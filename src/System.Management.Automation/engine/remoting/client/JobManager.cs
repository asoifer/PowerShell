// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Reflection;
using System.Security;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

// Stops compiler from warning about unknown warnings
#pragma warning disable 1634, 1691

namespace System.Management.Automation
{
public sealed class JobManager
{
private readonly PowerShellTraceSource _tracer ;

private readonly Dictionary<string, JobSourceAdapter> _sourceAdapters ;

private readonly object _syncObject ;

private static readonly Dictionary<Guid, KeyValuePair<int, string>> s_jobIdsForReuse ;

private static readonly object s_syncObject ;

internal JobManager()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1575,1614,1657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,820,875);
this._tracer = f_1575_830_875();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,1046,1119);
this._sourceAdapters = f_1575_1077_1119();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,1156,1182);
this._syncObject = f_1575_1170_1182();DynAbs.Tracing.TraceSender.TraceExitConstructor(1575,1614,1657);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,1614,1657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,1614,1657);
}
		}

public bool IsRegistered(string typeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,1908,2208);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,1974,2070) || true) && (f_1575_1978_2008(typeName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,1974,2070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,2042,2055);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,1974,2070);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,2092,2103);

            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,2137,2182);

return f_1575_2144_2181(_sourceAdapters, typeName);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,1908,2208);

bool
f_1575_1978_2008(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 1978, 2008);
return return_v;
}


bool
f_1575_2144_2181(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 2144, 2181);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,1908,2208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,1908,2208);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RegisterJobSourceAdapter(Type jobSourceAdapterType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,2745,4956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,2835,3000);

f_1575_2835_2999(f_1575_2846_2909(typeof(JobSourceAdapter), jobSourceAdapterType), "BaseType of any type being registered with the JobManager should be JobSourceAdapter.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3014,3144);

f_1575_3014_3143(jobSourceAdapterType != typeof(JobSourceAdapter), "JobSourceAdapter abstract type itself should never be registered.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3158,3263);

f_1575_3158_3262(jobSourceAdapterType != null, "JobSourceAdapterType should never be called with null value.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3277,3300);

object 
instance = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3316,3399);

ConstructorInfo 
constructor = f_1575_3346_3398(jobSourceAdapterType, Type.EmptyTypes)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3413,3801) || true) && (f_1575_3417_3438_M(!constructor.IsPublic))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,3413,3801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3472,3723);

string 
message = f_1575_3489_3722(f_1575_3503_3529(), f_1575_3580_3641(), f_1575_3692_3721(jobSourceAdapterType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3741,3786);

throw f_1575_3747_3785(message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,3413,3801);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3853,3889);

instance = f_1575_3864_3888(constructor, null);
            }
            catch (MemberAccessException exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,3918,4063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,3990,4024);

f_1575_3990_4023(                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4042,4048);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,3918,4063);
            }
            catch (TargetInvocationException exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,4077,4226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4153,4187);

f_1575_4153_4186(                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4205,4211);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,4077,4226);
            }
            catch (TargetParameterCountException exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,4240,4393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4320,4354);

f_1575_4320_4353(                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4372,4378);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,4240,4393);
            }
            catch (NotSupportedException exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,4407,4552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4479,4513);

f_1575_4479_4512(                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4531,4537);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,4407,4552);
            }
            catch (SecurityException exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,4566,4707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4634,4668);

f_1575_4634_4667(                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4686,4692);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,4566,4707);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4723,4945) || true) && (instance != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,4723,4945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4783,4794);
                lock (_syncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,4836,4911);

f_1575_4836_4910(                    _sourceAdapters, f_1575_4856_4881(jobSourceAdapterType), instance);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,4723,4945);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,2745,4956);

bool
f_1575_2846_2909(System.Type
this_param,System.Type
c)
{
var return_v = this_param.IsAssignableFrom( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 2846, 2909);
return return_v;
}


int
f_1575_2835_2999(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 2835, 2999);
return 0;
}


int
f_1575_3014_3143(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 3014, 3143);
return 0;
}


int
f_1575_3158_3262(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 3158, 3262);
return 0;
}


System.Reflection.ConstructorInfo?
f_1575_3346_3398(System.Type
this_param,System.Type[]
types)
{
var return_v = this_param.GetConstructor( types);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 3346, 3398);
return return_v;
}


bool
f_1575_3417_3438_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 3417, 3438);
return return_v;
}


System.Globalization.CultureInfo
f_1575_3503_3529()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 3503, 3529);
return return_v;
}


string
f_1575_3580_3641()
{
var return_v =                                                 RemotingErrorIdStrings.JobManagerRegistrationConstructorError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 3580, 3641);
return return_v;
}


string
f_1575_3692_3721(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 3692, 3721);
return return_v;
}


string
f_1575_3489_3722(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 3489, 3722);
return return_v;
}


System.InvalidOperationException
f_1575_3747_3785(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 3747, 3785);
return return_v;
}


object
f_1575_3864_3888(System.Reflection.ConstructorInfo
this_param,object?[]?
parameters)
{
var return_v = this_param.Invoke( parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 3864, 3888);
return return_v;
}


bool
f_1575_3990_4023(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.MemberAccessException
exception)
{
var return_v = this_param.TraceException( (System.Exception)exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 3990, 4023);
return return_v;
}


bool
f_1575_4153_4186(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Reflection.TargetInvocationException
exception)
{
var return_v = this_param.TraceException( (System.Exception)exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 4153, 4186);
return return_v;
}


bool
f_1575_4320_4353(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Reflection.TargetParameterCountException
exception)
{
var return_v = this_param.TraceException( (System.Exception)exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 4320, 4353);
return return_v;
}


bool
f_1575_4479_4512(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.NotSupportedException
exception)
{
var return_v = this_param.TraceException( (System.Exception)exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 4479, 4512);
return return_v;
}


bool
f_1575_4634_4667(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Security.SecurityException
exception)
{
var return_v = this_param.TraceException( (System.Exception)exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 4634, 4667);
return return_v;
}


string
f_1575_4856_4881(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 4856, 4881);
return return_v;
}


int
f_1575_4836_4910(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param,string
key,object
value)
{
this_param.Add( key, (System.Management.Automation.JobSourceAdapter)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 4836, 4910);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,2745,4956);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,2745,4956);
}
		}

internal static JobIdentifier GetJobIdentifier(Guid instanceId, string typeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1575,5459,5908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,5570,5582);
            lock (s_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,5616,5655);

KeyValuePair<int, string> 
keyValuePair
=default(KeyValuePair<int, string>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,5673,5852) || true) && (f_1575_5677_5735(s_jobIdsForReuse, instanceId, out keyValuePair)&&(DynAbs.Tracing.TraceSender.Expression_True(1575, 5677, 5774)&&f_1575_5739_5774(keyValuePair.Value, typeName)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,5673,5852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,5797,5852);

return f_1575_5804_5851(keyValuePair.Key, instanceId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,5673,5852);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,5870,5882);

return null;
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1575,5459,5908);

bool
f_1575_5677_5735(System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.KeyValuePair<int, string>>
this_param,System.Guid
key,out System.Collections.Generic.KeyValuePair<int, string>
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 5677, 5735);
return return_v;
}


