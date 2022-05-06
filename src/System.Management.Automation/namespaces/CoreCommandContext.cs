// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
internal sealed class CmdletProviderContext
{
[Dbg.TraceSourceAttribute(
             "CmdletProviderContext",
             "The context under which a core command is being run.")]
        private static Dbg.PSTraceSource s_tracer ;

internal CmdletProviderContext(ExecutionContext executionContext)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1189,2032,2710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10473,10487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10635,10668);
this._credentials = f_1189_10650_10668();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10874,10880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11123,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11276,11340);
this.Origin = CommandOrigin.Internal;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11802,11815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12063,12111);
this._accumulatedObjects = f_1189_12085_12111();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12357,12413);
this._accumulatedErrorObjects = f_1189_12384_12413();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12621,12638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12833,12884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14344,14391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15049,15085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15334,15374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17934,17970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18172,18229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18431,18488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18812,18872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41644,41688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41848,41956);
this.StopReferrals = f_1189_41916_41955();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,2122,2264) || true) && (executionContext == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,2122,2264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,2184,2249);

throw f_1189_2190_2248("executionContext");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,2122,2264);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,2280,2316);

ExecutionContext = executionContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,2330,2362);

Origin = CommandOrigin.Internal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,2376,2433);

Drive = f_1189_2384_2432(f_1189_2384_2419(executionContext));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,2447,2699) || true) && ((f_1189_2452_2492(executionContext)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1189, 2451, 2582)&&                (f_1189_2523_2571(f_1189_2523_2563(executionContext))is Cmdlet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,2447,2699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,2616,2684);

_command = (Cmdlet)f_1189_2635_2683(f_1189_2635_2675(executionContext));
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,2447,2699);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1189,2032,2710);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,2032,2710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,2032,2710);
}
		}

internal CmdletProviderContext(ExecutionContext executionContext, CommandOrigin origin)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1189,3221,3568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10473,10487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10635,10668);
this._credentials = f_1189_10650_10668();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10874,10880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11123,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11276,11340);
this.Origin = CommandOrigin.Internal;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11802,11815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12063,12111);
this._accumulatedObjects = f_1189_12085_12111();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12357,12413);
this._accumulatedErrorObjects = f_1189_12384_12413();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12621,12638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12833,12884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14344,14391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15049,15085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15334,15374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17934,17970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18172,18229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18431,18488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18812,18872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41644,41688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41848,41956);
this.StopReferrals = f_1189_41916_41955();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,3333,3475) || true) && (executionContext == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,3333,3475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,3395,3460);

throw f_1189_3401_3459("executionContext");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,3333,3475);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,3491,3527);

ExecutionContext = executionContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,3541,3557);

Origin = origin;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1189,3221,3568);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,3221,3568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,3221,3568);
}
		}

internal CmdletProviderContext(
            PSCmdlet command,
            PSCredential credentials,
            PSDriveInfo drive)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1189,4374,5437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10473,10487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10635,10668);
this._credentials = f_1189_10650_10668();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10874,10880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11123,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11276,11340);
this.Origin = CommandOrigin.Internal;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11802,11815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12063,12111);
this._accumulatedObjects = f_1189_12085_12111();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12357,12413);
this._accumulatedErrorObjects = f_1189_12384_12413();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12621,12638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12833,12884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14344,14391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15049,15085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15334,15374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17934,17970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18172,18229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18431,18488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18812,18872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41644,41688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41848,41956);
this.StopReferrals = f_1189_41916_41955();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4577,4701) || true) && (command == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,4577,4701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4630,4686);

throw f_1189_4636_4685("command");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,4577,4701);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4717,4736);

_command = command;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4750,4781);

Origin = f_1189_4759_4780(command);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4797,4896) || true) && (credentials != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,4797,4896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4854,4881);

_credentials = credentials;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,4797,4896);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4912,4926);

Drive = drive;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,4942,5072) || true) && (f_1189_4946_4958(command)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,4942,5072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,5000,5057);

throw f_1189_5006_5056("command.Host");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,4942,5072);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,5088,5224) || true) && (f_1189_5092_5107(command)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,5088,5224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,5149,5209);

throw f_1189_5155_5208("command.Context");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,5088,5224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,5240,5275);

ExecutionContext = f_1189_5259_5274(command);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,5375,5391);

PassThru = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,5405,5426);

_streamErrors = true;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1189,4374,5437);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,4374,5437);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,4374,5437);
}
		}

internal CmdletProviderContext(
            PSCmdlet command,
            PSCredential credentials)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1189,6123,7124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10473,10487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10635,10668);
