// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
internal
    class
    ProgressNode : ProgressRecord
{        /// <summary>
        /// Indicates the various layouts for rendering a particular node.  Each style is progressively less terse.
        /// </summary>

        internal
        enum
        RenderStyle
        {
            Invisible = 0,
            Minimal = 1,
            Compact = 2,

            /// <summary>
            /// Allocate only one line for displaying the StatusDescription or the CurrentOperation,
            /// truncate the rest if the StatusDescription or CurrentOperation doesn't fit in one line.
            /// </summary>
            Full = 3,

            /// <summary>
            /// The node will be displayed the same as Full, plus, the whole StatusDescription and CurrentOperation will be displayed (in multiple lines if needed).
            /// </summary>
            FullPlus = 4,
        };

internal
        ProgressNode(Int64 sourceId, ProgressRecord record)
:base( f_124_1758_1775_C(f_124_1758_1775(record)) ,f_124_1777_1792(record),f_124_1794_1818(record))
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(124,1655,2368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,13598,13606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,14591,14594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,14757,14785);
this.Style = RenderStyle.FullPlus;DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,14939,14947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,1844,1957);

f_124_1844_1956(f_124_1855_1872(record)== ProgressRecordType.Processing, "should only create node for Processing records");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,1973,2021);

this.ParentActivityId = f_124_1997_2020(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,2035,2083);

this.CurrentOperation = f_124_2059_2082(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,2097,2158);

this.PercentComplete = f_124_2120_2157(f_124_2129_2151(record), 100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,2172,2220);

this.SecondsRemaining = f_124_2196_2219(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,2234,2270);

this.RecordType = f_124_2252_2269(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,2284,2318);

this.Style = RenderStyle.FullPlus;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,2332,2357);

this.SourceId = sourceId;
DynAbs.Tracing.TraceSender.TraceExitConstructor(124,1655,2368);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,1655,2368);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,1655,2368);
}
		}

internal
        void
        Render(ArrayList strCollection, int indentation, int maxWidth, PSHostRawUserInterface rawUI)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(124,3174,4522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,3323,3393);

f_124_3323_3392(strCollection != null, "strCollection should not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,3407,3463);

f_124_3407_3462(indentation >= 0, "indentation is negative");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,3477,3578);

f_124_3477_3577(f_124_3488_3503(this)!= ProgressRecordType.Completed, "should never render completed records");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,3594,4511);

switch (Style)
            {

case RenderStyle.FullPlus:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,3594,4511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,3689,3763);

f_124_3689_3762(this, strCollection, indentation, maxWidth, rawUI, isFullPlus: true);
DynAbs.Tracing.TraceSender.TraceBreak(124,3785,3791);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,3594,4511);

case RenderStyle.Full:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,3594,4511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,3853,3928);

f_124_3853_3927(this, strCollection, indentation, maxWidth, rawUI, isFullPlus: false);
DynAbs.Tracing.TraceSender.TraceBreak(124,3950,3956);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,3594,4511);

case RenderStyle.Compact:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,3594,4511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,4021,4080);

f_124_4021_4079(this, strCollection, indentation, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceBreak(124,4102,4108);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,3594,4511);

case RenderStyle.Minimal:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,3594,4511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,4173,4232);

f_124_4173_4231(this, strCollection, indentation, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceBreak(124,4254,4260);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,3594,4511);

case RenderStyle.Invisible:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,3594,4511);
DynAbs.Tracing.TraceSender.TraceBreak(124,4362,4368);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,3594,4511);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,3594,4511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,4416,4468);

f_124_4416_4467(false, "unrecognized RenderStyle value");
DynAbs.Tracing.TraceSender.TraceBreak(124,4490,4496);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,3594,4511);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(124,3174,4522);

int
f_124_3323_3392(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 3323, 3392);
return 0;
}


int
f_124_3407_3462(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 3407, 3462);
return 0;
}


System.Management.Automation.ProgressRecordType
f_124_3488_3503(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.RecordType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 3488, 3503);
return return_v;
}


int
f_124_3477_3577(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 3477, 3577);
return 0;
}


int
f_124_3689_3762(Microsoft.PowerShell.ProgressNode
this_param,System.Collections.ArrayList
strCollection,int
indentation,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUI,bool
isFullPlus)
{
this_param.RenderFull( strCollection, indentation, maxWidth, rawUI, isFullPlus:isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 3689, 3762);
return 0;
}


