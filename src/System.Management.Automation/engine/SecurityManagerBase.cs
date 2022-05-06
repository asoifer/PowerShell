// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    /// <summary>
    /// This enum defines the dispatch origin of a command.
    /// </summary>
    public enum CommandOrigin
    {
        /// <summary>
        /// The command was submitted via a runspace.
        /// </summary>
        Runspace,

        /// <summary>
        /// The command was dispatched by the msh engine as a result of
        /// a dispatch request from an already running command.
        /// </summary>
        Internal
    }
public class AuthorizationManager
{
public AuthorizationManager(string shellId)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1337,1769,1866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,1927,1958);
this._policyCheckLock = f_1337_1946_1958();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,5716,5748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,1837,1855);

ShellId = shellId;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1337,1769,1866);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1337,1769,1866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1337,1769,1866);
}
		}

private object _policyCheckLock ;

internal void ShouldRunInternal(CommandInfo commandInfo,
                                        CommandOrigin origin,
                                        PSHost host)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1337,2685,5593);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3314,3541) || true) && (f_1337_3318_3341(commandInfo)== CommandTypes.ExternalScript)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,3314,3541);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3406,3526) || true) && (f_1337_3413_3477("PSCommandDiscoveryPreDelay")!= null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,3406,3526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3489,3524);

f_1337_3489_3523(100);
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,3406,3526);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1337,3406,3526);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1337,3406,3526);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1337,3314,3541);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3565,3585);

bool 
result = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3599,3625);

bool 
defaultCatch = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3639,3686);

Exception 
authorizationManagerException = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3744,3760);
                lock (_policyCheckLock)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,3802,3888);

result = f_1337_3811_3887(this, commandInfo, origin, host, out authorizationManagerException);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4028,4268) || true) && (f_1337_4032_4055(commandInfo)== CommandTypes.ExternalScript)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4028,4268);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4128,4249) || true) && (f_1337_4135_4200("PSCommandDiscoveryPostDelay")!= null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4128,4249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4212,4247);

f_1337_4212_4246(100);
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4128,4249);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1337,4128,4249);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1337,4128,4249);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4028,4268);
}
            }
            catch (Exception e) // Catch-all OK. 3rd party callout
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1337,4305,4514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4392,4426);

authorizationManagerException = e;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4446,4466);

defaultCatch = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4484,4499);

result = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1337,4305,4514);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4530,5574) || true) && (!result)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4530,5574);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4575,5559) || true) && (authorizationManagerException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4575,5559);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4658,5361) || true) && (authorizationManagerException is PSSecurityException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4658,5361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4764,4800);

throw authorizationManagerException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4658,5361);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4658,5361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4898,4953);

string 
message = f_1337_4915_4952(authorizationManagerException)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,4979,5156) || true) && (defaultCatch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4979,5156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,5053,5129);

message = f_1337_5063_5128();
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4979,5156);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,5184,5288);

PSSecurityException 
securityException = f_1337_5224_5287(message, authorizationManagerException)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,5314,5338);

throw securityException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4658,5361);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4575,5559);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1337,4575,5559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,5443,5540);

throw f_1337_5449_5539(f_1337_5473_5538());
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4575,5559);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1337,4530,5574);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1337,2685,5593);

System.Management.Automation.CommandTypes
f_1337_3318_3341(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1337, 3318, 3341);
return return_v;
}


string?
f_1337_3413_3477(string
variable)
{
var return_v = Environment.GetEnvironmentVariable( variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 3413, 3477);
return return_v;
}


int
f_1337_3489_3523(int
millisecondsTimeout)
{
System.Threading.Thread.Sleep( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 3489, 3523);
return 0;
}


bool
f_1337_3811_3887(System.Management.Automation.AuthorizationManager
this_param,System.Management.Automation.CommandInfo
commandInfo,System.Management.Automation.CommandOrigin
origin,System.Management.Automation.Host.PSHost
host,out System.Exception
reason)
{
var return_v = this_param.ShouldRun( commandInfo, origin, host, out reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 3811, 3887);
return return_v;
}


System.Management.Automation.CommandTypes
f_1337_4032_4055(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1337, 4032, 4055);
return return_v;
}


string?
f_1337_4135_4200(string
variable)
{
var return_v = Environment.GetEnvironmentVariable( variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 4135, 4200);
return return_v;
}


int
f_1337_4212_4246(int
millisecondsTimeout)
{
System.Threading.Thread.Sleep( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 4212, 4246);
return 0;
}


string
f_1337_4915_4952(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1337, 4915, 4952);
return return_v;
}


string
f_1337_5063_5128()
{
var return_v = AuthorizationManagerBase.AuthorizationManagerDefaultFailureReason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1337, 5063, 5128);
return return_v;
}


System.Management.Automation.PSSecurityException
f_1337_5224_5287(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.PSSecurityException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 5224, 5287);
return return_v;
}


string
f_1337_5473_5538()
{
var return_v = AuthorizationManagerBase.AuthorizationManagerDefaultFailureReason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1337, 5473, 5538);
return return_v;
}


System.Management.Automation.PSSecurityException
f_1337_5449_5539(string
message)
{
var return_v = new System.Management.Automation.PSSecurityException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 5449, 5539);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1337,2685,5593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1337,2685,5593);
}
		}

internal string ShellId {get; }

protected internal virtual bool ShouldRun(CommandInfo commandInfo,
                                                  CommandOrigin origin,
                                                  PSHost host,
                                                  out Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1337,6504,6958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,6805,6889);

f_1337_6805_6888(commandInfo != null, "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,6905,6919);

reason = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1337,6935,6947);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1337,6504,6958);

int
f_1337_6805_6888(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 6805, 6888);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1337,6504,6958);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1337,6504,6958);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static AuthorizationManager()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1337,1500,7025);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1337,1500,7025);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1337,1500,7025);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1337,1500,7025);

object
f_1337_1946_1958()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1337, 1946, 1958);
return return_v;
}

}
}

