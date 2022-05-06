// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
internal sealed class SessionStateScope
{
internal SessionStateScope(SessionStateScope parentScope)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1354,814,1261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,1491,1538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,1700,1748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,2397,2409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,2631,2679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,2902,2949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,3710,3751);
this._dottedScopes = f_1354_3726_3751();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61161,61181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61638,61704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,64586,64593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,65213,65231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,65283,65293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,68083,68089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,69175,69185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,70210,70228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,70750,70835);
this._cmdlets = f_1354_70761_70835(f_1354_70802_70834());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,71129,71222);
this._allScopeCmdlets = f_1354_71148_71222(f_1354_71189_71221());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,72623,72719);
this._commandsToAliasesCache = f_1354_72649_72719(f_1354_72686_72718());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,896,933);

ScopeOrigin = CommandOrigin.Internal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,947,968);

Parent = parentScope;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,984,1250) || true) && (parentScope != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,984,1250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,1110,1149);

_scriptScope = f_1354_1125_1148(parentScope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,984,1250);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,984,1250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,1215,1235);

_scriptScope = this;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,984,1250);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1354,814,1261);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,814,1261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,814,1261);
}
		}

internal SessionStateScope Parent {get; set; }

internal CommandOrigin ScopeOrigin {get; set; }

internal SessionStateScope ScriptScope
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,2142,2170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,2148,2168);

return _scriptScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,2142,2170);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,2079,2359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,2079,2359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,2186,2348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,2222,2294);

f_1354_2222_2293(value != null, "Caller to verify scope is not null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,2312,2333);

_scriptScope = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,2186,2348);

int
f_1354_2222_2293(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 2222, 2293);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,2079,2359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,2079,2359);
}
		}}

private SessionStateScope _scriptScope;

internal Version StrictModeVersion {get; set; }

internal MutableTuple LocalsTuple {get; set; }

internal Stack<MutableTuple> DottedScopes {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,3630,3659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,3636,3657);

return _dottedScopes;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,3630,3659);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,3586,3661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,3586,3661);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private readonly Stack<MutableTuple> _dottedScopes ;

internal void NewDrive(PSDriveInfo newDrive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,4455,5709);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,4524,4650) || true) && (newDrive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,4524,4650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,4578,4635);

throw f_1354_4584_4634("newDrive");
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,4524,4650);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,4783,4812);

var 
driveInfos = f_1354_4800_4811(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,4826,5278) || true) && (f_1354_4830_4867(driveInfos, f_1354_4853_4866(newDrive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,4826,5278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,4901,5235);

SessionStateException 
e =
f_1354_4948_5234(f_1354_5000_5013(newDrive), SessionStateCategory.Drive, "DriveAlreadyExists", f_1354_5140_5178(), ErrorCategory.ResourceExists)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,5255,5263);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,4826,5278);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,5294,5698) || true) && (f_1354_5298_5321_M(!newDrive.IsAutoMounted))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,5294,5698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,5355,5395);

f_1354_5355_5394(                driveInfos, f_1354_5370_5383(newDrive), newDrive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,5294,5698);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,5294,5698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,5461,5508);

var 
automountedDrives = f_1354_5485_5507(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,5526,5683) || true) && (!f_1354_5531_5575(automountedDrives, f_1354_5561_5574(newDrive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,5526,5683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,5617,5664);

f_1354_5617_5663(                    automountedDrives, f_1354_5639_5652(newDrive), newDrive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,5526,5683);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,5294,5698);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,4455,5709);

System.Management.Automation.PSArgumentNullException
f_1354_4584_4634(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 4584, 4634);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_4800_4811(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 4800, 4811);
return return_v;
}


string
f_1354_4853_4866(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 4853, 4866);
return return_v;
}


bool
f_1354_4830_4867(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 4830, 4867);
return return_v;
}


string
f_1354_5000_5013(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 5000, 5013);
return return_v;
}


string
f_1354_5140_5178()
{
var return_v =                         SessionStateStrings.DriveAlreadyExists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 5140, 5178);
return return_v;
}


System.Management.Automation.SessionStateException
f_1354_4948_5234(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr,System.Management.Automation.ErrorCategory
errorCategory,params object[]
messageArgs)
{
var return_v = new System.Management.Automation.SessionStateException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 4948, 5234);
return return_v;
}


bool
f_1354_5298_5321_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 5298, 5321);
return return_v;
}


string
f_1354_5370_5383(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 5370, 5383);
return return_v;
}


int
f_1354_5355_5394(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key,System.Management.Automation.PSDriveInfo
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 5355, 5394);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_5485_5507(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAutomountedDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 5485, 5507);
return return_v;
}


string
f_1354_5561_5574(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 5561, 5574);
return return_v;
}


bool
f_1354_5531_5575(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 5531, 5575);
return return_v;
}


string
f_1354_5639_5652(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 5639, 5652);
return return_v;
}


int
f_1354_5617_5663(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key,System.Management.Automation.PSDriveInfo
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 5617, 5663);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,4455,5709);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,4455,5709);
}
		}

internal void RemoveDrive(PSDriveInfo drive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,6215,7230);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6284,6404) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,6284,6404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6335,6389);

throw f_1354_6341_6388("drive");
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,6284,6404);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6420,6465) || true) && (_drives == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,6420,6465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6458,6465);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,6420,6465);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6481,6510);

var 
driveInfos = f_1354_6498_6509(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6524,7219) || true) && (!f_1354_6529_6558(driveInfos, f_1354_6547_6557(drive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,6524,7219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6671,6718);

var 
automountedDrives = f_1354_6695_6717(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6736,6765);

PSDriveInfo 
automountedDrive
=default(PSDriveInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6783,7204) || true) && (f_1354_6787_6850(automountedDrives, f_1354_6817_6827(drive), out automountedDrive))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,6783,7204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,6892,6945);

automountedDrive.IsAutoMountedManuallyRemoved = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,7051,7185) || true) && (f_1354_7055_7075(drive))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,7051,7185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,7125,7162);

f_1354_7125_7161(                        automountedDrives, f_1354_7150_7160(drive));
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,7051,7185);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,6783,7204);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,6524,7219);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,6215,7230);

System.Management.Automation.PSArgumentNullException
f_1354_6341_6388(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 6341, 6388);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_6498_6509(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 6498, 6509);
return return_v;
}


string
f_1354_6547_6557(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 6547, 6557);
return return_v;
}


bool
f_1354_6529_6558(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 6529, 6558);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_6695_6717(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAutomountedDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 6695, 6717);
return return_v;
}


string
f_1354_6817_6827(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 6817, 6827);
return return_v;
}


bool
f_1354_6787_6850(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key,out System.Management.Automation.PSDriveInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 6787, 6850);
return return_v;
}


bool
f_1354_7055_7075(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.IsNetworkDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 7055, 7075);
return return_v;
}


string
f_1354_7150_7160(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 7150, 7160);
return return_v;
}


bool
f_1354_7125_7161(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 7125, 7161);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,6215,7230);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,6215,7230);
}
		}

internal void RemoveAllDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,7341,7473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,7397,7417);

f_1354_7397_7416(f_1354_7397_7408(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,7431,7462);

f_1354_7431_7461(f_1354_7431_7453(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,7341,7473);

System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_7397_7408(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 7397, 7408);
return return_v;
}


int
f_1354_7397_7416(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 7397, 7416);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_7431_7453(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAutomountedDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 7431, 7453);
return return_v;
}


int
f_1354_7431_7461(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 7431, 7461);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,7341,7473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,7341,7473);
}
		}

internal PSDriveInfo GetDrive(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,8013,8598);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8080,8198) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,8080,8198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8130,8183);

throw f_1354_8136_8182("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,8080,8198);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8214,8240);

PSDriveInfo 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8256,8285);

var 
driveInfos = f_1354_8273_8284(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8299,8557) || true) && (!f_1354_8304_8344(driveInfos, name, out result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,8299,8557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8489,8542);

f_1354_8489_8541(f_1354_8489_8511(this), name, out result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,8299,8557);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8573,8587);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,8013,8598);

System.Management.Automation.PSArgumentNullException
f_1354_8136_8182(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8136, 8182);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_8273_8284(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8273, 8284);
return return_v;
}


bool
f_1354_8304_8344(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key,out System.Management.Automation.PSDriveInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8304, 8344);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_8489_8511(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAutomountedDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8489, 8511);
return return_v;
}


bool
f_1354_8489_8541(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key,out System.Management.Automation.PSDriveInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8489, 8541);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,8013,8598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,8013,8598);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IEnumerable<PSDriveInfo> Drives
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,8785,9466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8821,8884);

Collection<PSDriveInfo> 
result = f_1354_8854_8883()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8902,9029);
foreach(PSDriveInfo drive in f_1354_8932_8950_I(f_1354_8932_8950(f_1354_8932_8943(this))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,8902,9029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,8992,9010);

f_1354_8992_9009(                    result, drive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,8902,9029);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,128);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,128);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,9167,9417);
foreach(PSDriveInfo drive in f_1354_9197_9226_I(f_1354_9197_9226(f_1354_9197_9219(this))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,9167,9417);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,9268,9398) || true) && (f_1354_9272_9307_M(!drive.IsAutoMountedManuallyRemoved))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,9268,9398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,9357,9375);

f_1354_9357_9374(                        result, drive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,9268,9398);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,9167,9417);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,251);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,251);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,9437,9451);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,8785,9466);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1354_8854_8883()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8854, 8883);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_8932_8943(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8932, 8943);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
f_1354_8932_8950(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 8932, 8950);
return return_v;
}


int
f_1354_8992_9009(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8992, 9009);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
f_1354_8932_8950_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 8932, 8950);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_9197_9219(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAutomountedDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 9197, 9219);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
f_1354_9197_9226(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 9197, 9226);
return return_v;
}


bool
f_1354_9272_9307_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 9272, 9307);
return return_v;
}


int
f_1354_9357_9374(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 9357, 9374);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
f_1354_9197_9226_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 9197, 9226);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,8720,9477);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,8720,9477);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal IDictionary<string, PSVariable> Variables {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,9711,9748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,9717,9746);

return f_1354_9724_9745(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,9711,9748);

System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
f_1354_9724_9745(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetPrivateVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 9724, 9745);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,9658,9750);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,9658,9750);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal PSVariable GetVariable(string name, CommandOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,10225,10435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,10316,10334);

PSVariable 
result
=default(PSVariable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,10348,10396);

f_1354_10348_10395(this, name, origin, false, out result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,10410,10424);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,10225,10435);

bool
f_1354_10348_10395(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.CommandOrigin
origin,bool
fromNewOrSet,out System.Management.Automation.PSVariable
variable)
{
var return_v = this_param.TryGetVariable( name, origin, fromNewOrSet, out variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 10348, 10395);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,10225,10435);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,10225,10435);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSVariable GetVariable(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,10778,10896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,10847,10885);

return f_1354_10854_10884(this, name, f_1354_10872_10883());
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,10778,10896);

System.Management.Automation.CommandOrigin
f_1354_10872_10883()
{
var return_v = ScopeOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 10872, 10883);
return return_v;
}


System.Management.Automation.PSVariable
f_1354_10854_10884(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.CommandOrigin
origin)
{
var return_v = this_param.GetVariable( name, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 10854, 10884);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,10778,10896);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,10778,10896);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool TryGetVariable(string name, CommandOrigin origin, bool fromNewOrSet, out PSVariable variable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,11809,12462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,11941,12011);

f_1354_11941_12010(name != null, "The caller should verify the name");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12027,12221) || true) && (f_1354_12031_12093(this, name, fromNewOrSet, out variable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,12027,12221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12127,12176);

f_1354_12127_12175(origin, variable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12194,12206);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,12027,12221);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12237,12422) || true) && (f_1354_12241_12294(f_1354_12241_12262(this), name, out variable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,12237,12422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12328,12377);

f_1354_12328_12376(origin, variable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12395,12407);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,12237,12422);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12438,12451);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,11809,12462);

