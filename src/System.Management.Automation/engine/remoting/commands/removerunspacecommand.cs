// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Remoting;

using System.Management.Automation.Runspaces;
using System.Diagnostics.CodeAnalysis;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.Remove, "PSSession", SupportsShouldProcess = true,
            DefaultParameterSetName = RemovePSSessionCommand.IdParameterSet,
            HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096963", RemotingCapability = RemotingCapability.OwnedByCommand)]
    public class RemovePSSessionCommand : PSRunspaceCmdlet
{
[Parameter(Mandatory = true,
                   Position = 0,
                   ValueFromPipeline = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = RemovePSSessionCommand.SessionParameterSet)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public PSSession[] Session {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.ContainerIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public override string[] ContainerId {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.VMIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("VMGuid")]
        public override Guid[] VMId {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.VMNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public override string[] VMName {get; set; }

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1608,3943,8381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,4007,4046);

ICollection<PSSession> 
toRemove = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,4062,5253);

switch (f_1608_4070_4086())
            {

case RemovePSSessionCommand.ComputerNameParameterSet:
                case RemovePSSessionCommand.NameParameterSet:
                case RemovePSSessionCommand.InstanceIdParameterSet:
                case RemovePSSessionCommand.IdParameterSet:
                case RemovePSSessionCommand.ContainerIdParameterSet:
                case RemovePSSessionCommand.VMIdParameterSet:
                case RemovePSSessionCommand.VMNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1608,4062,5253);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,4613,4685);

Dictionary<Guid, PSSession> 
matches = f_1608_4651_4684(this, false, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,4713,4739);

toRemove = f_1608_4724_4738(matches);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1608,4786,4792);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1608,4062,5253);

case RemovePSSessionCommand.SessionParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1608,4062,5253);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,4907,4926);

toRemove = f_1608_4918_4925();
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1608,4973,4979);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1608,4062,5253);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1608,4062,5253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5027,5078);

f_1608_5027_5077(false, "Invalid Parameter Set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5100,5139);

toRemove = f_1608_5111_5138();
DynAbs.Tracing.TraceSender.TraceBreak(1608,5232,5238);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1608,4062,5253);
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5269,8370);
foreach(PSSession remoteRunspaceInfo in f_1608_5310_5318_I(toRemove) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1608,5269,8370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5352,5428);

RemoteRunspace 
remoteRunspace = (RemoteRunspace)f_1608_5400_5427(remoteRunspaceInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5448,8355) || true) && (f_1608_5452_5519(this, f_1608_5466_5508(f_1608_5466_5495(remoteRunspace)), "Remove"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1608,5448,8355);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5743,7378) || true) && (f_1608_5747_5798(f_1608_5747_5792(f_1608_5747_5774(remoteRunspaceInfo)))== RunspaceState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1608,5743,7378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5878,5900);

bool 
ConnectSucceeded
=default(bool);

                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,5988,6026);

f_1608_5988_6025(f_1608_5988_6015(remoteRunspaceInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,6056,6080);

ConnectSucceeded = true;
                        }
                        catch (InvalidRunspaceStateException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1608,6133,6279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,6227,6252);

ConnectSucceeded = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1608,6133,6279);
                        }
                        catch (PSRemotingTransportException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1608,6305,6450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,6398,6423);

ConnectSucceeded = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1608,6305,6450);
                        }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,6478,7355) || true) && (!ConnectSucceeded)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1608,6478,7355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,6734,6918);

string 
msg = f_1608_6747_6917(f_1608_6837_6886(), f_1608_6888_6916(remoteRunspace))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,6948,6993);

Exception 
reason = f_1608_6967_6992(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,7023,7192);

ErrorRecord 
errorRecord = f_1608_7049_7191(reason, "RemoveSessionCannotConnectToServer", ErrorCategory.InvalidOperation, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,7222,7246);

f_1608_7222_7245(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1608,6478,7355);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1608,5743,7378);
}

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,7651,7676);

f_1608_7651_7675(                        // Dispose internally calls Close() and Close()
                        // is a no-op if the state is not Opened, so just
                        // dispose the runspace
                        remoteRunspace);
                    }
                    catch (PSRemotingTransportException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1608,7721,7913);
DynAbs.Tracing.TraceSender.TraceExitCatch(1608,7721,7913);
                        // just ignore, there is some transport error
                        // on Close()
                    }

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,8057,8108);

f_1608_8057_8107(f_1608_8057_8080(this), remoteRunspaceInfo);
                    }
                    catch (ArgumentException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1608,8153,8336);
DynAbs.Tracing.TraceSender.TraceExitCatch(1608,8153,8336);
                        // just ignore, the runspace may already have
                        // been removed
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1608,5448,8355);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1608,5269,8370);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1608,1,3102);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1608,1,3102);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1608,3943,8381);

string
f_1608_4070_4086()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 4070, 4086);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1608_4651_4684(Microsoft.PowerShell.Commands.RemovePSSessionCommand
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspaces( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 4651, 4684);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
f_1608_4724_4738(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 4724, 4738);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1608_4918_4925()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 4918, 4925);
return return_v;
}


int
f_1608_5027_5077(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 5027, 5077);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1608_5111_5138()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 5111, 5138);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1608_5400_5427(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 5400, 5427);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1608_5466_5495(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 5466, 5495);
return return_v;
}


string
f_1608_5466_5508(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 5466, 5508);
return return_v;
}


bool
f_1608_5452_5519(Microsoft.PowerShell.Commands.RemovePSSessionCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 5452, 5519);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1608_5747_5774(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 5747, 5774);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1608_5747_5792(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 5747, 5792);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1608_5747_5798(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 5747, 5798);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1608_5988_6015(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 5988, 6015);
return return_v;
}


int
f_1608_5988_6025(System.Management.Automation.Runspaces.Runspace
this_param)
{
this_param.Connect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 5988, 6025);
return 0;
}


string
f_1608_6837_6886()
{
var return_v =                                 RemotingErrorIdStrings.RemoveRunspaceNotConnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 6837, 6886);
return return_v;
}


string
f_1608_6888_6916(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.PSSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 6888, 6916);
return return_v;
}


string
f_1608_6747_6917(string
formatSpec,string
o)
{
var return_v = System.Management.Automation.Internal.StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 6747, 6917);
return return_v;
}


System.Management.Automation.RuntimeException
f_1608_6967_6992(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 6967, 6992);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1608_7049_7191(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.RemoteRunspace
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 7049, 7191);
return return_v;
}


int
f_1608_7222_7245(Microsoft.PowerShell.Commands.RemovePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 7222, 7245);
return 0;
}


int
f_1608_7651_7675(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 7651, 7675);
return 0;
}


System.Management.Automation.RunspaceRepository
f_1608_8057_8080(Microsoft.PowerShell.Commands.RemovePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1608, 8057, 8080);
return return_v;
}


int
f_1608_8057_8107(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 8057, 8107);
return 0;
}


System.Collections.Generic.ICollection<System.Management.Automation.Runspaces.PSSession>
f_1608_5310_5318_I(System.Collections.Generic.ICollection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1608, 5310, 5318);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1608,3943,8381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1608,3943,8381);
}
		}

public RemovePSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1608,1108,8420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,1625,2021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,2117,2524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,2628,3046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1608,3150,3547);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1608,1108,8420);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1608,1108,8420);
}


static RemovePSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1608,1108,8420);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1608,1108,8420);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1608,1108,8420);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1608,1108,8420);
}
}
