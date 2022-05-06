// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Configuration;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Security;
using System.Text;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
internal class NullHostUserInterface : PSHostUserInterface
{
public override PSHostRawUserInterface RawUI
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(109,1092,1112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,1098,1110);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,1092,1112);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,1023,1123);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,1023,1123);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,1373,1573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,1524,1562);

throw f_109_1530_1561();
DynAbs.Tracing.TraceSender.TraceExitMethod(109,1373,1573);

System.Management.Automation.PSNotImplementedException
f_109_1530_1561()
{
var return_v = new System.Management.Automation.PSNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 1530, 1561);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,1373,1573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,1373,1573);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,1877,2076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,2027,2065);

throw f_109_2033_2064();
DynAbs.Tracing.TraceSender.TraceExitMethod(109,1877,2076);

System.Management.Automation.PSNotImplementedException
f_109_2033_2064()
{
var return_v = new System.Management.Automation.PSNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 2033, 2064);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,1877,2076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,1877,2076);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,2382,2572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,2523,2561);

throw f_109_2529_2560();
DynAbs.Tracing.TraceSender.TraceExitMethod(109,2382,2572);

System.Management.Automation.PSNotImplementedException
f_109_2529_2560()
{
var return_v = new System.Management.Automation.PSNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 2529, 2560);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,2382,2572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,2382,2572);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,2981,3244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,3195,3233);

throw f_109_3201_3232();
DynAbs.Tracing.TraceSender.TraceExitMethod(109,2981,3244);

System.Management.Automation.PSNotImplementedException
f_109_3201_3232()
{
var return_v = new System.Management.Automation.PSNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 3201, 3232);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,2981,3244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,2981,3244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override string ReadLine()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,3359,3466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,3417,3455);

throw f_109_3423_3454();
DynAbs.Tracing.TraceSender.TraceExitMethod(109,3359,3466);

System.Management.Automation.PSNotImplementedException
f_109_3423_3454()
{
var return_v = new System.Management.Automation.PSNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 3423, 3454);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,3359,3466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,3359,3466);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override SecureString ReadLineAsSecureString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,3595,3722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,3673,3711);

throw f_109_3679_3710();
DynAbs.Tracing.TraceSender.TraceExitMethod(109,3595,3722);

System.Management.Automation.PSNotImplementedException
f_109_3679_3710()
{
var return_v = new System.Management.Automation.PSNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 3679, 3710);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,3595,3722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,3595,3722);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void Write(string value)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterMethod(109,3843,3896);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,3843,3896);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,3843,3896);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,3843,3896);
}
		}

public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterMethod(109,4121,4234);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,4121,4234);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,4121,4234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,4121,4234);
}
		}

public override void WriteDebugLine(string message)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterMethod(109,4366,4430);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,4366,4430);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,4366,4430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,4366,4430);
}
		}

public override void WriteErrorLine(string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,4560,4674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,4634,4663);

f_109_4634_4662(f_109_4634_4645(), value);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,4560,4674);

System.IO.TextWriter
f_109_4634_4645()
{
var return_v =             Console.Out;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 4634, 4645);
return return_v;
}


int
f_109_4634_4662(System.IO.TextWriter
this_param,string
value)
{
this_param.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 4634, 4662);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,4560,4674);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,4560,4674);
}
		}

public override void WriteLine(string value)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterMethod(109,4799,4856);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,4799,4856);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,4799,4856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,4799,4856);
}
		}

public override void WriteProgress(long sourceId, ProgressRecord record)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterMethod(109,5031,5116);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,5031,5116);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,5031,5116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,5031,5116);
}
		}

public override void WriteVerboseLine(string message)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterMethod(109,5250,5316);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,5250,5316);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,5250,5316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,5250,5316);
}
		}

public override void WriteWarningLine(string message)
		{
			try
        { DynAbs.Tracing.TraceSender.TraceEnterMethod(109,5450,5516);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,5450,5516);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,5450,5516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,5450,5516);
}
		}

public NullHostUserInterface()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(109,881,5523);
DynAbs.Tracing.TraceSender.TraceExitConstructor(109,881,5523);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,881,5523);
}


static NullHostUserInterface()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(109,881,5523);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(109,881,5523);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,881,5523);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(109,881,5523);
}
internal class CommandLineParameterParser
{
private const int 
MaxPipePathLengthLinux = 108
;

private const int 
MaxPipePathLengthMacOS = 104
;

internal static string[] validParameters ;

internal CommandLineParameterParser(PSHostUserInterface hostUI, string bannerText, string helpText)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(109,6358,6719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50176,50193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50217,50228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50252,50272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50296,50310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50334,50346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50372,50390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50429,50436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50460,50469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50493,50510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50534,50552);
this._showBanner = true;DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50576,50590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50616,50627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50653,50662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50686,50699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50723,50736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50762,50777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50802,50817);
this._staMode = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50841,50855);
this._noExit = true;DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50879,50909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50933,50942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50968,50987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51011,51029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51053,51092);
this._exitCode = ConsoleHost.ExitCodeSuccess;DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51116,51122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51166,51208);
this._outFormat = Serialization.DataFormat.Text;DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51232,51262);
this._outputFormatSpecified = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51306,51347);
this._inFormat = Serialization.DataFormat.Text;DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51395,51446);
this._collectedArgs = f_109_51412_51446();DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51472,51477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51503,51519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51545,51562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,51599,51647);
this._removeWorkingDirectoryTrailingCharacter = false;
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,6482,6599) || true) && (hostUI == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,6482,6599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,6534,6584);

throw f_109_6540_6583(nameof(hostUI));
DynAbs.Tracing.TraceSender.TraceExitCondition(109,6482,6599);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,6615,6632);

_hostUI = hostUI;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,6648,6673);

_bannerText = bannerText;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,6687,6708);

_helpText = helpText;
DynAbs.Tracing.TraceSender.TraceExitConstructor(109,6358,6719);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,6358,6719);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,6358,6719);
}
		}

internal bool AbortStartup
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,6819,6963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,6855,6907);

f_109_6855_6906(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,6927,6948);

return _abortStartup;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,6819,6963);

int
f_109_6855_6906(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 6855, 6906);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,6768,6974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,6768,6974);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string InitialCommand
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,7041,7191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7077,7129);

f_109_7077_7128(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7149,7176);

return _commandLineCommand;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,7041,7191);

int
f_109_7077_7128(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 7077, 7128);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,6986,7202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,6986,7202);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool WasInitialCommandEncoded
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,7277,7426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7313,7365);

f_109_7313_7364(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7385,7411);

return _wasCommandEncoded;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,7277,7426);

int
f_109_7313_7364(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 7313, 7364);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,7214,7437);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,7214,7437);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool ShowBanner
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,7498,7638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7534,7586);

f_109_7534_7585(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7604,7623);

return _showBanner;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,7498,7638);

int
f_109_7534_7585(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 7534, 7585);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,7449,7649);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,7449,7649);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool NoExit
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,7706,7844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7742,7794);

f_109_7742_7793(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7814,7829);

return _noExit;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,7706,7844);

int
f_109_7742_7793(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 7742, 7793);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,7661,7855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,7661,7855);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool SkipProfiles
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,7918,8062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,7954,8006);

f_109_7954_8005(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8026,8047);

return _skipUserInit;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,7918,8062);

int
f_109_7954_8005(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 7954, 8005);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,7867,8073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,7867,8073);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal uint ExitCode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,8132,8272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8168,8220);

f_109_8168_8219(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8240,8257);

return _exitCode;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,8132,8272);

int
f_109_8168_8219(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 8168, 8219);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,8085,8283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,8085,8283);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool ExplicitReadCommandsFromStdin
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,8363,8524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8399,8451);

f_109_8399_8450(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8471,8509);

return _explicitReadCommandsFromStdin;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,8363,8524);

int
f_109_8399_8450(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 8399, 8450);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,8295,8535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,8295,8535);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool NoPrompt
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,8594,8734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8630,8682);

f_109_8630_8681(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8702,8719);

return _noPrompt;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,8594,8734);

int
f_109_8630_8681(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 8630, 8681);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,8547,8745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,8547,8745);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal Collection<CommandParameter> Args
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,8824,8969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8860,8912);

f_109_8860_8911(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,8932,8954);

return _collectedArgs;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,8824,8969);

int
f_109_8860_8911(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 8860, 8911);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,8757,8980);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,8757,8980);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string ConfigurationName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9050,9084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,9056,9082);

return _configurationName;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9050,9084);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,8992,9095);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,8992,9095);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool SocketServerMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9162,9238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,9198,9223);

return _socketServerMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9162,9238);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,9107,9249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,9107,9249);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool NamedPipeServerMode
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9319,9355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,9325,9353);

return _namedPipeServerMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9319,9355);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,9261,9366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,9261,9366);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool SSHServerMode
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9430,9460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,9436,9458);

return _sshServerMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9430,9460);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,9378,9471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,9378,9471);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool ServerMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9532,9602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,9568,9587);

return _serverMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9532,9602);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,9483,9613);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,9483,9613);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool ShowVersion
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9675,9746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,9711,9731);

return _showVersion;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9675,9746);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,9625,9757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,9625,9757);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string CustomPipeName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9824,9898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,9860,9883);

return _customPipeName;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9824,9898);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,9769,9909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,9769,9909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal Serialization.DataFormat OutputFormat
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,9992,10133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10028,10080);

f_109_10028_10079(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10100,10118);

return _outFormat;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,9992,10133);

int
f_109_10028_10079(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 10028, 10079);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,9921,10144);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,9921,10144);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool OutputFormatSpecified
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,10216,10369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10252,10304);

f_109_10252_10303(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10324,10354);

return _outputFormatSpecified;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,10216,10369);

int
f_109_10252_10303(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 10252, 10303);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,10156,10380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,10156,10380);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal Serialization.DataFormat InputFormat
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,10462,10600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10498,10550);

f_109_10498_10549(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10568,10585);

return _inFormat;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,10462,10600);

int
f_109_10498_10549(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 10498, 10549);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,10392,10611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,10392,10611);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string File
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,10668,10802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10704,10756);

f_109_10704_10755(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10774,10787);

return _file;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,10668,10802);

int
f_109_10704_10755(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 10704, 10755);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,10623,10813);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,10623,10813);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string ExecutionPolicy
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,10881,11026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10917,10969);