int
f_124_3853_3927(Microsoft.PowerShell.ProgressNode
this_param,System.Collections.ArrayList
strCollection,int
indentation,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUI,bool
isFullPlus)
{
this_param.RenderFull( strCollection, indentation, maxWidth, rawUI, isFullPlus:isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 3853, 3927);
return 0;
}


int
f_124_4021_4079(Microsoft.PowerShell.ProgressNode
this_param,System.Collections.ArrayList
strCollection,int
indentation,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUI)
{
this_param.RenderCompact( strCollection, indentation, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 4021, 4079);
return 0;
}


int
f_124_4173_4231(Microsoft.PowerShell.ProgressNode
this_param,System.Collections.ArrayList
strCollection,int
indentation,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUI)
{
this_param.RenderMinimal( strCollection, indentation, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 4173, 4231);
return 0;
}


int
f_124_4416_4467(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 4416, 4467);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,3174,4522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,3174,4522);
}
		}

private
        void
        RenderFull(ArrayList strCollection, int indentation, int maxWidth, PSHostRawUserInterface rawUI, bool isFullPlus)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(124,5370,8225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,5539,5587);

string 
indent = f_124_5555_5586(indentation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,5646,5813);

f_124_5646_5812(
            // First line: the activity

            strCollection, f_124_5682_5811(rawUI, f_124_5748_5800(" {0}{1} ", indent, f_124_5786_5799(this)), maxWidth));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,5829,5846);

indentation += 3;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,5860,5901);

indent = f_124_5869_5900(indentation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,5971,6069);

f_124_5971_6068(f_124_5993_6015(this), indent, maxWidth, rawUI, strCollection, isFullPlus);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,6316,7296) || true) && (f_124_6320_6335()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,6316,7296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,6374,6440);

int 
thermoWidth = f_124_6392_6439(3, maxWidth - indentation - 2 - 2 - 5)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,6458,6479);

int 
mercuryWidth = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,6497,6548);

mercuryWidth = f_124_6512_6527()* thermoWidth / 100;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,6566,6850) || true) && (f_124_6570_6585()< 100 &&(DynAbs.Tracing.TraceSender.Expression_True(124, 6570, 6622)&&mercuryWidth == thermoWidth))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,6566,6850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,6816,6831);

--mercuryWidth;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,6566,6850);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,6870,7281);

f_124_6870_7280(
                strCollection, f_124_6910_7279(rawUI, f_124_7005_7243(" {0}[{1}{2}] ", indent, f_124_7136_7165('o', mercuryWidth), f_124_7196_7242(thermoWidth - mercuryWidth)), maxWidth));
DynAbs.Tracing.TraceSender.TraceExitCondition(124,6316,7296);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,7365,7905) || true) && (f_124_7369_7385()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,7365,7905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,7424,7482);

TimeSpan 
span = f_124_7440_7481(0, 0, f_124_7459_7480(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,7502,7890);

f_124_7502_7889(
                strCollection, f_124_7542_7888(rawUI, " "
                        + f_124_7668_7825(f_124_7716_7752(), indent, span)                        + " ", maxWidth));
DynAbs.Tracing.TraceSender.TraceExitCondition(124,7365,7905);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,7984,8214) || true) && (!f_124_7989_8027(f_124_8010_8026()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,7984,8214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8061,8084);

f_124_8061_8083(                strCollection, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8102,8199);

f_124_8102_8198(f_124_8124_8145(this), indent, maxWidth, rawUI, strCollection, isFullPlus);
DynAbs.Tracing.TraceSender.TraceExitCondition(124,7984,8214);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(124,5370,8225);

string
f_124_5555_5586(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 5555, 5586);
return return_v;
}


string
f_124_5786_5799(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.Activity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 5786, 5799);
return return_v;
}


string
f_124_5748_5800(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 5748, 5800);
return return_v;
}


string
f_124_5682_5811(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 5682, 5811);
return return_v;
}


int
f_124_5646_5812(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 5646, 5812);
return return_v;
}


string
f_124_5869_5900(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 5869, 5900);
return return_v;
}


string
f_124_5993_6015(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 5993, 6015);
return return_v;
}


int
f_124_5971_6068(string
description,string
indent,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,System.Collections.ArrayList
strCollection,bool
isFullPlus)
{
RenderFullDescription( description, indent, maxWidth, rawUi, strCollection, isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 5971, 6068);
return 0;
}


int
f_124_6320_6335()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 6320, 6335);
return return_v;
}


int
f_124_6392_6439(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 6392, 6439);
return return_v;
}


