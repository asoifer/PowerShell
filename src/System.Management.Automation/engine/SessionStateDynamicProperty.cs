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
internal Collection<PSObject> NewProperty(
            string[] paths,
            string property,
            string type,
            object value,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,2411,3344);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,2646,2766) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,2646,2766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,2697,2751);

throw f_1346_2703_2750("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,2646,2766);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,2782,2908) || true) && (property == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,2782,2908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,2836,2893);

throw f_1346_2842_2892("property");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,2782,2908);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,2924,3005);

CmdletProviderContext 
context = f_1346_2956_3004(f_1346_2982_3003(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,3019,3041);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,3055,3103);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,3119,3170);

f_1346_3119_3169(this, paths, property, type, value, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,3186,3223);

f_1346_3186_3222(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,3239,3302);

Collection<PSObject> 
results = f_1346_3270_3301(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,3318,3333);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,2411,3344);

System.Management.Automation.PSArgumentNullException
f_1346_2703_2750(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 2703, 2750);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_2842_2892(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 2842, 2892);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1346_2982_3003(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 2982, 3003);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1346_2956_3004(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 2956, 3004);
return return_v;
}


int
f_1346_3119_3169(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,string
type,object
value,System.Management.Automation.CmdletProviderContext
context)
{
this_param.NewProperty( paths, property, type, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 3119, 3169);
return 0;
}


int
f_1346_3186_3222(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 3186, 3222);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1346_3270_3301(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 3270, 3301);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,2411,3344);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,2411,3344);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void NewProperty(
            string[] paths,
            string property,
            string type,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,5205,6515);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5412,5532) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,5412,5532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5463,5517);

throw f_1346_5469_5516("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,5412,5532);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5548,5674) || true) && (property == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,5548,5674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5602,5659);

throw f_1346_5608_5658("property");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,5548,5674);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5690,5719);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5733,5772);

CmdletProvider 
providerInstance = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5788,6504);
foreach(string path in f_1346_5812_5817_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,5788,6504);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5851,5982) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,5851,5982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,5909,5963);

throw f_1346_5915_5962("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,5851,5982);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,6002,6287);

Collection<string> 
providerPaths =
f_1346_6058_6286(f_1346_6058_6065(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,6307,6489);
foreach(string providerPath in f_1346_6339_6352_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,6307,6489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,6394,6470);

f_1346_6394_6469(this, providerInstance, providerPath, property, type, value, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,6307,6489);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,183);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,183);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1346,5788,6504);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,717);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,717);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1346,5205,6515);

System.Management.Automation.PSArgumentNullException
f_1346_5469_5516(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 5469, 5516);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_5608_5658(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 5608, 5658);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_5915_5962(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 5915, 5962);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1346_6058_6065()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 6058, 6065);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_6058_6286(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 6058, 6286);
return return_v;
}


int
f_1346_6394_6469(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
property,string
type,object
value,System.Management.Automation.CmdletProviderContext
context)
{
this_param.NewProperty( providerInstance, path, property, type, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 6394, 6469);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1346_6339_6352_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 6339, 6352);
return return_v;
}


string[]
f_1346_5812_5817_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 5812, 5817);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,5205,6515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,5205,6515);
}
		}

private void NewProperty(
            CmdletProvider providerInstance,
            string path,
            string property,
            string type,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,7783,9624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,8100,8254);

f_1346_8100_8253(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,8270,8400);

f_1346_8270_8399(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,8416,8550);

f_1346_8416_8549(property != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,8566,8702);

f_1346_8566_8701(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,8754,8821);

f_1346_8754_8820(                providerInstance, path, property, type, value, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,8850,8933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,8912,8918);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,8850,8933);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,8947,9026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,9005,9011);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,8947,9026);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,9040,9126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,9105,9111);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,9040,9126);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,9140,9231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,9210,9216);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,9140,9231);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,9245,9613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,9333,9598);

throw f_1346_9339_9597(this, "NewPropertyProviderException", f_1346_9445_9493(), f_1346_9516_9545(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,9245,9613);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,7783,9624);

int
f_1346_8100_8253(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 8100, 8253);
return 0;
}


int
f_1346_8270_8399(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 8270, 8399);
return 0;
}


int
f_1346_8416_8549(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 8416, 8549);
return 0;
}


int
f_1346_8566_8701(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 8566, 8701);
return 0;
}


int
f_1346_8754_8820(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
propertyName,string
propertyTypeName,object
value,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.NewProperty( path, propertyName, propertyTypeName, value, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 8754, 8820);
return 0;
}


string
f_1346_9445_9493()
{
var return_v =                     SessionStateStrings.NewPropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 9445, 9493);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_9516_9545(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 9516, 9545);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_9339_9597(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 9339, 9597);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,7783,9624);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,7783,9624);
}
		}

internal object NewPropertyDynamicParameters(
             string path,
            string propertyName,
            string type,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,11410,12660);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,11638,11715) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,11638,11715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,11688,11700);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,11638,11715);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,11731,11760);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,11774,11813);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,11829,11916);

CmdletProviderContext 
newContext =
f_1346_11881_11915(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,11930,12062);

f_1346_11930_12061(            newContext, f_1346_11970_11994(), f_1346_12013_12037(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,12078,12341);

Collection<string> 
providerPaths =
f_1346_12130_12340(f_1346_12130_12137(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,12357,12621) || true) && (f_1346_12361_12380(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,12357,12621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,12495,12606);

return f_1346_12502_12605(this, providerInstance, f_1346_12549_12565(providerPaths, 0), propertyName, type, value, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,12357,12621);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,12637,12649);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,11410,12660);

