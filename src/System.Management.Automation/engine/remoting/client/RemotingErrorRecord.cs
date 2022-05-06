// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Remoting;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation.Runspaces
{
[Serializable]
    public class RemotingErrorRecord : ErrorRecord
{
public OriginInfo OriginInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,627,697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,663,682);

return _originInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,627,697);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,574,708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,574,708);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private OriginInfo _originInfo;

public RemotingErrorRecord(ErrorRecord errorRecord, OriginInfo originInfo) :this(f_1582_1065_1076_C(errorRecord) ,originInfo,null) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,983,1099);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,983,1099);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,983,1099);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,983,1099);
}
		}

private RemotingErrorRecord(ErrorRecord errorRecord, OriginInfo originInfo, Exception replaceParentContainsErrorRecordException) :base(f_1582_1543_1554_C(errorRecord) ,replaceParentContainsErrorRecordException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,1394,1798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,739,750);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,1623,1746) || true) && (errorRecord != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1582,1623,1746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,1680,1731);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetInvocationInfo(f_1582_1703_1729(errorRecord)),1582,1680,1730);
DynAbs.Tracing.TraceSender.TraceExitCondition(1582,1623,1746);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,1762,1787);

_originInfo = originInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,1394,1798);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,1394,1798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,1394,1798);
}
		}

[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,2073,2529);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,2275,2393) || true) && (info == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1582,2275,2393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,2325,2378);

throw f_1582_2331_2377("info");
DynAbs.Tracing.TraceSender.TraceExitCondition(1582,2275,2393);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,2409,2443);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info,context),1582,2409,2442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,2459,2518);

f_1582_2459_2517(
            info, "RemoteErrorRecord_OriginInfo", _originInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,2073,2529);

System.Management.Automation.PSArgumentNullException
f_1582_2331_2377(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 2331, 2377);
return return_v;
}


int
f_1582_2459_2517(System.Runtime.Serialization.SerializationInfo
this_param,string
name,System.Management.Automation.Remoting.OriginInfo
value)
{
this_param.AddValue( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 2459, 2517);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,2073,2529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,2073,2529);
}
		}

protected RemotingErrorRecord(SerializationInfo info, StreamingContext context)
:base(f_1582_2853_2857_C(info) ,context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,2753,2995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,739,750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,2892,2984);

_originInfo = (OriginInfo)f_1582_2918_2983(info, "RemoteErrorRecord_OriginInfo", typeof(OriginInfo));
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,2753,2995);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,2753,2995);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,2753,2995);
}
		}

internal override ErrorRecord WrapException(Exception replaceParentContainsErrorRecordException)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,3452,3681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,3573,3670);

return f_1582_3580_3669(this, f_1582_3610_3625(this), replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,3452,3681);

System.Management.Automation.Remoting.OriginInfo
f_1582_3610_3625(System.Management.Automation.Runspaces.RemotingErrorRecord
this_param)
{
var return_v = this_param.OriginInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 3610, 3625);
return return_v;
}


System.Management.Automation.Runspaces.RemotingErrorRecord
f_1582_3580_3669(System.Management.Automation.Runspaces.RemotingErrorRecord
errorRecord,System.Management.Automation.Remoting.OriginInfo
originInfo,System.Exception
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.Runspaces.RemotingErrorRecord( (System.Management.Automation.ErrorRecord)errorRecord, originInfo, replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 3580, 3669);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,3452,3681);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,3452,3681);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static RemotingErrorRecord()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1582,398,3719);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1582,398,3719);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,398,3719);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1582,398,3719);

static System.Management.Automation.ErrorRecord
f_1582_1065_1076_C(System.Management.Automation.ErrorRecord
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 983, 1099);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1582_1703_1729(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.InvocationInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 1703, 1729);
return return_v;
}


static System.Management.Automation.ErrorRecord
f_1582_1543_1554_C(System.Management.Automation.ErrorRecord
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 1394, 1798);
return return_v;
}


object?
f_1582_2918_2983(System.Runtime.Serialization.SerializationInfo
this_param,string
name,System.Type
type)
{
var return_v = this_param.GetValue( name, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 2918, 2983);
return return_v;
}


static System.Runtime.Serialization.SerializationInfo
f_1582_2853_2857_C(System.Runtime.Serialization.SerializationInfo
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 2753, 2995);
return return_v;
}

}
[DataContract()]
    public class RemotingProgressRecord : ProgressRecord
{
public OriginInfo OriginInfo
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,4059,4086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4065,4084);

return _originInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,4059,4086);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,4006,4097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,4006,4097);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[DataMemberAttribute()]
        private readonly OriginInfo _originInfo;

