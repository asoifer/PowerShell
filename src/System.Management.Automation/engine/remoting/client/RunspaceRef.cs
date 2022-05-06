// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
internal class RunspaceRef
{
private ObjectRef<Runspace> _runspaceRef;

private bool _stopInvoke;

private object _localSyncObject;

private static RobustConnectionProgress s_RCProgress ;

internal RunspaceRef(Runspace runspace)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1586,1191,1467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,904,916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,940,951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,977,993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1255,1313);

f_1586_1255_1312(runspace != null, "Expected runspace != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1327,1376);

_runspaceRef = f_1586_1342_1375(runspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1390,1410);

_stopInvoke = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1424,1456);

_localSyncObject = f_1586_1443_1455();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1586,1191,1467);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,1191,1467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,1191,1467);
}
		}

internal void Revert()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,1547,1733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1594,1616);

f_1586_1594_1615(            _runspaceRef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1638,1654);

            lock (_localSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1688,1707);

_stopInvoke = true;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,1547,1733);

int
f_1586_1594_1615(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
this_param.Revert();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 1594, 1615);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,1547,1733);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,1547,1733);
}
		}

internal Runspace Runspace
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,1866,1943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1902,1928);

return f_1586_1909_1927(_runspaceRef);
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,1866,1943);

System.Management.Automation.Runspaces.Runspace
f_1586_1909_1927(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 1909, 1927);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,1815,1954);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,1815,1954);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal Runspace OldRunspace
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,2020,2057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,2026,2055);

return f_1586_2033_2054(_runspaceRef);
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,2020,2057);

System.Management.Automation.Runspaces.Runspace
f_1586_2033_2054(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.OldValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 2033, 2054);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,1966,2068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,1966,2068);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool IsRunspaceOverridden
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,2223,2307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,2259,2292);

return f_1586_2266_2291(_runspaceRef);
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,2223,2307);

bool
f_1586_2266_2291(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.IsOverridden;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 2266, 2291);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,2164,2318);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,2164,2318);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSCommand ParsePsCommandUsingScriptBlock(string line, bool? useLocalScope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,2427,3978);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,2637,2684);

Runspace 
localRunspace = f_1586_2662_2683(_runspaceRef)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,2702,2760);

ExecutionContext 
context = f_1586_2729_2759(localRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,3090,3159);

RemoteRunspace 
remoteRunspace = f_1586_3122_3140(_runspaceRef)as RemoteRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,3177,3276);

bool 
isConfiguredLoopback = (DynAbs.Tracing.TraceSender.Conditional_F1(1586, 3205, 3229)||(((remoteRunspace != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1586, 3232, 3267))||DynAbs.Tracing.TraceSender.Conditional_F3(1586, 3270, 3275)))?f_1586_3232_3267(remoteRunspace):false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,3294,3418);

bool 
isTrustedInput = !isConfiguredLoopback &&(DynAbs.Tracing.TraceSender.Expression_True(1586, 3316, 3417)&&(f_1586_3342_3385(f_1586_3342_3372(localRunspace))== PSLanguageMode.FullLanguage))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,3494,3554);

ScriptBlock 
scriptBlock = f_1586_3520_3553(context, line)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,3572,3668);

PowerShell 
powerShell = f_1586_3596_3667(scriptBlock, context, isTrustedInput, useLocalScope, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,3686,3713);

return f_1586_3693_3712(powerShell);
            }
            catch (ScriptBlockToPowerShellNotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1586,3742,3824);
DynAbs.Tracing.TraceSender.TraceExitCatch(1586,3742,3824);
            }
            catch (RuntimeException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1586,3838,3892);
DynAbs.Tracing.TraceSender.TraceExitCatch(1586,3838,3892);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,3955,3967);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,2427,3978);

System.Management.Automation.Runspaces.Runspace
f_1586_2662_2683(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.OldValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 2662, 2683);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1586_2729_2759(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 2729, 2759);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_3122_3140(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 3122, 3140);
return return_v;
}


