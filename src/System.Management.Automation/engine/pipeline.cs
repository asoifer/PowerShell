// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Reflection;
using System.Runtime.ExceptionServices;
using Microsoft.PowerShell.Telemetry;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation.Internal
{
internal class PipelineProcessor : IDisposable
{
private List<CommandProcessorBase> _commands ;

private List<PipelineProcessor> _redirectionPipes;

private PipelineReader<object> _externalInputPipe;

private PipelineWriter _externalSuccessOutput;

private PipelineWriter _externalErrorOutput;

private bool _executionStarted ;

private bool _stopping ;

private SessionStateScope _executionScope;

private ExceptionDispatchInfo _firstTerminatingError ;

private bool _linkedSuccessOutput ;

private bool _linkedErrorOutput ;

private bool _disposed ;

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,2495,2606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2541,2555);

f_1312_2541_2554(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2569,2595);

f_1312_2569_2594(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,2495,2606);

int
f_1312_2541_2554(System.Management.Automation.Internal.PipelineProcessor
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 2541, 2554);
return 0;
}


int
f_1312_2569_2594(System.Management.Automation.Internal.PipelineProcessor
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 2569, 2594);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,2495,2606);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,2495,2606);
}
		}

private void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,2618,3219);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2679,2718) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,2679,2718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2711,2718);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,2679,2718);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2734,3175) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,2734,3175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2781,2799);

f_1312_2781_2798(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2817,2839);

_localPipeline = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2857,2887);

_externalSuccessOutput = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2905,2933);

_externalErrorOutput = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2951,2974);

_executionScope = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2992,3015);

_eventLogBuffer = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,2734,3175);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,3191,3208);

_disposed = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,2618,3219);

int
f_1312_2781_2798(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.DisposeCommands();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 2781, 2798);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,2618,3219);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,2618,3219);
}
		}

        /// <summary>
        /// Finalizer for class PipelineProcessor.
        /// </summary>
        ~PipelineProcessor()
        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,3375,3390);

f_1312_3375_3389(this, false);
        }

private bool _executionFailed ;

internal List<CommandProcessorBase> Commands
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,3600,3625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,3606,3623);

return _commands;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,3600,3625);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,3531,3636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,3531,3636);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool ExecutionFailed
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,3702,3777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,3738,3762);

return _executionFailed;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,3702,3777);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,3648,3880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,3648,3880);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,3793,3869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,3829,3854);

_executionFailed = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,3793,3869);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,3648,3880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,3648,3880);
}
		}}

internal void LogExecutionInfo(InvocationInfo invocationInfo, string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,3892,4193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,3991,4106);

string 
message = f_1312_4008_4105(f_1312_4026_4070(), f_1312_4072_4098(this, invocationInfo), text)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,4120,4182);

f_1312_4120_4181(this, message, invocationInfo, PipelineExecutionStatus.Started);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,3892,4193);

string
f_1312_4026_4070()
{
var return_v = PipelineStrings.PipelineExecutionInformation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 4026, 4070);
return return_v;
}


string
f_1312_4072_4098(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.InvocationInfo
invocationInfo)
{
var return_v = this_param.GetCommand( invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4072, 4098);
return return_v;
}


string
f_1312_4008_4105(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4008, 4105);
return return_v;
}


int
f_1312_4120_4181(System.Management.Automation.Internal.PipelineProcessor
this_param,string
logElement,System.Management.Automation.InvocationInfo
invocation,System.Management.Automation.Internal.PipelineProcessor.PipelineExecutionStatus
pipelineExecutionStatus)
{
this_param.Log( logElement, invocation, pipelineExecutionStatus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4120, 4181);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,3892,4193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,3892,4193);
}
		}

internal void LogExecutionComplete(InvocationInfo invocationInfo, string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,4205,4511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,4308,4423);

string 
message = f_1312_4325_4422(f_1312_4343_4387(), f_1312_4389_4415(this, invocationInfo), text)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,4437,4500);

f_1312_4437_4499(this, message, invocationInfo, PipelineExecutionStatus.Complete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,4205,4511);

string
f_1312_4343_4387()
{
var return_v = PipelineStrings.PipelineExecutionInformation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 4343, 4387);
return return_v;
}


string
f_1312_4389_4415(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.InvocationInfo
invocationInfo)
{
var return_v = this_param.GetCommand( invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4389, 4415);
return return_v;
}


string
f_1312_4325_4422(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4325, 4422);
return return_v;
}


int
f_1312_4437_4499(System.Management.Automation.Internal.PipelineProcessor
this_param,string
logElement,System.Management.Automation.InvocationInfo
invocation,System.Management.Automation.Internal.PipelineProcessor.PipelineExecutionStatus
pipelineExecutionStatus)
{
this_param.Log( logElement, invocation, pipelineExecutionStatus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4437, 4499);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,4205,4511);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,4205,4511);
}
		}

internal void LogPipelineComplete()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,4523,4652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,4583,4641);

f_1312_4583_4640(this, null, null, PipelineExecutionStatus.PipelineComplete);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,4523,4652);

int
f_1312_4583_4640(System.Management.Automation.Internal.PipelineProcessor
this_param,string
logElement,System.Management.Automation.InvocationInfo
invocation,System.Management.Automation.Internal.PipelineProcessor.PipelineExecutionStatus
pipelineExecutionStatus)
{
this_param.Log( logElement, invocation, pipelineExecutionStatus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4583, 4640);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,4523,4652);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,4523,4652);
}
		}

internal void LogExecutionParameterBinding(InvocationInfo invocationInfo, string parameterName, string parameterValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,4664,5048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,4807,4952);

string 
message = f_1312_4824_4951(f_1312_4842_4891(), f_1312_4893_4919(this, invocationInfo), parameterName, parameterValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,4966,5037);

f_1312_4966_5036(this, message, invocationInfo, PipelineExecutionStatus.ParameterBinding);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,4664,5048);

string
f_1312_4842_4891()
{
var return_v = PipelineStrings.PipelineExecutionParameterBinding;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 4842, 4891);
return return_v;
}


string
f_1312_4893_4919(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.InvocationInfo
invocationInfo)
{
var return_v = this_param.GetCommand( invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4893, 4919);
return return_v;
}


string
f_1312_4824_4951(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4824, 4951);
return return_v;
}


int
f_1312_4966_5036(System.Management.Automation.Internal.PipelineProcessor
this_param,string
logElement,System.Management.Automation.InvocationInfo
invocation,System.Management.Automation.Internal.PipelineProcessor.PipelineExecutionStatus
pipelineExecutionStatus)
{
this_param.Log( logElement, invocation, pipelineExecutionStatus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 4966, 5036);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,4664,5048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,4664,5048);
}
		}

internal void LogExecutionError(InvocationInfo invocationInfo, ErrorRecord errorRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,5060,5463);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5172,5221) || true) && (errorRecord == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,5172,5221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5214,5221);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,5172,5221);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5237,5378);

string 
message = f_1312_5254_5377(f_1312_5272_5324(), f_1312_5326_5352(this, invocationInfo), f_1312_5354_5376(errorRecord))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5392,5452);

f_1312_5392_5451(this, message, invocationInfo, PipelineExecutionStatus.Error);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,5060,5463);

string
f_1312_5272_5324()
{
var return_v = PipelineStrings.PipelineExecutionNonTerminatingError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 5272, 5324);
return return_v;
}


string
f_1312_5326_5352(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.InvocationInfo
invocationInfo)
{
var return_v = this_param.GetCommand( invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 5326, 5352);
return return_v;
}


string
f_1312_5354_5376(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 5354, 5376);
return return_v;
}


string
f_1312_5254_5377(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 5254, 5377);
return return_v;
}


int
f_1312_5392_5451(System.Management.Automation.Internal.PipelineProcessor
this_param,string
logElement,System.Management.Automation.InvocationInfo
invocation,System.Management.Automation.Internal.PipelineProcessor.PipelineExecutionStatus
pipelineExecutionStatus)
{
this_param.Log( logElement, invocation, pipelineExecutionStatus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 5392, 5451);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,5060,5463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,5060,5463);
}
		}

private bool _terminatingErrorLogged ;

internal void LogExecutionException(Exception exception)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,5530,6104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5611,5635);

_executionFailed = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5722,5775) || true) && (_terminatingErrorLogged)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,5722,5775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5768,5775);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,5722,5775);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5791,5822);

_terminatingErrorLogged = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5838,5885) || true) && (exception == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,5838,5885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5878,5885);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,5838,5885);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5901,6029);

string 
message = f_1312_5918_6028(f_1312_5936_5985(), f_1312_5987_6008(this, exception), f_1312_6010_6027(exception))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6043,6093);

f_1312_6043_6092(this, message, null, PipelineExecutionStatus.Error);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,5530,6104);

string
f_1312_5936_5985()
{
var return_v = PipelineStrings.PipelineExecutionTerminatingError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 5936, 5985);
return return_v;
}


string
f_1312_5987_6008(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Exception
exception)
{
var return_v = this_param.GetCommand( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 5987, 6008);
return return_v;
}


string
f_1312_6010_6027(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 6010, 6027);
return return_v;
}


string
f_1312_5918_6028(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 5918, 6028);
return return_v;
}


int
f_1312_6043_6092(System.Management.Automation.Internal.PipelineProcessor
this_param,string
logElement,System.Management.Automation.InvocationInfo
invocation,System.Management.Automation.Internal.PipelineProcessor.PipelineExecutionStatus
pipelineExecutionStatus)
{
this_param.Log( logElement, invocation, pipelineExecutionStatus);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 6043, 6092);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,5530,6104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,5530,6104);
}
		}

private string GetCommand(InvocationInfo invocationInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,6116,6447);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6197,6262) || true) && (invocationInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,6197,6262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6242,6262);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,6197,6262);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6278,6400) || true) && (f_1312_6282_6306(invocationInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,6278,6400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6348,6385);

return f_1312_6355_6384(f_1312_6355_6379(invocationInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,6278,6400);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6416,6436);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,6116,6447);

System.Management.Automation.CommandInfo
f_1312_6282_6306(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.MyCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 6282, 6306);
return return_v;
}


System.Management.Automation.CommandInfo
f_1312_6355_6379(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.MyCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 6355, 6379);
return return_v;
}


string
f_1312_6355_6384(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 6355, 6384);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,6116,6447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,6116,6447);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetCommand(Exception exception)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,6459,6767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6530,6592);

IContainsErrorRecord 
icer = exception as IContainsErrorRecord
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6606,6720) || true) && (icer != null &&(DynAbs.Tracing.TraceSender.Expression_True(1312, 6610, 6650)&&f_1312_6626_6642(icer)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,6606,6720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6669,6720);

return f_1312_6676_6719(this, f_1312_6687_6718(f_1312_6687_6703(icer)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,6606,6720);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6736,6756);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,6459,6767);

System.Management.Automation.ErrorRecord
f_1312_6626_6642(System.Management.Automation.IContainsErrorRecord
this_param)
{
var return_v = this_param.ErrorRecord ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 6626, 6642);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1312_6687_6703(System.Management.Automation.IContainsErrorRecord
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 6687, 6703);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_6687_6718(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.InvocationInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 6687, 6718);
return return_v;
}


string
f_1312_6676_6719(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.InvocationInfo
invocationInfo)
{
var return_v = this_param.GetCommand( invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 6676, 6719);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,6459,6767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,6459,6767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void Log(string logElement, InvocationInfo invocation, PipelineExecutionStatus pipelineExecutionStatus)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,6779,8269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,6915,6990);