this._credentials = f_1189_10650_10668();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10874,10880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11123,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11276,11340);
this.Origin = CommandOrigin.Internal;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11802,11815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12063,12111);
this._accumulatedObjects = f_1189_12085_12111();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12357,12413);
this._accumulatedErrorObjects = f_1189_12384_12413();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12621,12638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12833,12884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14344,14391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15049,15085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15334,15374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17934,17970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18172,18229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18431,18488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18812,18872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41644,41688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41848,41956);
this.StopReferrals = f_1189_41916_41955();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6294,6418) || true) && (command == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,6294,6418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6347,6403);

throw f_1189_6353_6402("command");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,6294,6418);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6434,6453);

_command = command;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6467,6498);

Origin = f_1189_6476_6497(command);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6514,6613) || true) && (credentials != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,6514,6613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6571,6598);

_credentials = credentials;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,6514,6613);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6629,6759) || true) && (f_1189_6633_6645(command)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,6629,6759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6687,6744);

throw f_1189_6693_6743("command.Host");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,6629,6759);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6775,6911) || true) && (f_1189_6779_6794(command)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,6775,6911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6836,6896);

throw f_1189_6842_6895("command.Context");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,6775,6911);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,6927,6962);

ExecutionContext = f_1189_6946_6961(command);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,7062,7078);

PassThru = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,7092,7113);

_streamErrors = true;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1189,6123,7124);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,6123,7124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,6123,7124);
}
		}

internal CmdletProviderContext(
            Cmdlet command)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1189,7681,8380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10473,10487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10635,10668);
this._credentials = f_1189_10650_10668();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10874,10880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11123,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11276,11340);
this.Origin = CommandOrigin.Internal;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11802,11815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12063,12111);
this._accumulatedObjects = f_1189_12085_12111();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12357,12413);
this._accumulatedErrorObjects = f_1189_12384_12413();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12621,12638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12833,12884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14344,14391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15049,15085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15334,15374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17934,17970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18172,18229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18431,18488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18812,18872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41644,41688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41848,41956);
this.StopReferrals = f_1189_41916_41955();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,7811,7935) || true) && (command == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,7811,7935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,7864,7920);

throw f_1189_7870_7919("command");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,7811,7935);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,7951,7970);

_command = command;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,7984,8015);

Origin = f_1189_7993_8014(command);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,8031,8167) || true) && (f_1189_8035_8050(command)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,8031,8167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,8092,8152);

throw f_1189_8098_8151("command.Context");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,8031,8167);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,8183,8218);

ExecutionContext = f_1189_8202_8217(command);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,8318,8334);

PassThru = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,8348,8369);

_streamErrors = true;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1189,7681,8380);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,7681,8380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,7681,8380);
}
		}

internal CmdletProviderContext(
            CmdletProviderContext contextToCopyFrom)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1189,8916,10181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10473,10487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10635,10668);
this._credentials = f_1189_10650_10668();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10874,10880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11123,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11276,11340);
this.Origin = CommandOrigin.Internal;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,11802,11815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12063,12111);
this._accumulatedObjects = f_1189_12085_12111();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12357,12413);
this._accumulatedErrorObjects = f_1189_12384_12413();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12621,12638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,12833,12884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14344,14391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15049,15085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15334,15374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17934,17970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18172,18229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18431,18488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,18812,18872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41644,41688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41848,41956);
this.StopReferrals = f_1189_41916_41955();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9026,9170) || true) && (contextToCopyFrom == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,9026,9170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9089,9155);

throw f_1189_9095_9154("contextToCopyFrom");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,9026,9170);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9186,9240);

ExecutionContext = f_1189_9205_9239(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9256,9294);

_command = contextToCopyFrom._command;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9310,9443) || true) && (f_1189_9314_9342(contextToCopyFrom)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,9310,9443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9384,9428);

_credentials = f_1189_9399_9427(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,9310,9443);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9459,9491);

Drive = f_1189_9467_9490(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9505,9538);

_force = f_1189_9514_9537(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9552,9588);

f_1189_9552_9587(            this, contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9602,9674);

SuppressWildcardExpansion = f_1189_9630_9673(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9688,9744);

DynamicParameters = f_1189_9708_9743(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9758,9792);

Origin = f_1189_9767_9791(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,9931,9969);

Stopping = f_1189_9942_9968(contextToCopyFrom);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10079,10121);

f_1189_10079_10120(f_1189_10079_10110(contextToCopyFrom), this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,10135,10170);

_copiedContext = contextToCopyFrom;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1189,8916,10181);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,8916,10181);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,8916,10181);
}
		}

private CmdletProviderContext _copiedContext;

private PSCredential _credentials ;

private bool _force;

private Cmdlet _command;

internal CommandOrigin Origin {get; }

private bool _streamErrors;

private Collection<PSObject> _accumulatedObjects ;

private Collection<ErrorRecord> _accumulatedErrorObjects ;

private System.Management.Automation.Provider.CmdletProvider _providerInstance;

