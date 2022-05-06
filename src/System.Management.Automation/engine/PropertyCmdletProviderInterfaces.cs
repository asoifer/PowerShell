// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
public sealed class PropertyCmdletProviderIntrinsics
{
private PropertyCmdletProviderIntrinsics()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1317,676,941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78560,78567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78607,78620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,743,930);

f_1317_743_929(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
DynAbs.Tracing.TraceSender.TraceExitConstructor(1317,676,941);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,676,941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,676,941);
}
		}

internal PropertyCmdletProviderIntrinsics(Cmdlet cmdlet)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1317,1296,1607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78560,78567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78607,78620);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,1377,1499) || true) && (cmdlet == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1317,1377,1499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,1429,1484);

throw f_1317_1435_1483("cmdlet");
DynAbs.Tracing.TraceSender.TraceExitCondition(1317,1377,1499);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,1515,1532);

_cmdlet = cmdlet;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,1546,1596);

_sessionState = f_1317_1562_1595(f_1317_1562_1576(cmdlet));
DynAbs.Tracing.TraceSender.TraceExitConstructor(1317,1296,1607);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,1296,1607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,1296,1607);
}
		}

internal PropertyCmdletProviderIntrinsics(SessionStateInternal sessionState)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1317,1988,2279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78560,78567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78607,78620);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,2089,2223) || true) && (sessionState == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1317,2089,2223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,2147,2208);

throw f_1317_2153_2207("sessionState");
DynAbs.Tracing.TraceSender.TraceExitCondition(1317,2089,2223);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,2239,2268);

_sessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1317,1988,2279);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,1988,2279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,1988,2279);
}
		}

public Collection<PSObject> Get(
            string path,
            Collection<string> providerSpecificPickList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,4033,4526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,4174,4335);

f_1317_4174_4334(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,4426,4515);

return f_1317_4433_4514(_sessionState, new string[] { path }, providerSpecificPickList, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,4033,4526);

int
f_1317_4174_4334(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 4174, 4334);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_4433_4514(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,bool
literalPath)
{
var return_v = this_param.GetProperty( paths, providerSpecificPickList, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 4433, 4514);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,4033,4526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,4033,4526);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Get(
            string[] path,
            Collection<string> providerSpecificPickList,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,6301,6816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,6475,6636);

f_1317_6475_6635(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,6727,6805);

return f_1317_6734_6804(_sessionState, path, providerSpecificPickList, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,6301,6816);

int
f_1317_6475_6635(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 6475, 6635);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_6734_6804(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,bool
literalPath)
{
var return_v = this_param.GetProperty( paths, providerSpecificPickList, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 6734, 6804);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,6301,6816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,6301,6816);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Get(
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,8637,9155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,8808,8969);

f_1317_8808_8968(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,9060,9144);

f_1317_9060_9143(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,8637,9155);

int
f_1317_8808_8968(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 8808, 8968);
return 0;
}


int
f_1317_9060_9143(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
context)
{
this_param.GetProperty( paths, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 9060, 9143);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,8637,9155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,8637,9155);
}
		}

internal object GetPropertyDynamicParameters(
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,10783,11335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,10981,11142);

f_1317_10981_11141(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,11233,11324);

return f_1317_11240_11323(_sessionState, path, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,10783,11335);

int
f_1317_10981_11141(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 10981, 11141);
return 0;
}


object
f_1317_11240_11323(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetPropertyDynamicParameters( path, providerSpecificPickList, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 11240, 11323);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,10783,11335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,10783,11335);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Set(
            string path,
            PSObject propertyValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,12908,13376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,13028,13189);

f_1317_13028_13188(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,13280,13365);

return f_1317_13287_13364(_sessionState, new string[] { path }, propertyValue, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,12908,13376);

int
f_1317_13028_13188(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 13028, 13188);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_13287_13364(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.PSObject
property,bool
force,bool
literalPath)
{
var return_v = this_param.SetProperty( paths, property, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 13287, 13364);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,12908,13376);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,12908,13376);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Set(
            string[] path,
            PSObject propertyValue,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,15118,15633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,15296,15457);

f_1317_15296_15456(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,15548,15622);

return f_1317_15555_15621(_sessionState, path, propertyValue, force, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,15118,15633);

int
f_1317_15296_15456(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 15296, 15456);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_15555_15621(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.PSObject
property,bool
force,bool
literalPath)
{
var return_v = this_param.SetProperty( paths, property, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 15555, 15621);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,15118,15633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,15118,15633);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Set(
            string path,
            PSObject propertyValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,17279,17765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,17429,17590);

f_1317_17429_17589(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,17681,17754);

f_1317_17681_17753(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, propertyValue, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,17279,17765);