int
f_1354_11941_12010(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 11941, 12010);
return 0;
}


bool
f_1354_12031_12093(System.Management.Automation.SessionStateScope
this_param,string
name,bool
fromNewOrSet,out System.Management.Automation.PSVariable
result)
{
var return_v = this_param.TryGetLocalVariableFromTuple( name, fromNewOrSet, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12031, 12093);
return return_v;
}


int
f_1354_12127_12175(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.PSVariable
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12127, 12175);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
f_1354_12241_12262(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetPrivateVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12241, 12262);
return return_v;
}


bool
f_1354_12241_12294(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param,string
key,out System.Management.Automation.PSVariable
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12241, 12294);
return return_v;
}


int
f_1354_12328_12376(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.PSVariable
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12328, 12376);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,11809,12462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,11809,12462);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object GetAutomaticVariableValue(AutomaticVariable variable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,12599,13298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12693,12719);

int 
index = (int)variable
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12733,12952);
foreach(var dottedScope in f_1354_12761_12774_I(_dottedScopes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,12733,12952);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12808,12937) || true) && (f_1354_12812_12841(dottedScope, index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,12808,12937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,12883,12918);

return f_1354_12890_12917(dottedScope, index);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,12808,12937);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,12733,12952);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,220);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,220);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,13103,13243) || true) && (f_1354_13107_13118()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 13107, 13159)&&f_1354_13130_13159(f_1354_13130_13141(), index)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,13103,13243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,13193,13228);

return f_1354_13200_13227(f_1354_13200_13211(), index);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,13103,13243);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,13259,13287);

return f_1354_13266_13286();
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,12599,13298);

bool
f_1354_12812_12841(System.Management.Automation.MutableTuple
this_param,int
index)
{
var return_v = this_param.IsValueSet( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12812, 12841);
return return_v;
}


object
f_1354_12890_12917(System.Management.Automation.MutableTuple
this_param,int
index)
{
var return_v = this_param.GetValue( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12890, 12917);
return return_v;
}


System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
f_1354_12761_12774_I(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 12761, 12774);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_13107_13118()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 13107, 13118);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_13130_13141()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 13130, 13141);
return return_v;
}


bool
f_1354_13130_13159(System.Management.Automation.MutableTuple
this_param,int
index)
{
var return_v = this_param.IsValueSet( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 13130, 13159);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_13200_13211()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 13200, 13211);
return return_v;
}


object
f_1354_13200_13227(System.Management.Automation.MutableTuple
this_param,int
index)
{
var return_v = this_param.GetValue( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 13200, 13227);
return return_v;
}


System.Management.Automation.PSObject
f_1354_13266_13286()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 13266, 13286);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,12599,13298);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,12599,13298);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSVariable SetVariable(string name, object value, bool asValue, bool force, SessionStateInternal sessionState, CommandOrigin origin = CommandOrigin.Internal, bool fastPath = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,14707,19324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,14921,14991);

f_1354_14921_14990(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15007,15027);

PSVariable 
variable
=default(PSVariable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15041,15088);

PSVariable 
variableToSet = value as PSVariable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15277,15720) || true) && (fastPath)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,15277,15720);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15323,15448) || true) && (f_1354_15327_15333()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,15323,15448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15383,15429);

throw f_1354_15389_15428("fastPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,15323,15448);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15468,15614);

variable = new PSVariable(name, f_1354_15500_15519(variableToSet), f_1354_15521_15542(variableToSet), f_1354_15544_15568(variableToSet)) { Description = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1354_15586_15611(variableToSet),1354,15479,15613)};
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15632,15671);

f_1354_15632_15653(this)[name] = variable;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15689,15705);

return variable;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,15277,15720);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15736,15802);

bool 
varExists = f_1354_15753_15801(this, name, origin, true, out variable)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15893,15943) || true) && (_variables == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,15893,15943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15919,15941);

f_1354_15919_15940(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,15893,15943);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,15959,19021) || true) && (!asValue &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 15963, 15996)&&variableToSet != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,15959,19021);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,16030,18716) || true) && (varExists)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,16030,18716);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,16206,16760) || true) && (variable == null ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 16210, 16249)||f_1354_16230_16249(variable))||(DynAbs.Tracing.TraceSender.Expression_False(1354, 16210, 16284)||(!force &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 16254, 16283)&&f_1354_16264_16283(variable)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,16206,16760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,16334,16701);

SessionStateUnauthorizedAccessException 
e =
f_1354_16407_16700(name, SessionStateCategory.Variable, "VariableNotWritable", f_1354_16660_16699())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,16729,16737);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,16206,16760);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,16784,17403) || true) && (variable is LocalVariable
&&(DynAbs.Tracing.TraceSender.Expression_True(1354, 16788, 16919)&&(f_1354_16843_16873(f_1354_16843_16867(variableToSet))||(DynAbs.Tracing.TraceSender.Expression_False(1354, 16843, 16918)||f_1354_16877_16898(variableToSet)!= f_1354_16902_16918(variable)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,16784,17403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,16969,17344);

SessionStateUnauthorizedAccessException 
e =
f_1354_17042_17343(name, SessionStateCategory.Variable, "VariableNotWritableRare", f_1354_17299_17342())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,17372,17380);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,16784,17403);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,17427,18478) || true) && (f_1354_17431_17450(variable)&&(DynAbs.Tracing.TraceSender.Expression_True(1354, 17431, 17459)&&force))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,17427,18478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,17509,17533);

f_1354_17509_17532(                        _variables, name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,17559,17577);

varExists = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,17603,17749);

variable = new PSVariable(name, f_1354_17635_17654(variableToSet), f_1354_17656_17677(variableToSet), f_1354_17679_17703(variableToSet)) { Description = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1354_17721_17746(variableToSet),1354,17614,17748)};
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,17427,18478);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,17427,18478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18026,18054);

f_1354_18026_18053(f_1354_18026_18045(variable));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18082,18119);

variable.Value = f_1354_18099_18118(variableToSet);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18145,18186);

variable.Options = f_1354_18164_18185(variableToSet);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18212,18261);

variable.Description = f_1354_18235_18260(variableToSet);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18289,18455);
foreach(Attribute attr in f_1354_18316_18340_I(f_1354_18316_18340(variableToSet)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,18289,18455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18398,18428);

f_1354_18398_18427(f_1354_18398_18417(variable), attr);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,18289,18455);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,167);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,167);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1354,17427,18478);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,16030,18716);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,16030,18716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18672,18697);

variable = variableToSet;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,16030,18716);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,15959,19021);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,15959,19021);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18750,19021) || true) && (variable != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,18750,19021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18804,18827);

variable.Value = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,18750,19021);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,18750,19021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,18893,19006);

variable = ((DynAbs.Tracing.TraceSender.Conditional_F1(1354, 18905, 18924)||((f_1354_18905_18916()!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(1354, 18927, 18966))||DynAbs.Tracing.TraceSender.Conditional_F3(1354, 18969, 18973)))?f_1354_18927_18966(f_1354_18927_18938(), name, value):null) ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSVariable>(1354, 18904, 19005)??f_1354_18978_19005(name, value));
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,18750,19021);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,15959,19021);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19037,19188) || true) && (f_1354_19041_19088())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,19037,19188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19122,19173);

f_1354_19122_19172(this, variable);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,19037,19188);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19204,19232);

_variables[name] = variable;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19246,19283);

variable.SessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19297,19313);

return variable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,14707,19324);

int
f_1354_14921_14990(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 14921, 14990);
return 0;
}


System.Management.Automation.SessionStateScope
f_1354_15327_15333()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 15327, 15333);
return return_v;
}


System.NotImplementedException
f_1354_15389_15428(string
message)
{
var return_v = new System.NotImplementedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 15389, 15428);
return return_v;
}


object
f_1354_15500_15519(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 15500, 15519);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_15521_15542(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 15521, 15542);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1354_15544_15568(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 15544, 15568);
return return_v;
}


string
f_1354_15586_15611(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Description ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 15586, 15611);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
f_1354_15632_15653(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetPrivateVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 15632, 15653);
return return_v;
}


bool
f_1354_15753_15801(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.CommandOrigin
origin,bool
fromNewOrSet,out System.Management.Automation.PSVariable
variable)
{
var return_v = this_param.TryGetVariable( name, origin, fromNewOrSet, out variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 15753, 15801);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
f_1354_15919_15940(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetPrivateVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 15919, 15940);
return return_v;
}


bool
f_1354_16230_16249(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsConstant ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 16230, 16249);
return return_v;
}


bool
f_1354_16264_16283(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsReadOnly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 16264, 16283);
return return_v;
}


string
f_1354_16660_16699()
{
var return_v =                                     SessionStateStrings.VariableNotWritable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 16660, 16699);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_16407_16700(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 16407, 16700);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1354_16843_16867(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 16843, 16867);
return return_v;
}


bool
f_1354_16843_16873(System.Collections.ObjectModel.Collection<System.Attribute>
source)
{
var return_v = source.Any<System.Attribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 16843, 16873);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_16877_16898(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 16877, 16898);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_16902_16918(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 16902, 16918);
return return_v;
}


string
f_1354_17299_17342()
{
var return_v =                                     SessionStateStrings.VariableNotWritableRare;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 17299, 17342);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_17042_17343(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 17042, 17343);
return return_v;
}


bool
f_1354_17431_17450(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsReadOnly ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 17431, 17450);
return return_v;
}


bool
f_1354_17509_17532(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 17509, 17532);
return return_v;
}


object
f_1354_17635_17654(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 17635, 17654);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_17656_17677(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 17656, 17677);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1354_17679_17703(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 17679, 17703);
return return_v;
}


string
f_1354_17721_17746(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Description ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 17721, 17746);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1354_18026_18045(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18026, 18045);
return return_v;
}


int
f_1354_18026_18053(System.Collections.ObjectModel.Collection<System.Attribute>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 18026, 18053);
return 0;
}


object
f_1354_18099_18118(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18099, 18118);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_18164_18185(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18164, 18185);
return return_v;
}


string
f_1354_18235_18260(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Description;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18235, 18260);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1354_18316_18340(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18316, 18340);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1354_18398_18417(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18398, 18417);
return return_v;
}


int
f_1354_18398_18427(System.Collections.ObjectModel.Collection<System.Attribute>
this_param,System.Attribute
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 18398, 18427);
return 0;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1354_18316_18340_I(System.Collections.ObjectModel.Collection<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 18316, 18340);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_18905_18916()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18905, 18916);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_18927_18938()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 18927, 18938);
return return_v;
}


System.Management.Automation.PSVariable
f_1354_18927_18966(System.Management.Automation.MutableTuple
this_param,string
name,object
value)
{
var return_v = this_param.TrySetVariable( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 18927, 18966);
return return_v;
}


System.Management.Automation.PSVariable
f_1354_18978_19005(string
name,object
value)
{
var return_v = new System.Management.Automation.PSVariable( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 18978, 19005);
return return_v;
}


bool
f_1354_19041_19088()
{
var return_v = ExecutionContext.HasEverUsedConstrainedLanguage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 19041, 19088);
return return_v;
}


int
f_1354_19122_19172(System.Management.Automation.SessionStateScope
this_param,System.Management.Automation.PSVariable
variable)
{
this_param.CheckVariableChangeInConstrainedLanguage( variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 19122, 19172);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,14707,19324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,14707,19324);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetVariableForce(PSVariable variableToSet, SessionStateInternal sessionState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,19681,20059);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19797,19918) || true) && (f_1354_19801_19807()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,19797,19918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19849,19903);

throw f_1354_19855_19902("SetVariableForce");
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,19797,19918);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19934,19976);

variableToSet.SessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,19990,20048);

f_1354_19990_20011(this)[f_1354_20012_20030(variableToSet)] = variableToSet;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,19681,20059);