System.Management.Automation.Host.PSHostUserInterface 
hostInterface = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7004,7170) || true) && (f_1312_7008_7026(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,7004,7170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7068,7155);

hostInterface = f_1312_7084_7154(f_1312_7084_7151(f_1312_7084_7131(f_1312_7084_7111(f_1312_7084_7102(this)))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,7004,7170);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7233,7739) || true) && (hostInterface != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,7233,7739);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7292,7724) || true) && (pipelineExecutionStatus == PipelineExecutionStatus.Complete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,7292,7724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7397,7449);

f_1312_7397_7448(                    hostInterface, invocation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7471,7478);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,7292,7724);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,7292,7724);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7520,7724) || true) && (pipelineExecutionStatus == PipelineExecutionStatus.PipelineComplete)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,7520,7724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7633,7676);

f_1312_7633_7675(                    hostInterface);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7698,7705);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,7520,7724);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,7292,7724);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,7233,7739);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7868,8124) || true) && ((invocation == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 7872, 7933)||f_1312_7896_7933(f_1312_7917_7932(invocation))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,7868,8124);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,7967,8109) || true) && (hostInterface != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,7967,8109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,8034,8090);

f_1312_8034_8089(                    hostInterface, logElement, invocation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,7967,8109);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,7868,8124);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,8140,8258) || true) && (!f_1312_8145_8177(logElement))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,8140,8258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,8211,8243);

f_1312_8211_8242(                _eventLogBuffer, logElement);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,8140,8258);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,6779,8269);

System.Management.Automation.Runspaces.LocalPipeline
f_1312_7008_7026(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.LocalPipeline ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 7008, 7026);
return return_v;
}


System.Management.Automation.Runspaces.LocalPipeline
f_1312_7084_7102(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.LocalPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 7084, 7102);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1312_7084_7111(System.Management.Automation.Runspaces.LocalPipeline
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 7084, 7111);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_7084_7131(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.GetExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 7084, 7131);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_1312_7084_7151(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 7084, 7151);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1312_7084_7154(System.Management.Automation.Internal.Host.InternalHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 7084, 7154);
return return_v;
}


int
f_1312_7397_7448(System.Management.Automation.Host.PSHostUserInterface
this_param,System.Management.Automation.InvocationInfo
invocation)
{
this_param.TranscribeCommandComplete( invocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 7397, 7448);
return 0;
}


int
f_1312_7633_7675(System.Management.Automation.Host.PSHostUserInterface
this_param)
{
this_param.TranscribePipelineComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 7633, 7675);
return 0;
}


string
f_1312_7917_7932(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.Line;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 7917, 7932);
return return_v;
}


bool
f_1312_7896_7933(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 7896, 7933);
return return_v;
}


int
f_1312_8034_8089(System.Management.Automation.Host.PSHostUserInterface
this_param,string
commandText,System.Management.Automation.InvocationInfo
invocation)
{
this_param.TranscribeCommand( commandText, invocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 8034, 8089);
return 0;
}


bool
f_1312_8145_8177(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 8145, 8177);
return return_v;
}


int
f_1312_8211_8242(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 8211, 8242);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,6779,8269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,6779,8269);
}
		}

internal void LogToEventLog()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,8281,8987);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,8335,8976) || true) && (f_1312_8339_8350(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,8335,8976);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,8603,8708) || true) && (_commands == null ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 8607, 8648)||f_1312_8628_8643(_commands)<= 0 )||(DynAbs.Tracing.TraceSender.Expression_False(1312, 8607, 8678)||f_1312_8652_8673(_eventLogBuffer)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,8603,8708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,8701,8708);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,8603,8708);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,8728,8961);

f_1312_8728_8960(f_1312_8767_8795(f_1312_8767_8787(f_1312_8767_8779(_commands, 0))), _eventLogBuffer, f_1312_8926_8959(f_1312_8926_8946(f_1312_8926_8938(_commands, 0))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,8335,8976);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,8281,8987);

bool
f_1312_8339_8350(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.NeedToLog();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 8339, 8350);
return return_v;
}


int
f_1312_8628_8643(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8628, 8643);
return return_v;
}


int
f_1312_8652_8673(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8652, 8673);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_8767_8779(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8767, 8779);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_8767_8787(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8767, 8787);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_8767_8795(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8767, 8795);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_8926_8938(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8926, 8938);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_8926_8946(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8926, 8946);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_8926_8959(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 8926, 8959);
return return_v;
}


int
f_1312_8728_8960(System.Management.Automation.ExecutionContext
executionContext,System.Collections.Generic.List<string>
detail,System.Management.Automation.InvocationInfo
invocationInfo)
{
MshLog.LogPipelineExecutionDetailEvent( executionContext, detail, invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 8728, 8960);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,8281,8987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,8281,8987);
}
		}

private bool NeedToLog()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,8999,9475);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9048,9101) || true) && (_commands == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,9048,9101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9088,9101);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,9048,9101);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9117,9435);
foreach(CommandProcessorBase commandProcessor in f_1312_9167_9176_I(_commands) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,9117,9435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9210,9302);

MshCommandRuntime 
cmdRuntime = f_1312_9241_9265(commandProcessor).commandRuntime as MshCommandRuntime
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9322,9420) || true) && (cmdRuntime != null &&(DynAbs.Tracing.TraceSender.Expression_True(1312, 9326, 9385)&&f_1312_9348_9385(cmdRuntime)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,9322,9420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9408,9420);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,9322,9420);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,9117,9435);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,319);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,319);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9451,9464);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,8999,9475);

System.Management.Automation.Internal.InternalCommand
f_1312_9241_9265(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 9241, 9265);
return return_v;
}


bool
f_1312_9348_9385(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.LogPipelineExecutionDetail;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 9348, 9385);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
f_1312_9167_9176_I(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 9167, 9176);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,8999,9475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,8999,9475);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<string> _eventLogBuffer ;

internal int Add(CommandProcessorBase commandProcessor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,9974,10196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,10054,10111);

f_1312_10054_10085(commandProcessor).PipelineProcessor = this;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,10125,10185);

return f_1312_10132_10184(this, commandProcessor, f_1312_10161_10176(_commands), false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,9974,10196);

System.Management.Automation.MshCommandRuntime
f_1312_10054_10085(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 10054, 10085);
return return_v;
}


int
f_1312_10161_10176(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 10161, 10176);
return return_v;
}


int
f_1312_10132_10184(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.CommandProcessorBase
commandProcessor,int
readFromCommand,bool
readErrorQueue)
{
var return_v = this_param.AddCommand( commandProcessor, readFromCommand, readErrorQueue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 10132, 10184);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,9974,10196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,9974,10196);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void AddRedirectionPipe(PipelineProcessor pipelineProcessor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,10208,10577);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,10302,10399) || true) && (pipelineProcessor == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,10302,10399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,10333,10399);

throw f_1312_10339_10398("pipelineProcessor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,10302,10399);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,10413,10511) || true) && (_redirectionPipes == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,10413,10511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,10461,10511);

_redirectionPipes = f_1312_10481_10510();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,10413,10511);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,10525,10566);

f_1312_10525_10565(            _redirectionPipes, pipelineProcessor);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,10208,10577);

System.Management.Automation.PSArgumentNullException
f_1312_10339_10398(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 10339, 10398);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Internal.PipelineProcessor>
f_1312_10481_10510()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.PipelineProcessor>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 10481, 10510);
return return_v;
}


int
f_1312_10525_10565(System.Collections.Generic.List<System.Management.Automation.Internal.PipelineProcessor>
this_param,System.Management.Automation.Internal.PipelineProcessor
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 10525, 10565);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,10208,10577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,10208,10577);
}
		}

internal int AddCommand(CommandProcessorBase commandProcessor, int readFromCommand, bool readErrorQueue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,11990,16952);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12119,12261) || true) && (commandProcessor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,12119,12261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12181,12246);

throw f_1312_12187_12245("commandProcessor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,12119,12261);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12277,12438) || true) && (_commands == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,12277,12438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12372,12423);

throw f_1312_12378_12422();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,12277,12438);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12454,12584) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,12454,12584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12501,12569);

throw f_1312_12507_12568("PipelineProcessor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,12454,12584);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12600,12782) || true) && (_executionStarted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,12600,12782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12655,12767);

throw f_1312_12661_12766(f_1312_12726_12765());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,12600,12782);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12798,13006) || true) && (f_1312_12802_12841(commandProcessor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,12798,13006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,12875,12991);

throw f_1312_12881_12990(f_1312_12946_12989());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,12798,13006);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,13022,16614) || true) && (0 == f_1312_13031_13046(_commands))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,13022,16614);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,13080,13379) || true) && (0 != readFromCommand)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,13080,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,13204,13360);

throw f_1312_13210_13359("readFromCommand", f_1312_13315_13358());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,13080,13379);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,13399,13446);

commandProcessor.AddedToPipelineAlready = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,13022,16614);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,13022,16614);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,13554,16614) || true) && (readFromCommand > f_1312_13576_13591(_commands)||(DynAbs.Tracing.TraceSender.Expression_False(1312, 13558, 13615)||readFromCommand <= 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,13554,16614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,13694,13835);

throw f_1312_13700_13834("readFromCommand", f_1312_13797_13833());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,13554,16614);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,13554,16614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,13901,14000);

CommandProcessorBase 
prevcommandProcessor = f_1312_13945_13975(_commands, readFromCommand - 1)as CommandProcessorBase
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14018,14299) || true) && (prevcommandProcessor == null ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 14022, 14097)||f_1312_14054_14089(prevcommandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,14018,14299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14229,14280);

throw f_1312_14235_14279();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,14018,14299);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14319,14480);

Pipe 
UpstreamPipe = (DynAbs.Tracing.TraceSender.Conditional_F1(1312, 14339, 14355)||(((readErrorQueue) &&DynAbs.Tracing.TraceSender.Conditional_F2(1312, 14379, 14430))||DynAbs.Tracing.TraceSender.Conditional_F3(1312, 14433, 14479)))?f_1312_14379_14430(f_1312_14379_14414(prevcommandProcessor)):f_1312_14433_14479(f_1312_14433_14468(prevcommandProcessor))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14498,14713) || true) && (UpstreamPipe == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,14498,14713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14643,14694);

throw f_1312_14649_14693();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,14498,14713);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14733,14944) || true) && (f_1312_14737_14766(UpstreamPipe)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,14733,14944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14816,14925);

throw f_1312_14822_14924(f_1312_14891_14923());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,14733,14944);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,14964,15011);

commandProcessor.AddedToPipelineAlready = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15031,15088);

f_1312_15031_15062(commandProcessor).InputPipe = UpstreamPipe;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15106,15155);

UpstreamPipe.DownstreamCmdlet = commandProcessor;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15364,16599) || true) && (f_1312_15368_15434(f_1312_15368_15399(commandProcessor)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,15364,16599);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15485,15490);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15476,16580) || true) && (i < f_1312_15496_15511(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15513,15516)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,15476,16580))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,15476,16580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15566,15602);

prevcommandProcessor = f_1312_15589_15601(_commands, i);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15628,15941) || true) && (prevcommandProcessor == null ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 15632, 15707)||f_1312_15664_15699(prevcommandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,15628,15941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,15863,15914);

