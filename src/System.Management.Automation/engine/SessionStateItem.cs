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
internal Collection<PSObject> GetItem(string[] paths, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,2019,2732);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2127,2247) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,2127,2247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2178,2232);

throw f_1348_2184_2231("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,2127,2247);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2263,2344);

CmdletProviderContext 
context = f_1348_2295_2343(f_1348_2321_2342(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2358,2380);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2394,2442);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2458,2482);

f_1348_2458_2481(this, paths, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2498,2535);

f_1348_2498_2534(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2627,2690);

Collection<PSObject> 
results = f_1348_2658_2689(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,2706,2721);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,2019,2732);

System.Management.Automation.PSArgumentNullException
f_1348_2184_2231(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 2184, 2231);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1348_2321_2342(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 2321, 2342);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1348_2295_2343(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 2295, 2343);
return return_v;
}


int
f_1348_2458_2481(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetItem( paths, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 2458, 2481);
return 0;
}


int
f_1348_2498_2534(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 2498, 2534);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1348_2658_2689(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 2658, 2689);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,2019,2732);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,2019,2732);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetItem(
            string[] paths,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,4316,5377);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4436,4556) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,4436,4556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4487,4541);

throw f_1348_4493_4540("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,4436,4556);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4572,4601);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4615,4654);

CmdletProvider 
providerInstance = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4670,5366);
foreach(string path in f_1348_4694_4699_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,4670,5366);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4733,4864) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,4733,4864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4791,4845);

throw f_1348_4797_4844("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,4733,4864);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,4884,5169);

Collection<string> 
providerPaths =
f_1348_4940_5168(f_1348_4940_4947(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,5189,5351);
foreach(string providerPath in f_1348_5221_5234_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,5189,5351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,5276,5332);

f_1348_5276_5331(this, providerInstance, providerPath, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,5189,5351);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,163);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,163);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1348,4670,5366);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,697);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,697);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1348,4316,5377);

System.Management.Automation.PSArgumentNullException
f_1348_4493_4540(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 4493, 4540);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1348_4797_4844(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 4797, 4844);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1348_4940_4947()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 4940, 4947);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_4940_5168(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 4940, 5168);
return return_v;
}


int
f_1348_5276_5331(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetItemPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 5276, 5331);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1348_5221_5234_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 5221, 5234);
return return_v;
}


string[]
f_1348_4694_4699_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 4694, 4699);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,4316,5377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,4316,5377);
}
		}

private void GetItemPrivate(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,6306,7904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,6543,6697);

f_1348_6543_6696(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,6713,6843);

f_1348_6713_6842(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,6859,6995);

f_1348_6859_6994(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,7011,7110);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_7068_7109(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,7162,7204);

f_1348_7162_7203(                itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,7233,7312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,7291,7297);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,7233,7312);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,7326,7412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,7391,7397);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,7326,7412);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,7426,7517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,7496,7502);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,7426,7517);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,7531,7893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,7619,7878);

throw f_1348_7625_7877(this, "GetItemProviderException", f_1348_7727_7771(), f_1348_7794_7825(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,7531,7893);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,6306,7904);

int
f_1348_6543_6696(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 6543, 6696);
return 0;
}


int
f_1348_6713_6842(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 6713, 6842);
return 0;
}


int
f_1348_6859_6994(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 6859, 6994);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_7068_7109(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 7068, 7109);
return return_v;
}


int
f_1348_7162_7203(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetItem( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 7162, 7203);
return 0;
}


string
f_1348_7727_7771()
{
var return_v =                     SessionStateStrings.GetItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 7727, 7771);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_7794_7825(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 7794, 7825);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_7625_7877(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 7625, 7877);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,6306,7904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,6306,7904);
}
		}

internal object GetItemDynamicParameters(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,9317,10417);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,9426,9503) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,9426,9503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,9476,9488);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,9426,9503);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,9519,9548);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,9562,9601);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,9617,9704);

CmdletProviderContext 
newContext =
f_1348_9669_9703(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,9718,9850);

f_1348_9718_9849(            newContext, f_1348_9758_9782(), f_1348_9801_9825(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,9866,10129);

Collection<string> 
providerPaths =
f_1348_9918_10128(f_1348_9918_9925(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,10145,10378) || true) && (f_1348_10149_10168(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,10145,10378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,10283,10363);

return f_1348_10290_10362(this, providerInstance, f_1348_10333_10349(providerPaths, 0), newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,10145,10378);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,10394,10406);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,9317,10417);

