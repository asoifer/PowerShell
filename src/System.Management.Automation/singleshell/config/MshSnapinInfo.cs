// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Text;

using Microsoft.PowerShell.Commands;
using Microsoft.Win32;

using Dbg = System.Management.Automation.Diagnostics;
using Regex = System.Text.RegularExpressions.Regex;

namespace System.Management.Automation
{
internal static class RegistryStrings
{
internal const string 
MonadRootKeyPath = "Software\\Microsoft\\PowerShell"
;

internal const string 
MonadRootKeyName = "PowerShell"
;

internal const string 
MonadEngineKey = "PowerShellEngine"
;

internal const string 
MonadEngine_ApplicationBase = "ApplicationBase"
;

internal const string 
MonadEngine_ConsoleHostAssemblyName = "ConsoleHostAssemblyName"
;

internal const string 
MonadEngine_ConsoleHostModuleName = "ConsoleHostModuleName"
;

internal const string 
MonadEngine_RuntimeVersion = "RuntimeVersion"
;

internal const string 
MonadEngine_MonadVersion = "PowerShellVersion"
;

internal const string 
MshSnapinKey = "PowerShellSnapIns"
;

internal const string 
MshSnapin_ApplicationBase = "ApplicationBase"
;

internal const string 
MshSnapin_AssemblyName = "AssemblyName"
;

internal const string 
MshSnapin_ModuleName = "ModuleName"
;

internal const string 
MshSnapin_MonadVersion = "PowerShellVersion"
;

internal const string 
MshSnapin_BuiltInTypes = "Types"
;

internal const string 
MshSnapin_BuiltInFormats = "Formats"
;

internal const string 
MshSnapin_Description = "Description"
;

internal const string 
MshSnapin_Version = "Version"
;

internal const string 
MshSnapin_Vendor = "Vendor"
;

internal const string 
MshSnapin_DescriptionResource = "DescriptionIndirect"
;

internal const string 
MshSnapin_VendorResource = "VendorIndirect"
;

internal const string 
MshSnapin_LogPipelineExecutionDetails = "LogPipelineExecutionDetails"
;

internal const string 
CoreMshSnapinName = "Microsoft.PowerShell.Core"
;

internal const string 
HostMshSnapinName = "Microsoft.PowerShell.Host"
;

internal const string 
ManagementMshSnapinName = "Microsoft.PowerShell.Management"
;

internal const string 
SecurityMshSnapinName = "Microsoft.PowerShell.Security"
;

internal const string 
UtilityMshSnapinName = "Microsoft.PowerShell.Utility"
;

static RegistryStrings()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1231,514,3084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,676,728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,838,869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,986,1021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1107,1154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1187,1250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1283,1342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1375,1420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1453,1499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1634,1668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1757,1802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1835,1874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1907,1942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,1975,2019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2052,2084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2117,2153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2186,2223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2256,2285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2318,2345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2378,2431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2464,2507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2540,2609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2683,2730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2763,2810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2843,2902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,2935,2990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,3023,3076);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1231,514,3084);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,514,3084);
}

}
public class PSSnapInInfo
{
internal PSSnapInInfo
        (
            string name,
            bool isDefault,
            string applicationBase,
            string assemblyName,
            string moduleName,
            Version psVersion,
            Version version,
            Collection<string> types,
            Collection<string> formats,
            string descriptionFallback,
            string vendorFallback
        )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1231,3222,5470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7333,7360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7469,7499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7610,7648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7755,7790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7887,7920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8570,8603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8697,8728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8868,8908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9049,9091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9118,9138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9164,9199);
this._descriptionFallback = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9225,9237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9622,9637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9663,9693);
this._vendorFallback = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9719,9726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,10193,10255);
this.LogPipelineExecutionDetails = false;
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,3666,3798) || true) && (f_1231_3670_3696(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,3666,3798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,3730,3783);

throw f_1231_3736_3782("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,3666,3798);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,3814,3968) || true) && (f_1231_3818_3855(applicationBase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,3814,3968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,3889,3953);

throw f_1231_3895_3952("applicationBase");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,3814,3968);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,3984,4132) || true) && (f_1231_3988_4022(assemblyName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,3984,4132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4056,4117);

throw f_1231_4062_4116("assemblyName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,3984,4132);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4148,4292) || true) && (f_1231_4152_4184(moduleName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,4148,4292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4218,4277);

throw f_1231_4224_4276("moduleName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,4148,4292);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4308,4436) || true) && (psVersion == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,4308,4436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4363,4421);

throw f_1231_4369_4420("psVersion");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,4308,4436);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4452,4549) || true) && (version == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,4452,4549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4505,4534);

version = f_1231_4515_4533("0.0");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,4452,4549);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4565,4664) || true) && (types == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,4565,4664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4616,4649);

types = f_1231_4624_4648();
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,4565,4664);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4680,4783) || true) && (formats == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,4680,4783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4733,4768);

formats = f_1231_4743_4767();
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,4680,4783);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4799,4914) || true) && (descriptionFallback == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,4799,4914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4864,4899);

descriptionFallback = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,4799,4914);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4930,5035) || true) && (vendorFallback == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,4930,5035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,4990,5020);

vendorFallback = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,4930,5035);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5051,5063);

Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5077,5099);

IsDefault = isDefault;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5113,5147);

ApplicationBase = applicationBase;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5161,5189);

AssemblyName = assemblyName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5203,5227);

ModuleName = moduleName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5241,5263);

PSVersion = psVersion;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5277,5295);

Version = version;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5309,5323);

Types = types;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5337,5355);

Formats = formats;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5369,5412);

_descriptionFallback = descriptionFallback;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,5426,5459);

_vendorFallback = vendorFallback;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1231,3222,5470);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,3222,5470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,3222,5470);
}
		}

internal PSSnapInInfo
        (
            string name,
            bool isDefault,
            string applicationBase,
            string assemblyName,
            string moduleName,
            Version psVersion,
            Version version,
            Collection<string> types,
            Collection<string> formats,
            string description,
            string descriptionFallback,
            string vendor,
            string vendorFallback
        )
:this(f_1231_5979_5983_C(name) ,isDefault,applicationBase,assemblyName,moduleName,psVersion,version,types,formats,descriptionFallback,vendorFallback)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1231,5482,6205);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,6136,6163);

_description = description;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,6177,6194);

_vendor = vendor;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1231,5482,6205);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,5482,6205);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,5482,6205);
}
		}

internal PSSnapInInfo
        (
            string name,
            bool isDefault,
            string applicationBase,
            string assemblyName,
            string moduleName,
            Version psVersion,
            Version version,
            Collection<string> types,
            Collection<string> formats,
            string description,
            string descriptionFallback,
            string descriptionIndirect,
            string vendor,
            string vendorFallback,
            string vendorIndirect
        ) :this(f_1231_6782_6786_C(name) ,isDefault,applicationBase,assemblyName,moduleName,psVersion,version,types,formats,description,descriptionFallback,vendor,vendorFallback)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1231,6217,7231);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7064,7220) || true) && (isDefault)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,7064,7220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7111,7154);

_descriptionIndirect = descriptionIndirect;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,7172,7205);

_vendorIndirect = vendorIndirect;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,7064,7220);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1231,6217,7231);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,6217,7231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,6217,7231);
}
		}

public string Name {get; }

public bool IsDefault {get; }

public string ApplicationBase {get; }

public string AssemblyName {get; }

public string ModuleName {get; }

internal string AbsoluteModulePath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,7991,8454);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8027,8370) || true) && (f_1231_8031_8063(f_1231_8052_8062())||(DynAbs.Tracing.TraceSender.Expression_False(1231, 8031, 8096)||f_1231_8067_8096(f_1231_8085_8095())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,8027,8370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8138,8156);

return f_1231_8145_8155();
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,8027,8370);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,8027,8370);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8198,8370) || true) && (!f_1231_8203_8257(f_1231_8215_8256(f_1231_8228_8243(), f_1231_8245_8255())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,8198,8370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8299,8351);

return f_1231_8306_8350(f_1231_8339_8349());
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,8198,8370);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,8027,8370);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,8390,8439);

return f_1231_8397_8438(f_1231_8410_8425(), f_1231_8427_8437());
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,7991,8454);

string
f_1231_8052_8062()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8052, 8062);
return return_v;
}


bool
f_1231_8031_8063(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 8031, 8063);
return return_v;
}


string
f_1231_8085_8095()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8085, 8095);
return return_v;
}


bool
f_1231_8067_8096(string
path)
{
var return_v = Path.IsPathRooted( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 8067, 8096);
return return_v;
}


string
f_1231_8145_8155()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8145, 8155);
return return_v;
}


string
f_1231_8228_8243()
{
var return_v = ApplicationBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8228, 8243);
return return_v;
}


string
f_1231_8245_8255()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8245, 8255);
return return_v;
}


string
f_1231_8215_8256(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 8215, 8256);
return return_v;
}


bool
f_1231_8203_8257(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 8203, 8257);
return return_v;
}


string
f_1231_8339_8349()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8339, 8349);
return return_v;
}


string?
f_1231_8306_8350(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 8306, 8350);
return return_v;
}


string
f_1231_8410_8425()
{
var return_v = ApplicationBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8410, 8425);
return return_v;
}


string
f_1231_8427_8437()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 8427, 8437);
return return_v;
}


string
f_1231_8397_8438(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 8397, 8438);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,7932,8465);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,7932,8465);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Version PSVersion {get; }

public Version Version {get; }

public Collection<string> Types {get; }

public Collection<string> Formats {get; }

private string _descriptionIndirect;

private string _descriptionFallback ;

private string _description;

public string Description
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,9384,9584);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9420,9529) || true) && (_description == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,9420,9529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9486,9510);

f_1231_9486_9509(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,9420,9529);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9549,9569);

return _description;
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,9384,9584);

int
f_1231_9486_9509(System.Management.Automation.PSSnapInInfo
this_param)
{
this_param.LoadIndirectResources();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 9486, 9509);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,9334,9595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,9334,9595);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _vendorIndirect;