System.Management.Automation.CmdletProviderContext
f_1346_11881_11915(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 11881, 11915);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_11970_11994()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 11970, 11994);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_12013_12037()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 12013, 12037);
return return_v;
}


int
f_1346_11930_12061(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 11930, 12061);
return 0;
}


System.Management.Automation.LocationGlobber
f_1346_12130_12137()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 12130, 12137);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_12130_12340(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 12130, 12340);
return return_v;
}


int
f_1346_12361_12380(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 12361, 12380);
return return_v;
}


string
f_1346_12549_12565(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 12549, 12565);
return return_v;
}


object
f_1346_12502_12605(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
propertyName,string
type,object
value,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.NewPropertyDynamicParameters( providerInstance, path, propertyName, type, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 12502, 12605);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,11410,12660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,11410,12660);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object NewPropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string propertyName,
            string type,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,14107,15950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,14447,14601);

f_1346_14447_14600(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,14617,14747);

f_1346_14617_14746(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,14763,14899);

f_1346_14763_14898(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,14915,14936);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,14986,15083);

result = f_1346_14995_15082(providerInstance, path, propertyName, type, value, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,15112,15195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,15174,15180);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,15112,15195);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,15209,15288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,15267,15273);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,15209,15288);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,15302,15388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,15367,15373);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,15302,15388);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,15402,15493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,15472,15478);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,15402,15493);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,15507,15909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,15595,15894);

throw f_1346_15601_15893(this, "NewPropertyDynamicParametersProviderException", f_1346_15724_15789(), f_1346_15812_15841(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,15507,15909);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,15925,15939);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,14107,15950);

int
f_1346_14447_14600(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 14447, 14600);
return 0;
}


int
f_1346_14617_14746(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 14617, 14746);
return 0;
}


int
f_1346_14763_14898(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 14763, 14898);
return 0;
}


object
f_1346_14995_15082(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
propertyName,string
propertyTypeName,object
value,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.NewPropertyDynamicParameters( path, propertyName, propertyTypeName, value, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 14995, 15082);
return return_v;
}


string
f_1346_15724_15789()
{
var return_v =                     SessionStateStrings.NewPropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 15724, 15789);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_15812_15841(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 15812, 15841);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_15601_15893(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 15601, 15893);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,14107,15950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,14107,15950);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveProperty(string[] paths, string property, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,17441,18135);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,17557,17677) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,17557,17677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,17608,17662);

throw f_1346_17614_17661("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,17557,17677);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,17693,17819) || true) && (property == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,17693,17819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,17747,17804);

throw f_1346_17753_17803("property");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,17693,17819);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,17835,17916);

CmdletProviderContext 
context = f_1346_17867_17915(f_1346_17893_17914(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,17930,17952);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,17966,18014);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,18030,18071);

f_1346_18030_18070(this, paths, property, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,18087,18124);

f_1346_18087_18123(
            context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,17441,18135);

System.Management.Automation.PSArgumentNullException
f_1346_17614_17661(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 17614, 17661);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_17753_17803(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 17753, 17803);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1346_17893_17914(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 17893, 17914);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1346_17867_17915(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 17867, 17915);
return return_v;
}


int
f_1346_18030_18070(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveProperty( paths, property, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 18030, 18070);
return 0;
}


int
f_1346_18087_18123(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 18087, 18123);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,17441,18135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,17441,18135);
}
		}

internal void RemoveProperty(
            string[] paths,
            string property,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,19642,20900);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,19799,19919) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,19799,19919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,19850,19904);

throw f_1346_19856_19903("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,19799,19919);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,19935,20061) || true) && (property == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,19935,20061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,19989,20046);

throw f_1346_19995_20045("property");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,19935,20061);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20077,20889);
foreach(string path in f_1346_20101_20106_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,20077,20889);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20140,20271) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,20140,20271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20198,20252);

throw f_1346_20204_20251("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,20140,20271);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20291,20320);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20338,20377);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20397,20682);

Collection<string> 
providerPaths =
f_1346_20453_20681(f_1346_20453_20460(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20702,20874);
foreach(string providerPath in f_1346_20734_20747_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,20702,20874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,20789,20855);

f_1346_20789_20854(this, providerInstance, providerPath, property, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,20702,20874);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,173);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,173);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1346,20077,20889);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,813);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,813);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1346,19642,20900);

System.Management.Automation.PSArgumentNullException
f_1346_19856_19903(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 19856, 19903);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_19995_20045(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 19995, 20045);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_20204_20251(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 20204, 20251);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1346_20453_20460()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 20453, 20460);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_20453_20681(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 20453, 20681);
return return_v;
}


int
f_1346_20789_20854(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
property,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveProperty( providerInstance, path, property, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 20789, 20854);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1346_20734_20747_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 20734, 20747);
return return_v;
}


string[]
f_1346_20101_20106_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 20101, 20106);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,19642,20900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,19642,20900);
}
		}

private void RemoveProperty(
            CmdletProvider providerInstance,
            string path,
            string property,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,21958,23749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,22225,22379);

f_1346_22225_22378(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,22395,22525);

f_1346_22395_22524(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,22541,22679);

f_1346_22541_22678(property != null, "Caller should validate property before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,22695,22831);

f_1346_22695_22830(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,22883,22940);

f_1346_22883_22939(                providerInstance, path, property, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,22969,23052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,23031,23037);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,22969,23052);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,23066,23145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,23124,23130);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,23066,23145);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,23159,23245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,23224,23230);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,23159,23245);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,23259,23350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,23329,23335);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,23259,23350);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,23364,23738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,23452,23723);

throw f_1346_23458_23722(this, "RemovePropertyProviderException", f_1346_23567_23618(), f_1346_23641_23670(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,23364,23738);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,21958,23749);

int
f_1346_22225_22378(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 22225, 22378);
return 0;
}


