// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using System.Xml;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
internal class ProviderContext
{
private readonly string _requestedPath;

private readonly ExecutionContext _executionContext;

private readonly PathIntrinsics _pathIntrinsics;

internal string RequestedPath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1169,816,889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,852,874);

return _requestedPath;
DynAbs.Tracing.TraceSender.TraceExitMethod(1169,816,889);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1169,762,900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1169,762,900);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ProviderContext(
            string requestedPath,
            ExecutionContext executionContext,
            PathIntrinsics pathIntrinsics)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1169,1014,1418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,539,553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,598,615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,658,673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,1191,1264);

f_1169_1191_1263(executionContext != null, "ExecutionContext cannot be null.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,1278,1309);

_requestedPath = requestedPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,1323,1360);

_executionContext = executionContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,1374,1407);

_pathIntrinsics = pathIntrinsics;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1169,1014,1418);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1169,1014,1418);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1169,1014,1418);
}
		}

internal MamlCommandHelpInfo GetProviderSpecificHelpInfo(string helpItemName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1169,1523,6018);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,1625,1912) || true) && (InternalTestHooks.BypassOnlineHelpRetrieval)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,1625,1912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,1885,1897);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,1625,1912);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,1962,1995);

ProviderInfo 
providerInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,2009,2038);

PSDriveInfo 
driveInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,2052,2087);

string 
resolvedProviderPath = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,2101,2192);

CmdletProviderContext 
cmdletProviderContext = f_1169_2147_2191(_executionContext)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,2244,2275);

string 
psPath = _requestedPath
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,2293,2440) || true) && (f_1169_2297_2333(_requestedPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,2293,2440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,2375,2421);

psPath = f_1169_2384_2420(f_1169_2384_2415(_pathIntrinsics));
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,2293,2440);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,2460,2686);

resolvedProviderPath = f_1169_2483_2685(f_1169_2483_2516(_executionContext), psPath, cmdletProviderContext, out providerInfo, out driveInfo);
            }
            // ignore exceptions caused by provider resolution
            catch (ArgumentNullException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1169,2779,2838);
DynAbs.Tracing.TraceSender.TraceExitCatch(1169,2779,2838);
            }
            catch (ProviderNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1169,2852,2915);
DynAbs.Tracing.TraceSender.TraceExitCatch(1169,2852,2915);
            }
            catch (DriveNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1169,2929,2989);
DynAbs.Tracing.TraceSender.TraceExitCatch(1169,2929,2989);
            }
            catch (ProviderInvocationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1169,3003,3068);
DynAbs.Tracing.TraceSender.TraceExitCatch(1169,3003,3068);
            }
            catch (NotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1169,3082,3141);
DynAbs.Tracing.TraceSender.TraceExitCatch(1169,3082,3141);
            }
            catch (InvalidOperationException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1169,3155,3218);
DynAbs.Tracing.TraceSender.TraceExitCatch(1169,3155,3218);
            }
            catch (ItemNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1169,3232,3291);
DynAbs.Tracing.TraceSender.TraceExitCatch(1169,3232,3291);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3307,3392) || true) && (providerInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,3307,3392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3365,3377);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,3307,3392);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3469,3531);

CmdletProvider 
cmdletProvider = f_1169_3501_3530(providerInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3545,3630);

ICmdletProviderSupportsHelp 
provider = cmdletProvider as ICmdletProviderSupportsHelp
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3758,3839) || true) && (provider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,3758,3839);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3812,3824);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,3758,3839);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3855,3881);

bool 
isJEASession = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,3895,4533) || true) && (f_1169_3899_3941(this._executionContext)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1169, 3899, 4013)&&f_1169_3953_4005(f_1169_3953_3995(this._executionContext))!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1169, 3899, 4037)&&providerInfo != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,3895,4533);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,4071,4518);
foreach(                    Runspaces.SessionStateProviderEntry sessionStateProvider in f_1169_4187_4258_I(f_1169_4187_4258(f_1169_4187_4239(f_1169_4187_4229(this._executionContext)), f_1169_4240_4257(providerInfo))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,4071,4518);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,4300,4499) || true) && (f_1169_4304_4335(sessionStateProvider)== SessionStateEntryVisibility.Private)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,4300,4499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,4424,4444);

isJEASession = true;
DynAbs.Tracing.TraceSender.TraceBreak(1169,4470,4476);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,4300,4499);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,4071,4518);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1169,1,448);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1169,1,448);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1169,3895,4533);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,4549,4899) || true) && (resolvedProviderPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,4549,4899);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,4615,4884) || true) && (isJEASession)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,4615,4884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,4673,4685);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,4615,4884);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,4615,4884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,4767,4865);

throw f_1169_4773_4864(_requestedPath, "PathNotFound", f_1169_4831_4863());
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,4615,4884);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,4549,4899);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5067,5125);

