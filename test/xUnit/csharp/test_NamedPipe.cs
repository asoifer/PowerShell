// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Remoting;
using Xunit;

namespace PSTests.Parallel
{
    public class NamedPipeTests
    {
        [Fact]
        public void TestCustomPipeNameCreation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(957, 319, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 400, 455);

                string
                pipeNameForFirstCall = f_957_430_454()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 469, 525);

                string
                pipeNameForSecondCall = f_957_500_524()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 541, 620);

                f_957_541_619(pipeNameForFirstCall);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 634, 700);

                f_957_634_699(f_957_652_698(f_957_664_697(pipeNameForFirstCall)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 800, 880);

                f_957_800_879(pipeNameForSecondCall);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 894, 961);

                f_957_894_960(f_957_912_959(f_957_924_958(pipeNameForSecondCall)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1036, 1103);

                f_957_1036_1102(f_957_1055_1101(f_957_1067_1100(pipeNameForFirstCall)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(957, 319, 1114);

                string
                f_957_430_454()
                {
                    var return_v = Path.GetRandomFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 430, 454);
                    return return_v;
                }


                string
                f_957_500_524()
                {
                    var return_v = Path.GetRandomFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 500, 524);
                    return return_v;
                }


                int
                f_957_541_619(string
                pipeName)
                {
                    RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 541, 619);
                    return 0;
                }


                string
                f_957_664_697(string
                pipeName)
                {
                    var return_v = GetPipePath(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 664, 697);
                    return return_v;
                }


                bool
                f_957_652_698(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 652, 698);
                    return return_v;
                }


                bool
                f_957_634_699(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 634, 699);
                    return return_v;
                }


                int
                f_957_800_879(string
                pipeName)
                {
                    RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 800, 879);
                    return 0;
                }


                string
                f_957_924_958(string
                pipeName)
                {
                    var return_v = GetPipePath(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 924, 958);
                    return return_v;
                }


                bool
                f_957_912_959(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 912, 959);
                    return return_v;
                }


                bool
                f_957_894_960(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 894, 960);
                    return return_v;
                }


                string
                f_957_1067_1100(string
                pipeName)
                {
                    var return_v = GetPipePath(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1067, 1100);
                    return return_v;
                }


                bool
                f_957_1055_1101(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1055, 1101);
                    return return_v;
                }


                bool
                f_957_1036_1102(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1036, 1102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(957, 319, 1114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(957, 319, 1114);
            }
        }

        [Fact]
        public void TestCustomPipeNameCreationTooLongOnNonWindows()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(957, 1126, 1835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1226, 1376);

                var
                longPipeName = "DoggoipsumwaggywagssmolborkingdoggowithalongsnootforpatsdoingmeafrightenporgoYapperporgolongwatershoobcloudsbigolpupperlengthboy"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1392, 1824) || true) && (f_957_1396_1415_M(!Platform.IsWindows))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(957, 1392, 1824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1449, 1596);

                    f_957_1449_1595(() =>
                                        RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(longPipeName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(957, 1392, 1824);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(957, 1392, 1824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1662, 1733);

                    f_957_1662_1732(longPipeName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1751, 1809);

                    f_957_1751_1808(f_957_1769_1807(f_957_1781_1806(longPipeName)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(957, 1392, 1824);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(957, 1126, 1835);

                bool
                f_957_1396_1415_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(957, 1396, 1415);
                    return return_v;
                }


                System.InvalidOperationException
                f_957_1449_1595(System.Action
                testCode)
                {
                    var return_v = CustomAssert.Throws<InvalidOperationException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1449, 1595);
                    return return_v;
                }


                int
                f_957_1662_1732(string
                pipeName)
                {
                    RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1662, 1732);
                    return 0;
                }


                string
                f_957_1781_1806(string
                pipeName)
                {
                    var return_v = GetPipePath(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1781, 1806);
                    return return_v;
                }


                bool
                f_957_1769_1807(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1769, 1807);
                    return return_v;
                }


                bool
                f_957_1751_1808(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 1751, 1808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(957, 1126, 1835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(957, 1126, 1835);
            }
        }

        private static string GetPipePath(string pipeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(957, 1847, 2104);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1922, 2024) || true) && (f_957_1926_1944())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(957, 1922, 2024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 1978, 2009);

                    return $@"\\.\pipe\{pipeName}";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(957, 1922, 2024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(957, 2040, 2093);

                return $@"{f_957_2051_2069()}CoreFxPipe_{pipeName}";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(957, 1847, 2104);

                bool
                f_957_1926_1944()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(957, 1926, 1944);
                    return return_v;
                }


                string
                f_957_2051_2069()
                {
                    var return_v = Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(957, 2051, 2069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(957, 1847, 2104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(957, 1847, 2104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedPipeTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(957, 267, 2111);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(957, 267, 2111);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(957, 267, 2111);
        }


        static NamedPipeTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(957, 267, 2111);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(957, 267, 2111);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(957, 267, 2111);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(957, 267, 2111);
    }
}
