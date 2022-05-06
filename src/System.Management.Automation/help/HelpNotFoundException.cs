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
    public class HelpNotFoundException : SystemException, IContainsErrorRecord
{
public HelpNotFoundException(string helpTopic) : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1156,836,984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2668,2680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3012,3037);
this._helpTopic = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,916,939);

_helpTopic = helpTopic;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,953,973);

f_1156_953_972(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1156,836,984);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,836,984);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,836,984);
}
		}

public HelpNotFoundException() : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1156,1119,1214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2668,2680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3012,3037);
this._helpTopic = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,1183,1203);

f_1156_1183_1202(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1156,1119,1214);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,1119,1214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,1119,1214);
}
		}

public HelpNotFoundException(string helpTopic, Exception innerException) :base(f_1156_1670_1734_C((DynAbs.Tracing.TraceSender.Conditional_F1(1156, 1670, 1694)||(((innerException != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1156, 1697, 1719))||DynAbs.Tracing.TraceSender.Conditional_F3(1156, 1722, 1734)))?f_1156_1697_1719(innerException):string.Empty) ,innerException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1156,1573,1844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2668,2680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3012,3037);
this._helpTopic = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,1776,1799);

_helpTopic = helpTopic;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,1813,1833);

f_1156_1813_1832(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1156,1573,1844);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,1573,1844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,1573,1844);
}
		}

private void CreateErrorRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1156,2049,2636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2106,2177);

string 
errMessage = f_1156_2126_2176(f_1156_2140_2163(), _helpTopic)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2344,2484);

_errorRecord = f_1156_2359_2483(f_1156_2375_2425(errMessage), "HelpNotFound", ErrorCategory.ResourceUnavailable, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2498,2625);

_errorRecord.ErrorDetails = f_1156_2526_2624(f_1156_2543_2581(typeof(HelpNotFoundException)), "HelpErrors", "HelpNotFound", _helpTopic);
DynAbs.Tracing.TraceSender.TraceExitMethod(1156,2049,2636);

string
f_1156_2140_2163()
{
var return_v = HelpErrors.HelpNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1156, 2140, 2163);
return return_v;
}


string
f_1156_2126_2176(string
format,string
arg0)
{
var return_v = string.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 2126, 2176);
return return_v;
}


System.Management.Automation.ParentContainsErrorRecordException
f_1156_2375_2425(string
message)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 2375, 2425);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1156_2359_2483(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 2359, 2483);
return return_v;
}


System.Reflection.Assembly
f_1156_2543_2581(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1156, 2543, 2581);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1156_2526_2624(System.Reflection.Assembly
assembly,string
baseName,string
resourceId,params object[]
args)
{
var return_v = new System.Management.Automation.ErrorDetails( assembly, baseName, resourceId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 2526, 2624);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,2049,2636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,2049,2636);
}
		}

private ErrorRecord _errorRecord;

public ErrorRecord ErrorRecord
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1156,2903,2974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2939,2959);

return _errorRecord;
DynAbs.Tracing.TraceSender.TraceExitMethod(1156,2903,2974);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,2848,2985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,2848,2985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _helpTopic ;

public string HelpTopic
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1156,3243,3312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3279,3297);

return _helpTopic;
DynAbs.Tracing.TraceSender.TraceExitMethod(1156,3243,3312);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,3195,3323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,3195,3323);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string Message
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1156,3536,3743);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3572,3688) || true) && (_errorRecord != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1156,3572,3688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3638,3669);

return f_1156_3645_3668(_errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1156,3572,3688);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3708,3728);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message,1156,3715,3727);
DynAbs.Tracing.TraceSender.TraceExitMethod(1156,3536,3743);

string
f_1156_3645_3668(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 3645, 3668);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,3481,3754);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,3481,3754);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected HelpNotFoundException(SerializationInfo info,
                                        StreamingContext context)
:base(f_1156_4194_4198_C(info) ,context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1156,4051,4319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,2668,2680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,3012,3037);
this._helpTopic = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,4233,4274);

_helpTopic = f_1156_4246_4273(info, "HelpTopic");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,4288,4308);

f_1156_4288_4307(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1156,4051,4319);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,4051,4319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,4051,4319);
}
		}

[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1156,4756,5197);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,4958,5076) || true) && (info == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1156,4958,5076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,5008,5061);

throw f_1156_5014_5060("info");
DynAbs.Tracing.TraceSender.TraceExitCondition(1156,4958,5076);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,5092,5126);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info,context),1156,5092,5125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1156,5142,5186);

f_1156_5142_5185(
            info, "HelpTopic", this._helpTopic);
DynAbs.Tracing.TraceSender.TraceExitMethod(1156,4756,5197);

System.Management.Automation.PSArgumentNullException
f_1156_5014_5060(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 5014, 5060);
return return_v;
}


int
f_1156_5142_5185(System.Runtime.Serialization.SerializationInfo
this_param,string
name,string
value)
{
this_param.AddValue( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 5142, 5185);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1156,4756,5197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,4756,5197);
}
		}

static HelpNotFoundException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1156,488,5240);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1156,488,5240);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1156,488,5240);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1156,488,5240);

int
f_1156_953_972(Microsoft.PowerShell.Commands.HelpNotFoundException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 953, 972);
return 0;
}


int
f_1156_1183_1202(Microsoft.PowerShell.Commands.HelpNotFoundException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 1183, 1202);
return 0;
}


static string
f_1156_1697_1719(System.Exception
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1156, 1697, 1719);
return return_v;
}


int
f_1156_1813_1832(Microsoft.PowerShell.Commands.HelpNotFoundException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 1813, 1832);
return 0;
}


static string
f_1156_1670_1734_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1156, 1573, 1844);
return return_v;
}


string?
f_1156_4246_4273(System.Runtime.Serialization.SerializationInfo
this_param,string
name)
{
var return_v = this_param.GetString( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 4246, 4273);
return return_v;
}


int
f_1156_4288_4307(Microsoft.PowerShell.Commands.HelpNotFoundException
this_param)
{
this_param.CreateErrorRecord();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1156, 4288, 4307);
return 0;
}


static System.Runtime.Serialization.SerializationInfo
f_1156_4194_4198_C(System.Runtime.Serialization.SerializationInfo
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1156, 4051, 4319);
return return_v;
}

}
}

#pragma warning restore 56506