f_109_10917_10968(_dirty, "Parse has not been called yet");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,10987,11011);

return _executionPolicy;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,10881,11026);

int
f_109_10917_10968(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 10917, 10968);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,10825,11037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,10825,11037);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool ThrowOnReadAndPrompt
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,11108,11181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,11144,11166);

return _noInteractive;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,11108,11181);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,11049,11192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,11049,11192);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool NonInteractive
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(109,11257,11287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,11263,11285);

return _noInteractive;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,11257,11287);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,11204,11298);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,11204,11298);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string WorkingDirectory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,11367,11679);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,11414,11613) || true) && (_removeWorkingDirectoryTrailingCharacter &&(DynAbs.Tracing.TraceSender.Expression_True(109, 11418, 11490)&&f_109_11462_11486(_workingDirectory)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,11414,11613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,11532,11594);

return f_109_11539_11593(_workingDirectory, f_109_11564_11588(_workingDirectory)- 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,11414,11613);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,11639,11664);

return _workingDirectory;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,11367,11679);

int
f_109_11462_11486(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 11462, 11486);
return return_v;
}


int
f_109_11564_11588(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 11564, 11588);
return return_v;
}


string
f_109_11539_11593(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 11539, 11593);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,11310,11690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,11310,11690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool RemoveWorkingDirectoryTrailingCharacter
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(109,11791,11847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,11797,11845);

return _removeWorkingDirectoryTrailingCharacter;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,11791,11847);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,11713,11858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,11713,11858);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static bool TryParseSettingFileHelper(string[] args, int settingFileArgIndex, CommandLineParameterParser parser)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(109,12608,14159);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,12753,13070) || true) && (settingFileArgIndex >= f_109_12780_12791(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,12753,13070);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,12825,13022) || true) && (parser != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,12825,13022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,12885,13003);

f_109_12885_13002(                    parser, f_109_12940_13001());
DynAbs.Tracing.TraceSender.TraceExitCondition(109,12825,13022);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13042,13055);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,12753,13070);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13086,13111);

string 
configFile = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13161,13219);

configFile = f_109_13174_13218(args[settingFileArgIndex]);
            }
            catch (Exception ex)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(109,13248,13645);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13301,13597) || true) && (parser != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,13301,13597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13361,13520);

string 
error = f_109_13376_13519(f_109_13390_13416(), f_109_13418_13479(), args[settingFileArgIndex], f_109_13508_13518(ex))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13542,13578);

f_109_13542_13577(                    parser, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,13301,13597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13617,13630);

return false;
DynAbs.Tracing.TraceSender.TraceExitCatch(109,13248,13645);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13661,14044) || true) && (!f_109_13666_13699(configFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,13661,14044);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13733,13996) || true) && (parser != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,13733,13996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13793,13919);

string 
error = f_109_13808_13918(f_109_13822_13848(), f_109_13850_13905(), configFile)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,13941,13977);

f_109_13941_13976(                    parser, error);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,13733,13996);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,14016,14029);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,13661,14044);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,14060,14122);

f_109_14060_14121(
            PowerShellConfig.Instance, configFile);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,14136,14148);

return true;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(109,12608,14159);

int
f_109_12780_12791(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 12780, 12791);
return return_v;
}


string
f_109_12940_13001()
{
var return_v =                         CommandLineParameterParserStrings.MissingSettingsFileArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 12940, 13001);
return return_v;
}


int
f_109_12885_13002(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 12885, 13002);
return 0;
}


string
f_109_13174_13218(string
path)
{
var return_v = NormalizeFilePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 13174, 13218);
return return_v;
}


System.Globalization.CultureInfo
f_109_13390_13416()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 13390, 13416);
return return_v;
}


string
f_109_13418_13479()
{
var return_v = CommandLineParameterParserStrings.InvalidSettingsFileArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 13418, 13479);
return return_v;
}


string
f_109_13508_13518(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 13508, 13518);
return return_v;
}


string
f_109_13376_13519(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 13376, 13519);
return return_v;
}


int
f_109_13542_13577(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 13542, 13577);
return 0;
}


bool
f_109_13666_13699(string
path)
{
var return_v = System.IO.File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 13666, 13699);
return return_v;
}


System.Globalization.CultureInfo
f_109_13822_13848()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 13822, 13848);
return return_v;
}


string
f_109_13850_13905()
{
var return_v = CommandLineParameterParserStrings.SettingsFileNotExists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 13850, 13905);
return return_v;
}


string
f_109_13808_13918(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 13808, 13918);
return return_v;
}


int
f_109_13941_13976(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 13941, 13976);
return 0;
}


int
f_109_14060_14121(System.Management.Automation.Configuration.PowerShellConfig
this_param,string
value)
{
this_param.SetSystemConfigFilePath( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 14060, 14121);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,12608,14159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,12608,14159);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetConfigurationNameFromGroupPolicy()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(109,14171,14702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,14309,14428);

var 
consoleSessionSetting = f_109_14337_14427(Utils.CurrentUserThenSystemWideConfig)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,14444,14691);

return (DynAbs.Tracing.TraceSender.Conditional_F1(109, 14451, 14598)||(((f_109_14452_14508_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(consoleSessionSetting, 109, 14452, 14508)?.EnableConsoleSessionConfiguration)== true &&(DynAbs.Tracing.TraceSender.Expression_True(109, 14452, 14597)&&!f_109_14521_14597(f_109_14542_14596_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(consoleSessionSetting, 109, 14542, 14596)?.ConsoleSessionConfigurationName)))) &&DynAbs.Tracing.TraceSender.Conditional_F2(109, 14622, 14675))||DynAbs.Tracing.TraceSender.Conditional_F3(109, 14678, 14690)))?f_109_14622_14675(consoleSessionSetting):string.Empty;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(109,14171,14702);

System.Management.Automation.Configuration.ConsoleSessionConfiguration
f_109_14337_14427(System.Management.Automation.Configuration.ConfigScope[]
preferenceOrder)
{
var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>( preferenceOrder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 14337, 14427);
return return_v;
}


bool?
f_109_14452_14508_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 14452, 14508);
return return_v;
}


string
f_109_14542_14596_M(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 14542, 14596);
return return_v;
}


bool
f_109_14521_14597(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 14521, 14597);
return return_v;
}


string
f_109_14622_14675(System.Management.Automation.Configuration.ConsoleSessionConfiguration
this_param)
{
var return_v = this_param.ConsoleSessionConfigurationName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 14622, 14675);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,14171,14702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,14171,14702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void EarlyParse(string[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(109,15064,16187);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15135,15310) || true) && (args == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,15135,15310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15185,15270);

f_109_15185_15269(args != null, "Argument 'args' to EarlyParseHelper should never be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15288,15295);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,15135,15310);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15326,15350);

bool 
noexitSeen = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15373,15378);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15364,16176) || true) && (i < f_109_15384_15395(args))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15397,15400)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(109,15364,16176))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,15364,16176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15434,15546);

(string SwitchKey, bool ShouldBreak) 
switchKeyResults = f_109_15490_15545(args, ref i, parser: null, ref noexitSeen)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15564,15663) || true) && (switchKeyResults.ShouldBreak)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,15564,15663);
DynAbs.Tracing.TraceSender.TraceBreak(109,15638,15644);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,15564,15663);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15683,15729);

string 
switchKey = switchKeyResults.SwitchKey
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,15749,16161) || true) && (!f_109_15754_15785(switchKey)&&(DynAbs.Tracing.TraceSender.Expression_True(109, 15753, 15872)&&f_109_15789_15872(switchKey, match: "settingsfile", smallestUnambiguousMatch: "settings")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,15749,16161);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,16008,16142) || true) && (!f_109_16013_16063(args, ++i, parser: null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,16008,16142);
DynAbs.Tracing.TraceSender.TraceBreak(109,16113,16119);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,16008,16142);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,15749,16161);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,1,813);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,1,813);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(109,15064,16187);

int
f_109_15185_15269(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 15185, 15269);
return 0;
}


int
f_109_15384_15395(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 15384, 15395);
return return_v;
}


(string SwitchKey, bool ShouldBreak)
f_109_15490_15545(string[]
args,ref int
argIndex,Microsoft.PowerShell.CommandLineParameterParser
parser,ref bool
noexitSeen)
{
var return_v = GetSwitchKey( args, ref argIndex, parser:parser, ref noexitSeen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 15490, 15545);
return return_v;
}


bool
f_109_15754_15785(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 15754, 15785);
return return_v;
}


bool
f_109_15789_15872(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match:match, smallestUnambiguousMatch:smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 15789, 15872);
return return_v;
}


bool
f_109_16013_16063(string[]
args,int
settingFileArgIndex,Microsoft.PowerShell.CommandLineParameterParser
parser)
{
var return_v = TryParseSettingFileHelper( args, settingFileArgIndex, parser:parser);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 16013, 16063);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,15064,16187);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,15064,16187);
}
		}

private static (string SwitchKey, bool ShouldBreak) GetSwitchKey(string[] args, ref int argIndex, CommandLineParameterParser parser, ref bool noexitSeen)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(109,17175,18465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17353,17413);

string 
switchKey = f_109_17372_17412(f_109_17372_17393(args[argIndex]))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17427,17556) || true) && (f_109_17431_17462(switchKey))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,17427,17556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17496,17541);

return (SwitchKey: null, ShouldBreak: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,17427,17556);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17572,17945) || true) && (!f_109_17577_17612(f_109_17599_17611(switchKey, 0))&&(DynAbs.Tracing.TraceSender.Expression_True(109, 17576, 17635)&&f_109_17616_17628(switchKey, 0)!= '/'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,17572,17945);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17705,17866) || true) && (parser != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,17705,17866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17765,17776);

--argIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17798,17847);

f_109_17798_17846(                    parser, args, ref argIndex, noexitSeen);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,17705,17866);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,17886,17930);

return (SwitchKey: null, ShouldBreak: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,17572,17945);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18096,18131);

switchKey = f_109_18108_18130(switchKey, 1);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18229,18388) || true) && (!f_109_18234_18265(switchKey)&&(DynAbs.Tracing.TraceSender.Expression_True(109, 18233, 18304)&&f_109_18269_18304(f_109_18291_18303(switchKey, 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,18229,18388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18338,18373);

switchKey = f_109_18350_18372(switchKey, 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,18229,18388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18404,18454);

return (SwitchKey: switchKey, ShouldBreak: false);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(109,17175,18465);

string
f_109_17372_17393(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 17372, 17393);
return return_v;
}


string
f_109_17372_17412(string
this_param)
{
var return_v = this_param.ToLowerInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 17372, 17412);
return return_v;
}


bool
f_109_17431_17462(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 17431, 17462);
return return_v;
}


