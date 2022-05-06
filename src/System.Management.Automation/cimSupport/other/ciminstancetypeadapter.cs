// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Reflection;

using Microsoft.Management.Infrastructure;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Cim
{
public sealed class CimInstanceAdapter : PSPropertyAdapter
{
private static PSAdaptedProperty GetCimPropertyAdapter(CimProperty property, object baseObject, string propertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1068,971,1336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,1112,1192);

PSAdaptedProperty 
propertyToAdd = f_1068_1146_1191(propertyName, property)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,1206,1244);

propertyToAdd.baseObject = baseObject;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,1304,1325);

return propertyToAdd;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1068,971,1336);

System.Management.Automation.PSAdaptedProperty
f_1068_1146_1191(string
name,Microsoft.Management.Infrastructure.CimProperty
tag)
{
var return_v = new System.Management.Automation.PSAdaptedProperty( name, (object)tag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 1146, 1191);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,971,1336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,971,1336);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static PSAdaptedProperty GetCimPropertyAdapter(CimProperty property, object baseObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1068,1348,1815);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,1504,1540);

string 
propertyName = f_1068_1526_1539(property)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,1558,1623);

return f_1068_1565_1622(property, baseObject, propertyName);
            }
            catch (CimException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1068,1652,1804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,1777,1789);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1068,1652,1804);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1068,1348,1815);

string
f_1068_1526_1539(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 1526, 1539);
return return_v;
}


System.Management.Automation.PSAdaptedProperty
f_1068_1565_1622(Microsoft.Management.Infrastructure.CimProperty
property,object
baseObject,string
propertyName)
{
var return_v = GetCimPropertyAdapter( property, baseObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 1565, 1622);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,1348,1815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,1348,1815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static PSAdaptedProperty GetPSComputerNameAdapter(CimInstance cimInstance)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1068,1827,2228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,1934,2056);

PSAdaptedProperty 
psComputerNameProperty = f_1068_1977_2055(RemotingConstants.ComputerNameNoteProperty, cimInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,2070,2118);

psComputerNameProperty.baseObject = cimInstance;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,2187,2217);

return psComputerNameProperty;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1068,1827,2228);

System.Management.Automation.PSAdaptedProperty
f_1068_1977_2055(string
name,Microsoft.Management.Infrastructure.CimInstance
tag)
{
var return_v = new System.Management.Automation.PSAdaptedProperty( name, (object)tag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 1977, 2055);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,1827,2228);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,1827,2228);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override System.Collections.ObjectModel.Collection<PSAdaptedProperty> GetProperties(object baseObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,2367,3794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,2549,2601);

CimInstance 
cimInstance = baseObject as CimInstance
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,2615,2972) || true) && (cimInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,2615,2972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,2672,2896);

string 
msg = f_1068_2685_2895(f_1068_2699_2727(), f_1068_2750_2806(), "baseObject", f_1068_2864_2894(                    typeof(CimInstance)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,2914,2957);

throw f_1068_2920_2956(msg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,2615,2972);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,2988,3063);

Collection<PSAdaptedProperty> 
result = f_1068_3027_3062()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3079,3524) || true) && (f_1068_3083_3116(cimInstance)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,3079,3524);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3158,3509);
foreach(CimProperty property in f_1068_3191_3224_I(f_1068_3191_3224(cimInstance)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,3158,3509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3266,3344);

PSAdaptedProperty 
propertyToAdd = f_1068_3300_3343(property, baseObject)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3366,3490) || true) && (propertyToAdd != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,3366,3490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3441,3467);

f_1068_3441_3466(                        result, propertyToAdd);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,3366,3490);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,3158,3509);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1068,1,352);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1068,1,352);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1068,3079,3524);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3540,3621);

PSAdaptedProperty 
psComputerNameProperty = f_1068_3583_3620(cimInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3635,3753) || true) && (psComputerNameProperty != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,3635,3753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3703,3738);

f_1068_3703_3737(                result, psComputerNameProperty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,3635,3753);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,3769,3783);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,2367,3794);

