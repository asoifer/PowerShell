// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
internal class SyntaxHelpInfo : BaseCommandHelpInfo
{
private SyntaxHelpInfo(string name, string text, HelpCategory category)
:base(f_1176_552_560_C(category) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1176,460,690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,837,891);
this.Name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,1046,1104);
this.Synopsis = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,1277,1321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,586,623);

FullHelp = f_1176_597_622(text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,637,649);

Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,663,679);

Synopsis = text;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1176,460,690);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1176,460,690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1176,460,690);
}
		}

internal override string Name {get; }

internal override string Synopsis {get; }

internal override PSObject FullHelp {get; }

internal static SyntaxHelpInfo GetHelpInfo(string name, string text, HelpCategory category)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1176,1701,2165);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,1817,1878) || true) && (f_1176_1821_1847(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1176,1817,1878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,1866,1878);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1176,1817,1878);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,1894,1967);

SyntaxHelpInfo 
syntaxHelpInfo = f_1176_1926_1966(name, text, category)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,1983,2059) || true) && (f_1176_1987_2028(f_1176_2008_2027(syntaxHelpInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1176,1983,2059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,2047,2059);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1176,1983,2059);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,2075,2116);

f_1176_2075_2115(
            syntaxHelpInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1176,2132,2154);

return syntaxHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1176,1701,2165);

bool
f_1176_1821_1847(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1176, 1821, 1847);
return return_v;
}


System.Management.Automation.SyntaxHelpInfo
f_1176_1926_1966(string
name,string
text,System.Management.Automation.HelpCategory
category)
{
var return_v = new System.Management.Automation.SyntaxHelpInfo( name, text, category);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1176, 1926, 1966);
return return_v;
}


string
f_1176_2008_2027(System.Management.Automation.SyntaxHelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1176, 2008, 2027);
return return_v;
}


bool
f_1176_1987_2028(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1176, 1987, 2028);
return return_v;
}


int
f_1176_2075_2115(System.Management.Automation.SyntaxHelpInfo
this_param)
{
this_param.AddCommonHelpProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1176, 2075, 2115);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1176,1701,2165);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1176,1701,2165);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SyntaxHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1176,300,2172);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1176,300,2172);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1176,300,2172);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1176,300,2172);

System.Management.Automation.PSObject
f_1176_597_622(string
obj)
{
var return_v = PSObject.AsPSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1176, 597, 622);
return return_v;
}


static System.Management.Automation.HelpCategory
f_1176_552_560_C(System.Management.Automation.HelpCategory
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1176, 460, 690);
return return_v;
}

}
}