bool
f_1586_3232_3267(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.IsConfiguredLoopBack ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 3232, 3267);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1586_3342_3372(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 3342, 3372);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1586_3342_3385(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.LanguageMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 3342, 3385);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1586_3520_3553(System.Management.Automation.ExecutionContext
context,string
script)
{
var return_v = ScriptBlock.Create( context, script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 3520, 3553);
return return_v;
}


System.Management.Automation.PowerShell
f_1586_3596_3667(System.Management.Automation.ScriptBlock
this_param,System.Management.Automation.ExecutionContext
context,bool
isTrustedInput,bool?
useLocalScope,object[]
args)
{
var return_v = this_param.GetPowerShell( context, isTrustedInput, useLocalScope, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 3596, 3667);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_3693_3712(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 3693, 3712);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,2427,3978);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,2427,3978);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSCommand CreatePsCommand(string line, bool isScript, bool? useNewScope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,4069,4870);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,4252,4396) || true) && (f_1586_4256_4282_M(!this.IsRunspaceOverridden))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,4252,4396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,4316,4381);

return f_1586_4323_4380(this, line, isScript, useNewScope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,4252,4396);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,4467,4539);

PSCommand 
psCommand = f_1586_4489_4538(this, line, useNewScope)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,4626,4761) || true) && (psCommand == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,4626,4761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,4681,4746);

return f_1586_4688_4745(this, line, isScript, useNewScope);
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,4626,4761);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,4842,4859);

return psCommand;
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,4069,4870);

bool
f_1586_4256_4282_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 4256, 4282);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_4323_4380(System.Management.Automation.Remoting.RunspaceRef
this_param,string
line,bool
isScript,bool?
useNewScope)
{
var return_v = this_param.CreatePsCommandNotOverridden( line, isScript, useNewScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 4323, 4380);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_4489_4538(System.Management.Automation.Remoting.RunspaceRef
this_param,string
line,bool?
useLocalScope)
{
var return_v = this_param.ParsePsCommandUsingScriptBlock( line, useLocalScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 4489, 4538);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_4688_4745(System.Management.Automation.Remoting.RunspaceRef
this_param,string
line,bool
isScript,bool?
useNewScope)
{
var return_v = this_param.CreatePsCommandNotOverridden( line, isScript, useNewScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 4688, 4745);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,4069,4870);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,4069,4870);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSCommand CreatePsCommandNotOverridden(string line, bool isScript, bool? useNewScope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,5001,5810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5119,5155);

PSCommand 
command = f_1586_5139_5154()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5171,5768) || true) && (isScript)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,5171,5768);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5217,5451) || true) && (f_1586_5221_5241(useNewScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,5217,5451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5283,5326);

f_1586_5283_5325(                    command, line, f_1586_5307_5324(useNewScope));
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,5217,5451);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,5217,5451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5408,5432);

f_1586_5408_5431(                    command, line);
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,5217,5451);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,5171,5768);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,5171,5768);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5517,5753) || true) && (f_1586_5521_5541(useNewScope))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,5517,5753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5583,5627);

f_1586_5583_5626(                    command, line, f_1586_5608_5625(useNewScope));
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,5517,5753);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,5517,5753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5709,5734);

f_1586_5709_5733(                    command, line);
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,5517,5753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,5171,5768);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,5784,5799);

return command;
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,5001,5810);

System.Management.Automation.PSCommand
f_1586_5139_5154()
{
var return_v = new System.Management.Automation.PSCommand();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 5139, 5154);
return return_v;
}


bool
f_1586_5221_5241(bool?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 5221, 5241);
return return_v;
}


