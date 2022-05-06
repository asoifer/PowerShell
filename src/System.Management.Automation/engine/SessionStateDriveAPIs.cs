// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
internal sealed partial class SessionStateInternal
{
private PSDriveInfo _currentDrive;

internal PSDriveInfo NewDrive(PSDriveInfo drive, string scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,2492,3705);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,2581,2701) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,2581,2701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,2632,2686);

throw f_1345_2638_2685("drive");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,2581,2701);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,2717,2743);

PSDriveInfo 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,2833,2914);

CmdletProviderContext 
context = f_1345_2865_2913(f_1345_2891_2912(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,2930,2964);

f_1345_2930_2963(this, drive, scopeID, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,2980,3017);

f_1345_2980_3016(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,3033,3103);

Collection<PSObject> 
successObjects = f_1345_3071_3102(context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,3119,3664) || true) && (successObjects != null &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 3123, 3190)&&f_1345_3166_3186(successObjects)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,3119,3664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,3224,3384);

f_1345_3224_3383(f_1345_3269_3289(successObjects)== 1, "NewDrive should only add one PSDriveInfo object to the pipeline");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,3488,3649) || true) && (f_1345_3492_3537_M(!f_1345_3493_3510(successObjects, 0).ImmediateBaseObjectIsEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,3488,3649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,3579,3630);

result = (PSDriveInfo)f_1345_3601_3629(f_1345_3601_3618(successObjects, 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,3488,3649);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,3119,3664);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,3680,3694);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,2492,3705);

System.Management.Automation.PSArgumentNullException
f_1345_2638_2685(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 2638, 2685);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_2891_2912(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 2891, 2912);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1345_2865_2913(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 2865, 2913);
return return_v;
}


int
f_1345_2930_2963(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,string
scopeID,System.Management.Automation.CmdletProviderContext
context)
{
this_param.NewDrive( drive, scopeID, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 2930, 2963);
return 0;
}


int
f_1345_2980_3016(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 2980, 3016);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1345_3071_3102(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 3071, 3102);
return return_v;
}


int
f_1345_3166_3186(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 3166, 3186);
return return_v;
}


int
f_1345_3269_3289(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 3269, 3289);
return return_v;
}


int
f_1345_3224_3383(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 3224, 3383);
return 0;
}


System.Management.Automation.PSObject
f_1345_3493_3510(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 3493, 3510);
return return_v;
}


bool
f_1345_3492_3537_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 3492, 3537);
return return_v;
}


System.Management.Automation.PSObject
f_1345_3601_3618(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 3601, 3618);
return return_v;
}


object
f_1345_3601_3629(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 3601, 3629);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,2492,3705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,2492,3705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void NewDrive(PSDriveInfo drive, string scopeID, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,5577,8755);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,5690,5810) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,5690,5810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,5741,5795);

throw f_1345_5747_5794("drive");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,5690,5810);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,5826,5950) || true) && (context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,5826,5950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,5879,5935);

throw f_1345_5885_5934("context");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,5826,5950);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,5966,6267) || true) && (!f_1345_5971_5999(f_1345_5988_5998(drive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,5966,6267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6033,6224);

ArgumentException 
e =
f_1345_6076_6223("drive.Name", f_1345_6176_6222())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6244,6252);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,5966,6267);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6397,6466);

PSDriveInfo 
result = f_1345_6418_6465(this, drive, context, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6590,6664) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,6590,6664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6642,6649);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,6590,6664);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6680,8744) || true) && (f_1345_6684_6766(f_1345_6699_6710(result), f_1345_6712_6722(drive), StringComparison.CurrentCultureIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,6680,8744);
                // Set the drive in the current scope.

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6907,6947);

SessionStateScope 
scope = _currentScope
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,6971,7108) || true) && (!f_1345_6976_7005(scopeID))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,6971,7108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,7055,7085);

scope = f_1345_7063_7084(this, scopeID);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,6971,7108);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,7132,7155);

f_1345_7132_7154(
                    scope, result);
                }
                catch (ArgumentException argumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,7192,7659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,7357,7611);

f_1345_7357_7610(                    // Wrap up the exception and write it to the error stream

                    context, f_1345_7402_7609(argumentException, "NewDriveError", ErrorCategory.InvalidArgument, result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,7633,7640);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,7192,7659);
                }
                catch (SessionStateException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,7677,7844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,7819,7825);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,7677,7844);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,7864,8167) || true) && (f_1345_7868_7912(f_1345_7868_7896(), f_1345_7897_7911(drive))== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,7864,8167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8095,8148);

f_1345_8095_8123()[f_1345_8124_8138(drive)] = drive;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,7864,8167);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8255,8283);

f_1345_8255_8282(
                // Upon success, write the drive to the pipeline

                context, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,6680,8744);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,6680,8744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8349,8701);

ProviderInvocationException 
e =
f_1345_8402_8700(this, "NewDriveProviderFailed", f_1345_8510_8552(), f_1345_8579_8593(drive), f_1345_8620_8630(drive), f_1345_8657_8699("root"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8721,8729);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,6680,8744);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,5577,8755);

System.Management.Automation.PSArgumentNullException
f_1345_5747_5794(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 5747, 5794);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1345_5885_5934(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 5885, 5934);
return return_v;
}


string
f_1345_5988_5998(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 5988, 5998);
return return_v;
}


bool
f_1345_5971_5999(string
name)
{
var return_v = IsValidDriveName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 5971, 5999);
return return_v;
}


string
f_1345_6176_6222()
{
var return_v =                         SessionStateStrings.DriveNameIllegalCharacters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 6176, 6222);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1345_6076_6223(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 6076, 6223);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_6418_6465(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.CmdletProviderContext
context,bool
resolvePathIfPossible)
{
var return_v = this_param.ValidateDriveWithProvider( drive, context, resolvePathIfPossible);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 6418, 6465);
return return_v;
}


string
f_1345_6699_6710(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 6699, 6710);
return return_v;
}


string
f_1345_6712_6722(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 6712, 6722);
return return_v;
}


int
f_1345_6684_6766(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 6684, 6766);
return return_v;
}


bool
f_1345_6976_7005(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 6976, 7005);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_7063_7084(System.Management.Automation.SessionStateInternal
this_param,string
scopeID)
{
var return_v = this_param.GetScopeByID( scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 7063, 7084);
return return_v;
}


int
f_1345_7132_7154(System.Management.Automation.SessionStateScope
this_param,System.Management.Automation.PSDriveInfo
newDrive)
{
this_param.NewDrive( newDrive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 7132, 7154);
return 0;
}


System.Management.Automation.ErrorRecord
f_1345_7402_7609(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.PSDriveInfo
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 7402, 7609);
return return_v;
}


int
f_1345_7357_7610(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 7357, 7610);
return 0;
}


System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
f_1345_7868_7896()
{
var return_v = ProvidersCurrentWorkingDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 7868, 7896);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_7897_7911(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 7897, 7911);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_7868_7912(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.ProviderInfo
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 7868, 7912);
return return_v;
}


System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
f_1345_8095_8123()
{
var return_v = ProvidersCurrentWorkingDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 8095, 8123);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_8124_8138(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 8124, 8138);
return return_v;
}


int
f_1345_8255_8282(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.PSDriveInfo
obj)
{
this_param.WriteObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 8255, 8282);
return 0;
}


string
f_1345_8510_8552()
{
var return_v =                         SessionStateStrings.NewDriveProviderFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 8510, 8552);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_8579_8593(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 8579, 8593);
return return_v;
}


string
f_1345_8620_8630(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 8620, 8630);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1345_8657_8699(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 8657, 8699);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1345_8402_8700(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Management.Automation.PSArgumentException
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, (System.Exception)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 8402, 8700);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,5577,8755);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,5577,8755);
}
		}

private static bool IsValidDriveName(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1345,8767,9296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8841,8860);

bool 
result = true
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,8876,9255);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8911,9045) || true) && (f_1345_8915_8941(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,8911,9045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8983,8998);

result = false;
DynAbs.Tracing.TraceSender.TraceBreak(1345,9020,9026);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,8911,9045);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,9065,9225) || true) && (f_1345_9069_9116(name, s_charactersInvalidInDriveName)>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,9065,9225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,9163,9178);