System.Globalization.CultureInfo
f_1068_2699_2727()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 2699, 2727);
return return_v;
}


string
f_1068_2750_2806()
{
var return_v =                     CimInstanceTypeAdapterResources.BaseObjectNotCimInstance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 2750, 2806);
return return_v;
}


string
f_1068_2864_2894(System.Type
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 2864, 2894);
return return_v;
}


string
f_1068_2685_2895(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 2685, 2895);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1068_2920_2956(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 2920, 2956);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
f_1068_3027_3062()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 3027, 3062);
return return_v;
}


Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
f_1068_3083_3116(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.CimInstanceProperties ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 3083, 3116);
return return_v;
}


Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
f_1068_3191_3224(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.CimInstanceProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 3191, 3224);
return return_v;
}


System.Management.Automation.PSAdaptedProperty
f_1068_3300_3343(Microsoft.Management.Infrastructure.CimProperty
property,object
baseObject)
{
var return_v = GetCimPropertyAdapter( property, baseObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 3300, 3343);
return return_v;
}


int
f_1068_3441_3466(System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
this_param,System.Management.Automation.PSAdaptedProperty
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 3441, 3466);
return 0;
}


Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
f_1068_3191_3224_I(Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 3191, 3224);
return return_v;
}


System.Management.Automation.PSAdaptedProperty
f_1068_3583_3620(Microsoft.Management.Infrastructure.CimInstance
cimInstance)
{
var return_v = GetPSComputerNameAdapter( cimInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 3583, 3620);
return return_v;
}


int
f_1068_3703_3737(System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
this_param,System.Management.Automation.PSAdaptedProperty
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 3703, 3737);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,2367,3794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,2367,3794);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override PSAdaptedProperty GetProperty(object baseObject, string propertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,3982,5294);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4092,4215) || true) && (propertyName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,4092,4215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4150,4200);

throw f_1068_4156_4199("propertyName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,4092,4215);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4279,4331);

CimInstance 
cimInstance = baseObject as CimInstance
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4345,4702) || true) && (cimInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,4345,4702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4402,4626);

string 
msg = f_1068_4415_4625(f_1068_4429_4457(), f_1068_4480_4536(), "baseObject", f_1068_4594_4624(                    typeof(CimInstance)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4644,4687);

throw f_1068_4650_4686(msg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,4345,4702);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4718,4792);

CimProperty 
cimProperty = f_1068_4744_4791(f_1068_4744_4777(cimInstance), propertyName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4806,4994) || true) && (cimProperty != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,4806,4994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4863,4949);

PSAdaptedProperty 
prop = f_1068_4888_4948(cimProperty, baseObject, propertyName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,4967,4979);

return prop;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,4806,4994);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5010,5255) || true) && (f_1068_5014_5113(propertyName, RemotingConstants.ComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,5010,5255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5147,5210);

PSAdaptedProperty 
prop = f_1068_5172_5209(cimInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5228,5240);

return prop;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,5010,5255);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5271,5283);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,3982,5294);

System.Management.Automation.PSArgumentNullException
f_1068_4156_4199(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 4156, 4199);
return return_v;
}


System.Globalization.CultureInfo
f_1068_4429_4457()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 4429, 4457);
return return_v;
}


string
f_1068_4480_4536()
{
var return_v =                     CimInstanceTypeAdapterResources.BaseObjectNotCimInstance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 4480, 4536);
return return_v;
}


string
f_1068_4594_4624(System.Type
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 4594, 4624);
return return_v;
}


string
f_1068_4415_4625(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 4415, 4625);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1068_4650_4686(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 4650, 4686);
return return_v;
}


Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
f_1068_4744_4777(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.CimInstanceProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 4744, 4777);
return return_v;
}


Microsoft.Management.Infrastructure.CimProperty
f_1068_4744_4791(Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 4744, 4791);
return return_v;
}


System.Management.Automation.PSAdaptedProperty
f_1068_4888_4948(Microsoft.Management.Infrastructure.CimProperty
property,object
baseObject,string
propertyName)
{
var return_v = GetCimPropertyAdapter( property, baseObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 4888, 4948);
return return_v;
}


