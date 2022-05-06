// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Parallel
{
    public static class PSVersionInfoTests
    {
        [Fact]
        public static void TestVersions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(961, 258, 506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(961, 439, 495);

                f_961_439_494(f_961_460_493());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(961, 258, 506);

                System.Management.Automation.PSVersionHashTable
                f_961_460_493()
                {
                    var return_v = PSVersionInfo.GetPSVersionTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(961, 460, 493);
                    return return_v;
                }


                bool
                f_961_439_494(System.Management.Automation.PSVersionHashTable
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(961, 439, 494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(961, 258, 506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(961, 258, 506);
            }
        }

        static PSVersionInfoTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(961, 203, 513);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(961, 203, 513);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(961, 203, 513);
        }

    }
}
