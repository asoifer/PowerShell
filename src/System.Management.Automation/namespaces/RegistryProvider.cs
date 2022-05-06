// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using Microsoft.Win32;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using Dbg = System.Management.Automation;
using Microsoft.PowerShell.Commands.Internal;

namespace Microsoft.PowerShell.Commands
{
[CmdletProvider(RegistryProvider.ProviderName, ProviderCapabilities.ShouldProcess)]
    [OutputType(typeof(string), ProviderCmdlet = ProviderCmdlet.MoveItemProperty)]
    [OutputType(typeof(RegistryKey), typeof(string), ProviderCmdlet = ProviderCmdlet.GetChildItem)]
    [OutputType(typeof(RegistryKey), ProviderCmdlet = ProviderCmdlet.GetItem)]
    [OutputType(typeof(System.Security.AccessControl.RegistrySecurity), ProviderCmdlet = ProviderCmdlet.GetAcl)]
    [OutputType(typeof(Microsoft.Win32.RegistryKey), ProviderCmdlet = ProviderCmdlet.GetChildItem)]
    [OutputType(typeof(RegistryKey), ProviderCmdlet = ProviderCmdlet.GetItem)]
    [OutputType(typeof(RegistryKey), typeof(string), typeof(Int32), typeof(Int64), ProviderCmdlet = ProviderCmdlet.GetItemProperty)]
    [OutputType(typeof(RegistryKey), ProviderCmdlet = ProviderCmdlet.NewItem)]
    public sealed partial class RegistryProvider :
        NavigationCmdletProvider,
        IPropertyCmdletProvider,
        IDynamicPropertyCmdletProvider,
        ISecurityDescriptorCmdletProvider
{
[Dbg.TraceSourceAttribute(
            "RegistryProvider",
            "The namespace navigation provider for the Windows Registry")]
        private static Dbg.PSTraceSource s_tracer ;

public const string 
ProviderName = "Registry"
;

public override char AltItemSeparator {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,4185,4201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,4188,4201);
return f_1209_4188_4201();DynAbs.Tracing.TraceSender.TraceExitMethod(1209,4185,4201);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,4185,4201);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,4185,4201);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override PSDriveInfo NewDrive(PSDriveInfo drive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,4800,5420);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,4883,5003) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,4883,5003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,4934,4988);

throw f_1209_4940_4987("drive");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,4883,5003);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,5019,5380) || true) && (!f_1209_5024_5046(this, f_1209_5035_5045(drive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,5019,5380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,5080,5166);

Exception 
e = f_1209_5094_5165(f_1209_5116_5164())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,5184,5365);

f_1209_5184_5364(this, f_1209_5195_5363(e, f_1209_5257_5277(f_1209_5257_5268(                    e)), ErrorCategory.InvalidArgument, f_1209_5352_5362(drive)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,5019,5380);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,5396,5409);

return drive;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,4800,5420);

System.Management.Automation.PSArgumentNullException
f_1209_4940_4987(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 4940, 4987);
return return_v;
}


string
f_1209_5035_5045(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 5035, 5045);
return return_v;
}


bool
f_1209_5024_5046(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 5024, 5046);
return return_v;
}


string
f_1209_5116_5164()
{
var return_v = RegistryProviderStrings.NewDriveRootDoesNotExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 5116, 5164);
return return_v;
}


System.ArgumentException
f_1209_5094_5165(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 5094, 5165);
return return_v;
}


System.Type
f_1209_5257_5268(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 5257, 5268);
return return_v;
}


string
f_1209_5257_5277(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 5257, 5277);
return return_v;
}


string
f_1209_5352_5362(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 5352, 5362);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_5195_5363(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 5195, 5363);
return return_v;
}


int
f_1209_5184_5364(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 5184, 5364);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,4800,5420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,4800,5420);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override Collection<PSDriveInfo> InitializeDefaultDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,6058,6782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,6151,6214);

Collection<PSDriveInfo> 
drives = f_1209_6184_6213()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,6230,6478);

f_1209_6230_6477(
            drives, f_1209_6259_6476("HKLM", f_1209_6326_6338(), "HKEY_LOCAL_MACHINE", f_1209_6404_6448(), null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,6494,6741);

f_1209_6494_6740(
            drives, f_1209_6523_6739("HKCU", f_1209_6590_6602(), "HKEY_CURRENT_USER", f_1209_6667_6711(), null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,6757,6771);

return drives;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,6058,6782);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1209_6184_6213()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 6184, 6213);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1209_6326_6338()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 6326, 6338);
return return_v;
}


string
f_1209_6404_6448()
{
var return_v =                     RegistryProviderStrings.HKLMDriveDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 6404, 6448);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1209_6259_6476(string
name,System.Management.Automation.ProviderInfo
provider,string
root,string
description,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.PSDriveInfo( name, provider, root, description, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 6259, 6476);
return return_v;
}


int
f_1209_6230_6477(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 6230, 6477);
return 0;
}


System.Management.Automation.ProviderInfo
f_1209_6590_6602()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 6590, 6602);
return return_v;
}


string
f_1209_6667_6711()
{
var return_v =                     RegistryProviderStrings.HKCUDriveDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 6667, 6711);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1209_6523_6739(string
name,System.Management.Automation.ProviderInfo
provider,string
root,string
description,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.PSDriveInfo( name, provider, root, description, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 6523, 6739);
return return_v;
}


int
f_1209_6494_6740(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 6494, 6740);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,6058,6782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,6058,6782);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool IsValidPath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,7244,8505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7317,7336);

bool 
result = true
;
{try {
do // false loop

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,7352,8464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7587,7621);

string 
root = f_1209_7601_7620(this, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7639,7698);

root = f_1209_7646_7697(root, StringLiterals.DefaultPathSeparator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7716,7773);

root = f_1209_7723_7772(root, StringLiterals.DefaultPathSeparator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7793,7863);

int 
pathSeparator = f_1209_7813_7862(root, StringLiterals.DefaultPathSeparator)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7883,8007) || true) && (pathSeparator != -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,7883,8007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7948,7988);

root = f_1209_7955_7987(root, 0, pathSeparator);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,7883,8007);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,8027,8309) || true) && (f_1209_8031_8057(root))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,8027,8309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,8248,8262);

result = true;
DynAbs.Tracing.TraceSender.TraceBreak(1209,8284,8290);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,8027,8309);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,8329,8434) || true) && (f_1209_8333_8350(this, root)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,8329,8434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,8400,8415);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,8329,8434);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,7352,8464);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,7352,8464) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,7352,8464);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,7352,8464);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,8480,8494);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,7244,8505);

string
f_1209_7601_7620(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 7601, 7620);
return return_v;
}


string
f_1209_7646_7697(string
this_param,char
trimChar)
{
var return_v = this_param.TrimStart( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 7646, 7697);
return return_v;
}


string
f_1209_7723_7772(string
this_param,char
trimChar)
{
var return_v = this_param.TrimEnd( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 7723, 7772);
return return_v;
}


int
f_1209_7813_7862(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 7813, 7862);
return return_v;
}


string
f_1209_7955_7987(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 7955, 7987);
return return_v;
}


bool
f_1209_8031_8057(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 8031, 8057);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_8333_8350(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetHiveRoot( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 8333, 8350);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,7244,8505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,7244,8505);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void GetItem(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,8900,9271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,9009,9077);

IRegistryWrapper 
result = f_1209_9035_9076(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,9093,9167) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,9093,9167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,9145,9152);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,9093,9167);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,9222,9260);

f_1209_9222_9259(this, result, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,8900,9271);

Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_9035_9076(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 9035, 9076);
return return_v;
}


int
f_1209_9222_9259(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path)
{
this_param.WriteRegistryItemObject( key, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 9222, 9259);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,8900,9271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,8900,9271);
}
		}

protected override void SetItem(string path, object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,9714,15416);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,9797,9925) || true) && (f_1209_9801_9827(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,9797,9925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,9861,9910);

throw f_1209_9867_9909("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,9797,9925);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,9994,10048);

string 
action = f_1209_10010_10047()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10064,10138);

string 
resourceTemplate = f_1209_10090_10137()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10154,10340);

string 
resource =
f_1209_10189_10339(f_1209_10225_10244(f_1209_10225_10229()), resourceTemplate, path, value)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10356,15405) || true) && (f_1209_10360_10391(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,10356,15405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10469,10533);

IRegistryWrapper 
key = f_1209_10492_10532(this, path, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10553,10636) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,10553,10636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10610,10617);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,10553,10636);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10729,10751);

bool 
valueSet = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10769,13290) || true) && (f_1209_10773_10790()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,10769,13290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,10840,10978);

RegistryProviderSetItemDynamicParameter 
dynParams =
f_1209_10917_10934()as RegistryProviderSetItemDynamicParameter
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11002,13271) || true) && (dynParams != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,11002,13271);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11212,11252);

RegistryValueKind 
kind = f_1209_11237_11251(dynParams)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11284,11316);

f_1209_11284_11315(
                            key, null, value, kind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11346,11362);

valueSet = true;
                        }
                        catch (ArgumentException argException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,11415,11728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11510,11622);

f_1209_11510_11621(this, f_1209_11521_11620(argException, f_1209_11551_11582(f_1209_11551_11573(argException)), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11652,11664);

f_1209_11652_11663(                            key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11694,11701);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,11415,11728);
                        }
                        catch (System.IO.IOException ioException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,11754,12201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,11990,12095);

f_1209_11990_12094(this, f_1209_12001_12093(ioException, f_1209_12030_12060(f_1209_12030_12051(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,12125,12137);

f_1209_12125_12136(                            key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,12167,12174);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,11754,12201);
                        }
                        catch (System.Security.SecurityException securityException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,12227,12710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,12481,12604);

f_1209_12481_12603(this, f_1209_12492_12602(securityException, f_1209_12527_12563(f_1209_12527_12554(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,12634,12646);

f_1209_12634_12645(                            key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,12676,12683);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,12227,12710);
                        }
                        catch (System.UnauthorizedAccessException unauthorizedAccessException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,12736,13248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,12999,13142);

f_1209_12999_13141(this, f_1209_13010_13140(unauthorizedAccessException, f_1209_13055_13101(f_1209_13055_13092(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,13172,13184);

f_1209_13172_13183(                            key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,13214,13221);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,12736,13248);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,11002,13271);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,10769,13290);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,13310,14953) || true) && (!valueSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,13310,14953);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,13459,13485);

f_1209_13459_13484(                        // Set the value
                        key, null, value);
                    }
                    catch (System.IO.IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,13530,13949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,13750,13855);

f_1209_13750_13854(this, f_1209_13761_13853(ioException, f_1209_13790_13820(f_1209_13790_13811(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,13881,13893);

f_1209_13881_13892(                        key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,13919,13926);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,13530,13949);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,13971,14426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,14209,14332);

f_1209_14209_14331(this, f_1209_14220_14330(securityException, f_1209_14255_14291(f_1209_14255_14282(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,14358,14370);

f_1209_14358_14369(                        key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,14396,14403);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,13971,14426);
                    }
                    catch (System.UnauthorizedAccessException unauthorizedAccessException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,14448,14934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,14697,14840);

f_1209_14697_14839(this, f_1209_14708_14838(unauthorizedAccessException, f_1209_14753_14799(f_1209_14753_14790(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,14866,14878);

f_1209_14866_14877(                        key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,14904,14911);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,14448,14934);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,13310,14953);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,15014,15036);

object 
result = value
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,15262,15303);

result = f_1209_15271_15302(key, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,15321,15333);

f_1209_15321_15332(                key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,15353,15390);

f_1209_15353_15389(this, result, path, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,10356,15405);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,9714,15416);

bool
f_1209_9801_9827(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 9801, 9827);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_9867_9909(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 9867, 9909);
return return_v;
}


string
f_1209_10010_10047()
{
var return_v = RegistryProviderStrings.SetItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 10010, 10047);
return return_v;
}


string
f_1209_10090_10137()
{
var return_v = RegistryProviderStrings.SetItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 10090, 10137);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_10225_10229()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 10225, 10229);
return return_v;
}


System.Globalization.CultureInfo
f_1209_10225_10244(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 10225, 10244);
return return_v;
}


string
f_1209_10189_10339(System.Globalization.CultureInfo
provider,string
format,string
arg0,object
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 10189, 10339);
return return_v;
}


bool
f_1209_10360_10391(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 10360, 10391);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_10492_10532(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 10492, 10532);
return return_v;
}


object
f_1209_10773_10790()
{
var return_v = DynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 10773, 10790);
return return_v;
}


object
f_1209_10917_10934()
{
var return_v = DynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 10917, 10934);
return return_v;
}


Microsoft.Win32.RegistryValueKind
f_1209_11237_11251(Microsoft.PowerShell.Commands.RegistryProviderSetItemDynamicParameter
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 11237, 11251);
return return_v;
}


int
f_1209_11284_11315(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
value,Microsoft.Win32.RegistryValueKind
valueKind)
{
this_param.SetValue( name, value, valueKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 11284, 11315);
return 0;
}


System.Type
f_1209_11551_11573(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 11551, 11573);
return return_v;
}


string
f_1209_11551_11582(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 11551, 11582);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_11521_11620(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 11521, 11620);
return return_v;
}


int
f_1209_11510_11621(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 11510, 11621);
return 0;
}


int
f_1209_11652_11663(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 11652, 11663);
return 0;
}


System.Type
f_1209_12030_12051(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12030, 12051);
return return_v;
}


string
f_1209_12030_12060(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 12030, 12060);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_12001_12093(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12001, 12093);
return return_v;
}


int
f_1209_11990_12094(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 11990, 12094);
return 0;
}


int
f_1209_12125_12136(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12125, 12136);
return 0;
}


System.Type
f_1209_12527_12554(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12527, 12554);
return return_v;
}


string
f_1209_12527_12563(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 12527, 12563);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_12492_12602(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12492, 12602);
return return_v;
}


int
f_1209_12481_12603(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12481, 12603);
return 0;
}


int
f_1209_12634_12645(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12634, 12645);
return 0;
}


System.Type
f_1209_13055_13092(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13055, 13092);
return return_v;
}


string
f_1209_13055_13101(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 13055, 13101);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_13010_13140(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13010, 13140);
return return_v;
}


int
f_1209_12999_13141(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 12999, 13141);
return 0;
}


int
f_1209_13172_13183(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13172, 13183);
return 0;
}


int
f_1209_13459_13484(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
value)
{
this_param.SetValue( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13459, 13484);
return 0;
}


System.Type
f_1209_13790_13811(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13790, 13811);
return return_v;
}


string
f_1209_13790_13820(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 13790, 13820);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_13761_13853(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13761, 13853);
return return_v;
}


int
f_1209_13750_13854(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13750, 13854);
return 0;
}


int
f_1209_13881_13892(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 13881, 13892);
return 0;
}


System.Type
f_1209_14255_14282(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14255, 14282);
return return_v;
}


string
f_1209_14255_14291(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 14255, 14291);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_14220_14330(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14220, 14330);
return return_v;
}


int
f_1209_14209_14331(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14209, 14331);
return 0;
}


int
f_1209_14358_14369(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14358, 14369);
return 0;
}


System.Type
f_1209_14753_14790(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14753, 14790);
return return_v;
}


string
f_1209_14753_14799(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 14753, 14799);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_14708_14838(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14708, 14838);
return return_v;
}


int
f_1209_14697_14839(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14697, 14839);
return 0;
}


int
f_1209_14866_14877(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 14866, 14877);
return 0;
}


object
f_1209_15271_15302(Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
valueName)
{
var return_v = ReadExistingKeyValue( key, valueName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 15271, 15302);
return return_v;
}


int
f_1209_15321_15332(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 15321, 15332);
return 0;
}


int
f_1209_15353_15389(Microsoft.PowerShell.Commands.RegistryProvider
this_param,object
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 15353, 15389);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,9714,15416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,9714,15416);
}
		}

protected override object SetItemDynamicParameters(string path, object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,15918,16084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,16020,16073);

return f_1209_16027_16072();
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,15918,16084);

Microsoft.PowerShell.Commands.RegistryProviderSetItemDynamicParameter
f_1209_16027_16072()
{
var return_v = new Microsoft.PowerShell.Commands.RegistryProviderSetItemDynamicParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 16027, 16072);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,15918,16084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,15918,16084);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void ClearItem(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,16696,20598);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,16767,16895) || true) && (f_1209_16771_16797(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,16767,16895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,16831,16880);

throw f_1209_16837_16879("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,16767,16895);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,16966,17022);

string 
action = f_1209_16982_17021()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17038,17114);

string 
resourceTemplate = f_1209_17064_17113()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17130,17288);

string 
resource =
f_1209_17165_17287(f_1209_17201_17220(f_1209_17201_17205()), resourceTemplate, path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17304,20587) || true) && (f_1209_17308_17339(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,17304,20587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17417,17481);

IRegistryWrapper 
key = f_1209_17440_17480(this, path, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17501,17584) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,17501,17584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17558,17565);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,17501,17584);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17604,17624);

string[] 
valueNames
=default(string[]);

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,17730,17763);

valueNames = f_1209_17743_17762(key);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,17800,18156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,18004,18108);

f_1209_18004_18107(this, f_1209_18015_18106(ioException, f_1209_18044_18074(f_1209_18044_18065(ioException)), ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,18130,18137);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,17800,18156);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,18174,18567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,18396,18519);

f_1209_18396_18518(this, f_1209_18407_18517(securityException, f_1209_18442_18478(f_1209_18442_18469(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,18541,18548);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,18174,18567);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,18585,19009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,18818,18961);

f_1209_18818_18960(this, f_1209_18829_18959(unauthorizedAccessException, f_1209_18874_18920(f_1209_18874_18911(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,18983,18990);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,18585,19009);
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,19038,19047);

                for (int 
index = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,19029,20477) || true) && (index < f_1209_19057_19074(valueNames))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,19076,19083)
,++index,DynAbs.Tracing.TraceSender.TraceExitCondition(1209,19029,20477))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,19029,20477);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,19177,19212);

f_1209_19177_19211(                        key, valueNames[index]);
                    }
                    catch (System.IO.IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,19257,19610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,19482,19587);

f_1209_19482_19586(this, f_1209_19493_19585(ioException, f_1209_19522_19552(f_1209_19522_19543(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,19257,19610);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,19632,20021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,19875,19998);

f_1209_19875_19997(this, f_1209_19886_19996(securityException, f_1209_19921_19957(f_1209_19921_19948(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,19632,20021);
                    }
                    catch (System.UnauthorizedAccessException unauthorizedAccessException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,20043,20458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,20292,20435);

f_1209_20292_20434(this, f_1209_20303_20433(unauthorizedAccessException, f_1209_20348_20394(f_1209_20348_20385(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,20043,20458);
                    }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,1449);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,1449);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,20537,20572);

f_1209_20537_20571(this, key, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,17304,20587);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,16696,20598);

bool
f_1209_16771_16797(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 16771, 16797);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_16837_16879(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 16837, 16879);
return return_v;
}


string
f_1209_16982_17021()
{
var return_v = RegistryProviderStrings.ClearItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 16982, 17021);
return return_v;
}


string
f_1209_17064_17113()
{
var return_v = RegistryProviderStrings.ClearItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 17064, 17113);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_17201_17205()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 17201, 17205);
return return_v;
}


System.Globalization.CultureInfo
f_1209_17201_17220(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 17201, 17220);
return return_v;
}


string
f_1209_17165_17287(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 17165, 17287);
return return_v;
}


bool
f_1209_17308_17339(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 17308, 17339);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_17440_17480(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 17440, 17480);
return return_v;
}


string[]
f_1209_17743_17762(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetValueNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 17743, 17762);
return return_v;
}


System.Type
f_1209_18044_18065(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18044, 18065);
return return_v;
}


string
f_1209_18044_18074(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 18044, 18074);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_18015_18106(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18015, 18106);
return return_v;
}


int
f_1209_18004_18107(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18004, 18107);
return 0;
}


System.Type
f_1209_18442_18469(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18442, 18469);
return return_v;
}


string
f_1209_18442_18478(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 18442, 18478);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_18407_18517(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18407, 18517);
return return_v;
}


int
f_1209_18396_18518(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18396, 18518);
return 0;
}


System.Type
f_1209_18874_18911(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18874, 18911);
return return_v;
}


string
f_1209_18874_18920(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 18874, 18920);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_18829_18959(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18829, 18959);
return return_v;
}


int
f_1209_18818_18960(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 18818, 18960);
return 0;
}


int
f_1209_19057_19074(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 19057, 19074);
return return_v;
}


int
f_1209_19177_19211(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
this_param.DeleteValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 19177, 19211);
return 0;
}


System.Type
f_1209_19522_19543(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 19522, 19543);
return return_v;
}


string
f_1209_19522_19552(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 19522, 19552);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_19493_19585(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 19493, 19585);
return return_v;
}


int
f_1209_19482_19586(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 19482, 19586);
return 0;
}


System.Type
f_1209_19921_19948(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 19921, 19948);
return return_v;
}


string
f_1209_19921_19957(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 19921, 19957);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_19886_19996(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 19886, 19996);
return return_v;
}


int
f_1209_19875_19997(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 19875, 19997);
return 0;
}


System.Type
f_1209_20348_20385(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 20348, 20385);
return return_v;
}


string
f_1209_20348_20394(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 20348, 20394);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_20303_20433(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 20303, 20433);
return return_v;
}


int
f_1209_20292_20434(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 20292, 20434);
return 0;
}


int
f_1209_20537_20571(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path)
{
this_param.WriteRegistryItemObject( key, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 20537, 20571);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,16696,20598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,16696,20598);
}
		}

protected override void GetChildItems(
            string path,
            bool recurse,
            uint depth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,21426,27522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,21567,21632);

f_1209_21567_21631(            s_tracer, "recurse = {0}, depth = {1}", recurse, depth);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,21648,21766) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,21648,21766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,21698,21751);

throw f_1209_21704_21750("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,21648,21766);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,21782,27511) || true) && (f_1209_21786_21807(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,21782,27511);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,21922,22220);
foreach(string hiveName in f_1209_21950_21961_I(s_hiveNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,21922,22220);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22067,22159) || true) && (f_1209_22071_22079())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,22067,22159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22129,22136);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,22067,22159);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22183,22201);

f_1209_22183_22200(this, hiveName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,21922,22220);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,299);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,299);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1209,21782,27511);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,21782,27511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22342,22407);

IRegistryWrapper 
key = f_1209_22365_22406(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22427,22510) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,22427,22510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22484,22491);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,22427,22510);
}

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22642,22683);

string[] 
keyNames = f_1209_22662_22682(key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22705,22717);

f_1209_22705_22716(                    key);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22741,26337) || true) && (keyNames != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,22741,26337);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22811,26314);
foreach(string subkeyName in f_1209_22841_22849_I(keyNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,22811,26314);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,22979,23095) || true) && (f_1209_22983_22991())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,22979,23095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,23057,23064);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,22979,23095);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,23127,26287) || true) && (!f_1209_23132_23164(subkeyName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,23127,26287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,23230,23252);

string 
keypath = path
;

                                try
                                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,23442,23498);

keypath = f_1209_23452_23497(this, path, subkeyName, childIsLeaf: true);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,23538,24784) || true) && (!f_1209_23543_23572(keypath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,23538,24784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,23832,23894);

IRegistryWrapper 
resultKey = f_1209_23861_23893(this, keypath, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,23938,24136) || true) && (resultKey != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,23938,24136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,24049,24093);

f_1209_24049_24092(this, resultKey, keypath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,23938,24136);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,24251,24745) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,24251,24745);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,24422,24702) || true) && (depth > 0)
) // this includes special case 'depth == uint.MaxValue' for unlimited recursion

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,24422,24702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,24612,24655);

f_1209_24612_24654(this, keypath, recurse, depth - 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,24422,24702);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,24251,24745);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,23538,24784);
}
                                }
                                catch (System.IO.IOException ioException)
                                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,24853,25263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,25121,25228);

f_1209_25121_25227(this, f_1209_25132_25226(ioException, f_1209_25161_25191(f_1209_25161_25182(ioException)), ErrorCategory.ReadError, keypath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,24853,25263);
                                }
                                catch (System.Security.SecurityException securityException)
                                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,25297,25744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,25583,25709);

