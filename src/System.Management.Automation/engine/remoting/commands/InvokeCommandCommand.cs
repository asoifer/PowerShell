// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsLifecycle.Invoke, "Command", DefaultParameterSetName = InvokeCommandCommand.InProcParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096789", RemotingCapability = RemotingCapability.OwnedByCommand)]
    public class InvokeCommandCommand : PSExecutionCmdlet, IDisposable
{
[Parameter(Position = 0,
                   ParameterSetName = InvokeCommandCommand.SessionParameterSet)]
        [Parameter(Position = 0,
                   ParameterSetName = InvokeCommandCommand.FilePathSessionParameterSet)]
        [ValidateNotNullOrEmpty]
        public override PSSession[] Session
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,7190,7261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,7226,7246);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Session,1595,7233,7245);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,7190,7261);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,6856,7360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,6856,7360);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,7277,7349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,7313,7334);

base.Session = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,7277,7349);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,6856,7360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,6856,7360);
}
		}}

[Parameter(Position = 0,
                   ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(Position = 0,
                   ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Alias("Cn")]
        [ValidateNotNullOrEmpty]
        public override string[] ComputerName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,8081,8157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,8117,8142);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ComputerName,1595,8124,8141);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,8081,8157);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,7712,8261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,7712,8261);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,8173,8250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,8209,8235);

base.ComputerName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,8173,8250);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,7712,8261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,7712,8261);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        [Credential()]
        public override PSCredential Credential
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,9858,9932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,9894,9917);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Credential,1595,9901,9916);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,9858,9932);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,8536,10034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,8536,10034);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,9948,10023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,9984,10008);

base.Credential = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,9948,10023);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,8536,10034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,8536,10034);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [ValidateRange((int)1, (int)UInt16.MaxValue)]
        public override int Port
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,10972,11040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,11008,11025);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Port,1595,11015,11024);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,10972,11040);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,10604,11136);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,10604,11136);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,11056,11125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,11092,11110);

base.Port = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,11056,11125);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,10604,11136);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,10604,11136);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SSL")]
        public override SwitchParameter UseSSL
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,11881,11951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,11917,11936);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.UseSSL,1595,11924,11935);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,11881,11951);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,11526,12049);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,11526,12049);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,11967,12038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,12003,12023);

base.UseSSL = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,11967,12038);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,11526,12049);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,11526,12049);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        public override string ConfigurationName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,14026,14107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,14062,14092);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ConfigurationName,1595,14069,14091);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,14026,14107);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,12499,14216);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,12499,14216);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,14123,14205);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,14159,14190);

base.ConfigurationName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,14123,14205);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,12499,14216);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,12499,14216);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        public override string ApplicationName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,14952,15031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,14988,15016);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ApplicationName,1595,14995,15015);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,14952,15031);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,14587,15138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,14587,15138);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,15047,15127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,15083,15112);

base.ApplicationName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,15047,15127);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,14587,15138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,14587,15138);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        public override int ThrottleLimit
{
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,16472,16550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,16508,16535);

base.ThrottleLimit = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,16472,16550);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,15380,16654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,15380,16654);
}
		}
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,16566,16643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,16602,16628);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ThrottleLimit,1595,16609,16627);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,16566,16643);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,15380,16654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,15380,16654);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[Parameter(Position = 0,
                   ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(Position = 0,
                   ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("URI", "CU")]
        public override Uri[] ConnectionUri
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,17196,17273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,17232,17258);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ConnectionUri,1595,17239,17257);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,17196,17273);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,16840,17378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,16840,17378);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,17289,17367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,17325,17352);

base.ConnectionUri = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,17289,17367);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,16840,17378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,16840,17378);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostHashParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostHashParameterSet)]
        public SwitchParameter AsJob
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,18945,19010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,18981,18995);

return _asjob;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,18945,19010);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,17506,19103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,17506,19103);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,19026,19092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,19062,19077);

_asjob = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,19026,19092);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,17506,19103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,17506,19103);
}
		}}

private bool _asjob ;

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Alias("Disconnected")]
        public SwitchParameter InDisconnectedSession
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,19784,19819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,19790,19817);

return f_1595_19797_19816();
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,19784,19819);

bool
f_1595_19797_19816()
{
var return_v = InvokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 19797, 19816);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,19336,19882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,19336,19882);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,19835,19871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,19841,19869);

InvokeAndDisconnect = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,19835,19871);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,19336,19882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,19336,19882);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] SessionName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,20419,20458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,20425,20456);

return f_1595_20432_20455();
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,20419,20458);

string[]
f_1595_20432_20455()
{
var return_v = DisconnectedSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 20432, 20455);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,20057,20525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,20057,20525);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,20474,20514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,20480,20512);

DisconnectedSessionName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,20474,20514);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,20057,20525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,20057,20525);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostHashParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostHashParameterSet)]
        [Alias("HCN")]
        public SwitchParameter HideComputerName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,22117,22150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,22123,22148);

return _hideComputerName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,22117,22150);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,20643,22211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,20643,22211);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,22166,22200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,22172,22198);

_hideComputerName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,22166,22200);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,20643,22211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,20643,22211);
}
		}}

private bool _hideComputerName;

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostHashParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        public string JobName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,23289,23353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,23325,23338);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,23289,23353);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,22377,23574);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,22377,23574);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,23369,23563);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,23405,23548) || true) && (!f_1595_23410_23437(value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,23405,23548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,23479,23493);

_name = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,23515,23529);

_asjob = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,23405,23548);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,23369,23563);

bool
f_1595_23410_23437(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 23410, 23437);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,22377,23574);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,22377,23574);
}
		}}

private string _name ;

[Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.SessionParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(Position = 0,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.InProcParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = InvokeCommandCommand.SSHHostHashParameterSet)]
        [ValidateNotNull]
        [Alias("Command")]
        public override ScriptBlock ScriptBlock
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,25372,25447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,25408,25432);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ScriptBlock,1595,25415,25431);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,25372,25447);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,23863,25550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,23863,25550);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,25463,25539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,25499,25524);

base.ScriptBlock = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,25463,25539);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,23863,25550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,23863,25550);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.InProcParameterSet)]
        public SwitchParameter NoNewScope {get; set; }

[Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathComputerNameParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathSessionParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathUriParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathVMIdParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathVMNameParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathContainerIdParameterSet)]
        [Parameter(Mandatory = true,
                   ParameterSetName = FilePathSSHHostParameterSet)]
        [Parameter(Mandatory = true,
                   ParameterSetName = FilePathSSHHostHashParameterSet)]
        [ValidateNotNull]
        [Alias("PSPath")]
        public override string FilePath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,27262,27334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,27298,27319);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.FilePath,1595,27305,27318);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,27262,27334);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,26087,27434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,26087,27434);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,27350,27423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,27386,27408);

base.FilePath = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,27350,27423);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,26087,27434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,26087,27434);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        public override SwitchParameter AllowRedirection
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,27822,27902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,27858,27887);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.AllowRedirection,1595,27865,27886);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,27822,27902);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,27585,28010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,27585,28010);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,27918,27999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,27954,27984);

base.AllowRedirection = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,27918,27999);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,27585,28010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,27585,28010);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        public override PSSessionOption SessionOption
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,28646,28723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,28682,28708);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.SessionOption,1595,28689,28707);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,28646,28723);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,28230,28828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,28230,28828);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,28739,28817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,28775,28802);

base.SessionOption = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,28739,28817);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,28230,28828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,28230,28828);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        public override AuthenticationMechanism Authentication
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,29376,29454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,29412,29439);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Authentication,1595,29419,29438);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,29376,29454);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,28951,29560);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,28951,29560);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,29470,29549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,29506,29534);

base.Authentication = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,29470,29549);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,28951,29560);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,28951,29560);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        public override SwitchParameter EnableNetworkAccess
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,30436,30476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,30442,30474);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.EnableNetworkAccess,1595,30449,30473);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,30436,30476);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,30014,30544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,30014,30544);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,30492,30533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,30498,30531);

base.EnableNetworkAccess = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,30492,30533);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,30014,30544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,30014,30544);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        public override SwitchParameter RunAsAdministrator
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,31111,31150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,31117,31148);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.RunAsAdministrator,1595,31124,31147);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,31111,31150);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,30856,31217);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,30856,31217);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,31166,31206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,31172,31204);

base.RunAsAdministrator = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,31166,31206);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,30856,31217);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,30856,31217);
}
		}}

[Parameter(Mandatory = true,
            ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [Parameter(Mandatory = true,
            ParameterSetName = InvokeCommandCommand.FilePathSSHHostParameterSet)]
        [ValidateNotNullOrEmpty()]
        public override string[] HostName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,31691,31720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,31697,31718);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.HostName,1595,31704,31717);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,31691,31720);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,31363,31777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,31363,31777);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,31736,31766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,31742,31764);

base.HostName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,31736,31766);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,31363,31777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,31363,31777);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostParameterSet)]
        [ValidateNotNullOrEmpty()]
        public override string UserName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,32124,32153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,32130,32151);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.UserName,1595,32137,32150);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,32124,32153);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,31860,32210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,31860,32210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,32169,32199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,32175,32197);

base.UserName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,32169,32199);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,31860,32210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,31860,32210);
}
		}}

[Parameter(ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostParameterSet)]
        [ValidateNotNullOrEmpty()]
        [Alias("IdentityFilePath")]
        public override string KeyFilePath
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,32596,32628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,32602,32626);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.KeyFilePath,1595,32609,32625);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,32596,32628);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,32292,32688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,32292,32688);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,32644,32677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,32650,32675);

base.KeyFilePath = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,32644,32677);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,32292,32688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,32292,32688);
}
		}}

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.SSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostParameterSet)]
        [ValidateSet("true")]
        public override SwitchParameter SSHTransport
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,33363,33396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,33369,33394);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.SSHTransport,1595,33376,33393);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,33363,33396);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,33091,33457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,33091,33457);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,33412,33446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,33418,33444);

base.SSHTransport = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,33412,33446);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,33091,33457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,33091,33457);
}
		}}

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.SSHHostHashParameterSet, Mandatory = true)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostHashParameterSet, Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public override Hashtable[] SSHConnection
{            get;
            set;
}

[Parameter(ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSessionParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.SSHHostHashParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostParameterSet)]
        [Parameter(ParameterSetName = InvokeCommandCommand.FilePathSSHHostHashParameterSet)]
        public virtual SwitchParameter RemoteDebug
{            get;
            set;
}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,36109,47290);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,36175,36449) || true) && (f_1595_36179_36203(this)&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 36179, 36213)&&_asjob))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,36175,36449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,36348,36434);

throw f_1595_36354_36433(f_1595_36384_36432());
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,36175,36449);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,36465,36705) || true) && (f_1595_36469_36530(f_1595_36469_36497(f_1595_36469_36481()), nameof(SessionName))&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 36469, 36559)&&f_1595_36534_36559_M(!this.InvokeAndDisconnect)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,36465,36705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,36593,36690);

throw f_1595_36599_36689(f_1595_36629_36688());
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,36465,36705);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,36785,36822);

var 
hostDebugger = f_1595_36804_36821(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,36836,37282) || true) && (hostDebugger == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,36836,37282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,37028,37048);

RemoteDebug = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,36836,37282);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,36836,37282);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,37082,37282) || true) && (f_1595_37086_37124(hostDebugger))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,37082,37282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,37248,37267);

RemoteDebug = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,37082,37282);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,36836,37282);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,37642,40936) || true) && (!_asjob &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 37646, 37818)&&(f_1595_37658_37723(f_1595_37658_37674(), InvokeCommandCommand.SessionParameterSet)||(DynAbs.Tracing.TraceSender.Expression_False(1595, 37658, 37817)||f_1595_37744_37817(f_1595_37744_37760(), InvokeCommandCommand.FilePathSessionParameterSet)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,37642,40936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,37852,37983);

long 
localPipelineId =
f_1595_37896_37982(f_1595_37896_37971(                    ((LocalRunspace)f_1595_37912_37940(f_1595_37912_37924(this)))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,38081,38139);

List<PSSession> 
availableSessions = f_1595_38117_38138()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,38157,40544);
foreach(var session in f_1595_38181_38188_I(f_1595_38181_38188()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,38157,40544);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,38230,40525) || true) && (f_1595_38234_38274(f_1595_38234_38268(f_1595_38234_38250(session)))!= RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,38230,40525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,38405,38610);

string 
msg = f_1595_38418_38609(f_1595_38436_38481(), f_1595_38512_38524(session), f_1595_38526_38544(session), f_1595_38546_38566(session), f_1595_38568_38608(f_1595_38568_38602(f_1595_38568_38584(session))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,38638,38907);

f_1595_38638_38906(this, f_1595_38649_38905(f_1595_38695_38733(msg), "InvokeCommandCommandInvalidSessionState", ErrorCategory.InvalidOperation, session));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,38230,40525);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,38230,40525);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,38957,40525) || true) && (f_1595_38961_38998(f_1595_38961_38977(session))!= RunspaceAvailability.Available)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,38957,40525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,39161,39228);

RemoteRunspace 
remoteRunspace = f_1595_39193_39209(session)as RemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,39254,40373) || true) && ((remoteRunspace != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 39258, 39381)&&                            (f_1595_39316_39351(remoteRunspace)== RunspaceAvailability.Busy) )&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 39258, 39485)&&                            (f_1595_39415_39484(remoteRunspace, this, localPipelineId))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,39254,40373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,39609,39640);

