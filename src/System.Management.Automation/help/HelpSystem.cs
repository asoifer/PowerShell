// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Language;

using Microsoft.PowerShell.Commands;

using System.Management.Automation.Runspaces;
using System.Management.Automation.Internal;

namespace System.Management.Automation
{
internal class HelpSystem
{
internal HelpSystem(ExecutionContext context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1161,4823,5110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,5147,5164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7431,7474);
this._lastErrors = f_1161_7445_7474();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7848,7885);
this._lastHelpCategory = HelpCategory.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,8316,8342);
this._verboseHelpErrors = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,9560,9579);
this._searchPaths = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,22501,22533);
this._helpProviders = f_1161_22518_22533();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,28125,28141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,29748,29756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31318,31397);
this._scriptBlockTokenCache = f_1161_31343_31397(isThreadSafe: true);
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,4893,5026) || true) && (context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,4893,5026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,4946,5011);

throw f_1161_4952_5010("ExecutionContext");
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,4893,5026);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,5042,5070);

_executionContext = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,5086,5099);

f_1161_5086_5098(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1161,4823,5110);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,4823,5110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,4823,5110);
}
		}

private ExecutionContext _executionContext;

internal ExecutionContext ExecutionContext
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,5532,5608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,5568,5593);

return _executionContext;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,5532,5608);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,5465,5619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,5465,5619);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

        
        internal delegate void HelpProgressHandler(object sender, HelpProgressInfo arg);

        internal event HelpProgressHandler 
OnProgress
;

internal void Initialize()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,6237,6551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,6288,6439);

_verboseHelpErrors = f_1161_6309_6438(f_1161_6353_6437(                _executionContext, SpecialVariables.VerboseHelpErrorsVarPath, false));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,6453,6498);

_helpErrorTracer = f_1161_6472_6497(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,6514,6540);

f_1161_6514_6539(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,6237,6551);

object
f_1161_6353_6437(System.Management.Automation.ExecutionContext
this_param,System.Management.Automation.VariablePath
path,bool
defaultValue)
{
var return_v = this_param.GetVariableValue( path, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 6353, 6437);
return return_v;
}


bool
f_1161_6309_6438(object
obj)
{
var return_v = LanguagePrimitives.IsTrue( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 6309, 6438);
return return_v;
}


System.Management.Automation.HelpErrorTracer
f_1161_6472_6497(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.HelpErrorTracer( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 6472, 6497);
return return_v;
}


int
f_1161_6514_6539(System.Management.Automation.HelpSystem
this_param)
{
this_param.InitializeHelpProviders();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 6514, 6539);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,6237,6551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,6237,6551);
}
		}

internal IEnumerable<HelpInfo> GetHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,7041,7322);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7129,7183) || true) && (helpRequest == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,7129,7183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7171,7183);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,7129,7183);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7199,7222);

f_1161_7199_7221(
            helpRequest);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7238,7260);

f_1161_7238_7259(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7276,7311);

return f_1161_7283_7310(this, helpRequest);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,7041,7322);

int
f_1161_7199_7221(System.Management.Automation.HelpRequest
this_param)
{
this_param.Validate();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 7199, 7221);
return 0;
}


int
f_1161_7238_7259(System.Management.Automation.HelpSystem
this_param)
{
this_param.ValidateHelpCulture();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 7238, 7259);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_7283_7310(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.DoGetHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 7283, 7310);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,7041,7322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,7041,7322);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Collection<ErrorRecord> _lastErrors ;

internal Collection<ErrorRecord> LastErrors
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,7734,7804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,7770,7789);

return _lastErrors;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,7734,7804);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,7666,7815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,7666,7815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private HelpCategory _lastHelpCategory ;

internal HelpCategory LastHelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,8149,8225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,8185,8210);

return _lastHelpCategory;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,8149,8225);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,8086,8236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,8086,8236);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _verboseHelpErrors ;

internal bool VerboseHelpErrors
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,9242,9319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,9278,9304);

return _verboseHelpErrors;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,9242,9319);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,9186,9330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,9186,9330);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private Collection<string> _searchPaths ;

internal Collection<string> GetSearchPaths()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,9978,10765);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10100,10193) || true) && (_searchPaths != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,10100,10193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10158,10178);

return _searchPaths;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,10100,10193);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10209,10249);

