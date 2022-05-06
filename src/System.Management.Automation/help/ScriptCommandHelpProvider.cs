// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
internal class ScriptCommandHelpProvider : CommandHelpProvider
{
internal ScriptCommandHelpProvider(HelpSystem helpSystem)
:base(f_1175_890_900_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1175,812,923);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1175,812,923);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1175,812,923);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1175,812,923);
}
		}

internal override HelpCategory HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1175,1228,1523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1175,1264,1508);

return
                    HelpCategory.ExternalScript |
                    HelpCategory.Filter |
                    HelpCategory.Function |
                    HelpCategory.Configuration |
                    HelpCategory.ScriptCommand;
DynAbs.Tracing.TraceSender.TraceExitMethod(1175,1228,1523);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1175,1160,1534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1175,1160,1534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override CommandSearcher GetCommandSearcherForExactMatch(string commandName, ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1175,1788,2239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1175,1924,2196);

CommandSearcher 
searcher = f_1175_1951_2195(commandName, SearchResolutionOptions.None, CommandTypes.Filter | CommandTypes.Function | CommandTypes.ExternalScript | CommandTypes.Configuration, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1175,2212,2228);

return searcher;
DynAbs.Tracing.TraceSender.TraceExitMethod(1175,1788,2239);

System.Management.Automation.CommandSearcher
f_1175_1951_2195(string
commandName,System.Management.Automation.SearchResolutionOptions
options,System.Management.Automation.CommandTypes
commandTypes,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.CommandSearcher( commandName, options, commandTypes, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1175, 1951, 2195);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1175,1788,2239);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1175,1788,2239);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override CommandSearcher GetCommandSearcherForSearch(string pattern, ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1175,2481,3039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1175,2609,2996);

CommandSearcher 
searcher =
f_1175_2657_2995(pattern, SearchResolutionOptions.CommandNameIsPattern | SearchResolutionOptions.ResolveFunctionPatterns, CommandTypes.Filter | CommandTypes.Function | CommandTypes.ExternalScript | CommandTypes.Configuration, context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1175,3012,3028);

return searcher;
DynAbs.Tracing.TraceSender.TraceExitMethod(1175,2481,3039);

System.Management.Automation.CommandSearcher
f_1175_2657_2995(string
commandName,System.Management.Automation.SearchResolutionOptions
options,System.Management.Automation.CommandTypes
commandTypes,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.CommandSearcher( commandName, options, commandTypes, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1175, 2657, 2995);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1175,2481,3039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1175,2481,3039);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ScriptCommandHelpProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1175,636,3068);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1175,636,3068);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1175,636,3068);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1175,636,3068);

static System.Management.Automation.HelpSystem
f_1175_890_900_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1175, 812, 923);
return return_v;
}

}
}