f_1595_39609_39639(                            // Valid steppable pipeline session.
                            availableSessions, session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,39254,40373);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,39254,40373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,39809,40022);

string 
msg = f_1595_39822_40021(f_1595_39840_39892(), f_1595_39927_39939(session), f_1595_39941_39959(session), f_1595_39961_39981(session), f_1595_39983_40020(f_1595_39983_39999(session)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,40054,40346);

f_1595_40054_40345(this, f_1595_40065_40344(f_1595_40115_40153(msg), "InvokeCommandCommandInvalidSessionAvailability", ErrorCategory.InvalidOperation, session));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,39254,40373);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,38957,40525);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,38957,40525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,40471,40502);

f_1595_40471_40501(                        availableSessions, session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,38957,40525);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,38230,40525);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,38157,40544);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,2388);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,2388);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,40564,40758) || true) && (f_1595_40568_40591(availableSessions)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,40564,40758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,40638,40739);

throw f_1595_40644_40738(f_1595_40676_40737(f_1595_40694_40736()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,40564,40758);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,40778,40921) || true) && (f_1595_40782_40805(availableSessions)< f_1595_40808_40822(f_1595_40808_40815()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,40778,40921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,40864,40902);

Session = f_1595_40874_40901(availableSessions);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,40778,40921);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,37642,40936);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,40952,41926) || true) && (f_1595_40956_41020(f_1595_40956_40972(), InvokeCommandCommand.InProcParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,40952,41926);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41054,41189) || true) && (f_1595_41058_41066()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,41054,41189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41116,41170);

ScriptBlock = f_1595_41130_41169(this, f_1595_41153_41161(), false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,41054,41189);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41209,41884) || true) && (f_1595_41213_41245(f_1595_41213_41230(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,41209,41884);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41287,41865) || true) && (!f_1595_41292_41324(f_1595_41292_41303()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,41287,41865);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41434,41526);

_steppablePipeline = f_1595_41455_41525(f_1595_41455_41466(), CommandOrigin.Internal, f_1595_41512_41524());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41556,41587);

f_1595_41556_41586(                            _steppablePipeline, this);
                        }
                        catch (InvalidOperationException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1595,41640,41842);
DynAbs.Tracing.TraceSender.TraceExitCatch(1595,41640,41842);
                            // ignore exception and don't do any streaming if can't convert to steppable pipeline
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,41287,41865);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,41209,41884);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41904,41911);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,40952,41926);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,41942,42735) || true) && (f_1595_41946_41985(f_1595_41967_41984()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,41942,42735);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,42019,42720) || true) && ((f_1595_42024_42040()== InvokeCommandCommand.ComputerNameParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1595, 42023, 42173)||                    (f_1595_42116_42132()== InvokeCommandCommand.UriParameterSet) )||(DynAbs.Tracing.TraceSender.Expression_False(1595, 42023, 42273)||                    (f_1595_42199_42215()== InvokeCommandCommand.FilePathComputerNameParameterSet) )||(DynAbs.Tracing.TraceSender.Expression_False(1595, 42023, 42364)||                    (f_1595_42299_42315()== InvokeCommandCommand.FilePathUriParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,42019,42720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,42469,42508);

ConfigurationName = f_1595_42489_42507(this, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,42019,42720);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,42019,42720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,42668,42701);

ConfigurationName = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,42019,42720);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,41942,42735);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,42751,42774);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1595,42751,42773);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,42846,43015);
foreach(IThrottleOperation operation in f_1595_42887_42897_I(f_1595_42887_42897()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,42846,43015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,42931,43000);

f_1595_42931_42999(                _inputWriters, f_1595_42949_42998(f_1595_42949_42992(((ExecutionCmdletHelper)operation))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,42846,43015);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,170);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,170);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,43470,46226) || true) && (f_1595_43474_43539(f_1595_43474_43490(), InvokeCommandCommand.SessionParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,43470,46226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,43573,43704);

long 
localPipelineId =
f_1595_43617_43703(f_1595_43617_43692(                    ((LocalRunspace)f_1595_43633_43661(f_1595_43633_43645(this)))))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,43722,46211);
foreach(PSSession runspaceInfo in f_1595_43757_43764_I(f_1595_43757_43764()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,43722,46211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,43806,43876);

RemoteRunspace 
remoteRunspace = (RemoteRunspace)f_1595_43854_43875(runspaceInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,43898,46192) || true) && (f_1595_43902_43971(remoteRunspace, this, localPipelineId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,43898,46192);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,44518,45894) || true) && ((f_1595_44523_44535()!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 44522, 44584)&&(f_1595_44549_44578(f_1595_44549_44561())== 1) )&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 44522, 44626)&&(f_1595_44589_44616(f_1595_44589_44601())== false)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,44518,45894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,44684,44817);

PSPrimitiveDictionary 
table = (object)f_1595_44722_44791(f_1595_44722_44757(runspaceInfo), PSVersionInfo.PSVersionTableName)as PSPrimitiveDictionary
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,44847,45867) || true) && (table != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,44847,45867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,44930,45018);

Version 
version = (object)f_1595_44956_45006(table, PSVersionInfo.PSRemotingProtocolVersionName)as Version
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,45054,45836) || true) && (version != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,45054,45836);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,45394,45801) || true) && (version >= RemotingConstants.ProtocolVersionWin8RTM)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,45394,45801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,45604,45627);

_needToCollect = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,45669,45714);

_needToStartSteppablePipelineOnServer = true;
DynAbs.Tracing.TraceSender.TraceBreak(1595,45756,45762);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,45394,45801);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,45054,45836);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,44847,45867);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,44518,45894);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,46043,46065);

_needToCollect = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,46091,46137);

_needToStartSteppablePipelineOnServer = false;
DynAbs.Tracing.TraceSender.TraceBreak(1595,46163,46169);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,43898,46192);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,43722,46211);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,2490);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,2490);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1595,43470,46226);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,46242,47164) || true) && (_needToStartSteppablePipelineOnServer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,46242,47164);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,46377,46923);
foreach(IThrottleOperation operation in f_1595_46418_46428_I(f_1595_46418_46428()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,46377,46923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,46470,46554);

ExecutionCmdletHelperRunspace 
ecHelper = operation as ExecutionCmdletHelperRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,46576,46829) || true) && (ecHelper == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,46576,46829);
DynAbs.Tracing.TraceSender.TraceBreak(1595,46800,46806);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,46576,46829);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,46853,46904);

ecHelper.ShouldUseSteppablePipelineOnServer = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,46377,46923);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,547);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,547);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1595,46242,47164);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,46242,47164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,47112,47149);

_clearInvokeCommandOnRunspace = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,46242,47164);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,47245,47279);

f_1595_47245_47278(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,36109,47290);

bool
f_1595_36179_36203(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.InvokeAndDisconnect ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 36179, 36203);
return return_v;
}


string
f_1595_36384_36432()
{
var return_v = RemotingErrorIdStrings.AsJobAndDisconnectedError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 36384, 36432);
return return_v;
}


System.InvalidOperationException
f_1595_36354_36433(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 36354, 36433);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1595_36469_36481()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 36469, 36481);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1595_36469_36497(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 36469, 36497);
return return_v;
}


bool
f_1595_36469_36530(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 36469, 36530);
return return_v;
}


bool
f_1595_36534_36559_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 36534, 36559);
return return_v;
}


string
f_1595_36629_36688()
{
var return_v = RemotingErrorIdStrings.SessionNameWithoutInvokeDisconnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 36629, 36688);
return return_v;
}


System.InvalidOperationException
f_1595_36599_36689(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 36599, 36689);
return return_v;
}


System.Management.Automation.Debugger
f_1595_36804_36821(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.GetHostDebugger();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 36804, 36821);
return return_v;
}


bool
f_1595_37086_37124(System.Management.Automation.Debugger
this_param)
{
var return_v = this_param.IsDebuggerSteppingEnabled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 37086, 37124);
return return_v;
}


string
f_1595_37658_37674()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 37658, 37674);
return return_v;
}


bool
f_1595_37658_37723(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 37658, 37723);
return return_v;
}


string
f_1595_37744_37760()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 37744, 37760);
return return_v;
}


bool
f_1595_37744_37817(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 37744, 37817);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1595_37912_37924(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 37912, 37924);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_37912_37940(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.CurrentRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 37912, 37940);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1595_37896_37971(System.Management.Automation.Runspaces.LocalRunspace
this_param)
{
var return_v = this_param.GetCurrentlyRunningPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 37896, 37971);
return return_v;
}


long
f_1595_37896_37982(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 37896, 37982);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1595_38117_38138()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 38117, 38138);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_38181_38188()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38181, 38188);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_38234_38250(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38234, 38250);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1595_38234_38268(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38234, 38268);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1595_38234_38274(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38234, 38274);
return return_v;
}


string
f_1595_38436_38481()
{
var return_v = RemotingErrorIdStrings.ICMInvalidSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38436, 38481);
return return_v;
}


string
f_1595_38512_38524(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38512, 38524);
return return_v;
}


System.Guid
f_1595_38526_38544(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38526, 38544);
return return_v;
}


string
f_1595_38546_38566(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38546, 38566);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_38568_38584(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38568, 38584);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1595_38568_38602(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38568, 38602);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1595_38568_38608(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38568, 38608);
return return_v;
}


string
f_1595_38418_38609(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 38418, 38609);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1595_38695_38733(string
message)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 38695, 38733);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1595_38649_38905(System.Management.Automation.Runspaces.InvalidRunspaceStateException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 38649, 38905);
return return_v;
}


int
f_1595_38638_38906(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 38638, 38906);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1595_38961_38977(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38961, 38977);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1595_38961_38998(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 38961, 38998);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_39193_39209(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39193, 39209);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1595_39316_39351(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39316, 39351);
return return_v;
}


bool
f_1595_39415_39484(System.Management.Automation.RemoteRunspace
this_param,Microsoft.PowerShell.Commands.InvokeCommandCommand
invokeCommand,long
localPipelineId)
{
var return_v = this_param.IsAnotherInvokeCommandExecuting( invokeCommand, localPipelineId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 39415, 39484);
return return_v;
}


int
f_1595_39609_39639(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 39609, 39639);
return 0;
}


string
f_1595_39840_39892()
{
var return_v = RemotingErrorIdStrings.ICMInvalidSessionAvailability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39840, 39892);
return return_v;
}


string
f_1595_39927_39939(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39927, 39939);
return return_v;
}


System.Guid
f_1595_39941_39959(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39941, 39959);
return return_v;
}


string
f_1595_39961_39981(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39961, 39981);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_39983_39999(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39983, 39999);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1595_39983_40020(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceAvailability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 39983, 40020);
return return_v;
}


string
f_1595_39822_40021(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 39822, 40021);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1595_40115_40153(string
message)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40115, 40153);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1595_40065_40344(System.Management.Automation.Runspaces.InvalidRunspaceStateException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40065, 40344);
return return_v;
}


int
f_1595_40054_40345(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40054, 40345);
return 0;
}


int
f_1595_40471_40501(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40471, 40501);
return 0;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_38181_38188_I(System.Management.Automation.Runspaces.PSSession[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 38181, 38188);
return return_v;
}


int
f_1595_40568_40591(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 40568, 40591);
return return_v;
}


string
f_1595_40694_40736()
{
var return_v = RemotingErrorIdStrings.ICMNoValidRunspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 40694, 40736);
return return_v;
}


string
f_1595_40676_40737(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40676, 40737);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1595_40644_40738(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40644, 40738);
return return_v;
}


int
f_1595_40782_40805(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 40782, 40805);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_40808_40815()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 40808, 40815);
return return_v;
}


int
f_1595_40808_40822(System.Management.Automation.Runspaces.PSSession[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 40808, 40822);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_40874_40901(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40874, 40901);
return return_v;
}


string
f_1595_40956_40972()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 40956, 40972);
return return_v;
}


bool
f_1595_40956_41020(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 40956, 41020);
return return_v;
}


string
f_1595_41058_41066()
{
var return_v = FilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41058, 41066);
return return_v;
}


string
f_1595_41153_41161()
{
var return_v = FilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41153, 41161);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1595_41130_41169(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,string
filePath,bool
isLiteralPath)
{
var return_v = this_param.GetScriptBlockFromFile( filePath, isLiteralPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 41130, 41169);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1595_41213_41230(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41213, 41230);
return return_v;
}


bool
f_1595_41213_41245(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.ExpectingInput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41213, 41245);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1595_41292_41303()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41292, 41303);
return return_v;
}


bool
f_1595_41292_41324(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.IsUsingDollarInput();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 41292, 41324);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1595_41455_41466()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41455, 41466);
return return_v;
}


object[]
f_1595_41512_41524()
{
var return_v = ArgumentList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41512, 41524);
return return_v;
}


System.Management.Automation.SteppablePipeline
f_1595_41455_41525(System.Management.Automation.ScriptBlock
this_param,System.Management.Automation.CommandOrigin
commandOrigin,object[]
args)
{
var return_v = this_param.GetSteppablePipeline( commandOrigin, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 41455, 41525);
return return_v;
}


int
f_1595_41556_41586(System.Management.Automation.SteppablePipeline
this_param,Microsoft.PowerShell.Commands.InvokeCommandCommand
command)
{
this_param.Begin( (System.Management.Automation.Internal.InternalCommand)command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 41556, 41586);
return 0;
}


string
f_1595_41967_41984()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 41967, 41984);
return return_v;
}


bool
f_1595_41946_41985(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 41946, 41985);
return return_v;
}


