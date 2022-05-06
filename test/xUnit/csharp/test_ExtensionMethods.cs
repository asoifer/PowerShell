// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Parallel
{
    public static class PSTypeExtensionsTests
    {
        [Fact]
        public static void TestIsNumeric()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(954, 261, 407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(954, 336, 396);

                f_954_336_395(f_954_354_394(f_954_381_393(42)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(954, 261, 407);

                System.Type
                f_954_381_393(int
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(954, 381, 393);
                    return return_v;
                }


                bool
                f_954_354_394(System.Type
                type)
                {
                    var return_v = type.IsNumeric();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(954, 354, 394);
                    return return_v;
                }


                bool
                f_954_336_395(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(954, 336, 395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(954, 261, 407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(954, 261, 407);
            }
        }

        static PSTypeExtensionsTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(954, 203, 414);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(954, 203, 414);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(954, 203, 414);
        }

    }
}