result = false;
DynAbs.Tracing.TraceSender.TraceBreak(1345,9200,9206);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,9065,9225);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,8876,9255);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,8876,9255) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,8876,9255);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,8876,9255);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,9271,9285);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1345,8767,9296);

bool
f_1345_8915_8941(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 8915, 8941);
return return_v;
}


int
f_1345_9069_9116(string
this_param,char[]
anyOf)
{
var return_v = this_param.IndexOfAny( anyOf);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 9069, 9116);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,8767,9296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,8767,9296);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static char[] s_charactersInvalidInDriveName ;

private string GetProviderRootFromSpecifiedRoot(string root, ProviderInfo provider)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,10064,12855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10172,10284);

f_1345_10172_10283(root != null, "Caller should have verified the root");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10300,10420);

f_1345_10300_10419(provider != null, "Caller should have verified the provider");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10436,10457);

string 
result = root
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10473,10557);

SessionState 
sessionState = f_1345_10501_10556(f_1345_10518_10555(f_1345_10518_10534()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10571,10611);

Collection<string> 
resolvedPaths = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10625,10662);

ProviderInfo 
resolvedProvider = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10781,10898);

resolvedPaths =
f_1345_10818_10897(f_1345_10818_10835(sessionState), root, out resolvedProvider);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,10973,11779) || true) && (resolvedPaths != null &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 10977, 11047)&&f_1345_11023_11042(resolvedPaths)== 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,10973,11779);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,11224,11760) || true) && (f_1345_11228_11274(provider, f_1345_11248_11273(resolvedProvider)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,11224,11760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,11374,11472);

ProviderIntrinsics 
providerIntrinsics =
f_1345_11443_11471(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,11500,11737) || true) && (f_1345_11504_11540(f_1345_11504_11527(providerIntrinsics), root))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,11500,11737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,11684,11710);

result = f_1345_11693_11709(resolvedPaths, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,11500,11737);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,11224,11760);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,10973,11779);
}
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,11808,11887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,11866,11872);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,11808,11887);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,11901,11987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,11966,11972);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,11901,11987);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12001,12092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,12071,12077);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12001,12092);
            }
            // If any of the following exceptions are thrown we assume that
            // the path is a file system path not an MSH path and try
            // to create the drive with that root.
            catch (DriveNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12306,12366);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12306,12366);
            }
            catch (ProviderNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12380,12443);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12380,12443);
            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12457,12516);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12457,12516);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12530,12589);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12530,12589);
            }
            catch (InvalidOperationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12603,12666);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12603,12666);
            }
            catch (ProviderInvocationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12680,12745);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12680,12745);
            }
            catch (ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,12759,12814);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,12759,12814);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,12830,12844);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,10064,12855);

int
f_1345_10172_10283(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 10172, 10283);
return 0;
}


int
f_1345_10300_10419(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 10300, 10419);
return 0;
}


System.Management.Automation.ExecutionContext
f_1345_10518_10534()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 10518, 10534);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1345_10518_10555(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.TopLevelSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 10518, 10555);
return return_v;
}


System.Management.Automation.SessionState
f_1345_10501_10556(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.SessionState( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 10501, 10556);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1345_10818_10835(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 10818, 10835);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1345_10818_10897(System.Management.Automation.PathIntrinsics
this_param,string
path,out System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetResolvedProviderPathFromPSPath( path, out provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 10818, 10897);
return return_v;
}


int
f_1345_11023_11042(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 11023, 11042);
return return_v;
}


string
f_1345_11248_11273(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 11248, 11273);
return return_v;
}


bool
f_1345_11228_11274(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 11228, 11274);
return return_v;
}


System.Management.Automation.ProviderIntrinsics
f_1345_11443_11471(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.ProviderIntrinsics( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 11443, 11471);
return return_v;
}


System.Management.Automation.ItemCmdletProviderIntrinsics
f_1345_11504_11527(System.Management.Automation.ProviderIntrinsics
this_param)
{
var return_v = this_param.Item;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 11504, 11527);
return return_v;
}


bool
f_1345_11504_11540(System.Management.Automation.ItemCmdletProviderIntrinsics
this_param,string
path)
{
var return_v = this_param.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 11504, 11540);
return return_v;
}


string
f_1345_11693_11709(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 11693, 11709);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,10064,12855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,10064,12855);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object NewDriveDynamicParameters(string providerId, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,13774,14845);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,13890,14123) || true) && (providerId == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,13890,14123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,14096,14108);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,13890,14123);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,14139,14207);

DriveCmdletProvider 
provider = f_1345_14170_14206(this, providerId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,14223,14244);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,14294,14347);

result = f_1345_14303_14346(provider, context);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,14376,14804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,14463,14789);

throw
f_1345_14490_14788(this, "NewDriveDynamicParametersProviderException", f_1345_14618_14680(), f_1345_14707_14728(provider), null, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,14376,14804);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,14820,14834);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,13774,14845);

System.Management.Automation.Provider.DriveCmdletProvider
f_1345_14170_14206(System.Management.Automation.SessionStateInternal
this_param,string
providerId)
{
var return_v = this_param.GetDriveProviderInstance( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 14170, 14206);
return return_v;
}


object
f_1345_14303_14346(System.Management.Automation.Provider.DriveCmdletProvider
this_param,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.NewDriveDynamicParameters( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 14303, 14346);
return return_v;
}


string
f_1345_14618_14680()
{
var return_v =                         SessionStateStrings.NewDriveDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 14618, 14680);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_14707_14728(System.Management.Automation.Provider.DriveCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 14707, 14728);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1345_14490_14788(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 14490, 14788);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,13774,14845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,13774,14845);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSDriveInfo GetDrive(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,15511,15617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,15578,15606);

return f_1345_15585_15605(this, name, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,15511,15617);

System.Management.Automation.PSDriveInfo
f_1345_15585_15605(System.Management.Automation.SessionStateInternal
this_param,string
name,bool
automount)
{
var return_v = this_param.GetDrive( name, automount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 15585, 15605);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,15511,15617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,15511,15617);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSDriveInfo GetDrive(string name, bool automount)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,15629,17906);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,15711,15829) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,15711,15829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,15761,15814);

throw f_1345_15767_15813("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,15711,15829);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,15845,15871);

PSDriveInfo 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16027,16119);

SessionStateScopeEnumerator 
scopeEnumerator = f_1345_16073_16118(f_1345_16105_16117())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16135,16151);

int 
scopeID = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16167,17022);
foreach(SessionStateScope processingScope in f_1345_16213_16228_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,16167,17022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16262,16302);

result = f_1345_16271_16301(processingScope, name);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16322,16934) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,16322,16934);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16382,16712) || true) && (f_1345_16386_16406(result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,16382,16712);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16528,16689) || true) && (!f_1345_16533_16590(this, result, processingScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,16528,16689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16648,16662);

result = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,16528,16689);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,16382,16712);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16736,16915) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,16736,16915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16804,16860);

f_1345_16804_16859(                        s_tracer, "Drive found in scope {0}", scopeID);
DynAbs.Tracing.TraceSender.TraceBreak(1345,16886,16892);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,16736,16915);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,16322,16934);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,16997,17007);

++scopeID;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,16167,17022);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,856);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,856);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17038,17521) || true) && (result == null &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 17042, 17069)&&automount))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,17038,17521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17169,17209);

result = f_1345_17178_17208(this, name);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17343,17506) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,17343,17506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17403,17440);

result = f_1345_17412_17439(this, name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,17343,17506);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,17038,17521);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17537,17865) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,17537,17865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17589,17810);

DriveNotFoundException 
driveNotFound =
f_1345_17649_17809(name, "DriveNotFound", f_1345_17775_17808())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17830,17850);

throw driveNotFound;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,17537,17865);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,17881,17895);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,15629,17906);

System.Management.Automation.PSArgumentNullException
f_1345_15767_15813(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 15767, 15813);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_16105_16117()
{
var return_v = CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 16105, 16117);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_16073_16118(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 16073, 16118);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_16271_16301(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 16271, 16301);
return return_v;
}


