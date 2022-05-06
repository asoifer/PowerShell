// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
[DataContract()]
    public
    class ProgressRecord
{
public
        ProgressRecord(int activityId, string activity, string statusDescription)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1316,1483,2453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15317,15319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15377,15390);
this.parentId = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15451,15459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15520,15526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15587,15603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15661,15673);
this.percent = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15731,15752);
this.secondsRemaining = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15825,15861);
this.type = ProgressRecordType.Processing;
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,1597,1882) || true) && (activityId < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,1597,1882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,1733,1867);

throw f_1316_1739_1866("activityId", activityId, f_1316_1810_1851(), "activityId");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,1597,1882);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,1898,2092) || true) && (f_1316_1902_1932(activity))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,1898,2092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,1966,2077);

throw f_1316_1972_2076("activity", f_1316_2019_2063(), "activity");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,1898,2092);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2108,2320) || true) && (f_1316_2112_2151(statusDescription))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,2108,2320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2185,2305);

throw f_1316_2191_2304("activity", f_1316_2238_2282(), "statusDescription");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,2108,2320);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2336,2357);

this.id = activityId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2371,2396);

this.activity = activity;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2410,2442);

this.status = statusDescription;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1316,1483,2453);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,1483,2453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,1483,2453);
}
		}

internal ProgressRecord(ProgressRecord other)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1316,2673,3106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15317,15319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15377,15390);
this.parentId = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15451,15459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15520,15526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15587,15603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15661,15673);
this.percent = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15731,15752);
this.secondsRemaining = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15825,15861);
this.type = ProgressRecordType.Processing;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2743,2774);

this.activity = other.activity;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2788,2835);

this.currentOperation = other.currentOperation;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2849,2868);

this.id = other.id;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2882,2913);

this.parentId = other.parentId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2927,2956);

this.percent = other.percent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,2970,3017);

this.secondsRemaining = other.secondsRemaining;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,3031,3058);

this.status = other.status;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,3072,3095);

this.type = other.type;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1316,2673,3106);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,2673,3106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,2673,3106);
}
		}

public
        int
        ActivityId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,3379,3440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,3415,3425);

return id;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,3379,3440);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,3315,3451);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,3315,3451);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public
        int
        ParentActivityId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,4487,4554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,4523,4539);

return parentId;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,4487,4554);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,4417,4859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,4417,4859);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,4570,4848);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,4606,4796) || true) && (value == f_1316_4619_4629())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,4606,4796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,4671,4777);

throw f_1316_4677_4776("value", f_1316_4721_4775());
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,4606,4796);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,4816,4833);

parentId = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,4570,4848);

int
f_1316_4619_4629()
{
var return_v = ActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 4619, 4629);
return return_v;
}


string
f_1316_4721_4775()
{
var return_v = ProgressRecordStrings.ParentActivityIdCantBeActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 4721, 4775);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1316_4677_4776(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 4677, 4776);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,4417,4859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,4417,4859);
}
		}}

public
        string
        Activity
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,5311,5378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,5347,5363);

return activity;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,5311,5378);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,5246,5690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,5246,5690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,5394,5679);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,5430,5627) || true) && (f_1316_5434_5461(value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,5430,5627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,5503,5608);

throw f_1316_5509_5607("value", f_1316_5553_5597(), "value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,5430,5627);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,5647,5664);

activity = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,5394,5679);

bool
f_1316_5434_5461(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 5434, 5461);
return return_v;
}


string
f_1316_5553_5597()
{
var return_v = ProgressRecordStrings.ArgMayNotBeNullOrEmpty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 5553, 5597);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1316_5509_5607(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 5509, 5607);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,5246,5690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,5246,5690);
}
		}}

public
        string
        StatusDescription
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,5963,6028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,5999,6013);

return status;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,5963,6028);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,5889,6338);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,5889,6338);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,6044,6327);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,6080,6277) || true) && (f_1316_6084_6111(value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,6080,6277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,6153,6258);

throw f_1316_6159_6257("value", f_1316_6203_6247(), "value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,6080,6277);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,6297,6312);

status = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,6044,6327);

bool
f_1316_6084_6111(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 6084, 6111);
return return_v;
}


