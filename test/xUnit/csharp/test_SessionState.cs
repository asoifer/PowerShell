// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Runspaces;
using Microsoft.PowerShell;
using Xunit;

namespace PSTests.Parallel
{
    public class SessionStateTests
    {
        [SkippableFact]
        public void TestDrives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(964, 560, 1297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 634, 665);

                f_964_634_664(f_964_645_663());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 679, 735);

                CultureInfo
                currentCulture = f_964_708_734()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 749, 820);

                PSHost
                hostInterface = f_964_772_819(currentCulture, currentCulture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 834, 897);

                InitialSessionState
                iss = f_964_860_896()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 911, 978);

                AutomationEngine
                engine = f_964_937_977(hostInterface, iss)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 992, 1077);

                ExecutionContext
                executionContext = f_964_1028_1076(engine, hostInterface, iss)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 1091, 1170);

                SessionStateInternal
                sessionState = f_964_1127_1169(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 1184, 1243);

                Collection<PSDriveInfo>
                drives = f_964_1217_1242(sessionState, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(964, 1257, 1286);

                f_964_1257_1285(drives);
                DynAbs.Tracing.TraceSender.TraceExitMethod(964, 560, 1297);

                bool
                f_964_645_663()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(964, 645, 663);
                    return return_v;
                }


                int
                f_964_634_664(bool
                condition)
                {
                    Skip.IfNot(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 634, 664);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_964_708_734()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(964, 708, 734);
                    return return_v;
                }


                Microsoft.PowerShell.DefaultHost
                f_964_772_819(System.Globalization.CultureInfo
                currentCulture, System.Globalization.CultureInfo
                currentUICulture)
                {
                    var return_v = new Microsoft.PowerShell.DefaultHost(currentCulture, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 772, 819);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_964_860_896()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 860, 896);
                    return return_v;
                }


                System.Management.Automation.AutomationEngine
                f_964_937_977(System.Management.Automation.Host.PSHost
                hostInterface, System.Management.Automation.Runspaces.InitialSessionState
                iss)
                {
                    var return_v = new System.Management.Automation.AutomationEngine(hostInterface, iss);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 937, 977);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_964_1028_1076(System.Management.Automation.AutomationEngine
                engine, System.Management.Automation.Host.PSHost
                hostInterface, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = new System.Management.Automation.ExecutionContext(engine, hostInterface, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 1028, 1076);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_964_1127_1169(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.SessionStateInternal(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 1127, 1169);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_964_1217_1242(System.Management.Automation.SessionStateInternal
                this_param, string
                scope)
                {
                    var return_v = this_param.Drives(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 1217, 1242);
                    return return_v;
                }


                bool
                f_964_1257_1285(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(964, 1257, 1285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(964, 560, 1297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(964, 560, 1297);
            }
        }

        public SessionStateTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(964, 513, 1304);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(964, 513, 1304);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(964, 513, 1304);
        }


        static SessionStateTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(964, 513, 1304);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(964, 513, 1304);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(964, 513, 1304);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(964, 513, 1304);
    }
}