private string _vendorFallback ;

private string _vendor;

public string Vendor
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,9863,10053);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9899,10003) || true) && (_vendor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,9899,10003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,9960,9984);

f_1231_9960_9983(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,9899,10003);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,10023,10038);

return _vendor;
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,9863,10053);

int
f_1231_9960_9983(System.Management.Automation.PSSnapInInfo
this_param)
{
this_param.LoadIndirectResources();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 9960, 9983);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,9818,10064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,9818,10064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool LogPipelineExecutionDetails {get; set; }

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,10428,10509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,10486,10498);

return f_1231_10493_10497();
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,10428,10509);

string
f_1231_10493_10497()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 10493, 10497);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,10428,10509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,10428,10509);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal RegistryKey MshSnapinKey
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,10579,11140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,10615,10647);

RegistryKey 
mshsnapinKey = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,10711,10819);

mshsnapinKey = f_1231_10726_10818(f_1231_10757_10761(), f_1231_10763_10817(f_1231_10763_10778(f_1231_10763_10772()), f_1231_10788_10816()));
                }
                catch (ArgumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,10856,10919);
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,10856,10919);
                }
                catch (SecurityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,10937,11000);
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,10937,11000);
                }
                catch (System.IO.IOException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,11018,11085);
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,11018,11085);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,11105,11125);

return mshsnapinKey;
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,10579,11140);

string
f_1231_10757_10761()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 10757, 10761);
return return_v;
}


System.Version
f_1231_10763_10772()
{
var return_v = PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 10763, 10772);
return return_v;
}


int
f_1231_10763_10778(System.Version
this_param)
{
var return_v = this_param.Major;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 10763, 10778);
return return_v;
}


System.Globalization.CultureInfo
f_1231_10788_10816()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 10788, 10816);
return return_v;
}


string
f_1231_10763_10817(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 10763, 10817);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_10726_10818(string
mshSnapInName,string
psVersion)
{
var return_v = PSSnapInReader.GetMshSnapinKey( mshSnapInName, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 10726, 10818);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,10521,11151);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,10521,11151);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void LoadIndirectResources()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,11163,11436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,11225,11425);
using(RegistryStringResourceIndirect 
resourceReader = f_1231_11280_11338()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,11372,11410);

f_1231_11372_11409(this, resourceReader);
DynAbs.Tracing.TraceSender.TraceExitUsing(1231,11225,11425);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,11163,11436);

System.Management.Automation.RegistryStringResourceIndirect
f_1231_11280_11338()
{
var return_v = RegistryStringResourceIndirect.GetResourceIndirectReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 11280, 11338);
return return_v;
}


int
f_1231_11372_11409(System.Management.Automation.PSSnapInInfo
this_param,System.Management.Automation.RegistryStringResourceIndirect
resourceReader)
{
this_param.LoadIndirectResources( resourceReader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 11372, 11409);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,11163,11436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,11163,11436);
}
		}

internal void LoadIndirectResources(RegistryStringResourceIndirect resourceReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,11448,13160);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,11555,12886) || true) && (f_1231_11559_11568())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,11555,12886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,11732,11900);

_description = f_1231_11747_11899(resourceReader, f_1231_11810_11822(), f_1231_11845_11855(), _descriptionIndirect);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,11920,12078);

_vendor = f_1231_11930_12077(resourceReader, f_1231_11993_12005(), f_1231_12028_12038(), _vendorIndirect);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,11555,12886);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,11555,12886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,12144,12184);

RegistryKey 
mshsnapinKey = f_1231_12171_12183()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,12202,12871) || true) && (mshsnapinKey != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,12202,12871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,12268,12553);

_description =
f_1231_12308_12552(                        resourceReader, mshsnapinKey, RegistryStrings.MshSnapin_DescriptionResource, f_1231_12498_12510(), f_1231_12541_12551());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,12577,12852);

_vendor =
f_1231_12612_12851(                        resourceReader, mshsnapinKey, RegistryStrings.MshSnapin_VendorResource, f_1231_12797_12809(), f_1231_12840_12850());
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,12202,12871);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,11555,12886);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,12902,13025) || true) && (f_1231_12906_12940(_description))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,12902,13025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,12974,13010);

_description = _descriptionFallback;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,12902,13025);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,13041,13149) || true) && (f_1231_13045_13074(_vendor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,13041,13149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,13108,13134);

_vendor = _vendorFallback;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,13041,13149);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,11448,13160);

bool
f_1231_11559_11568()
{
var return_v = IsDefault;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 11559, 11568);
return return_v;
}


string
f_1231_11810_11822()
{
var return_v = AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 11810, 11822);
return return_v;
}


string
f_1231_11845_11855()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 11845, 11855);
return return_v;
}


string
f_1231_11747_11899(System.Management.Automation.RegistryStringResourceIndirect
this_param,string
assemblyName,string
modulePath,string
baseNameRIDPair)
{
var return_v = this_param.GetResourceStringIndirect( assemblyName, modulePath, baseNameRIDPair);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 11747, 11899);
return return_v;
}


string
f_1231_11993_12005()
{
var return_v = AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 11993, 12005);
return return_v;
}


string
f_1231_12028_12038()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 12028, 12038);
return return_v;
}


string
f_1231_11930_12077(System.Management.Automation.RegistryStringResourceIndirect
this_param,string
assemblyName,string
modulePath,string
baseNameRIDPair)
{
var return_v = this_param.GetResourceStringIndirect( assemblyName, modulePath, baseNameRIDPair);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 11930, 12077);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_12171_12183()
{
var return_v = MshSnapinKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 12171, 12183);
return return_v;
}


string
f_1231_12498_12510()
{
var return_v = AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 12498, 12510);
return return_v;
}


string
f_1231_12541_12551()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 12541, 12551);
return return_v;
}


string
f_1231_12308_12552(System.Management.Automation.RegistryStringResourceIndirect
this_param,Microsoft.Win32.RegistryKey
key,string
valueName,string
assemblyName,string
modulePath)
{
var return_v = this_param.GetResourceStringIndirect( key, valueName, assemblyName, modulePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 12308, 12552);
return return_v;
}


string
f_1231_12797_12809()
{
var return_v = AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 12797, 12809);
return return_v;
}


string
f_1231_12840_12850()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 12840, 12850);
return return_v;
}


string
f_1231_12612_12851(System.Management.Automation.RegistryStringResourceIndirect
this_param,Microsoft.Win32.RegistryKey
key,string
valueName,string
assemblyName,string
modulePath)
{
var return_v = this_param.GetResourceStringIndirect( key, valueName, assemblyName, modulePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 12612, 12851);
return return_v;
}


bool
f_1231_12906_12940(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 12906, 12940);
return return_v;
}


bool
f_1231_13045_13074(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 13045, 13074);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,11448,13160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,11448,13160);
}
		}

internal PSSnapInInfo Clone()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1231,13172,13810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,13226,13769);

PSSnapInInfo 
cloned = f_1231_13248_13768(f_1231_13283_13287(), f_1231_13306_13315(), f_1231_13334_13349(), f_1231_13368_13380(), f_1231_13399_13409(), f_1231_13428_13437(), f_1231_13456_13463(), f_1231_13482_13511(f_1231_13505_13510()), f_1231_13530_13561(f_1231_13553_13560()), _description, _descriptionFallback, _descriptionIndirect, _vendor, _vendorFallback, _vendorIndirect)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,13785,13799);

return cloned;
DynAbs.Tracing.TraceSender.TraceExitMethod(1231,13172,13810);

string
f_1231_13283_13287()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13283, 13287);
return return_v;
}


bool
f_1231_13306_13315()
{
var return_v = IsDefault;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13306, 13315);
return return_v;
}


string
f_1231_13334_13349()
{
var return_v = ApplicationBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13334, 13349);
return return_v;
}


string
f_1231_13368_13380()
{
var return_v = AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13368, 13380);
return return_v;
}


string
f_1231_13399_13409()
{
var return_v = ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13399, 13409);
return return_v;
}


System.Version
f_1231_13428_13437()
{
var return_v = PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13428, 13437);
return return_v;
}


System.Version
f_1231_13456_13463()
{
var return_v = Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13456, 13463);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_13505_13510()
{
var return_v = Types;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13505, 13510);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_13482_13511(System.Collections.ObjectModel.Collection<string>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 13482, 13511);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_13553_13560()
{
var return_v = Formats;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 13553, 13560);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_13530_13561(System.Collections.ObjectModel.Collection<string>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 13530, 13561);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1231_13248_13768(string
name,bool
isDefault,string
applicationBase,string
assemblyName,string
moduleName,System.Version
psVersion,System.Version
version,System.Collections.ObjectModel.Collection<string>
types,System.Collections.ObjectModel.Collection<string>
formats,string
description,string
descriptionFallback,string
descriptionIndirect,string
vendor,string
vendorFallback,string
vendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInInfo( name, isDefault, applicationBase, assemblyName, moduleName, psVersion, version, types, formats, description, descriptionFallback, descriptionIndirect, vendor, vendorFallback, vendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 13248, 13768);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,13172,13810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,13172,13810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsPSSnapinIdValid(string psSnapinId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,14089,14353);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,14171,14269) || true) && (f_1231_14175_14207(psSnapinId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,14171,14269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,14241,14254);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,14171,14269);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,14285,14342);

return f_1231_14292_14341(psSnapinId, "^[A-Za-z0-9-_\x2E]*$");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,14089,14353);

bool
f_1231_14175_14207(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 14175, 14207);
return return_v;
}


bool
f_1231_14292_14341(string
input,string
pattern)
{
var return_v = Regex.IsMatch( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 14292, 14341);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,14089,14353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,14089,14353);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void VerifyPSSnapInFormatThrowIfError(string psSnapinId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,14743,15270);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,14950,15194) || true) && (!f_1231_14955_14984(psSnapinId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,14950,15194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,15018,15179);

throw f_1231_15024_15178(nameof(psSnapinId), f_1231_15100_15144(), psSnapinId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,14950,15194);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,15252,15259);

return;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,14743,15270);

