// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Help;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.Get, "Help", DefaultParameterSetName = "AllUsersView", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096483")]
    public sealed class GetHelpCommand : PSCmdlet
{        /// <summary>
        /// Help Views.
        /// </summary>
        internal enum HelpView
        {
            Default = 0x00, // Default View
            DetailedView = 0x01,
            FullView = 0x02,
            ExamplesView = 0x03
        }

public GetHelpCommand()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1150,1299,1344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,1480,1639);
this.Name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,1765,1818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,1934,2256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,2283,2307);
this._provider = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,5079,5190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,5310,5370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,5494,5558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,5673,5728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6431,6446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6509,6539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6563,6573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,7278,7312);
this._viewTokenToAdd = HelpView.Default;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,7352,7376);
this._timer = f_1150_7361_7376();DynAbs.Tracing.TraceSender.TraceExitConstructor(1150,1299,1344);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,1299,1344);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,1299,1344);
}
		}

[Parameter(Position = 0, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty()]
        public string Name {get; set; }

[Parameter]
        public string Path {get; set; }

[Parameter]
        [ValidateSet(
            "Alias", "Cmdlet", "Provider", "General", "FAQ", "Glossary", "HelpFile", "ScriptCommand", "Function", "Filter", "ExternalScript", "All", "DefaultHelp", "DscResource", "Class", "Configuration",
             IgnoreCase = true)]
        public string[] Category {get; set; }

private string _provider ;

[Parameter(ParameterSetName = "DetailedView", Mandatory = true)]
        public SwitchParameter Detailed
{
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,2999,3169);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,3035,3154) || true) && (value.ToBool())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,3035,3154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,3095,3135);

_viewTokenToAdd = HelpView.DetailedView;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,3035,3154);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,2999,3169);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,2869,3180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,2869,3180);
}
		}}

[Parameter(ParameterSetName = "AllUsersView")]
        public SwitchParameter Full
{
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,3849,4015);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,3885,4000) || true) && (value.ToBool())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,3885,4000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,3945,3981);

_viewTokenToAdd = HelpView.FullView;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,3885,4000);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,3849,4015);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,3741,4026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,3741,4026);
}
		}}

[Parameter(ParameterSetName = "Examples", Mandatory = true)]
        public SwitchParameter Examples
{
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,4686,4856);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,4722,4841) || true) && (value.ToBool())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,4722,4841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,4782,4822);

_viewTokenToAdd = HelpView.ExamplesView;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,4722,4841);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,4686,4856);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,4560,4867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,4560,4867);
}
		}}

[Parameter(ParameterSetName = "Parameters", Mandatory = true)]
        public string[] Parameter {get; set; }

[Parameter]
        public string[] Component {get; set; }

[Parameter]
        public string[] Functionality {get; set; }

[Parameter]
        public string[] Role {get; set; }

[Parameter(ParameterSetName = "Online", Mandatory = true)]
        public SwitchParameter Online
{
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,6075,6305);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6111,6135);

_showOnlineHelp = value;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6153,6290) || true) && (_showOnlineHelp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,6153,6290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6214,6271);

f_1150_6214_6270(this, "Online");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,6153,6290);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,6075,6305);

int
f_1150_6214_6270(Microsoft.PowerShell.Commands.GetHelpCommand
cmdlet,string
parameterName)
{
VerifyParameterForbiddenInRemoteRunspace( (System.Management.Automation.Cmdlet)cmdlet, parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 6214, 6270);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,5953,6406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,5953,6406);
}
		}
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,6321,6395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6357,6380);

return _showOnlineHelp;
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,6321,6395);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,5953,6406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,5953,6406);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _showOnlineHelp;

private GraphicalHostReflectionWrapper graphicalHostReflectionWrapper;

private bool showWindow;

[Parameter(ParameterSetName = "ShowWindow", Mandatory = true)]
        public SwitchParameter ShowWindow
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,6867,6936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6903,6921);

return showWindow;
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,6867,6936);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,6737,7187);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,6737,7187);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,6952,7176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,6988,7007);

showWindow = value;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,7025,7161) || true) && (showWindow)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,7025,7161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,7081,7142);

f_1150_7081_7141(this, "ShowWindow");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,7025,7161);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,6952,7176);

int
f_1150_7081_7141(Microsoft.PowerShell.Commands.GetHelpCommand
cmdlet,string
parameterName)
{
VerifyParameterForbiddenInRemoteRunspace( (System.Management.Automation.Cmdlet)cmdlet, parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 7081, 7141);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,6737,7187);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,6737,7187);
}
		}}

private HelpView _viewTokenToAdd ;

private readonly Stopwatch _timer ;

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,7643,7735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,7709,7724);

f_1150_7709_7723(            _timer);
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,7643,7735);

int
f_1150_7709_7723(System.Diagnostics.Stopwatch
this_param)
{
this_param.Start();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 7709, 7723);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,7643,7735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,7643,7735);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,7867,12585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,7931,7979);

HelpSystem 
helpSystem = f_1150_7955_7978(f_1150_7955_7967(this))
;
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8040,8288) || true) && (f_1150_8044_8059(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,8040,8288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8101,8269);

this.graphicalHostReflectionWrapper = f_1150_8139_8268(this, "Microsoft.PowerShell.Commands.Internal.HelpWindowHelper");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,8040,8288);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8314,8397);

helpSystem.OnProgress += new HelpSystem.HelpProgressHandler(HelpSystem_OnProgress);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8417,8437);

bool 
failed = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8455,8520);

HelpCategory 
helpCategory = f_1150_8483_8519(this, f_1150_8498_8506(), ref failed)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8540,8580) || true) && (failed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,8540,8580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8573,8580);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,8540,8580);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8646,8684);

f_1150_8646_8683(this, helpCategory);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8704,8771);

HelpRequest 
helpRequest = f_1150_8730_8770(f_1150_8746_8755(this), helpCategory)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8791,8824);

helpRequest.Provider = _provider;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8842,8876);

helpRequest.Component = f_1150_8866_8875();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8894,8918);

helpRequest.Role = f_1150_8913_8917();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8936,8978);

helpRequest.Functionality = f_1150_8964_8977();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,8996,9174);

helpRequest.ProviderContext = f_1150_9026_9173(f_1150_9068_9077(this), f_1150_9100_9127(f_1150_9100_9119(f_1150_9100_9112(this))), f_1150_9150_9172(f_1150_9150_9167(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,9192,9252);

helpRequest.CommandOrigin = f_1150_9220_9251(f_1150_9220_9237(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,9474,9540);

IEnumerable<HelpInfo> 
helpInfos = f_1150_9508_9539(helpSystem, helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,9774,9810);

HelpInfo 
firstHelpInfoObject = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,9828,9853);

int 
countOfHelpInfos = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,9871,10774);
foreach(HelpInfo helpInfo in f_1150_9901_9910_I(helpInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,9871,10774);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10000,10094) || true) && (f_1150_10004_10014())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,10000,10094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10064,10071);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,10000,10094);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10118,10712) || true) && (0 == countOfHelpInfos)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,10118,10712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10193,10224);

