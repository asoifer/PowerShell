// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text;

using ConsoleHandle = Microsoft.Win32.SafeHandles.SafeFileHandle;
using Dbg = System.Management.Automation.Diagnostics;
using DWORD = System.UInt32;
using HRESULT = System.UInt32;
using NakedWin32Handle = System.IntPtr;

namespace Microsoft.PowerShell
{
    internal
        class ConsoleTextWriter : TextWriter
    {
        internal
                ConsoleTextWriter(ConsoleHostUserInterface ui)
        : base(f_120_586_633_C(f_120_586_633()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(120, 488, 738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 2308, 2311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 659, 702);

                f_120_659_701(ui != null, "ui needs a value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 718, 727);

                _ui = ui;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(120, 488, 738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 488, 738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 488, 738);
            }
        }

        public override
                Encoding
                Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 826, 889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 862, 874);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(120, 826, 889);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 750, 900);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 750, 900);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override
                void
                Write(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 912, 1056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 995, 1045);

                f_120_995_1044(_ui, value, transcribeResult: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 912, 1056);

                int
                f_120_995_1044(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, string
                value, bool
                transcribeResult)
                {
                    this_param.WriteToConsole((System.ReadOnlySpan<char>)value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 995, 1044);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 912, 1056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 912, 1056);
            }
        }

        public override
                void
                Write(ReadOnlySpan<char> value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 1068, 1224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1163, 1213);

                f_120_1163_1212(_ui, value, transcribeResult: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 1068, 1224);

                int
                f_120_1163_1212(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, System.ReadOnlySpan<char>
                value, bool
                transcribeResult)
                {
                    this_param.WriteToConsole(value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 1163, 1212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 1068, 1224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 1068, 1224);
            }
        }

        public override
                void
                WriteLine(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 1236, 1388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1323, 1377);

                f_120_1323_1376(_ui, value, transcribeResult: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 1236, 1388);

                int
                f_120_1323_1376(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, string
                value, bool
                transcribeResult)
                {
                    this_param.WriteLineToConsole((System.ReadOnlySpan<char>)value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 1323, 1376);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 1236, 1388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 1236, 1388);
            }
        }

        public override
                void
                WriteLine(ReadOnlySpan<char> value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 1400, 1564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1499, 1553);

                f_120_1499_1552(_ui, value, transcribeResult: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 1400, 1564);

                int
                f_120_1499_1552(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, System.ReadOnlySpan<char>
                value, bool
                transcribeResult)
                {
                    this_param.WriteLineToConsole(value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 1499, 1552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 1400, 1564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 1400, 1564);
            }
        }

        public override
                void
                Write(bool b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 1576, 1905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1653, 1894) || true) && (b)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 1653, 1894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1692, 1752);

                    f_120_1692_1751(_ui, bool.TrueString, transcribeResult: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 1653, 1894);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 1653, 1894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1818, 1879);

                    f_120_1818_1878(_ui, bool.FalseString, transcribeResult: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 1653, 1894);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 1576, 1905);

                int
                f_120_1692_1751(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, string
                value, bool
                transcribeResult)
                {
                    this_param.WriteToConsole((System.ReadOnlySpan<char>)value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 1692, 1751);
                    return 0;
                }


                int
                f_120_1818_1878(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, string
                value, bool
                transcribeResult)
                {
                    this_param.WriteToConsole((System.ReadOnlySpan<char>)value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 1818, 1878);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 1576, 1905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 1576, 1905);
            }
        }

        public override
                void
                Write(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 1917, 2115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1994, 2043);

                ReadOnlySpan<char>
                c1 = stackalloc char[1] { c }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 2057, 2104);

                f_120_2057_2103(_ui, c1, transcribeResult: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 1917, 2115);

                int
                f_120_2057_2103(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, System.ReadOnlySpan<char>
                value, bool
                transcribeResult)
                {
                    this_param.WriteToConsole(value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 2057, 2103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 1917, 2115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 1917, 2115);
            }
        }

        public override
                void
                Write(char[] a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 2127, 2263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 2206, 2252);

                f_120_2206_2251(_ui, a, transcribeResult: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 2127, 2263);

                int
                f_120_2206_2251(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, char[]
                value, bool
                transcribeResult)
                {
                    this_param.WriteToConsole((System.ReadOnlySpan<char>)value, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 2206, 2251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 2127, 2263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 2127, 2263);
            }
        }

        private ConsoleHostUserInterface _ui;

        static ConsoleTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(120, 421, 2319);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(120, 421, 2319);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 421, 2319);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(120, 421, 2319);

        static System.Globalization.CultureInfo
 f_120_586_633()
        {
            var return_v = System.Globalization.CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 586, 633);
            return return_v;
        }


        int
        f_120_659_701(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 659, 701);
            return 0;
        }


        static System.IFormatProvider
        f_120_586_633_C(System.IFormatProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(120, 488, 738);
            return return_v;
        }

    }
}