bool
f_1575_5739_5774(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 5739, 5774);
return return_v;
}


System.Management.Automation.JobIdentifier
f_1575_5804_5851(int
id,System.Guid
instanceId)
{
var return_v = new System.Management.Automation.JobIdentifier( id, instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 5804, 5851);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,5459,5908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,5459,5908);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void SaveJobId(Guid instanceId, int id, string typeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1575,6372,6696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,6475,6487);
            lock (s_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,6521,6574) || true) && (f_1575_6525_6565(s_jobIdsForReuse, instanceId))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,6521,6574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,6567,6574);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,6521,6574);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,6592,6670);

f_1575_6592_6669(                s_jobIdsForReuse, instanceId, f_1575_6625_6668(id, typeName));
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1575,6372,6696);

bool
f_1575_6525_6565(System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.KeyValuePair<int, string>>
this_param,System.Guid
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 6525, 6565);
return return_v;
}


System.Collections.Generic.KeyValuePair<int, string>
f_1575_6625_6668(int
key,string
value)
{
var return_v = new System.Collections.Generic.KeyValuePair<int, string>( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 6625, 6668);
return return_v;
}


int
f_1575_6592_6669(System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.KeyValuePair<int, string>>
this_param,System.Guid
key,System.Collections.Generic.KeyValuePair<int, string>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 6592, 6669);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,6372,6696);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,6372,6696);
}
		}

public Job2 NewJob(JobDefinition definition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,7325,8261);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,7394,7511) || true) && (definition == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,7394,7511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,7450,7496);

throw f_1575_7456_7495("definition");
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,7394,7511);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,7527,7592);

JobSourceAdapter 
sourceAdapter = f_1575_7560_7591(this, definition)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,7606,7618);

Job2 
newJob
=default(Job2);

#pragma warning disable 56500
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,7701,7743);

newJob = f_1575_7710_7742(sourceAdapter, definition);
            }
            catch (Exception exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,7772,8189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,8116,8150);

f_1575_8116_8149(                // Since we are calling into 3rd party code
                // catching Exception is allowed. In all
                // other cases the appropriate exception
                // needs to be caught.

                // sourceAdapter.NewJob returned unknown error.
                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,8168,8174);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,7772,8189);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,8236,8250);

return newJob;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,7325,8261);

System.ArgumentNullException
f_1575_7456_7495(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 7456, 7495);
return return_v;
}


System.Management.Automation.JobSourceAdapter
f_1575_7560_7591(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobDefinition
definition)
{
var return_v = this_param.GetJobSourceAdapter( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 7560, 7591);
return return_v;
}


System.Management.Automation.Job2
f_1575_7710_7742(System.Management.Automation.JobSourceAdapter
this_param,System.Management.Automation.JobDefinition
definition)
{
var return_v = this_param.NewJob( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 7710, 7742);
return return_v;
}


bool
f_1575_8116_8149(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 8116, 8149);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,7325,8261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,7325,8261);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Job2 NewJob(JobInvocationInfo specification)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,8871,10039);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,8947,9070) || true) && (specification == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,8947,9070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9006,9055);

throw f_1575_9012_9054("specification");
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,8947,9070);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9086,9265) || true) && (f_1575_9090_9114(specification)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,9086,9265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9156,9250);

throw f_1575_9162_9249(f_1575_9184_9231(), "specification");
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,9086,9265);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9281,9360);

JobSourceAdapter 
sourceAdapter = f_1575_9314_9359(this, f_1575_9334_9358(specification))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9374,9393);

Job2 
newJob = null
;

#pragma warning disable 56500
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9476,9521);

newJob = f_1575_9485_9520(sourceAdapter, specification);
            }
            catch (Exception exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,9550,9967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9894,9928);

f_1575_9894_9927(                // Since we are calling into 3rd party code
                // catching Exception is allowed. In all
                // other cases the appropriate exception
                // needs to be caught.

                // sourceAdapter.NewJob returned unknown error.
                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,9946,9952);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,9550,9967);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,10014,10028);

return newJob;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,8871,10039);

System.ArgumentNullException
f_1575_9012_9054(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 9012, 9054);
return return_v;
}


System.Management.Automation.JobDefinition
f_1575_9090_9114(System.Management.Automation.JobInvocationInfo
this_param)
{
var return_v = this_param.Definition ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 9090, 9114);
return return_v;
}


string
f_1575_9184_9231()
{
var return_v = RemotingErrorIdStrings.NewJobSpecificationError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 9184, 9231);
return return_v;
}


System.ArgumentException
f_1575_9162_9249(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 9162, 9249);
return return_v;
}


System.Management.Automation.JobDefinition
f_1575_9334_9358(System.Management.Automation.JobInvocationInfo
this_param)
{
var return_v = this_param.Definition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 9334, 9358);
return return_v;
}


System.Management.Automation.JobSourceAdapter
f_1575_9314_9359(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobDefinition
definition)
{
var return_v = this_param.GetJobSourceAdapter( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 9314, 9359);
return return_v;
}


System.Management.Automation.Job2
f_1575_9485_9520(System.Management.Automation.JobSourceAdapter
this_param,System.Management.Automation.JobInvocationInfo
specification)
{
var return_v = this_param.NewJob( specification);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 9485, 9520);
return return_v;
}


bool
f_1575_9894_9927(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 9894, 9927);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,8871,10039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,8871,10039);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void PersistJob(Job2 job, JobDefinition definition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,10372,11315);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,10455,10560) || true) && (job == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,10455,10560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,10504,10545);

throw f_1575_10510_10544("job");
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,10455,10560);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,10576,10695) || true) && (definition == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,10576,10695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,10632,10680);

throw f_1575_10638_10679("definition");
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,10576,10695);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,10711,10776);

JobSourceAdapter 
sourceAdapter = f_1575_10744_10775(this, definition)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,10828,10858);

f_1575_10828_10857(                sourceAdapter, job);
            }
            catch (Exception exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,10887,11304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,11231,11265);

f_1575_11231_11264(                // Since we are calling into 3rd party code
                // catching Exception is allowed. In all
                // other cases the appropriate exception
                // needs to be caught.

                // sourceAdapter.NewJob returned unknown error.
                _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,11283,11289);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,10887,11304);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,10372,11315);

System.Management.Automation.PSArgumentNullException
f_1575_10510_10544(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 10510, 10544);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1575_10638_10679(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 10638, 10679);
return return_v;
}


System.Management.Automation.JobSourceAdapter
f_1575_10744_10775(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobDefinition
definition)
{
var return_v = this_param.GetJobSourceAdapter( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 10744, 10775);
return return_v;
}


int
f_1575_10828_10857(System.Management.Automation.JobSourceAdapter
this_param,System.Management.Automation.Job2
job)
{
this_param.PersistJob( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 10828, 10857);
return 0;
}


bool
f_1575_11231_11264(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 11231, 11264);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,10372,11315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,10372,11315);
}
		}

private JobSourceAdapter AssertAndReturnJobSourceAdapter(string adapterTypeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,11818,12278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,11923,11948);

