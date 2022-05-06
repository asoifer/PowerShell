// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Threading;

using Microsoft.PowerShell.Commands.Internal.Format;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.Enter, "PSSession", DefaultParameterSetName = "ComputerName",
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096695", RemotingCapability = RemotingCapability.OwnedByCommand)]
    public class EnterPSSessionCommand : PSRemotingBaseCmdlet
{
private const string 
InstanceIdParameterSet = "InstanceId"
;

private const string 
IdParameterSet = "Id"
;

private const string 
NameParameterSet = "Name"
;

public new int ThrottleLimit {
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,1429,1436);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,1429,1436);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,1398,1456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,1398,1456);
}
		}
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,1437,1454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,1443,1452);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,1437,1454);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,1398,1456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,1398,1456);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private ObjectStream _stream;

private RemoteRunspace _tempRunspace;

[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true,
            ParameterSetName = PSRemotingBaseCmdlet.SSHHostParameterSet)]
        [ValidateNotNullOrEmpty()]
        public new string HostName {get; set; }

[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true, ParameterSetName = ComputerNameParameterSet)]
        [Alias("Cn")]
        [ValidateNotNullOrEmpty]
        public new string ComputerName {get; set; }

[Parameter(Position = 0, ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true, ParameterSetName = SessionParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        public new PSSession Session {get; set; }

[Parameter(Position = 1, ValueFromPipelineByPropertyName = true,
            ParameterSetName = UriParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("URI", "CU")]
        public new Uri ConnectionUri {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
        ParameterSetName = InstanceIdParameterSet)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        public Guid InstanceId {get; set; }

[Parameter(Position = 0,
            ValueFromPipelineByPropertyName = true,
             ParameterSetName = IdParameterSet)]
        [ValidateNotNull]
        public int Id {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
        ParameterSetName = NameParameterSet)]
        public string Name {get; set; }

[Parameter(ParameterSetName = ComputerNameParameterSet)]
        [Parameter(ParameterSetName = UriParameterSet)]
        public SwitchParameter EnableNetworkAccess {get; set; }

[ValidateNotNullOrEmpty]
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true, ParameterSetName = VMIdParameterSet)]
        [Alias("VMGuid")]
        public new Guid VMId {get; set; }

[ValidateNotNullOrEmpty]
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true, ParameterSetName = VMNameParameterSet)]
        public new string VMName {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true,
                   ParameterSetName = VMIdParameterSet)]
        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true,
                   ParameterSetName = VMNameParameterSet)]
        [Credential()]
        public override PSCredential Credential
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,6393,6424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,6399,6422);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Credential,1603,6406,6421);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,6393,6424);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,5718,6483);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,5718,6483);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,6440,6472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,6446,6470);

base.Credential = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,6440,6472);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,5718,6483);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,5718,6483);
}
		}}

[ValidateNotNullOrEmpty]
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true, ParameterSetName = ContainerIdParameterSet)]
        public new string ContainerId {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = EnterPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = EnterPSSessionCommand.UriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = EnterPSSessionCommand.ContainerIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = EnterPSSessionCommand.VMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = EnterPSSessionCommand.VMNameParameterSet)]
        public string ConfigurationName {get; set; }

public override Hashtable[] SSHConnection
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,8300,8320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,8306,8318);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,8300,8320);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,8234,8331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,8234,8331);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,8508,9228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,8574,8597);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1603,8574,8596);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,8613,9217) || true) && (f_1603_8617_8656(f_1603_8638_8655()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,8613,9217);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,8690,9202) || true) && ((f_1603_8695_8711()== EnterPSSessionCommand.ComputerNameParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1603, 8694, 8846)||                    (f_1603_8788_8804()== EnterPSSessionCommand.UriParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,8690,9202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,8951,8990);

ConfigurationName = f_1603_8971_8989(this, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,8690,9202);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,8690,9202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,9150,9183);

ConfigurationName = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,8690,9202);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,8613,9217);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,8508,9228);

string
f_1603_8638_8655()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 8638, 8655);
return return_v;
}


bool
f_1603_8617_8656(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 8617, 8656);
return return_v;
}


string
f_1603_8695_8711()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 8695, 8711);
return return_v;
}


string
f_1603_8788_8804()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 8788, 8804);
return return_v;
}


string
f_1603_8971_8989(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
shell)
{
var return_v = this_param.ResolveShell( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 8971, 8989);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,8508,9228);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,8508,9228);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,9316,21550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,9440,9524);

IHostSupportsInteractiveSession 
host = f_1603_9479_9488(this)as IHostSupportsInteractiveSession
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,9538,9967) || true) && (host == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,9538,9967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,9588,9927);

f_1603_9588_9926(this, f_1603_9621_9925(f_1603_9663_9751(f_1603_9685_9750(this, f_1603_9696_9749())), f_1603_9778_9837(                        PSRemotingErrorId.HostDoesNotSupportPushRunspace), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,9945,9952);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,9538,9967);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,10113,10973) || true) && (!f_1603_10118_10139(this)&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 10117, 10189)&&                !f_1603_10161_10189(this))&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 10117, 10248)&&                !f_1603_10211_10248(this))&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 10117, 10289)&&f_1603_10269_10281(this)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 10117, 10350)&&f_1603_10310_10342(f_1603_10310_10322(this))!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 10117, 10424)&&f_1603_10371_10416(f_1603_10371_10403(f_1603_10371_10383(this)))!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 10117, 10548)&&f_1603_10445_10490(f_1603_10445_10477(f_1603_10445_10457(this)))is System.Management.Automation.Remoting.ServerRemoteHost))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,10113,10973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,10582,10933);

f_1603_10582_10932(this, f_1603_10615_10931(f_1603_10657_10751(f_1603_10679_10750(this, f_1603_10690_10749())), f_1603_10778_10843(                        PSRemotingErrorId.RemoteHostDoesNotSupportPushRunspace), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,10951,10958);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,10113,10973);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,11168,11318);

System.Management.Automation.Internal.Host.InternalHost 
chost =
f_1603_11249_11258(this)as System.Management.Automation.Internal.Host.InternalHost
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,11334,11847) || true) && (!f_1603_11339_11360(this)&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 11338, 11410)&&                !f_1603_11382_11410(this))&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 11338, 11469)&&                !f_1603_11432_11469(this))&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 11338, 11503)&&                chost != null )&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 11338, 11533)&&f_1603_11507_11533(chost)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,11334,11847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,11567,11832);

f_1603_11567_11831(this, f_1603_11589_11830(f_1603_11627_11747(f_1603_11657_11746(f_1603_11704_11745())), "HostInNestedPrompt", ErrorCategory.InvalidOperation, chost));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,11334,11847);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,12419,12456);

RemoteRunspace 
remoteRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,12470,13902);

switch (f_1603_12478_12494())
            {

case ComputerNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,12580,12648);

remoteRunspace = f_1603_12597_12647(this);
DynAbs.Tracing.TraceSender.TraceBreak(1603,12670,12676);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case UriParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,12739,12798);

remoteRunspace = f_1603_12756_12797(this);
DynAbs.Tracing.TraceSender.TraceBreak(1603,12820,12826);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case SessionParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,12893,12943);

remoteRunspace = (RemoteRunspace)f_1603_12926_12942(f_1603_12926_12933());
DynAbs.Tracing.TraceSender.TraceBreak(1603,12965,12971);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case InstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,13041,13105);

remoteRunspace = f_1603_13058_13104(this, f_1603_13088_13103(this));
DynAbs.Tracing.TraceSender.TraceBreak(1603,13127,13133);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case IdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,13195,13250);

remoteRunspace = f_1603_13212_13249(this, f_1603_13241_13248(this));
DynAbs.Tracing.TraceSender.TraceBreak(1603,13272,13278);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,13342,13394);

remoteRunspace = f_1603_13359_13393(this, f_1603_13383_13392(this));
DynAbs.Tracing.TraceSender.TraceBreak(1603,13416,13422);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case VMIdParameterSet:
                case VMNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,13528,13571);

remoteRunspace = f_1603_13545_13570(this);
DynAbs.Tracing.TraceSender.TraceBreak(1603,13593,13599);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case ContainerIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,13670,13720);

remoteRunspace = f_1603_13687_13719(this);
DynAbs.Tracing.TraceSender.TraceBreak(1603,13742,13748);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);

case SSHHostParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,12470,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,13815,13859);

remoteRunspace = f_1603_13832_13858(this);
DynAbs.Tracing.TraceSender.TraceBreak(1603,13881,13887);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,12470,13902);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14018,14057) || true) && (remoteRunspace == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,14018,14057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14048,14055);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,14018,14057);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14148,14179);

bool 
runspaceConnected = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14193,15908) || true) && (f_1603_14197_14235(f_1603_14197_14229(remoteRunspace))== RunspaceState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,14193,15908);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14299,14781) || true) && (f_1603_14303_14329_M(!remoteRunspace.CanConnect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,14299,14781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14371,14463);

string 
message = f_1603_14388_14462(f_1603_14406_14461())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14485,14731);

f_1603_14485_14730(this, f_1603_14522_14729(f_1603_14568_14597(message), "EnterPSSessionCannotConnectDisconnectedSession", ErrorCategory.InvalidOperation, remoteRunspace));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14755,14762);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,14299,14781);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14843,14863);

Exception 
ex = null
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14925,14950);

f_1603_14925_14949(                    remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,14972,14997);

runspaceConnected = true;
                }
                catch (System.Management.Automation.Remoting.PSRemotingTransportException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,15034,15177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15151,15158);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,15034,15177);
                }
                catch (PSInvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,15195,15299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15273,15280);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,15195,15299);
                }
                catch (InvalidRunspacePoolStateException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,15317,15427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15401,15408);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,15317,15427);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15447,15893) || true) && (ex != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,15447,15893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15503,15583);

string 
message = f_1603_15520_15582(f_1603_15538_15581())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15605,15843);

f_1603_15605_15842(this, f_1603_15642_15841(f_1603_15688_15721(message, ex), "EnterPSSessionConnectSessionFailed", ErrorCategory.InvalidOperation, remoteRunspace));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15867,15874);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,15447,15893);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,14193,15908);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,15974,17207) || true) && (f_1603_15978_16016(f_1603_15978_16010(remoteRunspace))!= RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,15974,17207);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,16074,17165) || true) && (f_1603_16078_16094()== SessionParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,16074,17165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,16159,16228);

string 
sessionName = (DynAbs.Tracing.TraceSender.Conditional_F1(1603, 16180, 16197)||(((f_1603_16181_16188()!= null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1603, 16200, 16212))||DynAbs.Tracing.TraceSender.Conditional_F3(1603, 16215, 16227)))?f_1603_16200_16212(f_1603_16200_16207()):string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,16250,16717);

f_1603_16250_16716(this, f_1603_16287_16715(f_1603_16333_16535(f_1603_16355_16534(this, f_1603_16366_16416(), sessionName, f_1603_16464_16506(f_1603_16464_16493(remoteRunspace)), f_1603_16508_16533(remoteRunspace))), f_1603_16566_16619(                            PSRemotingErrorId.PushedRunspaceMustBeOpen), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,16074,17165);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,16074,17165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,16799,17146);

