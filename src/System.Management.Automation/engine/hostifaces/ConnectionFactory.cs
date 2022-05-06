// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Tracing;

using Microsoft.PowerShell;
using Microsoft.PowerShell.Commands;

namespace System.Management.Automation.Runspaces
{
    public static class RunspaceFactory
    {
        static RunspaceFactory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1457, 619, 912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 704, 750);

                Guid
                activityId = f_1457_722_749()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 766, 901) || true) && (activityId == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 766, 901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 828, 886);

                    f_1457_828_885(f_1457_854_884());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 766, 901);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1457, 619, 912);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 619, 912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 619, 912);
            }
        }

        public static Runspace CreateRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 1164, 1371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 1228, 1316);

                PSHost
                host = f_1457_1242_1315(f_1457_1258_1284(), f_1457_1286_1314())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 1332, 1360);

                return f_1457_1339_1359(host);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 1164, 1371);

                System.Globalization.CultureInfo
                f_1457_1258_1284()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 1258, 1284);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1457_1286_1314()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 1286, 1314);
                    return return_v;
                }


                Microsoft.PowerShell.DefaultHost
                f_1457_1242_1315(System.Globalization.CultureInfo
                currentCulture, System.Globalization.CultureInfo
                currentUICulture)
                {
                    var return_v = new Microsoft.PowerShell.DefaultHost(currentCulture, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 1242, 1315);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1457_1339_1359(System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = CreateRunspace(host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 1339, 1359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 1164, 1371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 1164, 1371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateRunspace(PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 1879, 2167);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 1954, 2072) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 1954, 2072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 2004, 2057);

                    throw f_1457_2010_2056("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 1954, 2072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 2088, 2156);

                return f_1457_2095_2155(host, f_1457_2119_2154());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 1879, 2167);

                System.Management.Automation.PSArgumentNullException
                f_1457_2010_2056(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 2010, 2056);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1457_2119_2154()
                {
                    var return_v = InitialSessionState.CreateDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 2119, 2154);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1457_2095_2155(System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = new System.Management.Automation.Runspaces.LocalRunspace(host, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 2095, 2155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 1879, 2167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 1879, 2167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        public static Runspace CreateRunspace(InitialSessionState initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 2634, 3182);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 2854, 3002) || true) && (initialSessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 2854, 3002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 2919, 2987);

                    throw f_1457_2925_2986("initialSessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 2854, 3002);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 3018, 3106);

                PSHost
                host = f_1457_3032_3105(f_1457_3048_3074(), f_1457_3076_3104())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 3122, 3171);

                return f_1457_3129_3170(host, initialSessionState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 2634, 3182);

                System.Management.Automation.PSArgumentNullException
                f_1457_2925_2986(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 2925, 2986);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1457_3048_3074()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 3048, 3074);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1457_3076_3104()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 3076, 3104);
                    return return_v;
                }


                Microsoft.PowerShell.DefaultHost
                f_1457_3032_3105(System.Globalization.CultureInfo
                currentCulture, System.Globalization.CultureInfo
                currentUICulture)
                {
                    var return_v = new Microsoft.PowerShell.DefaultHost(currentCulture, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 3032, 3105);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1457_3129_3170(System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = CreateRunspace(host, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 3129, 3170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 2634, 3182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 2634, 3182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        public static Runspace CreateRunspace(PSHost host, InitialSessionState initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 3885, 4479);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 4118, 4236) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 4118, 4236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 4168, 4221);

                    throw f_1457_4174_4220("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 4118, 4236);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 4252, 4400) || true) && (initialSessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 4252, 4400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 4317, 4385);

                    throw f_1457_4323_4384("initialSessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 4252, 4400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 4416, 4468);

                return f_1457_4423_4467(host, initialSessionState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 3885, 4479);

                System.Management.Automation.PSArgumentNullException
                f_1457_4174_4220(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 4174, 4220);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1457_4323_4384(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 4323, 4384);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1457_4423_4467(System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = new System.Management.Automation.Runspaces.LocalRunspace(host, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 4423, 4467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 3885, 4479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 3885, 4479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        internal static Runspace CreateRunspaceFromSessionStateNoClone(PSHost host, InitialSessionState initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 5182, 5807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 5440, 5558) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 5440, 5558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 5490, 5543);

                    throw f_1457_5496_5542("host");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 5440, 5558);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 5574, 5722) || true) && (initialSessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 5574, 5722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 5639, 5707);

                    throw f_1457_5645_5706("initialSessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 5574, 5722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 5738, 5796);

                return f_1457_5745_5795(host, initialSessionState, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 5182, 5807);

                System.Management.Automation.PSArgumentNullException
                f_1457_5496_5542(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 5496, 5542);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1457_5645_5706(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 5645, 5706);
                    return return_v;
                }


                System.Management.Automation.Runspaces.LocalRunspace
                f_1457_5745_5795(System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState, bool
                suppressClone)
                {
                    var return_v = new System.Management.Automation.Runspaces.LocalRunspace(host, initialSessionState, suppressClone);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 5745, 5795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 5182, 5807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 5182, 5807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RunspacePool CreateRunspacePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 6004, 6119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 6076, 6108);

                return f_1457_6083_6107(1, 1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 6004, 6119);

                System.Management.Automation.Runspaces.RunspacePool
                f_1457_6083_6107(int
                minRunspaces, int
                maxRunspaces)
                {
                    var return_v = CreateRunspacePool(minRunspaces, maxRunspaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 6083, 6107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 6004, 6119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 6004, 6119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RunspacePool CreateRunspacePool(int minRunspaces, int maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 6951, 7293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 7057, 7282);

                return f_1457_7064_7281(minRunspaces, maxRunspaces, f_1457_7128_7280(f_1457_7184_7210(), f_1457_7233_7261()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 6951, 7293);

                System.Globalization.CultureInfo
                f_1457_7184_7210()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 7184, 7210);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1457_7233_7261()
                {
                    var return_v = CultureInfo.CurrentUICulture
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 7233, 7261);
                    return return_v;
                }


                Microsoft.PowerShell.DefaultHost
                f_1457_7128_7280(System.Globalization.CultureInfo
                currentCulture, System.Globalization.CultureInfo
                currentUICulture)
                {
                    var return_v = new Microsoft.PowerShell.DefaultHost(currentCulture, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 7128, 7280);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1457_7064_7281(int
                minRunspaces, int
                maxRunspaces, Microsoft.PowerShell.DefaultHost
                host)
                {
                    var return_v = CreateRunspacePool(minRunspaces, maxRunspaces, (System.Management.Automation.Host.PSHost)host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 7064, 7281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 6951, 7293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 6951, 7293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        public static RunspacePool CreateRunspacePool(InitialSessionState initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 7840, 8303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 8068, 8292);

                return f_1457_8075_8291(1, 1, initialSessionState, f_1457_8138_8290(f_1457_8194_8220(), f_1457_8243_8271()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 7840, 8303);

                System.Globalization.CultureInfo
                f_1457_8194_8220()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 8194, 8220);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1457_8243_8271()
                {
                    var return_v = CultureInfo.CurrentUICulture
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1457, 8243, 8271);
                    return return_v;
                }


                Microsoft.PowerShell.DefaultHost
                f_1457_8138_8290(System.Globalization.CultureInfo
                currentCulture, System.Globalization.CultureInfo
                currentUICulture)
                {
                    var return_v = new Microsoft.PowerShell.DefaultHost(currentCulture, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 8138, 8290);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1457_8075_8291(int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState, Microsoft.PowerShell.DefaultHost
                host)
                {
                    var return_v = CreateRunspacePool(minRunspaces, maxRunspaces, initialSessionState, (System.Management.Automation.Host.PSHost)host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 8075, 8291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 7840, 8303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 7840, 8303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static RunspacePool CreateRunspacePool(int minRunspaces, int maxRunspaces, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 9220, 9526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 9457, 9515);

                return f_1457_9464_9514(minRunspaces, maxRunspaces, host);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 9220, 9526);

                System.Management.Automation.Runspaces.RunspacePool
                f_1457_9464_9514(int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspacePool(minRunspaces, maxRunspaces, host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 9464, 9514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 9220, 9526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 9220, 9526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static RunspacePool CreateRunspacePool(int minRunspaces, int maxRunspaces,
                    InitialSessionState initialSessionState, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 10885, 11400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 11293, 11389);

                return f_1457_11300_11388(minRunspaces, maxRunspaces, initialSessionState, host);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 10885, 11400);

                System.Management.Automation.Runspaces.RunspacePool
                f_1457_11300_11388(int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState, System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspacePool(minRunspaces, maxRunspaces, initialSessionState, host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 11300, 11388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 10885, 11400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 10885, 11400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static RunspacePool CreateRunspacePool(int minRunspaces,
                                                int maxRunspaces, RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 12644, 13035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 12948, 13024);

                return f_1457_12955_13023(minRunspaces, maxRunspaces, connectionInfo, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 12644, 13035);

                System.Management.Automation.Runspaces.RunspacePool
                f_1457_12955_13023(int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = CreateRunspacePool(minRunspaces, maxRunspaces, connectionInfo, host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 12955, 13023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 12644, 13035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 12644, 13035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static RunspacePool CreateRunspacePool(int minRunspaces,
                    int maxRunspaces, RunspaceConnectionInfo connectionInfo, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 14310, 14692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 14599, 14681);

                return f_1457_14606_14680(minRunspaces, maxRunspaces, connectionInfo, host, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 14310, 14692);

                System.Management.Automation.Runspaces.RunspacePool
                f_1457_14606_14680(int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = CreateRunspacePool(minRunspaces, maxRunspaces, connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 14606, 14680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 14310, 14692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 14310, 14692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static RunspacePool CreateRunspacePool(int minRunspaces,
                    int maxRunspaces, RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 16648, 17062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 16958, 17051);

                return f_1457_16965_17050(minRunspaces, maxRunspaces, connectionInfo, host, typeTable, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 16648, 17062);

                System.Management.Automation.Runspaces.RunspacePool
                f_1457_16965_17050(int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable, System.Management.Automation.PSPrimitiveDictionary
                applicationArguments)
                {
                    var return_v = CreateRunspacePool(minRunspaces, maxRunspaces, connectionInfo, host, typeTable, applicationArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 16965, 17050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 16648, 17062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 16648, 17062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        public static RunspacePool CreateRunspacePool(int minRunspaces,
                    int maxRunspaces, RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable, PSPrimitiveDictionary applicationArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 19232, 20270);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 19586, 19977) || true) && ((!(connectionInfo is WSManConnectionInfo)) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 19590, 19700) && (!(connectionInfo is NewProcessConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 19590, 19767) && (!(connectionInfo is NamedPipeConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 19590, 19827) && (!(connectionInfo is VMConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 19590, 19894) && (!(connectionInfo is ContainerConnectionInfo))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 19586, 19977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 19928, 19962);

                    throw f_1457_19934_19961();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 19586, 19977);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 19993, 20136) || true) && (connectionInfo is WSManConnectionInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 19993, 20136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 20068, 20121);

                    f_1457_20068_20120();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 19993, 20136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 20152, 20259);

                return f_1457_20159_20258(minRunspaces, maxRunspaces, typeTable, host, applicationArguments, connectionInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 19232, 20270);

                System.NotSupportedException
                f_1457_19934_19961()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 19934, 19961);
                    return return_v;
                }


                int
                f_1457_20068_20120()
                {
                    RemotingCommandUtil.CheckHostRemotingPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 20068, 20120);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1457_20159_20258(int
                minRunspaces, int
                maxRunspaces, System.Management.Automation.Runspaces.TypeTable
                typeTable, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.PSPrimitiveDictionary
                applicationArguments, System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.RunspacePool(minRunspaces, maxRunspaces, typeTable, host, applicationArguments, connectionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 20159, 20258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 19232, 20270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 19232, 20270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateRunspace(RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 21045, 21258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 21180, 21247);

                return f_1457_21187_21246(connectionInfo, host, typeTable, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 21045, 21258);

                System.Management.Automation.Runspaces.Runspace
                f_1457_21187_21246(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable, System.Management.Automation.PSPrimitiveDictionary
                applicationArguments, string
                name)
                {
                    var return_v = CreateRunspace(connectionInfo, host, typeTable, applicationArguments, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 21187, 21246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 21045, 21258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 21045, 21258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateRunspace(RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable, PSPrimitiveDictionary applicationArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 22150, 22423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 22329, 22412);

                return f_1457_22336_22411(connectionInfo, host, typeTable, applicationArguments, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 22150, 22423);

                System.Management.Automation.Runspaces.Runspace
                f_1457_22336_22411(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable, System.Management.Automation.PSPrimitiveDictionary
                applicationArguments, string
                name)
                {
                    var return_v = CreateRunspace(connectionInfo, host, typeTable, applicationArguments, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 22336, 22411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 22150, 22423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 22150, 22423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateRunspace(RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable, PSPrimitiveDictionary applicationArguments, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 23381, 24298);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 23573, 24025) || true) && ((!(connectionInfo is WSManConnectionInfo)) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 23577, 23687) && (!(connectionInfo is NewProcessConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 23577, 23754) && (!(connectionInfo is NamedPipeConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 23577, 23815) && (!(connectionInfo is SSHConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 23577, 23875) && (!(connectionInfo is VMConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1457, 23577, 23942) && (!(connectionInfo is ContainerConnectionInfo))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 23573, 24025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 23976, 24010);

                    throw f_1457_23982_24009();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 23573, 24025);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 24041, 24184) || true) && (connectionInfo is WSManConnectionInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1457, 24041, 24184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 24116, 24169);

                    f_1457_24116_24168();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1457, 24041, 24184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 24200, 24287);

                return f_1457_24207_24286(typeTable, connectionInfo, host, applicationArguments, name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 23381, 24298);

                System.NotSupportedException
                f_1457_23982_24009()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 23982, 24009);
                    return return_v;
                }


                int
                f_1457_24116_24168()
                {
                    RemotingCommandUtil.CheckHostRemotingPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 24116, 24168);
                    return 0;
                }


                System.Management.Automation.RemoteRunspace
                f_1457_24207_24286(System.Management.Automation.Runspaces.TypeTable
                typeTable, System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.PSPrimitiveDictionary
                applicationArguments, string
                name)
                {
                    var return_v = new System.Management.Automation.RemoteRunspace(typeTable, connectionInfo, host, applicationArguments, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 24207, 24286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 23381, 24298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 23381, 24298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateRunspace(PSHost host, RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 24482, 24657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 24596, 24646);

                return f_1457_24603_24645(connectionInfo, host, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 24482, 24657);

                System.Management.Automation.Runspaces.Runspace
                f_1457_24603_24645(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = CreateRunspace(connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 24603, 24645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 24482, 24657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 24482, 24657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateRunspace(RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 24800, 24956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 24901, 24945);

                return f_1457_24908_24944(null, connectionInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 24800, 24956);

                System.Management.Automation.Runspaces.Runspace
                f_1457_24908_24944(System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo)
                {
                    var return_v = CreateRunspace(host, connectionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 24908, 24944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 24800, 24956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 24800, 24956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateOutOfProcessRunspace(TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 25175, 25429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 25270, 25347);

                NewProcessConnectionInfo
                connectionInfo = f_1457_25312_25346(null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 25363, 25418);

                return f_1457_25370_25417(connectionInfo, null, typeTable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 25175, 25429);

                System.Management.Automation.Runspaces.NewProcessConnectionInfo
                f_1457_25312_25346(System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = new System.Management.Automation.Runspaces.NewProcessConnectionInfo(credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 25312, 25346);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1457_25370_25417(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = CreateRunspace((System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 25370, 25417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 25175, 25429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 25175, 25429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Runspace CreateOutOfProcessRunspace(TypeTable typeTable, PowerShellProcessInstance processInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1457, 25619, 25946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 25757, 25864);

                NewProcessConnectionInfo
                connectionInfo = new NewProcessConnectionInfo(null) { Process = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => processInstance, 1457, 25799, 25863) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1457, 25880, 25935);

                return f_1457_25887_25934(connectionInfo, null, typeTable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1457, 25619, 25946);

                System.Management.Automation.Runspaces.Runspace
                f_1457_25887_25934(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = CreateRunspace((System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 25887, 25934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1457, 25619, 25946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1457, 25619, 25946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static System.Guid
        f_1457_722_749()
        {
            var return_v = EtwActivity.GetActivityId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 722, 749);
            return return_v;
        }


        static System.Guid
        f_1457_854_884()
        {
            var return_v = EtwActivity.CreateActivityId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 854, 884);
            return return_v;
        }


        static bool
        f_1457_828_885(System.Guid
        activityId)
        {
            var return_v = EtwActivity.SetActivityId(activityId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1457, 828, 885);
            return return_v;
        }

    }
}

