// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.Get, "PSSession", DefaultParameterSetName = PSRunspaceCmdlet.NameParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096697", RemotingCapability = RemotingCapability.OwnedByCommand)]
    [OutputType(typeof(PSSession))]
    public class GetPSSessionCommand : PSRunspaceCmdlet, IDisposable
{
private const string 
ConnectionUriParameterSet = "ConnectionUri"
;

private const string 
ConnectionUriInstanceIdParameterSet = "ConnectionUriInstanceId"
;

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("Cn")]
        public override string[] ComputerName {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        public string ApplicationName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,3635,3659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,3641,3657);

return _appName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,3635,3659);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,3283,3770);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,3283,3770);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,3675,3759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,3711,3744);

_appName = f_1594_3722_3743(this, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,3675,3759);

string
f_1594_3722_3743(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,string
appName)
{
var return_v = this_param.ResolveAppName( appName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 3722, 3743);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,3283,3770);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,3283,3770);
}
		}}

private string _appName;

[Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("URI", "CU")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public Uri[] ConnectionUri {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.ContainerIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.ContainerIdInstanceIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.VMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.VMIdInstanceIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.VMNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = GetPSSessionCommand.VMNameInstanceIdParameterSet)]
        public string ConfigurationName {get; set; }

[Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public SwitchParameter AllowRedirection
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,7079,7112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,7085,7110);

return _allowRedirection;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,7079,7112);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,6831,7173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,6831,7173);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,7128,7162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,7134,7160);

_allowRedirection = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,7128,7162);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,6831,7173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,6831,7173);
}
		}}

private bool _allowRedirection ;

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.NameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMNameParameterSet)]
        [ValidateNotNullOrEmpty()]
        public override string[] Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,7965,7990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,7971,7988);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Name,1594,7978,7987);
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,7965,7990);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,7324,8043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,7324,8043);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,8006,8032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,8012,8030);

base.Name = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,8006,8032);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,7324,8043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,7324,8043);
}
		}}

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet,
                   Mandatory = true)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet,
                   Mandatory = true)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ContainerIdInstanceIdParameterSet,
                   Mandatory = true)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMIdInstanceIdParameterSet,
                   Mandatory = true)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMNameInstanceIdParameterSet,
                   Mandatory = true)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public override Guid[] InstanceId
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,9114,9145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,9120,9143);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.InstanceId,1594,9127,9142);
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,9114,9145);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,8142,9204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,8142,9204);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,9161,9193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,9167,9191);

base.InstanceId = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,9161,9193);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,8142,9204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,8142,9204);
}
		}}

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [Credential()]
        public PSCredential Credential
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,9920,9949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,9926,9947);

return _psCredential;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,9920,9949);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,9479,10173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,9479,10173);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,9965,10162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,10001,10023);

_psCredential = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,10043,10147);

f_1594_10043_10146(f_1594_10096_10106(), f_1594_10108_10129(), f_1594_10131_10145());
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,9965,10162);

System.Management.Automation.PSCredential
f_1594_10096_10106()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 10096, 10106);
return return_v;
}


string
f_1594_10108_10129()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 10108, 10129);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1594_10131_10145()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 10131, 10145);
return return_v;
}


int
f_1594_10043_10146(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 10043, 10146);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,9479,10173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,9479,10173);
}
		}}

private PSCredential _psCredential;

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public AuthenticationMechanism Authentication
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,10775,10806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,10781,10804);

return _authentication;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,10775,10806);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,10343,11032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,10343,11032);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,10822,11021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,10858,10882);

_authentication = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,10902,11006);

f_1594_10902_11005(f_1594_10955_10965(), f_1594_10967_10988(), f_1594_10990_11004());
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,10822,11021);

System.Management.Automation.PSCredential
f_1594_10955_10965()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 10955, 10965);
return return_v;
}


string
f_1594_10967_10988()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 10967, 10988);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1594_10990_11004()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 10990, 11004);
return return_v;
}


int
f_1594_10902_11005(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 10902, 11005);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,10343,11032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,10343,11032);
}
		}}

private AuthenticationMechanism _authentication;

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public string CertificateThumbprint
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,11694,11721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,11700,11719);