throw f_1312_15869_15913();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,15628,15941);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16045,16165) || true) && (f_1312_16049_16117(f_1312_16049_16100(f_1312_16049_16084(prevcommandProcessor)))!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,16045,16165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16156,16165);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,16045,16165);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16191,16309) || true) && (f_1312_16195_16261(f_1312_16195_16246(f_1312_16195_16230(prevcommandProcessor)))!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,16191,16309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16300,16309);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,16191,16309);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16490,16557);

f_1312_16490_16525(prevcommandProcessor).ErrorOutputPipe = UpstreamPipe;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,1105);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,1105);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1312,15364,16599);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,13554,16614);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,13022,16614);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16630,16662);

f_1312_16630_16661(
            _commands, commandProcessor);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16845,16902);

f_1312_16845_16876(commandProcessor).PipelineProcessor = this;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,16918,16941);

return f_1312_16925_16940(_commands);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,11990,16952);

System.Management.Automation.PSArgumentNullException
f_1312_12187_12245(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 12187, 12245);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_12378_12422()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 12378, 12422);
return return_v;
}


System.Management.Automation.PSObjectDisposedException
f_1312_12507_12568(string
objectName)
{
var return_v = PSTraceSource.NewObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 12507, 12568);
return return_v;
}


string
f_1312_12726_12765()
{
var return_v =                     PipelineStrings.ExecutionAlreadyStarted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 12726, 12765);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_12661_12766(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 12661, 12766);
return return_v;
}


bool
f_1312_12802_12841(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.AddedToPipelineAlready;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 12802, 12841);
return return_v;
}


string
f_1312_12946_12989()
{
var return_v =                     PipelineStrings.CommandProcessorAlreadyUsed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 12946, 12989);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_12881_12990(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 12881, 12990);
return return_v;
}


int
f_1312_13031_13046(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 13031, 13046);
return return_v;
}


string
f_1312_13315_13358()
{
var return_v =                         PipelineStrings.FirstCommandCannotHaveInput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 13315, 13358);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1312_13210_13359(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 13210, 13359);
return return_v;
}


int
f_1312_13576_13591(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 13576, 13591);
return return_v;
}


string
f_1312_13797_13833()
{
var return_v =                     PipelineStrings.InvalidCommandNumber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 13797, 13833);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1312_13700_13834(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 13700, 13834);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_13945_13975(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 13945, 13975);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_14054_14089(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 14054, 14089);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_14235_14279()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 14235, 14279);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_14379_14414(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 14379, 14414);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_14379_14430(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.ErrorOutputPipe ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 14379, 14430);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_14433_14468(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 14433, 14468);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_14433_14479(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.OutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 14433, 14479);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_14649_14693()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 14649, 14693);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_14737_14766(System.Management.Automation.Internal.Pipe
this_param)
{
var return_v = this_param.DownstreamCmdlet ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 14737, 14766);
return return_v;
}


string
f_1312_14891_14923()
{
var return_v =                         PipelineStrings.PipeAlreadyTaken;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 14891, 14923);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_14822_14924(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 14822, 14924);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_15031_15062(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 15031, 15062);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_15368_15399(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 15368, 15399);
return return_v;
}


bool
f_1312_15368_15434(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.MergeUnclaimedPreviousErrorResults;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 15368, 15434);
return return_v;
}


int
f_1312_15496_15511(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 15496, 15511);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_15589_15601(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 15589, 15601);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_15664_15699(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 15664, 15699);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_15869_15913()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 15869, 15913);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_16049_16084(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16049, 16084);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_16049_16100(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.ErrorOutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16049, 16100);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_16049_16117(System.Management.Automation.Internal.Pipe
this_param)
{
var return_v = this_param.DownstreamCmdlet ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16049, 16117);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_16195_16230(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16195, 16230);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_16195_16246(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.ErrorOutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16195, 16246);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1312_16195_16261(System.Management.Automation.Internal.Pipe
this_param)
{
var return_v = this_param.ExternalWriter ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16195, 16261);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_16490_16525(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16490, 16525);
return return_v;
}


int
f_1312_16630_16661(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,System.Management.Automation.CommandProcessorBase
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 16630, 16661);
return 0;
}


System.Management.Automation.MshCommandRuntime
f_1312_16845_16876(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16845, 16876);
return return_v;
}


int
f_1312_16925_16940(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 16925, 16940);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,11990,16952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,11990,16952);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Array SynchronousExecuteEnumerate(object input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,19547,24364);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,19628,19726) || true) && (f_1312_19632_19640())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,19628,19726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,19674,19711);

throw f_1312_19680_19710();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,19628,19726);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,19742,19778);

ExceptionDispatchInfo 
toRethrowInfo
=default(ExceptionDispatchInfo);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,19828,19896);

CommandProcessorBase 
commandRequestingUpstreamCommandsToStop = null
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,20237,20274);

f_1312_20237_20273(this, input != f_1312_20252_20272());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,20372,20430);

CommandProcessorBase 
firstCommandProcessor = f_1312_20417_20429(_commands, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,20514,20719) || true) && (f_1312_20518_20531()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,20514,20719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,20589,20696);

f_1312_20589_20635(f_1312_20589_20625(firstCommandProcessor)).ExternalReader
                            = f_1312_20682_20695();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,20514,20719);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,20743,20774);

f_1312_20743_20773(this, input, enumerate: true);
                }
                catch (PipelineStoppedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,20811,21555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,20884,21141);

StopUpstreamCommandsException 
stopUpstreamCommandsException =
(DynAbs.Tracing.TraceSender.Conditional_F1(1312, 20971, 21001)||((                        _firstTerminatingError != null
&&DynAbs.Tracing.TraceSender.Conditional_F2(1312, 21033, 21104))||DynAbs.Tracing.TraceSender.Conditional_F3(1312, 21136, 21140)))?f_1312_21033_21071(_firstTerminatingError)as StopUpstreamCommandsException
:null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,21163,21536) || true) && (stopUpstreamCommandsException == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,21163,21536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,21254,21260);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,21163,21536);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,21163,21536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,21358,21388);

_firstTerminatingError = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,21414,21513);

commandRequestingUpstreamCommandsToStop = f_1312_21456_21512(stopUpstreamCommandsException);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,21163,21536);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,20811,21555);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,21575,21631);

f_1312_21575_21630(this, commandRequestingUpstreamCommandsToStop);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,21952,22235) || true) && (_redirectionPipes != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,21952,22235);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,22023,22216);
foreach(PipelineProcessor redirectPipelineProcessor in f_1312_22079_22096_I(_redirectionPipes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,22023,22216);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,22146,22193);

f_1312_22146_22192(                        redirectPipelineProcessor, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,22023,22216);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,194);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,194);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1312,21952,22235);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,22255,22280);

return f_1312_22262_22279(this);
            }
            catch (RuntimeException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,22309,22750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,22584,22659);

toRethrowInfo = _firstTerminatingError ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.ExceptionServices.ExceptionDispatchInfo>(1312, 22600, 22658)??f_1312_22626_22658(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,22677,22735);

f_1312_22677_22734(                this, f_1312_22704_22733(toRethrowInfo));
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,22309,22750);
            }
            // NTRAID#Windows Out Of Band Releases-929020-2006/03/14-JonN
            catch (System.Runtime.InteropServices.InvalidComObjectException comException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,22839,23787);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23165,23694) || true) && (_firstTerminatingError != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,23165,23694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23241,23280);

toRethrowInfo = _firstTerminatingError;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,23165,23694);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,23165,23694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23362,23460);

string 
message = f_1312_23379_23459(f_1312_23397_23436(), f_1312_23438_23458(comException))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23482,23536);

var 
rte = f_1312_23492_23535(message, comException)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23558,23602);

f_1312_23558_23601(                    rte, "InvalidComObjectException");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23624,23675);

toRethrowInfo = f_1312_23640_23674(rte);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,23165,23694);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23714,23772);

f_1312_23714_23771(
                this, f_1312_23741_23770(toRethrowInfo));
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,22839,23787);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1312,23801,23874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,23841,23859);

f_1312_23841_23858(this);
DynAbs.Tracing.TraceSender.TraceExitFinally(1312,23801,23874);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24199,24276);

f_1312_24199_24275(toRethrowInfo != null, "Alternate protocol path failure");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24290,24312);

f_1312_24290_24311(            toRethrowInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24326,24338);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,19547,24364);

bool
f_1312_19632_19640()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 19632, 19640);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_1312_19680_19710()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 19680, 19710);
return return_v;
}


System.Management.Automation.PSObject
f_1312_20252_20272()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 20252, 20272);
return return_v;
}


int
f_1312_20237_20273(System.Management.Automation.Internal.PipelineProcessor
this_param,bool
incomingStream)
{
this_param.Start( incomingStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 20237, 20273);
return 0;
}


System.Management.Automation.CommandProcessorBase
f_1312_20417_20429(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 20417, 20429);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1312_20518_20531()
{
var return_v = ExternalInput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 20518, 20531);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_20589_20625(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 20589, 20625);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_20589_20635(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.InputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 20589, 20635);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1312_20682_20695()
{
var return_v = ExternalInput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 20682, 20695);
return return_v;
}


int
f_1312_20743_20773(System.Management.Automation.Internal.PipelineProcessor
this_param,object
input,bool
enumerate)
{
this_param.Inject( input, enumerate: enumerate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 20743, 20773);
return 0;
}


System.Exception
f_1312_21033_21071(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 21033, 21071);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_21456_21512(System.Management.Automation.StopUpstreamCommandsException
this_param)
{
var return_v = this_param.RequestingCommandProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 21456, 21512);
return return_v;
}


int
f_1312_21575_21630(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.CommandProcessorBase
commandRequestingUpstreamCommandsToStop)
{
this_param.DoCompleteCore( commandRequestingUpstreamCommandsToStop);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 21575, 21630);
return 0;
}


int
f_1312_22146_22192(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.CommandProcessorBase
commandRequestingUpstreamCommandsToStop)
{
this_param.DoCompleteCore( commandRequestingUpstreamCommandsToStop);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 22146, 22192);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.PipelineProcessor>
f_1312_22079_22096_I(System.Collections.Generic.List<System.Management.Automation.Internal.PipelineProcessor>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 22079, 22096);
return return_v;
}


System.Array
f_1312_22262_22279(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.RetrieveResults();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 22262, 22279);
return return_v;
}


System.Runtime.ExceptionServices.ExceptionDispatchInfo
f_1312_22626_22658(System.Management.Automation.RuntimeException
source)
{
var return_v = ExceptionDispatchInfo.Capture( (System.Exception)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 22626, 22658);
return return_v;
}


System.Exception
f_1312_22704_22733(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 22704, 22733);
return return_v;
}


int
f_1312_22677_22734(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Exception
exception)
{
this_param.LogExecutionException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 22677, 22734);
return 0;
}


string
f_1312_23397_23436()
{
var return_v = ParserStrings.InvalidComObjectException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 23397, 23436);
return return_v;
}


string
f_1312_23438_23458(System.Runtime.InteropServices.InvalidComObjectException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 23438, 23458);
return return_v;
}


string
f_1312_23379_23459(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 23379, 23459);
return return_v;
}


System.Management.Automation.RuntimeException
f_1312_23492_23535(string
message,System.Runtime.InteropServices.InvalidComObjectException
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 23492, 23535);
return return_v;
}


int
f_1312_23558_23601(System.Management.Automation.RuntimeException
this_param,string
errorId)
{
this_param.SetErrorId( errorId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 23558, 23601);
return 0;
}