int
f_124_6512_6527()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 6512, 6527);
return return_v;
}


int
f_124_6570_6585()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 6570, 6585);
return return_v;
}


string
f_124_7136_7165(char
c,int
count)
{
var return_v = new string( c, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7136, 7165);
return return_v;
}


string
f_124_7196_7242(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7196, 7242);
return return_v;
}


string
f_124_7005_7243(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7005, 7243);
return return_v;
}


string
f_124_6910_7279(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 6910, 7279);
return return_v;
}


int
f_124_6870_7280(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 6870, 7280);
return return_v;
}


int
f_124_7369_7385()
{
var return_v = SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 7369, 7385);
return return_v;
}


int
f_124_7459_7480(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 7459, 7480);
return return_v;
}


System.TimeSpan
f_124_7440_7481(int
hours,int
minutes,int
seconds)
{
var return_v = new System.TimeSpan( hours, minutes, seconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7440, 7481);
return return_v;
}


string
f_124_7716_7752()
{
var return_v =                             ProgressNodeStrings.SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 7716, 7752);
return return_v;
}


string
f_124_7668_7825(string
formatSpec,string
o1,System.TimeSpan
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7668, 7825);
return return_v;
}


string
f_124_7542_7888(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7542, 7888);
return return_v;
}


int
f_124_7502_7889(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7502, 7889);
return return_v;
}


string
f_124_8010_8026()
{
var return_v = CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 8010, 8026);
return return_v;
}


bool
f_124_7989_8027(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 7989, 8027);
return return_v;
}


int
f_124_8061_8083(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 8061, 8083);
return return_v;
}


string
f_124_8124_8145(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 8124, 8145);
return return_v;
}


int
f_124_8102_8198(string
description,string
indent,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,System.Collections.ArrayList
strCollection,bool
isFullPlus)
{
RenderFullDescription( description, indent, maxWidth, rawUi, strCollection, isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 8102, 8198);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,5370,8225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,5370,8225);
}
		}

private static void RenderFullDescription(string description, string indent, int maxWidth, PSHostRawUserInterface rawUi, ArrayList strCollection, bool isFullPlus)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(124,8237,9093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8424,8499);

string 
oldDescription = f_124_8448_8498(" {0}{1} ", indent, description)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8513,8535);

string 
newDescription
=default(string);
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,8551,9082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8586,8673);

newDescription = f_124_8603_8672(rawUi, oldDescription, maxWidth);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8691,8725);

f_124_8691_8724(                strCollection, newDescription);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8745,9047) || true) && (f_124_8749_8770(oldDescription)== f_124_8774_8795(newDescription))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,8745,9047);
DynAbs.Tracing.TraceSender.TraceBreak(124,8837,8843);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,8745,9047);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,8745,9047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8925,9028);

oldDescription = f_124_8942_9027(" {0}{1}", indent, f_124_8979_9026(oldDescription, f_124_9004_9025(newDescription)));
DynAbs.Tracing.TraceSender.TraceExitCondition(124,8745,9047);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(124,8551,9082);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,8551,9082) || true) && (isFullPlus)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(124,8551,9082);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(124,8551,9082);
}}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(124,8237,9093);

string
f_124_8448_8498(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 8448, 8498);
return return_v;
}


string
f_124_8603_8672(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 8603, 8672);
return return_v;
}


int
f_124_8691_8724(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 8691, 8724);
return return_v;
}


int
f_124_8749_8770(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 8749, 8770);
return return_v;
}


int
f_124_8774_8795(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 8774, 8795);
return return_v;
}


int
f_124_9004_9025(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 9004, 9025);
return return_v;
}


string
f_124_8979_9026(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 8979, 9026);
return return_v;
}


string
f_124_8942_9027(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 8942, 9027);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,8237,9093);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,8237,9093);
}
		}

private
        void
        RenderCompact(ArrayList strCollection, int indentation, int maxWidth, PSHostRawUserInterface rawUI)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(124,9789,11620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,9944,9992);

string 
indent = f_124_9960_9991(indentation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10051,10239);

f_124_10051_10238(
            // First line: the activity

            strCollection, f_124_10087_10237(rawUI, f_124_10174_10226(" {0}{1} ", indent, f_124_10212_10225(this)), maxWidth));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10255,10272);

indentation += 3;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10286,10327);

indent = f_124_10295_10326(indentation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10448,10478);

string 
percent = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10492,10619) || true) && (f_124_10496_10511()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,10492,10619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10550,10604);

