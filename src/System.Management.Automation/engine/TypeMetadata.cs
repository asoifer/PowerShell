// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Language;
using System.Reflection;

using Microsoft.PowerShell;

using Dbg = System.Diagnostics.Debug;

namespace System.Management.Automation
{
public sealed class ParameterSetMetadata
{
private bool _isMandatory;

private int _position;

private bool _valueFromPipeline;

private bool _valueFromPipelineByPropertyName;

private bool _valueFromRemainingArguments;

private string _helpMessage;

private string _helpMessageBaseName;

private string _helpMessageResourceId;

internal ParameterSetMetadata(ParameterSetSpecificMetadata psMD)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,1111,1314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,631,643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,666,675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,699,717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,741,773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,797,825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,851,863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,889,909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,935,957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1200,1272);

f_1366_1200_1271(psMD != null, "ParameterSetSpecificMetadata cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1286,1303);

f_1366_1286_1302(this, psMD);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,1111,1314);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,1111,1314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,1111,1314);
}
		}

internal ParameterSetMetadata(ParameterSetMetadata other)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,1548,2261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,631,643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,666,675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,699,717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,741,773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,797,825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,851,863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,889,909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,935,957);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1630,1750) || true) && (other == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,1630,1750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1681,1735);

throw f_1366_1687_1734("other");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,1630,1750);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1766,1800);

_helpMessage = other._helpMessage;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1814,1864);

_helpMessageBaseName = other._helpMessageBaseName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1878,1932);

_helpMessageResourceId = other._helpMessageResourceId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1946,1980);

_isMandatory = other._isMandatory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,1994,2022);

_position = other._position;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,2036,2082);

_valueFromPipeline = other._valueFromPipeline;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,2096,2170);

_valueFromPipelineByPropertyName = other._valueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,2184,2250);

_valueFromRemainingArguments = other._valueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,1548,2261);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,1548,2261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,1548,2261);
}
		}

public bool IsMandatory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,2552,2623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,2588,2608);

return _isMandatory;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,2552,2623);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,2504,2722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,2504,2722);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,2639,2711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,2675,2696);

_isMandatory = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,2639,2711);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,2504,2722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,2504,2722);
}
		}}

public int Position
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,3051,3119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,3087,3104);

return _position;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,3051,3119);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,3007,3215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,3007,3215);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,3135,3204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,3171,3189);

_position = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,3135,3204);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,3007,3215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,3007,3215);
}
		}}

public bool ValueFromPipeline
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,3422,3499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,3458,3484);

return _valueFromPipeline;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,3422,3499);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,3368,3604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,3368,3604);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,3515,3593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,3551,3578);

_valueFromPipeline = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,3515,3593);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,3368,3604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,3368,3604);
}
		}}

public bool ValueFromPipelineByPropertyName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,3890,3981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,3926,3966);

return _valueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,3890,3981);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,3822,4100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,3822,4100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,3997,4089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,4033,4074);

_valueFromPipelineByPropertyName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,3997,4089);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,3822,4100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,3822,4100);
}
		}}

public bool ValueFromRemainingArguments
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,4369,4456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,4405,4441);

return _valueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,4369,4456);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,4305,4571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,4305,4571);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,4472,4560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,4508,4545);

_valueFromRemainingArguments = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,4472,4560);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,4305,4571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,4305,4571);
}
		}}

public string HelpMessage
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,4774,4845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,4810,4830);

return _helpMessage;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,4774,4845);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,4724,4944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,4724,4944);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,4861,4933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,4897,4918);

_helpMessage = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,4861,4933);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,4724,4944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,4724,4944);
}
		}}

public string HelpMessageBaseName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,5124,5203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,5160,5188);

return _helpMessageBaseName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,5124,5203);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,5066,5310);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,5066,5310);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,5219,5299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,5255,5284);

_helpMessageBaseName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,5219,5299);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,5066,5310);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,5066,5310);
}
		}}

public string HelpMessageResourceId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,5485,5566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,5521,5551);

return _helpMessageResourceId;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,5485,5566);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,5425,5675);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,5425,5675);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,5582,5664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,5618,5649);

_helpMessageResourceId = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,5582,5664);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,5425,5675);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,5425,5675);
}
		}}

internal void Initialize(ParameterSetSpecificMetadata psMD)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,5856,6419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,5940,5972);

_isMandatory = f_1366_5955_5971(psMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,5986,6012);

_position = f_1366_5998_6011(psMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,6026,6070);

_valueFromPipeline = f_1366_6047_6069(psMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,6084,6156);

_valueFromPipelineByPropertyName = f_1366_6119_6155(psMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,6170,6234);

_valueFromRemainingArguments = f_1366_6201_6233(psMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,6248,6280);

_helpMessage = f_1366_6263_6279(psMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,6294,6342);

_helpMessageBaseName = f_1366_6317_6341(psMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,6356,6408);

_helpMessageResourceId = f_1366_6381_6407(psMD);
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,5856,6419);

bool
f_1366_5955_5971(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.IsMandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 5955, 5971);
return return_v;
}


int
f_1366_5998_6011(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 5998, 6011);
return return_v;
}


bool
f_1366_6047_6069(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 6047, 6069);
return return_v;
}


bool
f_1366_6119_6155(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 6119, 6155);
return return_v;
}


bool
f_1366_6201_6233(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 6201, 6233);
return return_v;
}


string
f_1366_6263_6279(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.HelpMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 6263, 6279);
return return_v;
}


string
f_1366_6317_6341(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.HelpMessageBaseName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 6317, 6341);
return return_v;
}


string
f_1366_6381_6407(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.HelpMessageResourceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 6381, 6407);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,5856,6419);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,5856,6419);
}
		}

internal bool Equals(ParameterSetMetadata second)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,6776,7512);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,6850,7473) || true) && ((_isMandatory != second._isMandatory) ||(DynAbs.Tracing.TraceSender.Expression_False(1366, 6854, 6943)||                (_position != second._position) )||(DynAbs.Tracing.TraceSender.Expression_False(1366, 6854, 7013)||                (_valueFromPipeline != second._valueFromPipeline) )||(DynAbs.Tracing.TraceSender.Expression_False(1366, 6854, 7111)||                (_valueFromPipelineByPropertyName != second._valueFromPipelineByPropertyName) )||(DynAbs.Tracing.TraceSender.Expression_False(1366, 6854, 7201)||                (_valueFromRemainingArguments != second._valueFromRemainingArguments) )||(DynAbs.Tracing.TraceSender.Expression_False(1366, 6854, 7259)||                (_helpMessage != second._helpMessage) )||(DynAbs.Tracing.TraceSender.Expression_False(1366, 6854, 7333)||                (_helpMessageBaseName != second._helpMessageBaseName) )||(DynAbs.Tracing.TraceSender.Expression_False(1366, 6854, 7411)||                (_helpMessageResourceId != second._helpMessageResourceId)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,6850,7473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,7445,7458);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,6850,7473);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,7489,7501);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,6776,7512);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,6776,7512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,6776,7512);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        
        
        [Flags]
        internal enum ParameterFlags : uint
        {
            Mandatory = 0x01,
            ValueFromPipeline = 0x02,
            ValueFromPipelineByPropertyName = 0x04,
            ValueFromRemainingArguments = 0x08,
        }

internal ParameterFlags Flags
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,7921,8446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,7957,7982);

ParameterFlags 
flags = 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8000,8062) || true) && (f_1366_8004_8015())
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,8000,8062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8019,8060);

flags = flags | ParameterFlags.Mandatory;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,8000,8062);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8082,8158) || true) && (f_1366_8086_8103())
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,8082,8158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8107,8156);

flags = flags | ParameterFlags.ValueFromPipeline;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,8082,8158);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8178,8282) || true) && (f_1366_8182_8213())
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,8178,8282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8217,8280);

flags = flags | ParameterFlags.ValueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,8178,8282);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8302,8398) || true) && (f_1366_8306_8333())
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,8302,8398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8337,8396);

flags = flags | ParameterFlags.ValueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,8302,8398);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8418,8431);

return flags;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,7921,8446);

bool
f_1366_8004_8015()
{
var return_v = IsMandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 8004, 8015);
return return_v;
}


bool
f_1366_8086_8103()
{
var return_v = ValueFromPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 8086, 8103);
return return_v;
}


bool
f_1366_8182_8213()
{
var return_v = ValueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 8182, 8213);
return return_v;
}


bool
f_1366_8306_8333()
{
var return_v = ValueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 8306, 8333);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,7867,9052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,7867,9052);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,8462,9041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8498,8582);

this.IsMandatory = (ParameterFlags.Mandatory == (value & ParameterFlags.Mandatory));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8600,8706);

this.ValueFromPipeline = (ParameterFlags.ValueFromPipeline == (value & ParameterFlags.ValueFromPipeline));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8724,8872);

this.ValueFromPipelineByPropertyName = (ParameterFlags.ValueFromPipelineByPropertyName == (value & ParameterFlags.ValueFromPipelineByPropertyName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,8890,9026);

this.ValueFromRemainingArguments = (ParameterFlags.ValueFromRemainingArguments == (value & ParameterFlags.ValueFromRemainingArguments));
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,8462,9041);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,7867,9052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,7867,9052);
}
		}}

internal ParameterSetMetadata(
            int position,
            ParameterFlags flags,
            string helpMessage)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,9157,9421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,631,643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,666,675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,699,717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,741,773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,797,825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,851,863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,889,909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,935,957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9307,9332);

this.Position = position;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9346,9365);

this.Flags = flags;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9379,9410);

this.HelpMessage = helpMessage;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,9157,9421);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,9157,9421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,9157,9421);
}
		}

private const string 
MandatoryFormat = @"{0}Mandatory=$true"
;

private const string 
PositionFormat = @"{0}Position={1}"
;

private const string 
ValueFromPipelineFormat = @"{0}ValueFromPipeline=$true"
;

private const string 
ValueFromPipelineByPropertyNameFormat = @"{0}ValueFromPipelineByPropertyName=$true"
;

private const string 
ValueFromRemainingArgumentsFormat = @"{0}ValueFromRemainingArguments=$true"
;

private const string 
HelpMessageFormat = @"{0}HelpMessage='{1}'"
;

internal string GetProxyParameterData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,10105,11739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10169,10229);

Text.StringBuilder 
result = f_1366_10197_10228()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10243,10272);

string 
prefix = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10288,10460) || true) && (_isMandatory)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,10288,10460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10338,10413);

f_1366_10338_10412(                result, f_1366_10358_10386(), MandatoryFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10431,10445);

prefix = ", ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,10288,10460);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10476,10673) || true) && (_position != Int32.MinValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,10476,10673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10541,10626);

f_1366_10541_10625(                result, f_1366_10561_10589(), PositionFormat, prefix, _position);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10644,10658);

prefix = ", ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,10476,10673);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10689,10875) || true) && (_valueFromPipeline)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,10689,10875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10745,10828);

