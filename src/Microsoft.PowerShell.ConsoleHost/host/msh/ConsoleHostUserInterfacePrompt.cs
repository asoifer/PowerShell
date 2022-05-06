// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Security;
using System.Text;

using Dbg = System.Management.Automation.Diagnostics;
using InternalHostUserInterface = System.Management.Automation.Internal.Host.InternalHostUserInterface;

namespace Microsoft.PowerShell
{
internal partial
    class ConsoleHostUserInterface : System.Management.Automation.Host.PSHostUserInterface
{        /// <summary>
        /// Used by Prompt to indicate any common errors when converting the user input string to
        ///  the type of the parameter.
        /// </summary>
        private enum PromptCommonInputErrors
        {
            /// <summary>
            /// No error or not an error prompt handles.
            /// </summary>
            None,
            /// <summary>
            /// Format error.
            /// </summary>
            Format,
            /// <summary>
            /// Overflow error.
            /// </summary>
            Overflow
        }

private static
        bool
        AtLeastOneHelpMessageIsPresent(Collection<FieldDescription> descriptions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(116,1348,1818);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,1484,1778);
foreach(FieldDescription fd in f_116_1516_1528_I(descriptions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,1484,1778);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,1562,1763) || true) && (fd != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,1562,1763);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,1618,1744) || true) && (!f_116_1623_1659(f_116_1644_1658(fd)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,1618,1744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,1709,1721);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,1618,1744);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,1562,1763);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,1484,1778);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(116,1,295);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(116,1,295);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,1794,1807);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(116,1348,1818);

string
f_116_1644_1658(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.HelpMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 1644, 1658);
return return_v;
}


bool
f_116_1623_1659(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 1623, 1659);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
f_116_1516_1528_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 1516, 1528);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116,1348,1818);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116,1348,1818);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override
        Dictionary<string, PSObject>
        Prompt(string caption, string message, Collection<FieldDescription> descriptions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(116,3258,11889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,3474,3503);

f_116_3474_3502(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,3519,3653) || true) && (descriptions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,3519,3653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,3577,3638);

throw f_116_3583_3637("descriptions");
DynAbs.Tracing.TraceSender.TraceExitCondition(116,3519,3653);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,3669,3908) || true) && (f_116_3673_3691(descriptions)< 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,3669,3908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,3729,3893);

throw f_116_3735_3892("descriptions", f_116_3807_3875(), "descriptions");
DynAbs.Tracing.TraceSender.TraceExitCondition(116,3669,3908);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4038,4051);

            // we lock here so that multiple threads won't interleave the various reads and writes here.

            lock (_instanceLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4085,4159);

Dictionary<string, PSObject> 
results = f_116_4124_4158()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4179,4204);

bool 
cancelInput = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4224,4502) || true) && (!f_116_4229_4258(caption))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,4224,4502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4350,4371);

f_116_4350_4370(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4393,4483);

f_116_4393_4482(this, f_116_4412_4423(), f_116_4425_4446(f_116_4425_4430()), f_116_4448_4481(this, caption));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,4224,4502);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4522,4671) || true) && (!f_116_4527_4556(message))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,4522,4671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4598,4652);

f_116_4598_4651(this, f_116_4617_4650(this, message));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,4522,4671);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4691,4889) || true) && (f_116_4695_4739(descriptions))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,4691,4889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4781,4870);

f_116_4781_4869(this, f_116_4800_4868(this, f_116_4825_4867()));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,4691,4889);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4909,4928);

int 
descIndex = -1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,4948,11828);
foreach(FieldDescription desc in f_116_4982_4994_I(descriptions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,4948,11828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5036,5048);

descIndex++;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5070,5402) || true) && (desc == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,5070,5402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5136,5379);

throw f_116_5142_5378("descriptions", f_116_5222_5271(), f_116_5302_5377(f_116_5316_5344(), "descriptions[{0}]", descIndex));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,5070,5402);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5426,5456);

PSObject 
inputPSObject = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5478,5504);

string 
fieldPrompt = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5526,5550);

fieldPrompt = f_116_5540_5549(desc);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5574,5604);

bool 
fieldEchoOnPrompt = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5769,6186) || true) && (f_116_5773_5825(f_116_5794_5824(desc)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,5769,6186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,5875,6016);

string 
paramName =
f_116_5923_6015(f_116_5937_5965(), "descriptions[{0}].AssemblyFullName", descIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6042,6163);

throw f_116_6048_6162(paramName, f_116_6094_6150(), paramName);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,5769,6186);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6210,6272);

Type 
fieldType = f_116_6227_6271(desc)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6294,7012) || true) && (fieldType == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,6294,7012);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6365,6934) || true) && (f_116_6369_6442(f_116_6419_6441(desc)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,6365,6934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6500,6704);

string 
errMsg =
f_116_6549_6703(f_116_6567_6626(), f_116_6665_6674(desc), f_116_6676_6702(desc))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6734,6869);

