// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
internal class ProviderCommandHelpInfo : HelpInfo
{
private HelpInfo _helpInfo;

internal ProviderCommandHelpInfo(HelpInfo genericHelpInfo, ProviderContext providerContext)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1168,564,1517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,441,450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,680,752);

f_1168_680_751(genericHelpInfo != null, "Expected genericHelpInfo != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,766,838);

f_1168_766_837(providerContext != null, "Expected providerContext != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,929,974);

this.ForwardHelpCategory = HelpCategory.None;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,1042,1172);

MamlCommandHelpInfo 
providerSpecificHelpInfo =
f_1168_1106_1171(                providerContext, f_1168_1150_1170(genericHelpInfo))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,1186,1506) || true) && (providerSpecificHelpInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1168,1186,1506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,1256,1284);

_helpInfo = genericHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1168,1186,1506);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1168,1186,1506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,1350,1436);

f_1168_1350_1435(                providerSpecificHelpInfo, genericHelpInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,1454,1491);

_helpInfo = providerSpecificHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1168,1186,1506);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1168,564,1517);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,564,1517);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,564,1517);
}
		}

internal override PSObject[] GetParameter(string pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,1604,1736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,1686,1725);

return f_1168_1693_1724(_helpInfo, pattern);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,1604,1736);

System.Management.Automation.PSObject[]
f_1168_1693_1724(System.Management.Automation.HelpInfo
this_param,string
pattern)
{
var return_v = this_param.GetParameter( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1168, 1693, 1724);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,1604,1736);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,1604,1736);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override Uri GetUriForOnlineHelp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,2081,2199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,2149,2188);

return f_1168_2156_2187(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,2081,2199);

System.Uri
f_1168_2156_2187(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.GetUriForOnlineHelp();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1168, 2156, 2187);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,2081,2199);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,2081,2199);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,2344,2417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,2380,2402);

return f_1168_2387_2401(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,2344,2417);

string
f_1168_2387_2401(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 2387, 2401);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,2290,2428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,2290,2428);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Synopsis
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,2581,2658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,2617,2643);

return f_1168_2624_2642(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,2581,2658);

string
f_1168_2624_2642(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Synopsis;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 2624, 2642);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,2523,2669);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,2523,2669);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,2836,2917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,2872,2902);

return f_1168_2879_2901(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,2836,2917);

System.Management.Automation.HelpCategory
f_1168_2879_2901(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 2879, 2901);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,2768,2928);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,2768,2928);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override PSObject FullHelp
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,3083,3160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,3119,3145);

return f_1168_3126_3144(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,3083,3160);

System.Management.Automation.PSObject
f_1168_3126_3144(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 3126, 3144);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,3023,3171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,3023,3171);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Component
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,3326,3404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,3362,3389);

return f_1168_3369_3388(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,3326,3404);

string
f_1168_3369_3388(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 3369, 3388);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,3267,3415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,3267,3415);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Role
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,3560,3633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,3596,3618);

return f_1168_3603_3617(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,3560,3633);

string
f_1168_3603_3617(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 3603, 3617);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,3506,3644);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,3506,3644);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Functionality
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1168,3807,3889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1168,3843,3874);

return f_1168_3850_3873(_helpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1168,3807,3889);

string
f_1168_3850_3873(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 3850, 3873);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1168,3744,3900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,3744,3900);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static ProviderCommandHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1168,287,3907);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1168,287,3907);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1168,287,3907);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1168,287,3907);

int
f_1168_680_751(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1168, 680, 751);
return 0;
}


int
f_1168_766_837(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1168, 766, 837);
return 0;
}


string
f_1168_1150_1170(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1168, 1150, 1170);
return return_v;
}


System.Management.Automation.MamlCommandHelpInfo
f_1168_1106_1171(System.Management.Automation.ProviderContext
this_param,string
helpItemName)
{
var return_v = this_param.GetProviderSpecificHelpInfo( helpItemName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1168, 1106, 1171);
return return_v;
}


int
f_1168_1350_1435(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.HelpInfo
genericHelpInfo)
{
this_param.OverrideProviderSpecificHelpWithGenericHelp( genericHelpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1168, 1350, 1435);
return 0;
}

}
}
