// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation
{
    public sealed class VTUtility
    {        /// <summary>
             /// Available VT escape codes other than colors.
             /// </summary>
        public enum VT
        {
            /// <summary>Reset the text style.</summary>
            Reset,

            /// <summary>Invert the foreground and background colors.</summary>
            Inverse
        }

        private static readonly Dictionary<ConsoleColor, string> ForegroundColorMap;

        private static readonly Dictionary<VT, string> VTCodes;

        public static string GetEscapeSequence(ConsoleColor color)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1046, 2140, 2352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 2223, 2251);

                string
                value = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 2265, 2314);

                f_1046_2265_2313(ForegroundColorMap, color, out value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 2328, 2341);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1046, 2140, 2352);

                bool
                f_1046_2265_2313(System.Collections.Generic.Dictionary<System.ConsoleColor, string>
                this_param, System.ConsoleColor
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1046, 2265, 2313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1046, 2140, 2352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1046, 2140, 2352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetEscapeSequence(VT vt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1046, 2691, 2876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 2761, 2789);

                string
                value = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 2803, 2838);

                f_1046_2803_2837(VTCodes, vt, out value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 2852, 2865);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1046, 2691, 2876);

                bool
                f_1046_2803_2837(System.Collections.Generic.Dictionary<System.Management.Automation.VTUtility.VT, string>
                this_param, System.Management.Automation.VTUtility.VT
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1046, 2803, 2837);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1046, 2691, 2876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1046, 2691, 2876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public VTUtility()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1046, 272, 2883);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1046, 272, 2883);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1046, 272, 2883);
        }


        static VTUtility()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1046, 272, 2883);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 710, 1597);
            ForegroundColorMap = new Dictionary<ConsoleColor, string>
        {
            { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => ConsoleColor.Black,1046,731,1597),"\x1b[30m" },            { ConsoleColor.Gray, "\x1b[37m" },            { ConsoleColor.Red, "\x1b[91m" },            { ConsoleColor.Green, "\x1b[92m" },            { ConsoleColor.Yellow, "\x1b[93m" },            { ConsoleColor.Blue, "\x1b[94m" },            { ConsoleColor.Magenta, "\x1b[95m" },            { ConsoleColor.Cyan, "\x1b[96m" },            { ConsoleColor.White, "\x1b[97m" },            { ConsoleColor.DarkRed, "\x1b[31m" },            { ConsoleColor.DarkGreen, "\x1b[32m" },            { ConsoleColor.DarkYellow, "\x1b[33m" },            { ConsoleColor.DarkBlue, "\x1b[34m" },            { ConsoleColor.DarkMagenta, "\x1b[35m" },            { ConsoleColor.DarkCyan, "\x1b[36m" },            { ConsoleColor.DarkGray, "\x1b[90m" }        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1046, 1657, 1792);
            VTCodes = new Dictionary<VT, string>
        {
            { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => VT.Reset,1046,1667,1792),"\x1b[0m" },            { VT.Inverse, "\x1b[7m" }
        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1046, 272, 2883);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1046, 272, 2883);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1046, 272, 2883);
    }
}