bool
f_1586_5307_5324(bool?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 5307, 5324);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_5283_5325(System.Management.Automation.PSCommand
this_param,string
script,bool
useLocalScope)
{
var return_v = this_param.AddScript( script, useLocalScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 5283, 5325);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_5408_5431(System.Management.Automation.PSCommand
this_param,string
script)
{
var return_v = this_param.AddScript( script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 5408, 5431);
return return_v;
}


bool
f_1586_5521_5541(bool?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 5521, 5541);
return return_v;
}


bool
f_1586_5608_5625(bool?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 5608, 5625);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_5583_5626(System.Management.Automation.PSCommand
this_param,string
cmdlet,bool
useLocalScope)
{
var return_v = this_param.AddCommand( cmdlet, useLocalScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 5583, 5626);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_5709_5733(System.Management.Automation.PSCommand
this_param,string
command)
{
var return_v = this_param.AddCommand( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 5709, 5733);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,5001,5810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,5001,5810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Pipeline CreatePipeline(string line, bool addToHistory, bool useNestedPipelines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,5899,9534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,6363,6388);

Pipeline 
pipeline = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,6512,7592) || true) && (f_1586_6516_6541(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,6512,7592);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,6657,6912) || true) && ((f_1586_6662_6680(_runspaceRef)is RemoteRunspace) &&(DynAbs.Tracing.TraceSender.Expression_True(1586, 6661, 6827)&&                    (!f_1586_6726_6752(line)&&(DynAbs.Tracing.TraceSender.Expression_True(1586, 6725, 6826)&&f_1586_6756_6826(f_1586_6770_6781(line), "exit", StringComparison.OrdinalIgnoreCase)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,6657,6912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,6869,6893);

line = "Exit-PSSession";
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,6657,6912);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,6932,6997);

PSCommand 
psCommand = f_1586_6954_6996(this, line, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,7015,7577) || true) && (psCommand != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,7015,7577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,7078,7334);

pipeline = (DynAbs.Tracing.TraceSender.Conditional_F1(1586, 7089, 7107)||((useNestedPipelines &&DynAbs.Tracing.TraceSender.Conditional_F2(1586, 7135, 7223))||DynAbs.Tracing.TraceSender.Conditional_F3(1586, 7251, 7333)))?f_1586_7135_7223(f_1586_7135_7153(_runspaceRef), f_1586_7175_7208(f_1586_7175_7196(f_1586_7175_7193(psCommand), 0)), addToHistory):f_1586_7251_7333(f_1586_7251_7269(_runspaceRef), f_1586_7285_7318(f_1586_7285_7306(f_1586_7285_7303(psCommand), 0)), addToHistory);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,7358,7384);

f_1586_7358_7383(f_1586_7358_7375(pipeline));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,7408,7558);
foreach(Command command in f_1586_7436_7454_I(f_1586_7436_7454(psCommand)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,7408,7558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,7504,7535);

f_1586_7504_7534(f_1586_7504_7521(pipeline), command);
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,7408,7558);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1586,1,151);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1586,1,151);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1586,7015,7577);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,6512,7592);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,7687,7946) || true) && (pipeline == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,7687,7946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,7741,7931);

pipeline = (DynAbs.Tracing.TraceSender.Conditional_F1(1586, 7752, 7770)||((useNestedPipelines &&DynAbs.Tracing.TraceSender.Conditional_F2(1586, 7794, 7853))||DynAbs.Tracing.TraceSender.Conditional_F3(1586, 7877, 7930)))?f_1586_7794_7853(f_1586_7794_7812(_runspaceRef), line, addToHistory):f_1586_7877_7930(f_1586_7877_7895(_runspaceRef), line, addToHistory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,7687,7946);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,8039,8098);

RemotePipeline 
remotePipeline = pipeline as RemotePipeline
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,8112,9443) || true) && (f_1586_8116_8141(this)&&(DynAbs.Tracing.TraceSender.Expression_True(1586, 8116, 8167)&&remotePipeline != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,8112,9443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,8201,8246);

PowerShell 
shell = f_1586_8220_8245(remotePipeline)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,8264,8518) || true) && (f_1586_8268_8290(shell)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,8264,8518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,8340,8499);