firstHelpInfoObject = helpInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,10118,10712);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,10118,10712);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10385,10615) || true) && (firstHelpInfoObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,10385,10615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10474,10531);

f_1150_10474_10530(this, firstHelpInfoObject, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10561,10588);

firstHelpInfoObject = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,10385,10615);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10643,10689);

f_1150_10643_10688(this, helpInfo, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,10118,10712);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10736,10755);

countOfHelpInfos++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,9871,10774);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,904);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,904);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,10794,10808);

f_1150_10794_10807(
                _timer);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,11145,11520) || true) && (1 == countOfHelpInfos)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,11145,11520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,11212,11268);

f_1150_11212_11267(this, firstHelpInfoObject, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,11145,11520);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,11145,11520);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,11310,11520) || true) && (_showOnlineHelp &&(DynAbs.Tracing.TraceSender.Expression_True(1150, 11314, 11355)&&(countOfHelpInfos > 1)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,11310,11520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,11397,11501);

throw f_1150_11403_11500(f_1150_11446_11489(), "Online");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,11310,11520);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,11145,11520);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,11638,12235) || true) && (((countOfHelpInfos == 0) &&(DynAbs.Tracing.TraceSender.Expression_True(1150, 11643, 11735)&&(!f_1150_11672_11734(f_1150_11715_11733(helpRequest)))))
||(DynAbs.Tracing.TraceSender.Expression_False(1150, 11642, 11789)||f_1150_11761_11789(helpSystem)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,11638,12235);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,11942,12216) || true) && (f_1150_11946_11973(f_1150_11946_11967(helpSystem))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,11942,12216);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12027,12193);
foreach(ErrorRecord errorRecord in f_1150_12063_12084_I(f_1150_12063_12084(helpSystem)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,12027,12193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12142,12166);

f_1150_12142_12165(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,12027,12193);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,167);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,167);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1150,11942,12216);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,11638,12235);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1150,12264,12574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12304,12387);

helpSystem.OnProgress -= new HelpSystem.HelpProgressHandler(HelpSystem_OnProgress);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12405,12429);

f_1150_12405_12428(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12519,12559);

f_1150_12519_12558(
                // finally clear the ScriptBlockAst -> Token[] cache
                helpSystem);
DynAbs.Tracing.TraceSender.TraceExitFinally(1150,12264,12574);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,7867,12585);

System.Management.Automation.ExecutionContext
f_1150_7955_7967(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 7955, 7967);
return return_v;
}


System.Management.Automation.HelpSystem
f_1150_7955_7978(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 7955, 7978);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1150_8044_8059(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.ShowWindow;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 8044, 8059);
return return_v;
}


System.Management.Automation.Internal.GraphicalHostReflectionWrapper
f_1150_8139_8268(Microsoft.PowerShell.Commands.GetHelpCommand
parentCmdlet,string
graphicalHostHelperTypeName)
{
var return_v = GraphicalHostReflectionWrapper.GetGraphicalHostReflectionWrapper( (System.Management.Automation.PSCmdlet)parentCmdlet, graphicalHostHelperTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 8139, 8268);
return return_v;
}


string[]
f_1150_8498_8506()
{
var return_v = Category;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 8498, 8506);
return return_v;
}


System.Management.Automation.HelpCategory
f_1150_8483_8519(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,string[]
category,ref bool
failed)
{
var return_v = this_param.ToHelpCategory( category, ref failed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 8483, 8519);
return return_v;
}


int
f_1150_8646_8683(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.HelpCategory
cat)
{
this_param.ValidateAndThrowIfError( cat);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 8646, 8683);
return 0;
}


string
f_1150_8746_8755(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 8746, 8755);
return return_v;
}


System.Management.Automation.HelpRequest
f_1150_8730_8770(string
target,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.HelpRequest( target, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 8730, 8770);
return return_v;
}


string[]
f_1150_8866_8875()
{
var return_v = Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 8866, 8875);
return return_v;
}


string[]
f_1150_8913_8917()
{
var return_v = Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 8913, 8917);
return return_v;
}


string[]
f_1150_8964_8977()
{
var return_v = Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 8964, 8977);
return return_v;
}


string
f_1150_9068_9077(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9068, 9077);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1150_9100_9112(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9100, 9112);
return return_v;
}


System.Management.Automation.AutomationEngine
f_1150_9100_9119(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.Engine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9100, 9119);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1150_9100_9127(System.Management.Automation.AutomationEngine
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9100, 9127);
return return_v;
}


System.Management.Automation.SessionState
f_1150_9150_9167(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9150, 9167);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1150_9150_9172(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9150, 9172);
return return_v;
}


System.Management.Automation.ProviderContext
f_1150_9026_9173(string
requestedPath,System.Management.Automation.ExecutionContext
executionContext,System.Management.Automation.PathIntrinsics
pathIntrinsics)
{
var return_v = new System.Management.Automation.ProviderContext( requestedPath, executionContext, pathIntrinsics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 9026, 9173);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1150_9220_9237(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9220, 9237);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1150_9220_9251(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.CommandOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 9220, 9251);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1150_9508_9539(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.GetHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 9508, 9539);
return return_v;
}


bool
f_1150_10004_10014()
{
var return_v = IsStopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 10004, 10014);
return return_v;
}


int
f_1150_10474_10530(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.HelpInfo
helpInfo,bool
showFullHelp)
{
this_param.WriteObjectsOrShowOnlineHelp( helpInfo, showFullHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 10474, 10530);
return 0;
}


int
f_1150_10643_10688(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.HelpInfo
helpInfo,bool
showFullHelp)
{
this_param.WriteObjectsOrShowOnlineHelp( helpInfo, showFullHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 10643, 10688);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1150_9901_9910_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 9901, 9910);
return return_v;
}


int
f_1150_10794_10807(System.Diagnostics.Stopwatch
this_param)
{
this_param.Stop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 10794, 10807);
return 0;
}


int
f_1150_11212_11267(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.HelpInfo
helpInfo,bool
showFullHelp)
{
this_param.WriteObjectsOrShowOnlineHelp( helpInfo, showFullHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 11212, 11267);
return 0;
}


string
f_1150_11446_11489()
{
var return_v = HelpErrors.MultipleOnlineTopicsNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 11446, 11489);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1150_11403_11500(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 11403, 11500);
return return_v;
}


string
f_1150_11715_11733(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 11715, 11733);
return return_v;
}


bool
f_1150_11672_11734(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 11672, 11734);
return return_v;
}


bool
f_1150_11761_11789(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.VerboseHelpErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 11761, 11789);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1150_11946_11967(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 11946, 11967);
return return_v;
}


int
f_1150_11946_11973(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 11946, 11973);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1150_12063_12084(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 12063, 12084);
return return_v;
}


int
f_1150_12142_12165(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 12142, 12165);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1150_12063_12084_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 12063, 12084);
return return_v;
}


int
f_1150_12405_12428(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
this_param.HelpSystem_OnComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 12405, 12428);
return 0;
}


int
f_1150_12519_12558(System.Management.Automation.HelpSystem
this_param)
{
this_param.ClearScriptBlockTokenCache();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 12519, 12558);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,7867,12585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,7867,12585);
}
		}

