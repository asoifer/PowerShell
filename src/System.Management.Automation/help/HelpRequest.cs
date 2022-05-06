// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
internal class HelpRequest
{
internal HelpRequest(string target, HelpCategory helpCategory)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1160,943,1152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1997,2051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,2169,2205);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,2328,2397);
this.HelpCategory = HelpCategory.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,2835,2873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,3027,3070);
this.MaxResults = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,3206,3247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,3378,3414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,3554,3599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,3811,3861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1030,1046);

Target = target;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1060,1088);

HelpCategory = helpCategory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1102,1141);

CommandOrigin = CommandOrigin.Runspace;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1160,943,1152);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1160,943,1152);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1160,943,1152);
}
		}

internal HelpRequest Clone()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1160,1303,1862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1356,1430);

HelpRequest 
helpRequest = f_1160_1382_1429(f_1160_1398_1409(this), f_1160_1411_1428(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1446,1483);

helpRequest.Provider = f_1160_1469_1482(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1497,1538);

helpRequest.MaxResults = f_1160_1522_1537(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1552,1591);

helpRequest.Component = f_1160_1576_1590(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1605,1634);

helpRequest.Role = f_1160_1624_1633(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1648,1695);

helpRequest.Functionality = f_1160_1676_1694(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1709,1760);

helpRequest.ProviderContext = f_1160_1739_1759(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1774,1816);

helpRequest.CommandOrigin = f_1160_1802_1815();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,1832,1851);

return helpRequest;
DynAbs.Tracing.TraceSender.TraceExitMethod(1160,1303,1862);

string
f_1160_1398_1409(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1398, 1409);
return return_v;
}


System.Management.Automation.HelpCategory
f_1160_1411_1428(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1411, 1428);
return return_v;
}


System.Management.Automation.HelpRequest
f_1160_1382_1429(string
target,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.HelpRequest( target, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1160, 1382, 1429);
return return_v;
}


string
f_1160_1469_1482(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1469, 1482);
return return_v;
}


int
f_1160_1522_1537(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1522, 1537);
return return_v;
}


string[]
f_1160_1576_1590(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1576, 1590);
return return_v;
}


string[]
f_1160_1624_1633(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1624, 1633);
return return_v;
}


string[]
f_1160_1676_1694(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1676, 1694);
return return_v;
}


System.Management.Automation.ProviderContext
f_1160_1739_1759(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.ProviderContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1739, 1759);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1160_1802_1815()
{
var return_v = CommandOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 1802, 1815);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1160,1303,1862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1160,1303,1862);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ProviderContext ProviderContext {get; set; }

internal string Target {get; set; }

internal HelpCategory HelpCategory {get; set; }

internal string Provider {get; set; }

internal int MaxResults {get; set; }

internal string[] Component {get; set; }

internal string[] Role {get; set; }

internal string[] Functionality {get; set; }

internal CommandOrigin CommandOrigin {get; set; }

internal void Validate()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1160,4455,6220);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,4504,4919) || true) && (f_1160_4508_4536(f_1160_4529_4535())&&(DynAbs.Tracing.TraceSender.Expression_True(1160, 4508, 4590)&&f_1160_4557_4569()== HelpCategory.None
)&&(DynAbs.Tracing.TraceSender.Expression_True(1160, 4508, 4641)&&f_1160_4611_4641(f_1160_4632_4640()))&&(DynAbs.Tracing.TraceSender.Expression_True(1160, 4508, 4679)&&f_1160_4662_4671()== null
)&&(DynAbs.Tracing.TraceSender.Expression_True(1160, 4508, 4712)&&f_1160_4700_4704()== null
)&&(DynAbs.Tracing.TraceSender.Expression_True(1160, 4508, 4754)&&f_1160_4733_4746()== null
))
            )

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1160,4504,4919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,4802,4821);

Target = "default";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,4839,4879);

HelpCategory = HelpCategory.DefaultHelp;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,4897,4904);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1160,4504,4919);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,4935,5344) || true) && (f_1160_4939_4967(f_1160_4960_4966()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1160,4935,5344);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5001,5329) || true) && (!f_1160_5006_5036(f_1160_5027_5035())&&(DynAbs.Tracing.TraceSender.Expression_True(1160, 5005, 5137)&&                    (f_1160_5062_5074()== HelpCategory.None ||(DynAbs.Tracing.TraceSender.Expression_False(1160, 5062, 5136)||f_1160_5099_5111()== HelpCategory.Provider))
))
                )

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1160,5001,5329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5197,5215);

