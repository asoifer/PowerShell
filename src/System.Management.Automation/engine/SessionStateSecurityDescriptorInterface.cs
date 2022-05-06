// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Provider;
using System.Security.AccessControl;

namespace System.Management.Automation
{
internal sealed partial class SessionStateInternal
{
internal static ISecurityDescriptorCmdletProvider GetPermissionProviderInstance(CmdletProvider providerInstance)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1357,1106,1854);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,1243,1385) || true) && (providerInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,1243,1385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,1305,1370);

throw f_1357_1311_1369("providerInstance");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,1243,1385);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,1401,1533);

ISecurityDescriptorCmdletProvider 
permissionCmdletProvider =
                providerInstance as ISecurityDescriptorCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,1549,1795) || true) && (permissionCmdletProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,1549,1795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,1619,1780);

throw
f_1357_1646_1779(f_1357_1711_1778());
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,1549,1795);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,1811,1843);

return permissionCmdletProvider;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1357,1106,1854);

System.Management.Automation.PSArgumentNullException
f_1357_1311_1369(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 1311, 1369);
return return_v;
}


string
f_1357_1711_1778()
{
var return_v =                         ProviderBaseSecurity.ISecurityDescriptorCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 1711, 1778);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1357_1646_1779(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 1646, 1779);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,1106,1854);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,1106,1854);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> GetSecurityDescriptor(string path,
                                                             AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,2440,3119);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,2623,2741) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,2623,2741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,2673,2726);

throw f_1357_2679_2725("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,2623,2741);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,2757,2838);

CmdletProviderContext 
context = f_1357_2789_2837(f_1357_2815_2836(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,2854,2901);

f_1357_2854_2900(this, path, sections, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,2917,2954);

f_1357_2917_2953(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,2970,3070);

Collection<PSObject> 
contextResults = f_1357_3008_3039(context)??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>>(1357, 3008, 3069)??f_1357_3043_3069())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,3086,3108);

return contextResults;
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,2440,3119);

System.Management.Automation.PSArgumentNullException
f_1357_2679_2725(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 2679, 2725);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1357_2815_2836(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 2815, 2836);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1357_2789_2837(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 2789, 2837);
return return_v;
}


int
f_1357_2854_2900(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Security.AccessControl.AccessControlSections
sections,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetSecurityDescriptor( path, sections, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 2854, 2900);
return 0;
}


int
f_1357_2917_2953(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 2917, 2953);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1357_3008_3039(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 3008, 3039);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1357_3043_3069()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 3043, 3069);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,2440,3119);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,2440,3119);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetSecurityDescriptor(
            string path,
            AccessControlSections sections,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,3982,4845);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,4158,4276) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,4158,4276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,4208,4261);

throw f_1357_4214_4260("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,4158,4276);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,4292,4321);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,4337,4376);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,4390,4651);

Collection<string> 
providerPaths =
f_1357_4442_4650(f_1357_4442_4449(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,4667,4834);
foreach(string providerPath in f_1357_4699_4712_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,4667,4834);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,4746,4819);

f_1357_4746_4818(this, providerInstance, providerPath, sections, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,4667,4834);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1357,1,168);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1357,1,168);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1357,3982,4845);

System.Management.Automation.PSArgumentNullException
f_1357_4214_4260(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 4214, 4260);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1357_4442_4449()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 4442, 4449);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1357_4442_4650(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 4442, 4650);
return return_v;
}


int
f_1357_4746_4818(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Security.AccessControl.AccessControlSections
sections,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetSecurityDescriptor( providerInstance, path, sections, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 4746, 4818);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1357_4699_4712_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 4699, 4712);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,3982,4845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,3982,4845);
}
		}

private void GetSecurityDescriptor(
            CmdletProvider providerInstance,
            string path,
            AccessControlSections sections,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,4857,6571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,5146,5296);

f_1357_5146_5295(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,5312,5438);

f_1357_5312_5437(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,5454,5586);

f_1357_5454_5585(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,5681,5729);

f_1357_5681_5728(providerInstance);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,5781,5845);

