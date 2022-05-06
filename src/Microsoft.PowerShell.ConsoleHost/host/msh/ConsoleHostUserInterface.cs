// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

using Dbg = System.Management.Automation.Diagnostics;
using ConsoleHandle = Microsoft.Win32.SafeHandles.SafeFileHandle;

namespace Microsoft.PowerShell
{
    using PowerShell = System.Management.Automation.PowerShell;
[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
    internal partial class ConsoleHostUserInterface : System.Management.Automation.Host.PSHostUserInterface
{
private PowerShell _commandCompletionPowerShell;

private static PSHostUserInterface s_h ;

public override bool SupportsVirtualTerminal {get; }

internal ConsoleHostUserInterface(ConsoleHost parent)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(114,1778,3069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,1194,1222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,1558,1611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,4816,4857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,4977,5013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48996,49069);
this.FormatAccentColor = ConsoleColor.Green;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49106,49177);
this.ErrorAccentColor = ConsoleColor.Cyan;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49187,49261);
this.ErrorForegroundColor = ConsoleColor.Red;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49271,49352);
this.ErrorBackgroundColor = f_114_49328_49351();DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49391,49470);
this.WarningForegroundColor = ConsoleColor.Yellow;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49480,49563);
this.WarningBackgroundColor = f_114_49539_49562();DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49600,49677);
this.DebugForegroundColor = ConsoleColor.Yellow;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49687,49768);
this.DebugBackgroundColor = f_114_49744_49767();DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49807,49886);
this.VerboseForegroundColor = ConsoleColor.Yellow;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,49896,49979);
this.VerboseBackgroundColor = f_114_49955_49978();DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,50019,50099);
this.ProgressForegroundColor = ConsoleColor.Yellow;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,50109,50191);
this.ProgressBackgroundColor = ConsoleColor.DarkCyan;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,82163,82191);
this._instanceLock = f_114_82179_82191();DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,82492,82513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,82916,82947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,83081,83087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,83118,83125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,6079,6095);
this._progPane = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,6130,6153);
this._pendingProgress = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,6295,6322);
this._progPaneUpdateTimer = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,6400,6422);
this.progPaneUpdateFlag = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,1856,1909);

f_114_1856_1908(parent != null, "parent may not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,1925,1942);

_parent = parent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,1956,2003);

_rawui = f_114_1965_2002(this);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,2295,2353);

var 
handle = f_114_2308_2352()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,2371,2410);

var 
m = f_114_2379_2409(handle)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,2428,2930) || true) && (f_114_2432_2561(f_114_2476_2503(handle), (m | ConsoleControl.ConsoleModes.VirtualTerminal)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,2428,2930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,2768,2803);

m = f_114_2772_2802(handle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,2825,2911);

this.SupportsVirtualTerminal = (m & ConsoleControl.ConsoleModes.VirtualTerminal) != 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,2428,2930);
}
            }
            catch
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(114,2959,2994);
DynAbs.Tracing.TraceSender.TraceExitCatch(114,2959,2994);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,3018,3058);

_isInteractiveTestToolListening = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(114,1778,3069);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,1778,3069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,1778,3069);
}
		}

public override PSHostRawUserInterface RawUI
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,3372,3613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,3408,3477);

f_114_3408_3476(_rawui != null, "rawui should have been created by ctor");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,3584,3598);

return _rawui;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,3372,3613);

int
f_114_3408_3476(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 3408, 3476);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,3303,3624);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,3303,3624);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool IsCommandCompletionRunning
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,4428,4634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,4464,4619);

return _commandCompletionPowerShell != null &&(DynAbs.Tracing.TraceSender.Expression_True(114, 4471, 4618)&&f_114_4535_4589(f_114_4535_4583(_commandCompletionPowerShell))== PSInvocationState.Running);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,4428,4634);

System.Management.Automation.PSInvocationStateInfo
f_114_4535_4583(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InvocationStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 4535, 4583);
return return_v;
}


System.Management.Automation.PSInvocationState
f_114_4535_4589(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 4535, 4589);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,4363,4645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,4363,4645);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool ReadFromStdin {get; set; }

internal bool NoPrompt {get; set; }

public override string ReadLine()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,5515,5811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,5573,5602);

f_114_5573_5601(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,5701,5723);

ReadLineResult 
unused
=default(ReadLineResult);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,5739,5800);

return f_114_5746_5799(this, false, string.Empty, out unused, true, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,5515,5811);

int
f_114_5573_5601(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.HandleThrowOnReadAndPrompt();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 5573, 5601);
return 0;
}


string
f_114_5746_5799(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,bool
endOnTab,string
initialContent,out Microsoft.PowerShell.ConsoleHostUserInterface.ReadLineResult
result,bool
calledFromPipeline,bool
transcribeResult)
{
var return_v = this_param.ReadLine( endOnTab, initialContent, out result, calledFromPipeline, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 5746, 5799);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,5515,5811);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,5515,5811);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override SecureString ReadLineAsSecureString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,6375,7064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,6453,6482);

f_114_6453_6481(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,6498,6526);

const char 
printToken = '*'
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,6677,6698);

object 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,6718,6731);
            lock (_instanceLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,6765,6805);

result = f_114_6774_6804(this, true, printToken);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,6836,6887);

SecureString 
secureResult = result as SecureString
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,6901,7017);

f_114_6901_7016(secureResult != null, "ReadLineSafe did not return a SecureString");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,7033,7053);

return secureResult;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,6375,7064);

int
f_114_6453_6481(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.HandleThrowOnReadAndPrompt();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 6453, 6481);
return 0;
}


object
f_114_6774_6804(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,bool
isSecureString,char
printToken)
{
var return_v = this_param.ReadLineSafe( isSecureString, (char?)printToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 6774, 6804);
return return_v;
}


int
f_114_6901_7016(bool
condition,string
whyThisShouldNeverHappen)
{
System.Management.Automation.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 6901, 7016);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,6375,7064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,6375,7064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object ReadLineSafe(bool isSecureString, char? printToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,8698,15198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,8875,8885);

f_114_8875_8884(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,8899,9010);

string 
printTokenString = (DynAbs.Tracing.TraceSender.Conditional_F1(114, 8925, 8944)||((f_114_8925_8944(printToken)&&DynAbs.Tracing.TraceSender.Conditional_F2(114, 8964, 8985))||DynAbs.Tracing.TraceSender.Conditional_F3(114, 9005, 9009)))?f_114_8964_8985(                printToken):                null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,9024,9071);

SecureString 
secureResult = f_114_9052_9070()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,9085,9128);

StringBuilder 
result = f_114_9108_9127()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,9230,9291);

ConsoleHandle 
handle = f_114_9253_9290()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,9305,9379);

ConsoleControl.ConsoleModes 
originalMode = f_114_9348_9378(handle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,9393,9419);

bool 
isModeChanged = true
;
            // fails to return the value correctly, the original mode is
            // restored.

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,9781,9948);

const ConsoleControl.ConsoleModes 
DesiredMode =
                    ConsoleControl.ConsoleModes.Extended |
                    ConsoleControl.ConsoleModes.QuickEdit
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,9968,10013);

ConsoleControl.ConsoleModes 
m = originalMode
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10031,10121);

bool 
shouldUnsetEchoInput = f_114_10059_10120(ConsoleControl.ConsoleModes.EchoInput, ref m)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10139,10229);

bool 
shouldUnsetLineInput = f_114_10167_10228(ConsoleControl.ConsoleModes.LineInput, ref m)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10247,10339);

bool 
shouldUnsetMouseInput = f_114_10276_10338(ConsoleControl.ConsoleModes.MouseInput, ref m)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10357,10455);

bool 
shouldUnsetProcessInput = f_114_10388_10454(ConsoleControl.ConsoleModes.ProcessedInput, ref m)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10475,10933) || true) && ((m & DesiredMode) != DesiredMode ||(DynAbs.Tracing.TraceSender.Expression_False(114, 10479, 10557)||                    shouldUnsetMouseInput )||(DynAbs.Tracing.TraceSender.Expression_False(114, 10479, 10602)||                    shouldUnsetEchoInput )||(DynAbs.Tracing.TraceSender.Expression_False(114, 10479, 10647)||                    shouldUnsetLineInput )||(DynAbs.Tracing.TraceSender.Expression_False(114, 10479, 10695)||                    shouldUnsetProcessInput))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,10475,10933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10737,10754);

m |= DesiredMode;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10776,10810);

f_114_10776_10809(handle, m);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,10475,10933);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,10475,10933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10892,10914);

isModeChanged = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,10475,10933);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,10953,10976);

f_114_10953_10975(
                _rawui);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,11004,11058);

Coordinates 
originalCursorPos = f_114_11036_11057(_rawui)
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,11078,14427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,11431,11462);

const int 
CharactersToRead = 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,11484,11547);

Span<char> 
inputBuffer = stackalloc char[CharactersToRead + 1]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,11569,11715);

string 
key = f_114_11582_11714(handle, initialContentLength: 0, inputBuffer, charactersToRead: CharactersToRead, endOnTab: false, out _)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,11924,12149) || true) && (f_114_11928_11953(key)||(DynAbs.Tracing.TraceSender.Expression_False(114, 11928, 11974)||(char)3 == f_114_11968_11974(key, 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,11924,12149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,12032,12092);

PipelineStoppedException 
e = f_114_12061_12091()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,12118,12126);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,11924,12149);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,12246,12477) || true) && ((char)13 == f_114_12262_12268(key, 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,12246,12477);
DynAbs.Tracing.TraceSender.TraceBreak(114,12448,12454);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,12246,12477);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,12578,14377) || true) && ((char)8 == f_114_12593_12599(key, 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,12578,14377);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,12782,13260) || true) && (isSecureString &&(DynAbs.Tracing.TraceSender.Expression_True(114, 12786, 12827)&&f_114_12804_12823(secureResult)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,12782,13260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,12885,12932);

f_114_12885_12931(                            secureResult, f_114_12907_12926(secureResult)- 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,12962,12996);

f_114_12962_12995(this, originalCursorPos);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,12782,13260);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,12782,13260);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,13054,13260) || true) && (f_114_13058_13071(result)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,13054,13260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,13133,13169);

f_114_13133_13168(                            result, f_114_13147_13160(result)- 1, 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,13199,13233);

f_114_13199_13232(this, originalCursorPos);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,13054,13260);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,12782,13260);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,12578,14377);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,12578,14377);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,13691,14141) || true) && (isSecureString)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,13691,14141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,13855,13887);

f_114_13855_13886(                            secureResult, f_114_13879_13885(key, 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(114,13691,14141);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,13691,14141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,14087,14106);

f_114_14087_14105(                            result, key);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,13691,14141);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,14169,14354) || true) && (!f_114_14174_14212(printTokenString))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,14169,14354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,14270,14327);

f_114_14270_14326(this, printTokenString, ref originalCursorPos);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,14169,14354);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,12578,14377);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,11078,14427);
}
                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,11078,14427) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,11078,14427);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,11078,14427);
}}            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(114,14654,14927);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,14781,14904) || true) && (isModeChanged)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,14781,14904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,14840,14885);

f_114_14840_14884(handle, originalMode);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,14781,14904);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(114,14654,14927);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,14943,14964);

f_114_14943_14963(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,14978,15006);

f_114_14978_15005(this, f_114_14987_15004(result));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,15020,15187) || true) && (isSecureString)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,15020,15187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,15072,15092);

return secureResult;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,15020,15187);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,15020,15187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,15158,15172);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,15020,15187);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,8698,15198);

int
f_114_8875_8884(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.PreRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 8875, 8884);
return 0;
}


bool
f_114_8925_8944(char?
this_param)
{
var return_v = this_param.HasValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 8925, 8944);
return return_v;
}


string?
f_114_8964_8985(char?
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 8964, 8985);
return return_v;
}


System.Security.SecureString
f_114_9052_9070()
{
var return_v = new System.Security.SecureString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 9052, 9070);
return return_v;
}


System.Text.StringBuilder
f_114_9108_9127()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 9108, 9127);
return return_v;
}


Microsoft.Win32.SafeHandles.SafeFileHandle
f_114_9253_9290()
{
var return_v = ConsoleControl.GetConioDeviceHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 9253, 9290);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.ConsoleModes
f_114_9348_9378(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle)
{
var return_v = ConsoleControl.GetMode( consoleHandle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 9348, 9378);
return return_v;
}


bool
f_114_10059_10120(Microsoft.PowerShell.ConsoleControl.ConsoleModes
flagToUnset,ref Microsoft.PowerShell.ConsoleControl.ConsoleModes
m)
{
var return_v = shouldUnsetMode( flagToUnset, ref m);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 10059, 10120);
return return_v;
}


bool
f_114_10167_10228(Microsoft.PowerShell.ConsoleControl.ConsoleModes
flagToUnset,ref Microsoft.PowerShell.ConsoleControl.ConsoleModes
m)
{
var return_v = shouldUnsetMode( flagToUnset, ref m);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 10167, 10228);
return return_v;
}


bool
f_114_10276_10338(Microsoft.PowerShell.ConsoleControl.ConsoleModes
flagToUnset,ref Microsoft.PowerShell.ConsoleControl.ConsoleModes
m)
{
var return_v = shouldUnsetMode( flagToUnset, ref m);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 10276, 10338);
return return_v;
}


bool
f_114_10388_10454(Microsoft.PowerShell.ConsoleControl.ConsoleModes
flagToUnset,ref Microsoft.PowerShell.ConsoleControl.ConsoleModes
m)
{
var return_v = shouldUnsetMode( flagToUnset, ref m);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 10388, 10454);
return return_v;
}


int
f_114_10776_10809(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,Microsoft.PowerShell.ConsoleControl.ConsoleModes
mode)
{
ConsoleControl.SetMode( consoleHandle, mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 10776, 10809);
return 0;
}


int
f_114_10953_10975(Microsoft.PowerShell.ConsoleHostRawUserInterface
this_param)
{
this_param.ClearKeyCache();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 10953, 10975);
return 0;
}


System.Management.Automation.Host.Coordinates
f_114_11036_11057(Microsoft.PowerShell.ConsoleHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 11036, 11057);
return return_v;
}


