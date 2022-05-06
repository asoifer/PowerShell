// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
internal sealed partial class SessionStateInternal
{
internal Collection<PSObject> GetProperty(
            string[] paths,
            Collection<string> providerSpecificPickList,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,2067,2774);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2252,2371) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,2252,2371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2303,2356);

throw f_1351_2309_2355("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,2252,2371);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2387,2468);

CmdletProviderContext 
context = f_1351_2419_2467(f_1351_2445_2466(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2482,2530);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2546,2600);

f_1351_2546_2599(this, paths, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2616,2653);

f_1351_2616_2652(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2669,2732);

Collection<PSObject> 
results = f_1351_2700_2731(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,2748,2763);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,2067,2774);

System.Management.Automation.PSArgumentNullException
f_1351_2309_2355(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 2309, 2355);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1351_2445_2466(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 2445, 2466);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1351_2419_2467(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 2419, 2467);
return return_v;
}


int
f_1351_2546_2599(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetProperty( paths, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 2546, 2599);
return 0;
}


int
f_1351_2616_2652(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 2616, 2652);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1351_2700_2731(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 2700, 2731);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,2067,2774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,2067,2774);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetProperty(
            string[] paths,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,4438,5700);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,4620,4740) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,4620,4740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,4671,4725);

throw f_1351_4677_4724("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,4620,4740);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,4756,5689);
foreach(string path in f_1351_4780_4785_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,4756,5689);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,4819,4950) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,4819,4950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,4877,4931);

throw f_1351_4883_4930("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,4819,4950);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,4970,4999);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,5017,5056);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,5076,5361);

Collection<string> 
providerPaths =
f_1351_5132_5360(f_1351_5132_5139(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,5381,5674);
foreach(string providerPath in f_1351_5413_5426_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,5381,5674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,5468,5655);

f_1351_5468_5654(this, providerInstance, providerPath, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,5381,5674);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1351,1,294);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1351,1,294);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1351,4756,5689);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1351,1,934);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1351,1,934);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1351,4438,5700);

System.Management.Automation.PSArgumentNullException
f_1351_4677_4724(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 4677, 4724);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1351_4883_4930(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 4883, 4930);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1351_5132_5139()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 5132, 5139);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_5132_5360(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 5132, 5360);
return return_v;
}


int
f_1351_5468_5654(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetPropertyPrivate( providerInstance, path, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 5468, 5654);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1351_5413_5426_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 5413, 5426);
return return_v;
}


string[]
f_1351_4780_4785_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 4780, 4785);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,4438,5700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,4438,5700);
}
		}

private void GetPropertyPrivate(
            CmdletProvider providerInstance,
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,6771,8447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,7070,7224);

f_1351_7070_7223(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,7240,7370);

f_1351_7240_7369(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,7386,7522);

f_1351_7386_7521(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,7574,7644);

f_1351_7574_7643(                providerInstance, path, providerSpecificPickList, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,7673,7756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,7735,7741);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,7673,7756);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,7770,7849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,7828,7834);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,7770,7849);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,7863,7954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,7933,7939);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,7863,7954);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,7968,8054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,8033,8039);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,7968,8054);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,8068,8436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,8156,8421);

throw f_1351_8162_8420(this, "GetPropertyProviderException", f_1351_8268_8316(), f_1351_8339_8368(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,8068,8436);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,6771,8447);

int
f_1351_7070_7223(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 7070, 7223);
return 0;
}


int
f_1351_7240_7369(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 7240, 7369);
return 0;
}


int
f_1351_7386_7521(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 7386, 7521);
return 0;
}


int
f_1351_7574_7643(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.GetProperty( path, providerSpecificPickList, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 7574, 7643);
return 0;
}


string
f_1351_8268_8316()
{
var return_v =                     SessionStateStrings.GetPropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 8268, 8316);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1351_8339_8368(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 8339, 8368);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1351_8162_8420(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 8162, 8420);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,6771,8447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,6771,8447);
}
		}

internal object GetPropertyDynamicParameters(
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,10014,11233);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10212,10289) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,10212,10289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10262,10274);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,10212,10289);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10305,10334);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10348,10387);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10403,10489);

CmdletProviderContext 
newContext =
f_1351_10454_10488(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10503,10635);

