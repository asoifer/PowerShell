// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Runspaces;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[SuppressMessage("Microsoft.PowerShell", "PS1012:CallShouldProcessOnlyIfDeclaringSupport")]
    [Cmdlet(VerbsCommunications.Connect, "PSSession", SupportsShouldProcess = true, DefaultParameterSetName = ConnectPSSessionCommand.NameParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096694", RemotingCapability = RemotingCapability.OwnedByCommand)]
    [OutputType(typeof(PSSession))]
    public class ConnectPSSessionCommand : PSRunspaceCmdlet, IDisposable
{
private const string 
ComputerNameGuidParameterSet = "ComputerNameGuid"
;

private const string 
ConnectionUriParameterSet = "ConnectionUri"
;

private const string 
ConnectionUriGuidParameterSet = "ConnectionUriGuid"
;

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = ConnectPSSessionCommand.SessionParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public PSSession[] Session {get; set; }

[Parameter(Position = 0,
                   ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet,
                   Mandatory = true)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet,
                   Mandatory = true)]
        [ValidateNotNullOrEmpty]
        [Alias("Cn")]
        public override string[] ComputerName {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        public string ApplicationName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,4301,4325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,4307,4323);

return _appName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,4301,4325);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,3943,4436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,3943,4436);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,4341,4425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,4377,4410);

_appName = f_1588_4388_4409(this, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,4341,4425);

string
f_1588_4388_4409(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,string
appName)
{
var return_v = this_param.ResolveAppName( appName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 4388, 4409);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,3943,4436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,3943,4436);
}
		}}

private string _appName;

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        public string ConfigurationName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,5424,5446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,5430,5444);

return _shell;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,5424,5446);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,4758,5553);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,4758,5553);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,5462,5542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,5498,5527);

_shell = f_1588_5507_5526(this, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,5462,5542);

string
f_1588_5507_5526(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,string
shell)
{
var return_v = this_param.ResolveShell( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 5507, 5526);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,4758,5553);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,4758,5553);
}
		}}

private string _shell;

[Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("URI", "CU")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public Uri[] ConnectionUri {get; set; }

[Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        public SwitchParameter AllowRedirection
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,6784,6817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,6790,6815);

return _allowRedirection;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,6784,6817);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,6534,6878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,6534,6878);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,6833,6867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,6839,6865);

_allowRedirection = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,6833,6867);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,6534,6878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,6534,6878);
}
		}}

private bool _allowRedirection ;

[Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet,
                   Mandatory = true)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet,
                   Mandatory = true)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.InstanceIdParameterSet,
                   Mandatory = true)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public override Guid[] InstanceId
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,7645,7676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,7651,7674);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.InstanceId,1588,7658,7673);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,7645,7676);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,7075,7735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,7075,7735);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,7692,7724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,7698,7722);

base.InstanceId = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,7692,7724);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,7075,7735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,7075,7735);
}
		}}

[Parameter(ParameterSetName = ConnectPSSessionCommand.NameParameterSet,
                   Mandatory = true)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [ValidateNotNullOrEmpty]
        public override string[] Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,8236,8261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,8242,8259);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Name,1588,8249,8258);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,8236,8261);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,7847,8314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,7847,8314);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,8277,8303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,8283,8301);

base.Name = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,8277,8303);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,7847,8314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,7847,8314);
}
		}}

[Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        [Credential()]
        public PSCredential Credential
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,9038,9067);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,9044,9065);

return _psCredential;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,9038,9067);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,8589,9291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,8589,9291);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,9083,9280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,9119,9141);

_psCredential = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,9161,9265);

f_1588_9161_9264(f_1588_9214_9224(), f_1588_9226_9247(), f_1588_9249_9263());
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,9083,9280);

System.Management.Automation.PSCredential
f_1588_9214_9224()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 9214, 9224);
return return_v;
}


string
f_1588_9226_9247()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 9226, 9247);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1588_9249_9263()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 9249, 9263);
return return_v;
}


int
f_1588_9161_9264(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 9161, 9264);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,8589,9291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,8589,9291);
}
		}}

private PSCredential _psCredential;

[Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        public AuthenticationMechanism Authentication
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,9901,9932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,9907,9930);

return _authentication;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,9901,9932);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,9461,10158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,9461,10158);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,9948,10147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,9984,10008);

_authentication = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,10028,10132);

f_1588_10028_10131(f_1588_10081_10091(), f_1588_10093_10114(), f_1588_10116_10130());
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,9948,10147);

System.Management.Automation.PSCredential
f_1588_10081_10091()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 10081, 10091);
return return_v;
}


string
f_1588_10093_10114()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 10093, 10114);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1588_10116_10130()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 10116, 10130);
return return_v;
}


int
f_1588_10028_10131(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 10028, 10131);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,9461,10158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,9461,10158);
}
		}}

private AuthenticationMechanism _authentication;

[Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        public string CertificateThumbprint
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,10828,10855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,10834,10853);

return _thumbprint;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,10828,10855);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,10398,11077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,10398,11077);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,10871,11066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,10907,10927);

_thumbprint = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,10947,11051);

f_1588_10947_11050(f_1588_11000_11010(), f_1588_11012_11033(), f_1588_11035_11049());
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,10871,11066);

System.Management.Automation.PSCredential
f_1588_11000_11010()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 11000, 11010);
return return_v;
}


string
f_1588_11012_11033()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 11012, 11033);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1588_11035_11049()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 11035, 11049);
return return_v;
}


int
f_1588_10947_11050(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 10947, 11050);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,10398,11077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,10398,11077);
}
		}}

private string _thumbprint;

[Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [ValidateRange((int)1, (int)UInt16.MaxValue)]
        public int Port {get; set; }

[Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SSL")]
        public SwitchParameter UseSSL {get; set; }

[Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        public PSSessionOption SessionOption {get; set; }

[Parameter(ParameterSetName = ConnectPSSessionCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.IdParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ComputerNameGuidParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.ConnectionUriGuidParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.NameParameterSet)]
        [Parameter(ParameterSetName = ConnectPSSessionCommand.InstanceIdParameterSet)]
        public int ThrottleLimit {get; set; }

public override string[] ContainerId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,14416,14479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,14452,14464);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,14416,14479);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,14355,14490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,14355,14490);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Guid[] VMId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,14653,14716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,14689,14701);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,14653,14716);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,14601,14727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,14601,14727);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string[] VMName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,14894,14957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,14930,14942);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,14894,14957);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,14838,14968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,14838,14968);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,15158,15431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,15224,15247);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1588,15224,15246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,15263,15310);

_throttleManager.ThrottleLimit = f_1588_15296_15309();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,15324,15420);

_throttleManager.ThrottleComplete += new EventHandler<EventArgs>(HandleThrottleConnectComplete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,15158,15431);

int
f_1588_15296_15309()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 15296, 15309);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,15158,15431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,15158,15431);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,15553,17361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,15617,15650);

Collection<PSSession> 
psSessions
=default(Collection<PSSession>);

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,15702,16431) || true) && (f_1588_15706_15722()== ConnectPSSessionCommand.ComputerNameParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1588, 15706, 15871)||f_1588_15799_15815()== ConnectPSSessionCommand.ComputerNameGuidParameterSet )||(DynAbs.Tracing.TraceSender.Expression_False(1588, 15706, 15965)||f_1588_15896_15912()== ConnectPSSessionCommand.ConnectionUriParameterSet )||(DynAbs.Tracing.TraceSender.Expression_False(1588, 15706, 16063)||f_1588_15990_16006()== ConnectPSSessionCommand.ConnectionUriGuidParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,15702,16431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,16179,16223);