f_1366_10745_10827(                result, f_1366_10765_10793(), ValueFromPipelineFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10846,10860);

prefix = ", ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,10689,10875);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10891,11105) || true) && (_valueFromPipelineByPropertyName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,10891,11105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,10961,11058);

f_1366_10961_11057(                result, f_1366_10981_11009(), ValueFromPipelineByPropertyNameFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11076,11090);

prefix = ", ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,10891,11105);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11121,11327) || true) && (_valueFromRemainingArguments)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,11121,11327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11187,11280);

f_1366_11187_11279(                result, f_1366_11207_11235(), ValueFromRemainingArgumentsFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11298,11312);

prefix = ", ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,11121,11327);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11343,11687) || true) && (!f_1366_11348_11382(_helpMessage))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,11343,11687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11416,11640);

f_1366_11416_11639(                result, f_1366_11458_11486(), HelpMessageFormat, prefix, f_1366_11578_11638(_helpMessage));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11658,11672);

prefix = ", ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,11343,11687);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11703,11728);

return f_1366_11710_11727(result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,10105,11739);

System.Text.StringBuilder
f_1366_10197_10228()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 10197, 10228);
return return_v;
}


System.Globalization.CultureInfo
f_1366_10358_10386()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 10358, 10386);
return return_v;
}


System.Text.StringBuilder
f_1366_10338_10412(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 10338, 10412);
return return_v;
}


System.Globalization.CultureInfo
f_1366_10561_10589()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 10561, 10589);
return return_v;
}


System.Text.StringBuilder
f_1366_10541_10625(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,int
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 10541, 10625);
return return_v;
}


System.Globalization.CultureInfo
f_1366_10765_10793()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 10765, 10793);
return return_v;
}


System.Text.StringBuilder
f_1366_10745_10827(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 10745, 10827);
return return_v;
}


System.Globalization.CultureInfo
f_1366_10981_11009()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 10981, 11009);
return return_v;
}


System.Text.StringBuilder
f_1366_10961_11057(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 10961, 11057);
return return_v;
}


System.Globalization.CultureInfo
f_1366_11207_11235()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 11207, 11235);
return return_v;
}


System.Text.StringBuilder
f_1366_11187_11279(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 11187, 11279);
return return_v;
}


bool
f_1366_11348_11382(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 11348, 11382);
return return_v;
}


System.Globalization.CultureInfo
f_1366_11458_11486()
{
var return_v =                     CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 11458, 11486);
return return_v;
}


string
f_1366_11578_11638(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 11578, 11638);
return return_v;
}


System.Text.StringBuilder
f_1366_11416_11639(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 11416, 11639);
return return_v;
}


string
f_1366_11710_11727(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 11710, 11727);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,10105,11739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,10105,11739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ParameterSetMetadata()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1366,529,11768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9522,9561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9593,9628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9660,9715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9747,9830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9862,9937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,9969,10012);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1366,529,11768);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,529,11768);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1366,529,11768);

int
f_1366_1200_1271(bool
condition,string
message)
{
Dbg.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 1200, 1271);
return 0;
}


int
f_1366_1286_1302(System.Management.Automation.ParameterSetMetadata
this_param,System.Management.Automation.ParameterSetSpecificMetadata
psMD)
{
this_param.Initialize( psMD);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 1286, 1302);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1366_1687_1734(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 1687, 1734);
return return_v;
}

}
public sealed class ParameterMetadata
{
private string _name;

private Type _parameterType;

private bool _isDynamic;

private Dictionary<string, ParameterSetMetadata> _parameterSets;

private Collection<string> _aliases;

private Collection<Attribute> _attributes;

public ParameterMetadata(string name)
:this(f_1366_12658_12662_C(name) ,null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,12600,12691);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,12600,12691);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,12600,12691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,12600,12691);
}
		}

public ParameterMetadata(string name, Type parameterType)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,13102,13587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11986,11991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12015,12029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12053,12063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12123,12137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12175,12183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12224,12235);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13184,13316) || true) && (f_1366_13188_13214(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,13184,13316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13248,13301);

throw f_1366_13254_13300("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,13184,13316);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13332,13345);

_name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13359,13390);

_parameterType = parameterType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13406,13448);

_attributes = f_1366_13420_13447();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13462,13498);

_aliases = f_1366_13473_13497();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13512,13576);

_parameterSets = f_1366_13529_13575();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,13102,13587);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,13102,13587);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,13102,13587);
}
		}

public ParameterMetadata(ParameterMetadata other)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,13896,15552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11986,11991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12015,12029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12053,12063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12123,12137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12175,12183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12224,12235);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,13970,14090) || true) && (other == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,13970,14090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14021,14075);

throw f_1366_14027_14074("other");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,13970,14090);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14106,14136);

_isDynamic = other._isDynamic;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14150,14170);

_name = other._name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14184,14222);

_parameterType = other._parameterType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14264,14338);

_aliases = f_1366_14275_14337(f_1366_14298_14336(f_1366_14315_14335(other._aliases)));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14352,14460);
foreach(string alias in f_1366_14377_14391_I(other._aliases) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,14352,14460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14425,14445);

f_1366_14425_14444(                _aliases, alias);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,14352,14460);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,109);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,109);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14571,14975) || true) && (other._attributes == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,14571,14975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14634,14653);

_attributes = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,14571,14975);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,14571,14975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14719,14805);

_attributes = f_1366_14733_14804(f_1366_14759_14803(f_1366_14779_14802(other._attributes)));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14823,14960);
foreach(Attribute attribute in f_1366_14855_14872_I(other._attributes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,14823,14960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,14914,14941);

f_1366_14914_14940(                    _attributes, attribute);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,14823,14960);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,138);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1366,14571,14975);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,15017,15039);

_parameterSets = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,15053,15541) || true) && (other._parameterSets == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,15053,15541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,15119,15141);

_parameterSets = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,15053,15541);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,15053,15541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,15207,15297);

_parameterSets = f_1366_15224_15296(f_1366_15269_15295(other._parameterSets));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,15315,15526);
foreach(KeyValuePair<string, ParameterSetMetadata> entry in f_1366_15376_15396_I(other._parameterSets) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,15315,15526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,15438,15507);

f_1366_15438_15506(                    _parameterSets, entry.Key, f_1366_15468_15505(entry.Value));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,15315,15526);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,212);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,212);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1366,15053,15541);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,13896,15552);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,13896,15552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,13896,15552);
}
		}

internal ParameterMetadata(CompiledCommandParameter cmdParameterMD)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,15954,16195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11986,11991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12015,12029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12053,12063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12123,12137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12175,12183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12224,12235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16046,16141);

f_1366_16046_16140(cmdParameterMD != null, "CompiledCommandParameter cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16157,16184);

f_1366_16157_16183(this, cmdParameterMD);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,15954,16195);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,15954,16195);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,15954,16195);
}
		}

internal ParameterMetadata(
            Collection<string> aliases,
            bool isDynamic,
            string name,
            Dictionary<string, ParameterSetMetadata> parameterSets,
            Type parameterType)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,16306,16796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,11986,11991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12015,12029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12053,12063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12123,12137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12175,12183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,12224,12235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16556,16575);

_aliases = aliases;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16589,16612);

_isDynamic = isDynamic;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16626,16639);

_name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16653,16684);

_parameterSets = parameterSets;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16698,16729);

_parameterType = parameterType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,16743,16785);

_attributes = f_1366_16757_16784();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,16306,16796);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,16306,16796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,16306,16796);
}
		}

public string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,17010,17074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,17046,17059);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,17010,17074);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,16967,17331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,16967,17331);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,17090,17320);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,17126,17271) || true) && (f_1366_17130_17157(value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,17126,17271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,17199,17252);

throw f_1366_17205_17251("Name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,17126,17271);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,17291,17305);

_name = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,17090,17320);

bool
f_1366_17130_17157(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 17130, 17157);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1366_17205_17251(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 17205, 17251);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,16967,17331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,16967,17331);
}
		}}

public Type ParameterType
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,17497,17570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,17533,17555);

return _parameterType;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,17497,17570);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,17447,17671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,17447,17671);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,17586,17660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,17622,17645);

_parameterType = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,17586,17660);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,17447,17671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,17447,17671);
}
		}}

public Dictionary<string, ParameterSetMetadata> ParameterSets
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,17893,17966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,17929,17951);

return _parameterSets;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,17893,17966);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,17807,17977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,17807,17977);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool IsDynamic
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,18134,18160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,18140,18158);

return _isDynamic;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,18134,18160);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,18088,18214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,18088,18214);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,18176,18203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,18182,18201);

_isDynamic = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,18176,18203);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,18088,18214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,18088,18214);
}
		}}

public Collection<string> Aliases
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,18388,18455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,18424,18440);

return _aliases;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,18388,18455);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,18330,18466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,18330,18466);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Collection<Attribute> Attributes
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,18654,18724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,18690,18709);

return _attributes;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,18654,18724);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,18590,18735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,18590,18735);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool SwitchParameter
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,18908,19133);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,18944,19085) || true) && (_parameterType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,18944,19085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,19012,19066);

return f_1366_19019_19065(_parameterType, typeof(SwitchParameter));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,18944,19085);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,19105,19118);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,18908,19133);

bool
f_1366_19019_19065(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 19019, 19065);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,18856,19144);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,18856,19144);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public static Dictionary<string, ParameterMetadata> GetParameterMetadata(Type type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1366,19703,20183);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,19811,19929) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,19811,19929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,19861,19914);

throw f_1366_19867_19913("type");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,19811,19929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,19945,20001);

CommandMetadata 
cmdMetaData = f_1366_19975_20000(type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20015,20085);

Dictionary<string, ParameterMetadata> 
result = f_1366_20062_20084(cmdMetaData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20125,20144);

cmdMetaData = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20158,20172);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1366,19703,20183);

System.Management.Automation.PSArgumentNullException
f_1366_19867_19913(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 19867, 19913);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1366_19975_20000(System.Type
commandType)
{
var return_v = new System.Management.Automation.CommandMetadata( commandType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 19975, 20000);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1366_20062_20084(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20062, 20084);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,19703,20183);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,19703,20183);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Initialize(CompiledCommandParameter compiledParameterMD)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,20367,21550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20462,20495);

_name = f_1366_20470_20494(compiledParameterMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20509,20551);

_parameterType = f_1366_20526_20550(compiledParameterMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20565,20608);

_isDynamic = f_1366_20578_20607(compiledParameterMD);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20670,20766);

_parameterSets = f_1366_20687_20765(f_1366_20732_20764());
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20780,21043);
foreach(string key in f_1366_20803_20844_I(f_1366_20803_20844(f_1366_20803_20839(compiledParameterMD))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,20780,21043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20878,20955);

ParameterSetSpecificMetadata 
pMD = f_1366_20913_20954(f_1366_20913_20949(compiledParameterMD), key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,20973,21028);

f_1366_20973_21027(                _parameterSets, key, f_1366_20997_21026(pMD));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,20780,21043);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,264);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,264);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21109,21145);

