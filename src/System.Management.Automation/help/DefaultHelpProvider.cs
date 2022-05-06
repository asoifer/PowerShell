// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation
{
internal class DefaultHelpProvider : HelpFileHelpProvider
{
internal DefaultHelpProvider(HelpSystem helpSystem)
:base(f_1147_680_690_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1147,608,713);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1147,608,713);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1147,608,713);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1147,608,713);
}
		}

internal override string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1147,892,974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1147,928,959);

return "Default Help Provider";
DynAbs.Tracing.TraceSender.TraceExitMethod(1147,892,974);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1147,838,985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1147,838,985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1147,1141,1224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1147,1177,1209);

return HelpCategory.DefaultHelp;
DynAbs.Tracing.TraceSender.TraceExitMethod(1147,1141,1224);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1147,1073,1235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1147,1073,1235);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1147,1460,1741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1147,1564,1617);

HelpRequest 
defaultHelpRequest = f_1147_1597_1616(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1147,1631,1669);

defaultHelpRequest.Target = "default";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1147,1683,1730);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ExactMatchHelp(defaultHelpRequest),1147,1690,1729);
DynAbs.Tracing.TraceSender.TraceExitMethod(1147,1460,1741);

System.Management.Automation.HelpRequest
f_1147_1597_1616(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1147, 1597, 1616);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1147,1460,1741);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1147,1460,1741);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DefaultHelpProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1147,444,1770);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1147,444,1770);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1147,444,1770);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1147,444,1770);

static System.Management.Automation.HelpSystem
f_1147_680_690_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1147, 608, 713);
return return_v;
}

}
}