bool
f_1231_14955_14984(string
psSnapinId)
{
var return_v = IsPSSnapinIdValid( psSnapinId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 14955, 14984);
return return_v;
}


string
f_1231_15100_15144()
{
var return_v =                     MshSnapInCmdletResources.InvalidPSSnapInName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 15100, 15144);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_15024_15178(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 15024, 15178);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,14743,15270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,14743,15270);
}
		}

static PSSnapInInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1231,3180,15277);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1231,3180,15277);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,3180,15277);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1231,3180,15277);

bool
f_1231_3670_3696(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 3670, 3696);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_3736_3782(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 3736, 3782);
return return_v;
}


bool
f_1231_3818_3855(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 3818, 3855);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_3895_3952(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 3895, 3952);
return return_v;
}


bool
f_1231_3988_4022(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 3988, 4022);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_4062_4116(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 4062, 4116);
return return_v;
}


bool
f_1231_4152_4184(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 4152, 4184);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_4224_4276(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 4224, 4276);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_4369_4420(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 4369, 4420);
return return_v;
}


System.Version
f_1231_4515_4533(string
version)
{
var return_v = new System.Version( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 4515, 4533);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_4624_4648()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 4624, 4648);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_4743_4767()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 4743, 4767);
return return_v;
}


static string
f_1231_5979_5983_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1231, 5482, 6205);
return return_v;
}


static string
f_1231_6782_6786_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1231, 6217, 7231);
return return_v;
}

}
internal static class PSSnapInReader
{
internal static Collection<PSSnapInInfo> ReadAll()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,15926,18125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16001,16073);

Collection<PSSnapInInfo> 
allMshSnapins = f_1231_16042_16072()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16087,16132);

RegistryKey 
monadRootKey = f_1231_16114_16131()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16148,16198);

string[] 
versions = f_1231_16168_16197(monadRootKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16212,16302) || true) && (versions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,16212,16302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16266,16287);

return allMshSnapins;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,16212,16302);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16442,16505);

Collection<string> 
filteredVersions = f_1231_16480_16504()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16519,16948);
foreach(string version in f_1231_16546_16554_I(versions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,16519,16948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16588,16665);

string 
temp = f_1231_16602_16664(version)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16683,16789) || true) && (f_1231_16687_16713(temp))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,16683,16789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16755,16770);

temp = version;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,16683,16789);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16809,16933) || true) && (!f_1231_16814_16845(filteredVersions, temp))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,16809,16933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16887,16914);

f_1231_16887_16913(                    filteredVersions, temp);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,16809,16933);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,16519,16948);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1231,1,430);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1231,1,430);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,16964,18077);
foreach(string version in f_1231_16991_17007_I(filteredVersions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,16964,18077);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17041,17144) || true) && (f_1231_17045_17074(version))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,17041,17144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17116,17125);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,17041,17144);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17215,17317) || true) && (!f_1231_17220_17247(version))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,17215,17317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17289,17298);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,17215,17317);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17337,17390);

Collection<PSSnapInInfo> 
oneVersionMshSnapins = null
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17452,17506);

oneVersionMshSnapins = f_1231_17475_17505(monadRootKey, version);
                }
                // If we cannot get information for one version, continue with other
                // versions
                catch (SecurityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,17658,17721);
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,17658,17721);
                }
                catch (ArgumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,17739,17802);
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,17739,17802);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17822,18062) || true) && (oneVersionMshSnapins != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,17822,18062);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17896,18043);
foreach(PSSnapInInfo info in f_1231_17926_17946_I(oneVersionMshSnapins) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,17896,18043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,17996,18020);

f_1231_17996_18019(                        allMshSnapins, info);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,17896,18043);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1231,1,148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1231,1,148);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1231,17822,18062);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,16964,18077);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1231,1,1114);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1231,1,1114);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,18093,18114);

return allMshSnapins;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,15926,18125);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
f_1231_16042_16072()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16042, 16072);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_16114_16131()
{
var return_v = GetMonadRootKey();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16114, 16131);
return return_v;
}


string[]
f_1231_16168_16197(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.GetSubKeyNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16168, 16197);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_16480_16504()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16480, 16504);
return return_v;
}


string
f_1231_16602_16664(string
majorVersion)
{
var return_v = PSVersionInfo.GetRegistryVersionKeyForSnapinDiscovery( majorVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16602, 16664);
return return_v;
}


bool
f_1231_16687_16713(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16687, 16713);
return return_v;
}


bool
f_1231_16814_16845(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16814, 16845);
return return_v;
}


int
f_1231_16887_16913(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16887, 16913);
return 0;
}


string[]
f_1231_16546_16554_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16546, 16554);
return return_v;
}


bool
f_1231_17045_17074(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 17045, 17074);
return return_v;
}


bool
f_1231_17220_17247(string
version)
{
var return_v = MeetsVersionFormat( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 17220, 17247);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
f_1231_17475_17505(Microsoft.Win32.RegistryKey
monadRootKey,string
psVersion)
{
var return_v = ReadAll( monadRootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 17475, 17505);
return return_v;
}


int
f_1231_17996_18019(System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
this_param,System.Management.Automation.PSSnapInInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 17996, 18019);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
f_1231_17926_17946_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 17926, 17946);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_16991_17007_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 16991, 17007);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,15926,18125);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,15926,18125);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        static
        bool MeetsVersionFormat(string version)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,18314,18709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,18411,18425);

bool 
r = true
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,18475,18556);

f_1231_18475_18555(version, typeof(int), f_1231_18526_18554());
            }
            catch (PSInvalidCastException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,18585,18673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,18648,18658);

r = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,18585,18673);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,18689,18698);

return r;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,18314,18709);

System.Globalization.CultureInfo
f_1231_18526_18554()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 18526, 18554);
return return_v;
}


object
f_1231_18475_18555(string
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( (object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 18475, 18555);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,18314,18709);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,18314,18709);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Collection<PSSnapInInfo> ReadAll(string psVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,19210,19569);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,19301,19443) || true) && (f_1231_19305_19336(psVersion))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,19301,19443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,19370,19428);

throw f_1231_19376_19427("psVersion");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,19301,19443);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,19459,19504);

RegistryKey 
monadRootKey = f_1231_19486_19503()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,19518,19558);

return f_1231_19525_19557(monadRootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,19210,19569);

bool
f_1231_19305_19336(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 19305, 19336);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_19376_19427(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 19376, 19427);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_19486_19503()
{
var return_v = GetMonadRootKey();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 19486, 19503);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
f_1231_19525_19557(Microsoft.Win32.RegistryKey
monadRootKey,string
psVersion)
{
var return_v = ReadAll( monadRootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 19525, 19557);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,19210,19569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,19210,19569);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Collection<PSSnapInInfo> ReadAll(RegistryKey monadRootKey, string psVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,20129,21409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20245,20320);

f_1231_20245_20319(monadRootKey != null, "caller should validate the information");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20334,20421);

f_1231_20334_20420(!f_1231_20346_20377(psVersion), "caller should validate the information");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20437,20506);

Collection<PSSnapInInfo> 
mshsnapins = f_1231_20475_20505()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20520,20589);

RegistryKey 
versionRoot = f_1231_20546_20588(monadRootKey, psVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20603,20675);

RegistryKey 
mshsnapinRoot = f_1231_20631_20674(versionRoot, psVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20750,20805);

string[] 
mshsnapinIds = f_1231_20774_20804(mshsnapinRoot)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20821,21364);
foreach(string id in f_1231_20843_20855_I(mshsnapinIds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,20821,21364);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20889,20987) || true) && (f_1231_20893_20917(id))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,20889,20987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,20959,20968);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,20889,20987);
}

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,21051,21094);

f_1231_21051_21093(                    mshsnapins, f_1231_21066_21092(mshsnapinRoot, id));
                }
                // If we cannot read some mshsnapins, we should continue
                catch (SecurityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,21205,21268);
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,21205,21268);
                }
                catch (ArgumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,21286,21349);
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,21286,21349);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,20821,21364);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1231,1,544);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1231,1,544);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,21380,21398);

return mshsnapins;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,20129,21409);

int
f_1231_20245_20319(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20245, 20319);
return 0;
}


bool
f_1231_20346_20377(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20346, 20377);
return return_v;
}


int
f_1231_20334_20420(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20334, 20420);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
f_1231_20475_20505()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20475, 20505);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_20546_20588(Microsoft.Win32.RegistryKey
rootKey,string
psVersion)
{
var return_v = GetVersionRootKey( rootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20546, 20588);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_20631_20674(Microsoft.Win32.RegistryKey
versionRootKey,string
psVersion)
{
var return_v = GetMshSnapinRootKey( versionRootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20631, 20674);
return return_v;
}


string[]
f_1231_20774_20804(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.GetSubKeyNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20774, 20804);
return return_v;
}


bool
f_1231_20893_20917(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20893, 20917);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1231_21066_21092(Microsoft.Win32.RegistryKey
mshSnapInRoot,string
mshsnapinId)
{
var return_v = ReadOne( mshSnapInRoot, mshsnapinId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 21066, 21092);
return return_v;
}


int
f_1231_21051_21093(System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
this_param,System.Management.Automation.PSSnapInInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 21051, 21093);
return 0;
}


string[]
f_1231_20843_20855_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 20843, 20855);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,20129,21409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,20129,21409);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static PSSnapInInfo Read(string psVersion, string mshsnapinId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,22143,23098);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22239,22381) || true) && (f_1231_22243_22274(psVersion))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,22239,22381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22308,22366);

throw f_1231_22314_22365("psVersion");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,22239,22381);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22397,22543) || true) && (f_1231_22401_22434(mshsnapinId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,22397,22543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22468,22528);

throw f_1231_22474_22527("mshsnapinId");
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,22397,22543);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22749,22808);

f_1231_22749_22807(mshsnapinId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22824,22864);

RegistryKey 
rootKey = f_1231_22846_22863()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22878,22942);

RegistryKey 
versionRoot = f_1231_22904_22941(rootKey, psVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,22956,23028);