_aliases = f_1366_21120_21144();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21159,21280);
foreach(string alias in f_1366_21184_21211_I(f_1366_21184_21211(compiledParameterMD)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,21159,21280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21245,21265);

f_1366_21245_21264(                _aliases, alias);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,21159,21280);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,122);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21349,21391);

_attributes = f_1366_21363_21390();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21405,21539);
foreach(var attrib in f_1366_21428_21466_I(f_1366_21428_21466(compiledParameterMD)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,21405,21539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21500,21524);

f_1366_21500_21523(                _attributes, attrib);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,21405,21539);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,135);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,135);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1366,20367,21550);

string
f_1366_20470_20494(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20470, 20494);
return return_v;
}


System.Type
f_1366_20526_20550(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20526, 20550);
return return_v;
}


bool
f_1366_20578_20607(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.IsDynamic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20578, 20607);
return return_v;
}


System.StringComparer
f_1366_20732_20764()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20732, 20764);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
f_1366_20687_20765(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 20687, 20765);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
f_1366_20803_20839(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.ParameterSetData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20803, 20839);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
f_1366_20803_20844(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20803, 20844);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
f_1366_20913_20949(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.ParameterSetData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20913, 20949);
return return_v;
}


System.Management.Automation.ParameterSetSpecificMetadata
f_1366_20913_20954(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 20913, 20954);
return return_v;
}


System.Management.Automation.ParameterSetMetadata
f_1366_20997_21026(System.Management.Automation.ParameterSetSpecificMetadata
psMD)
{
var return_v = new System.Management.Automation.ParameterSetMetadata( psMD);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 20997, 21026);
return return_v;
}


int
f_1366_20973_21027(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
this_param,string
key,System.Management.Automation.ParameterSetMetadata
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 20973, 21027);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
f_1366_20803_20844_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 20803, 20844);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1366_21120_21144()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 21120, 21144);
return return_v;
}


string[]
f_1366_21184_21211(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Aliases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 21184, 21211);
return return_v;
}


int
f_1366_21245_21264(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 21245, 21264);
return 0;
}


string[]
f_1366_21184_21211_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 21184, 21211);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_21363_21390()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 21363, 21390);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_21428_21466(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.CompiledAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 21428, 21466);
return return_v;
}


int
f_1366_21500_21523(System.Collections.ObjectModel.Collection<System.Attribute>
this_param,System.Attribute
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 21500, 21523);
return 0;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_21428_21466_I(System.Collections.ObjectModel.Collection<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 21428, 21466);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,20367,21550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,20367,21550);
}
		}

internal static Dictionary<string, ParameterMetadata> GetParameterMetadata(MergedCommandParameterMetadata
            cmdParameterMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1366,21699,22505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21864,21944);

f_1366_21864_21943(cmdParameterMetadata != null, "cmdParameterMetadata cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,21960,22083);

Dictionary<string, ParameterMetadata> 
result = f_1366_22007_22082(f_1366_22049_22081())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22099,22464);
foreach(var keyValuePair in f_1366_22128_22167_I(f_1366_22128_22167(cmdParameterMetadata)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,22099,22464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22201,22228);

var 
key = keyValuePair.Key
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22246,22289);

var 
mergedCompiledPMD = keyValuePair.Value
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22307,22396);

ParameterMetadata 
parameterMetaData = f_1366_22345_22395(f_1366_22367_22394(mergedCompiledPMD))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22414,22449);

f_1366_22414_22448(                result, key, parameterMetaData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,22099,22464);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,366);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,366);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22480,22494);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1366,21699,22505);

int
f_1366_21864_21943(bool
condition,string
message)
{
Dbg.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 21864, 21943);
return 0;
}


System.StringComparer
f_1366_22049_22081()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 22049, 22081);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1366_22007_22082(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 22007, 22082);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
f_1366_22128_22167(System.Management.Automation.MergedCommandParameterMetadata
this_param)
{
var return_v = this_param.BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 22128, 22167);
return return_v;
}


System.Management.Automation.CompiledCommandParameter
f_1366_22367_22394(System.Management.Automation.MergedCompiledCommandParameter
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 22367, 22394);
return return_v;
}


System.Management.Automation.ParameterMetadata
f_1366_22345_22395(System.Management.Automation.CompiledCommandParameter
cmdParameterMD)
{
var return_v = new System.Management.Automation.ParameterMetadata( cmdParameterMD);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 22345, 22395);
return return_v;
}


int
f_1366_22414_22448(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
this_param,string
key,System.Management.Automation.ParameterMetadata
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 22414, 22448);
return 0;
}


System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
f_1366_22128_22167_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 22128, 22167);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,21699,22505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,21699,22505);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsMatchingType(PSTypeName psTypeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,22517,24812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22593,22627);

Type 
dotNetType = f_1366_22611_22626(psTypeName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22641,23890) || true) && (dotNetType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,22641,23890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,22818,23016);

bool 
parameterAcceptsObjects =
                    ((int)(f_1366_22877_22953(f_1366_22877_22948(typeof(object), f_1366_22929_22947(this))))) >=
                    (int)(ConversionRank.AssignableS2A)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23034,23163) || true) && (f_1366_23038_23071(dotNetType, typeof(object)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,23034,23163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23113,23144);

return parameterAcceptsObjects;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,23034,23163);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23183,23348) || true) && (parameterAcceptsObjects)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,23183,23348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23252,23329);

return (f_1366_23260_23275(psTypeName)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1366, 23259, 23328)&&(f_1366_23289_23327(f_1366_23289_23304(psTypeName), typeof(object))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,23183,23348);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23489,23578);

var 
conversionData = f_1366_23510_23577(dotNetType, f_1366_23558_23576(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23596,23842) || true) && (conversionData != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,23596,23842);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23664,23823) || true) && ((int)(f_1366_23674_23693(conversionData)) >= (int)(ConversionRank.NumericImplicitS2A))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,23664,23823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23788,23800);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,23664,23823);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,23596,23842);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23862,23875);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,22641,23890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,23906,24087);

var 
wildcardPattern = f_1366_23928_24086("*" + (f_1366_23973_23988(psTypeName)??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1366, 23973, 24004)??string.Empty)), WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24101,24218) || true) && (f_1366_24105_24157(wildcardPattern, f_1366_24129_24156(f_1366_24129_24147(this))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,24101,24218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24191,24203);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,24101,24218);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24234,24400) || true) && (f_1366_24238_24264(f_1366_24238_24256(this))&&(DynAbs.Tracing.TraceSender.Expression_True(1366, 24238, 24339)&&f_1366_24268_24339(wildcardPattern, (f_1366_24293_24337(f_1366_24293_24328(f_1366_24293_24311(this)))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,24234,24400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24373,24385);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,24234,24400);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24416,24772) || true) && (f_1366_24420_24435(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,24416,24772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24477,24580);

PSTypeNameAttribute 
typeNameAttribute = f_1366_24517_24579(f_1366_24517_24562(f_1366_24517_24532(this)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24598,24757) || true) && (typeNameAttribute != null &&(DynAbs.Tracing.TraceSender.Expression_True(1366, 24602, 24684)&&f_1366_24631_24684(wildcardPattern, f_1366_24655_24683(typeNameAttribute))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,24598,24757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24726,24738);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,24598,24757);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,24416,24772);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24788,24801);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,22517,24812);

System.Type
f_1366_22611_22626(System.Management.Automation.PSTypeName
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 22611, 22626);
return return_v;
}


System.Type
f_1366_22929_22947(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 22929, 22947);
return return_v;
}


System.Management.Automation.LanguagePrimitives.IConversionData
f_1366_22877_22948(System.Type
fromType,System.Type
toType)
{
var return_v = LanguagePrimitives.FigureConversion( fromType, toType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 22877, 22948);
return return_v;
}


System.Management.Automation.ConversionRank
f_1366_22877_22953(System.Management.Automation.LanguagePrimitives.IConversionData
this_param)
{
var return_v = this_param.Rank;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 22877, 22953);
return return_v;
}


bool
f_1366_23038_23071(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 23038, 23071);
return return_v;
}


System.Type
f_1366_23260_23275(System.Management.Automation.PSTypeName
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 23260, 23275);
return return_v;
}


System.Type
f_1366_23289_23304(System.Management.Automation.PSTypeName
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 23289, 23304);
return return_v;
}


bool
f_1366_23289_23327(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 23289, 23327);
return return_v;
}


System.Type
f_1366_23558_23576(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 23558, 23576);
return return_v;
}


System.Management.Automation.LanguagePrimitives.IConversionData
f_1366_23510_23577(System.Type
fromType,System.Type
toType)
{
var return_v = LanguagePrimitives.FigureConversion( fromType, toType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 23510, 23577);
return return_v;
}


System.Management.Automation.ConversionRank
f_1366_23674_23693(System.Management.Automation.LanguagePrimitives.IConversionData
this_param)
{
var return_v = this_param.Rank;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 23674, 23693);
return return_v;
}


string
f_1366_23973_23988(System.Management.Automation.PSTypeName
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 23973, 23988);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1366_23928_24086(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 23928, 24086);
return return_v;
}


System.Type
f_1366_24129_24147(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24129, 24147);
return return_v;
}


string
f_1366_24129_24156(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24129, 24156);
return return_v;
}


bool
f_1366_24105_24157(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 24105, 24157);
return return_v;
}


System.Type
f_1366_24238_24256(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24238, 24256);
return return_v;
}


bool
f_1366_24238_24264(System.Type
this_param)
{
var return_v = this_param.IsArray ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24238, 24264);
return return_v;
}


System.Type
f_1366_24293_24311(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24293, 24311);
return return_v;
}


System.Type?
f_1366_24293_24328(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 24293, 24328);
return return_v;
}


string
f_1366_24293_24337(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24293, 24337);
return return_v;
}


bool
f_1366_24268_24339(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 24268, 24339);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_24420_24435(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24420, 24435);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_24517_24532(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24517, 24532);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeNameAttribute>
f_1366_24517_24562(System.Collections.ObjectModel.Collection<System.Attribute>
source)
{
var return_v = source.OfType<System.Management.Automation.PSTypeNameAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 24517, 24562);
return return_v;
}


System.Management.Automation.PSTypeNameAttribute
f_1366_24517_24579(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeNameAttribute>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.PSTypeNameAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 24517, 24579);
return return_v;
}


string
f_1366_24655_24683(System.Management.Automation.PSTypeNameAttribute
this_param)
{
var return_v = this_param.PSTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 24655, 24683);
return return_v;
}


bool
f_1366_24631_24684(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 24631, 24684);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,22517,24812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,22517,24812);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private const string 
ParameterNameFormat = @"{0}${{{1}}}"
;

private const string 
ParameterTypeFormat = @"{0}[{1}]"
;

