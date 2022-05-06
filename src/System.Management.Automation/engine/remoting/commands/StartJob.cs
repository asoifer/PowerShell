// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Security;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsLifecycle.Start, "Job", DefaultParameterSetName = StartJobCommand.ComputerNameParameterSet, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096796")]
    [OutputType(typeof(PSRemotingJob))]
    public class StartJobCommand : PSExecutionCmdlet, IDisposable
{
private static readonly string s_startJobType ;

private const string 
DefinitionNameParameterSet = "DefinitionName"
;

[Parameter(Position = 0, Mandatory = true,
                   ParameterSetName = StartJobCommand.DefinitionNameParameterSet)]
        [ValidateTrustedData]
        [ValidateNotNullOrEmpty]
        public string DefinitionName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,1474,1505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,1480,1503);

return _definitionName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,1474,1505);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,1220,1564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,1220,1564);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,1521,1553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,1527,1551);

_definitionName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,1521,1553);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,1220,1564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,1220,1564);
}
		}}

private string _definitionName;

[Parameter(Position = 1,
                   ParameterSetName = StartJobCommand.DefinitionNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string DefinitionPath
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,1909,1940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,1915,1938);

return _definitionPath;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,1909,1940);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,1704,1999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,1704,1999);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,1956,1988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,1962,1986);

_definitionPath = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,1956,1988);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,1704,1999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,1704,1999);
}
		}}

private string _definitionPath;

[Parameter(Position = 2,
            ParameterSetName = StartJobCommand.DefinitionNameParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public string Type
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,2445,2476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,2451,2474);

return _definitionType;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,2445,2476);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,2162,2535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,2162,2535);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,2492,2524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,2498,2522);

_definitionType = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,2492,2524);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,2162,2535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,2162,2535);
}
		}}

private string _definitionType;

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        public virtual string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,3185,3249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,3221,3234);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,3185,3249);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,2685,3434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,2685,3434);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,3265,3423);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,3301,3408) || true) && (!f_1611_3306_3333(value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,3301,3408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,3375,3389);

_name = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,3301,3408);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,3265,3423);

bool
f_1611_3306_3333(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 3306, 3333);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,2685,3434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,2685,3434);
}
		}}

private string _name;

[Parameter(Position = 0,
                   Mandatory = true,
                   ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [ValidateTrustedData]
        [Alias("Command")]
        public override ScriptBlock ScriptBlock
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,4174,4249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,4210,4234);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ScriptBlock,1611,4217,4233);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,4174,4249);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,3897,4352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,3897,4352);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,4265,4341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,4301,4326);

base.ScriptBlock = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,4265,4341);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,3897,4352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,3897,4352);
}
		}}

public override PSSession[] Session
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,4703,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,4739,4751);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,4703,4766);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,4643,4777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,4643,4777);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string[] ComputerName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,4950,5013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,4986,4998);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,4950,5013);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,4888,5024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,4888,5024);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override SwitchParameter EnableNetworkAccess
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,5230,5251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,5236,5249);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,5230,5251);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,5154,5262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,5154,5262);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override SwitchParameter SSHTransport
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,5426,5447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,5432,5445);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,5426,5447);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,5357,5458);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,5357,5458);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Hashtable[] SSHConnection
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,5620,5640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,5626,5638);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,5620,5640);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,5554,5651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,5554,5651);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string UserName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,5798,5818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,5804,5816);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,5798,5818);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,5742,5829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,5742,5829);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string KeyFilePath
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,5982,6002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,5988,6000);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,5982,6002);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,5923,6013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,5923,6013);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string[] HostName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,6162,6182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,6168,6180);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,6162,6182);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,6104,6193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,6104,6193);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string Subsystem
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,6342,6362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,6348,6360);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,6342,6362);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,6285,6373);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,6285,6373);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[Parameter(ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        [Credential()]
        public override PSCredential Credential
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,6856,6930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,6892,6915);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Credential,1611,6899,6914);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,6856,6930);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,6499,7032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,6499,7032);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,6946,7021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,6982,7006);