internal ExecutionContext ExecutionContext {get; }

internal System.Management.Automation.Provider.CmdletProvider ProviderInstance
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,13142,13218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,13178,13203);

return _providerInstance;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,13142,13218);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,13039,13322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,13039,13322);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,13234,13311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,13270,13296);

_providerInstance = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,13234,13311);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,13039,13322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,13039,13322);
}
		}}

private void CopyFilters(CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,13610,13943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,13690,13812);

f_1189_13690_13811(context != null, "The caller should have verified the context");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,13828,13854);

Include = f_1189_13838_13853(context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,13868,13894);

Exclude = f_1189_13878_13893(context);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,13908,13932);

Filter = f_1189_13917_13931(context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,13610,13943);

int
f_1189_13690_13811(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 13690, 13811);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1189_13838_13853(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 13838, 13853);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1189_13878_13893(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 13878, 13893);
return return_v;
}


string
f_1189_13917_13931(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Filter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 13917, 13931);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,13610,13943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,13610,13943);
}
		}

internal void RemoveStopReferral()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,13955,14142);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14014,14131) || true) && (_copiedContext != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,14014,14131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14074,14116);

f_1189_14074_14115(f_1189_14074_14102(_copiedContext), this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,14014,14131);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,13955,14142);

System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
f_1189_14074_14102(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.StopReferrals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 14074, 14102);
return return_v;
}


bool
f_1189_14074_14115(System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
this_param,System.Management.Automation.CmdletProviderContext
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 14074, 14115);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,13955,14142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,13955,14142);
}
		}

internal object DynamicParameters {get; set; }

internal InvocationInfo MyInvocation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,14573,14828);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14609,14813) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,14609,14813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14671,14700);

return f_1189_14678_14699(_command);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,14609,14813);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,14609,14813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,14782,14794);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,14609,14813);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,14573,14828);

System.Management.Automation.InvocationInfo
f_1189_14678_14699(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 14678, 14699);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,14512,14839);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,14512,14839);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool PassThru {get; set; }

internal PSDriveInfo Drive {get; set; }

internal PSCredential Credential
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,15560,15910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15596,15631);

PSCredential 
result = _credentials
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15733,15861) || true) && (_credentials == null &&(DynAbs.Tracing.TraceSender.Expression_True(1189, 15737, 15774)&&f_1189_15761_15766()!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,15733,15861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15816,15842);

result = f_1189_15825_15841(f_1189_15825_15830());
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,15733,15861);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,15881,15895);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,15560,15910);

System.Management.Automation.PSDriveInfo
f_1189_15761_15766()
{
var return_v = Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 15761, 15766);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1189_15825_15830()
{
var return_v = Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 15825, 15830);
return return_v;
}


System.Management.Automation.PSCredential
f_1189_15825_15841(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 15825, 15841);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,15503,15921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,15503,15921);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool UseTransaction
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,16155,16587);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16191,16539) || true) && ((_command != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1189, 16195, 16250)&&(f_1189_16218_16241(_command)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,16191,16539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16292,16368);

MshCommandRuntime 
mshRuntime = f_1189_16323_16346(_command)as MshCommandRuntime
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16392,16520) || true) && (mshRuntime != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,16392,16520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16464,16497);

return f_1189_16471_16496(mshRuntime);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,16392,16520);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,16191,16539);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16559,16572);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,16155,16587);

System.Management.Automation.ICommandRuntime
f_1189_16218_16241(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 16218, 16241);
return return_v;
}


System.Management.Automation.ICommandRuntime
f_1189_16323_16346(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.CommandRuntime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 16323, 16346);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1189_16471_16496(System.Management.Automation.MshCommandRuntime
this_param)
{
var return_v = this_param.UseTransaction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 16471, 16496);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,16102,16598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,16102,16598);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool TransactionAvailable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,16725,16932);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16784,16892) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,16784,16892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16838,16877);

return f_1189_16845_16876(_command);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,16784,16892);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,16908,16921);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,16725,16932);

bool
f_1189_16845_16876(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.TransactionAvailable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 16845, 16876);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,16725,16932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,16725,16932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public PSTransactionContext CurrentPSTransaction
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,17227,17428);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17263,17381) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,17263,17381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17325,17362);

return f_1189_17332_17361(_command);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,17263,17381);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17401,17413);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,17227,17428);

System.Management.Automation.PSTransactionContext
f_1189_17332_17361(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.CurrentPSTransaction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 17332, 17361);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,17154,17439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,17154,17439);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal SwitchParameter Force
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,17667,17689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17673,17687);

return _force;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,17667,17689);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,17612,17739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,17612,17739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,17705,17728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,17711,17726);

_force = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,17705,17728);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,17612,17739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,17612,17739);
}
		}}

internal string Filter {get; set; }

internal Collection<string> Include {get; private set; }

