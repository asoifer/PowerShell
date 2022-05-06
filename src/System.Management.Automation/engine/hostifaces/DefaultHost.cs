// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;

using Dbg = System.Diagnostics;

namespace Microsoft.PowerShell
{
    internal class DefaultHost : PSHost
    {
        internal DefaultHost(CultureInfo currentCulture, CultureInfo currentUICulture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1458, 887, 1083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 1320, 1387);
                this.Version = f_1458_1363_1386();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 1446, 1504);
                this.InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 1787, 1846);
                this.CurrentCulture = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 1934, 1995);
                this.CurrentUICulture = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 990, 1022);

                CurrentCulture = currentCulture;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 1036, 1072);

                CurrentUICulture = currentUICulture;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1458, 887, 1083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 887, 1083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 887, 1083);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1458, 1229, 1259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 1235, 1257);

                    return "Default Host";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1458, 1229, 1259);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 1199, 1261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 1199, 1261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Version Version { get; }

        public override Guid InstanceId { get; }

        public override PSHostUserInterface UI
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1458, 1677, 1697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 1683, 1695);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1458, 1677, 1697);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 1636, 1699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 1636, 1699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override CultureInfo CurrentCulture { get; }

        public override CultureInfo CurrentUICulture { get; }

        public override
                void
                SetShouldExit(int exitCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1458, 2200, 2310);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1458, 2200, 2310);
                // No op
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 2200, 2310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 2200, 2310);
            }
        }

        public override
                void
                EnterNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1458, 2545, 2686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 2628, 2675);

                throw f_1458_2634_2674();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1458, 2545, 2686);

                System.Management.Automation.PSNotSupportedException
                f_1458_2634_2674()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1458, 2634, 2674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 2545, 2686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 2545, 2686);
            }
        }

        public override
                void
                ExitNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1458, 2919, 3059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1458, 3001, 3048);

                throw f_1458_3007_3047();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1458, 2919, 3059);

                System.Management.Automation.PSNotSupportedException
                f_1458_3007_3047()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1458, 3007, 3047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 2919, 3059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 2919, 3059);
            }
        }

        public override
                void
                NotifyBeginApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1458, 3204, 3311);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1458, 3204, 3311);
                // No op
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 3204, 3311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 3204, 3311);
            }
        }

        public override
                void
                NotifyEndApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1458, 3456, 3561);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1458, 3456, 3561);
                // No op
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1458, 3456, 3561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 3456, 3561);
            }
        }

        static DefaultHost()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1458, 483, 3667);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1458, 483, 3667);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1458, 483, 3667);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1458, 483, 3667);

        System.Version
        f_1458_1363_1386()
        {
            var return_v = PSVersionInfo.PSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1458, 1363, 1386);
            return return_v;
        }

    }
}