bool
f_1068_5014_5113(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 5014, 5113);
return return_v;
}


System.Management.Automation.PSAdaptedProperty
f_1068_5172_5209(Microsoft.Management.Infrastructure.CimInstance
cimInstance)
{
var return_v = GetPSComputerNameAdapter( cimInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 5172, 5209);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,3982,5294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,3982,5294);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override PSAdaptedProperty GetFirstPropertyOrDefault(object baseObject, MemberNamePredicate predicate)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,5334,6727);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5468,5591) || true) && (predicate == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,5468,5591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5523,5576);

throw f_1068_5529_5575(nameof(predicate));
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,5468,5591);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5655,5707);

CimInstance 
cimInstance = baseObject as CimInstance
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5721,6100) || true) && (cimInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,5721,6100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,5778,6024);

string 
msg = f_1068_5791_6023(f_1068_5827_5855(), f_1068_5878_5934(), "baseObject", f_1068_5992_6022(                    typeof(CimInstance)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6042,6085);

throw f_1068_6048_6084(msg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,5721,6100);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6116,6315) || true) && (f_1068_6120_6173(predicate, RemotingConstants.ComputerNameNoteProperty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,6116,6315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6207,6270);

PSAdaptedProperty 
prop = f_1068_6232_6269(cimInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6288,6300);

return prop;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,6116,6315);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6331,6688);
foreach(CimProperty cimProperty in f_1068_6367_6400_I(f_1068_6367_6400(cimInstance)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,6331,6688);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6434,6673) || true) && (cimProperty != null &&(DynAbs.Tracing.TraceSender.Expression_True(1068, 6438, 6488)&&f_1068_6461_6488(predicate, f_1068_6471_6487(cimProperty))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,6434,6673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6530,6620);

PSAdaptedProperty 
prop = f_1068_6555_6619(cimProperty, baseObject, f_1068_6602_6618(cimProperty))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6642,6654);

return prop;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,6434,6673);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,6331,6688);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1068,1,358);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1068,1,358);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6704,6716);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,5334,6727);

System.Management.Automation.PSArgumentNullException
f_1068_5529_5575(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 5529, 5575);
return return_v;
}


System.Globalization.CultureInfo
f_1068_5827_5855()
{
var return_v =                     CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 5827, 5855);
return return_v;
}


string
f_1068_5878_5934()
{
var return_v =                     CimInstanceTypeAdapterResources.BaseObjectNotCimInstance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 5878, 5934);
return return_v;
}


string
f_1068_5992_6022(System.Type
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 5992, 6022);
return return_v;
}


string
f_1068_5791_6023(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 5791, 6023);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1068_6048_6084(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 6048, 6084);
return return_v;
}


bool
f_1068_6120_6173(System.Management.Automation.MemberNamePredicate
this_param,string
memberName)
{
var return_v = this_param.Invoke( memberName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 6120, 6173);
return return_v;
}


System.Management.Automation.PSAdaptedProperty
f_1068_6232_6269(Microsoft.Management.Infrastructure.CimInstance
cimInstance)
{
var return_v = GetPSComputerNameAdapter( cimInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 6232, 6269);
return return_v;
}


Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
f_1068_6367_6400(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.CimInstanceProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 6367, 6400);
return return_v;
}


string
f_1068_6471_6487(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 6471, 6487);
return return_v;
}


bool
f_1068_6461_6488(System.Management.Automation.MemberNamePredicate
this_param,string
memberName)
{
var return_v = this_param.Invoke( memberName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 6461, 6488);
return return_v;
}


string
f_1068_6602_6618(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 6602, 6618);
return return_v;
}


System.Management.Automation.PSAdaptedProperty
f_1068_6555_6619(Microsoft.Management.Infrastructure.CimProperty
property,object
baseObject,string
propertyName)
{
var return_v = GetCimPropertyAdapter( property, baseObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 6555, 6619);
return return_v;
}


Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
f_1068_6367_6400_I(Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 6367, 6400);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,5334,6727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,5334,6727);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string CimTypeToTypeNameDisplayString(CimType cimType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1068,6739,7358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,6834,7347);