f_1357_5781_5844(                providerInstance, path, sections, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,5874,5953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,5932,5938);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,5874,5953);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,5967,6053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,6032,6038);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,5967,6053);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,6067,6158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,6137,6143);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,6067,6158);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,6172,6560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,6260,6545);

throw f_1357_6266_6544(this, "GetSecurityDescriptorProviderException", f_1357_6382_6440(), f_1357_6463_6492(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,6172,6560);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,4857,6571);

int
f_1357_5146_5295(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 5146, 5295);
return 0;
}


int
f_1357_5312_5437(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 5312, 5437);
return 0;
}


int
f_1357_5454_5585(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 5454, 5585);
return 0;
}


System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
f_1357_5681_5728(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetPermissionProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 5681, 5728);
return return_v;
}


int
f_1357_5781_5844(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Security.AccessControl.AccessControlSections
sections,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetSecurityDescriptor( path, sections, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 5781, 5844);
return 0;
}


string
f_1357_6382_6440()
{
var return_v =                     SessionStateStrings.GetSecurityDescriptorProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 6382, 6440);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1357_6463_6492(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 6463, 6492);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1357_6266_6544(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 6266, 6544);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,4857,6571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,4857,6571);
}
		}

internal Collection<PSObject> SetSecurityDescriptor(string path, ObjectSecurity securityDescriptor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,7184,8030);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7308,7426) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,7308,7426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7358,7411);

throw f_1357_7364_7410("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,7308,7426);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7442,7588) || true) && (securityDescriptor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,7442,7588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7506,7573);

throw f_1357_7512_7572("securityDescriptor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,7442,7588);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7604,7685);

CmdletProviderContext 
context = f_1357_7636_7684(f_1357_7662_7683(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7701,7758);

f_1357_7701_7757(this, path, securityDescriptor, context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7774,7811);

f_1357_7774_7810(
            context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7881,7981);

Collection<PSObject> 
contextResults = f_1357_7919_7950(context)??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>>(1357, 7919, 7980)??f_1357_7954_7980())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,7997,8019);

return contextResults;
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,7184,8030);

System.Management.Automation.PSArgumentNullException
f_1357_7364_7410(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 7364, 7410);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1357_7512_7572(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 7512, 7572);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1357_7662_7683(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 7662, 7683);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1357_7636_7684(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 7636, 7684);
return return_v;
}


int
f_1357_7701_7757(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Security.AccessControl.ObjectSecurity
securityDescriptor,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetSecurityDescriptor( path, securityDescriptor, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 7701, 7757);
return 0;
}


int
f_1357_7774_7810(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.ThrowFirstErrorOrDoNothing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 7774, 7810);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1357_7919_7950(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 7919, 7950);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1357_7954_7980()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 7954, 7980);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,7184,8030);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,7184,8030);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetSecurityDescriptor(
            string path,
            ObjectSecurity securityDescriptor,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,8914,10037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9093,9211) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,9093,9211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9143,9196);

throw f_1357_9149_9195("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,9093,9211);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9227,9373) || true) && (securityDescriptor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,9227,9373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9291,9358);

throw f_1357_9297_9357("securityDescriptor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,9227,9373);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9389,9418);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9434,9473);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9487,9748);

Collection<string> 
providerPaths =
f_1357_9539_9747(f_1357_9539_9546(), path, false, context, out provider, out providerInstance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9764,10026);
foreach(string providerPath in f_1357_9796_9809_I(providerPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,9764,10026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,9843,10011);

f_1357_9843_10010(this, providerInstance, providerPath, securityDescriptor, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,9764,10026);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1357,1,263);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1357,1,263);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1357,8914,10037);

System.Management.Automation.PSArgumentNullException
f_1357_9149_9195(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 9149, 9195);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1357_9297_9357(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 9297, 9357);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1357_9539_9546()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 9539, 9546);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1357_9539_9747(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, context, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 9539, 9747);
return return_v;
}


int
f_1357_9843_10010(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Security.AccessControl.ObjectSecurity
securityDescriptor,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetSecurityDescriptor( providerInstance, path, securityDescriptor, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 9843, 10010);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1357_9796_9809_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 9796, 9809);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,8914,10037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,8914,10037);
}
		}

