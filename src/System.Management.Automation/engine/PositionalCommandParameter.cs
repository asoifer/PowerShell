// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

namespace System.Management.Automation
{
internal class PositionalCommandParameter
{
internal PositionalCommandParameter(MergedCompiledCommandParameter parameter)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1313,464,599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1313,638,696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1313,708,833);
this.ParameterSetData = f_1313_786_832();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1313,566,588);

Parameter = parameter;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1313,464,599);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1313,464,599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1313,464,599);
}
		}

internal MergedCompiledCommandParameter Parameter {get; }

internal Collection<ParameterSetSpecificMetadata> ParameterSetData {get; }

static PositionalCommandParameter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1313,188,840);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1313,188,840);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1313,188,840);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1313,188,840);

System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
f_1313_786_832()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1313, 786, 832);
return return_v;
}

}
}