switch (cimType)
            {

case CimType.DateTime:
                case CimType.Instance:
                case CimType.Reference:
                case CimType.DateTimeArray:
                case CimType.InstanceArray:
                case CimType.ReferenceArray:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,6834,7347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7144,7187);

return "CimInstance#" + f_1068_7168_7186(cimType);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,6834,7347);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,6834,7347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7237,7332);

return f_1068_7244_7331(f_1068_7295_7330(cimType));
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,6834,7347);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1068,6739,7358);

string
f_1068_7168_7186(Microsoft.Management.Infrastructure.CimType
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 7168, 7186);
return return_v;
}


System.Type
f_1068_7295_7330(Microsoft.Management.Infrastructure.CimType
cimType)
{
var return_v = CimConverter.GetDotNetType( cimType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 7295, 7330);
return return_v;
}


string
f_1068_7244_7331(System.Type
type)
{
var return_v = ToStringCodeMethods.Type( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 7244, 7331);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,6739,7358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,6739,7358);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override string GetPropertyTypeName(PSAdaptedProperty adaptedProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,7502,8255);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7604,7731) || true) && (adaptedProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,7604,7731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7665,7716);

throw f_1068_7671_7715("adaptedProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,7604,7731);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7747,7808);

CimProperty 
cimProperty = f_1068_7773_7792(adaptedProperty)as CimProperty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7822,7953) || true) && (cimProperty != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,7822,7953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7879,7938);

return f_1068_7886_7937(f_1068_7917_7936(cimProperty));
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,7822,7953);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,7969,8177) || true) && (f_1068_7973_8080(f_1068_7973_7993(adaptedProperty), RemotingConstants.ComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,7969,8177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8114,8162);

return f_1068_8121_8161(typeof(string));
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,7969,8177);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8193,8244);

throw f_1068_8199_8243("adaptedProperty");
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,7502,8255);

System.ArgumentNullException
f_1068_7671_7715(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 7671, 7715);
return return_v;
}


object
f_1068_7773_7792(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Tag ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 7773, 7792);
return return_v;
}


Microsoft.Management.Infrastructure.CimType
f_1068_7917_7936(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.CimType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 7917, 7936);
return return_v;
}


string
f_1068_7886_7937(Microsoft.Management.Infrastructure.CimType
cimType)
{
var return_v = CimTypeToTypeNameDisplayString( cimType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 7886, 7937);
return return_v;
}


string
f_1068_7973_7993(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 7973, 7993);
return return_v;
}


bool
f_1068_7973_8080(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 7973, 8080);
return return_v;
}


string
f_1068_8121_8161(System.Type
type)
{
var return_v = ToStringCodeMethods.Type( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 8121, 8161);
return return_v;
}


System.ArgumentNullException
f_1068_8199_8243(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 8199, 8243);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,7502,8255);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,7502,8255);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override object GetPropertyValue(PSAdaptedProperty adaptedProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,8399,9191);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8498,8625) || true) && (adaptedProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,8498,8625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8559,8610);

throw f_1068_8565_8609("adaptedProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,8498,8625);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8641,8702);

CimProperty 
cimProperty = f_1068_8667_8686(adaptedProperty)as CimProperty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8716,8813) || true) && (cimProperty != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,8716,8813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8773,8798);

return f_1068_8780_8797(cimProperty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,8716,8813);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8829,9113) || true) && (f_1068_8833_8940(f_1068_8833_8853(adaptedProperty), RemotingConstants.ComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,8829,9113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,8974,9033);

CimInstance 
cimInstance = (CimInstance)f_1068_9013_9032(adaptedProperty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,9051,9098);

return f_1068_9058_9097(cimInstance);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,8829,9113);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,9129,9180);

throw f_1068_9135_9179("adaptedProperty");
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,8399,9191);

System.ArgumentNullException
f_1068_8565_8609(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 8565, 8609);
return return_v;
}


object
f_1068_8667_8686(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Tag ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 8667, 8686);
return return_v;
}


object
f_1068_8780_8797(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 8780, 8797);
return return_v;
}


