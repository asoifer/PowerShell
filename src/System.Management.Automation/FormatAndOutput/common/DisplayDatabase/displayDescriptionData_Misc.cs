// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// this file contains the data structures for the in memory database
// containing display and formatting information

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class FieldControlBody : ControlBody
    {
        internal FieldFormattingDirective fieldFormattingDirective;

        public FieldControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1122, 381, 549);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1122, 484, 541);
            this.fieldFormattingDirective = f_1122_511_541();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1122, 381, 549);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1122, 381, 549);
        }


        static FieldControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1122, 381, 549);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1122, 381, 549);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1122, 381, 549);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1122, 381, 549);

        Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
        f_1122_511_541()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1122, 511, 541);
            return return_v;
        }

    }
}
