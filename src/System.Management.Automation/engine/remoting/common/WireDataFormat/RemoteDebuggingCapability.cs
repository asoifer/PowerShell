// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Management.Automation.Remoting
{
    internal class RemoteDebuggingCapability
    {
        private readonly HashSet<string> _supportedCommands;

        internal Version PSVersion { get; private set; }

        private RemoteDebuggingCapability(Version powerShellVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1669, 1217, 2598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 701, 743);
                this._supportedCommands = f_1669_722_743();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 756, 804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1302, 1332);

                PSVersion = powerShellVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1406, 1474);

                f_1669_1406_1473(
                            // Commands available in all server versions
                            _supportedCommands, RemoteDebuggingCommands.GetDebuggerStopArgs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1488, 1554);

                f_1669_1488_1553(_supportedCommands, RemoteDebuggingCommands.SetDebuggerAction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1568, 1629);

                f_1669_1568_1628(_supportedCommands, RemoteDebuggingCommands.SetDebugMode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1645, 1722) || true) && (f_1669_1649_1658() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1669, 1645, 1722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1700, 1707);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1669, 1645, 1722);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1775, 2039) || true) && (f_1669_1779_1794(f_1669_1779_1788()) >= f_1669_1798_1829(f_1669_1798_1823()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1669, 1775, 2039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1863, 1931);

                    f_1669_1863_1930(_supportedCommands, RemoteDebuggingCommands.SetDebuggerStepMode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 1949, 2024);

                    f_1669_1949_2023(_supportedCommands, RemoteDebuggingCommands.SetUnhandledBreakpointMode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1669, 1775, 2039);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 2092, 2587) || true) && (f_1669_2096_2111(f_1669_2096_2105()) >= f_1669_2115_2146(f_1669_2115_2140()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1669, 2092, 2587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 2180, 2242);

                    f_1669_2180_2241(_supportedCommands, RemoteDebuggingCommands.GetBreakpoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 2260, 2322);

                    f_1669_2260_2321(_supportedCommands, RemoteDebuggingCommands.SetBreakpoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 2340, 2405);

                    f_1669_2340_2404(_supportedCommands, RemoteDebuggingCommands.EnableBreakpoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 2423, 2489);

                    f_1669_2423_2488(_supportedCommands, RemoteDebuggingCommands.DisableBreakpoint);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 2507, 2572);

                    f_1669_2507_2571(_supportedCommands, RemoteDebuggingCommands.RemoveBreakpoint);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1669, 2092, 2587);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1669, 1217, 2598);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1669, 1217, 2598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1669, 1217, 2598);
            }
        }

        internal static RemoteDebuggingCapability CreateDebuggingCapability(Version powerShellVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1669, 3252, 3312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 3264, 3312);
                return f_1669_3264_3312(powerShellVersion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1669, 3252, 3312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1669, 3252, 3312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1669, 3252, 3312);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.Remoting.RemoteDebuggingCapability
            f_1669_3264_3312(System.Version
            powerShellVersion)
            {
                var return_v = new System.Management.Automation.Remoting.RemoteDebuggingCapability(powerShellVersion);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 3264, 3312);
                return return_v;
            }

        }

        internal bool IsCommandSupported(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1669, 3756, 3812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 3772, 3812);
                return f_1669_3772_3812(_supportedCommands, commandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1669, 3756, 3812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1669, 3756, 3812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1669, 3756, 3812);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1669_3772_3812(System.Collections.Generic.HashSet<string>
            this_param, string
            item)
            {
                var return_v = this_param.Contains(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 3772, 3812);
                return return_v;
            }

        }

        static RemoteDebuggingCapability()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1669, 611, 3820);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1669, 611, 3820);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1669, 611, 3820);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1669, 611, 3820);

        System.Collections.Generic.HashSet<string>
        f_1669_722_743()
        {
            var return_v = new System.Collections.Generic.HashSet<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 722, 743);
            return return_v;
        }


        bool
        f_1669_1406_1473(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 1406, 1473);
            return return_v;
        }


        bool
        f_1669_1488_1553(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 1488, 1553);
            return return_v;
        }


        bool
        f_1669_1568_1628(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 1568, 1628);
            return return_v;
        }


        System.Version
        f_1669_1649_1658()
        {
            var return_v = PSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 1649, 1658);
            return return_v;
        }


        System.Version
        f_1669_1779_1788()
        {
            var return_v = PSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 1779, 1788);
            return return_v;
        }


        int
        f_1669_1779_1794(System.Version
        this_param)
        {
            var return_v = this_param.Major;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 1779, 1794);
            return return_v;
        }


        System.Version
        f_1669_1798_1823()
        {
            var return_v = PSVersionInfo.PSV5Version;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 1798, 1823);
            return return_v;
        }


        int
        f_1669_1798_1829(System.Version
        this_param)
        {
            var return_v = this_param.Major;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 1798, 1829);
            return return_v;
        }


        bool
        f_1669_1863_1930(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 1863, 1930);
            return return_v;
        }


        bool
        f_1669_1949_2023(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 1949, 2023);
            return return_v;
        }


        System.Version
        f_1669_2096_2105()
        {
            var return_v = PSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 2096, 2105);
            return return_v;
        }


        int
        f_1669_2096_2111(System.Version
        this_param)
        {
            var return_v = this_param.Major;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 2096, 2111);
            return return_v;
        }


        System.Management.Automation.SemanticVersion
        f_1669_2115_2140()
        {
            var return_v = PSVersionInfo.PSV7Version;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 2115, 2140);
            return return_v;
        }


        int
        f_1669_2115_2146(System.Management.Automation.SemanticVersion
        this_param)
        {
            var return_v = this_param.Major;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1669, 2115, 2146);
            return return_v;
        }


        bool
        f_1669_2180_2241(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 2180, 2241);
            return return_v;
        }


        bool
        f_1669_2260_2321(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 2260, 2321);
            return return_v;
        }


        bool
        f_1669_2340_2404(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 2340, 2404);
            return return_v;
        }


        bool
        f_1669_2423_2488(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 2423, 2488);
            return return_v;
        }


        bool
        f_1669_2507_2571(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 2507, 2571);
            return return_v;
        }

    }
    internal static class RemoteDebuggingCommands
    {
        internal const string
        GetDebuggerStopArgs = "__Get-PSDebuggerStopArgs"
        ;

        internal const string
        SetDebuggerAction = "__Set-PSDebuggerAction"
        ;

        internal const string
        SetDebuggerStepMode = "__Set-PSDebuggerStepMode"
        ;

        internal const string
        SetDebugMode = "__Set-PSDebugMode"
        ;

        internal const string
        SetUnhandledBreakpointMode = "__Set-PSUnhandledBreakpointMode"
        ;

        internal const string
        GetBreakpoint = "__Get-PSBreakpoint"
        ;

        internal const string
        SetBreakpoint = "__Set-PSBreakpoint"
        ;

        internal const string
        EnableBreakpoint = "__Enable-PSBreakpoint"
        ;

        internal const string
        DisableBreakpoint = "__Disable-PSBreakpoint"
        ;

        internal const string
        RemoveBreakpoint = "__Remove-PSBreakpoint"
        ;

        internal static string CleanCommandName(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1669, 5038, 5167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 5122, 5156);

                return f_1669_5129_5155(commandName, '_');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1669, 5038, 5167);

                string
                f_1669_5129_5155(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimStart(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1669, 5129, 5155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1669, 5038, 5167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1669, 5038, 5167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteDebuggingCommands()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1669, 3828, 5174);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4101, 4156);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4189, 4242);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4318, 4373);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4406, 4454);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4487, 4549);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4616, 4665);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4698, 4747);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4780, 4832);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4865, 4918);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1669, 4951, 5003);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1669, 3828, 5174);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1669, 3828, 5174);
        }

    }
}