private HelpCategory ToHelpCategory(string[] category, ref bool failed)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,12597,13636);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12693,12781) || true) && (category == null ||(DynAbs.Tracing.TraceSender.Expression_False(1150, 12697, 12737)||f_1150_12717_12732(category)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,12693,12781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12756,12781);

return HelpCategory.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,12693,12781);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12797,12843);

HelpCategory 
helpCategory = HelpCategory.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12859,12874);

failed = false;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12899,12904);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12890,13589) || true) && (i < f_1150_12910_12925(category))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,12927,12930)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1150,12890,13589))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,12890,13589);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,13008,13094);

HelpCategory 
temp = (HelpCategory)f_1150_13042_13093(typeof(HelpCategory), category[i], true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,13118,13139);

helpCategory |= temp;
                }
                catch (ArgumentException argumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1150,13176,13574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,13260,13339);

Exception 
e = f_1150_13274_13338(category[i], argumentException)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,13361,13466);

ErrorRecord 
errorRecord = f_1150_13387_13465(e, "InvalidHelpCategory", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,13488,13517);

f_1150_13488_13516(                    this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,13541,13555);

failed = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1150,13176,13574);
                }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,700);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,700);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,13605,13625);

return helpCategory;
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,12597,13636);

int
f_1150_12717_12732(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 12717, 12732);
return return_v;
}


int
f_1150_12910_12925(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 12910, 12925);
return return_v;
}


object
f_1150_13042_13093(System.Type
enumType,string
value,bool
ignoreCase)
{
var return_v = Enum.Parse( enumType, value, ignoreCase);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 13042, 13093);
return return_v;
}


Microsoft.PowerShell.Commands.HelpCategoryInvalidException
f_1150_13274_13338(string
helpCategory,System.ArgumentException
innerException)
{
var return_v = new Microsoft.PowerShell.Commands.HelpCategoryInvalidException( helpCategory, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 13274, 13338);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1150_13387_13465(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 13387, 13465);
return return_v;
}


int
f_1150_13488_13516(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 13488, 13516);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,12597,13636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,12597,13636);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSObject TransformView(PSObject originalHelpObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,14232,16506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,14316,14413);

f_1150_14316_14412(originalHelpObject != null, "HelpObject should not be null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,14429,14653) || true) && (_viewTokenToAdd == HelpView.Default)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,14429,14653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,14502,14594);

f_1150_14502_14593(                s_tracer, "Detailed, Full, Examples are not selected. Constructing default view.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,14612,14638);

return originalHelpObject;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,14429,14653);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,14669,14716);

string 
tokenToAdd = f_1150_14689_14715(_viewTokenToAdd)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,14943,14995);

PSObject 
objectToReturn = f_1150_14969_14994(originalHelpObject)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15009,15042);

f_1150_15009_15041(f_1150_15009_15033(objectToReturn));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15058,16457) || true) && (f_1150_15062_15096(f_1150_15062_15090(originalHelpObject))== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,15058,16457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15135,15226);

string 
typeToAdd = f_1150_15154_15225(f_1150_15168_15196(), "HelpInfo#{0}", tokenToAdd)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15244,15284);

f_1150_15244_15283(f_1150_15244_15268(objectToReturn), typeToAdd);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,15058,16457);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,15058,16457);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15396,16141);
foreach(string typeName in f_1150_15424_15452_I(f_1150_15424_15452(originalHelpObject)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,15396,16141);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15652,15869) || true) && (f_1150_15656_15707(f_1150_15656_15683(typeName), "system.string")||(DynAbs.Tracing.TraceSender.Expression_False(1150, 15656, 15787)||f_1150_15736_15787(f_1150_15736_15763(                        typeName), "system.object")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,15652,15869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15837,15846);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,15652,15869);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,15893,15989);

string 
typeToAdd = f_1150_15912_15988(f_1150_15926_15954(), "{0}#{1}", typeName, tokenToAdd)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16011,16060);

f_1150_16011_16059(                    s_tracer, "Adding type {0}", typeToAdd);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16082,16122);

f_1150_16082_16121(f_1150_16082_16106(objectToReturn), typeToAdd);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,15396,16141);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,746);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,746);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16216,16442);
foreach(string typeName in f_1150_16244_16272_I(f_1150_16244_16272(originalHelpObject)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,16216,16442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16314,16362);

f_1150_16314_16361(                    s_tracer, "Adding type {0}", typeName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16384,16423);

f_1150_16384_16422(f_1150_16384_16408(objectToReturn), typeName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,16216,16442);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,227);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,227);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1150,15058,16457);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16473,16495);

return objectToReturn;
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,14232,16506);

int
f_1150_14316_14412(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 14316, 14412);
return 0;
}


int
f_1150_14502_14593(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 14502, 14593);
return 0;
}


string
f_1150_14689_14715(Microsoft.PowerShell.Commands.GetHelpCommand.HelpView
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 14689, 14715);
return return_v;
}


System.Management.Automation.PSObject
f_1150_14969_14994(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Copy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 14969, 14994);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1150_15009_15033(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 15009, 15033);
return return_v;
}


int
f_1150_15009_15041(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15009, 15041);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1150_15062_15090(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 15062, 15090);
return return_v;
}


int
f_1150_15062_15096(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 15062, 15096);
return return_v;
}


System.Globalization.CultureInfo
f_1150_15168_15196()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 15168, 15196);
return return_v;
}


string
f_1150_15154_15225(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15154, 15225);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1150_15244_15268(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 15244, 15268);
return return_v;
}


int
f_1150_15244_15283(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15244, 15283);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1150_15424_15452(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 15424, 15452);
return return_v;
}


string
f_1150_15656_15683(string
this_param)
{
var return_v = this_param.ToLowerInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15656, 15683);
return return_v;
}


bool
f_1150_15656_15707(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15656, 15707);
return return_v;
}


string
f_1150_15736_15763(string
this_param)
{
var return_v = this_param.ToLowerInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15736, 15763);
return return_v;
}


bool
f_1150_15736_15787(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15736, 15787);
return return_v;
}


System.Globalization.CultureInfo
f_1150_15926_15954()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 15926, 15954);
return return_v;
}


string
f_1150_15912_15988(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15912, 15988);
return return_v;
}


int
f_1150_16011_16059(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 16011, 16059);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1150_16082_16106(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 16082, 16106);
return return_v;
}


int
f_1150_16082_16121(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 16082, 16121);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1150_15424_15452_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 15424, 15452);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1150_16244_16272(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 16244, 16272);
return return_v;
}


int
f_1150_16314_16361(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 16314, 16361);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1150_16384_16408(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 16384, 16408);
return return_v;
}


int
f_1150_16384_16422(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 16384, 16422);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1150_16244_16272_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 16244, 16272);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,14232,16506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,14232,16506);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSObject[] GetParameterInfo(HelpInfo helpInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,16794,17270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16873,16946);

