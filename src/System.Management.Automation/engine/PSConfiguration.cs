// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation.Internal;
using System.Text;
using System.Threading;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace System.Management.Automation.Configuration
{
    /// <summary>
    /// The scope of the configuration file.
    /// </summary>
    public enum ConfigScope
    {
        /// <summary>
        /// AllUsers configuration applies to all users.
        /// </summary>
        AllUsers = 0,

        /// <summary>
        /// CurrentUser configuration applies to the current user.
        /// </summary>
        CurrentUser = 1
    }
internal sealed class PowerShellConfig
{
private const string 
ConfigFileName = "powershell.config.json"
;

private const string 
ExecutionPolicyDefaultShellKey = "Microsoft.PowerShell:ExecutionPolicy"
;

private const string 
DisableImplicitWinCompatKey = "DisableImplicitWinCompat"
;

private const string 
WindowsPowerShellCompatibilityModuleDenyListKey = "WindowsPowerShellCompatibilityModuleDenyList"
;

private const string 
WindowsPowerShellCompatibilityNoClobberModuleListKey = "WindowsPowerShellCompatibilityNoClobberModuleList"
;

internal static readonly PowerShellConfig Instance ;

private string systemWideConfigFile;

private string systemWideConfigDirectory;

private readonly string perUserConfigFile;

private readonly string perUserConfigDirectory;

private readonly JObject[] configRoots;

private readonly JObject emptyConfig;

private readonly JsonSerializer serializer;

private readonly ReaderWriterLockSlim fileLock;

private PowerShellConfig()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,4025,4972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2935,2955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2981,3006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,3117,3134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,3169,3191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,3499,3510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,3546,3557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,3600,3610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4004,4012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4133,4192);

systemWideConfigDirectory = f_1323_4161_4191();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4206,4285);

systemWideConfigFile = f_1323_4229_4284(systemWideConfigDirectory, ConfigFileName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4546,4596);

perUserConfigDirectory = Platform.ConfigDirectory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4610,4683);

perUserConfigFile = f_1323_4630_4682(perUserConfigDirectory, ConfigFileName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4699,4727);

emptyConfig = f_1323_4713_4726();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4741,4770);

configRoots = new JObject[2];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4784,4907);

serializer = f_1323_4797_4906(new JsonSerializerSettings { TypeNameHandling = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => TypeNameHandling.None,1323,4819,4905),MaxDepth = 10 });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,4923,4961);

fileLock = f_1323_4934_4960();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,4025,4972);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,4025,4972);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,4025,4972);
}
		}

private string GetConfigFilePath(ConfigScope scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,4984,5156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,5060,5145);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1323, 5067, 5101)||(((scope == ConfigScope.CurrentUser) &&DynAbs.Tracing.TraceSender.Conditional_F2(1323, 5104, 5121))||DynAbs.Tracing.TraceSender.Conditional_F3(1323, 5124, 5144)))?perUserConfigFile :systemWideConfigFile;
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,4984,5156);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,4984,5156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,4984,5156);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetSystemConfigFilePath(string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,5711,6110);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,5787,5930) || true) && (!f_1323_5792_5819(value)&&(DynAbs.Tracing.TraceSender.Expression_True(1323, 5791, 5842)&&!f_1323_5824_5842(value)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,5787,5930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,5876,5915);

throw f_1323_5882_5914(value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,5787,5930);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,5946,5982);

FileInfo 
info = f_1323_5962_5981(value)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,5996,6033);

systemWideConfigFile = f_1323_6019_6032(info);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,6047,6099);

systemWideConfigDirectory = f_1323_6075_6098(f_1323_6075_6089(info));
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,5711,6110);

bool
f_1323_5792_5819(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 5792, 5819);
return return_v;
}


bool
f_1323_5824_5842(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 5824, 5842);
return return_v;
}


System.IO.FileNotFoundException
f_1323_5882_5914(string
message)
{
var return_v = new System.IO.FileNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 5882, 5914);
return return_v;
}


System.IO.FileInfo
f_1323_5962_5981(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 5962, 5981);
return return_v;
}


string
f_1323_6019_6032(System.IO.FileInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 6019, 6032);
return return_v;
}


System.IO.DirectoryInfo
f_1323_6075_6089(System.IO.FileInfo
this_param)
{
var return_v = this_param.Directory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 6075, 6089);
return return_v;
}


string
f_1323_6075_6098(System.IO.DirectoryInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 6075, 6098);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,5711,6110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,5711,6110);
}
		}

internal string GetModulePath(ConfigScope scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,6638,7003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,6711,6794);