f_1209_25583_25708(this, f_1209_25594_25707(securityException, f_1209_25629_25665(f_1209_25629_25656(securityException)), ErrorCategory.PermissionDenied, keypath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,25297,25744);
                                }
                                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,25778,26256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,26075,26221);

f_1209_26075_26220(this, f_1209_26086_26219(unauthorizedAccessException, f_1209_26131_26177(f_1209_26131_26168(unauthorizedAccessException)), ErrorCategory.PermissionDenied, keypath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,25778,26256);
                                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,23127,26287);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,22811,26314);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,3504);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,3504);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1209,22741,26337);
}
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,26374,26701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,26578,26682);

f_1209_26578_26681(this, f_1209_26589_26680(ioException, f_1209_26618_26648(f_1209_26618_26639(ioException)), ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,26374,26701);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,26719,27083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,26941,27064);

f_1209_26941_27063(this, f_1209_26952_27062(securityException, f_1209_26987_27023(f_1209_26987_27014(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,26719,27083);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,27101,27496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,27334,27477);

f_1209_27334_27476(this, f_1209_27345_27475(unauthorizedAccessException, f_1209_27390_27436(f_1209_27390_27427(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,27101,27496);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,21782,27511);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,21426,27522);

int
f_1209_21567_21631(System.Management.Automation.PSTraceSource
this_param,string
format,bool
arg1,uint
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 21567, 21631);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1209_21704_21750(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 21704, 21750);
return return_v;
}


bool
f_1209_21786_21807(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.IsHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 21786, 21807);
return return_v;
}


bool
f_1209_22071_22079()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 22071, 22079);
return return_v;
}


int
f_1209_22183_22200(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
this_param.GetItem( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 22183, 22200);
return 0;
}


string[]
f_1209_21950_21961_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 21950, 21961);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_22365_22406(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 22365, 22406);
return return_v;
}


string[]
f_1209_22662_22682(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetSubKeyNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 22662, 22682);
return return_v;
}


int
f_1209_22705_22716(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 22705, 22716);
return 0;
}


bool
f_1209_22983_22991()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 22983, 22991);
return return_v;
}


bool
f_1209_23132_23164(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 23132, 23164);
return return_v;
}


string
f_1209_23452_23497(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child,bool
childIsLeaf)
{
var return_v = this_param.MakePath( parent, child, childIsLeaf: childIsLeaf);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 23452, 23497);
return return_v;
}


bool
f_1209_23543_23572(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 23543, 23572);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_23861_23893(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 23861, 23893);
return return_v;
}


int
f_1209_24049_24092(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path)
{
this_param.WriteRegistryItemObject( key, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 24049, 24092);
return 0;
}


int
f_1209_24612_24654(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
recurse,uint
depth)
{
this_param.GetChildItems( path, recurse, depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 24612, 24654);
return 0;
}


System.Type
f_1209_25161_25182(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 25161, 25182);
return return_v;
}


string
f_1209_25161_25191(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 25161, 25191);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_25132_25226(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 25132, 25226);
return return_v;
}


int
f_1209_25121_25227(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 25121, 25227);
return 0;
}


System.Type
f_1209_25629_25656(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 25629, 25656);
return return_v;
}


string
f_1209_25629_25665(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 25629, 25665);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_25594_25707(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 25594, 25707);
return return_v;
}


int
f_1209_25583_25708(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 25583, 25708);
return 0;
}


System.Type
f_1209_26131_26168(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26131, 26168);
return return_v;
}


string
f_1209_26131_26177(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 26131, 26177);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_26086_26219(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26086, 26219);
return return_v;
}


int
f_1209_26075_26220(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26075, 26220);
return 0;
}


string[]
f_1209_22841_22849_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 22841, 22849);
return return_v;
}


System.Type
f_1209_26618_26639(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26618, 26639);
return return_v;
}


string
f_1209_26618_26648(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 26618, 26648);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_26589_26680(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26589, 26680);
return return_v;
}


int
f_1209_26578_26681(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26578, 26681);
return 0;
}


System.Type
f_1209_26987_27014(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26987, 27014);
return return_v;
}


string
f_1209_26987_27023(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 26987, 27023);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_26952_27062(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26952, 27062);
return return_v;
}


int
f_1209_26941_27063(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 26941, 27063);
return 0;
}


System.Type
f_1209_27390_27427(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 27390, 27427);
return return_v;
}


string
f_1209_27390_27436(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 27390, 27436);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_27345_27475(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 27345, 27475);
return return_v;
}


int
f_1209_27334_27476(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 27334, 27476);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,21426,27522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,21426,27522);
}
		}

protected override void GetChildNames(
            string path,
            ReturnContainers returnContainers)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,28158,31181);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28295,28413) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,28295,28413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28345,28398);

throw f_1209_28351_28397("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,28295,28413);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28429,31170) || true) && (f_1209_28433_28444(path)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,28429,31170);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28553,28875);
foreach(string hiveName in f_1209_28581_28592_I(s_hiveNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,28553,28875);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28698,28790) || true) && (f_1209_28702_28710())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,28698,28790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28760,28767);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,28698,28790);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28814,28856);

f_1209_28814_28855(this, hiveName, hiveName, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,28553,28875);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,323);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,323);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1209,28429,31170);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,28429,31170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,28997,29062);

IRegistryWrapper 
key = f_1209_29020_29061(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29082,29165) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,29082,29165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29139,29146);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,29082,29165);
}

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29279,29319);

string[] 
results = f_1209_29298_29318(key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29341,29353);

f_1209_29341_29352(                    key);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29468,29477);

                    // Write the child key names to the WriteItemObject method

                    for (int 
index = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29459,29996) || true) && (index < f_1209_29487_29501(results))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29503,29510)
,++index,DynAbs.Tracing.TraceSender.TraceExitCondition(1209,29459,29996))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,29459,29996);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29628,29732) || true) && (f_1209_29632_29640())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,29628,29732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29698,29705);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,29628,29732);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29760,29811);

string 
childName = f_1209_29779_29810(results[index])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29837,29901);

string 
childPath = f_1209_29856_29900(this, path, childName, childIsLeaf: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,29929,29973);

f_1209_29929_29972(this, childName, childPath, true);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,538);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,538);
}                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,30033,30360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,30237,30341);

f_1209_30237_30340(this, f_1209_30248_30339(ioException, f_1209_30277_30307(f_1209_30277_30298(ioException)), ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,30033,30360);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,30378,30742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,30600,30723);

f_1209_30600_30722(this, f_1209_30611_30721(securityException, f_1209_30646_30682(f_1209_30646_30673(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,30378,30742);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,30760,31155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,30993,31136);

f_1209_30993_31135(this, f_1209_31004_31134(unauthorizedAccessException, f_1209_31049_31095(f_1209_31049_31086(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,30760,31155);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,28429,31170);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,28158,31181);

System.Management.Automation.PSArgumentNullException
f_1209_28351_28397(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 28351, 28397);
return return_v;
}


int
f_1209_28433_28444(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 28433, 28444);
return return_v;
}


bool
f_1209_28702_28710()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 28702, 28710);
return return_v;
}


int
f_1209_28814_28855(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( (object)item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 28814, 28855);
return 0;
}


string[]
f_1209_28581_28592_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 28581, 28592);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_29020_29061(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 29020, 29061);
return return_v;
}


string[]
f_1209_29298_29318(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetSubKeyNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 29298, 29318);
return return_v;
}


int
f_1209_29341_29352(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 29341, 29352);
return 0;
}


int
f_1209_29487_29501(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 29487, 29501);
return return_v;
}


bool
f_1209_29632_29640()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 29632, 29640);
return return_v;
}


string
f_1209_29779_29810(string
name)
{
var return_v = EscapeChildName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 29779, 29810);
return return_v;
}


string
f_1209_29856_29900(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child,bool
childIsLeaf)
{
var return_v = this_param.MakePath( parent, child, childIsLeaf: childIsLeaf);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 29856, 29900);
return return_v;
}


int
f_1209_29929_29972(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( (object)item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 29929, 29972);
return 0;
}


System.Type
f_1209_30277_30298(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 30277, 30298);
return return_v;
}


string
f_1209_30277_30307(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 30277, 30307);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_30248_30339(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 30248, 30339);
return return_v;
}


int
f_1209_30237_30340(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 30237, 30340);
return 0;
}


System.Type
f_1209_30646_30673(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 30646, 30673);
return return_v;
}


string
f_1209_30646_30682(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 30646, 30682);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_30611_30721(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 30611, 30721);
return return_v;
}


int
f_1209_30600_30722(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 30600, 30722);
return 0;
}


System.Type
f_1209_31049_31086(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 31049, 31086);
return return_v;
}


string
f_1209_31049_31095(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 31049, 31095);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_31004_31134(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 31004, 31134);
return return_v;
}


int
f_1209_30993_31135(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 30993, 31135);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,28158,31181);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,28158,31181);
}
		}

private const string 
charactersThatNeedEscaping = ".*?[]:"
;

private static string EscapeSpecialChars(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1209,31714,33258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,31792,31835);

StringBuilder 
result = f_1209_31815_31834()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,31987,32127);

System.Globalization.TextElementEnumerator 
textEnumerator =
f_1209_32064_32126(path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,32143,32319);

f_1209_32143_32318(textEnumerator != null, f_1209_32225_32317(f_1209_32239_32265(), "Cannot get a text enumerator for name {0}", path));
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,32335,33206) || true) && (f_1209_32342_32367(textEnumerator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,32335,33206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,32514,32567);

string 
textElement = f_1209_32535_32566(textEnumerator)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,32955,33144) || true) && (f_1209_32959_33007(textElement, charactersThatNeedEscaping))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,32955,33144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,33106,33125);

f_1209_33106_33124(                    // This text element needs espacing
                    result, "`");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,32955,33144);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,33164,33191);

f_1209_33164_33190(
                result, textElement);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,32335,33206);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,32335,33206);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,32335,33206);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,33222,33247);

return f_1209_33229_33246(result);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1209,31714,33258);

System.Text.StringBuilder
f_1209_31815_31834()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 31815, 31834);
return return_v;
}


System.Globalization.TextElementEnumerator
f_1209_32064_32126(string
str)
{
var return_v = System.Globalization.StringInfo.GetTextElementEnumerator( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 32064, 32126);
return return_v;
}


System.Globalization.CultureInfo
f_1209_32239_32265()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 32239, 32265);
return return_v;
}


string
f_1209_32225_32317(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 32225, 32317);
return return_v;
}


int
f_1209_32143_32318(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 32143, 32318);
return 0;
}


bool
f_1209_32342_32367(System.Globalization.TextElementEnumerator
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 32342, 32367);
return return_v;
}


string
f_1209_32535_32566(System.Globalization.TextElementEnumerator
this_param)
{
var return_v = this_param.GetTextElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 32535, 32566);
return return_v;
}


bool
f_1209_32959_33007(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 32959, 33007);
return return_v;
}


System.Text.StringBuilder
f_1209_33106_33124(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 33106, 33124);
return return_v;
}


System.Text.StringBuilder
f_1209_33164_33190(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 33164, 33190);
return return_v;
}


string
f_1209_33229_33246(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 33229, 33246);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,31714,33258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,31714,33258);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string EscapeChildName(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1209,33720,35261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,33795,33838);

StringBuilder 
result = f_1209_33818_33837()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,33990,34130);

System.Globalization.TextElementEnumerator 
textEnumerator =
f_1209_34067_34129(name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,34146,34322);

f_1209_34146_34321(textEnumerator != null, f_1209_34228_34320(f_1209_34242_34268(), "Cannot get a text enumerator for name {0}", name));
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,34338,35209) || true) && (f_1209_34345_34370(textEnumerator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,34338,35209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,34517,34570);

string 
textElement = f_1209_34538_34569(textEnumerator)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,34958,35147) || true) && (f_1209_34962_35010(textElement, charactersThatNeedEscaping))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,34958,35147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,35109,35128);

f_1209_35109_35127(                    // This text element needs espacing
                    result, "`");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,34958,35147);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,35167,35194);

f_1209_35167_35193(
                result, textElement);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,34338,35209);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,34338,35209);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,34338,35209);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,35225,35250);

return f_1209_35232_35249(result);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1209,33720,35261);

System.Text.StringBuilder
f_1209_33818_33837()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 33818, 33837);
return return_v;
}


System.Globalization.TextElementEnumerator
f_1209_34067_34129(string
str)
{
var return_v = System.Globalization.StringInfo.GetTextElementEnumerator( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 34067, 34129);
return return_v;
}


System.Globalization.CultureInfo
f_1209_34242_34268()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 34242, 34268);
return return_v;
}


string
f_1209_34228_34320(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 34228, 34320);
return return_v;
}


int
f_1209_34146_34321(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 34146, 34321);
return 0;
}


bool
f_1209_34345_34370(System.Globalization.TextElementEnumerator
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 34345, 34370);
return return_v;
}


string
f_1209_34538_34569(System.Globalization.TextElementEnumerator
this_param)
{
var return_v = this_param.GetTextElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 34538, 34569);
return return_v;
}


bool
f_1209_34962_35010(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 34962, 35010);
return return_v;
}


System.Text.StringBuilder
f_1209_35109_35127(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 35109, 35127);
return return_v;
}


System.Text.StringBuilder
f_1209_35167_35193(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 35167, 35193);
return return_v;
}


string
f_1209_35232_35249(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 35232, 35249);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,33720,35261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,33720,35261);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void RenameItem(
            string path,
            string newName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,35616,37326);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,35731,35859) || true) && (f_1209_35735_35761(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,35731,35859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,35795,35844);

throw f_1209_35801_35843("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,35731,35859);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,35875,36009) || true) && (f_1209_35879_35908(newName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,35875,36009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,35942,35994);

throw f_1209_35948_35993("newName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,35875,36009);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36025,36070);

f_1209_36025_36069(
            s_tracer, "newName = {0}", newName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36086,36132);

string 
parentPath = f_1209_36106_36131(this, path, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36146,36193);

string 
newPath = f_1209_36163_36192(this, parentPath, newName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36283,36317);

bool 
exists = f_1209_36297_36316(this, newPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36333,36700) || true) && (exists)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,36333,36700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36377,36462);

Exception 
e = f_1209_36391_36461(f_1209_36413_36460())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36480,36658);

f_1209_36480_36657(this, f_1209_36491_36656(e, f_1209_36553_36573(f_1209_36553_36564(                    e)), ErrorCategory.InvalidArgument, newPath));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36678,36685);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,36333,36700);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36770,36827);

string 
action = f_1209_36786_36826()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36843,36920);

string 
resourceTemplate = f_1209_36869_36919()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,36936,37124);

string 
resource =
f_1209_36971_37123(f_1209_37007_37026(f_1209_37007_37011()), resourceTemplate, path, newPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,37140,37315) || true) && (f_1209_37144_37175(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,37140,37315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,37268,37300);

f_1209_37268_37299(this, path, newPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,37140,37315);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,35616,37326);

bool
f_1209_35735_35761(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 35735, 35761);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_35801_35843(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 35801, 35843);
return return_v;
}


bool
f_1209_35879_35908(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 35879, 35908);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_35948_35993(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 35948, 35993);
return return_v;
}


int
f_1209_36025_36069(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36025, 36069);
return 0;
}


string
f_1209_36106_36131(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36106, 36131);
return return_v;
}


string
f_1209_36163_36192(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36163, 36192);
return return_v;
}


bool
f_1209_36297_36316(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36297, 36316);
return return_v;
}


string
f_1209_36413_36460()
{
var return_v = RegistryProviderStrings.RenameItemAlreadyExists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 36413, 36460);
return return_v;
}


System.ArgumentException
f_1209_36391_36461(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36391, 36461);
return return_v;
}


System.Type
f_1209_36553_36564(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36553, 36564);
return return_v;
}


string
f_1209_36553_36573(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 36553, 36573);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_36491_36656(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36491, 36656);
return return_v;
}


int
f_1209_36480_36657(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36480, 36657);
return 0;
}


string
f_1209_36786_36826()
{
var return_v = RegistryProviderStrings.RenameItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 36786, 36826);
return return_v;
}


string
f_1209_36869_36919()
{
var return_v = RegistryProviderStrings.RenameItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 36869, 36919);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_37007_37011()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 37007, 37011);
return return_v;
}


System.Globalization.CultureInfo
f_1209_37007_37026(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 37007, 37026);
return return_v;
}


string
f_1209_36971_37123(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 36971, 37123);
return return_v;
}


bool
f_1209_37144_37175(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 37144, 37175);
return return_v;
}


int
f_1209_37268_37299(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
destination)
{
this_param.MoveRegistryItem( path, destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 37268, 37299);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,35616,37326);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,35616,37326);
}
		}

protected override void NewItem(
            string path,
            string type,
            object newItem)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,37893,44169);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38031,38159) || true) && (f_1209_38035_38061(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,38031,38159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38095,38144);

throw f_1209_38101_38143("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,38031,38159);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38228,38282);

string 
action = f_1209_38244_38281()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38298,38372);

string 
resourceTemplate = f_1209_38324_38371()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38388,38546);

string 
resource =
f_1209_38423_38545(f_1209_38459_38478(f_1209_38459_38463()), resourceTemplate, path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38560,44158) || true) && (f_1209_38564_38595(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,38560,44158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38688,38747);

IRegistryWrapper 
resultKey = f_1209_38717_38746(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38767,39576) || true) && (resultKey != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,38767,39576);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38830,39557) || true) && (f_1209_38834_38840_M(!Force))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,38830,39557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38890,38972);

Exception 
e = f_1209_38904_38971(f_1209_38930_38970())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,38998,39209);

f_1209_38998_39208(this, f_1209_39009_39207(e, f_1209_39087_39107(f_1209_39087_39098(                            e)), ErrorCategory.ResourceExists, resultKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39237,39255);

f_1209_39237_39254(
                        resultKey);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39281,39288);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,38830,39557);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,38830,39557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39466,39484);

f_1209_39466_39483(                        // Remove the existing key before creating the new one
                        resultKey);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39510,39534);

f_1209_39510_39533(this, path, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,38830,39557);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,38767,39576);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39596,39863) || true) && (f_1209_39600_39605())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,39596,39863);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39647,39844) || true) && (!f_1209_39652_39680(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,39647,39844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39814,39821);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,39647,39844);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,39596,39863);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,39951,39997);

string 
parentPath = f_1209_39971_39996(this, path, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40015,40053);

string 
childName = f_1209_40034_40052(this, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40127,40197);

IRegistryWrapper 
key = f_1209_40150_40196(this, parentPath, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40217,40300) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,40217,40300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40274,40281);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,40217,40300);
}

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40410,40464);

IRegistryWrapper 
newKey = f_1209_40436_40463(key, childName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40486,40498);

f_1209_40486_40497(                    key);

                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40667,41057) || true) && (newItem != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,40667,41057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40744,40767);

RegistryValueKind 
kind
=default(RegistryValueKind);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40797,40931) || true) && (!f_1209_40802_40827(this, type, out kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,40797,40931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40893,40900);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,40797,40931);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,40963,41030);

f_1209_40963_41029(this, newKey, string.Empty, newItem, kind, path, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,40667,41057);
}
                    }
                    catch (Exception exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,41102,42386);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,41376,42363) || true) && ((exception is ArgumentException) ||(DynAbs.Tracing.TraceSender.Expression_False(1209, 41380, 41480)||                            (exception is InvalidCastException) )||(DynAbs.Tracing.TraceSender.Expression_False(1209, 41380, 41549)||                            (exception is System.IO.IOException) )||(DynAbs.Tracing.TraceSender.Expression_False(1209, 41380, 41630)||                            (exception is System.Security.SecurityException) )||(DynAbs.Tracing.TraceSender.Expression_False(1209, 41380, 41712)||                            (exception is System.UnauthorizedAccessException) )||(DynAbs.Tracing.TraceSender.Expression_False(1209, 41380, 41781)||                            (exception is NotSupportedException)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,41376,42363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,41839,42081);

ErrorRecord 
rec = f_1209_41857_42080(exception, f_1209_41951_41979(f_1209_41951_41970(                                exception)), ErrorCategory.WriteError, newKey)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,42111,42224);

rec.ErrorDetails = f_1209_42130_42223(f_1209_42147_42222(f_1209_42165_42210(), childName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,42254,42270);

f_1209_42254_42269(this, rec);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,41376,42363);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,41376,42363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,42357,42363);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,41376,42363);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,41102,42386);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,42457,42495);

f_1209_42457_42494(this, newKey, path);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,42532,42860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,42736,42841);

f_1209_42736_42840(this, f_1209_42747_42839(ioException, f_1209_42776_42806(f_1209_42776_42797(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,42532,42860);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,42878,43242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,43100,43223);

f_1209_43100_43222(this, f_1209_43111_43221(securityException, f_1209_43146_43182(f_1209_43146_43173(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,42878,43242);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,43260,43655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,43493,43636);

f_1209_43493_43635(this, f_1209_43504_43634(unauthorizedAccessException, f_1209_43549_43595(f_1209_43549_43586(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,43260,43655);
                }
                catch (ArgumentException argException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,43673,43883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,43752,43864);

f_1209_43752_43863(this, f_1209_43763_43862(argException, f_1209_43793_43824(f_1209_43793_43815(argException)), ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,43673,43883);
                }
                catch (NotSupportedException notSupportedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,43901,44143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,43993,44124);

f_1209_43993_44123(this, f_1209_44004_44122(notSupportedException, f_1209_44043_44083(f_1209_44043_44074(notSupportedException)), ErrorCategory.InvalidOperation, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,43901,44143);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,38560,44158);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,37893,44169);

bool
f_1209_38035_38061(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 38035, 38061);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_38101_38143(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 38101, 38143);
return return_v;
}


string
f_1209_38244_38281()
{
var return_v = RegistryProviderStrings.NewItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 38244, 38281);
return return_v;
}


string
f_1209_38324_38371()
{
var return_v = RegistryProviderStrings.NewItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 38324, 38371);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_38459_38463()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 38459, 38463);
return return_v;
}


System.Globalization.CultureInfo
f_1209_38459_38478(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 38459, 38478);
return return_v;
}


string
f_1209_38423_38545(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 38423, 38545);
return return_v;
}


bool
f_1209_38564_38595(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 38564, 38595);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_38717_38746(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 38717, 38746);
return return_v;
}


bool
f_1209_38834_38840_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 38834, 38840);
return return_v;
}


string
f_1209_38930_38970()
{
var return_v = RegistryProviderStrings.KeyAlreadyExists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 38930, 38970);
return return_v;
}


System.IO.IOException
f_1209_38904_38971(string
message)
{
var return_v = new System.IO.IOException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 38904, 38971);
return return_v;
}


System.Type
f_1209_39087_39098(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 39087, 39098);
return return_v;
}


string
f_1209_39087_39107(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 39087, 39107);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_39009_39207(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.IRegistryWrapper
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 39009, 39207);
return return_v;
}


int
f_1209_38998_39208(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 38998, 39208);
return 0;
}


int
f_1209_39237_39254(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 39237, 39254);
return 0;
}


int
f_1209_39466_39483(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 39466, 39483);
return 0;
}


int
f_1209_39510_39533(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
recurse)
{
this_param.RemoveItem( path, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 39510, 39533);
return 0;
}


System.Management.Automation.SwitchParameter
f_1209_39600_39605()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 39600, 39605);
return return_v;
}


bool
f_1209_39652_39680(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.CreateIntermediateKeys( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 39652, 39680);
return return_v;
}


string
f_1209_39971_39996(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 39971, 39996);
return return_v;
}


string
f_1209_40034_40052(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 40034, 40052);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_40150_40196(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 40150, 40196);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_40436_40463(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
subkey)
{
var return_v = this_param.CreateSubKey( subkey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 40436, 40463);
return return_v;
}


int
f_1209_40486_40497(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 40486, 40497);
return 0;
}


bool
f_1209_40802_40827(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
type,out Microsoft.Win32.RegistryValueKind
kind)
{
var return_v = this_param.ParseKind( type, out kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 40802, 40827);
return return_v;
}


int
f_1209_40963_41029(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
propertyName,object
value,Microsoft.Win32.RegistryValueKind
kind,string
path,bool
writeResult)
{
this_param.SetRegistryValue( key, propertyName, value, kind, path, writeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 40963, 41029);
return 0;
}