psSessions = f_1588_16192_16222(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,15702,16431);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,15702,16431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,16369,16412);

psSessions = f_1588_16382_16411(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,15702,16431);
}
            }
            catch (PSRemotingDataStructureException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,16460,16667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,16602,16628);

f_1588_16602_16627(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,16646,16652);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,16460,16667);
            }
            catch (PSRemotingTransportException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,16681,16884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,16819,16845);

f_1588_16819_16844(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,16863,16869);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,16681,16884);
            }
            catch (RemoteException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,16898,17088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17023,17049);

f_1588_17023_17048(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17067,17073);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,16898,17088);
            }
            catch (InvalidRunspaceStateException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,17102,17306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17241,17267);

f_1588_17241_17266(                // Allow cmdlet to end and then re-throw exception.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17285,17291);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,17102,17306);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17322,17350);

f_1588_17322_17349(this, psSessions);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,15553,17361);

string
f_1588_15706_15722()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 15706, 15722);
return return_v;
}


string
f_1588_15799_15815()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 15799, 15815);
return return_v;
}


string
f_1588_15896_15912()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 15896, 15912);
return return_v;
}


string
f_1588_15990_16006()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 15990, 16006);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_16192_16222(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.QueryForDisconnectedSessions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 16192, 16222);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_16382_16411(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.CollectDisconnectedSessions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 16382, 16411);
return return_v;
}


bool
f_1588_16602_16627(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 16602, 16627);
return return_v;
}


bool
f_1588_16819_16844(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 16819, 16844);
return return_v;
}


bool
f_1588_17023_17048(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 17023, 17048);
return return_v;
}


bool
f_1588_17241_17266(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 17241, 17266);
return return_v;
}


int
f_1588_17322_17349(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
psSessions)
{
this_param.ConnectSessions( psSessions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 17322, 17349);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,15553,17361);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,15553,17361);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,17458,18831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17522,17561);

f_1588_17522_17560(            _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17638,17668);

f_1588_17638_17667(
            // Wait for all connect operations to complete.
            _operationsComplete);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17817,17917) || true) && (f_1588_17821_17842(_failedSessions)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,17817,17917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17880,17902);

f_1588_17880_17901(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,17817,17917);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,17990,18192) || true) && (f_1588_17997_18023(f_1588_17997_18017(_stream))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,17990,18192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,18061,18111);

object 
streamObject = f_1588_18083_18110(f_1588_18083_18103(_stream))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,18129,18177);

f_1588_18129_18176(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,17990,18192);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,17990,18192);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,17990,18192);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,18208,18237);

f_1588_18208_18236(f_1588_18208_18228(_stream));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,18330,18820);
foreach(PSSession psSession in f_1588_18362_18374_I(_allSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,18330,18820);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,18408,18805) || true) && (f_1588_18412_18454(f_1588_18412_18448(f_1588_18412_18430(psSession)))== RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,18408,18805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,18738,18786);

f_1588_18738_18785(f_1588_18738_18761(this), psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,18408,18805);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,18330,18820);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,491);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,491);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1588,17458,18831);

int
f_1588_17522_17560(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.EndSubmitOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 17522, 17560);
return 0;
}


bool
f_1588_17638_17667(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 17638, 17667);
return return_v;
}


int
f_1588_17821_17842(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 17821, 17842);
return return_v;
}


int
f_1588_17880_17901(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
this_param.RetryFailedSessions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 17880, 17901);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1588_17997_18017(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 17997, 18017);
return return_v;
}


int
f_1588_17997_18023(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 17997, 18023);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1588_18083_18103(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 18083, 18103);
return return_v;
}


object
f_1588_18083_18110(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 18083, 18110);
return return_v;
}


int
f_1588_18129_18176(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 18129, 18176);
return 0;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1588_18208_18228(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 18208, 18228);
return return_v;
}


int
f_1588_18208_18236(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 18208, 18236);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1588_18412_18430(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 18412, 18430);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_18412_18448(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 18412, 18448);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_18412_18454(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 18412, 18454);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1588_18738_18761(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 18738, 18761);
return return_v;
}


int
f_1588_18738_18785(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 18738, 18785);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_18362_18374_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 18362, 18374);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,17458,18831);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,17458,18831);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,18945,19527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19074,19103);

f_1588_19074_19102(f_1588_19074_19094(_stream));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19187,19223);

f_1588_19187_19222(
            // Stop any remote server queries that may be running.
            _queryRunspaces);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19348,19385);

f_1588_19348_19384(
            // Signal the ThrottleManager to stop any further
            // PSSession connect processing.
            _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19474,19516);

f_1588_19474_19515(
            // Signal the Retry throttle manager in case it is running.
            _retryThrottleManager);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,18945,19527);

System.Management.Automation.Runspaces.PipelineWriter
f_1588_19074_19094(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 19074, 19094);
return return_v;
}


int
f_1588_19074_19102(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 19074, 19102);
return 0;
}


int
f_1588_19187_19222(Microsoft.PowerShell.Commands.QueryRunspaces
this_param)
{
this_param.StopAllOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 19187, 19222);
return 0;
}


int
f_1588_19348_19384(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.StopAllOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 19348, 19384);
return 0;
}


int
f_1588_19474_19515(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.StopAllOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 19474, 19515);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,18945,19527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,18945,19527);
}
		}
private class ConnectRunspaceOperation : IThrottleOperation
{
private PSSession _session;

private PSSession _oldSession;

private ObjectStream _writeStream;

private Collection<PSSession> _retryList;

private PSHost _host;

private QueryRunspaces _queryRunspaces;

private static object s_LockObject ;

internal ConnectRunspaceOperation(
                PSSession session,
                ObjectStream stream,
                PSHost host,
                QueryRunspaces queryRunspaces,
                Collection<PSSession> retryList)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1588,20159,20698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19835,19843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19876,19887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19923,19935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,19980,19990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20020,20025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20063,20078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20428,20447);

_session = session;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20465,20487);

_writeStream = stream;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20505,20518);

_host = host;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20536,20569);

_queryRunspaces = queryRunspaces;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20587,20610);

_retryList = retryList;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20628,20683);

f_1588_20628_20645(_session).StateChanged += StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1588,20159,20698);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,20159,20698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,20159,20698);
}
		}

internal override void StartOperation()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,20714,22635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20786,20818);

bool 
startedSuccessfully = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20838,20858);

Exception 
ex = null
;
                try
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20920,21783) || true) && (_queryRunspaces != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,20920,21783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20997,21046);

PSSession 
newSession = f_1588_21020_21045(this, _session)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21072,21629) || true) && (newSession != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,21072,21629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21152,21207);

f_1588_21152_21169(_session).StateChanged -= StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21237,21260);

_oldSession = _session;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21290,21312);

_session = newSession;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21342,21397);

f_1588_21342_21359(_session).StateChanged += StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21427,21460);

f_1588_21427_21459(f_1588_21427_21444(_session));
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,21072,21629);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,21072,21629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21574,21602);

startedSuccessfully = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,21072,21629);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,20920,21783);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,20920,21783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21727,21760);

