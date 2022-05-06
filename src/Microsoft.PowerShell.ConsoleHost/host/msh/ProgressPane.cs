// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation.Host;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
internal
    class ProgressPane
{
internal
        ProgressPane(ConsoleHostUserInterface ui)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(125,765,969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,9055,9088);
this._location = f_125_9067_9088(0, 0);DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,9196,9208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,9241,9256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,9298,9304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,9348,9351);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,849,903) || true) && (ui == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,849,903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,865,903);

throw f_125_871_902("ui");
DynAbs.Tracing.TraceSender.TraceExitCondition(125,849,903);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,917,926);

_ui = ui;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,940,958);

_rawui = f_125_949_957(ui);
DynAbs.Tracing.TraceSender.TraceExitConstructor(125,765,969);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(125,765,969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125,765,969);
}
		}

internal
        bool
        IsShowing
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(125,1287,1368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,1323,1353);

return (_savedRegion != null);
DynAbs.Tracing.TraceSender.TraceExitMethod(125,1287,1368);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(125,1221,1379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125,1221,1379);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal
        void
        Show()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(125,1613,4977);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,1676,4966) || true) && (f_125_1680_1690_M(!IsShowing))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,1676,4966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,1875,1926);

BufferCell[,] 
tempProgressRegion = _progressRegion
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,1944,2042) || true) && (tempProgressRegion == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,1944,2042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,2016,2023);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(125,1944,2042);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,2188,2231);

int 
rows = f_125_2199_2230(tempProgressRegion, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,2249,2292);

int 
cols = f_125_2260_2291(tempProgressRegion, 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,2312,2349);

_savedCursor = f_125_2327_2348(_rawui);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,2367,2383);

_location.X = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,3997,4031);

_location = f_125_4009_4030(_rawui);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,4417,4474);

_location.Y = f_125_4431_4473(_location.Y + 2, _bufSize.Height);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,4599,4775);

_savedRegion =
f_125_4635_4774(                    _rawui, f_125_4686_4773(_location.X, _location.Y, _location.X + cols - 1, _location.Y + rows - 1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,4895,4951);

f_125_4895_4950(
                // replace the saved region in the screen buffer with our progress display
                _rawui, _location, tempProgressRegion);
DynAbs.Tracing.TraceSender.TraceExitCondition(125,1676,4966);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(125,1613,4977);

bool
f_125_1680_1690_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 1680, 1690);
return return_v;
}


int
f_125_2199_2230(System.Management.Automation.Host.BufferCell[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 2199, 2230);
return return_v;
}


int
f_125_2260_2291(System.Management.Automation.Host.BufferCell[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 2260, 2291);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_125_2327_2348(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.CursorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 2327, 2348);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_125_4009_4030(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.WindowPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 4009, 4030);
return return_v;
}


int
f_125_4431_4473(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 4431, 4473);
return return_v;
}


System.Management.Automation.Host.Rectangle
f_125_4686_4773(int
left,int
top,int
right,int
bottom)
{
var return_v = new System.Management.Automation.Host.Rectangle( left, top, right, bottom);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 4686, 4773);
return return_v;
}


System.Management.Automation.Host.BufferCell[,]
f_125_4635_4774(System.Management.Automation.Host.PSHostRawUserInterface
this_param,System.Management.Automation.Host.Rectangle
rectangle)
{
var return_v = this_param.GetBufferContents( rectangle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 4635, 4774);
return return_v;
}


int
f_125_4895_4950(System.Management.Automation.Host.PSHostRawUserInterface
this_param,System.Management.Automation.Host.Coordinates
origin,System.Management.Automation.Host.BufferCell[,]
contents)
{
this_param.SetBufferContents( origin, contents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 4895, 4950);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(125,1613,4977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125,1613,4977);
}
		}

internal
        void
        Hide()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(125,5211,5923);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,5274,5912) || true) && (f_125_5278_5287())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,5274,5912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,5754,5804);

f_125_5754_5803(                // It would be nice if we knew that the saved region could be kept for the next time Show is called, but alas,
                // we have no way of knowing if the screen buffer has changed since we were hidden.  By "no good way" I mean that
                // detecting a change would be at least as expensive as chucking the savedRegion and rebuilding it.  And it would
                // be very complicated.

                _rawui, _location, _savedRegion);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,5822,5842);

_savedRegion = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,5860,5897);

_rawui.CursorPosition = _savedCursor;
DynAbs.Tracing.TraceSender.TraceExitCondition(125,5274,5912);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(125,5211,5923);

bool
f_125_5278_5287()
{
var return_v = IsShowing;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 5278, 5287);
return return_v;
}


int
f_125_5754_5803(System.Management.Automation.Host.PSHostRawUserInterface
this_param,System.Management.Automation.Host.Coordinates
origin,System.Management.Automation.Host.BufferCell[,]
contents)
{
this_param.SetBufferContents( origin, contents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 5754, 5803);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(125,5211,5923);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125,5211,5923);
}
		}

internal
        void
        Show(PendingProgress pendingProgress)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(125,6251,9023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6345,6416);

f_125_6345_6415(pendingProgress != null, "pendingProgress may not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6432,6461);

_bufSize = f_125_6443_6460(_rawui);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6653,6683);

int 
maxWidth = _bufSize.Width
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6697,6755);

int 
maxHeight = f_125_6713_6754(5, _rawui.WindowSize.Height / 3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6771,6843);

string[] 
contents = f_125_6791_6842(pendingProgress, maxWidth, maxHeight, _rawui)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6857,7046) || true) && (contents == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,6857,7046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6958,6965);

