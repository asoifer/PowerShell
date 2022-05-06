// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[SuppressMessage("Microsoft.PowerShell", "PS1012:CallShouldProcessOnlyIfDeclaringSupport")]
    [Cmdlet(VerbsCommunications.Disconnect, "PSSession", SupportsShouldProcess = true, DefaultParameterSetName = DisconnectPSSessionCommand.SessionParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096576", RemotingCapability = RemotingCapability.OwnedByCommand)]
    [OutputType(typeof(PSSession))]
    public class DisconnectPSSessionCommand : PSRunspaceCmdlet, IDisposable
{
[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = DisconnectPSSessionCommand.SessionParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public PSSession[] Session {get; set; }

[Parameter(ParameterSetName = DisconnectPSSessionCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.NameParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.IdParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.InstanceIdParameterSet)]
        [ValidateRange(0, int.MaxValue)]
        public int IdleTimeoutSec
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,3178,3234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,3184,3232);

return f_1591_3191_3211(this).IdleTimeout.Seconds;
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,3178,3234);

System.Management.Automation.Remoting.PSSessionOption
f_1591_3191_3211(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param)
{
var return_v = this_param.PSSessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 3191, 3211);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,2769,3332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,2769,3332);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,3250,3321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,3256,3319);

f_1591_3256_3276(this).IdleTimeout = TimeSpan.FromSeconds(value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,3250,3321);

System.Management.Automation.Remoting.PSSessionOption
f_1591_3256_3276(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param)
{
var return_v = this_param.PSSessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 3256, 3276);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,2769,3332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,2769,3332);
}
		}}

[Parameter(ParameterSetName = DisconnectPSSessionCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.NameParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.IdParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.InstanceIdParameterSet)]
        public OutputBufferingMode OutputBufferingMode
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,3904,3960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,3910,3958);

return f_1591_3917_3957(f_1591_3917_3937(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,3904,3960);

System.Management.Automation.Remoting.PSSessionOption
f_1591_3917_3937(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param)
{
var return_v = this_param.PSSessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 3917, 3937);
return return_v;
}


System.Management.Automation.Runspaces.OutputBufferingMode
f_1591_3917_3957(System.Management.Automation.Remoting.PSSessionOption
this_param)
{
var return_v = this_param.OutputBufferingMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 3917, 3957);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,3516,4044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,3516,4044);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,3976,4033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,3982,4031);

f_1591_3982_4002(this).OutputBufferingMode = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,3976,4033);

System.Management.Automation.Remoting.PSSessionOption
f_1591_3982_4002(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param)
{
var return_v = this_param.PSSessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 3982, 4002);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,3516,4044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,3516,4044);
}
		}}

[Parameter(ParameterSetName = DisconnectPSSessionCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.NameParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.IdParameterSet)]
        [Parameter(ParameterSetName = PSRunspaceCmdlet.InstanceIdParameterSet)]
        public int ThrottleLimit {get; set; }

public override string[] ComputerName {get; set; }

private PSSessionOption PSSessionOption
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,4960,5202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,5121,5187);

return _sessionOption ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Remoting.PSSessionOption>(1591, 5128, 5186)??(_sessionOption = f_1591_5164_5185()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,4960,5202);

System.Management.Automation.Remoting.PSSessionOption
f_1591_5164_5185()
{
var return_v = new System.Management.Automation.Remoting.PSSessionOption();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 5164, 5185);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,4896,5213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,4896,5213);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSSessionOption _sessionOption;

public override string[] ContainerId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,5436,5499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,5472,5484);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,5436,5499);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,5375,5510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,5375,5510);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Guid[] VMId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,5673,5736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,5709,5721);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,5673,5736);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,5621,5747);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,5621,5747);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string[] VMName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,5914,5977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,5950,5962);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,5914,5977);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,5858,5988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,5858,5988);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,6181,6457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,6247,6270);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1591,6247,6269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,6286,6333);

_throttleManager.ThrottleLimit = f_1591_6319_6332();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,6347,6446);

_throttleManager.ThrottleComplete += new EventHandler<EventArgs>(HandleThrottleDisconnectComplete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,6181,6457);

int
f_1591_6319_6332()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 6319, 6332);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,6181,6457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,6181,6457);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,6582,12780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,6646,6685);

