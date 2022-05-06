// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56506

using System;
using Dbg = System.Management.Automation;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Provider;
using System.Security;

namespace Microsoft.PowerShell.Commands
{
public abstract class SessionStateProviderBase : ContainerCmdletProvider, IContentCmdletProvider
{
[Dbg.TraceSourceAttribute(
             "SessionStateProvider",
             "Providers that produce a view of session state data.")]
        private static readonly Dbg.PSTraceSource s_tracer ;

internal abstract object GetSessionStateItem(string name);

internal abstract void SetSessionStateItem(string name, object value, bool writeItem);

internal abstract void RemoveSessionStateItem(string name);

internal abstract IDictionary GetSessionStateTable();

internal virtual object GetValueOfItem(object item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,3721,4118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,3797,3912);

f_1214_3797_3911(item != null, "Caller should verify the item parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,3928,3948);

object 
value = item
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,3964,4078) || true) && (item is DictionaryEntry)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,3964,4078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,4025,4063);

value = ((DictionaryEntry)item).Value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,3964,4078);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,4094,4107);

return value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,3721,4118);

int
f_1214_3797_3911(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 3797, 3911);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,3721,4118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,3721,4118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual bool CanRenameItem(object item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,4537,4633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,4610,4622);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,4537,4633);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,4537,4633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,4537,4633);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void GetItem(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,5048,5814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5117,5142);

bool 
isContainer = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5156,5175);

object 
item = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5191,5234);

IDictionary 
table = f_1214_5211_5233(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5248,5567) || true) && (table != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,5248,5567);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5299,5552) || true) && (f_1214_5303_5329(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,5299,5552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5371,5390);

isContainer = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5412,5432);

item = f_1214_5419_5431(table);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,5299,5552);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,5299,5552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5514,5533);

item = f_1214_5521_5532(table, name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,5299,5552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,5248,5567);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5583,5803) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,5583,5803);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5633,5788) || true) && (f_1214_5637_5686(f_1214_5660_5679(f_1214_5660_5672(this)), item))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,5633,5788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,5728,5769);

f_1214_5728_5768(this, item, name, isContainer);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,5633,5788);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,5583,5803);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,5048,5814);

System.Collections.IDictionary
f_1214_5211_5233(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param)
{
var return_v = this_param.GetSessionStateTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 5211, 5233);
return return_v;
}


bool
f_1214_5303_5329(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 5303, 5329);
return return_v;
}


System.Collections.ICollection
f_1214_5419_5431(System.Collections.IDictionary
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 5419, 5431);
return return_v;
}


object
f_1214_5521_5532(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 5521, 5532);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1214_5660_5672(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 5660, 5672);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1214_5660_5679(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 5660, 5679);
return return_v;
}


bool
f_1214_5637_5686(System.Management.Automation.CommandOrigin
origin,object
valueToCheck)
{
var return_v = SessionState.IsVisible( origin, valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 5637, 5686);
return return_v;
}


int
f_1214_5728_5768(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,object
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 5728, 5768);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,5048,5814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,5048,5814);
}
		}

protected override void SetItem(
            string name,
            object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,6268,7834);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,6378,6699) || true) && (f_1214_6382_6408(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,6378,6699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,6442,6659);

f_1214_6442_6658(this, f_1214_6453_6657(f_1214_6491_6537("name"), "SetItemNullName", ErrorCategory.InvalidArgument, name));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,6677,6684);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,6378,6699);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,6808,6870);

string 
action = f_1214_6824_6869()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,6890,6972);

string 
resourceTemplate = f_1214_6916_6971()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,6992,7198);

string 
resource =
f_1214_7031_7197(f_1214_7071_7090(f_1214_7071_7075()), resourceTemplate, name, value)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,7218,7353) || true) && (f_1214_7222_7253(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,7218,7353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,7295,7334);

f_1214_7295_7333(this, name, value, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,7218,7353);
}
            }
            catch (SessionStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,7382,7580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,7446,7565);

f_1214_7446_7564(this, f_1214_7479_7563(f_1214_7521_7534(e), e));
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,7382,7580);
            }
            catch (PSArgumentException argException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,7594,7823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,7667,7808);

f_1214_7667_7807(this, f_1214_7700_7806(f_1214_7742_7766(argException), argException));
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,7594,7823);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,6268,7834);

bool
f_1214_6382_6408(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 6382, 6408);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1214_6491_6537(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 6491, 6537);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_6453_6657(System.Management.Automation.PSArgumentNullException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 6453, 6657);
return return_v;
}


int
f_1214_6442_6658(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 6442, 6658);
return 0;
}


string
f_1214_6824_6869()
{
var return_v = SessionStateProviderBaseStrings.SetItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 6824, 6869);
return return_v;
}


string
f_1214_6916_6971()
{
var return_v = SessionStateProviderBaseStrings.SetItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 6916, 6971);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1214_7071_7075()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 7071, 7075);
return return_v;
}


System.Globalization.CultureInfo
f_1214_7071_7090(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 7071, 7090);
return return_v;
}


string
f_1214_7031_7197(System.Globalization.CultureInfo
provider,string
format,string
arg0,object
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 7031, 7197);
return return_v;
}


bool
f_1214_7222_7253(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 7222, 7253);
return return_v;
}


int
f_1214_7295_7333(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name,object
value,bool
writeItem)
{
this_param.SetSessionStateItem( name, value, writeItem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 7295, 7333);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_7521_7534(System.Management.Automation.SessionStateException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 7521, 7534);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_7479_7563(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.SessionStateException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 7479, 7563);
return return_v;
}


int
f_1214_7446_7564(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 7446, 7564);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_7742_7766(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 7742, 7766);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_7700_7806(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 7700, 7806);
return return_v;
}