System.Type
f_1209_41951_41970(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 41951, 41970);
return return_v;
}


string
f_1209_41951_41979(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 41951, 41979);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_41857_42080(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.IRegistryWrapper
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 41857, 42080);
return return_v;
}


string
f_1209_42165_42210()
{
var return_v = RegistryProviderStrings.KeyCreatedValueFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 42165, 42210);
return return_v;
}


string
f_1209_42147_42222(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 42147, 42222);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1209_42130_42223(string
message)
{
var return_v = new System.Management.Automation.ErrorDetails( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 42130, 42223);
return return_v;
}


int
f_1209_42254_42269(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 42254, 42269);
return 0;
}


int
f_1209_42457_42494(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path)
{
this_param.WriteRegistryItemObject( key, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 42457, 42494);
return 0;
}


System.Type
f_1209_42776_42797(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 42776, 42797);
return return_v;
}


string
f_1209_42776_42806(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 42776, 42806);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_42747_42839(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 42747, 42839);
return return_v;
}


int
f_1209_42736_42840(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 42736, 42840);
return 0;
}


System.Type
f_1209_43146_43173(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43146, 43173);
return return_v;
}


string
f_1209_43146_43182(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 43146, 43182);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_43111_43221(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43111, 43221);
return return_v;
}


int
f_1209_43100_43222(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43100, 43222);
return 0;
}


System.Type
f_1209_43549_43586(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43549, 43586);
return return_v;
}


string
f_1209_43549_43595(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 43549, 43595);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_43504_43634(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43504, 43634);
return return_v;
}


int
f_1209_43493_43635(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43493, 43635);
return 0;
}


System.Type
f_1209_43793_43815(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43793, 43815);
return return_v;
}


string
f_1209_43793_43824(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 43793, 43824);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_43763_43862(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43763, 43862);
return return_v;
}


int
f_1209_43752_43863(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43752, 43863);
return 0;
}


System.Type
f_1209_44043_44074(System.NotSupportedException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 44043, 44074);
return return_v;
}


string
f_1209_44043_44083(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 44043, 44083);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_44004_44122(System.NotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 44004, 44122);
return return_v;
}


int
f_1209_43993_44123(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 43993, 44123);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,37893,44169);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,37893,44169);
}
		}

protected override void RemoveItem(
            string path,
            bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,44568,47541);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,44681,44809) || true) && (f_1209_44685_44711(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,44681,44809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,44745,44794);

throw f_1209_44751_44793("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,44681,44809);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,44825,44870);

f_1209_44825_44869(
            s_tracer, "recurse = {0}", recurse);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,44950,44996);

string 
parentPath = f_1209_44970_44995(this, path, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45010,45048);

string 
childName = f_1209_45029_45047(this, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45101,45171);

IRegistryWrapper 
key = f_1209_45124_45170(this, parentPath, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45187,45258) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,45187,45258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45236,45243);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,45187,45258);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45330,45386);

string 
action = f_1209_45346_45385()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45402,45478);

string 
resourceTemplate = f_1209_45428_45477()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45494,45668);

string 
resource =
f_1209_45533_45667(f_1209_45573_45592(f_1209_45573_45577()), resourceTemplate, path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45684,47502) || true) && (f_1209_45688_45719(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,45684,47502);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45797,45829);

f_1209_45797_45828(                    key, childName);
                }
                catch (ArgumentException argumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,45866,46086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,45950,46067);

f_1209_45950_46066(this, f_1209_45961_46065(argumentException, f_1209_45996_46032(f_1209_45996_46023(argumentException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,45866,46086);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,46104,46432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,46308,46413);

f_1209_46308_46412(this, f_1209_46319_46411(ioException, f_1209_46348_46378(f_1209_46348_46369(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,46104,46432);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,46450,46814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,46672,46795);

f_1209_46672_46794(this, f_1209_46683_46793(securityException, f_1209_46718_46754(f_1209_46718_46745(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,46450,46814);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,46832,47227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,47065,47208);

f_1209_47065_47207(this, f_1209_47076_47206(unauthorizedAccessException, f_1209_47121_47167(f_1209_47121_47158(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,46832,47227);
                }
                catch (NotSupportedException notSupportedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,47245,47487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,47337,47468);

f_1209_47337_47467(this, f_1209_47348_47466(notSupportedException, f_1209_47387_47427(f_1209_47387_47418(notSupportedException)), ErrorCategory.InvalidOperation, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,47245,47487);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,45684,47502);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,47518,47530);

f_1209_47518_47529(
            key);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,44568,47541);

bool
f_1209_44685_44711(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 44685, 44711);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_44751_44793(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 44751, 44793);
return return_v;
}


int
f_1209_44825_44869(System.Management.Automation.PSTraceSource
this_param,string
format,bool
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 44825, 44869);
return 0;
}


string
f_1209_44970_44995(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 44970, 44995);
return return_v;
}


string
f_1209_45029_45047(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45029, 45047);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_45124_45170(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45124, 45170);
return return_v;
}


string
f_1209_45346_45385()
{
var return_v = RegistryProviderStrings.RemoveKeyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 45346, 45385);
return return_v;
}


string
f_1209_45428_45477()
{
var return_v = RegistryProviderStrings.RemoveKeyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 45428, 45477);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_45573_45577()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 45573, 45577);
return return_v;
}


System.Globalization.CultureInfo
f_1209_45573_45592(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 45573, 45592);
return return_v;
}


string
f_1209_45533_45667(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45533, 45667);
return return_v;
}


bool
f_1209_45688_45719(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45688, 45719);
return return_v;
}


int
f_1209_45797_45828(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
subkey)
{
this_param.DeleteSubKeyTree( subkey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45797, 45828);
return 0;
}


System.Type
f_1209_45996_46023(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45996, 46023);
return return_v;
}


string
f_1209_45996_46032(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 45996, 46032);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_45961_46065(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45961, 46065);
return return_v;
}


int
f_1209_45950_46066(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 45950, 46066);
return 0;
}


System.Type
f_1209_46348_46369(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 46348, 46369);
return return_v;
}


string
f_1209_46348_46378(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 46348, 46378);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_46319_46411(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 46319, 46411);
return return_v;
}


int
f_1209_46308_46412(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 46308, 46412);
return 0;
}


System.Type
f_1209_46718_46745(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 46718, 46745);
return return_v;
}


string
f_1209_46718_46754(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 46718, 46754);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_46683_46793(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 46683, 46793);
return return_v;
}


int
f_1209_46672_46794(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 46672, 46794);
return 0;
}


System.Type
f_1209_47121_47158(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 47121, 47158);
return return_v;
}


string
f_1209_47121_47167(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 47121, 47167);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_47076_47206(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 47076, 47206);
return return_v;
}


int
f_1209_47065_47207(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 47065, 47207);
return 0;
}


System.Type
f_1209_47387_47418(System.NotSupportedException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 47387, 47418);
return return_v;
}


string
f_1209_47387_47427(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 47387, 47427);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_47348_47466(System.NotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 47348, 47466);
return return_v;
}


int
f_1209_47337_47467(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 47337, 47467);
return 0;
}


int
f_1209_47518_47529(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 47518, 47529);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,44568,47541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,44568,47541);
}
		}

protected override bool ItemExists(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,47903,49171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,47975,47995);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48011,48129) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,48011,48129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48061,48114);

throw f_1209_48067_48113("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,48011,48129);
}

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48181,48700) || true) && (f_1209_48185_48206(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,48181,48700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48368,48382);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,48181,48700);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,48181,48700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48464,48517);

IRegistryWrapper 
key = f_1209_48487_48516(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48541,48681) || true) && (key != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,48541,48681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48606,48620);

result = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48646,48658);

f_1209_48646_48657(                        key);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,48541,48681);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,48181,48700);
}
            }
            // Catch known non-terminating exceptions
            catch (System.IO.IOException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,48784,48843);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,48784,48843);
            }
            // In these cases, the item does exist
            catch (System.Security.SecurityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,48909,49012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,48983,48997);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,48909,49012);
            }
            catch (System.UnauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,49026,49130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,49101,49115);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,49026,49130);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,49146,49160);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,47903,49171);

System.Management.Automation.PSArgumentNullException
f_1209_48067_48113(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 48067, 48113);
return return_v;
}


bool
f_1209_48185_48206(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.IsHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 48185, 48206);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_48487_48516(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 48487, 48516);
return return_v;
}


int
f_1209_48646_48657(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 48646, 48657);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,47903,49171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,47903,49171);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool HasChildItems(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,49525,50702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,49600,49620);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,49636,49754) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,49636,49754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,49686,49739);

throw f_1209_49692_49738("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,49636,49754);
}

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,49806,50303) || true) && (f_1209_49810_49831(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,49806,50303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,49938,49970);

result = f_1209_49947_49965(s_hiveNames)> 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,49806,50303);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,49806,50303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50052,50105);

IRegistryWrapper 
key = f_1209_50075_50104(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50129,50284) || true) && (key != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,50129,50284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50194,50223);

result = f_1209_50203_50218(key)> 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50249,50261);

f_1209_50249_50260(                        key);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,50129,50284);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,49806,50303);
}
            }
            catch (System.IO.IOException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,50332,50424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50394,50409);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,50332,50424);
            }
            catch (System.Security.SecurityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,50438,50542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50512,50527);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,50438,50542);
            }
            catch (System.UnauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,50556,50661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50631,50646);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,50556,50661);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,50677,50691);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,49525,50702);

System.Management.Automation.PSArgumentNullException
f_1209_49692_49738(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 49692, 49738);
return return_v;
}


bool
f_1209_49810_49831(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.IsHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 49810, 49831);
return return_v;
}


int
f_1209_49947_49965(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 49947, 49965);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_50075_50104(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 50075, 50104);
return return_v;
}


int
f_1209_50203_50218(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.SubKeyCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 50203, 50218);
return return_v;
}


int
f_1209_50249_50260(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 50249, 50260);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,49525,50702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,49525,50702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void CopyItem(
            string path,
            string destination,
            bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,51233,53196);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51377,51505) || true) && (f_1209_51381_51407(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,51377,51505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51441,51490);

throw f_1209_51447_51489("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,51377,51505);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51521,51663) || true) && (f_1209_51525_51558(destination))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,51521,51663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51592,51648);

throw f_1209_51598_51647("destination");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,51521,51663);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51679,51732);

f_1209_51679_51731(
            s_tracer, "destination = {0}", destination);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51746,51791);

f_1209_51746_51790(            s_tracer, "recurse = {0}", recurse);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51807,51872);

IRegistryWrapper 
key = f_1209_51830_51871(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51888,51959) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,51888,51959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,51937,51944);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,51888,51959);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,52011,52073);

f_1209_52011_52072(this, key, path, destination, recurse, true, false);
            }
            catch (System.IO.IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,52102,52410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,52290,52395);

f_1209_52290_52394(this, f_1209_52301_52393(ioException, f_1209_52330_52360(f_1209_52330_52351(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,52102,52410);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,52424,52768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,52630,52753);

f_1209_52630_52752(this, f_1209_52641_52751(securityException, f_1209_52676_52712(f_1209_52676_52703(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,52424,52768);
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,52782,53157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,52999,53142);

f_1209_52999_53141(this, f_1209_53010_53140(unauthorizedAccessException, f_1209_53055_53101(f_1209_53055_53092(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,52782,53157);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,53173,53185);

f_1209_53173_53184(
            key);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,51233,53196);

bool
f_1209_51381_51407(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 51381, 51407);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_51447_51489(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 51447, 51489);
return return_v;
}


bool
f_1209_51525_51558(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 51525, 51558);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_51598_51647(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 51598, 51647);
return return_v;
}


int
f_1209_51679_51731(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 51679, 51731);
return 0;
}


int
f_1209_51746_51790(System.Management.Automation.PSTraceSource
this_param,string
format,bool
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 51746, 51790);
return 0;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_51830_51871(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 51830, 51871);
return return_v;
}


bool
f_1209_52011_52072(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path,string
destination,bool
recurse,bool
streamResult,bool
streamFirstOnly)
{
var return_v = this_param.CopyRegistryKey( key, path, destination, recurse, streamResult, streamFirstOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52011, 52072);
return return_v;
}


System.Type
f_1209_52330_52351(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52330, 52351);
return return_v;
}


string
f_1209_52330_52360(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 52330, 52360);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_52301_52393(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52301, 52393);
return return_v;
}


int
f_1209_52290_52394(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52290, 52394);
return 0;
}


System.Type
f_1209_52676_52703(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52676, 52703);
return return_v;
}


string
f_1209_52676_52712(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 52676, 52712);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_52641_52751(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52641, 52751);
return return_v;
}


int
f_1209_52630_52752(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52630, 52752);
return 0;
}


System.Type
f_1209_53055_53092(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 53055, 53092);
return return_v;
}


string
f_1209_53055_53101(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 53055, 53101);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_53010_53140(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 53010, 53140);
return return_v;
}


int
f_1209_52999_53141(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 52999, 53141);
return 0;
}


int
f_1209_53173_53184(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 53173, 53184);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,51233,53196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,51233,53196);
}
		}

private bool CopyRegistryKey(
            IRegistryWrapper key,
            string path,
            string destination,
            bool recurse,
            bool streamResult,
            bool streamFirstOnly)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,53208,58922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,53450,53469);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,53611,53809) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,53611,53809);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,53656,53794) || true) && (f_1209_53660_53720(this, path, destination))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,53656,53794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,53762,53775);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,53656,53794);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,53611,53809);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,53825,53948);

f_1209_53825_53947(key != null, "The key should have been validated by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,53964,54104);

f_1209_53964_54103(!f_1209_54006_54032(path), "The path should have been validated by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54120,54274);

f_1209_54120_54273(!f_1209_54162_54195(destination), "The destination should have been validated by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54290,54343);

f_1209_54290_54342(
            s_tracer, "destination = {0}", destination);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54657,54725);

IRegistryWrapper 
newParentKey = f_1209_54689_54724(this, destination, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54739,54783);

string 
destinationName = f_1209_54764_54782(this, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54797,54836);

string 
destinationParent = destination
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54852,55129) || true) && (newParentKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,54852,55129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54910,54963);

destinationParent = f_1209_54930_54962(this, destination, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,54981,55025);

destinationName = f_1209_54999_55024(this, destination);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55045,55114);

newParentKey = f_1209_55060_55113(this, destinationParent, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,54852,55129);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55145,55360) || true) && (newParentKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,55145,55360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55332,55345);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,55145,55360);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55376,55446);

string 
destinationPath = f_1209_55401_55445(this, destinationParent, destinationName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55516,55570);

string 
action = f_1209_55532_55569()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55586,55660);

string 
resourceTemplate = f_1209_55612_55659()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55676,55888);

string 
resource =
f_1209_55715_55887(f_1209_55755_55774(f_1209_55755_55759()), resourceTemplate, path, destination)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,55904,57728) || true) && (f_1209_55908_55939(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,55904,57728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56027,56058);

IRegistryWrapper 
newKey = null
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56120,56172);

newKey = f_1209_56129_56171(newParentKey, destinationName);
                }
                catch (NotSupportedException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,56209,56402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56281,56383);

f_1209_56281_56382(this, f_1209_56292_56381(e, f_1209_56311_56331(f_1209_56311_56322(e)), ErrorCategory.InvalidOperation, destinationName));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,56209,56402);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56422,57713) || true) && (newKey != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,56422,57713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56571,56613);

string[] 
valueNames = f_1209_56593_56612(key)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56646,56655);

                    for (int 
index = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56637,57315) || true) && (index < f_1209_56665_56682(valueNames))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56684,56691)
,++index,DynAbs.Tracing.TraceSender.TraceExitCondition(1209,56637,57315))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,56637,57315);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56809,57015) || true) && (f_1209_56813_56821())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,56809,57015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56879,56900);

f_1209_56879_56899(                            newParentKey);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56930,56945);

f_1209_56930_56944(                            newKey);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,56975,56988);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,56809,57015);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57043,57292);

f_1209_57043_57291(
                        newKey, valueNames[index], f_1209_57137_57224(                            key, valueNames[index], null, RegistryValueOptions.DoNotExpandEnvironmentNames), f_1209_57255_57290(                            key, valueNames[index]));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,679);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,679);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57339,57694) || true) && (streamResult)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,57339,57694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57469,57518);

f_1209_57469_57517(this, newKey, destinationPath);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57546,57671) || true) && (streamFirstOnly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,57546,57671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57623,57644);

streamResult = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,57546,57671);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,57339,57694);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,56422,57713);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,55904,57728);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57744,57765);

f_1209_57744_57764(
            newParentKey);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57781,58881) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,57781,58881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57869,57913);

string[] 
subkeyNames = f_1209_57892_57912(key)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57942,57954);

                for (int 
keyIndex = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57933,58866) || true) && (keyIndex < f_1209_57967_57985(subkeyNames))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,57987,57997)
,++keyIndex,DynAbs.Tracing.TraceSender.TraceExitCondition(1209,57933,58866))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,57933,58866);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58103,58201) || true) && (f_1209_58107_58115())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,58103,58201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58165,58178);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,58103,58201);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58290,58348);

string 
subKeyPath = f_1209_58310_58347(this, path, subkeyNames[keyIndex])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58370,58442);

string 
newSubKeyPath = f_1209_58393_58441(this, destinationPath, subkeyNames[keyIndex])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58466,58530);

IRegistryWrapper 
childKey = f_1209_58494_58529(this, subKeyPath, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58554,58668);

bool 
subtreeResult = f_1209_58575_58667(this, childKey, subKeyPath, newSubKeyPath, recurse, streamResult, streamFirstOnly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58692,58709);

f_1209_58692_58708(
                    childKey);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58733,58847) || true) && (!subtreeResult)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,58733,58847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58801,58824);

result = subtreeResult;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,58733,58847);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,934);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,934);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1209,57781,58881);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,58897,58911);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,53208,58922);

bool
f_1209_53660_53720(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
sourcePath,string
destinationPath)
{
var return_v = this_param.ErrorIfDestinationIsSourceOrChildOfSource( sourcePath, destinationPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 53660, 53720);
return return_v;
}


int
f_1209_53825_53947(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 53825, 53947);
return 0;
}


bool
f_1209_54006_54032(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54006, 54032);
return return_v;
}


int
f_1209_53964_54103(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 53964, 54103);
return 0;
}


bool
f_1209_54162_54195(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54162, 54195);
return return_v;
}


int
f_1209_54120_54273(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54120, 54273);
return 0;
}


int
f_1209_54290_54342(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54290, 54342);
return 0;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_54689_54724(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54689, 54724);
return return_v;
}


string
f_1209_54764_54782(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54764, 54782);
return return_v;
}


string
f_1209_54930_54962(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54930, 54962);
return return_v;
}


string
f_1209_54999_55024(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 54999, 55024);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_55060_55113(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 55060, 55113);
return return_v;
}


string
f_1209_55401_55445(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 55401, 55445);
return return_v;
}


string
f_1209_55532_55569()
{
var return_v = RegistryProviderStrings.CopyKeyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 55532, 55569);
return return_v;
}


string
f_1209_55612_55659()
{
var return_v = RegistryProviderStrings.CopyKeyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 55612, 55659);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_55755_55759()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 55755, 55759);
return return_v;
}


System.Globalization.CultureInfo
f_1209_55755_55774(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 55755, 55774);
return return_v;
}


string
f_1209_55715_55887(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 55715, 55887);
return return_v;
}


bool
f_1209_55908_55939(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 55908, 55939);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_56129_56171(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
subkey)
{
var return_v = this_param.CreateSubKey( subkey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 56129, 56171);
return return_v;
}


System.Type
f_1209_56311_56322(System.NotSupportedException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 56311, 56322);
return return_v;
}


string
f_1209_56311_56331(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 56311, 56331);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_56292_56381(System.NotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 56292, 56381);
return return_v;
}


int
f_1209_56281_56382(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 56281, 56382);
return 0;
}


string[]
f_1209_56593_56612(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetValueNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 56593, 56612);
return return_v;
}


int
f_1209_56665_56682(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 56665, 56682);
return return_v;
}


bool
f_1209_56813_56821()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 56813, 56821);
return return_v;
}


int
f_1209_56879_56899(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 56879, 56899);
return 0;
}


int
f_1209_56930_56944(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 56930, 56944);
return 0;
}


object
f_1209_57137_57224(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
defaultValue,Microsoft.Win32.RegistryValueOptions
options)
{
var return_v = this_param.GetValue( name, defaultValue, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 57137, 57224);
return return_v;
}


Microsoft.Win32.RegistryValueKind
f_1209_57255_57290(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValueKind( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 57255, 57290);
return return_v;
}


int
f_1209_57043_57291(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
value,Microsoft.Win32.RegistryValueKind
valueKind)
{
this_param.SetValue( name, value, valueKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 57043, 57291);
return 0;
}


int
f_1209_57469_57517(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path)
{
this_param.WriteRegistryItemObject( key, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 57469, 57517);
return 0;
}


int
f_1209_57744_57764(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 57744, 57764);
return 0;
}


string[]
f_1209_57892_57912(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetSubKeyNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 57892, 57912);
return return_v;
}


int
f_1209_57967_57985(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 57967, 57985);
return return_v;
}


bool
f_1209_58107_58115()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 58107, 58115);
return return_v;
}


string
f_1209_58310_58347(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 58310, 58347);
return return_v;
}


string
f_1209_58393_58441(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 58393, 58441);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_58494_58529(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 58494, 58529);
return return_v;
}


bool
f_1209_58575_58667(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path,string
destination,bool
recurse,bool
streamResult,bool
streamFirstOnly)
{
var return_v = this_param.CopyRegistryKey( key, path, destination, recurse, streamResult, streamFirstOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 58575, 58667);
return return_v;
}


int
f_1209_58692_58708(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 58692, 58708);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,53208,58922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,53208,58922);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool ErrorIfDestinationIsSourceOrChildOfSource(
            string sourcePath,
            string destinationPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,58934,60934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,59083,59144);

f_1209_59083_59143(            s_tracer, "destinationPath = {0}", destinationPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,59291,59311);

bool 
result = false
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,59327,60481);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,59411,59678) || true) && (f_1209_59415_59570(sourcePath, destinationPath, StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,59411,59678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,59617,59631);

result = true;
DynAbs.Tracing.TraceSender.TraceBreak(1209,59653,59659);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,59411,59678);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,59698,59763);

string 
newDestinationPath = f_1209_59726_59762(this, destinationPath, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,59783,60015) || true) && (f_1209_59787_59827(newDestinationPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,59783,60015);
DynAbs.Tracing.TraceSender.TraceBreak(1209,59990,59996);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,59783,60015);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,60035,60395) || true) && (f_1209_60039_60202(newDestinationPath, destinationPath, StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,60035,60395);
DynAbs.Tracing.TraceSender.TraceBreak(1209,60370,60376);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,60035,60395);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,60415,60452);

destinationPath = newDestinationPath;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,59327,60481);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,59327,60481) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,59327,60481);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,59327,60481);
}}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,60497,60893) || true) && (result)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,60497,60893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,60541,60674);

Exception 
e =
f_1209_60576_60673(f_1209_60624_60672())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,60692,60878);

f_1209_60692_60877(this, f_1209_60703_60876(e, f_1209_60765_60785(f_1209_60765_60776(                    e)), ErrorCategory.InvalidArgument, destinationPath));
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,60497,60893);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,60909,60923);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,58934,60934);

int
f_1209_59083_59143(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 59083, 59143);
return 0;
}


int
f_1209_59415_59570(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 59415, 59570);
return return_v;
}


string
f_1209_59726_59762(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 59726, 59762);
return return_v;
}


bool
f_1209_59787_59827(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 59787, 59827);
return return_v;
}


int
f_1209_60039_60202(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 60039, 60202);
return return_v;
}


string
f_1209_60624_60672()
{
var return_v =                         RegistryProviderStrings.DestinationChildOfSource;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 60624, 60672);
return return_v;
}


System.ArgumentException
f_1209_60576_60673(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 60576, 60673);
return return_v;
}


System.Type
f_1209_60765_60776(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 60765, 60776);
return return_v;
}


string
f_1209_60765_60785(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 60765, 60785);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_60703_60876(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 60703, 60876);
return return_v;
}


