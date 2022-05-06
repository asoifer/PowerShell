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
internal Collection<IContentReader> GetContentReader(string[] paths, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,2035,2654);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2158,2278) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,2158,2278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2209,2263);

throw f_1344_2215_2262("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,2158,2278);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2294,2375);

CmdletProviderContext 
context = f_1344_2326_2374(f_1344_2352_2373(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2389,2411);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2425,2473);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2489,2559);

Collection<IContentReader> 
results = f_1344_2526_2558(this, paths, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2575,2612);

f_1344_2575_2611(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,2628,2643);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,2035,2654);

System.Management.Automation.PSArgumentNullException
f_1344_2215_2262(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 2215, 2262);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1344_2352_2373(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 2352, 2373);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1344_2326_2374(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 2326, 2374);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
f_1344_2526_2558(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetContentReader( paths, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 2526, 2558);
return return_v;
}


int
f_1344_2575_2611(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 2575, 2611);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,2035,2654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,2035,2654);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<IContentReader> GetContentReader(
             string[] paths,
             CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,4135,5579);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4288,4408) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,4288,4408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4339,4393);

throw f_1344_4345_4392("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,4288,4408);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4424,4453);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4467,4506);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4522,4592);

Collection<IContentReader> 
results = f_1344_4559_4591()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4608,5537);
foreach(string path in f_1344_4632_4637_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,4608,5537);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4671,4802) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,4671,4802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4729,4783);

throw f_1344_4735_4782("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,4671,4802);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,4822,5107);

Collection<string> 
providerPaths =
f_1344_4878_5106(f_1344_4878_4885(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,5127,5522);
foreach(string providerPath in f_1344_5159_5172_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,5127,5522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,5214,5303);

IContentReader 
reader = f_1344_5238_5302(this, providerInstance, providerPath, context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,5327,5438) || true) && (reader != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,5327,5438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,5395,5415);

f_1344_5395_5414(                        results, reader);
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,5327,5438);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,5462,5503);

f_1344_5462_5502(
                    context, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,5127,5522);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1344,1,396);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1344,1,396);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1344,4608,5537);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1344,1,930);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1344,1,930);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,5553,5568);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,4135,5579);

System.Management.Automation.PSArgumentNullException
f_1344_4345_4392(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 4345, 4392);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
f_1344_4559_4591()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 4559, 4591);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1344_4735_4782(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 4735, 4782);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1344_4878_4885()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 4878, 4885);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_4878_5106(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 4878, 5106);
return return_v;
}


System.Management.Automation.Provider.IContentReader
f_1344_5238_5302(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetContentReaderPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 5238, 5302);
return return_v;
}


int
f_1344_5395_5414(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
this_param,System.Management.Automation.Provider.IContentReader
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 5395, 5414);
return 0;
}


int
f_1344_5462_5502(System.Management.Automation.CmdletProviderContext
this_param,bool
wrapExceptionInProviderException)
{
this_param.ThrowFirstErrorOrDoNothing( wrapExceptionInProviderException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 5462, 5502);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1344_5159_5172_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 5159, 5172);
return return_v;
}


string[]
f_1344_4632_4637_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 4632, 4637);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,4135,5579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,4135,5579);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IContentReader GetContentReaderPrivate(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,6531,8237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,6787,6941);

f_1344_6787_6940(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,6957,7087);

f_1344_6957_7086(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7103,7239);

f_1344_7103_7238(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7255,7284);

IContentReader 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7336,7394);

result = f_1344_7345_7393(providerInstance, path, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,7423,7506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7485,7491);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,7423,7506);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,7520,7599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7578,7584);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,7520,7599);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,7613,7699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7678,7684);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,7613,7699);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,7713,7804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7783,7789);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,7713,7804);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,7818,8196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,7906,8181);

throw f_1344_7912_8180(this, "GetContentReaderProviderException", f_1344_8023_8076(), f_1344_8099_8128(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,7818,8196);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,8212,8226);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,6531,8237);

int
f_1344_6787_6940(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 6787, 6940);
return 0;
}


int
f_1344_6957_7086(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 6957, 7086);
return 0;
}


int
f_1344_7103_7238(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 7103, 7238);
return 0;
}