percent = f_124_10560_10603("{0}% ", f_124_10587_10602());
DynAbs.Tracing.TraceSender.TraceExitCondition(124,10492,10619);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10635,10667);

string 
secRemain = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10681,10860) || true) && (f_124_10685_10701()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,10681,10860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10740,10793);

TimeSpan 
span = f_124_10756_10792(0, 0, f_124_10775_10791())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10811,10845);

secRemain = span.ToString()+ " ";
DynAbs.Tracing.TraceSender.TraceExitCondition(124,10681,10860);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,10876,11241);

f_124_10876_11240(
            strCollection, f_124_10912_11239(rawUI, f_124_10999_11207(" {0}{1}{2}{3} ", indent, percent, secRemain, f_124_11189_11206()), maxWidth));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,11309,11609) || true) && (!f_124_11314_11352(f_124_11335_11351()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,11309,11609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,11386,11594);

f_124_11386_11593(                strCollection, f_124_11426_11592(rawUI, f_124_11521_11581(" {0}{1} ", indent, f_124_11559_11580(this)), maxWidth));
DynAbs.Tracing.TraceSender.TraceExitCondition(124,11309,11609);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(124,9789,11620);

string
f_124_9960_9991(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 9960, 9991);
return return_v;
}


string
f_124_10212_10225(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.Activity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 10212, 10225);
return return_v;
}


string
f_124_10174_10226(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10174, 10226);
return return_v;
}


string
f_124_10087_10237(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10087, 10237);
return return_v;
}


int
f_124_10051_10238(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10051, 10238);
return return_v;
}


string
f_124_10295_10326(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10295, 10326);
return return_v;
}


int
f_124_10496_10511()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 10496, 10511);
return return_v;
}


int
f_124_10587_10602()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 10587, 10602);
return return_v;
}


string
f_124_10560_10603(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10560, 10603);
return return_v;
}


int
f_124_10685_10701()
{
var return_v = SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 10685, 10701);
return return_v;
}


int
f_124_10775_10791()
{
var return_v = SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 10775, 10791);
return return_v;
}


System.TimeSpan
f_124_10756_10792(int
hours,int
minutes,int
seconds)
{
var return_v = new System.TimeSpan( hours, minutes, seconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10756, 10792);
return return_v;
}


string
f_124_11189_11206()
{
var return_v = StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 11189, 11206);
return return_v;
}


string
f_124_10999_11207(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10999, 11207);
return return_v;
}


string
f_124_10912_11239(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10912, 11239);
return return_v;
}


int
f_124_10876_11240(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 10876, 11240);
return return_v;
}


string
f_124_11335_11351()
{
var return_v = CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 11335, 11351);
return return_v;
}


bool
f_124_11314_11352(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 11314, 11352);
return return_v;
}


string
f_124_11559_11580(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 11559, 11580);
return return_v;
}


string
f_124_11521_11581(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 11521, 11581);
return return_v;
}


string
f_124_11426_11592(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 11426, 11592);
return return_v;
}


int
f_124_11386_11593(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 11386, 11593);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,9789,11620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,9789,11620);
}
		}

private
        void
        RenderMinimal(ArrayList strCollection, int indentation, int maxWidth, PSHostRawUserInterface rawUI)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(124,12316,13440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12471,12519);

string 
indent = f_124_12487_12518(indentation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12597,12627);

string 
percent = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12641,12768) || true) && (f_124_12645_12660()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,12641,12768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12699,12753);

percent = f_124_12709_12752("{0}% ", f_124_12736_12751());
DynAbs.Tracing.TraceSender.TraceExitCondition(124,12641,12768);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12784,12816);

string 
secRemain = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12830,13009) || true) && (f_124_12834_12850()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,12830,13009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12889,12942);

TimeSpan 
span = f_124_12905_12941(0, 0, f_124_12924_12940())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,12960,12994);

secRemain = span.ToString()+ " ";
DynAbs.Tracing.TraceSender.TraceExitCondition(124,12830,13009);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,13025,13429);

f_124_13025_13428(
            strCollection, f_124_13061_13427(rawUI, f_124_13148_13395(" {0}{1} {2}{3}{4} ", indent, f_124_13272_13280(), percent, secRemain, f_124_13377_13394()), maxWidth));
DynAbs.Tracing.TraceSender.TraceExitMethod(124,12316,13440);

string
f_124_12487_12518(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 12487, 12518);
return return_v;
}


int
f_124_12645_12660()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 12645, 12660);
return return_v;
}


