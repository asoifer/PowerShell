// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class TestPriorityAttribute : Attribute
{
    public TestPriorityAttribute(int priority)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(950, 238, 324);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(950, 332, 373);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(950, 297, 317);

            Priority = priority;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(950, 238, 324);
        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(950, 238, 324);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(950, 238, 324);
        }
    }

    public int Priority { get; private set; }

    static TestPriorityAttribute()
    {
        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(950, 117, 376);
        DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(950, 117, 376);

        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(950, 117, 376);
    }

    int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(950, 117, 376);
}
