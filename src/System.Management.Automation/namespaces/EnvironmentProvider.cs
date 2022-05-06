// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
[CmdletProvider(EnvironmentProvider.ProviderName, ProviderCapabilities.ShouldProcess)]
    public sealed class EnvironmentProvider : SessionStateProviderBase
{
public const string 
ProviderName = "Environment"
;

public EnvironmentProvider()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1191,1140,1190);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1191,1140,1190);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1191,1140,1190);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,1140,1190);
}
		}

protected override Collection<PSDriveInfo> InitializeDefaultDrives()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1191,1504,2073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,1597,1666);

string 
description = f_1191_1618_1665()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,1682,1920);

PSDriveInfo 
envDrive =
f_1191_1722_1919(DriveNames.EnvironmentDrive, f_1191_1810_1822(), string.Empty, description, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,1936,1999);

Collection<PSDriveInfo> 
drives = f_1191_1969_1998()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2013,2034);

f_1191_2013_2033(            drives, envDrive);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2048,2062);

return drives;
DynAbs.Tracing.TraceSender.TraceExitMethod(1191,1504,2073);

string
f_1191_1618_1665()
{
var return_v = SessionStateStrings.EnvironmentDriveDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1191, 1618, 1665);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1191_1810_1822()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1191, 1810, 1822);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1191_1722_1919(string
name,System.Management.Automation.ProviderInfo
provider,string
root,string
description,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.PSDriveInfo( name, provider, root, description, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 1722, 1919);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
f_1191_1969_1998()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 1969, 1998);
return return_v;
}


int
f_1191_2013_2033(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
this_param,System.Management.Automation.PSDriveInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 2013, 2033);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1191,1504,2073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,1504,2073);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override object GetSessionStateItem(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1191,2533,3019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2615,2745);

f_1191_2615_2744(!f_1191_2657_2683(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2761,2782);

object 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2798,2854);

string 
value = f_1191_2813_2853(name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2870,2978) || true) && (value != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,2870,2978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2921,2963);

result = f_1191_2930_2962(name, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,2870,2978);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,2994,3008);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1191,2533,3019);

bool
f_1191_2657_2683(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 2657, 2683);
return return_v;
}


int
f_1191_2615_2744(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 2615, 2744);
return 0;
}


string?
f_1191_2813_2853(string
variable)
{
var return_v = Environment.GetEnvironmentVariable( variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 2813, 2853);
return return_v;
}


System.Collections.DictionaryEntry
f_1191_2930_2962(string
key,string
value)
{
var return_v = new System.Collections.DictionaryEntry( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 2930, 2962);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1191,2533,3019);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,2533,3019);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override void SetSessionStateItem(string name, object value, bool writeItem)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1191,3535,4922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,3645,3775);

f_1191_3645_3774(!f_1191_3687_3713(name), "The caller should verify this parameter");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,3791,4911) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,3791,4911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,3842,3889);

f_1191_3842_3888(name, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,3791,4911);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,3791,4911);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4147,4275) || true) && (value is DictionaryEntry)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,4147,4275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4217,4256);

value = ((DictionaryEntry)value).Value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,4147,4275);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4295,4332);

string 
stringValue = value as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4350,4611) || true) && (stringValue == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,4350,4611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4479,4531);

PSObject 
wrappedObject = f_1191_4504_4530(value)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4553,4592);

stringValue = f_1191_4567_4591(wrappedObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,4350,4611);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4631,4685);

f_1191_4631_4684(name, stringValue);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4705,4767);

DictionaryEntry 
item = f_1191_4728_4766(name, stringValue)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4787,4896) || true) && (writeItem)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,4787,4896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,4842,4877);

f_1191_4842_4876(this, item, name, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,4787,4896);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,3791,4911);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1191,3535,4922);

bool
f_1191_3687_3713(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 3687, 3713);
return return_v;
}


int
f_1191_3645_3774(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 3645, 3774);
return 0;
}


int
f_1191_3842_3888(string
variable,string?
value)
{
Environment.SetEnvironmentVariable( variable, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 3842, 3888);
return 0;
}


System.Management.Automation.PSObject
f_1191_4504_4530(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 4504, 4530);
return return_v;
}


string
f_1191_4567_4591(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 4567, 4591);
return return_v;
}


int
f_1191_4631_4684(string
variable,string
value)
{
Environment.SetEnvironmentVariable( variable, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 4631, 4684);
return 0;
}


System.Collections.DictionaryEntry
f_1191_4728_4766(string
key,string
value)
{
var return_v = new System.Collections.DictionaryEntry( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 4728, 4766);
return return_v;
}