_searchPaths = f_1161_10224_10248();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10325,10718) || true) && (f_1161_10329_10353(f_1161_10329_10345())!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,10325,10718);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10395,10703);
foreach(PSModuleInfo loadedModule in f_1161_10433_10476_I(f_1161_10433_10476(f_1161_10433_10469(f_1161_10433_10457(f_1161_10433_10449())))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,10395,10703);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10518,10684) || true) && (!f_1161_10523_10569(_searchPaths, f_1161_10545_10568(loadedModule)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,10518,10684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10619,10661);

f_1161_10619_10660(                        _searchPaths, f_1161_10636_10659(loadedModule));
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,10518,10684);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,10395,10703);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,309);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,309);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1161,10325,10718);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,10734,10754);

return _searchPaths;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,9978,10765);

System.Collections.ObjectModel.Collection<string>
f_1161_10224_10248()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 10224, 10248);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1161_10329_10345()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10329, 10345);
return return_v;
}


System.Management.Automation.ModuleIntrinsics
f_1161_10329_10353(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.Modules ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10329, 10353);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1161_10433_10449()
{
var return_v = ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10433, 10449);
return return_v;
}


System.Management.Automation.ModuleIntrinsics
f_1161_10433_10457(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.Modules;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10433, 10457);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
f_1161_10433_10469(System.Management.Automation.ModuleIntrinsics
this_param)
{
var return_v = this_param.ModuleTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10433, 10469);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
f_1161_10433_10476(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10433, 10476);
return return_v;
}


string
f_1161_10545_10568(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.ModuleBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10545, 10568);
return return_v;
}


bool
f_1161_10523_10569(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 10523, 10569);
return return_v;
}


string
f_1161_10636_10659(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.ModuleBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 10636, 10659);
return return_v;
}


int
f_1161_10619_10660(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 10619, 10660);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
f_1161_10433_10476_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 10433, 10476);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,9978,10765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,9978,10765);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IEnumerable<HelpInfo> DoGetHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,11554,13878);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,11643,11663);

f_1161_11643_11662(            _lastErrors);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,11711,11731);

_searchPaths = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,11747,11792);

_lastHelpCategory = f_1161_11767_11791(helpRequest);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,11808,13867) || true) && (f_1161_11812_11852(f_1161_11833_11851(helpRequest)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,11808,13867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,11886,11923);

HelpInfo 
helpInfo = f_1161_11906_11922(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,11943,12046) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,11943,12046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12005,12027);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,11943,12046);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12066,12084);

listYield.Add(null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,11808,13867);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,11808,13867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12150,12176);

bool 
isMatchFound = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12194,12520) || true) && (!f_1161_12199_12261(f_1161_12242_12260(helpRequest)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,12194,12520);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12303,12501);
foreach(HelpInfo helpInfo in f_1161_12333_12360_I(f_1161_12333_12360(this, helpRequest)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,12303,12501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12410,12430);

isMatchFound = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12456,12478);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,12303,12501);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,199);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,199);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1161,12194,12520);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12540,13852) || true) && (!isMatchFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,12540,13852);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12599,12793);
foreach(HelpInfo helpInfo in f_1161_12629_12652_I(f_1161_12629_12652(this, helpRequest)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,12599,12793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12702,12722);

isMatchFound = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12748,12770);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,12599,12793);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,195);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,195);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,12817,13833) || true) && (!isMatchFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,12817,13833);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,13331,13810) || true) && (!f_1161_13336_13398(f_1161_13379_13397(helpRequest))&&(DynAbs.Tracing.TraceSender.Expression_True(1161, 13335, 13428)&&f_1161_13402_13423(f_1161_13402_13417(this))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,13331,13810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,13486,13546);

Exception 
e = f_1161_13500_13545(f_1161_13526_13544(helpRequest))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,13576,13678);

ErrorRecord 
errorRecord = f_1161_13602_13677(e, "HelpNotFound", ErrorCategory.ResourceUnavailable, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,13708,13741);

f_1161_13708_13740(f_1161_13708_13723(this), errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,13771,13783);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,13331,13810);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,12817,13833);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,12540,13852);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,11808,13867);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,11554,13878);

return listYield;

int
f_1161_11643_11662(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 11643, 11662);
return 0;
}


System.Management.Automation.HelpCategory
f_1161_11767_11791(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 11767, 11791);
return return_v;
}


string
f_1161_11833_11851(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 11833, 11851);
return return_v;
}


bool
f_1161_11812_11852(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 11812, 11852);
return return_v;
}