string
f_114_11582_11714(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,int
initialContentLength,System.Span<char>
editBuffer,int
charactersToRead,bool
endOnTab,out uint
keyState)
{
var return_v = ConsoleControl.ReadConsole( consoleHandle, initialContentLength:initialContentLength, editBuffer, charactersToRead:charactersToRead, endOnTab:endOnTab, out keyState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 11582, 11714);
return return_v;
}


bool
f_114_11928_11953(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 11928, 11953);
return return_v;
}


char
f_114_11968_11974(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 11968, 11974);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_114_12061_12091()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 12061, 12091);
return return_v;
}


char
f_114_12262_12268(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 12262, 12268);
return return_v;
}


char
f_114_12593_12599(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 12593, 12599);
return return_v;
}


int
f_114_12804_12823(System.Security.SecureString
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 12804, 12823);
return return_v;
}


int
f_114_12907_12926(System.Security.SecureString
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 12907, 12926);
return return_v;
}


int
f_114_12885_12931(System.Security.SecureString
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 12885, 12931);
return 0;
}


int
f_114_12962_12995(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Management.Automation.Host.Coordinates
originalCursorPosition)
{
this_param.WriteBackSpace( originalCursorPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 12962, 12995);
return 0;
}


int
f_114_13058_13071(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 13058, 13071);
return return_v;
}


int
f_114_13147_13160(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 13147, 13160);
return return_v;
}


System.Text.StringBuilder
f_114_13133_13168(System.Text.StringBuilder
this_param,int
startIndex,int
length)
{
var return_v = this_param.Remove( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 13133, 13168);
return return_v;
}


int
f_114_13199_13232(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Management.Automation.Host.Coordinates
originalCursorPosition)
{
this_param.WriteBackSpace( originalCursorPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 13199, 13232);
return 0;
}


char
f_114_13879_13885(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 13879, 13885);
return return_v;
}


int
f_114_13855_13886(System.Security.SecureString
this_param,char
c)
{
this_param.AppendChar( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 13855, 13886);
return 0;
}


System.Text.StringBuilder
f_114_14087_14105(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 14087, 14105);
return return_v;
}


bool
f_114_14174_14212(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 14174, 14212);
return return_v;
}


int
f_114_14270_14326(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
printToken,ref System.Management.Automation.Host.Coordinates
originalCursorPosition)
{
this_param.WritePrintToken( printToken, ref originalCursorPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 14270, 14326);
return 0;
}


int
f_114_14840_14884(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,Microsoft.PowerShell.ConsoleControl.ConsoleModes
mode)
{
ConsoleControl.SetMode( consoleHandle, mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 14840, 14884);
return 0;
}


int
f_114_14943_14963(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 14943, 14963);
return 0;
}


string
f_114_14987_15004(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 14987, 15004);
return return_v;
}


int
f_114_14978_15005(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value)
{
this_param.PostRead( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 14978, 15005);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,8698,15198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,8698,15198);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WritePrintToken(
            string printToken,
            ref Coordinates originalCursorPosition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,15831,16989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,15970,16096);

f_114_15970_16095(!f_114_15982_16014(printToken), "Calling WritePrintToken with printToken being null or empty");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,16110,16241);

f_114_16110_16240(f_114_16121_16138(printToken)== 1, "Calling WritePrintToken with printToken's Length being " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_114_16222_16239(printToken)).ToString(),114,16222,16239));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,16255,16298);

Size 
consoleBufferSize = f_114_16280_16297(_rawui)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,16312,16370);

Coordinates 
currentCursorPosition = f_114_16348_16369(_rawui)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,16597,16928) || true) && (currentCursorPosition.Y >= consoleBufferSize.Height - 1 &&(DynAbs.Tracing.TraceSender.Expression_True(114, 16601, 16743)&&                currentCursorPosition.X >= consoleBufferSize.Width - 1))
)  // last column

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,16597,16928);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,16793,16913) || true) && (originalCursorPosition.Y > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,16793,16913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,16867,16894);

f_114_16867_16893_M(originalCursorPosition.Y--);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,16793,16913);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,16597,16928);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,16944,16978);

f_114_16944_16977(this, printToken, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,15831,16989);

bool
f_114_15982_16014(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 15982, 16014);
return return_v;
}


int
f_114_15970_16095(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 15970, 16095);
return 0;
}


int
f_114_16121_16138(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 16121, 16138);
return return_v;
}


int
f_114_16222_16239(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 16222, 16239);
return return_v;
}


int
f_114_16110_16240(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 16110, 16240);
return 0;
}


System.Management.Automation.Host.Size
f_114_16280_16297(Microsoft.PowerShell.ConsoleHostRawUserInterface
this_param)
{
var return_v = this_param.BufferSize;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 16280, 16297);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_114_16348_16369(Microsoft.PowerShell.ConsoleHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 16348, 16369);
return return_v;
}


int
f_114_16867_16893_M(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 16867, 16893);
return return_v;
}


int
f_114_16944_16977(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 16944, 16977);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,15831,16989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,15831,16989);
}
		}

private void WriteBackSpace(Coordinates originalCursorPosition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,17475,18447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,17563,17614);

Coordinates 
cursorPosition = f_114_17592_17613(_rawui)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,17628,17786) || true) && (cursorPosition == originalCursorPosition)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,17628,17786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,17764,17771);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,17628,17786);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,17802,18371) || true) && (cursorPosition.X == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,17802,18371);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,17861,17977) || true) && (cursorPosition.Y <= originalCursorPosition.Y)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,17861,17977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,17951,17958);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,17861,17977);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18065,18112);

cursorPosition.X = _rawui.BufferSize.Width - 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18130,18149);

f_114_18130_18148_M(cursorPosition.Y--);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18167,18197);

f_114_18167_18196(this, cursorPosition);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,17802,18371);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,17802,18371);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18231,18371) || true) && (cursorPosition.X > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,18231,18371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18289,18308);

f_114_18289_18307_M(cursorPosition.X--);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18326,18356);

f_114_18326_18355(this, cursorPosition);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,18231,18371);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,17802,18371);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,17475,18447);

System.Management.Automation.Host.Coordinates
f_114_17592_17613(Microsoft.PowerShell.ConsoleHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 17592, 17613);
return return_v;
}


int
f_114_18130_18148_M(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 18130, 18148);
return return_v;
}


int
f_114_18167_18196(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Management.Automation.Host.Coordinates
cursorPosition)
{
this_param.BlankAtCursor( cursorPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 18167, 18196);
return 0;
}


int
f_114_18289_18307_M(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 18289, 18307);
return return_v;
}


int
f_114_18326_18355(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Management.Automation.Host.Coordinates
cursorPosition)
{
this_param.BlankAtCursor( cursorPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 18326, 18355);
return 0;
}

            // do nothing if cursorPosition.X is left of screen
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,17475,18447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,17475,18447);
}
		}

private void BlankAtCursor(Coordinates cursorPosition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,18672,18894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18751,18790);

_rawui.CursorPosition = cursorPosition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18804,18830);

f_114_18804_18829(this, " ", true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,18844,18883);

_rawui.CursorPosition = cursorPosition;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,18672,18894);

int
f_114_18804_18829(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 18804, 18829);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,18672,18894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,18672,18894);
}
		}

private static bool shouldUnsetMode(
            ConsoleControl.ConsoleModes flagToUnset,
            ref ConsoleControl.ConsoleModes m)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(114,19466,19791);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,19629,19751) || true) && ((m & flagToUnset) > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,19629,19751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,19688,19706);

m &= ~flagToUnset;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,19724,19736);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,19629,19751);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,19767,19780);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(114,19466,19791);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,19466,19791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,19466,19791);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void WriteToConsole(char c, bool transcribeResult)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,19845,20106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,19989,20041);

ReadOnlySpan<char> 
value = stackalloc char[1] { c }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,20055,20095);

f_114_20055_20094(this, value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,19845,20106);

int
f_114_20055_20094(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ReadOnlySpan<char>
value,bool
transcribeResult)
{
this_param.WriteToConsole( value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 20055, 20094);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,19845,20106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,19845,20106);
}
		}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void WriteToConsole(ReadOnlySpan<char> value, bool transcribeResult)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,20118,20347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,20280,20336);

f_114_20280_20335(this, value, transcribeResult, newLine: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,20118,20347);

int
f_114_20280_20335(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ReadOnlySpan<char>
value,bool
transcribeResult,bool
newLine)
{
this_param.WriteToConsole( value, transcribeResult, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 20280, 20335);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,20118,20347);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,20118,20347);
}
		}

private void WriteToConsole(ReadOnlySpan<char> value, bool transcribeResult, bool newLine)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,20359,21779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,20485,20553);

ConsoleHandle 
handle = f_114_20508_20552()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,20754,20817);

ConsoleControl.ConsoleModes 
m = f_114_20786_20816(handle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,20833,21003);

const ConsoleControl.ConsoleModes 
DesiredMode =
                ConsoleControl.ConsoleModes.ProcessedOutput
                | ConsoleControl.ConsoleModes.WrapEndOfLine
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21019,21173) || true) && ((m & DesiredMode) != DesiredMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,21019,21173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21089,21106);

m |= DesiredMode;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21124,21158);

f_114_21124_21157(handle, m);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,21019,21173);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21197,21208);

f_114_21197_21207(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21292,21344);

f_114_21292_21343(handle, value, newLine);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21427,21579) || true) && (_isInteractiveTestToolListening &&(DynAbs.Tracing.TraceSender.Expression_True(114, 21431, 21492)&&f_114_21466_21492()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,21427,21579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21526,21564);

f_114_21526_21563(this, value, newLine);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,21427,21579);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21595,21768) || true) && (transcribeResult)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,21595,21768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21649,21675);

f_114_21649_21674(this, value, newLine);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,21595,21768);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,21595,21768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,21741,21753);

f_114_21741_21752(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,21595,21768);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,20359,21779);

Microsoft.Win32.SafeHandles.SafeFileHandle
f_114_20508_20552()
{
var return_v = ConsoleControl.GetActiveScreenBufferHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 20508, 20552);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.ConsoleModes
f_114_20786_20816(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle)
{
var return_v = ConsoleControl.GetMode( consoleHandle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 20786, 20816);
return return_v;
}


int
f_114_21124_21157(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,Microsoft.PowerShell.ConsoleControl.ConsoleModes
mode)
{
ConsoleControl.SetMode( consoleHandle, mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 21124, 21157);
return 0;
}


int
f_114_21197_21207(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.PreWrite();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 21197, 21207);
return 0;
}


int
f_114_21292_21343(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,System.ReadOnlySpan<char>
output,bool
newLine)
{
ConsoleControl.WriteConsole( consoleHandle, output, newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 21292, 21343);
return 0;
}


bool
f_114_21466_21492()
{
var return_v = Console.IsOutputRedirected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 21466, 21492);
return return_v;
}


int
f_114_21526_21563(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ReadOnlySpan<char>
value,bool
newLine)
{
this_param.ConsoleOutWriteHelper( value, newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 21526, 21563);
return 0;
}


int
f_114_21649_21674(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ReadOnlySpan<char>
value,bool
newLine)
{
this_param.PostWrite( value, newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 21649, 21674);
return 0;
}


int
f_114_21741_21752(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.PostWrite();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 21741, 21752);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,20359,21779);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,20359,21779);
}
		}

private void WriteToConsole(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string text, bool newLine = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,21791,22632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22045,22058);
            // Sync access so that we don't race on color settings if called from multiple threads.
            lock (_instanceLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22092,22132);

ConsoleColor 
fg = f_114_22110_22131(f_114_22110_22115())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22150,22190);

ConsoleColor 
bg = f_114_22168_22189(f_114_22168_22173())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22210,22250);

f_114_22210_22215().ForegroundColor = foregroundColor;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22268,22308);

f_114_22268_22273().BackgroundColor = backgroundColor;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22372,22426);

f_114_22372_22425(this, text, transcribeResult: true, newLine);
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(114,22463,22606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22511,22538);

f_114_22511_22516().ForegroundColor = fg;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22560,22587);

f_114_22560_22565().BackgroundColor = bg;
DynAbs.Tracing.TraceSender.TraceExitFinally(114,22463,22606);
                }
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(114,21791,22632);

System.Management.Automation.Host.PSHostRawUserInterface
f_114_22110_22115()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22110, 22115);
return return_v;
}


System.ConsoleColor
f_114_22110_22131(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.ForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22110, 22131);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_22168_22173()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22168, 22173);
return return_v;
}


System.ConsoleColor
f_114_22168_22189(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22168, 22189);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_22210_22215()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22210, 22215);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_22268_22273()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22268, 22273);
return return_v;
}


int
f_114_22372_22425(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult,bool
newLine)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult:transcribeResult, newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 22372, 22425);
return 0;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_22511_22516()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22511, 22516);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_22560_22565()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22560, 22565);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,21791,22632);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,21791,22632);
}
		}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ConsoleOutWriteHelper(ReadOnlySpan<char> value, bool newLine)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,22644,22994);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22803,22983) || true) && (newLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,22803,22983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22848,22877);

f_114_22848_22876(f_114_22848_22859(), value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,22803,22983);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,22803,22983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,22943,22968);

f_114_22943_22967(f_114_22943_22954(), value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,22803,22983);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,22644,22994);

System.IO.TextWriter
f_114_22848_22859()
{
var return_v =                 Console.Out;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22848, 22859);
return return_v;
}


int
f_114_22848_22876(System.IO.TextWriter
this_param,System.ReadOnlySpan<char>
buffer)
{
this_param.WriteLine( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 22848, 22876);
return 0;
}


System.IO.TextWriter
f_114_22943_22954()
{
var return_v =                 Console.Out;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 22943, 22954);
return return_v;
}


int
f_114_22943_22967(System.IO.TextWriter
this_param,System.ReadOnlySpan<char>
buffer)
{
this_param.Write( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 22943, 22967);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,22644,22994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,22644,22994);
}
		}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void WriteLineToConsole(ReadOnlySpan<char> value, bool transcribeResult)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,23006,23238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,23172,23227);

