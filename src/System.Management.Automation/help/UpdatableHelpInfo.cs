// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Text;

namespace System.Management.Automation.Help
{
internal class CultureSpecificUpdatableHelp
{
internal CultureSpecificUpdatableHelp(CultureInfo culture, Version version)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1178,651,902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,991,1029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,1120,1162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,751,781);

f_1178_751_780(version != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,795,825);

f_1178_795_824(culture != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,841,859);

Culture = culture;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,873,891);

Version = version;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1178,651,902);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1178,651,902);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,651,902);
}
		}

internal Version Version {get; set; }

internal CultureInfo Culture {get; set; }

static CultureSpecificUpdatableHelp()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1178,398,1169);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1178,398,1169);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,398,1169);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1178,398,1169);

int
f_1178_751_780(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 751, 780);
return 0;
}


int
f_1178_795_824(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 795, 824);
return 0;
}

}
internal class UpdatableHelpInfo
{
internal UpdatableHelpInfo(string unresolvedUri, CultureSpecificUpdatableHelp[] cultures)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1178,1547,1869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,1957,1995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,2100,2171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,2266,2333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,1661,1692);

f_1178_1661_1691(cultures != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,1708,1738);

UnresolvedUri = unresolvedUri;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,1752,1814);

HelpContentUriCollection = f_1178_1779_1813();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,1828,1858);

UpdatableHelpItems = cultures;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1178,1547,1869);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1178,1547,1869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,1547,1869);
}
		}

internal string UnresolvedUri {get; }

internal Collection<UpdatableHelpUri> HelpContentUriCollection {get; }

internal CultureSpecificUpdatableHelp[] UpdatableHelpItems {get; }

internal bool IsNewerVersion(UpdatableHelpInfo helpInfo, CultureInfo culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1178,2669,3097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,2771,2802);

f_1178_2771_2801(helpInfo != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,2818,2867);

Version 
v1 = f_1178_2831_2866(helpInfo, culture)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,2881,2921);

Version 
v2 = f_1178_2894_2920(this, culture)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,2937,2962);

f_1178_2937_2961(v1 != null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,2978,3053) || true) && (v2 == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,2978,3053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3026,3038);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1178,2978,3053);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3069,3084);

return v1 > v2;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3085,3086);
;
DynAbs.Tracing.TraceSender.TraceExitMethod(1178,2669,3097);

int
f_1178_2771_2801(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 2771, 2801);
return 0;
}


System.Version
f_1178_2831_2866(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 2831, 2866);
return return_v;
}


System.Version
f_1178_2894_2920(System.Management.Automation.Help.UpdatableHelpInfo
this_param,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetCultureVersion( culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 2894, 2920);
return return_v;
}


int
f_1178_2937_2961(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 2937, 2961);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1178,2669,3097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,2669,3097);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsCultureSupported(CultureInfo culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1178,3329,3818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3407,3437);

f_1178_3407_3436(culture != null);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3453,3778);
foreach(CultureSpecificUpdatableHelp updatableHelpItem in f_1178_3512_3530_I(f_1178_3512_3530()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,3453,3778);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3564,3763) || true) && (f_1178_3568_3685(f_1178_3583_3613(f_1178_3583_3608(updatableHelpItem)), f_1178_3615_3627(culture), StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,3564,3763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3732,3744);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1178,3564,3763);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1178,3453,3778);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1178,1,326);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1178,1,326);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,3794,3807);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1178,3329,3818);

int
f_1178_3407_3436(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 3407, 3436);
return 0;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_3512_3530()
{
var return_v = UpdatableHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 3512, 3530);
return return_v;
}


System.Globalization.CultureInfo
f_1178_3583_3608(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 3583, 3608);
return return_v;
}


string
f_1178_3583_3613(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 3583, 3613);
return return_v;
}


string
f_1178_3615_3627(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 3615, 3627);
return return_v;
}


int
f_1178_3568_3685(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 3568, 3685);
return return_v;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_3512_3530_I(System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 3512, 3530);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1178,3329,3818);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,3329,3818);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetSupportedCultures()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1178,4008,4606);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4071,4204) || true) && (f_1178_4075_4100(f_1178_4075_4093())== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,4071,4204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4139,4189);