int
f_124_12736_12751()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 12736, 12751);
return return_v;
}


string
f_124_12709_12752(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 12709, 12752);
return return_v;
}


int
f_124_12834_12850()
{
var return_v = SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 12834, 12850);
return return_v;
}


int
f_124_12924_12940()
{
var return_v = SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 12924, 12940);
return return_v;
}


System.TimeSpan
f_124_12905_12941(int
hours,int
minutes,int
seconds)
{
var return_v = new System.TimeSpan( hours, minutes, seconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 12905, 12941);
return return_v;
}


string
f_124_13272_13280()
{
var return_v = Activity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 13272, 13280);
return return_v;
}


string
f_124_13377_13394()
{
var return_v = StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 13377, 13394);
return return_v;
}


string
f_124_13148_13395(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 13148, 13395);
return return_v;
}


string
f_124_13061_13427(System.Management.Automation.Host.PSHostRawUserInterface
rawUI,string
toTruncate,int
maxWidthInBufferCells)
{
var return_v = StringUtil.TruncateToBufferCellWidth( rawUI, toTruncate, maxWidthInBufferCells);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 13061, 13427);
return return_v;
}


int
f_124_13025_13428(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 13025, 13428);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,12316,13440);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,12316,13440);
}
		}

internal
        ArrayList
        Children;

internal
        int
        Age;

internal
        RenderStyle
        Style ;

internal
        Int64
        SourceId;

internal int LinesRequiredMethod(PSHostRawUserInterface rawUi, int maxWidth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(124,15145,16101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15246,15347);

f_124_15246_15346(f_124_15257_15272(this)!= ProgressRecordType.Completed, "should never render completed records");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15363,16065);

switch (Style)
            {

case RenderStyle.FullPlus:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,15363,16065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15458,15531);

return f_124_15465_15530(this, rawUi, maxWidth, isFullPlus: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(124,15363,16065);

case RenderStyle.Full:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,15363,16065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15595,15669);

return f_124_15602_15668(this, rawUi, maxWidth, isFullPlus: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(124,15363,16065);

case RenderStyle.Compact:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,15363,16065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15736,15771);

return f_124_15743_15770();
DynAbs.Tracing.TraceSender.TraceExitCondition(124,15363,16065);

case RenderStyle.Minimal:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,15363,16065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15838,15847);

return 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,15363,16065);

case RenderStyle.Invisible:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,15363,16065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15916,15925);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,15363,16065);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(124,15363,16065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,15975,16022);

f_124_15975_16021(false, "Unknown RenderStyle value");
DynAbs.Tracing.TraceSender.TraceBreak(124,16044,16050);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,15363,16065);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,16081,16090);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(124,15145,16101);

System.Management.Automation.ProgressRecordType
f_124_15257_15272(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.RecordType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 15257, 15272);
return return_v;
}


int
f_124_15246_15346(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 15246, 15346);
return 0;
}


int
f_124_15465_15530(Microsoft.PowerShell.ProgressNode
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxWidth,bool
isFullPlus)
{
var return_v = this_param.LinesRequiredInFullStyleMethod( rawUi, maxWidth, isFullPlus:isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 15465, 15530);
return return_v;
}


int
f_124_15602_15668(Microsoft.PowerShell.ProgressNode
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxWidth,bool
isFullPlus)
{
var return_v = this_param.LinesRequiredInFullStyleMethod( rawUi, maxWidth, isFullPlus:isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 15602, 15668);
return return_v;
}


int
f_124_15743_15770()
{
var return_v = LinesRequiredInCompactStyle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 15743, 15770);
return return_v;
}


int
f_124_15975_16021(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 15975, 16021);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,15145,16101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,15145,16101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private int LinesRequiredInFullStyleMethod(PSHostRawUserInterface rawUi, int maxWidth, bool isFullPlus)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(124,16295,18077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,16775,16789);

int 
lines = 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,16942,16977);

var 
indent = f_124_16955_16976(5)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,16991,17018);

var 
temp = f_124_17002_17017()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17034,17367) || true) && (isFullPlus)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,17034,17367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17082,17095);

f_124_17082_17094(                temp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17113,17203);

f_124_17113_17202(f_124_17135_17152(), indent, maxWidth, rawUi, temp, isFullPlus: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17221,17241);

lines += f_124_17230_17240(temp);
DynAbs.Tracing.TraceSender.TraceExitCondition(124,17034,17367);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,17034,17367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17344,17352);

lines++;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,17034,17367);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17383,17464) || true) && (f_124_17387_17402()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,17383,17464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17441,17449);