string 
modulePath = f_1323_6731_6793(this, scope, Constants.PSModulePathEnvVar)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,6808,6958) || true) && (!f_1323_6813_6845(modulePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,6808,6958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,6879,6943);

modulePath = f_1323_6892_6942(modulePath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,6808,6958);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,6974,6992);

return modulePath;
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,6638,7003);

string
f_1323_6731_6793(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<string>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 6731, 6793);
return return_v;
}


bool
f_1323_6813_6845(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 6813, 6845);
return return_v;
}


string
f_1323_6892_6942(string
name)
{
var return_v = Environment.ExpandEnvironmentVariables( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 6892, 6942);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,6638,7003);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,6638,7003);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetExecutionPolicy(ConfigScope scope, string shellId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,7855,8157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,7949,8000);

string 
key = f_1323_7962_7999(this, shellId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,8014,8072);

string 
execPolicy = f_1323_8034_8071(this, scope, key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,8086,8146);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1323, 8093, 8125)||((f_1323_8093_8125(execPolicy)&&DynAbs.Tracing.TraceSender.Conditional_F2(1323, 8128, 8132))||DynAbs.Tracing.TraceSender.Conditional_F3(1323, 8135, 8145)))?null :execPolicy;
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,7855,8157);

string
f_1323_7962_7999(System.Management.Automation.Configuration.PowerShellConfig
this_param,string
shellId)
{
var return_v = this_param.GetExecutionPolicySettingKey( shellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 7962, 7999);
return return_v;
}


string
f_1323_8034_8071(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<string>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8034, 8071);
return return_v;
}


bool
f_1323_8093_8125(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8093, 8125);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,7855,8157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,7855,8157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveExecutionPolicy(ConfigScope scope, string shellId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,8169,8380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,8264,8315);

string 
key = f_1323_8277_8314(this, shellId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,8329,8369);

f_1323_8329_8368(this, scope, key);
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,8169,8380);

string
f_1323_8277_8314(System.Management.Automation.Configuration.PowerShellConfig
this_param,string
shellId)
{
var return_v = this_param.GetExecutionPolicySettingKey( shellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8277, 8314);
return return_v;
}


int
f_1323_8329_8368(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
this_param.RemoveValueFromFile<string>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8329, 8368);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,8169,8380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,8169,8380);
}
		}

internal void SetExecutionPolicy(ConfigScope scope, string shellId, string executionPolicy)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,8392,8638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,8508,8559);

string 
key = f_1323_8521_8558(this, shellId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,8573,8627);

f_1323_8573_8626(this, scope, key, executionPolicy);
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,8392,8638);

string
f_1323_8521_8558(System.Management.Automation.Configuration.PowerShellConfig
this_param,string
shellId)
{
var return_v = this_param.GetExecutionPolicySettingKey( shellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8521, 8558);
return return_v;
}


int
f_1323_8573_8626(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,string
value)
{
this_param.WriteValueToFile<string>( scope, key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8573, 8626);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,8392,8638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,8392,8638);
}
		}

private string GetExecutionPolicySettingKey(string shellId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,8650,8949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,8734,8938);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1323, 8741, 8821)||((f_1323_8741_8821(shellId, Utils.DefaultPowerShellShellID, StringComparison.Ordinal)&&DynAbs.Tracing.TraceSender.Conditional_F2(1323, 8841, 8871))||DynAbs.Tracing.TraceSender.Conditional_F3(1323, 8891, 8937)))?ExecutionPolicyDefaultShellKey
:f_1323_8891_8937(shellId, ":", "ExecutionPolicy");
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,8650,8949);

bool
f_1323_8741_8821(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8741, 8821);
return return_v;
}


string
f_1323_8891_8937(string
str0,string
str1,string
str2)
{
var return_v = string.Concat( str0, str1, str2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 8891, 8937);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,8650,8949);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,8650,8949);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string[] GetExperimentalFeatures()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,9065,9473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,9133,9243);

string[] 
features = f_1323_9153_9242(this, ConfigScope.CurrentUser, "ExperimentalFeatures", f_1323_9220_9241())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,9259,9430) || true) && (f_1323_9263_9278(features)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,9259,9430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,9317,9415);

features = f_1323_9328_9414(this, ConfigScope.AllUsers, "ExperimentalFeatures", f_1323_9392_9413());
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,9259,9430);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,9446,9462);

return features;
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,9065,9473);

string[]
f_1323_9220_9241()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 9220, 9241);
return return_v;
}


string[]
f_1323_9153_9242(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,string[]
defaultValue)
{
var return_v = this_param.ReadValueFromFile<string[]>( scope, key, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 9153, 9242);
return return_v;
}


int
f_1323_9263_9278(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 9263, 9278);
return return_v;
}


string[]
f_1323_9392_9413()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 9392, 9413);
return return_v;
}