System.Management.Automation.CmdletProviderContext
f_1348_9669_9703(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 9669, 9703);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_9758_9782()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 9758, 9782);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_9801_9825()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 9801, 9825);
return return_v;
}


int
f_1348_9718_9849(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 9718, 9849);
return 0;
}


System.Management.Automation.LocationGlobber
f_1348_9918_9925()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 9918, 9925);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_9918_10128(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 9918, 10128);
return return_v;
}


int
f_1348_10149_10168(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 10149, 10168);
return return_v;
}


string
f_1348_10333_10349(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 10333, 10349);
return return_v;
}


object
f_1348_10290_10362(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetItemDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 10290, 10362);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,9317,10417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,9317,10417);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetItemDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,11544,13279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,11793,11947);

f_1348_11793_11946(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,11963,12093);

f_1348_11963_12092(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12109,12245);

f_1348_12109_12244(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12261,12360);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_12318_12359(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12376,12397);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12447,12515);

result = f_1348_12456_12514(itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,12544,12623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12602,12608);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,12544,12623);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,12637,12723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12702,12708);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,12637,12723);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,12737,12828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12807,12813);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,12737,12828);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,12842,13238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,12930,13223);

throw f_1348_12936_13222(this, "GetItemDynamicParametersProviderException", f_1348_13055_13116(), f_1348_13139_13170(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,12842,13238);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,13254,13268);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,11544,13279);

int
f_1348_11793_11946(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 11793, 11946);
return 0;
}


int
f_1348_11963_12092(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 11963, 12092);
return 0;
}


int
f_1348_12109_12244(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 12109, 12244);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_12318_12359(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 12318, 12359);
return return_v;
}


object
f_1348_12456_12514(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetItemDynamicParameters( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 12456, 12514);
return return_v;
}


string
f_1348_13055_13116()
{
var return_v =                     SessionStateStrings.GetItemDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 13055, 13116);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_13139_13170(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 13139, 13170);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_12936_13222(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 12936, 13222);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,11544,13279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,11544,13279);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> SetItem(string[] paths, object value, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,14865,15543);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,14987,15107) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,14987,15107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,15038,15092);

throw f_1348_15044_15091("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,14987,15107);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,15123,15204);

CmdletProviderContext 
context = f_1348_15155_15203(f_1348_15181_15202(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,15218,15240);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,15254,15302);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,15318,15349);

f_1348_15318_15348(this, paths, value, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,15365,15402);

f_1348_15365_15401(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,15493,15532);

return f_1348_15500_15531(context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,14865,15543);

System.Management.Automation.PSArgumentNullException
f_1348_15044_15091(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 15044, 15091);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1348_15181_15202(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 15181, 15202);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1348_15155_15203(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 15155, 15203);
return return_v;
}


int
f_1348_15318_15348(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,object
value,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetItem( paths, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 15318, 15348);
return 0;
}


int
f_1348_15365_15401(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 15365, 15401);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1348_15500_15531(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 15500, 15531);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,14865,15543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,14865,15543);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetItem(
            string[] paths,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,17064,18257);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17211,17331) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,17211,17331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17262,17316);

throw f_1348_17268_17315("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,17211,17331);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17347,18246);
foreach(string path in f_1348_17371_17376_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,17347,18246);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17410,17541) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,17410,17541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17468,17522);

throw f_1348_17474_17521("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,17410,17541);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17561,17590);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17608,17647);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17667,17951);

Collection<string> 
providerPaths =
f_1348_17723_17950(f_1348_17723_17730(), path, true, context, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,17971,18231) || true) && (providerPaths != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,17971,18231);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,18038,18212);
foreach(string providerPath in f_1348_18070_18083_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,18038,18212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,18133,18189);

f_1348_18133_18188(this, providerInstance, providerPath, value, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,18038,18212);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,175);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,175);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1348,17971,18231);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,17347,18246);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,900);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,900);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1348,17064,18257);

System.Management.Automation.PSArgumentNullException
f_1348_17268_17315(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 17268, 17315);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1348_17474_17521(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 17474, 17521);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1348_17723_17730()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 17723, 17730);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_17723_17950(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 17723, 17950);
return return_v;
}


int
f_1348_18133_18188(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,object
value,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetItem( providerInstance, path, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 18133, 18188);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1348_18070_18083_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 18070, 18083);
return return_v;
}


string[]
f_1348_17371_17376_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 17371, 17376);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,17064,18257);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,17064,18257);
}
		}