int
f_1209_60692_60877(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 60692, 60877);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,58934,60934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,58934,60934);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool IsItemContainer(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,61507,63163);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,61584,61702) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,61584,61702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,61634,61687);

throw f_1209_61640_61686("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,61584,61702);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,61718,61738);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,61754,63122) || true) && (f_1209_61758_61779(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,61754,63122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,61813,61827);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,61754,63122);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,61754,63122);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,61937,61990);

IRegistryWrapper 
key = f_1209_61960_61989(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,62014,62280) || true) && (key != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,62014,62280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,62205,62217);

f_1209_62205_62216(                        // All registry keys can be containers. Values are considered
                        // properties
                        key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,62243,62257);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,62014,62280);
}
                }
                // Catch known exceptions that are not terminating
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,62385,62590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,62467,62571);

f_1209_62467_62570(this, f_1209_62478_62569(ioException, f_1209_62507_62537(f_1209_62507_62528(ioException)), ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,62385,62590);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,62608,62850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,62708,62831);

f_1209_62708_62830(this, f_1209_62719_62829(securityException, f_1209_62754_62790(f_1209_62754_62781(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,62608,62850);
                }
                catch (UnauthorizedAccessException unauthorizedAccess)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,62868,63107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,62963,63088);

f_1209_62963_63087(this, f_1209_62974_63086(unauthorizedAccess, f_1209_63010_63047(f_1209_63010_63038(unauthorizedAccess)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,62868,63107);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,61754,63122);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,63138,63152);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,61507,63163);

System.Management.Automation.PSArgumentNullException
f_1209_61640_61686(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 61640, 61686);
return return_v;
}


bool
f_1209_61758_61779(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.IsHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 61758, 61779);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_61960_61989(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 61960, 61989);
return return_v;
}


int
f_1209_62205_62216(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62205, 62216);
return 0;
}


System.Type
f_1209_62507_62528(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62507, 62528);
return return_v;
}


string
f_1209_62507_62537(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 62507, 62537);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_62478_62569(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62478, 62569);
return return_v;
}


int
f_1209_62467_62570(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62467, 62570);
return 0;
}


System.Type
f_1209_62754_62781(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62754, 62781);
return return_v;
}


string
f_1209_62754_62790(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 62754, 62790);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_62719_62829(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62719, 62829);
return return_v;
}


int
f_1209_62708_62830(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62708, 62830);
return 0;
}


System.Type
f_1209_63010_63038(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 63010, 63038);
return return_v;
}


string
f_1209_63010_63047(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 63010, 63047);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_62974_63086(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62974, 63086);
return return_v;
}


int
f_1209_62963_63087(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 62963, 63087);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,61507,63163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,61507,63163);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void MoveItem(
            string path,
            string destination)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,63461,64506);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,63578,63706) || true) && (f_1209_63582_63608(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,63578,63706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,63642,63691);

throw f_1209_63648_63690("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,63578,63706);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,63722,63864) || true) && (f_1209_63726_63759(destination))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,63722,63864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,63793,63849);

throw f_1209_63799_63848("destination");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,63722,63864);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,63880,63933);

f_1209_63880_63932(
            s_tracer, "destination = {0}", destination);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64005,64060);

string 
action = f_1209_64021_64059()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64076,64151);

string 
resourceTemplate = f_1209_64102_64150()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64167,64359);

string 
resource =
f_1209_64202_64358(f_1209_64238_64257(f_1209_64238_64242()), resourceTemplate, path, destination)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64375,64495) || true) && (f_1209_64379_64410(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,64375,64495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64444,64480);

f_1209_64444_64479(this, path, destination);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,64375,64495);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,63461,64506);

bool
f_1209_63582_63608(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 63582, 63608);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_63648_63690(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 63648, 63690);
return return_v;
}


bool
f_1209_63726_63759(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 63726, 63759);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_63799_63848(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 63799, 63848);
return return_v;
}


int
f_1209_63880_63932(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 63880, 63932);
return 0;
}


string
f_1209_64021_64059()
{
var return_v = RegistryProviderStrings.MoveItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 64021, 64059);
return return_v;
}


string
f_1209_64102_64150()
{
var return_v = RegistryProviderStrings.MoveItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 64102, 64150);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_64238_64242()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 64238, 64242);
return return_v;
}


System.Globalization.CultureInfo
f_1209_64238_64257(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 64238, 64257);
return return_v;
}


string
f_1209_64202_64358(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 64202, 64358);
return return_v;
}


bool
f_1209_64379_64410(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 64379, 64410);
return return_v;
}


int
f_1209_64444_64479(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
destination)
{
this_param.MoveRegistryItem( path, destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 64444, 64479);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,63461,64506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,63461,64506);
}
		}

private void MoveRegistryItem(string path, string destination)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,64518,68175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64741,64806);

IRegistryWrapper 
key = f_1209_64764_64805(this, path, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64822,64893) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,64822,64893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64871,64878);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,64822,64893);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64909,64941);

bool 
continueWithRemove = false
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,64991,65070);

continueWithRemove = f_1209_65012_65069(this, key, path, destination, true, true, true);
            }
            catch (System.IO.IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,65099,65462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,65287,65392);

f_1209_65287_65391(this, f_1209_65298_65390(ioException, f_1209_65327_65357(f_1209_65327_65348(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,65410,65422);

f_1209_65410_65421(                key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,65440,65447);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,65099,65462);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,65476,65875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,65682,65805);

f_1209_65682_65804(this, f_1209_65693_65803(securityException, f_1209_65728_65764(f_1209_65728_65755(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,65823,65835);

f_1209_65823_65834(                key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,65853,65860);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,65476,65875);
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,65889,66319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66106,66249);

f_1209_66106_66248(this, f_1209_66117_66247(unauthorizedAccessException, f_1209_66162_66208(f_1209_66162_66199(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66267,66279);

f_1209_66267_66278(                key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66297,66304);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,65889,66319);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66335,66347);

f_1209_66335_66346(
            key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66363,66411);

string 
sourceParent = f_1209_66385_66410(this, path, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66607,66763) || true) && (f_1209_66611_66687(sourceParent, destination, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,66607,66763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66721,66748);

continueWithRemove = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,66607,66763);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66779,68164) || true) && (continueWithRemove)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,66779,68164);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,66879,66902);

f_1209_66879_66901(this, path, true);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,66939,67296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,67143,67248);

f_1209_67143_67247(this, f_1209_67154_67246(ioException, f_1209_67183_67213(f_1209_67183_67204(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,67270,67277);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,66939,67296);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,67314,67707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,67536,67659);

f_1209_67536_67658(this, f_1209_67547_67657(securityException, f_1209_67582_67618(f_1209_67582_67609(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,67681,67688);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,67314,67707);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,67725,68149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,67958,68101);

f_1209_67958_68100(this, f_1209_67969_68099(unauthorizedAccessException, f_1209_68014_68060(f_1209_68014_68051(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,68123,68130);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,67725,68149);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,66779,68164);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,64518,68175);

Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_64764_64805(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 64764, 64805);
return return_v;
}


bool
f_1209_65012_65069(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
path,string
destination,bool
recurse,bool
streamResult,bool
streamFirstOnly)
{
var return_v = this_param.CopyRegistryKey( key, path, destination, recurse, streamResult, streamFirstOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65012, 65069);
return return_v;
}


System.Type
f_1209_65327_65348(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65327, 65348);
return return_v;
}


string
f_1209_65327_65357(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 65327, 65357);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_65298_65390(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65298, 65390);
return return_v;
}


int
f_1209_65287_65391(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65287, 65391);
return 0;
}


int
f_1209_65410_65421(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65410, 65421);
return 0;
}


System.Type
f_1209_65728_65755(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65728, 65755);
return return_v;
}


string
f_1209_65728_65764(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 65728, 65764);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_65693_65803(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65693, 65803);
return return_v;
}


int
f_1209_65682_65804(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65682, 65804);
return 0;
}


int
f_1209_65823_65834(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 65823, 65834);
return 0;
}


System.Type
f_1209_66162_66199(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66162, 66199);
return return_v;
}


string
f_1209_66162_66208(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 66162, 66208);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_66117_66247(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66117, 66247);
return return_v;
}


int
f_1209_66106_66248(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66106, 66248);
return 0;
}


int
f_1209_66267_66278(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66267, 66278);
return 0;
}


int
f_1209_66335_66346(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66335, 66346);
return 0;
}


string
f_1209_66385_66410(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66385, 66410);
return return_v;
}


bool
f_1209_66611_66687(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66611, 66687);
return return_v;
}


int
f_1209_66879_66901(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
recurse)
{
this_param.RemoveItem( path, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 66879, 66901);
return 0;
}


System.Type
f_1209_67183_67204(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67183, 67204);
return return_v;
}


string
f_1209_67183_67213(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 67183, 67213);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_67154_67246(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67154, 67246);
return return_v;
}


int
f_1209_67143_67247(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67143, 67247);
return 0;
}


System.Type
f_1209_67582_67609(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67582, 67609);
return return_v;
}


string
f_1209_67582_67618(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 67582, 67618);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_67547_67657(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67547, 67657);
return return_v;
}


int
f_1209_67536_67658(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67536, 67658);
return 0;
}


System.Type
f_1209_68014_68051(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 68014, 68051);
return return_v;
}


string
f_1209_68014_68060(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 68014, 68060);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_67969_68099(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67969, 68099);
return return_v;
}


int
f_1209_67958_68100(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 67958, 68100);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,64518,68175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,64518,68175);
}
		}

public void GetProperty(
            string path,
            Collection<string> providerSpecificPickList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,68959,70876);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69092,69210) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,69092,69210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69142,69195);

throw f_1209_69148_69194("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,69092,69210);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69226,69332) || true) && (!f_1209_69231_69276(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,69226,69332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69310,69317);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,69226,69332);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69415,69436);

IRegistryWrapper 
key
=default(IRegistryWrapper);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69450,69496);

Collection<string> 
filteredPropertyCollection
=default(Collection<string>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69510,69854);

f_1209_69510_69853(this, path, providerSpecificPickList, true, false, out key, out filteredPropertyCollection);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69868,69939) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,69868,69939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69917,69924);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,69868,69939);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69955,69979);

bool 
valueAdded = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,69993,70035);

PSObject 
propertyResults = f_1209_70020_70034()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70049,70715);
foreach(string valueName in f_1209_70078_70104_I(filteredPropertyCollection) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,70049,70715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70138,70174);

string 
notePropertyName = valueName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70192,70550) || true) && (f_1209_70196_70227(valueName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,70192,70550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70485,70531);

notePropertyName = f_1209_70504_70530(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,70192,70550);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70570,70664);

f_1209_70570_70663(f_1209_70570_70596(propertyResults), f_1209_70601_70662(notePropertyName, f_1209_70638_70661(key, valueName)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70682,70700);

valueAdded = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,70049,70715);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,667);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,667);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70731,70743);

f_1209_70731_70742(
            key);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70759,70865) || true) && (valueAdded)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,70759,70865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,70807,70850);

f_1209_70807_70849(this, propertyResults, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,70759,70865);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,68959,70876);

System.Management.Automation.PSArgumentNullException
f_1209_69148_69194(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 69148, 69194);
return return_v;
}


bool
f_1209_69231_69276(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 69231, 69276);
return return_v;
}


int
f_1209_69510_69853(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
propertyNames,bool
getAll,bool
writeAccess,out Microsoft.PowerShell.Commands.IRegistryWrapper
key,out System.Collections.ObjectModel.Collection<string>
filteredCollection)
{
this_param.GetFilteredRegistryKeyProperties( path, propertyNames, getAll, writeAccess, out key, out filteredCollection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 69510, 69853);
return 0;
}


System.Management.Automation.PSObject
f_1209_70020_70034()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70020, 70034);
return return_v;
}


bool
f_1209_70196_70227(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70196, 70227);
return return_v;
}


string
f_1209_70504_70530(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.GetLocalizedDefaultToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70504, 70530);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1209_70570_70596(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 70570, 70596);
return return_v;
}


object
f_1209_70638_70661(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70638, 70661);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1209_70601_70662(string
name,object
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70601, 70662);
return return_v;
}


int
f_1209_70570_70663(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70570, 70663);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1209_70078_70104_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70078, 70104);
return return_v;
}


int
f_1209_70731_70742(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70731, 70742);
return 0;
}


int
f_1209_70807_70849(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.PSObject
propertyValue,string
path)
{
this_param.WritePropertyObject( (object)propertyValue, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 70807, 70849);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,68959,70876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,68959,70876);
}
		}

public void SetProperty(
            string path,
            PSObject propertyValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,71524,75033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,71636,71754) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,71636,71754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,71686,71739);

throw f_1209_71692_71738("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,71636,71754);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,71770,71876) || true) && (!f_1209_71775_71820(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,71770,71876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,71854,71861);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,71770,71876);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,71892,72028) || true) && (propertyValue == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,71892,72028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,71951,72013);

throw f_1209_71957_72012("propertyValue");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,71892,72028);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72044,72108);

IRegistryWrapper 
key = f_1209_72067_72107(this, path, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72124,72195) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,72124,72195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72173,72180);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,72124,72195);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72211,72262);

RegistryValueKind 
kind = RegistryValueKind.Unknown
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72351,72687) || true) && (f_1209_72355_72372()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,72351,72687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72414,72548);

RegistryProviderSetItemDynamicParameter 
dynParams =
f_1209_72487_72504()as RegistryProviderSetItemDynamicParameter
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72568,72672) || true) && (dynParams != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,72568,72672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72631,72653);

kind = f_1209_72638_72652(dynParams);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,72568,72672);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,72351,72687);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72703,72761);

string 
action = f_1209_72719_72760()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72777,72855);

string 
resourceTemplate = f_1209_72803_72854()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72871,74994);
foreach(PSMemberInfo property in f_1209_72905_72929_I(f_1209_72905_72929(propertyValue)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,72871,74994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,72963,73004);

object 
newPropertyValue = f_1209_72989_73003(property)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,73024,73238);

string 
resource =
f_1209_73063_73237(f_1209_73103_73122(f_1209_73103_73107()), resourceTemplate, path, f_1209_73223_73236(property))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,73258,74979) || true) && (f_1209_73262_73293(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,73258,74979);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,73387,73454);

f_1209_73387_73453(this, key, f_1209_73409_73422(property), newPropertyValue, kind, path);
                    }
                    catch (InvalidCastException invalidCast)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,73499,73716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,73588,73693);

f_1209_73588_73692(this, f_1209_73599_73691(invalidCast, f_1209_73628_73658(f_1209_73628_73649(invalidCast)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,73499,73716);
                    }
                    catch (System.IO.IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,73738,74097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,73960,74074);

f_1209_73960_74073(this, f_1209_73971_74072(ioException, f_1209_74000_74030(f_1209_74000_74021(ioException)), ErrorCategory.WriteError, f_1209_74058_74071(property)));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,73738,74097);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,74119,74514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,74359,74491);

f_1209_74359_74490(this, f_1209_74370_74489(securityException, f_1209_74405_74441(f_1209_74405_74432(securityException)), ErrorCategory.PermissionDenied, f_1209_74475_74488(property)));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,74119,74514);
                    }
                    catch (System.UnauthorizedAccessException unauthorizedAccessException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,74536,74960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,74785,74937);

f_1209_74785_74936(this, f_1209_74796_74935(unauthorizedAccessException, f_1209_74841_74887(f_1209_74841_74878(unauthorizedAccessException)), ErrorCategory.PermissionDenied, f_1209_74921_74934(property)));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,74536,74960);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,73258,74979);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,72871,74994);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,2124);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,2124);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,75010,75022);

f_1209_75010_75021(
            key);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,71524,75033);

System.Management.Automation.PSArgumentNullException
f_1209_71692_71738(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 71692, 71738);
return return_v;
}


bool
f_1209_71775_71820(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 71775, 71820);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1209_71957_72012(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 71957, 72012);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_72067_72107(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 72067, 72107);
return return_v;
}


object
f_1209_72355_72372()
{
var return_v = DynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 72355, 72372);
return return_v;
}


object
f_1209_72487_72504()
{
var return_v = DynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 72487, 72504);
return return_v;
}


Microsoft.Win32.RegistryValueKind
f_1209_72638_72652(Microsoft.PowerShell.Commands.RegistryProviderSetItemDynamicParameter
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 72638, 72652);
return return_v;
}


string
f_1209_72719_72760()
{
var return_v = RegistryProviderStrings.SetPropertyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 72719, 72760);
return return_v;
}


string
f_1209_72803_72854()
{
var return_v = RegistryProviderStrings.SetPropertyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 72803, 72854);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1209_72905_72929(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 72905, 72929);
return return_v;
}


object
f_1209_72989_73003(System.Management.Automation.PSMemberInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 72989, 73003);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_73103_73107()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 73103, 73107);
return return_v;
}


System.Globalization.CultureInfo
f_1209_73103_73122(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 73103, 73122);
return return_v;
}


string
f_1209_73223_73236(System.Management.Automation.PSMemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 73223, 73236);
return return_v;
}


string
f_1209_73063_73237(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73063, 73237);
return return_v;
}


bool
f_1209_73262_73293(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73262, 73293);
return return_v;
}


string
f_1209_73409_73422(System.Management.Automation.PSMemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 73409, 73422);
return return_v;
}


int
f_1209_73387_73453(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
propertyName,object
value,Microsoft.Win32.RegistryValueKind
kind,string
path)
{
this_param.SetRegistryValue( key, propertyName, value, kind, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73387, 73453);
return 0;
}


System.Type
f_1209_73628_73649(System.InvalidCastException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73628, 73649);
return return_v;
}


string
f_1209_73628_73658(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 73628, 73658);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_73599_73691(System.InvalidCastException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73599, 73691);
return return_v;
}


int
f_1209_73588_73692(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73588, 73692);
return 0;
}


System.Type
f_1209_74000_74021(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 74000, 74021);
return return_v;
}


string
f_1209_74000_74030(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 74000, 74030);
return return_v;
}


string
f_1209_74058_74071(System.Management.Automation.PSMemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 74058, 74071);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_73971_74072(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73971, 74072);
return return_v;
}


int
f_1209_73960_74073(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 73960, 74073);
return 0;
}


System.Type
f_1209_74405_74432(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 74405, 74432);
return return_v;
}


string
f_1209_74405_74441(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 74405, 74441);
return return_v;
}


string
f_1209_74475_74488(System.Management.Automation.PSMemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 74475, 74488);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_74370_74489(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 74370, 74489);
return return_v;
}


int
f_1209_74359_74490(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 74359, 74490);
return 0;
}


System.Type
f_1209_74841_74878(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 74841, 74878);
return return_v;
}


string
f_1209_74841_74887(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 74841, 74887);
return return_v;
}


string
f_1209_74921_74934(System.Management.Automation.PSMemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 74921, 74934);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_74796_74935(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 74796, 74935);
return return_v;
}


int
f_1209_74785_74936(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 74785, 74936);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1209_72905_72929_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 72905, 72929);
return return_v;
}


int
f_1209_75010_75021(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 75010, 75021);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,71524,75033);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,71524,75033);
}
		}

public object SetPropertyDynamicParameters(
            string path,
            PSObject propertyValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,75760,75955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,75891,75944);

return f_1209_75898_75943();
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,75760,75955);

Microsoft.PowerShell.Commands.RegistryProviderSetItemDynamicParameter
f_1209_75898_75943()
{
var return_v = new Microsoft.PowerShell.Commands.RegistryProviderSetItemDynamicParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 75898, 75943);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,75760,75955);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,75760,75955);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void ClearProperty(
            string path,
            Collection<string> propertyToClear)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,76334,78644);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,76460,76578) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,76460,76578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,76510,76563);

throw f_1209_76516_76562("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,76460,76578);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,76594,76700) || true) && (!f_1209_76599_76644(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,76594,76700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,76678,76685);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,76594,76700);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,76783,76804);

IRegistryWrapper 
key
=default(IRegistryWrapper);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,76818,76864);

Collection<string> 
filteredPropertyCollection
=default(Collection<string>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,76878,77213);

f_1209_76878_77212(this, path, propertyToClear, false, true, out key, out filteredPropertyCollection);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77227,77298) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,77227,77298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77276,77283);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,77227,77298);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77314,77374);

string 
action = f_1209_77330_77373()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77390,77470);

string 
resourceTemplate = f_1209_77416_77469()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77486,77509);

bool 
addedOnce = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77523,77556);

PSObject 
result = f_1209_77541_77555()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77572,78493);
foreach(string valueName in f_1209_77601_77627_I(filteredPropertyCollection) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,77572,78493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77661,77851);

string 
resource =
f_1209_77696_77850(f_1209_77732_77751(f_1209_77732_77736()), resourceTemplate, path, valueName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,77871,78478) || true) && (f_1209_77875_77906(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,77871,78478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78025,78085);

object 
defaultValue = f_1209_78047_78084(this, key, valueName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78107,78144);

string 
propertyNameToAdd = valueName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78166,78321) || true) && (f_1209_78170_78201(valueName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,78166,78321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78251,78298);

propertyNameToAdd = f_1209_78271_78297(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,78166,78321);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78345,78420);

f_1209_78345_78419(f_1209_78345_78362(result), f_1209_78367_78418(propertyNameToAdd, defaultValue));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78442,78459);

addedOnce = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,77871,78478);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,77572,78493);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,922);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,922);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78509,78521);

f_1209_78509_78520(
            key);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78537,78633) || true) && (addedOnce)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,78537,78633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,78584,78618);

f_1209_78584_78617(this, result, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,78537,78633);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,76334,78644);

System.Management.Automation.PSArgumentNullException
f_1209_76516_76562(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 76516, 76562);
return return_v;
}


bool
f_1209_76599_76644(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 76599, 76644);
return return_v;
}


int
f_1209_76878_77212(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
propertyNames,bool
getAll,bool
writeAccess,out Microsoft.PowerShell.Commands.IRegistryWrapper
key,out System.Collections.ObjectModel.Collection<string>
filteredCollection)
{
this_param.GetFilteredRegistryKeyProperties( path, propertyNames, getAll, writeAccess, out key, out filteredCollection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 76878, 77212);
return 0;
}


string
f_1209_77330_77373()
{
var return_v = RegistryProviderStrings.ClearPropertyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 77330, 77373);
return return_v;
}


string
f_1209_77416_77469()
{
var return_v = RegistryProviderStrings.ClearPropertyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 77416, 77469);
return return_v;
}


System.Management.Automation.PSObject
f_1209_77541_77555()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 77541, 77555);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_77732_77736()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 77732, 77736);
return return_v;
}


System.Globalization.CultureInfo
f_1209_77732_77751(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 77732, 77751);
return return_v;
}


string
f_1209_77696_77850(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 77696, 77850);
return return_v;
}


bool
f_1209_77875_77906(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 77875, 77906);
return return_v;
}


object
f_1209_78047_78084(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
valueName)
{
var return_v = this_param.ResetRegistryKeyValue( key, valueName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 78047, 78084);
return return_v;
}


bool
f_1209_78170_78201(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 78170, 78201);
return return_v;
}


string
f_1209_78271_78297(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.GetLocalizedDefaultToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 78271, 78297);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1209_78345_78362(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 78345, 78362);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1209_78367_78418(string
name,object
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 78367, 78418);
return return_v;
}


int
f_1209_78345_78419(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 78345, 78419);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1209_77601_77627_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 77601, 77627);
return return_v;
}


int
f_1209_78509_78520(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 78509, 78520);
return 0;
}


int
f_1209_78584_78617(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.PSObject
propertyValue,string
path)
{
this_param.WritePropertyObject( (object)propertyValue, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 78584, 78617);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,76334,78644);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,76334,78644);
}
		}

public object GetPropertyDynamicParameters(
            string path,
            Collection<string> providerSpecificPickList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,79449,79624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,79601,79613);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,79449,79624);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,79449,79624);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,79449,79624);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object ClearPropertyDynamicParameters(
            string path,
            Collection<string> propertyToClear)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,80284,80452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,80429,80441);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,80284,80452);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,80284,80452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,80284,80452);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void NewProperty(
            string path,
            string propertyName,
            string type,
            object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,81562,85461);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,81724,81842) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,81724,81842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,81774,81827);