int
f_1214_7667_7807(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 7667, 7807);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,6268,7834);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,6268,7834);
}
		}

protected override void ClearItem(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,7934,9437);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8005,8328) || true) && (f_1214_8009_8035(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,8005,8328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8069,8288);

f_1214_8069_8287(this, f_1214_8080_8286(f_1214_8118_8164("path"), "ClearItemNullPath", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8306,8313);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,8005,8328);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8439,8503);

string 
action = f_1214_8455_8502()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8523,8607);

string 
resourceTemplate = f_1214_8549_8606()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8627,8801);

string 
resource =
f_1214_8666_8800(f_1214_8706_8725(f_1214_8706_8710()), resourceTemplate, path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8821,8956) || true) && (f_1214_8825_8856(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,8821,8956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,8898,8937);

f_1214_8898_8936(this, path, null, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,8821,8956);
}
            }
            catch (SessionStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,8985,9183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,9049,9168);

f_1214_9049_9167(this, f_1214_9082_9166(f_1214_9124_9137(e), e));
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,8985,9183);
            }
            catch (PSArgumentException argException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,9197,9426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,9270,9411);

f_1214_9270_9410(this, f_1214_9303_9409(f_1214_9345_9369(argException), argException));
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,9197,9426);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,7934,9437);

bool
f_1214_8009_8035(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 8009, 8035);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1214_8118_8164(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 8118, 8164);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_8080_8286(System.Management.Automation.PSArgumentNullException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 8080, 8286);
return return_v;
}


int
f_1214_8069_8287(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 8069, 8287);
return 0;
}


string
f_1214_8455_8502()
{
var return_v = SessionStateProviderBaseStrings.ClearItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 8455, 8502);
return return_v;
}


string
f_1214_8549_8606()
{
var return_v = SessionStateProviderBaseStrings.ClearItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 8549, 8606);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1214_8706_8710()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 8706, 8710);
return return_v;
}


System.Globalization.CultureInfo
f_1214_8706_8725(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 8706, 8725);
return return_v;
}


string
f_1214_8666_8800(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 8666, 8800);
return return_v;
}


bool
f_1214_8825_8856(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 8825, 8856);
return return_v;
}


int
f_1214_8898_8936(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name,object
value,bool
writeItem)
{
this_param.SetSessionStateItem( name, value, writeItem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 8898, 8936);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_9124_9137(System.Management.Automation.SessionStateException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 9124, 9137);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_9082_9166(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.SessionStateException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 9082, 9166);
return return_v;
}


int
f_1214_9049_9167(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 9049, 9167);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_9345_9369(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 9345, 9369);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_9303_9409(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 9303, 9409);
return return_v;
}


int
f_1214_9270_9410(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 9270, 9410);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,7934,9437);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,7934,9437);
}
		}

protected override void GetChildItems(string path, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,9856,13773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,9945,9988);

CommandOrigin 
origin = f_1214_9968_9987(f_1214_9968_9980(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10002,13762) || true) && (f_1214_10006_10032(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,10002,13762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10066,10096);

IDictionary 
dictionary = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10160,10196);

dictionary = f_1214_10173_10195(this);
                }
                catch (SecurityException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,10233,10583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10301,10535);

f_1214_10301_10534(this, f_1214_10338_10533(e, "GetTableSecurityException", ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10557,10564);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,10233,10583);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10669,10755);

List<DictionaryEntry> 
sortedEntries = f_1214_10707_10754(f_1214_10733_10749(dictionary)+ 1)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10773,10903);
foreach(DictionaryEntry entry in f_1214_10807_10817_I(dictionary) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,10773,10903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10859,10884);

f_1214_10859_10883(                    sortedEntries, entry);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,10773,10903);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1214,1,131);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1214,1,131);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,10923,11364);

f_1214_10923_11363(
                sortedEntries, delegate (DictionaryEntry left, DictionaryEntry right)
                    {
                        string leftKey = (string)left.Key;
                        string rightKey = (string)right.Key;
                        IComparer<string> stringComparer = StringComparer.CurrentCultureIgnoreCase;
                        return stringComparer.Compare(leftKey, rightKey);
                    });
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,11430,12593);
foreach(DictionaryEntry entry in f_1214_11464_11477_I(sortedEntries) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,11430,12593);
                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,11571,11758) || true) && (f_1214_11575_11618(origin, entry.Value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,11571,11758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,11676,11731);

f_1214_11676_11730(this, entry.Value, entry.Key, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,11571,11758);
}
                    }
                    catch (PSArgumentException argException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,11803,12115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,11892,12057);

f_1214_11892_12056(this, f_1214_11933_12055(f_1214_11983_12007(argException), argException));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,12085,12092);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,11803,12115);
                    }
                    catch (SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,12137,12574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,12229,12518);

f_1214_12229_12517(this, f_1214_12270_12516(securityException, "GetItemSecurityException", ErrorCategory.PermissionDenied, (string)entry.Key));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,12544,12551);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,12137,12574);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,11430,12593);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1214,1,1164);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1214,1,1164);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1214,10002,13762);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,10002,13762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,12659,12678);

object 
item = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,12742,12775);

item = f_1214_12749_12774(this, path);
                }
                catch (PSArgumentException argException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,12812,13096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,12893,13046);

f_1214_12893_13045(this, f_1214_12930_13044(f_1214_12976_13000(argException), argException));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,13070,13077);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,12812,13096);
                }
                catch (SecurityException securityException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,13114,13502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,13198,13454);

f_1214_13198_13453(this, f_1214_13235_13452(securityException, "GetItemSecurityException", ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,13476,13483);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,13114,13502);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,13522,13747) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,13522,13747);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,13580,13728) || true) && (f_1214_13584_13620(origin, item))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,13580,13728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,13670,13705);