System.Runtime.ExceptionServices.ExceptionDispatchInfo
f_1312_23640_23674(System.Management.Automation.RuntimeException
source)
{
var return_v = ExceptionDispatchInfo.Capture( (System.Exception)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 23640, 23674);
return return_v;
}


System.Exception
f_1312_23741_23770(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 23741, 23770);
return return_v;
}


int
f_1312_23714_23771(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Exception
exception)
{
this_param.LogExecutionException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 23714, 23771);
return 0;
}


int
f_1312_23841_23858(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.DisposeCommands();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 23841, 23858);
return 0;
}


int
f_1312_24199_24275(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 24199, 24275);
return 0;
}


int
f_1312_24290_24311(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
this_param.Throw();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 24290, 24311);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,19547,24364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,19547,24364);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void DoCompleteCore(CommandProcessorBase commandRequestingUpstreamCommandsToStop)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,24376,28360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24591,24635);

MshCommandRuntime 
lastCommandRuntime = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24651,27561) || true) && (_commands != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,24651,27561);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24715,24720);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24706,27546) || true) && (i < f_1312_24726_24741(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24743,24746)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,24706,27546))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,24706,27546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24788,24841);

CommandProcessorBase 
commandProcessor = f_1312_24828_24840(_commands, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24865,25065) || true) && (commandProcessor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,24865,25065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,24991,25042);

throw f_1312_24997_25041();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,24865,25065);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,25089,25408) || true) && (f_1312_25093_25174(commandRequestingUpstreamCommandsToStop, commandProcessor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,25089,25408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,25224,25271);

commandRequestingUpstreamCommandsToStop = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,25297,25306);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,25089,25408);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,25432,25644) || true) && (commandRequestingUpstreamCommandsToStop != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,25432,25644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,25533,25542);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,25432,25644);
}

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,25720,25750);

f_1312_25720_25749(                        commandProcessor);
                    }
                    catch (PipelineStoppedException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,25795,26599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,25876,26145);

StopUpstreamCommandsException 
stopUpstreamCommandsException =
(DynAbs.Tracing.TraceSender.Conditional_F1(1312, 25967, 25997)||((                            _firstTerminatingError != null
&&DynAbs.Tracing.TraceSender.Conditional_F2(1312, 26033, 26104))||DynAbs.Tracing.TraceSender.Conditional_F3(1312, 26140, 26144)))?f_1312_26033_26071(_firstTerminatingError)as StopUpstreamCommandsException
:null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,26171,26576) || true) && (stopUpstreamCommandsException == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,26171,26576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,26270,26276);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,26171,26576);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,26171,26576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,26390,26420);

_firstTerminatingError = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,26450,26549);

commandRequestingUpstreamCommandsToStop = f_1312_26492_26548(stopUpstreamCommandsException);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,26171,26576);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,25795,26599);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,26623,26686);

f_1312_26623_26685(f_1312_26649_26684(commandProcessor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,26762,26965);

f_1312_26762_26964(f_1312_26820_26852(f_1312_26820_26844(commandProcessor)), CommandState.Stopped, f_1312_26926_26963(f_1312_26926_26950(commandProcessor)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,27135,27450) || true) && (f_1312_27139_27179(f_1312_27139_27167(commandProcessor))!= CommandTypes.Script)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,27135,27450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,27252,27427);

f_1312_27252_27426(f_1312_27252_27301(f_1312_27252_27283(commandProcessor)), f_1312_27353_27390(f_1312_27353_27377(commandProcessor)), f_1312_27392_27425(f_1312_27392_27420(commandProcessor)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,27135,27450);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,27474,27527);

lastCommandRuntime = f_1312_27495_27526(commandProcessor);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,2841);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,2841);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1312,24651,27561);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,27622,28070) || true) && (lastCommandRuntime != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,27622,28070);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,27869,28055) || true) && ((f_1312_27874_27892(this)== null) ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 27873, 27935)||(f_1312_27906_27934_M(!f_1312_27907_27925(this).IsNested))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,27869,28055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,27977,28036);

f_1312_27977_28035(f_1312_27977_28013(lastCommandRuntime));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,27869,28055);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,27622,28070);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28150,28349) || true) && (_firstTerminatingError != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,28150,28349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28218,28285);

f_1312_28218_28284(                this, f_1312_28245_28283(_firstTerminatingError));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28303,28334);

f_1312_28303_28333(                _firstTerminatingError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,28150,28349);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,24376,28360);

int
f_1312_24726_24741(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 24726, 24741);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_24828_24840(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 24828, 24840);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_24997_25041()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 24997, 25041);
return return_v;
}


bool
f_1312_25093_25174(System.Management.Automation.CommandProcessorBase
objA,System.Management.Automation.CommandProcessorBase
objB)
{
var return_v = object.ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 25093, 25174);
return return_v;
}


int
f_1312_25720_25749(System.Management.Automation.CommandProcessorBase
this_param)
{
this_param.DoComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 25720, 25749);
return 0;
}


System.Exception
f_1312_26033_26071(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 26033, 26071);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_26492_26548(System.Management.Automation.StopUpstreamCommandsException
this_param)
{
var return_v = this_param.RequestingCommandProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 26492, 26548);
return return_v;
}


System.Guid
f_1312_26649_26684(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.PipelineActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 26649, 26684);
return return_v;
}


bool
f_1312_26623_26685(System.Guid
activityId)
{
var return_v = EtwActivity.SetActivityId( activityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 26623, 26685);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_26820_26844(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 26820, 26844);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_26820_26852(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 26820, 26852);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_26926_26950(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 26926, 26950);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_26926_26963(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 26926, 26963);
return return_v;
}


int
f_1312_26762_26964(System.Management.Automation.ExecutionContext
executionContext,System.Management.Automation.CommandState
commandState,System.Management.Automation.InvocationInfo
invocationInfo)
{
MshLog.LogCommandLifecycleEvent( executionContext, commandState, invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 26762, 26964);
return 0;
}


System.Management.Automation.CommandInfo
f_1312_27139_27167(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27139, 27167);
return return_v;
}


System.Management.Automation.CommandTypes
f_1312_27139_27179(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27139, 27179);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_27252_27283(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27252, 27283);
return return_v;
}


System.Management.Automation.Internal.PipelineProcessor
f_1312_27252_27301(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.PipelineProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27252, 27301);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_27353_27377(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27353, 27377);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_27353_27390(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27353, 27390);
return return_v;
}


System.Management.Automation.CommandInfo
f_1312_27392_27420(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27392, 27420);
return return_v;
}


string
f_1312_27392_27425(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27392, 27425);
return return_v;
}


int
f_1312_27252_27426(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.InvocationInfo
invocationInfo,string
text)
{
this_param.LogExecutionComplete( invocationInfo, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 27252, 27426);
return 0;
}


System.Management.Automation.MshCommandRuntime
f_1312_27495_27526(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27495, 27526);
return return_v;
}


System.Management.Automation.Runspaces.LocalPipeline
f_1312_27874_27892(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.LocalPipeline ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27874, 27892);
return return_v;
}


System.Management.Automation.Runspaces.LocalPipeline
f_1312_27907_27925(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.LocalPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27907, 27925);
return return_v;
}


bool
f_1312_27906_27934_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27906, 27934);
return return_v;
}


System.Management.Automation.Internal.PipelineProcessor
f_1312_27977_28013(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.PipelineProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 27977, 28013);
return return_v;
}


int
f_1312_27977_28035(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.LogPipelineComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 27977, 28035);
return 0;
}


System.Exception
f_1312_28245_28283(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 28245, 28283);
return return_v;
}


int
f_1312_28218_28284(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Exception
exception)
{
this_param.LogExecutionException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 28218, 28284);
return 0;
}


int
f_1312_28303_28333(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
this_param.Throw();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 28303, 28333);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,24376,28360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,24376,28360);
}
		}

internal Array DoComplete()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,28609,31205);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28661,28759) || true) && (f_1312_28665_28673())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,28661,28759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28707,28744);

throw f_1312_28713_28743();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,28661,28759);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28775,28953) || true) && (!_executionStarted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,28775,28953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28831,28938);

throw f_1312_28837_28937(f_1312_28902_28936());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,28775,28953);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,28969,29005);

ExceptionDispatchInfo 
toRethrowInfo
=default(ExceptionDispatchInfo);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,29055,29076);

f_1312_29055_29075(this, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,29096,29121);

return f_1312_29103_29120(this);
            }
            catch (RuntimeException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,29150,29591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,29425,29500);

toRethrowInfo = _firstTerminatingError ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.ExceptionServices.ExceptionDispatchInfo>(1312, 29441, 29499)??f_1312_29467_29499(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,29518,29576);

f_1312_29518_29575(                this, f_1312_29545_29574(toRethrowInfo));
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,29150,29591);
            }
            // NTRAID#Windows Out Of Band Releases-929020-2006/03/14-JonN
            catch (System.Runtime.InteropServices.InvalidComObjectException comException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,29680,30628);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30006,30535) || true) && (_firstTerminatingError != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,30006,30535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30082,30121);

toRethrowInfo = _firstTerminatingError;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,30006,30535);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,30006,30535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30203,30301);

string 
message = f_1312_30220_30300(f_1312_30238_30277(), f_1312_30279_30299(comException))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30323,30377);

var 
rte = f_1312_30333_30376(message, comException)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30399,30443);

f_1312_30399_30442(                    rte, "InvalidComObjectException");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30465,30516);

toRethrowInfo = f_1312_30481_30515(rte);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,30006,30535);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30555,30613);

f_1312_30555_30612(
                this, f_1312_30582_30611(toRethrowInfo));
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,29680,30628);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1312,30642,30715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,30682,30700);

f_1312_30682_30699(this);
DynAbs.Tracing.TraceSender.TraceExitFinally(1312,30642,30715);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,31040,31117);

f_1312_31040_31116(toRethrowInfo != null, "Alternate protocol path failure");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,31131,31153);

f_1312_31131_31152(            toRethrowInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,31167,31179);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,28609,31205);

bool
f_1312_28665_28673()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 28665, 28673);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_1312_28713_28743()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 28713, 28743);
return return_v;
}


string
f_1312_28902_28936()
{
var return_v =                     PipelineStrings.PipelineNotStarted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 28902, 28936);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_28837_28937(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 28837, 28937);
return return_v;
}


int
f_1312_29055_29075(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.CommandProcessorBase
commandRequestingUpstreamCommandsToStop)
{
this_param.DoCompleteCore( commandRequestingUpstreamCommandsToStop);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 29055, 29075);
return 0;
}


System.Array
f_1312_29103_29120(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.RetrieveResults();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 29103, 29120);
return return_v;
}


System.Runtime.ExceptionServices.ExceptionDispatchInfo
f_1312_29467_29499(System.Management.Automation.RuntimeException
source)
{
var return_v = ExceptionDispatchInfo.Capture( (System.Exception)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 29467, 29499);
return return_v;
}


System.Exception
f_1312_29545_29574(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 29545, 29574);
return return_v;
}


int
f_1312_29518_29575(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Exception
exception)
{
this_param.LogExecutionException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 29518, 29575);
return 0;
}


string
f_1312_30238_30277()
{
var return_v = ParserStrings.InvalidComObjectException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 30238, 30277);
return return_v;
}


string
f_1312_30279_30299(System.Runtime.InteropServices.InvalidComObjectException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 30279, 30299);
return return_v;
}


string
f_1312_30220_30300(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 30220, 30300);
return return_v;
}