f_1588_21727_21759(f_1588_21727_21744(_session));
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,20920,21783);
}
                }
                catch (PSInvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,21820,21924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,21898,21905);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,21820,21924);
                }
                catch (InvalidRunspacePoolStateException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,21942,22052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22026,22033);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,21942,22052);
                }
                catch (RuntimeException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,22070,22163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22137,22144);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,22070,22163);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22183,22341) || true) && (ex != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,22183,22341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22239,22267);

startedSuccessfully = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22289,22322);

f_1588_22289_22321(this, ex, _session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,22183,22341);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22361,22620) || true) && (!startedSuccessfully)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,22361,22620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22504,22559);

f_1588_22504_22521(_session).StateChanged -= StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22581,22601);

f_1588_22581_22600(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,22361,22620);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,20714,22635);

System.Management.Automation.Runspaces.PSSession
f_1588_21020_21045(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
var return_v = this_param.QueryForSession( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 21020, 21045);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_21152_21169(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 21152, 21169);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_21342_21359(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 21342, 21359);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_21427_21444(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 21427, 21444);
return return_v;
}


int
f_1588_21427_21459(System.Management.Automation.Runspaces.Runspace
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 21427, 21459);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1588_21727_21744(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 21727, 21744);
return return_v;
}


int
f_1588_21727_21759(System.Management.Automation.Runspaces.Runspace
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 21727, 21759);
return 0;
}


int
f_1588_22289_22321(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param,System.Exception
e,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.WriteConnectFailed( e, session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 22289, 22321);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1588_22504_22521(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 22504, 22521);
return return_v;
}


int
f_1588_22581_22600(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param)
{
this_param.SendStartComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 22581, 22600);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,20714,22635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,20714,22635);
}
		}

internal override void StopOperation()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,22651,22973);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22722,22846) || true) && (_queryRunspaces != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,22722,22846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22791,22827);

f_1588_22791_22826(                    _queryRunspaces);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,22722,22846);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22866,22921);

f_1588_22866_22883(_session).StateChanged -= StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,22939,22958);

f_1588_22939_22957(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,22651,22973);

int
f_1588_22791_22826(Microsoft.PowerShell.Commands.QueryRunspaces
this_param)
{
this_param.StopAllOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 22791, 22826);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1588_22866_22883(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 22866, 22883);
return return_v;
}


int
f_1588_22939_22957(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param)
{
this_param.SendStopComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 22939, 22957);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,22651,22973);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,22651,22973);
}
		}

            internal override event EventHandler<OperationStateEventArgs> 
OperationComplete
;

internal PSSession QueryForSession(PSSession session)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,23085,24426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23171,23264);

Collection<WSManConnectionInfo> 
wsManConnectionInfos = f_1588_23226_23263()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23282,23363);

f_1588_23282_23362(                wsManConnectionInfos, f_1588_23307_23338(f_1588_23307_23323(session))as WSManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23383,23403);

Exception 
ex = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23421,23459);

Collection<PSSession> 
sessions = null
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23521,23729);

sessions = f_1588_23532_23728(_queryRunspaces, wsManConnectionInfos, _host, _writeStream, null, 0, SessionFilterState.Disconnected, new Guid[] { f_1588_23695_23713(session)}, null, null);
                }
                catch (RuntimeException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1588,23766,23859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23833,23840);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1588,23766,23859);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23879,24020) || true) && (ex != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,23879,24020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23935,23967);

f_1588_23935_23966(this, ex, session);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,23989,24001);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,23879,24020);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24040,24372) || true) && (f_1588_24044_24058(sessions)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,24040,24372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24105,24263);

ex = f_1588_24110_24262(f_1588_24131_24261(f_1588_24149_24199(), f_1588_24226_24238(session), f_1588_24240_24260(session)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24287,24319);

f_1588_24287_24318(this, ex, session);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24341,24353);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,24040,24372);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24392,24411);

return f_1588_24399_24410(sessions, 0);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,23085,24426);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
f_1588_23226_23263()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 23226, 23263);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_23307_23323(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 23307, 23323);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1588_23307_23338(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 23307, 23338);
return return_v;
}


int
f_1588_23282_23362(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
this_param,System.Management.Automation.Runspaces.RunspaceConnectionInfo
item)
{
this_param.Add( (System.Management.Automation.Runspaces.WSManConnectionInfo)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 23282, 23362);
return 0;
}


System.Guid
f_1588_23695_23713(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 23695, 23713);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_23532_23728(Microsoft.PowerShell.Commands.QueryRunspaces
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
connectionInfos,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Internal.ObjectStream
stream,System.Management.Automation.RunspaceRepository
runspaceRepository,int
throttleLimit,Microsoft.PowerShell.Commands.SessionFilterState
filterState,System.Guid[]
matchIds,string[]
matchNames,string
configurationName)
{
var return_v = this_param.GetDisconnectedSessions( connectionInfos, host, stream, runspaceRepository, throttleLimit, filterState, matchIds, matchNames, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 23532, 23728);
return return_v;
}


int
f_1588_23935_23966(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param,System.Exception
e,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.WriteConnectFailed( e, session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 23935, 23966);
return 0;
}


int
f_1588_24044_24058(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24044, 24058);
return return_v;
}


string
f_1588_24149_24199()
{
var return_v = RemotingErrorIdStrings.CannotFindSessionForConnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24149, 24199);
return return_v;
}


string
f_1588_24226_24238(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24226, 24238);
return return_v;
}


string
f_1588_24240_24260(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24240, 24260);
return return_v;
}


string
f_1588_24131_24261(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 24131, 24261);
return return_v;
}


System.Management.Automation.RuntimeException
f_1588_24110_24262(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 24110, 24262);
return return_v;
}


int
f_1588_24287_24318(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param,System.Exception
e,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.WriteConnectFailed( e, session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 24287, 24318);
return 0;
}


System.Management.Automation.Runspaces.PSSession
f_1588_24399_24410(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24399, 24410);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,23085,24426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,23085,24426);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void StateCallBackHandler(object sender, RunspaceStateEventArgs eArgs)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,24442,26699);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24553,24851) || true) && (f_1588_24557_24586(f_1588_24557_24580(eArgs))== RunspaceState.Connecting ||(DynAbs.Tracing.TraceSender.Expression_False(1588, 24557, 24699)||f_1588_24639_24668(f_1588_24639_24662(eArgs))== RunspaceState.Disconnecting )||(DynAbs.Tracing.TraceSender.Expression_False(1588, 24557, 24783)||f_1588_24724_24753(f_1588_24724_24747(eArgs))== RunspaceState.Disconnected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,24553,24851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24825,24832);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,24553,24851);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,24871,25005);

f_1588_24871_25004(f_1588_24882_24911(f_1588_24882_24905(eArgs))!= RunspaceState.BeforeOpen, "Can't reconnect a session that hasn't been previously Opened");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,25023,25154);

f_1588_25023_25153(f_1588_25034_25063(f_1588_25034_25057(eArgs))!= RunspaceState.Opening, "Can't reconnect a session that hasn't been previously Opened");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,25174,26571) || true) && (f_1588_25178_25207(f_1588_25178_25201(eArgs))== RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,25174,26571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,25354,25380);

f_1588_25354_25379(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,25174,26571);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,25174,26571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,25609,25632);

bool 
writeError = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,25654,26313) || true) && (_queryRunspaces == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,25654,26313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,25731,25844);