private const string 
ParameterSetNameFormat = "ParameterSetName='{0}'"
;

private const string 
AliasesFormat = @"{0}[Alias({1})]"
;

private const string 
ValidateLengthFormat = @"{0}[ValidateLength({1}, {2})]"
;

private const string 
ValidateRangeRangeKindFormat = @"{0}[ValidateRange([System.Management.Automation.ValidateRangeKind]::{1})]"
;

private const string 
ValidateRangeFloatFormat = @"{0}[ValidateRange({1:R}, {2:R})]"
;

private const string 
ValidateRangeFormat = @"{0}[ValidateRange({1}, {2})]"
;

private const string 
ValidatePatternFormat = "{0}[ValidatePattern('{1}')]"
;

private const string 
ValidateScriptFormat = @"{0}[ValidateScript({{ {1} }})]"
;

private const string 
ValidateCountFormat = @"{0}[ValidateCount({1}, {2})]"
;

private const string 
ValidateSetFormat = @"{0}[ValidateSet({1})]"
;

private const string 
ValidateNotNullFormat = @"{0}[ValidateNotNull()]"
;

private const string 
ValidateNotNullOrEmptyFormat = @"{0}[ValidateNotNullOrEmpty()]"
;

private const string 
AllowNullFormat = @"{0}[AllowNull()]"
;

private const string 
AllowEmptyStringFormat = @"{0}[AllowEmptyString()]"
;

private const string 
AllowEmptyCollectionFormat = @"{0}[AllowEmptyCollection()]"
;

private const string 
PSTypeNameFormat = @"{0}[PSTypeName('{1}')]"
;

private const string 
ObsoleteFormat = @"{0}[Obsolete({1})]"
;

private const string 
CredentialAttributeFormat = @"{0}[System.Management.Automation.CredentialAttribute()]"
;

internal string GetProxyParameterData(string prefix, string paramNameOverride, bool isProxyForCmdlet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,27192,31365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27318,27378);

Text.StringBuilder 
result = f_1366_27346_27377()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27394,28850) || true) && (_parameterSets != null &&(DynAbs.Tracing.TraceSender.Expression_True(1366, 27398, 27440)&&isProxyForCmdlet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,27394,28850);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27474,28835);
foreach(var pair in f_1366_27495_27509_I(_parameterSets) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,27474,28835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27551,27586);

string 
parameterSetName = pair.Key
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27608,27655);

ParameterSetMetadata 
parameterSet = pair.Value
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27677,27736);

string 
paramSetData = f_1366_27699_27735(parameterSet)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27758,28816) || true) && (!f_1366_27763_27797(paramSetData)||(DynAbs.Tracing.TraceSender.Expression_False(1366, 27762, 27862)||!f_1366_27802_27862(parameterSetName, ParameterAttribute.AllParameterSets)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,27758,28816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27912,27944);

string 
separator = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,27970,27992);

f_1366_27970_27991(                        result, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28018,28047);

f_1366_28018_28046(                        result, "[Parameter(");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28073,28510) || true) && (!f_1366_28078_28138(parameterSetName, ParameterAttribute.AllParameterSets))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,28073,28510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28196,28436);

f_1366_28196_28435(                            result, f_1366_28250_28278(), ParameterSetNameFormat, f_1366_28370_28434(parameterSetName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28466,28483);

separator = ", ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,28073,28510);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28538,28745) || true) && (!f_1366_28543_28577(paramSetData))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,28538,28745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28635,28660);

f_1366_28635_28659(                            result, separator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28690,28718);

f_1366_28690_28717(                            result, paramSetData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,28538,28745);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28773,28793);

f_1366_28773_28792(
                        result, ")]");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,27758,28816);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,27474,28835);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,1362);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,1362);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1366,27394,28850);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28866,29610) || true) && ((_aliases != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1366, 28870, 28912)&&(f_1366_28893_28907(_aliases)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,28866,29610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,28946,29011);

Text.StringBuilder 
aliasesData = f_1366_28979_29010()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29029,29057);

string 
comma = string.Empty
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29120,29478);
foreach(string alias in f_1366_29145_29153_I(_aliases) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,29120,29478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29195,29425);

f_1366_29195_29424(                    aliasesData, f_1366_29246_29274(), "{0}'{1}'", comma, f_1366_29370_29423(alias));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29447,29459);

comma = ",";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,29120,29478);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,359);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,359);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29498,29595);

f_1366_29498_29594(
                result, f_1366_29518_29546(), AliasesFormat, prefix, f_1366_29571_29593(aliasesData));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,28866,29610);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29626,30044) || true) && ((_attributes != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1366, 29630, 29678)&&(f_1366_29656_29673(_attributes)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,29626,30044);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29712,30029);
foreach(Attribute attrib in f_1366_29741_29752_I(_attributes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,29712,30029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29794,29852);

string 
attribData = f_1366_29814_29851(this, attrib, prefix)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29874,30010) || true) && (!f_1366_29879_29911(attribData))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,29874,30010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,29961,29987);

f_1366_29961_29986(                        result, attribData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,29874,30010);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,29712,30029);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,318);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,318);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1366,29626,30044);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30060,30432) || true) && (f_1366_30064_30079())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,30060,30432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30113,30202);

f_1366_30113_30201(                result, f_1366_30133_30161(), ParameterTypeFormat, prefix, "switch");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,30060,30432);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,30060,30432);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30236,30432) || true) && (_parameterType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,30236,30432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30296,30417);

f_1366_30296_30416(                result, f_1366_30316_30344(), ParameterTypeFormat, prefix, f_1366_30375_30415(_parameterType));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,30236,30432);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,30060,30432);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30617,30715);

CredentialAttribute 
credentialAttrib = f_1366_30656_30714(f_1366_30656_30697(_attributes))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30729,31047) || true) && (credentialAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,30729,31047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30791,30890);

string 
attribData = f_1366_30811_30889(f_1366_30825_30853(), CredentialAttributeFormat, prefix)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30908,31032) || true) && (!f_1366_30913_30945(attribData))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,30908,31032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,30987,31013);

f_1366_30987_31012(                    result, attribData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,30908,31032);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,30729,31047);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,31063,31315);

f_1366_31063_31314(
            result, f_1366_31101_31129(), ParameterNameFormat, prefix, f_1366_31211_31313((DynAbs.Tracing.TraceSender.Conditional_F1(1366, 31245, 31284)||((f_1366_31245_31284(paramNameOverride)&&DynAbs.Tracing.TraceSender.Conditional_F2(1366, 31287, 31292))||DynAbs.Tracing.TraceSender.Conditional_F3(1366, 31295, 31312)))?_name :paramNameOverride));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,31329,31354);

return f_1366_31336_31353(result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,27192,31365);

System.Text.StringBuilder
f_1366_27346_27377()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 27346, 27377);
return return_v;
}


string
f_1366_27699_27735(System.Management.Automation.ParameterSetMetadata
this_param)
{
var return_v = this_param.GetProxyParameterData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 27699, 27735);
return return_v;
}


bool
f_1366_27763_27797(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 27763, 27797);
return return_v;
}


bool
f_1366_27802_27862(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 27802, 27862);
return return_v;
}


System.Text.StringBuilder
f_1366_27970_27991(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 27970, 27991);
return return_v;
}


System.Text.StringBuilder
f_1366_28018_28046(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28018, 28046);
return return_v;
}


bool
f_1366_28078_28138(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28078, 28138);
return return_v;
}


System.Globalization.CultureInfo
f_1366_28250_28278()
{
var return_v =                                 CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 28250, 28278);
return return_v;
}


string
f_1366_28370_28434(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28370, 28434);
return return_v;
}


System.Text.StringBuilder
f_1366_28196_28435(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28196, 28435);
return return_v;
}


bool
f_1366_28543_28577(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28543, 28577);
return return_v;
}


System.Text.StringBuilder
f_1366_28635_28659(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28635, 28659);
return return_v;
}


System.Text.StringBuilder
f_1366_28690_28717(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28690, 28717);
return return_v;
}


System.Text.StringBuilder
f_1366_28773_28792(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28773, 28792);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
f_1366_27495_27509_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 27495, 27509);
return return_v;
}


int
f_1366_28893_28907(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 28893, 28907);
return return_v;
}


System.Text.StringBuilder
f_1366_28979_29010()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 28979, 29010);
return return_v;
}


System.Globalization.CultureInfo
f_1366_29246_29274()
{
var return_v =                         CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 29246, 29274);
return return_v;
}


string
f_1366_29370_29423(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29370, 29423);
return return_v;
}


System.Text.StringBuilder
f_1366_29195_29424(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29195, 29424);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1366_29145_29153_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29145, 29153);
return return_v;
}


System.Globalization.CultureInfo
f_1366_29518_29546()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 29518, 29546);
return return_v;
}


string
f_1366_29571_29593(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29571, 29593);
return return_v;
}


System.Text.StringBuilder
f_1366_29498_29594(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29498, 29594);
return return_v;
}


int
f_1366_29656_29673(System.Collections.ObjectModel.Collection<System.Attribute>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 29656, 29673);
return return_v;
}


string
f_1366_29814_29851(System.Management.Automation.ParameterMetadata
this_param,System.Attribute
attrib,string
prefix)
{
var return_v = this_param.GetProxyAttributeData( attrib, prefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29814, 29851);
return return_v;
}


bool
f_1366_29879_29911(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29879, 29911);
return return_v;
}


System.Text.StringBuilder
f_1366_29961_29986(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29961, 29986);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_29741_29752_I(System.Collections.ObjectModel.Collection<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 29741, 29752);
return return_v;
}


bool
f_1366_30064_30079()
{
var return_v = SwitchParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 30064, 30079);
return return_v;
}


System.Globalization.CultureInfo
f_1366_30133_30161()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 30133, 30161);
return return_v;
}


System.Text.StringBuilder
f_1366_30113_30201(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30113, 30201);
return return_v;
}


System.Globalization.CultureInfo
f_1366_30316_30344()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 30316, 30344);
return return_v;
}


string
f_1366_30375_30415(System.Type
type)
{
var return_v = ToStringCodeMethods.Type( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30375, 30415);
return return_v;
}


System.Text.StringBuilder
f_1366_30296_30416(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30296, 30416);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.CredentialAttribute>
f_1366_30656_30697(System.Collections.ObjectModel.Collection<System.Attribute>
source)
{
var return_v = source.OfType<System.Management.Automation.CredentialAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30656, 30697);
return return_v;
}


System.Management.Automation.CredentialAttribute
f_1366_30656_30714(System.Collections.Generic.IEnumerable<System.Management.Automation.CredentialAttribute>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.CredentialAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30656, 30714);
return return_v;
}


System.Globalization.CultureInfo
f_1366_30825_30853()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 30825, 30853);
return return_v;
}


string
f_1366_30811_30889(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30811, 30889);
return return_v;
}


bool
f_1366_30913_30945(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30913, 30945);
return return_v;
}