throw f_1209_81780_81826("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,81724,81842);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,81858,81964) || true) && (!f_1209_81863_81908(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,81858,81964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,81942,81949);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,81858,81964);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,81980,82044);

IRegistryWrapper 
key = f_1209_82003_82043(this, path, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82060,82131) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,82060,82131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82109,82116);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,82060,82131);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82200,82258);

string 
action = f_1209_82216_82257()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82274,82352);

string 
resourceTemplate = f_1209_82300_82351()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82368,82561);

string 
resource =
f_1209_82403_82560(f_1209_82439_82458(f_1209_82439_82443()), resourceTemplate, path, propertyName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82577,85422) || true) && (f_1209_82581_82612(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,82577,85422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82706,82729);

RegistryValueKind 
kind
=default(RegistryValueKind);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82747,82879) || true) && (!f_1209_82752_82777(this, type, out kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,82747,82879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82819,82831);

f_1209_82819_82830(                    key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,82853,82860);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,82747,82879);
}

                try
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,83062,83786) || true) && (f_1209_83066_83071()||(DynAbs.Tracing.TraceSender.Expression_False(1209, 83066, 83109)||f_1209_83075_83101(key, propertyName)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,83062,83786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,83204,83259);

f_1209_83204_83258(this, key, propertyName, value, kind, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,83062,83786);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,83062,83786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,83415,83577);

System.IO.IOException 
e =
f_1209_83470_83576(f_1209_83530_83575())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,83603,83692);

f_1209_83603_83691(this, f_1209_83614_83690(e, f_1209_83633_83653(f_1209_83633_83644(e)), ErrorCategory.ResourceExists, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,83718,83730);

f_1209_83718_83729(                        key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,83756,83763);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,83062,83786);
}
                }
                catch (ArgumentException argumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,83823,84043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,83907,84024);

f_1209_83907_84023(this, f_1209_83918_84022(argumentException, f_1209_83953_83989(f_1209_83953_83980(argumentException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,83823,84043);
                }
                catch (InvalidCastException invalidCast)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,84061,84266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,84142,84247);

f_1209_84142_84246(this, f_1209_84153_84245(invalidCast, f_1209_84182_84212(f_1209_84182_84203(invalidCast)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,84061,84266);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,84284,84612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,84488,84593);

f_1209_84488_84592(this, f_1209_84499_84591(ioException, f_1209_84528_84558(f_1209_84528_84549(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,84284,84612);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,84630,84994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,84852,84975);

f_1209_84852_84974(this, f_1209_84863_84973(securityException, f_1209_84898_84934(f_1209_84898_84925(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,84630,84994);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,85012,85407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,85245,85388);

f_1209_85245_85387(this, f_1209_85256_85386(unauthorizedAccessException, f_1209_85301_85347(f_1209_85301_85338(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,85012,85407);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,82577,85422);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,85438,85450);

f_1209_85438_85449(
            key);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,81562,85461);

System.Management.Automation.PSArgumentNullException
f_1209_81780_81826(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 81780, 81826);
return return_v;
}


bool
f_1209_81863_81908(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 81863, 81908);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_82003_82043(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 82003, 82043);
return return_v;
}


string
f_1209_82216_82257()
{
var return_v = RegistryProviderStrings.NewPropertyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 82216, 82257);
return return_v;
}


string
f_1209_82300_82351()
{
var return_v = RegistryProviderStrings.NewPropertyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 82300, 82351);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_82439_82443()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 82439, 82443);
return return_v;
}


System.Globalization.CultureInfo
f_1209_82439_82458(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 82439, 82458);
return return_v;
}


string
f_1209_82403_82560(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 82403, 82560);
return return_v;
}


bool
f_1209_82581_82612(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 82581, 82612);
return return_v;
}


bool
f_1209_82752_82777(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
type,out Microsoft.Win32.RegistryValueKind
kind)
{
var return_v = this_param.ParseKind( type, out kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 82752, 82777);
return return_v;
}


int
f_1209_82819_82830(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 82819, 82830);
return 0;
}


System.Management.Automation.SwitchParameter
f_1209_83066_83071()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 83066, 83071);
return return_v;
}


object
f_1209_83075_83101(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83075, 83101);
return return_v;
}


int
f_1209_83204_83258(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
propertyName,object
value,Microsoft.Win32.RegistryValueKind
kind,string
path)
{
this_param.SetRegistryValue( key, propertyName, value, kind, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83204, 83258);
return 0;
}


string
f_1209_83530_83575()
{
var return_v =                                 RegistryProviderStrings.PropertyAlreadyExists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 83530, 83575);
return return_v;
}


System.IO.IOException
f_1209_83470_83576(string
message)
{
var return_v = new System.IO.IOException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83470, 83576);
return return_v;
}


System.Type
f_1209_83633_83644(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83633, 83644);
return return_v;
}


string
f_1209_83633_83653(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 83633, 83653);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_83614_83690(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83614, 83690);
return return_v;
}


int
f_1209_83603_83691(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83603, 83691);
return 0;
}


int
f_1209_83718_83729(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83718, 83729);
return 0;
}


System.Type
f_1209_83953_83980(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83953, 83980);
return return_v;
}


string
f_1209_83953_83989(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 83953, 83989);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_83918_84022(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83918, 84022);
return return_v;
}


int
f_1209_83907_84023(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 83907, 84023);
return 0;
}


System.Type
f_1209_84182_84203(System.InvalidCastException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84182, 84203);
return return_v;
}


string
f_1209_84182_84212(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 84182, 84212);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_84153_84245(System.InvalidCastException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84153, 84245);
return return_v;
}


int
f_1209_84142_84246(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84142, 84246);
return 0;
}


System.Type
f_1209_84528_84549(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84528, 84549);
return return_v;
}


string
f_1209_84528_84558(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 84528, 84558);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_84499_84591(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84499, 84591);
return return_v;
}


int
f_1209_84488_84592(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84488, 84592);
return 0;
}


System.Type
f_1209_84898_84925(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84898, 84925);
return return_v;
}


string
f_1209_84898_84934(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 84898, 84934);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_84863_84973(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84863, 84973);
return return_v;
}


int
f_1209_84852_84974(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 84852, 84974);
return 0;
}


System.Type
f_1209_85301_85338(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 85301, 85338);
return return_v;
}


string
f_1209_85301_85347(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 85301, 85347);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_85256_85386(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 85256, 85386);
return return_v;
}


int
f_1209_85245_85387(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 85245, 85387);
return 0;
}


int
f_1209_85438_85449(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 85438, 85449);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,81562,85461);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,81562,85461);
}
		}

public void RemoveProperty(
            string path,
            string propertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,86017,89378);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86129,86247) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,86129,86247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86179,86232);

throw f_1209_86185_86231("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,86129,86247);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86263,86369) || true) && (!f_1209_86268_86313(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,86263,86369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86347,86354);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,86263,86369);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86385,86449);

IRegistryWrapper 
key = f_1209_86408_86448(this, path, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86465,86536) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,86465,86536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86514,86521);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,86465,86536);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86552,86669);

WildcardPattern 
propertyNamePattern =
f_1209_86607_86668(propertyName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86685,86708);

bool 
hadAMatch = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86724,89261);
foreach(string valueName in f_1209_86753_86772_I(f_1209_86753_86772(key)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,86724,89261);

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,86806,87126) || true) && (((f_1209_86834_86868_M(!f_1209_86835_86842().SuppressWildcardExpansion)) &&(DynAbs.Tracing.TraceSender.Expression_True(1209, 86833, 86914)&&(!f_1209_86875_86913(propertyNamePattern, valueName)))) ||(DynAbs.Tracing.TraceSender.Expression_False(1209, 86832, 87056)||                    (f_1209_86941_86974(f_1209_86941_86948())&&(DynAbs.Tracing.TraceSender.Expression_True(1209, 86941, 87055)&&(!f_1209_86980_87054(valueName, propertyName, StringComparison.OrdinalIgnoreCase))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,86806,87126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87098,87107);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,86806,87126);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87146,87163);

hadAMatch = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87238,87299);

string 
action = f_1209_87254_87298()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87319,87400);

string 
resourceTemplate = f_1209_87345_87399()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87420,87630);

string 
resource =
f_1209_87459_87629(f_1209_87499_87518(f_1209_87499_87503()), resourceTemplate, path, valueName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87650,89246) || true) && (f_1209_87654_87685(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,87650,89246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87727,87784);

string 
propertyNameToRemove = f_1209_87757_87783(this, valueName)
;

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,87905,87943);

f_1209_87905_87942(                        // Remove the value
                        key, propertyNameToRemove);
                    }
                    catch (System.IO.IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,87988,88352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,88208,88329);

f_1209_88208_88328(this, f_1209_88219_88327(ioException, f_1209_88248_88278(f_1209_88248_88269(ioException)), ErrorCategory.WriteError, propertyNameToRemove));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,87988,88352);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,88374,88774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,88612,88751);

f_1209_88612_88750(this, f_1209_88623_88749(securityException, f_1209_88658_88694(f_1209_88658_88685(securityException)), ErrorCategory.PermissionDenied, propertyNameToRemove));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,88374,88774);
                    }
                    catch (System.UnauthorizedAccessException unauthorizedAccessException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,88796,89227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,89045,89204);

f_1209_89045_89203(this, f_1209_89056_89202(unauthorizedAccessException, f_1209_89101_89147(f_1209_89101_89138(unauthorizedAccessException)), ErrorCategory.PermissionDenied, propertyNameToRemove));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,88796,89227);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,87650,89246);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,86724,89261);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,2538);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,2538);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,89277,89289);

f_1209_89277_89288(
            key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,89303,89367);

f_1209_89303_89366(this, hadAMatch, path, propertyName);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,86017,89378);

System.Management.Automation.PSArgumentNullException
f_1209_86185_86231(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86185, 86231);
return return_v;
}


bool
f_1209_86268_86313(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86268, 86313);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_86408_86448(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86408, 86448);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1209_86607_86668(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86607, 86668);
return return_v;
}


string[]
f_1209_86753_86772(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetValueNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86753, 86772);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1209_86835_86842()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 86835, 86842);
return return_v;
}


bool
f_1209_86834_86868_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 86834, 86868);
return return_v;
}


bool
f_1209_86875_86913(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86875, 86913);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1209_86941_86948()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 86941, 86948);
return return_v;
}


bool
f_1209_86941_86974(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.SuppressWildcardExpansion ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 86941, 86974);
return return_v;
}


bool
f_1209_86980_87054(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86980, 87054);
return return_v;
}


string
f_1209_87254_87298()
{
var return_v = RegistryProviderStrings.RemovePropertyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 87254, 87298);
return return_v;
}


string
f_1209_87345_87399()
{
var return_v = RegistryProviderStrings.RemovePropertyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 87345, 87399);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_87499_87503()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 87499, 87503);
return return_v;
}


System.Globalization.CultureInfo
f_1209_87499_87518(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 87499, 87518);
return return_v;
}


string
f_1209_87459_87629(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 87459, 87629);
return return_v;
}


bool
f_1209_87654_87685(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 87654, 87685);
return return_v;
}


string
f_1209_87757_87783(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
userEnteredPropertyName)
{
var return_v = this_param.GetPropertyName( userEnteredPropertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 87757, 87783);
return return_v;
}


int
f_1209_87905_87942(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
this_param.DeleteValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 87905, 87942);
return 0;
}


System.Type
f_1209_88248_88269(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 88248, 88269);
return return_v;
}


string
f_1209_88248_88278(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 88248, 88278);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_88219_88327(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 88219, 88327);
return return_v;
}


int
f_1209_88208_88328(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 88208, 88328);
return 0;
}


System.Type
f_1209_88658_88685(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 88658, 88685);
return return_v;
}


string
f_1209_88658_88694(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 88658, 88694);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_88623_88749(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 88623, 88749);
return return_v;
}


int
f_1209_88612_88750(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 88612, 88750);
return 0;
}


System.Type
f_1209_89101_89138(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 89101, 89138);
return return_v;
}


string
f_1209_89101_89147(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 89101, 89147);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_89056_89202(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 89056, 89202);
return return_v;
}


int
f_1209_89045_89203(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 89045, 89203);
return 0;
}


string[]
f_1209_86753_86772_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 86753, 86772);
return return_v;
}


int
f_1209_89277_89288(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 89277, 89288);
return 0;
}


int
f_1209_89303_89366(Microsoft.PowerShell.Commands.RegistryProvider
this_param,bool
hadAMatch,string
path,string
requestedValueName)
{
this_param.WriteErrorIfPerfectMatchNotFound( hadAMatch, path, requestedValueName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 89303, 89366);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,86017,89378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,86017,89378);
}
		}

public void RenameProperty(
            string path,
            string sourceProperty,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,90045,92490);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90200,90318) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,90200,90318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90250,90303);

throw f_1209_90256_90302("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,90200,90318);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90334,90440) || true) && (!f_1209_90339_90384(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,90334,90440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90418,90425);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,90334,90440);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90456,90520);

IRegistryWrapper 
key = f_1209_90479_90519(this, path, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90536,90607) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,90536,90607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90585,90592);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,90536,90607);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90676,90737);

string 
action = f_1209_90692_90736()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90753,90834);

string 
resourceTemplate = f_1209_90779_90833()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,90850,91087);

string 
resource =
f_1209_90885_91086(f_1209_90921_90940(f_1209_90921_90925()), resourceTemplate, path, sourceProperty, destinationProperty)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,91103,92451) || true) && (f_1209_91107_91138(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,91103,92451);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,91216,91276);

f_1209_91216_91275(this, key, key, sourceProperty, destinationProperty);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,91313,91641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,91517,91622);

f_1209_91517_91621(this, f_1209_91528_91620(ioException, f_1209_91557_91587(f_1209_91557_91578(ioException)), ErrorCategory.WriteError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,91313,91641);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,91659,92023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,91881,92004);

f_1209_91881_92003(this, f_1209_91892_92002(securityException, f_1209_91927_91963(f_1209_91927_91954(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,91659,92023);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,92041,92436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,92274,92417);

f_1209_92274_92416(this, f_1209_92285_92415(unauthorizedAccessException, f_1209_92330_92376(f_1209_92330_92367(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,92041,92436);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,91103,92451);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,92467,92479);

f_1209_92467_92478(
            key);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,90045,92490);

System.Management.Automation.PSArgumentNullException
f_1209_90256_90302(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 90256, 90302);
return return_v;
}


bool
f_1209_90339_90384(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 90339, 90384);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_90479_90519(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 90479, 90519);
return return_v;
}


string
f_1209_90692_90736()
{
var return_v = RegistryProviderStrings.RenamePropertyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 90692, 90736);
return return_v;
}


string
f_1209_90779_90833()
{
var return_v = RegistryProviderStrings.RenamePropertyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 90779, 90833);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_90921_90925()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 90921, 90925);
return return_v;
}


System.Globalization.CultureInfo
f_1209_90921_90940(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 90921, 90940);
return return_v;
}


string
f_1209_90885_91086(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1,string
arg2)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 90885, 91086);
return return_v;
}


bool
f_1209_91107_91138(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91107, 91138);
return return_v;
}


int
f_1209_91216_91275(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
sourceKey,Microsoft.PowerShell.Commands.IRegistryWrapper
destinationKey,string
sourceProperty,string
destinationProperty)
{
this_param.MoveProperty( sourceKey, destinationKey, sourceProperty, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91216, 91275);
return 0;
}


System.Type
f_1209_91557_91578(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91557, 91578);
return return_v;
}


string
f_1209_91557_91587(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 91557, 91587);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_91528_91620(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91528, 91620);
return return_v;
}


int
f_1209_91517_91621(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91517, 91621);
return 0;
}


System.Type
f_1209_91927_91954(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91927, 91954);
return return_v;
}


string
f_1209_91927_91963(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 91927, 91963);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_91892_92002(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91892, 92002);
return return_v;
}


int
f_1209_91881_92003(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 91881, 92003);
return 0;
}


System.Type
f_1209_92330_92367(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 92330, 92367);
return return_v;
}


string
f_1209_92330_92376(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 92330, 92376);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_92285_92415(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 92285, 92415);
return return_v;
}


int
f_1209_92274_92416(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 92274, 92416);
return 0;
}


int
f_1209_92467_92478(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 92467, 92478);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,90045,92490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,90045,92490);
}
		}

public void CopyProperty(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,93384,96341);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,93580,93710) || true) && (sourcePath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,93580,93710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,93636,93695);

throw f_1209_93642_93694("sourcePath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,93580,93710);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,93726,93866) || true) && (destinationPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,93726,93866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,93787,93851);

throw f_1209_93793_93850("destinationPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,93726,93866);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,93882,94011) || true) && (!f_1209_93887_93955(this, sourcePath, destinationPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,93882,94011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,93989,93996);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,93882,94011);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94027,94098);

IRegistryWrapper 
key = f_1209_94050_94097(this, sourcePath, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94114,94185) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,94114,94185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94163,94170);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,94114,94185);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94201,94287);

IRegistryWrapper 
destinationKey = f_1209_94235_94286(this, destinationPath, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94301,94383) || true) && (destinationKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,94301,94383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94361,94368);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,94301,94383);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94452,94511);

string 
action = f_1209_94468_94510()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94527,94606);

string 
resourceTemplate = f_1209_94553_94605()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94622,94903);

string 
resource =
f_1209_94657_94902(f_1209_94693_94712(f_1209_94693_94697()), resourceTemplate, sourcePath, sourceProperty, destinationPath, destinationProperty)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,94919,96302) || true) && (f_1209_94923_94954(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,94919,96302);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,95032,95109);

f_1209_95032_95108(this, key, destinationKey, sourceProperty, destinationProperty, true);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,95146,95480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,95350,95461);

f_1209_95350_95460(this, f_1209_95361_95459(ioException, f_1209_95390_95420(f_1209_95390_95411(ioException)), ErrorCategory.WriteError, sourcePath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,95146,95480);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,95498,95868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,95720,95849);

f_1209_95720_95848(this, f_1209_95731_95847(securityException, f_1209_95766_95802(f_1209_95766_95793(securityException)), ErrorCategory.PermissionDenied, sourcePath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,95498,95868);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,95886,96287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,96119,96268);

f_1209_96119_96267(this, f_1209_96130_96266(unauthorizedAccessException, f_1209_96175_96221(f_1209_96175_96212(unauthorizedAccessException)), ErrorCategory.PermissionDenied, sourcePath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,95886,96287);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,94919,96302);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,96318,96330);

f_1209_96318_96329(
            key);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,93384,96341);

System.Management.Automation.PSArgumentNullException
f_1209_93642_93694(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 93642, 93694);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1209_93793_93850(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 93793, 93850);
return return_v;
}


bool
f_1209_93887_93955(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
sourcePath,string
destinationPath)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( sourcePath, destinationPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 93887, 93955);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_94050_94097(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 94050, 94097);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_94235_94286(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 94235, 94286);
return return_v;
}


string
f_1209_94468_94510()
{
var return_v = RegistryProviderStrings.CopyPropertyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 94468, 94510);
return return_v;
}


string
f_1209_94553_94605()
{
var return_v = RegistryProviderStrings.CopyPropertyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 94553, 94605);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_94693_94697()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 94693, 94697);
return return_v;
}


System.Globalization.CultureInfo
f_1209_94693_94712(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 94693, 94712);
return return_v;
}


string
f_1209_94657_94902(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 94657, 94902);
return return_v;
}


bool
f_1209_94923_94954(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 94923, 94954);
return return_v;
}


int
f_1209_95032_95108(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
sourceKey,Microsoft.PowerShell.Commands.IRegistryWrapper
destinationKey,string
sourceProperty,string
destinationProperty,bool
writeOnSuccess)
{
this_param.CopyProperty( sourceKey, destinationKey, sourceProperty, destinationProperty, writeOnSuccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 95032, 95108);
return 0;
}


System.Type
f_1209_95390_95411(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 95390, 95411);
return return_v;
}


string
f_1209_95390_95420(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 95390, 95420);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_95361_95459(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 95361, 95459);
return return_v;
}


int
f_1209_95350_95460(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 95350, 95460);
return 0;
}


System.Type
f_1209_95766_95793(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 95766, 95793);
return return_v;
}


string
f_1209_95766_95802(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 95766, 95802);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_95731_95847(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 95731, 95847);
return return_v;
}


int
f_1209_95720_95848(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 95720, 95848);
return 0;
}


System.Type
f_1209_96175_96212(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 96175, 96212);
return return_v;
}


string
f_1209_96175_96221(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 96175, 96221);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_96130_96266(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 96130, 96266);
return return_v;
}


int
f_1209_96119_96267(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 96119, 96267);
return 0;
}


int
f_1209_96318_96329(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 96318, 96329);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,93384,96341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,93384,96341);
}
		}

public void MoveProperty(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,97160,100147);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97356,97486) || true) && (sourcePath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,97356,97486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97412,97471);

throw f_1209_97418_97470("sourcePath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,97356,97486);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97502,97642) || true) && (destinationPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,97502,97642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97563,97627);

throw f_1209_97569_97626("destinationPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,97502,97642);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97658,97787) || true) && (!f_1209_97663_97731(this, sourcePath, destinationPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,97658,97787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97765,97772);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,97658,97787);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97803,97873);

IRegistryWrapper 
key = f_1209_97826_97872(this, sourcePath, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97889,97960) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,97889,97960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97938,97945);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,97889,97960);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,97976,98062);

IRegistryWrapper 
destinationKey = f_1209_98010_98061(this, destinationPath, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,98076,98158) || true) && (destinationKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,98076,98158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,98136,98143);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,98076,98158);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,98227,98286);

string 
action = f_1209_98243_98285()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,98302,98381);

string 
resourceTemplate = f_1209_98328_98380()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,98397,98678);

string 
resource =
f_1209_98432_98677(f_1209_98468_98487(f_1209_98468_98472()), resourceTemplate, sourcePath, sourceProperty, destinationPath, destinationProperty)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,98694,100071) || true) && (f_1209_98698_98729(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,98694,100071);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,98807,98878);

f_1209_98807_98877(this, key, destinationKey, sourceProperty, destinationProperty);
                }
                catch (System.IO.IOException ioException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,98915,99249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,99119,99230);

f_1209_99119_99229(this, f_1209_99130_99228(ioException, f_1209_99159_99189(f_1209_99159_99180(ioException)), ErrorCategory.WriteError, sourcePath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,98915,99249);
                }
                catch (System.Security.SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,99267,99637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,99489,99618);

f_1209_99489_99617(this, f_1209_99500_99616(securityException, f_1209_99535_99571(f_1209_99535_99562(securityException)), ErrorCategory.PermissionDenied, sourcePath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,99267,99637);
                }
                catch (System.UnauthorizedAccessException unauthorizedAccessException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,99655,100056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,99888,100037);

f_1209_99888_100036(this, f_1209_99899_100035(unauthorizedAccessException, f_1209_99944_99990(f_1209_99944_99981(unauthorizedAccessException)), ErrorCategory.PermissionDenied, sourcePath));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,99655,100056);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,98694,100071);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,100087,100099);

f_1209_100087_100098(
            key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,100113,100136);

f_1209_100113_100135(            destinationKey);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,97160,100147);

System.Management.Automation.PSArgumentNullException
f_1209_97418_97470(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 97418, 97470);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1209_97569_97626(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 97569, 97626);
return return_v;
}


bool
f_1209_97663_97731(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
sourcePath,string
destinationPath)
{
var return_v = this_param.CheckOperationNotAllowedOnHiveContainer( sourcePath, destinationPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 97663, 97731);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_97826_97872(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 97826, 97872);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_98010_98061(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 98010, 98061);
return return_v;
}


string
f_1209_98243_98285()
{
var return_v = RegistryProviderStrings.MovePropertyAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 98243, 98285);
return return_v;
}


string
f_1209_98328_98380()
{
var return_v = RegistryProviderStrings.MovePropertyResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 98328, 98380);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_98468_98472()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 98468, 98472);
return return_v;
}


System.Globalization.CultureInfo
f_1209_98468_98487(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 98468, 98487);
return return_v;
}


string
f_1209_98432_98677(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 98432, 98677);
return return_v;
}


bool
f_1209_98698_98729(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 98698, 98729);
return return_v;
}