int
f_1346_22395_22524(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 22395, 22524);
return 0;
}


int
f_1346_22541_22678(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 22541, 22678);
return 0;
}


int
f_1346_22695_22830(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 22695, 22830);
return 0;
}


int
f_1346_22883_22939(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
propertyName,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.RemoveProperty( path, propertyName, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 22883, 22939);
return 0;
}


string
f_1346_23567_23618()
{
var return_v =                     SessionStateStrings.RemovePropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 23567, 23618);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_23641_23670(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 23641, 23670);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_23458_23722(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 23458, 23722);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,21958,23749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,21958,23749);
}
		}

internal object RemovePropertyDynamicParameters(
             string path,
            string propertyName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,25298,26488);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,25476,25553) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,25476,25553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,25526,25538);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,25476,25553);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,25569,25598);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,25612,25651);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,25667,25753);

CmdletProviderContext 
newContext =
f_1346_25718_25752(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,25767,25899);

f_1346_25767_25898(            newContext, f_1346_25807_25831(), f_1346_25850_25874(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,25915,26179);

Collection<string> 
providerPaths =
f_1346_25968_26178(f_1346_25968_25975(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,26195,26449) || true) && (f_1346_26199_26218(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,26195,26449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,26333,26434);

return f_1346_26340_26433(this, providerInstance, f_1346_26390_26406(providerPaths, 0), propertyName, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,26195,26449);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,26465,26477);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,25298,26488);

System.Management.Automation.CmdletProviderContext
f_1346_25718_25752(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 25718, 25752);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_25807_25831()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 25807, 25831);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_25850_25874()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 25850, 25874);
return return_v;
}


int
f_1346_25767_25898(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 25767, 25898);
return 0;
}


System.Management.Automation.LocationGlobber
f_1346_25968_25975()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 25968, 25975);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_25968_26178(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 25968, 26178);
return return_v;
}


int
f_1346_26199_26218(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 26199, 26218);
return return_v;
}


string
f_1346_26390_26406(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 26390, 26406);
return return_v;
}


object
f_1346_26340_26433(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
propertyName,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RemovePropertyDynamicParameters( providerInstance, path, propertyName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 26340, 26433);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,25298,26488);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,25298,26488);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object RemovePropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string propertyName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,27738,29527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28028,28182);

f_1346_28028_28181(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28198,28328);

f_1346_28198_28327(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28344,28480);

f_1346_28344_28479(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28496,28517);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28567,28654);

result = f_1346_28576_28653(providerInstance, path, propertyName, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,28683,28766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28745,28751);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,28683,28766);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,28780,28859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28838,28844);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,28780,28859);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,28873,28959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,28938,28944);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,28873,28959);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,28973,29064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,29043,29049);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,28973,29064);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,29078,29486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,29166,29471);

throw f_1346_29172_29470(this, "RemovePropertyDynamicParametersProviderException", f_1346_29298_29366(), f_1346_29389_29418(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,29078,29486);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,29502,29516);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,27738,29527);

int
f_1346_28028_28181(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 28028, 28181);
return 0;
}


int
f_1346_28198_28327(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 28198, 28327);
return 0;
}


int
f_1346_28344_28479(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 28344, 28479);
return 0;
}


object
f_1346_28576_28653(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
propertyName,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.RemovePropertyDynamicParameters( path, propertyName, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 28576, 28653);
return return_v;
}


string
f_1346_29298_29366()
{
var return_v =                     SessionStateStrings.RemovePropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 29298, 29366);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_29389_29418(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 29389, 29418);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_29172_29470(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 29172, 29470);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,27738,29527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,27738,29527);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> CopyProperty(
            string[] sourcePaths,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,31541,32894);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,31814,31946) || true) && (sourcePaths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,31814,31946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,31871,31931);

throw f_1346_31877_31930("sourcePaths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,31814,31946);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,31962,32100) || true) && (sourceProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,31962,32100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32022,32085);

throw f_1346_32028_32084("sourceProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,31962,32100);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32116,32256) || true) && (destinationPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,32116,32256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32177,32241);

throw f_1346_32183_32240("destinationPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,32116,32256);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32272,32420) || true) && (destinationProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,32272,32420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32337,32405);

throw f_1346_32343_32404("destinationProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,32272,32420);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32436,32517);

CmdletProviderContext 
context = f_1346_32468_32516(f_1346_32494_32515(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32531,32553);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32567,32615);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32631,32720);

f_1346_32631_32719(this, sourcePaths, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32736,32773);

f_1346_32736_32772(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32789,32852);

Collection<PSObject> 
results = f_1346_32820_32851(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,32868,32883);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,31541,32894);

System.Management.Automation.PSArgumentNullException
f_1346_31877_31930(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 31877, 31930);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_32028_32084(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 32028, 32084);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_32183_32240(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 32183, 32240);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_32343_32404(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 32343, 32404);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1346_32494_32515(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 32494, 32515);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1346_32468_32516(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 32468, 32516);
return return_v;
}


int
f_1346_32631_32719(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 32631, 32719);
return 0;
}


int
f_1346_32736_32772(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 32736, 32772);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1346_32820_32851(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 32820, 32851);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,31541,32894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,31541,32894);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void CopyProperty(
            string[] sourcePaths,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,34919,38039);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35164,35296) || true) && (sourcePaths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,35164,35296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35221,35281);