string
f_1316_6203_6247()
{
var return_v = ProgressRecordStrings.ArgMayNotBeNullOrEmpty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 6203, 6247);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1316_6159_6257(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 6159, 6257);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,5889,6338);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,5889,6338);
}
		}}

public
        string
        CurrentOperation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,6800,6875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,6836,6860);

return currentOperation;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,6800,6875);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,6727,7032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,6727,7032);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,6891,7021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,6981,7006);

currentOperation = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,6891,7021);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,6727,7032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,6727,7032);
}
		}}

public
        int
        PercentComplete
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,7414,7480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,7450,7465);

return percent;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,7414,7480);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,7345,7911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,7345,7911);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,7496,7900);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,7582,7849) || true) && (value > 100)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,7582,7849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,7639,7830);

throw
f_1316_7670_7829("value", value, f_1316_7761_7809(), "PercentComplete");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,7582,7849);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,7869,7885);

percent = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,7496,7900);

string
f_1316_7761_7809()
{
var return_v = ProgressRecordStrings.PercentMayNotBeMoreThan100;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 7761, 7809);
return return_v;
}


System.Management.Automation.PSArgumentOutOfRangeException
f_1316_7670_7829(string
paramName,int
actualValue,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentOutOfRangeException( paramName, (object)actualValue, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 7670, 7829);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,7345,7911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,7345,7911);
}
		}}

public
        int
        SecondsRemaining
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,8501,8576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,8537,8561);

return secondsRemaining;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,8501,8576);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,8431,8729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,8431,8729);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,8592,8718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,8678,8703);

secondsRemaining = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,8592,8718);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,8431,8729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,8431,8729);
}
		}}

public
        ProgressRecordType
        RecordType
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,8945,9008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,8981,8993);

return type;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,8945,9008);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,8866,9313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,8866,9313);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,9024,9302);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,9060,9254) || true) && (value != ProgressRecordType.Completed &&(DynAbs.Tracing.TraceSender.Expression_True(1316, 9064, 9143)&&value != ProgressRecordType.Processing))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,9060,9254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,9185,9235);

throw f_1316_9191_9234("value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,9060,9254);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,9274,9287);

type = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,9024,9302);

System.Management.Automation.PSArgumentException
f_1316_9191_9234(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 9191, 9234);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,8866,9313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,8866,9313);
}
		}}

public override
        string
        ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,9776,10331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,9852,10320);

return
f_1316_9876_10319(f_1316_9912_9959(), "parent = {0} id = {1} act = {2} stat = {3} cur = {4} pct = {5} sec = {6} type = {7}", parentId, id, activity, status, currentOperation, percent, secondsRemaining, type);
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,9776,10331);

System.Globalization.CultureInfo
f_1316_9912_9959()
{
var return_v =                     System.Globalization.CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 9912, 9959);
return return_v;
}


string
f_1316_9876_10319(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 9876, 10319);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,9776,10331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,9776,10331);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static int? GetSecondsRemaining(DateTime startTime, double percentageComplete)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1316,10399,11829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,10511,10599);

f_1316_10511_10598(percentageComplete >= 0.0, "Caller should verify percentageComplete >= 0.0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,10613,10701);

f_1316_10613_10700(percentageComplete <= 1.0, "Caller should verify percentageComplete <= 1.0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,10715,10978);

f_1316_10715_10977(startTime.Kind == DateTimeKind.Utc, "DateTime arithmetic should always be done in utc mode [to avoid problems when some operands are calculated right before and right after switching to /from a daylight saving time");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,10994,11125) || true) && ((percentageComplete < 0.00001) ||(DynAbs.Tracing.TraceSender.Expression_False(1316, 10998, 11064)||f_1316_11032_11064(percentageComplete)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,10994,11125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11098,11110);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,10994,11125);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11141,11172);

DateTime 
now = DateTime.UtcNow
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11186,11255);

f_1316_11186_11254(startTime <= now, "Caller should pass a valid startTime");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11269,11308);

TimeSpan 
elapsedTime = now - startTime
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11324,11343);