bool
f_1345_16386_16406(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.IsAutoMounted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 16386, 16406);
return return_v;
}


bool
f_1345_16533_16590(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.SessionStateScope
scope)
{
var return_v = this_param.ValidateOrRemoveAutoMountedDrive( drive, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 16533, 16590);
return return_v;
}


int
f_1345_16804_16859(System.Management.Automation.PSTraceSource
this_param,string
format,int
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 16804, 16859);
return 0;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_16213_16228_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 16213, 16228);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_17178_17208(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.AutomountFileSystemDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 17178, 17208);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_17412_17439(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.AutomountBuiltInDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 17412, 17439);
return return_v;
}


string
f_1345_17775_17808()
{
var return_v =                         SessionStateStrings.DriveNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 17775, 17808);
return return_v;
}


System.Management.Automation.DriveNotFoundException
f_1345_17649_17809(string
itemName,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.DriveNotFoundException( itemName, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 17649, 17809);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,15629,17906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,15629,17906);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSDriveInfo GetDrive(string name, string scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,19173,21527);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19256,19374) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,19256,19374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19306,19359);

throw f_1345_19312_19358("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,19256,19374);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19390,19416);

PSDriveInfo 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19590,21486) || true) && (f_1345_19594_19623(scopeID))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,19590,21486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19657,19770);

SessionStateScopeEnumerator 
scopeEnumerator =
f_1345_19724_19769(f_1345_19756_19768())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19790,20532);
foreach(SessionStateScope scope in f_1345_19826_19841_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,19790,20532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19883,19913);

result = f_1345_19892_19912(scope, name);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,19937,20513) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,19937,20513);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20005,20353) || true) && (f_1345_20009_20029(result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,20005,20353);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20163,20326) || true) && (!f_1345_20168_20215(this, result, scope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,20163,20326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20281,20295);

result = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,20163,20326);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,20005,20353);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20381,20490) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,20381,20490);
DynAbs.Tracing.TraceSender.TraceBreak(1345,20457,20463);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,20381,20490);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,19937,20513);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,19790,20532);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,743);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,743);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20552,20671) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,20552,20671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20612,20652);

result = f_1345_20621_20651(this, name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,20552,20671);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,19590,21486);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,19590,21486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20737,20785);

SessionStateScope 
scope = f_1345_20763_20784(this, scopeID)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20803,20833);

result = f_1345_20812_20832(scope, name);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20853,21471) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,20853,21471);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,20913,21233) || true) && (f_1345_20917_20937(result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,20913,21233);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21059,21210) || true) && (!f_1345_21064_21111(this, result, scope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,21059,21210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21169,21183);

result = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,21059,21210);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,20913,21233);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,20853,21471);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,20853,21471);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21315,21452) || true) && (scope == f_1345_21328_21339())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,21315,21452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21389,21429);

result = f_1345_21398_21428(this, name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,21315,21452);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,20853,21471);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,19590,21486);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21502,21516);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,19173,21527);

System.Management.Automation.PSArgumentNullException
f_1345_19312_19358(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 19312, 19358);
return return_v;
}


bool
f_1345_19594_19623(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 19594, 19623);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_19756_19768()
{
var return_v = CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 19756, 19768);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_19724_19769(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 19724, 19769);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_19892_19912(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 19892, 19912);
return return_v;
}


bool
f_1345_20009_20029(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.IsAutoMounted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 20009, 20029);
return return_v;
}


bool
f_1345_20168_20215(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.SessionStateScope
scope)
{
var return_v = this_param.ValidateOrRemoveAutoMountedDrive( drive, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 20168, 20215);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_19826_19841_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 19826, 19841);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_20621_20651(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.AutomountFileSystemDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 20621, 20651);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_20763_20784(System.Management.Automation.SessionStateInternal
this_param,string
scopeID)
{
var return_v = this_param.GetScopeByID( scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 20763, 20784);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_20812_20832(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 20812, 20832);
return return_v;
}


bool
f_1345_20917_20937(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.IsAutoMounted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 20917, 20937);
return return_v;
}


bool
f_1345_21064_21111(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.SessionStateScope
scope)
{
var return_v = this_param.ValidateOrRemoveAutoMountedDrive( drive, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 21064, 21111);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_21328_21339()
{
var return_v = GlobalScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 21328, 21339);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_21398_21428(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.AutomountFileSystemDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 21398, 21428);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,19173,21527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,19173,21527);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSDriveInfo AutomountFileSystemDrive(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,21539,22898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21621,21647);

PSDriveInfo 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21837,22857) || true) && (f_1345_21841_21852(name)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,21837,22857);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,21935,21997);

System.IO.DriveInfo 
driveInfo = f_1345_21967_21996(name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,22019,22064);

result = f_1345_22028_22063(this, driveInfo);
                }
                catch (LoopFlowException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,22101,22192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,22167,22173);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,22101,22192);
                }
                catch (PipelineStoppedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,22210,22308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,22283,22289);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,22210,22308);
                }
                catch (ActionPreferenceStopException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,22326,22429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,22404,22410);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,22326,22429);
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,22447,22842);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,22447,22842);
                    // Catch all exceptions and continue since the drive does not exist
                    // This action wasn't requested by the user and as such we don't
                    // want to expose the user to any error conditions other than
                    // DriveNotFoundException which will be thrown by the caller
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,21837,22857);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,22873,22887);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,21539,22898);

int
f_1345_21841_21852(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 21841, 21852);
return return_v;
}


System.IO.DriveInfo
f_1345_21967_21996(string
driveName)
{
var return_v = new System.IO.DriveInfo( driveName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 21967, 21996);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_22028_22063(System.Management.Automation.SessionStateInternal
this_param,System.IO.DriveInfo
systemDriveInfo)
{
var return_v = this_param.AutomountFileSystemDrive( systemDriveInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 22028, 22063);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,21539,22898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,21539,22898);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSDriveInfo AutomountFileSystemDrive(System.IO.DriveInfo systemDriveInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,22910,27036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23016,23042);

PSDriveInfo 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23058,23307) || true) && (!f_1345_23063_23127(this, f_1345_23080_23126(f_1345_23080_23115(f_1345_23080_23101(this)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,23058,23307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23161,23262);

f_1345_23161_23261(                s_tracer, "The {0} provider is not loaded", f_1345_23214_23260(f_1345_23214_23249(f_1345_23214_23235(this))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23280,23292);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,23058,23307);
}

            // Since the drive does exist, add it.

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23455,23585);

DriveCmdletProvider 
driveProvider =
f_1345_23512_23584(this, f_1345_23537_23583(f_1345_23537_23572(f_1345_23537_23558(this))))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23605,26181) || true) && (driveProvider != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,23605,26181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23715,23777);

string 
systemDriveName = f_1345_23740_23776(f_1345_23740_23760(systemDriveInfo), 0, 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23799,23833);

string 
volumeLabel = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,23855,23881);

string 
displayRoot = null
;

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,24058,24100);

volumeLabel = f_1345_24072_24099(systemDriveInfo);
                    }
                    catch (UnauthorizedAccessException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,24145,24184);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,24145,24184);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,24281,25081) || true) && (f_1345_24285_24310(systemDriveInfo)== DriveType.Network)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,24281,25081);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,24441,24605);

displayRoot = f_1345_24455_24604(systemDriveInfo);
                        }
                        // We want to get root path of the network drive as extra information to display to the user.
                        // It's okay we failed to get the root path for some reason. We don't want to throw exception
                        // here as it would break the current behavior.
                        catch (Win32Exception) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,24969,24995);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,24969,24995);
}
                        catch (InvalidOperationException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,25021,25058);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,25021,25058);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,24281,25081);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,25105,25467);

PSDriveInfo 
newPSDriveInfo =
f_1345_25159_25466(systemDriveName, f_1345_25251_25277(driveProvider), f_1345_25308_25346(f_1345_25308_25337(systemDriveInfo)), volumeLabel, null, displayRoot)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,25491,25527);

newPSDriveInfo.IsAutoMounted = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,25551,25632);

