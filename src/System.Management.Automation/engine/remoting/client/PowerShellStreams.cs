// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
public sealed class PowerShellStreams<TInput, TOutput> : IDisposable
{
private PSDataCollection<TInput> _inputStream;

private PSDataCollection<TOutput> _outputStream;

private PSDataCollection<ErrorRecord> _errorStream;

private PSDataCollection<WarningRecord> _warningStream;

private PSDataCollection<ProgressRecord> _progressStream;

private PSDataCollection<VerboseRecord> _verboseStream;

private PSDataCollection<DebugRecord> _debugStream;

private PSDataCollection<InformationRecord> _informationStream;

private bool _disposed;

private readonly object _syncLock ;

public PowerShellStreams()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1577,2025,2393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,475,487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,630,643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,787,799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,949,963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1116,1131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1281,1295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1439,1451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1613,1631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1759,1768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1907,1931);
this._syncLock = f_1577_1919_1931();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2076,2096);

_inputStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2110,2131);

_outputStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2145,2165);

_errorStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2179,2201);

_warningStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2215,2238);

_progressStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2252,2274);

_verboseStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2288,2308);

_debugStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2322,2348);

_informationStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2364,2382);

_disposed = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1577,2025,2393);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,2025,2393);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,2025,2393);
}
		}

public PowerShellStreams(PSDataCollection<TInput> pipelineInput)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1577,2486,3268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,475,487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,630,643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,787,799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,949,963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1116,1131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1281,1295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1439,1451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1613,1631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1759,1768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,1907,1931);
this._syncLock = f_1577_1919_1931();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2640,2703);

_inputStream = pipelineInput ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSDataCollection<TInput>>(1577, 2655, 2702)??f_1577_2672_2702());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2719,2743);

f_1577_2719_2742(
            _inputStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2759,2807);

_outputStream = f_1577_2775_2806();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2821,2872);

_errorStream = f_1577_2836_2871();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2886,2941);

_warningStream = f_1577_2903_2940();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,2955,3012);

_progressStream = f_1577_2973_3011();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3026,3081);

_verboseStream = f_1577_3043_3080();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3095,3146);

_debugStream = f_1577_3110_3145();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3160,3223);

_informationStream = f_1577_3181_3222();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3239,3257);

_disposed = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1577,2486,3268);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,2486,3268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,2486,3268);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,3364,3480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3410,3429);

f_1577_3410_3428(            this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3443,3469);

f_1577_3443_3468(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,3364,3480);

int
f_1577_3410_3428(System.Management.Automation.PowerShellStreams<TInput, TOutput>
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 3410, 3428);
return 0;
}


int
f_1577_3443_3468(System.Management.Automation.PowerShellStreams<TInput, TOutput>
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 3443, 3468);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,3364,3480);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,3364,3480);
}
		}

private void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,3643,4800);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3704,3743) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1577,3704,3743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3736,3743);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1577,3704,3743);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3765,3774);

            lock (_syncLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3808,4774) || true) && (!_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1577,3808,4774);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3864,4714) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1577,3864,4714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3927,3950);

f_1577_3927_3949(                        _inputStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,3976,4000);

f_1577_3976_3999(                        _outputStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4026,4049);

f_1577_4026_4048(                        _errorStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4075,4100);

f_1577_4075_4099(                        _warningStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4126,4152);

f_1577_4126_4151(                        _progressStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4178,4203);

f_1577_4178_4202(                        _verboseStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4229,4252);

f_1577_4229_4251(                        _debugStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4278,4307);

f_1577_4278_4306(                        _informationStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4335,4355);

_inputStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4381,4402);

_outputStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4428,4448);

_errorStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4474,4496);

_warningStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4522,4545);

_progressStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4571,4593);

_verboseStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4619,4639);

_debugStream = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4665,4691);

_informationStream = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1577,3864,4714);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,4738,4755);

_disposed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1577,3808,4774);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,3643,4800);

int
f_1577_3927_3949(System.Management.Automation.PSDataCollection<TInput>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 3927, 3949);
return 0;
}


int
f_1577_3976_3999(System.Management.Automation.PSDataCollection<TOutput>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 3976, 3999);
return 0;
}


int
f_1577_4026_4048(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 4026, 4048);
return 0;
}


int
f_1577_4075_4099(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 4075, 4099);
return 0;
}


int
f_1577_4126_4151(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 4126, 4151);
return 0;
}


int
f_1577_4178_4202(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 4178, 4202);
return 0;
}


int
f_1577_4229_4251(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 4229, 4251);
return 0;
}


int
f_1577_4278_4306(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 4278, 4306);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,3643,4800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,3643,4800);
}
		}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<TInput> InputStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,5084,5112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,5090,5110);

