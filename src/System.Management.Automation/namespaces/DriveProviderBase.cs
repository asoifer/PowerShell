// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Internal;

using Dbg = System.Management.Automation;

namespace System.Management.Automation.Provider
{
public abstract class DriveCmdletProvider : CmdletProvider
{
internal PSDriveInfo NewDrive(PSDriveInfo drive, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,1690,2377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,1794,1812);

Context = context;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,1940,2327) || true) && (f_1190_1944_1960(drive)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1190, 1944, 2027)&&f_1190_1989_2005(drive)!= f_1190_2009_2027())&&(DynAbs.Tracing.TraceSender.Expression_True(1190, 1944, 2157)&&                !f_1190_2049_2157(ProviderCapabilities.Credentials, f_1190_2144_2156())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1190,1940,2327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,2191,2312);

throw f_1190_2197_2311(f_1190_2258_2310());
DynAbs.Tracing.TraceSender.TraceExitCondition(1190,1940,2327);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,2343,2366);

return f_1190_2350_2365(this, drive);
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,1690,2377);

System.Management.Automation.PSCredential
f_1190_1944_1960(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1190, 1944, 1960);
return return_v;
}


System.Management.Automation.PSCredential
f_1190_1989_2005(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1190, 1989, 2005);
return return_v;
}


System.Management.Automation.PSCredential
f_1190_2009_2027()
{
var return_v = PSCredential.Empty ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1190, 2009, 2027);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1190_2144_2156()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1190, 2144, 2156);
return return_v;
}


bool
f_1190_2049_2157(System.Management.Automation.Provider.ProviderCapabilities
capability,System.Management.Automation.ProviderInfo
provider)
{
var return_v = CmdletProviderManagementIntrinsics.CheckProviderCapabilities( capability, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 2049, 2157);
return return_v;
}


string
f_1190_2258_2310()
{
var return_v =                     SessionStateStrings.NewDriveCredentials_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1190, 2258, 2310);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1190_2197_2311(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 2197, 2311);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1190_2350_2365(System.Management.Automation.Provider.DriveCmdletProvider
this_param,System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.NewDrive( drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 2350, 2365);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,1690,2377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,1690,2377);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object NewDriveDynamicParameters(CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,2839,3014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,2936,2954);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,2968,3003);

return f_1190_2975_3002(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,2839,3014);

object
f_1190_2975_3002(System.Management.Automation.Provider.DriveCmdletProvider
this_param)
{
var return_v = this_param.NewDriveDynamicParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 2975, 3002);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,2839,3014);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,2839,3014);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSDriveInfo RemoveDrive(PSDriveInfo drive, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,3674,3850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,3781,3799);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,3813,3839);

return f_1190_3820_3838(this, drive);
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,3674,3850);

System.Management.Automation.PSDriveInfo
f_1190_3820_3838(System.Management.Automation.Provider.DriveCmdletProvider
this_param,System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.RemoveDrive( drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 3820, 3838);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,3674,3850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,3674,3850);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSDriveInfo> InitializeDefaultDrives(CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,4408,4633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,4520,4538);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,4552,4573);

f_1190_4552_4559().Drive = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,4589,4622);

return f_1190_4596_4621(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,4408,4633);

System.Management.Automation.CmdletProviderContext
f_1190_4552_4559()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1190, 4552, 4559);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1190_4596_4621(System.Management.Automation.Provider.DriveCmdletProvider
this_param)
{
var return_v = this_param.InitializeDefaultDrives();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 4596, 4621);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,4408,4633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,4408,4633);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual PSDriveInfo NewDrive(PSDriveInfo drive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,6589,6798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,6671,6787);
using(f_1190_6678_6725())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,6759,6772);

return drive;
DynAbs.Tracing.TraceSender.TraceExitUsing(1190,6671,6787);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,6589,6798);

System.IDisposable
f_1190_6678_6725()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 6678, 6725);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,6589,6798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,6589,6798);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual object NewDriveDynamicParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,7379,7582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,7456,7571);
using(f_1190_7463_7510())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,7544,7556);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1190,7456,7571);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,7379,7582);

System.IDisposable
f_1190_7463_7510()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 7463, 7510);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,7379,7582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,7379,7582);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual PSDriveInfo RemoveDrive(PSDriveInfo drive)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,8429,8641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,8514,8630);
using(f_1190_8521_8568())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,8602,8615);

return drive;
DynAbs.Tracing.TraceSender.TraceExitUsing(1190,8514,8630);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,8429,8641);

System.IDisposable
f_1190_8521_8568()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 8521, 8568);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,8429,8641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,8429,8641);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual Collection<PSDriveInfo> InitializeDefaultDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1190,10003,10246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,10095,10235);
using(f_1190_10102_10149())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1190,10183,10220);

return f_1190_10190_10219();
DynAbs.Tracing.TraceSender.TraceExitUsing(1190,10095,10235);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1190,10003,10246);

System.IDisposable
f_1190_10102_10149()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 10102, 10149);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1190_10190_10219()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1190, 10190, 10219);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1190,10003,10246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,10003,10246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DriveCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1190,876,10290);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1190,876,10290);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,876,10290);
}


static DriveCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1190,876,10290);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1190,876,10290);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1190,876,10290);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1190,876,10290);
}

    }