throw f_1346_35227_35280("sourcePaths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,35164,35296);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35312,35450) || true) && (sourceProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,35312,35450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35372,35435);

throw f_1346_35378_35434("sourceProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,35312,35450);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35466,35606) || true) && (destinationPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,35466,35606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35527,35591);

throw f_1346_35533_35590("destinationPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,35466,35606);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35622,35770) || true) && (destinationProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,35622,35770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35687,35755);

throw f_1346_35693_35754("destinationProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,35622,35770);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35786,38028);
foreach(string sourcePath in f_1346_35816_35827_I(sourcePaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,35786,38028);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35861,36004) || true) && (sourcePath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,35861,36004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,35925,35985);

throw f_1346_35931_35984("sourcePaths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,35861,36004);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36024,36053);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36071,36110);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36130,36421);

Collection<string> 
providerPaths =
f_1346_36186_36420(f_1346_36186_36193(), sourcePath, false, context, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36441,38013) || true) && (f_1346_36445_36464(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,36441,38013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36564,36616);

Collection<string> 
includeFilters = f_1346_36600_36615(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36638,36690);

Collection<string> 
excludeFilters = f_1346_36674_36689(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36712,36749);

string 
filterString = f_1346_36734_36748(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,36861,37014);

f_1346_36861_37013(
                    // now modify the filters so that the destination isn't filtered

                    context, f_1346_36906_36930(), f_1346_36957_36981(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,37038,37369);

Collection<string> 
providerDestinationPaths =
f_1346_37109_37368(f_1346_37109_37116(), destinationPath, false, context, out provider, out providerInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,37443,37584);

f_1346_37443_37583(
                    // Now reapply the filters

                    context, includeFilters, excludeFilters, filterString);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,37608,37994);
foreach(string providerPath in f_1346_37640_37653_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,37608,37994);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,37703,37971);
foreach(string providerDestinationPath in f_1346_37746_37770_I(providerDestinationPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,37703,37971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,37828,37944);

f_1346_37828_37943(this, providerInstance, providerPath, sourceProperty, providerDestinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,37703,37971);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,269);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,269);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1346,37608,37994);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,387);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,387);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1346,36441,38013);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,35786,38028);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,2243);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,2243);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1346,34919,38039);

System.Management.Automation.PSArgumentNullException
f_1346_35227_35280(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 35227, 35280);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_35378_35434(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 35378, 35434);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_35533_35590(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 35533, 35590);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_35693_35754(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 35693, 35754);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_35931_35984(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 35931, 35984);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1346_36186_36193()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 36186, 36193);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_36186_36420(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 36186, 36420);
return return_v;
}


int
f_1346_36445_36464(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 36445, 36464);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_36600_36615(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 36600, 36615);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_36674_36689(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 36674, 36689);
return return_v;
}


string
f_1346_36734_36748(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Filter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 36734, 36748);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_36906_36930()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 36906, 36930);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_36957_36981()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 36957, 36981);
return return_v;
}


int
f_1346_36861_37013(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 36861, 37013);
return 0;
}


System.Management.Automation.LocationGlobber
f_1346_37109_37116()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 37109, 37116);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_37109_37368(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 37109, 37368);
return return_v;
}


int
f_1346_37443_37583(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 37443, 37583);
return 0;
}


int
f_1346_37828_37943(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyProperty( providerInstance, sourcePath, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 37828, 37943);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1346_37746_37770_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 37746, 37770);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_37640_37653_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 37640, 37653);
return return_v;
}


string[]
f_1346_35816_35827_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 35816, 35827);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,34919,38039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,34919,38039);
}
		}

private void CopyProperty(
            CmdletProvider providerInstance,
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,39340,41637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,39695,39849);

f_1346_39695_39848(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,39865,40007);

f_1346_39865_40006(sourcePath != null, "Caller should validate sourcePath before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,40023,40173);

f_1346_40023_40172(sourceProperty != null, "Caller should validate sourceProperty before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,40189,40341);

f_1346_40189_40340(destinationPath != null, "Caller should validate destinationPath before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,40357,40517);

f_1346_40357_40516(destinationProperty != null, "Caller should validate destinationProperty before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,40533,40669);

f_1346_40533_40668(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,40721,40826);

f_1346_40721_40825(                providerInstance, sourcePath, sourceProperty, destinationPath, destinationProperty, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,40855,40938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,40917,40923);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,40855,40938);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,40952,41031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,41010,41016);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,40952,41031);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,41045,41131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,41110,41116);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,41045,41131);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,41145,41236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,41215,41221);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,41145,41236);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,41250,41626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,41338,41611);

throw f_1346_41344_41610(this, "CopyPropertyProviderException", f_1346_41451_41500(), f_1346_41523_41552(providerInstance), sourcePath, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,41250,41626);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,39340,41637);

int
f_1346_39695_39848(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 39695, 39848);
return 0;
}


int
f_1346_39865_40006(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 39865, 40006);
return 0;
}


int
f_1346_40023_40172(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 40023, 40172);
return 0;
}


int
f_1346_40189_40340(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 40189, 40340);
return 0;
}


int
f_1346_40357_40516(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 40357, 40516);
return 0;
}


int
f_1346_40533_40668(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 40533, 40668);
return 0;
}


int
f_1346_40721_40825(System.Management.Automation.Provider.CmdletProvider
this_param,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.CopyProperty( sourcePath, sourceProperty, destinationPath, destinationProperty, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 40721, 40825);
return 0;
}


string
f_1346_41451_41500()
{
var return_v =                     SessionStateStrings.CopyPropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 41451, 41500);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_41523_41552(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 41523, 41552);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_41344_41610(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 41344, 41610);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,39340,41637);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,39340,41637);
}
		}

internal object CopyPropertyDynamicParameters(
             string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,43434,44867);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,43690,43767) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,43690,43767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,43740,43752);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,43690,43767);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,43783,43812);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,43826,43865);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,43881,43968);

CmdletProviderContext 
newContext =
f_1346_43933_43967(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,43982,44114);