internal Collection<string> Exclude {get; private set; }

public bool SuppressWildcardExpansion {get; internal set; }

internal bool ShouldProcess(
            string target)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,19555,19819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,19636,19655);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,19669,19778) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,19669,19778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,19723,19763);

result = f_1189_19732_19762(_command, target);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,19669,19778);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,19794,19808);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,19555,19819);

bool
f_1189_19732_19762(System.Management.Automation.Cmdlet
this_param,string
target)
{
var return_v = this_param.ShouldProcess( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 19732, 19762);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,19555,19819);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,19555,19819);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ShouldProcess(
            string target,
            string action)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,20533,20833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,20642,20661);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,20675,20792) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,20675,20792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,20729,20777);

result = f_1189_20738_20776(_command, target, action);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,20675,20792);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,20808,20822);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,20533,20833);

bool
f_1189_20738_20776(System.Management.Automation.Cmdlet
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 20738, 20776);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,20533,20833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,20533,20833);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ShouldProcess(
            string verboseDescription,
            string verboseWarning,
            string caption)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,22181,22623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,22339,22358);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,22372,22582) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,22372,22582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,22426,22567);

result = f_1189_22435_22566(_command, verboseDescription, verboseWarning, caption);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,22372,22582);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,22598,22612);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,22181,22623);

bool
f_1189_22435_22566(System.Management.Automation.Cmdlet
this_param,string
verboseDescription,string
verboseWarning,string
caption)
{
var return_v = this_param.ShouldProcess( verboseDescription, verboseWarning, caption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 22435, 22566);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,22181,22623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,22181,22623);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ShouldProcess(
            string verboseDescription,
            string verboseWarning,
            string caption,
            out ShouldProcessReason shouldProcessReason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,24270,24929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,24486,24505);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,24519,24888) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,24519,24888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,24573,24760);

result = f_1189_24582_24759(_command, verboseDescription, verboseWarning, caption, out shouldProcessReason);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,24519,24888);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,24519,24888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,24826,24873);

shouldProcessReason = ShouldProcessReason.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,24519,24888);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,24904,24918);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,24270,24929);

bool
f_1189_24582_24759(System.Management.Automation.Cmdlet
this_param,string
verboseDescription,string
verboseWarning,string
caption,out System.Management.Automation.ShouldProcessReason
shouldProcessReason)
{
var return_v = this_param.ShouldProcess( verboseDescription, verboseWarning, caption, out shouldProcessReason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 24582, 24759);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,24270,24929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,24270,24929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ShouldContinue(
            string query,
            string caption)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,25519,25821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,25629,25648);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,25662,25780) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,25662,25780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,25716,25765);

result = f_1189_25725_25764(_command, query, caption);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,25662,25780);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,25796,25810);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,25519,25821);

bool
f_1189_25725_25764(System.Management.Automation.Cmdlet
this_param,string
query,string
caption)
{
var return_v = this_param.ShouldContinue( query, caption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 25725, 25764);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,25519,25821);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,25519,25821);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ShouldContinue(
            string query,
            string caption,
            ref bool yesToAll,
            ref bool noToAll)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,26643,27174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,26816,26835);

bool 
result = true
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,26849,27133) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,26849,27133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,26903,27001);

result = f_1189_26912_27000(_command, query, caption, ref yesToAll, ref noToAll);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,26849,27133);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,26849,27133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,27067,27084);

yesToAll = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,27102,27118);

noToAll = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,26849,27133);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,27149,27163);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,26643,27174);

bool
f_1189_26912_27000(System.Management.Automation.Cmdlet
this_param,string
query,string
caption,ref bool
yesToAll,ref bool
noToAll)
{
var return_v = this_param.ShouldContinue( query, caption, ref yesToAll, ref noToAll);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 26912, 27000);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,26643,27174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,26643,27174);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void WriteVerbose(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,27390,27562);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,27454,27551) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,27454,27551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,27508,27536);

f_1189_27508_27535(                _command, text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,27454,27551);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,27390,27562);

int
f_1189_27508_27535(System.Management.Automation.Cmdlet
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 27508, 27535);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,27390,27562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,27390,27562);
}
		}

internal void WriteWarning(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,27778,27950);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,27842,27939) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,27842,27939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,27896,27924);

f_1189_27896_27923(                _command, text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,27842,27939);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,27778,27950);

int
f_1189_27896_27923(System.Management.Automation.Cmdlet
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 27896, 27923);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,27778,27950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,27778,27950);
}
		}

internal void WriteProgress(ProgressRecord record)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,27962,28148);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28037,28137) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,28037,28137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28091,28122);

f_1189_28091_28121(                _command, record);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,28037,28137);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,27962,28148);