string[]
f_1323_9328_9414(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,string[]
defaultValue)
{
var return_v = this_param.ReadValueFromFile<string[]>( scope, key, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 9328, 9414);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,9065,9473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,9065,9473);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetExperimentalFeatures(ConfigScope scope, string featureName, bool setEnabled)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,9936,10638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10054,10113);

var 
features = f_1323_10069_10112(f_1323_10086_10111(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10127,10181);

bool 
containsFeature = f_1323_10150_10180(features, featureName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10195,10627) || true) && (setEnabled &&(DynAbs.Tracing.TraceSender.Expression_True(1323, 10199, 10229)&&!containsFeature))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,10195,10627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10263,10289);

f_1323_10263_10288(                features, featureName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10307,10385);

f_1323_10307_10384(this, scope, "ExperimentalFeatures", f_1323_10365_10383(features));
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,10195,10627);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,10195,10627);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10419,10627) || true) && (!setEnabled &&(DynAbs.Tracing.TraceSender.Expression_True(1323, 10423, 10453)&&containsFeature))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,10419,10627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10487,10516);

f_1323_10487_10515(                features, featureName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10534,10612);

f_1323_10534_10611(this, scope, "ExperimentalFeatures", f_1323_10592_10610(features));
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,10419,10627);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,10195,10627);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,9936,10638);

string[]
f_1323_10086_10111(System.Management.Automation.Configuration.PowerShellConfig
this_param)
{
var return_v = this_param.GetExperimentalFeatures();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10086, 10111);
return return_v;
}


System.Collections.Generic.List<string>
f_1323_10069_10112(string[]
collection)
{
var return_v = new System.Collections.Generic.List<string>( (System.Collections.Generic.IEnumerable<string>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10069, 10112);
return return_v;
}


bool
f_1323_10150_10180(System.Collections.Generic.List<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10150, 10180);
return return_v;
}


int
f_1323_10263_10288(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10263, 10288);
return 0;
}


string[]
f_1323_10365_10383(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10365, 10383);
return return_v;
}


int
f_1323_10307_10384(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,string[]
value)
{
this_param.WriteValueToFile<string[]>( scope, key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10307, 10384);
return 0;
}


bool
f_1323_10487_10515(System.Collections.Generic.List<string>
this_param,string
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10487, 10515);
return return_v;
}


string[]
f_1323_10592_10610(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10592, 10610);
return return_v;
}


int
f_1323_10534_10611(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,string[]
value)
{
this_param.WriteValueToFile<string[]>( scope, key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10534, 10611);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,9936,10638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,9936,10638);
}
		}

internal bool IsImplicitWinCompatEnabled()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,10650,11205);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10717,10817);

bool? 
settingValue = f_1323_10738_10816(this, ConfigScope.CurrentUser, DisableImplicitWinCompatKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,10831,11151) || true) && (f_1323_10835_10857_M(!settingValue.HasValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,10831,11151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,11024,11136);

settingValue = f_1323_11039_11135(this, ConfigScope.AllUsers, DisableImplicitWinCompatKey, defaultValue: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,10831,11151);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,11167,11194);

return f_1323_11174_11193_M(!settingValue.Value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,10650,11205);

bool?
f_1323_10738_10816(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<bool?>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 10738, 10816);
return return_v;
}


bool
f_1323_10835_10857_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 10835, 10857);
return return_v;
}


bool?
f_1323_11039_11135(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,bool
defaultValue)
{
var return_v = this_param.ReadValueFromFile<bool?>( scope, key, defaultValue: (bool?)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 11039, 11135);
return return_v;
}


bool
f_1323_11174_11193_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 11174, 11193);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,10650,11205);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,10650,11205);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string[] GetWindowsPowerShellCompatibilityModuleDenyList()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,11217,11835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,11309,11435);

string[] 
settingValue = f_1323_11333_11434(this, ConfigScope.CurrentUser, WindowsPowerShellCompatibilityModuleDenyListKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,11449,11788) || true) && (settingValue == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,11449,11788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,11659,11773);

settingValue = f_1323_11674_11772(this, ConfigScope.AllUsers, WindowsPowerShellCompatibilityModuleDenyListKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,11449,11788);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,11804,11824);

return settingValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,11217,11835);

string[]
f_1323_11333_11434(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<string[]>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 11333, 11434);
return return_v;
}


string[]
f_1323_11674_11772(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<string[]>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 11674, 11772);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,11217,11835);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,11217,11835);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string[] GetWindowsPowerShellCompatibilityNoClobberModuleList()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,11847,12485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,11944,12075);