char
f_109_17599_17611(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 17599, 17611);
return return_v;
}


bool
f_109_17577_17612(char
c)
{
var return_v = c.IsDash();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 17577, 17612);
return return_v;
}


char
f_109_17616_17628(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 17616, 17628);
return return_v;
}


bool
f_109_17798_17846(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,bool
noexitSeen)
{
var return_v = this_param.ParseFile( args, ref i, noexitSeen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 17798, 17846);
return return_v;
}


string
f_109_18108_18130(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18108, 18130);
return return_v;
}


bool
f_109_18234_18265(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18234, 18265);
return return_v;
}


char
f_109_18291_18303(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 18291, 18303);
return return_v;
}


bool
f_109_18269_18304(char
c)
{
var return_v = c.IsDash();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18269, 18304);
return return_v;
}


string
f_109_18350_18372(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18350, 18372);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,17175,18465);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,17175,18465);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string NormalizeFilePath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(109,18477,18774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18588,18717);

path = f_109_18595_18716(path, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18733,18763);

return f_109_18740_18762(path);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(109,18477,18774);

string
f_109_18595_18716(string
this_param,char
oldChar,char
newChar)
{
var return_v = this_param.Replace( oldChar, newChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18595, 18716);
return return_v;
}


string
f_109_18740_18762(string
path)
{
var return_v = Path.GetFullPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18740, 18762);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,18477,18774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,18477,18774);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool MatchSwitch(string switchKey, string match, string smallestUnambiguousMatch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(109,18786,19627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18907,18953);

f_109_18907_18952(switchKey != null, "need a value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,18967,19024);

f_109_18967_19023(!f_109_18979_19006(match), "need a value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19038,19159);

f_109_19038_19158(f_109_19049_19080(f_109_19049_19061(match))== match, "match should be normalized to lowercase w/ no outside whitespace");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19173,19332);

f_109_19173_19331(f_109_19184_19234(f_109_19184_19215(smallestUnambiguousMatch))== smallestUnambiguousMatch, "match should be normalized to lowercase w/ no outside whitespace");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19346,19437);

f_109_19346_19436(f_109_19357_19397(match, smallestUnambiguousMatch), "sUM should be a substring of match");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19453,19616);

return (f_109_19461_19537(f_109_19461_19492(f_109_19461_19473(match)), switchKey, StringComparison.Ordinal)== 0 &&(DynAbs.Tracing.TraceSender.Expression_True(109, 19461, 19614)&&f_109_19563_19579(switchKey)>= f_109_19583_19614(smallestUnambiguousMatch)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(109,18786,19627);

int
f_109_18907_18952(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18907, 18952);
return 0;
}


bool
f_109_18979_19006(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18979, 19006);
return return_v;
}


int
f_109_18967_19023(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 18967, 19023);
return 0;
}


string
f_109_19049_19061(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19049, 19061);
return return_v;
}


string
f_109_19049_19080(string
this_param)
{
var return_v = this_param.ToLowerInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19049, 19080);
return return_v;
}


int
f_109_19038_19158(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19038, 19158);
return 0;
}


string
f_109_19184_19215(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19184, 19215);
return return_v;
}


string
f_109_19184_19234(string
this_param)
{
var return_v = this_param.ToLowerInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19184, 19234);
return return_v;
}


int
f_109_19173_19331(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19173, 19331);
return 0;
}


bool
f_109_19357_19397(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19357, 19397);
return return_v;
}


int
f_109_19346_19436(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19346, 19436);
return 0;
}


string
f_109_19461_19473(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19461, 19473);
return return_v;
}


string
f_109_19461_19492(string
this_param)
{
var return_v = this_param.ToLowerInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19461, 19492);
return return_v;
}


int
f_109_19461_19537(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19461, 19537);
return return_v;
}


int
f_109_19563_19579(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 19563, 19579);
return return_v;
}


int
f_109_19583_19614(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 19583, 19614);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,18786,19627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,18786,19627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ShowHelp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,19661,20050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19709,19771);

f_109_19709_19770(_helpText != null, "_helpText should not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19785,19817);

f_109_19785_19816(            _hostUI, string.Empty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19831,19856);

f_109_19831_19855(            _hostUI, _helpText);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19870,19991) || true) && (_showExtendedHelp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,19870,19991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,19925,19976);

f_109_19925_19975(                _hostUI, f_109_19939_19974());
DynAbs.Tracing.TraceSender.TraceExitCondition(109,19870,19991);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,20007,20039);

f_109_20007_20038(
            _hostUI, string.Empty);
DynAbs.Tracing.TraceSender.TraceExitMethod(109,19661,20050);

int
f_109_19709_19770(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19709, 19770);
return 0;
}


int
f_109_19785_19816(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19785, 19816);
return 0;
}


int
f_109_19831_19855(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19831, 19855);
return 0;
}


string
f_109_19939_19974()
{
var return_v = ManagedEntranceStrings.ExtendedHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 19939, 19974);
return return_v;
}


int
f_109_19925_19975(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 19925, 19975);
return 0;
}


int
f_109_20007_20038(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 20007, 20038);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,19661,20050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,19661,20050);
}
		}

private void DisplayBanner()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,20062,20341);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,20174,20330) || true) && (!f_109_20179_20212(_bannerText))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,20174,20330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,20246,20277);

f_109_20246_20276(                _hostUI, _bannerText);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,20295,20315);

f_109_20295_20314(                _hostUI);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,20174,20330);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(109,20062,20341);

bool
f_109_20179_20212(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 20179, 20212);
return return_v;
}


int
f_109_20246_20276(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 20246, 20276);
return 0;
}


int
f_109_20295_20314(System.Management.Automation.Host.PSHostUserInterface
this_param)
{
this_param.WriteLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 20295, 20314);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,20062,20341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,20062,20341);
}
		}

internal bool StaMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,20399,20648);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,20435,20633) || true) && (f_109_20439_20456(_staMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,20435,20633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,20498,20520);

return f_109_20505_20519(_staMode);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,20435,20633);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,20435,20633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,20602,20614);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,20435,20633);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(109,20399,20648);

bool
f_109_20439_20456(bool?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 20439, 20456);
return return_v;
}


bool
f_109_20505_20519(bool?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 20505, 20519);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,20353,20659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,20353,20659);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void Parse(string[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,21042,21791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21101,21184);

f_109_21101_21183(!_dirty, "This instance has already been used. Create a new instance.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21361,21375);

_dirty = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21391,21409);

f_109_21391_21408(this, args);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21572,21634);

var 
configurationName = f_109_21596_21633()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21648,21780) || true) && (!f_109_21653_21692(configurationName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,21648,21780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21726,21765);

_configurationName = configurationName;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,21648,21780);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(109,21042,21791);

int
f_109_21101_21183(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 21101, 21183);
return 0;
}


int
f_109_21391_21408(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args)
{
this_param.ParseHelper( args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 21391, 21408);
return 0;
}


string
f_109_21596_21633()
{
var return_v = GetConfigurationNameFromGroupPolicy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 21596, 21633);
return return_v;
}


bool
f_109_21653_21692(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 21653, 21692);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,21042,21791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,21042,21791);
}
		}

private void ParseHelper(string[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,21803,35909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21867,21947);

f_109_21867_21946(args != null, "Argument 'args' to ParseHelper should never be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,21961,21985);

bool 
noexitSeen = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22010,22015);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22001,35257) || true) && (i < f_109_22021_22032(args))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22034,22037)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(109,22001,35257))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,22001,35257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22071,22175);

(string SwitchKey, bool ShouldBreak) 
switchKeyResults = f_109_22127_22174(args, ref i, this, ref noexitSeen)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22193,22292) || true) && (switchKeyResults.ShouldBreak)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,22193,22292);
DynAbs.Tracing.TraceSender.TraceBreak(109,22267,22273);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,22193,22292);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22312,22358);

string 
switchKey = switchKeyResults.SwitchKey
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22479,22797) || true) && (f_109_22483_22521(switchKey, "version", "v"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,22479,22797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22563,22583);

_showVersion = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22605,22625);

_showBanner = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22647,22669);

_noInteractive = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22691,22712);

_skipUserInit = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22734,22750);

_noExit = false;
DynAbs.Tracing.TraceSender.TraceBreak(109,22772,22778);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,22479,22797);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22817,35242) || true) && (f_109_22821_22856(switchKey, "help", "h")||(DynAbs.Tracing.TraceSender.Expression_False(109, 22821, 22892)||f_109_22860_22892(switchKey, "?", "?")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,22817,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22934,22951);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,22973,22998);

_showExtendedHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23020,23041);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,22817,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,22817,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23083,35242) || true) && (f_109_23087_23123(switchKey, "login", "l"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23083,35242);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23083,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23083,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23365,35242) || true) && (f_109_23369_23408(switchKey, "noexit", "noe"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23365,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23450,23465);

_noExit = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23487,23505);

noexitSeen = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23365,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23365,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23547,35242) || true) && (f_109_23551_23593(switchKey, "noprofile", "nop"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23547,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23635,23656);

_skipUserInit = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23547,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23547,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23698,35242) || true) && (f_109_23702_23741(switchKey, "nologo", "nol"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23698,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23783,23803);

_showBanner = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23698,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23698,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23845,35242) || true) && (f_109_23849_23897(switchKey, "noninteractive", "noni"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23845,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,23939,23961);

_noInteractive = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23845,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,23845,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24003,35242) || true) && (f_109_24007_24055(switchKey, "socketservermode", "so"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24003,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24097,24122);

_socketServerMode = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24003,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24003,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24164,35242) || true) && (f_109_24168_24209(switchKey, "servermode", "s"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24164,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24251,24270);

_serverMode = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24164,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24164,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24312,35242) || true) && (f_109_24316_24368(switchKey, "namedpipeservermode", "nam"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24312,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24410,24438);

_namedPipeServerMode = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24312,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24312,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24480,35242) || true) && (f_109_24484_24531(switchKey, "sshservermode", "sshs"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24480,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24573,24595);

_sshServerMode = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24480,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24480,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24637,35242) || true) && (f_109_24641_24683(switchKey, "interactive", "i"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24637,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24725,24748);

_noInteractive = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24637,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24637,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24790,35242) || true) && (f_109_24794_24847(switchKey, "configurationname", "config"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24790,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24889,24893);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24915,25160) || true) && (i >= f_109_24924_24935(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24915,25160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,24985,25105);

f_109_24985_25104(this, f_109_25037_25103());
DynAbs.Tracing.TraceSender.TraceBreak(109,25131,25137);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24915,25160);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25184,25213);

