// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Microsoft.PowerShell.Cmdletization
{
    /// <summary>
    /// Describes how to handle the method parameter.
    /// </summary>
    [Flags]
    public enum MethodParameterBindings
    {
        /// <summary>
        /// Bind value of a method parameter based on arguments of a cmdlet parameter.
        /// </summary>
        In = 1,

        /// <summary>
        /// Method invocation is expected to set the value of the method parameter.  Cmdlet should emit the value of method parameter to the downstream pipe.
        /// </summary>
        Out = 2,

        /// <summary>
        /// Method invocation is expected to set the value of the method parameter.  Cmdlet should emit a non-terminating error when the value evaluates to $true.
        /// </summary>
        Error = 4,
    }
    public sealed class MethodParameter
    {
        public string Name { get; set; }

        public Type ParameterType { get; set; }

        public string ParameterTypeName { get; set; }

        public MethodParameterBindings Bindings { get; set; }

        public object Value { get; set; }

        public bool IsValuePresent { get; set; }

        public MethodParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1063, 1096, 2519);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1063, 1238, 1270);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1063, 1412, 1451);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1063, 1744, 1789);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1063, 1909, 1962);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1063, 2081, 2114);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1063, 2374, 2414);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1063, 1096, 2519);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1063, 1096, 2519);
        }


        static MethodParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1063, 1096, 2519);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1063, 1096, 2519);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1063, 1096, 2519);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1063, 1096, 2519);
    }
}