return _inputStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,5084,5112);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,4891,5168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,4891,5168);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,5128,5157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,5134,5155);

_inputStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,5128,5157);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,4891,5168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,4891,5168);
}
		}}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<TOutput> OutputStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,5455,5484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,5461,5482);

return _outputStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,5455,5484);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,5260,5541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,5260,5541);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,5500,5530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,5506,5528);

_outputStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,5500,5530);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,5260,5541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,5260,5541);
}
		}}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<ErrorRecord> ErrorStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,5830,5858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,5836,5856);

return _errorStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,5830,5858);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,5632,5914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,5632,5914);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,5874,5903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,5880,5901);

_errorStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,5874,5903);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,5632,5914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,5632,5914);
}
		}}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<WarningRecord> WarningStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,6209,6239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,6215,6237);

return _warningStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,6209,6239);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,6007,6297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,6007,6297);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,6255,6286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,6261,6284);

_warningStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,6255,6286);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,6007,6297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,6007,6297);
}
		}}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<ProgressRecord> ProgressStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,6595,6626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,6601,6624);

return _progressStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,6595,6626);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,6391,6685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,6391,6685);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,6642,6674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,6648,6672);

_progressStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,6642,6674);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,6391,6685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,6391,6685);
}
		}}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<VerboseRecord> VerboseStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,6980,7010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,6986,7008);

return _verboseStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,6980,7010);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,6778,7068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,6778,7068);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,7026,7057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,7032,7055);

_verboseStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,7026,7057);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,6778,7068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,6778,7068);
}
		}}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<DebugRecord> DebugStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,7356,7384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,7362,7382);

return _debugStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,7356,7384);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,7158,7440);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,7158,7440);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,7400,7429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,7406,7427);

_debugStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,7400,7429);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,7158,7440);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,7158,7440);
}
		}}

[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSDataCollection<InformationRecord> InformationStream
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,7747,7781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,7753,7779);

return _informationStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,7747,7781);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,7537,7843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,7537,7843);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,7797,7832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,7803,7830);

_informationStream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,7797,7832);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,7537,7843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,7537,7843);
}
		}}

public void CloseAll()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1577,8059,8697);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8106,8686) || true) && (_disposed == false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1577,8106,8686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8168,8177);
                lock (_syncLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8219,8652) || true) && (_disposed == false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1577,8219,8652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8291,8316);

f_1577_8291_8315(                        _outputStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8342,8366);

f_1577_8342_8365(                        _errorStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8392,8418);

f_1577_8392_8417(                        _warningStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8444,8471);

f_1577_8444_8470(                        _progressStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8497,8523);

f_1577_8497_8522(                        _verboseStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8549,8573);

f_1577_8549_8572(                        _debugStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1577,8599,8629);

f_1577_8599_8628(                        _informationStream);
DynAbs.Tracing.TraceSender.TraceExitCondition(1577,8219,8652);
}
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1577,8106,8686);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1577,8059,8697);

int
f_1577_8291_8315(System.Management.Automation.PSDataCollection<TOutput>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 8291, 8315);
return 0;
}


int
f_1577_8342_8365(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 8342, 8365);
return 0;
}


int
f_1577_8392_8417(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 8392, 8417);
return 0;
}


int
f_1577_8444_8470(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 8444, 8470);
return 0;
}


int
f_1577_8497_8522(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 8497, 8522);
return 0;
}


int
f_1577_8549_8572(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 8549, 8572);
return 0;
}


int
f_1577_8599_8628(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 8599, 8628);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1577,8059,8697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,8059,8697);
}
		}

static PowerShellStreams()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1577,262,8704);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1577,262,8704);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1577,262,8704);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1577,262,8704);

object
f_1577_1919_1931()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 1919, 1931);
return return_v;
}


System.Management.Automation.PSDataCollection<TInput>
f_1577_2672_2702()
{
var return_v = new System.Management.Automation.PSDataCollection<TInput>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 2672, 2702);
return return_v;
}


int
f_1577_2719_2742(System.Management.Automation.PSDataCollection<TInput>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 2719, 2742);
return 0;
}


System.Management.Automation.PSDataCollection<TOutput>
f_1577_2775_2806()
{
var return_v = new System.Management.Automation.PSDataCollection<TOutput>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 2775, 2806);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1577_2836_2871()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 2836, 2871);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
f_1577_2903_2940()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 2903, 2940);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
f_1577_2973_3011()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 2973, 3011);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
f_1577_3043_3080()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 3043, 3080);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
f_1577_3110_3145()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 3110, 3145);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
f_1577_3181_3222()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1577, 3181, 3222);
return return_v;
}

}
}