_configurationName = args[i];
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24790,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,24790,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25255,35242) || true) && (f_109_25259_25306(switchKey, "custompipename", "cus"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,25255,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25348,25352);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25374,25616) || true) && (i >= f_109_25383_25394(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,25374,25616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25444,25561);

f_109_25444_25560(this, f_109_25496_25559());
DynAbs.Tracing.TraceSender.TraceBreak(109,25587,25593);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,25374,25616);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25640,26351) || true) && (f_109_25644_25663_M(!Platform.IsWindows))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,25640,26351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25713,25830);

int 
maxNameLength = ((DynAbs.Tracing.TraceSender.Conditional_F1(109, 25734, 25750)||((f_109_25734_25750()&&DynAbs.Tracing.TraceSender.Conditional_F2(109, 25753, 25775))||DynAbs.Tracing.TraceSender.Conditional_F3(109, 25778, 25800)))?MaxPipePathLengthLinux :MaxPipePathLengthMacOS) - f_109_25804_25829(f_109_25804_25822())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25856,26328) || true) && (f_109_25860_25874(args[i])> maxNameLength)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,25856,26328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,25948,26265);

f_109_25948_26264(this, f_109_26004_26263(f_109_26056_26111(), maxNameLength, args[i], f_109_26248_26262(args[i])));
DynAbs.Tracing.TraceSender.TraceBreak(109,26295,26301);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,25856,26328);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,25640,26351);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,26375,26401);

_customPipeName = args[i];
DynAbs.Tracing.TraceSender.TraceExitCondition(109,25255,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,25255,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,26443,35242) || true) && (f_109_26447_26485(switchKey, "command", "c"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,26443,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,26527,26655) || true) && (!f_109_26532_26576(this, args, ref i, noexitSeen, false))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,26527,26655);
DynAbs.Tracing.TraceSender.TraceBreak(109,26626,26632);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,26527,26655);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,26443,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,26443,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,26697,35242) || true) && (f_109_26701_26743(switchKey, "windowstyle", "w"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,26697,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,26969,26973);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,26995,27234) || true) && (i >= f_109_27004_27015(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,26995,27234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,27065,27179);

f_109_27065_27178(this, f_109_27117_27177());
DynAbs.Tracing.TraceSender.TraceBreak(109,27205,27211);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,26995,27234);
}

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,27310,27483);

ProcessWindowStyle 
style = (ProcessWindowStyle)f_109_27357_27482(args[i], typeof(ProcessWindowStyle), f_109_27453_27481())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,27509,27546);

f_109_27509_27545(style);
                    }
                    catch (PSInvalidCastException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(109,27591,27904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,27672,27849);

f_109_27672_27848(this, f_109_27724_27847(f_109_27738_27764(), f_109_27766_27826(), args[i], f_109_27837_27846(e)));
DynAbs.Tracing.TraceSender.TraceBreak(109,27875,27881);

break;
DynAbs.Tracing.TraceSender.TraceExitCatch(109,27591,27904);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(109,26697,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,26697,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,27954,35242) || true) && (f_109_27958_27993(switchKey, "file", "f"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,27954,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,28035,28153) || true) && (!f_109_28040_28074(this, args, ref i, noexitSeen))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,28035,28153);
DynAbs.Tracing.TraceSender.TraceBreak(109,28124,28130);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,28035,28153);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,27954,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,27954,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,28404,35242) || true) && (f_109_28408_28443(switchKey, "wait", "w"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,28404,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,28560,28655);

f_109_28560_28654(                    // This does not need to be localized: its chk only

                    ((ConsoleHostUserInterface)_hostUI), "Waiting - type enter to continue:", false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,28677,28696);

f_109_28677_28695(                    _hostUI);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,28404,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,28404,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,28837,35242) || true) && (f_109_28841_28877(switchKey, "iss", "iss"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,28837,35242);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,28837,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,28837,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,29265,35242) || true) && (f_109_29269_29313(switchKey, "isswait", "isswait"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,29265,35242);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,29265,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,29265,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,29452,35242) || true) && (f_109_29456_29496(switchKey, "modules", "mod"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,29452,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,29538,29904) || true) && (ConsoleHost.DefaultInitialSessionState == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,29538,29904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,29638,29849);

f_109_29638_29848(this, "The -module option can only be specified with the -iss option.", showHelp: true, showBanner: false);
DynAbs.Tracing.TraceSender.TraceBreak(109,29875,29881);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,29538,29904);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,29928,29932);

++i;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,29954,29974);

int 
moduleCount = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30063,30627) || true) && (i < f_109_30074_30085(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,30063,30627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30135,30156);

string 
arg = args[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30184,30572) || true) && (!f_109_30189_30214(arg)&&(DynAbs.Tracing.TraceSender.Expression_True(109, 30188, 30247)&&f_109_30218_30247(f_109_30240_30246(arg, 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,30184,30572);
DynAbs.Tracing.TraceSender.TraceBreak(109,30305,30311);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,30184,30572);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,30184,30572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30425,30501);

f_109_30425_30500(                            ConsoleHost.DefaultInitialSessionState, new string[] { arg });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30531,30545);

moduleCount++;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,30184,30572);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30600,30604);

++i;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,30063,30627);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,30063,30627);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,30063,30627);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30651,30809) || true) && (moduleCount < 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,30651,30809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30720,30786);

f_109_30720_30785(                        _hostUI, "No modules specified for -module option");
DynAbs.Tracing.TraceSender.TraceExitCondition(109,30651,30809);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,29452,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,29452,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30859,35242) || true) && (f_109_30863_30906(switchKey, "outputformat", "o")||(DynAbs.Tracing.TraceSender.Expression_False(109, 30863, 30943)||f_109_30910_30943(switchKey, "of", "o")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,30859,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,30985,31090);

f_109_30985_31089(this, args, ref i, ref _outFormat, f_109_31026_31088());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31112,31142);

_outputFormatSpecified = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,30859,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,30859,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31184,35242) || true) && (f_109_31188_31231(switchKey, "inputformat", "in")||(DynAbs.Tracing.TraceSender.Expression_False(109, 31188, 31269)||f_109_31235_31269(switchKey, "if", "if")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,31184,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31311,31414);

f_109_31311_31413(this, args, ref i, ref _inFormat, f_109_31351_31412());
DynAbs.Tracing.TraceSender.TraceExitCondition(109,31184,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,31184,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31456,35242) || true) && (f_109_31460_31507(switchKey, "executionpolicy", "ex")||(DynAbs.Tracing.TraceSender.Expression_False(109, 31460, 31545)||f_109_31511_31545(switchKey, "ep", "ep")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,31456,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31587,31710);

f_109_31587_31709(this, args, ref i, ref _executionPolicy, f_109_31643_31708());
DynAbs.Tracing.TraceSender.TraceExitCondition(109,31456,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,31456,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31752,35242) || true) && (f_109_31756_31801(switchKey, "encodedcommand", "e")||(DynAbs.Tracing.TraceSender.Expression_False(109, 31756, 31838)||f_109_31805_31838(switchKey, "ec", "e")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,31752,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31880,31906);

_wasCommandEncoded = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,31928,32055) || true) && (!f_109_31933_31976(this, args, ref i, noexitSeen, true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,31928,32055);
DynAbs.Tracing.TraceSender.TraceBreak(109,32026,32032);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,31928,32055);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,31752,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,31752,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,32097,35242) || true) && (f_109_32101_32155(switchKey, "encodedarguments", "encodeda")||(DynAbs.Tracing.TraceSender.Expression_False(109, 32101, 32193)||f_109_32159_32193(switchKey, "ea", "ea")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32097,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,32235,32343) || true) && (!f_109_32240_32264(this, args, ref i))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32235,32343);
DynAbs.Tracing.TraceSender.TraceBreak(109,32314,32320);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32235,32343);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32097,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32097,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,32385,35242) || true) && (f_109_32389_32439(switchKey, "settingsfile", "settings"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32385,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,32544,32670) || true) && (!f_109_32549_32591(args, ++i, this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32544,32670);
DynAbs.Tracing.TraceSender.TraceBreak(109,32641,32647);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32544,32670);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32385,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32385,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,32712,35242) || true) && (f_109_32716_32750(switchKey, "sta", "s"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32712,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,32792,33032) || true) && (f_109_32796_32822_M(!Platform.IsWindowsDesktop))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32792,33032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,32872,32977);

f_109_32872_32976(this, f_109_32924_32975());
DynAbs.Tracing.TraceSender.TraceBreak(109,33003,33009);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32792,33032);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33056,33359) || true) && (f_109_33060_33077(_staMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,33056,33359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33193,33304);

f_109_33193_33303(this, f_109_33245_33302());
DynAbs.Tracing.TraceSender.TraceBreak(109,33330,33336);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,33056,33359);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33383,33399);

_staMode = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32712,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,32712,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33441,35242) || true) && (f_109_33445_33481(switchKey, "mta", "mta"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,33441,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33523,33763) || true) && (f_109_33527_33553_M(!Platform.IsWindowsDesktop))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,33523,33763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33603,33708);

f_109_33603_33707(this, f_109_33655_33706());
DynAbs.Tracing.TraceSender.TraceBreak(109,33734,33740);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,33523,33763);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33787,34090) || true) && (f_109_33791_33808(_staMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,33787,34090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,33924,34035);

f_109_33924_34034(this, f_109_33976_34033());
DynAbs.Tracing.TraceSender.TraceBreak(109,34061,34067);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,33787,34090);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34114,34131);