f_1586_8340_8362(shell).RCConnectionNotification +=
                        new EventHandler<PSConnectionRetryStatusEventArgs>(HandleRCConnectionNotification);
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,8264,8518);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,8618,9428);

f_1586_8618_8635(shell).DataAdded += (sender, eventArgs) =>
                {
                    RemoteRunspace remoteRunspace = _runspaceRef.Value as RemoteRunspace;
                    PSDataCollection<ErrorRecord> erBuffer = sender as PSDataCollection<ErrorRecord>;
                    if (remoteRunspace != null && erBuffer != null &&
                        remoteRunspace.RunspacePool.RemoteRunspacePoolInternal.Host != null)
                    {
                        Collection<ErrorRecord> erRecords = erBuffer.ReadAll();
                        foreach (var er in erRecords)
                        {
                            remoteRunspace.RunspacePool.RemoteRunspacePoolInternal.Host.UI.WriteErrorLine(er.ToString());
                        }
                    }
                };
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,8112,9443);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,9459,9491);

f_1586_9459_9490(
            pipeline, line);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,9507,9523);

return pipeline;
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,5899,9534);

bool
f_1586_6516_6541(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
var return_v = this_param.IsRunspaceOverridden;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 6516, 6541);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_6662_6680(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 6662, 6680);
return return_v;
}


bool
f_1586_6726_6752(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 6726, 6752);
return return_v;
}


string
f_1586_6770_6781(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 6770, 6781);
return return_v;
}


bool
f_1586_6756_6826(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 6756, 6826);
return return_v;
}


System.Management.Automation.PSCommand
f_1586_6954_6996(System.Management.Automation.Remoting.RunspaceRef
this_param,string
line,bool?
useLocalScope)
{
var return_v = this_param.ParsePsCommandUsingScriptBlock( line, useLocalScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 6954, 6996);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_7135_7153(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7135, 7153);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1586_7175_7193(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7175, 7193);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1586_7175_7196(System.Management.Automation.Runspaces.CommandCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7175, 7196);
return return_v;
}


string
f_1586_7175_7208(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.CommandText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7175, 7208);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1586_7135_7223(System.Management.Automation.Runspaces.Runspace
this_param,string
command,bool
addToHistory)
{
var return_v = this_param.CreateNestedPipeline( command, addToHistory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 7135, 7223);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_7251_7269(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7251, 7269);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1586_7285_7303(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7285, 7303);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1586_7285_7306(System.Management.Automation.Runspaces.CommandCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7285, 7306);
return return_v;
}


string
f_1586_7285_7318(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.CommandText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7285, 7318);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1586_7251_7333(System.Management.Automation.Runspaces.Runspace
this_param,string
command,bool
addToHistory)
{
var return_v = this_param.CreatePipeline( command, addToHistory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 7251, 7333);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1586_7358_7375(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7358, 7375);
return return_v;
}


int
f_1586_7358_7383(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 7358, 7383);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_1586_7436_7454(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7436, 7454);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1586_7504_7521(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7504, 7521);
return return_v;
}


int
f_1586_7504_7534(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 7504, 7534);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_1586_7436_7454_I(System.Management.Automation.Runspaces.CommandCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 7436, 7454);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_7794_7812(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7794, 7812);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1586_7794_7853(System.Management.Automation.Runspaces.Runspace
this_param,string
command,bool
addToHistory)
{
var return_v = this_param.CreateNestedPipeline( command, addToHistory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 7794, 7853);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_7877_7895(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 7877, 7895);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1586_7877_7930(System.Management.Automation.Runspaces.Runspace
this_param,string
command,bool
addToHistory)
{
var return_v = this_param.CreatePipeline( command, addToHistory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 7877, 7930);
return return_v;
}


bool
f_1586_8116_8141(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
var return_v = this_param.IsRunspaceOverridden ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 8116, 8141);
return return_v;
}