System.Text.StringBuilder
f_1366_30987_31012(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 30987, 31012);
return return_v;
}


System.Globalization.CultureInfo
f_1366_31101_31129()
{
var return_v =                 CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 31101, 31129);
return return_v;
}


bool
f_1366_31245_31284(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 31245, 31284);
return return_v;
}


string
f_1366_31211_31313(string
value)
{
var return_v = CodeGeneration.EscapeVariableName( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 31211, 31313);
return return_v;
}


System.Text.StringBuilder
f_1366_31063_31314(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 31063, 31314);
return return_v;
}


string
f_1366_31336_31353(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 31336, 31353);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,27192,31365);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,27192,31365);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetProxyAttributeData(Attribute attrib, string prefix)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,31783,40245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,31877,31891);

string 
result
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,31907,31985);

ValidateLengthAttribute 
validLengthAttrib = attrib as ValidateLengthAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,31999,32335) || true) && (validLengthAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,31999,32335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32062,32288);

result = f_1366_32071_32287(f_1366_32107_32135(), ValidateLengthFormat, prefix, f_1366_32209_32236(validLengthAttrib), f_1366_32259_32286(validLengthAttrib));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32306,32320);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,31999,32335);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32351,32426);

ValidateRangeAttribute 
validRangeAttrib = attrib as ValidateRangeAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32440,33683) || true) && (validRangeAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,32440,33683);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32502,33668) || true) && (f_1366_32506_32541(f_1366_32506_32532(validRangeAttrib)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,32502,33668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32583,32814);

result = f_1366_32592_32813(f_1366_32632_32660(), ValidateRangeRangeKindFormat, prefix, f_1366_32775_32812(f_1366_32775_32801(validRangeAttrib)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32836,32850);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,32502,33668);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,32502,33668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,32932,32985);

Type 
rangeType = f_1366_32949_32984(f_1366_32949_32974(validRangeAttrib))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33007,33021);

string 
format
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33045,33340) || true) && (rangeType == typeof(float) ||(DynAbs.Tracing.TraceSender.Expression_False(1366, 33049, 33106)||rangeType == typeof(double)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,33045,33340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33156,33190);

format = ValidateRangeFloatFormat;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,33045,33340);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,33045,33340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33288,33317);

format = ValidateRangeFormat;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,33045,33340);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33364,33613);

result = f_1366_33373_33612(f_1366_33413_33441(), format, prefix, f_1366_33534_33559(validRangeAttrib), f_1366_33586_33611(validRangeAttrib));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33635,33649);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,32502,33668);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,32440,33683);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33699,33765);

AllowNullAttribute 
allowNullAttrib = attrib as AllowNullAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33779,33986) || true) && (allowNullAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,33779,33986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33840,33939);

result = f_1366_33849_33938(f_1366_33863_33891(), AllowNullFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,33957,33971);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,33779,33986);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34002,34089);

AllowEmptyStringAttribute 
allowEmptyStringAttrib = attrib as AllowEmptyStringAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34103,34324) || true) && (allowEmptyStringAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,34103,34324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34171,34277);

result = f_1366_34180_34276(f_1366_34194_34222(), AllowEmptyStringFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34295,34309);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,34103,34324);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34340,34432);

AllowEmptyCollectionAttribute 
allowEmptyColAttrib = attrib as AllowEmptyCollectionAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34446,34668) || true) && (allowEmptyColAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,34446,34668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34511,34621);

result = f_1366_34520_34620(f_1366_34534_34562(), AllowEmptyCollectionFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34639,34653);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,34446,34668);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34684,34760);

ValidatePatternAttribute 
patternAttrib = attrib as ValidatePatternAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,34774,36296) || true) && (patternAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,34774,36296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36001,36249);

result = f_1366_36010_36248(f_1366_36024_36052(), ValidatePatternFormat, prefix, f_1366_36127_36201(f_1366_36174_36200(patternAttrib)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36267,36281);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,34774,36296);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36312,36382);

ValidateCountAttribute 
countAttrib = attrib as ValidateCountAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36396,36649) || true) && (countAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,36396,36649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36453,36602);

result = f_1366_36462_36601(f_1366_36476_36504(), ValidateCountFormat, prefix, f_1366_36556_36577(countAttrib), f_1366_36579_36600(countAttrib));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36620,36634);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,36396,36649);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36665,36741);

ValidateNotNullAttribute 
notNullAttrib = attrib as ValidateNotNullAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36755,36966) || true) && (notNullAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,36755,36966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36814,36919);

result = f_1366_36823_36918(f_1366_36837_36865(), ValidateNotNullFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36937,36951);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,36755,36966);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,36982,37077);

ValidateNotNullOrEmptyAttribute 
notNullEmptyAttrib = attrib as ValidateNotNullOrEmptyAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37091,37314) || true) && (notNullEmptyAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,37091,37314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37155,37267);

result = f_1366_37164_37266(f_1366_37178_37206(), ValidateNotNullOrEmptyFormat, prefix);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37285,37299);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,37091,37314);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37330,37394);

ValidateSetAttribute 
setAttrib = attrib as ValidateSetAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37408,38176) || true) && (setAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,37408,38176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37463,37523);

Text.StringBuilder 
values = f_1366_37491_37522()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37541,37569);

string 
comma = string.Empty
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37587,37963);
foreach(string validValue in f_1366_37617_37638_I(f_1366_37617_37638(setAttrib)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,37587,37963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37680,37910);

f_1366_37680_37909(                    values, f_1366_37726_37754(), "{0}'{1}'", comma, f_1366_37850_37908(validValue));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37932,37944);

comma = ",";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,37587,37963);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,377);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,377);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,37983,38129);

result = f_1366_37992_38128(f_1366_38006_38034(), ValidateSetFormat, prefix, f_1366_38084_38101(values));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,38147,38161);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,37408,38176);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,38192,38265);

ValidateScriptAttribute 
scriptAttrib = attrib as ValidateScriptAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,38279,38856) || true) && (scriptAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,38279,38856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,38668,38809);

result = f_1366_38677_38808(f_1366_38691_38719(), ValidateScriptFormat, prefix, f_1366_38772_38807(f_1366_38772_38796(scriptAttrib)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,38827,38841);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,38279,38856);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,38872,38941);

PSTypeNameAttribute 
psTypeNameAttrib = attrib as PSTypeNameAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,38955,39305) || true) && (psTypeNameAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,38955,39305);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39017,39258);

result = f_1366_39026_39257(f_1366_39062_39090(), PSTypeNameFormat, prefix, f_1366_39181_39256(f_1366_39228_39255(psTypeNameAttrib)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39276,39290);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,38955,39305);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39321,39384);

ObsoleteAttribute 
obsoleteAttrib = attrib as ObsoleteAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39398,40206) || true) && (obsoleteAttrib != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,39398,40206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39458,39491);

string 
parameters = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39509,39965) || true) && (f_1366_39513_39535(obsoleteAttrib))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,39509,39965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39577,39677);

string 
message = "'" + f_1366_39600_39670(f_1366_39647_39669(obsoleteAttrib))+ "'"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39699,39732);

parameters = message + ", $true";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,39509,39965);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,39509,39965);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39774,39965) || true) && (f_1366_39778_39800(obsoleteAttrib)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,39774,39965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39850,39946);

parameters = "'" + f_1366_39869_39939(f_1366_39916_39938(obsoleteAttrib))+ "'";
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,39774,39965);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,39509,39965);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,39985,40159);

result = f_1366_39994_40158(f_1366_40030_40058(), ObsoleteFormat, prefix, parameters);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,40177,40191);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,39398,40206);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,40222,40234);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,31783,40245);

System.Globalization.CultureInfo
f_1366_32107_32135()
{
var return_v =                     CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32107, 32135);
return return_v;
}


int
f_1366_32209_32236(System.Management.Automation.ValidateLengthAttribute
this_param)
{
var return_v = this_param.MinLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32209, 32236);
return return_v;
}


int
f_1366_32259_32286(System.Management.Automation.ValidateLengthAttribute
this_param)
{
var return_v = this_param.MaxLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32259, 32286);
return return_v;
}


string
f_1366_32071_32287(System.Globalization.CultureInfo
provider,string
format,string
arg0,int
arg1,int
arg2)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 32071, 32287);
return return_v;
}


System.Management.Automation.ValidateRangeKind?
f_1366_32506_32532(System.Management.Automation.ValidateRangeAttribute
this_param)
{
var return_v = this_param.RangeKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32506, 32532);
return return_v;
}


bool
f_1366_32506_32541(System.Management.Automation.ValidateRangeKind?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32506, 32541);
return return_v;
}


System.Globalization.CultureInfo
f_1366_32632_32660()
{
var return_v =                         CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32632, 32660);
return return_v;
}


System.Management.Automation.ValidateRangeKind?
f_1366_32775_32801(System.Management.Automation.ValidateRangeAttribute
this_param)
{
var return_v = this_param.RangeKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32775, 32801);
return return_v;
}


string?
f_1366_32775_32812(System.Management.Automation.ValidateRangeKind?
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 32775, 32812);
return return_v;
}


string
f_1366_32592_32813(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 32592, 32813);
return return_v;
}


object
f_1366_32949_32974(System.Management.Automation.ValidateRangeAttribute
this_param)
{
var return_v = this_param.MinRange;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 32949, 32974);
return return_v;
}


System.Type
f_1366_32949_32984(object
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 32949, 32984);
return return_v;
}


System.Globalization.CultureInfo
f_1366_33413_33441()
{
var return_v =                         CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 33413, 33441);
return return_v;
}


object
f_1366_33534_33559(System.Management.Automation.ValidateRangeAttribute
this_param)
{
var return_v = this_param.MinRange;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 33534, 33559);
return return_v;
}


object
f_1366_33586_33611(System.Management.Automation.ValidateRangeAttribute
this_param)
{
var return_v = this_param.MaxRange;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 33586, 33611);
return return_v;
}


string
f_1366_33373_33612(System.Globalization.CultureInfo
provider,string
format,string
arg0,object
arg1,object
arg2)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, arg1, arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 33373, 33612);
return return_v;
}


System.Globalization.CultureInfo
f_1366_33863_33891()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 33863, 33891);
return return_v;
}


string
f_1366_33849_33938(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 33849, 33938);
return return_v;
}


System.Globalization.CultureInfo
f_1366_34194_34222()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 34194, 34222);
return return_v;
}


string
f_1366_34180_34276(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 34180, 34276);
return return_v;
}


System.Globalization.CultureInfo
f_1366_34534_34562()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 34534, 34562);
return return_v;
}


string
f_1366_34520_34620(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 34520, 34620);
return return_v;
}


System.Globalization.CultureInfo
f_1366_36024_36052()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 36024, 36052);
return return_v;
}


string
f_1366_36174_36200(System.Management.Automation.ValidatePatternAttribute
this_param)
{
var return_v = this_param.RegexPattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 36174, 36200);
return return_v;
}