base.Credential = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,6946,7021);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,6499,7032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,6499,7032);
}
		}}

public override int Port
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,7192,7252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,7228,7237);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,7192,7252);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,7143,7263);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,7143,7263);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override SwitchParameter UseSSL
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,7437,7501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,7473,7486);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,7437,7501);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,7374,7512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,7374,7512);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string ConfigurationName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,7688,7769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,7724,7754);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ConfigurationName,1611,7731,7753);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,7688,7769);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,7623,7878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,7623,7878);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,7785,7867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,7821,7852);

base.ConfigurationName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,7785,7867);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,7623,7878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,7623,7878);
}
		}}

public override Int32 ThrottleLimit
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,8049,8109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,8085,8094);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,8049,8109);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,7989,8120);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,7989,8120);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string ApplicationName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,8294,8357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,8330,8342);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,8294,8357);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,8231,8368);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,8231,8368);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Uri[] ConnectionUri
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,8539,8602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,8575,8587);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,8539,8602);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,8479,8613);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,8479,8613);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[Parameter(
            Position = 0,
            Mandatory = true,
            ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [ValidateTrustedData]
        public override string FilePath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,8967,9039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,9003,9024);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.FilePath,1611,9010,9023);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,8967,9039);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,8718,9139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,8718,9139);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,9055,9128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,9091,9113);

base.FilePath = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,9055,9128);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,8718,9139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,8718,9139);
}
		}}

[Parameter(
            Mandatory = true,
            ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        [ValidateTrustedData]
        [Alias("PSPath", "LP")]
        public string LiteralPath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,9508,9580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,9544,9565);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.FilePath,1611,9551,9564);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,9508,9580);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,9252,9724);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,9252,9724);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,9596,9713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,9632,9654);

base.FilePath = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,9672,9698);

base.IsLiteralPath = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,9596,9713);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,9252,9724);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,9252,9724);
}
		}}

[Parameter(ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        public override AuthenticationMechanism Authentication
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,10195,10273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,10231,10258);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Authentication,1611,10238,10257);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,10195,10273);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,9847,10379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,9847,10379);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,10289,10368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,10325,10353);

base.Authentication = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,10289,10368);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,9847,10379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,9847,10379);
}
		}}

public override string CertificateThumbprint
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,10559,10644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,10595,10629);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.CertificateThumbprint,1611,10602,10628);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,10559,10644);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,10490,10757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,10490,10757);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,10660,10746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,10696,10731);

base.CertificateThumbprint = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,10660,10746);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,10490,10757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,10490,10757);
}
		}}

public override SwitchParameter AllowRedirection
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,10941,11005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,10977,10990);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,10941,11005);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,10868,11016);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,10868,11016);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Guid[] VMId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,11179,11242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,11215,11227);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,11179,11242);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,11127,11253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,11127,11253);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string[] VMName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,11420,11483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,11456,11468);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,11420,11483);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,11364,11494);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,11364,11494);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string[] ContainerId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,11666,11729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,11702,11714);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,11666,11729);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,11605,11740);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,11605,11740);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override SwitchParameter RunAsAdministrator
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,11926,11990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,11962,11975);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,11926,11990);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,11851,12001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,11851,12001);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PSSessionOption SessionOption
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,12457,12534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,12493,12519);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.SessionOption,1611,12500,12518);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,12457,12534);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,12387,12639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,12387,12639);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,12550,12628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,12586,12613);

base.SessionOption = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,12550,12628);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,12387,12639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,12387,12639);
}
		}}

[Parameter(Position = 1,
                   ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(Position = 1,
                   ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(Position = 1,
                   ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        [ValidateTrustedData]
        public virtual ScriptBlock InitializationScript
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,13239,13266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,13245,13264);

return _initScript;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,13239,13266);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,12765,13321);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,12765,13321);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,13282,13310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,13288,13308);

_initScript = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,13282,13310);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,12765,13321);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,12765,13321);
}
		}}

private ScriptBlock _initScript;

[Parameter]
        [ValidateNotNullOrEmpty]
        public string WorkingDirectory {get; set; }