CmdletProviderContext 
context = f_1345_25583_25631(f_1345_25609_25630(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,25656,25696);

newPSDriveInfo.DriveBeingCreated = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,25781,25863);

result = f_1345_25790_25862(this, driveProvider, newPSDriveInfo, context, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,25887,25928);

newPSDriveInfo.DriveBeingCreated = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,25952,26162) || true) && (result != null &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 25956, 25994)&&!f_1345_25975_25994(context)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,25952,26162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,26110,26139);

f_1345_26110_26138(f_1345_26110_26121(), result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,25952,26162);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,23605,26181);
}
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,26210,26289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,26268,26274);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,26210,26289);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,26303,26389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,26368,26374);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,26303,26389);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,26403,26494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,26473,26479);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,26403,26494);
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,26508,26995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,26773,26980);

f_1345_26773_26979(f_1345_26825_26846(this), f_1345_26869_26915(f_1345_26869_26904(f_1345_26869_26890(this))), e, Severity.Warning);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,26508,26995);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,27011,27025);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,22910,27036);

System.Management.Automation.ExecutionContext
f_1345_23080_23101(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23080, 23101);
return return_v;
}


System.Management.Automation.ProviderNames
f_1345_23080_23115(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23080, 23115);
return return_v;
}


string
f_1345_23080_23126(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23080, 23126);
return return_v;
}


bool
f_1345_23063_23127(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.IsProviderLoaded( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 23063, 23127);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_23214_23235(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23214, 23235);
return return_v;
}


System.Management.Automation.ProviderNames
f_1345_23214_23249(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23214, 23249);
return return_v;
}


string
f_1345_23214_23260(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23214, 23260);
return return_v;
}


int
f_1345_23161_23261(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 23161, 23261);
return 0;
}


System.Management.Automation.ExecutionContext
f_1345_23537_23558(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23537, 23558);
return return_v;
}


System.Management.Automation.ProviderNames
f_1345_23537_23572(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23537, 23572);
return return_v;
}


string
f_1345_23537_23583(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23537, 23583);
return return_v;
}


System.Management.Automation.Provider.DriveCmdletProvider
f_1345_23512_23584(System.Management.Automation.SessionStateInternal
this_param,string
providerId)
{
var return_v = this_param.GetDriveProviderInstance( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 23512, 23584);
return return_v;
}


string
f_1345_23740_23760(System.IO.DriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 23740, 23760);
return return_v;
}


string
f_1345_23740_23776(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 23740, 23776);
return return_v;
}


string
f_1345_24072_24099(System.IO.DriveInfo
this_param)
{
var return_v = this_param.VolumeLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 24072, 24099);
return return_v;
}


System.IO.DriveType
f_1345_24285_24310(System.IO.DriveInfo
this_param)
{
var return_v = this_param.DriveType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 24285, 24310);
return return_v;
}


string
f_1345_24455_24604(System.IO.DriveInfo
driveInfo)
{
var return_v = Microsoft.PowerShell.Commands.FileSystemProvider
                                            .GetRootPathForNetworkDriveOrDosDevice( driveInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 24455, 24604);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_25251_25277(System.Management.Automation.Provider.DriveCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 25251, 25277);
return return_v;
}


System.IO.DirectoryInfo
f_1345_25308_25337(System.IO.DriveInfo
this_param)
{
var return_v = this_param.RootDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 25308, 25337);
return return_v;
}


string
f_1345_25308_25346(System.IO.DirectoryInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 25308, 25346);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_25159_25466(string
name,System.Management.Automation.ProviderInfo
provider,string
root,string
description,System.Management.Automation.PSCredential
credential,string
displayRoot)
{
var return_v = new System.Management.Automation.PSDriveInfo( name, provider, root, description, credential, displayRoot);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 25159, 25466);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_25609_25630(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 25609, 25630);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1345_25583_25631(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 25583, 25631);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_25790_25862(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.DriveCmdletProvider
driveProvider,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.CmdletProviderContext
context,bool
resolvePathIfPossible)
{
var return_v = this_param.ValidateDriveWithProvider( driveProvider, drive, context, resolvePathIfPossible);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 25790, 25862);
return return_v;
}


bool
f_1345_25975_25994(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.HasErrors();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 25975, 25994);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_26110_26121()
{
var return_v = GlobalScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 26110, 26121);
return return_v;
}


int
f_1345_26110_26138(System.Management.Automation.SessionStateScope
this_param,System.Management.Automation.PSDriveInfo
newDrive)
{
this_param.NewDrive( newDrive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 26110, 26138);
return 0;
}


System.Management.Automation.ExecutionContext
f_1345_26825_26846(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 26825, 26846);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_26869_26890(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 26869, 26890);
return return_v;
}


System.Management.Automation.ProviderNames
f_1345_26869_26904(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 26869, 26904);
return return_v;
}


string
f_1345_26869_26915(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 26869, 26915);
return return_v;
}


int
f_1345_26773_26979(System.Management.Automation.ExecutionContext
executionContext,string
providerName,System.Exception
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogProviderHealthEvent( executionContext, providerName, exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 26773, 26979);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,22910,27036);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,22910,27036);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSDriveInfo AutomountBuiltInDrive(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,27242,27462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,27322,27364);

f_1345_27322_27363(name, f_1345_27346_27362());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,27378,27421);

PSDriveInfo 
result = f_1345_27399_27420(this, name, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,27437,27451);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,27242,27462);

System.Management.Automation.ExecutionContext
f_1345_27346_27362()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 27346, 27362);
return return_v;
}


int
f_1345_27322_27363(string
name,System.Management.Automation.ExecutionContext
context)
{
MountDefaultDrive( name, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 27322, 27363);
return 0;
}


System.Management.Automation.PSDriveInfo
f_1345_27399_27420(System.Management.Automation.SessionStateInternal
this_param,string
name,bool
automount)
{
var return_v = this_param.GetDrive( name, automount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 27399, 27420);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,27242,27462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,27242,27462);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void MountDefaultDrive(string name, ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1345,27762,29767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,27875,28096);

PSModuleAutoLoadingPreference 
moduleAutoLoadingPreference =
f_1345_27952_28095(context, SpecialVariables.PSModuleAutoLoadingPreferenceVarPath, "PSModuleAutoLoadingPreference")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,28110,28235) || true) && (moduleAutoLoadingPreference == PSModuleAutoLoadingPreference.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,28110,28235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,28213,28220);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,28110,28235);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,28251,28276);

string 
moduleName = null
;

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,28577,29043) || true) && (f_1345_28599_28662("Cert", name, StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1345, 28599, 28753)||f_1345_28683_28753("Certificate", name, StringComparison.OrdinalIgnoreCase)))
                )

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,28577,29043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,28805,28850);

moduleName = "Microsoft.PowerShell.Security";
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,28577,29043);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,28577,29043);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,28884,29043) || true) && (f_1345_28888_28952("WSMan", name, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,28884,29043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,28986,29028);

moduleName = "Microsoft.WSMan.Management";
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,28884,29043);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,28577,29043);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,29059,29748) || true) && (!f_1345_29064_29096(moduleName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,29059,29748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,29130,29192);

f_1345_29130_29191(                s_tracer, "Auto-mounting built-in drive: {0}", name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,29210,29348);

CommandInfo 
commandInfo = f_1345_29236_29347("Import-Module", typeof(Microsoft.PowerShell.Commands.ImportModuleCommand), null, null, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,29366,29393);

Exception 
exception = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,29411,29476);

f_1345_29411_29475(                s_tracer, "Attempting to load module: {0}", moduleName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,29494,29595);

f_1345_29494_29594(moduleName, context, f_1345_29556_29578(commandInfo), out exception);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,29613,29733) || true) && (exception != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,29613,29733);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,29613,29733);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,29059,29748);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1345,27762,29767);

System.Management.Automation.PSModuleAutoLoadingPreference
f_1345_27952_28095(System.Management.Automation.ExecutionContext
context,System.Management.Automation.VariablePath
variablePath,string
environmentVariable)
{
var return_v = CommandDiscovery.GetCommandDiscoveryPreference( context, variablePath, environmentVariable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 27952, 28095);
return return_v;
}