private void SetItem(
            CmdletProvider providerInstance,
            string path,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,19274,20899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,19531,19685);

f_1348_19531_19684(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,19701,19831);

f_1348_19701_19830(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,19847,19983);

f_1348_19847_19982(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,19999,20098);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_20056_20097(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,20150,20199);

f_1348_20150_20198(                itemCmdletProvider, path, value, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,20228,20307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,20286,20292);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,20228,20307);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,20321,20407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,20386,20392);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,20321,20407);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,20421,20512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,20491,20497);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,20421,20512);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,20526,20888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,20614,20873);

throw f_1348_20620_20872(this, "SetItemProviderException", f_1348_20722_20766(), f_1348_20789_20820(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,20526,20888);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,19274,20899);

int
f_1348_19531_19684(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 19531, 19684);
return 0;
}


int
f_1348_19701_19830(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 19701, 19830);
return 0;
}


int
f_1348_19847_19982(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 19847, 19982);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_20056_20097(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 20056, 20097);
return return_v;
}


int
f_1348_20150_20198(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,object
value,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetItem( path, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 20150, 20198);
return 0;
}


string
f_1348_20722_20766()
{
var return_v =                     SessionStateStrings.SetItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 20722, 20766);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_20789_20820(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 20789, 20820);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_20620_20872(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 20620, 20872);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,19274,20899);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,19274,20899);
}
		}

internal object SetItemDynamicParameters(string path, object value, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,22430,23551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,22553,22630) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,22553,22630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,22603,22615);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,22553,22630);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,22646,22675);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,22689,22728);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,22744,22830);

CmdletProviderContext 
newContext =
f_1348_22795_22829(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,22844,22976);

f_1348_22844_22975(            newContext, f_1348_22884_22908(), f_1348_22927_22951(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,22992,23256);

Collection<string> 
providerPaths =
f_1348_23045_23255(f_1348_23045_23052(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,23272,23512) || true) && (f_1348_23276_23295(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,23272,23512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,23410,23497);

return f_1348_23417_23496(this, providerInstance, f_1348_23460_23476(providerPaths, 0), value, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,23272,23512);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,23528,23540);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,22430,23551);

System.Management.Automation.CmdletProviderContext
f_1348_22795_22829(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 22795, 22829);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_22884_22908()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 22884, 22908);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_22927_22951()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 22927, 22951);
return return_v;
}


int
f_1348_22844_22975(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 22844, 22975);
return 0;
}


System.Management.Automation.LocationGlobber
f_1348_23045_23052()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 23045, 23052);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_23045_23255(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 23045, 23255);
return return_v;
}


int
f_1348_23276_23295(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 23276, 23295);
return return_v;
}


string
f_1348_23460_23476(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 23460, 23476);
return return_v;
}


object
f_1348_23417_23496(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,object
value,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.SetItemDynamicParameters( providerInstance, path, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 23417, 23496);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,22430,23551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,22430,23551);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object SetItemDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,24768,26537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25044,25198);

f_1348_25044_25197(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25214,25344);

f_1348_25214_25343(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25360,25496);

f_1348_25360_25495(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25512,25611);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_25569_25610(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25627,25648);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25698,25773);

result = f_1348_25707_25772(itemCmdletProvider, path, value, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,25802,25881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25860,25866);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,25802,25881);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,25895,25981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,25960,25966);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,25895,25981);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,25995,26086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,26065,26071);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,25995,26086);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,26100,26496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,26188,26481);

throw f_1348_26194_26480(this, "SetItemDynamicParametersProviderException", f_1348_26313_26374(), f_1348_26397_26428(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,26100,26496);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,26512,26526);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,24768,26537);

int
f_1348_25044_25197(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 25044, 25197);
return 0;
}


int
f_1348_25214_25343(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 25214, 25343);
return 0;
}


int
f_1348_25360_25495(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 25360, 25495);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_25569_25610(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 25569, 25610);
return return_v;
}


object
f_1348_25707_25772(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,object
value,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.SetItemDynamicParameters( path, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 25707, 25772);
return return_v;
}


string
f_1348_26313_26374()
{
var return_v =                     SessionStateStrings.SetItemDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 26313, 26374);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_26397_26428(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 26397, 26428);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_26194_26480(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 26194, 26480);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,24768,26537);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,24768,26537);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> ClearItem(string[] paths, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,28239,28825);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28349,28469) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,28349,28469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28400,28454);