List<PSObject> 
parameterInfosList = f_1150_16909_16945(f_1150_16928_16944(f_1150_16928_16937()))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,16962,17207);
foreach(var parameter in f_1150_16988_16997_I(f_1150_16988_16997()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,16962,17207);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,17031,17192);
foreach(var parameterInfo in f_1150_17061_17093_I(f_1150_17061_17093(helpInfo, parameter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,17031,17192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,17135,17173);

f_1150_17135_17172(                    parameterInfosList, parameterInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,17031,17192);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,162);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,162);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1150,16962,17207);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,246);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,246);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,17223,17259);

return f_1150_17230_17258(parameterInfosList);
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,16794,17270);

string[]
f_1150_16928_16937()
{
var return_v = Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 16928, 16937);
return return_v;
}


int
f_1150_16928_16944(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 16928, 16944);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.PSObject>
f_1150_16909_16945(int
capacity)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 16909, 16945);
return return_v;
}


string[]
f_1150_16988_16997()
{
var return_v = Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 16988, 16997);
return return_v;
}


System.Management.Automation.PSObject[]
f_1150_17061_17093(System.Management.Automation.HelpInfo
this_param,string
pattern)
{
var return_v = this_param.GetParameter( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 17061, 17093);
return return_v;
}


int
f_1150_17135_17172(System.Collections.Generic.List<System.Management.Automation.PSObject>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 17135, 17172);
return 0;
}


System.Management.Automation.PSObject[]
f_1150_17061_17093_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 17061, 17093);
return return_v;
}


string[]
f_1150_16988_16997_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 16988, 16997);
return return_v;
}


System.Management.Automation.PSObject[]
f_1150_17230_17258(System.Collections.Generic.List<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 17230, 17258);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,16794,17270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,16794,17270);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void GetAndWriteParameterInfo(HelpInfo helpInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,17646,18406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,17727,17793);

f_1150_17727_17792(            s_tracer, "Searching parameters for {0}", f_1150_17778_17791(helpInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,17809,17856);

PSObject[] 
pInfos = f_1150_17829_17855(this, helpInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,17872,18395) || true) && ((pInfos == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1150, 17876, 17916)||(f_1150_17897_17910(pInfos)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,17872,18395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,17950,18082);

Exception 
innerException = f_1150_17977_18081("Parameter", f_1150_18046_18069(), f_1150_18071_18080())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,18100,18201);

f_1150_18100_18200(this, f_1150_18111_18199(innerException, "NoParmsFound", ErrorCategory.InvalidArgument, helpInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,17872,18395);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,17872,18395);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,18267,18380);
foreach(PSObject pInfo in f_1150_18294_18300_I(pInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,18267,18380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,18342,18361);

f_1150_18342_18360(this, pInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,18267,18380);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,114);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,114);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1150,17872,18395);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,17646,18406);

string
f_1150_17778_17791(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 17778, 17791);
return return_v;
}


int
f_1150_17727_17792(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 17727, 17792);
return 0;
}


System.Management.Automation.PSObject[]
f_1150_17829_17855(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.HelpInfo
helpInfo)
{
var return_v = this_param.GetParameterInfo( helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 17829, 17855);
return return_v;
}


int
f_1150_17897_17910(System.Management.Automation.PSObject[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 17897, 17910);
return return_v;
}


string
f_1150_18046_18069()
{
var return_v =                     HelpErrors.NoParmsFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 18046, 18069);
return return_v;
}


string[]
f_1150_18071_18080()
{
var return_v = Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 18071, 18080);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1150_17977_18081(string
paramName,string
resourceString,params string[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, (object[])args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 17977, 18081);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1150_18111_18199(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.HelpInfo
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 18111, 18199);
return return_v;
}


int
f_1150_18100_18200(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 18100, 18200);
return 0;
}


int
f_1150_18342_18360(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.PSObject
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 18342, 18360);
return 0;
}


System.Management.Automation.PSObject[]
f_1150_18294_18300_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 18294, 18300);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,17646,18406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,17646,18406);
}
		}

private void ValidateAndThrowIfError(HelpCategory cat)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,18699,20179);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,18778,18862) || true) && (cat == HelpCategory.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,18778,18862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,18840,18847);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,18778,18862);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,18975,19190);

HelpCategory 
supportedCategories =
                HelpCategory.Alias | HelpCategory.Cmdlet | HelpCategory.ExternalScript |
                HelpCategory.Filter | HelpCategory.Function | HelpCategory.ScriptCommand
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19206,20168) || true) && ((cat & supportedCategories) == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,19206,20168);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19276,19481) || true) && (f_1150_19280_19289()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,19276,19481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19339,19462);

throw f_1150_19345_19461("Parameter", f_1150_19418_19446(), "-Parameter");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,19276,19481);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19501,19706) || true) && (f_1150_19505_19514()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,19501,19706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19564,19687);

throw f_1150_19570_19686("Component", f_1150_19643_19671(), "-Component");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,19501,19706);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19726,19916) || true) && (f_1150_19730_19734()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,19726,19916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19784,19897);

throw f_1150_19790_19896("Role", f_1150_19858_19886(), "-Role");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,19726,19916);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,19936,20153) || true) && (f_1150_19940_19953()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,19936,20153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,20003,20134);

throw f_1150_20009_20133("Functionality", f_1150_20086_20114(), "-Functionality");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,19936,20153);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,19206,20168);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,18699,20179);

string[]
f_1150_19280_19289()
{
var return_v = Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 19280, 19289);
return return_v;
}


string
f_1150_19418_19446()
{
var return_v =                         HelpErrors.ParamNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 19418, 19446);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1150_19345_19461(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 19345, 19461);
return return_v;
}


string[]
f_1150_19505_19514()
{
var return_v = Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 19505, 19514);
return return_v;
}


string
f_1150_19643_19671()
{
var return_v =                         HelpErrors.ParamNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 19643, 19671);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1150_19570_19686(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 19570, 19686);
return return_v;
}


string[]
f_1150_19730_19734()
{
var return_v = Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 19730, 19734);
return return_v;
}


string
f_1150_19858_19886()
{
var return_v =                         HelpErrors.ParamNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 19858, 19886);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1150_19790_19896(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 19790, 19896);
return return_v;
}


string[]
f_1150_19940_19953()
{
var return_v = Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 19940, 19953);
return return_v;
}


string
f_1150_20086_20114()
{
var return_v =                         HelpErrors.ParamNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 20086, 20114);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1150_20009_20133(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 20009, 20133);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,18699,20179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,18699,20179);
}
		}

private void WriteObjectsOrShowOnlineHelp(HelpInfo helpInfo, bool showFullHelp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,20406,22939);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,20510,22928) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,20510,22928);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,20827,22913) || true) && (showFullHelp &&(DynAbs.Tracing.TraceSender.Expression_True(1150, 20831, 20862)&&_showOnlineHelp))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,20827,22913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,20904,20932);

bool 
onlineUriFound = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,20995,21048);

f_1150_20995_21047(                    // show online help
                    s_tracer, "Preparing to show help online.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21070,21117);

Uri 
onlineUri = f_1150_21086_21116(helpInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21139,21342) || true) && (onlineUri != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21139,21342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21210,21232);

