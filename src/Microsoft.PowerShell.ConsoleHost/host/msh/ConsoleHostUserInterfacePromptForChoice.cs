// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Text;

using Dbg = System.Management.Automation.Diagnostics;
using ConsoleHandle = Microsoft.Win32.SafeHandles.SafeFileHandle;
using NakedWin32Handle = System.IntPtr;

namespace Microsoft.PowerShell
{
internal partial class ConsoleHostUserInterface : PSHostUserInterface, IHostUISupportsMultipleChoiceSelection
{
public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,1601,5509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,1751,1780);

f_117_1751_1779(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,1796,1920) || true) && (choices == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,1796,1920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,1849,1905);

throw f_117_1855_1904("choices");
DynAbs.Tracing.TraceSender.TraceExitCondition(117,1796,1920);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,1936,2150) || true) && (f_117_1940_1953(choices)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,1936,2150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,1992,2135);

throw f_117_1998_2134("choices", f_117_2065_2122(), "choices");
DynAbs.Tracing.TraceSender.TraceExitCondition(117,1936,2150);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,2166,2473) || true) && ((defaultChoice < -1) ||(DynAbs.Tracing.TraceSender.Expression_False(117, 2170, 2226)||(defaultChoice >= f_117_2212_2225(choices))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,2166,2473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,2260,2458);

throw f_117_2266_2457("defaultChoice", defaultChoice, f_117_2364_2429(), "defaultChoice", "choice");
DynAbs.Tracing.TraceSender.TraceExitCondition(117,2166,2473);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,2603,2616);

            // we lock here so that multiple threads won't interleave the various reads and writes here.

            lock (_instanceLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,2650,2928) || true) && (!f_117_2655_2684(caption))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,2650,2928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,2776,2797);

f_117_2776_2796(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,2819,2909);

f_117_2819_2908(this, f_117_2838_2849(), f_117_2851_2872(f_117_2851_2856()), f_117_2874_2907(this, caption));
DynAbs.Tracing.TraceSender.TraceExitCondition(117,2650,2928);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,2948,3097) || true) && (!f_117_2953_2982(message))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,2948,3097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3024,3078);

f_117_3024_3077(this, f_117_3043_3076(this, message));
DynAbs.Tracing.TraceSender.TraceExitCondition(117,2948,3097);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3117,3144);

int 
result = defaultChoice
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3164,3203);

string[,] 
hotkeysAndPlainLabels = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3221,3304);

f_117_3221_3303(choices, out hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3324,3394);

Dictionary<int, bool> 
defaultChoiceKeys = f_117_3366_3393()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3534,3660) || true) && (defaultChoice >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,3534,3660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3598,3641);

f_117_3598_3640(                    defaultChoiceKeys, defaultChoice, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,3534,3660);
}
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,3680,5449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3723,3790);

f_117_3723_3789(this, hotkeysAndPlainLabels, defaultChoiceKeys, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3814,3838);

ReadLineResult 
rlResult
=default(ReadLineResult);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3860,3911);

string 
response = f_117_3878_3910(this, out rlResult)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3935,4322) || true) && (rlResult == ReadLineResult.endedOnBreak)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,3935,4322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4028,4093);

string 
msg = f_117_4041_4092()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4119,4265);

PromptingException 
e = f_117_4142_4264(msg, null, "PromptForChoiceCanceled", ErrorCategory.OperationStopped)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4291,4299);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,3935,4322);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4346,4768) || true) && (f_117_4350_4365(response)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,4346,4768);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4471,4708) || true) && (defaultChoice >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,4471,4708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4622,4645);

result = defaultChoice;
DynAbs.Tracing.TraceSender.TraceBreak(117,4675,4681);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,4471,4708);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4736,4745);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,4346,4768);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4849,5074) || true) && (f_117_4853_4868(response)== "?")
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,4849,5074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,4969,5016);

f_117_4969_5015(this, choices, hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,5042,5051);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,4849,5074);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,5098,5198);

result = f_117_5107_5197(f_117_5149_5164(response), choices, hotkeysAndPlainLabels);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,5222,5316) || true) && (result >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,5222,5316);
DynAbs.Tracing.TraceSender.TraceBreak(117,5287,5293);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,5222,5316);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(117,3680,5449);
}
                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,3680,5449) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(117,3680,5449);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(117,3680,5449);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,5469,5483);

return result;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(117,1601,5509);

int
f_117_1751_1779(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.HandleThrowOnReadAndPrompt();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 1751, 1779);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_117_1855_1904(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 1855, 1904);
return return_v;
}


int
f_117_1940_1953(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 1940, 1953);
return return_v;
}