return _thumbprint;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,11694,11721);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,11272,11943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,11272,11943);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,11737,11932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,11773,11793);

_thumbprint = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,11813,11917);

f_1594_11813_11916(f_1594_11866_11876(), f_1594_11878_11899(), f_1594_11901_11915());
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,11737,11932);

System.Management.Automation.PSCredential
f_1594_11866_11876()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 11866, 11876);
return return_v;
}


string
f_1594_11878_11899()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 11878, 11899);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1594_11901_11915()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 11901, 11915);
return return_v;
}


int
f_1594_11813_11916(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 11813, 11916);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,11272,11943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,11272,11943);
}
		}}

private string _thumbprint;

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [ValidateRange((int)1, (int)UInt16.MaxValue)]
        public int Port {get; set; }

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SSL")]
        public SwitchParameter UseSSL {get; set; }

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public int ThrottleLimit {get; set; }

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ContainerIdInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMIdInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.VMNameInstanceIdParameterSet)]
        public SessionFilterState State {get; set; }

[Parameter(ParameterSetName = GetPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriParameterSet)]
        [Parameter(ParameterSetName = GetPSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public PSSessionOption SessionOption {get; set; }

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,15880,16107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,15946,15969);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1594,15946,15968);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,15985,16096) || true) && (f_1594_15989_16006()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,15985,16096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,16048,16081);

ConfigurationName = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,15985,16096);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,15880,16107);

string
f_1594_15989_16006()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 15989, 16006);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,15880,16107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,15880,16107);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,16346,17362);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,16410,17351) || true) && ((f_1594_16415_16431()== GetPSSessionCommand.NameParameterSet) &&(DynAbs.Tracing.TraceSender.Expression_True(1594, 16414, 16514)&&((f_1594_16478_16482()== null) ||(DynAbs.Tracing.TraceSender.Expression_False(1594, 16477, 16513)||(f_1594_16496_16507(f_1594_16496_16500())== 0)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,16410,17351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,16646,16674);

f_1594_16646_16673(this, true, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,16410,17351);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,16410,17351);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,16708,17351) || true) && (f_1594_16712_16728()== GetPSSessionCommand.ComputerNameParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1594, 16712, 16872)||f_1594_16802_16818()== GetPSSessionCommand.ComputerInstanceIdParameterSet )||(DynAbs.Tracing.TraceSender.Expression_False(1594, 16712, 16963)||f_1594_16898_16914()== GetPSSessionCommand.ConnectionUriParameterSet )||(DynAbs.Tracing.TraceSender.Expression_False(1594, 16712, 17064)||f_1594_16989_17005()== GetPSSessionCommand.ConnectionUriInstanceIdParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,16708,17351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,17176,17201);

f_1594_17176_17200(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,16708,17351);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,16708,17351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,17267,17336);

f_1594_17267_17335(this, true, true, f_1594_17300_17310(this), f_1594_17312_17334(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,16708,17351);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,16410,17351);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,16346,17362);

string
f_1594_16415_16431()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16415, 16431);
return return_v;
}


string[]
f_1594_16478_16482()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16478, 16482);
return return_v;
}


string[]
f_1594_16496_16500()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16496, 16500);
return return_v;
}


int
f_1594_16496_16507(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16496, 16507);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1594_16646_16673(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetAllRunspaces( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 16646, 16673);
return return_v;
}


string
f_1594_16712_16728()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16712, 16728);
return return_v;
}


string
f_1594_16802_16818()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16802, 16818);
return return_v;
}


string
f_1594_16898_16914()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16898, 16914);
return return_v;
}


string
f_1594_16989_17005()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 16989, 17005);
return return_v;
}


int
f_1594_17176_17200(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
this_param.QueryForRemoteSessions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 17176, 17200);
return 0;
}


Microsoft.PowerShell.Commands.SessionFilterState
f_1594_17300_17310(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 17300, 17310);
return return_v;
}


string
f_1594_17312_17334(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 17312, 17334);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1594_17267_17335(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,bool
writeobject,bool
writeErrorOnNoMatch,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName)
{
var return_v = this_param.GetMatchingRunspaces( writeobject, writeErrorOnNoMatch, filterState, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 17267, 17335);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,16346,17362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,16346,17362);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,17459,17563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,17523,17552);

