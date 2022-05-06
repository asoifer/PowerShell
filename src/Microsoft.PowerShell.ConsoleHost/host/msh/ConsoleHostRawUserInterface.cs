// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.


using System;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Host;
using System.ComponentModel;
using System.Globalization;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dbg = System.Management.Automation.Diagnostics;
using ConsoleHandle = Microsoft.Win32.SafeHandles.SafeFileHandle;
using WORD = System.UInt16;
using DWORD = System.UInt32;

namespace Microsoft.PowerShell
{
    internal sealed
        class ConsoleHostRawUserInterface : System.Management.Automation.Host.PSHostRawUserInterface
    {
        internal
                ConsoleHostRawUserInterface(ConsoleHostUserInterface mshConsole) : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(112, 1062, 2761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 53309, 53346);
                this.defaultForeground = ConsoleColor.Gray;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 53380, 53418);
                this.defaultBackground = ConsoleColor.Black;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 53464, 53477);
                this.parent = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1178, 1214);

                defaultForeground = f_112_1198_1213();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1228, 1264);

                defaultBackground = f_112_1248_1263();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1278, 1298);

                parent = mshConsole;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1631, 1687);

                WindowsIdentity
                identity = f_112_1658_1686()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1705, 1765);

                WindowsPrincipal
                principal = f_112_1734_1764(identity)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1783, 2731) || true) && (f_112_1787_1839(principal, WindowsBuiltInRole.Administrator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 1783, 2731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 1881, 1958);

                    string
                    prefix = f_112_1897_1957()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2135, 2212);

                    string
                    titlePattern = f_112_2157_2211()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2234, 2390);

                    titlePattern = f_112_2249_2389(f_112_2249_2324(f_112_2249_2275(titlePattern), @"\{1}", ".*"), @"\{0}", f_112_2368_2388(prefix));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2412, 2712) || true) && (!f_112_2417_2462(f_112_2431_2447(this), titlePattern))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 2412, 2712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 2512, 2689);

                        this.WindowTitle = f_112_2531_2688(f_112_2549_2603(), prefix, f_112_2671_2687(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 2412, 2712);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 1783, 2731);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(112, 1062, 2761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 1062, 2761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 1062, 2761);
            }
        }

        public override
                ConsoleColor
                ForegroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 3291, 3659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3327, 3380);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3398, 3428);

                    f_112_3398_3427(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3448, 3472);

                    ConsoleColor
                    foreground
                    = default(ConsoleColor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3490, 3510);

                    ConsoleColor
                    unused
                    = default(ConsoleColor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3530, 3608);

                    f_112_3530_3607(bufferInfo.Attributes, out foreground, out unused);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3626, 3644);

                    return foreground;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 3291, 3659);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_3398_3427(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3398, 3427);
                        return return_v;
                    }


                    int
                    f_112_3530_3607(ushort
                    attribute, out System.ConsoleColor
                    foreground, out System.ConsoleColor
                    background)
                    {
                        ConsoleControl.WORDToColor(attribute, out foreground, out background);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3530, 3607);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 3204, 4476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 3204, 4476);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 3675, 4465);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3711, 4450) || true) && (f_112_3715_3751(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 3711, 4450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3793, 3846);

                        ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                        bufferInfo
                        = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 3870, 3923);

                        ConsoleHandle
                        handle = f_112_3893_3922(out bufferInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4018, 4057);

                        short
                        a = (short)bufferInfo.Attributes
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4081, 4099);

                        a &= (short)~0x0f;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4121, 4160);

                        a = (short)((ushort)a | (ushort)value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4182, 4238);

                        f_112_4182_4237(handle, a);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 3711, 4450);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 3711, 4450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 4320, 4431);

                        throw f_112_4326_4430("value", f_112_4370_4429());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 3711, 4450);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 3675, 4465);

                    bool
                    f_112_3715_3751(System.ConsoleColor
                    c)
                    {
                        var return_v = ConsoleControl.IsConsoleColor(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3715, 3751);
                        return return_v;
                    }


                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_3893_3922(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 3893, 3922);
                        return return_v;
                    }


                    int
                    f_112_4182_4237(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, short
                    attribute)
                    {
                        ConsoleControl.SetConsoleTextAttribute(consoleHandle, (ushort)attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 4182, 4237);
                        return 0;
                    }


                    string
                    f_112_4370_4429()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.InvalidConsoleColorError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 4370, 4429);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_112_4326_4430(string
                    paramName, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 4326, 4430);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 3204, 4476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 3204, 4476);
                }
            }
        }

        public override
                ConsoleColor
                BackgroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 5006, 5374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5042, 5095);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5113, 5143);

                    f_112_5113_5142(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5163, 5187);

                    ConsoleColor
                    background
                    = default(ConsoleColor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5205, 5225);

                    ConsoleColor
                    unused
                    = default(ConsoleColor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5245, 5323);

                    f_112_5245_5322(bufferInfo.Attributes, out unused, out background);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5341, 5359);

                    return background;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 5006, 5374);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_5113_5142(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 5113, 5142);
                        return return_v;
                    }


                    int
                    f_112_5245_5322(ushort
                    attribute, out System.ConsoleColor
                    foreground, out System.ConsoleColor
                    background)
                    {
                        ConsoleControl.WORDToColor(attribute, out foreground, out background);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 5245, 5322);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 4919, 6204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 4919, 6204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 5390, 6193);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5426, 6178) || true) && (f_112_5430_5466(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 5426, 6178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5508, 5561);

                        ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                        bufferInfo
                        = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5585, 5638);

                        ConsoleHandle
                        handle = f_112_5608_5637(out bufferInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5733, 5772);

                        short
                        a = (short)bufferInfo.Attributes
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5796, 5814);

                        a &= (short)~0xf0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5836, 5888);

                        a = (short)((ushort)a | (ushort)((uint)value << 4));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 5910, 5966);

                        f_112_5910_5965(handle, a);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 5426, 6178);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 5426, 6178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 6048, 6159);

                        throw f_112_6054_6158("value", f_112_6098_6157());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 5426, 6178);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 5390, 6193);

                    bool
                    f_112_5430_5466(System.ConsoleColor
                    c)
                    {
                        var return_v = ConsoleControl.IsConsoleColor(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 5430, 5466);
                        return return_v;
                    }


                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_5608_5637(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 5608, 5637);
                        return return_v;
                    }


                    int
                    f_112_5910_5965(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, short
                    attribute)
                    {
                        ConsoleControl.SetConsoleTextAttribute(consoleHandle, (ushort)attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 5910, 5965);
                        return 0;
                    }


                    string
                    f_112_6098_6157()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.InvalidConsoleColorError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 6098, 6157);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_112_6054_6158(string
                    paramName, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 6054, 6158);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 4919, 6204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 4919, 6204);
                }
            }
        }

        public override
                Coordinates
                CursorPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 6746, 7035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 6782, 6835);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 6853, 6883);

                    f_112_6853_6882(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 6903, 6993);

                    Coordinates
                    c = f_112_6919_6992(bufferInfo.CursorPosition.X, bufferInfo.CursorPosition.Y)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 7011, 7020);

                    return c;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 6746, 7035);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_6853_6882(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 6853, 6882);
                        return return_v;
                    }


                    System.Management.Automation.Host.Coordinates
                    f_112_6919_6992(short
                    x, short
                    y)
                    {
                        var return_v = new System.Management.Automation.Host.Coordinates((int)x, (int)y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 6919, 6992);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 6661, 7467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 6661, 7467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 7051, 7456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 7158, 7211);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 7231, 7284);

                    ConsoleHandle
                    handle = f_112_7254_7283(out bufferInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 7304, 7368);

                    f_112_7304_7367(ref value, ref bufferInfo, "value");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 7386, 7441);

                    f_112_7386_7440(handle, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 7051, 7456);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_7254_7283(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 7254, 7283);
                        return return_v;
                    }


                    int
                    f_112_7304_7367(ref System.Management.Automation.Host.Coordinates
                    c, ref Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo, string
                    paramName)
                    {
                        CheckCoordinateWithinBuffer(ref c, ref bufferInfo, paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 7304, 7367);
                        return 0;
                    }


                    int
                    f_112_7386_7440(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, System.Management.Automation.Host.Coordinates
                    cursorPosition)
                    {
                        ConsoleControl.SetConsoleCursorPosition(consoleHandle, cursorPosition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 7386, 7440);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 6661, 7467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 6661, 7467);
                }
            }
        }

        public override
                int
                CursorSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 8111, 8359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8147, 8222);

                    ConsoleHandle
                    consoleHandle = f_112_8177_8221()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8240, 8312);

                    int
                    size = (int)f_112_8256_8306(consoleHandle).Size
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8332, 8344);

                    return size;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 8111, 8359);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_8177_8221()
                    {
                        var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 8177, 8221);
                        return return_v;
                    }


                    Microsoft.PowerShell.ConsoleControl.CONSOLE_CURSOR_INFO
                    f_112_8256_8306(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle)
                    {
                        var return_v = ConsoleControl.GetConsoleCursorInfo(consoleHandle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 8256, 8306);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 8038, 9505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 8038, 9505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 8375, 9494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8411, 8439);

                    const int
                    MinCursorSize = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8457, 8487);

                    const int
                    MaxCursorSize = 100
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8507, 9479) || true) && (value >= MinCursorSize && (DynAbs.Tracing.TraceSender.Expression_True(112, 8511, 8559) && value <= MaxCursorSize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 8507, 9479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8601, 8676);

                        ConsoleHandle
                        consoleHandle = f_112_8631_8675()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8698, 8822);

                        ConsoleControl.CONSOLE_CURSOR_INFO
                        cursorInfo =
                        f_112_8771_8821(consoleHandle)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8846, 9140) || true) && (value == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 8846, 9140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 8910, 8937);

                            cursorInfo.Visible = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 8846, 9140);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 8846, 9140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 9035, 9065);

                            cursorInfo.Size = (uint)value;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 9091, 9117);

                            cursorInfo.Visible = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 8846, 9140);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 9164, 9227);

                        f_112_9164_9226(consoleHandle, cursorInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 8507, 9479);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 8507, 9479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 9309, 9460);

                        throw f_112_9315_9459("value", value, f_112_9401_9458());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 8507, 9479);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 8375, 9494);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_8631_8675()
                    {
                        var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 8631, 8675);
                        return return_v;
                    }


                    Microsoft.PowerShell.ConsoleControl.CONSOLE_CURSOR_INFO
                    f_112_8771_8821(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle)
                    {
                        var return_v = ConsoleControl.GetConsoleCursorInfo(consoleHandle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 8771, 8821);
                        return return_v;
                    }


                    int
                    f_112_9164_9226(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, Microsoft.PowerShell.ConsoleControl.CONSOLE_CURSOR_INFO
                    cursorInfo)
                    {
                        ConsoleControl.SetConsoleCursorInfo(consoleHandle, cursorInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 9164, 9226);
                        return 0;
                    }


                    string
                    f_112_9401_9458()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.InvalidCursorSizeError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 9401, 9458);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_9315_9459(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 9315, 9459);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 8038, 9505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 8038, 9505);
                }
            }
        }

        public override
                Coordinates
                WindowPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 10042, 10330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10078, 10131);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10149, 10179);

                    f_112_10149_10178(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10199, 10286);

                    Coordinates
                    c = f_112_10215_10285(bufferInfo.WindowRect.Left, bufferInfo.WindowRect.Top)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10306, 10315);

                    return c;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 10042, 10330);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_10149_10178(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 10149, 10178);
                        return return_v;
                    }


                    System.Management.Automation.Host.Coordinates
                    f_112_10215_10285(short
                    x, short
                    y)
                    {
                        var return_v = new System.Management.Automation.Host.Coordinates((int)x, (int)y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 10215, 10285);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 9957, 12311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 9957, 12311);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 10346, 12300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10382, 10435);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10455, 10508);

                    ConsoleHandle
                    handle = f_112_10478_10507(out bufferInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10526, 10578);

                    ConsoleControl.SMALL_RECT
                    r = bufferInfo.WindowRect
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 10953, 10992);

                    int
                    windowWidth = r.Right - r.Left + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11010, 11050);

                    int
                    windowHeight = r.Bottom - r.Top + 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11070, 11357) || true) && (value.X < 0 || (DynAbs.Tracing.TraceSender.Expression_False(112, 11074, 11136) || value.X > bufferInfo.BufferSize.X - windowWidth))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 11070, 11357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11178, 11338);

                        throw f_112_11184_11337("value.X", value.X, f_112_11274_11336());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 11070, 11357);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11377, 11665) || true) && (value.Y < 0 || (DynAbs.Tracing.TraceSender.Expression_False(112, 11381, 11444) || value.Y > bufferInfo.BufferSize.Y - windowHeight))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 11377, 11665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11486, 11646);

                        throw f_112_11492_11645("value.Y", value.Y, f_112_11582_11644());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 11377, 11665);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11685, 11709);

                    r.Left = (short)value.X;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11727, 11750);

                    r.Top = (short)value.Y;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 11954, 11998);

                    r.Right = (short)(r.Left + windowWidth - 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 12016, 12061);

                    r.Bottom = (short)(r.Top + windowHeight - 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 12079, 12138);

                    f_112_12079_12137(r.Right >= r.Left, "Window size is too narrow");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 12156, 12214);

                    f_112_12156_12213(r.Bottom >= r.Top, "Window size is too short");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 12232, 12285);

                    f_112_12232_12284(handle, true, r);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 10346, 12300);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_10478_10507(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 10478, 10507);
                        return return_v;
                    }


                    string
                    f_112_11274_11336()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.InvalidXWindowPositionError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 11274, 11336);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_11184_11337(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 11184, 11337);
                        return return_v;
                    }


                    string
                    f_112_11582_11644()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.InvalidYWindowPositionError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 11582, 11644);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_11492_11645(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 11492, 11645);
                        return return_v;
                    }


                    int
                    f_112_12079_12137(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 12079, 12137);
                        return 0;
                    }


                    int
                    f_112_12156_12213(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 12156, 12213);
                        return 0;
                    }


                    int
                    f_112_12232_12284(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, bool
                    absolute, Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                    windowInfo)
                    {
                        ConsoleControl.SetConsoleWindowInfo(consoleHandle, absolute, windowInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 12232, 12284);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 9957, 12311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 9957, 12311);
                }
            }
        }

        public override
                Size
                BufferSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 12933, 13169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 12969, 13022);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 13040, 13070);

                    f_112_13040_13069(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 13088, 13154);

                    return f_112_13095_13153(bufferInfo.BufferSize.X, bufferInfo.BufferSize.Y);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 12933, 13169);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_13040_13069(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 13040, 13069);
                        return return_v;
                    }


                    System.Management.Automation.Host.Size
                    f_112_13095_13153(short
                    width, short
                    height)
                    {
                        var return_v = new System.Management.Automation.Host.Size((int)width, (int)height);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 13095, 13153);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 12859, 14516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 12859, 14516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 13185, 14505);
                    // looking in windows/core/ntcon/server/output.c, it looks like the minimum size is 1 row X however many
                    // characters will fit in the minimum window size system metric (SM_CXMIN).  Instead of going to the effort of
                    // computing that minimum here, it is cleaner and cheaper to make the call to SetConsoleScreenBuffer and just
                    // translate any exception that might get thrown.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 13709, 13777);

                        ConsoleHandle
                        handle = f_112_13732_13776()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 13799, 13856);

                        f_112_13799_13855(handle, value);
                    }
                    catch (HostException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(112, 13893, 14490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 13957, 14024);

                        Win32Exception
                        win32exception = f_112_13989_14005(e) as Win32Exception
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 14046, 14471) || true) && (win32exception != null && (DynAbs.Tracing.TraceSender.Expression_True(112, 14050, 14139) && f_112_14101_14131(win32exception) == 0x57))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 14046, 14471);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 14189, 14344);

                            throw f_112_14195_14343("value", value, f_112_14285_14342());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 14046, 14471);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 14046, 14471);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 14442, 14448);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 14046, 14471);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(112, 13893, 14490);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 13185, 14505);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_13732_13776()
                    {
                        var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 13732, 13776);
                        return return_v;
                    }


                    int
                    f_112_13799_13855(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, System.Management.Automation.Host.Size
                    newSize)
                    {
                        ConsoleControl.SetConsoleScreenBufferSize(consoleHandle, newSize);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 13799, 13855);
                        return 0;
                    }


                    System.Exception
                    f_112_13989_14005(System.Management.Automation.Host.HostException
                    this_param)
                    {
                        var return_v = this_param.InnerException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 13989, 14005);
                        return return_v;
                    }


                    int
                    f_112_14101_14131(System.ComponentModel.Win32Exception
                    this_param)
                    {
                        var return_v = this_param.NativeErrorCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 14101, 14131);
                        return return_v;
                    }


                    string
                    f_112_14285_14342()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.InvalidBufferSizeError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 14285, 14342);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_14195_14343(string
                    paramName, System.Management.Automation.Host.Size
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 14195, 14343);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 12859, 14516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 12859, 14516);
                }
            }
        }

        public override
                Size
                WindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 15138, 15553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 15174, 15227);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 15245, 15275);

                    f_112_15245_15274(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 15295, 15509);

                    Size
                    s =
                    f_112_15325_15508(bufferInfo.WindowRect.Right - bufferInfo.WindowRect.Left + 1, bufferInfo.WindowRect.Bottom - bufferInfo.WindowRect.Top + 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 15529, 15538);

                    return s;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 15138, 15553);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_15245_15274(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 15245, 15274);
                        return return_v;
                    }


                    System.Management.Automation.Host.Size
                    f_112_15325_15508(int
                    width, int
                    height)
                    {
                        var return_v = new System.Management.Automation.Host.Size(width, height);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 15325, 15508);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 15064, 20067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 15064, 20067);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 15569, 20056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 15605, 15658);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 15678, 15731);

                    ConsoleHandle
                    handle = f_112_15701_15730(out bufferInfo)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 16108, 16353) || true) && (value.Width < 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 16108, 16353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 16169, 16334);

                        throw f_112_16175_16333("value.Width", value.Width, f_112_16273_16332());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 16108, 16353);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 16373, 16622) || true) && (value.Height < 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 16373, 16622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 16435, 16603);

                        throw f_112_16441_16602("value.Height", value.Height, f_112_16541_16601());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 16373, 16622);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 16642, 16917) || true) && (value.Width > bufferInfo.BufferSize.X)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 16642, 16917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 16725, 16898);

                        throw f_112_16731_16897("value.Width", value.Width, f_112_16829_16896());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 16642, 16917);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 16937, 17216) || true) && (value.Height > bufferInfo.BufferSize.Y)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 16937, 17216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 17021, 17197);

                        throw f_112_17027_17196("value.Height", value.Height, f_112_17127_17195());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 16937, 17216);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 17236, 17567) || true) && (value.Width > bufferInfo.MaxWindowSize.X)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 17236, 17567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 17322, 17548);

                        throw f_112_17328_17547("value.Width", value.Width, f_112_17426_17493(), bufferInfo.MaxWindowSize.X);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 17236, 17567);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 17587, 17922) || true) && (value.Height > bufferInfo.MaxWindowSize.Y)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 17587, 17922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 17674, 17903);

                        throw f_112_17680_17902("value.Height", value.Height, f_112_17780_17848(), bufferInfo.MaxWindowSize.Y);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 17587, 17922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 18101, 18153);

                    ConsoleControl.SMALL_RECT
                    r = bufferInfo.WindowRect
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 18359, 18403);

                    r.Right = (short)(r.Left + value.Width - 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 18421, 18466);

                    r.Bottom = (short)(r.Top + value.Height - 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 18990, 19058);

                    short
                    adjustLeft = (short)(r.Right - (bufferInfo.BufferSize.X - 1))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19076, 19144);

                    short
                    adjustTop = (short)(r.Bottom - (bufferInfo.BufferSize.Y - 1))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19164, 19308) || true) && (adjustLeft > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 19164, 19308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19224, 19245);

                        r.Left -= adjustLeft;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19267, 19289);

                        r.Right -= adjustLeft;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 19164, 19308);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19328, 19469) || true) && (adjustTop > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 19328, 19469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19387, 19406);

                        r.Top -= adjustTop;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19428, 19450);

                        r.Bottom -= adjustTop;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 19328, 19469);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19489, 19719) || true) && (r.Right < r.Left)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 19489, 19719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19551, 19700);

                        throw f_112_19557_19699("value", value, f_112_19643_19698());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 19489, 19719);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19739, 19968) || true) && (r.Bottom < r.Top)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 19739, 19968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19801, 19949);

                        throw f_112_19807_19948("value", value, f_112_19893_19947());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 19739, 19968);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 19988, 20041);

                    f_112_19988_20040(handle, true, r);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 15569, 20056);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_15701_15730(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 15701, 15730);
                        return return_v;
                    }


                    string
                    f_112_16273_16332()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowWidthTooSmallError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 16273, 16332);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_16175_16333(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 16175, 16333);
                        return return_v;
                    }


                    string
                    f_112_16541_16601()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowHeightTooSmallError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 16541, 16601);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_16441_16602(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 16441, 16602);
                        return return_v;
                    }


                    string
                    f_112_16829_16896()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowWidthLargerThanBufferError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 16829, 16896);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_16731_16897(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 16731, 16897);
                        return return_v;
                    }


                    string
                    f_112_17127_17195()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowHeightLargerThanBufferError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 17127, 17195);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_17027_17196(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 17027, 17196);
                        return return_v;
                    }


                    string
                    f_112_17426_17493()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowWidthTooLargeErrorTemplate;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 17426, 17493);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_17328_17547(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 17328, 17547);
                        return return_v;
                    }


                    string
                    f_112_17780_17848()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowHeightTooLargeErrorTemplate;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 17780, 17848);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_17680_17902(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 17680, 17902);
                        return return_v;
                    }


                    string
                    f_112_19643_19698()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowTooNarrowError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 19643, 19698);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_19557_19699(string
                    paramName, System.Management.Automation.Host.Size
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 19557, 19699);
                        return return_v;
                    }


                    string
                    f_112_19893_19947()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowTooShortError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 19893, 19947);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_112_19807_19948(string
                    paramName, System.Management.Automation.Host.Size
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 19807, 19948);
                        return return_v;
                    }


                    int
                    f_112_19988_20040(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, bool
                    absolute, Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                    windowInfo)
                    {
                        ConsoleControl.SetConsoleWindowInfo(consoleHandle, absolute, windowInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 19988, 20040);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 15064, 20067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 15064, 20067);
                }
            }
        }

        public override
                Size
                MaxWindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 20397, 20670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 20433, 20486);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo
                    = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 20504, 20534);

                    f_112_20504_20533(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 20552, 20626);

                    Size
                    s = f_112_20561_20625(bufferInfo.MaxWindowSize.X, bufferInfo.MaxWindowSize.Y)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 20646, 20655);

                    return s;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 20397, 20670);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_20504_20533(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo)
                    {
                        var return_v = GetBufferInfo(out bufferInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 20504, 20533);
                        return return_v;
                    }


                    System.Management.Automation.Host.Size
                    f_112_20561_20625(short
                    width, short
                    height)
                    {
                        var return_v = new System.Management.Automation.Host.Size((int)width, (int)height);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 20561, 20625);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 20320, 20681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 20320, 20681);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override
                Size
                MaxPhysicalWindowSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 21105, 21300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 21141, 21209);

                    ConsoleHandle
                    handle = f_112_21164_21208()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 21227, 21285);

                    return f_112_21234_21284(handle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 21105, 21300);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_21164_21208()
                    {
                        var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 21164, 21208);
                        return return_v;
                    }


                    System.Management.Automation.Host.Size
                    f_112_21234_21284(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle)
                    {
                        var return_v = ConsoleControl.GetLargestConsoleWindowSize(consoleHandle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 21234, 21284);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 21020, 21311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 21020, 21311);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PipelineStoppedException NewPipelineStoppedException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 21476, 21657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 21563, 21623);

                PipelineStoppedException
                e = f_112_21592_21622()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 21637, 21646);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 21476, 21657);

                System.Management.Automation.PipelineStoppedException
                f_112_21592_21622()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 21592, 21622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 21476, 21657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 21476, 21657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CacheKeyEvent(ConsoleControl.KEY_EVENT_RECORD input, ref ConsoleControl.KEY_EVENT_RECORD cache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(112, 21919, 22196);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 22059, 22185) || true) && (input.RepeatCount > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 22059, 22185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 22118, 22132);

                    cache = input;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 22150, 22170);

                    cache.RepeatCount--;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 22059, 22185);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(112, 21919, 22196);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 21919, 22196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 21919, 22196);
            }
        }

        public override
                KeyInfo
                ReadKey(ReadKeyOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 23604, 29302);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 23702, 23948) || true) && ((options & (ReadKeyOptions.IncludeKeyDown | ReadKeyOptions.IncludeKeyUp)) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 23702, 23948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 23818, 23933);

                    throw f_112_23824_23932("options", f_112_23870_23931());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 23702, 23948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 24034, 24050);

                KeyInfo
                keyInfo
                = default(KeyInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 24066, 25002) || true) && (cachedKeyEvent.RepeatCount > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 24066, 25002);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 24201, 24514) || true) && (((options & ReadKeyOptions.AllowCtrlC) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(112, 24205, 24290) && cachedKeyEvent.UnicodeChar == (char)3))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 24201, 24514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 24408, 24437);

                        cachedKeyEvent.RepeatCount--;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 24459, 24495);

                        throw f_112_24465_24494(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 24201, 24514);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 24714, 24987) || true) && ((((options & ReadKeyOptions.IncludeKeyUp) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(112, 24719, 24792) && !cachedKeyEvent.KeyDown)) || (DynAbs.Tracing.TraceSender.Expression_False(112, 24718, 24895) || (((options & ReadKeyOptions.IncludeKeyDown) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(112, 24820, 24894) && cachedKeyEvent.KeyDown))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 24714, 24987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 24937, 24968);

                        cachedKeyEvent.RepeatCount = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 24714, 24987);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 24066, 25002);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 25018, 29088) || true) && (cachedKeyEvent.RepeatCount > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 25018, 29088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 25086, 25141);

                    f_112_25086_25140(cachedKeyEvent, out keyInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 25159, 25188);

                    cachedKeyEvent.RepeatCount--;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 25018, 29088);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 25018, 29088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 25254, 25315);

                    ConsoleHandle
                    handle = f_112_25277_25314()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 25333, 25413);

                    ConsoleControl.INPUT_RECORD[]
                    inputRecords = new ConsoleControl.INPUT_RECORD[1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 25431, 25505);

                    ConsoleControl.ConsoleModes
                    originalMode = f_112_25474_25504(handle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 25660, 25977);

                    ConsoleControl.ConsoleModes
                    newMode = originalMode &
                                                                ~ConsoleControl.ConsoleModes.WindowInput &
                                                                ~ConsoleControl.ConsoleModes.MouseInput &
                                                                ~ConsoleControl.ConsoleModes.ProcessedInput
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 26041, 26081);

                        f_112_26041_26080(handle, newMode);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 26103, 28924) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 26103, 28924);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 26164, 26248);

                                int
                                actualNumberOfInput = f_112_26190_26247(handle, ref inputRecords)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 26274, 26501);

                                f_112_26274_26500(actualNumberOfInput == 1, f_112_26340_26499(f_112_26354_26382(), "ReadConsoleInput returns {0} number of input event records", actualNumberOfInput));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 26527, 28901) || true) && (actualNumberOfInput == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 26527, 28901);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 26613, 28874) || true) && (((ConsoleControl.InputRecordEventTypes)inputRecords[0].EventType) ==
                                                                    ConsoleControl.InputRecordEventTypes.KEY_EVENT)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 26613, 28874);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 26831, 27077);

                                        f_112_26831_27076(!inputRecords[0].KeyEvent.KeyDown || (DynAbs.Tracing.TraceSender.Expression_False(112, 26842, 26920) || inputRecords[0].KeyEvent.RepeatCount != 0), f_112_26959_27075(f_112_26973_27001(), "ReadConsoleInput returns a KeyEvent that is KeyDown and RepeatCount 0"));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 27111, 27532) || true) && (inputRecords[0].KeyEvent.RepeatCount == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 27111, 27532);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 27488, 27497);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 27111, 27532);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 27647, 28024) || true) && ((options & ReadKeyOptions.AllowCtrlC) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(112, 27651, 27781) && inputRecords[0].KeyEvent.UnicodeChar == (char)3))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 27647, 28024);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 27855, 27915);

                                            f_112_27855_27914(inputRecords[0].KeyEvent, ref cachedKeyEvent);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 27953, 27989);

                                            throw f_112_27959_27988(this);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 27647, 28024);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 28229, 28843) || true) && ((((options & ReadKeyOptions.IncludeKeyDown) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(112, 28234, 28359) && inputRecords[0].KeyEvent.KeyDown)) || (DynAbs.Tracing.TraceSender.Expression_False(112, 28233, 28527) || (((options & ReadKeyOptions.IncludeKeyUp) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(112, 28402, 28526) && !inputRecords[0].KeyEvent.KeyDown))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 28229, 28843);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 28601, 28661);

                                            f_112_28601_28660(inputRecords[0].KeyEvent, ref cachedKeyEvent);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 28699, 28764);

                                            f_112_28699_28763(inputRecords[0].KeyEvent, out keyInfo);
                                            DynAbs.Tracing.TraceSender.TraceBreak(112, 28802, 28808);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 28229, 28843);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 26613, 28874);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 26527, 28901);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(112, 26103, 28924);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 26103, 28924);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(112, 26103, 28924);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(112, 28961, 29073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 29009, 29054);

                        f_112_29009_29053(handle, originalMode);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(112, 28961, 29073);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 25018, 29088);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 29104, 29260) || true) && ((options & ReadKeyOptions.NoEcho) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 29104, 29260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 29180, 29245);

                    f_112_29180_29244(parent, keyInfo.Character, transcribeResult: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 29104, 29260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 29276, 29291);

                return keyInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 23604, 29302);

                string
                f_112_23870_23931()
                {
                    var return_v = ConsoleHostRawUserInterfaceStrings.InvalidReadKeyOptionsError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 23870, 23931);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_23824_23932(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 23824, 23932);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_112_24465_24494(Microsoft.PowerShell.ConsoleHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.NewPipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 24465, 24494);
                    return return_v;
                }


                int
                f_112_25086_25140(Microsoft.PowerShell.ConsoleControl.KEY_EVENT_RECORD
                keyEventRecord, out System.Management.Automation.Host.KeyInfo
                keyInfo)
                {
                    KEY_EVENT_RECORDToKeyInfo(keyEventRecord, out keyInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 25086, 25140);
                    return 0;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_112_25277_25314()
                {
                    var return_v = ConsoleControl.GetConioDeviceHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 25277, 25314);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleControl.ConsoleModes
                f_112_25474_25504(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = ConsoleControl.GetMode(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 25474, 25504);
                    return return_v;
                }


                int
                f_112_26041_26080(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, Microsoft.PowerShell.ConsoleControl.ConsoleModes
                mode)
                {
                    ConsoleControl.SetMode(consoleHandle, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 26041, 26080);
                    return 0;
                }


                int
                f_112_26190_26247(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, ref Microsoft.PowerShell.ConsoleControl.INPUT_RECORD[]
                buffer)
                {
                    var return_v = ConsoleControl.ReadConsoleInput(consoleHandle, ref buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 26190, 26247);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_112_26354_26382()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 26354, 26382);
                    return return_v;
                }


                string
                f_112_26340_26499(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 26340, 26499);
                    return return_v;
                }


                int
                f_112_26274_26500(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 26274, 26500);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_112_26973_27001()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 26973, 27001);
                    return return_v;
                }


                string
                f_112_26959_27075(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 26959, 27075);
                    return return_v;
                }


                int
                f_112_26831_27076(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 26831, 27076);
                    return 0;
                }


                int
                f_112_27855_27914(Microsoft.PowerShell.ConsoleControl.KEY_EVENT_RECORD
                input, ref Microsoft.PowerShell.ConsoleControl.KEY_EVENT_RECORD
                cache)
                {
                    CacheKeyEvent(input, ref cache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 27855, 27914);
                    return 0;
                }


                System.Management.Automation.PipelineStoppedException
                f_112_27959_27988(Microsoft.PowerShell.ConsoleHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.NewPipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 27959, 27988);
                    return return_v;
                }


                int
                f_112_28601_28660(Microsoft.PowerShell.ConsoleControl.KEY_EVENT_RECORD
                input, ref Microsoft.PowerShell.ConsoleControl.KEY_EVENT_RECORD
                cache)
                {
                    CacheKeyEvent(input, ref cache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 28601, 28660);
                    return 0;
                }


                int
                f_112_28699_28763(Microsoft.PowerShell.ConsoleControl.KEY_EVENT_RECORD
                keyEventRecord, out System.Management.Automation.Host.KeyInfo
                keyInfo)
                {
                    KEY_EVENT_RECORDToKeyInfo(keyEventRecord, out keyInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 28699, 28763);
                    return 0;
                }


                int
                f_112_29009_29053(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, Microsoft.PowerShell.ConsoleControl.ConsoleModes
                mode)
                {
                    ConsoleControl.SetMode(consoleHandle, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 29009, 29053);
                    return 0;
                }


                int
                f_112_29180_29244(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param, char
                c, bool
                transcribeResult)
                {
                    this_param.WriteToConsole(c, transcribeResult: transcribeResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 29180, 29244);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 23604, 29302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 23604, 29302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static
                void
                KEY_EVENT_RECORDToKeyInfo(ConsoleControl.KEY_EVENT_RECORD keyEventRecord, out KeyInfo keyInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(112, 29314, 29706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 29471, 29695);

                keyInfo = f_112_29481_29694(keyEventRecord.VirtualKeyCode, keyEventRecord.UnicodeChar, (uint)((ControlKeyStates)keyEventRecord.ControlKeyState), keyEventRecord.KeyDown);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(112, 29314, 29706);

                System.Management.Automation.Host.KeyInfo
                f_112_29481_29694(ushort
                virtualKeyCode, char
                ch, uint
                controlKeyState, bool
                keyDown)
                {
                    var return_v = new System.Management.Automation.Host.KeyInfo((int)virtualKeyCode, ch, (System.Management.Automation.Host.ControlKeyStates)controlKeyState, keyDown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 29481, 29694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 29314, 29706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 29314, 29706);
            }
        }

        public override
                void
                FlushInputBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 30012, 30274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 30094, 30155);

                ConsoleHandle
                handle = f_112_30117_30154()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 30169, 30216);

                f_112_30169_30215(handle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 30232, 30263);

                cachedKeyEvent.RepeatCount = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 30012, 30274);

                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_112_30117_30154()
                {
                    var return_v = ConsoleControl.GetConioDeviceHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 30117, 30154);
                    return return_v;
                }


                int
                f_112_30169_30215(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    ConsoleControl.FlushConsoleInputBuffer(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 30169, 30215);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 30012, 30274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 30012, 30274);
            }
        }

        public override
                bool
                KeyAvailable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 30762, 32403);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 30798, 30905) || true) && (cachedKeyEvent.RepeatCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 30798, 30905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 30874, 30886);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 30798, 30905);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 30925, 30986);

                    ConsoleHandle
                    handle = f_112_30948_30985()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31004, 31156);

                    ConsoleControl.INPUT_RECORD[]
                    inputRecords =
                                        new ConsoleControl.INPUT_RECORD[f_112_31102_31154(handle)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31176, 31267);

                    int
                    actualNumberOfInputRecords = f_112_31209_31266(handle, ref inputRecords)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31296, 31301);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31287, 32355) || true) && (i < actualNumberOfInputRecords)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31335, 31338)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(112, 31287, 32355))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 31287, 32355);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31380, 32336) || true) && (((ConsoleControl.InputRecordEventTypes)inputRecords[i].EventType) ==
                                                        ConsoleControl.InputRecordEventTypes.KEY_EVENT)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 31380, 32336);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31578, 31816);

                                f_112_31578_31815(!inputRecords[i].KeyEvent.KeyDown || (DynAbs.Tracing.TraceSender.Expression_False(112, 31589, 31667) || inputRecords[i].KeyEvent.RepeatCount != 0), f_112_31698_31814(f_112_31712_31740(), "PeekConsoleInput returns a KeyEvent that is KeyDown and RepeatCount 0"));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 31844, 32273) || true) && (inputRecords[i].KeyEvent.KeyDown && (DynAbs.Tracing.TraceSender.Expression_True(112, 31848, 31925) && inputRecords[i].KeyEvent.RepeatCount == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 31844, 32273);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 32237, 32246);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 31844, 32273);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 32301, 32313);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(112, 31380, 32336);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 1, 1069);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(112, 1, 1069);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 32375, 32388);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 30762, 32403);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    f_112_30948_30985()
                    {
                        var return_v = ConsoleControl.GetConioDeviceHandle();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 30948, 30985);
                        return return_v;
                    }


                    int
                    f_112_31102_31154(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle)
                    {
                        var return_v = ConsoleControl.GetNumberOfConsoleInputEvents(consoleHandle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 31102, 31154);
                        return return_v;
                    }


                    int
                    f_112_31209_31266(Microsoft.Win32.SafeHandles.SafeFileHandle
                    consoleHandle, ref Microsoft.PowerShell.ConsoleControl.INPUT_RECORD[]
                    buffer)
                    {
                        var return_v = ConsoleControl.PeekConsoleInput(consoleHandle, ref buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 31209, 31266);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_112_31712_31740()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 31712, 31740);
                        return return_v;
                    }


                    string
                    f_112_31698_31814(System.Globalization.CultureInfo
                    provider, string
                    format, params object?[]
                    args)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 31698, 31814);
                        return return_v;
                    }


                    int
                    f_112_31578_31815(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 31578, 31815);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 30686, 32414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 30686, 32414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string WindowTitle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 33041, 33138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33077, 33123);

                    return f_112_33084_33122();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 33041, 33138);

                    string
                    f_112_33084_33122()
                    {
                        var return_v = ConsoleControl.GetConsoleWindowTitle();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 33084, 33122);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 32982, 34506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 32982, 34506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 33154, 34495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33190, 33228);

                    const int
                    MaxWindowTitleLength = 1023
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33246, 33281);

                    const int
                    MinWindowTitleLength = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33301, 34480) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 33301, 34480);

                        if (
                        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33360, 34325) || true) && (f_112_33390_33402(value) >= MinWindowTitleLength && (DynAbs.Tracing.TraceSender.Expression_True(112, 33390, 33491) && f_112_33455_33467(value) <= MaxWindowTitleLength
                        ))
                                                )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 33360, 34325);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33567, 33611);

                            f_112_33567_33610(value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 33360, 34325);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 33360, 34325);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33661, 34325) || true) && (f_112_33665_33677(value) < MinWindowTitleLength)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 33661, 34325);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33750, 33861);

                                throw f_112_33756_33860("value", f_112_33800_33859());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(112, 33661, 34325);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 33661, 34325);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 33959, 34302);

                                throw f_112_33965_34301("value", f_112_34075_34212(), MaxWindowTitleLength);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(112, 33661, 34325);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 33360, 34325);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 33301, 34480);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 33301, 34480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 34407, 34461);

                        throw f_112_34413_34460("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 33301, 34480);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(112, 33154, 34495);

                    int
                    f_112_33390_33402(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 33390, 33402);
                        return return_v;
                    }


                    int
                    f_112_33455_33467(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 33455, 33467);
                        return return_v;
                    }


                    int
                    f_112_33567_33610(string
                    consoleTitle)
                    {
                        ConsoleControl.SetConsoleWindowTitle(consoleTitle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 33567, 33610);
                        return 0;
                    }


                    int
                    f_112_33665_33677(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 33665, 33677);
                        return return_v;
                    }


                    string
                    f_112_33800_33859()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings.WindowTitleTooShortError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 33800, 33859);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_112_33756_33860(string
                    paramName, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 33756, 33860);
                        return return_v;
                    }


                    string
                    f_112_34075_34212()
                    {
                        var return_v = ConsoleHostRawUserInterfaceStrings
                                                                                             .WindowTitleTooLongErrorTemplate;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 34075, 34212);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_112_33965_34301(string
                    paramName, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 33965, 34301);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentNullException
                    f_112_34413_34460(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 34413, 34460);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 32982, 34506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 32982, 34506);
                }
            }
        }

        public override
                void
                SetBufferContents(Coordinates origin, BufferCell[,] contents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 35576, 36334);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 35701, 35821) || true) && (contents == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 35701, 35821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 35755, 35806);

                    f_112_35755_35805("contents");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 35701, 35821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 35891, 35944);

                ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo
                = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 35960, 36013);

                ConsoleHandle
                handle = f_112_35983_36012(out bufferInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 36027, 36093);

                f_112_36027_36092(ref origin, ref bufferInfo, "origin");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 36263, 36323);

                f_112_36263_36322(handle, origin, contents);
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 35576, 36334);

                System.Management.Automation.PSArgumentNullException
                f_112_35755_35805(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 35755, 35805);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_112_35983_36012(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo)
                {
                    var return_v = GetBufferInfo(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 35983, 36012);
                    return return_v;
                }


                int
                f_112_36027_36092(ref System.Management.Automation.Host.Coordinates
                c, ref Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo, string
                paramName)
                {
                    CheckCoordinateWithinBuffer(ref c, ref bufferInfo, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 36027, 36092);
                    return 0;
                }


                int
                f_112_36263_36322(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ConsoleControl.WriteConsoleOutput(consoleHandle, origin, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 36263, 36322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 35576, 36334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 35576, 36334);
            }
        }

        public override
                void
                SetBufferContents(Rectangle region, BufferCell fill)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 37700, 44038);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 37860, 38126) || true) && (region.Right < region.Left)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 37860, 38126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 37924, 38111);

                    throw f_112_37930_38110("region", f_112_37996_38057(), "region.Right", "region.Left");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 37860, 38126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38142, 38408) || true) && (region.Bottom < region.Top)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 38142, 38408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38206, 38393);

                    throw f_112_38212_38392("region", f_112_38278_38339(), "region.Bottom", "region.Top");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 38142, 38408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38424, 38477);

                ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo
                = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38493, 38546);

                ConsoleHandle
                handle = f_112_38516_38545(out bufferInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38562, 38604);

                int
                bufferWidth = bufferInfo.BufferSize.X
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38618, 38661);

                int
                bufferHeight = bufferInfo.BufferSize.Y
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38675, 38763);

                WORD
                attribute = f_112_38692_38762(fill.ForegroundColor, fill.BackgroundColor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38777, 38820);

                Coordinates
                origin = f_112_38798_38819(0, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38834, 38848);

                uint
                codePage
                = default(uint);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 38959, 39645) || true) && (region.Left == -1 && (DynAbs.Tracing.TraceSender.Expression_True(112, 38963, 39002) && region.Right == -1) && (DynAbs.Tracing.TraceSender.Expression_True(112, 38963, 39022) && region.Top == -1) && (DynAbs.Tracing.TraceSender.Expression_True(112, 38963, 39045) && region.Bottom == -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 38959, 39645);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 39079, 39351) || true) && (bufferWidth % 2 == 1 && (DynAbs.Tracing.TraceSender.Expression_True(112, 39083, 39176) && f_112_39128_39176(out codePage)) && (DynAbs.Tracing.TraceSender.Expression_True(112, 39083, 39241) && f_112_39201_39236(this, fill.Character) == 2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 39079, 39351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 39283, 39332);

                        throw f_112_39289_39331("fill");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 39079, 39351);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 39371, 39410);

                    int
                    cells = bufferWidth * bufferHeight
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 39430, 39511);

                    f_112_39430_39510(handle, fill.Character, cells, origin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 39529, 39605);

                    f_112_39529_39604(handle, attribute, cells, origin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 39623, 39630);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 38959, 39645);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40084, 40374) || true) && (region.Left >= bufferWidth || (DynAbs.Tracing.TraceSender.Expression_False(112, 40088, 40144) || region.Top >= bufferHeight) || (DynAbs.Tracing.TraceSender.Expression_False(112, 40088, 40164) || region.Right < 0) || (DynAbs.Tracing.TraceSender.Expression_False(112, 40088, 40185) || region.Bottom < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 40084, 40374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40288, 40334);

                    f_112_40288_40333(                // region is entirely outside the buffer boundaries
                                    tracer, "region outside boundaries");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40352, 40359);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 40084, 40374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40390, 40431);

                int
                lineStart = f_112_40406_40430(0, region.Left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40445, 40499);

                int
                lineEnd = f_112_40459_40498(bufferWidth - 1, region.Right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40513, 40554);

                int
                lineLength = lineEnd - lineStart + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40570, 40591);

                origin.X = lineStart;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40607, 40646);

                int
                firstRow = f_112_40622_40645(0, region.Top)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40660, 40716);

                int
                lastRow = f_112_40674_40715(bufferHeight - 1, region.Bottom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40730, 40750);

                origin.Y = firstRow;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40766, 43531) || true) && (f_112_40770_40818(out codePage))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 40766, 43531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40852, 40922);

                    Rectangle
                    existingRegion = f_112_40879_40921(0, 0, 1, lastRow - firstRow)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 40940, 40993);

                    int
                    charLength = f_112_40957_40992(this, fill.Character)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41047, 41713) || true) && (origin.X > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 41047, 41713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41105, 41179);

                        BufferCell[,]
                        leftExisting = new BufferCell[existingRegion.Bottom + 1, 2]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41201, 41355);

                        f_112_41201_41354(handle, codePage, f_112_41280_41319(origin.X - 1, origin.Y), existingRegion, ref leftExisting);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41386, 41391);
                            for (int
        r = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41377, 41694) || true) && (r <= existingRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41421, 41424)
        , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(112, 41377, 41694))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 41377, 41694);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41474, 41671) || true) && (leftExisting[r, 0].BufferCellType == BufferCellType.Leading)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 41474, 41671);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41595, 41644);

                                    throw f_112_41601_41643("fill");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 41474, 41671);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 1, 318);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(112, 1, 318);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 41047, 41713);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41768, 43399) || true) && (lineEnd == bufferWidth - 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 41768, 43399);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41840, 41981) || true) && (charLength == 2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 41840, 41981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 41909, 41958);

                            throw f_112_41915_41957("fill");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 41840, 41981);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 41768, 43399);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 41768, 43399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42215, 42290);

                        BufferCell[,]
                        rightExisting = new BufferCell[existingRegion.Bottom + 1, 2]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42312, 42462);

                        f_112_42312_42461(handle, codePage, f_112_42391_42425(lineEnd, origin.Y), existingRegion, ref rightExisting);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42484, 43380) || true) && (lineLength % 2 == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 42484, 43380);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42566, 42571);
                                for (int
        r = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42557, 42899) || true) && (r <= existingRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42601, 42604)
        , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(112, 42557, 42899))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 42557, 42899);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42662, 42872) || true) && (rightExisting[r, 0].BufferCellType == BufferCellType.Leading)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 42662, 42872);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42792, 42841);

                                        throw f_112_42798_42840("fill");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 42662, 42872);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 1, 343);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(112, 1, 343);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 42484, 43380);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 42484, 43380);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43006, 43011);
                                for (int
        r = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 42997, 43357) || true) && (r <= existingRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43041, 43044)
        , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(112, 42997, 43357))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 42997, 43357);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43102, 43330) || true) && (rightExisting[r, 0].BufferCellType == BufferCellType.Leading ^ charLength == 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 43102, 43330);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43250, 43299);

                                        throw f_112_43256_43298("fill");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 43102, 43330);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 1, 361);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(112, 1, 361);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(112, 42484, 43380);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 41768, 43399);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43419, 43516) || true) && (lineLength % 2 == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 43419, 43516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43484, 43497);

                        lineLength++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(112, 43419, 43516);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 40766, 43531);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43556, 43570);

                    for (int
        row = firstRow
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43547, 44027) || true) && (row <= lastRow)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43588, 43593)
        , ++row, DynAbs.Tracing.TraceSender.TraceExitCondition(112, 43547, 44027))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 43547, 44027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43627, 43642);

                        origin.Y = row;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43827, 43913);

                        f_112_43827_43912(handle, fill.Character, lineLength, origin);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 43931, 44012);

                        f_112_43931_44011(handle, attribute, lineLength, origin);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(112, 1, 481);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(112, 1, 481);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 37700, 44038);

                string
                f_112_37996_38057()
                {
                    var return_v = ConsoleHostRawUserInterfaceStrings.InvalidRegionErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 37996, 38057);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_37930_38110(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 37930, 38110);
                    return return_v;
                }


                string
                f_112_38278_38339()
                {
                    var return_v = ConsoleHostRawUserInterfaceStrings.InvalidRegionErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 38278, 38339);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_38212_38392(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 38212, 38392);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_112_38516_38545(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo)
                {
                    var return_v = GetBufferInfo(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 38516, 38545);
                    return return_v;
                }


                ushort
                f_112_38692_38762(System.ConsoleColor
                foreground, System.ConsoleColor
                background)
                {
                    var return_v = ConsoleControl.ColorToWORD(foreground, background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 38692, 38762);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_112_38798_38819(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 38798, 38819);
                    return return_v;
                }


                bool
                f_112_39128_39176(out uint
                codePage)
                {
                    var return_v = ConsoleControl.IsCJKOutputCodePage(out codePage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 39128, 39176);
                    return return_v;
                }


                int
                f_112_39201_39236(Microsoft.PowerShell.ConsoleHostRawUserInterface
                this_param, char
                c)
                {
                    var return_v = this_param.LengthInBufferCells(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 39201, 39236);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_39289_39331(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 39289, 39331);
                    return return_v;
                }


                int
                f_112_39430_39510(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, char
                character, int
                numberToWrite, System.Management.Automation.Host.Coordinates
                origin)
                {
                    ConsoleControl.FillConsoleOutputCharacter(consoleHandle, character, numberToWrite, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 39430, 39510);
                    return 0;
                }


                int
                f_112_39529_39604(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, ushort
                attribute, int
                numberToWrite, System.Management.Automation.Host.Coordinates
                origin)
                {
                    ConsoleControl.FillConsoleOutputAttribute(consoleHandle, attribute, numberToWrite, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 39529, 39604);
                    return 0;
                }


                int
                f_112_40288_40333(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40288, 40333);
                    return 0;
                }


                int
                f_112_40406_40430(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40406, 40430);
                    return return_v;
                }


                int
                f_112_40459_40498(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40459, 40498);
                    return return_v;
                }


                int
                f_112_40622_40645(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40622, 40645);
                    return return_v;
                }


                int
                f_112_40674_40715(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40674, 40715);
                    return return_v;
                }


                bool
                f_112_40770_40818(out uint
                codePage)
                {
                    var return_v = ConsoleControl.IsCJKOutputCodePage(out codePage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40770, 40818);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_112_40879_40921(int
                left, int
                top, int
                right, int
                bottom)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(left, top, right, bottom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40879, 40921);
                    return return_v;
                }


                int
                f_112_40957_40992(Microsoft.PowerShell.ConsoleHostRawUserInterface
                this_param, char
                c)
                {
                    var return_v = this_param.LengthInBufferCells(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 40957, 40992);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_112_41280_41319(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 41280, 41319);
                    return return_v;
                }


                int
                f_112_41201_41354(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ConsoleControl.ReadConsoleOutputCJK(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 41201, 41354);
                    return 0;
                }


                System.Management.Automation.PSArgumentException
                f_112_41601_41643(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 41601, 41643);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_41915_41957(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 41915, 41957);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_112_42391_42425(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 42391, 42425);
                    return return_v;
                }


                int
                f_112_42312_42461(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ConsoleControl.ReadConsoleOutputCJK(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 42312, 42461);
                    return 0;
                }


                System.Management.Automation.PSArgumentException
                f_112_42798_42840(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 42798, 42840);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_43256_43298(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 43256, 43298);
                    return return_v;
                }


                int
                f_112_43827_43912(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, char
                character, int
                numberToWrite, System.Management.Automation.Host.Coordinates
                origin)
                {
                    ConsoleControl.FillConsoleOutputCharacter(consoleHandle, character, numberToWrite, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 43827, 43912);
                    return 0;
                }


                int
                f_112_43931_44011(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, ushort
                attribute, int
                numberToWrite, System.Management.Automation.Host.Coordinates
                origin)
                {
                    ConsoleControl.FillConsoleOutputAttribute(consoleHandle, attribute, numberToWrite, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 43931, 44011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 37700, 44038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 37700, 44038);
            }
        }

        public override
                BufferCell[,] GetBufferContents(Rectangle region)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 44930, 47323);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45073, 45339) || true) && (region.Right < region.Left)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 45073, 45339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45137, 45324);

                    throw f_112_45143_45323("region", f_112_45209_45270(), "region.Right", "region.Left");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 45073, 45339);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45355, 45621) || true) && (region.Bottom < region.Top)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 45355, 45621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45419, 45606);

                    throw f_112_45425_45605("region", f_112_45491_45552(), "region.Bottom", "region.Top");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 45355, 45621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45637, 45690);

                ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo
                = default(ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45706, 45759);

                ConsoleHandle
                handle = f_112_45729_45758(out bufferInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45773, 45815);

                int
                bufferWidth = bufferInfo.BufferSize.X
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45829, 45872);

                int
                bufferHeight = bufferInfo.BufferSize.Y
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 45888, 46199) || true) && (region.Left >= bufferWidth || (DynAbs.Tracing.TraceSender.Expression_False(112, 45892, 45948) || region.Top >= bufferHeight) || (DynAbs.Tracing.TraceSender.Expression_False(112, 45892, 45968) || region.Right < 0) || (DynAbs.Tracing.TraceSender.Expression_False(112, 45892, 45989) || region.Bottom < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 45888, 46199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46092, 46138);

                    f_112_46092_46137(                // region is entirely outside the buffer boundaries
                                    tracer, "region outside boundaries");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46156, 46184);

                    return new BufferCell[0, 0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 45888, 46199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46215, 46255);

                int
                colStart = f_112_46230_46254(0, region.Left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46269, 46322);

                int
                colEnd = f_112_46282_46321(bufferWidth - 1, region.Right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46336, 46375);

                int
                rowStart = f_112_46351_46374(0, region.Top)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46389, 46444);

                int
                rowEnd = f_112_46402_46443(bufferHeight - 1, region.Bottom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46458, 46515);

                Coordinates
                origin = f_112_46479_46514(colStart, rowStart)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46683, 46726);

                Rectangle
                contentsRegion = f_112_46710_46725()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46740, 46791);

                contentsRegion.Left = f_112_46762_46790(0, 0 - region.Left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46805, 46854);

                contentsRegion.Top = f_112_46826_46853(0, 0 - region.Top);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46868, 46933);

                contentsRegion.Right = contentsRegion.Left + (colEnd - colStart);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 46947, 47012);

                contentsRegion.Bottom = contentsRegion.Top + (rowEnd - rowStart);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 47028, 47185);

                BufferCell[,]
                contents = new BufferCell[region.Bottom - region.Top + 1,
                                                                    region.Right - region.Left + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 47201, 47280);

                f_112_47201_47279(handle, origin, contentsRegion, ref contents);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 47296, 47312);

                return contents;
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 44930, 47323);

                string
                f_112_45209_45270()
                {
                    var return_v = ConsoleHostRawUserInterfaceStrings.InvalidRegionErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 45209, 45270);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_45143_45323(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 45143, 45323);
                    return return_v;
                }


                string
                f_112_45491_45552()
                {
                    var return_v = ConsoleHostRawUserInterfaceStrings.InvalidRegionErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 45491, 45552);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_112_45425_45605(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 45425, 45605);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_112_45729_45758(out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo)
                {
                    var return_v = GetBufferInfo(out bufferInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 45729, 45758);
                    return return_v;
                }


                int
                f_112_46092_46137(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46092, 46137);
                    return 0;
                }


                int
                f_112_46230_46254(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46230, 46254);
                    return return_v;
                }


                int
                f_112_46282_46321(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46282, 46321);
                    return return_v;
                }


                int
                f_112_46351_46374(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46351, 46374);
                    return return_v;
                }


                int
                f_112_46402_46443(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46402, 46443);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_112_46479_46514(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46479, 46514);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_112_46710_46725()
                {
                    var return_v = new System.Management.Automation.Host.Rectangle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46710, 46725);
                    return return_v;
                }


                int
                f_112_46762_46790(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46762, 46790);
                    return return_v;
                }


                int
                f_112_46826_46853(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 46826, 46853);
                    return return_v;
                }


                int
                f_112_47201_47279(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ConsoleControl.ReadConsoleOutput(consoleHandle, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 47201, 47279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 44930, 47323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 44930, 47323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                void
                ScrollBufferContents
                (
                    Rectangle source,
                    Coordinates destination,
                    Rectangle clip,
                    BufferCell fill
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 48066, 49520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48299, 48341);

                ConsoleControl.SMALL_RECT
                scrollRectangle
                = default(ConsoleControl.SMALL_RECT);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48355, 48397);

                scrollRectangle.Left = (short)source.Left;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48411, 48455);

                scrollRectangle.Right = (short)source.Right;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48469, 48509);

                scrollRectangle.Top = (short)source.Top;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48523, 48569);

                scrollRectangle.Bottom = (short)source.Bottom;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48585, 48625);

                ConsoleControl.SMALL_RECT
                clipRectangle
                = default(ConsoleControl.SMALL_RECT);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48639, 48677);

                clipRectangle.Left = (short)clip.Left;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48691, 48731);

                clipRectangle.Right = (short)clip.Right;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48745, 48781);

                clipRectangle.Top = (short)clip.Top;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48795, 48837);

                clipRectangle.Bottom = (short)clip.Bottom;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48853, 48881);

                ConsoleControl.COORD
                origin
                = default(ConsoleControl.COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48895, 48927);

                origin.X = (short)destination.X;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48941, 48973);

                origin.Y = (short)destination.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 48989, 49023);

                ConsoleControl.CHAR_INFO
                fillChar
                = default(ConsoleControl.CHAR_INFO);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 49039, 49077);

                fillChar.UnicodeChar = fill.Character;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 49091, 49184);

                fillChar.Attributes = f_112_49113_49183(fill.ForegroundColor, fill.BackgroundColor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 49200, 49275);

                ConsoleHandle
                consoleHandle = f_112_49230_49274()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 49289, 49509);

                f_112_49289_49508(consoleHandle, scrollRectangle, clipRectangle, origin, fillChar);
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 48066, 49520);

                ushort
                f_112_49113_49183(System.ConsoleColor
                foreground, System.ConsoleColor
                background)
                {
                    var return_v = ConsoleControl.ColorToWORD(foreground, background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 49113, 49183);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_112_49230_49274()
                {
                    var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 49230, 49274);
                    return return_v;
                }


                int
                f_112_49289_49508(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                scrollRectangle, Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                clipRectangle, Microsoft.PowerShell.ConsoleControl.COORD
                destOrigin, Microsoft.PowerShell.ConsoleControl.CHAR_INFO
                fill)
                {
                    ConsoleControl.ScrollConsoleScreenBuffer(consoleHandle, scrollRectangle, clipRectangle, destOrigin, fill);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 49289, 49508);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 48066, 49520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 48066, 49520);
            }
        }

        public override
                int LengthInBufferCells(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 49803, 49935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 49886, 49924);

                return f_112_49893_49923(this, s, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 49803, 49935);

                int
                f_112_49893_49923(Microsoft.PowerShell.ConsoleHostRawUserInterface
                this_param, string
                s, int
                offset)
                {
                    var return_v = this_param.LengthInBufferCells(s, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 49893, 49923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 49803, 49935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 49803, 49935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int LengthInBufferCells(string s, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 50261, 50582);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 50356, 50470) || true) && (s == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 50356, 50470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 50403, 50455);

                    throw f_112_50409_50454("str");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 50356, 50470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 50486, 50571);

                return f_112_50493_50570(s, offset, f_112_50539_50569(parent));
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 50261, 50582);

                System.Management.Automation.PSArgumentNullException
                f_112_50409_50454(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 50409, 50454);
                    return return_v;
                }


                bool
                f_112_50539_50569(Microsoft.PowerShell.ConsoleHostUserInterface
                this_param)
                {
                    var return_v = this_param.SupportsVirtualTerminal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 50539, 50569);
                    return return_v;
                }


                int
                f_112_50493_50570(string
                str, int
                offset, bool
                checkEscapeSequences)
                {
                    var return_v = ConsoleControl.LengthInBufferCells(str, offset, checkEscapeSequences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 50493, 50570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 50261, 50582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 50261, 50582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int LengthInBufferCells(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 50865, 51002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 50946, 50991);

                return f_112_50953_50990(c);
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 50865, 51002);

                int
                f_112_50953_50990(char
                c)
                {
                    var return_v = ConsoleControl.LengthInBufferCells(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 50953, 50990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 50865, 51002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 50865, 51002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ClearKeyCache()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(112, 51153, 51249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 51207, 51238);

                cachedKeyEvent.RepeatCount = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(112, 51153, 51249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 51153, 51249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 51153, 51249);
            }
        }

        private static
                void
                CheckCoordinateWithinBuffer(ref Coordinates c, ref ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO bufferInfo, string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(112, 51692, 52554);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 51877, 52202) || true) && (c.X < 0 || (DynAbs.Tracing.TraceSender.Expression_False(112, 51881, 51921) || c.X > bufferInfo.BufferSize.X))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 51877, 52202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 51955, 52187);

                    throw f_112_51961_52186(paramName + ".X", c.X, f_112_52093_52162(), bufferInfo.BufferSize);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 51877, 52202);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 52218, 52543) || true) && (c.Y < 0 || (DynAbs.Tracing.TraceSender.Expression_False(112, 52222, 52262) || c.Y > bufferInfo.BufferSize.Y))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(112, 52218, 52543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 52296, 52528);

                    throw f_112_52302_52527(paramName + ".Y", c.Y, f_112_52434_52503(), bufferInfo.BufferSize);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(112, 52218, 52543);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(112, 51692, 52554);

                string
                f_112_52093_52162()
                {
                    var return_v = ConsoleHostRawUserInterfaceStrings.CoordinateOutOfBufferErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 52093, 52162);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_112_51961_52186(string
                paramName, int
                actualValue, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 51961, 52186);
                    return return_v;
                }


                string
                f_112_52434_52503()
                {
                    var return_v = ConsoleHostRawUserInterfaceStrings.CoordinateOutOfBufferErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 52434, 52503);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_112_52302_52527(string
                paramName, int
                actualValue, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 52302, 52527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 51692, 52554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 51692, 52554);
            }
        }

        private static
                ConsoleHandle
                GetBufferInfo(out ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO bufferInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(112, 52919, 53246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 53062, 53130);

                ConsoleHandle
                result = f_112_53085_53129()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 53144, 53207);

                bufferInfo = f_112_53157_53206(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 53221, 53235);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(112, 52919, 53246);

                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_112_53085_53129()
                {
                    var return_v = ConsoleControl.GetActiveScreenBufferHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 53085, 53129);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                f_112_53157_53206(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = ConsoleControl.GetConsoleScreenBufferInfo(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 53157, 53206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(112, 52919, 53246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 52919, 53246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConsoleColor defaultForeground;

        private ConsoleColor defaultBackground;

        private ConsoleHostUserInterface parent;

        private ConsoleControl.KEY_EVENT_RECORD cachedKeyEvent;

        [TraceSourceAttribute("ConsoleHostRawUserInterface", "Console host's subclass of S.M.A.Host.RawConsole")]
        private static
                PSTraceSource tracer;

        static ConsoleHostRawUserInterface()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(112, 733, 53833);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(112, 53710, 53825);
            tracer = f_112_53719_53825("ConsoleHostRawUserInterface", "Console host's subclass of S.M.A.Host.RawConsole");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(112, 733, 53833);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(112, 733, 53833);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(112, 733, 53833);

        System.ConsoleColor
        f_112_1198_1213()
        {
            var return_v = ForegroundColor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 1198, 1213);
            return return_v;
        }


        System.ConsoleColor
        f_112_1248_1263()
        {
            var return_v = BackgroundColor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 1248, 1263);
            return return_v;
        }


        System.Security.Principal.WindowsIdentity
        f_112_1658_1686()
        {
            var return_v = WindowsIdentity.GetCurrent();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 1658, 1686);
            return return_v;
        }


        System.Security.Principal.WindowsPrincipal
        f_112_1734_1764(System.Security.Principal.WindowsIdentity
        ntIdentity)
        {
            var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 1734, 1764);
            return return_v;
        }


        bool
        f_112_1787_1839(System.Security.Principal.WindowsPrincipal
        this_param, System.Security.Principal.WindowsBuiltInRole
        role)
        {
            var return_v = this_param.IsInRole(role);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 1787, 1839);
            return return_v;
        }


        string
        f_112_1897_1957()
        {
            var return_v = ConsoleHostRawUserInterfaceStrings.WindowTitleElevatedPrefix;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 1897, 1957);
            return return_v;
        }


        string
        f_112_2157_2211()
        {
            var return_v = ConsoleHostRawUserInterfaceStrings.WindowTitleTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 2157, 2211);
            return return_v;
        }


        string
        f_112_2249_2275(string
        str)
        {
            var return_v = Regex.Escape(str);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 2249, 2275);
            return return_v;
        }


        string
        f_112_2249_2324(string
        this_param, string
        oldValue, string
        newValue)
        {
            var return_v = this_param.Replace(oldValue, newValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 2249, 2324);
            return return_v;
        }


        string
        f_112_2368_2388(string
        str)
        {
            var return_v = Regex.Escape(str);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 2368, 2388);
            return return_v;
        }


        string
        f_112_2249_2389(string
        this_param, string
        oldValue, string
        newValue)
        {
            var return_v = this_param.Replace(oldValue, newValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 2249, 2389);
            return return_v;
        }


        string
        f_112_2431_2447(Microsoft.PowerShell.ConsoleHostRawUserInterface
        this_param)
        {
            var return_v = this_param.WindowTitle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 2431, 2447);
            return return_v;
        }


        bool
        f_112_2417_2462(string
        input, string
        pattern)
        {
            var return_v = Regex.IsMatch(input, pattern);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 2417, 2462);
            return return_v;
        }


        string
        f_112_2549_2603()
        {
            var return_v = ConsoleHostRawUserInterfaceStrings.WindowTitleTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 2549, 2603);
            return return_v;
        }


        string
        f_112_2671_2687(Microsoft.PowerShell.ConsoleHostRawUserInterface
        this_param)
        {
            var return_v = this_param.WindowTitle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(112, 2671, 2687);
            return return_v;
        }


        string
        f_112_2531_2688(string
        formatSpec, string
        o1, string
        o2)
        {
            var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 2531, 2688);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_112_53719_53825(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(112, 53719, 53825);
            return return_v;
        }

    }
}   // namespace

