// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation.Runspaces
{
[Serializable]
    public class PSSnapInException : RuntimeException
{
internal PSSnapInException(string PSSnapin, string message)
            : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1232,1022,1226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4653,4669);
this._warning = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4702,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4738,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5585,5609);
this._PSSnapin = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5635,5657);
this._reason = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,1128,1149);

_PSSnapin = PSSnapin;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,1163,1181);

_reason = message;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,1195,1215);

f_1232_1195_1214(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1232,1022,1226);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,1022,1226);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,1022,1226);
}
		}

internal PSSnapInException(string PSSnapin, string message, bool warning)
            : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1232,1583,1834);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4653,4669);
this._warning = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4702,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4738,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5585,5609);
this._PSSnapin = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5635,5657);
this._reason = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,1703,1724);

_PSSnapin = PSSnapin;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,1738,1756);

_reason = message;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,1770,1789);

_warning = warning;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,1803,1823);

f_1232_1803_1822(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1232,1583,1834);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,1583,1834);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,1583,1834);
}
		}

internal PSSnapInException(string PSSnapin, string message, Exception exception)
:base(f_1232_2281_2288_C(message) ,exception)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1232,2180,2423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4653,4669);
this._warning = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4702,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4738,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5585,5609);
this._PSSnapin = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5635,5657);
this._reason = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,2325,2346);

_PSSnapin = PSSnapin;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,2360,2378);

_reason = message;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,2392,2412);

f_1232_2392_2411(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1232,2180,2423);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,2180,2423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,2180,2423);
}
		}

public PSSnapInException() : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1232,2538,2595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4653,4669);
this._warning = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4702,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4738,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5585,5609);
this._PSSnapin = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5635,5657);
this._reason = string.Empty;DynAbs.Tracing.TraceSender.TraceExitConstructor(1232,2538,2595);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,2538,2595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,2538,2595);
}
		}

public PSSnapInException(string message)
:base(f_1232_2829_2836_C(message) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1232,2768,2859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4653,4669);
this._warning = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4702,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4738,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5585,5609);
this._PSSnapin = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5635,5657);
this._reason = string.Empty;DynAbs.Tracing.TraceSender.TraceExitConstructor(1232,2768,2859);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,2768,2859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,2768,2859);
}
		}

public PSSnapInException(string message, Exception innerException)
:base(f_1232_3186_3193_C(message) ,innerException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1232,3099,3232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4653,4669);
this._warning = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4702,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4738,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5585,5609);
this._PSSnapin = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5635,5657);
this._reason = string.Empty;DynAbs.Tracing.TraceSender.TraceExitConstructor(1232,3099,3232);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,3099,3232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,3099,3232);
}
		}

private void CreateErrorRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1232,3418,4628);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,3685,4617) || true) && (!f_1232_3690_3721(_PSSnapin)&&(DynAbs.Tracing.TraceSender.Expression_True(1232, 3689, 3755)&&!f_1232_3726_3755(_reason)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1232,3685,4617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,3789,3851);

Assembly 
currentAssembly = f_1232_3816_3850(typeof(PSSnapInException))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,3871,4602) || true) && (_warning)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1232,3871,4602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,3925,4066);

_errorRecord = f_1232_3940_4065(f_1232_3956_4000(this), "PSSnapInLoadWarning", ErrorCategory.ResourceUnavailable, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4088,4213);

_errorRecord.ErrorDetails = f_1232_4116_4212(f_1232_4133_4211(f_1232_4147_4190(), _PSSnapin, _reason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1232,3871,4602);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1232,3871,4602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4295,4436);

_errorRecord = f_1232_4310_4435(f_1232_4326_4370(this), "PSSnapInLoadFailure", ErrorCategory.ResourceUnavailable, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4458,4583);

_errorRecord.ErrorDetails = f_1232_4486_4582(f_1232_4503_4581(f_1232_4517_4560(), _PSSnapin, _reason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1232,3871,4602);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1232,3685,4617);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1232,3418,4628);

bool
f_1232_3690_3721(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 3690, 3721);
return return_v;
}


bool
f_1232_3726_3755(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 3726, 3755);
return return_v;
}


System.Reflection.Assembly
f_1232_3816_3850(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1232, 3816, 3850);
return return_v;
}


System.Management.Automation.ParentContainsErrorRecordException
f_1232_3956_4000(System.Management.Automation.Runspaces.PSSnapInException
wrapperException)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( (System.Exception)wrapperException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 3956, 4000);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1232_3940_4065(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 3940, 4065);
return return_v;
}


string
f_1232_4147_4190()
{
var return_v = ConsoleInfoErrorStrings.PSSnapInLoadWarning;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1232, 4147, 4190);
return return_v;
}


string
f_1232_4133_4211(string
format,string
arg0,string
arg1)
{
var return_v = string.Format( format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 4133, 4211);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1232_4116_4212(string
message)
{
var return_v = new System.Management.Automation.ErrorDetails( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 4116, 4212);
return return_v;
}


System.Management.Automation.ParentContainsErrorRecordException
f_1232_4326_4370(System.Management.Automation.Runspaces.PSSnapInException
wrapperException)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( (System.Exception)wrapperException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 4326, 4370);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1232_4310_4435(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 4310, 4435);
return return_v;
}