string
f_1595_42024_42040()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 42024, 42040);
return return_v;
}


string
f_1595_42116_42132()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 42116, 42132);
return return_v;
}


string
f_1595_42199_42215()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 42199, 42215);
return return_v;
}


string
f_1595_42299_42315()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 42299, 42315);
return return_v;
}


string
f_1595_42489_42507(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,string
shell)
{
var return_v = this_param.ResolveShell( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 42489, 42507);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_42887_42897()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 42887, 42897);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1595_42949_42992(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 42949, 42992);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1595_42949_42998(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Input;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 42949, 42998);
return return_v;
}


int
f_1595_42931_42999(System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
this_param,System.Management.Automation.Runspaces.PipelineWriter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 42931, 42999);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_42887_42897_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 42887, 42897);
return return_v;
}


string
f_1595_43474_43490()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 43474, 43490);
return return_v;
}


bool
f_1595_43474_43539(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 43474, 43539);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1595_43633_43645(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 43633, 43645);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_43633_43661(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.CurrentRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 43633, 43661);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1595_43617_43692(System.Management.Automation.Runspaces.LocalRunspace
this_param)
{
var return_v = this_param.GetCurrentlyRunningPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 43617, 43692);
return return_v;
}


long
f_1595_43617_43703(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 43617, 43703);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_43757_43764()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 43757, 43764);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_43854_43875(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 43854, 43875);
return return_v;
}


bool
f_1595_43902_43971(System.Management.Automation.RemoteRunspace
this_param,Microsoft.PowerShell.Commands.InvokeCommandCommand
invokeCommand,long
localPipelineId)
{
var return_v = this_param.IsAnotherInvokeCommandExecuting( invokeCommand, localPipelineId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 43902, 43971);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1595_44523_44535()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44523, 44535);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1595_44549_44561()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44549, 44561);
return return_v;
}


int
f_1595_44549_44578(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.PipelinePosition ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44549, 44578);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1595_44589_44601()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44589, 44601);
return return_v;
}


bool
f_1595_44589_44616(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.ExpectingInput ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44589, 44616);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1595_44722_44757(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ApplicationPrivateData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44722, 44757);
return return_v;
}


object
f_1595_44722_44791(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44722, 44791);
return return_v;
}


object
f_1595_44956_45006(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 44956, 45006);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_43757_43764_I(System.Management.Automation.Runspaces.PSSession[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 43757, 43764);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_46418_46428()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 46418, 46428);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_46418_46428_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 46418, 46428);
return return_v;
}


int
f_1595_47245_47278(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.DetermineThrowStatementBehavior();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 47245, 47278);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,36109,47290);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,36109,47290);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,47686,53448);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,47912,52546) || true) && (!_pipelineinvoked &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 47916, 47952)&&!_needToCollect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,47912,52546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,47986,48010);

_pipelineinvoked = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,48030,48201) || true) && (f_1595_48034_48045()== f_1595_48049_48069())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,48030,48201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,48111,48134);

f_1595_48111_48133(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,48156,48182);

_inputStreamClosed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,48030,48201);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,48221,52531) || true) && (!f_1595_48226_48269(f_1595_48226_48242(), InProcParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,48221,52531);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,48483,52512) || true) && (!_asjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,48483,52512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,48544,48566);

f_1595_48544_48565(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,48483,52512);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,48483,52512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,48664,52489);

switch (f_1595_48672_48688())
                        {

case InvokeCommandCommand.ComputerNameParameterSet:
                            case InvokeCommandCommand.FilePathComputerNameParameterSet:
                            case InvokeCommandCommand.VMIdParameterSet:
                            case InvokeCommandCommand.VMNameParameterSet:
                            case InvokeCommandCommand.ContainerIdParameterSet:
                            case InvokeCommandCommand.FilePathVMIdParameterSet:
                            case InvokeCommandCommand.FilePathVMNameParameterSet:
                            case InvokeCommandCommand.FilePathContainerIdParameterSet:
                            case InvokeCommandCommand.SSHHostParameterSet:
                            case InvokeCommandCommand.FilePathSSHHostParameterSet:
                            case InvokeCommandCommand.SSHHostHashParameterSet:
                            case InvokeCommandCommand.FilePathSSHHostHashParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,48664,52489);
                                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,49767,50405) || true) && (f_1595_49771_49799(f_1595_49771_49792())!= 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 49771, 49828)&&f_1595_49808_49824(f_1595_49808_49818())> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,49767,50405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,49910,50078);

PSRemotingJob 
job = f_1595_49930_50077(f_1595_49948_49969(), f_1595_49971_49981(), f_1595_50032_50054(f_1595_50032_50043()), f_1595_50056_50069(), _name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,50120,50154);

job.PSJobTypeName = RemoteJobType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,50196,50237);

job.HideComputerName = _hideComputerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,50279,50307);

f_1595_50279_50306(f_1595_50279_50297(this), job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,50349,50366);

f_1595_50349_50365(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,49767,50405);
}
                                }
DynAbs.Tracing.TraceSender.TraceBreak(1595,50476,50482);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,48664,52489);

case InvokeCommandCommand.SessionParameterSet:
                            case InvokeCommandCommand.FilePathSessionParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,48664,52489);
                                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,50717,50867);

PSRemotingJob 
job = f_1595_50737_50866(f_1595_50755_50762(), f_1595_50764_50774(), f_1595_50821_50843(f_1595_50821_50832()), f_1595_50845_50858(), _name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,50905,50939);

job.PSJobTypeName = RemoteJobType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,50977,51018);

job.HideComputerName = _hideComputerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51056,51084);

f_1595_51056_51083(f_1595_51056_51074(this), job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51122,51139);

f_1595_51122_51138(this, job);
                                }
DynAbs.Tracing.TraceSender.TraceBreak(1595,51210,51216);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,48664,52489);

case InvokeCommandCommand.UriParameterSet:
                            case InvokeCommandCommand.FilePathUriParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,48664,52489);
                                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51443,52385) || true) && (f_1595_51447_51463(f_1595_51447_51457())> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,51443,52385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51549,51603);

string[] 
locations = new string[f_1595_51581_51601(f_1595_51581_51594())]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51654,51659);
                                        for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51645,51862) || true) && (i < f_1595_51665_51681(locations))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51683,51686)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1595,51645,51862))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,51645,51862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51776,51819);

locations[i] = f_1595_51791_51818(f_1595_51791_51804()[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,218);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,218);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,51906,52058);

PSRemotingJob 
job = f_1595_51926_52057(locations, f_1595_51955_51965(), f_1595_52012_52034(f_1595_52012_52023()), f_1595_52036_52049(), _name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52100,52134);

job.PSJobTypeName = RemoteJobType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52176,52217);

job.HideComputerName = _hideComputerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52259,52287);

f_1595_52259_52286(f_1595_52259_52277(this), job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52329,52346);

f_1595_52329_52345(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,51443,52385);
}
                                }
DynAbs.Tracing.TraceSender.TraceBreak(1595,52456,52462);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,48664,52489);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,48483,52512);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,48221,52531);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,47912,52546);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52562,53437) || true) && (f_1595_52566_52577()!= f_1595_52581_52601()&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 52566, 52624)&&!_inputStreamClosed))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,52562,53437);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52658,53422) || true) && ((f_1595_52663_52727(f_1595_52663_52679(), InvokeCommandCommand.InProcParameterSet)&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 52663, 52759)&&(_steppablePipeline == null))) ||(DynAbs.Tracing.TraceSender.Expression_False(1595, 52662, 52799)||                    _needToCollect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,52658,53422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52841,52865);

f_1595_52841_52864(                    _input, f_1595_52852_52863());
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,52658,53422);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,52658,53422);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,52907,53422) || true) && (f_1595_52911_52975(f_1595_52911_52927(), InvokeCommandCommand.InProcParameterSet)&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 52911, 53007)&&(_steppablePipeline != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,52907,53422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53049,53089);

f_1595_53049_53088(                    _steppablePipeline, f_1595_53076_53087());
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,52907,53422);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,52907,53422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53171,53195);

f_1595_53171_53194(this, f_1595_53182_53193());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53297,53403) || true) && (!_asjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,53297,53403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53358,53380);

f_1595_53358_53379(this, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,53297,53403);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,52907,53422);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,52658,53422);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,52562,53437);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,47686,53448);

System.Management.Automation.PSObject
f_1595_48034_48045()
{
var return_v = InputObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 48034, 48045);
return return_v;
}


System.Management.Automation.PSObject
f_1595_48049_48069()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 48049, 48069);
return return_v;
}


int
f_1595_48111_48133(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.CloseAllInputStreams();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 48111, 48133);
return 0;
}


string
f_1595_48226_48242()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 48226, 48242);
return return_v;
}


bool
f_1595_48226_48269(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 48226, 48269);
return return_v;
}


int
f_1595_48544_48565(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.CreateAndRunSyncJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 48544, 48565);
return 0;
}


string
f_1595_48672_48688()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 48672, 48688);
return return_v;
}


string[]
f_1595_49771_49792()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 49771, 49792);
return return_v;
}


int
f_1595_49771_49799(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 49771, 49799);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_49808_49818()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 49808, 49818);
return return_v;
}


int
f_1595_49808_49824(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 49808, 49824);
return return_v;
}


string[]
f_1595_49948_49969()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 49948, 49969);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_49971_49981()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 49971, 49981);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1595_50032_50043()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 50032, 50043);
return return_v;
}


string
f_1595_50032_50054(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 50032, 50054);
return return_v;
}


int
f_1595_50056_50069()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 50056, 50069);
return return_v;
}


System.Management.Automation.PSRemotingJob
f_1595_49930_50077(string[]
computerNames,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
computerNameHelpers,string
remoteCommand,int
throttleLimit,string
name)
{
var return_v = new System.Management.Automation.PSRemotingJob( computerNames, computerNameHelpers, remoteCommand, throttleLimit, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 49930, 50077);
return return_v;
}


System.Management.Automation.JobRepository
f_1595_50279_50297(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 50279, 50297);
return return_v;
}


int
f_1595_50279_50306(System.Management.Automation.JobRepository
this_param,System.Management.Automation.PSRemotingJob
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 50279, 50306);
return 0;
}


int
f_1595_50349_50365(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.PSRemotingJob
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 50349, 50365);
return 0;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_50755_50762()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 50755, 50762);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_50764_50774()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 50764, 50774);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1595_50821_50832()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 50821, 50832);
return return_v;
}


string
f_1595_50821_50843(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 50821, 50843);
return return_v;
}


int
f_1595_50845_50858()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 50845, 50858);
return return_v;
}


System.Management.Automation.PSRemotingJob
f_1595_50737_50866(System.Management.Automation.Runspaces.PSSession[]
remoteRunspaceInfos,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
runspaceHelpers,string
remoteCommand,int
throttleLimit,string
name)
{
var return_v = new System.Management.Automation.PSRemotingJob( remoteRunspaceInfos, runspaceHelpers, remoteCommand, throttleLimit, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 50737, 50866);
return return_v;
}


System.Management.Automation.JobRepository
f_1595_51056_51074(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51056, 51074);
return return_v;
}


int
f_1595_51056_51083(System.Management.Automation.JobRepository
this_param,System.Management.Automation.PSRemotingJob
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 51056, 51083);
return 0;
}


int
f_1595_51122_51138(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.PSRemotingJob
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 51122, 51138);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_51447_51457()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51447, 51457);
return return_v;
}


int
f_1595_51447_51463(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51447, 51463);
return return_v;
}


System.Uri[]
f_1595_51581_51594()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51581, 51594);
return return_v;
}


int
f_1595_51581_51601(System.Uri[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51581, 51601);
return return_v;
}


int
f_1595_51665_51681(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51665, 51681);
return return_v;
}


System.Uri[]
f_1595_51791_51804()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51791, 51804);
return return_v;
}


string
f_1595_51791_51818(System.Uri
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 51791, 51818);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_51955_51965()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 51955, 51965);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1595_52012_52023()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52012, 52023);
return return_v;
}


string
f_1595_52012_52034(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 52012, 52034);
return return_v;
}


int
f_1595_52036_52049()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52036, 52049);
return return_v;
}


System.Management.Automation.PSRemotingJob
f_1595_51926_52057(string[]
computerNames,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
computerNameHelpers,string
remoteCommand,int
throttleLimit,string
name)
{
var return_v = new System.Management.Automation.PSRemotingJob( computerNames, computerNameHelpers, remoteCommand, throttleLimit, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 51926, 52057);
return return_v;
}


System.Management.Automation.JobRepository
f_1595_52259_52277(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52259, 52277);
return return_v;
}


int
f_1595_52259_52286(System.Management.Automation.JobRepository
this_param,System.Management.Automation.PSRemotingJob
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 52259, 52286);
return 0;
}


int
f_1595_52329_52345(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.PSRemotingJob
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 52329, 52345);
return 0;
}


System.Management.Automation.PSObject
f_1595_52566_52577()
{
var return_v = InputObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52566, 52577);
return return_v;
}


System.Management.Automation.PSObject
f_1595_52581_52601()
{
var return_v = AutomationNull.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52581, 52601);
return return_v;
}


string
f_1595_52663_52679()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52663, 52679);
return return_v;
}


bool
f_1595_52663_52727(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 52663, 52727);
return return_v;
}


System.Management.Automation.PSObject
f_1595_52852_52863()
{
var return_v = InputObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52852, 52863);
return return_v;
}


int
f_1595_52841_52864(System.Management.Automation.PSDataCollection<object>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( (object)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 52841, 52864);
return 0;
}


