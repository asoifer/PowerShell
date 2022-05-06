// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Security.AccessControl;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
public sealed class SecurityDescriptorCmdletProviderIntrinsics
{
private SecurityDescriptorCmdletProviderIntrinsics()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1336,637,912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,9531,9538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,9578,9591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,714,901);

f_1336_714_900(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
DynAbs.Tracing.TraceSender.TraceExitConstructor(1336,637,912);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,637,912);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,637,912);
}
		}

internal SecurityDescriptorCmdletProviderIntrinsics(Cmdlet cmdlet)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1336,1248,1569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,9531,9538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,9578,9591);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,1339,1461) || true) && (cmdlet == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1336,1339,1461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,1391,1446);

throw f_1336_1397_1445("cmdlet");
DynAbs.Tracing.TraceSender.TraceExitCondition(1336,1339,1461);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,1477,1494);

_cmdlet = cmdlet;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,1508,1558);

_sessionState = f_1336_1524_1557(f_1336_1524_1538(cmdlet));
DynAbs.Tracing.TraceSender.TraceExitConstructor(1336,1248,1569);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,1248,1569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,1248,1569);
}
		}

internal SecurityDescriptorCmdletProviderIntrinsics(SessionStateInternal sessionState)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1336,1935,2236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,9531,9538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,9578,9591);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,2046,2180) || true) && (sessionState == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1336,2046,2180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,2104,2165);

throw f_1336_2110_2164("sessionState");
DynAbs.Tracing.TraceSender.TraceExitCondition(1336,2046,2180);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,2196,2225);

_sessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1336,1935,2236);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,1935,2236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,1935,2236);
}
		}

public Collection<PSObject> Get(string path, AccessControlSections includeSections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1336,2968,3403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,3076,3237);

f_1336_3076_3236(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,3326,3392);

return f_1336_3333_3391(_sessionState, path, includeSections);
DynAbs.Tracing.TraceSender.TraceExitMethod(1336,2968,3403);

int
f_1336_3076_3236(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 3076, 3236);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1336_3333_3391(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Security.AccessControl.AccessControlSections
sections)
{
var return_v = this_param.GetSecurityDescriptor( path, sections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 3333, 3391);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,2968,3403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,2968,3403);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Get(string path,
                        AccessControlSections includeSections,
                        CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1336,4195,4699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,4370,4531);

f_1336_4370_4530(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,4620,4688);

f_1336_4620_4687(
            // Parameter validation is done in the session state object
            _sessionState, path, includeSections, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1336,4195,4699);

int
f_1336_4370_4530(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 4370, 4530);
return 0;
}


int
f_1336_4620_4687(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Security.AccessControl.AccessControlSections
sections,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetSecurityDescriptor( path, sections, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 4620, 4687);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,4195,4699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,4195,4699);
}
		}

public Collection<PSObject> Set(string path, ObjectSecurity sd)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1336,5319,5774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,5407,5568);

f_1336_5407_5567(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,5657,5733);

Collection<PSObject> 
result = f_1336_5687_5732(_sessionState, path, sd)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,5749,5763);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1336,5319,5774);

int
f_1336_5407_5567(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 5407, 5567);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1336_5687_5732(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Security.AccessControl.ObjectSecurity
securityDescriptor)
{
var return_v = this_param.SetSecurityDescriptor( path, securityDescriptor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 5687, 5732);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,5319,5774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,5319,5774);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Set(string path, ObjectSecurity sd, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1336,6471,6894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,6576,6737);

f_1336_6576_6736(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,6828,6883);

f_1336_6828_6882(
            // Parameter validation is done in the session state object

            _sessionState, path, sd, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1336,6471,6894);

int
f_1336_6576_6736(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 6576, 6736);
return 0;
}


int
f_1336_6828_6882(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Security.AccessControl.ObjectSecurity
securityDescriptor,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetSecurityDescriptor( path, securityDescriptor, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 6828, 6882);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,6471,6894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,6471,6894);
}
		}

public ObjectSecurity NewFromPath(string path, AccessControlSections includeSections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1336,7619,8064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,7729,7890);

f_1336_7729_7889(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,7979,8053);

return f_1336_7986_8052(_sessionState, path, includeSections);
DynAbs.Tracing.TraceSender.TraceExitMethod(1336,7619,8064);

int
f_1336_7729_7889(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 7729, 7889);
return 0;
}


System.Security.AccessControl.ObjectSecurity
f_1336_7986_8052(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Security.AccessControl.AccessControlSections
sections)
{
var return_v = this_param.NewSecurityDescriptorFromPath( path, sections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 7986, 8052);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,7619,8064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,7619,8064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ObjectSecurity NewOfType(string providerId, string type, AccessControlSections includeSections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1336,8795,9391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,8922,9083);

f_1336_8922_9082(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1336,9174,9380);

return f_1336_9181_9379(_sessionState, providerId, type, includeSections);
DynAbs.Tracing.TraceSender.TraceExitMethod(1336,8795,9391);

int
f_1336_8922_9082(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 8922, 9082);
return 0;
}


System.Security.AccessControl.ObjectSecurity
f_1336_9181_9379(System.Management.Automation.SessionStateInternal
this_param,string
providerId,string
type,System.Security.AccessControl.AccessControlSections
sections)
{
var return_v = this_param.NewSecurityDescriptorOfType( providerId, type, sections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 9181, 9379);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1336,8795,9391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,8795,9391);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Cmdlet _cmdlet;

private SessionStateInternal _sessionState;

static SecurityDescriptorCmdletProviderIntrinsics()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1336,384,9634);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1336,384,9634);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1336,384,9634);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1336,384,9634);

int
f_1336_714_900(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 714, 900);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1336_1397_1445(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 1397, 1445);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1336_1524_1538(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1336, 1524, 1538);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1336_1524_1557(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1336, 1524, 1557);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1336_2110_2164(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1336, 2110, 2164);
return return_v;
}

}
}