Dictionary<Guid, PSSession> 
psSessions
=default(Dictionary<Guid, PSSession>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,6699,6778);

List<IThrottleOperation> 
disconnectOperations = f_1591_6747_6777()
;

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,6890,7525) || true) && (f_1591_6894_6910()== DisconnectPSSessionCommand.SessionParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,6890,7525);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7002,7124) || true) && (f_1591_7006_7013()== null ||(DynAbs.Tracing.TraceSender.Expression_False(1591, 7006, 7044)||f_1591_7025_7039(f_1591_7025_7032())== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,7002,7124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7094,7101);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,7002,7124);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7148,7195);

psSessions = f_1591_7161_7194();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7217,7377);
foreach(PSSession psSession in f_1591_7249_7256_I(f_1591_7249_7256()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,7217,7377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7306,7354);

f_1591_7306_7353(                        psSessions, f_1591_7321_7341(psSession), psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,7217,7377);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1591,1,161);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1591,1,161);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1591,6890,7525);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,6890,7525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7459,7506);

psSessions = f_1591_7472_7505(this, false, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,6890,7525);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7769,7835);

string 
cnNames = f_1591_7786_7834(this, psSessions)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7853,8066) || true) && (!f_1591_7858_7887(cnNames))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,7853,8066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,7929,8047);

f_1591_7929_8046(this, f_1591_7968_8045(f_1591_7986_8035(), cnNames));
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,7853,8066);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,8169,11236);
foreach(PSSession psSession in f_1591_8201_8218_I(f_1591_8201_8218(psSessions)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,8169,11236);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,8260,11217) || true) && (f_1591_8264_8325(this, f_1591_8278_8292(psSession), VerbsCommunications.Disconnect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,8260,11217);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,8472,9208) || true) && (f_1591_8476_8498(psSession)!= TargetMachineType.RemoteMachine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,8472,9208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,8643,8845);

string 
msg = f_1591_8656_8844(f_1591_8674_8746(), f_1591_8781_8795(psSession), f_1591_8797_8819(psSession), f_1591_8821_8843(psSession))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,8875,8927);

Exception 
reason = f_1591_8894_8926(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,8957,9088);

ErrorRecord 
errorRecord = f_1591_8983_9087(reason, "CannotDisconnectVMContainerSession", ErrorCategory.InvalidOperation, psSession)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,9118,9142);

f_1591_9118_9141(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,9172,9181);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,8472,9208);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,9304,11194) || true) && (f_1591_9308_9350(f_1591_9308_9344(f_1591_9308_9326(psSession)))== RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,9304,11194);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,9529,9720) || true) && (_sessionOption != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,9529,9720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,9621,9689);

f_1591_9621_9688(f_1591_9621_9654(f_1591_9621_9639(psSession)), _sessionOption);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,9529,9720);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,9960,10101) || true) && (!f_1591_9965_9995(this, psSession))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,9960,10101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10061,10070);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,9960,10101);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10133,10235);

DisconnectRunspaceOperation 
disconnectOperation = f_1591_10183_10234(psSession, _stream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10265,10311);

f_1591_10265_10310(                            disconnectOperations, disconnectOperation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,9304,11194);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,9304,11194);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10369,11194) || true) && (f_1591_10373_10415(f_1591_10373_10409(f_1591_10373_10391(psSession)))!= RunspaceState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,10369,11194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10555,10655);

string 
msg = f_1591_10568_10654(f_1591_10586_10637(), f_1591_10639_10653(psSession))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10685,10730);

Exception 
reason = f_1591_10704_10729(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10760,10893);

ErrorRecord 
errorRecord = f_1591_10786_10892(reason, "CannotDisconnectSessionWhenNotOpened", ErrorCategory.InvalidOperation, psSession)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,10923,10947);

f_1591_10923_10946(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,10369,11194);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,10369,11194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,11144,11167);

f_1591_11144_11166(this, psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,10369,11194);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,9304,11194);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,8260,11217);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,8169,11236);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1591,1,3068);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1591,1,3068);
}            }
            catch (PSRemotingDataStructureException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1591,11265,11472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,11407,11433);

f_1591_11407_11432(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,11451,11457);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1591,11265,11472);
            }
            catch (PSRemotingTransportException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1591,11486,11689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,11624,11650);

