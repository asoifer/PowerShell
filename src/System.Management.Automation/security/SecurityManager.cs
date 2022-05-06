// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Security;
using System.Security;
using System.Security.Cryptography.X509Certificates;

using Dbg = System.Management.Automation;

namespace Microsoft.PowerShell
{
public sealed class PSAuthorizationManager : AuthorizationManager
{        internal enum RunPromptDecision
        {
            NeverRun = 0,
            DoNotRun = 1,
            RunOnce = 2,
            AlwaysRun = 3,
            Suspend = 4
        }

private ExecutionPolicy _executionPolicy;

private string _shellId;

public PSAuthorizationManager(string shellId)
:base(f_1227_3593_3600_C(shellId) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1227,3527,3810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,3066,3082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,3165,3173);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,3626,3764) || true) && (f_1227_3630_3659(shellId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,3626,3764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,3693,3749);

throw f_1227_3699_3748("shellId");
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,3626,3764);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,3780,3799);

_shellId = shellId;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1227,3527,3810);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,3527,3810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,3527,3810);
}
		}

private static bool IsSupportedExtension(string ext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1227,3889,4484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,3966,4473);

return (
f_1227_3999_4053(                       ext, ".ps1", StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1227, 3999, 4138)||f_1227_4081_4138(                       ext, ".ps1xml", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1227, 3999, 4221)||f_1227_4166_4221(                       ext, ".psm1", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1227, 3999, 4304)||f_1227_4249_4304(                       ext, ".psd1", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1227, 3999, 4387)||f_1227_4332_4387(                       ext, ".xaml", StringComparison.OrdinalIgnoreCase))||(DynAbs.Tracing.TraceSender.Expression_False(1227, 3999, 4471)||f_1227_4415_4471(                       ext, ".cdxml", StringComparison.OrdinalIgnoreCase)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1227,3889,4484);

bool
f_1227_3999_4053(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 3999, 4053);
return return_v;
}


bool
f_1227_4081_4138(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4081, 4138);
return return_v;
}


bool
f_1227_4166_4221(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4166, 4221);
return return_v;
}


bool
f_1227_4249_4304(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4249, 4304);
return return_v;
}


bool
f_1227_4332_4387(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4332, 4387);
return return_v;
}


bool
f_1227_4415_4471(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4415, 4471);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,3889,4484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,3889,4484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CheckPolicy(ExternalScriptInfo script, PSHost host, out Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,4496,15950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,4607,4638);

bool 
policyCheckPassed = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,4652,4666);

reason = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,4680,4706);

string 
path = f_1227_4694_4705(script)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,4720,4741);

string 
reasonMessage
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,4816,4973) || true) && (f_1227_4820_4871(path, System.IO.Path.DirectorySeparatorChar)< 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,4816,4973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,4909,4958);

throw f_1227_4915_4957("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,4816,4973);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,4989,5167) || true) && (f_1227_4993_5048(path, System.IO.Path.DirectorySeparatorChar)== (f_1227_5053_5064(path)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,4989,5167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5103,5152);

throw f_1227_5109_5151("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,4989,5167);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5183,5216);

FileInfo 
fi = f_1227_5197_5215(path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5349,5484) || true) && (f_1227_5353_5363_M(!fi.Exists))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,5349,5484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5397,5438);

reason = f_1227_5406_5437(path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5456,5469);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,5349,5484);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5561,5631) || true) && (!f_1227_5566_5600(f_1227_5587_5599(fi)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,5561,5631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5619,5631);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,5561,5631);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5688,5752);

_executionPolicy = f_1227_5707_5751(_shellId);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5837,5914) || true) && (_executionPolicy == ExecutionPolicy.Bypass)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,5837,5914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,5902,5914);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,5837,5914);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6218,7820) || true) && (f_1227_6222_6260()!= SystemEnforcementMode.Enforce)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,6218,7820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6327,6376);

SaferPolicy 
saferPolicy = SaferPolicy.Disallowed
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6394,6415);

int 
saferAttempt = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6433,6461);

bool 
gotSaferPolicy = false
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6581,7142) || true) && ((!gotSaferPolicy) &&(DynAbs.Tracing.TraceSender.Expression_True(1227, 6588, 6627)&&(saferAttempt < 5)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,6581,7142);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6721,6778);

saferPolicy = f_1227_6735_6777(path, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6804,6826);

gotSaferPolicy = true;
                    }
                    catch (System.ComponentModel.Win32Exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1227,6871,7123);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6964,6996) || true) && (saferAttempt > 4)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,6964,6996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,6988,6994);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,6964,6996);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,7024,7039);

saferAttempt++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,7065,7100);

f_1227_7065_7099(100);
DynAbs.Tracing.TraceSender.TraceExitCatch(1227,6871,7123);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,6581,7142);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1227,6581,7142);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1227,6581,7142);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,7509,7805) || true) && (saferPolicy == SaferPolicy.Disallowed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,7509,7805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,7592,7671);

reasonMessage = f_1227_7608_7670(f_1227_7626_7663(), path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,7693,7749);

reason = f_1227_7702_7748(reasonMessage);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,7773,7786);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,7509,7805);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,6218,7820);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,7836,15898) || true) && (_executionPolicy == ExecutionPolicy.Unrestricted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,7836,15898);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8045,8121) || true) && (f_1227_8049_8086(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,8045,8121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8109,8121);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,8045,8121);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8264,10896) || true) && (!f_1227_8269_8293(this, f_1227_8281_8292(fi)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,8264,10896);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8390,8717) || true) && (f_1227_8394_8437(f_1227_8415_8436(script)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,8390,8717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8487,8571);

reasonMessage = f_1227_8503_8570(f_1227_8521_8563(), path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8597,8653);

reason = f_1227_8606_8652(reasonMessage);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8681,8694);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,8390,8717);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8741,8807);

Signature 
signature = f_1227_8763_8806(this, path, script)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,8930,9267) || true) && (f_1227_8934_8950(signature)== SignatureStatus.Valid)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,8930,9267);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9095,9244) || true) && (f_1227_9099_9134(this, signature, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,9095,9244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9192,9217);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,9095,9244);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,8930,9267);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9494,10770) || true) && (!policyCheckPassed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,9494,10770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9566,9622);

RunPromptDecision 
decision = RunPromptDecision.DoNotRun
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,9788,10094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9847,9887);

decision = f_1227_9858_9886(this, path, host);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9919,10020) || true) && (decision == RunPromptDecision.Suspend)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,9919,10020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9995,10020);

f_1227_9995_10019(                                host);
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,9919,10020);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,9788,10094);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,9788,10094) || true) && (decision == RunPromptDecision.Suspend)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1227,9788,10094);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1227,9788,10094);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,10122,10747);

switch (decision)
                        {

case RunPromptDecision.RunOnce:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,10122,10747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,10261,10286);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceBreak(1227,10320,10326);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,10122,10747);

case RunPromptDecision.DoNotRun:
                            default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,10122,10747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,10460,10486);

policyCheckPassed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,10520,10590);

reasonMessage = f_1227_10536_10589(f_1227_10554_10582(), path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,10624,10680);

