// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
public sealed class PathInfo
{
public PSDriveInfo Drive
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1205,467,732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,503,529);

PSDriveInfo 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,549,683) || true) && (_drive != null &&(DynAbs.Tracing.TraceSender.Expression_True(1205, 553, 606)&&f_1205_592_606_M(!_drive.Hidden)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1205,549,683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,648,664);

result = _drive;
DynAbs.Tracing.TraceSender.TraceExitCondition(1205,549,683);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,703,717);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1205,467,732);

bool
f_1205_592_606_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1205, 592, 606);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1205,418,743);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,418,743);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ProviderInfo Provider
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1205,910,978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,946,963);

return _provider;
DynAbs.Tracing.TraceSender.TraceExitMethod(1205,910,978);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1205,857,989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,857,989);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal PSDriveInfo GetDrive()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1205,1218,1299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,1274,1288);

return _drive;
DynAbs.Tracing.TraceSender.TraceExitMethod(1205,1218,1299);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1205,1218,1299);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,1218,1299);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public string ProviderPath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1205,1850,2239);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,1886,2183) || true) && (_providerPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1205,1886,2183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2006,2092);

LocationGlobber 
pathGlobber = f_1205_2036_2091(f_1205_2036_2075(f_1205_2036_2058(_sessionState)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2114,2164);

_providerPath = f_1205_2130_2163(pathGlobber, f_1205_2158_2162());
DynAbs.Tracing.TraceSender.TraceExitCondition(1205,1886,2183);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2203,2224);

return _providerPath;
DynAbs.Tracing.TraceSender.TraceExitMethod(1205,1850,2239);

System.Management.Automation.SessionStateInternal
f_1205_2036_2058(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1205, 2036, 2058);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1205_2036_2075(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1205, 2036, 2075);
return return_v;
}


System.Management.Automation.LocationGlobber
f_1205_2036_2091(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.LocationGlobber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1205, 2036, 2091);
return return_v;
}


string
f_1205_2158_2162()
{
var return_v = Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1205, 2158, 2162);
return return_v;
}


string
f_1205_2130_2163(System.Management.Automation.LocationGlobber
this_param,string
path)
{
var return_v = this_param.GetProviderPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1205, 2130, 2163);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1205,1799,2250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,1799,2250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _providerPath;

private SessionState _sessionState;

public string Path
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1205,2498,2572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2534,2557);

return f_1205_2541_2556(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1205,2498,2572);

string
f_1205_2541_2556(System.Management.Automation.PathInfo
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1205, 2541, 2556);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1205,2455,2583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,2455,2583);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSDriveInfo _drive;

private ProviderInfo _provider;

private string _path ;

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1205,2918,3495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2976,2998);

string 
result = _path
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,3014,3454) || true) && (_drive == null ||(DynAbs.Tracing.TraceSender.Expression_False(1205, 3018, 3066)||f_1205_3053_3066(_drive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1205,3014,3454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,3171,3311);

result =
f_1205_3201_3310(_path, _provider);
DynAbs.Tracing.TraceSender.TraceExitCondition(1205,3014,3454);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1205,3014,3454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,3377,3439);

result = f_1205_3386_3438(_path, _drive);
DynAbs.Tracing.TraceSender.TraceExitCondition(1205,3014,3454);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,3470,3484);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1205,2918,3495);

bool
f_1205_3053_3066(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Hidden;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1205, 3053, 3066);
return return_v;
}


string
f_1205_3201_3310(string
path,System.Management.Automation.ProviderInfo
provider)
{
var return_v = LocationGlobber.GetProviderQualifiedPath( path, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1205, 3201, 3310);
return return_v;
}


string
f_1205_3386_3438(string
path,System.Management.Automation.PSDriveInfo
drive)
{
var return_v = LocationGlobber.GetDriveQualifiedPath( path, drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1205, 3386, 3438);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1205,2918,3495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,2918,3495);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PathInfo(PSDriveInfo drive, ProviderInfo provider, string path, SessionState sessionState)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1205,4305,5004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2277,2290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2322,2335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2615,2621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2653,2662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,2688,2708);
this._path = string.Empty;
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4429,4561) || true) && (provider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1205,4429,4561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4483,4546);

throw f_1205_4489_4545(nameof(provider));
DynAbs.Tracing.TraceSender.TraceExitCondition(1205,4429,4561);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4577,4701) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1205,4577,4701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4627,4686);

throw f_1205_4633_4685(nameof(path));
DynAbs.Tracing.TraceSender.TraceExitCondition(1205,4577,4701);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4717,4857) || true) && (sessionState == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1205,4717,4857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4775,4842);

throw f_1205_4781_4841(nameof(sessionState));
DynAbs.Tracing.TraceSender.TraceExitCondition(1205,4717,4857);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4873,4888);

_drive = drive;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4902,4923);

_provider = provider;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4937,4950);

_path = path;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1205,4964,4993);

_sessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1205,4305,5004);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1205,4305,5004);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,4305,5004);
}
		}

static PathInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1205,274,5011);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1205,274,5011);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1205,274,5011);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1205,274,5011);

System.Management.Automation.PSArgumentNullException
f_1205_4489_4545(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1205, 4489, 4545);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1205_4633_4685(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1205, 4633, 4685);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1205_4781_4841(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1205, 4781, 4841);
return return_v;
}

}
}