RegistryKey 
mshsnapinRoot = f_1231_22984_23027(versionRoot, psVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,23044,23087);

return f_1231_23051_23086(mshsnapinRoot, mshsnapinId);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,22143,23098);

bool
f_1231_22243_22274(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22243, 22274);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_22314_22365(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22314, 22365);
return return_v;
}


bool
f_1231_22401_22434(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22401, 22434);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1231_22474_22527(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22474, 22527);
return return_v;
}


int
f_1231_22749_22807(string
psSnapinId)
{
PSSnapInInfo.VerifyPSSnapInFormatThrowIfError( psSnapinId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22749, 22807);
return 0;
}


Microsoft.Win32.RegistryKey
f_1231_22846_22863()
{
var return_v = GetMonadRootKey();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22846, 22863);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_22904_22941(Microsoft.Win32.RegistryKey
rootKey,string
psVersion)
{
var return_v = GetVersionRootKey( rootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22904, 22941);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_22984_23027(Microsoft.Win32.RegistryKey
versionRootKey,string
psVersion)
{
var return_v = GetMshSnapinRootKey( versionRootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 22984, 23027);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1231_23051_23086(Microsoft.Win32.RegistryKey
mshSnapInRoot,string
mshsnapinId)
{
var return_v = ReadOne( mshSnapInRoot, mshsnapinId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 23051, 23086);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,22143,23098);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,22143,23098);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static PSSnapInInfo ReadOne(RegistryKey mshSnapInRoot, string mshsnapinId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,23755,26927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,23862,23949);

f_1231_23862_23948(!f_1231_23874_23907(mshsnapinId), "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,23963,24037);

f_1231_23963_24036(mshSnapInRoot != null, "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24053,24078);

RegistryKey 
mshsnapinKey
=default(RegistryKey);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24092,24145);

mshsnapinKey = f_1231_24107_24144(mshSnapInRoot, mshsnapinId);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24159,24458) || true) && (mshsnapinKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,24159,24458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24217,24319);

f_1231_24217_24318(                s_mshsnapinTracer, "Error opening registry key {0}\\{1}.", f_1231_24286_24304(mshSnapInRoot), mshsnapinId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24337,24443);

throw f_1231_24343_24442("mshsnapinId", f_1231_24393_24428(), mshsnapinId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,24159,24458);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24474,24578);

string 
applicationBase = f_1231_24499_24577(mshsnapinKey, RegistryStrings.MshSnapin_ApplicationBase, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24592,24690);

string 
assemblyName = f_1231_24614_24689(mshsnapinKey, RegistryStrings.MshSnapin_AssemblyName, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24704,24798);

string 
moduleName = f_1231_24724_24797(mshsnapinKey, RegistryStrings.MshSnapin_ModuleName, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24812,24912);

Version 
monadVersion = f_1231_24835_24911(mshsnapinKey, RegistryStrings.MshSnapin_MonadVersion, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,24926,25017);

Version 
version = f_1231_24944_25016(mshsnapinKey, RegistryStrings.MshSnapin_Version, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25033,25130);

string 
description = f_1231_25054_25129(mshsnapinKey, RegistryStrings.MshSnapin_Description, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25144,25388) || true) && (description == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,25144,25388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25201,25328);

f_1231_25201_25327(                s_mshsnapinTracer, "No description is specified for mshsnapin {0}. Using empty string for description.", mshsnapinId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25346,25373);

description = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,25144,25388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25404,25491);

string 
vendor = f_1231_25420_25490(mshsnapinKey, RegistryStrings.MshSnapin_Vendor, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25505,25734) || true) && (vendor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,25505,25734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25557,25679);

f_1231_25557_25678(                s_mshsnapinTracer, "No vendor is specified for mshsnapin {0}. Using empty string for description.", mshsnapinId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25697,25719);

vendor = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,25505,25734);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25750,25791);

bool 
logPipelineExecutionDetails = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25805,25937);

string 
logPipelineExecutionDetailsStr = f_1231_25845_25936(mshsnapinKey, RegistryStrings.MshSnapin_LogPipelineExecutionDetails, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,25951,26211) || true) && (!f_1231_25956_26008(logPipelineExecutionDetailsStr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,25951,26211);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26042,26196) || true) && (f_1231_26046_26133("1", logPipelineExecutionDetailsStr, StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,26042,26196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26161,26196);

logPipelineExecutionDetails = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,26042,26196);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,25951,26211);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26227,26336);

Collection<string> 
types = f_1231_26254_26335(mshsnapinKey, RegistryStrings.MshSnapin_BuiltInTypes, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26350,26463);

Collection<string> 
formats = f_1231_26379_26462(mshsnapinKey, RegistryStrings.MshSnapin_BuiltInFormats, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26479,26610);

f_1231_26479_26609(
            s_mshsnapinTracer, "Successfully read registry values for mshsnapin {0}. Constructing PSSnapInInfo object.", mshsnapinId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26624,26793);

PSSnapInInfo 
mshSnapinInfo = f_1231_26653_26792(mshsnapinId, false, applicationBase, assemblyName, moduleName, monadVersion, version, types, formats, description, vendor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26807,26879);

mshSnapinInfo.LogPipelineExecutionDetails = logPipelineExecutionDetails;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,26895,26916);

return mshSnapinInfo;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,23755,26927);

bool
f_1231_23874_23907(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 23874, 23907);
return return_v;
}


int
f_1231_23862_23948(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 23862, 23948);
return 0;
}


int
f_1231_23963_24036(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 23963, 24036);
return 0;
}


Microsoft.Win32.RegistryKey
f_1231_24107_24144(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24107, 24144);
return return_v;
}


string
f_1231_24286_24304(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 24286, 24304);
return return_v;
}


int
f_1231_24217_24318(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24217, 24318);
return 0;
}


string
f_1231_24393_24428()
{
var return_v = MshSnapinInfo.MshSnapinDoesNotExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 24393, 24428);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_24343_24442(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24343, 24442);
return return_v;
}


string
f_1231_24499_24577(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24499, 24577);
return return_v;
}


string
f_1231_24614_24689(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24614, 24689);
return return_v;
}


string
f_1231_24724_24797(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24724, 24797);
return return_v;
}


System.Version
f_1231_24835_24911(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadVersionValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24835, 24911);
return return_v;
}


System.Version
f_1231_24944_25016(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadVersionValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 24944, 25016);
return return_v;
}


string
f_1231_25054_25129(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 25054, 25129);
return return_v;
}


int
f_1231_25201_25327(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 25201, 25327);
return 0;
}


string
f_1231_25420_25490(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 25420, 25490);
return return_v;
}


int
f_1231_25557_25678(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 25557, 25678);
return 0;
}


string
f_1231_25845_25936(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 25845, 25936);
return return_v;
}


bool
f_1231_25956_26008(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 25956, 26008);
return return_v;
}


int
f_1231_26046_26133(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 26046, 26133);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_26254_26335(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadMultiStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 26254, 26335);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_26379_26462(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadMultiStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 26379, 26462);
return return_v;
}


int
f_1231_26479_26609(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 26479, 26609);
return 0;
}


System.Management.Automation.PSSnapInInfo
f_1231_26653_26792(string
name,bool
isDefault,string
applicationBase,string
assemblyName,string
moduleName,System.Version
psVersion,System.Version
version,System.Collections.ObjectModel.Collection<string>
types,System.Collections.ObjectModel.Collection<string>
formats,string
descriptionFallback,string
vendorFallback)
{
var return_v = new System.Management.Automation.PSSnapInInfo( name, isDefault, applicationBase, assemblyName, moduleName, psVersion, version, types, formats, descriptionFallback, vendorFallback);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 26653, 26792);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,23755,26927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,23755,26927);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Collection<string> ReadMultiStringValue(RegistryKey mshsnapinKey, string name, bool mandatory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,27336,29293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,27470,27513);

object 
value = f_1231_27485_27512(mshsnapinKey, name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,27527,28100) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,27527,28100);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,27641,28085) || true) && (mandatory)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,27641,28085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,27696,27836);

f_1231_27696_27835(                    s_mshsnapinTracer, "Mandatory property {0} not specified for registry key {1}", name, f_1231_27817_27834(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,27858,27972);

throw f_1231_27864_27971("name", f_1231_27907_27945(), name, f_1231_27953_27970(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,27641,28085);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,27641,28085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28054,28066);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,27641,28085);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,27527,28100);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28161,28194);

string[] 
msv = value as string[]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28210,28535) || true) && (msv == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,28210,28535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28318,28355);

string 
singleValue = value as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28373,28520) || true) && (singleValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,28373,28520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28438,28458);

msv = new string[1];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28480,28501);

msv[0] = singleValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,28373,28520);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,28210,28535);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28551,29104) || true) && (msv == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,28551,29104);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28600,29089) || true) && (mandatory)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,28600,29089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28655,28821);

f_1231_28655_28820(                    s_mshsnapinTracer, "Cannot get string/multi-string value for mandatory property {0} in registry key {1}", name, f_1231_28802_28819(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,28843,28976);

throw f_1231_28849_28975("name", f_1231_28892_28949(), name, f_1231_28957_28974(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,28600,29089);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,28600,29089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,29058,29070);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,28600,29089);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,28551,29104);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,29120,29233);

f_1231_29120_29232(
            s_mshsnapinTracer, "Successfully read property {0} from {1}", name, f_1231_29214_29231(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,29247,29282);

return f_1231_29254_29281(msv);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,27336,29293);

object
f_1231_27485_27512(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 27485, 27512);
return return_v;
}


string
f_1231_27817_27834(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 27817, 27834);
return return_v;
}


int
f_1231_27696_27835(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 27696, 27835);
return 0;
}


string
f_1231_27907_27945()
{
var return_v = MshSnapinInfo.MandatoryValueNotPresent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 27907, 27945);
return return_v;
}


string
f_1231_27953_27970(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 27953, 27970);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_27864_27971(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 27864, 27971);
return return_v;
}


string
f_1231_28802_28819(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 28802, 28819);
return return_v;
}


int
f_1231_28655_28820(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 28655, 28820);
return 0;
}