int
f_1209_98807_98877(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
sourceKey,Microsoft.PowerShell.Commands.IRegistryWrapper
destinationKey,string
sourceProperty,string
destinationProperty)
{
this_param.MoveProperty( sourceKey, destinationKey, sourceProperty, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 98807, 98877);
return 0;
}


System.Type
f_1209_99159_99180(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99159, 99180);
return return_v;
}


string
f_1209_99159_99189(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 99159, 99189);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_99130_99228(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99130, 99228);
return return_v;
}


int
f_1209_99119_99229(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99119, 99229);
return 0;
}


System.Type
f_1209_99535_99562(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99535, 99562);
return return_v;
}


string
f_1209_99535_99571(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 99535, 99571);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_99500_99616(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99500, 99616);
return return_v;
}


int
f_1209_99489_99617(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99489, 99617);
return 0;
}


System.Type
f_1209_99944_99981(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99944, 99981);
return return_v;
}


string
f_1209_99944_99990(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 99944, 99990);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_99899_100035(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99899, 100035);
return return_v;
}


int
f_1209_99888_100036(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 99888, 100036);
return 0;
}


int
f_1209_100087_100098(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 100087, 100098);
return 0;
}


int
f_1209_100113_100135(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 100113, 100135);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,97160,100147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,97160,100147);
}
		}

protected override string GetParentPath(string path, string root)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,100748,102374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,100838,100889);

string 
parentPath = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetParentPath(path,root),1209,100858,100888)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101195,102308) || true) && (!f_1209_101200_101267(parentPath, root, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,101195,102308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101301,101344);

bool 
originalPathExists = f_1209_101327_101343(this, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101362,101402);

bool 
originalPathExistsWithRoot = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101495,101603) || true) && (!originalPathExists)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,101495,101603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101541,101603);

originalPathExistsWithRoot = f_1209_101570_101602(this, f_1209_101581_101601(this, root, path));
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,101495,101603);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101623,102293) || true) && ((!f_1209_101629_101661(parentPath)) &&(DynAbs.Tracing.TraceSender.Expression_True(1209, 101627, 101716)&&(originalPathExists ||(DynAbs.Tracing.TraceSender.Expression_False(1209, 101667, 101715)||originalPathExistsWithRoot))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,101623,102293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101758,101795);

string 
parentPathToTest = parentPath
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,101819,102274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101870,101900);

parentPathToTest = parentPath;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101926,102033) || true) && (originalPathExistsWithRoot)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,101926,102033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101987,102033);

parentPathToTest = f_1209_102006_102032(this, root, parentPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,101926,102033);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,102061,102130) || true) && (f_1209_102065_102093(this, parentPathToTest))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,102061,102130);
DynAbs.Tracing.TraceSender.TraceBreak(1209,102124,102130);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,102061,102130);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,102158,102208);

parentPath = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetParentPath(parentPath,root),1209,102171,102207);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,101819,102274);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,101819,102274) || true) && (!f_1209_102240_102272(parentPath))
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,101819,102274);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,101819,102274);
}}DynAbs.Tracing.TraceSender.TraceExitCondition(1209,101623,102293);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,101195,102308);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,102324,102363);

return f_1209_102331_102362(parentPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,100748,102374);

bool
f_1209_101200_101267(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 101200, 101267);
return return_v;
}


bool
f_1209_101327_101343(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 101327, 101343);
return return_v;
}


string
f_1209_101581_101601(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 101581, 101601);
return return_v;
}


bool
f_1209_101570_101602(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 101570, 101602);
return return_v;
}


bool
f_1209_101629_101661(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 101629, 101661);
return return_v;
}


string
f_1209_102006_102032(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 102006, 102032);
return return_v;
}


bool
f_1209_102065_102093(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 102065, 102093);
return return_v;
}


bool
f_1209_102240_102272(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 102240, 102272);
return return_v;
}


string
f_1209_102331_102362(string
path)
{
var return_v = EnsureDriveIsRooted( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 102331, 102362);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,100748,102374);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,100748,102374);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override string GetChildName(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,102911,103091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,102987,103030);

string 
childName = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetChildName(path),1209,103006,103029)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,103044,103080);

return f_1209_103051_103079(childName, '\\', '/');
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,102911,103091);

string
f_1209_103051_103079(string
this_param,char
oldChar,char
newChar)
{
var return_v = this_param.Replace( oldChar, newChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 103051, 103079);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,102911,103091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,102911,103091);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string EnsureDriveIsRooted(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1209,103103,103676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,103182,103203);

string 
result = path
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,103262,103292);

int 
index = f_1209_103274_103291(path, ':')
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,103308,103635) || true) && (index != -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,103308,103635);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,103479,103620) || true) && (index + 1 == f_1209_103496_103507(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,103479,103620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,103549,103601);

result = path + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(),1209,103565,103600);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,103479,103620);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,103308,103635);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,103651,103665);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1209,103103,103676);

int
f_1209_103274_103291(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 103274, 103291);
return return_v;
}


int
f_1209_103496_103507(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 103496, 103507);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,103103,103676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,103103,103676);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object NewPropertyDynamicParameters(
            string path,
            string propertyName,
            string type,
            object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,104626,104830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,104807,104819);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,104626,104830);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,104626,104830);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,104626,104830);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object RemovePropertyDynamicParameters(
            string path,
            string propertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,105502,105656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,105633,105645);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,105502,105656);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,105502,105656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,105502,105656);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object RenamePropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,106418,106615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,106592,106604);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,106418,106615);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,106418,106615);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,106418,106615);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object CopyPropertyDynamicParameters(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,107532,107770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,107747,107759);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,107532,107770);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,107532,107770);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,107532,107770);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object MovePropertyDynamicParameters(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,108687,108925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,108902,108914);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,108687,108925);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,108687,108925);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,108687,108925);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CopyProperty(
            IRegistryWrapper sourceKey,
            IRegistryWrapper destinationKey,
            string sourceProperty,
            string destinationProperty,
            bool writeOnSuccess)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,109069,109874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,109318,109378);

string 
realSourceProperty = f_1209_109346_109377(this, sourceProperty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,109392,109462);

string 
realDestinationProperty = f_1209_109425_109461(this, destinationProperty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,109478,109534);

object 
sourceValue = f_1209_109499_109533(sourceKey, sourceProperty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,109548,109618);

RegistryValueKind 
sourceKind = f_1209_109579_109617(sourceKey, sourceProperty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,109634,109704);

f_1209_109634_109703(
            destinationKey, destinationProperty, sourceValue, sourceKind);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,109720,109863) || true) && (writeOnSuccess)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,109720,109863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,109772,109848);

f_1209_109772_109847(this, sourceValue, realSourceProperty, f_1209_109832_109846(sourceKey));
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,109720,109863);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,109069,109874);

string
f_1209_109346_109377(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
userEnteredPropertyName)
{
var return_v = this_param.GetPropertyName( userEnteredPropertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 109346, 109377);
return return_v;
}


string
f_1209_109425_109461(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
userEnteredPropertyName)
{
var return_v = this_param.GetPropertyName( userEnteredPropertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 109425, 109461);
return return_v;
}


object
f_1209_109499_109533(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 109499, 109533);
return return_v;
}


Microsoft.Win32.RegistryValueKind
f_1209_109579_109617(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValueKind( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 109579, 109617);
return return_v;
}


int
f_1209_109634_109703(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
value,Microsoft.Win32.RegistryValueKind
valueKind)
{
this_param.SetValue( name, value, valueKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 109634, 109703);
return 0;
}


string
f_1209_109832_109846(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 109832, 109846);
return return_v;
}


int
f_1209_109772_109847(Microsoft.PowerShell.Commands.RegistryProvider
this_param,object
value,string
propertyName,string
path)
{
this_param.WriteWrappedPropertyObject( value, propertyName, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 109772, 109847);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,109069,109874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,109069,109874);
}
		}

private void MoveProperty(
            IRegistryWrapper sourceKey,
            IRegistryWrapper destinationKey,
            string sourceProperty,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,109886,112788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,110101,110161);

string 
realSourceProperty = f_1209_110129_110160(this, sourceProperty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,110175,110245);

string 
realDestinationProperty = f_1209_110208_110244(this, destinationProperty)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,110440,110471);

bool 
continueWithRemove = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,110491,110788) || true) && (f_1209_110495_110581(f_1209_110509_110523(sourceKey), f_1209_110525_110544(destinationKey), StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1209, 110495, 110700)&&f_1209_110606_110700(realSourceProperty, realDestinationProperty, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,110491,110788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,110742,110769);

continueWithRemove = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,110491,110788);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,110972,111170);

f_1209_110972_111169(this, sourceKey, destinationKey, realSourceProperty, realDestinationProperty, false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,111279,111404) || true) && (continueWithRemove)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,111279,111404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,111343,111385);

f_1209_111343_111384(                    sourceKey, realSourceProperty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,111279,111404);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,111424,111491);

object 
newValue = f_1209_111442_111490(destinationKey, realDestinationProperty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,111509,111588);

f_1209_111509_111587(this, newValue, destinationProperty, f_1209_111567_111586(destinationKey));
            }
            catch (System.IO.IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,111617,111960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,111805,111920);

f_1209_111805_111919(this, f_1209_111816_111918(ioException, f_1209_111845_111875(f_1209_111845_111866(ioException)), ErrorCategory.WriteError, f_1209_111903_111917(sourceKey)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,111938,111945);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,111617,111960);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,111974,112353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,112180,112313);

f_1209_112180_112312(this, f_1209_112191_112311(securityException, f_1209_112226_112262(f_1209_112226_112253(securityException)), ErrorCategory.PermissionDenied, f_1209_112296_112310(sourceKey)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,112331,112338);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,111974,112353);
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,112367,112777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,112584,112737);

f_1209_112584_112736(this, f_1209_112595_112735(unauthorizedAccessException, f_1209_112640_112686(f_1209_112640_112677(unauthorizedAccessException)), ErrorCategory.PermissionDenied, f_1209_112720_112734(sourceKey)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,112755,112762);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,112367,112777);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,109886,112788);

string
f_1209_110129_110160(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
userEnteredPropertyName)
{
var return_v = this_param.GetPropertyName( userEnteredPropertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 110129, 110160);
return return_v;
}


string
f_1209_110208_110244(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
userEnteredPropertyName)
{
var return_v = this_param.GetPropertyName( userEnteredPropertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 110208, 110244);
return return_v;
}


string
f_1209_110509_110523(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 110509, 110523);
return return_v;
}


string
f_1209_110525_110544(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 110525, 110544);
return return_v;
}


bool
f_1209_110495_110581(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 110495, 110581);
return return_v;
}


bool
f_1209_110606_110700(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 110606, 110700);
return return_v;
}


int
f_1209_110972_111169(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
sourceKey,Microsoft.PowerShell.Commands.IRegistryWrapper
destinationKey,string
sourceProperty,string
destinationProperty,bool
writeOnSuccess)
{
this_param.CopyProperty( sourceKey, destinationKey, sourceProperty, destinationProperty, writeOnSuccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 110972, 111169);
return 0;
}


int
f_1209_111343_111384(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
this_param.DeleteValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 111343, 111384);
return 0;
}


object
f_1209_111442_111490(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 111442, 111490);
return return_v;
}


string
f_1209_111567_111586(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 111567, 111586);
return return_v;
}


int
f_1209_111509_111587(Microsoft.PowerShell.Commands.RegistryProvider
this_param,object
value,string
propertyName,string
path)
{
this_param.WriteWrappedPropertyObject( value, propertyName, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 111509, 111587);
return 0;
}


System.Type
f_1209_111845_111866(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 111845, 111866);
return return_v;
}


string
f_1209_111845_111875(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 111845, 111875);
return return_v;
}


string
f_1209_111903_111917(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 111903, 111917);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_111816_111918(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 111816, 111918);
return return_v;
}


int
f_1209_111805_111919(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 111805, 111919);
return 0;
}


System.Type
f_1209_112226_112253(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 112226, 112253);
return return_v;
}


string
f_1209_112226_112262(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 112226, 112262);
return return_v;
}


string
f_1209_112296_112310(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 112296, 112310);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_112191_112311(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 112191, 112311);
return return_v;
}


int
f_1209_112180_112312(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 112180, 112312);
return 0;
}


System.Type
f_1209_112640_112677(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 112640, 112677);
return return_v;
}


string
f_1209_112640_112686(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 112640, 112686);
return return_v;
}


string
f_1209_112720_112734(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 112720, 112734);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_112595_112735(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 112595, 112735);
return return_v;
}


int
f_1209_112584_112736(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 112584, 112736);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,109886,112788);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,109886,112788);
}
		}

private string NormalizePath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,113079,113606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,113145,113166);

string 
result = path
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,113182,113565) || true) && (!f_1209_113187_113213(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,113182,113565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,113247,113345);

result = f_1209_113256_113344(path, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,113413,113550) || true) && (f_1209_113417_113444(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,113413,113550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,113486,113531);

result = f_1209_113495_113530(this, result, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,113413,113550);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,113182,113565);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,113581,113595);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,113079,113606);

bool
f_1209_113187_113213(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113187, 113213);
return return_v;
}


string
f_1209_113256_113344(string
this_param,char
oldChar,char
newChar)
{
var return_v = this_param.Replace( oldChar, newChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113256, 113344);
return return_v;
}


bool
f_1209_113417_113444(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.HasRelativePathTokens( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113417, 113444);
return return_v;
}


string
f_1209_113495_113530(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,string
basePath)
{
var return_v = this_param.NormalizeRelativePath( path, basePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113495, 113530);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,113079,113606);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,113079,113606);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool HasRelativePathTokens(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,113618,114192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,113690,114181);

return (
f_1209_113716_113737(                path, '\\')||(DynAbs.Tracing.TraceSender.Expression_False(1209, 113716, 113780)||f_1209_113758_113780(                path, "\\.\\"))||(DynAbs.Tracing.TraceSender.Expression_False(1209, 113716, 113824)||f_1209_113801_113824(                path, "\\..\\"))||(DynAbs.Tracing.TraceSender.Expression_False(1209, 113716, 113902)||f_1209_113845_113902(                path, "\\..", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1209, 113716, 113979)||f_1209_113923_113979(                path, "\\.", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1209, 113716, 114059)||f_1209_114000_114059(                path, "..\\", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1209, 113716, 114138)||f_1209_114080_114138(                path, ".\\", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1209, 113716, 114179)||f_1209_114159_114179(                path, '~')));
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,113618,114192);

bool
f_1209_113716_113737(string
this_param,char
value)
{
var return_v = this_param.StartsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113716, 113737);
return return_v;
}


bool
f_1209_113758_113780(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113758, 113780);
return return_v;
}


bool
f_1209_113801_113824(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113801, 113824);
return return_v;
}


bool
f_1209_113845_113902(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113845, 113902);
return return_v;
}


bool
f_1209_113923_113979(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 113923, 113979);
return return_v;
}


bool
f_1209_114000_114059(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 114000, 114059);
return return_v;
}


bool
f_1209_114080_114138(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 114080, 114138);
return return_v;
}


bool
f_1209_114159_114179(string
this_param,char
value)
{
var return_v = this_param.StartsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 114159, 114179);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,113618,114192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,113618,114192);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void GetFilteredRegistryKeyProperties(string path,
                                                                    Collection<string> propertyNames,
                                                                    bool getAll,
                                                                    bool writeAccess,
                                                                    out IRegistryWrapper key,
                                                                    out Collection<string> filteredCollection)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,114204,118836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,114766,114789);

bool 
expandAll = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,114805,114933) || true) && (f_1209_114809_114835(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,114805,114933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,114869,114918);

throw f_1209_114875_114917("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,114805,114933);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,114949,114995);

filteredCollection = f_1209_114970_114994();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115009,115063);

key = f_1209_115015_115062(this, path, writeAccess);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115079,115150) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,115079,115150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115128,115135);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,115079,115150);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115237,115352) || true) && (propertyNames == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,115237,115352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115296,115337);

propertyNames = f_1209_115312_115336();
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,115237,115352);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115368,115513) || true) && (f_1209_115372_115391(propertyNames)== 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1209, 115372, 115406)&&getAll))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,115368,115513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115440,115463);

f_1209_115440_115462(                propertyNames, "*");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115481,115498);

expandAll = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,115368,115513);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115529,115549);

string[] 
valueNames
=default(string[]);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115599,115632);

valueNames = f_1209_115612_115631(key);
            }
            catch (System.IO.IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,115661,115993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115849,115953);

f_1209_115849_115952(this, f_1209_115860_115951(ioException, f_1209_115889_115919(f_1209_115889_115910(ioException)), ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,115971,115978);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,115661,115993);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,116007,116376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,116213,116336);

f_1209_116213_116335(this, f_1209_116224_116334(securityException, f_1209_116259_116295(f_1209_116259_116286(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,116354,116361);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,116007,116376);
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,116390,116790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,116607,116750);

f_1209_116607_116749(this, f_1209_116618_116748(unauthorizedAccessException, f_1209_116663_116709(f_1209_116663_116700(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,116768,116775);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,116390,116790);
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,116806,118825);
foreach(string requestedValueName in f_1209_116844_116857_I(propertyNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,116806,118825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,116891,117068);

WildcardPattern 
valueNameMatcher =
f_1209_116947_117067(requestedValueName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,117088,117111);

bool 
hadAMatch = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,117131,118720);
foreach(string valueName in f_1209_117160_117170_I(valueNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,117131,118720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,117212,117248);

string 
valueNameToMatch = valueName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,117350,117758) || true) && (f_1209_117354_117385(valueName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,117350,117758);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,117559,117735) || true) && (!f_1209_117564_117604(requestedValueName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,117559,117735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,117662,117708);

valueNameToMatch = f_1209_117681_117707(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,117559,117735);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,117350,117758);
}

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,117782,118701) || true) && (expandAll ||(DynAbs.Tracing.TraceSender.Expression_False(1209, 117812, 117944)||                        ((f_1209_117852_117885(f_1209_117852_117859())== false) &&(DynAbs.Tracing.TraceSender.Expression_True(1209, 117851, 117943)&&(f_1209_117900_117942(valueNameMatcher, valueNameToMatch)))) )||(DynAbs.Tracing.TraceSender.Expression_False(1209, 117812, 118110)||                       ((f_1209_117974_118007(f_1209_117974_117981())== true) &&(DynAbs.Tracing.TraceSender.Expression_True(1209, 117973, 118109)&&(f_1209_118021_118108(valueNameToMatch, requestedValueName, StringComparison.OrdinalIgnoreCase))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,117782,118701);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,118160,118573) || true) && (f_1209_118164_118202(valueNameToMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,118160,118573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,118500,118546);

valueNameToMatch = f_1209_118519_118545(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,118160,118573);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,118601,118618);

hadAMatch = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,118644,118678);

f_1209_118644_118677(                        filteredCollection, valueName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,117782,118701);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,117131,118720);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,1590);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,1590);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,118740,118810);

f_1209_118740_118809(this, hadAMatch, path, requestedValueName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,116806,118825);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,2020);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,2020);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1209,114204,118836);

bool
f_1209_114809_114835(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 114809, 114835);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_114875_114917(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 114875, 114917);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1209_114970_114994()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 114970, 114994);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_115015_115062(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 115015, 115062);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1209_115312_115336()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 115312, 115336);
return return_v;
}


int
f_1209_115372_115391(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 115372, 115391);
return return_v;
}


int
f_1209_115440_115462(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 115440, 115462);
return 0;
}


string[]
f_1209_115612_115631(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetValueNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 115612, 115631);
return return_v;
}


System.Type
f_1209_115889_115910(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 115889, 115910);
return return_v;
}


string
f_1209_115889_115919(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 115889, 115919);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_115860_115951(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 115860, 115951);
return return_v;
}


int
f_1209_115849_115952(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 115849, 115952);
return 0;
}


System.Type
f_1209_116259_116286(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116259, 116286);
return return_v;
}


string
f_1209_116259_116295(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 116259, 116295);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_116224_116334(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116224, 116334);
return return_v;
}


int
f_1209_116213_116335(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116213, 116335);
return 0;
}


System.Type
f_1209_116663_116700(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116663, 116700);
return return_v;
}


string
f_1209_116663_116709(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 116663, 116709);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_116618_116748(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116618, 116748);
return return_v;
}


int
f_1209_116607_116749(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116607, 116749);
return 0;
}


System.Management.Automation.WildcardPattern
f_1209_116947_117067(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116947, 117067);
return return_v;
}


bool
f_1209_117354_117385(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 117354, 117385);
return return_v;
}


bool
f_1209_117564_117604(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 117564, 117604);
return return_v;
}


string
f_1209_117681_117707(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.GetLocalizedDefaultToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 117681, 117707);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1209_117852_117859()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 117852, 117859);
return return_v;
}


bool
f_1209_117852_117885(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.SuppressWildcardExpansion ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 117852, 117885);
return return_v;
}


bool
f_1209_117900_117942(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 117900, 117942);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1209_117974_117981()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 117974, 117981);
return return_v;
}


bool
f_1209_117974_118007(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.SuppressWildcardExpansion ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 117974, 118007);
return return_v;
}


bool
f_1209_118021_118108(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 118021, 118108);
return return_v;
}


bool
f_1209_118164_118202(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 118164, 118202);
return return_v;
}


string
f_1209_118519_118545(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.GetLocalizedDefaultToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 118519, 118545);
return return_v;
}


int
f_1209_118644_118677(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 118644, 118677);
return 0;
}


string[]
f_1209_117160_117170_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 117160, 117170);
return return_v;
}


int
f_1209_118740_118809(Microsoft.PowerShell.Commands.RegistryProvider
this_param,bool
hadAMatch,string
path,string
requestedValueName)
{
this_param.WriteErrorIfPerfectMatchNotFound( hadAMatch, path, requestedValueName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 118740, 118809);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1209_116844_116857_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 116844, 116857);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,114204,118836);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,114204,118836);
}
		}

private void WriteErrorIfPerfectMatchNotFound(bool hadAMatch, string path, string requestedValueName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,118848,119931);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,118974,119920) || true) && (!hadAMatch &&(DynAbs.Tracing.TraceSender.Expression_True(1209, 118978, 119055)&&!f_1209_118993_119055(requestedValueName)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,118974,119920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,119289,119353);

string 
formatString = f_1209_119311_119352()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,119371,119698);

Exception 
e =
f_1209_119406_119697(f_1209_119456_119654(f_1209_119500_119526(), formatString, requestedValueName, path), (Exception)null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,119716,119905);

f_1209_119716_119904(this, f_1209_119727_119903(e, f_1209_119789_119809(f_1209_119789_119800(                    e)), ErrorCategory.InvalidArgument, requestedValueName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,118974,119920);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,118848,119931);

bool
f_1209_118993_119055(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 118993, 119055);
return return_v;
}


string
f_1209_119311_119352()
{
var return_v = RegistryProviderStrings.PropertyNotAtPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 119311, 119352);
return return_v;
}


System.Globalization.CultureInfo
f_1209_119500_119526()
{
var return_v =                             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 119500, 119526);
return return_v;
}


string
f_1209_119456_119654(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 119456, 119654);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_119406_119697(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.PSArgumentException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 119406, 119697);
return return_v;
}


System.Type
f_1209_119789_119800(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 119789, 119800);
return return_v;
}


string
f_1209_119789_119809(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 119789, 119809);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_119727_119903(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 119727, 119903);
return return_v;
}


int
f_1209_119716_119904(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 119716, 119904);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,118848,119931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,118848,119931);
}
		}

private object ResetRegistryKeyValue(IRegistryWrapper key, string valueName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,120265,122900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,120366,120424);

RegistryValueKind 
valueKind = f_1209_120396_120423(key, valueName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,120438,120465);

object 
defaultValue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,120481,121649);

switch (valueKind)
            {

case RegistryValueKind.Binary:
                case RegistryValueKind.Unknown:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,120481,121649);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,120779,120814);

defaultValue = f_1209_120794_120813();
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1209,120861,120867);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,120481,121649);

case RegistryValueKind.DWord:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,120481,121649);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,120963,120985);

defaultValue = (int)0;
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1209,121032,121038);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,120481,121649);

case RegistryValueKind.ExpandString:
                case RegistryValueKind.String:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,120481,121649);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,121189,121217);

defaultValue = string.Empty;
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1209,121264,121270);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,120481,121649);