Target = f_1160_5206_5214();
DynAbs.Tracing.TraceSender.TraceExitCondition(1160,5001,5329);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1160,5001,5329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5297,5310);

Target = "*";
DynAbs.Tracing.TraceSender.TraceExitCondition(1160,5001,5329);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1160,4935,5344);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5490,5850) || true) && ((!(f_1160_5497_5506()== null &&(DynAbs.Tracing.TraceSender.Expression_True(1160, 5497, 5530)&&f_1160_5518_5522()== null )&&(DynAbs.Tracing.TraceSender.Expression_True(1160, 5497, 5555)&&f_1160_5534_5547()== null))) &&(DynAbs.Tracing.TraceSender.Expression_True(1160, 5494, 5613)&&                (f_1160_5579_5591()== HelpCategory.None)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1160,5490,5850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5647,5808);

HelpCategory = HelpCategory.Alias | HelpCategory.Cmdlet | HelpCategory.Function | HelpCategory.Filter | HelpCategory.ExternalScript | HelpCategory.ScriptCommand;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5828,5835);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1160,5490,5850);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5866,5994) || true) && ((f_1160_5871_5883()& HelpCategory.Cmdlet) > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1160,5866,5994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,5944,5979);

HelpCategory |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => HelpCategory.Alias,1160,5944,5956);
DynAbs.Tracing.TraceSender.TraceExitCondition(1160,5866,5994);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,6010,6128) || true) && (f_1160_6014_6026()== HelpCategory.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1160,6010,6128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,6081,6113);

HelpCategory = HelpCategory.All;
DynAbs.Tracing.TraceSender.TraceExitCondition(1160,6010,6128);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,6144,6186);

HelpCategory &= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => ~HelpCategory.DefaultHelp,1160,6144,6156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1160,6202,6209);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1160,4455,6220);

string
f_1160_4529_4535()
{
var return_v = Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 4529, 4535);
return return_v;
}


bool
f_1160_4508_4536(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1160, 4508, 4536);
return return_v;
}


System.Management.Automation.HelpCategory
f_1160_4557_4569()
{
var return_v = HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 4557, 4569);
return return_v;
}


string
f_1160_4632_4640()
{
var return_v = Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 4632, 4640);
return return_v;
}


bool
f_1160_4611_4641(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1160, 4611, 4641);
return return_v;
}


string[]
f_1160_4662_4671()
{
var return_v = Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 4662, 4671);
return return_v;
}


string[]
f_1160_4700_4704()
{
var return_v = Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 4700, 4704);
return return_v;
}


string[]
f_1160_4733_4746()
{
var return_v = Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 4733, 4746);
return return_v;
}


string
f_1160_4960_4966()
{
var return_v = Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 4960, 4966);
return return_v;
}


bool
f_1160_4939_4967(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1160, 4939, 4967);
return return_v;
}


string
f_1160_5027_5035()
{
var return_v = Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5027, 5035);
return return_v;
}


bool
f_1160_5006_5036(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1160, 5006, 5036);
return return_v;
}


System.Management.Automation.HelpCategory
f_1160_5062_5074()
{
var return_v = HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5062, 5074);
return return_v;
}


System.Management.Automation.HelpCategory
f_1160_5099_5111()
{
var return_v = HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5099, 5111);
return return_v;
}


string
f_1160_5206_5214()
{
var return_v = Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5206, 5214);
return return_v;
}


string[]
f_1160_5497_5506()
{
var return_v = Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5497, 5506);
return return_v;
}


string[]
f_1160_5518_5522()
{
var return_v = Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5518, 5522);
return return_v;
}


string[]
f_1160_5534_5547()
{
var return_v = Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5534, 5547);
return return_v;
}


System.Management.Automation.HelpCategory
f_1160_5579_5591()
{
var return_v = HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5579, 5591);
return return_v;
}


System.Management.Automation.HelpCategory
f_1160_5871_5883()
{
var return_v = HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 5871, 5883);
return return_v;
}


System.Management.Automation.HelpCategory
f_1160_6014_6026()
{
var return_v = HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1160, 6014, 6026);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1160,4455,6220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1160,4455,6220);
}
		}

static HelpRequest()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1160,719,6227);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1160,719,6227);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1160,719,6227);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1160,719,6227);
}
}
