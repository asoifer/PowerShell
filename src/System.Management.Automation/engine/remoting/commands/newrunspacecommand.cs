// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.New, "PSSession", DefaultParameterSetName = "ComputerName",
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096484", RemotingCapability = RemotingCapability.OwnedByCommand)]
    [OutputType(typeof(PSSession))]
    public class NewPSSessionCommand : PSRemotingBaseCmdlet, IDisposable
{
[Parameter(Position = 0,
                   ValueFromPipeline = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = NewPSSessionCommand.ComputerNameParameterSet)]
        [Alias("Cn")]
        [ValidateNotNullOrEmpty]
        public override string[] ComputerName {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.VMIdParameterSet)]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.VMNameParameterSet)]
        [Credential()]
        public override PSCredential Credential
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,4338,4369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,4344,4367);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Credential,1600,4351,4366);
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,4338,4369);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,3609,4471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,3609,4471);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,4385,4460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,4421,4445);

base.Credential = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,4385,4460);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,3609,4471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,3609,4471);
}
		}}

[Parameter(Position = 0,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = NewPSSessionCommand.SessionParameterSet)]
        [ValidateNotNullOrEmpty]
        public override PSSession[] Session
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,4985,5064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,5021,5049);

return _remoteRunspaceInfos;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,4985,5064);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,4670,5171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,4670,5171);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,5080,5160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,5116,5145);

_remoteRunspaceInfos = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,5080,5160);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,4670,5171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,4670,5171);
}
		}}

private PSSession[] _remoteRunspaceInfos;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] Name {get; set; }

[Parameter(ParameterSetName = NewPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = NewPSSessionCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = NewPSSessionCommand.UriParameterSet)]
        public SwitchParameter EnableNetworkAccess {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = NewPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = NewPSSessionCommand.UriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = NewPSSessionCommand.ContainerIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = NewPSSessionCommand.VMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = NewPSSessionCommand.VMNameParameterSet)]
        public string ConfigurationName {get; set; }

[Parameter(Mandatory = true, ParameterSetName = NewPSSessionCommand.UseWindowsPowerShellParameterSet)]
        public SwitchParameter UseWindowsPowerShell {get; set; }

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,8027,8966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8093,8116);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1600,8093,8115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8130,8158);

f_1600_8130_8157(            _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8172,8219);

_throttleManager.ThrottleLimit = f_1600_8205_8218();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8233,8339);

_throttleManager.ThrottleComplete +=
                new EventHandler<EventArgs>(HandleThrottleComplete);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8355,8955) || true) && (f_1600_8359_8398(f_1600_8380_8397()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,8355,8955);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8432,8940) || true) && ((f_1600_8437_8453()== NewPSSessionCommand.ComputerNameParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1600, 8436, 8584)||                    (f_1600_8528_8544()== NewPSSessionCommand.UriParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,8432,8940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8689,8728);

ConfigurationName = f_1600_8709_8727(this, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,8432,8940);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,8432,8940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,8888,8921);

ConfigurationName = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,8432,8940);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,8355,8955);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,8027,8966);

bool
f_1600_8130_8157(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 8130, 8157);
return return_v;
}


int
f_1600_8205_8218()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 8205, 8218);
return return_v;
}


string
f_1600_8380_8397()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 8380, 8397);
return return_v;
}


bool
f_1600_8359_8398(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 8359, 8398);
return return_v;
}


string
f_1600_8437_8453()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 8437, 8453);
return return_v;
}


string
f_1600_8528_8544()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 8528, 8544);
return return_v;
}


string
f_1600_8709_8727(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string
shell)
{
var return_v = this_param.ResolveShell( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 8709, 8727);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,8027,8966);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,8027,8966);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,9266,13269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,9330,9374);

List<RemoteRunspace> 
remoteRunspaces = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,9388,9457);

List<IThrottleOperation> 
operations = f_1600_9426_9456()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,9473,11726);

switch (f_1600_9481_9497())
            {

case NewPSSessionCommand.SessionParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,9625,9691);

remoteRunspaces = f_1600_9643_9690(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,9738,9744);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

case "Uri":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,9824,9885);

remoteRunspaces = f_1600_9842_9884(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,9932,9938);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

case NewPSSessionCommand.ComputerNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,10057,10127);

remoteRunspaces = f_1600_10075_10126(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,10174,10180);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

case NewPSSessionCommand.VMIdParameterSet:
                case NewPSSessionCommand.VMNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,10353,10413);

remoteRunspaces = f_1600_10371_10412(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,10460,10466);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

case NewPSSessionCommand.ContainerIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,10584,10651);

remoteRunspaces = f_1600_10602_10650(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,10698,10704);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

case NewPSSessionCommand.SSHHostParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,10818,10876);

remoteRunspaces = f_1600_10836_10875(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,10923,10929);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

case NewPSSessionCommand.SSHHostHashParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,11047,11109);

remoteRunspaces = f_1600_11065_11108(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,11156,11162);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

case NewPSSessionCommand.UseWindowsPowerShellParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,11289,11360);

remoteRunspaces = f_1600_11307_11359(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,11407,11413);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,9473,11726);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,11490,11553);

f_1600_11490_11552(false, "Missing parameter set in switch statement");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,11579,11624);

remoteRunspaces = f_1600_11597_11623();
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,11705,11711);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,9473,11726);
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,11742,12490);
foreach(RemoteRunspace remoteRunspace in f_1600_11784_11799_I(remoteRunspaces) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,11742,12490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,11833,11915);

f_1600_11833_11869(f_1600_11833_11854(remoteRunspace)).PSEventReceived += OnRunspacePSEventReceived;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,11935,12011);

OpenRunspaceOperation 
operation = f_1600_11969_12010(remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,12223,12345);

operation.OperationComplete +=
                    new EventHandler<OperationStateEventArgs>(HandleRunspaceStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,12363,12431);

remoteRunspace.URIRedirectionReported += HandleURIDirectionReported;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,12449,12475);

f_1600_12449_12474(                operations, operation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,11742,12490);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,749);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,749);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,12611,12657);

f_1600_12611_12656(
            // submit list of operations to throttle manager to start opening
            // runspaces
            _throttleManager, operations);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,12715,12746);

f_1600_12715_12745(
            // Add to list for clean up.
            _allOperations, operations);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13009,13100);

Collection<object> 
streamObjects =
f_1600_13061_13099(f_1600_13061_13081(_stream))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13116,13258);
foreach(object streamObject in f_1600_13148_13161_I(streamObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,13116,13258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13195,13243);

f_1600_13195_13242(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,13116,13258);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,143);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,143);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1600,9266,13269);

System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1600_9426_9456()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 9426, 9456);
return return_v;
}


string
f_1600_9481_9497()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 9481, 9497);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_9643_9690(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesWhenRunspaceParameterSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 9643, 9690);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_9842_9884(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesWhenUriParameterSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 9842, 9884);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_10075_10126(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesWhenComputerNameParameterSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 10075, 10126);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_10371_10412(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesWhenVMParameterSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 10371, 10412);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_10602_10650(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesWhenContainerParameterSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 10602, 10650);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_10836_10875(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesForSSHHostParameterSet();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 10836, 10875);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_11065_11108(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesForSSHHostHashParameterSet();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 11065, 11108);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_11307_11359(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.CreateRunspacesForUseWindowsPowerShellParameterSet();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 11307, 11359);
return return_v;
}


int
f_1600_11490_11552(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 11490, 11552);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_11597_11623()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 11597, 11623);
return return_v;
}


System.Management.Automation.PSEventManager
f_1600_11833_11854(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 11833, 11854);
return return_v;
}


System.Management.Automation.PSEventArgsCollection
f_1600_11833_11869(System.Management.Automation.PSEventManager
this_param)
{
var return_v = this_param.ReceivedEvents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 11833, 11869);
return return_v;
}


Microsoft.PowerShell.Commands.OpenRunspaceOperation
f_1600_11969_12010(System.Management.Automation.RemoteRunspace
runspace)
{
var return_v = new Microsoft.PowerShell.Commands.OpenRunspaceOperation( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 11969, 12010);
return return_v;
}


int
f_1600_12449_12474(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,Microsoft.PowerShell.Commands.OpenRunspaceOperation
item)
{
this_param.Add( (System.Management.Automation.Remoting.IThrottleOperation)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 12449, 12474);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_11784_11799_I(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 11784, 11799);
return return_v;
}


int
f_1600_12611_12656(System.Management.Automation.Remoting.ThrottleManager
this_param,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
operations)
{
this_param.SubmitOperations( operations);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 12611, 12656);
return 0;
}


int
f_1600_12715_12745(System.Collections.ObjectModel.Collection<System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>>
this_param,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 12715, 12745);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1600_13061_13081(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 13061, 13081);
return return_v;
}


System.Collections.ObjectModel.Collection<object>
f_1600_13061_13099(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.NonBlockingRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 13061, 13099);
return return_v;
}


int
f_1600_13195_13242(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 13195, 13242);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_1600_13148_13161_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 13148, 13161);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,9266,13269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,9266,13269);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,13544,14250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13676,13715);

f_1600_13676_13714(            // signal to throttle manager end of submit operations
            _throttleManager);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13731,14239) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,13731,14239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13854,13896);

f_1600_13854_13895(f_1600_13854_13885(f_1600_13854_13874(_stream)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13916,14224) || true) && (f_1600_13920_13955_M(!f_1600_13921_13941(_stream).EndOfPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,13916,14224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,13997,14047);

object 
streamObject = f_1600_14019_14046(f_1600_14019_14039(_stream))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,14069,14117);

f_1600_14069_14116(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,13916,14224);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,13916,14224);
DynAbs.Tracing.TraceSender.TraceBreak(1600,14199,14205);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,13916,14224);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,13731,14239);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,13731,14239);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,13731,14239);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1600,13544,14250);

int
f_1600_13676_13714(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.EndSubmitOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 13676, 13714);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1600_13854_13874(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 13854, 13874);
return return_v;
}


System.Threading.WaitHandle
f_1600_13854_13885(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.WaitHandle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 13854, 13885);
return return_v;
}


bool
f_1600_13854_13895(System.Threading.WaitHandle
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 13854, 13895);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1600_13921_13941(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 13921, 13941);
return return_v;
}


bool
f_1600_13920_13955_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 13920, 13955);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1600_14019_14039(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 14019, 14039);
return return_v;
}


object
f_1600_14019_14046(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 14019, 14046);
return return_v;
}


int
f_1600_14069_14116(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 14069, 14116);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,13544,14250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,13544,14250);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,14844,15251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,15024,15053);

f_1600_15024_15052(f_1600_15024_15044(_stream));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,15203,15240);

f_1600_15203_15239(
            // for all the runspaces that have been submitted for opening
            // call StopOperation on each object and quit
            _throttleManager);
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,14844,15251);

