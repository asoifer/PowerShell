// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;
using System.Globalization;

namespace System.Management.Automation.Help
{
internal class UpdatableHelpUri
{
internal UpdatableHelpUri(string moduleName, Guid moduleGuid, CultureInfo culture, string resolvedUri)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1181,660,1106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,1191,1226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,1428,1465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,1551,1587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,787,835);

f_1181_787_834(!f_1181_801_833(moduleName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,849,882);

f_1181_849_881(moduleGuid != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,896,945);

f_1181_896_944(!f_1181_910_943(resolvedUri));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,961,985);

ModuleName = moduleName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,999,1023);

ModuleGuid = moduleGuid;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,1037,1055);

Culture = culture;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1181,1069,1095);

ResolvedUri = resolvedUri;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1181,660,1106);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1181,660,1106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1181,660,1106);
}
		}

internal string ModuleName {get; }

internal Guid ModuleGuid {get; }

internal CultureInfo Culture {get; }

internal string ResolvedUri {get; }

static UpdatableHelpUri()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1181,299,1594);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1181,299,1594);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1181,299,1594);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1181,299,1594);

bool
f_1181_801_833(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1181, 801, 833);
return return_v;
}


int
f_1181_787_834(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1181, 787, 834);
return 0;
}


int
f_1181_849_881(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1181, 849, 881);
return 0;
}


bool
f_1181_910_943(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1181, 910, 943);
return return_v;
}


int
f_1181_896_944(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1181, 896, 944);
return 0;
}

}
}
