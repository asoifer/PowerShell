// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Xml;

namespace System.Management.Automation
{
internal class ProviderHelpInfo : HelpInfo
{
private ProviderHelpInfo(XmlNode xmlNode)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1170,497,880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,4933,4948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,563,605);

MamlNode 
mamlNode = f_1170_583_604(xmlNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,619,655);

_fullHelpObject = f_1170_637_654(mamlNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,669,699);

this.Errors = f_1170_683_698(mamlNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,715,749);

f_1170_715_748(f_1170_715_740(_fullHelpObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,763,813);

f_1170_763_812(f_1170_763_788(_fullHelpObject), "ProviderHelpInfo");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,827,869);

f_1170_827_868(f_1170_827_852(_fullHelpObject), "HelpInfo");
DynAbs.Tracing.TraceSender.TraceExitConstructor(1170,497,880);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,497,880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,497,880);
}
		}

internal override string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1170,1169,1716);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1205,1275) || true) && (_fullHelpObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,1205,1275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1255,1275);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,1205,1275);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1295,1384) || true) && (f_1170_1299_1333(f_1170_1299_1325(_fullHelpObject), "Name")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,1295,1384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1364,1384);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,1295,1384);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1404,1499) || true) && (f_1170_1408_1448(f_1170_1408_1442(f_1170_1408_1434(_fullHelpObject), "Name"))== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,1404,1499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1479,1499);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,1404,1499);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1519,1585);

string 
name = f_1170_1533_1584(f_1170_1533_1573(f_1170_1533_1567(f_1170_1533_1559(_fullHelpObject), "Name")))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1603,1662) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,1603,1662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1642,1662);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,1603,1662);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1682,1701);

return f_1170_1689_1700(name);
DynAbs.Tracing.TraceSender.TraceExitMethod(1170,1169,1716);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_1299_1325(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1299, 1325);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_1299_1333(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1299, 1333);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_1408_1434(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1408, 1434);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_1408_1442(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1408, 1442);
return return_v;
}


object
f_1170_1408_1448(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1408, 1448);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_1533_1559(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1533, 1559);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_1533_1567(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1533, 1567);
return return_v;
}


object
f_1170_1533_1573(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 1533, 1573);
return return_v;
}


string?
f_1170_1533_1584(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 1533, 1584);
return return_v;
}


string
f_1170_1689_1700(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 1689, 1700);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,1115,1727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,1115,1727);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Synopsis
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1170,1956,2527);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,1992,2062) || true) && (_fullHelpObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,1992,2062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2042,2062);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,1992,2062);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2082,2175) || true) && (f_1170_2086_2124(f_1170_2086_2112(_fullHelpObject), "Synopsis")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,2082,2175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2155,2175);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,2082,2175);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2195,2294) || true) && (f_1170_2199_2243(f_1170_2199_2237(f_1170_2199_2225(_fullHelpObject), "Synopsis"))== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,2195,2294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2274,2294);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,2195,2294);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2314,2388);

string 
synopsis = f_1170_2332_2387(f_1170_2332_2376(f_1170_2332_2370(f_1170_2332_2358(_fullHelpObject), "Synopsis")))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2406,2469) || true) && (synopsis == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,2406,2469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2449,2469);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,2406,2469);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2489,2512);

return f_1170_2496_2511(synopsis);
DynAbs.Tracing.TraceSender.TraceExitMethod(1170,1956,2527);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_2086_2112(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2086, 2112);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_2086_2124(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2086, 2124);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_2199_2225(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2199, 2225);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_2199_2237(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2199, 2237);
return return_v;
}


object
f_1170_2199_2243(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2199, 2243);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_2332_2358(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2332, 2358);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_2332_2370(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2332, 2370);
return return_v;
}


object
f_1170_2332_2376(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2332, 2376);
return return_v;
}


string?
f_1170_2332_2387(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 2332, 2387);
return return_v;
}