[Parameter(ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        public virtual SwitchParameter RunAs32 {get; set; }

[Parameter(ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public virtual Version PSVersion
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,14640,14666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,14646,14664);

return _psVersion;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,14640,14666);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,14280,14982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,14280,14982);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,14682,14971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,14718,14760);

f_1611_14718_14759(value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,14854,14917);

f_1611_14854_14916(value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,14937,14956);

_psVersion = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,14682,14971);

int
f_1611_14718_14759(System.Version
version)
{
RemotingCommandUtil.CheckPSVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 14718, 14759);
return 0;
}


int
f_1611_14854_14916(System.Version
version)
{
RemotingCommandUtil.CheckIfPowerShellVersionIsInstalled( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 14854, 14916);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,14280,14982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,14280,14982);
}
		}}

private Version _psVersion;

[Parameter(ValueFromPipeline = true,
                   ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(ValueFromPipeline = true,
                   ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipeline = true,
                   ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        [ValidateTrustedData]
        public override PSObject InputObject
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,15605,15637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,15611,15635);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.InputObject,1611,15618,15634);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,15605,15637);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,15106,15697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,15106,15697);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,15653,15686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,15659,15684);

base.InputObject = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,15653,15686);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,15106,15697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,15106,15697);
}
		}}

[Parameter(ParameterSetName = StartJobCommand.FilePathComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = StartJobCommand.LiteralFilePathComputerNameParameterSet)]
        [ValidateTrustedData]
        [Alias("Args")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public override object[] ArgumentList
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,16264,16297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,16270,16295);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ArgumentList,1611,16277,16294);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,16264,16297);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,15783,16358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,15783,16358);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,16313,16347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,16319,16345);

base.ArgumentList = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,16313,16347);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,15783,16358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,15783,16358);
}
		}}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,16685,19496);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,16751,17601) || true) && (!f_1611_16756_16806(PowerShellProcessInstance.PwshExePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,16751,17601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,17091,17258);

string 
message = f_1611_17108_17257(f_1611_17148_17196(), PowerShellProcessInstance.PwshExePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,17278,17531);

var 
errorRecord = f_1611_17296_17530(f_1611_17334_17370(message), "IPCPwshExecutableNotFound", ErrorCategory.NotInstalled, PowerShellProcessInstance.PwshExePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,17551,17586);

f_1611_17551_17585(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,16751,17601);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,17617,18177) || true) && (f_1611_17621_17628().IsPresent &&(DynAbs.Tracing.TraceSender.Expression_True(1611, 17621, 17668)&&f_1611_17642_17668()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,17617,18177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,17797,17857);

string 
message = f_1611_17814_17856()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,17875,18107);

var 
errorRecord = f_1611_17893_18106(f_1611_17931_17967(message), "RunAs32NotSupported", ErrorCategory.InvalidOperation, targetObject: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,18127,18162);

f_1611_18127_18161(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,17617,18177);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,18193,18762) || true) && (f_1611_18197_18213()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1611, 18197, 18260)&&!f_1611_18226_18260(f_1611_18243_18259())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,18193,18762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,18298,18408);

string 
message = f_1611_18315_18407(f_1611_18333_18388(), f_1611_18390_18406())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,18430,18688);

var 
errorRecord = f_1611_18448_18687(f_1611_18490_18529(message), "DirectoryNotFoundException", ErrorCategory.InvalidOperation, targetObject: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,18712,18747);

f_1611_18712_18746(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,18193,18762);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,18778,19071) || true) && (f_1611_18782_18798()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,18778,19071);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,18884,18946);

WorkingDirectory = f_1611_18903_18945(f_1611_18903_18940(f_1611_18903_18924(f_1611_18903_18915())));
                }
                catch (PSInvalidOperationException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1611,18983,19056);
DynAbs.Tracing.TraceSender.TraceExitCatch(1611,18983,19056);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,18778,19071);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,19087,19175);

f_1611_19087_19174(f_1611_19141_19153(this), f_1611_19155_19173(this));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,19191,19297) || true) && (f_1611_19195_19211()== DefinitionNameParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,19191,19297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,19275,19282);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,19191,19297);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,19424,19446);