System.Management.Automation.Provider.IContentReader
f_1344_7345_7393(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.GetContentReader( path, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 7345, 7393);
return return_v;
}


string
f_1344_8023_8076()
{
var return_v =                     SessionStateStrings.GetContentReaderProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 8023, 8076);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1344_8099_8128(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 8099, 8128);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1344_7912_8180(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 7912, 8180);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,6531,8237);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,6531,8237);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object GetContentReaderDynamicParameters(
             string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,9653,10606);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,9799,9876) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,9799,9876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,9849,9861);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,9799,9876);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,9892,9921);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,9935,9974);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,9990,10077);

CmdletProviderContext 
newContext =
f_1344_10042_10076(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,10091,10223);

f_1344_10091_10222(            newContext, f_1344_10131_10155(), f_1344_10174_10198(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,10239,10502);

Collection<string> 
providerPaths =
f_1344_10291_10501(f_1344_10291_10298(), path, true, newContext, out provider, out providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,10518,10595);

return f_1344_10525_10594(this, providerInstance, path, newContext);
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,9653,10606);

System.Management.Automation.CmdletProviderContext
f_1344_10042_10076(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 10042, 10076);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_10131_10155()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 10131, 10155);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_10174_10198()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 10174, 10198);
return return_v;
}


int
f_1344_10091_10222(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 10091, 10222);
return 0;
}


System.Management.Automation.LocationGlobber
f_1344_10291_10298()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 10291, 10298);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_10291_10501(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 10291, 10501);
return return_v;
}


object
f_1344_10525_10594(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetContentReaderDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 10525, 10594);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,9653,10606);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,9653,10606);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetContentReaderDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,11736,13485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,11994,12148);

f_1344_11994_12147(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12164,12294);

f_1344_12164_12293(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12310,12446);

f_1344_12310_12445(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12462,12483);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12533,12608);

result = f_1344_12542_12607(providerInstance, path, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,12637,12720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12699,12705);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,12637,12720);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,12734,12813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12792,12798);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,12734,12813);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,12827,12913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12892,12898);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,12827,12913);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,12927,13018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,12997,13003);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,12927,13018);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,13032,13444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,13120,13429);

throw f_1344_13126_13428(this, "GetContentReaderDynamicParametersProviderException", f_1344_13254_13324(), f_1344_13347_13376(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,13032,13444);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,13460,13474);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,11736,13485);

int
f_1344_11994_12147(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 11994, 12147);
return 0;
}


int
f_1344_12164_12293(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 12164, 12293);
return 0;
}


int
f_1344_12310_12445(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 12310, 12445);
return 0;
}


object
f_1344_12542_12607(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.GetContentReaderDynamicParameters( path, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 12542, 12607);
return return_v;
}


string
f_1344_13254_13324()
{
var return_v =                     SessionStateStrings.GetContentReaderDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 13254, 13324);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1344_13347_13376(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 13347, 13376);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1344_13126_13428(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 13126, 13428);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,11736,13485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,11736,13485);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<IContentWriter> GetContentWriter(string[] paths, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,14960,15579);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15083,15203) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,15083,15203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15134,15188);

throw f_1344_15140_15187("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,15083,15203);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15219,15300);

CmdletProviderContext 
context = f_1344_15251_15299(f_1344_15277_15298(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15314,15336);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15350,15398);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15414,15484);

Collection<IContentWriter> 
results = f_1344_15451_15483(this, paths, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15500,15537);

f_1344_15500_15536(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,15553,15568);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,14960,15579);

System.Management.Automation.PSArgumentNullException
f_1344_15140_15187(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 15140, 15187);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1344_15277_15298(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 15277, 15298);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1344_15251_15299(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 15251, 15299);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
f_1344_15451_15483(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetContentWriter( paths, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 15451, 15483);
return return_v;
}


int
f_1344_15500_15536(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 15500, 15536);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,14960,15579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,14960,15579);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<IContentWriter> GetContentWriter(
            string[] paths,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,17060,18459);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17211,17331) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,17211,17331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17262,17316);