TimeSpan 
totalTime
=default(TimeSpan);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11393,11483);

totalTime = TimeSpan.FromMilliseconds(elapsedTime.TotalMilliseconds / percentageComplete);
            }
            catch (OverflowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1316,11512,11597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11570,11582);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1316,11512,11597);
            }
            catch (ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1316,11611,11696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11669,11681);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1316,11611,11696);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11712,11761);

TimeSpan 
remainingTime = totalTime - elapsedTime
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,11777,11818);

return (int)(remainingTime.TotalSeconds);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1316,10399,11829);

int
f_1316_10511_10598(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 10511, 10598);
return 0;
}


int
f_1316_10613_10700(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 10613, 10700);
return 0;
}


int
f_1316_10715_10977(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 10715, 10977);
return 0;
}


bool
f_1316_11032_11064(double
d)
{
var return_v = double.IsNaN( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 11032, 11064);
return return_v;
}


int
f_1316_11186_11254(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 11186, 11254);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,10399,11829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,10399,11829);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static int GetPercentageComplete(DateTime startTime, TimeSpan expectedDuration)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1316,12702,15119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,12815,12846);

DateTime 
now = DateTime.UtcNow
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,12862,13125);

f_1316_12862_13124(startTime.Kind == DateTimeKind.Utc, "DateTime arithmetic should always be done in utc mode [to avoid problems when some operands are calculated right before and right after switching to /from a daylight saving time");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,13141,13260) || true) && (startTime > now)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,13141,13260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,13194,13245);

throw f_1316_13200_13244("startTime");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,13141,13260);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,13276,13420) || true) && (expectedDuration <= TimeSpan.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,13276,13420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,13347,13405);

throw f_1316_13353_13404("expectedDuration");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,13276,13420);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,14764,14803);

TimeSpan 
timeElapsed = now - startTime
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,14817,14864);

double 
b = expectedDuration.TotalSeconds / 9.0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,14878,14899);

double 
a = 100.0 * b
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,14913,14977);

double 
percentageRemaining = a / (timeElapsed.TotalSeconds + b)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,14991,15048);

double 
percentageCompleted = 100.0 - percentageRemaining
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,15064,15108);

return (int)f_1316_15076_15107(percentageCompleted);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1316,12702,15119);

int
f_1316_12862_13124(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 12862, 13124);
return 0;
}


System.ArgumentOutOfRangeException
f_1316_13200_13244(string
paramName)
{
var return_v = new System.ArgumentOutOfRangeException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 13200, 13244);
return return_v;
}


System.ArgumentOutOfRangeException
f_1316_13353_13404(string
paramName)
{
var return_v = new System.ArgumentOutOfRangeException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 13353, 13404);
return return_v;
}


double
f_1316_15076_15107(double
d)
{
var return_v = Math.Floor( d);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 15076, 15107);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,12702,15119);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,12702,15119);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[DataMemberAttribute()]
        private int id;

[DataMemberAttribute()]
        private int parentId ;

[DataMemberAttribute()]
        private string activity;

[DataMemberAttribute()]
        private string status;

[DataMemberAttribute()]
        private string currentOperation;

[DataMemberAttribute()]
        private int percent ;

[DataMemberAttribute()]
        private int secondsRemaining ;

[DataMemberAttribute()]
        private ProgressRecordType type ;

internal static ProgressRecord FromPSObjectForRemoting(PSObject progressAsPSObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1316,16684,18282);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,16792,16938) || true) && (progressAsPSObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1316,16792,16938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,16856,16923);

throw f_1316_16862_16922("progressAsPSObject");
DynAbs.Tracing.TraceSender.TraceExitCondition(1316,16792,16938);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,16954,17080);

string 
activity = f_1316_16972_17079(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_Activity)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,17094,17218);

int 
activityId = f_1316_17111_17217(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_ActivityId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,17232,17376);

string 
statusDescription = f_1316_17259_17375(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_StatusDescription)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,17392,17476);

ProgressRecord 
result = f_1316_17416_17475(activityId, activity, statusDescription)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,17492,17634);