public RemotingProgressRecord(ProgressRecord progressRecord, OriginInfo originInfo) :base(f_1582_4524_4559_C(f_1582_4524_4559(f_1582_4524_4548(progressRecord))) ,f_1582_4561_4594(f_1582_4561_4585(progressRecord)),f_1582_4596_4638(f_1582_4596_4620(progressRecord)))
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,4420,5246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4170,4181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4664,4689);

_originInfo = originInfo;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4703,5235) || true) && (progressRecord != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1582,4703,5235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4763,4817);

this.PercentComplete = f_1582_4786_4816(progressRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4835,4891);

this.ParentActivityId = f_1582_4859_4890(progressRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4909,4953);

this.RecordType = f_1582_4927_4952(progressRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,4971,5027);

this.SecondsRemaining = f_1582_4995_5026(progressRecord);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5045,5220) || true) && (!f_1582_5050_5103(f_1582_5071_5102(progressRecord)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1582,5045,5220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5145,5201);

this.CurrentOperation = f_1582_5169_5200(progressRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1582,5045,5220);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1582,4703,5235);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,4420,5246);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,4420,5246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,4420,5246);
}
		}

private static ProgressRecord Validate(ProgressRecord progressRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1582,5258,5477);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5352,5430) || true) && (progressRecord == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1582,5352,5430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5380,5430);

throw f_1582_5386_5429("progressRecord");
DynAbs.Tracing.TraceSender.TraceExitCondition(1582,5352,5430);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5444,5466);

return progressRecord;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1582,5258,5477);

System.ArgumentNullException
f_1582_5386_5429(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 5386, 5429);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,5258,5477);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,5258,5477);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static RemotingProgressRecord()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1582,3822,5484);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1582,3822,5484);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,3822,5484);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1582,3822,5484);

static System.Management.Automation.ProgressRecord
f_1582_4524_4548(System.Management.Automation.ProgressRecord
progressRecord)
{
var return_v = Validate( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 4524, 4548);
return return_v;
}


static int
f_1582_4524_4559(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 4524, 4559);
return return_v;
}


static System.Management.Automation.ProgressRecord
f_1582_4561_4585(System.Management.Automation.ProgressRecord
progressRecord)
{
var return_v = Validate( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 4561, 4585);
return return_v;
}


static string
f_1582_4561_4594(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.Activity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 4561, 4594);
return return_v;
}


static System.Management.Automation.ProgressRecord
f_1582_4596_4620(System.Management.Automation.ProgressRecord
progressRecord)
{
var return_v = Validate( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 4596, 4620);
return return_v;
}


static string
f_1582_4596_4638(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 4596, 4638);
return return_v;
}


int
f_1582_4786_4816(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 4786, 4816);
return return_v;
}


int
f_1582_4859_4890(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ParentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 4859, 4890);
return return_v;
}


System.Management.Automation.ProgressRecordType
f_1582_4927_4952(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.RecordType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 4927, 4952);
return return_v;
}


int
f_1582_4995_5026(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 4995, 5026);
return return_v;
}


string
f_1582_5071_5102(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 5071, 5102);
return return_v;
}


bool
f_1582_5050_5103(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1582, 5050, 5103);
return return_v;
}


string
f_1582_5169_5200(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 5169, 5200);
return return_v;
}


static int
f_1582_4524_4559_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 4420, 5246);
return return_v;
}

}
[DataContract()]
    public class RemotingWarningRecord : WarningRecord
{
public OriginInfo OriginInfo
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,5821,5848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5827,5846);

return _originInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,5821,5848);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,5768,5859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,5768,5859);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[DataMemberAttribute()]
        private readonly OriginInfo _originInfo;

public RemotingWarningRecord(string message, OriginInfo originInfo) :base(f_1582_6254_6261_C(message) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,6179,6323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5932,5943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,6287,6312);

_originInfo = originInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,6179,6323);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,6179,6323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,6179,6323);
}
		}

internal RemotingWarningRecord(
            WarningRecord warningRecord,
            OriginInfo originInfo)
:base(f_1582_6712_6749_C(f_1582_6712_6749(warningRecord)) ,f_1582_6751_6772(warningRecord))
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,6582,6834);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,5932,5943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,6798,6823);

_originInfo = originInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,6582,6834);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,6582,6834);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,6582,6834);
}
		}

static RemotingWarningRecord()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1582,5586,6841);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1582,5586,6841);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,5586,6841);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1582,5586,6841);

static string
f_1582_6254_6261_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 6179, 6323);
return return_v;
}


static string
f_1582_6712_6749(System.Management.Automation.WarningRecord
this_param)
{
var return_v = this_param.FullyQualifiedWarningId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 6712, 6749);
return return_v;
}