f_1591_11624_11649(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,11668,11674);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1591,11486,11689);
            }
            catch (RemoteException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1591,11703,11893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,11828,11854);

f_1591_11828_11853(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,11872,11878);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1591,11703,11893);
            }
            catch (InvalidRunspaceStateException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1591,11907,12111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12046,12072);

f_1591_12046_12071(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12090,12096);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1591,11907,12111);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12127,12769) || true) && (f_1591_12131_12157(disconnectOperations)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,12127,12769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12284,12312);

f_1591_12284_12311(                // Make sure operations are not set as complete while processing input.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12390,12446);

f_1591_12390_12445(
                // Submit list of disconnect operations.
                _throttleManager, disconnectOperations);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12508,12582);

Collection<object> 
streamObjects = f_1591_12543_12581(f_1591_12543_12563(_stream))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12600,12754);
foreach(object streamObject in f_1591_12632_12645_I(streamObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,12600,12754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12687,12735);

f_1591_12687_12734(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,12600,12754);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1591,1,155);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1591,1,155);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1591,12127,12769);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,6582,12780);

System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1591_6747_6777()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 6747, 6777);
return return_v;
}


string
f_1591_6894_6910()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 6894, 6910);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1591_7006_7013()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 7006, 7013);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1591_7025_7032()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 7025, 7032);
return return_v;
}


int
f_1591_7025_7039(System.Management.Automation.Runspaces.PSSession[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 7025, 7039);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1591_7161_7194()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7161, 7194);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1591_7249_7256()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 7249, 7256);
return return_v;
}


System.Guid
f_1591_7321_7341(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 7321, 7341);
return return_v;
}


int
f_1591_7306_7353(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param,System.Guid
key,System.Management.Automation.Runspaces.PSSession
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7306, 7353);
return 0;
}


System.Management.Automation.Runspaces.PSSession[]
f_1591_7249_7256_I(System.Management.Automation.Runspaces.PSSession[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7249, 7256);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1591_7472_7505(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspaces( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7472, 7505);
return return_v;
}


string
f_1591_7786_7834(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
psSessions)
{
var return_v = this_param.GetLocalhostWithNetworkAccessEnabled( psSessions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7786, 7834);
return return_v;
}


bool
f_1591_7858_7887(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7858, 7887);
return return_v;
}


string
f_1591_7986_8035()
{
var return_v = RemotingErrorIdStrings.EnableNetworkAccessWarning;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 7986, 8035);
return return_v;
}


string
f_1591_7968_8045(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7968, 8045);
return return_v;
}


int
f_1591_7929_8046(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 7929, 8046);
return 0;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
f_1591_8201_8218(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 8201, 8218);
return return_v;
}


string
f_1591_8278_8292(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 8278, 8292);
return return_v;
}


bool
f_1591_8264_8325(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 8264, 8325);
return return_v;
}


System.Management.Automation.Runspaces.TargetMachineType
f_1591_8476_8498(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 8476, 8498);
return return_v;
}


string
f_1591_8674_8746()
{
var return_v = RemotingErrorIdStrings.RunspaceCannotBeDisconnectedForVMContainerSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 8674, 8746);
return return_v;
}


string
f_1591_8781_8795(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 8781, 8795);
return return_v;
}


string
f_1591_8797_8819(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 8797, 8819);
return return_v;
}


System.Management.Automation.Runspaces.TargetMachineType
f_1591_8821_8843(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 8821, 8843);
return return_v;
}


string
f_1591_8656_8844(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 8656, 8844);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1591_8894_8926(string
message)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 8894, 8926);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1591_8983_9087(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 8983, 9087);
return return_v;
}


int
f_1591_9118_9141(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 9118, 9141);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1591_9308_9326(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 9308, 9326);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1591_9308_9344(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 9308, 9344);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1591_9308_9350(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 9308, 9350);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1591_9621_9639(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 9621, 9639);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1591_9621_9654(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 9621, 9654);
return return_v;
}


int
f_1591_9621_9688(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param,System.Management.Automation.Remoting.PSSessionOption
options)
{
this_param.SetSessionOptions( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 9621, 9688);
return 0;
}