f_1351_10503_10634(            newContext, f_1351_10543_10567(), f_1351_10586_10610(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10651,10915);

Collection<string> 
providerPaths =
f_1351_10704_10914(f_1351_10704_10711(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,10931,11194) || true) && (f_1351_10935_10954(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,10931,11194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,11069,11179);

return f_1351_11076_11178(this, providerInstance, f_1351_11123_11139(providerPaths, 0), providerSpecificPickList, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,10931,11194);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,11210,11222);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,10014,11233);

System.Management.Automation.CmdletProviderContext
f_1351_10454_10488(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 10454, 10488);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_10543_10567()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 10543, 10567);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_10586_10610()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 10586, 10610);
return return_v;
}


int
f_1351_10503_10634(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 10503, 10634);
return 0;
}


System.Management.Automation.LocationGlobber
f_1351_10704_10711()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 10704, 10711);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_10704_10914(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 10704, 10914);
return return_v;
}


int
f_1351_10935_10954(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 10935, 10954);
return return_v;
}


string
f_1351_11123_11139(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 11123, 11139);
return return_v;
}


object
f_1351_11076_11178(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetPropertyDynamicParameters( providerInstance, path, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 11076, 11178);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,10014,11233);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,10014,11233);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetPropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,12492,14305);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,12803,12957);

f_1351_12803_12956(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,12973,13103);

f_1351_12973_13102(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13119,13255);

f_1351_13119_13254(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13271,13292);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13342,13438);

result = f_1351_13351_13437(providerInstance, path, providerSpecificPickList, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,13467,13550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13529,13535);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,13467,13550);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,13564,13643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13622,13628);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,13564,13643);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,13657,13743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13722,13728);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,13657,13743);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,13757,13848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13827,13833);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,13757,13848);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,13862,14264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,13950,14249);

throw f_1351_13956_14248(this, "GetPropertyDynamicParametersProviderException", f_1351_14079_14144(), f_1351_14167_14196(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,13862,14264);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,14280,14294);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,12492,14305);

int
f_1351_12803_12956(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 12803, 12956);
return 0;
}


int
f_1351_12973_13102(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 12973, 13102);
return 0;
}


int
f_1351_13119_13254(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 13119, 13254);
return 0;
}


object
f_1351_13351_13437(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.GetPropertyDynamicParameters( path, providerSpecificPickList, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 13351, 13437);
return return_v;
}


string
f_1351_14079_14144()
{
var return_v =                     SessionStateStrings.GetPropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 14079, 14144);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1351_14167_14196(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 14167, 14196);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1351_13956_14248(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 13956, 14248);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,12492,14305);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,12492,14305);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> SetProperty(string[] paths, PSObject property, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,15942,16760);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16073,16193) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,16073,16193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16124,16178);

throw f_1351_16130_16177("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,16073,16193);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16209,16337) || true) && (property == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,16209,16337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16263,16322);

throw f_1351_16269_16321("properties");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,16209,16337);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16353,16434);

CmdletProviderContext 
context = f_1351_16385_16433(f_1351_16411_16432(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16448,16470);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16484,16532);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16548,16586);

f_1351_16548_16585(this, paths, property, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16602,16639);

f_1351_16602_16638(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16655,16718);

Collection<PSObject> 
results = f_1351_16686_16717(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,16734,16749);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,15942,16760);

System.Management.Automation.PSArgumentNullException
f_1351_16130_16177(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 16130, 16177);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1351_16269_16321(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 16269, 16321);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1351_16411_16432(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 16411, 16432);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1351_16385_16433(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 16385, 16433);
return return_v;
}


int
f_1351_16548_16585(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.PSObject
property,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetProperty( paths, property, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 16548, 16585);
return 0;
}


int
f_1351_16602_16638(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 16602, 16638);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1351_16686_16717(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 16686, 16717);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,15942,16760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,15942,16760);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetProperty(
            string[] paths,
            PSObject property,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,18467,19826);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,18623,18743) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,18623,18743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,18674,18728);

throw f_1351_18680_18727("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,18623,18743);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,18759,18885) || true) && (property == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,18759,18885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,18813,18870);

throw f_1351_18819_18869("property");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,18759,18885);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,18901,19815);
foreach(string path in f_1351_18925_18930_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,18901,19815);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,18964,19095) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,18964,19095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,19022,19076);

throw f_1351_19028_19075("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,18964,19095);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,19115,19144);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,19162,19201);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,19221,19506);

Collection<string> 
providerPaths =
f_1351_19277_19505(f_1351_19277_19284(), path, false, context, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,19526,19800) || true) && (providerPaths != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,19526,19800);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,19593,19781);
foreach(string providerPath in f_1351_19625_19638_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,19593,19781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,19688,19758);