f_1214_13670_13704(this, item, path, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,13580,13728);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,13522,13747);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,10002,13762);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,9856,13773);

System.Management.Automation.CmdletProviderContext
f_1214_9968_9980(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 9968, 9980);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1214_9968_9987(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 9968, 9987);
return return_v;
}


bool
f_1214_10006_10032(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10006, 10032);
return return_v;
}


System.Collections.IDictionary
f_1214_10173_10195(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param)
{
var return_v = this_param.GetSessionStateTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10173, 10195);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_10338_10533(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10338, 10533);
return return_v;
}


int
f_1214_10301_10534(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10301, 10534);
return 0;
}


int
f_1214_10733_10749(System.Collections.IDictionary
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 10733, 10749);
return return_v;
}


System.Collections.Generic.List<System.Collections.DictionaryEntry>
f_1214_10707_10754(int
capacity)
{
var return_v = new System.Collections.Generic.List<System.Collections.DictionaryEntry>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10707, 10754);
return return_v;
}


int
f_1214_10859_10883(System.Collections.Generic.List<System.Collections.DictionaryEntry>
this_param,System.Collections.DictionaryEntry
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10859, 10883);
return 0;
}


System.Collections.IDictionary
f_1214_10807_10817_I(System.Collections.IDictionary
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10807, 10817);
return return_v;
}


int
f_1214_10923_11363(System.Collections.Generic.List<System.Collections.DictionaryEntry>
this_param,System.Comparison<System.Collections.DictionaryEntry>
comparison)
{
this_param.Sort( comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 10923, 11363);
return 0;
}


bool
f_1214_11575_11618(System.Management.Automation.CommandOrigin
origin,object
valueToCheck)
{
var return_v = SessionState.IsVisible( origin, valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 11575, 11618);
return return_v;
}


int
f_1214_11676_11730(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,object
item,object
path,bool
isContainer)
{
this_param.WriteItemObject( item, (string)path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 11676, 11730);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_11983_12007(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 11983, 12007);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_11933_12055(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 11933, 12055);
return return_v;
}


int
f_1214_11892_12056(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 11892, 12056);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_12270_12516(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 12270, 12516);
return return_v;
}


int
f_1214_12229_12517(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 12229, 12517);
return 0;
}


System.Collections.Generic.List<System.Collections.DictionaryEntry>
f_1214_11464_11477_I(System.Collections.Generic.List<System.Collections.DictionaryEntry>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 11464, 11477);
return return_v;
}


object
f_1214_12749_12774(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
var return_v = this_param.GetSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 12749, 12774);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_12976_13000(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 12976, 13000);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_12930_13044(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 12930, 13044);
return return_v;
}


int
f_1214_12893_13045(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 12893, 13045);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_13235_13452(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 13235, 13452);
return return_v;
}


int
f_1214_13198_13453(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 13198, 13453);
return 0;
}


bool
f_1214_13584_13620(System.Management.Automation.CommandOrigin
origin,object
valueToCheck)
{
var return_v = SessionState.IsVisible( origin, valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 13584, 13620);
return return_v;
}


int
f_1214_13670_13704(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,object
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 13670, 13704);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,9856,13773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,9856,13773);
}
		}

protected override void GetChildNames(string path, ReturnContainers returnContainers)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,14112,16945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,14222,14265);

CommandOrigin 
origin = f_1214_14245_14264(f_1214_14245_14257(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,14279,16934) || true) && (f_1214_14283_14309(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,14279,16934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,14343,14373);

IDictionary 
dictionary = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,14437,14473);

dictionary = f_1214_14450_14472(this);
                }
                catch (SecurityException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,14510,14865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,14578,14817);

f_1214_14578_14816(this, f_1214_14615_14815(e, "GetChildNamesSecurityException", ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,14839,14846);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,14510,14865);
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,14942,16100);
foreach(DictionaryEntry entry in f_1214_14976_14986_I(dictionary) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,14942,16100);
                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,15080,15265) || true) && (f_1214_15084_15127(origin, entry.Value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,15080,15265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,15185,15238);

f_1214_15185_15237(this, entry.Key, entry.Key, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,15080,15265);
}
                    }
                    catch (PSArgumentException argException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,15310,15622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,15399,15564);

f_1214_15399_15563(this, f_1214_15440_15562(f_1214_15490_15514(argException), argException));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,15592,15599);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,15310,15622);
                    }
                    catch (SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,15644,16081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,15736,16025);

f_1214_15736_16024(this, f_1214_15777_16023(securityException, "GetItemSecurityException", ErrorCategory.PermissionDenied, (string)entry.Key));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16051,16058);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,15644,16081);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,14942,16100);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1214,1,1159);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1214,1,1159);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1214,14279,16934);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,14279,16934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16166,16185);

object 
item = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16249,16282);

item = f_1214_16256_16281(this, path);
                }
                catch (SecurityException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,16319,16674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16387,16626);

f_1214_16387_16625(this, f_1214_16424_16624(e, "GetChildNamesSecurityException", ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16648,16655);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,16319,16674);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16694,16919) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,16694,16919);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16752,16900) || true) && (f_1214_16756_16792(origin, item))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,16752,16900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,16842,16877);

f_1214_16842_16876(this, path, path, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,16752,16900);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,16694,16919);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,14279,16934);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,14112,16945);

System.Management.Automation.CmdletProviderContext
f_1214_14245_14257(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 14245, 14257);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1214_14245_14264(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 14245, 14264);
return return_v;
}


bool
f_1214_14283_14309(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 14283, 14309);
return return_v;
}


