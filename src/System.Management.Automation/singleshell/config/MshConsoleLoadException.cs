// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace System.Management.Automation.Runspaces
{
[Serializable]
    public class PSConsoleLoadException : SystemException, IContainsErrorRecord
{
public PSConsoleLoadException() : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1230,942,1004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,1693,1705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2856,2913);
this._PSSnapInExceptions = f_1230_2878_2913();DynAbs.Tracing.TraceSender.TraceExitConstructor(1230,942,1004);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1230,942,1004);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,942,1004);
}
		}

public PSConsoleLoadException(string message)
:base(f_1230_1248_1255_C(message) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1230,1182,1278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,1693,1705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2856,2913);
this._PSSnapInExceptions = f_1230_2878_2913();DynAbs.Tracing.TraceSender.TraceExitConstructor(1230,1182,1278);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1230,1182,1278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,1182,1278);
}
		}

public PSConsoleLoadException(string message, Exception innerException)
:base(f_1230_1615_1622_C(message) ,innerException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1230,1523,1661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,1693,1705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2856,2913);
this._PSSnapInExceptions = f_1230_2878_2913();DynAbs.Tracing.TraceSender.TraceExitConstructor(1230,1523,1661);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1230,1523,1661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,1523,1661);
}
		}

private ErrorRecord _errorRecord;

public ErrorRecord ErrorRecord
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1230,2010,2081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2046,2066);

return _errorRecord;
DynAbs.Tracing.TraceSender.TraceExitMethod(1230,2010,2081);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1230,1955,2092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,1955,2092);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private void CreateErrorRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1230,2278,2806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2335,2374);

StringBuilder 
sb = f_1230_2354_2373()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2390,2639) || true) && (f_1230_2394_2412()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1230,2390,2639);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2454,2624);
foreach(PSSnapInException e in f_1230_2486_2504_I(f_1230_2486_2504()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1230,2454,2624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2546,2562);

f_1230_2546_2561(                    sb, "\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2584,2605);

f_1230_2584_2604(                    sb, f_1230_2594_2603(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1230,2454,2624);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1230,1,171);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1230,1,171);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1230,2390,2639);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,2655,2795);

_errorRecord = f_1230_2670_2794(f_1230_2686_2730(this), "ConsoleLoadFailure", ErrorCategory.ResourceUnavailable, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1230,2278,2806);

System.Text.StringBuilder
f_1230_2354_2373()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 2354, 2373);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInException>
f_1230_2394_2412()
{
var return_v = PSSnapInExceptions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1230, 2394, 2412);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInException>
f_1230_2486_2504()
{
var return_v = PSSnapInExceptions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1230, 2486, 2504);
return return_v;
}


System.Text.StringBuilder
f_1230_2546_2561(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 2546, 2561);
return return_v;
}


string
f_1230_2594_2603(System.Management.Automation.Runspaces.PSSnapInException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1230, 2594, 2603);
return return_v;
}


System.Text.StringBuilder
f_1230_2584_2604(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 2584, 2604);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInException>
f_1230_2486_2504_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInException>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 2486, 2504);
return return_v;
}


System.Management.Automation.ParentContainsErrorRecordException
f_1230_2686_2730(System.Management.Automation.Runspaces.PSConsoleLoadException
wrapperException)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( (System.Exception)wrapperException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 2686, 2730);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1230_2670_2794(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 2670, 2794);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1230,2278,2806);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,2278,2806);
}
		}

private Collection<PSSnapInException> _PSSnapInExceptions ;

internal Collection<PSSnapInException> PSSnapInExceptions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1230,3006,3084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,3042,3069);

return _PSSnapInExceptions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1230,3006,3084);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1230,2924,3095);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,2924,3095);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string Message
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1230,3255,3524);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,3291,3509) || true) && (_errorRecord != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1230,3291,3509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,3357,3388);

return f_1230_3364_3387(_errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1230,3291,3509);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1230,3291,3509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1230,3470,3490);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message,1230,3477,3489);
DynAbs.Tracing.TraceSender.TraceExitCondition(1230,3291,3509);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1230,3255,3524);

string
f_1230_3364_3387(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 3364, 3387);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1230,3200,3535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,3200,3535);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static PSConsoleLoadException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1230,722,3542);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1230,722,3542);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1230,722,3542);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1230,722,3542);

static string
f_1230_1248_1255_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1230, 1182, 1278);
return return_v;
}


static string
f_1230_1615_1622_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1230, 1523, 1661);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInException>
f_1230_2878_2913()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSnapInException>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1230, 2878, 2913);
return return_v;
}

}
}