f_1603_16799_17145(this, f_1603_16836_17144(f_1603_16882_16964(f_1603_16904_16963(this, f_1603_16915_16962())), f_1603_16995_17048(                            PSRemotingErrorId.PushedRunspaceMustBeOpen), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,16074,17165);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17185,17192);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,15974,17207);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17223,17248);

Debugger 
debugger = null
;
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17298,17418) || true) && (f_1603_17302_17315(host)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,17298,17418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17365,17399);

debugger = f_1603_17376_17398(f_1603_17376_17389(host));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,17298,17418);
}
            }
            catch (PSNotImplementedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,17447,17484);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,17447,17484);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17500,17629);

bool 
supportRunningCommand = ((debugger != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 17530, 17627)&&((f_1603_17554_17572(debugger)& DebugModes.RemoteScript) == DebugModes.RemoteScript)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17643,20663) || true) && (f_1603_17647_17682(remoteRunspace)!= RunspaceAvailability.Available)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,17643,20663);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17799,20648) || true) && (!supportRunningCommand)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,17799,20648);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,17965,19354) || true) && (runspaceConnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,17965,19354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,18371,18544);

string 
message = f_1603_18388_18543(f_1603_18406_18455(), f_1603_18514_18542(remoteRunspace))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,18570,18815);

f_1603_18570_18814(this, f_1603_18611_18813(f_1603_18661_18690(message), "EnterPSSessionConnectSessionNotAvailable", ErrorCategory.InvalidOperation, f_1603_18805_18812()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,18917,18950);

f_1603_18917_18949(
                        // Leave session in original disconnected state.
                        remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,18978,18985);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,17965,19354);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,17965,19354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,19272,19331);

f_1603_19272_19330(this, f_1603_19285_19329(this, f_1603_19296_19328()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,17965,19354);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,17799,20648);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,17799,20648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,19646,19702);

Job 
job = f_1603_19656_19701(this, f_1603_19675_19700(remoteRunspace))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,19724,19735);

string 
msg
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,19757,20587) || true) && (job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,19757,20587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,19822,20001);

msg = f_1603_19828_20000(f_1603_19876_19909(), (DynAbs.Tracing.TraceSender.Conditional_F1(1603, 19940, 19973)||((                            (!f_1603_19942_19972(f_1603_19963_19971(job))) &&DynAbs.Tracing.TraceSender.Conditional_F2(1603, 19976, 19984))||DynAbs.Tracing.TraceSender.Conditional_F3(1603, 19987, 19999)))?f_1603_19976_19984(job):string.Empty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,19757,20587);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,19757,20587);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,20099,20564) || true) && (f_1603_20103_20138(remoteRunspace)== RunspaceAvailability.RemoteDebug)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,20099,20564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,20232,20327);

msg = f_1603_20238_20326(f_1603_20290_20325());
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,20099,20564);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,20099,20564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,20441,20537);

msg = f_1603_20447_20536(f_1603_20499_20535());
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,20099,20564);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,19757,20587);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,20611,20629);

f_1603_20611_20628(this, msg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,17799,20648);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,17643,20663);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,20779,20893) || true) && (f_1603_20783_20790()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,20779,20893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,20832,20878);

f_1603_20832_20877(f_1603_20832_20855(this), f_1603_20869_20876());
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,20779,20893);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,20953,20987);

f_1603_20953_20986(this, remoteRunspace);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,21039,21073);

f_1603_21039_21072(                host, remoteRunspace);
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,21102,21539);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,21292,21441) || true) && ((remoteRunspace != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 21296, 21357)&&(f_1603_21325_21356(remoteRunspace))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,21292,21441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,21399,21422);

f_1603_21399_21421(                    remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,21292,21441);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,21518,21524);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,21102,21539);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,9316,21550);

System.Management.Automation.Host.PSHost
f_1603_9479_9488(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 9479, 9488);
return return_v;
}


string
f_1603_9696_9749()
{
var return_v = RemotingErrorIdStrings.HostDoesNotSupportPushRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 9696, 9749);
return return_v;
}


string
f_1603_9685_9750(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 9685, 9750);
return return_v;
}


System.ArgumentException
f_1603_9663_9751(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 9663, 9751);
return return_v;
}


string
f_1603_9778_9837(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 9778, 9837);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_9621_9925(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 9621, 9925);
return return_v;
}


int
f_1603_9588_9926(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 9588, 9926);
return 0;
}


bool
f_1603_10118_10139(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForVM();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10118, 10139);
return return_v;
}


bool
f_1603_10161_10189(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForContainer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10161, 10189);
return return_v;
}


bool
f_1603_10211_10248(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForVMContainerSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10211, 10248);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1603_10269_10281(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Context ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10269, 10281);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1603_10310_10322(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10310, 10322);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_1603_10310_10342(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10310, 10342);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1603_10371_10383(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10371, 10383);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_1603_10371_10403(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10371, 10403);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1603_10371_10416(System.Management.Automation.Internal.Host.InternalHost
this_param)
{
var return_v = this_param.ExternalHost ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10371, 10416);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1603_10445_10457(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10445, 10457);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_1603_10445_10477(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10445, 10477);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1603_10445_10490(System.Management.Automation.Internal.Host.InternalHost
this_param)
{
var return_v = this_param.ExternalHost ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10445, 10490);
return return_v;
}


string
f_1603_10690_10749()
{
var return_v = RemotingErrorIdStrings.RemoteHostDoesNotSupportPushRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 10690, 10749);
return return_v;
}


string
f_1603_10679_10750(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10679, 10750);
return return_v;
}


System.ArgumentException
f_1603_10657_10751(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10657, 10751);
return return_v;
}


string
f_1603_10778_10843(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10778, 10843);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_10615_10931(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10615, 10931);
return return_v;
}


int
f_1603_10582_10932(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 10582, 10932);
return 0;
}


System.Management.Automation.Host.PSHost
f_1603_11249_11258(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 11249, 11258);
return return_v;
}


bool
f_1603_11339_11360(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForVM();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11339, 11360);
return return_v;
}


bool
f_1603_11382_11410(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForContainer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11382, 11410);
return return_v;
}


bool
f_1603_11432_11469(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForVMContainerSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11432, 11469);
return return_v;
}


bool
f_1603_11507_11533(System.Management.Automation.Internal.Host.InternalHost
this_param)
{
var return_v = this_param.HostInNestedPrompt();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11507, 11533);
return return_v;
}


string
f_1603_11704_11745()
{
var return_v = RemotingErrorIdStrings.HostInNestedPrompt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 11704, 11745);
return return_v;
}


string
f_1603_11657_11746(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11657, 11746);
return return_v;
}


System.InvalidOperationException
f_1603_11627_11747(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11627, 11747);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_11589_11830(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Internal.Host.InternalHost
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11589, 11830);
return return_v;
}


int
f_1603_11567_11831(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 11567, 11831);
return 0;
}


string
f_1603_12478_12494()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 12478, 12494);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_12597_12647(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspaceWhenComputerNameParameterSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 12597, 12647);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_12756_12797(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspaceWhenUriParameterSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 12756, 12797);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_12926_12933()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 12926, 12933);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_12926_12942(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 12926, 12942);
return return_v;
}


System.Guid
f_1603_13088_13103(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 13088, 13103);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_13058_13104(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Guid
remoteRunspaceId)
{
var return_v = this_param.GetRunspaceMatchingRunspaceId( remoteRunspaceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 13058, 13104);
return return_v;
}


int
f_1603_13241_13248(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 13241, 13248);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_13212_13249(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,int
sessionId)
{
var return_v = this_param.GetRunspaceMatchingSessionId( sessionId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 13212, 13249);
return return_v;
}


string
f_1603_13383_13392(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 13383, 13392);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_13359_13393(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
name)
{
var return_v = this_param.GetRunspaceMatchingName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 13359, 13393);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_13545_13570(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.GetRunspaceForVMSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 13545, 13570);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_13687_13719(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.GetRunspaceForContainerSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 13687, 13719);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_13832_13858(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.GetRunspaceForSSHSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 13832, 13858);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1603_14197_14229(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 14197, 14229);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1603_14197_14235(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 14197, 14235);
return return_v;
}


bool
f_1603_14303_14329_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 14303, 14329);
return return_v;
}


string
f_1603_14406_14461()
{
var return_v = RemotingErrorIdStrings.SessionNotAvailableForConnection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 14406, 14461);
return return_v;
}


string
f_1603_14388_14462(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 14388, 14462);
return return_v;
}


System.Management.Automation.RuntimeException
f_1603_14568_14597(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 14568, 14597);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_14522_14729(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.RemoteRunspace
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 14522, 14729);
return return_v;
}


int
f_1603_14485_14730(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 14485, 14730);
return 0;
}


int
f_1603_14925_14949(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Connect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 14925, 14949);
return 0;
}


string
f_1603_15538_15581()
{
var return_v = RemotingErrorIdStrings.SessionConnectFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 15538, 15581);
return return_v;
}


string
f_1603_15520_15582(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 15520, 15582);
return return_v;
}


System.Management.Automation.RuntimeException
f_1603_15688_15721(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 15688, 15721);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_15642_15841(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.RemoteRunspace
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 15642, 15841);
return return_v;
}


int
f_1603_15605_15842(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 15605, 15842);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1603_15978_16010(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 15978, 16010);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1603_15978_16016(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 15978, 16016);
return return_v;
}


string
f_1603_16078_16094()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16078, 16094);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_16181_16188()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16181, 16188);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_16200_16207()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16200, 16207);
return return_v;
}


string
f_1603_16200_16212(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16200, 16212);
return return_v;
}


string
f_1603_16366_16416()
{
var return_v = RemotingErrorIdStrings.EnterPSSessionBrokenSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16366, 16416);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1603_16464_16493(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16464, 16493);
return return_v;
}


string
f_1603_16464_16506(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16464, 16506);
return return_v;
}


System.Guid
f_1603_16508_16533(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16508, 16533);
return return_v;
}


string
f_1603_16355_16534(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16355, 16534);
return return_v;
}


System.ArgumentException
f_1603_16333_16535(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16333, 16535);
return return_v;
}


string
f_1603_16566_16619(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16566, 16619);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_16287_16715(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16287, 16715);
return return_v;
}


int
f_1603_16250_16716(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16250, 16716);
return 0;
}


string
f_1603_16915_16962()
{
var return_v = RemotingErrorIdStrings.PushedRunspaceMustBeOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 16915, 16962);
return return_v;
}


string
f_1603_16904_16963(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16904, 16963);
return return_v;
}


System.ArgumentException
f_1603_16882_16964(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16882, 16964);
return return_v;
}


string
f_1603_16995_17048(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16995, 17048);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_16836_17144(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16836, 17144);
return return_v;
}


int
f_1603_16799_17145(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 16799, 17145);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1603_17302_17315(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 17302, 17315);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_17376_17389(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 17376, 17389);
return return_v;
}


System.Management.Automation.Debugger
f_1603_17376_17398(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 17376, 17398);
return return_v;
}


System.Management.Automation.DebugModes
f_1603_17554_17572(System.Management.Automation.Debugger
this_param)
{
var return_v = this_param.DebugMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 17554, 17572);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1603_17647_17682(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 17647, 17682);
return return_v;
}


