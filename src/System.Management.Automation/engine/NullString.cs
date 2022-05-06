// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Language
{
    public class NullString
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1302, 608, 689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1302, 666, 678);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1302, 608, 689);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1302, 608, 689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1302, 608, 689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NullString Value { get; }

        private NullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1302, 1085, 1127);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1302, 1085, 1127);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1302, 1085, 1127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1302, 1085, 1127);
            }
        }

        static NullString()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1302, 306, 1176);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1302, 812, 871);
            Value = f_1302_854_870();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1302, 306, 1176);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1302, 306, 1176);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1302, 306, 1176);

        static System.Management.Automation.Language.NullString
        f_1302_854_870()
        {
            var return_v = new System.Management.Automation.Language.NullString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1302, 854, 870);
            return return_v;
        }

    }
}