string
f_117_2065_2122()
{
var return_v =                     ConsoleHostUserInterfaceStrings.EmptyChoicesErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 2065, 2122);
return return_v;
}


System.Management.Automation.PSArgumentException
f_117_1998_2134(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 1998, 2134);
return return_v;
}


int
f_117_2212_2225(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 2212, 2225);
return return_v;
}


string
f_117_2364_2429()
{
var return_v =                     ConsoleHostUserInterfaceStrings.InvalidDefaultChoiceErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 2364, 2429);
return return_v;
}


System.Management.Automation.PSArgumentOutOfRangeException
f_117_2266_2457(string
paramName,int
actualValue,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentOutOfRangeException( paramName, (object)actualValue, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 2266, 2457);
return return_v;
}


bool
f_117_2655_2684(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 2655, 2684);
return return_v;
}


int
f_117_2776_2796(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 2776, 2796);
return 0;
}


System.ConsoleColor
f_117_2838_2849()
{
var return_v = PromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 2838, 2849);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_117_2851_2856()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 2851, 2856);
return return_v;
}


System.ConsoleColor
f_117_2851_2872(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 2851, 2872);
return return_v;
}


string
f_117_2874_2907(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 2874, 2907);
return return_v;
}


int
f_117_2819_2908(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
text)
{
this_param.WriteLineToConsole( foregroundColor, backgroundColor, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 2819, 2908);
return 0;
}


bool
f_117_2953_2982(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 2953, 2982);
return return_v;
}


string
f_117_3043_3076(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3043, 3076);
return return_v;
}


int
f_117_3024_3077(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3024, 3077);
return 0;
}


int
f_117_3221_3303(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,out string[,]
hotkeysAndPlainLabels)
{
HostUIHelperMethods.BuildHotkeysAndPlainLabels( choices, out hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3221, 3303);
return 0;
}


System.Collections.Generic.Dictionary<int, bool>
f_117_3366_3393()
{
var return_v = new System.Collections.Generic.Dictionary<int, bool>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3366, 3393);
return return_v;
}


int
f_117_3598_3640(System.Collections.Generic.Dictionary<int, bool>
this_param,int
key,bool
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3598, 3640);
return 0;
}


int
f_117_3723_3789(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string[,]
hotkeysAndPlainLabels,System.Collections.Generic.Dictionary<int, bool>
defaultChoiceKeys,bool
shouldEmulateForMultipleChoiceSelection)
{
this_param.WriteChoicePrompt( hotkeysAndPlainLabels, defaultChoiceKeys, shouldEmulateForMultipleChoiceSelection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3723, 3789);
return 0;
}


string
f_117_3878_3910(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,out Microsoft.PowerShell.ConsoleHostUserInterface.ReadLineResult
result)
{
var return_v = this_param.ReadChoiceResponse( out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 3878, 3910);
return return_v;
}


string
f_117_4041_4092()
{
var return_v = ConsoleHostUserInterfaceStrings.PromptCanceledError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 4041, 4092);
return return_v;
}


System.Management.Automation.Host.PromptingException
f_117_4142_4264(string
message,System.Exception
innerException,string
errorId,System.Management.Automation.ErrorCategory
errorCategory)
{
var return_v = new System.Management.Automation.Host.PromptingException( message, innerException, errorId, errorCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 4142, 4264);
return return_v;
}


int
f_117_4350_4365(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 4350, 4365);
return return_v;
}


string
f_117_4853_4868(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 4853, 4868);
return return_v;
}


int
f_117_4969_5015(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,string[,]
hotkeysAndPlainLabels)
{
this_param.ShowChoiceHelp( choices, hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 4969, 5015);
return 0;
}


string
f_117_5149_5164(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 5149, 5164);
return return_v;
}


int
f_117_5107_5197(string
response,System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,string[,]
hotkeysAndPlainLabels)
{
var return_v = HostUIHelperMethods.DetermineChoicePicked( response, choices, hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 5107, 5197);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,1601,5509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,1601,5509);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Collection<int> PromptForChoice(string caption,
            string message,
            Collection<ChoiceDescription> choices,
            IEnumerable<int> defaultChoices)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,6520,11927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,6726,6755);

f_117_6726_6754(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,6771,6895) || true) && (choices == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,6771,6895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,6824,6880);

throw f_117_6830_6879("choices");
DynAbs.Tracing.TraceSender.TraceExitCondition(117,6771,6895);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,6911,7125) || true) && (f_117_6915_6928(choices)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,6911,7125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,6967,7110);

throw f_117_6973_7109("choices", f_117_7040_7097(), "choices");
DynAbs.Tracing.TraceSender.TraceExitCondition(117,6911,7125);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,7141,7211);