System.Management.Automation.RuntimeException
f_1312_30333_30376(string
message,System.Runtime.InteropServices.InvalidComObjectException
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 30333, 30376);
return return_v;
}


int
f_1312_30399_30442(System.Management.Automation.RuntimeException
this_param,string
errorId)
{
this_param.SetErrorId( errorId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 30399, 30442);
return 0;
}


System.Runtime.ExceptionServices.ExceptionDispatchInfo
f_1312_30481_30515(System.Management.Automation.RuntimeException
source)
{
var return_v = ExceptionDispatchInfo.Capture( (System.Exception)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 30481, 30515);
return return_v;
}


System.Exception
f_1312_30582_30611(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 30582, 30611);
return return_v;
}


int
f_1312_30555_30612(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Exception
exception)
{
this_param.LogExecutionException( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 30555, 30612);
return 0;
}


int
f_1312_30682_30699(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.DisposeCommands();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 30682, 30699);
return 0;
}


int
f_1312_31040_31116(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 31040, 31116);
return 0;
}


int
f_1312_31131_31152(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
this_param.Throw();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 31131, 31152);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,28609,31205);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,28609,31205);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void StartStepping(bool expectInput)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,31733,32598);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,31839,31858);

f_1312_31839_31857(this, expectInput);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,31946,32072) || true) && (_firstTerminatingError != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,31946,32072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,32022,32053);

f_1312_32022_32052(                    _firstTerminatingError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,31946,32072);
}
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,32101,32587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,32166,32184);

f_1312_32166_32183(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,32420,32546) || true) && (_firstTerminatingError != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,32420,32546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,32496,32527);

f_1312_32496_32526(                    _firstTerminatingError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,32420,32546);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,32566,32572);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,32101,32587);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,31733,32598);

int
f_1312_31839_31857(System.Management.Automation.Internal.PipelineProcessor
this_param,bool
incomingStream)
{
this_param.Start( incomingStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 31839, 31857);
return 0;
}


int
f_1312_32022_32052(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
this_param.Throw();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 32022, 32052);
return 0;
}


int
f_1312_32166_32183(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.DisposeCommands();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 32166, 32183);
return 0;
}


int
f_1312_32496_32526(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
this_param.Throw();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 32496, 32526);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,31733,32598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,31733,32598);
}
		}

internal void Stop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,32831,34061);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,32987,33069) || true) && (!f_1312_32992_33043(this, f_1312_33006_33036(), null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,32987,33069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33062,33069);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,32987,33069);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33154,33202);

List<CommandProcessorBase> 
commands = _commands
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33216,33262) || true) && (commands == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,33216,33262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33255,33262);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,33216,33262);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33347,33352);

            // Call StopProcessing() for all the commands.
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33338,34050) || true) && (i < f_1312_33358_33372(commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33374,33377)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,33338,34050))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,33338,34050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33411,33463);

CommandProcessorBase 
commandProcessor = f_1312_33451_33462(commands, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33483,33623) || true) && (commandProcessor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,33483,33623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33553,33604);

throw f_1312_33559_33603();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,33483,33623);
}
#pragma warning disable 56500
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33716,33760);

f_1312_33716_33759(f_1312_33716_33740(commandProcessor));
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,33797,34004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,33976,33985);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,33797,34004);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,713);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,713);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1312,32831,34061);

System.Management.Automation.PipelineStoppedException
f_1312_33006_33036()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 33006, 33036);
return return_v;
}


bool
f_1312_32992_33043(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.PipelineStoppedException
e,System.Management.Automation.Internal.InternalCommand
command)
{
var return_v = this_param.RecordFailure( (System.Exception)e, command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 32992, 33043);
return return_v;
}


int
f_1312_33358_33372(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 33358, 33372);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_33451_33462(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 33451, 33462);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_33559_33603()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 33559, 33603);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_33716_33740(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 33716, 33740);
return return_v;
}


int
f_1312_33716_33759(System.Management.Automation.Internal.InternalCommand
this_param)
{
this_param.DoStopProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 33716, 33759);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,32831,34061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,32831,34061);
}
		}

internal Array Step(object input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,35613,36789);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,35671,35769) || true) && (f_1312_35675_35683())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,35671,35769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,35717,35754);

throw f_1312_35723_35753();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,35671,35769);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,35821,35833);

f_1312_35821_35832(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,35851,35883);

f_1312_35851_35882(this, input, enumerate: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,35971,36097) || true) && (_firstTerminatingError != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,35971,36097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36047,36078);

f_1312_36047_36077(                    _firstTerminatingError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,35971,36097);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36117,36142);

return f_1312_36124_36141(this);
            }
            catch (PipelineStoppedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,36171,36657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36236,36254);

f_1312_36236_36253(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36490,36616) || true) && (_firstTerminatingError != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,36490,36616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36566,36597);

f_1312_36566_36596(                    _firstTerminatingError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,36490,36616);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36636,36642);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,36171,36657);
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,36671,36778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36721,36739);

f_1312_36721_36738(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,36757,36763);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,36671,36778);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,35613,36789);

bool
f_1312_35675_35683()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 35675, 35683);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_1312_35723_35753()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 35723, 35753);
return return_v;
}


int
f_1312_35821_35832(System.Management.Automation.Internal.PipelineProcessor
this_param,bool
incomingStream)
{
this_param.Start( incomingStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 35821, 35832);
return 0;
}


int
f_1312_35851_35882(System.Management.Automation.Internal.PipelineProcessor
this_param,object
input,bool
enumerate)
{
this_param.Inject( input, enumerate: enumerate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 35851, 35882);
return 0;
}


int
f_1312_36047_36077(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
this_param.Throw();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 36047, 36077);
return 0;
}


System.Array
f_1312_36124_36141(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
var return_v = this_param.RetrieveResults();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 36124, 36141);
return return_v;
}


int
f_1312_36236_36253(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.DisposeCommands();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 36236, 36253);
return 0;
}


int
f_1312_36566_36596(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
this_param.Throw();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 36566, 36596);
return 0;
}


int
f_1312_36721_36738(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.DisposeCommands();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 36721, 36738);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,35613,36789);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,35613,36789);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void Start(bool incomingStream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,38173,44572);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38311,38441) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,38311,38441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38358,38426);

throw f_1312_38364_38425("PipelineProcessor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,38311,38441);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38457,38555) || true) && (f_1312_38461_38469())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,38457,38555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38503,38540);

throw f_1312_38509_38539();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,38457,38555);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38571,38618) || true) && (_executionStarted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,38571,38618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38611,38618);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,38571,38618);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38634,38857) || true) && (_commands == null ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 38638, 38679)||0 == f_1312_38664_38679(_commands)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,38634,38857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38713,38842);

throw f_1312_38719_38841(f_1312_38784_38840());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,38634,38857);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38873,38931);

CommandProcessorBase 
firstcommandProcessor = f_1312_38918_38930(_commands, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,38945,39221) || true) && (firstcommandProcessor == null
||(DynAbs.Tracing.TraceSender.Expression_False(1312, 38949, 39043)||f_1312_38999_39035(firstcommandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,38945,39221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39077,39206);

throw f_1312_39083_39205(f_1312_39148_39204());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,38945,39221);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39301,39457) || true) && (_executionScope == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,39301,39457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39362,39442);

_executionScope = f_1312_39380_39441(f_1312_39380_39428(f_1312_39380_39409(firstcommandProcessor)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,39301,39457);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39535,39610);

CommandProcessorBase 
LastCommandProcessor = f_1312_39579_39609(_commands, f_1312_39589_39604(_commands)- 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39624,39898) || true) && (LastCommandProcessor == null
||(DynAbs.Tracing.TraceSender.Expression_False(1312, 39628, 39720)||f_1312_39677_39712(LastCommandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,39624,39898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39832,39883);

throw f_1312_39838_39882();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,39624,39898);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39914,40103) || true) && (f_1312_39918_39939()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,39914,40103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,39981,40088);

f_1312_39981_40027(f_1312_39981_40016(LastCommandProcessor)).ExternalWriter
                    = f_1312_40066_40087();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,39914,40103);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,40229,40254);

f_1312_40229_40253(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,40270,40478) || true) && (f_1312_40274_40287()== null &&(DynAbs.Tracing.TraceSender.Expression_True(1312, 40274, 40314)&&!incomingStream))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,40270,40478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,40410,40463);

f_1312_40410_40446(firstcommandProcessor).IsClosed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,40270,40478);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,40698,40873);

IDictionary 
psDefaultParameterValues =
f_1312_40754_40857(f_1312_40754_40783(firstcommandProcessor), SpecialVariables.PSDefaultParameterValuesVarPath, false)as IDictionary
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,40889,40914);

_executionStarted = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41144,41203);

int[] 
pipelineIterationInfo = new int[f_1312_41182_41197(_commands)+ 1]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41334,41339);

            // Prepare all commands from Engine's side,
            // and make sure they are all valid
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41325,43657) || true) && (i < f_1312_41345_41360(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41362,41365)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,41325,43657))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,41325,43657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41399,41452);

CommandProcessorBase 
commandProcessor = f_1312_41439_41451(_commands, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41470,41654) || true) && (commandProcessor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,41470,41654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41584,41635);

throw f_1312_41590_41634();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,41470,41654);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41734,41791);

Guid 
pipelineActivityId = f_1312_41760_41790()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41883,41929);

f_1312_41883_41928(pipelineActivityId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,41947,42004);

commandProcessor.PipelineActivityId = pipelineActivityId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,42072,42255);

f_1312_42072_42254(f_1312_42126_42150(commandProcessor), CommandState.Started, f_1312_42216_42253(f_1312_42216_42240(commandProcessor)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,42432,42573);

f_1312_42432_42572(TelemetryType.ApplicationType, f_1312_42512_42571(f_1312_42512_42560(f_1312_42512_42548(f_1312_42512_42536(commandProcessor)))));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,42930,43225) || true) && (f_1312_42934_42974(f_1312_42934_42962(commandProcessor))!= CommandTypes.Script)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,42930,43225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43039,43206);

f_1312_43039_43205(f_1312_43039_43088(f_1312_43039_43070(commandProcessor)), f_1312_43132_43169(f_1312_43132_43156(commandProcessor)), f_1312_43171_43204(f_1312_43171_43199(commandProcessor)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,42930,43225);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43245,43307);

InvocationInfo 
myInfo = f_1312_43269_43306(f_1312_43269_43293(commandProcessor))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43325,43357);

myInfo.PipelinePosition = i + 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43375,43415);

myInfo.PipelineLength = f_1312_43399_43414(_commands);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43433,43486);

myInfo.PipelineIterationInfo = pipelineIterationInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43504,43571);

myInfo.ExpectingInput = f_1312_43528_43570(commandProcessor);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43589,43642);

f_1312_43589_43641(                commandProcessor, psDefaultParameterValues);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,2333);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,2333);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,43724,43750);

f_1312_43724_43749(this);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44381,44386);

            // Prepare all commands from Command's side.
            // Note that DoPrepare() and DoBegin() should NOT be combined
            // in a single for loop.
            // Reason: Encoding of commandline parameters happen
            // as part of DoPrepare(). If they are combined,
            // the first command's DoBegin() will be called before
            // the next command's DoPrepare(). Since BeginProcessing()
            // can write objects to the downstream commandlet,
            // it will end up calling DoExecute() (from Pipe.Add())
            // before DoPrepare.
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44372,44561) || true) && (i < f_1312_44392_44407(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44409,44412)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,44372,44561))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,44372,44561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44446,44499);