int
f_1189_28091_28121(System.Management.Automation.Cmdlet
this_param,System.Management.Automation.ProgressRecord
progressRecord)
{
this_param.WriteProgress( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 28091, 28121);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,27962,28148);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,27962,28148);
}
		}

internal void WriteDebug(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,28348,28516);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28410,28505) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,28410,28505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28464,28490);

f_1189_28464_28489(                _command, text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,28410,28505);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,28348,28516);

int
f_1189_28464_28489(System.Management.Automation.Cmdlet
this_param,string
text)
{
this_param.WriteDebug( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 28464, 28489);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,28348,28516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,28348,28516);
}
		}

internal void WriteInformation(InformationRecord record)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,28528,28723);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28609,28712) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,28609,28712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28663,28697);

f_1189_28663_28696(                _command, record);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,28609,28712);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,28528,28723);

int
f_1189_28663_28696(System.Management.Automation.Cmdlet
this_param,System.Management.Automation.InformationRecord
informationRecord)
{
this_param.WriteInformation( informationRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 28663, 28696);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,28528,28723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,28528,28723);
}
		}

internal void WriteInformation(object messageData, string[] tags)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,28735,28950);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28825,28939) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,28825,28939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,28879,28924);

f_1189_28879_28923(                _command, messageData, tags);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,28825,28939);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,28735,28950);

int
f_1189_28879_28923(System.Management.Automation.Cmdlet
this_param,object
messageData,string[]
tags)
{
this_param.WriteInformation( messageData, tags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 28879, 28923);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,28735,28950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,28735,28950);
}
		}

internal void SetFilters(Collection<string> include, Collection<string> exclude, string filter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,29677,29888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,29797,29815);

Include = include;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,29829,29847);

Exclude = exclude;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,29861,29877);

Filter = filter;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,29677,29888);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,29677,29888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,29677,29888);
}
		}

internal Collection<PSObject> GetAccumulatedObjects()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,30223,30539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,30348,30399);

Collection<PSObject> 
results = _accumulatedObjects
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,30413,30462);

_accumulatedObjects = f_1189_30435_30461();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,30513,30528);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,30223,30539);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1189_30435_30461()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 30435, 30461);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,30223,30539);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,30223,30539);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<ErrorRecord> GetAccumulatedErrorObjects()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,30879,31219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,31012,31071);

Collection<ErrorRecord> 
results = _accumulatedErrorObjects
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,31085,31142);

_accumulatedErrorObjects = f_1189_31112_31141();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,31193,31208);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,30879,31219);

System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1189_31112_31141()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 31112, 31141);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,30879,31219);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,30879,31219);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ThrowFirstErrorOrDoNothing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,31562,31673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,31629,31662);

f_1189_31629_31661(this, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,31562,31673);

int
f_1189_31629_31661(System.Management.Automation.CmdletProviderContext
this_param,bool
wrapExceptionInProviderException)
{
this_param.ThrowFirstErrorOrDoNothing( wrapExceptionInProviderException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 31629, 31661);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,31562,31673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,31562,31673);
}
		}

internal void ThrowFirstErrorOrDoNothing(bool wrapExceptionInProviderException)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,32585,34046);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,32689,34035) || true) && (f_1189_32693_32704(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,32689,34035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,32738,32800);

Collection<ErrorRecord> 
errors = f_1189_32771_32799(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,32820,34020) || true) && (errors != null &&(DynAbs.Tracing.TraceSender.Expression_True(1189, 32824, 32858)&&f_1189_32842_32854(errors)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,32820,34020);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,32952,34001) || true) && (wrapExceptionInProviderException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,32952,34001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,33038,33071);

ProviderInfo 
providerInfo = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,33097,33265) || true) && (f_1189_33101_33122(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,33097,33265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,33188,33238);

providerInfo = f_1189_33203_33237(f_1189_33203_33224(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,33097,33265);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,33293,33478);

ProviderInvocationException 
e =
f_1189_33354_33477(providerInfo, f_1189_33467_33476(errors, 0))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,33564,33818);

f_1189_33564_33817(f_1189_33624_33645(this), (DynAbs.Tracing.TraceSender.Conditional_F1(1189, 33676, 33696)||((                            providerInfo != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1189, 33699, 33716))||DynAbs.Tracing.TraceSender.Conditional_F3(1189, 33719, 33737)))?f_1189_33699_33716(providerInfo):"unknown provider", e, Severity.Warning);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,33846,33854);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,32952,34001);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,32952,34001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,33952,33978);

throw f_1189_33958_33977(f_1189_33958_33967(errors, 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,32952,34001);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,32820,34020);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,32689,34035);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,32585,34046);

bool
f_1189_32693_32704(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.HasErrors();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 32693, 32704);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1189_32771_32799(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedErrorObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 32771, 32799);
return return_v;
}


int
f_1189_32842_32854(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 32842, 32854);
return return_v;
}