reason = f_1227_10633_10679(reasonMessage);
DynAbs.Tracing.TraceSender.TraceBreak(1227,10714,10720);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,10122,10747);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,9494,10770);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,8264,10896);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,8264,10896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,10852,10877);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,8264,10896);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,7836,15898);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,7836,15898);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11050,15898) || true) && ((f_1227_11055_11079(this, f_1227_11067_11078(fi))) &&(DynAbs.Tracing.TraceSender.Expression_True(1227, 11054, 11155)&&                    (_executionPolicy == ExecutionPolicy.RemoteSigned)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,11050,15898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11189,11214);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,11050,15898);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,11050,15898);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11248,15898) || true) && ((_executionPolicy == ExecutionPolicy.AllSigned) ||(DynAbs.Tracing.TraceSender.Expression_False(1227, 11252, 11369)||               (_executionPolicy == ExecutionPolicy.RemoteSigned)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,11248,15898);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11551,11858) || true) && (f_1227_11555_11598(f_1227_11576_11597(script)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,11551,11858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11640,11724);

reasonMessage = f_1227_11656_11723(f_1227_11674_11716(), path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11746,11802);

reason = f_1227_11755_11801(reasonMessage);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11826,11839);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,11551,11858);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,11878,11944);

Signature 
signature = f_1227_11900_11943(this, path, script)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,12004,13536) || true) && (f_1227_12008_12024(signature)== SignatureStatus.Valid)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,12004,13536);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,12157,12582) || true) && (f_1227_12161_12196(this, signature, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,12157,12582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,12246,12271);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,12157,12582);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,12157,12582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,12472,12559);

policyCheckPassed = f_1227_12492_12558(this, path, host, ref reason, signature);
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,12157,12582);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,12004,13536);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,12004,13536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,12790,12816);

policyCheckPassed = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,12840,13517) || true) && (f_1227_12844_12860(signature)== SignatureStatus.NotTrusted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,12840,13517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,12940,13180);

reason = f_1227_12949_13179(f_1227_13011_13178(f_1227_13029_13059(), path, f_1227_13133_13177(f_1227_13133_13172(f_1227_13133_13160(signature)))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,12840,13517);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,12840,13517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,13278,13494);

reason = f_1227_13287_13493(f_1227_13349_13492(f_1227_13367_13394(), path, f_1227_13468_13491(signature)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,12840,13517);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,12004,13536);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,11248,15898);
}

else // if(executionPolicy == ExecutionPolicy.Restricted)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,11248,15898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,13691,13717);

policyCheckPassed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,13877,13900);

bool 
reasonSet = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,13918,15609) || true) && (f_1227_13922_13996(f_1227_13936_13948(fi), ".ps1xml", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,13918,15609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14038,14283);

string[] 
trustedDirectories = new string[]
                        { f_1227_14108_14164(Environment.SpecialFolder.System),
f_1227_14193_14255(Environment.SpecialFolder.ProgramFiles)                        }
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14307,14570);
foreach(string trustedDirectory in f_1227_14343_14361_I(trustedDirectories) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,14307,14570);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14411,14547) || true) && (f_1227_14415_14491(f_1227_14415_14426(fi), trustedDirectory, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,14411,14547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14522,14547);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,14411,14547);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,14307,14570);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1227,1,264);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1227,1,264);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14594,15590) || true) && (!policyCheckPassed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,14594,15590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14725,14791);

Signature 
signature = f_1227_14747_14790(this, path, script)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14889,15567) || true) && (f_1227_14893_14909(signature)== SignatureStatus.Valid)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,14889,15567);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,14992,15540) || true) && (f_1227_14996_15031(this, signature, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,14992,15540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,15097,15122);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,14992,15540);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,14992,15540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,15371,15458);

policyCheckPassed = f_1227_15391_15457(this, path, host, ref reason, signature);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,15492,15509);

reasonSet = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,14992,15540);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,14889,15567);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,14594,15590);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,13918,15609);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,15629,15883) || true) && (!policyCheckPassed &&(DynAbs.Tracing.TraceSender.Expression_True(1227, 15633, 15665)&&!reasonSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,15629,15883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,15707,15864);

reason = f_1227_15716_15863(f_1227_15774_15862(f_1227_15792_15826(), path));
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,15629,15883);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,11248,15898);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,11050,15898);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,7836,15898);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,15914,15939);

return policyCheckPassed;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,4496,15950);

string
f_1227_4694_4705(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 4694, 4705);
return return_v;
}


int
f_1227_4820_4871(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4820, 4871);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1227_4915_4957(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4915, 4957);
return return_v;
}


int
f_1227_4993_5048(string
this_param,char
value)
{
var return_v = this_param.LastIndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 4993, 5048);
return return_v;
}


int
f_1227_5053_5064(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 5053, 5064);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1227_5109_5151(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 5109, 5151);
return return_v;
}


System.IO.FileInfo
f_1227_5197_5215(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 5197, 5215);
return return_v;
}


bool
f_1227_5353_5363_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 5353, 5363);
return return_v;
}


System.IO.FileNotFoundException
f_1227_5406_5437(string
message)
{
var return_v = new System.IO.FileNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 5406, 5437);
return return_v;
}


string
f_1227_5587_5599(System.IO.FileInfo
this_param)
{
var return_v = this_param.Extension;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 5587, 5599);
return return_v;
}


bool
f_1227_5566_5600(string
ext)
{
var return_v = IsSupportedExtension( ext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 5566, 5600);
return return_v;
}


Microsoft.PowerShell.ExecutionPolicy
f_1227_5707_5751(string
shellId)
{
var return_v = SecuritySupport.GetExecutionPolicy( shellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 5707, 5751);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1227_6222_6260()
{
var return_v = SystemPolicy.GetSystemLockdownPolicy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 6222, 6260);
return return_v;
}


System.Management.Automation.Internal.SaferPolicy
f_1227_6735_6777(string
path,System.Runtime.InteropServices.SafeHandle
handle)
{
var return_v = SecuritySupport.GetSaferPolicy( path, handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 6735, 6777);
return return_v;
}


int
f_1227_7065_7099(int
millisecondsTimeout)
{
System.Threading.Thread.Sleep( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 7065, 7099);
return 0;
}


string
f_1227_7626_7663()
{
var return_v = Authenticode.Reason_DisallowedBySafer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 7626, 7663);
return return_v;
}


string
f_1227_7608_7670(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 7608, 7670);
return return_v;
}


System.UnauthorizedAccessException
f_1227_7702_7748(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 7702, 7748);
return return_v;
}


bool
f_1227_8049_8086(string
file)
{
var return_v = SecuritySupport.IsProductBinary( file);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 8049, 8086);
return return_v;
}


string
f_1227_8281_8292(System.IO.FileInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 8281, 8292);
return return_v;
}


bool
f_1227_8269_8293(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
filename)
{
var return_v = this_param.IsLocalFile( filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 8269, 8293);
return return_v;
}


string
f_1227_8415_8436(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.ScriptContents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 8415, 8436);
return return_v;
}


bool
f_1227_8394_8437(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 8394, 8437);
return return_v;
}