System.Management.Automation.Runspaces.PipelineWriter
f_1600_15024_15044(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 15024, 15044);
return return_v;
}


int
f_1600_15024_15052(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 15024, 15052);
return 0;
}


int
f_1600_15203_15239(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.StopAllOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 15203, 15239);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,14844,15251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,14844,15251);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,15588,15701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,15634,15648);

f_1600_15634_15647(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,15664,15690);

f_1600_15664_15689(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,15588,15701);

int
f_1600_15634_15647(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 15634, 15647);
return 0;
}


int
f_1600_15664_15689(Microsoft.PowerShell.Commands.NewPSSessionCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 15664, 15689);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,15588,15701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,15588,15701);
}
		}

private void OnRunspacePSEventReceived(object sender, PSEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,15894,16073);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,15987,16062) || true) && (f_1600_15991_16002(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,15987,16062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,16029,16062);

f_1600_16029_16061(f_1600_16029_16040(this), e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,15987,16062);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,15894,16073);

System.Management.Automation.PSEventManager
f_1600_15991_16002(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Events ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 15991, 16002);
return return_v;
}


System.Management.Automation.PSEventManager
f_1600_16029_16040(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 16029, 16040);
return return_v;
}


int
f_1600_16029_16061(System.Management.Automation.PSEventManager
this_param,System.Management.Automation.PSEventArgs
forwardedEvent)
{
this_param.AddForwardedEvent( forwardedEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 16029, 16061);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,15894,16073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,15894,16073);
}
		}

private void HandleURIDirectionReported(object sender, RemoteDataEventArgs<Uri> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,16391,16822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,16506,16621);

string 
message = f_1600_16523_16620(f_1600_16541_16588(), f_1600_16590_16619(f_1600_16590_16604(eventArgs)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,16635,16768);

Action<Cmdlet> 
warningWriter = delegate (Cmdlet cmdlet)
            {
                cmdlet.WriteWarning(message);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,16782,16811);

f_1600_16782_16810(            _stream, warningWriter);
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,16391,16822);

string
f_1600_16541_16588()
{
var return_v = RemotingErrorIdStrings.URIRedirectWarningToHost;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 16541, 16588);
return return_v;
}


System.Uri
f_1600_16590_16604(System.Management.Automation.RemoteDataEventArgs<System.Uri>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 16590, 16604);
return return_v;
}


string
f_1600_16590_16619(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 16590, 16619);
return return_v;
}


string
f_1600_16523_16620(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 16523, 16620);
return return_v;
}


int
f_1600_16782_16810(System.Management.Automation.Internal.ObjectStream
this_param,System.Action<System.Management.Automation.Cmdlet>
value)
{
var return_v = this_param.Write( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 16782, 16810);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,16391,16822);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,16391,16822);
}
		}

private void HandleRunspaceStateChanged(object sender, OperationStateEventArgs stateEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,17136,27787);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17255,17377) || true) && (sender == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,17255,17377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17307,17362);

throw f_1600_17313_17361("sender");
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,17255,17377);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17393,17531) || true) && (stateEventArgs == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,17393,17531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17453,17516);

throw f_1600_17459_17515("stateEventArgs");
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,17393,17531);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17547,17671);

RunspaceStateEventArgs 
runspaceStateEventArgs =
f_1600_17620_17644(stateEventArgs)as RunspaceStateEventArgs
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17685,17756);

RunspaceStateInfo 
stateInfo = f_1600_17715_17755(runspaceStateEventArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17770,17808);

RunspaceState 
state = f_1600_17792_17807(stateInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17822,17888);

OpenRunspaceOperation 
operation = sender as OpenRunspaceOperation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,17902,17961);

RemoteRunspace 
remoteRunspace = f_1600_17934_17960(operation)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18094,18237) || true) && (remoteRunspace != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,18094,18237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18154,18222);

remoteRunspace.URIRedirectionReported -= HandleURIDirectionReported;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,18094,18237);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18253,18298);

PipelineWriter 
writer = f_1600_18277_18297(_stream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18312,18379);

Exception 
reason = f_1600_18331_18378(f_1600_18331_18371(runspaceStateEventArgs))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18395,27776);

switch (state)
            {

case RunspaceState.Opened:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,18395,27776);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18713,18774);

PSSession 
remoteRunspaceInfo = f_1600_18744_18773(remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18802,18850);

f_1600_18802_18849(f_1600_18802_18825(this), remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,18878,19056);

Action<Cmdlet> 
outputWriter = delegate (Cmdlet cmdlet)
                        {
                            cmdlet.WriteObject(remoteRunspaceInfo);
                        }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,19082,19211) || true) && (f_1600_19086_19099(writer))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,19082,19211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,19157,19184);

f_1600_19157_19183(                            writer, outputWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,19082,19211);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,19258,19264);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,18395,27776);

case RunspaceState.Broken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,18395,27776);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,19730,19844);

PSRemotingTransportException 
transException =
                            reason as PSRemotingTransportException
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,19870,19897);

string 
errorDetails = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,19923,19946);

int 
transErrorCode = 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,19972,22256) || true) && (transException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,19972,22256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,20056,20123);

OpenRunspaceOperation 
senderAsOp = sender as OpenRunspaceOperation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,20153,20195);

transErrorCode = f_1600_20170_20194(transException);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,20225,22229) || true) && (senderAsOp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,20225,22229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,20313,20383);

string 
host = f_1600_20327_20382(f_1600_20327_20369(f_1600_20327_20354(senderAsOp)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,20419,22198) || true) && (f_1600_20423_20447(transException)==
                                    System.Management.Automation.Remoting.Client.WSManNativeApi.ERROR_WSMAN_REDIRECT_REQUESTED)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,20419,22198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,20911,21384);

string 
message = f_1600_20928_21383(f_1600_21017_21062(), f_1600_21105_21127(transException), "MaximumConnectionRedirectionCount", Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet.DEFAULT_SESSION_OPTION, "AllowRedirection")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,21424,21467);

errorDetails = "[" + host + "] " + message;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,20419,22198);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,20419,22198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,21613,21646);

errorDetails = "[" + host + "] ";

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,21684,22163) || true) && (!f_1600_21689_21733(f_1600_21710_21732(transException)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,21684,22163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,21815,21854);

errorDetails += f_1600_21831_21853(transException);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,21684,22163);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,21684,22163);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,21936,22163) || true) && (!f_1600_21941_21994(f_1600_21962_21993(transException)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,21936,22163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,22076,22124);

errorDetails += f_1600_22092_22123(transException);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,21936,22163);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,21684,22163);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,20419,22198);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,20225,22229);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,19972,22256);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,22382,22475);

PSRemotingDataStructureException 
protoException = reason as PSRemotingDataStructureException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,22503,22996) || true) && (protoException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,22503,22996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,22587,22654);

OpenRunspaceOperation 
senderAsOp = sender as OpenRunspaceOperation
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,22686,22969) || true) && (senderAsOp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,22686,22969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,22774,22844);

string 
host = f_1600_22788_22843(f_1600_22788_22830(f_1600_22788_22815(senderAsOp)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,22880,22938);

errorDetails = "[" + host + "] " + f_1600_22915_22937(protoException);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,22686,22969);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,22503,22996);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,23024,23236) || true) && (reason == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,23024,23236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,23100,23209);

reason = f_1600_23109_23208(f_1600_23130_23207(this, f_1600_23146_23199(), state));
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,23024,23236);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,23264,23439);

string 
fullyQualifiedErrorId = f_1600_23295_23438(transErrorCode, _defaultFQEID)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,23467,23788) || true) && (WSManNativeApi.ERROR_WSMAN_NO_LOGON_SESSION_EXIST == transErrorCode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,23467,23788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,23596,23761);

errorDetails += f_1600_23612_23638()+ f_1600_23641_23760(f_1600_23655_23702(), f_1600_23704_23759());
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,23467,23788);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,23816,24087);

ErrorRecord 
errorRecord = f_1600_23842_24086(reason, remoteRunspace, fullyQualifiedErrorId, ErrorCategory.OpenError, null, null, null, null, null, errorDetails, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,24115,25401);

Action<Cmdlet> 
errorWriter = delegate (Cmdlet cmdlet)
                        {
                            //
                            // In case of PSDirectException, we should output the precise error message
                            // in inner exception instead of the generic one in outer exception.
                            //
                            if ((errorRecord.Exception != null) &&
                                (errorRecord.Exception.InnerException != null))
                            {
                                PSDirectException ex = errorRecord.Exception.InnerException as PSDirectException;
                                if (ex != null)
                                {
                                    errorRecord = new ErrorRecord(errorRecord.Exception.InnerException,
                                                                  errorRecord.FullyQualifiedErrorId,
                                                                  errorRecord.CategoryInfo.Category,
                                                                  errorRecord.TargetObject);
                                }
                            }

                            cmdlet.WriteError(errorRecord);
                        }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,25427,25555) || true) && (f_1600_25431_25444(writer))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,25427,25555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,25502,25528);

f_1600_25502_25527(                            writer, errorWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,25427,25555);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,25583,25614);

f_1600_25583_25613(
                        _toDispose, remoteRunspace);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,25661,25667);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,18395,27776);

case RunspaceState.Closed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,18395,27776);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,25997,26162);

Uri 
connectionUri = f_1600_26017_26161(f_1600_26079_26108(remoteRunspace), "ConnectionUri", null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,26188,26440);

string 
message =
f_1600_26234_26439(this, f_1600_26245_26288(), (DynAbs.Tracing.TraceSender.Conditional_F1(1600, 26331, 26354)||((                                        (connectionUri != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1600, 26398, 26423))||DynAbs.Tracing.TraceSender.Conditional_F3(1600, 26426, 26438)))?f_1600_26398_26423(connectionUri):string.Empty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,26468,26637);

Action<Cmdlet> 
verboseWriter = delegate (Cmdlet cmdlet)
                        {
                            cmdlet.WriteVerbose(message);
                        }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,26663,26793) || true) && (f_1600_26667_26680(writer))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,26663,26793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,26738,26766);

f_1600_26738_26765(                            writer, verboseWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,26663,26793);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,27033,27708) || true) && (reason != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,27033,27708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,27109,27298);

ErrorRecord 
errorRecord = f_1600_27135_27297(reason, "PSSessionStateClosed", ErrorCategory.OpenError, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,27330,27511);

Action<Cmdlet> 
errorWriter = delegate (Cmdlet cmdlet)
                            {
                                cmdlet.WriteError(errorRecord);
                            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,27541,27681) || true) && (f_1600_27545_27558(writer))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,27541,27681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,27624,27650);

f_1600_27624_27649(                                writer, errorWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,27541,27681);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,27033,27708);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1600,27755,27761);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,18395,27776);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,17136,27787);

System.Management.Automation.PSArgumentNullException
f_1600_17313_17361(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 17313, 17361);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1600_17459_17515(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 17459, 17515);
return return_v;
}


