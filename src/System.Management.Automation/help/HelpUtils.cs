// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Management.Automation;
using System.Management.Automation.Help;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation
{
internal class HelpUtils
{
private static string userHomeHelpPath ;

internal static string GetUserHomeHelpSearchPath()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1162,468,1100);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,543,1049) || true) && (userHomeHelpPath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1162,543,1049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,829,949);

string 
userScopeRootPath = f_1162_856_948(f_1162_869_933(Environment.SpecialFolder.MyDocuments), "PowerShell")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,975,1034);

userHomeHelpPath = f_1162_994_1033(userScopeRootPath, "Help");
DynAbs.Tracing.TraceSender.TraceExitCondition(1162,543,1049);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,1065,1089);

return userHomeHelpPath;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1162,468,1100);

string
f_1162_869_933(System.Environment.SpecialFolder
folder)
{
var return_v = Environment.GetFolderPath( folder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 869, 933);
return return_v;
}


string
f_1162_856_948(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 856, 948);
return return_v;
}


string
f_1162_994_1033(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 994, 1033);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1162,468,1100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1162,468,1100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GetModuleBaseForUserHelp(string moduleBase, string moduleName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1162,1112,2768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,1222,1256);

string 
newModuleBase = moduleBase
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,1782,1829);

var 
userHelpPath = f_1162_1801_1828()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,1843,1906);

string 
moduleBaseParent = f_1162_1869_1905(f_1162_1869_1900(moduleBase))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,1922,2720) || true) && (f_1162_1926_1993(moduleBase, moduleName, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1162,1922,2720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,2130,2185);

newModuleBase = f_1162_2146_2184(userHelpPath, moduleName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1162,1922,2720);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1162,1922,2720);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,2219,2720) || true) && (f_1162_2223_2302(moduleBaseParent, moduleName, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1162,2219,2720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,2388,2437);

var 
moduleVersion = f_1162_2408_2436(moduleBase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,2455,2525);

newModuleBase = f_1162_2471_2524(userHelpPath, moduleName, moduleVersion);
DynAbs.Tracing.TraceSender.TraceExitCondition(1162,2219,2720);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1162,2219,2720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,2676,2705);

newModuleBase = userHelpPath;
DynAbs.Tracing.TraceSender.TraceExitCondition(1162,2219,2720);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1162,1922,2720);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,2736,2757);

return newModuleBase;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1162,1112,2768);

string
f_1162_1801_1828()
{
var return_v = GetUserHomeHelpSearchPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 1801, 1828);
return return_v;
}


System.IO.DirectoryInfo
f_1162_1869_1900(string
path)
{
var return_v = Directory.GetParent( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 1869, 1900);
return return_v;
}


string
f_1162_1869_1905(System.IO.DirectoryInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1162, 1869, 1905);
return return_v;
}


bool
f_1162_1926_1993(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 1926, 1993);
return return_v;
}


string
f_1162_2146_2184(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 2146, 2184);
return return_v;
}


bool
f_1162_2223_2302(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 2223, 2302);
return return_v;
}


string?
f_1162_2408_2436(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 2408, 2436);
return return_v;
}


string
f_1162_2471_2524(string
path1,string
path2,string
path3)
{
var return_v = Path.Combine( path1, path2, path3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1162, 2471, 2524);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1162,1112,2768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1162,1112,2768);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public HelpUtils()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1162,286,2775);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1162,286,2775);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1162,286,2775);
}


static HelpUtils()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1162,286,2775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1162,349,372);
userHomeHelpPath = null;DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1162,286,2775);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1162,286,2775);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1162,286,2775);
}
}