private void SetSecurityDescriptor(
            CmdletProvider providerInstance,
            string path,
            ObjectSecurity securityDescriptor,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,10049,13458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,10341,10491);

f_1357_10341_10490(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,10507,10633);

f_1357_10507_10632(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,10649,10803);

f_1357_10649_10802(securityDescriptor != null, "Caller should validate securityDescriptor before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,10819,10951);

f_1357_10819_10950(context != null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,11046,11094);

f_1357_11046_11093(providerInstance);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,11146,11220);

f_1357_11146_11219(                providerInstance, path, securityDescriptor, context);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,11249,11328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,11307,11313);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,11249,11328);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,11342,11428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,11407,11413);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,11342,11428);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,11442,11533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,11512,11518);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,11442,11533);
            }
            catch (PrivilegeNotHeldException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,11547,11879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,11765,11864);

f_1357_11765_11863(                //
                // thrown if one tries to set SACL and does not have
                // SeSecurityPrivilege
                //
                context, f_1357_11784_11862(e, f_1357_11803_11823(f_1357_11803_11814(e)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,11547,11879);
            }
            catch (UnauthorizedAccessException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,11893,12262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,12148,12247);

f_1357_12148_12246(                //
                // thrown if
                // -- owner or pri. group are invalid OR
                // -- marta returns ERROR_ACCESS_DENIED
                //
                context, f_1357_12167_12245(e, f_1357_12186_12206(f_1357_12186_12197(e)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,11893,12262);
            }
            catch (NotSupportedException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,12276,12708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,12594,12693);

f_1357_12594_12692(                //
                // thrown if path points to an item that does not
                // support access control.
                //
                // for example, FAT or FAT32 file in case of file system provider
                //
                context, f_1357_12613_12691(e, f_1357_12632_12652(f_1357_12632_12643(e)), ErrorCategory.InvalidOperation, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,12276,12708);
            }
            catch (SystemException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,12722,13045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,12931,13030);

f_1357_12931_13029(                //
                // thrown if the CLR gets back unexpected error
                // from OS security or marta
                //
                context, f_1357_12950_13028(e, f_1357_12969_12989(f_1357_12969_12980(e)), ErrorCategory.InvalidOperation, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,12722,13045);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,13059,13447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,13147,13432);

throw f_1357_13153_13431(this, "SetSecurityDescriptorProviderException", f_1357_13269_13327(), f_1357_13350_13379(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,13059,13447);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,10049,13458);

int
f_1357_10341_10490(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 10341, 10490);
return 0;
}


int
f_1357_10507_10632(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 10507, 10632);
return 0;
}


int
f_1357_10649_10802(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 10649, 10802);
return 0;
}


int
f_1357_10819_10950(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 10819, 10950);
return 0;
}


System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
f_1357_11046_11093(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetPermissionProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 11046, 11093);
return return_v;
}


int
f_1357_11146_11219(System.Management.Automation.Provider.CmdletProvider
this_param,string
path,System.Security.AccessControl.ObjectSecurity
securityDescriptor,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetSecurityDescriptor( path, securityDescriptor, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 11146, 11219);
return 0;
}


System.Type
f_1357_11803_11814(System.Security.AccessControl.PrivilegeNotHeldException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 11803, 11814);
return return_v;
}


string
f_1357_11803_11823(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 11803, 11823);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1357_11784_11862(System.Security.AccessControl.PrivilegeNotHeldException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 11784, 11862);
return return_v;
}


int
f_1357_11765_11863(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 11765, 11863);
return 0;
}


System.Type
f_1357_12186_12197(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12186, 12197);
return return_v;
}


string
f_1357_12186_12206(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 12186, 12206);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1357_12167_12245(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12167, 12245);
return return_v;
}


int
f_1357_12148_12246(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12148, 12246);
return 0;
}


System.Type
f_1357_12632_12643(System.NotSupportedException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12632, 12643);
return return_v;
}


string
f_1357_12632_12652(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 12632, 12652);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1357_12613_12691(System.NotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12613, 12691);
return return_v;
}


int
f_1357_12594_12692(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12594, 12692);
return 0;
}