System.EventArgs
f_1600_17620_17644(System.Management.Automation.Remoting.OperationStateEventArgs
this_param)
{
var return_v = this_param.BaseEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 17620, 17644);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1600_17715_17755(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 17715, 17755);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1600_17792_17807(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 17792, 17807);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_17934_17960(Microsoft.PowerShell.Commands.OpenRunspaceOperation
this_param)
{
var return_v = this_param.OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 17934, 17960);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1600_18277_18297(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 18277, 18297);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1600_18331_18371(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 18331, 18371);
return return_v;
}


System.Exception
f_1600_18331_18378(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 18331, 18378);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1600_18744_18773(System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = new System.Management.Automation.Runspaces.PSSession( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 18744, 18773);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1600_18802_18825(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 18802, 18825);
return return_v;
}


int
f_1600_18802_18849(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 18802, 18849);
return 0;
}


bool
f_1600_19086_19099(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 19086, 19099);
return return_v;
}


int
f_1600_19157_19183(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 19157, 19183);
return return_v;
}


int
f_1600_20170_20194(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 20170, 20194);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_20327_20354(Microsoft.PowerShell.Commands.OpenRunspaceOperation
this_param)
{
var return_v = this_param.OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 20327, 20354);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_20327_20369(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 20327, 20369);
return return_v;
}


string
f_1600_20327_20382(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 20327, 20382);
return return_v;
}


int
f_1600_20423_20447(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 20423, 20447);
return return_v;
}


string
f_1600_21017_21062()
{
var return_v =                                         RemotingErrorIdStrings.URIRedirectionReported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 21017, 21062);
return return_v;
}


string
f_1600_21105_21127(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 21105, 21127);
return return_v;
}


string
f_1600_20928_21383(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 20928, 21383);
return return_v;
}


string
f_1600_21710_21732(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 21710, 21732);
return return_v;
}


bool
f_1600_21689_21733(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 21689, 21733);
return return_v;
}


string
f_1600_21831_21853(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 21831, 21853);
return return_v;
}


string
f_1600_21962_21993(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.TransportMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 21962, 21993);
return return_v;
}


bool
f_1600_21941_21994(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 21941, 21994);
return return_v;
}


string
f_1600_22092_22123(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.TransportMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 22092, 22123);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_22788_22815(Microsoft.PowerShell.Commands.OpenRunspaceOperation
this_param)
{
var return_v = this_param.OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 22788, 22815);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_22788_22830(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 22788, 22830);
return return_v;
}


string
f_1600_22788_22843(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 22788, 22843);
return return_v;
}


string
f_1600_22915_22937(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 22915, 22937);
return return_v;
}


string
f_1600_23146_23199()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceOpenUnknownState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 23146, 23199);
return return_v;
}


string
f_1600_23130_23207(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 23130, 23207);
return return_v;
}


System.Management.Automation.RuntimeException
f_1600_23109_23208(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 23109, 23208);
return return_v;
}


string
f_1600_23295_23438(int
transportErrorCode,string
defaultFQEID)
{
var return_v = WSManTransportManagerUtils.GetFQEIDFromTransportError( transportErrorCode, defaultFQEID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 23295, 23438);
return return_v;
}


string
f_1600_23612_23638()
{
var return_v = System.Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 23612, 23638);
return return_v;
}


System.Globalization.CultureInfo
f_1600_23655_23702()
{
var return_v = System.Globalization.CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 23655, 23702);
return return_v;
}


string
f_1600_23704_23759()
{
var return_v = RemotingErrorIdStrings.RemotingErrorNoLogonSessionExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 23704, 23759);
return return_v;
}


string
f_1600_23641_23760(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 23641, 23760);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_23842_24086(System.Exception
exception,System.Management.Automation.RemoteRunspace
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
var return_v = new System.Management.Automation.ErrorRecord( exception, (object)targetObject, fullyQualifiedErrorId, errorCategory, errorCategory_Activity, errorCategory_Reason, errorCategory_TargetName, errorCategory_TargetType, errorCategory_Message, errorDetails_Message, errorDetails_RecommendedAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 23842, 24086);
return return_v;
}


bool
f_1600_25431_25444(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 25431, 25444);
return return_v;
}


int
f_1600_25502_25527(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 25502, 25527);
return return_v;
}


int
f_1600_25583_25613(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.RemoteRunspace
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 25583, 25613);
return 0;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_26079_26108(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 26079, 26108);
return return_v;
}


System.Uri
f_1600_26017_26161(System.Management.Automation.Runspaces.RunspaceConnectionInfo
rsCI,string
property,System.Uri
defaultValue)
{
var return_v = WSManConnectionInfo.ExtractPropertyAsWsManConnectionInfo<Uri>( rsCI, property, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 26017, 26161);
return return_v;
}


string
f_1600_26245_26288()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceClosed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 26245, 26288);
return return_v;
}


string
f_1600_26398_26423(System.Uri
this_param)
{
var return_v = this_param.AbsoluteUri ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 26398, 26423);
return return_v;
}


string
f_1600_26234_26439(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 26234, 26439);
return return_v;
}


bool
f_1600_26667_26680(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 26667, 26680);
return return_v;
}


int
f_1600_26738_26765(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 26738, 26765);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_27135_27297(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.RemoteRunspace
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 27135, 27297);
return return_v;
}


bool
f_1600_27545_27558(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 27545, 27558);
return return_v;
}


int
f_1600_27624_27649(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 27624, 27649);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,17136,27787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,17136,27787);
}
		}

[SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        private List<RemoteRunspace> CreateRunspacesWhenRunspaceParameterSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,28032,33688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,28228,28294);

List<RemoteRunspace> 
remoteRunspaces = f_1600_28267_28293()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,28504,28539);

f_1600_28504_28538(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,28555,28571);

int 
rsIndex = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,28585,33638);
foreach(PSSession remoteRunspaceInfo in f_1600_28626_28646_I(_remoteRunspaceInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,28585,33638);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,28680,33593) || true) && (remoteRunspaceInfo == null ||(DynAbs.Tracing.TraceSender.Expression_False(1600, 28684, 28749)||f_1600_28714_28741(remoteRunspaceInfo)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,28680,33593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,28791,28987);

f_1600_28791_28986(this, f_1600_28813_28985(f_1600_28855_28893("PSSession"), "PSSessionArgumentNull", ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,28680,33593);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,28680,33593);
                    // clone the object based on what's specified in the input parameter
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29211,29287);

RemoteRunspace 
remoteRunspace = (RemoteRunspace)f_1600_29259_29286(remoteRunspaceInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29313,29361);

RunspaceConnectionInfo 
newConnectionInfo = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29389,31916) || true) && (f_1600_29393_29422(remoteRunspace)is VMConnectionInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,29389,31916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29500,29565);

newConnectionInfo = f_1600_29520_29564(f_1600_29520_29549(remoteRunspace));
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,29389,31916);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,29389,31916);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29623,31916) || true) && (f_1600_29627_29656(remoteRunspace)is ContainerConnectionInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,29623,31916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29741,29866);

ContainerConnectionInfo 
newContainerConnectionInfo = f_1600_29794_29838(f_1600_29794_29823(remoteRunspace))as ContainerConnectionInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29896,29948);

f_1600_29896_29947(                            newContainerConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,29978,30025);

newConnectionInfo = newContainerConnectionInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,29623,31916);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,29623,31916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,30182,30285);

WSManConnectionInfo 
originalWSManConnectionInfo = f_1600_30232_30261(remoteRunspace)as WSManConnectionInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,30315,30365);

WSManConnectionInfo 
newWSManConnectionInfo = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,30397,31889) || true) && (originalWSManConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,30397,31889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,30502,30562);

newWSManConnectionInfo = f_1600_30527_30561(originalWSManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,30596,30724);

newWSManConnectionInfo.EnableNetworkAccess = (DynAbs.Tracing.TraceSender.Conditional_F1(1600, 30641, 30708)||(((f_1600_30642_30684(newWSManConnectionInfo)||(DynAbs.Tracing.TraceSender.Expression_False(1600, 30642, 30707)||f_1600_30688_30707())) &&DynAbs.Tracing.TraceSender.Conditional_F2(1600, 30711, 30715))||DynAbs.Tracing.TraceSender.Conditional_F3(1600, 30718, 30723)))?true :false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,30758,30801);

newConnectionInfo = newWSManConnectionInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,30397,31889);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,30397,31889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,30931,31112);

Uri 
connectionUri = f_1600_30951_31111(f_1600_31013_31042(remoteRunspace), "ConnectionUri", null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,31146,31323);

string 
shellUri = f_1600_31164_31322(f_1600_31229_31258(remoteRunspace), "ShellUri", string.Empty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,31357,31603);

newWSManConnectionInfo = f_1600_31382_31602(connectionUri, shellUri, f_1600_31561_31601(f_1600_31561_31590(remoteRunspace)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,31637,31682);

f_1600_31637_31681(this, newWSManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,31716,31781);

newWSManConnectionInfo.EnableNetworkAccess = f_1600_31761_31780();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,31815,31858);

newConnectionInfo = newWSManConnectionInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,30397,31889);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,29623,31916);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,29389,31916);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,31944,32036);

RemoteRunspacePoolInternal 
rrsPool = f_1600_31981_32035(f_1600_31981_32008(remoteRunspace))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,32062,32089);

TypeTable 
typeTable = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,32115,32459) || true) && ((rrsPool != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1600, 32119, 32207)&&                            (f_1600_32170_32198(rrsPool)!= null) )&&(DynAbs.Tracing.TraceSender.Expression_True(1600, 32119, 32295)&&                            (f_1600_32241_32286(f_1600_32241_32269(rrsPool))!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,32115,32459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,32353,32432);

typeTable = f_1600_32365_32431(f_1600_32365_32421(f_1600_32365_32410(f_1600_32365_32393(rrsPool))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,32115,32459);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,32560,32569);

int 
rsId
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,32595,32646);

string 
rsName = f_1600_32611_32645(this, rsIndex, out rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,32672,32881);

RemoteRunspace 
newRemoteRunspace = f_1600_32707_32880(typeTable, newConnectionInfo, f_1600_32786_32795(this), f_1600_32797_32836(f_1600_32797_32815(this)), rsName, rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,32909,32948);

f_1600_32909_32947(
                        remoteRunspaces, newRemoteRunspace);
                    }
                    catch (UriFormatException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,32993,33574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,33070,33115);

PipelineWriter 
writer = f_1600_33094_33114(_stream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,33143,33302);

ErrorRecord 
errorRecord = f_1600_33169_33301(e, "CreateRemoteRunspaceFailed", ErrorCategory.InvalidArgument, remoteRunspaceInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,33330,33499);