string
f_1603_18406_18455()
{
var return_v = RemotingErrorIdStrings.EnterPSSessionDisconnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 18406, 18455);
return return_v;
}


string
f_1603_18514_18542(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.PSSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 18514, 18542);
return return_v;
}


string
f_1603_18388_18543(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 18388, 18543);
return return_v;
}


System.Management.Automation.RuntimeException
f_1603_18661_18690(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 18661, 18690);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_18805_18812()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 18805, 18812);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_18611_18813(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 18611, 18813);
return return_v;
}


int
f_1603_18570_18814(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 18570, 18814);
return 0;
}


int
f_1603_18917_18949(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.DisconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 18917, 18949);
return 0;
}


string
f_1603_19296_19328()
{
var return_v = RunspaceStrings.RunspaceNotReady;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 19296, 19328);
return return_v;
}


string
f_1603_19285_19329(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 19285, 19329);
return return_v;
}


int
f_1603_19272_19330(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 19272, 19330);
return 0;
}


System.Guid
f_1603_19675_19700(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 19675, 19700);
return return_v;
}


System.Management.Automation.Job
f_1603_19656_19701(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Guid
id)
{
var return_v = this_param.FindJobForRunspace( id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 19656, 19701);
return return_v;
}


string
f_1603_19876_19909()
{
var return_v =                             RunspaceStrings.RunningCmdWithJob;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 19876, 19909);
return return_v;
}


string
f_1603_19963_19971(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 19963, 19971);
return return_v;
}


bool
f_1603_19942_19972(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 19942, 19972);
return return_v;
}


string
f_1603_19976_19984(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 19976, 19984);
return return_v;
}


string
f_1603_19828_20000(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 19828, 20000);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1603_20103_20138(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 20103, 20138);
return return_v;
}


string
f_1603_20290_20325()
{
var return_v =                                 RunspaceStrings.RunningCmdDebugStop;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 20290, 20325);
return return_v;
}


string
f_1603_20238_20326(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 20238, 20326);
return return_v;
}


string
f_1603_20499_20535()
{
var return_v =                                 RunspaceStrings.RunningCmdWithoutJob;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 20499, 20535);
return return_v;
}


string
f_1603_20447_20536(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 20447, 20536);
return return_v;
}


int
f_1603_20611_20628(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 20611, 20628);
return 0;
}


System.Management.Automation.Runspaces.PSSession
f_1603_20783_20790()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 20783, 20790);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1603_20832_20855(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 20832, 20855);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_20869_20876()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 20869, 20876);
return return_v;
}


int
f_1603_20832_20877(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 20832, 20877);
return 0;
}


int
f_1603_20953_20986(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
this_param.SetRunspacePrompt( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 20953, 20986);
return 0;
}


int
f_1603_21039_21072(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param,System.Management.Automation.RemoteRunspace
runspace)
{
this_param.PushRunspace( (System.Management.Automation.Runspaces.Runspace)runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 21039, 21072);
return 0;
}


bool
f_1603_21325_21356(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ShouldCloseOnPop;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 21325, 21356);
return return_v;
}


int
f_1603_21399_21421(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 21399, 21421);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,9316,21550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,9316,21550);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,21715,22416);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,21779,22405) || true) && (_stream != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,21779,22405);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,21832,22390) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,21832,22390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,21965,22007);

f_1603_21965_22006(f_1603_21965_21996(f_1603_21965_21985(_stream)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22031,22371) || true) && (f_1603_22035_22070_M(!f_1603_22036_22056(_stream).EndOfPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,22031,22371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22120,22170);

object 
streamObject = f_1603_22142_22169(f_1603_22142_22162(_stream))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22196,22244);

f_1603_22196_22243(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,22031,22371);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,22031,22371);
DynAbs.Tracing.TraceSender.TraceBreak(1603,22342,22348);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,22031,22371);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,21832,22390);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1603,21832,22390);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1603,21832,22390);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1603,21779,22405);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,21715,22416);

System.Management.Automation.Runspaces.PipelineReader<object>
f_1603_21965_21985(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 21965, 21985);
return return_v;
}


System.Threading.WaitHandle
f_1603_21965_21996(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.WaitHandle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 21965, 21996);
return return_v;
}


bool
f_1603_21965_22006(System.Threading.WaitHandle
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 21965, 22006);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1603_22036_22056(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 22036, 22056);
return return_v;
}


bool
f_1603_22035_22070_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 22035, 22070);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1603_22142_22162(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 22142, 22162);
return return_v;
}


object
f_1603_22142_22169(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 22142, 22169);
return return_v;
}


int
f_1603_22196_22243(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 22196, 22243);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,21715,22416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,21715,22416);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,22475,23430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22540,22575);

var 
remoteRunspace = _tempRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22589,22841) || true) && (remoteRunspace != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,22589,22841);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22693,22721);

f_1603_22693_22720(                    remoteRunspace);
                }
                catch (InvalidRunspaceStateException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,22758,22799);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,22758,22799);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22819,22826);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,22589,22841);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22857,22941);

IHostSupportsInteractiveSession 
host = f_1603_22896_22905(this)as IHostSupportsInteractiveSession
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,22955,23384) || true) && (host == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,22955,23384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,23005,23344);

f_1603_23005_23343(this, f_1603_23038_23342(f_1603_23080_23168(f_1603_23102_23167(this, f_1603_23113_23166())), f_1603_23195_23254(                        PSRemotingErrorId.HostDoesNotSupportPushRunspace), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,23362,23369);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,22955,23384);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,23400,23419);

f_1603_23400_23418(
            host);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,22475,23430);

int
f_1603_22693_22720(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 22693, 22720);
return 0;
}


System.Management.Automation.Host.PSHost
f_1603_22896_22905(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 22896, 22905);
return return_v;
}


string
f_1603_23113_23166()
{
var return_v = RemotingErrorIdStrings.HostDoesNotSupportPushRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 23113, 23166);
return return_v;
}


string
f_1603_23102_23167(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23102, 23167);
return return_v;
}


System.ArgumentException
f_1603_23080_23168(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23080, 23168);
return return_v;
}


string
f_1603_23195_23254(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23195, 23254);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_23038_23342(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23038, 23342);
return return_v;
}


int
f_1603_23005_23343(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23005, 23343);
return 0;
}


int
f_1603_23400_23418(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
this_param.PopRunspace();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23400, 23418);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,22475,23430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,22475,23430);
}
		}

private RemoteRunspace CreateTemporaryRemoteRunspace(PSHost host, WSManConnectionInfo connectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,23593,25367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,23765,23774);

int 
rsId
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,23788,23845);

string 
rsName = f_1603_23804_23844(out rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,23859,24135);

RemoteRunspace 
remoteRunspace = f_1603_23891_24134(f_1603_23928_23971(), connectionInfo, host, f_1603_24046_24085(f_1603_24046_24064(this)), rsName, rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,24149,24219);

f_1603_24149_24218(remoteRunspace != null, "Expected remoteRunspace != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,24233,24301);

remoteRunspace.URIRedirectionReported += HandleURIDirectionReported;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,24317,24346);

_stream = f_1603_24327_24345();
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,24396,24418);

f_1603_24396_24417(                remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,24513,24552);

remoteRunspace.ShouldCloseOnPop = true;
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1603,24581,25318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,24676,24744);

remoteRunspace.URIRedirectionReported -= HandleURIDirectionReported;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,24969,24998);

f_1603_24969_24997(f_1603_24969_24989(_stream));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,25107,25303) || true) && (f_1603_25111_25149(f_1603_25111_25143(remoteRunspace))!= RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,25107,25303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,25215,25240);

f_1603_25215_25239(                    remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,25262,25284);

remoteRunspace = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,25107,25303);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1603,24581,25318);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,25334,25356);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,23593,25367);

string
f_1603_23804_23844(out int
rtnId)
{
var return_v = PSSession.GenerateRunspaceName( out rtnId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23804, 23844);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1603_23928_23971()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23928, 23971);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1603_24046_24064(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 24046, 24064);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1603_24046_24085(System.Management.Automation.Remoting.PSSessionOption
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 24046, 24085);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_23891_24134(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 23891, 24134);
return return_v;
}


int
f_1603_24149_24218(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 24149, 24218);
return 0;
}


System.Management.Automation.Internal.ObjectStream
f_1603_24327_24345()
{
var return_v = new System.Management.Automation.Internal.ObjectStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 24327, 24345);
return return_v;
}


int
f_1603_24396_24417(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 24396, 24417);
return 0;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1603_24969_24989(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 24969, 24989);
return return_v;
}


int
f_1603_24969_24997(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 24969, 24997);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1603_25111_25143(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 25111, 25143);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1603_25111_25149(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 25111, 25149);
return return_v;
}


int
f_1603_25215_25239(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 25215, 25239);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,23593,25367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,23593,25367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteErrorCreateRemoteRunspaceFailed(Exception exception, object argument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,25482,27111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,25797,25910);

PSRemotingTransportException 
transException =
                        exception as PSRemotingTransportException
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,25924,25951);

string 
errorDetails = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,25965,26819) || true) && ((transException != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 25969, 26155)&&                (f_1603_26015_26039(transException)==
                    System.Management.Automation.Remoting.Client.WSManNativeApi.ERROR_WSMAN_REDIRECT_REQUESTED)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,25965,26819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,26388,26761);

string 
message = f_1603_26405_26760(f_1603_26474_26519(), f_1603_26542_26564(transException), "MaximumConnectionRedirectionCount", Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet.DEFAULT_SESSION_OPTION, "AllowRedirection")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,26781,26804);

errorDetails = message;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,25965,26819);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,26835,27060);

ErrorRecord 
errorRecord = f_1603_26861_27059(exception, argument, "CreateRemoteRunspaceFailed", ErrorCategory.InvalidArgument, null, null, null, null, null, errorDetails, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,27076,27100);

f_1603_27076_27099(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,25482,27111);

int
f_1603_26015_26039(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 26015, 26039);
return return_v;
}


string
f_1603_26474_26519()
{
var return_v =                     RemotingErrorIdStrings.URIRedirectionReported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 26474, 26519);
return return_v;
}


string
f_1603_26542_26564(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 26542, 26564);
return return_v;
}


string
f_1603_26405_26760(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 26405, 26760);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_26861_27059(System.Exception
exception,object
targetObject,string
fullyQualifiedErrorId,System.Management.Automation.ErrorCategory
errorCategory,string
errorCategory_Activity,string
errorCategory_Reason,string
errorCategory_TargetName,string
errorCategory_TargetType,string
errorCategory_Message,string
errorDetails_Message,string
errorDetails_RecommendedAction)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, targetObject, fullyQualifiedErrorId, errorCategory, errorCategory_Activity, errorCategory_Reason, errorCategory_TargetName, errorCategory_TargetType, errorCategory_Message, errorDetails_Message, errorDetails_RecommendedAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 26861, 27059);
return return_v;
}


int
f_1603_27076_27099(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 27076, 27099);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,25482,27111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,25482,27111);
}
		}

private void WriteInvalidArgumentError(PSRemotingErrorId errorId, string resourceString, object errorArgument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,27213,27575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,27348,27407);

