// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Security;

using Microsoft.Win32;

namespace Microsoft.PowerShell
{
internal partial
    class ConsoleHostUserInterface : System.Management.Automation.Host.PSHostUserInterface
{
public override PSCredential PromptForCredential(
            string caption,
            string message,
            string userName,
            string targetName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(118,1318,1858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,1512,1847);

return f_118_1519_1846(this, caption, message, userName, targetName, PSCredentialTypes.Default, PSCredentialUIOptions.Default);
DynAbs.Tracing.TraceSender.TraceExitMethod(118,1318,1858);

System.Management.Automation.PSCredential
f_118_1519_1846(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
caption,string
message,string
userName,string
targetName,System.Management.Automation.PSCredentialTypes
allowedCredentialTypes,System.Management.Automation.PSCredentialUIOptions
options)
{
var return_v = this_param.PromptForCredential( caption, message, userName, targetName, allowedCredentialTypes, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 1519, 1846);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118,1318,1858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118,1318,1858);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override PSCredential PromptForCredential(
            string caption,
            string message,
            string userName,
            string targetName,
            PSCredentialTypes allowedCredentialTypes,
            PSCredentialUIOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(118,2700,4735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,2993,3018);

PSCredential 
cred = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3032,3061);

SecureString 
password = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3075,3100);

string 
userPrompt = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3114,3143);

string 
passwordPrompt = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3159,3417) || true) && (!f_118_3164_3193(caption))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(118,3159,3417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3273,3294);

f_118_3273_3293(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3312,3402);

f_118_3312_3401(this, f_118_3331_3342(), f_118_3344_3365(f_118_3344_3349()), f_118_3367_3400(this, caption));
DynAbs.Tracing.TraceSender.TraceExitCondition(118,3159,3417);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3433,3570) || true) && (!f_118_3438_3467(message))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(118,3433,3570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3501,3555);

f_118_3501_3554(this, f_118_3520_3553(this, message));
DynAbs.Tracing.TraceSender.TraceExitCondition(118,3433,3570);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3586,4177) || true) && (f_118_3590_3620(userName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(118,3586,4177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3654,3734);

userPrompt = f_118_3667_3733();
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(118,3849,4162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3892,3925);

f_118_3892_3924(this, userPrompt, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3947,3969);

userName = f_118_3958_3968(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3991,4096) || true) && (userName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(118,3991,4096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4061,4073);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(118,3991,4096);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(118,3849,4162);
}
                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,3849,4162) || true) && (f_118_4140_4155(userName)== 0)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(118,3849,4162);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(118,3849,4162);
}}DynAbs.Tracing.TraceSender.TraceExitCondition(118,3586,4177);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4193,4324);

passwordPrompt = f_118_4210_4323(f_118_4228_4298(), userName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4417,4454);

f_118_4417_4453(this, passwordPrompt, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4468,4504);

password = f_118_4479_4503(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4518,4599) || true) && (password == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(118,4518,4599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4572,4584);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(118,4518,4599);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4615,4636);

f_118_4615_4635(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4652,4696);

cred = f_118_4659_4695(userName, password);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(118,4712,4724);

return cred;
DynAbs.Tracing.TraceSender.TraceExitMethod(118,2700,4735);

bool
f_118_3164_3193(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3164, 3193);
return return_v;
}


int
f_118_3273_3293(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3273, 3293);
return 0;
}


System.ConsoleColor
f_118_3331_3342()
{
var return_v = PromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 3331, 3342);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_118_3344_3349()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 3344, 3349);
return return_v;
}


System.ConsoleColor
f_118_3344_3365(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 3344, 3365);
return return_v;
}


string
f_118_3367_3400(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3367, 3400);
return return_v;
}


int
f_118_3312_3401(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
text)
{
this_param.WriteLineToConsole( foregroundColor, backgroundColor, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3312, 3401);
return 0;
}


bool
f_118_3438_3467(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3438, 3467);
return return_v;
}


string
f_118_3520_3553(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3520, 3553);
return return_v;
}


int
f_118_3501_3554(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3501, 3554);
return 0;
}


bool
f_118_3590_3620(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3590, 3620);
return return_v;
}


string
f_118_3667_3733()
{
var return_v = ConsoleHostUserInterfaceSecurityResources.PromptForCredential_User;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 3667, 3733);
return return_v;
}


int
f_118_3892_3924(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3892, 3924);
return 0;
}


string
f_118_3958_3968(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
var return_v = this_param.ReadLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3958, 3968);
return return_v;
}


int
f_118_4140_4155(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 4140, 4155);
return return_v;
}


string
f_118_4228_4298()
{
var return_v = ConsoleHostUserInterfaceSecurityResources.PromptForCredential_Password;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 4228, 4298);
return return_v;
}


string
f_118_4210_4323(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4210, 4323);
return return_v;
}


int
f_118_4417_4453(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4417, 4453);
return 0;
}


System.Security.SecureString
f_118_4479_4503(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
var return_v = this_param.ReadLineAsSecureString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4479, 4503);
return return_v;
}


int
f_118_4615_4635(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4615, 4635);
return 0;
}


System.Management.Automation.PSCredential
f_118_4659_4695(string
userName,System.Security.SecureString
password)
{
var return_v = new System.Management.Automation.PSCredential( userName, password);
DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4659, 4695);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118,2700,4735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118,2700,4735);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}