f_1346_43982_44113(            newContext, f_1346_44022_44046(), f_1346_44065_44089(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,44130,44393);

Collection<string> 
providerPaths =
f_1346_44182_44392(f_1346_44182_44189(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,44409,44828) || true) && (f_1346_44413_44432(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,44409,44828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,44547,44813);

return f_1346_44554_44812(this, providerInstance, f_1346_44645_44661(providerPaths, 0), sourceProperty, destinationPath, destinationProperty, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,44409,44828);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,44844,44856);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,43434,44867);

System.Management.Automation.CmdletProviderContext
f_1346_43933_43967(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 43933, 43967);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_44022_44046()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 44022, 44046);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_44065_44089()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 44065, 44089);
return return_v;
}


int
f_1346_43982_44113(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 43982, 44113);
return 0;
}


System.Management.Automation.LocationGlobber
f_1346_44182_44189()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 44182, 44189);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_44182_44392(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 44182, 44392);
return return_v;
}


int
f_1346_44413_44432(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 44413, 44432);
return return_v;
}


string
f_1346_44645_44661(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 44645, 44661);
return return_v;
}


object
f_1346_44554_44812(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.CopyPropertyDynamicParameters( providerInstance, path, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 44554, 44812);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,43434,44867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,43434,44867);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object CopyPropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,46397,48404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,46765,46919);

f_1346_46765_46918(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,46935,47065);

f_1346_46935_47064(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,47081,47217);

f_1346_47081_47216(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,47233,47254);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,47304,47535);

result = f_1346_47313_47534(providerInstance, path, sourceProperty, destinationPath, destinationProperty, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,47564,47647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,47626,47632);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,47564,47647);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,47661,47740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,47719,47725);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,47661,47740);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,47754,47840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,47819,47825);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,47754,47840);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,47854,47945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,47924,47930);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,47854,47945);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,47959,48363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,48047,48348);

throw f_1346_48053_48347(this, "CopyPropertyDynamicParametersProviderException", f_1346_48177_48243(), f_1346_48266_48295(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,47959,48363);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,48379,48393);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,46397,48404);

int
f_1346_46765_46918(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 46765, 46918);
return 0;
}


int
f_1346_46935_47064(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 46935, 47064);
return 0;
}


int
f_1346_47081_47216(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 47081, 47216);
return 0;
}


object
f_1346_47313_47534(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.CopyPropertyDynamicParameters( path, sourceProperty, destinationPath, destinationProperty, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 47313, 47534);
return return_v;
}


string
f_1346_48177_48243()
{
var return_v =                     SessionStateStrings.CopyPropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 48177, 48243);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_48266_48295(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 48266, 48295);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_48053_48347(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 48053, 48347);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,46397,48404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,46397,48404);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> MoveProperty(
            string[] sourcePaths,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,50573,51926);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,50846,50978) || true) && (sourcePaths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,50846,50978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,50903,50963);

throw f_1346_50909_50962("sourcePaths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,50846,50978);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,50994,51132) || true) && (sourceProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,50994,51132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51054,51117);

throw f_1346_51060_51116("sourceProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,50994,51132);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51148,51288) || true) && (destinationPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,51148,51288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51209,51273);

throw f_1346_51215_51272("destinationPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,51148,51288);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51304,51452) || true) && (destinationProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,51304,51452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51369,51437);

throw f_1346_51375_51436("destinationProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,51304,51452);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51468,51549);

CmdletProviderContext 
context = f_1346_51500_51548(f_1346_51526_51547(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51563,51585);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51599,51647);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51663,51752);

f_1346_51663_51751(this, sourcePaths, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51768,51805);

f_1346_51768_51804(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51821,51884);

Collection<PSObject> 
results = f_1346_51852_51883(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,51900,51915);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,50573,51926);

System.Management.Automation.PSArgumentNullException
f_1346_50909_50962(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 50909, 50962);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_51060_51116(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 51060, 51116);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_51215_51272(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 51215, 51272);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_51375_51436(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 51375, 51436);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1346_51526_51547(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 51526, 51547);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1346_51500_51548(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 51500, 51548);
return return_v;
}


int
f_1346_51663_51751(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.MoveProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 51663, 51751);
return 0;
}


int
f_1346_51768_51804(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 51768, 51804);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1346_51852_51883(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 51852, 51883);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,50573,51926);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,50573,51926);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void MoveProperty(
            string[] sourcePaths,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,54108,57099);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54353,54485) || true) && (sourcePaths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,54353,54485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54410,54470);

throw f_1346_54416_54469("sourcePaths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,54353,54485);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54501,54639) || true) && (sourceProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,54501,54639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54561,54624);

throw f_1346_54567_54623("sourceProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,54501,54639);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54655,54795) || true) && (destinationPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,54655,54795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54716,54780);

throw f_1346_54722_54779("destinationPath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,54655,54795);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54811,54959) || true) && (destinationProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,54811,54959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54876,54944);

throw f_1346_54882_54943("destinationProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,54811,54959);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,54975,55004);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,55018,55057);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,55138,55216);

CmdletProviderContext 
destinationContext = f_1346_55181_55215(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,55232,55372);

f_1346_55232_55371(
            destinationContext, f_1346_55280_55304(), f_1346_55323_55347(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,55388,55682);

Collection<string> 
destinationProviderPaths =
f_1346_55451_55681(f_1346_55451_55458(), destinationPath, false, destinationContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,55698,57088) || true) && (f_1346_55702_55732(destinationProviderPaths)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,55698,57088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,55770,55989);

ArgumentException 
argException =
f_1346_55824_55988("destinationPath", f_1346_55929_55987())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,56009,56149);

f_1346_56009_56148(
                context, f_1346_56028_56147(argException, f_1346_56058_56089(f_1346_56058_56080(argException)), ErrorCategory.InvalidArgument, destinationProviderPaths));
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,55698,57088);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,55698,57088);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,56215,57073);
foreach(string sourcePath in f_1346_56245_56256_I(sourcePaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,56215,57073);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,56298,56453) || true) && (sourcePath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,56298,56453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,56370,56430);

