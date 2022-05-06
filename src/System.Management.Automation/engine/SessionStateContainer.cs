// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using System.Management.Automation.Runspaces;
using System.Reflection;

using Dbg = System.Management.Automation;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
internal sealed partial class SessionStateInternal
{
internal bool ItemExists(string path, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,2193,2748);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2285,2403) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,2285,2403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2335,2388);

throw f_1343_2341_2387("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,2285,2403);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2419,2500);

CmdletProviderContext 
context = f_1343_2451_2499(f_1343_2477_2498(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2514,2536);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2550,2598);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2614,2654);

bool 
result = f_1343_2628_2653(this, path, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2670,2707);

f_1343_2670_2706(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,2723,2737);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,2193,2748);

System.Management.Automation.PSArgumentNullException
f_1343_2341_2387(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 2341, 2387);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_2477_2498(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 2477, 2498);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_2451_2499(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 2451, 2499);
return return_v;
}


bool
f_1343_2628_2653(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExists( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 2628, 2653);
return return_v;
}


int
f_1343_2670_2706(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 2670, 2706);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,2193,2748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,2193,2748);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ItemExists(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,4037,5211);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4157,4275) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,4157,4275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4207,4260);

throw f_1343_4213_4259("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,4157,4275);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4291,4320);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4334,4373);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4389,4409);

bool 
result = false
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4459,4743);

Collection<string> 
providerPaths =
f_1343_4515_4742(f_1343_4515_4522(), path, true, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4763,5049);
foreach(string providerPath in f_1343_4795_4808_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,4763,5049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4850,4911);

result = f_1343_4859_4910(this, providerInstance, providerPath, context);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,4933,5030) || true) && (result == true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,4933,5030);
DynAbs.Tracing.TraceSender.TraceBreak(1343,5001,5007);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,4933,5030);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,4763,5049);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,287);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,287);
}            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,5078,5170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,5140,5155);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,5078,5170);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,5186,5200);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,4037,5211);

System.Management.Automation.PSArgumentNullException
f_1343_4213_4259(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 4213, 4259);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_4515_4522()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 4515, 4522);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_4515_4742(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 4515, 4742);
return return_v;
}


bool
f_1343_4859_4910(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExists( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 4859, 4910);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_4795_4808_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 4795, 4808);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,4037,5211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,4037,5211);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ItemExists(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,6156,7829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,6390,6538);

f_1343_6390_6537(providerInstance != null, "Caller should validate providerId before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,6554,6684);

f_1343_6554_6683(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,6700,6836);

f_1343_6700_6835(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,6852,6951);

ItemCmdletProvider 
itemCmdletProvider =
f_1343_6909_6950(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,6967,6987);

bool 
result = false
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,7039,7093);

result = f_1343_7048_7092(itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,7122,7201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,7180,7186);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,7122,7201);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,7215,7301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,7280,7286);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,7215,7301);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,7315,7406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,7385,7391);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,7315,7406);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,7420,7788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,7508,7773);

throw f_1343_7514_7772(this, "ItemExistsProviderException", f_1343_7619_7666(), f_1343_7689_7720(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,7420,7788);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,7804,7818);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,6156,7829);

int
f_1343_6390_6537(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 6390, 6537);
return 0;
}


int
f_1343_6554_6683(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 6554, 6683);
return 0;
}


int
f_1343_6700_6835(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 6700, 6835);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1343_6909_6950(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 6909, 6950);
return return_v;
}


bool
f_1343_7048_7092(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExists( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 7048, 7092);
return return_v;
}


string
f_1343_7619_7666()
{
var return_v =                     SessionStateStrings.ItemExistsProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 7619, 7666);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_7689_7720(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 7689, 7720);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_7514_7772(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 7514, 7772);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,6156,7829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,6156,7829);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object ItemExistsDynamicParameters(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,9372,10519);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,9484,9602) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,9484,9602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,9534,9587);

throw f_1343_9540_9586("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,9484,9602);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,9618,9647);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,9661,9700);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,9716,9803);

CmdletProviderContext 
newContext =
f_1343_9768_9802(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,9817,9949);

f_1343_9817_9948(            newContext, f_1343_9857_9881(), f_1343_9900_9924(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,9965,10228);

Collection<string> 
providerPaths =
f_1343_10017_10227(f_1343_10017_10024(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,10244,10480) || true) && (f_1343_10248_10267(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,10244,10480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,10382,10465);

return f_1343_10389_10464(this, providerInstance, f_1343_10435_10451(providerPaths, 0), newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,10244,10480);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,10496,10508);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,9372,10519);

System.Management.Automation.PSArgumentNullException
f_1343_9540_9586(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 9540, 9586);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_9768_9802(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 9768, 9802);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_9857_9881()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 9857, 9881);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_9900_9924()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 9900, 9924);
return return_v;
}


int
f_1343_9817_9948(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 9817, 9948);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_10017_10024()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 10017, 10024);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_10017_10227(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 10017, 10227);
return return_v;
}


int
f_1343_10248_10267(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 10248, 10267);
return return_v;
}


string
f_1343_10435_10451(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 10435, 10451);
return return_v;
}


object
f_1343_10389_10464(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExistsDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 10389, 10464);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,9372,10519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,9372,10519);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object ItemExistsDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,11647,13419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,11899,12053);

f_1343_11899_12052(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12069,12199);

f_1343_12069_12198(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12215,12351);

f_1343_12215_12350(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12367,12481);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_12434_12480(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12497,12518);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12568,12644);

result = f_1343_12577_12643(containerCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,12673,12752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12731,12737);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,12673,12752);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,12766,12852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12831,12837);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,12766,12852);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,12866,12957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,12936,12942);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,12866,12957);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,12971,13378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,13059,13363);

throw f_1343_13065_13362(this, "ItemExistsDynamicParametersProviderException", f_1343_13187_13251(), f_1343_13274_13310(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,12971,13378);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,13394,13408);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,11647,13419);

int
f_1343_11899_12052(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 11899, 12052);
return 0;
}


int
f_1343_12069_12198(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 12069, 12198);
return 0;
}


int
f_1343_12215_12350(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 12215, 12350);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_12434_12480(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 12434, 12480);
return return_v;
}


object
f_1343_12577_12643(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExistsDynamicParameters( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 12577, 12643);
return return_v;
}


string
f_1343_13187_13251()
{
var return_v =                     SessionStateStrings.ItemExistsDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 13187, 13251);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_13274_13310(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 13274, 13310);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_13065_13362(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 13065, 13362);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,11647,13419);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,11647,13419);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsValidPath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,14692,15121);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,14755,14873) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,14755,14873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,14805,14858);

throw f_1343_14811_14857("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,14755,14873);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,14889,14970);

CmdletProviderContext 
context = f_1343_14921_14969(f_1343_14947_14968(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,14986,15027);

bool 
result = f_1343_15000_15026(this, path, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,15043,15080);

f_1343_15043_15079(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,15096,15110);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,14692,15121);

System.Management.Automation.PSArgumentNullException
f_1343_14811_14857(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 14811, 14857);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_14947_14968(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 14947, 14968);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_14921_14969(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 14921, 14969);
return return_v;
}


bool
f_1343_15000_15026(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsValidPath( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 15000, 15026);
return return_v;
}


int
f_1343_15043_15079(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 15043, 15079);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,14692,15121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,14692,15121);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsValidPath(
             string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,16452,17163);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,16574,16692) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,16574,16692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,16624,16677);

throw f_1343_16630_16676("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,16574,16692);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,16708,16737);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,16751,16780);

PSDriveInfo 
driveInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,16796,16988);

string 
providerPath =
f_1343_16835_16987(f_1343_16835_16842(), path, context, out provider, out driveInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,17004,17076);

ItemCmdletProvider 
providerInstance = f_1343_17042_17075(this, provider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,17092,17152);

return f_1343_17099_17151(this, providerInstance, providerPath, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,16452,17163);

System.Management.Automation.PSArgumentNullException
f_1343_16630_16676(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 16630, 16676);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_16835_16842()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 16835, 16842);
return return_v;
}


string
f_1343_16835_16987(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 16835, 16987);
return return_v;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1343_17042_17075(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetItemProviderInstance( provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 17042, 17075);
return return_v;
}


bool
f_1343_17099_17151(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ItemCmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsValidPath( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 17099, 17151);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,16452,17163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,16452,17163);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsValidPath(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,18098,19780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,18332,18486);

f_1343_18332_18485(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,18502,18632);

f_1343_18502_18631(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,18648,18784);

f_1343_18648_18783(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,18800,18899);

ItemCmdletProvider 
itemCmdletProvider =
f_1343_18857_18898(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,18915,18935);

bool 
result = false
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,18987,19042);

result = f_1343_18996_19041(itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,19071,19150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,19129,19135);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,19071,19150);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,19164,19250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,19229,19235);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,19164,19250);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,19264,19355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,19334,19340);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,19264,19355);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,19369,19739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,19457,19724);

throw f_1343_19463_19723(this, "IsValidPathProviderException", f_1343_19569_19617(), f_1343_19640_19671(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,19369,19739);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,19755,19769);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,18098,19780);

int
f_1343_18332_18485(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 18332, 18485);
return 0;
}


int
f_1343_18502_18631(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 18502, 18631);
return 0;
}


int
f_1343_18648_18783(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 18648, 18783);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1343_18857_18898(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 18857, 18898);
return return_v;
}


bool
f_1343_18996_19041(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsValidPath( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 18996, 19041);
return return_v;
}


string
f_1343_19569_19617()
{
var return_v =                     SessionStateStrings.IsValidPathProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 19569, 19617);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_19640_19671(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 19640, 19671);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_19463_19723(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 19463, 19723);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,18098,19780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,18098,19780);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsItemContainer(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,21044,21481);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,21111,21229) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,21111,21229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,21161,21214);

throw f_1343_21167_21213("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,21111,21229);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,21245,21326);

CmdletProviderContext 
context = f_1343_21277_21325(f_1343_21303_21324(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,21342,21387);

bool 
result = f_1343_21356_21386(this, path, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,21403,21440);

f_1343_21403_21439(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,21456,21470);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,21044,21481);

System.Management.Automation.PSArgumentNullException
f_1343_21167_21213(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 21167, 21213);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_21303_21324(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 21303, 21324);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_21277_21325(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 21277, 21325);
return return_v;
}


bool
f_1343_21356_21386(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 21356, 21386);
return return_v;
}


int
f_1343_21403_21439(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 21403, 21439);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,21044,21481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,21044,21481);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsItemContainer(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,22794,23979);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,22919,23037) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,22919,23037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,22969,23022);

throw f_1343_22975_23021("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,22919,23037);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23053,23082);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23096,23135);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23151,23171);

bool 
result = false
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23221,23505);

Collection<string> 
providerPaths =
f_1343_23277_23504(f_1343_23277_23284(), path, true, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23525,23817);
foreach(string providerPath in f_1343_23557_23570_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,23525,23817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23612,23678);

result = f_1343_23621_23677(this, providerInstance, providerPath, context);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23700,23798) || true) && (result == false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,23700,23798);
DynAbs.Tracing.TraceSender.TraceBreak(1343,23769,23775);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,23700,23798);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,23525,23817);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,293);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,293);
}            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,23846,23938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23908,23923);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,23846,23938);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,23954,23968);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,22794,23979);

System.Management.Automation.PSArgumentNullException
f_1343_22975_23021(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 22975, 23021);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_23277_23284()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 23277, 23284);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_23277_23504(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 23277, 23504);
return return_v;
}


bool
f_1343_23621_23677(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 23621, 23677);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_23557_23570_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 23557, 23570);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,22794,23979);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,22794,23979);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsItemContainer(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,24932,27925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,25170,25324);

f_1343_25170_25323(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,25340,25470);

f_1343_25340_25469(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,25486,25622);

f_1343_25486_25621(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,25638,25658);

bool 
result = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,25674,25731);

NavigationCmdletProvider 
navigationCmdletProvider = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,25924,26027);

navigationCmdletProvider =
f_1343_25972_26026(providerInstance, false);

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,26091,26156);

result = f_1343_26100_26155(navigationCmdletProvider, path, context);
                }
                catch (LoopFlowException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,26193,26284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,26259,26265);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,26193,26284);
                }
                catch (PipelineStoppedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,26302,26400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,26375,26381);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,26302,26400);
                }
                catch (ActionPreferenceStopException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,26418,26521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,26496,26502);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,26418,26521);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout.
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,26539,26951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,26635,26932);

throw f_1343_26641_26931(this, "IsItemContainerProviderException", f_1343_26755_26807(), f_1343_26834_26871(navigationCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,26539,26951);
                }
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,26980,27884);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,27279,27326);

f_1343_27279_27325(providerInstance);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,27350,27570) || true) && (f_1343_27354_27365(path)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,27350,27570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,27420,27434);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,27350,27570);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,27350,27570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,27532,27547);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,27350,27570);
}
                }
                catch (NotSupportedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,27607,27869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,27835,27850);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,27607,27869);
                }
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,26980,27884);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,27900,27914);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,24932,27925);

int
f_1343_25170_25323(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 25170, 25323);
return 0;
}


int
f_1343_25340_25469(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 25340, 25469);
return 0;
}


int
f_1343_25486_25621(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 25486, 25621);
return 0;
}


System.Management.Automation.Provider.NavigationCmdletProvider
f_1343_25972_26026(System.Management.Automation.Provider.CmdletProvider
providerInstance,bool
acceptNonContainerProviders)
{
var return_v = GetNavigationProviderInstance( providerInstance, acceptNonContainerProviders);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 25972, 26026);
return return_v;
}


bool
f_1343_26100_26155(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 26100, 26155);
return return_v;
}


string
f_1343_26755_26807()
{
var return_v =                     SessionStateStrings.IsItemContainerProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 26755, 26807);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_26834_26871(System.Management.Automation.Provider.NavigationCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 26834, 26871);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_26641_26931(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 26641, 26931);
return return_v;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_27279_27325(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 27279, 27325);
return return_v;
}


int
f_1343_27354_27365(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 27354, 27365);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,24932,27925);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,24932,27925);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveItem(string[] paths, bool recurse, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,29393,29933);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,29502,29622) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,29502,29622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,29553,29607);

throw f_1343_29559_29606("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,29502,29622);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,29638,29719);

CmdletProviderContext 
context = f_1343_29670_29718(f_1343_29696_29717(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,29733,29755);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,29769,29817);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,29833,29869);

f_1343_29833_29868(this, paths, recurse, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,29885,29922);

f_1343_29885_29921(
            context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,29393,29933);

System.Management.Automation.PSArgumentNullException
f_1343_29559_29606(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 29559, 29606);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_29696_29717(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 29696, 29717);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_29670_29718(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 29670, 29718);
return return_v;
}


int
f_1343_29833_29868(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveItem( paths, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 29833, 29868);
return 0;
}


int
f_1343_29885_29921(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 29885, 29921);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,29393,29933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,29393,29933);
}
		}

internal void RemoveItem(
            string[] paths,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,31413,32517);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,31563,31683) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,31563,31683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,31614,31668);

throw f_1343_31620_31667("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,31563,31683);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,31699,32506);
foreach(string path in f_1343_31723_31728_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,31699,32506);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,31762,31893) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,31762,31893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,31820,31874);

throw f_1343_31826_31873("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,31762,31893);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,31913,31942);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,31960,31999);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,32019,32304);

Collection<string> 
providerPaths =
f_1343_32075_32303(f_1343_32075_32082(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,32324,32491);
foreach(string providerPath in f_1343_32356_32369_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,32324,32491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,32411,32472);

f_1343_32411_32471(this, providerInstance, providerPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,32324,32491);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,168);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,168);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,31699,32506);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,808);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,808);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1343,31413,32517);

System.Management.Automation.PSArgumentNullException
f_1343_31620_31667(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 31620, 31667);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_31826_31873(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 31826, 31873);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_32075_32082()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 32075, 32082);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_32075_32303(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 32075, 32303);
return return_v;
}


int
f_1343_32411_32471(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveItem( providerInstance, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 32411, 32471);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_32356_32369_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 32356, 32369);
return return_v;
}


string[]
f_1343_31723_31728_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 31723, 31728);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,31413,32517);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,31413,32517);
}
		}

internal void RemoveItem(
            string providerId,
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,33794,34641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,34041,34183);

f_1343_34041_34182(providerId != null, "Caller should validate providerId before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,34199,34329);

f_1343_34199_34328(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,34345,34481);

f_1343_34345_34480(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,34497,34563);

CmdletProvider 
providerInstance = f_1343_34531_34562(this, providerId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,34577,34630);

f_1343_34577_34629(this, providerInstance, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,33794,34641);

int
f_1343_34041_34182(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 34041, 34182);
return 0;
}


int
f_1343_34199_34328(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 34199, 34328);
return 0;
}


int
f_1343_34345_34480(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 34345, 34480);
return 0;
}


System.Management.Automation.Provider.CmdletProvider
f_1343_34531_34562(System.Management.Automation.SessionStateInternal
this_param,string
providerId)
{
var return_v = this_param.GetProviderInstance( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 34531, 34562);
return return_v;
}


int
f_1343_34577_34629(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveItem( providerInstance, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 34577, 34629);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,33794,34641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,33794,34641);
}
		}

internal void RemoveItem(
            CmdletProvider providerInstance,
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,35928,40356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,36189,36343);

f_1343_36189_36342(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,36359,36489);

f_1343_36359_36488(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,36505,36641);

f_1343_36505_36640(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,36657,36771);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_36724_36770(providerInstance)
;

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,36823,39645) || true) && (f_1343_36827_36854(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,36823,39645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,36896,36938);

int 
childrenNotMatchingFilterCriteria = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,37217,37368);

f_1343_37217_37367(this, providerInstance, path, recurse, context, out childrenNotMatchingFilterCriteria, ProcessMode.Delete, skipIsItemContainerCheck: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,37539,39485) || true) && (f_1343_37543_37591(this, providerInstance, path, context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,37539,39485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,37641,37690);

string 
item = f_1343_37655_37689(this, path, context, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,37716,38060);

bool 
isIncludeMatch =
f_1343_37767_38059(item, f_1343_37888_38019(f_1343_37975_37990(context), WildcardOptions.IgnoreCase), true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,38088,39462) || true) && (isIncludeMatch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,38088,39462);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,38164,39435) || true) && (!f_1343_38169_38462(item, f_1343_38290_38421(f_1343_38377_38392(context), WildcardOptions.IgnoreCase), false))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,38164,39435);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,39196,39404) || true) && (childrenNotMatchingFilterCriteria == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,39196,39404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,39312,39369);