string 
message = f_1603_27365_27406(this, resourceString, errorArgument)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,27421,27564);

f_1603_27421_27563(this, f_1603_27432_27562(f_1603_27448_27478(message), f_1603_27480_27498(errorId), ErrorCategory.InvalidArgument, errorArgument));
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,27213,27575);

string
f_1603_27365_27406(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 27365, 27406);
return return_v;
}


System.ArgumentException
f_1603_27448_27478(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 27448, 27478);
return return_v;
}


string
f_1603_27480_27498(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 27480, 27498);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_27432_27562(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 27432, 27562);
return return_v;
}


int
f_1603_27421_27563(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 27421, 27563);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,27213,27575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,27213,27575);
}
		}

private void HandleURIDirectionReported(object sender, RemoteDataEventArgs<Uri> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,27893,28322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28008,28123);

string 
message = f_1603_28025_28122(f_1603_28043_28090(), f_1603_28092_28121(f_1603_28092_28106(eventArgs)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28137,28269);

Action<Cmdlet> 
streamObject = delegate (Cmdlet cmdlet)
            {
                cmdlet.WriteWarning(message);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28283,28311);

f_1603_28283_28310(            _stream, streamObject);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,27893,28322);

string
f_1603_28043_28090()
{
var return_v = RemotingErrorIdStrings.URIRedirectWarningToHost;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 28043, 28090);
return return_v;
}


System.Uri
f_1603_28092_28106(System.Management.Automation.RemoteDataEventArgs<System.Uri>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 28092, 28106);
return return_v;
}


string
f_1603_28092_28121(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 28092, 28121);
return return_v;
}


string
f_1603_28025_28122(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 28025, 28122);
return return_v;
}


int
f_1603_28283_28310(System.Management.Automation.Internal.ObjectStream
this_param,System.Action<System.Management.Automation.Cmdlet>
value)
{
var return_v = this_param.Write( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 28283, 28310);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,27893,28322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,27893,28322);
}
		}

private RemoteRunspace CreateRunspaceWhenComputerNameParameterSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,28450,30350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28548,28585);

RemoteRunspace 
remoteRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28599,28663);

string 
resolvedComputerName = f_1603_28629_28662(this, f_1603_28649_28661())
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28713,28755);

WSManConnectionInfo 
connectionInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28773,28816);

connectionInfo = f_1603_28790_28815();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28834,28934);

string 
scheme = (DynAbs.Tracing.TraceSender.Conditional_F1(1603, 28850, 28866)||((f_1603_28850_28856().IsPresent &&DynAbs.Tracing.TraceSender.Conditional_F2(1603, 28869, 28900))||DynAbs.Tracing.TraceSender.Conditional_F3(1603, 28903, 28933)))?WSManConnectionInfo.HttpsScheme :WSManConnectionInfo.HttpScheme
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,28952,29003);

connectionInfo.ComputerName = resolvedComputerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29021,29048);

connectionInfo.Port = f_1603_29043_29047();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29066,29107);

connectionInfo.AppName = f_1603_29091_29106();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29125,29169);

connectionInfo.ShellUri = f_1603_29151_29168();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29187,29218);

connectionInfo.Scheme = scheme;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29236,29512) || true) && (f_1603_29240_29261()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,29236,29512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29311,29372);

connectionInfo.CertificateThumbprint = f_1603_29350_29371();
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,29236,29512);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,29236,29512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29454,29493);

connectionInfo.Credential = f_1603_29482_29492();
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,29236,29512);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29532,29588);

connectionInfo.AuthenticationMechanism = f_1603_29573_29587();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29606,29643);

f_1603_29606_29642(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29663,29720);

connectionInfo.EnableNetworkAccess = f_1603_29700_29719();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29740,29814);

remoteRunspace = f_1603_29757_29813(this, f_1603_29787_29796(this), connectionInfo);
            }
            catch (InvalidOperationException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,29843,29988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,29911,29973);

f_1603_29911_29972(this, e, resolvedComputerName);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,29843,29988);
            }
            catch (ArgumentException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,30002,30139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30062,30124);

f_1603_30062_30123(this, e, resolvedComputerName);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,30002,30139);
            }
            catch (PSRemotingTransportException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,30153,30301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30224,30286);

f_1603_30224_30285(this, e, resolvedComputerName);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,30153,30301);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30317,30339);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,28450,30350);

string
f_1603_28649_28661()
{
var return_v = ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 28649, 28661);
return return_v;
}


string
f_1603_28629_28662(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 28629, 28662);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1603_28790_28815()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 28790, 28815);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1603_28850_28856()
{
var return_v = UseSSL;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 28850, 28856);
return return_v;
}


int
f_1603_29043_29047()
{
var return_v = Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29043, 29047);
return return_v;
}


string
f_1603_29091_29106()
{
var return_v = ApplicationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29091, 29106);
return return_v;
}


string
f_1603_29151_29168()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29151, 29168);
return return_v;
}


string
f_1603_29240_29261()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29240, 29261);
return return_v;
}


string
f_1603_29350_29371()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29350, 29371);
return return_v;
}


System.Management.Automation.PSCredential
f_1603_29482_29492()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29482, 29492);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1603_29573_29587()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29573, 29587);
return return_v;
}


int
f_1603_29606_29642(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 29606, 29642);
return 0;
}


System.Management.Automation.SwitchParameter
f_1603_29700_29719()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29700, 29719);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1603_29787_29796(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 29787, 29796);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_29757_29813(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
var return_v = this_param.CreateTemporaryRemoteRunspace( host, connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 29757, 29813);
return return_v;
}


int
f_1603_29911_29972(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.InvalidOperationException
exception,string
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 29911, 29972);
return 0;
}


int
f_1603_30062_30123(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.ArgumentException
exception,string
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 30062, 30123);
return 0;
}


int
f_1603_30224_30285(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Remoting.PSRemotingTransportException
exception,string
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 30224, 30285);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,28450,30350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,28450,30350);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace CreateRunspaceWhenUriParameterSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,30468,32232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30557,30594);

RemoteRunspace 
remoteRunspace = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30644,30707);

WSManConnectionInfo 
connectionInfo = f_1603_30681_30706()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30725,30770);

connectionInfo.ConnectionUri = f_1603_30756_30769();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30788,30832);

connectionInfo.ShellUri = f_1603_30814_30831();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30850,31126) || true) && (f_1603_30854_30875()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,30850,31126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,30925,30986);

connectionInfo.CertificateThumbprint = f_1603_30964_30985();
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,30850,31126);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,30850,31126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31068,31107);

connectionInfo.Credential = f_1603_31096_31106();
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,30850,31126);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31146,31202);

connectionInfo.AuthenticationMechanism = f_1603_31187_31201();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31220,31257);

f_1603_31220_31256(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31275,31332);

connectionInfo.EnableNetworkAccess = f_1603_31312_31331();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31350,31424);

remoteRunspace = f_1603_31367_31423(this, f_1603_31397_31406(this), connectionInfo);
            }
            catch (UriFormatException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,31453,31584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31514,31569);

f_1603_31514_31568(this, e, f_1603_31554_31567());
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,31453,31584);
            }
            catch (InvalidOperationException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,31598,31736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31666,31721);

f_1603_31666_31720(this, e, f_1603_31706_31719());
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,31598,31736);
            }
            catch (ArgumentException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,31750,31880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31810,31865);

f_1603_31810_31864(this, e, f_1603_31850_31863());
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,31750,31880);
            }
            catch (PSRemotingTransportException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,31894,32035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,31965,32020);

f_1603_31965_32019(this, e, f_1603_32005_32018());
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,31894,32035);
            }
            catch (NotSupportedException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,32049,32183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,32113,32168);

f_1603_32113_32167(this, e, f_1603_32153_32166());
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,32049,32183);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,32199,32221);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,30468,32232);

System.Management.Automation.Runspaces.WSManConnectionInfo
f_1603_30681_30706()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 30681, 30706);
return return_v;
}


System.Uri
f_1603_30756_30769()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 30756, 30769);
return return_v;
}


string
f_1603_30814_30831()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 30814, 30831);
return return_v;
}


string
f_1603_30854_30875()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 30854, 30875);
return return_v;
}


string
f_1603_30964_30985()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 30964, 30985);
return return_v;
}


System.Management.Automation.PSCredential
f_1603_31096_31106()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 31096, 31106);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1603_31187_31201()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 31187, 31201);
return return_v;
}


int
f_1603_31220_31256(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 31220, 31256);
return 0;
}


System.Management.Automation.SwitchParameter
f_1603_31312_31331()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 31312, 31331);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1603_31397_31406(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 31397, 31406);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_31367_31423(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
var return_v = this_param.CreateTemporaryRemoteRunspace( host, connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 31367, 31423);
return return_v;
}


System.Uri
f_1603_31554_31567()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 31554, 31567);
return return_v;
}


int
f_1603_31514_31568(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.UriFormatException
exception,System.Uri
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 31514, 31568);
return 0;
}


System.Uri
f_1603_31706_31719()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 31706, 31719);
return return_v;
}


int
f_1603_31666_31720(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.InvalidOperationException
exception,System.Uri
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 31666, 31720);
return 0;
}


System.Uri
f_1603_31850_31863()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 31850, 31863);
return return_v;
}


int
f_1603_31810_31864(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.ArgumentException
exception,System.Uri
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 31810, 31864);
return 0;
}


System.Uri
f_1603_32005_32018()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 32005, 32018);
return return_v;
}


int
f_1603_31965_32019(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Remoting.PSRemotingTransportException
exception,System.Uri
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 31965, 32019);
return 0;
}


System.Uri
f_1603_32153_32166()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 32153, 32166);
return return_v;
}


int
f_1603_32113_32167(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.NotSupportedException
exception,System.Uri
argument)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)exception, (object)argument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 32113, 32167);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,30468,32232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,30468,32232);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace GetRunspaceMatchingCondition(
            Predicate<PSSession> condition,
            PSRemotingErrorId tooFew,
            PSRemotingErrorId tooMany,
            string tooFewResourceString,
            string tooManyResourceString,
            object errorArgument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,32337,33420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,32688,32767);

List<PSSession> 
matches = f_1603_32714_32766(f_1603_32714_32747(f_1603_32714_32737(this)), condition)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,32809,32846);

RemoteRunspace 
remoteRunspace = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,32860,33371) || true) && (f_1603_32864_32877(matches)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,32860,33371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,32916,32987);

f_1603_32916_32986(this, tooFew, tooFewResourceString, errorArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,32860,33371);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,32860,33371);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33021,33371) || true) && (f_1603_33025_33038(matches)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,33021,33371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33076,33149);

f_1603_33076_33148(this, tooMany, tooManyResourceString, errorArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,33021,33371);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,33021,33371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33215,33268);

remoteRunspace = (RemoteRunspace)f_1603_33248_33267(f_1603_33248_33258(matches, 0));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33286,33356);

f_1603_33286_33355(remoteRunspace != null, "Expected remoteRunspace != null");
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,33021,33371);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,32860,33371);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33387,33409);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,32337,33420);

