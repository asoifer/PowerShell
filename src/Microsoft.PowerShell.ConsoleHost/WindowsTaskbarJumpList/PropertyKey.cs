// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.PowerShell
{

[StructLayout(LayoutKind.Sequential, Pack = 4)]
    internal struct PropertyKey : IEquatable<PropertyKey>
    {

public Guid FormatId {get; }

public Int32 PropertyId {get; }

internal PropertyKey(Guid formatId, Int32 propertyId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(132,1002,1159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,1080,1105);

this.FormatId = formatId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,1119,1148);

this.PropertyId = propertyId;
DynAbs.Tracing.TraceSender.TraceExitConstructor(132,1002,1159);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132,1002,1159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,1002,1159);
}
		}

public bool Equals(PropertyKey other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(132,1520,1627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,1582,1616);

return other.Equals(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(132,1520,1627);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132,1520,1627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,1520,1627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(132,1877,1989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,1935,1978);

return FormatId.GetHashCode()^ PropertyId;
DynAbs.Tracing.TraceSender.TraceExitMethod(132,1877,1989);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132,1877,1989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,1877,1989);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(132,2275,2612);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,2339,2386) || true) && (obj == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(132,2339,2386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,2373,2386);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(132,2339,2386);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,2402,2459) || true) && (!(obj is PropertyKey))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(132,2402,2459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,2446,2459);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(132,2402,2459);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,2475,2512);

PropertyKey 
other = (PropertyKey)obj
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,2526,2601);

return other.FormatId.Equals(FormatId)&&(DynAbs.Tracing.TraceSender.Expression_True(132, 2533, 2600)&&(other.PropertyId == PropertyId));
DynAbs.Tracing.TraceSender.TraceExitMethod(132,2275,2612);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132,2275,2612);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,2275,2612);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool operator ==(PropertyKey propKey1, PropertyKey propKey2)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(132,2957,3100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,3056,3089);

return propKey1.Equals(propKey2);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(132,2957,3100);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132,2957,3100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,2957,3100);
}
		}

public static bool operator !=(PropertyKey propKey1, PropertyKey propKey2)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(132,3455,3599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,3554,3588);

return !propKey1.Equals(propKey2);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(132,3455,3599);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132,3455,3599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,3455,3599);
}
		}

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(132,3811,4049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(132,3869,4038);

return f_132_3876_4037(f_132_3890_3939(), "PropertyKeyFormatString", FormatId.ToString("B"), PropertyId);
DynAbs.Tracing.TraceSender.TraceExitMethod(132,3811,4049);

System.Globalization.CultureInfo
f_132_3890_3939()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(132, 3890, 3939);
return return_v;
}


string
f_132_3876_4037(System.Globalization.CultureInfo
provider,string
format,string
arg0,int
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(132, 3876, 4037);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(132,3811,4049);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,3811,4049);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static PropertyKey(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(132,286,4078);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(132,286,4078);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(132,286,4078);
}

            }
}
