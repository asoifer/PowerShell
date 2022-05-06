// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
internal static class StringLiterals
{
internal const string 
ProviderPathSeparator = "::"
;

internal static readonly char DefaultPathSeparator ;

internal static readonly string DefaultPathSeparatorString ;

internal static readonly char AlternatePathSeparator ;

internal static readonly string AlternatePathSeparatorString ;

internal const string 
DefaultRemotePathPrefix = "\\\\"
;

internal const string 
AlternateRemotePathPrefix = "//"
;

internal const string 
HomePath = "~"
;

internal const string 
Global = "GLOBAL"
;

internal const string 
Local = "LOCAL"
;

internal const string 
Private = "PRIVATE"
;

internal const string 
Script = "SCRIPT"
;

internal const string 
SessionState = "SessionState"
;

internal const string 
PowerShellScriptFileExtension = ".ps1"
;

internal const string 
PowerShellModuleFileExtension = ".psm1"
;

internal const string 
PowerShellMofFileExtension = ".mof"
;

internal const string 
PowerShellCmdletizationFileExtension = ".cdxml"
;

internal const string 
PowerShellDISCFileExtension = ".pssc"
;

internal const string 
PowerShellRoleCapabilityFileExtension = ".psrc"
;

internal const string 
PowerShellDataFileExtension = ".psd1"
;

internal const string 
PowerShellILAssemblyExtension = ".dll"
;

internal const string 
PowerShellNgenAssemblyExtension = ".ni.dll"
;

internal const string 
PowerShellILExecutableExtension = ".exe"
;

internal const string 
PowerShellConsoleFileExtension = ".psc1"
;

internal const char 
CommandVerbNounSeparator = '-'
;

internal const string 
DefaultCommandVerb = "get"
;

internal const string 
HelpFileExtension = "-Help.xml"
;

internal const string 
DollarNull = "$null"
;

internal const string 
Null = "null"
;

internal const string 
False = "false"
;

internal const string 
True = "true"
;

internal const char 
EscapeCharacter = '`'
;

internal const string 
DefaultCmdletAdapter = "Microsoft.PowerShell.Cmdletization.Cim.CimCmdletAdapter, Microsoft.PowerShell.Commands.Management, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
;

static StringLiterals()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1358,261,7191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,516,544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,899,959);
DefaultPathSeparator = System.IO.Path.DirectorySeparatorChar;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,1002,1062);
DefaultPathSeparatorString = f_1358_1031_1062(DefaultPathSeparator);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,1589,1645);
AlternatePathSeparator = (DynAbs.Tracing.TraceSender.Conditional_F1(1358, 1614, 1632)||((f_1358_1614_1632()&&DynAbs.Tracing.TraceSender.Conditional_F2(1358, 1635, 1638))||DynAbs.Tracing.TraceSender.Conditional_F3(1358, 1641, 1645)))?'/' :'\\';DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,1688,1752);
AlternatePathSeparatorString = f_1358_1719_1752(AlternatePathSeparator);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,1949,1981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,2180,2212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,2367,2381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,2547,2564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,2718,2733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,2931,2950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,3171,3188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,3341,3370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,3534,3572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,3736,3775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,3925,3960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,4130,4177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,4367,4404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,4576,4623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,4785,4822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,4991,5029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,5203,5246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,5403,5443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,5478,5518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,5682,5712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,5864,5890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,6059,6090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,6222,6242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,6374,6387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,6520,6535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,6667,6680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,6816,6837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1358,6994,7183);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1358,261,7191);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1358,261,7191);
}


static string
f_1358_1031_1062(char
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1358, 1031, 1062);
return return_v;
}


static bool
f_1358_1614_1632()
{
var return_v = Platform.IsWindows ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1358, 1614, 1632);
return return_v;
}


static string
f_1358_1719_1752(char
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1358, 1719, 1752);
return return_v;
}

}
}
