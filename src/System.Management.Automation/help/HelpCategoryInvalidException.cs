// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56506

using System;
using System.Management.Automation;
using System.Runtime.Serialization;
using System.Reflection;
using System.Security.Permissions;

namespace Microsoft.PowerShell.Commands
{
[Serializable]
    public class HelpCategoryInvalidException : ArgumentException, IContainsErrorRecord
{
public HelpCategoryInvalidException(string helpCategory) : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1149,862,1026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2402,2414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2745,2818);
this._helpCategory = f_1149_2761_2818(System.Management.Automation.HelpCategory.None);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,952,981);

_helpCategory = helpCategory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,995,1015);

f_1149_995_1014(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1149,862,1026);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,862,1026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,862,1026);
}
		}

public HelpCategoryInvalidException() : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1149,1168,1270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2402,2414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2745,2818);
this._helpCategory = f_1149_2761_2818(System.Management.Automation.HelpCategory.None);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,1239,1259);

f_1149_1239_1258(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1149,1168,1270);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,1168,1270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,1168,1270);
}
		}

public HelpCategoryInvalidException(string helpCategory, Exception innerException) :base(f_1149_1699_1763_C((DynAbs.Tracing.TraceSender.Conditional_F1(1149, 1699, 1723)||(((innerException != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1149, 1726, 1748))||DynAbs.Tracing.TraceSender.Conditional_F3(1149, 1751, 1763)))?f_1149_1726_1748(innerException):string.Empty) ,innerException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1149,1592,1879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2402,2414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2745,2818);
this._helpCategory = f_1149_2761_2818(System.Management.Automation.HelpCategory.None);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,1805,1834);

_helpCategory = helpCategory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,1848,1868);

f_1149_1848_1867(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1149,1592,1879);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,1592,1879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,1592,1879);
}
		}

private void CreateErrorRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1149,2007,2370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2064,2201);

_errorRecord = f_1149_2079_2200(f_1149_2095_2139(this), "HelpCategoryInvalid", ErrorCategory.InvalidArgument, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2215,2359);

_errorRecord.ErrorDetails = f_1149_2243_2358(f_1149_2260_2305(typeof(HelpCategoryInvalidException)), "HelpErrors", "HelpCategoryInvalid", _helpCategory);
DynAbs.Tracing.TraceSender.TraceExitMethod(1149,2007,2370);

System.Management.Automation.ParentContainsErrorRecordException
f_1149_2095_2139(Microsoft.PowerShell.Commands.HelpCategoryInvalidException
wrapperException)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( (System.Exception)wrapperException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 2095, 2139);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1149_2079_2200(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 2079, 2200);
return return_v;
}


System.Reflection.Assembly
f_1149_2260_2305(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1149, 2260, 2305);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1149_2243_2358(System.Reflection.Assembly
assembly,string
baseName,string
resourceId,params object[]
args)
{
var return_v = new System.Management.Automation.ErrorDetails( assembly, baseName, resourceId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 2243, 2358);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,2007,2370);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,2007,2370);
}
		}

private ErrorRecord _errorRecord;

public ErrorRecord ErrorRecord
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1149,2636,2707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2672,2692);

return _errorRecord;
DynAbs.Tracing.TraceSender.TraceExitMethod(1149,2636,2707);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,2581,2718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,2581,2718);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _helpCategory ;

public string HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1149,3045,3117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,3081,3102);

return _helpCategory;
DynAbs.Tracing.TraceSender.TraceExitMethod(1149,3045,3117);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,2994,3128);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,2994,3128);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string Message
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1149,3341,3548);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,3377,3493) || true) && (_errorRecord != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1149,3377,3493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,3443,3474);

return f_1149_3450_3473(_errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1149,3377,3493);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,3513,3533);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message,1149,3520,3532);
DynAbs.Tracing.TraceSender.TraceExitMethod(1149,3341,3548);

string
f_1149_3450_3473(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 3450, 3473);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,3286,3559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,3286,3559);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected HelpCategoryInvalidException(SerializationInfo info,
                                        StreamingContext context)
:base(f_1149_4011_4015_C(info) ,context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1149,3861,4142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2402,2414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,2745,2818);
this._helpCategory = f_1149_2761_2818(System.Management.Automation.HelpCategory.None);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,4050,4097);

_helpCategory = f_1149_4066_4096(info, "HelpCategory");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,4111,4131);

f_1149_4111_4130(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1149,3861,4142);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,3861,4142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,3861,4142);
}
		}

[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1149,4586,5033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,4788,4906) || true) && (info == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1149,4788,4906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,4838,4891);

throw f_1149_4844_4890("info");
DynAbs.Tracing.TraceSender.TraceExitCondition(1149,4788,4906);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,4922,4956);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info,context),1149,4922,4955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1149,4972,5022);

f_1149_4972_5021(
            info, "HelpCategory", this._helpCategory);
DynAbs.Tracing.TraceSender.TraceExitMethod(1149,4586,5033);

System.Management.Automation.PSArgumentNullException
f_1149_4844_4890(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 4844, 4890);
return return_v;
}


int
f_1149_4972_5021(System.Runtime.Serialization.SerializationInfo
this_param,string
name,string
value)
{
this_param.AddValue( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 4972, 5021);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1149,4586,5033);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,4586,5033);
}
		}

static HelpCategoryInvalidException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1149,521,5076);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1149,521,5076);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1149,521,5076);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1149,521,5076);

int
f_1149_995_1014(Microsoft.PowerShell.Commands.HelpCategoryInvalidException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 995, 1014);
return 0;
}


int
f_1149_1239_1258(Microsoft.PowerShell.Commands.HelpCategoryInvalidException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 1239, 1258);
return 0;
}


static string
f_1149_1726_1748(System.Exception
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1149, 1726, 1748);
return return_v;
}


int
f_1149_1848_1867(Microsoft.PowerShell.Commands.HelpCategoryInvalidException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 1848, 1867);
return 0;
}


static string
f_1149_1699_1763_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1149, 1592, 1879);
return return_v;
}


string
f_1149_2761_2818(System.Management.Automation.HelpCategory
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 2761, 2818);
return return_v;
}


string?
f_1149_4066_4096(System.Runtime.Serialization.SerializationInfo
this_param,string
name)
{
var return_v = this_param.GetString( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 4066, 4096);
return return_v;
}


int
f_1149_4111_4130(Microsoft.PowerShell.Commands.HelpCategoryInvalidException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1149, 4111, 4130);
return 0;
}


static System.Runtime.Serialization.SerializationInfo
f_1149_4011_4015_C(System.Runtime.Serialization.SerializationInfo
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1149, 3861, 4142);
return return_v;
}

}
}

#pragma warning restore 56506
