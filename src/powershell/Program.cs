// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.PowerShell
{
    public sealed class ManagedPSEntry
    {
        public static int Main(string[] args)
        {
            try
            {
                // LAFHIS
                //var str = "";
                //if (args != null && args.Length > 0)
                //    str = string.Join(", ", args);
                //DynAbs.Tracing.TraceSender.TraceString("##:" + str);

                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1, 2137, 2332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 2258, 2321);

                return f_1_2265_2320(string.Empty, args, f_1_2308_2319(args));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1, 2137, 2332);

                int
                f_1_2308_2319(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1, 2308, 2319);
                    return return_v;
                }


                int
                f_1_2265_2320(string
                consoleFilePath, string[]
                args, int
                argc)
                {
                    var return_v = UnmanagedPSEntry.Start(consoleFilePath, args, argc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1, 2265, 2320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1, 2137, 2332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 2137, 2332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ManagedPSEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1, 345, 20215);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1, 345, 20215);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 345, 20215);
        }


        static ManagedPSEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1, 345, 20215);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1, 345, 20215);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 345, 20215);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1, 345, 20215);
    }
}