f_114_23172_23226(this, value, transcribeResult, newLine: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,23006,23238);

int
f_114_23172_23226(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ReadOnlySpan<char>
value,bool
transcribeResult,bool
newLine)
{
this_param.WriteToConsole( value, transcribeResult, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 23172, 23226);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,23006,23238);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,23006,23238);
}
		}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WriteLineToConsole(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,23250,23520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,23439,23509);

f_114_23439_23508(this, foregroundColor, backgroundColor, text, newLine: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,23250,23520);

int
f_114_23439_23508(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
text,bool
newLine)
{
this_param.WriteToConsole( foregroundColor, backgroundColor, text, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 23439, 23508);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,23250,23520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,23250,23520);
}
		}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WriteLineToConsole(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,23532,23721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,23661,23710);

f_114_23661_23709(this, text, transcribeResult: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,23532,23721);

int
f_114_23661_23709(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteLineToConsole( (System.ReadOnlySpan<char>)value, transcribeResult:transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 23661, 23709);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,23532,23721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,23532,23721);
}
		}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WriteLineToConsole()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,23733,23938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,23851,23927);

f_114_23851_23926(this, f_114_23866_23885(), transcribeResult: true, newLine: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,23733,23938);

string
f_114_23866_23885()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 23866, 23885);
return return_v;
}


int
f_114_23851_23926(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult,bool
newLine)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult:transcribeResult, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 23851, 23926);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,23733,23938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,23733,23938);
}
		}

public override void Write(string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,24410,24519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,24475,24508);

f_114_24475_24507(this, value, newLine: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,24410,24519);

int
f_114_24475_24507(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
newLine)
{
this_param.WriteImpl( value, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 24475, 24507);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,24410,24519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,24410,24519);
}
		}

private void WriteImpl(string value, bool newLine)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,24531,25813);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,24606,24705) || true) && (f_114_24610_24637(value)&&(DynAbs.Tracing.TraceSender.Expression_True(114, 24610, 24649)&&!newLine))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,24606,24705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,24683,24690);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,24606,24705);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,24788,25044) || true) && (s_h != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,24788,25044);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,24837,25029) || true) && (newLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,24837,25029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,24890,24911);

f_114_24890_24910(                    s_h, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,24837,25029);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,24837,25029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,24993,25010);

f_114_24993_25009(                    s_h, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,24837,25029);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,24788,25044);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25060,25149);

TextWriter 
writer = (DynAbs.Tracing.TraceSender.Conditional_F1(114, 25080, 25106)||((f_114_25080_25106()&&DynAbs.Tracing.TraceSender.Conditional_F2(114, 25109, 25120))||DynAbs.Tracing.TraceSender.Conditional_F3(114, 25123, 25148)))?f_114_25109_25120():f_114_25123_25148(_parent)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25165,25802) || true) && (f_114_25169_25191(_parent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,25165,25802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25225,25313);

f_114_25225_25312(writer == f_114_25246_25270(_parent).textWriter, "writers should be the same");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25333,25375);

f_114_25333_25374(f_114_25333_25357(_parent), value);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25395,25523) || true) && (newLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,25395,25523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25448,25504);

f_114_25448_25503(f_114_25448_25472(_parent), f_114_25483_25502());
DynAbs.Tracing.TraceSender.TraceExitCondition(114,25395,25523);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,25165,25802);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,25165,25802);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25589,25787) || true) && (newLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,25589,25787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25642,25666);

f_114_25642_25665(                    writer, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,25589,25787);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,25589,25787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,25748,25768);

f_114_25748_25767(                    writer, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,25589,25787);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,25165,25802);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,24531,25813);

bool
f_114_24610_24637(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 24610, 24637);
return return_v;
}


int
f_114_24890_24910(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 24890, 24910);
return 0;
}


int
f_114_24993_25009(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 24993, 25009);
return 0;
}


bool
f_114_25080_25106()
{
var return_v = Console.IsOutputRedirected ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25080, 25106);
return return_v;
}


System.IO.TextWriter
f_114_25109_25120()
{
var return_v = Console.Out ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25109, 25120);
return return_v;
}


System.IO.TextWriter
f_114_25123_25148(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ConsoleTextWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25123, 25148);
return return_v;
}


bool
f_114_25169_25191(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.IsRunningAsync;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25169, 25191);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_114_25246_25270(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.OutputSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25246, 25270);
return return_v;
}


int
f_114_25225_25312(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 25225, 25312);
return 0;
}


Microsoft.PowerShell.WrappedSerializer
f_114_25333_25357(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.OutputSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25333, 25357);
return return_v;
}


int
f_114_25333_25374(Microsoft.PowerShell.WrappedSerializer
this_param,string
o)
{
this_param.Serialize( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 25333, 25374);
return 0;
}


Microsoft.PowerShell.WrappedSerializer
f_114_25448_25472(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.OutputSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25448, 25472);
return return_v;
}


string
f_114_25483_25502()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 25483, 25502);
return return_v;
}


int
f_114_25448_25503(Microsoft.PowerShell.WrappedSerializer
this_param,string
o)
{
this_param.Serialize( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 25448, 25503);
return 0;
}


int
f_114_25642_25665(System.IO.TextWriter
this_param,string
value)
{
this_param.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 25642, 25665);
return 0;
}


int
f_114_25748_25767(System.IO.TextWriter
this_param,string
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 25748, 25767);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,24531,25813);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,24531,25813);
}
		}

public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,26500,26699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,26625,26688);

f_114_26625_26687(this, foregroundColor, backgroundColor, value, newLine: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,26500,26699);

int
f_114_26625_26687(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
value,bool
newLine)
{
this_param.Write( foregroundColor, backgroundColor, value, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 26625, 26687);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,26500,26699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,26500,26699);
}
		}

public override void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,27384,27586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,27513,27575);

f_114_27513_27574(this, foregroundColor, backgroundColor, value, newLine: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,27384,27586);

int
f_114_27513_27574(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
value,bool
newLine)
{
this_param.Write( foregroundColor, backgroundColor, value, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 27513, 27574);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,27384,27586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,27384,27586);
}
		}

private void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value, bool newLine)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,27598,28400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,27836,27849);
            // Sync access so that we don't race on color settings if called from multiple threads.
            lock (_instanceLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,27883,27923);

ConsoleColor 
fg = f_114_27901_27922(f_114_27901_27906())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,27941,27981);

ConsoleColor 
bg = f_114_27959_27980(f_114_27959_27964())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,28001,28041);

f_114_28001_28006().ForegroundColor = foregroundColor;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,28059,28099);

f_114_28059_28064().BackgroundColor = backgroundColor;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,28163,28194);

f_114_28163_28193(                    this, value, newLine);
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(114,28231,28374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,28279,28306);

f_114_28279_28284().ForegroundColor = fg;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,28328,28355);

f_114_28328_28333().BackgroundColor = bg;
DynAbs.Tracing.TraceSender.TraceExitFinally(114,28231,28374);
                }
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(114,27598,28400);

System.Management.Automation.Host.PSHostRawUserInterface
f_114_27901_27906()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 27901, 27906);
return return_v;
}


System.ConsoleColor
f_114_27901_27922(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.ForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 27901, 27922);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_27959_27964()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 27959, 27964);
return return_v;
}


System.ConsoleColor
f_114_27959_27980(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 27959, 27980);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_28001_28006()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 28001, 28006);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_28059_28064()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 28059, 28064);
return return_v;
}


int
f_114_28163_28193(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
newLine)
{
this_param.WriteImpl( value, newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 28163, 28193);
return 0;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_28279_28284()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 28279, 28284);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_28328_28333()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 28328, 28333);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,27598,28400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,27598,28400);
}
		}

public override void WriteLine(string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,28833,28950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,28902,28939);

f_114_28902_28938(            this, value, newLine: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,28833,28950);

int
f_114_28902_28938(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
newLine)
{
this_param.WriteImpl( value, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 28902, 28938);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,28833,28950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,28833,28950);
}
		}

public override void WriteLine()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,29341,29461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,29398,29450);

f_114_29398_29449(            this, f_114_29413_29432(), newLine: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,29341,29461);

string
f_114_29413_29432()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 29413, 29432);
return return_v;
}


int
f_114_29398_29449(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
newLine)
{
this_param.WriteImpl( value, newLine:newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 29398, 29449);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,29341,29461);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,29341,29461);
}
		}

internal List<string> WrapText(string text, int maxWidthInBufferCells)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,31037,34223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31132,31173);

List<string> 
result = f_114_31154_31172()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31189,31255);

List<Word> 
words = f_114_31208_31254(this, text, maxWidthInBufferCells)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31269,31351) || true) && (f_114_31273_31284(words)< 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,31269,31351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31322,31336);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,31269,31351);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31367,31411);

IEnumerator<Word> 
e = f_114_31389_31410(words)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31425,31444);

bool 
valid = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31458,31478);

int 
cellCounter = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31492,31533);

StringBuilder 
line = f_114_31513_31532()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31547,31563);

string 
l = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,31579,34182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31614,31635);

valid = f_114_31622_31634(e);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31653,32018) || true) && (!valid)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,31653,32018);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31705,31969) || true) && (f_114_31709_31720(line)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,31705,31969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31774,31794);

l = f_114_31778_31793(line);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31820,31906);

f_114_31820_31905(f_114_31831_31859(f_114_31831_31836(), l)<= maxWidthInBufferCells, "line is too long");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31932,31946);

f_114_31932_31945(                        result, l);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,31705,31969);
}
DynAbs.Tracing.TraceSender.TraceBreak(114,31993,31999);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,31653,32018);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32038,32481) || true) && ((e.Current.Flags & WordFlags.IsNewline) > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,32038,32481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32127,32147);

l = f_114_32131_32146(line);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32169,32255);

f_114_32169_32254(f_114_32180_32208(f_114_32180_32185(), l)<= maxWidthInBufferCells, "line is too long");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32277,32291);

f_114_32277_32290(                    result, l);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32366,32393);

line = f_114_32373_32392();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32415,32431);

cellCounter = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32453,32462);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,32038,32481);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32542,34152) || true) && (cellCounter + e.Current.CellCount <= maxWidthInBufferCells)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,32542,34152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32697,32725);

f_114_32697_32724(                    // yes, add it to the line.

                    line, e.Current.Text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32747,32782);

cellCounter += e.Current.CellCount;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,32542,34152);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,32542,34152);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,32973,33433) || true) && ((e.Current.Flags & WordFlags.IsWhitespace) == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,32973,33433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33074,33094);

l = f_114_33078_33093(line);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33120,33206);

f_114_33120_33205(f_114_33131_33159(f_114_33131_33136(), l)<= maxWidthInBufferCells, "line is too long");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33232,33246);

f_114_33232_33245(                        result, l);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33274,33315);

line = f_114_33281_33314(e.Current.Text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33341,33375);

cellCounter = e.Current.CellCount;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33401,33410);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,32973,33433);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33514,33558);

int 
w = maxWidthInBufferCells - cellCounter
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33580,33668);

f_114_33580_33667(w < e.Current.CellCount, "width remaining should be less than size of word");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33692,33736);

f_114_33692_33735(
                    line, f_114_33704_33734(e.Current.Text, 0, w));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33760,33780);

l = f_114_33764_33779(line);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33802,33895);

f_114_33802_33894(f_114_33813_33841(f_114_33813_33818(), l)== maxWidthInBufferCells, "line should exactly fit");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33917,33931);

f_114_33917_33930(                    result, l);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,33955,34002);

string 
remaining = f_114_33974_34001(e.Current.Text, w)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,34024,34060);

line = f_114_34031_34059(remaining);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,34082,34133);

cellCounter = f_114_34096_34132(f_114_34096_34101(), remaining);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,32542,34152);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,31579,34182);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,31579,34182) || true) && (valid)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,31579,34182);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,31579,34182);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,34198,34212);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,31037,34223);

System.Collections.Generic.List<string>
f_114_31154_31172()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31154, 31172);
return return_v;
}


System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
f_114_31208_31254(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,int
maxWidthInBufferCells)
{
var return_v = this_param.ChopTextIntoWords( text, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31208, 31254);
return return_v;
}


int
f_114_31273_31284(System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 31273, 31284);
return return_v;
}


System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>.Enumerator
f_114_31389_31410(System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
this_param)
{
var return_v = this_param.GetEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31389, 31410);
return return_v;
}


System.Text.StringBuilder
f_114_31513_31532()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31513, 31532);
return return_v;
}


bool
f_114_31622_31634(System.Collections.Generic.IEnumerator<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31622, 31634);
return return_v;
}


int
f_114_31709_31720(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 31709, 31720);
return return_v;
}


string
f_114_31778_31793(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31778, 31793);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_31831_31836()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 31831, 31836);
return return_v;
}


int
f_114_31831_31859(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31831, 31859);
return return_v;
}


int
f_114_31820_31905(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31820, 31905);
return 0;
}


int
f_114_31932_31945(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 31932, 31945);
return 0;
}


string
f_114_32131_32146(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 32131, 32146);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_32180_32185()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 32180, 32185);
return return_v;
}


int
f_114_32180_32208(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 32180, 32208);
return return_v;
}


int
f_114_32169_32254(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 32169, 32254);
return 0;
}


int
f_114_32277_32290(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 32277, 32290);
return 0;
}


System.Text.StringBuilder
f_114_32373_32392()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 32373, 32392);
return return_v;
}


System.Text.StringBuilder
f_114_32697_32724(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 32697, 32724);
return return_v;
}


string
f_114_33078_33093(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33078, 33093);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_33131_33136()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 33131, 33136);
return return_v;
}


int
f_114_33131_33159(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33131, 33159);
return return_v;
}


int
f_114_33120_33205(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33120, 33205);
return 0;
}


int
f_114_33232_33245(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33232, 33245);
return 0;
}


System.Text.StringBuilder
f_114_33281_33314(string
value)
{
var return_v = new System.Text.StringBuilder( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33281, 33314);
return return_v;
}


int
f_114_33580_33667(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33580, 33667);
return 0;
}


string
f_114_33704_33734(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33704, 33734);
return return_v;
}