onlineUriFound = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21258,21286);

f_1150_21258_21285(this, onlineUri);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21312,21319);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21139,21342);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21366,21530) || true) && (!onlineUriFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21366,21530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21435,21507);

throw f_1150_21441_21506(f_1150_21484_21505());
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21366,21530);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,20827,22913);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,20827,22913);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21583,22913) || true) && (showFullHelp &&(DynAbs.Tracing.TraceSender.Expression_True(1150, 21587, 21613)&&f_1150_21603_21613()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21583,22913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21655,21746);

f_1150_21655_21745(                    graphicalHostReflectionWrapper, "ShowHelpWindow", f_1150_21721_21738(helpInfo), this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21583,22913);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21583,22913);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21877,22894) || true) && (showFullHelp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21877,22894);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,21943,22380) || true) && (f_1150_21947_21956()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21943,22380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22022,22057);

f_1150_22022_22056(this, helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21943,22380);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21943,22380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22171,22230);

PSObject 
objectToReturn = f_1150_22197_22229(this, f_1150_22211_22228(helpInfo))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22260,22295);

objectToReturn.IsHelpObject = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22325,22353);

f_1150_22325_22352(this, objectToReturn);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21943,22380);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21877,22894);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,21877,22894);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22478,22811) || true) && (f_1150_22482_22491()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,22478,22811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22557,22604);

PSObject[] 
pInfos = f_1150_22577_22603(this, helpInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22636,22784) || true) && ((pInfos == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1150, 22640, 22680)||(f_1150_22661_22674(pInfos)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,22636,22784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22746,22753);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,22636,22784);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,22478,22811);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,22839,22871);

f_1150_22839_22870(this, f_1150_22851_22869(helpInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21877,22894);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,21583,22913);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,20827,22913);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,20510,22928);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,20406,22939);

int
f_1150_20995_21047(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 20995, 21047);
return 0;
}


System.Uri
f_1150_21086_21116(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.GetUriForOnlineHelp();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 21086, 21116);
return return_v;
}


int
f_1150_21258_21285(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Uri
uriToLaunch)
{
this_param.LaunchOnlineHelp( uriToLaunch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 21258, 21285);
return 0;
}


string
f_1150_21484_21505()
{
var return_v = HelpErrors.NoURIFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 21484, 21505);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1150_21441_21506(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 21441, 21506);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1150_21603_21613()
{
var return_v = ShowWindow;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 21603, 21613);
return return_v;
}


System.Management.Automation.PSObject
f_1150_21721_21738(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 21721, 21738);
return return_v;
}


object
f_1150_21655_21745(System.Management.Automation.Internal.GraphicalHostReflectionWrapper
this_param,string
methodName,params object[]
arguments)
{
var return_v = this_param.CallStaticMethod( methodName, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 21655, 21745);
return return_v;
}


string[]
f_1150_21947_21956()
{
var return_v = Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 21947, 21956);
return return_v;
}


int
f_1150_22022_22056(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.HelpInfo
helpInfo)
{
this_param.GetAndWriteParameterInfo( helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 22022, 22056);
return 0;
}


System.Management.Automation.PSObject
f_1150_22211_22228(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 22211, 22228);
return return_v;
}


System.Management.Automation.PSObject
f_1150_22197_22229(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.PSObject
originalHelpObject)
{
var return_v = this_param.TransformView( originalHelpObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 22197, 22229);
return return_v;
}


int
f_1150_22325_22352(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.PSObject
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 22325, 22352);
return 0;
}


string[]
f_1150_22482_22491()
{
var return_v = Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 22482, 22491);
return return_v;
}


System.Management.Automation.PSObject[]
f_1150_22577_22603(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.HelpInfo
helpInfo)
{
var return_v = this_param.GetParameterInfo( helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 22577, 22603);
return return_v;
}


int
f_1150_22661_22674(System.Management.Automation.PSObject[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 22661, 22674);
return return_v;
}


System.Management.Automation.PSObject
f_1150_22851_22869(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.ShortHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 22851, 22869);
return return_v;
}


int
f_1150_22839_22870(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.PSObject
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 22839, 22870);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,20406,22939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,20406,22939);
}
		}

private void LaunchOnlineHelp(Uri uriToLaunch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,23146,25612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,23217,23291);

f_1150_23217_23290(uriToLaunch != null, "uriToLaunch should not be null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,23307,23708) || true) && (!f_1150_23312_23381(f_1150_23312_23330(uriToLaunch), "http", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1150, 23311, 23473)&&                !f_1150_23403_23473(f_1150_23403_23421(uriToLaunch), "https", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,23307,23708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,23507,23693);

throw f_1150_23513_23692(f_1150_23556_23587(), f_1150_23610_23632(                    uriToLaunch), "http", "https");
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,23307,23708);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,23814,24059) || true) && (InternalTestHooks.BypassOnlineHelpRetrieval)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,23814,24059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,23895,24019);

f_1150_23895_24018(                this, f_1150_23912_24017(f_1150_23926_23954(), f_1150_23956_23988(), f_1150_23990_24016(uriToLaunch)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24037,24044);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,23814,24059);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24075,24102);

Exception 
exception = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24116,24148);

bool 
wrapCaughtException = true
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24198,24323);

f_1150_24198_24322(                this, f_1150_24216_24321(f_1150_24230_24258(), f_1150_24260_24292(), f_1150_24294_24320(uriToLaunch)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24341,24418);

System.Diagnostics.Process 
browserProcess = f_1150_24385_24417()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24438,25039) || true) && (f_1150_24442_24463()||(DynAbs.Tracing.TraceSender.Expression_False(1150, 24442, 24481)||f_1150_24467_24481()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,24438,25039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24599,24627);

wrapCaughtException = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24649,24760);

exception = f_1150_24661_24759(f_1150_24704_24730(), f_1150_24732_24758(uriToLaunch));
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,24438,25039);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,24438,25039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24842,24905);

f_1150_24842_24866(browserProcess).FileName = f_1150_24878_24904(uriToLaunch);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24927,24975);

f_1150_24927_24951(browserProcess).UseShellExecute = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,24997,25020);

f_1150_24997_25019(                    browserProcess);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,24438,25039);
}
            }
            catch (InvalidOperationException ioe)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1150,25068,25169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25138,25154);

exception = ioe;
DynAbs.Tracing.TraceSender.TraceExitCatch(1150,25068,25169);
            }
            catch (System.ComponentModel.Win32Exception we)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1150,25183,25293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25263,25278);

exception = we;
DynAbs.Tracing.TraceSender.TraceExitCatch(1150,25183,25293);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25309,25601) || true) && (exception != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,25309,25601);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25364,25586) || true) && (wrapCaughtException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,25364,25586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25410,25526);

throw f_1150_25416_25525(exception, f_1150_25470_25496(), f_1150_25498_25524(uriToLaunch));
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,25364,25586);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,25364,25586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25570,25586);

throw exception;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,25364,25586);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,25309,25601);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,23146,25612);

int
f_1150_23217_23290(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 23217, 23290);
return 0;
}