throw f_1344_17268_17315("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,17211,17331);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17347,17376);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17390,17429);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17443,17513);

Collection<IContentWriter> 
results = f_1344_17480_17512()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17529,18417);
foreach(string path in f_1344_17553_17558_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,17529,18417);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17592,17723) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,17592,17723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17650,17704);

throw f_1344_17656_17703("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,17592,17723);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,17743,18027);

Collection<string> 
providerPaths =
f_1344_17799_18026(f_1344_17799_17806(), path, true, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,18047,18402);
foreach(string providerPath in f_1344_18079_18092_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,18047,18402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,18134,18248);

IContentWriter 
result =
f_1344_18183_18247(this, providerInstance, providerPath, context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,18272,18383) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,18272,18383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,18340,18360);

f_1344_18340_18359(                        results, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,18272,18383);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,18047,18402);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1344,1,356);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1344,1,356);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1344,17529,18417);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1344,1,889);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1344,1,889);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,18433,18448);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,17060,18459);

System.Management.Automation.PSArgumentNullException
f_1344_17268_17315(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 17268, 17315);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
f_1344_17480_17512()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 17480, 17512);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1344_17656_17703(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 17656, 17703);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1344_17799_17806()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 17799, 17806);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_17799_18026(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 17799, 18026);
return return_v;
}


System.Management.Automation.Provider.IContentWriter
f_1344_18183_18247(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetContentWriterPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 18183, 18247);
return return_v;
}


int
f_1344_18340_18359(System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
this_param,System.Management.Automation.Provider.IContentWriter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 18340, 18359);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1344_18079_18092_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 18079, 18092);
return return_v;
}


string[]
f_1344_17553_17558_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 17553, 17558);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,17060,18459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,17060,18459);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IContentWriter GetContentWriterPrivate(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,19411,21115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,19667,19821);

f_1344_19667_19820(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,19837,19967);

f_1344_19837_19966(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,19983,20119);

f_1344_19983_20118(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,20135,20164);

IContentWriter 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,20214,20272);

result = f_1344_20223_20271(providerInstance, path, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,20301,20384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,20363,20369);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,20301,20384);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,20398,20477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,20456,20462);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,20398,20477);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,20491,20577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,20556,20562);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,20491,20577);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,20591,20682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,20661,20667);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,20591,20682);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,20696,21074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,20784,21059);

throw f_1344_20790_21058(this, "GetContentWriterProviderException", f_1344_20901_20954(), f_1344_20977_21006(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,20696,21074);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,21090,21104);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,19411,21115);

int
f_1344_19667_19820(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 19667, 19820);
return 0;
}


int
f_1344_19837_19966(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 19837, 19966);
return 0;
}


int
f_1344_19983_20118(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 19983, 20118);
return 0;
}


System.Management.Automation.Provider.IContentWriter
f_1344_20223_20271(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.GetContentWriter( path, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 20223, 20271);
return return_v;
}


string
f_1344_20901_20954()
{
var return_v =                     SessionStateStrings.GetContentWriterProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 20901, 20954);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1344_20977_21006(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 20977, 21006);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1344_20790_21058(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 20790, 21058);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,19411,21115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,19411,21115);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object GetContentWriterDynamicParameters(
             string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,22547,23693);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,22693,22770) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,22693,22770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,22743,22755);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,22693,22770);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,22786,22815);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,22829,22868);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,22884,22971);

CmdletProviderContext 
newContext =
f_1344_22936_22970(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,22985,23117);

f_1344_22985_23116(            newContext, f_1344_23025_23049(), f_1344_23068_23092(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,23133,23396);

Collection<string> 
providerPaths =
f_1344_23185_23395(f_1344_23185_23192(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,23412,23654) || true) && (f_1344_23416_23435(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,23412,23654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,23550,23639);

return f_1344_23557_23638(this, providerInstance, f_1344_23609_23625(providerPaths, 0), newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,23412,23654);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,23670,23682);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,22547,23693);

System.Management.Automation.CmdletProviderContext
f_1344_22936_22970(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 22936, 22970);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_23025_23049()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 23025, 23049);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_23068_23092()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 23068, 23092);
return return_v;
}


int
f_1344_22985_23116(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 22985, 23116);
return 0;
}


