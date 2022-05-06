// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
internal abstract class HelpProvider
{
internal HelpProvider(HelpSystem helpSystem)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1157,1780,1885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,1916,1927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,1849,1874);

_helpSystem = helpSystem;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1157,1780,1885);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1157,1780,1885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,1780,1885);
}
		}

private HelpSystem _helpSystem;

internal HelpSystem HelpSystem
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1157,1995,2065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,2031,2050);

return _helpSystem;
DynAbs.Tracing.TraceSender.TraceExitMethod(1157,1995,2065);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1157,1940,2076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,1940,2076);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal abstract string Name
{            get;
}

internal abstract HelpCategory HelpCategory
{            get;
}

internal abstract IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest);

internal abstract IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent);

internal virtual IEnumerable<HelpInfo> ProcessForwardedHelp(HelpInfo helpInfo, HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1157,6277,6691);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,6564,6644);

helpInfo.ForwardHelpCategory = f_1157_6595_6623(helpInfo)^ f_1157_6626_6643(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,6658,6680);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1157,6277,6691);

return listYield;

System.Management.Automation.HelpCategory
f_1157_6595_6623(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.ForwardHelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 6595, 6623);
return return_v;
}


System.Management.Automation.HelpCategory
f_1157_6626_6643(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 6626, 6643);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1157,6277,6691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,6277,6691);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1157,6872,6944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,6926,6933);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1157,6872,6944);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1157,6872,6944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,6872,6944);
}
		}

internal void ReportHelpFileError(Exception exception, string target, string helpFile)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1157,7617,8104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,7728,7843);

ErrorRecord 
errorRecord = f_1157_7754_7842(exception, "LoadHelpFileForTargetFailed", ErrorCategory.OpenError, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,7857,8014);

errorRecord.ErrorDetails = f_1157_7884_8013(f_1157_7901_7930(typeof(HelpProvider)), "HelpErrors", "LoadHelpFileForTargetFailed", target, helpFile, f_1157_7995_8012(exception));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,8028,8072);

f_1157_8028_8071(f_1157_8028_8054(f_1157_8028_8043(this)), errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,8086,8093);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1157,7617,8104);

System.Management.Automation.ErrorRecord
f_1157_7754_7842(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 7754, 7842);
return return_v;
}


System.Reflection.Assembly
f_1157_7901_7930(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 7901, 7930);
return return_v;
}


string
f_1157_7995_8012(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 7995, 8012);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1157_7884_8013(System.Reflection.Assembly
assembly,string
baseName,string
resourceId,params object[]
args)
{
var return_v = new System.Management.Automation.ErrorDetails( assembly, baseName, resourceId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 7884, 8013);
return return_v;
}


System.Management.Automation.HelpSystem
f_1157_8028_8043(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 8028, 8043);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1157_8028_8054(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 8028, 8054);
return return_v;
}


int
f_1157_8028_8071(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 8028, 8071);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1157,7617,8104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,7617,8104);
}
		}

internal string GetDefaultShellSearchPath()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1157,8407,9074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,8475,8533);

string 
shellID = f_1157_8492_8532(f_1157_8492_8524(f_1157_8492_8507(this)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,8682,8737);

string 
returnValue = f_1157_8703_8736(shellID)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,8753,9028) || true) && (returnValue == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1157,8753,9028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,8897,9013);

returnValue = f_1157_8911_9012(f_1157_8933_9011(f_1157_8933_9002(f_1157_8955_9001())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1157,8753,9028);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,9044,9063);

return returnValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1157,8407,9074);

System.Management.Automation.HelpSystem
f_1157_8492_8507(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 8492, 8507);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1157_8492_8524(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 8492, 8524);
return return_v;
}


string
f_1157_8492_8532(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ShellID;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 8492, 8532);
return return_v;
}


string
f_1157_8703_8736(string
shellId)
{
var return_v = Utils.GetApplicationBase( shellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 8703, 8736);
return return_v;
}


System.Diagnostics.Process
f_1157_8955_9001()
{
var return_v = System.Diagnostics.Process.GetCurrentProcess();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 8955, 9001);
return return_v;
}


System.Diagnostics.ProcessModule
f_1157_8933_9002(System.Diagnostics.Process
targetProcess)
{
var return_v = PsUtils.GetMainModule( targetProcess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 8933, 9002);
return return_v;
}


string
f_1157_8933_9011(System.Diagnostics.ProcessModule
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 8933, 9011);
return return_v;
}


string?
f_1157_8911_9012(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 8911, 9012);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1157,8407,9074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,8407,9074);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<string> GetSearchPaths()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1157,9395,9920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,9464,9530);

Collection<string> 
searchPaths = f_1157_9497_9529(f_1157_9497_9512(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,9546,9646);

f_1157_9546_9645(searchPaths != null, "HelpSystem returned an null search path");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,9662,9722);

string 
defaultShellSearchPath = f_1157_9694_9721(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,9736,9874) || true) && (!f_1157_9741_9785(searchPaths, defaultShellSearchPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1157,9736,9874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,9819,9859);

f_1157_9819_9858(                searchPaths, defaultShellSearchPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1157,9736,9874);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1157,9890,9909);

return searchPaths;
DynAbs.Tracing.TraceSender.TraceExitMethod(1157,9395,9920);

System.Management.Automation.HelpSystem
f_1157_9497_9512(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1157, 9497, 9512);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1157_9497_9529(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.GetSearchPaths();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 9497, 9529);
return return_v;
}


int
f_1157_9546_9645(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 9546, 9645);
return 0;
}


string
f_1157_9694_9721(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.GetDefaultShellSearchPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 9694, 9721);
return return_v;
}


bool
f_1157_9741_9785(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 9741, 9785);
return return_v;
}


int
f_1157_9819_9858(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1157, 9819, 9858);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1157,9395,9920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,9395,9920);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static HelpProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1157,1637,9949);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1157,1637,9949);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1157,1637,9949);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1157,1637,9949);
}
}