f_1343_39312_39368(                                    containerCmdletProvider, path, false, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,39196,39404);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,38164,39435);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,38088,39462);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,37539,39485);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,36823,39645);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,36823,39645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,39567,39626);

f_1343_39567_39625(                    containerCmdletProvider, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,36823,39645);
}
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,39674,39753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,39732,39738);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,39674,39753);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,39767,39853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,39832,39838);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,39767,39853);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,39867,39958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,39937,39943);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,39867,39958);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,39972,40345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,40060,40330);

throw f_1343_40066_40329(this, "RemoveItemProviderException", f_1343_40171_40218(), f_1343_40241_40277(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,39972,40345);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,35928,40356);

int
f_1343_36189_36342(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 36189, 36342);
return 0;
}


int
f_1343_36359_36488(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 36359, 36488);
return 0;
}


int
f_1343_36505_36640(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 36505, 36640);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_36724_36770(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 36724, 36770);
return return_v;
}


bool
f_1343_36827_36854(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.HasIncludeOrExclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 36827, 36854);
return return_v;
}


int
f_1343_37217_37367(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context,out int
childrenNotMatchingFilterCriteria,System.Management.Automation.ProcessMode
processMode,bool
skipIsItemContainerCheck)
{
this_param.ProcessPathItems( providerInstance, path, recurse, context, out childrenNotMatchingFilterCriteria, processMode, skipIsItemContainerCheck: skipIsItemContainerCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 37217, 37367);
return 0;
}


bool
f_1343_37543_37591(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 37543, 37591);
return return_v;
}


string
f_1343_37655_37689(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,bool
useDefaultProvider)
{
var return_v = this_param.GetChildName( path, context, useDefaultProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 37655, 37689);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_37975_37990(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 37975, 37990);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
f_1343_37888_38019(System.Collections.ObjectModel.Collection<string>
globPatterns,System.Management.Automation.WildcardOptions
options)
{
var return_v = SessionStateUtilities.CreateWildcardsFromStrings( (System.Collections.Generic.IEnumerable<string>)globPatterns, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 37888, 38019);
return return_v;
}


bool
f_1343_37767_38059(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 37767, 38059);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_38377_38392(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 38377, 38392);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
f_1343_38290_38421(System.Collections.ObjectModel.Collection<string>
globPatterns,System.Management.Automation.WildcardOptions
options)
{
var return_v = SessionStateUtilities.CreateWildcardsFromStrings( (System.Collections.Generic.IEnumerable<string>)globPatterns, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 38290, 38421);
return return_v;
}


bool
f_1343_38169_38462(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 38169, 38462);
return return_v;
}


int
f_1343_39312_39368(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveItem( path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 39312, 39368);
return 0;
}


int
f_1343_39567_39625(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveItem( path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 39567, 39625);
return 0;
}


string
f_1343_40171_40218()
{
var return_v =                     SessionStateStrings.RemoveItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 40171, 40218);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_40241_40277(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 40241, 40277);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_40066_40329(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 40066, 40329);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,35928,40356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,35928,40356);
}
		}

internal object RemoveItemDynamicParameters(
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,41912,43081);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42078,42155) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,42078,42155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42128,42140);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,42078,42155);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42171,42200);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42214,42253);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42269,42356);

CmdletProviderContext 
newContext =
f_1343_42321_42355(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42370,42502);

f_1343_42370_42501(            newContext, f_1343_42410_42434(), f_1343_42453_42477(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42518,42781);

Collection<string> 
providerPaths =
f_1343_42570_42780(f_1343_42570_42577(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42797,43042) || true) && (f_1343_42801_42820(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,42797,43042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,42935,43027);

return f_1343_42942_43026(this, providerInstance, f_1343_42988_43004(providerPaths, 0), recurse, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,42797,43042);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,43058,43070);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,41912,43081);

System.Management.Automation.CmdletProviderContext
f_1343_42321_42355(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 42321, 42355);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_42410_42434()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 42410, 42434);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_42453_42477()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 42453, 42477);
return return_v;
}


int
f_1343_42370_42501(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 42370, 42501);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_42570_42577()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 42570, 42577);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_42570_42780(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 42570, 42780);
return return_v;
}


int
f_1343_42801_42820(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 42801, 42820);
return return_v;
}


string
f_1343_42988_43004(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 42988, 43004);
return return_v;
}


object
f_1343_42942_43026(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RemoveItemDynamicParameters( providerInstance, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 42942, 43026);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,41912,43081);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,41912,43081);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object RemoveItemDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,44335,46109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,44614,44768);

f_1343_44614_44767(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,44784,44914);

f_1343_44784_44913(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,44930,45066);

f_1343_44930_45065(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,45082,45196);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_45149_45195(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,45212,45233);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,45283,45368);

result = f_1343_45292_45367(containerCmdletProvider, path, recurse, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,45397,45476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,45455,45461);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,45397,45476);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,45490,45576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,45555,45561);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,45490,45576);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,45590,45681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,45660,45666);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,45590,45681);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,45695,46068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,45783,46053);

throw f_1343_45789_46052(this, "RemoveItemProviderException", f_1343_45894_45941(), f_1343_45964_46000(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,45695,46068);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,46084,46098);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,44335,46109);

int
f_1343_44614_44767(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 44614, 44767);
return 0;
}


int
f_1343_44784_44913(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 44784, 44913);
return 0;
}


int
f_1343_44930_45065(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 44930, 45065);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_45149_45195(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 45149, 45195);
return return_v;
}


object
f_1343_45292_45367(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RemoveItemDynamicParameters( path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 45292, 45367);
return return_v;
}


string
f_1343_45894_45941()
{
var return_v =                     SessionStateStrings.RemoveItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 45894, 45941);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_45964_46000(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 45964, 46000);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_45789_46052(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 45789, 46052);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,44335,46109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,44335,46109);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> GetChildItems(string[] paths, bool recurse, uint depth, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,48107,48971);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48247,48367) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,48247,48367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48298,48352);

throw f_1343_48304_48351("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,48247,48367);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48383,48464);

CmdletProviderContext 
context = f_1343_48415_48463(f_1343_48441_48462(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48478,48500);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48514,48562);

context.SuppressWildcardExpansion = literalPath;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48578,48852);
foreach(string path in f_1343_48602_48607_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,48578,48852);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48641,48772) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,48641,48772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48699,48753);

throw f_1343_48705_48752("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,48641,48772);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48792,48837);

f_1343_48792_48836(this, path, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,48578,48852);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,275);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,275);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48868,48905);

f_1343_48868_48904(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,48921,48960);

return f_1343_48928_48959(context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,48107,48971);

System.Management.Automation.PSArgumentNullException
f_1343_48304_48351(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 48304, 48351);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_48441_48462(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 48441, 48462);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_48415_48463(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 48415, 48463);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_48705_48752(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 48705, 48752);
return return_v;
}


int
f_1343_48792_48836(System.Management.Automation.SessionStateInternal
this_param,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildItems( path, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 48792, 48836);
return 0;
}


string[]
f_1343_48602_48607_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 48602, 48607);
return return_v;
}


int
f_1343_48868_48904(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 48868, 48904);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_48928_48959(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 48928, 48959);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,48107,48971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,48107,48971);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetChildItems(
            string path,
            bool recurse,
            uint depth,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,50752,61174);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,50927,51045) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,50927,51045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,50977,51030);

throw f_1343_50983_51029("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,50927,51045);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51061,51185) || true) && (context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,51061,51185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51114,51170);

throw f_1343_51120_51169("context");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,51061,51185);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51201,51230);

ProviderInfo 
provider = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51246,61163) || true) && ((recurse &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 51251, 51296)&&f_1343_51262_51296_M(!context.SuppressWildcardExpansion))) ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 51250, 51353)||f_1343_51301_51353(path, context)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,51246,61163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51387,51416);

bool 
modifiedInclude = false
;

                try
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51596,53957) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,51596,53957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51657,51704);

string 
childName = f_1343_51676_51703(this, path, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51875,51913);

bool 
isFileOrDirectoryPresent = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,51941,52206) || true) && (f_1343_51945_51970(context)is Microsoft.PowerShell.Commands.GetChildDynamicParameters dynParam)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,51941,52206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,52096,52179);

isFileOrDirectoryPresent = dynParam.File.IsPresent ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 52123, 52178)||dynParam.Directory.IsPresent);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,51941,52206);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,52234,52534) || true) && (f_1343_52238_52303(childName, "*", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 52238, 52331)&&isFileOrDirectoryPresent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,52234,52534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,52389,52459);

string 
parentName = f_1343_52409_52458(path, 0, f_1343_52427_52438(path)- f_1343_52441_52457(childName))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,52489,52507);

path = parentName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,52234,52534);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,52633,53934) || true) && ((f_1343_52638_52653(context)== null) ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 52637, 52694)||(f_1343_52667_52688(f_1343_52667_52682(context))== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,52633,53934);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,53172,53907) || true) && (!f_1343_53177_53203(path)&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 53176, 53229)&&!f_1343_53208_53229(this, path)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,53172,53907);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,53295,53718) || true) && (!f_1343_53300_53365(childName, "*", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,53295,53718);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,53439,53683) || true) && (f_1343_53443_53458(context)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,53439,53683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,53548,53579);

f_1343_53548_53578(f_1343_53548_53563(context), childName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,53621,53644);

modifiedInclude = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,53439,53683);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,53295,53718);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,53754,53824);

string 
parentName = f_1343_53774_53823(path, 0, f_1343_53792_53803(path)- f_1343_53806_53822(childName))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,53858,53876);

path = parentName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,53172,53907);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,52633,53934);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,51596,53957);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54116,54161);

Collection<string> 
include = f_1343_54145_54160(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54183,54228);

Collection<string> 
exclude = f_1343_54212_54227(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54250,54281);

string 
filter = f_1343_54266_54280(context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54305,54554) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,54305,54554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54366,54531);

f_1343_54366_54530(                        context, f_1343_54415_54439(), f_1343_54470_54494(), null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,54305,54554);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54578,54617);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54639,54679);

Collection<string> 
providerPaths = null
;

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,54755,55040);

providerPaths = f_1343_54771_55039(f_1343_54771_54778(), path, false, context, out provider, out providerInstance);
                    }
                    finally
                    {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1343,55085,55363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,55207,55340);

f_1343_55207_55339(                        // Reset the include and exclude filters
                        context, include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceExitFinally(1343,55085,55363);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,55556,55712) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,55556,55712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,55617,55689);

ContainerCmdletProvider 
unused = f_1343_55650_55688(this, provider)
;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,55556,55712);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,55736,55820);

bool 
getChildrenBecauseNoGlob = !f_1343_55769_55819(path)
;

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,56284,58510) || true) && ((recurse &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 56315, 56351)&&!getChildrenBecauseNoGlob )&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 56315, 56372)&&(include != null) )&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 56315, 56396)&&(f_1343_56377_56390(include)== 0))) ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 56314, 56464)||                        (include != null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 56427, 56463)&&f_1343_56446_56459(include)> 0)) )||(DynAbs.Tracing.TraceSender.Expression_False(1343, 56314, 56531)||                        (exclude != null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 56494, 56530)&&f_1343_56513_56526(exclude)> 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,56284,58510);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,56716,57294);
foreach(string providerPath in f_1343_56748_56761_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,56716,57294);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,56891,57015) || true) && (f_1343_56895_56911(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,56891,57015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,56977,56984);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,56891,57015);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,57047,57095);

int 
unUsedChildrenNotMatchingFilterCriteria = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,57125,57267);

f_1343_57125_57266(this, providerInstance, providerPath, recurse, depth, context, out unUsedChildrenNotMatchingFilterCriteria, ProcessMode.Enumerate);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,56716,57294);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,579);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,579);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,56284,58510);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,56284,58510);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,57674,58487);
foreach(string providerPath in f_1343_57706_57719_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,57674,58487);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,57849,57973) || true) && (f_1343_57853_57869(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,57849,57973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,57935,57942);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,57849,57973);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58005,58460) || true) && ((getChildrenBecauseNoGlob ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 58010, 58045)||recurse)) &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 58009, 58106)&&f_1343_58050_58106(this, providerInstance, providerPath, context)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,58005,58460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58172,58243);

f_1343_58172_58242(this, providerInstance, providerPath, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,58005,58460);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,58005,58460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58373,58429);

f_1343_58373_58428(this, providerInstance, providerPath, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,58005,58460);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,57674,58487);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,814);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,814);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,56284,58510);
}
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1343,58547,58730);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58595,58711) || true) && (modifiedInclude)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,58595,58711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58664,58688);

f_1343_58664_58687(f_1343_58664_58679(context));
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,58595,58711);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1343,58547,58730);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,51246,61163);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,51246,61163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58796,58821);

PSDriveInfo 
drive = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58841,58868);

string 
originalPath = path
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,58886,59148);

path =
f_1343_58914_59147(f_1343_58914_58921(), (DynAbs.Tracing.TraceSender.Conditional_F1(1343, 58964, 58997)||((f_1343_58964_58997(context)&&DynAbs.Tracing.TraceSender.Conditional_F2(1343, 59000, 59004))||DynAbs.Tracing.TraceSender.Conditional_F3(1343, 59007, 59037)))?path :f_1343_59007_59037(path), context, out provider, out drive);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,59168,59268) || true) && (drive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,59168,59268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,59227,59249);

context.Drive = drive;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,59168,59268);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,59288,59370);

ContainerCmdletProvider 
providerInstance = f_1343_59331_59369(this, provider)
;

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,59390,61148) || true) && ((f_1343_59417_59432(context)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 59417, 59469)&&f_1343_59444_59465(f_1343_59444_59459(context))> 0)) ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 59416, 59549)||                    (f_1343_59496_59511(context)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 59496, 59548)&&f_1343_59523_59544(f_1343_59523_59538(context))> 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,59390,61148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,59718,59766);

int 
unUsedChildrenNotMatchingFilterCriteria = 0
;
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,59921,59963);

context.SuppressWildcardExpansion = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,59989,60123);

f_1343_59989_60122(this, providerInstance, path, recurse, depth, context, out unUsedChildrenNotMatchingFilterCriteria, ProcessMode.Enumerate);
                    }
                    finally
                    {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1343,60168,60288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,60224,60265);

context.SuppressWildcardExpansion = true;
DynAbs.Tracing.TraceSender.TraceExitFinally(1343,60168,60288);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,59390,61148);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,59390,61148);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,60330,61148) || true) && (path != null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 60334, 60398)&&f_1343_60350_60398(this, providerInstance, path, context)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,60330,61148);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,60440,60774) || true) && (f_1343_60444_60492(this, providerInstance, path, context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,60440,60774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,60542,60605);

f_1343_60542_60604(this, providerInstance, path, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,60440,60774);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,60440,60774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,60703,60751);

f_1343_60703_60750(this, providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,60440,60774);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,60330,61148);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,60330,61148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,60856,61088);

ItemNotFoundException 
pathNotFound =
f_1343_60918_61087(path, "PathNotFound", f_1343_61054_61086())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,61110,61129);

throw pathNotFound;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,60330,61148);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,59390,61148);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,51246,61163);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,50752,61174);

System.Management.Automation.PSArgumentNullException
f_1343_50983_51029(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 50983, 51029);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_51120_51169(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 51120, 51169);
return return_v;
}


bool
f_1343_51262_51296_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 51262, 51296);
return return_v;
}


bool
f_1343_51301_51353(string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = LocationGlobber.ShouldPerformGlobbing( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 51301, 51353);
return return_v;
}


string
f_1343_51676_51703(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildName( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 51676, 51703);
return return_v;
}


object
f_1343_51945_51970(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.DynamicParameters ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 51945, 51970);
return return_v;
}


bool
f_1343_52238_52303(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 52238, 52303);
return return_v;
}


int
f_1343_52427_52438(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 52427, 52438);
return return_v;
}


int
f_1343_52441_52457(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 52441, 52457);
return return_v;
}


string
f_1343_52409_52458(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 52409, 52458);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_52638_52653(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 52638, 52653);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_52667_52682(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 52667, 52682);
return return_v;
}


int
f_1343_52667_52688(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 52667, 52688);
return return_v;
}


bool
f_1343_53177_53203(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 53177, 53203);
return return_v;
}


bool
f_1343_53208_53229(System.Management.Automation.SessionStateInternal
this_param,string
path)
{
var return_v = this_param.IsItemContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 53208, 53229);
return return_v;
}


bool
f_1343_53300_53365(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 53300, 53365);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_53443_53458(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 53443, 53458);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_53548_53563(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 53548, 53563);
return return_v;
}


int
f_1343_53548_53578(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 53548, 53578);
return 0;
}


int
f_1343_53792_53803(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 53792, 53803);
return return_v;
}


int
f_1343_53806_53822(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 53806, 53822);
return return_v;
}


string
f_1343_53774_53823(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 53774, 53823);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_54145_54160(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 54145, 54160);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_54212_54227(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 54212, 54227);
return return_v;
}


string
f_1343_54266_54280(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Filter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 54266, 54280);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_54415_54439()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 54415, 54439);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_54470_54494()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 54470, 54494);
return return_v;
}


int
f_1343_54366_54530(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 54366, 54530);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_54771_54778()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 54771, 54778);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_54771_55039(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 54771, 55039);
return return_v;
}


int
f_1343_55207_55339(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 55207, 55339);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_55650_55688(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetContainerProviderInstance( provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 55650, 55688);
return return_v;
}


bool
f_1343_55769_55819(string
path)
{
var return_v = LocationGlobber.StringContainsGlobCharacters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 55769, 55819);
return return_v;
}


int
f_1343_56377_56390(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 56377, 56390);
return return_v;
}


int
f_1343_56446_56459(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 56446, 56459);
return return_v;
}


int
f_1343_56513_56526(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 56513, 56526);
return return_v;
}


bool
f_1343_56895_56911(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 56895, 56911);
return return_v;
}


int
f_1343_57125_57266(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context,out int
childrenNotMatchingFilterCriteria,System.Management.Automation.ProcessMode
processMode)
{
this_param.ProcessPathItems( providerInstance, path, recurse, depth, context, out childrenNotMatchingFilterCriteria, processMode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 57125, 57266);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_56748_56761_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 56748, 56761);
return return_v;
}


