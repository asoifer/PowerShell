// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
internal abstract class ProviderNames
{
internal abstract string Environment {get; }

internal abstract string Certificate {get; }

internal abstract string Variable {get; }

internal abstract string Alias {get; }

internal abstract string Function {get; }

internal abstract string FileSystem {get; }

internal abstract string Registry {get; }

public ProviderNames()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1319,415,1537);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1319,415,1537);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,415,1537);
}


static ProviderNames()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1319,415,1537);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1319,415,1537);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,415,1537);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1319,415,1537);
}
internal class SingleShellProviderNames : ProviderNames
{
internal override string Environment
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1319,1869,1968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1319,1905,1953);

return "Microsoft.PowerShell.Core\\Environment";
DynAbs.Tracing.TraceSender.TraceExitMethod(1319,1869,1968);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1319,1808,1979);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,1808,1979);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Certificate
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1319,2146,2249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1319,2182,2234);

return "Microsoft.PowerShell.Security\\Certificate";
DynAbs.Tracing.TraceSender.TraceExitMethod(1319,2146,2249);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1319,2085,2260);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,2085,2260);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Variable
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1319,2429,2525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1319,2465,2510);

return "Microsoft.PowerShell.Core\\Variable";
DynAbs.Tracing.TraceSender.TraceExitMethod(1319,2429,2525);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1319,2371,2536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,2371,2536);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Alias
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1319,2699,2792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1319,2735,2777);

return "Microsoft.PowerShell.Core\\Alias";
DynAbs.Tracing.TraceSender.TraceExitMethod(1319,2699,2792);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1319,2644,2803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,2644,2803);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Function
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1319,2972,3068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1319,3008,3053);

return "Microsoft.PowerShell.Core\\Function";
DynAbs.Tracing.TraceSender.TraceExitMethod(1319,2972,3068);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1319,2914,3079);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,2914,3079);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string FileSystem
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1319,3252,3350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1319,3288,3335);

return "Microsoft.PowerShell.Core\\FileSystem";
DynAbs.Tracing.TraceSender.TraceExitMethod(1319,3252,3350);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1319,3192,3361);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,3192,3361);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Registry
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1319,3530,3626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1319,3566,3611);

return "Microsoft.PowerShell.Core\\Registry";
DynAbs.Tracing.TraceSender.TraceExitMethod(1319,3530,3626);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1319,3472,3637);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,3472,3637);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SingleShellProviderNames()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1319,1634,3644);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1319,1634,3644);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,1634,3644);
}


static SingleShellProviderNames()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1319,1634,3644);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1319,1634,3644);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1319,1634,3644);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1319,1634,3644);
}
}