PSRemotingTransportException 
transportException = f_1588_25781_25811(f_1588_25781_25804(eArgs))as PSRemotingTransportException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,25870,26290) || true) && (transportException != null &&(DynAbs.Tracing.TraceSender.Expression_True(1588, 25874, 26014)&&f_1588_25933_25961(transportException)== WSManNativeApi.ERROR_WSMAN_INUSE_CANNOT_RECONNECT))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,25870,26290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26078,26090);
                            lock (s_LockObject)
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26156,26181);

f_1588_26156_26180(                                _retryList, _session);
                            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26244,26263);

writeError = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,25870,26290);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,25654,26313);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26337,26552) || true) && (writeError)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,26337,26552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26468,26529);

f_1588_26468_26528(this, f_1588_26487_26517(f_1588_26487_26510(eArgs)), _session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,26337,26552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,25174,26571);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26591,26646);

f_1588_26591_26608(_session).StateChanged -= StateCallBackHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26664,26684);

f_1588_26664_26683(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,24442,26699);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_24557_24580(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24557, 24580);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_24557_24586(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24557, 24586);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_24639_24662(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24639, 24662);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_24639_24668(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24639, 24668);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_24724_24747(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24724, 24747);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_24724_24753(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24724, 24753);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_24882_24905(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24882, 24905);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_24882_24911(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 24882, 24911);
return return_v;
}


int
f_1588_24871_25004(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 24871, 25004);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_25034_25057(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 25034, 25057);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_25034_25063(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 25034, 25063);
return return_v;
}


int
f_1588_25023_25153(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 25023, 25153);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_25178_25201(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 25178, 25201);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_25178_25207(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 25178, 25207);
return return_v;
}


int
f_1588_25354_25379(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param)
{
this_param.WriteConnectedPSSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 25354, 25379);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_25781_25804(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 25781, 25804);
return return_v;
}


System.Exception
f_1588_25781_25811(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 25781, 25811);
return return_v;
}


int
f_1588_25933_25961(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 25933, 25961);
return return_v;
}


int
f_1588_26156_26180(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 26156, 26180);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_26487_26510(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 26487, 26510);
return return_v;
}


System.Exception
f_1588_26487_26517(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 26487, 26517);
return return_v;
}


int
f_1588_26468_26528(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param,System.Exception
e,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.WriteConnectFailed( e, session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 26468, 26528);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1588_26591_26608(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 26591, 26608);
return return_v;
}


int
f_1588_26664_26683(Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
this_param)
{
this_param.SendStartComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 26664, 26683);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,24442,26699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,24442,26699);
}
		}

private void SendStartComplete()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,26715,27041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26780,26860);

OperationStateEventArgs 
operationStateEventArgs = f_1588_26830_26859()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26878,26948);

operationStateEventArgs.OperationState = OperationState.StartComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,26966,27026);

f_1588_26966_27025(                OperationComplete, this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,26715,27041);

System.Management.Automation.Remoting.OperationStateEventArgs
f_1588_26830_26859()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 26830, 26859);
return return_v;
}


int
f_1588_26966_27025(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
eventHandler,Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
sender,System.Management.Automation.Remoting.OperationStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 26966, 27025);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,26715,27041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,26715,27041);
}
		}

private void SendStopComplete()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,27057,27381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,27121,27201);

OperationStateEventArgs 
operationStateEventArgs = f_1588_27171_27200()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,27219,27288);

operationStateEventArgs.OperationState = OperationState.StopComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,27306,27366);

f_1588_27306_27365(                OperationComplete, this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,27057,27381);

System.Management.Automation.Remoting.OperationStateEventArgs
f_1588_27171_27200()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 27171, 27200);
return return_v;
}


int
f_1588_27306_27365(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
eventHandler,Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
sender,System.Management.Automation.Remoting.OperationStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 27306, 27365);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,27057,27381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,27057,27381);
}
		}

private void WriteConnectedPSSession()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,27397,28991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,27603,27635);

PSSession 
outSession = _session
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,27653,28330) || true) && (_queryRunspaces != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,27653,28330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,27728,27740);
                    lock (s_LockObject)
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,27862,28288) || true) && (_oldSession != null &&(DynAbs.Tracing.TraceSender.Expression_True(1588, 27866, 27981)&&f_1588_27918_27981(                            _oldSession, f_1588_27945_27962(_session)as RemoteRunspace)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,27862,28288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,28039,28064);

outSession = _oldSession;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,28094,28122);

f_1588_28094_28121(                            _retryList, _oldSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,27862,28288);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,27862,28288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,28236,28261);

f_1588_28236_28260(                            _retryList, _session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,27862,28288);
}
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,27653,28330);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,28350,28976) || true) && (f_1588_28354_28386(f_1588_28354_28379(_writeStream)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,28350,28976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,28731,28889);

Action<Cmdlet> 
outputWriter = delegate (Cmdlet cmdlet)
                    {
                        cmdlet.WriteObject(outSession);
                    }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,28911,28957);

f_1588_28911_28956(f_1588_28911_28936(_writeStream), outputWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,28350,28976);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,27397,28991);

System.Management.Automation.Runspaces.Runspace
f_1588_27945_27962(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 27945, 27962);
return return_v;
}


bool
f_1588_27918_27981(System.Management.Automation.Runspaces.PSSession
this_param,System.Management.Automation.Runspaces.Runspace
remoteRunspace)
{
var return_v = this_param.InsertRunspace( (System.Management.Automation.RemoteRunspace)remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 27918, 27981);
return return_v;
}


int
f_1588_28094_28121(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 28094, 28121);
return 0;
}


int
f_1588_28236_28260(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 28236, 28260);
return 0;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1588_28354_28379(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 28354, 28379);
return return_v;
}


bool
f_1588_28354_28386(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 28354, 28386);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1588_28911_28936(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 28911, 28936);
return return_v;
}


int
f_1588_28911_28956(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 28911, 28956);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,27397,28991);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,27397,28991);
}
		}

private void WriteConnectFailed(
                Exception e,
                PSSession session)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,29007,30802);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29138,30787) || true) && (f_1588_29142_29174(f_1588_29142_29167(_writeStream)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,29138,30787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29216,29256);

string 
FQEID = "PSSessionConnectFailed"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29278,29295);

Exception 
reason
=default(Exception);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29317,30403) || true) && (e != null &&(DynAbs.Tracing.TraceSender.Expression_True(1588, 29321, 29366)&&!f_1588_29335_29366(f_1588_29356_29365(e))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,29317,30403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29506,29590);

PSRemotingTransportException 
transportException = e as PSRemotingTransportException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29616,29830) || true) && (transportException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,29616,29830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29704,29803);

FQEID = f_1588_29712_29802(f_1588_29766_29794(transportException), FQEID);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,29616,29830);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,29858,30051);

reason = f_1588_29867_30050(f_1588_29918_30017(f_1588_29936_29991(), f_1588_29993_30005(session), f_1588_30007_30016(e)), e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,29317,30403);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,29317,30403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,30149,30380);

reason = f_1588_30158_30379(f_1588_30209_30372(f_1588_30227_30271(), f_1588_30273_30285(session), f_1588_30320_30371(f_1588_30320_30360(f_1588_30320_30354(f_1588_30320_30336(session))))), null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,29317,30403);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,30427,30522);

ErrorRecord 
errorRecord = f_1588_30453_30521(reason, FQEID, ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,30544,30701);

Action<Cmdlet> 
errorWriter = delegate (Cmdlet cmdlet)
                    {
                        cmdlet.WriteError(errorRecord);
                    }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,30723,30768);

f_1588_30723_30767(f_1588_30723_30748(_writeStream), errorWriter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,29138,30787);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,29007,30802);

