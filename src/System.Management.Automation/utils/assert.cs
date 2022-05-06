// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// The define below is only valid for this file. It allows the methods
// defined here to call Diagnostics.Assert when only ASSERTIONS_TRACE is defined
// Any #if DEBUG is pointless (always true) in this file because of this declaration.
// The presence of the define will cause the System.Diagnostics.Debug.Asser calls
// always to be compiled in for this file. What can be compiled out are the calls to
// System.Management.Automation.Diagnostics.Assert in other files when neither DEBUG
// nor ASSERTIONS_TRACE is defined.
#define DEBUG

using System.Diagnostics;
using System.Text;

namespace System.Management.Automation
{
    internal class AssertException : SystemException
    {
        internal AssertException(string message) : base(f_1001_1163_1170_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1001, 1115, 1339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 1516, 1558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 1289, 1328);

                StackTrace = f_1001_1302_1327(3);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1001, 1115, 1339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1001, 1115, 1339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 1115, 1339);
            }
        }

        public override string StackTrace { get; }

        static AssertException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1001, 859, 1565);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1001, 859, 1565);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 859, 1565);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1001, 859, 1565);

        string
        f_1001_1302_1327(int
        framesToSkip)
        {
            var return_v = Diagnostics.StackTrace(framesToSkip);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 1302, 1327);
            return return_v;
        }


        static string
        f_1001_1163_1170_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1001, 1115, 1339);
            return return_v;
        }

    }
    internal sealed class Diagnostics
    {
        internal static string StackTrace(int framesToSkip)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1001, 2148, 2727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2224, 2264);

                StackTrace
                trace = f_1001_2243_2263(true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2278, 2318);

                StackFrame[]
                frames = f_1001_2300_2317(trace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2332, 2380);

                StringBuilder
                frameString = f_1001_2360_2379()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2394, 2413);

                int
                maxFrames = 10
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2427, 2453);

                maxFrames += framesToSkip;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2476, 2492);
                    for (int
        i = framesToSkip
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2467, 2670) || true) && ((i < f_1001_2499_2512(frames)) && (DynAbs.Tracing.TraceSender.Expression_True(1001, 2494, 2532) && (i < maxFrames)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2534, 2537)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1001, 2467, 2670))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1001, 2467, 2670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2571, 2600);

                        StackFrame
                        frame = frames[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2618, 2655);

                        f_1001_2618_2654(frameString, f_1001_2637_2653(frame));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1001, 1, 204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1001, 1, 204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2686, 2716);

                return f_1001_2693_2715(frameString);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1001, 2148, 2727);

                System.Diagnostics.StackTrace
                f_1001_2243_2263(bool
                fNeedFileInfo)
                {
                    var return_v = new System.Diagnostics.StackTrace(fNeedFileInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 2243, 2263);
                    return return_v;
                }


                System.Diagnostics.StackFrame?[]
                f_1001_2300_2317(System.Diagnostics.StackTrace
                this_param)
                {
                    var return_v = this_param.GetFrames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 2300, 2317);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1001_2360_2379()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 2360, 2379);
                    return return_v;
                }


                int
                f_1001_2499_2512(System.Diagnostics.StackFrame[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1001, 2499, 2512);
                    return return_v;
                }


                string
                f_1001_2637_2653(System.Diagnostics.StackFrame
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 2637, 2653);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1001_2618_2654(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 2618, 2654);
                    return return_v;
                }


                string
                f_1001_2693_2715(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 2693, 2715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1001, 2148, 2727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 2148, 2727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object s_throwInsteadOfAssertLock;

        private static bool s_throwInsteadOfAssert;

        internal static bool ThrowInsteadOfAssert
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1001, 3192, 3366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 3234, 3260);
                    lock (s_throwInsteadOfAssertLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 3302, 3332);

                        return s_throwInsteadOfAssert;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1001, 3192, 3366);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1001, 3126, 3568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 3126, 3568);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1001, 3382, 3557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 3424, 3450);
                    lock (s_throwInsteadOfAssertLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 3492, 3523);

                        s_throwInsteadOfAssert = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1001, 3382, 3557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1001, 3126, 3568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 3126, 3568);
                }
            }
        }

        private Diagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1001, 3717, 3742);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1001, 3717, 3742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1001, 3717, 3742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 3717, 3742);
            }
        }

        [System.Diagnostics.Conditional("DEBUG")]
        [System.Diagnostics.Conditional("ASSERTIONS_TRACE")]
        internal static void Assert(
                    bool condition,
                    string whyThisShouldNeverHappen)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1001, 4543, 5092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 5011, 5081);

                f_1001_5011_5080(condition, whyThisShouldNeverHappen, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1001, 4543, 5092);

                int
                f_1001_5011_5080(bool
                condition, string
                whyThisShouldNeverHappen, string
                detailMessage)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen, detailMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 5011, 5080);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1001, 4543, 5092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 4543, 5092);
            }
        }

        [System.Diagnostics.Conditional("DEBUG")]
        [System.Diagnostics.Conditional("ASSERTIONS_TRACE")]
        internal static void
                Assert(
                    bool condition,
                    string whyThisShouldNeverHappen, string detailMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1001, 6031, 8044);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 6637, 6659) || true) && (condition)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1001, 6637, 6659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 6652, 6659);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1001, 6637, 6659);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 7698, 7938) || true) && (f_1001_7702_7734())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1001, 7698, 7938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 7768, 7861);

                    string
                    assertionMessage = "ASSERT: " + whyThisShouldNeverHappen + "  " + detailMessage + " "
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 7879, 7923);

                    throw f_1001_7885_7922(assertionMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1001, 7698, 7938);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 7954, 8025);

                f_1001_7954_8024(whyThisShouldNeverHappen, detailMessage);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1001, 6031, 8044);

                bool
                f_1001_7702_7734()
                {
                    var return_v = Diagnostics.ThrowInsteadOfAssert;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1001, 7702, 7734);
                    return return_v;
                }


                System.Management.Automation.AssertException
                f_1001_7885_7922(string
                message)
                {
                    var return_v = new System.Management.Automation.AssertException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 7885, 7922);
                    return return_v;
                }


                int
                f_1001_7954_8024(string
                message, string
                detailMessage)
                {
                    System.Diagnostics.Debug.Fail(message, detailMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1001, 7954, 8024);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1001, 6031, 8044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 6031, 8044);
            }
        }

        static Diagnostics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1001, 2098, 8051);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2761, 2791);
            s_throwInsteadOfAssertLock = 1;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1001, 2824, 2854);
            s_throwInsteadOfAssert = false;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1001, 2098, 8051);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1001, 2098, 8051);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1001, 2098, 8051);
    }
}

