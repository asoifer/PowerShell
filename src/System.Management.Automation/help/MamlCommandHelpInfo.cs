// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;
using System.Text;
using System.Xml;

namespace System.Management.Automation
{
internal class MamlCommandHelpInfo : BaseCommandHelpInfo
{
internal MamlCommandHelpInfo(PSObject helpObject, HelpCategory helpCategory)
:base(f_1164_901_913_C(helpCategory) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1164,804,1649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,4035,4050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6202,6219);
this._component = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6513,6525);
this._role = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6804,6825);
this._functionality = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,939,968);

_fullHelpObject = helpObject;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,984,1033);

this.ForwardHelpCategory = HelpCategory.Provider;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,1049,1080);

f_1164_1049_1079(
            this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,1132,1291) || true) && (f_1164_1136_1170(f_1164_1136_1157(helpObject), "Component")!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,1132,1291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,1212,1276);

_component = f_1164_1225_1265(f_1164_1225_1259(f_1164_1225_1246(helpObject), "Component"))as string;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,1132,1291);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,1307,1451) || true) && (f_1164_1311_1340(f_1164_1311_1332(helpObject), "Role")!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,1307,1451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,1382,1436);

_role = f_1164_1390_1425(f_1164_1390_1419(f_1164_1390_1411(helpObject), "Role"))as string;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,1307,1451);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,1467,1638) || true) && (f_1164_1471_1509(f_1164_1471_1492(helpObject), "Functionality")!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,1467,1638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,1551,1623);

_functionality = f_1164_1568_1612(f_1164_1568_1606(f_1164_1568_1589(helpObject), "Functionality"))as string;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,1467,1638);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1164,804,1649);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,804,1649);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,804,1649);
}
		}

private MamlCommandHelpInfo(XmlNode xmlNode, HelpCategory helpCategory) :base(f_1164_2252_2264_C(helpCategory) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1164,2173,3112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,4035,4050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6202,6219);
this._component = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6513,6525);
this._role = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6804,6825);
this._functionality = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2290,2332);

MamlNode 
mamlNode = f_1164_2310_2331(xmlNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2346,2382);

_fullHelpObject = f_1164_2364_2381(mamlNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2398,2428);

this.Errors = f_1164_2412_2427(mamlNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2663,2697);

f_1164_2663_2696(f_1164_2663_2688(_fullHelpObject));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2711,3036) || true) && (helpCategory == HelpCategory.DscResource)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,2711,3036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2789,2842);

f_1164_2789_2841(f_1164_2789_2814(_fullHelpObject), "DscResourceHelpInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,2711,3036);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,2711,3036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2908,2961);

f_1164_2908_2960(f_1164_2908_2933(_fullHelpObject), "MamlCommandHelpInfo");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,2979,3021);

f_1164_2979_3020(f_1164_2979_3004(_fullHelpObject), "HelpInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,2711,3036);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3052,3101);

this.ForwardHelpCategory = HelpCategory.Provider;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1164,2173,3112);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,2173,3112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,2173,3112);
}
		}

internal void OverrideProviderSpecificHelpWithGenericHelp(HelpInfo genericHelpInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,3269,3965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3377,3429);

PSObject 
genericHelpMaml = f_1164_3404_3428(genericHelpInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3443,3499);

f_1164_3443_3498(_fullHelpObject, genericHelpMaml);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3513,3576);

f_1164_3513_3575(_fullHelpObject, genericHelpMaml);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3590,3647);

f_1164_3590_3646(_fullHelpObject, genericHelpMaml);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3661,3731);

f_1164_3661_3730(_fullHelpObject, genericHelpMaml);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3745,3807);

f_1164_3745_3806(_fullHelpObject, genericHelpMaml);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3821,3877);

f_1164_3821_3876(_fullHelpObject, genericHelpMaml);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,3891,3954);

f_1164_3891_3953(_fullHelpObject, genericHelpMaml);
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,3269,3965);

System.Management.Automation.PSObject
f_1164_3404_3428(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 3404, 3428);
return return_v;
}


int
f_1164_3443_3498(System.Management.Automation.PSObject
maml1,System.Management.Automation.PSObject
maml2)
{
MamlUtil.OverrideName( maml1, maml2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 3443, 3498);
return 0;
}