System.Collections.IDictionary
f_1214_14450_14472(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param)
{
var return_v = this_param.GetSessionStateTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 14450, 14472);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_14615_14815(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 14615, 14815);
return return_v;
}


int
f_1214_14578_14816(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 14578, 14816);
return 0;
}


bool
f_1214_15084_15127(System.Management.Automation.CommandOrigin
origin,object
valueToCheck)
{
var return_v = SessionState.IsVisible( origin, valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 15084, 15127);
return return_v;
}


int
f_1214_15185_15237(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,object
item,object
path,bool
isContainer)
{
this_param.WriteItemObject( item, (string)path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 15185, 15237);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_15490_15514(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 15490, 15514);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_15440_15562(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 15440, 15562);
return return_v;
}


int
f_1214_15399_15563(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 15399, 15563);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_15777_16023(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 15777, 16023);
return return_v;
}


int
f_1214_15736_16024(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 15736, 16024);
return 0;
}


System.Collections.IDictionary
f_1214_14976_14986_I(System.Collections.IDictionary
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 14976, 14986);
return return_v;
}


object
f_1214_16256_16281(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
var return_v = this_param.GetSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 16256, 16281);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_16424_16624(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 16424, 16624);
return return_v;
}


int
f_1214_16387_16625(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 16387, 16625);
return 0;
}


bool
f_1214_16756_16792(System.Management.Automation.CommandOrigin
origin,object
valueToCheck)
{
var return_v = SessionState.IsVisible( origin, valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 16756, 16792);
return return_v;
}


int
f_1214_16842_16876(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
item,string
path,bool
isContainer)
{
this_param.WriteItemObject( (object)item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 16842, 16876);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,14112,16945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,14112,16945);
}
		}

protected override bool HasChildItems(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,17285,18046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,17360,17380);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,17396,18005) || true) && (f_1214_17400_17426(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,17396,18005);
                try
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,17504,17627) || true) && (f_1214_17508_17536(f_1214_17508_17530(this))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,17504,17627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,17590,17604);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,17504,17627);
}
                }
                catch (SecurityException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,17664,17990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,17732,17971);

f_1214_17732_17970(this, f_1214_17769_17969(e, "HasChildItemsSecurityException", ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,17664,17990);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,17396,18005);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,18021,18035);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,17285,18046);

bool
f_1214_17400_17426(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 17400, 17426);
return return_v;
}


System.Collections.IDictionary
f_1214_17508_17530(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param)
{
var return_v = this_param.GetSessionStateTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 17508, 17530);
return return_v;
}


int
f_1214_17508_17536(System.Collections.IDictionary
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 17508, 17536);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_17769_17969(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 17769, 17969);
return return_v;
}


int
f_1214_17732_17970(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 17732, 17970);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,17285,18046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,17285,18046);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool ItemExists(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,18447,19342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,18519,18539);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,18555,19301) || true) && (f_1214_18559_18585(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,18555,19301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,18619,18633);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,18555,19301);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,18555,19301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,18699,18718);

object 
item = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,18782,18815);

item = f_1214_18789_18814(this, path);
                }
                catch (SecurityException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,18852,19175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,18920,19156);

f_1214_18920_19155(this, f_1214_18957_19154(e, "ItemExistsSecurityException", ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,18852,19175);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,19195,19286) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,19195,19286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,19253,19267);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,19195,19286);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,18555,19301);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,19317,19331);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,18447,19342);

bool
f_1214_18559_18585(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 18559, 18585);
return return_v;
}


object
f_1214_18789_18814(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
var return_v = this_param.GetSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 18789, 18814);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_18957_19154(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 18957, 19154);
return return_v;
}


int
f_1214_18920_19155(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 18920, 19155);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,18447,19342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,18447,19342);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool IsValidPath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,19817,19936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,19890,19925);

return !f_1214_19898_19924(path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,19817,19936);

bool
f_1214_19898_19924(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 19898, 19924);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,19817,19936);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,19817,19936);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void RemoveItem(string path, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,20232,22471);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,20318,22460) || true) && (f_1214_20322_20348(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,20318,22460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,20382,20460);

Exception 
e =
f_1214_20417_20459("path")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,20478,20653);

f_1214_20478_20652(this, f_1214_20489_20651(e, "RemoveItemNullPath", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,20318,22460);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,20318,22460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,20779,20844);

string 
action = f_1214_20795_20843()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,20864,20949);

string 
resourceTemplate = f_1214_20890_20948()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,20969,21143);

string 
resource =
f_1214_21008_21142(f_1214_21048_21067(f_1214_21048_21052()), resourceTemplate, path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,21163,22445) || true) && (f_1214_21167_21198(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,21163,22445);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,21292,21321);

f_1214_21292_21320(this, path);
                    }
                    catch (SessionStateException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,21366,21645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,21446,21589);

f_1214_21446_21588(this, f_1214_21487_21587(f_1214_21537_21550(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,21615,21622);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,21366,21645);
                    }
                    catch (SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,21667,22094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,21759,22038);

f_1214_21759_22037(this, f_1214_21800_22036(securityException, "RemoveItemSecurityException", ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,22064,22071);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,21667,22094);
                    }
                    catch (PSArgumentException argException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,22116,22426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,22205,22370);

f_1214_22205_22369(this, f_1214_22246_22368(f_1214_22296_22320(argException), argException));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,22396,22403);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,22116,22426);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,21163,22445);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,20318,22460);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,20232,22471);

bool
f_1214_20322_20348(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 20322, 20348);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_20417_20459(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 20417, 20459);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_20489_20651(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 20489, 20651);
return return_v;
}


int
f_1214_20478_20652(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 20478, 20652);
return 0;
}


string
f_1214_20795_20843()
{
var return_v = SessionStateProviderBaseStrings.RemoveItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 20795, 20843);
return return_v;
}