throw f_1346_56376_56429("sourcePaths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,56298,56453);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,56477,56792);

Collection<string> 
providerPaths =
f_1346_56537_56791(f_1346_56537_56544(), sourcePath, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,56816,57054);
foreach(string providerPath in f_1346_56848_56861_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,56816,57054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,56911,57031);

f_1346_56911_57030(this, providerInstance, providerPath, sourceProperty, f_1346_56972_56999(destinationProviderPaths, 0), destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,56816,57054);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,239);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,239);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1346,56215,57073);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,859);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,859);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1346,55698,57088);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,54108,57099);

System.Management.Automation.PSArgumentNullException
f_1346_54416_54469(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 54416, 54469);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_54567_54623(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 54567, 54623);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_54722_54779(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 54722, 54779);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_54882_54943(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 54882, 54943);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1346_55181_55215(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 55181, 55215);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_55280_55304()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 55280, 55304);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_55323_55347()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 55323, 55347);
return return_v;
}


int
f_1346_55232_55371(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 55232, 55371);
return 0;
}


System.Management.Automation.LocationGlobber
f_1346_55451_55458()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 55451, 55458);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_55451_55681(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 55451, 55681);
return return_v;
}


int
f_1346_55702_55732(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 55702, 55732);
return return_v;
}


string
f_1346_55929_55987()
{
var return_v =                         SessionStateStrings.MovePropertyDestinationResolveToSingle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 55929, 55987);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1346_55824_55988(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 55824, 55988);
return return_v;
}


System.Type
f_1346_56058_56080(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56058, 56080);
return return_v;
}


string
f_1346_56058_56089(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 56058, 56089);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1346_56028_56147(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Collections.ObjectModel.Collection<string>
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56028, 56147);
return return_v;
}


int
f_1346_56009_56148(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56009, 56148);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1346_56376_56429(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56376, 56429);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1346_56537_56544()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 56537, 56544);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_56537_56791(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56537, 56791);
return return_v;
}


string
f_1346_56972_56999(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 56972, 56999);
return return_v;
}


int
f_1346_56911_57030(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.MoveProperty( providerInstance, sourcePath, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56911, 57030);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1346_56848_56861_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56848, 56861);
return return_v;
}


string[]
f_1346_56245_56256_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 56245, 56256);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,54108,57099);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,54108,57099);
}
		}

private void MoveProperty(
            CmdletProvider providerInstance,
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,58404,60701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,58759,58913);

f_1346_58759_58912(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,58929,59071);

f_1346_58929_59070(sourcePath != null, "Caller should validate sourcePath before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,59087,59237);

f_1346_59087_59236(sourceProperty != null, "Caller should validate sourceProperty before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,59253,59405);

f_1346_59253_59404(destinationPath != null, "Caller should validate destinationPath before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,59421,59581);

f_1346_59421_59580(destinationProperty != null, "Caller should validate destinationProperty before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,59597,59733);

f_1346_59597_59732(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,59785,59890);

f_1346_59785_59889(                providerInstance, sourcePath, sourceProperty, destinationPath, destinationProperty, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,59919,60002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,59981,59987);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,59919,60002);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,60016,60095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,60074,60080);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,60016,60095);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,60109,60195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,60174,60180);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,60109,60195);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,60209,60300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,60279,60285);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,60209,60300);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,60314,60690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,60402,60675);

throw f_1346_60408_60674(this, "MovePropertyProviderException", f_1346_60515_60564(), f_1346_60587_60616(providerInstance), sourcePath, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,60314,60690);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,58404,60701);

int
f_1346_58759_58912(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 58759, 58912);
return 0;
}


int
f_1346_58929_59070(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 58929, 59070);
return 0;
}


int
f_1346_59087_59236(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 59087, 59236);
return 0;
}


int
f_1346_59253_59404(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 59253, 59404);
return 0;
}


int
f_1346_59421_59580(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 59421, 59580);
return 0;
}


int
f_1346_59597_59732(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 59597, 59732);
return 0;
}


int
f_1346_59785_59889(System.Management.Automation.Provider.CmdletProvider
this_param,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.MoveProperty( sourcePath, sourceProperty, destinationPath, destinationProperty, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 59785, 59889);
return 0;
}


string
f_1346_60515_60564()
{
var return_v =                     SessionStateStrings.MovePropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 60515, 60564);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_60587_60616(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 60587, 60616);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_60408_60674(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 60408, 60674);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,58404,60701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,58404,60701);
}
		}

internal object MovePropertyDynamicParameters(
             string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,62497,63930);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,62753,62830) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,62753,62830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,62803,62815);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,62753,62830);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,62846,62875);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,62889,62928);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,62944,63031);

CmdletProviderContext 
newContext =
f_1346_62996_63030(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,63045,63177);

f_1346_63045_63176(            newContext, f_1346_63085_63109(), f_1346_63128_63152(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,63193,63456);

Collection<string> 
providerPaths =
f_1346_63245_63455(f_1346_63245_63252(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,63472,63891) || true) && (f_1346_63476_63495(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,63472,63891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,63610,63876);

return f_1346_63617_63875(this, providerInstance, f_1346_63708_63724(providerPaths, 0), sourceProperty, destinationPath, destinationProperty, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,63472,63891);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,63907,63919);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,62497,63930);