System.Management.Automation.Runspaces.PipelineWriter
f_1588_29142_29167(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 29142, 29167);
return return_v;
}


bool
f_1588_29142_29174(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 29142, 29174);
return return_v;
}


string
f_1588_29356_29365(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 29356, 29365);
return return_v;
}


bool
f_1588_29335_29366(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 29335, 29366);
return return_v;
}


int
f_1588_29766_29794(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 29766, 29794);
return return_v;
}


string
f_1588_29712_29802(int
transportErrorCode,string
defaultFQEID)
{
var return_v = WSManTransportManagerUtils.GetFQEIDFromTransportError( transportErrorCode, defaultFQEID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 29712, 29802);
return return_v;
}


string
f_1588_29936_29991()
{
var return_v = RemotingErrorIdStrings.RunspaceConnectFailedWithMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 29936, 29991);
return return_v;
}


string
f_1588_29993_30005(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 29993, 30005);
return return_v;
}


string
f_1588_30007_30016(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 30007, 30016);
return return_v;
}


string
f_1588_29918_30017(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 29918, 30017);
return return_v;
}


System.Management.Automation.RuntimeException
f_1588_29867_30050(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 29867, 30050);
return return_v;
}


string
f_1588_30227_30271()
{
var return_v = RemotingErrorIdStrings.RunspaceConnectFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 30227, 30271);
return return_v;
}


string
f_1588_30273_30285(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 30273, 30285);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_30320_30336(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 30320, 30336);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_30320_30354(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 30320, 30354);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_30320_30360(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 30320, 30360);
return return_v;
}


string
f_1588_30320_30371(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 30320, 30371);
return return_v;
}


string
f_1588_30209_30372(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 30209, 30372);
return return_v;
}


System.Management.Automation.RuntimeException
f_1588_30158_30379(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 30158, 30379);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1588_30453_30521(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 30453, 30521);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1588_30723_30748(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 30723, 30748);
return return_v;
}


int
f_1588_30723_30767(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 30723, 30767);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,29007,30802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,29007,30802);
}
		}

static ConnectRunspaceOperation()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1588,19733,30813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,20115,20142);
s_LockObject = f_1588_20130_20142();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1588,19733,30813);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,19733,30813);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1588,19733,30813);

static object
f_1588_20130_20142()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 20130, 20142);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_20628_20645(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 20628, 20645);
return return_v;
}

}

        
        
        /// <summary>
        /// Enum indicating an override on which parameter is used to filter
        /// local sessions.
        /// </summary>
        private enum OverrideParameter
        {
            /// <summary>
            /// No override.
            /// </summary>
            None = 0,

            /// <summary>
            /// Use the Name parameter as a filter.
            /// </summary>
            Name = 1,

            /// <summary>
            /// Use the InstanceId parameter as a filter.
            /// </summary>
            InstanceId = 2
        }

private Collection<PSSession> QueryForDisconnectedSessions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,31724,32584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,31809,31882);

Collection<WSManConnectionInfo> 
connectionInfos = f_1588_31859_31881(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,31896,32234);

Collection<PSSession> 
psSessions = f_1588_31931_32233(_queryRunspaces, connectionInfos, f_1588_31988_31997(this), _stream, f_1588_32061_32084(this), f_1588_32086_32099(), SessionFilterState.Disconnected, f_1588_32187_32202(this), f_1588_32204_32213(this), f_1588_32215_32232())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,32309,32383);

Collection<object> 
streamObjects = f_1588_32344_32382(f_1588_32344_32364(_stream))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,32397,32539);
foreach(object streamObject in f_1588_32429_32442_I(streamObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,32397,32539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,32476,32524);

f_1588_32476_32523(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,32397,32539);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,143);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,143);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,32555,32573);

return psSessions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,31724,32584);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
f_1588_31859_31881(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.GetConnectionObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 31859, 31881);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1588_31988_31997(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 31988, 31997);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1588_32061_32084(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 32061, 32084);
return return_v;
}


int
f_1588_32086_32099()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 32086, 32099);
return return_v;
}


System.Guid[]
f_1588_32187_32202(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 32187, 32202);
return return_v;
}


string[]
f_1588_32204_32213(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 32204, 32213);
return return_v;
}


string
f_1588_32215_32232()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 32215, 32232);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_31931_32233(Microsoft.PowerShell.Commands.QueryRunspaces
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
connectionInfos,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Internal.ObjectStream
stream,System.Management.Automation.RunspaceRepository
runspaceRepository,int
throttleLimit,Microsoft.PowerShell.Commands.SessionFilterState
filterState,System.Guid[]
matchIds,string[]
matchNames,string
configurationName)
{
var return_v = this_param.GetDisconnectedSessions( connectionInfos, host, stream, runspaceRepository, throttleLimit, filterState, matchIds, matchNames, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 31931, 32233);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1588_32344_32364(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 32344, 32364);
return return_v;
}


System.Collections.ObjectModel.Collection<object>
f_1588_32344_32382(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.NonBlockingRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 32344, 32382);
return return_v;
}


int
f_1588_32476_32523(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 32476, 32523);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_1588_32429_32442_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 32429, 32442);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,31724,32584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,31724,32584);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Collection<PSSession> CollectDisconnectedSessions(OverrideParameter overrideParam = OverrideParameter.None)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,32881,34456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33021,33084);

Collection<PSSession> 
psSessions = f_1588_33056_33083()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33156,34411) || true) && (f_1588_33160_33176()== DisconnectPSSessionCommand.SessionParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,33156,34411);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33260,33478) || true) && (f_1588_33264_33271()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,33260,33478);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33321,33459);
foreach(PSSession psSession in f_1588_33353_33360_I(f_1588_33353_33360()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,33321,33459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33410,33436);

f_1588_33410_33435(                        psSessions, psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,33321,33459);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,139);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,139);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1588,33260,33478);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,33156,34411);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,33156,34411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33544,33587);

Dictionary<Guid, PSSession> 
entries = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33607,34151);

switch (overrideParam)
                {

case OverrideParameter.None:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,33607,34151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33724,33768);

entries = f_1588_33734_33767(this, false, true);
DynAbs.Tracing.TraceSender.TraceBreak(1588,33794,33800);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,33607,34151);

case OverrideParameter.Name:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,33607,34151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,33878,33928);

entries = f_1588_33888_33927(this, false, true);
DynAbs.Tracing.TraceSender.TraceBreak(1588,33954,33960);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,33607,34151);

case OverrideParameter.InstanceId:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,33607,34151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34044,34100);

entries = f_1588_34054_34099(this, false, true);
DynAbs.Tracing.TraceSender.TraceBreak(1588,34126,34132);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,33607,34151);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34171,34396) || true) && (entries != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,34171,34396);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34232,34377);
foreach(PSSession psSession in f_1588_34264_34278_I(f_1588_34264_34278(entries)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,34232,34377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34328,34354);

f_1588_34328_34353(                        psSessions, psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,34232,34377);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,146);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,146);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1588,34171,34396);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,33156,34411);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34427,34445);

return psSessions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,32881,34456);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_33056_33083()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 33056, 33083);
return return_v;
}


string
f_1588_33160_33176()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 33160, 33176);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1588_33264_33271()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 33264, 33271);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1588_33353_33360()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 33353, 33360);
return return_v;
}


int
f_1588_33410_33435(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 33410, 33435);
return 0;
}