System.Text.StringBuilder
f_114_33692_33735(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33692, 33735);
return return_v;
}


string
f_114_33764_33779(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33764, 33779);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_33813_33818()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 33813, 33818);
return return_v;
}


int
f_114_33813_33841(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33813, 33841);
return return_v;
}


int
f_114_33802_33894(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33802, 33894);
return 0;
}


int
f_114_33917_33930(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33917, 33930);
return 0;
}


string
f_114_33974_34001(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 33974, 34001);
return return_v;
}


System.Text.StringBuilder
f_114_34031_34059(string
value)
{
var return_v = new System.Text.StringBuilder( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 34031, 34059);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_34096_34101()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 34096, 34101);
return return_v;
}


int
f_114_34096_34132(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 34096, 34132);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,31037,34223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,31037,34223);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        /// <summary>
        /// Struct used by WrapText.
        /// </summary>

        [Flags]
        internal enum WordFlags
        {
            IsWhitespace = 0x01,
            IsNewline = 0x02
        }

internal struct Word
        {

internal int CellCount;

internal string Text;

internal WordFlags Flags;
static Word(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(114,34460,34613);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(114,34460,34613);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,34460,34613);
}
        }

internal List<Word> ChopTextIntoWords(string text, int maxWidthInBufferCells)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,35791,38264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,35893,35930);

List<Word> 
result = f_114_35913_35929()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,35946,36039) || true) && (f_114_35950_35976(text))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,35946,36039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36010,36024);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,35946,36039);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36055,36147) || true) && (maxWidthInBufferCells < 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,36055,36147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36118,36132);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,36055,36147);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36163,36194);

text = f_114_36170_36193(text, '\t', ' ');
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36210,36236);

result = f_114_36219_36235();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36368,36387);

int 
startIndex = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36401,36417);

int 
wordEnd = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36431,36449);

bool 
inWs = false
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36465,38053) || true) && (wordEnd < f_114_36482_36493(text))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,36465,38053);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36527,38008) || true) && (f_114_36531_36544(text, wordEnd)== '\n')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,36527,38008);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36594,36845) || true) && (startIndex < wordEnd)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,36594,36845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36746,36822);

f_114_36746_36821(this, text, startIndex, wordEnd, maxWidthInBufferCells, inWs, ref result);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,36594,36845);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36909,36929);

Word 
w = f_114_36918_36928()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,36951,36981);

w.Flags = WordFlags.IsNewline;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37003,37017);

f_114_37003_37016(                    result, w);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37079,37089);

++wordEnd;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37111,37132);

startIndex = wordEnd;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37156,37169);

inWs = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37191,37200);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,36527,38008);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,36527,38008);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37242,38008) || true) && (f_114_37246_37259(text, wordEnd)== ' ')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,37242,38008);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37308,37589) || true) && (!inWs)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,37308,37589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37443,37519);

f_114_37443_37518(this, text, startIndex, wordEnd, maxWidthInBufferCells, inWs, ref result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37545,37566);

startIndex = wordEnd;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,37308,37589);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37613,37625);

inWs = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,37242,38008);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,37242,38008);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37748,37952) || true) && (inWs)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,37748,37952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37806,37882);

f_114_37806_37881(this, text, startIndex, wordEnd, maxWidthInBufferCells, inWs, ref result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37908,37929);

startIndex = wordEnd;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,37748,37952);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,37976,37989);

inWs = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,37242,38008);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,36527,38008);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,38028,38038);

++wordEnd;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,36465,38053);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,36465,38053);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,36465,38053);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,38069,38223) || true) && (startIndex != wordEnd)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,38069,38223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,38128,38208);

f_114_38128_38207(this, text, startIndex, f_114_38154_38165(text), maxWidthInBufferCells, inWs, ref result);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,38069,38223);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,38239,38253);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,35791,38264);

System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
f_114_35913_35929()
{
var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 35913, 35929);
return return_v;
}


bool
f_114_35950_35976(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 35950, 35976);
return return_v;
}


string
f_114_36170_36193(string
this_param,char
oldChar,char
newChar)
{
var return_v = this_param.Replace( oldChar, newChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 36170, 36193);
return return_v;
}


System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
f_114_36219_36235()
{
var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 36219, 36235);
return return_v;
}


int
f_114_36482_36493(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 36482, 36493);
return return_v;
}


char
f_114_36531_36544(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 36531, 36544);
return return_v;
}


int
f_114_36746_36821(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,int
startIndex,int
endIndex,int
maxWidthInBufferCells,bool
isWhitespace,ref System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
result)
{
this_param.AddWord( text, startIndex, endIndex, maxWidthInBufferCells, isWhitespace, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 36746, 36821);
return 0;
}


Microsoft.PowerShell.ConsoleHostUserInterface.Word
f_114_36918_36928()
{
var return_v = new Microsoft.PowerShell.ConsoleHostUserInterface.Word();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 36918, 36928);
return return_v;
}


int
f_114_37003_37016(System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
this_param,Microsoft.PowerShell.ConsoleHostUserInterface.Word
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 37003, 37016);
return 0;
}


char
f_114_37246_37259(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 37246, 37259);
return return_v;
}


int
f_114_37443_37518(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,int
startIndex,int
endIndex,int
maxWidthInBufferCells,bool
isWhitespace,ref System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
result)
{
this_param.AddWord( text, startIndex, endIndex, maxWidthInBufferCells, isWhitespace, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 37443, 37518);
return 0;
}


int
f_114_37806_37881(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,int
startIndex,int
endIndex,int
maxWidthInBufferCells,bool
isWhitespace,ref System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
result)
{
this_param.AddWord( text, startIndex, endIndex, maxWidthInBufferCells, isWhitespace, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 37806, 37881);
return 0;
}


int
f_114_38154_38165(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 38154, 38165);
return return_v;
}


int
f_114_38128_38207(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,int
startIndex,int
endIndex,int
maxWidthInBufferCells,bool
isWhitespace,ref System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
result)
{
this_param.AddWord( text, startIndex, endIndex, maxWidthInBufferCells, isWhitespace, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 38128, 38207);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,35791,38264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,35791,38264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void AddWord(string text, int startIndex, int endIndex,
            int maxWidthInBufferCells, bool isWhitespace, ref List<Word> result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,39320,41013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,39491,39564);

f_114_39491_39563(endIndex >= startIndex, "startIndex must be before endIndex");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,39578,39633);

f_114_39578_39632(endIndex >= 0, "endIndex must be positive");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,39647,39706);

f_114_39647_39705(startIndex >= 0, "startIndex must be positive");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,39720,39797);

f_114_39720_39796(startIndex < f_114_39744_39755(text), "startIndex must be within the string");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,39811,39885);

f_114_39811_39884(endIndex <= f_114_39834_39845(text), "endIndex must be within the string");
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,39901,41002) || true) && (startIndex < endIndex)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,39901,41002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,39963,40026);

int 
i = f_114_39971_40025(endIndex, startIndex + maxWidthInBufferCells)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40044,40064);

Word 
w = f_114_40053_40063()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40082,40192) || true) && (isWhitespace)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,40082,40192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40140,40173);

w.Flags = WordFlags.IsWhitespace;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,40082,40192);
}
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,40212,40799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40255,40307);

w.Text = f_114_40264_40306(text, startIndex, i - startIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40329,40377);

w.CellCount = f_114_40343_40376(f_114_40343_40348(), w.Text);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40399,40766) || true) && (w.CellCount <= maxWidthInBufferCells)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,40399,40766);
DynAbs.Tracing.TraceSender.TraceBreak(114,40550,40556);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,40399,40766);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,40399,40766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40739,40743);

--i;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,40399,40766);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,40212,40799);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40212,40799) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,40212,40799);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,40212,40799);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40819,40920);

f_114_40819_40919(f_114_40830_40863(f_114_40830_40835(), w.Text)<= maxWidthInBufferCells, "word should not exceed max");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40938,40952);

f_114_40938_40951(                result, w);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,40972,40987);

startIndex = i;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,39901,41002);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,39901,41002);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,39901,41002);
}DynAbs.Tracing.TraceSender.TraceExitMethod(114,39320,41013);

int
f_114_39491_39563(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 39491, 39563);
return 0;
}


int
f_114_39578_39632(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 39578, 39632);
return 0;
}


int
f_114_39647_39705(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 39647, 39705);
return 0;
}


int
f_114_39744_39755(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 39744, 39755);
return return_v;
}


int
f_114_39720_39796(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 39720, 39796);
return 0;
}


int
f_114_39834_39845(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 39834, 39845);
return return_v;
}


int
f_114_39811_39884(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 39811, 39884);
return 0;
}


int
f_114_39971_40025(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 39971, 40025);
return return_v;
}


Microsoft.PowerShell.ConsoleHostUserInterface.Word
f_114_40053_40063()
{
var return_v = new Microsoft.PowerShell.ConsoleHostUserInterface.Word();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 40053, 40063);
return return_v;
}


string
f_114_40264_40306(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 40264, 40306);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_40343_40348()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 40343, 40348);
return return_v;
}


int
f_114_40343_40376(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 40343, 40376);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_40830_40835()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 40830, 40835);
return return_v;
}


int
f_114_40830_40863(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 40830, 40863);
return return_v;
}


int
f_114_40819_40919(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 40819, 40919);
return 0;
}


int
f_114_40938_40951(System.Collections.Generic.List<Microsoft.PowerShell.ConsoleHostUserInterface.Word>
this_param,Microsoft.PowerShell.ConsoleHostUserInterface.Word
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 40938, 40951);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,39320,41013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,39320,41013);
}
		}

internal string WrapToCurrentWindowWidth(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,41025,41726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41103,41142);

StringBuilder 
sb = f_114_41122_41141()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41348,41412);

List<string> 
lines = f_114_41369_41411(this, text, f_114_41384_41389().WindowSize.Width - 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41426,41440);

int 
count = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41454,41678);
foreach(string s in f_114_41475_41480_I(lines) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,41454,41678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41514,41527);

f_114_41514_41526(                sb, s);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41545,41663) || true) && (++count != f_114_41560_41571(lines))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,41545,41663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41613,41644);

f_114_41613_41643(                    sb, f_114_41623_41642());
DynAbs.Tracing.TraceSender.TraceExitCondition(114,41545,41663);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,41454,41678);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,1,225);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,1,225);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,41694,41715);

return f_114_41701_41714(sb);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,41025,41726);

System.Text.StringBuilder
f_114_41122_41141()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 41122, 41141);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_41384_41389()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 41384, 41389);
return return_v;
}


System.Collections.Generic.List<string>
f_114_41369_41411(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text,int
maxWidthInBufferCells)
{
var return_v = this_param.WrapText( text, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 41369, 41411);
return return_v;
}


System.Text.StringBuilder
f_114_41514_41526(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 41514, 41526);
return return_v;
}


int
f_114_41560_41571(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 41560, 41571);
return return_v;
}


string
f_114_41623_41642()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 41623, 41642);
return return_v;
}


System.Text.StringBuilder
f_114_41613_41643(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 41613, 41643);
return return_v;
}


System.Collections.Generic.List<string>
f_114_41475_41480_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 41475, 41480);
return return_v;
}


string
f_114_41701_41714(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 41701, 41714);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,41025,41726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,41025,41726);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void WriteDebugLine(string message)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,42345,43215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,42488,42500);

bool 
unused
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,42514,42581);

message = f_114_42524_42580(message, out unused);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,42681,43204) || true) && (f_114_42685_42704(_parent)== Serialization.DataFormat.XML)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,42681,43204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,42770,42822);

f_114_42770_42821(f_114_42770_42793(_parent), message, "debug");
DynAbs.Tracing.TraceSender.TraceExitCondition(114,42681,43204);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,42681,43204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,42992,43189);

f_114_42992_43188(this, f_114_43024_43044(), f_114_43067_43087(), f_114_43110_43187(f_114_43128_43177(), message));
DynAbs.Tracing.TraceSender.TraceExitCondition(114,42681,43204);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,42345,43215);

string
f_114_42524_42580(string
message,out bool
matchPattern)
{
var return_v = HostUtilities.RemoveGuidFromMessage( message, out matchPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 42524, 42580);
return return_v;
}


Microsoft.PowerShell.Serialization.DataFormat
f_114_42685_42704(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 42685, 42704);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_114_42770_42793(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 42770, 42793);
return return_v;
}


int
f_114_42770_42821(Microsoft.PowerShell.WrappedSerializer
this_param,string
o,string
streamName)
{
this_param.Serialize( (object)o, streamName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 42770, 42821);
return 0;
}


System.ConsoleColor
f_114_43024_43044()
{
var return_v = DebugForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 43024, 43044);
return return_v;
}


System.ConsoleColor
f_114_43067_43087()
{
var return_v = DebugBackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 43067, 43087);
return return_v;
}


string
f_114_43128_43177()
{
var return_v = ConsoleHostUserInterfaceStrings.DebugFormatString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 43128, 43177);
return return_v;
}


string
f_114_43110_43187(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 43110, 43187);
return return_v;
}


int
f_114_42992_43188(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
value)
{
this_param.WriteLine( foregroundColor, backgroundColor, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 42992, 43188);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,42345,43215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,42345,43215);
}
		}

public override void WriteInformation(InformationRecord record)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,43346,43816);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,43515,43805) || true) && (f_114_43519_43538(_parent)== Serialization.DataFormat.XML)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,43515,43805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,43604,43661);

f_114_43604_43660(f_114_43604_43627(_parent), record, "information");
DynAbs.Tracing.TraceSender.TraceExitCondition(114,43515,43805);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,43515,43805);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,43515,43805);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,43346,43816);

Microsoft.PowerShell.Serialization.DataFormat
f_114_43519_43538(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 43519, 43538);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_114_43604_43627(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 43604, 43627);
return return_v;
}


int
f_114_43604_43660(Microsoft.PowerShell.WrappedSerializer
this_param,System.Management.Automation.InformationRecord
o,string
streamName)
{
this_param.Serialize( (object)o, streamName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 43604, 43660);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,43346,43816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,43346,43816);
}
		}