SkipWinRMCheck = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,19462,19485);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1611,19462,19484);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,16685,19496);

bool
f_1611_16756_16806(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 16756, 16806);
return return_v;
}


string
f_1611_17148_17196()
{
var return_v =                     RemotingErrorIdStrings.IPCPwshExecutableNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 17148, 17196);
return return_v;
}


string
f_1611_17108_17257(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 17108, 17257);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1611_17334_17370(string
message)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 17334, 17370);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_17296_17530(System.Management.Automation.PSNotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 17296, 17530);
return return_v;
}


int
f_1611_17551_17585(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 17551, 17585);
return 0;
}


System.Management.Automation.SwitchParameter
f_1611_17621_17628()
{
var return_v = RunAs32;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 17621, 17628);
return return_v;
}


bool
f_1611_17642_17668()
{
var return_v = Environment.Is64BitProcess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 17642, 17668);
return return_v;
}


string
f_1611_17814_17856()
{
var return_v = RemotingErrorIdStrings.RunAs32NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 17814, 17856);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1611_17931_17967(string
message)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 17931, 17967);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_17893_18106(System.Management.Automation.PSNotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject: targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 17893, 18106);
return return_v;
}


int
f_1611_18127_18161(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 18127, 18161);
return 0;
}


string
f_1611_18197_18213()
{
var return_v = WorkingDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18197, 18213);
return return_v;
}


string
f_1611_18243_18259()
{
var return_v = WorkingDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18243, 18259);
return return_v;
}


bool
f_1611_18226_18260(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 18226, 18260);
return return_v;
}


string
f_1611_18333_18388()
{
var return_v = RemotingErrorIdStrings.StartJobWorkingDirectoryNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18333, 18388);
return return_v;
}


string
f_1611_18390_18406()
{
var return_v = WorkingDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18390, 18406);
return return_v;
}


string
f_1611_18315_18407(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 18315, 18407);
return return_v;
}


System.IO.DirectoryNotFoundException
f_1611_18490_18529(string
message)
{
var return_v = new System.IO.DirectoryNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 18490, 18529);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_18448_18687(System.IO.DirectoryNotFoundException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject: targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 18448, 18687);
return return_v;
}


int
f_1611_18712_18746(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 18712, 18746);
return 0;
}


string
f_1611_18782_18798()
{
var return_v = WorkingDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18782, 18798);
return return_v;
}


System.Management.Automation.SessionState
f_1611_18903_18915()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18903, 18915);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1611_18903_18924(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18903, 18924);
return return_v;
}


System.Management.Automation.PathInfo
f_1611_18903_18940(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18903, 18940);
return return_v;
}


string
f_1611_18903_18945(System.Management.Automation.PathInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 18903, 18945);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1611_19141_19153(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 19141, 19153);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1611_19155_19173(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.CommandOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 19155, 19173);
return return_v;
}


int
f_1611_19087_19174(System.Management.Automation.ExecutionContext
context,System.Management.Automation.CommandOrigin
commandOrigin)
{
CommandDiscovery.AutoloadModulesWithJobSourceAdapters( context, commandOrigin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 19087, 19174);
return 0;
}


string
f_1611_19195_19211()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 19195, 19211);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,16685,19496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,16685,19496);
}
		}