PromptingException 
e = f_116_6757_6868(errMsg, null, "BadTypeName", ErrorCategory.InvalidType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6899,6907);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,6365,6934);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,6962,6989);

fieldType = typeof(string);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,6294,7012);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7036,11455) || true) && (f_116_7040_7086(fieldType, f_116_7063_7085(typeof(IList)))!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,7036,11455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7207,7245);

ArrayList 
inputList = f_116_7229_7244()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7466,7500);

Type 
elementType = typeof(object)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7526,8609) || true) && (f_116_7530_7547(fieldType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,7526,8609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7605,7646);

elementType = f_116_7619_7645(fieldType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7676,7712);

int 
rank = f_116_7687_7711(fieldType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7905,8582) || true) && (rank <= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,7905,8582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,7984,8086);

string 
msg = f_116_7997_8085(f_116_8015_8073(), f_116_8075_8084(desc))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,8120,8359);

ArgumentException 
innerException = f_116_8155_8358(f_116_8228_8357(f_116_8242_8270(), "descriptions[{0}].AssemblyFullName", descIndex))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,8393,8509);

PromptingException 
e = f_116_8416_8508(msg, innerException, "ZeroRankArray", ErrorCategory.InvalidOperation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,8543,8551);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,7905,8582);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,7526,8609);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,8637,8700);

StringBuilder 
fieldPromptList = f_116_8669_8699(fieldPrompt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,8794,8822);

f_116_8794_8821(                        // fieldPromptList = fieldPrompt + "[i] :"
                        fieldPromptList, "[");
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,8850,9943) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,8850,9943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,8919,9048);

f_116_8919_9047(                            fieldPromptList, f_116_8976_9046(f_116_8990_9018(), "{0}]: ", f_116_9030_9045(inputList)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,9078,9104);

bool 
inputListEnd = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,9134,9161);

object 
convertedObj = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,9191,9421);

string 
inputString = f_116_9212_9420(this, elementType, f_116_9245_9271(fieldPromptList), fieldPrompt, caption, message, desc, fieldEchoOnPrompt, true, out inputListEnd, out cancelInput, out convertedObj)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,9453,9916) || true) && (cancelInput ||(DynAbs.Tracing.TraceSender.Expression_False(116, 9457, 9484)||inputListEnd))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,9453,9916);
DynAbs.Tracing.TraceSender.TraceBreak(116,9550,9556);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,9453,9916);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,9453,9916);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,9622,9916) || true) && (!cancelInput)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,9622,9916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,9704,9732);

f_116_9704_9731(                                inputList, convertedObj);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,9837,9885);

fieldPromptList.Length = f_116_9862_9880(fieldPrompt)+ 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,9622,9916);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,9453,9916);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,8850,9943);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(116,8850,9943);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(116,8850,9943);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,10052,10621) || true) && (!cancelInput)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,10052,10621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,10126,10157);

object 
tryConvertResult = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,10187,10594) || true) && (f_116_10191_10266(inputList, fieldType, out tryConvertResult))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,10187,10594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,10332,10386);

inputPSObject = f_116_10348_10385(tryConvertResult);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,10187,10594);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,10187,10594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,10516,10563);

inputPSObject = f_116_10532_10562(inputList);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,10187,10594);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,10052,10621);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,7036,11455);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,7036,11455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,10719,10878);

string 
printFieldPrompt = f_116_10745_10877(f_116_10763_10834(), fieldPrompt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,10952,10979);

object 
convertedObj = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11005,11024);

bool 
dummy = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11052,11255);

f_116_11052_11254(this, fieldType, printFieldPrompt, fieldPrompt, caption, message, desc, fieldEchoOnPrompt, false, out dummy, out cancelInput, out convertedObj);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11281,11432) || true) && (!cancelInput)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,11281,11432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11355,11405);

inputPSObject = f_116_11371_11404(convertedObj);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,11281,11432);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,7036,11455);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11479,11726) || true) && (cancelInput)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,11479,11726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11544,11582);

f_116_11544_11581(                        s_tracer, "Prompt canceled");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11608,11629);

f_116_11608_11628(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11655,11671);

f_116_11655_11670(                        results);
DynAbs.Tracing.TraceSender.TraceBreak(116,11697,11703);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,11479,11726);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11750,11809);

f_116_11750_11808(
                    results, f_116_11762_11771(desc), f_116_11773_11807(inputPSObject));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,4948,11828);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(116,1,6881);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(116,1,6881);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,11848,11863);

return results;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(116,3258,11889);