bool
f_1591_9965_9995(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
var return_v = this_param.ValidateIdleTimeout( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 9965, 9995);
return return_v;
}


Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
f_1591_10183_10234(System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.Internal.ObjectStream
stream)
{
var return_v = new Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation( session, stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 10183, 10234);
return return_v;
}


int
f_1591_10265_10310(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
item)
{
this_param.Add( (System.Management.Automation.Remoting.IThrottleOperation)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 10265, 10310);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1591_10373_10391(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 10373, 10391);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1591_10373_10409(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 10373, 10409);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1591_10373_10415(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 10373, 10415);
return return_v;
}


string
f_1591_10586_10637()
{
var return_v = RemotingErrorIdStrings.RunspaceCannotBeDisconnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 10586, 10637);
return return_v;
}


string
f_1591_10639_10653(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 10639, 10653);
return return_v;
}


string
f_1591_10568_10654(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 10568, 10654);
return return_v;
}


System.Management.Automation.RuntimeException
f_1591_10704_10729(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 10704, 10729);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1591_10786_10892(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 10786, 10892);
return return_v;
}


int
f_1591_10923_10946(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 10923, 10946);
return 0;
}


int
f_1591_11144_11166(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 11144, 11166);
return 0;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
f_1591_8201_8218_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 8201, 8218);
return return_v;
}


bool
f_1591_11407_11432(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 11407, 11432);
return return_v;
}


bool
f_1591_11624_11649(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 11624, 11649);
return return_v;
}


bool
f_1591_11828_11853(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 11828, 11853);
return return_v;
}


bool
f_1591_12046_12071(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 12046, 12071);
return return_v;
}


int
f_1591_12131_12157(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 12131, 12157);
return return_v;
}


bool
f_1591_12284_12311(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 12284, 12311);
return return_v;
}


int
f_1591_12390_12445(System.Management.Automation.Remoting.ThrottleManager
this_param,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
operations)
{
this_param.SubmitOperations( operations);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 12390, 12445);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1591_12543_12563(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 12543, 12563);
return return_v;
}


System.Collections.ObjectModel.Collection<object>
f_1591_12543_12581(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.NonBlockingRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 12543, 12581);
return return_v;
}


int
f_1591_12687_12734(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 12687, 12734);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_1591_12632_12645_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 12632, 12645);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,6582,12780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,6582,12780);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,12877,13381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,12941,12980);

f_1591_12941_12979(            _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,13060,13090);

f_1591_13060_13089(
            // Wait for all disconnect operations to complete.
            _operationsComplete);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,13163,13370) || true) && (f_1591_13170_13205_M(!f_1591_13171_13191(_stream).EndOfPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,13163,13370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,13239,13289);

object 
streamObject = f_1591_13261_13288(f_1591_13261_13281(_stream))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,13307,13355);

f_1591_13307_13354(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,13163,13370);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1591,13163,13370);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1591,13163,13370);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1591,12877,13381);

int
f_1591_12941_12979(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.EndSubmitOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 12941, 12979);
return 0;
}


bool
f_1591_13060_13089(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 13060, 13089);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1591_13171_13191(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 13171, 13191);
return return_v;
}


bool
f_1591_13170_13205_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 13170, 13205);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1591_13261_13281(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 13261, 13281);
return return_v;
}


object
f_1591_13261_13288(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 13261, 13288);
return return_v;
}


int
f_1591_13307_13354(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 13307, 13354);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,12877,13381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,12877,13381);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,13495,13822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,13624,13653);

f_1591_13624_13652(f_1591_13624_13644(_stream));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,13774,13811);

f_1591_13774_13810(
            // Signal the ThrottleManager to stop any further processing
            // of PSSessions.
            _throttleManager);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,13495,13822);

System.Management.Automation.Runspaces.PipelineWriter
f_1591_13624_13644(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 13624, 13644);
return return_v;
}


int
f_1591_13624_13652(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 13624, 13652);
return 0;
}


int
f_1591_13774_13810(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.StopAllOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 13774, 13810);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,13495,13822);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,13495,13822);
}
		}

private void HandleThrottleDisconnectComplete(object sender, EventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,14129,14315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,14235,14264);

f_1591_14235_14263(f_1591_14235_14255(_stream));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,14278,14304);

f_1591_14278_14303(            _operationsComplete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,14129,14315);

System.Management.Automation.Runspaces.PipelineWriter
f_1591_14235_14255(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14235, 14255);
return return_v;
}