throw f_1348_28406_28453("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,28349,28469);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28485,28566);

CmdletProviderContext 
context = f_1348_28517_28565(f_1348_28543_28564(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28580,28602);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28616,28664);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28680,28706);

f_1348_28680_28705(this, paths, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28722,28759);

f_1348_28722_28758(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,28775,28814);

return f_1348_28782_28813(context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,28239,28825);

System.Management.Automation.PSArgumentNullException
f_1348_28406_28453(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 28406, 28453);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1348_28543_28564(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 28543, 28564);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1348_28517_28565(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 28517, 28565);
return return_v;
}


int
f_1348_28680_28705(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearItem( paths, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 28680, 28705);
return 0;
}


int
f_1348_28722_28758(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 28722, 28758);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1348_28782_28813(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 28782, 28813);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,28239,28825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,28239,28825);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ClearItem(
            string[] paths,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,30351,31514);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30473,30593) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,30473,30593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30524,30578);

throw f_1348_30530_30577("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,30473,30593);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30609,30638);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30652,30691);

CmdletProvider 
providerInstance = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30707,31503);
foreach(string path in f_1348_30731_30736_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,30707,31503);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30770,30901) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,30770,30901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30828,30882);

throw f_1348_30834_30881("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,30770,30901);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,30921,31206);

Collection<string> 
providerPaths =
f_1348_30977_31205(f_1348_30977_30984(), path, false, context, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,31226,31488) || true) && (providerPaths != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,31226,31488);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,31293,31469);
foreach(string providerPath in f_1348_31325_31338_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,31293,31469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,31388,31446);

f_1348_31388_31445(this, providerInstance, providerPath, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,31293,31469);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,177);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,177);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1348,31226,31488);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,30707,31503);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,797);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,797);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1348,30351,31514);

System.Management.Automation.PSArgumentNullException
f_1348_30530_30577(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 30530, 30577);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1348_30834_30881(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 30834, 30881);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1348_30977_30984()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 30977, 30984);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_30977_31205(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 30977, 31205);
return return_v;
}


int
f_1348_31388_31445(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearItemPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 31388, 31445);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1348_31325_31338_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 31325, 31338);
return return_v;
}


string[]
f_1348_30731_30736_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 30731, 30736);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,30351,31514);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,30351,31514);
}
		}

private void ClearItemPrivate(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,32445,34051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,32684,32838);

f_1348_32684_32837(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,32854,32984);

f_1348_32854_32983(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,33000,33136);

f_1348_33000_33135(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,33152,33251);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_33209_33250(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,33303,33347);

f_1348_33303_33346(                itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,33376,33455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,33434,33440);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,33376,33455);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,33469,33555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,33534,33540);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,33469,33555);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,33569,33660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,33639,33645);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,33569,33660);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,33674,34040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,33762,34025);

throw f_1348_33768_34024(this, "ClearItemProviderException", f_1348_33872_33918(), f_1348_33941_33972(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,33674,34040);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,32445,34051);

int
f_1348_32684_32837(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 32684, 32837);
return 0;
}


int
f_1348_32854_32983(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 32854, 32983);
return 0;
}


int
f_1348_33000_33135(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 33000, 33135);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_33209_33250(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 33209, 33250);
return return_v;
}


int
f_1348_33303_33346(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearItem( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 33303, 33346);
return 0;
}


string
f_1348_33872_33918()
{
var return_v =                     SessionStateStrings.ClearItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 33872, 33918);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_33941_33972(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 33941, 33972);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_33768_34024(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 33768, 34024);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,32445,34051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,32445,34051);
}
		}

internal object ClearItemDynamicParameters(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,35466,36570);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,35577,35654) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,35577,35654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,35627,35639);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,35577,35654);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,35670,35699);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,35713,35752);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,35768,35854);

CmdletProviderContext 
newContext =
f_1348_35819_35853(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,35868,36000);

f_1348_35868_35999(            newContext, f_1348_35908_35932(), f_1348_35951_35975(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,36016,36280);

Collection<string> 
providerPaths =
f_1348_36069_36279(f_1348_36069_36076(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,36296,36531) || true) && (f_1348_36300_36319(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,36296,36531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,36434,36516);

return f_1348_36441_36515(this, providerInstance, f_1348_36486_36502(providerPaths, 0), newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,36296,36531);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,36547,36559);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,35466,36570);

System.Management.Automation.CmdletProviderContext
f_1348_35819_35853(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 35819, 35853);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_35908_35932()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 35908, 35932);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_35951_35975()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 35951, 35975);
return return_v;
}