System.Type
f_1357_12969_12980(System.SystemException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12969, 12980);
return return_v;
}


string
f_1357_12969_12989(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 12969, 12989);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1357_12950_13028(System.SystemException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12950, 13028);
return return_v;
}


int
f_1357_12931_13029(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 12931, 13029);
return 0;
}


string
f_1357_13269_13327()
{
var return_v =                     SessionStateStrings.SetSecurityDescriptorProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 13269, 13327);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1357_13350_13379(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 13350, 13379);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1357_13153_13431(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 13153, 13431);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,10049,13458);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,10049,13458);
}
		}

internal ObjectSecurity NewSecurityDescriptorFromPath(
            string path,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,14288,15498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,14438,14463);

ObjectSecurity 
sd = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,14479,14597) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,14479,14597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,14529,14582);

throw f_1357_14535_14581("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,14479,14597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,14613,14642);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,14658,14697);

CmdletProvider 
providerInstance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,14711,14942);

Collection<string> 
providerPaths =
f_1357_14763_14941(f_1357_14763_14770(), path, false, out provider, out providerInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,15084,15461) || true) && (f_1357_15088_15107(providerPaths)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,15084,15461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,15146,15331);

sd = f_1357_15151_15330(this, providerInstance, f_1357_15251_15267(providerPaths, 0), sections);
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,15084,15461);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,15084,15461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,15397,15446);

throw f_1357_15403_15445("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,15084,15461);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,15477,15487);

return sd;
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,14288,15498);

System.Management.Automation.PSArgumentNullException
f_1357_14535_14581(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 14535, 14581);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1357_14763_14770()
{
var return_v = Globber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 14763, 14770);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1357_14763_14941(System.Management.Automation.LocationGlobber
this_param,string
path,bool
allowNonexistingPaths,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = this_param.GetGlobbedProviderPathsFromMonadPath( path, allowNonexistingPaths, out provider, out providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 14763, 14941);
return return_v;
}


int
f_1357_15088_15107(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 15088, 15107);
return return_v;
}


string
f_1357_15251_15267(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 15251, 15267);
return return_v;
}


System.Security.AccessControl.ObjectSecurity
f_1357_15151_15330(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
path,System.Security.AccessControl.AccessControlSections
sections)
{
var return_v = this_param.NewSecurityDescriptorFromPath( providerInstance, path, sections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 15151, 15330);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1357_15403_15445(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 15403, 15445);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,14288,15498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,14288,15498);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ObjectSecurity NewSecurityDescriptorFromPath(
            CmdletProvider providerInstance,
            string path,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,15510,17399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,15705,15730);

ObjectSecurity 
sd = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,15814,15964);

f_1357_15814_15963(providerInstance != null, "Caller should validate providerInstance before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,15980,16106);

f_1357_15980_16105(path != null, "Caller should validate path before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,16122,16263);

f_1357_16122_16262(f_1357_16159_16175()!= null, "Caller should validate context before calling this method");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,16358,16470);

ISecurityDescriptorCmdletProvider 
sdProvider =
f_1357_16422_16469(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,16522,16647);

sd = f_1357_16527_16646(sdProvider, path, sections);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,16676,16755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,16734,16740);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,16676,16755);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,16769,16855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,16834,16840);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,16769,16855);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,16869,16960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,16939,16945);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,16869,16960);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,16974,17362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,17062,17347);

throw f_1357_17068_17346(this, "NewSecurityDescriptorProviderException", f_1357_17184_17242(), f_1357_17265_17294(providerInstance), path, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,16974,17362);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,17378,17388);

return sd;
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,15510,17399);

int
f_1357_15814_15963(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 15814, 15963);
return 0;
}


int
f_1357_15980_16105(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 15980, 16105);
return 0;
}


System.Management.Automation.ExecutionContext
f_1357_16159_16175()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 16159, 16175);
return return_v;
}


int
f_1357_16122_16262(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 16122, 16262);
return 0;
}


System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
f_1357_16422_16469(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetPermissionProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 16422, 16469);
return return_v;
}