System.Management.Automation.RunspaceRepository
f_1603_32714_32737(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 32714, 32737);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1603_32714_32747(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 32714, 32747);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1603_32714_32766(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param,System.Predicate<System.Management.Automation.Runspaces.PSSession>
match)
{
var return_v = this_param.FindAll( match);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 32714, 32766);
return return_v;
}


int
f_1603_32864_32877(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 32864, 32877);
return return_v;
}


int
f_1603_32916_32986(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,object
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 32916, 32986);
return 0;
}


int
f_1603_33025_33038(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 33025, 33038);
return return_v;
}


int
f_1603_33076_33148(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,object
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 33076, 33148);
return 0;
}


System.Management.Automation.Runspaces.PSSession
f_1603_33248_33258(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 33248, 33258);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_33248_33267(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 33248, 33267);
return return_v;
}


int
f_1603_33286_33355(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 33286, 33355);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,32337,33420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,32337,33420);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace GetRunspaceMatchingRunspaceId(Guid remoteRunspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,33527,34391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33627,33777);

Predicate<PSSession> 
condition = delegate (PSSession info)
            {
                return info.InstanceId == remoteRunspaceId;
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33791,33885);

PSRemotingErrorId 
tooFew = PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedRunspaceId
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,33899,34000);

PSRemotingErrorId 
tooMany = PSRemotingErrorId.RemoteRunspaceHasMultipleMatchesForSpecifiedRunspaceId
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,34014,34116);

string 
tooFewResourceString = f_1603_34044_34115()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,34130,34239);

string 
tooManyResourceString = f_1603_34161_34238()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,34253,34380);

return f_1603_34260_34379(this, condition, tooFew, tooMany, tooFewResourceString, tooManyResourceString, remoteRunspaceId);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,33527,34391);

string
f_1603_34044_34115()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedRunspaceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 34044, 34115);
return return_v;
}


string
f_1603_34161_34238()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceHasMultipleMatchesForSpecifiedRunspaceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 34161, 34238);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_34260_34379(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Predicate<System.Management.Automation.Runspaces.PSSession>
condition,System.Management.Automation.Remoting.PSRemotingErrorId
tooFew,System.Management.Automation.Remoting.PSRemotingErrorId
tooMany,string
tooFewResourceString,string
tooManyResourceString,System.Guid
errorArgument)
{
var return_v = this_param.GetRunspaceMatchingCondition( condition, tooFew, tooMany, tooFewResourceString, tooManyResourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 34260, 34379);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,33527,34391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,33527,34391);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace GetRunspaceMatchingSessionId(int sessionId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,34497,35326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,34588,34723);

Predicate<PSSession> 
condition = delegate (PSSession info)
            {
                return info.Id == sessionId;
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,34737,34830);

PSRemotingErrorId 
tooFew = PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedSessionId
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,34844,34944);

PSRemotingErrorId 
tooMany = PSRemotingErrorId.RemoteRunspaceHasMultipleMatchesForSpecifiedSessionId
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,34958,35059);

string 
tooFewResourceString = f_1603_34988_35058()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,35073,35181);

string 
tooManyResourceString = f_1603_35104_35180()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,35195,35315);

return f_1603_35202_35314(this, condition, tooFew, tooMany, tooFewResourceString, tooManyResourceString, sessionId);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,34497,35326);

string
f_1603_34988_35058()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedSessionId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 34988, 35058);
return return_v;
}


string
f_1603_35104_35180()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceHasMultipleMatchesForSpecifiedSessionId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 35104, 35180);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_35202_35314(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Predicate<System.Management.Automation.Runspaces.PSSession>
condition,System.Management.Automation.Remoting.PSRemotingErrorId
tooFew,System.Management.Automation.Remoting.PSRemotingErrorId
tooMany,string
tooFewResourceString,string
tooManyResourceString,int
errorArgument)
{
var return_v = this_param.GetRunspaceMatchingCondition( condition, tooFew, tooMany, tooFewResourceString, tooManyResourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 35202, 35314);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,34497,35326);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,34497,35326);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace GetRunspaceMatchingName(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,35426,36327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,35510,35749);

Predicate<PSSession> 
condition = delegate (PSSession info)
            {
                // doing case-insensitive match for session name
                return info.Name.Equals(name, StringComparison.OrdinalIgnoreCase);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,35763,35851);

PSRemotingErrorId 
tooFew = PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedName
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,35865,35960);

PSRemotingErrorId 
tooMany = PSRemotingErrorId.RemoteRunspaceHasMultipleMatchesForSpecifiedName
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,35974,36070);

string 
tooFewResourceString = f_1603_36004_36069()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,36084,36187);

string 
tooManyResourceString = f_1603_36115_36186()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,36201,36316);

return f_1603_36208_36315(this, condition, tooFew, tooMany, tooFewResourceString, tooManyResourceString, name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,35426,36327);

string
f_1603_36004_36069()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36004, 36069);
return return_v;
}


string
f_1603_36115_36186()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceHasMultipleMatchesForSpecifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36115, 36186);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_36208_36315(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Predicate<System.Management.Automation.Runspaces.PSSession>
condition,System.Management.Automation.Remoting.PSRemotingErrorId
tooFew,System.Management.Automation.Remoting.PSRemotingErrorId
tooMany,string
tooFewResourceString,string
tooManyResourceString,string
errorArgument)
{
var return_v = this_param.GetRunspaceMatchingCondition( condition, tooFew, tooMany, tooFewResourceString, tooManyResourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 36208, 36315);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,35426,36327);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,35426,36327);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Job FindJobForRunspace(Guid id)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,36339,37069);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,36403,37030);
foreach(var repJob in f_1603_36426_36449_I(f_1603_36426_36449(f_1603_36426_36444(this))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,36403,37030);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,36483,37015);
foreach(Job childJob in f_1603_36508_36524_I(f_1603_36508_36524(repJob)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,36483,37015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,36566,36635);

PSRemotingChildJob 
remotingChildJob = childJob as PSRemotingChildJob
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,36659,36996) || true) && (remotingChildJob != null &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 36663, 36749)&&f_1603_36716_36741(remotingChildJob)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 36663, 36833)&&f_1603_36778_36813(f_1603_36778_36807(remotingChildJob))== JobState.Running )&&(DynAbs.Tracing.TraceSender.Expression_True(1603, 36663, 36909)&&f_1603_36862_36887(remotingChildJob).InstanceId.Equals(id)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,36659,36996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,36959,36973);

return repJob;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,36659,36996);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,36483,37015);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1603,1,533);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1603,1,533);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1603,36403,37030);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1603,1,628);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1603,1,628);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,37046,37058);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,36339,37069);

System.Management.Automation.JobRepository
f_1603_36426_36444(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36426, 36444);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1603_36426_36449(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36426, 36449);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1603_36508_36524(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36508, 36524);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_36716_36741(System.Management.Automation.PSRemotingChildJob
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36716, 36741);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1603_36778_36807(System.Management.Automation.PSRemotingChildJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36778, 36807);
return return_v;
}


System.Management.Automation.JobState
f_1603_36778_36813(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36778, 36813);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_36862_36887(System.Management.Automation.PSRemotingChildJob
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 36862, 36887);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1603_36508_36524_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 36508, 36524);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1603_36426_36449_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 36426, 36449);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,36339,37069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,36339,37069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsParameterSetForVM()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,37081,37264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,37140,37253);

return ((f_1603_37149_37165()== VMIdParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1603, 37148, 37251)||                    (f_1603_37212_37228()== VMNameParameterSet)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,37081,37264);

string
f_1603_37149_37165()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 37149, 37165);
return return_v;
}


string
f_1603_37212_37228()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 37212, 37228);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,37081,37264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,37081,37264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsParameterSetForContainer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,37276,37406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,37342,37395);

return (f_1603_37350_37366()== ContainerIdParameterSet);
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,37276,37406);

string
f_1603_37350_37366()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 37350, 37366);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,37276,37406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,37276,37406);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsParameterSetForVMContainerSession()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,37578,38919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,37653,37690);

RemoteRunspace 
remoteRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,37706,38515);

switch (f_1603_37714_37730())
            {

case SessionParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,37706,38515);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,37811,37963) || true) && (f_1603_37815_37827(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,37811,37963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,37885,37940);

remoteRunspace = (RemoteRunspace)f_1603_37918_37939(f_1603_37918_37930(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,37811,37963);
}
DynAbs.Tracing.TraceSender.TraceBreak(1603,37987,37993);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,37706,38515);

case InstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,37706,38515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,38063,38127);

remoteRunspace = f_1603_38080_38126(this, f_1603_38110_38125(this));
DynAbs.Tracing.TraceSender.TraceBreak(1603,38149,38155);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,37706,38515);

case IdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,37706,38515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,38217,38272);

remoteRunspace = f_1603_38234_38271(this, f_1603_38263_38270(this));
DynAbs.Tracing.TraceSender.TraceBreak(1603,38294,38300);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,37706,38515);

case NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,37706,38515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,38364,38416);

remoteRunspace = f_1603_38381_38415(this, f_1603_38405_38414(this));
DynAbs.Tracing.TraceSender.TraceBreak(1603,38438,38444);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,37706,38515);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,37706,38515);
DynAbs.Tracing.TraceSender.TraceBreak(1603,38494,38500);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,37706,38515);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,38531,38879) || true) && ((remoteRunspace != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 38535, 38619)&&                (f_1603_38581_38610(remoteRunspace)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,38531,38879);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,38653,38864) || true) && ((f_1603_38658_38687(remoteRunspace)is VMConnectionInfo) ||(DynAbs.Tracing.TraceSender.Expression_False(1603, 38657, 38791)||                    (f_1603_38734_38763(remoteRunspace)is ContainerConnectionInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,38653,38864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,38833,38845);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,38653,38864);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,38531,38879);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,38895,38908);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,37578,38919);

string
f_1603_37714_37730()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 37714, 37730);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_37815_37827(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Session ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 37815, 37827);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_37918_37930(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 37918, 37930);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_37918_37939(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 37918, 37939);
return return_v;
}


System.Guid
f_1603_38110_38125(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 38110, 38125);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_38080_38126(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Guid
remoteRunspaceId)
{
var return_v = this_param.GetRunspaceMatchingRunspaceId( remoteRunspaceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 38080, 38126);
return return_v;
}


int
f_1603_38263_38270(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 38263, 38270);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_38234_38271(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,int
sessionId)
{
var return_v = this_param.GetRunspaceMatchingSessionId( sessionId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 38234, 38271);
return return_v;
}


string
f_1603_38405_38414(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 38405, 38414);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_38381_38415(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
name)
{
var return_v = this_param.GetRunspaceMatchingName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 38381, 38415);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1603_38581_38610(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 38581, 38610);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1603_38658_38687(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 38658, 38687);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1603_38734_38763(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 38734, 38763);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,37578,38919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,37578,38919);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace GetRunspaceForVMSession()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,39023,45489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39096,39133);

RemoteRunspace 
remoteRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39147,39162);

string 
command
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39176,39205);

Collection<PSObject> 
results
=default(Collection<PSObject>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39221,42541) || true) && (f_1603_39225_39241()== VMIdParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,39221,42541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39295,39327);

command = "Get-VM -Id $args[0]";

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39391,39518);

