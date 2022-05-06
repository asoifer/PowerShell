// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation
{
    internal static class SpecialVariables
    {
        internal const string
        HistorySize = "MaximumHistoryCount"
        ;

        internal static readonly VariablePath HistorySizeVarPath;

        internal const string
        MyInvocation = "MyInvocation"
        ;

        internal static readonly VariablePath MyInvocationVarPath;

        internal const string
        OFS = "OFS"
        ;

        internal static readonly VariablePath OFSVarPath;

        internal const string
        OutputEncoding = "OutputEncoding"
        ;

        internal static readonly VariablePath OutputEncodingVarPath;

        internal const string
        VerboseHelpErrors = "VerboseHelpErrors"
        ;

        internal static readonly VariablePath VerboseHelpErrorsVarPath;

        internal const string
        LogEngineHealthEvent = "LogEngineHealthEvent"
        ;

        internal static readonly VariablePath LogEngineHealthEventVarPath;

        internal const string
        LogEngineLifecycleEvent = "LogEngineLifecycleEvent"
        ;

        internal static readonly VariablePath LogEngineLifecycleEventVarPath;

        internal const string
        LogCommandHealthEvent = "LogCommandHealthEvent"
        ;

        internal static readonly VariablePath LogCommandHealthEventVarPath;

        internal const string
        LogCommandLifecycleEvent = "LogCommandLifecycleEvent"
        ;

        internal static readonly VariablePath LogCommandLifecycleEventVarPath;

        internal const string
        LogProviderHealthEvent = "LogProviderHealthEvent"
        ;

        internal static readonly VariablePath LogProviderHealthEventVarPath;

        internal const string
        LogProviderLifecycleEvent = "LogProviderLifecycleEvent"
        ;

        internal static readonly VariablePath LogProviderLifecycleEventVarPath;

        internal const string
        LogSettingsEvent = "LogSettingsEvent"
        ;

        internal static readonly VariablePath LogSettingsEventVarPath;

        internal const string
        PSLogUserData = "PSLogUserData"
        ;

        internal static readonly VariablePath PSLogUserDataPath;

        internal const string
        NestedPromptLevel = "NestedPromptLevel"
        ;

        internal static readonly VariablePath NestedPromptCounterVarPath;

        internal const string
        CurrentlyExecutingCommand = "CurrentlyExecutingCommand"
        ;

        internal static readonly VariablePath CurrentlyExecutingCommandVarPath;

        internal const string
        PSBoundParameters = "PSBoundParameters"
        ;

        internal static readonly VariablePath PSBoundParametersVarPath;

        internal const string
        Matches = "Matches"
        ;

        internal static readonly VariablePath MatchesVarPath;

        internal const string
        LastExitCode = "LASTEXITCODE"
        ;

        internal static readonly VariablePath LastExitCodeVarPath;

        internal const string
        PSDebugContext = "PSDebugContext"
        ;

        internal static readonly VariablePath PSDebugContextVarPath;

        internal const string
        StackTrace = "StackTrace"
        ;

        internal static readonly VariablePath StackTraceVarPath;

        internal const string
        FirstToken = "^"
        ;

        internal static readonly VariablePath FirstTokenVarPath;

        internal const string
        LastToken = "$"
        ;

        internal static readonly VariablePath LastTokenVarPath;

        internal static bool IsUnderbar(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1362, 5144, 5235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5191, 5233);

                return f_1362_5198_5209(name) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1362, 5198, 5232) && f_1362_5218_5225(name, 0) == '_');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1362, 5144, 5235);

                int
                f_1362_5198_5209(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1362, 5198, 5209);
                    return return_v;
                }


                char
                f_1362_5218_5225(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1362, 5218, 5225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1362, 5144, 5235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1362, 5144, 5235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        PSItem = "PSItem"
        ;

        internal const string
        Underbar = "_"
        ;

        internal static readonly VariablePath UnderbarVarPath;

        internal const string
        Question = "?"
        ;

        internal static readonly VariablePath QuestionVarPath;

        internal const string
        Args = "args"
        ;

        internal static readonly VariablePath ArgsVarPath;

        internal const string
        This = "this"
        ;

        internal static readonly VariablePath ThisVarPath;

        internal const string
        Input = "input"
        ;

        internal static readonly VariablePath InputVarPath;

        internal const string
        PSCmdlet = "PSCmdlet"
        ;

        internal static readonly VariablePath PSCmdletVarPath;

        internal const string
        Error = "error"
        ;

        internal static readonly VariablePath ErrorVarPath;

        internal const string
        EventError = "error"
        ;

        internal static readonly VariablePath EventErrorVarPath;

        internal const string
        PathExt = "env:PATHEXT"
        ;

        internal static readonly VariablePath PathExtVarPath;

        internal const string
        PSEmailServer = "PSEmailServer"
        ;

        internal static readonly VariablePath PSEmailServerVarPath;

        internal const string
        PSDefaultParameterValues = "PSDefaultParameterValues"
        ;

        internal static readonly VariablePath PSDefaultParameterValuesVarPath;

        internal const string
        PSScriptRoot = "PSScriptRoot"
        ;

        internal static readonly VariablePath PSScriptRootVarPath;

        internal const string
        PSCommandPath = "PSCommandPath"
        ;

        internal static readonly VariablePath PSCommandPathVarPath;

        internal const string
        PSSenderInfo = "PSSenderInfo"
        ;

        internal static readonly VariablePath PSSenderInfoVarPath;

        internal const string
        @foreach = "foreach"
        ;

        internal static readonly VariablePath foreachVarPath;

        internal const string
        @switch = "switch"
        ;

        internal static readonly VariablePath switchVarPath;

        internal const string
        pwd = "PWD"
        ;

        internal static VariablePath PWDVarPath;

        internal const string
        Null = "null"
        ;

        internal static VariablePath NullVarPath;

        internal const string
        True = "true"
        ;

        internal static VariablePath TrueVarPath;

        internal const string
        False = "false"
        ;

        internal static VariablePath FalseVarPath;

        internal const string
        PSModuleAutoLoading = "PSModuleAutoLoadingPreference"
        ;

        internal static VariablePath PSModuleAutoLoadingPreferenceVarPath;

        internal const string
        IsLinux = "IsLinux"
        ;

        internal static VariablePath IsLinuxPath;

        internal const string
        IsMacOS = "IsMacOS"
        ;

        internal static VariablePath IsMacOSPath;

        internal const string
        IsWindows = "IsWindows"
        ;

        internal static VariablePath IsWindowsPath;

        internal const string
        IsCoreCLR = "IsCoreCLR"
        ;

        internal static VariablePath IsCoreCLRPath;

        internal const string
        DebugPreference = "DebugPreference"
        ;

        internal static readonly VariablePath DebugPreferenceVarPath;

        internal const string
        ErrorActionPreference = "ErrorActionPreference"
        ;

        internal static readonly VariablePath ErrorActionPreferenceVarPath;

        internal const string
        ProgressPreference = "ProgressPreference"
        ;

        internal static readonly VariablePath ProgressPreferenceVarPath;

        internal const string
        VerbosePreference = "VerbosePreference"
        ;

        internal static readonly VariablePath VerbosePreferenceVarPath;

        internal const string
        WarningPreference = "WarningPreference"
        ;

        internal static readonly VariablePath WarningPreferenceVarPath;

        internal const string
        WhatIfPreference = "WhatIfPreference"
        ;

        internal static readonly VariablePath WhatIfPreferenceVarPath;

        internal const string
        ConfirmPreference = "ConfirmPreference"
        ;

        internal static readonly VariablePath ConfirmPreferenceVarPath;

        internal const string
        InformationPreference = "InformationPreference"
        ;

        internal static readonly VariablePath InformationPreferenceVarPath;

        internal const string
        ErrorView = "ErrorView"
        ;

        internal static readonly VariablePath ErrorViewVarPath;

        internal const string
        PSSessionConfigurationName = "PSSessionConfigurationName"
        ;

        internal static readonly VariablePath PSSessionConfigurationNameVarPath;

        internal const string
        PSSessionApplicationName = "PSSessionApplicationName"
        ;

        internal static readonly VariablePath PSSessionApplicationNameVarPath;

        internal const string
        ExecutionContext = "ExecutionContext"
        ;

        internal const string
        Home = "HOME"
        ;

        internal const string
        Host = "Host"
        ;

        internal const string
        PID = "PID"
        ;

        internal const string
        PSCulture = "PSCulture"
        ;

        internal const string
        PSHome = "PSHOME"
        ;

        internal const string
        PSUICulture = "PSUICulture"
        ;

        internal const string
        PSVersionTable = "PSVersionTable"
        ;

        internal const string
        PSEdition = "PSEdition"
        ;

        internal const string
        ShellId = "ShellId"
        ;

        internal const string
        EnabledExperimentalFeatures = "EnabledExperimentalFeatures"
        ;

        internal static readonly string[] AutomaticVariables;

        internal static readonly Type[] AutomaticVariableTypes;

        internal static readonly string[] PreferenceVariables;

        internal static readonly Type[] PreferenceVariableTypes;

        internal static readonly string[] AllScopeVariables;

        private static readonly HashSet<string> s_classMethodsAccessibleVariables;

        internal static bool IsImplicitVariableAccessibleInClassMethod(VariablePath variablePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1362, 18892, 19090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 19006, 19079);

                return f_1362_19013_19078(s_classMethodsAccessibleVariables, f_1362_19056_19077(variablePath));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1362, 18892, 19090);

                string
                f_1362_19056_19077(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1362, 19056, 19077);
                    return return_v;
                }


                bool
                f_1362_19013_19078(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 19013, 19078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1362, 18892, 19090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1362, 18892, 19090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SpecialVariables()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1362, 1020, 19097);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1097, 1132);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1181, 1231);
            HistorySizeVarPath = f_1362_1202_1231(HistorySize);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1266, 1295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1344, 1396);
            MyInvocationVarPath = f_1362_1366_1396(MyInvocation);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1431, 1442);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1491, 1525);
            OFSVarPath = f_1362_1504_1525(OFS);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1560, 1593);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1642, 1698);
            OutputEncodingVarPath = f_1362_1666_1698(OutputEncoding);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1733, 1772);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1821, 1883);
            VerboseHelpErrorsVarPath = f_1362_1848_1883(VerboseHelpErrors);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 1955, 2000);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2049, 2117);
            LogEngineHealthEventVarPath = f_1362_2079_2117(LogEngineHealthEvent);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2152, 2203);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2252, 2326);
            LogEngineLifecycleEventVarPath = f_1362_2285_2326(LogEngineLifecycleEvent);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2361, 2408);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2457, 2527);
            LogCommandHealthEventVarPath = f_1362_2488_2527(LogCommandHealthEvent);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2562, 2615);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2664, 2740);
            LogCommandLifecycleEventVarPath = f_1362_2698_2740(LogCommandLifecycleEvent);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2775, 2824);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2873, 2945);
            LogProviderHealthEventVarPath = f_1362_2905_2945(LogProviderHealthEvent);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 2980, 3035);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3084, 3162);
            LogProviderLifecycleEventVarPath = f_1362_3119_3162(LogProviderLifecycleEvent);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3197, 3234);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3283, 3343);
            LogSettingsEventVarPath = f_1362_3309_3343(LogSettingsEvent);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3378, 3409);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3458, 3509);
            PSLogUserDataPath = f_1362_3478_3509(PSLogUserData);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3584, 3623);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3672, 3748);
            NestedPromptCounterVarPath = f_1362_3701_3748("global:" + NestedPromptLevel);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3783, 3838);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 3887, 3965);
            CurrentlyExecutingCommandVarPath = f_1362_3922_3965(CurrentlyExecutingCommand);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4000, 4039);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4088, 4150);
            PSBoundParametersVarPath = f_1362_4115_4150(PSBoundParameters);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4185, 4204);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4253, 4295);
            MatchesVarPath = f_1362_4270_4295(Matches);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4330, 4359);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4408, 4472);
            LastExitCodeVarPath = f_1362_4430_4472("global:" + LastExitCode);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4507, 4540);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4589, 4645);
            PSDebugContextVarPath = f_1362_4613_4645(PSDebugContext);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4680, 4705);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4754, 4814);
            StackTraceVarPath = f_1362_4774_4814("global:" + StackTrace);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4849, 4865);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 4914, 4974);
            FirstTokenVarPath = f_1362_4934_4974("global:" + FirstToken);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5009, 5024);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5073, 5131);
            LastTokenVarPath = f_1362_5092_5131("global:" + LastToken);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5269, 5286);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5343, 5357);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5406, 5450);
            UnderbarVarPath = f_1362_5424_5450(Underbar);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5485, 5499);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5548, 5592);
            QuestionVarPath = f_1362_5566_5592(Question);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5627, 5640);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5689, 5736);
            ArgsVarPath = f_1362_5703_5736("local:" + Args);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5771, 5784);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5833, 5871);
            ThisVarPath = f_1362_5847_5871("this");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5906, 5921);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 5970, 6019);
            InputVarPath = f_1362_5985_6019("local:" + Input);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6054, 6075);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6124, 6170);
            PSCmdletVarPath = f_1362_6142_6170("PSCmdlet");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6205, 6220);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6269, 6319);
            ErrorVarPath = f_1362_6284_6319("global:" + Error);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6354, 6374);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6423, 6483);
            EventErrorVarPath = f_1362_6443_6483("script:" + EventError);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6527, 6550);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6599, 6641);
            PathExtVarPath = f_1362_6616_6641(PathExt);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6682, 6713);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6762, 6816);
            PSEmailServerVarPath = f_1362_6785_6816(PSEmailServer);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6851, 6904);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 6953, 7029);
            PSDefaultParameterValuesVarPath = f_1362_6987_7029(PSDefaultParameterValues);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7064, 7093);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7142, 7194);
            PSScriptRootVarPath = f_1362_7164_7194(PSScriptRoot);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7229, 7260);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7309, 7363);
            PSCommandPathVarPath = f_1362_7332_7363(PSCommandPath);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7398, 7427);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7476, 7528);
            PSSenderInfoVarPath = f_1362_7498_7528(PSSenderInfo);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7563, 7583);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7632, 7686);
            foreachVarPath = f_1362_7649_7686("local:" + @foreach);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7721, 7739);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7788, 7840);
            switchVarPath = f_1362_7804_7840("local:" + @switch);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7875, 7886);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 7926, 7972);
            PWDVarPath = f_1362_7939_7972("global:" + pwd);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8007, 8020);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8060, 8098);
            NullVarPath = f_1362_8074_8098("null");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8133, 8146);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8186, 8224);
            TrueVarPath = f_1362_8200_8224("true");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8259, 8274);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8314, 8354);
            FalseVarPath = f_1362_8329_8354("false");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8389, 8442);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8482, 8570);
            PSModuleAutoLoadingPreferenceVarPath = f_1362_8521_8570("global:" + PSModuleAutoLoading);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8641, 8660);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8700, 8741);
            IsLinuxPath = f_1362_8714_8741("IsLinux");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8776, 8795);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8835, 8876);
            IsMacOSPath = f_1362_8849_8876("IsMacOS");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8911, 8934);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 8974, 9019);
            IsWindowsPath = f_1362_8990_9019("IsWindows");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9054, 9077);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9117, 9162);
            IsCoreCLRPath = f_1362_9133_9162("IsCoreCLR");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9257, 9292);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9341, 9399);
            DebugPreferenceVarPath = f_1362_9366_9399(DebugPreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9434, 9481);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9530, 9600);
            ErrorActionPreferenceVarPath = f_1362_9561_9600(ErrorActionPreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9635, 9676);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9725, 9789);
            ProgressPreferenceVarPath = f_1362_9753_9789(ProgressPreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9824, 9863);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 9912, 9974);
            VerbosePreferenceVarPath = f_1362_9939_9974(VerbosePreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10009, 10048);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10097, 10159);
            WarningPreferenceVarPath = f_1362_10124_10159(WarningPreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10194, 10231);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10280, 10340);
            WhatIfPreferenceVarPath = f_1362_10306_10340(WhatIfPreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10375, 10414);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10463, 10525);
            ConfirmPreferenceVarPath = f_1362_10490_10525(ConfirmPreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10560, 10607);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10656, 10726);
            InformationPreferenceVarPath = f_1362_10687_10726(InformationPreference);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10804, 10827);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 10876, 10922);
            ErrorViewVarPath = f_1362_10895_10922(ErrorView);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11045, 11102);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11151, 11243);
            PSSessionConfigurationNameVarPath = f_1362_11187_11243("global:" + PSSessionConfigurationName);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11442, 11495);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11544, 11632);
            PSSessionApplicationNameVarPath = f_1362_11578_11632("global:" + PSSessionApplicationName);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11730, 11767);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11800, 11813);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11846, 11859);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11892, 11903);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11936, 11959);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 11992, 12009);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 12042, 12069);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 12102, 12135);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 12168, 12191);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 12224, 12243);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 12276, 12335);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 12448, 13402);
            AutomaticVariables = new string[]{
                                                                   SpecialVariables.Underbar,
                                                                   SpecialVariables.Args,
                                                                   SpecialVariables.This,
                                                                   SpecialVariables.Input,
                                                                   SpecialVariables.PSCmdlet,
                                                                   SpecialVariables.PSBoundParameters,
                                                                   SpecialVariables.MyInvocation,
                                                                   SpecialVariables.PSScriptRoot,
                                                                   SpecialVariables.PSCommandPath,
                                                               };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 13447, 14552);
            AutomaticVariableTypes = new Type[]{
                                                                   /* Underbar */          typeof(object),
                                                                   /* Args */              typeof(object[]),
                                                                   /* This */              typeof(object),
                                                                   /* Input */             typeof(object),
                                                                   /* PSCmdlet */          typeof(PSScriptCmdlet),
                                                                   /* PSBoundParameters */ typeof(PSBoundParametersDictionary),
                                                                   /* MyInvocation */      typeof(InvocationInfo),
                                                                   /* PSScriptRoot */      typeof(string),
                                                                   /* PSCommandPath */     typeof(string),
                                                                 };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 14599, 15429);
            PreferenceVariables = new string[]{
                                                                    SpecialVariables.DebugPreference,
                                                                    SpecialVariables.VerbosePreference,
                                                                    SpecialVariables.ErrorActionPreference,
                                                                    SpecialVariables.WhatIfPreference,
                                                                    SpecialVariables.WarningPreference,
                                                                    SpecialVariables.InformationPreference,
                                                                    SpecialVariables.ConfirmPreference,
                                                                };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 15474, 16427);
            PreferenceVariableTypes = new Type[]{
                                                                    /* DebugPreference */       typeof(ActionPreference),
                                                                    /* VerbosePreference */     typeof(ActionPreference),
                                                                    /* ErrorPreference */       typeof(ActionPreference),
                                                                    /* WhatIfPreference */      typeof(SwitchParameter),
                                                                    /* WarningPreference */     typeof(ActionPreference),
                                                                    /* InformationPreference */ typeof(ActionPreference),
                                                                    /* ConfirmPreference */     typeof(ConfirmImpact),
                                                                  };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 16857, 18274);
            AllScopeVariables = new string[]{
                                                                  SpecialVariables.Question,
                                                                  SpecialVariables.ExecutionContext,
                                                                  SpecialVariables.False,
                                                                  SpecialVariables.Home,
                                                                  SpecialVariables.Host,
                                                                  SpecialVariables.PID,
                                                                  SpecialVariables.PSCulture,
                                                                  SpecialVariables.PSHome,
                                                                  SpecialVariables.PSUICulture,
                                                                  SpecialVariables.PSVersionTable,
                                                                  SpecialVariables.PSEdition,
                                                                  SpecialVariables.ShellId,
                                                                  SpecialVariables.True,
                                                                  SpecialVariables.EnabledExperimentalFeatures,
                                                              };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1362, 18327, 18879);
            s_classMethodsAccessibleVariables = f_1362_18363_18879(new string[]
                            {
                    SpecialVariables.LastExitCode,
                    SpecialVariables.Error,
                    SpecialVariables.StackTrace,
                    SpecialVariables.OutputEncoding,
                    SpecialVariables.NestedPromptLevel,
                    SpecialVariables.pwd,
                    SpecialVariables.Matches,
                            }, f_1362_18832_18864());
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1362, 1020, 19097);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1362, 1020, 19097);
        }


        static System.Management.Automation.VariablePath
        f_1362_1202_1231(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 1202, 1231);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_1366_1396(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 1366, 1396);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_1504_1525(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 1504, 1525);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_1666_1698(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 1666, 1698);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_1848_1883(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 1848, 1883);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_2079_2117(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 2079, 2117);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_2285_2326(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 2285, 2326);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_2488_2527(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 2488, 2527);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_2698_2740(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 2698, 2740);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_2905_2945(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 2905, 2945);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_3119_3162(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 3119, 3162);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_3309_3343(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 3309, 3343);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_3478_3509(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 3478, 3509);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_3701_3748(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 3701, 3748);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_3922_3965(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 3922, 3965);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_4115_4150(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 4115, 4150);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_4270_4295(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 4270, 4295);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_4430_4472(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 4430, 4472);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_4613_4645(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 4613, 4645);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_4774_4814(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 4774, 4814);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_4934_4974(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 4934, 4974);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_5092_5131(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 5092, 5131);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_5424_5450(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 5424, 5450);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_5566_5592(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 5566, 5592);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_5703_5736(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 5703, 5736);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_5847_5871(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 5847, 5871);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_5985_6019(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 5985, 6019);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_6142_6170(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 6142, 6170);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_6284_6319(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 6284, 6319);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_6443_6483(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 6443, 6483);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_6616_6641(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 6616, 6641);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_6785_6816(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 6785, 6816);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_6987_7029(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 6987, 7029);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_7164_7194(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 7164, 7194);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_7332_7363(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 7332, 7363);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_7498_7528(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 7498, 7528);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_7649_7686(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 7649, 7686);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_7804_7840(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 7804, 7840);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_7939_7972(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 7939, 7972);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_8074_8098(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 8074, 8098);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_8200_8224(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 8200, 8224);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_8329_8354(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 8329, 8354);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_8521_8570(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 8521, 8570);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_8714_8741(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 8714, 8741);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_8849_8876(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 8849, 8876);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_8990_9019(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 8990, 9019);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_9133_9162(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 9133, 9162);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_9366_9399(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 9366, 9399);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_9561_9600(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 9561, 9600);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_9753_9789(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 9753, 9789);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_9939_9974(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 9939, 9974);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_10124_10159(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 10124, 10159);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_10306_10340(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 10306, 10340);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_10490_10525(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 10490, 10525);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_10687_10726(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 10687, 10726);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_10895_10922(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 10895, 10922);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_11187_11243(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 11187, 11243);
            return return_v;
        }


        static System.Management.Automation.VariablePath
        f_1362_11578_11632(string
        path)
        {
            var return_v = new System.Management.Automation.VariablePath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 11578, 11632);
            return return_v;
        }


        static System.StringComparer
        f_1362_18832_18864()
        {
            var return_v = StringComparer.OrdinalIgnoreCase
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1362, 18832, 18864);
            return return_v;
        }


        static System.Collections.Generic.HashSet<string>
        f_1362_18363_18879(string[]
        collection, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEnumerable<string>)collection, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1362, 18363, 18879);
            return return_v;
        }

    }

    internal enum AutomaticVariable
    {
        Underbar = 0,
        Args = 1,
        This = 2,
        Input = 3,
        PSCmdlet = 4,
        PSBoundParameters = 5,
        MyInvocation = 6,
        PSScriptRoot = 7,
        PSCommandPath = 8,
        NumberOfAutomaticVariables // 1 + the last, used to initialize global scope.
    }

    internal enum PreferenceVariable
    {
        Debug = 9,
        Verbose = 10,
        Error = 11,
        WhatIf = 12,
        Warning = 13,
        Information = 14,
        Confirm = 15,
    }
}