int
f_1317_17429_17589(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 17429, 17589);
return 0;
}


int
f_1317_17681_17753(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Management.Automation.PSObject
property,System.Management.Automation.CmdletProviderContext
context)
{
this_param.SetProperty( paths, property, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 17681, 17753);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,17279,17765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,17279,17765);
}
		}

internal object SetPropertyDynamicParameters(
            string path,
            PSObject propertyValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,19309,19829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,19486,19647);

f_1317_19486_19646(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,19738,19818);

return f_1317_19745_19817(_sessionState, path, propertyValue, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,19309,19829);

int
f_1317_19486_19646(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 19486, 19646);
return 0;
}


object
f_1317_19745_19817(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Management.Automation.PSObject
propertyValue,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.SetPropertyDynamicParameters( path, propertyValue, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 19745, 19817);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,19309,19829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,19309,19829);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Clear(
            string path,
            Collection<string> propertyToClear)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,21298,21761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,21416,21577);

f_1317_21416_21576(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,21668,21750);

f_1317_21668_21749(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, propertyToClear, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,21298,21761);

int
f_1317_21416_21576(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 21416, 21576);
return 0;
}


int
f_1317_21668_21749(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
propertyToClear,bool
force,bool
literalPath)
{
this_param.ClearProperty( paths, propertyToClear, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 21668, 21749);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,21298,21761);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,21298,21761);
}
		}

public void Clear(
            string[] path,
            Collection<string> propertyToClear,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,23397,23907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,23573,23734);

f_1317_23573_23733(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,23825,23896);

f_1317_23825_23895(
            // Parameter validation is done in the session state object

            _sessionState, path, propertyToClear, force, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,23397,23907);

int
f_1317_23573_23733(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 23573, 23733);
return 0;
}


int
f_1317_23825_23895(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
propertyToClear,bool
force,bool
literalPath)
{
this_param.ClearProperty( paths, propertyToClear, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 23825, 23895);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,23397,23907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,23397,23907);
}
		}

internal void Clear(
            string path,
            Collection<string> propertyToClear,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,25429,25933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,25593,25754);

f_1317_25593_25753(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,25845,25922);

f_1317_25845_25921(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,25429,25933);

int
f_1317_25593_25753(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 25593, 25753);
return 0;
}


int
f_1317_25845_25921(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,System.Collections.ObjectModel.Collection<string>
propertyToClear,System.Management.Automation.CmdletProviderContext
context)
{
this_param.ClearProperty( paths, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 25845, 25921);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,25429,25933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,25429,25933);
}
		}

internal object ClearPropertyDynamicParameters(
            string path,
            Collection<string> propertyToClear,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,27477,28015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,27668,27829);

f_1317_27668_27828(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,27920,28004);

return f_1317_27927_28003(_sessionState, path, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,27477,28015);

int
f_1317_27668_27828(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 27668, 27828);
return 0;
}


object
f_1317_27927_28003(System.Management.Automation.SessionStateInternal
this_param,string
path,System.Collections.ObjectModel.Collection<string>
propertyToClear,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ClearPropertyDynamicParameters( path, propertyToClear, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 27927, 28003);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,27477,28015);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,27477,28015);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> New(
            string path,
            string propertyName,
            string propertyTypeName,
            object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,29893,30447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,30075,30236);

f_1317_30075_30235(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,30327,30436);

return f_1317_30334_30435(_sessionState, new string[] { path }, propertyName, propertyTypeName, value, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,29893,30447);

int
f_1317_30075_30235(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 30075, 30235);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_30334_30435(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,string
type,object
value,bool
force,bool
literalPath)
{
var return_v = this_param.NewProperty( paths, property, type, value, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 30334, 30435);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,29893,30447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,29893,30447);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> New(
            string[] path,
            string propertyName,
            string propertyTypeName,
            object value,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,32492,33093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,32732,32893);

f_1317_32732_32892(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,32984,33082);

return f_1317_32991_33081(_sessionState, path, propertyName, propertyTypeName, value, force, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,32492,33093);

int
f_1317_32732_32892(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 32732, 32892);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_32991_33081(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,string
type,object
value,bool
force,bool
literalPath)
{
var return_v = this_param.NewProperty( paths, property, type, value, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 32991, 33081);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,32492,33093);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,32492,33093);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void New(
            string path,
            string propertyName,
            string type,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,35060,35608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,35260,35421);

f_1317_35260_35420(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,35512,35597);

f_1317_35512_35596(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, propertyName, type, value, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,35060,35608);

int
f_1317_35260_35420(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 35260, 35420);
return 0;
}