JobSourceAdapter 
adapter
=default(JobSourceAdapter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,11968,11979);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,12013,12221) || true) && (!f_1575_12018_12075(_sourceAdapters, adapterTypeName, out adapter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,12013,12221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,12117,12202);

throw f_1575_12123_12201(f_1575_12153_12200());
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,12013,12221);
}
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,12252,12267);

return adapter;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,11818,12278);

bool
f_1575_12018_12075(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param,string
key,out System.Management.Automation.JobSourceAdapter
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 12018, 12075);
return return_v;
}


string
f_1575_12153_12200()
{
var return_v = RemotingErrorIdStrings.JobSourceAdapterNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 12153, 12200);
return return_v;
}


System.InvalidOperationException
f_1575_12123_12201(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 12123, 12201);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,11818,12278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,11818,12278);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private JobSourceAdapter GetJobSourceAdapter(JobDefinition definition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,12666,15816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,12761,12784);

string 
adapterTypeName
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,12798,13280) || true) && (!f_1575_12803_12860(f_1575_12824_12859(definition)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,12798,13280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,12894,12948);

adapterTypeName = f_1575_12912_12947(definition);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,12798,13280);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,12798,13280);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,12982,13280) || true) && (f_1575_12986_13017(definition)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,12982,13280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13059,13114);

adapterTypeName = f_1575_13077_13113(f_1575_13077_13108(definition));
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,12982,13280);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,12982,13280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13180,13265);

throw f_1575_13186_13264(f_1575_13216_13263());
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,12982,13280);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,12798,13280);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13296,13321);

JobSourceAdapter 
adapter
=default(JobSourceAdapter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13335,13361);

bool 
adapterFound = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13381,13392);
            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13426,13499);

adapterFound = f_1575_13441_13498(_sourceAdapters, adapterTypeName, out adapter);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13530,15774) || true) && (!adapterFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,13530,15774);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13581,15759) || true) && (!f_1575_13586_13629(f_1575_13607_13628(definition)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,13581,15759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13723,13743);

Exception 
ex = null
;
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13817,13880);

InitialSessionState 
iss = f_1575_13843_13879()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13906,13927);

f_1575_13906_13926(f_1575_13906_13918(iss));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13953,13973);

f_1575_13953_13972(f_1575_13953_13964(iss));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,13999,14127);

f_1575_13999_14126(f_1575_13999_14011(iss), f_1575_14016_14125("Import-Module", typeof(Microsoft.PowerShell.Commands.ImportModuleCommand), null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14153,14671);
using(PowerShell 
powerShell = f_1575_14184_14206(iss)
)                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14264,14303);

f_1575_14264_14302(                            powerShell, "Import-Module");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14333,14388);

f_1575_14333_14387(                            powerShell, "Name", f_1575_14365_14386(definition));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14418,14438);

f_1575_14418_14437(                            powerShell);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14470,14644) || true) && (f_1575_14474_14502(f_1575_14474_14496(powerShell))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,14470,14644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14572,14613);

ex = f_1575_14577_14612(f_1575_14577_14602(f_1575_14577_14599(powerShell), 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,14470,14644);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1575,14153,14671);
                        }
                    }
                    catch (RuntimeException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,14716,14821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14791,14798);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,14716,14821);
                    }
                    catch (InvalidOperationException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,14843,14957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,14927,14934);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,14843,14957);
                    }
                    catch (ScriptCallDepthException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,14979,15092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,15062,15069);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,14979,15092);
                    }
                    catch (SecurityException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,15114,15220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,15190,15197);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,15114,15220);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,15244,15420) || true) && (ex != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,15244,15420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,15308,15397);

throw f_1575_15314_15396(f_1575_15344_15391(), ex);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,15244,15420);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,15514,15573);

adapter = f_1575_15524_15572(this, adapterTypeName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,13581,15759);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,13581,15759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,15655,15740);

throw f_1575_15661_15739(f_1575_15691_15738());
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,13581,15759);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,13530,15774);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,15790,15805);

return adapter;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,12666,15816);

string
f_1575_12824_12859(System.Management.Automation.JobDefinition
this_param)
{
var return_v = this_param.JobSourceAdapterTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 12824, 12859);
return return_v;
}


bool
f_1575_12803_12860(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 12803, 12860);
return return_v;
}


string
f_1575_12912_12947(System.Management.Automation.JobDefinition
this_param)
{
var return_v = this_param.JobSourceAdapterTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 12912, 12947);
return return_v;
}


System.Type
f_1575_12986_13017(System.Management.Automation.JobDefinition
this_param)
{
var return_v = this_param.JobSourceAdapterType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 12986, 13017);
return return_v;
}


System.Type
f_1575_13077_13108(System.Management.Automation.JobDefinition
this_param)
{
var return_v = this_param.JobSourceAdapterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 13077, 13108);
return return_v;
}


string
f_1575_13077_13113(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 13077, 13113);
return return_v;
}


string
f_1575_13216_13263()
{
var return_v = RemotingErrorIdStrings.JobSourceAdapterNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 13216, 13263);
return return_v;
}


System.InvalidOperationException
f_1575_13186_13264(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 13186, 13264);
return return_v;
}


bool
f_1575_13441_13498(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param,string
key,out System.Management.Automation.JobSourceAdapter
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 13441, 13498);
return return_v;
}


string
f_1575_13607_13628(System.Management.Automation.JobDefinition
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 13607, 13628);
return return_v;
}


bool
f_1575_13586_13629(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 13586, 13629);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionState
f_1575_13843_13879()
{
var return_v = InitialSessionState.CreateDefault2();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 13843, 13879);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
f_1575_13906_13918(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 13906, 13918);
return return_v;
}


int
f_1575_13906_13926(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 13906, 13926);
return 0;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateFormatEntry>
f_1575_13953_13964(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Formats;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 13953, 13964);
return return_v;
}


int
f_1575_13953_13972(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateFormatEntry>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 13953, 13972);
return 0;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
f_1575_13999_14011(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 13999, 14011);
return return_v;
}


System.Management.Automation.Runspaces.SessionStateCmdletEntry
f_1575_14016_14125(string
name,System.Type
implementingType,string
helpFileName)
{
var return_v = new System.Management.Automation.Runspaces.SessionStateCmdletEntry( name, implementingType, helpFileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 14016, 14125);
return return_v;
}


int
f_1575_13999_14126(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
this_param,System.Management.Automation.Runspaces.SessionStateCmdletEntry
item)
{
this_param.Add( (System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 13999, 14126);
return 0;
}


System.Management.Automation.PowerShell
f_1575_14184_14206(System.Management.Automation.Runspaces.InitialSessionState
initialSessionState)
{
var return_v = PowerShell.Create( initialSessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 14184, 14206);
return return_v;
}


System.Management.Automation.PowerShell
f_1575_14264_14302(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 14264, 14302);
return return_v;
}


string
f_1575_14365_14386(System.Management.Automation.JobDefinition
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 14365, 14386);
return return_v;
}


System.Management.Automation.PowerShell
f_1575_14333_14387(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 14333, 14387);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1575_14418_14437(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 14418, 14437);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1575_14474_14496(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ErrorBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 14474, 14496);
return return_v;
}


int
f_1575_14474_14502(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 14474, 14502);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1575_14577_14599(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ErrorBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 14577, 14599);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1575_14577_14602(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 14577, 14602);
return return_v;
}