public override void WriteVerboseLine(string message)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,44401,45194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,44546,44558);

bool 
unused
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,44572,44639);

message = f_114_44582_44638(message, out unused);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,44756,45183) || true) && (f_114_44760_44779(_parent)== Serialization.DataFormat.XML)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,44756,45183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,44845,44899);

f_114_44845_44898(f_114_44845_44868(_parent), message, "verbose");
DynAbs.Tracing.TraceSender.TraceExitCondition(114,44756,45183);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,44756,45183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,44965,45168);

f_114_44965_45167(this, f_114_44997_45019(), f_114_45042_45064(), f_114_45087_45166(f_114_45105_45156(), message));
DynAbs.Tracing.TraceSender.TraceExitCondition(114,44756,45183);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,44401,45194);

string
f_114_44582_44638(string
message,out bool
matchPattern)
{
var return_v = HostUtilities.RemoveGuidFromMessage( message, out matchPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 44582, 44638);
return return_v;
}


Microsoft.PowerShell.Serialization.DataFormat
f_114_44760_44779(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 44760, 44779);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_114_44845_44868(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 44845, 44868);
return return_v;
}


int
f_114_44845_44898(Microsoft.PowerShell.WrappedSerializer
this_param,string
o,string
streamName)
{
this_param.Serialize( (object)o, streamName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 44845, 44898);
return 0;
}


System.ConsoleColor
f_114_44997_45019()
{
var return_v = VerboseForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 44997, 45019);
return return_v;
}


System.ConsoleColor
f_114_45042_45064()
{
var return_v = VerboseBackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 45042, 45064);
return return_v;
}


string
f_114_45105_45156()
{
var return_v = ConsoleHostUserInterfaceStrings.VerboseFormatString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 45105, 45156);
return return_v;
}


string
f_114_45087_45166(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 45087, 45166);
return return_v;
}


int
f_114_44965_45167(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
value)
{
this_param.WriteLine( foregroundColor, backgroundColor, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 44965, 45167);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,44401,45194);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,44401,45194);
}
		}

public override void WriteWarningLine(string message)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,45779,46572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,45924,45936);

bool 
unused
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,45950,46017);

message = f_114_45960_46016(message, out unused);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,46134,46561) || true) && (f_114_46138_46157(_parent)== Serialization.DataFormat.XML)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,46134,46561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,46223,46277);

f_114_46223_46276(f_114_46223_46246(_parent), message, "warning");
DynAbs.Tracing.TraceSender.TraceExitCondition(114,46134,46561);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,46134,46561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,46343,46546);

f_114_46343_46545(this, f_114_46375_46397(), f_114_46420_46442(), f_114_46465_46544(f_114_46483_46534(), message));
DynAbs.Tracing.TraceSender.TraceExitCondition(114,46134,46561);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,45779,46572);

string
f_114_45960_46016(string
message,out bool
matchPattern)
{
var return_v = HostUtilities.RemoveGuidFromMessage( message, out matchPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 45960, 46016);
return return_v;
}


Microsoft.PowerShell.Serialization.DataFormat
f_114_46138_46157(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 46138, 46157);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_114_46223_46246(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 46223, 46246);
return return_v;
}


int
f_114_46223_46276(Microsoft.PowerShell.WrappedSerializer
this_param,string
o,string
streamName)
{
this_param.Serialize( (object)o, streamName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 46223, 46276);
return 0;
}


System.ConsoleColor
f_114_46375_46397()
{
var return_v = WarningForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 46375, 46397);
return return_v;
}


System.ConsoleColor
f_114_46420_46442()
{
var return_v = WarningBackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 46420, 46442);
return return_v;
}


string
f_114_46483_46534()
{
var return_v = ConsoleHostUserInterfaceStrings.WarningFormatString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 46483, 46534);
return return_v;
}


string
f_114_46465_46544(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 46465, 46544);
return return_v;
}


int
f_114_46343_46545(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
value)
{
this_param.WriteLine( foregroundColor, backgroundColor, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 46343, 46545);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,45779,46572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,45779,46572);
}
		}

public override void WriteProgress(Int64 sourceId, ProgressRecord record)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,46713,48052);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,46811,48041) || true) && (record == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,46811,48041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,46863,46930);

f_114_46863_46929(false, "WriteProgress called with null ProgressRecord");
DynAbs.Tracing.TraceSender.TraceExitCondition(114,46811,48041);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,46811,48041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,46996,47014);

bool 
matchPattern
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47032,47147);

string 
currentOperation = f_114_47058_47146(f_114_47104_47127(record), out matchPattern)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47165,47318) || true) && (matchPattern)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,47165,47318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47223,47299);

record = new ProgressRecord(record) { CurrentOperation = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => currentOperation,114,47232,47298) };
DynAbs.Tracing.TraceSender.TraceExitCondition(114,47165,47318);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47424,48026) || true) && (f_114_47428_47447(_parent)== Serialization.DataFormat.XML)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,47424,48026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47521,47551);

PSObject 
obj = f_114_47536_47550()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47573,47634);

f_114_47573_47633(f_114_47573_47587(obj), f_114_47592_47632("SourceId", sourceId));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47656,47713);

f_114_47656_47712(f_114_47656_47670(obj), f_114_47675_47711("Record", record));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47735,47786);

f_114_47735_47785(f_114_47735_47758(_parent), obj, "progress");
DynAbs.Tracing.TraceSender.TraceExitCondition(114,47424,48026);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,47424,48026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47874,47887);
                    lock (_instanceLock)
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,47937,47984);

f_114_47937_47983(this, sourceId, record);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(114,47424,48026);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,46811,48041);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,46713,48052);

int
f_114_46863_46929(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 46863, 46929);
return 0;
}


string
f_114_47104_47127(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 47104, 47127);
return return_v;
}


string
f_114_47058_47146(string
message,out bool
matchPattern)
{
var return_v = HostUtilities.RemoveIdentifierInfoFromMessage( message, out matchPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47058, 47146);
return return_v;
}


Microsoft.PowerShell.Serialization.DataFormat
f_114_47428_47447(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 47428, 47447);
return return_v;
}


System.Management.Automation.PSObject
f_114_47536_47550()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47536, 47550);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_114_47573_47587(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 47573, 47587);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_114_47592_47632(string
name,long
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47592, 47632);
return return_v;
}


int
f_114_47573_47633(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47573, 47633);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_114_47656_47670(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 47656, 47670);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_114_47675_47711(string
name,System.Management.Automation.ProgressRecord
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47675, 47711);
return return_v;
}


int
f_114_47656_47712(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47656, 47712);
return 0;
}


Microsoft.PowerShell.WrappedSerializer
f_114_47735_47758(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 47735, 47758);
return return_v;
}


int
f_114_47735_47785(Microsoft.PowerShell.WrappedSerializer
this_param,System.Management.Automation.PSObject
o,string
streamName)
{
this_param.Serialize( (object)o, streamName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47735, 47785);
return 0;
}


int
f_114_47937_47983(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,long
sourceId,System.Management.Automation.ProgressRecord
record)
{
this_param.HandleIncomingProgressRecord( sourceId, record);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 47937, 47983);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,46713,48052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,46713,48052);
}
		}

public override void WriteErrorLine(string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,48064,48958);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48138,48225) || true) && (f_114_48142_48169(value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,48138,48225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48203,48210);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,48138,48225);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48241,48393);

TextWriter 
writer = (DynAbs.Tracing.TraceSender.Conditional_F1(114, 48261, 48314)||(((f_114_48262_48288_M(!Console.IsErrorRedirected)||(DynAbs.Tracing.TraceSender.Expression_False(114, 48262, 48313)||f_114_48292_48313(_parent)))
&&DynAbs.Tracing.TraceSender.Conditional_F2(114, 48334, 48359))||DynAbs.Tracing.TraceSender.Conditional_F3(114, 48379, 48392)))?f_114_48334_48359(_parent):f_114_48379_48392()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48409,48947) || true) && (f_114_48413_48432(_parent)== Serialization.DataFormat.XML)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,48409,48947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48498,48585);

f_114_48498_48584(writer == f_114_48519_48542(_parent).textWriter, "writers should be the same");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48605,48668);

f_114_48605_48667(f_114_48605_48628(_parent), value + f_114_48647_48666());
DynAbs.Tracing.TraceSender.TraceExitCondition(114,48409,48947);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,48409,48947);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48734,48932) || true) && (writer == f_114_48748_48773(_parent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,48734,48932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48796,48857);

f_114_48796_48856(this, f_114_48806_48826(), f_114_48828_48848(), value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,48734,48932);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,48734,48932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,48901,48932);

f_114_48901_48931(f_114_48901_48914(), value);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,48734,48932);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,48409,48947);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,48064,48958);

bool
f_114_48142_48169(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 48142, 48169);
return return_v;
}


bool
f_114_48262_48288_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48262, 48288);
return return_v;
}


bool
f_114_48292_48313(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.IsInteractive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48292, 48313);
return return_v;
}


System.IO.TextWriter
f_114_48334_48359(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ConsoleTextWriter
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48334, 48359);
return return_v;
}


System.IO.TextWriter
f_114_48379_48392()
{
var return_v = Console.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48379, 48392);
return return_v;
}


Microsoft.PowerShell.Serialization.DataFormat
f_114_48413_48432(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48413, 48432);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_114_48519_48542(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48519, 48542);
return return_v;
}


int
f_114_48498_48584(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 48498, 48584);
return 0;
}


Microsoft.PowerShell.WrappedSerializer
f_114_48605_48628(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48605, 48628);
return return_v;
}


string
f_114_48647_48666()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48647, 48666);
return return_v;
}


int
f_114_48605_48667(Microsoft.PowerShell.WrappedSerializer
this_param,string
o)
{
this_param.Serialize( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 48605, 48667);
return 0;
}


System.IO.TextWriter
f_114_48748_48773(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ConsoleTextWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48748, 48773);
return return_v;
}


System.ConsoleColor
f_114_48806_48826()
{
var return_v = ErrorForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48806, 48826);
return return_v;
}


System.ConsoleColor
f_114_48828_48848()
{
var return_v = ErrorBackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48828, 48848);
return return_v;
}


int
f_114_48796_48856(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
value)
{
this_param.WriteLine( foregroundColor, backgroundColor, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 48796, 48856);
return 0;
}


System.IO.TextWriter
f_114_48901_48914()
{
var return_v =                     Console.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 48901, 48914);
return return_v;
}


int
f_114_48901_48931(System.IO.TextWriter
this_param,string
value)
{
this_param.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 48901, 48931);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,48064,48958);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,48064,48958);
}
		}

public ConsoleColor FormatAccentColor {get; set; }

public ConsoleColor ErrorAccentColor {get; set; }

public ConsoleColor ErrorForegroundColor {get; set; }

public ConsoleColor ErrorBackgroundColor {get; set; }

public ConsoleColor WarningForegroundColor {get; set; }

public ConsoleColor WarningBackgroundColor {get; set; }

public ConsoleColor DebugForegroundColor {get; set; }

public ConsoleColor DebugBackgroundColor {get; set; }

public ConsoleColor VerboseForegroundColor {get; set; }

public ConsoleColor VerboseBackgroundColor {get; set; }

public ConsoleColor ProgressForegroundColor {get; set; }

public ConsoleColor ProgressBackgroundColor {get; set; }

internal static string Crlf ;

private const string 
Tab = "\x0009"
;

        internal enum ReadLineResult
        {
            endedOnEnter = 0,
            endedOnTab = 1,
            endedOnShiftTab = 2,
            endedOnBreak = 3
        }

private const int 
MaxInputLineLength = 1024
;

internal string ReadLine(bool endOnTab, string initialContent, out ReadLineResult result, bool calledFromPipeline, bool transcribeResult)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,52477,53316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,52639,52676);

result = ReadLineResult.endedOnEnter;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,52747,52786) || true) && (s_h != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,52747,52786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,52764,52786);

return f_114_52771_52785(s_h);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,52747,52786);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,52802,52827);

string 
restOfLine = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,52843,53033);

string 
s = (DynAbs.Tracing.TraceSender.Conditional_F1(114, 52854, 52867)||((f_114_52854_52867()&&DynAbs.Tracing.TraceSender.Conditional_F2(114, 52887, 52919))||DynAbs.Tracing.TraceSender.Conditional_F3(114, 52939, 53032)))?f_114_52887_52919(this, initialContent):f_114_52939_53032(this, endOnTab, initialContent, calledFromPipeline, ref restOfLine, ref result)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53049,53207) || true) && (transcribeResult)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,53049,53207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53103,53115);

f_114_53103_53114(this, s);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,53049,53207);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,53049,53207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53181,53192);

f_114_53181_53191(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,53049,53207);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53223,53280) || true) && (restOfLine != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,53223,53280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53264,53280);

s += restOfLine;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,53223,53280);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53296,53305);

return s;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,52477,53316);

string
f_114_52771_52785(System.Management.Automation.Host.PSHostUserInterface
this_param)
{
var return_v = this_param.ReadLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 52771, 52785);
return return_v;
}


bool
f_114_52854_52867()
{
var return_v = ReadFromStdin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 52854, 52867);
return return_v;
}


string
f_114_52887_52919(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
initialContent)
{
var return_v = this_param.ReadLineFromFile( initialContent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 52887, 52919);
return return_v;
}


string
f_114_52939_53032(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,bool
endOnTab,string
initialContent,bool
calledFromPipeline,ref string
restOfLine,ref Microsoft.PowerShell.ConsoleHostUserInterface.ReadLineResult
result)
{
var return_v = this_param.ReadLineFromConsole( endOnTab, initialContent, calledFromPipeline, ref restOfLine, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 52939, 53032);
return return_v;
}


int
f_114_53103_53114(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value)
{
this_param.PostRead( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 53103, 53114);
return 0;
}


int
f_114_53181_53191(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.PostRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 53181, 53191);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,52477,53316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,52477,53316);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string ReadLineFromFile(string initialContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,53328,55180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53407,53436);