string
f_1231_28892_28949()
{
var return_v = MshSnapinInfo.MandatoryValueNotInCorrectFormatMultiString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 28892, 28949);
return return_v;
}


string
f_1231_28957_28974(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 28957, 28974);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_28849_28975(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 28849, 28975);
return return_v;
}


string
f_1231_29214_29231(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 29214, 29231);
return return_v;
}


int
f_1231_29120_29232(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,string
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 29120, 29232);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1231_29254_29281(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 29254, 29281);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,27336,29293);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,27336,29293);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string ReadStringValue(RegistryKey mshsnapinKey, string name, bool mandatory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,29695,31025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,29813,29893);

f_1231_29813_29892(!f_1231_29825_29851(name), "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,29907,29980);

f_1231_29907_29979(mshsnapinKey != null, "Caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,29996,30039);

object 
value = f_1231_30011_30038(mshsnapinKey, name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30053,30412) || true) && (value == null &&(DynAbs.Tracing.TraceSender.Expression_True(1231, 30057, 30091)&&mandatory == true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,30053,30412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30125,30265);

f_1231_30125_30264(                s_mshsnapinTracer, "Mandatory property {0} not specified for registry key {1}", name, f_1231_30246_30263(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30283,30397);

throw f_1231_30289_30396("name", f_1231_30332_30370(), name, f_1231_30378_30395(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,30053,30412);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30428,30455);

string 
s = value as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30469,30845) || true) && (f_1231_30473_30496(s)&&(DynAbs.Tracing.TraceSender.Expression_True(1231, 30473, 30517)&&mandatory == true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,30469,30845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30551,30690);

f_1231_30551_30689(                s_mshsnapinTracer, "Value is null or empty for mandatory property {0} in {1}", name, f_1231_30671_30688(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30708,30830);

throw f_1231_30714_30829("name", f_1231_30757_30803(), name, f_1231_30811_30828(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,30469,30845);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,30861,30991);

f_1231_30861_30990(
            s_mshsnapinTracer, "Successfully read value {0} for property {1} from {2}", s, name, f_1231_30972_30989(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31005,31014);

return s;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,29695,31025);

bool
f_1231_29825_29851(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 29825, 29851);
return return_v;
}


int
f_1231_29813_29892(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 29813, 29892);
return 0;
}


int
f_1231_29907_29979(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 29907, 29979);
return 0;
}


object
f_1231_30011_30038(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 30011, 30038);
return return_v;
}


string
f_1231_30246_30263(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 30246, 30263);
return return_v;
}


int
f_1231_30125_30264(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 30125, 30264);
return 0;
}


string
f_1231_30332_30370()
{
var return_v = MshSnapinInfo.MandatoryValueNotPresent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 30332, 30370);
return return_v;
}


string
f_1231_30378_30395(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 30378, 30395);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_30289_30396(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 30289, 30396);
return return_v;
}


bool
f_1231_30473_30496(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 30473, 30496);
return return_v;
}


string
f_1231_30671_30688(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 30671, 30688);
return return_v;
}


int
f_1231_30551_30689(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 30551, 30689);
return 0;
}


string
f_1231_30757_30803()
{
var return_v = MshSnapinInfo.MandatoryValueNotInCorrectFormat;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 30757, 30803);
return return_v;
}


string
f_1231_30811_30828(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 30811, 30828);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_30714_30829(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 30714, 30829);
return return_v;
}


string
f_1231_30972_30989(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 30972, 30989);
return return_v;
}


int
f_1231_30861_30990(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,string
arg2,string
arg3)
{
this_param.WriteLine( format, (object)arg1, (object)arg2, (object)arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 30861, 30990);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,29695,31025);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,29695,31025);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Version ReadVersionValue(RegistryKey mshsnapinKey, string name, bool mandatory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,31037,33020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31157,31218);

string 
temp = f_1231_31171_31217(mshsnapinKey, name, mandatory)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31232,31574) || true) && (temp == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,31232,31574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31282,31421);

f_1231_31282_31420(                s_mshsnapinTracer, "Cannot read value for property {0} in registry key {1}", name, f_1231_31396_31419(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31439,31529);

f_1231_31439_31528(!mandatory, "mandatory is true, ReadStringValue should have thrown exception");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31547,31559);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,31232,31574);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31590,31600);

Version 
v
=default(Version);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31650,31672);

v = f_1231_31654_31671(temp);
            }
            catch (ArgumentOutOfRangeException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,31701,31994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31769,31850);

f_1231_31769_31849(                s_mshsnapinTracer, "Cannot convert value {0} to version format", temp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,31868,31979);

throw f_1231_31874_31978("name", f_1231_31917_31952(), name, f_1231_31960_31977(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,31701,31994);
            }
            catch (ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,32008,32291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,32066,32147);

f_1231_32066_32146(                s_mshsnapinTracer, "Cannot convert value {0} to version format", temp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,32165,32276);

throw f_1231_32171_32275("name", f_1231_32214_32249(), name, f_1231_32257_32274(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,32008,32291);
            }
            catch (OverflowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,32305,32588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,32363,32444);

f_1231_32363_32443(                s_mshsnapinTracer, "Cannot convert value {0} to version format", temp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,32462,32573);

throw f_1231_32468_32572("name", f_1231_32511_32546(), name, f_1231_32554_32571(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,32305,32588);
            }
            catch (FormatException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1231,32602,32883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,32658,32739);

f_1231_32658_32738(                s_mshsnapinTracer, "Cannot convert value {0} to version format", temp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,32757,32868);

throw f_1231_32763_32867("name", f_1231_32806_32841(), name, f_1231_32849_32866(mshsnapinKey));
DynAbs.Tracing.TraceSender.TraceExitCatch(1231,32602,32883);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,32899,32986);

f_1231_32899_32985(
            s_mshsnapinTracer, "Successfully converted string {0} to version format.", v);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,33000,33009);

return v;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,31037,33020);

string
f_1231_31171_31217(Microsoft.Win32.RegistryKey
mshsnapinKey,string
name,bool
mandatory)
{
var return_v = ReadStringValue( mshsnapinKey, name, mandatory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 31171, 31217);
return return_v;
}


string
f_1231_31396_31419(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 31396, 31419);
return return_v;
}


int
f_1231_31282_31420(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 31282, 31420);
return 0;
}


int
f_1231_31439_31528(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 31439, 31528);
return 0;
}


System.Version
f_1231_31654_31671(string
version)
{
var return_v = new System.Version( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 31654, 31671);
return return_v;
}


int
f_1231_31769_31849(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 31769, 31849);
return 0;
}


string
f_1231_31917_31952()
{
var return_v = MshSnapinInfo.VersionValueInCorrect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 31917, 31952);
return return_v;
}


string
f_1231_31960_31977(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 31960, 31977);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_31874_31978(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 31874, 31978);
return return_v;
}


int
f_1231_32066_32146(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 32066, 32146);
return 0;
}


string
f_1231_32214_32249()
{
var return_v = MshSnapinInfo.VersionValueInCorrect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 32214, 32249);
return return_v;
}


string
f_1231_32257_32274(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 32257, 32274);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_32171_32275(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 32171, 32275);
return return_v;
}


int
f_1231_32363_32443(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 32363, 32443);
return 0;
}


string
f_1231_32511_32546()
{
var return_v = MshSnapinInfo.VersionValueInCorrect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 32511, 32546);
return return_v;
}


string
f_1231_32554_32571(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 32554, 32571);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_32468_32572(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 32468, 32572);
return return_v;
}


int
f_1231_32658_32738(System.Management.Automation.PSTraceSource
this_param,string
errorMessageFormat,params object[]
args)
{
this_param.TraceError( errorMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 32658, 32738);
return 0;
}


string
f_1231_32806_32841()
{
var return_v = MshSnapinInfo.VersionValueInCorrect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 32806, 32841);
return return_v;
}


string
f_1231_32849_32866(Microsoft.Win32.RegistryKey
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 32849, 32866);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_32763_32867(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 32763, 32867);
return return_v;
}


int
f_1231_32899_32985(System.Management.Automation.PSTraceSource
this_param,string
format,System.Version
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 32899, 32985);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,31037,33020);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,31037,33020);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void ReadRegistryInfo(out Version assemblyVersion, out string publicKeyToken, out string culture, out string architecture, out string applicationBase, out Version psVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,33032,35330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,33246,33295);

applicationBase = f_1231_33264_33294();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,33309,33507);

f_1231_33309_33506(!f_1231_33339_33376(applicationBase), f_1231_33395_33505(f_1231_33409_33435(), "{0} is empty or null", RegistryStrings.MonadEngine_ApplicationBase));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,33587,33623);

psVersion = f_1231_33599_33622();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,33637,33802);

f_1231_33637_33801(psVersion != null, f_1231_33702_33800(f_1231_33716_33742(), "{0} is null", RegistryStrings.MonadEngine_MonadVersion));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34263,34322);

Assembly 
currentAssembly = f_1231_34290_34321(typeof(PSSnapInReader))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34336,34390);

AssemblyName 
assemblyName = f_1231_34364_34389(currentAssembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34404,34443);

assemblyVersion = f_1231_34422_34442(assemblyName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34457,34512);

byte[] 
publicTokens = f_1231_34479_34511(assemblyName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34526,34704) || true) && (f_1231_34530_34549(publicTokens)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,34526,34704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34588,34689);

throw f_1231_34594_34688("PublicKeyToken", f_1231_34647_34687());
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,34526,34704);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34720,34776);

publicKeyToken = f_1231_34737_34775(publicTokens);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,34940,34960);

culture = "neutral";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,35297,35319);

architecture = "MSIL";
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,33032,35330);

string
f_1231_33264_33294()
{
var return_v = Utils.DefaultPowerShellAppBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 33264, 33294);
return return_v;
}


bool
f_1231_33339_33376(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 33339, 33376);
return return_v;
}


System.Globalization.CultureInfo
f_1231_33409_33435()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 33409, 33435);
return return_v;
}


string
f_1231_33395_33505(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 33395, 33505);
return return_v;
}


