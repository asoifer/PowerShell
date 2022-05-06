// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Xml;

namespace System.Management.Automation
{
internal class MamlClassHelpInfo : HelpInfo
{
internal MamlClassHelpInfo(PSObject helpObject, HelpCategory helpCategory)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1163,585,766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1489,1504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,4081,4133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,684,712);

HelpCategory = helpCategory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,726,755);

_fullHelpObject = helpObject;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1163,585,766);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,585,766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,585,766);
}
		}

private MamlClassHelpInfo(XmlNode xmlNode, HelpCategory helpCategory)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1163,969,1367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1489,1504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,4081,4133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1063,1091);

HelpCategory = helpCategory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1107,1149);

MamlNode 
mamlNode = f_1163_1127_1148(xmlNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1163,1199);

_fullHelpObject = f_1163_1181_1198(mamlNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1215,1245);

this.Errors = f_1163_1229_1244(mamlNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1259,1293);

f_1163_1259_1292(f_1163_1259_1284(_fullHelpObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1307,1356);

f_1163_1307_1355(f_1163_1307_1332(_fullHelpObject), "PSClassHelpInfo");
DynAbs.Tracing.TraceSender.TraceExitConstructor(1163,969,1367);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,969,1367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,969,1367);
}
		}

private PSObject _fullHelpObject;

internal static MamlClassHelpInfo Load(XmlNode xmlNode, HelpCategory helpCategory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1163,1886,2283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,1993,2076);

MamlClassHelpInfo 
mamlClassHelpInfo = f_1163_2031_2075(xmlNode, helpCategory)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,2092,2171) || true) && (f_1163_2096_2140(f_1163_2117_2139(mamlClassHelpInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1163,2092,2171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,2159,2171);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1163,2092,2171);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,2187,2231);

f_1163_2187_2230(
            mamlClassHelpInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,2247,2272);

return mamlClassHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1163,1886,2283);

System.Management.Automation.MamlClassHelpInfo
f_1163_2031_2075(System.Xml.XmlNode
xmlNode,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.MamlClassHelpInfo( xmlNode, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 2031, 2075);
return return_v;
}


string
f_1163_2117_2139(System.Management.Automation.MamlClassHelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 2117, 2139);
return return_v;
}


bool
f_1163_2096_2140(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 2096, 2140);
return return_v;
}


int
f_1163_2187_2230(System.Management.Automation.MamlClassHelpInfo
this_param)
{
this_param.AddCommonHelpProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 2187, 2230);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,1886,2283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,1886,2283);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal MamlClassHelpInfo Copy()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1163,2511,2700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,2569,2661);

MamlClassHelpInfo 
result = f_1163_2596_2660(f_1163_2618_2640(_fullHelpObject), f_1163_2642_2659(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,2675,2689);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1163,2511,2700);

System.Management.Automation.PSObject
f_1163_2618_2640(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Copy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 2618, 2640);
return return_v;
}


System.Management.Automation.HelpCategory
f_1163_2642_2659(System.Management.Automation.MamlClassHelpInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 2642, 2659);
return return_v;
}


System.Management.Automation.MamlClassHelpInfo
f_1163_2596_2660(System.Management.Automation.PSObject
helpObject,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.MamlClassHelpInfo( helpObject, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 2596, 2660);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,2511,2700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,2511,2700);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal MamlClassHelpInfo Copy(HelpCategory newCategoryToUse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1163,2919,3214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3006,3097);

MamlClassHelpInfo 
result = f_1163_3033_3096(f_1163_3055_3077(_fullHelpObject), newCategoryToUse)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3111,3175);

f_1163_3111_3149(f_1163_3111_3137(f_1163_3111_3126(result)), "Category").Value = newCategoryToUse;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3189,3203);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1163,2919,3214);

System.Management.Automation.PSObject
f_1163_3055_3077(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Copy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 3055, 3077);
return return_v;
}


System.Management.Automation.MamlClassHelpInfo
f_1163_3033_3096(System.Management.Automation.PSObject
helpObject,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.MamlClassHelpInfo( helpObject, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 3033, 3096);
return return_v;
}


System.Management.Automation.PSObject
f_1163_3111_3126(System.Management.Automation.MamlClassHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3111, 3126);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1163_3111_3137(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3111, 3137);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1163_3111_3149(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3111, 3149);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,2919,3214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,2919,3214);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1163,3280,3619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3316,3347);

string 
tempName = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3365,3413);

var 
title = f_1163_3377_3412(f_1163_3377_3403(_fullHelpObject), "title")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3433,3568) || true) && (title != null &&(DynAbs.Tracing.TraceSender.Expression_True(1163, 3437, 3473)&&f_1163_3454_3465(title)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1163,3433,3568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3515,3549);

tempName = f_1163_3526_3548(f_1163_3526_3537(title));
DynAbs.Tracing.TraceSender.TraceExitCondition(1163,3433,3568);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3588,3604);

return tempName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1163,3280,3619);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1163_3377_3403(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3377, 3403);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1163_3377_3412(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3377, 3412);
return return_v;
}


object
f_1163_3454_3465(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3454, 3465);
return return_v;
}


object
f_1163_3526_3537(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3526, 3537);
return return_v;
}


string?
f_1163_3526_3548(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 3526, 3548);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,3226,3630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,3226,3630);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Synopsis
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1163,3700,4058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3736,3771);

string 
tempSynopsis = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3789,3844);

var 
intro = f_1163_3801_3843(f_1163_3801_3827(_fullHelpObject), "introduction")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3864,4003) || true) && (intro != null &&(DynAbs.Tracing.TraceSender.Expression_True(1163, 3868, 3904)&&f_1163_3885_3896(intro)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1163,3864,4003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,3946,3984);

tempSynopsis = f_1163_3961_3983(f_1163_3961_3972(intro));
DynAbs.Tracing.TraceSender.TraceExitCondition(1163,3864,4003);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,4023,4043);

return tempSynopsis;
DynAbs.Tracing.TraceSender.TraceExitMethod(1163,3700,4058);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1163_3801_3827(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3801, 3827);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1163_3801_3843(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3801, 3843);
return return_v;
}


object
f_1163_3885_3896(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3885, 3896);
return return_v;
}


object
f_1163_3961_3972(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 3961, 3972);
return return_v;
}


string?
f_1163_3961_3983(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 3961, 3983);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,3642,4069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,3642,4069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory {get; }

internal override PSObject FullHelp
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1163,4205,4236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1163,4211,4234);

return _fullHelpObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1163,4205,4236);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1163,4145,4247);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,4145,4247);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static MamlClassHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1163,320,4276);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1163,320,4276);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1163,320,4276);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1163,320,4276);

System.Management.Automation.MamlNode
f_1163_1127_1148(System.Xml.XmlNode
xmlNode)
{
var return_v = new System.Management.Automation.MamlNode( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 1127, 1148);
return return_v;
}


System.Management.Automation.PSObject
f_1163_1181_1198(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.PSObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 1181, 1198);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1163_1229_1244(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 1229, 1244);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1163_1259_1284(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 1259, 1284);
return return_v;
}


int
f_1163_1259_1292(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 1259, 1292);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1163_1307_1332(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1163, 1307, 1332);
return return_v;
}


int
f_1163_1307_1355(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1163, 1307, 1355);
return 0;
}

}
}