int
f_1591_14235_14263(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 14235, 14263);
return 0;
}


bool
f_1591_14278_14303(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 14278, 14303);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,14129,14315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,14129,14315);
}
		}

private bool ValidateIdleTimeout(PSSession session)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,14327,15350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,14403,14465);

int 
idleTimeout = f_1591_14421_14464(f_1591_14421_14452(f_1591_14421_14437(session)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,14479,14547);

int 
maxIdleTimeout = f_1591_14500_14546(f_1591_14500_14531(f_1591_14500_14516(session)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,14561,14622);

int 
minIdleTimeout = BaseTransportManager.MinimumIdleTimeout
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,14638,15311) || true) && (idleTimeout != BaseTransportManager.UseServerDefaultIdleTimeout &&(DynAbs.Tracing.TraceSender.Expression_True(1591, 14642, 14788)&&                (idleTimeout > maxIdleTimeout ||(DynAbs.Tracing.TraceSender.Expression_False(1591, 14727, 14787)||idleTimeout < minIdleTimeout))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,14638,15311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,14822,15024);

string 
msg = f_1591_14835_15023(f_1591_14853_14921(), f_1591_14944_14956(session), idleTimeout / 1000, maxIdleTimeout / 1000, minIdleTimeout / 1000)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15042,15221);

ErrorRecord 
errorRecord = f_1591_15068_15220(f_1591_15084_15109(msg), "CannotDisconnectSessionWithInvalidIdleTimeout", ErrorCategory.InvalidArgument, session)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15239,15263);

f_1591_15239_15262(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15283,15296);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,14638,15311);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15327,15339);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,14327,15350);

System.Management.Automation.Runspaces.Runspace
f_1591_14421_14437(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14421, 14437);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1591_14421_14452(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14421, 14452);
return return_v;
}


int
f_1591_14421_14464(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.IdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14421, 14464);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1591_14500_14516(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14500, 14516);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1591_14500_14531(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14500, 14531);
return return_v;
}


int
f_1591_14500_14546(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.MaxIdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14500, 14546);
return return_v;
}


string
f_1591_14853_14921()
{
var return_v = RemotingErrorIdStrings.CannotDisconnectSessionWithInvalidIdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14853, 14921);
return return_v;
}


string
f_1591_14944_14956(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 14944, 14956);
return return_v;
}


string
f_1591_14835_15023(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 14835, 15023);
return return_v;
}


System.Management.Automation.RuntimeException
f_1591_15084_15109(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 15084, 15109);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1591_15068_15220(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 15068, 15220);
return return_v;
}


int
f_1591_15239_15262(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 15239, 15262);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,14327,15350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,14327,15350);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetLocalhostWithNetworkAccessEnabled(Dictionary<Guid, PSSession> psSessions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,15362,16112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15478,15541);

System.Text.StringBuilder 
sb = f_1591_15509_15540()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15557,15954);
foreach(PSSession psSession in f_1591_15589_15606_I(f_1591_15589_15606(psSessions)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,15557,15954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15640,15739);

WSManConnectionInfo 
wsManConnectionInfo = f_1591_15682_15715(f_1591_15682_15700(psSession))as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15759,15939) || true) && ((wsManConnectionInfo != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1591, 15763, 15845)&&(f_1591_15797_15844(wsManConnectionInfo))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,15759,15939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15887,15920);

f_1591_15887_15919(                    sb, f_1591_15897_15911(psSession)+ ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,15759,15939);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,15557,15954);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1591,1,398);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1591,1,398);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,15970,16064) || true) && (f_1591_15974_15983(sb)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,15970,16064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16021,16049);

f_1591_16021_16048(                sb, f_1591_16031_16040(sb)- 2, 2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,15970,16064);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16080,16101);

return f_1591_16087_16100(sb);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,15362,16112);

System.Text.StringBuilder
f_1591_15509_15540()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 15509, 15540);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
f_1591_15589_15606(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 15589, 15606);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1591_15682_15700(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 15682, 15700);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1591_15682_15715(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 15682, 15715);
return return_v;
}


bool
f_1591_15797_15844(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.IsLocalhostAndNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 15797, 15844);
return return_v;
}


string
f_1591_15897_15911(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 15897, 15911);
return return_v;
}