string
f_1366_36127_36201(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 36127, 36201);
return return_v;
}


string
f_1366_36010_36248(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 36010, 36248);
return return_v;
}


System.Globalization.CultureInfo
f_1366_36476_36504()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 36476, 36504);
return return_v;
}


int
f_1366_36556_36577(System.Management.Automation.ValidateCountAttribute
this_param)
{
var return_v = this_param.MinLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 36556, 36577);
return return_v;
}


int
f_1366_36579_36600(System.Management.Automation.ValidateCountAttribute
this_param)
{
var return_v = this_param.MaxLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 36579, 36600);
return return_v;
}


string
f_1366_36462_36601(System.Globalization.CultureInfo
provider,string
format,string
arg0,int
arg1,int
arg2)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 36462, 36601);
return return_v;
}


System.Globalization.CultureInfo
f_1366_36837_36865()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 36837, 36865);
return return_v;
}


string
f_1366_36823_36918(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 36823, 36918);
return return_v;
}


System.Globalization.CultureInfo
f_1366_37178_37206()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 37178, 37206);
return return_v;
}


string
f_1366_37164_37266(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 37164, 37266);
return return_v;
}


System.Text.StringBuilder
f_1366_37491_37522()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 37491, 37522);
return return_v;
}


System.Collections.Generic.IList<string>
f_1366_37617_37638(System.Management.Automation.ValidateSetAttribute
this_param)
{
var return_v = this_param.ValidValues;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 37617, 37638);
return return_v;
}


System.Globalization.CultureInfo
f_1366_37726_37754()
{
var return_v =                         CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 37726, 37754);
return return_v;
}


string
f_1366_37850_37908(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 37850, 37908);
return return_v;
}


System.Text.StringBuilder
f_1366_37680_37909(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 37680, 37909);
return return_v;
}


System.Collections.Generic.IList<string>
f_1366_37617_37638_I(System.Collections.Generic.IList<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 37617, 37638);
return return_v;
}


System.Globalization.CultureInfo
f_1366_38006_38034()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 38006, 38034);
return return_v;
}


string
f_1366_38084_38101(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 38084, 38101);
return return_v;
}


string
f_1366_37992_38128(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 37992, 38128);
return return_v;
}


System.Globalization.CultureInfo
f_1366_38691_38719()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 38691, 38719);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1366_38772_38796(System.Management.Automation.ValidateScriptAttribute
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 38772, 38796);
return return_v;
}


string
f_1366_38772_38807(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 38772, 38807);
return return_v;
}


string
f_1366_38677_38808(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 38677, 38808);
return return_v;
}


System.Globalization.CultureInfo
f_1366_39062_39090()
{
var return_v =                     CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 39062, 39090);
return return_v;
}


string
f_1366_39228_39255(System.Management.Automation.PSTypeNameAttribute
this_param)
{
var return_v = this_param.PSTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 39228, 39255);
return return_v;
}


string
f_1366_39181_39256(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 39181, 39256);
return return_v;
}


string
f_1366_39026_39257(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 39026, 39257);
return return_v;
}


bool
f_1366_39513_39535(System.ObsoleteAttribute
this_param)
{
var return_v = this_param.IsError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 39513, 39535);
return return_v;
}


string
f_1366_39647_39669(System.ObsoleteAttribute
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 39647, 39669);
return return_v;
}


string
f_1366_39600_39670(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 39600, 39670);
return return_v;
}


string
f_1366_39778_39800(System.ObsoleteAttribute
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 39778, 39800);
return return_v;
}


string
f_1366_39916_39938(System.ObsoleteAttribute
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 39916, 39938);
return return_v;
}


string
f_1366_39869_39939(string
value)
{
var return_v = CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 39869, 39939);
return return_v;
}


System.Globalization.CultureInfo
f_1366_40030_40058()
{
var return_v =                     CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 40030, 40058);
return return_v;
}


string
f_1366_39994_40158(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 39994, 40158);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,31783,40245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,31783,40245);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ParameterMetadata()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1366,11885,40274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,24986,25022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25054,25087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25119,25168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25200,25234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25266,25321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25353,25460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25492,25554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25586,25639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25671,25724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25756,25812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25844,25897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,25929,25973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26005,26054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26086,26149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26181,26218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26250,26301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26333,26392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26424,26468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26500,26538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,26570,26656);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1366,11885,40274);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,11885,40274);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1366,11885,40274);

static string
f_1366_12658_12662_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1366, 12600, 12691);
return return_v;
}


bool
f_1366_13188_13214(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 13188, 13214);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1366_13254_13300(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 13254, 13300);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_13420_13447()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 13420, 13447);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1366_13473_13497()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 13473, 13497);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
f_1366_13529_13575()
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 13529, 13575);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1366_14027_14074(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14027, 14074);
return return_v;
}


int
f_1366_14315_14335(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 14315, 14335);
return return_v;
}


System.Collections.Generic.List<string>
f_1366_14298_14336(int
capacity)
{
var return_v = new System.Collections.Generic.List<string>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14298, 14336);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1366_14275_14337(System.Collections.Generic.List<string>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14275, 14337);
return return_v;
}


int
f_1366_14425_14444(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14425, 14444);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1366_14377_14391_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14377, 14391);
return return_v;
}


int
f_1366_14779_14802(System.Collections.ObjectModel.Collection<System.Attribute>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 14779, 14802);
return return_v;
}


System.Collections.Generic.List<System.Attribute>
f_1366_14759_14803(int
capacity)
{
var return_v = new System.Collections.Generic.List<System.Attribute>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14759, 14803);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_14733_14804(System.Collections.Generic.List<System.Attribute>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>( (System.Collections.Generic.IList<System.Attribute>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14733, 14804);
return return_v;
}


int
f_1366_14914_14940(System.Collections.ObjectModel.Collection<System.Attribute>
this_param,System.Attribute
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14914, 14940);
return 0;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_14855_14872_I(System.Collections.ObjectModel.Collection<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 14855, 14872);
return return_v;
}


int
f_1366_15269_15295(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 15269, 15295);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
f_1366_15224_15296(int
capacity)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 15224, 15296);
return return_v;
}


System.Management.Automation.ParameterSetMetadata
f_1366_15468_15505(System.Management.Automation.ParameterSetMetadata
other)
{
var return_v = new System.Management.Automation.ParameterSetMetadata( other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 15468, 15505);
return return_v;
}


int
f_1366_15438_15506(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
this_param,string
key,System.Management.Automation.ParameterSetMetadata
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 15438, 15506);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
f_1366_15376_15396_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 15376, 15396);
return return_v;
}


int
f_1366_16046_16140(bool
condition,string
message)
{
Dbg.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 16046, 16140);
return 0;
}


int
f_1366_16157_16183(System.Management.Automation.ParameterMetadata
this_param,System.Management.Automation.CompiledCommandParameter
compiledParameterMD)
{
this_param.Initialize( compiledParameterMD);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 16157, 16183);
return 0;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1366_16757_16784()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 16757, 16784);
return return_v;
}

}
internal class InternalParameterMetadata
{
internal static InternalParameterMetadata Get(RuntimeDefinedParameterDictionary runtimeDefinedParameters,
                                                      bool processingDynamicParameters,
                                                      bool checkNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1366,41669,42248);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,41960,42117) || true) && (runtimeDefinedParameters == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,41960,42117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,42030,42102);

throw f_1366_42036_42101("runtimeDefinedParameter");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,41960,42117);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,42133,42237);

return f_1366_42140_42236(runtimeDefinedParameters, processingDynamicParameters, checkNames);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1366,41669,42248);

System.Management.Automation.PSArgumentNullException
f_1366_42036_42101(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 42036, 42101);
return return_v;
}


System.Management.Automation.InternalParameterMetadata
f_1366_42140_42236(System.Management.Automation.RuntimeDefinedParameterDictionary
runtimeDefinedParameters,bool
processingDynamicParameters,bool
checkNames)
{
var return_v = new System.Management.Automation.InternalParameterMetadata( runtimeDefinedParameters, processingDynamicParameters, checkNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 42140, 42236);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,41669,42248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,41669,42248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static InternalParameterMetadata Get(Type type, ExecutionContext context, bool processingDynamicParameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1366,43336,44090);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,43477,43595) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,43477,43595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,43527,43580);

throw f_1366_43533_43579("type");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,43477,43595);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,43611,43644);

InternalParameterMetadata 
result
=default(InternalParameterMetadata);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,43658,44049) || true) && (context == null ||(DynAbs.Tracing.TraceSender.Expression_False(1366, 43662, 43758)||!f_1366_43682_43758(s_parameterMetadataCache, f_1366_43719_43745(type), out result)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,43658,44049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,43792,43866);

result = f_1366_43801_43865(type, processingDynamicParameters);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,43886,44034) || true) && (context != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,43886,44034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,43947,44015);

f_1366_43947_44014(                    s_parameterMetadataCache, f_1366_43979_44005(type), result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,43886,44034);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,43658,44049);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,44065,44079);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1366,43336,44090);

System.Management.Automation.PSArgumentNullException
f_1366_43533_43579(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 43533, 43579);
return return_v;
}


string
f_1366_43719_43745(System.Type
this_param)
{
var return_v = this_param.AssemblyQualifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 43719, 43745);
return return_v;
}


bool
f_1366_43682_43758(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.InternalParameterMetadata>
this_param,string
key,out System.Management.Automation.InternalParameterMetadata
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 43682, 43758);
return return_v;
}


System.Management.Automation.InternalParameterMetadata
f_1366_43801_43865(System.Type
type,bool
processingDynamicParameters)
{
var return_v = new System.Management.Automation.InternalParameterMetadata( type, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 43801, 43865);
return return_v;
}


string
f_1366_43979_44005(System.Type
this_param)
{
var return_v = this_param.AssemblyQualifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 43979, 44005);
return return_v;
}


bool
f_1366_43947_44014(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.InternalParameterMetadata>
this_param,string
key,System.Management.Automation.InternalParameterMetadata
value)
{
var return_v = this_param.TryAdd( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 43947, 44014);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,43336,44090);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,43336,44090);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal InternalParameterMetadata(RuntimeDefinedParameterDictionary runtimeDefinedParameters, bool processingDynamicParameters, bool checkNames)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,45161,45640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,47034,47083);
this.TypeName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,47366,47548);
this.BindableParameters = f_1366_47465_47547(f_1366_47514_47546());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,47790,47971);
this.AliasedParameters = f_1366_47888_47970(f_1366_47937_47969());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,48251,48256);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,45331,45489) || true) && (runtimeDefinedParameters == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,45331,45489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,45401,45474);

throw f_1366_45407_45473("runtimeDefinedParameters");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,45331,45489);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,45505,45629);

f_1366_45505_45628(this, runtimeDefinedParameters, processingDynamicParameters, checkNames);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,45161,45640);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,45161,45640);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,45161,45640);
}
		}