int
f_1164_3513_3575(System.Management.Automation.PSObject
maml1,System.Management.Automation.PSObject
maml2)
{
MamlUtil.OverridePSTypeNames( maml1, maml2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 3513, 3575);
return 0;
}


int
f_1164_3590_3646(System.Management.Automation.PSObject
maml1,System.Management.Automation.PSObject
maml2)
{
MamlUtil.PrependSyntax( maml1, maml2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 3590, 3646);
return 0;
}


int
f_1164_3661_3730(System.Management.Automation.PSObject
maml1,System.Management.Automation.PSObject
maml2)
{
MamlUtil.PrependDetailedDescription( maml1, maml2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 3661, 3730);
return 0;
}


int
f_1164_3745_3806(System.Management.Automation.PSObject
maml1,System.Management.Automation.PSObject
maml2)
{
MamlUtil.OverrideParameters( maml1, maml2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 3745, 3806);
return 0;
}


int
f_1164_3821_3876(System.Management.Automation.PSObject
maml1,System.Management.Automation.PSObject
maml2)
{
MamlUtil.PrependNotes( maml1, maml2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 3821, 3876);
return 0;
}


int
f_1164_3891_3953(System.Management.Automation.PSObject
maml1,System.Management.Automation.PSObject
maml2)
{
MamlUtil.AddCommonProperties( maml1, maml2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 3891, 3953);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,3269,3965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,3269,3965);
}
		}

private PSObject _fullHelpObject;

internal override PSObject FullHelp
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,4285,4359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,4321,4344);

return _fullHelpObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,4285,4359);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,4225,4370);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,4225,4370);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string Examples
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,4532,4644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,4568,4629);

return f_1164_4575_4628(this, f_1164_4602_4615(this), "Examples");
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,4532,4644);

System.Management.Automation.PSObject
f_1164_4602_4615(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 4602, 4615);
return return_v;
}


string
f_1164_4575_4628(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = this_param.ExtractTextForHelpProperty( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 4575, 4628);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,4484,4655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,4484,4655);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string Parameters
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,4821,4935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,4857,4920);

return f_1164_4864_4919(this, f_1164_4891_4904(this), "Parameters");
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,4821,4935);

System.Management.Automation.PSObject
f_1164_4891_4904(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 4891, 4904);
return return_v;
}


string
f_1164_4864_4919(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = this_param.ExtractTextForHelpProperty( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 4864, 4919);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,4771,4946);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,4771,4946);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string Notes
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,5102,5214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,5138,5199);

return f_1164_5145_5198(this, f_1164_5172_5185(this), "alertset");
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,5102,5214);

System.Management.Automation.PSObject
f_1164_5172_5185(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 5172, 5185);
return return_v;
}


string
f_1164_5145_5198(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = this_param.ExtractTextForHelpProperty( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 5145, 5198);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,5057,5225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,5057,5225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _component ;

internal override string Component
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,6406,6475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6442,6460);

return _component;
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,6406,6475);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,6347,6486);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,6347,6486);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _role ;

internal override string Role
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,6702,6766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,6738,6751);

return _role;
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,6702,6766);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,6648,6777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,6648,6777);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string _functionality ;

internal override string Functionality
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,7020,7093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7056,7078);

return _functionality;
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,7020,7093);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,6957,7104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,6957,7104);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void SetAdditionalDataFromHelpComment(string component, string functionality, string role)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,7116,7537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7240,7263);

_component = component;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7277,7308);

_functionality = functionality;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7322,7335);

_role = role;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7487,7526);

f_1164_7487_7525(
            // component,role,functionality is part of common help..
            // Update these properties as we have new data now..
            this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,7116,7537);

int
f_1164_7487_7525(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
this_param.UpdateUserDefinedDataProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 7487, 7525);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,7116,7537);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,7116,7537);
}
		}

internal void AddUserDefinedData(UserDefinedHelpData userDefinedData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,7738,8618);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7832,7885) || true) && (userDefinedData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,7832,7885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7878,7885);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,7832,7885);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7901,7922);