bool
f_1343_57853_57869(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 57853, 57869);
return return_v;
}


bool
f_1343_58050_58106(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 58050, 58106);
return return_v;
}


int
f_1343_58172_58242(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildItems( providerInstance, path, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 58172, 58242);
return 0;
}


int
f_1343_58373_58428(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetItemPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 58373, 58428);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_57706_57719_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 57706, 57719);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_58664_58679(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 58664, 58679);
return return_v;
}


int
f_1343_58664_58687(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 58664, 58687);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_58914_58921()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 58914, 58921);
return return_v;
}


bool
f_1343_58964_58997(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.SuppressWildcardExpansion ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 58964, 58997);
return return_v;
}


string
f_1343_59007_59037(string
pattern)
{
var return_v = WildcardPattern.Unescape( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 59007, 59037);
return return_v;
}


string
f_1343_58914_59147(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 58914, 59147);
return return_v;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_59331_59369(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetContainerProviderInstance( provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 59331, 59369);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_59417_59432(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 59417, 59432);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_59444_59459(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 59444, 59459);
return return_v;
}


int
f_1343_59444_59465(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 59444, 59465);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_59496_59511(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 59496, 59511);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_59523_59538(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 59523, 59538);
return return_v;
}


int
f_1343_59523_59544(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 59523, 59544);
return return_v;
}


int
f_1343_59989_60122(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context,out int
childrenNotMatchingFilterCriteria,System.Management.Automation.ProcessMode
processMode)
{
this_param.ProcessPathItems( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, recurse, depth, context, out childrenNotMatchingFilterCriteria, processMode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 59989, 60122);
return 0;
}


bool
f_1343_60350_60398(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExists( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 60350, 60398);
return return_v;
}


bool
f_1343_60444_60492(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 60444, 60492);
return return_v;
}


int
f_1343_60542_60604(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildItems( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 60542, 60604);
return 0;
}


int
f_1343_60703_60750(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetItemPrivate( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 60703, 60750);
return 0;
}


string
f_1343_61054_61086()
{
var return_v =                             SessionStateStrings.PathNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 61054, 61086);
return return_v;
}


System.Management.Automation.ItemNotFoundException
f_1343_60918_61087(string
path,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.ItemNotFoundException( path, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 60918, 61087);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,50752,61174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,50752,61174);
}
		}

private void GetChildItems(
            CmdletProvider providerInstance,
            string path,
            bool recurse,
            uint depth,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,62390,64094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,62678,62832);

f_1343_62678_62831(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,62848,62978);

f_1343_62848_62977(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,62994,63130);

f_1343_62994_63129(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,63146,63260);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_63213_63259(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,63312,63381);

f_1343_63312_63380(                containerCmdletProvider, path, recurse, depth, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,63410,63489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,63468,63474);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,63410,63489);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,63503,63589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,63568,63574);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,63503,63589);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,63603,63694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,63673,63679);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,63603,63694);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,63708,64083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,63796,64068);

throw f_1343_63802_64067(this, "GetChildrenProviderException", f_1343_63908_63956(), f_1343_63979_64015(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,63708,64083);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,62390,64094);

int
f_1343_62678_62831(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 62678, 62831);
return 0;
}


int
f_1343_62848_62977(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 62848, 62977);
return 0;
}


int
f_1343_62994_63129(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 62994, 63129);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_63213_63259(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 63213, 63259);
return return_v;
}


int
f_1343_63312_63380(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildItems( path, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 63312, 63380);
return 0;
}


string
f_1343_63908_63956()
{
var return_v =                     SessionStateStrings.GetChildrenProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 63908, 63956);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_63979_64015(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 63979, 64015);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_63802_64067(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 63802, 64067);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,62390,64094);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,62390,64094);
}
		}

private bool IsPathContainer(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,64585,65866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,64755,64782);

bool 
itemContainer = false
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,64832,64897);

itemContainer = f_1343_64848_64896(this, providerInstance, path, context);
            }
            catch (UnauthorizedAccessException accessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,64926,65150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,65010,65135);

f_1343_65010_65134(                context, f_1343_65029_65133(accessException, "GetItemUnauthorizedAccessError", ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,64926,65150);
            }
            catch (ProviderInvocationException accessException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,65164,65818);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,65371,65803) || true) && (f_1343_65375_65405(accessException)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 65375, 65529)&&f_1343_65438_65529(f_1343_65438_65478(f_1343_65438_65468(accessException)), typeof(System.UnauthorizedAccessException))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,65371,65803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,65571,65696);

f_1343_65571_65695(                    context, f_1343_65590_65694(accessException, "GetItemUnauthorizedAccessError", ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,65371,65803);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,65371,65803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,65778,65784);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,65371,65803);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,65164,65818);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,65834,65855);

return itemContainer;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,64585,65866);

bool
f_1343_64848_64896(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 64848, 64896);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_65029_65133(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 65029, 65133);
return return_v;
}


int
f_1343_65010_65134(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 65010, 65134);
return 0;
}


System.Exception
f_1343_65375_65405(System.Management.Automation.ProviderInvocationException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 65375, 65405);
return return_v;
}


System.Exception
f_1343_65438_65468(System.Management.Automation.ProviderInvocationException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 65438, 65468);
return return_v;
}


System.Type
f_1343_65438_65478(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 65438, 65478);
return return_v;
}


bool
f_1343_65438_65529(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 65438, 65529);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_65590_65694(System.Management.Automation.ProviderInvocationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 65590, 65694);
return return_v;
}


int
f_1343_65571_65695(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 65571, 65695);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,64585,65866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,64585,65866);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ProcessPathItems(
            CmdletProvider providerInstance,
            string path,
            bool recurse,
            CmdletProviderContext context,
            out int childrenNotMatchingFilterCriteria,
            ProcessMode processMode = ProcessMode.Enumerate,
            bool skipIsItemContainerCheck = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,67725,68364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,68201,68353);

f_1343_68201_68352(this, providerInstance, path, recurse, uint.MaxValue, context, out childrenNotMatchingFilterCriteria, processMode, skipIsItemContainerCheck);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,67725,68364);

int
f_1343_68201_68352(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context,out int
childrenNotMatchingFilterCriteria,System.Management.Automation.ProcessMode
processMode,bool
skipIsItemContainerCheck)
{
this_param.ProcessPathItems( providerInstance, path, recurse, depth, context, out childrenNotMatchingFilterCriteria, processMode, skipIsItemContainerCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 68201, 68352);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,67725,68364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,67725,68364);
}
		}

private void ProcessPathItems(
            CmdletProvider providerInstance,
            string path,
            bool recurse,
            uint depth,
            CmdletProviderContext context,
            out int childrenNotMatchingFilterCriteria,
            ProcessMode processMode = ProcessMode.Enumerate,
            bool skipIsItemContainerCheck = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,70362,79593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,70755,70852);

ContainerCmdletProvider 
containerCmdletProvider = f_1343_70805_70851(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,70866,70904);

childrenNotMatchingFilterCriteria = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,70920,71060);

f_1343_70920_71059(providerInstance != null, "The caller should have verified the providerInstance");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,71076,71192);

f_1343_71076_71191(path != null, "The caller should have verified the path");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,71208,71330);

f_1343_71208_71329(context != null, "The caller should have verified the context");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,71393,71592);

Collection<WildcardPattern> 
includeMatcher =
f_1343_71455_71591(f_1343_71526_71541(context), WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,71655,71854);

Collection<WildcardPattern> 
excludeMatcher =
f_1343_71717_71853(f_1343_71788_71803(context), WildcardOptions.IgnoreCase)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,72015,79582) || true) && (skipIsItemContainerCheck ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 72019, 72095)||f_1343_72047_72095(this, providerInstance, path, context)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,72015,79582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,72129,72220);

CmdletProviderContext 
newContext =
f_1343_72185_72219(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,72240,72285);

Collection<PSObject> 
childNameObjects = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,72303,72390);

System.Collections.Generic.Dictionary<string, bool> 
filteredChildNameDictionary = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,72502,72747);

f_1343_72502_72746(this, providerInstance, path, (DynAbs.Tracing.TraceSender.Conditional_F1(1343, 72616, 72625)||((                        (recurse) &&DynAbs.Tracing.TraceSender.Conditional_F2(1343, 72628, 72664))||DynAbs.Tracing.TraceSender.Conditional_F3(1343, 72667, 72708)))?ReturnContainers.ReturnAllContainers :ReturnContainers.ReturnMatchingContainers, newContext);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,72769,72810);

f_1343_72769_72809(                    newContext, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,72832,72886);

childNameObjects = f_1343_72851_72885(newContext);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,73318,74425) || true) && (recurse &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 73322, 73365)&&(f_1343_73334_73364(providerInstance))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,73318,74425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,73415,73447);

f_1343_73415_73446(                        newContext);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,73473,73521);

newContext = f_1343_73486_73520(context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,73547,73635);

filteredChildNameDictionary = f_1343_73577_73634();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,73663,73873);

f_1343_73663_73872(this, providerInstance, path, ReturnContainers.ReturnMatchingContainers, newContext);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,73899,73965);

var 
filteredChildNameObjects = f_1343_73930_73964(newContext)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,73993,74402);
foreach(PSObject filteredChildName in f_1343_74032_74056_I(filteredChildNameObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,73993,74402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74114,74175);

string 
filteredName = f_1343_74136_74164(filteredChildName)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74205,74375) || true) && (filteredName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,74205,74375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74295,74344);

filteredChildNameDictionary[filteredName] = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,74205,74375);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,73993,74402);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,410);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,410);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,73318,74425);
}
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1343,74462,74561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74510,74542);

f_1343_74510_74541(                    newContext);
DynAbs.Tracing.TraceSender.TraceExitFinally(1343,74462,74561);
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74720,74729);

                // Now loop through all the child objects matching the filters and recursing
                // into containers
                for (int 
index = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74711,78158) || true) && (index < f_1343_74739_74761(childNameObjects))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74763,74770)
,++index,DynAbs.Tracing.TraceSender.TraceExitCondition(1343,74711,78158))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,74711,78158);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74876,74976) || true) && (f_1343_74880_74896(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,74876,74976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,74946,74953);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,74876,74976);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75000,75064);

string 
childName = f_1343_75019_75053(f_1343_75019_75042(childNameObjects, index))as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75088,75191) || true) && (childName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,75088,75191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75159,75168);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,75088,75191);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75282,75358);

string 
qualifiedPath = f_1343_75305_75357(this, providerInstance, path, childName, context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75382,75489) || true) && (qualifiedPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,75382,75489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75457,75466);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,75382,75489);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75513,75767);

bool 
isIncludeMatch = f_1343_75535_75569_M(!context.SuppressWildcardExpansion)&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 75535, 75766)&&f_1343_75598_75766(childName, includeMatcher, true))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75791,77459) || true) && (isIncludeMatch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,75791,77459);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,75859,77302) || true) && (!f_1343_75864_76033(childName, excludeMatcher, false))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,75859,77302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76091,76112);

bool 
emitItem = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76142,76440) || true) && (filteredChildNameDictionary != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,76142,76440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76247,76284);

bool 
isChildNameInDictionary = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76318,76409);

emitItem = f_1343_76329_76408(filteredChildNameDictionary, childName, out isChildNameInDictionary);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,76142,76440);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76472,77125) || true) && (emitItem)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,76472,77125);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76550,77094) || true) && (processMode == ProcessMode.Delete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,76550,77094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76661,76727);

f_1343_76661_76726(                                    containerCmdletProvider, qualifiedPath, false, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,76550,77094);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,76550,77094);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,76801,77094) || true) && (processMode != ProcessMode.Delete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,76801,77094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,77002,77059);

f_1343_77002_77058(this, providerInstance, qualifiedPath, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,76801,77094);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,76550,77094);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,76472,77125);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,75859,77302);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,75859,77302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,77239,77275);

childrenNotMatchingFilterCriteria++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,75859,77302);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,75791,77459);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,75791,77459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,77400,77436);

childrenNotMatchingFilterCriteria++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,75791,77459);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,77540,78139) || true) && (recurse &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 77544, 77612)&&f_1343_77555_77612(this, providerInstance, qualifiedPath, context))&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 77544, 77625)&&depth > 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,77540,78139);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,77743,77855) || true) && (f_1343_77747_77763(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,77743,77855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,77821,77828);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,77743,77855);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,77953,78116);

f_1343_77953_78115(this, providerInstance, qualifiedPath, recurse, depth - 1, context, out childrenNotMatchingFilterCriteria, processMode, skipIsItemContainerCheck: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,77540,78139);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,3448);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,3448);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,72015,79582);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,72015,79582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,78341,78365);

string 
childName = path
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,78383,78447);

childName = f_1343_78395_78446(this, providerInstance, path, context, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,78527,78727);

bool 
isIncludeMatch =
f_1343_78570_78726(childName, includeMatcher, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,78747,79567) || true) && (isIncludeMatch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,78747,79567);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,78807,79548) || true) && (!f_1343_78812_78981(childName, excludeMatcher, false))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,78807,79548);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,79031,79525) || true) && (processMode != ProcessMode.Delete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,79031,79525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,79208,79256);

f_1343_79208_79255(this, providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,79031,79525);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,79031,79525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,79439,79498);

f_1343_79439_79497(                            // The object is a match so, remove it.
                            containerCmdletProvider, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,79031,79525);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,78807,79548);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,78747,79567);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,72015,79582);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,70362,79593);

System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_70805_70851(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 70805, 70851);
return return_v;
}


int
f_1343_70920_71059(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 70920, 71059);
return 0;
}


int
f_1343_71076_71191(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 71076, 71191);
return 0;
}


int
f_1343_71208_71329(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 71208, 71329);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_71526_71541(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 71526, 71541);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
f_1343_71455_71591(System.Collections.ObjectModel.Collection<string>
globPatterns,System.Management.Automation.WildcardOptions
options)
{
var return_v = SessionStateUtilities.CreateWildcardsFromStrings( (System.Collections.Generic.IEnumerable<string>)globPatterns, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 71455, 71591);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_71788_71803(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 71788, 71803);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
f_1343_71717_71853(System.Collections.ObjectModel.Collection<string>
globPatterns,System.Management.Automation.WildcardOptions
options)
{
var return_v = SessionStateUtilities.CreateWildcardsFromStrings( (System.Collections.Generic.IEnumerable<string>)globPatterns, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 71717, 71853);
return return_v;
}


bool
f_1343_72047_72095(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsPathContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 72047, 72095);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_72185_72219(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 72185, 72219);
return return_v;
}


int
f_1343_72502_72746(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.ReturnContainers
returnContainers,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildNames( providerInstance, path, returnContainers, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 72502, 72746);
return 0;
}


int
f_1343_72769_72809(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.CmdletProviderContext
errorContext)
{
this_param.WriteErrorsToContext( errorContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 72769, 72809);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_72851_72885(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 72851, 72885);
return return_v;
}


bool
f_1343_73334_73364(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.IsFilterSet();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 73334, 73364);
return return_v;
}


int
f_1343_73415_73446(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.RemoveStopReferral();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 73415, 73446);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1343_73486_73520(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 73486, 73520);
return return_v;
}


System.Collections.Generic.Dictionary<string, bool>
f_1343_73577_73634()
{
var return_v = new System.Collections.Generic.Dictionary<string, bool>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 73577, 73634);
return return_v;
}


int
f_1343_73663_73872(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.ReturnContainers
returnContainers,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildNames( providerInstance, path, returnContainers, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 73663, 73872);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_73930_73964(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 73930, 73964);
return return_v;
}


object
f_1343_74136_74164(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 74136, 74164);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_74032_74056_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 74032, 74056);
return return_v;
}


int
f_1343_74510_74541(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.RemoveStopReferral();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 74510, 74541);
return 0;
}


int
f_1343_74739_74761(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 74739, 74761);
return return_v;
}


bool
f_1343_74880_74896(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 74880, 74896);
return return_v;
}


System.Management.Automation.PSObject
f_1343_75019_75042(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 75019, 75042);
return return_v;
}


object
f_1343_75019_75053(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 75019, 75053);
return return_v;
}


string
f_1343_75305_75357(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
parent,string
child,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MakePath( providerInstance, parent, child, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 75305, 75357);
return return_v;
}


bool
f_1343_75535_75569_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 75535, 75569);
return return_v;
}


bool
f_1343_75598_75766(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 75598, 75766);
return return_v;
}


bool
f_1343_75864_76033(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 75864, 76033);
return return_v;
}


bool
f_1343_76329_76408(System.Collections.Generic.Dictionary<string, bool>
this_param,string
key,out bool
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 76329, 76408);
return return_v;
}


int
f_1343_76661_76726(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveItem( path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 76661, 76726);
return 0;
}


int
f_1343_77002_77058(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetItemPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 77002, 77058);
return 0;
}


bool
f_1343_77555_77612(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsPathContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 77555, 77612);
return return_v;
}


bool
f_1343_77747_77763(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 77747, 77763);
return return_v;
}


int
f_1343_77953_78115(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context,out int
childrenNotMatchingFilterCriteria,System.Management.Automation.ProcessMode
processMode,bool
skipIsItemContainerCheck)
{
this_param.ProcessPathItems( providerInstance, path, recurse, depth, context, out childrenNotMatchingFilterCriteria, processMode, skipIsItemContainerCheck: skipIsItemContainerCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 77953, 78115);
return 0;
}


string
f_1343_78395_78446(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context,bool
acceptNonContainerProviders)
{
var return_v = this_param.GetChildName( providerInstance, path, context, acceptNonContainerProviders);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 78395, 78446);
return return_v;
}


bool
f_1343_78570_78726(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 78570, 78726);
return return_v;
}


bool
f_1343_78812_78981(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 78812, 78981);
return return_v;
}


int
f_1343_79208_79255(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetItemPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 79208, 79255);
return 0;
}


int
f_1343_79439_79497(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveItem( path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 79439, 79497);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,70362,79593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,70362,79593);
}
		}

internal object GetChildItemsDynamicParameters(
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,81151,84221);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81320,81397) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,81320,81397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81370,81382);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,81320,81397);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81413,81442);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81456,81495);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81571,81615);

f_1343_81571_81614(f_1343_81571_81578(), path, out provider);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81742,81850) || true) && (!f_1343_81747_81789(this, provider))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,81742,81850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81823,81835);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,81742,81850);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81866,81953);

CmdletProviderContext 
newContext =
f_1343_81918_81952(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,81967,82099);