static string
f_1582_6751_6772(System.Management.Automation.WarningRecord
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 6751, 6772);
return return_v;
}


static string
f_1582_6712_6749_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 6582, 6834);
return return_v;
}

}
[DataContract()]
    public class RemotingDebugRecord : DebugRecord
{
public OriginInfo OriginInfo
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,7172,7199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,7178,7197);

return _originInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,7172,7199);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,7119,7210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,7119,7210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[DataMemberAttribute()]
        private readonly OriginInfo _originInfo;

public RemotingDebugRecord(string message, OriginInfo originInfo) :base(f_1582_7601_7608_C(message) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,7528,7670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,7283,7294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,7634,7659);

_originInfo = originInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,7528,7670);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,7528,7670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,7528,7670);
}
		}

static RemotingDebugRecord()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1582,6941,7677);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1582,6941,7677);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,6941,7677);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1582,6941,7677);

static string
f_1582_7601_7608_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 7528, 7670);
return return_v;
}

}
[DataContract()]
    public class RemotingVerboseRecord : VerboseRecord
{
public OriginInfo OriginInfo
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,8014,8041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,8020,8039);

return _originInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,8014,8041);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,7961,8052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,7961,8052);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[DataMemberAttribute()]
        private readonly OriginInfo _originInfo;

public RemotingVerboseRecord(string message, OriginInfo originInfo) :base(f_1582_8447_8454_C(message) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,8372,8516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,8125,8136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,8480,8505);

_originInfo = originInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,8372,8516);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,8372,8516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,8372,8516);
}
		}

static RemotingVerboseRecord()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1582,7779,8523);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1582,7779,8523);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,7779,8523);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1582,7779,8523);

static string
f_1582_8447_8454_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 8372, 8516);
return return_v;
}

}
[DataContract()]
    public class RemotingInformationRecord : InformationRecord
{
public OriginInfo OriginInfo
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,8872,8899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,8878,8897);

return _originInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,8872,8899);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,8819,8910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,8819,8910);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[DataMemberAttribute()]
        private readonly OriginInfo _originInfo;

public RemotingInformationRecord(InformationRecord record, OriginInfo originInfo)
:base(f_1582_9335_9341_C(record) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,9233,9403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,8983,8994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,9367,9392);

_originInfo = originInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,9233,9403);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,9233,9403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,9233,9403);
}
		}

static RemotingInformationRecord()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1582,8629,9410);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1582,8629,9410);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,8629,9410);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1582,8629,9410);

static System.Management.Automation.InformationRecord
f_1582_9335_9341_C(System.Management.Automation.InformationRecord
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 9233, 9403);
return return_v;
}

}
}

namespace System.Management.Automation.Remoting
{
[Serializable]
    [DataContract()]
    public class OriginInfo
{
[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PSIP")]
        public string PSComputerName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,10204,10276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,10240,10261);

return _computerName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,10204,10276);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,10040,10287);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,10040,10287);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[DataMemberAttribute()]
        private string _computerName;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
        public Guid RunspaceID
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,10611,10681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,10647,10666);

return _runspaceID;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,10611,10681);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,10455,10692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,10455,10692);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[DataMemberAttribute()]
        private Guid _runspaceID;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
        public Guid InstanceID
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,11023,11093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,11059,11078);

return _instanceId;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,11023,11093);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,10867,11191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,10867,11191);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,11109,11180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,11145,11165);

_instanceId = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,11109,11180);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,10867,11191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,10867,11191);
}
		}}

[DataMemberAttribute()]
        private Guid _instanceId;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
        public OriginInfo(string computerName, Guid runspaceID)
:this(f_1582_11671_11683_C(computerName) ,runspaceID,Guid.Empty)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,11486,11721);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,11486,11721);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,11486,11721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,11486,11721);
}
		}

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
        public OriginInfo(string computerName, Guid runspaceID, Guid instanceID)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1582,12027,12351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,10347,10360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,12233,12262);

_computerName = computerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,12276,12301);

_runspaceID = runspaceID;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,12315,12340);

_instanceId = instanceID;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1582,12027,12351);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,12027,12351);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,12027,12351);
}
		}

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1582,12511,12602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1582,12569,12591);

return f_1582_12576_12590();
DynAbs.Tracing.TraceSender.TraceExitMethod(1582,12511,12602);

string
f_1582_12576_12590()
{
var return_v = PSComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1582, 12576, 12590);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1582,12511,12602);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,12511,12602);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static OriginInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1582,9805,12609);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1582,9805,12609);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1582,9805,12609);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1582,9805,12609);

static string
f_1582_11671_11683_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1582, 11486, 11721);
return return_v;
}

}
}