protected override void CreateHelpersForSpecifiedComputerNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,19670,21533);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,19979,20626) || true) && ((f_1611_19984_20004(f_1611_19984_19991())== PSLanguageMode.ConstrainedLanguage) &&(DynAbs.Tracing.TraceSender.Expression_True(1611, 19983, 20137)&&                (f_1611_20065_20103()!= SystemEnforcementMode.Enforce) )&&(DynAbs.Tracing.TraceSender.Expression_True(1611, 19983, 20215)&&                ((f_1611_20160_20171()!= null) ||(DynAbs.Tracing.TraceSender.Expression_False(1611, 20159, 20214)||(f_1611_20185_20205()!= null)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,19979,20626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,20249,20611);

f_1611_20249_20610(this, f_1611_20293_20609(f_1611_20335_20425(f_1611_20363_20424()), "CannotStartJobInconsistentLanguageMode", ErrorCategory.PermissionDenied, f_1611_20588_20608(f_1611_20588_20595())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,19979,20626);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,20642,20730);

NewProcessConnectionInfo 
connectionInfo = f_1611_20684_20729(f_1611_20713_20728(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,20744,20794);

connectionInfo.InitializationScript = _initScript;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,20808,20869);

connectionInfo.AuthenticationMechanism = f_1611_20849_20868(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,20883,20925);

connectionInfo.PSVersion = f_1611_20910_20924(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,20939,20995);

connectionInfo.WorkingDirectory = f_1611_20973_20994(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,21011,21187);

RemoteRunspace 
remoteRunspace = (RemoteRunspace)f_1611_21059_21186(connectionInfo, f_1611_21106_21115(this), f_1611_21142_21185())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,21203,21285);

f_1611_21203_21239(f_1611_21203_21224(remoteRunspace)).PSEventReceived += OnRunspacePSEventReceived;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,21301,21352);

Pipeline 
pipeline = f_1611_21321_21351(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,21368,21480);

IThrottleOperation 
operation =
f_1611_21416_21479(remoteRunspace, pipeline)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,21496,21522);

f_1611_21496_21521(f_1611_21496_21506(), operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,19670,21533);

System.Management.Automation.ExecutionContext
f_1611_19984_19991()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 19984, 19991);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1611_19984_20004(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.LanguageMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 19984, 20004);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1611_20065_20103()
{
var return_v = SystemPolicy.GetSystemLockdownPolicy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 20065, 20103);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1611_20160_20171()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20160, 20171);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1611_20185_20205()
{
var return_v = InitializationScript;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20185, 20205);
return return_v;
}


string
f_1611_20363_20424()
{
var return_v = RemotingErrorIdStrings.CannotStartJobInconsistentLanguageMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20363, 20424);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1611_20335_20425(string
message)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 20335, 20425);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1611_20588_20595()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20588, 20595);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1611_20588_20608(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.LanguageMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20588, 20608);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_20293_20609(System.Management.Automation.PSNotSupportedException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.PSLanguageMode
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 20293, 20609);
return return_v;
}


int
f_1611_20249_20610(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 20249, 20610);
return 0;
}


System.Management.Automation.PSCredential
f_1611_20713_20728(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20713, 20728);
return return_v;
}


System.Management.Automation.Runspaces.NewProcessConnectionInfo
f_1611_20684_20729(System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Runspaces.NewProcessConnectionInfo( credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 20684, 20729);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1611_20849_20868(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20849, 20868);
return return_v;
}


System.Version
f_1611_20910_20924(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20910, 20924);
return return_v;
}


string
f_1611_20973_20994(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.WorkingDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 20973, 20994);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1611_21106_21115(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 21106, 21115);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1611_21142_21185()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 21142, 21185);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1611_21059_21186(System.Management.Automation.Runspaces.NewProcessConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RunspaceFactory.CreateRunspace( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 21059, 21186);
return return_v;
}


System.Management.Automation.PSEventManager
f_1611_21203_21224(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 21203, 21224);
return return_v;
}


System.Management.Automation.PSEventArgsCollection
f_1611_21203_21239(System.Management.Automation.PSEventManager
this_param)
{
var return_v = this_param.ReceivedEvents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 21203, 21239);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1611_21321_21351(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 21321, 21351);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
f_1611_21416_21479(System.Management.Automation.RemoteRunspace
remoteRunspace,System.Management.Automation.Runspaces.Pipeline
pipeline)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName( remoteRunspace, pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 21416, 21479);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1611_21496_21506()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 21496, 21506);
return return_v;
}


int
f_1611_21496_21521(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,System.Management.Automation.Remoting.IThrottleOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 21496, 21521);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,19670,21533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,19670,21533);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,21912,26078);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,21976,25277) || true) && (f_1611_21980_21996()== DefinitionNameParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,21976,25277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,22165,22192);