System.Exception
f_1575_14577_14612(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 14577, 14612);
return return_v;
}


string
f_1575_15344_15391()
{
var return_v = RemotingErrorIdStrings.JobSourceAdapterNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 15344, 15391);
return return_v;
}


System.InvalidOperationException
f_1575_15314_15396(string
message,System.Exception
innerException)
{
var return_v = new System.InvalidOperationException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 15314, 15396);
return return_v;
}


System.Management.Automation.JobSourceAdapter
f_1575_15524_15572(System.Management.Automation.JobManager
this_param,string
adapterTypeName)
{
var return_v = this_param.AssertAndReturnJobSourceAdapter( adapterTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 15524, 15572);
return return_v;
}


string
f_1575_15691_15738()
{
var return_v = RemotingErrorIdStrings.JobSourceAdapterNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 15691, 15738);
return return_v;
}


System.InvalidOperationException
f_1575_15661_15739(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 15661, 15739);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,12666,15816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,12666,15816);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job2> GetJobs(
            Cmdlet cmdlet,
            bool writeErrorOnException,
            bool writeObject,
            string[] jobSourceAdapterTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,16430,16759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,16628,16748);

return f_1575_16635_16747(this, null, FilterType.None, cmdlet, writeErrorOnException, writeObject, false, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,16430,16759);

System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_16635_16747(System.Management.Automation.JobManager
this_param,object
filter,System.Management.Automation.JobManager.FilterType
filterType,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetFilteredJobs( filter, filterType, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 16635, 16747);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,16430,16759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,16430,16759);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job2> GetJobsByName(
            string name,
            Cmdlet cmdlet,
            bool writeErrorOnException,
            bool writeObject,
            bool recurse,
            string[] jobSourceAdapterTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,17581,17971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,17838,17960);

return f_1575_17845_17959(this, name, FilterType.Name, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,17581,17971);

System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_17845_17959(System.Management.Automation.JobManager
this_param,string
filter,System.Management.Automation.JobManager.FilterType
filterType,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetFilteredJobs( (object)filter, filterType, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 17845, 17959);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,17581,17971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,17581,17971);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job2> GetJobsByCommand(
            string command,
            Cmdlet cmdlet,
            bool writeErrorOnException,
            bool writeObject,
            bool recurse,
            string[] jobSourceAdapterTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,18737,19139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,19000,19128);

return f_1575_19007_19127(this, command, FilterType.Command, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,18737,19139);

System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_19007_19127(System.Management.Automation.JobManager
this_param,string
filter,System.Management.Automation.JobManager.FilterType
filterType,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetFilteredJobs( (object)filter, filterType, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 19007, 19127);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,18737,19139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,18737,19139);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job2> GetJobsByState(
            JobState state,
            Cmdlet cmdlet,
            bool writeErrorOnException,
            bool writeObject,
            bool recurse,
            string[] jobSourceAdapterTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,19893,20289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,20154,20278);

return f_1575_20161_20277(this, state, FilterType.State, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,19893,20289);

System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_20161_20277(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobState
filter,System.Management.Automation.JobManager.FilterType
filterType,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetFilteredJobs( (object)filter, filterType, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 20161, 20277);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,19893,20289);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,19893,20289);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job2> GetJobsByFilter(Dictionary<string, object> filter, Cmdlet cmdlet, bool writeErrorOnException, bool writeObject, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,21062,21352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,21232,21341);

return f_1575_21239_21340(this, filter, FilterType.Filter, cmdlet, writeErrorOnException, writeObject, recurse, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,21062,21352);

System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_21239_21340(System.Management.Automation.JobManager
this_param,System.Collections.Generic.Dictionary<string, object>
filter,System.Management.Automation.JobManager.FilterType
filterType,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetFilteredJobs( (object)filter, filterType, cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 21239, 21340);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,21062,21352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,21062,21352);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsJobFromAdapter(Guid id, string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,21608,22122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,21691,21702);
            lock (_syncObject)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,21736,22067);
foreach(JobSourceAdapter sourceAdapter in f_1575_21779_21801_I(f_1575_21779_21801(_sourceAdapters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,21736,22067);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,21843,22048) || true) && (f_1575_21847_21914(f_1575_21847_21865(sourceAdapter), name, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,21843,22048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,21964,22025);

return (f_1575_21972_22015(sourceAdapter, id, false)!= null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,21843,22048);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,21736,22067);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,332);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,332);
}            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,22098,22111);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,21608,22122);

System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_21779_21801(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 21779, 21801);
return return_v;
}


string
f_1575_21847_21865(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 21847, 21865);
return return_v;
}


bool
f_1575_21847_21914(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 21847, 21914);
return return_v;
}


System.Management.Automation.Job2
f_1575_21972_22015(System.Management.Automation.JobSourceAdapter
this_param,System.Guid
instanceId,bool
recurse)
{
var return_v = this_param.GetJobByInstanceId( instanceId, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 21972, 22015);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_21779_21801_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 21779, 21801);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,21608,22122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,21608,22122);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<Job2> GetFilteredJobs(
            object filter,
            FilterType filterType,
            Cmdlet cmdlet,
            bool writeErrorOnException,
            bool writeObject,
            bool recurse,
            string[] jobSourceAdapterTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,23019,25107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23315,23391);

f_1575_23315_23390(cmdlet != null, "Cmdlet should be passed to JobManager");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23407,23445);

List<Job2> 
allJobs = f_1575_23428_23444()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23467,23478);

            lock (_syncObject)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23512,24857);
foreach(JobSourceAdapter sourceAdapter in f_1575_23555_23577_I(f_1575_23555_23577(_sourceAdapters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,23512,24857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23619,23642);

List<Job2> 
jobs = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23751,23890) || true) && (!f_1575_23756_23808(this, sourceAdapter, jobSourceAdapterTypes))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,23751,23890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23858,23867);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,23751,23890);
}

#pragma warning disable 56500
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,23997,24062);

jobs = f_1575_24004_24061(sourceAdapter, filter, filterType, recurse);
                    }
                    catch (Exception exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,24107,24711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,24519,24553);

f_1575_24519_24552(                        // Since we are calling into 3rd party code
                        // catching Exception is allowed. In all
                        // other cases the appropriate exception
                        // needs to be caught.

                        // sourceAdapter.GetJobsByFilter() threw unknown exception.
                        _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,24579,24688);

f_1575_24579_24687(writeErrorOnException, cmdlet, exception, "JobSourceAdapterGetJobsError", sourceAdapter);
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,24107,24711);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,24766,24793) || true) && (jobs == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,24766,24793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,24784,24793);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,24766,24793);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,24815,24838);

f_1575_24815_24837(                    allJobs, jobs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,23512,24857);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,1346);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,1346);
}            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,24888,25065) || true) && (writeObject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,24888,25065);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,24937,25050);
foreach(Job2 job in f_1575_24958_24965_I(allJobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,24937,25050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,25007,25031);

f_1575_25007_25030(                    cmdlet, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,24937,25050);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,114);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,114);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1575,24888,25065);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,25081,25096);

return allJobs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,23019,25107);

