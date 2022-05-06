// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
internal partial
    class ConsoleHostUserInterface : System.Management.Automation.Host.PSHostUserInterface
{
internal
        void
        ResetProgress()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,620,2042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1016,1029);
            // destroy the data structures representing outstanding progress records
            // take down and destroy the progress display

            // If we have multiple runspaces on the host then any finished pipeline in any runspace will lead to call 'ResetProgress'
            // so we need the lock
            lock (_instanceLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1063,1307) || true) && (_progPaneUpdateTimer != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,1063,1307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1207,1238);

f_115_1207_1237(                    // Stop update a progress pane and destroy timer
                    _progPaneUpdateTimer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1260,1288);

_progPaneUpdateTimer = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(115,1063,1307);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1706,1972) || true) && (_progPane != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,1706,1972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1769,1873);

f_115_1769_1872(_pendingProgress != null, "How can you have a progress pane and no backing data structure?");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1897,1914);

f_115_1897_1913(
                    _progPane);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1936,1953);

_progPane = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(115,1706,1972);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,1992,2016);

_pendingProgress = null;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(115,620,2042);

int
f_115_1207_1237(System.Threading.Timer
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 1207, 1237);
return 0;
}


int
f_115_1769_1872(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 1769, 1872);
return 0;
}


int
f_115_1897_1913(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Hide();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 1897, 1913);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,620,2042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,620,2042);
}
		}

private
        void
        HandleIncomingProgressRecord(Int64 sourceId, ProgressRecord record)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,2269,4055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,2392,2448);

f_115_2392_2447(record != null, "record should not be null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,2464,2698) || true) && (_pendingProgress == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,2464,2698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,2526,2622);

f_115_2526_2621(_progPane == null, "If there is no data struct, there shouldn't be a pane, either.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,2642,2683);

_pendingProgress = f_115_2661_2682();
DynAbs.Tracing.TraceSender.TraceExitCondition(115,2464,2698);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,2714,2756);

f_115_2714_2755(
            _pendingProgress, sourceId, record);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,2772,3575) || true) && (_progPane == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,2772,3575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,3046,3081);

_progPane = f_115_3058_3080(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,3101,3560) || true) && (_progPaneUpdateTimer == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,3101,3560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,3271,3294);

progPaneUpdateFlag = 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,3407,3541);

_progPaneUpdateTimer = f_115_3430_3540(new TimerCallback(ProgressPaneUpdateTimerElapsed), null, UpdateTimerThreshold, UpdateTimerThreshold);
DynAbs.Tracing.TraceSender.TraceExitCondition(115,3101,3560);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(115,2772,3575);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,3591,4044) || true) && (f_115_3595_3652(ref progPaneUpdateFlag, 0, 1)== 1 ||(DynAbs.Tracing.TraceSender.Expression_False(115, 3595, 3710)||f_115_3661_3678(record)== ProgressRecordType.Completed))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,3591,4044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,3996,4029);

f_115_3996_4028(                // Update the progress pane only when the timer set up the update flag or WriteProgress is completed.
                // As a result, we do not block WriteProgress and whole script and eliminate unnecessary console locks and updates.
                _progPane, _pendingProgress);
DynAbs.Tracing.TraceSender.TraceExitCondition(115,3591,4044);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(115,2269,4055);

int
f_115_2392_2447(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2392, 2447);
return 0;
}


int
f_115_2526_2621(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2526, 2621);
return 0;
}


Microsoft.PowerShell.PendingProgress
f_115_2661_2682()
{
var return_v = new Microsoft.PowerShell.PendingProgress();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2661, 2682);
return return_v;
}


int
f_115_2714_2755(Microsoft.PowerShell.PendingProgress
this_param,long
sourceId,System.Management.Automation.ProgressRecord
record)
{
this_param.Update( sourceId, record);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2714, 2755);
return 0;
}


Microsoft.PowerShell.ProgressPane
f_115_3058_3080(Microsoft.PowerShell.ConsoleHostUserInterface
ui)
{
var return_v = new Microsoft.PowerShell.ProgressPane( ui);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3058, 3080);
return return_v;
}


System.Threading.Timer
f_115_3430_3540(System.Threading.TimerCallback
callback,object?
state,int
dueTime,int
period)
{
var return_v = new System.Threading.Timer( callback, state, dueTime, period);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3430, 3540);
return return_v;
}


int
f_115_3595_3652(ref int
location1,int
value,int
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, value, comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3595, 3652);
return return_v;
}