System.Management.Automation.CmdletProviderContext
f_1346_62996_63030(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 62996, 63030);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_63085_63109()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 63085, 63109);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_63128_63152()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 63128, 63152);
return return_v;
}


int
f_1346_63045_63176(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 63045, 63176);
return 0;
}


System.Management.Automation.LocationGlobber
f_1346_63245_63252()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 63245, 63252);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_63245_63455(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 63245, 63455);
return return_v;
}


int
f_1346_63476_63495(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 63476, 63495);
return return_v;
}


string
f_1346_63708_63724(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 63708, 63724);
return return_v;
}


object
f_1346_63617_63875(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MovePropertyDynamicParameters( providerInstance, path, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 63617, 63875);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,62497,63930);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,62497,63930);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object MovePropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,65460,67469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,65828,65982);

f_1346_65828_65981(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,65998,66128);

f_1346_65998_66127(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,66144,66280);

f_1346_66144_66279(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,66296,66317);

object 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,66369,66600);

result = f_1346_66378_66599(providerInstance, path, sourceProperty, destinationPath, destinationProperty, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,66629,66712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,66691,66697);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,66629,66712);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,66726,66805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,66784,66790);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,66726,66805);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,66819,66905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,66884,66890);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,66819,66905);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,66919,67010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,66989,66995);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,66919,67010);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,67024,67428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,67112,67413);

throw f_1346_67118_67412(this, "MovePropertyDynamicParametersProviderException", f_1346_67242_67308(), f_1346_67331_67360(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,67024,67428);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,67444,67458);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,65460,67469);

int
f_1346_65828_65981(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 65828, 65981);
return 0;
}


int
f_1346_65998_66127(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 65998, 66127);
return 0;
}


int
f_1346_66144_66279(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 66144, 66279);
return 0;
}


object
f_1346_66378_66599(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.MovePropertyDynamicParameters( path, sourceProperty, destinationPath, destinationProperty, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 66378, 66599);
return return_v;
}


string
f_1346_67242_67308()
{
var return_v =                     SessionStateStrings.MovePropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 67242, 67308);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_67331_67360(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 67331, 67360);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_67118_67412(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 67118, 67412);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,65460,67469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,65460,67469);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> RenameProperty(
            string[] sourcePaths,
            string sourceProperty,
            string destinationProperty,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,69195,70340);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69433,69565) || true) && (sourcePaths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,69433,69565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69490,69550);

throw f_1346_69496_69549("sourcePaths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,69433,69565);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69581,69719) || true) && (sourceProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,69581,69719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69641,69704);

throw f_1346_69647_69703("sourceProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,69581,69719);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69735,69883) || true) && (destinationProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,69735,69883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69800,69868);

throw f_1346_69806_69867("destinationProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,69735,69883);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69899,69980);

CmdletProviderContext 
context = f_1346_69931_69979(f_1346_69957_69978(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,69994,70016);

context.Force = force;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,70030,70078);

context.SuppressWildcardExpansion = literalPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,70094,70168);

f_1346_70094_70167(this, sourcePaths, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,70184,70221);

f_1346_70184_70220(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,70235,70298);

Collection<PSObject> 
results = f_1346_70266_70297(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,70314,70329);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,69195,70340);

System.Management.Automation.PSArgumentNullException
f_1346_69496_69549(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 69496, 69549);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_69647_69703(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 69647, 69703);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_69806_69867(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 69806, 69867);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1346_69957_69978(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 69957, 69978);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1346_69931_69979(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 69931, 69979);
return return_v;
}


int
f_1346_70094_70167(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
sourceProperty,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RenameProperty( paths, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 70094, 70167);
return 0;
}


int
f_1346_70184_70220(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 70184, 70220);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1346_70266_70297(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 70266, 70297);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,69195,70340);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,69195,70340);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RenameProperty(
            string[] paths,
            string sourceProperty,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,72071,73579);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72275,72395) || true) && (paths == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,72275,72395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72326,72380);

throw f_1346_72332_72379("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,72275,72395);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72411,72549) || true) && (sourceProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,72411,72549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72471,72534);

throw f_1346_72477_72533("sourceProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,72411,72549);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72565,72713) || true) && (destinationProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,72565,72713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72630,72698);

throw f_1346_72636_72697("destinationProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,72565,72713);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72729,73568);
foreach(string path in f_1346_72753_72758_I(paths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,72729,73568);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72792,72923) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,72792,72923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72850,72904);

throw f_1346_72856_72903("paths");
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,72792,72923);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72943,72972);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,72990,73029);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,73049,73334);

Collection<string> 
providerPaths =
f_1346_73105_73333(f_1346_73105_73112(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,73354,73553);
foreach(string providerPath in f_1346_73386_73399_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,73354,73553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,73441,73534);

f_1346_73441_73533(this, providerInstance, providerPath, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,73354,73553);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,200);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,200);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1346,72729,73568);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1346,1,840);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1346,1,840);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1346,72071,73579);

System.Management.Automation.PSArgumentNullException
f_1346_72332_72379(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 72332, 72379);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_72477_72533(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 72477, 72533);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_72636_72697(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 72636, 72697);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1346_72856_72903(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 72856, 72903);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1346_73105_73112()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 73105, 73112);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_73105_73333(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 73105, 73333);
return return_v;
}


int
f_1346_73441_73533(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
sourcePath,string
sourceProperty,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RenameProperty( providerInstance, sourcePath, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 73441, 73533);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1346_73386_73399_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 73386, 73399);
return return_v;
}


string[]
f_1346_72753_72758_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 72753, 72758);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,72071,73579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,72071,73579);
}
		}

private void RenameProperty(
            CmdletProvider providerInstance,
            string sourcePath,
            string sourceProperty,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,74760,76843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,75080,75234);