System.Management.Automation.SessionStateScope
f_1354_19801_19807()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 19801, 19807);
return return_v;
}


System.NotImplementedException
f_1354_19855_19902(string
message)
{
var return_v = new System.NotImplementedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 19855, 19902);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
f_1354_19990_20011(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetPrivateVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 19990, 20011);
return return_v;
}


string
f_1354_20012_20030(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 20012, 20030);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,19681,20059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,19681,20059);
}
		}

internal PSVariable NewVariable(PSVariable newVariable, bool force, SessionStateInternal sessionState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,20786,23245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,20913,20933);

PSVariable 
variable
=default(PSVariable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,20947,21030);

bool 
varExists = f_1354_20964_21029(this, f_1354_20979_20995(newVariable), f_1354_20997_21008(), true, out variable)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,21046,22933) || true) && (varExists)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,21046,22933);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,21206,21736) || true) && (variable == null ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 21210, 21249)||f_1354_21230_21249(variable))||(DynAbs.Tracing.TraceSender.Expression_False(1354, 21210, 21284)||(!force &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 21254, 21283)&&f_1354_21264_21283(variable)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,21206,21736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,21326,21685);

SessionStateUnauthorizedAccessException 
e =
f_1354_21395_21684(f_1354_21473_21489(newVariable), SessionStateCategory.Variable, "VariableNotWritable", f_1354_21644_21683())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,21709,21717);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,21206,21736);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,21756,22245) || true) && (variable is LocalVariable)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,21756,22245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,21827,22194);

SessionStateUnauthorizedAccessException 
e =
f_1354_21896_22193(f_1354_21974_21990(newVariable), SessionStateCategory.Variable, "VariableNotWritableRare", f_1354_22149_22192())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,22218,22226);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,21756,22245);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,22489,22725) || true) && (!f_1354_22494_22532(newVariable, variable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,22489,22725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,22634,22661);

variable.WasRemoved = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,22683,22706);

variable = newVariable;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,22489,22725);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,21046,22933);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,21046,22933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,22895,22918);

variable = newVariable;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,21046,22933);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,22949,23100) || true) && (f_1354_22953_23000())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,22949,23100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,23034,23085);

f_1354_23034_23084(this, variable);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,22949,23100);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,23116,23153);

_variables[f_1354_23127_23140(variable)] = variable;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,23167,23204);

variable.SessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,23218,23234);

return variable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,20786,23245);

string
f_1354_20979_20995(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 20979, 20995);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1354_20997_21008()
{
var return_v = ScopeOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 20997, 21008);
return return_v;
}


bool
f_1354_20964_21029(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.CommandOrigin
origin,bool
fromNewOrSet,out System.Management.Automation.PSVariable
variable)
{
var return_v = this_param.TryGetVariable( name, origin, fromNewOrSet, out variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 20964, 21029);
return return_v;
}


bool
f_1354_21230_21249(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsConstant ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 21230, 21249);
return return_v;
}


bool
f_1354_21264_21283(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsReadOnly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 21264, 21283);
return return_v;
}


string
f_1354_21473_21489(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 21473, 21489);
return return_v;
}


string
f_1354_21644_21683()
{
var return_v =                                 SessionStateStrings.VariableNotWritable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 21644, 21683);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_21395_21684(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 21395, 21684);
return return_v;
}


string
f_1354_21974_21990(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 21974, 21990);
return return_v;
}


string
f_1354_22149_22192()
{
var return_v =                                 SessionStateStrings.VariableNotWritableRare;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 22149, 22192);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_21896_22193(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 21896, 22193);
return return_v;
}


bool
f_1354_22494_22532(System.Management.Automation.PSVariable
objA,System.Management.Automation.PSVariable
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 22494, 22532);
return return_v;
}


bool
f_1354_22953_23000()
{
var return_v = ExecutionContext.HasEverUsedConstrainedLanguage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 22953, 23000);
return return_v;
}


int
f_1354_23034_23084(System.Management.Automation.SessionStateScope
this_param,System.Management.Automation.PSVariable
variable)
{
this_param.CheckVariableChangeInConstrainedLanguage( variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 23034, 23084);
return 0;
}


string
f_1354_23127_23140(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 23127, 23140);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,20786,23245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,20786,23245);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveVariable(string name, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,23734,25153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,23812,23917);

f_1354_23812_23916(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,23933,23973);

PSVariable 
variable = f_1354_23955_23972(this, name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,23989,24453) || true) && (f_1354_23993_24012(variable)||(DynAbs.Tracing.TraceSender.Expression_False(1354, 23993, 24047)||(f_1354_24017_24036(variable)&&(DynAbs.Tracing.TraceSender.Expression_True(1354, 24017, 24046)&&!force))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,23989,24453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,24081,24410);

SessionStateUnauthorizedAccessException 
e =
f_1354_24146_24409(name, SessionStateCategory.Variable, "VariableNotRemovable", f_1354_24368_24408())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,24430,24438);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,23989,24453);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,24469,24912) || true) && (variable is LocalVariable)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,24469,24912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,24532,24869);

SessionStateUnauthorizedAccessException 
e =
f_1354_24597_24868(name, SessionStateCategory.Variable, "VariableNotRemovableRare", f_1354_24823_24867())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,24889,24897);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,24469,24912);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,24928,24952);

f_1354_24928_24951(
            _variables, name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,25115,25142);

variable.WasRemoved = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,23734,25153);

int
f_1354_23812_23916(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 23812, 23916);
return 0;
}


System.Management.Automation.PSVariable
f_1354_23955_23972(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetVariable( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 23955, 23972);
return return_v;
}


bool
f_1354_23993_24012(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsConstant ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 23993, 24012);
return return_v;
}


bool
f_1354_24017_24036(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsReadOnly ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 24017, 24036);
return return_v;
}


string
f_1354_24368_24408()
{
var return_v =                             SessionStateStrings.VariableNotRemovable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 24368, 24408);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_24146_24409(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 24146, 24409);
return return_v;
}


string
f_1354_24823_24867()
{
var return_v =                             SessionStateStrings.VariableNotRemovableRare;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 24823, 24867);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_24597_24868(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 24597, 24868);
return return_v;
}


bool
f_1354_24928_24951(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 24928, 24951);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,23734,25153);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,23734,25153);
}
		}

internal bool TrySetLocalParameterValue(string name, object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,25165,25561);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,25256,25463);
foreach(var dottedScope in f_1354_25284_25297_I(_dottedScopes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,25256,25463);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,25331,25448) || true) && (f_1354_25335_25375(dottedScope, name, value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,25331,25448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,25417,25429);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,25331,25448);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,25256,25463);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,208);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,208);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,25479,25550);

return f_1354_25486_25497()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 25486, 25549)&&f_1354_25509_25549(f_1354_25509_25520(), name, value));
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,25165,25561);

bool
f_1354_25335_25375(System.Management.Automation.MutableTuple
this_param,string
name,object
value)
{
var return_v = this_param.TrySetParameter( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 25335, 25375);
return return_v;
}


System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
f_1354_25284_25297_I(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 25284, 25297);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_25486_25497()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 25486, 25497);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_25509_25520()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 25509, 25520);
return return_v;
}


bool
f_1354_25509_25549(System.Management.Automation.MutableTuple
this_param,string
name,object
value)
{
var return_v = this_param.TrySetParameter( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 25509, 25549);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,25165,25561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,25165,25561);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool TryGetLocalVariableFromTuple(string name, bool fromNewOrSet, out PSVariable result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,26018,26519);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,26140,26370);
foreach(var dottedScope in f_1354_26168_26181_I(_dottedScopes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,26140,26370);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,26215,26355) || true) && (f_1354_26219_26282(dottedScope, name, fromNewOrSet, out result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,26215,26355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,26324,26336);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,26215,26355);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,26140,26370);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,231);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,231);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,26386,26400);

result = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,26414,26508);

return f_1354_26421_26432()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 26421, 26507)&&f_1354_26444_26507(f_1354_26444_26455(), name, fromNewOrSet, out result));
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,26018,26519);

bool
f_1354_26219_26282(System.Management.Automation.MutableTuple
this_param,string
name,bool
fromNewOrSet,out System.Management.Automation.PSVariable
result)
{
var return_v = this_param.TryGetLocalVariable( name, fromNewOrSet, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 26219, 26282);
return return_v;
}


System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
f_1354_26168_26181_I(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 26168, 26181);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_26421_26432()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 26421, 26432);
return return_v;
}


System.Management.Automation.MutableTuple
f_1354_26444_26455()
{
var return_v = LocalsTuple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 26444, 26455);
return return_v;
}


bool
f_1354_26444_26507(System.Management.Automation.MutableTuple
this_param,string
name,bool
fromNewOrSet,out System.Management.Automation.PSVariable
result)
{
var return_v = this_param.TryGetLocalVariable( name, fromNewOrSet, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 26444, 26507);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,26018,26519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,26018,26519);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IEnumerable<AliasInfo> AliasTable
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,26768,26846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,26804,26831);

return f_1354_26811_26830(f_1354_26811_26823(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,26768,26846);

System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_26811_26823(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAliases();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 26811, 26823);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>.ValueCollection
f_1354_26811_26830(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 26811, 26830);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,26701,26857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,26701,26857);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal AliasInfo GetAlias(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,27197,27498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,27262,27367);

f_1354_27262_27366(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,27383,27400);

AliasInfo 
result
=default(AliasInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,27414,27457);

f_1354_27414_27456(f_1354_27414_27426(this), name, out result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,27473,27487);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,27197,27498);

int
f_1354_27262_27366(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 27262, 27366);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_27414_27426(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAliases();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 27414, 27426);
return return_v;
}


bool
f_1354_27414_27456(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key,out System.Management.Automation.AliasInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 27414, 27456);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,27197,27498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,27197,27498);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal AliasInfo SetAliasValue(string name, string value, ExecutionContext context, bool force, CommandOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,28406,30210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,28550,28655);

f_1354_28550_28654(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,28671,28701);

var 
aliasInfos = f_1354_28688_28700(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,28715,28735);

AliasInfo 
aliasInfo
=default(AliasInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,28749,30114) || true) && (!f_1354_28754_28797(aliasInfos, name, out aliasInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,28749,30114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,28831,28886);

aliasInfos[name] = f_1354_28850_28885(name, value, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,28749,30114);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,28749,30114);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29019,29597) || true) && ((f_1354_29024_29041(aliasInfo)& ScopedItemOptions.Constant) != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 29023, 29166)||                    (!force &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 29102, 29165)&&(f_1354_29113_29130(aliasInfo)& ScopedItemOptions.ReadOnly) != 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,29019,29597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29208,29546);

SessionStateUnauthorizedAccessException 
e =
f_1354_29277_29545(name, SessionStateCategory.Alias, "AliasNotWritable", f_1354_29508_29544())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29570,29578);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,29019,29597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29617,29667);

f_1354_29617_29666(origin, aliasInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29685,29744);

f_1354_29685_29743(this, f_1354_29706_29720(aliasInfo), f_1354_29722_29742(aliasInfo));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29764,30099) || true) && (force)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,29764,30099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29815,29839);

f_1354_29815_29838(                    aliasInfos, name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29861,29909);

aliasInfo = f_1354_29873_29908(name, value, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,29931,29960);

aliasInfos[name] = aliasInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,29764,30099);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,29764,30099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,30042,30080);

f_1354_30042_30079(                    aliasInfo, value, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,29764,30099);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,28749,30114);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,30130,30159);

f_1354_30130_30158(this, name, value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,30175,30199);

return f_1354_30182_30198(aliasInfos, name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,28406,30210);

int
f_1354_28550_28654(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 28550, 28654);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_28688_28700(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAliases();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 28688, 28700);
return return_v;
}


bool
f_1354_28754_28797(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key,out System.Management.Automation.AliasInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 28754, 28797);
return return_v;
}


