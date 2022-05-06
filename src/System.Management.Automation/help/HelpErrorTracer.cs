// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Management.Automation
{
internal class HelpErrorTracer
{internal sealed class TraceFrame : IDisposable
{
private string _helpFile ;

private Collection<ErrorRecord> _errors ;

private HelpErrorTracer _helpTracer;

internal TraceFrame(HelpErrorTracer helpTracer, string helpFile)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1152,2945,3121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,2458,2482);
this._helpFile = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,2605,2644);
this._errors = f_1152_2615_2644();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,2685,2696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,3042,3067);

_helpTracer = helpTracer;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,3085,3106);

_helpFile = helpFile;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1152,2945,3121);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,2945,3121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,2945,3121);
}
		}

internal void TraceError(ErrorRecord errorRecord)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,3377,3566);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,3459,3551) || true) && (f_1152_3463_3503(f_1152_3463_3485(_helpTracer)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,3459,3551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,3526,3551);

f_1152_3526_3550(                    _errors, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,3459,3551);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,3377,3566);

System.Management.Automation.HelpSystem
f_1152_3463_3485(System.Management.Automation.HelpErrorTracer
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 3463, 3485);
return return_v;
}


bool
f_1152_3463_3503(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.VerboseHelpErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 3463, 3503);
return return_v;
}


int
f_1152_3526_3550(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 3526, 3550);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,3377,3566);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,3377,3566);
}
		}

internal void TraceErrors(Collection<ErrorRecord> errorRecords)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,3825,4187);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,3921,4172) || true) && (f_1152_3925_3965(f_1152_3925_3947(_helpTracer)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,3921,4172);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,4007,4153);
foreach(ErrorRecord errorRecord in f_1152_4043_4055_I(errorRecords) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,4007,4153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,4105,4130);

f_1152_4105_4129(                        _errors, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,4007,4153);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1152,1,147);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1152,1,147);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1152,3921,4172);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,3825,4187);

System.Management.Automation.HelpSystem
f_1152_3925_3947(System.Management.Automation.HelpErrorTracer
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 3925, 3947);
return return_v;
}


bool
f_1152_3925_3965(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.VerboseHelpErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 3925, 3965);
return return_v;
}


int
f_1152_4105_4129(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 4105, 4129);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1152_4043_4055_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 4043, 4055);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,3825,4187);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,3825,4187);
}
		}

public void Dispose()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,4406,5208);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,4460,5146) || true) && (f_1152_4464_4504(f_1152_4464_4486(_helpTracer))&&(DynAbs.Tracing.TraceSender.Expression_True(1152, 4464, 4525)&&f_1152_4508_4521(_errors)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,4460,5146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,4567,4718);

ErrorRecord 
errorRecord = f_1152_4593_4717(f_1152_4609_4666("Help Load Error"), "HelpLoadError", ErrorCategory.SyntaxError, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,4740,4875);

errorRecord.ErrorDetails = f_1152_4767_4874(f_1152_4784_4816(typeof(HelpErrorTracer)), "HelpErrors", "HelpLoadError", _helpFile, f_1152_4860_4873(_errors));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,4897,4948);

f_1152_4897_4947(f_1152_4897_4930(f_1152_4897_4919(_helpTracer)), errorRecord);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,4972,5127);
foreach(ErrorRecord error in f_1152_5002_5009_I(_errors) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,4972,5127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,5059,5104);

f_1152_5059_5103(f_1152_5059_5092(f_1152_5059_5081(_helpTracer)), error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,4972,5127);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1152,1,156);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1152,1,156);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1152,4460,5146);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,5166,5193);

f_1152_5166_5192(
                _helpTracer, this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,4406,5208);

System.Management.Automation.HelpSystem
f_1152_4464_4486(System.Management.Automation.HelpErrorTracer
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 4464, 4486);
return return_v;
}


bool
f_1152_4464_4504(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.VerboseHelpErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 4464, 4504);
return return_v;
}


int
f_1152_4508_4521(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 4508, 4521);
return return_v;
}


System.Management.Automation.ParentContainsErrorRecordException
f_1152_4609_4666(string
message)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 4609, 4666);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1152_4593_4717(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 4593, 4717);
return return_v;
}


System.Reflection.Assembly
f_1152_4784_4816(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 4784, 4816);
return return_v;
}


int
f_1152_4860_4873(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 4860, 4873);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1152_4767_4874(System.Reflection.Assembly
assembly,string
baseName,string
resourceId,params object[]
args)
{
var return_v = new System.Management.Automation.ErrorDetails( assembly, baseName, resourceId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 4767, 4874);
return return_v;
}


System.Management.Automation.HelpSystem
f_1152_4897_4919(System.Management.Automation.HelpErrorTracer
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 4897, 4919);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1152_4897_4930(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 4897, 4930);
return return_v;
}


int
f_1152_4897_4947(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 4897, 4947);
return 0;
}


System.Management.Automation.HelpSystem
f_1152_5059_5081(System.Management.Automation.HelpErrorTracer
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 5059, 5081);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1152_5059_5092(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 5059, 5092);
return return_v;
}


int
f_1152_5059_5103(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 5059, 5103);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1152_5002_5009_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 5002, 5009);
return return_v;
}


int
f_1152_5166_5192(System.Management.Automation.HelpErrorTracer
this_param,System.Management.Automation.HelpErrorTracer.TraceFrame
traceFrame)
{
this_param.PopFrame( traceFrame);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 5166, 5192);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,4406,5208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,4406,5208);
}
		}

static TraceFrame()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1152,2317,5219);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1152,2317,5219);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,2317,5219);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1152,2317,5219);