f_1594_17523_17551(f_1594_17523_17543(_stream));
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,17459,17563);

System.Management.Automation.Runspaces.PipelineWriter
f_1594_17523_17543(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 17523, 17543);
return return_v;
}


int
f_1594_17523_17551(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 17523, 17551);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,17459,17563);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,17459,17563);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,17677,17789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,17742,17778);

f_1594_17742_17777(            _queryRunspaces);
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,17677,17789);

int
f_1594_17742_17777(Microsoft.PowerShell.Commands.QueryRunspaces
this_param)
{
this_param.StopAllOperations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 17742, 17777);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,17677,17789);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,17677,17789);
}
		}

private void QueryForRemoteSessions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,18089,19452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,18262,18335);

Collection<WSManConnectionInfo> 
connectionInfos = f_1594_18312_18334(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,18387,18758);

Collection<PSSession> 
results = f_1594_18419_18757(_queryRunspaces, connectionInfos, f_1594_18476_18485(this), _stream, f_1594_18585_18608(this), f_1594_18610_18623(), f_1594_18714_18719(), f_1594_18721_18731(), f_1594_18733_18737(), f_1594_18739_18756())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,18833,18907);

Collection<object> 
streamObjects = f_1594_18868_18906(f_1594_18868_18888(_stream))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,18921,19169);
foreach(object streamObject in f_1594_18953_18966_I(streamObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,18921,19169);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19000,19086) || true) && (f_1594_19004_19019(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,19000,19086);
DynAbs.Tracing.TraceSender.TraceBreak(1594,19061,19067);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,19000,19086);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19106,19154);

f_1594_19106_19153(this, streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,18921,19169);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1594,1,249);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1594,1,249);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19228,19441);
foreach(PSSession session in f_1594_19258_19265_I(results) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,19228,19441);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19299,19385) || true) && (f_1594_19303_19318(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,19299,19385);
DynAbs.Tracing.TraceSender.TraceBreak(1594,19360,19366);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,19299,19385);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19405,19426);

f_1594_19405_19425(this, session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,19228,19441);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1594,1,214);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1594,1,214);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1594,18089,19452);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
f_1594_18312_18334(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
var return_v = this_param.GetConnectionObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 18312, 18334);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1594_18476_18485(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18476, 18485);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1594_18585_18608(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18585, 18608);
return return_v;
}


int
f_1594_18610_18623()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18610, 18623);
return return_v;
}


Microsoft.PowerShell.Commands.SessionFilterState
f_1594_18714_18719()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18714, 18719);
return return_v;
}


System.Guid[]
f_1594_18721_18731()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18721, 18731);
return return_v;
}


string[]
f_1594_18733_18737()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18733, 18737);
return return_v;
}


string
f_1594_18739_18756()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18739, 18756);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1594_18419_18757(Microsoft.PowerShell.Commands.QueryRunspaces
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 18419, 18757);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1594_18868_18888(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 18868, 18888);
return return_v;
}


System.Collections.ObjectModel.Collection<object>
f_1594_18868_18906(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.NonBlockingRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 18868, 18906);
return return_v;
}


bool
f_1594_19004_19019(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
var return_v = this_param.IsStopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 19004, 19019);
return return_v;
}


int
f_1594_19106_19153(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,object
action)
{
this_param.WriteStreamObject( (System.Action<System.Management.Automation.Cmdlet>)action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 19106, 19153);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_1594_18953_18966_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 18953, 18966);
return return_v;
}


bool
f_1594_19303_19318(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param)
{
var return_v = this_param.IsStopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 19303, 19318);
return return_v;
}


int
f_1594_19405_19425(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 19405, 19425);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1594_19258_19265_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 19258, 19265);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,18089,19452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,18089,19452);
}
		}

private Collection<WSManConnectionInfo> GetConnectionObjects()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,19464,22106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19551,19639);

Collection<WSManConnectionInfo> 
connectionInfos = f_1594_19601_19638()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19655,22056) || true) && (f_1594_19659_19675()== GetPSSessionCommand.ComputerNameParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1594, 19659, 19814)||f_1594_19744_19760()== GetPSSessionCommand.ComputerInstanceIdParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,19655,22056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19848,19948);