results = f_1603_39401_39517(f_1603_39401_39419(this), command, false, PipelineResultTypes.None, null, f_1603_39507_39516(this));
                }
                catch (CommandNotFoundException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,39555,40015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39628,39960);

f_1603_39628_39959(this, f_1603_39665_39958(f_1603_39711_39781(f_1603_39733_39780()), f_1603_39812_39865(                            PSRemotingErrorId.HyperVModuleNotAvailable), ErrorCategory.NotInstalled, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,39984,39996);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,39555,40015);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,40035,40463) || true) && (f_1603_40039_40052(results)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,40035,40463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,40099,40408);

f_1603_40099_40407(this, f_1603_40136_40406(f_1603_40182_40239(f_1603_40204_40238()), f_1603_40270_40310(                            PSRemotingErrorId.InvalidVMId), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,40432,40444);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,40035,40463);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,40483,40543);

this.VMName = (string)f_1603_40505_40542(f_1603_40505_40536(f_1603_40505_40526(f_1603_40505_40515(results, 0)), "VMName"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,39221,42541);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,39221,42541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,40609,40699);

f_1603_40609_40698(f_1603_40620_40636()== VMNameParameterSet, "Expected ParameterSetName == VMName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,40719,40750);

command = "Get-VM -Name $args";

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,40814,40943);

results = f_1603_40824_40942(f_1603_40824_40842(this), command, false, PipelineResultTypes.None, null, f_1603_40930_40941(this));
                }
                catch (CommandNotFoundException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,40980,41440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,41053,41385);

f_1603_41053_41384(this, f_1603_41090_41383(f_1603_41136_41206(f_1603_41158_41205()), f_1603_41237_41290(                            PSRemotingErrorId.HyperVModuleNotAvailable), ErrorCategory.NotInstalled, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,41409,41421);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,40980,41440);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,41460,42374) || true) && (f_1603_41464_41477(results)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,41460,42374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,41524,41845);

f_1603_41524_41844(this, f_1603_41561_41843(f_1603_41607_41670(f_1603_41629_41669()), f_1603_41701_41747(                            PSRemotingErrorId.InvalidVMNameNoVM), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,41869,41881);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,41460,42374);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,41460,42374);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,41923,42374) || true) && (f_1603_41927_41940(results)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,41923,42374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,41986,42319);

f_1603_41986_42318(this, f_1603_42023_42317(f_1603_42069_42138(f_1603_42091_42137()), f_1603_42169_42221(                            PSRemotingErrorId.InvalidVMNameMultipleVM), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,42343,42355);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,41923,42374);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,41460,42374);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,42394,42448);

this.VMId = (Guid)f_1603_42412_42447(f_1603_42412_42441(f_1603_42412_42433(f_1603_42412_42422(results, 0)), "VMId"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,42466,42526);

this.VMName = (string)f_1603_42488_42525(f_1603_42488_42519(f_1603_42488_42509(f_1603_42488_42498(results, 0)), "VMName"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,39221,42541);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,42636,43163) || true) && ((VMState)f_1603_42649_42685(f_1603_42649_42679(f_1603_42649_42670(f_1603_42649_42659(results, 0)), "State"))!= VMState.Running)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,42636,43163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,42738,43116);

f_1603_42738_43115(this, f_1603_42771_43114(f_1603_42813_42956(f_1603_42835_42955(this, f_1603_42846_42883(), f_1603_42943_42954(this))), f_1603_42983_43026(                        PSRemotingErrorId.InvalidVMState), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,43136,43148);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,42636,43163);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,43215,43247);

VMConnectionInfo 
connectionInfo
=default(VMConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,43265,43368);

connectionInfo = f_1603_43282_43367(f_1603_43303_43318(this), f_1603_43320_43329(this), f_1603_43331_43342(this), f_1603_43344_43366(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,43388,43481);

remoteRunspace = f_1603_43405_43480(this, f_1603_43454_43463(this), connectionInfo);
            }
            catch (InvalidOperationException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,43510,43818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,43578,43759);

ErrorRecord 
errorRecord = f_1603_43604_43758(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,43779,43803);

f_1603_43779_43802(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,43510,43818);
            }
            catch (ArgumentException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,43832,44131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,43892,44072);

ErrorRecord 
errorRecord = f_1603_43918_44071(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,44092,44116);

f_1603_44092_44115(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,43832,44131);
            }
            catch (PSRemotingDataStructureException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,44145,45134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,44220,44244);

ErrorRecord 
errorRecord
=default(ErrorRecord);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,44483,45075) || true) && ((f_1603_44488_44504(e)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 44487, 44556)&&(f_1603_44518_44534(e)is PSDirectException)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,44483,45075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,44598,44793);

errorRecord = f_1603_44612_44792(f_1603_44628_44644(e), "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidArgument, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,44483,45075);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,44483,45075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,44875,45056);

errorRecord = f_1603_44889_45055(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidOperation, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,44483,45075);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,45095,45119);

f_1603_45095_45118(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,44145,45134);
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,45148,45440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,45200,45381);

ErrorRecord 
errorRecord = f_1603_45226_45380(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,45401,45425);

f_1603_45401_45424(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,45148,45440);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,45456,45478);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,39023,45489);

string
f_1603_39225_39241()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 39225, 39241);
return return_v;
}


System.Management.Automation.CommandInvocationIntrinsics
f_1603_39401_39419(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.InvokeCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 39401, 39419);
return return_v;
}


System.Guid
f_1603_39507_39516(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 39507, 39516);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1603_39401_39517(System.Management.Automation.CommandInvocationIntrinsics
this_param,string
script,bool
useNewScope,System.Management.Automation.Runspaces.PipelineResultTypes
writeToPipeline,System.Collections.IList
input,params object[]
args)
{
var return_v = this_param.InvokeScript( script, useNewScope, writeToPipeline, input, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 39401, 39517);
return return_v;
}


string
f_1603_39733_39780()
{
var return_v = RemotingErrorIdStrings.HyperVModuleNotAvailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 39733, 39780);
return return_v;
}


System.ArgumentException
f_1603_39711_39781(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 39711, 39781);
return return_v;
}


string
f_1603_39812_39865(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 39812, 39865);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_39665_39958(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 39665, 39958);
return return_v;
}


int
f_1603_39628_39959(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 39628, 39959);
return 0;
}


int
f_1603_40039_40052(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40039, 40052);
return return_v;
}


string
f_1603_40204_40238()
{
var return_v = RemotingErrorIdStrings.InvalidVMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40204, 40238);
return return_v;
}


System.ArgumentException
f_1603_40182_40239(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 40182, 40239);
return return_v;
}


string
f_1603_40270_40310(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 40270, 40310);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_40136_40406(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 40136, 40406);
return return_v;
}


int
f_1603_40099_40407(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 40099, 40407);
return 0;
}


System.Management.Automation.PSObject
f_1603_40505_40515(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40505, 40515);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1603_40505_40526(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40505, 40526);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1603_40505_40536(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40505, 40536);
return return_v;
}


object
f_1603_40505_40542(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40505, 40542);
return return_v;
}


string
f_1603_40620_40636()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40620, 40636);
return return_v;
}


int
f_1603_40609_40698(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 40609, 40698);
return 0;
}


System.Management.Automation.CommandInvocationIntrinsics
f_1603_40824_40842(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.InvokeCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40824, 40842);
return return_v;
}


string
f_1603_40930_40941(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 40930, 40941);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1603_40824_40942(System.Management.Automation.CommandInvocationIntrinsics
this_param,string
script,bool
useNewScope,System.Management.Automation.Runspaces.PipelineResultTypes
writeToPipeline,System.Collections.IList
input,params object[]
args)
{
var return_v = this_param.InvokeScript( script, useNewScope, writeToPipeline, input, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 40824, 40942);
return return_v;
}


string
f_1603_41158_41205()
{
var return_v = RemotingErrorIdStrings.HyperVModuleNotAvailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 41158, 41205);
return return_v;
}


System.ArgumentException
f_1603_41136_41206(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41136, 41206);
return return_v;
}


string
f_1603_41237_41290(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41237, 41290);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_41090_41383(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41090, 41383);
return return_v;
}


int
f_1603_41053_41384(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41053, 41384);
return 0;
}


int
f_1603_41464_41477(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 41464, 41477);
return return_v;
}


string
f_1603_41629_41669()
{
var return_v = RemotingErrorIdStrings.InvalidVMNameNoVM;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 41629, 41669);
return return_v;
}


System.ArgumentException
f_1603_41607_41670(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41607, 41670);
return return_v;
}


string
f_1603_41701_41747(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41701, 41747);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_41561_41843(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41561, 41843);
return return_v;
}


int
f_1603_41524_41844(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41524, 41844);
return 0;
}


int
f_1603_41927_41940(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 41927, 41940);
return return_v;
}


string
f_1603_42091_42137()
{
var return_v = RemotingErrorIdStrings.InvalidVMNameMultipleVM;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42091, 42137);
return return_v;
}


System.ArgumentException
f_1603_42069_42138(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42069, 42138);
return return_v;
}


string
f_1603_42169_42221(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42169, 42221);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_42023_42317(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42023, 42317);
return return_v;
}


int
f_1603_41986_42318(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 41986, 42318);
return 0;
}


System.Management.Automation.PSObject
f_1603_42412_42422(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42412, 42422);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1603_42412_42433(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42412, 42433);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1603_42412_42441(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42412, 42441);
return return_v;
}


object
f_1603_42412_42447(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42412, 42447);
return return_v;
}


System.Management.Automation.PSObject
f_1603_42488_42498(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42488, 42498);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1603_42488_42509(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42488, 42509);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1603_42488_42519(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42488, 42519);
return return_v;
}


object
f_1603_42488_42525(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42488, 42525);
return return_v;
}


System.Management.Automation.PSObject
f_1603_42649_42659(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42649, 42659);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1603_42649_42670(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42649, 42670);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1603_42649_42679(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42649, 42679);
return return_v;
}


object
f_1603_42649_42685(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42649, 42685);
return return_v;
}


string
f_1603_42846_42883()
{
var return_v = RemotingErrorIdStrings.InvalidVMState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42846, 42883);
return return_v;
}


string
f_1603_42943_42954(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 42943, 42954);
return return_v;
}


string
f_1603_42835_42955(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42835, 42955);
return return_v;
}


System.ArgumentException
f_1603_42813_42956(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42813, 42956);
return return_v;
}


string
f_1603_42983_43026(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42983, 43026);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_42771_43114(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42771, 43114);
return return_v;
}


int
f_1603_42738_43115(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 42738, 43115);
return 0;
}


System.Management.Automation.PSCredential
f_1603_43303_43318(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 43303, 43318);
return return_v;
}


System.Guid
f_1603_43320_43329(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 43320, 43329);
return return_v;
}


string
f_1603_43331_43342(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 43331, 43342);
return return_v;
}


string
f_1603_43344_43366(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 43344, 43366);
return return_v;
}