System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1152_2615_2644()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 2615, 2644);
return return_v;
}

}

internal HelpSystem HelpSystem {get; }

internal HelpErrorTracer(HelpSystem helpSystem)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1152,5282,5535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,5231,5270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,5703,5740);
this._traceFrames = f_1152_5718_5740();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,5354,5484) || true) && (helpSystem == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,5354,5484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,5410,5469);

throw f_1152_5416_5468("HelpSystem");
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,5354,5484);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,5500,5524);

HelpSystem = helpSystem;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1152,5282,5535);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,5282,5535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,5282,5535);
}
		}

private readonly List<TraceFrame> _traceFrames ;

internal IDisposable Trace(string helpFile)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,5947,6160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6015,6070);

TraceFrame 
traceFrame = f_1152_6039_6069(this, helpFile)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6086,6115);

f_1152_6086_6114(
            _traceFrames, traceFrame);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6131,6149);

return traceFrame;
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,5947,6160);

System.Management.Automation.HelpErrorTracer.TraceFrame
f_1152_6039_6069(System.Management.Automation.HelpErrorTracer
helpTracer,string
helpFile)
{
var return_v = new System.Management.Automation.HelpErrorTracer.TraceFrame( helpTracer, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 6039, 6069);
return return_v;
}


int
f_1152_6086_6114(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param,System.Management.Automation.HelpErrorTracer.TraceFrame
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 6086, 6114);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,5947,6160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,5947,6160);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void TraceError(ErrorRecord errorRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,6375,6641);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6449,6502) || true) && (f_1152_6453_6471(_traceFrames)<= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,6449,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6495,6502);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,6449,6502);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6518,6579);

TraceFrame 
traceFrame = f_1152_6542_6578(_traceFrames, f_1152_6555_6573(_traceFrames)- 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6595,6630);

f_1152_6595_6629(
            traceFrame, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,6375,6641);

int
f_1152_6453_6471(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 6453, 6471);
return return_v;
}


int
f_1152_6555_6573(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 6555, 6573);
return return_v;
}


System.Management.Automation.HelpErrorTracer.TraceFrame
f_1152_6542_6578(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 6542, 6578);
return return_v;
}


int
f_1152_6595_6629(System.Management.Automation.HelpErrorTracer.TraceFrame
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.TraceError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 6595, 6629);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,6375,6641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,6375,6641);
}
		}

internal void TraceErrors(Collection<ErrorRecord> errorRecords)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,6857,7139);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6945,6998) || true) && (f_1152_6949_6967(_traceFrames)<= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,6945,6998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,6991,6998);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,6945,6998);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7014,7075);

TraceFrame 
traceFrame = f_1152_7038_7074(_traceFrames, f_1152_7051_7069(_traceFrames)- 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7091,7128);

f_1152_7091_7127(
            traceFrame, errorRecords);
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,6857,7139);

int
f_1152_6949_6967(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 6949, 6967);
return return_v;
}


int
f_1152_7051_7069(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7051, 7069);
return return_v;
}


System.Management.Automation.HelpErrorTracer.TraceFrame
f_1152_7038_7074(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7038, 7074);
return return_v;
}


int
f_1152_7091_7127(System.Management.Automation.HelpErrorTracer.TraceFrame
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
errorRecords)
{
this_param.TraceErrors( errorRecords);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 7091, 7127);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,6857,7139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,6857,7139);
}
		}

internal void PopFrame(TraceFrame traceFrame)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,7151,7499);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7221,7274) || true) && (f_1152_7225_7243(_traceFrames)<= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,7221,7274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7267,7274);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,7221,7274);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7290,7350);

TraceFrame 
lastFrame = f_1152_7313_7349(_traceFrames, f_1152_7326_7344(_traceFrames)- 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7366,7488) || true) && (lastFrame == traceFrame)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1152,7366,7488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7427,7473);

f_1152_7427_7472(                _traceFrames, f_1152_7449_7467(_traceFrames)- 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1152,7366,7488);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,7151,7499);

int
f_1152_7225_7243(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7225, 7243);
return return_v;
}


int
f_1152_7326_7344(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7326, 7344);
return return_v;
}


System.Management.Automation.HelpErrorTracer.TraceFrame
f_1152_7313_7349(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7313, 7349);
return return_v;
}


int
f_1152_7449_7467(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7449, 7467);
return return_v;
}


int
f_1152_7427_7472(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 7427, 7472);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,7151,7499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,7151,7499);
}
		}

internal bool IsOn
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1152,7689,7809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1152,7725,7794);

return (f_1152_7733_7751(_traceFrames)> 0 &&(DynAbs.Tracing.TraceSender.Expression_True(1152, 7733, 7792)&&f_1152_7759_7792(f_1152_7759_7774(this))));
DynAbs.Tracing.TraceSender.TraceExitMethod(1152,7689,7809);

int
f_1152_7733_7751(System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7733, 7751);
return return_v;
}


System.Management.Automation.HelpSystem
f_1152_7759_7774(System.Management.Automation.HelpErrorTracer
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7759, 7774);
return return_v;
}


bool
f_1152_7759_7792(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.VerboseHelpErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1152, 7759, 7792);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1152,7646,7820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,7646,7820);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static HelpErrorTracer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1152,1348,7827);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1152,1348,7827);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1152,1348,7827);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1152,1348,7827);

System.Management.Automation.PSArgumentNullException
f_1152_5416_5468(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 5416, 5468);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>
f_1152_5718_5740()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.HelpErrorTracer.TraceFrame>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1152, 5718, 5740);
return return_v;
}

}
}