string
f_1227_8521_8563()
{
var return_v = Authenticode.Reason_FileContentUnavailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 8521, 8563);
return return_v;
}


string
f_1227_8503_8570(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 8503, 8570);
return return_v;
}


System.UnauthorizedAccessException
f_1227_8606_8652(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 8606, 8652);
return return_v;
}


System.Management.Automation.Signature
f_1227_8763_8806(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
path,System.Management.Automation.ExternalScriptInfo
script)
{
var return_v = this_param.GetSignatureWithEncodingRetry( path, script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 8763, 8806);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1227_8934_8950(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 8934, 8950);
return return_v;
}


bool
f_1227_9099_9134(Microsoft.PowerShell.PSAuthorizationManager
this_param,System.Management.Automation.Signature
signature,string
file)
{
var return_v = this_param.IsTrustedPublisher( signature, file);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 9099, 9134);
return return_v;
}


Microsoft.PowerShell.PSAuthorizationManager.RunPromptDecision
f_1227_9858_9886(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
path,System.Management.Automation.Host.PSHost
host)
{
var return_v = this_param.RemoteFilePrompt( path, host);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 9858, 9886);
return return_v;
}


int
f_1227_9995_10019(System.Management.Automation.Host.PSHost
this_param)
{
this_param.EnterNestedPrompt();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 9995, 10019);
return 0;
}


string
f_1227_10554_10582()
{
var return_v = Authenticode.Reason_DoNotRun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 10554, 10582);
return return_v;
}


string
f_1227_10536_10589(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 10536, 10589);
return return_v;
}


System.UnauthorizedAccessException
f_1227_10633_10679(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 10633, 10679);
return return_v;
}


string
f_1227_11067_11078(System.IO.FileInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 11067, 11078);
return return_v;
}


bool
f_1227_11055_11079(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
filename)
{
var return_v = this_param.IsLocalFile( filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 11055, 11079);
return return_v;
}


string
f_1227_11576_11597(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.ScriptContents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 11576, 11597);
return return_v;
}


bool
f_1227_11555_11598(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 11555, 11598);
return return_v;
}


string
f_1227_11674_11716()
{
var return_v = Authenticode.Reason_FileContentUnavailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 11674, 11716);
return return_v;
}


string
f_1227_11656_11723(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 11656, 11723);
return return_v;
}


System.UnauthorizedAccessException
f_1227_11755_11801(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 11755, 11801);
return return_v;
}


System.Management.Automation.Signature
f_1227_11900_11943(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
path,System.Management.Automation.ExternalScriptInfo
script)
{
var return_v = this_param.GetSignatureWithEncodingRetry( path, script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 11900, 11943);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1227_12008_12024(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 12008, 12024);
return return_v;
}


bool
f_1227_12161_12196(Microsoft.PowerShell.PSAuthorizationManager
this_param,System.Management.Automation.Signature
signature,string
file)
{
var return_v = this_param.IsTrustedPublisher( signature, file);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 12161, 12196);
return return_v;
}


bool
f_1227_12492_12558(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
path,System.Management.Automation.Host.PSHost
host,ref System.Exception
reason,System.Management.Automation.Signature
signature)
{
var return_v = this_param.SetPolicyFromAuthenticodePrompt( path, host, ref reason, signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 12492, 12558);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1227_12844_12860(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 12844, 12860);
return return_v;
}


string
f_1227_13029_13059()
{
var return_v = Authenticode.Reason_NotTrusted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 13029, 13059);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2
f_1227_13133_13160(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.SignerCertificate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 13133, 13160);
return return_v;
}


System.Security.Cryptography.X509Certificates.X500DistinguishedName
f_1227_13133_13172(System.Security.Cryptography.X509Certificates.X509Certificate2
this_param)
{
var return_v = this_param.SubjectName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 13133, 13172);
return return_v;
}


string
f_1227_13133_13177(System.Security.Cryptography.X509Certificates.X500DistinguishedName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 13133, 13177);
return return_v;
}


string
f_1227_13011_13178(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 13011, 13178);
return return_v;
}


System.UnauthorizedAccessException
f_1227_12949_13179(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 12949, 13179);
return return_v;
}


string
f_1227_13367_13394()
{
var return_v = Authenticode.Reason_Unknown;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 13367, 13394);
return return_v;
}


string
f_1227_13468_13491(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.StatusMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 13468, 13491);
return return_v;
}


string
f_1227_13349_13492(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 13349, 13492);
return return_v;
}


System.UnauthorizedAccessException
f_1227_13287_13493(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 13287, 13493);
return return_v;
}


string
f_1227_13936_13948(System.IO.FileInfo
this_param)
{
var return_v = this_param.Extension;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 13936, 13948);
return return_v;
}


bool
f_1227_13922_13996(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 13922, 13996);
return return_v;
}


string
f_1227_14108_14164(System.Environment.SpecialFolder
folder)
{
var return_v = Platform.GetFolderPath( folder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 14108, 14164);
return return_v;
}


string
f_1227_14193_14255(System.Environment.SpecialFolder
folder)
{
var return_v = Platform.GetFolderPath( folder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 14193, 14255);
return return_v;
}


string
f_1227_14415_14426(System.IO.FileInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 14415, 14426);
return return_v;
}


bool
f_1227_14415_14491(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 14415, 14491);
return return_v;
}


string[]
f_1227_14343_14361_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 14343, 14361);
return return_v;
}


System.Management.Automation.Signature
f_1227_14747_14790(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
path,System.Management.Automation.ExternalScriptInfo
script)
{
var return_v = this_param.GetSignatureWithEncodingRetry( path, script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 14747, 14790);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1227_14893_14909(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 14893, 14909);
return return_v;
}


bool
f_1227_14996_15031(Microsoft.PowerShell.PSAuthorizationManager
this_param,System.Management.Automation.Signature
signature,string
file)
{
var return_v = this_param.IsTrustedPublisher( signature, file);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 14996, 15031);
return return_v;
}


bool
f_1227_15391_15457(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
path,System.Management.Automation.Host.PSHost
host,ref System.Exception
reason,System.Management.Automation.Signature
signature)
{
var return_v = this_param.SetPolicyFromAuthenticodePrompt( path, host, ref reason, signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 15391, 15457);
return return_v;
}


string
f_1227_15792_15826()
{
var return_v = Authenticode.Reason_RestrictedMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 15792, 15826);
return return_v;
}


string
f_1227_15774_15862(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 15774, 15862);
return return_v;
}


System.UnauthorizedAccessException
f_1227_15716_15863(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 15716, 15863);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,4496,15950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,4496,15950);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool SetPolicyFromAuthenticodePrompt(string path, PSHost host, ref Exception reason, Signature signature)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,15962,17363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16100,16131);

bool 
policyCheckPassed = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16147,16168);

string 
reasonMessage
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16182,16253);

RunPromptDecision 
decision = f_1227_16211_16252(this, path, signature, host)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16269,17311);

switch (decision)
            {

case RunPromptDecision.RunOnce:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,16269,17311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16372,16397);