_staMode = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,33441,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,33441,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34173,35242) || true) && (f_109_34177_34225(switchKey, "workingdirectory", "wo")||(DynAbs.Tracing.TraceSender.Expression_False(109, 34177, 34263)||f_109_34229_34263(switchKey, "wd", "wd")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,34173,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34305,34309);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34331,34575) || true) && (i >= f_109_34340_34351(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,34331,34575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34401,34520);

f_109_34401_34519(this, f_109_34453_34518());
DynAbs.Tracing.TraceSender.TraceBreak(109,34546,34552);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,34331,34575);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34599,34627);

_workingDirectory = args[i];
DynAbs.Tracing.TraceSender.TraceExitCondition(109,34173,35242);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,34173,35242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34680,35242) || true) && (f_109_34684_34792(switchKey, "removeworkingdirectorytrailingcharacter", "removeworkingdirectorytrailingcharacter"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,34680,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,34834,34882);

_removeWorkingDirectoryTrailingCharacter = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,34680,35242);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,34680,35242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35079,35083);

--i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35105,35223) || true) && (!f_109_35110_35144(this, args, ref i, noexitSeen))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,35105,35223);
DynAbs.Tracing.TraceSender.TraceBreak(109,35194,35200);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,35105,35223);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,34680,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,34173,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,33441,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32712,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32385,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,32097,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,31752,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,31456,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,31184,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,30859,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,29452,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,29265,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,28837,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,28404,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,27954,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,26697,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,26443,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,25255,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24790,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24637,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24480,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24312,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24164,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,24003,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23845,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23698,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23547,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23365,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,23083,35242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,22817,35242);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,1,13257);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,1,13257);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35273,35346) || true) && (_showHelp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,35273,35346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35320,35331);

f_109_35320_35330(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,35273,35346);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35362,35629) || true) && (_showBanner &&(DynAbs.Tracing.TraceSender.Expression_True(109, 35366, 35391)&&!_showHelp))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,35362,35629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35425,35441);

f_109_35425_35440(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35461,35614) || true) && (UpdatesNotification.CanNotifyUpdates)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,35461,35614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35543,35595);

f_109_35543_35594(_hostUI);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,35461,35614);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,35362,35629);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,35645,35898);

f_109_35645_35897(((_exitCode == ConsoleHost.ExitCodeBadCommandLineParameter) &&(DynAbs.Tracing.TraceSender.Expression_True(109, 35679, 35754)&&_abortStartup))
||(DynAbs.Tracing.TraceSender.Expression_False(109, 35678, 35818)||(_exitCode == ConsoleHost.ExitCodeSuccess)), "if exit code is failure, then abortstartup should be true");
DynAbs.Tracing.TraceSender.TraceExitMethod(109,21803,35909);

int
f_109_21867_21946(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 21867, 21946);
return 0;
}


int
f_109_22021_22032(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 22021, 22032);
return return_v;
}


(string SwitchKey, bool ShouldBreak)
f_109_22127_22174(string[]
args,ref int
argIndex,Microsoft.PowerShell.CommandLineParameterParser
parser,ref bool
noexitSeen)
{
var return_v = GetSwitchKey( args, ref argIndex, parser, ref noexitSeen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 22127, 22174);
return return_v;
}


bool
f_109_22483_22521(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 22483, 22521);
return return_v;
}


bool
f_109_22821_22856(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 22821, 22856);
return return_v;
}


bool
f_109_22860_22892(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 22860, 22892);
return return_v;
}


bool
f_109_23087_23123(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 23087, 23123);
return return_v;
}


bool
f_109_23369_23408(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 23369, 23408);
return return_v;
}


bool
f_109_23551_23593(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 23551, 23593);
return return_v;
}


bool
f_109_23702_23741(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 23702, 23741);
return return_v;
}


bool
f_109_23849_23897(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 23849, 23897);
return return_v;
}


bool
f_109_24007_24055(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 24007, 24055);
return return_v;
}


bool
f_109_24168_24209(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 24168, 24209);
return return_v;
}


bool
f_109_24316_24368(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 24316, 24368);
return return_v;
}


bool
f_109_24484_24531(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 24484, 24531);
return return_v;
}


bool
f_109_24641_24683(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 24641, 24683);
return return_v;
}


bool
f_109_24794_24847(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 24794, 24847);
return return_v;
}


int
f_109_24924_24935(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 24924, 24935);
return return_v;
}


string
f_109_25037_25103()
{
var return_v =                             CommandLineParameterParserStrings.MissingConfigurationNameArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 25037, 25103);
return return_v;
}


int
f_109_24985_25104(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 24985, 25104);
return 0;
}


bool
f_109_25259_25306(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 25259, 25306);
return return_v;
}


int
f_109_25383_25394(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 25383, 25394);
return return_v;
}


string
f_109_25496_25559()
{
var return_v =                             CommandLineParameterParserStrings.MissingCustomPipeNameArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 25496, 25559);
return return_v;
}


int
f_109_25444_25560(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 25444, 25560);
return 0;
}


bool
f_109_25644_25663_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 25644, 25663);
return return_v;
}


bool
f_109_25734_25750()
{
var return_v = Platform.IsLinux ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 25734, 25750);
return return_v;
}


string
f_109_25804_25822()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 25804, 25822);
return return_v;
}


int
f_109_25804_25829(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 25804, 25829);
return return_v;
}


int
f_109_25860_25874(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 25860, 25874);
return return_v;
}


string
f_109_26056_26111()
{
var return_v =                                     CommandLineParameterParserStrings.CustomPipeNameTooLong;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 26056, 26111);
return return_v;
}


int
f_109_26248_26262(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 26248, 26262);
return return_v;
}


string
f_109_26004_26263(string
format,int
arg0,string
arg1,int
arg2)
{
var return_v = string.Format( format, (object)arg0, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 26004, 26263);
return return_v;
}


int
f_109_25948_26264(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 25948, 26264);
return 0;
}


bool
f_109_26447_26485(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 26447, 26485);
return return_v;
}


bool
f_109_26532_26576(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,bool
noexitSeen,bool
isEncoded)
{
var return_v = this_param.ParseCommand( args, ref i, noexitSeen, isEncoded);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 26532, 26576);
return return_v;
}


bool
f_109_26701_26743(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 26701, 26743);
return return_v;
}


int
f_109_27004_27015(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 27004, 27015);
return return_v;
}


string
f_109_27117_27177()
{
var return_v =                             CommandLineParameterParserStrings.MissingWindowStyleArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 27117, 27177);
return return_v;
}


int
f_109_27065_27178(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 27065, 27178);
return 0;
}


System.Globalization.CultureInfo
f_109_27453_27481()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 27453, 27481);
return return_v;
}


object
f_109_27357_27482(string
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( (object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 27357, 27482);
return return_v;
}


int
f_109_27509_27545(System.Diagnostics.ProcessWindowStyle
style)
{
ConsoleControl.SetConsoleMode( style);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 27509, 27545);
return 0;
}


System.Globalization.CultureInfo
f_109_27738_27764()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 27738, 27764);
return return_v;
}


string
f_109_27766_27826()
{
var return_v = CommandLineParameterParserStrings.InvalidWindowStyleArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 27766, 27826);
return return_v;
}


string
f_109_27837_27846(System.Management.Automation.PSInvalidCastException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 27837, 27846);
return return_v;
}


string
f_109_27724_27847(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 27724, 27847);
return return_v;
}


int
f_109_27672_27848(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 27672, 27848);
return 0;
}


bool
f_109_27958_27993(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 27958, 27993);
return return_v;
}


bool
f_109_28040_28074(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,bool
noexitSeen)
{
var return_v = this_param.ParseFile( args, ref i, noexitSeen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 28040, 28074);
return return_v;
}


bool
f_109_28408_28443(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 28408, 28443);
return return_v;
}


int
f_109_28560_28654(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 28560, 28654);
return 0;
}


string
f_109_28677_28695(System.Management.Automation.Host.PSHostUserInterface
this_param)
{
var return_v = this_param.ReadLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 28677, 28695);
return return_v;
}


bool
f_109_28841_28877(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 28841, 28877);
return return_v;
}


bool
f_109_29269_29313(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 29269, 29313);
return return_v;
}


bool
f_109_29456_29496(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 29456, 29496);
return return_v;
}


int
f_109_29638_29848(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg,bool
showHelp,bool
showBanner)
{
this_param.WriteCommandLineError( msg, showHelp:showHelp, showBanner:showBanner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 29638, 29848);
return 0;
}


int
f_109_30074_30085(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 30074, 30085);
return return_v;
}


bool
f_109_30189_30214(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 30189, 30214);
return return_v;
}


char
f_109_30240_30246(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 30240, 30246);
return return_v;
}


bool
f_109_30218_30247(char
c)
{
var return_v = c.IsDash();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 30218, 30247);
return return_v;
}


int
f_109_30425_30500(System.Management.Automation.Runspaces.InitialSessionState
this_param,params string[]
name)
{
this_param.ImportPSModule( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 30425, 30500);
return 0;
}


int
f_109_30720_30785(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 30720, 30785);
return 0;
}


bool
f_109_30863_30906(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 30863, 30906);
return return_v;
}


bool
f_109_30910_30943(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 30910, 30943);
return return_v;
}


string
f_109_31026_31088()
{
var return_v = CommandLineParameterParserStrings.MissingOutputFormatParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 31026, 31088);
return return_v;
}


int
f_109_30985_31089(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,ref Microsoft.PowerShell.Serialization.DataFormat
format,string
resourceStr)
{
this_param.ParseFormat( args, ref i, ref format, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 30985, 31089);
return 0;
}


bool
f_109_31188_31231(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31188, 31231);
return return_v;
}


bool
f_109_31235_31269(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31235, 31269);
return return_v;
}


string
f_109_31351_31412()
{
var return_v = CommandLineParameterParserStrings.MissingInputFormatParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 31351, 31412);
return return_v;
}


int
f_109_31311_31413(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,ref Microsoft.PowerShell.Serialization.DataFormat
format,string
resourceStr)
{
this_param.ParseFormat( args, ref i, ref format, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31311, 31413);
return 0;
}


bool
f_109_31460_31507(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31460, 31507);
return return_v;
}


bool
f_109_31511_31545(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31511, 31545);
return return_v;
}


string
f_109_31643_31708()
{
var return_v = CommandLineParameterParserStrings.MissingExecutionPolicyParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 31643, 31708);
return return_v;
}


int
f_109_31587_31709(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,ref string
executionPolicy,string
resourceStr)
{
this_param.ParseExecutionPolicy( args, ref i, ref executionPolicy, resourceStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31587, 31709);
return 0;
}


