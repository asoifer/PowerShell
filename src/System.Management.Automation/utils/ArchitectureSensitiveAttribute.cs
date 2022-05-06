// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Internal
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal class ArchitectureSensitiveAttribute : Attribute
    {
        internal ArchitectureSensitiveAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1000, 827, 890);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1000, 827, 890);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1000, 827, 890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1000, 827, 890);
            }
        }

        static ArchitectureSensitiveAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1000, 565, 897);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1000, 565, 897);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1000, 565, 897);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1000, 565, 897);
    }
}