int
f_116_3474_3502(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.HandleThrowOnReadAndPrompt();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3474, 3502);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_116_3583_3637(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3583, 3637);
return return_v;
}


int
f_116_3673_3691(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 3673, 3691);
return return_v;
}


string
f_116_3807_3875()
{
var return_v =                     ConsoleHostUserInterfaceStrings.PromptEmptyDescriptionsErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 3807, 3875);
return return_v;
}


System.Management.Automation.PSArgumentException
f_116_3735_3892(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 3735, 3892);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
f_116_4124_4158()
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4124, 4158);
return return_v;
}


bool
f_116_4229_4258(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4229, 4258);
return return_v;
}


int
f_116_4350_4370(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4350, 4370);
return 0;
}


System.ConsoleColor
f_116_4412_4423()
{
var return_v = PromptColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 4412, 4423);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_116_4425_4430()
{
var return_v = RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 4425, 4430);
return return_v;
}


System.ConsoleColor
f_116_4425_4446(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 4425, 4446);
return return_v;
}


string
f_116_4448_4481(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4448, 4481);
return return_v;
}


int
f_116_4393_4482(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor,string
text)
{
this_param.WriteLineToConsole( foregroundColor, backgroundColor, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4393, 4482);
return 0;
}


bool
f_116_4527_4556(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4527, 4556);
return return_v;
}


string
f_116_4617_4650(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4617, 4650);
return return_v;
}


int
f_116_4598_4651(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4598, 4651);
return 0;
}


bool
f_116_4695_4739(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
descriptions)
{
var return_v = AtLeastOneHelpMessageIsPresent( descriptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4695, 4739);
return return_v;
}


string
f_116_4825_4867()
{
var return_v = ConsoleHostUserInterfaceStrings.PromptHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 4825, 4867);
return return_v;
}


string
f_116_4800_4868(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4800, 4868);
return return_v;
}


int
f_116_4781_4869(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4781, 4869);
return 0;
}


string
f_116_5222_5271()
{
var return_v =                             ConsoleHostUserInterfaceStrings.NullErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 5222, 5271);
return return_v;
}


System.Globalization.CultureInfo
f_116_5316_5344()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 5316, 5344);
return return_v;
}


string
f_116_5302_5377(System.Globalization.CultureInfo
provider,string
format,int
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 5302, 5377);
return return_v;
}


System.Management.Automation.PSArgumentException
f_116_5142_5378(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 5142, 5378);
return return_v;
}


string
f_116_5540_5549(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 5540, 5549);
return return_v;
}


string
f_116_5794_5824(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.ParameterAssemblyFullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 5794, 5824);
return return_v;
}


bool
f_116_5773_5825(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 5773, 5825);
return return_v;
}


System.Globalization.CultureInfo
f_116_5937_5965()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 5937, 5965);
return return_v;
}


string
f_116_5923_6015(System.Globalization.CultureInfo
provider,string
format,int
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 5923, 6015);
return return_v;
}


string
f_116_6094_6150()
{
var return_v = ConsoleHostUserInterfaceStrings.NullOrEmptyErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 6094, 6150);
return return_v;
}


System.Management.Automation.PSArgumentException
f_116_6048_6162(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 6048, 6162);
return return_v;
}


System.Type
f_116_6227_6271(System.Management.Automation.Host.FieldDescription
field)
{
var return_v = InternalHostUserInterface.GetFieldType( field);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 6227, 6271);
return return_v;
}


string
f_116_6419_6441(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.ParameterTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 6419, 6441);
return return_v;
}


bool
f_116_6369_6442(string
typeName)
{
var return_v = InternalHostUserInterface.IsSecuritySensitiveType( typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 6369, 6442);
return return_v;
}


string
f_116_6567_6626()
{
var return_v = ConsoleHostUserInterfaceStrings.PromptTypeLoadErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 6567, 6626);
return return_v;
}


string
f_116_6665_6674(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 6665, 6674);
return return_v;
}


string
f_116_6676_6702(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.ParameterTypeFullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 6676, 6702);
return return_v;
}


string
f_116_6549_6703(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 6549, 6703);
return return_v;
}


System.Management.Automation.Host.PromptingException
f_116_6757_6868(string
message,System.Exception
innerException,string
errorId,System.Management.Automation.ErrorCategory
errorCategory)
{
var return_v = new System.Management.Automation.Host.PromptingException( message, innerException, errorId, errorCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 6757, 6868);
return return_v;
}


string
f_116_7063_7085(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 7063, 7085);
return return_v;
}


System.Type?
f_116_7040_7086(System.Type
this_param,string
name)
{
var return_v = this_param.GetInterface( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 7040, 7086);
return return_v;
}


System.Collections.ArrayList
f_116_7229_7244()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 7229, 7244);
return return_v;
}


