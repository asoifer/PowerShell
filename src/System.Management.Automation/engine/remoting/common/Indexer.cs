// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class Indexer : IEnumerable, IEnumerator
    {
        private int[] _current;

        private int[] _lengths;

        public object Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1619, 834, 901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 870, 886);

                    return _current;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1619, 834, 901);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1619, 788, 912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1619, 788, 912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Indexer(int[] lengths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1619, 1009, 1318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 594, 602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 698, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1065, 1121);

                f_1619_1065_1120(lengths != null, "Expected lengths != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1135, 1154);

                _lengths = lengths;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1168, 1258);

                f_1619_1168_1257(f_1619_1179_1211(this, lengths), "Expected CheckLengthsNonNegative(lengths)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1272, 1307);

                _current = new int[f_1619_1291_1305(lengths)];
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1619, 1009, 1318);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1619, 1009, 1318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1619, 1009, 1318);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        private bool CheckLengthsNonNegative(int[] lengths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1619, 1418, 1832);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1622, 1627);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1613, 1793) || true) && (i < f_1619_1633_1647(lengths))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1649, 1652)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1619, 1613, 1793))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1619, 1613, 1793);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1686, 1778) || true) && (lengths[i] < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1619, 1686, 1778);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1746, 1759);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1619, 1686, 1778);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1619, 1, 181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1619, 1, 181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1809, 1821);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1619, 1418, 1832);

                int
                f_1619_1633_1647(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1619, 1633, 1647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1619, 1418, 1832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1619, 1418, 1832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1619, 1920, 2029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 1979, 1992);

                f_1619_1979_1991(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2006, 2018);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1619, 1920, 2029);

                int
                f_1619_1979_1991(System.Management.Automation.Remoting.Indexer
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1619, 1979, 1991);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1619, 1920, 2029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1619, 1920, 2029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1619, 2108, 2467);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2161, 2166);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2152, 2257) || true) && (i < f_1619_2172_2187(_current))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2189, 2192)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1619, 2152, 2257))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1619, 2152, 2257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2226, 2242);

                        _current[i] = 0;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1619, 1, 106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1619, 1, 106);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2349, 2456) || true) && (f_1619_2353_2368(_current) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1619, 2349, 2456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2406, 2441);

                    _current[f_1619_2415_2430(_current) - 1] = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1619, 2349, 2456);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1619, 2108, 2467);

                int
                f_1619_2172_2187(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1619, 2172, 2187);
                    return return_v;
                }


                int
                f_1619_2353_2368(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1619, 2353, 2368);
                    return return_v;
                }


                int
                f_1619_2415_2430(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1619, 2415, 2430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1619, 2108, 2467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1619, 2108, 2467);
            }
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1619, 2550, 3042);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2606, 2629);
                    for (int
        i = f_1619_2610_2625(_lengths) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2597, 3002) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2639, 2642)
        , --i, DynAbs.Tracing.TraceSender.TraceExitCondition(1619, 2597, 3002))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1619, 2597, 3002);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2736, 2878) || true) && (_current[i] < _lengths[i] - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1619, 2736, 2878);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2811, 2825);

                            _current[i]++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2847, 2859);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1619, 2736, 2878);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 2971, 2987);

                        _current[i] = 0;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1619, 1, 406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1619, 1, 406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1619, 3018, 3031);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1619, 2550, 3042);

                int
                f_1619_2610_2625(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1619, 2610, 2625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1619, 2550, 3042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1619, 2550, 3042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Indexer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1619, 445, 3049);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1619, 445, 3049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1619, 445, 3049);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1619, 445, 3049);

        int
        f_1619_1065_1120(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1619, 1065, 1120);
            return 0;
        }


        bool
        f_1619_1179_1211(System.Management.Automation.Remoting.Indexer
        this_param, int[]
        lengths)
        {
            var return_v = this_param.CheckLengthsNonNegative(lengths);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1619, 1179, 1211);
            return return_v;
        }


        int
        f_1619_1168_1257(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1619, 1168, 1257);
            return 0;
        }


        int
        f_1619_1291_1305(int[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1619, 1291, 1305);
            return return_v;
        }

    }
}