result.CurrentOperation = f_1316_17518_17633(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_CurrentOperation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,17648,17787);

result.ParentActivityId = f_1316_17674_17786(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_ParentActivityId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,17801,17938);

result.PercentComplete = f_1316_17826_17937(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_PercentComplete);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,17952,18088);

result.RecordType = f_1316_17972_18087(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_Type);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,18102,18241);

result.SecondsRemaining = f_1316_18128_18240(progressAsPSObject, RemoteDataNameStrings.ProgressRecord_SecondsRemaining);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,18257,18271);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1316,16684,18282);

System.Management.Automation.PSArgumentNullException
f_1316_16862_16922(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 16862, 16922);
return return_v;
}


string
f_1316_16972_17079(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<string>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 16972, 17079);
return return_v;
}


int
f_1316_17111_17217(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<int>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 17111, 17217);
return return_v;
}


string
f_1316_17259_17375(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<string>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 17259, 17375);
return return_v;
}


System.Management.Automation.ProgressRecord
f_1316_17416_17475(int
activityId,string
activity,string
statusDescription)
{
var return_v = new System.Management.Automation.ProgressRecord( activityId, activity, statusDescription);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 17416, 17475);
return return_v;
}


string
f_1316_17518_17633(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<string>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 17518, 17633);
return return_v;
}


int
f_1316_17674_17786(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<int>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 17674, 17786);
return return_v;
}


int
f_1316_17826_17937(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<int>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 17826, 17937);
return return_v;
}


System.Management.Automation.ProgressRecordType
f_1316_17972_18087(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<ProgressRecordType>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 17972, 18087);
return return_v;
}


int
f_1316_18128_18240(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<int>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18128, 18240);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,16684,18282);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,16684,18282);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSObject ToPSObjectForRemoting()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1316,18539,19852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,18605,18673);

PSObject 
progressAsPSObject = f_1316_18635_18672()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,18689,18805);

f_1316_18689_18804(f_1316_18689_18718(progressAsPSObject), f_1316_18723_18803(RemoteDataNameStrings.ProgressRecord_Activity, f_1316_18789_18802(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,18819,18939);

f_1316_18819_18938(f_1316_18819_18848(progressAsPSObject), f_1316_18853_18937(RemoteDataNameStrings.ProgressRecord_ActivityId, f_1316_18921_18936(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,18953,19087);

f_1316_18953_19086(f_1316_18953_18982(progressAsPSObject), f_1316_18987_19085(RemoteDataNameStrings.ProgressRecord_StatusDescription, f_1316_19062_19084(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,19103,19235);

f_1316_19103_19234(f_1316_19103_19132(progressAsPSObject), f_1316_19137_19233(RemoteDataNameStrings.ProgressRecord_CurrentOperation, f_1316_19211_19232(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,19249,19381);

f_1316_19249_19380(f_1316_19249_19278(progressAsPSObject), f_1316_19283_19379(RemoteDataNameStrings.ProgressRecord_ParentActivityId, f_1316_19357_19378(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,19395,19525);

f_1316_19395_19524(f_1316_19395_19424(progressAsPSObject), f_1316_19429_19523(RemoteDataNameStrings.ProgressRecord_PercentComplete, f_1316_19502_19522(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,19539,19653);

f_1316_19539_19652(f_1316_19539_19568(progressAsPSObject), f_1316_19573_19651(RemoteDataNameStrings.ProgressRecord_Type, f_1316_19635_19650(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,19667,19799);

f_1316_19667_19798(f_1316_19667_19696(progressAsPSObject), f_1316_19701_19797(RemoteDataNameStrings.ProgressRecord_SecondsRemaining, f_1316_19775_19796(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1316,19815,19841);

return progressAsPSObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1316,18539,19852);

System.Management.Automation.PSObject
f_1316_18635_18672()
{
var return_v = RemotingEncoder.CreateEmptyPSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18635, 18672);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_18689_18718(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 18689, 18718);
return return_v;
}


string
f_1316_18789_18802(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.Activity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 18789, 18802);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_18723_18803(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18723, 18803);
return return_v;
}


int
f_1316_18689_18804(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18689, 18804);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_18819_18848(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 18819, 18848);
return return_v;
}


int
f_1316_18921_18936(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 18921, 18936);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_18853_18937(string
name,int
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18853, 18937);
return return_v;
}


int
f_1316_18819_18938(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18819, 18938);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_18953_18982(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 18953, 18982);
return return_v;
}


string
f_1316_19062_19084(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19062, 19084);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_18987_19085(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18987, 19085);
return return_v;
}


int
f_1316_18953_19086(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 18953, 19086);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_19103_19132(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19103, 19132);
return return_v;
}


string
f_1316_19211_19232(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19211, 19232);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_19137_19233(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19137, 19233);
return return_v;
}


int
f_1316_19103_19234(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19103, 19234);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_19249_19278(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19249, 19278);
return return_v;
}


int
f_1316_19357_19378(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ParentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19357, 19378);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_19283_19379(string
name,int
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19283, 19379);
return return_v;
}


int
f_1316_19249_19380(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19249, 19380);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_19395_19424(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19395, 19424);
return return_v;
}


int
f_1316_19502_19522(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19502, 19522);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_19429_19523(string
name,int
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19429, 19523);
return return_v;
}


int
f_1316_19395_19524(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19395, 19524);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_19539_19568(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19539, 19568);
return return_v;
}


System.Management.Automation.ProgressRecordType
f_1316_19635_19650(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.RecordType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19635, 19650);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_19573_19651(string
name,System.Management.Automation.ProgressRecordType
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19573, 19651);
return return_v;
}


int
f_1316_19539_19652(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19539, 19652);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1316_19667_19696(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19667, 19696);
return return_v;
}