Action<Cmdlet> 
errorWriter = delegate (Cmdlet cmdlet)
                        {
                            cmdlet.WriteError(errorRecord);
                        }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,33525,33551);

f_1600_33525_33550(                        writer, errorWriter);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,32993,33574);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,28680,33593);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,33613,33623);

++rsIndex;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,28585,33638);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,5054);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,5054);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,33654,33677);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,28032,33688);

System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_28267_28293()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 28267, 28293);
return return_v;
}


int
f_1600_28504_28538(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
this_param.ValidateRemoteRunspacesSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 28504, 28538);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1600_28714_28741(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 28714, 28741);
return return_v;
}


System.ArgumentNullException
f_1600_28855_28893(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 28855, 28893);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_28813_28985(System.ArgumentNullException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 28813, 28985);
return return_v;
}


int
f_1600_28791_28986(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 28791, 28986);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1600_29259_29286(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 29259, 29286);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_29393_29422(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 29393, 29422);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_29520_29549(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 29520, 29549);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_29520_29564(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.InternalCopy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 29520, 29564);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_29627_29656(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 29627, 29656);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_29794_29823(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 29794, 29823);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_29794_29838(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.InternalCopy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 29794, 29838);
return return_v;
}


int
f_1600_29896_29947(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
this_param.CreateContainerProcess();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 29896, 29947);
return 0;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_30232_30261(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 30232, 30261);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1600_30527_30561(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Copy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 30527, 30561);
return return_v;
}


bool
f_1600_30642_30684(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.EnableNetworkAccess ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 30642, 30684);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1600_30688_30707()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 30688, 30707);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_31013_31042(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 31013, 31042);
return return_v;
}


System.Uri
f_1600_30951_31111(System.Management.Automation.Runspaces.RunspaceConnectionInfo
rsCI,string
property,System.Uri
defaultValue)
{
var return_v = WSManConnectionInfo.ExtractPropertyAsWsManConnectionInfo<Uri>( rsCI, property, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 30951, 31111);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_31229_31258(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 31229, 31258);
return return_v;
}


string
f_1600_31164_31322(System.Management.Automation.Runspaces.RunspaceConnectionInfo
rsCI,string
property,string
defaultValue)
{
var return_v = WSManConnectionInfo.ExtractPropertyAsWsManConnectionInfo<string>( rsCI, property, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 31164, 31322);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1600_31561_31590(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 31561, 31590);
return return_v;
}


System.Management.Automation.PSCredential
f_1600_31561_31601(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 31561, 31601);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1600_31382_31602(System.Uri
uri,string
shellUri,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo( uri, shellUri, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 31382, 31602);
return return_v;
}


int
f_1600_31637_31681(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 31637, 31681);
return 0;
}


System.Management.Automation.SwitchParameter
f_1600_31761_31780()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 31761, 31780);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1600_31981_32008(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 31981, 32008);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1600_31981_32035(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 31981, 32035);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1600_32170_32198(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32170, 32198);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1600_32241_32269(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32241, 32269);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
f_1600_32241_32286(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32241, 32286);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1600_32365_32393(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32365, 32393);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
f_1600_32365_32410(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32365, 32410);
return return_v;
}


System.Management.Automation.Remoting.Fragmentor
f_1600_32365_32421(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
var return_v = this_param.Fragmentor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32365, 32421);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_32365_32431(System.Management.Automation.Remoting.Fragmentor
this_param)
{
var return_v = this_param.TypeTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32365, 32431);
return return_v;
}


string
f_1600_32611_32645(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 32611, 32645);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_32786_32795(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32786, 32795);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1600_32797_32815(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32797, 32815);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1600_32797_32836(System.Management.Automation.Remoting.PSSessionOption
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 32797, 32836);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_32707_32880(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 32707, 32880);
return return_v;
}


int
f_1600_32909_32947(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.RemoteRunspace
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 32909, 32947);
return 0;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1600_33094_33114(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 33094, 33114);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_33169_33301(System.UriFormatException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 33169, 33301);
return return_v;
}


int
f_1600_33525_33550(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 33525, 33550);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1600_28626_28646_I(System.Management.Automation.Runspaces.PSSession[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 28626, 28646);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,28032,33688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,28032,33688);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<RemoteRunspace> CreateRunspacesWhenUriParameterSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,33846,36356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,33942,34008);

List<RemoteRunspace> 
remoteRunspaces = f_1600_33981_34007()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34129,34134);

            // parse the Uri to obtain information about the runspace
            // required
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34120,36306) || true) && (i < f_1600_34140_34160(f_1600_34140_34153()))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34162,34165)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1600,34120,36306))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,34120,36306);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34243,34306);

WSManConnectionInfo 
connectionInfo = f_1600_34280_34305()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34328,34376);

connectionInfo.ConnectionUri = f_1600_34359_34372()[i];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34398,34442);

connectionInfo.ShellUri = f_1600_34424_34441();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34464,34768) || true) && (f_1600_34468_34489()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,34464,34768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34547,34608);

connectionInfo.CertificateThumbprint = f_1600_34586_34607();
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,34464,34768);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,34464,34768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34706,34745);

connectionInfo.Credential = f_1600_34734_34744();
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,34464,34768);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34792,34848);

connectionInfo.AuthenticationMechanism = f_1600_34833_34847();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34870,34907);

f_1600_34870_34906(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,34931,34988);

connectionInfo.EnableNetworkAccess = f_1600_34968_34987();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,35081,35090);

int 
rsId
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,35112,35157);

string 
rsName = f_1600_35128_35156(this, i, out rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,35179,35408);

RemoteRunspace 
remoteRunspace = f_1600_35211_35407(f_1600_35256_35299(), connectionInfo, f_1600_35317_35326(this), f_1600_35353_35392(f_1600_35353_35371(this)), rsName, rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,35432,35547);

f_1600_35432_35546(remoteRunspace != null, "RemoteRunspace object created using URI is null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,35571,35607);

f_1600_35571_35606(
                    remoteRunspaces, remoteRunspace);
                }
                catch (UriFormatException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,35644,35790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,35713,35771);

f_1600_35713_35770(this, e, f_1600_35753_35766()[i]);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,35644,35790);
                }
                catch (InvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,35808,35961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,35884,35942);

f_1600_35884_35941(this, e, f_1600_35924_35937()[i]);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,35808,35961);
                }
                catch (ArgumentException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,35979,36124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36047,36105);

f_1600_36047_36104(this, e, f_1600_36087_36100()[i]);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,35979,36124);
                }
                catch (NotSupportedException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,36142,36291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36214,36272);

f_1600_36214_36271(this, e, f_1600_36254_36267()[i]);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,36142,36291);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,2187);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,2187);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36322,36345);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,33846,36356);

System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_33981_34007()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 33981, 34007);
return return_v;
}


System.Uri[]
f_1600_34140_34153()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34140, 34153);
return return_v;
}


int
f_1600_34140_34160(System.Uri[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34140, 34160);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1600_34280_34305()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 34280, 34305);
return return_v;
}


System.Uri[]
f_1600_34359_34372()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34359, 34372);
return return_v;
}


string
f_1600_34424_34441()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34424, 34441);
return return_v;
}


string
f_1600_34468_34489()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34468, 34489);
return return_v;
}


string
f_1600_34586_34607()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34586, 34607);
return return_v;
}


System.Management.Automation.PSCredential
f_1600_34734_34744()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34734, 34744);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1600_34833_34847()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34833, 34847);
return return_v;
}


int
f_1600_34870_34906(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 34870, 34906);
return 0;
}


System.Management.Automation.SwitchParameter
f_1600_34968_34987()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 34968, 34987);
return return_v;
}


string
f_1600_35128_35156(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 35128, 35156);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_35256_35299()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 35256, 35299);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_35317_35326(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 35317, 35326);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1600_35353_35371(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 35353, 35371);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1600_35353_35392(System.Management.Automation.Remoting.PSSessionOption
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 35353, 35392);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_35211_35407(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 35211, 35407);
return return_v;
}


int
f_1600_35432_35546(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 35432, 35546);
return 0;
}


int
f_1600_35571_35606(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.RemoteRunspace
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 35571, 35606);
return 0;
}


System.Uri[]
f_1600_35753_35766()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 35753, 35766);
return return_v;
}


int
f_1600_35713_35770(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.UriFormatException
e,System.Uri
uri)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)e, uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 35713, 35770);
return 0;
}


System.Uri[]
f_1600_35924_35937()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 35924, 35937);
return return_v;
}


int
f_1600_35884_35941(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.InvalidOperationException
e,System.Uri
uri)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)e, uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 35884, 35941);
return 0;
}


System.Uri[]
f_1600_36087_36100()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 36087, 36100);
return return_v;
}


int
f_1600_36047_36104(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.ArgumentException
e,System.Uri
uri)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)e, uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 36047, 36104);
return 0;
}


System.Uri[]
f_1600_36254_36267()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 36254, 36267);
return return_v;
}


int
f_1600_36214_36271(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.NotSupportedException
e,System.Uri
uri)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)e, uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 36214, 36271);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,33846,36356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,33846,36356);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<RemoteRunspace> CreateRunspacesWhenComputerNameParameterSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,36523,39325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36628,36711);

List<RemoteRunspace> 
remoteRunspaces =
f_1600_36684_36710()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36773,36804);

string[] 
resolvedComputerNames
=default(string[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36820,36882);

f_1600_36820_36881(this, f_1600_36841_36853(), out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36898,36942);

f_1600_36898_36941(this, resolvedComputerNames);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37003,37008);

            // Do for each machine
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,36994,39275) || true) && (i < f_1600_37014_37042(resolvedComputerNames))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37044,37047)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1600,36994,39275))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,36994,39275);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37125,37167);

WSManConnectionInfo 
connectionInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37189,37232);

connectionInfo = f_1600_37206_37231();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37254,37354);

string 
scheme = (DynAbs.Tracing.TraceSender.Conditional_F1(1600, 37270, 37286)||((f_1600_37270_37276().IsPresent &&DynAbs.Tracing.TraceSender.Conditional_F2(1600, 37289, 37320))||DynAbs.Tracing.TraceSender.Conditional_F3(1600, 37323, 37353)))?WSManConnectionInfo.HttpsScheme :WSManConnectionInfo.HttpScheme
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37376,37431);

connectionInfo.ComputerName = resolvedComputerNames[i];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37453,37480);

connectionInfo.Port = f_1600_37475_37479();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37502,37543);

connectionInfo.AppName = f_1600_37527_37542();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37565,37609);

connectionInfo.ShellUri = f_1600_37591_37608();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37631,37662);

connectionInfo.Scheme = scheme;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37684,37988) || true) && (f_1600_37688_37709()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,37684,37988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37767,37828);

connectionInfo.CertificateThumbprint = f_1600_37806_37827();
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,37684,37988);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,37684,37988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,37926,37965);

connectionInfo.Credential = f_1600_37954_37964();
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,37684,37988);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38012,38068);

