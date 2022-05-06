// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ObjectRef<T> where T : class
    {
        private T _newValue;

        private T _oldValue;

        internal T OldValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1621, 949, 1017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 985, 1002);

                    return _oldValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1621, 949, 1017);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1621, 905, 1028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1621, 905, 1028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal T Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1621, 1148, 1397);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 1184, 1382) || true) && (_newValue == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1621, 1184, 1382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 1247, 1264);

                        return _oldValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1621, 1184, 1382);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1621, 1184, 1382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 1346, 1363);

                        return _newValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1621, 1184, 1382);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1621, 1148, 1397);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1621, 1107, 1408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1621, 1107, 1408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsOverridden
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1621, 1546, 1622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 1582, 1607);

                    return _newValue != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1621, 1546, 1622);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1621, 1495, 1633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1621, 1495, 1633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ObjectRef(T oldValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1621, 1732, 1891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 711, 720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 812, 821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 1787, 1845);

                f_1621_1787_1844(oldValue != null, "Expected oldValue != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 1859, 1880);

                _oldValue = oldValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1621, 1732, 1891);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1621, 1732, 1891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1621, 1732, 1891);
            }
        }

        internal void Override(T newValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1621, 1973, 2136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 2032, 2090);

                f_1621_2032_2089(newValue != null, "Expected newValue != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 2104, 2125);

                _newValue = newValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1621, 1973, 2136);

                int
                f_1621_2032_2089(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1621, 2032, 2089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1621, 1973, 2136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1621, 1973, 2136);
            }
        }

        internal void Revert()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1621, 2216, 2291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1621, 2263, 2280);

                _newValue = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1621, 2216, 2291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1621, 2216, 2291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1621, 2216, 2291);
            }
        }

        static ObjectRef()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1621, 570, 2298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1621, 570, 2298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1621, 570, 2298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1621, 570, 2298);

        int
        f_1621_1787_1844(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1621, 1787, 1844);
            return 0;
        }

    }
}