string[] 
settingValue = f_1323_11968_12074(this, ConfigScope.CurrentUser, WindowsPowerShellCompatibilityNoClobberModuleListKey)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,12089,12438) || true) && (settingValue == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,12089,12438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,12304,12423);

settingValue = f_1323_12319_12422(this, ConfigScope.AllUsers, WindowsPowerShellCompatibilityNoClobberModuleListKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,12089,12438);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,12454,12474);

return settingValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,11847,12485);

string[]
f_1323_11968_12074(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<string[]>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 11968, 12074);
return return_v;
}


string[]
f_1323_12319_12422(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<string[]>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 12319, 12422);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,11847,12485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,11847,12485);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PowerShellPolicies GetPowerShellPolicies(ConfigScope scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,12612,12796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,12705,12785);

return f_1323_12712_12784(this, scope, nameof(PowerShellPolicies));
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,12612,12796);

System.Management.Automation.Configuration.PowerShellPolicies
f_1323_12712_12784(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key)
{
var return_v = this_param.ReadValueFromFile<System.Management.Automation.Configuration.PowerShellPolicies>( scope, key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 12712, 12784);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,12612,12796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,12612,12796);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private T ReadValueFromFile<T>(ConfigScope scope, string key, T defaultValue = default)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,17767,19472);
Newtonsoft.Json.Linq.JToken? jToken = default(Newtonsoft.Json.Linq.JToken?);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,17879,17922);

string 
fileName = f_1323_17897_17921(this, scope)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,17936,17981);

JObject 
configData = configRoots[(int)scope]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,17997,19191) || true) && (configData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,17997,19191);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18053,18877) || true) && (f_1323_18057_18078(fileName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,18053,18877);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18250,18275);

f_1323_18250_18274(                        // Open file for reading, but allow multiple readers
                        fileLock);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18303,18409);

using var 
stream = f_1323_18322_18408(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18435,18503);

using var 
jsonReader = f_1323_18458_18502(f_1323_18477_18501(stream))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18531,18603);

configData = f_1323_18544_18587(serializer, jsonReader)??(DynAbs.Tracing.TraceSender.Expression_Null<Newtonsoft.Json.Linq.JObject>(1323, 18544, 18602)??emptyConfig);
                    }
                    finally
                    {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1323,18648,18751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18704,18728);

f_1323_18704_18727(                        fileLock);
DynAbs.Tracing.TraceSender.TraceExitFinally(1323,18648,18751);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,18053,18877);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,18053,18877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18833,18858);

configData = emptyConfig;
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,18053,18877);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,18946,19045);

JObject 
originalValue = f_1323_18970_19044(ref configRoots[(int)scope], configData, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19063,19176) || true) && (originalValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,19063,19176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19130,19157);

configData = originalValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,19063,19176);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,17997,19191);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19207,19425) || true) && (configData != emptyConfig &&(DynAbs.Tracing.TraceSender.Expression_True(1323, 19211, 19322)&&f_1323_19240_19322(configData, key, StringComparison.OrdinalIgnoreCase, out jToken)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,19207,19425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19356,19410);

return f_1323_19363_19393(jToken, serializer)??(DynAbs.Tracing.TraceSender.Expression_Null<T>(1323, 19363, 19409)??defaultValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,19207,19425);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19441,19461);

return defaultValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,17767,19472);

string
f_1323_17897_17921(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope)
{
var return_v = this_param.GetConfigFilePath( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 17897, 17921);
return return_v;
}


bool
f_1323_18057_18078(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18057, 18078);
return return_v;
}


int
f_1323_18250_18274(System.Threading.ReaderWriterLockSlim
this_param)
{
this_param.EnterReadLock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18250, 18274);
return 0;
}


System.IO.FileStream
f_1323_18322_18408(string
fullPath,System.IO.FileMode
mode,System.IO.FileAccess
access,System.IO.FileShare
share)
{
var return_v = OpenFileStreamWithRetry( fullPath, mode, access, share);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18322, 18408);
return return_v;
}


System.IO.StreamReader
f_1323_18477_18501(System.IO.FileStream
stream)
{
var return_v = new System.IO.StreamReader( (System.IO.Stream)stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18477, 18501);
return return_v;
}


Newtonsoft.Json.JsonTextReader
f_1323_18458_18502(System.IO.StreamReader
reader)
{
var return_v = new Newtonsoft.Json.JsonTextReader( (System.IO.TextReader)reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18458, 18502);
return return_v;
}


Newtonsoft.Json.Linq.JObject
f_1323_18544_18587(Newtonsoft.Json.JsonSerializer
this_param,Newtonsoft.Json.JsonTextReader
reader)
{
var return_v = this_param.Deserialize<Newtonsoft.Json.Linq.JObject>( (Newtonsoft.Json.JsonReader)reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18544, 18587);
return return_v;
}