System.Management.Automation.PowerShell
f_1586_8220_8245(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.PowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 8220, 8245);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1586_8268_8290(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 8268, 8290);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1586_8340_8362(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 8340, 8362);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1586_8618_8635(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ErrorBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 8618, 8635);
return return_v;
}


int
f_1586_9459_9490(System.Management.Automation.Runspaces.Pipeline
this_param,string
historyString)
{
this_param.SetHistoryString( historyString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 9459, 9490);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,5899,9534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,5899,9534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Pipeline CreatePipeline()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,9623,9736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,9682,9725);

return f_1586_9689_9724(f_1586_9689_9707(_runspaceRef));
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,9623,9736);

System.Management.Automation.Runspaces.Runspace
f_1586_9689_9707(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 9689, 9707);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1586_9689_9724(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.CreatePipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 9689, 9724);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,9623,9736);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,9623,9736);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Pipeline CreateNestedPipeline()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,9832,9957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,9897,9946);

return f_1586_9904_9945(f_1586_9904_9922(_runspaceRef));
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,9832,9957);

System.Management.Automation.Runspaces.Runspace
f_1586_9904_9922(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 9904, 9922);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1586_9904_9945(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.CreateNestedPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 9904, 9945);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,9832,9957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,9832,9957);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Override(RemoteRunspace remoteRunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,10039,10225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,10117,10147);

bool 
isRunspacePushed = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,10161,10214);

f_1586_10161_10213(this, remoteRunspace, null, out isRunspacePushed);
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,10039,10225);

int
f_1586_10161_10213(System.Management.Automation.Remoting.RunspaceRef
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace,object
syncObject,out bool
isRunspacePushed)
{
this_param.Override( remoteRunspace, syncObject, out isRunspacePushed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 10161, 10213);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,10039,10225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,10039,10225);
}
		}

internal void Override(RemoteRunspace remoteRunspace, object syncObject, out bool isRunspacePushed)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,10554,13356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,10684,10700);
            lock (_localSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,10734,10754);

_stopInvoke = false;
            }

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,10821,11247) || true) && (syncObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,10821,11247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,10891,10901);
                    lock (syncObject)
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,10951,10989);

f_1586_10951_10988(                        _runspaceRef, remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11015,11039);

isRunspacePushed = true;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,10821,11247);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,10821,11247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11144,11182);

f_1586_11144_11181(                    _runspaceRef, remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11204,11228);

isRunspacePushed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,10821,11247);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11267,11482) || true) && ((f_1586_11272_11316(remoteRunspace)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,11267,11482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11456,11463);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,11267,11482);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11502,13162);
using(PowerShell 
powerShell = f_1586_11533_11552()
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11594,11631);

f_1586_11594_11630(                    powerShell, "Get-Command");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11653,11735);

f_1586_11653_11734(                    powerShell, "Name", new string[] { "Out-Default", "Exit-PSSession" });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11757,11798);

powerShell.Runspace = f_1586_11779_11797(_runspaceRef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,11822,11983);

bool 
isReleaseCandidateBackcompatibilityMode =
f_1586_11894_11939(f_1586_11894_11912(_runspaceRef))== RemotingConstants.ProtocolVersionWin7RC
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12005,12095);

powerShell.IsGetCommandMetadataSpecialPipeline = !isReleaseCandidateBackcompatibilityMode;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12117,12195);

int 
expectedNumberOfResults = (DynAbs.Tracing.TraceSender.Conditional_F1(1586, 12147, 12186)||((isReleaseCandidateBackcompatibilityMode &&DynAbs.Tracing.TraceSender.Conditional_F2(1586, 12189, 12190))||DynAbs.Tracing.TraceSender.Conditional_F3(1586, 12193, 12194)))?2 :3
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12219,12337);