bool
f_1345_28599_28662(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 28599, 28662);
return return_v;
}


bool
f_1345_28683_28753(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 28683, 28753);
return return_v;
}


bool
f_1345_28888_28952(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 28888, 28952);
return return_v;
}


bool
f_1345_29064_29096(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 29064, 29096);
return return_v;
}


int
f_1345_29130_29191(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 29130, 29191);
return 0;
}


System.Management.Automation.CmdletInfo
f_1345_29236_29347(string
name,System.Type
implementingType,string
helpFile,System.Management.Automation.PSSnapInInfo
PSSnapin,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.CmdletInfo( name, implementingType, helpFile, PSSnapin, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 29236, 29347);
return return_v;
}


int
f_1345_29411_29475(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 29411, 29475);
return 0;
}


System.Management.Automation.SessionStateEntryVisibility
f_1345_29556_29578(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Visibility;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 29556, 29578);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1345_29494_29594(string
moduleName,System.Management.Automation.ExecutionContext
context,System.Management.Automation.SessionStateEntryVisibility
visibility,out System.Exception
exception)
{
var return_v = CommandDiscovery.AutoloadSpecifiedModule( moduleName, context, visibility, out exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 29494, 29594);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,27762,29767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,27762,29767);
}
		}

private bool ValidateOrRemoveAutoMountedDrive(PSDriveInfo drive, SessionStateScope scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,30332,32543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,30446,30465);

bool 
result = true
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,30515,30589);

System.IO.DriveInfo 
systemDriveInfo = f_1345_30553_30588(f_1345_30577_30587(drive))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,30607,30671);

result = f_1345_30616_30641(systemDriveInfo)!= DriveType.NoRootDirectory;
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,30700,30779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,30758,30764);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,30700,30779);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,30793,30879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,30858,30864);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,30793,30879);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,30893,30984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,30963,30969);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,30893,30984);
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,30998,31201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,31171,31186);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,30998,31201);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,31217,32502) || true) && (!result)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,31217,32502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,31262,31303);

DriveCmdletProvider 
driveProvider = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,31367,31481);

driveProvider =
f_1345_31408_31480(this, f_1345_31433_31479(f_1345_31433_31468(f_1345_31433_31454(this))));
                }
                catch (NotSupportedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,31518,31585);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,31518,31585);
                }
                catch (ProviderNotFoundException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,31603,31674);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,31603,31674);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,31694,32487) || true) && (driveProvider != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,31694,32487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,31761,31842);

CmdletProviderContext 
context = f_1345_31793_31841(f_1345_31819_31840(this))
;

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,31984,32026);

f_1345_31984_32025(                        // Give the provider a chance to cleanup
                        driveProvider, drive, context);
                    }
                    // Ignore any exceptions the provider throws because we
                    // are doing this without an explicit request from the
                    // user. Since the provider can throw any exception
                    // we must catch all exceptions here.
                    catch (Exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,32356,32419);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,32356,32419);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,32443,32468);

f_1345_32443_32467(
                    scope, drive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,31694,32487);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,31217,32502);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,32518,32532);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,30332,32543);

string
f_1345_30577_30587(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 30577, 30587);
return return_v;
}


System.IO.DriveInfo
f_1345_30553_30588(string
driveName)
{
var return_v = new System.IO.DriveInfo( driveName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 30553, 30588);
return return_v;
}


System.IO.DriveType
f_1345_30616_30641(System.IO.DriveInfo
this_param)
{
var return_v = this_param.DriveType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 30616, 30641);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_31433_31454(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 31433, 31454);
return return_v;
}


System.Management.Automation.ProviderNames
f_1345_31433_31468(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 31433, 31468);
return return_v;
}


string
f_1345_31433_31479(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 31433, 31479);
return return_v;
}


System.Management.Automation.Provider.DriveCmdletProvider
f_1345_31408_31480(System.Management.Automation.SessionStateInternal
this_param,string
providerId)
{
var return_v = this_param.GetDriveProviderInstance( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 31408, 31480);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_31819_31840(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 31819, 31840);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1345_31793_31841(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 31793, 31841);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_31984_32025(System.Management.Automation.Provider.DriveCmdletProvider
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RemoveDrive( drive, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 31984, 32025);
return return_v;
}


int
f_1345_32443_32467(System.Management.Automation.SessionStateScope
this_param,System.Management.Automation.PSDriveInfo
drive)
{
this_param.RemoveDrive( drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 32443, 32467);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,30332,32543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,30332,32543);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsAStaleVhdMountedDrive(PSDriveInfo drive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,33027,35122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,33107,33127);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,33206,33376) || true) && ((f_1345_33211_33225(drive)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 33210, 33314)&&(!f_1345_33240_33313(f_1345_33240_33254(drive), f_1345_33266_33312(f_1345_33266_33301(f_1345_33266_33287(this)))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,33206,33376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,33348,33361);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,33206,33376);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,34068,35081) || true) && (drive != null &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 34072, 34122)&&!f_1345_34090_34122(f_1345_34111_34121(drive)))&&(DynAbs.Tracing.TraceSender.Expression_True(1345, 34072, 34148)&&f_1345_34126_34143(f_1345_34126_34136(drive))== 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,34068,35081);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,34226,34300);

char 
driveChar = f_1345_34243_34299(f_1345_34258_34268(drive), f_1345_34270_34298())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,34324,34852) || true) && (f_1345_34328_34360(driveChar)>= 'A' &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 34328, 34410)&&f_1345_34371_34403(driveChar)<= 'Z'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,34324,34852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,34460,34514);

DriveInfo 
systemDriveInfo = f_1345_34488_34513(f_1345_34502_34512(drive))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,34542,34829) || true) && (f_1345_34546_34571(systemDriveInfo)== DriveType.NoRootDirectory)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,34542,34829);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,34658,34802) || true) && (!f_1345_34663_34691(f_1345_34680_34690(drive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,34658,34802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,34757,34771);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,34658,34802);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,34542,34829);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,34324,34852);
}
                }
                catch (ArgumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,34889,35066);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,34889,35066);
                    // At this point, We dont care if the drive is not a valid drive that does not host the VHD.
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,34068,35081);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,35097,35111);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,33027,35122);

System.Management.Automation.ProviderInfo
f_1345_33211_33225(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 33211, 33225);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_33240_33254(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 33240, 33254);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_33266_33287(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 33266, 33287);
return return_v;
}


System.Management.Automation.ProviderNames
f_1345_33266_33301(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 33266, 33301);
return return_v;
}


string
f_1345_33266_33312(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 33266, 33312);
return return_v;
}


bool
f_1345_33240_33313(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 33240, 33313);
return return_v;
}


string
f_1345_34111_34121(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34111, 34121);
return return_v;
}


bool
f_1345_34090_34122(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 34090, 34122);
return return_v;
}


string
f_1345_34126_34136(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34126, 34136);
return return_v;
}


int
f_1345_34126_34143(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34126, 34143);
return return_v;
}


string
f_1345_34258_34268(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34258, 34268);
return return_v;
}


System.Globalization.CultureInfo
f_1345_34270_34298()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34270, 34298);
return return_v;
}


char
f_1345_34243_34299(string
value,System.Globalization.CultureInfo
provider)
{
var return_v = Convert.ToChar( value, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 34243, 34299);
return return_v;
}


char
f_1345_34328_34360(char
c)
{
var return_v = char.ToUpperInvariant( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 34328, 34360);
return return_v;
}


char
f_1345_34371_34403(char
c)
{
var return_v = char.ToUpperInvariant( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 34371, 34403);
return return_v;
}


string
f_1345_34502_34512(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34502, 34512);
return return_v;
}


System.IO.DriveInfo
f_1345_34488_34513(string
driveName)
{
var return_v = new System.IO.DriveInfo( driveName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 34488, 34513);
return return_v;
}


System.IO.DriveType
f_1345_34546_34571(System.IO.DriveInfo
this_param)
{
var return_v = this_param.DriveType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34546, 34571);
return return_v;
}