Dictionary<int, bool> 
defaultChoiceKeys = f_117_7183_7210()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,7227,8044) || true) && (defaultChoices != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,7227,8044);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,7287,8029);
foreach(int defaultChoice in f_117_7317_7331_I(defaultChoices) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,7287,8029);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,7373,7821) || true) && ((defaultChoice < 0) ||(DynAbs.Tracing.TraceSender.Expression_False(117, 7377, 7432)||(defaultChoice >= f_117_7418_7431(choices))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,7373,7821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,7482,7798);

throw f_117_7488_7797("defaultChoice", defaultChoice, f_117_7594_7666(), "defaultChoice", "choices", defaultChoice);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,7373,7821);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,7845,8010) || true) && (!f_117_7850_7894(defaultChoiceKeys, defaultChoice))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,7845,8010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,7944,7987);

f_117_7944_7986(                        defaultChoiceKeys, defaultChoice, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,7845,8010);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(117,7287,8029);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(117,1,743);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(117,1,743);
}DynAbs.Tracing.TraceSender.TraceExitCondition(117,7227,8044);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8060,8107);

Collection<int> 
result = f_117_8085_8106()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8233,8246);
            // we lock here so that multiple threads won't interleave the various reads and writes here.
            lock (_instanceLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8342,8618) || true) && (!f_117_8347_8376(caption))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,8342,8618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8466,8487);

f_117_8466_8486(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8509,8599);

f_117_8509_8598(this, f_117_8528_8539(), f_117_8541_8562(f_117_8541_8546()), f_117_8564_8597(this, caption));
DynAbs.Tracing.TraceSender.TraceExitCondition(117,8342,8618);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8670,8819) || true) && (!f_117_8675_8704(message))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,8670,8819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8746,8800);

f_117_8746_8799(this, f_117_8765_8798(this, message));
DynAbs.Tracing.TraceSender.TraceExitCondition(117,8670,8819);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8839,8878);

string[,] 
hotkeysAndPlainLabels = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8896,8979);

f_117_8896_8978(choices, out hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,8999,9065);

f_117_8999_9064(this, hotkeysAndPlainLabels, defaultChoiceKeys, true);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9083,9196) || true) && (f_117_9087_9110(defaultChoiceKeys)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,9083,9196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9156,9177);

f_117_9156_9176(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,9083,9196);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9295,9319);

int 
choicesSelected = 0
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,9337,11867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9429,9530);

string 
choiceMsg = f_117_9448_9529(f_117_9466_9511(), choicesSelected)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9552,9640);

f_117_9552_9639(this, f_117_9567_9578(), f_117_9580_9601(f_117_9580_9585()), f_117_9603_9638(this, choiceMsg));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9664,9688);

ReadLineResult 
rlResult
=default(ReadLineResult);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9710,9761);

string 
response = f_117_9728_9760(this, out rlResult)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9785,10172) || true) && (rlResult == ReadLineResult.endedOnBreak)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,9785,10172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9878,9943);

string 
msg = f_117_9891_9942()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9969,10115);

PromptingException 
e = f_117_9992_10114(msg, null, "PromptForChoiceCanceled", ErrorCategory.OperationStopped)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,10141,10149);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,9785,10172);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,10240,11142) || true) && (f_117_10244_10259(response)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,10240,11142);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,10637,11028) || true) && ((f_117_10642_10654(result)== 0) &&(DynAbs.Tracing.TraceSender.Expression_True(117, 10641, 10699)&&(f_117_10665_10693(f_117_10665_10687(defaultChoiceKeys))>= 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,10637,11028);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,10826,11001);
foreach(int defaultChoice in f_117_10856_10878_I(f_117_10856_10878(defaultChoiceKeys)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,10826,11001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,10944,10970);

f_117_10944_10969(                                result, defaultChoice);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,10826,11001);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(117,1,176);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(117,1,176);
}DynAbs.Tracing.TraceSender.TraceExitCondition(117,10637,11028);
}
DynAbs.Tracing.TraceSender.TraceBreak(117,11113,11119);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,10240,11142);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11221,11444) || true) && (f_117_11225_11240(response)== "?")
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,11221,11444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11339,11386);

f_117_11339_11385(this, choices, hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11412,11421);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,11221,11444);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11468,11578);

int 
choicePicked = f_117_11487_11577(f_117_11529_11544(response), choices, hotkeysAndPlainLabels)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11602,11765) || true) && (choicePicked >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,11602,11765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11673,11698);

f_117_11673_11697(                        result, choicePicked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11724,11742);