string
f_1170_2496_2511(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 2496, 2511);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,1898,2538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,1898,2538);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string DetailedDescription
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1170,2793,4506);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2829,2897) || true) && (f_1170_2833_2846(this)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,2829,2897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2877,2897);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,2829,2897);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,2917,3143) || true) && (f_1170_2921_2968(f_1170_2921_2945(f_1170_2921_2934(this)), "DetailedDescription")== null ||(DynAbs.Tracing.TraceSender.Expression_False(1170, 2921, 3062)||f_1170_3001_3054(f_1170_3001_3048(f_1170_3001_3025(f_1170_3001_3014(this)), "DetailedDescription"))== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,2917,3143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3104,3124);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,2917,3143);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3163,3246);

IList 
descriptionItems = f_1170_3188_3236(f_1170_3188_3230(f_1170_3188_3207(f_1170_3188_3196()), "DetailedDescription"))as IList
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3264,3404) || true) && (descriptionItems == null ||(DynAbs.Tracing.TraceSender.Expression_False(1170, 3268, 3323)||f_1170_3296_3318(descriptionItems)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,3264,3404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3365,3385);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,3264,3404);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3705,3761);

Text.StringBuilder 
result = f_1170_3733_3760(400)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3779,4439);
foreach(object descriptionItem in f_1170_3814_3830_I(descriptionItems) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,3779,4439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3872,3938);

PSObject 
descriptionObject = f_1170_3901_3937(descriptionItem)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,3960,4229) || true) && ((descriptionObject == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1170, 3964, 4066)||                        (f_1170_4021_4057(f_1170_4021_4049(descriptionObject), "Text")== null) )||(DynAbs.Tracing.TraceSender.Expression_False(1170, 3964, 4147)||                        (f_1170_4096_4138(f_1170_4096_4132(f_1170_4096_4124(descriptionObject), "Text"))== null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,3960,4229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,4197,4206);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,3960,4229);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,4253,4321);

string 
text = f_1170_4267_4320(f_1170_4267_4309(f_1170_4267_4303(f_1170_4267_4295(descriptionObject), "Text")))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,4343,4363);

f_1170_4343_4362(                    result, text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,4385,4420);

f_1170_4385_4419(                    result, f_1170_4399_4418());
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,3779,4439);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1170,1,661);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1170,1,661);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,4459,4491);

return f_1170_4466_4490(f_1170_4466_4483(result));
DynAbs.Tracing.TraceSender.TraceExitMethod(1170,2793,4506);

System.Management.Automation.PSObject
f_1170_2833_2846(System.Management.Automation.ProviderHelpInfo
this_param)
{
var return_v = this_param.FullHelp ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2833, 2846);
return return_v;
}


System.Management.Automation.PSObject
f_1170_2921_2934(System.Management.Automation.ProviderHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2921, 2934);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_2921_2945(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2921, 2945);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_2921_2968(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 2921, 2968);
return return_v;
}


System.Management.Automation.PSObject
f_1170_3001_3014(System.Management.Automation.ProviderHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3001, 3014);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_3001_3025(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3001, 3025);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_3001_3048(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3001, 3048);
return return_v;
}


object
f_1170_3001_3054(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3001, 3054);
return return_v;
}


System.Management.Automation.PSObject
f_1170_3188_3196()
{
var return_v = FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3188, 3196);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_3188_3207(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3188, 3207);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_3188_3230(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3188, 3230);
return return_v;
}


object
f_1170_3188_3236(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3188, 3236);
return return_v;
}


int
f_1170_3296_3318(System.Collections.IList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 3296, 3318);
return return_v;
}


System.Text.StringBuilder
f_1170_3733_3760(int
capacity)
{
var return_v = new System.Text.StringBuilder( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 3733, 3760);
return return_v;
}


System.Management.Automation.PSObject
f_1170_3901_3937(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 3901, 3937);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_4021_4049(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4021, 4049);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_4021_4057(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4021, 4057);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_4096_4124(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4096, 4124);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_4096_4132(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4096, 4132);
return return_v;
}


object
f_1170_4096_4138(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4096, 4138);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1170_4267_4295(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4267, 4295);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1170_4267_4303(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4267, 4303);
return return_v;
}


object
f_1170_4267_4309(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4267, 4309);
return return_v;
}


string?
f_1170_4267_4320(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 4267, 4320);
return return_v;
}


System.Text.StringBuilder
f_1170_4343_4362(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 4343, 4362);
return return_v;
}