bool
f_116_7530_7547(System.Type
this_param)
{
var return_v = this_param.IsArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 7530, 7547);
return return_v;
}


System.Type?
f_116_7619_7645(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 7619, 7645);
return return_v;
}


int
f_116_7687_7711(System.Type
this_param)
{
var return_v = this_param.GetArrayRank();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 7687, 7711);
return return_v;
}


string
f_116_8015_8073()
{
var return_v = ConsoleHostUserInterfaceStrings.RankZeroArrayErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 8015, 8073);
return return_v;
}


string
f_116_8075_8084(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 8075, 8084);
return return_v;
}


string
f_116_7997_8085(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 7997, 8085);
return return_v;
}


System.Globalization.CultureInfo
f_116_8242_8270()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 8242, 8270);
return return_v;
}


string
f_116_8228_8357(System.Globalization.CultureInfo
provider,string
format,int
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 8228, 8357);
return return_v;
}


System.Management.Automation.PSArgumentException
f_116_8155_8358(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 8155, 8358);
return return_v;
}


System.Management.Automation.Host.PromptingException
f_116_8416_8508(string
message,System.ArgumentException
innerException,string
errorId,System.Management.Automation.ErrorCategory
errorCategory)
{
var return_v = new System.Management.Automation.Host.PromptingException( message, (System.Exception)innerException, errorId, errorCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 8416, 8508);
return return_v;
}


System.Text.StringBuilder
f_116_8669_8699(string
value)
{
var return_v = new System.Text.StringBuilder( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 8669, 8699);
return return_v;
}


System.Text.StringBuilder
f_116_8794_8821(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 8794, 8821);
return return_v;
}


System.Globalization.CultureInfo
f_116_8990_9018()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 8990, 9018);
return return_v;
}


int
f_116_9030_9045(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 9030, 9045);
return return_v;
}


string
f_116_8976_9046(System.Globalization.CultureInfo
provider,string
format,int
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 8976, 9046);
return return_v;
}


System.Text.StringBuilder
f_116_8919_9047(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 8919, 9047);
return return_v;
}


string
f_116_9245_9271(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 9245, 9271);
return return_v;
}


string
f_116_9212_9420(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Type
fieldType,string
printFieldPrompt,string
fieldPrompt,string
caption,string
message,System.Management.Automation.Host.FieldDescription
desc,bool
fieldEchoOnPrompt,bool
listInput,out bool
endListInput,out bool
cancelInput,out object
convertedObj)
{
var return_v = this_param.PromptForSingleItem( fieldType, printFieldPrompt, fieldPrompt, caption, message, desc, fieldEchoOnPrompt, listInput, out endListInput, out cancelInput, out convertedObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 9212, 9420);
return return_v;
}


int
f_116_9704_9731(System.Collections.ArrayList
this_param,object
value)
{
var return_v = this_param.Add( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 9704, 9731);
return return_v;
}


int
f_116_9862_9880(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 9862, 9880);
return return_v;
}


bool
f_116_10191_10266(System.Collections.ArrayList
valueToConvert,System.Type
resultType,out object
result)
{
var return_v = LanguagePrimitives.TryConvertTo( (object)valueToConvert, resultType, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 10191, 10266);
return return_v;
}


System.Management.Automation.PSObject
f_116_10348_10385(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 10348, 10385);
return return_v;
}


System.Management.Automation.PSObject
f_116_10532_10562(System.Collections.ArrayList
obj)
{
var return_v = PSObject.AsPSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 10532, 10562);
return return_v;
}


string
f_116_10763_10834()
{
var return_v = ConsoleHostUserInterfaceStrings.PromptFieldPromptInputSeparatorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 10763, 10834);
return return_v;
}


string
f_116_10745_10877(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 10745, 10877);
return return_v;
}


string
f_116_11052_11254(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Type
fieldType,string
printFieldPrompt,string
fieldPrompt,string
caption,string
message,System.Management.Automation.Host.FieldDescription
desc,bool
fieldEchoOnPrompt,bool
listInput,out bool
endListInput,out bool
cancelInput,out object
convertedObj)
{
var return_v = this_param.PromptForSingleItem( fieldType, printFieldPrompt, fieldPrompt, caption, message, desc, fieldEchoOnPrompt, listInput, out endListInput, out cancelInput, out convertedObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 11052, 11254);
return return_v;
}


System.Management.Automation.PSObject
f_116_11371_11404(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 11371, 11404);
return return_v;
}


int
f_116_11544_11581(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 11544, 11581);
return 0;
}


int
f_116_11608_11628(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.WriteLineToConsole();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 11608, 11628);
return 0;
}


int
f_116_11655_11670(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 11655, 11670);
return 0;
}


string
f_116_11762_11771(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 11762, 11771);
return return_v;
}


