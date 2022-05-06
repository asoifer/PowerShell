// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Tracing
{
    using System;

    /// <summary>
    ///     An object that can be used to revert the ETW activity ID of the current thread
    ///     to its original value.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Etw")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Reverter")]
    public interface IEtwActivityReverter :
        IDisposable
    {

void RevertCurrentActivityId();
    }
internal class EtwActivityReverter :
        IEtwActivityReverter
{
private readonly IEtwEventCorrelator _correlator;

private readonly Guid _oldActivityId;

private bool _isDisposed;

public EtwActivityReverter(IEtwEventCorrelator correlator, Guid oldActivityId)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1051,1351,1535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1243,1254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1327,1338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1454,1479);

_correlator = correlator;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1493,1524);

_oldActivityId = oldActivityId;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1051,1351,1535);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1051,1351,1535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1051,1351,1535);
}
		}

public void RevertCurrentActivityId()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1051,1547,1630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1609,1619);

f_1051_1609_1618(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1051,1547,1630);

int
f_1051_1609_1618(System.Management.Automation.Tracing.EtwActivityReverter
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1051, 1609, 1618);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1051,1547,1630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1051,1547,1630);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1051,1642,1894);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1688,1883) || true) && (!_isDisposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1051,1688,1883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1738,1785);

_correlator.CurrentActivityId = _oldActivityId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1803,1822);

_isDisposed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1051,1842,1868);

f_1051_1842_1867(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1051,1688,1883);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1051,1642,1894);

int
f_1051_1842_1867(System.Management.Automation.Tracing.EtwActivityReverter
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1051, 1842, 1867);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1051,1642,1894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1051,1642,1894);
}
		}

static EtwActivityReverter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1051,1123,1901);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1051,1123,1901);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1051,1123,1901);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1051,1123,1901);
}
}