int
f_1317_35512_35596(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,string
type,object
value,System.Management.Automation.CmdletProviderContext
context)
{
this_param.NewProperty( paths, property, type, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 35512, 35596);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,35060,35608);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,35060,35608);
}
		}

internal object NewPropertyDynamicParameters(
            string path,
            string propertyName,
            string type,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,37394,37976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,37621,37782);

f_1317_37621_37781(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,37873,37965);

return f_1317_37880_37964(_sessionState, path, propertyName, type, value, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,37394,37976);

int
f_1317_37621_37781(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 37621, 37781);
return 0;
}


object
f_1317_37880_37964(System.Management.Automation.SessionStateInternal
this_param,string
path,string
propertyName,string
type,object
value,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.NewPropertyDynamicParameters( path, propertyName, type, value, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 37880, 37964);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,37394,37976);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,37394,37976);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Remove(string path, string propertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,39438,39858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,39515,39676);

f_1317_39515_39675(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,39767,39847);

f_1317_39767_39846(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, propertyName, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,39438,39858);

int
f_1317_39515_39675(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 39515, 39675);
return 0;
}


int
f_1317_39767_39846(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,bool
force,bool
literalPath)
{
this_param.RemoveProperty( paths, property, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 39767, 39846);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,39438,39858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,39438,39858);
}
		}

public void Remove(string[] path, string propertyName, bool force, bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,41483,41924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,41592,41753);

f_1317_41592_41752(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,41844,41913);

f_1317_41844_41912(
            // Parameter validation is done in the session state object

            _sessionState, path, propertyName, force, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,41483,41924);

int
f_1317_41592_41752(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 41592, 41752);
return 0;
}


int
f_1317_41844_41912(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,bool
force,bool
literalPath)
{
this_param.RemoveProperty( paths, property, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 41844, 41912);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,41483,41924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,41483,41924);
}
		}

internal void Remove(
            string path,
            string propertyName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,43437,43925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,43587,43748);

f_1317_43587_43747(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,43839,43914);

f_1317_43839_43913(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, propertyName, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,43437,43925);

int
f_1317_43587_43747(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 43587, 43747);
return 0;
}


int
f_1317_43839_43913(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
property,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RemoveProperty( paths, property, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 43839, 43913);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,43437,43925);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,43437,43925);
}
		}

internal object RemovePropertyDynamicParameters(
            string path,
            string propertyName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,45474,45996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,45651,45812);

f_1317_45651_45811(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,45903,45985);

return f_1317_45910_45984(_sessionState, path, propertyName, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,45474,45996);

int
f_1317_45651_45811(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 45651, 45811);
return 0;
}


object
f_1317_45910_45984(System.Management.Automation.SessionStateInternal
this_param,string
path,string
propertyName,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RemovePropertyDynamicParameters( path, propertyName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 45910, 45984);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,45474,45996);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,45474,45996);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Rename(
            string path,
            string sourceProperty,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,47767,48303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,47930,48091);

f_1317_47930_48090(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,48182,48292);

return f_1317_48189_48291(_sessionState, new string[] { path }, sourceProperty, destinationProperty, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,47767,48303);

int
f_1317_47930_48090(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 47930, 48090);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_48189_48291(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationProperty,bool
force,bool
literalPath)
{
var return_v = this_param.RenameProperty( sourcePaths, sourceProperty, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 48189, 48291);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,47767,48303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,47767,48303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Rename(
            string[] path,
            string sourceProperty,
            string destinationProperty,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,50234,50817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,50455,50616);

f_1317_50455_50615(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,50707,50806);

return f_1317_50714_50805(_sessionState, path, sourceProperty, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,50234,50817);

int
f_1317_50455_50615(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 50455, 50615);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_50714_50805(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationProperty,bool
force,bool
literalPath)
{
var return_v = this_param.RenameProperty( sourcePaths, sourceProperty, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 50714, 50805);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,50234,50817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,50234,50817);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Rename(
            string path,
            string sourceProperty,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,52734,53288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,52927,53088);

f_1317_52927_53087(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,53179,53277);

f_1317_53179_53276(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { path }, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,52734,53288);

int
f_1317_52927_53087(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 52927, 53087);
return 0;
}


int
f_1317_53179_53276(System.Management.Automation.SessionStateInternal
this_param,string[]
paths,string
sourceProperty,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.RenameProperty( paths, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 53179, 53276);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,52734,53288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,52734,53288);
}
		}

internal object RenamePropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,54950,55538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,55170,55331);

f_1317_55170_55330(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,55422,55527);

return f_1317_55429_55526(_sessionState, path, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,54950,55538);

int
f_1317_55170_55330(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 55170, 55330);
return 0;
}