string
f_1595_52911_52927()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 52911, 52927);
return return_v;
}


bool
f_1595_52911_52975(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 52911, 52975);
return return_v;
}


System.Management.Automation.PSObject
f_1595_53076_53087()
{
var return_v = InputObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 53076, 53087);
return return_v;
}


System.Array
f_1595_53049_53088(System.Management.Automation.SteppablePipeline
this_param,System.Management.Automation.PSObject
input)
{
var return_v = this_param.Process( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 53049, 53088);
return return_v;
}


System.Management.Automation.PSObject
f_1595_53182_53193()
{
var return_v = InputObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 53182, 53193);
return return_v;
}


int
f_1595_53171_53194(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.PSObject
inputValue)
{
this_param.WriteInput( (object)inputValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 53171, 53194);
return 0;
}


int
f_1595_53358_53379(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,bool
nonblocking)
{
this_param.WriteJobResults( nonblocking);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 53358, 53379);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,47686,53448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,47686,53448);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,53637,58623);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53761,53852) || true) && (!_needToCollect)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,53761,53852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53814,53837);

f_1595_53814_53836(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,53761,53852);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53868,58612) || true) && (!_asjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,53868,58612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,53913,58597) || true) && (f_1595_53917_53981(f_1595_53917_53933(), InvokeCommandCommand.InProcParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,53913,58597);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,54023,54718) || true) && (_steppablePipeline != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,54023,54718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,54103,54128);

f_1595_54103_54127(                        _steppablePipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,54023,54718);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,54023,54718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,54226,54695);

f_1595_54226_54694(f_1595_54226_54237(), contextCmdlet: this, useLocalScope: f_1595_54351_54362_M(!NoNewScope), errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1595_54517_54537(), input: _input, scriptThis: f_1595_54624_54644(), args: f_1595_54681_54693());
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,54023,54718);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,53913,58597);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,53913,58597);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,54865,58578) || true) && (_job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,54865,58578);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,55142,55393) || true) && (f_1595_55146_55165())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,55142,55393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,55296,55329);

f_1595_55296_55328(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,55359,55366);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,55142,55393);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,55709,55732);

f_1595_55709_55731(this, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,55813,55828);

f_1595_55813_55827(
                        // finally dispose the job.
                        _job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,54865,58578);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,54865,58578);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,56325,58555) || true) && (_needToCollect &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 56329, 56412)&&f_1595_56347_56412(f_1595_56347_56363(), InvokeCommandCommand.SessionParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,56325,58555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,56887,56971);

f_1595_56887_56970(_needToCollect, "InvokeCommand should have collected input before this");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,57001,57159);

f_1595_57001_57158(f_1595_57012_57077(f_1595_57012_57028(), InvokeCommandCommand.SessionParameterSet), "Collecting and invoking should happen only in case of Runspace parameter set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,57191,57213);

f_1595_57191_57212(this);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,57310,57466);
foreach(object inputValue in f_1595_57340_57346_I(_input) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,57310,57466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,57412,57435);

f_1595_57412_57434(this, inputValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,57310,57466);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,157);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,157);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,57498,57521);

f_1595_57498_57520(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,57772,58043) || true) && (f_1595_57776_57795())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,57772,58043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,57938,57971);

f_1595_57938_57970(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,58005,58012);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,57772,58043);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,58401,58424);

f_1595_58401_58423(this, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,58513,58528);

f_1595_58513_58527(
                            // finally dispose the job.
                            _job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,56325,58555);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,54865,58578);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,53913,58597);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,53868,58612);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,53637,58623);

int
f_1595_53814_53836(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.CloseAllInputStreams();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 53814, 53836);
return 0;
}


string
f_1595_53917_53933()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 53917, 53933);
return return_v;
}


bool
f_1595_53917_53981(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 53917, 53981);
return return_v;
}


System.Array
f_1595_54103_54127(System.Management.Automation.SteppablePipeline
this_param)
{
var return_v = this_param.End();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 54103, 54127);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1595_54226_54237()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 54226, 54237);
return return_v;
}


bool
f_1595_54351_54362_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 54351, 54362);
return return_v;
}


System.Management.Automation.PSObject
f_1595_54517_54537()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 54517, 54537);
return return_v;
}


System.Management.Automation.PSObject
f_1595_54624_54644()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 54624, 54644);
return return_v;
}


object[]
f_1595_54681_54693()
{
var return_v = ArgumentList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 54681, 54693);
return return_v;
}


int
f_1595_54226_54694(System.Management.Automation.ScriptBlock
this_param,Microsoft.PowerShell.Commands.InvokeCommandCommand
contextCmdlet,bool
useLocalScope,System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
errorHandlingBehavior,System.Management.Automation.PSObject
dollarUnder,System.Management.Automation.PSDataCollection<object>
input,System.Management.Automation.PSObject
scriptThis,object[]
args)
{
this_param.InvokeUsingCmdlet( contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 54226, 54694);
return 0;
}


bool
f_1595_55146_55165()
{
var return_v = InvokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 55146, 55165);
return return_v;
}


int
f_1595_55296_55328(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.WaitForDisconnectAndDisposeJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 55296, 55328);
return 0;
}


int
f_1595_55709_55731(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,bool
nonblocking)
{
this_param.WriteJobResults( nonblocking);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 55709, 55731);
return 0;
}


int
f_1595_55813_55827(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 55813, 55827);
return 0;
}


string
f_1595_56347_56363()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 56347, 56363);
return return_v;
}


bool
f_1595_56347_56412(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 56347, 56412);
return return_v;
}


int
f_1595_56887_56970(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 56887, 56970);
return 0;
}


string
f_1595_57012_57028()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 57012, 57028);
return return_v;
}


bool
f_1595_57012_57077(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 57012, 57077);
return return_v;
}


int
f_1595_57001_57158(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 57001, 57158);
return 0;
}


int
f_1595_57191_57212(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.CreateAndRunSyncJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 57191, 57212);
return 0;
}


int
f_1595_57412_57434(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,object
inputValue)
{
this_param.WriteInput( inputValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 57412, 57434);
return 0;
}


System.Management.Automation.PSDataCollection<object>
f_1595_57340_57346_I(System.Management.Automation.PSDataCollection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 57340, 57346);
return return_v;
}


int
f_1595_57498_57520(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.CloseAllInputStreams();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 57498, 57520);
return 0;
}


bool
f_1595_57776_57795()
{
var return_v = InvokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 57776, 57795);
return return_v;
}


int
f_1595_57938_57970(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.WaitForDisconnectAndDisposeJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 57938, 57970);
return 0;
}


int
f_1595_58401_58423(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,bool
nonblocking)
{
this_param.WriteJobResults( nonblocking);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 58401, 58423);
return 0;
}


int
f_1595_58513_58527(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 58513, 58527);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,53637,58623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,53637,58623);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,59167,60778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,59299,59336);

var 
hostDebugger = f_1595_59318_59335(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,59350,59581) || true) && (hostDebugger != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,59350,59581);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,59452,59492);

f_1595_59452_59491(                    hostDebugger);
                }
                catch (PSNotImplementedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1595,59529,59566);
DynAbs.Tracing.TraceSender.TraceExitCatch(1595,59529,59566);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,59350,59581);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,59597,60767) || true) && (!f_1595_59602_59666(f_1595_59602_59618(), InvokeCommandCommand.InProcParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,59597,60767);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,59700,60752) || true) && (!_asjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,59700,60752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,59985,60006);

bool 
stopjob = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60034,60048);
                    lock (_jobSyncObject)
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60098,60485) || true) && (_job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,60098,60485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60172,60187);

stopjob = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,60098,60485);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,60098,60485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60444,60458);

_nojob = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,60098,60485);
}
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60532,60631) || true) && (stopjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,60532,60631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60593,60608);

f_1595_60593_60607(                        _job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,60532,60631);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60710,60733);

_needToCollect = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,59700,60752);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,59597,60767);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,59167,60778);

System.Management.Automation.Debugger
f_1595_59318_59335(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.GetHostDebugger();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 59318, 59335);
return return_v;
}


int
f_1595_59452_59491(System.Management.Automation.Debugger
this_param)
{
this_param.CancelDebuggerProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 59452, 59491);
return 0;
}


string
f_1595_59602_59618()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 59602, 59618);
return return_v;
}


bool
f_1595_59602_59666(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 59602, 59666);
return return_v;
}


int
f_1595_60593_60607(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 60593, 60607);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,59167,60778);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,59167,60778);
}
		}

private Debugger GetHostDebugger()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,60857,61319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60916,60945);

Debugger 
hostDebugger = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,60995,61149);

System.Management.Automation.Internal.Host.InternalHost 
chost =
f_1595_61080_61089(this)as System.Management.Automation.Internal.Host.InternalHost
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,61167,61206);

hostDebugger = f_1595_61182_61205(f_1595_61182_61196(chost));
            }
            catch (PSNotImplementedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1595,61235,61272);
DynAbs.Tracing.TraceSender.TraceExitCatch(1595,61235,61272);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,61288,61308);

return hostDebugger;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,60857,61319);

System.Management.Automation.Host.PSHost
f_1595_61080_61089(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 61080, 61089);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_61182_61196(System.Management.Automation.Internal.Host.InternalHost
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 61182, 61196);
return return_v;
}


System.Management.Automation.Debugger
f_1595_61182_61205(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 61182, 61205);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,60857,61319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,60857,61319);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandleThrottleComplete(object sender, EventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,61577,61813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,61673,61699);

f_1595_61673_61698(            _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,61713,61802);

_throttleManager.ThrottleComplete -= new EventHandler<EventArgs>(HandleThrottleComplete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,61577,61813);

bool
f_1595_61673_61698(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 61673, 61698);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,61577,61813);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,61577,61813);
}
		}

private void ClearInvokeCommandOnRunspaces()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,61967,62396);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62036,62385) || true) && (f_1595_62040_62105(f_1595_62040_62056(), InvokeCommandCommand.SessionParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,62036,62385);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62139,62370);
foreach(PSSession runspaceInfo in f_1595_62174_62181_I(f_1595_62174_62181()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,62139,62370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62223,62293);

RemoteRunspace 
remoteRunspace = (RemoteRunspace)f_1595_62271_62292(runspaceInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62315,62351);

f_1595_62315_62350(                    remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,62139,62370);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,232);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,232);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1595,62036,62385);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,61967,62396);

string
f_1595_62040_62056()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 62040, 62056);
return return_v;
}


bool
f_1595_62040_62105(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 62040, 62105);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_62174_62181()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 62174, 62181);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_62271_62292(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 62271, 62292);
return return_v;
}


int
f_1595_62315_62350(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.ClearInvokeCommand();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 62315, 62350);
return 0;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_62174_62181_I(System.Management.Automation.Runspaces.PSSession[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 62174, 62181);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,61967,62396);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,61967,62396);
}
		}

private void CreateAndRunSyncJob()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,62568,64130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62633,62647);
            lock (_jobSyncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62681,64104) || true) && (!_nojob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,62681,64104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62734,62781);

_throttleManager.ThrottleLimit = f_1595_62767_62780();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62803,62892);

_throttleManager.ThrottleComplete += new EventHandler<EventArgs>(HandleThrottleComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62916,62944);

f_1595_62916_62943(
                    _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,62966,63060);

f_1595_62966_63059(_disconnectComplete == null, "disconnectComplete event should only be used once.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63082,63132);

_disconnectComplete = f_1595_63104_63131(false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63154,63221);

_job = f_1595_63161_63220(f_1595_63191_63201(), _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63243,63285);

_job.HideComputerName = _hideComputerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63307,63387);

_job.StateChanged += new EventHandler<JobStateEventArgs>(HandleJobStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63485,63517);

f_1595_63485_63516(this, _job);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63719,64028);
foreach(var operation in f_1595_63745_63755_I(f_1595_63745_63755()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,63719,64028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63805,63847);

operation.RunspaceDebuggingEnabled = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63873,63924);

operation.RunspaceDebugStepInEnabled = f_1595_63912_63923();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,63950,64005);

operation.RunspaceDebugStop += HandleRunspaceDebugStop;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,63719,64028);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,310);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,310);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64052,64085);

f_1595_64052_64084(
                    _job, f_1595_64073_64083());
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,62681,64104);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,62568,64130);

int
f_1595_62767_62780()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 62767, 62780);
return return_v;
}


bool
f_1595_62916_62943(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 62916, 62943);
return return_v;
}


int
f_1595_62966_63059(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 62966, 63059);
return 0;
}


System.Threading.ManualResetEvent
f_1595_63104_63131(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 63104, 63131);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_63191_63201()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 63191, 63201);
return return_v;
}


System.Management.Automation.PSInvokeExpressionSyncJob
f_1595_63161_63220(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
operations,System.Management.Automation.Remoting.ThrottleManager
throttleManager)
{
var return_v = new System.Management.Automation.PSInvokeExpressionSyncJob( operations, throttleManager);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 63161, 63220);
return return_v;
}


int
f_1595_63485_63516(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.PSInvokeExpressionSyncJob
job)
{
this_param.AddConnectionRetryHandler( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 63485, 63516);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_63745_63755()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 63745, 63755);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1595_63912_63923()
{
var return_v = RemoteDebug;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 63912, 63923);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_63745_63755_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 63745, 63755);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1595_64073_64083()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 64073, 64083);
return return_v;
}


int
f_1595_64052_64084(System.Management.Automation.PSInvokeExpressionSyncJob
this_param,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
operations)
{
this_param.StartOperations( operations);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 64052, 64084);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,62568,64130);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,62568,64130);
}
		}