f_1169_5067_5124(
            // ok we have path and valid provider that supplys content..initialize the provider
            // and get the help content for the path.
            cmdletProvider, providerInfo, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5198,5241);

string 
providerPath = resolvedProviderPath
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5338,5410);

string 
mamlXmlString = f_1169_5361_5409(provider, helpItemName, providerPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5424,5524) || true) && (f_1169_5428_5463(mamlXmlString))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1169,5424,5524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5497,5509);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1169,5424,5524);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5604,5789);

XmlDocument 
mamlDoc = f_1169_5626_5788(mamlXmlString, false, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5841,5961);

MamlCommandHelpInfo 
providerSpecificHelpInfo = f_1169_5888_5960(f_1169_5913_5936(mamlDoc), HelpCategory.Provider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1169,5975,6007);

return providerSpecificHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1169,1523,6018);

System.Management.Automation.CmdletProviderContext
f_1169_2147_2191(System.Management.Automation.ExecutionContext
executionContext)
{
var return_v = new System.Management.Automation.CmdletProviderContext( executionContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 2147, 2191);
return return_v;
}


bool
f_1169_2297_2333(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 2297, 2333);
return return_v;
}


System.Management.Automation.PathInfo
f_1169_2384_2415(System.Management.Automation.PathIntrinsics
this_param)
{
var return_v = this_param.CurrentLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 2384, 2415);
return return_v;
}


string
f_1169_2384_2420(System.Management.Automation.PathInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 2384, 2420);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1169_2483_2516(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.LocationGlobber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 2483, 2516);
return return_v;
}


string
f_1169_2483_2685(System.Management.Automation.LocationGlobber
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetProviderPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 2483, 2685);
return return_v;
}


System.Management.Automation.Provider.CmdletProvider
f_1169_3501_3530(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.CreateInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 3501, 3530);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionState
f_1169_3899_3941(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.InitialSessionState ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 3899, 3941);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionState
f_1169_3953_3995(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.InitialSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 3953, 3995);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
f_1169_3953_4005(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Providers ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 3953, 4005);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionState
f_1169_4187_4229(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.InitialSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 4187, 4229);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
f_1169_4187_4239(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Providers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 4187, 4239);
return return_v;
}


string
f_1169_4240_4257(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 4240, 4257);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
f_1169_4187_4258(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 4187, 4258);
return return_v;
}


System.Management.Automation.SessionStateEntryVisibility
f_1169_4304_4335(System.Management.Automation.Runspaces.SessionStateProviderEntry
this_param)
{
var return_v = this_param.Visibility ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 4304, 4335);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
f_1169_4187_4258_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 4187, 4258);
return return_v;
}


string
f_1169_4831_4863()
{
var return_v = SessionStateStrings.PathNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 4831, 4863);
return return_v;
}


System.Management.Automation.ItemNotFoundException
f_1169_4773_4864(string
path,string
errorIdAndResourceId,string
resourceStr)
{
var return_v = new System.Management.Automation.ItemNotFoundException( path, errorIdAndResourceId, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 4773, 4864);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1169_5067_5124(System.Management.Automation.Provider.CmdletProvider
this_param,System.Management.Automation.ProviderInfo
providerInfo,System.Management.Automation.CmdletProviderContext
cmdletProviderContext)
{
var return_v = this_param.Start( providerInfo, cmdletProviderContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 5067, 5124);
return return_v;
}


string
f_1169_5361_5409(System.Management.Automation.Provider.ICmdletProviderSupportsHelp
this_param,string
helpItemName,string
path)
{
var return_v = this_param.GetHelpMaml( helpItemName, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 5361, 5409);
return return_v;
}


bool
f_1169_5428_5463(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 5428, 5463);
return return_v;
}


System.Xml.XmlDocument
f_1169_5626_5788(string
xmlContents,bool
preserveNonElements,int?
maxCharactersInDocument)
{
var return_v = InternalDeserializer.LoadUnsafeXmlDocument( xmlContents, preserveNonElements, maxCharactersInDocument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 5626, 5788);
return return_v;
}


System.Xml.XmlElement
f_1169_5913_5936(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.DocumentElement;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1169, 5913, 5936);
return return_v;
}


System.Management.Automation.MamlCommandHelpInfo
f_1169_5888_5960(System.Xml.XmlElement
xmlNode,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = MamlCommandHelpInfo.Load( (System.Xml.XmlNode)xmlNode, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 5888, 5960);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1169,1523,6018);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1169,1523,6018);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ProviderContext()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1169,392,6025);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1169,392,6025);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1169,392,6025);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1169,392,6025);

int
f_1169_1191_1263(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1169, 1191, 1263);
return 0;
}

}
}