string
f_1150_23312_23330(System.Uri
this_param)
{
var return_v = this_param.Scheme;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 23312, 23330);
return return_v;
}


bool
f_1150_23312_23381(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 23312, 23381);
return return_v;
}


string
f_1150_23403_23421(System.Uri
this_param)
{
var return_v = this_param.Scheme;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 23403, 23421);
return return_v;
}


bool
f_1150_23403_23473(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 23403, 23473);
return return_v;
}


string
f_1150_23556_23587()
{
var return_v = HelpErrors.ProtocolNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 23556, 23587);
return return_v;
}


string
f_1150_23610_23632(System.Uri
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 23610, 23632);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1150_23513_23692(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 23513, 23692);
return return_v;
}


System.Globalization.CultureInfo
f_1150_23926_23954()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 23926, 23954);
return return_v;
}


string
f_1150_23956_23988()
{
var return_v = HelpDisplayStrings.OnlineHelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 23956, 23988);
return return_v;
}


string
f_1150_23990_24016(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 23990, 24016);
return return_v;
}


string
f_1150_23912_24017(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 23912, 24017);
return return_v;
}


int
f_1150_23895_24018(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,string
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 23895, 24018);
return 0;
}


System.Globalization.CultureInfo
f_1150_24230_24258()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24230, 24258);
return return_v;
}


string
f_1150_24260_24292()
{
var return_v = HelpDisplayStrings.OnlineHelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24260, 24292);
return return_v;
}


string
f_1150_24294_24320(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24294, 24320);
return return_v;
}


string
f_1150_24216_24321(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 24216, 24321);
return return_v;
}


int
f_1150_24198_24322(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 24198, 24322);
return 0;
}


System.Diagnostics.Process
f_1150_24385_24417()
{
var return_v = new System.Diagnostics.Process();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 24385, 24417);
return return_v;
}


bool
f_1150_24442_24463()
{
var return_v = Platform.IsNanoServer ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24442, 24463);
return return_v;
}


bool
f_1150_24467_24481()
{
var return_v = Platform.IsIoT;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24467, 24481);
return return_v;
}


string
f_1150_24704_24730()
{
var return_v = HelpErrors.CannotLaunchURI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24704, 24730);
return return_v;
}


string
f_1150_24732_24758(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24732, 24758);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1150_24661_24759(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 24661, 24759);
return return_v;
}


System.Diagnostics.ProcessStartInfo
f_1150_24842_24866(System.Diagnostics.Process
this_param)
{
var return_v = this_param.StartInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24842, 24866);
return return_v;
}


string
f_1150_24878_24904(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24878, 24904);
return return_v;
}


System.Diagnostics.ProcessStartInfo
f_1150_24927_24951(System.Diagnostics.Process
this_param)
{
var return_v = this_param.StartInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 24927, 24951);
return return_v;
}


bool
f_1150_24997_25019(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Start();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 24997, 25019);
return return_v;
}


string
f_1150_25470_25496()
{
var return_v = HelpErrors.CannotLaunchURI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 25470, 25496);
return return_v;
}


string
f_1150_25498_25524(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 25498, 25524);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1150_25416_25525(System.Exception
innerException,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( innerException, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 25416, 25525);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,23146,25612);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,23146,25612);
}
		}

private void HelpSystem_OnProgress(object sender, HelpProgressInfo arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,25646,25948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25742,25899);

var 
record = new ProgressRecord(0, f_1150_25777_25798(f_1150_25777_25793(this)), arg.Activity)
            {
                PercentComplete = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => arg.PercentComplete,1150,25755,25898)
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,25915,25937);

f_1150_25915_25936(this, record);
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,25646,25948);

System.Management.Automation.CommandInfo
f_1150_25777_25793(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.CommandInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 25777, 25793);
return return_v;
}


string
f_1150_25777_25798(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 25777, 25798);
return return_v;
}


int
f_1150_25915_25936(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.ProgressRecord
progressRecord)
{
this_param.WriteProgress( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 25915, 25936);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,25646,25948);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,25646,25948);
}
		}

private void HelpSystem_OnComplete()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1150,25960,26230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,26021,26181);

var 
record = new ProgressRecord(0, f_1150_26056_26077(f_1150_26056_26072(this)), "Completed")
            {
                RecordType = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => ProgressRecordType.Completed,1150,26034,26180)
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,26197,26219);

f_1150_26197_26218(this, record);
DynAbs.Tracing.TraceSender.TraceExitMethod(1150,25960,26230);

System.Management.Automation.CommandInfo
f_1150_26056_26072(Microsoft.PowerShell.Commands.GetHelpCommand
this_param)
{
var return_v = this_param.CommandInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 26056, 26072);
return return_v;
}


string
f_1150_26056_26077(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 26056, 26077);
return return_v;
}


int
f_1150_26197_26218(Microsoft.PowerShell.Commands.GetHelpCommand
this_param,System.Management.Automation.ProgressRecord
progressRecord)
{
this_param.WriteProgress( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 26197, 26218);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,25960,26230);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,25960,26230);
}
		}

internal static void VerifyParameterForbiddenInRemoteRunspace(Cmdlet cmdlet, string parameterName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1150,26331,27003);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,26454,26992) || true) && (f_1150_26458_26493())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,26454,26992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,26527,26709);

string 
message = f_1150_26544_26708(f_1150_26562_26614(), f_1150_26637_26671(f_1150_26637_26656(cmdlet)), parameterName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,26727,26780);

Exception 
e = f_1150_26741_26779(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,26798,26917);

ErrorRecord 
errorRecord = f_1150_26824_26916(e, "ParameterNotValidInRemoteRunspace", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,26935,26977);

f_1150_26935_26976(                cmdlet, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,26454,26992);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1150,26331,27003);

bool
f_1150_26458_26493()
{
var return_v = NativeCommandProcessor.IsServerSide;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 26458, 26493);
return return_v;
}


string
f_1150_26562_26614()
{
var return_v = CommandBaseStrings.ParameterNotValidInRemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 26562, 26614);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1150_26637_26656(System.Management.Automation.Cmdlet
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 26637, 26656);
return return_v;
}


string
f_1150_26637_26671(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.InvocationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 26637, 26671);
return return_v;
}


string
f_1150_26544_26708(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 26544, 26708);
return return_v;
}


System.InvalidOperationException
f_1150_26741_26779(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 26741, 26779);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1150_26824_26916(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 26824, 26916);
return return_v;
}


int
f_1150_26935_26976(System.Management.Automation.Cmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 26935, 26976);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,26331,27003);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,26331,27003);
}
		}

[TraceSourceAttribute("GetHelpCommand ", "GetHelpCommand ")]
        private static PSTraceSource s_tracer ;

static GetHelpCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1150,715,27263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,27161,27233);
s_tracer = f_1150_27172_27233("GetHelpCommand ", "GetHelpCommand ");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1150,715,27263);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,715,27263);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1150,715,27263);

System.Diagnostics.Stopwatch
f_1150_7361_7376()
{
var return_v = new System.Diagnostics.Stopwatch();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 7361, 7376);
return return_v;
}