CommandProcessorBase 
commandProcessor = f_1312_44486_44498(_commands, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44519,44546);

f_1312_44519_44545(
                commandProcessor);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,190);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,190);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1312,38173,44572);

System.Management.Automation.PSObjectDisposedException
f_1312_38364_38425(string
objectName)
{
var return_v = PSTraceSource.NewObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 38364, 38425);
return return_v;
}


bool
f_1312_38461_38469()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 38461, 38469);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_1312_38509_38539()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 38509, 38539);
return return_v;
}


int
f_1312_38664_38679(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 38664, 38679);
return return_v;
}


string
f_1312_38784_38840()
{
var return_v =                     PipelineStrings.PipelineExecuteRequiresAtLeastOneCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 38784, 38840);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_38719_38841(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 38719, 38841);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_38918_38930(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 38918, 38930);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_38999_39035(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 38999, 39035);
return return_v;
}


string
f_1312_39148_39204()
{
var return_v =                     PipelineStrings.PipelineExecuteRequiresAtLeastOneCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39148, 39204);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_39083_39205(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 39083, 39205);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_39380_39409(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39380, 39409);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1312_39380_39428(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39380, 39428);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1312_39380_39441(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39380, 39441);
return return_v;
}


int
f_1312_39589_39604(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39589, 39604);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_39579_39609(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39579, 39609);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_39677_39712(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39677, 39712);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_39838_39882()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 39838, 39882);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1312_39918_39939()
{
var return_v = ExternalSuccessOutput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39918, 39939);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_39981_40016(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39981, 40016);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_39981_40027(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.OutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 39981, 40027);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1312_40066_40087()
{
var return_v = ExternalSuccessOutput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 40066, 40087);
return return_v;
}


int
f_1312_40229_40253(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.SetExternalErrorOutput();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 40229, 40253);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1312_40274_40287()
{
var return_v = ExternalInput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 40274, 40287);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_40410_40446(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 40410, 40446);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_40754_40783(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 40754, 40783);
return return_v;
}


object
f_1312_40754_40857(System.Management.Automation.ExecutionContext
this_param,System.Management.Automation.VariablePath
path,bool
defaultValue)
{
var return_v = this_param.GetVariableValue( path, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 40754, 40857);
return return_v;
}


int
f_1312_41182_41197(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 41182, 41197);
return return_v;
}


int
f_1312_41345_41360(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 41345, 41360);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_41439_41451(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 41439, 41451);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_41590_41634()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 41590, 41634);
return return_v;
}


System.Guid
f_1312_41760_41790()
{
var return_v = EtwActivity.CreateActivityId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 41760, 41790);
return return_v;
}


bool
f_1312_41883_41928(System.Guid
activityId)
{
var return_v = EtwActivity.SetActivityId( activityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 41883, 41928);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_42126_42150(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42126, 42150);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_42216_42240(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42216, 42240);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_42216_42253(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42216, 42253);
return return_v;
}


int
f_1312_42072_42254(System.Management.Automation.ExecutionContext
executionContext,System.Management.Automation.CommandState
commandState,System.Management.Automation.InvocationInfo
invocationInfo)
{
MshLog.LogCommandLifecycleEvent( executionContext, commandState, invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 42072, 42254);
return 0;
}


System.Management.Automation.Internal.InternalCommand
f_1312_42512_42536(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42512, 42536);
return return_v;
}


System.Management.Automation.CommandInfo
f_1312_42512_42548(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.CommandInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42512, 42548);
return return_v;
}


System.Management.Automation.CommandTypes
f_1312_42512_42560(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42512, 42560);
return return_v;
}


string
f_1312_42512_42571(System.Management.Automation.CommandTypes
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 42512, 42571);
return return_v;
}


int
f_1312_42432_42572(Microsoft.PowerShell.Telemetry.TelemetryType
metricId,string
data)
{
ApplicationInsightsTelemetry.SendTelemetryMetric( metricId, data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 42432, 42572);
return 0;
}


System.Management.Automation.CommandInfo
f_1312_42934_42962(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42934, 42962);
return return_v;
}


System.Management.Automation.CommandTypes
f_1312_42934_42974(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 42934, 42974);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_43039_43070(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43039, 43070);
return return_v;
}


System.Management.Automation.Internal.PipelineProcessor
f_1312_43039_43088(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.PipelineProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43039, 43088);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_43132_43156(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43132, 43156);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_43132_43169(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43132, 43169);
return return_v;
}


System.Management.Automation.CommandInfo
f_1312_43171_43199(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43171, 43199);
return return_v;
}


string
f_1312_43171_43204(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43171, 43204);
return return_v;
}


int
f_1312_43039_43205(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Management.Automation.InvocationInfo
invocationInfo,string
text)
{
this_param.LogExecutionInfo( invocationInfo, text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 43039, 43205);
return 0;
}


System.Management.Automation.Internal.InternalCommand
f_1312_43269_43293(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43269, 43293);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_43269_43306(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43269, 43306);
return return_v;
}


int
f_1312_43399_43414(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 43399, 43414);
return return_v;
}


bool
f_1312_43528_43570(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.IsPipelineInputExpected();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 43528, 43570);
return return_v;
}


int
f_1312_43589_43641(System.Management.Automation.CommandProcessorBase
this_param,System.Collections.IDictionary
psDefaultParameterValues)
{
this_param.DoPrepare( psDefaultParameterValues);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 43589, 43641);
return 0;
}


int
f_1312_43724_43749(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.SetupParameterVariables();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 43724, 43749);
return 0;
}


int
f_1312_44392_44407(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 44392, 44407);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_44486_44498(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 44486, 44498);
return return_v;
}


int
f_1312_44519_44545(System.Management.Automation.CommandProcessorBase
this_param)
{
this_param.DoBegin();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 44519, 44545);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,38173,44572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,38173,44572);
}
		}

private void SetExternalErrorOutput()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,44736,45439);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44798,45428) || true) && (f_1312_44802_44821()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,44798,45428);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44872,44877);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44863,45413) || true) && (i < f_1312_44883_44898(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44900,44903)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,44863,45413))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,44863,45413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,44945,44998);

CommandProcessorBase 
commandProcessor = f_1312_44985_44997(_commands, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45020,45113);

Pipe 
UpstreamPipe =
f_1312_45065_45112(f_1312_45065_45096(commandProcessor))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45212,45394) || true) && (f_1312_45216_45242_M(!UpstreamPipe.IsRedirected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,45212,45394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45292,45371);

UpstreamPipe.ExternalWriter =
f_1312_45351_45370();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,45212,45394);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,551);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,551);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1312,44798,45428);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,44736,45439);

System.Management.Automation.Runspaces.PipelineWriter
f_1312_44802_44821()
{
var return_v = ExternalErrorOutput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 44802, 44821);
return return_v;
}


int
f_1312_44883_44898(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 44883, 44898);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_44985_44997(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 44985, 44997);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_45065_45096(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 45065, 45096);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_45065_45112(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.ErrorOutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 45065, 45112);
return return_v;
}


bool
f_1312_45216_45242_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 45216, 45242);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1312_45351_45370()
{
var return_v = ExternalErrorOutput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 45351, 45370);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,44736,45439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,44736,45439);
}
		}

private void SetupParameterVariables()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,45547,46374);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45619,45624);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45610,46363) || true) && (i < f_1312_45630_45645(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45647,45650)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,45610,46363))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,45610,46363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45684,45737);

CommandProcessorBase 
commandProcessor = f_1312_45724_45736(_commands, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45755,45982) || true) && (commandProcessor == null ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 45759, 45826)||f_1312_45787_45818(commandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,45755,45982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,45912,45963);

throw f_1312_45918_45962();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,45755,45982);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,46002,46053);

f_1312_46002_46052(f_1312_46002_46033(commandProcessor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,46071,46124);

f_1312_46071_46123(f_1312_46071_46102(commandProcessor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,46142,46197);

f_1312_46142_46196(f_1312_46142_46173(commandProcessor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,46215,46271);

f_1312_46215_46270(f_1312_46215_46246(commandProcessor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,46289,46348);

f_1312_46289_46347(f_1312_46289_46320(commandProcessor));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,754);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,754);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1312,45547,46374);

int
f_1312_45630_45645(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 45630, 45645);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_45724_45736(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 45724, 45736);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_45787_45818(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 45787, 45818);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_45918_45962()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 45918, 45962);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_46002_46033(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 46002, 46033);
return return_v;
}


int
f_1312_46002_46052(System.Management.Automation.MshCommandRuntime
this_param)
{
this_param.SetupOutVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 46002, 46052);
return 0;
}


System.Management.Automation.MshCommandRuntime
f_1312_46071_46102(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 46071, 46102);
return return_v;
}


int
f_1312_46071_46123(System.Management.Automation.MshCommandRuntime
this_param)
{
this_param.SetupErrorVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 46071, 46123);
return 0;
}


System.Management.Automation.MshCommandRuntime
f_1312_46142_46173(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 46142, 46173);
return return_v;
}


int
f_1312_46142_46196(System.Management.Automation.MshCommandRuntime
this_param)
{
this_param.SetupWarningVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 46142, 46196);
return 0;
}


System.Management.Automation.MshCommandRuntime
f_1312_46215_46246(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 46215, 46246);
return return_v;
}


int
f_1312_46215_46270(System.Management.Automation.MshCommandRuntime
this_param)
{
this_param.SetupPipelineVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 46215, 46270);
return 0;
}


System.Management.Automation.MshCommandRuntime
f_1312_46289_46320(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 46289, 46320);
return return_v;
}


int
f_1312_46289_46347(System.Management.Automation.MshCommandRuntime
this_param)
{
this_param.SetupInformationVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 46289, 46347);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,45547,46374);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,45547,46374);
}
		}

private void Inject(object input, bool enumerate)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,47497,49035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,47623,47681);

CommandProcessorBase 
firstcommandProcessor = f_1312_47668_47680(_commands, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,47695,47971) || true) && (firstcommandProcessor == null
||(DynAbs.Tracing.TraceSender.Expression_False(1312, 47699, 47793)||f_1312_47749_47785(firstcommandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,47695,47971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,47827,47956);

throw f_1312_47833_47955(f_1312_47898_47954());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,47695,47971);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,47987,48693) || true) && (input != f_1312_48000_48020())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,47987,48693);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,48054,48678) || true) && (enumerate)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,48054,48678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,48109,48174);

IEnumerator 
enumerator = f_1312_48134_48173(input)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,48198,48519) || true) && (enumerator != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,48198,48519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,48270,48340);

f_1312_48270_48306(firstcommandProcessor).InputPipe = f_1312_48319_48339(enumerator);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,48198,48519);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,48198,48519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,48438,48496);

f_1312_48438_48495(f_1312_48438_48484(f_1312_48438_48474(firstcommandProcessor)), input);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,48198,48519);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,48054,48678);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,48054,48678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,48601,48659);

f_1312_48601_48658(f_1312_48601_48647(f_1312_48601_48637(firstcommandProcessor)), input);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,48054,48678);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,47987,48693);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,48990,49024);

f_1312_48990_49023(
            // Do not set ExternalInput until SynchronousExecute is called
            // Execute the first command - In the streamlet model, Execute of the first command will
            // automatically call the downstream command incase if there are any objects in the pipe.
            firstcommandProcessor);
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,47497,49035);

System.Management.Automation.CommandProcessorBase
f_1312_47668_47680(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 47668, 47680);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_47749_47785(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 47749, 47785);
return return_v;
}


