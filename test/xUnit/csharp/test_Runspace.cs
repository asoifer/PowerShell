// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Reflection;
using Xunit;

namespace PSTests.Sequential
{
    public class RunspaceTests
    {
        private static int count;

        private static string script;

        [Fact]
        public void TestRunspaceWithPipeline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(962, 581, 1244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 660, 1233);
                using (Runspace
                runspace = f_962_687_719()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 753, 769);

                    f_962_753_768(runspace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 789, 1181);
                    using (var
                    pipeline = f_962_811_842(runspace, script)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 884, 901);

                        int
                        objCount = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 923, 1102);
                            foreach (var result in f_962_946_963_I(f_962_946_963(pipeline)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(962, 923, 1102);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1013, 1024);

                                ++objCount;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1050, 1079);

                                f_962_1050_1078(result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(962, 923, 1102);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(962, 1, 180);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(962, 1, 180);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1126, 1162);

                        f_962_1126_1161(count, objCount);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(962, 789, 1181);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1201, 1218);

                    f_962_1201_1217(
                                    runspace);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(962, 660, 1233);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(962, 581, 1244);

                System.Management.Automation.Runspaces.Runspace
                f_962_687_719()
                {
                    var return_v = RunspaceFactory.CreateRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 687, 719);
                    return return_v;
                }


                int
                f_962_753_768(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 753, 768);
                    return 0;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_962_811_842(System.Management.Automation.Runspaces.Runspace
                this_param, string
                command)
                {
                    var return_v = this_param.CreatePipeline(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 811, 842);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_962_946_963(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 946, 963);
                    return return_v;
                }


                bool
                f_962_1050_1078(System.Management.Automation.PSObject
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1050, 1078);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_962_946_963_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 946, 963);
                    return return_v;
                }


                bool
                f_962_1126_1161(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1126, 1161);
                    return return_v;
                }


                int
                f_962_1201_1217(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1201, 1217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(962, 581, 1244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(962, 581, 1244);
            }
        }

        [Fact]
        public void TestRunspaceWithPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(962, 1256, 2023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1337, 2012);
                using (var
                runspace = f_962_1359_1391()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1425, 1441);

                    f_962_1425_1440(runspace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1461, 1960);
                    using (PowerShell
                    powerShell = f_962_1492_1511()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1553, 1584);

                        powerShell.Runspace = runspace;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1608, 1637);

                        f_962_1608_1636(
                                            powerShell, script);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1661, 1678);

                        int
                        objCount = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1700, 1881);
                            foreach (var result in f_962_1723_1742_I(f_962_1723_1742(powerShell)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(962, 1700, 1881);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1792, 1803);

                                ++objCount;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1829, 1858);

                                f_962_1829_1857(result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(962, 1700, 1881);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(962, 1, 182);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(962, 1, 182);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1905, 1941);

                        f_962_1905_1940(count, objCount);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(962, 1461, 1960);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 1980, 1997);

                    f_962_1980_1996(
                                    runspace);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(962, 1337, 2012);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(962, 1256, 2023);

                System.Management.Automation.Runspaces.Runspace
                f_962_1359_1391()
                {
                    var return_v = RunspaceFactory.CreateRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1359, 1391);
                    return return_v;
                }


                int
                f_962_1425_1440(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1425, 1440);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_962_1492_1511()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1492, 1511);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_962_1608_1636(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1608, 1636);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_962_1723_1742(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1723, 1742);
                    return return_v;
                }


                bool
                f_962_1829_1857(System.Management.Automation.PSObject
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1829, 1857);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_962_1723_1742_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1723, 1742);
                    return return_v;
                }


                bool
                f_962_1905_1940(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1905, 1940);
                    return return_v;
                }


                int
                f_962_1980_1996(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 1980, 1996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(962, 1256, 2023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(962, 1256, 2023);
            }
        }

        [Fact]
        public void TestRunspaceWithPowerShellAndInitialSessionState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(962, 2035, 3445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2185, 2247);

                InitialSessionState
                iss = f_962_2211_2246()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2426, 3434);
                using (Runspace
                runspace = f_962_2453_2499(iss)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2533, 2549);

                    f_962_2533_2548(runspace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2567, 3382);
                    using (PowerShell
                    powerShell = f_962_2598_2617()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2659, 2690);

                        powerShell.Runspace = runspace;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2712, 2786);

                        f_962_2712_2785(powerShell, "Import-Module Microsoft.PowerShell.Utility -Force");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2808, 2837);

                        f_962_2808_2836(powerShell, script);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2861, 2878);

                        int
                        objCount = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2902, 2936);

                        var
                        results = f_962_2916_2935(powerShell)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 2960, 3303);
                            foreach (var result in f_962_2983_2990_I(results))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(962, 2960, 3303);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 3214, 3225);

                                ++objCount;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 3251, 3280);

                                f_962_3251_3279(result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(962, 2960, 3303);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(962, 1, 344);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(962, 1, 344);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 3327, 3363);

                        f_962_3327_3362(count, objCount);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(962, 2567, 3382);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 3402, 3419);

                    f_962_3402_3418(
                                    runspace);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(962, 2426, 3434);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(962, 2035, 3445);

                System.Management.Automation.Runspaces.InitialSessionState
                f_962_2211_2246()
                {
                    var return_v = InitialSessionState.CreateDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2211, 2246);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_962_2453_2499(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspace(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2453, 2499);
                    return return_v;
                }


                int
                f_962_2533_2548(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2533, 2548);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_962_2598_2617()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2598, 2617);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_962_2712_2785(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2712, 2785);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_962_2808_2836(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2808, 2836);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_962_2916_2935(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2916, 2935);
                    return return_v;
                }


                bool
                f_962_3251_3279(System.Management.Automation.PSObject
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 3251, 3279);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_962_2983_2990_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 2983, 2990);
                    return return_v;
                }


                bool
                f_962_3327_3362(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 3327, 3362);
                    return return_v;
                }


                int
                f_962_3402_3418(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 3402, 3418);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(962, 2035, 3445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(962, 2035, 3445);
            }
        }

        public RunspaceTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(962, 414, 4636);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(962, 414, 4636);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(962, 414, 4636);
        }


        static RunspaceTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(962, 414, 4636);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 476, 485);
            count = 1;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(962, 518, 568);
            script = f_962_527_568($"get-command get-command");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(962, 414, 4636);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(962, 414, 4636);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(962, 414, 4636);

        static string
        f_962_527_568(string
        format, params object?[]
        args)
        {
            var return_v = string.Format(format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(962, 527, 568);
            return return_v;
        }

    }
}