string 
propertyValue
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,7936,8086) || true) && (f_1164_7940_8010(f_1164_7940_7966(userDefinedData), "component", out propertyValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,7936,8086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,8044,8071);

_component = propertyValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,7936,8086);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,8102,8242) || true) && (f_1164_8106_8171(f_1164_8106_8132(userDefinedData), "role", out propertyValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,8102,8242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,8205,8227);

_role = propertyValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,8102,8242);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,8258,8416) || true) && (f_1164_8262_8336(f_1164_8262_8288(userDefinedData), "functionality", out propertyValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,8258,8416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,8370,8401);

_functionality = propertyValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,8258,8416);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,8568,8607);

f_1164_8568_8606(
            // component,role,functionality is part of common help..
            // Update these properties as we have new data now..
            this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,7738,8618);

System.Collections.Generic.Dictionary<string, string>
f_1164_7940_7966(System.Management.Automation.UserDefinedHelpData
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 7940, 7966);
return return_v;
}


bool
f_1164_7940_8010(System.Collections.Generic.Dictionary<string, string>
this_param,string
key,out string
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 7940, 8010);
return return_v;
}


System.Collections.Generic.Dictionary<string, string>
f_1164_8106_8132(System.Management.Automation.UserDefinedHelpData
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 8106, 8132);
return return_v;
}


bool
f_1164_8106_8171(System.Collections.Generic.Dictionary<string, string>
this_param,string
key,out string
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 8106, 8171);
return return_v;
}


System.Collections.Generic.Dictionary<string, string>
f_1164_8262_8288(System.Management.Automation.UserDefinedHelpData
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 8262, 8288);
return return_v;
}


bool
f_1164_8262_8336(System.Collections.Generic.Dictionary<string, string>
this_param,string
key,out string
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 8262, 8336);
return return_v;
}


int
f_1164_8568_8606(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
this_param.UpdateUserDefinedDataProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 8568, 8606);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,7738,8618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,7738,8618);
}
		}

internal static MamlCommandHelpInfo Load(XmlNode xmlNode, HelpCategory helpCategory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1164,9023,9434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,9132,9221);

MamlCommandHelpInfo 
mamlCommandHelpInfo = f_1164_9174_9220(xmlNode, helpCategory)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,9237,9318) || true) && (f_1164_9241_9287(f_1164_9262_9286(mamlCommandHelpInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,9237,9318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,9306,9318);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,9237,9318);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,9334,9380);

f_1164_9334_9379(
            mamlCommandHelpInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,9396,9423);

return mamlCommandHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1164,9023,9434);

System.Management.Automation.MamlCommandHelpInfo
f_1164_9174_9220(System.Xml.XmlNode
xmlNode,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.MamlCommandHelpInfo( xmlNode, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 9174, 9220);
return return_v;
}


string
f_1164_9262_9286(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 9262, 9286);
return return_v;
}


bool
f_1164_9241_9287(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 9241, 9287);
return return_v;
}


int
f_1164_9334_9379(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
this_param.AddCommonHelpProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 9334, 9379);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,9023,9434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,9023,9434);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string ExtractTextForHelpProperty(PSObject psObject, string propertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,11509,11980);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,11615,11674) || true) && (psObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,11615,11674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,11654,11674);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,11615,11674);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,11690,11872) || true) && (f_1164_11694_11727(f_1164_11694_11713(psObject), propertyName)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1164, 11694, 11803)||f_1164_11756_11795(f_1164_11756_11789(f_1164_11756_11775(psObject), propertyName))== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,11690,11872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,11837,11857);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,11690,11872);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,11888,11969);

return f_1164_11895_11968(this, f_1164_11907_11967(f_1164_11927_11966(f_1164_11927_11960(f_1164_11927_11946(psObject), propertyName))));
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,11509,11980);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_11694_11713(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11694, 11713);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_11694_11727(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11694, 11727);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_11756_11775(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11756, 11775);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_11756_11789(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11756, 11789);
return return_v;
}


object
f_1164_11756_11795(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11756, 11795);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_11927_11946(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11927, 11946);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_11927_11960(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11927, 11960);
return return_v;
}


object
f_1164_11927_11966(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 11927, 11966);
return return_v;
}


System.Management.Automation.PSObject
f_1164_11907_11967(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 11907, 11967);
return return_v;
}