string 
scheme = (DynAbs.Tracing.TraceSender.Conditional_F1(1594, 19864, 19880)||((f_1594_19864_19870().IsPresent &&DynAbs.Tracing.TraceSender.Conditional_F2(1594, 19883, 19914))||DynAbs.Tracing.TraceSender.Conditional_F3(1594, 19917, 19947)))?WSManConnectionInfo.HttpsScheme :WSManConnectionInfo.HttpScheme
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,19968,20978);
foreach(string computerName in f_1594_20000_20012_I(f_1594_20000_20012()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,19968,20978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20054,20117);

WSManConnectionInfo 
connectionInfo = f_1594_20091_20116()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20139,20170);

connectionInfo.Scheme = scheme;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20192,20256);

connectionInfo.ComputerName = f_1594_20222_20255(this, computerName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20278,20319);

connectionInfo.AppName = f_1594_20303_20318();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20341,20385);

connectionInfo.ShellUri = f_1594_20367_20384();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20407,20434);

connectionInfo.Port = f_1594_20429_20433();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20456,20760) || true) && (f_1594_20460_20481()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,20456,20760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20539,20600);

connectionInfo.CertificateThumbprint = f_1594_20578_20599();
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,20456,20760);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,20456,20760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20698,20737);

connectionInfo.Credential = f_1594_20726_20736();
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,20456,20760);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20784,20840);

connectionInfo.AuthenticationMechanism = f_1594_20825_20839();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20862,20899);

f_1594_20862_20898(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,20923,20959);

f_1594_20923_20958(
                    connectionInfos, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,19968,20978);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1594,1,1011);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1594,1,1011);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1594,19655,22056);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,19655,22056);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21012,22056) || true) && (f_1594_21016_21032()== GetPSSessionCommand.ConnectionUriParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1594, 21016, 21182)||f_1594_21107_21123()== GetPSSessionCommand.ConnectionUriInstanceIdParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,21012,22056);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21216,22041);
foreach(var connectionUri in f_1594_21246_21259_I(f_1594_21246_21259()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,21216,22041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21301,21364);

WSManConnectionInfo 
connectionInfo = f_1594_21338_21363()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21386,21431);

connectionInfo.ConnectionUri = connectionUri;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21453,21497);

connectionInfo.ShellUri = f_1594_21479_21496();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21519,21823) || true) && (f_1594_21523_21544()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,21519,21823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21602,21663);

connectionInfo.CertificateThumbprint = f_1594_21641_21662();
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,21519,21823);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,21519,21823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21761,21800);

connectionInfo.Credential = f_1594_21789_21799();
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,21519,21823);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21847,21903);

connectionInfo.AuthenticationMechanism = f_1594_21888_21902();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21925,21962);

f_1594_21925_21961(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,21986,22022);

f_1594_21986_22021(
                    connectionInfos, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,21216,22041);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1594,1,826);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1594,1,826);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1594,21012,22056);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,19655,22056);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,22072,22095);

return connectionInfos;
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,19464,22106);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
f_1594_19601_19638()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 19601, 19638);
return return_v;
}


string
f_1594_19659_19675()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 19659, 19675);
return return_v;
}


string
f_1594_19744_19760()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 19744, 19760);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1594_19864_19870()
{
var return_v = UseSSL;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 19864, 19870);
return return_v;
}


string[]
f_1594_20000_20012()
{
var return_v = ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20000, 20012);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1594_20091_20116()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 20091, 20116);
return return_v;
}


string
f_1594_20222_20255(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 20222, 20255);
return return_v;
}


string
f_1594_20303_20318()
{
var return_v = ApplicationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20303, 20318);
return return_v;
}


string
f_1594_20367_20384()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20367, 20384);
return return_v;
}


int
f_1594_20429_20433()
{
var return_v = Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20429, 20433);
return return_v;
}


string
f_1594_20460_20481()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20460, 20481);
return return_v;
}


string
f_1594_20578_20599()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20578, 20599);
return return_v;
}


System.Management.Automation.PSCredential
f_1594_20726_20736()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20726, 20736);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1594_20825_20839()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 20825, 20839);
return return_v;
}


int
f_1594_20862_20898(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 20862, 20898);
return 0;
}