System.Management.Automation.Provider.CmdletProvider
f_1189_33101_33122(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ProviderInstance ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33101, 33122);
return return_v;
}


System.Management.Automation.Provider.CmdletProvider
f_1189_33203_33224(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ProviderInstance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33203, 33224);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1189_33203_33237(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33203, 33237);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1189_33467_33476(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33467, 33476);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1189_33354_33477(System.Management.Automation.ProviderInfo
provider,System.Management.Automation.ErrorRecord
errorRecord)
{
var return_v = new System.Management.Automation.ProviderInvocationException( provider, errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 33354, 33477);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_33624_33645(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33624, 33645);
return return_v;
}


string
f_1189_33699_33716(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33699, 33716);
return return_v;
}


int
f_1189_33564_33817(System.Management.Automation.ExecutionContext
executionContext,string
providerName,System.Management.Automation.ProviderInvocationException
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogProviderHealthEvent( executionContext, providerName, (System.Exception)exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 33564, 33817);
return 0;
}


System.Management.Automation.ErrorRecord
f_1189_33958_33967(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33958, 33967);
return return_v;
}


System.Exception
f_1189_33958_33977(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 33958, 33977);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,32585,34046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,32585,34046);
}
		}

internal void WriteErrorsToContext(CmdletProviderContext errorContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,34444,34926);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,34539,34673) || true) && (errorContext == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,34539,34673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,34597,34658);

throw f_1189_34603_34657("errorContext");
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,34539,34673);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,34689,34915) || true) && (f_1189_34693_34704(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,34689,34915);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,34738,34900);
foreach(ErrorRecord errorRecord in f_1189_34774_34802_I(f_1189_34774_34802(this)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,34738,34900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,34844,34881);

f_1189_34844_34880(                    errorContext, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,34738,34900);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1189,1,163);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1189,1,163);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1189,34689,34915);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,34444,34926);

System.Management.Automation.PSArgumentNullException
f_1189_34603_34657(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 34603, 34657);
return return_v;
}


bool
f_1189_34693_34704(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.HasErrors();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 34693, 34704);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1189_34774_34802(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.GetAccumulatedErrorObjects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 34774, 34802);
return return_v;
}


int
f_1189_34844_34880(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 34844, 34880);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1189_34774_34802_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 34774, 34802);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,34444,34926);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,34444,34926);
}
		}

internal void WriteObject(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,36112,37747);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,36328,36520) || true) && (f_1189_36332_36340())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,36328,36520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,36374,36466);

PipelineStoppedException 
stopPipeline =
f_1189_36435_36465()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,36486,36505);

throw stopPipeline;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,36328,36520);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,36536,37736) || true) && (f_1189_36540_36548())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,36536,37736);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,36582,37291) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,36582,37291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,36644,36694);

f_1189_36644_36693(                    s_tracer, "Writing to command pipeline");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,36843,36869);

f_1189_36843_36868(
                    // Since there was no writeObject handler use
                    // the command WriteObject method.

                    _command, obj);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,36582,37291);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,36582,37291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,37067,37242);

InvalidOperationException 
e =
f_1189_37122_37241(f_1189_37195_37240())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,37264,37272);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,36582,37291);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,36536,37736);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,36536,37736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,37357,37410);

f_1189_37357_37409(                s_tracer, "Writing to accumulated objects");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,37530,37573);

PSObject 
newObj = f_1189_37548_37572(obj)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,37689,37721);

f_1189_37689_37720(
                // Since we are not streaming, just add the object to the accumulatedObjects

                _accumulatedObjects, newObj);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,36536,37736);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,36112,37747);

bool
f_1189_36332_36340()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 36332, 36340);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_1189_36435_36465()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 36435, 36465);
return return_v;
}


bool
f_1189_36540_36548()
{
var return_v = PassThru;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 36540, 36548);
return return_v;
}


int
f_1189_36644_36693(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 36644, 36693);
return 0;
}


int
f_1189_36843_36868(System.Management.Automation.Cmdlet
this_param,object
sendToPipeline)
{
this_param.WriteObject( sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 36843, 36868);
return 0;
}


string
f_1189_37195_37240()
{
var return_v =                             SessionStateStrings.OutputStreamingNotEnabled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 37195, 37240);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1189_37122_37241(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 37122, 37241);
return return_v;
}


int
f_1189_37357_37409(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 37357, 37409);
return 0;
}


System.Management.Automation.PSObject
f_1189_37548_37572(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 37548, 37572);
return return_v;
}


int
f_1189_37689_37720(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 37689, 37720);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,36112,37747);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,36112,37747);
}
		}

internal void WriteError(ErrorRecord errorRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,38464,40254);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,38691,38883) || true) && (f_1189_38695_38703())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,38691,38883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,38737,38829);

