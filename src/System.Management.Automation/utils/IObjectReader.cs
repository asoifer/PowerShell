// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces
{
public abstract class PipelineReader<T>
{        /// <summary>
        /// Event fired when data is added to the buffer.
        /// </summary>
        public abstract event EventHandler 
DataReady
;

public abstract WaitHandle WaitHandle
{            get;
}

public abstract bool EndOfPipeline
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

public abstract Collection<T> Read(int count);

public abstract T Read();

public abstract Collection<T> ReadToEnd();

public abstract Collection<T> NonBlockingRead();

public abstract Collection<T> NonBlockingRead(int maxRequested);

public abstract T Peek();

internal IEnumerator<T> GetReadEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1015,6172,6612);

var listYield= new List<T>();
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1015,6240,6601) || true) && (f_1015_6247_6266_M(!this.EndOfPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1015,6240,6601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1015,6300,6318);

T 
t = f_1015_6306_6317(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1015,6336,6586) || true) && (f_1015_6340_6416(t, f_1015_6357_6415()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1015,6336,6586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1015,6458,6470);

return listYield.GetEnumerator();
DynAbs.Tracing.TraceSender.TraceExitCondition(1015,6336,6586);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1015,6336,6586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1015,6552,6567);

listYield.Add(t);
DynAbs.Tracing.TraceSender.TraceExitCondition(1015,6336,6586);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1015,6240,6601);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1015,6240,6601);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1015,6240,6601);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1015,6172,6612);

return listYield.GetEnumerator();

bool
f_1015_6247_6266_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1015, 6247, 6266);
return return_v;
}


T
f_1015_6306_6317(System.Management.Automation.Runspaces.PipelineReader<T>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1015, 6306, 6317);
return return_v;
}


System.Management.Automation.PSObject
f_1015_6357_6415()
{
var return_v = System.Management.Automation.Internal.AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1015, 6357, 6415);
return return_v;
}


bool
f_1015_6340_6416(T
objA,System.Management.Automation.PSObject
objB)
{
var return_v = object.Equals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1015, 6340, 6416);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1015,6172,6612);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1015,6172,6612);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public PipelineReader()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1015,680,6641);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1015,680,6641);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1015,680,6641);
}


static PipelineReader()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1015,680,6641);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1015,680,6641);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1015,680,6641);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1015,680,6641);
}
}