string 
resolvedPath = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,22210,23904) || true) && (!f_1611_22215_22252(_definitionPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,22210,23904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,22294,22323);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,22345,22524);

System.Collections.ObjectModel.Collection<string> 
paths =
f_1611_22428_22523(f_1611_22428_22458(f_1611_22428_22453(f_1611_22428_22440(this))), _definitionPath, out provider)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,22608,23234) || true) && (!f_1611_22613_22671(provider, f_1611_22633_22670(f_1611_22633_22659(f_1611_22633_22645(this)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,22608,23234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,22721,22963);

string 
message = f_1611_22738_22962(f_1611_22756_22821(), _definitionName, _definitionPath, f_1611_22944_22961(provider))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,22989,23176);

f_1611_22989_23175(this, f_1611_23000_23174(f_1611_23016_23045(message), "StartJobFromDefinitionNamePathInvalidNotFileSystemProvider", ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,23204,23211);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,22608,23234);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,23318,23837) || true) && (f_1611_23322_23333(paths)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,23318,23837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,23388,23578);

string 
message = f_1611_23405_23577(f_1611_23423_23484(), _definitionName, _definitionPath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,23604,23779);

f_1611_23604_23778(this, f_1611_23615_23777(f_1611_23631_23660(message), "StartJobFromDefinitionNamePathInvalidNotSingle", ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,23807,23814);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,23318,23837);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,23861,23885);

resolvedPath = f_1611_23876_23884(paths, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,22210,23904);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,23924,24028);

List<Job2> 
jobs = f_1611_23942_24027(f_1611_23942_23952(), _definitionName, resolvedPath, _definitionType, this, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,24048,24629) || true) && (f_1611_24052_24062(jobs)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,24048,24629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,24109,24397);

string 
message = (DynAbs.Tracing.TraceSender.Conditional_F1(1611, 24126, 24151)||(((_definitionType != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1611, 24179, 24282))||DynAbs.Tracing.TraceSender.Conditional_F3(1611, 24310, 24396)))?f_1611_24179_24282(f_1611_24197_24247(), _definitionType, _definitionName):f_1611_24310_24396(f_1611_24328_24378(), _definitionName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,24421,24579);

f_1611_24421_24578(this, f_1611_24432_24577(f_1611_24448_24477(message), "StartJobFromDefinitionNameNotFound", ErrorCategory.ObjectNotFound, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,24603,24610);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,24048,24629);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,24649,25049) || true) && (f_1611_24653_24663(jobs)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,24649,25049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,24709,24812);

string 
message = f_1611_24726_24811(f_1611_24744_24793(), _definitionName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,24834,24999);

f_1611_24834_24998(this, f_1611_24845_24997(f_1611_24861_24890(message), "StartJobFromDefinitionNameMoreThanOneMatch", ErrorCategory.InvalidResult, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25023,25030);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,24649,25049);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25100,25119);

Job2 
job = f_1611_25111_25118(jobs, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25137,25152);

f_1611_25137_25151(                job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25218,25235);

f_1611_25218_25234(this, job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25255,25262);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,21976,25277);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25293,25695) || true) && (_firstProcessRecord)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,25293,25695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25350,25378);

_firstProcessRecord = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25398,25542);

PSRemotingJob 
job = f_1611_25418_25541(f_1611_25436_25457(), f_1611_25459_25469(), f_1611_25496_25518(f_1611_25496_25507()), f_1611_25520_25533(), _name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25562,25597);

job.PSJobTypeName = s_startJobType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25617,25645);

f_1611_25617_25644(f_1611_25617_25635(this), job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25663,25680);

f_1611_25663_25679(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,25293,25695);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25740,26067) || true) && (f_1611_25744_25755()!= f_1611_25759_25779())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,25740,26067);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25813,26052);
foreach(IThrottleOperation operation in f_1611_25854_25864_I(f_1611_25854_25864()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,25813,26052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25906,25970);

ExecutionCmdletHelper 
helper = (ExecutionCmdletHelper)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,25992,26033);

