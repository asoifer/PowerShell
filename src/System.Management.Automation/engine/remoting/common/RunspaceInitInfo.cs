// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class RunspacePoolInitInfo
    {
        internal int MinRunspaces { get; }

        internal int MaxRunspaces { get; }

        internal RunspacePoolInitInfo(int minRS, int maxRS)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1630, 870, 1013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1630, 510, 544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1630, 667, 701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1630, 946, 967);

                MinRunspaces = minRS;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1630, 981, 1002);

                MaxRunspaces = maxRS;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1630, 870, 1013);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1630, 870, 1013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1630, 870, 1013);
            }
        }

        static RunspacePoolInitInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1630, 347, 1020);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1630, 347, 1020);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1630, 347, 1020);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1630, 347, 1020);
    }
}