private void HandleRunspaceDebugStop(object sender, StartRunspaceDebugProcessingEventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,64142,64577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64262,64307);

var 
operation = sender as IThrottleOperation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64321,64376);

operation.RunspaceDebugStop -= HandleRunspaceDebugStop;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64392,64429);

var 
hostDebugger = f_1595_64411_64428(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64443,64566) || true) && (hostDebugger != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,64443,64566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64501,64551);

f_1595_64501_64550(                hostDebugger, f_1595_64536_64549(args));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,64443,64566);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,64142,64577);

System.Management.Automation.Debugger
f_1595_64411_64428(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.GetHostDebugger();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 64411, 64428);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_64536_64549(System.Management.Automation.StartRunspaceDebugProcessingEventArgs
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 64536, 64549);
return return_v;
}


int
f_1595_64501_64550(System.Management.Automation.Debugger
this_param,System.Management.Automation.Runspaces.Runspace
runspace)
{
this_param.QueueRunspaceForDebug( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 64501, 64550);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,64142,64577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,64142,64577);
}
		}

private void HandleJobStateChanged(object sender, JobStateEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,64589,65442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64684,64722);

JobState 
state = f_1595_64701_64721(f_1595_64701_64715(e))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64736,65431) || true) && (state == JobState.Disconnected ||(DynAbs.Tracing.TraceSender.Expression_False(1595, 64740, 64818)||                state == JobState.Completed )||(DynAbs.Tracing.TraceSender.Expression_False(1595, 64740, 64864)||                state == JobState.Stopped )||(DynAbs.Tracing.TraceSender.Expression_False(1595, 64740, 64909)||                state == JobState.Failed))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,64736,65431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,64943,65023);

_job.StateChanged -= new EventHandler<JobStateEventArgs>(HandleJobStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65041,65107);

f_1595_65041_65106(this, sender as PSInvokeExpressionSyncJob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65211,65225);

                // Signal that this job has been disconnected, or has ended.
                lock (_jobSyncObject)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65267,65397) || true) && (_disconnectComplete != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,65267,65397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65348,65374);

f_1595_65348_65373(                        _disconnectComplete);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,65267,65397);
}
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,64736,65431);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,64589,65442);

System.Management.Automation.JobStateInfo
f_1595_64701_64715(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 64701, 64715);
return return_v;
}


System.Management.Automation.JobState
f_1595_64701_64721(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 64701, 64721);
return return_v;
}


int
f_1595_65041_65106(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,object
job)
{
this_param.RemoveConnectionRetryHandler( (System.Management.Automation.PSInvokeExpressionSyncJob)job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 65041, 65106);
return 0;
}


bool
f_1595_65348_65373(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 65348, 65373);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,64589,65442);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,64589,65442);
}
		}

private void AddConnectionRetryHandler(PSInvokeExpressionSyncJob job)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,65454,66075);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65548,65619) || true) && (job == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,65548,65619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65597,65604);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,65548,65619);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65635,65722);

Collection<System.Management.Automation.PowerShell> 
powershells = f_1595_65701_65721(job)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65736,66064);
foreach(var ps in f_1595_65755_65766_I(powershells) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,65736,66064);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65800,66049) || true) && (f_1595_65804_65823(ps)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,65800,66049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,65873,66030);

f_1595_65873_65892(ps).RCConnectionNotification +=
                        new EventHandler<PSConnectionRetryStatusEventArgs>(RCConnectionNotificationHandler);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,65800,66049);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,65736,66064);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,329);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,329);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1595,65454,66075);

System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_65701_65721(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.GetPowerShells();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 65701, 65721);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_65804_65823(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 65804, 65823);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_65873_65892(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 65873, 65892);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_65755_65766_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 65755, 65766);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,65454,66075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,65454,66075);
}
		}

private void RemoveConnectionRetryHandler(PSInvokeExpressionSyncJob job)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,66087,66794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66232,66251);

f_1595_66232_66250(this, 0);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66267,66338) || true) && (job == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,66267,66338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66316,66323);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,66267,66338);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66354,66441);

Collection<System.Management.Automation.PowerShell> 
powershells = f_1595_66420_66440(job)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66455,66783);
foreach(var ps in f_1595_66474_66485_I(powershells) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,66455,66783);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66519,66768) || true) && (f_1595_66523_66542(ps)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,66519,66768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66592,66749);

f_1595_66592_66611(ps).RCConnectionNotification -=
                        new EventHandler<PSConnectionRetryStatusEventArgs>(RCConnectionNotificationHandler);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,66519,66768);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,66455,66783);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,329);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,329);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1595,66087,66794);

int
f_1595_66232_66250(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,int
sourceId)
{
this_param.StopProgressBar( (long)sourceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 66232, 66250);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_66420_66440(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.GetPowerShells();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 66420, 66440);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_66523_66542(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 66523, 66542);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_66592_66611(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 66592, 66611);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_66474_66485_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 66474, 66485);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,66087,66794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,66087,66794);
}
		}

private void RCConnectionNotificationHandler(object sender, PSConnectionRetryStatusEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,66806,67539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,66967,67528);

switch (f_1595_66975_66989(e))
            {

case PSConnectionRetryStatus.NetworkFailureDetected:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,66967,67528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,67097,67187);

f_1595_67097_67186(this, f_1595_67114_67134(sender), f_1595_67136_67150(e), (f_1595_67153_67177(e)/ 1000));
DynAbs.Tracing.TraceSender.TraceBreak(1595,67209,67215);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,66967,67528);

case PSConnectionRetryStatus.ConnectionRetrySucceeded:
                case PSConnectionRetryStatus.AutoDisconnectStarting:
                case PSConnectionRetryStatus.InternalErrorAbort:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,66967,67528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,67447,67485);

f_1595_67447_67484(this, f_1595_67463_67483(sender));
DynAbs.Tracing.TraceSender.TraceBreak(1595,67507,67513);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,66967,67528);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,66806,67539);

System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
f_1595_66975_66989(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
this_param)
{
var return_v = this_param.Notification;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 66975, 66989);
return return_v;
}


int
f_1595_67114_67134(object
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 67114, 67134);
return return_v;
}


string
f_1595_67136_67150(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 67136, 67150);
return return_v;
}


int
f_1595_67153_67177(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
this_param)
{
var return_v = this_param.MaxRetryConnectionTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 67153, 67177);
return return_v;
}


int
f_1595_67097_67186(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,int
sourceId,string
computerName,int
totalSeconds)
{
this_param.StartProgressBar( (long)sourceId, computerName, totalSeconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 67097, 67186);
return 0;
}


int
f_1595_67463_67483(object
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 67463, 67483);
return return_v;
}


int
f_1595_67447_67484(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,int
sourceId)
{
this_param.StopProgressBar( (long)sourceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 67447, 67484);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,66806,67539);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,66806,67539);
}
		}

private void WaitForDisconnectAndDisposeJob()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,67697,68573);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,67767,68562) || true) && (_disconnectComplete != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,67767,68562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,67832,67862);

f_1595_67832_67861(                _disconnectComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,67981,68042);

List<PSSession> 
discSessions = f_1595_68012_68041(this, _job)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,68060,68252);
foreach(PSSession session in f_1595_68090_68102_I(discSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,68060,68252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,68144,68190);

f_1595_68144_68189(f_1595_68144_68167(this), session);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,68212,68233);

f_1595_68212_68232(this, session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,68060,68252);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,193);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,193);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,68378,68512) || true) && (f_1595_68382_68398(f_1595_68382_68392(_job))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,68378,68512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,68444,68493);

f_1595_68444_68492(this, f_1595_68477_68491(_job));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,68378,68512);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,68532,68547);

f_1595_68532_68546(
                _job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,67767,68562);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,67697,68573);

bool
f_1595_67832_67861(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 67832, 67861);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1595_68012_68041(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.PSInvokeExpressionSyncJob
job)
{
var return_v = this_param.GetDisconnectedSessions( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68012, 68041);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1595_68144_68167(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 68144, 68167);
return return_v;
}


int
f_1595_68144_68189(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68144, 68189);
return 0;
}


int
f_1595_68212_68232(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68212, 68232);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1595_68090_68102_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68090, 68102);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1595_68382_68392(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 68382, 68392);
return return_v;
}


int
f_1595_68382_68398(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 68382, 68398);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1595_68477_68491(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.ReadAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68477, 68491);
return return_v;
}


int
f_1595_68444_68492(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
results)
{
this_param.WriteStreamObjectsFromCollection( (System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>)results);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68444, 68492);
return 0;
}


int
f_1595_68532_68546(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68532, 68546);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,67697,68573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,67697,68573);
}
		}

private List<PSSession> GetDisconnectedSessions(PSInvokeExpressionSyncJob job)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,68832,73008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,68935,68988);

List<PSSession> 
discSessions = f_1595_68966_68987()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69004,69091);

Collection<System.Management.Automation.PowerShell> 
powershells = f_1595_69070_69090(job)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69105,72961);
foreach(System.Management.Automation.PowerShell ps in f_1595_69160_69171_I(powershells) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,69105,72961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69281,69432);

string 
commandText = (DynAbs.Tracing.TraceSender.Conditional_F1(1595, 69302, 69357)||(((f_1595_69303_69314(ps)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 69303, 69356)&&f_1595_69326_69352(f_1595_69326_69346(f_1595_69326_69337(ps)))> 0)) &&DynAbs.Tracing.TraceSender.Conditional_F2(1595, 69381, 69416))||DynAbs.Tracing.TraceSender.Conditional_F3(1595, 69419, 69431)))?f_1595_69381_69416(f_1595_69381_69404(f_1595_69381_69401(f_1595_69381_69392(ps)), 0)):string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69450,69530);

ConnectCommandInfo 
cmdInfo = f_1595_69479_69529(f_1595_69502_69515(ps), commandText)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69641,69677);

RunspacePool 
oldRunspacePool = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69695,70485) || true) && (f_1595_69699_69714(ps)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,69695,70485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69764,69798);

oldRunspacePool = f_1595_69782_69797(ps);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,69695,70485);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,69695,70485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69880,69929);

object 
rsConnection = f_1595_69902_69928(ps)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,69951,70002);

RunspacePool 
rsPool = rsConnection as RunspacePool
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,70024,70466) || true) && (rsPool != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,70024,70466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,70092,70117);

oldRunspacePool = rsPool;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,70024,70466);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,70024,70466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,70215,70272);

RemoteRunspace 
remoteRs = rsConnection as RemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,70298,70443) || true) && (remoteRs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,70298,70443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,70376,70416);

oldRunspacePool = f_1595_70394_70415(remoteRs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,70298,70443);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,70024,70466);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,69695,70485);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,70720,72946) || true) && (oldRunspacePool != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,70720,72946);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,70789,71560) || true) && (f_1595_70793_70836(f_1595_70793_70830(oldRunspacePool))!= RunspacePoolState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,70789,71560);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71117,71537) || true) && (f_1595_71121_71140()&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 71121, 71215)&&f_1595_71144_71187(f_1595_71144_71181(oldRunspacePool))== RunspacePoolState.Opened))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,71117,71537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71273,71302);

f_1595_71273_71301(                            oldRunspacePool);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,71117,71537);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,71117,71537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71501,71510);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,71117,71537);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,70789,71560);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71662,71731);

string 
sessionName = f_1595_71683_71730(f_1595_71683_71725(oldRunspacePool))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71753,71949) || true) && (f_1595_71757_71790(sessionName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,71753,71949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71840,71847);

int 
id
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71873,71926);

sessionName = f_1595_71887_71925(out id);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,71753,71949);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,71973,72625);

RunspacePool 
runspacePool = f_1595_72001_72624(true, f_1595_72139_72192(f_1595_72139_72181(oldRunspacePool)), sessionName, new ConnectCommandInfo[1] { cmdInfo }, f_1595_72417_72474(f_1595_72417_72459(oldRunspacePool)), f_1595_72533_72542(this), f_1595_72601_72623(f_1595_72601_72613(this)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,72647,72768);

f_1595_72647_72686(runspacePool).IsRemoteDebugStop = f_1595_72707_72767(f_1595_72707_72749(oldRunspacePool));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,72792,72857);

RemoteRunspace 
remoteRunspace = f_1595_72824_72856(runspacePool)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,72879,72927);

f_1595_72879_72926(                    discSessions, f_1595_72896_72925(remoteRunspace));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,70720,72946);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,69105,72961);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,3857);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,3857);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,72977,72997);

return discSessions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,68832,73008);

System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1595_68966_68987()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 68966, 68987);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_69070_69090(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.GetPowerShells();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 69070, 69090);
return return_v;
}


System.Management.Automation.PSCommand
f_1595_69303_69314(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69303, 69314);
return return_v;
}


System.Management.Automation.PSCommand
f_1595_69326_69337(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69326, 69337);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1595_69326_69346(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69326, 69346);
return return_v;
}


int
f_1595_69326_69352(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69326, 69352);
return return_v;
}


System.Management.Automation.PSCommand
f_1595_69381_69392(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69381, 69392);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1595_69381_69401(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69381, 69401);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1595_69381_69404(System.Management.Automation.Runspaces.CommandCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69381, 69404);
return return_v;
}


string
f_1595_69381_69416(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.CommandText ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69381, 69416);
return return_v;
}


