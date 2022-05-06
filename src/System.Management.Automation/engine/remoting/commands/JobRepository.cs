// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Remoting;

namespace System.Management.Automation
{
public abstract class Repository<T> where T : class
{
public void Add(T item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,594,1154);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,642,752) || true) && (item == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1596,642,752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,692,737);

throw f_1596_698_736(_identifier);
DynAbs.Tracing.TraceSender.TraceExitCondition(1596,642,752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,774,785);

            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,819,850);

Guid 
instanceId = f_1596_837_849(this, item)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,870,1128) || true) && (!f_1596_875_910(_repository, instanceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1596,870,1128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,952,986);

f_1596_952_985(                    _repository, instanceId, item);
DynAbs.Tracing.TraceSender.TraceExitCondition(1596,870,1128);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1596,870,1128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1068,1109);

throw f_1596_1074_1108(_identifier);
DynAbs.Tracing.TraceSender.TraceExitCondition(1596,870,1128);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,594,1154);

System.ArgumentNullException
f_1596_698_736(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 698, 736);
return return_v;
}


System.Guid
f_1596_837_849(System.Management.Automation.Repository<T>
this_param,T
item)
{
var return_v = this_param.GetKey( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 837, 849);
return return_v;
}


bool
f_1596_875_910(System.Collections.Generic.Dictionary<System.Guid, T>
this_param,System.Guid
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 875, 910);
return return_v;
}


int
f_1596_952_985(System.Collections.Generic.Dictionary<System.Guid, T>
this_param,System.Guid
key,T
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 952, 985);
return 0;
}


System.ArgumentException
f_1596_1074_1108(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 1074, 1108);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,594,1154);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,594,1154);
}
		}

public void Remove(T item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,1331,2001);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1382,1492) || true) && (item == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1596,1382,1492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1432,1477);

throw f_1596_1438_1476(_identifier);
DynAbs.Tracing.TraceSender.TraceExitCondition(1596,1382,1492);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1514,1525);

            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1559,1590);

Guid 
instanceId = f_1596_1577_1589(this, item)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1610,1975) || true) && (!f_1596_1615_1645(_repository, instanceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1596,1610,1975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1687,1895);

string 
message =
f_1596_1729_1894(f_1596_1776_1823(), "Job repository", instanceId.ToString())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,1919,1956);

throw f_1596_1925_1955(message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1596,1610,1975);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,1331,2001);

System.ArgumentNullException
f_1596_1438_1476(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 1438, 1476);
return return_v;
}


System.Guid
f_1596_1577_1589(System.Management.Automation.Repository<T>
this_param,T
item)
{
var return_v = this_param.GetKey( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 1577, 1589);
return return_v;
}


bool
f_1596_1615_1645(System.Collections.Generic.Dictionary<System.Guid, T>
this_param,System.Guid
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 1615, 1645);
return return_v;
}


string
f_1596_1776_1823()
{
var return_v = RemotingErrorIdStrings.ItemNotFoundInRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1596, 1776, 1823);
return return_v;
}


string
f_1596_1729_1894(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 1729, 1894);
return return_v;
}


System.ArgumentException
f_1596_1925_1955(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 1925, 1955);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,1331,2001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,1331,2001);
}
		}

public List<T> GetItems()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,2093,2167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,2143,2156);

return f_1596_2150_2155();
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,2093,2167);

System.Collections.Generic.List<T>
f_1596_2150_2155()
{
var return_v = Items;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1596, 2150, 2155);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,2093,2167);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,2093,2167);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract Guid GetKey(T item);

protected Repository(string identifier)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1596,2608,2708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3792,3831);
this._repository = f_1596_3806_3831();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3857,3883);
this._syncObject = f_1596_3871_3883();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3944,3955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,2672,2697);

_identifier = identifier;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1596,2608,2708);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,2608,2708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,2608,2708);
}
		}

internal List<T> Items
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,2875,3043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,2917,2928);
                lock (_syncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,2970,3009);

return f_1596_2977_3008(f_1596_2989_3007(_repository));
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,2875,3043);

System.Collections.Generic.Dictionary<System.Guid, T>.ValueCollection
f_1596_2989_3007(System.Collections.Generic.Dictionary<System.Guid, T>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1596, 2989, 3007);
return return_v;
}


System.Collections.Generic.List<T>
f_1596_2977_3008(System.Collections.Generic.Dictionary<System.Guid, T>.ValueCollection
collection)
{
var return_v = new System.Collections.Generic.List<T>( (System.Collections.Generic.IEnumerable<T>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 2977, 3008);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,2828,3054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,2828,3054);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public T GetItem(Guid instanceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,3231,3473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3295,3306);
            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3340,3349);

T 
result
=default(T);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3367,3415);

f_1596_3367_3414(                _repository, instanceId, out result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3433,3447);

return result;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,3231,3473);

bool
f_1596_3367_3414(System.Collections.Generic.Dictionary<System.Guid, T>
this_param,System.Guid
key,out T
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 3367, 3414);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,3231,3473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,3231,3473);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Dictionary<Guid, T> Dictionary
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,3641,3668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,3647,3666);

return _repository;
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,3641,3668);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,3577,3679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,3577,3679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private Dictionary<Guid, T> _repository ;

private object _syncObject ;

private string _identifier;

static Repository()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1596,346,4001);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1596,346,4001);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,346,4001);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1596,346,4001);

System.Collections.Generic.Dictionary<System.Guid, T>
f_1596_3806_3831()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, T>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 3806, 3831);
return return_v;
}


object
f_1596_3871_3883()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 3871, 3883);
return return_v;
}

}
public class JobRepository : Repository<Job>
{
public List<Job> Jobs
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,4335,4399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,4371,4384);

return f_1596_4378_4383();
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,4335,4399);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1596_4378_4383()
{
var return_v = Items;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1596, 4378, 4383);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,4289,4410);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,4289,4410);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Job GetJob(Guid instanceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,4643,4740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,4702,4729);

return f_1596_4709_4728(this, instanceId);
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,4643,4740);

System.Management.Automation.Job
f_1596_4709_4728(System.Management.Automation.JobRepository
this_param,System.Guid
instanceId)
{
var return_v = this_param.GetItem( instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1596, 4709, 4728);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,4643,4740);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,4643,4740);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal JobRepository() :base(f_1596_4902_4907_C("job") )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1596,4870,4930);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1596,4870,4930);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,4870,4930);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,4870,4930);
}
		}

protected override Guid GetKey(Job item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1596,5169,5367);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,5234,5322) || true) && (item != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1596,5234,5322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,5284,5307);

return f_1596_5291_5306(item);
DynAbs.Tracing.TraceSender.TraceExitCondition(1596,5234,5322);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1596,5338,5356);

return Guid.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1596,5169,5367);

System.Guid
f_1596_5291_5306(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1596, 5291, 5306);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1596,5169,5367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,5169,5367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static JobRepository()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1596,4125,5413);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1596,4125,5413);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1596,4125,5413);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1596,4125,5413);

static string
f_1596_4902_4907_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1596, 4870, 4930);
return return_v;
}

}
}