int
f_1323_18704_18727(System.Threading.ReaderWriterLockSlim
this_param)
{
this_param.ExitReadLock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18704, 18727);
return 0;
}


Newtonsoft.Json.Linq.JObject
f_1323_18970_19044(ref Newtonsoft.Json.Linq.JObject
location1,Newtonsoft.Json.Linq.JObject
value,Newtonsoft.Json.Linq.JObject
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, value, comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 18970, 19044);
return return_v;
}


bool
f_1323_19240_19322(Newtonsoft.Json.Linq.JObject
this_param,string
propertyName,System.StringComparison
comparison,out Newtonsoft.Json.Linq.JToken
value)
{
var return_v = this_param.TryGetValue( propertyName, comparison, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 19240, 19322);
return return_v;
}


T
f_1323_19363_19393(Newtonsoft.Json.Linq.JToken
this_param,Newtonsoft.Json.JsonSerializer
jsonSerializer)
{
var return_v = this_param.ToObject<T>( jsonSerializer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 19363, 19393);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,17767,19472);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,17767,19472);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static FileStream OpenFileStreamWithRetry(string fullPath, FileMode mode, FileAccess access, FileShare share)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1323,19484,20211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19626,19649);

const int 
MaxTries = 5
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19672,19684);
            for (int 
numTries = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19663,20129) || true) && (numTries < MaxTries)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19707,19717)
,numTries++,DynAbs.Tracing.TraceSender.TraceExitCondition(1323,19663,20129))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,19663,20129);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19795,19848);

return f_1323_19802_19847(fullPath, mode, access, share);
                }
                catch (IOException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1323,19885,20114);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,19945,20054) || true) && (numTries == (MaxTries - 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,19945,20054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,20025,20031);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,19945,20054);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,20078,20095);

f_1323_20078_20094(50);
DynAbs.Tracing.TraceSender.TraceExitCatch(1323,19885,20114);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1323,1,467);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1323,1,467);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,20145,20200);

throw f_1323_20151_20199(nameof(OpenFileStreamWithRetry));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1323,19484,20211);

System.IO.FileStream
f_1323_19802_19847(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access,System.IO.FileShare
share)
{
var return_v = new System.IO.FileStream( path, mode, access, share);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 19802, 19847);
return return_v;
}


int
f_1323_20078_20094(int
millisecondsTimeout)
{
Thread.Sleep( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 20078, 20094);
return 0;
}


System.IO.IOException
f_1323_20151_20199(string
message)
{
var return_v = new System.IO.IOException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 20151, 20199);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,19484,20211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,19484,20211);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void UpdateValueInFile<T>(ConfigScope scope, string key, T value, bool addValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,20729,25495);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,20878,20921);

string 
fileName = f_1323_20896_20920(this, scope)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,20939,20965);

f_1323_20939_20964(                fileLock);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,21377,21403);

JObject 
jsonObject = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,21421,21538);

using FileStream 
fs = f_1323_21443_21537(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,21878,24242);
using(StreamReader 
streamRdr = f_1323_21910_22020(fs, f_1323_21931_21944(), detectEncodingFromByteOrderMarks: true, bufferSize: 1024, leaveOpen: true)
){DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22039,24242);
using(JsonTextReader 
jsonReader = f_1323_22074_22103(streamRdr)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22234,22273);

bool 
isReadSuccess = f_1323_22255_22272(jsonReader)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22295,24223) || true) && (isReadSuccess)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,22295,24223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22443,22500);

jsonObject = f_1323_22456_22499(serializer, jsonReader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22526,22580);

JProperty 
propertyToModify = f_1323_22555_22579(jsonObject, key)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22608,23519) || true) && (propertyToModify == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,22608,23519);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22764,22915) || true) && (addValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,22764,22915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,22842,22884);

f_1323_22842_22883(                                jsonObject, f_1323_22857_22882(key, value));
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,22764,22915);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,22608,23519);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,22608,23519);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,23175,23492) || true) && (addValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,23175,23492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,23253,23305);

f_1323_23253_23304(                                propertyToModify, f_1323_23278_23303(key, value));
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,23175,23492);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,23175,23492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,23435,23461);

f_1323_23435_23460(                                propertyToModify);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,23175,23492);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,22608,23519);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,22295,24223);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,22295,24223);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,23930,24200) || true) && (addValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,23930,24200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,24000,24052);

jsonObject = f_1323_24013_24051(f_1323_24025_24050(key, value));
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,23930,24200);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,23930,24200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,24166,24173);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,23930,24200);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,22295,24223);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1323,22039,24242);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1323,21878,24242);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,24400,24429);