int
f_1316_19775_19796(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 19775, 19796);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1316_19701_19797(string
name,int
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19701, 19797);
return return_v;
}


int
f_1316_19667_19798(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 19667, 19798);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1316,18539,19852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,18539,19852);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ProgressRecord()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1316,757,19881);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1316,757,19881);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1316,757,19881);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1316,757,19881);

string
f_1316_1810_1851()
{
var return_v = ProgressRecordStrings.ArgMayNotBeNegative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 1810, 1851);
return return_v;
}


System.Management.Automation.PSArgumentOutOfRangeException
f_1316_1739_1866(string
paramName,int
actualValue,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentOutOfRangeException( paramName, (object)actualValue, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 1739, 1866);
return return_v;
}


bool
f_1316_1902_1932(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 1902, 1932);
return return_v;
}


string
f_1316_2019_2063()
{
var return_v = ProgressRecordStrings.ArgMayNotBeNullOrEmpty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 2019, 2063);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1316_1972_2076(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 1972, 2076);
return return_v;
}


bool
f_1316_2112_2151(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 2112, 2151);
return return_v;
}


string
f_1316_2238_2282()
{
var return_v = ProgressRecordStrings.ArgMayNotBeNullOrEmpty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1316, 2238, 2282);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1316_2191_2304(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1316, 2191, 2304);
return return_v;
}

}

    /// <summary>
    /// Defines two types of progress record that refer to the beginning (or middle) and end of an operation.
    /// </summary>

    public
    enum ProgressRecordType
    {
        ///<summary>
        /// Operation just started or is not yet complete.
        /// </summary>
        /// <remarks>
        /// A cmdlet can call WriteProgress with ProgressRecordType.Processing
        /// as many times as it wishes.  However, at the end of the operation,
        /// it should call once more with ProgressRecordType.Completed.
        ///
        /// The first time that a host receives a progress record
        /// for a given activity, it will typically display a progress
        /// indicator for that activity.  For each subsequent record
        /// of the same Id, the host will update that display.
        /// Finally, when the host receives a 'completed' record
        /// for that activity, it will remove the progress indicator.
        /// </remarks>

        Processing,

        /// <summary>
        /// Operation is complete.
        /// </summary>
        /// <remarks>
        /// If a cmdlet uses WriteProgress, it should use
        /// ProgressRecordType.Completed exactly once, in the last call
        /// to WriteProgress.
        /// </remarks>

        Completed
    }
}