choicesSelected++;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,11602,11765);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(117,9337,11867);
}
                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,9337,11867) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(117,9337,11867);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(117,9337,11867);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,11887,11901);

return result;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(117,6520,11927);

int
f_117_6726_6754(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.HandleThrowOnReadAndPrompt();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6726, 6754);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_117_6830_6879(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6830, 6879);
return return_v;
}


int
f_117_6915_6928(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 6915, 6928);
return return_v;
}


string
f_117_7040_7097()
{
var return_v =                     ConsoleHostUserInterfaceStrings.EmptyChoicesErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 7040, 7097);
return return_v;
}


System.Management.Automation.PSArgumentException
f_117_6973_7109(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 6973, 7109);
return return_v;
}


System.Collections.Generic.Dictionary<int, bool>
f_117_7183_7210()
{
var return_v = new System.Collections.Generic.Dictionary<int, bool>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7183, 7210);
return return_v;
}


int
f_117_7418_7431(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 7418, 7431);
return return_v;
}


string
f_117_7594_7666()
{
var return_v =                             ConsoleHostUserInterfaceStrings.InvalidDefaultChoiceForMultipleSelection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 7594, 7666);
return return_v;
}


System.Management.Automation.PSArgumentOutOfRangeException
f_117_7488_7797(string
paramName,int
actualValue,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentOutOfRangeException( paramName, (object)actualValue, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7488, 7797);
return return_v;
}


bool
f_117_7850_7894(System.Collections.Generic.Dictionary<int, bool>
this_param,int
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7850, 7894);
return return_v;
}


int
f_117_7944_7986(System.Collections.Generic.Dictionary<int, bool>
this_param,int
key,bool
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7944, 7986);
return 0;
}


System.Collections.Generic.IEnumerable<int>
f_117_7317_7331_I(System.Collections.Generic.IEnumerable<int>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 7317, 7331);
return return_v;
}


System.Collections.ObjectModel.Collection<int>
f_117_8085_8106()
{
var return_v = new System.Collections.ObjectModel.Collection<int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8085, 8106);
return return_v;
}


bool
f_117_8347_8376(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8347, 8376);
return return_v;
}


int
f_117_8466_8486(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8466, 8486);
return 0;
}


System.ConsoleColor
f_117_8528_8539()
{
var return_v = PromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8528, 8539);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_117_8541_8546()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8541, 8546);
return return_v;
}


System.ConsoleColor
f_117_8541_8562(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 8541, 8562);
return return_v;
}


string
f_117_8564_8597(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8564, 8597);
return return_v;
}


int
f_117_8509_8598(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
text)
{
this_param.WriteLineToConsole( foregroundColor, backgroundColor, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8509, 8598);
return 0;
}


bool
f_117_8675_8704(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8675, 8704);
return return_v;
}


string
f_117_8765_8798(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8765, 8798);
return return_v;
}


int
f_117_8746_8799(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8746, 8799);
return 0;
}


int
f_117_8896_8978(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,out string[,]
hotkeysAndPlainLabels)
{
HostUIHelperMethods.BuildHotkeysAndPlainLabels( choices, out hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8896, 8978);
return 0;
}


int
f_117_8999_9064(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string[,]
hotkeysAndPlainLabels,System.Collections.Generic.Dictionary<int, bool>
defaultChoiceKeys,bool
shouldEmulateForMultipleChoiceSelection)
{
this_param.WriteChoicePrompt( hotkeysAndPlainLabels, defaultChoiceKeys, shouldEmulateForMultipleChoiceSelection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 8999, 9064);
return 0;
}


int
f_117_9087_9110(System.Collections.Generic.Dictionary<int, bool>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9087, 9110);
return return_v;
}


int
f_117_9156_9176(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9156, 9176);
return 0;
}


string
f_117_9466_9511()
{
var return_v = ConsoleHostUserInterfaceStrings.ChoiceMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9466, 9511);
return return_v;
}


string
f_117_9448_9529(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9448, 9529);
return return_v;
}


System.ConsoleColor
f_117_9567_9578()
{
var return_v = PromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9567, 9578);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_117_9580_9585()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9580, 9585);
return return_v;
}


System.ConsoleColor
f_117_9580_9601(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9580, 9601);
return return_v;
}


string
f_117_9603_9638(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9603, 9638);
return return_v;
}


int
f_117_9552_9639(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
text)
{
this_param.WriteToConsole( foregroundColor, backgroundColor, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9552, 9639);
return 0;
}


string
f_117_9728_9760(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,out Microsoft.PowerShell.ConsoleHostUserInterface.ReadLineResult
result)
{
var return_v = this_param.ReadChoiceResponse( out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9728, 9760);
return return_v;
}


