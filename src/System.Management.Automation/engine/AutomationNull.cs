// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Internal
{
    public static class AutomationNull
    {
        public static PSObject Value { get; }

        static AutomationNull()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1238, 714, 1120);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1238, 1020, 1075);
            Value = f_1238_1060_1074();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1238, 714, 1120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1238, 714, 1120);
        }


        static System.Management.Automation.PSObject
        f_1238_1060_1074()
        {
            var return_v = new System.Management.Automation.PSObject();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1238, 1060, 1074);
            return return_v;
        }

    }
}