f_1611_25992_26032(f_1611_25992_26013(f_1611_25992_26007(helper)), f_1611_26020_26031());
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,25813,26052);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1611,1,240);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1611,1,240);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1611,25740,26067);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,21912,26078);

string
f_1611_21980_21996()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 21980, 21996);
return return_v;
}


bool
f_1611_22215_22252(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 22215, 22252);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1611_22428_22440(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22428, 22440);
return return_v;
}


System.Management.Automation.SessionState
f_1611_22428_22453(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22428, 22453);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1611_22428_22458(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22428, 22458);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1611_22428_22523(System.Management.Automation.PathIntrinsics
this_param,string
path,out System.Management.Automation.ProviderInfo
provider)
{
var return_v = this_param.GetResolvedProviderPathFromPSPath( path, out provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 22428, 22523);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1611_22633_22645(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22633, 22645);
return return_v;
}


System.Management.Automation.ProviderNames
f_1611_22633_22659(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22633, 22659);
return return_v;
}


string
f_1611_22633_22670(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22633, 22670);
return return_v;
}


bool
f_1611_22613_22671(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 22613, 22671);
return return_v;
}


string
f_1611_22756_22821()
{
var return_v = RemotingErrorIdStrings.StartJobDefinitionPathInvalidNotFSProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22756, 22821);
return return_v;
}


string
f_1611_22944_22961(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 22944, 22961);
return return_v;
}


string
f_1611_22738_22962(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 22738, 22962);
return return_v;
}


System.Management.Automation.RuntimeException
f_1611_23016_23045(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 23016, 23045);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_23000_23174(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 23000, 23174);
return return_v;
}


int
f_1611_22989_23175(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 22989, 23175);
return 0;
}


int
f_1611_23322_23333(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 23322, 23333);
return return_v;
}


string
f_1611_23423_23484()
{
var return_v = RemotingErrorIdStrings.StartJobDefinitionPathInvalidNotSingle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 23423, 23484);
return return_v;
}


string
f_1611_23405_23577(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 23405, 23577);
return return_v;
}


System.Management.Automation.RuntimeException
f_1611_23631_23660(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 23631, 23660);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_23615_23777(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 23615, 23777);
return return_v;
}


int
f_1611_23604_23778(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 23604, 23778);
return 0;
}


string
f_1611_23876_23884(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 23876, 23884);
return return_v;
}


System.Management.Automation.JobManager
f_1611_23942_23952()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 23942, 23952);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1611_23942_24027(System.Management.Automation.JobManager
this_param,string
definitionName,string
definitionPath,string
definitionType,Microsoft.PowerShell.Commands.StartJobCommand
cmdlet,bool
writeErrorOnException)
{
var return_v = this_param.GetJobToStart( definitionName, definitionPath, definitionType, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 23942, 24027);
return return_v;
}


int
f_1611_24052_24062(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 24052, 24062);
return return_v;
}


string
f_1611_24197_24247()
{
var return_v = RemotingErrorIdStrings.StartJobDefinitionNotFound2;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 24197, 24247);
return return_v;
}


string
f_1611_24179_24282(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24179, 24282);
return return_v;
}


string
f_1611_24328_24378()
{
var return_v = RemotingErrorIdStrings.StartJobDefinitionNotFound1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 24328, 24378);
return return_v;
}


string
f_1611_24310_24396(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24310, 24396);
return return_v;
}


System.Management.Automation.RuntimeException
f_1611_24448_24477(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24448, 24477);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_24432_24577(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24432, 24577);
return return_v;
}


int
f_1611_24421_24578(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24421, 24578);
return 0;
}


int
f_1611_24653_24663(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 24653, 24663);
return return_v;
}


string
f_1611_24744_24793()
{
var return_v = RemotingErrorIdStrings.StartJobManyDefNameMatches;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 24744, 24793);
return return_v;
}


string
f_1611_24726_24811(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24726, 24811);
return return_v;
}


System.Management.Automation.RuntimeException
f_1611_24861_24890(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24861, 24890);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1611_24845_24997(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24845, 24997);
return return_v;
}