int
f_1575_23315_23390(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 23315, 23390);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_23428_23444()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job2>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 23428, 23444);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_23555_23577(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 23555, 23577);
return return_v;
}


bool
f_1575_23756_23808(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobSourceAdapter
sourceAdapter,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.CheckTypeNames( sourceAdapter, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 23756, 23808);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_24004_24061(System.Management.Automation.JobSourceAdapter
sourceAdapter,object
filter,System.Management.Automation.JobManager.FilterType
filterType,bool
recurse)
{
var return_v = CallJobFilter( sourceAdapter, filter, filterType, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 24004, 24061);
return return_v;
}


bool
f_1575_24519_24552(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 24519, 24552);
return return_v;
}


int
f_1575_24579_24687(bool
writeErrorOnException,System.Management.Automation.Cmdlet
cmdlet,System.Exception
exception,string
identifier,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
WriteErrorOrWarning( writeErrorOnException, cmdlet, exception, identifier, sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 24579, 24687);
return 0;
}


int
f_1575_24815_24837(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param,System.Collections.Generic.List<System.Management.Automation.Job2>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job2>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 24815, 24837);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_23555_23577_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 23555, 23577);
return return_v;
}


int
f_1575_25007_25030(System.Management.Automation.Cmdlet
this_param,System.Management.Automation.Job2
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 25007, 25030);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_24958_24965_I(System.Collections.Generic.List<System.Management.Automation.Job2>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 24958, 24965);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,23019,25107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,23019,25107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CheckTypeNames(JobSourceAdapter sourceAdapter, string[] jobSourceAdapterTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,25409,26367);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,25603,25751) || true) && (jobSourceAdapterTypes == null ||(DynAbs.Tracing.TraceSender.Expression_False(1575, 25607, 25690)||f_1575_25657_25685(jobSourceAdapterTypes)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,25603,25751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,25724,25736);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,25603,25751);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,25767,25824);

string 
sourceAdapterName = f_1575_25794_25823(this, sourceAdapter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,25838,25928);

f_1575_25838_25927(sourceAdapterName != null, "Source adapter should have name or type.");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,26000,26327);
foreach(string typeName in f_1575_26028_26049_I(jobSourceAdapterTypes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,26000,26327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,26083,26175);

WildcardPattern 
typeNamePattern = f_1575_26117_26174(typeName, WildcardOptions.IgnoreCase)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,26193,26312) || true) && (f_1575_26197_26239(typeNamePattern, sourceAdapterName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,26193,26312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,26281,26293);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,26193,26312);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,26000,26327);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,328);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,328);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,26343,26356);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,25409,26367);

int
f_1575_25657_25685(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 25657, 25685);
return return_v;
}


string
f_1575_25794_25823(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
var return_v = this_param.GetAdapterName( sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 25794, 25823);
return return_v;
}


int
f_1575_25838_25927(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 25838, 25927);
return 0;
}


System.Management.Automation.WildcardPattern
f_1575_26117_26174(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 26117, 26174);
return return_v;
}


bool
f_1575_26197_26239(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 26197, 26239);
return return_v;
}


string[]
f_1575_26028_26049_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 26028, 26049);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,25409,26367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,25409,26367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetAdapterName(JobSourceAdapter sourceAdapter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,26379,26627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,26465,26616);

return ((DynAbs.Tracing.TraceSender.Conditional_F1(1575, 26473, 26522)||((f_1575_26473_26513(f_1575_26494_26512(sourceAdapter))== false &&DynAbs.Tracing.TraceSender.Conditional_F2(1575, 26542, 26560))||DynAbs.Tracing.TraceSender.Conditional_F3(1575, 26580, 26614)))?f_1575_26542_26560(sourceAdapter):f_1575_26580_26614(f_1575_26580_26603(                sourceAdapter)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,26379,26627);

string
f_1575_26494_26512(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 26494, 26512);
return return_v;
}


bool
f_1575_26473_26513(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 26473, 26513);
return return_v;
}


string
f_1575_26542_26560(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 26542, 26560);
return return_v;
}


System.Type
f_1575_26580_26603(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 26580, 26603);
return return_v;
}


string
f_1575_26580_26614(System.Type
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 26580, 26614);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,26379,26627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,26379,26627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static List<Job2> CallJobFilter(JobSourceAdapter sourceAdapter, object filter, FilterType filterType, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1575,27215,28436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,27363,27398);

List<Job2> 
jobs = f_1575_27381_27397()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,27412,27432);

IList<Job2> 
matches
=default(IList<Job2>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,27448,28290);

switch (filterType)
            {

case FilterType.Command:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,27448,28290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,27548,27614);

matches = f_1575_27558_27613(sourceAdapter, filter, recurse);
DynAbs.Tracing.TraceSender.TraceBreak(1575,27636,27642);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,27448,28290);

case FilterType.Filter:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,27448,28290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,27705,27790);

matches = f_1575_27715_27789(sourceAdapter, filter, recurse);
DynAbs.Tracing.TraceSender.TraceBreak(1575,27812,27818);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,27448,28290);

case FilterType.Name:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,27448,28290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,27879,27942);

matches = f_1575_27889_27941(sourceAdapter, filter, recurse);
DynAbs.Tracing.TraceSender.TraceBreak(1575,27964,27970);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,27448,28290);

case FilterType.State:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,27448,28290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,28032,28098);

matches = f_1575_28042_28097(sourceAdapter, filter, recurse);
DynAbs.Tracing.TraceSender.TraceBreak(1575,28120,28126);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,27448,28290);

case FilterType.None:
                default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,27448,28290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,28213,28247);

matches = f_1575_28223_28246(sourceAdapter);
DynAbs.Tracing.TraceSender.TraceBreak(1575,28269,28275);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,27448,28290);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,28306,28397) || true) && (matches != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,28306,28397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,28359,28382);

f_1575_28359_28381(                jobs, matches);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,28306,28397);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,28413,28425);

return jobs;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1575,27215,28436);

System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_27381_27397()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job2>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 27381, 27397);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job2>
f_1575_27558_27613(System.Management.Automation.JobSourceAdapter
this_param,object
command,bool
recurse)
{
var return_v = this_param.GetJobsByCommand( (string)command, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 27558, 27613);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job2>
f_1575_27715_27789(System.Management.Automation.JobSourceAdapter
this_param,object
filter,bool
recurse)
{
var return_v = this_param.GetJobsByFilter( (System.Collections.Generic.Dictionary<string, object>)filter, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 27715, 27789);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job2>
f_1575_27889_27941(System.Management.Automation.JobSourceAdapter
this_param,object
name,bool
recurse)
{
var return_v = this_param.GetJobsByName( (string)name, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 27889, 27941);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job2>
f_1575_28042_28097(System.Management.Automation.JobSourceAdapter
this_param,object
state,bool
recurse)
{
var return_v = this_param.GetJobsByState( (System.Management.Automation.JobState)state, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 28042, 28097);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job2>
f_1575_28223_28246(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.GetJobs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 28223, 28246);
return return_v;
}


int
f_1575_28359_28381(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param,System.Collections.Generic.IList<System.Management.Automation.Job2>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job2>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 28359, 28381);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,27215,28436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,27215,28436);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Job2 GetJobById(int id, Cmdlet cmdlet, bool writeErrorOnException, bool writeObject, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,29094,29334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,29226,29323);

return f_1575_29233_29322(this, Guid.Empty, id, cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,29094,29334);

System.Management.Automation.Job2
f_1575_29233_29322(System.Management.Automation.JobManager
this_param,System.Guid
guid,int
id,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobThroughId<int>( guid, id, cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 29233, 29322);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,29094,29334);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,29094,29334);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Job2 GetJobByInstanceId(Guid instanceId, Cmdlet cmdlet, bool writeErrorOnException, bool writeObject, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,29960,30217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30109,30206);

return f_1575_30116_30205(this, instanceId, 0, cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,29960,30217);

System.Management.Automation.Job2
f_1575_30116_30205(System.Management.Automation.JobManager
this_param,System.Guid
guid,int
id,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobThroughId<System.Guid>( guid, id, cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 30116, 30205);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,29960,30217);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,29960,30217);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Job2 GetJobThroughId<T>(Guid guid, int id, Cmdlet cmdlet, bool writeErrorOnException, bool writeObject, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,30229,32246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30379,30462);