string
f_1068_8833_8853(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 8833, 8853);
return return_v;
}


bool
f_1068_8833_8940(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 8833, 8940);
return return_v;
}


object
f_1068_9013_9032(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Tag;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 9013, 9032);
return return_v;
}


string
f_1068_9058_9097(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.GetCimSessionComputerName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 9058, 9097);
return return_v;
}


System.ArgumentNullException
f_1068_9135_9179(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 9135, 9179);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,8399,9191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,8399,9191);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void AddTypeNameHierarchy(IList<string> typeNamesWithNamespace, IList<string> typeNamesWithoutNamespace, string namespaceName, string className)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,9203,10046);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,9380,9802) || true) && (!f_1068_9385_9420(namespaceName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,9380,9802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,9454,9728);

string 
fullTypeName = f_1068_9476_9727(f_1068_9490_9518(), "Microsoft.Management.Infrastructure.CimInstance#{0}/{1}", namespaceName, className)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,9746,9787);

f_1068_9746_9786(                typeNamesWithNamespace, fullTypeName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,9380,9802);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,9818,10035);

f_1068_9818_10034(
            typeNamesWithoutNamespace, f_1068_9848_10033(f_1068_9862_9890(), "Microsoft.Management.Infrastructure.CimInstance#{0}", className));
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,9203,10046);

bool
f_1068_9385_9420(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 9385, 9420);
return return_v;
}


System.Globalization.CultureInfo
f_1068_9490_9518()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 9490, 9518);
return return_v;
}


string
f_1068_9476_9727(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 9476, 9727);
return return_v;
}


int
f_1068_9746_9786(System.Collections.Generic.IList<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 9746, 9786);
return 0;
}


System.Globalization.CultureInfo
f_1068_9862_9890()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 9862, 9890);
return return_v;
}


string
f_1068_9848_10033(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 9848, 10033);
return return_v;
}


int
f_1068_9818_10034(System.Collections.Generic.IList<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 9818, 10034);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,9203,10046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,9203,10046);
}
		}

private List<CimClass> GetInheritanceChain(CimInstance cimInstance)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,10058,10734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10150,10205);

List<CimClass> 
inheritanceChain = f_1068_10184_10204()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10219,10260);

CimClass 
cimClass = f_1068_10239_10259(cimInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10274,10347);

f_1068_10274_10346(cimClass != null, "CimInstance should always have ClassDecl");
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10361,10683) || true) && (cimClass != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,10361,10683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10418,10449);

f_1068_10418_10448(                inheritanceChain, cimClass);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10511,10545);

cimClass = f_1068_10522_10544(cimClass);
                }
                catch (CimException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1068,10582,10668);
DynAbs.Tracing.TraceSender.TraceBreak(1068,10643,10649);

break;
DynAbs.Tracing.TraceSender.TraceExitCatch(1068,10582,10668);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,10361,10683);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1068,10361,10683);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1068,10361,10683);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10699,10723);

return inheritanceChain;
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,10058,10734);

System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>
f_1068_10184_10204()
{
var return_v = new System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 10184, 10204);
return return_v;
}


Microsoft.Management.Infrastructure.CimClass
f_1068_10239_10259(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.CimClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 10239, 10259);
return return_v;
}


int
f_1068_10274_10346(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 10274, 10346);
return 0;
}


int
f_1068_10418_10448(System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>
this_param,Microsoft.Management.Infrastructure.CimClass
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 10418, 10448);
return 0;
}


Microsoft.Management.Infrastructure.CimClass
f_1068_10522_10544(Microsoft.Management.Infrastructure.CimClass
this_param)
{
var return_v = this_param.CimSuperClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 10522, 10544);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,10058,10734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,10058,10734);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Collection<string> GetTypeNameHierarchy(object baseObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,10873,12668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,10972,11016);

var 
cimInstance = baseObject as CimInstance
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11030,11148) || true) && (cimInstance == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,11030,11148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11087,11133);

throw f_1068_11093_11132("baseObject");
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,11030,11148);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11164,11212);

var 
typeNamesWithNamespace = f_1068_11193_11211()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11226,11277);