internal InternalParameterMetadata(Type type, bool processingDynamicParameters)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1366,46509,46894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,47034,47083);
this.TypeName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,47366,47548);
this.BindableParameters = f_1366_47465_47547(f_1366_47514_47546());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,47790,47971);
this.AliasedParameters = f_1366_47888_47970(f_1366_47937_47969());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,48251,48256);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,46613,46731) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,46613,46731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,46663,46716);

throw f_1366_46669_46715("type");
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,46613,46731);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,46747,46760);

_type = type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,46774,46795);

TypeName = f_1366_46785_46794(type);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,46811,46883);

f_1366_46811_46882(this, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1366,46509,46894);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,46509,46894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,46509,46894);
}
		}

internal string TypeName {get; }

internal Dictionary<string, CompiledCommandParameter> BindableParameters {get; }

internal Dictionary<string, CompiledCommandParameter> AliasedParameters {get; }

private Type _type;

internal static readonly BindingFlags metaDataBindingFlags ;

private void ConstructCompiledParametersUsingRuntimeDefinedParameters(
            RuntimeDefinedParameterDictionary runtimeDefinedParameters,
            bool processingDynamicParameters,
            bool checkNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,49421,50688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,49666,49858);

f_1366_49666_49857(runtimeDefinedParameters != null, "This method should only be called when constructed with a valid runtime-defined parameter collection");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,49874,50677);
foreach(RuntimeDefinedParameter parameterDefinition in f_1366_49930_49961_I(f_1366_49930_49961(runtimeDefinedParameters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,49874,50677);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,50094,50472) || true) && (processingDynamicParameters)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,50094,50472);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,50371,50453) || true) && (parameterDefinition == null ||(DynAbs.Tracing.TraceSender.Expression_False(1366, 50375, 50438)||f_1366_50406_50438(parameterDefinition)))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,50371,50453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,50442,50451);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,50371,50453);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,50094,50472);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,50492,50608);

CompiledCommandParameter 
parameter = f_1366_50529_50607(parameterDefinition, processingDynamicParameters)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,50626,50662);

f_1366_50626_50661(this, parameter, checkNames);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,49874,50677);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,804);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,804);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1366,49421,50688);

int
f_1366_49666_49857(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 49666, 49857);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.RuntimeDefinedParameter>.ValueCollection
f_1366_49930_49961(System.Management.Automation.RuntimeDefinedParameterDictionary
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 49930, 49961);
return return_v;
}


bool
f_1366_50406_50438(System.Management.Automation.RuntimeDefinedParameter
this_param)
{
var return_v = this_param.IsDisabled();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 50406, 50438);
return return_v;
}


System.Management.Automation.CompiledCommandParameter
f_1366_50529_50607(System.Management.Automation.RuntimeDefinedParameter
runtimeDefinedParameter,bool
processingDynamicParameters)
{
var return_v = new System.Management.Automation.CompiledCommandParameter( runtimeDefinedParameter, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 50529, 50607);
return return_v;
}


int
f_1366_50626_50661(System.Management.Automation.InternalParameterMetadata
this_param,System.Management.Automation.CompiledCommandParameter
parameter,bool
checkNames)
{
this_param.AddParameter( parameter, checkNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 50626, 50661);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.RuntimeDefinedParameter>.ValueCollection
f_1366_49930_49961_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.RuntimeDefinedParameter>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 49930, 49961);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,49421,50688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,49421,50688);
}
		}

private void ConstructCompiledParametersUsingReflection(bool processingDynamicParameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,51212,52356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,51326,51463);

f_1366_51326_51462(_type != null, "This method should only be called when constructed with the Type");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,51529,51599);

PropertyInfo[] 
properties = f_1366_51557_51598(_type, metaDataBindingFlags)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,51613,51672);

FieldInfo[] 
fields = f_1366_51634_51671(_type, metaDataBindingFlags)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,51688,52018);
foreach(PropertyInfo property in f_1366_51722_51732_I(properties) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,51688,52018);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,51828,51931) || true) && (!f_1366_51833_51861(property))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,51828,51931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,51903,51912);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,51828,51931);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,51951,52003);

f_1366_51951_52002(this, property, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,51688,52018);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,331);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,331);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,52034,52345);
foreach(FieldInfo field in f_1366_52062_52068_I(fields) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,52034,52345);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,52161,52261) || true) && (!f_1366_52166_52191(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,52161,52261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,52233,52242);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,52161,52261);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,52281,52330);

f_1366_52281_52329(this, field, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,52034,52345);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,312);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,312);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1366,51212,52356);

int
f_1366_51326_51462(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 51326, 51462);
return 0;
}


System.Reflection.PropertyInfo[]
f_1366_51557_51598(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetProperties( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 51557, 51598);
return return_v;
}


System.Reflection.FieldInfo[]
f_1366_51634_51671(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetFields( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 51634, 51671);
return return_v;
}


bool
f_1366_51833_51861(System.Reflection.PropertyInfo
member)
{
var return_v = IsMemberAParameter( (System.Reflection.MemberInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 51833, 51861);
return return_v;
}


int
f_1366_51951_52002(System.Management.Automation.InternalParameterMetadata
this_param,System.Reflection.PropertyInfo
member,bool
processingDynamicParameters)
{
this_param.AddParameter( (System.Reflection.MemberInfo)member, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 51951, 52002);
return 0;
}


System.Reflection.PropertyInfo[]
f_1366_51722_51732_I(System.Reflection.PropertyInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 51722, 51732);
return return_v;
}


bool
f_1366_52166_52191(System.Reflection.FieldInfo
member)
{
var return_v = IsMemberAParameter( (System.Reflection.MemberInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 52166, 52191);
return return_v;
}


int
f_1366_52281_52329(System.Management.Automation.InternalParameterMetadata
this_param,System.Reflection.FieldInfo
member,bool
processingDynamicParameters)
{
this_param.AddParameter( (System.Reflection.MemberInfo)member, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 52281, 52329);
return 0;
}


System.Reflection.FieldInfo[]
f_1366_52062_52068_I(System.Reflection.FieldInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 52062, 52068);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,51212,52356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,51212,52356);
}
		}

private void CheckForReservedParameter(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,52368,52899);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,52444,52888) || true) && (f_1366_52448_52513(name, "SelectProperty", StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1366, 52448, 52614)||f_1366_52551_52614(                name, "SelectObject", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,52444,52888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,52648,52873);

throw f_1366_52654_52872("ReservedParameterName", null, f_1366_52795_52836(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,52444,52888);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,52368,52899);

bool
f_1366_52448_52513(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 52448, 52513);
return return_v;
}


bool
f_1366_52551_52614(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 52551, 52614);
return return_v;
}


string
f_1366_52795_52836()
{
var return_v =                             DiscoveryExceptions.ReservedParameterName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 52795, 52836);
return return_v;
}


System.Management.Automation.MetadataException
f_1366_52654_52872(string
errorId,System.Exception
innerException,string
resourceStr,params object[]
arguments)
{
var return_v = new System.Management.Automation.MetadataException( errorId, innerException, resourceStr, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 52654, 52872);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,52368,52899);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,52368,52899);
}
		}

private void AddParameter(MemberInfo member, bool processingDynamicParameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,53166,55153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53269,53288);

bool 
error = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53302,53327);

bool 
useExisting = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53343,53382);

f_1366_53343_53381(this, f_1366_53369_53380(member));
{try {
do // false loop

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,53398,54493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53447,53490);

CompiledCommandParameter 
existingParameter
=default(CompiledCommandParameter);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53508,53646) || true) && (!f_1366_53513_53579(f_1366_53513_53531(), f_1366_53544_53555(member), out existingParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,53508,53646);
DynAbs.Tracing.TraceSender.TraceBreak(1366,53621,53627);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,53508,53646);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53666,53732);

Type 
existingParamDeclaringType = f_1366_53700_53731(existingParameter)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53752,53892) || true) && (existingParamDeclaringType == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,53752,53892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53832,53845);

error = true;
DynAbs.Tracing.TraceSender.TraceBreak(1366,53867,53873);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,53752,53892);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53912,54085) || true) && (f_1366_53916_53977(existingParamDeclaringType, f_1366_53956_53976(member)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,53912,54085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54019,54038);

useExisting = true;
DynAbs.Tracing.TraceSender.TraceBreak(1366,54060,54066);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,53912,54085);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54105,54430) || true) && (f_1366_54109_54170(f_1366_54109_54129(member), existingParamDeclaringType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,54105,54430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54348,54383);

f_1366_54348_54382(this, existingParameter);
DynAbs.Tracing.TraceSender.TraceBreak(1366,54405,54411);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,54105,54430);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54450,54463);

error = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,53398,54493);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,53398,54493) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,53398,54493);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,53398,54493);
}}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54509,54910) || true) && (error)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,54509,54910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54678,54895);

throw f_1366_54684_54894("DuplicateParameterDefinition", null, f_1366_54808_54859(), f_1366_54882_54893(member));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,54509,54910);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54926,55142) || true) && (!useExisting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,54926,55142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,54976,55079);

CompiledCommandParameter 
parameter = f_1366_55013_55078(member, processingDynamicParameters)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55097,55127);

f_1366_55097_55126(this, parameter, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,54926,55142);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1366,53166,55153);

string
f_1366_53369_53380(System.Reflection.MemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 53369, 53380);
return return_v;
}


int
f_1366_53343_53381(System.Management.Automation.InternalParameterMetadata
this_param,string
name)
{
this_param.CheckForReservedParameter( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 53343, 53381);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_53513_53531()
{
var return_v = BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 53513, 53531);
return return_v;
}


string
f_1366_53544_53555(System.Reflection.MemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 53544, 53555);
return return_v;
}


bool
f_1366_53513_53579(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
this_param,string
key,out System.Management.Automation.CompiledCommandParameter
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 53513, 53579);
return return_v;
}


System.Type
f_1366_53700_53731(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.DeclaringType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 53700, 53731);
return return_v;
}


System.Type
f_1366_53956_53976(System.Reflection.MemberInfo
this_param)
{
var return_v = this_param.DeclaringType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 53956, 53976);
return return_v;
}


bool
f_1366_53916_53977(System.Type
this_param,System.Type
c)
{
var return_v = this_param.IsSubclassOf( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 53916, 53977);
return return_v;
}


System.Type
f_1366_54109_54129(System.Reflection.MemberInfo
this_param)
{
var return_v = this_param.DeclaringType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 54109, 54129);
return return_v;
}


bool
f_1366_54109_54170(System.Type
this_param,System.Type
c)
{
var return_v = this_param.IsSubclassOf( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 54109, 54170);
return return_v;
}


int
f_1366_54348_54382(System.Management.Automation.InternalParameterMetadata
this_param,System.Management.Automation.CompiledCommandParameter
parameter)
{
this_param.RemoveParameter( parameter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 54348, 54382);
return 0;
}


