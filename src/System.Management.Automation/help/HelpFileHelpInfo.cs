// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;

namespace System.Management.Automation
{
internal class HelpFileHelpInfo : HelpInfo
{
private HelpFileHelpInfo(string name, string text, string filename)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1153,906,1542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1689,1743);
this.Name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1770,1794);
this._filename = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1820,1844);
this._synopsis = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,2632,2676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,998,1035);

FullHelp = f_1153_1009_1034(text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1051,1063);

Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1207,1236);

_synopsis = f_1153_1219_1235(text, 5);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1250,1494) || true) && (_synopsis != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1153,1250,1494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1305,1334);

_synopsis = f_1153_1317_1333(_synopsis);
DynAbs.Tracing.TraceSender.TraceExitCondition(1153,1250,1494);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1153,1250,1494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1454,1479);

_synopsis = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1153,1250,1494);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,1510,1531);

_filename = filename;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1153,906,1542);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1153,906,1542);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1153,906,1542);
}
		}

internal override string Name {get; }

private string _filename ;

private string _synopsis ;

internal override string Synopsis
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1153,2056,2124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,2092,2109);

return _synopsis;
DynAbs.Tracing.TraceSender.TraceExitMethod(1153,2056,2124);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1153,1998,2135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1153,1998,2135);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1153,2368,2448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,2404,2433);

return HelpCategory.HelpFile;
DynAbs.Tracing.TraceSender.TraceExitMethod(1153,2368,2448);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1153,2300,2459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1153,2300,2459);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override PSObject FullHelp {get; }

internal static HelpFileHelpInfo GetHelpInfo(string name, string text, string filename)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1153,3082,3554);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3194,3255) || true) && (f_1153_3198_3224(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1153,3194,3255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3243,3255);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1153,3194,3255);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3271,3350);

HelpFileHelpInfo 
helpfileHelpInfo = f_1153_3307_3349(name, text, filename)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3366,3444) || true) && (f_1153_3370_3413(f_1153_3391_3412(helpfileHelpInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1153,3366,3444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3432,3444);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1153,3366,3444);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3460,3503);

f_1153_3460_3502(
            helpfileHelpInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3519,3543);

return helpfileHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1153,3082,3554);

bool
f_1153_3198_3224(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 3198, 3224);
return return_v;
}


System.Management.Automation.HelpFileHelpInfo
f_1153_3307_3349(string
name,string
text,string
filename)
{
var return_v = new System.Management.Automation.HelpFileHelpInfo( name, text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 3307, 3349);
return return_v;
}


string
f_1153_3391_3412(System.Management.Automation.HelpFileHelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1153, 3391, 3412);
return return_v;
}


bool
f_1153_3370_3413(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 3370, 3413);
return return_v;
}


int
f_1153_3460_3502(System.Management.Automation.HelpFileHelpInfo
this_param)
{
this_param.AddCommonHelpProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 3460, 3502);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1153,3082,3554);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1153,3082,3554);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetLine(string text, int line)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1153,3883,4277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,3960,4005);

StringReader 
reader = f_1153_3982_4004(text)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4021,4042);

string 
result = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4067,4072);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4058,4236) || true) && (i < line)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4084,4087)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1153,4058,4236))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1153,4058,4236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4121,4148);

result = f_1153_4130_4147(reader);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4168,4221) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1153,4168,4221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4209,4221);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1153,4168,4221);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1153,1,179);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1153,1,179);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4252,4266);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1153,3883,4277);

System.IO.StringReader
f_1153_3982_4004(string
s)
{
var return_v = new System.IO.StringReader( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 3982, 4004);
return return_v;
}


string?
f_1153_4130_4147(System.IO.StringReader
this_param)
{
var return_v = this_param.ReadLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 4130, 4147);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1153,3883,4277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1153,3883,4277);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool MatchPatternInContent(WildcardPattern pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1153,4289,4638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4383,4446);

f_1153_4383_4445(pattern != null, "pattern cannot be null.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4462,4496);

string 
helpContent = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4510,4577);

f_1153_4510_4576(f_1153_4550_4558(), out helpContent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1153,4591,4627);

return f_1153_4598_4626(pattern, helpContent);
DynAbs.Tracing.TraceSender.TraceExitMethod(1153,4289,4638);

int
f_1153_4383_4445(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 4383, 4445);
return 0;
}


System.Management.Automation.PSObject
f_1153_4550_4558()
{
var return_v = FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1153, 4550, 4558);
return return_v;
}


bool
f_1153_4510_4576(System.Management.Automation.PSObject
valueToConvert,out string
result)
{
var return_v = LanguagePrimitives.TryConvertTo<string>( (object)valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 4510, 4576);
return return_v;
}


bool
f_1153_4598_4626(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 4598, 4626);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1153,4289,4638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1153,4289,4638);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static HelpFileHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1153,320,4645);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1153,320,4645);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1153,320,4645);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1153,320,4645);

System.Management.Automation.PSObject
f_1153_1009_1034(string
obj)
{
var return_v = PSObject.AsPSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 1009, 1034);
return return_v;
}


string
f_1153_1219_1235(string
text,int
line)
{
var return_v = GetLine( text, line);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 1219, 1235);
return return_v;
}


string
f_1153_1317_1333(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1153, 1317, 1333);
return return_v;
}

}
}