System.Management.Automation.PSObject
f_116_11773_11807(System.Management.Automation.PSObject
obj)
{
var return_v = PSObject.AsPSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 11773, 11807);
return return_v;
}


int
f_116_11750_11808(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
this_param,string
key,System.Management.Automation.PSObject
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 11750, 11808);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
f_116_4982_4994_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 4982, 4994);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116,3258,11889);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116,3258,11889);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string PromptForSingleItem(Type fieldType,
            string printFieldPrompt,
            string fieldPrompt,
            string caption,
            string message,
            FieldDescription desc,
            bool fieldEchoOnPrompt,
            bool listInput,
            out bool endListInput,
            out bool cancelInput,
            out object convertedObj
            )
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(116,11901,14271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12330,12350);

cancelInput = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12364,12385);

endListInput = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12399,12419);

convertedObj = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12435,14232) || true) && (f_116_12439_12477(fieldType, typeof(SecureString)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,12435,14232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12511,12550);

f_116_12511_12549(this, printFieldPrompt, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12568,12621);

SecureString 
secureString = f_116_12596_12620(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12639,12667);

convertedObj = secureString;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12685,12722);

cancelInput = (convertedObj == null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12740,12890) || true) && ((secureString != null) &&(DynAbs.Tracing.TraceSender.Expression_True(116, 12744, 12796)&&(f_116_12771_12790(secureString)== 0) )&&(DynAbs.Tracing.TraceSender.Expression_True(116, 12744, 12809)&&listInput))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,12740,12890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12851,12871);

endListInput = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,12740,12890);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,12435,14232);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,12435,14232);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,12924,14232) || true) && (f_116_12928_12966(fieldType, typeof(PSCredential)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,12924,14232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13000,13058);

f_116_13000_13057(this, f_116_13019_13056(this, fieldPrompt));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13076,13107);

PSCredential 
credential = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13125,13370);

credential =
f_116_13159_13369(this, null, null, null, string.Empty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13388,13414);

convertedObj = credential;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13432,13469);

cancelInput = (convertedObj == null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13487,13642) || true) && ((credential != null) &&(DynAbs.Tracing.TraceSender.Expression_True(116, 13491, 13548)&&(f_116_13516_13542(f_116_13516_13535(credential))== 0) )&&(DynAbs.Tracing.TraceSender.Expression_True(116, 13491, 13561)&&listInput))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,13487,13642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13603,13623);

endListInput = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,13487,13642);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,12924,14232);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,12924,14232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13708,13734);

string 
inputString = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,13752,14180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13795,13965);

inputString = f_116_13809_13964(this, printFieldPrompt, desc, fieldEchoOnPrompt, listInput, out endListInput, out cancelInput);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,13752,14180);
}
                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,13752,14180) || true) && (!cancelInput &&(DynAbs.Tracing.TraceSender.Expression_True(116, 14009, 14038)&&!endListInput )&&(DynAbs.Tracing.TraceSender.Expression_True(116, 14009, 14178)&&f_116_14042_14125(this, fieldType, f_116_14072_14093(desc), inputString, out convertedObj)!=
                    PromptCommonInputErrors.None))
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(116,13752,14180);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(116,13752,14180);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,14198,14217);

return inputString;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,12924,14232);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,12435,14232);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,14248,14260);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(116,11901,14271);

bool
f_116_12439_12477(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 12439, 12477);
return return_v;
}


int
f_116_12511_12549(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 12511, 12549);
return 0;
}


System.Security.SecureString
f_116_12596_12620(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
var return_v = this_param.ReadLineAsSecureString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 12596, 12620);
return return_v;
}


int
f_116_12771_12790(System.Security.SecureString
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 12771, 12790);
return return_v;
}


bool
f_116_12928_12966(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 12928, 12966);
return return_v;
}


string
f_116_13019_13056(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 13019, 13056);
return return_v;
}


int
f_116_13000_13057(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 13000, 13057);
return 0;
}


System.Management.Automation.PSCredential
f_116_13159_13369(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
caption,string
message,string
userName,string
targetName)
{
var return_v = this_param.PromptForCredential( caption, message, userName, targetName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 13159, 13369);
return return_v;
}


System.Security.SecureString
f_116_13516_13535(System.Management.Automation.PSCredential
this_param)
{
var return_v = this_param.Password;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 13516, 13535);
return return_v;
}


int
f_116_13516_13542(System.Security.SecureString
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 13516, 13542);
return return_v;
}


string
f_116_13809_13964(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
fieldPrompt,System.Management.Automation.Host.FieldDescription
desc,bool
fieldEchoOnPrompt,bool
listInput,out bool
endListInput,out bool
cancelled)
{
var return_v = this_param.PromptReadInput( fieldPrompt, desc, fieldEchoOnPrompt, listInput, out endListInput, out cancelled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 13809, 13964);
return return_v;
}