int
f_1594_20923_20958(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 20923, 20958);
return 0;
}


string[]
f_1594_20000_20012_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 20000, 20012);
return return_v;
}


string
f_1594_21016_21032()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21016, 21032);
return return_v;
}


string
f_1594_21107_21123()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21107, 21123);
return return_v;
}


System.Uri[]
f_1594_21246_21259()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21246, 21259);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1594_21338_21363()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 21338, 21363);
return return_v;
}


string
f_1594_21479_21496()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21479, 21496);
return return_v;
}


string
f_1594_21523_21544()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21523, 21544);
return return_v;
}


string
f_1594_21641_21662()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21641, 21662);
return return_v;
}


System.Management.Automation.PSCredential
f_1594_21789_21799()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21789, 21799);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1594_21888_21902()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 21888, 21902);
return return_v;
}


int
f_1594_21925_21961(Microsoft.PowerShell.Commands.GetPSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 21925, 21961);
return 0;
}


int
f_1594_21986_22021(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 21986, 22021);
return 0;
}


System.Uri[]
f_1594_21246_21259_I(System.Uri[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 21246, 21259);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,19464,22106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,19464,22106);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void UpdateConnectionInfo(WSManConnectionInfo connectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,22298,23173);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,22392,22736) || true) && (f_1594_22396_22412()!= GetPSSessionCommand.ConnectionUriParameterSet &&(DynAbs.Tracing.TraceSender.Expression_True(1594, 22396, 22557)&&f_1594_22482_22498()!= GetPSSessionCommand.ConnectionUriInstanceIdParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,22392,22736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,22668,22721);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,22392,22736);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,22752,22943) || true) && (!_allowRedirection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,22752,22943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,22875,22928);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,22752,22943);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,23040,23162) || true) && (f_1594_23044_23057()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1594,23040,23162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,23099,23147);

f_1594_23099_23146(                connectionInfo, f_1594_23132_23145());
DynAbs.Tracing.TraceSender.TraceExitCondition(1594,23040,23162);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,22298,23173);

string
f_1594_22396_22412()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 22396, 22412);
return return_v;
}


string
f_1594_22482_22498()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 22482, 22498);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1594_23044_23057()
{
var return_v = SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 23044, 23057);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1594_23132_23145()
{
var return_v = SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1594, 23132, 23145);
return return_v;
}


int
f_1594_23099_23146(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param,System.Management.Automation.Remoting.PSSessionOption
options)
{
this_param.SetSessionOptions( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 23099, 23146);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,22298,23173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,22298,23173);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1594,23329,23444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,23375,23393);

f_1594_23375_23392(            _stream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,23407,23433);

f_1594_23407_23432(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1594,23329,23444);

int
f_1594_23375_23392(System.Management.Automation.Internal.ObjectStream
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 23375, 23392);
return 0;
}


int
f_1594_23407_23432(Microsoft.PowerShell.Commands.GetPSSessionCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 23407, 23432);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1594,23329,23444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,23329,23444);
}
		}

private QueryRunspaces _queryRunspaces ;

private ObjectStream _stream ;

public GetPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1594,1721,23786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,2362,2912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,3797,3805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,3994,4600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,5077,6680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,7198,7223);
this._allowRedirection = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,10206,10219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,11076,11091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,11970,11981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,12552,12814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,13777,14182);
this.ThrottleLimit = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,14313,15236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,15325,15737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,23591,23629);
this._queryRunspaces = f_1594_23609_23629();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,23728,23756);
this._stream = f_1594_23738_23756();DynAbs.Tracing.TraceSender.TraceExitConstructor(1594,1721,23786);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,1721,23786);
}


static GetPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1594,1721,23786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,2121,2164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1594,2196,2259);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1594,1721,23786);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1594,1721,23786);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1594,1721,23786);

Microsoft.PowerShell.Commands.QueryRunspaces
f_1594_23609_23629()
{
var return_v = new Microsoft.PowerShell.Commands.QueryRunspaces();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 23609, 23629);
return return_v;
}


System.Management.Automation.Internal.ObjectStream
f_1594_23738_23756()
{
var return_v = new System.Management.Automation.Internal.ObjectStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1594, 23738, 23756);
return return_v;
}

}
}