System.Management.Automation.Runspaces.VMConnectionInfo
f_1603_43282_43367(System.Management.Automation.PSCredential
credential,System.Guid
vmGuid,string
vmName,string
configurationName)
{
var return_v = new System.Management.Automation.Runspaces.VMConnectionInfo( credential, vmGuid, vmName, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 43282, 43367);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1603_43454_43463(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 43454, 43463);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_43405_43480(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.VMConnectionInfo
connectionInfo)
{
var return_v = this_param.CreateTemporaryRemoteRunspaceForPowerShellDirect( host, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 43405, 43480);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_43604_43758(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 43604, 43758);
return return_v;
}


int
f_1603_43779_43802(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 43779, 43802);
return 0;
}


System.Management.Automation.ErrorRecord
f_1603_43918_44071(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 43918, 44071);
return return_v;
}


int
f_1603_44092_44115(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 44092, 44115);
return 0;
}


System.Exception
f_1603_44488_44504(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 44488, 44504);
return return_v;
}


System.Exception
f_1603_44518_44534(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 44518, 44534);
return return_v;
}


System.Exception
f_1603_44628_44644(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 44628, 44644);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_44612_44792(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 44612, 44792);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_44889_45055(System.Management.Automation.Remoting.PSRemotingDataStructureException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 44889, 45055);
return return_v;
}


int
f_1603_45095_45118(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 45095, 45118);
return 0;
}


System.Management.Automation.ErrorRecord
f_1603_45226_45380(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 45226, 45380);
return return_v;
}


int
f_1603_45401_45424(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 45401, 45424);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,39023,45489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,39023,45489);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace CreateTemporaryRemoteRunspaceForPowerShellDirect(PSHost host, RunspaceConnectionInfo connectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,45595,46744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,45789,45844);

TypeTable 
typeTable = f_1603_45811_45843()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,45858,45972);

RemoteRunspace 
remoteRunspace = f_1603_45890_45953(connectionInfo, host, typeTable)as RemoteRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,45986,46033);

remoteRunspace.Name = "PowerShellDirectAttach";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46049,46119);

f_1603_46049_46118(remoteRunspace != null, "Expected remoteRunspace != null");
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46169,46191);

f_1603_46169_46190(                remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46286,46325);

remoteRunspace.ShouldCloseOnPop = true;
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1603,46354,46695);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46484,46680) || true) && (f_1603_46488_46526(f_1603_46488_46520(remoteRunspace))!= RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,46484,46680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46592,46617);

f_1603_46592_46616(                    remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46639,46661);

remoteRunspace = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,46484,46680);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1603,46354,46695);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46711,46733);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,45595,46744);

System.Management.Automation.Runspaces.TypeTable
f_1603_45811_45843()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 45811, 45843);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_45890_45953(System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RunspaceFactory.CreateRunspace( connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 45890, 45953);
return return_v;
}


int
f_1603_46049_46118(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 46049, 46118);
return 0;
}


int
f_1603_46169_46190(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 46169, 46190);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1603_46488_46520(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 46488, 46520);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1603_46488_46526(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 46488, 46526);
return return_v;
}


int
f_1603_46592_46616(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 46592, 46616);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,45595,46744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,45595,46744);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void SetRunspacePrompt(RemoteRunspace remoteRunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,46854,49329);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,46940,49295) || true) && (f_1603_46944_46965(this)||(DynAbs.Tracing.TraceSender.Expression_False(1603, 46944, 47014)||f_1603_46986_47014(this))||(DynAbs.Tracing.TraceSender.Expression_False(1603, 46944, 47072)||f_1603_47035_47072(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,46940,49295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,47106,47139);

string 
targetName = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,47159,48460);

switch (f_1603_47167_47183())
                {

case VMIdParameterSet:
                    case VMNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,47159,48460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,47319,47344);

targetName = f_1603_47332_47343(this);
DynAbs.Tracing.TraceSender.TraceBreak(1603,47370,47376);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,47159,48460);

case ContainerIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,47159,48460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,47455,47645);

targetName = (DynAbs.Tracing.TraceSender.Conditional_F1(1603, 47468, 47499)||(((f_1603_47469_47492(f_1603_47469_47485(this))<= 15) &&DynAbs.Tracing.TraceSender.Conditional_F2(1603, 47502, 47518))||DynAbs.Tracing.TraceSender.Conditional_F3(1603, 47591, 47644)))?f_1603_47502_47518(this):f_1603_47591_47618(f_1603_47591_47607(this), 14)+ DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (PSObjectHelper.Ellipsis).ToString(),1603,47621,47644);
DynAbs.Tracing.TraceSender.TraceBreak(1603,47671,47677);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,47159,48460);

case SessionParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,47159,48460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,47752,47831);

targetName = (DynAbs.Tracing.TraceSender.Conditional_F1(1603, 47765, 47787)||(((f_1603_47766_47778(this)!= null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1603, 47790, 47815))||DynAbs.Tracing.TraceSender.Conditional_F3(1603, 47818, 47830)))?f_1603_47790_47815(f_1603_47790_47802(this)):string.Empty;
DynAbs.Tracing.TraceSender.TraceBreak(1603,47857,47863);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,47159,48460);

case InstanceIdParameterSet:
                    case IdParameterSet:
                    case NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,47159,48460);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,48027,48268) || true) && ((remoteRunspace != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 48031, 48127)&&                            (f_1603_48089_48118(remoteRunspace)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,48027,48268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,48185,48241);

targetName = f_1603_48198_48240(f_1603_48198_48227(remoteRunspace));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,48027,48268);
}
DynAbs.Tracing.TraceSender.TraceBreak(1603,48296,48302);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,47159,48460);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,47159,48460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,48360,48409);

f_1603_48360_48408(false, "Unrecognized parameter set.");
DynAbs.Tracing.TraceSender.TraceBreak(1603,48435,48441);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,47159,48460);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,48480,48736);

string 
promptFn = f_1603_48498_48735(f_1603_48516_48559(), @"function global:prompt { """, targetName, @"PS $($executionContext.SessionState.Path.CurrentLocation)> "" }")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,48818,49280);
using(System.Management.Automation.PowerShell 
ps = f_1603_48870_48918()
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,48960,48989);

ps.Runspace = remoteRunspace;

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,49121,49153);

f_1603_49121_49152(f_1603_49121_49143(                        // Set pushed runspace prompt.
                        ps, promptFn));
                    }
                    catch (Exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,49198,49261);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,49198,49261);
                    }
DynAbs.Tracing.TraceSender.TraceExitUsing(1603,48818,49280);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,46940,49295);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,49311,49318);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,46854,49329);

bool
f_1603_46944_46965(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForVM();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 46944, 46965);
return return_v;
}


bool
f_1603_46986_47014(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForContainer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 46986, 47014);
return return_v;
}


bool
f_1603_47035_47072(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.IsParameterSetForVMContainerSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 47035, 47072);
return return_v;
}


string
f_1603_47167_47183()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47167, 47183);
return return_v;
}


string
f_1603_47332_47343(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47332, 47343);
return return_v;
}


string
f_1603_47469_47485(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47469, 47485);
return return_v;
}


int
f_1603_47469_47492(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47469, 47492);
return return_v;
}


string
f_1603_47502_47518(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.ContainerId
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47502, 47518);
return return_v;
}


string
f_1603_47591_47607(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47591, 47607);
return return_v;
}


string
f_1603_47591_47618(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 47591, 47618);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_47766_47778(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Session ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47766, 47778);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1603_47790_47802(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47790, 47802);
return return_v;
}


string
f_1603_47790_47815(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 47790, 47815);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1603_48089_48118(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 48089, 48118);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1603_48198_48227(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 48198, 48227);
return return_v;
}


string
f_1603_48198_48240(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 48198, 48240);
return return_v;
}


int
f_1603_48360_48408(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 48360, 48408);
return 0;
}


string
f_1603_48516_48559()
{
var return_v = RemotingErrorIdStrings.EnterVMSessionPrompt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 48516, 48559);
return return_v;
}


string
f_1603_48498_48735(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 48498, 48735);
return return_v;
}


System.Management.Automation.PowerShell
f_1603_48870_48918()
{
var return_v = System.Management.Automation.PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 48870, 48918);
return return_v;
}


System.Management.Automation.PowerShell
f_1603_49121_49143(System.Management.Automation.PowerShell
this_param,string
script)
{
var return_v = this_param.AddScript( script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 49121, 49143);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1603_49121_49152(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 49121, 49152);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,46854,49329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,46854,49329);
}
		}

private RemoteRunspace GetRunspaceForContainerSession()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,49440,52311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,49520,49557);

RemoteRunspace 
remoteRunspace = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,49609,49686);

f_1603_49609_49685(!f_1603_49621_49654(f_1603_49642_49653()), "ContainerId has to be set.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,49706,49752);

ContainerConnectionInfo 
connectionInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,49958,50096);

connectionInfo = f_1603_49975_50095(f_1603_50029_50040(), f_1603_50042_50060().IsPresent, f_1603_50072_50094(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,50116,50156);

f_1603_50116_50155(
                connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,50174,50267);

remoteRunspace = f_1603_50191_50266(this, f_1603_50240_50249(this), connectionInfo);
            }
            catch (InvalidOperationException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,50296,50611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,50364,50552);

ErrorRecord 
errorRecord = f_1603_50390_50551(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,50572,50596);

f_1603_50572_50595(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,50296,50611);
            }
            catch (ArgumentException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,50625,50931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,50685,50872);

ErrorRecord 
errorRecord = f_1603_50711_50871(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,50892,50916);

f_1603_50892_50915(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,50625,50931);
            }
            catch (PSRemotingDataStructureException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,50945,51949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,51020,51044);

ErrorRecord 
errorRecord
=default(ErrorRecord);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,51283,51890) || true) && ((f_1603_51288_51304(e)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 51287, 51356)&&(f_1603_51318_51334(e)is PSDirectException)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,51283,51890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,51398,51601);

errorRecord = f_1603_51412_51600(f_1603_51428_51444(e), "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,51283,51890);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,51283,51890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,51683,51871);

errorRecord = f_1603_51697_51870(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,51283,51890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,51910,51934);

f_1603_51910_51933(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,50945,51949);
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1603,51963,52262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,52015,52203);

ErrorRecord 
errorRecord = f_1603_52041_52202(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,52223,52247);

f_1603_52223_52246(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1603,51963,52262);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,52278,52300);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,49440,52311);

string
f_1603_49642_49653()
{
var return_v = ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 49642, 49653);
return return_v;
}


bool
f_1603_49621_49654(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 49621, 49654);
return return_v;
}


int
f_1603_49609_49685(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 49609, 49685);
return 0;
}


string
f_1603_50029_50040()
{
var return_v = ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 50029, 50040);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1603_50042_50060()
{
var return_v = RunAsAdministrator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 50042, 50060);
return return_v;
}


string
f_1603_50072_50094(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 50072, 50094);
return return_v;
}


System.Management.Automation.Runspaces.ContainerConnectionInfo
f_1603_49975_50095(string
containerId,bool
runAsAdmin,string
configurationName)
{
var return_v = ContainerConnectionInfo.CreateContainerConnectionInfo( containerId, runAsAdmin, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 49975, 50095);
return return_v;
}


int
f_1603_50116_50155(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
this_param.CreateContainerProcess();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 50116, 50155);
return 0;
}