PipelineStoppedException 
stopPipeline =
f_1189_38798_38828()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,38849,38868);

throw stopPipeline;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,38691,38883);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,38899,40243) || true) && (_streamErrors)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,38899,40243);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,38950,39440) || true) && (_command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,38950,39440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39012,39078);

f_1189_39012_39077(                    s_tracer, "Writing error package to command error pipe");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39102,39135);

f_1189_39102_39134(
                    _command, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,38950,39440);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,38950,39440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39217,39391);

InvalidOperationException 
e =
f_1189_39272_39390(f_1189_39345_39389())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39413,39421);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,38950,39440);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,38899,40243);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,38899,40243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39605,39647);

f_1189_39605_39646(                // Since we are not streaming, just add the object to the accumulatedErrorObjects
                _accumulatedErrorObjects, errorRecord);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39667,40228) || true) && (f_1189_39671_39695(errorRecord)!= null
&&(DynAbs.Tracing.TraceSender.Expression_True(1189, 39671, 39776)&&f_1189_39728_39768(f_1189_39728_39752(errorRecord))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,39667,40228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39818,39887);

Exception 
textLookupError = f_1189_39846_39886(f_1189_39846_39870(errorRecord))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39909,39957);

f_1189_39909_39933(errorRecord).TextLookupError = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,39979,40209);

f_1189_39979_40208(f_1189_40035_40056(this), f_1189_40083_40122(f_1189_40083_40117(f_1189_40083_40104(this))), textLookupError, Severity.Warning);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,39667,40228);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,38899,40243);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,38464,40254);

bool
f_1189_38695_38703()
{
var return_v = Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 38695, 38703);
return return_v;
}


System.Management.Automation.PipelineStoppedException
f_1189_38798_38828()
{
var return_v = new System.Management.Automation.PipelineStoppedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 38798, 38828);
return return_v;
}


int
f_1189_39012_39077(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 39012, 39077);
return 0;
}


int
f_1189_39102_39134(System.Management.Automation.Cmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 39102, 39134);
return 0;
}


string
f_1189_39345_39389()
{
var return_v =                             SessionStateStrings.ErrorStreamingNotEnabled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 39345, 39389);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1189_39272_39390(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 39272, 39390);
return return_v;
}


int
f_1189_39605_39646(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 39605, 39646);
return 0;
}


System.Management.Automation.ErrorDetails
f_1189_39671_39695(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 39671, 39695);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1189_39728_39752(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 39728, 39752);
return return_v;
}


System.Exception
f_1189_39728_39768(System.Management.Automation.ErrorDetails
this_param)
{
var return_v = this_param.TextLookupError ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 39728, 39768);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1189_39846_39870(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 39846, 39870);
return return_v;
}


System.Exception
f_1189_39846_39886(System.Management.Automation.ErrorDetails
this_param)
{
var return_v = this_param.TextLookupError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 39846, 39886);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1189_39909_39933(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 39909, 39933);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_40035_40056(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 40035, 40056);
return return_v;
}


System.Management.Automation.Provider.CmdletProvider
f_1189_40083_40104(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ProviderInstance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 40083, 40104);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1189_40083_40117(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 40083, 40117);
return return_v;
}


string
f_1189_40083_40122(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 40083, 40122);
return return_v;
}


int
f_1189_39979_40208(System.Management.Automation.ExecutionContext
executionContext,string
providerName,System.Exception
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogProviderHealthEvent( executionContext, providerName, exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 39979, 40208);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,38464,40254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,38464,40254);
}
		}

internal bool HasErrors()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,40628,40767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,40678,40756);

return _accumulatedErrorObjects != null &&(DynAbs.Tracing.TraceSender.Expression_True(1189, 40685, 40755)&&f_1189_40721_40751(_accumulatedErrorObjects)> 0);
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,40628,40767);

int
f_1189_40721_40751(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 40721, 40751);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,40628,40767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,40628,40767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,41011,41632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41066,41082);

Stopping = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41098,41411) || true) && (_providerInstance != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,41098,41411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41361,41396);

f_1189_41361_41395(                // We don't need to catch any of the exceptions here because
                // we are terminating the pipeline and any exception will
                // be caught by the engine.

                _providerInstance);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,41098,41411);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41476,41621);
foreach(CmdletProviderContext referralContext in f_1189_41526_41539_I(f_1189_41526_41539()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1189,41476,41621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,41573,41606);

f_1189_41573_41605(                referralContext);
DynAbs.Tracing.TraceSender.TraceExitCondition(1189,41476,41621);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1189,1,146);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1189,1,146);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1189,41011,41632);

int
f_1189_41361_41395(System.Management.Automation.Provider.CmdletProvider
this_param)
{
this_param.StopProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 41361, 41395);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
f_1189_41526_41539()
{
var return_v = StopReferrals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 41526, 41539);
return return_v;
}