string
f_1345_34680_34690(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 34680, 34690);
return return_v;
}


bool
f_1345_34663_34691(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 34663, 34691);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,33027,35122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,33027,35122);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSDriveInfo> GetDrivesForProvider(string providerId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,35501,36210);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,35598,35703) || true) && (f_1345_35602_35634(providerId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,35598,35703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,35668,35688);

return f_1345_35675_35687(this, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,35598,35703);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,35795,35825);

f_1345_35795_35824(this, providerId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,35841,35904);

Collection<PSDriveInfo> 
drives = f_1345_35874_35903()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,35920,36169);
foreach(PSDriveInfo drive in f_1345_35950_35962_I(f_1345_35950_35962(this, null)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,35920,36169);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,35996,36154) || true) && (drive != null &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 36000, 36075)&&f_1345_36038_36075(f_1345_36038_36052(drive), providerId)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,35996,36154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,36117,36135);

f_1345_36117_36134(                    drives, drive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,35996,36154);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,35920,36169);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,250);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,250);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,36185,36199);

return drives;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,35501,36210);

bool
f_1345_35602_35634(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 35602, 35634);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1345_35675_35687(System.Management.Automation.SessionStateInternal
this_param,string
scope)
{
var return_v = this_param.Drives( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 35675, 35687);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_35795_35824(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.GetSingleProvider( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 35795, 35824);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1345_35874_35903()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 35874, 35903);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1345_35950_35962(System.Management.Automation.SessionStateInternal
this_param,string
scope)
{
var return_v = this_param.Drives( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 35950, 35962);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_36038_36052(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 36038, 36052);
return return_v;
}


bool
f_1345_36038_36075(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 36038, 36075);
return return_v;
}


int
f_1345_36117_36134(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 36117, 36134);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1345_35950_35962_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 35950, 35962);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,35501,36210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,35501,36210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveDrive(string driveName, bool force, string scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,37005,37645);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,37101,37229) || true) && (driveName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,37101,37229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,37156,37214);

throw f_1345_37162_37213("driveName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,37101,37229);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,37245,37294);

PSDriveInfo 
drive = f_1345_37265_37293(this, driveName, scopeID)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,37310,37583) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,37310,37583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,37361,37542);

DriveNotFoundException 
e = f_1345_37388_37541(driveName, "DriveNotFound", f_1345_37507_37540())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,37560,37568);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,37310,37583);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,37599,37634);

f_1345_37599_37633(this, drive, force, scopeID);
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,37005,37645);

System.Management.Automation.PSArgumentNullException
f_1345_37162_37213(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 37162, 37213);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_37265_37293(System.Management.Automation.SessionStateInternal
this_param,string
name,string
scopeID)
{
var return_v = this_param.GetDrive( name, scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 37265, 37293);
return return_v;
}


string
f_1345_37507_37540()
{
var return_v =                     SessionStateStrings.DriveNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 37507, 37540);
return return_v;
}


System.Management.Automation.DriveNotFoundException
f_1345_37388_37541(string
itemName,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.DriveNotFoundException( itemName, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 37388, 37541);
return return_v;
}


int
f_1345_37599_37633(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,bool
force,string
scopeID)
{
this_param.RemoveDrive( drive, force, scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 37599, 37633);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,37005,37645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,37005,37645);
}
		}

internal void RemoveDrive(
            string driveName,
            bool force,
            string scopeID,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,38479,39439);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,38659,38787) || true) && (driveName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,38659,38787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,38714,38772);

throw f_1345_38720_38771("driveName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,38659,38787);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,38803,38918);

f_1345_38803_38917(context != null, "The caller should verify the context");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,38934,38983);

PSDriveInfo 
drive = f_1345_38954_38982(this, driveName, scopeID)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,38999,39428) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,38999,39428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,39050,39231);

DriveNotFoundException 
e = f_1345_39077_39230(driveName, "DriveNotFound", f_1345_39196_39229())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,39249,39303);

f_1345_39249_39302(                context, f_1345_39268_39301(f_1345_39284_39297(e), e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,38999,39428);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,38999,39428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,39369,39413);

f_1345_39369_39412(this, drive, force, scopeID, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,38999,39428);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,38479,39439);

System.Management.Automation.PSArgumentNullException
f_1345_38720_38771(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 38720, 38771);
return return_v;
}


int
f_1345_38803_38917(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 38803, 38917);
return 0;
}


System.Management.Automation.PSDriveInfo
f_1345_38954_38982(System.Management.Automation.SessionStateInternal
this_param,string
name,string
scopeID)
{
var return_v = this_param.GetDrive( name, scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 38954, 38982);
return return_v;
}


string
f_1345_39196_39229()
{
var return_v =                     SessionStateStrings.DriveNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 39196, 39229);
return return_v;
}


System.Management.Automation.DriveNotFoundException
f_1345_39077_39230(string
itemName,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.DriveNotFoundException( itemName, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 39077, 39230);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1345_39284_39297(System.Management.Automation.DriveNotFoundException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 39284, 39297);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1345_39268_39301(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.DriveNotFoundException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 39268, 39301);
return return_v;
}


int
f_1345_39249_39302(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 39249, 39302);
return 0;
}


int
f_1345_39369_39412(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,bool
force,string
scopeID,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveDrive( drive, force, scopeID, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 39369, 39412);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,38479,39439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,38479,39439);
}
		}

internal void RemoveDrive(PSDriveInfo drive, bool force, string scopeID)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,40148,40668);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,40245,40365) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,40245,40365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,40296,40350);

throw f_1345_40302_40349("drive");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,40245,40365);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,40381,40462);

CmdletProviderContext 
context = f_1345_40413_40461(f_1345_40439_40460(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,40478,40522);

f_1345_40478_40521(this, drive, force, scopeID, context);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,40538,40657) || true) && (f_1345_40542_40561(context)&&(DynAbs.Tracing.TraceSender.Expression_True(1345, 40542, 40571)&&!force))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,40538,40657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,40605,40642);

f_1345_40605_40641(                context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,40538,40657);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,40148,40668);

System.Management.Automation.PSArgumentNullException
f_1345_40302_40349(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 40302, 40349);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_40439_40460(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 40439, 40460);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1345_40413_40461(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 40413, 40461);
return return_v;
}


int
f_1345_40478_40521(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,bool
force,string
scopeID,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveDrive( drive, force, scopeID, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 40478, 40521);
return 0;
}


bool
f_1345_40542_40561(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.HasErrors();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 40542, 40561);
return return_v;
}


int
f_1345_40605_40641(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 40605, 40641);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,40148,40668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,40148,40668);
}
		}

internal void RemoveDrive(
            PSDriveInfo drive,
            bool force,
            string scopeID,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,41710,45314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42078,42101);

bool 
canRemove = false
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42153,42196);

canRemove = f_1345_42165_42195(this, drive, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,42225,42304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42283,42289);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,42225,42304);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,42318,42404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42383,42389);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,42318,42404);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,42418,42509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42488,42494);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,42418,42509);
            }
            catch (ProviderInvocationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,42523,42683);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42591,42668) || true) && (!force)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,42591,42668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42643,42649);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,42591,42668);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,42523,42683);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,42790,45303) || true) && (canRemove ||(DynAbs.Tracing.TraceSender.Expression_False(1345, 42794, 42812)||force))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,42790,45303);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43016,44771) || true) && (f_1345_43020_43049(scopeID))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,43016,44771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43091,43208);

SessionStateScopeEnumerator 
scopeEnumerator =
f_1345_43162_43207(f_1345_43194_43206())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43232,44228);
foreach(SessionStateScope scope in f_1345_43268_43283_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,43232,44228);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43393,43441);

PSDriveInfo 
result = f_1345_43414_43440(scope, f_1345_43429_43439(drive))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43471,44073) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,43471,44073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43555,43580);

f_1345_43555_43579(                                scope, drive);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43781,44000) || true) && (f_1345_43785_43829(f_1345_43785_43813(), f_1345_43814_43828(drive))== result)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,43781,44000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,43913,43965);