string
f_1214_20890_20948()
{
var return_v = SessionStateProviderBaseStrings.RemoveItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 20890, 20948);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1214_21048_21052()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 21048, 21052);
return return_v;
}


System.Globalization.CultureInfo
f_1214_21048_21067(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 21048, 21067);
return return_v;
}


string
f_1214_21008_21142(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 21008, 21142);
return return_v;
}


bool
f_1214_21167_21198(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 21167, 21198);
return return_v;
}


int
f_1214_21292_21320(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
this_param.RemoveSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 21292, 21320);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_21537_21550(System.Management.Automation.SessionStateException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 21537, 21550);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_21487_21587(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.SessionStateException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 21487, 21587);
return return_v;
}


int
f_1214_21446_21588(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 21446, 21588);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_21800_22036(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 21800, 22036);
return return_v;
}


int
f_1214_21759_22037(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 21759, 22037);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_22296_22320(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 22296, 22320);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_22246_22368(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 22246, 22368);
return return_v;
}


int
f_1214_22205_22369(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 22205, 22369);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,20232,22471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,20232,22471);
}
		}

protected override void NewItem(string path, string type, object newItem)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,22884,25029);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,22982,23354) || true) && (f_1214_22986_23012(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,22982,23354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23046,23124);

Exception 
e =
f_1214_23081_23123("path")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23142,23314);

f_1214_23142_23313(this, f_1214_23153_23312(e, "NewItemNullPath", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23332,23339);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,22982,23354);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23370,23819) || true) && (newItem == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,23370,23819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23423,23529);

ArgumentNullException 
argException =
f_1214_23481_23528("value")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23549,23779);

f_1214_23549_23778(this, f_1214_23582_23777(argException, "NewItemValueNotSpecified", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23797,23804);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,23370,23819);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23835,25018) || true) && (f_1214_23839_23855(this, path)&&(DynAbs.Tracing.TraceSender.Expression_True(1214, 23839, 23865)&&f_1214_23859_23865_M(!Force)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,23835,25018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,23899,24154);

PSArgumentException 
e =
                    (PSArgumentException)
f_1214_23987_24153("path", f_1214_24081_24121(), path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,24174,24293);

f_1214_24174_24292(this, f_1214_24207_24291(f_1214_24249_24262(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,24311,24318);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,23835,25018);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,23835,25018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,24441,24503);

string 
action = f_1214_24457_24502()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,24523,24605);

string 
resourceTemplate = f_1214_24549_24604()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,24625,24864);

string 
resource =
f_1214_24664_24863(f_1214_24704_24723(f_1214_24704_24708()), resourceTemplate, path, type, newItem)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,24884,25003) || true) && (f_1214_24888_24919(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,24884,25003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,24961,24984);

f_1214_24961_24983(this, path, newItem);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,24884,25003);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,23835,25018);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,22884,25029);

bool
f_1214_22986_23012(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 22986, 23012);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_23081_23123(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23081, 23123);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_23153_23312(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23153, 23312);
return return_v;
}


int
f_1214_23142_23313(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23142, 23313);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1214_23481_23528(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23481, 23528);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_23582_23777(System.ArgumentNullException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23582, 23777);
return return_v;
}


int
f_1214_23549_23778(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23549, 23778);
return 0;
}


bool
f_1214_23839_23855(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23839, 23855);
return return_v;
}


bool
f_1214_23859_23865_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 23859, 23865);
return return_v;
}


string
f_1214_24081_24121()
{
var return_v =                         SessionStateStrings.NewItemAlreadyExists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 24081, 24121);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_23987_24153(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 23987, 24153);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_24249_24262(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 24249, 24262);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_24207_24291(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 24207, 24291);
return return_v;
}


int
f_1214_24174_24292(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 24174, 24292);
return 0;
}


string
f_1214_24457_24502()
{
var return_v = SessionStateProviderBaseStrings.NewItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 24457, 24502);
return return_v;
}


string
f_1214_24549_24604()
{
var return_v = SessionStateProviderBaseStrings.NewItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 24549, 24604);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1214_24704_24708()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 24704, 24708);
return return_v;
}


System.Globalization.CultureInfo
f_1214_24704_24723(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 24704, 24723);
return return_v;
}


string
f_1214_24664_24863(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1,object
arg2)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1, arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 24664, 24863);
return return_v;
}


bool
f_1214_24888_24919(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 24888, 24919);
return return_v;
}


int
f_1214_24961_24983(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name,object
value)
{
this_param.SetItem( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 24961, 24983);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,22884,25029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,22884,25029);
}
		}

protected override void CopyItem(string path, string copyPath, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,25410,28588);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,25511,25884) || true) && (f_1214_25515_25541(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,25511,25884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,25575,25653);

Exception 
e =
f_1214_25610_25652("path")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,25671,25844);

f_1214_25671_25843(this, f_1214_25682_25842(e, "CopyItemNullPath", ErrorCategory.InvalidArgument, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,25862,25869);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,25511,25884);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26041,26215) || true) && (f_1214_26045_26075(copyPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,26041,26215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26161,26175);

f_1214_26161_26174(this, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26193,26200);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,26041,26215);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26231,26250);

object 
item = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26302,26335);

item = f_1214_26309_26334(this, path);
            }
            catch (SecurityException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,26364,26678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26424,26638);

f_1214_26424_26637(this, f_1214_26457_26636(e, "CopyItemSecurityException", ErrorCategory.ReadError, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26656,26663);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,26364,26678);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26694,28577) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,26694,28577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26801,26864);

string 
action = f_1214_26817_26863()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26884,26967);

string 
resourceTemplate = f_1214_26910_26966()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,26987,27196);