string
f_1312_47898_47954()
{
var return_v =                     PipelineStrings.PipelineExecuteRequiresAtLeastOneCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 47898, 47954);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_47833_47955(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 47833, 47955);
return return_v;
}


System.Management.Automation.PSObject
f_1312_48000_48020()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 48000, 48020);
return return_v;
}


System.Collections.IEnumerator
f_1312_48134_48173(object
obj)
{
var return_v = LanguagePrimitives.GetEnumerator( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 48134, 48173);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_48270_48306(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 48270, 48306);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_48319_48339(System.Collections.IEnumerator
enumeratorToProcess)
{
var return_v = new System.Management.Automation.Internal.Pipe( enumeratorToProcess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 48319, 48339);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_48438_48474(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 48438, 48474);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_48438_48484(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.InputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 48438, 48484);
return return_v;
}


int
f_1312_48438_48495(System.Management.Automation.Internal.Pipe
this_param,object
obj)
{
this_param.Add( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 48438, 48495);
return 0;
}


System.Management.Automation.MshCommandRuntime
f_1312_48601_48637(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 48601, 48637);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_48601_48647(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.InputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 48601, 48647);
return return_v;
}


int
f_1312_48601_48658(System.Management.Automation.Internal.Pipe
this_param,object
obj)
{
this_param.Add( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 48601, 48658);
return 0;
}


int
f_1312_48990_49023(System.Management.Automation.CommandProcessorBase
this_param)
{
this_param.DoExecute();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 48990, 49023);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,47497,49035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,47497,49035);
}
		}

private Array RetrieveResults()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,49339,51649);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,49534,50612) || true) && (!_linkedErrorOutput)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,49534,50612);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,49748,49753);
                // Retrieve any accumulated error objects from each of the pipes
                // and add them to the error results hash table.
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,49739,50597) || true) && (i < f_1312_49759_49774(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,49776,49779)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,49739,50597))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,49739,50597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,49821,49874);

CommandProcessorBase 
commandProcessor = f_1312_49861_49873(_commands, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,49896,50194) || true) && (commandProcessor == null
||(DynAbs.Tracing.TraceSender.Expression_False(1312, 49900, 49992)||f_1312_49953_49984(commandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,49896,50194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50120,50171);

throw f_1312_50126_50170();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,49896,50194);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50218,50283);

Pipe 
ErrorPipe = f_1312_50235_50282(f_1312_50235_50266(commandProcessor))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50305,50578) || true) && (f_1312_50309_50335(ErrorPipe)== null &&(DynAbs.Tracing.TraceSender.Expression_True(1312, 50309, 50363)&&f_1312_50347_50363_M(!ErrorPipe.Empty)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,50305,50578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50537,50555);

f_1312_50537_50554(                        // 2003/10/02-JonN
                        // Do not return the same error results more than once
                        ErrorPipe);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,50305,50578);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,859);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,859);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1312,49534,50612);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50769,50854) || true) && (_linkedSuccessOutput)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,50769,50854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50812,50854);

return MshCommandRuntime.StaticEmptyArray;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,50769,50854);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50870,50945);

CommandProcessorBase 
LastCommandProcessor = f_1312_50914_50944(_commands, f_1312_50924_50939(_commands)- 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,50959,51243) || true) && (LastCommandProcessor == null
||(DynAbs.Tracing.TraceSender.Expression_False(1312, 50963, 51055)||f_1312_51012_51047(LastCommandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,50959,51243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,51177,51228);

throw f_1312_51183_51227();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,50959,51243);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,51259,51348);

Array 
results =
f_1312_51292_51347(f_1312_51292_51327(LastCommandProcessor))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,51458,51513);

f_1312_51458_51512(f_1312_51458_51504(f_1312_51458_51493(LastCommandProcessor)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,51529,51609) || true) && (results == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,51529,51609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,51567,51609);

return MshCommandRuntime.StaticEmptyArray;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,51529,51609);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,51623,51638);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,49339,51649);

int
f_1312_49759_49774(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 49759, 49774);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_49861_49873(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 49861, 49873);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_49953_49984(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 49953, 49984);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_50126_50170()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 50126, 50170);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_50235_50266(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 50235, 50266);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_50235_50282(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.ErrorOutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 50235, 50282);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_50309_50335(System.Management.Automation.Internal.Pipe
this_param)
{
var return_v = this_param.DownstreamCmdlet ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 50309, 50335);
return return_v;
}


bool
f_1312_50347_50363_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 50347, 50363);
return return_v;
}


int
f_1312_50537_50554(System.Management.Automation.Internal.Pipe
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 50537, 50554);
return 0;
}


int
f_1312_50924_50939(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 50924, 50939);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_50914_50944(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 50914, 50944);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_51012_51047(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 51012, 51047);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_51183_51227()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 51183, 51227);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_51292_51327(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 51292, 51327);
return return_v;
}


object[]
f_1312_51292_51347(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.GetResultsAsArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 51292, 51347);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_51458_51493(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 51458, 51493);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_51458_51504(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.OutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 51458, 51504);
return return_v;
}


int
f_1312_51458_51512(System.Management.Automation.Internal.Pipe
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 51458, 51512);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,49339,51649);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,49339,51649);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void LinkPipelineSuccessOutput(Pipe pipeToUse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,52001,52670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52081,52153);

f_1312_52081_52152(pipeToUse != null, "Caller should verify pipeToUse != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52169,52244);

CommandProcessorBase 
LastCommandProcessor = f_1312_52213_52243(_commands, f_1312_52223_52238(_commands)- 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52258,52542) || true) && (LastCommandProcessor == null
||(DynAbs.Tracing.TraceSender.Expression_False(1312, 52262, 52354)||f_1312_52311_52346(LastCommandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,52258,52542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52476,52527);

throw f_1312_52482_52526();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,52258,52542);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52558,52617);

f_1312_52558_52593(LastCommandProcessor).OutputPipe = pipeToUse;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52631,52659);

_linkedSuccessOutput = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,52001,52670);

int
f_1312_52081_52152(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 52081, 52152);
return 0;
}


int
f_1312_52223_52238(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 52223, 52238);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_52213_52243(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 52213, 52243);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_52311_52346(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 52311, 52346);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_52482_52526()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 52482, 52526);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_52558_52593(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 52558, 52593);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,52001,52670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,52001,52670);
}
		}

internal void LinkPipelineErrorOutput(Pipe pipeToUse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,52682,53556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52760,52832);

f_1312_52760_52831(pipeToUse != null, "Caller should verify pipeToUse != null");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52857,52862);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52848,53503) || true) && (i < f_1312_52868_52883(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52885,52888)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,52848,53503))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,52848,53503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52922,52975);

CommandProcessorBase 
commandProcessor = f_1312_52962_52974(_commands, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,52993,53271) || true) && (commandProcessor == null
||(DynAbs.Tracing.TraceSender.Expression_False(1312, 52997, 53085)||f_1312_53046_53077(commandProcessor)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,52993,53271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,53201,53252);

throw f_1312_53207_53251();
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,52993,53271);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,53291,53488) || true) && (f_1312_53295_53359(f_1312_53295_53342(f_1312_53295_53326(commandProcessor)))== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,53291,53488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,53409,53469);

f_1312_53409_53440(commandProcessor).ErrorOutputPipe = pipeToUse;
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,53291,53488);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,656);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,656);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,53519,53545);

_linkedErrorOutput = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,52682,53556);

int
f_1312_52760_52831(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 52760, 52831);
return 0;
}


int
f_1312_52868_52883(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 52868, 52883);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_52962_52974(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 52962, 52974);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_53046_53077(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 53046, 53077);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_53207_53251()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 53207, 53251);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_53295_53326(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 53295, 53326);
return return_v;
}


System.Management.Automation.Internal.Pipe
f_1312_53295_53342(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.ErrorOutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 53295, 53342);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_53295_53359(System.Management.Automation.Internal.Pipe
this_param)
{
var return_v = this_param.DownstreamCmdlet ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 53295, 53359);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_53409_53440(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 53409, 53440);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,52682,53556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,52682,53556);
}
		}

private void DisposeCommands()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,53920,57548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54124,54141);

_stopping = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54157,54173);

f_1312_54157_54172(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54189,56622) || true) && (_commands != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,54189,56622);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54253,54258);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54244,56607) || true) && (i < f_1312_54264_54279(_commands))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54281,54284)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1312,54244,56607))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,54244,56607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54326,54379);

CommandProcessorBase 
commandProcessor = f_1312_54366_54378(_commands, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54401,56588) || true) && (commandProcessor != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,54401,56588);
#pragma warning disable 56500
                        // If Dispose throws an exception, record it as a
                        // pipeline failure and continue disposing cmdlets.
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54722,54782);

f_1312_54722_54781(f_1312_54722_54753(commandProcessor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,54812,54839);

f_1312_54812_54838(                            commandProcessor);
                        }
                        // 2005/04/13-JonN: The only vaguely plausible reason
                        // for a failure here is an exception in Command.Dispose.
                        // As such, this should be covered by the overall
                        // exemption.
                        catch (Exception e) // Catch-all OK, 3rd party callout.
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,55168,56534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,55280,55315);

InvocationInfo 
myInvocation = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,55345,55469) || true) && (f_1312_55349_55373(commandProcessor)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,55345,55469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,55416,55469);

myInvocation = f_1312_55431_55468(f_1312_55431_55455(commandProcessor));
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,55345,55469);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,55501,55601);

ProviderInvocationException 
pie =
                                e as ProviderInvocationException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,55631,56432) || true) && (pie != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,55631,56432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,55712,55848);

e = f_1312_55716_55847(pie, myInvocation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,55631,56432);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,55631,56432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,55978,56104);

e = f_1312_55982_56103(e, myInvocation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,56205,56401);

f_1312_56205_56400(f_1312_56272_56304(f_1312_56272_56296(commandProcessor)), e, Severity.Warning);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,55631,56432);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,56464,56507);

f_1312_56464_56506(this, e, f_1312_56481_56505(commandProcessor));
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,55168,56534);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,54401,56588);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,2364);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,2364);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1312,54189,56622);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,56638,56655);

_commands = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,56743,57496) || true) && (_redirectionPipes != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,56743,57496);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,56806,57481);
foreach(PipelineProcessor redirPipe in f_1312_56846_56863_I(_redirectionPipes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,56806,57481);
#pragma warning disable 56500
                    // The complicated logic of disposing the commands is taken care
                    // of through recursion, this routine should not be getting any
                    // exceptions...
                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,57197,57323) || true) && (redirPipe != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,57197,57323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,57276,57296);

f_1312_57276_57295(                            redirPipe);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,57197,57323);
}
                    }
                    catch (Exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1312,57368,57431);
DynAbs.Tracing.TraceSender.TraceExitCatch(1312,57368,57431);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,56806,57481);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,1,676);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,1,676);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1312,56743,57496);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,57512,57537);

_redirectionPipes = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,53920,57548);

int
f_1312_54157_54172(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.LogToEventLog();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 54157, 54172);
return 0;
}


int
f_1312_54264_54279(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 54264, 54279);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1312_54366_54378(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 54366, 54378);
return return_v;
}


System.Management.Automation.MshCommandRuntime
f_1312_54722_54753(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.CommandRuntime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 54722, 54753);
return return_v;
}


int
f_1312_54722_54781(System.Management.Automation.MshCommandRuntime
this_param)
{
this_param.RemoveVariableListsInPipe();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 54722, 54781);
return 0;
}