var 
sb = f_114_53416_53435()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53450,53600) || true) && (!f_114_53455_53491(initialContent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,53450,53600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53525,53551);

f_114_53525_53550(                sb, initialContent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53569,53585);

f_114_53569_53584(                sb, '\n');
DynAbs.Tracing.TraceSender.TraceExitCondition(114,53450,53600);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53616,53656);

var 
consoleIn = f_114_53632_53655(f_114_53632_53649(_parent))
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53670,55132) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,53670,55132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53715,53742);

var 
inC = f_114_53725_53741(consoleIn)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,53760,54112) || true) && (inC == -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,53760,54112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54048,54093);

return (DynAbs.Tracing.TraceSender.Conditional_F1(114, 54055, 54069)||((f_114_54055_54064(sb)== 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(114, 54072, 54076))||DynAbs.Tracing.TraceSender.Conditional_F3(114, 54079, 54092)))?null :f_114_54079_54092(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,53760,54112);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54132,54161);

var 
c = unchecked((char)inC)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54179,54215) || true) && (f_114_54183_54192_M(!NoPrompt))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,54179,54215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54194,54215);

f_114_54194_54214(f_114_54194_54205(), c);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,54179,54215);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54235,54596) || true) && (c == '\r')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,54235,54596);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54364,54547) || true) && (f_114_54368_54384(consoleIn)== '\n')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,54364,54547);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54442,54481) || true) && (f_114_54446_54455_M(!NoPrompt))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,54442,54481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54457,54481);

f_114_54457_54480(f_114_54457_54468(), '\n');
DynAbs.Tracing.TraceSender.TraceExitCondition(114,54442,54481);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54507,54524);

f_114_54507_54523(                        consoleIn);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,54364,54547);
}
DynAbs.Tracing.TraceSender.TraceBreak(114,54571,54577);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,54235,54596);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54616,54696) || true) && (c == '\n')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,54616,54696);
DynAbs.Tracing.TraceSender.TraceBreak(114,54671,54677);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,54616,54696);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54907,55117) || true) && (c == '\b' &&(DynAbs.Tracing.TraceSender.Expression_True(114, 54911, 54933)&&f_114_54924_54933_M(!NoPrompt)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,54907,55117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,54975,55003);

f_114_54975_55002(                    sb, f_114_54985_54994(sb)- 1, 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,54907,55117);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,54907,55117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55085,55098);

f_114_55085_55097(                    sb, c);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,54907,55117);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,53670,55132);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,53670,55132);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,53670,55132);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55148,55169);

return f_114_55155_55168(sb);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,53328,55180);

System.Text.StringBuilder
f_114_53416_53435()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 53416, 53435);
return return_v;
}


bool
f_114_53455_53491(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 53455, 53491);
return return_v;
}


System.Text.StringBuilder
f_114_53525_53550(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 53525, 53550);
return return_v;
}


System.Text.StringBuilder
f_114_53569_53584(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 53569, 53584);
return return_v;
}


System.Lazy<System.IO.TextReader>
f_114_53632_53649(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ConsoleIn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 53632, 53649);
return return_v;
}


System.IO.TextReader
f_114_53632_53655(System.Lazy<System.IO.TextReader>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 53632, 53655);
return return_v;
}


int
f_114_53725_53741(System.IO.TextReader
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 53725, 53741);
return return_v;
}


int
f_114_54055_54064(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 54055, 54064);
return return_v;
}


string
f_114_54079_54092(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 54079, 54092);
return return_v;
}


bool
f_114_54183_54192_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 54183, 54192);
return return_v;
}


System.IO.TextWriter
f_114_54194_54205()
{
var return_v = Console.Out;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 54194, 54205);
return return_v;
}


int
f_114_54194_54214(System.IO.TextWriter
this_param,char
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 54194, 54214);
return 0;
}


int
f_114_54368_54384(System.IO.TextReader
this_param)
{
var return_v = this_param.Peek();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 54368, 54384);
return return_v;
}


bool
f_114_54446_54455_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 54446, 54455);
return return_v;
}


System.IO.TextWriter
f_114_54457_54468()
{
var return_v = Console.Out;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 54457, 54468);
return return_v;
}


int
f_114_54457_54480(System.IO.TextWriter
this_param,char
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 54457, 54480);
return 0;
}


int
f_114_54507_54523(System.IO.TextReader
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 54507, 54523);
return return_v;
}


bool
f_114_54924_54933_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 54924, 54933);
return return_v;
}


int
f_114_54985_54994(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 54985, 54994);
return return_v;
}


System.Text.StringBuilder
f_114_54975_55002(System.Text.StringBuilder
this_param,int
startIndex,int
length)
{
var return_v = this_param.Remove( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 54975, 55002);
return return_v;
}


System.Text.StringBuilder
f_114_55085_55097(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 55085, 55097);
return return_v;
}


string
f_114_55155_55168(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 55155, 55168);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,53328,55180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,53328,55180);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string ReadLineFromConsole(bool endOnTab, string initialContent, bool calledFromPipeline, ref string restOfLine, ref ReadLineResult result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,55192,67739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55364,55374);

f_114_55364_55373(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55466,55527);

ConsoleHandle 
handle = f_114_55489_55526()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55541,55604);

ConsoleControl.ConsoleModes 
m = f_114_55573_55603(handle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55620,55842);

const ConsoleControl.ConsoleModes 
DesiredMode =
                ConsoleControl.ConsoleModes.LineInput
                | ConsoleControl.ConsoleModes.EchoInput
                | ConsoleControl.ConsoleModes.ProcessedInput
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55858,56127) || true) && ((m & DesiredMode) != DesiredMode ||(DynAbs.Tracing.TraceSender.Expression_False(114, 55862, 55946)||(m & ConsoleControl.ConsoleModes.MouseInput) > 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,55858,56127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,55980,56025);

m &= ~ConsoleControl.ConsoleModes.MouseInput;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,56043,56060);

m |= DesiredMode;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,56078,56112);

f_114_56078_56111(handle, m);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,55858,56127);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58110,58133);

f_114_58110_58132(
            // If more characters are typed than you asked, then the next call to ReadConsole will return the
            // additional characters beyond those you requested.
            //
            // If input is terminated with a tab key, then the buffer returned will have a tab (ascii 0x9) at the
            // position where the tab key was hit.  If the user has arrowed backward over existing input in the line
            // buffer, the tab will overwrite whatever character was in that position. That character will be lost in
            // the input buffer, but since we echo each character the user types, it's still in the active screen buffer
            // and we can read the console output to get that character.
            //
            // If input is terminated with an enter key, then the buffer returned will have ascii 0x0D and 0x0A
            // (Carriage Return and Line Feed) as the last two characters of the buffer.
            //
            // If input is terminated with a break key (Ctrl-C, Ctrl-Break, Close, etc.), then the buffer will be
            // the empty string.

            _rawui);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58147,58165);

uint 
keyState = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58179,58203);

string 
s = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58217,58282);

Span<char> 
inputBuffer = stackalloc char[MaxInputLineLength + 1]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58296,58418) || true) && (f_114_58300_58321(initialContent)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,58296,58418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58359,58403);

f_114_58359_58382(                initialContent).CopyTo(inputBuffer);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,58296,58418);
}
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,58442,67286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58548,58668);

s += f_114_58553_58667(handle, f_114_58588_58609(initialContent), inputBuffer, MaxInputLineLength, endOnTab, out keyState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58686,58734);

f_114_58686_58733(s != null, "s should never be null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58939,59363) || true) && (f_114_58943_58951(s)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,58939,59363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,59006,59043);

result = ReadLineResult.endedOnBreak;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,59065,59074);

s = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,59098,59314) || true) && (calledFromPipeline)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,59098,59314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,59254,59291);

throw f_114_59260_59290();
DynAbs.Tracing.TraceSender.TraceExitCondition(114,59098,59314);
}
DynAbs.Tracing.TraceSender.TraceBreak(114,59338,59344);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,58939,59363);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,59458,59892) || true) && (f_114_59462_59519(s, f_114_59473_59492(), StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,59458,59892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,59569,59606);

result = ReadLineResult.endedOnEnter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,59785,59837);

s = f_114_59789_59836(s, f_114_59798_59806(s)- f_114_59809_59835(f_114_59809_59828()));
DynAbs.Tracing.TraceSender.TraceBreak(114,59867,59873);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,59458,59892);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,60114,60163);

int 
i = f_114_60122_60162(s, Tab, StringComparison.Ordinal)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,60183,62232) || true) && (endOnTab &&(DynAbs.Tracing.TraceSender.Expression_True(114, 60187, 60206)&&i != -1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,60183,62232);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,60414,61075) || true) && ((keyState & 0x10) == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,60414,61075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,60490,60525);

result = ReadLineResult.endedOnTab;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,60414,61075);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,60414,61075);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,60575,61075) || true) && ((keyState & 0x10) > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,60575,61075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,60650,60690);

result = ReadLineResult.endedOnShiftTab;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,60575,61075);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,60575,61075);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,60575,61075);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,60414,61075);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,61362,61423);

int 
leftover = f_114_61377_61422(f_114_61377_61382(), f_114_61403_61421(s, i + 1))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,61447,62143) || true) && (leftover > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,61447,62143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,61513,61550);

Coordinates 
c = f_114_61529_61549(f_114_61529_61534())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,61751,61801);

char 
charUnderCursor = f_114_61774_61800(this, c)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,61829,61865);

f_114_61829_61864(this, f_114_61835_61863(leftover));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,61891,61916);

f_114_61891_61896().CursorPosition = c;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,61944,62003);

restOfLine = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_114_61957_61961(s, i)).ToString(),114,61957,61961)+ (DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (charUnderCursor).ToString(),114,61965,61980)+ f_114_61983_62001(s, i + 1));
DynAbs.Tracing.TraceSender.TraceExitCondition(114,61447,62143);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,61447,62143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,62101,62120);

restOfLine += f_114_62115_62119(s, i);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,61447,62143);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,62167,62183);

s = f_114_62171_62182(s, i);
DynAbs.Tracing.TraceSender.TraceBreak(114,62207,62213);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,60183,62232);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,58442,67286);
}
            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,58442,67286) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,58442,67286);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,58442,67286);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,67302,67549);

f_114_67302_67548((s == null &&(DynAbs.Tracing.TraceSender.Expression_True(114, 67339, 67389)&&result == ReadLineResult.endedOnBreak))
||(DynAbs.Tracing.TraceSender.Expression_False(114, 67338, 67470)||(s != null &&(DynAbs.Tracing.TraceSender.Expression_True(114, 67419, 67469)&&result != ReadLineResult.endedOnBreak))), "s should only be null if input ended with a break");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,67565,67574);

return s;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,55192,67739);

int
f_114_55364_55373(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.PreRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 55364, 55373);
return 0;
}


Microsoft.Win32.SafeHandles.SafeFileHandle
f_114_55489_55526()
{
var return_v = ConsoleControl.GetConioDeviceHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 55489, 55526);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.ConsoleModes
f_114_55573_55603(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle)
{
var return_v = ConsoleControl.GetMode( consoleHandle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 55573, 55603);
return return_v;
}


int
f_114_56078_56111(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,Microsoft.PowerShell.ConsoleControl.ConsoleModes
mode)
{
ConsoleControl.SetMode( consoleHandle, mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 56078, 56111);
return 0;
}


int
f_114_58110_58132(Microsoft.PowerShell.ConsoleHostRawUserInterface
this_param)
{
this_param.ClearKeyCache();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 58110, 58132);
return 0;
}


int
f_114_58300_58321(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 58300, 58321);
return return_v;
}


System.ReadOnlySpan<char>
f_114_58359_58382(string
text)
{
var return_v = text.AsSpan();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 58359, 58382);
return return_v;
}


int
f_114_58588_58609(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 58588, 58609);
return return_v;
}


string
f_114_58553_58667(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,int
initialContentLength,System.Span<char>
editBuffer,int
charactersToRead,bool
endOnTab,out uint
keyState)
{
var return_v = ConsoleControl.ReadConsole( consoleHandle, initialContentLength, editBuffer, charactersToRead, endOnTab, out keyState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 58553, 58667);
return return_v;
}


int
f_114_58686_58733(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 58686, 58733);
return 0;
}


int
f_114_58943_58951(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 58943, 58951);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_114_59260_59290()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 59260, 59290);
return return_v;
}


string
f_114_59473_59492()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 59473, 59492);
return return_v;
}


bool
f_114_59462_59519(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 59462, 59519);
return return_v;
}


int
f_114_59798_59806(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 59798, 59806);
return return_v;
}


string
f_114_59809_59828()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 59809, 59828);
return return_v;
}


int
f_114_59809_59835(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 59809, 59835);
return return_v;
}


string
f_114_59789_59836(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 59789, 59836);
return return_v;
}


int
f_114_60122_60162(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 60122, 60162);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_61377_61382()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 61377, 61382);
return return_v;
}


string
f_114_61403_61421(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 61403, 61421);
return return_v;
}


int
f_114_61377_61422(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string
source)
{
var return_v = this_param.LengthInBufferCells( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 61377, 61422);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_61529_61534()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 61529, 61534);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_114_61529_61549(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 61529, 61549);
return return_v;
}


char
f_114_61774_61800(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Management.Automation.Host.Coordinates
cursorPosition)
{
var return_v = this_param.GetCharacterUnderCursor( cursorPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 61774, 61800);
return return_v;
}


string
f_114_61835_61863(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 61835, 61863);
return return_v;
}


int
f_114_61829_61864(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 61829, 61864);
return 0;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_61891_61896()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 61891, 61896);
return return_v;
}


char
f_114_61957_61961(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 61957, 61961);
return return_v;
}


string
f_114_61983_62001(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 61983, 62001);
return return_v;
}


char
f_114_62115_62119(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 62115, 62119);
return return_v;
}


string
f_114_62171_62182(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 62171, 62182);
return return_v;
}


int
f_114_67302_67548(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 67302, 67548);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,55192,67739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,55192,67739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private char GetCharacterUnderCursor(Coordinates cursorPosition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,68026,68983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68115,68215);

Rectangle 
region = f_114_68134_68214(0, cursorPosition.Y, f_114_68169_68174().BufferSize.Width - 1, cursorPosition.Y)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68229,68285);