string 
resource =
f_1214_27026_27195(f_1214_27066_27085(f_1214_27066_27070()), resourceTemplate, path, copyPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,27216,28078) || true) && (f_1214_27220_27251(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,27216,28078);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,27345,27403);

f_1214_27345_27402(this, copyPath, f_1214_27375_27395(this, item), true);
                    }
                    catch (SessionStateException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,27448,27727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,27528,27671);

f_1214_27528_27670(this, f_1214_27569_27669(f_1214_27619_27632(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,27697,27704);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,27448,27727);
                    }
                    catch (PSArgumentException argException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,27749,28059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,27838,28003);

f_1214_27838_28002(this, f_1214_27879_28001(f_1214_27929_27953(argException), argException));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,28029,28036);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,27749,28059);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,27216,28078);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,26694,28577);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,26694,28577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,28144,28398);

PSArgumentException 
e =
                    (PSArgumentException)
f_1214_28232_28397("path", f_1214_28326_28365(), path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,28418,28537);

f_1214_28418_28536(this, f_1214_28451_28535(f_1214_28493_28506(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,28555,28562);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,26694,28577);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,25410,28588);

bool
f_1214_25515_25541(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 25515, 25541);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_25610_25652(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 25610, 25652);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_25682_25842(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 25682, 25842);
return return_v;
}


int
f_1214_25671_25843(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 25671, 25843);
return 0;
}


bool
f_1214_26045_26075(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 26045, 26075);
return return_v;
}


int
f_1214_26161_26174(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
this_param.GetItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 26161, 26174);
return 0;
}


object
f_1214_26309_26334(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
var return_v = this_param.GetSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 26309, 26334);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_26457_26636(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 26457, 26636);
return return_v;
}


int
f_1214_26424_26637(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 26424, 26637);
return 0;
}


string
f_1214_26817_26863()
{
var return_v = SessionStateProviderBaseStrings.CopyItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 26817, 26863);
return return_v;
}


string
f_1214_26910_26966()
{
var return_v = SessionStateProviderBaseStrings.CopyItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 26910, 26966);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1214_27066_27070()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 27066, 27070);
return return_v;
}


System.Globalization.CultureInfo
f_1214_27066_27085(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 27066, 27085);
return return_v;
}


string
f_1214_27026_27195(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27026, 27195);
return return_v;
}


bool
f_1214_27220_27251(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27220, 27251);
return return_v;
}


object
f_1214_27375_27395(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,object
item)
{
var return_v = this_param.GetValueOfItem( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27375, 27395);
return return_v;
}


int
f_1214_27345_27402(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name,object
value,bool
writeItem)
{
this_param.SetSessionStateItem( name, value, writeItem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27345, 27402);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_27619_27632(System.Management.Automation.SessionStateException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 27619, 27632);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_27569_27669(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.SessionStateException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27569, 27669);
return return_v;
}


int
f_1214_27528_27670(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27528, 27670);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_27929_27953(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 27929, 27953);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_27879_28001(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27879, 28001);
return return_v;
}


int
f_1214_27838_28002(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 27838, 28002);
return 0;
}


string
f_1214_28326_28365()
{
var return_v =                         SessionStateStrings.CopyItemDoesntExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 28326, 28365);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_28232_28397(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 28232, 28397);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_28493_28506(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 28493, 28506);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_28451_28535(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 28451, 28535);
return return_v;
}


int
f_1214_28418_28536(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 28418, 28536);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,25410,28588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,25410,28588);
}
		}

protected override void RenameItem(string name, string newName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,28882,34205);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,28970,29345) || true) && (f_1214_28974_29000(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,28970,29345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29034,29112);

Exception 
e =
f_1214_29069_29111("name")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29130,29305);

f_1214_29130_29304(this, f_1214_29141_29303(e, "RenameItemNullPath", ErrorCategory.InvalidArgument, name));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29323,29330);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,28970,29345);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29361,29380);

object 
item = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29432,29465);

item = f_1214_29439_29464(this, name);
            }
            catch (SecurityException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,29494,29810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29554,29770);

f_1214_29554_29769(this, f_1214_29587_29768(e, "RenameItemSecurityException", ErrorCategory.ReadError, name));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29788,29795);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,29494,29810);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29826,34194) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,29826,34194);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29876,33693) || true) && (f_1214_29880_29899(this, newName)&&(DynAbs.Tracing.TraceSender.Expression_True(1214, 29880, 29909)&&f_1214_29903_29909_M(!Force)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,29876,33693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,29951,30232);

PSArgumentException 
e =
                        (PSArgumentException)
f_1214_30047_30231("newName", f_1214_30152_30192(), newName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,30256,30387);

f_1214_30256_30386(this, f_1214_30293_30385(f_1214_30339_30352(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,30409,30416);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,29876,33693);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,29876,33693);
                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,30550,33350) || true) && (f_1214_30554_30573(this, item))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,30550,33350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,30700,30765);

string 
action = f_1214_30716_30764()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,30797,30882);

string 
resourceTemplate = f_1214_30823_30881()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,30914,31182);

string 
resource =
f_1214_30965_31181(f_1214_31017_31036(f_1214_31017_31021()), resourceTemplate, name, newName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,31214,33323) || true) && (f_1214_31218_31249(this, resource, action))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,31214,33323);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,31315,31643) || true) && (f_1214_31319_31383(name, newName, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,31315,31643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,31546,31563);

f_1214_31546_31562(this, newName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,31601,31608);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,31315,31643);
}

                                try
                                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,31755,31796);

f_1214_31755_31795(this, newName, item, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,31834,31863);

f_1214_31834_31862(this, name);
                                }
                                catch (SessionStateException e)
                                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,31932,32295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,32036,32215);