string
f_1164_11895_11968(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.PSObject
psObject)
{
var return_v = this_param.ExtractText( psObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 11895, 11968);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,11509,11980);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,11509,11980);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string ExtractText(PSObject psObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,12332,14510);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,12402,12491) || true) && (psObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,12402,12491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,12456,12476);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,12402,12491);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,12797,12843);

StringBuilder 
result = f_1164_12820_12842(400)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,12857,14458);
foreach(PSPropertyInfo propertyInfo in f_1164_12897_12916_I(f_1164_12897_12916(psObject)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,12857,14458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,12950,13004);

string 
typeNameOfValue = f_1164_12975_13003(propertyInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,13022,14443);

switch (f_1164_13030_13064(typeNameOfValue))
                {

case "system.boolean":
                    case "system.int32":
                    case "system.object":
                    case "system.object[]":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,13022,14443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,13284,13293);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,13022,14443);

case "system.string":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,13022,14443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,13362,13509);

f_1164_13362_13508(                        result, f_1164_13384_13507(f_1164_13413_13431(propertyInfo), typeof(string), f_1164_13478_13506()));
DynAbs.Tracing.TraceSender.TraceBreak(1164,13535,13541);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,13022,14443);

case "system.management.automation.psobject[]":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,13022,14443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,13636,13866);

PSObject[] 
items = (PSObject[])f_1164_13667_13865(f_1164_13730_13748(propertyInfo), typeof(PSObject[]), f_1164_13836_13864())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,13892,14041);
foreach(PSObject item in f_1164_13918_13923_I(items) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,13892,14041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,13981,14014);

f_1164_13981_14013(                            result, f_1164_13995_14012(this, item));
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,13892,14041);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1164,1,150);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1164,1,150);
}DynAbs.Tracing.TraceSender.TraceBreak(1164,14069,14075);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,13022,14443);

case "system.management.automation.psobject":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,13022,14443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,14168,14236);

f_1164_14168_14235(                        result, f_1164_14182_14234(this, f_1164_14194_14233(f_1164_14214_14232(propertyInfo))));
DynAbs.Tracing.TraceSender.TraceBreak(1164,14262,14268);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,13022,14443);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,13022,14443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,14324,14392);

f_1164_14324_14391(                        result, f_1164_14338_14390(this, f_1164_14350_14389(f_1164_14370_14388(propertyInfo))));
DynAbs.Tracing.TraceSender.TraceBreak(1164,14418,14424);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,13022,14443);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,12857,14458);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1164,1,1602);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1164,1,1602);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,14474,14499);

return f_1164_14481_14498(result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,12332,14510);

System.Text.StringBuilder
f_1164_12820_12842(int
capacity)
{
var return_v = new System.Text.StringBuilder( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 12820, 12842);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_12897_12916(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 12897, 12916);
return return_v;
}


string
f_1164_12975_13003(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.TypeNameOfValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 12975, 13003);
return return_v;
}


string
f_1164_13030_13064(string
this_param)
{
var return_v = this_param.ToLowerInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 13030, 13064);
return return_v;
}


object
f_1164_13413_13431(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 13413, 13431);
return return_v;
}


System.Globalization.CultureInfo
f_1164_13478_13506()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 13478, 13506);
return return_v;
}


object
f_1164_13384_13507(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 13384, 13507);
return return_v;
}


System.Text.StringBuilder
f_1164_13362_13508(System.Text.StringBuilder
this_param,object
value)
{
var return_v = this_param.Append( (string)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 13362, 13508);
return return_v;
}


object
f_1164_13730_13748(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 13730, 13748);
return return_v;
}


System.Globalization.CultureInfo
f_1164_13836_13864()
{
var return_v =                                 CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 13836, 13864);
return return_v;
}


object
f_1164_13667_13865(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 13667, 13865);
return return_v;
}


string
f_1164_13995_14012(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.PSObject
psObject)
{
var return_v = this_param.ExtractText( psObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 13995, 14012);
return return_v;
}


System.Text.StringBuilder
f_1164_13981_14013(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 13981, 14013);
return return_v;
}


System.Management.Automation.PSObject[]
f_1164_13918_13923_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 13918, 13923);
return return_v;
}


object
f_1164_14214_14232(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 14214, 14232);
return return_v;
}