bool
f_109_31756_31801(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31756, 31801);
return return_v;
}


bool
f_109_31805_31838(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31805, 31838);
return return_v;
}


bool
f_109_31933_31976(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,bool
noexitSeen,bool
isEncoded)
{
var return_v = this_param.ParseCommand( args, ref i, noexitSeen, isEncoded);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 31933, 31976);
return return_v;
}


bool
f_109_32101_32155(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 32101, 32155);
return return_v;
}


bool
f_109_32159_32193(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 32159, 32193);
return return_v;
}


bool
f_109_32240_32264(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i)
{
var return_v = this_param.CollectArgs( args, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 32240, 32264);
return return_v;
}


bool
f_109_32389_32439(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 32389, 32439);
return return_v;
}


bool
f_109_32549_32591(string[]
args,int
settingFileArgIndex,Microsoft.PowerShell.CommandLineParameterParser
parser)
{
var return_v = TryParseSettingFileHelper( args, settingFileArgIndex, parser);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 32549, 32591);
return return_v;
}


bool
f_109_32716_32750(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 32716, 32750);
return return_v;
}


bool
f_109_32796_32822_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 32796, 32822);
return return_v;
}


string
f_109_32924_32975()
{
var return_v =                             CommandLineParameterParserStrings.STANotImplemented;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 32924, 32975);
return return_v;
}


int
f_109_32872_32976(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 32872, 32976);
return 0;
}


bool
f_109_33060_33077(bool?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 33060, 33077);
return return_v;
}


string
f_109_33245_33302()
{
var return_v =                             CommandLineParameterParserStrings.MtaStaMutuallyExclusive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 33245, 33302);
return return_v;
}


int
f_109_33193_33303(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 33193, 33303);
return 0;
}


bool
f_109_33445_33481(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 33445, 33481);
return return_v;
}


bool
f_109_33527_33553_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 33527, 33553);
return return_v;
}


string
f_109_33655_33706()
{
var return_v =                             CommandLineParameterParserStrings.MTANotImplemented;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 33655, 33706);
return return_v;
}


int
f_109_33603_33707(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 33603, 33707);
return 0;
}


bool
f_109_33791_33808(bool?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 33791, 33808);
return return_v;
}


string
f_109_33976_34033()
{
var return_v =                             CommandLineParameterParserStrings.MtaStaMutuallyExclusive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 33976, 34033);
return return_v;
}


int
f_109_33924_34034(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 33924, 34034);
return 0;
}


bool
f_109_34177_34225(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 34177, 34225);
return return_v;
}


bool
f_109_34229_34263(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 34229, 34263);
return return_v;
}


int
f_109_34340_34351(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 34340, 34351);
return return_v;
}


string
f_109_34453_34518()
{
var return_v =                             CommandLineParameterParserStrings.MissingWorkingDirectoryArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 34453, 34518);
return return_v;
}


int
f_109_34401_34519(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg)
{
this_param.WriteCommandLineError( msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 34401, 34519);
return 0;
}


bool
f_109_34684_34792(string
switchKey,string
match,string
smallestUnambiguousMatch)
{
var return_v = MatchSwitch( switchKey, match, smallestUnambiguousMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 34684, 34792);
return return_v;
}


bool
f_109_35110_35144(Microsoft.PowerShell.CommandLineParameterParser
this_param,string[]
args,ref int
i,bool
noexitSeen)
{
var return_v = this_param.ParseFile( args, ref i, noexitSeen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 35110, 35144);
return return_v;
}


int
f_109_35320_35330(Microsoft.PowerShell.CommandLineParameterParser
this_param)
{
this_param.ShowHelp();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 35320, 35330);
return 0;
}


int
f_109_35425_35440(Microsoft.PowerShell.CommandLineParameterParser
this_param)
{
this_param.DisplayBanner();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 35425, 35440);
return 0;
}


int
f_109_35543_35594(System.Management.Automation.Host.PSHostUserInterface
hostUI)
{
UpdatesNotification.ShowUpdateNotification( hostUI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 35543, 35594);
return 0;
}


int
f_109_35645_35897(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 35645, 35897);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,21803,35909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,21803,35909);
}
		}

private void WriteCommandLineError(string msg, bool showHelp = false, bool showBanner = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,35921,36258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36040,36068);

f_109_36040_36067(            _hostUI, msg);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36082,36103);

_showHelp = showHelp;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36117,36142);

_showBanner = showBanner;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36156,36177);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36191,36247);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,35921,36258);

int
f_109_36040_36067(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36040, 36067);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,35921,36258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,35921,36258);
}
		}

private void ParseFormat(string[] args, ref int i, ref Serialization.DataFormat format, string resourceStr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,36270,37684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36402,36441);

StringBuilder 
sb = f_109_36421_36440()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36455,36634);
foreach(string s in f_109_36476_36523_I(f_109_36476_36523(typeof(Serialization.DataFormat))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,36455,36634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36557,36570);

f_109_36557_36569(                sb, s);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36588,36619);

f_109_36588_36618(                sb, f_109_36598_36617());
DynAbs.Tracing.TraceSender.TraceExitCondition(109,36455,36634);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,1,180);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,1,180);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36650,36654);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36668,37053) || true) && (i >= f_109_36677_36688(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,36668,37053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36722,36865);

f_109_36722_36864(                _hostUI, f_109_36767_36863(resourceStr, f_109_36849_36862(                        sb)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36883,36900);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36918,36939);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,36957,37013);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37031,37038);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,36668,37053);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37105,37200);

format = (Serialization.DataFormat)f_109_37140_37199(typeof(Serialization.DataFormat), args[i], true);
            }
            catch (ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(109,37229,37673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37287,37510);

f_109_37287_37509(                _hostUI, f_109_37332_37508(f_109_37376_37433(), args[i], f_109_37494_37507(                        sb)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37528,37545);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37563,37584);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37602,37658);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceExitCatch(109,37229,37673);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(109,36270,37684);

System.Text.StringBuilder
f_109_36421_36440()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36421, 36440);
return return_v;
}


string[]
f_109_36476_36523(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36476, 36523);
return return_v;
}


System.Text.StringBuilder
f_109_36557_36569(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36557, 36569);
return return_v;
}


string
f_109_36598_36617()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 36598, 36617);
return return_v;
}


System.Text.StringBuilder
f_109_36588_36618(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36588, 36618);
return return_v;
}


string[]
f_109_36476_36523_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36476, 36523);
return return_v;
}


int
f_109_36677_36688(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 36677, 36688);
return return_v;
}


string
f_109_36849_36862(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36849, 36862);
return return_v;
}


string
f_109_36767_36863(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36767, 36863);
return return_v;
}


int
f_109_36722_36864(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 36722, 36864);
return 0;
}


object
f_109_37140_37199(System.Type
enumType,string
value,bool
ignoreCase)
{
var return_v = Enum.Parse( enumType, value, ignoreCase);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 37140, 37199);
return return_v;
}


string
f_109_37376_37433()
{
var return_v =                         CommandLineParameterParserStrings.BadFormatParameterValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 37376, 37433);
return return_v;
}


string
f_109_37494_37507(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 37494, 37507);
return return_v;
}


string
f_109_37332_37508(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 37332, 37508);
return return_v;
}


int
f_109_37287_37509(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 37287, 37509);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,36270,37684);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,36270,37684);
}
		}

private void ParseExecutionPolicy(string[] args, ref int i, ref string executionPolicy, string resourceStr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,37696,38179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37828,37832);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37846,38126) || true) && (i >= f_109_37855_37866(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,37846,38126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37900,37936);

f_109_37900_37935(                _hostUI, resourceStr);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37956,37973);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,37991,38012);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,38030,38086);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,38104,38111);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,37846,38126);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,38142,38168);

executionPolicy = args[i];
DynAbs.Tracing.TraceSender.TraceExitMethod(109,37696,38179);

int
f_109_37855_37866(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 37855, 37866);
return return_v;
}


int
f_109_37900_37935(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 37900, 37935);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,37696,38179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,37696,38179);
}
		}

private bool ParseFile(string[] args, ref int i, bool noexitSeen)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,38191,45025);
bool boolValue = default(bool);

bool TryGetBoolValue(string arg, out bool boolValue)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,38600,39253);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,38685,39169) || true) && (f_109_38689_38744(arg, "$true", StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(109, 38689, 38802)||f_109_38748_38802(arg, "true", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,38685,39169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,38844,38861);

boolValue = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,38883,38895);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,38685,39169);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,38685,39169);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,38937,39169) || true) && (f_109_38941_38997(arg, "$false", StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(109, 38941, 39056)||f_109_39001_39056(arg, "false", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,38937,39169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39098,39116);

boolValue = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39138,39150);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,38937,39169);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,38685,39169);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39189,39207);

boolValue = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39225,39238);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,38600,39253);

bool
f_109_38689_38744(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 38689, 38744);
return return_v;
}


bool
f_109_38748_38802(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 38748, 38802);
return return_v;
}


bool
f_109_38941_38997(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 38941, 38997);
return return_v;
}


bool
f_109_39001_39056(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 39001, 39056);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,38600,39253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,38600,39253);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39269,39273);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39287,39563) || true) && (i >= f_109_39296_39307(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,39287,39563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39341,39517);

f_109_39341_39516(this, f_109_39385_39438(), showHelp: true, showBanner: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39535,39548);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,39287,39563);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39660,39714) || true) && (!noexitSeen)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,39660,39714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39694,39714);

_showBanner = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,39660,39714);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39775,44986) || true) && (args[i] == "-")
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,39775,44986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39941,39979);

_explicitReadCommandsFromStdin = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,39997,40015);

_noPrompt = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,39775,44986);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,39775,44986);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,40159,40213) || true) && (!noexitSeen)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,40159,40213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,40197,40213);

_noExit = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,40159,40213);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,40434,40465);

string 
exceptionMessage = null
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,40527,40562);

_file = f_109_40535_40561(args[i]);
                }
                catch (Exception e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(109,40599,40864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,40816,40845);

exceptionMessage = f_109_40835_40844(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(109,40599,40864);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,40884,41225) || true) && (exceptionMessage != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,40884,41225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,40954,41171);

