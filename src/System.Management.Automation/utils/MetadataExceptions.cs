// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Internal;
using System.Runtime.Serialization;

namespace System.Management.Automation
{
    [Serializable]
    public class MetadataException : RuntimeException
    {
        internal const string
        MetadataMemberInitialization = "MetadataMemberInitialization"
        ;

        internal const string
        BaseName = "Metadata"
        ;

        protected MetadataException(SerializationInfo info, StreamingContext context) : base(f_1017_963_967_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 878, 1059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 1002, 1048);

                f_1017_1002_1047(this, ErrorCategory.MetadataError);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 878, 1059);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 878, 1059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 878, 1059);
            }
        }

        public MetadataException() : base(f_1017_1286_1320_C(f_1017_1286_1320(typeof(MetadataException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 1252, 1403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 1346, 1392);

                f_1017_1346_1391(this, ErrorCategory.MetadataError);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 1252, 1403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 1252, 1403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 1252, 1403);
            }
        }

        public MetadataException(string message) : base(f_1017_1660_1667_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 1612, 1750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 1693, 1739);

                f_1017_1693_1738(this, ErrorCategory.MetadataError);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 1612, 1750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 1612, 1750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 1612, 1750);
            }
        }

        public MetadataException(string message, Exception innerException) : base(f_1017_2136_2143_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 2062, 2242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 2185, 2231);

                f_1017_2185_2230(this, ErrorCategory.MetadataError);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 2062, 2242);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 2062, 2242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 2062, 2242);
            }
        }

        internal MetadataException(string errorId, Exception innerException, string resourceStr, params object[] arguments) : base(f_1017_2390_2431_C(f_1017_2390_2431(resourceStr, arguments)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 2254, 2564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 2473, 2519);

                f_1017_2473_2518(this, ErrorCategory.MetadataError);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 2533, 2553);

                f_1017_2533_2552(this, errorId);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 2254, 2564);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 2254, 2564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 2254, 2564);
            }
        }

        static MetadataException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1017, 374, 2571);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 482, 543);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 576, 597);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1017, 374, 2571);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 374, 2571);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1017, 374, 2571);

        int
        f_1017_1002_1047(System.Management.Automation.MetadataException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1017, 1002, 1047);
            return 0;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1017_963_967_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 878, 1059);
            return return_v;
        }


        static string
        f_1017_1286_1320(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1017, 1286, 1320);
            return return_v;
        }


        int
        f_1017_1346_1391(System.Management.Automation.MetadataException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1017, 1346, 1391);
            return 0;
        }


        static string
        f_1017_1286_1320_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 1252, 1403);
            return return_v;
        }


        int
        f_1017_1693_1738(System.Management.Automation.MetadataException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1017, 1693, 1738);
            return 0;
        }


        static string
        f_1017_1660_1667_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 1612, 1750);
            return return_v;
        }


        int
        f_1017_2185_2230(System.Management.Automation.MetadataException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1017, 2185, 2230);
            return 0;
        }


        static string
        f_1017_2136_2143_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 2062, 2242);
            return return_v;
        }


        static string
        f_1017_2390_2431(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1017, 2390, 2431);
            return return_v;
        }


        int
        f_1017_2473_2518(System.Management.Automation.MetadataException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1017, 2473, 2518);
            return 0;
        }


        int
        f_1017_2533_2552(System.Management.Automation.MetadataException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1017, 2533, 2552);
            return 0;
        }


        static string
        f_1017_2390_2431_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 2254, 2564);
            return return_v;
        }

    }
    [Serializable]
    [SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly")]
    public class ValidationMetadataException : MetadataException
    {
        internal const string
        ValidateRangeElementType = "ValidateRangeElementType"
        ;

        internal const string
        ValidateRangePositiveFailure = "ValidateRangePositiveFailure"
        ;

        internal const string
        ValidateRangeNonNegativeFailure = "ValidateRangeNonNegativeFailure"
        ;

        internal const string
        ValidateRangeNegativeFailure = "ValidateRangeNegativeFailure"
        ;

        internal const string
        ValidateRangeNonPositiveFailure = "ValidateRangeNonPositiveFailure"
        ;

        internal const string
        ValidateRangeMinRangeMaxRangeType = "ValidateRangeMinRangeMaxRangeType"
        ;

        internal const string
        ValidateRangeNotIComparable = "ValidateRangeNotIComparable"
        ;

        internal const string
        ValidateRangeMaxRangeSmallerThanMinRange = "ValidateRangeMaxRangeSmallerThanMinRange"
        ;

        internal const string
        ValidateRangeGreaterThanMaxRangeFailure = "ValidateRangeGreaterThanMaxRangeFailure"
        ;

        internal const string
        ValidateRangeSmallerThanMinRangeFailure = "ValidateRangeSmallerThanMinRangeFailure"
        ;

        internal const string
        ValidateFailureResult = "ValidateFailureResult"
        ;

        internal const string
        ValidatePatternFailure = "ValidatePatternFailure"
        ;

        internal const string
        ValidateScriptFailure = "ValidateScriptFailure"
        ;

        internal const string
        ValidateCountNotInArray = "ValidateCountNotInArray"
        ;

        internal const string
        ValidateCountMaxLengthSmallerThanMinLength = "ValidateCountMaxLengthSmallerThanMinLength"
        ;

        internal const string
        ValidateCountMinLengthFailure = "ValidateCountMinLengthFailure"
        ;

        internal const string
        ValidateCountMaxLengthFailure = "ValidateCountMaxLengthFailure"
        ;

        internal const string
        ValidateLengthMaxLengthSmallerThanMinLength = "ValidateLengthMaxLengthSmallerThanMinLength"
        ;

        internal const string
        ValidateLengthNotString = "ValidateLengthNotString"
        ;

        internal const string
        ValidateLengthMinLengthFailure = "ValidateLengthMinLengthFailure"
        ;

        internal const string
        ValidateLengthMaxLengthFailure = "ValidateLengthMaxLengthFailure"
        ;

        internal const string
        ValidateSetFailure = "ValidateSetFailure"
        ;

        internal const string
        ValidateVersionFailure = "ValidateVersionFailure"
        ;

        internal const string
        InvalidValueFailure = "InvalidValueFailure"
        ;

        protected ValidationMetadataException(SerializationInfo info, StreamingContext context) : base(f_1017_5545_5549_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 5450, 5563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 7881, 7906);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 5450, 5563);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 5450, 5563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 5450, 5563);
            }
        }

        public ValidationMetadataException() : base(f_1017_5818_5862_C(f_1017_5818_5862(typeof(ValidationMetadataException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 5774, 5867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 7881, 7906);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 5774, 5867);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 5774, 5867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 5774, 5867);
            }
        }

        public ValidationMetadataException(string message) : this(f_1017_6142_6149_C(message), false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 6084, 6161);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 6084, 6161);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 6084, 6161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 6084, 6161);
            }
        }

        public ValidationMetadataException(string message, Exception innerException) : base(f_1017_6565_6572_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 6481, 6593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 7881, 7906);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 6481, 6593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 6481, 6593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 6481, 6593);
            }
        }

        internal ValidationMetadataException(string errorId, Exception innerException, string resourceStr, params object[] arguments) : base(f_1017_6751_6758_C(errorId), innerException, resourceStr, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 6605, 6821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 7881, 7906);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 6605, 6821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 6605, 6821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 6605, 6821);
            }
        }

        internal ValidationMetadataException(string message, bool swallowException) : base(f_1017_7400_7407_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 7317, 7481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 7881, 7906);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 7433, 7470);

                _swallowException = swallowException;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 7317, 7481);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 7317, 7481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 7317, 7481);
            }
        }

        internal bool SwallowException
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1017, 7812, 7845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 7818, 7843);

                    return _swallowException;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1017, 7812, 7845);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 7757, 7856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 7757, 7856);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _swallowException;

        static ValidationMetadataException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1017, 2685, 7914);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 2888, 2941);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 2974, 3035);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3068, 3135);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3168, 3229);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3262, 3329);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3362, 3433);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3466, 3525);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3558, 3643);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3676, 3759);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3792, 3875);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3910, 3957);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 3992, 4041);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4074, 4121);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4156, 4207);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4240, 4329);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4362, 4425);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4458, 4521);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4556, 4647);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4680, 4731);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4764, 4829);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4862, 4927);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 4960, 5001);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 5034, 5083);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 5116, 5159);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1017, 2685, 7914);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 2685, 7914);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1017, 2685, 7914);

        static System.Runtime.Serialization.SerializationInfo
        f_1017_5545_5549_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 5450, 5563);
            return return_v;
        }


        static string
        f_1017_5818_5862(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1017, 5818, 5862);
            return return_v;
        }


        static string
        f_1017_5818_5862_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 5774, 5867);
            return return_v;
        }


        static string
        f_1017_6142_6149_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 6084, 6161);
            return return_v;
        }


        static string
        f_1017_6565_6572_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 6481, 6593);
            return return_v;
        }


        static string
        f_1017_6751_6758_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 6605, 6821);
            return return_v;
        }


        static string
        f_1017_7400_7407_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 7317, 7481);
            return return_v;
        }

    }
    [Serializable]
    public class ArgumentTransformationMetadataException : MetadataException
    {
        internal const string
        ArgumentTransformationArgumentsShouldBeStrings = "ArgumentTransformationArgumentsShouldBeStrings"
        ;

        protected ArgumentTransformationMetadataException(SerializationInfo info, StreamingContext context) : base(f_1017_8680_8684_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 8573, 8698);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 8573, 8698);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 8573, 8698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 8573, 8698);
            }
        }

        public ArgumentTransformationMetadataException() : base(f_1017_8989_9045_C(f_1017_8989_9045(typeof(ArgumentTransformationMetadataException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 8933, 9050);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 8933, 9050);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 8933, 9050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 8933, 9050);
            }
        }

        public ArgumentTransformationMetadataException(string message) : base(f_1017_9349_9356_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 9279, 9361);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 9279, 9361);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 9279, 9361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 9279, 9361);
            }
        }

        public ArgumentTransformationMetadataException(string message, Exception innerException) : base(f_1017_9789_9796_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 9693, 9817);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 9693, 9817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 9693, 9817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 9693, 9817);
            }
        }

        internal ArgumentTransformationMetadataException(string errorId, Exception innerException, string resourceStr, params object[] arguments) : base(f_1017_9987_9994_C(errorId), innerException, resourceStr, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 9829, 10057);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 9829, 10057);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 9829, 10057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 9829, 10057);
            }
        }

        static ArgumentTransformationMetadataException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1017, 8042, 10064);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 8173, 8270);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1017, 8042, 10064);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 8042, 10064);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1017, 8042, 10064);

        static System.Runtime.Serialization.SerializationInfo
        f_1017_8680_8684_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 8573, 8698);
            return return_v;
        }


        static string
        f_1017_8989_9045(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1017, 8989, 9045);
            return return_v;
        }


        static string
        f_1017_8989_9045_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 8933, 9050);
            return return_v;
        }


        static string
        f_1017_9349_9356_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 9279, 9361);
            return return_v;
        }


        static string
        f_1017_9789_9796_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 9693, 9817);
            return return_v;
        }


        static string
        f_1017_9987_9994_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 9829, 10057);
            return return_v;
        }

    }
    [Serializable]
    public class ParsingMetadataException : MetadataException
    {
        internal const string
        ParsingTooManyParameterSets = "ParsingTooManyParameterSets"
        ;

        protected ParsingMetadataException(SerializationInfo info, StreamingContext context) : base(f_1017_10773_10777_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 10681, 10791);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 10681, 10791);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 10681, 10791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 10681, 10791);
            }
        }

        public ParsingMetadataException() : base(f_1017_11037_11078_C(f_1017_11037_11078(typeof(ParsingMetadataException))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 10996, 11083);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 10996, 11083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 10996, 11083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 10996, 11083);
            }
        }

        public ParsingMetadataException(string message) : base(f_1017_11352_11359_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 11297, 11364);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 11297, 11364);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 11297, 11364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 11297, 11364);
            }
        }

        public ParsingMetadataException(string message, Exception innerException) : base(f_1017_11762_11769_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 11681, 11790);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 11681, 11790);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 11681, 11790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 11681, 11790);
            }
        }

        internal ParsingMetadataException(string errorId, Exception innerException, string resourceStr, params object[] arguments) : base(f_1017_11945_11952_C(errorId), innerException, resourceStr, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1017, 11802, 12015);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1017, 11802, 12015);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1017, 11802, 12015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 11802, 12015);
            }
        }

        static ParsingMetadataException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1017, 10218, 12022);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1017, 10334, 10393);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1017, 10218, 12022);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1017, 10218, 12022);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1017, 10218, 12022);

        static System.Runtime.Serialization.SerializationInfo
        f_1017_10773_10777_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 10681, 10791);
            return return_v;
        }


        static string
        f_1017_11037_11078(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1017, 11037, 11078);
            return return_v;
        }


        static string
        f_1017_11037_11078_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 10996, 11083);
            return return_v;
        }


        static string
        f_1017_11352_11359_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 11297, 11364);
            return return_v;
        }


        static string
        f_1017_11762_11769_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 11681, 11790);
            return return_v;
        }


        static string
        f_1017_11945_11952_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1017, 11802, 12015);
            return return_v;
        }

    }
}