System.Management.Automation.AliasInfo
f_1354_28850_28885(string
name,string
definition,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.AliasInfo( name, definition, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 28850, 28885);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_29024_29041(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 29024, 29041);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_29113_29130(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 29113, 29130);
return return_v;
}


string
f_1354_29508_29544()
{
var return_v =                                 SessionStateStrings.AliasNotWritable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 29508, 29544);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_29277_29545(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 29277, 29545);
return return_v;
}


int
f_1354_29617_29666(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.AliasInfo
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 29617, 29666);
return 0;
}


string
f_1354_29706_29720(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 29706, 29720);
return return_v;
}


string
f_1354_29722_29742(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Definition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 29722, 29742);
return return_v;
}


int
f_1354_29685_29743(System.Management.Automation.SessionStateScope
this_param,string
alias,string
value)
{
this_param.RemoveAliasFromCache( alias, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 29685, 29743);
return 0;
}


bool
f_1354_29815_29838(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 29815, 29838);
return return_v;
}


System.Management.Automation.AliasInfo
f_1354_29873_29908(string
name,string
definition,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.AliasInfo( name, definition, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 29873, 29908);
return return_v;
}


int
f_1354_30042_30079(System.Management.Automation.AliasInfo
this_param,string
definition,bool
force)
{
this_param.SetDefinition( definition, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 30042, 30079);
return 0;
}


int
f_1354_30130_30158(System.Management.Automation.SessionStateScope
this_param,string
alias,string
value)
{
this_param.AddAliasToCache( alias, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 30130, 30158);
return 0;
}


System.Management.Automation.AliasInfo
f_1354_30182_30198(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 30182, 30198);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,28406,30210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,28406,30210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal AliasInfo SetAliasValue(
            string name,
            string value,
            ScopedItemOptions options,
            ExecutionContext context,
            bool force,
            CommandOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,31222,34701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,31472,31577);

f_1354_31472_31576(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,31593,31623);

var 
aliasInfos = f_1354_31610_31622(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,31637,31657);

AliasInfo 
aliasInfo
=default(AliasInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,31671,31688);

AliasInfo 
result
=default(AliasInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,31702,34615) || true) && (!f_1354_31707_31750(aliasInfos, name, out aliasInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,31702,34615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,31784,31838);

result = f_1354_31793_31837(name, value, context, options);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,31856,31882);

aliasInfos[name] = result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,31702,34615);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,31702,34615);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,32015,32593) || true) && ((f_1354_32020_32037(aliasInfo)& ScopedItemOptions.Constant) != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 32019, 32162)||                    (!force &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 32098, 32161)&&(f_1354_32109_32126(aliasInfo)& ScopedItemOptions.ReadOnly) != 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,32015,32593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,32204,32542);

SessionStateUnauthorizedAccessException 
e =
f_1354_32273_32541(name, SessionStateCategory.Alias, "AliasNotWritable", f_1354_32504_32540())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,32566,32574);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,32015,32593);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,32752,33248) || true) && ((options & ScopedItemOptions.Constant) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,32752,33248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,32841,33197);

SessionStateUnauthorizedAccessException 
e =
f_1354_32910_33196(name, SessionStateCategory.Alias, "AliasCannotBeMadeConstant", f_1354_33150_33195())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,33221,33229);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,32752,33248);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,33268,34004) || true) && ((options & ScopedItemOptions.AllScope) == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 33272, 33393)&&                    (f_1354_33341_33358(aliasInfo)& ScopedItemOptions.AllScope) != 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,33268,34004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,33579,33953);

SessionStateUnauthorizedAccessException 
e =
f_1354_33648_33952(name, SessionStateCategory.Alias, "AliasAllScopeOptionCannotBeRemoved", f_1354_33897_33951())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,33977,33985);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,33268,34004);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34024,34074);

f_1354_34024_34073(origin, aliasInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34092,34151);

f_1354_34092_34150(this, f_1354_34113_34127(aliasInfo), f_1354_34129_34149(aliasInfo));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34171,34600) || true) && (force)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,34171,34600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34222,34246);

f_1354_34222_34245(                    aliasInfos, name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34268,34322);

result = f_1354_34277_34321(name, value, context, options);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34344,34370);

aliasInfos[name] = result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,34171,34600);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,34171,34600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34452,34471);

result = aliasInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34493,34521);

aliasInfo.Options = options;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34543,34581);

f_1354_34543_34580(                    aliasInfo, value, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,34171,34600);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,31702,34615);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34631,34660);

f_1354_34631_34659(this, name, value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,34676,34690);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,31222,34701);

int
f_1354_31472_31576(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 31472, 31576);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_31610_31622(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAliases();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 31610, 31622);
return return_v;
}


bool
f_1354_31707_31750(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key,out System.Management.Automation.AliasInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 31707, 31750);
return return_v;
}


System.Management.Automation.AliasInfo
f_1354_31793_31837(string
name,string
definition,System.Management.Automation.ExecutionContext
context,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = new System.Management.Automation.AliasInfo( name, definition, context, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 31793, 31837);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_32020_32037(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 32020, 32037);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_32109_32126(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 32109, 32126);
return return_v;
}


string
f_1354_32504_32540()
{
var return_v =                                 SessionStateStrings.AliasNotWritable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 32504, 32540);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_32273_32541(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 32273, 32541);
return return_v;
}


string
f_1354_33150_33195()
{
var return_v =                                 SessionStateStrings.AliasCannotBeMadeConstant;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 33150, 33195);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_32910_33196(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 32910, 33196);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_33341_33358(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 33341, 33358);
return return_v;
}


string
f_1354_33897_33951()
{
var return_v =                                 SessionStateStrings.AliasAllScopeOptionCannotBeRemoved;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 33897, 33951);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_33648_33952(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 33648, 33952);
return return_v;
}


int
f_1354_34024_34073(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.AliasInfo
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 34024, 34073);
return 0;
}


string
f_1354_34113_34127(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 34113, 34127);
return return_v;
}


string
f_1354_34129_34149(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Definition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 34129, 34149);
return return_v;
}


int
f_1354_34092_34150(System.Management.Automation.SessionStateScope
this_param,string
alias,string
value)
{
this_param.RemoveAliasFromCache( alias, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 34092, 34150);
return 0;
}


bool
f_1354_34222_34245(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 34222, 34245);
return return_v;
}


System.Management.Automation.AliasInfo
f_1354_34277_34321(string
name,string
definition,System.Management.Automation.ExecutionContext
context,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = new System.Management.Automation.AliasInfo( name, definition, context, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 34277, 34321);
return return_v;
}


int
f_1354_34543_34580(System.Management.Automation.AliasInfo
this_param,string
definition,bool
force)
{
this_param.SetDefinition( definition, force);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 34543, 34580);
return 0;
}


int
f_1354_34631_34659(System.Management.Automation.SessionStateScope
this_param,string
alias,string
value)
{
this_param.AddAliasToCache( alias, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 34631, 34659);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,31222,34701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,31222,34701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal AliasInfo SetAliasItem(AliasInfo aliasToSet, bool force, CommandOrigin origin = CommandOrigin.Internal)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,35462,37809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,35599,35716);

f_1354_35599_35715(aliasToSet != null, "The caller should verify the aliasToSet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,35732,35762);

var 
aliasInfos = f_1354_35749_35761(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,35776,35796);

AliasInfo 
aliasInfo
=default(AliasInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,35810,37635) || true) && (f_1354_35814_35868(aliasInfos, f_1354_35837_35852(aliasToSet), out aliasInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,35810,37635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,36106,36156);

f_1354_36106_36155(origin, aliasInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,36174,36763) || true) && ((f_1354_36179_36196(aliasInfo)& ScopedItemOptions.Constant) != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 36178, 36321)||                    ((f_1354_36258_36275(aliasInfo)& ScopedItemOptions.ReadOnly) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 36257, 36320)&&!force))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,36174,36763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,36363,36712);

SessionStateUnauthorizedAccessException 
e =
f_1354_36432_36711(f_1354_36510_36525(aliasToSet), SessionStateCategory.Alias, "AliasNotWritable", f_1354_36674_36710())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,36736,36744);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,36174,36763);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,36783,37541) || true) && ((f_1354_36788_36806(aliasToSet)& ScopedItemOptions.AllScope) == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 36787, 36919)&&                    (f_1354_36867_36884(aliasInfo)& ScopedItemOptions.AllScope) != 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,36783,37541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,37105,37490);

SessionStateUnauthorizedAccessException 
e =
f_1354_37174_37489(f_1354_37252_37267(aliasToSet), SessionStateCategory.Alias, "AliasAllScopeOptionCannotBeRemoved", f_1354_37434_37488())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,37514,37522);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,36783,37541);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,37561,37620);

f_1354_37561_37619(this, f_1354_37582_37596(aliasInfo), f_1354_37598_37618(aliasInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,35810,37635);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,37651,37692);

aliasInfos[f_1354_37662_37677(aliasToSet)] = aliasToSet;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,37708,37764);

f_1354_37708_37763(this, f_1354_37724_37739(aliasToSet), f_1354_37741_37762(aliasToSet));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,37780,37798);

return aliasToSet;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,35462,37809);

int
f_1354_35599_35715(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 35599, 35715);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_35749_35761(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAliases();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 35749, 35761);
return return_v;
}


string
f_1354_35837_35852(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 35837, 35852);
return return_v;
}


bool
f_1354_35814_35868(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key,out System.Management.Automation.AliasInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 35814, 35868);
return return_v;
}


int
f_1354_36106_36155(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.AliasInfo
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 36106, 36155);
return 0;
}


System.Management.Automation.ScopedItemOptions
f_1354_36179_36196(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 36179, 36196);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_36258_36275(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 36258, 36275);
return return_v;
}


string
f_1354_36510_36525(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 36510, 36525);
return return_v;
}


string
f_1354_36674_36710()
{
var return_v =                                 SessionStateStrings.AliasNotWritable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 36674, 36710);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_36432_36711(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 36432, 36711);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_36788_36806(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 36788, 36806);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_36867_36884(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 36867, 36884);
return return_v;
}


string
f_1354_37252_37267(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 37252, 37267);
return return_v;
}


string
f_1354_37434_37488()
{
var return_v =                                 SessionStateStrings.AliasAllScopeOptionCannotBeRemoved;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 37434, 37488);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_37174_37489(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 37174, 37489);
return return_v;
}


string
f_1354_37582_37596(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 37582, 37596);
return return_v;
}


string
f_1354_37598_37618(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Definition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 37598, 37618);
return return_v;
}


int
f_1354_37561_37619(System.Management.Automation.SessionStateScope
this_param,string
alias,string
value)
{
this_param.RemoveAliasFromCache( alias, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 37561, 37619);
return 0;
}


string
f_1354_37662_37677(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 37662, 37677);
return return_v;
}


string
f_1354_37724_37739(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 37724, 37739);
return return_v;
}


string
f_1354_37741_37762(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Definition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 37741, 37762);
return return_v;
}


int
f_1354_37708_37763(System.Management.Automation.SessionStateScope
this_param,string
alias,string
value)
{
this_param.AddAliasToCache( alias, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 37708, 37763);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,35462,37809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,35462,37809);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveAlias(string name, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,38285,39430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,38360,38465);

f_1354_38360_38464(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,38546,38576);

var 
aliasInfos = f_1354_38563_38575(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,38590,38610);

AliasInfo 
aliasInfo
=default(AliasInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,38624,39379) || true) && (f_1354_38628_38671(aliasInfos, name, out aliasInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,38624,39379);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,38705,39285) || true) && ((f_1354_38710_38727(aliasInfo)& ScopedItemOptions.Constant) != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 38709, 38852)||                    (!force &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 38788, 38851)&&(f_1354_38799_38816(aliasInfo)& ScopedItemOptions.ReadOnly) != 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,38705,39285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,38894,39234);

