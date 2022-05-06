// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Parallel
{
    public static class SecuritySupportTests
    {
        [Fact]
        public static void TestScanContent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(963, 260, 629);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(963, 373, 509);

                    f_963_373_508(AmsiUtils.AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED, f_963_458_507(string.Empty, string.Empty));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(963, 538, 618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(963, 578, 603);

                    f_963_578_602();
                    DynAbs.Tracing.TraceSender.TraceExitFinally(963, 538, 618);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(963, 260, 629);

                System.Management.Automation.AmsiUtils.AmsiNativeMethods.AMSI_RESULT
                f_963_458_507(string
                content, string
                sourceMetadata)
                {
                    var return_v = AmsiUtils.ScanContent(content, sourceMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(963, 458, 507);
                    return return_v;
                }


                bool
                f_963_373_508(System.Management.Automation.AmsiUtils.AmsiNativeMethods.AMSI_RESULT
                expected, System.Management.Automation.AmsiUtils.AmsiNativeMethods.AMSI_RESULT
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(963, 373, 508);
                    return return_v;
                }


                int
                f_963_578_602()
                {
                    AmsiUtils.Uninitialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(963, 578, 602);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(963, 260, 629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(963, 260, 629);
            }
        }

        static SecuritySupportTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(963, 203, 636);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(963, 203, 636);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(963, 203, 636);
        }

    }
}