object
f_1317_55429_55526(System.Management.Automation.SessionStateInternal
this_param,string
path,string
sourceProperty,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.RenamePropertyDynamicParameters( path, sourceProperty, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 55429, 55526);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,54950,55538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,54950,55538);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Copy(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,57609,58330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,57813,57974);

f_1317_57813_57973(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,58065,58319);

return
f_1317_58089_58318(                _sessionState, new string[] { sourcePath }, sourceProperty, destinationPath, destinationProperty, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,57609,58330);

int
f_1317_57813_57973(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 57813, 57973);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_58089_58318(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,bool
force,bool
literalPath)
{
var return_v = this_param.CopyProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 58089, 58318);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,57609,58330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,57609,58330);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Copy(
            string[] sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,60563,61352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,60825,60986);

f_1317_60825_60985(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,61077,61341);

return
f_1317_61101_61340(                _sessionState, sourcePath, sourceProperty, destinationPath, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,60563,61352);

int
f_1317_60825_60985(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 60825, 60985);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_61101_61340(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,bool
force,bool
literalPath)
{
var return_v = this_param.CopyProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 61101, 61340);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,60563,61352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,60563,61352);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Copy(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,63517,64219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,63751,63912);

f_1317_63751_63911(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,64003,64208);

f_1317_64003_64207(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { sourcePath }, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,63517,64219);

int
f_1317_63751_63911(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 63751, 63911);
return 0;
}


int
f_1317_64003_64207(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 64003, 64207);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,63517,64219);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,63517,64219);
}
		}

internal object CopyPropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,66105,66743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,66360,66521);

f_1317_66360_66520(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,66612,66732);

return f_1317_66619_66731(_sessionState, path, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,66105,66743);

int
f_1317_66360_66520(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 66360, 66520);
return 0;
}


object
f_1317_66619_66731(System.Management.Automation.SessionStateInternal
this_param,string
path,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.CopyPropertyDynamicParameters( path, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 66619, 66731);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,66105,66743);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,66105,66743);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Move(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,68968,69710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,69172,69333);

f_1317_69172_69332(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,69424,69699);

return
f_1317_69448_69698(                _sessionState, new string[] { sourcePath }, sourceProperty, destinationPath, destinationProperty, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,68968,69710);

int
f_1317_69172_69332(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 69172, 69332);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_69448_69698(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,bool
force,bool
literalPath)
{
var return_v = this_param.MoveProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 69448, 69698);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,68968,69710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,68968,69710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<PSObject> Move(
            string[] sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            bool force,
            bool literalPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,72099,72888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,72361,72522);

f_1317_72361_72521(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,72613,72877);

return
f_1317_72637_72876(                _sessionState, sourcePath, sourceProperty, destinationPath, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,72099,72888);

int
f_1317_72361_72521(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 72361, 72521);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1317_72637_72876(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,bool
force,bool
literalPath)
{
var return_v = this_param.MoveProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 72637, 72876);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,72099,72888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,72099,72888);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Move(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,75204,75906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,75438,75599);

f_1317_75438_75598(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,75690,75895);

f_1317_75690_75894(
            // Parameter validation is done in the session state object

            _sessionState, new string[] { sourcePath }, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,75204,75906);

int
f_1317_75438_75598(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 75438, 75598);
return 0;
}


int
f_1317_75690_75894(System.Management.Automation.SessionStateInternal
this_param,string[]
sourcePaths,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
this_param.MoveProperty( sourcePaths, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 75690, 75894);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,75204,75906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,75204,75906);
}
		}

internal object MovePropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1317,77791,78429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78046,78207);

f_1317_78046_78206(_sessionState != null, "The only constructor for this class should always set the sessionState field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1317,78298,78418);

return f_1317_78305_78417(_sessionState, path, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1317,77791,78429);

int
f_1317_78046_78206(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 78046, 78206);
return 0;
}


object
f_1317_78305_78417(System.Management.Automation.SessionStateInternal
this_param,string
path,string
sourceProperty,string
destinationPath,string
destinationProperty,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.MovePropertyDynamicParameters( path, sourceProperty, destinationPath, destinationProperty, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 78305, 78417);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1317,77791,78429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,77791,78429);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Cmdlet _cmdlet;

private SessionStateInternal _sessionState;

static PropertyCmdletProviderIntrinsics()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1317,433,78663);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1317,433,78663);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1317,433,78663);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1317,433,78663);

int
f_1317_743_929(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 743, 929);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1317_1435_1483(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 1435, 1483);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1317_1562_1576(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1317, 1562, 1576);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1317_1562_1595(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1317, 1562, 1595);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1317_2153_2207(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1317, 2153, 2207);
return return_v;
}

}
}