f_1323_24400_24428(
                // Reset the stream position to the beginning so that the
                // changes to the file can be written to disk
                fs, 0, SeekOrigin.Begin);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,24502,25240);
using(StreamWriter 
streamWriter = f_1323_24537_24557(fs)
){DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,24576,25240);
using(JsonTextWriter 
jsonWriter = f_1323_24611_24643(streamWriter)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,24843,24874);

f_1323_24843_24873(                    // The entire document exists within the root JObject.
                    // I just need to write that object to produce the document.
                    jsonObject, jsonWriter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,25195,25221);

f_1323_25195_25220(
                    // This trims the file if the file shrank. If the file grew,
                    // it is a no-op. The purpose is to trim extraneous characters
                    // from the file stream when the resultant JObject is smaller
                    // than the input JObject.
                    fs, f_1323_25208_25219(fs));
DynAbs.Tracing.TraceSender.TraceExitUsing(1323,24576,25240);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1323,24502,25240);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,25313,25375);

f_1323_25313_25374(ref configRoots[(int)scope], jsonObject);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1323,25404,25484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,25444,25469);

f_1323_25444_25468(                fileLock);
DynAbs.Tracing.TraceSender.TraceExitFinally(1323,25404,25484);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,20729,25495);

string
f_1323_20896_20920(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope)
{
var return_v = this_param.GetConfigFilePath( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 20896, 20920);
return return_v;
}


int
f_1323_20939_20964(System.Threading.ReaderWriterLockSlim
this_param)
{
this_param.EnterWriteLock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 20939, 20964);
return 0;
}


System.IO.FileStream
f_1323_21443_21537(string
fullPath,System.IO.FileMode
mode,System.IO.FileAccess
access,System.IO.FileShare
share)
{
var return_v = OpenFileStreamWithRetry( fullPath, mode, access, share);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 21443, 21537);
return return_v;
}


System.Text.Encoding
f_1323_21931_21944()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 21931, 21944);
return return_v;
}


System.IO.StreamReader
f_1323_21910_22020(System.IO.FileStream
stream,System.Text.Encoding
encoding,bool
detectEncodingFromByteOrderMarks,int
bufferSize,bool
leaveOpen)
{
var return_v = new System.IO.StreamReader( (System.IO.Stream)stream, encoding, detectEncodingFromByteOrderMarks: detectEncodingFromByteOrderMarks, bufferSize: bufferSize, leaveOpen: leaveOpen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 21910, 22020);
return return_v;
}


Newtonsoft.Json.JsonTextReader
f_1323_22074_22103(System.IO.StreamReader
reader)
{
var return_v = new Newtonsoft.Json.JsonTextReader( (System.IO.TextReader)reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 22074, 22103);
return return_v;
}


bool
f_1323_22255_22272(Newtonsoft.Json.JsonTextReader
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 22255, 22272);
return return_v;
}


Newtonsoft.Json.Linq.JObject
f_1323_22456_22499(Newtonsoft.Json.JsonSerializer
this_param,Newtonsoft.Json.JsonTextReader
reader)
{
var return_v = this_param.Deserialize<Newtonsoft.Json.Linq.JObject>( (Newtonsoft.Json.JsonReader)reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 22456, 22499);
return return_v;
}


Newtonsoft.Json.Linq.JProperty?
f_1323_22555_22579(Newtonsoft.Json.Linq.JObject
this_param,string
name)
{
var return_v = this_param.Property( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 22555, 22579);
return return_v;
}


Newtonsoft.Json.Linq.JProperty
f_1323_22857_22882(string
name,T
content)
{
var return_v = new Newtonsoft.Json.Linq.JProperty( name, (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 22857, 22882);
return return_v;
}


int
f_1323_22842_22883(Newtonsoft.Json.Linq.JObject
this_param,Newtonsoft.Json.Linq.JProperty
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 22842, 22883);
return 0;
}


Newtonsoft.Json.Linq.JProperty
f_1323_23278_23303(string
name,T
content)
{
var return_v = new Newtonsoft.Json.Linq.JProperty( name, (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 23278, 23303);
return return_v;
}


int
f_1323_23253_23304(Newtonsoft.Json.Linq.JProperty
this_param,Newtonsoft.Json.Linq.JProperty
value)
{
this_param.Replace( (Newtonsoft.Json.Linq.JToken)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 23253, 23304);
return 0;
}


int
f_1323_23435_23460(Newtonsoft.Json.Linq.JProperty
this_param)
{
this_param.Remove();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 23435, 23460);
return 0;
}


