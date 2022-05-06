// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;

namespace System.Management.Automation
{
    [Serializable]
    public class ApplicationFailedException : RuntimeException
    {
        private const string
        errorIdString = "NativeCommandFailed"
        ;

        protected ApplicationFailedException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1005_1172_1176_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1005, 1033, 1208);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1005, 1033, 1208);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1005, 1033, 1208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1005, 1033, 1208);
            }
        }

        public ApplicationFailedException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1005, 1434, 1616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 1503, 1534);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1005, 1503, 1533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 1548, 1605);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ResourceUnavailable), 1005, 1548, 1604);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1005, 1434, 1616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1005, 1434, 1616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1005, 1434, 1616);
            }
        }

        public ApplicationFailedException(string message) : base(f_1005_1994_2001_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1005, 1937, 2140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 2027, 2058);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1005, 2027, 2057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 2072, 2129);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ResourceUnavailable), 1005, 2072, 2128);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1005, 1937, 2140);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1005, 1937, 2140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1005, 1937, 2140);
            }
        }

        internal ApplicationFailedException(string message, string errorId) : base(f_1005_2654_2661_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1005, 2579, 2794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 2687, 2712);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorId), 1005, 2687, 2711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 2726, 2783);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ResourceUnavailable), 1005, 2726, 2782);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1005, 2579, 2794);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1005, 2579, 2794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1005, 2579, 2794);
            }
        }

        internal ApplicationFailedException(string message, string errorId, Exception innerException)
        : base(f_1005_3473_3480_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1005, 3359, 3629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 3522, 3547);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorId), 1005, 3522, 3546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 3561, 3618);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ResourceUnavailable), 1005, 3561, 3617);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1005, 3359, 3629);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1005, 3359, 3629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1005, 3359, 3629);
            }
        }

        public ApplicationFailedException(string message,
                                Exception innerException)
        : base(f_1005_4216_4223_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1005, 4091, 4378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 4265, 4296);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(errorIdString), 1005, 4265, 4295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 4310, 4367);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(ErrorCategory.ResourceUnavailable), 1005, 4310, 4366);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1005, 4091, 4378);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1005, 4091, 4378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1005, 4091, 4378);
            }
        }

        static ApplicationFailedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1005, 298, 4410);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1005, 439, 476);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1005, 298, 4410);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1005, 298, 4410);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1005, 298, 4410);

        static System.Runtime.Serialization.SerializationInfo
        f_1005_1172_1176_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1005, 1033, 1208);
            return return_v;
        }


        static string
        f_1005_1994_2001_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1005, 1937, 2140);
            return return_v;
        }


        static string
        f_1005_2654_2661_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1005, 2579, 2794);
            return return_v;
        }


        static string
        f_1005_3473_3480_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1005, 3359, 3629);
            return return_v;
        }


        static string
        f_1005_4216_4223_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1005, 4091, 4378);
            return return_v;
        }

    }
}