BufferCell[,] 
content = f_114_68253_68284(f_114_68253_68258(), region)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68310,68319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68321,68331);

            for (int 
index = 0
, 
column = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68301,68841) || true) && (column <= cursorPosition.X)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68361,68368)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(114,68301,68841))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,68301,68841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68402,68438);

BufferCell 
cell = content[0, index]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68456,68826) || true) && (cell.BufferCellType == BufferCellType.Complete ||(DynAbs.Tracing.TraceSender.Expression_False(114, 68460, 68555)||cell.BufferCellType == BufferCellType.Leading))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,68456,68826);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68597,68722) || true) && (column == cursorPosition.X)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,68597,68722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68677,68699);

return cell.Character;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,68597,68722);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68746,68807);

column += f_114_68756_68806(cell.Character);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,68456,68826);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,1,541);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,1,541);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68857,68946);

f_114_68857_68945(false, "the character at the cursor should be retrieved, never gets to here");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,68960,68972);

return '\0';
DynAbs.Tracing.TraceSender.TraceExitMethod(114,68026,68983);

System.Management.Automation.Host.PSHostRawUserInterface
f_114_68169_68174()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 68169, 68174);
return return_v;
}


System.Management.Automation.Host.Rectangle
f_114_68134_68214(int
left,int
top,int
right,int
bottom)
{
var return_v = new System.Management.Automation.Host.Rectangle( left, top, right, bottom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 68134, 68214);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_68253_68258()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 68253, 68258);
return return_v;
}


System.Management.Automation.Host.BufferCell[,]
f_114_68253_68284(System.Management.Automation.Host.PSHostRawUserInterface
this_param,System.Management.Automation.Host.Rectangle
rectangle)
{
var return_v = this_param.GetBufferContents( rectangle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 68253, 68284);
return return_v;
}


int
f_114_68756_68806(char
c)
{
var return_v = ConsoleControl.LengthInBufferCells( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 68756, 68806);
return return_v;
}


int
f_114_68857_68945(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 68857, 68945);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,68026,68983);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,68026,68983);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string RemoveNulls(string input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,69233,69596);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,69298,69359) || true) && (f_114_69302_69321(input, '\0')== -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,69298,69359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,69346,69359);

return input;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,69298,69359);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,69373,69412);

StringBuilder 
sb = f_114_69392_69411()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,69426,69548);
foreach(char c in f_114_69445_69450_I(input) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,69426,69548);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,69484,69533) || true) && (c != '\0')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,69484,69533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,69520,69533);

f_114_69520_69532(                    sb, c);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,69484,69533);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,69426,69548);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,1,123);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,1,123);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,69564,69585);

return f_114_69571_69584(sb);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,69233,69596);

int
f_114_69302_69321(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 69302, 69321);
return return_v;
}


System.Text.StringBuilder
f_114_69392_69411()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 69392, 69411);
return return_v;
}


System.Text.StringBuilder
f_114_69520_69532(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 69520, 69532);
return return_v;
}


string
f_114_69445_69450_I(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 69445, 69450);
return return_v;
}


string
f_114_69571_69584(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 69571, 69584);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,69233,69596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,69233,69596);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string ReadLineWithTabCompletion(Executor exec)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,70012,77417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70093,70113);

string 
input = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70127,70159);

string 
lastInput = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70175,70229);

ReadLineResult 
rlResult = ReadLineResult.endedOnEnter
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70256,70324);

ConsoleHandle 
handle = f_114_70279_70323()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70340,70377);

string 
lastCompletion = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70391,70432);

Size 
screenBufferSize = f_114_70415_70431(f_114_70415_70420())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70601,70657);

Coordinates 
endOfPromptCursorPos = f_114_70636_70656(f_114_70636_70641())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70673,70716);

CommandCompletion 
commandCompletion = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70730,70760);

string 
completionInput = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,70784,77074);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70819,70929) || true) && (f_114_70823_70862(this, out input))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,70819,70929);
DynAbs.Tracing.TraceSender.TraceBreak(114,70904,70910);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,70819,70929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70949,71011);

input = f_114_70957_71010(this, true, lastInput, out rlResult, false, false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71031,71115) || true) && (input == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,71031,71115);
DynAbs.Tracing.TraceSender.TraceBreak(114,71090,71096);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,71031,71115);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71135,71245) || true) && (rlResult == ReadLineResult.endedOnEnter)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,71135,71245);
DynAbs.Tracing.TraceSender.TraceBreak(114,71220,71226);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,71135,71245);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71473,71528);

Coordinates 
endOfInputCursorPos = f_114_71507_71527(f_114_71507_71512())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71546,71575);

string 
completedInput = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71595,77024) || true) && (rlResult == ReadLineResult.endedOnTab ||(DynAbs.Tracing.TraceSender.Expression_False(114, 71599, 71682)||rlResult == ReadLineResult.endedOnShiftTab))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,71595,77024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71724,71784);

int 
tabIndex = f_114_71739_71783(input, Tab, StringComparison.Ordinal)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71806,71867);

f_114_71806_71866(tabIndex != -1, "tab should appear in the input");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71891,71924);

string 
restOfLine = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,71946,71989);

int 
leftover = f_114_71961_71973(input)- tabIndex - 1
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,72011,72766) || true) && (leftover > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,72011,72766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,72635,72674);

input = f_114_72643_72673(input, f_114_72656_72668(input)- 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,72700,72743);

restOfLine = f_114_72713_72742(input, tabIndex + 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,72011,72766);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,72790,72821);

input = f_114_72798_72820(input, tabIndex);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,72845,73075) || true) && (input != lastCompletion ||(DynAbs.Tracing.TraceSender.Expression_False(114, 72849, 72901)||commandCompletion == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,72845,73075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,72951,72975);

completionInput = input;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73001,73052);

commandCompletion = f_114_73021_73051(this, input);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,72845,73075);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73099,73193);

var 
completionResult = f_114_73122_73192(commandCompletion, rlResult == ReadLineResult.endedOnTab)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73215,73605) || true) && (completionResult != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,73215,73605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73293,73451);

completedInput = f_114_73310_73374(completionInput, 0, f_114_73339_73373(commandCompletion))                                         + f_114_73419_73450(completionResult);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,73215,73605);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,73215,73605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73549,73582);

completedInput = completionInput;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,73215,73605);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73629,73761) || true) && (restOfLine != string.Empty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,73629,73761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73709,73738);

completedInput += restOfLine;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,73629,73761);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73785,73979) || true) && (f_114_73789_73810(completedInput)> (MaxInputLineLength - 2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,73785,73979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,73887,73956);

completedInput = f_114_73904_73955(completedInput, 0, MaxInputLineLength - 2);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,73785,73979);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,74063,74108);

completedInput = f_114_74080_74107(this, completedInput);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,74311,74395);

int 
linesOfInput = (endOfPromptCursorPos.X + f_114_74356_74368(input)) / screenBufferSize.Width
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,74417,74479);

endOfPromptCursorPos.Y = endOfInputCursorPos.Y - linesOfInput;

                    // replace the displayed input with the new input
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,74626,74670);

f_114_74626_74631().CursorPosition = endOfPromptCursorPos;
                    }
                    catch (PSArgumentOutOfRangeException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(114,74715,75057);
DynAbs.Tracing.TraceSender.TraceBreak(114,75028,75034);

break;
DynAbs.Tracing.TraceSender.TraceExitCatch(114,74715,75057);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,75292,75330);

f_114_75292_75329(this, completedInput, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,75354,75414);

Coordinates 
endOfCompletionCursorPos = f_114_75393_75413(f_114_75393_75398())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,75668,75770);

int 
linesOfCompletedInput = (endOfPromptCursorPos.X + f_114_75722_75743(completedInput)) / screenBufferSize.Width
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,75792,75868);

endOfPromptCursorPos.Y = endOfCompletionCursorPos.Y - linesOfCompletedInput;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76122,76347);

int 
deltaInput =
                        (endOfInputCursorPos.Y * screenBufferSize.Width + endOfInputCursorPos.X)
                        - (endOfCompletionCursorPos.Y * screenBufferSize.Width + endOfCompletionCursorPos.X)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76371,76555) || true) && (deltaInput > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,76371,76555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76439,76532);

f_114_76439_76531(handle, ' ', deltaInput, endOfCompletionCursorPos);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,76371,76555);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76579,76954) || true) && (restOfLine != string.Empty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,76579,76954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76659,76741);

lastCompletion = f_114_76676_76740(completedInput, f_114_76698_76719(completedInput)- f_114_76722_76739(restOfLine));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76767,76801);

f_114_76767_76800(this, f_114_76782_76799(restOfLine));
DynAbs.Tracing.TraceSender.TraceExitCondition(114,76579,76954);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,76579,76954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76899,76931);

lastCompletion = completedInput;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,76579,76954);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,76978,77005);

lastInput = completedInput;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,71595,77024);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,70784,77074);
}
            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,70784,77074) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,70784,77074);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,70784,77074);
}}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77187,77377) || true) && (f_114_77191_77213(_parent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,77187,77377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77325,77362);

f_114_77325_77361(                // Reads always terminate with the enter key, so add that.

                _parent, input);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,77187,77377);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77393,77406);

return input;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,70012,77417);

Microsoft.Win32.SafeHandles.SafeFileHandle
f_114_70279_70323()
{
var return_v = ConsoleControl.GetActiveScreenBufferHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 70279, 70323);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_70415_70420()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 70415, 70420);
return return_v;
}


System.Management.Automation.Host.Size
f_114_70415_70431(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BufferSize;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 70415, 70431);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_70636_70641()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 70636, 70641);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_114_70636_70656(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 70636, 70656);
return return_v;
}


bool
f_114_70823_70862(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,out string
input)
{
var return_v = this_param.TryInvokeUserDefinedReadLine( out input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 70823, 70862);
return return_v;
}


string
f_114_70957_71010(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,bool
endOnTab,string
initialContent,out Microsoft.PowerShell.ConsoleHostUserInterface.ReadLineResult
result,bool
calledFromPipeline,bool
transcribeResult)
{
var return_v = this_param.ReadLine( endOnTab, initialContent, out result, calledFromPipeline, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 70957, 71010);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_71507_71512()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 71507, 71512);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_114_71507_71527(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 71507, 71527);
return return_v;
}


int
f_114_71739_71783(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 71739, 71783);
return return_v;
}


int
f_114_71806_71866(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 71806, 71866);
return 0;
}


int
f_114_71961_71973(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 71961, 71973);
return return_v;
}


int
f_114_72656_72668(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 72656, 72668);
return return_v;
}


string
f_114_72643_72673(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 72643, 72673);
return return_v;
}


string
f_114_72713_72742(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 72713, 72742);
return return_v;
}


string
f_114_72798_72820(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 72798, 72820);
return return_v;
}


System.Management.Automation.CommandCompletion
f_114_73021_73051(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
input)
{
var return_v = this_param.GetNewCompletionResults( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 73021, 73051);
return return_v;
}


System.Management.Automation.CompletionResult
f_114_73122_73192(System.Management.Automation.CommandCompletion
this_param,bool
forward)
{
var return_v = this_param.GetNextResult( forward);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 73122, 73192);
return return_v;
}


int
f_114_73339_73373(System.Management.Automation.CommandCompletion
this_param)
{
var return_v = this_param.ReplacementIndex;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 73339, 73373);
return return_v;
}


string
f_114_73310_73374(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 73310, 73374);
return return_v;
}


string
f_114_73419_73450(System.Management.Automation.CompletionResult
this_param)
{
var return_v = this_param.CompletionText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 73419, 73450);
return return_v;
}


int
f_114_73789_73810(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 73789, 73810);
return return_v;
}


string
f_114_73904_73955(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 73904, 73955);
return return_v;
}


string
f_114_74080_74107(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
input)
{
var return_v = this_param.RemoveNulls( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 74080, 74107);
return return_v;
}


int
f_114_74356_74368(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 74356, 74368);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_74626_74631()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 74626, 74631);
return return_v;
}


int
f_114_75292_75329(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 75292, 75329);
return 0;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_114_75393_75398()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 75393, 75398);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_114_75393_75413(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 75393, 75413);
return return_v;
}


int
f_114_75722_75743(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 75722, 75743);
return return_v;
}


int
f_114_76439_76531(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle,char
character,int
numberToWrite,System.Management.Automation.Host.Coordinates
origin)
{
ConsoleControl.FillConsoleOutputCharacter( consoleHandle, character, numberToWrite, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 76439, 76531);
return 0;
}


int
f_114_76698_76719(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 76698, 76719);
return return_v;
}


int
f_114_76722_76739(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 76722, 76739);
return return_v;
}


string
f_114_76676_76740(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 76676, 76740);
return return_v;
}


int
f_114_76782_76799(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 76782, 76799);
return return_v;
}


int
f_114_76767_76800(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,int
length)
{
this_param.SendLeftArrows( length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 76767, 76800);
return 0;
}


bool
f_114_77191_77213(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.IsTranscribing;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 77191, 77213);
return return_v;
}


int
f_114_77325_77361(Microsoft.PowerShell.ConsoleHost
this_param,string
text)
{
this_param.WriteLineToTranscript( (System.ReadOnlySpan<char>)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 77325, 77361);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,70012,77417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,70012,77417);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void SendLeftArrows(int length)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,77440,78776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77504,77554);

var 
inputs = new ConsoleControl.INPUT[length * 2]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77577,77582);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77568,78712) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77596,77599)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(114,77568,78712))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,77568,78712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77633,77671);

var 
down = f_114_77644_77670()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77689,77743);

down.Type = (UInt32)ConsoleControl.InputType.Keyboard;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77761,77817);

down.Data.Keyboard = f_114_77782_77816();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77835,77902);

down.Data.Keyboard.Vk = (UInt16)ConsoleControl.VirtualKeyCode.Left;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77920,77948);

down.Data.Keyboard.Scan = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,77966,77995);

down.Data.Keyboard.Flags = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78013,78041);

down.Data.Keyboard.Time = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78059,78102);

down.Data.Keyboard.ExtraInfo = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78122,78158);