System.Management.Automation.HelpInfo
f_1161_11906_11922(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.GetDefaultHelp();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 11906, 11922);
return return_v;
}


string
f_1161_12242_12260(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 12242, 12260);
return return_v;
}


bool
f_1161_12199_12261(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 12199, 12261);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_12333_12360(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.ExactMatchHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 12333, 12360);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_12333_12360_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 12333, 12360);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_12629_12652(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.SearchHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 12629, 12652);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_12629_12652_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 12629, 12652);
return return_v;
}


string
f_1161_13379_13397(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 13379, 13397);
return return_v;
}


bool
f_1161_13336_13398(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 13336, 13398);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1161_13402_13417(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 13402, 13417);
return return_v;
}


int
f_1161_13402_13423(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 13402, 13423);
return return_v;
}


string
f_1161_13526_13544(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 13526, 13544);
return return_v;
}


Microsoft.PowerShell.Commands.HelpNotFoundException
f_1161_13500_13545(string
helpTopic)
{
var return_v = new Microsoft.PowerShell.Commands.HelpNotFoundException( helpTopic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 13500, 13545);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1161_13602_13677(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 13602, 13677);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1161_13708_13723(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 13708, 13723);
return return_v;
}


int
f_1161_13708_13740(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 13708, 13740);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,11554,13878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,11554,13878);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,14350,15721);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14445,14474);

bool 
isHelpInfoFound = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14497,14502);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14488,15710) || true) && (i < f_1161_14508_14532(f_1161_14508_14526(this)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14534,14537)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1161,14488,15710))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,14488,15710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14571,14635);

HelpProvider 
helpProvider = (HelpProvider)f_1161_14613_14634(f_1161_14613_14631(this), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14653,15145) || true) && ((f_1161_14658_14683(helpProvider)& f_1161_14686_14710(helpRequest)) > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,14653,15145);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14757,15126);
foreach(HelpInfo helpInfo in f_1161_14787_14827_I(f_1161_14787_14827(helpProvider, helpRequest)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,14757,15126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14877,14900);

isHelpInfoFound = true;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,14926,15103);
foreach(HelpInfo fwdHelpInfo in f_1161_14959_14993_I(f_1161_14959_14993(this, helpInfo, helpRequest)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,14926,15103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,15051,15076);

listYield.Add(fwdHelpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,14926,15103);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,178);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,178);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1161,14757,15126);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,370);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,370);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1161,14653,15145);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,15455,15695) || true) && (isHelpInfoFound &&(DynAbs.Tracing.TraceSender.Expression_True(1161, 15459, 15524)&&(!(helpProvider is ScriptCommandHelpProvider))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,15455,15695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,15664,15676);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,15455,15695);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,1223);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,1223);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1161,14350,15721);

return listYield;

System.Collections.ArrayList
f_1161_14508_14526(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 14508, 14526);
return return_v;
}


int
f_1161_14508_14532(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 14508, 14532);
return return_v;
}


System.Collections.ArrayList
f_1161_14613_14631(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 14613, 14631);
return return_v;
}


object
f_1161_14613_14634(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 14613, 14634);
return return_v;
}


System.Management.Automation.HelpCategory
f_1161_14658_14683(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.HelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 14658, 14683);
return return_v;
}


System.Management.Automation.HelpCategory
f_1161_14686_14710(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 14686, 14710);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_14787_14827(System.Management.Automation.HelpProvider
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.ExactMatchHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 14787, 14827);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_14959_14993(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpInfo
helpInfo,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.ForwardHelp( helpInfo, helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 14959, 14993);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_14959_14993_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 14959, 14993);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_14787_14827_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 14787, 14827);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,14350,15721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,14350,15721);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IEnumerable<HelpInfo> ForwardHelp(HelpInfo helpInfo, HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,16335,18423);

var listYield= new List<HelpInfo>();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,16518,18412) || true) && (f_1161_16522_16550(helpInfo)== HelpCategory.None &&(DynAbs.Tracing.TraceSender.Expression_True(1161, 16522, 16619)&&f_1161_16575_16619(f_1161_16596_16618(helpInfo))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,16518,18412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,16756,16778);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,16518,18412);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,16518,18412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,16919,16983);

HelpCategory 
forwardHelpCategory = f_1161_16954_16982(helpInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17001,17034);