System.Management.Automation.PSObject
f_1164_14194_14233(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 14194, 14233);
return return_v;
}


string
f_1164_14182_14234(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.PSObject
psObject)
{
var return_v = this_param.ExtractText( psObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 14182, 14234);
return return_v;
}


System.Text.StringBuilder
f_1164_14168_14235(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 14168, 14235);
return return_v;
}


object
f_1164_14370_14388(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 14370, 14388);
return return_v;
}


System.Management.Automation.PSObject
f_1164_14350_14389(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 14350, 14389);
return return_v;
}


string
f_1164_14338_14390(System.Management.Automation.MamlCommandHelpInfo
this_param,System.Management.Automation.PSObject
psObject)
{
var return_v = this_param.ExtractText( psObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 14338, 14390);
return return_v;
}


System.Text.StringBuilder
f_1164_14324_14391(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 14324, 14391);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_12897_12916_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 12897, 12916);
return return_v;
}


string
f_1164_14481_14498(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 14481, 14498);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,12332,14510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,12332,14510);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool MatchPatternInContent(WildcardPattern pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,14985,16180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15079,15170);

f_1164_15079_15169(pattern != null, "pattern cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15186,15213);

string 
synopsis = f_1164_15204_15212()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15227,15356) || true) && ((!f_1164_15233_15263(synopsis)) &&(DynAbs.Tracing.TraceSender.Expression_True(1164, 15231, 15295)&&(f_1164_15269_15294(pattern, synopsis))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,15227,15356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15329,15341);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,15227,15356);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15372,15421);

string 
detailedDescription = f_1164_15401_15420()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15435,15586) || true) && ((!f_1164_15441_15482(detailedDescription)) &&(DynAbs.Tracing.TraceSender.Expression_True(1164, 15439, 15525)&&(f_1164_15488_15524(pattern, detailedDescription))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,15435,15586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15559,15571);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,15435,15586);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15602,15629);

string 
examples = f_1164_15620_15628()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15643,15772) || true) && ((!f_1164_15649_15679(examples)) &&(DynAbs.Tracing.TraceSender.Expression_True(1164, 15647, 15711)&&(f_1164_15685_15710(pattern, examples))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,15643,15772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15745,15757);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,15643,15772);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15788,15809);

string 
notes = f_1164_15803_15808()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15823,15946) || true) && ((!f_1164_15829_15856(notes)) &&(DynAbs.Tracing.TraceSender.Expression_True(1164, 15827, 15885)&&(f_1164_15862_15884(pattern, notes))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,15823,15946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15919,15931);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,15823,15946);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,15962,15993);

string 
parameters = f_1164_15982_15992()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16007,16140) || true) && ((!f_1164_16013_16045(parameters)) &&(DynAbs.Tracing.TraceSender.Expression_True(1164, 16011, 16079)&&(f_1164_16051_16078(pattern, parameters))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1164,16007,16140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16113,16125);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1164,16007,16140);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16156,16169);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,14985,16180);

int
f_1164_15079_15169(bool
condition,string
whyThisShouldNeverHappen)
{
System.Management.Automation.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15079, 15169);
return 0;
}


string
f_1164_15204_15212()
{
var return_v = Synopsis;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 15204, 15212);
return return_v;
}


bool
f_1164_15233_15263(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15233, 15263);
return return_v;
}


bool
f_1164_15269_15294(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15269, 15294);
return return_v;
}


string
f_1164_15401_15420()
{
var return_v = DetailedDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 15401, 15420);
return return_v;
}


bool
f_1164_15441_15482(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15441, 15482);
return return_v;
}


bool
f_1164_15488_15524(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15488, 15524);
return return_v;
}


string
f_1164_15620_15628()
{
var return_v = Examples;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 15620, 15628);
return return_v;
}


bool
f_1164_15649_15679(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15649, 15679);
return return_v;
}


bool
f_1164_15685_15710(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15685, 15710);
return return_v;
}


string
f_1164_15803_15808()
{
var return_v = Notes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 15803, 15808);
return return_v;
}


bool
f_1164_15829_15856(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15829, 15856);
return return_v;
}


bool
f_1164_15862_15884(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 15862, 15884);
return return_v;
}