f_1575_30379_30461(cmdlet != null, "Cmdlet should always be passed to JobManager");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30476,30492);

Job2 
job = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30512,30523);
            lock (_syncObject)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30557,32192);
foreach(JobSourceAdapter sourceAdapter in f_1575_30600_30622_I(f_1575_30600_30622(_sourceAdapters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,30557,32192);
                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30716,31289) || true) && (typeof(T) == typeof(Guid))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,30716,31289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30803,30873);

f_1575_30803_30872(id == 0, "id must be zero when invoked with guid");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,30903,30957);

job = f_1575_30909_30956(sourceAdapter, guid, recurse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,30716,31289);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,30716,31289);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,31015,31289) || true) && (typeof(T) == typeof(int))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,31015,31289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,31101,31181);

f_1575_31101_31180(guid == Guid.Empty, "Guid must be empty when used with int");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,31211,31262);

job = f_1575_31217_31261(sourceAdapter, id, recurse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,31015,31289);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,30716,31289);
}
                    }
                    catch (Exception exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,31334,31952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,31747,31781);

f_1575_31747_31780(                        // Since we are calling into 3rd party code
                        // catching Exception is allowed. In all
                        // other cases the appropriate exception
                        // needs to be caught.

                        // sourceAdapter.GetJobByInstanceId threw unknown exception.
                        _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,31809,31929);

f_1575_31809_31928(writeErrorOnException, cmdlet, exception, "JobSourceAdapterGetJobByInstanceIdError", sourceAdapter);
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,31334,31952);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,31976,32002) || true) && (job == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,31976,32002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,31993,32002);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,31976,32002);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,32026,32138) || true) && (writeObject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,32026,32138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,32091,32115);

f_1575_32091_32114(                        cmdlet, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,32026,32138);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,32162,32173);

return job;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,30557,32192);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,1636);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,1636);
}            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,32223,32235);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,30229,32246);

int
f_1575_30379_30461(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 30379, 30461);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_30600_30622(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 30600, 30622);
return return_v;
}


int
f_1575_30803_30872(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 30803, 30872);
return 0;
}


System.Management.Automation.Job2
f_1575_30909_30956(System.Management.Automation.JobSourceAdapter
this_param,System.Guid
instanceId,bool
recurse)
{
var return_v = this_param.GetJobByInstanceId( instanceId, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 30909, 30956);
return return_v;
}


int
f_1575_31101_31180(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 31101, 31180);
return 0;
}


System.Management.Automation.Job2
f_1575_31217_31261(System.Management.Automation.JobSourceAdapter
this_param,int
id,bool
recurse)
{
var return_v = this_param.GetJobBySessionId( id, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 31217, 31261);
return return_v;
}


bool
f_1575_31747_31780(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 31747, 31780);
return return_v;
}


int
f_1575_31809_31928(bool
writeErrorOnException,System.Management.Automation.Cmdlet
cmdlet,System.Exception
exception,string
identifier,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
WriteErrorOrWarning( writeErrorOnException, cmdlet, exception, identifier, sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 31809, 31928);
return 0;
}


int
f_1575_32091_32114(System.Management.Automation.Cmdlet
this_param,System.Management.Automation.Job2
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 32091, 32114);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_30600_30622_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 30600, 30622);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,30229,32246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,30229,32246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job2> GetJobToStart(
            string definitionName,
            string definitionPath,
            string definitionType,
            Cmdlet cmdlet,
            bool writeErrorOnException)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,32965,35067);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33201,33236);

List<Job2> 
jobs = f_1575_33219_33235()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33250,33399);

WildcardPattern 
typeNamePattern = (DynAbs.Tracing.TraceSender.Conditional_F1(1575, 33284, 33308)||(((definitionType != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1575, 33328, 33391))||DynAbs.Tracing.TraceSender.Conditional_F3(1575, 33394, 33398)))?f_1575_33328_33391(definitionType, WildcardOptions.IgnoreCase):null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33421,33432);

            lock (_syncObject)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33466,35013);
foreach(JobSourceAdapter sourceAdapter in f_1575_33509_33531_I(f_1575_33509_33531(_sourceAdapters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,33466,35013);
                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33625,33977) || true) && (typeNamePattern != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,33625,33977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33710,33767);

string 
sourceAdapterName = f_1575_33737_33766(this, sourceAdapter)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33797,33950) || true) && (!f_1575_33802_33844(typeNamePattern, sourceAdapterName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,33797,33950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,33910,33919);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,33797,33950);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,33625,33977);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,34005,34069);

Job2 
job = f_1575_34016_34068(sourceAdapter, definitionName, definitionPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,34095,34209) || true) && (job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,34095,34209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,34168,34182);

f_1575_34168_34181(                            jobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,34095,34209);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,34237,34417) || true) && (typeNamePattern != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,34237,34417);
DynAbs.Tracing.TraceSender.TraceBreak(1575,34384,34390);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,34237,34417);
}
                    }
                    catch (Exception exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,34462,34994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,34789,34823);

f_1575_34789_34822(                        // Since we are calling into 3rd party code
                        // catching Exception is allowed. In all
                        // other cases the appropriate exception
                        // needs to be caught.

                        _tracer, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,34851,34971);

f_1575_34851_34970(writeErrorOnException, cmdlet, exception, "JobSourceAdapterGetJobByInstanceIdError", sourceAdapter);
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,34462,34994);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,33466,35013);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,1548);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,1548);
}            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,35044,35056);

return jobs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,32965,35067);

System.Collections.Generic.List<System.Management.Automation.Job2>
f_1575_33219_33235()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job2>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 33219, 33235);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1575_33328_33391(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 33328, 33391);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_33509_33531(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 33509, 33531);
return return_v;
}


string
f_1575_33737_33766(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
var return_v = this_param.GetAdapterName( sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 33737, 33766);
return return_v;
}


bool
f_1575_33802_33844(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 33802, 33844);
return return_v;
}


System.Management.Automation.Job2
f_1575_34016_34068(System.Management.Automation.JobSourceAdapter
this_param,string
definitionName,string
definitionPath)
{
var return_v = this_param.NewJob( definitionName, definitionPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 34016, 34068);
return return_v;
}