int
f_1312_54812_54838(System.Management.Automation.CommandProcessorBase
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 54812, 54838);
return 0;
}


System.Management.Automation.Internal.InternalCommand
f_1312_55349_55373(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 55349, 55373);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_55431_55455(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 55431, 55455);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1312_55431_55468(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 55431, 55468);
return return_v;
}


System.Management.Automation.CmdletProviderInvocationException
f_1312_55716_55847(System.Management.Automation.ProviderInvocationException
innerException,System.Management.Automation.InvocationInfo
myInvocation)
{
var return_v = new System.Management.Automation.CmdletProviderInvocationException( innerException, myInvocation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 55716, 55847);
return return_v;
}


System.Management.Automation.CmdletInvocationException
f_1312_55982_56103(System.Exception
innerException,System.Management.Automation.InvocationInfo
invocationInfo)
{
var return_v = new System.Management.Automation.CmdletInvocationException( innerException, invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 55982, 56103);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1312_56272_56296(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 56272, 56296);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_56272_56304(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 56272, 56304);
return return_v;
}


int
f_1312_56205_56400(System.Management.Automation.ExecutionContext
executionContext,System.Exception
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogCommandHealthEvent( executionContext, exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 56205, 56400);
return 0;
}


System.Management.Automation.Internal.InternalCommand
f_1312_56481_56505(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 56481, 56505);
return return_v;
}


bool
f_1312_56464_56506(System.Management.Automation.Internal.PipelineProcessor
this_param,System.Exception
e,System.Management.Automation.Internal.InternalCommand
command)
{
var return_v = this_param.RecordFailure( e, command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 56464, 56506);
return return_v;
}


int
f_1312_57276_57295(System.Management.Automation.Internal.PipelineProcessor
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 57276, 57295);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.PipelineProcessor>
f_1312_56846_56863_I(System.Collections.Generic.List<System.Management.Automation.Internal.PipelineProcessor>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 56846, 56863);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,53920,57548);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,53920,57548);
}
		}

private object _stopReasonLock ;

internal bool RecordFailure(Exception e, InternalCommand command)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,58007,60117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,58097,58122);

bool 
wasStopping = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,58142,58157);
            lock (_stopReasonLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,58191,59976) || true) && (_firstTerminatingError == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,58191,59976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,58267,58325);

_firstTerminatingError = f_1312_58292_58324(e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,58191,59976);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,58191,59976);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,58724,59976) || true) && ((!(f_1312_58731_58769(_firstTerminatingError)is PipelineStoppedException))
&&(DynAbs.Tracing.TraceSender.Expression_True(1312, 58728, 58839)&&command != null )&&(DynAbs.Tracing.TraceSender.Expression_True(1312, 58728, 58866)&&f_1312_58843_58858(command)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,58724,59976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,58908,58925);

Exception 
ex = e
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,58947,59178) || true) && ((ex is TargetInvocationException ||(DynAbs.Tracing.TraceSender.Expression_False(1312, 58955, 59021)||ex is CmdletInvocationException))
&&(DynAbs.Tracing.TraceSender.Expression_True(1312, 58954, 59082)&&(f_1312_59056_59073(ex)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,58947,59178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,59132,59155);

ex = f_1312_59137_59154(ex);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,58947,59178);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1312,58947,59178);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1312,58947,59178);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,59202,59957) || true) && (!(ex is PipelineStoppedException))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,59202,59957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,59289,59621);

string 
message = f_1312_59306_59620(f_1312_59324_59353(), f_1312_59384_59421(f_1312_59384_59416(                            _firstTerminatingError)), f_1312_59452_59501(f_1312_59452_59490(_firstTerminatingError)), f_1312_59532_59549(f_1312_59532_59544(                            ex)), f_1312_59580_59593(ex))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,59647,59751);

InvalidOperationException 
ioe
                            = f_1312_59708_59750(message, ex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,59777,59934);

f_1312_59777_59933(f_1312_59836_59851(command), ioe, Severity.Warning);
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,59202,59957);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,58724,59976);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,58191,59976);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,59996,60020);

wasStopping = _stopping;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,60038,60055);

_stopping = true;
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,60086,60106);

return !wasStopping;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,58007,60117);

System.Runtime.ExceptionServices.ExceptionDispatchInfo
f_1312_58292_58324(System.Exception
source)
{
var return_v = ExceptionDispatchInfo.Capture( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 58292, 58324);
return return_v;
}


System.Exception
f_1312_58731_58769(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 58731, 58769);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_58843_58858(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.Context ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 58843, 58858);
return return_v;
}


System.Exception
f_1312_59056_59073(System.Exception
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59056, 59073);
return return_v;
}


System.Exception
f_1312_59137_59154(System.Exception
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59137, 59154);
return return_v;
}


string
f_1312_59324_59353()
{
var return_v = PipelineStrings.SecondFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59324, 59353);
return return_v;
}


System.Type
f_1312_59384_59416(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 59384, 59416);
return return_v;
}


string
f_1312_59384_59421(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59384, 59421);
return return_v;
}


System.Exception
f_1312_59452_59490(System.Runtime.ExceptionServices.ExceptionDispatchInfo
this_param)
{
var return_v = this_param.SourceException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59452, 59490);
return return_v;
}


string
f_1312_59452_59501(System.Exception
this_param)
{
var return_v = this_param.StackTrace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59452, 59501);
return return_v;
}


System.Type
f_1312_59532_59544(System.Exception
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 59532, 59544);
return return_v;
}


string
f_1312_59532_59549(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59532, 59549);
return return_v;
}


string
f_1312_59580_59593(System.Exception
this_param)
{
var return_v = this_param.StackTrace
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59580, 59593);
return return_v;
}


string
f_1312_59306_59620(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 59306, 59620);
return return_v;
}


System.InvalidOperationException
f_1312_59708_59750(string
message,System.Exception
innerException)
{
var return_v = new System.InvalidOperationException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 59708, 59750);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1312_59836_59851(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 59836, 59851);
return return_v;
}


int
f_1312_59777_59933(System.Management.Automation.ExecutionContext
executionContext,System.InvalidOperationException
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogCommandHealthEvent( executionContext, (System.Exception)exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 59777, 59933);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,58007,60117);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,58007,60117);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ForgetFailure()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,60321,60416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,60375,60405);

_firstTerminatingError = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,60321,60416);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,60321,60416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,60321,60416);
}
		}

internal InternalCommand _permittedToWrite ;

internal bool _permittedToWriteToPipeline ;

internal System.Threading.Thread _permittedToWriteThread ;

internal PipelineReader<object> ExternalInput
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,61596,61630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,61602,61628);

return _externalInputPipe;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,61596,61630);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,61526,61953);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,61526,61953);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,61646,61942);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,61682,61880) || true) && (_executionStarted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,61682,61880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,61745,61861);

throw f_1312_61751_61860(f_1312_61820_61859());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,61682,61880);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,61900,61927);

_externalInputPipe = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,61646,61942);

string
f_1312_61820_61859()
{
var return_v =                         PipelineStrings.ExecutionAlreadyStarted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 61820, 61859);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_61751_61860(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 61751, 61860);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,61526,61953);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,61526,61953);
}
		}}

internal PipelineWriter ExternalSuccessOutput
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,62628,62666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,62634,62664);

return _externalSuccessOutput;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,62628,62666);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,62558,62993);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,62558,62993);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,62682,62982);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,62718,62916) || true) && (_executionStarted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,62718,62916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,62781,62897);

throw f_1312_62787_62896(f_1312_62856_62895());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,62718,62916);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,62936,62967);

_externalSuccessOutput = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,62682,62982);

string
f_1312_62856_62895()
{
var return_v =                         PipelineStrings.ExecutionAlreadyStarted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 62856, 62895);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_62787_62896(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 62787, 62896);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,62558,62993);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,62558,62993);
}
		}}

internal PipelineWriter ExternalErrorOutput
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,63736,63772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,63742,63770);

return _externalErrorOutput;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,63736,63772);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,63668,64097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,63668,64097);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,63788,64086);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,63824,64022) || true) && (_executionStarted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1312,63824,64022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,63887,64003);

throw f_1312_63893_64002(f_1312_63962_64001());
DynAbs.Tracing.TraceSender.TraceExitCondition(1312,63824,64022);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,64042,64071);

_externalErrorOutput = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,63788,64086);

string
f_1312_63962_64001()
{
var return_v =                         PipelineStrings.ExecutionAlreadyStarted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 63962, 64001);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1312_63893_64002(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 63893, 64002);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,63668,64097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,63668,64097);
}
		}}

internal bool ExecutionStarted
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,64348,64381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,64354,64379);

return _executionStarted;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,64348,64381);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,64293,64392);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,64293,64392);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool Stopping
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,64580,64647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,64586,64645);

return _localPipeline != null &&(DynAbs.Tracing.TraceSender.Expression_True(1312, 64593, 64644)&&f_1312_64619_64644(_localPipeline));
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,64580,64647);

bool
f_1312_64619_64644(System.Management.Automation.Runspaces.LocalPipeline
this_param)
{
var return_v = this_param.IsStopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1312, 64619, 64644);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,64533,64658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,64533,64658);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private LocalPipeline _localPipeline;

internal LocalPipeline LocalPipeline
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,64778,64808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,64784,64806);

return _localPipeline;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,64778,64808);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,64717,64866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,64717,64866);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,64824,64855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,64830,64853);

_localPipeline = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,64824,64855);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,64717,64866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,64717,64866);
}
		}}

internal bool TopLevel {get; set; }

internal SessionStateScope ExecutionScope
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,65103,65134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,65109,65132);

return _executionScope;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,65103,65134);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,65037,65424);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,65037,65424);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1312,65150,65413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,65374,65398);

_executionScope = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1312,65150,65413);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1312,65037,65424);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,65037,65424);
}
		}}
        
        internal enum PipelineExecutionStatus
        {
            Started,
            ParameterBinding,
            Complete,
            Error,
            PipelineComplete
        }

public PipelineProcessor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1312,1035,65666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1168,1212);
this._commands = f_1312_1180_1212();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1255,1272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1314,1332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1366,1388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1422,1442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1466,1491);
this._executionStarted = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1515,1532);
this._stopping = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1569,1584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1627,1656);
this._firstTerminatingError = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1682,1710);
this._linkedSuccessOutput = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,1734,1760);
this._linkedErrorOutput = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,2109,2126);
this._disposed = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,3494,3518);
this._executionFailed = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,5488,5519);
this._terminatingErrorLogged = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,9508,9544);
this._eventLogBuffer = f_1312_9526_9544();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,57575,57605);
this._stopReasonLock = f_1312_57593_57605();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,60604,60628);
this._permittedToWrite = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,60653,60688);
this._permittedToWriteToPipeline = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,60732,60762);
this._permittedToWriteThread = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,64692,64706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1312,64878,64923);
this.TopLevel = false;DynAbs.Tracing.TraceSender.TraceExitConstructor(1312,1035,65666);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,1035,65666);
}


static PipelineProcessor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1312,1035,65666);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1312,1035,65666);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1312,1035,65666);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1312,1035,65666);

System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
f_1312_1180_1212()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 1180, 1212);
return return_v;
}


int
f_1312_3375_3389(System.Management.Automation.Internal.PipelineProcessor
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 3375, 3389);
return 0;
}


System.Collections.Generic.List<string>
f_1312_9526_9544()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 9526, 9544);
return return_v;
}


object
f_1312_57593_57605()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1312, 57593, 57605);
return return_v;
}

}
}

