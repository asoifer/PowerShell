// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56506

namespace System.Management.Automation
{
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class CredentialAttribute : ArgumentTransformationAttribute
{
public override object Transform(EngineIntrinsics engineIntrinsics, object inputData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1223,1246,3141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1356,1381);

PSCredential 
cred = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1395,1418);

string 
userName = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1432,1458);

bool 
shouldPrompt = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1474,1723) || true) && ((engineIntrinsics == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1223, 1478, 1555)||               (f_1223_1525_1546(engineIntrinsics)== null) )||(DynAbs.Tracing.TraceSender.Expression_False(1223, 1478, 1609)||               (f_1223_1576_1600(f_1223_1576_1597(engineIntrinsics))== null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1223,1474,1723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1643,1708);

throw f_1223_1649_1707("engineIntrinsics");
DynAbs.Tracing.TraceSender.TraceExitCondition(1223,1474,1723);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1739,2559) || true) && (inputData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1223,1739,2559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1794,1814);

shouldPrompt = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1223,1739,2559);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1223,1739,2559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,1943,2007);

cred = f_1223_1950_2006(inputData);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2090,2544) || true) && (cred == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1223,2090,2544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2148,2168);

shouldPrompt = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2190,2252);

userName = f_1223_2201_2251(inputData);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2390,2525) || true) && (userName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1223,2390,2525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2460,2502);

throw f_1223_2466_2501("userName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1223,2390,2525);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1223,2090,2544);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1223,1739,2559);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2575,3102) || true) && (shouldPrompt)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1223,2575,3102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2625,2647);

string 
caption = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2665,2686);

string 
prompt = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2706,2778);

caption = f_1223_2716_2777();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2798,2861);

prompt = f_1223_2807_2860();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,2881,3087);

cred = f_1223_2888_3086(f_1223_2888_2912(f_1223_2888_2909(engineIntrinsics)), caption, prompt, userName, string.Empty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1223,2575,3102);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,3118,3130);

return cred;
DynAbs.Tracing.TraceSender.TraceExitMethod(1223,1246,3141);

System.Management.Automation.Host.PSHost
f_1223_1525_1546(System.Management.Automation.EngineIntrinsics
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1223, 1525, 1546);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1223_1576_1597(System.Management.Automation.EngineIntrinsics
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1223, 1576, 1597);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1223_1576_1600(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1223, 1576, 1600);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1223_1649_1707(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1223, 1649, 1707);
return return_v;
}


System.Management.Automation.PSCredential
f_1223_1950_2006(object
castObject)
{
var return_v = LanguagePrimitives.FromObjectAs<PSCredential>( castObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1223, 1950, 2006);
return return_v;
}


string
f_1223_2201_2251(object
castObject)
{
var return_v = LanguagePrimitives.FromObjectAs<string>( castObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1223, 2201, 2251);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1223_2466_2501(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1223, 2466, 2501);
return return_v;
}


string
f_1223_2716_2777()
{
var return_v = CredentialAttributeStrings.CredentialAttribute_Prompt_Caption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1223, 2716, 2777);
return return_v;
}


string
f_1223_2807_2860()
{
var return_v = CredentialAttributeStrings.CredentialAttribute_Prompt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1223, 2807, 2860);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1223_2888_2909(System.Management.Automation.EngineIntrinsics
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1223, 2888, 2909);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1223_2888_2912(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1223, 2888, 2912);
return return_v;
}


System.Management.Automation.PSCredential
f_1223_2888_3086(System.Management.Automation.Host.PSHostUserInterface
this_param,string
caption,string
message,string
userName,string
targetName)
{
var return_v = this_param.PromptForCredential( caption, message, userName, targetName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1223, 2888, 3086);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1223,1246,3141);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1223,1246,3141);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool TransformNullOptionalParameters {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1223,3232,3253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1223,3238,3251);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1223,3232,3253);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1223,3177,3255);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1223,3177,3255);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CredentialAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1223,371,3262);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1223,371,3262);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1223,371,3262);
}


static CredentialAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1223,371,3262);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1223,371,3262);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1223,371,3262);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1223,371,3262);
}
}

#pragma warning restore 56506