SessionStateUnauthorizedAccessException 
e =
f_1354_38963_39233(name, SessionStateCategory.Alias, "AliasNotRemovable", f_1354_39195_39232())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,39258,39266);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,38705,39285);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,39305,39364);

f_1354_39305_39363(this, f_1354_39326_39340(aliasInfo), f_1354_39342_39362(aliasInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,38624,39379);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,39395,39419);

f_1354_39395_39418(
            aliasInfos, name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,38285,39430);

int
f_1354_38360_38464(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 38360, 38464);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_38563_38575(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAliases();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 38563, 38575);
return return_v;
}


bool
f_1354_38628_38671(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key,out System.Management.Automation.AliasInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 38628, 38671);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_38710_38727(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 38710, 38727);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_38799_38816(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 38799, 38816);
return return_v;
}


string
f_1354_39195_39232()
{
var return_v =                                 SessionStateStrings.AliasNotRemovable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 39195, 39232);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_38963_39233(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 38963, 39233);
return return_v;
}


string
f_1354_39326_39340(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 39326, 39340);
return return_v;
}


string
f_1354_39342_39362(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Definition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 39342, 39362);
return return_v;
}


int
f_1354_39305_39363(System.Management.Automation.SessionStateScope
this_param,string
alias,string
value)
{
this_param.RemoveAliasFromCache( alias, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 39305, 39363);
return 0;
}


bool
f_1354_39395_39418(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 39395, 39418);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,38285,39430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,38285,39430);
}
		}

internal Dictionary<string, FunctionInfo> FunctionTable
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,39694,39767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,39730,39752);

return f_1354_39737_39751(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,39694,39767);

System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_39737_39751(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetFunctions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 39737, 39751);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,39614,39778);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,39614,39778);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal FunctionInfo GetFunction(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,40178,40490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,40249,40354);

f_1354_40249_40353(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,40370,40390);

FunctionInfo 
result
=default(FunctionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,40404,40449);

f_1354_40404_40448(f_1354_40404_40418(this), name, out result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,40465,40479);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,40178,40490);

int
f_1354_40249_40353(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 40249, 40353);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_40404_40418(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetFunctions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 40404, 40418);
return return_v;
}


bool
f_1354_40404_40448(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
this_param,string
key,out System.Management.Automation.FunctionInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 40404, 40448);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,40178,40490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,40178,40490);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal FunctionInfo SetFunction(
            string name,
            ScriptBlock function,
            bool force,
            CommandOrigin origin,
            ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,41519,41845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,41738,41834);

return f_1354_41745_41833(this, name, function, null, ScopedItemOptions.Unspecified, force, origin, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,41519,41845);

System.Management.Automation.FunctionInfo
f_1354_41745_41833(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.ScopedItemOptions
options,bool
force,System.Management.Automation.CommandOrigin
origin,System.Management.Automation.ExecutionContext
context)
{
var return_v = this_param.SetFunction( name, function, originalFunction, options, force, origin, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 41745, 41833);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,41519,41845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,41519,41845);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal FunctionInfo SetFunction(
            string name,
            ScriptBlock function,
            FunctionInfo originalFunction,
            bool force,
            CommandOrigin origin,
            ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,43023,43405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,43286,43394);

return f_1354_43293_43393(this, name, function, originalFunction, ScopedItemOptions.Unspecified, force, origin, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,43023,43405);

System.Management.Automation.FunctionInfo
f_1354_43293_43393(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.ScopedItemOptions
options,bool
force,System.Management.Automation.CommandOrigin
origin,System.Management.Automation.ExecutionContext
context)
{
var return_v = this_param.SetFunction( name, function, originalFunction, options, force, origin, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 43293, 43393);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,43023,43405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,43023,43405);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal FunctionInfo SetFunction(
            string name,
            ScriptBlock function,
            FunctionInfo originalFunction,
            ScopedItemOptions options,
            bool force,
            CommandOrigin origin,
            ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,44701,45107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,45004,45096);

return f_1354_45011_45095(this, name, function, originalFunction, options, force, origin, context, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,44701,45107);

System.Management.Automation.FunctionInfo
f_1354_45011_45095(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.ScopedItemOptions
options,bool
force,System.Management.Automation.CommandOrigin
origin,System.Management.Automation.ExecutionContext
context,string
helpFile)
{
var return_v = this_param.SetFunction( name, function, originalFunction, options, force, origin, context, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 45011, 45095);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,44701,45107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,44701,45107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal FunctionInfo SetFunction(
            string name,
            ScriptBlock function,
            FunctionInfo originalFunction,
            ScopedItemOptions options,
            bool force,
            CommandOrigin origin,
            ExecutionContext context,
            string helpFile)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,45119,45575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,45452,45564);

return f_1354_45459_45563(this, name, function, originalFunction, options, force, origin, context, helpFile, CreateFunction);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,45119,45575);

System.Management.Automation.FunctionInfo
f_1354_45459_45563(System.Management.Automation.SessionStateScope
this_param,string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.FunctionInfo
originalFunction,System.Management.Automation.ScopedItemOptions
options,bool
force,System.Management.Automation.CommandOrigin
origin,System.Management.Automation.ExecutionContext
context,string
helpFile,System.Func<string, System.Management.Automation.ScriptBlock, System.Management.Automation.FunctionInfo, System.Management.Automation.ScopedItemOptions, System.Management.Automation.ExecutionContext, string, System.Management.Automation.FunctionInfo>
functionFactory)
{
var return_v = this_param.SetFunction( name, function, originalFunction, options, force, origin, context, helpFile, functionFactory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 45459, 45563);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,45119,45575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,45119,45575);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal FunctionInfo SetFunction(
            string name,
            ScriptBlock function,
            FunctionInfo originalFunction,
            ScopedItemOptions options,
            bool force,
            CommandOrigin origin,
            ExecutionContext context,
            string helpFile,
            Func<string, ScriptBlock, FunctionInfo, ScopedItemOptions, ExecutionContext, string, FunctionInfo> functionFactory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,47115,51696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,47577,47682);

f_1354_47577_47681(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,47698,47733);

var 
functionInfos = f_1354_47718_47732(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,47747,47774);

FunctionInfo 
existingValue
=default(FunctionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,47788,47808);

FunctionInfo 
result
=default(FunctionInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,47822,51655) || true) && (!f_1354_47827_47877(functionInfos, name, out existingValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,47822,51655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,47911,47998);

result = f_1354_47920_47997(functionFactory, name, function, originalFunction, options, context, helpFile);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,48016,48045);

functionInfos[name] = result;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,48065,48223) || true) && (f_1354_48069_48124(result, ScopedItemOptions.AllScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,48065,48223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,48166,48204);

f_1354_48166_48188(this)[name] = result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,48065,48223);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,47822,51655);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,47822,51655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,48361,48415);

f_1354_48361_48414(origin, existingValue);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,48435,49040) || true) && (f_1354_48439_48501(existingValue, ScopedItemOptions.Constant)||(DynAbs.Tracing.TraceSender.Expression_False(1354, 48439, 48600)||                    (!force &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 48527, 48599)&&f_1354_48537_48599(existingValue, ScopedItemOptions.ReadOnly)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,48435,49040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,48642,48989);

SessionStateUnauthorizedAccessException 
e =
f_1354_48711_48988(name, SessionStateCategory.Function, "FunctionNotWritable", f_1354_48948_48987())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,49013,49021);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,48435,49040);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,49202,49707) || true) && ((options & ScopedItemOptions.Constant) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,49202,49707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,49291,49656);

SessionStateUnauthorizedAccessException 
e =
f_1354_49360_49655(name, SessionStateCategory.Function, "FunctionCannotBeMadeConstant", f_1354_49606_49654())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,49680,49688);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,49202,49707);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,49804,50414) || true) && ((options & ScopedItemOptions.AllScope) == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 49808, 49938)&&f_1354_49876_49938(existingValue, ScopedItemOptions.AllScope)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,49804,50414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,49980,50363);

SessionStateUnauthorizedAccessException 
e =
f_1354_50049_50362(name, SessionStateCategory.Function, "FunctionAllScopeOptionCannotBeRemoved", f_1354_50304_50361())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,50387,50395);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,49804,50414);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,50434,50480);

FunctionInfo 
existingFunction = existingValue
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,50498,50527);

FunctionInfo 
newValue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,50690,50779);

newValue = f_1354_50701_50778(functionFactory, name, function, originalFunction, options, context, helpFile);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,50799,50875);

bool 
changesFunctionType = f_1354_50826_50852(existingFunction)!= f_1354_50856_50874(newValue)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,51099,51640) || true) && (changesFunctionType ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 51103, 51218)||                    ((f_1354_51149_51173(existingFunction)& ScopedItemOptions.ReadOnly) != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 51148, 51217)&&force))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,51099,51640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,51260,51278);

result = newValue;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,51300,51331);

functionInfos[name] = newValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,51099,51640);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,51099,51640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,51413,51484);

bool 
applyForce = force ||(DynAbs.Tracing.TraceSender.Expression_False(1354, 51431, 51483)||(options & ScopedItemOptions.ReadOnly) == 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,51508,51573);

f_1354_51508_51572(
                    existingFunction, newValue, applyForce, options, helpFile);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,51595,51621);

result = existingFunction;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,51099,51640);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,47822,51655);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,51671,51685);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,47115,51696);

int
f_1354_47577_47681(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 47577, 47681);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_47718_47732(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetFunctions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 47718, 47732);
return return_v;
}


bool
f_1354_47827_47877(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
this_param,string
key,out System.Management.Automation.FunctionInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 47827, 47877);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1354_47920_47997(System.Func<string, System.Management.Automation.ScriptBlock, System.Management.Automation.FunctionInfo, System.Management.Automation.ScopedItemOptions, System.Management.Automation.ExecutionContext, string, System.Management.Automation.FunctionInfo>
this_param,string
arg1,System.Management.Automation.ScriptBlock
arg2,System.Management.Automation.FunctionInfo
arg3,System.Management.Automation.ScopedItemOptions
arg4,System.Management.Automation.ExecutionContext
arg5,string
arg6)
{
var return_v = this_param.Invoke( arg1, arg2, arg3, arg4, arg5, arg6);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 47920, 47997);
return return_v;
}


bool
f_1354_48069_48124(System.Management.Automation.FunctionInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = IsFunctionOptionSet( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 48069, 48124);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_48166_48188(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAllScopeFunctions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 48166, 48188);
return return_v;
}


int
f_1354_48361_48414(System.Management.Automation.CommandOrigin
origin,System.Management.Automation.FunctionInfo
valueToCheck)
{
SessionState.ThrowIfNotVisible( origin, (object)valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 48361, 48414);
return 0;
}


bool
f_1354_48439_48501(System.Management.Automation.FunctionInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = IsFunctionOptionSet( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 48439, 48501);
return return_v;
}


bool
f_1354_48537_48599(System.Management.Automation.FunctionInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = IsFunctionOptionSet( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 48537, 48599);
return return_v;
}


string
f_1354_48948_48987()
{
var return_v =                                 SessionStateStrings.FunctionNotWritable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 48948, 48987);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_48711_48988(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 48711, 48988);
return return_v;
}


string
f_1354_49606_49654()
{
var return_v =                                 SessionStateStrings.FunctionCannotBeMadeConstant;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 49606, 49654);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_49360_49655(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 49360, 49655);
return return_v;
}


bool
f_1354_49876_49938(System.Management.Automation.FunctionInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = IsFunctionOptionSet( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 49876, 49938);
return return_v;
}