string
f_117_9891_9942()
{
var return_v = ConsoleHostUserInterfaceStrings.PromptCanceledError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 9891, 9942);
return return_v;
}


System.Management.Automation.Host.PromptingException
f_117_9992_10114(string
message,System.Exception
innerException,string
errorId,System.Management.Automation.ErrorCategory
errorCategory)
{
var return_v = new System.Management.Automation.Host.PromptingException( message, innerException, errorId, errorCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 9992, 10114);
return return_v;
}


int
f_117_10244_10259(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 10244, 10259);
return return_v;
}


int
f_117_10642_10654(System.Collections.ObjectModel.Collection<int>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 10642, 10654);
return return_v;
}


System.Collections.Generic.Dictionary<int, bool>.KeyCollection
f_117_10665_10687(System.Collections.Generic.Dictionary<int, bool>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 10665, 10687);
return return_v;
}


int
f_117_10665_10693(System.Collections.Generic.Dictionary<int, bool>.KeyCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 10665, 10693);
return return_v;
}


System.Collections.Generic.Dictionary<int, bool>.KeyCollection
f_117_10856_10878(System.Collections.Generic.Dictionary<int, bool>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 10856, 10878);
return return_v;
}


int
f_117_10944_10969(System.Collections.ObjectModel.Collection<int>
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10944, 10969);
return 0;
}


System.Collections.Generic.Dictionary<int, bool>.KeyCollection
f_117_10856_10878_I(System.Collections.Generic.Dictionary<int, bool>.KeyCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 10856, 10878);
return return_v;
}


string
f_117_11225_11240(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 11225, 11240);
return return_v;
}


int
f_117_11339_11385(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,string[,]
hotkeysAndPlainLabels)
{
this_param.ShowChoiceHelp( choices, hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 11339, 11385);
return 0;
}


string
f_117_11529_11544(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 11529, 11544);
return return_v;
}


int
f_117_11487_11577(string
response,System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
choices,string[,]
hotkeysAndPlainLabels)
{
var return_v = HostUIHelperMethods.DetermineChoicePicked( response, choices, hotkeysAndPlainLabels);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 11487, 11577);
return return_v;
}


int
f_117_11673_11697(System.Collections.ObjectModel.Collection<int>
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 11673, 11697);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,6520,11927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,6520,11927);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteChoicePrompt(string[,] hotkeysAndPlainLabels,
            Dictionary<int, bool> defaultChoiceKeys,
            bool shouldEmulateForMultipleChoiceSelection)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,11939,15389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12140,12252);

f_117_12140_12251(defaultChoiceKeys != null, "defaultChoiceKeys cannot be null.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12268,12308);

ConsoleColor 
fg = f_117_12286_12307(f_117_12286_12291())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12322,12362);

ConsoleColor 
bg = f_117_12340_12361(f_117_12340_12345())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12376,12420);

int 
lineLenMax = f_117_12393_12398().WindowSize.Width - 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12434,12450);

int 
lineLen = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12466,12504);

string 
choiceTemplate = "[{0}] {1}  "
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12529,12534);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12520,13344) || true) && (i < f_117_12540_12574(hotkeysAndPlainLabels, 1))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12576,12579)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(117,12520,13344))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,12520,13344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12613,12644);

ConsoleColor 
cfg = f_117_12632_12643()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12662,12832) || true) && (f_117_12666_12698(defaultChoiceKeys, i))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,12662,12832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12788,12813);

cfg = f_117_12794_12812();
DynAbs.Tracing.TraceSender.TraceExitCondition(117,12662,12832);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,12852,13108);

string 
choice =
f_117_12889_13107(f_117_12929_12957(), choiceTemplate, hotkeysAndPlainLabels[0, i], hotkeysAndPlainLabels[1, i])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13126,13186);

f_117_13126_13185(this, choice, cfg, bg, ref lineLen, lineLenMax);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13204,13329) || true) && (shouldEmulateForMultipleChoiceSelection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,13204,13329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13289,13310);

f_117_13289_13309(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,13204,13329);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(117,1,825);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(117,1,825);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13360,13550);

f_117_13360_13549(this, f_117_13396_13447(), fg, bg, ref lineLen, lineLenMax);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13564,13677) || true) && (shouldEmulateForMultipleChoiceSelection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,13564,13677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13641,13662);

f_117_13641_13661(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,13564,13677);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13693,13729);

string 
defaultPrompt = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13743,15228) || true) && (f_117_13747_13770(defaultChoiceKeys)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,13743,15228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13808,13838);

string 
prepend = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13856,13914);

