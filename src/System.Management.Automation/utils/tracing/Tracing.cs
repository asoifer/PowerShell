// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text;

namespace System.Management.Automation.Tracing
{
public sealed partial class Tracer : System.Management.Automation.Tracing.EtwActivity
{
[EtwEvent(0xc000)]
        public void DebugMessage(Exception exception)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1059,420,636);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,518,565) || true) && (exception == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1059,518,565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,558,565);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1059,518,565);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,581,625);

f_1059_581_624(this, f_1059_594_623(exception));
DynAbs.Tracing.TraceSender.TraceExitMethod(1059,420,636);

string
f_1059_594_623(System.Exception
exception)
{
var return_v = GetExceptionString( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 594, 623);
return return_v;
}


int
f_1059_581_624(System.Management.Automation.Tracing.Tracer
this_param,string
message)
{
this_param.DebugMessage( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 581, 624);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1059,420,636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1059,420,636);
}
		}

public static string GetExceptionString(Exception exception)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1059,828,1216);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,913,973) || true) && (exception == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1059,913,973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,953,973);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1059,913,973);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,989,1028);

StringBuilder 
sb = f_1059_1008_1027()
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1042,1168) || true) && (f_1059_1049_1082(sb, exception))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1059,1042,1168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1116,1153);

exception = f_1059_1128_1152(exception);
DynAbs.Tracing.TraceSender.TraceExitCondition(1059,1042,1168);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1059,1042,1168);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1059,1042,1168);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1184,1205);

return f_1059_1191_1204(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1059,828,1216);

System.Text.StringBuilder
f_1059_1008_1027()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1008, 1027);
return return_v;
}


bool
f_1059_1049_1082(System.Text.StringBuilder
sb,System.Exception
e)
{
var return_v = WriteExceptionText( sb, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1049, 1082);
return return_v;
}


System.Exception
f_1059_1128_1152(System.Exception
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1059, 1128, 1152);
return return_v;
}


string
f_1059_1191_1204(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1191, 1204);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1059,828,1216);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1059,828,1216);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool WriteExceptionText(StringBuilder sb, Exception e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1059,1228,1575);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1322,1367) || true) && (e == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1059,1322,1367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1354,1367);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1059,1322,1367);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1383,1411);

f_1059_1383_1410(
            sb, f_1059_1393_1409(f_1059_1393_1404(e)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1425,1456);

f_1059_1425_1455(            sb, f_1059_1435_1454());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1470,1491);

f_1059_1470_1490(            sb, f_1059_1480_1489(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1505,1536);

f_1059_1505_1535(            sb, f_1059_1515_1534());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1059,1552,1564);

return true;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1059,1228,1575);

System.Type
f_1059_1393_1404(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1393, 1404);
return return_v;
}


string
f_1059_1393_1409(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1059, 1393, 1409);
return return_v;
}


System.Text.StringBuilder
f_1059_1383_1410(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1383, 1410);
return return_v;
}


string
f_1059_1435_1454()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1059, 1435, 1454);
return return_v;
}


System.Text.StringBuilder
f_1059_1425_1455(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1425, 1455);
return return_v;
}


string
f_1059_1480_1489(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1059, 1480, 1489);
return return_v;
}


System.Text.StringBuilder
f_1059_1470_1490(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1470, 1490);
return return_v;
}


string
f_1059_1515_1534()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1059, 1515, 1534);
return return_v;
}


System.Text.StringBuilder
f_1059_1505_1535(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1059, 1505, 1535);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1059,1228,1575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1059,1228,1575);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1059,244,1582);
}
}