string
f_1366_54808_54859()
{
var return_v =                     ParameterBinderStrings.DuplicateParameterDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 54808, 54859);
return return_v;
}


string
f_1366_54882_54893(System.Reflection.MemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 54882, 54893);
return return_v;
}


System.Management.Automation.MetadataException
f_1366_54684_54894(string
errorId,System.Exception
innerException,string
resourceStr,params object[]
arguments)
{
var return_v = new System.Management.Automation.MetadataException( errorId, innerException, resourceStr, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 54684, 54894);
return return_v;
}


System.Management.Automation.CompiledCommandParameter
f_1366_55013_55078(System.Reflection.MemberInfo
member,bool
processingDynamicParameters)
{
var return_v = new System.Management.Automation.CompiledCommandParameter( member, processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55013, 55078);
return return_v;
}


int
f_1366_55097_55126(System.Management.Automation.InternalParameterMetadata
this_param,System.Management.Automation.CompiledCommandParameter
parameter,bool
checkNames)
{
this_param.AddParameter( parameter, checkNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55097, 55126);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,53166,55153);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,53166,55153);
}
		}

private void AddParameter(CompiledCommandParameter parameter, bool checkNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,55165,56041);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55268,55373) || true) && (checkNames)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,55268,55373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55316,55358);

f_1366_55316_55357(this, f_1366_55342_55356(parameter));
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,55268,55373);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55389,55439);

f_1366_55389_55438(f_1366_55389_55407(), f_1366_55412_55426(parameter), parameter);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55542,56030);
foreach(string alias in f_1366_55567_55584_I(f_1366_55567_55584(parameter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,55542,56030);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55618,55955) || true) && (f_1366_55622_55658(f_1366_55622_55639(), alias))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,55618,55955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55700,55936);

throw f_1366_55706_55935("AliasDeclaredMultipleTimes", null, f_1366_55852_55898(), alias);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,55618,55955);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,55975,56015);

f_1366_55975_56014(f_1366_55975_55992(), alias, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,55542,56030);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,489);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,489);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1366,55165,56041);

string
f_1366_55342_55356(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 55342, 55356);
return return_v;
}


int
f_1366_55316_55357(System.Management.Automation.InternalParameterMetadata
this_param,string
name)
{
this_param.CheckForReservedParameter( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55316, 55357);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_55389_55407()
{
var return_v = BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 55389, 55407);
return return_v;
}


string
f_1366_55412_55426(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 55412, 55426);
return return_v;
}


int
f_1366_55389_55438(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
this_param,string
key,System.Management.Automation.CompiledCommandParameter
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55389, 55438);
return 0;
}


string[]
f_1366_55567_55584(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Aliases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 55567, 55584);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_55622_55639()
{
var return_v = AliasedParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 55622, 55639);
return return_v;
}


bool
f_1366_55622_55658(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55622, 55658);
return return_v;
}


string
f_1366_55852_55898()
{
var return_v =                             DiscoveryExceptions.AliasDeclaredMultipleTimes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 55852, 55898);
return return_v;
}


System.Management.Automation.MetadataException
f_1366_55706_55935(string
errorId,System.Exception
innerException,string
resourceStr,params object[]
arguments)
{
var return_v = new System.Management.Automation.MetadataException( errorId, innerException, resourceStr, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55706, 55935);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_55975_55992()
{
var return_v = AliasedParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 55975, 55992);
return return_v;
}


int
f_1366_55975_56014(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
this_param,string
key,System.Management.Automation.CompiledCommandParameter
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55975, 56014);
return 0;
}


string[]
f_1366_55567_55584_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 55567, 55584);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,55165,56041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,55165,56041);
}
		}

private void RemoveParameter(CompiledCommandParameter parameter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1366,56053,56421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,56142,56184);

f_1366_56142_56183(f_1366_56142_56160(), f_1366_56168_56182(parameter));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,56287,56410);
foreach(string alias in f_1366_56312_56329_I(f_1366_56312_56329(parameter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,56287,56410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,56363,56395);

f_1366_56363_56394(f_1366_56363_56380(), alias);
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,56287,56410);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,124);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,124);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1366,56053,56421);

System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_56142_56160()
{
var return_v = BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 56142, 56160);
return return_v;
}


string
f_1366_56168_56182(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 56168, 56182);
return return_v;
}


bool
f_1366_56142_56183(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 56142, 56183);
return return_v;
}


string[]
f_1366_56312_56329(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Aliases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 56312, 56329);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_56363_56380()
{
var return_v = AliasedParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 56363, 56380);
return return_v;
}


bool
f_1366_56363_56394(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
this_param,string
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 56363, 56394);
return return_v;
}


string[]
f_1366_56312_56329_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 56312, 56329);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,56053,56421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,56053,56421);
}
		}

private static bool IsMemberAParameter(MemberInfo member)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1366,56990,58586);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57108,57210);

var 
expAttribute = f_1366_57127_57209(f_1366_57127_57192(member, inherit: false))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57228,57294) || true) && (expAttribute != null &&(DynAbs.Tracing.TraceSender.Expression_True(1366, 57232, 57275)&&f_1366_57256_57275(expAttribute)))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,57228,57294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57279,57292);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,57228,57294);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57314,57355);

var 
hasAnyVisibleParamAttributes = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57373,57458);

var 
paramAttributes = f_1366_57395_57457(member, inherit: false)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57476,57750);
foreach(var paramAttribute in f_1366_57507_57522_I(paramAttributes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,57476,57750);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57564,57731) || true) && (f_1366_57568_57590_M(!paramAttribute.ToHide))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1366,57564,57731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57640,57676);

hasAnyVisibleParamAttributes = true;
DynAbs.Tracing.TraceSender.TraceBreak(1366,57702,57708);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,57564,57731);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1366,57476,57750);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1366,1,275);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1366,1,275);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57770,57806);

return hasAnyVisibleParamAttributes;
            }
            catch (MetadataException metadataException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1366,57835,58198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,57911,58183);

throw f_1366_57917_58182("GetCustomAttributesMetadataException", metadataException, f_1366_58062_58099(), f_1366_58122_58133(member), f_1366_58156_58181(metadataException));
DynAbs.Tracing.TraceSender.TraceExitCatch(1366,57835,58198);
            }
            catch (ArgumentException argumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1366,58212,58575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,58288,58560);

throw f_1366_58294_58559("GetCustomAttributesArgumentException", argumentException, f_1366_58439_58476(), f_1366_58499_58510(member), f_1366_58533_58558(argumentException));
DynAbs.Tracing.TraceSender.TraceExitCatch(1366,58212,58575);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1366,56990,58586);

System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalAttribute>
f_1366_57127_57192(System.Reflection.MemberInfo
element,bool
inherit)
{
var return_v = element.GetCustomAttributes<System.Management.Automation.ExperimentalAttribute>( inherit: inherit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 57127, 57192);
return return_v;
}


System.Management.Automation.ExperimentalAttribute
f_1366_57127_57209(System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalAttribute>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.ExperimentalAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 57127, 57209);
return return_v;
}


bool
f_1366_57256_57275(System.Management.Automation.ExperimentalAttribute
this_param)
{
var return_v = this_param.ToHide;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 57256, 57275);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterAttribute>
f_1366_57395_57457(System.Reflection.MemberInfo
element,bool
inherit)
{
var return_v = element.GetCustomAttributes<System.Management.Automation.ParameterAttribute>( inherit: inherit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 57395, 57457);
return return_v;
}


bool
f_1366_57568_57590_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 57568, 57590);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterAttribute>
f_1366_57507_57522_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterAttribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 57507, 57522);
return return_v;
}


string
f_1366_58062_58099()
{
var return_v =                     Metadata.MetadataMemberInitialization;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 58062, 58099);
return return_v;
}


string
f_1366_58122_58133(System.Reflection.MemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 58122, 58133);
return return_v;
}


string
f_1366_58156_58181(System.Management.Automation.MetadataException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 58156, 58181);
return return_v;
}


System.Management.Automation.MetadataException
f_1366_57917_58182(string
errorId,System.Management.Automation.MetadataException
innerException,string
resourceStr,params object[]
arguments)
{
var return_v = new System.Management.Automation.MetadataException( errorId, (System.Exception)innerException, resourceStr, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 57917, 58182);
return return_v;
}


string
f_1366_58439_58476()
{
var return_v =                     Metadata.MetadataMemberInitialization;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 58439, 58476);
return return_v;
}


string
f_1366_58499_58510(System.Reflection.MemberInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 58499, 58510);
return return_v;
}


string
f_1366_58533_58558(System.ArgumentException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 58533, 58558);
return return_v;
}


System.Management.Automation.MetadataException
f_1366_58294_58559(string
errorId,System.ArgumentException
innerException,string
resourceStr,params object[]
arguments)
{
var return_v = new System.Management.Automation.MetadataException( errorId, (System.Exception)innerException, resourceStr, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 58294, 58559);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1366,56990,58586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,56990,58586);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static System.Collections.Concurrent.ConcurrentDictionary<string, InternalParameterMetadata> s_parameterMetadataCache ;

static InternalParameterMetadata()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1366,40376,59198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,48441,48567);
metaDataBindingFlags = (BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1366,59000,59153);
s_parameterMetadataCache = f_1366_59040_59153(f_1366_59130_59152());DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1366,40376,59198);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1366,40376,59198);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1366,40376,59198);

System.Management.Automation.PSArgumentNullException
f_1366_45407_45473(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 45407, 45473);
return return_v;
}


int
f_1366_45505_45628(System.Management.Automation.InternalParameterMetadata
this_param,System.Management.Automation.RuntimeDefinedParameterDictionary
runtimeDefinedParameters,bool
processingDynamicParameters,bool
checkNames)
{
this_param.ConstructCompiledParametersUsingRuntimeDefinedParameters( runtimeDefinedParameters, processingDynamicParameters, checkNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 45505, 45628);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1366_46669_46715(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 46669, 46715);
return return_v;
}


string
f_1366_46785_46794(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 46785, 46794);
return return_v;
}


int
f_1366_46811_46882(System.Management.Automation.InternalParameterMetadata
this_param,bool
processingDynamicParameters)
{
this_param.ConstructCompiledParametersUsingReflection( processingDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 46811, 46882);
return 0;
}


System.StringComparer
f_1366_47514_47546()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 47514, 47546);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_47465_47547(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 47465, 47547);
return return_v;
}


System.StringComparer
f_1366_47937_47969()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 47937, 47969);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
f_1366_47888_47970(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 47888, 47970);
return return_v;
}


static System.StringComparer
f_1366_59130_59152()
{
var return_v = StringComparer.Ordinal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1366, 59130, 59152);
return return_v;
}


static System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.InternalParameterMetadata>
f_1366_59040_59153(System.StringComparer
comparer)
{
var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.InternalParameterMetadata>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1366, 59040, 59153);
return return_v;
}

}
}