string
f_1164_15982_15992()
{
var return_v = Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 15982, 15992);
return return_v;
}


bool
f_1164_16013_16045(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 16013, 16045);
return return_v;
}


bool
f_1164_16051_16078(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 16051, 16078);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,14985,16180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,14985,16180);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal MamlCommandHelpInfo Copy()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,16192,16387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16252,16348);

MamlCommandHelpInfo 
result = f_1164_16281_16347(f_1164_16305_16327(_fullHelpObject), f_1164_16329_16346(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16362,16376);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,16192,16387);

System.Management.Automation.PSObject
f_1164_16305_16327(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Copy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 16305, 16327);
return return_v;
}


System.Management.Automation.HelpCategory
f_1164_16329_16346(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 16329, 16346);
return return_v;
}


System.Management.Automation.MamlCommandHelpInfo
f_1164_16281_16347(System.Management.Automation.PSObject
helpObject,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.MamlCommandHelpInfo( helpObject, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 16281, 16347);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,16192,16387);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,16192,16387);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal MamlCommandHelpInfo Copy(HelpCategory newCategoryToUse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1164,16399,16700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16488,16583);

MamlCommandHelpInfo 
result = f_1164_16517_16582(f_1164_16541_16563(_fullHelpObject), newCategoryToUse)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16597,16661);

f_1164_16597_16635(f_1164_16597_16623(f_1164_16597_16612(result)), "Category").Value = newCategoryToUse;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1164,16675,16689);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1164,16399,16700);

System.Management.Automation.PSObject
f_1164_16541_16563(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Copy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 16541, 16563);
return return_v;
}


System.Management.Automation.MamlCommandHelpInfo
f_1164_16517_16582(System.Management.Automation.PSObject
helpObject,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.MamlCommandHelpInfo( helpObject, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 16517, 16582);
return return_v;
}


System.Management.Automation.PSObject
f_1164_16597_16612(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 16597, 16612);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_16597_16623(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 16597, 16623);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_16597_16635(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 16597, 16635);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1164,16399,16700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,16399,16700);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static MamlCommandHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1164,373,16729);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1164,373,16729);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1164,373,16729);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1164,373,16729);

int
f_1164_1049_1079(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
this_param.AddCommonHelpProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 1049, 1079);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_1136_1157(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1136, 1157);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_1136_1170(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1136, 1170);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_1225_1246(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1225, 1246);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_1225_1259(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1225, 1259);
return return_v;
}


object
f_1164_1225_1265(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1225, 1265);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_1311_1332(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1311, 1332);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_1311_1340(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1311, 1340);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_1390_1411(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1390, 1411);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_1390_1419(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1390, 1419);
return return_v;
}


object
f_1164_1390_1425(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1390, 1425);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_1471_1492(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1471, 1492);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_1471_1509(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1471, 1509);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1164_1568_1589(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1568, 1589);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1164_1568_1606(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1568, 1606);
return return_v;
}


object
f_1164_1568_1612(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 1568, 1612);
return return_v;
}


static System.Management.Automation.HelpCategory
f_1164_901_913_C(System.Management.Automation.HelpCategory
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1164, 804, 1649);
return return_v;
}


System.Management.Automation.MamlNode
f_1164_2310_2331(System.Xml.XmlNode
xmlNode)
{
var return_v = new System.Management.Automation.MamlNode( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 2310, 2331);
return return_v;
}


System.Management.Automation.PSObject
f_1164_2364_2381(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.PSObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 2364, 2381);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1164_2412_2427(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 2412, 2427);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1164_2663_2688(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 2663, 2688);
return return_v;
}


int
f_1164_2663_2696(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 2663, 2696);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1164_2789_2814(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 2789, 2814);
return return_v;
}


int
f_1164_2789_2841(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 2789, 2841);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1164_2908_2933(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 2908, 2933);
return return_v;
}


int
f_1164_2908_2960(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 2908, 2960);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1164_2979_3004(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1164, 2979, 3004);
return return_v;
}


int
f_1164_2979_3020(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1164, 2979, 3020);
return 0;
}


static System.Management.Automation.HelpCategory
f_1164_2252_2264_C(System.Management.Automation.HelpCategory
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1164, 2173, 3112);
return return_v;
}

}
}