connectionInfo.AuthenticationMechanism = f_1600_38053_38067();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38090,38127);

f_1600_38090_38126(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38151,38208);

connectionInfo.EnableNetworkAccess = f_1600_38188_38207();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38301,38310);

int 
rsId
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38332,38377);

string 
rsName = f_1600_38348_38376(this, i, out rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38399,38622);

RemoteRunspace 
runspace = f_1600_38425_38621(f_1600_38470_38513(), connectionInfo, f_1600_38531_38540(this), f_1600_38567_38606(f_1600_38567_38585(this)), rsName, rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38646,38676);

f_1600_38646_38675(
                    remoteRunspaces, runspace);
                }
                catch (UriFormatException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,38713,39260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38782,38827);

PipelineWriter 
writer = f_1600_38806_38826(_stream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,38851,39012);

ErrorRecord 
errorRecord = f_1600_38877_39011(e, "CreateRemoteRunspaceFailed", ErrorCategory.InvalidArgument, resolvedComputerNames[i])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39036,39193);

Action<Cmdlet> 
errorWriter = delegate (Cmdlet cmdlet)
                    {
                        cmdlet.WriteError(errorRecord);
                    }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39215,39241);

f_1600_39215_39240(                    writer, errorWriter);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,38713,39260);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,2282);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,2282);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39291,39314);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,36523,39325);

System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_36684_36710()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 36684, 36710);
return return_v;
}


string[]
f_1600_36841_36853()
{
var return_v = ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 36841, 36853);
return return_v;
}


int
f_1600_36820_36881(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string[]
computerNames,out string[]
resolvedComputerNames)
{
this_param.ResolveComputerNames( computerNames, out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 36820, 36881);
return 0;
}


int
f_1600_36898_36941(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string[]
computerNames)
{
this_param.ValidateComputerName( computerNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 36898, 36941);
return 0;
}


int
f_1600_37014_37042(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37014, 37042);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1600_37206_37231()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 37206, 37231);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1600_37270_37276()
{
var return_v = UseSSL;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37270, 37276);
return return_v;
}


int
f_1600_37475_37479()
{
var return_v = Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37475, 37479);
return return_v;
}


string
f_1600_37527_37542()
{
var return_v = ApplicationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37527, 37542);
return return_v;
}


string
f_1600_37591_37608()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37591, 37608);
return return_v;
}


string
f_1600_37688_37709()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37688, 37709);
return return_v;
}


string
f_1600_37806_37827()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37806, 37827);
return return_v;
}


System.Management.Automation.PSCredential
f_1600_37954_37964()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 37954, 37964);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1600_38053_38067()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 38053, 38067);
return return_v;
}


int
f_1600_38090_38126(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 38090, 38126);
return 0;
}


System.Management.Automation.SwitchParameter
f_1600_38188_38207()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 38188, 38207);
return return_v;
}


string
f_1600_38348_38376(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 38348, 38376);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_38470_38513()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 38470, 38513);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_38531_38540(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 38531, 38540);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1600_38567_38585(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 38567, 38585);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1600_38567_38606(System.Management.Automation.Remoting.PSSessionOption
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 38567, 38606);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_38425_38621(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 38425, 38621);
return return_v;
}


int
f_1600_38646_38675(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.RemoteRunspace
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 38646, 38675);
return 0;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1600_38806_38826(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 38806, 38826);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_38877_39011(System.UriFormatException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 38877, 39011);
return return_v;
}


int
f_1600_39215_39240(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 39215, 39240);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,36523,39325);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,36523,39325);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<RemoteRunspace> CreateRunspacesWhenVMParameterSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,39494,45245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39589,39608);

int 
inputArraySize
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39622,39645);

bool 
isVMIdSet = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39659,39669);

int 
index
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39683,39698);

string 
command
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39712,39741);

Collection<PSObject> 
results
=default(Collection<PSObject>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39755,39821);

List<RemoteRunspace> 
remoteRunspaces = f_1600_39794_39820()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39837,40494) || true) && (f_1600_39841_39857()== PSExecutionCmdlet.VMIdParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,39837,40494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39929,39946);

isVMIdSet = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,39964,39998);

inputArraySize = f_1600_39981_39997(f_1600_39981_39990(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40016,40057);

this.VMName = new string[inputArraySize];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40075,40107);

command = "Get-VM -Id $args[0]";
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,39837,40494);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,39837,40494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40173,40319);

f_1600_40173_40318((f_1600_40185_40201()== PSExecutionCmdlet.VMNameParameterSet), "Expected ParameterSetName == VMId or VMName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40339,40375);

inputArraySize = f_1600_40356_40374(f_1600_40356_40367(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40393,40430);

this.VMId = new Guid[inputArraySize];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40448,40479);

command = "Get-VM -Name $args";
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,39837,40494);
}
try {
            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40515,40524)
,index = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40510,45143) || true) && (index < inputArraySize)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40550,40557)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(1600,40510,45143))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,40510,45143);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40635,40838);

results = f_1600_40645_40837(f_1600_40645_40663(this), command, false, PipelineResultTypes.None, null, (DynAbs.Tracing.TraceSender.Conditional_F1(1600, 40776, 40785)||((                        isVMIdSet &&DynAbs.Tracing.TraceSender.Conditional_F2(1600, 40788, 40815))||DynAbs.Tracing.TraceSender.Conditional_F3(1600, 40818, 40836)))?f_1600_40788_40797(this)[index].ToString():f_1600_40818_40829(this)[index]);
                }
                catch (CommandNotFoundException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,40875,41346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,40948,41291);

f_1600_40948_41290(this, f_1600_40996_41289(f_1600_41042_41112(f_1600_41064_41111()), f_1600_41143_41196(                            PSRemotingErrorId.HyperVModuleNotAvailable), ErrorCategory.NotInstalled, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,41315,41327);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,40875,41346);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,41407,43745) || true) && (f_1600_41411_41424(results)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,41407,43745);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,41471,42756) || true) && (isVMIdSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,41471,42756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,41534,41568);

f_1600_41534_41545(this)[index] = string.Empty;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,41596,42054);

f_1600_41596_42053(this, f_1600_41637_42052(f_1600_41687_41864(f_1600_41709_41863(this, f_1600_41720_41763(), f_1600_41831_41840(this)[index].ToString(null))), f_1600_41899_41948(                                PSRemotingErrorId.InvalidVMIdNotSingle), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,42082,42091);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,41471,42756);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,41471,42756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,42189,42219);

f_1600_42189_42198(this)[index] = Guid.Empty;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,42247,42696);

f_1600_42247_42695(this, f_1600_42288_42694(f_1600_42338_42504(f_1600_42360_42503(this, f_1600_42371_42416(), f_1600_42484_42495(this)[index])), f_1600_42539_42590(                                PSRemotingErrorId.InvalidVMNameNotSingle), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,42724,42733);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,41471,42756);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,41407,43745);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,41407,43745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,42838,42899);

f_1600_42838_42847(this)[index] = (Guid)f_1600_42863_42898(f_1600_42863_42892(f_1600_42863_42884(f_1600_42863_42873(results, 0)), "VMId"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,42921,42988);

f_1600_42921_42932(this)[index] = (string)f_1600_42950_42987(f_1600_42950_42981(f_1600_42950_42971(f_1600_42950_42960(results, 0)), "VMName"));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,43115,43726) || true) && ((VMState)f_1600_43128_43164(f_1600_43128_43158(f_1600_43128_43149(f_1600_43128_43138(results, 0)), "State"))!= VMState.Running)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,43115,43726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,43233,43666);

f_1600_43233_43665(this, f_1600_43274_43664(f_1600_43324_43482(f_1600_43346_43481(this, f_1600_43357_43394(), f_1600_43462_43473(this)[index])), f_1600_43517_43560(                                PSRemotingErrorId.InvalidVMState), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,43694,43703);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,43115,43726);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,41407,43745);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,43829,43860);

RemoteRunspace 
runspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,43878,43910);

VMConnectionInfo 
connectionInfo
=default(VMConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,43928,43937);

int 
rsId
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,43955,44004);

string 
rsName = f_1600_43971_44003(this, index, out rsId)
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,44068,44185);

connectionInfo = f_1600_44085_44184(f_1600_44106_44121(this), f_1600_44123_44132(this)[index], f_1600_44141_44152(this)[index], f_1600_44161_44183(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,44209,44356);

runspace = f_1600_44220_44355(f_1600_44239_44282(), connectionInfo, f_1600_44325_44334(this), null, rsName, rsId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,44380,44410);

f_1600_44380_44409(
                    remoteRunspaces, runspace);
                }
                catch (InvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,44447,44783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,44523,44716);

ErrorRecord 
errorRecord = f_1600_44549_44715(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,44740,44764);

f_1600_44740_44763(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,44447,44783);
                }
                catch (ArgumentException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,44801,45128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,44869,45061);

ErrorRecord 
errorRecord = f_1600_44895_45060(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45085,45109);

f_1600_45085_45108(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,44801,45128);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,4634);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,4634);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45159,45195);

ResolvedComputerNames = f_1600_45183_45194(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45211,45234);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,39494,45245);

System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_39794_39820()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 39794, 39820);
return return_v;
}


string
f_1600_39841_39857()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 39841, 39857);
return return_v;
}


System.Guid[]
f_1600_39981_39990(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 39981, 39990);
return return_v;
}


int
f_1600_39981_39997(System.Guid[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 39981, 39997);
return return_v;
}


string
f_1600_40185_40201()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 40185, 40201);
return return_v;
}


int
f_1600_40173_40318(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 40173, 40318);
return 0;
}


string[]
f_1600_40356_40367(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 40356, 40367);
return return_v;
}


int
f_1600_40356_40374(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 40356, 40374);
return return_v;
}


System.Management.Automation.CommandInvocationIntrinsics
f_1600_40645_40663(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.InvokeCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 40645, 40663);
return return_v;
}


System.Guid[]
f_1600_40788_40797(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 40788, 40797);
return return_v;
}


string[]
f_1600_40818_40829(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 40818, 40829);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1600_40645_40837(System.Management.Automation.CommandInvocationIntrinsics
this_param,string
script,bool
useNewScope,System.Management.Automation.Runspaces.PipelineResultTypes
writeToPipeline,System.Collections.IList
input,params object[]
args)
{
var return_v = this_param.InvokeScript( script, useNewScope, writeToPipeline, input, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 40645, 40837);
return return_v;
}


string
f_1600_41064_41111()
{
var return_v = RemotingErrorIdStrings.HyperVModuleNotAvailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 41064, 41111);
return return_v;
}


System.ArgumentException
f_1600_41042_41112(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 41042, 41112);
return return_v;
}


string
f_1600_41143_41196(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 41143, 41196);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_40996_41289(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 40996, 41289);
return return_v;
}