string
f_1354_50304_50361()
{
var return_v =                                 SessionStateStrings.FunctionAllScopeOptionCannotBeRemoved;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 50304, 50361);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_50049_50362(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 50049, 50362);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1354_50701_50778(System.Func<string, System.Management.Automation.ScriptBlock, System.Management.Automation.FunctionInfo, System.Management.Automation.ScopedItemOptions, System.Management.Automation.ExecutionContext, string, System.Management.Automation.FunctionInfo>
this_param,string
arg1,System.Management.Automation.ScriptBlock
arg2,System.Management.Automation.FunctionInfo
arg3,System.Management.Automation.ScopedItemOptions
arg4,System.Management.Automation.ExecutionContext
arg5,string
arg6)
{
var return_v = this_param.Invoke( arg1, arg2, arg3, arg4, arg5, arg6);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 50701, 50778);
return return_v;
}


System.Type
f_1354_50826_50852(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 50826, 50852);
return return_v;
}


System.Type
f_1354_50856_50874(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 50856, 50874);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_51149_51173(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 51149, 51173);
return return_v;
}


int
f_1354_51508_51572(System.Management.Automation.FunctionInfo
this_param,System.Management.Automation.FunctionInfo
newFunction,bool
force,System.Management.Automation.ScopedItemOptions
options,string
helpFile)
{
this_param.Update( newFunction, force, options, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 51508, 51572);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,47115,51696);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,47115,51696);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveFunction(string name, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,52182,53393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,52260,52365);

f_1354_52260_52364(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,52381,52416);

var 
functionInfos = f_1354_52401_52415(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,52430,52452);

FunctionInfo 
function
=default(FunctionInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,52466,53339) || true) && (f_1354_52470_52515(functionInfos, name, out function))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,52466,53339);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,52549,53146) || true) && (f_1354_52553_52610(function, ScopedItemOptions.Constant)||(DynAbs.Tracing.TraceSender.Expression_False(1354, 52553, 52704)||                    (!force &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 52636, 52703)&&f_1354_52646_52703(function, ScopedItemOptions.ReadOnly)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,52549,53146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,52746,53095);

SessionStateUnauthorizedAccessException 
e =
f_1354_52815_53094(name, SessionStateCategory.Function, "FunctionNotRemovable", f_1354_53053_53093())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,53119,53127);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,52549,53146);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,53166,53324) || true) && (f_1354_53170_53227(function, ScopedItemOptions.AllScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,53166,53324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,53269,53305);

f_1354_53269_53304(f_1354_53269_53291(this), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,53166,53324);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,52466,53339);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,53355,53382);

f_1354_53355_53381(
            functionInfos, name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,52182,53393);

int
f_1354_52260_52364(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 52260, 52364);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_52401_52415(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetFunctions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 52401, 52415);
return return_v;
}


bool
f_1354_52470_52515(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
this_param,string
key,out System.Management.Automation.FunctionInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 52470, 52515);
return return_v;
}


bool
f_1354_52553_52610(System.Management.Automation.FunctionInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = IsFunctionOptionSet( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 52553, 52610);
return return_v;
}


bool
f_1354_52646_52703(System.Management.Automation.FunctionInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = IsFunctionOptionSet( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 52646, 52703);
return return_v;
}


string
f_1354_53053_53093()
{
var return_v =                                 SessionStateStrings.FunctionNotRemovable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 53053, 53093);
return return_v;
}


System.Management.Automation.SessionStateUnauthorizedAccessException
f_1354_52815_53094(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 52815, 53094);
return return_v;
}


bool
f_1354_53170_53227(System.Management.Automation.FunctionInfo
function,System.Management.Automation.ScopedItemOptions
options)
{
var return_v = IsFunctionOptionSet( function, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 53170, 53227);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_53269_53291(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAllScopeFunctions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 53269, 53291);
return return_v;
}


bool
f_1354_53269_53304(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 53269, 53304);
return return_v;
}


bool
f_1354_53355_53381(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 53355, 53381);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,52182,53393);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,52182,53393);
}
		}

internal Dictionary<string, List<CmdletInfo>> CmdletTable
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,53657,53724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,53693,53709);

return _cmdlets;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,53657,53724);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,53575,53735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,53575,53735);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal CmdletInfo GetCmdlet(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,54058,54582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,54125,54230);

f_1354_54125_54229(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,54246,54271);

CmdletInfo 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,54287,54312);

List<CmdletInfo> 
cmdlets
=default(List<CmdletInfo>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,54328,54541) || true) && (f_1354_54332_54371(_cmdlets, name, out cmdlets))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,54328,54541);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,54405,54526) || true) && (cmdlets != null &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 54409, 54445)&&f_1354_54428_54441(cmdlets)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,54405,54526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,54487,54507);

result = f_1354_54496_54506(cmdlets, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,54405,54526);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,54328,54541);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,54557,54571);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,54058,54582);

int
f_1354_54125_54229(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 54125, 54229);
return 0;
}


bool
f_1354_54332_54371(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key,out System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 54332, 54371);
return return_v;
}


int
f_1354_54428_54441(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 54428, 54441);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1354_54496_54506(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 54496, 54506);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,54058,54582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,54058,54582);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal CmdletInfo AddCmdletToCache(
            string name,
            CmdletInfo cmdlet,
            CommandOrigin origin,
            ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,55368,58814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,55562,55593);

bool 
throwNotSupported = false
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,55643,55756);

f_1354_55643_55755(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,55776,55801);

List<CmdletInfo> 
cmdlets
=default(List<CmdletInfo>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,55819,58306) || true) && (!f_1354_55824_55863(_cmdlets, name, out cmdlets))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,55819,58306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,55905,55938);

cmdlets = f_1354_55915_55937();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,55960,55980);

f_1354_55960_55979(                    cmdlets, cmdlet);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,56002,56030);

f_1354_56002_56029(                    _cmdlets, name, cmdlets);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,56054,56222) || true) && ((f_1354_56059_56073(cmdlet)& ScopedItemOptions.AllScope) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,56054,56222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,56158,56199);

f_1354_56158_56198(f_1354_56158_56180(_allScopeCmdlets, name), 0, cmdlet);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,56054,56222);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,55819,58306);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,55819,58306);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,56304,58065) || true) && (!f_1354_56309_56348(f_1354_56330_56347(cmdlet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,56304,58065);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,56501,57297);
foreach(CmdletInfo cmdletInfo in f_1354_56535_56542_I(cmdlets) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,56501,57297);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,56600,57270) || true) && (f_1354_56604_56738(f_1354_56618_56633(cmdlet), f_1354_56635_56654(cmdletInfo), StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,56600,57270);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,56804,57077) || true) && (f_1354_56808_56831(cmdlet)== f_1354_56835_56862(cmdletInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,56804,57077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,57030,57042);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,56804,57077);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,57174,57199);

throwNotSupported = true;
DynAbs.Tracing.TraceSender.TraceBreak(1354,57233,57239);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,56600,57270);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,56501,57297);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,797);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,797);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1354,56304,58065);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,56304,58065);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,57502,58042);
foreach(CmdletInfo cmdletInfo in f_1354_57536_57543_I(cmdlets) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,57502,58042);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,57601,57863) || true) && (f_1354_57605_57628(cmdlet)== f_1354_57632_57659(cmdletInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,57601,57863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,57820,57832);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,57601,57863);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,57954,57979);

throwNotSupported = true;
DynAbs.Tracing.TraceSender.TraceBreak(1354,58009,58015);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,57502,58042);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,541);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,541);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1354,56304,58065);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,58166,58287) || true) && (!throwNotSupported)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,58166,58287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,58238,58264);

f_1354_58238_58263(                        cmdlets, 0, cmdlet);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,58166,58287);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,55819,58306);
}
            }
            catch (ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1354,58335,58433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,58393,58418);

throwNotSupported = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1354,58335,58433);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,58449,58762) || true) && (throwNotSupported)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,58449,58762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,58504,58708);

PSNotSupportedException 
notSupported =
f_1354_58564_58707(f_1354_58629_58668(), f_1354_58695_58706(cmdlet))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,58728,58747);

throw notSupported;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,58449,58762);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,58778,58803);

return f_1354_58785_58802(f_1354_58785_58799(_cmdlets, name), 0);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,55368,58814);

int
f_1354_55643_55755(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 55643, 55755);
return 0;
}


bool
f_1354_55824_55863(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key,out System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 55824, 55863);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1354_55915_55937()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CmdletInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 55915, 55937);
return return_v;
}


int
f_1354_55960_55979(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,System.Management.Automation.CmdletInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 55960, 55979);
return 0;
}


int
f_1354_56002_56029(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key,System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 56002, 56029);
return 0;
}


System.Management.Automation.ScopedItemOptions
f_1354_56059_56073(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 56059, 56073);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1354_56158_56180(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 56158, 56180);
return return_v;
}


int
f_1354_56158_56198(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,int
index,System.Management.Automation.CmdletInfo
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 56158, 56198);
return 0;
}


string
f_1354_56330_56347(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 56330, 56347);
return return_v;
}


bool
f_1354_56309_56348(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 56309, 56348);
return return_v;
}


string
f_1354_56618_56633(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 56618, 56633);
return return_v;
}


string
f_1354_56635_56654(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 56635, 56654);
return return_v;
}


bool
f_1354_56604_56738(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 56604, 56738);
return return_v;
}


System.Type
f_1354_56808_56831(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.ImplementingType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 56808, 56831);
return return_v;
}


System.Type
f_1354_56835_56862(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.ImplementingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 56835, 56862);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1354_56535_56542_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 56535, 56542);
return return_v;
}


System.Type
f_1354_57605_57628(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.ImplementingType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 57605, 57628);
return return_v;
}


System.Type
f_1354_57632_57659(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.ImplementingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 57632, 57659);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1354_57536_57543_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 57536, 57543);
return return_v;
}


int
f_1354_58238_58263(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,int
index,System.Management.Automation.CmdletInfo
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 58238, 58263);
return 0;
}


string
f_1354_58629_58668()
{
var return_v =                         DiscoveryExceptions.DuplicateCmdletName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 58629, 58668);
return return_v;
}


string
f_1354_58695_58706(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 58695, 58706);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1354_58564_58707(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 58564, 58707);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1354_58785_58799(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 58785, 58799);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1354_58785_58802(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 58785, 58802);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,55368,58814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,55368,58814);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveCmdlet(string name, int index, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,59462,60328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,59549,59654);

f_1354_59549_59653(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,59670,59695);

List<CmdletInfo> 
cmdlets
=default(List<CmdletInfo>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,59709,60317) || true) && (f_1354_59713_59752(_cmdlets, name, out cmdlets))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,59709,60317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,59786,59825);

CmdletInfo 
tempCmdlet = f_1354_59810_59824(cmdlets, index)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,59845,60003) || true) && ((f_1354_59850_59868(tempCmdlet)& ScopedItemOptions.AllScope) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,59845,60003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,59945,59984);

f_1354_59945_59983(f_1354_59945_59967(_allScopeCmdlets, name), index);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,59845,60003);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,60023,60047);

f_1354_60023_60046(
                cmdlets, index);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,60129,60302) || true) && (f_1354_60133_60146(cmdlets)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,60129,60302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,60232,60254);

f_1354_60232_60253(                    // Remove the key
                    _cmdlets, name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,60276,60283);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,60129,60302);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,59709,60317);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,59462,60328);

int
f_1354_59549_59653(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 59549, 59653);
return 0;
}


bool
f_1354_59713_59752(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key,out System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 59713, 59752);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1354_59810_59824(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 59810, 59824);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_59850_59868(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 59850, 59868);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
f_1354_59945_59967(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 59945, 59967);
return return_v;
}


int
f_1354_59945_59983(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 59945, 59983);
return 0;
}


int
f_1354_60023_60046(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 60023, 60046);
return 0;
}


int
f_1354_60133_60146(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 60133, 60146);
return return_v;
}


bool
f_1354_60232_60253(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 60232, 60253);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,59462,60328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,59462,60328);
}
		}

internal void RemoveCmdletEntry(string name, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,60822,61057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,60903,61008);

