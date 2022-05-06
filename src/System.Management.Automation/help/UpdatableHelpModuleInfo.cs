// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;
using System.Globalization;

namespace System.Management.Automation.Help
{
internal class UpdatableHelpModuleInfo
{
internal static readonly string HelpContentZipName ;

internal static readonly string HelpIntoXmlName ;

internal UpdatableHelpModuleInfo(string name, Guid guid, string path, string uri)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1179,941,1383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1468,1503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1840,1875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1961,1997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1047,1089);

f_1179_1047_1088(!f_1179_1061_1087(name));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1103,1130);

f_1179_1103_1129(guid != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1144,1186);

f_1179_1144_1185(!f_1179_1158_1184(path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1200,1241);

f_1179_1200_1240(!f_1179_1214_1239(uri));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1257,1275);

ModuleName = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1289,1308);

_moduleGuid = guid;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1322,1340);

ModuleBase = path;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1354,1372);

HelpInfoUri = uri;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1179,941,1383);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1179,941,1383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1179,941,1383);
}
		}

internal string ModuleName {get; }

internal Guid ModuleGuid
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1179,1637,1707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,1673,1692);

return _moduleGuid;
DynAbs.Tracing.TraceSender.TraceExitMethod(1179,1637,1707);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1179,1588,1718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1179,1588,1718);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private Guid _moduleGuid;

internal string ModuleBase {get; }

internal string HelpInfoUri {get; }

internal string GetHelpContentName(CultureInfo culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1179,2219,2453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,2299,2329);

f_1179_2299_2328(culture != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,2345,2442);

return f_1179_2352_2362()+ "_" + _moduleGuid.ToString()+ "_" + f_1179_2402_2414(culture)+ "_" + HelpContentZipName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1179,2219,2453);

int
f_1179_2299_2328(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 2299, 2328);
return 0;
}


string
f_1179_2352_2362()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1179, 2352, 2362);
return return_v;
}


string
f_1179_2402_2414(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1179, 2402, 2414);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1179,2219,2453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1179,2219,2453);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetHelpInfoName()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1179,2609,2751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,2667,2740);

return f_1179_2674_2684()+ "_" + _moduleGuid.ToString()+ "_" + HelpIntoXmlName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1179,2609,2751);

string
f_1179_2674_2684()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1179, 2674, 2684);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1179,2609,2751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1179,2609,2751);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static UpdatableHelpModuleInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1179,331,2758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,516,554);
HelpContentZipName = "HelpContent.cab";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1179,605,637);
HelpIntoXmlName = "HelpInfo.xml";DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1179,331,2758);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1179,331,2758);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1179,331,2758);

bool
f_1179_1061_1087(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 1061, 1087);
return return_v;
}


int
f_1179_1047_1088(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 1047, 1088);
return 0;
}


int
f_1179_1103_1129(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 1103, 1129);
return 0;
}


bool
f_1179_1158_1184(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 1158, 1184);
return return_v;
}


int
f_1179_1144_1185(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 1144, 1185);
return 0;
}


bool
f_1179_1214_1239(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 1214, 1239);
return return_v;
}


int
f_1179_1200_1240(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1179, 1200, 1240);
return 0;
}

}
}