f_1343_81967_82098(            newContext, f_1343_82007_82031(), f_1343_82050_82074(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,82115,82155);

Collection<string> 
providerPaths = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,82207,82475);

providerPaths =
f_1343_82244_82474(f_1343_82244_82251(), path, true, newContext, out provider, out providerInstance);
            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,82504,83061);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,82951,83046) || true) && (providerInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,82951,83046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,83021,83027);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,82951,83046);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,82504,83061);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,83077,84182) || true) && (providerPaths != null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 83081, 83129)&&f_1343_83106_83125(providerPaths)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,83077,84182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,83238,83333);

return f_1343_83245_83332(this, providerInstance, f_1343_83294_83310(providerPaths, 0), recurse, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,83077,84182);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,83077,84182);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,83399,84167) || true) && (providerInstance != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,83399,84167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,83469,83494);

PSDriveInfo 
drive = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,83852,83938);

string 
providerPath = f_1343_83874_83937(f_1343_83874_83881(), path, context, out provider, out drive)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,83960,84148) || true) && (providerPath != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,83960,84148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84034,84125);

return f_1343_84041_84124(this, providerInstance, providerPath, recurse, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,83960,84148);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,83399,84167);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,83077,84182);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84198,84210);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,81151,84221);

System.Management.Automation.LocationGlobber
f_1343_81571_81578()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 81571, 81578);
return return_v;
}


string
f_1343_81571_81614(System.Management.Automation.LocationGlobber
this_param,string
path,out System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetProviderPath( path, out provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 81571, 81614);
return return_v;
}


bool
f_1343_81747_81789(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
providerInfo)
{
var return_v = this_param.HasGetChildItemDynamicParameters( providerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 81747, 81789);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_81918_81952(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 81918, 81952);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_82007_82031()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 82007, 82031);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_82050_82074()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 82050, 82074);
return return_v;
}


int
f_1343_81967_82098(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 81967, 82098);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_82244_82251()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 82244, 82251);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_82244_82474(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 82244, 82474);
return return_v;
}


int
f_1343_83106_83125(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 83106, 83125);
return return_v;
}


string
f_1343_83294_83310(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 83294, 83310);
return return_v;
}


object
f_1343_83245_83332(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildItemsDynamicParameters( providerInstance, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 83245, 83332);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_83874_83881()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 83874, 83881);
return return_v;
}


string
f_1343_83874_83937(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 83874, 83937);
return return_v;
}


object
f_1343_84041_84124(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildItemsDynamicParameters( providerInstance, path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 84041, 84124);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,81151,84221);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,81151,84221);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool HasGetChildItemDynamicParameters(ProviderInfo providerInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,84310,84985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84407,84457);

Type 
providerType = f_1343_84427_84456(providerInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84473,84494);

MethodInfo 
mi = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,84510,84938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84545,84701);

mi = f_1343_84550_84700(providerType, "GetChildItemsDynamicParameters", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84719,84756);

providerType = f_1343_84734_84755(providerType);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,84510,84938);
}
while (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84510,84938) || true) && ((mi == null) &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 84797, 84852)&&                (providerType != null) )&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 84797, 84922)&&                (providerType != typeof(ContainerCmdletProvider))
))
            );
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,84510,84938);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,84510,84938);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,84954,84974);

return (mi != null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,84310,84985);

System.Type
f_1343_84427_84456(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.ImplementingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 84427, 84456);
return return_v;
}


System.Reflection.MethodInfo?
f_1343_84550_84700(System.Type
this_param,string
name,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetMethod( name, bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 84550, 84700);
return return_v;
}


System.Type
f_1343_84734_84755(System.Type
this_param)
{
var return_v = this_param.BaseType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 84734, 84755);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,84310,84985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,84310,84985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetChildItemsDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,86248,88066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,86530,86684);

f_1343_86530_86683(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,86700,86830);

f_1343_86700_86829(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,86846,86982);

f_1343_86846_86981(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,86998,87112);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_87065_87111(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,87128,87149);

object 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,87201,87289);

result = f_1343_87210_87288(containerCmdletProvider, path, recurse, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,87318,87397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,87376,87382);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,87318,87397);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,87411,87497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,87476,87482);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,87411,87497);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,87511,87602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,87581,87587);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,87511,87602);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,87616,88025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,87704,88010);

throw f_1343_87710_88009(this, "GetChildrenDynamicParametersProviderException", f_1343_87833_87898(), f_1343_87921_87957(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,87616,88025);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,88041,88055);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,86248,88066);

int
f_1343_86530_86683(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 86530, 86683);
return 0;
}


int
f_1343_86700_86829(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 86700, 86829);
return 0;
}


int
f_1343_86846_86981(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 86846, 86981);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_87065_87111(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 87065, 87111);
return return_v;
}


object
f_1343_87210_87288(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildItemsDynamicParameters( path, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 87210, 87288);
return return_v;
}


string
f_1343_87833_87898()
{
var return_v =                     SessionStateStrings.GetChildrenDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 87833, 87898);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_87921_87957(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 87921, 87957);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_87710_88009(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 87710, 88009);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,86248,88066);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,86248,88066);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<string> GetChildNames(
            string[] paths,
            ReturnContainers returnContainers,
            bool recurse,
            uint depth,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,90647,91931);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,90899,91019) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,90899,91019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,90950,91004);

throw f_1343_90956_91003("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,90899,91019);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91035,91116);

CmdletProviderContext 
context = f_1343_91067_91115(f_1343_91093_91114(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91130,91152);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91166,91214);

context.SuppressWildcardExpansion = literalPath;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91230,91522);
foreach(string path in f_1343_91254_91259_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,91230,91522);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91293,91424) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,91293,91424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91351,91405);

throw f_1343_91357_91404("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,91293,91424);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91444,91507);

f_1343_91444_91506(this, path, returnContainers, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,91230,91522);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,293);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,293);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91538,91575);

f_1343_91538_91574(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91591,91660);

Collection<PSObject> 
objectResults = f_1343_91628_91659(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91676,91730);

Collection<string> 
results = f_1343_91705_91729()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91746,91889);
foreach(PSObject resultObject in f_1343_91780_91793_I(objectResults) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,91746,91889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91827,91874);

f_1343_91827_91873(                results, f_1343_91839_91862(resultObject)as string);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,91746,91889);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,144);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,144);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,91905,91920);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,90647,91931);

System.Management.Automation.PSArgumentNullException
f_1343_90956_91003(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 90956, 91003);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_91093_91114(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 91093, 91114);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_91067_91115(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91067, 91115);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_91357_91404(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91357, 91404);
return return_v;
}


int
f_1343_91444_91506(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.ReturnContainers
returnContainers,bool
recurse,uint
depth,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildNames( path, returnContainers, recurse, depth, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91444, 91506);
return 0;
}


string[]
f_1343_91254_91259_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91254, 91259);
return return_v;
}


int
f_1343_91538_91574(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91538, 91574);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_91628_91659(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91628, 91659);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_91705_91729()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91705, 91729);
return return_v;
}


object
f_1343_91839_91862(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 91839, 91862);
return return_v;
}


int
f_1343_91827_91873(System.Collections.ObjectModel.Collection<string>
this_param,object
item)
{
this_param.Add( (string)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91827, 91873);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_91780_91793_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 91780, 91793);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,90647,91931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,90647,91931);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetChildNames(
            string path,
            ReturnContainers returnContainers,
            bool recurse,
            uint depth,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,94495,101591);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,94718,94836) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,94718,94836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,94768,94821);

throw f_1343_94774_94820("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,94718,94836);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,94899,95098);

Collection<WildcardPattern> 
includeMatcher =
f_1343_94961_95097(f_1343_95032_95047(context), WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,95161,95360);

Collection<WildcardPattern> 
excludeMatcher =
f_1343_95223_95359(f_1343_95294_95309(context), WildcardOptions.IgnoreCase)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,95376,101580) || true) && (f_1343_95380_95432(path, context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,95376,101580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,95466,95495);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,95513,95552);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,95768,95867);

CmdletProviderContext 
resolvePathContext =
f_1343_95832_95866(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,95885,96037);

f_1343_95885_96036(                resolvePathContext, f_1343_95937_95961(), f_1343_95984_96008(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96096,96392);

Collection<string> 
providerPaths =
f_1343_96152_96391(f_1343_96152_96159(), path, false, resolvePathContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96412,96550) || true) && (f_1343_96416_96440(resolvePathContext)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,96412,96550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96490,96531);

context.Drive = f_1343_96506_96530(resolvePathContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,96412,96550);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96570,96655);

bool 
pathContainsGlobCharacters = f_1343_96604_96654(path)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96673,99382);
foreach(string providerPath in f_1343_96705_96718_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,96673,99382);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96824,96924) || true) && (f_1343_96828_96844(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,96824,96924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96894,96901);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,96824,96924);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,96948,99363) || true) && ((!pathContainsGlobCharacters ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 96953, 96991)||recurse)) &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 96952, 97052)&&f_1343_96996_97052(this, providerInstance, providerPath, context)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,96948,99363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,97283,97690);

f_1343_97283_97689(this, providerInstance, providerPath, string.Empty, returnContainers, includeMatcher, excludeMatcher, context, recurse, depth);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,96948,99363);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,96948,99363);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,98076,99340) || true) && (providerInstance is NavigationCmdletProvider)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,98076,99340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,98182,98407);

string 
childName =
f_1343_98234_98406(this, providerInstance, providerPath, context, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,98439,98687);

bool 
isIncludeMatch =
f_1343_98494_98686(childName, includeMatcher, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,98719,98968);

bool 
isExcludeMatch =
f_1343_98774_98967(childName, excludeMatcher, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99000,99165) || true) && (isIncludeMatch &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 99004, 99037)&&!isExcludeMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,99000,99165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99103,99134);

f_1343_99103_99133(                                context, childName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,99000,99165);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,98076,99340);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,98076,99340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99279,99313);

f_1343_99279_99312(                            context, providerPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,98076,99340);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,96948,99363);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,96673,99382);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,2710);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,2710);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,95376,101580);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,95376,101580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99503,99532);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99550,99575);

PSDriveInfo 
drive = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99595,99872);

string 
providerPath =
f_1343_99638_99871(f_1343_99638_99645(), (DynAbs.Tracing.TraceSender.Conditional_F1(1343, 99688, 99721)||((f_1343_99688_99721(context)&&DynAbs.Tracing.TraceSender.Conditional_F2(1343, 99724, 99728))||DynAbs.Tracing.TraceSender.Conditional_F3(1343, 99731, 99761)))?path :f_1343_99731_99761(path), context, out provider, out drive)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99892,99974);

ContainerCmdletProvider 
providerInstance = f_1343_99935_99973(this, provider)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,99994,100094) || true) && (drive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,99994,100094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,100053,100075);

context.Drive = drive;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,99994,100094);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,100114,100511) || true) && (!f_1343_100119_100169(providerInstance, providerPath, context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,100114,100511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,100211,100451);

ItemNotFoundException 
pathNotFound =
f_1343_100273_100450(providerPath, "PathNotFound", f_1343_100417_100449())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,100473,100492);

throw pathNotFound;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,100114,100511);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,100531,101565) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,100531,101565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,100732,101103);

f_1343_100732_101102(this, providerInstance, providerPath, string.Empty, returnContainers, includeMatcher, excludeMatcher, context, recurse, depth);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,100531,101565);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,100531,101565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,101372,101546);

f_1343_101372_101545(this, providerInstance, providerPath, returnContainers, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,100531,101565);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,95376,101580);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,94495,101591);

System.Management.Automation.PSArgumentNullException
f_1343_94774_94820(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 94774, 94820);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_95032_95047(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 95032, 95047);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
f_1343_94961_95097(System.Collections.ObjectModel.Collection<string>
globPatterns,System.Management.Automation.WildcardOptions
options)
{
var return_v = SessionStateUtilities.CreateWildcardsFromStrings( (System.Collections.Generic.IEnumerable<string>)globPatterns, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 94961, 95097);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_95294_95309(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 95294, 95309);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
f_1343_95223_95359(System.Collections.ObjectModel.Collection<string>
globPatterns,System.Management.Automation.WildcardOptions
options)
{
var return_v = SessionStateUtilities.CreateWildcardsFromStrings( (System.Collections.Generic.IEnumerable<string>)globPatterns, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 95223, 95359);
return return_v;
}


bool
f_1343_95380_95432(string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = LocationGlobber.ShouldPerformGlobbing( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 95380, 95432);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_95832_95866(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 95832, 95866);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_95937_95961()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 95937, 95961);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_95984_96008()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 95984, 96008);
return return_v;
}


int
f_1343_95885_96036(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 95885, 96036);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_96152_96159()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 96152, 96159);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_96152_96391(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 96152, 96391);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1343_96416_96440(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Drive ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 96416, 96440);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1343_96506_96530(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 96506, 96530);
return return_v;
}


bool
f_1343_96604_96654(string
path)
{
var return_v = LocationGlobber.StringContainsGlobCharacters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 96604, 96654);
return return_v;
}


bool
f_1343_96828_96844(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 96828, 96844);
return return_v;
}


bool
f_1343_96996_97052(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 96996, 97052);
return return_v;
}


int
f_1343_97283_97689(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
providerPath,string
relativePath,System.Management.Automation.ReturnContainers
returnContainers,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
includeMatcher,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
excludeMatcher,System.Management.Automation.CmdletProviderContext
context,bool
recurse,uint
depth)
{
this_param.DoGetChildNamesManually( providerInstance, providerPath, relativePath, returnContainers, includeMatcher, excludeMatcher, context, recurse, depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 97283, 97689);
return 0;
}


string
f_1343_98234_98406(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context,bool
acceptNonContainerProviders)
{
var return_v = this_param.GetChildName( providerInstance, path, context, acceptNonContainerProviders);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 98234, 98406);
return return_v;
}


bool
f_1343_98494_98686(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 98494, 98686);
return return_v;
}


bool
f_1343_98774_98967(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 98774, 98967);
return return_v;
}


int
f_1343_99103_99133(System.Management.Automation.CmdletProviderContext
this_param,string
obj)
{
this_param.WriteObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 99103, 99133);
return 0;
}


int
f_1343_99279_99312(System.Management.Automation.CmdletProviderContext
this_param,string
obj)
{
this_param.WriteObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 99279, 99312);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_96705_96718_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 96705, 96718);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_99638_99645()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 99638, 99645);
return return_v;
}


bool
f_1343_99688_99721(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.SuppressWildcardExpansion ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 99688, 99721);
return return_v;
}


string
f_1343_99731_99761(string
pattern)
{
var return_v = WildcardPattern.Unescape( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 99731, 99761);
return return_v;
}


string
f_1343_99638_99871(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 99638, 99871);
return return_v;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_99935_99973(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetContainerProviderInstance( provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 99935, 99973);
return return_v;
}


bool
f_1343_100119_100169(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExists( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 100119, 100169);
return return_v;
}


string
f_1343_100417_100449()
{
var return_v =                             SessionStateStrings.PathNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 100417, 100449);
return return_v;
}


System.Management.Automation.ItemNotFoundException
f_1343_100273_100450(string
path,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.ItemNotFoundException( path, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 100273, 100450);
return return_v;
}


int
f_1343_100732_101102(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
providerPath,string
relativePath,System.Management.Automation.ReturnContainers
returnContainers,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
includeMatcher,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
excludeMatcher,System.Management.Automation.CmdletProviderContext
context,bool
recurse,uint
depth)
{
this_param.DoGetChildNamesManually( (System.Management.Automation.Provider.CmdletProvider)providerInstance, providerPath, relativePath, returnContainers, includeMatcher, excludeMatcher, context, recurse, depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 100732, 101102);
return 0;
}


int
f_1343_101372_101545(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,System.Management.Automation.ReturnContainers
returnContainers,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildNames( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, returnContainers, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 101372, 101545);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,94495,101591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,94495,101591);
}
		}

private void DoGetChildNamesManually(
            CmdletProvider providerInstance,
            string providerPath,
            string relativePath,
            ReturnContainers returnContainers,
            Collection<WildcardPattern> includeMatcher,
            Collection<WildcardPattern> excludeMatcher,
            CmdletProviderContext context,
            bool recurse,
            uint depth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,103526,109448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,103960,104108);

f_1343_103960_104107(providerInstance != null, "The providerInstance should have been verified by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,104124,104257);

f_1343_104124_104256(providerPath != null, "The paths should have been verified by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,104273,104403);

f_1343_104273_104402(context != null, "The context should have been verified by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,104419,104610);

string 
newProviderPath =
f_1343_104461_104609(this, providerInstance, providerPath, relativePath, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,104626,104720);

CmdletProviderContext 
childNamesContext =
f_1343_104685_104719(context)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,104859,105055);

f_1343_104859_105054(this, providerInstance, newProviderPath, ReturnContainers.ReturnMatchingContainers, childNamesContext);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105075,105148);

Collection<PSObject> 
results = f_1343_105106_105147(childNamesContext)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105168,106372);
foreach(PSObject result in f_1343_105196_105203_I(results) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,105168,106372);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105309,105409) || true) && (f_1343_105313_105329(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,105309,105409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105379,105386);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,105309,105409);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105433,105475);

string 
name = f_1343_105447_105464(result)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105499,105597) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,105499,105597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105565,105574);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,105499,105597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105621,105832);

bool 
isIncludeMatch =
f_1343_105668_105831(name, includeMatcher, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105856,106353) || true) && (isIncludeMatch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,105856,106353);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,105924,106330) || true) && (!f_1343_105929_106105(name, excludeMatcher, false))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,105924,106330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,106163,106239);

string 
resultPath = f_1343_106183_106238(this, providerInstance, relativePath, name, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,106271,106303);

f_1343_106271_106302(
                            context, resultPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,105924,106330);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,105856,106353);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,105168,106372);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,1205);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,1205);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,106392,109314) || true) && (recurse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,106392,109314);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,106584,109295) || true) && (depth > 0)
) // this includes special case 'depth == uint.MaxValue' for unlimited recursion

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,106584,109295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,106726,106949);

f_1343_106726_106948(this, providerInstance, newProviderPath, ReturnContainers.ReturnAllContainers, childNamesContext);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,106977,107029);

results = f_1343_106987_107028(childNamesContext);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,107057,109272);
foreach(PSObject result in f_1343_107085_107092_I(results) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,107057,109272);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,107222,107346) || true) && (f_1343_107226_107242(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,107222,107346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,107308,107315);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,107222,107346);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,107378,107420);