System.Management.Automation.Runspaces.PSSession[]
f_1588_33353_33360_I(System.Management.Automation.Runspaces.PSSession[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 33353, 33360);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1588_33734_33767(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspaces( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 33734, 33767);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1588_33888_33927(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspacesByName( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 33888, 33927);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1588_34054_34099(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspacesByRunspaceId( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 34054, 34099);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
f_1588_34264_34278(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 34264, 34278);
return return_v;
}


int
f_1588_34328_34353(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 34328, 34353);
return 0;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
f_1588_34264_34278_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 34264, 34278);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,32881,34456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,32881,34456);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ConnectSessions(Collection<PSSession> psSessions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,34563,38175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34650,34726);

List<IThrottleOperation> 
connectOperations = f_1588_34695_34725()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34821,37515);
foreach(PSSession psSession in f_1588_34853_34863_I(psSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,34821,37515);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,34897,37452) || true) && (f_1588_34901_34959(this, f_1588_34915_34929(psSession), VerbsCommunications.Connect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,34897,37452);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,35001,37433) || true) && (f_1588_35005_35027(psSession)!= TargetMachineType.RemoteMachine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,35001,37433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,35209,35404);

string 
msg = f_1588_35222_35403(f_1588_35240_35309(), f_1588_35340_35354(psSession), f_1588_35356_35378(psSession), f_1588_35380_35402(psSession))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,35430,35482);

Exception 
reason = f_1588_35449_35481(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,35508,35636);

ErrorRecord 
errorRecord = f_1588_35534_35635(reason, "CannotConnectVMContainerSession", ErrorCategory.InvalidOperation, psSession)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,35662,35686);

f_1588_35662_35685(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,35001,37433);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,35001,37433);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,35736,37433) || true) && (f_1588_35740_35782(f_1588_35740_35776(f_1588_35740_35758(psSession)))== RunspaceState.Disconnected &&(DynAbs.Tracing.TraceSender.Expression_True(1588, 35740, 35909)&&f_1588_35841_35880(f_1588_35841_35859(psSession))== RunspaceAvailability.None))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,35736,37433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,36139,36218);

f_1588_36139_36217(this, f_1588_36160_36193(f_1588_36160_36178(psSession))as WSManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,36246,36519);

ConnectRunspaceOperation 
connectOperation = f_1588_36290_36518(psSession, _stream, f_1588_36427_36436(this), null, _failedSessions)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,36545,36585);

f_1588_36545_36584(                        connectOperations, connectOperation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,35736,37433);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,35736,37433);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,36635,37433) || true) && (f_1588_36639_36681(f_1588_36639_36675(f_1588_36639_36657(psSession)))!= RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,36635,37433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,36850,36947);

string 
msg = f_1588_36863_36946(f_1588_36881_36929(), f_1588_36931_36945(psSession))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,36973,37018);

Exception 
reason = f_1588_36992_37017(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37044,37163);

ErrorRecord 
errorRecord = f_1588_37070_37162(reason, "PSSessionConnectFailed", ErrorCategory.InvalidOperation, psSession)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37189,37213);

f_1588_37189_37212(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,36635,37433);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,36635,37433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37387,37410);

f_1588_37387_37409(this, psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,36635,37433);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,35736,37433);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,35001,37433);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,34897,37452);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37472,37500);

f_1588_37472_37499(
                _allSessions, psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,34821,37515);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,2695);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,2695);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37531,38164) || true) && (f_1588_37535_37558(connectOperations)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,37531,38164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37685,37713);

f_1588_37685_37712(                // Make sure operations are not set as complete while processing input.
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37788,37841);

f_1588_37788_37840(
                // Submit list of connect operations.
                _throttleManager, connectOperations);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37903,37977);

Collection<object> 
streamObjects = f_1588_37938_37976(f_1588_37938_37958(_stream))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,37995,38149);
foreach(object streamObject in f_1588_38027_38040_I(streamObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,37995,38149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,38082,38130);

f_1588_38082_38129(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,37995,38149);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,155);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,155);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1588,37531,38164);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,34563,38175);

System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1588_34695_34725()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 34695, 34725);
return return_v;
}


string
f_1588_34915_34929(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 34915, 34929);
return return_v;
}


bool
f_1588_34901_34959(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 34901, 34959);
return return_v;
}


System.Management.Automation.Runspaces.TargetMachineType
f_1588_35005_35027(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35005, 35027);
return return_v;
}


string
f_1588_35240_35309()
{
var return_v = RemotingErrorIdStrings.RunspaceCannotBeConnectedForVMContainerSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35240, 35309);
return return_v;
}


string
f_1588_35340_35354(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35340, 35354);
return return_v;
}


string
f_1588_35356_35378(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35356, 35378);
return return_v;
}


System.Management.Automation.Runspaces.TargetMachineType
f_1588_35380_35402(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35380, 35402);
return return_v;
}


string
f_1588_35222_35403(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 35222, 35403);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1588_35449_35481(string
message)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 35449, 35481);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1588_35534_35635(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 35534, 35635);
return return_v;
}


int
f_1588_35662_35685(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 35662, 35685);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1588_35740_35758(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35740, 35758);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_35740_35776(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35740, 35776);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_35740_35782(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35740, 35782);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_35841_35859(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35841, 35859);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1588_35841_35880(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 35841, 35880);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1588_36160_36178(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36160, 36178);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1588_36160_36193(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36160, 36193);
return return_v;
}


int
f_1588_36139_36217(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( (System.Management.Automation.Runspaces.WSManConnectionInfo)connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 36139, 36217);
return 0;
}


System.Management.Automation.Host.PSHost
f_1588_36427_36436(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36427, 36436);
return return_v;
}


Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
f_1588_36290_36518(System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.Internal.ObjectStream
stream,System.Management.Automation.Host.PSHost
host,Microsoft.PowerShell.Commands.QueryRunspaces
queryRunspaces,System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
retryList)
{
var return_v = new Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation( session, stream, host, queryRunspaces, retryList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 36290, 36518);
return return_v;
}


int
f_1588_36545_36584(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
item)
{
this_param.Add( (System.Management.Automation.Remoting.IThrottleOperation)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 36545, 36584);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1588_36639_36657(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36639, 36657);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1588_36639_36675(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36639, 36675);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1588_36639_36681(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36639, 36681);
return return_v;
}


string
f_1588_36881_36929()
{
var return_v = RemotingErrorIdStrings.RunspaceCannotBeConnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36881, 36929);
return return_v;
}


string
f_1588_36931_36945(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 36931, 36945);
return return_v;
}


string
f_1588_36863_36946(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 36863, 36946);
return return_v;
}


System.Management.Automation.RuntimeException
f_1588_36992_37017(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 36992, 37017);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1588_37070_37162(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 37070, 37162);
return return_v;
}


int
f_1588_37189_37212(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 37189, 37212);
return 0;
}


int
f_1588_37387_37409(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 37387, 37409);
return 0;
}


int
f_1588_37472_37499(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 37472, 37499);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_34853_34863_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 34853, 34863);
return return_v;
}


int
f_1588_37535_37558(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 37535, 37558);
return return_v;
}


bool
f_1588_37685_37712(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 37685, 37712);
return return_v;
}


int
f_1588_37788_37840(System.Management.Automation.Remoting.ThrottleManager
this_param,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
operations)
{
this_param.SubmitOperations( operations);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 37788, 37840);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1588_37938_37958(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 37938, 37958);
return return_v;
}