int
f_1600_40948_41290(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 40948, 41290);
return 0;
}


int
f_1600_41411_41424(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 41411, 41424);
return return_v;
}


string[]
f_1600_41534_41545(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 41534, 41545);
return return_v;
}


string
f_1600_41720_41763()
{
var return_v = RemotingErrorIdStrings.InvalidVMIdNotSingle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 41720, 41763);
return return_v;
}


System.Guid[]
f_1600_41831_41840(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 41831, 41840);
return return_v;
}


string
f_1600_41709_41863(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 41709, 41863);
return return_v;
}


System.ArgumentException
f_1600_41687_41864(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 41687, 41864);
return return_v;
}


string
f_1600_41899_41948(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 41899, 41948);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_41637_42052(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 41637, 42052);
return return_v;
}


int
f_1600_41596_42053(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 41596, 42053);
return 0;
}


System.Guid[]
f_1600_42189_42198(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42189, 42198);
return return_v;
}


string
f_1600_42371_42416()
{
var return_v = RemotingErrorIdStrings.InvalidVMNameNotSingle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42371, 42416);
return return_v;
}


string[]
f_1600_42484_42495(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42484, 42495);
return return_v;
}


string
f_1600_42360_42503(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 42360, 42503);
return return_v;
}


System.ArgumentException
f_1600_42338_42504(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 42338, 42504);
return return_v;
}


string
f_1600_42539_42590(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 42539, 42590);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_42288_42694(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 42288, 42694);
return return_v;
}


int
f_1600_42247_42695(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 42247, 42695);
return 0;
}


System.Guid[]
f_1600_42838_42847(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42838, 42847);
return return_v;
}


System.Management.Automation.PSObject
f_1600_42863_42873(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42863, 42873);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1600_42863_42884(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42863, 42884);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1600_42863_42892(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42863, 42892);
return return_v;
}


object
f_1600_42863_42898(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42863, 42898);
return return_v;
}


string[]
f_1600_42921_42932(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42921, 42932);
return return_v;
}


System.Management.Automation.PSObject
f_1600_42950_42960(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42950, 42960);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1600_42950_42971(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42950, 42971);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1600_42950_42981(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42950, 42981);
return return_v;
}


object
f_1600_42950_42987(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 42950, 42987);
return return_v;
}


System.Management.Automation.PSObject
f_1600_43128_43138(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 43128, 43138);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1600_43128_43149(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 43128, 43149);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1600_43128_43158(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 43128, 43158);
return return_v;
}


object
f_1600_43128_43164(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 43128, 43164);
return return_v;
}


string
f_1600_43357_43394()
{
var return_v = RemotingErrorIdStrings.InvalidVMState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 43357, 43394);
return return_v;
}


string[]
f_1600_43462_43473(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 43462, 43473);
return return_v;
}


string
f_1600_43346_43481(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 43346, 43481);
return return_v;
}


System.ArgumentException
f_1600_43324_43482(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 43324, 43482);
return return_v;
}


string
f_1600_43517_43560(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 43517, 43560);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_43274_43664(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 43274, 43664);
return return_v;
}


int
f_1600_43233_43665(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 43233, 43665);
return 0;
}


string
f_1600_43971_44003(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 43971, 44003);
return return_v;
}


System.Management.Automation.PSCredential
f_1600_44106_44121(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 44106, 44121);
return return_v;
}


System.Guid[]
f_1600_44123_44132(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 44123, 44132);
return return_v;
}


string[]
f_1600_44141_44152(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 44141, 44152);
return return_v;
}


string
f_1600_44161_44183(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 44161, 44183);
return return_v;
}


System.Management.Automation.Runspaces.VMConnectionInfo
f_1600_44085_44184(System.Management.Automation.PSCredential
credential,System.Guid
vmGuid,string
vmName,string
configurationName)
{
var return_v = new System.Management.Automation.Runspaces.VMConnectionInfo( credential, vmGuid, vmName, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 44085, 44184);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_44239_44282()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 44239, 44282);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_44325_44334(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 44325, 44334);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_44220_44355(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.VMConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 44220, 44355);
return return_v;
}


int
f_1600_44380_44409(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.RemoteRunspace
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 44380, 44409);
return 0;
}


System.Management.Automation.ErrorRecord
f_1600_44549_44715(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 44549, 44715);
return return_v;
}


int
f_1600_44740_44763(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 44740, 44763);
return 0;
}


System.Management.Automation.ErrorRecord
f_1600_44895_45060(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 44895, 45060);
return return_v;
}


int
f_1600_45085_45108(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 45085, 45108);
return 0;
}


string[]
f_1600_45183_45194(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 45183, 45194);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,39494,45245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,39494,45245);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<RemoteRunspace> CreateRunspacesWhenContainerParameterSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,45398,48288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45500,45514);

int 
index = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45528,45579);

List<string> 
resolvedNameList = f_1600_45560_45578()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45593,45659);

List<RemoteRunspace> 
remoteRunspaces = f_1600_45632_45658()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45675,45819);

f_1600_45675_45818((f_1600_45687_45703()== PSExecutionCmdlet.ContainerIdParameterSet), "Expected ParameterSetName == ContainerId");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,45835,48171);
foreach(var input in f_1600_45857_45868_I(f_1600_45857_45868()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,45835,48171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46010,46041);

RemoteRunspace 
runspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46059,46105);

ContainerConnectionInfo 
connectionInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46123,46132);

int 
rsId
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46150,46199);

string 
rsName = f_1600_46166_46198(this, index, out rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46217,46225);

index++;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46491,46623);

connectionInfo = f_1600_46508_46622(input, f_1600_46569_46587().IsPresent, f_1600_46599_46621(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46647,46697);

f_1600_46647_46696(
                    resolvedNameList, f_1600_46668_46695(connectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46721,46761);

f_1600_46721_46760(
                    connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46785,46932);

runspace = f_1600_46796_46931(f_1600_46815_46858(), connectionInfo, f_1600_46901_46910(this), null, rsName, rsId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,46956,46986);

f_1600_46956_46985(
                    remoteRunspaces, runspace);
                }
                catch (InvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,47023,47397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,47099,47299);

ErrorRecord 
errorRecord = f_1600_47125_47298(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,47323,47347);

f_1600_47323_47346(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,47369,47378);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,47023,47397);
                }
                catch (ArgumentException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,47415,47780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,47483,47682);

ErrorRecord 
errorRecord = f_1600_47509_47681(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,47706,47730);

f_1600_47706_47729(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,47752,47761);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,47415,47780);
                }
                catch (Exception e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,47798,48156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,47858,48058);

ErrorRecord 
errorRecord = f_1600_47884_48057(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48082,48106);

f_1600_48082_48105(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48128,48137);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,47798,48156);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,45835,48171);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,2337);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,2337);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48187,48238);

ResolvedComputerNames = f_1600_48211_48237(resolvedNameList);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48254,48277);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,45398,48288);

System.Collections.Generic.List<string>
f_1600_45560_45578()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 45560, 45578);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_45632_45658()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 45632, 45658);
return return_v;
}


string
f_1600_45687_45703()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 45687, 45703);
return return_v;
}


int
f_1600_45675_45818(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 45675, 45818);
return 0;
}


string[]
f_1600_45857_45868()
{
var return_v = ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 45857, 45868);
return return_v;
}


string
f_1600_46166_46198(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 46166, 46198);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1600_46569_46587()
{
var return_v = RunAsAdministrator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 46569, 46587);
return return_v;
}


string
f_1600_46599_46621(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 46599, 46621);
return return_v;
}


System.Management.Automation.Runspaces.ContainerConnectionInfo
f_1600_46508_46622(string
containerId,bool
runAsAdmin,string
configurationName)
{
var return_v = ContainerConnectionInfo.CreateContainerConnectionInfo( containerId, runAsAdmin, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 46508, 46622);
return return_v;
}


string
f_1600_46668_46695(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 46668, 46695);
return return_v;
}


int
f_1600_46647_46696(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 46647, 46696);
return 0;
}


int
f_1600_46721_46760(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
this_param.CreateContainerProcess();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 46721, 46760);
return 0;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_46815_46858()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 46815, 46858);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_46901_46910(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 46901, 46910);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_46796_46931(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.ContainerConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 46796, 46931);
return return_v;
}


int
f_1600_46956_46985(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.RemoteRunspace
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 46956, 46985);
return 0;
}


System.Management.Automation.ErrorRecord
f_1600_47125_47298(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 47125, 47298);
return return_v;
}


int
f_1600_47323_47346(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 47323, 47346);
return 0;
}


System.Management.Automation.ErrorRecord
f_1600_47509_47681(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 47509, 47681);
return return_v;
}


int
f_1600_47706_47729(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 47706, 47729);
return 0;
}


System.Management.Automation.ErrorRecord
f_1600_47884_48057(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 47884, 48057);
return return_v;
}


int
f_1600_48082_48105(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 48082, 48105);
return 0;
}


string[]
f_1600_45857_45868_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 45857, 45868);
return return_v;
}


string[]
f_1600_48211_48237(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 48211, 48237);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,45398,48288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,45398,48288);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<RemoteRunspace> CreateRunspacesForSSHHostParameterSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,48432,49884);
string host = default(string);
string userName = default(string);
int port = default(int);
int rsIdUnused = default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48571,48602);

string[] 
resolvedComputerNames
=default(string[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48618,48676);

f_1600_48618_48675(this, f_1600_48639_48647(), out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48692,48741);

var 
remoteRunspaces = f_1600_48714_48740()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48755,48769);

int 
index = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48783,49834);
foreach(var computerName in f_1600_48812_48833_I(resolvedComputerNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,48783,49834);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48867,48950);

f_1600_48867_48949(this, computerName, out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,48970,49173);

var 
sshConnectionInfo = f_1600_48994_49172(userName, host, f_1600_49096_49112(this), port, f_1600_49162_49171())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,49191,49240);

var 
typeTable = f_1600_49207_49239()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,49258,49317);

string 
rsName = f_1600_49274_49316(this, index, out rsIdUnused)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,49335,49343);

index++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,49361,49819);

f_1600_49361_49818(                remoteRunspaces, f_1600_49381_49799(connectionInfo: sshConnectionInfo, host: f_1600_49521_49530(this), typeTable: typeTable, applicationArguments: null, name: rsName)as RemoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,48783,49834);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,1052);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,1052);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,49850,49873);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,48432,49884);

string[]
f_1600_48639_48647()
{
var return_v = HostName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 48639, 48647);
return return_v;
}


int
f_1600_48618_48675(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string[]
computerNames,out string[]
resolvedComputerNames)
{
this_param.ResolveComputerNames( computerNames, out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 48618, 48675);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_48714_48740()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 48714, 48740);
return return_v;
}


int
f_1600_48867_48949(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,string
hostname,out string
host,out string
userName,out int
port)
{
this_param.ParseSshHostName( hostname, out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 48867, 48949);
return 0;
}


