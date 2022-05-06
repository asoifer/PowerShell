// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Threading;

namespace System.Management.Automation.Runspaces
{
public abstract class PipelineWriter
{
public abstract WaitHandle WaitHandle
{            get;
}

public abstract bool IsOpen
{            get;
}

public abstract int Count
{            get;
}

public abstract int MaxCapacity
{            get;
}

public abstract void Close();

public abstract void Flush();

public abstract int Write(object obj);

public abstract int Write(object obj, bool enumerateCollection);

public PipelineWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1016,519,4647);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1016,519,4647);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,519,4647);
}


static PipelineWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1016,519,4647);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1016,519,4647);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,519,4647);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1016,519,4647);
}
internal class DiscardingPipelineWriter : PipelineWriter
{
private ManualResetEvent _waitHandle ;

public override WaitHandle WaitHandle
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,4866,4893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,4872,4891);

return _waitHandle;
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,4866,4893);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,4804,4904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,4804,4904);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _isOpen ;

public override bool IsOpen
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,5006,5029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5012,5027);

return _isOpen;
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,5006,5029);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,4954,5040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,4954,5040);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private int _count ;

public override int Count
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,5135,5157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5141,5155);

return _count;
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,5135,5157);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,5085,5168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,5085,5168);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int MaxCapacity
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,5236,5264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5242,5262);

return int.MaxValue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,5236,5264);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,5180,5275);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,5180,5275);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override void Close()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,5287,5367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5340,5356);

_isOpen = false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,5287,5367);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,5287,5367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,5287,5367);
}
		}

public override void Flush()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,5379,5429);
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,5379,5429);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,5379,5429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,5379,5429);
}
		}

public override int Write(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,5441,5636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5503,5534);

int 
numberOfObjectsWritten = 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5548,5581);

_count += numberOfObjectsWritten;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5595,5625);

return numberOfObjectsWritten;
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,5441,5636);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,5441,5636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,5441,5636);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int Write(object obj, bool enumerateCollection)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1016,5648,6353);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5736,5832) || true) && (!enumerateCollection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1016,5736,5832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5794,5817);

return f_1016_5801_5816(this, obj);
DynAbs.Tracing.TraceSender.TraceExitCondition(1016,5736,5832);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5848,5879);

int 
numberOfObjectsWritten = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5893,5956);

IEnumerable 
enumerable = f_1016_5918_5955(obj)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5970,6249) || true) && (enumerable != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1016,5970,6249);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,6026,6143);
foreach(object o in f_1016_6047_6057_I(enumerable) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1016,6026,6143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,6099,6124);

numberOfObjectsWritten++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1016,6026,6143);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1016,1,118);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1016,1,118);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1016,5970,6249);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1016,5970,6249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,6209,6234);

numberOfObjectsWritten++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1016,5970,6249);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,6265,6298);

_count += numberOfObjectsWritten;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,6312,6342);

return numberOfObjectsWritten;
DynAbs.Tracing.TraceSender.TraceExitMethod(1016,5648,6353);

int
f_1016_5801_5816(System.Management.Automation.Runspaces.DiscardingPipelineWriter
this_param,object
obj)
{
var return_v = this_param.Write( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1016, 5801, 5816);
return return_v;
}


System.Collections.IEnumerable
f_1016_5918_5955(object
obj)
{
var return_v = LanguagePrimitives.GetEnumerable( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1016, 5918, 5955);
return return_v;
}


System.Collections.IEnumerable
f_1016_6047_6057_I(System.Collections.IEnumerable
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1016, 6047, 6057);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1016,5648,6353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,5648,6353);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DiscardingPipelineWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1016,4655,6360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,4753,4793);
this._waitHandle = f_1016_4767_4793(true);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,4929,4943);
this._isOpen = true;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1016,5064,5074);
this._count = 0;DynAbs.Tracing.TraceSender.TraceExitConstructor(1016,4655,6360);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,4655,6360);
}


static DiscardingPipelineWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1016,4655,6360);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1016,4655,6360);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1016,4655,6360);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1016,4655,6360);

System.Threading.ManualResetEvent
f_1016_4767_4793(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1016, 4767, 4793);
return return_v;
}

}
}