int
f_1231_33309_33506(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 33309, 33506);
return 0;
}


System.Version
f_1231_33599_33622()
{
var return_v = PSVersionInfo.PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 33599, 33622);
return return_v;
}


System.Globalization.CultureInfo
f_1231_33716_33742()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 33716, 33742);
return return_v;
}


string
f_1231_33702_33800(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 33702, 33800);
return return_v;
}


int
f_1231_33637_33801(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 33637, 33801);
return 0;
}


System.Reflection.Assembly
f_1231_34290_34321(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 34290, 34321);
return return_v;
}


System.Reflection.AssemblyName
f_1231_34364_34389(System.Reflection.Assembly
this_param)
{
var return_v = this_param.GetName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 34364, 34389);
return return_v;
}


System.Version
f_1231_34422_34442(System.Reflection.AssemblyName
this_param)
{
var return_v = this_param.Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 34422, 34442);
return return_v;
}


byte[]?
f_1231_34479_34511(System.Reflection.AssemblyName
this_param)
{
var return_v = this_param.GetPublicKeyToken();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 34479, 34511);
return return_v;
}


int
f_1231_34530_34549(byte[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 34530, 34549);
return return_v;
}


string
f_1231_34647_34687()
{
var return_v = MshSnapinInfo.PublicKeyTokenAccessFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 34647, 34687);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_34594_34688(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 34594, 34688);
return return_v;
}


string
f_1231_34737_34775(byte[]
tokens)
{
var return_v = ConvertByteArrayToString( tokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 34737, 34775);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,33032,35330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,33032,35330);
}
		}

internal static string ConvertByteArrayToString(byte[] tokens)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,35577,36022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,35664,35728);

f_1231_35664_35727(tokens != null, "Input tokens should never be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,35742,35808);

StringBuilder 
tokenBuilder = f_1231_35771_35807(f_1231_35789_35802(tokens)* 2)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,35822,35964);
foreach(byte b in f_1231_35841_35847_I(tokens) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,35822,35964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,35881,35949);

f_1231_35881_35948(                tokenBuilder, f_1231_35901_35947(b, "x2", f_1231_35918_35946()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,35822,35964);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1231,1,143);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1231,1,143);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,35980,36011);

return f_1231_35987_36010(tokenBuilder);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,35577,36022);

int
f_1231_35664_35727(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 35664, 35727);
return 0;
}


int
f_1231_35789_35802(byte[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 35789, 35802);
return return_v;
}


System.Text.StringBuilder
f_1231_35771_35807(int
capacity)
{
var return_v = new System.Text.StringBuilder( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 35771, 35807);
return return_v;
}


System.Globalization.CultureInfo
f_1231_35918_35946()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 35918, 35946);
return return_v;
}


string
f_1231_35901_35947(byte
this_param,string
format,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( format, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 35901, 35947);
return return_v;
}


System.Text.StringBuilder
f_1231_35881_35948(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 35881, 35948);
return return_v;
}


byte[]
f_1231_35841_35847_I(byte[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 35841, 35847);
return return_v;
}


string
f_1231_35987_36010(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 35987, 36010);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,35577,36022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,35577,36022);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static PSSnapInInfo ReadCoreEngineSnapIn()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,36212,38481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36288,36323);

Version 
assemblyVersion
=default(Version),
psVersion
=default(Version);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36337,36366);

string 
publicKeyToken = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36380,36402);

string 
culture = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36416,36443);

string 
architecture = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36457,36487);

string 
applicationBase = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36503,36628);

f_1231_36503_36627(out assemblyVersion, out publicKeyToken, out culture, out architecture, out applicationBase, out psVersion);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36711,36812);

Collection<string> 
types = f_1231_36738_36811(new string[] { "types.ps1xml", "typesv3.ps1xml" })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,36826,37188);

Collection<string> 
formats = f_1231_36855_37187(new string[]
                        {"Certificate.format.ps1xml","DotNetTypes.format.ps1xml","FileSystem.format.ps1xml",
                         "Help.format.ps1xml","HelpV3.format.ps1xml","PowerShellCore.format.ps1xml","PowerShellTrace.format.ps1xml",
                         "Registry.format.ps1xml"})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,37204,37448);

string 
strongName = f_1231_37224_37447(f_1231_37238_37266(), "{0}, Version={1}, Culture={2}, PublicKeyToken={3}, ProcessorArchitecture={4}", s_coreSnapin.AssemblyName, assemblyVersion, culture, publicKeyToken, architecture)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,37464,37550);

string 
moduleName = f_1231_37484_37549(applicationBase, s_coreSnapin.AssemblyName + ".dll")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,37566,38141);

PSSnapInInfo 
coreMshSnapin = f_1231_37595_38140(s_coreSnapin.PSSnapInName, isDefault: true, applicationBase, strongName, moduleName, psVersion, assemblyVersion, types, formats, description: null, s_coreSnapin.Description, s_coreSnapin.DescriptionIndirect, vendor: null, vendorFallback: null, s_coreSnapin.VendorIndirect)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,38382,38425);

f_1231_38382_38424(coreMshSnapin);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,38449,38470);

return coreMshSnapin;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,36212,38481);

int
f_1231_36503_36627(out System.Version
assemblyVersion,out string
publicKeyToken,out string
culture,out string
architecture,out string
applicationBase,out System.Version
psVersion)
{
ReadRegistryInfo( out assemblyVersion, out publicKeyToken, out culture, out architecture, out applicationBase, out psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 36503, 36627);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1231_36738_36811(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 36738, 36811);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_36855_37187(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 36855, 37187);
return return_v;
}


System.Globalization.CultureInfo
f_1231_37238_37266()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 37238, 37266);
return return_v;
}


string
f_1231_37224_37447(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 37224, 37447);
return return_v;
}


string
f_1231_37484_37549(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 37484, 37549);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1231_37595_38140(string
name,bool
isDefault,string
applicationBase,string
assemblyName,string
moduleName,System.Version
psVersion,System.Version
version,System.Collections.ObjectModel.Collection<string>
types,System.Collections.ObjectModel.Collection<string>
formats,string
description,string
descriptionFallback,string
descriptionIndirect,string
vendor,string
vendorFallback,string
vendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInInfo( name, isDefault: isDefault, applicationBase, assemblyName, moduleName, psVersion, version, types, formats, description: description, descriptionFallback, descriptionIndirect, vendor: vendor, vendorFallback: vendorFallback, vendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 37595, 38140);
return return_v;
}


int
f_1231_38382_38424(System.Management.Automation.PSSnapInInfo
psSnapInInfo)
{
SetSnapInLoggingInformation( psSnapInInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 38382, 38424);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,36212,38481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,36212,38481);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Collection<PSSnapInInfo> ReadEnginePSSnapIns()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,38720,42544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,38807,38842);

Version 
assemblyVersion
=default(Version),
psVersion
=default(Version);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,38856,38885);

string 
publicKeyToken = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,38899,38921);

string 
culture = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,38935,38962);

string 
architecture = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,38976,39006);

string 
applicationBase = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39022,39147);

f_1231_39022_39146(out assemblyVersion, out publicKeyToken, out culture, out architecture, out applicationBase, out psVersion);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39230,39595);

Collection<string> 
smaFormats = f_1231_39262_39594(new string[]
                        {"Certificate.format.ps1xml","DotNetTypes.format.ps1xml","FileSystem.format.ps1xml",
                         "Help.format.ps1xml","HelpV3.format.ps1xml","PowerShellCore.format.ps1xml","PowerShellTrace.format.ps1xml",
                         "Registry.format.ps1xml"})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39609,39713);

Collection<string> 
smaTypes = f_1231_39639_39712(new string[] { "types.ps1xml", "typesv3.ps1xml" })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39784,39859);

Collection<PSSnapInInfo> 
engineMshSnapins = f_1231_39828_39858()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39873,39931);

string 
assemblyVersionString = f_1231_39904_39930(assemblyVersion)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39956,39964);

            for (int 
item = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39947,42493) || true) && (item < f_1231_39973_39996(f_1231_39973_39990()))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,39998,40004)
,item++,DynAbs.Tracing.TraceSender.TraceExitCondition(1231,39947,42493))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,39947,42493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40038,40112);

DefaultPSSnapInInformation 
defaultMshSnapinInfo = f_1231_40088_40111(f_1231_40088_40105(), item)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40132,40521);

string 
strongName = f_1231_40152_40520(f_1231_40188_40216(), "{0}, Version={1}, Culture={2}, PublicKeyToken={3}, ProcessorArchitecture={4}", defaultMshSnapinInfo.AssemblyName, assemblyVersionString, culture, publicKeyToken, architecture)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40541,40575);

Collection<string> 
formats = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40593,40625);

Collection<string> 
types = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40645,41551) || true) && (f_1231_40649_40757(defaultMshSnapinInfo.AssemblyName, "System.Management.Automation", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,40645,41551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40799,40820);

formats = smaFormats;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40842,40859);

types = smaTypes;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,40645,41551);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,40645,41551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,40901,41551) || true) && (f_1231_40905_41026(defaultMshSnapinInfo.AssemblyName, "Microsoft.PowerShell.Commands.Diagnostics", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,40901,41551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,41068,41141);

types = f_1231_41076_41140(new string[] { "GetEvent.types.ps1xml" });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,41163,41265);

formats = f_1231_41173_41264(new string[] { "Event.format.ps1xml", "Diagnostics.format.ps1xml" });
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,40901,41551);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,40901,41551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,41307,41551) || true) && (f_1231_41311_41417(defaultMshSnapinInfo.AssemblyName, "Microsoft.WSMan.Management", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,41307,41551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,41459,41532);

formats = f_1231_41469_41531(new string[] { "WSMan.format.ps1xml" });
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,41307,41551);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,40901,41551);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,40645,41551);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,41571,41665);

string 
moduleName = f_1231_41591_41664(applicationBase, defaultMshSnapinInfo.AssemblyName + ".dll")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,41685,42355);

