// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation;

using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.Format, "Default")]
    public class FormatDefaultCommand : FrontEndCommandBase
    {
        public FormatDefaultCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1113, 553, 691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1113, 607, 680);

                this.implementation = f_1113_629_679(FormatShape.Undefined);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1113, 553, 691);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1113, 553, 691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1113, 553, 691);
            }
        }

        static FormatDefaultCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1113, 338, 698);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1113, 338, 698);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1113, 338, 698);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1113, 338, 698);

        Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
        f_1113_629_679(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
        shape)
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand(shape);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1113, 629, 679);
            return return_v;
        }

    }
}

