// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class ExtendedTypeSystemException : RuntimeException
    {
        public ExtendedTypeSystemException() : base(f_1274_753_797_C(f_1274_753_797(typeof(ExtendedTypeSystemException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 709, 820);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 709, 820);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 709, 820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 709, 820);
            }
        }

        public ExtendedTypeSystemException(string message) : base(f_1274_1097_1104_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 1039, 1127);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 1039, 1127);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 1039, 1127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 1039, 1127);
            }
        }

        public ExtendedTypeSystemException(string message, Exception innerException) : base(f_1274_1533_1540_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 1449, 1579);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 1449, 1579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 1449, 1579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 1449, 1579);
            }
        }

        internal ExtendedTypeSystemException(string errorId, Exception innerException, string resourceString,
                    params object[] arguments) : base(f_1274_2182_2226_C(f_1274_2182_2226(resourceString, arguments)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 2020, 2299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 2268, 2288);

                f_1274_2268_2287(this, errorId);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 2020, 2299);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 2020, 2299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 2020, 2299);
            }
        }

        protected ExtendedTypeSystemException(SerializationInfo info, StreamingContext context)
        : base(f_1274_2732_2736_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 2620, 2768);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 2620, 2768);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 2620, 2768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 2620, 2768);
            }
        }

        static ExtendedTypeSystemException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 390, 2838);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 390, 2838);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 390, 2838);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 390, 2838);

        static string
        f_1274_753_797(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 753, 797);
            return return_v;
        }


        static string
        f_1274_753_797_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 709, 820);
            return return_v;
        }


        static string
        f_1274_1097_1104_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 1039, 1127);
            return return_v;
        }


        static string
        f_1274_1533_1540_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 1449, 1579);
            return return_v;
        }


        static string
        f_1274_2182_2226(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 2182, 2226);
            return return_v;
        }


        int
        f_1274_2268_2287(System.Management.Automation.ExtendedTypeSystemException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 2268, 2287);
            return 0;
        }


        static string
        f_1274_2182_2226_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 2020, 2299);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_2732_2736_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 2620, 2768);
            return return_v;
        }

    }
    [Serializable]
    public class MethodException : ExtendedTypeSystemException
    {
        internal const string
        MethodArgumentCountExceptionMsg = "MethodArgumentCountException"
        ;

        internal const string
        MethodAmbiguousExceptionMsg = "MethodAmbiguousException"
        ;

        internal const string
        MethodArgumentConversionExceptionMsg = "MethodArgumentConversionException"
        ;

        internal const string
        NonRefArgumentToRefParameterMsg = "NonRefArgumentToRefParameter"
        ;

        internal const string
        RefArgumentToNonRefParameterMsg = "RefArgumentToNonRefParameter"
        ;

        public MethodException() : base(f_1274_3765_3797_C(f_1274_3765_3797(typeof(MethodException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 3733, 3820);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 3733, 3820);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 3733, 3820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 3733, 3820);
            }
        }

        public MethodException(string message) : base(f_1274_4073_4080_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 4027, 4103);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 4027, 4103);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 4027, 4103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 4027, 4103);
            }
        }

        public MethodException(string message, Exception innerException) : base(f_1274_4485_4492_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 4413, 4531);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 4413, 4531);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 4413, 4531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 4413, 4531);
            }
        }

        internal MethodException(string errorId, Exception innerException,
                    string resourceString, params object[] arguments) : base(f_1274_5107_5114_C(errorId), innerException, resourceString, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 4957, 5180);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 4957, 5180);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 4957, 5180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 4957, 5180);
            }
        }

        protected MethodException(SerializationInfo info, StreamingContext context)
        : base(f_1274_5589_5593_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 5489, 5625);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 5489, 5625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 5489, 5625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 5489, 5625);
            }
        }

        static MethodException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 2950, 5695);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 3067, 3131);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 3164, 3220);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 3253, 3327);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 3360, 3424);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 3457, 3521);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 2950, 5695);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 2950, 5695);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 2950, 5695);

        static string
        f_1274_3765_3797(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 3765, 3797);
            return return_v;
        }


        static string
        f_1274_3765_3797_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 3733, 3820);
            return return_v;
        }


        static string
        f_1274_4073_4080_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 4027, 4103);
            return return_v;
        }


        static string
        f_1274_4485_4492_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 4413, 4531);
            return return_v;
        }


        static string
        f_1274_5107_5114_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 4957, 5180);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_5589_5593_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 5489, 5625);
            return return_v;
        }

    }
    [Serializable]
    public class MethodInvocationException : MethodException
    {
        internal const string
        MethodInvocationExceptionMsg = "MethodInvocationException"
        ;

        internal const string
        CopyToInvocationExceptionMsg = "CopyToInvocationException"
        ;

        internal const string
        WMIMethodInvocationException = "WMIMethodInvocationException"
        ;

        public MethodInvocationException() : base(f_1274_6446_6488_C(f_1274_6446_6488(typeof(MethodInvocationException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 6404, 6511);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 6404, 6511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 6404, 6511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 6404, 6511);
            }
        }

        public MethodInvocationException(string message) : base(f_1274_6784_6791_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 6728, 6814);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 6728, 6814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 6728, 6814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 6728, 6814);
            }
        }

        public MethodInvocationException(string message, Exception innerException) : base(f_1274_7216_7223_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 7134, 7262);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 7134, 7262);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 7134, 7262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 7134, 7262);
            }
        }

        internal MethodInvocationException(string errorId, Exception innerException,
                    string resourceString, params object[] arguments) : base(f_1274_7848_7855_C(errorId), innerException, resourceString, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 7688, 7921);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 7688, 7921);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 7688, 7921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 7688, 7921);
            }
        }

        protected MethodInvocationException(SerializationInfo info, StreamingContext context)
        : base(f_1274_8350_8354_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 8240, 8386);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 8240, 8386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 8240, 8386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 8240, 8386);
            }
        }

        static MethodInvocationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 5814, 8456);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 5929, 5987);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 6020, 6078);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 6111, 6172);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 5814, 8456);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 5814, 8456);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 5814, 8456);

        static string
        f_1274_6446_6488(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 6446, 6488);
            return return_v;
        }


        static string
        f_1274_6446_6488_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 6404, 6511);
            return return_v;
        }


        static string
        f_1274_6784_6791_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 6728, 6814);
            return return_v;
        }


        static string
        f_1274_7216_7223_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 7134, 7262);
            return return_v;
        }


        static string
        f_1274_7848_7855_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 7688, 7921);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_8350_8354_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 8240, 8386);
            return return_v;
        }

    }
    [Serializable]
    public class GetValueException : ExtendedTypeSystemException
    {
        internal const string
        GetWithoutGetterExceptionMsg = "GetWithoutGetterException"
        ;

        internal const string
        WriteOnlyProperty = "WriteOnlyProperty"
        ;

        public GetValueException() : base(f_1274_9082_9116_C(f_1274_9082_9116(typeof(GetValueException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 9048, 9139);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 9048, 9139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 9048, 9139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 9048, 9139);
            }
        }

        public GetValueException(string message) : base(f_1274_9396_9403_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 9348, 9426);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 9348, 9426);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 9348, 9426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 9348, 9426);
            }
        }

        public GetValueException(string message, Exception innerException) : base(f_1274_9812_9819_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 9738, 9858);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 9738, 9858);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 9738, 9858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 9738, 9858);
            }
        }

        internal GetValueException(string errorId, Exception innerException,
                    string resourceString, params object[] arguments) : base(f_1274_10436_10443_C(errorId), innerException, resourceString, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 10284, 10509);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 10284, 10509);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 10284, 10509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 10284, 10509);
            }
        }

        protected GetValueException(SerializationInfo info, StreamingContext context)
        : base(f_1274_10922_10926_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 10820, 10958);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 10820, 10958);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 10820, 10958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 10820, 10958);
            }
        }

        static GetValueException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 8585, 11028);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 8704, 8762);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 8795, 8834);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 8585, 11028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 8585, 11028);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 8585, 11028);

        static string
        f_1274_9082_9116(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 9082, 9116);
            return return_v;
        }


        static string
        f_1274_9082_9116_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 9048, 9139);
            return return_v;
        }


        static string
        f_1274_9396_9403_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 9348, 9426);
            return return_v;
        }


        static string
        f_1274_9812_9819_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 9738, 9858);
            return return_v;
        }


        static string
        f_1274_10436_10443_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 10284, 10509);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_10922_10926_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 10820, 10958);
            return return_v;
        }

    }
    [Serializable]
    public class PropertyNotFoundException : ExtendedTypeSystemException
    {
        public PropertyNotFoundException()
        : base(f_1274_11520_11562_C(f_1274_11520_11562(typeof(PropertyNotFoundException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 11465, 11585);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 11465, 11585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 11465, 11585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 11465, 11585);
            }
        }

        public PropertyNotFoundException(string message)
        : base(f_1274_11863_11870_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 11794, 11893);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 11794, 11893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 11794, 11893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 11794, 11893);
            }
        }

        public PropertyNotFoundException(string message, Exception innerException)
        : base(f_1274_12300_12307_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 12205, 12346);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 12205, 12346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 12205, 12346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 12205, 12346);
            }
        }

        internal PropertyNotFoundException(string errorId, Exception innerException,
                    string resourceString, params object[] arguments) : base(f_1274_12932_12939_C(errorId), innerException, resourceString, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 12772, 13005);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 12772, 13005);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 12772, 13005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 12772, 13005);
            }
        }

        protected PropertyNotFoundException(SerializationInfo info, StreamingContext context)
        : base(f_1274_13422_13426_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 13316, 13458);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 13316, 13458);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 13316, 13458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 13316, 13458);
            }
        }

        static PropertyNotFoundException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 11157, 13528);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 11157, 13528);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 11157, 13528);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 11157, 13528);

        static string
        f_1274_11520_11562(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 11520, 11562);
            return return_v;
        }


        static string
        f_1274_11520_11562_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 11465, 11585);
            return return_v;
        }


        static string
        f_1274_11863_11870_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 11794, 11893);
            return return_v;
        }


        static string
        f_1274_12300_12307_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 12205, 12346);
            return return_v;
        }


        static string
        f_1274_12932_12939_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 12772, 13005);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_13422_13426_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 13316, 13458);
            return return_v;
        }

    }
    [Serializable]
    public class GetValueInvocationException : GetValueException
    {
        internal const string
        ExceptionWhenGettingMsg = "ExceptionWhenGetting"
        ;

        public GetValueInvocationException() : base(f_1274_14103_14147_C(f_1274_14103_14147(typeof(GetValueInvocationException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 14059, 14170);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 14059, 14170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 14059, 14170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 14059, 14170);
            }
        }

        public GetValueInvocationException(string message) : base(f_1274_14447_14454_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 14389, 14477);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 14389, 14477);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 14389, 14477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 14389, 14477);
            }
        }

        public GetValueInvocationException(string message, Exception innerException) : base(f_1274_14883_14890_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 14799, 14929);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 14799, 14929);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 14799, 14929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 14799, 14929);
            }
        }

        internal GetValueInvocationException(string errorId, Exception innerException,
                    string resourceString, params object[] arguments) : base(f_1274_15517_15524_C(errorId), innerException, resourceString, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 15355, 15590);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 15355, 15590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 15355, 15590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 15355, 15590);
            }
        }

        protected GetValueInvocationException(SerializationInfo info, StreamingContext context)
        : base(f_1274_16023_16027_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 15911, 16059);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 15911, 16059);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 15911, 16059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 15911, 16059);
            }
        }

        static GetValueInvocationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 13656, 16129);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 13775, 13823);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 13656, 16129);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 13656, 16129);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 13656, 16129);

        static string
        f_1274_14103_14147(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 14103, 14147);
            return return_v;
        }


        static string
        f_1274_14103_14147_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 14059, 14170);
            return return_v;
        }


        static string
        f_1274_14447_14454_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 14389, 14477);
            return return_v;
        }


        static string
        f_1274_14883_14890_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 14799, 14929);
            return return_v;
        }


        static string
        f_1274_15517_15524_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 15355, 15590);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_16023_16027_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 15911, 16059);
            return return_v;
        }

    }
    [Serializable]
    public class SetValueException : ExtendedTypeSystemException
    {
        public SetValueException() : base(f_1274_16592_16626_C(f_1274_16592_16626(typeof(SetValueException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 16558, 16649);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 16558, 16649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 16558, 16649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 16558, 16649);
            }
        }

        public SetValueException(string message) : base(f_1274_16906_16913_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 16858, 16936);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 16858, 16936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 16858, 16936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 16858, 16936);
            }
        }

        public SetValueException(string message, Exception innerException) : base(f_1274_17322_17329_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 17248, 17368);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 17248, 17368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 17248, 17368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 17248, 17368);
            }
        }

        internal SetValueException(string errorId, Exception innerException,
                    string resourceString, params object[] arguments) : base(f_1274_17946_17953_C(errorId), innerException, resourceString, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 17794, 18019);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 17794, 18019);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 17794, 18019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 17794, 18019);
            }
        }

        protected SetValueException(SerializationInfo info, StreamingContext context)
        : base(f_1274_18432_18436_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 18330, 18468);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 18330, 18468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 18330, 18468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 18330, 18468);
            }
        }

        static SetValueException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 16258, 18538);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 16258, 18538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 16258, 18538);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 16258, 18538);

        static string
        f_1274_16592_16626(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 16592, 16626);
            return return_v;
        }


        static string
        f_1274_16592_16626_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 16558, 16649);
            return return_v;
        }


        static string
        f_1274_16906_16913_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 16858, 16936);
            return return_v;
        }


        static string
        f_1274_17322_17329_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 17248, 17368);
            return return_v;
        }


        static string
        f_1274_17946_17953_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 17794, 18019);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_18432_18436_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 18330, 18468);
            return return_v;
        }

    }
    [Serializable]
    public class SetValueInvocationException : SetValueException
    {
        public SetValueInvocationException() : base(f_1274_19030_19074_C(f_1274_19030_19074(typeof(SetValueInvocationException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 18986, 19097);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 18986, 19097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 18986, 19097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 18986, 19097);
            }
        }

        public SetValueInvocationException(string message) : base(f_1274_19374_19381_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 19316, 19404);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 19316, 19404);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 19316, 19404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 19316, 19404);
            }
        }

        public SetValueInvocationException(string message, Exception innerException) : base(f_1274_19810_19817_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 19726, 19856);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 19726, 19856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 19726, 19856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 19726, 19856);
            }
        }

        internal SetValueInvocationException(string errorId, Exception innerException,
                    string resourceString, params object[] arguments) : base(f_1274_20444_20451_C(errorId), innerException, resourceString, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 20282, 20517);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 20282, 20517);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 20282, 20517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 20282, 20517);
            }
        }

        protected SetValueInvocationException(SerializationInfo info, StreamingContext context)
        : base(f_1274_20950_20954_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 20838, 20986);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 20838, 20986);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 20838, 20986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 20838, 20986);
            }
        }

        static SetValueInvocationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 18666, 21056);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 18666, 21056);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 18666, 21056);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 18666, 21056);

        static string
        f_1274_19030_19074(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 19030, 19074);
            return return_v;
        }


        static string
        f_1274_19030_19074_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 18986, 19097);
            return return_v;
        }


        static string
        f_1274_19374_19381_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 19316, 19404);
            return return_v;
        }


        static string
        f_1274_19810_19817_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 19726, 19856);
            return return_v;
        }


        static string
        f_1274_20444_20451_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 20282, 20517);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_20950_20954_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 20838, 20986);
            return return_v;
        }

    }
    [Serializable]
    public class PSInvalidCastException : InvalidCastException, IContainsErrorRecord
    {
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1274, 21745, 22164);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 21947, 22054) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1274, 21947, 22054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 21997, 22039);

                    throw f_1274_22003_22038("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1274, 21947, 22054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 22070, 22104);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1274, 22070, 22103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 22118, 22153);

                f_1274_22118_22152(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1274, 21745, 22164);

                System.Management.Automation.PSArgumentNullException
                f_1274_22003_22038(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 22003, 22038);
                    return return_v;
                }


                int
                f_1274_22118_22152(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 22118, 22152);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 21745, 22164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 21745, 22164);
            }
        }

        protected PSInvalidCastException(SerializationInfo info, StreamingContext context) : base(f_1274_22537_22541_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 22447, 22624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24772, 24784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24810, 24845);
                this._errorId = "PSInvalidCastException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 22576, 22613);

                _errorId = f_1274_22587_22612(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 22447, 22624);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 22447, 22624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 22447, 22624);
            }
        }

        public PSInvalidCastException() : base(f_1274_22902_22941_C(f_1274_22902_22941(typeof(PSInvalidCastException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 22863, 22964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24772, 24784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24810, 24845);
                this._errorId = "PSInvalidCastException";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 22863, 22964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 22863, 22964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 22863, 22964);
            }
        }

        public PSInvalidCastException(string message) : base(f_1274_23229_23236_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 23176, 23259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24772, 24784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24810, 24845);
                this._errorId = "PSInvalidCastException";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 23176, 23259);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 23176, 23259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 23176, 23259);
            }
        }

        public PSInvalidCastException(string message, Exception innerException) : base(f_1274_23653_23660_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 23574, 23699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24772, 24784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24810, 24845);
                this._errorId = "PSInvalidCastException";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 23574, 23699);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 23574, 23699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 23574, 23699);
            }
        }

        internal PSInvalidCastException(string errorId, string message, Exception innerException)
        : base(f_1274_23821_23828_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 23711, 23900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24772, 24784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24810, 24845);
                this._errorId = "PSInvalidCastException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 23870, 23889);

                _errorId = errorId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 23711, 23900);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 23711, 23900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 23711, 23900);
            }
        }

        internal PSInvalidCastException(string errorId, Exception innerException, string resourceString, params object[] arguments)
        : this(f_1274_24056_24063_C(errorId), f_1274_24065_24109(resourceString, arguments), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1274, 23912, 24148);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1274, 23912, 24148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 23912, 24148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 23912, 24148);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1274, 24328, 24729);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24364, 24674) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1274, 24364, 24674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24430, 24655);

                        _errorRecord = f_1274_24445_24654(f_1274_24487_24531(this), _errorId, ErrorCategory.InvalidArgument, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1274, 24364, 24674);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1274, 24694, 24714);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1274, 24328, 24729);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1274_24487_24531(System.Management.Automation.PSInvalidCastException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 24487, 24531);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1274_24445_24654(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 24445, 24654);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1274, 24273, 24740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 24273, 24740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        static PSInvalidCastException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1274, 21169, 24853);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1274, 21169, 24853);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1274, 21169, 24853);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1274, 21169, 24853);

        string?
        f_1274_22587_22612(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 22587, 22612);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1274_22537_22541_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 22447, 22624);
            return return_v;
        }


        static string
        f_1274_22902_22941(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1274, 22902, 22941);
            return return_v;
        }


        static string
        f_1274_22902_22941_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 22863, 22964);
            return return_v;
        }


        static string
        f_1274_23229_23236_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 23176, 23259);
            return return_v;
        }


        static string
        f_1274_23653_23660_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 23574, 23699);
            return return_v;
        }


        static string
        f_1274_23821_23828_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 23711, 23900);
            return return_v;
        }


        static string
        f_1274_24065_24109(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1274, 24065, 24109);
            return return_v;
        }


        static string
        f_1274_24056_24063_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1274, 23912, 24148);
            return return_v;
        }

    }
}