string 
name = f_1343_107392_107409(result)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,107452,107574) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,107452,107574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,107534,107543);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,107452,107574);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,107690,107956);

string 
resultRelativePath =
f_1343_107751_107955(this, providerInstance, relativePath, name, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,108128,108428);

string 
resultProviderPath =
f_1343_108193_108427(this, providerInstance, providerPath, resultRelativePath, context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,108596,109245) || true) && (f_1343_108600_108662(this, providerInstance, resultProviderPath, context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,108596,109245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,108728,109214);

f_1343_108728_109213(this, providerInstance, providerPath, resultRelativePath, returnContainers, includeMatcher, excludeMatcher, context, true, depth - 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,108596,109245);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,107057,109272);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,2216);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,2216);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,106584,109295);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,106392,109314);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1343,109343,109437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,109383,109422);

f_1343_109383_109421(                childNamesContext);
DynAbs.Tracing.TraceSender.TraceExitFinally(1343,109343,109437);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,103526,109448);

int
f_1343_103960_104107(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 103960, 104107);
return 0;
}


int
f_1343_104124_104256(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 104124, 104256);
return 0;
}


int
f_1343_104273_104402(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 104273, 104402);
return 0;
}


string
f_1343_104461_104609(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
parent,string
child,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MakePath( providerInstance, parent, child, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 104461, 104609);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_104685_104719(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 104685, 104719);
return return_v;
}


int
f_1343_104859_105054(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.ReturnContainers
returnContainers,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildNames( providerInstance, path, returnContainers, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 104859, 105054);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_105106_105147(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 105106, 105147);
return return_v;
}


bool
f_1343_105313_105329(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 105313, 105329);
return return_v;
}


object
f_1343_105447_105464(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 105447, 105464);
return return_v;
}


bool
f_1343_105668_105831(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 105668, 105831);
return return_v;
}


bool
f_1343_105929_106105(string
text,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 105929, 106105);
return return_v;
}


string
f_1343_106183_106238(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
parent,string
child,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MakePath( providerInstance, parent, child, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 106183, 106238);
return return_v;
}


int
f_1343_106271_106302(System.Management.Automation.CmdletProviderContext
this_param,string
obj)
{
this_param.WriteObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 106271, 106302);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_105196_105203_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 105196, 105203);
return return_v;
}


int
f_1343_106726_106948(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.ReturnContainers
returnContainers,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildNames( providerInstance, path, returnContainers, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 106726, 106948);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_106987_107028(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 106987, 107028);
return return_v;
}


bool
f_1343_107226_107242(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 107226, 107242);
return return_v;
}


object
f_1343_107392_107409(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 107392, 107409);
return return_v;
}


string
f_1343_107751_107955(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
parent,string
child,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MakePath( providerInstance, parent, child, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 107751, 107955);
return return_v;
}


string
f_1343_108193_108427(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
parent,string
child,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MakePath( providerInstance, parent, child, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 108193, 108427);
return return_v;
}


bool
f_1343_108600_108662(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 108600, 108662);
return return_v;
}


int
f_1343_108728_109213(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
providerPath,string
relativePath,System.Management.Automation.ReturnContainers
returnContainers,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
includeMatcher,System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
excludeMatcher,System.Management.Automation.CmdletProviderContext
context,bool
recurse,uint
depth)
{
this_param.DoGetChildNamesManually( providerInstance, providerPath, relativePath, returnContainers, includeMatcher, excludeMatcher, context, recurse, depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 108728, 109213);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_107085_107092_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 107085, 107092);
return return_v;
}


int
f_1343_109383_109421(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.RemoveStopReferral();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 109383, 109421);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,103526,109448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,103526,109448);
}
		}

private void GetChildNames(
            CmdletProvider providerInstance,
            string path,
            ReturnContainers returnContainers,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,110598,112304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,110882,111036);

f_1343_110882_111035(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,111052,111182);

f_1343_111052_111181(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,111198,111334);

f_1343_111198_111333(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,111350,111464);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_111417_111463(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,111516,111587);

f_1343_111516_111586(                containerCmdletProvider, path, returnContainers, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,111616,111695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,111674,111680);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,111616,111695);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,111709,111795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,111774,111780);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,111709,111795);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,111809,111900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,111879,111885);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,111809,111900);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,111914,112293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,112002,112278);

throw f_1343_112008_112277(this, "GetChildNamesProviderException", f_1343_112116_112166(), f_1343_112189_112225(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,111914,112293);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,110598,112304);

int
f_1343_110882_111035(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 110882, 111035);
return 0;
}


int
f_1343_111052_111181(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 111052, 111181);
return 0;
}


int
f_1343_111198_111333(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 111198, 111333);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_111417_111463(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 111417, 111463);
return return_v;
}


int
f_1343_111516_111586(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,System.Management.Automation.ReturnContainers
returnContainers,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetChildNames( path, returnContainers, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 111516, 111586);
return 0;
}


string
f_1343_112116_112166()
{
var return_v =                     SessionStateStrings.GetChildNamesProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 112116, 112166);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_112189_112225(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 112189, 112225);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_112008_112277(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 112008, 112277);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,110598,112304);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,110598,112304);
}
		}

internal object GetChildNamesDynamicParameters(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,113728,116439);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,113870,113947) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,113870,113947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,113920,113932);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,113870,113947);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,113963,113992);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,114006,114045);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,114061,114148);

CmdletProviderContext 
newContext =
f_1343_114113_114147(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,114162,114294);

f_1343_114162_114293(            newContext, f_1343_114202_114226(), f_1343_114245_114269(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,114310,114350);

Collection<string> 
providerPaths = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,114402,114670);

providerPaths =
f_1343_114439_114669(f_1343_114439_114446(), path, true, newContext, out provider, out providerInstance);
            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,114699,115256);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,115146,115241) || true) && (providerInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,115146,115241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,115216,115222);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,115146,115241);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,114699,115256);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,115272,115293);

object 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,115307,116398) || true) && (providerPaths != null &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 115311, 115359)&&f_1343_115336_115355(providerPaths)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,115307,116398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,115468,115556);

result = f_1343_115477_115555(this, providerInstance, f_1343_115526_115542(providerPaths, 0), newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,115307,116398);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,115307,116398);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,115622,116383) || true) && (providerInstance != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,115622,116383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,115692,115717);

PSDriveInfo 
drive = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,116075,116161);

string 
providerPath = f_1343_116097_116160(f_1343_116097_116104(), path, context, out provider, out drive)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,116183,116364) || true) && (providerPath != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,116183,116364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,116257,116341);

result = f_1343_116266_116340(this, providerInstance, providerPath, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,116183,116364);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,115622,116383);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,115307,116398);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,116414,116428);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,113728,116439);

System.Management.Automation.CmdletProviderContext
f_1343_114113_114147(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 114113, 114147);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_114202_114226()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 114202, 114226);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_114245_114269()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 114245, 114269);
return return_v;
}


int
f_1343_114162_114293(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 114162, 114293);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_114439_114446()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 114439, 114446);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_114439_114669(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 114439, 114669);
return return_v;
}


int
f_1343_115336_115355(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 115336, 115355);
return return_v;
}


string
f_1343_115526_115542(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 115526, 115542);
return return_v;
}


object
f_1343_115477_115555(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildNamesDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 115477, 115555);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_116097_116104()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 116097, 116104);
return return_v;
}


string
f_1343_116097_116160(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 116097, 116160);
return return_v;
}


object
f_1343_116266_116340(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildNamesDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 116266, 116340);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,113728,116439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,113728,116439);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetChildNamesDynamicParameters(
             CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,117578,119359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,117834,117982);

f_1343_117834_117981(providerInstance != null, "Caller should validate providerId before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,117998,118128);

f_1343_117998_118127(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118144,118280);

f_1343_118144_118279(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118296,118410);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_118363_118409(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118426,118447);

object 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118499,118578);

result = f_1343_118508_118577(containerCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,118607,118686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118665,118671);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,118607,118686);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,118700,118786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118765,118771);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,118700,118786);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,118800,118891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118870,118876);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,118800,118891);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,118905,119318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,118993,119303);

throw f_1343_118999_119302(this, "GetChildNamesDynamicParametersProviderException", f_1343_119124_119191(), f_1343_119214_119250(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,118905,119318);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,119334,119348);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,117578,119359);

int
f_1343_117834_117981(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 117834, 117981);
return 0;
}


int
f_1343_117998_118127(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 117998, 118127);
return 0;
}


int
f_1343_118144_118279(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 118144, 118279);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_118363_118409(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 118363, 118409);
return return_v;
}


object
f_1343_118508_118577(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildNamesDynamicParameters( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 118508, 118577);
return return_v;
}


string
f_1343_119124_119191()
{
var return_v =                     SessionStateStrings.GetChildNamesDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 119124, 119191);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_119214_119250(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 119214, 119250);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_118999_119302(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 118999, 119302);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,117578,119359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,117578,119359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> RenameItem(string path, string newName, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,120917,121519);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,121023,121141) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,121023,121141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,121073,121126);

throw f_1343_121079_121125("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,121023,121141);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,121157,121238);

CmdletProviderContext 
context = f_1343_121189_121237(f_1343_121215_121236(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,121252,121274);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,121290,121325);

f_1343_121290_121324(this, path, newName, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,121341,121378);

f_1343_121341_121377(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,121469,121508);

return f_1343_121476_121507(context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,120917,121519);

System.Management.Automation.PSArgumentNullException
f_1343_121079_121125(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 121079, 121125);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_121215_121236(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 121215, 121236);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_121189_121237(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 121189, 121237);
return return_v;
}


int
f_1343_121290_121324(System.Management.Automation.SessionStateInternal
this_param,string
path,string
newName,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RenameItem( path, newName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 121290, 121324);
return 0;
}


int
f_1343_121341_121377(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 121341, 121377);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_121476_121507(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 121476, 121507);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,120917,121519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,120917,121519);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RenameItem(
            string path,
            string newName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,123230,124689);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,123379,123497) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,123379,123497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,123429,123482);

throw f_1343_123435_123481("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,123379,123497);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,123513,123542);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,123556,123595);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,123611,123872);

Collection<string> 
providerPaths =
f_1343_123663_123871(f_1343_123663_123670(), path, false, context, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,124011,124678) || true) && (f_1343_124015_124034(providerPaths)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,124011,124678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,124073,124138);

f_1343_124073_124137(this, providerInstance, f_1343_124102_124118(providerPaths, 0), newName, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,124011,124678);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,124011,124678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,124204,124397);

ArgumentException 
argException =
f_1343_124258_124396("path", f_1343_124352_124395())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,124417,124663);

f_1343_124417_124662(
                context, f_1343_124458_124661(argException, "RenameMultipleItemError", ErrorCategory.InvalidArgument, providerPaths));
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,124011,124678);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,123230,124689);

System.Management.Automation.PSArgumentNullException
f_1343_123435_123481(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 123435, 123481);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_123663_123670()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 123663, 123670);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_123663_123871(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 123663, 123871);
return return_v;
}


int
f_1343_124015_124034(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 124015, 124034);
return return_v;
}


string
f_1343_124102_124118(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 124102, 124118);
return return_v;
}


int
f_1343_124073_124137(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
newName,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RenameItem( providerInstance, path, newName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 124073, 124137);
return 0;
}


string
f_1343_124352_124395()
{
var return_v =                         SessionStateStrings.RenameMultipleItemError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 124352, 124395);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1343_124258_124396(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 124258, 124396);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_124458_124661(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Collections.ObjectModel.Collection<string>
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 124458, 124661);
return return_v;
}


int
f_1343_124417_124662(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 124417, 124662);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,123230,124689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,123230,124689);
}
		}

private void RenameItem(
            CmdletProvider providerInstance,
            string path,
            string newName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,125718,127384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,125980,126134);

f_1343_125980_126133(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,126150,126280);

f_1343_126150_126279(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,126296,126432);

f_1343_126296_126431(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,126448,126562);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_126515_126561(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,126614,126673);

f_1343_126614_126672(                containerCmdletProvider, path, newName, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,126702,126781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,126760,126766);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,126702,126781);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,126795,126881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,126860,126866);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,126795,126881);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,126895,126986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,126965,126971);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,126895,126986);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,127000,127373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,127088,127358);

throw f_1343_127094_127357(this, "RenameItemProviderException", f_1343_127199_127246(), f_1343_127269_127305(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,127000,127373);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,125718,127384);

int
f_1343_125980_126133(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 125980, 126133);
return 0;
}


int
f_1343_126150_126279(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 126150, 126279);
return 0;
}


int
f_1343_126296_126431(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 126296, 126431);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_126515_126561(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 126515, 126561);
return return_v;
}


int
f_1343_126614_126672(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
newName,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RenameItem( path, newName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 126614, 126672);
return 0;
}


string
f_1343_127199_127246()
{
var return_v =                     SessionStateStrings.RenameItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 127199, 127246);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_127269_127305(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 127269, 127305);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_127094_127357(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 127094, 127357);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,125718,127384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,125718,127384);
}
		}

internal object RenameItemDynamicParameters(
            string path,
            string newName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,128991,130162);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129159,129236) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,129159,129236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129209,129221);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,129159,129236);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129252,129281);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129295,129334);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129350,129437);

CmdletProviderContext 
newContext =
f_1343_129402_129436(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129451,129583);

f_1343_129451_129582(            newContext, f_1343_129491_129515(), f_1343_129534_129558(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129599,129862);

Collection<string> 
providerPaths =
f_1343_129651_129861(f_1343_129651_129658(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,129878,130123) || true) && (f_1343_129882_129901(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,129878,130123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,130016,130108);

return f_1343_130023_130107(this, providerInstance, f_1343_130069_130085(providerPaths, 0), newName, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,129878,130123);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,130139,130151);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,128991,130162);

System.Management.Automation.CmdletProviderContext
f_1343_129402_129436(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 129402, 129436);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_129491_129515()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 129491, 129515);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_129534_129558()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 129534, 129558);
return return_v;
}


int
f_1343_129451_129582(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 129451, 129582);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_129651_129658()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 129651, 129658);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_129651_129861(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 129651, 129861);
return return_v;
}


int
f_1343_129882_129901(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 129882, 129901);
return return_v;
}


string
f_1343_130069_130085(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 130069, 130085);
return return_v;
}


object
f_1343_130023_130107(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
newName,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RenameItemDynamicParameters( providerInstance, path, newName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 130023, 130107);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,128991,130162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,128991,130162);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object RenameItemDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string newName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,131389,133201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,131670,131824);

f_1343_131670_131823(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,131840,131970);

f_1343_131840_131969(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,131986,132122);

f_1343_131986_132121(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,132138,132252);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_132205_132251(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,132268,132289);

object 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,132341,132426);

result = f_1343_132350_132425(containerCmdletProvider, path, newName, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,132455,132534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,132513,132519);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,132455,132534);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,132548,132634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,132613,132619);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,132548,132634);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,132648,132739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,132718,132724);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,132648,132739);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,132753,133160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,132841,133145);

throw f_1343_132847_133144(this, "RenameItemDynamicParametersProviderException", f_1343_132969_133033(), f_1343_133056_133092(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,132753,133160);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,133176,133190);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,131389,133201);

int
f_1343_131670_131823(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 131670, 131823);
return 0;
}


int
f_1343_131840_131969(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 131840, 131969);
return 0;
}


int
f_1343_131986_132121(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 131986, 132121);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_132205_132251(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 132205, 132251);
return return_v;
}


object
f_1343_132350_132425(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
newName,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RenameItemDynamicParameters( path, newName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 132350, 132425);
return return_v;
}


string
f_1343_132969_133033()
{
var return_v =                     SessionStateStrings.RenameItemDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 132969, 133033);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_133056_133092(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 133056, 133092);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_132847_133144(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 132847, 133144);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,131389,133201);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,131389,133201);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> NewItem(string[] paths, string name, string type, object content, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,134878,135516);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,135010,135130) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,135010,135130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,135061,135115);

throw f_1343_135067_135114("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,135010,135130);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,135146,135227);

CmdletProviderContext 
context = f_1343_135178_135226(f_1343_135204_135225(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,135241,135263);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,135279,135324);

f_1343_135279_135323(this, paths, name, type, content, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,135340,135377);

f_1343_135340_135376(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,135466,135505);

return f_1343_135473_135504(context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,134878,135516);

System.Management.Automation.PSArgumentNullException
f_1343_135067_135114(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 135067, 135114);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_135204_135225(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 135204, 135225);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_135178_135226(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 135178, 135226);
return return_v;
}


int
f_1343_135279_135323(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
name,string
type,object
content,System.Management.Automation.CmdletProviderContext
context)
{
this_param.NewItem( paths, name, type, content, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 135279, 135323);
return 0;
}


int
f_1343_135340_135376(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 135340, 135376);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_135473_135504(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 135473, 135504);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,134878,135516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,134878,135516);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void NewItem(
            string[] paths,
            string name,
            string type,
            object content,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,137341,144047);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,137542,137662) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,137542,137662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,137593,137647);

throw f_1343_137599_137646("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,137542,137662);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,137678,144036);
foreach(string path in f_1343_137702_137707_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,137678,144036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,137741,137767);

string 
resolvePath = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,137785,138593) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,137785,138593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,137843,137891);

f_1343_137843_137890("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,137785,138593);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,137785,138593);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,137933,138593) || true) && (f_1343_137937_138013(path, (":" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.DirectorySeparatorChar).ToString(),1343,137958,137985)), StringComparison.Ordinal)||(DynAbs.Tracing.TraceSender.Expression_False(1343, 137937, 138122)||f_1343_138043_138122(                         path, (":" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.AltDirectorySeparatorChar).ToString(),1343,138064,138094)), StringComparison.Ordinal)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,137933,138593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138209,138228);

resolvePath = path;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,137933,138593);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,137933,138593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138422,138512);

char[] 
charsToTrim = { ' ', Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138534,138574);

resolvePath = f_1343_138548_138573(path, charsToTrim);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,137933,138593);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,137785,138593);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138613,138642);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138660,138682);

PSDriveInfo 
driveInfo
=default(PSDriveInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138700,138739);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138759,138819);