System.Collections.ObjectModel.Collection<object>
f_1588_37938_37976(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.NonBlockingRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 37938, 37976);
return return_v;
}


int
f_1588_38082_38129(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 38082, 38129);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_1588_38027_38040_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 38027, 38040);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,34563,38175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,34563,38175);
}
		}

private void HandleThrottleConnectComplete(object sender, EventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,38425,38565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,38528,38554);

f_1588_38528_38553(            _operationsComplete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,38425,38565);

bool
f_1588_38528_38553(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 38528, 38553);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,38425,38565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,38425,38565);
}
		}

private Collection<WSManConnectionInfo> GetConnectionObjects()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,38577,41227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,38664,38752);

Collection<WSManConnectionInfo> 
connectionInfos = f_1588_38714_38751()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,38768,41177) || true) && (f_1588_38772_38788()== ConnectPSSessionCommand.ComputerNameParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1588, 38772, 38933)||f_1588_38861_38877()== ConnectPSSessionCommand.ComputerNameGuidParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,38768,41177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,38967,39067);

string 
scheme = (DynAbs.Tracing.TraceSender.Conditional_F1(1588, 38983, 38999)||((f_1588_38983_38989().IsPresent &&DynAbs.Tracing.TraceSender.Conditional_F2(1588, 39002, 39033))||DynAbs.Tracing.TraceSender.Conditional_F3(1588, 39036, 39066)))?WSManConnectionInfo.HttpsScheme :WSManConnectionInfo.HttpScheme
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39087,40097);
foreach(string computerName in f_1588_39119_39131_I(f_1588_39119_39131()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,39087,40097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39173,39236);

WSManConnectionInfo 
connectionInfo = f_1588_39210_39235()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39258,39289);

connectionInfo.Scheme = scheme;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39311,39375);

connectionInfo.ComputerName = f_1588_39341_39374(this, computerName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39397,39438);

connectionInfo.AppName = f_1588_39422_39437();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39460,39504);

connectionInfo.ShellUri = f_1588_39486_39503();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39526,39553);

connectionInfo.Port = f_1588_39548_39552();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39575,39879) || true) && (f_1588_39579_39600()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,39575,39879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39658,39719);

connectionInfo.CertificateThumbprint = f_1588_39697_39718();
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,39575,39879);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,39575,39879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39817,39856);

connectionInfo.Credential = f_1588_39845_39855();
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,39575,39879);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39903,39959);

connectionInfo.AuthenticationMechanism = f_1588_39944_39958();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,39981,40018);

f_1588_39981_40017(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40042,40078);

f_1588_40042_40077(
                    connectionInfos, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,39087,40097);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,1011);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,1011);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1588,38768,41177);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,38768,41177);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40131,41177) || true) && (f_1588_40135_40151()== ConnectPSSessionCommand.ConnectionUriParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1588, 40135, 40303)||f_1588_40230_40246()== ConnectPSSessionCommand.ConnectionUriGuidParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,40131,41177);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40337,41162);
foreach(var connectionUri in f_1588_40367_40380_I(f_1588_40367_40380()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,40337,41162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40422,40485);

WSManConnectionInfo 
connectionInfo = f_1588_40459_40484()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40507,40552);

connectionInfo.ConnectionUri = connectionUri;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40574,40618);

connectionInfo.ShellUri = f_1588_40600_40617();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40640,40944) || true) && (f_1588_40644_40665()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,40640,40944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40723,40784);

connectionInfo.CertificateThumbprint = f_1588_40762_40783();
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,40640,40944);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,40640,40944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40882,40921);

connectionInfo.Credential = f_1588_40910_40920();
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,40640,40944);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,40968,41024);

connectionInfo.AuthenticationMechanism = f_1588_41009_41023();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,41046,41083);

f_1588_41046_41082(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,41107,41143);

f_1588_41107_41142(
                    connectionInfos, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,40337,41162);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,826);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,826);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1588,40131,41177);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,38768,41177);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,41193,41216);

return connectionInfos;
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,38577,41227);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
f_1588_38714_38751()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 38714, 38751);
return return_v;
}


string
f_1588_38772_38788()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 38772, 38788);
return return_v;
}


string
f_1588_38861_38877()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 38861, 38877);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1588_38983_38989()
{
var return_v = UseSSL;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 38983, 38989);
return return_v;
}


string[]
f_1588_39119_39131()
{
var return_v = ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39119, 39131);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1588_39210_39235()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 39210, 39235);
return return_v;
}


string
f_1588_39341_39374(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 39341, 39374);
return return_v;
}


string
f_1588_39422_39437()
{
var return_v = ApplicationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39422, 39437);
return return_v;
}


string
f_1588_39486_39503()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39486, 39503);
return return_v;
}


int
f_1588_39548_39552()
{
var return_v = Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39548, 39552);
return return_v;
}


string
f_1588_39579_39600()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39579, 39600);
return return_v;
}


string
f_1588_39697_39718()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39697, 39718);
return return_v;
}


System.Management.Automation.PSCredential
f_1588_39845_39855()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39845, 39855);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1588_39944_39958()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 39944, 39958);
return return_v;
}


int
f_1588_39981_40017(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 39981, 40017);
return 0;
}


int
f_1588_40042_40077(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 40042, 40077);
return 0;
}


string[]
f_1588_39119_39131_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 39119, 39131);
return return_v;
}


string
f_1588_40135_40151()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 40135, 40151);
return return_v;
}


string
f_1588_40230_40246()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 40230, 40246);
return return_v;
}


System.Uri[]
f_1588_40367_40380()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 40367, 40380);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1588_40459_40484()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 40459, 40484);
return return_v;
}


string
f_1588_40600_40617()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 40600, 40617);
return return_v;
}


string
f_1588_40644_40665()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 40644, 40665);
return return_v;
}


string
f_1588_40762_40783()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 40762, 40783);
return return_v;
}


System.Management.Automation.PSCredential
f_1588_40910_40920()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 40910, 40920);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1588_41009_41023()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 41009, 41023);
return return_v;
}


int
f_1588_41046_41082(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 41046, 41082);
return 0;
}


int
f_1588_41107_41142(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 41107, 41142);
return 0;
}


System.Uri[]
f_1588_40367_40380_I(System.Uri[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 40367, 40380);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,38577,41227);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,38577,41227);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void UpdateConnectionInfo(WSManConnectionInfo connectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,41419,42296);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,41513,41859) || true) && (f_1588_41517_41533()!= ConnectPSSessionCommand.ConnectionUriParameterSet &&(DynAbs.Tracing.TraceSender.Expression_True(1588, 41517, 41680)&&f_1588_41607_41623()!= ConnectPSSessionCommand.ConnectionUriGuidParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,41513,41859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,41791,41844);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,41513,41859);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,41875,42066) || true) && (!_allowRedirection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,41875,42066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,41998,42051);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,41875,42066);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,42163,42285) || true) && (f_1588_42167_42180()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,42163,42285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,42222,42270);

f_1588_42222_42269(                connectionInfo, f_1588_42255_42268());
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,42163,42285);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,41419,42296);

string
f_1588_41517_41533()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 41517, 41533);
return return_v;
}


string
f_1588_41607_41623()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 41607, 41623);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1588_42167_42180()
{
var return_v = SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 42167, 42180);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1588_42255_42268()
{
var return_v = SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 42255, 42268);
return return_v;
}


int
f_1588_42222_42269(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param,System.Management.Automation.Remoting.PSSessionOption
options)
{
this_param.SetSessionOptions( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 42222, 42269);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,41419,42296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,41419,42296);
}
		}

