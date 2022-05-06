// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// NOTE: define this if you want to test the output on US machine and ASCII
// characters
//#define TEST_MULTICELL_ON_SINGLE_CELL_LOCALE

using System;
using System.Collections.Specialized;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Host;

using Dbg = System.Management.Automation.Diagnostics;

// interfaces for host interaction

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class DisplayCellsPSHost : DisplayCells
    {
        internal DisplayCellsPSHost(PSHostRawUserInterface rawUserInterface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1114, 2424, 2565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 4507, 4524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 2517, 2554);

                _rawUserInterface = rawUserInterface;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1114, 2424, 2565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 2424, 2565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 2424, 2565);
            }
        }

        internal override int Length(string str, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 2577, 3198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 2654, 2693);

                f_1114_2654_2692(offset >= 0, "offset >= 0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 2707, 2793);

                f_1114_2707_2792(f_1114_2718_2743(str) || (DynAbs.Tracing.TraceSender.Expression_False(1114, 2718, 2768) || (offset < f_1114_2757_2767(str))), "offset < str.Length");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 2845, 2903);

                    return f_1114_2852_2902(_rawUserInterface, str, offset);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1114, 2932, 3112);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1114, 2932, 3112);
                    // thrown when external host rawui is not implemented, in which case
                    // we will fallback to the default value.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 3128, 3187);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1114, 3135, 3160) || ((f_1114_3135_3160(str) && DynAbs.Tracing.TraceSender.Conditional_F2(1114, 3163, 3164)) || DynAbs.Tracing.TraceSender.Conditional_F3(1114, 3167, 3186))) ? 0 : f_1114_3167_3177(str) - offset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 2577, 3198);

                int
                f_1114_2654_2692(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 2654, 2692);
                    return 0;
                }


                bool
                f_1114_2718_2743(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 2718, 2743);
                    return return_v;
                }


                int
                f_1114_2757_2767(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 2757, 2767);
                    return return_v;
                }


                int
                f_1114_2707_2792(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 2707, 2792);
                    return 0;
                }


                int
                f_1114_2852_2902(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, string
                source, int
                offset)
                {
                    var return_v = this_param.LengthInBufferCells(source, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 2852, 2902);
                    return return_v;
                }


                bool
                f_1114_3135_3160(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 3135, 3160);
                    return return_v;
                }


                int
                f_1114_3167_3177(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 3167, 3177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 2577, 3198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 2577, 3198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int Length(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 3210, 3647);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 3311, 3361);

                    return f_1114_3318_3360(_rawUserInterface, str);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1114, 3390, 3570);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1114, 3390, 3570);
                    // thrown when external host rawui is not implemented, in which case
                    // we will fallback to the default value.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 3586, 3636);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1114, 3593, 3618) || ((f_1114_3593_3618(str) && DynAbs.Tracing.TraceSender.Conditional_F2(1114, 3621, 3622)) || DynAbs.Tracing.TraceSender.Conditional_F3(1114, 3625, 3635))) ? 0 : f_1114_3625_3635(str);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 3210, 3647);

                int
                f_1114_3318_3360(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, string
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 3318, 3360);
                    return return_v;
                }


                bool
                f_1114_3593_3618(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 3593, 3618);
                    return return_v;
                }


                int
                f_1114_3625_3635(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 3625, 3635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 3210, 3647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 3210, 3647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int Length(char character)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 3659, 4065);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 3764, 3820);

                    return f_1114_3771_3819(_rawUserInterface, character);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1114, 3849, 4029);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1114, 3849, 4029);
                    // thrown when external host rawui is not implemented, in which case
                    // we will fallback to the default value.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 4045, 4054);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 3659, 4065);

                int
                f_1114_3771_3819(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, char
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 3771, 3819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 3659, 4065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 3659, 4065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int GetHeadSplitLength(string str, int offset, int displayCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 4077, 4264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 4184, 4253);

                return f_1114_4191_4252(this, str, offset, displayCells, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 4077, 4264);

                int
                f_1114_4191_4252(Microsoft.PowerShell.Commands.Internal.Format.DisplayCellsPSHost
                this_param, string
                str, int
                offset, int
                displayCells, bool
                head)
                {
                    var return_v = this_param.GetSplitLengthInternalHelper(str, offset, displayCells, head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 4191, 4252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 4077, 4264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 4077, 4264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int GetTailSplitLength(string str, int offset, int displayCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 4276, 4464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 4383, 4453);

                return f_1114_4390_4452(this, str, offset, displayCells, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 4276, 4464);

                int
                f_1114_4390_4452(Microsoft.PowerShell.Commands.Internal.Format.DisplayCellsPSHost
                this_param, string
                str, int
                offset, int
                displayCells, bool
                head)
                {
                    var return_v = this_param.GetSplitLengthInternalHelper(str, offset, displayCells, head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 4390, 4452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 4276, 4464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 4276, 4464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSHostRawUserInterface _rawUserInterface;

        static DisplayCellsPSHost()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1114, 2359, 4532);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1114, 2359, 4532);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 2359, 4532);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1114, 2359, 4532);
    }
    internal sealed class ConsoleLineOutput : LineOutput
    {
        [TraceSource("ConsoleLineOutput", "ConsoleLineOutput")]
        internal static PSTraceSource tracer;

        internal override int ColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 5257, 6179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 5293, 5315);

                    f_1114_5293_5314(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 5333, 5377);

                    PSHostRawUserInterface
                    raw = f_1114_5362_5376(_console)
                    ;

                    // IMPORTANT NOTE: we subtract one because
                    // we want to make sure the console's last column
                    // is never considered written. This causes the writing
                    // logic to always call WriteLine(), making sure a CR
                    // is inserted.

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 5747, 5818);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1114, 5754, 5767) || ((_forceNewLine && DynAbs.Tracing.TraceSender.Conditional_F2(1114, 5770, 5794)) || DynAbs.Tracing.TraceSender.Conditional_F3(1114, 5797, 5817))) ? raw.BufferSize.Width - 1 : raw.BufferSize.Width;
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1114, 5855, 6051);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1114, 5855, 6051);
                        // thrown when external host rawui is not implemented, in which case
                        // we will fallback to the default value.
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 6071, 6164);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1114, 6078, 6091) || ((_forceNewLine && DynAbs.Tracing.TraceSender.Conditional_F2(1114, 6094, 6129)) || DynAbs.Tracing.TraceSender.Conditional_F3(1114, 6132, 6163))) ? _fallbackRawConsoleColumnNumber - 1 : _fallbackRawConsoleColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 5257, 6179);

                    int
                    f_1114_5293_5314(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        this_param.CheckStopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 5293, 5314);
                        return 0;
                    }


                    System.Management.Automation.Host.PSHostRawUserInterface
                    f_1114_5362_5376(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        var return_v = this_param.RawUI;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 5362, 5376);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 5198, 6190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 5198, 6190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int RowNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 6458, 6975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 6494, 6516);

                    f_1114_6494_6515(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 6534, 6578);

                    PSHostRawUserInterface
                    raw = f_1114_6563_6577(_console)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 6642, 6671);

                        return raw.WindowSize.Height;
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1114, 6708, 6904);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1114, 6708, 6904);
                        // thrown when external host rawui is not implemented, in which case
                        // we will fallback to the default value.
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 6924, 6960);

                    return _fallbackRawConsoleRowNumber;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 6458, 6975);

                    int
                    f_1114_6494_6515(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        this_param.CheckStopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 6494, 6515);
                        return 0;
                    }


                    System.Management.Automation.Host.PSHostRawUserInterface
                    f_1114_6563_6577(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        var return_v = this_param.RawUI;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 6563, 6577);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 6402, 6986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 6402, 6986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void WriteLine(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 7145, 7445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 7212, 7234);

                f_1114_7212_7233(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 7385, 7434);

                f_1114_7385_7433(            // delegate the action to the helper,
                                             // that will properly break the string into
                                             // screen lines
                            _writeLineHelper, s, f_1114_7415_7432(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 7145, 7445);

                int
                f_1114_7212_7233(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                this_param)
                {
                    this_param.CheckStopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 7212, 7233);
                    return 0;
                }


                int
                f_1114_7415_7432(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 7415, 7432);
                    return return_v;
                }


                int
                f_1114_7385_7433(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                s, int
                cols)
                {
                    this_param.WriteLine(s, cols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 7385, 7433);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 7145, 7445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 7145, 7445);
            }
        }

        internal override DisplayCells DisplayCells
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 7525, 7857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 7561, 7583);

                    f_1114_7561_7582(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 7601, 7720) || true) && (_displayCellsPSHost != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 7601, 7720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 7674, 7701);

                        return _displayCellsPSHost;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 7601, 7720);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 7815, 7842);

                    return _displayCellsPSHost;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 7525, 7857);

                    int
                    f_1114_7561_7582(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        this_param.CheckStopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 7561, 7582);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 7457, 7868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 7457, 7868);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ConsoleLineOutput(PSHostUserInterface hostConsole, bool paging, TerminatingErrorContext errorContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1114, 8246, 10250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 20636, 20656);
                this._forceNewLine = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 20774, 20810);
                this._fallbackRawConsoleColumnNumber = 80;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 20928, 20961);
                this._fallbackRawConsoleRowNumber = 40;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 20998, 21014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 21213, 21227);
                this._prompt = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 21369, 21386);
                this._linesWritten = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 21511, 21543);
                this._disableLineWrittenEvent = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 21699, 21714);
                this._console = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 21854, 21873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 22030, 22050);
                this._errorContext = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8381, 8483) || true) && (hostConsole == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 8381, 8483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8423, 8483);

                    throw f_1114_8429_8482("hostConsole");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 8381, 8483);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8497, 8601) || true) && (errorContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 8497, 8601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8540, 8601);

                    throw f_1114_8546_8600("errorContext");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 8497, 8601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8617, 8640);

                _console = hostConsole;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8654, 8683);

                _errorContext = errorContext;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8699, 9112) || true) && (paging)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 8699, 9112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8743, 8780);

                    f_1114_8743_8779(tracer, "paging is needed");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 8938, 9031);

                    string
                    promptString = f_1114_8960_9030(f_1114_8978_9029())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9049, 9097);

                    _prompt = f_1114_9059_9096(promptString, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 8699, 9112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9128, 9172);

                PSHostRawUserInterface
                raw = f_1114_9157_9171(_console)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9186, 9618) || true) && (raw != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 9186, 9618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9235, 9286);

                    f_1114_9235_9285(tracer, "there is a valid raw interface");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9545, 9595);

                    _displayCellsPSHost = f_1114_9567_9594(raw);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 9186, 9618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9737, 9824);

                WriteLineHelper.WriteCallback
                wl = new WriteLineHelper.WriteCallback(this.OnWriteLine)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9838, 9920);

                WriteLineHelper.WriteCallback
                w = new WriteLineHelper.WriteCallback(this.OnWrite)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9936, 10239) || true) && (_forceNewLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 9936, 10239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 9987, 10074);

                    _writeLineHelper = f_1114_10006_10073(false, wl, null, f_1114_10055_10072(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 9936, 10239);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 9936, 10239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 10140, 10224);

                    _writeLineHelper = f_1114_10159_10223(false, wl, w, f_1114_10205_10222(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 9936, 10239);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1114, 8246, 10250);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 8246, 10250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 8246, 10250);
            }
        }

        private void OnWriteLine(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 10457, 11760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 10697, 10726);

                f_1114_10697_10725(            // Do any default transcription.
                            _console, s);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 10742, 11714);

                switch (f_1114_10750_10766(this))
                {

                    case WriteStreamType.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 10742, 11714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 10849, 10876);

                        f_1114_10849_10875(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 10898, 10904);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 10742, 11714);

                    case WriteStreamType.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 10742, 11714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 10975, 11004);

                        f_1114_10975_11003(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 11026, 11032);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 10742, 11714);

                    case WriteStreamType.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 10742, 11714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 11103, 11132);

                        f_1114_11103_11131(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 11154, 11160);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 10742, 11714);

                    case WriteStreamType.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 10742, 11714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 11229, 11256);

                        f_1114_11229_11255(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 11278, 11284);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 10742, 11714);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 10742, 11714);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 11546, 11669) || true) && (f_1114_11550_11574_M(!_console.TranscribeOnly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 11546, 11669);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 11624, 11646);

                            f_1114_11624_11645(_console, s);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 11546, 11669);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 11693, 11699);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 10742, 11714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 11730, 11749);

                f_1114_11730_11748(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 10457, 11760);

                int
                f_1114_10697_10725(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 10697, 10725);
                    return 0;
                }


                System.Management.Automation.WriteStreamType
                f_1114_10750_10766(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                this_param)
                {
                    var return_v = this_param.WriteStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 10750, 10766);
                    return return_v;
                }


                int
                f_1114_10849_10875(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 10849, 10875);
                    return 0;
                }


                int
                f_1114_10975_11003(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteWarningLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 10975, 11003);
                    return 0;
                }


                int
                f_1114_11103_11131(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteVerboseLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 11103, 11131);
                    return 0;
                }


                int
                f_1114_11229_11255(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 11229, 11255);
                    return 0;
                }


                bool
                f_1114_11550_11574_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 11550, 11574);
                    return return_v;
                }


                int
                f_1114_11624_11645(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 11624, 11645);
                    return 0;
                }


                int
                f_1114_11730_11748(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                this_param)
                {
                    this_param.LineWrittenEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 11730, 11748);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 10457, 11760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 10457, 11760);
            }
        }

        private void OnWrite(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 12110, 12999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 12300, 12953);

                switch (f_1114_12308_12324(this))
                {

                    case WriteStreamType.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 12300, 12953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 12407, 12434);

                        f_1114_12407_12433(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 12456, 12462);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 12300, 12953);

                    case WriteStreamType.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 12300, 12953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 12533, 12562);

                        f_1114_12533_12561(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 12584, 12590);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 12300, 12953);

                    case WriteStreamType.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 12300, 12953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 12661, 12690);

                        f_1114_12661_12689(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 12712, 12718);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 12300, 12953);

                    case WriteStreamType.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 12300, 12953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 12787, 12814);

                        f_1114_12787_12813(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 12836, 12842);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 12300, 12953);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 12300, 12953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 12892, 12910);

                        f_1114_12892_12909(_console, s);
                        DynAbs.Tracing.TraceSender.TraceBreak(1114, 12932, 12938);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 12300, 12953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 12969, 12988);

                f_1114_12969_12987(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 12110, 12999);

                System.Management.Automation.WriteStreamType
                f_1114_12308_12324(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                this_param)
                {
                    var return_v = this_param.WriteStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 12308, 12324);
                    return return_v;
                }


                int
                f_1114_12407_12433(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 12407, 12433);
                    return 0;
                }


                int
                f_1114_12533_12561(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteWarningLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 12533, 12561);
                    return 0;
                }


                int
                f_1114_12661_12689(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteVerboseLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 12661, 12689);
                    return 0;
                }


                int
                f_1114_12787_12813(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                message)
                {
                    this_param.WriteDebugLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 12787, 12813);
                    return 0;
                }


                int
                f_1114_12892_12909(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 12892, 12909);
                    return 0;
                }


                int
                f_1114_12969_12987(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                this_param)
                {
                    this_param.LineWrittenEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 12969, 12987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 12110, 12999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 12110, 12999);
            }
        }

        private void LineWrittenEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 13114, 14880);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13289, 13343) || true) && (_disableLineWrittenEvent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 13289, 13343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13336, 13343);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 13289, 13343);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13413, 13458) || true) && (_prompt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 13413, 13458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13451, 13458);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 13413, 13458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13541, 13557);

                _linesWritten++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13626, 14869) || true) && (f_1114_13630_13647(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 13626, 14869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13720, 13752);

                    _disableLineWrittenEvent = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13770, 13839);

                    PromptHandler.PromptResponse
                    response = f_1114_13810_13838(_prompt, _console)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13857, 13890);

                    _disableLineWrittenEvent = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 13910, 14854);

                    switch (response)
                    {

                        case PromptHandler.PromptResponse.NextPage:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 13910, 14854);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 14152, 14170);

                                _linesWritten = 0;
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1114, 14225, 14231);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 13910, 14854);

                        case PromptHandler.PromptResponse.NextLine:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 13910, 14854);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 14444, 14460);

                                _linesWritten--;
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1114, 14515, 14521);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 13910, 14854);

                        case PromptHandler.PromptResponse.Quit:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 13910, 14854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 14802, 14835);

                            throw f_1114_14808_14834();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 13910, 14854);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 13626, 14869);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 13114, 14880);

                bool
                f_1114_13630_13647(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                this_param)
                {
                    var return_v = this_param.NeedToPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 13630, 13647);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput.PromptHandler.PromptResponse
                f_1114_13810_13838(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput.PromptHandler
                this_param, System.Management.Automation.Host.PSHostUserInterface
                console)
                {
                    var return_v = this_param.PromptUser(console);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 13810, 13838);
                    return return_v;
                }


                System.Management.Automation.HaltCommandException
                f_1114_14808_14834()
                {
                    var return_v = new System.Management.Automation.HaltCommandException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 14808, 14834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 13114, 14880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 13114, 14880);
            }
        }

        private bool NeedToPrompt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 15094, 16145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 15219, 15253);

                    int
                    rawRowNumber = f_1114_15238_15252(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 15273, 15459) || true) && (rawRowNumber <= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 15273, 15459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 15427, 15440);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 15273, 15459);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 15615, 15706);

                    int
                    computedPromptLines = f_1114_15641_15705(_prompt, f_1114_15668_15685(this), f_1114_15687_15704(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 15724, 15782);

                    int
                    availableLines = f_1114_15745_15759(this) - computedPromptLines
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 15802, 16071) || true) && (availableLines <= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 15802, 16071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 15867, 15926);

                        f_1114_15867_15925(tracer, "No available Lines; suppress prompting");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 16039, 16052);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 15802, 16071);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 16091, 16130);

                    return _linesWritten >= availableLines;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 15094, 16145);

                    int
                    f_1114_15238_15252(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        var return_v = this_param.RowNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 15238, 15252);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    f_1114_15668_15685(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        var return_v = this_param.DisplayCells;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 15668, 15685);
                        return return_v;
                    }


                    int
                    f_1114_15687_15704(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 15687, 15704);
                        return return_v;
                    }


                    int
                    f_1114_15641_15705(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput.PromptHandler
                    this_param, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    displayCells, int
                    cols)
                    {
                        var return_v = this_param.ComputePromptLines(displayCells, cols);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 15641, 15705);
                        return return_v;
                    }


                    int
                    f_1114_15745_15759(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        var return_v = this_param.RowNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 15745, 15759);
                        return return_v;
                    }


                    int
                    f_1114_15867_15925(System.Management.Automation.PSTraceSource
                    this_param, string
                    format)
                    {
                        this_param.WriteLine(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 15867, 15925);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 15044, 16156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 15044, 16156);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        private class PromptHandler
        {
            internal PromptHandler(string s, ConsoleLineOutput cmdlet)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1114, 16602, 16888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 20046, 20059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 20206, 20219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 20375, 20396);
                    this._callingCmdlet = null;
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 16693, 16793) || true) && (f_1114_16697_16720(s))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 16693, 16793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 16743, 16793);

                        throw f_1114_16749_16792("s");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 16693, 16793);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 16813, 16831);

                    _promptString = s;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 16849, 16873);

                    _callingCmdlet = cmdlet;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1114, 16602, 16888);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 16602, 16888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 16602, 16888);
                }
            }

            internal int ComputePromptLines(DisplayCells displayCells, int cols)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 17226, 17538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 17382, 17478);

                    _actualPrompt = f_1114_17398_17477(displayCells, _promptString, cols, cols);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 17496, 17523);

                    return f_1114_17503_17522(_actualPrompt);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 17226, 17538);

                    System.Collections.Specialized.StringCollection
                    f_1114_17398_17477(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    displayCells, string
                    val, int
                    firstLineLen, int
                    followingLinesLen)
                    {
                        var return_v = StringManipulationHelper.GenerateLines(displayCells, val, firstLineLen, followingLinesLen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 17398, 17477);
                        return return_v;
                    }


                    int
                    f_1114_17503_17522(System.Collections.Specialized.StringCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 17503, 17522);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 17226, 17538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 17226, 17538);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            /// <summary>
            /// Options returned by the PromptUser() call.
            /// </summary>
            internal enum PromptResponse
            {
                NextPage,
                NextLine,
                Quit
            }

            internal PromptResponse PromptUser(PSHostUserInterface console)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1114, 18006, 19855);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18372, 18377);
                        // NOTE: assume the values passed to ComputePromptLines are still valid

                        // write out the prompt line(s). The last one will not have a new line
                        // at the end because we leave the prompt at the end of the line
                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18363, 18685) || true) && (k < f_1114_18383_18402(_actualPrompt))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18404, 18407)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 18363, 18685))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 18363, 18685);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18449, 18653) || true) && (k < (f_1114_18458_18477(_actualPrompt) - 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 18449, 18653);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18509, 18545);

                                f_1114_18509_18544(console, f_1114_18527_18543(_actualPrompt, k));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 18449, 18653);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 18449, 18653);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18621, 18653);

                                f_1114_18621_18652(console, f_1114_18635_18651(_actualPrompt, k));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 18449, 18653);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1114, 1, 323);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1114, 1, 323);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18705, 19840) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 18705, 19840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18758, 18795);

                            f_1114_18758_18794(_callingCmdlet);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18817, 18905);

                            KeyInfo
                            ki = f_1114_18830_18904(f_1114_18830_18843(console), ReadKeyOptions.IncludeKeyUp | ReadKeyOptions.NoEcho)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18927, 18951);

                            char
                            key = ki.Character
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 18973, 19821) || true) && (key == 'q' || (DynAbs.Tracing.TraceSender.Expression_False(1114, 18977, 19001) || key == 'Q'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 18973, 19821);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19148, 19168);

                                f_1114_19148_19167(                        // need to move to the next line since we accepted input, add a newline
                                                        console);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19194, 19221);

                                return PromptResponse.Quit;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 18973, 19821);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 18973, 19821);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19271, 19821) || true) && (key == ' ')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 19271, 19821);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19432, 19452);

                                    f_1114_19432_19451(                        // need to move to the next line since we accepted input, add a newline
                                                            console);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19478, 19509);

                                    return PromptResponse.NextPage;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 19271, 19821);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 19271, 19821);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19559, 19821) || true) && (key == '\r')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1114, 19559, 19821);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19721, 19741);

                                        f_1114_19721_19740(                        // need to move to the next line since we accepted input, add a newline
                                                                console);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 19767, 19798);

                                        return PromptResponse.NextLine;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 19559, 19821);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 19271, 19821);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 18973, 19821);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1114, 18705, 19840);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1114, 18705, 19840);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1114, 18705, 19840);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1114, 18006, 19855);

                    int
                    f_1114_18383_18402(System.Collections.Specialized.StringCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 18383, 18402);
                        return return_v;
                    }


                    int
                    f_1114_18458_18477(System.Collections.Specialized.StringCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 18458, 18477);
                        return return_v;
                    }


                    string
                    f_1114_18527_18543(System.Collections.Specialized.StringCollection
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 18527, 18543);
                        return return_v;
                    }


                    int
                    f_1114_18509_18544(System.Management.Automation.Host.PSHostUserInterface
                    this_param, string
                    value)
                    {
                        this_param.WriteLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 18509, 18544);
                        return 0;
                    }


                    string
                    f_1114_18635_18651(System.Collections.Specialized.StringCollection
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 18635, 18651);
                        return return_v;
                    }


                    int
                    f_1114_18621_18652(System.Management.Automation.Host.PSHostUserInterface
                    this_param, string
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 18621, 18652);
                        return 0;
                    }


                    int
                    f_1114_18758_18794(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                    this_param)
                    {
                        this_param.CheckStopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 18758, 18794);
                        return 0;
                    }


                    System.Management.Automation.Host.PSHostRawUserInterface
                    f_1114_18830_18843(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        var return_v = this_param.RawUI;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 18830, 18843);
                        return return_v;
                    }


                    System.Management.Automation.Host.KeyInfo
                    f_1114_18830_18904(System.Management.Automation.Host.PSHostRawUserInterface
                    this_param, System.Management.Automation.Host.ReadKeyOptions
                    options)
                    {
                        var return_v = this_param.ReadKey(options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 18830, 18904);
                        return return_v;
                    }


                    int
                    f_1114_19148_19167(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        this_param.WriteLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 19148, 19167);
                        return 0;
                    }


                    int
                    f_1114_19432_19451(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        this_param.WriteLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 19432, 19451);
                        return 0;
                    }


                    int
                    f_1114_19721_19740(System.Management.Automation.Host.PSHostUserInterface
                    this_param)
                    {
                        this_param.WriteLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 19721, 19740);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1114, 18006, 19855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 18006, 19855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private StringCollection _actualPrompt;

            private string _promptString;

            private ConsoleLineOutput _callingCmdlet;

            static PromptHandler()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1114, 16289, 20408);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1114, 16289, 20408);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 16289, 20408);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1114, 16289, 20408);

            bool
            f_1114_16697_16720(string
            value)
            {
                var return_v = string.IsNullOrEmpty(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 16697, 16720);
                return return_v;
            }


            System.Management.Automation.PSArgumentNullException
            f_1114_16749_16792(string
            paramName)
            {
                var return_v = PSTraceSource.NewArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 16749, 16792);
                return return_v;
            }

        }

        private bool _forceNewLine;

        private int _fallbackRawConsoleColumnNumber;

        private int _fallbackRawConsoleRowNumber;

        private WriteLineHelper _writeLineHelper;

        private PromptHandler _prompt;

        private long _linesWritten;

        private bool _disableLineWrittenEvent;

        private PSHostUserInterface _console;

        private DisplayCells _displayCellsPSHost;

        private TerminatingErrorContext _errorContext;

        static ConsoleLineOutput()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1114, 4665, 22080);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1114, 4853, 4927);
            tracer = f_1114_4862_4927("ConsoleLineOutput", "ConsoleLineOutput");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1114, 4665, 22080);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1114, 4665, 22080);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1114, 4665, 22080);

        static System.Management.Automation.PSTraceSource
        f_1114_4862_4927(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 4862, 4927);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1114_8429_8482(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 8429, 8482);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1114_8546_8600(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 8546, 8600);
            return return_v;
        }


        int
        f_1114_8743_8779(System.Management.Automation.PSTraceSource
        this_param, string
        format)
        {
            this_param.WriteLine(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 8743, 8779);
            return 0;
        }


        string
        f_1114_8978_9029()
        {
            var return_v = FormatAndOut_out_xxx.ConsoleLineOutput_PagingPrompt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 8978, 9029);
            return return_v;
        }


        string
        f_1114_8960_9030(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 8960, 9030);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput.PromptHandler
        f_1114_9059_9096(string
        s, Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
        cmdlet)
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput.PromptHandler(s, cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 9059, 9096);
            return return_v;
        }


        System.Management.Automation.Host.PSHostRawUserInterface
        f_1114_9157_9171(System.Management.Automation.Host.PSHostUserInterface
        this_param)
        {
            var return_v = this_param.RawUI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 9157, 9171);
            return return_v;
        }


        int
        f_1114_9235_9285(System.Management.Automation.PSTraceSource
        this_param, string
        format)
        {
            this_param.WriteLine(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 9235, 9285);
            return 0;
        }


        Microsoft.PowerShell.Commands.Internal.Format.DisplayCellsPSHost
        f_1114_9567_9594(System.Management.Automation.Host.PSHostRawUserInterface
        rawUserInterface)
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DisplayCellsPSHost(rawUserInterface);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 9567, 9594);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
        f_1114_10055_10072(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
        this_param)
        {
            var return_v = this_param.DisplayCells;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 10055, 10072);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
        f_1114_10006_10073(bool
        lineWrap, Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper.WriteCallback
        wlc, Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper.WriteCallback
        wc, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
        displayCells)
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper(lineWrap, wlc, wc, displayCells);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 10006, 10073);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
        f_1114_10205_10222(Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
        this_param)
        {
            var return_v = this_param.DisplayCells;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1114, 10205, 10222);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
        f_1114_10159_10223(bool
        lineWrap, Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper.WriteCallback
        wlc, Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper.WriteCallback
        wc, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
        displayCells)
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper(lineWrap, wlc, wc, displayCells);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1114, 10159, 10223);
            return return_v;
        }

    }
}