System.Security.AccessControl.ObjectSecurity
f_1357_16527_16646(System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
this_param,string
path,System.Security.AccessControl.AccessControlSections
includeSections)
{
var return_v = this_param.NewSecurityDescriptorFromPath( path, includeSections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 16527, 16646);
return return_v;
}


string
f_1357_17184_17242()
{
var return_v =                     SessionStateStrings.GetSecurityDescriptorProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 17184, 17242);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1357_17265_17294(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 17265, 17294);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1357_17068_17346(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 17068, 17346);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,15510,17399);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,15510,17399);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ObjectSecurity NewSecurityDescriptorOfType(
            string providerId,
            string type,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,18094,18434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,18274,18340);

CmdletProvider 
providerInstance = f_1357_18308_18339(this, providerId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,18354,18423);

return f_1357_18361_18422(this, providerInstance, type, sections);
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,18094,18434);

System.Management.Automation.Provider.CmdletProvider
f_1357_18308_18339(System.Management.Automation.SessionStateInternal
this_param,string
providerId)
{
var return_v = this_param.GetProviderInstance( providerId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 18308, 18339);
return return_v;
}


System.Security.AccessControl.ObjectSecurity
f_1357_18361_18422(System.Management.Automation.SessionStateInternal
this_param,System.Management.Automation.Provider.CmdletProvider
providerInstance,string
type,System.Security.AccessControl.AccessControlSections
sections)
{
var return_v = this_param.NewSecurityDescriptorOfType( providerInstance, type, sections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 18361, 18422);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,18094,18434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,18094,18434);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ObjectSecurity NewSecurityDescriptorOfType(
            CmdletProvider providerInstance,
            string type,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1357,19212,20855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,19406,19431);

ObjectSecurity 
sd = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,19447,19565) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,19447,19565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,19497,19550);

throw f_1357_19503_19549("type");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,19447,19565);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,19581,19723) || true) && (providerInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1357,19581,19723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,19643,19708);

throw f_1357_19649_19707("providerInstance");
DynAbs.Tracing.TraceSender.TraceExitCondition(1357,19581,19723);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,19818,19930);

ISecurityDescriptorCmdletProvider 
sdProvider =
f_1357_19882_19929(providerInstance)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,19982,20103);

sd = f_1357_19987_20102(sdProvider, type, sections);
            }
            catch (LoopFlowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,20132,20211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,20190,20196);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,20132,20211);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,20225,20311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,20290,20296);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,20225,20311);
            }
            catch (ActionPreferenceStopException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,20325,20416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,20395,20401);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,20325,20416);
            }
            catch (Exception e) // Catch-all OK, 3rd party callout.
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1357,20430,20818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,20518,20803);

throw f_1357_20524_20802(this, "NewSecurityDescriptorProviderException", f_1357_20640_20698(), f_1357_20721_20750(providerInstance), type, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1357,20430,20818);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1357,20834,20844);

return sd;
DynAbs.Tracing.TraceSender.TraceExitMethod(1357,19212,20855);

System.Management.Automation.PSArgumentNullException
f_1357_19503_19549(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 19503, 19549);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1357_19649_19707(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 19649, 19707);
return return_v;
}


System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
f_1357_19882_19929(System.Management.Automation.Provider.CmdletProvider
providerInstance)
{
var return_v = GetPermissionProviderInstance( providerInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 19882, 19929);
return return_v;
}


System.Security.AccessControl.ObjectSecurity
f_1357_19987_20102(System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
this_param,string
type,System.Security.AccessControl.AccessControlSections
includeSections)
{
var return_v = this_param.NewSecurityDescriptorOfType( type, includeSections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 19987, 20102);
return return_v;
}


string
f_1357_20640_20698()
{
var return_v =                     SessionStateStrings.GetSecurityDescriptorProviderException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 20640, 20698);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1357_20721_20750(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1357, 20721, 20750);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1357_20524_20802(System.Management.Automation.SessionStateInternal
this_param,string
resourceId,string
resourceStr,System.Management.Automation.ProviderInfo
provider,string
path,System.Exception
e)
{
var return_v = this_param.NewProviderInvocationException( resourceId, resourceStr, provider, path, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1357, 20524, 20802);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1357,19212,20855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1357,19212,20855);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}