bool 
isHelpInfoProcessed = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17061,17066);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17052,18128) || true) && (i < f_1161_17072_17096(f_1161_17072_17090(this)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17098,17101)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1161,17052,18128))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,17052,18128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17143,17207);

HelpProvider 
helpProvider = (HelpProvider)f_1161_17185_17206(f_1161_17185_17203(this), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17229,18109) || true) && ((f_1161_17234_17259(helpProvider)& forwardHelpCategory) != HelpCategory.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,17229,18109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17353,17380);

isHelpInfoProcessed = true;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17553,18086);
foreach(HelpInfo fwdResult in f_1161_17584_17640_I(f_1161_17584_17640(helpProvider, helpInfo, helpRequest)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,17553,18086);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17766,17952);
foreach(HelpInfo fHelpInfo in f_1161_17797_17832_I(f_1161_17797_17832(this, fwdResult, helpRequest)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,17766,17952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,17898,17921);

listYield.Add(fHelpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,17766,17952);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,187);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,187);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,18047,18059);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,17553,18086);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,534);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,534);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1161,17229,18109);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,1077);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,1077);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,18148,18397) || true) && (!isHelpInfoProcessed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,18148,18397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,18356,18378);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,18148,18397);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,16518,18412);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,16335,18423);

return listYield;

System.Management.Automation.HelpCategory
f_1161_16522_16550(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.ForwardHelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 16522, 16550);
return return_v;
}


string
f_1161_16596_16618(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.ForwardTarget;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 16596, 16618);
return return_v;
}


bool
f_1161_16575_16619(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 16575, 16619);
return return_v;
}


System.Management.Automation.HelpCategory
f_1161_16954_16982(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.ForwardHelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 16954, 16982);
return return_v;
}


System.Collections.ArrayList
f_1161_17072_17090(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 17072, 17090);
return return_v;
}


int
f_1161_17072_17096(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 17072, 17096);
return return_v;
}


System.Collections.ArrayList
f_1161_17185_17203(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 17185, 17203);
return return_v;
}


object
f_1161_17185_17206(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 17185, 17206);
return return_v;
}


System.Management.Automation.HelpCategory
f_1161_17234_17259(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.HelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 17234, 17259);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_17584_17640(System.Management.Automation.HelpProvider
this_param,System.Management.Automation.HelpInfo
helpInfo,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.ProcessForwardedHelp( helpInfo, helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 17584, 17640);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_17797_17832(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpInfo
helpInfo,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.ForwardHelp( helpInfo, helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 17797, 17832);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_17797_17832_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 17797, 17832);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_17584_17640_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 17584, 17640);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,16335,18423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,16335,18423);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private HelpInfo GetDefaultHelp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,18592,18962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,18650,18729);

HelpRequest 
helpRequest = f_1161_18676_18728("default", HelpCategory.DefaultHelp)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,18743,18923);
foreach(HelpInfo helpInfo in f_1161_18773_18800_I(f_1161_18773_18800(this, helpRequest)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,18743,18923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,18892,18908);

return helpInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,18743,18923);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,181);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,181);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,18939,18951);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,18592,18962);

System.Management.Automation.HelpRequest
f_1161_18676_18728(string
target,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = new System.Management.Automation.HelpRequest( target, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 18676, 18728);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_18773_18800(System.Management.Automation.HelpSystem
this_param,System.Management.Automation.HelpRequest
helpRequest)
{
var return_v = this_param.ExactMatchHelp( helpRequest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 18773, 18800);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_18773_18800_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 18773, 18800);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,18592,18962);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,18592,18962);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,19209,22396);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19299,19329);

int 
countOfHelpInfosFound = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19343,19376);

bool 
searchInHelpContent = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19390,19415);

bool 
shouldBreak = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19431,19482);

HelpProgressInfo 
progress = f_1161_19459_19481()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19498,19600);

progress.Activity = f_1161_19518_19599(f_1161_19536_19578(), f_1161_19580_19598(helpRequest));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19614,19641);

progress.Completed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19655,19684);

progress.PercentComplete = 0;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19736,19763);

f_1161_19736_19762(OnProgress, this, progress);
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,19972,22179);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20218,20333) || true) && (searchInHelpContent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,20218,20333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20291,20310);

shouldBreak = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,20218,20333);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20366,20371);

                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20357,21424) || true) && (i < f_1161_20377_20401(f_1161_20377_20395(this)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20403,20406)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1161,20357,21424))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,20357,21424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20456,20520);