Collection<string> 
providerPaths = f_1343_138794_138818()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138905,139643) || true) && (f_1343_138909_138935(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,138905,139643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,138977,139099);

string 
providerPath =
f_1343_139024_139098(f_1343_139024_139031(), resolvePath, context, out provider, out driveInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,139123,139172);

providerInstance = f_1343_139142_139171(this, provider);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,139194,139226);

f_1343_139194_139225(                    providerPaths, providerPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,138905,139643);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,138905,139643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,139308,139624);

providerPaths =
f_1343_139349_139623(f_1343_139349_139356(), resolvePath, true, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,138905,139643);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,139663,144021);
foreach(string providerPath in f_1343_139695_139708_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,139663,144021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,139894,139929);

string 
composedPath = providerPath
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,139951,140126) || true) && (!f_1343_139956_139982(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,139951,140126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,140032,140103);

composedPath = f_1343_140047_140102(this, providerInstance, providerPath, name, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,139951,140126);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,140384,140852) || true) && (f_1343_140388_140455(f_1343_140388_140412(context))&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 140388, 140552)&&                        (providerInstance is Microsoft.PowerShell.Commands.FunctionProvider) )&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 140388, 140651)&&                        (f_1343_140582_140650(type, "Directory", StringComparison.OrdinalIgnoreCase))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,140384,140852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,140701,140829);

throw
f_1343_140736_140828(f_1343_140775_140827());
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,140384,140852);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,140876,140918);

bool 
isSymbolicJunctionOrHardLink = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141037,141071);

bool 
allowNonexistingPath = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141095,141658) || true) && (type != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,141095,141658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141161,141280);

WildcardPattern 
typeEvaluator = f_1343_141193_141279(type + "*", WildcardOptions.IgnoreCase | WildcardOptions.Compiled)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141308,141635) || true) && (f_1343_141312_141349(typeEvaluator, "symboliclink")||(DynAbs.Tracing.TraceSender.Expression_False(1343, 141312, 141386)||f_1343_141353_141386(typeEvaluator, "junction"))||(DynAbs.Tracing.TraceSender.Expression_False(1343, 141312, 141423)||f_1343_141390_141423(typeEvaluator, "hardlink")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,141308,141635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141481,141517);

isSymbolicJunctionOrHardLink = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141547,141608);

allowNonexistingPath = f_1343_141570_141607(typeEvaluator, "symboliclink");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,141308,141635);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,141095,141658);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141682,143907) || true) && (isSymbolicJunctionOrHardLink)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,141682,143907);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141764,141965) || true) && (content == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,141764,141965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141841,141938);

throw f_1343_141847_141937(f_1343_141886_141930(), path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,141764,141965);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,141993,142032);

string 
targetPath = f_1343_142013_142031(content)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,142060,142272) || true) && (f_1343_142064_142096(targetPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,142060,142272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,142154,142245);

throw f_1343_142160_142244(f_1343_142199_142231(), targetPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,142060,142272);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,142300,142335);

ProviderInfo 
targetProvider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,142361,142406);

CmdletProvider 
targetProviderInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,142434,142736);

var 
globbedTarget = f_1343_142454_142735(f_1343_142454_142461(), targetPath, allowNonexistingPath, context, out targetProvider, out targetProviderInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,142764,143030) || true) && (f_1343_142768_142853(f_1343_142783_142802(targetProvider), "filesystem", StringComparison.OrdinalIgnoreCase)!= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,142764,143030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,142916,143003);

throw f_1343_142922_143002(f_1343_142961_143001());
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,142764,143030);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,143058,143275) || true) && (f_1343_143062_143081(globbedTarget)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,143058,143275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,143143,143248);

throw f_1343_143149_143247(f_1343_143192_143234(), targetPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,143058,143275);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,143303,143511) || true) && (f_1343_143307_143326(globbedTarget)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,143303,143511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,143389,143484);

throw f_1343_143395_143483(f_1343_143438_143470(), targetPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,143303,143511);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,143714,143884) || true) && (f_1343_143718_143772(targetPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,143714,143884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,143830,143857);

content = f_1343_143840_143856(globbedTarget, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,143714,143884);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,141682,143907);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,143931,144002);

f_1343_143931_144001(this, providerInstance, composedPath, type, content, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,139663,144021);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,4359);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,4359);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,137678,144036);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,6359);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,6359);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1343,137341,144047);

System.Management.Automation.PSArgumentNullException
f_1343_137599_137646(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 137599, 137646);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_137843_137890(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 137843, 137890);
return return_v;
}


bool
f_1343_137937_138013(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 137937, 138013);
return return_v;
}


bool
f_1343_138043_138122(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 138043, 138122);
return return_v;
}


string
f_1343_138548_138573(string
this_param,params char[]
trimChars)
{
var return_v = this_param.TrimEnd( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 138548, 138573);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_138794_138818()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 138794, 138818);
return return_v;
}


bool
f_1343_138909_138935(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 138909, 138935);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_139024_139031()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 139024, 139031);
return return_v;
}


string
f_1343_139024_139098(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 139024, 139098);
return return_v;
}


System.Management.Automation.Provider.CmdletProvider
f_1343_139142_139171(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetProviderInstance( provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 139142, 139171);
return return_v;
}


int
f_1343_139194_139225(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 139194, 139225);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_139349_139356()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 139349, 139356);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_139349_139623(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 139349, 139623);
return return_v;
}


bool
f_1343_139956_139982(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 139956, 139982);
return return_v;
}


string
f_1343_140047_140102(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
parent,string
child,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MakePath( providerInstance, parent, child, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 140047, 140102);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_140388_140412(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 140388, 140412);
return return_v;
}


bool
f_1343_140388_140455(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.HasRunspaceEverUsedConstrainedLanguageMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 140388, 140455);
return return_v;
}


bool
f_1343_140582_140650(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 140582, 140650);
return return_v;
}


string
f_1343_140775_140827()
{
var return_v = SessionStateStrings.DriveCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 140775, 140827);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1343_140736_140828(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 140736, 140828);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1343_141193_141279(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 141193, 141279);
return return_v;
}


bool
f_1343_141312_141349(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 141312, 141349);
return return_v;
}


bool
f_1343_141353_141386(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 141353, 141386);
return return_v;
}


bool
f_1343_141390_141423(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 141390, 141423);
return return_v;
}


bool
f_1343_141570_141607(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 141570, 141607);
return return_v;
}


string
f_1343_141886_141930()
{
var return_v = SessionStateStrings.NewItemValueNotSpecified;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 141886, 141930);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_141847_141937(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 141847, 141937);
return return_v;
}


string?
f_1343_142013_142031(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 142013, 142031);
return return_v;
}


bool
f_1343_142064_142096(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 142064, 142096);
return return_v;
}


string
f_1343_142199_142231()
{
var return_v = SessionStateStrings.PathNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 142199, 142231);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_142160_142244(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 142160, 142244);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_142454_142461()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 142454, 142461);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_142454_142735(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 142454, 142735);
return return_v;
}


string
f_1343_142783_142802(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 142783, 142802);
return return_v;
}


int
f_1343_142768_142853(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 142768, 142853);
return return_v;
}


string
f_1343_142961_143001()
{
var return_v = SessionStateStrings.MustBeFileSystemPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 142961, 143001);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1343_142922_143002(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 142922, 143002);
return return_v;
}


int
f_1343_143062_143081(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 143062, 143081);
return return_v;
}


string
f_1343_143192_143234()
{
var return_v = SessionStateStrings.PathResolvedToMultiple;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 143192, 143234);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1343_143149_143247(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 143149, 143247);
return return_v;
}


int
f_1343_143307_143326(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 143307, 143326);
return return_v;
}


string
f_1343_143438_143470()
{
var return_v = SessionStateStrings.PathNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 143438, 143470);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1343_143395_143483(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 143395, 143483);
return return_v;
}


bool
f_1343_143718_143772(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 143718, 143772);
return return_v;
}


string
f_1343_143840_143856(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 143840, 143856);
return return_v;
}


int
f_1343_143931_144001(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
type,object
content,System.Management.Automation.CmdletProviderContext
context)
{
this_param.NewItemPrivate( providerInstance, path, type, content, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 143931, 144001);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_139695_139708_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 139695, 139708);
return return_v;
}


string[]
f_1343_137702_137707_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 137702, 137707);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,137341,144047);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,137341,144047);
}
		}

private void NewItemPrivate(
            CmdletProvider providerInstance,
            string path,
            string type,
            object content,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,145187,146728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,145479,145633);

f_1343_145479_145632(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,145649,145779);

f_1343_145649_145778(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,145795,145909);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_145862_145908(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,145961,146023);

f_1343_145961_146022(                containerCmdletProvider, path, type, content, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,146052,146131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,146110,146116);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,146052,146131);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,146145,146231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,146210,146216);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,146145,146231);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,146245,146336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,146315,146321);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,146245,146336);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,146350,146717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,146438,146702);

throw f_1343_146444_146701(this, "NewItemProviderException", f_1343_146546_146590(), f_1343_146613_146649(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,146350,146717);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,145187,146728);

int
f_1343_145479_145632(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 145479, 145632);
return 0;
}


int
f_1343_145649_145778(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 145649, 145778);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_145862_145908(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 145862, 145908);
return return_v;
}


int
f_1343_145961_146022(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
type,object
newItemValue,System.Management.Automation.CmdletProviderContext
context)
{
this_param.NewItem( path, type, newItemValue, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 145961, 146022);
return 0;
}


string
f_1343_146546_146590()
{
var return_v =                     SessionStateStrings.NewItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 146546, 146590);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_146613_146649(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 146613, 146649);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_146444_146701(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 146444, 146701);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,145187,146728);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,145187,146728);
}
		}

internal object NewItemDynamicParameters(
            string path,
            string type,
            object newItemValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,148380,149587);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,148576,148653) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,148576,148653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,148626,148638);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,148576,148653);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,148669,148698);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,148712,148751);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,148767,148854);

CmdletProviderContext 
newContext =
f_1343_148819_148853(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,148868,149000);

f_1343_148868_148999(            newContext, f_1343_148908_148932(), f_1343_148951_148975(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,149016,149279);

Collection<string> 
providerPaths =
f_1343_149068_149278(f_1343_149068_149075(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,149295,149548) || true) && (f_1343_149299_149318(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,149295,149548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,149433,149533);

return f_1343_149440_149532(this, providerInstance, f_1343_149483_149499(providerPaths, 0), type, newItemValue, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,149295,149548);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,149564,149576);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,148380,149587);

System.Management.Automation.CmdletProviderContext
f_1343_148819_148853(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 148819, 148853);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_148908_148932()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 148908, 148932);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_148951_148975()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 148951, 148975);
return return_v;
}


int
f_1343_148868_148999(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 148868, 148999);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_149068_149075()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 149068, 149075);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_149068_149278(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 149068, 149278);
return return_v;
}


int
f_1343_149299_149318(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 149299, 149318);
return return_v;
}


string
f_1343_149483_149499(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 149483, 149499);
return return_v;
}


object
f_1343_149440_149532(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
type,object
newItemValue,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.NewItemDynamicParameters( providerInstance, path, type, newItemValue, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 149440, 149532);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,148380,149587);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,148380,149587);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object NewItemDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string type,
            object newItemValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,150910,152750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,151219,151373);

f_1343_151219_151372(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,151389,151519);

f_1343_151389_151518(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,151535,151671);

f_1343_151535_151670(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,151687,151801);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_151754_151800(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,151817,151838);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,151888,151981);

result = f_1343_151897_151980(containerCmdletProvider, path, type, newItemValue, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,152010,152089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,152068,152074);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,152010,152089);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,152103,152189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,152168,152174);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,152103,152189);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,152203,152294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,152273,152279);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,152203,152294);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,152308,152709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,152396,152694);

throw f_1343_152402_152693(this, "NewItemDynamicParametersProviderException", f_1343_152521_152582(), f_1343_152605_152641(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,152308,152709);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,152725,152739);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,150910,152750);

int
f_1343_151219_151372(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 151219, 151372);
return 0;
}


int
f_1343_151389_151518(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 151389, 151518);
return 0;
}


int
f_1343_151535_151670(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 151535, 151670);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_151754_151800(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 151754, 151800);
return return_v;
}


object
f_1343_151897_151980(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
type,object
newItemValue,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.NewItemDynamicParameters( path, type, newItemValue, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 151897, 151980);
return return_v;
}


string
f_1343_152521_152582()
{
var return_v =                     SessionStateStrings.NewItemDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 152521, 152582);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_152605_152641(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 152605, 152641);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_152402_152693(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 152402, 152693);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,150910,152750);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,150910,152750);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool HasChildItems(string path, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,154200,154761);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154295,154413) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,154295,154413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154345,154398);

throw f_1343_154351_154397("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,154295,154413);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154429,154510);

CmdletProviderContext 
context = f_1343_154461_154509(f_1343_154487_154508(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154524,154546);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154560,154608);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154624,154667);

bool 
result = f_1343_154638_154666(this, path, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154683,154720);

f_1343_154683_154719(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,154736,154750);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,154200,154761);

System.Management.Automation.PSArgumentNullException
f_1343_154351_154397(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 154351, 154397);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_154487_154508(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 154487, 154508);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_154461_154509(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 154461, 154509);
return return_v;
}


bool
f_1343_154638_154666(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.HasChildItems( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 154638, 154666);
return return_v;
}


int
f_1343_154683_154719(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 154683, 154719);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,154200,154761);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,154200,154761);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool HasChildItems(
             string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,156228,157197);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156352,156470) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,156352,156470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156402,156455);

throw f_1343_156408_156454("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,156352,156470);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156486,156515);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156531,156570);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156584,156845);

Collection<string> 
providerPaths =
f_1343_156636_156844(f_1343_156636_156643(), path, false, context, out provider, out providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156861,156881);

bool 
result = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156895,157156);
foreach(string providerPath in f_1343_156927_156940_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,156895,157156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,156974,157038);

result = f_1343_156983_157037(this, providerInstance, providerPath, context);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,157056,157141) || true) && (result == true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,157056,157141);
DynAbs.Tracing.TraceSender.TraceBreak(1343,157116,157122);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,157056,157141);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,156895,157156);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,262);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,262);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,157172,157186);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,156228,157197);

System.Management.Automation.PSArgumentNullException
f_1343_156408_156454(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 156408, 156454);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_156636_156643()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 156636, 156643);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_156636_156844(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 156636, 156844);
return return_v;
}


bool
f_1343_156983_157037(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.HasChildItems( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 156983, 157037);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_156927_156940_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 156927, 156940);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,156228,157197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,156228,157197);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool HasChildItems(
            string providerId,
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,158015,158691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158126,158146);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158162,158302) || true) && (f_1343_158166_158198(providerId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,158162,158302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158232,158287);

throw f_1343_158238_158286("providerId");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,158162,158302);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158318,158436) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,158318,158436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158368,158421);

throw f_1343_158374_158420("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,158318,158436);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158452,158533);

CmdletProviderContext 
context = f_1343_158484_158532(f_1343_158510_158531(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158549,158599);

result = f_1343_158558_158598(this, providerId, path, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158613,158650);

f_1343_158613_158649(            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,158666,158680);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,158015,158691);

bool
f_1343_158166_158198(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 158166, 158198);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1343_158238_158286(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 158238, 158286);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1343_158374_158420(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 158374, 158420);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_158510_158531(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 158510, 158531);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_158484_158532(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 158484, 158532);
return return_v;
}


bool
f_1343_158558_158598(System.Management.Automation.SessionStateInternal
this_param,string
providerId,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.HasChildItems( providerId, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 158558, 158598);
return return_v;
}


int
f_1343_158613_158649(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 158613, 158649);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,158015,158691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,158015,158691);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool HasChildItems(
            string providerId,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,159628,159948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,159783,159867);

ContainerCmdletProvider 
providerInstance = f_1343_159826_159866(this, providerId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,159883,159937);

return f_1343_159890_159936(this, providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,159628,159948);

System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_159826_159866(System.Management.Automation.SessionStateInternal
this_param,string
providerId)
{
var return_v = this_param.GetContainerProviderInstance( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 159826, 159866);
return return_v;
}


bool
f_1343_159890_159936(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.HasChildItems( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 159890, 159936);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,159628,159948);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,159628,159948);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool HasChildItems(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,160899,162614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,161135,161289);

f_1343_161135_161288(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,161305,161435);

f_1343_161305_161434(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,161451,161587);

f_1343_161451_161586(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,161603,161717);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_161670_161716(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,161733,161753);

bool 
result = false
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,161805,161867);

result = f_1343_161814_161866(containerCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,161896,161975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,161954,161960);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,161896,161975);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,161989,162075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,162054,162060);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,161989,162075);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,162089,162180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,162159,162165);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,162089,162180);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,162194,162573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,162282,162558);

throw f_1343_162288_162557(this, "HasChildItemsProviderException", f_1343_162396_162446(), f_1343_162469_162505(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,162194,162573);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,162589,162603);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,160899,162614);

int
f_1343_161135_161288(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 161135, 161288);
return 0;
}


int
f_1343_161305_161434(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 161305, 161434);
return 0;
}


int
f_1343_161451_161586(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 161451, 161586);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_161670_161716(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 161670, 161716);
return return_v;
}


bool
f_1343_161814_161866(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.HasChildItems( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 161814, 161866);
return return_v;
}


string
f_1343_162396_162446()
{
var return_v =                     SessionStateStrings.HasChildItemsProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 162396, 162446);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_162469_162505(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 162469, 162505);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_162288_162557(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 162288, 162557);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,160899,162614);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,160899,162614);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> CopyItem(string[] paths,
                                               string copyPath,
                                               bool recurse,
                                               CopyContainers copyContainers,
                                               bool force,
                                               bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,164442,165472);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,164853,164973) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,164853,164973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,164904,164958);

throw f_1343_164910_164957("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,164853,164973);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,164989,165082) || true) && (copyPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,164989,165082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,165043,165067);

copyPath = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,164989,165082);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,165098,165179);

CmdletProviderContext 
context = f_1343_165130_165178(f_1343_165156_165177(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,165193,165215);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,165229,165277);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,165293,165353);

f_1343_165293_165352(this, paths, copyPath, recurse, copyContainers, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,165369,165406);

f_1343_165369_165405(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,165422,165461);

return f_1343_165429_165460(context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,164442,165472);

System.Management.Automation.PSArgumentNullException
f_1343_164910_164957(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 164910, 164957);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_165156_165177(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 165156, 165177);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1343_165130_165178(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 165130, 165178);
return return_v;
}