f_1345_43913_43941()[f_1345_43942_43956(drive)] = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,43781,44000);
}
DynAbs.Tracing.TraceSender.TraceBreak(1345,44036,44042);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,43471,44073);
}
                        }
                        catch (ArgumentException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,44126,44205);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,44126,44205);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,43232,44228);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,997);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,997);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1345,43016,44771);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,43016,44771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,44310,44358);

SessionStateScope 
scope = f_1345_44336_44357(this, scopeID)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,44380,44405);

f_1345_44380_44404(                    scope, drive);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,44570,44752) || true) && (f_1345_44574_44618(f_1345_44574_44602(), f_1345_44603_44617(drive))== drive)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,44570,44752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,44677,44729);

f_1345_44677_44705()[f_1345_44706_44720(drive)] = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,44570,44752);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,43016,44771);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,42790,45303);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,42790,45303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,44837,45141);

PSInvalidOperationException 
e =
                    (PSInvalidOperationException)
f_1345_44941_45140(f_1345_45010_45061(), f_1345_45088_45098(drive), f_1345_45125_45139(drive))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,45161,45288);

f_1345_45161_45287(
                context, f_1345_45202_45286(f_1345_45244_45257(e), e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,42790,45303);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,41710,45314);

bool
f_1345_42165_42195(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.CanRemoveDrive( drive, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 42165, 42195);
return return_v;
}


bool
f_1345_43020_43049(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 43020, 43049);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_43194_43206()
{
var return_v = CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 43194, 43206);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_43162_43207(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 43162, 43207);
return return_v;
}


string
f_1345_43429_43439(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 43429, 43439);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_43414_43440(System.Management.Automation.SessionStateScope
this_param,string
name)
{
var return_v = this_param.GetDrive( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 43414, 43440);
return return_v;
}


int
f_1345_43555_43579(System.Management.Automation.SessionStateScope
this_param,System.Management.Automation.PSDriveInfo
drive)
{
this_param.RemoveDrive( drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 43555, 43579);
return 0;
}


System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
f_1345_43785_43813()
{
var return_v = ProvidersCurrentWorkingDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 43785, 43813);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_43814_43828(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 43814, 43828);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_43785_43829(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.ProviderInfo
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 43785, 43829);
return return_v;
}


System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
f_1345_43913_43941()
{
var return_v = ProvidersCurrentWorkingDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 43913, 43941);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_43942_43956(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 43942, 43956);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_43268_43283_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 43268, 43283);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_44336_44357(System.Management.Automation.SessionStateInternal
this_param,string
scopeID)
{
var return_v = this_param.GetScopeByID( scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 44336, 44357);
return return_v;
}


int
f_1345_44380_44404(System.Management.Automation.SessionStateScope
this_param,System.Management.Automation.PSDriveInfo
drive)
{
this_param.RemoveDrive( drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 44380, 44404);
return 0;
}


System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
f_1345_44574_44602()
{
var return_v = ProvidersCurrentWorkingDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 44574, 44602);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_44603_44617(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 44603, 44617);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_44574_44618(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.ProviderInfo
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 44574, 44618);
return return_v;
}


System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
f_1345_44677_44705()
{
var return_v = ProvidersCurrentWorkingDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 44677, 44705);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_44706_44720(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 44706, 44720);
return return_v;
}


string
f_1345_45010_45061()
{
var return_v =                         SessionStateStrings.DriveRemovalPreventedByProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 45010, 45061);
return return_v;
}


string
f_1345_45088_45098(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 45088, 45098);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_45125_45139(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 45125, 45139);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1345_44941_45140(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 44941, 45140);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1345_45244_45257(System.Management.Automation.PSInvalidOperationException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 45244, 45257);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1345_45202_45286(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSInvalidOperationException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 45202, 45286);
return return_v;
}


int
f_1345_45161_45287(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 45161, 45287);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,41710,45314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,41710,45314);
}
		}

private bool CanRemoveDrive(PSDriveInfo drive, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,46130,48160);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46232,46356) || true) && (context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,46232,46356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46285,46341);

throw f_1345_46291_46340("context");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,46232,46356);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46372,46492) || true) && (drive == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,46372,46492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46423,46477);

throw f_1345_46429_46476("drive");
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,46372,46492);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46508,46559);

f_1345_46508_46558(
            s_tracer, "Drive name = {0}", f_1345_46547_46557(drive));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46618,46640);

context.Drive = drive;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46727,46827);

DriveCmdletProvider 
driveCmdletProvider =
f_1345_46786_46826(this, f_1345_46811_46825(drive))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46843,46871);

bool 
driveRemovable = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46887,46913);

PSDriveInfo 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,46965,47022);

result = f_1345_46974_47021(driveCmdletProvider, drive, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,47051,47130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,47109,47115);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,47051,47130);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,47144,47230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,47209,47215);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,47144,47230);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,47244,47335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,47314,47320);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,47244,47335);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,47349,47719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,47436,47704);

throw f_1345_47442_47703(this, "RemoveDriveProviderException", f_1345_47548_47596(), f_1345_47619_47651(driveCmdletProvider), null, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,47349,47719);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,47735,48111) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,47735,48111);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,47922,48096) || true) && (f_1345_47926_48008(f_1345_47941_47952(result), f_1345_47954_47964(drive), StringComparison.CurrentCultureIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,47922,48096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,48055,48077);

driveRemovable = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,47922,48096);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,47735,48111);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,48127,48149);

return driveRemovable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,46130,48160);

System.Management.Automation.PSArgumentNullException
f_1345_46291_46340(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 46291, 46340);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1345_46429_46476(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 46429, 46476);
return return_v;
}


string
f_1345_46547_46557(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 46547, 46557);
return return_v;
}


int
f_1345_46508_46558(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 46508, 46558);
return 0;
}


System.Management.Automation.ProviderInfo
f_1345_46811_46825(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 46811, 46825);
return return_v;
}


System.Management.Automation.Provider.DriveCmdletProvider
f_1345_46786_46826(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetDriveProviderInstance( provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 46786, 46826);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_46974_47021(System.Management.Automation.Provider.DriveCmdletProvider
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RemoveDrive( drive, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 46974, 47021);
return return_v;
}


string
f_1345_47548_47596()
{
var return_v =                     SessionStateStrings.RemoveDriveProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 47548, 47596);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1345_47619_47651(System.Management.Automation.Provider.DriveCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 47619, 47651);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1345_47442_47703(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 47442, 47703);
return return_v;
}


string
f_1345_47941_47952(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 47941, 47952);
return return_v;
}


string
f_1345_47954_47964(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 47954, 47964);
return return_v;
}


int
f_1345_47926_48008(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 47926, 48008);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,46130,48160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,46130,48160);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSDriveInfo> Drives(string scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,48999,52779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49077,49160);

Dictionary<string, PSDriveInfo> 
driveTable = f_1345_49122_49159()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49176,49224);

SessionStateScope 
startingScope = _currentScope
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49240,49357) || true) && (!f_1345_49245_49272(scope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,49240,49357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49306,49342);

startingScope = f_1345_49322_49341(this, scope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,49240,49357);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49373,49483);

SessionStateScopeEnumerator 
scopeEnumerator =
f_1345_49436_49482(startingScope)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49497,49543);

DriveInfo[] 
alldrives = f_1345_49521_49542()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49557,49614);

Collection<string> 
driveNames = f_1345_49589_49613()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49628,49757);
foreach(DriveInfo drive in f_1345_49656_49665_I(alldrives) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,49628,49757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49699,49742);

f_1345_49699_49741(                driveNames, f_1345_49714_49740(f_1345_49714_49724(drive), 0, 1));
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,49628,49757);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,130);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,130);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49773,51316);
foreach(SessionStateScope lookupScope in f_1345_49815_49830_I(scopeEnumerator) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,49773,51316);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,49864,51067);
foreach(PSDriveInfo drive in f_1345_49894_49912_I(f_1345_49894_49912(lookupScope)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,49864,51067);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50129,51048) || true) && (drive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,50129,51048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50196,50221);