int
f_1575_34168_34181(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param,System.Management.Automation.Job2
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 34168, 34181);
return 0;
}


bool
f_1575_34789_34822(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 34789, 34822);
return return_v;
}


int
f_1575_34851_34970(bool
writeErrorOnException,System.Management.Automation.Cmdlet
cmdlet,System.Exception
exception,string
identifier,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
WriteErrorOrWarning( writeErrorOnException, cmdlet, exception, identifier, sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 34851, 34970);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_33509_33531_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 33509, 33531);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,32965,35067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,32965,35067);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void WriteErrorOrWarning(bool writeErrorOnException, Cmdlet cmdlet, Exception exception, string identifier, JobSourceAdapter sourceAdapter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1575,35079,36234);
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,35294,35951) || true) && (writeErrorOnException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,35294,35951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,35361,35459);

f_1575_35361_35458(                    cmdlet, f_1575_35379_35457(exception, identifier, ErrorCategory.OpenError, sourceAdapter));
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,35294,35951);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,35294,35951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,35581,35881);

string 
message = f_1575_35598_35880(f_1575_35612_35638(), f_1575_35692_35736(), f_1575_35790_35807(exception), f_1575_35861_35879(sourceAdapter))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,35903,35932);

f_1575_35903_35931(                    cmdlet, message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,35294,35951);
}
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,35980,36223);
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,35980,36223);
                // if this call is not made from a cmdlet thread or if
                // the cmdlet is closed this will thrown an exception
                // it is fine to eat that exception
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1575,35079,36234);

System.Management.Automation.ErrorRecord
f_1575_35379_35457(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.JobSourceAdapter
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 35379, 35457);
return return_v;
}


int
f_1575_35361_35458(System.Management.Automation.Cmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 35361, 35458);
return 0;
}


System.Globalization.CultureInfo
f_1575_35612_35638()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 35612, 35638);
return return_v;
}


string
f_1575_35692_35736()
{
var return_v =                                                    RemotingErrorIdStrings.JobSourceAdapterError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 35692, 35736);
return return_v;
}


string
f_1575_35790_35807(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 35790, 35807);
return return_v;
}


string
f_1575_35861_35879(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 35861, 35879);
return return_v;
}


string
f_1575_35598_35880(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 35598, 35880);
return return_v;
}


int
f_1575_35903_35931(System.Management.Automation.Cmdlet
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 35903, 35931);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,35079,36234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,35079,36234);
}
		}

internal List<string> GetLoadedAdapterNames(string[] adapterTypeNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,36483,37050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,36578,36625);

List<string> 
adapterNames = f_1575_36606_36624()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,36645,36656);
            lock (_syncObject)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,36690,36988);
foreach(JobSourceAdapter sourceAdapter in f_1575_36733_36755_I(f_1575_36733_36755(_sourceAdapters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,36690,36988);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,36797,36969) || true) && (f_1575_36801_36848(this, sourceAdapter, adapterTypeNames))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,36797,36969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,36898,36946);

f_1575_36898_36945(                        adapterNames, f_1575_36915_36944(this, sourceAdapter));
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,36797,36969);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,36690,36988);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,299);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,299);
}            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,37019,37039);

return adapterNames;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,36483,37050);

System.Collections.Generic.List<string>
f_1575_36606_36624()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 36606, 36624);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_36733_36755(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 36733, 36755);
return return_v;
}


bool
f_1575_36801_36848(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobSourceAdapter
sourceAdapter,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.CheckTypeNames( sourceAdapter, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 36801, 36848);
return return_v;
}


string
f_1575_36915_36944(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
var return_v = this_param.GetAdapterName( sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 36915, 36944);
return return_v;
}


int
f_1575_36898_36945(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 36898, 36945);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_36733_36755_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 36733, 36755);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,36483,37050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,36483,37050);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveJob(int sessionJobId, Cmdlet cmdlet, bool writeErrorOnException)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,37406,37651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,37515,37596);

Job2 
job = f_1575_37526_37595(this, sessionJobId, cmdlet, writeErrorOnException, false, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,37610,37640);

f_1575_37610_37639(this, job, cmdlet, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,37406,37651);

System.Management.Automation.Job2
f_1575_37526_37595(System.Management.Automation.JobManager
this_param,int
id,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobById( id, cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 37526, 37595);
return return_v;
}


bool
f_1575_37610_37639(System.Management.Automation.JobManager
this_param,System.Management.Automation.Job2
job,System.Management.Automation.Cmdlet
cmdlet,bool
writeErrorOnException)
{
var return_v = this_param.RemoveJob( job, cmdlet, writeErrorOnException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 37610, 37639);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,37406,37651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,37406,37651);
}
		}

internal bool RemoveJob(Job2 job, Cmdlet cmdlet, bool writeErrorOnException, bool throwExceptions = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,38189,40866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,38320,38342);

bool 
jobFound = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,38364,38375);

            lock (_syncObject)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,38409,40472);
foreach(JobSourceAdapter sourceAdapter in f_1575_38452_38474_I(f_1575_38452_38474(_sourceAdapters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,38409,40472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,38516,38537);

Job2 
foundJob = null
;
#pragma warning disable 56500
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,38642,38708);

foundJob = f_1575_38653_38707(sourceAdapter, f_1575_38686_38700(job), true);
                    }
                    catch (Exception exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,38753,39412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39168,39202);

f_1575_39168_39201(                        // Since we are calling into 3rd party code
                        // catching Exception is allowed. In all
                        // other cases the appropriate exception
                        // needs to be caught.

                        // sourceAdapter.GetJobByInstanceId() threw unknown exception.
                        _tracer, exception);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39228,39255) || true) && (throwExceptions)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,39228,39255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39249,39255);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,39228,39255);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39281,39389);

f_1575_39281_39388(writeErrorOnException, cmdlet, exception, "JobSourceAdapterGetJobError", sourceAdapter);
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,38753,39412);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39467,39498) || true) && (foundJob == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,39467,39498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39489,39498);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,39467,39498);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39520,39536);

jobFound = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39558,39588);

f_1575_39558_39587(this, foundJob);

#pragma warning disable 56500
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,39695,39724);

f_1575_39695_39723(                        sourceAdapter, job);
                    }
                    catch (Exception exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1575,39769,40422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40175,40209);

f_1575_40175_40208(                        // Since we are calling into 3rd party code
                        // catching Exception is allowed. In all
                        // other cases the appropriate exception
                        // needs to be caught.
                        // sourceAdapter.RemoveJob() threw unknown exception.

                        _tracer, exception);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40235,40262) || true) && (throwExceptions)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,40235,40262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40256,40262);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,40235,40262);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40288,40399);

f_1575_40288_40398(writeErrorOnException, cmdlet, exception, "JobSourceAdapterRemoveJobError", sourceAdapter);
DynAbs.Tracing.TraceSender.TraceExitCatch(1575,39769,40422);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,38409,40472);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,2064);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,2064);
}            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40503,40823) || true) && (!jobFound &&(DynAbs.Tracing.TraceSender.Expression_True(1575, 40507, 40535)&&throwExceptions))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,40503,40823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40569,40753);

