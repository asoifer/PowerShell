// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Host;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    /// <summary>
    /// The RemoteHostMethodId enum.
    /// </summary>
    internal enum RemoteHostMethodId
    {
        // Host read-only properties.
        GetName = 1,
        GetVersion = 2,
        GetInstanceId = 3,
        GetCurrentCulture = 4,
        GetCurrentUICulture = 5,

        // Host methods.
        SetShouldExit = 6,
        EnterNestedPrompt = 7,
        ExitNestedPrompt = 8,
        NotifyBeginApplication = 9,
        NotifyEndApplication = 10,

        // Host UI methods.
        ReadLine = 11,
        ReadLineAsSecureString = 12,
        Write1 = 13,
        Write2 = 14,
        WriteLine1 = 15,
        WriteLine2 = 16,
        WriteLine3 = 17,
        WriteErrorLine = 18,
        WriteDebugLine = 19,
        WriteProgress = 20,
        WriteVerboseLine = 21,
        WriteWarningLine = 22,
        Prompt = 23,
        PromptForCredential1 = 24,
        PromptForCredential2 = 25,
        PromptForChoice = 26,

        // Host Raw UI read-write properties.
        GetForegroundColor = 27,
        SetForegroundColor = 28,
        GetBackgroundColor = 29,
        SetBackgroundColor = 30,
        GetCursorPosition = 31,
        SetCursorPosition = 32,
        GetWindowPosition = 33,
        SetWindowPosition = 34,
        GetCursorSize = 35,
        SetCursorSize = 36,
        GetBufferSize = 37,
        SetBufferSize = 38,
        GetWindowSize = 39,
        SetWindowSize = 40,
        GetWindowTitle = 41,
        SetWindowTitle = 42,

        // Host Raw UI read-only properties.
        GetMaxWindowSize = 43,
        GetMaxPhysicalWindowSize = 44,
        GetKeyAvailable = 45,

        // Host Raw UI methods.
        ReadKey = 46,
        FlushInputBuffer = 47,
        SetBufferContents1 = 48,
        SetBufferContents2 = 49,
        GetBufferContents = 50,
        ScrollBufferContents = 51,

        // IHostSupportsInteractiveSession methods.
        PushRunspace = 52,
        PopRunspace = 53,

        // IHostSupportsInteractiveSession read-only properties.
        GetIsRunspacePushed = 54,
        GetRunspace = 55,

        // IHostSupportsMultipleChoiceSelection
        PromptForChoiceMultipleSelection = 56,
    }
    internal class RemoteHostMethodInfo
    {
        internal Type InterfaceType { get; }

        internal string Name { get; }

        internal Type ReturnType { get; }

        internal Type[] ParameterTypes { get; }

        internal RemoteHostMethodInfo(
                    Type interfaceType,
                    string name,
                    Type returnType,
                    Type[] parameterTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1645, 3425, 3756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 2917, 2953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3031, 3060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3145, 3178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3267, 3306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3605, 3635);

                InterfaceType = interfaceType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3649, 3661);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3675, 3699);

                ReturnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3713, 3745);

                ParameterTypes = parameterTypes;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1645, 3425, 3756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1645, 3425, 3756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1645, 3425, 3756);
            }
        }

        internal static RemoteHostMethodInfo LookUp(RemoteHostMethodId methodId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1645, 3837, 22370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 3934, 22359);

                switch (methodId)
                {

                    case RemoteHostMethodId.GetName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 4087, 4280);

                        return f_1645_4094_4279(typeof(PSHost), "get_Name", typeof(string), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetVersion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 4357, 4554);

                        return f_1645_4364_4553(typeof(PSHost), "get_Version", typeof(Version), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetInstanceId:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 4634, 4831);

                        return f_1645_4641_4830(typeof(PSHost), "get_InstanceId", typeof(Guid), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetCurrentCulture:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 4915, 5144);

                        return f_1645_4922_5143(typeof(PSHost), "get_CurrentCulture", typeof(System.Globalization.CultureInfo), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetCurrentUICulture:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 5230, 5461);

                        return f_1645_5237_5460(typeof(PSHost), "get_CurrentUICulture", typeof(System.Globalization.CultureInfo), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetShouldExit:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 5577, 5785);

                        return f_1645_5584_5784(typeof(PSHost), "SetShouldExit", typeof(void), new Type[] { typeof(int) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.EnterNestedPrompt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 5869, 6069);

                        return f_1645_5876_6068(typeof(PSHost), "EnterNestedPrompt", typeof(void), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.ExitNestedPrompt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 6152, 6351);

                        return f_1645_6159_6350(typeof(PSHost), "ExitNestedPrompt", typeof(void), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.NotifyBeginApplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 6440, 6645);

                        return f_1645_6447_6644(typeof(PSHost), "NotifyBeginApplication", typeof(void), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.NotifyEndApplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 6732, 6935);

                        return f_1645_6739_6934(typeof(PSHost), "NotifyEndApplication", typeof(void), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.ReadLine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 7049, 7255);

                        return f_1645_7056_7254(typeof(PSHostUserInterface), "ReadLine", typeof(string), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.ReadLineAsSecureString:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 7344, 7586);

                        return f_1645_7351_7585(typeof(PSHostUserInterface), "ReadLineAsSecureString", typeof(System.Security.SecureString), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.Write1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 7659, 7875);

                        return f_1645_7666_7874(typeof(PSHostUserInterface), "Write", typeof(void), new Type[] { typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.Write2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 7948, 8208);

                        return f_1645_7955_8207(typeof(PSHostUserInterface), "Write", typeof(void), new Type[] { typeof(ConsoleColor), typeof(ConsoleColor), typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteLine1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 8285, 8490);

                        return f_1645_8292_8489(typeof(PSHostUserInterface), "WriteLine", typeof(void), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteLine2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 8567, 8787);

                        return f_1645_8574_8786(typeof(PSHostUserInterface), "WriteLine", typeof(void), new Type[] { typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteLine3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 8864, 9128);

                        return f_1645_8871_9127(typeof(PSHostUserInterface), "WriteLine", typeof(void), new Type[] { typeof(ConsoleColor), typeof(ConsoleColor), typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteErrorLine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 9209, 9434);

                        return f_1645_9216_9433(typeof(PSHostUserInterface), "WriteErrorLine", typeof(void), new Type[] { typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteDebugLine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 9515, 9740);

                        return f_1645_9522_9739(typeof(PSHostUserInterface), "WriteDebugLine", typeof(void), new Type[] { typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteProgress:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 9820, 10066);

                        return f_1645_9827_10065(typeof(PSHostUserInterface), "WriteProgress", typeof(void), new Type[] { typeof(long), typeof(ProgressRecord) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteVerboseLine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 10149, 10376);

                        return f_1645_10156_10375(typeof(PSHostUserInterface), "WriteVerboseLine", typeof(void), new Type[] { typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.WriteWarningLine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 10459, 10686);

                        return f_1645_10466_10685(typeof(PSHostUserInterface), "WriteWarningLine", typeof(void), new Type[] { typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.Prompt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 10759, 11085);

                        return f_1645_10766_11084(typeof(PSHostUserInterface), "Prompt", typeof(Dictionary<string, PSObject>), new Type[] { typeof(string), typeof(string), typeof(System.Collections.ObjectModel.Collection<FieldDescription>) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.PromptForCredential1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 11172, 11458);

                        return f_1645_11179_11457(typeof(PSHostUserInterface), "PromptForCredential", typeof(PSCredential), new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.PromptForCredential2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 11545, 11889);

                        return f_1645_11552_11888(typeof(PSHostUserInterface), "PromptForCredential", typeof(PSCredential), new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(PSCredentialTypes), typeof(PSCredentialUIOptions) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.PromptForChoice:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 11971, 12295);

                        return f_1645_11978_12294(typeof(PSHostUserInterface), "PromptForChoice", typeof(int), new Type[] { typeof(string), typeof(string), typeof(System.Collections.ObjectModel.Collection<ChoiceDescription>), typeof(int) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.PromptForChoiceMultipleSelection:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 12394, 12731);

                        return f_1645_12401_12730(typeof(IHostUISupportsMultipleChoiceSelection), "PromptForChoice", typeof(Collection<int>), new Type[] { typeof(string), typeof(string), typeof(Collection<ChoiceDescription>), typeof(IEnumerable<int>) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetForegroundColor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 12873, 13099);

                        return f_1645_12880_13098(typeof(PSHostRawUserInterface), "get_ForegroundColor", typeof(ConsoleColor), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetForegroundColor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 13184, 13423);

                        return f_1645_13191_13422(typeof(PSHostRawUserInterface), "set_ForegroundColor", typeof(void), new Type[] { typeof(ConsoleColor) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetBackgroundColor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 13508, 13734);

                        return f_1645_13515_13733(typeof(PSHostRawUserInterface), "get_BackgroundColor", typeof(ConsoleColor), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetBackgroundColor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 13819, 14058);

                        return f_1645_13826_14057(typeof(PSHostRawUserInterface), "set_BackgroundColor", typeof(void), new Type[] { typeof(ConsoleColor) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetCursorPosition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 14142, 14366);

                        return f_1645_14149_14365(typeof(PSHostRawUserInterface), "get_CursorPosition", typeof(Coordinates), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetCursorPosition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 14450, 14687);

                        return f_1645_14457_14686(typeof(PSHostRawUserInterface), "set_CursorPosition", typeof(void), new Type[] { typeof(Coordinates) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetWindowPosition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 14771, 14995);

                        return f_1645_14778_14994(typeof(PSHostRawUserInterface), "get_WindowPosition", typeof(Coordinates), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetWindowPosition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 15079, 15316);

                        return f_1645_15086_15315(typeof(PSHostRawUserInterface), "set_WindowPosition", typeof(void), new Type[] { typeof(Coordinates) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetCursorSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 15396, 15608);

                        return f_1645_15403_15607(typeof(PSHostRawUserInterface), "get_CursorSize", typeof(int), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetCursorSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 15688, 15913);

                        return f_1645_15695_15912(typeof(PSHostRawUserInterface), "set_CursorSize", typeof(void), new Type[] { typeof(int) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetBufferSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 15993, 16206);

                        return f_1645_16000_16205(typeof(PSHostRawUserInterface), "get_BufferSize", typeof(Size), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetBufferSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 16286, 16512);

                        return f_1645_16293_16511(typeof(PSHostRawUserInterface), "set_BufferSize", typeof(void), new Type[] { typeof(Size) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetWindowSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 16592, 16805);

                        return f_1645_16599_16804(typeof(PSHostRawUserInterface), "get_WindowSize", typeof(Size), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetWindowSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 16885, 17111);

                        return f_1645_16892_17110(typeof(PSHostRawUserInterface), "set_WindowSize", typeof(void), new Type[] { typeof(Size) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetWindowTitle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 17192, 17408);

                        return f_1645_17199_17407(typeof(PSHostRawUserInterface), "get_WindowTitle", typeof(string), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetWindowTitle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 17489, 17718);

                        return f_1645_17496_17717(typeof(PSHostRawUserInterface), "set_WindowTitle", typeof(void), new Type[] { typeof(string) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetMaxWindowSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 17857, 18073);

                        return f_1645_17864_18072(typeof(PSHostRawUserInterface), "get_MaxWindowSize", typeof(Size), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetMaxPhysicalWindowSize:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 18164, 18388);

                        return f_1645_18171_18387(typeof(PSHostRawUserInterface), "get_MaxPhysicalWindowSize", typeof(Size), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetKeyAvailable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 18470, 18685);

                        return f_1645_18477_18684(typeof(PSHostRawUserInterface), "get_KeyAvailable", typeof(bool), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.ReadKey:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 18802, 19034);

                        return f_1645_18809_19033(typeof(PSHostRawUserInterface), "ReadKey", typeof(KeyInfo), new Type[] { typeof(ReadKeyOptions) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.FlushInputBuffer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 19117, 19332);

                        return f_1645_19124_19331(typeof(PSHostRawUserInterface), "FlushInputBuffer", typeof(void), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetBufferContents1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 19417, 19671);

                        return f_1645_19424_19670(typeof(PSHostRawUserInterface), "SetBufferContents", typeof(void), new Type[] { typeof(Rectangle), typeof(BufferCell) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.SetBufferContents2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 19756, 20015);

                        return f_1645_19763_20014(typeof(PSHostRawUserInterface), "SetBufferContents", typeof(void), new Type[] { typeof(Coordinates), typeof(BufferCell[,]) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetBufferContents:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 20099, 20342);

                        return f_1645_20106_20341(typeof(PSHostRawUserInterface), "GetBufferContents", typeof(BufferCell[,]), new Type[] { typeof(Rectangle) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.ScrollBufferContents:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 20429, 20726);

                        return f_1645_20436_20725(typeof(PSHostRawUserInterface), "ScrollBufferContents", typeof(void), new Type[] { typeof(Rectangle), typeof(Coordinates), typeof(Rectangle), typeof(BufferCell) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.PushRunspace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 20868, 21144);

                        return f_1645_20875_21143(typeof(IHostSupportsInteractiveSession), "PushRunspace", typeof(void), new Type[] { typeof(System.Management.Automation.Runspaces.Runspace) });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.PopRunspace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 21222, 21441);

                        return f_1645_21229_21440(typeof(IHostSupportsInteractiveSession), "PopRunspace", typeof(void), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetIsRunspacePushed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 21593, 21821);

                        return f_1645_21600_21820(typeof(IHostSupportsInteractiveSession), "get_IsRunspacePushed", typeof(bool), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    case RemoteHostMethodId.GetRunspace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 21899, 22162);

                        return f_1645_21906_22161(typeof(IHostSupportsInteractiveSession), "get_Runspace", typeof(System.Management.Automation.Runspaces.Runspace), new Type[] { });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1645, 3934, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 22212, 22310);

                        f_1645_22212_22309(false, "All RemoteHostMethodId's should be handled. This code should not be reached.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1645, 22332, 22344);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1645, 3934, 22359);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1645, 3837, 22370);

                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_4094_4279(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 4094, 4279);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_4364_4553(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 4364, 4553);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_4641_4830(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 4641, 4830);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_4922_5143(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 4922, 5143);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_5237_5460(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 5237, 5460);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_5584_5784(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 5584, 5784);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_5876_6068(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 5876, 6068);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_6159_6350(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 6159, 6350);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_6447_6644(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 6447, 6644);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_6739_6934(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 6739, 6934);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_7056_7254(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 7056, 7254);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_7351_7585(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 7351, 7585);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_7666_7874(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 7666, 7874);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_7955_8207(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 7955, 8207);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_8292_8489(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 8292, 8489);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_8574_8786(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 8574, 8786);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_8871_9127(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 8871, 9127);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_9216_9433(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 9216, 9433);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_9522_9739(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 9522, 9739);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_9827_10065(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 9827, 10065);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_10156_10375(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 10156, 10375);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_10466_10685(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 10466, 10685);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_10766_11084(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 10766, 11084);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_11179_11457(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 11179, 11457);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_11552_11888(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 11552, 11888);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_11978_12294(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 11978, 12294);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_12401_12730(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 12401, 12730);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_12880_13098(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 12880, 13098);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_13191_13422(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 13191, 13422);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_13515_13733(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 13515, 13733);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_13826_14057(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 13826, 14057);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_14149_14365(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 14149, 14365);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_14457_14686(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 14457, 14686);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_14778_14994(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 14778, 14994);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_15086_15315(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 15086, 15315);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_15403_15607(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 15403, 15607);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_15695_15912(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 15695, 15912);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_16000_16205(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 16000, 16205);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_16293_16511(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 16293, 16511);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_16599_16804(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 16599, 16804);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_16892_17110(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 16892, 17110);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_17199_17407(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 17199, 17407);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_17496_17717(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 17496, 17717);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_17864_18072(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 17864, 18072);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_18171_18387(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 18171, 18387);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_18477_18684(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 18477, 18684);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_18809_19033(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 18809, 19033);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_19124_19331(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 19124, 19331);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_19424_19670(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 19424, 19670);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_19763_20014(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 19763, 20014);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_20106_20341(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 20106, 20341);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_20436_20725(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 20436, 20725);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_20875_21143(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 20875, 21143);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_21229_21440(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 21229, 21440);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_21600_21820(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 21600, 21820);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1645_21906_22161(System.Type
                interfaceType, string
                name, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostMethodInfo(interfaceType, name, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 21906, 22161);
                    return return_v;
                }


                int
                f_1645_22212_22309(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1645, 22212, 22309);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1645, 3837, 22370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1645, 3837, 22370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteHostMethodInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1645, 2789, 22377);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1645, 2789, 22377);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1645, 2789, 22377);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1645, 2789, 22377);
    }
}