string
f_1600_49096_49112(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.KeyFilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 49096, 49112);
return return_v;
}


string
f_1600_49162_49171()
{
var return_v = Subsystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 49162, 49171);
return return_v;
}


System.Management.Automation.Runspaces.SSHConnectionInfo
f_1600_48994_49172(string
userName,string
computerName,string
keyFilePath,int
port,string
subsystem)
{
var return_v = new System.Management.Automation.Runspaces.SSHConnectionInfo( userName, computerName, keyFilePath, port, subsystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 48994, 49172);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_49207_49239()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 49207, 49239);
return return_v;
}


string
f_1600_49274_49316(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 49274, 49316);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_49521_49530(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 49521, 49530);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1600_49381_49799(System.Management.Automation.Runspaces.SSHConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name)
{
var return_v = RunspaceFactory.CreateRunspace( connectionInfo: (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host: host, typeTable: typeTable, applicationArguments: applicationArguments, name: name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 49381, 49799);
return return_v;
}


int
f_1600_49361_49818(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.Runspaces.Runspace
item)
{
this_param.Add( (System.Management.Automation.RemoteRunspace)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 49361, 49818);
return 0;
}


string[]
f_1600_48812_48833_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 48812, 48833);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,48432,49884);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,48432,49884);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<RemoteRunspace> CreateRunspacesForSSHHostHashParameterSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,49896,51214);
int rsIdUnused = default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,49993,50044);

var 
sshConnections = f_1600_50014_50043(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50058,50107);

var 
remoteRunspaces = f_1600_50080_50106()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50121,50135);

int 
index = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50149,51164);
foreach(var sshConnection in f_1600_50179_50193_I(sshConnections) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,50149,51164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50227,50503);

var 
sshConnectionInfo = f_1600_50251_50502(sshConnection.UserName, sshConnection.ComputerName, sshConnection.KeyFilePath, sshConnection.Port, sshConnection.Subsystem)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50521,50570);

var 
typeTable = f_1600_50537_50569()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50588,50647);

string 
rsName = f_1600_50604_50646(this, index, out rsIdUnused)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50665,50673);

index++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,50691,51149);

f_1600_50691_51148(                remoteRunspaces, f_1600_50711_51129(connectionInfo: sshConnectionInfo, host: f_1600_50851_50860(this), typeTable: typeTable, applicationArguments: null, name: rsName)as RemoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,50149,51164);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,1016);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,1016);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,51180,51203);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,49896,51214);

Microsoft.PowerShell.Commands.SSHConnection[]
f_1600_50014_50043(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.ParseSSHConnectionHashTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50014, 50043);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_50080_50106()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50080, 50106);
return return_v;
}


System.Management.Automation.Runspaces.SSHConnectionInfo
f_1600_50251_50502(string
userName,string
computerName,string
keyFilePath,int
port,string
subsystem)
{
var return_v = new System.Management.Automation.Runspaces.SSHConnectionInfo( userName, computerName, keyFilePath, port, subsystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50251, 50502);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_50537_50569()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50537, 50569);
return return_v;
}


string
f_1600_50604_50646(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50604, 50646);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_50851_50860(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 50851, 50860);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1600_50711_51129(System.Management.Automation.Runspaces.SSHConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name)
{
var return_v = RunspaceFactory.CreateRunspace( connectionInfo: (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host: host, typeTable: typeTable, applicationArguments: applicationArguments, name: name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50711, 51129);
return return_v;
}


int
f_1600_50691_51148(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.Runspaces.Runspace
item)
{
this_param.Add( (System.Management.Automation.RemoteRunspace)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50691, 51148);
return 0;
}


Microsoft.PowerShell.Commands.SSHConnection[]
f_1600_50179_50193_I(Microsoft.PowerShell.Commands.SSHConnection[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 50179, 50193);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,49896,51214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,49896,51214);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<RemoteRunspace> CreateRunspacesForUseWindowsPowerShellParameterSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,51437,52500);
int runspaceIdUnused = default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,51543,51592);

var 
remoteRunspaces = f_1600_51565_51591()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,51608,51696);

NewProcessConnectionInfo 
connectionInfo = f_1600_51650_51695(f_1600_51679_51694(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,51710,51771);

connectionInfo.AuthenticationMechanism = f_1600_51751_51770(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,51796,51841);

connectionInfo.PSVersion = f_1600_51823_51840(5, 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,51863,51912);

var 
typeTable = f_1600_51879_51911()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,51926,51993);

string 
runspaceName = f_1600_51948_51992(this, 0, out runspaceIdUnused)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,52007,52452);

f_1600_52007_52451(            remoteRunspaces, f_1600_52027_52432(connectionInfo: connectionInfo, host: f_1600_52160_52169(this), typeTable: typeTable, applicationArguments: null, name: runspaceName)as RemoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,52466,52489);

return remoteRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,51437,52500);

System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_51565_51591()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 51565, 51591);
return return_v;
}


System.Management.Automation.PSCredential
f_1600_51679_51694(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 51679, 51694);
return return_v;
}


System.Management.Automation.Runspaces.NewProcessConnectionInfo
f_1600_51650_51695(System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Runspaces.NewProcessConnectionInfo( credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 51650, 51695);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1600_51751_51770(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 51751, 51770);
return return_v;
}


System.Version
f_1600_51823_51840(int
major,int
minor)
{
var return_v = new System.Version( major, minor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 51823, 51840);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1600_51879_51911()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 51879, 51911);
return return_v;
}


string
f_1600_51948_51992(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param,int
rsIndex,out int
rsId)
{
var return_v = this_param.GetRunspaceName( rsIndex, out rsId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 51948, 51992);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1600_52160_52169(Microsoft.PowerShell.Commands.NewPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 52160, 52169);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1600_52027_52432(System.Management.Automation.Runspaces.NewProcessConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name)
{
var return_v = RunspaceFactory.CreateRunspace( connectionInfo: (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host: host, typeTable: typeTable, applicationArguments: applicationArguments, name: name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 52027, 52432);
return return_v;
}


int
f_1600_52007_52451(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
this_param,System.Management.Automation.Runspaces.Runspace
item)
{
this_param.Add( (System.Management.Automation.RemoteRunspace)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 52007, 52451);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,51437,52500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,51437,52500);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetRunspaceName(int rsIndex, out int rsId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,52864,53565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,53013,53070);

string 
rsName = f_1600_53029_53069(out rsId)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,53411,53524) || true) && (f_1600_53415_53419()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1600, 53415, 53452)&&rsIndex < f_1600_53441_53452(f_1600_53441_53445())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,53411,53524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,53486,53509);

rsName = f_1600_53495_53499()[rsIndex];
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,53411,53524);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,53540,53554);

return rsName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,52864,53565);

string
f_1600_53029_53069(out int
rtnId)
{
var return_v = PSSession.GenerateRunspaceName( out rtnId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 53029, 53069);
return return_v;
}


string[]
f_1600_53415_53419()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 53415, 53419);
return return_v;
}


string[]
f_1600_53441_53445()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 53441, 53445);
return return_v;
}


int
f_1600_53441_53452(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 53441, 53452);
return return_v;
}


string[]
f_1600_53495_53499()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 53495, 53499);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,52864,53565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,52864,53565);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,53852,54915);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,53915,54904) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,53915,54904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,53962,53989);

f_1600_53962_53988(                _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54077,54107);

f_1600_54077_54106(
                // wait for all runspace operations to be complete
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54125,54155);

f_1600_54125_54154(                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54175,54264);

_throttleManager.ThrottleComplete -= new EventHandler<EventArgs>(HandleThrottleComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54282,54306);

_throttleManager = null;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54326,54464);
foreach(RemoteRunspace remoteRunspace in f_1600_54368_54378_I(_toDispose) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,54326,54464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54420,54445);

f_1600_54420_54444(                    remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,54326,54464);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,139);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,139);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54575,54851);
foreach(List<IThrottleOperation> operationList in f_1600_54626_54640_I(_allOperations) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,54575,54851);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54682,54832);
foreach(OpenRunspaceOperation operation in f_1600_54726_54739_I(operationList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,54682,54832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54789,54809);

f_1600_54789_54808(                        operation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,54682,54832);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,151);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,151);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1600,54575,54851);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,277);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,277);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,54871,54889);

f_1600_54871_54888(
                _stream);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,53915,54904);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,53852,54915);

int
f_1600_53962_53988(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 53962, 53988);
return 0;
}


bool
f_1600_54077_54106(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54077, 54106);
return return_v;
}


int
f_1600_54125_54154(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54125, 54154);
return 0;
}


int
f_1600_54420_54444(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54420, 54444);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_54368_54378_I(System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54368, 54378);
return return_v;
}


int
f_1600_54789_54808(Microsoft.PowerShell.Commands.OpenRunspaceOperation
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54789, 54808);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1600_54726_54739_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54726, 54739);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>>
f_1600_54626_54640_I(System.Collections.ObjectModel.Collection<System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54626, 54640);
return return_v;
}


int
f_1600_54871_54888(System.Management.Automation.Internal.ObjectStream
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 54871, 54888);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,53852,54915);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,53852,54915);
}
		}

private void HandleThrottleComplete(object sender, EventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,55160,55399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,55317,55346);

f_1600_55317_55345(f_1600_55317_55337(_stream));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,55362,55388);

f_1600_55362_55387(
            _operationsComplete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,55160,55399);

System.Management.Automation.Runspaces.PipelineWriter
f_1600_55317_55337(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 55317, 55337);
return return_v;
}


int
f_1600_55317_55345(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 55317, 55345);
return 0;
}


bool
f_1600_55362_55387(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 55362, 55387);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,55160,55399);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,55160,55399);
}
		}

private void WriteErrorCreateRemoteRunspaceFailed(Exception e, Uri uri)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,55740,56540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,55836,56135);

f_1600_55836_56134(e is UriFormatException ||(DynAbs.Tracing.TraceSender.Expression_False(1600, 55847, 55904)||e is InvalidOperationException )||(DynAbs.Tracing.TraceSender.Expression_False(1600, 55847, 55954)||                       e is ArgumentException )||(DynAbs.Tracing.TraceSender.Expression_False(1600, 55847, 55984)||e is NotSupportedException), "Exception has to be of type UriFormatException or InvalidOperationException or ArgumentException or NotSupportedException");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,56151,56196);

PipelineWriter 
writer = f_1600_56175_56195(_stream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,56212,56340);

ErrorRecord 
errorRecord = f_1600_56238_56339(e, "CreateRemoteRunspaceFailed", ErrorCategory.InvalidArgument, uri)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,56356,56489);

Action<Cmdlet> 
errorWriter = delegate (Cmdlet cmdlet)
            {
                cmdlet.WriteError(errorRecord);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,56503,56529);

f_1600_56503_56528(            writer, errorWriter);
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,55740,56540);