HelpProvider 
helpProvider = (HelpProvider)f_1161_20498_20519(f_1161_20498_20516(this), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20546,21401) || true) && ((f_1161_20551_20576(helpProvider)& f_1161_20579_20603(helpRequest)) > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,20546,21401);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20666,21374);
foreach(HelpInfo helpInfo in f_1161_20696_20753_I(f_1161_20696_20753(helpProvider, helpRequest, searchInHelpContent)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,20666,21374);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20819,20985) || true) && (f_1161_20823_20864(_executionContext))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,20819,20985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,20938,20950);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,20819,20985);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21021,21045);

countOfHelpInfosFound++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21079,21101);

listYield.Add(helpInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21137,21343) || true) && ((countOfHelpInfosFound >= f_1161_21167_21189(helpRequest)) &&(DynAbs.Tracing.TraceSender.Expression_True(1161, 21141, 21222)&&(f_1161_21195_21217(helpRequest)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,21137,21343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21296,21308);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,21137,21343);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,20666,21374);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,709);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,709);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1161,20546,21401);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,1068);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,1068);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21586,21700) || true) && (countOfHelpInfosFound > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,21586,21700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21665,21677);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,21586,21700);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21868,21895);

searchInHelpContent = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,21919,22138) || true) && (f_1161_21923_21947(f_1161_21923_21941(this))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,21919,22138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,22001,22062);

progress.PercentComplete += (100 / f_1161_22036_22060(f_1161_22036_22054(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,22088,22115);

f_1161_22088_22114(OnProgress, this, progress);
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,21919,22138);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,19972,22179);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,19972,22179) || true) && (!shouldBreak)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,19972,22179);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,19972,22179);
}}            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1161,22208,22385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,22248,22274);

progress.Completed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,22292,22323);

progress.PercentComplete = 100;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,22343,22370);

f_1161_22343_22369(OnProgress, this, progress);
DynAbs.Tracing.TraceSender.TraceExitFinally(1161,22208,22385);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,19209,22396);

return listYield;

System.Management.Automation.HelpProgressInfo
f_1161_19459_19481()
{
var return_v = new System.Management.Automation.HelpProgressInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 19459, 19481);
return return_v;
}


string
f_1161_19536_19578()
{
var return_v = HelpDisplayStrings.SearchingForHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 19536, 19578);
return return_v;
}


string
f_1161_19580_19598(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 19580, 19598);
return return_v;
}


string
f_1161_19518_19599(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 19518, 19599);
return return_v;
}


int
f_1161_19736_19762(System.Management.Automation.HelpSystem.HelpProgressHandler
this_param,System.Management.Automation.HelpSystem
sender,System.Management.Automation.HelpProgressInfo
arg)
{
this_param.Invoke( (object)sender, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 19736, 19762);
return 0;
}


System.Collections.ArrayList
f_1161_20377_20395(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 20377, 20395);
return return_v;
}


int
f_1161_20377_20401(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 20377, 20401);
return return_v;
}


System.Collections.ArrayList
f_1161_20498_20516(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 20498, 20516);
return return_v;
}


object
f_1161_20498_20519(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 20498, 20519);
return return_v;
}


System.Management.Automation.HelpCategory
f_1161_20551_20576(System.Management.Automation.HelpProvider
this_param)
{
var return_v = this_param.HelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 20551, 20576);
return return_v;
}


System.Management.Automation.HelpCategory
f_1161_20579_20603(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 20579, 20603);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_20696_20753(System.Management.Automation.HelpProvider
this_param,System.Management.Automation.HelpRequest
helpRequest,bool
searchOnlyContent)
{
var return_v = this_param.SearchHelp( helpRequest, searchOnlyContent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 20696, 20753);
return return_v;
}


bool
f_1161_20823_20864(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.CurrentPipelineStopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 20823, 20864);
return return_v;
}


int
f_1161_21167_21189(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 21167, 21189);
return return_v;
}


int
f_1161_21195_21217(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 21195, 21217);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
f_1161_20696_20753_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 20696, 20753);
return return_v;
}


System.Collections.ArrayList
f_1161_21923_21941(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 21923, 21941);
return return_v;
}


int
f_1161_21923_21947(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 21923, 21947);
return return_v;
}


System.Collections.ArrayList
f_1161_22036_22054(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.HelpProviders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 22036, 22054);
return return_v;
}