System.Management.Automation.Host.PSHost
f_1603_50240_50249(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 50240, 50249);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1603_50191_50266(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.ContainerConnectionInfo
connectionInfo)
{
var return_v = this_param.CreateTemporaryRemoteRunspaceForPowerShellDirect( host, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 50191, 50266);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_50390_50551(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 50390, 50551);
return return_v;
}


int
f_1603_50572_50595(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 50572, 50595);
return 0;
}


System.Management.Automation.ErrorRecord
f_1603_50711_50871(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 50711, 50871);
return return_v;
}


int
f_1603_50892_50915(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 50892, 50915);
return 0;
}


System.Exception
f_1603_51288_51304(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 51288, 51304);
return return_v;
}


System.Exception
f_1603_51318_51334(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 51318, 51334);
return return_v;
}


System.Exception
f_1603_51428_51444(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 51428, 51444);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_51412_51600(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 51412, 51600);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1603_51697_51870(System.Management.Automation.Remoting.PSRemotingDataStructureException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 51697, 51870);
return return_v;
}


int
f_1603_51910_51933(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 51910, 51933);
return 0;
}


System.Management.Automation.ErrorRecord
f_1603_52041_52202(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 52041, 52202);
return return_v;
}


int
f_1603_52223_52246(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 52223, 52246);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,49440,52311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,49440,52311);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteRunspace GetRunspaceForSSHSession()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1603,52423,53406);
string host = default(string);
string userName = default(string);
int port = default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,52497,52576);

f_1603_52497_52575(this, f_1603_52514_52522(), out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,52590,52692);

var 
sshConnectionInfo = f_1603_52614_52691(userName, host, f_1603_52652_52668(this), port, f_1603_52676_52690(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,52706,52755);

var 
typeTable = f_1603_52722_52754()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53080,53186);

_tempRunspace = f_1603_53096_53167(sshConnectionInfo, f_1603_53146_53155(this), typeTable)as RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53200,53221);

f_1603_53200_53220(            _tempRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53235,53273);

_tempRunspace.ShouldCloseOnPop = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53287,53322);

var 
remoteRunspace = _tempRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53336,53357);

_tempRunspace = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53373,53395);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1603,52423,53406);

string
f_1603_52514_52522()
{
var return_v = HostName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 52514, 52522);
return return_v;
}


int
f_1603_52497_52575(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param,string
hostname,out string
host,out string
userName,out int
port)
{
this_param.ParseSshHostName( hostname, out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 52497, 52575);
return 0;
}


string
f_1603_52652_52668(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.KeyFilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 52652, 52668);
return return_v;
}


string
f_1603_52676_52690(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Subsystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 52676, 52690);
return return_v;
}


System.Management.Automation.Runspaces.SSHConnectionInfo
f_1603_52614_52691(string
userName,string
computerName,string
keyFilePath,int
port,string
subsystem)
{
var return_v = new System.Management.Automation.Runspaces.SSHConnectionInfo( userName, computerName, keyFilePath, port, subsystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 52614, 52691);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1603_52722_52754()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 52722, 52754);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1603_53146_53155(Microsoft.PowerShell.Commands.EnterPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 53146, 53155);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1603_53096_53167(System.Management.Automation.Runspaces.SSHConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RunspaceFactory.CreateRunspace( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 53096, 53167);
return return_v;
}


int
f_1603_53200_53220(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 53200, 53220);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,52423,53406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,52423,53406);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static RemotePipeline ConnectRunningPipeline(RemoteRunspace remoteRunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1603,53476,55069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53585,53611);

RemotePipeline 
cmd = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53625,54098) || true) && (f_1603_53629_53657(remoteRunspace)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,53625,54098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,53867,53908);

cmd = f_1603_53873_53907(remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,53625,54098);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,53625,54098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,54014,54083);

cmd = f_1603_54020_54064(remoteRunspace)as RemotePipeline;
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,53625,54098);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,54243,55031) || true) && (cmd != null &&(DynAbs.Tracing.TraceSender.Expression_True(1603, 54247, 54336)&&f_1603_54279_54306(f_1603_54279_54300(cmd))== PipelineState.Disconnected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,54243,55031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,54370,55016);
using(ManualResetEvent 
connected = f_1603_54406_54433(false)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,54475,54912);

cmd.StateChanged += (sender, args) =>
                    {
                        if (args.PipelineStateInfo.State != PipelineState.Disconnected)
                        {
                            try
                            {
                                connected.Set();
                            }
                            catch (ObjectDisposedException) { }
                        }
                    };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,54936,54955);

f_1603_54936_54954(
                    cmd);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,54977,54997);

f_1603_54977_54996(                    connected);
DynAbs.Tracing.TraceSender.TraceExitUsing(1603,54370,55016);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,54243,55031);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55047,55058);

return cmd;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1603,53476,55069);

System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1603_53629_53657(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 53629, 53657);
return return_v;
}


System.Management.Automation.RemotePipeline
f_1603_53873_53907(System.Management.Automation.RemoteRunspace
runspace)
{
var return_v = new System.Management.Automation.RemotePipeline( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 53873, 53907);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1603_54020_54064(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetCurrentlyRunningPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 54020, 54064);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1603_54279_54300(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 54279, 54300);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1603_54279_54306(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 54279, 54306);
return return_v;
}


System.Threading.ManualResetEvent
f_1603_54406_54433(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 54406, 54433);
return return_v;
}


int
f_1603_54936_54954(System.Management.Automation.RemotePipeline
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 54936, 54954);
return 0;
}


bool
f_1603_54977_54996(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 54977, 54996);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,53476,55069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,53476,55069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void ContinueCommand(RemoteRunspace remoteRunspace, Pipeline cmd, PSHost host, bool inDebugMode, System.Management.Automation.ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1603,55081,57425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55273,55327);

RemotePipeline 
remotePipeline = cmd as RemotePipeline
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55343,57414) || true) && (remotePipeline != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,55343,57414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55403,57399);
using(System.Management.Automation.PowerShell 
ps = f_1603_55455_55503()
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55545,55687);

PSInvocationSettings 
settings = new PSInvocationSettings()
                    {
                        Host = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => host,1603,55577,55686)
                    }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55711,55779);

PSDataCollection<PSObject> 
input = f_1603_55746_55778()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55803,55907);

CommandInfo 
commandInfo = f_1603_55829_55906("Out-Default", typeof(OutDefaultCommand), null, null, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,55929,55982);

Command 
outDefaultCommand = f_1603_55957_55981(commandInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56004,56037);

f_1603_56004_56036(                    ps, outDefaultCommand);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56059,56134);

IAsyncResult 
async = f_1603_56080_56133(ps, input, settings, null, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56158,56232);

RemoteDebugger 
remoteDebugger = f_1603_56190_56213(remoteRunspace)as RemoteDebugger
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56254,56866) || true) && (remoteDebugger != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,56254,56866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56533,56578);

f_1603_56533_56577(                        // Update client with breakpoint information from pushed runspace.
                        // Information will be passed to the client via the Debugger.BreakpointUpdated event.
                        remoteDebugger);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56606,56843) || true) && (!inDebugMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,56606,56843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56771,56816);

f_1603_56771_56815(                            // Enter debug mode if remote runspace is in debug stop mode.
                            remoteDebugger);
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,56606,56843);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,56254,56866);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,56949,57297) || true) && (f_1603_56956_56992_M(!f_1603_56957_56978(remotePipeline).EndOfPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,56949,57297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,57042,57085);

f_1603_57042_57084(f_1603_57042_57074(f_1603_57042_57063(remotePipeline)));
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,57111,57274) || true) && (f_1603_57118_57145(f_1603_57118_57139(remotePipeline))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1603,57111,57274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,57207,57247);

f_1603_57207_57246(                            input, f_1603_57217_57245(f_1603_57217_57238(remotePipeline)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,57111,57274);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1603,57111,57274);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1603,57111,57274);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1603,56949,57297);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1603,56949,57297);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1603,56949,57297);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,57321,57338);

f_1603_57321_57337(
                    input);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,57360,57380);

f_1603_57360_57379(                    ps, async);
DynAbs.Tracing.TraceSender.TraceExitUsing(1603,55403,57399);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1603,55343,57414);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1603,55081,57425);

System.Management.Automation.PowerShell
f_1603_55455_55503()
{
var return_v = System.Management.Automation.PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 55455, 55503);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1603_55746_55778()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 55746, 55778);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1603_55829_55906(string
name,System.Type
implementingType,string
helpFile,System.Management.Automation.PSSnapInInfo
PSSnapin,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.CmdletInfo( name, implementingType, helpFile, PSSnapin, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 55829, 55906);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1603_55957_55981(System.Management.Automation.CommandInfo
commandInfo)
{
var return_v = new System.Management.Automation.Runspaces.Command( commandInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 55957, 55981);
return return_v;
}


System.Management.Automation.PowerShell
f_1603_56004_56036(System.Management.Automation.PowerShell
this_param,System.Management.Automation.Runspaces.Command
command)
{
var return_v = this_param.AddCommand( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 56004, 56036);
return return_v;
}


System.IAsyncResult
f_1603_56080_56133(System.Management.Automation.PowerShell
this_param,System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
input,System.Management.Automation.PSInvocationSettings
settings,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginInvoke<System.Management.Automation.PSObject>( input, settings, callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 56080, 56133);
return return_v;
}


System.Management.Automation.Debugger
f_1603_56190_56213(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Debugger ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 56190, 56213);
return return_v;
}


int
f_1603_56533_56577(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.SendBreakpointUpdatedEvents();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 56533, 56577);
return 0;
}


int
f_1603_56771_56815(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckStateAndRaiseStopEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 56771, 56815);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1603_56957_56978(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 56957, 56978);
return return_v;
}


bool
f_1603_56956_56992_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 56956, 56992);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1603_57042_57063(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 57042, 57063);
return return_v;
}


System.Threading.WaitHandle
f_1603_57042_57074(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.WaitHandle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 57042, 57074);
return return_v;
}


bool
f_1603_57042_57084(System.Threading.WaitHandle
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 57042, 57084);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1603_57118_57139(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 57118, 57139);
return return_v;
}


int
f_1603_57118_57145(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 57118, 57145);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1603_57217_57238(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1603, 57217, 57238);
return return_v;
}


System.Management.Automation.PSObject
f_1603_57217_57245(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 57217, 57245);
return return_v;
}


int
f_1603_57207_57246(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 57207, 57246);
return 0;
}


int
f_1603_57321_57337(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 57321, 57337);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1603_57360_57379(System.Management.Automation.PowerShell
this_param,System.IAsyncResult
asyncResult)
{
var return_v = this_param.EndInvoke( asyncResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1603, 57360, 57379);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1603,55081,57425);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,55081,57425);
}
		}

public EnterPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1603,734,57454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,1489,1496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,1530,1543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,1745,1974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,2093,2371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,2463,2810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,2907,3137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,3673,3864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,3977,4116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,5199,5442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,6587,6840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,7291,8052);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1603,734,57454);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,734,57454);
}


static EnterPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1603,734,57454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,1070,1107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,1139,1160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1603,1192,1217);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1603,734,57454);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1603,734,57454);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1603,734,57454);
}
}