policyCheckPassed = true;
DynAbs.Tracing.TraceSender.TraceBreak(1227,16398,16404);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,16269,17311);

case RunPromptDecision.AlwaysRun:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,16269,17311);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16504,16530);

f_1227_16504_16529(this, signature);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16556,16581);

policyCheckPassed = true;
                    }DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16604,16605);
; DynAbs.Tracing.TraceSender.TraceBreak(1227,16606,16612);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,16269,17311);

case RunPromptDecision.DoNotRun:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,16269,17311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16684,16710);

policyCheckPassed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16732,16802);

reasonMessage = f_1227_16748_16801(f_1227_16766_16794(), path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,16824,16880);

reason = f_1227_16833_16879(reasonMessage);
DynAbs.Tracing.TraceSender.TraceBreak(1227,16902,16908);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,16269,17311);

case RunPromptDecision.NeverRun:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,16269,17311);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17007,17035);

f_1227_17007_17034(this, signature);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17061,17131);

reasonMessage = f_1227_17077_17130(f_1227_17095_17123(), path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17157,17213);

reason = f_1227_17166_17212(reasonMessage);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17239,17265);

policyCheckPassed = false;
                    }DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17288,17289);
; DynAbs.Tracing.TraceSender.TraceBreak(1227,17290,17296);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,16269,17311);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17327,17352);

return policyCheckPassed;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,15962,17363);

Microsoft.PowerShell.PSAuthorizationManager.RunPromptDecision
f_1227_16211_16252(Microsoft.PowerShell.PSAuthorizationManager
this_param,string
path,System.Management.Automation.Signature
signature,System.Management.Automation.Host.PSHost
host)
{
var return_v = this_param.AuthenticodePrompt( path, signature, host);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 16211, 16252);
return return_v;
}


int
f_1227_16504_16529(Microsoft.PowerShell.PSAuthorizationManager
this_param,System.Management.Automation.Signature
signature)
{
this_param.TrustPublisher( signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 16504, 16529);
return 0;
}


string
f_1227_16766_16794()
{
var return_v = Authenticode.Reason_DoNotRun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 16766, 16794);
return return_v;
}


string
f_1227_16748_16801(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 16748, 16801);
return return_v;
}


System.UnauthorizedAccessException
f_1227_16833_16879(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 16833, 16879);
return return_v;
}


int
f_1227_17007_17034(Microsoft.PowerShell.PSAuthorizationManager
this_param,System.Management.Automation.Signature
signature)
{
this_param.UntrustPublisher( signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 17007, 17034);
return 0;
}


string
f_1227_17095_17123()
{
var return_v = Authenticode.Reason_NeverRun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 17095, 17123);
return return_v;
}


string
f_1227_17077_17130(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 17077, 17130);
return return_v;
}


System.UnauthorizedAccessException
f_1227_17166_17212(string
message)
{
var return_v = new System.UnauthorizedAccessException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 17166, 17212);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,15962,17363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,15962,17363);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsLocalFile(string filename)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,17375,17803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17484,17544);

SecurityZone 
zone = f_1227_17504_17543(filename)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17560,17755) || true) && (zone == SecurityZone.MyComputer ||(DynAbs.Tracing.TraceSender.Expression_False(1227, 17564, 17645)||                zone == SecurityZone.Intranet )||(DynAbs.Tracing.TraceSender.Expression_False(1227, 17564, 17694)||                zone == SecurityZone.Trusted))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,17560,17755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17728,17740);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,17560,17755);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,17771,17784);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,17375,17803);

System.Security.SecurityZone
f_1227_17504_17543(string
filePath)
{
var return_v = ClrFacade.GetFileSecurityZone( filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 17504, 17543);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,17375,17803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,17375,17803);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsTrustedPublisher(Signature signature, string file)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,17929,18809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18079,18144);

X509Certificate2 
signerCertificate = f_1227_18116_18143(signature)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18158,18207);

string 
thumbprint = f_1227_18178_18206(signerCertificate)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18295,18394);

X509Store 
trustedPublishers = f_1227_18325_18393(StoreName.TrustedPublisher, StoreLocation.CurrentUser)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18408,18451);

f_1227_18408_18450(            trustedPublishers, OpenFlags.ReadOnly);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18467,18769);
foreach(X509Certificate2 trustedCertificate in f_1227_18515_18545_I(f_1227_18515_18545(trustedPublishers)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,18467,18769);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18579,18754) || true) && (f_1227_18583_18675(f_1227_18597_18626(trustedCertificate), thumbprint, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,18579,18754);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18698,18754) || true) && (!f_1227_18703_18740(this, signature, file))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,18698,18754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18742,18754);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,18698,18754);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,18579,18754);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,18467,18769);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1227,1,303);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1227,1,303);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18785,18798);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,17929,18809);

System.Security.Cryptography.X509Certificates.X509Certificate2
f_1227_18116_18143(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.SignerCertificate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 18116, 18143);
return return_v;
}


string
f_1227_18178_18206(System.Security.Cryptography.X509Certificates.X509Certificate2
this_param)
{
var return_v = this_param.Thumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 18178, 18206);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Store
f_1227_18325_18393(System.Security.Cryptography.X509Certificates.StoreName
storeName,System.Security.Cryptography.X509Certificates.StoreLocation
storeLocation)
{
var return_v = new System.Security.Cryptography.X509Certificates.X509Store( storeName, storeLocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 18325, 18393);
return return_v;
}


int
f_1227_18408_18450(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.OpenFlags
flags)
{
this_param.Open( flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 18408, 18450);
return 0;
}


System.Security.Cryptography.X509Certificates.X509Certificate2Collection
f_1227_18515_18545(System.Security.Cryptography.X509Certificates.X509Store
this_param)
{
var return_v = this_param.Certificates;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 18515, 18545);
return return_v;
}


string
f_1227_18597_18626(System.Security.Cryptography.X509Certificates.X509Certificate2
this_param)
{
var return_v = this_param.Thumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 18597, 18626);
return return_v;
}


bool
f_1227_18583_18675(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 18583, 18675);
return return_v;
}


bool
f_1227_18703_18740(Microsoft.PowerShell.PSAuthorizationManager
this_param,System.Management.Automation.Signature
signature,string
file)
{
var return_v = this_param.IsUntrustedPublisher( signature, file);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 18703, 18740);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2Collection
f_1227_18515_18545_I(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 18515, 18545);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,17929,18809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,17929,18809);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsUntrustedPublisher(Signature signature, string file)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,18821,19653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,18973,19038);

X509Certificate2 
signerCertificate = f_1227_19010_19037(signature)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19052,19101);

string 
thumbprint = f_1227_19072_19100(signerCertificate)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19189,19282);

X509Store 
trustedPublishers = f_1227_19219_19281(StoreName.Disallowed, StoreLocation.CurrentUser)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19296,19339);

f_1227_19296_19338(            trustedPublishers, OpenFlags.ReadOnly);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19355,19613);
foreach(X509Certificate2 trustedCertificate in f_1227_19403_19433_I(f_1227_19403_19433(trustedPublishers)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,19355,19613);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19467,19598) || true) && (f_1227_19471_19563(f_1227_19485_19514(trustedCertificate), thumbprint, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,19467,19598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19586,19598);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,19467,19598);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,19355,19613);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1227,1,259);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1227,1,259);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19629,19642);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,18821,19653);

