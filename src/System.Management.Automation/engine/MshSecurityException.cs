// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;

namespace System.Management.Automation
{
    [Serializable]
    public class PSSecurityException : RuntimeException
    {
        public PSSecurityException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1296, 568, 1006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4022, 4034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4379, 4387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 643, 846);

                _errorRecord = f_1296_658_845(f_1296_692_736(this), "UnauthorizedAccess", ErrorCategory.SecurityError, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 860, 936);

                _errorRecord.ErrorDetails = f_1296_888_935(f_1296_905_934());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 950, 995);

                _message = f_1296_961_994(f_1296_961_986(_errorRecord));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1296, 568, 1006);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1296, 568, 1006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1296, 568, 1006);
            }
        }

        protected PSSecurityException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1296_1444_1448_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1296, 1316, 1958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4022, 4034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4379, 4387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 1483, 1686);

                _errorRecord = f_1296_1498_1685(f_1296_1532_1576(this), "UnauthorizedAccess", ErrorCategory.SecurityError, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 1700, 1776);

                _errorRecord.ErrorDetails = f_1296_1728_1775(f_1296_1745_1774());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 1790, 1835);

                _message = f_1296_1801_1834(f_1296_1801_1826(_errorRecord));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1296, 1316, 1958);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1296, 1316, 1958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1296, 1316, 1958);
            }
        }

        public PSSecurityException(string message)
        : base(f_1296_2232_2239_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1296, 2169, 2580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4022, 4034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4379, 4387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 2265, 2284);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 2298, 2501);

                _errorRecord = f_1296_2313_2500(f_1296_2347_2391(this), "UnauthorizedAccess", ErrorCategory.SecurityError, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 2515, 2569);

                _errorRecord.ErrorDetails = f_1296_2543_2568(message);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1296, 2169, 2580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1296, 2169, 2580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1296, 2169, 2580);
            }
        }

        public PSSecurityException(string message,
                                        Exception innerException)
        : base(f_1296_2964_2971_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1296, 2842, 3354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4022, 4034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4379, 4387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 3013, 3216);

                _errorRecord = f_1296_3028_3215(f_1296_3062_3106(this), "UnauthorizedAccess", ErrorCategory.SecurityError, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 3230, 3284);

                _errorRecord.ErrorDetails = f_1296_3258_3283(message);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 3298, 3343);

                _message = f_1296_3309_3342(f_1296_3309_3334(_errorRecord));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1296, 2842, 3354);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1296, 2842, 3354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1296, 2842, 3354);
            }
        }

        public override ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1296, 3568, 3979);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 3604, 3924) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1296, 3604, 3924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 3670, 3905);

                        _errorRecord = f_1296_3685_3904(f_1296_3727_3771(this), "UnauthorizedAccess", ErrorCategory.SecurityError, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1296, 3604, 3924);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 3944, 3964);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1296, 3568, 3979);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1296_3727_3771(System.Management.Automation.PSSecurityException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 3727, 3771);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1296_3685_3904(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 3685, 3904);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1296, 3504, 3990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1296, 3504, 3990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        public override string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1296, 4317, 4341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1296, 4323, 4339);

                    return _message;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1296, 4317, 4341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1296, 4262, 4352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1296, 4262, 4352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _message;

        static PSSecurityException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1296, 291, 4395);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1296, 291, 4395);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1296, 291, 4395);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1296, 291, 4395);

        System.Management.Automation.ParentContainsErrorRecordException
        f_1296_692_736(System.Management.Automation.PSSecurityException
        wrapperException)
        {
            var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 692, 736);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1296_658_845(System.Management.Automation.ParentContainsErrorRecordException
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 658, 845);
            return return_v;
        }


        string
        f_1296_905_934()
        {
            var return_v = SessionStateStrings.CanNotRun;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 905, 934);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1296_888_935(string
        message)
        {
            var return_v = new System.Management.Automation.ErrorDetails(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 888, 935);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1296_961_986(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorDetails;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 961, 986);
            return return_v;
        }


        string
        f_1296_961_994(System.Management.Automation.ErrorDetails
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 961, 994);
            return return_v;
        }


        System.Management.Automation.ParentContainsErrorRecordException
        f_1296_1532_1576(System.Management.Automation.PSSecurityException
        wrapperException)
        {
            var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 1532, 1576);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1296_1498_1685(System.Management.Automation.ParentContainsErrorRecordException
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 1498, 1685);
            return return_v;
        }


        string
        f_1296_1745_1774()
        {
            var return_v = SessionStateStrings.CanNotRun;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 1745, 1774);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1296_1728_1775(string
        message)
        {
            var return_v = new System.Management.Automation.ErrorDetails(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 1728, 1775);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1296_1801_1826(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorDetails;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 1801, 1826);
            return return_v;
        }


        string
        f_1296_1801_1834(System.Management.Automation.ErrorDetails
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 1801, 1834);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1296_1444_1448_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1296, 1316, 1958);
            return return_v;
        }


        System.Management.Automation.ParentContainsErrorRecordException
        f_1296_2347_2391(System.Management.Automation.PSSecurityException
        wrapperException)
        {
            var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 2347, 2391);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1296_2313_2500(System.Management.Automation.ParentContainsErrorRecordException
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 2313, 2500);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1296_2543_2568(string
        message)
        {
            var return_v = new System.Management.Automation.ErrorDetails(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 2543, 2568);
            return return_v;
        }


        static string
        f_1296_2232_2239_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1296, 2169, 2580);
            return return_v;
        }


        System.Management.Automation.ParentContainsErrorRecordException
        f_1296_3062_3106(System.Management.Automation.PSSecurityException
        wrapperException)
        {
            var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 3062, 3106);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1296_3028_3215(System.Management.Automation.ParentContainsErrorRecordException
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 3028, 3215);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1296_3258_3283(string
        message)
        {
            var return_v = new System.Management.Automation.ErrorDetails(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1296, 3258, 3283);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1296_3309_3334(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorDetails;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 3309, 3334);
            return return_v;
        }


        string
        f_1296_3309_3342(System.Management.Automation.ErrorDetails
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1296, 3309, 3342);
            return return_v;
        }


        static string
        f_1296_2964_2971_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1296, 2842, 3354);
            return return_v;
        }

    }
}