System.Text.StringBuilder
f_1591_15887_15919(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 15887, 15919);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
f_1591_15589_15606_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 15589, 15606);
return return_v;
}


int
f_1591_15974_15983(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 15974, 15983);
return return_v;
}


int
f_1591_16031_16040(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 16031, 16040);
return return_v;
}


System.Text.StringBuilder
f_1591_16021_16048(System.Text.StringBuilder
this_param,int
startIndex,int
length)
{
var return_v = this_param.Remove( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 16021, 16048);
return return_v;
}


string
f_1591_16087_16100(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 16087, 16100);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,15362,16112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,15362,16112);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private class DisconnectRunspaceOperation : IThrottleOperation
{
private PSSession _remoteSession;

private ObjectStream _writeStream;

internal DisconnectRunspaceOperation(PSSession session, ObjectStream stream)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1591,16490,16758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16411,16425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16461,16473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16599,16624);

_remoteSession = session;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16642,16664);

_writeStream = stream;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16682,16743);

f_1591_16682_16705(_remoteSession).StateChanged += StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1591,16490,16758);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,16490,16758);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,16490,16758);
}
		}

internal override void StartOperation()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,16774,17689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16846,16878);

bool 
startedSuccessfully = true
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,16942,16984);

f_1591_16942_16983(f_1591_16942_16965(_remoteSession));
                }
                catch (InvalidRunspacePoolStateException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1591,17021,17199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17105,17133);

startedSuccessfully = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17155,17180);

f_1591_17155_17179(this, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1591,17021,17199);
                }
                catch (PSInvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1591,17217,17389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17295,17323);

startedSuccessfully = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17345,17370);

f_1591_17345_17369(this, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1591,17217,17389);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17409,17674) || true) && (!startedSuccessfully)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,17409,17674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17552,17613);

f_1591_17552_17575(_remoteSession).StateChanged -= StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17635,17655);

f_1591_17635_17654(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,17409,17674);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,16774,17689);

System.Management.Automation.Runspaces.Runspace
f_1591_16942_16965(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 16942, 16965);
return return_v;
}


int
f_1591_16942_16983(System.Management.Automation.Runspaces.Runspace
this_param)
{
this_param.DisconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 16942, 16983);
return 0;
}


int
f_1591_17155_17179(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
this_param,System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
e)
{
this_param.WriteDisconnectFailed( (System.Exception)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 17155, 17179);
return 0;
}


int
f_1591_17345_17369(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
this_param,System.Management.Automation.PSInvalidOperationException
e)
{
this_param.WriteDisconnectFailed( (System.Exception)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 17345, 17369);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1591_17552_17575(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 17552, 17575);
return return_v;
}


int
f_1591_17635_17654(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
this_param)
{
this_param.SendStartComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 17635, 17654);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,16774,17689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,16774,17689);
}
		}

internal override void StopOperation()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,17705,17943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17830,17891);

f_1591_17830_17853(_remoteSession).StateChanged -= StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,17909,17928);

f_1591_17909_17927(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,17705,17943);

System.Management.Automation.Runspaces.Runspace
f_1591_17830_17853(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 17830, 17853);
return return_v;
}


int
f_1591_17909_17927(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
this_param)
{
this_param.SendStopComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 17909, 17927);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,17705,17943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,17705,17943);
}
		}

            internal override event EventHandler<OperationStateEventArgs> 
OperationComplete
;

private void StateCallBackHandler(object sender, RunspaceStateEventArgs eArgs)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,18055,18931);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,18166,18298) || true) && (f_1591_18170_18199(f_1591_18170_18193(eArgs))== RunspaceState.Disconnecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,18166,18298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,18272,18279);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,18166,18298);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,18318,18725) || true) && (f_1591_18322_18351(f_1591_18322_18345(eArgs))== RunspaceState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,18318,18725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,18504,18533);

f_1591_18504_18532(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,18318,18725);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,18318,18725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,18682,18706);

f_1591_18682_18705(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,18318,18725);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,18817,18878);

f_1591_18817_18840(_remoteSession).StateChanged -= StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,18896,18916);

f_1591_18896_18915(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,18055,18931);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1591_18170_18193(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 18170, 18193);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1591_18170_18199(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 18170, 18199);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1591_18322_18345(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 18322, 18345);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1591_18322_18351(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 18322, 18351);
return return_v;
}