static System.Management.Automation.PSTraceSource
f_1150_27172_27233(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 27172, 27233);
return return_v;
}

}
public static class GetHelpCodeMethods
{
private static bool DoesCurrentRunspaceIncludeCoreHelpCmdlet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1150,27590,28684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,27677,27804);

InitialSessionState 
iss =
f_1150_27720_27803(f_1150_27720_27783())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,27818,28644) || true) && (iss != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,27818,28644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,27867,28068);

IEnumerable<SessionStateCommandEntry> 
publicGetHelpEntries = f_1150_27928_28067(f_1150_27928_27974(f_1150_27928_27962(iss), "Get-Help"), entry => entry.Visibility == SessionStateEntryVisibility.Public)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,28086,28197) || true) && (f_1150_28090_28118(publicGetHelpEntries)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,28086,28197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,28165,28178);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,28086,28197);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,28217,28629);
foreach(SessionStateCommandEntry getHelpEntry in f_1150_28267_28287_I(publicGetHelpEntries) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,28217,28629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,28329,28409);

SessionStateCmdletEntry 
getHelpCmdlet = getHelpEntry as SessionStateCmdletEntry
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,28431,28610) || true) && ((getHelpCmdlet != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1150, 28435, 28525)&&(f_1150_28463_28524(f_1150_28463_28493(getHelpCmdlet), typeof(GetHelpCommand)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,28431,28610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,28575,28587);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,28431,28610);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,28217,28629);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,413);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,413);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1150,27818,28644);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,28660,28673);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1150,27590,28684);

System.Management.Automation.Runspaces.Runspace
f_1150_27720_27783()
{
var return_v =                 System.Management.Automation.Runspaces.Runspace.DefaultRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 27720, 27783);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionState
f_1150_27720_27803(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InitialSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 27720, 27803);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
f_1150_27928_27962(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 27928, 27962);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
f_1150_27928_27974(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 27928, 27974);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCommandEntry>
f_1150_27928_28067(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
source,System.Func<System.Management.Automation.Runspaces.SessionStateCommandEntry, bool>
predicate)
{
var return_v = source.Where<System.Management.Automation.Runspaces.SessionStateCommandEntry>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 27928, 28067);
return return_v;
}


int
f_1150_28090_28118(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCommandEntry>
source)
{
var return_v = source.Count<System.Management.Automation.Runspaces.SessionStateCommandEntry>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 28090, 28118);
return return_v;
}


System.Type
f_1150_28463_28493(System.Management.Automation.Runspaces.SessionStateCmdletEntry
this_param)
{
var return_v = this_param.ImplementingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 28463, 28493);
return return_v;
}


bool
f_1150_28463_28524(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 28463, 28524);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCommandEntry>
f_1150_28267_28287_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.SessionStateCommandEntry>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 28267, 28287);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,27590,28684);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,27590,28684);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings")]
        public static string GetHelpUri(PSObject commandInfoPSObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1150,29176,34655);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,29353,29453) || true) && (commandInfoPSObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,29353,29453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,29418,29438);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,29353,29453);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,29469,29541);

CommandInfo 
cmdInfo = f_1150_29491_29525(commandInfoPSObject)as CommandInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,29710,29840) || true) && ((cmdInfo == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1150, 29714, 29771)||(f_1150_29736_29770(f_1150_29757_29769(cmdInfo)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,29710,29840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,29805,29825);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,29710,29840);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30068,30410) || true) && ((cmdInfo is CmdletInfo) ||(DynAbs.Tracing.TraceSender.Expression_False(1150, 30072, 30124)||(cmdInfo is FunctionInfo) )||(DynAbs.Tracing.TraceSender.Expression_False(1150, 30072, 30176)||                (cmdInfo is ExternalScriptInfo) )||(DynAbs.Tracing.TraceSender.Expression_False(1150, 30072, 30203)||(cmdInfo is ScriptInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,30068,30410);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30237,30395) || true) && (!f_1150_30242_30295(f_1150_30263_30294(f_1150_30263_30286(cmdInfo))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,30237,30395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30337,30376);

return f_1150_30344_30375(f_1150_30344_30367(cmdInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,30237,30395);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,30068,30410);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30426,30469);

AliasInfo 
aliasInfo = cmdInfo as AliasInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30483,30755) || true) && ((aliasInfo != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1150, 30487, 30570)&&                (f_1150_30528_30561(aliasInfo)!= null) )&&(DynAbs.Tracing.TraceSender.Expression_True(1150, 30487, 30657)&&                (!f_1150_30593_30656(f_1150_30614_30655(f_1150_30614_30647(aliasInfo))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,30483,30755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30691,30740);

return f_1150_30698_30739(f_1150_30698_30731(aliasInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,30483,30755);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30866,30896);

string 
cmdName = f_1150_30883_30895(cmdInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30910,31145) || true) && (!f_1150_30915_30955(f_1150_30936_30954(cmdInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,30910,31145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,30989,31130);

cmdName = f_1150_30999_31129(f_1150_31013_31041(), "{0}\\{1}", f_1150_31096_31114(cmdInfo), f_1150_31116_31128(cmdInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,30910,31145);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,31161,34608) || true) && (f_1150_31165_31207())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,31161,34608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,31426,31529);

var 
currentContext = f_1150_31447_31528()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,31547,32405) || true) && ((currentContext != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1150, 31551, 31614)&&(f_1150_31580_31605(currentContext)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,31547,32405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,31656,31729);

HelpRequest 
helpRequest = f_1150_31682_31728(cmdName, f_1150_31707_31727(cmdInfo))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,31751,31941);

helpRequest.ProviderContext = f_1150_31781_31940(string.Empty, currentContext, f_1150_31907_31939(f_1150_31907_31934(currentContext)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,31963,32014);

helpRequest.CommandOrigin = CommandOrigin.Runspace;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,32036,32386);
foreach(                        Uri result in f_1150_32114_32284_I(f_1150_32114_32284(f_1150_32114_32252(f_1150_32114_32167(f_1150_32114_32139(currentContext), helpRequest), helpInfo => helpInfo.GetUriForOnlineHelp()), result => result != null)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,32036,32386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,32334,32363);

return f_1150_32341_32362(result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,32036,32386);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,351);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,351);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1150,31547,32405);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,31161,34608);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,31161,34608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33070,33340);

var 
getHelpPS = f_1150_33086_33339(f_1150_33086_33259(f_1150_33086_33207(f_1150_33086_33162(RunspaceMode.CurrentRunspace), "get-help"), "Name", cmdName), "Category", f_1150_33307_33338(f_1150_33307_33327(cmdInfo)))
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33402,33454);

Collection<PSObject> 
helpInfos = f_1150_33435_33453(getHelpPS)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33478,34469) || true) && (helpInfos != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,33478,34469);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33558,33567);
                        for (int 
index = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33549,34446) || true) && (index < f_1150_33577_33592(helpInfos))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33594,33601)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(1150,33549,34446))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,33549,34446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33659,33677);