int
f_1348_35868_35999(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 35868, 35999);
return 0;
}


System.Management.Automation.LocationGlobber
f_1348_36069_36076()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 36069, 36076);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_36069_36279(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 36069, 36279);
return return_v;
}


int
f_1348_36300_36319(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 36300, 36319);
return return_v;
}


string
f_1348_36486_36502(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 36486, 36502);
return return_v;
}


object
f_1348_36441_36515(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ClearItemDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 36441, 36515);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,35466,36570);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,35466,36570);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object ClearItemDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,37699,39408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,37950,38104);

f_1348_37950_38103(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38120,38250);

f_1348_38120_38249(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38266,38402);

f_1348_38266_38401(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38418,38517);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_38475_38516(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38533,38554);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38604,38674);

result = f_1348_38613_38673(itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,38703,38782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38761,38767);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,38703,38782);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,38796,38882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38861,38867);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,38796,38882);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,38896,38987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,38966,38972);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,38896,38987);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,39001,39367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,39089,39352);

throw f_1348_39095_39351(this, "ClearItemProviderException", f_1348_39199_39245(), f_1348_39268_39299(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,39001,39367);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,39383,39397);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,37699,39408);

int
f_1348_37950_38103(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 37950, 38103);
return 0;
}


int
f_1348_38120_38249(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 38120, 38249);
return 0;
}


int
f_1348_38266_38401(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 38266, 38401);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_38475_38516(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 38475, 38516);
return return_v;
}


object
f_1348_38613_38673(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ClearItemDynamicParameters( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 38613, 38673);
return return_v;
}


string
f_1348_39199_39245()
{
var return_v =                     SessionStateStrings.ClearItemProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 39199, 39245);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_39268_39299(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 39268, 39299);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_39095_39351(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 39095, 39351);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,37699,39408);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,37699,39408);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void InvokeDefaultAction(string[] paths, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,40867,41354);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,40959,41079) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,40959,41079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,41010,41064);

throw f_1348_41016_41063("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,40959,41079);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,41095,41176);

CmdletProviderContext 
context = f_1348_41127_41175(f_1348_41153_41174(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,41190,41238);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,41254,41290);

f_1348_41254_41289(this, paths, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,41306,41343);

f_1348_41306_41342(
            context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,40867,41354);

System.Management.Automation.PSArgumentNullException
f_1348_41016_41063(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 41016, 41063);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1348_41153_41174(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 41153, 41174);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1348_41127_41175(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 41127, 41175);
return return_v;
}


int
f_1348_41254_41289(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.CmdletProviderContext
context)
{
this_param.InvokeDefaultAction( paths, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 41254, 41289);
return 0;
}


int
f_1348_41306_41342(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 41306, 41342);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,40867,41354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,40867,41354);
}
		}

internal void InvokeDefaultAction(
            string[] paths,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,42827,44010);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,42959,43079) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,42959,43079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43010,43064);

throw f_1348_43016_43063("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,42959,43079);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43095,43124);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43138,43177);

CmdletProvider 
providerInstance = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43193,43999);
foreach(string path in f_1348_43217_43222_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,43193,43999);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43256,43387) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,43256,43387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43314,43368);

throw f_1348_43320_43367("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,43256,43387);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43407,43692);

Collection<string> 
providerPaths =
f_1348_43463_43691(f_1348_43463_43470(), path, false, context, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43712,43984) || true) && (providerPaths != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,43712,43984);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43779,43965);
foreach(string providerPath in f_1348_43811_43824_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,43779,43965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,43874,43942);

f_1348_43874_43941(this, providerInstance, providerPath, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,43779,43965);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,187);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,187);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1348,43712,43984);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,43193,43999);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1348,1,807);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1348,1,807);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1348,42827,44010);

System.Management.Automation.PSArgumentNullException
f_1348_43016_43063(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 43016, 43063);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1348_43320_43367(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 43320, 43367);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1348_43463_43470()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 43463, 43470);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_43463_43691(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 43463, 43691);
return return_v;
}


int
f_1348_43874_43941(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.InvokeDefaultActionPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 43874, 43941);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1348_43811_43824_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 43811, 43824);
return return_v;
}


string[]
f_1348_43217_43222_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 43217, 43222);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,42827,44010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,42827,44010);
}
		}

private void InvokeDefaultActionPrivate(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,44964,46610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,45213,45367);

f_1348_45213_45366(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,45383,45513);

f_1348_45383_45512(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,45529,45665);