int
f_1343_165293_165352(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
copyPath,bool
recurse,System.Management.Automation.CopyContainers
copyContainers,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyItem( paths, copyPath, recurse, copyContainers, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 165293, 165352);
return 0;
}


int
f_1343_165369_165405(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 165369, 165405);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1343_165429_165460(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 165429, 165460);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,164442,165472);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,164442,165472);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void CopyItem(
            string[] paths,
            string copyPath,
            bool recurse,
            CopyContainers copyContainers,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,167226,179084);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,167448,167568) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,167448,167568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,167499,167553);

throw f_1343_167505_167552("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,167448,167568);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,167584,167677) || true) && (copyPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,167584,167677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,167638,167662);

copyPath = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,167584,167677);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,167762,167793);

PSDriveInfo 
unusedDrive = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,167807,167847);

ProviderInfo 
destinationProvider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,167861,168018);

Microsoft.PowerShell.Commands.CopyItemDynamicParameters 
dynamicParams = f_1343_167933_167958(context)as Microsoft.PowerShell.Commands.CopyItemDynamicParameters
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168032,168065);

bool 
destinationIsRemote = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168079,168107);

bool 
sourceIsRemote = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168121,168152);

string 
providerDestinationPath
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168166,168201);

Runspaces.PSSession 
session = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168217,168668) || true) && (dynamicParams != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,168217,168668);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168276,168454) || true) && (f_1343_168280_168305(dynamicParams)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,168276,168454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168355,168377);

sourceIsRemote = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168399,168435);

session = f_1343_168409_168434(dynamicParams);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,168276,168454);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168474,168653) || true) && (f_1343_168478_168501(dynamicParams)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,168474,168653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168551,168578);

destinationIsRemote = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168600,168634);

session = f_1343_168610_168633(dynamicParams);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,168474,168653);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,168217,168668);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168684,169224) || true) && (sourceIsRemote &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 168688, 168725)&&destinationIsRemote))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,168684,169224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,168759,169184);

f_1343_168759_169183(                context, f_1343_168778_169182(f_1343_168823_169021(f_1343_168878_169020(f_1343_168892_168941(), f_1343_168943_168991(), "FromSession", "ToSession")), "InvalidInput", ErrorCategory.InvalidArgument, dynamicParams));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,169202,169209);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,168684,169224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,169366,169408);

PSLanguageMode? 
remoteLanguageMode = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,169422,169641) || true) && (sourceIsRemote ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 169426, 169463)||destinationIsRemote))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,169422,169641);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,169497,169626) || true) && (!f_1343_169502_169558(this, session, context, out remoteLanguageMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,169497,169626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,169600,169607);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,169497,169626);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,169422,169641);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,169657,171196) || true) && (!destinationIsRemote)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,169657,171196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,169715,169943);

providerDestinationPath =
f_1343_169761_169942(f_1343_169761_169768(), copyPath, context, out destinationProvider, out unusedDrive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,169657,171196);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,169657,171196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,170062,170097);

providerDestinationPath = copyPath;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,170115,170946) || true) && (f_1343_170119_170164(providerDestinationPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,170115,170946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,170206,170898);

f_1343_170206_170897(                    context, f_1343_170225_170896(f_1343_170287_170662(f_1343_170367_170661(f_1343_170435_170484(), f_1343_170539_170592(), "Destination")), "CopyItemRemoteDestinationIsNullOrEmpty", ErrorCategory.InvalidArgument, providerDestinationPath));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,170920,170927);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,170115,170946);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,170966,171079);

string 
root = f_1343_170980_171078(this, providerDestinationPath, session, context, remoteLanguageMode, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171097,171181) || true) && (root == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,171097,171181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171155,171162);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,171097,171181);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,169657,171196);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171212,171289);

f_1343_171212_171288(
            s_tracer, "providerDestinationPath = {0}", providerDestinationPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171305,171334);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171348,171387);

CmdletProvider 
providerInstance = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171403,179073);
foreach(string path in f_1343_171427_171432_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,171403,179073);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171466,171597) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,171466,171597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171524,171578);

throw f_1343_171530_171577("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,171466,171597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171617,171650);

Collection<string> 
providerPaths
=default(Collection<string>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171670,172590) || true) && (sourceIsRemote)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,171670,172590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171787,171880);

string 
root = f_1343_171801_171879(this, path, session, context, remoteLanguageMode, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171902,171998) || true) && (root == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,171902,171998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,171968,171975);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,171902,171998);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,172022,172114);

providerInstance = f_1343_172041_172113(f_1343_172041_172079(f_1343_172041_172070(f_1343_172041_172057())), "FileSystem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,172136,172177);

providerPaths = f_1343_172152_172176();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,172199,172223);

f_1343_172199_172222(                    providerPaths, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,171670,172590);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,171670,172590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,172305,172571);

providerPaths =
f_1343_172342_172570(f_1343_172342_172349(), path, false, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,171670,172590);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,172757,173462) || true) && (!sourceIsRemote &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 172761, 172800)&&!destinationIsRemote )&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 172761, 172835)&&provider != destinationProvider))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,172757,173462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,172877,173102);

ArgumentException 
argException =
f_1343_172935_173101("path", f_1343_173037_173100())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,173126,173412);

f_1343_173126_173411(
                    context, f_1343_173171_173410(argException, "CopyItemSourceAndDestinationNotSameProvider", ErrorCategory.InvalidArgument, providerPaths));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,173436,173443);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,172757,173462);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,173482,173518);

bool 
destinationIsContainer = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,173538,173891) || true) && (!destinationIsRemote)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,173538,173891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,173604,173773);

destinationIsContainer = f_1343_173629_173772(this, providerInstance, providerDestinationPath, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,173797,173872);

f_1343_173797_173871(
                    s_tracer, "destinationIsContainer = {0}", destinationIsContainer);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,173538,173891);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,173911,179058);
foreach(string providerPath in f_1343_173943_173956_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,173911,179058);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174062,174162) || true) && (f_1343_174066_174082(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,174062,174162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174132,174139);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,174062,174162);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174186,174565) || true) && (sourceIsRemote ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 174190, 174227)||destinationIsRemote))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,174186,174565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174277,174507);

f_1343_174277_174506(this, providerInstance, providerPath, providerDestinationPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174533,174542);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,174186,174565);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174589,174785);

bool 
sourceIsContainer =
f_1343_174640_174784(this, providerInstance, providerPath, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174809,174874);

f_1343_174809_174873(
                    s_tracer, "sourceIsContainer = {0}", sourceIsContainer);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174898,179039) || true) && (sourceIsContainer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,174898,179039);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,174969,178627) || true) && (destinationIsContainer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,174969,178627);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,175053,176993) || true) && (!recurse &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 175057, 175131)&&copyContainers == CopyContainers.CopyChildrenOfTargetContainer))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,175053,176993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,175361,175609);

Exception 
e =
f_1343_175412_175608("path", f_1343_175538_175607())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,175645,175931);

f_1343_175645_175930(
                                context, f_1343_175664_175929(e, "CopyContainerToContainerWithoutRecurseOrContainer", ErrorCategory.InvalidArgument, providerPath));
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,175053,176993);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,175053,176993);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,175997,176993) || true) && (recurse &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 176001, 176074)&&copyContainers == CopyContainers.CopyChildrenOfTargetContainer))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,175997,176993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,176224,176468);

f_1343_176224_176467(this, providerInstance, providerPath, providerDestinationPath, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,175997,176993);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,175997,176993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,176692,176962);

f_1343_176692_176961(this, providerInstance, providerPath, providerDestinationPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,175997,176993);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,175053,176993);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,174969,178627);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,174969,178627);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,177249,178600) || true) && (f_1343_177253_177315(this, providerInstance, providerDestinationPath, context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,177249,178600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,177561,177788);

Exception 
e =
f_1343_177612_177787("path", f_1343_177738_177786())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,177824,178089);

f_1343_177824_178088(
                                context, f_1343_177843_178087(e, "CopyContainerItemToLeafError", ErrorCategory.InvalidArgument, providerPath));
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,177249,178600);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,177249,178600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,178299,178569);

f_1343_178299_178568(this, providerInstance, providerPath, providerDestinationPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,177249,178600);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,174969,178627);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,174898,179039);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,174898,179039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,178786,179016);

f_1343_178786_179015(this, providerInstance, providerPath, providerDestinationPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,174898,179039);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,173911,179058);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,5148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,5148);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1343,171403,179073);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,7671);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,7671);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1343,167226,179084);

System.Management.Automation.PSArgumentNullException
f_1343_167505_167552(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 167505, 167552);
return return_v;
}


object
f_1343_167933_167958(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.DynamicParameters ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 167933, 167958);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1343_168280_168305(Microsoft.PowerShell.Commands.CopyItemDynamicParameters
this_param)
{
var return_v = this_param.FromSession ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 168280, 168305);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1343_168409_168434(Microsoft.PowerShell.Commands.CopyItemDynamicParameters
this_param)
{
var return_v = this_param.FromSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 168409, 168434);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1343_168478_168501(Microsoft.PowerShell.Commands.CopyItemDynamicParameters
this_param)
{
var return_v = this_param.ToSession ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 168478, 168501);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1343_168610_168633(Microsoft.PowerShell.Commands.CopyItemDynamicParameters
this_param)
{
var return_v = this_param.ToSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 168610, 168633);
return return_v;
}


System.Globalization.CultureInfo
f_1343_168892_168941()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 168892, 168941);
return return_v;
}


string
f_1343_168943_168991()
{
var return_v = SessionStateStrings.CopyItemFromSessionToSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 168943, 168991);
return return_v;
}


string
f_1343_168878_169020(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 168878, 169020);
return return_v;
}


System.ArgumentException
f_1343_168823_169021(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 168823, 169021);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_168778_169182(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.CopyItemDynamicParameters
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 168778, 169182);
return return_v;
}


int
f_1343_168759_169183(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 168759, 169183);
return 0;
}


bool
f_1343_169502_169558(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.PSLanguageMode?
languageMode)
{
var return_v = this_param.isValidSession( session, context, out languageMode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 169502, 169558);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1343_169761_169768()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 169761, 169768);
return return_v;
}


string
f_1343_169761_169942(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 169761, 169942);
return return_v;
}


bool
f_1343_170119_170164(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 170119, 170164);
return return_v;
}


System.Globalization.CultureInfo
f_1343_170435_170484()
{
var return_v =                                                     System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 170435, 170484);
return return_v;
}


string
f_1343_170539_170592()
{
var return_v =                                                     SessionStateStrings.CopyItemRemotelyPathIsNullOrEmpty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 170539, 170592);
return return_v;
}


string
f_1343_170367_170661(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 170367, 170661);
return return_v;
}


System.ArgumentNullException
f_1343_170287_170662(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 170287, 170662);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_170225_170896(System.ArgumentNullException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 170225, 170896);
return return_v;
}


int
f_1343_170206_170897(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 170206, 170897);
return 0;
}


string
f_1343_170980_171078(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.CmdletProviderContext
context,System.Management.Automation.PSLanguageMode?
languageMode,bool
sourceIsRemote)
{
var return_v = this_param.ValidateRemotePathAndGetRoot( path, session, context, languageMode, sourceIsRemote);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 170980, 171078);
return return_v;
}


int
f_1343_171212_171288(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 171212, 171288);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1343_171530_171577(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 171530, 171577);
return return_v;
}


string
f_1343_171801_171879(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.CmdletProviderContext
context,System.Management.Automation.PSLanguageMode?
languageMode,bool
sourceIsRemote)
{
var return_v = this_param.ValidateRemotePathAndGetRoot( path, session, context, languageMode, sourceIsRemote);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 171801, 171879);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_172041_172057()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 172041, 172057);
return return_v;
}


System.Management.Automation.SessionState
f_1343_172041_172070(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 172041, 172070);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1343_172041_172079(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 172041, 172079);
return return_v;
}


System.Management.Automation.Provider.CmdletProvider
f_1343_172041_172113(System.Management.Automation.SessionStateInternal
this_param,string
providerId)
{
var return_v = this_param.GetProviderInstance( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 172041, 172113);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_172152_172176()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 172152, 172176);
return return_v;
}


int
f_1343_172199_172222(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 172199, 172222);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_172342_172349()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 172342, 172349);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_172342_172570(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 172342, 172570);
return return_v;
}


string
f_1343_173037_173100()
{
var return_v =                             SessionStateStrings.CopyItemSourceAndDestinationNotSameProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 173037, 173100);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1343_172935_173101(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 172935, 173101);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_173171_173410(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Collections.ObjectModel.Collection<string>
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 173171, 173410);
return return_v;
}


int
f_1343_173126_173411(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 173126, 173411);
return 0;
}


bool
f_1343_173629_173772(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 173629, 173772);
return return_v;
}


int
f_1343_173797_173871(System.Management.Automation.PSTraceSource
this_param,string
format,bool
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 173797, 173871);
return 0;
}


bool
f_1343_174066_174082(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 174066, 174082);
return return_v;
}


int
f_1343_174277_174506(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
copyPath,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyItem( providerInstance, path, copyPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 174277, 174506);
return 0;
}


bool
f_1343_174640_174784(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.IsItemContainer( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 174640, 174784);
return return_v;
}


int
f_1343_174809_174873(System.Management.Automation.PSTraceSource
this_param,string
format,bool
arg1)
{
this_param.WriteLine( format, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 174809, 174873);
return 0;
}


string
f_1343_175538_175607()
{
var return_v =                                         SessionStateStrings.CopyContainerToContainerWithoutRecurseOrContainer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 175538, 175607);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1343_175412_175608(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 175412, 175608);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_175664_175929(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 175664, 175929);
return return_v;
}


int
f_1343_175645_175930(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 175645, 175930);
return 0;
}


int
f_1343_176224_176467(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
sourcePath,string
destinationPath,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyRecurseToSingleContainer( providerInstance, sourcePath, destinationPath, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 176224, 176467);
return 0;
}


int
f_1343_176692_176961(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
copyPath,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyItem( providerInstance, path, copyPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 176692, 176961);
return 0;
}


bool
f_1343_177253_177315(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExists( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 177253, 177315);
return return_v;
}


string
f_1343_177738_177786()
{
var return_v =                                         SessionStateStrings.CopyContainerItemToLeafError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 177738, 177786);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1343_177612_177787(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 177612, 177787);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_177843_178087(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 177843, 178087);
return return_v;
}


int
f_1343_177824_178088(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 177824, 178088);
return 0;
}


int
f_1343_178299_178568(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
copyPath,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyItem( providerInstance, path, copyPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 178299, 178568);
return 0;
}


int
f_1343_178786_179015(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
copyPath,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyItem( providerInstance, path, copyPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 178786, 179015);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_173943_173956_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 173943, 173956);
return return_v;
}


string[]
f_1343_171427_171432_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 171427, 171432);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,167226,179084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,167226,179084);
}
		}

private void CopyItem(
            CmdletProvider providerInstance,
            string path,
            string copyPath,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,180275,181971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,180563,180717);

f_1343_180563_180716(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,180733,180863);

f_1343_180733_180862(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,180879,181015);

f_1343_180879_181014(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,181031,181145);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_181098_181144(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,181197,181264);

f_1343_181197_181263(                containerCmdletProvider, path, copyPath, recurse, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,181293,181372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,181351,181357);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,181293,181372);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,181386,181472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,181451,181457);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,181386,181472);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,181486,181577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,181556,181562);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,181486,181577);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,181591,181960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,181679,181945);

throw f_1343_181685_181944(this, "CopyItemProviderException", f_1343_181788_181833(), f_1343_181856_181892(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,181591,181960);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,180275,181971);

int
f_1343_180563_180716(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 180563, 180716);
return 0;
}


int
f_1343_180733_180862(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 180733, 180862);
return 0;
}


int
f_1343_180879_181014(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 180879, 181014);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_181098_181144(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 181098, 181144);
return return_v;
}


int
f_1343_181197_181263(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
copyPath,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyItem( path, copyPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 181197, 181263);
return 0;
}


string
f_1343_181788_181833()
{
var return_v =                     SessionStateStrings.CopyItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 181788, 181833);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_181856_181892(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 181856, 181892);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_181685_181944(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 181685, 181944);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,180275,181971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,180275,181971);
}
		}

private void CopyRecurseToSingleContainer(
            CmdletProvider providerInstance,
            string sourcePath,
            string destinationPath,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,183034,185008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,183260,183408);

f_1343_183260_183407(providerInstance != null, "The providerInstance should have been verified by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,183424,183575);

f_1343_183424_183574(!f_1343_183466_183498(sourcePath), "The sourcePath should have been verified by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,183591,183752);

f_1343_183591_183751(!f_1343_183633_183670(destinationPath), "The destinationPath should have been verified by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,183768,183898);

f_1343_183768_183897(context != null, "The context should have been verified by the caller");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,183914,184030);

ContainerCmdletProvider 
containerProviderInstance =
f_1343_183983_184029(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,184157,184389);

Collection<string> 
children =
f_1343_184204_184388(this, new string[] { sourcePath }, ReturnContainers.ReturnMatchingContainers, true, uint.MaxValue, false, false)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,184405,184997);
foreach(string childName in f_1343_184434_184442_I(children) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,184405,184997);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,184536,184624) || true) && (f_1343_184540_184556(context))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,184536,184624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,184598,184605);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,184536,184624);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,184727,184818);

string 
childPath = f_1343_184746_184817(this, f_1343_184755_184784(providerInstance), sourcePath, childName, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,184902,184982);

f_1343_184902_184981(this, containerProviderInstance, childPath, destinationPath, false, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,184405,184997);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1343,1,593);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1343,1,593);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1343,183034,185008);

int
f_1343_183260_183407(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 183260, 183407);
return 0;
}


bool
f_1343_183466_183498(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 183466, 183498);
return return_v;
}


int
f_1343_183424_183574(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 183424, 183574);
return 0;
}


bool
f_1343_183633_183670(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 183633, 183670);
return return_v;
}


int
f_1343_183591_183751(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 183591, 183751);
return 0;
}


int
f_1343_183768_183897(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 183768, 183897);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_183983_184029(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 183983, 184029);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_184204_184388(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.ReturnContainers
returnContainers,bool
recurse,uint
depth,bool
force,bool
literalPath)
{
var return_v = this_param.GetChildNames( paths, returnContainers, recurse, depth, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 184204, 184388);
return return_v;
}


bool
f_1343_184540_184556(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 184540, 184556);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_184755_184784(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 184755, 184784);
return return_v;
}