int
f_1191_4842_4876(Microsoft.PowerShell.Commands.EnvironmentProvider
this_param,System.Collections.DictionaryEntry
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( (object)item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 4842, 4876);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1191,3535,4922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,3535,4922);
}
		}

internal override void RemoveSessionStateItem(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1191,5192,5479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,5275,5405);

f_1191_5275_5404(!f_1191_5317_5343(name), "The caller should verify this parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,5421,5468);

f_1191_5421_5467(name, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1191,5192,5479);

bool
f_1191_5317_5343(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 5317, 5343);
return return_v;
}


int
f_1191_5275_5404(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 5275, 5404);
return 0;
}


int
f_1191_5421_5467(string
variable,string?
value)
{
Environment.SetEnvironmentVariable( variable, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 5421, 5467);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1191,5192,5479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,5192,5479);
}
		}

internal override IDictionary GetSessionStateTable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1191,5787,8935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,6141,6284);

Dictionary<string, DictionaryEntry> 
providerTable =
f_1191_6210_6283(f_1191_6250_6282())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,6605,6674);

IDictionary 
environmentTable = f_1191_6636_6673()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,6688,8887);
foreach(DictionaryEntry entry in f_1191_6722_6738_I(environmentTable) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,6688,8887);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,6772,8872) || true) && (!f_1191_6777_6823(providerTable, entry.Key, entry))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,6772,8872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,7971,8049);

string 
effectiveValue = f_1191_7995_8048(entry.Key)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,8071,8853) || true) && (f_1191_8075_8145(((string)entry.Value), effectiveValue, StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,8071,8853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,8720,8760);

f_1191_8720_8759(                        // Note: We *recreate* the entry so that the specific name casing of the
                        //       effective definition is also reflected. However, if the case variants
                        //       define the same value, it is unspecified which name variant is reflected
                        //       in Get-Item env: output; given the always case-insensitive nature of the retrieval,
                        //       that shouldn't matter.
                        providerTable, entry.Key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,8786,8830);

f_1191_8786_8829(                        providerTable, entry.Key, entry);
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,8071,8853);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,6772,8872);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,6688,8887);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1191,1,2200);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1191,1,2200);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,8903,8924);

return providerTable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1191,5787,8935);

System.StringComparer
f_1191_6250_6282()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1191, 6250, 6282);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Collections.DictionaryEntry>
f_1191_6210_6283(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.DictionaryEntry>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 6210, 6283);
return return_v;
}


System.Collections.IDictionary
f_1191_6636_6673()
{
var return_v = Environment.GetEnvironmentVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 6636, 6673);
return return_v;
}


bool
f_1191_6777_6823(System.Collections.Generic.Dictionary<string, System.Collections.DictionaryEntry>
this_param,object
key,System.Collections.DictionaryEntry
value)
{
var return_v = this_param.TryAdd( (string)key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 6777, 6823);
return return_v;
}


string?
f_1191_7995_8048(object
variable)
{
var return_v = Environment.GetEnvironmentVariable( (string)variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 7995, 8048);
return return_v;
}


bool
f_1191_8075_8145(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 8075, 8145);
return return_v;
}


bool
f_1191_8720_8759(System.Collections.Generic.Dictionary<string, System.Collections.DictionaryEntry>
this_param,object
key)
{
var return_v = this_param.Remove( (string)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 8720, 8759);
return return_v;
}


int
f_1191_8786_8829(System.Collections.Generic.Dictionary<string, System.Collections.DictionaryEntry>
this_param,object
key,System.Collections.DictionaryEntry
value)
{
this_param.Add( (string)key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 8786, 8829);
return 0;
}


System.Collections.IDictionary
f_1191_6722_6738_I(System.Collections.IDictionary
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 6722, 6738);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1191,5787,8935);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,5787,8935);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override object GetValueOfItem(object item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1191,9243,9641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,9320,9435);

f_1191_9320_9434(item != null, "Caller should verify the item parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,9451,9471);

object 
value = item
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,9487,9601) || true) && (item is DictionaryEntry)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1191,9487,9601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,9548,9586);

value = ((DictionaryEntry)item).Value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1191,9487,9601);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,9617,9630);

return value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1191,9243,9641);

int
f_1191_9320_9434(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1191, 9320, 9434);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1191,9243,9641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,9243,9641);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static EnvironmentProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1191,618,9688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1191,904,932);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1191,618,9688);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1191,618,9688);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1191,618,9688);
}
}