private void RetryFailedSessions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,42308,43894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,42367,43883);
using(ManualResetEvent 
retrysComplete = f_1588_42408_42435(false)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,42469,42539);

Collection<PSSession> 
connectedSessions = f_1588_42511_42538()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,42557,42641);

List<IThrottleOperation> 
retryConnectionOperations = f_1588_42610_42640()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,42659,42711);

_retryThrottleManager.ThrottleLimit = f_1588_42697_42710();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,42729,43035);

_retryThrottleManager.ThrottleComplete += (sender, eventArgs) =>
                    {
                        try
                        {
                            retrysComplete.Set();
                        }
                        catch (ObjectDisposedException) { }
                    };
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,43055,43411);
foreach(var session in f_1588_43079_43094_I(_failedSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,43055,43411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,43136,43392);

f_1588_43136_43391(                    retryConnectionOperations, f_1588_43166_43390(session, _stream, f_1588_43289_43298(this), f_1588_43325_43345(), connectedSessions));
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,43055,43411);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,357);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,357);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,43431,43497);

f_1588_43431_43496(
                _retryThrottleManager, retryConnectionOperations);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,43515,43559);

f_1588_43515_43558(                _retryThrottleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,43579,43604);

f_1588_43579_43603(
                retrysComplete);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,43720,43868);
foreach(var session in f_1588_43744_43761_I(connectedSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,43720,43868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,43803,43849);

f_1588_43803_43848(f_1588_43803_43826(this), session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,43720,43868);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1588,1,149);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1588,1,149);
}DynAbs.Tracing.TraceSender.TraceExitUsing(1588,42367,43883);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,42308,43894);

System.Threading.ManualResetEvent
f_1588_42408_42435(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 42408, 42435);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_42511_42538()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 42511, 42538);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1588_42610_42640()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 42610, 42640);
return return_v;
}


int
f_1588_42697_42710()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 42697, 42710);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1588_43289_43298(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 43289, 43298);
return return_v;
}


Microsoft.PowerShell.Commands.QueryRunspaces
f_1588_43325_43345()
{
var return_v = new Microsoft.PowerShell.Commands.QueryRunspaces();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43325, 43345);
return return_v;
}


Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
f_1588_43166_43390(System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.Internal.ObjectStream
stream,System.Management.Automation.Host.PSHost
host,Microsoft.PowerShell.Commands.QueryRunspaces
queryRunspaces,System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
retryList)
{
var return_v = new Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation( session, stream, host, queryRunspaces, retryList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43166, 43390);
return return_v;
}


int
f_1588_43136_43391(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,Microsoft.PowerShell.Commands.ConnectPSSessionCommand.ConnectRunspaceOperation
item)
{
this_param.Add( (System.Management.Automation.Remoting.IThrottleOperation)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43136, 43391);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_43079_43094_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43079, 43094);
return return_v;
}


int
f_1588_43431_43496(System.Management.Automation.Remoting.ThrottleManager
this_param,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
operations)
{
this_param.SubmitOperations( operations);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43431, 43496);
return 0;
}


int
f_1588_43515_43558(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.EndSubmitOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43515, 43558);
return 0;
}


bool
f_1588_43579_43603(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43579, 43603);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1588_43803_43826(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1588, 43803, 43826);
return return_v;
}


int
f_1588_43803_43848(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43803, 43848);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_43744_43761_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 43744, 43761);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,42308,43894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,42308,43894);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,44204,44317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44250,44264);

f_1588_44250_44263(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44280,44306);

f_1588_44280_44305(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,44204,44317);

int
f_1588_44250_44263(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 44250, 44263);
return 0;
}


int
f_1588_44280_44305(Microsoft.PowerShell.Commands.ConnectPSSessionCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 44280, 44305);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,44204,44317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,44204,44317);
}
		}

private void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1588,44604,45067);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44665,45056) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1588,44665,45056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44712,44739);

f_1588_44712_44738(                _throttleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44759,44789);

f_1588_44759_44788(
                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44807,44837);

f_1588_44807_44836(                _operationsComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44857,44953);

_throttleManager.ThrottleComplete -= new EventHandler<EventArgs>(HandleThrottleConnectComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,44971,45003);

f_1588_44971_45002(                _retryThrottleManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,45023,45041);

f_1588_45023_45040(
                _stream);
DynAbs.Tracing.TraceSender.TraceExitCondition(1588,44665,45056);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1588,44604,45067);

int
f_1588_44712_44738(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 44712, 44738);
return 0;
}


bool
f_1588_44759_44788(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 44759, 44788);
return return_v;
}


int
f_1588_44807_44836(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 44807, 44836);
return 0;
}


int
f_1588_44971_45002(System.Management.Automation.Remoting.ThrottleManager
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 44971, 45002);
return 0;
}


int
f_1588_45023_45040(System.Management.Automation.Internal.ObjectStream
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 45023, 45040);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1588,44604,45067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,44604,45067);
}
		}

private Collection<PSSession> _allSessions ;

private ThrottleManager _throttleManager ;

private ManualResetEvent _operationsComplete ;

private QueryRunspaces _queryRunspaces ;

private ObjectStream _stream ;

private ThrottleManager _retryThrottleManager ;

private Collection<PSSession> _failedSessions ;

public ConnectPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1588,1758,46132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,2637,3068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,3170,3572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,4463,4471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,5580,5586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,5775,6383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,6903,6928);
this._allowRedirection = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,9324,9337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,10202,10217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,11104,11115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,11686,11954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,12834,13254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,13496,14244);
this.ThrottleLimit = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,45220,45262);
this._allSessions = f_1588_45235_45262();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,45385,45425);
this._throttleManager = f_1588_45404_45425();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,45577,45625);
this._operationsComplete = f_1588_45599_45625(true);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,45716,45754);
this._queryRunspaces = f_1588_45734_45754();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,45853,45881);
this._stream = f_1588_45863_45881();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,45971,46016);
this._retryThrottleManager = f_1588_45995_46016();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,46057,46102);
this._failedSessions = f_1588_46075_46102();DynAbs.Tracing.TraceSender.TraceExitConstructor(1588,1758,46132);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,1758,46132);
}


static ConnectPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1588,1758,46132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,2308,2357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,2389,2432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1588,2464,2515);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1588,1758,46132);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1588,1758,46132);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1588,1758,46132);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_45235_45262()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 45235, 45262);
return return_v;
}


System.Management.Automation.Remoting.ThrottleManager
f_1588_45404_45425()
{
var return_v = new System.Management.Automation.Remoting.ThrottleManager();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 45404, 45425);
return return_v;
}


System.Threading.ManualResetEvent
f_1588_45599_45625(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 45599, 45625);
return return_v;
}


Microsoft.PowerShell.Commands.QueryRunspaces
f_1588_45734_45754()
{
var return_v = new Microsoft.PowerShell.Commands.QueryRunspaces();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 45734, 45754);
return return_v;
}


System.Management.Automation.Internal.ObjectStream
f_1588_45863_45881()
{
var return_v = new System.Management.Automation.Internal.ObjectStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 45863, 45881);
return return_v;
}


System.Management.Automation.Remoting.ThrottleManager
f_1588_45995_46016()
{
var return_v = new System.Management.Automation.Remoting.ThrottleManager();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 45995, 46016);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1588_46075_46102()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1588, 46075, 46102);
return return_v;
}

}
}