int
f_1161_22036_22060(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 22036, 22060);
return return_v;
}


int
f_1161_22088_22114(System.Management.Automation.HelpSystem.HelpProgressHandler
this_param,System.Management.Automation.HelpSystem
sender,System.Management.Automation.HelpProgressInfo
arg)
{
this_param.Invoke( (object)sender, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 22088, 22114);
return 0;
}


int
f_1161_22343_22369(System.Management.Automation.HelpSystem.HelpProgressHandler
this_param,System.Management.Automation.HelpSystem
sender,System.Management.Automation.HelpProgressInfo
arg)
{
this_param.Invoke( (object)sender, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 22343, 22369);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,19209,22396);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,19209,22396);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ArrayList _helpProviders ;

internal ArrayList HelpProviders
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,22763,22836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,22799,22821);

return _helpProviders;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,22763,22836);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,22706,22847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,22706,22847);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private void InitializeHelpProviders()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,23245,24417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23308,23341);

HelpProvider 
helpProvider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23357,23400);

helpProvider = f_1161_23372_23399(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23414,23447);

f_1161_23414_23446(            _helpProviders, helpProvider);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23463,23514);

helpProvider = f_1161_23478_23513(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23528,23561);

f_1161_23528_23560(            _helpProviders, helpProvider);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23577,23622);

helpProvider = f_1161_23592_23621(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23636,23669);

f_1161_23636_23668(            _helpProviders, helpProvider);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23685,23731);

helpProvider = f_1161_23700_23730(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23745,23778);

f_1161_23745_23777(            _helpProviders, helpProvider);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23794,23839);

helpProvider = f_1161_23809_23838(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,23853,23886);

f_1161_23853_23885(            _helpProviders, helpProvider);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,24205,24251);

helpProvider = f_1161_24220_24250(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,24265,24298);

f_1161_24265_24297(            _helpProviders, helpProvider);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,24314,24359);

helpProvider = f_1161_24329_24358(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,24373,24406);

f_1161_24373_24405(            _helpProviders, helpProvider);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,23245,24417);

System.Management.Automation.AliasHelpProvider
f_1161_23372_23399(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.AliasHelpProvider( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23372, 23399);
return return_v;
}


int
f_1161_23414_23446(System.Collections.ArrayList
this_param,System.Management.Automation.HelpProvider
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23414, 23446);
return return_v;
}


System.Management.Automation.ScriptCommandHelpProvider
f_1161_23478_23513(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.ScriptCommandHelpProvider( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23478, 23513);
return return_v;
}


int
f_1161_23528_23560(System.Collections.ArrayList
this_param,System.Management.Automation.HelpProvider
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23528, 23560);
return return_v;
}


System.Management.Automation.CommandHelpProvider
f_1161_23592_23621(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.CommandHelpProvider( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23592, 23621);
return return_v;
}


int
f_1161_23636_23668(System.Collections.ArrayList
this_param,System.Management.Automation.HelpProvider
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23636, 23668);
return return_v;
}


System.Management.Automation.ProviderHelpProvider
f_1161_23700_23730(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.ProviderHelpProvider( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23700, 23730);
return return_v;
}


int
f_1161_23745_23777(System.Collections.ArrayList
this_param,System.Management.Automation.HelpProvider
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23745, 23777);
return return_v;
}


System.Management.Automation.PSClassHelpProvider
f_1161_23809_23838(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.PSClassHelpProvider( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23809, 23838);
return return_v;
}


int
f_1161_23853_23885(System.Collections.ArrayList
this_param,System.Management.Automation.HelpProvider
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 23853, 23885);
return return_v;
}


System.Management.Automation.HelpFileHelpProvider
f_1161_24220_24250(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.HelpFileHelpProvider( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 24220, 24250);
return return_v;
}


int
f_1161_24265_24297(System.Collections.ArrayList
this_param,System.Management.Automation.HelpProvider
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 24265, 24297);
return return_v;
}


System.Management.Automation.DefaultHelpProvider
f_1161_24329_24358(System.Management.Automation.HelpSystem
helpSystem)
{
var return_v = new System.Management.Automation.DefaultHelpProvider( helpSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 24329, 24358);
return return_v;
}


int
f_1161_24373_24405(System.Collections.ArrayList
this_param,System.Management.Automation.HelpProvider
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 24373, 24405);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,23245,24417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,23245,24417);
}
		}