f_1586_12219_12246(powerShell).HostCallReceived += new EventHandler<RemoteDataEventArgs<RemoteHostCall>>(HandleHostCall);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12361,12413);

IAsyncResult 
asyncResult = f_1586_12388_12412(powerShell)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12435,12505);

PSDataCollection<PSObject> 
results = f_1586_12472_12504()
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12529,12883) || true) && (!_stopInvoke)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,12529,12883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12598,12640);

f_1586_12598_12639(f_1586_12598_12625(asyncResult), 1000);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12668,12860) || true) && (f_1586_12672_12695(asyncResult))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,12668,12860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12753,12797);

results = f_1586_12763_12796(powerShell, asyncResult);
DynAbs.Tracing.TraceSender.TraceBreak(1586,12827,12833);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,12668,12860);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,12529,12883);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1586,12529,12883);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1586,12529,12883);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,12907,13143) || true) && (f_1586_12911_12941(f_1586_12911_12935(f_1586_12911_12929(powerShell)))> 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1586, 12911, 12988)||f_1586_12949_12962(results)< expectedNumberOfResults))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,12907,13143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,13038,13120);

throw f_1586_13044_13119();
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,12907,13143);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1586,11502,13162);
                }
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1586,13191,13345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,13241,13263);

f_1586_13241_13262(                _runspaceRef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,13281,13306);

isRunspacePushed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,13324,13330);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1586,13191,13345);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,10554,13356);

int
f_1586_10951_10988(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param,System.Management.Automation.RemoteRunspace
newValue)
{
this_param.Override( (System.Management.Automation.Runspaces.Runspace)newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 10951, 10988);
return 0;
}


int
f_1586_11144_11181(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param,System.Management.Automation.RemoteRunspace
newValue)
{
this_param.Override( (System.Management.Automation.Runspaces.Runspace)newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 11144, 11181);
return 0;
}


System.Management.Automation.Runspaces.Pipeline
f_1586_11272_11316(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetCurrentlyRunningPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 11272, 11316);
return return_v;
}


System.Management.Automation.PowerShell
f_1586_11533_11552()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 11533, 11552);
return return_v;
}


System.Management.Automation.PowerShell
f_1586_11594_11630(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 11594, 11630);
return return_v;
}


System.Management.Automation.PowerShell
f_1586_11653_11734(System.Management.Automation.PowerShell
this_param,string
parameterName,string[]
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 11653, 11734);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_11779_11797(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 11779, 11797);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1586_11894_11912(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 11894, 11912);
return return_v;
}


System.Version
f_1586_11894_11939(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.GetRemoteProtocolVersion();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 11894, 11939);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1586_12219_12246(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 12219, 12246);
return return_v;
}


System.IAsyncResult
f_1586_12388_12412(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.BeginInvoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 12388, 12412);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1586_12472_12504()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 12472, 12504);
return return_v;
}


System.Threading.WaitHandle
f_1586_12598_12625(System.IAsyncResult
this_param)
{
var return_v = this_param.AsyncWaitHandle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 12598, 12625);
return return_v;
}


bool
f_1586_12598_12639(System.Threading.WaitHandle
this_param,int
millisecondsTimeout)
{
var return_v = this_param.WaitOne( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 12598, 12639);
return return_v;
}


bool
f_1586_12672_12695(System.IAsyncResult
this_param)
{
var return_v = this_param.IsCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 12672, 12695);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1586_12763_12796(System.Management.Automation.PowerShell
this_param,System.IAsyncResult
asyncResult)
{
var return_v = this_param.EndInvoke( asyncResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 12763, 12796);
return return_v;
}


System.Management.Automation.PSDataStreams
f_1586_12911_12929(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Streams;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 12911, 12929);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1586_12911_12935(System.Management.Automation.PSDataStreams
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 12911, 12935);
return return_v;
}


int
f_1586_12911_12941(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 12911, 12941);
return return_v;
}