f_1354_60903_61007(name != null, "The caller should verify the name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61024,61046);

f_1354_61024_61045(
            _cmdlets, name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,60822,61057);

int
f_1354_60903_61007(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 60903, 61007);
return 0;
}


bool
f_1354_61024_61045(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 61024, 61045);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,60822,61057);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,60822,61057);
}
		}

private Language.TypeResolutionState _typeResolutionState;

internal Language.TypeResolutionState TypeResolutionState
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,61276,61562);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61312,61433) || true) && (_typeResolutionState != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,61312,61433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61386,61414);

return _typeResolutionState;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,61312,61433);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61453,61547);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1354, 61460, 61474)||((f_1354_61460_61466()!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(1354, 61477, 61503))||DynAbs.Tracing.TraceSender.Conditional_F3(1354, 61506, 61546)))?f_1354_61477_61503(f_1354_61477_61483()):Language.TypeResolutionState.UsingSystem;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,61276,61562);

System.Management.Automation.SessionStateScope
f_1354_61460_61466()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 61460, 61466);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_61477_61483()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 61477, 61483);
return return_v;
}


System.Management.Automation.Language.TypeResolutionState
f_1354_61477_61503(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.TypeResolutionState ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 61477, 61503);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,61194,61626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,61194,61626);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,61578,61615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61584,61613);

_typeResolutionState = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,61578,61615);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,61194,61626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,61194,61626);
}
		}}

internal IDictionary<string, Type> TypeTable {get; private set; }

internal void AddType(string name, Type type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,61716,61981);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61786,61931) || true) && (f_1354_61790_61799()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,61786,61931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61841,61916);

TypeTable = f_1354_61853_61915(f_1354_61882_61914());
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,61786,61931);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,61947,61970);

f_1354_61947_61956()[name] = type;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,61716,61981);

System.Collections.Generic.IDictionary<string, System.Type>
f_1354_61790_61799()
{
var return_v = TypeTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 61790, 61799);
return return_v;
}


System.StringComparer
f_1354_61882_61914()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 61882, 61914);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Type>
f_1354_61853_61915(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Type>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 61853, 61915);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Type>
f_1354_61947_61956()
{
var return_v = TypeTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 61947, 61956);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,61716,61981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,61716,61981);
}
		}

internal Type LookupType(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,61993,62209);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62055,62090) || true) && (f_1354_62059_62068()== null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,62055,62090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62078,62090);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,62055,62090);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62104,62116);

Type 
result
=default(Type);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62130,62170);

f_1354_62130_62169(f_1354_62130_62139(), name, out result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62184,62198);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,61993,62209);

System.Collections.Generic.IDictionary<string, System.Type>
f_1354_62059_62068()
{
var return_v = TypeTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 62059, 62068);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Type>
f_1354_62130_62139()
{
var return_v = TypeTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 62130, 62139);
return return_v;
}


bool
f_1354_62130_62169(System.Collections.Generic.IDictionary<string, System.Type>
this_param,string
key,out System.Type
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 62130, 62169);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,61993,62209);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,61993,62209);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsFunctionOptionSet(FunctionInfo function, ScopedItemOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1354,62323,62489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62437,62478);

return (f_1354_62445_62461(function)& options) != 0;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1354,62323,62489);

System.Management.Automation.ScopedItemOptions
f_1354_62445_62461(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 62445, 62461);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,62323,62489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,62323,62489);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static FunctionInfo CreateFunction(string name, ScriptBlock function, FunctionInfo originalFunction,
            ScopedItemOptions options, ExecutionContext context, string helpFile)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1354,62501,64038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62717,62746);

FunctionInfo 
newValue = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62762,62888) || true) && (options == ScopedItemOptions.Unspecified)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,62762,62888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62840,62873);

options = ScopedItemOptions.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,62762,62888);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,62952,63995) || true) && (originalFunction is FilterInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,62952,63995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63020,63082);

newValue = f_1354_63031_63081(name, (FilterInfo)originalFunction);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,62952,63995);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,62952,63995);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63116,63995) || true) && (originalFunction is ConfigurationInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63116,63995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63191,63267);

newValue = f_1354_63202_63266(name, (ConfigurationInfo)originalFunction);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63116,63995);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63116,63995);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63301,63995) || true) && (originalFunction != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63301,63995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63363,63415);

newValue = f_1354_63374_63414(name, originalFunction);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63301,63995);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63301,63995);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63602,63995) || true) && (f_1354_63606_63623(function))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63602,63995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63627,63697);

newValue = f_1354_63638_63696(name, function, options, context, helpFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63602,63995);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63602,63995);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63718,63995) || true) && (f_1354_63722_63746(function))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63718,63995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63780,63889);

newValue = f_1354_63791_63888(name, function, options, context, helpFile, f_1354_63857_63887(function));
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63718,63995);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,63718,63995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,63923,63995);

newValue = f_1354_63934_63994(name, function, options, context, helpFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63718,63995);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63602,63995);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63301,63995);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,63116,63995);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,62952,63995);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,64011,64027);

return newValue;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1354,62501,64038);

System.Management.Automation.FilterInfo
f_1354_63031_63081(string
name,System.Management.Automation.FunctionInfo
other)
{
var return_v = new System.Management.Automation.FilterInfo( name, (System.Management.Automation.FilterInfo)other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 63031, 63081);
return return_v;
}


System.Management.Automation.ConfigurationInfo
f_1354_63202_63266(string
name,System.Management.Automation.FunctionInfo
other)
{
var return_v = new System.Management.Automation.ConfigurationInfo( name, (System.Management.Automation.ConfigurationInfo)other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 63202, 63266);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1354_63374_63414(string
name,System.Management.Automation.FunctionInfo
other)
{
var return_v = new System.Management.Automation.FunctionInfo( name, other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 63374, 63414);
return return_v;
}


bool
f_1354_63606_63623(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.IsFilter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 63606, 63623);
return return_v;
}


System.Management.Automation.FilterInfo
f_1354_63638_63696(string
name,System.Management.Automation.ScriptBlock
filter,System.Management.Automation.ScopedItemOptions
options,System.Management.Automation.ExecutionContext
context,string
helpFile)
{
var return_v = new System.Management.Automation.FilterInfo( name, filter, options, context, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 63638, 63696);
return return_v;
}


bool
f_1354_63722_63746(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.IsConfiguration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 63722, 63746);
return return_v;
}


bool
f_1354_63857_63887(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.IsMetaConfiguration();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 63857, 63887);
return return_v;
}


System.Management.Automation.ConfigurationInfo
f_1354_63791_63888(string
name,System.Management.Automation.ScriptBlock
configuration,System.Management.Automation.ScopedItemOptions
options,System.Management.Automation.ExecutionContext
context,string
helpFile,bool
isMetaConfig)
{
var return_v = new System.Management.Automation.ConfigurationInfo( name, configuration, options, context, helpFile, isMetaConfig);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 63791, 63888);
return return_v;
}


System.Management.Automation.FunctionInfo
f_1354_63934_63994(string
name,System.Management.Automation.ScriptBlock
function,System.Management.Automation.ScopedItemOptions
options,System.Management.Automation.ExecutionContext
context,string
helpFile)
{
var return_v = new System.Management.Automation.FunctionInfo( name, function, options, context, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 63934, 63994);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,62501,64038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,62501,64038);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<string, PSDriveInfo> GetDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,64347,64534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,64423,64523);

return _drives ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>>(1354, 64430, 64522)??(_drives = f_1354_64452_64521(f_1354_64488_64520())));
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,64347,64534);

System.StringComparer
f_1354_64488_64520()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 64488, 64520);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_64452_64521(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 64452, 64521);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,64347,64534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,64347,64534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<string, PSDriveInfo> _drives;

private Dictionary<string, PSDriveInfo> GetAutomountedDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,64921,65161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,65008,65150);

return _automountedDrives ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>>(1354, 65015, 65149)??                   (_automountedDrives = f_1354_65079_65148(f_1354_65115_65147())));
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,64921,65161);

System.StringComparer
f_1354_65115_65147()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 65115, 65147);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1354_65079_65148(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 65079, 65148);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,64921,65161);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,64921,65161);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<string, PSDriveInfo> _automountedDrives;

private Dictionary<string, PSVariable> _variables;

private Dictionary<string, PSVariable> GetPrivateVariables()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,65304,65921);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,65389,65876) || true) && (_variables == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,65389,65876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,65525,65607);

_variables = f_1354_65538_65606(f_1354_65573_65605());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,65822,65861);

f_1354_65822_65860(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,65389,65876);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,65892,65910);

return _variables;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,65304,65921);

System.StringComparer
f_1354_65573_65605()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 65573, 65605);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
f_1354_65538_65606(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 65538, 65606);
return return_v;
}


int
f_1354_65822_65860(System.Management.Automation.SessionStateScope
this_param)
{
this_param.AddSessionStateScopeDefaultVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 65822, 65860);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,65304,65921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,65304,65921);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void AddSessionStateScopeDefaultVariables()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,66056,66935);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,66133,66924) || true) && (f_1354_66137_66143()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,66133,66924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,66391,66433);

f_1354_66391_66432(                // Create the default variables that are in every scope
                // These variables will automatically propagate to new
                // scopes since they are marked AllScope.

                _variables, f_1354_66406_66420(s_nullVar), s_nullVar);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,66451,66495);

f_1354_66451_66494(                _variables, f_1354_66466_66481(s_falseVar), s_falseVar);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,66513,66555);

f_1354_66513_66554(                _variables, f_1354_66528_66542(s_trueVar), s_trueVar);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,66133,66924);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,66133,66924);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,66691,66909);
foreach(PSVariable variable in f_1354_66723_66758_I(f_1354_66723_66758(f_1354_66723_66751(f_1354_66723_66729()))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,66691,66909);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,66800,66890) || true) && (f_1354_66804_66823(variable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,66800,66890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,66850,66890);

f_1354_66850_66889(                        _variables, f_1354_66865_66878(variable), variable);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,66800,66890);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,66691,66909);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,219);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,219);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1354,66133,66924);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,66056,66935);

System.Management.Automation.SessionStateScope
f_1354_66137_66143()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66137, 66143);
return return_v;
}


string
f_1354_66406_66420(System.Management.Automation.NullVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66406, 66420);
return return_v;
}


int
f_1354_66391_66432(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param,string
key,System.Management.Automation.NullVariable
value)
{
this_param.Add( key, (System.Management.Automation.PSVariable)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 66391, 66432);
return 0;
}


string
f_1354_66466_66481(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66466, 66481);
return return_v;
}


int
f_1354_66451_66494(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param,string
key,System.Management.Automation.PSVariable
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 66451, 66494);
return 0;
}


string
f_1354_66528_66542(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66528, 66542);
return return_v;
}


int
f_1354_66513_66554(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param,string
key,System.Management.Automation.PSVariable
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 66513, 66554);
return 0;
}


System.Management.Automation.SessionStateScope
f_1354_66723_66729()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66723, 66729);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
f_1354_66723_66751(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetPrivateVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 66723, 66751);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>.ValueCollection
f_1354_66723_66758(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66723, 66758);
return return_v;
}


bool
f_1354_66804_66823(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.IsAllScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66804, 66823);
return return_v;
}


string
f_1354_66865_66878(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 66865, 66878);
return return_v;
}


int
f_1354_66850_66889(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
this_param,string
key,System.Management.Automation.PSVariable
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 66850, 66889);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>.ValueCollection
f_1354_66723_66758_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 66723, 66758);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,66056,66935);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,66056,66935);
}
		}

private Dictionary<string, AliasInfo> GetAliases()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,67253,68033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,67328,67992) || true) && (_alias == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,67328,67992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,67423,67500);

_alias = f_1354_67432_67499(f_1354_67466_67498());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,67520,67977) || true) && (f_1354_67524_67530()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,67520,67977);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,67651,67958);
foreach(AliasInfo newAlias in f_1354_67682_67708_I(f_1354_67682_67708(f_1354_67682_67701(f_1354_67682_67688()))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,67651,67958);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,67758,67935) || true) && ((f_1354_67763_67779(newAlias)& ScopedItemOptions.AllScope) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,67758,67935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,67872,67908);