private HelpErrorTracer _helpErrorTracer;

internal HelpErrorTracer HelpErrorTracer
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,28347,28422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,28383,28407);

return _helpErrorTracer;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,28347,28422);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,28282,28433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,28282,28433);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal IDisposable Trace(string helpFile)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,28620,28814);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,28688,28747) || true) && (_helpErrorTracer == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,28688,28747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,28735,28747);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,28688,28747);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,28763,28803);

return f_1161_28770_28802(_helpErrorTracer, helpFile);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,28620,28814);

System.IDisposable
f_1161_28770_28802(System.Management.Automation.HelpErrorTracer
this_param,string
helpFile)
{
var return_v = this_param.Trace( helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 28770, 28802);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,28620,28814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,28620,28814);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void TraceError(ErrorRecord errorRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,29010,29206);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,29084,29138) || true) && (_helpErrorTracer == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,29084,29138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,29131,29138);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,29084,29138);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,29154,29195);

f_1161_29154_29194(
            _helpErrorTracer, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,29010,29206);

int
f_1161_29154_29194(System.Management.Automation.HelpErrorTracer
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.TraceError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 29154, 29194);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,29010,29206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,29010,29206);
}
		}

internal void TraceErrors(Collection<ErrorRecord> errorRecords)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,29430,29666);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,29518,29596) || true) && (_helpErrorTracer == null ||(DynAbs.Tracing.TraceSender.Expression_False(1161, 29522, 29570)||errorRecords == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,29518,29596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,29589,29596);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,29518,29596);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,29612,29655);

f_1161_29612_29654(
            _helpErrorTracer, errorRecords);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,29430,29666);

int
f_1161_29612_29654(System.Management.Automation.HelpErrorTracer
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
errorRecords)
{
this_param.TraceErrors( errorRecords);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 29612, 29654);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,29430,29666);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,29430,29666);
}
		}

private CultureInfo _culture;

private void ValidateHelpCulture()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,30059,30479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30118,30169);

CultureInfo 
culture = f_1161_30140_30168()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30185,30298) || true) && (_culture == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,30185,30298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30239,30258);

_culture = culture;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30276,30283);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,30185,30298);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30314,30398) || true) && (f_1161_30318_30342(_culture, culture))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,30314,30398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30376,30383);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,30314,30398);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30414,30433);

_culture = culture;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30447,30468);

f_1161_30447_30467(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,30059,30479);

System.Globalization.CultureInfo
f_1161_30140_30168()
{
var return_v = CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 30140, 30168);
return return_v;
}


bool
f_1161_30318_30342(System.Globalization.CultureInfo
this_param,System.Globalization.CultureInfo
value)
{
var return_v = this_param.Equals( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 30318, 30342);
return return_v;
}


int
f_1161_30447_30467(System.Management.Automation.HelpSystem
this_param)
{
this_param.ResetHelpProviders();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 30447, 30467);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,30059,30479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,30059,30479);
}
		}

internal void ResetHelpProviders()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,30805,31161);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30864,30916) || true) && (_helpProviders == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,30864,30916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30909,30916);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,30864,30916);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30941,30946);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30932,31127) || true) && (i < f_1161_30952_30972(_helpProviders))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,30974,30977)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1161,30932,31127))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,30932,31127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31011,31071);

HelpProvider 
helpProvider = (HelpProvider)f_1161_31053_31070(_helpProviders, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31091,31112);

f_1161_31091_31111(
                helpProvider);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1161,1,196);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1161,1,196);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31143,31150);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,30805,31161);

int
f_1161_30952_30972(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 30952, 30972);
return return_v;
}


object
f_1161_31053_31070(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 31053, 31070);
return return_v;
}


int
f_1161_31091_31111(System.Management.Automation.HelpProvider
this_param)
{
this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 31091, 31111);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,30805,31161);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,30805,31161);
}
		}

private readonly Lazy<Dictionary<Ast, Token[]>> _scriptBlockTokenCache ;

internal Dictionary<Ast, Token[]> ScriptBlockTokenCache
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,31490,31534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31496,31532);

return f_1161_31503_31531(_scriptBlockTokenCache);
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,31490,31534);

System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
f_1161_31503_31531(System.Lazy<System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 31503, 31531);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,31410,31545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,31410,31545);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void ClearScriptBlockTokenCache()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1161,31557,31762);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31624,31751) || true) && (f_1161_31628_31665(_scriptBlockTokenCache))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1161,31624,31751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31699,31736);