int
f_1586_12949_12962(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 12949, 12962);
return return_v;
}


System.Exception
f_1586_13044_13119()
{
var return_v = RemoteHostExceptions.NewRemoteRunspaceDoesNotSupportPushRunspaceException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 13044, 13119);
return return_v;
}


int
f_1586_13241_13262(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
this_param.Revert();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 13241, 13262);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,10554,13356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,10554,13356);
}
		}

private void HandleHostCall(object sender, RemoteDataEventArgs<RemoteHostCall> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,13504,13731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,13618,13720);

f_1586_13618_13719(sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,13504,13731);

int
f_1586_13618_13719(object
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
eventArgs)
{
System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell.ExitHandler( sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 13618, 13719);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,13504,13731);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,13504,13731);
}
		}

private void HandleRCConnectionNotification(object sender, PSConnectionRetryStatusEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,13788,14683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,13907,14672);

switch (f_1586_13915_13929(e))
            {

case PSConnectionRetryStatus.NetworkFailureDetected:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,13907,14672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,14037,14127);

f_1586_14037_14126(this, f_1586_14054_14074(sender), f_1586_14076_14090(e), (f_1586_14093_14117(e)/ 1000));
DynAbs.Tracing.TraceSender.TraceBreak(1586,14149,14155);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,13907,14672);

case PSConnectionRetryStatus.AutoDisconnectStarting:
                case PSConnectionRetryStatus.ConnectionRetrySucceeded:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,13907,14672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,14321,14359);

f_1586_14321_14358(this, f_1586_14337_14357(sender));
DynAbs.Tracing.TraceSender.TraceBreak(1586,14381,14387);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,13907,14672);

case PSConnectionRetryStatus.AutoDisconnectSucceeded:
                case PSConnectionRetryStatus.InternalErrorAbort:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,13907,14672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,14548,14569);

f_1586_14548_14568(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,14591,14629);

f_1586_14591_14628(this, f_1586_14607_14627(sender));
DynAbs.Tracing.TraceSender.TraceBreak(1586,14651,14657);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,13907,14672);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,13788,14683);

System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
f_1586_13915_13929(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
this_param)
{
var return_v = this_param.Notification;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 13915, 13929);
return return_v;
}


int
f_1586_14054_14074(object
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14054, 14074);
return return_v;
}


string
f_1586_14076_14090(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14076, 14090);
return return_v;
}


int
f_1586_14093_14117(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
this_param)
{
var return_v = this_param.MaxRetryConnectionTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14093, 14117);
return return_v;
}


int
f_1586_14037_14126(System.Management.Automation.Remoting.RunspaceRef
this_param,int
sourceId,string
computerName,int
totalSeconds)
{
this_param.StartProgressBar( (long)sourceId, computerName, totalSeconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14037, 14126);
return 0;
}


int
f_1586_14337_14357(object
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14337, 14357);
return return_v;
}


int
f_1586_14321_14358(System.Management.Automation.Remoting.RunspaceRef
this_param,int
sourceId)
{
this_param.StopProgressBar( (long)sourceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14321, 14358);
return 0;
}


int
f_1586_14548_14568(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
this_param.WriteRCFailedError();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14548, 14568);
return 0;
}


int
f_1586_14607_14627(object
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14607, 14627);
return return_v;
}


int
f_1586_14591_14628(System.Management.Automation.Remoting.RunspaceRef
this_param,int
sourceId)
{
this_param.StopProgressBar( (long)sourceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14591, 14628);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,13788,14683);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,13788,14683);
}
		}

private void WriteRCFailedError()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,14695,15243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,14753,14822);