System.Management.Automation.ProgressRecordType
f_115_3661_3678(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.RecordType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 3661, 3678);
return return_v;
}


int
f_115_3996_4028(Microsoft.PowerShell.ProgressPane
this_param,Microsoft.PowerShell.PendingProgress
pendingProgress)
{
this_param.Show( pendingProgress);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3996, 4028);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,2269,4055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,2269,4055);
}
		}

private
        void
        ProgressPaneUpdateTimerElapsed(object sender)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,4201,4371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4302,4360);

f_115_4302_4359(ref progPaneUpdateFlag, 1, 0);
DynAbs.Tracing.TraceSender.TraceExitMethod(115,4201,4371);

int
f_115_4302_4359(ref int
location1,int
value,int
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, value, comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4302, 4359);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,4201,4371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,4201,4371);
}
		}

private
        void
        PreWrite()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,4383,4547);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4449,4536) || true) && (_progPane != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,4449,4536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4504,4521);

f_115_4504_4520(                _progPane);
DynAbs.Tracing.TraceSender.TraceExitCondition(115,4449,4536);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(115,4383,4547);

int
f_115_4504_4520(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Hide();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4504, 4520);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,4383,4547);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,4383,4547);
}
		}

private
        void
        PostWrite()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,4559,4724);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4626,4713) || true) && (_progPane != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,4626,4713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4681,4698);

f_115_4681_4697(                _progPane);
DynAbs.Tracing.TraceSender.TraceExitCondition(115,4626,4713);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(115,4559,4724);

int
f_115_4681_4697(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Show();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4681, 4697);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,4559,4724);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,4559,4724);
}
		}

private
        void
        PostWrite(ReadOnlySpan<char> value, bool newLine)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,4736,5186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4841,4853);

f_115_4841_4852(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4869,5175) || true) && (f_115_4873_4895(_parent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,4869,5175);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,4973,5015);

f_115_4973_5014(                    _parent, value, newLine);
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(115,5052,5160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5110,5141);

_parent.IsTranscribing = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(115,5052,5160);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(115,4869,5175);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(115,4736,5186);

int
f_115_4841_4852(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.PostWrite();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4841, 4852);
return 0;
}


bool
f_115_4873_4895(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.IsTranscribing;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 4873, 4895);
return return_v;
}


int
f_115_4973_5014(Microsoft.PowerShell.ConsoleHost
this_param,System.ReadOnlySpan<char>
text,bool
newLine)
{
this_param.WriteToTranscript( text, newLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4973, 5014);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,4736,5186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,4736,5186);
}
		}

private
        void
        PreRead()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,5198,5361);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5263,5350) || true) && (_progPane != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,5263,5350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5318,5335);

f_115_5318_5334(                _progPane);
DynAbs.Tracing.TraceSender.TraceExitCondition(115,5263,5350);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(115,5198,5361);

int
f_115_5318_5334(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Hide();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 5318, 5334);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,5198,5361);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,5198,5361);
}
		}

private
        void
        PostRead()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,5373,5537);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5439,5526) || true) && (_progPane != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,5439,5526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5494,5511);

f_115_5494_5510(                _progPane);
DynAbs.Tracing.TraceSender.TraceExitCondition(115,5439,5526);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(115,5373,5537);

int
f_115_5494_5510(Microsoft.PowerShell.ProgressPane
this_param)
{
this_param.Show();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 5494, 5510);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,5373,5537);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,5373,5537);
}
		}

private
        void
        PostRead(string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(115,5549,6046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5627,5638);

f_115_5627_5637(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5654,6035) || true) && (f_115_5658_5680(_parent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(115,5654,6035);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5838,5875);

f_115_5838_5874(                    // Reads always terminate with the enter key, so add that.
                    _parent, value);
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(115,5912,6020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(115,5970,6001);

_parent.IsTranscribing = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(115,5912,6020);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(115,5654,6035);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(115,5549,6046);

int
f_115_5627_5637(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.PostRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 5627, 5637);
return 0;
}


bool
f_115_5658_5680(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.IsTranscribing;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 5658, 5680);
return return_v;
}


int
f_115_5838_5874(Microsoft.PowerShell.ConsoleHost
this_param,string
text)
{
this_param.WriteLineToTranscript( (System.ReadOnlySpan<char>)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 5838, 5874);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115,5549,6046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115,5549,6046);
}
		}

private ProgressPane _progPane ;

private PendingProgress _pendingProgress ;

private Timer _progPaneUpdateTimer ;

private const int 
UpdateTimerThreshold = 200
;

private int progPaneUpdateFlag ;
}
}   // namespace