string
f_1343_184746_184817(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider,string
parent,string
child,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MakePath( provider, parent, child, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 184746, 184817);
return return_v;
}


int
f_1343_184902_184981(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.ContainerCmdletProvider
providerInstance,string
path,string
copyPath,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyItem( (System.Management.Automation.Provider.CmdletProvider)providerInstance, path, copyPath, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 184902, 184981);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1343_184434_184442_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 184434, 184442);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,183034,185008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,183034,185008);
}
		}

internal object CopyItemDynamicParameters(
            string path,
            string destination,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,186660,189505);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,186857,186934) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,186857,186934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,186907,186919);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,186857,186934);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,186950,186979);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,186993,187032);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,187048,187135);

CmdletProviderContext 
newContext =
f_1343_187100_187134(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,187149,187281);

f_1343_187149_187280(            newContext, f_1343_187189_187213(), f_1343_187232_187256(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,187297,187324);

string 
providerPath = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,187338,187372);

bool 
pathNotFoundOnClient = false
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,187422,187709);

Collection<string> 
providerPaths =
f_1343_187478_187708(f_1343_187478_187485(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,187729,187811) || true) && (f_1343_187733_187752(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,187729,187811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,187779,187811);

providerPath = f_1343_187794_187810(providerPaths, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,187729,187811);
}
            }
            catch (DriveNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,187840,188095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,188052,188080);

pathNotFoundOnClient = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,187840,188095);
            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,188109,188361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,188318,188346);

pathNotFoundOnClient = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,188109,188361);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,188377,189203) || true) && (pathNotFoundOnClient)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,188377,189203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,188859,188909);

var 
fileSystemProviders = f_1343_188885_188908(f_1343_188885_188894(), "FileSystem")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,188927,189188) || true) && (f_1343_188931_188956(fileSystemProviders)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,188927,189188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,189002,189022);

providerPath = path;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,189044,189169);

providerInstance = f_1343_189063_189168(f_1343_189063_189098(f_1343_189063_189079()), f_1343_189145_189167(fileSystemProviders, 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,188927,189188);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,188377,189203);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,189219,189466) || true) && (providerPath != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,189219,189466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,189352,189451);

return f_1343_189359_189450(this, providerInstance, providerPath, destination, recurse, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,189219,189466);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,189482,189494);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,186660,189505);

System.Management.Automation.CmdletProviderContext
f_1343_187100_187134(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 187100, 187134);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_187189_187213()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 187189, 187213);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_187232_187256()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 187232, 187256);
return return_v;
}


int
f_1343_187149_187280(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 187149, 187280);
return 0;
}


System.Management.Automation.LocationGlobber
f_1343_187478_187485()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 187478, 187485);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1343_187478_187708(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 187478, 187708);
return return_v;
}


int
f_1343_187733_187752(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 187733, 187752);
return return_v;
}


string
f_1343_187794_187810(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 187794, 187810);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
f_1343_188885_188894()
{
var return_v = Providers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 188885, 188894);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
f_1343_188885_188908(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 188885, 188908);
return return_v;
}


int
f_1343_188931_188956(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 188931, 188956);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1343_189063_189079()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 189063, 189079);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1343_189063_189098(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 189063, 189098);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_189145_189167(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 189145, 189167);
return return_v;
}


System.Management.Automation.Provider.CmdletProvider
f_1343_189063_189168(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetProviderInstance( provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 189063, 189168);
return return_v;
}


object
f_1343_189359_189450(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
destination,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.CopyItemDynamicParameters( providerInstance, path, destination, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 189359, 189450);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,186660,189505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,186660,189505);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object CopyItemDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string destination,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,190869,192715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,191179,191333);

f_1343_191179_191332(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,191349,191479);

f_1343_191349_191478(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,191495,191631);

f_1343_191495_191630(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,191647,191761);

ContainerCmdletProvider 
containerCmdletProvider =
f_1343_191714_191760(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,191777,191798);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,191848,191944);

result = f_1343_191857_191943(containerCmdletProvider, path, destination, recurse, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,191973,192052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,192031,192037);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,191973,192052);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,192066,192152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,192131,192137);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,192066,192152);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,192166,192257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,192236,192242);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,192166,192257);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1343,192271,192674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,192359,192659);

throw f_1343_192365_192658(this, "CopyItemDynamicParametersProviderException", f_1343_192485_192547(), f_1343_192570_192606(containerCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1343,192271,192674);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,192690,192704);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,190869,192715);

int
f_1343_191179_191332(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 191179, 191332);
return 0;
}


int
f_1343_191349_191478(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 191349, 191478);
return 0;
}


int
f_1343_191495_191630(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 191495, 191630);
return 0;
}


System.Management.Automation.Provider.ContainerCmdletProvider
f_1343_191714_191760(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetContainerProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 191714, 191760);
return return_v;
}


object
f_1343_191857_191943(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
destination,bool
recurse,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.CopyItemDynamicParameters( path, destination, recurse, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 191857, 191943);
return return_v;
}


string
f_1343_192485_192547()
{
var return_v =                     SessionStateStrings.CopyItemDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 192485, 192547);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1343_192570_192606(System.Management.Automation.Provider.ContainerCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 192570, 192606);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1343_192365_192658(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 192365, 192658);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,190869,192715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,190869,192715);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string ValidateRemotePathAndGetRoot(string path, Runspaces.PSSession session, CmdletProviderContext context, PSLanguageMode? languageMode, bool sourceIsRemote)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,192834,198251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193026,193046);

Hashtable 
op = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193062,195504);
using(PowerShell 
ps = f_1343_193085_193104()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193138,193169);

ps.Runspace = f_1343_193152_193168(session);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193479,195191) || true) && (f_1343_193483_193504(languageMode)&&(DynAbs.Tracing.TraceSender.Expression_True(1343, 193483, 193638)&&                    (f_1343_193530_193548(languageMode)== PSLanguageMode.ConstrainedLanguage ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 193530, 193637)||f_1343_193590_193608(languageMode)== PSLanguageMode.NoLanguage))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,193479,195191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193680,193746);

var 
psRemoteUtilsName = CopyFileRemoteUtils.PSCopyRemoteUtilsName
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193768,193799);

ps.Runspace = f_1343_193782_193798(session);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193821,193881);

f_1343_193821_193880(f_1343_193821_193849(                    ps, "Get-Command"), psRemoteUtilsName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193903,193934);

var 
result = f_1343_193916_193933(ps)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,193958,194827) || true) && (f_1343_193962_193974(result)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,193958,194827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,194029,194764);

f_1343_194029_194763(                        context, f_1343_194048_194736(f_1343_194094_194518(f_1343_194158_194483(f_1343_194210_194259(), f_1343_194298_194343(), "LanguageMode", f_1343_194435_194482(f_1343_194435_194469(f_1343_194435_194451(session))))), "SessionIsNotInFullLanguageMode", ErrorCategory.InvalidOperation, f_1343_194685_194705(session)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,194792,194804);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,193958,194827);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,194851,194871);

f_1343_194851_194870(f_1343_194851_194862(ps));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,194893,194919);

f_1343_194893_194918(f_1343_194893_194903(ps));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,194941,194974);

f_1343_194941_194973(                    ps, psRemoteUtilsName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,193479,195191);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,193479,195191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195056,195123);

string 
remoteScript = CopyFileRemoteUtils.PSValidatePathDefinition
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195145,195172);

f_1343_195145_195171(                    ps, remoteScript);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,193479,195191);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195211,195251);

f_1343_195211_195250(
                ps, "pathToValidate", path);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195271,195390) || true) && (sourceIsRemote)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,195271,195390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195331,195371);

f_1343_195331_195370(                    ps, "sourceIsRemote", true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,195271,195390);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195410,195489);

op = f_1343_195415_195488(ps, null, context);
DynAbs.Tracing.TraceSender.TraceExitUsing(1343,193062,195504);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195520,196089) || true) && (op == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,195520,196089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,195568,196044);

f_1343_195568_196043(                context, f_1343_195587_196042(f_1343_195637_195862(f_1343_195705_195861(f_1343_195757_195806(), f_1343_195808_195854(), path)), "FailedToValidateRemotePath", ErrorCategory.InvalidOperation, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,196062,196074);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,195520,196089);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,196187,196952) || true) && (f_1343_196191_196207(op, "IsAbsolute")!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,196187,196952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,196249,196290);

bool 
isAbsolute = (bool)f_1343_196273_196289(op, "IsAbsolute")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,196308,196937) || true) && (!isAbsolute)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,196308,196937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,196365,196884);

f_1343_196365_196883(                    context, f_1343_196384_196882(f_1343_196442_196682(f_1343_196510_196681(f_1343_196570_196619(), f_1343_196621_196674(), path)), "RemotePathIsNotAbsolute", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,196906,196918);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,196308,196937);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,196187,196952);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,196968,196991);

bool 
pathExist = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197005,197024);

string 
root = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197040,197114) || true) && (f_1343_197044_197056(op, "Exists")!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,197040,197114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197083,197114);

pathExist = (bool)f_1343_197101_197113(op, "Exists");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,197040,197114);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197130,197197) || true) && (f_1343_197134_197144(op, "Root")!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,197130,197197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197171,197197);

root = (string)f_1343_197186_197196(op, "Root");
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,197130,197197);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197342,197402);

bool 
invalidRemoteSource = (sourceIsRemote &&(DynAbs.Tracing.TraceSender.Expression_True(1343, 197370, 197400)&&(!pathExist)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197502,197549);

bool 
invalidRemoteDestination = (root == null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197565,198212) || true) && (invalidRemoteSource ||(DynAbs.Tracing.TraceSender.Expression_False(1343, 197569, 197616)||invalidRemoteDestination))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,197565,198212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,197650,198167);

f_1343_197650_198166(                context, f_1343_197669_198165(f_1343_197731_197958(f_1343_197803_197957(f_1343_197867_197916(), f_1343_197918_197950(), path)), "RemotePathNotFound", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,198185,198197);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,197565,198212);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,198228,198240);

return root;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,192834,198251);

System.Management.Automation.PowerShell
f_1343_193085_193104()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 193085, 193104);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1343_193152_193168(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 193152, 193168);
return return_v;
}


bool
f_1343_193483_193504(System.Management.Automation.PSLanguageMode?
this_param)
{
var return_v = this_param.HasValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 193483, 193504);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1343_193530_193548(System.Management.Automation.PSLanguageMode?
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 193530, 193548);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1343_193590_193608(System.Management.Automation.PSLanguageMode?
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 193590, 193608);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1343_193782_193798(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 193782, 193798);
return return_v;
}


System.Management.Automation.PowerShell
f_1343_193821_193849(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 193821, 193849);
return return_v;
}


System.Management.Automation.PowerShell
f_1343_193821_193880(System.Management.Automation.PowerShell
this_param,string
value)
{
var return_v = this_param.AddArgument( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 193821, 193880);
return return_v;
}


System.Collections.ObjectModel.Collection<bool>
f_1343_193916_193933(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke<bool>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 193916, 193933);
return return_v;
}


int
f_1343_193962_193974(System.Collections.ObjectModel.Collection<bool>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 193962, 193974);
return return_v;
}


System.Globalization.CultureInfo
f_1343_194210_194259()
{
var return_v =                                     System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194210, 194259);
return return_v;
}


string
f_1343_194298_194343()
{
var return_v =                                     SessionStateStrings.CopyItemSessionProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194298, 194343);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1343_194435_194451(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194435, 194451);
return return_v;
}


System.Management.Automation.Runspaces.SessionStateProxy
f_1343_194435_194469(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.SessionStateProxy;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194435, 194469);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1343_194435_194482(System.Management.Automation.Runspaces.SessionStateProxy
this_param)
{
var return_v = this_param.LanguageMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194435, 194482);
return return_v;
}


string
f_1343_194158_194483(System.Globalization.CultureInfo
provider,string
format,string
arg0,System.Management.Automation.PSLanguageMode
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 194158, 194483);
return return_v;
}


System.InvalidOperationException
f_1343_194094_194518(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 194094, 194518);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1343_194685_194705(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Availability
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194685, 194705);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_194048_194736(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.RunspaceAvailability
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 194048, 194736);
return return_v;
}


int
f_1343_194029_194763(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 194029, 194763);
return 0;
}


System.Management.Automation.PSCommand
f_1343_194851_194862(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194851, 194862);
return return_v;
}


int
f_1343_194851_194870(System.Management.Automation.PSCommand
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 194851, 194870);
return 0;
}


System.Management.Automation.PSDataStreams
f_1343_194893_194903(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Streams;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 194893, 194903);
return return_v;
}


int
f_1343_194893_194918(System.Management.Automation.PSDataStreams
this_param)
{
this_param.ClearStreams();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 194893, 194918);
return 0;
}


System.Management.Automation.PowerShell
f_1343_194941_194973(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 194941, 194973);
return return_v;
}


System.Management.Automation.PowerShell
f_1343_195145_195171(System.Management.Automation.PowerShell
this_param,string
script)
{
var return_v = this_param.AddScript( script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195145, 195171);
return return_v;
}


System.Management.Automation.PowerShell
f_1343_195211_195250(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195211, 195250);
return return_v;
}


System.Management.Automation.PowerShell
f_1343_195331_195370(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195331, 195370);
return return_v;
}


System.Collections.Hashtable
f_1343_195415_195488(System.Management.Automation.PowerShell
ps,Microsoft.PowerShell.Commands.FileSystemProvider
fileSystemContext,System.Management.Automation.CmdletProviderContext
cmdletContext)
{
var return_v = Microsoft.PowerShell.Commands.SafeInvokeCommand.Invoke( ps, fileSystemContext, cmdletContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195415, 195488);
return return_v;
}


System.Globalization.CultureInfo
f_1343_195757_195806()
{
var return_v =                                     System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 195757, 195806);
return return_v;
}


string
f_1343_195808_195854()
{
var return_v = SessionStateStrings.CopyItemValidateRemotePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 195808, 195854);
return return_v;
}


string
f_1343_195705_195861(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195705, 195861);
return return_v;
}


System.InvalidOperationException
f_1343_195637_195862(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195637, 195862);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_195587_196042(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195587, 196042);
return return_v;
}


int
f_1343_195568_196043(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 195568, 196043);
return 0;
}


object
f_1343_196191_196207(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 196191, 196207);
return return_v;
}


object
f_1343_196273_196289(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 196273, 196289);
return return_v;
}


System.Globalization.CultureInfo
f_1343_196570_196619()
{
var return_v =                                             System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 196570, 196619);
return return_v;
}


string
f_1343_196621_196674()
{
var return_v = SessionStateStrings.CopyItemRemotelyPathIsNotAbsolute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 196621, 196674);
return return_v;
}


string
f_1343_196510_196681(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 196510, 196681);
return return_v;
}


System.ArgumentException
f_1343_196442_196682(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 196442, 196682);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_196384_196882(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 196384, 196882);
return return_v;
}


int
f_1343_196365_196883(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 196365, 196883);
return 0;
}


object
f_1343_197044_197056(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 197044, 197056);
return return_v;
}


object
f_1343_197101_197113(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 197101, 197113);
return return_v;
}


object
f_1343_197134_197144(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 197134, 197144);
return return_v;
}


object
f_1343_197186_197196(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 197186, 197196);
return return_v;
}


System.Globalization.CultureInfo
f_1343_197867_197916()
{
var return_v =                                                 System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 197867, 197916);
return return_v;
}


string
f_1343_197918_197950()
{
var return_v = SessionStateStrings.PathNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 197918, 197950);
return return_v;
}


string
f_1343_197803_197957(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 197803, 197957);
return return_v;
}


System.ArgumentException
f_1343_197731_197958(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 197731, 197958);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_197669_198165(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 197669, 198165);
return return_v;
}


int
f_1343_197650_198166(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 197650, 198166);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,192834,198251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,192834,198251);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool isValidSession(PSSession session, CmdletProviderContext context, out PSLanguageMode? languageMode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1343,198263,199359);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,198469,199241) || true) && (f_1343_198473_198493(session)!= RunspaceAvailability.Available)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1343,198469,199241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,198561,199155);

f_1343_198561_199154(                context, f_1343_198580_199153(f_1343_198634_198946(f_1343_198706_198945(f_1343_198720_198769(), f_1343_198816_198861(), "Availability", f_1343_198924_198944(session))), "SessionIsNotAvailable", ErrorCategory.InvalidOperation, f_1343_199132_199152(session)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,199175,199195);

languageMode = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,199213,199226);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1343,198469,199241);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,199257,199320);

languageMode = f_1343_199272_199319(f_1343_199272_199306(f_1343_199272_199288(session)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1343,199336,199348);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1343,198263,199359);

System.Management.Automation.Runspaces.RunspaceAvailability
f_1343_198473_198493(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Availability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 198473, 198493);
return return_v;
}


System.Globalization.CultureInfo
f_1343_198720_198769()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 198720, 198769);
return return_v;
}


string
f_1343_198816_198861()
{
var return_v =                                             SessionStateStrings.CopyItemSessionProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 198816, 198861);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1343_198924_198944(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Availability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 198924, 198944);
return return_v;
}


string
f_1343_198706_198945(System.Globalization.CultureInfo
provider,string
format,string
arg0,System.Management.Automation.Runspaces.RunspaceAvailability
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 198706, 198945);
return return_v;
}


System.InvalidOperationException
f_1343_198634_198946(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 198634, 198946);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1343_199132_199152(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Availability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 199132, 199152);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1343_198580_199153(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.RunspaceAvailability
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 198580, 199153);
return return_v;
}


int
f_1343_198561_199154(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1343, 198561, 199154);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1343_199272_199288(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 199272, 199288);
return return_v;
}


System.Management.Automation.Runspaces.SessionStateProxy
f_1343_199272_199306(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.SessionStateProxy;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 199272, 199306);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1343_199272_199319(System.Management.Automation.Runspaces.SessionStateProxy
this_param)
{
var return_v = this_param.LanguageMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1343, 199272, 199319);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1343,198263,199359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1343,198263,199359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}

    /// <summary>
    /// Defines the action to be taken for Navigation cmdlets.
    /// </summary>
    internal enum ProcessMode
    {
        /// <summary>
        /// Write out the details.
        /// </summary>
        Enumerate = 1,

        /// <summary>
        /// Delete the item.
        /// </summary>
        Delete = 2
    }
}

#pragma warning restore 56500