bool
f_116_14072_14093(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.IsFromRemoteHost;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 14072, 14093);
return return_v;
}


Microsoft.PowerShell.ConsoleHostUserInterface.PromptCommonInputErrors
f_116_14042_14125(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,System.Type
fieldType,bool
isFromRemoteHost,string
inputString,out object
convertedObj)
{
var return_v = this_param.PromptTryConvertTo( fieldType, isFromRemoteHost, inputString, out convertedObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 14042, 14125);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116,11901,14271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116,11901,14271);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string PromptReadInput(string fieldPrompt, FieldDescription desc, bool fieldEchoOnPrompt,
                        bool listInput, out bool endListInput, out bool cancelled)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(116,15054,17229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15260,15359);

f_116_15260_15358(fieldPrompt != null, "fieldPrompt should never be null when PromptReadInput is called");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15373,15458);

f_116_15373_15457(desc != null, "desc should never be null when PromptReadInput is called");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15474,15509);

string 
processedInputString = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15523,15544);

endListInput = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15558,15576);

cancelled = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15590,15613);

bool 
inputDone = false
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15627,17174) || true) && (!inputDone)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,15627,17174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15678,15712);

f_116_15678_15711(this, fieldPrompt, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15730,15759);

string 
rawInputString = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15821,16315) || true) && (fieldEchoOnPrompt)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,15821,16315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15884,15912);

rawInputString = f_116_15901_15911(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,15821,16315);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,15821,16315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,15994,16039);

object 
userInput = f_116_16013_16038(this, false, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16061,16106);

string 
userInputString = userInput as string
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16128,16241);

f_116_16128_16240(userInputString != null, "ReadLineSafe did not return a string");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16263,16296);

rawInputString = userInputString;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,15821,16315);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16335,17159) || true) && (rawInputString == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,16335,17159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16495,16512);

cancelled = true;
DynAbs.Tracing.TraceSender.TraceBreak(116,16534,16540);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,16335,17159);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,16335,17159);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16599,17159) || true) && (!f_116_16604_16636(f_116_16625_16635(desc))&&(DynAbs.Tracing.TraceSender.Expression_True(116, 16603, 16712)&&f_116_16640_16712(rawInputString, PromptCommandPrefix, StringComparison.Ordinal)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,16599,17159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16754,16832);

processedInputString = f_116_16777_16831(this, rawInputString, desc, out inputDone);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,16599,17159);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,16599,17159);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,16914,17050) || true) && (f_116_16918_16939(rawInputString)== 0 &&(DynAbs.Tracing.TraceSender.Expression_True(116, 16918, 16957)&&listInput))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,16914,17050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,17007,17027);

endListInput = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,16914,17050);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,17074,17112);

processedInputString = rawInputString;
DynAbs.Tracing.TraceSender.TraceBreak(116,17134,17140);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,16599,17159);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,16335,17159);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,15627,17174);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(116,15627,17174);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(116,15627,17174);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,17190,17218);

return processedInputString;
DynAbs.Tracing.TraceSender.TraceExitMethod(116,15054,17229);

int
f_116_15260_15358(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 15260, 15358);
return 0;
}


int
f_116_15373_15457(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 15373, 15457);
return 0;
}


int
f_116_15678_15711(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
value,bool
transcribeResult)
{
this_param.WriteToConsole( (System.ReadOnlySpan<char>)value, transcribeResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 15678, 15711);
return 0;
}


string
f_116_15901_15911(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
var return_v = this_param.ReadLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 15901, 15911);
return return_v;
}


object
f_116_16013_16038(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,bool
isSecureString,char?
printToken)
{
var return_v = this_param.ReadLineSafe( isSecureString, printToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 16013, 16038);
return return_v;
}


int
f_116_16128_16240(bool
condition,string
whyThisShouldNeverHappen)
{
System.Management.Automation.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 16128, 16240);
return 0;
}


string
f_116_16625_16635(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 16625, 16635);
return return_v;
}


bool
f_116_16604_16636(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 16604, 16636);
return return_v;
}


bool
f_116_16640_16712(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 16640, 16712);
return return_v;
}


string
f_116_16777_16831(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
input,System.Management.Automation.Host.FieldDescription
desc,out bool
inputDone)
{
var return_v = this_param.PromptCommandMode( input, desc, out inputDone);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 16777, 16831);
return return_v;
}


int
f_116_16918_16939(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 16918, 16939);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116,15054,17229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116,15054,17229);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PromptCommonInputErrors PromptTryConvertTo(Type fieldType, bool isFromRemoteHost, string inputString, out object convertedObj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(116,18010,20499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,18169,18267);

f_116_18169_18266(fieldType != null, "fieldType should never be null when PromptTryConvertTo is called");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,18281,18308);