System.Guid
f_1595_69502_69515(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69502, 69515);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1595_69479_69529(System.Guid
cmdId,string
cmdStr)
{
var return_v = new System.Management.Automation.Runspaces.Internal.ConnectCommandInfo( cmdId, cmdStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 69479, 69529);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1595_69699_69714(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RunspacePool ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69699, 69714);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1595_69782_69797(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 69782, 69797);
return return_v;
}


object
f_1595_69902_69928(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.GetRunspaceConnection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 69902, 69928);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1595_70394_70415(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 70394, 70415);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1595_70793_70830(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 70793, 70830);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1595_70793_70836(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 70793, 70836);
return return_v;
}


bool
f_1595_71121_71140()
{
var return_v = InvokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 71121, 71140);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1595_71144_71181(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 71144, 71181);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1595_71144_71187(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 71144, 71187);
return return_v;
}


int
f_1595_71273_71301(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
this_param.Disconnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 71273, 71301);
return 0;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1595_71683_71725(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 71683, 71725);
return return_v;
}


string
f_1595_71683_71730(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 71683, 71730);
return return_v;
}


bool
f_1595_71757_71790(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 71757, 71790);
return return_v;
}


string
f_1595_71887_71925(out int
rtnId)
{
var return_v = PSSession.GenerateRunspaceName( out rtnId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 71887, 71925);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1595_72139_72181(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72139, 72181);
return return_v;
}


System.Guid
f_1595_72139_72192(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72139, 72192);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1595_72417_72459(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72417, 72459);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1595_72417_72474(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72417, 72474);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1595_72533_72542(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72533, 72542);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1595_72601_72613(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72601, 72613);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1595_72601_72623(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.TypeTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72601, 72623);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1595_72001_72624(bool
isDisconnected,System.Guid
instanceId,string
name,System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
connectCommands,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePool( isDisconnected, instanceId, name, connectCommands, connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 72001, 72624);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1595_72647_72686(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72647, 72686);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1595_72707_72749(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72707, 72749);
return return_v;
}


bool
f_1595_72707_72767(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.IsRemoteDebugStop;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 72707, 72767);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1595_72824_72856(System.Management.Automation.Runspaces.RunspacePool
runspacePool)
{
var return_v = new System.Management.Automation.RemoteRunspace( runspacePool);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 72824, 72856);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1595_72896_72925(System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = new System.Management.Automation.Runspaces.PSSession( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 72896, 72925);
return return_v;
}


int
f_1595_72879_72926(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 72879, 72926);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_69160_69171_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 69160, 69171);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,68832,73008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,68832,73008);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteInput(object inputValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,73187,74316);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73432,73709) || true) && (f_1595_73436_73455(_inputWriters)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,73432,73709);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73494,73589) || true) && (!_asjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,73494,73589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73547,73570);

f_1595_73547_73569(this, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,73494,73589);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73609,73630);

f_1595_73609_73629(
                this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73648,73694);

throw f_1595_73654_73693(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,73432,73709);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73725,73792);

List<PipelineWriter> 
removeCollection = f_1595_73765_73791()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73808,74161);
foreach(PipelineWriter writer in f_1595_73842_73855_I(_inputWriters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,73808,74161);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,73933,73958);

f_1595_73933_73957(                    writer, inputValue);
                }
                catch (PipelineClosedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1595,73995,74146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74067,74096);

f_1595_74067_74095(                    removeCollection, writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74118,74127);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1595,73995,74146);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,73808,74161);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,354);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,354);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74177,74305);
foreach(PipelineWriter writer in f_1595_74211_74227_I(removeCollection) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,74177,74305);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74261,74290);

f_1595_74261_74289(                _inputWriters, writer);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,74177,74305);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,129);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,129);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1595,73187,74316);

int
f_1595_73436_73455(System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 73436, 73455);
return return_v;
}


int
f_1595_73547_73569(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,bool
nonblocking)
{
this_param.WriteJobResults( nonblocking);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 73547, 73569);
return 0;
}


int
f_1595_73609_73629(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.EndProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 73609, 73629);
return 0;
}


System.Management.Automation.StopUpstreamCommandsException
f_1595_73654_73693(Microsoft.PowerShell.Commands.InvokeCommandCommand
requestingCommand)
{
var return_v = new System.Management.Automation.StopUpstreamCommandsException( (System.Management.Automation.Internal.InternalCommand)requestingCommand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 73654, 73693);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
f_1595_73765_73791()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 73765, 73791);
return return_v;
}


int
f_1595_73933_73957(System.Management.Automation.Runspaces.PipelineWriter
this_param,object
obj)
{
var return_v = this_param.Write( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 73933, 73957);
return return_v;
}


int
f_1595_74067_74095(System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
this_param,System.Management.Automation.Runspaces.PipelineWriter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 74067, 74095);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
f_1595_73842_73855_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 73842, 73855);
return return_v;
}


bool
f_1595_74261_74289(System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
this_param,System.Management.Automation.Runspaces.PipelineWriter
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 74261, 74289);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
f_1595_74211_74227_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 74211, 74227);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,73187,74316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,73187,74316);
}
		}

private void WriteJobResults(bool nonblocking)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,74505,81561);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74576,74648) || true) && (_job == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,74576,74648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74626,74633);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,74576,74648);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74700,74763);

PipelineStoppedException 
caughtPipelineStoppedException = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74781,74821);

_job.PropagateThrows = _propagateErrors;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,74841,76406);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74884,75892) || true) && (!nonblocking)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,74884,75892);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,75250,75869) || true) && (_disconnectComplete != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,75250,75869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,75502,75694);

f_1595_75502_75693(new WaitHandle[] {
                                                    _disconnectComplete,
f_1595_75667_75690(f_1595_75667_75679(_job))});
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,75250,75869);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,75250,75869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,75808,75842);

f_1595_75808_75841(f_1595_75808_75831(f_1595_75808_75820(_job)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,75250,75869);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,74884,75892);
}

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,75968,76017);

f_1595_75968_76016(this, f_1595_76001_76015(_job));
                    }
                    catch (System.Management.Automation.PipelineStoppedException pse)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1595,76062,76236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76176,76213);

caughtPipelineStoppedException = pse;
DynAbs.Tracing.TraceSender.TraceExitCatch(1595,76062,76236);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76260,76354) || true) && (nonblocking)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,76260,76354);
DynAbs.Tracing.TraceSender.TraceBreak(1595,76325,76331);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,76260,76354);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,74841,76406);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,74841,76406) || true) && (!f_1595_76382_76404(_job))
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,74841,76406);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,74841,76406);
}}
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76470,76519);

f_1595_76470_76518(this, f_1595_76503_76517(_job));
                }
                catch (System.Management.Automation.PipelineStoppedException pse)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1595,76556,76718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76662,76699);

caughtPipelineStoppedException = pse;
DynAbs.Tracing.TraceSender.TraceExitCatch(1595,76556,76718);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76738,76925) || true) && (caughtPipelineStoppedException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,76738,76925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76822,76847);

f_1595_76822_76846(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76869,76906);

throw caughtPipelineStoppedException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,76738,76925);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,76945,81195) || true) && (f_1595_76949_76972(f_1595_76949_76966(_job))== JobState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,76945,81195);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,77039,81176) || true) && (f_1595_77043_77059()== InvokeCommandCommand.SessionParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1595, 77043, 77200)||f_1595_77132_77148()== InvokeCommandCommand.FilePathSessionParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,77039,81176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,77421,77481);

PSRemotingJob 
rtnJob = f_1595_77444_77480(_job)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,77507,79670) || true) && (rtnJob != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,77507,79670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,77583,77620);

rtnJob.PSJobTypeName = RemoteJobType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,77865,77879);

_asjob = true;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,77989,79116);
foreach(var cjob in f_1595_78010_78026_I(f_1595_78010_78026(rtnJob)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,77989,79116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,78092,78149);

PSRemotingChildJob 
childJob = cjob as PSRemotingChildJob
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,78183,79085) || true) && (childJob != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,78183,79085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,78343,78406);

PSSession 
session = f_1595_78363_78405(this, f_1595_78376_78404(f_1595_78376_78393(childJob)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,78444,79050) || true) && (session != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,78444,79050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,78633,78666);

f_1595_78633_78665(this, session);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,78784,79011);

f_1595_78784_79010(this, f_1595_78843_79009(f_1595_78861_78903(), f_1595_78954_78966(session), f_1595_78968_78986(session), f_1595_78988_79008(session)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,78444,79050);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,78183,79085);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,77989,79116);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,1128);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,1128);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,79148,79643) || true) && (f_1595_79152_79174(f_1595_79152_79168(rtnJob))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,79148,79643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,79244,79270);

f_1595_79244_79269(f_1595_79244_79257(), rtnJob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,79487,79612);

f_1595_79487_79611(this, f_1595_79538_79610(f_1595_79556_79596(), f_1595_79598_79609(rtnJob)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,79148,79643);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,77507,79670);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,77039,81176);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,77039,81176);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,79720,81176) || true) && (f_1595_79724_79740()== InvokeCommandCommand.ComputerNameParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1595, 79724, 79896)||f_1595_79823_79839()== InvokeCommandCommand.FilePathComputerNameParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,79720,81176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,80119,80180);

List<PSSession> 
discSessions = f_1595_80150_80179(this, _job)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,80206,81153);
foreach(PSSession session in f_1595_80236_80248_I(discSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,80206,81153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,80365,80411);

f_1595_80365_80410(f_1595_80365_80388(this), session);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,80519,80552);

f_1595_80519_80551(this, session);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,80646,80849);

f_1595_80646_80848(this, f_1595_80693_80847(f_1595_80711_80753(), f_1595_80792_80804(session), f_1595_80806_80824(session), f_1595_80826_80846(session)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,80938,81126);

f_1595_80938_81125(this, f_1595_80985_81124(f_1595_81003_81052(), f_1595_81091_81103(session), f_1595_81105_81123(session)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,80206,81153);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,948);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,948);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1595,79720,81176);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,77039,81176);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,76945,81195);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1595,81224,81550);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,81264,81535) || true) && (f_1595_81268_81291(f_1595_81268_81285(_job))== JobState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,81264,81535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,81481,81516);

f_1595_81481_81515(this, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,81264,81535);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1595,81224,81550);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,74505,81561);

System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1595_75667_75679(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 75667, 75679);
return return_v;
}


System.Threading.WaitHandle
f_1595_75667_75690(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.WaitHandle ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 75667, 75690);
return return_v;
}


int
f_1595_75502_75693(System.Threading.WaitHandle[]
waitHandles)
{
var return_v = WaitHandle.WaitAny( waitHandles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 75502, 75693);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1595_75808_75820(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 75808, 75820);
return return_v;
}


System.Threading.WaitHandle
f_1595_75808_75831(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.WaitHandle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 75808, 75831);
return return_v;
}


bool
f_1595_75808_75841(System.Threading.WaitHandle
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 75808, 75841);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1595_76001_76015(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.ReadAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 76001, 76015);
return return_v;
}


int
f_1595_75968_76016(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
results)
{
this_param.WriteStreamObjectsFromCollection( (System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>)results);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 75968, 76016);
return 0;
}


bool
f_1595_76382_76404(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.IsTerminalState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 76382, 76404);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1595_76503_76517(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.ReadAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 76503, 76517);
return return_v;
}


int
f_1595_76470_76518(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
results)
{
this_param.WriteStreamObjectsFromCollection( (System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>)results);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 76470, 76518);
return 0;
}


int
f_1595_76822_76846(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.HandlePipelinesStopped();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 76822, 76846);
return 0;
}


System.Management.Automation.JobStateInfo
f_1595_76949_76966(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 76949, 76966);
return return_v;
}


System.Management.Automation.JobState
f_1595_76949_76972(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 76949, 76972);
return return_v;
}


string
f_1595_77043_77059()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 77043, 77059);
return return_v;
}


string
f_1595_77132_77148()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 77132, 77148);
return return_v;
}


System.Management.Automation.PSRemotingJob
f_1595_77444_77480(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.CreateDisconnectedRemotingJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 77444, 77480);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1595_78010_78026(System.Management.Automation.PSRemotingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 78010, 78026);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_78376_78393(System.Management.Automation.PSRemotingChildJob
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 78376, 78393);
return return_v;
}


System.Guid
f_1595_78376_78404(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 78376, 78404);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1595_78363_78405(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Guid
runspaceId)
{
var return_v = this_param.GetPSSession( runspaceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 78363, 78405);
return return_v;
}


int
f_1595_78633_78665(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.WriteNetworkFailedError( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 78633, 78665);
return 0;
}


string
f_1595_78861_78903()
{
var return_v = RemotingErrorIdStrings.RCDisconnectSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 78861, 78903);
return return_v;
}


string
f_1595_78954_78966(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 78954, 78966);
return return_v;
}


System.Guid
f_1595_78968_78986(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 78968, 78986);
return return_v;
}


string
f_1595_78988_79008(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 78988, 79008);
return return_v;
}


string
f_1595_78843_79009(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 78843, 79009);
return return_v;
}


int
f_1595_78784_79010(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 78784, 79010);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1595_78010_78026_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 78010, 78026);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1595_79152_79168(System.Management.Automation.PSRemotingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 79152, 79168);
return return_v;
}


int
f_1595_79152_79174(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 79152, 79174);
return return_v;
}


System.Management.Automation.JobRepository
f_1595_79244_79257()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 79244, 79257);
return return_v;
}


int
f_1595_79244_79269(System.Management.Automation.JobRepository
this_param,System.Management.Automation.PSRemotingJob
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 79244, 79269);
return 0;
}