var 
typeNamesWithoutNamespace = f_1068_11258_11276()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11293,11361);

IList<CimClass> 
inheritanceChain = f_1068_11328_11360(this, cimInstance)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11375,12197) || true) && ((inheritanceChain == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1068, 11379, 11438)||(f_1068_11410_11432(inheritanceChain)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,11375,12197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11472,11715);

f_1068_11472_11714(this, typeNamesWithNamespace, typeNamesWithoutNamespace, f_1068_11608_11649(f_1068_11608_11639(cimInstance)), f_1068_11672_11713(f_1068_11672_11703(cimInstance)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,11375,12197);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,11375,12197);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11781,12182);
foreach(CimClass cimClass in f_1068_11811_11827_I(inheritanceChain) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,11781,12182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,11869,12122);

f_1068_11869_12121(this, typeNamesWithNamespace, typeNamesWithoutNamespace, f_1068_12017_12055(f_1068_12017_12045(cimClass)), f_1068_12082_12120(f_1068_12082_12110(cimClass)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12144,12163);

f_1068_12144_12162(                    cimClass);
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,11781,12182);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1068,1,402);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1068,1,402);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1068,11375,12197);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12213,12245);

var 
result = f_1068_12226_12244()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12259,12299);

f_1068_12259_12298(            result, typeNamesWithNamespace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12313,12356);

f_1068_12313_12355(            result, typeNamesWithoutNamespace);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12372,12603) || true) && (baseObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,12372,12603);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12438,12465);
                for (Type 
type = f_1068_12445_12465(baseObject)
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12428,12588) || true) && (type != null)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12481,12501)
,type = f_1068_12488_12501(type),DynAbs.Tracing.TraceSender.TraceExitCondition(1068,12428,12588))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,12428,12588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12543,12569);

f_1068_12543_12568(                    result, f_1068_12554_12567(type));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1068,1,161);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1068,1,161);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1068,12372,12603);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,12619,12657);

return f_1068_12626_12656(result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,10873,12668);

System.ArgumentNullException
f_1068_11093_11132(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 11093, 11132);
return return_v;
}


System.Collections.Generic.List<string>
f_1068_11193_11211()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 11193, 11211);
return return_v;
}


System.Collections.Generic.List<string>
f_1068_11258_11276()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 11258, 11276);
return return_v;
}


System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>
f_1068_11328_11360(Microsoft.PowerShell.Cim.CimInstanceAdapter
this_param,Microsoft.Management.Infrastructure.CimInstance
cimInstance)
{
var return_v = this_param.GetInheritanceChain( cimInstance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 11328, 11360);
return return_v;
}


int
f_1068_11410_11432(System.Collections.Generic.IList<Microsoft.Management.Infrastructure.CimClass>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 11410, 11432);
return return_v;
}


Microsoft.Management.Infrastructure.CimSystemProperties
f_1068_11608_11639(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.CimSystemProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 11608, 11639);
return return_v;
}


string
f_1068_11608_11649(Microsoft.Management.Infrastructure.CimSystemProperties
this_param)
{
var return_v = this_param.Namespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 11608, 11649);
return return_v;
}


Microsoft.Management.Infrastructure.CimSystemProperties
f_1068_11672_11703(Microsoft.Management.Infrastructure.CimInstance
this_param)
{
var return_v = this_param.CimSystemProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 11672, 11703);
return return_v;
}


string
f_1068_11672_11713(Microsoft.Management.Infrastructure.CimSystemProperties
this_param)
{
var return_v = this_param.ClassName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 11672, 11713);
return return_v;
}


int
f_1068_11472_11714(Microsoft.PowerShell.Cim.CimInstanceAdapter
this_param,System.Collections.Generic.List<string>
typeNamesWithNamespace,System.Collections.Generic.List<string>
typeNamesWithoutNamespace,string
namespaceName,string
className)
{
this_param.AddTypeNameHierarchy( (System.Collections.Generic.IList<string>)typeNamesWithNamespace, (System.Collections.Generic.IList<string>)typeNamesWithoutNamespace, namespaceName, className);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 11472, 11714);
return 0;
}