StringBuilder 
defaultChoicesBuilder = f_117_13894_13913()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,13932,14479);
foreach(int defaultChoice in f_117_13962_13984_I(f_117_13962_13984(defaultChoiceKeys)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,13932,14479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14026,14086);

string 
defaultStr = hotkeysAndPlainLabels[0, defaultChoice]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14108,14270) || true) && (f_117_14112_14144(defaultStr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,14108,14270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14194,14247);

defaultStr = hotkeysAndPlainLabels[1, defaultChoice];
DynAbs.Tracing.TraceSender.TraceExitCondition(117,14108,14270);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14294,14424);

f_117_14294_14423(
                    defaultChoicesBuilder, f_117_14323_14422(f_117_14337_14365(), "{0}{1}", prepend, defaultStr));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14446,14460);

prepend = ",";
DynAbs.Tracing.TraceSender.TraceExitCondition(117,13932,14479);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(117,1,548);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(117,1,548);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14499,14556);

string 
defaultChoices = f_117_14523_14555(defaultChoicesBuilder)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14576,15213) || true) && (f_117_14580_14603(defaultChoiceKeys)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,14576,15213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,14650,14971);

defaultPrompt = (DynAbs.Tracing.TraceSender.Conditional_F1(117, 14666, 14705)||((shouldEmulateForMultipleChoiceSelection &&DynAbs.Tracing.TraceSender.Conditional_F2(117, 14733, 14831))||DynAbs.Tracing.TraceSender.Conditional_F3(117, 14884, 14970)))?f_117_14733_14831(f_117_14751_14814(), defaultChoices):f_117_14884_14970(f_117_14902_14953(), defaultChoices);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,14576,15213);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,14576,15213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15053,15194);

defaultPrompt = f_117_15069_15193(f_117_15087_15151(), defaultChoices);
DynAbs.Tracing.TraceSender.TraceExitCondition(117,14576,15213);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(117,13743,15228);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15244,15378);

f_117_15244_15377(this, defaultPrompt, fg, bg, ref lineLen, lineLenMax);
DynAbs.Tracing.TraceSender.TraceExitMethod(117,11939,15389);

int
f_117_12140_12251(bool
condition,string
whyThisShouldNeverHappen)
{
System.Management.Automation.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 12140, 12251);
return 0;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_117_12286_12291()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12286, 12291);
return return_v;
}


System.ConsoleColor
f_117_12286_12307(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.ForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12286, 12307);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_117_12340_12345()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12340, 12345);
return return_v;
}


System.ConsoleColor
f_117_12340_12361(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12340, 12361);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_117_12393_12398()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12393, 12398);
return return_v;
}


int
f_117_12540_12574(string[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 12540, 12574);
return return_v;
}


System.ConsoleColor
f_117_12632_12643()
{
var return_v = PromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12632, 12643);
return return_v;
}


bool
f_117_12666_12698(System.Collections.Generic.Dictionary<int, bool>
this_param,int
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 12666, 12698);
return return_v;
}


System.ConsoleColor
f_117_12794_12812()
{
var return_v = DefaultPromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12794, 12812);
return return_v;
}


System.Globalization.CultureInfo
f_117_12929_12957()
{
var return_v =                         CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 12929, 12957);
return return_v;
}


string
f_117_12889_13107(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 12889, 13107);
return return_v;
}


int
f_117_13126_13185(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,System.ConsoleColor
fg,System.ConsoleColor
bg,ref int
lineLen,int
lineLenMax)
{
this_param.WriteChoiceHelper( text, fg, bg, ref lineLen, lineLenMax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 13126, 13185);
return 0;
}


int
f_117_13289_13309(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 13289, 13309);
return 0;
}


string
f_117_13396_13447()
{
var return_v =                 ConsoleHostUserInterfaceStrings.PromptForChoiceHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 13396, 13447);
return return_v;
}


int
f_117_13360_13549(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,System.ConsoleColor
fg,System.ConsoleColor
bg,ref int
lineLen,int
lineLenMax)
{
this_param.WriteChoiceHelper( text, fg, bg, ref lineLen, lineLenMax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 13360, 13549);
return 0;
}


int
f_117_13641_13661(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 13641, 13661);
return 0;
}


int
f_117_13747_13770(System.Collections.Generic.Dictionary<int, bool>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 13747, 13770);
return return_v;
}


System.Text.StringBuilder
f_117_13894_13913()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 13894, 13913);
return return_v;
}


System.Collections.Generic.Dictionary<int, bool>.KeyCollection
f_117_13962_13984(System.Collections.Generic.Dictionary<int, bool>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 13962, 13984);
return return_v;
}


bool
f_117_14112_14144(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 14112, 14144);
return return_v;
}