int
f_1611_24834_24998(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 24834, 24998);
return 0;
}


System.Management.Automation.Job2
f_1611_25111_25118(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25111, 25118);
return return_v;
}


int
f_1611_25137_25151(System.Management.Automation.Job2
this_param)
{
this_param.StartJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25137, 25151);
return 0;
}


int
f_1611_25218_25234(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.Job2
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25218, 25234);
return 0;
}


string[]
f_1611_25436_25457()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25436, 25457);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1611_25459_25469()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25459, 25469);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1611_25496_25507()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25496, 25507);
return return_v;
}


string
f_1611_25496_25518(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25496, 25518);
return return_v;
}


int
f_1611_25520_25533()
{
var return_v = ThrottleLimit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25520, 25533);
return return_v;
}


System.Management.Automation.PSRemotingJob
f_1611_25418_25541(string[]
computerNames,System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
computerNameHelpers,string
remoteCommand,int
throttleLimit,string
name)
{
var return_v = new System.Management.Automation.PSRemotingJob( computerNames, computerNameHelpers, remoteCommand, throttleLimit, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25418, 25541);
return return_v;
}


System.Management.Automation.JobRepository
f_1611_25617_25635(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
var return_v = this_param.JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25617, 25635);
return return_v;
}


int
f_1611_25617_25644(System.Management.Automation.JobRepository
this_param,System.Management.Automation.PSRemotingJob
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25617, 25644);
return 0;
}


int
f_1611_25663_25679(Microsoft.PowerShell.Commands.StartJobCommand
this_param,System.Management.Automation.PSRemotingJob
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25663, 25679);
return 0;
}


System.Management.Automation.PSObject
f_1611_25744_25755()
{
var return_v = InputObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25744, 25755);
return return_v;
}


System.Management.Automation.PSObject
f_1611_25759_25779()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25759, 25779);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1611_25854_25864()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25854, 25864);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1611_25992_26007(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25992, 26007);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1611_25992_26013(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Input;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 25992, 26013);
return return_v;
}


System.Management.Automation.PSObject
f_1611_26020_26031()
{
var return_v = InputObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1611, 26020, 26031);
return return_v;
}


int
f_1611_25992_26032(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Management.Automation.PSObject
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25992, 26032);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1611_25854_25864_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 25854, 25864);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,21912,26078);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,21912,26078);
}
		}

private bool _firstProcessRecord ;

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,26319,26477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,26443,26466);

f_1611_26443_26465(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,26319,26477);

int
f_1611_26443_26465(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
this_param.CloseAllInputStreams();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 26443, 26465);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,26319,26477);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,26319,26477);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,26642,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,26688,26702);

f_1611_26688_26701(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,26716,26742);

f_1611_26716_26741(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,26642,26753);

int
f_1611_26688_26701(Microsoft.PowerShell.Commands.StartJobCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 26688, 26701);
return 0;
}


int
f_1611_26716_26741(Microsoft.PowerShell.Commands.StartJobCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 26716, 26741);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,26642,26753);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,26642,26753);
}
		}

private void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1611,26968,27125);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,27029,27114) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1611,27029,27114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,27076,27099);

f_1611_27076_27098(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1611,27029,27114);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1611,26968,27125);

int
f_1611_27076_27098(Microsoft.PowerShell.Commands.StartJobCommand
this_param)
{
this_param.CloseAllInputStreams();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1611, 27076, 27098);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1611,26968,27125);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,26968,27125);
}
		}

public StartJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1611,607,27176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,1591,1606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,2026,2041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,2562,2577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,3461,3466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,13353,13364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,13514,13613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,15010,15020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,26103,26129);
this._firstProcessRecord = true;DynAbs.Tracing.TraceSender.TraceExitConstructor(1611,607,27176);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,607,27176);
}


static StartJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1611,607,27176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,964,996);
s_startJobType = "BackgroundJob";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1611,1082,1127);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1611,607,27176);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1611,607,27176);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1611,607,27176);
}
}