convertedObj = inputString;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,18562,18667) || true) && (isFromRemoteHost)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,18562,18667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,18616,18652);

return PromptCommonInputErrors.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,18562,18667);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,18719,18817);

convertedObj = f_116_18734_18816(inputString, fieldType, f_116_18787_18815());
            }
            catch (PSInvalidCastException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(116,18846,20436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,18911,18947);

Exception 
innerE = f_116_18930_18946(e)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,18965,20421) || true) && (innerE != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,18965,20421);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19025,20342) || true) && (innerE is OverflowException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,19025,20342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19106,19224);

string 
errMsgTemplate =
f_116_19159_19223()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19250,19442);

f_116_19250_19441(this, f_116_19299_19440(this, f_116_19358_19439(f_116_19372_19398(), errMsgTemplate, fieldType, inputString)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19468,19508);

return PromptCommonInputErrors.Overflow;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,19025,20342);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,19025,20342);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19558,20342) || true) && (innerE is FormatException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,19558,20342);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19720,20181) || true) && (f_116_19724_19742(inputString)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,19720,20181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19804,19924);

string 
errMsgTemplate =
f_116_19861_19923()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,19954,20154);

f_116_19954_20153(this, f_116_20007_20152(this, f_116_20070_20151(f_116_20084_20110(), errMsgTemplate, fieldType, inputString)));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,19720,20181);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,20209,20247);

return PromptCommonInputErrors.Format;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,19558,20342);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,19558,20342);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,19558,20342);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,19025,20342);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,18965,20421);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,18965,20421);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,18965,20421);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(116,18846,20436);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,20452,20488);

return PromptCommonInputErrors.None;
DynAbs.Tracing.TraceSender.TraceExitMethod(116,18010,20499);

int
f_116_18169_18266(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 18169, 18266);
return 0;
}


System.Globalization.CultureInfo
f_116_18787_18815()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 18787, 18815);
return return_v;
}


object
f_116_18734_18816(string
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( (object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 18734, 18816);
return return_v;
}


System.Exception
f_116_18930_18946(System.Management.Automation.PSInvalidCastException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 18930, 18946);
return return_v;
}


string
f_116_19159_19223()
{
var return_v =                             ConsoleHostUserInterfaceStrings.PromptParseOverflowErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 19159, 19223);
return return_v;
}


System.Globalization.CultureInfo
f_116_19372_19398()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 19372, 19398);
return return_v;
}


string
f_116_19358_19439(System.Globalization.CultureInfo
provider,string
format,System.Type
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 19358, 19439);
return return_v;
}


string
f_116_19299_19440(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 19299, 19440);
return return_v;
}


int
f_116_19250_19441(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 19250, 19441);
return 0;
}


int
f_116_19724_19742(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 19724, 19742);
return return_v;
}


string
f_116_19861_19923()
{
var return_v =                                 ConsoleHostUserInterfaceStrings.PromptParseFormatErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 19861, 19923);
return return_v;
}


System.Globalization.CultureInfo
f_116_20084_20110()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 20084, 20110);
return return_v;
}


string
f_116_20070_20151(System.Globalization.CultureInfo
provider,string
format,System.Type
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 20070, 20151);
return return_v;
}


string
f_116_20007_20152(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 20007, 20152);
return return_v;
}


int
f_116_19954_20153(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 19954, 20153);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116,18010,20499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116,18010,20499);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string PromptCommandMode(string input, FieldDescription desc, out bool inputDone)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(116,21270,23453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,21384,21601);

f_116_21384_21600(input != null &&(DynAbs.Tracing.TraceSender.Expression_True(116, 21395, 21485)&&f_116_21412_21485(input, PromptCommandPrefix, StringComparison.OrdinalIgnoreCase)), f_116_21504_21599(f_116_21518_21546(), "input should start with {0}", PromptCommandPrefix));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,21615,21702);

f_116_21615_21701(desc != null, "desc should never be null when PromptCommandMode is called");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,21716,21752);

string 
command = f_116_21733_21751(input, 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,21768,21785);

inputDone = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,21799,21942) || true) && (f_116_21803_21878(command, PromptCommandPrefix, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,21799,21942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,21912,21927);

return command;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,21799,21942);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,21958,22872) || true) && (f_116_21962_21976(command)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,21958,22872);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22015,22789) || true) && (f_116_22019_22029(command, 0)== '?')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,22015,22789);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22078,22649) || true) && (f_116_22082_22120(f_116_22103_22119(desc)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,22078,22649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22170,22318);

string 
noHelpErrMsg =
f_116_22221_22317(f_116_22239_22305(), f_116_22307_22316(desc))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22344,22380);

