// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.


// Implementation notes: In the functions that take ConsoleHandle parameters, we only assert that the handle is valid and not
// closed, as opposed to doing a check and throwing an exception.  This is because the win32 APIs that those functions wrap will
// fail on invalid/closed handles, and the check for API failure will throw the exception.
//
// On the use of DangerousGetHandle: If the handle has been invalidated, then the API we pass it to will return an error.  These
// handles should not be exposed to recycling attacks (because they are not exposed at all), but if they were, the worse they
// could do is diddle with the console buffer.
#pragma warning disable 1634, 1691

using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.ComponentModel;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;
using Microsoft.Win32.SafeHandles;

using ConsoleHandle = Microsoft.Win32.SafeHandles.SafeFileHandle;

using WORD = System.UInt16;
using ULONG = System.UInt32;
using DWORD = System.UInt32;
using NakedWin32Handle = System.IntPtr;
using HWND = System.IntPtr;
using HDC = System.IntPtr;


using System.Diagnostics.CodeAnalysis;
using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
    internal static class ConsoleControl
    {
        internal enum InputRecordEventTypes : ushort
        {
            // from wincon.h.  These look like bit flags, but of course they could not really be used that way, since it would
            // not make sense to have more than one of the INPUT_RECORD union members "in effect" at any one time.

            KEY_EVENT = 0x0001,
            MOUSE_EVENT = 0x0002,
            WINDOW_BUFFER_SIZE_EVENT = 0x0004,
            MENU_EVENT = 0x0008,
            FOCUS_EVENT = 0x0010
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct INPUT_RECORD
        {

            internal WORD EventType;

            internal KEY_EVENT_RECORD KeyEvent;
            static INPUT_RECORD()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 2382, 2566);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 2382, 2566);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 2382, 2566);
            }
        }

        [Flags]
        internal enum ControlKeyStates : uint
        {
            // From wincon.h.
            RIGHT_ALT_PRESSED = 0x0001, // the right alt key is pressed.
            LEFT_ALT_PRESSED = 0x0002, // the left alt key is pressed.
            RIGHT_CTRL_PRESSED = 0x0004, // the right ctrl key is pressed.
            LEFT_CTRL_PRESSED = 0x0008, // the left ctrl key is pressed.
            SHIFT_PRESSED = 0x0010, // the shift key is pressed.
            NUMLOCK_ON = 0x0020, // the numlock light is on.
            SCROLLLOCK_ON = 0x0040, // the scrolllock light is on.
            CAPSLOCK_ON = 0x0080, // the capslock light is on.
            ENHANCED_KEY = 0x0100  // the key is enhanced.
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct KEY_EVENT_RECORD
        {

            internal bool KeyDown;

            internal WORD RepeatCount;

            internal WORD VirtualKeyCode;

            internal WORD VirtualScanCode;

            internal char UnicodeChar;

            internal DWORD ControlKeyState;
            static KEY_EVENT_RECORD()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 3353, 3712);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 3353, 3712);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 3353, 3712);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct COORD
        {

            internal short X;

            internal short Y;

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 3883, 4032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 3949, 4017);

                    return f_110_3956_4016(f_110_3970_3998(), "{0},{1}", X, Y);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 3883, 4032);

                    System.Globalization.CultureInfo
                    f_110_3970_3998()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 3970, 3998);
                        return return_v;
                    }


                    string
                    f_110_3956_4016(System.Globalization.CultureInfo
                    provider, string
                    format, short
                    arg0, short
                    arg1)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 3956, 4016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 3883, 4032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 3883, 4032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static COORD()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 3724, 4043);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 3724, 4043);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 3724, 4043);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CONSOLE_READCONSOLE_CONTROL
        {

            internal ULONG nLength;

            internal ULONG nInitialChars;

            internal ULONG dwCtrlWakeupMask;

            internal /* out */ ULONG dwControlKeyState;
            static CONSOLE_READCONSOLE_CONTROL()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 4055, 4415);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 4055, 4415);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 4055, 4415);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct CONSOLE_FONT_INFO_EX
        {

            internal int cbSize;

            internal int nFont;

            internal short FontWidth;

            internal short FontHeight;

            internal int FontFamily;

            internal int FontWeight;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            internal string FontFace;
            static CONSOLE_FONT_INFO_EX()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 4427, 4886);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 4427, 4886);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 4427, 4886);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CHAR_INFO
        {

            internal ushort UnicodeChar;

            internal WORD Attributes;
            static CHAR_INFO()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 4898, 5075);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 4898, 5075);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 4898, 5075);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct SMALL_RECT
        {

            internal short Left;

            internal short Top;

            internal short Right;

            internal short Bottom;

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 5331, 5508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 5397, 5493);

                    return f_110_5404_5492(f_110_5418_5446(), "{0},{1},{2},{3}", Left, Top, Right, Bottom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 5331, 5508);

                    System.Globalization.CultureInfo
                    f_110_5418_5446()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 5418, 5446);
                        return return_v;
                    }


                    string
                    f_110_5404_5492(System.Globalization.CultureInfo
                    provider, string
                    format, params object?[]
                    args)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 5404, 5492);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 5331, 5508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 5331, 5508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static SMALL_RECT()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 5087, 5519);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 5087, 5519);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 5087, 5519);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CONSOLE_SCREEN_BUFFER_INFO
        {

            internal COORD BufferSize;

            internal COORD CursorPosition;

            internal WORD Attributes;

            internal SMALL_RECT WindowRect;

            internal COORD MaxWindowSize;

            internal DWORD Padding;
            static CONSOLE_SCREEN_BUFFER_INFO()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 5531, 6038);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 5531, 6038);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 5531, 6038);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CONSOLE_CURSOR_INFO
        {

            internal DWORD Size;

            internal bool Visible;

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(110, 6231, 6405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 6297, 6390);

                    return f_110_6304_6389(f_110_6318_6346(), "Size: {0}, Visible: {1}", Size, Visible);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(110, 6231, 6405);

                    System.Globalization.CultureInfo
                    f_110_6318_6346()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 6318, 6346);
                        return return_v;
                    }


                    string
                    f_110_6304_6389(System.Globalization.CultureInfo
                    provider, string
                    format, uint
                    arg0, bool
                    arg1)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 6304, 6389);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 6231, 6405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 6231, 6405);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static CONSOLE_CURSOR_INFO()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 6050, 6416);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 6050, 6416);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 6050, 6416);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct FONTSIGNATURE
        {

            internal DWORD fsUsb0;

            internal DWORD fsUsb1;

            internal DWORD fsUsb2;

            internal DWORD fsUsb3;

            internal DWORD fsCsb0;

            internal DWORD fsCsb1;
            static FONTSIGNATURE()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 6428, 7007);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 6428, 7007);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 6428, 7007);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CHARSETINFO
        {

            internal uint ciCharset;

            internal uint ciACP;

            internal FONTSIGNATURE fs;
            static CHARSETINFO()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 7019, 7334);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 7019, 7334);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 7019, 7334);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TEXTMETRIC
        {

            public int tmHeight;

            public int tmAscent;

            public int tmDescent;

            public int tmInternalLeading;

            public int tmExternalLeading;

            public int tmAveCharWidth;

            public int tmMaxCharWidth;

            public int tmWeight;

            public int tmOverhang;

            public int tmDigitizedAspectX;

            public int tmDigitizedAspectY;

            public char tmFirstChar;

            public char tmLastChar;

            public char tmDefaultChar;

            public char tmBreakChar;

            public byte tmItalic;

            public byte tmUnderlined;

            public byte tmStruckOut;

            public byte tmPitchAndFamily;

            public byte tmCharSet;
            static TEXTMETRIC()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 7346, 8284);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 7346, 8284);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 7346, 8284);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct INPUT
        {

            internal DWORD Type;

            internal MouseKeyboardHardwareInput Data;
            static INPUT()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 8341, 8520);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 8341, 8520);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 8341, 8520);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MouseKeyboardHardwareInput
        {

            [FieldOffset(0)]
            internal MouseInput Mouse;

            [FieldOffset(0)]
            internal KeyboardInput Keyboard;

            [FieldOffset(0)]
            internal HardwareInput Hardware;
            static MouseKeyboardHardwareInput()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 8532, 8867);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 8532, 8867);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 8532, 8867);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MouseInput
        {

            internal Int32 X;

            internal Int32 Y;

            internal DWORD MouseData;

            internal DWORD Flags;

            internal DWORD Time;

            internal IntPtr ExtraInfo;
            static MouseInput()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 8879, 10931);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 8879, 10931);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 8879, 10931);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct KeyboardInput
        {

            internal WORD Vk;

            internal WORD Scan;

            internal DWORD Flags;

            internal DWORD Time;

            internal IntPtr ExtraInfo;
            static KeyboardInput()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 10943, 12303);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 10943, 12303);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 10943, 12303);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct HardwareInput
        {

            internal DWORD Msg;

            internal WORD ParamL;

            internal WORD ParamH;
            static HardwareInput()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 12315, 12888);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 12315, 12888);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 12315, 12888);
            }
        }

        internal enum VirtualKeyCode : ushort
        {
            /// <summary>
            /// LEFT ARROW key.
            /// </summary>
            Left = 0x25,

            /// <summary>
            /// ENTER key.
            /// </summary>
            Return = 0x0D,
        }

        /// <summary>
        /// Specify the type of the input.
        /// </summary>
        internal enum InputType : uint
        {
            /// <summary>
            /// INPUT_MOUSE = 0x00.
            /// </summary>
            Mouse = 0,

            /// <summary>
            /// INPUT_KEYBOARD = 0x01.
            /// </summary>
            Keyboard = 1,

            /// <summary>
            /// INPUT_HARDWARE = 0x02.
            /// </summary>
            Hardware = 2,
        }

        internal enum KeyboardFlag : uint
        {
            /// <summary>
            /// If specified, the scan code was preceded by a prefix byte that has the value 0xE0 (224).
            /// </summary>
            ExtendedKey = 0x0001,

            /// <summary>
            /// If specified, the key is being released. If not specified, the key is being pressed.
            /// </summary>
            KeyUp = 0x0002,

            /// <summary>
            /// If specified, wScan identifies the key and wVk is ignored.
            /// </summary>
            Unicode = 0x0004,

            /// <summary>
            /// If specified, the system synthesizes a VK_PACKET keystroke. The wVk parameter must be zero.
            /// This flag can only be combined with the KEYEVENTF_KEYUP flag.
            /// </summary>
            ScanCode = 0x0008
        }

        [DllImport(PinvokeDllNames.GetConsoleWindowDllName)]
        internal static extern IntPtr GetConsoleWindow();

        internal const int
        SW_HIDE = 0
        ;

        internal const int
        SW_SHOWNORMAL = 1
        ;

        internal const int
        SW_NORMAL = 1
        ;

        internal const int
        SW_SHOWMINIMIZED = 2
        ;

        internal const int
        SW_SHOWMAXIMIZED = 3
        ;

        internal const int
        SW_MAXIMIZE = 3
        ;

        internal const int
        SW_SHOWNOACTIVATE = 4
        ;

        internal const int
        SW_SHOW = 5
        ;

        internal const int
        SW_MINIMIZE = 6
        ;

        internal const int
        SW_SHOWMINNOACTIVE = 7
        ;

        internal const int
        SW_SHOWNA = 8
        ;

        internal const int
        SW_RESTORE = 9
        ;

        internal const int
        SW_SHOWDEFAULT = 10
        ;

        internal const int
        SW_FORCEMINIMIZE = 11
        ;

        internal const int
        SW_MAX = 11
        ;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ShowWindow(IntPtr hWnd, Int32 nCmdShow);

        internal static void SetConsoleMode(ProcessWindowStyle style)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 16016, 16805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 16102, 16135);

                IntPtr
                hwnd = f_110_16116_16134()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 16149, 16220);

                f_110_16149_16219(hwnd != IntPtr.Zero, "Console handle should never be zero");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 16234, 16794);

                switch (style)
                {

                    case ProcessWindowStyle.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 16234, 16794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 16334, 16360);

                        f_110_16334_16359(hwnd, SW_HIDE);
                        DynAbs.Tracing.TraceSender.TraceBreak(110, 16382, 16388);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 16234, 16794);

                    case ProcessWindowStyle.Maximized:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 16234, 16794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 16462, 16492);

                        f_110_16462_16491(hwnd, SW_MAXIMIZE);
                        DynAbs.Tracing.TraceSender.TraceBreak(110, 16514, 16520);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 16234, 16794);

                    case ProcessWindowStyle.Minimized:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 16234, 16794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 16594, 16624);

                        f_110_16594_16623(hwnd, SW_MINIMIZE);
                        DynAbs.Tracing.TraceSender.TraceBreak(110, 16646, 16652);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 16234, 16794);

                    case ProcessWindowStyle.Normal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 16234, 16794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 16723, 16751);

                        f_110_16723_16750(hwnd, SW_NORMAL);
                        DynAbs.Tracing.TraceSender.TraceBreak(110, 16773, 16779);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 16234, 16794);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 16016, 16805);

                System.IntPtr
                f_110_16116_16134()
                {
                    var return_v = GetConsoleWindow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 16116, 16134);
                    return return_v;
                }


                int
                f_110_16149_16219(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 16149, 16219);
                    return 0;
                }


                bool
                f_110_16334_16359(System.IntPtr
                hWnd, int
                nCmdShow)
                {
                    var return_v = ShowWindow(hWnd, nCmdShow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 16334, 16359);
                    return return_v;
                }


                bool
                f_110_16462_16491(System.IntPtr
                hWnd, int
                nCmdShow)
                {
                    var return_v = ShowWindow(hWnd, nCmdShow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 16462, 16491);
                    return return_v;
                }


                bool
                f_110_16594_16623(System.IntPtr
                hWnd, int
                nCmdShow)
                {
                    var return_v = ShowWindow(hWnd, nCmdShow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 16594, 16623);
                    return return_v;
                }


                bool
                f_110_16723_16750(System.IntPtr
                hWnd, int
                nCmdShow)
                {
                    var return_v = ShowWindow(hWnd, nCmdShow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 16723, 16750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 16016, 16805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 16016, 16805);
            }
        }


        /// <summary>
        /// Types of control ConsoleBreakSignals received by break Win32Handler delegates.
        /// </summary>

        internal enum ConsoleBreakSignal : uint
        {
            // These correspond to the CRTL_XXX_EVENT #defines in public/sdk/inc/wincon.h

            CtrlC = 0,
            CtrlBreak = 1,
            Close = 2,
            Logoff = 5,

            // This only gets received by services

            Shutdown = 6,

            // None is not really a signal -- it's used to indicate that no signal exists.

            None = 0xFF
        }

        // NOTE: this delegate will be executed in its own thread

        internal delegate bool BreakHandler(ConsoleBreakSignal ConsoleBreakSignal);

        internal static void AddBreakHandler(BreakHandler handlerDelegate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 17944, 18460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18035, 18108);

                bool
                result = f_110_18049_18107(handlerDelegate, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18124, 18449) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 18124, 18449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18177, 18215);

                    int
                    err = f_110_18187_18214()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18235, 18408);

                    HostException
                    e = f_110_18253_18407(err, "AddBreakHandler", ErrorCategory.ResourceUnavailable, f_110_18353_18406())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18426, 18434);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 18124, 18449);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 17944, 18460);

                bool
                f_110_18049_18107(Microsoft.PowerShell.ConsoleControl.BreakHandler
                handlerRoutine, bool
                add)
                {
                    var return_v = NativeMethods.SetConsoleCtrlHandler(handlerRoutine, add);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 18049, 18107);
                    return return_v;
                }


                int
                f_110_18187_18214()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 18187, 18214);
                    return return_v;
                }


                string
                f_110_18353_18406()
                {
                    var return_v = ConsoleControlStrings.AddBreakHandlerExceptionMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 18353, 18406);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_18253_18407(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 18253, 18407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 17944, 18460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 17944, 18460);
            }
        }

        internal static void RemoveBreakHandler()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 18699, 19187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18765, 18828);

                bool
                result = f_110_18779_18827(null, false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18844, 19176) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 18844, 19176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18897, 18935);

                    int
                    err = f_110_18907_18934()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 18955, 19135);

                    HostException
                    e = f_110_18973_19134(err, "RemoveBreakHandler", ErrorCategory.ResourceUnavailable, f_110_19076_19133())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 19153, 19161);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 18844, 19176);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 18699, 19187);

                bool
                f_110_18779_18827(Microsoft.PowerShell.ConsoleControl.BreakHandler
                handlerRoutine, bool
                add)
                {
                    var return_v = NativeMethods.SetConsoleCtrlHandler(handlerRoutine, add);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 18779, 18827);
                    return return_v;
                }


                int
                f_110_18907_18934()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 18907, 18934);
                    return return_v;
                }


                string
                f_110_19076_19133()
                {
                    var return_v = ConsoleControlStrings.RemoveBreakHandlerExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 19076, 19133);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_18973_19134(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 18973, 19134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 18699, 19187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 18699, 19187);
            }
        }

        private static readonly Lazy<ConsoleHandle> _keyboardInputHandle;

        internal static ConsoleHandle GetConioDeviceHandle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 20545, 20667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 20622, 20656);

                return f_110_20629_20655(_keyboardInputHandle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 20545, 20667);

                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_110_20629_20655(System.Lazy<Microsoft.Win32.SafeHandles.SafeFileHandle>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 20629, 20655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 20545, 20667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 20545, 20667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Lazy<ConsoleHandle> _outputHandle;

        internal static ConsoleHandle GetActiveScreenBufferHandle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 22183, 22305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 22267, 22294);

                return f_110_22274_22293(_outputHandle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 22183, 22305);

                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_110_22274_22293(System.Lazy<Microsoft.Win32.SafeHandles.SafeFileHandle>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 22274, 22293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 22183, 22305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 22183, 22305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }



        /// <summary>
        /// Flags used by ConsoleControl.GetMode and ConsoleControl.SetMode.
        /// </summary>
        [Flags]
        internal enum ConsoleModes : uint
        {
            // These values from wincon.h
            // input modes
            ProcessedInput = 0x001,
            LineInput = 0x002,
            EchoInput = 0x004,
            WindowInput = 0x008,
            MouseInput = 0x010,
            Insert = 0x020,
            QuickEdit = 0x040,
            Extended = 0x080,
            AutoPosition = 0x100,
            // output modes
            ProcessedOutput = 0x001,  // yes, I know they are the same values as some flags defined above.
            WrapEndOfLine = 0x002,
            VirtualTerminal = 0x004,
            // Error getting console mode
            Unknown = 0xffffffff,
        }

        internal static ConsoleModes GetMode(ConsoleHandle consoleHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 23491, 24237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 23581, 23648);

                f_110_23581_23647(f_110_23592_23616_M(!consoleHandle.IsInvalid), "consoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 23662, 23725);

                f_110_23662_23724(f_110_23673_23696_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 23741, 23754);

                UInt32
                m = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 23768, 23854);

                bool
                result = f_110_23782_23853(f_110_23811_23845(consoleHandle), out m)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 23870, 24187) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 23870, 24187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 23923, 23961);

                    int
                    err = f_110_23933_23960()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 23981, 24146);

                    HostException
                    e = f_110_23999_24145(err, "GetConsoleMode", ErrorCategory.ResourceUnavailable, f_110_24098_24144())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 24164, 24172);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 23870, 24187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 24203, 24226);

                return (ConsoleModes)m;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 23491, 24237);

                bool
                f_110_23592_23616_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 23592, 23616);
                    return return_v;
                }


                int
                f_110_23581_23647(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 23581, 23647);
                    return 0;
                }


                bool
                f_110_23673_23696_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 23673, 23696);
                    return return_v;
                }


                int
                f_110_23662_23724(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 23662, 23724);
                    return 0;
                }


                System.IntPtr
                f_110_23811_23845(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 23811, 23845);
                    return return_v;
                }


                bool
                f_110_23782_23853(System.IntPtr
                consoleHandle, out uint
                mode)
                {
                    var return_v = NativeMethods.GetConsoleMode(consoleHandle, out mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 23782, 23853);
                    return return_v;
                }


                int
                f_110_23933_23960()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 23933, 23960);
                    return return_v;
                }


                string
                f_110_24098_24144()
                {
                    var return_v = ConsoleControlStrings.GetModeExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 24098, 24144);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_23999_24145(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 23999, 24145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 23491, 24237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 23491, 24237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetMode(ConsoleHandle consoleHandle, ConsoleModes mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 24693, 25390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 24794, 24861);

                f_110_24794_24860(f_110_24805_24829_M(!consoleHandle.IsInvalid), "consoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 24875, 24938);

                f_110_24875_24937(f_110_24886_24909_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 24954, 25046);

                bool
                result = f_110_24968_25045(f_110_24997_25031(consoleHandle), mode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 25062, 25379) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 25062, 25379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 25115, 25153);

                    int
                    err = f_110_25125_25152()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 25173, 25338);

                    HostException
                    e = f_110_25191_25337(err, "SetConsoleMode", ErrorCategory.ResourceUnavailable, f_110_25290_25336())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 25356, 25364);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 25062, 25379);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 24693, 25390);

                bool
                f_110_24805_24829_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 24805, 24829);
                    return return_v;
                }


                int
                f_110_24794_24860(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 24794, 24860);
                    return 0;
                }


                bool
                f_110_24886_24909_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 24886, 24909);
                    return return_v;
                }


                int
                f_110_24875_24937(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 24875, 24937);
                    return 0;
                }


                System.IntPtr
                f_110_24997_25031(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 24997, 25031);
                    return return_v;
                }


                bool
                f_110_24968_25045(System.IntPtr
                consoleHandle, Microsoft.PowerShell.ConsoleControl.ConsoleModes
                mode)
                {
                    var return_v = NativeMethods.SetConsoleMode(consoleHandle, (uint)mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 24968, 25045);
                    return return_v;
                }


                int
                f_110_25125_25152()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 25125, 25152);
                    return return_v;
                }


                string
                f_110_25290_25336()
                {
                    var return_v = ConsoleControlStrings.SetModeExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 25290, 25336);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_25191_25337(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 25191, 25337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 24693, 25390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 24693, 25390);
            }
        }

        internal static string ReadConsole(
                    ConsoleHandle consoleHandle,
                    int initialContentLength,
                    Span<char> editBuffer,
                    int charactersToRead,
                    bool endOnTab,
                    out uint keyState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 26826, 28913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27098, 27165);

                f_110_27098_27164(f_110_27109_27133_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27179, 27242);

                f_110_27179_27241(f_110_27190_27213_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27256, 27369);

                f_110_27256_27368(initialContentLength < editBuffer.Length, "initialContentLength must be less than editBuffer.Length");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27383, 27488);

                f_110_27383_27487(charactersToRead < editBuffer.Length, "charactersToRead must be less than editBuffer.Length");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27502, 27515);

                keyState = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27531, 27603);

                CONSOLE_READCONSOLE_CONTROL
                control = f_110_27569_27602()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27619, 27668);

                control.nLength = (ULONG)f_110_27644_27667(control);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27682, 27734);

                control.nInitialChars = (ULONG)initialContentLength;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27748, 27778);

                control.dwControlKeyState = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27792, 27931) || true) && (endOnTab)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 27792, 27931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27838, 27858);

                    const int
                    TAB = 0x9
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27878, 27916);

                    control.dwCtrlWakeupMask = (1 << TAB);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 27792, 27931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27947, 27969);

                DWORD
                charsReaded = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 27985, 28251);

                bool
                result =
                f_110_28016_28250(f_110_28064_28098(consoleHandle), editBuffer, charactersToRead, out charsReaded, ref control)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28265, 28302);

                keyState = control.dwControlKeyState;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28316, 28688) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 28316, 28688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28369, 28407);

                    int
                    err = f_110_28379_28406()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28427, 28647);

                    HostException
                    e = f_110_28445_28646(err, "ReadConsole", ErrorCategory.ReadError, f_110_28595_28645())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28665, 28673);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 28316, 28688);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28704, 28830) || true) && (charsReaded > (uint)charactersToRead)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 28704, 28830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28778, 28815);

                    charsReaded = (uint)charactersToRead;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 28704, 28830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 28846, 28902);

                return editBuffer.Slice(0, (int)charsReaded).ToString();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 26826, 28913);

                bool
                f_110_27109_27133_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 27109, 27133);
                    return return_v;
                }


                int
                f_110_27098_27164(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 27098, 27164);
                    return 0;
                }


                bool
                f_110_27190_27213_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 27190, 27213);
                    return return_v;
                }


                int
                f_110_27179_27241(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 27179, 27241);
                    return 0;
                }


                int
                f_110_27256_27368(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 27256, 27368);
                    return 0;
                }


                int
                f_110_27383_27487(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 27383, 27487);
                    return 0;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_READCONSOLE_CONTROL
                f_110_27569_27602()
                {
                    var return_v = new Microsoft.PowerShell.ConsoleControl.CONSOLE_READCONSOLE_CONTROL();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 27569, 27602);
                    return return_v;
                }


                int
                f_110_27644_27667(Microsoft.PowerShell.ConsoleControl.CONSOLE_READCONSOLE_CONTROL
                structure)
                {
                    var return_v = Marshal.SizeOf(structure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 27644, 27667);
                    return return_v;
                }


                System.IntPtr
                f_110_28064_28098(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 28064, 28098);
                    return return_v;
                }


                bool
                f_110_28016_28250(System.IntPtr
                consoleInput, System.Span<char>
                buffer, int
                numberOfCharsToRead, out uint
                numberOfCharsRead, ref Microsoft.PowerShell.ConsoleControl.CONSOLE_READCONSOLE_CONTROL
                controlData)
                {
                    var return_v = NativeMethods.ReadConsole(consoleInput, buffer, (uint)numberOfCharsToRead, out numberOfCharsRead, ref controlData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 28016, 28250);
                    return return_v;
                }


                int
                f_110_28379_28406()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 28379, 28406);
                    return return_v;
                }


                string
                f_110_28595_28645()
                {
                    var return_v = ConsoleControlStrings.ReadConsoleExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 28595, 28645);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_28445_28646(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 28445, 28646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 26826, 28913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 26826, 28913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int ReadConsoleInput(ConsoleHandle consoleHandle, ref INPUT_RECORD[] buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 29514, 30440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 29631, 29698);

                f_110_29631_29697(f_110_29642_29666_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 29712, 29775);

                f_110_29712_29774(f_110_29723_29746_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 29791, 29813);

                DWORD
                recordsRead = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 29827, 30057);

                bool
                result =
                f_110_29858_30056(f_110_29911_29945(consoleHandle), buffer, f_110_30004_30017(buffer), out recordsRead)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 30071, 30389) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 30071, 30389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 30124, 30162);

                    int
                    err = f_110_30134_30161()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 30182, 30348);

                    HostException
                    e = f_110_30200_30347(err, "ReadConsoleInput", ErrorCategory.ReadError, f_110_30291_30346())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 30366, 30374);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 30071, 30389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 30405, 30429);

                return (int)recordsRead;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 29514, 30440);

                bool
                f_110_29642_29666_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 29642, 29666);
                    return return_v;
                }


                int
                f_110_29631_29697(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 29631, 29697);
                    return 0;
                }


                bool
                f_110_29723_29746_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 29723, 29746);
                    return return_v;
                }


                int
                f_110_29712_29774(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 29712, 29774);
                    return 0;
                }


                System.IntPtr
                f_110_29911_29945(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 29911, 29945);
                    return return_v;
                }


                int
                f_110_30004_30017(Microsoft.PowerShell.ConsoleControl.INPUT_RECORD[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 30004, 30017);
                    return return_v;
                }


                bool
                f_110_29858_30056(System.IntPtr
                consoleInput, Microsoft.PowerShell.ConsoleControl.INPUT_RECORD[]
                buffer, int
                length, out uint
                numberOfEventsRead)
                {
                    var return_v = NativeMethods.ReadConsoleInput(consoleInput, buffer, (uint)length, out numberOfEventsRead);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 29858, 30056);
                    return return_v;
                }


                int
                f_110_30134_30161()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 30134, 30161);
                    return return_v;
                }


                string
                f_110_30291_30346()
                {
                    var return_v = ConsoleControlStrings.ReadConsoleInputExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 30291, 30346);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_30200_30347(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 30200, 30347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 29514, 30440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 29514, 30440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int PeekConsoleInput
                (
                    ConsoleHandle consoleHandle,
                    ref INPUT_RECORD[] buffer
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 30986, 31957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31150, 31217);

                f_110_31150_31216(f_110_31161_31185_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31231, 31294);

                f_110_31231_31293(f_110_31242_31265_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31310, 31328);

                DWORD
                recordsRead
                = default(DWORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31342, 31572);

                bool
                result =
                f_110_31373_31571(f_110_31426_31460(consoleHandle), buffer, f_110_31519_31532(buffer), out recordsRead)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31588, 31906) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 31588, 31906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31641, 31679);

                    int
                    err = f_110_31651_31678()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31699, 31865);

                    HostException
                    e = f_110_31717_31864(err, "PeekConsoleInput", ErrorCategory.ReadError, f_110_31808_31863())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31883, 31891);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 31588, 31906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 31922, 31946);

                return (int)recordsRead;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 30986, 31957);

                bool
                f_110_31161_31185_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 31161, 31185);
                    return return_v;
                }


                int
                f_110_31150_31216(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 31150, 31216);
                    return 0;
                }


                bool
                f_110_31242_31265_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 31242, 31265);
                    return return_v;
                }


                int
                f_110_31231_31293(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 31231, 31293);
                    return 0;
                }


                System.IntPtr
                f_110_31426_31460(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 31426, 31460);
                    return return_v;
                }


                int
                f_110_31519_31532(Microsoft.PowerShell.ConsoleControl.INPUT_RECORD[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 31519, 31532);
                    return return_v;
                }


                bool
                f_110_31373_31571(System.IntPtr
                consoleInput, Microsoft.PowerShell.ConsoleControl.INPUT_RECORD[]
                buffer, int
                length, out uint
                numberOfEventsRead)
                {
                    var return_v = NativeMethods.PeekConsoleInput(consoleInput, buffer, (uint)length, out numberOfEventsRead);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 31373, 31571);
                    return return_v;
                }


                int
                f_110_31651_31678()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 31651, 31678);
                    return return_v;
                }


                string
                f_110_31808_31863()
                {
                    var return_v = ConsoleControlStrings.PeekConsoleInputExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 31808, 31863);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_31717_31864(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 31717, 31864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 30986, 31957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 30986, 31957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetNumberOfConsoleInputEvents(ConsoleHandle consoleHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 32450, 33261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 32553, 32620);

                f_110_32553_32619(f_110_32564_32588_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 32634, 32697);

                f_110_32634_32696(f_110_32645_32668_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 32713, 32729);

                DWORD
                numEvents
                = default(DWORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 32743, 32852);

                bool
                result = f_110_32757_32851(f_110_32801_32835(consoleHandle), out numEvents)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 32868, 33212) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 32868, 33212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 32921, 32959);

                    int
                    err = f_110_32931_32958()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 32979, 33171);

                    HostException
                    e = f_110_32997_33170(err, "GetNumberOfConsoleInputEvents", ErrorCategory.ReadError, f_110_33101_33169())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 33189, 33197);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 32868, 33212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 33228, 33250);

                return (int)numEvents;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 32450, 33261);

                bool
                f_110_32564_32588_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 32564, 32588);
                    return return_v;
                }


                int
                f_110_32553_32619(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 32553, 32619);
                    return 0;
                }


                bool
                f_110_32645_32668_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 32645, 32668);
                    return return_v;
                }


                int
                f_110_32634_32696(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 32634, 32696);
                    return 0;
                }


                System.IntPtr
                f_110_32801_32835(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 32801, 32835);
                    return return_v;
                }


                bool
                f_110_32757_32851(System.IntPtr
                consoleInput, out uint
                numberOfEvents)
                {
                    var return_v = NativeMethods.GetNumberOfConsoleInputEvents(consoleInput, out numberOfEvents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 32757, 32851);
                    return return_v;
                }


                int
                f_110_32931_32958()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 32931, 32958);
                    return return_v;
                }


                string
                f_110_33101_33169()
                {
                    var return_v = ConsoleControlStrings.GetNumberOfConsoleInputEventsExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 33101, 33169);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_32997_33170(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 32997, 33170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 32450, 33261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 32450, 33261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void FlushConsoleInputBuffer(ConsoleHandle consoleHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 33630, 34401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 33728, 33795);

                f_110_33728_33794(f_110_33739_33763_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 33809, 33872);

                f_110_33809_33871(f_110_33820_33843_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 33888, 33908);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 33922, 33978);

                NakedWin32Handle
                h = f_110_33943_33977(consoleHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 33992, 34042);

                result = f_110_34001_34041(h);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 34058, 34390) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 34058, 34390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 34111, 34149);

                    int
                    err = f_110_34121_34148()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 34169, 34349);

                    HostException
                    e = f_110_34187_34348(err, "FlushConsoleInputBuffer", ErrorCategory.ReadError, f_110_34285_34347())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 34367, 34375);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 34058, 34390);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 33630, 34401);

                bool
                f_110_33739_33763_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 33739, 33763);
                    return return_v;
                }


                int
                f_110_33728_33794(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 33728, 33794);
                    return 0;
                }


                bool
                f_110_33820_33843_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 33820, 33843);
                    return return_v;
                }


                int
                f_110_33809_33871(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 33809, 33871);
                    return 0;
                }


                System.IntPtr
                f_110_33943_33977(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 33943, 33977);
                    return return_v;
                }


                bool
                f_110_34001_34041(System.IntPtr
                consoleInput)
                {
                    var return_v = NativeMethods.FlushConsoleInputBuffer(consoleInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 34001, 34041);
                    return return_v;
                }


                int
                f_110_34121_34148()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 34121, 34148);
                    return return_v;
                }


                string
                f_110_34285_34347()
                {
                    var return_v = ConsoleControlStrings.FlushConsoleInputBufferExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 34285, 34347);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_34187_34348(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 34187, 34348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 33630, 34401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 33630, 34401);
            }
        }

        internal static CONSOLE_SCREEN_BUFFER_INFO GetConsoleScreenBufferInfo(ConsoleHandle consoleHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 35024, 35875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35147, 35214);

                f_110_35147_35213(f_110_35158_35182_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35228, 35291);

                f_110_35228_35290(f_110_35239_35262_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35307, 35345);

                CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo
                = default(CONSOLE_SCREEN_BUFFER_INFO);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35359, 35466);

                bool
                result = f_110_35373_35465(f_110_35414_35448(consoleHandle), out bufferInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35482, 35830) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 35482, 35830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35535, 35573);

                    int
                    err = f_110_35545_35572()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35593, 35789);

                    HostException
                    e = f_110_35611_35788(err, "GetConsoleScreenBufferInfo", ErrorCategory.ResourceUnavailable, f_110_35722_35787())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35807, 35815);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 35482, 35830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 35846, 35864);

                return bufferInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 35024, 35875);

                bool
                f_110_35158_35182_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 35158, 35182);
                    return return_v;
                }


                int
                f_110_35147_35213(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 35147, 35213);
                    return 0;
                }


                bool
                f_110_35239_35262_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 35239, 35262);
                    return return_v;
                }


                int
                f_110_35228_35290(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 35228, 35290);
                    return 0;
                }


                System.IntPtr
                f_110_35414_35448(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 35414, 35448);
                    return return_v;
                }


                bool
                f_110_35373_35465(System.IntPtr
                consoleHandle, out Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                consoleScreenBufferInfo)
                {
                    var return_v = NativeMethods.GetConsoleScreenBufferInfo(consoleHandle, out consoleScreenBufferInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 35373, 35465);
                    return return_v;
                }


                int
                f_110_35545_35572()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 35545, 35572);
                    return return_v;
                }


                string
                f_110_35722_35787()
                {
                    var return_v = ConsoleControlStrings.GetConsoleScreenBufferInfoExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 35722, 35787);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_35611_35788(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 35611, 35788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 35024, 35875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 35024, 35875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetConsoleScreenBufferSize(ConsoleHandle consoleHandle, Size newSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 36202, 37055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36317, 36384);

                f_110_36317_36383(f_110_36328_36352_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36398, 36461);

                f_110_36398_36460(f_110_36409_36432_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36477, 36485);

                COORD
                s
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36501, 36528);

                s.X = (short)newSize.Width;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36542, 36570);

                s.Y = (short)newSize.Height;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36586, 36680);

                bool
                result = f_110_36600_36679(f_110_36641_36675(consoleHandle), s)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36696, 37044) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 36696, 37044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36749, 36787);

                    int
                    err = f_110_36759_36786()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 36807, 37003);

                    HostException
                    e = f_110_36825_37002(err, "SetConsoleScreenBufferSize", ErrorCategory.ResourceUnavailable, f_110_36936_37001())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 37021, 37029);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 36696, 37044);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 36202, 37055);

                bool
                f_110_36328_36352_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 36328, 36352);
                    return return_v;
                }


                int
                f_110_36317_36383(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 36317, 36383);
                    return 0;
                }


                bool
                f_110_36409_36432_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 36409, 36432);
                    return return_v;
                }


                int
                f_110_36398_36460(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 36398, 36460);
                    return 0;
                }


                System.IntPtr
                f_110_36641_36675(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 36641, 36675);
                    return return_v;
                }


                bool
                f_110_36600_36679(System.IntPtr
                consoleOutput, Microsoft.PowerShell.ConsoleControl.COORD
                size)
                {
                    var return_v = NativeMethods.SetConsoleScreenBufferSize(consoleOutput, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 36600, 36679);
                    return return_v;
                }


                int
                f_110_36759_36786()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 36759, 36786);
                    return return_v;
                }


                string
                f_110_36936_37001()
                {
                    var return_v = ConsoleControlStrings.SetConsoleScreenBufferSizeExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 36936, 37001);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_36825_37002(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 36825, 37002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 36202, 37055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 36202, 37055);
            }
        }

        internal static bool IsConsoleColor(ConsoleColor c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 37067, 37953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 37143, 37913);

                switch (c)
                {

                    case ConsoleColor.Black:
                    case ConsoleColor.Blue:
                    case ConsoleColor.Cyan:
                    case ConsoleColor.DarkBlue:
                    case ConsoleColor.DarkCyan:
                    case ConsoleColor.DarkGray:
                    case ConsoleColor.DarkGreen:
                    case ConsoleColor.DarkMagenta:
                    case ConsoleColor.DarkRed:
                    case ConsoleColor.DarkYellow:
                    case ConsoleColor.Gray:
                    case ConsoleColor.Green:
                    case ConsoleColor.Magenta:
                    case ConsoleColor.Red:
                    case ConsoleColor.White:
                    case ConsoleColor.Yellow:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 37143, 37913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 37886, 37898);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 37143, 37913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 37929, 37942);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 37067, 37953);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 37067, 37953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 37067, 37953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void WORDToColor(WORD attribute, out ConsoleColor foreground, out ConsoleColor background)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 37965, 38455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 38191, 38237);

                foreground = (ConsoleColor)(attribute & 0x0f);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 38251, 38304);

                background = (ConsoleColor)((attribute & 0xf0) >> 4);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 38318, 38374);

                f_110_38318_38373(f_110_38329_38355(foreground), "unknown color");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 38388, 38444);

                f_110_38388_38443(f_110_38399_38425(background), "unknown color");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 37965, 38455);

                bool
                f_110_38329_38355(System.ConsoleColor
                c)
                {
                    var return_v = IsConsoleColor(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 38329, 38355);
                    return return_v;
                }


                int
                f_110_38318_38373(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 38318, 38373);
                    return 0;
                }


                bool
                f_110_38399_38425(System.ConsoleColor
                c)
                {
                    var return_v = IsConsoleColor(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 38399, 38425);
                    return return_v;
                }


                int
                f_110_38388_38443(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 38388, 38443);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 37965, 38455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 37965, 38455);
            }
        }

        internal static WORD ColorToWORD(ConsoleColor foreground, ConsoleColor background)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 38467, 38678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 38574, 38637);

                WORD
                result = (WORD)(((int)background << 4) | (int)foreground)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 38653, 38667);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 38467, 38678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 38467, 38678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 38467, 38678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void WriteConsoleOutput(ConsoleHandle consoleHandle, Coordinates origin, BufferCell[,] contents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 39801, 43274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 39938, 40005);

                f_110_39938_40004(f_110_39949_39973_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40019, 40082);

                f_110_40019_40081(f_110_40030_40053_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40096, 40222) || true) && (contents == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 40096, 40222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40150, 40207);

                    throw f_110_40156_40206("contents");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 40096, 40222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40238, 40252);

                uint
                codePage
                = default(uint);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40266, 43263) || true) && (f_110_40270_40303(out codePage))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 40266, 43263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40497, 40540);

                    Rectangle
                    contentsRegion = f_110_40524_40539()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40558, 40676);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo =
                    f_110_40634_40675(consoleHandle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40696, 40738);

                    int
                    bufferWidth = bufferInfo.BufferSize.X
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40756, 40799);

                    int
                    bufferHeight = bufferInfo.BufferSize.Y
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 40817, 41071);

                    Rectangle
                    screenRegion = f_110_40842_41070(origin.X, origin.Y, f_110_40919_40982(origin.X + f_110_40939_40960(contents, 1) - 1, bufferWidth - 1), f_110_41005_41069(origin.Y + f_110_41025_41046(contents, 0) - 1, bufferHeight - 1))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41091, 41139);

                    contentsRegion.Left = f_110_41113_41138(contents, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41157, 41204);

                    contentsRegion.Top = f_110_41178_41203(contents, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41222, 41327);

                    contentsRegion.Right = contentsRegion.Left +
                                        screenRegion.Right - screenRegion.Left;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41345, 41450);

                    contentsRegion.Bottom = contentsRegion.Top +
                                        screenRegion.Bottom - screenRegion.Top;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41534, 41592);

                    f_110_41534_41591(contents, contentsRegion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41713, 41803);

                    List<BufferCellArrayRowTypeRange>
                    sameEdgeAreas = f_110_41763_41802()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41821, 41878);

                    int
                    firstLeftTrailingRow = -1
                    ,
                    firstRightLeadingRow = -1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 41896, 42028);

                    f_110_41896_42027(contentsRegion, contents, sameEdgeAreas, out firstLeftTrailingRow, out firstRightLeadingRow);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42059, 42211);

                    f_110_42059_42210(consoleHandle, codePage, origin, contents, contentsRegion, bufferInfo, firstLeftTrailingRow, firstRightLeadingRow);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42239, 43125);
                        foreach (BufferCellArrayRowTypeRange area in f_110_42284_42297_I(sameEdgeAreas))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 42239, 43125);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42339, 42478);

                            Coordinates
                            o = f_110_42355_42477(origin.X, origin.Y + area.Start - contentsRegion.Top)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42500, 42628);

                            Rectangle
                            contRegion = f_110_42523_42627(contentsRegion.Left, area.Start, contentsRegion.Right, area.End)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42650, 43009) || true) && ((area.Type & BufferCellArrayRowType.LeftTrailing) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 42650, 43009);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42758, 42776);

                                f_110_42758_42775_M(contRegion.Left++);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42802, 42808);

                                f_110_42802_42807_M(o.X++);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42834, 42986) || true) && (o.X >= bufferWidth || (DynAbs.Tracing.TraceSender.Expression_False(110, 42838, 42894) || contRegion.Right < contRegion.Left))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 42834, 42986);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 42952, 42959);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 42834, 42986);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 42650, 43009);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43033, 43106);

                            f_110_43033_43105(consoleHandle, o, contRegion, contents, area.Type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 42239, 43125);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 887);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 887);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 40266, 43263);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 40266, 43263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43191, 43248);

                    f_110_43191_43247(consoleHandle, origin, contents);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 40266, 43263);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 39801, 43274);

                bool
                f_110_39949_39973_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 39949, 39973);
                    return return_v;
                }


                int
                f_110_39938_40004(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 39938, 40004);
                    return 0;
                }


                bool
                f_110_40030_40053_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 40030, 40053);
                    return return_v;
                }


                int
                f_110_40019_40081(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40019, 40081);
                    return 0;
                }


                System.Management.Automation.PSArgumentNullException
                f_110_40156_40206(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40156, 40206);
                    return return_v;
                }


                bool
                f_110_40270_40303(out uint
                codePage)
                {
                    var return_v = IsCJKOutputCodePage(out codePage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40270, 40303);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_110_40524_40539()
                {
                    var return_v = new System.Management.Automation.Host.Rectangle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40524, 40539);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                f_110_40634_40675(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = GetConsoleScreenBufferInfo(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40634, 40675);
                    return return_v;
                }


                int
                f_110_40939_40960(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40939, 40960);
                    return return_v;
                }


                int
                f_110_40919_40982(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40919, 40982);
                    return return_v;
                }


                int
                f_110_41025_41046(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 41025, 41046);
                    return return_v;
                }


                int
                f_110_41005_41069(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 41005, 41069);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_110_40842_41070(int
                left, int
                top, int
                right, int
                bottom)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(left, top, right, bottom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 40842, 41070);
                    return return_v;
                }


                int
                f_110_41113_41138(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 41113, 41138);
                    return return_v;
                }


                int
                f_110_41178_41203(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 41178, 41203);
                    return return_v;
                }


                int
                f_110_41534_41591(System.Management.Automation.Host.BufferCell[,]
                contents, System.Management.Automation.Host.Rectangle
                contentsRegion)
                {
                    CheckWriteConsoleOutputContents(contents, contentsRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 41534, 41591);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange>
                f_110_41763_41802()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 41763, 41802);
                    return return_v;
                }


                int
                f_110_41896_42027(System.Management.Automation.Host.Rectangle
                contentsRegion, System.Management.Automation.Host.BufferCell[,]
                contents, System.Collections.Generic.List<Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange>
                sameEdgeAreas, out int
                firstLeftTrailingRow, out int
                firstRightLeadingRow)
                {
                    BuildEdgeTypeInfo(contentsRegion, contents, sameEdgeAreas, out firstLeftTrailingRow, out firstRightLeadingRow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 41896, 42027);
                    return 0;
                }


                int
                f_110_42059_42210(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.BufferCell[,]
                contents, System.Management.Automation.Host.Rectangle
                contentsRegion, Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo, int
                firstLeftTrailingRow, int
                firstRightLeadingRow)
                {
                    CheckWriteEdges(consoleHandle, codePage, origin, contents, contentsRegion, bufferInfo, firstLeftTrailingRow, firstRightLeadingRow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 42059, 42210);
                    return 0;
                }


                System.Management.Automation.Host.Coordinates
                f_110_42355_42477(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 42355, 42477);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_110_42523_42627(int
                left, int
                top, int
                right, int
                bottom)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(left, top, right, bottom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 42523, 42627);
                    return return_v;
                }


                int
                f_110_42758_42775_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 42758, 42775);
                    return return_v;
                }


                int
                f_110_42802_42807_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 42802, 42807);
                    return return_v;
                }


                int
                f_110_43033_43105(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, System.Management.Automation.Host.BufferCell[,]
                contents, Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowType
                rowType)
                {
                    WriteConsoleOutputCJK(consoleHandle, origin, contentsRegion, contents, rowType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 43033, 43105);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange>
                f_110_42284_42297_I(System.Collections.Generic.List<Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 42284, 42297);
                    return return_v;
                }


                int
                f_110_43191_43247(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    WriteConsoleOutputPlain(consoleHandle, origin, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 43191, 43247);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 39801, 43274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 39801, 43274);
            }
        }

        private static void BuildEdgeTypeInfo(
                    Rectangle contentsRegion,
                    BufferCell[,] contents,
                    List<BufferCellArrayRowTypeRange> sameEdgeAreas,
                    out int firstLeftTrailingRow,
                    out int firstRightLeadingRow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 43286, 45134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43573, 43599);

                firstLeftTrailingRow = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43613, 43639);

                firstRightLeadingRow = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43653, 43840);

                BufferCellArrayRowType
                edgeType =
                f_110_43704_43839(contents[contentsRegion.Top, contentsRegion.Left], contents[contentsRegion.Top, contentsRegion.Right])
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43863, 43885);
                    for (int
        r = contentsRegion.Top
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43854, 45123) || true) && (r <= contentsRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(110, 43854, 45123))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 43854, 45123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 43948, 43982);

                        BufferCellArrayRowTypeRange
                        range
                        = default(BufferCellArrayRowTypeRange);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44000, 44016);

                        range.Start = r;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44034, 44056);

                        range.Type = edgeType;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44074, 44251) || true) && (firstLeftTrailingRow == -1 && (DynAbs.Tracing.TraceSender.Expression_True(110, 44078, 44165) && ((range.Type & BufferCellArrayRowType.LeftTrailing) != 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 44074, 44251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44207, 44232);

                            firstLeftTrailingRow = r;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 44074, 44251);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44271, 44448) || true) && (firstRightLeadingRow == -1 && (DynAbs.Tracing.TraceSender.Expression_True(110, 44275, 44362) && ((range.Type & BufferCellArrayRowType.RightLeading) != 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 44271, 44448);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44404, 44429);

                            firstRightLeadingRow = r;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 44271, 44448);
                        }
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44468, 45108) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 44468, 45108);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44521, 44525);

                                r++;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44547, 44751) || true) && (r > contentsRegion.Bottom)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 44547, 44751);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44626, 44644);

                                    range.End = r - 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44670, 44695);

                                    f_110_44670_44694(sameEdgeAreas, range);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44721, 44728);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 44547, 44751);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44775, 44867);

                                edgeType = f_110_44786_44866(contents[r, contentsRegion.Left], contents[r, contentsRegion.Right]);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44889, 45089) || true) && (edgeType != range.Type)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 44889, 45089);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 44965, 44983);

                                    range.End = r - 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 45009, 45034);

                                    f_110_45009_45033(sameEdgeAreas, range);
                                    DynAbs.Tracing.TraceSender.TraceBreak(110, 45060, 45066);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 44889, 45089);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 44468, 45108);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 44468, 45108);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 44468, 45108);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 1270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 1270);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 43286, 45134);

                Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowType
                f_110_43704_43839(System.Management.Automation.Host.BufferCell
                left, System.Management.Automation.Host.BufferCell
                right)
                {
                    var return_v = GetEdgeType(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 43704, 43839);
                    return return_v;
                }


                int
                f_110_44670_44694(System.Collections.Generic.List<Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange>
                this_param, Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 44670, 44694);
                    return 0;
                }


                Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowType
                f_110_44786_44866(System.Management.Automation.Host.BufferCell
                left, System.Management.Automation.Host.BufferCell
                right)
                {
                    var return_v = GetEdgeType(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 44786, 44866);
                    return return_v;
                }


                int
                f_110_45009_45033(System.Collections.Generic.List<Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange>
                this_param, Microsoft.PowerShell.ConsoleControl.BufferCellArrayRowTypeRange
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 45009, 45033);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 43286, 45134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 43286, 45134);
            }
        }

        private static BufferCellArrayRowType GetEdgeType(BufferCell left, BufferCell right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 45146, 45658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 45255, 45291);

                BufferCellArrayRowType
                edgeType = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 45305, 45452) || true) && (left.BufferCellType == BufferCellType.Trailing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 45305, 45452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 45389, 45437);

                    edgeType |= BufferCellArrayRowType.LeftTrailing;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 45305, 45452);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 45468, 45615) || true) && (right.BufferCellType == BufferCellType.Leading)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 45468, 45615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 45552, 45600);

                    edgeType |= BufferCellArrayRowType.RightLeading;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 45468, 45615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 45631, 45647);

                return edgeType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 45146, 45658);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 45146, 45658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 45146, 45658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct BufferCellArrayRowTypeRange
        {

            internal int Start;

            internal int End;

            internal BufferCellArrayRowType Type;
            static BufferCellArrayRowTypeRange()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 45670, 45849);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 45670, 45849);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 45670, 45849);
            }
        }

        [Flags]
        private enum BufferCellArrayRowType : uint
        {
            LeftTrailing = 0x1,
            RightLeading = 0x2
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Called in CHK builds")]
        internal static void CheckWriteEdges(
                    ConsoleHandle consoleHandle,
                    uint codePage, Coordinates origin,
                    BufferCell[,] contents,
                    Rectangle contentsRegion,
                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO bufferInfo,
                    int firstLeftTrailingRow,
                    int firstRightLeadingRow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 46914, 50373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 47414, 47508);

                Rectangle
                existingRegion = f_110_47441_47507(0, 0, 1, contentsRegion.Bottom - contentsRegion.Top)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 47522, 48856) || true) && (origin.X == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 47522, 48856);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 47573, 47839) || true) && (firstLeftTrailingRow >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 47573, 47839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 47644, 47820);

                        throw f_110_47650_47819(f_110_47685_47818(f_110_47699_47727(), "contents[{0}, {1}]", firstLeftTrailingRow, contentsRegion.Left));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 47573, 47839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 47522, 48856);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 47522, 48856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48049, 48123);

                    BufferCell[,]
                    leftExisting = new BufferCell[existingRegion.Bottom + 1, 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48141, 48283);

                    f_110_48141_48282(consoleHandle, codePage, f_110_48208_48247(origin.X - 1, origin.Y), existingRegion, ref leftExisting);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48310, 48332);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48334, 48339);
                        for (int
        r = contentsRegion.Top
        ,
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48301, 48841) || true) && (r <= contentsRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48369, 48372)
        , r++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48374, 48377)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 48301, 48841))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 48301, 48841);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48419, 48822) || true) && (leftExisting[r, 0].BufferCellType == BufferCellType.Leading ^
                                                        contents[r, contentsRegion.Left].BufferCellType == BufferCellType.Trailing)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 48419, 48822);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48638, 48799);

                                throw f_110_48644_48798(f_110_48679_48797(f_110_48693_48721(), "contents[{0}, {1}]", r, contentsRegion.Left));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 48419, 48822);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 541);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 541);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 47522, 48856);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 48903, 50362) || true) && (origin.X + (contentsRegion.Right - contentsRegion.Left) + 1 >= bufferInfo.BufferSize.X)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 48903, 50362);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49027, 49298) || true) && (firstRightLeadingRow >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 49027, 49298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49098, 49279);

                        throw f_110_49104_49278(f_110_49139_49277(f_110_49153_49181(), "contents[{0}, {1}]", firstRightLeadingRow, contentsRegion.Right));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 49027, 49298);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 48903, 50362);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 48903, 50362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49508, 49583);

                    BufferCell[,]
                    rightExisting = new BufferCell[existingRegion.Bottom + 1, 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49601, 49787);

                    f_110_49601_49786(consoleHandle, codePage, f_110_49668_49750(origin.X + (contentsRegion.Right - contentsRegion.Left), origin.Y), existingRegion, ref rightExisting);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49814, 49836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49838, 49843);
                        for (int
        r = contentsRegion.Top
        ,
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49805, 50347) || true) && (r <= contentsRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49873, 49876)
        , r++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49878, 49881)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 49805, 50347))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 49805, 50347);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 49923, 50328) || true) && (rightExisting[r, 0].BufferCellType == BufferCellType.Leading ^
                                                        contents[r, contentsRegion.Right].BufferCellType == BufferCellType.Leading)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 49923, 50328);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 50143, 50305);

                                throw f_110_50149_50304(f_110_50184_50303(f_110_50198_50226(), "contents[{0}, {1}]", r, contentsRegion.Right));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 49923, 50328);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 543);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 543);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 48903, 50362);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 46914, 50373);

                System.Management.Automation.Host.Rectangle
                f_110_47441_47507(int
                left, int
                top, int
                right, int
                bottom)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(left, top, right, bottom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 47441, 47507);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_110_47699_47727()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 47699, 47727);
                    return return_v;
                }


                string
                f_110_47685_47818(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 47685, 47818);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_110_47650_47819(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 47650, 47819);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_110_48208_48247(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 48208, 48247);
                    return return_v;
                }


                int
                f_110_48141_48282(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ReadConsoleOutputCJK(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 48141, 48282);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_110_48693_48721()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 48693, 48721);
                    return return_v;
                }


                string
                f_110_48679_48797(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 48679, 48797);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_110_48644_48798(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 48644, 48798);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_110_49153_49181()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 49153, 49181);
                    return return_v;
                }


                string
                f_110_49139_49277(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 49139, 49277);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_110_49104_49278(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 49104, 49278);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_110_49668_49750(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 49668, 49750);
                    return return_v;
                }


                int
                f_110_49601_49786(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ReadConsoleOutputCJK(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 49601, 49786);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_110_50198_50226()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 50198, 50226);
                    return return_v;
                }


                string
                f_110_50184_50303(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 50184, 50303);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_110_50149_50304(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 50149, 50304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 46914, 50373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 46914, 50373);
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Called in CHK builds")]
        private static void CheckWriteConsoleOutputContents(BufferCell[,] contents, Rectangle contentsRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 50385, 52281);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 50647, 50669);
                    for (int
        r = contentsRegion.Top
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 50638, 52270) || true) && (r <= contentsRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 50699, 50702)
        , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 50638, 52270))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 50638, 52270);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 50745, 50768);
                            for (int
            c = contentsRegion.Left
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 50736, 52255) || true) && (c <= contentsRegion.Right)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 50797, 50800)
            , c++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 50736, 52255))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 50736, 52255);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 51075, 51436) || true) && (contents[r, c].BufferCellType == BufferCellType.Trailing && (DynAbs.Tracing.TraceSender.Expression_True(110, 51079, 51193) && contents[r, c].Character != 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 51075, 51436);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 51299, 51413);

                                    throw f_110_51305_51412(f_110_51340_51411(f_110_51354_51382(), "contents[{0}, {1}]", r, c));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 51075, 51436);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 51460, 52236) || true) && (contents[r, c].BufferCellType == BufferCellType.Leading)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 51460, 52236);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 51569, 51573);

                                    c++;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 51599, 51718) || true) && (c > contentsRegion.Right)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 51599, 51718);
                                        DynAbs.Tracing.TraceSender.TraceBreak(110, 51685, 51691);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 51599, 51718);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 51746, 52213) || true) && (contents[r, c].Character != 0 || (DynAbs.Tracing.TraceSender.Expression_False(110, 51750, 51839) || contents[r, c].BufferCellType != BufferCellType.Trailing))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 51746, 52213);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 52072, 52186);

                                        throw f_110_52078_52185(f_110_52113_52184(f_110_52127_52155(), "contents[{0}, {1}]", r, c));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 51746, 52213);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 51460, 52236);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 1520);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 1520);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 1633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 1633);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 50385, 52281);

                System.Globalization.CultureInfo
                f_110_51354_51382()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 51354, 51382);
                    return return_v;
                }


                string
                f_110_51340_51411(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 51340, 51411);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_110_51305_51412(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 51305, 51412);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_110_52127_52155()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 52127, 52155);
                    return return_v;
                }


                string
                f_110_52113_52184(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 52113, 52184);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_110_52078_52185(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 52078, 52185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 50385, 52281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 50385, 52281);
            }
        }

        private static void WriteConsoleOutputCJK(ConsoleHandle consoleHandle, Coordinates origin, Rectangle contentsRegion, BufferCell[,] contents, BufferCellArrayRowType rowType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 52293, 64253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 52490, 52593);

                f_110_52490_52592(origin.X >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(110, 52501, 52531) && origin.Y >= 0), "origin must be within the output buffer");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 52607, 52665);

                int
                rows = contentsRegion.Bottom - contentsRegion.Top + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 52679, 52737);

                int
                cols = contentsRegion.Right - contentsRegion.Left + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 52753, 52819);

                CONSOLE_FONT_INFO_EX
                fontInfo = f_110_52785_52818(consoleHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 52833, 52897);

                int
                fontType = fontInfo.FontFamily & NativeMethods.FontTypeMask
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 52911, 53002);

                bool
                trueTypeInUse = (fontType & NativeMethods.TrueTypeFont) == NativeMethods.TrueTypeFont
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53018, 53045);

                int
                bufferLimit = 2 * 1024
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53114, 53132);

                COORD
                bufferCoord
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53148, 53166);

                bufferCoord.X = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53180, 53198);

                bufferCoord.Y = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53269, 53292);

                SMALL_RECT
                writeRegion
                = default(SMALL_RECT);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53308, 53342);

                writeRegion.Top = (short)origin.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53358, 53383);

                int
                rowsRemaining = rows
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 53399, 64224) || true) && (rowsRemaining > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 53399, 64224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54127, 54162);

                        writeRegion.Left = (short)origin.X;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54182, 54199);

                        COORD
                        bufferSize
                        = default(COORD);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54219, 54269);

                        bufferSize.X = (short)f_110_54241_54268(cols, bufferLimit);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54287, 54536);

                        bufferSize.Y = (short)f_110_54309_54535(rowsRemaining, bufferLimit / bufferSize.X);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54554, 54619);

                        writeRegion.Bottom = (short)(writeRegion.Top + bufferSize.Y - 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54729, 54783);

                        int
                        atRow = rows - rowsRemaining + contentsRegion.Top
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54859, 54884);

                        int
                        colsRemaining = cols
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54902, 64088) || true) && (colsRemaining > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 54902, 64088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 54968, 55033);

                                writeRegion.Right = (short)(writeRegion.Left + bufferSize.X - 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55154, 55209);

                                int
                                atCol = cols - colsRemaining + contentsRegion.Left
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55390, 55668) || true) && (colsRemaining > bufferSize.X && (DynAbs.Tracing.TraceSender.Expression_True(110, 55394, 55534) && contents[atRow, atCol + bufferSize.X - 1].BufferCellType == BufferCellType.Leading))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 55390, 55668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55584, 55599);

                                    bufferSize.X--;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55625, 55645);

                                    writeRegion.Right--;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 55390, 55668);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55692, 55765);

                                CHAR_INFO[]
                                characterBuffer = new CHAR_INFO[bufferSize.Y * bufferSize.X]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55847, 55876);

                                int
                                characterBufferIndex = 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55898, 55929);

                                bool
                                lastCharIsLeading = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 55951, 55997);

                                BufferCell
                                lastLeadingCell = f_110_55980_55996()
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56028, 56037);
                                    for (int
                r = atRow
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56019, 60499) || true) && (r < bufferSize.Y + atRow)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56065, 56068)
                , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 56019, 60499))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 56019, 60499);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56127, 56136);
                                            for (int
                    c = atCol
                    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56118, 60476) || true) && (c < bufferSize.X + atCol)
                    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56164, 56167)
                    , c++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56169, 56191)
                    , characterBufferIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 56118, 60476))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 56118, 60476);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56249, 60449) || true) && (contents[r, c].BufferCellType == BufferCellType.Complete)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 56249, 60449);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56375, 56497);

                                                    characterBuffer[characterBufferIndex].UnicodeChar =
                                                                                        (ushort)contents[r, c].Character;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56531, 56705);

                                                    characterBuffer[characterBufferIndex].Attributes =
                                                                                        (ushort)(f_110_56628_56703(contents[r, c].ForegroundColor, contents[r, c].BackgroundColor));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56741, 56767);

                                                    lastCharIsLeading = false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 56249, 60449);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 56249, 60449);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56833, 60449) || true) && (contents[r, c].BufferCellType == BufferCellType.Leading)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 56833, 60449);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 56958, 57080);

                                                        characterBuffer[characterBufferIndex].UnicodeChar =
                                                                                            (ushort)contents[r, c].Character;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 57114, 57406);

                                                        characterBuffer[characterBufferIndex].Attributes =
                                                                                            (ushort)(f_110_57211_57286(contents[r, c].ForegroundColor, contents[r, c].BackgroundColor) | (ushort)NativeMethods.CHAR_INFO_Attributes.COMMON_LVB_LEADING_BYTE);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 57442, 57467);

                                                        lastCharIsLeading = true;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 57501, 57534);

                                                        lastLeadingCell = contents[r, c];
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 56833, 60449);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 56833, 60449);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 57600, 60449) || true) && (contents[r, c].BufferCellType == BufferCellType.Trailing)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 57600, 60449);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 59362, 60356) || true) && (lastCharIsLeading && (DynAbs.Tracing.TraceSender.Expression_True(110, 59366, 59400) && trueTypeInUse))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 59362, 60356);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 59592, 59670);

                                                                characterBuffer[characterBufferIndex].UnicodeChar = lastLeadingCell.Character;
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 59708, 60005);

                                                                characterBuffer[characterBufferIndex].Attributes =
                                                                                                        (ushort)(f_110_59809_59884(contents[r, c].ForegroundColor, contents[r, c].BackgroundColor) | (ushort)NativeMethods.CHAR_INFO_Attributes.COMMON_LVB_TRAILING_BYTE);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 59362, 60356);
                                                            }

                                                            else

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 59362, 60356);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 60298, 60321);

                                                                characterBufferIndex--;
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 59362, 60356);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 60392, 60418);

                                                            lastCharIsLeading = false;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 57600, 60449);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 56833, 60449);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 56249, 60449);
                                                }
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 4359);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 4359);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 4481);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 4481);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 60670, 60682);

                                bool
                                result
                                = default(bool);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 60704, 62104) || true) && ((rowType & BufferCellArrayRowType.RightLeading) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(110, 60708, 60822) && colsRemaining == bufferSize.X))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 60704, 62104);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 60872, 60897);

                                    COORD
                                    bSize = bufferSize
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 60923, 60933);

                                    bSize.X++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 60959, 60992);

                                    SMALL_RECT
                                    wRegion = writeRegion
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 61018, 61034);

                                    wRegion.Right++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 61243, 61517);

                                    result = f_110_61252_61516(f_110_61315_61349(consoleHandle), characterBuffer, bSize, bufferCoord, ref wRegion);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 60704, 62104);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 60704, 62104);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 61798, 62081);

                                    result = f_110_61807_62080(f_110_61870_61904(consoleHandle), characterBuffer, bufferSize, bufferCoord, ref writeRegion);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 60704, 62104);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62128, 63879) || true) && (result == false)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 62128, 63879);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62273, 62666) || true) && (bufferLimit < 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 62273, 62666);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62350, 62388);

                                        int
                                        err = f_110_62360_62387()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62418, 62601);

                                        HostException
                                        e = f_110_62436_62600(err, "WriteConsoleOutput", ErrorCategory.WriteError, f_110_62542_62599())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62631, 62639);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 62273, 62666);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62694, 62711);

                                    bufferLimit /= 2;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62737, 63856) || true) && (cols == colsRemaining)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 62737, 63856);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 62998, 63015);

                                        bufferSize.Y = 0;
                                        DynAbs.Tracing.TraceSender.TraceBreak(110, 63045, 63051);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 62737, 63856);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 62737, 63856);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 63572, 63701);

                                        f_110_63572_63700(bufferSize.Y == 1, f_110_63602_63699(f_110_63616_63644(), "bufferSize.Y should be 1, but is {0}", bufferSize.Y));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 63731, 63790);

                                        bufferSize.X = (short)f_110_63753_63789(colsRemaining, bufferLimit);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 63820, 63829);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 62737, 63856);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 62128, 63879);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 63903, 63933);

                                colsRemaining -= bufferSize.X;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 63955, 63988);

                                writeRegion.Left += bufferSize.X;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64010, 64069);

                                bufferSize.X = (short)f_110_64032_64068(colsRemaining, bufferLimit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 54902, 64088);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 54902, 64088);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 54902, 64088);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64129, 64159);

                        rowsRemaining -= bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64177, 64209);

                        writeRegion.Top += bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 53399, 64224);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 53399, 64224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 53399, 64224);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 52293, 64253);

                int
                f_110_52490_52592(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 52490, 52592);
                    return 0;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_FONT_INFO_EX
                f_110_52785_52818(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = GetConsoleFontInfo(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 52785, 52818);
                    return return_v;
                }


                int
                f_110_54241_54268(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 54241, 54268);
                    return return_v;
                }


                int
                f_110_54309_54535(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 54309, 54535);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell
                f_110_55980_55996()
                {
                    var return_v = new System.Management.Automation.Host.BufferCell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 55980, 55996);
                    return return_v;
                }


                ushort
                f_110_56628_56703(System.ConsoleColor
                foreground, System.ConsoleColor
                background)
                {
                    var return_v = ColorToWORD(foreground, background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 56628, 56703);
                    return return_v;
                }


                ushort
                f_110_57211_57286(System.ConsoleColor
                foreground, System.ConsoleColor
                background)
                {
                    var return_v = ColorToWORD(foreground, background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 57211, 57286);
                    return return_v;
                }


                ushort
                f_110_59809_59884(System.ConsoleColor
                foreground, System.ConsoleColor
                background)
                {
                    var return_v = ColorToWORD(foreground, background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 59809, 59884);
                    return return_v;
                }


                System.IntPtr
                f_110_61315_61349(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 61315, 61349);
                    return return_v;
                }


                bool
                f_110_61252_61516(System.IntPtr
                consoleOutput, Microsoft.PowerShell.ConsoleControl.CHAR_INFO[]
                buffer, Microsoft.PowerShell.ConsoleControl.COORD
                bufferSize, Microsoft.PowerShell.ConsoleControl.COORD
                bufferCoord, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                writeRegion)
                {
                    var return_v = NativeMethods.WriteConsoleOutput(consoleOutput, buffer, bufferSize, bufferCoord, ref writeRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 61252, 61516);
                    return return_v;
                }


                System.IntPtr
                f_110_61870_61904(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 61870, 61904);
                    return return_v;
                }


                bool
                f_110_61807_62080(System.IntPtr
                consoleOutput, Microsoft.PowerShell.ConsoleControl.CHAR_INFO[]
                buffer, Microsoft.PowerShell.ConsoleControl.COORD
                bufferSize, Microsoft.PowerShell.ConsoleControl.COORD
                bufferCoord, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                writeRegion)
                {
                    var return_v = NativeMethods.WriteConsoleOutput(consoleOutput, buffer, bufferSize, bufferCoord, ref writeRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 61807, 62080);
                    return return_v;
                }


                int
                f_110_62360_62387()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 62360, 62387);
                    return return_v;
                }


                string
                f_110_62542_62599()
                {
                    var return_v = ConsoleControlStrings.WriteConsoleOutputExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 62542, 62599);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_62436_62600(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 62436, 62600);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_110_63616_63644()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 63616, 63644);
                    return return_v;
                }


                string
                f_110_63602_63699(System.Globalization.CultureInfo
                provider, string
                format, short
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 63602, 63699);
                    return return_v;
                }


                int
                f_110_63572_63700(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 63572, 63700);
                    return 0;
                }


                int
                f_110_63753_63789(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 63753, 63789);
                    return return_v;
                }


                int
                f_110_64032_64068(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 64032, 64068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 52293, 64253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 52293, 64253);
            }
        }

        private static void WriteConsoleOutputPlain(ConsoleHandle consoleHandle, Coordinates origin, BufferCell[,] contents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 64265, 70337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64406, 64439);

                int
                rows = f_110_64417_64438(contents, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64453, 64486);

                int
                cols = f_110_64464_64485(contents, 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64502, 64666) || true) && ((rows <= 0) || (DynAbs.Tracing.TraceSender.Expression_False(110, 64506, 64530) || cols <= 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 64502, 64666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64564, 64626);

                    f_110_64564_64625(tracer, "contents passed in has 0 rows and columns");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64644, 64651);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 64502, 64666);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64682, 64709);

                int
                bufferLimit = 2 * 1024
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64778, 64796);

                COORD
                bufferCoord
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64812, 64830);

                bufferCoord.X = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64844, 64862);

                bufferCoord.Y = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64933, 64956);

                SMALL_RECT
                writeRegion
                = default(SMALL_RECT);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 64972, 65006);

                writeRegion.Top = (short)origin.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 65022, 65047);

                int
                rowsRemaining = rows
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 65063, 70308) || true) && (rowsRemaining > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 65063, 70308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 65791, 65826);

                        writeRegion.Left = (short)origin.X;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 65846, 65863);

                        COORD
                        bufferSize
                        = default(COORD);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 65883, 65933);

                        bufferSize.X = (short)f_110_65905_65932(cols, bufferLimit);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 65951, 66200);

                        bufferSize.Y = (short)f_110_65973_66199(rowsRemaining, bufferLimit / bufferSize.X);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 66218, 66283);

                        writeRegion.Bottom = (short)(writeRegion.Top + bufferSize.Y - 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 66393, 66454);

                        int
                        atRow = rows - rowsRemaining + f_110_66428_66453(contents, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 66530, 66555);

                        int
                        colsRemaining = cols
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 66575, 70172) || true) && (colsRemaining > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 66575, 70172);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 66641, 66706);

                                writeRegion.Right = (short)(writeRegion.Left + bufferSize.X - 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 66827, 66888);

                                int
                                atCol = cols - colsRemaining + f_110_66862_66887(contents, 1)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 66910, 66983);

                                CHAR_INFO[]
                                characterBuffer = new CHAR_INFO[bufferSize.Y * bufferSize.X]
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67074, 67083);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67085, 67109);

                                    // copy characterBuffer to contents;
                                    for (int
                r = atRow
                ,
                characterBufferIndex = 0
                ;
                (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67065, 67704) || true) && (r < bufferSize.Y + atRow)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67162, 67165)
                , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 67065, 67704))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 67065, 67704);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67224, 67233);
                                            for (int
                    c = atCol
                    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67215, 67681) || true) && (c < bufferSize.X + atCol)
                    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67261, 67264)
                    , c++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67266, 67288)
                    , characterBufferIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 67215, 67681))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 67215, 67681);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67346, 67464);

                                                characterBuffer[characterBufferIndex].UnicodeChar =
                                                                                (ushort)contents[r, c].Character;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67494, 67654);

                                                characterBuffer[characterBufferIndex].Attributes =
                                                f_110_67578_67653(contents[r, c].ForegroundColor, contents[r, c].BackgroundColor);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 467);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 467);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 640);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 640);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 67875, 68188);

                                bool
                                result =
                                f_110_67914_68187(f_110_67977_68011(consoleHandle), characterBuffer, bufferSize, bufferCoord, ref writeRegion)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 68212, 69963) || true) && (result == false)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 68212, 69963);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 68357, 68750) || true) && (bufferLimit < 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 68357, 68750);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 68434, 68472);

                                        int
                                        err = f_110_68444_68471()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 68502, 68685);

                                        HostException
                                        e = f_110_68520_68684(err, "WriteConsoleOutput", ErrorCategory.WriteError, f_110_68626_68683())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 68715, 68723);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 68357, 68750);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 68778, 68795);

                                    bufferLimit /= 2;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 68821, 69940) || true) && (cols == colsRemaining)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 68821, 69940);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 69082, 69099);

                                        bufferSize.Y = 0;
                                        DynAbs.Tracing.TraceSender.TraceBreak(110, 69129, 69135);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 68821, 69940);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 68821, 69940);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 69656, 69785);

                                        f_110_69656_69784(bufferSize.Y == 1, f_110_69686_69783(f_110_69700_69728(), "bufferSize.Y should be 1, but is {0}", bufferSize.Y));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 69815, 69874);

                                        bufferSize.X = (short)f_110_69837_69873(colsRemaining, bufferLimit);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 69904, 69913);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 68821, 69940);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 68212, 69963);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 69987, 70017);

                                colsRemaining -= bufferSize.X;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 70039, 70072);

                                writeRegion.Left += bufferSize.X;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 70094, 70153);

                                bufferSize.X = (short)f_110_70116_70152(colsRemaining, bufferLimit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 66575, 70172);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 66575, 70172);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 66575, 70172);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 70213, 70243);

                        rowsRemaining -= bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 70261, 70293);

                        writeRegion.Top += bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 65063, 70308);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 65063, 70308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 65063, 70308);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 64265, 70337);

                int
                f_110_64417_64438(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 64417, 64438);
                    return return_v;
                }


                int
                f_110_64464_64485(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 64464, 64485);
                    return return_v;
                }


                int
                f_110_64564_64625(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 64564, 64625);
                    return 0;
                }


                int
                f_110_65905_65932(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 65905, 65932);
                    return return_v;
                }


                int
                f_110_65973_66199(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 65973, 66199);
                    return return_v;
                }


                int
                f_110_66428_66453(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 66428, 66453);
                    return return_v;
                }


                int
                f_110_66862_66887(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 66862, 66887);
                    return return_v;
                }


                ushort
                f_110_67578_67653(System.ConsoleColor
                foreground, System.ConsoleColor
                background)
                {
                    var return_v = ColorToWORD(foreground, background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 67578, 67653);
                    return return_v;
                }


                System.IntPtr
                f_110_67977_68011(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 67977, 68011);
                    return return_v;
                }


                bool
                f_110_67914_68187(System.IntPtr
                consoleOutput, Microsoft.PowerShell.ConsoleControl.CHAR_INFO[]
                buffer, Microsoft.PowerShell.ConsoleControl.COORD
                bufferSize, Microsoft.PowerShell.ConsoleControl.COORD
                bufferCoord, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                writeRegion)
                {
                    var return_v = NativeMethods.WriteConsoleOutput(consoleOutput, buffer, bufferSize, bufferCoord, ref writeRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 67914, 68187);
                    return return_v;
                }


                int
                f_110_68444_68471()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 68444, 68471);
                    return return_v;
                }


                string
                f_110_68626_68683()
                {
                    var return_v = ConsoleControlStrings.WriteConsoleOutputExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 68626, 68683);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_68520_68684(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 68520, 68684);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_110_69700_69728()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 69700, 69728);
                    return return_v;
                }


                string
                f_110_69686_69783(System.Globalization.CultureInfo
                provider, string
                format, short
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 69686, 69783);
                    return return_v;
                }


                int
                f_110_69656_69784(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 69656, 69784);
                    return 0;
                }


                int
                f_110_69837_69873(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 69837, 69873);
                    return return_v;
                }


                int
                f_110_70116_70152(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 70116, 70152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 64265, 70337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 64265, 70337);
            }
        }

        internal static void ReadConsoleOutput
                (
                    ConsoleHandle consoleHandle,
                    Coordinates origin,
                    Rectangle contentsRegion,
                    ref BufferCell[,] contents
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 71273, 74365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71512, 71579);

                f_110_71512_71578(f_110_71523_71547_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71593, 71656);

                f_110_71593_71655(f_110_71604_71627_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71670, 71684);

                uint
                codePage
                = default(uint);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71698, 74354) || true) && (f_110_71702_71735(out codePage))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 71698, 74354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71769, 71853);

                    f_110_71769_71852(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71907, 71938);

                    BufferCell[,]
                    cellArray = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71956, 71980);

                    Coordinates
                    checkOrigin
                    = default(Coordinates);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 71998, 72093);

                    Rectangle
                    cellArrayRegion = f_110_72026_72092(0, 0, 1, contentsRegion.Bottom - contentsRegion.Top)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72111, 72973) || true) && (origin.X > 0 && (DynAbs.Tracing.TraceSender.Expression_True(110, 72115, 72189) && f_110_72131_72189(contentsRegion.Left, contents, contentsRegion)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 72111, 72973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72231, 72289);

                        cellArray = new BufferCell[cellArrayRegion.Bottom + 1, 2];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72311, 72365);

                        checkOrigin = f_110_72325_72364(origin.X - 1, origin.Y);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72387, 72503);

                        f_110_72387_72502(consoleHandle, codePage, checkOrigin, cellArrayRegion, ref cellArray);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72534, 72539);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72525, 72954) || true) && (i <= cellArrayRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72570, 72573)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 72525, 72954))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 72525, 72954);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72623, 72931) || true) && (cellArray[i, 0].BufferCellType == BufferCellType.Leading)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 72623, 72931);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72741, 72797);

                                    contents[contentsRegion.Top + i, 0].Character = (char)0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 72827, 72904);

                                    contents[contentsRegion.Top + i, 0].BufferCellType = BufferCellType.Trailing;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 72623, 72931);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 430);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 430);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 72111, 72973);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73030, 73148);

                    ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                    bufferInfo =
                    f_110_73106_73147(consoleHandle)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73166, 74197) || true) && (origin.X + (contentsRegion.Right - contentsRegion.Left) + 1 < bufferInfo.BufferSize.X && (DynAbs.Tracing.TraceSender.Expression_True(110, 73170, 73339) && f_110_73280_73339(contentsRegion.Right, contents, contentsRegion)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 73166, 74197);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73381, 73533) || true) && (cellArray == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 73381, 73533);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73452, 73510);

                            cellArray = new BufferCell[cellArrayRegion.Bottom + 1, 2];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 73381, 73533);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73557, 73679);

                        checkOrigin = f_110_73571_73678(origin.X +
                                                (contentsRegion.Right - contentsRegion.Left), origin.Y);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73701, 73817);

                        f_110_73701_73816(consoleHandle, codePage, checkOrigin, cellArrayRegion, ref cellArray);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73848, 73853);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73839, 74178) || true) && (i <= cellArrayRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73884, 73887)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 73839, 74178))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 73839, 74178);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 73937, 74155) || true) && (cellArray[i, 0].BufferCellType == BufferCellType.Leading)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 73937, 74155);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 74055, 74128);

                                    contents[contentsRegion.Top + i, contentsRegion.Right] = cellArray[i, 0];
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 73937, 74155);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 340);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 340);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 73166, 74197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 71698, 74354);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 71698, 74354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 74263, 74339);

                    f_110_74263_74338(consoleHandle, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 71698, 74354);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 71273, 74365);

                bool
                f_110_71523_71547_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 71523, 71547);
                    return return_v;
                }


                int
                f_110_71512_71578(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 71512, 71578);
                    return 0;
                }


                bool
                f_110_71604_71627_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 71604, 71627);
                    return return_v;
                }


                int
                f_110_71593_71655(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 71593, 71655);
                    return 0;
                }


                bool
                f_110_71702_71735(out uint
                codePage)
                {
                    var return_v = IsCJKOutputCodePage(out codePage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 71702, 71735);
                    return return_v;
                }


                int
                f_110_71769_71852(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ReadConsoleOutputCJK(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 71769, 71852);
                    return 0;
                }


                System.Management.Automation.Host.Rectangle
                f_110_72026_72092(int
                left, int
                top, int
                right, int
                bottom)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(left, top, right, bottom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 72026, 72092);
                    return return_v;
                }


                bool
                f_110_72131_72189(int
                edge, System.Management.Automation.Host.BufferCell[,]
                contents, System.Management.Automation.Host.Rectangle
                contentsRegion)
                {
                    var return_v = ShouldCheck(edge, contents, contentsRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 72131, 72189);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_110_72325_72364(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 72325, 72364);
                    return return_v;
                }


                int
                f_110_72387_72502(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ReadConsoleOutputCJK(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 72387, 72502);
                    return 0;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                f_110_73106_73147(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = GetConsoleScreenBufferInfo(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 73106, 73147);
                    return return_v;
                }


                bool
                f_110_73280_73339(int
                edge, System.Management.Automation.Host.BufferCell[,]
                contents, System.Management.Automation.Host.Rectangle
                contentsRegion)
                {
                    var return_v = ShouldCheck(edge, contents, contentsRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 73280, 73339);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_110_73571_73678(int
                x, int
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 73571, 73678);
                    return return_v;
                }


                int
                f_110_73701_73816(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ReadConsoleOutputCJK(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 73701, 73816);
                    return 0;
                }


                int
                f_110_74263_74338(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    ReadConsoleOutputPlain(consoleHandle, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 74263, 74338);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 71273, 74365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 71273, 74365);
            }
        }

        private static bool ShouldCheck(int edge, BufferCell[,] contents, Rectangle contentsRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 74812, 75192);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 74937, 74959);
                    for (int
        i = contentsRegion.Top
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 74928, 75152) || true) && (i <= contentsRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 74989, 74992)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 74928, 75152))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 74928, 75152);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75026, 75137) || true) && (contents[i, edge].Character == ' ')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 75026, 75137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75106, 75118);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 75026, 75137);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75168, 75181);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 74812, 75192);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 74812, 75192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 74812, 75192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReadConsoleOutputCJKSmall
                (
                    ConsoleHandle consoleHandle,
                    uint codePage,
                    Coordinates origin,
                    Rectangle contentsRegion,
                    ref BufferCell[,] contents
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 75204, 79810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75478, 75495);

                COORD
                bufferSize
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75509, 75580);

                bufferSize.X = (short)(contentsRegion.Right - contentsRegion.Left + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75594, 75665);

                bufferSize.Y = (short)(contentsRegion.Bottom - contentsRegion.Top + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75679, 75697);

                COORD
                bufferCoord
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75711, 75729);

                bufferCoord.X = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75743, 75761);

                bufferCoord.Y = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75775, 75848);

                CHAR_INFO[]
                characterBuffer = new CHAR_INFO[bufferSize.X * bufferSize.Y]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75862, 75884);

                SMALL_RECT
                readRegion
                = default(SMALL_RECT);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75898, 75932);

                readRegion.Left = (short)origin.X;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75946, 75979);

                readRegion.Top = (short)origin.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 75993, 76049);

                readRegion.Right = (short)(origin.X + bufferSize.X - 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76063, 76120);

                readRegion.Bottom = (short)(origin.Y + bufferSize.Y - 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76293, 76639);

                bool
                result = f_110_76307_76638(f_110_76381_76415(consoleHandle), characterBuffer, bufferSize, bufferCoord, ref readRegion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76653, 76726) || true) && (!result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 76653, 76726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76698, 76711);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 76653, 76726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76742, 76771);

                int
                characterBufferIndex = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76796, 76818);

                    for (int
        r = contentsRegion.Top
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76787, 79771) || true) && (r <= contentsRegion.Bottom)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76848, 76851)
        , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 76787, 79771))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 76787, 79771);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76894, 76917);
                            for (int
            c = contentsRegion.Left
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76885, 79756) || true) && (c <= contentsRegion.Right)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76946, 76949)
            , c++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 76951, 76973)
            , characterBufferIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 76885, 79756))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 76885, 79756);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 77015, 77045);

                                ConsoleColor
                                fgColor
                                = default(ConsoleColor),
                                bgColor
                                = default(ConsoleColor);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 77069, 77152);

                                contents[r, c].Character = (char)characterBuffer[characterBufferIndex].UnicodeChar;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 77174, 77328);

                                f_110_77174_77327(characterBuffer[characterBufferIndex].Attributes, out fgColor, out bgColor);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 77350, 77391);

                                contents[r, c].ForegroundColor = fgColor;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 77413, 77454);

                                contents[r, c].BackgroundColor = bgColor;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 77899, 79737) || true) && ((characterBuffer[characterBufferIndex].Attributes & (ushort)NativeMethods.CHAR_INFO_Attributes.COMMON_LVB_LEADING_BYTE)
                                                            == (ushort)NativeMethods.CHAR_INFO_Attributes.COMMON_LVB_LEADING_BYTE)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 77899, 79737);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 78171, 78226);

                                    contents[r, c].BufferCellType = BufferCellType.Leading;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 77899, 79737);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 77899, 79737);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 78276, 79737) || true) && ((characterBuffer[characterBufferIndex].Attributes & (ushort)NativeMethods.CHAR_INFO_Attributes.COMMON_LVB_TRAILING_BYTE)
                                                                == (ushort)NativeMethods.CHAR_INFO_Attributes.COMMON_LVB_TRAILING_BYTE)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 78276, 79737);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 78550, 78585);

                                        contents[r, c].Character = (char)0;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 78611, 78667);

                                        contents[r, c].BufferCellType = BufferCellType.Trailing;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 78276, 79737);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 78276, 79737);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 78765, 78828);

                                        int
                                        charLength = f_110_78782_78827(contents[r, c].Character)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 78854, 79714) || true) && (charLength == 2)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 78854, 79714);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79135, 79190);

                                            contents[r, c].BufferCellType = BufferCellType.Leading;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79220, 79224);

                                            c++;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79254, 79289);

                                            contents[r, c].Character = (char)0;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79319, 79360);

                                            contents[r, c].ForegroundColor = fgColor;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79390, 79431);

                                            contents[r, c].BackgroundColor = bgColor;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79461, 79517);

                                            contents[r, c].BufferCellType = BufferCellType.Trailing;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 78854, 79714);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 78854, 79714);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79631, 79687);

                                            contents[r, c].BufferCellType = BufferCellType.Complete;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 78854, 79714);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 78276, 79737);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 77899, 79737);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 2872);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 2872);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 2985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 2985);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 79787, 79799);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 75204, 79810);

                System.IntPtr
                f_110_76381_76415(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 76381, 76415);
                    return return_v;
                }


                bool
                f_110_76307_76638(System.IntPtr
                consoleOutput, Microsoft.PowerShell.ConsoleControl.CHAR_INFO[]
                buffer, Microsoft.PowerShell.ConsoleControl.COORD
                bufferSize, Microsoft.PowerShell.ConsoleControl.COORD
                bufferCoord, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                readRegion)
                {
                    var return_v = NativeMethods.ReadConsoleOutput(consoleOutput, buffer, bufferSize, bufferCoord, ref readRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 76307, 76638);
                    return return_v;
                }


                int
                f_110_77174_77327(ushort
                attribute, out System.ConsoleColor
                foreground, out System.ConsoleColor
                background)
                {
                    WORDToColor(attribute, out foreground, out background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 77174, 77327);
                    return 0;
                }


                int
                f_110_78782_78827(char
                c)
                {
                    var return_v = LengthInBufferCells(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 78782, 78827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 75204, 79810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 75204, 79810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReadConsoleOutputCJK
                (
                    ConsoleHandle consoleHandle,
                    uint codePage,
                    Coordinates origin,
                    Rectangle contentsRegion,
                    ref BufferCell[,] contents
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 80359, 88180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 80629, 80687);

                int
                rows = contentsRegion.Bottom - contentsRegion.Top + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 80701, 80759);

                int
                cols = contentsRegion.Right - contentsRegion.Left + 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 80775, 80921) || true) && ((rows <= 0) || (DynAbs.Tracing.TraceSender.Expression_False(110, 80779, 80803) || cols <= 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 80775, 80921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 80837, 80881);

                    f_110_80837_80880(tracer, "invalid contents region");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 80899, 80906);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 80775, 80921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 80937, 80964);

                int
                bufferLimit = 2 * 1024
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 81033, 81051);

                COORD
                bufferCoord
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 81067, 81085);

                bufferCoord.X = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 81099, 81117);

                bufferCoord.Y = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 81190, 81212);

                SMALL_RECT
                readRegion
                = default(SMALL_RECT);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 81228, 81261);

                readRegion.Top = (short)origin.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 81277, 81302);

                int
                rowsRemaining = rows
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 81318, 86226) || true) && (rowsRemaining > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 81318, 86226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82041, 82075);

                        readRegion.Left = (short)origin.X;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82095, 82112);

                        COORD
                        bufferSize
                        = default(COORD);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82130, 82180);

                        bufferSize.X = (short)f_110_82152_82179(cols, bufferLimit);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82198, 82447);

                        bufferSize.Y = (short)f_110_82220_82446(rowsRemaining, bufferLimit / bufferSize.X);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82465, 82528);

                        readRegion.Bottom = (short)(readRegion.Top + bufferSize.Y - 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82646, 82708);

                        int
                        atContentsRow = rows - rowsRemaining + contentsRegion.Top
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82781, 82806);

                        int
                        colsRemaining = cols
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82826, 86091) || true) && (colsRemaining > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 82826, 86091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 82997, 83060);

                                int
                                atContentsCol = cols - colsRemaining + contentsRegion.Left
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 83084, 83147);

                                readRegion.Right = (short)(readRegion.Left + bufferSize.X - 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 83238, 83406);

                                Rectangle
                                atContents = f_110_83261_83405(atContentsCol, atContentsRow, atContentsCol + bufferSize.X - 1, atContentsRow + bufferSize.Y - 1)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 83428, 83681);

                                bool
                                result =
                                f_110_83467_83680(consoleHandle, codePage, f_110_83547_83595(readRegion.Left, readRegion.Top), atContents, ref contents)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 83703, 85589) || true) && (result == false)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 83703, 85589);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 83848, 85566) || true) && (bufferLimit < 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 83848, 85566);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 83925, 83963);

                                        int
                                        err = f_110_83935_83962()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 83995, 84175);

                                        HostException
                                        e = f_110_84013_84174(err, "ReadConsoleOutput", ErrorCategory.ReadError, f_110_84117_84173())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 84205, 84213);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 83848, 85566);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 83848, 85566);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 84499, 84516);

                                        bufferLimit /= 2;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 84546, 85539) || true) && (cols == colsRemaining)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 84546, 85539);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 84637, 84654);

                                            bufferSize.Y = 0;
                                            DynAbs.Tracing.TraceSender.TraceBreak(110, 84688, 84694);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 84546, 85539);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 84546, 85539);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85243, 85372);

                                            f_110_85243_85371(bufferSize.Y == 1, f_110_85273_85370(f_110_85287_85315(), "bufferSize.Y should be 1, but is {0}", bufferSize.Y));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85406, 85465);

                                            bufferSize.X = (short)f_110_85428_85464(colsRemaining, bufferLimit);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85499, 85508);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 84546, 85539);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 83848, 85566);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 83703, 85589);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85613, 85643);

                                colsRemaining -= bufferSize.X;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85665, 85697);

                                readRegion.Left += bufferSize.X;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85719, 85989) || true) && (colsRemaining > 0 && (DynAbs.Tracing.TraceSender.Expression_True(110, 85723, 85763) && (bufferSize.Y == 1)) && (DynAbs.Tracing.TraceSender.Expression_True(110, 85723, 85856) && (contents[atContents.Bottom, atContents.Right].Character == ' ')))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 85719, 85989);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85906, 85922);

                                    colsRemaining++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 85948, 85966);

                                    readRegion.Left--;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 85719, 85989);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86013, 86072);

                                bufferSize.X = (short)f_110_86035_86071(colsRemaining, bufferLimit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 82826, 86091);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 82826, 86091);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 82826, 86091);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86132, 86162);

                        rowsRemaining -= bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86180, 86211);

                        readRegion.Top += bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 81318, 86226);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 81318, 86226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 81318, 86226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86507, 86548);

                int
                rowIndex = f_110_86522_86547(contents, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86562, 86601);

                int
                rowEnd = f_110_86575_86600(contents, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86615, 86656);

                int
                colBegin = f_110_86630_86655(contents, 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86670, 86709);

                int
                colEnd = f_110_86683_86708(contents, 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86723, 86830);

                CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo =
                f_110_86788_86829(consoleHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86844, 86872);

                ConsoleColor
                foreground = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86886, 86914);

                ConsoleColor
                background = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 86930, 87111);

                f_110_86930_87110(bufferInfo.Attributes, out foreground, out background);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 87127, 88169) || true) && (rowIndex <= rowEnd)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 87127, 88169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 87186, 87210);

                        int
                        colIndex = colBegin
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 87228, 88123) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 87228, 88123);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 87464, 87740) || true) && (contentsRegion.Top <= rowIndex && (DynAbs.Tracing.TraceSender.Expression_True(110, 87468, 87535) && rowIndex <= contentsRegion.Bottom) && (DynAbs.Tracing.TraceSender.Expression_True(110, 87468, 87595) && contentsRegion.Left <= colIndex) && (DynAbs.Tracing.TraceSender.Expression_True(110, 87468, 87631) && colIndex <= contentsRegion.Right))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 87464, 87740);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 87681, 87717);

                                    colIndex = contentsRegion.Right + 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 87464, 87740);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 87821, 87921) || true) && (colIndex > colEnd)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 87821, 87921);
                                    DynAbs.Tracing.TraceSender.TraceBreak(110, 87892, 87898);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 87821, 87921);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 87945, 88071);

                                contents[rowIndex, colIndex] = f_110_87976_88070(' ', foreground, background, BufferCellType.Complete);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88093, 88104);

                                colIndex++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 87228, 88123);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 87228, 88123);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 87228, 88123);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88143, 88154);

                        rowIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 87127, 88169);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 87127, 88169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 87127, 88169);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 80359, 88180);

                int
                f_110_80837_80880(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 80837, 80880);
                    return 0;
                }


                int
                f_110_82152_82179(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 82152, 82179);
                    return return_v;
                }


                int
                f_110_82220_82446(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 82220, 82446);
                    return return_v;
                }


                System.Management.Automation.Host.Rectangle
                f_110_83261_83405(int
                left, int
                top, int
                right, int
                bottom)
                {
                    var return_v = new System.Management.Automation.Host.Rectangle(left, top, right, bottom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 83261, 83405);
                    return return_v;
                }


                System.Management.Automation.Host.Coordinates
                f_110_83547_83595(short
                x, short
                y)
                {
                    var return_v = new System.Management.Automation.Host.Coordinates((int)x, (int)y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 83547, 83595);
                    return return_v;
                }


                bool
                f_110_83467_83680(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, uint
                codePage, System.Management.Automation.Host.Coordinates
                origin, System.Management.Automation.Host.Rectangle
                contentsRegion, ref System.Management.Automation.Host.BufferCell[,]
                contents)
                {
                    var return_v = ReadConsoleOutputCJKSmall(consoleHandle, codePage, origin, contentsRegion, ref contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 83467, 83680);
                    return return_v;
                }


                int
                f_110_83935_83962()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 83935, 83962);
                    return return_v;
                }


                string
                f_110_84117_84173()
                {
                    var return_v = ConsoleControlStrings.ReadConsoleOutputExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 84117, 84173);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_84013_84174(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 84013, 84174);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_110_85287_85315()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 85287, 85315);
                    return return_v;
                }


                string
                f_110_85273_85370(System.Globalization.CultureInfo
                provider, string
                format, short
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 85273, 85370);
                    return return_v;
                }


                int
                f_110_85243_85371(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 85243, 85371);
                    return 0;
                }


                int
                f_110_85428_85464(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 85428, 85464);
                    return return_v;
                }


                int
                f_110_86035_86071(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 86035, 86071);
                    return return_v;
                }


                int
                f_110_86522_86547(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 86522, 86547);
                    return return_v;
                }


                int
                f_110_86575_86600(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetUpperBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 86575, 86600);
                    return return_v;
                }


                int
                f_110_86630_86655(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 86630, 86655);
                    return return_v;
                }


                int
                f_110_86683_86708(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetUpperBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 86683, 86708);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                f_110_86788_86829(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = GetConsoleScreenBufferInfo(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 86788, 86829);
                    return return_v;
                }


                int
                f_110_86930_87110(ushort
                attribute, out System.ConsoleColor
                foreground, out System.ConsoleColor
                background)
                {
                    WORDToColor(attribute, out foreground, out background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 86930, 87110);
                    return 0;
                }


                System.Management.Automation.Host.BufferCell
                f_110_87976_88070(char
                character, System.ConsoleColor
                foreground, System.ConsoleColor
                background, System.Management.Automation.Host.BufferCellType
                bufferCellType)
                {
                    var return_v = new System.Management.Automation.Host.BufferCell(character, foreground, background, bufferCellType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 87976, 88070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 80359, 88180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 80359, 88180);
            }
        }

        private static void ReadConsoleOutputPlain
                (
                    ConsoleHandle consoleHandle,
                    Coordinates origin,
                    Rectangle contentsRegion,
                    ref BufferCell[,] contents
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 88234, 96662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88477, 88535);

                int
                rows = contentsRegion.Bottom - contentsRegion.Top + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88549, 88607);

                int
                cols = contentsRegion.Right - contentsRegion.Left + 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88623, 88769) || true) && ((rows <= 0) || (DynAbs.Tracing.TraceSender.Expression_False(110, 88627, 88651) || cols <= 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 88623, 88769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88685, 88729);

                    f_110_88685_88728(tracer, "invalid contents region");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88747, 88754);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 88623, 88769);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88785, 88812);

                int
                bufferLimit = 2 * 1024
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88881, 88899);

                COORD
                bufferCoord
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88915, 88933);

                bufferCoord.X = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 88947, 88965);

                bufferCoord.Y = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 89035, 89057);

                SMALL_RECT
                readRegion
                = default(SMALL_RECT);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 89073, 89106);

                readRegion.Top = (short)origin.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 89122, 89147);

                int
                rowsRemaining = rows
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 89163, 94630) || true) && (rowsRemaining > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 89163, 94630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 89886, 89920);

                        readRegion.Left = (short)origin.X;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 89940, 89957);

                        COORD
                        bufferSize
                        = default(COORD);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 89975, 90025);

                        bufferSize.X = (short)f_110_89997_90024(cols, bufferLimit);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 90043, 90292);

                        bufferSize.Y = (short)f_110_90065_90291(rowsRemaining, bufferLimit / bufferSize.X);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 90310, 90373);

                        readRegion.Bottom = (short)(readRegion.Top + bufferSize.Y - 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 90491, 90553);

                        int
                        atContentsRow = rows - rowsRemaining + contentsRegion.Top
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 90626, 90651);

                        int
                        colsRemaining = cols
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 90671, 94495) || true) && (colsRemaining > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 90671, 94495);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 90737, 90800);

                                readRegion.Right = (short)(readRegion.Left + bufferSize.X - 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 90952, 91025);

                                CHAR_INFO[]
                                characterBuffer = new CHAR_INFO[bufferSize.Y * bufferSize.X]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 91047, 91393);

                                bool
                                result = f_110_91061_91392(f_110_91135_91169(consoleHandle), characterBuffer, bufferSize, bufferCoord, ref readRegion)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 91417, 93147) || true) && (result == false)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 91417, 93147);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 91562, 91954) || true) && (bufferLimit < 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 91562, 91954);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 91639, 91677);

                                        int
                                        err = f_110_91649_91676()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 91709, 91889);

                                        HostException
                                        e = f_110_91727_91888(err, "ReadConsoleOutput", ErrorCategory.ReadError, f_110_91831_91887())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 91919, 91927);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 91562, 91954);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 92144, 92161);

                                    bufferLimit /= 2;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 92187, 93124) || true) && (cols == colsRemaining)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 92187, 93124);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 92270, 92287);

                                        bufferSize.Y = 0;
                                        DynAbs.Tracing.TraceSender.TraceBreak(110, 92317, 92323);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 92187, 93124);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 92187, 93124);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 92840, 92969);

                                        f_110_92840_92968(bufferSize.Y == 1, f_110_92870_92967(f_110_92884_92912(), "bufferSize.Y should be 1, but is {0}", bufferSize.Y));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 92999, 93058);

                                        bufferSize.X = (short)f_110_93021_93057(colsRemaining, bufferLimit);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93088, 93097);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 92187, 93124);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 91417, 93147);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93276, 93339);

                                int
                                atContentsCol = cols - colsRemaining + contentsRegion.Left
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93421, 93450);

                                int
                                characterBufferIndex = 0
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93481, 93498);
                                    for (int
                r = atContentsRow
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93472, 94287) || true) && (r < bufferSize.Y + atContentsRow)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93534, 93537)
                , r++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 93472, 94287))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 93472, 94287);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93596, 93613);
                                            for (int
                    c = atContentsCol
                    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93587, 94264) || true) && (c < bufferSize.X + atContentsCol)
                    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93649, 93652)
                    , c++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93654, 93676)
                    , characterBufferIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(110, 93587, 94264))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 93587, 94264);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93734, 93851);

                                                contents[r, c].Character = (char)
                                                                                characterBuffer[characterBufferIndex].UnicodeChar;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93881, 93911);

                                                ConsoleColor
                                                fgColor
                                                = default(ConsoleColor),
                                                bgColor
                                                = default(ConsoleColor);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 93941, 94095);

                                                f_110_93941_94094(characterBuffer[characterBufferIndex].Attributes, out fgColor, out bgColor);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94125, 94166);

                                                contents[r, c].ForegroundColor = fgColor;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94196, 94237);

                                                contents[r, c].BackgroundColor = bgColor;
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 678);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 678);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 816);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 816);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94311, 94341);

                                colsRemaining -= bufferSize.X;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94363, 94395);

                                readRegion.Left += bufferSize.X;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94417, 94476);

                                bufferSize.X = (short)f_110_94439_94475(colsRemaining, bufferLimit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 90671, 94495);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 90671, 94495);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 90671, 94495);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94536, 94566);

                        rowsRemaining -= bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94584, 94615);

                        readRegion.Top += bufferSize.Y;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 89163, 94630);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 89163, 94630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 89163, 94630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94911, 94952);

                int
                rowIndex = f_110_94926_94951(contents, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 94966, 95005);

                int
                rowEnd = f_110_94979_95004(contents, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95019, 95060);

                int
                colBegin = f_110_95034_95059(contents, 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95074, 95113);

                int
                colEnd = f_110_95087_95112(contents, 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95127, 95234);

                CONSOLE_SCREEN_BUFFER_INFO
                bufferInfo =
                f_110_95192_95233(consoleHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95248, 95276);

                ConsoleColor
                foreground = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95290, 95318);

                ConsoleColor
                background = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95334, 95514);

                f_110_95334_95513(bufferInfo.Attributes, out foreground, out background);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95530, 96651) || true) && (rowIndex <= rowEnd)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 95530, 96651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95589, 95613);

                        int
                        colIndex = colBegin
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95631, 96605) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 95631, 96605);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 95867, 96143) || true) && (contentsRegion.Top <= rowIndex && (DynAbs.Tracing.TraceSender.Expression_True(110, 95871, 95938) && rowIndex <= contentsRegion.Bottom) && (DynAbs.Tracing.TraceSender.Expression_True(110, 95871, 95998) && contentsRegion.Left <= colIndex) && (DynAbs.Tracing.TraceSender.Expression_True(110, 95871, 96034) && colIndex <= contentsRegion.Right))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 95867, 96143);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 96084, 96120);

                                    colIndex = contentsRegion.Right + 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 95867, 96143);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 96224, 96324) || true) && (colIndex > colEnd)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 96224, 96324);
                                    DynAbs.Tracing.TraceSender.TraceBreak(110, 96295, 96301);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 96224, 96324);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 96348, 96393);

                                contents[rowIndex, colIndex].Character = ' ';
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 96415, 96473);

                                contents[rowIndex, colIndex].ForegroundColor = foreground;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 96495, 96553);

                                contents[rowIndex, colIndex].BackgroundColor = background;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 96575, 96586);

                                colIndex++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 95631, 96605);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 95631, 96605);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(110, 95631, 96605);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 96625, 96636);

                        rowIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 95530, 96651);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 95530, 96651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 95530, 96651);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 88234, 96662);

                int
                f_110_88685_88728(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 88685, 88728);
                    return 0;
                }


                int
                f_110_89997_90024(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 89997, 90024);
                    return return_v;
                }


                int
                f_110_90065_90291(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 90065, 90291);
                    return return_v;
                }


                System.IntPtr
                f_110_91135_91169(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 91135, 91169);
                    return return_v;
                }


                bool
                f_110_91061_91392(System.IntPtr
                consoleOutput, Microsoft.PowerShell.ConsoleControl.CHAR_INFO[]
                buffer, Microsoft.PowerShell.ConsoleControl.COORD
                bufferSize, Microsoft.PowerShell.ConsoleControl.COORD
                bufferCoord, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                readRegion)
                {
                    var return_v = NativeMethods.ReadConsoleOutput(consoleOutput, buffer, bufferSize, bufferCoord, ref readRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 91061, 91392);
                    return return_v;
                }


                int
                f_110_91649_91676()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 91649, 91676);
                    return return_v;
                }


                string
                f_110_91831_91887()
                {
                    var return_v = ConsoleControlStrings.ReadConsoleOutputExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 91831, 91887);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_91727_91888(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 91727, 91888);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_110_92884_92912()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 92884, 92912);
                    return return_v;
                }


                string
                f_110_92870_92967(System.Globalization.CultureInfo
                provider, string
                format, short
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 92870, 92967);
                    return return_v;
                }


                int
                f_110_92840_92968(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 92840, 92968);
                    return 0;
                }


                int
                f_110_93021_93057(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 93021, 93057);
                    return return_v;
                }


                int
                f_110_93941_94094(ushort
                attribute, out System.ConsoleColor
                foreground, out System.ConsoleColor
                background)
                {
                    WORDToColor(attribute, out foreground, out background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 93941, 94094);
                    return 0;
                }


                int
                f_110_94439_94475(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 94439, 94475);
                    return return_v;
                }


                int
                f_110_94926_94951(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 94926, 94951);
                    return return_v;
                }


                int
                f_110_94979_95004(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetUpperBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 94979, 95004);
                    return return_v;
                }


                int
                f_110_95034_95059(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 95034, 95059);
                    return return_v;
                }


                int
                f_110_95087_95112(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetUpperBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 95087, 95112);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_SCREEN_BUFFER_INFO
                f_110_95192_95233(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle)
                {
                    var return_v = GetConsoleScreenBufferInfo(consoleHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 95192, 95233);
                    return return_v;
                }


                int
                f_110_95334_95513(ushort
                attribute, out System.ConsoleColor
                foreground, out System.ConsoleColor
                background)
                {
                    WORDToColor(attribute, out foreground, out background);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 95334, 95513);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 88234, 96662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 88234, 96662);
            }
        }

        internal static void FillConsoleOutputCharacter
                (
                    ConsoleHandle consoleHandle,
                    char character,
                    int numberToWrite,
                    Coordinates origin
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 97365, 98723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 97594, 97661);

                f_110_97594_97660(f_110_97605_97629_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 97675, 97738);

                f_110_97675_97737(f_110_97686_97709_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 97754, 97762);

                COORD
                c
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 97778, 97800);

                c.X = (short)origin.X;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 97814, 97836);

                c.Y = (short)origin.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 97852, 97869);

                DWORD
                unused = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 97883, 98145);

                bool
                result =
                f_110_97914_98144(f_110_97977_98011(consoleHandle), character, numberToWrite, c, out unused)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 98159, 98498) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 98159, 98498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 98212, 98250);

                    int
                    err = f_110_98222_98249()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 98270, 98457);

                    HostException
                    e = f_110_98288_98456(err, "FillConsoleOutputCharacter", ErrorCategory.WriteError, f_110_98390_98455())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 98475, 98483);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 98159, 98498);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 97365, 98723);

                bool
                f_110_97605_97629_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 97605, 97629);
                    return return_v;
                }


                int
                f_110_97594_97660(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 97594, 97660);
                    return 0;
                }


                bool
                f_110_97686_97709_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 97686, 97709);
                    return return_v;
                }


                int
                f_110_97675_97737(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 97675, 97737);
                    return 0;
                }


                System.IntPtr
                f_110_97977_98011(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 97977, 98011);
                    return return_v;
                }


                bool
                f_110_97914_98144(System.IntPtr
                consoleOutput, char
                character, int
                length, Microsoft.PowerShell.ConsoleControl.COORD
                writeCoord, out uint
                numberOfCharsWritten)
                {
                    var return_v = NativeMethods.FillConsoleOutputCharacter(consoleOutput, character, (uint)length, writeCoord, out numberOfCharsWritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 97914, 98144);
                    return return_v;
                }


                int
                f_110_98222_98249()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 98222, 98249);
                    return return_v;
                }


                string
                f_110_98390_98455()
                {
                    var return_v = ConsoleControlStrings.FillConsoleOutputCharacterExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 98390, 98455);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_98288_98456(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 98288, 98456);
                    return return_v;
                }

                // we don't assert that the number actually written matches the number we asked for, as the function may clip if
                // the number of cells to write extends past the end of the screen buffer.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 97365, 98723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 97365, 98723);
            }
        }

        internal static void FillConsoleOutputAttribute
                (
                    ConsoleHandle consoleHandle,
                    WORD attribute,
                    int numberToWrite,
                    Coordinates origin
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 99426, 100572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 99655, 99722);

                f_110_99655_99721(f_110_99666_99690_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 99736, 99799);

                f_110_99736_99798(f_110_99747_99770_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 99815, 99823);

                COORD
                c
                = default(COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 99839, 99861);

                c.X = (short)origin.X;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 99875, 99897);

                c.Y = (short)origin.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 99913, 99930);

                DWORD
                unused = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 99944, 100206);

                bool
                result =
                f_110_99975_100205(f_110_100038_100072(consoleHandle), attribute, numberToWrite, c, out unused)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 100222, 100561) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 100222, 100561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 100275, 100313);

                    int
                    err = f_110_100285_100312()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 100333, 100520);

                    HostException
                    e = f_110_100351_100519(err, "FillConsoleOutputAttribute", ErrorCategory.WriteError, f_110_100453_100518())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 100538, 100546);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 100222, 100561);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 99426, 100572);

                bool
                f_110_99666_99690_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 99666, 99690);
                    return return_v;
                }


                int
                f_110_99655_99721(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 99655, 99721);
                    return 0;
                }


                bool
                f_110_99747_99770_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 99747, 99770);
                    return return_v;
                }


                int
                f_110_99736_99798(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 99736, 99798);
                    return 0;
                }


                System.IntPtr
                f_110_100038_100072(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 100038, 100072);
                    return return_v;
                }


                bool
                f_110_99975_100205(System.IntPtr
                consoleOutput, ushort
                attribute, int
                length, Microsoft.PowerShell.ConsoleControl.COORD
                writeCoord, out uint
                numberOfAttrsWritten)
                {
                    var return_v = NativeMethods.FillConsoleOutputAttribute(consoleOutput, attribute, (uint)length, writeCoord, out numberOfAttrsWritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 99975, 100205);
                    return return_v;
                }


                int
                f_110_100285_100312()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 100285, 100312);
                    return return_v;
                }


                string
                f_110_100453_100518()
                {
                    var return_v = ConsoleControlStrings.FillConsoleOutputAttributeExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 100453, 100518);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_100351_100519(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 100351, 100519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 99426, 100572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 99426, 100572);
            }
        }

        internal static void ScrollConsoleScreenBuffer
                (
                    ConsoleHandle consoleHandle,
                    SMALL_RECT scrollRectangle,
                    SMALL_RECT clipRectangle,
                    COORD destOrigin, CHAR_INFO fill
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 101422, 102482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 101683, 101750);

                f_110_101683_101749(f_110_101694_101718_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 101764, 101827);

                f_110_101764_101826(f_110_101775_101798_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 101843, 102118);

                bool
                result =
                f_110_101874_102117(f_110_101936_101970(consoleHandle), ref scrollRectangle, ref clipRectangle, destOrigin, ref fill)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 102134, 102471) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 102134, 102471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 102187, 102225);

                    int
                    err = f_110_102197_102224()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 102245, 102430);

                    HostException
                    e = f_110_102263_102429(err, "ScrollConsoleScreenBuffer", ErrorCategory.WriteError, f_110_102364_102428())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 102448, 102456);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 102134, 102471);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 101422, 102482);

                bool
                f_110_101694_101718_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 101694, 101718);
                    return return_v;
                }


                int
                f_110_101683_101749(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 101683, 101749);
                    return 0;
                }


                bool
                f_110_101775_101798_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 101775, 101798);
                    return return_v;
                }


                int
                f_110_101764_101826(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 101764, 101826);
                    return 0;
                }


                System.IntPtr
                f_110_101936_101970(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 101936, 101970);
                    return return_v;
                }


                bool
                f_110_101874_102117(System.IntPtr
                consoleOutput, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                scrollRectangle, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                clipRectangle, Microsoft.PowerShell.ConsoleControl.COORD
                destinationOrigin, ref Microsoft.PowerShell.ConsoleControl.CHAR_INFO
                fill)
                {
                    var return_v = NativeMethods.ScrollConsoleScreenBuffer(consoleOutput, ref scrollRectangle, ref clipRectangle, destinationOrigin, ref fill);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 101874, 102117);
                    return return_v;
                }


                int
                f_110_102197_102224()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 102197, 102224);
                    return return_v;
                }


                string
                f_110_102364_102428()
                {
                    var return_v = ConsoleControlStrings.ScrollConsoleScreenBufferExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 102364, 102428);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_102263_102429(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 102263, 102429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 101422, 102482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 101422, 102482);
            }
        }

        internal static void SetConsoleWindowInfo(ConsoleHandle consoleHandle, bool absolute, SMALL_RECT windowInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 103327, 104094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 103460, 103527);

                f_110_103460_103526(f_110_103471_103495_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 103541, 103604);

                f_110_103541_103603(f_110_103552_103575_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 103620, 103731);

                bool
                result = f_110_103634_103730(f_110_103669_103703(consoleHandle), absolute, ref windowInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 103747, 104083) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 103747, 104083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 103800, 103838);

                    int
                    err = f_110_103810_103837()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 103858, 104042);

                    HostException
                    e = f_110_103876_104041(err, "SetConsoleWindowInfo", ErrorCategory.ResourceUnavailable, f_110_103981_104040())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 104060, 104068);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 103747, 104083);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 103327, 104094);

                bool
                f_110_103471_103495_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 103471, 103495);
                    return return_v;
                }


                int
                f_110_103460_103526(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 103460, 103526);
                    return 0;
                }


                bool
                f_110_103552_103575_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 103552, 103575);
                    return return_v;
                }


                int
                f_110_103541_103603(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 103541, 103603);
                    return 0;
                }


                System.IntPtr
                f_110_103669_103703(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 103669, 103703);
                    return return_v;
                }


                bool
                f_110_103634_103730(System.IntPtr
                consoleHandle, bool
                absolute, ref Microsoft.PowerShell.ConsoleControl.SMALL_RECT
                windowInfo)
                {
                    var return_v = NativeMethods.SetConsoleWindowInfo(consoleHandle, absolute, ref windowInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 103634, 103730);
                    return return_v;
                }


                int
                f_110_103810_103837()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 103810, 103837);
                    return return_v;
                }


                string
                f_110_103981_104040()
                {
                    var return_v = ConsoleControlStrings.SetConsoleWindowInfoExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 103981, 104040);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_103876_104041(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 103876, 104041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 103327, 104094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 103327, 104094);
            }
        }

        internal static Size GetLargestConsoleWindowSize(ConsoleHandle consoleHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 104569, 105372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 104671, 104738);

                f_110_104671_104737(f_110_104682_104706_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 104752, 104815);

                f_110_104752_104814(f_110_104763_104786_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 104831, 104924);

                COORD
                result = f_110_104846_104923(f_110_104888_104922(consoleHandle))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 104940, 105309) || true) && ((result.X == 0) && (DynAbs.Tracing.TraceSender.Expression_True(110, 104944, 104978) && (result.Y == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 104940, 105309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 105012, 105050);

                    int
                    err = f_110_105022_105049()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 105070, 105268);

                    HostException
                    e = f_110_105088_105267(err, "GetLargestConsoleWindowSize", ErrorCategory.ResourceUnavailable, f_110_105200_105266())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 105286, 105294);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 104940, 105309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 105325, 105361);

                return f_110_105332_105360(result.X, result.Y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 104569, 105372);

                bool
                f_110_104682_104706_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 104682, 104706);
                    return return_v;
                }


                int
                f_110_104671_104737(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 104671, 104737);
                    return 0;
                }


                bool
                f_110_104763_104786_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 104763, 104786);
                    return return_v;
                }


                int
                f_110_104752_104814(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 104752, 104814);
                    return 0;
                }


                System.IntPtr
                f_110_104888_104922(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 104888, 104922);
                    return return_v;
                }


                Microsoft.PowerShell.ConsoleControl.COORD
                f_110_104846_104923(System.IntPtr
                consoleOutput)
                {
                    var return_v = NativeMethods.GetLargestConsoleWindowSize(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 104846, 104923);
                    return return_v;
                }


                int
                f_110_105022_105049()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 105022, 105049);
                    return return_v;
                }


                string
                f_110_105200_105266()
                {
                    var return_v = ConsoleControlStrings.GetLargestConsoleWindowSizeExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 105200, 105266);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_105088_105267(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 105088, 105267);
                    return return_v;
                }


                System.Management.Automation.Host.Size
                f_110_105332_105360(short
                width, short
                height)
                {
                    var return_v = new System.Management.Automation.Host.Size((int)width, (int)height);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 105332, 105360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 104569, 105372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 104569, 105372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetConsoleWindowTitle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 105826, 106735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 105897, 105935);

                const int
                MaxWindowTitleLength = 1024
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 105949, 105989);

                DWORD
                bufferSize = MaxWindowTitleLength
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 106003, 106016);

                DWORD
                result
                = default(DWORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 106030, 106094);

                StringBuilder
                consoleTitle = f_110_106059_106093(bufferSize)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 106269, 106334);

                result = f_110_106278_106333(consoleTitle, bufferSize);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 106593, 106677) || true) && (result == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 106593, 106677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 106642, 106662);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 106593, 106677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 106693, 106724);

                return f_110_106700_106723(consoleTitle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 105826, 106735);

                System.Text.StringBuilder
                f_110_106059_106093(uint
                capacity)
                {
                    var return_v = new System.Text.StringBuilder((int)capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 106059, 106093);
                    return return_v;
                }


                uint
                f_110_106278_106333(System.Text.StringBuilder
                consoleTitle, uint
                size)
                {
                    var return_v = NativeMethods.GetConsoleTitle(consoleTitle, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 106278, 106333);
                    return return_v;
                }


                string
                f_110_106700_106723(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 106700, 106723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 105826, 106735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 105826, 106735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetConsoleWindowTitle(string consoleTitle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 107069, 107580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 107157, 107215);

                bool
                result = f_110_107171_107214(consoleTitle)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 107231, 107569) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 107231, 107569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 107284, 107322);

                    int
                    err = f_110_107294_107321()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 107342, 107528);

                    HostException
                    e = f_110_107360_107527(err, "SetConsoleWindowTitle", ErrorCategory.ResourceUnavailable, f_110_107466_107526())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 107546, 107554);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 107231, 107569);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 107069, 107580);

                bool
                f_110_107171_107214(string
                consoleTitle)
                {
                    var return_v = NativeMethods.SetConsoleTitle(consoleTitle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 107171, 107214);
                    return return_v;
                }


                int
                f_110_107294_107321()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 107294, 107321);
                    return return_v;
                }


                string
                f_110_107466_107526()
                {
                    var return_v = ConsoleControlStrings.SetConsoleWindowTitleExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 107466, 107526);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_107360_107527(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 107360, 107527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 107069, 107580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 107069, 107580);
            }
        }

        internal static void WriteConsole(ConsoleHandle consoleHandle, ReadOnlySpan<char> output, bool newLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 108141, 110267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108269, 108336);

                f_110_108269_108335(f_110_108280_108304_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108350, 108413);

                f_110_108350_108412(f_110_108361_108384_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108429, 108648) || true) && (output.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 108429, 108648);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108485, 108606) || true) && (newLine)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 108485, 108606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108538, 108587);

                        f_110_108538_108586(consoleHandle, f_110_108566_108585());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 108485, 108606);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108626, 108633);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 108429, 108648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108816, 108831);

                int
                cursor = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 108900, 108932);

                const int
                MaxBufferSize = 16383
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109018, 110256) || true) && (cursor < output.Length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 109018, 110256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109081, 109110);

                        ReadOnlySpan<char>
                        outBuffer
                        = default(ReadOnlySpan<char>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109130, 110241) || true) && (cursor + MaxBufferSize < output.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 109130, 110241);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109214, 109262);

                            outBuffer = output.Slice(cursor, MaxBufferSize);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109284, 109308);

                            cursor += MaxBufferSize;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109332, 109371);

                            f_110_109332_109370(consoleHandle, outBuffer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 109130, 110241);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 109130, 110241);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109453, 109486);

                            outBuffer = output.Slice(cursor);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109508, 109531);

                            cursor = output.Length;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109555, 110222) || true) && (newLine)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 109555, 110222);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109616, 109661);

                                var
                                endOfLine = f_110_109632_109660(f_110_109632_109651())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109687, 109726);

                                var
                                endOfLineLength = endOfLine.Length
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109752, 109831);

                                Span<char>
                                outBufferLine = stackalloc char[outBuffer.Length + endOfLineLength]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109857, 109889);

                                outBuffer.CopyTo(outBufferLine);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 109915, 109993);

                                endOfLine.CopyTo(outBufferLine.Slice(outBufferLine.Length - endOfLineLength));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 110019, 110062);

                                f_110_110019_110061(consoleHandle, outBufferLine);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 109555, 110222);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 109555, 110222);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 110160, 110199);

                                f_110_110160_110198(consoleHandle, outBuffer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(110, 109555, 110222);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 109130, 110241);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 109018, 110256);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 109018, 110256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 109018, 110256);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 108141, 110267);

                bool
                f_110_108280_108304_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 108280, 108304);
                    return return_v;
                }


                int
                f_110_108269_108335(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 108269, 108335);
                    return 0;
                }


                bool
                f_110_108361_108384_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 108361, 108384);
                    return return_v;
                }


                int
                f_110_108350_108412(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 108350, 108412);
                    return 0;
                }


                string
                f_110_108566_108585()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 108566, 108585);
                    return return_v;
                }


                int
                f_110_108538_108586(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, string
                buffer)
                {
                    WriteConsole(consoleHandle, (System.ReadOnlySpan<char>)buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 108538, 108586);
                    return 0;
                }


                int
                f_110_109332_109370(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.ReadOnlySpan<char>
                buffer)
                {
                    WriteConsole(consoleHandle, buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 109332, 109370);
                    return 0;
                }


                string
                f_110_109632_109651()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 109632, 109651);
                    return return_v;
                }


                System.ReadOnlySpan<char>
                f_110_109632_109660(string
                text)
                {
                    var return_v = text.AsSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 109632, 109660);
                    return return_v;
                }


                int
                f_110_110019_110061(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.Span<char>
                buffer)
                {
                    WriteConsole(consoleHandle, (System.ReadOnlySpan<char>)buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 110019, 110061);
                    return 0;
                }


                int
                f_110_110160_110198(Microsoft.Win32.SafeHandles.SafeFileHandle
                consoleHandle, System.ReadOnlySpan<char>
                buffer)
                {
                    WriteConsole(consoleHandle, buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 110160, 110198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 108141, 110267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 108141, 110267);
            }
        }

        private static void WriteConsole(ConsoleHandle consoleHandle, ReadOnlySpan<char> buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 110279, 111088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 110392, 110411);

                DWORD
                charsWritten
                = default(DWORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 110425, 110686);

                bool
                result =
                f_110_110456_110685(f_110_110505_110539(consoleHandle), buffer, buffer.Length, out charsWritten, IntPtr.Zero)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 110702, 111077) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 110702, 111077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 110755, 110793);

                    int
                    err = f_110_110765_110792()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 110813, 111036);

                    HostException
                    e = f_110_110831_111035(err, "WriteConsole", ErrorCategory.WriteError, f_110_110983_111034())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 111054, 111062);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 110702, 111077);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 110279, 111088);

                System.IntPtr
                f_110_110505_110539(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 110505, 110539);
                    return return_v;
                }


                bool
                f_110_110456_110685(System.IntPtr
                consoleOutput, System.ReadOnlySpan<char>
                buffer, int
                numberOfCharsToWrite, out uint
                numberOfCharsWritten, System.IntPtr
                reserved)
                {
                    var return_v = NativeMethods.WriteConsole(consoleOutput, buffer, (uint)numberOfCharsToWrite, out numberOfCharsWritten, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 110456, 110685);
                    return return_v;
                }


                int
                f_110_110765_110792()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 110765, 110792);
                    return return_v;
                }


                string
                f_110_110983_111034()
                {
                    var return_v = ConsoleControlStrings.WriteConsoleExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 110983, 111034);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_110831_111035(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 110831, 111035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 110279, 111088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 110279, 111088);
            }
        }

        internal static void SetConsoleTextAttribute(ConsoleHandle consoleHandle, WORD attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 111564, 112306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 111678, 111745);

                f_110_111678_111744(f_110_111689_111713_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 111759, 111822);

                f_110_111759_111821(f_110_111770_111793_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 111838, 111937);

                bool
                result = f_110_111852_111936(f_110_111890_111924(consoleHandle), attribute)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 111953, 112295) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 111953, 112295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 112006, 112044);

                    int
                    err = f_110_112016_112043()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 112064, 112254);

                    HostException
                    e = f_110_112082_112253(err, "SetConsoleTextAttribute", ErrorCategory.ResourceUnavailable, f_110_112190_112252())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 112272, 112280);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 111953, 112295);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 111564, 112306);

                bool
                f_110_111689_111713_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 111689, 111713);
                    return return_v;
                }


                int
                f_110_111678_111744(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 111678, 111744);
                    return 0;
                }


                bool
                f_110_111770_111793_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 111770, 111793);
                    return return_v;
                }


                int
                f_110_111759_111821(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 111759, 111821);
                    return 0;
                }


                System.IntPtr
                f_110_111890_111924(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 111890, 111924);
                    return return_v;
                }


                bool
                f_110_111852_111936(System.IntPtr
                consoleOutput, ushort
                attributes)
                {
                    var return_v = NativeMethods.SetConsoleTextAttribute(consoleOutput, attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 111852, 111936);
                    return return_v;
                }


                int
                f_110_112016_112043()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 112016, 112043);
                    return return_v;
                }


                string
                f_110_112190_112252()
                {
                    var return_v = ConsoleControlStrings.SetConsoleTextAttributeExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 112190, 112252);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_112082_112253(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 112082, 112253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 111564, 112306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 111564, 112306);
            }
        }

        internal static int ControlSequenceLength(string str, ref int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 113457, 115547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 113551, 113570);

                var
                start = offset
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 113628, 114180) || true) && ((f_110_113633_113644(str, offset) == (char)0x1b) && (DynAbs.Tracing.TraceSender.Expression_True(110, 113632, 113690) && (f_110_113664_113674(str) > (offset + 1))) && (DynAbs.Tracing.TraceSender.Expression_True(110, 113632, 113718) && (f_110_113695_113710(str, offset + 1) == '[')))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 113628, 114180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 113779, 113791);

                    offset += 2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 113628, 114180);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 113628, 114180);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 113825, 114180) || true) && (f_110_113829_113840(str, offset) == (char)0x9b)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 113825, 114180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 113915, 113927);

                        offset += 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 113825, 114180);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 113825, 114180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114126, 114138);

                        offset += 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114156, 114165);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 113825, 114180);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 113628, 114180);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114196, 114278) || true) && (offset >= f_110_114210_114220(str))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 114196, 114278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114254, 114263);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 114196, 114278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114351, 114358);

                char
                c
                = default(char);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 114372, 114517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114407, 114425);

                            c = f_110_114411_114424(str, offset++);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 114372, 114517);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114372, 114517) || true) && ((offset < f_110_114471_114481(str)) && (DynAbs.Tracing.TraceSender.Expression_True(110, 114461, 114515) && (f_110_114487_114502(c) || (DynAbs.Tracing.TraceSender.Expression_False(110, 114487, 114514) || c == ';'))))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 114372, 114517);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(110, 114372, 114517);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114642, 114776) || true) && (c == 'm')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 114642, 114776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114739, 114761);

                    return offset - start;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 114642, 114776);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 114952, 115034) || true) && (offset >= f_110_114966_114976(str))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 114952, 115034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 115010, 115019);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 114952, 115034);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 115050, 115511) || true) && (c == '#')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 115050, 115511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 115258, 115276);

                    c = f_110_115262_115275(str, offset++);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 115294, 115496) || true) && ((c == '{') || (DynAbs.Tracing.TraceSender.Expression_False(110, 115298, 115343) || (c == '}')) || (DynAbs.Tracing.TraceSender.Expression_False(110, 115298, 115378) || (c == 'p')) || (DynAbs.Tracing.TraceSender.Expression_False(110, 115298, 115413) || (c == 'q')))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 115294, 115496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 115455, 115477);

                        return offset - start;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 115294, 115496);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 115050, 115511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 115527, 115536);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 113457, 115547);

                char
                f_110_113633_113644(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 113633, 113644);
                    return return_v;
                }


                int
                f_110_113664_113674(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 113664, 113674);
                    return return_v;
                }


                char
                f_110_113695_113710(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 113695, 113710);
                    return return_v;
                }


                char
                f_110_113829_113840(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 113829, 113840);
                    return return_v;
                }


                int
                f_110_114210_114220(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 114210, 114220);
                    return return_v;
                }


                char
                f_110_114411_114424(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 114411, 114424);
                    return return_v;
                }


                int
                f_110_114471_114481(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 114471, 114481);
                    return return_v;
                }


                bool
                f_110_114487_114502(char
                c)
                {
                    var return_v = char.IsDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 114487, 114502);
                    return return_v;
                }


                int
                f_110_114966_114976(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 114966, 114976);
                    return return_v;
                }


                char
                f_110_115262_115275(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 115262, 115275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 113457, 115547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 113457, 115547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults",
                    MessageId = "Microsoft.PowerShell.ConsoleControl+NativeMethods.ReleaseDC(System.IntPtr,System.IntPtr)")]
        internal static int LengthInBufferCells(string str, int offset, bool checkEscapeSequences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 115714, 116974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116027, 116066);

                f_110_116027_116065(offset >= 0, "offset >= 0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116080, 116166);

                f_110_116080_116165(f_110_116091_116116(str) || (DynAbs.Tracing.TraceSender.Expression_False(110, 116091, 116141) || (offset < f_110_116130_116140(str))), "offset < str.Length");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116182, 116215);

                var
                escapeSequenceAdjustment = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116229, 116748) || true) && (checkEscapeSequences)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 116229, 116748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116287, 116297);

                    int
                    i = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116315, 116427) || true) && (i < offset)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 116315, 116427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116374, 116408);

                            f_110_116374_116407(str, ref i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 116315, 116427);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 116315, 116427);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(110, 116315, 116427);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116589, 116733) || true) && (i < f_110_116600_116610(str))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 116589, 116733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116652, 116714);

                            escapeSequenceAdjustment += f_110_116680_116713(str, ref i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(110, 116589, 116733);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 116589, 116733);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(110, 116589, 116733);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 116229, 116748);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116764, 116779);

                int
                length = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116793, 116897);
                    foreach (char c in f_110_116812_116815_I(str))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 116793, 116897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116849, 116882);

                        length += f_110_116859_116881(c);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(110, 116793, 116897);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(110, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(110, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 116913, 116963);

                return length - offset - escapeSequenceAdjustment;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 115714, 116974);

                int
                f_110_116027_116065(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 116027, 116065);
                    return 0;
                }


                bool
                f_110_116091_116116(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 116091, 116116);
                    return return_v;
                }


                int
                f_110_116130_116140(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 116130, 116140);
                    return return_v;
                }


                int
                f_110_116080_116165(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 116080, 116165);
                    return 0;
                }


                int
                f_110_116374_116407(string
                str, ref int
                offset)
                {
                    var return_v = ControlSequenceLength(str, ref offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 116374, 116407);
                    return return_v;
                }


                int
                f_110_116600_116610(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 116600, 116610);
                    return return_v;
                }


                int
                f_110_116680_116713(string
                str, ref int
                offset)
                {
                    var return_v = ControlSequenceLength(str, ref offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 116680, 116713);
                    return return_v;
                }


                int
                f_110_116859_116881(char
                c)
                {
                    var return_v = LengthInBufferCells(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 116859, 116881);
                    return return_v;
                }


                string
                f_110_116812_116815_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 116812, 116815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 115714, 116974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 115714, 116974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int LengthInBufferCells(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 116986, 118317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 117246, 118012);

                bool
                isWide = c >= 0x1100 && (DynAbs.Tracing.TraceSender.Expression_True(110, 117260, 118011) && (c <= 0x115f || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117372) || c == 0x2329) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117387) || c == 0x232a) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117484) || ((uint)(c - 0x2e80) <= (0xa4cf - 0x2e80) && (DynAbs.Tracing.TraceSender.Expression_True(110, 117410, 117483) && c != 0x303f))) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117564) || ((uint)(c - 0xac00) <= (0xd7a3 - 0xac00))) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117650) || ((uint)(c - 0xf900) <= (0xfaff - 0xf900))) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117748) || ((uint)(c - 0xfe10) <= (0xfe19 - 0xfe10))) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117832) || ((uint)(c - 0xfe30) <= (0xfe6f - 0xfe30))) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 117925) || ((uint)(c - 0xff00) <= (0xff60 - 0xff00))) || (DynAbs.Tracing.TraceSender.Expression_False(110, 117293, 118010) || ((uint)(c - 0xffe0) <= (0xffe6 - 0xffe0)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 118278, 118306);

                return 1 + ((DynAbs.Tracing.TraceSender.Conditional_F1(110, 118290, 118296) || ((isWide && DynAbs.Tracing.TraceSender.Conditional_F2(110, 118299, 118300)) || DynAbs.Tracing.TraceSender.Conditional_F3(110, 118303, 118304))) ? 1 : 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 116986, 118317);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 116986, 118317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 116986, 118317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCJKOutputCodePage(out uint codePage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 118582, 118936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 118666, 118712);

                codePage = f_110_118677_118711();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 118726, 118901);

                return codePage == 932 || (DynAbs.Tracing.TraceSender.Expression_False(110, 118733, 118796) || codePage == 936) || (DynAbs.Tracing.TraceSender.Expression_False(110, 118733, 118854) || codePage == 949) || (DynAbs.Tracing.TraceSender.Expression_False(110, 118733, 118900) || codePage == 950);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 118582, 118936);

                uint
                f_110_118677_118711()
                {
                    var return_v = NativeMethods.GetConsoleOutputCP();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 118677, 118711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 118582, 118936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 118582, 118936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetConsoleCursorPosition(ConsoleHandle consoleHandle, Coordinates cursorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 119509, 120388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 119636, 119703);

                f_110_119636_119702(f_110_119647_119671_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 119717, 119780);

                f_110_119717_119779(f_110_119728_119751_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 119796, 119819);

                ConsoleControl.COORD
                c
                = default(ConsoleControl.COORD);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 119835, 119865);

                c.X = (short)cursorPosition.X;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 119879, 119909);

                c.Y = (short)cursorPosition.Y;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 119925, 120017);

                bool
                result = f_110_119939_120016(f_110_119978_120012(consoleHandle), c)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 120033, 120377) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 120033, 120377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 120086, 120124);

                    int
                    err = f_110_120096_120123()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 120144, 120336);

                    HostException
                    e = f_110_120162_120335(err, "SetConsoleCursorPosition", ErrorCategory.ResourceUnavailable, f_110_120271_120334())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 120354, 120362);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 120033, 120377);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 119509, 120388);

                bool
                f_110_119647_119671_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 119647, 119671);
                    return return_v;
                }


                int
                f_110_119636_119702(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 119636, 119702);
                    return 0;
                }


                bool
                f_110_119728_119751_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 119728, 119751);
                    return return_v;
                }


                int
                f_110_119717_119779(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 119717, 119779);
                    return 0;
                }


                System.IntPtr
                f_110_119978_120012(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 119978, 120012);
                    return return_v;
                }


                bool
                f_110_119939_120016(System.IntPtr
                consoleOutput, Microsoft.PowerShell.ConsoleControl.COORD
                cursorPosition)
                {
                    var return_v = NativeMethods.SetConsoleCursorPosition(consoleOutput, cursorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 119939, 120016);
                    return return_v;
                }


                int
                f_110_120096_120123()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 120096, 120123);
                    return return_v;
                }


                string
                f_110_120271_120334()
                {
                    var return_v = ConsoleControlStrings.SetConsoleCursorPositionExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 120271, 120334);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_120162_120335(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 120162, 120335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 119509, 120388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 119509, 120388);
            }
        }

        internal static CONSOLE_CURSOR_INFO GetConsoleCursorInfo(ConsoleHandle consoleHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 120821, 121636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 120931, 120998);

                f_110_120931_120997(f_110_120942_120966_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121012, 121075);

                f_110_121012_121074(f_110_121023_121046_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121091, 121122);

                CONSOLE_CURSOR_INFO
                cursorInfo
                = default(CONSOLE_CURSOR_INFO);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121138, 121239);

                bool
                result = f_110_121152_121238(f_110_121187_121221(consoleHandle), out cursorInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121255, 121591) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 121255, 121591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121308, 121346);

                    int
                    err = f_110_121318_121345()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121366, 121550);

                    HostException
                    e = f_110_121384_121549(err, "GetConsoleCursorInfo", ErrorCategory.ResourceUnavailable, f_110_121489_121548())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121568, 121576);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 121255, 121591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121607, 121625);

                return cursorInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 120821, 121636);

                bool
                f_110_120942_120966_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 120942, 120966);
                    return return_v;
                }


                int
                f_110_120931_120997(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 120931, 120997);
                    return 0;
                }


                bool
                f_110_121023_121046_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 121023, 121046);
                    return return_v;
                }


                int
                f_110_121012_121074(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121012, 121074);
                    return 0;
                }


                System.IntPtr
                f_110_121187_121221(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121187, 121221);
                    return return_v;
                }


                bool
                f_110_121152_121238(System.IntPtr
                consoleOutput, out Microsoft.PowerShell.ConsoleControl.CONSOLE_CURSOR_INFO
                consoleCursorInfo)
                {
                    var return_v = NativeMethods.GetConsoleCursorInfo(consoleOutput, out consoleCursorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121152, 121238);
                    return return_v;
                }


                int
                f_110_121318_121345()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121318, 121345);
                    return return_v;
                }


                string
                f_110_121489_121548()
                {
                    var return_v = ConsoleControlStrings.GetConsoleCursorInfoExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 121489, 121548);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_121384_121549(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121384, 121549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 120821, 121636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 120821, 121636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CONSOLE_FONT_INFO_EX GetConsoleFontInfo(ConsoleHandle consoleHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 121648, 122547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121757, 121824);

                f_110_121757_121823(f_110_121768_121792_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121838, 121901);

                f_110_121838_121900(f_110_121849_121872_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121917, 121976);

                CONSOLE_FONT_INFO_EX
                fontInfo = f_110_121949_121975()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 121990, 122033);

                fontInfo.cbSize = f_110_122008_122032(fontInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 122047, 122156);

                bool
                result = f_110_122061_122155(f_110_122099_122133(consoleHandle), false, ref fontInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 122172, 122504) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 122172, 122504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 122225, 122263);

                    int
                    err = f_110_122235_122262()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 122283, 122463);

                    HostException
                    e = f_110_122301_122462(err, "GetConsoleFontInfo", ErrorCategory.ResourceUnavailable, f_110_122404_122461())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 122481, 122489);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 122172, 122504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 122520, 122536);

                return fontInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 121648, 122547);

                bool
                f_110_121768_121792_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 121768, 121792);
                    return return_v;
                }


                int
                f_110_121757_121823(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121757, 121823);
                    return 0;
                }


                bool
                f_110_121849_121872_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 121849, 121872);
                    return return_v;
                }


                int
                f_110_121838_121900(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121838, 121900);
                    return 0;
                }


                Microsoft.PowerShell.ConsoleControl.CONSOLE_FONT_INFO_EX
                f_110_121949_121975()
                {
                    var return_v = new Microsoft.PowerShell.ConsoleControl.CONSOLE_FONT_INFO_EX();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 121949, 121975);
                    return return_v;
                }


                int
                f_110_122008_122032(Microsoft.PowerShell.ConsoleControl.CONSOLE_FONT_INFO_EX
                structure)
                {
                    var return_v = Marshal.SizeOf(structure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 122008, 122032);
                    return return_v;
                }


                System.IntPtr
                f_110_122099_122133(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 122099, 122133);
                    return return_v;
                }


                bool
                f_110_122061_122155(System.IntPtr
                consoleOutput, bool
                bMaximumWindow, ref Microsoft.PowerShell.ConsoleControl.CONSOLE_FONT_INFO_EX
                consoleFontInfo)
                {
                    var return_v = NativeMethods.GetCurrentConsoleFontEx(consoleOutput, bMaximumWindow, ref consoleFontInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 122061, 122155);
                    return return_v;
                }


                int
                f_110_122235_122262()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 122235, 122262);
                    return return_v;
                }


                string
                f_110_122404_122461()
                {
                    var return_v = ConsoleControlStrings.GetConsoleFontInfoExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 122404, 122461);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_122301_122462(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 122301, 122462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 121648, 122547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 121648, 122547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetConsoleCursorInfo(ConsoleHandle consoleHandle, CONSOLE_CURSOR_INFO cursorInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 123007, 123758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 123134, 123201);

                f_110_123134_123200(f_110_123145_123169_M(!consoleHandle.IsInvalid), "ConsoleHandle is not valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 123215, 123278);

                f_110_123215_123277(f_110_123226_123249_M(!consoleHandle.IsClosed), "ConsoleHandle is closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 123294, 123395);

                bool
                result = f_110_123308_123394(f_110_123343_123377(consoleHandle), ref cursorInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 123411, 123747) || true) && (result == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 123411, 123747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 123464, 123502);

                    int
                    err = f_110_123474_123501()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 123522, 123706);

                    HostException
                    e = f_110_123540_123705(err, "SetConsoleCursorInfo", ErrorCategory.ResourceUnavailable, f_110_123645_123704())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 123724, 123732);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 123411, 123747);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 123007, 123758);

                bool
                f_110_123145_123169_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 123145, 123169);
                    return return_v;
                }


                int
                f_110_123134_123200(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 123134, 123200);
                    return 0;
                }


                bool
                f_110_123226_123249_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 123226, 123249);
                    return return_v;
                }


                int
                f_110_123215_123277(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 123215, 123277);
                    return 0;
                }


                System.IntPtr
                f_110_123343_123377(Microsoft.Win32.SafeHandles.SafeFileHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 123343, 123377);
                    return return_v;
                }


                bool
                f_110_123308_123394(System.IntPtr
                consoleOutput, ref Microsoft.PowerShell.ConsoleControl.CONSOLE_CURSOR_INFO
                consoleCursorInfo)
                {
                    var return_v = NativeMethods.SetConsoleCursorInfo(consoleOutput, ref consoleCursorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 123308, 123394);
                    return return_v;
                }


                int
                f_110_123474_123501()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 123474, 123501);
                    return return_v;
                }


                string
                f_110_123645_123704()
                {
                    var return_v = ConsoleControlStrings.SetConsoleCursorInfoExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 123645, 123704);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_123540_123705(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 123540, 123705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 123007, 123758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 123007, 123758);
            }
        }

        private static HostException CreateHostException(
                    int win32Error, string errorId, ErrorCategory category, string resourceStr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 124154, 124598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 124317, 124380);

                Win32Exception
                innerException = f_110_124349_124379(win32Error)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 124394, 124474);

                string
                msg = f_110_124407_124473(resourceStr, f_110_124438_124460(innerException), win32Error)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 124488, 124564);

                HostException
                e = f_110_124506_124563(msg, innerException, errorId, category)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 124578, 124587);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 124154, 124598);

                System.ComponentModel.Win32Exception
                f_110_124349_124379(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 124349, 124379);
                    return return_v;
                }


                string
                f_110_124438_124460(System.ComponentModel.Win32Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 124438, 124460);
                    return return_v;
                }


                string
                f_110_124407_124473(string
                formatSpec, string
                o1, int
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 124407, 124473);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_124506_124563(string
                message, System.ComponentModel.Win32Exception
                innerException, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    var return_v = new System.Management.Automation.Host.HostException(message, (System.Exception)innerException, errorId, errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 124506, 124563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 124154, 124598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 124154, 124598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void MimicKeyPress(INPUT[] inputs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 124668, 125323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 124743, 124829);

                f_110_124743_124828(inputs != null && (DynAbs.Tracing.TraceSender.Expression_True(110, 124754, 124789) && f_110_124772_124785(inputs) > 0), "inputs should not be null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 124843, 124952);

                var
                numberOfSuccessfulEvents = f_110_124874_124951(f_110_124904_124917(inputs), inputs, f_110_124927_124950())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 124968, 125312) || true) && (numberOfSuccessfulEvents == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(110, 124968, 125312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 125035, 125073);

                    int
                    err = f_110_125045_125072()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 125093, 125271);

                    HostException
                    e = f_110_125111_125270(err, "SendKeyPressInput", ErrorCategory.ResourceUnavailable, f_110_125213_125269())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 125289, 125297);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(110, 124968, 125312);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 124668, 125323);

                int
                f_110_124772_124785(Microsoft.PowerShell.ConsoleControl.INPUT[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 124772, 124785);
                    return return_v;
                }


                int
                f_110_124743_124828(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 124743, 124828);
                    return 0;
                }


                int
                f_110_124904_124917(Microsoft.PowerShell.ConsoleControl.INPUT[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 124904, 124917);
                    return return_v;
                }


                int
                f_110_124927_124950()
                {
                    var return_v = Marshal.SizeOf<INPUT>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 124927, 124950);
                    return return_v;
                }


                uint
                f_110_124874_124951(int
                inputNumbers, Microsoft.PowerShell.ConsoleControl.INPUT[]
                inputs, int
                sizeOfInput)
                {
                    var return_v = NativeMethods.SendInput((uint)inputNumbers, inputs, sizeOfInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 124874, 124951);
                    return return_v;
                }


                int
                f_110_125045_125072()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 125045, 125072);
                    return return_v;
                }


                string
                f_110_125213_125269()
                {
                    var return_v = ConsoleControlStrings.SendKeyPressInputExceptionTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(110, 125213, 125269);
                    return return_v;
                }


                System.Management.Automation.Host.HostException
                f_110_125111_125270(int
                win32Error, string
                errorId, System.Management.Automation.ErrorCategory
                category, string
                resourceStr)
                {
                    var return_v = CreateHostException(win32Error, errorId, category, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 125111, 125270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 124668, 125323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 124668, 125323);
            }
        }
        internal static class NativeMethods
        {
            internal static readonly IntPtr INVALID_HANDLE_VALUE;

            internal const int
            FontTypeMask = 0x06
            ;

            internal const int
            TrueTypeFont = 0x04
            ;


            [Flags]
            internal enum AccessQualifiers : uint
            {
                // From winnt.h
                GenericRead = 0x80000000,
                GenericWrite = 0x40000000
            }

            [Flags]
            internal enum ShareModes : uint
            {
                // From winnt.h
                ShareRead = 0x00000001,
                ShareWrite = 0x00000002
            }

            internal enum CreationDisposition : uint
            {
                // From winbase.h
                CreateNew = 1,
                CreateAlways = 2,
                OpenExisting = 3,
                OpenAlways = 4,
                TruncateExisting = 5
            }

            [DllImport(PinvokeDllNames.CreateFileDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern NakedWin32Handle CreateFile
                        (
                            string fileName,
                            DWORD desiredAccess,
                            DWORD ShareModes,
                            IntPtr securityAttributes,
                            DWORD creationDisposition,
                            DWORD flagsAndAttributes,
                            NakedWin32Handle templateFileWin32Handle
                        );

            [DllImport(PinvokeDllNames.GetConsoleOutputCPDllName, SetLastError = false, CharSet = CharSet.Unicode)]
            internal static extern uint GetConsoleOutputCP();

            [DllImport(PinvokeDllNames.GetConsoleWindowDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern HWND GetConsoleWindow();

            [DllImport(PinvokeDllNames.GetDCDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern HDC GetDC(HWND hwnd);

            [DllImport(PinvokeDllNames.ReleaseDCDllName, SetLastError = false, CharSet = CharSet.Unicode)]
            internal static extern int ReleaseDC(HWND hwnd, HDC hdc);

            [DllImport(PinvokeDllNames.FlushConsoleInputBufferDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool FlushConsoleInputBuffer(NakedWin32Handle consoleInput);

            [DllImport(PinvokeDllNames.FillConsoleOutputAttributeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool FillConsoleOutputAttribute
                        (
                            NakedWin32Handle consoleOutput,
                            WORD attribute,
                            DWORD length,
                            COORD writeCoord,
                            out DWORD numberOfAttrsWritten
                        );

            [DllImport(PinvokeDllNames.FillConsoleOutputCharacterDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool FillConsoleOutputCharacter
                        (
                            NakedWin32Handle consoleOutput,
                            char character,
                            DWORD length,
                            COORD writeCoord,
                            out DWORD numberOfCharsWritten
                        );

            [DllImport(PinvokeDllNames.WriteConsoleDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern unsafe bool WriteConsole
                        (
                            NakedWin32Handle consoleOutput,
                            char* buffer,
                            DWORD numberOfCharsToWrite,
                            out DWORD numberOfCharsWritten,
                            IntPtr reserved
                        );

            internal static unsafe bool WriteConsole
                        (
                            NakedWin32Handle consoleOutput,
                            ReadOnlySpan<char> buffer,
                            DWORD numberOfCharsToWrite,
                            out DWORD numberOfCharsWritten,
                            IntPtr reserved
                        )
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 129521, 130084);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 129851, 129904);
                    fixed (char*
    bufferPtr = &MemoryMarshal.GetReference(buffer)
    )
                    {
                        // LAFHIS
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 129870, 129904);

                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 129946, 130050);

                        return f_110_129953_130049(consoleOutput, bufferPtr, numberOfCharsToWrite, out numberOfCharsWritten, reserved);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 129521, 130084);

                    //char
                    //f_110_129870_129904(System.ReadOnlySpan<char>
                    //span)
                    //{
                    //    var return_v = MemoryMarshal.GetReference(span);
                    //    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 129870, 129904);
                    //    return return_v;
                    //}


                    unsafe bool
                    f_110_129953_130049(System.IntPtr
                    consoleOutput, char*
                    buffer, uint
                    numberOfCharsToWrite, out uint
                    numberOfCharsWritten, System.IntPtr
                    reserved)
                    {
                        var return_v = WriteConsole(consoleOutput, buffer, numberOfCharsToWrite, out numberOfCharsWritten, reserved);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 129953, 130049);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 129521, 130084);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 129521, 130084);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [DllImport(PinvokeDllNames.GetConsoleTitleDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern DWORD GetConsoleTitle(StringBuilder consoleTitle, DWORD size);

            [DllImport(PinvokeDllNames.SetConsoleTitleDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleTitle(string consoleTitle);

            [DllImport(PinvokeDllNames.GetConsoleModeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetConsoleMode(NakedWin32Handle consoleHandle, out UInt32 mode);

            [DllImport(PinvokeDllNames.GetConsoleScreenBufferInfoDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetConsoleScreenBufferInfo(NakedWin32Handle consoleHandle, out CONSOLE_SCREEN_BUFFER_INFO consoleScreenBufferInfo);

            [DllImport(PinvokeDllNames.GetLargestConsoleWindowSizeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern COORD GetLargestConsoleWindowSize(NakedWin32Handle consoleOutput);

            [DllImport(PinvokeDllNames.ReadConsoleDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern unsafe bool ReadConsole
                        (
                            NakedWin32Handle consoleInput,
                            char* lpBuffer,
                            DWORD numberOfCharsToRead,
                            out DWORD numberOfCharsRead,
                            ref CONSOLE_READCONSOLE_CONTROL controlData
                        );

            internal static unsafe bool ReadConsole
                        (
                            NakedWin32Handle consoleInput,
                            Span<char> buffer,
                            DWORD numberOfCharsToRead,
                            out DWORD numberOfCharsRead,
                            ref CONSOLE_READCONSOLE_CONTROL controlData
                        )
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(110, 131886, 132464);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 132364, 132283);

                    fixed (char*
    bufferPtr = &MemoryMarshal.GetReference(buffer)
    )
                    {
                        // LAFHIS
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 132249, 132283);

                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 132325, 132430);

                        return f_110_132332_132429(consoleInput, bufferPtr, numberOfCharsToRead, out numberOfCharsRead, ref controlData);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(110, 131886, 132464);

                    //char
                    //f_110_132249_132283(System.Span<char>
                    //span)
                    //{
                    //    var return_v = MemoryMarshal.GetReference(span);
                    //    DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 132249, 132283);
                    //    return return_v;
                    //}


                    unsafe bool
                    f_110_132332_132429(System.IntPtr
                    consoleInput, char*
                    lpBuffer, uint
                    numberOfCharsToRead, out uint
                    numberOfCharsRead, ref Microsoft.PowerShell.ConsoleControl.CONSOLE_READCONSOLE_CONTROL
                    controlData)
                    {
                        var return_v = ReadConsole(consoleInput, lpBuffer, numberOfCharsToRead, out numberOfCharsRead, ref controlData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 132332, 132429);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(110, 131886, 132464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 131886, 132464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [DllImport(PinvokeDllNames.PeekConsoleInputDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool PeekConsoleInput
                        (
                            NakedWin32Handle consoleInput,
                            [Out] INPUT_RECORD[] buffer,
                            DWORD length,
                            out DWORD numberOfEventsRead
                        );

            [DllImport(PinvokeDllNames.GetNumberOfConsoleInputEventsDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetNumberOfConsoleInputEvents(NakedWin32Handle consoleInput, out DWORD numberOfEvents);

            [DllImport(PinvokeDllNames.SetConsoleCtrlHandlerDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleCtrlHandler(BreakHandler handlerRoutine, bool add);

            [DllImport(PinvokeDllNames.SetConsoleCursorPositionDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleCursorPosition(NakedWin32Handle consoleOutput, COORD cursorPosition);

            [DllImport(PinvokeDllNames.SetConsoleModeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleMode(NakedWin32Handle consoleHandle, DWORD mode);

            [DllImport(PinvokeDllNames.SetConsoleScreenBufferSizeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleScreenBufferSize(NakedWin32Handle consoleOutput, COORD size);

            [DllImport(PinvokeDllNames.SetConsoleTextAttributeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleTextAttribute(NakedWin32Handle consoleOutput, WORD attributes);

            [DllImport(PinvokeDllNames.SetConsoleWindowInfoDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleWindowInfo(NakedWin32Handle consoleHandle, bool absolute, ref SMALL_RECT windowInfo);

            [DllImport(PinvokeDllNames.WriteConsoleOutputDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool WriteConsoleOutput
                        (
                            NakedWin32Handle consoleOutput,
                            CHAR_INFO[] buffer,
                            COORD bufferSize,
                            COORD bufferCoord,
                            ref SMALL_RECT writeRegion
                        );

            [DllImport(PinvokeDllNames.ReadConsoleOutputDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool ReadConsoleOutput
                        (
                            NakedWin32Handle consoleOutput,
                            [Out] CHAR_INFO[] buffer,
                            COORD bufferSize,
                            COORD bufferCoord,
                            ref SMALL_RECT readRegion
                        );

            [DllImport(PinvokeDllNames.ScrollConsoleScreenBufferDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool ScrollConsoleScreenBuffer
                        (
                            NakedWin32Handle consoleOutput,
                            ref SMALL_RECT scrollRectangle,
                            ref SMALL_RECT clipRectangle,
                            COORD destinationOrigin,
                            ref CHAR_INFO fill
                        );

            [DllImport(PinvokeDllNames.SendInputDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern UInt32 SendInput(UInt32 inputNumbers, INPUT[] inputs, Int32 sizeOfInput);

            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetCurrentConsoleFontEx(NakedWin32Handle consoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX consoleFontInfo);

            [DllImport(PinvokeDllNames.GetConsoleCursorInfoDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetConsoleCursorInfo(NakedWin32Handle consoleOutput, out CONSOLE_CURSOR_INFO consoleCursorInfo);

            [DllImport(PinvokeDllNames.SetConsoleCursorInfoDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool SetConsoleCursorInfo(NakedWin32Handle consoleOutput, ref CONSOLE_CURSOR_INFO consoleCursorInfo);

            [DllImport(PinvokeDllNames.ReadConsoleInputDllName, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool ReadConsoleInput
                        (
                            NakedWin32Handle consoleInput,
                            [Out] INPUT_RECORD[] buffer,
                            DWORD length,
                            out DWORD numberOfEventsRead
                        );

            internal enum CHAR_INFO_Attributes : uint
            {
                COMMON_LVB_LEADING_BYTE = 0x0100,
                COMMON_LVB_TRAILING_BYTE = 0x0200
            }

            static NativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 125497, 138203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 125589, 125626);
                INVALID_HANDLE_VALUE = f_110_125612_125626(-1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 125674, 125693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 125727, 125746);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 125497, 138203);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 125497, 138203);
            }


            static System.IntPtr
            f_110_125612_125626(int
            value)
            {
                var return_v = new System.IntPtr(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 125612, 125626);
                return return_v;
            }

        }

        [TraceSourceAttribute("ConsoleControl", "Console control methods")]
        private static PSTraceSource tracer;

        static ConsoleControl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(110, 1783, 138414);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 14863, 14874);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 14904, 14921);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 14951, 14964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 14994, 15014);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15044, 15064);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15094, 15109);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15139, 15160);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15190, 15201);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15231, 15246);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15276, 15298);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15328, 15341);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15371, 15385);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15415, 15434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15464, 15485);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 15515, 15526);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 19297, 20415);
            _keyboardInputHandle = f_110_19320_20415(() =>
                        {
                            var handle = NativeMethods.CreateFile(
                                "CONIN$",
                                (UInt32)
                                (NativeMethods.AccessQualifiers.GenericRead | NativeMethods.AccessQualifiers.GenericWrite),
                                (UInt32)NativeMethods.ShareModes.ShareRead,
                                (IntPtr)0,
                                (UInt32)NativeMethods.CreationDisposition.OpenExisting,
                                0,
                                (IntPtr)0);

                            if (handle == NativeMethods.INVALID_HANDLE_VALUE)
                            {
                                int err = Marshal.GetLastWin32Error();

                                HostException e = CreateHostException(err, "RetreiveInputConsoleHandle",
                                                                        ErrorCategory.ResourceUnavailable,
                                                                        ConsoleControlStrings.GetInputModeExceptionTemplate);
                                throw e;
                            }

                            return new ConsoleHandle(handle, true);
                        });
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 20723, 21870);
            _outputHandle = f_110_20739_21870(() =>
                        {
                            // We use CreateFile here instead of GetStdWin32Handle, as GetStdWin32Handle will return redirected handles
                            var handle = NativeMethods.CreateFile(
                                            "CONOUT$",
                                            (UInt32)(NativeMethods.AccessQualifiers.GenericRead | NativeMethods.AccessQualifiers.GenericWrite),
                                            (UInt32)NativeMethods.ShareModes.ShareWrite,
                                            (IntPtr)0,
                                            (UInt32)NativeMethods.CreationDisposition.OpenExisting,
                                            0,
                                            (IntPtr)0);

                            if (handle == NativeMethods.INVALID_HANDLE_VALUE)
                            {
                                int err = Marshal.GetLastWin32Error();

                                HostException e = CreateHostException(err, "RetreiveActiveScreenBufferConsoleHandle",
                                    ErrorCategory.ResourceUnavailable, ConsoleControlStrings.GetActiveScreenBufferHandleExceptionTemplate);
                                throw e;
                            }

                            return new ConsoleHandle(handle, true);
                        });
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(110, 138321, 138398);
            tracer = f_110_138330_138398("ConsoleControl", "Console control methods");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(110, 1783, 138414);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(110, 1783, 138414);
        }


        static System.Lazy<Microsoft.Win32.SafeHandles.SafeFileHandle>
        f_110_19320_20415(System.Func<Microsoft.Win32.SafeHandles.SafeFileHandle>
        valueFactory)
        {
            var return_v = new System.Lazy<Microsoft.Win32.SafeHandles.SafeFileHandle>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 19320, 20415);
            return return_v;
        }


        static System.Lazy<Microsoft.Win32.SafeHandles.SafeFileHandle>
        f_110_20739_21870(System.Func<Microsoft.Win32.SafeHandles.SafeFileHandle>
        valueFactory)
        {
            var return_v = new System.Lazy<Microsoft.Win32.SafeHandles.SafeFileHandle>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 20739, 21870);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_110_138330_138398(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(110, 138330, 138398);
            return return_v;
        }

    }
}