var 
message = f_1575_40583_40752(f_1575_40630_40677(), "Job repository", job.InstanceId.ToString())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40771,40808);

throw f_1575_40777_40807(message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,40503,40823);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40839,40855);

return jobFound;
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,38189,40866);

System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_38452_38474(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 38452, 38474);
return return_v;
}


System.Guid
f_1575_38686_38700(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 38686, 38700);
return return_v;
}


System.Management.Automation.Job2
f_1575_38653_38707(System.Management.Automation.JobSourceAdapter
this_param,System.Guid
instanceId,bool
recurse)
{
var return_v = this_param.GetJobByInstanceId( instanceId, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 38653, 38707);
return return_v;
}


bool
f_1575_39168_39201(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 39168, 39201);
return return_v;
}


int
f_1575_39281_39388(bool
writeErrorOnException,System.Management.Automation.Cmdlet
cmdlet,System.Exception
exception,string
identifier,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
WriteErrorOrWarning( writeErrorOnException, cmdlet, exception, identifier, sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 39281, 39388);
return 0;
}


int
f_1575_39558_39587(System.Management.Automation.JobManager
this_param,System.Management.Automation.Job2
job)
{
this_param.RemoveJobIdForReuse( (System.Management.Automation.Job)job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 39558, 39587);
return 0;
}


int
f_1575_39695_39723(System.Management.Automation.JobSourceAdapter
this_param,System.Management.Automation.Job2
job)
{
this_param.RemoveJob( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 39695, 39723);
return 0;
}


bool
f_1575_40175_40208(System.Management.Automation.Tracing.PowerShellTraceSource
this_param,System.Exception
exception)
{
var return_v = this_param.TraceException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 40175, 40208);
return return_v;
}


int
f_1575_40288_40398(bool
writeErrorOnException,System.Management.Automation.Cmdlet
cmdlet,System.Exception
exception,string
identifier,System.Management.Automation.JobSourceAdapter
sourceAdapter)
{
WriteErrorOrWarning( writeErrorOnException, cmdlet, exception, identifier, sourceAdapter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 40288, 40398);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
f_1575_38452_38474_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 38452, 38474);
return return_v;
}


string
f_1575_40630_40677()
{
var return_v = RemotingErrorIdStrings.ItemNotFoundInRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 40630, 40677);
return return_v;
}


string
f_1575_40583_40752(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 40583, 40752);
return return_v;
}


System.ArgumentException
f_1575_40777_40807(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 40777, 40807);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,38189,40866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,38189,40866);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void RemoveJobIdForReuse(Job job)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,40878,41119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,40944,40990);

Hashtable 
duplicateDetector = f_1575_40974_40989()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41004,41042);

f_1575_41004_41041(            duplicateDetector, f_1575_41026_41032(job), f_1575_41034_41040(job));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41058,41108);

f_1575_41058_41107(this, duplicateDetector, job);
DynAbs.Tracing.TraceSender.TraceExitMethod(1575,40878,41119);

System.Collections.Hashtable
f_1575_40974_40989()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 40974, 40989);
return return_v;
}


int
f_1575_41026_41032(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 41026, 41032);
return return_v;
}


int
f_1575_41034_41040(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 41034, 41040);
return return_v;
}


int
f_1575_41004_41041(System.Collections.Hashtable
this_param,int
key,int
value)
{
this_param.Add( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 41004, 41041);
return 0;
}


int
f_1575_41058_41107(System.Management.Automation.JobManager
this_param,System.Collections.Hashtable
duplicateDetector,System.Management.Automation.Job
job)
{
this_param.RemoveJobIdForReuseHelper( duplicateDetector, job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 41058, 41107);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,40878,41119);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,40878,41119);
}
		}

private void RemoveJobIdForReuseHelper(Hashtable duplicateDetector, Job job)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1575,41131,41672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41238,41250);
            lock (s_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41284,41324);

f_1575_41284_41323(                s_jobIdsForReuse, f_1575_41308_41322(job));
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41355,41661);
foreach(Job child in f_1575_41377_41390_I(f_1575_41377_41390(job)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,41355,41661);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41424,41537) || true) && (f_1575_41428_41467(duplicateDetector, f_1575_41458_41466(child)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1575,41424,41537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41509,41518);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,41424,41537);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41557,41599);

f_1575_41557_41598(
                duplicateDetector, f_1575_41579_41587(child), f_1575_41589_41597(child));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,41619,41646);

f_1575_41619_41645(this, child);
DynAbs.Tracing.TraceSender.TraceExitCondition(1575,41355,41661);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1575,1,307);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1575,1,307);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1575,41131,41672);

System.Guid
f_1575_41308_41322(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 41308, 41322);
return return_v;
}


bool
f_1575_41284_41323(System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.KeyValuePair<int, string>>
this_param,System.Guid
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 41284, 41323);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1575_41377_41390(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 41377, 41390);
return return_v;
}


int
f_1575_41458_41466(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 41458, 41466);
return return_v;
}


bool
f_1575_41428_41467(System.Collections.Hashtable
this_param,int
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 41428, 41467);
return return_v;
}


int
f_1575_41579_41587(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 41579, 41587);
return return_v;
}


int
f_1575_41589_41597(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1575, 41589, 41597);
return return_v;
}


int
f_1575_41557_41598(System.Collections.Hashtable
this_param,int
key,int
value)
{
this_param.Add( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 41557, 41598);
return 0;
}


int
f_1575_41619_41645(System.Management.Automation.JobManager
this_param,System.Management.Automation.Job
job)
{
this_param.RemoveJobIdForReuse( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 41619, 41645);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1575_41377_41390_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 41377, 41390);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1575,41131,41672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,41131,41672);
}
		}

        
        /// <summary>
        /// Filters available for GetJob, used internally to centralize Exception handling.
        /// </summary>
        private enum FilterType
        {
            /// <summary>
            /// Use no filter.
            /// </summary>
            None,

            /// <summary>
            /// Filter on command (string).
            /// </summary>
            Command,

            /// <summary>
            /// Filter on custom dictionary (dictionary(string, object)).
            /// </summary>
            Filter,

            /// <summary>
            /// Filter on name (string).
            /// </summary>
            Name,

            /// <summary>
            /// Filter on job state (JobState).
            /// </summary>
            State
        }

static JobManager()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1575,734,42534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,1371,1439);
s_jobIdsForReuse = f_1575_1390_1439();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1575,1483,1510);
s_syncObject = f_1575_1498_1510();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1575,734,42534);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1575,734,42534);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1575,734,42534);

System.Management.Automation.Tracing.PowerShellTraceSource
f_1575_830_875()
{
var return_v = PowerShellTraceSourceFactory.GetTraceSource();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 830, 875);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>
f_1575_1077_1119()
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.JobSourceAdapter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 1077, 1119);
return return_v;
}


object
f_1575_1170_1182()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 1170, 1182);
return return_v;
}


static System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.KeyValuePair<int, string>>
f_1575_1390_1439()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.KeyValuePair<int, string>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 1390, 1439);
return return_v;
}


static object
f_1575_1498_1510()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1575, 1498, 1510);
return return_v;
}

}
}
