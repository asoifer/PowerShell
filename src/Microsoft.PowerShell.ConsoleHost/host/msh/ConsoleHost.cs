// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.PowerShell.Telemetry;
using Microsoft.PowerShell.Commands;

using ConsoleHandle = Microsoft.Win32.SafeHandles.SafeFileHandle;
using Dbg = System.Management.Automation.Diagnostics;
using Debugger = System.Management.Automation.Debugger;


namespace Microsoft.PowerShell
{
    [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
    internal sealed partial class ConsoleHost
            :
            PSHost,
            IDisposable,
            IHostSupportsInteractiveSession
    {
        internal const int
        ExitCodeSuccess = 0
        ;

        internal const int
        ExitCodeCtrlBreak = 128 + 21
        ;

        internal const int
        ExitCodeInitFailure = 70
        ;

        internal const int
        ExitCodeBadCommandLineParameter = 64
        ;

        private const uint
        SPI_GETSCREENREADER = 0x0046
        ;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref bool pvParam, uint fWinIni);

        internal static int Start(string bannerText, string helpText, string[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 4395, 12077);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4507, 4756) || true) && (f_111_4511_4573("POWERSHELL_DEBUG_STARTUP") != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 4507, 4756);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4615, 4741) || true) && (f_111_4622_4661_M(!System.Diagnostics.Debugger.IsAttached))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 4615, 4741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4703, 4722);

                            f_111_4703_4721(1000);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 4615, 4741);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 4615, 4741);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(111, 4615, 4741);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 4507, 4756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4912, 4969);

                string
                path = f_111_4926_4968("PATH")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 4983, 5051);

                string
                pshome = f_111_4999_5029() + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.PathSeparator).ToString(), 111, 5032, 5050)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5268, 5552) || true) && (f_111_5272_5298(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 5268, 5552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5332, 5383);

                    f_111_5332_5382("PATH", pshome);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 5268, 5552);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 5268, 5552);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5417, 5552) || true) && (!f_111_5422_5445(path, pshome))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 5417, 5552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5479, 5537);

                        f_111_5479_5536("PATH", pshome + path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 5417, 5552);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 5268, 5552);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5604, 5648);

                    string
                    profileDir = Platform.CacheDirectory
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5678, 5810) || true) && (!f_111_5683_5711(profileDir))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 5678, 5810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5753, 5791);

                        f_111_5753_5790(profileDir);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 5678, 5810);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 5836, 5883);

                    f_111_5836_5882(profileDir);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 5912, 6086);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(111, 5912, 6086);
                    // It's safe to ignore errors, the guarded code is just there to try and
                    // improve startup performance.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6102, 6134);

                uint
                exitCode = ExitCodeSuccess
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6150, 6204);

                f_111_6150_6170().Name = "ConsoleHost main thread";

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6419, 6454);

                    HostException
                    hostException = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6516, 6573);

                        s_theConsoleHost = f_111_6535_6572();
                    }
                    catch (HostException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 6610, 6711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6674, 6692);

                        hostException = e;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 6610, 6711);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6731, 6812);

                    PSHostUserInterface
                    hostUi = f_111_6760_6780_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(s_theConsoleHost, 111, 6760, 6780)?.UI) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Host.PSHostUserInterface>(111, 6760, 6811) ?? f_111_6784_6811())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6830, 6899);

                    s_cpp = f_111_6838_6898(hostUi, bannerText, helpText);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 6917, 6935);

                    f_111_6917_6934(s_cpp, args);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 7178, 7685) || true) && (f_111_7182_7199(s_cpp))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 7178, 7685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 7562, 7635);

                        f_111_7562_7634(f_111_7562_7581(s_theConsoleHost), "PowerShell " + f_111_7608_7633());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 7657, 7666);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 7178, 7685);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 7764, 8350) || true) && ((f_111_7769_7785(s_cpp) && (DynAbs.Tracing.TraceSender.Expression_True(111, 7769, 7814) && f_111_7789_7814(s_cpp))) || (DynAbs.Tracing.TraceSender.Expression_False(111, 7768, 7863) || (f_111_7820_7836(s_cpp) && (DynAbs.Tracing.TraceSender.Expression_True(111, 7820, 7862) && f_111_7840_7862(s_cpp)))) || (DynAbs.Tracing.TraceSender.Expression_False(111, 7768, 7920) || (f_111_7868_7893(s_cpp) && (DynAbs.Tracing.TraceSender.Expression_True(111, 7868, 7919) && f_111_7897_7919(s_cpp)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 7764, 8350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 7962, 8058);

                        f_111_7962_8057(s_tracer, "Conflicting server mode parameters, parameters must be used exclusively.");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8080, 8268) || true) && (s_theConsoleHost != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 8080, 8268);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8158, 8245);

                            f_111_8158_8244(s_theConsoleHost.ui, f_111_8193_8243());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 8080, 8268);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8292, 8331);

                        return ExitCodeBadCommandLineParameter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 7764, 8350);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8381, 8432);

                    f_111_8381_8431();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8544, 11670) || true) && (f_111_8548_8564(s_cpp))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 8544, 11670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8606, 8676);

                        f_111_8606_8675("ServerMode");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8698, 8764);

                        f_111_8698_8763("StartupProfileData-ServerMode");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8786, 8902);

                        f_111_8786_8901(f_111_8856_8876(s_cpp), f_111_8878_8900(s_cpp));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8924, 8937);

                        exitCode = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 8544, 11670);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 8544, 11670);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 8979, 11670) || true) && (f_111_8983_9008(s_cpp))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 8979, 11670);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9050, 9119);

                            f_111_9050_9118("NamedPipe");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9141, 9216);

                            f_111_9141_9215("StartupProfileData-NamedPipeServerMode");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9238, 9370);

                            f_111_9238_9369(f_111_9345_9368(s_cpp));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9392, 9405);

                            exitCode = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 8979, 11670);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 8979, 11670);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9447, 11670) || true) && (f_111_9451_9470(s_cpp))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 9447, 11670);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9512, 9581);

                                f_111_9512_9580("SSHServer");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9603, 9672);

                                f_111_9603_9671("StartupProfileData-SSHServerMode");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9694, 9784);

                                f_111_9694_9783(f_111_9762_9782(s_cpp));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9806, 9819);

                                exitCode = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 9447, 11670);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 9447, 11670);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9861, 11670) || true) && (f_111_9865_9887(s_cpp))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 9861, 11670);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 9929, 10005);

                                    f_111_9929_10004("SocketServerMode");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10027, 10099);

                                    f_111_10027_10098("StartupProfileData-SocketServerMode");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10121, 10263);

                                    f_111_10121_10262(f_111_10191_10211(s_cpp), f_111_10238_10261(s_cpp));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10285, 10298);

                                    exitCode = 0;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 9861, 11670);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 9861, 11670);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10443, 10620) || true) && (hostException != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 10443, 10620);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10577, 10597);

                                        throw hostException;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 10443, 10620);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10644, 11280) || true) && (f_111_10648_10681(s_theConsoleHost))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 10644, 11280);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10731, 10798);

                                        f_111_10731_10797("StartupProfileData-Interactive");

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 10826, 11089) || true) && (UpdatesNotification.CanNotifyUpdates)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 10826, 11089);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11020, 11062);

                                            f_111_11024_11061();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 10826, 11089);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 10644, 11280);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 10644, 11280);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11187, 11257);

                                        f_111_11187_11256("StartupProfileData-NonInteractive");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 10644, 11280);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11304, 11340);

                                    f_111_11304_11339(
                                                        s_theConsoleHost);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11362, 11420);

                                    PSHost.IsStdOutputRedirected = f_111_11393_11419();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11515, 11581);

                                    f_111_11515_11580("Normal");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11605, 11651);

                                    exitCode = f_111_11616_11650(s_theConsoleHost, s_cpp, false);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 9861, 11670);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 9447, 11670);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 8979, 11670);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 8544, 11670);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(111, 11699, 11972);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11739, 11957) || true) && (s_theConsoleHost != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 11739, 11957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 11911, 11938);

                        f_111_11911_11937(s_theConsoleHost);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 11739, 11957);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(111, 11699, 11972);
                }

                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 12030, 12051);

                    return (int)exitCode;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 4395, 12077);

                string?
                f_111_4511_4573(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4511, 4573);
                    return return_v;
                }


                bool
                f_111_4622_4661_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 4622, 4661);
                    return return_v;
                }


                int
                f_111_4703_4721(int
                millisecondsTimeout)
                {
                    Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4703, 4721);
                    return 0;
                }


                string?
                f_111_4926_4968(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 4926, 4968);
                    return return_v;
                }


                string
                f_111_4999_5029()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 4999, 5029);
                    return return_v;
                }


                bool
                f_111_5272_5298(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5272, 5298);
                    return return_v;
                }


                int
                f_111_5332_5382(string
                variable, string
                value)
                {
                    Environment.SetEnvironmentVariable(variable, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5332, 5382);
                    return 0;
                }


                bool
                f_111_5422_5445(string
                this_param, string
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5422, 5445);
                    return return_v;
                }


                int
                f_111_5479_5536(string
                variable, string
                value)
                {
                    Environment.SetEnvironmentVariable(variable, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5479, 5536);
                    return 0;
                }


                bool
                f_111_5683_5711(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5683, 5711);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_111_5753_5790(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5753, 5790);
                    return return_v;
                }


                int
                f_111_5836_5882(string
                directoryPath)
                {
                    ProfileOptimization.SetProfileRoot(directoryPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 5836, 5882);
                    return 0;
                }


                System.Threading.Thread
                f_111_6150_6170()
                {
                    var return_v =
                                Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 6150, 6170);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleHost
                f_111_6535_6572()
                {
                    var return_v = ConsoleHost.CreateSingletonInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 6535, 6572);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_111_6760_6780_M(System.Management.Automation.Host.PSHostUserInterface
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 6760, 6780);
                    return return_v;
                }


                Microsoft.PowerShell.NullHostUserInterface
                f_111_6784_6811()
                {
                    var return_v = new Microsoft.PowerShell.NullHostUserInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 6784, 6811);
                    return return_v;
                }


                Microsoft.PowerShell.CommandLineParameterParser
                f_111_6838_6898(System.Management.Automation.Host.PSHostUserInterface
                hostUI, string
                bannerText, string
                helpText)
                {
                    var return_v = new Microsoft.PowerShell.CommandLineParameterParser(hostUI, bannerText, helpText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 6838, 6898);
                    return return_v;
                }


                int
                f_111_6917_6934(Microsoft.PowerShell.CommandLineParameterParser
                this_param, string[]
                args)
                {
                    this_param.Parse(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 6917, 6934);
                    return 0;
                }


                bool
                f_111_7182_7199(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ShowVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7182, 7199);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_111_7562_7581(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7562, 7581);
                    return return_v;
                }


                string
                f_111_7608_7633()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7608, 7633);
                    return return_v;
                }


                int
                f_111_7562_7634(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 7562, 7634);
                    return 0;
                }


                bool
                f_111_7769_7785(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7769, 7785);
                    return return_v;
                }


                bool
                f_111_7789_7814(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.NamedPipeServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7789, 7814);
                    return return_v;
                }


                bool
                f_111_7820_7836(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7820, 7836);
                    return return_v;
                }


                bool
                f_111_7840_7862(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.SocketServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7840, 7862);
                    return return_v;
                }


                bool
                f_111_7868_7893(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.NamedPipeServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7868, 7893);
                    return return_v;
                }


                bool
                f_111_7897_7919(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.SocketServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 7897, 7919);
                    return return_v;
                }


                int
                f_111_7962_8057(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 7962, 8057);
                    return 0;
                }


                string
                f_111_8193_8243()
                {
                    var return_v = ConsoleHostStrings.ConflictingServerModeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 8193, 8243);
                    return return_v;
                }


                int
                f_111_8158_8244(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 8158, 8244);
                    return 0;
                }


                int
                f_111_8381_8431()
                {
                    TaskbarJumpList.CreateRunAsAdministratorJumpList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 8381, 8431);
                    return 0;
                }


                bool
                f_111_8548_8564(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 8548, 8564);
                    return return_v;
                }


                int
                f_111_8606_8675(string
                mode)
                {
                    ApplicationInsightsTelemetry.SendPSCoreStartupTelemetry(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 8606, 8675);
                    return 0;
                }


                int
                f_111_8698_8763(string
                profile)
                {
                    ProfileOptimization.StartProfile(profile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 8698, 8763);
                    return 0;
                }


                string
                f_111_8856_8876(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 8856, 8876);
                    return return_v;
                }


                string
                f_111_8878_8900(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.WorkingDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 8878, 8900);
                    return return_v;
                }


                int
                f_111_8786_8901(string
                initialCommand, string
                workingDirectory)
                {
                    System.Management.Automation.Remoting.Server.OutOfProcessMediator.Run(initialCommand, workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 8786, 8901);
                    return 0;
                }


                bool
                f_111_8983_9008(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.NamedPipeServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 8983, 9008);
                    return return_v;
                }


                int
                f_111_9050_9118(string
                mode)
                {
                    ApplicationInsightsTelemetry.SendPSCoreStartupTelemetry(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 9050, 9118);
                    return 0;
                }


                int
                f_111_9141_9215(string
                profile)
                {
                    ProfileOptimization.StartProfile(profile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 9141, 9215);
                    return 0;
                }


                string
                f_111_9345_9368(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 9345, 9368);
                    return return_v;
                }


                int
                f_111_9238_9369(string
                configurationName)
                {
                    System.Management.Automation.Remoting.RemoteSessionNamedPipeServer.RunServerMode(configurationName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 9238, 9369);
                    return 0;
                }


                bool
                f_111_9451_9470(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.SSHServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 9451, 9470);
                    return return_v;
                }


                int
                f_111_9512_9580(string
                mode)
                {
                    ApplicationInsightsTelemetry.SendPSCoreStartupTelemetry(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 9512, 9580);
                    return 0;
                }


                int
                f_111_9603_9671(string
                profile)
                {
                    ProfileOptimization.StartProfile(profile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 9603, 9671);
                    return 0;
                }


                string
                f_111_9762_9782(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 9762, 9782);
                    return return_v;
                }


                int
                f_111_9694_9783(string
                initialCommand)
                {
                    System.Management.Automation.Remoting.Server.SSHProcessMediator.Run(initialCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 9694, 9783);
                    return 0;
                }


                bool
                f_111_9865_9887(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.SocketServerMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 9865, 9887);
                    return return_v;
                }


                int
                f_111_9929_10004(string
                mode)
                {
                    ApplicationInsightsTelemetry.SendPSCoreStartupTelemetry(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 9929, 10004);
                    return 0;
                }


                int
                f_111_10027_10098(string
                profile)
                {
                    ProfileOptimization.StartProfile(profile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 10027, 10098);
                    return 0;
                }


                string
                f_111_10191_10211(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 10191, 10211);
                    return return_v;
                }


                string
                f_111_10238_10261(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 10238, 10261);
                    return return_v;
                }


                int
                f_111_10121_10262(string
                initialCommand, string
                configurationName)
                {
                    System.Management.Automation.Remoting.Server.HyperVSocketMediator.Run(initialCommand, configurationName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 10121, 10262);
                    return 0;
                }


                bool
                f_111_10648_10681(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.LoadPSReadline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 10648, 10681);
                    return return_v;
                }


                int
                f_111_10731_10797(string
                profile)
                {
                    ProfileOptimization.StartProfile(profile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 10731, 10797);
                    return 0;
                }


                void
                f_111_11024_11061()
                {
                    UpdatesNotification.CheckForUpdates();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 11024, 11061);
                }


                int
                f_111_11187_11256(string
                profile)
                {
                    ProfileOptimization.StartProfile(profile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 11187, 11256);
                    return 0;
                }


                int
                f_111_11304_11339(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    this_param.BindBreakHandler();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 11304, 11339);
                    return 0;
                }


                bool
                f_111_11393_11419()
                {
                    var return_v = Console.IsOutputRedirected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 11393, 11419);
                    return return_v;
                }


                int
                f_111_11515_11580(string
                mode)
                {
                    ApplicationInsightsTelemetry.SendPSCoreStartupTelemetry(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 11515, 11580);
                    return 0;
                }


                uint
                f_111_11616_11650(Microsoft.PowerShell.ConsoleHost
                this_param, Microsoft.PowerShell.CommandLineParameterParser
                cpp, bool
                isPrestartWarned)
                {
                    var return_v = this_param.Run(cpp, isPrestartWarned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 11616, 11650);
                    return return_v;
                }


                int
                f_111_11911_11937(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 11911, 11937);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 4395, 12077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 4395, 12077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandLineParameterParser s_cpp;

        private static bool MyBreakHandler(ConsoleControl.ConsoleBreakSignal signal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 13494, 15248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 13595, 15237);

                switch (signal)
                {

                    case ConsoleControl.ConsoleBreakSignal.CtrlBreak:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 13595, 15237);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 13714, 14116) || true) && (f_111_13718_13738(s_cpp))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 13714, 14116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 13870, 13919);

                            f_111_13870_13918(shouldEndSession: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 13714, 14116);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 13714, 14116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 14073, 14093);

                            f_111_14073_14092();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 13714, 14116);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 14140, 14152);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 13595, 15237);

                    case ConsoleControl.ConsoleBreakSignal.CtrlC:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 13595, 15237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 14284, 14334);

                        f_111_14284_14333(shouldEndSession: false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 14356, 14368);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 13595, 15237);

                    case ConsoleControl.ConsoleBreakSignal.Logoff:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 13595, 15237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 14766, 14778);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 13595, 15237);

                    case ConsoleControl.ConsoleBreakSignal.Close:
                    case ConsoleControl.ConsoleBreakSignal.Shutdown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 13595, 15237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 14931, 14980);

                        f_111_14931_14979(shouldEndSession: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15002, 15015);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 13595, 15237);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 13595, 15237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15138, 15187);

                        f_111_15138_15186(shouldEndSession: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15209, 15222);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 13595, 15237);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 13494, 15248);

                bool
                f_111_13718_13738(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.NonInteractive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 13718, 13738);
                    return return_v;
                }


                int
                f_111_13870_13918(bool
                shouldEndSession)
                {
                    SpinUpBreakHandlerThread(shouldEndSession: shouldEndSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 13870, 13918);
                    return 0;
                }


                bool
                f_111_14073_14092()
                {
                    var return_v = BreakIntoDebugger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 14073, 14092);
                    return return_v;
                }


                int
                f_111_14284_14333(bool
                shouldEndSession)
                {
                    SpinUpBreakHandlerThread(shouldEndSession: shouldEndSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 14284, 14333);
                    return 0;
                }


                int
                f_111_14931_14979(bool
                shouldEndSession)
                {
                    SpinUpBreakHandlerThread(shouldEndSession: shouldEndSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 14931, 14979);
                    return 0;
                }


                int
                f_111_15138_15186(bool
                shouldEndSession)
                {
                    SpinUpBreakHandlerThread(shouldEndSession: shouldEndSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 15138, 15186);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 13494, 15248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 13494, 15248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool BreakIntoDebugger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 15268, 15933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15332, 15381);

                ConsoleHost
                host = f_111_15351_15380()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15395, 15420);

                Debugger
                debugger = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15440, 15459);
                lock (host.hostGlobalLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15493, 15728) || true) && (f_111_15497_15523(host._runspaceRef) != null && (DynAbs.Tracing.TraceSender.Expression_True(111, 15497, 15620) && f_111_15556_15612(f_111_15556_15582(host._runspaceRef)) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 15493, 15728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15662, 15709);

                        debugger = f_111_15673_15708(f_111_15673_15699(host._runspaceRef));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 15493, 15728);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15759, 15893) || true) && (debugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 15759, 15893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15813, 15848);

                    f_111_15813_15847(debugger, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15866, 15878);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 15759, 15893);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 15909, 15922);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 15268, 15933);

                Microsoft.PowerShell.ConsoleHost
                f_111_15351_15380()
                {
                    var return_v = ConsoleHost.SingletonInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 15351, 15380);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_15497_15523(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 15497, 15523);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_15556_15582(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 15556, 15582);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_111_15556_15612(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 15556, 15612);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_15673_15699(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 15673, 15699);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_15673_15708(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 15673, 15708);
                    return return_v;
                }


                int
                f_111_15813_15847(System.Management.Automation.Debugger
                this_param, bool
                enabled)
                {
                    this_param.SetDebuggerStepMode(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 15813, 15847);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 15268, 15933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 15268, 15933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SpinUpBreakHandlerThread(bool shouldEndSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 16667, 17955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 16759, 16808);

                ConsoleHost
                host = f_111_16778_16807()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 16824, 16842);

                Thread
                bht = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 16864, 16883);

                lock (host.hostGlobalLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 16917, 16948);

                    bht = host._breakHandlerThread;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 16966, 17114) || true) && (f_111_16970_16992_M(!host.ShouldEndSession) && (DynAbs.Tracing.TraceSender.Expression_True(111, 16970, 17012) && shouldEndSession))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 16966, 17114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 17054, 17095);

                        host.ShouldEndSession = shouldEndSession;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 16966, 17114);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 17537, 17929) || true) && (bht == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 17537, 17929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 17695, 17775);

                        host._breakHandlerThread = f_111_17722_17774(new ThreadStart(ConsoleHost.HandleBreak));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 17797, 17855);

                        host._breakHandlerThread.Name = "ConsoleHost.HandleBreak";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 17877, 17910);

                        f_111_17877_17909(host._breakHandlerThread);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 17537, 17929);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 16667, 17955);

                Microsoft.PowerShell.ConsoleHost
                f_111_16778_16807()
                {
                    var return_v = ConsoleHost.SingletonInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 16778, 16807);
                    return return_v;
                }


                bool
                f_111_16970_16992_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 16970, 16992);
                    return return_v;
                }


                System.Threading.Thread
                f_111_17722_17774(System.Threading.ThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 17722, 17774);
                    return return_v;
                }


                int
                f_111_17877_17909(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 17877, 17909);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 16667, 17955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 16667, 17955);
            }
        }

        private static void HandleBreak()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 17967, 19969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 18025, 18068);

                ConsoleHost
                consoleHost = s_theConsoleHost
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 18082, 19543) || true) && (consoleHost != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 18082, 19543);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 18139, 19052) || true) && (f_111_18143_18166(consoleHost))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 18139, 19052);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 18292, 18722) || true) && (f_111_18296_18330(consoleHost))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 18292, 18722);
                            // Cancel any executing debugger command if in debug mode.
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 18524, 18575);

                                f_111_18524_18574(f_111_18524_18553(f_111_18524_18544(consoleHost)));
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 18628, 18699);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(111, 18628, 18699);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 18292, 18722);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 18139, 19052);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 18139, 19052);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 18886, 19033) || true) && (!f_111_18891_18927(consoleHost.runningCmd))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 18886, 19033);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 18977, 19010);

                            f_111_18977_19009();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 18886, 19033);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 18139, 19052);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19072, 19528) || true) && (f_111_19076_19104(consoleHost))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 19072, 19528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19146, 19207);

                        var
                        runspaceRef = f_111_19164_19193()._runspaceRef
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19229, 19509) || true) && (runspaceRef != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 19229, 19509);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19302, 19338);

                            var
                            runspace = f_111_19317_19337(runspaceRef)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19364, 19486) || true) && (runspace != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 19364, 19486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19442, 19459);

                                f_111_19442_19458(runspace);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 19364, 19486);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 19229, 19509);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 19072, 19528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 18082, 19543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19755, 19816);

                ConsoleHandle
                handle = f_111_19778_19815()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19830, 19877);

                f_111_19830_19876(handle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 19901, 19958);

                f_111_19901_19930()._breakHandlerThread = null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 17967, 19969);

                bool
                f_111_18143_18166(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.InDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 18143, 18166);
                    return return_v;
                }


                bool
                f_111_18296_18330(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.DebuggerCanStopCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 18296, 18330);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_18524_18544(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 18524, 18544);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_18524_18553(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 18524, 18553);
                    return return_v;
                }


                int
                f_111_18524_18574(System.Management.Automation.Debugger
                this_param)
                {
                    this_param.StopProcessCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 18524, 18574);
                    return 0;
                }


                bool
                f_111_18891_18927(System.Management.Automation.Runspaces.Pipeline
                cmd)
                {
                    var return_v = StopPipeline(cmd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 18891, 18927);
                    return return_v;
                }


                int
                f_111_18977_19009()
                {
                    Executor.CancelCurrentExecutor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 18977, 19009);
                    return 0;
                }


                bool
                f_111_19076_19104(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.ShouldEndSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 19076, 19104);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleHost
                f_111_19164_19193()
                {
                    var return_v = ConsoleHost.SingletonInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 19164, 19193);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_19317_19337(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 19317, 19337);
                    return return_v;
                }


                int
                f_111_19442_19458(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 19442, 19458);
                    return 0;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_111_19778_19815()
                {
                    var return_v = ConsoleControl.GetConioDeviceHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 19778, 19815);
                    return return_v;
                }


                int
                f_111_19830_19876(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    ConsoleControl.FlushConsoleInputBuffer(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 19830, 19876);
                    return 0;
                }


                Microsoft.PowerShell.ConsoleHost
                f_111_19901_19930()
                {
                    var return_v =
                                ConsoleHost.SingletonInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 19901, 19930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 17967, 19969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 17967, 19969);
            }
        }

        private static bool StopPipeline(Pipeline cmd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 19981, 20496);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 20052, 20456) || true) && (cmd != null && (DynAbs.Tracing.TraceSender.Expression_True(111, 20056, 20221) && (f_111_20089_20116(f_111_20089_20110(cmd)) == PipelineState.Running || (DynAbs.Tracing.TraceSender.Expression_False(111, 20089, 20220) || f_111_20163_20190(f_111_20163_20184(cmd)) == PipelineState.Disconnected))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 20052, 20456);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 20299, 20315);

                        f_111_20299_20314(cmd);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 20337, 20349);

                        return true;
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 20386, 20441);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 20386, 20441);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 20052, 20456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 20472, 20485);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 19981, 20496);

                System.Management.Automation.Runspaces.PipelineStateInfo
                f_111_20089_20110(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 20089, 20110);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_111_20089_20116(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 20089, 20116);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_111_20163_20184(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 20163, 20184);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_111_20163_20190(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 20163, 20190);
                    return return_v;
                }


                int
                f_111_20299_20314(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    this_param.StopAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 20299, 20314);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 19981, 20496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 19981, 20496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConsoleHost CreateSingletonInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 20607, 20885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 20685, 20785);

                f_111_20685_20784(s_theConsoleHost == null, "CreateSingletonInstance should not be called multiple times");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 20799, 20836);

                s_theConsoleHost = f_111_20818_20835();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 20850, 20874);

                return s_theConsoleHost;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 20607, 20885);

                int
                f_111_20685_20784(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 20685, 20784);
                    return 0;
                }


                Microsoft.PowerShell.ConsoleHost
                f_111_20818_20835()
                {
                    var return_v = new Microsoft.PowerShell.ConsoleHost();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 20818, 20835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 20607, 20885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 20607, 20885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConsoleHost SingletonInstance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 20967, 21168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 21003, 21111);

                    f_111_21003_21110(s_theConsoleHost != null, "CreateSingletonInstance should be called before calling this method");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 21129, 21153);

                    return s_theConsoleHost;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 20967, 21168);

                    int
                    f_111_21003_21110(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 21003, 21110);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 20897, 21179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 20897, 21179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 21442, 21606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 21478, 21514);

                    const string
                    myName = "ConsoleHost"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 21577, 21591);

                    return myName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 21442, 21606);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 21390, 21617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 21390, 21617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override System.Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 21825, 21931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 21904, 21916);

                    return _ver;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 21825, 21931);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 21762, 21942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 21762, 21942);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override System.Guid InstanceId { get; }

        public override PSHostUserInterface UI
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 22358, 22501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22394, 22458);

                    f_111_22394_22457(ui != null, "ui should have been allocated in ctor");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22476, 22486);

                    return ui;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 22358, 22501);

                    int
                    f_111_22394_22457(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 22394, 22457);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 22295, 22512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 22295, 22512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void PushRunspace(Runspace newRunspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 22600, 24143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22671, 22708) || true) && (_runspaceRef == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 22671, 22708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22699, 22706);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 22671, 22708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22724, 22786);

                RemoteRunspace
                remoteRunspace = newRunspace as RemoteRunspace
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22800, 22870);

                f_111_22800_22869(remoteRunspace != null, "Expected remoteRunspace != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22884, 22990);

                remoteRunspace.StateChanged += new EventHandler<RunspaceStateEventArgs>(HandleRemoteRunspaceStateChanged);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23062, 23221) || true) && (f_111_23066_23096(f_111_23066_23087(_runspaceRef)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 23062, 23221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23138, 23206);

                    f_111_23138_23168(f_111_23138_23159(_runspaceRef)).DebuggerStop -= OnExecutionSuspended;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 23062, 23221);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23287, 23432) || true) && (f_111_23291_23314(remoteRunspace) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 23287, 23432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23356, 23417);

                    f_111_23356_23379(remoteRunspace).DebuggerStop += OnExecutionSuspended;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 23287, 23432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23496, 23575);

                this.runningCmd = f_111_23514_23574(remoteRunspace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23622, 23699);

                f_111_23622_23698(
                            // Push runspace.
                            _runspaceRef, remoteRunspace, hostGlobalLock, out _isRunspacePushed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23713, 23762);

                f_111_23713_23761(RunspacePushed, this, EventArgs.Empty);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23778, 24093) || true) && (this.runningCmd != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 23778, 24093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 23839, 24078);

                    f_111_23839_24077(remoteRunspace, this.runningCmd, this, f_111_24001_24012(), f_111_24035_24076(f_111_24035_24059(_runspaceRef)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 23778, 24093);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 24109, 24132);

                this.runningCmd = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 22600, 24143);

                int
                f_111_22800_22869(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 22800, 22869);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_23066_23087(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 23066, 23087);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_23066_23096(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 23066, 23096);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_23138_23159(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 23138, 23159);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_23138_23168(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 23138, 23168);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_23291_23314(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 23291, 23314);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_23356_23379(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 23356, 23379);
                    return return_v;
                }


                System.Management.Automation.RemotePipeline
                f_111_23514_23574(System.Management.Automation.RemoteRunspace
                remoteRunspace)
                {
                    var return_v = EnterPSSessionCommand.ConnectRunningPipeline(remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 23514, 23574);
                    return return_v;
                }


                int
                f_111_23622_23698(System.Management.Automation.Remoting.RunspaceRef
                this_param, System.Management.Automation.RemoteRunspace
                remoteRunspace, object
                syncObject, out bool
                isRunspacePushed)
                {
                    this_param.Override(remoteRunspace, syncObject, out isRunspacePushed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 23622, 23698);
                    return 0;
                }


                int
                f_111_23713_23761(System.EventHandler
                eventHandler, Microsoft.PowerShell.ConsoleHost
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 23713, 23761);
                    return 0;
                }


                bool
                f_111_24001_24012()
                {
                    var return_v = InDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 24001, 24012);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_24035_24059(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.OldRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 24035, 24059);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_111_24035_24076(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 24035, 24076);
                    return return_v;
                }


                int
                f_111_23839_24077(System.Management.Automation.RemoteRunspace
                remoteRunspace, System.Management.Automation.Runspaces.Pipeline
                cmd, Microsoft.PowerShell.ConsoleHost
                host, bool
                inDebugMode, System.Management.Automation.ExecutionContext
                context)
                {
                    EnterPSSessionCommand.ContinueCommand(remoteRunspace, cmd, (System.Management.Automation.Host.PSHost)host, inDebugMode, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 23839, 24077);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 22600, 24143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 22600, 24143);
            }
        }

        private void HandleRemoteRunspaceStateChanged(object sender, RunspaceStateEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 24526, 25239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 24645, 24701);

                RunspaceState
                state = f_111_24667_24700(f_111_24667_24694(eventArgs))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 24717, 25228);

                switch (state)
                {

                    case RunspaceState.Opening:
                    case RunspaceState.Opened:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 24717, 25228);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 24884, 24891);

                            return;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 24717, 25228);

                    case RunspaceState.Closing:
                    case RunspaceState.Closed:
                    case RunspaceState.Broken:
                    case RunspaceState.Disconnected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 24717, 25228);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25146, 25160);

                            f_111_25146_25159(this);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(111, 25207, 25213);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 24717, 25228);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 24526, 25239);

                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_111_24667_24694(System.Management.Automation.Runspaces.RunspaceStateEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 24667, 24694);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_111_24667_24700(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 24667, 24700);
                    return return_v;
                }


                int
                f_111_25146_25159(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    this_param.PopRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 25146, 25159);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 24526, 25239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 24526, 25239);
            }
        }

        public void PopRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 25327, 26617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25377, 25512) || true) && (_runspaceRef == null || (DynAbs.Tracing.TraceSender.Expression_False(111, 25381, 25456) || f_111_25422_25456_M(!_runspaceRef.IsRunspaceOverridden)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 25377, 25512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25490, 25497);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 25377, 25512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25528, 25738) || true) && (_inPushedConfiguredSession)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 25528, 25738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25694, 25723);

                    this.ShouldEndSession = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 25528, 25738);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25754, 26167) || true) && (f_111_25758_25788(f_111_25758_25779(_runspaceRef)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 25754, 26167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25888, 25956);

                    f_111_25888_25918(f_111_25888_25909(_runspaceRef)).DebuggerStop -= OnExecutionSuspended;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 25976, 26006);

                    f_111_25976_26005(this.runningCmd);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26026, 26152) || true) && (f_111_26030_26046(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 26026, 26152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26088, 26133);

                        f_111_26088_26132(this, DebuggerResumeAction.Continue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 26026, 26152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 25754, 26167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26183, 26206);

                this.runningCmd = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26228, 26242);

                lock (hostGlobalLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26276, 26298);

                    f_111_26276_26297(_runspaceRef);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26316, 26342);

                    _isRunspacePushed = false;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26427, 26495);

                f_111_26427_26457(f_111_26427_26448(_runspaceRef)).DebuggerStop += OnExecutionSuspended;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26557, 26606);

                f_111_26557_26605(
                            // raise events outside the lock
                            RunspacePopped, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 25327, 26617);

                bool
                f_111_25422_25456_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 25422, 25456);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_25758_25779(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 25758, 25779);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_25758_25788(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 25758, 25788);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_25888_25909(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 25888, 25909);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_25888_25918(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 25888, 25918);
                    return return_v;
                }


                bool
                f_111_25976_26005(System.Management.Automation.Runspaces.Pipeline
                cmd)
                {
                    var return_v = StopPipeline(cmd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 25976, 26005);
                    return return_v;
                }


                bool
                f_111_26030_26046(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.InDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 26030, 26046);
                    return return_v;
                }


                int
                f_111_26088_26132(Microsoft.PowerShell.ConsoleHost
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.ExitDebugMode(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 26088, 26132);
                    return 0;
                }


                int
                f_111_26276_26297(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    this_param.Revert();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 26276, 26297);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_26427_26448(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 26427, 26448);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_26427_26457(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 26427, 26457);
                    return return_v;
                }


                int
                f_111_26557_26605(System.EventHandler
                eventHandler, Microsoft.PowerShell.ConsoleHost
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 26557, 26605);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 25327, 26617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 25327, 26617);
            }
        }

        public bool IsRunspacePushed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 26789, 26865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26825, 26850);

                    return _isRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 26789, 26865);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 26736, 26876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 26736, 26876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _isRunspacePushed;

        public Runspace Runspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 27104, 27254);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27140, 27186) || true) && (f_111_27144_27160(this) == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 27140, 27186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27172, 27184);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 27140, 27186);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27206, 27239);

                    return f_111_27213_27238(f_111_27213_27229(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 27104, 27254);

                    System.Management.Automation.Remoting.RunspaceRef
                    f_111_27144_27160(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.RunspaceRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27144, 27160);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.RunspaceRef
                    f_111_27213_27229(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.RunspaceRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27213, 27229);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_27213_27238(System.Management.Automation.Remoting.RunspaceRef
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27213, 27238);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 27055, 27265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 27055, 27265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal LocalRunspace LocalRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 27338, 27645);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27374, 27504) || true) && (_isRunspacePushed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 27374, 27504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27437, 27485);

                        return f_111_27444_27467(f_111_27444_27455()) as LocalRunspace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 27374, 27504);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27524, 27565) || true) && (f_111_27528_27539() == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 27524, 27565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27551, 27563);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 27524, 27565);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27585, 27630);

                    return f_111_27592_27612(f_111_27592_27603()) as LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 27338, 27645);

                    System.Management.Automation.Remoting.RunspaceRef
                    f_111_27444_27455()
                    {
                        var return_v = RunspaceRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27444, 27455);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_27444_27467(System.Management.Automation.Remoting.RunspaceRef
                    this_param)
                    {
                        var return_v = this_param.OldRunspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27444, 27467);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.RunspaceRef
                    f_111_27528_27539()
                    {
                        var return_v = RunspaceRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27528, 27539);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.RunspaceRef
                    f_111_27592_27603()
                    {
                        var return_v = RunspaceRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27592, 27603);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_27592_27612(System.Management.Automation.Remoting.RunspaceRef
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 27592, 27612);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 27277, 27656);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 27277, 27656);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        public class ConsoleColorProxy
        {
            private ConsoleHostUserInterface _ui;

            public ConsoleColorProxy(ConsoleHostUserInterface ui)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 27776, 27958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27756, 27759);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27862, 27916) || true) && (ui == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 27862, 27916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27878, 27916);

                        throw f_111_27884_27915("ui");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 27862, 27916);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 27934, 27943);

                    _ui = ui;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 27776, 27958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 27776, 27958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 27776, 27958);
                }
            }

            public ConsoleColor FormatAccentColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 28044, 28231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 28183, 28212);

                        return f_111_28190_28211(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 28044, 28231);

                        System.ConsoleColor
                        f_111_28190_28211(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.FormatAccentColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 28190, 28211);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 27974, 28454);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 27974, 28454);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 28251, 28439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 28390, 28420);

                        _ui.FormatAccentColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 28251, 28439);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 27974, 28454);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 27974, 28454);
                    }
                }
            }

            public ConsoleColor ErrorAccentColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 28539, 28725);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 28678, 28706);

                        return f_111_28685_28705(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 28539, 28725);

                        System.ConsoleColor
                        f_111_28685_28705(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.ErrorAccentColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 28685, 28705);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 28470, 28947);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 28470, 28947);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 28745, 28932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 28884, 28913);

                        _ui.ErrorAccentColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 28745, 28932);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 28470, 28947);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 28470, 28947);
                    }
                }
            }

            public ConsoleColor ErrorForegroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 29036, 29226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 29175, 29207);

                        return f_111_29182_29206(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 29036, 29226);

                        System.ConsoleColor
                        f_111_29182_29206(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.ErrorForegroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 29182, 29206);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 28963, 29452);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 28963, 29452);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 29246, 29437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 29385, 29418);

                        _ui.ErrorForegroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 29246, 29437);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 28963, 29452);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 28963, 29452);
                    }
                }
            }

            public ConsoleColor ErrorBackgroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 29541, 29731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 29680, 29712);

                        return f_111_29687_29711(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 29541, 29731);

                        System.ConsoleColor
                        f_111_29687_29711(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.ErrorBackgroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 29687, 29711);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 29468, 29957);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 29468, 29957);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 29751, 29942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 29890, 29923);

                        _ui.ErrorBackgroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 29751, 29942);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 29468, 29957);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 29468, 29957);
                    }
                }
            }

            public ConsoleColor WarningForegroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 30048, 30240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 30187, 30221);

                        return f_111_30194_30220(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 30048, 30240);

                        System.ConsoleColor
                        f_111_30194_30220(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.WarningForegroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 30194, 30220);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 29973, 30468);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 29973, 30468);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 30260, 30453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 30399, 30434);

                        _ui.WarningForegroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 30260, 30453);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 29973, 30468);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 29973, 30468);
                    }
                }
            }

            public ConsoleColor WarningBackgroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 30559, 30751);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 30698, 30732);

                        return f_111_30705_30731(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 30559, 30751);

                        System.ConsoleColor
                        f_111_30705_30731(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.WarningBackgroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 30705, 30731);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 30484, 30979);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 30484, 30979);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 30771, 30964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 30910, 30945);

                        _ui.WarningBackgroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 30771, 30964);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 30484, 30979);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 30484, 30979);
                    }
                }
            }

            public ConsoleColor DebugForegroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 31068, 31258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 31207, 31239);

                        return f_111_31214_31238(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 31068, 31258);

                        System.ConsoleColor
                        f_111_31214_31238(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.DebugForegroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 31214, 31238);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 30995, 31484);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 30995, 31484);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 31278, 31469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 31417, 31450);

                        _ui.DebugForegroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 31278, 31469);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 30995, 31484);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 30995, 31484);
                    }
                }
            }

            public ConsoleColor DebugBackgroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 31573, 31763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 31712, 31744);

                        return f_111_31719_31743(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 31573, 31763);

                        System.ConsoleColor
                        f_111_31719_31743(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.DebugBackgroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 31719, 31743);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 31500, 31989);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 31500, 31989);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 31783, 31974);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 31922, 31955);

                        _ui.DebugBackgroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 31783, 31974);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 31500, 31989);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 31500, 31989);
                    }
                }
            }

            public ConsoleColor VerboseForegroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 32080, 32272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 32219, 32253);

                        return f_111_32226_32252(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 32080, 32272);

                        System.ConsoleColor
                        f_111_32226_32252(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.VerboseForegroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 32226, 32252);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 32005, 32500);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 32005, 32500);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 32292, 32485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 32431, 32466);

                        _ui.VerboseForegroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 32292, 32485);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 32005, 32500);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 32005, 32500);
                    }
                }
            }

            public ConsoleColor VerboseBackgroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 32591, 32783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 32730, 32764);

                        return f_111_32737_32763(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 32591, 32783);

                        System.ConsoleColor
                        f_111_32737_32763(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.VerboseBackgroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 32737, 32763);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 32516, 33011);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 32516, 33011);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 32803, 32996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 32942, 32977);

                        _ui.VerboseBackgroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 32803, 32996);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 32516, 33011);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 32516, 33011);
                    }
                }
            }

            public ConsoleColor ProgressForegroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 33103, 33296);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 33242, 33277);

                        return f_111_33249_33276(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 33103, 33296);

                        System.ConsoleColor
                        f_111_33249_33276(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.ProgressForegroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 33249, 33276);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 33027, 33525);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 33027, 33525);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 33316, 33510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 33455, 33491);

                        _ui.ProgressForegroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 33316, 33510);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 33027, 33525);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 33027, 33525);
                    }
                }
            }

            public ConsoleColor ProgressBackgroundColor
            {
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 33617, 33810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 33756, 33791);

                        return f_111_33763_33790(_ui);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 33617, 33810);

                        System.ConsoleColor
                        f_111_33763_33790(Microsoft.PowerShell.ConsoleHostUserInterface
                        this_param)
                        {
                            var return_v = this_param.ProgressBackgroundColor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 33763, 33790);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 33541, 34039);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 33541, 34039);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 33830, 34024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 33969, 34005);

                        _ui.ProgressBackgroundColor = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(111, 33830, 34024);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 33541, 34039);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 33541, 34039);
                    }
                }
            }

            static ConsoleColorProxy()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 27668, 34050);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 27668, 34050);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 27668, 34050);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 27668, 34050);

            System.ArgumentNullException
            f_111_27884_27915(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 27884, 27915);
                return return_v;
            }

        }

        public override PSObject PrivateData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 34285, 34481);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 34321, 34349) || true) && (ui == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 34321, 34349);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 34337, 34349);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 34321, 34349);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 34367, 34466);

                    return _consoleColorProxy ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSObject>(111, 34374, 34465) ?? (_consoleColorProxy = f_111_34418_34464(f_111_34438_34463(ui))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 34285, 34481);

                    Microsoft.PowerShell.ConsoleHost.ConsoleColorProxy
                    f_111_34438_34463(Microsoft.PowerShell.ConsoleHostUserInterface
                    ui)
                    {
                        var return_v = new Microsoft.PowerShell.ConsoleHost.ConsoleColorProxy(ui);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 34438, 34463);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_111_34418_34464(Microsoft.PowerShell.ConsoleHost.ConsoleColorProxy
                    obj)
                    {
                        var return_v = PSObject.AsPSObject((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 34418, 34464);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 34224, 34492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 34224, 34492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSObject _consoleColorProxy;

        public override System.Globalization.CultureInfo CurrentCulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 34771, 34937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 34813, 34827);
                    lock (hostGlobalLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 34869, 34903);

                        return f_111_34876_34902();
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 34771, 34937);

                    System.Globalization.CultureInfo
                    f_111_34876_34902()
                    {
                        var return_v = CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 34876, 34902);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 34683, 34948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 34683, 34948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override System.Globalization.CultureInfo CurrentUICulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 35181, 35349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35223, 35237);
                    lock (hostGlobalLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35279, 35315);

                        return f_111_35286_35314();
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 35181, 35349);

                    System.Globalization.CultureInfo
                    f_111_35286_35314()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 35286, 35314);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 35091, 35360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 35091, 35360);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void SetShouldExit(int exitCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 35445, 36118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35524, 35538);
                lock (hostGlobalLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35632, 36092) || true) && (f_111_35636_35657(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 35632, 36092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35699, 35718);

                        f_111_35699_35717(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 35632, 36092);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 35632, 36092);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35760, 36092) || true) && (f_111_35764_35775())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 35760, 36092);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35817, 35862);

                            f_111_35817_35861(this, DebuggerResumeAction.Continue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 35760, 36092);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 35760, 36092);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35944, 35972);

                            _setShouldExitCalled = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 35994, 36027);

                            _exitCodeFromRunspace = exitCode;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 36049, 36073);

                            ShouldEndSession = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 35760, 36092);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 35632, 36092);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 35445, 36118);

                bool
                f_111_35636_35657(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.IsRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 35636, 35657);
                    return return_v;
                }


                int
                f_111_35699_35717(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    this_param.PopRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 35699, 35717);
                    return 0;
                }


                bool
                f_111_35764_35775()
                {
                    var return_v = InDebugMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 35764, 35775);
                    return return_v;
                }


                int
                f_111_35817_35861(Microsoft.PowerShell.ConsoleHost
                this_param, System.Management.Automation.DebuggerResumeAction
                resumeAction)
                {
                    this_param.ExitDebugMode(resumeAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 35817, 35861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 35445, 36118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 35445, 36118);
            }
        }

        public override void EnterNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 36508, 37315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 36729, 36776);

                Executor
                oldCurrent = f_111_36751_36775()
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 36921, 36953);

                    Executor.CurrentExecutor = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 36977, 36991);
                    lock (hostGlobalLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37033, 37101);

                        IsNested = oldCurrent != null || (DynAbs.Tracing.TraceSender.Expression_False(111, 37044, 37100) || f_111_37066_37100(this.ui));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37140, 37182);

                    f_111_37140_37181(this, f_111_37172_37180());
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(111, 37211, 37304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37251, 37289);

                    Executor.CurrentExecutor = oldCurrent;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(111, 37211, 37304);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 36508, 37315);

                Microsoft.PowerShell.Executor
                f_111_36751_36775()
                {
                    var return_v = Executor.CurrentExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 36751, 36775);
                    return return_v;
                }


                bool
                f_111_37066_37100(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    var return_v = this_param.IsCommandCompletionRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 37066, 37100);
                    return return_v;
                }


                bool
                f_111_37172_37180()
                {
                    var return_v = IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 37172, 37180);
                    return return_v;
                }


                int
                f_111_37140_37181(Microsoft.PowerShell.ConsoleHost
                parent, bool
                isNested)
                {
                    InputLoop.RunNewInputLoop(parent, isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 37140, 37181);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 36508, 37315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 36508, 37315);
            }
        }

        public override void ExitNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 37530, 37713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37600, 37614);
                lock (hostGlobalLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37648, 37687);

                    IsNested = f_111_37659_37686();
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 37530, 37713);

                bool
                f_111_37659_37686()
                {
                    var return_v = InputLoop.ExitCurrentLoop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 37659, 37686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 37530, 37713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 37530, 37713);
            }
        }

        public override void NotifyBeginApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 37801, 38651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37877, 37891);
                lock (hostGlobalLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37925, 37956);

                    ++_beginApplicationNotifyCount;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 37974, 38625) || true) && (_beginApplicationNotifyCount == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 37974, 38625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 38122, 38163);

                        _savedWindowTitle = f_111_38142_38162(f_111_38142_38150(ui));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 38196, 38598) || true) && (_initialConsoleMode != ConsoleControl.ConsoleModes.Unknown)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 38196, 38598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 38308, 38384);

                            var
                            activeScreenBufferHandle = f_111_38339_38383()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 38410, 38479);

                            _savedConsoleMode = f_111_38430_38478(activeScreenBufferHandle);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 38505, 38575);

                            f_111_38505_38574(activeScreenBufferHandle, _initialConsoleMode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 38196, 38598);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 37974, 38625);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 37801, 38651);

                System.Management.Automation.Host.PSHostRawUserInterface
                f_111_38142_38150(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 38142, 38150);
                    return return_v;
                }


                string
                f_111_38142_38162(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.WindowTitle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 38142, 38162);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_111_38339_38383()
                {
                    var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 38339, 38383);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleControl.ConsoleModes
                f_111_38430_38478(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = ConsoleControl.GetMode(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 38430, 38478);
                    return return_v;
                }


                int
                f_111_38505_38574(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, Microsoft.PowerShell.ConsoleControl.ConsoleModes
                mode)
                {
                    ConsoleControl.SetMode(consoleHandle, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 38505, 38574);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 37801, 38651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 37801, 38651);
            }
        }

        public override void NotifyEndApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 38792, 39619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 38866, 38880);
                lock (hostGlobalLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 38914, 39029);

                    f_111_38914_39028(_beginApplicationNotifyCount > 0, "Not running an executable - NotifyBeginApplication was not called!");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 39047, 39078);

                    --_beginApplicationNotifyCount;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 39096, 39593) || true) && (_beginApplicationNotifyCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 39096, 39593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 39271, 39312);

                        f_111_39271_39279(ui).WindowTitle = _savedWindowTitle;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 39345, 39566) || true) && (_savedConsoleMode != ConsoleControl.ConsoleModes.Unknown)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 39345, 39566);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 39455, 39543);

                            f_111_39455_39542(f_111_39478_39522(), _savedConsoleMode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 39345, 39566);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 39096, 39593);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 38792, 39619);

                int
                f_111_38914_39028(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 38914, 39028);
                    return 0;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_111_39271_39279(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 39271, 39279);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_111_39478_39522()
                {
                    var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 39478, 39522);
                    return return_v;
                }


                int
                f_111_39455_39542(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, Microsoft.PowerShell.ConsoleControl.ConsoleModes
                mode)
                {
                    ConsoleControl.SetMode(consoleHandle, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 39455, 39542);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 38792, 39619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 38792, 39619);
            }
        }

        private double _profileLoadTimeInMS;

        internal ConsoleHost()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 40582, 41958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 22087, 22152);
                this.InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 26901, 26926);
                this._isRunspacePushed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 34521, 34539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 40397, 40417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 46733, 46805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 46817, 46874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 46886, 46957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 47887, 47931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 83930, 83968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 84116, 84210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 84240, 84283);
                this._lastRunspaceInitializationException = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 84308, 84316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 111596, 111608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 111824, 111879);
                this._savedConsoleMode = ConsoleControl.ConsoleModes.Unknown;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 111926, 111983);
                this._initialConsoleMode = ConsoleControl.ConsoleModes.Unknown;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112017, 112036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112060, 112071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112116, 112118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112131, 112217);
                this.ConsoleIn = f_111_112178_112216(() => Console.In);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112244, 112276);
                this._savedWindowTitle = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112303, 112333);
                this._ver = f_111_112310_112333();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112356, 112377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112401, 112415);
                this._noExit = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112439, 112459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112483, 112503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112527, 112552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112577, 112596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 112899, 112928);
                this.hostGlobalLock = f_111_112916_112928();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113151, 113168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113191, 113219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113258, 113272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113309, 113326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113363, 113379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113403, 113425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113466, 113488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113512, 113538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113567, 113577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 723, 738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 1975, 2009);
                this._transcriptFileName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4095, 4115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 4141, 4179);
                this._transcriptionStateLock = new object(); // LAFHIS f_113_4167_4179();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 4167, 4179);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 40850, 40941);

                    _initialConsoleMode = f_111_40872_40940(f_111_40895_40939());
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 40970, 41183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41090, 41168);

                    _savedConsoleMode = _initialConsoleMode = ConsoleControl.ConsoleModes.Unknown;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(111, 40970, 41183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41207, 41269);

                f_111_41207_41227().CurrentUICulture = f_111_41247_41268(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41283, 41341);

                f_111_41283_41303().CurrentCulture = f_111_41321_41340(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41518, 41562);

                base.ShouldSetThreadUILanguageToZero = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41578, 41598);

                InDebugMode = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41612, 41642);

                _displayDebuggerBanner = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41658, 41703);

                this.ui = f_111_41668_41702(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41717, 41760);

                _consoleWriter = f_111_41734_41759(ui);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41776, 41879);

                UnhandledExceptionEventHandler
                handler = new UnhandledExceptionEventHandler(UnhandledExceptionHandler)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 41893, 41947);

                f_111_41893_41916().UnhandledException += handler;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 40582, 41958);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 40582, 41958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 40582, 41958);
            }
        }

        private void BindBreakHandler()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 41970, 42338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42129, 42216);

                breakHandlerGcHandle = GCHandle.Alloc(new ConsoleControl.BreakHandler(MyBreakHandler));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42230, 42319);

                f_111_42230_42318(breakHandlerGcHandle.Target);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 41970, 42338);

                int
                f_111_42230_42318(object
                handlerDelegate)
                {
                    ConsoleControl.AddBreakHandler((Microsoft.PowerShell.ConsoleControl.BreakHandler)handlerDelegate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 42230, 42318);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 41970, 42338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 41970, 42338);
            }
        }

        private void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 42350, 43114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42693, 42718);

                _shouldEndSession = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42734, 42753);

                Exception
                e = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42769, 42870) || true) && (args != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 42769, 42870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42819, 42855);

                    e = (Exception)f_111_42834_42854(args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 42769, 42870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42886, 42901);

                f_111_42886_42900(
                            ui);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 42915, 43074);

                f_111_42915_43073(ui, ConsoleColor.Red, f_111_42977_43001(f_111_42977_42985(ui)), f_111_43020_43072());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43088, 43103);

                f_111_43088_43102(ui);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 42350, 43114);

                object
                f_111_42834_42854(System.UnhandledExceptionEventArgs
                this_param)
                {
                    var return_v = this_param.ExceptionObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 42834, 42854);
                    return return_v;
                }


                int
                f_111_42886_42900(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 42886, 42900);
                    return 0;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_111_42977_42985(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 42977, 42985);
                    return return_v;
                }


                System.ConsoleColor
                f_111_42977_43001(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.BackgroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 42977, 43001);
                    return return_v;
                }


                string
                f_111_43020_43072()
                {
                    var return_v = ConsoleHostStrings.UnhandledExceptionShutdownMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 43020, 43072);
                    return return_v;
                }


                int
                f_111_42915_43073(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.Write(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 42915, 43073);
                    return 0;
                }


                int
                f_111_43088_43102(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 43088, 43102);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 42350, 43114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 42350, 43114);
            }
        }

        /// <summary>
        /// Finalizes the instance.
        /// </summary>
        ~ConsoleHost()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43249, 43264);

            f_111_43249_43263(this, false);
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 43403, 43514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43449, 43463);

                f_111_43449_43462(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43477, 43503);

                f_111_43477_43502(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 43403, 43514);

                int
                f_111_43449_43462(Microsoft.PowerShell.ConsoleHost
                this_param, bool
                isDisposingNotFinalizing)
                {
                    this_param.Dispose(isDisposingNotFinalizing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 43449, 43462);
                    return 0;
                }


                int
                f_111_43477_43502(Microsoft.PowerShell.ConsoleHost
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 43477, 43502);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 43403, 43514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 43403, 43514);
            }
        }

        private void Dispose(bool isDisposingNotFinalizing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 43526, 45033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43602, 44987) || true) && (!_isDisposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 43602, 44987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43663, 43735);

                    f_111_43663_43734(breakHandlerGcHandle != null, "break handler should be set");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43753, 43789);

                    f_111_43753_43788();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43807, 43932) || true) && (breakHandlerGcHandle.IsAllocated)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 43807, 43932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43885, 43913);

                        breakHandlerGcHandle.Free();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 43807, 43932);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 43960, 44972) || true) && (isDisposingNotFinalizing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 43960, 44972);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44030, 44140) || true) && (f_111_44034_44048())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 44030, 44140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44098, 44117);

                            f_111_44098_44116(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 44030, 44140);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44164, 44290) || true) && (_outputSerializer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 44164, 44290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44243, 44267);

                            f_111_44243_44266(_outputSerializer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 44164, 44290);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44314, 44438) || true) && (_errorSerializer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 44314, 44438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44392, 44415);

                            f_111_44392_44414(_errorSerializer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 44314, 44438);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44462, 44877) || true) && (_runspaceRef != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 44462, 44877);
                            // NTRAID#Windows Out Of Band Releases-925297-2005/12/14
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44678, 44710);

                                f_111_44678_44709(f_111_44678_44699(_runspaceRef));
                            }
                            catch (InvalidRunspaceStateException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 44763, 44854);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(111, 44763, 44854);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 44462, 44877);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44901, 44921);

                        _runspaceRef = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 44943, 44953);

                        ui = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 43960, 44972);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 43602, 44987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 45003, 45022);

                _isDisposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 43526, 45033);

                int
                f_111_43663_43734(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 43663, 43734);
                    return 0;
                }


                int
                f_111_43753_43788()
                {
                    ConsoleControl.RemoveBreakHandler();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 43753, 43788);
                    return 0;
                }


                bool
                f_111_44034_44048()
                {
                    var return_v = IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 44034, 44048);
                    return return_v;
                }


                string
                f_111_44098_44116(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.StopTranscribing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 44098, 44116);
                    return return_v;
                }


                int
                f_111_44243_44266(Microsoft.PowerShell.WrappedSerializer
                this_param)
                {
                    this_param.End();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 44243, 44266);
                    return 0;
                }


                int
                f_111_44392_44414(Microsoft.PowerShell.WrappedSerializer
                this_param)
                {
                    this_param.End();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 44392, 44414);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_44678_44699(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 44678, 44699);
                    return return_v;
                }


                int
                f_111_44678_44709(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 44678, 44709);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 43526, 45033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 43526, 45033);
            }
        }

        internal bool ShouldEndSession
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 45727, 45960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 45763, 45783);

                    bool
                    result = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 45809, 45823);

                    lock (hostGlobalLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 45865, 45892);

                        result = _shouldEndSession;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 45931, 45945);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 45727, 45960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 45551, 46390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 45551, 46390);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 45976, 46379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 46018, 46032);
                    lock (hostGlobalLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 46159, 46295);

                        f_111_46159_46294(_shouldEndSession != true || (DynAbs.Tracing.TraceSender.Expression_False(111, 46170, 46213) || value != false), "ShouldEndSession can only be set from false to true");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 46319, 46345);

                        _shouldEndSession = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 45976, 46379);

                    int
                    f_111_46159_46294(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 46159, 46294);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 45551, 46390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 45551, 46390);
                }
            }
        }

        internal RunspaceRef RunspaceRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 46639, 46710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 46675, 46695);

                    return _runspaceRef;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 46639, 46710);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 46582, 46721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 46582, 46721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal WrappedSerializer.DataFormat OutputFormat { get; private set; }

        internal bool OutputFormatSpecified { get; private set; }

        internal WrappedSerializer.DataFormat InputFormat { get; private set; }

        internal WrappedDeserializer.DataFormat ErrorFormat
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 47045, 47633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 47081, 47134);

                    WrappedDeserializer.DataFormat
                    format = f_111_47121_47133()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 47375, 47584) || true) && (f_111_47379_47401_M(!OutputFormatSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(111, 47379, 47427) && f_111_47405_47418() == false) && (DynAbs.Tracing.TraceSender.Expression_True(111, 47379, 47456) && f_111_47431_47456()) && (DynAbs.Tracing.TraceSender.Expression_True(111, 47379, 47485) && _wasInitialCommandEncoded))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 47375, 47584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 47527, 47565);

                        format = Serialization.DataFormat.XML;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 47375, 47584);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 47604, 47618);

                    return format;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 47045, 47633);

                    Microsoft.PowerShell.Serialization.DataFormat
                    f_111_47121_47133()
                    {
                        var return_v = OutputFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 47121, 47133);
                        return return_v;
                    }


                    bool
                    f_111_47379_47401_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 47379, 47401);
                        return return_v;
                    }


                    bool
                    f_111_47405_47418()
                    {
                        var return_v = IsInteractive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 47405, 47418);
                        return return_v;
                    }


                    bool
                    f_111_47431_47456()
                    {
                        var return_v = Console.IsErrorRedirected;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 47431, 47456);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 46969, 47644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 46969, 47644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsRunningAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 47709, 47864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 47745, 47849);

                    return f_111_47752_47766_M(!IsInteractive) && (DynAbs.Tracing.TraceSender.Expression_True(111, 47752, 47848) && ((f_111_47772_47784() != Serialization.DataFormat.Text) || (DynAbs.Tracing.TraceSender.Expression_False(111, 47771, 47847) || f_111_47822_47847())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 47709, 47864);

                    bool
                    f_111_47752_47766_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 47752, 47766);
                        return return_v;
                    }


                    Microsoft.PowerShell.Serialization.DataFormat
                    f_111_47772_47784()
                    {
                        var return_v = OutputFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 47772, 47784);
                        return return_v;
                    }


                    bool
                    f_111_47822_47847()
                    {
                        var return_v = Console.IsInputRedirected;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 47822, 47847);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 47656, 47875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 47656, 47875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsNested { get; private set; }

        internal WrappedSerializer OutputSerializer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 48011, 48438);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 48047, 48378) || true) && (_outputSerializer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 48047, 48378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 48118, 48359);

                        _outputSerializer =
                        f_111_48163_48358(f_111_48215_48227(), "Output", (DynAbs.Tracing.TraceSender.Conditional_F1(111, 48297, 48323) || ((f_111_48297_48323() && DynAbs.Tracing.TraceSender.Conditional_F2(111, 48326, 48337)) || DynAbs.Tracing.TraceSender.Conditional_F3(111, 48340, 48357))) ? f_111_48326_48337() : f_111_48340_48357());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 48047, 48378);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 48398, 48423);

                    return _outputSerializer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 48011, 48438);

                    Microsoft.PowerShell.Serialization.DataFormat
                    f_111_48215_48227()
                    {
                        var return_v = OutputFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48215, 48227);
                        return return_v;
                    }


                    bool
                    f_111_48297_48323()
                    {
                        var return_v = Console.IsOutputRedirected;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48297, 48323);
                        return return_v;
                    }


                    System.IO.TextWriter
                    f_111_48326_48337()
                    {
                        var return_v = Console.Out;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48326, 48337);
                        return return_v;
                    }


                    System.IO.TextWriter
                    f_111_48340_48357()
                    {
                        var return_v = ConsoleTextWriter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48340, 48357);
                        return return_v;
                    }


                    Microsoft.PowerShell.WrappedSerializer
                    f_111_48163_48358(Microsoft.PowerShell.Serialization.DataFormat
                    dataFormat, string
                    streamName, System.IO.TextWriter
                    output)
                    {
                        var return_v = new Microsoft.PowerShell.WrappedSerializer(dataFormat, streamName, output);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 48163, 48358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 47943, 48449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 47943, 48449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal WrappedSerializer ErrorSerializer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 48528, 48951);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 48564, 48892) || true) && (_errorSerializer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 48564, 48892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 48634, 48873);

                        _errorSerializer =
                        f_111_48678_48872(f_111_48730_48741(), "Error", (DynAbs.Tracing.TraceSender.Conditional_F1(111, 48810, 48835) || ((f_111_48810_48835() && DynAbs.Tracing.TraceSender.Conditional_F2(111, 48838, 48851)) || DynAbs.Tracing.TraceSender.Conditional_F3(111, 48854, 48871))) ? f_111_48838_48851() : f_111_48854_48871());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 48564, 48892);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 48912, 48936);

                    return _errorSerializer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 48528, 48951);

                    Microsoft.PowerShell.Serialization.DataFormat
                    f_111_48730_48741()
                    {
                        var return_v = ErrorFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48730, 48741);
                        return return_v;
                    }


                    bool
                    f_111_48810_48835()
                    {
                        var return_v = Console.IsErrorRedirected;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48810, 48835);
                        return return_v;
                    }


                    System.IO.TextWriter
                    f_111_48838_48851()
                    {
                        var return_v = Console.Error;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48838, 48851);
                        return return_v;
                    }


                    System.IO.TextWriter
                    f_111_48854_48871()
                    {
                        var return_v = ConsoleTextWriter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 48854, 48871);
                        return return_v;
                    }


                    Microsoft.PowerShell.WrappedSerializer
                    f_111_48678_48872(Microsoft.PowerShell.Serialization.DataFormat
                    dataFormat, string
                    streamName, System.IO.TextWriter
                    output)
                    {
                        var return_v = new Microsoft.PowerShell.WrappedSerializer(dataFormat, streamName, output);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 48678, 48872);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 48461, 48962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 48461, 48962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsInteractive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 49026, 49250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 49186, 49235);

                    return _isRunningPromptLoop && (DynAbs.Tracing.TraceSender.Expression_True(111, 49193, 49234) && f_111_49217_49234_M(!ui.ReadFromStdin));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 49026, 49250);

                    bool
                    f_111_49217_49234_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 49217, 49234);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 48974, 49261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 48974, 49261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TextWriter ConsoleTextWriter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 49335, 49507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 49371, 49452);

                    f_111_49371_49451(_consoleWriter != null, "consoleWriter should have been initialized");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 49470, 49492);

                    return _consoleWriter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 49335, 49507);

                    int
                    f_111_49371_49451(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 49371, 49451);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 49273, 49518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 49273, 49518);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private uint Run(CommandLineParameterParser cpp, bool isPrestartWarned)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 50113, 52822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50209, 50281);

                f_111_50209_50280(cpp != null, "CommandLine parameter parser cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50295, 50327);

                uint
                exitCode = ExitCodeSuccess
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 50343, 52779);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50378, 50454);

                            f_111_50378_50453(s_runspaceInitTracer, "starting parse of command line parameters");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50474, 50501);

                            exitCode = ExitCodeSuccess;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50519, 50985) || true) && (!f_111_50524_50564(f_111_50545_50563(cpp)) && (DynAbs.Tracing.TraceSender.Expression_True(111, 50523, 50584) && isPrestartWarned))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 50519, 50985);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50626, 50721);

                                f_111_50626_50720(s_tracer, "Start up warnings made command \"{0}\" not executed", f_111_50701_50719(cpp));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50743, 50840);

                                string
                                msg = f_111_50756_50839(f_111_50774_50818(), f_111_50820_50838(cpp))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50862, 50885);

                                f_111_50862_50884(ui, msg);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50907, 50938);

                                exitCode = ExitCodeInitFailure;
                                DynAbs.Tracing.TraceSender.TraceBreak(111, 50960, 50966);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 50519, 50985);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51005, 51225) || true) && (f_111_51009_51025(cpp))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 51005, 51225);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51067, 51132);

                                f_111_51067_51131(s_tracer, "processing of cmdline args failed, exiting");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51154, 51178);

                                exitCode = f_111_51165_51177(cpp);
                                DynAbs.Tracing.TraceSender.TraceBreak(111, 51200, 51206);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 51005, 51225);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51245, 51277);

                            OutputFormat = f_111_51260_51276(cpp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51295, 51345);

                            OutputFormatSpecified = f_111_51319_51344(cpp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51363, 51393);

                            InputFormat = f_111_51377_51392(cpp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51411, 51468);

                            _wasInitialCommandEncoded = f_111_51439_51467(cpp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51488, 51570);

                            ui.ReadFromStdin = f_111_51507_51540(cpp) || (DynAbs.Tracing.TraceSender.Expression_False(111, 51507, 51569) || f_111_51544_51569());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51588, 51615);

                            ui.NoPrompt = f_111_51602_51614(cpp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51633, 51684);

                            ui.ThrowOnReadAndPrompt = f_111_51659_51683(cpp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51702, 51723);

                            _noExit = f_111_51712_51722(cpp);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51853, 52162) || true) && (!f_111_51858_51899(f_111_51879_51898(cpp)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 51853, 52162);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 51941, 52033);

                                ExecutionPolicy
                                executionPolicy = f_111_51975_52032(f_111_52012_52031(cpp))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 52055, 52143);

                                f_111_52055_52142(ExecutionPolicyScope.Process, executionPolicy, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 51853, 52162);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 52279, 52462) || true) && (!f_111_52284_52324(f_111_52305_52323(cpp)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 52279, 52462);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 52366, 52443);

                                f_111_52366_52442(f_111_52423_52441(cpp));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 52279, 52462);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 52626, 52736);

                            exitCode = f_111_52637_52735(this, f_111_52652_52670(cpp), f_111_52672_52688(cpp), f_111_52690_52698(cpp), f_111_52700_52711(cpp), f_111_52713_52734(cpp));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 50343, 52779);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 50343, 52779) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 50343, 52779);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(111, 50343, 52779);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 52795, 52811);

                return exitCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 50113, 52822);

                int
                f_111_50209_50280(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 50209, 50280);
                    return 0;
                }


                int
                f_111_50378_50453(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 50378, 50453);
                    return 0;
                }


                string
                f_111_50545_50563(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 50545, 50563);
                    return return_v;
                }


                bool
                f_111_50524_50564(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 50524, 50564);
                    return return_v;
                }


                string
                f_111_50701_50719(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 50701, 50719);
                    return return_v;
                }


                int
                f_111_50626_50720(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 50626, 50720);
                    return 0;
                }


                string
                f_111_50774_50818()
                {
                    var return_v = ConsoleHostStrings.InitialCommandNotExecuted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 50774, 50818);
                    return return_v;
                }


                string
                f_111_50820_50838(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 50820, 50838);
                    return return_v;
                }


                string
                f_111_50756_50839(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 50756, 50839);
                    return return_v;
                }


                int
                f_111_50862_50884(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 50862, 50884);
                    return 0;
                }


                bool
                f_111_51009_51025(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.AbortStartup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51009, 51025);
                    return return_v;
                }


                int
                f_111_51067_51131(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 51067, 51131);
                    return 0;
                }


                uint
                f_111_51165_51177(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ExitCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51165, 51177);
                    return return_v;
                }


                Microsoft.PowerShell.Serialization.DataFormat
                f_111_51260_51276(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.OutputFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51260, 51276);
                    return return_v;
                }


                bool
                f_111_51319_51344(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.OutputFormatSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51319, 51344);
                    return return_v;
                }


                Microsoft.PowerShell.Serialization.DataFormat
                f_111_51377_51392(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InputFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51377, 51392);
                    return return_v;
                }


                bool
                f_111_51439_51467(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.WasInitialCommandEncoded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51439, 51467);
                    return return_v;
                }


                bool
                f_111_51507_51540(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ExplicitReadCommandsFromStdin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51507, 51540);
                    return return_v;
                }


                bool
                f_111_51544_51569()
                {
                    var return_v = Console.IsInputRedirected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51544, 51569);
                    return return_v;
                }


                bool
                f_111_51602_51614(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.NoPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51602, 51614);
                    return return_v;
                }


                bool
                f_111_51659_51683(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ThrowOnReadAndPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51659, 51683);
                    return return_v;
                }


                bool
                f_111_51712_51722(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.NoExit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51712, 51722);
                    return return_v;
                }


                string
                f_111_51879_51898(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ExecutionPolicy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 51879, 51898);
                    return return_v;
                }


                bool
                f_111_51858_51899(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 51858, 51899);
                    return return_v;
                }


                string
                f_111_52012_52031(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ExecutionPolicy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52012, 52031);
                    return return_v;
                }


                Microsoft.PowerShell.ExecutionPolicy
                f_111_51975_52032(string
                policy)
                {
                    var return_v = SecuritySupport.ParseExecutionPolicy(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 51975, 52032);
                    return return_v;
                }


                int
                f_111_52055_52142(Microsoft.PowerShell.ExecutionPolicyScope
                scope, Microsoft.PowerShell.ExecutionPolicy
                policy, string
                shellId)
                {
                    SecuritySupport.SetExecutionPolicy(scope, policy, shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 52055, 52142);
                    return 0;
                }


                string
                f_111_52305_52323(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.CustomPipeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52305, 52323);
                    return return_v;
                }


                bool
                f_111_52284_52324(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 52284, 52324);
                    return return_v;
                }


                string
                f_111_52423_52441(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.CustomPipeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52423, 52441);
                    return return_v;
                }


                int
                f_111_52366_52442(string
                pipeName)
                {
                    RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 52366, 52442);
                    return 0;
                }


                string
                f_111_52652_52670(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52652, 52670);
                    return return_v;
                }


                bool
                f_111_52672_52688(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.SkipProfiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52672, 52688);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                f_111_52690_52698(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.Args;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52690, 52698);
                    return return_v;
                }


                bool
                f_111_52700_52711(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.StaMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52700, 52711);
                    return return_v;
                }


                string
                f_111_52713_52734(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 52713, 52734);
                    return return_v;
                }


                uint
                f_111_52637_52735(Microsoft.PowerShell.ConsoleHost
                this_param, string
                initialCommand, bool
                skipProfiles, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                initialCommandArgs, bool
                staMode, string
                configurationName)
                {
                    var return_v = this_param.DoRunspaceLoop(initialCommand, skipProfiles, initialCommandArgs, staMode, configurationName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 52637, 52735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 50113, 52822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 50113, 52822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private uint DoRunspaceLoop(string initialCommand, bool skipProfiles, Collection<CommandParameter> initialCommandArgs, bool staMode, string configurationName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 53113, 55106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 53296, 53323);

                ExitCode = ExitCodeSuccess;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 53339, 55063) || true) && (f_111_53346_53363_M(!ShouldEndSession))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 53339, 55063);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 53397, 53538);

                        RunspaceCreationEventArgs
                        args = f_111_53430_53537(initialCommand, skipProfiles, staMode, configurationName, initialCommandArgs)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 53556, 53577);

                        f_111_53556_53576(this, args);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 53597, 53644) || true) && (ExitCode == ExitCodeInitFailure)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 53597, 53644);
                            DynAbs.Tracing.TraceSender.TraceBreak(111, 53636, 53642);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 53597, 53644);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 53664, 54074) || true) && (!_noExit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 53664, 54074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 53879, 53903);

                            ShouldEndSession = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 53664, 54074);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 53664, 54074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54035, 54055);

                            f_111_54035_54054(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 53664, 54074);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54094, 54781) || true) && (_setShouldExitCalled)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 54094, 54781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54160, 54210);

                            ExitCode = unchecked((uint)_exitCodeFromRunspace);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 54094, 54781);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 54094, 54781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54292, 54341);

                            Executor
                            exec = f_111_54308_54340(this, false, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54365, 54443);

                            bool
                            dollarHook = f_111_54383_54433(exec, "$global:?") ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(111, 54383, 54442) ?? false)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54467, 54762) || true) && (dollarHook && (DynAbs.Tracing.TraceSender.Expression_True(111, 54471, 54531) && (_lastRunspaceInitializationException == null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 54467, 54762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54581, 54608);

                                ExitCode = ExitCodeSuccess;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 54467, 54762);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 54467, 54762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54706, 54739);

                                ExitCode = ExitCodeSuccess | 0x1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 54467, 54762);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 54094, 54781);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54801, 54831);

                        f_111_54801_54830(f_111_54801_54822(_runspaceRef));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54849, 54869);

                        _runspaceRef = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 54889, 55048) || true) && (staMode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 54889, 55048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55005, 55029);

                            ShouldEndSession = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 54889, 55048);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 53339, 55063);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 53339, 55063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(111, 53339, 55063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55079, 55095);

                return ExitCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 53113, 55106);

                bool
                f_111_53346_53363_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 53346, 53363);
                    return return_v;
                }


                Microsoft.PowerShell.RunspaceCreationEventArgs
                f_111_53430_53537(string
                initialCommand, bool
                skipProfiles, bool
                staMode, string
                configurationName, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                initialCommandArgs)
                {
                    var return_v = new Microsoft.PowerShell.RunspaceCreationEventArgs(initialCommand, skipProfiles, staMode, configurationName, initialCommandArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 53430, 53537);
                    return return_v;
                }


                int
                f_111_53556_53576(Microsoft.PowerShell.ConsoleHost
                this_param, Microsoft.PowerShell.RunspaceCreationEventArgs
                runspaceCreationArgs)
                {
                    this_param.CreateRunspace((object)runspaceCreationArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 53556, 53576);
                    return 0;
                }


                int
                f_111_54035_54054(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    this_param.EnterNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 54035, 54054);
                    return 0;
                }


                Microsoft.PowerShell.Executor
                f_111_54308_54340(Microsoft.PowerShell.ConsoleHost
                parent, bool
                useNestedPipelines, bool
                isPromptFunctionExecutor)
                {
                    var return_v = new Microsoft.PowerShell.Executor(parent, useNestedPipelines, isPromptFunctionExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 54308, 54340);
                    return return_v;
                }


                bool?
                f_111_54383_54433(Microsoft.PowerShell.Executor
                this_param, string
                command)
                {
                    var return_v = this_param.ExecuteCommandAndGetResultAsBool(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 54383, 54433);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_54801_54822(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 54801, 54822);
                    return return_v;
                }


                int
                f_111_54801_54830(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 54801, 54830);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 53113, 55106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 53113, 55106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Exception InitializeRunspaceHelper(string command, Executor exec, Executor.ExecutionOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 55118, 55898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55251, 55325);

                f_111_55251_55324(!f_111_55263_55292(command), "command should have a value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55339, 55401);

                f_111_55339_55400(exec != null, "non-null Executor instance needed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55417, 55480);

                f_111_55417_55479(
                            s_runspaceInitTracer, "running command {0}", command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55496, 55515);

                Exception
                e = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55531, 55759) || true) && (f_111_55535_55549())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 55531, 55759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55583, 55633);

                    f_111_55583_55632(exec, command, out e, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 55531, 55759);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 55531, 55759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55699, 55744);

                    f_111_55699_55743(exec, command, out e, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 55531, 55759);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55775, 55862) || true) && (e != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 55775, 55862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55822, 55847);

                    f_111_55822_55846(this, e, exec);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 55775, 55862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55878, 55887);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 55118, 55898);

                bool
                f_111_55263_55292(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 55263, 55292);
                    return return_v;
                }


                int
                f_111_55251_55324(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 55251, 55324);
                    return 0;
                }


                int
                f_111_55339_55400(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 55339, 55400);
                    return 0;
                }


                int
                f_111_55417_55479(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 55417, 55479);
                    return 0;
                }


                bool
                f_111_55535_55549()
                {
                    var return_v = IsRunningAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 55535, 55549);
                    return return_v;
                }


                int
                f_111_55583_55632(Microsoft.PowerShell.Executor
                this_param, string
                command, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    this_param.ExecuteCommandAsync(command, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 55583, 55632);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_111_55699_55743(Microsoft.PowerShell.Executor
                this_param, string
                command, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    var return_v = this_param.ExecuteCommand(command, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 55699, 55743);
                    return return_v;
                }


                int
                f_111_55822_55846(Microsoft.PowerShell.ConsoleHost
                this_param, System.Exception
                e, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.ReportException(e, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 55822, 55846);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 55118, 55898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 55118, 55898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CreateRunspace(object runspaceCreationArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 55910, 56645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 55991, 56029);

                RunspaceCreationEventArgs
                args = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 56079, 56136);

                    args = runspaceCreationArgs as RunspaceCreationEventArgs;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 56154, 56235);

                    f_111_56154_56234(args != null, "Event Arguments to CreateRunspace should not be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 56253, 56373);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceString($"{args.InitialCommand}, {args.SkipProfiles}, {args.StaMode}, {args.ConfigurationName}, {args.InitialCommandArgs}");

                    f_111_56253_56372(this, f_111_56270_56289(args), f_111_56291_56308(args), f_111_56310_56322(args), f_111_56324_56346(args), f_111_56348_56371(args));
                }
                catch (ConsoleHostStartupException startupException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 56402, 56634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 56487, 56570);

                    f_111_56487_56569(this, f_111_56511_56542(startupException), f_111_56544_56568(startupException));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 56588, 56619);

                    ExitCode = ExitCodeInitFailure;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(111, 56402, 56634);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 55910, 56645);

                int
                f_111_56154_56234(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 56154, 56234);
                    return 0;
                }


                string
                f_111_56270_56289(Microsoft.PowerShell.RunspaceCreationEventArgs
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 56270, 56289);
                    return return_v;
                }


                bool
                f_111_56291_56308(Microsoft.PowerShell.RunspaceCreationEventArgs
                this_param)
                {
                    var return_v = this_param.SkipProfiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 56291, 56308);
                    return return_v;
                }


                bool
                f_111_56310_56322(Microsoft.PowerShell.RunspaceCreationEventArgs
                this_param)
                {
                    var return_v = this_param.StaMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 56310, 56322);
                    return return_v;
                }


                string
                f_111_56324_56346(Microsoft.PowerShell.RunspaceCreationEventArgs
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 56324, 56346);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                f_111_56348_56371(Microsoft.PowerShell.RunspaceCreationEventArgs
                this_param)
                {
                    var return_v = this_param.InitialCommandArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 56348, 56371);
                    return return_v;
                }


                int
                f_111_56253_56372(Microsoft.PowerShell.ConsoleHost
                this_param, string
                initialCommand, bool
                skipProfiles, bool
                staMode, string
                configurationName, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                initialCommandArgs)
                {
                    this_param.DoCreateRunspace(initialCommand, skipProfiles, staMode, configurationName, initialCommandArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 56253, 56372);
                    return 0;
                }


                System.Exception
                f_111_56511_56542(Microsoft.PowerShell.ConsoleHost.ConsoleHostStartupException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 56511, 56542);
                    return return_v;
                }


                string
                f_111_56544_56568(Microsoft.PowerShell.ConsoleHost.ConsoleHostStartupException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 56544, 56568);
                    return return_v;
                }


                int
                f_111_56487_56569(Microsoft.PowerShell.ConsoleHost
                this_param, System.Exception
                e, string
                header)
                {
                    this_param.ReportExceptionFallback(e, header);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 56487, 56569);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 55910, 56645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 55910, 56645);
            }
        }

        private bool IsScreenReaderActive()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 56943, 57995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57003, 57117) || true) && (f_111_57007_57035(_screenReaderActive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 57003, 57117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57069, 57102);

                    return f_111_57076_57101(_screenReaderActive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 57003, 57117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57133, 57161);

                _screenReaderActive = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57175, 57935) || true) && (f_111_57179_57204())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 57175, 57935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57726, 57747);

                    bool
                    enabled = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57765, 57920) || true) && (f_111_57769_57829(SPI_GETSCREENREADER, 0, ref enabled, 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 57765, 57920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57871, 57901);

                        _screenReaderActive = enabled;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 57765, 57920);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 57175, 57935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 57951, 57984);

                return f_111_57958_57983(_screenReaderActive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 56943, 57995);

                bool
                f_111_57007_57035(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 57007, 57035);
                    return return_v;
                }


                bool
                f_111_57076_57101(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 57076, 57101);
                    return return_v;
                }


                bool
                f_111_57179_57204()
                {
                    var return_v = Platform.IsWindowsDesktop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 57179, 57204);
                    return return_v;
                }


                bool
                f_111_57769_57829(uint
                uiAction, int
                uiParam, ref bool
                pvParam, int
                fWinIni)
                {
                    var return_v = SystemParametersInfo(uiAction, (uint)uiParam, ref pvParam, (uint)fWinIni);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 57769, 57829);
                    return return_v;
                }


                bool
                f_111_57958_57983(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 57958, 57983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 56943, 57995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 56943, 57995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LoadPSReadline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 58007, 58883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 58769, 58872);

                return ((f_111_58778_58798(s_cpp) == null && (DynAbs.Tracing.TraceSender.Expression_True(111, 58778, 58828) && f_111_58810_58820(s_cpp) == null)) || (DynAbs.Tracing.TraceSender.Expression_False(111, 58777, 58845) || f_111_58833_58845(s_cpp))) && (DynAbs.Tracing.TraceSender.Expression_True(111, 58776, 58871) && f_111_58850_58871_M(!s_cpp.NonInteractive));
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 58007, 58883);

                string
                f_111_58778_58798(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.InitialCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 58778, 58798);
                    return return_v;
                }


                string
                f_111_58810_58820(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 58810, 58820);
                    return return_v;
                }


                bool
                f_111_58833_58845(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.NoExit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 58833, 58845);
                    return return_v;
                }


                bool
                f_111_58850_58871_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 58850, 58871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 58007, 58883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 58007, 58883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DoCreateRunspace(string initialCommand, bool skipProfiles, bool staMode, string configurationName, Collection<CommandParameter> initialCommandArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 59098, 63680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 59283, 59343);

                f_111_59283_59342(_runspaceRef == null, "runspace should be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 59357, 59453);

                f_111_59357_59452(DefaultInitialSessionState != null, "DefaultInitialSessionState should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 59467, 59540);

                f_111_59467_59539(s_runspaceInitTracer, "Calling RunspaceFactory.CreateRunspace");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 59592, 59624);

                    Runspace
                    consoleRunspace = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 59642, 59672);

                    bool
                    psReadlineFailed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 60410, 60482);

                    ReadOnlyCollection<ModuleSpecification>
                    defaultImportModulesList = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 60500, 61629) || true) && (f_111_60504_60520(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 60500, 61629);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 60562, 61610) || true) && (f_111_60566_60588(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 60562, 61610);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 60638, 60735);

                            f_111_60638_60734(f_111_60638_60657(s_theConsoleHost), f_111_60668_60733());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 60761, 60793);

                            f_111_60761_60792(f_111_60761_60780(s_theConsoleHost));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 60562, 61610);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 60562, 61610);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 60961, 61023);

                            defaultImportModulesList = f_111_60988_61022(DefaultInitialSessionState);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61049, 61115);

                            f_111_61049_61114(DefaultInitialSessionState, new[] { "PSReadLine" });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61141, 61224);

                            consoleRunspace = f_111_61159_61223(this, DefaultInitialSessionState);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61310, 61356);

                                f_111_61310_61355(this, consoleRunspace, staMode);
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 61409, 61587);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61483, 61506);

                                consoleRunspace = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61536, 61560);

                                psReadlineFailed = true;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(111, 61409, 61587);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 60562, 61610);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 60500, 61629);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61649, 62226) || true) && (consoleRunspace == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 61649, 62226);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61718, 62032) || true) && (psReadlineFailed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 61718, 62032);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61871, 61915);

                            f_111_61871_61914(                        // Try again but without importing the PSReadline module.
                                                    DefaultInitialSessionState);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 61941, 62009);

                            f_111_61941_62008(DefaultInitialSessionState, defaultImportModulesList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 61718, 62032);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 62056, 62139);

                        consoleRunspace = f_111_62074_62138(this, DefaultInitialSessionState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 62161, 62207);

                        f_111_62161_62206(this, consoleRunspace, staMode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 61649, 62226);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 62246, 62289);

                    Runspace.PrimaryRunspace = consoleRunspace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 62307, 62355);

                    _runspaceRef = f_111_62322_62354(consoleRunspace);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 62375, 62598) || true) && (psReadlineFailed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 62375, 62598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 62514, 62579);

                        f_111_62514_62578(f_111_62514_62527(), f_111_62538_62577());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 62375, 62598);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 62627, 63011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 62914, 62996);

                    throw f_111_62920_62995(f_111_62952_62991(), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(111, 62627, 63011);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(111, 63025, 63325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 63100, 63310);

                    f_111_63100_63309(PSEventId.Perftrack_ConsoleStartupStop, PSOpcode.WinStop, PSTask.PowershellConsoleStartup, PSKeyword.UseAlwaysOperational);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(111, 63025, 63325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 63575, 63669);

                f_111_63575_63668(this, skipProfiles, initialCommand, configurationName, initialCommandArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 59098, 63680);

                int
                f_111_59283_59342(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 59283, 59342);
                    return 0;
                }


                int
                f_111_59357_59452(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 59357, 59452);
                    return 0;
                }


                int
                f_111_59467_59539(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 59467, 59539);
                    return 0;
                }


                bool
                f_111_60504_60520(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.LoadPSReadline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 60504, 60520);
                    return return_v;
                }


                bool
                f_111_60566_60588(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.IsScreenReaderActive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 60566, 60588);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_111_60638_60657(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 60638, 60657);
                    return return_v;
                }


                string
                f_111_60668_60733()
                {
                    var return_v = ManagedEntranceStrings.PSReadLineDisabledWhenScreenReaderIsActive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 60668, 60733);
                    return return_v;
                }


                int
                f_111_60638_60734(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 60638, 60734);
                    return 0;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_111_60761_60780(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 60761, 60780);
                    return return_v;
                }


                int
                f_111_60761_60792(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 60761, 60792);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_111_60988_61022(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 60988, 61022);
                    return return_v;
                }


                int
                f_111_61049_61114(System.Management.Automation.Runspaces.InitialSessionState
                this_param, params string[]
                name)
                {
                    this_param.ImportPSModule(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 61049, 61114);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_61159_61223(Microsoft.PowerShell.ConsoleHost
                host, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspace((System.Management.Automation.Host.PSHost)host, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 61159, 61223);
                    return return_v;
                }


                int
                f_111_61310_61355(Microsoft.PowerShell.ConsoleHost
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace, bool
                staMode)
                {
                    this_param.OpenConsoleRunspace(runspace, staMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 61310, 61355);
                    return 0;
                }


                int
                f_111_61871_61914(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    this_param.ClearPSModules();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 61871, 61914);
                    return 0;
                }


                int
                f_111_61941_62008(System.Management.Automation.Runspaces.InitialSessionState
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                modules)
                {
                    this_param.ImportPSModule((System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>)modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 61941, 62008);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_62074_62138(Microsoft.PowerShell.ConsoleHost
                host, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspace((System.Management.Automation.Host.PSHost)host, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 62074, 62138);
                    return return_v;
                }


                int
                f_111_62161_62206(Microsoft.PowerShell.ConsoleHost
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace, bool
                staMode)
                {
                    this_param.OpenConsoleRunspace(runspace, staMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 62161, 62206);
                    return 0;
                }


                System.Management.Automation.Remoting.RunspaceRef
                f_111_62322_62354(System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    var return_v = new System.Management.Automation.Remoting.RunspaceRef(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 62322, 62354);
                    return return_v;
                }


                System.IO.TextWriter
                f_111_62514_62527()
                {
                    var return_v =                     // Notify the user that PSReadline could not be loaded.
                                        Console.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 62514, 62527);
                    return return_v;
                }


                string
                f_111_62538_62577()
                {
                    var return_v = ConsoleHostStrings.CannotLoadPSReadline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 62538, 62577);
                    return return_v;
                }


                int
                f_111_62514_62578(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 62514, 62578);
                    return 0;
                }


                string
                f_111_62952_62991()
                {
                    var return_v = ConsoleHostStrings.ShellCannotBeStarted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 62952, 62991);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleHost.ConsoleHostStartupException
                f_111_62920_62995(string
                message, System.Exception
                innerException)
                {
                    var return_v = new Microsoft.PowerShell.ConsoleHost.ConsoleHostStartupException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 62920, 62995);
                    return return_v;
                }


                int
                f_111_63100_63309(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 63100, 63309);
                    return 0;
                }


                int
                f_111_63575_63668(Microsoft.PowerShell.ConsoleHost
                this_param, bool
                skipProfiles, string
                initialCommand, string
                configurationName, System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                initialCommandArgs)
                {
                    this_param.DoRunspaceInitialization(skipProfiles, initialCommand, configurationName, initialCommandArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 63575, 63668);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 59098, 63680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 59098, 63680);
            }
        }

        private void OpenConsoleRunspace(Runspace runspace, bool staMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 63692, 64168);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 63782, 63916) || true) && (staMode && (DynAbs.Tracing.TraceSender.Expression_True(111, 63786, 63822) && f_111_63797_63822()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 63782, 63916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 63856, 63901);

                    runspace.ApartmentState = ApartmentState.STA;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 63782, 63916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 63932, 63985);

                runspace.ThreadOptions = PSThreadOptions.ReuseThread;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 63999, 64055);

                runspace.EngineActivityId = f_111_64027_64054();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64071, 64127);

                f_111_64071_64126(
                            s_runspaceInitTracer, "Calling Runspace.Open");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64141, 64157);

                f_111_64141_64156(runspace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 63692, 64168);

                bool
                f_111_63797_63822()
                {
                    var return_v = Platform.IsWindowsDesktop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 63797, 63822);
                    return return_v;
                }


                System.Guid
                f_111_64027_64054()
                {
                    var return_v = EtwActivity.GetActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64027, 64054);
                    return return_v;
                }


                int
                f_111_64071_64126(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64071, 64126);
                    return 0;
                }


                int
                f_111_64141_64156(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64141, 64156);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 63692, 64168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 63692, 64168);
            }
        }

        private void DoRunspaceInitialization(bool skipProfiles, string initialCommand, string configurationName, Collection<CommandParameter> initialCommandArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 64180, 75158);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64359, 64635) || true) && (f_111_64363_64393(f_111_64363_64384(_runspaceRef)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 64359, 64635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64435, 64529);

                    f_111_64435_64528(f_111_64435_64465(f_111_64435_64456(_runspaceRef)), DebugModes.LocalScript | DebugModes.RemoteScript);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64547, 64620);

                    f_111_64547_64577(f_111_64547_64568(_runspaceRef)).DebuggerStop += this.OnExecutionSuspended;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 64359, 64635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64651, 64700);

                Executor
                exec = f_111_64667_64699(this, false, false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64775, 65734) || true) && (s_cpp != null && (DynAbs.Tracing.TraceSender.Expression_True(111, 64779, 64826) && f_111_64796_64818(s_cpp) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 64775, 65734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64860, 64906);

                    Pipeline
                    tempPipeline = f_111_64884_64905(exec)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64924, 64966);

                    var
                    command = f_111_64938_64965("Set-Location")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 64984, 65046);

                    f_111_64984_65045(f_111_64984_65002(command), "LiteralPath", f_111_65022_65044(s_cpp));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65064, 65099);

                    f_111_65064_65098(f_111_65064_65085(tempPipeline), command);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65119, 65139);

                    Exception
                    exception
                    = default(Exception);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65157, 65513) || true) && (f_111_65161_65175())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 65157, 65513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65217, 65317);

                        f_111_65217_65316(exec, tempPipeline, out exception, Executor.ExecutionOptions.AddOutputter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 65157, 65513);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 65157, 65513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65399, 65494);

                        f_111_65399_65493(exec, tempPipeline, out exception, Executor.ExecutionOptions.AddOutputter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 65157, 65513);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65533, 65719) || true) && (exception != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 65533, 65719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65596, 65645);

                        _lastRunspaceInitializationException = exception;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65667, 65700);

                        f_111_65667_65699(this, exception, exec);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 65533, 65719);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 64775, 65734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 65750, 69403) || true) && (!f_111_65755_65794(configurationName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 65750, 69403);
                    // If an endpoint configuration is specified then create a loop-back remote runspace targeting
                    // the endpoint and push onto runspace ref stack.  Ignore profile and configuration scripts.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 66094, 66190);

                        RemoteRunspace
                        remoteRunspace = f_111_66126_66189(configurationName, this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 66212, 66251);

                        remoteRunspace.ShouldCloseOnPop = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 66273, 66302);

                        f_111_66273_66301(this, remoteRunspace);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 66418, 66452);

                        _inPushedConfiguredSession = true;
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 66489, 66650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 66549, 66631);

                        throw f_111_66555_66630(f_111_66587_66626(), e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 66489, 66650);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 65750, 69403);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 65750, 69403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 66716, 66756);

                    string
                    shellId = "Microsoft.PowerShell"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 67011, 67091);

                    f_111_67011_67090(f_111_67051_67089(f_111_67051_67072(_runspaceRef)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 67111, 67186);

                    string
                    allUsersProfile = f_111_67136_67185(null, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 67204, 67294);

                    string
                    allUsersHostSpecificProfile = f_111_67241_67293(shellId, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 67312, 67389);

                    string
                    currentUserProfile = f_111_67340_67388(null, true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 67407, 67499);

                    string
                    currentUserHostSpecificProfile = f_111_67447_67498(shellId, true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 67714, 68029);

                    f_111_67714_68028(f_111_67714_67753(f_111_67714_67735(_runspaceRef)), "PROFILE", f_111_67798_68027(allUsersProfile, allUsersHostSpecificProfile, currentUserProfile, currentUserHostSpecificProfile));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68049, 69388) || true) && (!skipProfiles)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 68049, 69388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68499, 68524);

                        var
                        sw = f_111_68508_68523()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68546, 68557);

                        f_111_68546_68556(sw);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68579, 68613);

                        f_111_68579_68612(this, allUsersProfile, exec);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68635, 68681);

                        f_111_68635_68680(this, allUsersHostSpecificProfile, exec);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68703, 68740);

                        f_111_68703_68739(this, currentUserProfile, exec);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68762, 68811);

                        f_111_68762_68810(this, currentUserHostSpecificProfile, exec);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68833, 68843);

                        f_111_68833_68842(sw);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68867, 68916);

                        var
                        profileLoadTimeInMs = f_111_68893_68915(sw)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 68938, 69151) || true) && (profileLoadTimeInMs > 500 && (DynAbs.Tracing.TraceSender.Expression_True(111, 68942, 68987) && f_111_68971_68987(s_cpp)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 68938, 69151);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69037, 69128);

                            f_111_69037_69127(f_111_69037_69050(), f_111_69061_69105(), profileLoadTimeInMs);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 68938, 69151);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69175, 69218);

                        _profileLoadTimeInMS = profileLoadTimeInMs;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 68049, 69388);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 68049, 69388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69300, 69369);

                        f_111_69300_69368(s_tracer, "-noprofile option specified: skipping profiles");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 68049, 69388);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 65750, 69403);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69741, 75147) || true) && (s_cpp != null && (DynAbs.Tracing.TraceSender.Expression_True(111, 69745, 69780) && f_111_69762_69772(s_cpp) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 69741, 75147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69814, 69843);

                    string
                    filePath = f_111_69832_69842(s_cpp)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69863, 69915);

                    f_111_69863_69914(
                                    s_tracer, "running -file '{0}'", filePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69935, 69981);

                    Pipeline
                    tempPipeline = f_111_69959_69980(exec)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 69999, 70009);

                    Command
                    c
                    = default(Command);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70178, 70571) || true) && (!f_111_70183_70261(f_111_70183_70210(filePath), ".ps1", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 70178, 70571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70303, 70346);

                        string
                        script = f_111_70319_70345(filePath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70368, 70430);

                        c = f_111_70372_70429(script, isScript: true, useLocalScope: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 70178, 70571);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 70178, 70571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70512, 70552);

                        c = f_111_70516_70551(filePath, false, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 70178, 70571);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70591, 70620);

                    f_111_70591_70619(f_111_70591_70612(tempPipeline), c);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70640, 70935) || true) && (initialCommandArgs != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 70640, 70935);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70774, 70916);
                            foreach (CommandParameter p in f_111_70805_70823_I(initialCommandArgs))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 70774, 70916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 70873, 70893);

                                f_111_70873_70892(f_111_70873_70885(c), p);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 70774, 70916);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 1, 143);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(111, 1, 143);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 70640, 70935);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71117, 71306) || true) && (!_noExit && (DynAbs.Tracing.TraceSender.Expression_True(111, 71121, 71167) && !(f_111_71135_71148(this) is RemoteRunspace)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 71117, 71306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71209, 71287);

                        f_111_71209_71239(f_111_71209_71222(this)).ScriptCommandProcessorShouldRethrowExit = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 71117, 71306);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71326, 71339);

                    Exception
                    e1
                    = default(Exception);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71359, 72421) || true) && (f_111_71363_71377())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 71359, 72421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71419, 71503);

                        Executor.ExecutionOptions
                        executionOptions = Executor.ExecutionOptions.AddOutputter
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71527, 71542);

                        Token[]
                        tokens
                        = default(Token[]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71564, 71584);

                        ParseError[]
                        errors
                        = default(ParseError[]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71684, 71753);

                        Ast
                        parsedInput = f_111_71702_71752(filePath, out tokens, out errors)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71775, 72137) || true) && (f_111_71779_71822(parsedInput))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 71775, 72137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 71872, 71935);

                            executionOptions |= Executor.ExecutionOptions.ReadInputObjects;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72089, 72114);

                            ui.ReadFromStdin = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 71775, 72137);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72161, 72232);

                        f_111_72161_72231(
                                            exec, tempPipeline, out e1, executionOptions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 71359, 72421);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 71359, 72421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72314, 72402);

                        f_111_72314_72401(exec, tempPipeline, out e1, Executor.ExecutionOptions.AddOutputter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 71359, 72421);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72630, 73133) || true) && (e1 != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 72630, 73133);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72686, 73064) || true) && (!_noExit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 72686, 73064);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72802, 72816);
                            // Set ExitCode to 0x1
                            lock (hostGlobalLock)
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72874, 72902);

                                _setShouldExitCalled = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72932, 72960);

                                _exitCodeFromRunspace = 0x1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 72990, 73014);

                                ShouldEndSession = true;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 72686, 73064);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73088, 73114);

                        f_111_73088_73113(this, e1, exec);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 72630, 73133);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 69741, 75147);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 69741, 75147);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73167, 75147) || true) && (!f_111_73172_73208(initialCommand))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 73167, 75147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73307, 73353);

                        f_111_73307_73352(                // Run the command passed on the command line

                                        s_tracer, "running initial command");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73373, 73439);

                        Pipeline
                        tempPipeline = f_111_73397_73438(exec, initialCommand, true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73459, 73777) || true) && (initialCommandArgs != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 73459, 73777);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73593, 73758);
                                foreach (CommandParameter p in f_111_73624_73642_I(initialCommandArgs))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 73593, 73758);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73692, 73735);

                                    f_111_73692_73734(f_111_73692_73727(f_111_73692_73716(f_111_73692_73713(tempPipeline), 0)), p);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 73593, 73758);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 1, 166);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(111, 1, 166);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 73459, 73777);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73797, 73810);

                        Exception
                        e1
                        = default(Exception);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73830, 74899) || true) && (f_111_73834_73848())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 73830, 74899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73890, 73974);

                            Executor.ExecutionOptions
                            executionOptions = Executor.ExecutionOptions.AddOutputter
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 73998, 74013);

                            Token[]
                            tokens
                            = default(Token[]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74035, 74055);

                            ParseError[]
                            errors
                            = default(ParseError[]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74155, 74231);

                            Ast
                            parsedInput = f_111_74173_74230(initialCommand, out tokens, out errors)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74253, 74615) || true) && (f_111_74257_74300(parsedInput))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 74253, 74615);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74350, 74413);

                                executionOptions |= Executor.ExecutionOptions.ReadInputObjects;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74567, 74592);

                                ui.ReadFromStdin = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 74253, 74615);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74639, 74710);

                            f_111_74639_74709(
                                                exec, tempPipeline, out e1, executionOptions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 73830, 74899);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 73830, 74899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74792, 74880);

                            f_111_74792_74879(exec, tempPipeline, out e1, Executor.ExecutionOptions.AddOutputter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 73830, 74899);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 74919, 75132) || true) && (e1 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 74919, 75132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 75023, 75065);

                            _lastRunspaceInitializationException = e1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 75087, 75113);

                            f_111_75087_75112(this, e1, exec);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 74919, 75132);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 73167, 75147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 69741, 75147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 64180, 75158);

                System.Management.Automation.Runspaces.Runspace
                f_111_64363_64384(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64363, 64384);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_64363_64393(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64363, 64393);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_64435_64456(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64435, 64456);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_64435_64465(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64435, 64465);
                    return return_v;
                }


                int
                f_111_64435_64528(System.Management.Automation.Debugger
                this_param, System.Management.Automation.DebugModes
                mode)
                {
                    this_param.SetDebugMode(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64435, 64528);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_64547_64568(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64547, 64568);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_111_64547_64577(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64547, 64577);
                    return return_v;
                }


                Microsoft.PowerShell.Executor
                f_111_64667_64699(Microsoft.PowerShell.ConsoleHost
                parent, bool
                useNestedPipelines, bool
                isPromptFunctionExecutor)
                {
                    var return_v = new Microsoft.PowerShell.Executor(parent, useNestedPipelines, isPromptFunctionExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64667, 64699);
                    return return_v;
                }


                string
                f_111_64796_64818(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.WorkingDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64796, 64818);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_111_64884_64905(Microsoft.PowerShell.Executor
                this_param)
                {
                    var return_v = this_param.CreatePipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64884, 64905);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_111_64938_64965(string
                command)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64938, 64965);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_111_64984_65002(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 64984, 65002);
                    return return_v;
                }


                string
                f_111_65022_65044(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.WorkingDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 65022, 65044);
                    return return_v;
                }


                int
                f_111_64984_65045(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, string
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 64984, 65045);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_111_65064_65085(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 65064, 65085);
                    return return_v;
                }


                int
                f_111_65064_65098(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 65064, 65098);
                    return 0;
                }


                bool
                f_111_65161_65175()
                {
                    var return_v = IsRunningAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 65161, 65175);
                    return return_v;
                }


                int
                f_111_65217_65316(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    this_param.ExecuteCommandAsyncHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 65217, 65316);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_111_65399_65493(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    var return_v = this_param.ExecuteCommandHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 65399, 65493);
                    return return_v;
                }


                int
                f_111_65667_65699(Microsoft.PowerShell.ConsoleHost
                this_param, System.Exception
                e, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.ReportException(e, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 65667, 65699);
                    return 0;
                }


                bool
                f_111_65755_65794(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 65755, 65794);
                    return return_v;
                }


                System.Management.Automation.RemoteRunspace
                f_111_66126_66189(string
                configurationName, Microsoft.PowerShell.ConsoleHost
                host)
                {
                    var return_v = HostUtilities.CreateConfiguredRunspace(configurationName, (System.Management.Automation.Host.PSHost)host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 66126, 66189);
                    return return_v;
                }


                int
                f_111_66273_66301(Microsoft.PowerShell.ConsoleHost
                this_param, System.Management.Automation.RemoteRunspace
                newRunspace)
                {
                    this_param.PushRunspace((System.Management.Automation.Runspaces.Runspace)newRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 66273, 66301);
                    return 0;
                }


                string
                f_111_66587_66626()
                {
                    var return_v = ConsoleHostStrings.ShellCannotBeStarted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 66587, 66626);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleHost.ConsoleHostStartupException
                f_111_66555_66630(string
                message, System.Exception
                innerException)
                {
                    var return_v = new Microsoft.PowerShell.ConsoleHost.ConsoleHostStartupException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 66555, 66630);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_67051_67072(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 67051, 67072);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_111_67051_67089(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 67051, 67089);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_111_67011_67090(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Utils.EnforceSystemLockDownLanguageMode(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 67011, 67090);
                    return return_v;
                }


                string
                f_111_67136_67185(string
                shellId, bool
                forCurrentUser)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 67136, 67185);
                    return return_v;
                }


                string
                f_111_67241_67293(string
                shellId, bool
                forCurrentUser)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 67241, 67293);
                    return return_v;
                }


                string
                f_111_67340_67388(string
                shellId, bool
                forCurrentUser)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 67340, 67388);
                    return return_v;
                }


                string
                f_111_67447_67498(string
                shellId, bool
                forCurrentUser)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 67447, 67498);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_67714_67735(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 67714, 67735);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateProxy
                f_111_67714_67753(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.SessionStateProxy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 67714, 67753);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_111_67798_68027(string
                allUsersAllHosts, string
                allUsersCurrentHost, string
                currentUserAllHosts, string
                currentUserCurrentHost)
                {
                    var return_v = HostUtilities.GetDollarProfile(allUsersAllHosts, allUsersCurrentHost, currentUserAllHosts, currentUserCurrentHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 67798, 68027);
                    return return_v;
                }


                int
                f_111_67714_68028(System.Management.Automation.Runspaces.SessionStateProxy
                this_param, string
                name, System.Management.Automation.PSObject
                value)
                {
                    this_param.SetVariable(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 67714, 68028);
                    return 0;
                }


                System.Diagnostics.Stopwatch
                f_111_68508_68523()
                {
                    var return_v = new System.Diagnostics.Stopwatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 68508, 68523);
                    return return_v;
                }


                int
                f_111_68546_68556(System.Diagnostics.Stopwatch
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 68546, 68556);
                    return 0;
                }


                int
                f_111_68579_68612(Microsoft.PowerShell.ConsoleHost
                this_param, string
                profileFileName, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.RunProfile(profileFileName, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 68579, 68612);
                    return 0;
                }


                int
                f_111_68635_68680(Microsoft.PowerShell.ConsoleHost
                this_param, string
                profileFileName, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.RunProfile(profileFileName, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 68635, 68680);
                    return 0;
                }


                int
                f_111_68703_68739(Microsoft.PowerShell.ConsoleHost
                this_param, string
                profileFileName, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.RunProfile(profileFileName, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 68703, 68739);
                    return 0;
                }


                int
                f_111_68762_68810(Microsoft.PowerShell.ConsoleHost
                this_param, string
                profileFileName, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.RunProfile(profileFileName, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 68762, 68810);
                    return 0;
                }


                int
                f_111_68833_68842(System.Diagnostics.Stopwatch
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 68833, 68842);
                    return 0;
                }


                long
                f_111_68893_68915(System.Diagnostics.Stopwatch
                this_param)
                {
                    var return_v = this_param.ElapsedMilliseconds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 68893, 68915);
                    return return_v;
                }


                bool
                f_111_68971_68987(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.ShowBanner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 68971, 68987);
                    return return_v;
                }


                System.IO.TextWriter
                f_111_69037_69050()
                {
                    var return_v = Console.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 69037, 69050);
                    return return_v;
                }


                string
                f_111_69061_69105()
                {
                    var return_v = ConsoleHostStrings.SlowProfileLoadingMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 69061, 69105);
                    return return_v;
                }


                int
                f_111_69037_69127(System.IO.TextWriter
                this_param, string
                format, long
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 69037, 69127);
                    return 0;
                }


                int
                f_111_69300_69368(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 69300, 69368);
                    return 0;
                }


                string
                f_111_69762_69772(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 69762, 69772);
                    return return_v;
                }


                string
                f_111_69832_69842(Microsoft.PowerShell.CommandLineParameterParser
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 69832, 69842);
                    return return_v;
                }


                int
                f_111_69863_69914(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 69863, 69914);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_111_69959_69980(Microsoft.PowerShell.Executor
                this_param)
                {
                    var return_v = this_param.CreatePipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 69959, 69980);
                    return return_v;
                }


                string?
                f_111_70183_70210(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70183, 70210);
                    return return_v;
                }


                bool
                f_111_70183_70261(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70183, 70261);
                    return return_v;
                }


                string
                f_111_70319_70345(string
                path)
                {
                    var return_v = File.ReadAllText(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70319, 70345);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_111_70372_70429(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript: isScript, useLocalScope: useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70372, 70429);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_111_70516_70551(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70516, 70551);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_111_70591_70612(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 70591, 70612);
                    return return_v;
                }


                int
                f_111_70591_70619(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70591, 70619);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_111_70873_70885(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 70873, 70885);
                    return return_v;
                }


                int
                f_111_70873_70892(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70873, 70892);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                f_111_70805_70823_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 70805, 70823);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_71135_71148(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 71135, 71148);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_71209_71222(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 71209, 71222);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_111_71209_71239(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 71209, 71239);
                    return return_v;
                }


                bool
                f_111_71363_71377()
                {
                    var return_v = IsRunningAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 71363, 71377);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_111_71702_71752(string
                fileName, out System.Management.Automation.Language.Token[]
                tokens, out System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = Parser.ParseFile(fileName, out tokens, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 71702, 71752);
                    return return_v;
                }


                bool
                f_111_71779_71822(System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = AstSearcher.IsUsingDollarInput(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 71779, 71822);
                    return return_v;
                }


                int
                f_111_72161_72231(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    this_param.ExecuteCommandAsyncHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 72161, 72231);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_111_72314_72401(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    var return_v = this_param.ExecuteCommandHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 72314, 72401);
                    return return_v;
                }


                int
                f_111_73088_73113(Microsoft.PowerShell.ConsoleHost
                this_param, System.Exception
                e, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.ReportException(e, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 73088, 73113);
                    return 0;
                }


                bool
                f_111_73172_73208(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 73172, 73208);
                    return return_v;
                }


                int
                f_111_73307_73352(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 73307, 73352);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_111_73397_73438(Microsoft.PowerShell.Executor
                this_param, string
                command, bool
                addToHistory)
                {
                    var return_v = this_param.CreatePipeline(command, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 73397, 73438);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_111_73692_73713(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 73692, 73713);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_111_73692_73716(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 73692, 73716);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_111_73692_73727(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 73692, 73727);
                    return return_v;
                }


                int
                f_111_73692_73734(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 73692, 73734);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                f_111_73624_73642_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.CommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 73624, 73642);
                    return return_v;
                }


                bool
                f_111_73834_73848()
                {
                    var return_v = IsRunningAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 73834, 73848);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_111_74173_74230(string
                input, out System.Management.Automation.Language.Token[]
                tokens, out System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = Parser.ParseInput(input, out tokens, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 74173, 74230);
                    return return_v;
                }


                bool
                f_111_74257_74300(System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = AstSearcher.IsUsingDollarInput(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 74257, 74300);
                    return return_v;
                }


                int
                f_111_74639_74709(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    this_param.ExecuteCommandAsyncHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 74639, 74709);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_111_74792_74879(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    var return_v = this_param.ExecuteCommandHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 74792, 74879);
                    return return_v;
                }


                int
                f_111_75087_75112(Microsoft.PowerShell.ConsoleHost
                this_param, System.Exception
                e, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.ReportException(e, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 75087, 75112);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 64180, 75158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 64180, 75158);
            }
        }

        private void RunProfile(string profileFileName, Executor exec)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 75170, 76220);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 75257, 76209) || true) && (!f_111_75262_75299(profileFileName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 75257, 76209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 75333, 75402);

                    f_111_75333_75401(s_runspaceInitTracer, "checking profile" + profileFileName);

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 75466, 75936) || true) && (f_111_75470_75498(profileFileName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 75466, 75936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 75548, 75758);

                            f_111_75548_75757(this, ". '" + f_111_75611_75646(profileFileName) + "'", exec, Executor.ExecutionOptions.AddOutputter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 75466, 75936);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 75466, 75936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 75856, 75913);

                            f_111_75856_75912(s_runspaceInitTracer, "profile file not found");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 75466, 75936);
                        }
                    }
                    catch (Exception e) // Catch-all OK, 3rd party callout
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 75973, 76194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76068, 76093);

                        f_111_76068_76092(this, e, exec);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76117, 76175);

                        f_111_76117_76174(
                                            s_runspaceInitTracer, "Could not load profile.");
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 75973, 76194);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 75257, 76209);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 75170, 76220);

                bool
                f_111_75262_75299(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 75262, 75299);
                    return return_v;
                }


                int
                f_111_75333_75401(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 75333, 75401);
                    return 0;
                }


                bool
                f_111_75470_75498(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 75470, 75498);
                    return return_v;
                }


                string
                f_111_75611_75646(string
                str)
                {
                    var return_v = EscapeSingleQuotes(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 75611, 75646);
                    return return_v;
                }


                System.Exception
                f_111_75548_75757(Microsoft.PowerShell.ConsoleHost
                this_param, string
                command, Microsoft.PowerShell.Executor
                exec, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    var return_v = this_param.InitializeRunspaceHelper(command, exec, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 75548, 75757);
                    return return_v;
                }


                int
                f_111_75856_75912(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 75856, 75912);
                    return 0;
                }


                int
                f_111_76068_76092(Microsoft.PowerShell.ConsoleHost
                this_param, System.Exception
                e, Microsoft.PowerShell.Executor
                exec)
                {
                    this_param.ReportException(e, exec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 76068, 76092);
                    return 0;
                }


                int
                f_111_76117_76174(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 76117, 76174);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 75170, 76220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 75170, 76220);
            }
        }

        internal static string EscapeSingleQuotes(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 76441, 77021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76627, 76680);

                StringBuilder
                sb = f_111_76646_76679(f_111_76664_76674(str) * 2)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76705, 76710);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76696, 76934) || true) && (i < f_111_76716_76726(str))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76728, 76731)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(111, 76696, 76934))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 76696, 76934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76765, 76781);

                        char
                        c = f_111_76774_76780(str, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76799, 76886) || true) && (c == '\'')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 76799, 76886);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76854, 76867);

                            f_111_76854_76866(sb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 76799, 76886);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76906, 76919);

                        f_111_76906_76918(
                                        sb, c);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 1, 239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(111, 1, 239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76950, 76980);

                string
                result = f_111_76966_76979(sb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 76996, 77010);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 76441, 77021);

                int
                f_111_76664_76674(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 76664, 76674);
                    return return_v;
                }


                System.Text.StringBuilder
                f_111_76646_76679(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 76646, 76679);
                    return return_v;
                }


                int
                f_111_76716_76726(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 76716, 76726);
                    return return_v;
                }


                char
                f_111_76774_76780(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 76774, 76780);
                    return return_v;
                }


                System.Text.StringBuilder
                f_111_76854_76866(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 76854, 76866);
                    return return_v;
                }


                System.Text.StringBuilder
                f_111_76906_76918(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 76906, 76918);
                    return return_v;
                }


                string
                f_111_76966_76979(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 76966, 76979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 76441, 77021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 76441, 77021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteErrorLine(string line)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 77033, 77244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 77098, 77133);

                ConsoleColor
                fg = ConsoleColor.Red
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 77147, 77190);

                ConsoleColor
                bg = f_111_77165_77189(f_111_77165_77173(f_111_77165_77167()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 77206, 77233);

                f_111_77206_77232(f_111_77206_77208(), fg, bg, line);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 77033, 77244);

                System.Management.Automation.Host.PSHostUserInterface
                f_111_77165_77167()
                {
                    var return_v = UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 77165, 77167);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_111_77165_77173(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 77165, 77173);
                    return return_v;
                }


                System.ConsoleColor
                f_111_77165_77189(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.BackgroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 77165, 77189);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_111_77206_77208()
                {
                    var return_v = UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 77206, 77208);
                    return return_v;
                }


                int
                f_111_77206_77232(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.WriteLine(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 77206, 77232);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 77033, 77244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 77033, 77244);
            }
        }

        private void ReportException(Exception e, Executor exec)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 77384, 79160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 77465, 77515);

                f_111_77465_77514(e != null, "must supply an Exception");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 77529, 77581);

                f_111_77529_77580(exec != null, "must supply an Executor");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 77897, 77917);

                object
                error = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 77931, 77977);

                Pipeline
                tempPipeline = f_111_77955_77976(exec)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78060, 78114);

                IContainsErrorRecord
                icer = e as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78130, 78386) || true) && (icer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 78130, 78386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78180, 78205);

                    error = f_111_78188_78204(icer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 78130, 78386);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 78130, 78386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78271, 78371);

                    error = (object)f_111_78287_78370(e, "ConsoleHost.ReportException", ErrorCategory.NotSpecified, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 78130, 78386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78402, 78529);

                PSObject
                wrappedError = new PSObject(error)
                {
                    WriteStream = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => WriteStreamType.Error, 111, 78426, 78528)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78545, 78565);

                Exception
                e1 = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78581, 78620);

                f_111_78581_78619(f_111_78581_78599(tempPipeline), wrappedError);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78634, 78948) || true) && (f_111_78638_78652())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 78634, 78948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78686, 78779);

                    f_111_78686_78778(exec, tempPipeline, out e1, Executor.ExecutionOptions.AddOutputter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 78634, 78948);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 78634, 78948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78845, 78933);

                    f_111_78845_78932(exec, tempPipeline, out e1, Executor.ExecutionOptions.AddOutputter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 78634, 78948);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 78964, 79149) || true) && (e1 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 78964, 79149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 79101, 79134);

                    f_111_79101_79133(this, e, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 78964, 79149);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 77384, 79160);

                int
                f_111_77465_77514(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 77465, 77514);
                    return 0;
                }


                int
                f_111_77529_77580(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 77529, 77580);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_111_77955_77976(Microsoft.PowerShell.Executor
                this_param)
                {
                    var return_v = this_param.CreatePipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 77955, 77976);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_111_78188_78204(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 78188, 78204);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_111_78287_78370(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 78287, 78370);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_111_78581_78599(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 78581, 78599);
                    return return_v;
                }


                int
                f_111_78581_78619(System.Management.Automation.Runspaces.PipelineWriter
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    var return_v = this_param.Write((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 78581, 78619);
                    return return_v;
                }


                bool
                f_111_78638_78652()
                {
                    var return_v = IsRunningAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 78638, 78652);
                    return return_v;
                }


                int
                f_111_78686_78778(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    this_param.ExecuteCommandAsyncHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 78686, 78778);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_111_78845_78932(Microsoft.PowerShell.Executor
                this_param, System.Management.Automation.Runspaces.Pipeline
                tempPipeline, out System.Exception
                exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                options)
                {
                    var return_v = this_param.ExecuteCommandHelper(tempPipeline, out exceptionThrown, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 78845, 78932);
                    return return_v;
                }


                int
                f_111_79101_79133(Microsoft.PowerShell.ConsoleHost
                this_param, System.Exception
                e, string
                header)
                {
                    this_param.ReportExceptionFallback(e, header);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 79101, 79133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 77384, 79160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 77384, 79160);
            }
        }

        private void ReportExceptionFallback(Exception e, string header)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 79528, 80746);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 79617, 79731) || true) && (!f_111_79622_79650(header))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 79617, 79731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 79684, 79716);

                    f_111_79684_79715(f_111_79684_79697(), header);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 79617, 79731);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 79747, 79816) || true) && (e == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 79747, 79816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 79794, 79801);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 79747, 79816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 79907, 79929);

                ErrorRecord
                er = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 79943, 79997);

                IContainsErrorRecord
                icer = e as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80011, 80068) || true) && (icer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 80011, 80068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80046, 80068);

                    er = f_111_80051_80067(icer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 80011, 80068);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80084, 80524) || true) && (e is PSRemotingTransportException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 80084, 80524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80227, 80256);

                    f_111_80227_80255(f_111_80227_80229(), f_111_80245_80254(e));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 80084, 80524);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 80084, 80524);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80290, 80524) || true) && (e is TargetInvocationException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 80290, 80524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80358, 80408);

                        f_111_80358_80407(f_111_80358_80371(), f_111_80382_80406(f_111_80382_80398(e)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 80290, 80524);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 80290, 80524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80474, 80509);

                        f_111_80474_80508(f_111_80474_80487(), f_111_80498_80507(e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 80290, 80524);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 80084, 80524);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80614, 80735) || true) && (er != null && (DynAbs.Tracing.TraceSender.Expression_True(111, 80618, 80657) && f_111_80632_80649(er) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 80614, 80735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 80676, 80735);

                    f_111_80676_80734(f_111_80676_80689(), f_111_80700_80733(f_111_80700_80717(er)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 80614, 80735);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 79528, 80746);

                bool
                f_111_79622_79650(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 79622, 79650);
                    return return_v;
                }


                System.IO.TextWriter
                f_111_79684_79697()
                {
                    var return_v = Console.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 79684, 79697);
                    return return_v;
                }


                int
                f_111_79684_79715(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 79684, 79715);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_111_80051_80067(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80051, 80067);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_111_80227_80229()
                {
                    var return_v = UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80227, 80229);
                    return return_v;
                }


                string
                f_111_80245_80254(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80245, 80254);
                    return return_v;
                }


                int
                f_111_80227_80255(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 80227, 80255);
                    return 0;
                }


                System.IO.TextWriter
                f_111_80358_80371()
                {
                    var return_v = Console.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80358, 80371);
                    return return_v;
                }


                System.Exception
                f_111_80382_80398(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80382, 80398);
                    return return_v;
                }


                string
                f_111_80382_80406(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80382, 80406);
                    return return_v;
                }


                int
                f_111_80358_80407(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 80358, 80407);
                    return 0;
                }


                System.IO.TextWriter
                f_111_80474_80487()
                {
                    var return_v = Console.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80474, 80487);
                    return return_v;
                }


                string
                f_111_80498_80507(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80498, 80507);
                    return return_v;
                }


                int
                f_111_80474_80508(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 80474, 80508);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_111_80632_80649(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80632, 80649);
                    return return_v;
                }


                System.IO.TextWriter
                f_111_80676_80689()
                {
                    var return_v = Console.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80676, 80689);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_111_80700_80717(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80700, 80717);
                    return return_v;
                }


                string
                f_111_80700_80733(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PositionMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 80700, 80733);
                    return return_v;
                }


                int
                f_111_80676_80734(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 80676, 80734);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 79528, 80746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 79528, 80746);
            }
        }

        /// <summary>
        /// Raised when the host pops a runspace.
        /// </summary>
        internal event EventHandler