f_109_40954_41170(this, f_109_41002_41125(f_109_41016_41042(), f_109_41044_41097(), args[i], exceptionMessage), showBanner: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41193,41206);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,40884,41225);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41245,42772) || true) && (!f_109_41250_41278(_file))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,41245,42772);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41320,42493) || true) && (f_109_41324_41347(args[i], '-')&&(DynAbs.Tracing.TraceSender.Expression_True(109, 41324, 41369)&&f_109_41351_41365(args[i])> 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,41320,42493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41419,41485);

string 
param = f_109_41434_41484(f_109_41434_41474(args[i], 1, f_109_41455_41469(args[i])- 1))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41511,41566);

StringBuilder 
possibleParameters = f_109_41546_41565()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41592,41968);
foreach(string validParameter in f_109_41626_41641_I(validParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,41592,41968);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41699,41941) || true) && (f_109_41703_41733(validParameter, param))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,41699,41941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41799,41834);

f_109_41799_41833(                                possibleParameters, "\n  -");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41868,41910);

f_109_41868_41909(                                possibleParameters, validParameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,41699,41941);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,41592,41968);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,1,377);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,1,377);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,41996,42470) || true) && (f_109_42000_42025(possibleParameters)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,41996,42470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42087,42298);

f_109_42087_42297(this, f_109_42143_42244(f_109_42157_42183(), f_109_42185_42234(), args[i]), showBanner: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42328,42400);

f_109_42328_42399(this, f_109_42350_42379(possibleParameters), showBanner: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42430,42443);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,41996,42470);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,41320,42493);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42517,42718);

f_109_42517_42717(this, f_109_42565_42675(f_109_42579_42605(), f_109_42607_42665(), args[i]), showHelp: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42740,42753);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,41245,42772);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42792,42796);

i++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42816,42847);

string 
pendingParameter = null
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42930,44971) || true) && (i < f_109_42941_42952(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,42930,44971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,42994,43015);

string 
arg = args[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43192,44924) || true) && (pendingParameter != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43192,44924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43270,43334);

f_109_43270_43333(                        _collectedArgs, f_109_43289_43332(pendingParameter, arg));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43360,43384);

pendingParameter = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43192,44924);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43192,44924);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43434,44924) || true) && (!f_109_43439_43464(arg)&&(DynAbs.Tracing.TraceSender.Expression_True(109, 43438, 43497)&&f_109_43468_43497(f_109_43490_43496(arg, 0)))&&(DynAbs.Tracing.TraceSender.Expression_True(109, 43438, 43515)&&f_109_43501_43511(arg)> 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43434,44924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43565,43595);

int 
offset = f_109_43578_43594(arg, ':')
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43621,44751) || true) && (offset >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43621,44751);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43694,44564) || true) && (offset == f_109_43708_43718(arg)- 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43694,44564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43788,43824);

pendingParameter = f_109_43807_43823(arg, ':');
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43694,44564);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43694,44564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,43954,43998);

string 
argValue = f_109_43972_43997(arg, offset + 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,44032,44074);

string 
argName = f_109_44049_44073(arg, 0, offset)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,44108,44533) || true) && (f_109_44112_44157(argValue, out boolValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,44108,44533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,44231,44292);

f_109_44231_44291(                                    _collectedArgs, f_109_44250_44290(argName, boolValue));
DynAbs.Tracing.TraceSender.TraceExitCondition(109,44108,44533);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,44108,44533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,44438,44498);

f_109_44438_44497(                                    _collectedArgs, f_109_44457_44496(argName, argValue));
DynAbs.Tracing.TraceSender.TraceExitCondition(109,44108,44533);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43694,44564);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43621,44751);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43621,44751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,44678,44724);

f_109_44678_44723(                            _collectedArgs, f_109_44697_44722(arg));
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43621,44751);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43434,44924);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,43434,44924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,44849,44901);

f_109_44849_44900(                        _collectedArgs, f_109_44868_44899(null, arg));
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43434,44924);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,43192,44924);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,44948,44952);

++i;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,42930,44971);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,42930,44971);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,42930,44971);
}DynAbs.Tracing.TraceSender.TraceExitCondition(109,39775,44986);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45002,45014);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,38191,45025);

int
f_109_39296_39307(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 39296, 39307);
return return_v;
}


string
f_109_39385_39438()
{
var return_v =                     CommandLineParameterParserStrings.MissingFileArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 39385, 39438);
return return_v;
}


int
f_109_39341_39516(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg,bool
showHelp,bool
showBanner)
{
this_param.WriteCommandLineError( msg, showHelp:showHelp, showBanner:showBanner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 39341, 39516);
return 0;
}


string
f_109_40535_40561(string
path)
{
var return_v = NormalizeFilePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 40535, 40561);
return return_v;
}


string
f_109_40835_40844(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 40835, 40844);
return return_v;
}


System.Globalization.CultureInfo
f_109_41016_41042()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 41016, 41042);
return return_v;
}


string
f_109_41044_41097()
{
var return_v = CommandLineParameterParserStrings.InvalidFileArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 41044, 41097);
return return_v;
}


string
f_109_41002_41125(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41002, 41125);
return return_v;
}


int
f_109_40954_41170(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg,bool
showBanner)
{
this_param.WriteCommandLineError( msg, showBanner:showBanner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 40954, 41170);
return 0;
}


bool
f_109_41250_41278(string
path)
{
var return_v = System.IO.File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41250, 41278);
return return_v;
}


bool
f_109_41324_41347(string
this_param,char
value)
{
var return_v = this_param.StartsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41324, 41347);
return return_v;
}


int
f_109_41351_41365(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 41351, 41365);
return return_v;
}


int
f_109_41455_41469(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 41455, 41469);
return return_v;
}


string
f_109_41434_41474(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41434, 41474);
return return_v;
}


string
f_109_41434_41484(string
this_param)
{
var return_v = this_param.ToLower();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41434, 41484);
return return_v;
}


System.Text.StringBuilder
f_109_41546_41565()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41546, 41565);
return return_v;
}


bool
f_109_41703_41733(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41703, 41733);
return return_v;
}


System.Text.StringBuilder
f_109_41799_41833(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41799, 41833);
return return_v;
}


System.Text.StringBuilder
f_109_41868_41909(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41868, 41909);
return return_v;
}


string[]
f_109_41626_41641_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 41626, 41641);
return return_v;
}


int
f_109_42000_42025(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 42000, 42025);
return return_v;
}


System.Globalization.CultureInfo
f_109_42157_42183()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 42157, 42183);
return return_v;
}


string
f_109_42185_42234()
{
var return_v = CommandLineParameterParserStrings.InvalidArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 42185, 42234);
return return_v;
}


string
f_109_42143_42244(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 42143, 42244);
return return_v;
}


int
f_109_42087_42297(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg,bool
showBanner)
{
this_param.WriteCommandLineError( msg, showBanner:showBanner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 42087, 42297);
return 0;
}


string
f_109_42350_42379(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 42350, 42379);
return return_v;
}


int
f_109_42328_42399(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg,bool
showBanner)
{
this_param.WriteCommandLineError( msg, showBanner:showBanner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 42328, 42399);
return 0;
}


System.Globalization.CultureInfo
f_109_42579_42605()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 42579, 42605);
return return_v;
}


string
f_109_42607_42665()
{
var return_v = CommandLineParameterParserStrings.ArgumentFileDoesNotExist;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 42607, 42665);
return return_v;
}


string
f_109_42565_42675(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 42565, 42675);
return return_v;
}


int
f_109_42517_42717(Microsoft.PowerShell.CommandLineParameterParser
this_param,string
msg,bool
showHelp)
{
this_param.WriteCommandLineError( msg, showHelp:showHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 42517, 42717);
return 0;
}


int
f_109_42941_42952(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 42941, 42952);
return return_v;
}


System.Management.Automation.Runspaces.CommandParameter
f_109_43289_43332(string
name,string
value)
{
var return_v = new System.Management.Automation.Runspaces.CommandParameter( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 43289, 43332);
return return_v;
}


int
f_109_43270_43333(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
this_param,System.Management.Automation.Runspaces.CommandParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 43270, 43333);
return 0;
}


bool
f_109_43439_43464(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 43439, 43464);
return return_v;
}


char
f_109_43490_43496(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 43490, 43496);
return return_v;
}


bool
f_109_43468_43497(char
c)
{
var return_v = c.IsDash();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 43468, 43497);
return return_v;
}


int
f_109_43501_43511(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 43501, 43511);
return return_v;
}


int
f_109_43578_43594(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 43578, 43594);
return return_v;
}


int
f_109_43708_43718(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 43708, 43718);
return return_v;
}


string
f_109_43807_43823(string
this_param,char
trimChar)
{
var return_v = this_param.TrimEnd( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 43807, 43823);
return return_v;
}


string
f_109_43972_43997(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 43972, 43997);
return return_v;
}


string
f_109_44049_44073(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44049, 44073);
return return_v;
}


bool
f_109_44112_44157(string
arg,out bool
boolValue)
{
var return_v = TryGetBoolValue( arg, out boolValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44112, 44157);
return return_v;
}


System.Management.Automation.Runspaces.CommandParameter
f_109_44250_44290(string
name,bool
value)
{
var return_v = new System.Management.Automation.Runspaces.CommandParameter( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44250, 44290);
return return_v;
}


int
f_109_44231_44291(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
this_param,System.Management.Automation.Runspaces.CommandParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44231, 44291);
return 0;
}


System.Management.Automation.Runspaces.CommandParameter
f_109_44457_44496(string
name,string
value)
{
var return_v = new System.Management.Automation.Runspaces.CommandParameter( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44457, 44496);
return return_v;
}


int
f_109_44438_44497(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
this_param,System.Management.Automation.Runspaces.CommandParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44438, 44497);
return 0;
}


System.Management.Automation.Runspaces.CommandParameter
f_109_44697_44722(string
name)
{
var return_v = new System.Management.Automation.Runspaces.CommandParameter( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44697, 44722);
return return_v;
}


int
f_109_44678_44723(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
this_param,System.Management.Automation.Runspaces.CommandParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44678, 44723);
return 0;
}


System.Management.Automation.Runspaces.CommandParameter
f_109_44868_44899(string
name,string
value)
{
var return_v = new System.Management.Automation.Runspaces.CommandParameter( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44868, 44899);
return return_v;
}