f_1346_75080_75233(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,75250,75392);

f_1346_75250_75391(sourcePath != null, "Caller should validate sourcePath before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,75408,75558);

f_1346_75408_75557(sourceProperty != null, "Caller should validate sourceProperty before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,75574,75734);

f_1346_75574_75733(destinationProperty != null, "Caller should validate destinationProperty before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,75750,75886);

f_1346_75750_75885(context != null, "Caller should validate context before calling this method");

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,75938,76028);

f_1346_75938_76027(                providerInstance, sourcePath, sourceProperty, destinationProperty, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,76057,76140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,76119,76125);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,76057,76140);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,76154,76233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,76212,76218);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,76154,76233);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,76247,76333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,76312,76318);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,76247,76333);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,76347,76438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,76417,76423);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,76347,76438);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,76452,76832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,76540,76817);

throw f_1346_76546_76816(this, "RenamePropertyProviderException", f_1346_76655_76706(), f_1346_76729_76758(providerInstance), sourcePath, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,76452,76832);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,74760,76843);

int
f_1346_75080_75233(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 75080, 75233);
return 0;
}


int
f_1346_75250_75391(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 75250, 75391);
return 0;
}


int
f_1346_75408_75557(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 75408, 75557);
return 0;
}


int
f_1346_75574_75733(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 75574, 75733);
return 0;
}


int
f_1346_75750_75885(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 75750, 75885);
return 0;
}


int
f_1346_75938_76027(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
propertyName,string
newPropertyName,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
this_param.RenameProperty( path, propertyName, newPropertyName, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 75938, 76027);
return 0;
}


string
f_1346_76655_76706()
{
var return_v =                     SessionStateStrings.RenamePropertyProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 76655, 76706);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_76729_76758(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 76729, 76758);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_76546_76816(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 76546, 76816);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,74760,76843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,74760,76843);
}
		}

internal object RenamePropertyDynamicParameters(
             string path,
            string sourceProperty,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,78520,79882);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,78741,78818) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,78741,78818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,78791,78803);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,78741,78818);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,78834,78863);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,78877,78916);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,78932,79019);

CmdletProviderContext 
newContext =
f_1346_78984_79018(context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,79033,79165);

f_1346_79033_79164(            newContext, f_1346_79073_79097(), f_1346_79116_79140(), null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,79181,79444);

Collection<string> 
providerPaths =
f_1346_79233_79443(f_1346_79233_79240(), path, true, newContext, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,79460,79843) || true) && (f_1346_79464_79483(providerPaths)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1346,79460,79843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,79598,79828);

return f_1346_79605_79827(this, providerInstance, f_1346_79698_79714(providerPaths, 0), sourceProperty, destinationProperty, newContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1346,79460,79843);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,79859,79871);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,78520,79882);

System.Management.Automation.CmdletProviderContext
f_1346_78984_79018(System.Management.Automation.CmdletProviderContext
contextToCopyFrom)
{
var return_v = new System.Management.Automation.CmdletProviderContext( contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 78984, 79018);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_79073_79097()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 79073, 79097);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_79116_79140()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 79116, 79140);
return return_v;
}


int
f_1346_79033_79164(System.Management.Automation.CmdletProviderContext
this_param,System.Collections.ObjectModel.Collection<string>
include,System.Collections.ObjectModel.Collection<string>
exclude,string
filter)
{
this_param.SetFilters( include, exclude, filter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 79033, 79164);
return 0;
}


System.Management.Automation.LocationGlobber
f_1346_79233_79240()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 79233, 79240);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1346_79233_79443(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 79233, 79443);
return return_v;
}


int
f_1346_79464_79483(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 79464, 79483);
return return_v;
}


string
f_1346_79698_79714(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 79698, 79714);
return return_v;
}


object
f_1346_79605_79827(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,string
sourceProperty,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RenamePropertyDynamicParameters( providerInstance, path, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 79605, 79827);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,78520,79882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,78520,79882);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object RenamePropertyDynamicParameters(
            CmdletProvider providerInstance,
            string path,
            string sourceProperty,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1346,81248,83188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,81581,81735);

f_1346_81581_81734(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,81751,81881);

f_1346_81751_81880(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,81897,82033);

f_1346_81897_82032(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,82049,82070);

object 
result = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,82120,82315);

result = f_1346_82129_82314(providerInstance, path, sourceProperty, destinationProperty, context);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,82344,82427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,82406,82412);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,82344,82427);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,82441,82520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,82499,82505);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,82441,82520);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,82534,82620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,82599,82605);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,82534,82620);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,82634,82725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,82704,82710);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,82634,82725);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1346,82739,83147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,82827,83132);

throw f_1346_82833_83131(this, "RenamePropertyDynamicParametersProviderException", f_1346_82959_83027(), f_1346_83050_83079(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1346,82739,83147);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1346,83163,83177);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1346,81248,83188);

int
f_1346_81581_81734(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 81581, 81734);
return 0;
}


int
f_1346_81751_81880(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 81751, 81880);
return 0;
}


int
f_1346_81897_82032(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 81897, 82032);
return 0;
}


object
f_1346_82129_82314(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,string
sourceProperty,string
destinationProperty,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.RenamePropertyDynamicParameters( path, sourceProperty, destinationProperty, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 82129, 82314);
return return_v;
}


string
f_1346_82959_83027()
{
var return_v =                     SessionStateStrings.RenamePropertyDynamicParametersProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 82959, 83027);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1346_83050_83079(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1346, 83050, 83079);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1346_82833_83131(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1346, 82833, 83131);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1346,81248,83188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1346,81248,83188);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}

#pragma warning restore 56500