string
f_1595_79556_79596()
{
var return_v = RemotingErrorIdStrings.RCDisconnectedJob;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 79556, 79596);
return return_v;
}


string
f_1595_79598_79609(System.Management.Automation.PSRemotingJob
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 79598, 79609);
return return_v;
}


string
f_1595_79538_79610(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 79538, 79610);
return return_v;
}


int
f_1595_79487_79611(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 79487, 79611);
return 0;
}


string
f_1595_79724_79740()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 79724, 79740);
return return_v;
}


string
f_1595_79823_79839()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 79823, 79839);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1595_80150_80179(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.PSInvokeExpressionSyncJob
job)
{
var return_v = this_param.GetDisconnectedSessions( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80150, 80179);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1595_80365_80388(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 80365, 80388);
return return_v;
}


int
f_1595_80365_80410(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80365, 80410);
return 0;
}


int
f_1595_80519_80551(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.WriteNetworkFailedError( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80519, 80551);
return 0;
}


string
f_1595_80711_80753()
{
var return_v = RemotingErrorIdStrings.RCDisconnectSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 80711, 80753);
return return_v;
}


string
f_1595_80792_80804(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 80792, 80804);
return return_v;
}


System.Guid
f_1595_80806_80824(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 80806, 80824);
return return_v;
}


string
f_1595_80826_80846(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 80826, 80846);
return return_v;
}


string
f_1595_80693_80847(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80693, 80847);
return return_v;
}


int
f_1595_80646_80848(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80646, 80848);
return 0;
}


string
f_1595_81003_81052()
{
var return_v = RemotingErrorIdStrings.RCDisconnectSessionCreated;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 81003, 81052);
return return_v;
}


string
f_1595_81091_81103(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 81091, 81103);
return return_v;
}


System.Guid
f_1595_81105_81123(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 81105, 81123);
return return_v;
}


string
f_1595_80985_81124(string
formatSpec,string
o1,System.Guid
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80985, 81124);
return return_v;
}


int
f_1595_80938_81125(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80938, 81125);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1595_80236_80248_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 80236, 80248);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1595_81268_81285(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 81268, 81285);
return return_v;
}


System.Management.Automation.JobState
f_1595_81268_81291(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 81268, 81291);
return return_v;
}


int
f_1595_81481_81515(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,object
sender,System.EventArgs
eventArgs)
{
this_param.HandleThrottleComplete( sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 81481, 81515);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,74505,81561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,74505,81561);
}
		}

private void WriteNetworkFailedError(PSSession session)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,81573,82007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,81653,81808);

RuntimeException 
reason = f_1595_81679_81807(f_1595_81718_81806(f_1595_81736_81783(), f_1595_81785_81805(session)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,81824,81996);

f_1595_81824_81995(this, f_1595_81835_81994(reason, PSConnectionRetryStatusEventArgs.FQIDAutoDisconnectStarting, ErrorCategory.OperationTimeout, session));
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,81573,82007);

string
f_1595_81736_81783()
{
var return_v = RemotingErrorIdStrings.RCAutoDisconnectingError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 81736, 81783);
return return_v;
}


string
f_1595_81785_81805(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 81785, 81805);
return return_v;
}


string
f_1595_81718_81806(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 81718, 81806);
return return_v;
}


System.Management.Automation.RuntimeException
f_1595_81679_81807(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 81679, 81807);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1595_81835_81994(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 81835, 81994);
return return_v;
}


int
f_1595_81824_81995(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 81824, 81995);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,81573,82007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,81573,82007);
}
		}

private PSSession GetPSSession(Guid runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,82019,82337);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82091,82298);
foreach(PSSession session in f_1595_82121_82128_I(f_1595_82121_82128()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,82091,82298);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82162,82283) || true) && (f_1595_82166_82193(f_1595_82166_82182(session))== runspaceId)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,82162,82283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82249,82264);

return session;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,82162,82283);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,82091,82298);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,208);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,208);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82314,82326);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,82019,82337);

System.Management.Automation.Runspaces.PSSession[]
f_1595_82121_82128()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82121, 82128);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1595_82166_82182(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82166, 82182);
return return_v;
}


System.Guid
f_1595_82166_82193(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82166, 82193);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_82121_82128_I(System.Management.Automation.Runspaces.PSSession[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 82121, 82128);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,82019,82337);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,82019,82337);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandlePipelinesStopped()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,82349,83532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82512,82539);

bool 
retryCanceled = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82553,82641);

Collection<System.Management.Automation.PowerShell> 
powershells = f_1595_82619_82640(_job)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82655,83244);
foreach(System.Management.Automation.PowerShell ps in f_1595_82710_82721_I(powershells) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,82655,83244);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,82755,83229) || true) && (f_1595_82759_82778(ps)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 82759, 82884)&&f_1595_82811_82852(f_1595_82811_82830(ps))!= PSConnectionRetryStatus.None )&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 82759, 83002)&&f_1595_82909_82950(f_1595_82909_82928(ps))!= PSConnectionRetryStatus.ConnectionRetrySucceeded )&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 82759, 83119)&&f_1595_83027_83068(f_1595_83027_83046(ps))!= PSConnectionRetryStatus.AutoDisconnectSucceeded))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,82755,83229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,83161,83182);

retryCanceled = true;
DynAbs.Tracing.TraceSender.TraceBreak(1595,83204,83210);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,82755,83229);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,82655,83244);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,590);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,590);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,83260,83521) || true) && (retryCanceled &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 83264, 83315)&&f_1595_83298_83307(this)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,83260,83521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,83433,83506);

f_1595_83433_83505(f_1595_83433_83445(f_1595_83433_83442(this)), f_1595_83463_83504());
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,83260,83521);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,82349,83532);

System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_82619_82640(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
var return_v = this_param.GetPowerShells();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 82619, 82640);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_82759_82778(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82759, 82778);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_82811_82830(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82811, 82830);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
f_1595_82811_82852(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.ConnectionRetryStatus ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82811, 82852);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_82909_82928(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82909, 82928);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
f_1595_82909_82950(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.ConnectionRetryStatus ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 82909, 82950);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1595_83027_83046(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 83027, 83046);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
f_1595_83027_83068(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.ConnectionRetryStatus ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 83027, 83068);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1595_82710_82721_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 82710, 82721);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1595_83298_83307(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 83298, 83307);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1595_83433_83442(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 83433, 83442);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1595_83433_83445(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 83433, 83445);
return return_v;
}


string
f_1595_83463_83504()
{
var return_v = RemotingErrorIdStrings.StopCommandOnRetry;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 83463, 83504);
return return_v;
}


int
f_1595_83433_83505(System.Management.Automation.Host.PSHostUserInterface
this_param,string
message)
{
this_param.WriteWarningLine( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 83433, 83505);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,82349,83532);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,82349,83532);
}
		}

private void StartProgressBar(
            long sourceId,
            string computerName,
            int totalSeconds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,83544,83848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,83692,83837);

f_1595_83692_83836(            s_RCProgress, sourceId, computerName, totalSeconds, f_1595_83826_83835(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,83544,83848);

System.Management.Automation.Host.PSHost
f_1595_83826_83835(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 83826, 83835);
return return_v;
}


int
f_1595_83692_83836(System.Management.Automation.Internal.RobustConnectionProgress
this_param,long
sourceId,string
computerName,int
secondsTotal,System.Management.Automation.Host.PSHost
psHost)
{
this_param.StartProgress( sourceId, computerName, secondsTotal, psHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 83692, 83836);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,83544,83848);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,83544,83848);
}
		}

private void StopProgressBar(
            long sourceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,83860,83989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,83942,83978);

f_1595_83942_83977(            s_RCProgress, sourceId);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,83860,83989);

int
f_1595_83942_83977(System.Management.Automation.Internal.RobustConnectionProgress
this_param,long
sourceId)
{
this_param.StopProgress( sourceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 83942, 83977);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,83860,83989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,83860,83989);
}
		}

private void WriteStreamObjectsFromCollection(IEnumerable<PSStreamObject> results)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,84184,84544);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,84291,84533);
foreach(var result in f_1595_84314_84321_I(results) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,84291,84533);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,84355,84518) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,84355,84518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,84415,84446);

f_1595_84415_84445(this, result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,84468,84499);

f_1595_84468_84498(                    result, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,84355,84518);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,84291,84533);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1595,1,243);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1595,1,243);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1595,84184,84544);

int
f_1595_84415_84445(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,System.Management.Automation.Remoting.Internal.PSStreamObject
streamObject)
{
this_param.PreProcessStreamObject( streamObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 84415, 84445);
return 0;
}


int
f_1595_84468_84498(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param,Microsoft.PowerShell.Commands.InvokeCommandCommand
cmdlet)
{
this_param.WriteStreamObject( (System.Management.Automation.Cmdlet)cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 84468, 84498);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1595_84314_84321_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 84314, 84321);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,84184,84544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,84184,84544);
}
		}

private void DetermineThrowStatementBehavior()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,85237,86688);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,85308,85488) || true) && (f_1595_85312_85376(f_1595_85312_85328(), InvokeCommandCommand.InProcParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,85308,85488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,85466,85473);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,85308,85488);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,85504,86677) || true) && (!_asjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,85504,86677);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,85549,86662) || true) && (f_1595_85553_85623(f_1595_85553_85569(), InvokeCommandCommand.ComputerNameParameterSet)||(DynAbs.Tracing.TraceSender.Expression_False(1595, 85553, 85726)||f_1595_85648_85726(f_1595_85648_85664(), InvokeCommandCommand.FilePathComputerNameParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,85549,86662);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,85768,85893) || true) && (f_1595_85772_85791(f_1595_85772_85784())== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,85768,85893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,85846,85870);

_propagateErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,85768,85893);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,85549,86662);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,85549,86662);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,85935,86662) || true) && (f_1595_85939_86004(f_1595_85939_85955(), InvokeCommandCommand.SessionParameterSet)||(DynAbs.Tracing.TraceSender.Expression_False(1595, 85939, 86107)||f_1595_86034_86107(f_1595_86034_86050(), InvokeCommandCommand.FilePathSessionParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,85935,86662);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,86149,86269) || true) && (f_1595_86153_86167(f_1595_86153_86160())== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,86149,86269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,86222,86246);

_propagateErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,86149,86269);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,85935,86662);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,85935,86662);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,86311,86662) || true) && (f_1595_86315_86376(f_1595_86315_86331(), InvokeCommandCommand.UriParameterSet)||(DynAbs.Tracing.TraceSender.Expression_False(1595, 86315, 86475)||f_1595_86406_86475(f_1595_86406_86422(), InvokeCommandCommand.FilePathUriParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,86311,86662);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,86517,86643) || true) && (f_1595_86521_86541(f_1595_86521_86534())== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,86517,86643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,86596,86620);

_propagateErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,86517,86643);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,86311,86662);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,85935,86662);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,85549,86662);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,85504,86677);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,85237,86688);

string
f_1595_85312_85328()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 85312, 85328);
return return_v;
}


bool
f_1595_85312_85376(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 85312, 85376);
return return_v;
}


string
f_1595_85553_85569()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 85553, 85569);
return return_v;
}


bool
f_1595_85553_85623(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 85553, 85623);
return return_v;
}


string
f_1595_85648_85664()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 85648, 85664);
return return_v;
}


bool
f_1595_85648_85726(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 85648, 85726);
return return_v;
}


string[]
f_1595_85772_85784()
{
var return_v = ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 85772, 85784);
return return_v;
}


int
f_1595_85772_85791(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 85772, 85791);
return return_v;
}


string
f_1595_85939_85955()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 85939, 85955);
return return_v;
}


bool
f_1595_85939_86004(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 85939, 86004);
return return_v;
}


string
f_1595_86034_86050()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 86034, 86050);
return return_v;
}


bool
f_1595_86034_86107(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 86034, 86107);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1595_86153_86160()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 86153, 86160);
return return_v;
}


int
f_1595_86153_86167(System.Management.Automation.Runspaces.PSSession[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 86153, 86167);
return return_v;
}


string
f_1595_86315_86331()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 86315, 86331);
return return_v;
}


bool
f_1595_86315_86376(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 86315, 86376);
return return_v;
}


string
f_1595_86406_86422()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 86406, 86422);
return return_v;
}


bool
f_1595_86406_86475(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 86406, 86475);
return return_v;
}


System.Uri[]
f_1595_86521_86534()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 86521, 86534);
return return_v;
}


int
f_1595_86521_86541(System.Uri[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 86521, 86541);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,85237,86688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,85237,86688);
}
		}

private void PreProcessStreamObject(PSStreamObject streamObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,86907,87998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,86996,87056);

ErrorRecord 
errorRecord = f_1595_87022_87040(streamObject)as ErrorRecord
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,87275,87987) || true) && ((errorRecord != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 87279, 87352)&&                (f_1595_87322_87343(errorRecord)!= null) )&&(DynAbs.Tracing.TraceSender.Expression_True(1595, 87279, 87419)&&                (f_1595_87374_87410(f_1595_87374_87395(errorRecord))!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,87275,87987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,87453,87534);

PSDirectException 
ex = f_1595_87476_87512(f_1595_87476_87497(errorRecord))as PSDirectException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,87552,87972) || true) && (ex != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,87552,87972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,87608,87953);

streamObject.Value = f_1595_87629_87952(f_1595_87645_87681(f_1595_87645_87666(errorRecord)), f_1595_87741_87774(errorRecord), f_1595_87834_87867(f_1595_87834_87858(errorRecord)), f_1595_87927_87951(errorRecord));
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,87552,87972);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,87275,87987);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,86907,87998);