PSSnapInInfo 
defaultMshSnapin = f_1231_41717_42354(defaultMshSnapinInfo.PSSnapInName, isDefault: true, applicationBase, strongName, moduleName, psVersion, assemblyVersion, types, formats, description: null, defaultMshSnapinInfo.Description, defaultMshSnapinInfo.DescriptionIndirect, vendor: null, vendorFallback: null, defaultMshSnapinInfo.VendorIndirect)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,42375,42421);

f_1231_42375_42420(defaultMshSnapin);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,42439,42478);

f_1231_42439_42477(                engineMshSnapins, defaultMshSnapin);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1231,1,2547);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1231,1,2547);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,42509,42533);

return engineMshSnapins;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,38720,42544);

int
f_1231_39022_39146(out System.Version
assemblyVersion,out string
publicKeyToken,out string
culture,out string
architecture,out string
applicationBase,out System.Version
psVersion)
{
ReadRegistryInfo( out assemblyVersion, out publicKeyToken, out culture, out architecture, out applicationBase, out psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 39022, 39146);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1231_39262_39594(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 39262, 39594);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_39639_39712(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 39639, 39712);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
f_1231_39828_39858()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 39828, 39858);
return return_v;
}


string
f_1231_39904_39930(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 39904, 39930);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation>
f_1231_39973_39990()
{
var return_v = DefaultMshSnapins;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 39973, 39990);
return return_v;
}


int
f_1231_39973_39996(System.Collections.Generic.IList<System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 39973, 39996);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation>
f_1231_40088_40105()
{
var return_v = DefaultMshSnapins;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 40088, 40105);
return return_v;
}


System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_40088_40111(System.Collections.Generic.IList<System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 40088, 40111);
return return_v;
}


System.Globalization.CultureInfo
f_1231_40188_40216()
{
var return_v =                     CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 40188, 40216);
return return_v;
}


string
f_1231_40152_40520(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 40152, 40520);
return return_v;
}


bool
f_1231_40649_40757(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 40649, 40757);
return return_v;
}


bool
f_1231_40905_41026(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 40905, 41026);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_41076_41140(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 41076, 41140);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_41173_41264(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 41173, 41264);
return return_v;
}


bool
f_1231_41311_41417(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 41311, 41417);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1231_41469_41531(string[]
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 41469, 41531);
return return_v;
}


string
f_1231_41591_41664(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 41591, 41664);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1231_41717_42354(string
name,bool
isDefault,string
applicationBase,string
assemblyName,string
moduleName,System.Version
psVersion,System.Version
version,System.Collections.ObjectModel.Collection<string>
types,System.Collections.ObjectModel.Collection<string>
formats,string
description,string
descriptionFallback,string
descriptionIndirect,string
vendor,string
vendorFallback,string
vendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInInfo( name, isDefault: isDefault, applicationBase, assemblyName, moduleName, psVersion, version, types, formats, description: description, descriptionFallback, descriptionIndirect, vendor: vendor, vendorFallback: vendorFallback, vendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 41717, 42354);
return return_v;
}


int
f_1231_42375_42420(System.Management.Automation.PSSnapInInfo
psSnapInInfo)
{
SetSnapInLoggingInformation( psSnapInInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 42375, 42420);
return 0;
}


int
f_1231_42439_42477(System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
this_param,System.Management.Automation.PSSnapInInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 42439, 42477);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,38720,42544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,38720,42544);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void SetSnapInLoggingInformation(PSSnapInInfo psSnapInInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,42661,43115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,42760,42786);

IEnumerable<string> 
names
=default(IEnumerable<string>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,42800,42913);

ModuleCmdletBase.ModuleLoggingGroupPolicyStatus 
status = f_1231_42857_42912(out names)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,42927,43104) || true) && (status != ModuleCmdletBase.ModuleLoggingGroupPolicyStatus.Undefined)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,42927,43104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,43032,43089);

f_1231_43032_43088(psSnapInInfo, status, names);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,42927,43104);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,42661,43115);

Microsoft.PowerShell.Commands.ModuleCmdletBase.ModuleLoggingGroupPolicyStatus
f_1231_42857_42912(out System.Collections.Generic.IEnumerable<string>
moduleNames)
{
var return_v = ModuleCmdletBase.GetModuleLoggingInformation( out moduleNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 42857, 42912);
return return_v;
}


int
f_1231_43032_43088(System.Management.Automation.PSSnapInInfo
psSnapInInfo,Microsoft.PowerShell.Commands.ModuleCmdletBase.ModuleLoggingGroupPolicyStatus
status,System.Collections.Generic.IEnumerable<string>
moduleOrSnapinNames)
{
SetSnapInLoggingInformation( psSnapInInfo, status, moduleOrSnapinNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 43032, 43088);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,42661,43115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,42661,43115);
}
		}

private static void SetSnapInLoggingInformation(PSSnapInInfo psSnapInInfo, ModuleCmdletBase.ModuleLoggingGroupPolicyStatus status, IEnumerable<string> moduleOrSnapinNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,43232,44422);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,43428,44411) || true) && (((status & ModuleCmdletBase.ModuleLoggingGroupPolicyStatus.Enabled) != 0) &&(DynAbs.Tracing.TraceSender.Expression_True(1231, 43432, 43536)&&moduleOrSnapinNames != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,43428,44411);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,43570,44396);
foreach(string currentGPModuleOrSnapinName in f_1231_43617_43636_I(moduleOrSnapinNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,43570,44396);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,43678,44377) || true) && (f_1231_43682_43779(f_1231_43696_43713(psSnapInInfo), currentGPModuleOrSnapinName, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,43678,44377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,43829,43877);

psSnapInInfo.LogPipelineExecutionDetails = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,43678,44377);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,43678,44377);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,43927,44377) || true) && (f_1231_43931_44002(currentGPModuleOrSnapinName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,43927,44377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,44052,44156);

WildcardPattern 
wildcard = f_1231_44079_44155(currentGPModuleOrSnapinName, WildcardOptions.IgnoreCase)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,44182,44354) || true) && (f_1231_44186_44221(wildcard, f_1231_44203_44220(psSnapInInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,44182,44354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,44279,44327);

psSnapInInfo.LogPipelineExecutionDetails = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,44182,44354);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,43927,44377);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,43678,44377);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,43570,44396);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1231,1,827);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1231,1,827);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1231,43428,44411);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,43232,44422);

string
f_1231_43696_43713(System.Management.Automation.PSSnapInInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 43696, 43713);
return return_v;
}


bool
f_1231_43682_43779(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 43682, 43779);
return return_v;
}


bool
f_1231_43931_44002(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 43931, 44002);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1231_44079_44155(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 44079, 44155);
return return_v;
}


string
f_1231_44203_44220(System.Management.Automation.PSSnapInInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 44203, 44220);
return return_v;
}


bool
f_1231_44186_44221(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 44186, 44221);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1231_43617_43636_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 43617, 43636);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,43232,44422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,43232,44422);
}
		}

internal static RegistryKey GetMonadRootKey()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,44843,45526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,44913,45002);

RegistryKey 
rootKey = f_1231_44935_45001(Registry.LocalMachine, RegistryStrings.MonadRootKeyPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,45016,45484) || true) && (rootKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,45016,45484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,45289,45356);

f_1231_45289_45355(false, "Root Key of Monad installation is not present");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,45374,45469);

throw f_1231_45380_45468("monad", f_1231_45424_45467());
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,45016,45484);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,45500,45515);

return rootKey;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,44843,45526);

Microsoft.Win32.RegistryKey
f_1231_44935_45001(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 44935, 45001);
return return_v;
}


int
f_1231_45289_45355(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 45289, 45355);
return 0;
}


string
f_1231_45424_45467()
{
var return_v = MshSnapinInfo.MonadRootRegistryAccessFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 45424, 45467);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_45380_45468(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 45380, 45468);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,44843,45526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,44843,45526);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static RegistryKey GetPSEngineKey(string psVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,45892,46979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,45977,46017);

RegistryKey 
rootKey = f_1231_45999_46016()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46069,46146);

f_1231_46069_46145(rootKey != null, "Root Key of Monad installation is not present");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46162,46229);

RegistryKey 
versionRootKey = f_1231_46191_46228(rootKey, psVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46289,46380);

f_1231_46289_46379(versionRootKey != null, "Version Rootkey of Monad installation is not present");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46396,46458);

RegistryKey 
psEngineParentKey = f_1231_46428_46457(rootKey, psVersion)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46472,46647) || true) && (psEngineParentKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,46472,46647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46535,46632);

throw f_1231_46541_46631("monad", f_1231_46585_46630());
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,46472,46647);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46663,46750);

RegistryKey 
psEngineKey = f_1231_46689_46749(psEngineParentKey, RegistryStrings.MonadEngineKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46764,46933) || true) && (psEngineKey == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,46764,46933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46821,46918);

throw f_1231_46827_46917("monad", f_1231_46871_46916());
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,46764,46933);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,46949,46968);

return psEngineKey;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,45892,46979);

Microsoft.Win32.RegistryKey
f_1231_45999_46016()
{
var return_v = GetMonadRootKey();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 45999, 46016);
return return_v;
}


int
f_1231_46069_46145(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 46069, 46145);
return 0;
}


Microsoft.Win32.RegistryKey
f_1231_46191_46228(Microsoft.Win32.RegistryKey
rootKey,string
psVersion)
{
var return_v = GetVersionRootKey( rootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 46191, 46228);
return return_v;
}


int
f_1231_46289_46379(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 46289, 46379);
return 0;
}


Microsoft.Win32.RegistryKey
f_1231_46428_46457(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 46428, 46457);
return return_v;
}


string
f_1231_46585_46630()
{
var return_v = MshSnapinInfo.MonadEngineRegistryAccessFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 46585, 46630);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_46541_46631(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 46541, 46631);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_46689_46749(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 46689, 46749);
return return_v;
}


string
f_1231_46871_46916()
{
var return_v = MshSnapinInfo.MonadEngineRegistryAccessFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 46871, 46916);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_46827_46917(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 46827, 46917);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,45892,46979);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,45892,46979);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static
        RegistryKey
        GetVersionRootKey(RegistryKey rootKey, string psVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,47501,48205);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,47628,47713);