System.Security.Cryptography.X509Certificates.X509Certificate2
f_1227_19010_19037(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.SignerCertificate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 19010, 19037);
return return_v;
}


string
f_1227_19072_19100(System.Security.Cryptography.X509Certificates.X509Certificate2
this_param)
{
var return_v = this_param.Thumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 19072, 19100);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Store
f_1227_19219_19281(System.Security.Cryptography.X509Certificates.StoreName
storeName,System.Security.Cryptography.X509Certificates.StoreLocation
storeLocation)
{
var return_v = new System.Security.Cryptography.X509Certificates.X509Store( storeName, storeLocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 19219, 19281);
return return_v;
}


int
f_1227_19296_19338(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.OpenFlags
flags)
{
this_param.Open( flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 19296, 19338);
return 0;
}


System.Security.Cryptography.X509Certificates.X509Certificate2Collection
f_1227_19403_19433(System.Security.Cryptography.X509Certificates.X509Store
this_param)
{
var return_v = this_param.Certificates;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 19403, 19433);
return return_v;
}


string
f_1227_19485_19514(System.Security.Cryptography.X509Certificates.X509Certificate2
this_param)
{
var return_v = this_param.Thumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 19485, 19514);
return return_v;
}


bool
f_1227_19471_19563(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 19471, 19563);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2Collection
f_1227_19403_19433_I(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 19403, 19433);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,18821,19653);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,18821,19653);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void TrustPublisher(Signature signature)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,19837,20475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,19960,20025);

X509Certificate2 
signerCertificate = f_1227_19997_20024(signature)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,20039,20138);

X509Store 
trustedPublishers = f_1227_20069_20137(StoreName.TrustedPublisher, StoreLocation.CurrentUser)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,20251,20295);

f_1227_20251_20294(                // Add it to the list of trusted publishers
                trustedPublishers, OpenFlags.ReadWrite);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,20313,20354);

f_1227_20313_20353(                trustedPublishers, signerCertificate);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1227,20383,20464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,20423,20449);

f_1227_20423_20448(                trustedPublishers);
DynAbs.Tracing.TraceSender.TraceExitFinally(1227,20383,20464);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,19837,20475);

System.Security.Cryptography.X509Certificates.X509Certificate2
f_1227_19997_20024(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.SignerCertificate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 19997, 20024);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Store
f_1227_20069_20137(System.Security.Cryptography.X509Certificates.StoreName
storeName,System.Security.Cryptography.X509Certificates.StoreLocation
storeLocation)
{
var return_v = new System.Security.Cryptography.X509Certificates.X509Store( storeName, storeLocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 20069, 20137);
return return_v;
}


int
f_1227_20251_20294(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.OpenFlags
flags)
{
this_param.Open( flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 20251, 20294);
return 0;
}


int
f_1227_20313_20353(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.X509Certificate2
certificate)
{
this_param.Add( certificate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 20313, 20353);
return 0;
}


int
f_1227_20423_20448(System.Security.Cryptography.X509Certificates.X509Store
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 20423, 20448);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,19837,20475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,19837,20475);
}
		}

private void UntrustPublisher(Signature signature)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,20487,21627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,20612,20677);

X509Certificate2 
signerCertificate = f_1227_20649_20676(signature)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,20691,20786);

X509Store 
untrustedPublishers = f_1227_20723_20785(StoreName.Disallowed, StoreLocation.CurrentUser)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,20800,20899);

X509Store 
trustedPublishers = f_1227_20830_20898(StoreName.TrustedPublisher, StoreLocation.CurrentUser)
;

            // Remove it from the list of trusted publishers
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21066,21110);

f_1227_21066_21109(                // Remove the signer, if it's there
                trustedPublishers, OpenFlags.ReadWrite);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21128,21172);

f_1227_21128_21171(                trustedPublishers, signerCertificate);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1227,21201,21282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21241,21267);

f_1227_21241_21266(                trustedPublishers);
DynAbs.Tracing.TraceSender.TraceExitFinally(1227,21201,21282);
            }

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21397,21443);

f_1227_21397_21442(                // Add it to the list of untrusted publishers
                untrustedPublishers, OpenFlags.ReadWrite);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21461,21504);

f_1227_21461_21503(                untrustedPublishers, signerCertificate);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1227,21533,21616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21573,21601);

f_1227_21573_21600(                untrustedPublishers);
DynAbs.Tracing.TraceSender.TraceExitFinally(1227,21533,21616);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,20487,21627);

System.Security.Cryptography.X509Certificates.X509Certificate2
f_1227_20649_20676(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.SignerCertificate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 20649, 20676);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Store
f_1227_20723_20785(System.Security.Cryptography.X509Certificates.StoreName
storeName,System.Security.Cryptography.X509Certificates.StoreLocation
storeLocation)
{
var return_v = new System.Security.Cryptography.X509Certificates.X509Store( storeName, storeLocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 20723, 20785);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Store
f_1227_20830_20898(System.Security.Cryptography.X509Certificates.StoreName
storeName,System.Security.Cryptography.X509Certificates.StoreLocation
storeLocation)
{
var return_v = new System.Security.Cryptography.X509Certificates.X509Store( storeName, storeLocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 20830, 20898);
return return_v;
}


int
f_1227_21066_21109(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.OpenFlags
flags)
{
this_param.Open( flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21066, 21109);
return 0;
}


int
f_1227_21128_21171(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.X509Certificate2
certificate)
{
this_param.Remove( certificate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21128, 21171);
return 0;
}


int
f_1227_21241_21266(System.Security.Cryptography.X509Certificates.X509Store
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21241, 21266);
return 0;
}


int
f_1227_21397_21442(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.OpenFlags
flags)
{
this_param.Open( flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21397, 21442);
return 0;
}


int
f_1227_21461_21503(System.Security.Cryptography.X509Certificates.X509Store
this_param,System.Security.Cryptography.X509Certificates.X509Certificate2
certificate)
{
this_param.Add( certificate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21461, 21503);
return 0;
}


int
f_1227_21573_21600(System.Security.Cryptography.X509Certificates.X509Store
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21573, 21600);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,20487,21627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,20487,21627);
}
		}

private Signature GetSignatureWithEncodingRetry(string path, ExternalScriptInfo script)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,21639,22651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21751,21883);

string 
verificationContents = f_1227_21781_21858(f_1227_21781_21809(), f_1227_21820_21857(f_1227_21820_21843(script)))+ f_1227_21861_21882(script)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,21897,21976);

Signature 
signature = f_1227_21919_21975(path, verificationContents)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,22089,22607) || true) && ((f_1227_22094_22110(signature)!= SignatureStatus.Valid) &&(DynAbs.Tracing.TraceSender.Expression_True(1227, 22093, 22197)&&(f_1227_22141_22164(script)!= f_1227_22168_22196())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,22089,22607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,22231,22361);

verificationContents = f_1227_22254_22336(f_1227_22254_22282(), f_1227_22293_22335(f_1227_22293_22321()))+ f_1227_22339_22360(script);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,22379,22466);