Microsoft.Management.Infrastructure.CimSystemProperties
f_1068_12017_12045(Microsoft.Management.Infrastructure.CimClass
this_param)
{
var return_v = this_param.CimSystemProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 12017, 12045);
return return_v;
}


string
f_1068_12017_12055(Microsoft.Management.Infrastructure.CimSystemProperties
this_param)
{
var return_v = this_param.Namespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 12017, 12055);
return return_v;
}


Microsoft.Management.Infrastructure.CimSystemProperties
f_1068_12082_12110(Microsoft.Management.Infrastructure.CimClass
this_param)
{
var return_v = this_param.CimSystemProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 12082, 12110);
return return_v;
}


string
f_1068_12082_12120(Microsoft.Management.Infrastructure.CimSystemProperties
this_param)
{
var return_v = this_param.ClassName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 12082, 12120);
return return_v;
}


int
f_1068_11869_12121(Microsoft.PowerShell.Cim.CimInstanceAdapter
this_param,System.Collections.Generic.List<string>
typeNamesWithNamespace,System.Collections.Generic.List<string>
typeNamesWithoutNamespace,string
namespaceName,string
className)
{
this_param.AddTypeNameHierarchy( (System.Collections.Generic.IList<string>)typeNamesWithNamespace, (System.Collections.Generic.IList<string>)typeNamesWithoutNamespace, namespaceName, className);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 11869, 12121);
return 0;
}


int
f_1068_12144_12162(Microsoft.Management.Infrastructure.CimClass
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 12144, 12162);
return 0;
}


System.Collections.Generic.IList<Microsoft.Management.Infrastructure.CimClass>
f_1068_11811_11827_I(System.Collections.Generic.IList<Microsoft.Management.Infrastructure.CimClass>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 11811, 11827);
return return_v;
}


System.Collections.Generic.List<string>
f_1068_12226_12244()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 12226, 12244);
return return_v;
}


int
f_1068_12259_12298(System.Collections.Generic.List<string>
this_param,System.Collections.Generic.List<string>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<string>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 12259, 12298);
return 0;
}


int
f_1068_12313_12355(System.Collections.Generic.List<string>
this_param,System.Collections.Generic.List<string>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<string>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 12313, 12355);
return 0;
}


System.Type
f_1068_12445_12465(object
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 12445, 12465);
return return_v;
}


System.Type
f_1068_12488_12501(System.Type
this_param)
{
var return_v = this_param.BaseType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 12488, 12501);
return return_v;
}


string
f_1068_12554_12567(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 12554, 12567);
return return_v;
}


int
f_1068_12543_12568(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 12543, 12568);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1068_12626_12656(System.Collections.Generic.List<string>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 12626, 12656);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,10873,12668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,10873,12668);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool IsGettable(PSAdaptedProperty adaptedProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,12812,13274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,13251,13263);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,12812,13274);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,12812,13274);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,12812,13274);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool IsSettable(PSAdaptedProperty adaptedProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,13418,14317);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,13868,13957) || true) && (adaptedProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,13868,13957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,13929,13942);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,13868,13957);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,13973,14034);

CimProperty 
cimProperty = f_1068_13999_14018(adaptedProperty)as CimProperty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14048,14133) || true) && (cimProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,14048,14133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14105,14118);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,14048,14133);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14149,14230);

bool 
isReadOnly = (CimFlags.ReadOnly == (f_1068_14190_14207(cimProperty)& CimFlags.ReadOnly))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14244,14274);

bool 
isSettable = !isReadOnly
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14288,14306);

return isSettable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,13418,14317);

object
f_1068_13999_14018(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Tag ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 13999, 14018);
return return_v;
}


Microsoft.Management.Infrastructure.CimFlags
f_1068_14190_14207(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.Flags ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 14190, 14207);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,13418,14317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,13418,14317);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void SetPropertyValue(PSAdaptedProperty adaptedProperty, object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1068,14470,16151);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14581,14708) || true) && (adaptedProperty == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,14581,14708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14642,14693);