f_1214_32036_32214(this, f_1214_32089_32213(f_1214_32151_32164(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,32253,32260);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,31932,32295);
                                }
                                catch (PSArgumentException argException)
                                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,32329,32723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,32442,32643);

f_1214_32442_32642(this, f_1214_32495_32641(f_1214_32557_32581(argException), argException));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,32681,32688);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,32329,32723);
                                }
                                catch (SecurityException securityException)
                                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,32757,33292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,32873,33212);

f_1214_32873_33211(this, f_1214_32926_33210(securityException, "RenameItemSecurityException", ErrorCategory.PermissionDenied, name));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,33250,33257);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,32757,33292);
                                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,31214,33323);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,30550,33350);
}
                    }
                    catch (SessionStateException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1214,33395,33674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,33475,33618);

f_1214_33475_33617(this, f_1214_33516_33616(f_1214_33566_33579(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,33644,33651);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1214,33395,33674);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,29876,33693);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,29826,34194);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,29826,34194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,33759,34015);

PSArgumentException 
e =
                    (PSArgumentException)
f_1214_33847_34014("name", f_1214_33941_33982(), name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,34035,34154);

f_1214_34035_34153(this, f_1214_34068_34152(f_1214_34110_34123(e), e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,34172,34179);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,29826,34194);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,28882,34205);

bool
f_1214_28974_29000(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 28974, 29000);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_29069_29111(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 29069, 29111);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_29141_29303(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 29141, 29303);
return return_v;
}


int
f_1214_29130_29304(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 29130, 29304);
return 0;
}


object
f_1214_29439_29464(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
var return_v = this_param.GetSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 29439, 29464);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_29587_29768(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 29587, 29768);
return return_v;
}


int
f_1214_29554_29769(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 29554, 29769);
return 0;
}


bool
f_1214_29880_29899(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 29880, 29899);
return return_v;
}


bool
f_1214_29903_29909_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 29903, 29909);
return return_v;
}


string
f_1214_30152_30192()
{
var return_v =                             SessionStateStrings.NewItemAlreadyExists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 30152, 30192);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_30047_30231(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 30047, 30231);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_30339_30352(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 30339, 30352);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_30293_30385(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 30293, 30385);
return return_v;
}


int
f_1214_30256_30386(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 30256, 30386);
return 0;
}


bool
f_1214_30554_30573(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,object
item)
{
var return_v = this_param.CanRenameItem( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 30554, 30573);
return return_v;
}


string
f_1214_30716_30764()
{
var return_v = SessionStateProviderBaseStrings.RenameItemAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 30716, 30764);
return return_v;
}


string
f_1214_30823_30881()
{
var return_v = SessionStateProviderBaseStrings.RenameItemResourceTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 30823, 30881);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1214_31017_31021()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 31017, 31021);
return return_v;
}


System.Globalization.CultureInfo
f_1214_31017_31036(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 31017, 31036);
return return_v;
}


string
f_1214_30965_31181(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 30965, 31181);
return return_v;
}


bool
f_1214_31218_31249(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 31218, 31249);
return return_v;
}


bool
f_1214_31319_31383(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 31319, 31383);
return return_v;
}


int
f_1214_31546_31562(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
this_param.GetItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 31546, 31562);
return 0;
}


int
f_1214_31755_31795(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name,object
value,bool
writeItem)
{
this_param.SetSessionStateItem( name, value, writeItem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 31755, 31795);
return 0;
}


int
f_1214_31834_31862(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
this_param.RemoveSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 31834, 31862);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_32151_32164(System.Management.Automation.SessionStateException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 32151, 32164);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_32089_32213(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.SessionStateException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 32089, 32213);
return return_v;
}


int
f_1214_32036_32214(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 32036, 32214);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_32557_32581(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 32557, 32581);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_32495_32641(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 32495, 32641);
return return_v;
}


int
f_1214_32442_32642(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 32442, 32642);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_32926_33210(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 32926, 33210);
return return_v;
}


int
f_1214_32873_33211(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 32873, 33211);
return 0;
}


System.Management.Automation.ErrorRecord
f_1214_33566_33579(System.Management.Automation.SessionStateException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 33566, 33579);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_33516_33616(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.SessionStateException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 33516, 33616);
return return_v;
}


int
f_1214_33475_33617(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 33475, 33617);
return 0;
}


string
f_1214_33941_33982()
{
var return_v =                         SessionStateStrings.RenameItemDoesntExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 33941, 33982);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_33847_34014(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 33847, 34014);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_34110_34123(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 34110, 34123);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1214_34068_34152(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSArgumentException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 34068, 34152);
return return_v;
}


int
f_1214_34035_34153(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 34035, 34153);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,28882,34205);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,28882,34205);
}
		}

public IContentReader GetContentReader(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,34698,34852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,34774,34841);

return f_1214_34781_34840(path, this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,34698,34852);

Microsoft.PowerShell.Commands.SessionStateProviderBaseContentReaderWriter
f_1214_34781_34840(string
path,Microsoft.PowerShell.Commands.SessionStateProviderBase
provider)
{
var return_v = new Microsoft.PowerShell.Commands.SessionStateProviderBaseContentReaderWriter( path, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 34781, 34840);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,34698,34852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,34698,34852);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public IContentWriter GetContentWriter(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,35239,35393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,35315,35382);

return f_1214_35322_35381(path, this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,35239,35393);

Microsoft.PowerShell.Commands.SessionStateProviderBaseContentReaderWriter
f_1214_35322_35381(string
path,Microsoft.PowerShell.Commands.SessionStateProviderBase
provider)
{
var return_v = new Microsoft.PowerShell.Commands.SessionStateProviderBaseContentReaderWriter( path, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 35322, 35381);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,35239,35393);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,35239,35393);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void ClearContent(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,35707,35913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,35769,35902);