Signature 
fallbackSignature = f_1227_22409_22465(path, verificationContents)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,22486,22592) || true) && (f_1227_22490_22514(fallbackSignature)== SignatureStatus.Valid)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,22486,22592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,22562,22592);

signature = fallbackSignature;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,22486,22592);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,22089,22607);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,22623,22640);

return signature;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,21639,22651);

System.Text.Encoding
f_1227_21781_21809()
{
var return_v = System.Text.Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 21781, 21809);
return return_v;
}


System.Text.Encoding
f_1227_21820_21843(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.OriginalEncoding;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 21820, 21843);
return return_v;
}


byte[]
f_1227_21820_21857(System.Text.Encoding
this_param)
{
var return_v = this_param.GetPreamble();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21820, 21857);
return return_v;
}


string
f_1227_21781_21858(System.Text.Encoding
this_param,byte[]
bytes)
{
var return_v = this_param.GetString( bytes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21781, 21858);
return return_v;
}


string
f_1227_21861_21882(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.ScriptContents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 21861, 21882);
return return_v;
}


System.Management.Automation.Signature
f_1227_21919_21975(string
fileName,string
fileContent)
{
var return_v = SignatureHelper.GetSignature( fileName, fileContent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 21919, 21975);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1227_22094_22110(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 22094, 22110);
return return_v;
}


System.Text.Encoding
f_1227_22141_22164(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.OriginalEncoding ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 22141, 22164);
return return_v;
}


System.Text.Encoding
f_1227_22168_22196()
{
var return_v = System.Text.Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 22168, 22196);
return return_v;
}


System.Text.Encoding
f_1227_22254_22282()
{
var return_v = System.Text.Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 22254, 22282);
return return_v;
}


System.Text.Encoding
f_1227_22293_22321()
{
var return_v = System.Text.Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 22293, 22321);
return return_v;
}


byte[]
f_1227_22293_22335(System.Text.Encoding
this_param)
{
var return_v = this_param.GetPreamble();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 22293, 22335);
return return_v;
}


string
f_1227_22254_22336(System.Text.Encoding
this_param,byte[]
bytes)
{
var return_v = this_param.GetString( bytes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 22254, 22336);
return return_v;
}


string
f_1227_22339_22360(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.ScriptContents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 22339, 22360);
return return_v;
}


System.Management.Automation.Signature
f_1227_22409_22465(string
fileName,string
fileContent)
{
var return_v = SignatureHelper.GetSignature( fileName, fileContent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 22409, 22465);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1227_22490_22514(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 22490, 22514);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,21639,22651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,21639,22651);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected internal override bool ShouldRun(CommandInfo commandInfo,
                                                   CommandOrigin origin,
                                                   PSHost host,
                                                   out Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,23976,26837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,24281,24365);

f_1227_24281_24364(commandInfo != null, "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,24381,24403);

bool 
allowRun = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,24417,24431);

reason = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,24445,24495);

f_1227_24445_24494(commandInfo, "commandInfo");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,24509,24576);

f_1227_24509_24575(f_1227_24538_24554(commandInfo), "commandInfo.Name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,24592,26794);

switch (f_1227_24600_24623(commandInfo))
            {

case CommandTypes.Cmdlet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,24592,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,24756,24772);

allowRun = true;
DynAbs.Tracing.TraceSender.TraceBreak(1227,24794,24800);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,24592,26794);

case CommandTypes.Alias:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,24592,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,25109,25125);

allowRun = true;
DynAbs.Tracing.TraceSender.TraceBreak(1227,25147,25153);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,24592,26794);

case CommandTypes.Function:
                case CommandTypes.Filter:
                case CommandTypes.Configuration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,24592,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,25482,25498);

allowRun = true;
DynAbs.Tracing.TraceSender.TraceBreak(1227,25520,25526);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,24592,26794);

case CommandTypes.Script:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,24592,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,25758,25774);

allowRun = true;
DynAbs.Tracing.TraceSender.TraceBreak(1227,25796,25802);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,24592,26794);

case CommandTypes.ExternalScript:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,24592,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,25877,25935);

ExternalScriptInfo 
si = commandInfo as ExternalScriptInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,25957,26506) || true) && (si == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,25957,26506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26021,26079);

reason = f_1227_26030_26078("scriptInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,25957,26506);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,25957,26506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26177,26229);

bool 
etwEnabled = f_1227_26195_26228(ParserEventSource.Log)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26255,26321) || true) && (etwEnabled)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,26255,26321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26271,26321);

f_1227_26271_26320(ParserEventSource.Log, f_1227_26312_26319(si));
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,26255,26321);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26347,26392);

allowRun = f_1227_26358_26391(this, si, host, out reason);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26418,26483) || true) && (etwEnabled)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,26418,26483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26434,26483);

f_1227_26434_26482(ParserEventSource.Log, f_1227_26474_26481(si));
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,26418,26483);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,25957,26506);
}
DynAbs.Tracing.TraceSender.TraceBreak(1227,26530,26536);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,24592,26794);

case CommandTypes.Application:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,24592,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26735,26751);

allowRun = true;
DynAbs.Tracing.TraceSender.TraceBreak(1227,26773,26779);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,24592,26794);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,26810,26826);

return allowRun;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,23976,26837);

int
f_1227_24281_24364(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 24281, 24364);
return 0;
}


int
f_1227_24445_24494(System.Management.Automation.CommandInfo
arg,string
argName)
{
Utils.CheckArgForNull( (object)arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 24445, 24494);
return 0;
}


string
f_1227_24538_24554(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 24538, 24554);
return return_v;
}


int
f_1227_24509_24575(string
arg,string
argName)
{
Utils.CheckArgForNullOrEmpty( arg, argName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 24509, 24575);
return 0;
}


System.Management.Automation.CommandTypes
f_1227_24600_24623(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 24600, 24623);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1227_26030_26078(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 26030, 26078);
return return_v;
}


bool
f_1227_26195_26228(System.Management.Automation.Language.ParserEventSource
this_param)
{
var return_v = this_param.IsEnabled();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 26195, 26228);
return return_v;
}


string
f_1227_26312_26319(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 26312, 26319);
return return_v;
}


int
f_1227_26271_26320(System.Management.Automation.Language.ParserEventSource
this_param,string
FileName)
{
this_param.CheckSecurityStart( FileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 26271, 26320);
return 0;
}


bool
f_1227_26358_26391(Microsoft.PowerShell.PSAuthorizationManager
this_param,System.Management.Automation.ExternalScriptInfo
script,System.Management.Automation.Host.PSHost
host,out System.Exception
reason)
{
var return_v = this_param.CheckPolicy( script, host, out reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 26358, 26391);
return return_v;
}


string
f_1227_26474_26481(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 26474, 26481);
return return_v;
}