var 
up = f_114_78131_78157()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78176,78228);

up.Type = (UInt32)ConsoleControl.InputType.Keyboard;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78246,78300);

up.Data.Keyboard = f_114_78265_78299();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78318,78383);

up.Data.Keyboard.Vk = (UInt16)ConsoleControl.VirtualKeyCode.Left;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78401,78427);

up.Data.Keyboard.Scan = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78445,78512);

up.Data.Keyboard.Flags = (UInt32)ConsoleControl.KeyboardFlag.KeyUp;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78530,78556);

up.Data.Keyboard.Time = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78574,78615);

up.Data.Keyboard.ExtraInfo = IntPtr.Zero;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78635,78656);

inputs[2 * i] = down;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78674,78697);

inputs[2 * i + 1] = up;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(114,1,1145);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(114,1,1145);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78728,78765);

f_114_78728_78764(inputs);
DynAbs.Tracing.TraceSender.TraceExitMethod(114,77440,78776);

Microsoft.PowerShell.ConsoleControl.INPUT
f_114_77644_77670()
{
var return_v = new Microsoft.PowerShell.ConsoleControl.INPUT();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 77644, 77670);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.KeyboardInput
f_114_77782_77816()
{
var return_v = new Microsoft.PowerShell.ConsoleControl.KeyboardInput();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 77782, 77816);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.INPUT
f_114_78131_78157()
{
var return_v = new Microsoft.PowerShell.ConsoleControl.INPUT();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 78131, 78157);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.KeyboardInput
f_114_78265_78299()
{
var return_v = new Microsoft.PowerShell.ConsoleControl.KeyboardInput();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 78265, 78299);
return return_v;
}


int
f_114_78728_78764(Microsoft.PowerShell.ConsoleControl.INPUT[]
inputs)
{
ConsoleControl.MimicKeyPress( inputs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 78728, 78764);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,77440,78776);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,77440,78776);
}
		}

private CommandCompletion GetNewCompletionResults(string input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,78796,80288);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78920,78952);

var 
runspace = f_114_78935_78951(_parent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,78970,79003);

var 
debugger = f_114_78985_79002(runspace)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,79023,79475) || true) && ((debugger != null) &&(DynAbs.Tracing.TraceSender.Expression_True(114, 79027, 79070)&&f_114_79049_79070(debugger)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,79023,79475);
                    // If in debug stop mode do command completion though debugger process command.
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,79265,79351);

return f_114_79272_79350(input, f_114_79321_79333(input), null, debugger);
                    }
                    catch (PSInvalidOperationException)
                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(114,79396,79456);
DynAbs.Tracing.TraceSender.TraceExitCatch(114,79396,79456);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(114,79023,79475);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,79495,80041) || true) && (runspace is LocalRunspace &&(DynAbs.Tracing.TraceSender.Expression_True(114, 79499, 79616)&&f_114_79549_79612(f_114_79549_79594(f_114_79549_79574(runspace)))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,79495,80041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,79658,79737);

_commandCompletionPowerShell = f_114_79689_79736(RunspaceMode.CurrentRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,79495,80041);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,79495,80041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,79819,79870);

_commandCompletionPowerShell = f_114_79850_79869();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,79892,79951);

f_114_79892_79950(                    _commandCompletionPowerShell, f_114_79933_79949(_parent));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,79973,80022);

_commandCompletionPowerShell.Runspace = runspace;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,79495,80041);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,80061,80157);

return f_114_80068_80156(input, f_114_80107_80119(input), null, _commandCompletionPowerShell);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(114,80186,80277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,80226,80262);

_commandCompletionPowerShell = null;
DynAbs.Tracing.TraceSender.TraceExitFinally(114,80186,80277);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(114,78796,80288);

System.Management.Automation.Runspaces.Runspace
f_114_78935_78951(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 78935, 78951);
return return_v;
}


System.Management.Automation.Debugger
f_114_78985_79002(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 78985, 79002);
return return_v;
}


bool
f_114_79049_79070(System.Management.Automation.Debugger
this_param)
{
var return_v = this_param.InBreakpoint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 79049, 79070);
return return_v;
}


int
f_114_79321_79333(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 79321, 79333);
return return_v;
}


System.Management.Automation.CommandCompletion
f_114_79272_79350(string
input,int
cursorIndex,System.Collections.Hashtable
options,System.Management.Automation.Debugger
debugger)
{
var return_v = CommandCompletion.CompleteInputInDebugger( input, cursorIndex, options, debugger);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 79272, 79350);
return return_v;
}


System.Management.Automation.ExecutionContext
f_114_79549_79574(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 79549, 79574);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_114_79549_79594(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 79549, 79594);
return return_v;
}


int
f_114_79549_79612(System.Management.Automation.Internal.Host.InternalHost
this_param)
{
var return_v = this_param.NestedPromptCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 79549, 79612);
return return_v;
}


System.Management.Automation.PowerShell
f_114_79689_79736(System.Management.Automation.RunspaceMode
runspace)
{
var return_v = PowerShell.Create( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 79689, 79736);
return return_v;
}


System.Management.Automation.PowerShell
f_114_79850_79869()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 79850, 79869);
return return_v;
}


bool
f_114_79933_79949(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.IsNested;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 79933, 79949);
return return_v;
}


int
f_114_79892_79950(System.Management.Automation.PowerShell
this_param,bool
isNested)
{
this_param.SetIsNested( isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 79892, 79950);
return 0;
}


int
f_114_80107_80119(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 80107, 80119);
return return_v;
}


System.Management.Automation.CommandCompletion
f_114_80068_80156(string
input,int
cursorIndex,System.Collections.Hashtable
options,System.Management.Automation.PowerShell
powershell)
{
var return_v = CommandCompletion.CompleteInput( input, cursorIndex, options, powershell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 80068, 80156);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,78796,80288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,78796,80288);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private const string 
CustomReadlineCommand = "PSConsoleHostReadLine"
;

private bool TryInvokeUserDefinedReadLine(out string input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,80379,82043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,80766,80803);

var 
runspace = f_114_80781_80802(_parent)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,80817,81976) || true) && (runspace != null &&(DynAbs.Tracing.TraceSender.Expression_True(114, 80821, 81041)&&f_114_80858_81041(f_114_80858_81035(f_114_80858_80912(f_114_80858_80898(f_114_80858_80881(f_114_80858_80873(runspace)))), CustomReadlineCommand, CommandTypes.Function | CommandTypes.Cmdlet, nameIsPattern: false))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,80817,81976);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81119,81133);

PowerShell 
ps
=default(PowerShell);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81155,81589) || true) && ((f_114_81160_81223(f_114_81160_81205(f_114_81160_81185(runspace)))> 0) &&(DynAbs.Tracing.TraceSender.Expression_True(114, 81159, 81291)&&                        (f_114_81258_81282()!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,81155,81589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81341,81394);

ps = f_114_81346_81393(RunspaceMode.CurrentRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(114,81155,81589);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,81155,81589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81492,81517);

ps = f_114_81497_81516();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81543,81566);

ps.Runspace = runspace;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,81155,81589);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81613,81672);

var 
result = f_114_81626_81671(f_114_81626_81662(ps, CustomReadlineCommand))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81694,81869) || true) && (f_114_81698_81710(result)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,81694,81869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81765,81808);

input = f_114_81773_81797(f_114_81787_81796(result, 0))as string;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81834,81846);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(114,81694,81869);
}
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(114,81906,81961);
DynAbs.Tracing.TraceSender.TraceExitCatch(114,81906,81961);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(114,80817,81976);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,81992,82005);

input = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,82019,82032);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,80379,82043);

System.Management.Automation.Runspaces.LocalRunspace
f_114_80781_80802(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.LocalRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 80781, 80802);
return return_v;
}


System.Management.Automation.AutomationEngine
f_114_80858_80873(System.Management.Automation.Runspaces.LocalRunspace
this_param)
{
var return_v = this_param.Engine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 80858, 80873);
return return_v;
}


System.Management.Automation.ExecutionContext
f_114_80858_80881(System.Management.Automation.AutomationEngine
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 80858, 80881);
return return_v;
}


System.Management.Automation.EngineIntrinsics
f_114_80858_80898(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineIntrinsics;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 80858, 80898);
return return_v;
}


System.Management.Automation.CommandInvocationIntrinsics
f_114_80858_80912(System.Management.Automation.EngineIntrinsics
this_param)
{
var return_v = this_param.InvokeCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 80858, 80912);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
f_114_80858_81035(System.Management.Automation.CommandInvocationIntrinsics
this_param,string
name,System.Management.Automation.CommandTypes
commandTypes,bool
nameIsPattern)
{
var return_v = this_param.GetCommands( name, commandTypes, nameIsPattern:nameIsPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 80858, 81035);
return return_v;
}


bool
f_114_80858_81041(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
source)
{
var return_v = source.Any<System.Management.Automation.CommandInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 80858, 81041);
return return_v;
}


System.Management.Automation.ExecutionContext
f_114_81160_81185(System.Management.Automation.Runspaces.LocalRunspace
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 81160, 81185);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_114_81160_81205(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 81160, 81205);
return return_v;
}


int
f_114_81160_81223(System.Management.Automation.Internal.Host.InternalHost
this_param)
{
var return_v = this_param.NestedPromptCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 81160, 81223);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_114_81258_81282()
{
var return_v = Runspace.DefaultRunspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 81258, 81282);
return return_v;
}


System.Management.Automation.PowerShell
f_114_81346_81393(System.Management.Automation.RunspaceMode
runspace)
{
var return_v = PowerShell.Create( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 81346, 81393);
return return_v;
}


System.Management.Automation.PowerShell
f_114_81497_81516()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 81497, 81516);
return return_v;
}


System.Management.Automation.PowerShell
f_114_81626_81662(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 81626, 81662);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_114_81626_81671(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 81626, 81671);
return return_v;
}


int
f_114_81698_81710(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 81698, 81710);
return return_v;
}


System.Management.Automation.PSObject
f_114_81787_81796(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 81787, 81796);
return return_v;
}


object
f_114_81773_81797(System.Management.Automation.PSObject
obj)
{
var return_v = PSObject.Base( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 81773, 81797);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,80379,82043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,80379,82043);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object _instanceLock ;

internal bool ThrowOnReadAndPrompt
{
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,82375,82456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,82411,82441);

_throwOnReadAndPrompt = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(114,82375,82456);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,82316,82467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,82316,82467);
}
		}}

private bool _throwOnReadAndPrompt;

internal void HandleThrowOnReadAndPrompt()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(114,82526,82790);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,82593,82779) || true) && (_throwOnReadAndPrompt)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(114,82593,82779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,82652,82764);

throw f_114_82658_82763(f_114_82701_82762());
DynAbs.Tracing.TraceSender.TraceExitCondition(114,82593,82779);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(114,82526,82790);

string
f_114_82701_82762()
{
var return_v = ConsoleHostUserInterfaceStrings.ReadFailsOnNonInteractiveFlag;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 82701, 82762);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_114_82658_82763(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 82658, 82763);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114,82526,82790);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,82526,82790);
}
		}

private bool _isInteractiveTestToolListening;

private ConsoleHostRawUserInterface _rawui;

private ConsoleHost _parent;

[TraceSourceAttribute("ConsoleHostUserInterface", "Console host's subclass of S.M.A.Host.Console")]
        private static
        PSTraceSource s_tracer ;

static ConsoleHostUserInterface()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(114,863,83404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,1408,1418);
s_h = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,50389,50422);
Crlf = f_114_50396_50422();DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,50454,50468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,50685,50710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,80321,80368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(114,83285,83396);
s_tracer = f_114_83296_83396("ConsoleHostUserInterface", "Console host's subclass of S.M.A.Host.Console");DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,6351,6377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23816,23841);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(114,863,83404);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114,863,83404);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(114,863,83404);

int
f_114_1856_1908(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 1856, 1908);
return 0;
}


Microsoft.PowerShell.ConsoleHostRawUserInterface
f_114_1965_2002(Microsoft.PowerShell.ConsoleHostUserInterface
mshConsole)
{
var return_v = new Microsoft.PowerShell.ConsoleHostRawUserInterface( mshConsole);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 1965, 2002);
return return_v;
}


Microsoft.Win32.SafeHandles.SafeFileHandle
f_114_2308_2352()
{
var return_v = ConsoleControl.GetActiveScreenBufferHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 2308, 2352);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.ConsoleModes
f_114_2379_2409(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle)
{
var return_v = ConsoleControl.GetMode( consoleHandle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 2379, 2409);
return return_v;
}


System.IntPtr
f_114_2476_2503(Microsoft.Win32.SafeHandles.SafeFileHandle
this_param)
{
var return_v = this_param.DangerousGetHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 2476, 2503);
return return_v;
}


bool
f_114_2432_2561(System.IntPtr
consoleHandle,Microsoft.PowerShell.ConsoleControl.ConsoleModes
mode)
{
var return_v = ConsoleControl.NativeMethods.SetConsoleMode( consoleHandle, (uint)mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 2432, 2561);
return return_v;
}


Microsoft.PowerShell.ConsoleControl.ConsoleModes
f_114_2772_2802(Microsoft.Win32.SafeHandles.SafeFileHandle
consoleHandle)
{
var return_v = ConsoleControl.GetMode( consoleHandle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 2772, 2802);
return return_v;
}


System.ConsoleColor
f_114_49328_49351()
{
var return_v = Console.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 49328, 49351);
return return_v;
}


System.ConsoleColor
f_114_49539_49562()
{
var return_v = Console.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 49539, 49562);
return return_v;
}


System.ConsoleColor
f_114_49744_49767()
{
var return_v = Console.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 49744, 49767);
return return_v;
}


System.ConsoleColor
f_114_49955_49978()
{
var return_v = Console.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 49955, 49978);
return return_v;
}


static string
f_114_50396_50422()
{
var return_v = System.Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(114, 50396, 50422);
return return_v;
}


object
f_114_82179_82191()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 82179, 82191);
return return_v;
}


static System.Management.Automation.PSTraceSource
f_114_83296_83396(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(114, 83296, 83396);
return return_v;
}

}
}   // namespace

