// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Runtime.CompilerServices;

namespace Microsoft.PowerShell
{
    public static class ConsoleShell
    {
        public static int Start(string bannerText, string helpText, string[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(119, 986, 1175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1085, 1164);

                return f_119_1092_1163(f_119_1098_1134(), bannerText, helpText, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(119, 986, 1175);

                System.Management.Automation.Runspaces.InitialSessionState
                f_119_1098_1134()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(119, 1098, 1134);
                    return return_v;
                }


                int
                f_119_1092_1163(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState, string
                bannerText, string
                helpText, string[]
                args)
                {
                    var return_v = Start(initialSessionState, bannerText, helpText, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(119, 1092, 1163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(119, 986, 1175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(119, 986, 1175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int Start(InitialSessionState initialSessionState, string bannerText, string helpText, string[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(119, 1754, 2345);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1894, 2048) || true) && (initialSessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(119, 1894, 2048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1959, 2033);

                    throw f_119_1965_2032(nameof(initialSessionState));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(119, 1894, 2048);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 2064, 2188) || true) && (args == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(119, 2064, 2188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 2114, 2173);

                    throw f_119_2120_2172(nameof(args));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(119, 2064, 2188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 2204, 2265);

                ConsoleHost.DefaultInitialSessionState = initialSessionState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 2281, 2334);

                return f_119_2288_2333(bannerText, helpText, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(119, 1754, 2345);

                System.Management.Automation.PSArgumentNullException
                f_119_1965_2032(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(119, 1965, 2032);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_119_2120_2172(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(119, 2120, 2172);
                    return return_v;
                }


                int
                f_119_2288_2333(string
                bannerText, string
                helpText, string[]
                args)
                {
                    var return_v = ConsoleHost.Start(bannerText, helpText, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(119, 2288, 2333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(119, 1754, 2345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(119, 1754, 2345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConsoleShell()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(119, 451, 2352);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(119, 451, 2352);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(119, 451, 2352);
        }

    }
}