HelpInfo 
helpInfo
=default(HelpInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33707,34419) || true) && (f_1150_33711_33784(f_1150_33753_33769(helpInfos, index), out helpInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,33707,34419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33850,33894);

Uri 
result = f_1150_33863_33893(helpInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,33928,34084) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,33928,34084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,34020,34049);

return f_1150_34027_34048(result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,33928,34084);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,33707,34419);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1150,33707,34419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,34214,34291);

Uri 
result = f_1150_34227_34290(f_1150_34273_34289(helpInfos, index))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,34325,34388);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1150, 34332, 34348)||(((result != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1150, 34351, 34372))||DynAbs.Tracing.TraceSender.Conditional_F3(1150, 34375, 34387)))?f_1150_34351_34372(result):string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,33707,34419);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1150,1,898);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1150,1,898);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1150,33478,34469);
}
                }
                finally
                {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1150,34506,34593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,34554,34574);

f_1150_34554_34573(                    getHelpPS);
DynAbs.Tracing.TraceSender.TraceExitFinally(1150,34506,34593);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1150,31161,34608);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1150,34624,34644);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1150,29176,34655);

object
f_1150_29491_29525(System.Management.Automation.PSObject
obj)
{
var return_v = PSObject.Base( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 29491, 29525);
return return_v;
}


string
f_1150_29757_29769(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 29757, 29769);
return return_v;
}


bool
f_1150_29736_29770(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 29736, 29770);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1150_30263_30286(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30263, 30286);
return return_v;
}


string
f_1150_30263_30294(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30263, 30294);
return return_v;
}


bool
f_1150_30242_30295(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 30242, 30295);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1150_30344_30367(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30344, 30367);
return return_v;
}


string
f_1150_30344_30375(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30344, 30375);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1150_30528_30561(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.ExternalCommandMetadata ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30528, 30561);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1150_30614_30647(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.ExternalCommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30614, 30647);
return return_v;
}


string
f_1150_30614_30655(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30614, 30655);
return return_v;
}


bool
f_1150_30593_30656(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 30593, 30656);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1150_30698_30731(System.Management.Automation.AliasInfo
this_param)
{
var return_v = this_param.ExternalCommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30698, 30731);
return return_v;
}


string
f_1150_30698_30739(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30698, 30739);
return return_v;
}


string
f_1150_30883_30895(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30883, 30895);
return return_v;
}


string
f_1150_30936_30954(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 30936, 30954);
return return_v;
}


bool
f_1150_30915_30955(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 30915, 30955);
return return_v;
}


System.Globalization.CultureInfo
f_1150_31013_31041()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 31013, 31041);
return return_v;
}


string
f_1150_31096_31114(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 31096, 31114);
return return_v;
}


string
f_1150_31116_31128(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 31116, 31128);
return return_v;
}


string
f_1150_30999_31129(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 30999, 31129);
return return_v;
}


bool
f_1150_31165_31207()
{
var return_v = DoesCurrentRunspaceIncludeCoreHelpCmdlet();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 31165, 31207);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1150_31447_31528()
{
var return_v = System.Management.Automation.Runspaces.LocalPipeline.GetExecutionContextFromTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 31447, 31528);
return return_v;
}


System.Management.Automation.HelpSystem
f_1150_31580_31605(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.HelpSystem ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 31580, 31605);
return return_v;
}


System.Management.Automation.HelpCategory
f_1150_31707_31727(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 31707, 31727);
return return_v;
}


System.Management.Automation.HelpRequest
f_1150_31682_31728(string
target,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.HelpRequest( target, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 31682, 31728);
return return_v;
}


System.Management.Automation.SessionState
f_1150_31907_31934(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 31907, 31934);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1150_31907_31939(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 31907, 31939);
return return_v;
}


System.Management.Automation.ProviderContext
f_1150_31781_31940(string
requestedPath,System.Management.Automation.ExecutionContext
executionContext,System.Management.Automation.PathIntrinsics
pathIntrinsics)
{
var return_v = new System.Management.Automation.ProviderContext( requestedPath, executionContext, pathIntrinsics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 31781, 31940);
return return_v;
}


System.Management.Automation.HelpSystem
f_1150_32114_32139(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 32114, 32139);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1150_32114_32167(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.ExactMatchHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 32114, 32167);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Uri>
f_1150_32114_32252(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
source,System.Func<System.Management.Automation.HelpInfo, System.Uri>
selector)
{
var return_v = source.Select<System.Management.Automation.HelpInfo,System.Uri>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 32114, 32252);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Uri>
f_1150_32114_32284(System.Collections.Generic.IEnumerable<System.Uri>
source,System.Func<System.Uri, bool>
predicate)
{
var return_v = source.Where<System.Uri>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 32114, 32284);
return return_v;
}


string
f_1150_32341_32362(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 32341, 32362);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Uri>
f_1150_32114_32284_I(System.Collections.Generic.IEnumerable<System.Uri>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 32114, 32284);
return return_v;
}


System.Management.Automation.PowerShell
f_1150_33086_33162(System.Management.Automation.RunspaceMode
runspace)
{
var return_v = System.Management.Automation.PowerShell.Create( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33086, 33162);
return return_v;
}


System.Management.Automation.PowerShell
f_1150_33086_33207(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33086, 33207);
return return_v;
}


System.Management.Automation.PowerShell
f_1150_33086_33259(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33086, 33259);
return return_v;
}


System.Management.Automation.HelpCategory
f_1150_33307_33327(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 33307, 33327);
return return_v;
}


string
f_1150_33307_33338(System.Management.Automation.HelpCategory
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33307, 33338);
return return_v;
}


System.Management.Automation.PowerShell
f_1150_33086_33339(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33086, 33339);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1150_33435_33453(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33435, 33453);
return return_v;
}


int
f_1150_33577_33592(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 33577, 33592);
return return_v;
}


System.Management.Automation.PSObject
f_1150_33753_33769(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 33753, 33769);
return return_v;
}


bool
f_1150_33711_33784(System.Management.Automation.PSObject
valueToConvert,out System.Management.Automation.HelpInfo
result)
{
var return_v = LanguagePrimitives.TryConvertTo<HelpInfo>( (object)valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33711, 33784);
return return_v;
}


System.Uri
f_1150_33863_33893(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.GetUriForOnlineHelp();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 33863, 33893);
return return_v;
}


string
f_1150_34027_34048(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 34027, 34048);
return return_v;
}


System.Management.Automation.PSObject
f_1150_34273_34289(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 34273, 34289);
return return_v;
}


System.Uri
f_1150_34227_34290(System.Management.Automation.PSObject
commandFullHelp)
{
var return_v = BaseCommandHelpInfo.GetUriFromCommandPSObject( commandFullHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 34227, 34290);
return return_v;
}


string
f_1150_34351_34372(System.Uri
this_param)
{
var return_v = this_param.OriginalString ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1150, 34351, 34372);
return return_v;
}


int
f_1150_34554_34573(System.Management.Automation.PowerShell
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1150, 34554, 34573);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1150,29176,34655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,29176,34655);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static GetHelpCodeMethods()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1150,27382,34662);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1150,27382,34662);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1150,27382,34662);
}

}
}