f_125_6958_6964(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,6983,7006);

_progressRegion = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,7024,7031);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(125,6857,7046);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,7164,7284);

BufferCell[,] 
newRegion = f_125_7190_7283(_rawui, contents, f_125_7226_7253(_ui), f_125_7255_7282(_ui))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,7298,7362);

f_125_7298_7361(newRegion != null, "NewBufferCellArray has failed!");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,7378,9012) || true) && (_progressRegion == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,7378,9012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,7497,7525);

_progressRegion = newRegion;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,7543,7550);

f_125_7543_7549(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(125,7378,9012);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,7378,9012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,8376,8594);

bool 
sizeChanged =
(DynAbs.Tracing.TraceSender.Conditional_F1(125, 8420, 8557)||((                        (f_125_8421_8443(newRegion, 0)!= f_125_8447_8475(_progressRegion, 0))
||(DynAbs.Tracing.TraceSender.Expression_False(125, 8420, 8557)||(f_125_8502_8524(newRegion, 1)!= f_125_8528_8556(_progressRegion, 1))
)&&DynAbs.Tracing.TraceSender.Conditional_F2(125, 8581, 8585))||DynAbs.Tracing.TraceSender.Conditional_F3(125, 8588, 8593)))?true :false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,8614,8642);

_progressRegion = newRegion;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,8662,8997) || true) && (sizeChanged)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,8662,8997);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,8719,8812) || true) && (f_125_8723_8732())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,8719,8812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,8782,8789);

f_125_8782_8788(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(125,8719,8812);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,8836,8843);

f_125_8836_8842(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(125,8662,8997);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(125,8662,8997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(125,8925,8978);

f_125_8925_8977(                    _rawui, _location, _progressRegion);
DynAbs.Tracing.TraceSender.TraceExitCondition(125,8662,8997);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(125,7378,9012);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(125,6251,9023);

int
f_125_6345_6415(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 6345, 6415);
return 0;
}


System.Management.Automation.Host.Size
f_125_6443_6460(System.Management.Automation.Host.PSHostRawUserInterface
this_param)
{
var return_v = this_param.BufferSize;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 6443, 6460);
return return_v;
}


int
f_125_6713_6754(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 6713, 6754);
return return_v;
}


string[]
f_125_6791_6842(Microsoft.PowerShell.PendingProgress
this_param,int
maxWidth,int
maxHeight,System.Management.Automation.Host.PSHostRawUserInterface
rawUI)
{
var return_v = this_param.Render( maxWidth, maxHeight, rawUI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 6791, 6842);
return return_v;
}


int
f_125_6958_6964(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Hide();
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 6958, 6964);
return 0;
}


System.ConsoleColor
f_125_7226_7253(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
var return_v = this_param.ProgressForegroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 7226, 7253);
return return_v;
}


System.ConsoleColor
f_125_7255_7282(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
var return_v = this_param.ProgressBackgroundColor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 7255, 7282);
return return_v;
}


System.Management.Automation.Host.BufferCell[,]
f_125_7190_7283(System.Management.Automation.Host.PSHostRawUserInterface
this_param,string[]
contents,System.ConsoleColor
foregroundColor,System.ConsoleColor
backgroundColor)
{
var return_v = this_param.NewBufferCellArray( contents, foregroundColor, backgroundColor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 7190, 7283);
return return_v;
}


int
f_125_7298_7361(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 7298, 7361);
return 0;
}


int
f_125_7543_7549(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Show();
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 7543, 7549);
return 0;
}


int
f_125_8421_8443(System.Management.Automation.Host.BufferCell[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 8421, 8443);
return return_v;
}


int
f_125_8447_8475(System.Management.Automation.Host.BufferCell[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 8447, 8475);
return return_v;
}


int
f_125_8502_8524(System.Management.Automation.Host.BufferCell[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 8502, 8524);
return return_v;
}


int
f_125_8528_8556(System.Management.Automation.Host.BufferCell[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 8528, 8556);
return return_v;
}


bool
f_125_8723_8732()
{
var return_v = IsShowing;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 8723, 8732);
return return_v;
}


int
f_125_8782_8788(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Hide();
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 8782, 8788);
return 0;
}


int
f_125_8836_8842(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Show();
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 8836, 8842);
return 0;
}


int
f_125_8925_8977(System.Management.Automation.Host.PSHostRawUserInterface
this_param,System.Management.Automation.Host.Coordinates
origin,System.Management.Automation.Host.BufferCell[,]
contents)
{
this_param.SetBufferContents( origin, contents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 8925, 8977);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(125,6251,9023);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125,6251,9023);
}
		}

private Coordinates _location ;

private Coordinates _savedCursor;

private Size _bufSize;

private BufferCell[,] _savedRegion;

private BufferCell[,] _progressRegion;

private PSHostRawUserInterface _rawui;

private ConsoleHostUserInterface _ui;

static ProgressPane()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(125,467,9359);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(125,467,9359);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(125,467,9359);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(125,467,9359);

System.ArgumentNullException
f_125_871_902(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 871, 902);
return return_v;
}


System.Management.Automation.Host.PSHostRawUserInterface
f_125_949_957(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
var return_v = this_param.RawUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(125, 949, 957);
return return_v;
}


System.Management.Automation.Host.Coordinates
f_125_9067_9088(int
x,int
y)
{
var return_v = new System.Management.Automation.Host.Coordinates( x, y);
DynAbs.Tracing.TraceSender.TraceEndInvocation(125, 9067, 9088);
return return_v;
}

}
}   // namespace