return f_1178_4146_4188(f_1178_4164_4187());
DynAbs.Tracing.TraceSender.TraceExitCondition(1178,4071,4204);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4220,4259);

StringBuilder 
sb = f_1178_4239_4258()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4284,4289);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4275,4558) || true) && (i < f_1178_4295_4320(f_1178_4295_4313()))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4322,4325)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1178,4275,4558))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,4275,4558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4359,4405);

f_1178_4359_4404(                sb, f_1178_4369_4403(f_1178_4369_4398(f_1178_4369_4387()[i])));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4425,4543) || true) && (i != (f_1178_4435_4460(f_1178_4435_4453())- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,4425,4543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4507,4524);

f_1178_4507_4523(                    sb, " | ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1178,4425,4543);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1178,1,284);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1178,1,284);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4574,4595);

return f_1178_4581_4594(sb);
DynAbs.Tracing.TraceSender.TraceExitMethod(1178,4008,4606);

System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_4075_4093()
{
var return_v = UpdatableHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4075, 4093);
return return_v;
}


int
f_1178_4075_4100(System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4075, 4100);
return return_v;
}


string
f_1178_4164_4187()
{
var return_v = HelpDisplayStrings.None;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4164, 4187);
return return_v;
}


string
f_1178_4146_4188(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 4146, 4188);
return return_v;
}


System.Text.StringBuilder
f_1178_4239_4258()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 4239, 4258);
return return_v;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_4295_4313()
{
var return_v = UpdatableHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4295, 4313);
return return_v;
}


int
f_1178_4295_4320(System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4295, 4320);
return return_v;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_4369_4387()
{
var return_v = UpdatableHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4369, 4387);
return return_v;
}


System.Globalization.CultureInfo
f_1178_4369_4398(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4369, 4398);
return return_v;
}


string
f_1178_4369_4403(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4369, 4403);
return return_v;
}


System.Text.StringBuilder
f_1178_4359_4404(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 4359, 4404);
return return_v;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_4435_4453()
{
var return_v = UpdatableHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4435, 4453);
return return_v;
}


int
f_1178_4435_4460(System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4435, 4460);
return return_v;
}


System.Text.StringBuilder
f_1178_4507_4523(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 4507, 4523);
return return_v;
}


string
f_1178_4581_4594(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 4581, 4594);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1178,4008,4606);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,4008,4606);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Version GetCultureVersion(CultureInfo culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1178,4810,5275);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,4890,5236);
foreach(CultureSpecificUpdatableHelp updatableHelpItem in f_1178_4949_4967_I(f_1178_4949_4967()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,4890,5236);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,5001,5221) || true) && (f_1178_5005_5122(f_1178_5020_5050(f_1178_5020_5045(updatableHelpItem)), f_1178_5052_5064(culture), StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1178,5001,5221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,5169,5202);

return f_1178_5176_5201(updatableHelpItem);
DynAbs.Tracing.TraceSender.TraceExitCondition(1178,5001,5221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1178,4890,5236);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1178,1,347);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1178,1,347);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1178,5252,5264);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1178,4810,5275);

System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_4949_4967()
{
var return_v = UpdatableHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 4949, 4967);
return return_v;
}


System.Globalization.CultureInfo
f_1178_5020_5045(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 5020, 5045);
return return_v;
}


string
f_1178_5020_5050(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 5020, 5050);
return return_v;
}


string
f_1178_5052_5064(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 5052, 5064);
return return_v;
}


int
f_1178_5005_5122(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 5005, 5122);
return return_v;
}


System.Version
f_1178_5176_5201(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1178, 5176, 5201);
return return_v;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1178_4949_4967_I(System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 4949, 4967);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1178,4810,5275);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,4810,5275);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static UpdatableHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1178,1274,5282);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1178,1274,5282);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1178,1274,5282);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1178,1274,5282);

int
f_1178_1661_1691(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 1661, 1691);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
f_1178_1779_1813()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1178, 1779, 1813);
return return_v;
}

}
}