string
f_1232_4517_4560()
{
var return_v = ConsoleInfoErrorStrings.PSSnapInLoadFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1232, 4517, 4560);
return return_v;
}


string
f_1232_4503_4581(string
format,string
arg0,string
arg1)
{
var return_v = string.Format( format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 4503, 4581);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1232_4486_4582(string
message)
{
var return_v = new System.Management.Automation.ErrorDetails( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 4486, 4582);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,3418,4628);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,3418,4628);
}
		}

private bool _warning ;

private ErrorRecord _errorRecord;

private bool _isErrorRecordOriginallyNull;

public override ErrorRecord ErrorRecord
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1232,5080,5547);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5116,5492) || true) && (_errorRecord == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1232,5116,5492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5182,5218);

_isErrorRecordOriginallyNull = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5240,5473);

_errorRecord = f_1232_5255_5472(f_1232_5297_5341(this), "PSSnapInException", ErrorCategory.NotSpecified, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1232,5116,5492);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5512,5532);

return _errorRecord;
DynAbs.Tracing.TraceSender.TraceExitMethod(1232,5080,5547);

System.Management.Automation.ParentContainsErrorRecordException
f_1232_5297_5341(System.Management.Automation.Runspaces.PSSnapInException
wrapperException)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( (System.Exception)wrapperException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 5297, 5341);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1232_5255_5472(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 5255, 5472);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,5016,5558);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,5016,5558);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _PSSnapin ;

private string _reason ;

public override string Message
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1232,5818,6058);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5854,6003) || true) && (_errorRecord != null &&(DynAbs.Tracing.TraceSender.Expression_True(1232, 5858, 5911)&&!_isErrorRecordOriginallyNull))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1232,5854,6003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5953,5984);

return f_1232_5960_5983(_errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1232,5854,6003);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,6023,6043);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message,1232,6030,6042);
DynAbs.Tracing.TraceSender.TraceExitMethod(1232,5818,6058);

string
f_1232_5960_5983(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 5960, 5983);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,5763,6069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,5763,6069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected PSSnapInException(SerializationInfo info,
                                        StreamingContext context)
:base(f_1232_6481_6485_C(info) ,context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1232,6342,6655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4653,4669);
this._warning = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4702,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,4738,4766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5585,5609);
this._PSSnapin = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,5635,5657);
this._reason = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,6520,6559);

_PSSnapin = f_1232_6532_6558(info, "PSSnapIn");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,6573,6608);

_reason = f_1232_6583_6607(info, "Reason");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,6624,6644);

f_1232_6624_6643(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1232,6342,6655);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,6342,6655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,6342,6655);
}
		}

[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1232,6904,7385);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,7106,7224) || true) && (info == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1232,7106,7224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,7156,7209);

throw f_1232_7162_7208("info");
DynAbs.Tracing.TraceSender.TraceExitCondition(1232,7106,7224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,7240,7274);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info,context),1232,7240,7273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,7290,7327);

f_1232_7290_7326(
            info, "PSSnapIn", _PSSnapin);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1232,7341,7374);

f_1232_7341_7373(            info, "Reason", _reason);
DynAbs.Tracing.TraceSender.TraceExitMethod(1232,6904,7385);

System.Management.Automation.PSArgumentNullException
f_1232_7162_7208(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 7162, 7208);
return return_v;
}


int
f_1232_7290_7326(System.Runtime.Serialization.SerializationInfo
this_param,string
name,string
value)
{
this_param.AddValue( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 7290, 7326);
return 0;
}


int
f_1232_7341_7373(System.Runtime.Serialization.SerializationInfo
this_param,string
name,string
value)
{
this_param.AddValue( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 7341, 7373);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1232,6904,7385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,6904,7385);
}
		}

static PSSnapInException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1232,684,7428);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1232,684,7428);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1232,684,7428);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1232,684,7428);

int
f_1232_1195_1214(System.Management.Automation.Runspaces.PSSnapInException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 1195, 1214);
return 0;
}


int
f_1232_1803_1822(System.Management.Automation.Runspaces.PSSnapInException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 1803, 1822);
return 0;
}


int
f_1232_2392_2411(System.Management.Automation.Runspaces.PSSnapInException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 2392, 2411);
return 0;
}


static string
f_1232_2281_2288_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1232, 2180, 2423);
return return_v;
}


static string
f_1232_2829_2836_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1232, 2768, 2859);
return return_v;
}


static string
f_1232_3186_3193_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1232, 3099, 3232);
return return_v;
}


string?
f_1232_6532_6558(System.Runtime.Serialization.SerializationInfo
this_param,string
name)
{
var return_v = this_param.GetString( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 6532, 6558);
return return_v;
}


string?
f_1232_6583_6607(System.Runtime.Serialization.SerializationInfo
this_param,string
name)
{
var return_v = this_param.GetString( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 6583, 6607);
return return_v;
}


int
f_1232_6624_6643(System.Management.Automation.Runspaces.PSSnapInException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1232, 6624, 6643);
return 0;
}


static System.Runtime.Serialization.SerializationInfo
f_1232_6481_6485_C(System.Runtime.Serialization.SerializationInfo
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1232, 6342, 6655);
return return_v;
}

}
}