f_1351_19688_19757(this, providerInstance, providerPath, property, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,19593,19781);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1351,1,189);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1351,1,189);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1351,19526,19800);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,18901,19815);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1351,1,915);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1351,1,915);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1351,18467,19826);

System.Management.Automation.PSArgumentNullException
f_1351_18680_18727(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 18680, 18727);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1351_18819_18869(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 18819, 18869);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1351_19028_19075(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 19028, 19075);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1351_19277_19284()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 19277, 19284);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_19277_19505(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 19277, 19505);
return return_v;
}


int
f_1351_19688_19757(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.PSObject
property,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetPropertyPrivate( providerInstance, path, property, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 19688, 19757);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1351_19625_19638_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 19625, 19638);
return return_v;
}


string[]
f_1351_18925_18930_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 18925, 18930);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,18467,19826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,18467,19826);
}
		}

private void SetPropertyPrivate(
            CmdletProvider providerInstance,
            string path,
            PSObject property,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,20876,22666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,21149,21303);

f_1351_21149_21302(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,21319,21449);

f_1351_21319_21448(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,21465,21605);

f_1351_21465_21604(property != null, "Caller should validate properties before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,21621,21757);

f_1351_21621_21756(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,21809,21863);

f_1351_21809_21862(                providerInstance, path, property, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,21892,21975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,21954,21960);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,21892,21975);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,21989,22068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,22047,22053);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,21989,22068);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,22082,22168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,22147,22153);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,22082,22168);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,22182,22273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,22252,22258);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,22182,22273);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,22287,22655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,22375,22640);

throw f_1351_22381_22639(this, "SetPropertyProviderException", f_1351_22487_22535(), f_1351_22558_22587(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,22287,22655);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,20876,22666);

int
f_1351_21149_21302(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 21149, 21302);
return 0;
}


int
f_1351_21319_21448(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 21319, 21448);
return 0;
}


int
f_1351_21465_21604(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 21465, 21604);
return 0;
}


int
f_1351_21621_21756(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 21621, 21756);
return 0;
}


int
f_1351_21809_21862(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.PSObject
propertyValue,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.SetProperty( path, propertyValue, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 21809, 21862);
return 0;
}


string
f_1351_22487_22535()
{
var return_v =                     SessionStateStrings.SetPropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 22487, 22535);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1351_22558_22587(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 22558, 22587);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1351_22381_22639(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 22381, 22639);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,20876,22666);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,20876,22666);
}
		}

internal object SetPropertyDynamicParameters(
            string path,
            PSObject propertyValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,24245,25432);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,24422,24499) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,24422,24499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,24472,24484);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,24422,24499);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,24515,24544);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,24558,24597);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,24613,24700);

CmdletProviderContext 
newContext =
f_1351_24665_24699(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,24714,24846);

f_1351_24714_24845(            newContext, f_1351_24754_24778(), f_1351_24797_24821(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,24862,25125);

Collection<string> 
providerPaths =
f_1351_24914_25124(f_1351_24914_24921(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,25141,25393) || true) && (f_1351_25145_25164(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,25141,25393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,25279,25378);

return f_1351_25286_25377(this, providerInstance, f_1351_25333_25349(providerPaths, 0), propertyValue, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,25141,25393);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,25409,25421);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,24245,25432);

System.Management.Automation.CmdletProviderContext
f_1351_24665_24699(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 24665, 24699);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_24754_24778()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 24754, 24778);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_24797_24821()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 24797, 24821);
return return_v;
}


int
f_1351_24714_24845(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 24714, 24845);
return 0;
}


System.Management.Automation.LocationGlobber
f_1351_24914_24921()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 24914, 24921);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_24914_25124(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 24914, 25124);
return return_v;
}


int
f_1351_25145_25164(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 25145, 25164);
return return_v;
}


string
f_1351_25333_25349(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 25333, 25349);
return return_v;
}


object
f_1351_25286_25377(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.PSObject
propertyValue,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.SetPropertyDynamicParameters( providerInstance, path, propertyValue, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 25286, 25377);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,24245,25432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,24245,25432);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object SetPropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            PSObject propertyValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,26678,28459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,26968,27122);

f_1351_26968_27121(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27138,27268);

f_1351_27138_27267(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27284,27420);

f_1351_27284_27419(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27436,27457);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27507,27592);