System.Management.Automation.LocationGlobber
f_1344_23185_23192()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 23185, 23192);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_23185_23395(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 23185, 23395);
return return_v;
}


int
f_1344_23416_23435(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 23416, 23435);
return return_v;
}


string
f_1344_23609_23625(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 23609, 23625);
return return_v;
}


object
f_1344_23557_23638(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetContentWriterDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 23557, 23638);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,22547,23693);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,22547,23693);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetContentWriterDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,24839,26588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25097,25251);

f_1344_25097_25250(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25267,25397);

f_1344_25267_25396(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25413,25549);

f_1344_25413_25548(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25565,25586);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25636,25711);

result = f_1344_25645_25710(providerInstance, path, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,25740,25823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25802,25808);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,25740,25823);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,25837,25916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25895,25901);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,25837,25916);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,25930,26016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,25995,26001);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,25930,26016);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,26030,26121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,26100,26106);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,26030,26121);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,26135,26547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,26223,26532);

throw f_1344_26229_26531(this, "GetContentWriterDynamicParametersProviderException", f_1344_26357_26427(), f_1344_26450_26479(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,26135,26547);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,26563,26577);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,24839,26588);

int
f_1344_25097_25250(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 25097, 25250);
return 0;
}


int
f_1344_25267_25396(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 25267, 25396);
return 0;
}


int
f_1344_25413_25548(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 25413, 25548);
return 0;
}


object
f_1344_25645_25710(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.GetContentWriterDynamicParameters( path, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 25645, 25710);
return return_v;
}


string
f_1344_26357_26427()
{
var return_v =                     SessionStateStrings.GetContentWriterDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 26357, 26427);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1344_26450_26479(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 26450, 26479);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1344_26229_26531(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 26229, 26531);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,24839,26588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,24839,26588);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ClearContent(string[] paths, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,27934,28455);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,28031,28151) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,28031,28151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,28082,28136);

throw f_1344_28088_28135("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,28031,28151);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,28167,28248);

CmdletProviderContext 
context = f_1344_28199_28247(f_1344_28225_28246(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,28262,28284);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,28298,28346);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,28362,28391);

f_1344_28362_28390(this, paths, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,28407,28444);

f_1344_28407_28443(
            context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,27934,28455);

System.Management.Automation.PSArgumentNullException
f_1344_28088_28135(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 28088, 28135);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1344_28225_28246(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 28225, 28246);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1344_28199_28247(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 28199, 28247);
return return_v;
}


int
f_1344_28362_28390(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearContent( paths, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 28362, 28390);
return 0;
}


int
f_1344_28407_28443(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 28407, 28443);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,27934,28455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,27934,28455);
}
		}

internal void ClearContent(
              string[] paths,
              CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,29807,30876);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,29936,30056) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,29936,30056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,29987,30041);

throw f_1344_29993_30040("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,29936,30056);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30072,30101);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30115,30154);

CmdletProvider 
providerInstance = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30170,30865);
foreach(string path in f_1344_30194_30199_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,30170,30865);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30233,30358) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,30233,30358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30291,30339);

f_1344_30291_30338("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,30233,30358);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30378,30663);

Collection<string> 
providerPaths =
f_1344_30434_30662(f_1344_30434_30441(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30683,30850);
foreach(string providerPath in f_1344_30715_30728_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,30683,30850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,30770,30831);

f_1344_30770_30830(this, providerInstance, providerPath, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,30683,30850);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1344,1,168);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1344,1,168);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1344,30170,30865);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1344,1,696);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1344,1,696);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1344,29807,30876);

System.Management.Automation.PSArgumentNullException
f_1344_29993_30040(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 29993, 30040);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1344_30291_30338(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 30291, 30338);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1344_30434_30441()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 30434, 30441);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_30434_30662(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 30434, 30662);
return return_v;
}


int
f_1344_30770_30830(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearContentPrivate( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 30770, 30830);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1344_30715_30728_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 30715, 30728);
return return_v;
}


string[]
f_1344_30194_30199_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 30194, 30199);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,29807,30876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,29807,30876);
}
		}

private void ClearContentPrivate(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,31824,33420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,32066,32220);

f_1344_32066_32219(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,32236,32366);