case RegistryValueKind.MultiString:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,120481,121649);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,121372,121409);

defaultValue = f_1209_121387_121408();
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1209,121456,121462);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,120481,121649);

case RegistryValueKind.QWord:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,120481,121649);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,121558,121581);

defaultValue = (long)0;
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1209,121628,121634);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,120481,121649);
            }

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,121701,121750);

f_1209_121701_121749(                key, valueName, defaultValue, valueKind);
            }
            catch (System.IO.IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,121779,122094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,121969,122079);

f_1209_121969_122078(this, f_1209_121980_122077(ioException, f_1209_122009_122039(f_1209_122009_122030(ioException)), ErrorCategory.WriteError, valueName));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,121779,122094);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,122108,122459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,122316,122444);

f_1209_122316_122443(this, f_1209_122327_122442(securityException, f_1209_122362_122398(f_1209_122362_122389(securityException)), ErrorCategory.PermissionDenied, valueName));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,122108,122459);
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,122473,122853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,122690,122838);

f_1209_122690_122837(this, f_1209_122701_122836(unauthorizedAccessException, f_1209_122746_122792(f_1209_122746_122783(unauthorizedAccessException)), ErrorCategory.PermissionDenied, valueName));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,122473,122853);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,122869,122889);

return defaultValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,120265,122900);

Microsoft.Win32.RegistryValueKind
f_1209_120396_120423(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValueKind( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 120396, 120423);
return return_v;
}


byte[]
f_1209_120794_120813()
{
var return_v = Array.Empty<byte>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 120794, 120813);
return return_v;
}


string[]
f_1209_121387_121408()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 121387, 121408);
return return_v;
}


int
f_1209_121701_121749(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
value,Microsoft.Win32.RegistryValueKind
valueKind)
{
this_param.SetValue( name, value, valueKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 121701, 121749);
return 0;
}


System.Type
f_1209_122009_122030(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 122009, 122030);
return return_v;
}


string
f_1209_122009_122039(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 122009, 122039);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_121980_122077(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 121980, 122077);
return return_v;
}


int
f_1209_121969_122078(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 121969, 122078);
return 0;
}


System.Type
f_1209_122362_122389(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 122362, 122389);
return return_v;
}


string
f_1209_122362_122398(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 122362, 122398);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_122327_122442(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 122327, 122442);
return return_v;
}


int
f_1209_122316_122443(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 122316, 122443);
return 0;
}


System.Type
f_1209_122746_122783(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 122746, 122783);
return return_v;
}


string
f_1209_122746_122792(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 122746, 122792);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_122701_122836(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 122701, 122836);
return return_v;
}


int
f_1209_122690_122837(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 122690, 122837);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,120265,122900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,120265,122900);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsHiveContainer(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,123246,123793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,123312,123332);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,123346,123464) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,123346,123464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,123396,123449);

throw f_1209_123402_123448("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,123346,123464);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,123480,123752) || true) && (f_1209_123484_123510(path)||(DynAbs.Tracing.TraceSender.Expression_False(1209, 123484, 123600)||                (f_1209_123532_123594(path, "\\", StringComparison.OrdinalIgnoreCase)== 0) )||(DynAbs.Tracing.TraceSender.Expression_False(1209, 123484, 123689)||                (f_1209_123622_123683(path, "/", StringComparison.OrdinalIgnoreCase)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,123480,123752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,123723,123737);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,123480,123752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,123768,123782);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,123246,123793);

System.Management.Automation.PSArgumentNullException
f_1209_123402_123448(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 123402, 123448);
return return_v;
}


bool
f_1209_123484_123510(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 123484, 123510);
return return_v;
}


int
f_1209_123532_123594(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 123532, 123594);
return return_v;
}


int
f_1209_123622_123683(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 123622, 123683);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,123246,123793);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,123246,123793);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CheckOperationNotAllowedOnHiveContainer(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,124103,124609);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,124193,124570) || true) && (f_1209_124197_124218(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,124193,124570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,124252,124327);

string 
message = f_1209_124269_124326()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,124347,124417);

InvalidOperationException 
ex = f_1209_124378_124416(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,124435,124524);

f_1209_124435_124523(this, f_1209_124446_124522(ex, "InvalidContainer", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,124542,124555);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,124193,124570);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,124586,124598);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,124103,124609);

bool
f_1209_124197_124218(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.IsHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 124197, 124218);
return return_v;
}


string
f_1209_124269_124326()
{
var return_v = RegistryProviderStrings.ContainerInvalidOperationTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 124269, 124326);
return return_v;
}


System.InvalidOperationException
f_1209_124378_124416(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 124378, 124416);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_124446_124522(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 124446, 124522);
return return_v;
}


int
f_1209_124435_124523(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 124435, 124523);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,124103,124609);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,124103,124609);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CheckOperationNotAllowedOnHiveContainer(string sourcePath, string destinationPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,124939,125932);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125059,125452) || true) && (f_1209_125063_125090(this, sourcePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,125059,125452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125124,125205);

string 
message = f_1209_125141_125204()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125223,125293);

InvalidOperationException 
ex = f_1209_125254_125292(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125311,125406);

f_1209_125311_125405(this, f_1209_125322_125404(ex, "InvalidContainer", ErrorCategory.InvalidArgument, sourcePath));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125424,125437);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,125059,125452);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125468,125893) || true) && (f_1209_125472_125504(this, destinationPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,125468,125893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125538,125641);

string 
message =
f_1209_125572_125640()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125659,125729);

InvalidOperationException 
ex = f_1209_125690_125728(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125747,125847);

f_1209_125747_125846(this, f_1209_125758_125845(ex, "InvalidContainer", ErrorCategory.InvalidArgument, destinationPath));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125865,125878);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,125468,125893);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,125909,125921);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,124939,125932);

bool
f_1209_125063_125090(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.IsHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125063, 125090);
return return_v;
}


string
f_1209_125141_125204()
{
var return_v = RegistryProviderStrings.SourceContainerInvalidOperationTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 125141, 125204);
return return_v;
}


System.InvalidOperationException
f_1209_125254_125292(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125254, 125292);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_125322_125404(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125322, 125404);
return return_v;
}


int
f_1209_125311_125405(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125311, 125405);
return 0;
}


bool
f_1209_125472_125504(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.IsHiveContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125472, 125504);
return return_v;
}


string
f_1209_125572_125640()
{
var return_v =                 RegistryProviderStrings.DestinationContainerInvalidOperationTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 125572, 125640);
return return_v;
}


System.InvalidOperationException
f_1209_125690_125728(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125690, 125728);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_125758_125845(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125758, 125845);
return return_v;
}


int
f_1209_125747_125846(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 125747, 125846);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,124939,125932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,124939,125932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IRegistryWrapper GetHiveRoot(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,126289,127593);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126363,126491) || true) && (f_1209_126367_126393(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,126363,126491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126427,126476);

throw f_1209_126433_126475("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,126363,126491);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126507,127554) || true) && (f_1209_126511_126533(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,126507,127554);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126576,126581);
                for (int 
k = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126567,127109) || true) && (k < f_1209_126587_126612(s_wellKnownHivesTx))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126614,126617)
,k++,DynAbs.Tracing.TraceSender.TraceExitCondition(1209,126567,127109))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,126567,127109);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126659,127090) || true) && (f_1209_126663_126734(path, s_hiveNames[k], StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1209, 126663, 126839)||f_1209_126763_126839(path, s_hiveShortNames[k], StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,126659,127090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126889,127067);
using(f_1209_126896_126916())                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,126974,127040);

return f_1209_126981_127039(s_wellKnownHivesTx[k], this);
DynAbs.Tracing.TraceSender.TraceExitUsing(1209,126889,127067);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,126659,127090);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,543);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,543);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1209,126507,127554);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,126507,127554);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,127184,127189);
                for (int 
k = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,127175,127539) || true) && (k < f_1209_127195_127218(s_wellKnownHives))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,127220,127223)
,k++,DynAbs.Tracing.TraceSender.TraceExitCondition(1209,127175,127539))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,127175,127539);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,127265,127520) || true) && (f_1209_127269_127340(path, s_hiveNames[k], StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1209, 127269, 127445)||f_1209_127369_127445(path, s_hiveShortNames[k], StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,127265,127520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,127472,127520);

return f_1209_127479_127519(s_wellKnownHives[k]);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,127265,127520);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,365);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,365);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1209,126507,127554);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,127570,127582);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,126289,127593);

bool
f_1209_126367_126393(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 126367, 126393);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_126433_126475(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 126433, 126475);
return return_v;
}


bool
f_1209_126511_126533(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.TransactionAvailable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 126511, 126533);
return return_v;
}


int
f_1209_126587_126612(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 126587, 126612);
return return_v;
}


bool
f_1209_126663_126734(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 126663, 126734);
return return_v;
}


bool
f_1209_126763_126839(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 126763, 126839);
return return_v;
}


System.Management.Automation.PSTransactionContext
f_1209_126896_126916()
{
var return_v = CurrentPSTransaction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 126896, 126916);
return return_v;
}


Microsoft.PowerShell.Commands.TransactedRegistryWrapper
f_1209_126981_127039(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
txRegKey,Microsoft.PowerShell.Commands.RegistryProvider
provider)
{
var return_v = new Microsoft.PowerShell.Commands.TransactedRegistryWrapper( txRegKey, (System.Management.Automation.Provider.CmdletProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 126981, 127039);
return return_v;
}


int
f_1209_127195_127218(Microsoft.Win32.RegistryKey[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 127195, 127218);
return return_v;
}


bool
f_1209_127269_127340(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 127269, 127340);
return return_v;
}


bool
f_1209_127369_127445(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 127369, 127445);
return return_v;
}


Microsoft.PowerShell.Commands.RegistryWrapper
f_1209_127479_127519(Microsoft.Win32.RegistryKey
regKey)
{
var return_v = new Microsoft.PowerShell.Commands.RegistryWrapper( regKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 127479, 127519);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,126289,127593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,126289,127593);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CreateIntermediateKeys(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,128074,131985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128147,128167);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128212,128340) || true) && (f_1209_128216_128242(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,128212,128340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128276,128325);

throw f_1209_128282_128324("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,128212,128340);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128527,128554);

path = f_1209_128534_128553(this, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128574,128605);

int 
index = f_1209_128586_128604(path, '\\')
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128623,128831) || true) && (index == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,128623,128831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128738,128763);

path = f_1209_128745_128762(path, 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128785,128812);

index = f_1209_128793_128811(path, '\\');
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,128623,128831);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,128851,129046) || true) && (index == -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,128851,129046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129015,129027);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,128851,129046);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129066,129108);

string 
keyRoot = f_1209_129083_129107(path, 0, index)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129275,129335);

f_1209_129275_129334(index + 1 < f_1209_129310_129321(path), "Bad path");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129353,129402);

string 
remainingPath = f_1209_129376_129401(path, index + 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129422,129470);

IRegistryWrapper 
rootKey = f_1209_129449_129469(this, keyRoot)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129490,129648) || true) && (f_1209_129494_129514(remainingPath)== 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1209, 129494, 129538)||rootKey == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,129490,129648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129580,129629);

throw f_1209_129586_129628("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,129490,129648);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129717,129779);

IRegistryWrapper 
subKey = f_1209_129743_129778(rootKey, remainingPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129799,130122) || true) && (subKey != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,129799,130122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,129859,129874);

f_1209_129859_129873(                    subKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,129799,130122);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,129799,130122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,130054,130103);

throw f_1209_130060_130102("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,129799,130122);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,130142,130156);

result = true;
            }
            catch (ArgumentException argumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,130185,130536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,130373,130489);

f_1209_130373_130488(this, f_1209_130384_130487(argumentException, f_1209_130419_130455(f_1209_130419_130446(argumentException)), ErrorCategory.OpenError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,130507,130521);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,130185,130536);
            }
            catch (System.IO.IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,130550,130889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,130738,130842);

f_1209_130738_130841(this, f_1209_130749_130840(ioException, f_1209_130778_130808(f_1209_130778_130799(ioException)), ErrorCategory.OpenError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,130860,130874);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,130550,130889);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,130903,131279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,131109,131232);

f_1209_131109_131231(this, f_1209_131120_131230(securityException, f_1209_131155_131191(f_1209_131155_131182(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,131250,131264);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,130903,131279);
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,131293,131700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,131510,131653);

f_1209_131510_131652(this, f_1209_131521_131651(unauthorizedAccessException, f_1209_131566_131612(f_1209_131566_131603(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,131671,131685);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,131293,131700);
            }
            catch (NotSupportedException notSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,131714,131944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,131798,131929);

f_1209_131798_131928(this, f_1209_131809_131927(notSupportedException, f_1209_131848_131888(f_1209_131848_131879(notSupportedException)), ErrorCategory.InvalidOperation, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,131714,131944);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,131960,131974);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,128074,131985);

bool
f_1209_128216_128242(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 128216, 128242);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_128282_128324(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 128282, 128324);
return return_v;
}


string
f_1209_128534_128553(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 128534, 128553);
return return_v;
}


int
f_1209_128586_128604(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 128586, 128604);
return return_v;
}


string
f_1209_128745_128762(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 128745, 128762);
return return_v;
}


int
f_1209_128793_128811(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 128793, 128811);
return return_v;
}


string
f_1209_129083_129107(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 129083, 129107);
return return_v;
}


int
f_1209_129310_129321(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 129310, 129321);
return return_v;
}


int
f_1209_129275_129334(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 129275, 129334);
return 0;
}


string
f_1209_129376_129401(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 129376, 129401);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_129449_129469(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetHiveRoot( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 129449, 129469);
return return_v;
}


int
f_1209_129494_129514(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 129494, 129514);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1209_129586_129628(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 129586, 129628);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_129743_129778(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
subkey)
{
var return_v = this_param.CreateSubKey( subkey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 129743, 129778);
return return_v;
}


int
f_1209_129859_129873(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 129859, 129873);
return 0;
}


System.Management.Automation.PSArgumentException
f_1209_130060_130102(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 130060, 130102);
return return_v;
}


System.Type
f_1209_130419_130446(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 130419, 130446);
return return_v;
}


string
f_1209_130419_130455(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 130419, 130455);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_130384_130487(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 130384, 130487);
return return_v;
}


int
f_1209_130373_130488(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 130373, 130488);
return 0;
}


System.Type
f_1209_130778_130799(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 130778, 130799);
return return_v;
}


string
f_1209_130778_130808(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 130778, 130808);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_130749_130840(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 130749, 130840);
return return_v;
}


int
f_1209_130738_130841(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 130738, 130841);
return 0;
}


System.Type
f_1209_131155_131182(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131155, 131182);
return return_v;
}


string
f_1209_131155_131191(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 131155, 131191);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_131120_131230(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131120, 131230);
return return_v;
}


int
f_1209_131109_131231(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131109, 131231);
return 0;
}


System.Type
f_1209_131566_131603(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131566, 131603);
return return_v;
}


string
f_1209_131566_131612(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 131566, 131612);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_131521_131651(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131521, 131651);
return return_v;
}


int
f_1209_131510_131652(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131510, 131652);
return 0;
}


System.Type
f_1209_131848_131879(System.NotSupportedException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131848, 131879);
return return_v;
}


string
f_1209_131848_131888(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 131848, 131888);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_131809_131927(System.NotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131809, 131927);
return return_v;
}


int
f_1209_131798_131928(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 131798, 131928);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,128074,131985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,128074,131985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IRegistryWrapper GetRegkeyForPathWriteIfError(string path, bool writeAccess)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,132679,134863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,132788,132819);

IRegistryWrapper 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,132869,132914);

result = f_1209_132878_132913(this, path, writeAccess);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,132934,133390) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,132934,133390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,133063,133207);

ArgumentException 
exception =
f_1209_133118_133206(f_1209_133166_133205())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,133229,133335);

f_1209_133229_133334(this, f_1209_133240_133333(exception, f_1209_133267_133295(f_1209_133267_133286(exception)), ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,133359,133371);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,132934,133390);
}
            }
            catch (ArgumentException argumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,133419,133658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,133495,133611);

f_1209_133495_133610(this, f_1209_133506_133609(argumentException, f_1209_133541_133577(f_1209_133541_133568(argumentException)), ErrorCategory.OpenError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,133629,133643);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,133419,133658);
            }
            catch (System.IO.IOException ioException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,133672,134011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,133860,133964);

f_1209_133860_133963(this, f_1209_133871_133962(ioException, f_1209_133900_133930(f_1209_133900_133921(ioException)), ErrorCategory.OpenError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,133982,133996);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,133672,134011);
            }
            catch (System.Security.SecurityException securityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,134025,134401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,134231,134354);

f_1209_134231_134353(this, f_1209_134242_134352(securityException, f_1209_134277_134313(f_1209_134277_134304(securityException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,134372,134386);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,134025,134401);
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,134415,134822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,134632,134775);

f_1209_134632_134774(this, f_1209_134643_134773(unauthorizedAccessException, f_1209_134688_134734(f_1209_134688_134725(unauthorizedAccessException)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,134793,134807);

return result;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,134415,134822);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,134838,134852);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,132679,134863);

Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_132878_132913(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPath( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 132878, 132913);
return return_v;
}


string
f_1209_133166_133205()
{
var return_v =                         RegistryProviderStrings.KeyDoesNotExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 133166, 133205);
return return_v;
}


System.ArgumentException
f_1209_133118_133206(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133118, 133206);
return return_v;
}


System.Type
f_1209_133267_133286(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133267, 133286);
return return_v;
}


string
f_1209_133267_133295(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 133267, 133295);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_133240_133333(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133240, 133333);
return return_v;
}


int
f_1209_133229_133334(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133229, 133334);
return 0;
}


System.Type
f_1209_133541_133568(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133541, 133568);
return return_v;
}


string
f_1209_133541_133577(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 133541, 133577);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_133506_133609(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133506, 133609);
return return_v;
}


int
f_1209_133495_133610(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133495, 133610);
return 0;
}


System.Type
f_1209_133900_133921(System.IO.IOException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133900, 133921);
return return_v;
}


string
f_1209_133900_133930(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 133900, 133930);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_133871_133962(System.IO.IOException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133871, 133962);
return return_v;
}


int
f_1209_133860_133963(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 133860, 133963);
return 0;
}


System.Type
f_1209_134277_134304(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 134277, 134304);
return return_v;
}


string
f_1209_134277_134313(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 134277, 134313);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_134242_134352(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 134242, 134352);
return return_v;
}


int
f_1209_134231_134353(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 134231, 134353);
return 0;
}


System.Type
f_1209_134688_134725(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 134688, 134725);
return return_v;
}


string
f_1209_134688_134734(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 134688, 134734);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_134643_134773(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 134643, 134773);
return return_v;
}


int
f_1209_134632_134774(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 134632, 134774);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,132679,134863);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,132679,134863);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IRegistryWrapper GetRegkeyForPath(string path, bool writeAccess)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,135453,139841);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,135550,135864) || true) && (f_1209_135554_135580(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,135550,135864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,135679,135815);

ArgumentException 
exception =
f_1209_135730_135814(f_1209_135774_135813())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,135833,135849);

throw exception;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,135550,135864);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,135936,136009) || true) && (f_1209_135940_135948())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,135936,136009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,135982,135994);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,135936,136009);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136025,136078);

f_1209_136025_136077(
            s_tracer, "writeAccess = {0}", writeAccess);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136094,136125);

IRegistryWrapper 
result = null
;
{try {
do // false loop

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,136141,139800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136190,136221);

int 
index = f_1209_136202_136220(path, '\\')
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136241,136451) || true) && (index == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,136241,136451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136358,136383);

path = f_1209_136365_136382(path, 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136405,136432);

index = f_1209_136413_136431(path, '\\');
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,136241,136451);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136471,136602) || true) && (index == -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,136471,136602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136528,136555);

result = f_1209_136537_136554(this, path);
DynAbs.Tracing.TraceSender.TraceBreak(1209,136577,136583);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,136471,136602);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136622,136664);

string 
keyRoot = f_1209_136639_136663(path, 0, index)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136682,136731);

string 
remainingPath = f_1209_136705_136730(path, index + 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136751,136802);

IRegistryWrapper 
resultRoot = f_1209_136781_136801(this, keyRoot)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136822,136982) || true) && (f_1209_136826_136846(remainingPath)== 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1209, 136826, 136873)||resultRoot == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,136822,136982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136915,136935);

result = resultRoot;
DynAbs.Tracing.TraceSender.TraceBreak(1209,136957,136963);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,136822,136982);
}

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137046,137105);

result = f_1209_137055_137104(resultRoot, remainingPath, writeAccess);
                }
                catch (NotSupportedException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,137142,137324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137214,137305);

f_1209_137214_137304(this, f_1209_137225_137303(e, f_1209_137244_137264(f_1209_137244_137255(e)), ErrorCategory.InvalidOperation, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,137142,137324);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137438,139770) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,137438,139770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137498,137539);

IRegistryWrapper 
currentKey = resultRoot
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137561,137593);

IRegistryWrapper 
tempKey = null
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137678,139709) || true) && (!f_1209_137686_137721(remainingPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,137678,139709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137771,137796);

bool 
foundSubkey = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137824,139545);
foreach(string subKey in f_1209_137850_137877_I(f_1209_137850_137877(currentKey)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,137824,139545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,137935,137968);

string 
normalizedSubkey = subKey
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,138088,138917) || true) && (!f_1209_138093_138157(remainingPath, subKey, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1209, 138092, 138301)&&                                !f_1209_138195_138301(remainingPath, subKey + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(),1209,138229,138264), StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,138088,138917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,138454,138495);

normalizedSubkey = f_1209_138473_138494(this, subKey);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,138531,138886) || true) && (!f_1209_138536_138610(remainingPath, normalizedSubkey, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1209, 138535, 138768)&&                                    !f_1209_138652_138768(remainingPath, normalizedSubkey + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(),1209,138696,138731), StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,138531,138886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,138842,138851);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,138531,138886);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,138088,138917);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,138949,139002);

tempKey = f_1209_138959_139001(currentKey, subKey, writeAccess);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139032,139051);

f_1209_139032_139050(                            currentKey);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139081,139102);

currentKey = tempKey;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139134,139153);

foundSubkey = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139185,139480);

remainingPath = (DynAbs.Tracing.TraceSender.Conditional_F1(1209, 139201, 139275)||((f_1209_139201_139275(remainingPath, normalizedSubkey, StringComparison.OrdinalIgnoreCase)&&DynAbs.Tracing.TraceSender.Conditional_F2(1209, 139327, 139339))||DynAbs.Tracing.TraceSender.Conditional_F3(1209, 139391, 139479)))?string.Empty
:f_1209_139391_139479(remainingPath, f_1209_139415_139478((normalizedSubkey + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(),1209,139435,139470))));
DynAbs.Tracing.TraceSender.TraceBreak(1209,139512,139518);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,137824,139545);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,1722);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,1722);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139573,139686) || true) && (!foundSubkey)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,139573,139686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139647,139659);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,139573,139686);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,137678,139709);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,137678,139709);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,137678,139709);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139733,139751);

return currentKey;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,137438,139770);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,136141,139800);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,136141,139800) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,136141,139800);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,136141,139800);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,139816,139830);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,135453,139841);

bool
f_1209_135554_135580(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 135554, 135580);
return return_v;
}


string
f_1209_135774_135813()
{
var return_v =                     RegistryProviderStrings.KeyDoesNotExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 135774, 135813);
return return_v;
}


System.ArgumentException
f_1209_135730_135814(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 135730, 135814);
return return_v;
}


bool
f_1209_135940_135948()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 135940, 135948);
return return_v;
}


int
f_1209_136025_136077(System.Management.Automation.PSTraceSource
this_param,string
format,bool
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136025, 136077);
return 0;
}


int
f_1209_136202_136220(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136202, 136220);
return return_v;
}


string
f_1209_136365_136382(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136365, 136382);
return return_v;
}


int
f_1209_136413_136431(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136413, 136431);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_136537_136554(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetHiveRoot( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136537, 136554);
return return_v;
}


string
f_1209_136639_136663(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136639, 136663);
return return_v;
}


string
f_1209_136705_136730(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136705, 136730);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_136781_136801(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.GetHiveRoot( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 136781, 136801);
return return_v;
}