Newtonsoft.Json.Linq.JProperty
f_1323_24025_24050(string
name,T
content)
{
var return_v = new Newtonsoft.Json.Linq.JProperty( name, (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 24025, 24050);
return return_v;
}


Newtonsoft.Json.Linq.JObject
f_1323_24013_24051(Newtonsoft.Json.Linq.JProperty
content)
{
var return_v = new Newtonsoft.Json.Linq.JObject( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 24013, 24051);
return return_v;
}


long
f_1323_24400_24428(System.IO.FileStream
this_param,int
offset,System.IO.SeekOrigin
origin)
{
var return_v = this_param.Seek( (long)offset, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 24400, 24428);
return return_v;
}


System.IO.StreamWriter
f_1323_24537_24557(System.IO.FileStream
stream)
{
var return_v = new System.IO.StreamWriter( (System.IO.Stream)stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 24537, 24557);
return return_v;
}


Newtonsoft.Json.JsonTextWriter
f_1323_24611_24643(System.IO.StreamWriter
textWriter)
{
var return_v = new Newtonsoft.Json.JsonTextWriter( (System.IO.TextWriter)textWriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 24611, 24643);
return return_v;
}


int
f_1323_24843_24873(Newtonsoft.Json.Linq.JObject
this_param,Newtonsoft.Json.JsonTextWriter
writer,params Newtonsoft.Json.JsonConverter[]
converters)
{
this_param.WriteTo( (Newtonsoft.Json.JsonWriter)writer, converters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 24843, 24873);
return 0;
}


long
f_1323_25208_25219(System.IO.FileStream
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 25208, 25219);
return return_v;
}


int
f_1323_25195_25220(System.IO.FileStream
this_param,long
value)
{
this_param.SetLength( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 25195, 25220);
return 0;
}


Newtonsoft.Json.Linq.JObject
f_1323_25313_25374(ref Newtonsoft.Json.Linq.JObject
location1,Newtonsoft.Json.Linq.JObject
value)
{
var return_v = Interlocked.Exchange( ref location1, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 25313, 25374);
return return_v;
}


int
f_1323_25444_25468(System.Threading.ReaderWriterLockSlim
this_param)
{
this_param.ExitWriteLock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 25444, 25468);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,20729,25495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,20729,25495);
}
		}

private void WriteValueToFile<T>(ConfigScope scope, string key, T value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,25899,26249);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,25996,26176) || true) && (ConfigScope.CurrentUser == scope &&(DynAbs.Tracing.TraceSender.Expression_True(1323, 26000, 26077)&&!f_1323_26037_26077(perUserConfigDirectory)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,25996,26176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,26111,26161);

f_1323_26111_26160(perUserConfigDirectory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,25996,26176);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,26192,26238);

f_1323_26192_26237(this, scope, key, value, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,25899,26249);

bool
f_1323_26037_26077(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 26037, 26077);
return return_v;
}


System.IO.DirectoryInfo
f_1323_26111_26160(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 26111, 26160);
return return_v;
}


int
f_1323_26192_26237(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,T
value,bool
addValue)
{
this_param.UpdateValueInFile<T>( scope, key, value, addValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 26192, 26237);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,25899,26249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,25899,26249);
}
		}

private void RemoveValueFromFile<T>(ConfigScope scope, string key)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1323,26593,26962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,26684,26727);

string 
fileName = f_1323_26702_26726(this, scope)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,26825,26951) || true) && (f_1323_26829_26850(fileName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1323,26825,26951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,26884,26936);

f_1323_26884_26935(this, scope, key, default(T), false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1323,26825,26951);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1323,26593,26962);

string
f_1323_26702_26726(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope)
{
var return_v = this_param.GetConfigFilePath( scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 26702, 26726);
return return_v;
}


bool
f_1323_26829_26850(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 26829, 26850);
return return_v;
}


int
f_1323_26884_26935(System.Management.Automation.Configuration.PowerShellConfig
this_param,System.Management.Automation.Configuration.ConfigScope
scope,string
key,T
value,bool
addValue)
{
this_param.UpdateValueInFile<T>( scope, key, value, addValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 26884, 26935);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1323,26593,26962);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,26593,26962);
}
		}

static PowerShellConfig()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,2039,26969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2115,2156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2188,2259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2291,2347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2379,2475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2507,2613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,2700,2733);
Instance = f_1323_2711_2733();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,2039,26969);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,2039,26969);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,2039,26969);

static System.Management.Automation.Configuration.PowerShellConfig
f_1323_2711_2733()
{
var return_v = new System.Management.Automation.Configuration.PowerShellConfig();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 2711, 2733);
return return_v;
}


string
f_1323_4161_4191()
{
var return_v = Utils.DefaultPowerShellAppBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1323, 4161, 4191);
return return_v;
}


string
f_1323_4229_4284(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 4229, 4284);
return return_v;
}


