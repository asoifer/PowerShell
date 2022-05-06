/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation.
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A
 * copy of the license can be found in the License.html file at the root of this distribution. If
 * you cannot locate the Apache License, Version 2.0, please send an email to
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

namespace System.Management.Automation.Interpreter
{
internal sealed class NewArrayInitInstruction<TElement> : Instruction
{
private readonly int _elementCount;

internal NewArrayInitInstruction(int elementCount)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1487,907,1022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,881,894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,982,1011);

_elementCount = elementCount;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1487,907,1022);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,907,1022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,907,1022);
}
		}

public override int ConsumedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,1070,1099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1076,1097);

return _elementCount;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,1070,1099);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,1034,1101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1034,1101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int ProducedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,1149,1166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1155,1164);

return 1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,1149,1166);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,1113,1168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1113,1168);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int Run(InterpretedFrame frame)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,1180,1507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1252,1299);

TElement[] 
array = new TElement[_elementCount]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1322,1343);
            for (int 
i = _elementCount - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1313,1438) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1353,1356)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1487,1313,1438))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1487,1313,1438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1390,1423);

array[i] = (TElement)f_1487_1411_1422(frame);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1487,1,126);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1487,1,126);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1454,1472);

f_1487_1454_1471(
            frame, array);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1486,1496);

return +1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,1180,1507);

object
f_1487_1411_1422(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 1411, 1422);
return return_v;
}


int
f_1487_1454_1471(System.Management.Automation.Interpreter.InterpretedFrame
this_param,TElement[]
value)
{
this_param.Push( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 1454, 1471);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,1180,1507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1180,1507);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static NewArrayInitInstruction()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1487,774,1514);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1487,774,1514);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,774,1514);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1487,774,1514);
}
internal sealed class NewArrayInstruction<TElement> : Instruction
{
internal NewArrayInstruction() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1487,1604,1638);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1487,1604,1638);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,1604,1638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1604,1638);
}
		}

public override int ConsumedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,1686,1703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1692,1701);

return 1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,1686,1703);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,1650,1705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1650,1705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int ProducedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,1753,1770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1759,1768);

return 1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,1753,1770);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,1717,1772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1717,1772);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int Run(InterpretedFrame frame)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,1784,1968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1856,1886);

int 
length = (int)f_1487_1874_1885(frame)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1900,1933);

f_1487_1900_1932(            frame, new TElement[length]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,1947,1957);

return +1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,1784,1968);

object
f_1487_1874_1885(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 1874, 1885);
return return_v;
}


int
f_1487_1900_1932(System.Management.Automation.Interpreter.InterpretedFrame
this_param,TElement[]
value)
{
this_param.Push( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 1900, 1932);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,1784,1968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1784,1968);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static NewArrayInstruction()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1487,1522,1975);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1487,1522,1975);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1522,1975);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1487,1522,1975);
}
internal sealed class NewArrayBoundsInstruction : Instruction
{
private readonly Type _elementType;

private readonly int _rank;

internal NewArrayBoundsInstruction(Type elementType, int rank)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1487,2145,2297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2083,2095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2127,2132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2232,2259);

_elementType = elementType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2273,2286);

_rank = rank;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1487,2145,2297);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,2145,2297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,2145,2297);
}
		}

public override int ConsumedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,2345,2366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2351,2364);

return _rank;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,2345,2366);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,2309,2368);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,2309,2368);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int ProducedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,2416,2433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2422,2431);

return 1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,2416,2433);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,2380,2435);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,2380,2435);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int Run(InterpretedFrame frame)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,2447,2815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2519,2548);

var 
lengths = new int[_rank]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2571,2584);
            for (int 
i = _rank - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2562,2676) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2594,2597)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1487,2562,2676))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1487,2562,2676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2631,2661);

lengths[i] = (int)f_1487_2649_2660(frame);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1487,1,115);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1487,1,115);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2692,2748);

var 
array = f_1487_2704_2747(_elementType, lengths)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2762,2780);

f_1487_2762_2779(            frame, array);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,2794,2804);

return +1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,2447,2815);

object
f_1487_2649_2660(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 2649, 2660);
return return_v;
}


System.Array
f_1487_2704_2747(System.Type
elementType,params int[]
lengths)
{
var return_v = Array.CreateInstance( elementType, lengths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 2704, 2747);
return return_v;
}


int
f_1487_2762_2779(System.Management.Automation.Interpreter.InterpretedFrame
this_param,System.Array
value)
{
this_param.Push( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 2762, 2779);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,2447,2815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,2447,2815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static NewArrayBoundsInstruction()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1487,1983,2822);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1487,1983,2822);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,1983,2822);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1487,1983,2822);
}
internal sealed class GetArrayItemInstruction<TElement> : Instruction
{
internal GetArrayItemInstruction() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1487,2916,2954);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1487,2916,2954);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,2916,2954);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,2916,2954);
}
		}

public override int ConsumedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,3002,3019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3008,3017);

return 2;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,3002,3019);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,2966,3021);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,2966,3021);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int ProducedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,3069,3086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3075,3084);

return 1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,3069,3086);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,3033,3088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3033,3088);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int Run(InterpretedFrame frame)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,3100,3332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3172,3201);

int 
index = (int)f_1487_3189_3200(frame)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3215,3258);

TElement[] 
array = (TElement[])f_1487_3246_3257(frame)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3272,3297);

f_1487_3272_3296(            frame, array[index]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3311,3321);

return +1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,3100,3332);

object
f_1487_3189_3200(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 3189, 3200);
return return_v;
}


object
f_1487_3246_3257(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 3246, 3257);
return return_v;
}


int
f_1487_3272_3296(System.Management.Automation.Interpreter.InterpretedFrame
this_param,TElement
value)
{
this_param.Push( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 3272, 3296);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,3100,3332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3100,3332);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override string InstructionName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,3407,3437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3413,3435);

return "GetArrayItem";
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,3407,3437);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,3344,3448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3344,3448);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static GetArrayItemInstruction()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1487,2830,3455);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1487,2830,3455);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,2830,3455);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1487,2830,3455);
}
internal sealed class SetArrayItemInstruction<TElement> : Instruction
{
internal SetArrayItemInstruction() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1487,3549,3587);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1487,3549,3587);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,3549,3587);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3549,3587);
}
		}

public override int ConsumedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,3635,3652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3641,3650);

return 3;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,3635,3652);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,3599,3654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3599,3654);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int ProducedStack {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,3702,3719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3708,3717);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,3702,3719);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,3666,3721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3666,3721);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int Run(InterpretedFrame frame)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,3733,4014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3805,3844);

TElement 
value = (TElement)f_1487_3832_3843(frame)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3858,3887);

int 
index = (int)f_1487_3875_3886(frame)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3901,3944);

TElement[] 
array = (TElement[])f_1487_3932_3943(frame)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3958,3979);

array[index] = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,3993,4003);

return +1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,3733,4014);

object
f_1487_3832_3843(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 3832, 3843);
return return_v;
}


object
f_1487_3875_3886(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 3875, 3886);
return return_v;
}


object
f_1487_3932_3943(System.Management.Automation.Interpreter.InterpretedFrame
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1487, 3932, 3943);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,3733,4014);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3733,4014);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override string InstructionName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1487,4089,4119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1487,4095,4117);

return "SetArrayItem";
DynAbs.Tracing.TraceSender.TraceExitMethod(1487,4089,4119);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1487,4026,4130);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,4026,4130);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static SetArrayItemInstruction()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1487,3463,4137);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1487,3463,4137);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1487,3463,4137);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1487,3463,4137);
}
}