int
f_1591_18504_18532(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
this_param)
{
this_param.WriteDisconnectedPSSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 18504, 18532);
return 0;
}


int
f_1591_18682_18705(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
this_param)
{
this_param.WriteDisconnectFailed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 18682, 18705);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1591_18817_18840(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 18817, 18840);
return return_v;
}


int
f_1591_18896_18915(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
this_param)
{
this_param.SendStartComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 18896, 18915);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,18055,18931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,18055,18931);
}
		}

private void SendStartComplete()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,18947,19273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19012,19092);

OperationStateEventArgs 
operationStateEventArgs = f_1591_19062_19091()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19110,19180);

operationStateEventArgs.OperationState = OperationState.StartComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19198,19258);

f_1591_19198_19257(                OperationComplete, this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,18947,19273);

System.Management.Automation.Remoting.OperationStateEventArgs
f_1591_19062_19091()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 19062, 19091);
return return_v;
}


int
f_1591_19198_19257(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
eventHandler,Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
sender,System.Management.Automation.Remoting.OperationStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 19198, 19257);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,18947,19273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,18947,19273);
}
		}

private void SendStopComplete()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,19289,19613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19353,19433);

OperationStateEventArgs 
operationStateEventArgs = f_1591_19403_19432()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19451,19520);

operationStateEventArgs.OperationState = OperationState.StopComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19538,19598);

f_1591_19538_19597(                OperationComplete, this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,19289,19613);

System.Management.Automation.Remoting.OperationStateEventArgs
f_1591_19403_19432()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 19403, 19432);
return return_v;
}


int
f_1591_19538_19597(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
eventHandler,Microsoft.PowerShell.Commands.DisconnectPSSessionCommand.DisconnectRunspaceOperation
sender,System.Management.Automation.Remoting.OperationStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 19538, 19597);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,19289,19613);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,19289,19613);
}
		}

private void WriteDisconnectedPSSession()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,19629,20045);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19703,20030) || true) && (f_1591_19707_19739(f_1591_19707_19732(_writeStream)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,19703,20030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19781,19943);

Action<Cmdlet> 
outputWriter = delegate (Cmdlet cmdlet)
                    {
                        cmdlet.WriteObject(_remoteSession);
                    }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,19965,20011);

f_1591_19965_20010(f_1591_19965_19990(_writeStream), outputWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,19703,20030);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,19629,20045);

System.Management.Automation.Runspaces.PipelineWriter
f_1591_19707_19732(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 19707, 19732);
return return_v;
}


bool
f_1591_19707_19739(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 19707, 19739);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1591_19965_19990(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 19965, 19990);
return return_v;
}


int
f_1591_19965_20010(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 19965, 20010);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,19629,20045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,19629,20045);
}
		}

private void WriteDisconnectFailed(Exception e = null)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,20061,21208);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20148,21193) || true) && (f_1591_20152_20184(f_1591_20152_20177(_writeStream)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,20148,21193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20226,20237);

string 
msg
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20261,20707) || true) && (e != null &&(DynAbs.Tracing.TraceSender.Expression_True(1591, 20265, 20315)&&!f_1591_20279_20315(f_1591_20305_20314(e))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,20261,20707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20365,20486);

msg = f_1591_20371_20485(f_1591_20389_20446(), f_1591_20448_20473(_remoteSession), f_1591_20475_20484(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,20261,20707);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,20261,20707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20584,20684);

msg = f_1591_20590_20683(f_1591_20608_20655(), f_1591_20657_20682(_remoteSession));
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,20261,20707);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20731,20779);

Exception 
reason = f_1591_20750_20778(msg, e)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20801,20928);

ErrorRecord 
errorRecord = f_1591_20827_20927(reason, "PSSessionDisconnectFailed", ErrorCategory.InvalidOperation, _remoteSession)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,20950,21107);

Action<Cmdlet> 
errorWriter = delegate (Cmdlet cmdlet)
                    {
                        cmdlet.WriteError(errorRecord);
                    }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,21129,21174);

f_1591_21129_21173(f_1591_21129_21154(_writeStream), errorWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,20148,21193);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,20061,21208);

System.Management.Automation.Runspaces.PipelineWriter
f_1591_20152_20177(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20152, 20177);
return return_v;
}


