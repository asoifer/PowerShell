// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public sealed class RunspacePoolStateInfo
    {
        public RunspacePoolState State { get; }

        public Exception Reason { get; }

        public RunspacePoolStateInfo(RunspacePoolState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1631, 1228, 1379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1631, 773, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1631, 922, 954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1631, 1324, 1338);

                State = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1631, 1352, 1368);

                Reason = reason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1631, 1228, 1379);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1631, 1228, 1379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1631, 1228, 1379);
            }
        }

        static RunspacePoolStateInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1631, 603, 1386);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1631, 603, 1386);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1631, 603, 1386);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1631, 603, 1386);
    }
}