f_1231_47628_47712(!f_1231_47640_47671(psVersion), "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,47727,47795);

f_1231_47727_47794(rootKey != null, "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,47811,47896);

string 
versionKey = f_1231_47831_47895(psVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,47910,47967);

RegistryKey 
versionRoot = f_1231_47936_47966(rootKey, versionKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,47981,48159) || true) && (versionRoot == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,47981,48159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,48038,48144);

throw f_1231_48044_48143("psVersion", f_1231_48092_48130(), versionKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,47981,48159);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,48175,48194);

return versionRoot;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,47501,48205);

bool
f_1231_47640_47671(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 47640, 47671);
return return_v;
}


int
f_1231_47628_47712(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 47628, 47712);
return 0;
}


int
f_1231_47727_47794(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 47727, 47794);
return 0;
}


string
f_1231_47831_47895(string
majorVersion)
{
var return_v = PSVersionInfo.GetRegistryVersionKeyForSnapinDiscovery( majorVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 47831, 47895);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_47936_47966(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 47936, 47966);
return return_v;
}


string
f_1231_48092_48130()
{
var return_v = MshSnapinInfo.SpecifiedVersionNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 48092, 48130);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_48044_48143(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 48044, 48143);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,47501,48205);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,47501,48205);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static
        RegistryKey
        GetMshSnapinRootKey(RegistryKey versionRootKey, string psVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,48728,49283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,48863,48938);

f_1231_48863_48937(versionRootKey != null, "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,48954,49038);

RegistryKey 
mshsnapinRoot = f_1231_48982_49037(versionRootKey, RegistryStrings.MshSnapinKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,49052,49235) || true) && (mshsnapinRoot == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,49052,49235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,49111,49220);

throw f_1231_49117_49219("psVersion", f_1231_49165_49207(), psVersion);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,49052,49235);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,49251,49272);

return mshsnapinRoot;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,48728,49283);

int
f_1231_48863_48937(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 48863, 48937);
return 0;
}


Microsoft.Win32.RegistryKey
f_1231_48982_49037(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 48982, 49037);
return return_v;
}


string
f_1231_49165_49207()
{
var return_v = MshSnapinInfo.NoMshSnapinPresentForVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 49165, 49207);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_49117_49219(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 49117, 49219);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,48728,49283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,48728,49283);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static
        RegistryKey
        GetMshSnapinKey(string mshSnapInName, string psVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,49819,50499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,49945,49990);

RegistryKey 
monadRootKey = f_1231_49972_49989()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,50004,50076);

RegistryKey 
versionRootKey = f_1231_50033_50075(monadRootKey, psVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,50090,50174);

RegistryKey 
mshsnapinRoot = f_1231_50118_50173(versionRootKey, RegistryStrings.MshSnapinKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,50188,50371) || true) && (mshsnapinRoot == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,50188,50371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,50247,50356);

throw f_1231_50253_50355("psVersion", f_1231_50301_50343(), psVersion);
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,50188,50371);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,50387,50454);

RegistryKey 
mshsnapinKey = f_1231_50414_50453(mshsnapinRoot, mshSnapInName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,50468,50488);

return mshsnapinKey;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,49819,50499);

Microsoft.Win32.RegistryKey
f_1231_49972_49989()
{
var return_v = GetMonadRootKey();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 49972, 49989);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_50033_50075(Microsoft.Win32.RegistryKey
rootKey,string
psVersion)
{
var return_v = GetVersionRootKey( rootKey, psVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 50033, 50075);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_50118_50173(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 50118, 50173);
return return_v;
}


string
f_1231_50301_50343()
{
var return_v = MshSnapinInfo.NoMshSnapinPresentForVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1231, 50301, 50343);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1231_50253_50355(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 50253, 50355);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1231_50414_50453(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 50414, 50453);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,49819,50499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,49819,50499);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private struct DefaultPSSnapInInformation
        {

public string PSSnapInName;

public string AssemblyName;

public string Description;

public string DescriptionIndirect;

public string VendorIndirect;

public DefaultPSSnapInInformation(string sName,
                string sAssemblyName,
                string sDescription,
                string sDescriptionIndirect,
                string sVendorIndirect)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1231,51104,51588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,51348,51369);

PSSnapInName = sName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,51387,51416);

AssemblyName = sAssemblyName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,51434,51461);

Description = sDescription;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,51479,51522);

DescriptionIndirect = sDescriptionIndirect;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,51540,51573);

VendorIndirect = sVendorIndirect;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1231,51104,51588);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,51104,51588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,51104,51588);
}
		}
static DefaultPSSnapInInformation(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1231,50740,51599);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1231,50740,51599);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,50740,51599);
}
        }

private static DefaultPSSnapInInformation s_coreSnapin ;

private static IList<DefaultPSSnapInInformation> DefaultMshSnapins
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1231,52044,54294);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,52080,54232) || true) && (s_defaultMshSnapins == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,52080,54232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,52159,52171);
                    lock (s_syncObject)
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,52221,54190) || true) && (s_defaultMshSnapins == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,52221,54190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,52310,53777);

s_defaultMshSnapins = new List<DefaultPSSnapInInformation>()
                            {
DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1231_52446_52661("Microsoft.PowerShell.Diagnostics", "Microsoft.PowerShell.Commands.Diagnostics", null, "GetEventResources,Description", "GetEventResources,Vendor"),1231,52332,53776),f_1231_52704_52912("Microsoft.PowerShell.Host", "Microsoft.PowerShell.ConsoleHost", null, "HostMshSnapInResources,Description", "HostMshSnapInResources,Vendor"),
                                s_coreSnapin,f_1231_52998_53220("Microsoft.PowerShell.Utility", "Microsoft.PowerShell.Commands.Utility", null, "UtilityMshSnapInResources,Description", "UtilityMshSnapInResources,Vendor"),f_1231_53257_53491("Microsoft.PowerShell.Management", "Microsoft.PowerShell.Commands.Management", null, "ManagementMshSnapInResources,Description", "ManagementMshSnapInResources,Vendor"),f_1231_53528_53745("Microsoft.PowerShell.Security", "Microsoft.PowerShell.Security", null, "SecurityMshSnapInResources,Description", "SecurityMshSnapInResources,Vendor")                            };

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,53820,54155) || true) && (!f_1231_53825_53844())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1231,53820,54155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,53910,54124);

f_1231_53910_54123(                                s_defaultMshSnapins, f_1231_53934_54122("Microsoft.WSMan.Management", "Microsoft.WSMan.Management", null, "WsManResources,Description", "WsManResources,Vendor"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,53820,54155);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,52221,54190);
}
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1231,52080,54232);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,54252,54279);

return s_defaultMshSnapins;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1231,52044,54294);

System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_52446_52661(string
sName,string
sAssemblyName,string
sDescription,string
sDescriptionIndirect,string
sVendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation( sName, sAssemblyName, sDescription, sDescriptionIndirect, sVendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 52446, 52661);
return return_v;
}


System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_52704_52912(string
sName,string
sAssemblyName,string
sDescription,string
sDescriptionIndirect,string
sVendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation( sName, sAssemblyName, sDescription, sDescriptionIndirect, sVendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 52704, 52912);
return return_v;
}


System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_52998_53220(string
sName,string
sAssemblyName,string
sDescription,string
sDescriptionIndirect,string
sVendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation( sName, sAssemblyName, sDescription, sDescriptionIndirect, sVendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 52998, 53220);
return return_v;
}


System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_53257_53491(string
sName,string
sAssemblyName,string
sDescription,string
sDescriptionIndirect,string
sVendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation( sName, sAssemblyName, sDescription, sDescriptionIndirect, sVendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 53257, 53491);
return return_v;
}


System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_53528_53745(string
sName,string
sAssemblyName,string
sDescription,string
sDescriptionIndirect,string
sVendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation( sName, sAssemblyName, sDescription, sDescriptionIndirect, sVendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 53528, 53745);
return return_v;
}


bool
f_1231_53825_53844()
{
var return_v = Utils.IsWinPEHost();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 53825, 53844);
return return_v;
}


System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_53934_54122(string
sName,string
sAssemblyName,string
sDescription,string
sDescriptionIndirect,string
sVendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation( sName, sAssemblyName, sDescription, sDescriptionIndirect, sVendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 53934, 54122);
return return_v;
}


int
f_1231_53910_54123(System.Collections.Generic.IList<System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation>
this_param,System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 53910, 54123);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1231,51953,54305);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,51953,54305);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static IList<DefaultPSSnapInInformation> s_defaultMshSnapins ;

private static object s_syncObject ;

private static PSTraceSource s_mshsnapinTracer ;

static PSSnapInReader()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1231,15387,54633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,51653,51893);
s_coreSnapin = f_1231_51681_51893("Microsoft.PowerShell.Core", "System.Management.Automation", null, "CoreMshSnapInResources,Description", "CoreMshSnapInResources,Vendor");DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,54366,54392);
s_defaultMshSnapins = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,54425,54452);
s_syncObject = f_1231_54440_54452();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1231,54516,54625);
s_mshsnapinTracer = f_1231_54536_54625("MshSnapinLoadUnload", "Loading and unloading mshsnapins", false);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1231,15387,54633);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1231,15387,54633);
}


static System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation
f_1231_51681_51893(string
sName,string
sAssemblyName,string
sDescription,string
sDescriptionIndirect,string
sVendorIndirect)
{
var return_v = new System.Management.Automation.PSSnapInReader.DefaultPSSnapInInformation( sName, sAssemblyName, sDescription, sDescriptionIndirect, sVendorIndirect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 51681, 51893);
return return_v;
}


static object
f_1231_54440_54452()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 54440, 54452);
return return_v;
}


static System.Management.Automation.PSTraceSource
f_1231_54536_54625(string
name,string
description,bool
traceHeaders)
{
var return_v = PSTraceSource.GetTracer( name, description, traceHeaders);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1231, 54536, 54625);
return return_v;
}

}
}