f_116_22344_22379(                        s_tracer, noHelpErrMsg);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22406,22465);

f_116_22406_22464(this, f_116_22425_22463(this, noHelpErrMsg));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,22078,22649);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,22078,22649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22563,22626);

f_116_22563_22625(this, f_116_22582_22624(this, f_116_22607_22623(desc)));
DynAbs.Tracing.TraceSender.TraceExitCondition(116,22078,22649);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,22015,22789);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,22015,22789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22731,22770);

f_116_22731_22769(this, input);
DynAbs.Tracing.TraceSender.TraceExitCondition(116,22015,22789);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22809,22827);

inputDone = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22845,22857);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,21958,22872);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22888,23117) || true) && (f_116_22892_22906(command)== 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,22888,23117);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,22945,23102) || true) && (0 == f_116_22954_23021(command, "\"\"", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,22945,23102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23063,23083);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,22945,23102);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(116,22888,23117);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23133,23442) || true) && (0 == f_116_23142_23210(command, "$null", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,23133,23442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23244,23256);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,23133,23442);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(116,23133,23442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23322,23361);

f_116_23322_23360(this, input);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23379,23397);

inputDone = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23415,23427);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(116,23133,23442);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(116,21270,23453);

bool
f_116_21412_21485(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 21412, 21485);
return return_v;
}


System.Globalization.CultureInfo
f_116_21518_21546()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 21518, 21546);
return return_v;
}


string
f_116_21504_21599(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 21504, 21599);
return return_v;
}


int
f_116_21384_21600(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 21384, 21600);
return 0;
}


int
f_116_21615_21701(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 21615, 21701);
return 0;
}


string
f_116_21733_21751(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 21733, 21751);
return return_v;
}


bool
f_116_21803_21878(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 21803, 21878);
return return_v;
}


int
f_116_21962_21976(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 21962, 21976);
return return_v;
}


char
f_116_22019_22029(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 22019, 22029);
return return_v;
}


string
f_116_22103_22119(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.HelpMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 22103, 22119);
return return_v;
}


bool
f_116_22082_22120(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22082, 22120);
return return_v;
}


string
f_116_22239_22305()
{
var return_v = ConsoleHostUserInterfaceStrings.PromptNoHelpAvailableErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 22239, 22305);
return return_v;
}


string
f_116_22307_22316(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 22307, 22316);
return return_v;
}


string
f_116_22221_22317(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22221, 22317);
return return_v;
}


int
f_116_22344_22379(System.Management.Automation.PSTraceSource
this_param,string
warningMessageFormat,params object[]
args)
{
this_param.TraceWarning( warningMessageFormat, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22344, 22379);
return 0;
}


string
f_116_22425_22463(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22425, 22463);
return return_v;
}


int
f_116_22406_22464(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22406, 22464);
return 0;
}


string
f_116_22607_22623(System.Management.Automation.Host.FieldDescription
this_param)
{
var return_v = this_param.HelpMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 22607, 22623);
return return_v;
}


string
f_116_22582_22624(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22582, 22624);
return return_v;
}


int
f_116_22563_22625(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22563, 22625);
return 0;
}


int
f_116_22731_22769(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
command)
{
this_param.ReportUnrecognizedPromptCommand( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22731, 22769);
return 0;
}


int
f_116_22892_22906(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 22892, 22906);
return return_v;
}


int
f_116_22954_23021(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 22954, 23021);
return return_v;
}


int
f_116_23142_23210(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 23142, 23210);
return return_v;
}


int
f_116_23322_23360(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
command)
{
this_param.ReportUnrecognizedPromptCommand( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 23322, 23360);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116,21270,23453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116,21270,23453);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ReportUnrecognizedPromptCommand(string command)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(116,23465,23737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23550,23662);

string 
msg = f_116_23563_23661(f_116_23581_23651(), command)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(116,23676,23726);

f_116_23676_23725(this, f_116_23695_23724(this, msg));
DynAbs.Tracing.TraceSender.TraceExitMethod(116,23465,23737);

string
f_116_23581_23651()
{
var return_v = ConsoleHostUserInterfaceStrings.PromptUnrecognizedCommandErrorTemplate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(116, 23581, 23651);
return return_v;
}


string
f_116_23563_23661(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 23563, 23661);
return return_v;
}


string
f_116_23695_23724(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
var return_v = this_param.WrapToCurrentWindowWidth( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 23695, 23724);
return return_v;
}


int
f_116_23676_23725(Microsoft.PowerShell.ConsoleHostUserInterface
this_param,string
text)
{
this_param.WriteLineToConsole( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(116, 23676, 23725);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(116,23465,23737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(116,23465,23737);
}
		}

private const string 
PromptCommandPrefix = "!"
;
}
}   // namespace