int
f_109_44849_44900(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
this_param,System.Management.Automation.Runspaces.CommandParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 44849, 44900);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,38191,45025);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,38191,45025);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool ParseCommand(string[] args, ref int i, bool noexitSeen, bool isEncoded)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,45037,48601);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45146,45550) || true) && (_commandLineCommand != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,45146,45550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45274,45356);

f_109_45274_45355(                // we've already set the command, so squawk

                _hostUI, f_109_45297_45354());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45374,45391);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45409,45430);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45448,45504);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45522,45535);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,45146,45550);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45566,45570);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45584,45914) || true) && (i >= f_109_45593_45604(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,45584,45914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45638,45720);

f_109_45638_45719(                _hostUI, f_109_45661_45718());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45738,45755);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45773,45794);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45812,45868);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45886,45899);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,45584,45914);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,45930,48321) || true) && (isEncoded)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,45930,48321);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46021,46091);

_commandLineCommand = f_109_46043_46090(args[i]);
                }
                // decoding failed
                catch
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(109,46164,46498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46210,46284);

f_109_46210_46283(                    _hostUI, f_109_46233_46282());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46306,46323);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46345,46366);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46388,46444);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46466,46479);

return false;
DynAbs.Tracing.TraceSender.TraceExitCatch(109,46164,46498);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(109,45930,48321);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,45930,48321);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46532,48321) || true) && (args[i] == "-")
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,46532,48321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46704,46742);

_explicitReadCommandsFromStdin = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46760,46777);

_noPrompt = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46797,46801);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46819,47271) || true) && (i != f_109_46828_46839(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,46819,47271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,46972,47057);

f_109_46972_47056(                    // there are more parameters to -command than -, which is an error.

                    _hostUI, f_109_46995_47055());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47079,47096);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47118,47139);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47161,47217);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47239,47252);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,46819,47271);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47291,47654) || true) && (f_109_47295_47321_M(!Console.IsInputRedirected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,47291,47654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47363,47440);

f_109_47363_47439(                    _hostUI, f_109_47386_47438());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47462,47479);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47501,47522);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47544,47600);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47622,47635);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,47291,47654);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,46532,48321);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,46532,48321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47825,47874);

StringBuilder 
cmdLineCmdSB = f_109_47854_47873()
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47894,48038) || true) && (i < f_109_47905_47916(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,47894,48038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,47958,47993);

f_109_47958_47992(                    cmdLineCmdSB, args[i] + " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48015,48019);

++i;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,47894,48038);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,47894,48038);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,47894,48038);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48058,48240) || true) && (f_109_48062_48081(cmdLineCmdSB)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,48058,48240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48173,48221);

f_109_48173_48220(                    // remove the last blank
                    cmdLineCmdSB, f_109_48193_48212(cmdLineCmdSB)- 1, 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,48058,48240);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48260,48306);

_commandLineCommand = f_109_48282_48305(cmdLineCmdSB);
DynAbs.Tracing.TraceSender.TraceExitCondition(109,46532,48321);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(109,45930,48321);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48337,48526) || true) && (!noexitSeen &&(DynAbs.Tracing.TraceSender.Expression_True(109, 48341, 48387)&&!_explicitReadCommandsFromStdin))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,48337,48526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48495,48511);

_noExit = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,48337,48526);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48542,48562);

_showBanner = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48578,48590);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,45037,48601);

string
f_109_45297_45354()
{
var return_v = CommandLineParameterParserStrings.CommandAlreadySpecified;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 45297, 45354);
return return_v;
}


int
f_109_45274_45355(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 45274, 45355);
return 0;
}


int
f_109_45593_45604(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 45593, 45604);
return return_v;
}


string
f_109_45661_45718()
{
var return_v = CommandLineParameterParserStrings.MissingCommandParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 45661, 45718);
return return_v;
}


int
f_109_45638_45719(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 45638, 45719);
return 0;
}


string
f_109_46043_46090(string
base64)
{
var return_v = StringToBase64Converter.Base64ToString( base64);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 46043, 46090);
return return_v;
}


string
f_109_46233_46282()
{
var return_v = CommandLineParameterParserStrings.BadCommandValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 46233, 46282);
return return_v;
}


int
f_109_46210_46283(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 46210, 46283);
return 0;
}


int
f_109_46828_46839(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 46828, 46839);
return return_v;
}


string
f_109_46995_47055()
{
var return_v = CommandLineParameterParserStrings.TooManyParametersToCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 46995, 47055);
return return_v;
}


int
f_109_46972_47056(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 46972, 47056);
return 0;
}


bool
f_109_47295_47321_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 47295, 47321);
return return_v;
}


string
f_109_47386_47438()
{
var return_v = CommandLineParameterParserStrings.StdinNotRedirected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 47386, 47438);
return return_v;
}


int
f_109_47363_47439(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 47363, 47439);
return 0;
}


System.Text.StringBuilder
f_109_47854_47873()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 47854, 47873);
return return_v;
}


int
f_109_47905_47916(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 47905, 47916);
return return_v;
}


System.Text.StringBuilder
f_109_47958_47992(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 47958, 47992);
return return_v;
}


int
f_109_48062_48081(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 48062, 48081);
return return_v;
}


int
f_109_48193_48212(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 48193, 48212);
return return_v;
}


System.Text.StringBuilder
f_109_48173_48220(System.Text.StringBuilder
this_param,int
startIndex,int
length)
{
var return_v = this_param.Remove( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 48173, 48220);
return return_v;
}


string
f_109_48282_48305(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 48282, 48305);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,45037,48601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,45037,48601);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CollectArgs(string[] args, ref int i)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(109,48613,50151);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48688,49024) || true) && (f_109_48692_48712(_collectedArgs)!= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,48688,49024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48751,48830);

f_109_48751_48829(                _hostUI, f_109_48774_48828());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48848,48865);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48883,48904);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48922,48978);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,48996,49009);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,48688,49024);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49040,49044);

++i;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49058,49381) || true) && (i >= f_109_49067_49078(args))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,49058,49381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49112,49187);

f_109_49112_49186(                _hostUI, f_109_49135_49185());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49205,49222);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49240,49261);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49279,49335);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49353,49366);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(109,49058,49381);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49433,49501);

object[] 
a = f_109_49446_49500(args[i])
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49519,49742) || true) && (a != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,49519,49742);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49574,49723);
foreach(object obj in f_109_49597_49598_I(a) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(109,49574,49723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49648,49700);

f_109_49648_49699(                        _collectedArgs, f_109_49667_49698(null, obj));
DynAbs.Tracing.TraceSender.TraceExitCondition(109,49574,49723);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(109,1,150);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(109,1,150);
}DynAbs.Tracing.TraceSender.TraceExitCondition(109,49519,49742);
}
            }
            catch
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(109,49771,50112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49847,49918);

f_109_49847_49917(                // decoding failed

                _hostUI, f_109_49870_49916());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49936,49953);

_showHelp = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,49971,49992);

_abortStartup = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50010,50066);

_exitCode = ConsoleHost.ExitCodeBadCommandLineParameter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50084,50097);

return false;
DynAbs.Tracing.TraceSender.TraceExitCatch(109,49771,50112);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,50128,50140);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(109,48613,50151);

int
f_109_48692_48712(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 48692, 48712);
return return_v;
}


string
f_109_48774_48828()
{
var return_v = CommandLineParameterParserStrings.ArgsAlreadySpecified;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 48774, 48828);
return return_v;
}


int
f_109_48751_48829(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 48751, 48829);
return 0;
}


int
f_109_49067_49078(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 49067, 49078);
return return_v;
}


string
f_109_49135_49185()
{
var return_v = CommandLineParameterParserStrings.MissingArgsValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 49135, 49185);
return return_v;
}


int
f_109_49112_49186(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 49112, 49186);
return 0;
}


object[]
f_109_49446_49500(string
base64)
{
var return_v = StringToBase64Converter.Base64ToArgsConverter( base64);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 49446, 49500);
return return_v;
}


System.Management.Automation.Runspaces.CommandParameter
f_109_49667_49698(string
name,object
value)
{
var return_v = new System.Management.Automation.Runspaces.CommandParameter( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 49667, 49698);
return return_v;
}


int
f_109_49648_49699(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
this_param,System.Management.Automation.Runspaces.CommandParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 49648, 49699);
return 0;
}


object[]
f_109_49597_49598_I(object[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 49597, 49598);
return return_v;
}


string
f_109_49870_49916()
{
var return_v = CommandLineParameterParserStrings.BadArgsValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(109, 49870, 49916);
return return_v;
}


int
f_109_49847_49917(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 49847, 49917);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(109,48613,50151);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,48613,50151);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool _socketServerMode;

private bool _serverMode;

private bool _namedPipeServerMode;

private bool _sshServerMode;

private bool _showVersion;

private string _configurationName;

private PSHostUserInterface _hostUI;

private bool _showHelp;

private bool _showExtendedHelp;

private bool _showBanner ;

private bool _noInteractive;

private string _bannerText;

private string _helpText;

private bool _abortStartup;

private bool _skipUserInit;

private string _customPipeName;

private bool? _staMode ;

private bool _noExit ;

private bool _explicitReadCommandsFromStdin;

private bool _noPrompt;

private string _commandLineCommand;

private bool _wasCommandEncoded;

private uint _exitCode ;

private bool _dirty;

private Serialization.DataFormat _outFormat ;

private bool _outputFormatSpecified ;

private Serialization.DataFormat _inFormat ;

private Collection<CommandParameter> _collectedArgs ;

private string _file;

private string _executionPolicy;

private string _workingDirectory;

private bool _removeWorkingDirectoryTrailingCharacter ;

static CommandLineParameterParser()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(109,5531,51663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,5607,5635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,5664,5692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(109,5730,6345);
validParameters = new string[]{
            "sta",
            "mta",
            "command",
            "configurationname",
            "custompipename",
            "encodedcommand",
            "executionpolicy",
            "file",
            "help",
            "inputformat",
            "login",
            "noexit",
            "nologo",
            "noninteractive",
            "noprofile",
            "outputformat",
            "removeworkingdirectorytrailingcharacter",
            "settingsfile",
            "version",
            "windowstyle",
            "workingdirectory"
        };DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(109,5531,51663);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(109,5531,51663);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(109,5531,51663);

System.Management.Automation.PSArgumentNullException
f_109_6540_6583(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 6540, 6583);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
f_109_51412_51446()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(109, 51412, 51446);
return return_v;
}

}
}   // namespace