string
f_1323_4630_4682(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 4630, 4682);
return return_v;
}


Newtonsoft.Json.Linq.JObject
f_1323_4713_4726()
{
var return_v = new Newtonsoft.Json.Linq.JObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 4713, 4726);
return return_v;
}


Newtonsoft.Json.JsonSerializer
f_1323_4797_4906(Newtonsoft.Json.JsonSerializerSettings
settings)
{
var return_v = JsonSerializer.Create( settings);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 4797, 4906);
return return_v;
}


System.Threading.ReaderWriterLockSlim
f_1323_4934_4960()
{
var return_v = new System.Threading.ReaderWriterLockSlim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1323, 4934, 4960);
return return_v;
}

}
internal sealed class PowerShellPolicies
{
public ScriptExecution ScriptExecution {get; set; }

public ScriptBlockLogging ScriptBlockLogging {get; set; }

public ModuleLogging ModuleLogging {get; set; }

public ProtectedEventLogging ProtectedEventLogging {get; set; }

public Transcription Transcription {get; set; }

public UpdatableHelp UpdatableHelp {get; set; }

public ConsoleSessionConfiguration ConsoleSessionConfiguration {get; set; }

public PowerShellPolicies()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,29170,29688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29227,29279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29289,29347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29357,29405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29415,29479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29489,29537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29547,29595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29605,29681);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,29170,29688);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,29170,29688);
}


static PowerShellPolicies()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,29170,29688);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,29170,29688);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,29170,29688);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,29170,29688);
}
internal abstract class PolicyBase {
public PolicyBase()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,29696,29734);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,29696,29734);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,29696,29734);
}


static PolicyBase()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,29696,29734);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,29696,29734);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,29696,29734);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,29696,29734);
}
internal sealed class ScriptExecution : PolicyBase
{
public string ExecutionPolicy {get; set; }

public bool? EnableScripts {get; set; }

public ScriptExecution()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,29821,29988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29888,29931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,29941,29981);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,29821,29988);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,29821,29988);
}


static ScriptExecution()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,29821,29988);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,29821,29988);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,29821,29988);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,29821,29988);
}
internal sealed class ScriptBlockLogging : PolicyBase
{
public bool? EnableScriptBlockInvocationLogging {get; set; }

public bool? EnableScriptBlockLogging {get; set; }

public ScriptBlockLogging()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,30078,30277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30148,30209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30219,30270);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,30078,30277);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30078,30277);
}


static ScriptBlockLogging()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,30078,30277);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,30078,30277);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30078,30277);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,30078,30277);
}
internal sealed class ModuleLogging : PolicyBase
{
public bool? EnableModuleLogging {get; set; }

public string[] ModuleNames {get; set; }

public ModuleLogging()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,30362,30531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30427,30473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30483,30524);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,30362,30531);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30362,30531);
}


static ModuleLogging()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,30362,30531);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,30362,30531);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30362,30531);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,30362,30531);
}
internal sealed class Transcription : PolicyBase
{
public bool? EnableTranscripting {get; set; }

public bool? EnableInvocationHeader {get; set; }

public string OutputDirectory {get; set; }

public Transcription()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,30616,30846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30681,30727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30737,30786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30796,30839);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,30616,30846);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30616,30846);
}


static Transcription()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,30616,30846);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,30616,30846);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30616,30846);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,30616,30846);
}
internal sealed class UpdatableHelp : PolicyBase
{
public bool? EnableUpdateHelpDefaultSourcePath {get; set; }

public string DefaultSourcePath {get; set; }

public UpdatableHelp()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,30931,31118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,30996,31056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,31066,31111);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,30931,31118);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30931,31118);
}


static UpdatableHelp()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,30931,31118);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,30931,31118);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,30931,31118);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,30931,31118);
}
internal sealed class ConsoleSessionConfiguration : PolicyBase
{
public bool? EnableConsoleSessionConfiguration {get; set; }

public string ConsoleSessionConfigurationName {get; set; }

public ConsoleSessionConfiguration()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,31217,31432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,31296,31356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,31366,31425);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,31217,31432);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,31217,31432);
}


static ConsoleSessionConfiguration()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,31217,31432);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,31217,31432);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,31217,31432);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,31217,31432);
}
internal sealed class ProtectedEventLogging : PolicyBase
{
public bool? EnableProtectedEventLogging {get; set; }

public string[] EncryptionCertificate {get; set; }

public ProtectedEventLogging()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1323,31525,31720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,31598,31652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1323,31662,31713);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1323,31525,31720);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,31525,31720);
}


static ProtectedEventLogging()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1323,31525,31720);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1323,31525,31720);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1323,31525,31720);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1323,31525,31720);
}

    }
