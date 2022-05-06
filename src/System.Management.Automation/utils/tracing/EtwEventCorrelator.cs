// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Tracing
{
    using System;
    using System.Diagnostics.Eventing;

    /// <summary>
    ///     An object that can be used to manage the ETW activity ID of the current thread.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Etw")]
    public interface IEtwEventCorrelator
    {

Guid CurrentActivityId {get; set; }

IEtwActivityReverter StartActivity(Guid relatedActivityId);

IEtwActivityReverter StartActivity();
    }
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Etw")]
    public class EtwEventCorrelator :
        IEtwEventCorrelator
{
private readonly EventProvider _transferProvider;

private readonly EventDescriptor _transferEvent;

public EtwEventCorrelator(EventProvider transferProvider, EventDescriptor transferEvent)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1053,3034,3385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,2503,2520);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,3147,3276) || true) && (transferProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1053,3147,3276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,3209,3261);

throw f_1053_3215_3260("transferProvider");
DynAbs.Tracing.TraceSender.TraceExitCondition(1053,3147,3276);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,3292,3329);

_transferProvider = transferProvider;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,3343,3374);

_transferEvent = transferEvent;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1053,3034,3385);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1053,3034,3385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1053,3034,3385);
}
		}

public Guid CurrentActivityId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1053,3580,3666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,3616,3651);

return f_1053_3623_3650();
DynAbs.Tracing.TraceSender.TraceExitMethod(1053,3580,3666);

System.Guid
f_1053_3623_3650()
{
var return_v = EtwActivity.GetActivityId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1053, 3623, 3650);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1053,3526,3783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1053,3526,3783);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1053,3682,3772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,3718,3757);

f_1053_3718_3756(ref value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1053,3682,3772);

int
f_1053_3718_3756(ref System.Guid
id)
{
EventProvider.SetActivityId( ref id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1053, 3718, 3756);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1053,3526,3783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1053,3526,3783);
}
		}}

public IEtwActivityReverter StartActivity(Guid relatedActivityId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1053,3926,4432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,4016,4083);

var 
retActivity = f_1053_4034_4082(this, f_1053_4064_4081())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,4097,4150);

CurrentActivityId = f_1053_4117_4149();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,4166,4386) || true) && (relatedActivityId != Guid.Empty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1053,4166,4386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,4235,4274);

var 
tempTransferEvent = _transferEvent
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,4292,4371);

f_1053_4292_4370(                _transferProvider, ref tempTransferEvent, relatedActivityId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1053,4166,4386);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,4402,4421);

return retActivity;
DynAbs.Tracing.TraceSender.TraceExitMethod(1053,3926,4432);

System.Guid
f_1053_4064_4081()
{
var return_v = CurrentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1053, 4064, 4081);
return return_v;
}


System.Management.Automation.Tracing.EtwActivityReverter
f_1053_4034_4082(System.Management.Automation.Tracing.EtwEventCorrelator
correlator,System.Guid
oldActivityId)
{
var return_v = new System.Management.Automation.Tracing.EtwActivityReverter( (System.Management.Automation.Tracing.IEtwEventCorrelator)correlator, oldActivityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1053, 4034, 4082);
return return_v;
}


System.Guid
f_1053_4117_4149()
{
var return_v = EventProvider.CreateActivityId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1053, 4117, 4149);
return return_v;
}


bool
f_1053_4292_4370(System.Diagnostics.Eventing.EventProvider
this_param,ref System.Diagnostics.Eventing.EventDescriptor
eventDescriptor,System.Guid
relatedActivityId,params object[]
eventPayload)
{
var return_v = this_param.WriteTransferEvent( ref eventDescriptor, relatedActivityId, eventPayload);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1053, 4292, 4370);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1053,3926,4432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1053,3926,4432);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public IEtwActivityReverter StartActivity()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1053,4571,4690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1053,4639,4679);

return f_1053_4646_4678(this, f_1053_4660_4677());
DynAbs.Tracing.TraceSender.TraceExitMethod(1053,4571,4690);

System.Guid
f_1053_4660_4677()
{
var return_v = CurrentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1053, 4660, 4677);
return return_v;
}


System.Management.Automation.Tracing.IEtwActivityReverter
f_1053_4646_4678(System.Management.Automation.Tracing.EtwEventCorrelator
this_param,System.Guid
relatedActivityId)
{
var return_v = this_param.StartActivity( relatedActivityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1053, 4646, 4678);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1053,4571,4690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1053,4571,4690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static EtwEventCorrelator()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1053,2253,4697);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1053,2253,4697);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1053,2253,4697);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1053,2253,4697);

System.ArgumentNullException
f_1053_3215_3260(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1053, 3215, 3260);
return return_v;
}

}
}