System.Globalization.CultureInfo
f_117_14337_14365()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 14337, 14365);
return return_v;
}


string
f_117_14323_14422(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 14323, 14422);
return return_v;
}


System.Text.StringBuilder
f_117_14294_14423(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 14294, 14423);
return return_v;
}


System.Collections.Generic.Dictionary<int, bool>.KeyCollection
f_117_13962_13984_I(System.Collections.Generic.Dictionary<int, bool>.KeyCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 13962, 13984);
return return_v;
}


string
f_117_14523_14555(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 14523, 14555);
return return_v;
}


int
f_117_14580_14603(System.Collections.Generic.Dictionary<int, bool>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 14580, 14603);
return return_v;
}


string
f_117_14751_14814()
{
var return_v = ConsoleHostUserInterfaceStrings.DefaultChoiceForMultipleChoices;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 14751, 14814);
return return_v;
}


string
f_117_14733_14831(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 14733, 14831);
return return_v;
}


string
f_117_14902_14953()
{
var return_v = ConsoleHostUserInterfaceStrings.DefaultChoicePrompt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 14902, 14953);
return return_v;
}


string
f_117_14884_14970(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 14884, 14970);
return return_v;
}


string
f_117_15087_15151()
{
var return_v = ConsoleHostUserInterfaceStrings.DefaultChoicesForMultipleChoices;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 15087, 15151);
return return_v;
}


string
f_117_15069_15193(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 15069, 15193);
return return_v;
}


int
f_117_15244_15377(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,System.ConsoleColor
fg,System.ConsoleColor
bg,ref int
lineLen,int
lineLenMax)
{
this_param.WriteChoiceHelper( text, fg, bg, ref lineLen, lineLenMax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 15244, 15377);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,11939,15389);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,11939,15389);
}
		}

private void WriteChoiceHelper(string text, ConsoleColor fg, ConsoleColor bg, ref int lineLen, int lineLenMax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,15401,15978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15536,15582);

int 
textLen = f_117_15550_15581(f_117_15550_15555(), text)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15596,15617);

bool 
trimEnd = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15633,15891) || true) && (lineLen + textLen > lineLenMax)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,15633,15891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15701,15722);

f_117_15701_15721(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15740,15755);

trimEnd = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15773,15791);

lineLen = textLen;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,15633,15891);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,15633,15891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15857,15876);

lineLen += textLen;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,15633,15891);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,15907,15967);

f_117_15907_15966(this, fg, bg, (DynAbs.Tracing.TraceSender.Conditional_F1(117, 15930, 15937)||((trimEnd &&DynAbs.Tracing.TraceSender.Conditional_F2(117, 15940, 15958))||DynAbs.Tracing.TraceSender.Conditional_F3(117, 15961, 15965)))?f_117_15940_15958(text, null):text);
DynAbs.Tracing.TraceSender.TraceExitMethod(117,15401,15978);

System.Management.Automation.Host.PSHostRawUserInterface
f_117_15550_15555()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 15550, 15555);
return return_v;
}


int
f_117_15550_15581(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 15550, 15581);
return return_v;
}


int
f_117_15701_15721(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 15701, 15721);
return 0;
}


string
f_117_15940_15958(string
this_param,params char[]?
trimChars)
{
var return_v = this_param.TrimEnd( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 15940, 15958);
return return_v;
}


int
f_117_15907_15966(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
text)
{
this_param.WriteToConsole( foregroundColor, backgroundColor, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 15907, 15966);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,15401,15978);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,15401,15978);
}
		}

private string ReadChoiceResponse(out ReadLineResult result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,15990,16500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16075,16112);

result = ReadLineResult.endedOnEnter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16126,16489);

return (DynAbs.Tracing.TraceSender.Conditional_F1(117, 16133, 16184)||((InternalTestHooks.ForcePromptForChoiceDefaultOption
&&DynAbs.Tracing.TraceSender.Conditional_F2(117, 16207, 16219))||DynAbs.Tracing.TraceSender.Conditional_F3(117, 16242, 16488)))?string.Empty
:f_117_16242_16488(this, endOnTab: false, initialContent: string.Empty, result: out result, calledFromPipeline: true, transcribeResult: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(117,15990,16500);

string
f_117_16242_16488(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,bool
endOnTab,string
initialContent,out Microsoft.PowerShell.ConsoleHostUserInterface.ReadLineResult
result,bool
calledFromPipeline,bool
transcribeResult)
{
var return_v = this_param.ReadLine( endOnTab:endOnTab, initialContent:initialContent, out result, calledFromPipeline:calledFromPipeline, transcribeResult:transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 16242, 16488);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,15990,16500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,15990,16500);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ShowChoiceHelp(Collection<ChoiceDescription> choices, string[,] hotkeysAndPlainLabels)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,16512,17452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16636,16693);