f_1354_67872_67907(                            _alias, f_1354_67883_67896(newAlias), newAlias);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,67758,67935);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,67651,67958);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,308);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,308);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1354,67520,67977);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,67328,67992);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,68008,68022);

return _alias;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,67253,68033);

System.StringComparer
f_1354_67466_67498()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 67466, 67498);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_67432_67499(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 67432, 67499);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_67524_67530()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 67524, 67530);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_67682_67688()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 67682, 67688);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
f_1354_67682_67701(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.GetAliases();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 67682, 67701);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>.ValueCollection
f_1354_67682_67708(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 67682, 67708);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_67763_67779(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 67763, 67779);
return return_v;
}


string
f_1354_67883_67896(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 67883, 67896);
return return_v;
}


int
f_1354_67872_67907(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
this_param,string
key,System.Management.Automation.AliasInfo
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 67872, 67907);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>.ValueCollection
f_1354_67682_67708_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 67682, 67708);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,67253,68033);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,67253,68033);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<string, AliasInfo> _alias;

private Dictionary<string, FunctionInfo> GetFunctions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,68410,69122);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,68490,69077) || true) && (_functions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,68490,69077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,68593,68677);

_functions = f_1354_68606_68676(f_1354_68643_68675());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,68697,69062) || true) && (f_1354_68701_68707()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 68701, 68752)&&f_1354_68719_68725()._allScopeFunctions != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,68697,69062);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,68867,69043);
foreach(FunctionInfo newFunc in f_1354_68900_68932_I(f_1354_68900_68932(f_1354_68900_68906()._allScopeFunctions)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,68867,69043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,68982,69020);

f_1354_68982_69019(                        _functions, f_1354_68997_69009(newFunc), newFunc);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,68867,69043);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,177);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,177);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1354,68697,69062);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,68490,69077);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,69093,69111);

return _functions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,68410,69122);

System.StringComparer
f_1354_68643_68675()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 68643, 68675);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_68606_68676(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 68606, 68676);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_68701_68707()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 68701, 68707);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_68719_68725()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 68719, 68725);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_68900_68906()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 68900, 68906);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
f_1354_68900_68932(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 68900, 68932);
return return_v;
}


string
f_1354_68997_69009(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 68997, 69009);
return return_v;
}


int
f_1354_68982_69019(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
this_param,string
key,System.Management.Automation.FunctionInfo
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 68982, 69019);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
f_1354_68900_68932_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 68900, 68932);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,68410,69122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,68410,69122);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<string, FunctionInfo> _functions;

private Dictionary<string, FunctionInfo> GetAllScopeFunctions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,69618,70157);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,69706,70104) || true) && (_allScopeFunctions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,69706,70104);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,69770,69919) || true) && (f_1354_69774_69780()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1354, 69774, 69825)&&f_1354_69792_69798()._allScopeFunctions != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,69770,69919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,69867,69900);

return f_1354_69874_69880()._allScopeFunctions;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,69770,69919);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,69997,70089);

_allScopeFunctions = f_1354_70018_70088(f_1354_70055_70087());
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,69706,70104);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,70120,70146);

return _allScopeFunctions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,69618,70157);

System.Management.Automation.SessionStateScope
f_1354_69774_69780()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 69774, 69780);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_69792_69798()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 69792, 69798);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1354_69874_69880()
{
var return_v = Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 69874, 69880);
return return_v;
}


System.StringComparer
f_1354_70055_70087()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 70055, 70087);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
f_1354_70018_70088(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 70018, 70088);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,69618,70157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,69618,70157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<string, FunctionInfo> _allScopeFunctions;

private readonly Dictionary<string, List<CmdletInfo>> _cmdlets ;

private readonly Dictionary<string, List<CmdletInfo>> _allScopeCmdlets ;

private static readonly PSVariable s_trueVar ;

private static readonly PSVariable s_falseVar ;

private static readonly NullVariable s_nullVar ;

private Dictionary<string, List<string>> _commandsToAliasesCache ;

internal IEnumerable<string> GetAliasesByCommandName(string command)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,72933,73348);

var listYield= new List<String>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73026,73057);

List<string> 
commandsToAliases
=default(List<string>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73071,73309) || true) && (f_1354_73075_73142(_commandsToAliasesCache, command, out commandsToAliases))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,73071,73309);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73176,73294);
foreach(string str in f_1354_73199_73216_I(commandsToAliases) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,73176,73294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73258,73275);

listYield.Add(str);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,73176,73294);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1354,1,119);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1354,1,119);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1354,73071,73309);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73325,73337);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,72933,73348);

return listYield;

bool
f_1354_73075_73142(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>
this_param,string
key,out System.Collections.Generic.List<string>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 73075, 73142);
return return_v;
}


System.Collections.Generic.List<string>
f_1354_73199_73216_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 73199, 73216);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,72933,73348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,72933,73348);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void AddAliasToCache(string alias, string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,73491,74099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73572,73601);

List<string> 
existingAliases
=default(List<string>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73615,74088) || true) && (!f_1354_73620_73683(_commandsToAliasesCache, value, out existingAliases))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,73615,74088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73717,73756);

List<string> 
list = f_1354_73737_73755()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73774,73790);

f_1354_73774_73789(                list, alias);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73808,73849);

f_1354_73808_73848(                _commandsToAliasesCache, value, list);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,73615,74088);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,73615,74088);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,73915,74073) || true) && (!f_1354_73920_73985(existingAliases, alias, f_1354_73952_73984()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,73915,74073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74027,74054);

f_1354_74027_74053(                    existingAliases, alias);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,73915,74073);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,73615,74088);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,73491,74099);

bool
f_1354_73620_73683(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>
this_param,string
key,out System.Collections.Generic.List<string>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 73620, 73683);
return return_v;
}


System.Collections.Generic.List<string>
f_1354_73737_73755()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 73737, 73755);
return return_v;
}


int
f_1354_73774_73789(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 73774, 73789);
return 0;
}


int
f_1354_73808_73848(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>
this_param,string
key,System.Collections.Generic.List<string>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 73808, 73848);
return 0;
}


System.StringComparer
f_1354_73952_73984()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 73952, 73984);
return return_v;
}


bool
f_1354_73920_73985(System.Collections.Generic.List<string>
source,string
value,System.StringComparer
comparer)
{
var return_v = source.Contains<string>( value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 73920, 73985);
return return_v;
}


int
f_1354_74027_74053(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 74027, 74053);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,73491,74099);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,73491,74099);
}
		}

private void RemoveAliasFromCache(string alias, string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,74242,74907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74328,74346);

List<string> 
list
=default(List<string>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74360,74473) || true) && (!f_1354_74365_74417(_commandsToAliasesCache, value, out list))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,74360,74473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74451,74458);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,74360,74473);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74489,74896) || true) && (f_1354_74493_74503(list)<= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,74489,74896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74542,74580);

f_1354_74542_74579(                _commandsToAliasesCache, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,74489,74896);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,74489,74896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74646,74752);

string 
itemToRemove = f_1354_74668_74751(list, item => item.Equals(alias, StringComparison.OrdinalIgnoreCase))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74770,74881) || true) && (itemToRemove != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,74770,74881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,74836,74862);

f_1354_74836_74861(                    list, itemToRemove);
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,74770,74881);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,74489,74896);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,74242,74907);

bool
f_1354_74365_74417(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>
this_param,string
key,out System.Collections.Generic.List<string>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 74365, 74417);
return return_v;
}


int
f_1354_74493_74503(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 74493, 74503);
return return_v;
}


bool
f_1354_74542_74579(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 74542, 74579);
return return_v;
}


string
f_1354_74668_74751(System.Collections.Generic.List<string>
source,System.Func<string, bool>
predicate)
{
var return_v = source.FirstOrDefault<string>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 74668, 74751);
return return_v;
}


bool
f_1354_74836_74861(System.Collections.Generic.List<string>
this_param,string
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 74836, 74861);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,74242,74907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,74242,74907);
}
		}

private void CheckVariableChangeInConstrainedLanguage(PSVariable variable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1354,74919,75867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,75018,75075);

var 
context = f_1354_75032_75074()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,75089,75856) || true) && (f_1354_75093_75114_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(context, 1354, 75093, 75114)?.LanguageMode)== PSLanguageMode.ConstrainedLanguage)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,75089,75856);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,75186,75553) || true) && ((f_1354_75191_75207(variable)& ScopedItemOptions.AllScope) == ScopedItemOptions.AllScope)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1354,75186,75553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,75498,75534);

throw f_1354_75504_75533();
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,75186,75553);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,75737,75841);

f_1354_75737_75840(variable, this, f_1354_75813_75839(context));
DynAbs.Tracing.TraceSender.TraceExitCondition(1354,75089,75856);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1354,74919,75867);

System.Management.Automation.ExecutionContext
f_1354_75032_75074()
{
var return_v = LocalPipeline.GetExecutionContextFromTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 75032, 75074);
return return_v;
}


System.Management.Automation.PSLanguageMode?
f_1354_75093_75114_M(System.Management.Automation.PSLanguageMode?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 75093, 75114);
return return_v;
}


System.Management.Automation.ScopedItemOptions
f_1354_75191_75207(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Options ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 75191, 75207);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1354_75504_75533()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 75504, 75533);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1354_75813_75839(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 75813, 75839);
return return_v;
}


int
f_1354_75737_75840(System.Management.Automation.PSVariable
variable,System.Management.Automation.SessionStateScope
scope,System.Management.Automation.SessionStateInternal
sessionState)
{
ExecutionContext.MarkObjectAsUntrustedForVariableAssignment( variable, scope, sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 75737, 75840);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1354,74919,75867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,74919,75867);
}
		}

static SessionStateScope()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1354,489,75896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,71492,71700);
s_trueVar = f_1354_71517_71700(StringLiterals.True, true, ScopedItemOptions.Constant | ScopedItemOptions.AllScope, "Boolean True");DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,71971,72183);
s_falseVar = f_1354_71997_72183(StringLiterals.False, false, ScopedItemOptions.Constant | ScopedItemOptions.AllScope, "Boolean False");DynAbs.Tracing.TraceSender.TraceSimpleStatement(1354,72455,72498);
s_nullVar = f_1354_72480_72498();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1354,489,75896);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1354,489,75896);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1354,489,75896);

System.Management.Automation.SessionStateScope
f_1354_1125_1148(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.ScriptScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 1125, 1148);
return return_v;
}


System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
f_1354_3726_3751()
{
var return_v = new System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 3726, 3751);
return return_v;
}


System.StringComparer
f_1354_70802_70834()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 70802, 70834);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1354_70761_70835(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 70761, 70835);
return return_v;
}


System.StringComparer
f_1354_71189_71221()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 71189, 71221);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
f_1354_71148_71222(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 71148, 71222);
return return_v;
}


static System.Management.Automation.PSVariable
f_1354_71517_71700(string
name,bool
value,System.Management.Automation.ScopedItemOptions
options,string
description)
{
var return_v = new System.Management.Automation.PSVariable( name, (object)value, options, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 71517, 71700);
return return_v;
}


static System.Management.Automation.PSVariable
f_1354_71997_72183(string
name,bool
value,System.Management.Automation.ScopedItemOptions
options,string
description)
{
var return_v = new System.Management.Automation.PSVariable( name, (object)value, options, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 71997, 72183);
return return_v;
}


static System.Management.Automation.NullVariable
f_1354_72480_72498()
{
var return_v = new System.Management.Automation.NullVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 72480, 72498);
return return_v;
}


System.StringComparer
f_1354_72686_72718()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1354, 72686, 72718);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>
f_1354_72649_72719(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1354, 72649, 72719);
return return_v;
}

}
}