f_1348_45529_45664(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,45681,45780);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_45738_45779(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,45832,45886);

f_1348_45832_45885(                itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,45915,45994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,45973,45979);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,45915,45994);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,46008,46094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,46073,46079);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,46008,46094);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,46108,46199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,46178,46184);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,46108,46199);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,46213,46599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,46301,46584);

throw f_1348_46307_46583(this, "InvokeDefaultActionProviderException", f_1348_46421_46477(), f_1348_46500_46531(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,46213,46599);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,44964,46610);

int
f_1348_45213_45366(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 45213, 45366);
return 0;
}


int
f_1348_45383_45512(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 45383, 45512);
return 0;
}


int
f_1348_45529_45664(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 45529, 45664);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_45738_45779(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 45738, 45779);
return return_v;
}


int
f_1348_45832_45885(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.InvokeDefaultAction( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 45832, 45885);
return 0;
}


string
f_1348_46421_46477()
{
var return_v =                     SessionStateStrings.InvokeDefaultActionProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 46421, 46477);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_46500_46531(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 46500, 46531);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_46307_46583(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 46307, 46583);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,44964,46610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,44964,46610);
}
		}

internal object InvokeDefaultActionDynamicParameters(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,48026,49150);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48147,48224) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,48147,48224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48197,48209);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,48147,48224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48240,48269);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48283,48322);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48338,48424);

CmdletProviderContext 
newContext =
f_1348_48389_48423(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48438,48570);

f_1348_48438_48569(            newContext, f_1348_48478_48502(), f_1348_48521_48545(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48586,48850);

Collection<string> 
providerPaths =
f_1348_48639_48849(f_1348_48639_48646(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,48866,49111) || true) && (f_1348_48870_48889(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1348,48866,49111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,49004,49096);

return f_1348_49011_49095(this, providerInstance, f_1348_49066_49082(providerPaths, 0), newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1348,48866,49111);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,49127,49139);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,48026,49150);

System.Management.Automation.CmdletProviderContext
f_1348_48389_48423(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 48389, 48423);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_48478_48502()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 48478, 48502);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_48521_48545()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 48521, 48545);
return return_v;
}


int
f_1348_48438_48569(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 48438, 48569);
return 0;
}


System.Management.Automation.LocationGlobber
f_1348_48639_48646()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 48639, 48646);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1348_48639_48849(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 48639, 48849);
return return_v;
}


int
f_1348_48870_48889(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 48870, 48889);
return return_v;
}


string
f_1348_49066_49082(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 49066, 49082);
return return_v;
}


object
f_1348_49011_49095(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.InvokeDefaultActionDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 49011, 49095);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,48026,49150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,48026,49150);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object InvokeDefaultActionDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1348,50280,52063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,50541,50695);

f_1348_50541_50694(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,50711,50841);

f_1348_50711_50840(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,50857,50993);

f_1348_50857_50992(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,51009,51108);

ItemCmdletProvider 
itemCmdletProvider =
f_1348_51066_51107(providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,51124,51145);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,51195,51275);

result = f_1348_51204_51274(itemCmdletProvider, path, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,51304,51383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,51362,51368);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,51304,51383);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,51397,51483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,51462,51468);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,51397,51483);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,51497,51588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,51567,51573);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,51497,51588);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1348,51602,52022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,51690,52007);

throw f_1348_51696_52006(this, "InvokeDefaultActionDynamicParametersProviderException", f_1348_51827_51900(), f_1348_51923_51954(itemCmdletProvider), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1348,51602,52022);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1348,52038,52052);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1348,50280,52063);

int
f_1348_50541_50694(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 50541, 50694);
return 0;
}


int
f_1348_50711_50840(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 50711, 50840);
return 0;
}


int
f_1348_50857_50992(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 50857, 50992);
return 0;
}


System.Management.Automation.Provider.ItemCmdletProvider
f_1348_51066_51107(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetItemProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 51066, 51107);
return return_v;
}


object
f_1348_51204_51274(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.InvokeDefaultActionDynamicParameters( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 51204, 51274);
return return_v;
}


string
f_1348_51827_51900()
{
var return_v =                     SessionStateStrings.InvokeDefaultActionDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 51827, 51900);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1348_51923_51954(System.Management.Automation.Provider.ItemCmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1348, 51923, 51954);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1348_51696_52006(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1348, 51696, 52006);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1348,50280,52063);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1348,50280,52063);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}

#pragma warning restore 56500