int
f_1227_26434_26482(System.Management.Automation.Language.ParserEventSource
this_param,string
FileName)
{
this_param.CheckSecurityStop( FileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 26434, 26482);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,23976,26837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,23976,26837);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RunPromptDecision AuthenticodePrompt(string path,
                                                Signature signature,
                                                PSHost host)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,26849,29541);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27063,27185) || true) && ((host == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1227, 27067, 27102)||(f_1227_27086_27093(host)== null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,27063,27185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27136,27170);

return RunPromptDecision.DoNotRun;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,27063,27185);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27201,27257);

RunPromptDecision 
decision = RunPromptDecision.DoNotRun
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27273,27359) || true) && (signature == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,27273,27359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27328,27344);

return decision;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,27273,27359);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27375,29498);

switch (f_1227_27383_27399(signature))
            {

case SignatureStatus.UnknownError:
                case SignatureStatus.NotSigned:
                case SignatureStatus.HashMismatch:
                case SignatureStatus.NotSupportedFileFormat:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,27375,29498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27792,27830);

decision = RunPromptDecision.DoNotRun;
DynAbs.Tracing.TraceSender.TraceBreak(1227,27852,27858);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,27375,29498);

case SignatureStatus.Valid:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,27375,29498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,27927,27998);

Collection<ChoiceDescription> 
choices = f_1227_27967_27997(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,28022,28109);

string 
promptCaption =
f_1227_28070_28108()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,28133,28151);

string 
promptText
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,28175,28783) || true) && (f_1227_28179_28206(signature)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,28175,28783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,28264,28417);

promptText =
f_1227_28306_28416(f_1227_28324_28376(), path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,28175,28783);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,28175,28783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,28515,28760);

promptText =
f_1227_28557_28759(f_1227_28575_28610(), path, f_1227_28684_28728(f_1227_28684_28723(f_1227_28684_28711(signature))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,28175,28783);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,28807,29101);

int 
userChoice =
f_1227_28849_29100(f_1227_28849_28856(host), promptCaption, promptText, choices, RunPromptDecision.DoNotRun)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29123,29164);

decision = (RunPromptDecision)userChoice;
DynAbs.Tracing.TraceSender.TraceBreak(1227,29188,29194);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,27375,29498);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,27375,29498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29417,29455);

decision = RunPromptDecision.DoNotRun;
DynAbs.Tracing.TraceSender.TraceBreak(1227,29477,29483);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,27375,29498);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29514,29530);

return decision;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,26849,29541);

System.Management.Automation.Host.PSHostUserInterface
f_1227_27086_27093(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 27086, 27093);
return return_v;
}


System.Management.Automation.SignatureStatus
f_1227_27383_27399(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.Status;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 27383, 27399);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
f_1227_27967_27997(Microsoft.PowerShell.PSAuthorizationManager
this_param)
{
var return_v = this_param.GetAuthenticodePromptChoices();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 27967, 27997);
return return_v;
}


string
f_1227_28070_28108()
{
var return_v =                         Authenticode.AuthenticodePromptCaption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28070, 28108);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2
f_1227_28179_28206(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.SignerCertificate ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28179, 28206);
return return_v;
}


string
f_1227_28324_28376()
{
var return_v = Authenticode.AuthenticodePromptText_UnknownPublisher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28324, 28376);
return return_v;
}


string
f_1227_28306_28416(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 28306, 28416);
return return_v;
}


string
f_1227_28575_28610()
{
var return_v = Authenticode.AuthenticodePromptText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28575, 28610);
return return_v;
}


System.Security.Cryptography.X509Certificates.X509Certificate2
f_1227_28684_28711(System.Management.Automation.Signature
this_param)
{
var return_v = this_param.SignerCertificate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28684, 28711);
return return_v;
}


System.Security.Cryptography.X509Certificates.X500DistinguishedName
f_1227_28684_28723(System.Security.Cryptography.X509Certificates.X509Certificate2
this_param)
{
var return_v = this_param.SubjectName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28684, 28723);
return return_v;
}


string
f_1227_28684_28728(System.Security.Cryptography.X509Certificates.X500DistinguishedName
this_param)
{
var return_v = this_param.Name
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28684, 28728);
return return_v;
}


string
f_1227_28557_28759(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 28557, 28759);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1227_28849_28856(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 28849, 28856);
return return_v;
}


int
f_1227_28849_29100(System.Management.Automation.Host.PSHostUserInterface
this_param,string
caption,string
message,System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,Microsoft.PowerShell.PSAuthorizationManager.RunPromptDecision
defaultChoice)
{
var return_v = this_param.PromptForChoice( caption, message, choices, (int)defaultChoice);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 28849, 29100);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,26849,29541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,26849,29541);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RunPromptDecision RemoteFilePrompt(string path, PSHost host)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,29553,30633);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29646,29768) || true) && ((host == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1227, 29650, 29685)||(f_1227_29669_29676(host)== null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,29646,29768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29719,29753);

return RunPromptDecision.DoNotRun;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,29646,29768);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29784,29853);

Collection<ChoiceDescription> 
choices = f_1227_29824_29852(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29869,29946);

string 
promptCaption =
f_1227_29909_29945()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,29962,30087);

string 
promptText =
f_1227_30003_30086(f_1227_30021_30054(), path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30103,30318);

int 
userChoice = f_1227_30120_30317(f_1227_30120_30127(host), promptCaption, promptText, choices, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30334,30622);

switch (userChoice)
            {

case 0: DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,30334,30622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30394,30428);

return RunPromptDecision.DoNotRun;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,30334,30622);

case 1: DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,30334,30622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30454,30487);

return RunPromptDecision.RunOnce;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,30334,30622);

case 2: DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,30334,30622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30513,30546);

return RunPromptDecision.Suspend;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,30334,30622);

default: DynAbs.Tracing.TraceSender.TraceEnterCondition(1227,30334,30622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30573,30607);

return RunPromptDecision.DoNotRun;
DynAbs.Tracing.TraceSender.TraceExitCondition(1227,30334,30622);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,29553,30633);

System.Management.Automation.Host.PSHostUserInterface
f_1227_29669_29676(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 29669, 29676);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
f_1227_29824_29852(Microsoft.PowerShell.PSAuthorizationManager
this_param)
{
var return_v = this_param.GetRemoteFilePromptChoices();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 29824, 29852);
return return_v;
}


string
f_1227_29909_29945()
{
var return_v =                 Authenticode.RemoteFilePromptCaption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 29909, 29945);
return return_v;
}


string
f_1227_30021_30054()
{
var return_v = Authenticode.RemoteFilePromptText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 30021, 30054);
return return_v;
}


string
f_1227_30003_30086(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 30003, 30086);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1227_30120_30127(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 30120, 30127);
return return_v;
}


int
f_1227_30120_30317(System.Management.Automation.Host.PSHostUserInterface
this_param,string
caption,string
message,System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,int
defaultChoice)
{
var return_v = this_param.PromptForChoice( caption, message, choices, defaultChoice);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 30120, 30317);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,29553,30633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,29553,30633);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Collection<ChoiceDescription> GetAuthenticodePromptChoices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,30645,31676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30738,30814);

Collection<ChoiceDescription> 
choices = f_1227_30778_30813()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30830,30877);

string 
neverRun = f_1227_30848_30876()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30891,30947);