object
f_1595_87022_87040(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87022, 87040);
return return_v;
}


System.Exception
f_1595_87322_87343(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87322, 87343);
return return_v;
}


System.Exception
f_1595_87374_87395(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87374, 87395);
return return_v;
}


System.Exception
f_1595_87374_87410(System.Exception
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87374, 87410);
return return_v;
}


System.Exception
f_1595_87476_87497(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87476, 87497);
return return_v;
}


System.Exception
f_1595_87476_87512(System.Exception
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87476, 87512);
return return_v;
}


System.Exception
f_1595_87645_87666(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87645, 87666);
return return_v;
}


System.Exception
f_1595_87645_87681(System.Exception
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87645, 87681);
return return_v;
}


string
f_1595_87741_87774(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87741, 87774);
return return_v;
}


System.Management.Automation.ErrorCategoryInfo
f_1595_87834_87858(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.CategoryInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87834, 87858);
return return_v;
}


System.Management.Automation.ErrorCategory
f_1595_87834_87867(System.Management.Automation.ErrorCategoryInfo
this_param)
{
var return_v = this_param.Category;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87834, 87867);
return return_v;
}


object
f_1595_87927_87951(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.TargetObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 87927, 87951);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1595_87629_87952(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 87629, 87952);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,86907,87998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,86907,87998);
}
		}

private ThrottleManager _throttleManager ;

private ManualResetEvent _operationsComplete ;

private ManualResetEvent _disconnectComplete;

private PSInvokeExpressionSyncJob _job;

private SteppablePipeline _steppablePipeline;

private bool _pipelineinvoked ;

private bool _inputStreamClosed ;

private const string 
InProcParameterSet = "InProcess"
;

private PSDataCollection<object> _input ;

private bool _needToCollect ;

private bool _needToStartSteppablePipelineOnServer ;

private bool _clearInvokeCommandOnRunspace ;

private List<PipelineWriter> _inputWriters ;

private object _jobSyncObject ;

private bool _nojob ;

private Guid _instanceId ;

private bool _propagateErrors ;

private static RobustConnectionProgress s_RCProgress ;

internal static readonly string RemoteJobType ;

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,89913,90024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89959,89973);

f_1595_89959_89972(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89987,90013);

f_1595_89987_90012(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,89913,90024);

int
f_1595_89959_89972(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 89959, 89972);
return 0;
}


int
f_1595_89987_90012(Microsoft.PowerShell.Commands.InvokeCommandCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 89987, 90012);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,89913,90024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,89913,90024);
}
		}

private void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,90239,91771);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,90300,91760) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,90300,91760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,90556,90578);

f_1595_90556_90577(                // this call fixes bug Windows 7 #278836
                // by making sure the server is stopped even if it is waiting
                // for further input from this Invoke-Command cmdlet

                this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,90652,90682);

f_1595_90652_90681(                // wait for all operations to complete
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,90700,90730);

f_1595_90700_90729(                _operationsComplete);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,90750,91203) || true) && (!_asjob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,90750,91203);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,90803,90976) || true) && (_job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,90803,90976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,90938,90953);

f_1595_90938_90952(                        // job will be null in the "InProcess" case
                        _job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,90803,90976);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91000,91089);

_throttleManager.ThrottleComplete -= new EventHandler<EventArgs>(HandleThrottleComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91111,91138);

f_1595_91111_91137(                    _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91160,91184);

_throttleManager = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,90750,91203);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91294,91420) || true) && (_clearInvokeCommandOnRunspace)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,91294,91420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91369,91401);

f_1595_91369_91400(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,91294,91420);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91440,91457);

f_1595_91440_91456(
                _input);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91483,91497);

                lock (_jobSyncObject)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91539,91726) || true) && (_disconnectComplete != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,91539,91726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91620,91650);

f_1595_91620_91649(                        _disconnectComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,91676,91703);

_disconnectComplete = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,91539,91726);
}
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,90300,91760);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,90239,91771);

int
f_1595_90556_90577(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.StopProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 90556, 90577);
return 0;
}


bool
f_1595_90652_90681(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 90652, 90681);
return return_v;
}


int
f_1595_90700_90729(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 90700, 90729);
return 0;
}


int
f_1595_90938_90952(System.Management.Automation.PSInvokeExpressionSyncJob
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 90938, 90952);
return 0;
}


int
f_1595_91111_91137(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 91111, 91137);
return 0;
}


int
f_1595_91369_91400(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param)
{
this_param.ClearInvokeCommandOnRunspaces();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 91369, 91400);
return 0;
}


int
f_1595_91440_91456(System.Management.Automation.PSDataCollection<object>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 91440, 91456);
return 0;
}


int
f_1595_91620_91649(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 91620, 91649);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,90239,91771);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,90239,91771);
}
		}

public InvokeCommandCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1595,6315,91822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,19128,19142);
this._asjob = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,22236,22253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,23601,23621);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,33809,34160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,88107,88147);
this._throttleManager = f_1595_88126_88147();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,88251,88299);
this._operationsComplete = f_1595_88273_88299(true);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,88335,88354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,88713,88717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,88818,88836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,88862,88886);
this._pipelineinvoked = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,88945,88971);
this._inputStreamClosed = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89081,89120);
this._input = f_1595_89090_89120();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89144,89166);
this._needToCollect = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89190,89235);
this._needToStartSteppablePipelineOnServer = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89259,89296);
this._clearInvokeCommandOnRunspace = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89336,89378);
this._inputWriters = f_1595_89352_89378();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89404,89433);
this._jobSyncObject = f_1595_89421_89433();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89457,89471);
this._nojob = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89495,89523);
this._instanceId = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89547,89571);
this._propagateErrors = false;DynAbs.Tracing.TraceSender.TraceExitConstructor(1595,6315,91822);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,6315,91822);
}


static InvokeCommandCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1595,6315,91822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89005,89037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89624,89669);
s_RCProgress = f_1595_89639_89669();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,89714,89741);
RemoteJobType = "RemoteJob";DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1595,6315,91822);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,6315,91822);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1595,6315,91822);

System.Management.Automation.Remoting.ThrottleManager
f_1595_88126_88147()
{
var return_v = new System.Management.Automation.Remoting.ThrottleManager();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 88126, 88147);
return return_v;
}


System.Threading.ManualResetEvent
f_1595_88273_88299(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 88273, 88299);
return return_v;
}


System.Management.Automation.PSDataCollection<object>
f_1595_89090_89120()
{
var return_v = new System.Management.Automation.PSDataCollection<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 89090, 89120);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>
f_1595_89352_89378()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.PipelineWriter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 89352, 89378);
return return_v;
}


object
f_1595_89421_89433()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 89421, 89433);
return return_v;
}


static System.Management.Automation.Internal.RobustConnectionProgress
f_1595_89639_89669()
{
var return_v = new System.Management.Automation.Internal.RobustConnectionProgress();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 89639, 89669);
return return_v;
}

}
}

namespace System.Management.Automation.Internal
{
internal class RobustConnectionProgress
{
private System.Management.Automation.Host.PSHost _psHost;

private string _activity;

private string _status;

private int _secondsTotal;

private int _secondsRemaining;

private ProgressRecord _progressRecord;

private long _sourceId;

private bool _progressIsRunning;

private object _syncObject;

private Timer _updateTimer;

public RobustConnectionProgress()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1595,92574,92738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92139,92146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92172,92181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92207,92214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92237,92250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92273,92290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92324,92339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92363,92372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92396,92414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92440,92451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92476,92488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92632,92659);

_syncObject = f_1595_92646_92658();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,92673,92727);

_activity = f_1595_92685_92726();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1595,92574,92738);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,92574,92738);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,92574,92738);
}
		}

public void StartProgress(
            long sourceId,
            string computerName,
            int secondsTotal,
            System.Management.Automation.Host.PSHost psHost)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,93017,94322);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93223,93297) || true) && (psHost == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,93223,93297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93275,93282);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,93223,93297);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93313,93389) || true) && (secondsTotal < 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,93313,93389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93367,93374);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,93313,93389);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93405,93540) || true) && (f_1595_93409_93443(computerName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,93405,93540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93477,93525);

throw f_1595_93483_93524("computerName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,93405,93540);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93562,93573);

            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93607,93697) || true) && (_progressIsRunning)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,93607,93697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93671,93678);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,93607,93697);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93717,93743);

_progressIsRunning = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93761,93782);

_sourceId = sourceId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93800,93829);

_secondsTotal = secondsTotal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93847,93880);

_secondsRemaining = secondsTotal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93898,93915);

_psHost = psHost;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,93933,94016);

_status = f_1595_93943_94015(f_1595_93961_94000(), computerName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94034,94094);

_progressRecord = f_1595_94052_94093(0, _activity, _status);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94192,94296);

_updateTimer = f_1595_94207_94295(new TimerCallback(UpdateCallback), null, TimeSpan.Zero, f_1595_94273_94294(0, 0, 1));
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,93017,94322);

bool
f_1595_93409_93443(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 93409, 93443);
return return_v;
}


System.ArgumentNullException
f_1595_93483_93524(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 93483, 93524);
return return_v;
}


string
f_1595_93961_94000()
{
var return_v = RemotingErrorIdStrings.RCProgressStatus;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 93961, 94000);
return return_v;
}


string
f_1595_93943_94015(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 93943, 94015);
return return_v;
}


System.Management.Automation.ProgressRecord
f_1595_94052_94093(int
activityId,string
activity,string
statusDescription)
{
var return_v = new System.Management.Automation.ProgressRecord( activityId, activity, statusDescription);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 94052, 94093);
return return_v;
}


System.TimeSpan
f_1595_94273_94294(int
hours,int
minutes,int
seconds)
{
var return_v = new System.TimeSpan( hours, minutes, seconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 94273, 94294);
return return_v;
}


System.Threading.Timer
f_1595_94207_94295(System.Threading.TimerCallback
callback,object?
state,System.TimeSpan
dueTime,System.TimeSpan
period)
{
var return_v = new System.Threading.Timer( callback, state, dueTime, period);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 94207, 94295);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,93017,94322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,93017,94322);
}
		}

public void StopProgress(
            long sourceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,94414,94737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94498,94509);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94543,94711) || true) && ((sourceId == _sourceId ||(DynAbs.Tracing.TraceSender.Expression_False(1595, 94548, 94586)||sourceId == 0)) &&(DynAbs.Tracing.TraceSender.Expression_True(1595, 94547, 94630)&&                    _progressIsRunning))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,94543,94711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94672,94692);

f_1595_94672_94691(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,94543,94711);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,94414,94737);

int
f_1595_94672_94691(System.Management.Automation.Internal.RobustConnectionProgress
this_param)
{
this_param.RemoveProgressBar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 94672, 94691);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,94414,94737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,94414,94737);
}
		}

private void UpdateCallback(object state)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,94749,95625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94821,94832);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94866,94957) || true) && (!_progressIsRunning)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,94866,94957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94931,94938);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,94866,94957);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,94977,95599) || true) && (_secondsRemaining > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,94977,95599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95089,95208);

_progressRecord.PercentComplete =
                        ((_secondsTotal - _secondsRemaining) * 100) / _secondsTotal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95230,95285);

_progressRecord.SecondsRemaining = _secondsRemaining--;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95307,95366);

_progressRecord.RecordType = ProgressRecordType.Processing;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95388,95433);

f_1595_95388_95432(f_1595_95388_95398(_psHost), 0, _progressRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,94977,95599);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1595,94977,95599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95560,95580);

f_1595_95560_95579(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1595,94977,95599);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,94749,95625);

System.Management.Automation.Host.PSHostUserInterface
f_1595_95388_95398(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 95388, 95398);
return return_v;
}


int
f_1595_95388_95432(System.Management.Automation.Host.PSHostUserInterface
this_param,int
sourceId,System.Management.Automation.ProgressRecord
record)
{
this_param.WriteProgress( (long)sourceId, record);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 95388, 95432);
return 0;
}


int
f_1595_95560_95579(System.Management.Automation.Internal.RobustConnectionProgress
this_param)
{
this_param.RemoveProgressBar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 95560, 95579);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,94749,95625);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,94749,95625);
}
		}

private void RemoveProgressBar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1595,95637,96005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95694,95721);

_progressIsRunning = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95774,95832);

_progressRecord.RecordType = ProgressRecordType.Completed;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95846,95891);

f_1595_95846_95890(f_1595_95846_95856(_psHost), 0, _progressRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95937,95960);

f_1595_95937_95959(
            // Remove timer.
            _updateTimer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1595,95974,95994);

_updateTimer = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1595,95637,96005);

System.Management.Automation.Host.PSHostUserInterface
f_1595_95846_95856(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 95846, 95856);
return return_v;
}


int
f_1595_95846_95890(System.Management.Automation.Host.PSHostUserInterface
this_param,int
sourceId,System.Management.Automation.ProgressRecord
record)
{
this_param.WriteProgress( (long)sourceId, record);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 95846, 95890);
return 0;
}


int
f_1595_95937_95959(System.Threading.Timer
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 95937, 95959);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1595,95637,96005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,95637,96005);
}
		}

static RobustConnectionProgress()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1595,92034,96012);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1595,92034,96012);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1595,92034,96012);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1595,92034,96012);

object
f_1595_92646_92658()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1595, 92646, 92658);
return return_v;
}


string
f_1595_92685_92726()
{
var return_v = RemotingErrorIdStrings.RCProgressActivity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1595, 92685, 92726);
return return_v;
}

}

    }
