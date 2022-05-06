// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation.Language;
using Xunit;

namespace PSTests.Parallel
{
    public static class PSEnumerableBinderTests
    {
        [Fact]
        public static void TestIsStaticTypePossiblyEnumerable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(952, 272, 511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(952, 416, 500);

                f_952_416_499(f_952_435_498(f_952_485_497(42)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(952, 272, 511);

                System.Type
                f_952_485_497(int
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(952, 485, 497);
                    return return_v;
                }


                bool
                f_952_435_498(System.Type
                type)
                {
                    var return_v = PSEnumerableBinder.IsStaticTypePossiblyEnumerable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(952, 435, 498);
                    return return_v;
                }


                bool
                f_952_416_499(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(952, 416, 499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(952, 272, 511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(952, 272, 511);
            }
        }

        static PSEnumerableBinderTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(952, 212, 518);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(952, 212, 518);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(952, 212, 518);
        }

    }
}