int
f_1189_41573_41605(System.Management.Automation.CmdletProviderContext
this_param)
{
this_param.StopProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 41573, 41605);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
f_1189_41526_41539_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 41526, 41539);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,41011,41632);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,41011,41632);
}
		}

internal bool Stopping {get; private set; }

internal Collection<CmdletProviderContext> StopReferrals {get; }

internal bool HasIncludeOrExclude
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1189,42026,42192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,42062,42177);

return ((f_1189_42071_42078()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1189, 42071, 42107)&&f_1189_42090_42103(f_1189_42090_42097())> 0)) ||(DynAbs.Tracing.TraceSender.Expression_False(1189, 42070, 42175)||                        (f_1189_42138_42145()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1189, 42138, 42174)&&f_1189_42157_42170(f_1189_42157_42164())> 0))));
DynAbs.Tracing.TraceSender.TraceExitMethod(1189,42026,42192);

System.Collections.ObjectModel.Collection<string>
f_1189_42071_42078()
{
var return_v = Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 42071, 42078);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1189_42090_42097()
{
var return_v = Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 42090, 42097);
return return_v;
}


int
f_1189_42090_42103(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 42090, 42103);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1189_42138_42145()
{
var return_v = Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 42138, 42145);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1189_42157_42164()
{
var return_v = Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 42157, 42164);
return return_v;
}


int
f_1189_42157_42170(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 42157, 42170);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1189,41968,42203);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,41968,42203);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static CmdletProviderContext()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1189,963,42247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1189,1415,1561);
s_tracer = f_1189_1439_1561("CmdletProviderContext", "The context under which a core command is being run.");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1189,963,42247);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1189,963,42247);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1189,963,42247);

static System.Management.Automation.PSTraceSource
f_1189_1439_1561(string
name,string
description)
{
var return_v = Dbg.PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 1439, 1561);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1189_2190_2248(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 2190, 2248);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1189_2384_2419(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 2384, 2419);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1189_2384_2432(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 2384, 2432);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1189_2452_2492(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.CurrentCommandProcessor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 2452, 2492);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1189_2523_2563(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.CurrentCommandProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 2523, 2563);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1189_2523_2571(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 2523, 2571);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1189_2635_2675(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.CurrentCommandProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 2635, 2675);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1189_2635_2683(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 2635, 2683);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1189_3401_3459(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 3401, 3459);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1189_4636_4685(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 4636, 4685);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1189_4759_4780(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.CommandOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 4759, 4780);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1189_4946_4958(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 4946, 4958);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1189_5006_5056(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 5006, 5056);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_5092_5107(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.Context ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 5092, 5107);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1189_5155_5208(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 5155, 5208);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_5259_5274(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 5259, 5274);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1189_6353_6402(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 6353, 6402);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1189_6476_6497(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.CommandOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 6476, 6497);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1189_6633_6645(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 6633, 6645);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1189_6693_6743(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 6693, 6743);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_6779_6794(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.Context ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 6779, 6794);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1189_6842_6895(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 6842, 6895);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_6946_6961(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 6946, 6961);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1189_7870_7919(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 7870, 7919);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1189_7993_8014(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.CommandOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 7993, 8014);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_8035_8050(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.Context ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 8035, 8050);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1189_8098_8151(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 8098, 8151);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_8202_8217(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 8202, 8217);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1189_9095_9154(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 9095, 9154);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1189_9205_9239(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9205, 9239);
return return_v;
}


System.Management.Automation.PSCredential
f_1189_9314_9342(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9314, 9342);
return return_v;
}


System.Management.Automation.PSCredential
f_1189_9399_9427(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9399, 9427);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1189_9467_9490(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9467, 9490);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1189_9514_9537(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9514, 9537);
return return_v;
}


int
f_1189_9552_9587(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.CmdletProviderContext
context)
{
this_param.CopyFilters( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 9552, 9587);
return 0;
}


bool
f_1189_9630_9673(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.SuppressWildcardExpansion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9630, 9673);
return return_v;
}


object
f_1189_9708_9743(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.DynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9708, 9743);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1189_9767_9791(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Origin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9767, 9791);
return return_v;
}


bool
f_1189_9942_9968(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 9942, 9968);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
f_1189_10079_10110(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.StopReferrals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 10079, 10110);
return return_v;
}


int
f_1189_10079_10120(System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
this_param,System.Management.Automation.CmdletProviderContext
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 10079, 10120);
return 0;
}


System.Management.Automation.PSCredential
f_1189_10650_10668()
{
var return_v = PSCredential.Empty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1189, 10650, 10668);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1189_12085_12111()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 12085, 12111);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1189_12384_12413()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 12384, 12413);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>
f_1189_41916_41955()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletProviderContext>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1189, 41916, 41955);
return return_v;
}

}
}