result = f_1351_27516_27591(providerInstance, path, propertyValue, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,27621,27704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27683,27689);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,27621,27704);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,27718,27797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27776,27782);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,27718,27797);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,27811,27897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27876,27882);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,27811,27897);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,27911,28002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,27981,27987);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,27911,28002);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,28016,28418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,28104,28403);

throw f_1351_28110_28402(this, "SetPropertyDynamicParametersProviderException", f_1351_28233_28298(), f_1351_28321_28350(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,28016,28418);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,28434,28448);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,26678,28459);

int
f_1351_26968_27121(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 26968, 27121);
return 0;
}


int
f_1351_27138_27267(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 27138, 27267);
return 0;
}


int
f_1351_27284_27419(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 27284, 27419);
return 0;
}


object
f_1351_27516_27591(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.PSObject
propertyValue,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.SetPropertyDynamicParameters( path, propertyValue, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 27516, 27591);
return return_v;
}


string
f_1351_28233_28298()
{
var return_v =                     SessionStateStrings.SetPropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 28233, 28298);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1351_28321_28350(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 28321, 28350);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1351_28110_28402(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 28110, 28402);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,26678,28459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,26678,28459);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ClearProperty(
            string[] paths,
            Collection<string> propertyToClear,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,29957,30742);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30144,30264) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,30144,30264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30195,30249);

throw f_1351_30201_30248("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,30144,30264);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30280,30420) || true) && (propertyToClear == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,30280,30420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30341,30405);

throw f_1351_30347_30404("propertyToClear");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,30280,30420);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30436,30517);

CmdletProviderContext 
context = f_1351_30468_30516(f_1351_30494_30515(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30531,30553);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30567,30615);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30631,30678);

f_1351_30631_30677(this, paths, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,30694,30731);

f_1351_30694_30730(
            context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,29957,30742);

System.Management.Automation.PSArgumentNullException
f_1351_30201_30248(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 30201, 30248);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1351_30347_30404(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 30347, 30404);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1351_30494_30515(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 30494, 30515);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1351_30468_30516(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 30468, 30516);
return return_v;
}


int
f_1351_30631_30677(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
propertyToClear,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearProperty( paths, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 30631, 30677);
return 0;
}


int
f_1351_30694_30730(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 30694, 30730);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,29957,30742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,29957,30742);
}
		}

internal void ClearProperty(
            string[] paths,
            Collection<string> propertyToClear,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,32269,33572);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32444,32564) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,32444,32564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32495,32549);

throw f_1351_32501_32548("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,32444,32564);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32580,32720) || true) && (propertyToClear == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,32580,32720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32641,32705);

throw f_1351_32647_32704("propertyToClear");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,32580,32720);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32736,33561);
foreach(string path in f_1351_32760_32765_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,32736,33561);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32799,32930) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,32799,32930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32857,32911);

throw f_1351_32863_32910("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,32799,32930);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32950,32979);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,32997,33036);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,33056,33341);

Collection<string> 
providerPaths =
f_1351_33112_33340(f_1351_33112_33119(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,33361,33546);
foreach(string providerPath in f_1351_33393_33406_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,33361,33546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,33448,33527);

f_1351_33448_33526(this, providerInstance, providerPath, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,33361,33546);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1351,1,186);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1351,1,186);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1351,32736,33561);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1351,1,826);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1351,1,826);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1351,32269,33572);

System.Management.Automation.PSArgumentNullException
f_1351_32501_32548(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 32501, 32548);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1351_32647_32704(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 32647, 32704);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1351_32863_32910(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 32863, 32910);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1351_33112_33119()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 33112, 33119);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_33112_33340(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 33112, 33340);
return return_v;
}


int
f_1351_33448_33526(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Collections.ObjectModel.Collection<string>
propertyToClear,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearPropertyPrivate( providerInstance, path, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 33448, 33526);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1351_33393_33406_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 33393, 33406);
return return_v;
}


string[]
f_1351_32760_32765_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 32760, 32765);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,32269,33572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,32269,33572);
}
		}

private void ClearPropertyPrivate(
            CmdletProvider providerInstance,
            string path,
            Collection<string> propertyToClear,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,34648,36482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,34940,35094);

f_1351_34940_35093(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,35110,35240);

f_1351_35110_35239(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,35256,35408);