bool 
driveIsValid = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50368,50578) || true) && (f_1345_50372_50391(drive)||(DynAbs.Tracing.TraceSender.Expression_False(1345, 50372, 50425)||f_1345_50395_50425(this, drive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,50368,50578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50483,50551);

driveIsValid = f_1345_50498_50550(this, drive, lookupScope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,50368,50578);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50612,50826) || true) && (f_1345_50616_50633(f_1345_50616_50626(drive))== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,50612,50826);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50696,50799) || true) && (!(f_1345_50702_50733(driveNames, f_1345_50722_50732(drive))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,50696,50799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50769,50799);

f_1345_50769_50798(                                driveTable, f_1345_50787_50797(drive));
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,50696,50799);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,50612,50826);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50854,51025) || true) && (driveIsValid &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 50858, 50909)&&!f_1345_50875_50909(driveTable, f_1345_50898_50908(drive))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,50854,51025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,50967,50998);

driveTable[f_1345_50978_50988(drive)] = drive;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,50854,51025);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,50129,51048);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,49864,51067);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,1204);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,1204);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,51197,51301) || true) && (scope != null &&(DynAbs.Tracing.TraceSender.Expression_True(1345, 51201, 51234)&&f_1345_51218_51230(scope)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,51197,51301);
DynAbs.Tracing.TraceSender.TraceBreak(1345,51276,51282);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,51197,51301);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,49773,51316);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,1544);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,1544);
}
            // Now lookup all the file system drives and automount any that are not
            // present

            try
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,51479,52171);
foreach(System.IO.DriveInfo fsDriveInfo in f_1345_51523_51532_I(alldrives) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,51479,52171);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,51574,52152) || true) && (fsDriveInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,51574,52152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,51647,51701);

string 
fsDriveName = f_1345_51668_51700(f_1345_51668_51684(fsDriveInfo), 0, 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,51727,52129) || true) && (!f_1345_51732_51767(driveTable, fsDriveName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,51727,52129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,51825,51894);

PSDriveInfo 
automountedDrive = f_1345_51856_51893(this, fsDriveInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,51924,52102) || true) && (automountedDrive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,51924,52102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,52018,52071);

driveTable[f_1345_52029_52050(automountedDrive)] = automountedDrive;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,51924,52102);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,51727,52129);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,51574,52152);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,51479,52171);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,693);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,693);
}            }
            // We don't want to have automounting cause an exception. We
            // rather it just fail silently as it wasn't a result of an
            // explicit request by the user anyway.
            catch (IOException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,52400,52449);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,52400,52449);
            }
            catch (UnauthorizedAccessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1345,52463,52528);
DynAbs.Tracing.TraceSender.TraceExitCatch(1345,52463,52528);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,52544,52608);

Collection<PSDriveInfo> 
results = f_1345_52578_52607()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,52622,52737);
foreach(PSDriveInfo drive in f_1345_52652_52669_I(f_1345_52652_52669(driveTable)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,52622,52737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,52703,52722);

f_1345_52703_52721(                results, drive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,52622,52737);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1345,1,116);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1345,1,116);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,52753,52768);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,48999,52779);

System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
f_1345_49122_49159()
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49122, 49159);
return return_v;
}


bool
f_1345_49245_49272(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49245, 49272);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1345_49322_49341(System.Management.Automation.SessionStateInternal
this_param,string
scopeID)
{
var return_v = this_param.GetScopeByID( scopeID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49322, 49341);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_49436_49482(System.Management.Automation.SessionStateScope
scope)
{
var return_v = new System.Management.Automation.SessionStateScopeEnumerator( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49436, 49482);
return return_v;
}


System.IO.DriveInfo[]
f_1345_49521_49542()
{
var return_v = DriveInfo.GetDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49521, 49542);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1345_49589_49613()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49589, 49613);
return return_v;
}


string
f_1345_49714_49724(System.IO.DriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 49714, 49724);
return return_v;
}


string
f_1345_49714_49740(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49714, 49740);
return return_v;
}


int
f_1345_49699_49741(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49699, 49741);
return 0;
}


System.IO.DriveInfo[]
f_1345_49656_49665_I(System.IO.DriveInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49656, 49665);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.PSDriveInfo>
f_1345_49894_49912(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.Drives;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 49894, 49912);
return return_v;
}


bool
f_1345_50372_50391(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.IsAutoMounted ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 50372, 50391);
return return_v;
}


bool
f_1345_50395_50425(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.IsAStaleVhdMountedDrive( drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 50395, 50425);
return return_v;
}


bool
f_1345_50498_50550(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.SessionStateScope
scope)
{
var return_v = this_param.ValidateOrRemoveAutoMountedDrive( drive, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 50498, 50550);
return return_v;
}


string
f_1345_50616_50626(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 50616, 50626);
return return_v;
}


int
f_1345_50616_50633(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 50616, 50633);
return return_v;
}


string
f_1345_50722_50732(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 50722, 50732);
return return_v;
}


bool
f_1345_50702_50733(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 50702, 50733);
return return_v;
}


string
f_1345_50787_50797(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 50787, 50797);
return return_v;
}


bool
f_1345_50769_50798(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 50769, 50798);
return return_v;
}


string
f_1345_50898_50908(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 50898, 50908);
return return_v;
}


bool
f_1345_50875_50909(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 50875, 50909);
return return_v;
}


string
f_1345_50978_50988(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 50978, 50988);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.PSDriveInfo>
f_1345_49894_49912_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSDriveInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49894, 49912);
return return_v;
}


int
f_1345_51218_51230(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 51218, 51230);
return return_v;
}


System.Management.Automation.SessionStateScopeEnumerator
f_1345_49815_49830_I(System.Management.Automation.SessionStateScopeEnumerator
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 49815, 49830);
return return_v;
}


string
f_1345_51668_51684(System.IO.DriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 51668, 51684);
return return_v;
}


string
f_1345_51668_51700(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 51668, 51700);
return return_v;
}


bool
f_1345_51732_51767(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 51732, 51767);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_51856_51893(System.Management.Automation.SessionStateInternal
this_param,System.IO.DriveInfo
systemDriveInfo)
{
var return_v = this_param.AutomountFileSystemDrive( systemDriveInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 51856, 51893);
return return_v;
}


string
f_1345_52029_52050(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 52029, 52050);
return return_v;
}


System.IO.DriveInfo[]
f_1345_51523_51532_I(System.IO.DriveInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 51523, 51532);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1345_52578_52607()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 52578, 52607);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
f_1345_52652_52669(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 52652, 52669);
return return_v;
}


int
f_1345_52703_52721(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 52703, 52721);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
f_1345_52652_52669_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSDriveInfo>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1345, 52652, 52669);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,48999,52779);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,48999,52779);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSDriveInfo CurrentDrive
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,52978,53224);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,53014,53209) || true) && (this != f_1345_53026_53063(f_1345_53026_53042()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,53014,53209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,53086,53144);

return f_1345_53093_53143(f_1345_53093_53130(f_1345_53093_53109()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,53014,53209);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,53014,53209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,53188,53209);

return _currentDrive;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,53014,53209);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,52978,53224);

System.Management.Automation.ExecutionContext
f_1345_53026_53042()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53026, 53042);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1345_53026_53063(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.TopLevelSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53026, 53063);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_53093_53109()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53093, 53109);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1345_53093_53130(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.TopLevelSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53093, 53130);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1345_53093_53143(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53093, 53143);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,52920,53499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,52920,53499);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1345,53240,53488);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,53276,53473) || true) && (this != f_1345_53288_53325(f_1345_53288_53304()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,53276,53473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,53348,53407);

f_1345_53348_53385(f_1345_53348_53364()).CurrentDrive = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,53276,53473);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1345,53276,53473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345,53451,53473);

_currentDrive = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1345,53276,53473);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1345,53240,53488);

System.Management.Automation.ExecutionContext
f_1345_53288_53304()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53288, 53304);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1345_53288_53325(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.TopLevelSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53288, 53325);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1345_53348_53364()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53348, 53364);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1345_53348_53385(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.TopLevelSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1345, 53348, 53385);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1345,52920,53499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1345,52920,53499);
}
		}}
}
}

#pragma warning restore 56500