bool
f_1591_20152_20184(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20152, 20184);
return return_v;
}


string
f_1591_20305_20314(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20305, 20314);
return return_v;
}


bool
f_1591_20279_20315(string
value)
{
var return_v = string.IsNullOrWhiteSpace( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 20279, 20315);
return return_v;
}


string
f_1591_20389_20446()
{
var return_v = RemotingErrorIdStrings.RunspaceDisconnectFailedWithReason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20389, 20446);
return return_v;
}


System.Guid
f_1591_20448_20473(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20448, 20473);
return return_v;
}


string
f_1591_20475_20484(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20475, 20484);
return return_v;
}


string
f_1591_20371_20485(string
formatSpec,System.Guid
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 20371, 20485);
return return_v;
}


string
f_1591_20608_20655()
{
var return_v = RemotingErrorIdStrings.RunspaceDisconnectFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20608, 20655);
return return_v;
}


System.Guid
f_1591_20657_20682(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 20657, 20682);
return return_v;
}


string
f_1591_20590_20683(string
formatSpec,System.Guid
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 20590, 20683);
return return_v;
}


System.Management.Automation.RuntimeException
f_1591_20750_20778(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 20750, 20778);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1591_20827_20927(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 20827, 20927);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1591_21129_21154(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 21129, 21154);
return return_v;
}


int
f_1591_21129_21173(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 21129, 21173);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,20061,21208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,20061,21208);
}
		}

static DisconnectRunspaceOperation()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1591,16306,21219);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1591,16306,21219);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,16306,21219);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1591,16306,21219);

System.Management.Automation.Runspaces.Runspace
f_1591_16682_16705(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1591, 16682, 16705);
return return_v;
}

}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,21529,21642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,21575,21589);

f_1591_21575_21588(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,21605,21631);

f_1591_21605_21630(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,21529,21642);

int
f_1591_21575_21588(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 21575, 21588);
return 0;
}


int
f_1591_21605_21630(Microsoft.PowerShell.Commands.DisconnectPSSessionCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 21605, 21630);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,21529,21642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,21529,21642);
}
		}

private void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1591,21929,22343);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,21990,22332) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1591,21990,22332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22037,22064);

f_1591_22037_22063(                _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22084,22114);

f_1591_22084_22113(
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22132,22162);

f_1591_22132_22161(                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22182,22281);

_throttleManager.ThrottleComplete -= new EventHandler<EventArgs>(HandleThrottleDisconnectComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22299,22317);

f_1591_22299_22316(                _stream);
DynAbs.Tracing.TraceSender.TraceExitCondition(1591,21990,22332);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1591,21929,22343);

int
f_1591_22037_22063(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 22037, 22063);
return 0;
}


bool
f_1591_22084_22113(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 22084, 22113);
return return_v;
}


int
f_1591_22132_22161(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 22132, 22161);
return 0;
}


int
f_1591_22299_22316(System.Management.Automation.Internal.ObjectStream
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 22299, 22316);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1591,21929,22343);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,21929,22343);
}
		}

private ThrottleManager _throttleManager ;

private ManualResetEvent _operationsComplete ;

private ObjectStream _stream ;

public DisconnectPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1591,1504,22908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,2157,2591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,4286,4646);
this.ThrottleLimit = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,4833,4884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,5249,5263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22544,22584);
this._throttleManager = f_1591_22563_22584();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22736,22784);
this._operationsComplete = f_1591_22758_22784(true);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1591,22850,22878);
this._stream = f_1591_22860_22878();DynAbs.Tracing.TraceSender.TraceExitConstructor(1591,1504,22908);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,1504,22908);
}


static DisconnectPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1591,1504,22908);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1591,1504,22908);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1591,1504,22908);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1591,1504,22908);

System.Management.Automation.Remoting.ThrottleManager
f_1591_22563_22584()
{
var return_v = new System.Management.Automation.Remoting.ThrottleManager();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 22563, 22584);
return return_v;
}


System.Threading.ManualResetEvent
f_1591_22758_22784(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 22758, 22784);
return return_v;
}


System.Management.Automation.Internal.ObjectStream
f_1591_22860_22878()
{
var return_v = new System.Management.Automation.Internal.ObjectStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1591, 22860, 22878);
return return_v;
}

}
}