f_1161_31699_31735(f_1161_31699_31727(_scriptBlockTokenCache));
DynAbs.Tracing.TraceSender.TraceExitCondition(1161,31624,31751);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1161,31557,31762);

bool
f_1161_31628_31665(System.Lazy<System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>>
this_param)
{
var return_v = this_param.IsValueCreated;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 31628, 31665);
return return_v;
}


System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
f_1161_31699_31727(System.Lazy<System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1161, 31699, 31727);
return return_v;
}


int
f_1161_31699_31735(System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 31699, 31735);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,31557,31762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,31557,31762);
}
		}

static HelpSystem()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1161,4610,31791);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1161,4610,31791);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,4610,31791);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1161,4610,31791);

System.Management.Automation.PSArgumentNullException
f_1161_4952_5010(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 4952, 5010);
return return_v;
}


int
f_1161_5086_5098(System.Management.Automation.HelpSystem
this_param)
{
this_param.Initialize();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 5086, 5098);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1161_7445_7474()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 7445, 7474);
return return_v;
}


System.Collections.ArrayList
f_1161_22518_22533()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 22518, 22533);
return return_v;
}


System.Lazy<System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>>
f_1161_31343_31397(bool
isThreadSafe)
{
var return_v = new System.Lazy<System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>>( isThreadSafe: isThreadSafe);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1161, 31343, 31397);
return return_v;
}

}
internal class HelpProgressInfo
{
internal bool Completed;

internal string Activity;

internal int PercentComplete;

public HelpProgressInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1161,31867,32020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31929,31938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31965,31973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,31997,32012);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1161,31867,32020);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,31867,32020);
}


static HelpProgressInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1161,31867,32020);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1161,31867,32020);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,31867,32020);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1161,31867,32020);
}
internal class HelpProviderInfo
{
internal string AssemblyName ;

internal string ClassName ;

internal HelpCategory HelpCategory ;

internal HelpProviderInfo(string assemblyName, string className, HelpCategory helpCategory)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1161,32694,32942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,32198,32225);
this.AssemblyName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,32252,32276);
this.ClassName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,32309,32341);
this.HelpCategory = HelpCategory.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,32810,32843);

this.AssemblyName = assemblyName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,32857,32884);

this.ClassName = className;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1161,32898,32931);

this.HelpCategory = helpCategory;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1161,32694,32942);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1161,32694,32942);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,32694,32942);
}
		}

static HelpProviderInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1161,32134,32949);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1161,32134,32949);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1161,32134,32949);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1161,32134,32949);
}

    /// <summary>
    /// Help categories.
    /// </summary>
    [Flags]
    internal enum HelpCategory
    {
        /// <summary>
        /// Undefined help category.
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Alias help.
        /// </summary>
        Alias = 0x01,

        /// <summary>
        /// Cmdlet help.
        /// </summary>
        Cmdlet = 0x02,

        /// <summary>
        /// Provider help.
        /// </summary>
        Provider = 0x04,

        /// <summary>
        /// General keyword help.
        /// </summary>
        General = 0x10,

        /// <summary>
        /// FAQ's.
        /// </summary>
        FAQ = 0x20,

        /// <summary>
        /// Glossary and term definitions.
        /// </summary>
        Glossary = 0x40,

        /// <summary>
        /// Help that is contained in help file.
        /// </summary>
        HelpFile = 0x80,

        /// <summary>
        /// Help from a script block.
        /// </summary>
        ScriptCommand = 0x100,

        /// <summary>
        /// Help for a function.
        /// </summary>
        Function = 0x200,

        /// <summary>
        /// Help for a filter.
        /// </summary>
        Filter = 0x400,

        /// <summary>
        /// Help for an external script (i.e. for a *.ps1 file)
        /// </summary>
        ExternalScript = 0x800,

        /// <summary>
        /// All help categories.
        /// </summary>
        All = 0xFFFFF,

        ///<summary>
        /// Default Help.
        /// </summary>
        DefaultHelp = 0x1000,

        ///<summary>
        /// Help for a Configuration.
        /// </summary>
        Configuration = 0x4000,

        /// <summary>
        /// Help for DSC Resource.
        /// </summary>
        DscResource = 0x8000,

        /// <summary>
        /// Help for PS Classes.
        /// </summary>
        Class = 0x10000
    }
}