++lines;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,17383,17464);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17480,17562) || true) && (f_124_17484_17500()>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,17480,17562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17539,17547);

++lines;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,17480,17562);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17578,18037) || true) && (!f_124_17583_17621(f_124_17604_17620()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,17578,18037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17655,18022) || true) && (isFullPlus)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,17655,18022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17711,17722);

lines += 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17744,17757);

f_124_17744_17756(                    temp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17779,17868);

f_124_17779_17867(f_124_17801_17817(), indent, maxWidth, rawUi, temp, isFullPlus: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17890,17910);

lines += f_124_17899_17909(temp);
DynAbs.Tracing.TraceSender.TraceExitCondition(124,17655,18022);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,17655,18022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,17992,18003);

lines += 2;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,17655,18022);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(124,17578,18037);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,18053,18066);

return lines;
DynAbs.Tracing.TraceSender.TraceExitMethod(124,16295,18077);

string
f_124_16955_16976(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 16955, 16976);
return return_v;
}


System.Collections.ArrayList
f_124_17002_17017()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 17002, 17017);
return return_v;
}


int
f_124_17082_17094(System.Collections.ArrayList
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 17082, 17094);
return 0;
}


string
f_124_17135_17152()
{
var return_v = StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 17135, 17152);
return return_v;
}


int
f_124_17113_17202(string
description,string
indent,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,System.Collections.ArrayList
strCollection,bool
isFullPlus)
{
RenderFullDescription( description, indent, maxWidth, rawUi, strCollection, isFullPlus:isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 17113, 17202);
return 0;
}


int
f_124_17230_17240(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 17230, 17240);
return return_v;
}


int
f_124_17387_17402()
{
var return_v = PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 17387, 17402);
return return_v;
}


int
f_124_17484_17500()
{
var return_v = SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 17484, 17500);
return return_v;
}


string
f_124_17604_17620()
{
var return_v = CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 17604, 17620);
return return_v;
}


bool
f_124_17583_17621(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 17583, 17621);
return return_v;
}


int
f_124_17744_17756(System.Collections.ArrayList
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 17744, 17756);
return 0;
}


string
f_124_17801_17817()
{
var return_v = CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 17801, 17817);
return return_v;
}


int
f_124_17779_17867(string
description,string
indent,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,System.Collections.ArrayList
strCollection,bool
isFullPlus)
{
RenderFullDescription( description, indent, maxWidth, rawUi, strCollection, isFullPlus:isFullPlus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 17779, 17867);
return 0;
}


int
f_124_17899_17909(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 17899, 17909);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,16295,18077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,16295,18077);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        int
        LinesRequiredInCompactStyle
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(124,18356,18977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,18785,18799);

int 
lines = 2
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,18817,18929) || true) && (!f_124_18822_18860(f_124_18843_18859()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(124,18817,18929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,18902,18910);

++lines;
DynAbs.Tracing.TraceSender.TraceExitCondition(124,18817,18929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(124,18949,18962);

return lines;
DynAbs.Tracing.TraceSender.TraceExitMethod(124,18356,18977);

string
f_124_18843_18859()
{
var return_v = CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 18843, 18859);
return return_v;
}


bool
f_124_18822_18860(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 18822, 18860);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124,18274,18988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,18274,18988);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static ProgressNode()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(124,615,18995);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(124,615,18995);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124,615,18995);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(124,615,18995);

static int
f_124_1758_1775(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 1758, 1775);
return return_v;
}


static string
f_124_1777_1792(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.Activity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 1777, 1792);
return return_v;
}


static string
f_124_1794_1818(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 1794, 1818);
return return_v;
}


System.Management.Automation.ProgressRecordType
f_124_1855_1872(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.RecordType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 1855, 1872);
return return_v;
}


int
f_124_1844_1956(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 1844, 1956);
return 0;
}


int
f_124_1997_2020(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ParentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 1997, 2020);
return return_v;
}


string
f_124_2059_2082(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 2059, 2082);
return return_v;
}


int
f_124_2129_2151(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 2129, 2151);
return return_v;
}


int
f_124_2120_2157(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 2120, 2157);
return return_v;
}


int
f_124_2196_2219(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 2196, 2219);
return return_v;
}


System.Management.Automation.ProgressRecordType
f_124_2252_2269(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.RecordType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(124, 2252, 2269);
return return_v;
}


static int
f_124_1758_1775_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(124, 1655, 2368);
return return_v;
}

}
}   // namespace