f_117_16636_16692(choices != null, "choices: expected a value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16707,16792);

f_117_16707_16791(hotkeysAndPlainLabels != null, "hotkeysAndPlainLabels: expected a value");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16817,16822);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16808,17441) || true) && (i < f_117_16828_16841(choices))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16843,16846)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(117,16808,17441))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,16808,17441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16880,16889);

string 
s
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,16979,17228) || true) && (f_117_16983_17017(hotkeysAndPlainLabels[0, i])> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,16979,17228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17063,17095);

s = hotkeysAndPlainLabels[0, i];
DynAbs.Tracing.TraceSender.TraceExitCondition(117,16979,17228);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,16979,17228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17177,17209);

s = hotkeysAndPlainLabels[1, i];
DynAbs.Tracing.TraceSender.TraceExitCondition(117,16979,17228);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17248,17426);

f_117_17248_17425(this, f_117_17289_17424(this, f_117_17340_17423(f_117_17354_17382(), "{0} - {1}", s, f_117_17400_17422(f_117_17400_17410(choices, i)))));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(117,1,634);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(117,1,634);
}DynAbs.Tracing.TraceSender.TraceExitMethod(117,16512,17452);

int
f_117_16636_16692(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 16636, 16692);
return 0;
}


int
f_117_16707_16791(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 16707, 16791);
return 0;
}


int
f_117_16828_16841(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 16828, 16841);
return return_v;
}


int
f_117_16983_17017(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 16983, 17017);
return return_v;
}


System.Globalization.CultureInfo
f_117_17354_17382()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 17354, 17382);
return return_v;
}


System.Management.Automation.Host.ChoiceDescription
f_117_17400_17410(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 17400, 17410);
return return_v;
}


string
f_117_17400_17422(System.Management.Automation.Host.ChoiceDescription
this_param)
{
var return_v = this_param.HelpMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 17400, 17422);
return return_v;
}


string
f_117_17340_17423(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 17340, 17423);
return return_v;
}


string
f_117_17289_17424(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 17289, 17424);
return return_v;
}


int
f_117_17248_17425(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(117, 17248, 17425);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,16512,17452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,16512,17452);
}
		}

private ConsoleColor PromptColor
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,17629,18247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17665,18232);

switch (f_117_17673_17694(f_117_17673_17678()))
                {

case ConsoleColor.White: DynAbs.Tracing.TraceSender.TraceEnterCondition(117,17665,18232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17761,17787);

return ConsoleColor.Black;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,17665,18232);

case ConsoleColor.Cyan: DynAbs.Tracing.TraceSender.TraceEnterCondition(117,17665,18232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17833,17859);

return ConsoleColor.Black;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,17665,18232);

case ConsoleColor.DarkYellow: DynAbs.Tracing.TraceSender.TraceEnterCondition(117,17665,18232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17911,17937);

return ConsoleColor.Black;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,17665,18232);

case ConsoleColor.Yellow: DynAbs.Tracing.TraceSender.TraceEnterCondition(117,17665,18232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,17985,18011);

return ConsoleColor.Black;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,17665,18232);

case ConsoleColor.Gray: DynAbs.Tracing.TraceSender.TraceEnterCondition(117,17665,18232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,18057,18083);

return ConsoleColor.Black;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,17665,18232);

case ConsoleColor.Green: DynAbs.Tracing.TraceSender.TraceEnterCondition(117,17665,18232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,18130,18156);

return ConsoleColor.Black;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,17665,18232);

default: DynAbs.Tracing.TraceSender.TraceEnterCondition(117,17665,18232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,18187,18213);

return ConsoleColor.White;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,17665,18232);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(117,17629,18247);

System.Management.Automation.Host.PSHostRawUserInterface
f_117_17673_17678()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 17673, 17678);
return return_v;
}


System.ConsoleColor
f_117_17673_17694(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 17673, 17694);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,17572,18258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,17572,18258);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private ConsoleColor DefaultPromptColor
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(117,18517,18724);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,18553,18709) || true) && (f_117_18557_18568()== ConsoleColor.White)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,18553,18709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,18613,18640);

return ConsoleColor.Yellow;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,18553,18709);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(117,18553,18709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(117,18684,18709);

return ConsoleColor.Blue;
DynAbs.Tracing.TraceSender.TraceExitCondition(117,18553,18709);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(117,18517,18724);

System.ConsoleColor
f_117_18557_18568()
{
var return_v = PromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(117, 18557, 18568);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(117,18453,18735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(117,18453,18735);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}
}
}   // namespace