string
f_1170_4399_4418()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 4399, 4418);
return return_v;
}


System.Text.StringBuilder
f_1170_4385_4419(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 4385, 4419);
return return_v;
}


System.Collections.IList
f_1170_3814_3830_I(System.Collections.IList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 3814, 3830);
return return_v;
}


string
f_1170_4466_4483(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 4466, 4483);
return return_v;
}


string
f_1170_4466_4490(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 4466, 4490);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,2733,4517);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,2733,4517);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1170,4813,4893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,4849,4878);

return HelpCategory.Provider;
DynAbs.Tracing.TraceSender.TraceExitMethod(1170,4813,4893);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,4745,4904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,4745,4904);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSObject _fullHelpObject;

internal override PSObject FullHelp
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1170,5200,5274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,5236,5259);

return _fullHelpObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1170,5200,5274);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,5140,5285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,5140,5285);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override bool MatchPatternInContent(WildcardPattern pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1170,5762,6364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,5856,5918);

f_1170_5856_5917(pattern != null, "pattern cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,5934,5961);

string 
synopsis = f_1170_5952_5960()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,5975,6024);

string 
detailedDescription = f_1170_6004_6023()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,6040,6133) || true) && (synopsis == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,6040,6133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,6094,6118);

synopsis = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,6040,6133);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,6149,6264) || true) && (detailedDescription == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,6149,6264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,6214,6249);

detailedDescription = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,6149,6264);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,6280,6353);

return f_1170_6287_6312(pattern, synopsis)||(DynAbs.Tracing.TraceSender.Expression_False(1170, 6287, 6352)||f_1170_6316_6352(pattern, detailedDescription));
DynAbs.Tracing.TraceSender.TraceExitMethod(1170,5762,6364);

int
f_1170_5856_5917(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 5856, 5917);
return 0;
}


string
f_1170_5952_5960()
{
var return_v = Synopsis;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 5952, 5960);
return return_v;
}


string
f_1170_6004_6023()
{
var return_v = DetailedDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 6004, 6023);
return return_v;
}


bool
f_1170_6287_6312(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 6287, 6312);
return return_v;
}


bool
f_1170_6316_6352(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 6316, 6352);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,5762,6364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,5762,6364);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ProviderHelpInfo Load(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1170,12574,12923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,12653,12719);

ProviderHelpInfo 
providerHelpInfo = f_1170_12689_12718(xmlNode)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,12735,12813) || true) && (f_1170_12739_12782(f_1170_12760_12781(providerHelpInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1170,12735,12813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,12801,12813);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1170,12735,12813);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,12829,12872);

f_1170_12829_12871(
            providerHelpInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1170,12888,12912);

return providerHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1170,12574,12923);

System.Management.Automation.ProviderHelpInfo
f_1170_12689_12718(System.Xml.XmlNode
xmlNode)
{
var return_v = new System.Management.Automation.ProviderHelpInfo( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 12689, 12718);
return return_v;
}


string
f_1170_12760_12781(System.Management.Automation.ProviderHelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 12760, 12781);
return return_v;
}


bool
f_1170_12739_12782(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 12739, 12782);
return return_v;
}


int
f_1170_12829_12871(System.Management.Automation.ProviderHelpInfo
this_param)
{
this_param.AddCommonHelpProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 12829, 12871);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1170,12574,12923);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,12574,12923);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ProviderHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1170,348,12952);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1170,348,12952);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1170,348,12952);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1170,348,12952);

System.Management.Automation.MamlNode
f_1170_583_604(System.Xml.XmlNode
xmlNode)
{
var return_v = new System.Management.Automation.MamlNode( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 583, 604);
return return_v;
}


System.Management.Automation.PSObject
f_1170_637_654(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.PSObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 637, 654);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1170_683_698(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 683, 698);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1170_715_740(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 715, 740);
return return_v;
}


int
f_1170_715_748(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 715, 748);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1170_763_788(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 763, 788);
return return_v;
}


int
f_1170_763_812(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 763, 812);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1170_827_852(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1170, 827, 852);
return return_v;
}


int
f_1170_827_868(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1170, 827, 868);
return 0;
}

}
}