f_1344_32236_32365(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,32382,32518);

f_1344_32382_32517(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,32570,32615);

f_1344_32570_32614(                providerInstance, path, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,32644,32727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,32706,32712);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,32644,32727);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,32741,32820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,32799,32805);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,32741,32820);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,32834,32920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,32899,32905);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,32834,32920);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,32934,33025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,33004,33010);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,32934,33025);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,33039,33409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,33127,33394);

throw f_1344_33133_33393(this, "ClearContentProviderException", f_1344_33240_33289(), f_1344_33312_33341(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,33039,33409);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,31824,33420);

int
f_1344_32066_32219(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 32066, 32219);
return 0;
}


int
f_1344_32236_32365(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 32236, 32365);
return 0;
}


int
f_1344_32382_32517(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 32382, 32517);
return 0;
}


int
f_1344_32570_32614(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.ClearContent( path, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 32570, 32614);
return 0;
}


string
f_1344_33240_33289()
{
var return_v =                     SessionStateStrings.ClearContentProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 33240, 33289);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1344_33312_33341(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 33312, 33341);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1344_33133_33393(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 33133, 33393);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,31824,33420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,31824,33420);
}
		}

internal object ClearContentDynamicParameters(
             string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,34838,35976);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,34980,35057) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,34980,35057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35030,35042);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,34980,35057);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35073,35102);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35116,35155);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35171,35258);

CmdletProviderContext 
newContext =
f_1344_35223_35257(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35272,35404);

f_1344_35272_35403(            newContext, f_1344_35312_35336(), f_1344_35355_35379(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35420,35683);

Collection<string> 
providerPaths =
f_1344_35472_35682(f_1344_35472_35479(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35699,35937) || true) && (f_1344_35703_35722(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1344,35699,35937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35837,35922);

return f_1344_35844_35921(this, providerInstance, f_1344_35892_35908(providerPaths, 0), newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1344,35699,35937);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,35953,35965);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,34838,35976);

System.Management.Automation.CmdletProviderContext
f_1344_35223_35257(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 35223, 35257);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_35312_35336()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 35312, 35336);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_35355_35379()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 35355, 35379);
return return_v;
}


int
f_1344_35272_35403(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 35272, 35403);
return 0;
}


System.Management.Automation.LocationGlobber
f_1344_35472_35479()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 35472, 35479);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1344_35472_35682(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 35472, 35682);
return return_v;
}


int
f_1344_35703_35722(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 35703, 35722);
return return_v;
}


string
f_1344_35892_35908(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 35892, 35908);
return return_v;
}


object
f_1344_35844_35921(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ClearContentDynamicParameters( providerInstance, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 35844, 35921);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,34838,35976);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,34838,35976);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object ClearContentDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1344,37023,38756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,37277,37431);

f_1344_37277_37430(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,37447,37577);

f_1344_37447_37576(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,37593,37729);

f_1344_37593_37728(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,37745,37766);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,37816,37887);

result = f_1344_37825_37886(providerInstance, path, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,37916,37999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,37978,37984);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,37916,37999);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,38013,38092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,38071,38077);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,38013,38092);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,38106,38192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,38171,38177);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,38106,38192);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,38206,38297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,38276,38282);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,38206,38297);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1344,38311,38715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,38399,38700);

throw f_1344_38405_38699(this, "ClearContentDynamicParametersProviderException", f_1344_38529_38595(), f_1344_38618_38647(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1344,38311,38715);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1344,38731,38745);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1344,37023,38756);

int
f_1344_37277_37430(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 37277, 37430);
return 0;
}


int
f_1344_37447_37576(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 37447, 37576);
return 0;
}


int
f_1344_37593_37728(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 37593, 37728);
return 0;
}


object
f_1344_37825_37886(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.ClearContentDynamicParameters( path, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 37825, 37886);
return return_v;
}


string
f_1344_38529_38595()
{
var return_v =                     SessionStateStrings.ClearContentDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 38529, 38595);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1344_38618_38647(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1344, 38618, 38647);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1344_38405_38699(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1344, 38405, 38699);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1344,37023,38756);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1344,37023,38756);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}

#pragma warning restore 56500