f_1351_35256_35407(propertyToClear != null, "Caller should validate propertyToClear before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,35424,35560);

f_1351_35424_35559(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,35612,35675);

f_1351_35612_35674(                providerInstance, path, propertyToClear, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,35704,35787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,35766,35772);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,35704,35787);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,35801,35880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,35859,35865);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,35801,35880);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,35894,35980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,35959,35965);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,35894,35980);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,35994,36085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,36064,36070);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,35994,36085);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,36099,36471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,36187,36456);

throw f_1351_36193_36455(this, "ClearPropertyProviderException", f_1351_36301_36351(), f_1351_36374_36403(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,36099,36471);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,34648,36482);

int
f_1351_34940_35093(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 34940, 35093);
return 0;
}


int
f_1351_35110_35239(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 35110, 35239);
return 0;
}


int
f_1351_35256_35407(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 35256, 35407);
return 0;
}


int
f_1351_35424_35559(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 35424, 35559);
return 0;
}


int
f_1351_35612_35674(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
propertyName,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.ClearProperty( path, propertyName, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 35612, 35674);
return 0;
}


string
f_1351_36301_36351()
{
var return_v =                     SessionStateStrings.ClearPropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 36301, 36351);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1351_36374_36403(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 36374, 36403);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1351_36193_36455(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 36193, 36455);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,34648,36482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,34648,36482);
}
		}

internal object ClearPropertyDynamicParameters(
            string path,
            Collection<string> propertyToClear,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,38035,39240);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38226,38303) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,38226,38303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38276,38288);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,38226,38303);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38319,38348);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38362,38401);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38417,38503);

CmdletProviderContext 
newContext =
f_1351_38468_38502(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38517,38649);

f_1351_38517_38648(            newContext, f_1351_38557_38581(), f_1351_38600_38624(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38665,38929);

Collection<string> 
providerPaths =
f_1351_38718_38928(f_1351_38718_38725(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,38945,39201) || true) && (f_1351_38949_38968(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1351,38945,39201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,39083,39186);

return f_1351_39090_39185(this, providerInstance, f_1351_39139_39155(providerPaths, 0), propertyToClear, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1351,38945,39201);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,39217,39229);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,38035,39240);

System.Management.Automation.CmdletProviderContext
f_1351_38468_38502(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 38468, 38502);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_38557_38581()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 38557, 38581);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_38600_38624()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 38600, 38624);
return return_v;
}


int
f_1351_38517_38648(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 38517, 38648);
return 0;
}


System.Management.Automation.LocationGlobber
f_1351_38718_38725()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 38718, 38725);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1351_38718_38928(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 38718, 38928);
return return_v;
}


int
f_1351_38949_38968(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 38949, 38968);
return return_v;
}


string
f_1351_39139_39155(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 39139, 39155);
return return_v;
}


object
f_1351_39090_39185(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Collections.ObjectModel.Collection<string>
propertyToClear,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ClearPropertyDynamicParameters( providerInstance, path, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 39090, 39185);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,38035,39240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,38035,39240);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object ClearPropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            Collection<string> propertyToClear,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1351,40491,42296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,40795,40949);

f_1351_40795_40948(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,40965,41095);

f_1351_40965_41094(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41111,41247);

f_1351_41111_41246(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41263,41284);

object 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41336,41425);

result = f_1351_41345_41424(providerInstance, path, propertyToClear, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,41454,41537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41516,41522);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,41454,41537);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,41551,41630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41609,41615);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,41551,41630);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,41644,41730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41709,41715);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,41644,41730);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,41744,41835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41814,41820);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,41744,41835);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1351,41849,42255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,41937,42240);

throw f_1351_41943_42239(this, "ClearPropertyDynamicParametersProviderException", f_1351_42068_42135(), f_1351_42158_42187(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1351,41849,42255);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1351,42271,42285);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1351,40491,42296);

int
f_1351_40795_40948(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 40795, 40948);
return 0;
}


int
f_1351_40965_41094(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 40965, 41094);
return 0;
}


int
f_1351_41111_41246(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 41111, 41246);
return 0;
}


object
f_1351_41345_41424(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.ClearPropertyDynamicParameters( path, providerSpecificPickList, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 41345, 41424);
return return_v;
}


string
f_1351_42068_42135()
{
var return_v =                     SessionStateStrings.ClearPropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 42068, 42135);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1351_42158_42187(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1351, 42158, 42187);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1351_41943_42239(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1351, 41943, 42239);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1351,40491,42296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1351,40491,42296);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}

#pragma warning restore 56500

