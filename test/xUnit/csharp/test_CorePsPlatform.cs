// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using Xunit;

namespace PSTests.Parallel
{
    public static class PlatformTests
    {
        [Fact]
        public static void TestIsCoreCLR()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(953, 298, 422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(953, 373, 411);

                f_953_373_410(f_953_391_409());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(953, 298, 422);

                bool
                f_953_391_409()
                {
                    var return_v = Platform.IsCoreCLR;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(953, 391, 409);
                    return return_v;
                }


                bool
                f_953_373_410(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(953, 373, 410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(953, 298, 422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(953, 298, 422);
            }
        }

        static PlatformTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(953, 248, 7619);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(953, 248, 7619);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(953, 248, 7619);
        }

    }
}
