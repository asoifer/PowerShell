// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
    internal static class DriveNames
    {
        internal const string
        VariableDrive = "Variable"
        ;

        internal const string
        EnvironmentDrive = "Env"
        ;

        internal const string
        AliasDrive = "Alias"
        ;

        internal const string
        FunctionDrive = "Function"
        ;

        internal const string
        TempDrive = "Temp"
        ;

        static DriveNames()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1265, 285, 1103);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1265, 457, 483);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1265, 622, 646);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1265, 779, 799);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1265, 935, 961);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1265, 1077, 1095);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1265, 285, 1103);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1265, 285, 1103);
        }

    }
}