RunspacePopped
;

        /// <summary>
        /// Raised when the host pushes a runspace.
        /// </summary>
        internal event EventHandler
RunspacePushed
;

        private void OnExecutionSuspended(object sender, DebuggerStopEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 81219, 83815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81399, 81443);

                LocalRunspace
                localrunspace = f_111_81429_81442()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81457, 81568) || true) && ((localrunspace != null) && (DynAbs.Tracing.TraceSender.Expression_True(111, 81461, 81555) && f_111_81488_81555_M(!f_111_81489_81539(f_111_81489_81519(localrunspace)).DebuggerEnabled)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 81457, 81568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81559, 81566);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 81457, 81568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81584, 81611);

                _debuggerStopEventArgs = e;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81625, 81651);

                InputLoop
                baseLoop = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81703, 82105) || true) && (f_111_81707_81728(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 81703, 82105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81901, 81941);

                        baseLoop = f_111_81912_81940();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 81963, 82086) || true) && (baseLoop != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 81963, 82086);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82033, 82063);

                            f_111_82033_82062(baseLoop);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 81963, 82086);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 81703, 82105);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82226, 82481) || true) && (_displayDebuggerBanner)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 82226, 82481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82294, 82352);

                        f_111_82294_82351(this, f_111_82315_82350());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82374, 82409);

                        f_111_82374_82408(this, string.Empty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82431, 82462);

                        _displayDebuggerBanner = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 82226, 82481);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82600, 83024) || true) && (f_111_82604_82623(f_111_82604_82617(e)) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 82600, 83024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82669, 82718);

                        string
                        format = f_111_82685_82717()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82742, 82946);
                            foreach (Breakpoint breakpoint in f_111_82776_82789_I(f_111_82776_82789(e)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 82742, 82946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82839, 82923);

                                f_111_82839_82922(this, f_111_82860_82921(f_111_82874_82900(), format, breakpoint));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 82742, 82946);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 1, 205);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(111, 1, 205);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 82970, 83005);

                        f_111_82970_83004(this, string.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 82600, 83024);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 83126, 83442) || true) && (f_111_83130_83146(e) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 83126, 83442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 83368, 83423);

                        f_111_83368_83422(this, f_111_83389_83421(f_111_83389_83405(e)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 83126, 83442);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 83543, 83560);

                    f_111_83543_83559(this);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(111, 83589, 83804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 83629, 83659);

                    _debuggerStopEventArgs = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 83677, 83789) || true) && (baseLoop != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 83677, 83789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 83739, 83770);

                        f_111_83739_83769(baseLoop);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 83677, 83789);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(111, 83589, 83804);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 81219, 83815);

                System.Management.Automation.Runspaces.LocalRunspace
                f_111_81429_81442()
                {
                    var return_v = LocalRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 81429, 81442);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_111_81489_81519(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 81489, 81519);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_111_81489_81539(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 81489, 81539);
                    return return_v;
                }


                bool
                f_111_81488_81555_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 81488, 81555);
                    return return_v;
                }


                bool
                f_111_81707_81728(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.IsRunspacePushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 81707, 81728);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleHost.InputLoop
                f_111_81912_81940()
                {
                    var return_v = InputLoop.GetNonNestedLoop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 81912, 81940);
                    return return_v;
                }


                int
                f_111_82033_82062(Microsoft.PowerShell.ConsoleHost.InputLoop
                this_param)
                {
                    this_param.BlockCommandOutput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 82033, 82062);
                    return 0;
                }


                string
                f_111_82315_82350()
                {
                    var return_v = ConsoleHostStrings.EnteringDebugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 82315, 82350);
                    return return_v;
                }


                int
                f_111_82294_82351(Microsoft.PowerShell.ConsoleHost
                this_param, string
                line)
                {
                    this_param.WriteDebuggerMessage(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 82294, 82351);
                    return 0;
                }


                int
                f_111_82374_82408(Microsoft.PowerShell.ConsoleHost
                this_param, string
                line)
                {
                    this_param.WriteDebuggerMessage(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 82374, 82408);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Breakpoint>
                f_111_82604_82617(System.Management.Automation.DebuggerStopEventArgs
                this_param)
                {
                    var return_v = this_param.Breakpoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 82604, 82617);
                    return return_v;
                }


                int
                f_111_82604_82623(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Breakpoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 82604, 82623);
                    return return_v;
                }


                string
                f_111_82685_82717()
                {
                    var return_v = ConsoleHostStrings.HitBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 82685, 82717);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Breakpoint>
                f_111_82776_82789(System.Management.Automation.DebuggerStopEventArgs
                this_param)
                {
                    var return_v = this_param.Breakpoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 82776, 82789);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_111_82874_82900()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 82874, 82900);
                    return return_v;
                }


                string
                f_111_82860_82921(System.Globalization.CultureInfo
                provider, string
                format, System.Management.Automation.Breakpoint
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 82860, 82921);
                    return return_v;
                }


                int
                f_111_82839_82922(Microsoft.PowerShell.ConsoleHost
                this_param, string
                line)
                {
                    this_param.WriteDebuggerMessage(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 82839, 82922);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Breakpoint>
                f_111_82776_82789_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Breakpoint>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 82776, 82789);
                    return return_v;
                }


                int
                f_111_82970_83004(Microsoft.PowerShell.ConsoleHost
                this_param, string
                line)
                {
                    this_param.WriteDebuggerMessage(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 82970, 83004);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_111_83130_83146(System.Management.Automation.DebuggerStopEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 83130, 83146);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_111_83389_83405(System.Management.Automation.DebuggerStopEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 83389, 83405);
                    return return_v;
                }


                string
                f_111_83389_83421(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PositionMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 83389, 83421);
                    return return_v;
                }


                int
                f_111_83368_83422(Microsoft.PowerShell.ConsoleHost
                this_param, string
                line)
                {
                    this_param.WriteDebuggerMessage(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 83368, 83422);
                    return 0;
                }


                int
                f_111_83543_83559(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    this_param.EnterDebugMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 83543, 83559);
                    return 0;
                }


                int
                f_111_83739_83769(Microsoft.PowerShell.ConsoleHost.InputLoop
                this_param)
                {
                    this_param.ResumeCommandOutput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 83739, 83769);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 81219, 83815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 81219, 83815);
            }
        }

        private bool InDebugMode { get; set; }

        internal bool DebuggerCanStopCommand
        {
            get;
            set;
        }

        private Exception _lastRunspaceInitializationException;

        internal uint ExitCode;

        private void EnterDebugMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 84445, 85228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 84499, 84518);

                InDebugMode = true;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 84789, 84863);

                    Runspace
                    runspace = f_111_84809_84833(_runspaceRef) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.Runspace>(111, 84809, 84862) ?? f_111_84837_84862(f_111_84837_84853(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 84881, 84947);

                    f_111_84881_84946(f_111_84881_84926(f_111_84881_84906(runspace)));
                }
                catch (PSNotImplementedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 84976, 85128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 85042, 85113);

                    f_111_85042_85112(this, f_111_85063_85111());
                    DynAbs.Tracing.TraceSender.TraceExitCatch(111, 84976, 85128);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(111, 85142, 85217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 85182, 85202);

                    InDebugMode = false;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(111, 85142, 85217);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 84445, 85228);

                System.Management.Automation.Runspaces.Runspace
                f_111_84809_84833(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.OldRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 84809, 84833);
                    return return_v;
                }


                System.Management.Automation.Remoting.RunspaceRef
                f_111_84837_84853(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.RunspaceRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 84837, 84853);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_84837_84862(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 84837, 84862);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_111_84881_84906(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 84881, 84906);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_111_84881_84926(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 84881, 84926);
                    return return_v;
                }


                int
                f_111_84881_84946(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.EnterNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 84881, 84946);
                    return 0;
                }


                string
                f_111_85063_85111()
                {
                    var return_v = ConsoleHostStrings.SessionDoesNotSupportDebugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 85063, 85111);
                    return return_v;
                }


                int
                f_111_85042_85112(Microsoft.PowerShell.ConsoleHost
                this_param, string
                line)
                {
                    this_param.WriteDebuggerMessage(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 85042, 85112);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 84445, 85228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 84445, 85228);
            }
        }

        private void ExitDebugMode(DebuggerResumeAction resumeAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 85336, 86043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 85422, 85473);

                _debuggerStopEventArgs.ResumeAction = resumeAction;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 85742, 85816);

                    Runspace
                    runspace = f_111_85762_85786(_runspaceRef) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.Runspace>(111, 85762, 85815) ?? f_111_85790_85815(f_111_85790_85806(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 85834, 85899);

                    f_111_85834_85898(f_111_85834_85879(f_111_85834_85859(runspace)));
                }
                catch (ExitNestedPromptException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 85928, 86032);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(111, 85928, 86032);
                    // ignore the exception
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 85336, 86043);

                System.Management.Automation.Runspaces.Runspace
                f_111_85762_85786(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.OldRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 85762, 85786);
                    return return_v;
                }


                System.Management.Automation.Remoting.RunspaceRef
                f_111_85790_85806(Microsoft.PowerShell.ConsoleHost
                this_param)
                {
                    var return_v = this_param.RunspaceRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 85790, 85806);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_111_85790_85815(System.Management.Automation.Remoting.RunspaceRef
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 85790, 85815);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_111_85834_85859(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 85834, 85859);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_111_85834_85879(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 85834, 85879);
                    return return_v;
                }


                int
                f_111_85834_85898(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.ExitNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 85834, 85898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 85336, 86043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 85336, 86043);
            }
        }

        private void WriteDebuggerMessage(string line)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 86156, 86322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 86227, 86311);

                f_111_86227_86310(this.ui, f_111_86245_86273(this.ui), f_111_86275_86303(this.ui), line);
                DynAbs.Tracing.TraceSender.TraceExitMethod(111, 86156, 86322);

                System.ConsoleColor
                f_111_86245_86273(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    var return_v = this_param.DebugForegroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 86245, 86273);
                    return return_v;
                }


                System.ConsoleColor
                f_111_86275_86303(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    var return_v = this_param.DebugBackgroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 86275, 86303);
                    return return_v;
                }


                int
                f_111_86227_86310(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.WriteLine(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 86227, 86310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 86156, 86322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 86156, 86322);
            }
        }
        private class InputLoop
        {
            internal static void RunNewInputLoop(ConsoleHost parent, bool isNested)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 86889, 87787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87083, 87122);

                    int
                    stackCount = f_111_87100_87121(s_instanceStack)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87142, 87347) || true) && (stackCount == PSHost.MaximumNestedPromptLevel)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 87142, 87347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87233, 87328);

                        throw f_111_87239_87327(f_111_87282_87326());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 87142, 87347);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87367, 87414);

                    InputLoop
                    il = f_111_87382_87413(parent, isNested)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87434, 87459);

                    f_111_87434_87458(
                                    s_instanceStack, il);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87477, 87511);

                    f_111_87477_87510(il, f_111_87484_87505(s_instanceStack) > 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87624, 87662);

                    InputLoop
                    il2 = f_111_87640_87661(s_instanceStack)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 87682, 87772);

                    f_111_87682_87771(il == il2, "top of instance stack does not correspond to the instance pushed");
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 86889, 87787);

                    int
                    f_111_87100_87121(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 87100, 87121);
                        return return_v;
                    }


                    string
                    f_111_87282_87326()
                    {
                        var return_v = ConsoleHostStrings.TooManyNestedPromptsError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 87282, 87326);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_111_87239_87327(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 87239, 87327);
                        return return_v;
                    }


                    Microsoft.PowerShell.ConsoleHost.InputLoop
                    f_111_87382_87413(Microsoft.PowerShell.ConsoleHost
                    parent, bool
                    isNested)
                    {
                        var return_v = new Microsoft.PowerShell.ConsoleHost.InputLoop(parent, isNested);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 87382, 87413);
                        return return_v;
                    }


                    int
                    f_111_87434_87458(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param, Microsoft.PowerShell.ConsoleHost.InputLoop
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 87434, 87458);
                        return 0;
                    }


                    int
                    f_111_87484_87505(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 87484, 87505);
                        return return_v;
                    }


                    int
                    f_111_87477_87510(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param, bool
                    inputLoopIsNested)
                    {
                        this_param.Run(inputLoopIsNested);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 87477, 87510);
                        return 0;
                    }


                    Microsoft.PowerShell.ConsoleHost.InputLoop
                    f_111_87640_87661(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 87640, 87661);
                        return return_v;
                    }


                    int
                    f_111_87682_87771(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 87682, 87771);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 86889, 87787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 86889, 87787);
                }
            }

            internal static bool ExitCurrentLoop()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 88303, 88936);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 88374, 88569) || true) && (f_111_88378_88399(s_instanceStack) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 88374, 88569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 88446, 88550);

                        throw f_111_88452_88549(f_111_88495_88548());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 88374, 88569);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 88589, 88627);

                    InputLoop
                    il = f_111_88604_88626(s_instanceStack)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 88645, 88667);

                    il._shouldExit = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 88886, 88921);

                    return (f_111_88894_88915(s_instanceStack) > 2);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 88303, 88936);

                    int
                    f_111_88378_88399(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 88378, 88399);
                        return return_v;
                    }


                    string
                    f_111_88495_88548()
                    {
                        var return_v = ConsoleHostStrings.InputExitCurrentLoopOutOfSyncError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 88495, 88548);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_111_88452_88549(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 88452, 88549);
                        return return_v;
                    }


                    Microsoft.PowerShell.ConsoleHost.InputLoop
                    f_111_88604_88626(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Peek();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 88604, 88626);
                        return return_v;
                    }


                    int
                    f_111_88894_88915(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 88894, 88915);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 88303, 88936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 88303, 88936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static InputLoop GetNonNestedLoop()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(111, 89334, 89579);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89411, 89532) || true) && (f_111_89415_89436(s_instanceStack) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 89411, 89532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89483, 89513);

                        return f_111_89490_89512(s_instanceStack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 89411, 89532);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89552, 89564);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(111, 89334, 89579);

                    int
                    f_111_89415_89436(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 89415, 89436);
                        return return_v;
                    }


                    Microsoft.PowerShell.ConsoleHost.InputLoop
                    f_111_89490_89512(System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
                    this_param)
                    {
                        var return_v = this_param.Peek();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 89490, 89512);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 89334, 89579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 89334, 89579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private InputLoop(ConsoleHost parent, bool isNested)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 89595, 90110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109205, 109212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109240, 109249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109277, 109288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109320, 109325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109357, 109368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109398, 109424);
                    this._syncObject = f_111_109412_109424();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109452, 109477);
                    this._isRunspacePushed = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109505, 109528);
                    this._runspacePopped = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89680, 89697);

                    _parent = parent;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89715, 89736);

                    _isNested = isNested;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89754, 89798);

                    _isRunspacePushed = f_111_89774_89797(parent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89816, 89880);

                    parent.RunspacePopped += new EventHandler(HandleRunspacePopped);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89898, 89962);

                    parent.RunspacePushed += new EventHandler(HandleRunspacePushed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 89980, 90026);

                    _exec = f_111_89988_90025(parent, isNested, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 90044, 90095);

                    _promptExec = f_111_90058_90094(parent, isNested, true);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 89595, 90110);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 89595, 90110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 89595, 90110);
                }
            }

            private void HandleRunspacePushed(object sender, EventArgs e)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 90126, 90384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 90226, 90237);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 90279, 90304);

                        _isRunspacePushed = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 90326, 90350);

                        _runspacePopped = false;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 90126, 90384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 90126, 90384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 90126, 90384);
                }
            }

            private void HandleRunspacePopped(object sender, EventArgs eventArgs)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 90716, 90982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 90824, 90835);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 90877, 90903);

                        _isRunspacePushed = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 90925, 90948);

                        _runspacePopped = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 90716, 90982);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 90716, 90982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 90716, 90982);
                }
            }

            internal void Run(bool inputLoopIsNested)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 91381, 101088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 91455, 91524);

                    System.Management.Automation.Host.PSHostUserInterface
                    c = f_111_91513_91523(_parent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 91542, 91602);

                    ConsoleHostUserInterface
                    ui = c as ConsoleHostUserInterface
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 91622, 91683);

                    f_111_91622_91682(ui != null, "Host.UI should return an instance.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 91703, 91728);

                    bool
                    inBlockMode = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 91746, 91784);

                    bool
                    previousResponseWasEmpty = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 91802, 91849);

                    StringBuilder
                    inputBlock = f_111_91829_91848()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 91869, 101073) || true) && (f_111_91876_91901_M(!_parent.ShouldEndSession) && (DynAbs.Tracing.TraceSender.Expression_True(111, 91876, 91917) && !_shouldExit))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 91869, 101073);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92011, 92047);

                                _parent._isRunningPromptLoop = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92075, 92096);

                                string
                                prompt = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92122, 92141);

                                string
                                line = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92169, 93646) || true) && (f_111_92173_92185_M(!ui.NoPrompt))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 92169, 93646);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92243, 93570) || true) && (inBlockMode)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 92243, 93570);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92407, 92422);

                                        prompt = ">> ";
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 92243, 93570);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 92243, 93570);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92745, 92833) || true) && 
                                            // LAFHIS
                                            (f_111_92749_92772(f_111_92749_92757(ui)).X != 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 92745, 92833);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92818, 92833);

                                            f_111_92818_92832(ui);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 92745, 92833);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 92930, 93092) || true) && (!previousResponseWasEmpty)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 92930, 93092);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93033, 93057);

                                            f_111_93033_93056(this, ui);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 92930, 93092);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93187, 93350) || true) && (f_111_93191_93210(_parent))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 93187, 93350);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93284, 93315);

                                            prompt = f_111_93293_93314(this);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 93187, 93350);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93386, 93539) || true) && (prompt == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 93386, 93539);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93478, 93504);

                                            prompt = f_111_93487_93503(this);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 93386, 93539);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 92243, 93570);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93602, 93619);

                                    f_111_93602_93618(
                                                                ui, prompt);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 92169, 93646);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93674, 93707);

                                previousResponseWasEmpty = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 93844, 93887);

                                line = f_111_93851_93886(ui, _exec);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94008, 95015) || true) && (line == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 94008, 95015);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94082, 94114);

                                    previousResponseWasEmpty = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94146, 94181);

                                    f_111_94146_94180(
                                                                s_tracer, "line is null");

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94211, 94580) || true) && (f_111_94215_94232_M(!ui.ReadFromStdin))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 94211, 94580);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94534, 94549);

                                        f_111_94534_94548(                                // If we're not reading from stdin, the we probably got here
                                                                                          // because the user hit ctrl-C. Do a writeline to clean up
                                                                                          // the output...
                                                                        ui);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 94211, 94580);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94612, 94632);

                                    inBlockMode = false;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94664, 94947) || true) && (f_111_94668_94693())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 94664, 94947);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94844, 94876);

                                        _parent.ShouldEndSession = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(111, 94910, 94916);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 94664, 94947);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 94979, 94988);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 94008, 95015);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95043, 96185) || true) && (f_111_95047_95078(line))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 95043, 96185);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95136, 95730) || true) && (inBlockMode)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 95136, 95730);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95310, 95351);

                                        f_111_95310_95350(                                // end block mode and execute the block accumulated block

                                                                        s_tracer, "exiting block mode");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95385, 95414);

                                        line = f_111_95392_95413(inputBlock);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95448, 95468);

                                        inBlockMode = false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 95136, 95730);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 95136, 95730);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95534, 95730) || true) && (f_111_95538_95558_M(!_parent.InDebugMode))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 95534, 95730);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95624, 95656);

                                            previousResponseWasEmpty = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95690, 95699);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 95534, 95730);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 95136, 95730);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 95043, 96185);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 95043, 96185);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95844, 96158) || true) && (inBlockMode)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 95844, 96158);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 95925, 95968);

                                        f_111_95925_95967(s_tracer, "adding line to block");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96002, 96026);

                                        f_111_96002_96025(inputBlock, "\n");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96060, 96084);

                                        f_111_96060_96083(inputBlock, line);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96118, 96127);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 95844, 96158);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 95043, 96185);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96213, 96265);

                                f_111_96213_96264(line != null, "line should not be null");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96291, 96403);

                                f_111_96291_96402(f_111_96302_96313(line) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(111, 96302, 96340) || f_111_96321_96340(_parent)), "line should not be empty unless the host is in debug mode");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96429, 96516);

                                f_111_96429_96515(!inBlockMode, "should not be in block mode at point of pipeline execution");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96544, 96563);

                                Exception
                                e = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96591, 98156) || true) && (f_111_96595_96614(_parent))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 96591, 98156);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96672, 96738);

                                    DebuggerCommandResults
                                    results = f_111_96705_96737(this, line, out e)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96770, 96949) || true) && (f_111_96774_96794(results) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 96770, 96949);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96868, 96918);

                                        f_111_96868_96917(_parent, f_111_96890_96916(f_111_96890_96910(results)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 96770, 96949);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 96981, 98088) || true) && (e != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 96981, 98088);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 97060, 97102);

                                        var
                                        ex = e as PSInvalidOperationException
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 97136, 98057) || true) && (e is PSRemotingTransportException || (DynAbs.Tracing.TraceSender.Expression_False(111, 97140, 97234) || e is RemoteException) || (DynAbs.Tracing.TraceSender.Expression_False(111, 97140, 97515) || (ex != null && (DynAbs.Tracing.TraceSender.Expression_True(111, 97276, 97350) && f_111_97328_97342(ex) != null) && (DynAbs.Tracing.TraceSender.Expression_True(111, 97276, 97514) && f_111_97392_97514(f_111_97392_97428(f_111_97392_97406(ex)), "Debugger:CannotProcessCommandNotStopped", StringComparison.OrdinalIgnoreCase)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 97136, 98057);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 97676, 97729);

                                            f_111_97676_97728(                                    // Debugger session is broken.  Exit nested loop.
                                                                                _parent, DebuggerResumeAction.Continue);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 97136, 98057);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 97136, 98057);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 97957, 98022);

                                            inBlockMode = f_111_97971_98021(this, e, line, inBlockMode, ref inputBlock);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 97136, 98057);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 96981, 98088);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98120, 98129);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 96591, 98156);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98184, 100741) || true) && (_runspacePopped)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 98184, 100741);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98261, 98337);

                                    string
                                    msg = f_111_98274_98336(f_111_98292_98329(), line)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98367, 98390);

                                    f_111_98367_98389(ui, msg);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98420, 98444);

                                    _runspacePopped = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 98184, 100741);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 98184, 100741);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98558, 99067) || true) && (f_111_98562_98584(_parent) && (DynAbs.Tracing.TraceSender.Expression_True(111, 98562, 98605) && f_111_98588_98605_M(!_parent.IsNested)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 98558, 99067);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98671, 98791);

                                        f_111_98671_98790(_exec, line, out e, Executor.ExecutionOptions.AddOutputter | Executor.ExecutionOptions.AddToHistory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 98558, 99067);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 98558, 99067);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 98921, 99036);

                                        f_111_98921_99035(_exec, line, out e, Executor.ExecutionOptions.AddOutputter | Executor.ExecutionOptions.AddToHistory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 98558, 99067);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99099, 99117);

                                    Thread
                                    bht = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99155, 99177);

                                    lock (_parent.hostGlobalLock)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99243, 99277);

                                        bht = _parent._breakHandlerThread;
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99340, 99463) || true) && (bht != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 99340, 99463);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99421, 99432);

                                        f_111_99421_99431(bht);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 99340, 99463);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99663, 99682);

                                    f_111_99663_99681(
                                                                // Once the pipeline has been executed, we toss any outstanding progress data and
                                                                // take down the display.

                                                                ui);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99714, 100555) || true) && (e != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 99714, 100555);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 99871, 99936);

                                        inBlockMode = f_111_99885_99935(this, e, line, inBlockMode, ref inputBlock);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 100118, 100524) || true) && (_isRunspacePushed && (DynAbs.Tracing.TraceSender.Expression_True(111, 100122, 100169) && (f_111_100144_100160(_parent) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(111, 100122, 100393) && ((f_111_100212_100252(f_111_100212_100246(f_111_100212_100228(_parent))) != RunspaceState.Opened) || (DynAbs.Tracing.TraceSender.Expression_False(111, 100211, 100392) || (f_111_100320_100357(f_111_100320_100336(_parent)) != RunspaceAvailability.Available)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 100118, 100524);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 100467, 100489);

                                            f_111_100467_100488(_parent);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 100118, 100524);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 99714, 100555);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 98184, 100741);
                                }
                            }
                            // NTRAID#Windows Out Of Band Releases-915506-2005/09/09
                            // Removed HandleUnexpectedExceptions infrastructure
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(111, 100938, 101054);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 100994, 101031);

                                _parent._isRunningPromptLoop = false;
                                DynAbs.Tracing.TraceSender.TraceExitFinally(111, 100938, 101054);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 91869, 101073);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 91869, 101073);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(111, 91869, 101073);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 91381, 101088);

                    System.Management.Automation.Host.PSHostUserInterface
                    f_111_91513_91523(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.UI;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 91513, 91523);
                        return return_v;
                    }


                    int
                    f_111_91622_91682(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 91622, 91682);
                        return 0;
                    }


                    System.Text.StringBuilder
                    f_111_91829_91848()
                    {
                        var return_v = new System.Text.StringBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 91829, 91848);
                        return return_v;
                    }


                    bool
                    f_111_91876_91901_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 91876, 91901);
                        return return_v;
                    }


                    bool
                    f_111_92173_92185_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 92173, 92185);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHostRawUserInterface
                    f_111_92749_92757(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param)
                    {
                        var return_v = this_param.RawUI;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 92749, 92757);
                        return return_v;
                    }

                    Coordinates
                    f_111_92749_92772(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param)
                    {
                        var return_v = this_param.CursorPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 92749, 92772);
                        return return_v;
                    }


                    int
                    f_111_92818_92832(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param)
                    {
                        this_param.WriteLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 92818, 92832);
                        return 0;
                    }


                    int
                    f_111_93033_93056(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param, Microsoft.PowerShell.ConsoleHostUserInterface
                    ui)
                    {
                        this_param.EvaluateSuggestions(ui);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 93033, 93056);
                        return 0;
                    }


                    bool
                    f_111_93191_93210(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.InDebugMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 93191, 93210);
                        return return_v;
                    }


                    string
                    f_111_93293_93314(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param)
                    {
                        var return_v = this_param.EvaluateDebugPrompt();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 93293, 93314);
                        return return_v;
                    }


                    string
                    f_111_93487_93503(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param)
                    {
                        var return_v = this_param.EvaluatePrompt();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 93487, 93503);
                        return return_v;
                    }


                    int
                    f_111_93602_93618(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param, string
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 93602, 93618);
                        return 0;
                    }


                    string
                    f_111_93851_93886(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param, Microsoft.PowerShell.Executor
                    exec)
                    {
                        var return_v = this_param.ReadLineWithTabCompletion(exec);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 93851, 93886);
                        return return_v;
                    }


                    int
                    f_111_94146_94180(System.Management.Automation.PSTraceSource
                    this_param, string
                    format)
                    {
                        this_param.WriteLine(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 94146, 94180);
                        return 0;
                    }


                    bool
                    f_111_94215_94232_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 94215, 94232);
                        return return_v;
                    }


                    int
                    f_111_94534_94548(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param)
                    {
                        this_param.WriteLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 94534, 94548);
                        return 0;
                    }


                    bool
                    f_111_94668_94693()
                    {
                        var return_v = Console.IsInputRedirected;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 94668, 94693);
                        return return_v;
                    }


                    bool
                    f_111_95047_95078(string
                    value)
                    {
                        var return_v = string.IsNullOrWhiteSpace(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 95047, 95078);
                        return return_v;
                    }


                    int
                    f_111_95310_95350(System.Management.Automation.PSTraceSource
                    this_param, string
                    format)
                    {
                        this_param.WriteLine(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 95310, 95350);
                        return 0;
                    }


                    string
                    f_111_95392_95413(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 95392, 95413);
                        return return_v;
                    }


                    bool
                    f_111_95538_95558_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 95538, 95558);
                        return return_v;
                    }


                    int
                    f_111_95925_95967(System.Management.Automation.PSTraceSource
                    this_param, string
                    format)
                    {
                        this_param.WriteLine(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 95925, 95967);
                        return 0;
                    }


                    System.Text.StringBuilder
                    f_111_96002_96025(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 96002, 96025);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_111_96060_96083(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 96060, 96083);
                        return return_v;
                    }


                    int
                    f_111_96213_96264(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 96213, 96264);
                        return 0;
                    }


                    int
                    f_111_96302_96313(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 96302, 96313);
                        return return_v;
                    }


                    bool
                    f_111_96321_96340(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.InDebugMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 96321, 96340);
                        return return_v;
                    }


                    int
                    f_111_96291_96402(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 96291, 96402);
                        return 0;
                    }


                    int
                    f_111_96429_96515(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 96429, 96515);
                        return 0;
                    }


                    bool
                    f_111_96595_96614(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.InDebugMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 96595, 96614);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerCommandResults
                    f_111_96705_96737(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param, string
                    cmd, out System.Exception
                    e)
                    {
                        var return_v = this_param.ProcessDebugCommand(cmd, out e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 96705, 96737);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerResumeAction?
                    f_111_96774_96794(System.Management.Automation.DebuggerCommandResults
                    this_param)
                    {
                        var return_v = this_param.ResumeAction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 96774, 96794);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerResumeAction?
                    f_111_96890_96910(System.Management.Automation.DebuggerCommandResults
                    this_param)
                    {
                        var return_v = this_param.ResumeAction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 96890, 96910);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerResumeAction
                    f_111_96890_96916(System.Management.Automation.DebuggerResumeAction?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 96890, 96916);
                        return return_v;
                    }


                    int
                    f_111_96868_96917(Microsoft.PowerShell.ConsoleHost
                    this_param, System.Management.Automation.DebuggerResumeAction
                    resumeAction)
                    {
                        this_param.ExitDebugMode(resumeAction);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 96868, 96917);
                        return 0;
                    }


                    System.Management.Automation.ErrorRecord
                    f_111_97328_97342(System.Management.Automation.PSInvalidOperationException
                    this_param)
                    {
                        var return_v = this_param.ErrorRecord;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 97328, 97342);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_111_97392_97406(System.Management.Automation.PSInvalidOperationException
                    this_param)
                    {
                        var return_v = this_param.ErrorRecord;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 97392, 97406);
                        return return_v;
                    }


                    string
                    f_111_97392_97428(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.FullyQualifiedErrorId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 97392, 97428);
                        return return_v;
                    }


                    bool
                    f_111_97392_97514(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 97392, 97514);
                        return return_v;
                    }


                    int
                    f_111_97676_97728(Microsoft.PowerShell.ConsoleHost
                    this_param, System.Management.Automation.DebuggerResumeAction
                    resumeAction)
                    {
                        this_param.ExitDebugMode(resumeAction);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 97676, 97728);
                        return 0;
                    }


                    bool
                    f_111_97971_98021(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param, System.Exception
                    e, string
                    line, bool
                    inBlockMode, ref System.Text.StringBuilder
                    inputBlock)
                    {
                        var return_v = this_param.HandleErrors(e, line, inBlockMode, ref inputBlock);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 97971, 98021);
                        return return_v;
                    }


                    string
                    f_111_98292_98329()
                    {
                        var return_v = ConsoleHostStrings.CommandNotExecuted;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 98292, 98329);
                        return return_v;
                    }


                    string
                    f_111_98274_98336(string
                    formatSpec, string
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 98274, 98336);
                        return return_v;
                    }


                    int
                    f_111_98367_98389(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param, string
                    value)
                    {
                        this_param.WriteErrorLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 98367, 98389);
                        return 0;
                    }


                    bool
                    f_111_98562_98584(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.IsRunningAsync;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 98562, 98584);
                        return return_v;
                    }


                    bool
                    f_111_98588_98605_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 98588, 98605);
                        return return_v;
                    }


                    int
                    f_111_98671_98790(Microsoft.PowerShell.Executor
                    this_param, string
                    command, out System.Exception
                    exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                    options)
                    {
                        this_param.ExecuteCommandAsync(command, out exceptionThrown, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 98671, 98790);
                        return 0;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    f_111_98921_99035(Microsoft.PowerShell.Executor
                    this_param, string
                    command, out System.Exception
                    exceptionThrown, Microsoft.PowerShell.Executor.ExecutionOptions
                    options)
                    {
                        var return_v = this_param.ExecuteCommand(command, out exceptionThrown, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 98921, 99035);
                        return return_v;
                    }


                    int
                    f_111_99421_99431(System.Threading.Thread
                    this_param)
                    {
                        this_param.Join();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 99421, 99431);
                        return 0;
                    }


                    int
                    f_111_99663_99681(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param)
                    {
                        this_param.ResetProgress();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 99663, 99681);
                        return 0;
                    }


                    bool
                    f_111_99885_99935(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param, System.Exception
                    e, string
                    line, bool
                    inBlockMode, ref System.Text.StringBuilder
                    inputBlock)
                    {
                        var return_v = this_param.HandleErrors(e, line, inBlockMode, ref inputBlock);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 99885, 99935);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_100144_100160(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 100144, 100160);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_100212_100228(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 100212, 100228);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceStateInfo
                    f_111_100212_100246(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.RunspaceStateInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 100212, 100246);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceState
                    f_111_100212_100252(System.Management.Automation.Runspaces.RunspaceStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 100212, 100252);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_100320_100336(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 100320, 100336);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.RunspaceAvailability
                    f_111_100320_100357(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.RunspaceAvailability;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 100320, 100357);
                        return return_v;
                    }


                    int
                    f_111_100467_100488(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        this_param.PopRunspace();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 100467, 100488);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 91381, 101088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 91381, 101088);
                }
            }

            internal void BlockCommandOutput()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 101104, 101555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101171, 101238);

                    RemotePipeline
                    rCmdPipeline = _parent.runningCmd as RemotePipeline
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101256, 101540) || true) && (rCmdPipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 101256, 101540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101322, 101355);

                        f_111_101322_101354(rCmdPipeline);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101377, 101412);

                        f_111_101377_101411(rCmdPipeline);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 101256, 101540);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 101256, 101540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101494, 101521);

                        f_111_101494_101520(_exec);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 101256, 101540);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 101104, 101555);

                    int
                    f_111_101322_101354(System.Management.Automation.RemotePipeline
                    this_param)
                    {
                        this_param.DrainIncomingData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 101322, 101354);
                        return 0;
                    }


                    int
                    f_111_101377_101411(System.Management.Automation.RemotePipeline
                    this_param)
                    {
                        this_param.SuspendIncomingData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 101377, 101411);
                        return 0;
                    }


                    int
                    f_111_101494_101520(Microsoft.PowerShell.Executor
                    this_param)
                    {
                        this_param.BlockCommandOutput();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 101494, 101520);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 101104, 101555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 101104, 101555);
                }
            }

            internal void ResumeCommandOutput()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 101571, 101968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101639, 101706);

                    RemotePipeline
                    rCmdPipeline = _parent.runningCmd as RemotePipeline
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101724, 101953) || true) && (rCmdPipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 101724, 101953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101790, 101824);

                        f_111_101790_101823(rCmdPipeline);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 101724, 101953);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 101724, 101953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 101906, 101934);

                        f_111_101906_101933(_exec);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 101724, 101953);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 101571, 101968);

                    int
                    f_111_101790_101823(System.Management.Automation.RemotePipeline
                    this_param)
                    {
                        this_param.ResumeIncomingData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 101790, 101823);
                        return 0;
                    }


                    int
                    f_111_101906_101933(Microsoft.PowerShell.Executor
                    this_param)
                    {
                        this_param.ResumeCommandOutput();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 101906, 101933);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 101571, 101968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 101571, 101968);
                }
            }

            private bool HandleErrors(Exception e, string line, bool inBlockMode, ref StringBuilder inputBlock)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 101984, 102859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102116, 102181);

                    f_111_102116_102180(e != null, "Exception reference should not be null.");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102201, 102805) || true) && (f_111_102205_102234(this, e))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 102201, 102805);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102276, 102569) || true) && (!inBlockMode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 102276, 102569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102342, 102361);

                            inBlockMode = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102387, 102424);

                            inputBlock = f_111_102400_102423(line);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 102276, 102569);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 102276, 102569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102522, 102546);

                            f_111_102522_102545(inputBlock, line);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 102276, 102569);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 102201, 102805);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 102201, 102805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102752, 102786);

                        f_111_102752_102785(                    // an exception ocurred when the command was executed.  Tell the user about it.
                                            _parent, e, _exec);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 102201, 102805);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102825, 102844);

                    return inBlockMode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 101984, 102859);

                    int
                    f_111_102116_102180(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 102116, 102180);
                        return 0;
                    }


                    bool
                    f_111_102205_102234(Microsoft.PowerShell.ConsoleHost.InputLoop
                    this_param, System.Exception
                    e)
                    {
                        var return_v = this_param.IsIncompleteParseException(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 102205, 102234);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_111_102400_102423(string
                    value)
                    {
                        var return_v = new System.Text.StringBuilder(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 102400, 102423);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_111_102522_102545(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 102522, 102545);
                        return return_v;
                    }


                    int
                    f_111_102752_102785(Microsoft.PowerShell.ConsoleHost
                    this_param, System.Exception
                    e, Microsoft.PowerShell.Executor
                    exec)
                    {
                        this_param.ReportException(e, exec);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 102752, 102785);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 101984, 102859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 101984, 102859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private DebuggerCommandResults ProcessDebugCommand(string cmd, out Exception e)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 102875, 104742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 102987, 103025);

                    DebuggerCommandResults
                    results = null
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 103089, 103127);

                        _parent.DebuggerCanStopCommand = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 103230, 104207);
                        using (System.Management.Automation.PowerShell
                        ps = f_111_103282_103330()
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 103380, 103537);

                            PSInvocationSettings
                            settings = new PSInvocationSettings()
                            {
                                Host = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _parent, 111, 103412, 103536)
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 103565, 103634);

                            PSDataCollection<PSObject>
                            output = f_111_103601_103633()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 103660, 103689);

                            f_111_103660_103688(ps, "Out-Default");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 103715, 103791);

                            IAsyncResult
                            async = f_111_103736_103790(ps, output, settings, null, null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 103901, 104092);

                            results = f_111_103911_104091(f_111_103911_103936(f_111_103911_103927(_parent)), f_111_103982_104053(f_111_104030_104052(cmd, true)), output);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104120, 104138);

                            f_111_104120_104137(
                                                    output);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104164, 104184);

                            f_111_104164_104183(ps, async);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(111, 103230, 104207);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104231, 104240);

                        e = null;
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 104277, 104436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104338, 104345);

                        e = ex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104367, 104417);

                        results = f_111_104377_104416(null, false);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 104277, 104436);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(111, 104454, 104560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104502, 104541);

                        _parent.DebuggerCanStopCommand = false;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(111, 104454, 104560);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104644, 104727);

                    return results ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.DebuggerCommandResults>(111, 104651, 104726) ?? f_111_104662_104726(DebuggerResumeAction.Continue, false));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 102875, 104742);

                    System.Management.Automation.PowerShell
                    f_111_103282_103330()
                    {
                        var return_v = System.Management.Automation.PowerShell.Create();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 103282, 103330);
                        return return_v;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    f_111_103601_103633()
                    {
                        var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 103601, 103633);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_111_103660_103688(System.Management.Automation.PowerShell
                    this_param, string
                    cmdlet)
                    {
                        var return_v = this_param.AddCommand(cmdlet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 103660, 103688);
                        return return_v;
                    }


                    System.IAsyncResult
                    f_111_103736_103790(System.Management.Automation.PowerShell
                    this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    input, System.Management.Automation.PSInvocationSettings
                    settings, System.AsyncCallback
                    callback, object
                    state)
                    {
                        var return_v = this_param.BeginInvoke<System.Management.Automation.PSObject>(input, settings, callback, state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 103736, 103790);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_103911_103927(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 103911, 103927);
                        return return_v;
                    }


                    System.Management.Automation.Debugger
                    f_111_103911_103936(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.Debugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 103911, 103936);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Command
                    f_111_104030_104052(string
                    command, bool
                    isScript)
                    {
                        var return_v = new System.Management.Automation.Runspaces.Command(command, isScript);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 104030, 104052);
                        return return_v;
                    }


                    System.Management.Automation.PSCommand
                    f_111_103982_104053(System.Management.Automation.Runspaces.Command
                    command)
                    {
                        var return_v = new System.Management.Automation.PSCommand(command);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 103982, 104053);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerCommandResults
                    f_111_103911_104091(System.Management.Automation.Debugger
                    this_param, System.Management.Automation.PSCommand
                    command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    output)
                    {
                        var return_v = this_param.ProcessCommand(command, output);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 103911, 104091);
                        return return_v;
                    }


                    int
                    f_111_104120_104137(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    this_param)
                    {
                        this_param.Complete();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 104120, 104137);
                        return 0;
                    }


                    System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    f_111_104164_104183(System.Management.Automation.PowerShell
                    this_param, System.IAsyncResult
                    asyncResult)
                    {
                        var return_v = this_param.EndInvoke(asyncResult);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 104164, 104183);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerCommandResults
                    f_111_104377_104416(System.Management.Automation.DebuggerResumeAction?
                    resumeAction, bool
                    evaluatedByDebugger)
                    {
                        var return_v = new System.Management.Automation.DebuggerCommandResults(resumeAction, evaluatedByDebugger);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 104377, 104416);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerCommandResults
                    f_111_104662_104726(System.Management.Automation.DebuggerResumeAction
                    resumeAction, bool
                    evaluatedByDebugger)
                    {
                        var return_v = new System.Management.Automation.DebuggerCommandResults((System.Management.Automation.DebuggerResumeAction?)resumeAction, evaluatedByDebugger);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 104662, 104726);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 102875, 104742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 102875, 104742);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsIncompleteParseException(Exception e)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 104758, 105426);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104879, 104985) || true) && (e is IncompleteParseException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 104879, 104985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 104954, 104966);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 104879, 104985);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105082, 105137);

                    RemoteException
                    remoteException = e as RemoteException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105155, 105295) || true) && (remoteException == null || (DynAbs.Tracing.TraceSender.Expression_False(111, 105159, 105221) || f_111_105186_105213(remoteException) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 105155, 105295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105263, 105276);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 105155, 105295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105315, 105411);

                    return f_111_105322_105369(f_111_105322_105362(f_111_105322_105349(remoteException))) == f_111_105373_105410(typeof(IncompleteParseException));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 104758, 105426);

                    System.Management.Automation.ErrorRecord
                    f_111_105186_105213(System.Management.Automation.RemoteException
                    this_param)
                    {
                        var return_v = this_param.ErrorRecord;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 105186, 105213);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_111_105322_105349(System.Management.Automation.RemoteException
                    this_param)
                    {
                        var return_v = this_param.ErrorRecord;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 105322, 105349);
                        return return_v;
                    }


                    System.Management.Automation.ErrorCategoryInfo
                    f_111_105322_105362(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.CategoryInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 105322, 105362);
                        return return_v;
                    }


                    string
                    f_111_105322_105369(System.Management.Automation.ErrorCategoryInfo
                    this_param)
                    {
                        var return_v = this_param.Reason;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 105322, 105369);
                        return return_v;
                    }


                    string
                    f_111_105373_105410(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 105373, 105410);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 104758, 105426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 104758, 105426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void EvaluateSuggestions(ConsoleHostUserInterface ui)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 105442, 106899);
                    // Output any training suggestions
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105632, 105705);

                        List<string>
                        suggestions = f_111_105659_105704(f_111_105687_105703(_parent))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105729, 105842) || true) && (f_111_105733_105750(suggestions) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 105729, 105842);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105804, 105819);

                            f_111_105804_105818(ui);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 105729, 105842);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105866, 105884);

                        bool
                        first = true
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105906, 106171);
                            foreach (string suggestion in f_111_105936_105947_I(suggestions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 105906, 106171);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 105997, 106053) || true) && (!first)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 105997, 106053);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 106038, 106053);

                                    f_111_106038_106052(ui);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(111, 105997, 106053);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 106081, 106106);

                                f_111_106081_106105(
                                                        ui, suggestion);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 106134, 106148);

                                first = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(111, 105906, 106171);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(111, 1, 266);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(111, 1, 266);
                        }
                    }
                    catch (TerminateException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 106208, 106525);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 106208, 106525);
                        // A variable breakpoint may be hit by HostUtilities.GetSuggestion. The debugger throws TerminateExceptions to stop the execution
                        // of the current statement; we do not want to treat these exceptions as errors.
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 106543, 106884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 106673, 106702);

                        f_111_106673_106701(                    // Catch-all OK. This is a third-party call-out.
                                            ui, f_111_106691_106700(e));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 106726, 106788);

                        LocalRunspace
                        localRunspace = (LocalRunspace)f_111_106771_106787(_parent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 106810, 106865);

                        f_111_106810_106864(f_111_106810_106843(localRunspace), e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 106543, 106884);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 105442, 106899);

                    System.Management.Automation.Runspaces.Runspace
                    f_111_105687_105703(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 105687, 105703);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_111_105659_105704(System.Management.Automation.Runspaces.Runspace
                    runspace)
                    {
                        var return_v = HostUtilities.GetSuggestion(runspace);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 105659, 105704);
                        return return_v;
                    }


                    int
                    f_111_105733_105750(System.Collections.Generic.List<string>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 105733, 105750);
                        return return_v;
                    }


                    int
                    f_111_105804_105818(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param)
                    {
                        this_param.WriteLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 105804, 105818);
                        return 0;
                    }


                    int
                    f_111_106038_106052(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param)
                    {
                        this_param.WriteLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 106038, 106052);
                        return 0;
                    }


                    int
                    f_111_106081_106105(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param, string
                    value)
                    {
                        this_param.WriteLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 106081, 106105);
                        return 0;
                    }


                    System.Collections.Generic.List<string>
                    f_111_105936_105947_I(System.Collections.Generic.List<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 105936, 105947);
                        return return_v;
                    }


                    string
                    f_111_106691_106700(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 106691, 106700);
                        return return_v;
                    }


                    int
                    f_111_106673_106701(Microsoft.PowerShell.ConsoleHostUserInterface
                    this_param, string
                    value)
                    {
                        this_param.WriteErrorLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 106673, 106701);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_106771_106787(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 106771, 106787);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_111_106810_106843(System.Management.Automation.Runspaces.LocalRunspace
                    this_param)
                    {
                        var return_v = this_param.GetExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 106810, 106843);
                        return return_v;
                    }


                    int
                    f_111_106810_106864(System.Management.Automation.ExecutionContext
                    this_param, System.Exception
                    obj)
                    {
                        this_param.AppendDollarError((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 106810, 106864);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 105442, 106899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 105442, 106899);
                }
            }

            private string EvaluatePrompt()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 106915, 108044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 106979, 107003);

                    Exception
                    unused = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107021, 107112);

                    string
                    promptString = f_111_107043_107111(_promptExec, "prompt", out unused)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107132, 107279) || true) && (f_111_107136_107170(promptString))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 107132, 107279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107212, 107260);

                        promptString = f_111_107227_107259();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 107132, 107279);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107359, 107938) || true) && (_isRunspacePushed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 107359, 107938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107422, 107489);

                        RemoteRunspace
                        remoteRunspace = f_111_107454_107470(_parent) as RemoteRunspace
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107511, 107721) || true) && (remoteRunspace != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 107511, 107721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107587, 107698);

                            promptString = f_111_107602_107697(remoteRunspace, promptString, _parent._inPushedConfiguredSession);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 107511, 107721);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 107359, 107938);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 107359, 107938);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107803, 107919) || true) && (_runspacePopped)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 107803, 107919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 107872, 107896);

                            _runspacePopped = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 107803, 107919);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 107359, 107938);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108009, 108029);

                    return promptString;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 106915, 108044);

                    string
                    f_111_107043_107111(Microsoft.PowerShell.Executor
                    this_param, string
                    command, out System.Exception
                    exceptionThrown)
                    {
                        var return_v = this_param.ExecuteCommandAndGetResultAsString(command, out exceptionThrown);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 107043, 107111);
                        return return_v;
                    }


                    bool
                    f_111_107136_107170(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 107136, 107170);
                        return return_v;
                    }


                    string
                    f_111_107227_107259()
                    {
                        var return_v = ConsoleHostStrings.DefaultPrompt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 107227, 107259);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_107454_107470(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 107454, 107470);
                        return return_v;
                    }


                    string
                    f_111_107602_107697(System.Management.Automation.RemoteRunspace
                    runspace, string
                    basePrompt, bool
                    configuredSession)
                    {
                        var return_v = HostUtilities.GetRemotePrompt(runspace, basePrompt, configuredSession);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 107602, 107697);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 106915, 108044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 106915, 108044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private string EvaluateDebugPrompt()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(111, 108060, 109169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108129, 108198);

                    PSDataCollection<PSObject>
                    output = f_111_108165_108197()
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108262, 108400);

                        f_111_108262_108399(f_111_108262_108287(f_111_108262_108278(_parent)), f_111_108329_108365(f_111_108343_108364("prompt")), output);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(111, 108437, 108552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108498, 108533);

                        f_111_108498_108532(_parent, ex, _exec);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(111, 108437, 108552);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108572, 108616);

                    PSObject
                    prompt = f_111_108590_108615(output)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108634, 108712);

                    string
                    promptString = (DynAbs.Tracing.TraceSender.Conditional_F1(111, 108656, 108672) || (((prompt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(111, 108675, 108704)) || DynAbs.Tracing.TraceSender.Conditional_F3(111, 108707, 108711))) ? (f_111_108676_108693(prompt) as string) : null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108730, 109114) || true) && (promptString != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 108730, 109114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108796, 108863);

                        RemoteRunspace
                        remoteRunspace = f_111_108828_108844(_parent) as RemoteRunspace
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108885, 109095) || true) && (remoteRunspace != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(111, 108885, 109095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 108961, 109072);

                            promptString = f_111_108976_109071(remoteRunspace, promptString, _parent._inPushedConfiguredSession);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(111, 108885, 109095);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(111, 108730, 109114);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109134, 109154);

                    return promptString;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(111, 108060, 109169);

                    System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    f_111_108165_108197()
                    {
                        var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 108165, 108197);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_108262_108278(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 108262, 108278);
                        return return_v;
                    }


                    System.Management.Automation.Debugger
                    f_111_108262_108287(System.Management.Automation.Runspaces.Runspace
                    this_param)
                    {
                        var return_v = this_param.Debugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 108262, 108287);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Command
                    f_111_108343_108364(string
                    command)
                    {
                        var return_v = new System.Management.Automation.Runspaces.Command(command);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 108343, 108364);
                        return return_v;
                    }


                    System.Management.Automation.PSCommand
                    f_111_108329_108365(System.Management.Automation.Runspaces.Command
                    command)
                    {
                        var return_v = new System.Management.Automation.PSCommand(command);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 108329, 108365);
                        return return_v;
                    }


                    System.Management.Automation.DebuggerCommandResults
                    f_111_108262_108399(System.Management.Automation.Debugger
                    this_param, System.Management.Automation.PSCommand
                    command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    output)
                    {
                        var return_v = this_param.ProcessCommand(command, output);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 108262, 108399);
                        return return_v;
                    }


                    int
                    f_111_108498_108532(Microsoft.PowerShell.ConsoleHost
                    this_param, System.Exception
                    e, Microsoft.PowerShell.Executor
                    exec)
                    {
                        this_param.ReportException(e, exec);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 108498, 108532);
                        return 0;
                    }


                    System.Management.Automation.PSObject
                    f_111_108590_108615(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                    this_param)
                    {
                        var return_v = this_param.ReadAndRemoveAt0();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 108590, 108615);
                        return return_v;
                    }


                    object
                    f_111_108676_108693(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.BaseObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 108676, 108693);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_111_108828_108844(Microsoft.PowerShell.ConsoleHost
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 108828, 108844);
                        return return_v;
                    }


                    string
                    f_111_108976_109071(System.Management.Automation.RemoteRunspace
                    runspace, string
                    basePrompt, bool
                    configuredSession)
                    {
                        var return_v = HostUtilities.GetRemotePrompt(runspace, basePrompt, configuredSession);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 108976, 109071);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 108060, 109169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 108060, 109169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ConsoleHost _parent;

            private bool _isNested;

            private bool _shouldExit;

            private Executor _exec;

            private Executor _promptExec;

            private object _syncObject;

            private bool _isRunspacePushed;

            private bool _runspacePopped;

            private static Stack<InputLoop> s_instanceStack;

            static InputLoop()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 86841, 109856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 109804, 109844);
                s_instanceStack = f_111_109822_109844();
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 86841, 109856);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 86841, 109856);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 86841, 109856);

            bool
            f_111_89774_89797(Microsoft.PowerShell.ConsoleHost
            this_param)
            {
                var return_v = this_param.IsRunspacePushed;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 89774, 89797);
                return return_v;
            }


            Microsoft.PowerShell.Executor
            f_111_89988_90025(Microsoft.PowerShell.ConsoleHost
            parent, bool
            useNestedPipelines, bool
            isPromptFunctionExecutor)
            {
                var return_v = new Microsoft.PowerShell.Executor(parent, useNestedPipelines, isPromptFunctionExecutor);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 89988, 90025);
                return return_v;
            }


            Microsoft.PowerShell.Executor
            f_111_90058_90094(Microsoft.PowerShell.ConsoleHost
            parent, bool
            useNestedPipelines, bool
            isPromptFunctionExecutor)
            {
                var return_v = new Microsoft.PowerShell.Executor(parent, useNestedPipelines, isPromptFunctionExecutor);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 90058, 90094);
                return return_v;
            }


            object
            f_111_109412_109424()
            {
                var return_v = new object();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 109412, 109424);
                return return_v;
            }


            static System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>
            f_111_109822_109844()
            {
                var return_v = new System.Collections.Generic.Stack<Microsoft.PowerShell.ConsoleHost.InputLoop>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 109822, 109844);
                return return_v;
            }

        }
        [Serializable]
        [SuppressMessage("Microsoft.Design", "CA1064:ExceptionsShouldBePublic", Justification =
                    "This exception cannot be used outside of the console host application. It is not thrown by a library routine, only by an application.")]
        private class ConsoleHostStartupException : Exception
        {
            internal
                        ConsoleHostStartupException()
                            :
                            base()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 110218, 110342);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 110218, 110342);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 110218, 110342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 110218, 110342);
                }
            }

            internal
                        ConsoleHostStartupException(string message)
            : base(f_111_110465_110472_C(message))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 110358, 110503);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 110358, 110503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 110358, 110503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 110358, 110503);
                }
            }

            protected
                        ConsoleHostStartupException(
                            System.Runtime.Serialization.SerializationInfo info,
                            System.Runtime.Serialization.StreamingContext context)
            : base(f_111_110754_110758_C(info), context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 110519, 110798);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 110519, 110798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 110519, 110798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 110519, 110798);
                }
            }

            internal
                        ConsoleHostStartupException(string message, Exception innerException)
            : base(f_111_110947_110954_C(message), innerException)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 110814, 111001);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 110814, 111001);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 110814, 111001);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 110814, 111001);
                }
            }

            static ConsoleHostStartupException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 109868, 111012);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 109868, 111012);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 109868, 111012);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 109868, 111012);

            static string
            f_111_110465_110472_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(111, 110358, 110503);
                return return_v;
            }


            static System.Runtime.Serialization.SerializationInfo
            f_111_110754_110758_C(System.Runtime.Serialization.SerializationInfo
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(111, 110519, 110798);
                return return_v;
            }


            static string
            f_111_110947_110954_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(111, 110814, 111001);
                return return_v;
            }

        }

        private RunspaceRef _runspaceRef;

        private GCHandle breakHandlerGcHandle;

        private ConsoleControl.ConsoleModes _savedConsoleMode;

        private ConsoleControl.ConsoleModes _initialConsoleMode;

        private Thread _breakHandlerThread;

        private bool _isDisposed;

        internal ConsoleHostUserInterface ui;

        internal Lazy<TextReader> ConsoleIn { get; }

        private string _savedWindowTitle;

        private Version _ver;

        private int _exitCodeFromRunspace;

        private bool _noExit;

        private bool _setShouldExitCalled;

        private bool _isRunningPromptLoop;

        private bool _wasInitialCommandEncoded;

        private bool? _screenReaderActive;

        internal object hostGlobalLock;

        private bool _shouldEndSession;

        private int _beginApplicationNotifyCount;

        private ConsoleTextWriter _consoleWriter;

        private WrappedSerializer _outputSerializer;

        private WrappedSerializer _errorSerializer;

        private bool _displayDebuggerBanner;

        private DebuggerStopEventArgs _debuggerStopEventArgs;

        private bool _inPushedConfiguredSession;

        internal Pipeline runningCmd;

        private static ConsoleHost s_theConsoleHost;

        internal static InitialSessionState DefaultInitialSessionState;

        [TraceSource("ConsoleHost", "ConsoleHost subclass of S.M.A.PSHost")]
        private static
                PSTraceSource s_tracer;

        [TraceSource("ConsoleHostRunspaceInit", "Initialization code for ConsoleHost's Runspace")]
        private static PSTraceSource s_runspaceInitTracer;

        static ConsoleHost()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 1298, 114399);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1656, 1675);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1705, 1733);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1775, 1799);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1856, 1892);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 1950, 1978);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 12131, 12136);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113797, 113813);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 113862, 113888);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 114017, 114106);
            s_tracer = f_111_114028_114106("ConsoleHost", "ConsoleHost subclass of S.M.A.PSHost");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 114248, 114391);
            s_runspaceInitTracer = f_111_114284_114391("ConsoleHostRunspaceInit", "Initialization code for ConsoleHost's Runspace", false);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 1298, 114399);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 1298, 114399);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 1298, 114399);

        Microsoft.Win32.SafeHandles.SafeFileHandle
        f_111_40895_40939()
        {
            var return_v = ConsoleControl.GetActiveScreenBufferHandle();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 40895, 40939);
            return return_v;
        }


        Microsoft.PowerShell.ConsoleControl.ConsoleModes
        f_111_40872_40940(Microsoft.Win32.SafeHandles.SafeFileHandle
        consoleHandle)
        {
            var return_v = ConsoleControl.GetMode(consoleHandle);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 40872, 40940);
            return return_v;
        }


        System.Threading.Thread
        f_111_41207_41227()
        {
            var return_v =
                        Thread.CurrentThread;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 41207, 41227);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_111_41247_41268(Microsoft.PowerShell.ConsoleHost
        this_param)
        {
            var return_v = this_param.CurrentUICulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 41247, 41268);
            return return_v;
        }


        System.Threading.Thread
        f_111_41283_41303()
        {
            var return_v = Thread.CurrentThread;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 41283, 41303);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_111_41321_41340(Microsoft.PowerShell.ConsoleHost
        this_param)
        {
            var return_v = this_param.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 41321, 41340);
            return return_v;
        }


        Microsoft.PowerShell.ConsoleHostUserInterface
        f_111_41668_41702(Microsoft.PowerShell.ConsoleHost
        parent)
        {
            var return_v = new Microsoft.PowerShell.ConsoleHostUserInterface(parent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 41668, 41702);
            return return_v;
        }


        Microsoft.PowerShell.ConsoleTextWriter
        f_111_41734_41759(Microsoft.PowerShell.ConsoleHostUserInterface
        ui)
        {
            var return_v = new Microsoft.PowerShell.ConsoleTextWriter(ui);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 41734, 41759);
            return return_v;
        }


        System.AppDomain
        f_111_41893_41916()
        {
            var return_v = AppDomain.CurrentDomain;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 41893, 41916);
            return return_v;
        }


        int
        f_111_43249_43263(Microsoft.PowerShell.ConsoleHost
        this_param, bool
        isDisposingNotFinalizing)
        {
            this_param.Dispose(isDisposingNotFinalizing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 43249, 43263);
            return 0;
        }


        System.Lazy<System.IO.TextReader>
        f_111_112178_112216(System.Func<System.IO.TextReader>
        valueFactory)
        {
            var return_v = new System.Lazy<System.IO.TextReader>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 112178, 112216);
            return return_v;
        }


        System.Version
        f_111_112310_112333()
        {
            var return_v = PSVersionInfo.PSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(111, 112310, 112333);
            return return_v;
        }


        object
        f_111_112916_112928()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 112916, 112928);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_111_114028_114106(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 114028, 114106);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_111_114284_114391(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(111, 114284, 114391);
            return return_v;
        }

    }
    internal sealed class RunspaceCreationEventArgs : EventArgs
    {
        internal RunspaceCreationEventArgs(
                    string initialCommand,
                    bool skipProfiles,
                    bool staMode,
                    string configurationName,
                    Collection<CommandParameter> initialCommandArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(111, 114685, 115164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115176, 115220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115230, 115270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115280, 115315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115325, 115372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115382, 115452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 114941, 114973);

                InitialCommand = initialCommand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 114987, 115015);

                SkipProfiles = skipProfiles;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115029, 115047);

                StaMode = staMode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115061, 115099);

                ConfigurationName = configurationName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(111, 115113, 115153);

                InitialCommandArgs = initialCommandArgs;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(111, 114685, 115164);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(111, 114685, 115164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 114685, 115164);
            }
        }

        internal string InitialCommand { get; set; }

        internal bool SkipProfiles { get; set; }

        internal bool StaMode { get; set; }

        internal string ConfigurationName { get; set; }

        internal Collection<CommandParameter> InitialCommandArgs { get; set; }

        static RunspaceCreationEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(111, 114511, 115459);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(111, 114511, 115459);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(111, 114511, 115459);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(111, 114511, 115459);
    }
}   // namespace