RemoteRunspace 
remoteRunspace = f_1586_14785_14803(_runspaceRef)as RemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,14836,15232) || true) && (remoteRunspace != null &&(DynAbs.Tracing.TraceSender.Expression_True(1586, 14840, 14950)&&f_1586_14883_14942(f_1586_14883_14937(f_1586_14883_14910(remoteRunspace)))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,14836,15232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,14984,15217);

f_1586_14984_15216(f_1586_14984_15046(f_1586_14984_15043(f_1586_14984_15038(f_1586_14984_15011(remoteRunspace)))), f_1586_15084_15215(f_1586_15102_15149(), f_1586_15172_15214(f_1586_15172_15201(remoteRunspace))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,14836,15232);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,14695,15243);

System.Management.Automation.Runspaces.Runspace
f_1586_14785_14803(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14785, 14803);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1586_14883_14910(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14883, 14910);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1586_14883_14937(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14883, 14937);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1586_14883_14942(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14883, 14942);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1586_14984_15011(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14984, 15011);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1586_14984_15038(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14984, 15038);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1586_14984_15043(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14984, 15043);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1586_14984_15046(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 14984, 15046);
return return_v;
}


string
f_1586_15102_15149()
{
var return_v = RemotingErrorIdStrings.RCAutoDisconnectingError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 15102, 15149);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1586_15172_15201(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 15172, 15201);
return return_v;
}


string
f_1586_15172_15214(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 15172, 15214);
return return_v;
}


string
f_1586_15084_15215(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 15084, 15215);
return return_v;
}


int
f_1586_14984_15216(System.Management.Automation.Host.PSHostUserInterface
this_param,string
value)
{
this_param.WriteErrorLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 14984, 15216);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,14695,15243);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,14695,15243);
}
		}

private void StartProgressBar(
            long sourceId,
            string computerName,
            int totalSeconds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,15255,15783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,15403,15472);

RemoteRunspace 
remoteRunspace = f_1586_15435_15453(_runspaceRef)as RemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,15486,15772) || true) && (remoteRunspace != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1586,15486,15772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,15546,15757);

f_1586_15546_15756(                s_RCProgress, sourceId, computerName, totalSeconds, f_1586_15696_15755(f_1586_15696_15750(f_1586_15696_15723(remoteRunspace))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1586,15486,15772);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,15255,15783);

System.Management.Automation.Runspaces.Runspace
f_1586_15435_15453(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 15435, 15453);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1586_15696_15723(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 15696, 15723);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1586_15696_15750(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 15696, 15750);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1586_15696_15755(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1586, 15696, 15755);
return return_v;
}


int
f_1586_15546_15756(System.Management.Automation.Internal.RobustConnectionProgress
this_param,long
sourceId,string
computerName,int
secondsTotal,System.Management.Automation.Host.PSHost
psHost)
{
this_param.StartProgress( sourceId, computerName, secondsTotal, psHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 15546, 15756);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,15255,15783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,15255,15783);
}
		}

private void StopProgressBar(
            long sourceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1586,15795,15924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,15877,15913);

f_1586_15877_15912(            s_RCProgress, sourceId);
DynAbs.Tracing.TraceSender.TraceExitMethod(1586,15795,15924);

int
f_1586_15877_15912(System.Management.Automation.Internal.RobustConnectionProgress
this_param,long
sourceId)
{
this_param.StopProgress( sourceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 15877, 15912);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1586,15795,15924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,15795,15924);
}
		}

static RunspaceRef()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1586,759,15953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1586,1044,1089);
s_RCProgress = f_1586_1059_1089();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1586,759,15953);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1586,759,15953);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1586,759,15953);

static System.Management.Automation.Internal.RobustConnectionProgress
f_1586_1059_1089()
{
var return_v = new System.Management.Automation.Internal.RobustConnectionProgress();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 1059, 1089);
return return_v;
}


int
f_1586_1255_1312(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 1255, 1312);
return 0;
}


System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>
f_1586_1342_1375(System.Management.Automation.Runspaces.Runspace
oldValue)
{
var return_v = new System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Runspaces.Runspace>( oldValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 1342, 1375);
return return_v;
}


object
f_1586_1443_1455()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1586, 1443, 1455);
return return_v;
}

}
}