int
f_1600_55836_56134(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 55836, 56134);
return 0;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1600_56175_56195(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 56175, 56195);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1600_56238_56339(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Uri
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 56238, 56339);
return return_v;
}


int
f_1600_56503_56528(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 56503, 56528);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,55740,56540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,55740,56540);
}
		}

private ThrottleManager _throttleManager ;

private ObjectStream _stream ;

private ManualResetEvent _operationsComplete ;

private List<RemoteRunspace> _toDispose ;

private Collection<List<IThrottleOperation>> _allOperations ;

private string _defaultFQEID ;

public NewPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1600,2296,57703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,3000,3334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,5203,5223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,5335,5486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,6691,7442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,56649,56689);
this._throttleManager = f_1600_56668_56689();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,56721,56749);
this._stream = f_1600_56731_56749();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,56888,56936);
this._operationsComplete = f_1600_56910_56936(true);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,57333,57372);
this._toDispose = f_1600_57346_57372();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,57506,57565);
this._allOperations = f_1600_57523_57565();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,57620,57657);
this._defaultFQEID = "PSSessionOpenFailed";DynAbs.Tracing.TraceSender.TraceExitConstructor(1600,2296,57703);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,2296,57703);
}


static NewPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1600,2296,57703);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1600,2296,57703);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,2296,57703);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1600,2296,57703);

System.Management.Automation.Remoting.ThrottleManager
f_1600_56668_56689()
{
var return_v = new System.Management.Automation.Remoting.ThrottleManager();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 56668, 56689);
return return_v;
}


System.Management.Automation.Internal.ObjectStream
f_1600_56731_56749()
{
var return_v = new System.Management.Automation.Internal.ObjectStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 56731, 56749);
return return_v;
}


System.Threading.ManualResetEvent
f_1600_56910_56936(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 56910, 56936);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>
f_1600_57346_57372()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemoteRunspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 57346, 57372);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>>
f_1600_57523_57565()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 57523, 57565);
return return_v;
}

}
internal class OpenRunspaceOperation : IThrottleOperation, IDisposable
{
private bool _startComplete;

private bool _stopComplete;

private object _syncObject ;

internal RemoteRunspace OperatedRunspace {get; }

internal OpenRunspaceOperation(RemoteRunspace runspace)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1600,58348,58671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58169,58183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58207,58220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58248,58274);
this._syncObject = f_1600_58262_58274();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58287,58336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,60695,60765);
this._internalCallbacks = f_1600_60716_60765();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58428,58450);

_startComplete = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58464,58485);

_stopComplete = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58499,58527);

OperatedRunspace = runspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58541,58660);

f_1600_58541_58557().StateChanged +=
                new EventHandler<RunspaceStateEventArgs>(HandleRunspaceStateChanged);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1600,58348,58671);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,58348,58671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,58348,58671);
}
		}

internal override void StartOperation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,58778,58987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58848,58859);
            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58893,58916);

_startComplete = false;
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,58947,58976);

f_1600_58947_58975(f_1600_58947_58963());
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,58778,58987);

System.Management.Automation.RemoteRunspace
f_1600_58947_58963()
{
var return_v = OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 58947, 58963);
return return_v;
}


int
f_1600_58947_58975(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.OpenAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 58947, 58975);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,58778,58987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,58778,58987);
}
		}

internal override void StopOperation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,59110,60166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59173,59228);

OperationStateEventArgs 
operationStateEventArgs = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59250,59261);

            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59371,59909) || true) && (_startComplete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,59371,59909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59431,59452);

_stopComplete = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59474,59496);

_startComplete = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59518,59574);

operationStateEventArgs = f_1600_59544_59573();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59596,59695);

operationStateEventArgs.BaseEvent = f_1600_59632_59694(f_1600_59659_59693(f_1600_59659_59675()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59717,59786);

operationStateEventArgs.OperationState = OperationState.StopComplete;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,59371,59909);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,59371,59909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59868,59890);

_stopComplete = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,59371,59909);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,59940,60155) || true) && (operationStateEventArgs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,59940,60155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,60009,60044);

f_1600_60009_60043(this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,59940,60155);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,59940,60155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,60110,60140);

f_1600_60110_60139(f_1600_60110_60126());
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,59940,60155);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,59110,60166);

System.Management.Automation.Remoting.OperationStateEventArgs
f_1600_59544_59573()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 59544, 59573);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_59659_59675()
{
var return_v = OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 59659, 59675);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1600_59659_59693(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 59659, 59693);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateEventArgs
f_1600_59632_59694(System.Management.Automation.Runspaces.RunspaceStateInfo
runspaceStateInfo)
{
var return_v = new System.Management.Automation.Runspaces.RunspaceStateEventArgs( runspaceStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 59632, 59694);
return return_v;
}


int
f_1600_60009_60043(Microsoft.PowerShell.Commands.OpenRunspaceOperation
this_param,System.Management.Automation.Remoting.OperationStateEventArgs
operationStateEventArgs)
{
this_param.FireEvent( operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 60009, 60043);
return 0;
}


System.Management.Automation.RemoteRunspace
f_1600_60110_60126()
{
var return_v = OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 60110, 60126);
return return_v;
}


int
f_1600_60110_60139(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 60110, 60139);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,59110,60166);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,59110,60166);
}
		}

private List<EventHandler<OperationStateEventArgs>> _internalCallbacks ;
        internal override event EventHandler<OperationStateEventArgs> OperationComplete
        {

add
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,60880,61046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,60922,60940);
                lock (_internalCallbacks)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,60982,61012);

f_1600_60982_61011(                    _internalCallbacks, value);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,60880,61046);

int
f_1600_60982_61011(System.Collections.Generic.List<System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>>
this_param,System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 60982, 61011);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,60880,61046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,60880,61046);
}
		}

remove
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,61062,61234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,61107,61125);
                lock (_internalCallbacks)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,61167,61200);

f_1600_61167_61199(                    _internalCallbacks, value);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,61062,61234);

bool
f_1600_61167_61199(System.Collections.Generic.List<System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>>
this_param,System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 61167, 61199);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,61062,61234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,61062,61234);
}
		}
        }

private void HandleRunspaceStateChanged(object source, RunspaceStateEventArgs stateEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,62541,64367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,62706,62950);

switch (f_1600_62714_62752(f_1600_62714_62746(stateEventArgs)))
            {

case RunspaceState.Opening:
                case RunspaceState.BeforeOpen:
                case RunspaceState.Closing:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,62706,62950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,62928,62935);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,62706,62950);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,62966,63021);

OperationStateEventArgs 
operationStateEventArgs = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63041,63052);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63179,64156) || true) && (!_stopComplete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,63179,64156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63462,63483);

_stopComplete = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63505,63527);

_startComplete = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63549,63605);

operationStateEventArgs = f_1600_63575_63604();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63627,63678);

operationStateEventArgs.BaseEvent = stateEventArgs;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63700,63769);

operationStateEventArgs.OperationState = OperationState.StopComplete;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,63179,64156);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,63179,64156);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63811,64156) || true) && (!_startComplete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,63811,64156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63872,63894);

_startComplete = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63916,63972);

operationStateEventArgs = f_1600_63942_63971();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,63994,64045);

operationStateEventArgs.BaseEvent = stateEventArgs;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64067,64137);

operationStateEventArgs.OperationState = OperationState.StartComplete;
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,63811,64156);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,63179,64156);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64187,64356) || true) && (operationStateEventArgs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,64187,64356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64306,64341);

f_1600_64306_64340(this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,64187,64356);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,62541,64367);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1600_62714_62746(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 62714, 62746);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1600_62714_62752(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 62714, 62752);
return return_v;
}


System.Management.Automation.Remoting.OperationStateEventArgs
f_1600_63575_63604()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 63575, 63604);
return return_v;
}


System.Management.Automation.Remoting.OperationStateEventArgs
f_1600_63942_63971()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 63942, 63971);
return return_v;
}


int
f_1600_64306_64340(Microsoft.PowerShell.Commands.OpenRunspaceOperation
this_param,System.Management.Automation.Remoting.OperationStateEventArgs
operationStateEventArgs)
{
this_param.FireEvent( operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 64306, 64340);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,62541,64367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,62541,64367);
}
		}

private void FireEvent(OperationStateEventArgs operationStateEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,64379,65176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64475,64529);

EventHandler<OperationStateEventArgs>[] 
copyCallbacks
=default(EventHandler<OperationStateEventArgs>[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64549,64567);
            lock (_internalCallbacks)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64601,64685);

copyCallbacks = new EventHandler<OperationStateEventArgs>[f_1600_64659_64683(_internalCallbacks)];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64703,64744);

f_1600_64703_64743(                _internalCallbacks, copyCallbacks);
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64775,65165);
foreach(var callbackDelegate in f_1600_64808_64821_I(copyCallbacks) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1600,64775,65165);
                // Ensure all callbacks get called to prevent ThrottleManager from not responding.
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,64999,65058);

f_1600_64999_65057(                    callbackDelegate, this, operationStateEventArgs);
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1600,65095,65150);
DynAbs.Tracing.TraceSender.TraceExitCatch(1600,65095,65150);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1600,64775,65165);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1600,1,391);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1600,1,391);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1600,64379,65176);

int
f_1600_64659_64683(System.Collections.Generic.List<System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 64659, 64683);
return return_v;
}


int
f_1600_64703_64743(System.Collections.Generic.List<System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>>
this_param,System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>[]
array)
{
this_param.CopyTo( array);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 64703, 64743);
return 0;
}


int
f_1600_64999_65057(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
eventHandler,Microsoft.PowerShell.Commands.OpenRunspaceOperation
sender,System.Management.Automation.Remoting.OperationStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 64999, 65057);
return 0;
}


System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>[]
f_1600_64808_64821_I(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 64808, 64821);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,64379,65176);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,64379,65176);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1600,65272,65600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,65487,65547);

f_1600_65487_65503().StateChanged -= HandleRunspaceStateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1600,65563,65589);

f_1600_65563_65588(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1600,65272,65600);

System.Management.Automation.RemoteRunspace
f_1600_65487_65503()
{
var return_v = OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 65487, 65503);
return return_v;
}


int
f_1600_65563_65588(Microsoft.PowerShell.Commands.OpenRunspaceOperation
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 65563, 65588);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1600,65272,65600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,65272,65600);
}
		}

static OpenRunspaceOperation()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1600,57912,65607);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1600,57912,65607);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1600,57912,65607);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1600,57912,65607);

object
f_1600_58262_58274()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 58262, 58274);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1600_58541_58557()
{
var return_v = OperatedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1600, 58541, 58557);
return return_v;
}


System.Collections.Generic.List<System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>>
f_1600_60716_60765()
{
var return_v = new System.Collections.Generic.List<System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1600, 60716, 60765);
return return_v;
}

}

    }