string 
neverRunHelp = f_1227_30913_30946()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,30961,31008);

string 
doNotRun = f_1227_30979_31007()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31022,31078);

string 
doNotRunHelp = f_1227_31044_31077()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31092,31137);

string 
runOnce = f_1227_31109_31136()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31151,31205);

string 
runOnceHelp = f_1227_31172_31204()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31219,31268);

string 
alwaysRun = f_1227_31238_31267()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31282,31340);

string 
alwaysRunHelp = f_1227_31305_31339()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31356,31415);

f_1227_31356_31414(
            choices, f_1227_31368_31413(neverRun, neverRunHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31429,31488);

f_1227_31429_31487(            choices, f_1227_31441_31486(doNotRun, doNotRunHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31502,31559);

f_1227_31502_31558(            choices, f_1227_31514_31557(runOnce, runOnceHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31573,31634);

f_1227_31573_31633(            choices, f_1227_31585_31632(alwaysRun, alwaysRunHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31650,31665);

return choices;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,30645,31676);

System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
f_1227_30778_30813()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 30778, 30813);
return return_v;
}


string
f_1227_30848_30876()
{
var return_v = Authenticode.Choice_NeverRun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 30848, 30876);
return return_v;
}


string
f_1227_30913_30946()
{
var return_v = Authenticode.Choice_NeverRun_Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 30913, 30946);
return return_v;
}


string
f_1227_30979_31007()
{
var return_v = Authenticode.Choice_DoNotRun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 30979, 31007);
return return_v;
}


string
f_1227_31044_31077()
{
var return_v = Authenticode.Choice_DoNotRun_Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 31044, 31077);
return return_v;
}


string
f_1227_31109_31136()
{
var return_v = Authenticode.Choice_RunOnce;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 31109, 31136);
return return_v;
}


string
f_1227_31172_31204()
{
var return_v = Authenticode.Choice_RunOnce_Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 31172, 31204);
return return_v;
}


string
f_1227_31238_31267()
{
var return_v = Authenticode.Choice_AlwaysRun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 31238, 31267);
return return_v;
}


string
f_1227_31305_31339()
{
var return_v = Authenticode.Choice_AlwaysRun_Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 31305, 31339);
return return_v;
}


System.Management.Automation.Host.ChoiceDescription
f_1227_31368_31413(string
label,string
helpMessage)
{
var return_v = new System.Management.Automation.Host.ChoiceDescription( label, helpMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31368, 31413);
return return_v;
}


int
f_1227_31356_31414(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,System.Management.Automation.Host.ChoiceDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31356, 31414);
return 0;
}


System.Management.Automation.Host.ChoiceDescription
f_1227_31441_31486(string
label,string
helpMessage)
{
var return_v = new System.Management.Automation.Host.ChoiceDescription( label, helpMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31441, 31486);
return return_v;
}


int
f_1227_31429_31487(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,System.Management.Automation.Host.ChoiceDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31429, 31487);
return 0;
}


System.Management.Automation.Host.ChoiceDescription
f_1227_31514_31557(string
label,string
helpMessage)
{
var return_v = new System.Management.Automation.Host.ChoiceDescription( label, helpMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31514, 31557);
return return_v;
}


int
f_1227_31502_31558(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,System.Management.Automation.Host.ChoiceDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31502, 31558);
return 0;
}


System.Management.Automation.Host.ChoiceDescription
f_1227_31585_31632(string
label,string
helpMessage)
{
var return_v = new System.Management.Automation.Host.ChoiceDescription( label, helpMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31585, 31632);
return return_v;
}


int
f_1227_31573_31633(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,System.Management.Automation.Host.ChoiceDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31573, 31633);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,30645,31676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,30645,31676);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Collection<ChoiceDescription> GetRemoteFilePromptChoices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1227,31688,32501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31779,31855);

Collection<ChoiceDescription> 
choices = f_1227_31819_31854()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31871,31918);

string 
doNotRun = f_1227_31889_31917()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,31932,31988);

string 
doNotRunHelp = f_1227_31954_31987()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32002,32047);

string 
runOnce = f_1227_32019_32046()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32061,32115);

string 
runOnceHelp = f_1227_32082_32114()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32129,32174);

string 
suspend = f_1227_32146_32173()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32188,32242);

string 
suspendHelp = f_1227_32209_32241()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32258,32317);

f_1227_32258_32316(
            choices, f_1227_32270_32315(doNotRun, doNotRunHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32331,32388);

f_1227_32331_32387(            choices, f_1227_32343_32386(runOnce, runOnceHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32402,32459);

f_1227_32402_32458(            choices, f_1227_32414_32457(suspend, suspendHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1227,32475,32490);

return choices;
DynAbs.Tracing.TraceSender.TraceExitMethod(1227,31688,32501);

System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
f_1227_31819_31854()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 31819, 31854);
return return_v;
}


string
f_1227_31889_31917()
{
var return_v = Authenticode.Choice_DoNotRun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 31889, 31917);
return return_v;
}


string
f_1227_31954_31987()
{
var return_v = Authenticode.Choice_DoNotRun_Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 31954, 31987);
return return_v;
}


string
f_1227_32019_32046()
{
var return_v = Authenticode.Choice_RunOnce;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 32019, 32046);
return return_v;
}


string
f_1227_32082_32114()
{
var return_v = Authenticode.Choice_RunOnce_Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 32082, 32114);
return return_v;
}


string
f_1227_32146_32173()
{
var return_v = Authenticode.Choice_Suspend;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 32146, 32173);
return return_v;
}


string
f_1227_32209_32241()
{
var return_v = Authenticode.Choice_Suspend_Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1227, 32209, 32241);
return return_v;
}


System.Management.Automation.Host.ChoiceDescription
f_1227_32270_32315(string
label,string
helpMessage)
{
var return_v = new System.Management.Automation.Host.ChoiceDescription( label, helpMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 32270, 32315);
return return_v;
}


int
f_1227_32258_32316(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,System.Management.Automation.Host.ChoiceDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 32258, 32316);
return 0;
}


System.Management.Automation.Host.ChoiceDescription
f_1227_32343_32386(string
label,string
helpMessage)
{
var return_v = new System.Management.Automation.Host.ChoiceDescription( label, helpMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 32343, 32386);
return return_v;
}


int
f_1227_32331_32387(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,System.Management.Automation.Host.ChoiceDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 32331, 32387);
return 0;
}


System.Management.Automation.Host.ChoiceDescription
f_1227_32414_32457(string
label,string
helpMessage)
{
var return_v = new System.Management.Automation.Host.ChoiceDescription( label, helpMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 32414, 32457);
return return_v;
}


int
f_1227_32402_32458(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,System.Management.Automation.Host.ChoiceDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 32402, 32458);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1227,31688,32501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,31688,32501);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static PSAuthorizationManager()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1227,2668,32508);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1227,2668,32508);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1227,2668,32508);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1227,2668,32508);

bool
f_1227_3630_3659(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 3630, 3659);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1227_3699_3748(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1227, 3699, 3748);
return return_v;
}


static string
f_1227_3593_3600_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1227, 3527, 3810);
return return_v;
}

}
}