throw
f_1214_35792_35901(f_1214_35853_35900());
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,35707,35913);

string
f_1214_35853_35900()
{
var return_v =                     SessionStateStrings.IContent_Clear_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 35853, 35900);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1214_35792_35901(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 35792, 35901);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,35707,35913);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,35707,35913);
}
		}

public object GetContentReaderDynamicParameters(string path) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,36246,36323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,36309,36321);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,36246,36323);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,36246,36323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,36246,36323);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object GetContentWriterDynamicParameters(string path) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,36495,36572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,36558,36570);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,36495,36572);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,36495,36572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,36495,36572);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object ClearContentDynamicParameters(string path) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,36744,36817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,36803,36815);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,36744,36817);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,36744,36817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,36744,36817);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public SessionStateProviderBase()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1214,644,36866);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1214,644,36866);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,644,36866);
}


static SessionStateProviderBase()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1214,644,36866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,1092,1237);
s_tracer = f_1214_1116_1237("SessionStateProvider", "Providers that produce a view of session state data.");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1214,644,36866);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,644,36866);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1214,644,36866);

static System.Management.Automation.PSTraceSource
f_1214_1116_1237(string
name,string
description)
{
var return_v = Dbg.PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 1116, 1237);
return return_v;
}

}
public class SessionStateProviderBaseContentReaderWriter : IContentReader, IContentWriter
{
internal SessionStateProviderBaseContentReaderWriter(string path, SessionStateProviderBase provider)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1214,37896,38366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38393,38398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38442,38451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39685,39697);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38021,38149) || true) && (f_1214_38025_38051(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,38021,38149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38085,38134);

throw f_1214_38091_38133("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,38021,38149);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38165,38291) || true) && (provider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,38165,38291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38219,38276);

throw f_1214_38225_38275("provider");
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,38165,38291);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38307,38320);

_path = path;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,38334,38355);

_provider = provider;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1214,37896,38366);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,37896,38366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,37896,38366);
}
		}

private string _path;

private SessionStateProviderBase _provider;

public IList Read(long readCount)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,39005,39660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39063,39083);

IList 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39099,39619) || true) && (!_contentRead)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,39099,39619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39150,39201);

object 
item = f_1214_39164_39200(_provider, _path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39221,39604) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,39221,39604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39279,39338);

object 
getItemValueResult = f_1214_39307_39337(_provider, item)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39362,39541) || true) && (getItemValueResult != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,39362,39541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39442,39518);

result = getItemValueResult as IList ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.IList>(1214, 39451, 39517)??new object[] { getItemValueResult });
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,39362,39541);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39565,39585);

_contentRead = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,39221,39604);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,39099,39619);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,39635,39649);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,39005,39660);

object
f_1214_39164_39200(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name)
{
var return_v = this_param.GetSessionStateItem( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 39164, 39200);
return return_v;
}


object
f_1214_39307_39337(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,object
item)
{
var return_v = this_param.GetValueOfItem( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 39307, 39337);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,39005,39660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,39005,39660);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool _contentRead;

public IList Write(IList content)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,40258,40768);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,40316,40440) || true) && (content == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,40316,40440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,40369,40425);

throw f_1214_40375_40424("content");
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,40316,40440);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,40517,40545);

object 
valueToSet = content
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,40559,40654) || true) && (f_1214_40563_40576(content)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1214,40559,40654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,40615,40639);

valueToSet = f_1214_40628_40638(content, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1214,40559,40654);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,40670,40726);

f_1214_40670_40725(
            _provider, _path, valueToSet, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,40742,40757);

return content;
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,40258,40768);

System.Management.Automation.PSArgumentNullException
f_1214_40375_40424(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 40375, 40424);
return return_v;
}


int
f_1214_40563_40576(System.Collections.IList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 40563, 40576);
return return_v;
}


object
f_1214_40628_40638(System.Collections.IList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 40628, 40638);
return return_v;
}


int
f_1214_40670_40725(Microsoft.PowerShell.Commands.SessionStateProviderBase
this_param,string
name,object
value,bool
writeItem)
{
this_param.SetSessionStateItem( name, value, writeItem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 40670, 40725);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,40258,40768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,40258,40768);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Seek(long offset, SeekOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,41236,41452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,41309,41441);

throw
f_1214_41332_41440(f_1214_41393_41439());
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,41236,41452);

string
f_1214_41393_41439()
{
var return_v =                     SessionStateStrings.IContent_Seek_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1214, 41393, 41439);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1214_41332_41440(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 41332, 41440);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,41236,41452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,41236,41452);
}
		}

public void Close() 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,41628,41651);
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,41628,41651);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,41628,41651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,41628,41651);
}
		}

public void Dispose() 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1214,41827,41888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,41851,41859);

f_1214_41851_41858(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1214,41860,41886);

f_1214_41860_41885(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1214,41827,41888);

int
f_1214_41851_41858(Microsoft.PowerShell.Commands.SessionStateProviderBaseContentReaderWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 41851, 41858);
return 0;
}


int
f_1214_41860_41885(Microsoft.PowerShell.Commands.SessionStateProviderBaseContentReaderWriter
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 41860, 41885);
return 0;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1214,41827,41888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,41827,41888);
}
		}

static SessionStateProviderBaseContentReaderWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1214,37006,41895);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1214,37006,41895);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1214,37006,41895);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1214,37006,41895);

bool
f_1214_38025_38051(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 38025, 38051);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1214_38091_38133(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 38091, 38133);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1214_38225_38275(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1214, 38225, 38275);
return return_v;
}

}
}

#pragma warning restore 56506