int
f_1209_136826_136846(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 136826, 136846);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_137055_137104(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,bool
writable)
{
var return_v = this_param.OpenSubKey( name, writable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 137055, 137104);
return return_v;
}


System.Type
f_1209_137244_137255(System.NotSupportedException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 137244, 137255);
return return_v;
}


string
f_1209_137244_137264(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 137244, 137264);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_137225_137303(System.NotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 137225, 137303);
return return_v;
}


int
f_1209_137214_137304(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 137214, 137304);
return 0;
}


bool
f_1209_137686_137721(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 137686, 137721);
return return_v;
}


string[]
f_1209_137850_137877(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetSubKeyNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 137850, 137877);
return return_v;
}


bool
f_1209_138093_138157(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 138093, 138157);
return return_v;
}


bool
f_1209_138195_138301(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 138195, 138301);
return return_v;
}


string
f_1209_138473_138494(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 138473, 138494);
return return_v;
}


bool
f_1209_138536_138610(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 138536, 138610);
return return_v;
}


bool
f_1209_138652_138768(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 138652, 138768);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1209_138959_139001(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,bool
writable)
{
var return_v = this_param.OpenSubKey( name, writable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 138959, 139001);
return return_v;
}


int
f_1209_139032_139050(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 139032, 139050);
return 0;
}


bool
f_1209_139201_139275(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 139201, 139275);
return return_v;
}


int
f_1209_139415_139478(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 139415, 139478);
return return_v;
}


string
f_1209_139391_139479(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 139391, 139479);
return return_v;
}


string[]
f_1209_137850_137877_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 137850, 137877);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,135453,139841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,135453,139841);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static readonly string[] s_hiveNames ;

private static readonly string[] s_hiveShortNames ;

private static readonly RegistryKey[] s_wellKnownHives ;

private static readonly TransactedRegistryKey[] s_wellKnownHivesTx ;

private void SetRegistryValue(IRegistryWrapper key, string propertyName, object value, RegistryValueKind kind, string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,141820,142040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,141968,142029);

f_1209_141968_142028(this, key, propertyName, value, kind, path, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,141820,142040);

int
f_1209_141968_142028(Microsoft.PowerShell.Commands.RegistryProvider
this_param,Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
propertyName,object
value,Microsoft.Win32.RegistryValueKind
kind,string
path,bool
writeResult)
{
this_param.SetRegistryValue( key, propertyName, value, kind, path, writeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 141968, 142028);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,141820,142040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,141820,142040);
}
		}

private void SetRegistryValue(
            IRegistryWrapper key,
            string propertyName,
            object value,
            RegistryValueKind kind,
            string path,
            bool writeResult)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,142825,145458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143070,143176);

f_1209_143070_143175(key != null, "Caller should have verified key");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143192,143249);

string 
propertyNameToSet = f_1209_143219_143248(this, propertyName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143265,143324);

RegistryValueKind 
existingKind = RegistryValueKind.Unknown
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143454,143603) || true) && (kind == RegistryValueKind.Unknown)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,143454,143603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143525,143588);

existingKind = f_1209_143540_143587(key, propertyNameToSet);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,143454,143603);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143734,144260) || true) && (existingKind != RegistryValueKind.Unknown)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,143734,144260);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143857,143905);

value = f_1209_143865_143904(value, existingKind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,143927,143947);

kind = existingKind;
                }
                catch (InvalidCastException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,143984,144245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,144185,144226);

existingKind = RegistryValueKind.Unknown;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,143984,144245);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,143734,144260);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,144328,145135) || true) && (existingKind == RegistryValueKind.Unknown)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,144328,145135);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,144566,145060) || true) && (kind == RegistryValueKind.Unknown)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,144566,145060);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,144697,145041) || true) && (value != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,144697,145041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,144764,144801);

kind = f_1209_144771_144800(value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,144697,145041);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,144697,145041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,144986,145018);

kind = RegistryValueKind.String;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,144697,145041);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,144566,145060);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,145080,145120);

value = f_1209_145088_145119(value, kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,144328,145135);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,145151,145196);

f_1209_145151_145195(
            key, propertyNameToSet, value, kind);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,145212,145447) || true) && (writeResult)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,145212,145447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,145305,145355);

object 
newValue = f_1209_145323_145354(key, propertyNameToSet)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,145375,145432);

f_1209_145375_145431(this, newValue, propertyName, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,145212,145447);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,142825,145458);

int
f_1209_143070_143175(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 143070, 143175);
return 0;
}


string
f_1209_143219_143248(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
userEnteredPropertyName)
{
var return_v = this_param.GetPropertyName( userEnteredPropertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 143219, 143248);
return return_v;
}


Microsoft.Win32.RegistryValueKind
f_1209_143540_143587(Microsoft.PowerShell.Commands.IRegistryWrapper
key,string
valueName)
{
var return_v = GetValueKindForProperty( key, valueName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 143540, 143587);
return return_v;
}


object
f_1209_143865_143904(object
value,Microsoft.Win32.RegistryValueKind
kind)
{
var return_v = ConvertValueToKind( value, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 143865, 143904);
return return_v;
}


Microsoft.Win32.RegistryValueKind
f_1209_144771_144800(object
value)
{
var return_v = GetValueKindFromObject( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 144771, 144800);
return return_v;
}


object
f_1209_145088_145119(object
value,Microsoft.Win32.RegistryValueKind
kind)
{
var return_v = ConvertValueToKind( value, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 145088, 145119);
return return_v;
}


int
f_1209_145151_145195(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
value,Microsoft.Win32.RegistryValueKind
valueKind)
{
this_param.SetValue( name, value, valueKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 145151, 145195);
return 0;
}


object
f_1209_145323_145354(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 145323, 145354);
return return_v;
}


int
f_1209_145375_145431(Microsoft.PowerShell.Commands.RegistryProvider
this_param,object
value,string
propertyName,string
path)
{
this_param.WriteWrappedPropertyObject( value, propertyName, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 145375, 145431);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,142825,145458);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,142825,145458);
}
		}

private void WriteWrappedPropertyObject(object value, string propertyName, string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,145891,146385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,146003,146036);

PSObject 
result = f_1209_146021_146035()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,146052,146092);

string 
propertyNameToAdd = propertyName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,146106,146240) || true) && (f_1209_146110_146144(propertyName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,146106,146240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,146178,146225);

propertyNameToAdd = f_1209_146198_146224(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,146106,146240);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,146256,146324);

f_1209_146256_146323(f_1209_146256_146273(result), f_1209_146278_146322(propertyNameToAdd, value));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,146340,146374);

f_1209_146340_146373(this, result, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,145891,146385);

System.Management.Automation.PSObject
f_1209_146021_146035()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 146021, 146035);
return return_v;
}


bool
f_1209_146110_146144(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 146110, 146144);
return return_v;
}


string
f_1209_146198_146224(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.GetLocalizedDefaultToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 146198, 146224);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1209_146256_146273(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 146256, 146273);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1209_146278_146322(string
name,object
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 146278, 146322);
return return_v;
}


int
f_1209_146256_146323(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 146256, 146323);
return 0;
}


int
f_1209_146340_146373(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.PSObject
propertyValue,string
path)
{
this_param.WritePropertyObject( (object)propertyValue, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 146340, 146373);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,145891,146385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,145891,146385);
}
		}

private static object ConvertValueToKind(object value, RegistryValueKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1209,146886,150231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,146989,150191);

switch (kind)
            {

case RegistryValueKind.Binary:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,146989,150191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,147087,147356);

value = (DynAbs.Tracing.TraceSender.Conditional_F1(1209, 147095, 147110)||(((value != null)
&&DynAbs.Tracing.TraceSender.Conditional_F2(1209, 147138, 147313))||DynAbs.Tracing.TraceSender.Conditional_F3(1209, 147341, 147355)))?(byte[])f_1209_147146_147313(value, typeof(byte[]), f_1209_147286_147312()):new byte[] { };
DynAbs.Tracing.TraceSender.TraceBreak(1209,147378,147384);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,146989,150191);

case RegistryValueKind.DWord:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,146989,150191);
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,147482,148149) || true) && (value != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,147482,148149);
                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,147625,147715);

value = (int)f_1209_147638_147714(value, typeof(int), f_1209_147687_147713());
                            }
                            catch (PSInvalidCastException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,147776,147998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,147871,147967);

value = (UInt32)f_1209_147887_147966(value, typeof(UInt32), f_1209_147939_147965());
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,147776,147998);
                            }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,147482,148149);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,147482,148149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,148112,148122);

value = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,147482,148149);
}
                    }DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,148172,148173);
; DynAbs.Tracing.TraceSender.TraceBreak(1209,148174,148180);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,146989,150191);

case RegistryValueKind.ExpandString:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,146989,150191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,148258,148525);

value = (DynAbs.Tracing.TraceSender.Conditional_F1(1209, 148266, 148281)||(((value != null)
&&DynAbs.Tracing.TraceSender.Conditional_F2(1209, 148309, 148484))||DynAbs.Tracing.TraceSender.Conditional_F3(1209, 148512, 148524)))?(string)f_1209_148317_148484(value, typeof(string), f_1209_148457_148483()):string.Empty;
DynAbs.Tracing.TraceSender.TraceBreak(1209,148547,148553);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,146989,150191);

case RegistryValueKind.MultiString:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,146989,150191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,148630,148905);

value = (DynAbs.Tracing.TraceSender.Conditional_F1(1209, 148638, 148653)||(((value != null)
&&DynAbs.Tracing.TraceSender.Conditional_F2(1209, 148681, 148860))||DynAbs.Tracing.TraceSender.Conditional_F3(1209, 148888, 148904)))?(string[])f_1209_148691_148860(value, typeof(string[]), f_1209_148833_148859()):new string[] { };
DynAbs.Tracing.TraceSender.TraceBreak(1209,148927,148933);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,146989,150191);

case RegistryValueKind.QWord:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,146989,150191);
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,149031,149700) || true) && (value != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,149031,149700);
                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,149174,149266);

value = (long)f_1209_149188_149265(value, typeof(long), f_1209_149238_149264());
                            }
                            catch (PSInvalidCastException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,149327,149549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,149422,149518);

value = (UInt64)f_1209_149438_149517(value, typeof(UInt64), f_1209_149490_149516());
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,149327,149549);
                            }
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,149031,149700);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,149031,149700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,149663,149673);

value = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,149031,149700);
}
                    }DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,149723,149724);
; DynAbs.Tracing.TraceSender.TraceBreak(1209,149725,149731);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,146989,150191);

case RegistryValueKind.String:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,146989,150191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,149803,150070);

value = (DynAbs.Tracing.TraceSender.Conditional_F1(1209, 149811, 149826)||(((value != null)
&&DynAbs.Tracing.TraceSender.Conditional_F2(1209, 149854, 150029))||DynAbs.Tracing.TraceSender.Conditional_F3(1209, 150057, 150069)))?(string)f_1209_149862_150029(value, typeof(string), f_1209_150002_150028()):string.Empty;
DynAbs.Tracing.TraceSender.TraceBreak(1209,150092,150098);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,146989,150191);

                    // If kind is Unknown then just leave the value as-is.
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150207,150220);

return value;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1209,146886,150231);

System.Globalization.CultureInfo
f_1209_147286_147312()
{
var return_v =                             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 147286, 147312);
return return_v;
}


object
f_1209_147146_147313(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 147146, 147313);
return return_v;
}


System.Globalization.CultureInfo
f_1209_147687_147713()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 147687, 147713);
return return_v;
}


object
f_1209_147638_147714(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 147638, 147714);
return return_v;
}


System.Globalization.CultureInfo
f_1209_147939_147965()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 147939, 147965);
return return_v;
}


object
f_1209_147887_147966(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 147887, 147966);
return return_v;
}


System.Globalization.CultureInfo
f_1209_148457_148483()
{
var return_v =                             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 148457, 148483);
return return_v;
}


object
f_1209_148317_148484(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 148317, 148484);
return return_v;
}


System.Globalization.CultureInfo
f_1209_148833_148859()
{
var return_v =                             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 148833, 148859);
return return_v;
}


object
f_1209_148691_148860(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 148691, 148860);
return return_v;
}


System.Globalization.CultureInfo
f_1209_149238_149264()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 149238, 149264);
return return_v;
}


object
f_1209_149188_149265(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 149188, 149265);
return return_v;
}


System.Globalization.CultureInfo
f_1209_149490_149516()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 149490, 149516);
return return_v;
}


object
f_1209_149438_149517(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 149438, 149517);
return return_v;
}


System.Globalization.CultureInfo
f_1209_150002_150028()
{
var return_v =                             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 150002, 150028);
return return_v;
}


object
f_1209_149862_150029(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 149862, 150029);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,146886,150231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,146886,150231);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static RegistryValueKind GetValueKindFromObject(object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1209,150516,151540);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150610,150730) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,150610,150730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150661,150715);

throw f_1209_150667_150714("value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,150610,150730);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150746,150799);

RegistryValueKind 
result = RegistryValueKind.Unknown
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150815,150848);

Type 
valueType = f_1209_150832_150847(value)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150862,151105) || true) && (valueType == typeof(byte[]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,150862,151105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150927,150961);

result = RegistryValueKind.Binary;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,150862,151105);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,150862,151105);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,150995,151105) || true) && (valueType == typeof(int))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,150995,151105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151057,151090);

result = RegistryValueKind.DWord;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,150995,151105);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,150862,151105);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151121,151235) || true) && (valueType == typeof(string))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,151121,151235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151186,151220);

result = RegistryValueKind.String;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,151121,151235);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151251,151372) || true) && (valueType == typeof(string[]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,151251,151372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151318,151357);

result = RegistryValueKind.MultiString;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,151251,151372);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151388,151499) || true) && (valueType == typeof(long))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,151388,151499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151451,151484);

result = RegistryValueKind.QWord;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,151388,151499);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,151515,151529);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1209,150516,151540);

System.Management.Automation.PSArgumentNullException
f_1209_150667_150714(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 150667, 150714);
return return_v;
}


System.Type
f_1209_150832_150847(object
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 150832, 150847);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,150516,151540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,150516,151540);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static RegistryValueKind GetValueKindForProperty(IRegistryWrapper key, string valueName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1209,151960,152628);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,152117,152152);

return f_1209_152124_152151(key, valueName);
            }
            catch (System.ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,152181,152324);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,152181,152324);
                // RegistryKey that contains the specified value does not exist
            }
            catch (System.IO.IOException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,152338,152397);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,152338,152397);
            }
            catch (System.Security.SecurityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,152411,152482);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,152411,152482);
            }
            catch (System.UnauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,152496,152568);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,152496,152568);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,152584,152617);

return RegistryValueKind.Unknown;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1209,151960,152628);

Microsoft.Win32.RegistryValueKind
f_1209_152124_152151(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name)
{
var return_v = this_param.GetValueKind( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 152124, 152151);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,151960,152628);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,151960,152628);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static object ReadExistingKeyValue(IRegistryWrapper key, string valueName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1209,153074,153810);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,153425,153512);

return f_1209_153432_153511(key, valueName, null, RegistryValueOptions.DoNotExpandEnvironmentNames);
            }
            catch (System.IO.IOException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,153541,153600);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,153541,153600);
            }
            catch (System.Security.SecurityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,153614,153685);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,153614,153685);
            }
            catch (System.UnauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,153699,153771);
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,153699,153771);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,153787,153799);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1209,153074,153810);

object
f_1209_153432_153511(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,string
name,object
defaultValue,Microsoft.Win32.RegistryValueOptions
options)
{
var return_v = this_param.GetValue( name, defaultValue, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 153432, 153511);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,153074,153810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,153074,153810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteRegistryItemObject(
            IRegistryWrapper key,
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,154270,155557);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,154393,154704) || true) && (key == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,154393,154704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,154442,154592);

f_1209_154442_154591(key != null, "The RegistryProvider should never attempt to write out a null value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,154682,154689);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,154393,154704);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,154779,154811);

path = f_1209_154786_154810(path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,154871,154932);

PSObject 
outputObject = f_1209_154895_154931(f_1209_154915_154930(key))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155004,155046);

string[] 
valueNames = f_1209_155026_155045(key)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155071,155080);

            for (int 
index = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155062,155418) || true) && (index < f_1209_155090_155107(valueNames))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155109,155116)
,++index,DynAbs.Tracing.TraceSender.TraceExitCondition(1209,155062,155418))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,155062,155418);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155150,155403) || true) && (f_1209_155154_155193(valueNames[index]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,155150,155403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155309,155356);

valueNames[index] = f_1209_155329_155355(this);
DynAbs.Tracing.TraceSender.TraceBreak(1209,155378,155384);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,155150,155403);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1209,1,357);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1209,1,357);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155434,155488);

f_1209_155434_155487(
            outputObject, "Property", valueNames);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,155504,155546);

f_1209_155504_155545(this, outputObject, path, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,154270,155557);

int
f_1209_154442_154591(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 154442, 154591);
return 0;
}


string
f_1209_154786_154810(string
path)
{
var return_v = EscapeSpecialChars( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 154786, 154810);
return return_v;
}


object
f_1209_154915_154930(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.RegistryKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 154915, 154930);
return return_v;
}


System.Management.Automation.PSObject
f_1209_154895_154931(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 154895, 154931);
return return_v;
}


string[]
f_1209_155026_155045(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param)
{
var return_v = this_param.GetValueNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 155026, 155045);
return return_v;
}


int
f_1209_155090_155107(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 155090, 155107);
return return_v;
}


bool
f_1209_155154_155193(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 155154, 155193);
return return_v;
}


string
f_1209_155329_155355(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.GetLocalizedDefaultToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 155329, 155355);
return return_v;
}


int
f_1209_155434_155487(System.Management.Automation.PSObject
this_param,string
memberName,string[]
value)
{
this_param.AddOrSetProperty( memberName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 155434, 155487);
return 0;
}


int
f_1209_155504_155545(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.PSObject
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( (object)item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 155504, 155545);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,154270,155557);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,154270,155557);
}
		}

private bool ParseKind(string type, out RegistryValueKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,156114,157706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156202,156235);

kind = RegistryValueKind.Unknown;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156251,156342) || true) && (f_1209_156255_156281(type))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,156251,156342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156315,156327);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,156251,156342);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156358,156378);

bool 
success = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156392,156424);

Exception 
innerException = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156539,156615);

kind = (RegistryValueKind)f_1209_156565_156614(typeof(RegistryValueKind), type, true);
            }
            catch (InvalidCastException invalidCast)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,156644,156761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156717,156746);

innerException = invalidCast;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,156644,156761);
            }
            catch (ArgumentException argException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1209,156775,156891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156846,156876);

innerException = argException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1209,156775,156891);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156907,157664) || true) && (innerException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,156907,157664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,156967,156983);

success = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,157003,157098);

string 
formatString =
f_1209_157046_157097()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,157116,157456);

Exception 
e =
f_1209_157151_157455(f_1209_157199_157413(f_1209_157243_157269(), formatString, type, f_1209_157378_157412(typeof(RegistryValueKind))), innerException)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,157474,157649);

f_1209_157474_157648(this, f_1209_157485_157647(e, f_1209_157547_157567(f_1209_157547_157558(                    e)), ErrorCategory.InvalidArgument, type));
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,156907,157664);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,157680,157695);

return success;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,156114,157706);

bool
f_1209_156255_156281(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 156255, 156281);
return return_v;
}


object
f_1209_156565_156614(System.Type
enumType,string
value,bool
ignoreCase)
{
var return_v = Enum.Parse( enumType, value, ignoreCase);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 156565, 156614);
return return_v;
}


string
f_1209_157046_157097()
{
var return_v =                     RegistryProviderStrings.TypeParameterBindingFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 157046, 157097);
return return_v;
}


System.Globalization.CultureInfo
f_1209_157243_157269()
{
var return_v =                             CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 157243, 157269);
return return_v;
}


string
f_1209_157378_157412(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 157378, 157412);
return return_v;
}


string
f_1209_157199_157413(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 157199, 157413);
return return_v;
}


System.ArgumentException
f_1209_157151_157455(string
message,System.Exception
innerException)
{
var return_v = new System.ArgumentException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 157151, 157455);
return return_v;
}


System.Type
f_1209_157547_157558(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 157547, 157558);
return return_v;
}


string
f_1209_157547_157567(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 157547, 157567);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1209_157485_157647(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 157485, 157647);
return return_v;
}


int
f_1209_157474_157648(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 157474, 157648);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,156114,157706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,156114,157706);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetLocalizedDefaultToken()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,158005,158229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,158142,158180);

string 
defaultValueName = "(default)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,158194,158218);

return defaultValueName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,158005,158229);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,158005,158229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,158005,158229);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetPropertyName(string userEnteredPropertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1209,158749,159367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,158836,158876);

string 
result = userEnteredPropertyName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,158892,159326) || true) && (!f_1209_158897_158942(userEnteredPropertyName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,158892,159326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,158976,159029);

var 
stringComparer = f_1209_158997_159028(f_1209_158997_159016(f_1209_158997_159001()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,159049,159311) || true) && (f_1209_159053_159231(stringComparer, userEnteredPropertyName, f_1209_159152_159178(this), CompareOptions.IgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1209,159049,159311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,159278,159292);

result = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,159049,159311);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1209,158892,159326);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,159342,159356);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1209,158749,159367);

bool
f_1209_158897_158942(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 158897, 158942);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1209_158997_159001()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 158997, 159001);
return return_v;
}


System.Globalization.CultureInfo
f_1209_158997_159016(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 158997, 159016);
return return_v;
}


System.Globalization.CompareInfo
f_1209_158997_159028(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.CompareInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 158997, 159028);
return return_v;
}


string
f_1209_159152_159178(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.GetLocalizedDefaultToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 159152, 159178);
return return_v;
}


int
f_1209_159053_159231(System.Globalization.CompareInfo
this_param,string
string1,string
string2,System.Globalization.CompareOptions
options)
{
var return_v = this_param.Compare( string1, string2, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 159053, 159231);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1209,158749,159367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,158749,159367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public RegistryProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1209,2044,159410);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1209,2044,159410);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,2044,159410);
}


static RegistryProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1209,2044,159410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,3643,3789);
s_tracer = f_1209_3667_3789("RegistryProvider", "The namespace navigation provider for the Windows Registry");DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,3942,3967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,31214,31251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,140052,140294);
s_hiveNames = new string[] {
            "HKEY_LOCAL_MACHINE",
            "HKEY_CURRENT_USER",
            "HKEY_CLASSES_ROOT",
            "HKEY_CURRENT_CONFIG",
            "HKEY_USERS",
            "HKEY_PERFORMANCE_DATA"
        };DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,140340,140508);
s_hiveShortNames = new string[] {
            "HKLM",
            "HKCU",
            "HKCR",
            "HKCC",
            "HKU",
            "HKPD"
        };DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,140559,140818);
s_wellKnownHives = new RegistryKey[] {
            Registry.LocalMachine,
            Registry.CurrentUser,
            Registry.ClassesRoot,
            Registry.CurrentConfig,
            Registry.Users,
            Registry.PerformanceData
        };DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,140879,141161);
s_wellKnownHivesTx = new TransactedRegistryKey[] {
            TransactedRegistry.LocalMachine,
            TransactedRegistry.CurrentUser,
            TransactedRegistry.ClassesRoot,
            TransactedRegistry.CurrentConfig,
            TransactedRegistry.Users
        };DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1209,2044,159410);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,2044,159410);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1209,2044,159410);

static System.Management.Automation.PSTraceSource
f_1209_3667_3789(string
name,string
description)
{
var return_v = Dbg.PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1209, 3667, 3789);
return return_v;
}


char
f_1209_4188_4201()
{
var return_v = ItemSeparator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1209, 4188, 4201);
return return_v;
}

}
public class RegistryProviderSetItemDynamicParameter
{
[Parameter(ValueFromPipelineByPropertyName = true)]
        public RegistryValueKind Type {get; set; }

public RegistryProviderSetItemDynamicParameter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1209,159520,160066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1209,159926,160059);
this.Type = RegistryValueKind.Unknown;DynAbs.Tracing.TraceSender.TraceExitConstructor(1209,159520,160066);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,159520,160066);
}


static RegistryProviderSetItemDynamicParameter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1209,159520,160066);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1209,159520,160066);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1209,159520,160066);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1209,159520,160066);
}
}