throw f_1068_14648_14692("adaptedProperty");
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,14581,14708);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14724,15012) || true) && (!f_1068_14729_14756(this, adaptedProperty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,14724,15012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,14790,14997);

throw f_1068_14796_14996("ReadOnlyCIMProperty", null, f_1068_14897_14948(), f_1068_14975_14995(adaptedProperty));
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,14724,15012);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15028,15089);

CimProperty 
cimProperty = f_1068_15054_15073(adaptedProperty)as CimProperty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15103,15129);

object 
valueToSet = value
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15143,16072) || true) && (valueToSet != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,15143,16072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15253,15268);

Type 
paramType
=default(Type);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15286,15908);

switch (f_1068_15294_15313(cimProperty))
                {

case CimType.DateTime:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,15286,15908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15403,15430);

paramType = typeof(object);
DynAbs.Tracing.TraceSender.TraceBreak(1068,15456,15462);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,15286,15908);

case CimType.DateTimeArray:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,15286,15908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15537,15566);

paramType = typeof(object[]);
DynAbs.Tracing.TraceSender.TraceBreak(1068,15592,15598);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,15286,15908);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1068,15286,15908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15654,15714);

paramType = f_1068_15666_15713(f_1068_15693_15712(cimProperty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15740,15857);

f_1068_15740_15856(paramType != null, "'default' case should only be used for well-defined CimType->DotNetType conversions");
DynAbs.Tracing.TraceSender.TraceBreak(1068,15883,15889);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,15286,15908);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,15928,16057);

valueToSet = f_1068_15941_16056(value, paramType, f_1068_16027_16055());
DynAbs.Tracing.TraceSender.TraceExitCondition(1068,15143,16072);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,16088,16119);

cimProperty.Value = valueToSet;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1068,16133,16140);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1068,14470,16151);

System.ArgumentNullException
f_1068_14648_14692(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 14648, 14692);
return return_v;
}


bool
f_1068_14729_14756(Microsoft.PowerShell.Cim.CimInstanceAdapter
this_param,System.Management.Automation.PSAdaptedProperty
adaptedProperty)
{
var return_v = this_param.IsSettable( adaptedProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 14729, 14756);
return return_v;
}


string
f_1068_14897_14948()
{
var return_v =                         CimInstanceTypeAdapterResources.ReadOnlyCIMProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 14897, 14948);
return return_v;
}


string
f_1068_14975_14995(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 14975, 14995);
return return_v;
}


System.Management.Automation.SetValueException
f_1068_14796_14996(string
errorId,System.Exception
innerException,string
resourceString,params object[]
arguments)
{
var return_v = new System.Management.Automation.SetValueException( errorId, innerException, resourceString, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 14796, 14996);
return return_v;
}


object
f_1068_15054_15073(System.Management.Automation.PSAdaptedProperty
this_param)
{
var return_v = this_param.Tag ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 15054, 15073);
return return_v;
}


Microsoft.Management.Infrastructure.CimType
f_1068_15294_15313(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.CimType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 15294, 15313);
return return_v;
}


Microsoft.Management.Infrastructure.CimType
f_1068_15693_15712(Microsoft.Management.Infrastructure.CimProperty
this_param)
{
var return_v = this_param.CimType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 15693, 15712);
return return_v;
}


System.Type
f_1068_15666_15713(Microsoft.Management.Infrastructure.CimType
cimType)
{
var return_v = CimConverter.GetDotNetType( cimType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 15666, 15713);
return return_v;
}


int
f_1068_15740_15856(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 15740, 15856);
return 0;
}


System.Globalization.CultureInfo
f_1068_16027_16055()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1068, 16027, 16055);
return return_v;
}


object
f_1068_15941_16056(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = Adapter.PropertySetAndMethodArgumentConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1068, 15941, 16056);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1068,14470,16151);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,14470,16151);
}
		}

public CimInstanceAdapter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1068,896,16158);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1068,896,16158);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,896,16158);
}


static CimInstanceAdapter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1068,896,16158);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1068,896,16158);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1068,896,16158);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1068,896,16158);
}
}
