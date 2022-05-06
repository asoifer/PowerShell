// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class ProviderInvocationException : RuntimeException
    {
        public ProviderInvocationException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 811, 878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8501, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9161, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11649, 11657);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 811, 878);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 811, 878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 811, 878);
            }
        }

        protected ProviderInvocationException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1041_1332_1336_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 1197, 1368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8501, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9161, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11649, 11657);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 1197, 1368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 1197, 1368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 1197, 1368);
            }
        }

        public ProviderInvocationException(string message)
        : base(f_1041_1670_1677_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 1599, 1733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8501, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9161, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11649, 11657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 1703, 1722);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 1599, 1733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 1599, 1733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 1599, 1733);
            }
        }

        internal ProviderInvocationException(ProviderInfo provider, Exception innerException)
        : base(f_1041_2261_2309_C(f_1041_2261_2309(innerException)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 2155, 2943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8501, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9161, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11649, 11657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 2351, 2375);

                _message = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message, 1041, 2362, 2374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 2389, 2414);

                _providerInfo = provider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 2430, 2497);

                IContainsErrorRecord
                icer = innerException as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 2511, 2932) || true) && (icer != null && (DynAbs.Tracing.TraceSender.Expression_True(1041, 2515, 2555) && f_1041_2531_2547(icer) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 2511, 2932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 2589, 2654);

                    _errorRecord = f_1041_2604_2653(f_1041_2620_2636(icer), innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 2511, 2932);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 2511, 2932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 2720, 2917);

                    _errorRecord = f_1041_2735_2916(innerException, "ErrorRecordNotSpecified", ErrorCategory.InvalidOperation, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 2511, 2932);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 2155, 2943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 2155, 2943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 2155, 2943);
            }
        }

        internal ProviderInvocationException(ProviderInfo provider, ErrorRecord errorRecord)
        : base(f_1041_3463_3508_C(f_1041_3463_3508(errorRecord)), f_1041_3531_3578(errorRecord))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 3358, 3854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8501, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9161, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11649, 11657);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 3604, 3723) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 3604, 3723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 3661, 3708);

                    throw f_1041_3667_3707("errorRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 3604, 3723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 3739, 3763);

                _message = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message, 1041, 3750, 3762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 3777, 3802);

                _providerInfo = provider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 3816, 3843);

                _errorRecord = errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 3358, 3854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 3358, 3854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 3358, 3854);
            }
        }

        public ProviderInvocationException(string message, Exception innerException)
        : base(f_1041_4333_4340_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 4236, 4412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8501, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9161, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11649, 11657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 4382, 4401);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 4236, 4412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 4236, 4412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 4236, 4412);
            }
        }

        internal ProviderInvocationException(
                    string errorId,
                    string resourceStr,
                    ProviderInfo provider,
                    string path,
                    Exception innerException)
        : this(f_1041_5564_5571_C(errorId), resourceStr, provider, path, innerException, true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 5343, 5645);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 5343, 5645);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 5343, 5645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 5343, 5645);
            }
        }

        internal ProviderInvocationException(
                    string errorId,
                    string resourceStr,
                    ProviderInfo provider,
                    string path,
                    Exception innerException,
                    bool useInnerExceptionMessage)
        : base(
        f_1041_7139_7208_C(f_1041_7139_7208(errorId, resourceStr, provider, path, innerException)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 6856, 8172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8501, 8514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9161, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11649, 11657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7267, 7292);

                _providerInfo = provider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7308, 7332);

                _message = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message, 1041, 7319, 7331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7348, 7386);

                Exception
                errorRecordException = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7400, 7649) || true) && (useInnerExceptionMessage)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 7400, 7649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7462, 7500);

                    errorRecordException = innerException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 7400, 7649);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 7400, 7649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7566, 7634);

                    errorRecordException = f_1041_7589_7633(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 7400, 7649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7665, 7732);

                IContainsErrorRecord
                icer = innerException as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7746, 8161) || true) && (icer != null && (DynAbs.Tracing.TraceSender.Expression_True(1041, 7750, 7790) && f_1041_7766_7782(icer) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 7746, 8161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7824, 7895);

                    _errorRecord = f_1041_7839_7894(f_1041_7855_7871(icer), errorRecordException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 7746, 8161);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 7746, 8161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 7961, 8146);

                    _errorRecord = f_1041_7976_8145(errorRecordException, errorId, ErrorCategory.InvalidOperation, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 7746, 8161);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 6856, 8172);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 6856, 8172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 6856, 8172);
            }
        }

        public ProviderInfo ProviderInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 8411, 8440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8417, 8438);

                    return _providerInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 8411, 8440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 8376, 8442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 8376, 8442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [NonSerialized]
        internal ProviderInfo _providerInfo;

        public override ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 8674, 9093);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8710, 9038) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 8710, 9038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 8776, 9019);

                        _errorRecord = f_1041_8791_9018(f_1041_8833_8877(this), "ProviderInvocationException", ErrorCategory.NotSpecified, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 8710, 9038);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9058, 9078);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 8674, 9093);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1041_8833_8877(System.Management.Automation.ProviderInvocationException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 8833, 8877);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1041_8791_9018(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 8791, 9018);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 8610, 9104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 8610, 9104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [NonSerialized]
        private ErrorRecord _errorRecord;

        private static string RetrieveMessage(
                    string errorId,
                    string resourceStr,
                    ProviderInfo provider,
                    string path,
                    Exception innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1041, 9251, 11357);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9477, 9701) || true) && (innerException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 9477, 9701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9537, 9648);

                    f_1041_9537_9647(false, "ProviderInvocationException.RetrieveMessage needs innerException");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9666, 9686);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 9477, 9701);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9717, 9977) || true) && (f_1041_9721_9750(errorId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 9717, 9977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9784, 9888);

                    f_1041_9784_9887(false, "ProviderInvocationException.RetrieveMessage needs errorId");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9906, 9962);

                    return f_1041_9913_9961(innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 9717, 9977);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 9993, 10241) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 9993, 10241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10047, 10152);

                    f_1041_10047_10151(false, "ProviderInvocationException.RetrieveMessage needs provider");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10170, 10226);

                    return f_1041_10177_10225(innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 9993, 10241);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10257, 10285);

                string
                format = resourceStr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10299, 10567) || true) && (f_1041_10303_10331(format))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 10299, 10567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10365, 10478);

                    f_1041_10365_10477(false, "ProviderInvocationException.RetrieveMessage bad errorId " + errorId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10496, 10552);

                    return f_1041_10503_10551(innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 10299, 10567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10583, 10604);

                string
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10620, 11316) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 10620, 11316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 10670, 10937);

                    result =
                    f_1041_10700_10936(f_1041_10740_10787(), format, f_1041_10847_10860(provider), f_1041_10887_10935(innerException));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 10620, 11316);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 10620, 11316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11003, 11301);

                    result =
                    f_1041_11033_11300(f_1041_11073_11120(), format, f_1041_11180_11193(provider), path, f_1041_11251_11299(innerException));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 10620, 11316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11332, 11346);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1041, 9251, 11357);

                int
                f_1041_9537_9647(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 9537, 9647);
                    return 0;
                }


                bool
                f_1041_9721_9750(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 9721, 9750);
                    return return_v;
                }


                int
                f_1041_9784_9887(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 9784, 9887);
                    return 0;
                }


                string
                f_1041_9913_9961(System.Exception
                e)
                {
                    var return_v = RuntimeException.RetrieveMessage(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 9913, 9961);
                    return return_v;
                }


                int
                f_1041_10047_10151(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 10047, 10151);
                    return 0;
                }


                string
                f_1041_10177_10225(System.Exception
                e)
                {
                    var return_v = RuntimeException.RetrieveMessage(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 10177, 10225);
                    return return_v;
                }


                bool
                f_1041_10303_10331(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 10303, 10331);
                    return return_v;
                }


                int
                f_1041_10365_10477(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 10365, 10477);
                    return 0;
                }


                string
                f_1041_10503_10551(System.Exception
                e)
                {
                    var return_v = RuntimeException.RetrieveMessage(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 10503, 10551);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1041_10740_10787()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 10740, 10787);
                    return return_v;
                }


                string
                f_1041_10847_10860(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 10847, 10860);
                    return return_v;
                }


                string
                f_1041_10887_10935(System.Exception
                e)
                {
                    var return_v = RuntimeException.RetrieveMessage(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 10887, 10935);
                    return return_v;
                }


                string
                f_1041_10700_10936(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 10700, 10936);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1041_11073_11120()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 11073, 11120);
                    return return_v;
                }


                string
                f_1041_11180_11193(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 11180, 11193);
                    return return_v;
                }


                string
                f_1041_11251_11299(System.Exception
                e)
                {
                    var return_v = RuntimeException.RetrieveMessage(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 11251, 11299);
                    return return_v;
                }


                string
                f_1041_11033_11300(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 11033, 11300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 9251, 11357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 9251, 11357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 11512, 11586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 11518, 11584);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1041, 11525, 11557) || (((f_1041_11526_11556(_message)) && DynAbs.Tracing.TraceSender.Conditional_F2(1041, 11560, 11572)) || DynAbs.Tracing.TraceSender.Conditional_F3(1041, 11575, 11583))) ? DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message, 1041, 11560, 11572) : _message;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 11512, 11586);

                    bool
                    f_1041_11526_11556(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 11526, 11556);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 11457, 11597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 11457, 11597);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [NonSerialized]
        private string _message /* = null */;

        static ProviderInvocationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1041, 583, 11717);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1041, 583, 11717);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 583, 11717);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1041, 583, 11717);

        static System.Runtime.Serialization.SerializationInfo
        f_1041_1332_1336_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 1197, 1368);
            return return_v;
        }


        static string
        f_1041_1670_1677_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 1599, 1733);
            return return_v;
        }


        static string
        f_1041_2261_2309(System.Exception
        e)
        {
            var return_v = RuntimeException.RetrieveMessage(e);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 2261, 2309);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_2531_2547(System.Management.Automation.IContainsErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 2531, 2547);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_2620_2636(System.Management.Automation.IContainsErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 2620, 2636);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_2604_2653(System.Management.Automation.ErrorRecord
        errorRecord, System.Exception
        replaceParentContainsErrorRecordException)
        {
            var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 2604, 2653);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_2735_2916(System.Exception
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 2735, 2916);
            return return_v;
        }


        static string
        f_1041_2261_2309_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 2155, 2943);
            return return_v;
        }


        static string
        f_1041_3463_3508(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = RuntimeException.RetrieveMessage(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 3463, 3508);
            return return_v;
        }


        static System.Exception
        f_1041_3531_3578(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = RuntimeException.RetrieveException(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 3531, 3578);
            return return_v;
        }


        System.ArgumentNullException
        f_1041_3667_3707(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 3667, 3707);
            return return_v;
        }


        static string
        f_1041_3463_3508_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 3358, 3854);
            return return_v;
        }


        static string
        f_1041_4333_4340_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 4236, 4412);
            return return_v;
        }


        static string
        f_1041_5564_5571_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 5343, 5645);
            return return_v;
        }


        static string
        f_1041_7139_7208(string
        errorId, string
        resourceStr, System.Management.Automation.ProviderInfo
        provider, string
        path, System.Exception
        innerException)
        {
            var return_v = RetrieveMessage(errorId, resourceStr, provider, path, innerException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 7139, 7208);
            return return_v;
        }


        System.Management.Automation.ParentContainsErrorRecordException
        f_1041_7589_7633(System.Management.Automation.ProviderInvocationException
        wrapperException)
        {
            var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 7589, 7633);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_7766_7782(System.Management.Automation.IContainsErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 7766, 7782);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_7855_7871(System.Management.Automation.IContainsErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 7855, 7871);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_7839_7894(System.Management.Automation.ErrorRecord
        errorRecord, System.Exception
        replaceParentContainsErrorRecordException)
        {
            var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 7839, 7894);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1041_7976_8145(System.Exception
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 7976, 8145);
            return return_v;
        }


        static string
        f_1041_7139_7208_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 6856, 8172);
            return return_v;
        }

    }

    /// <summary>
    /// Categories of session state objects, used by SessionStateException.
    /// </summary>
    public enum SessionStateCategory
    {
        /// <summary>
        /// Used when an exception is thrown accessing a variable.
        /// </summary>
        Variable = 0,

        /// <summary>
        /// Used when an exception is thrown accessing an alias.
        /// </summary>
        Alias = 1,

        /// <summary>
        /// Used when an exception is thrown accessing a function.
        /// </summary>
        Function = 2,

        /// <summary>
        /// Used when an exception is thrown accessing a filter.
        /// </summary>
        Filter = 3,

        /// <summary>
        /// Used when an exception is thrown accessing a drive.
        /// </summary>
        Drive = 4,

        /// <summary>
        /// Used when an exception is thrown accessing a Cmdlet Provider.
        /// </summary>
        CmdletProvider = 5,

        /// <summary>
        /// Used when an exception is thrown manipulating the PowerShell language scopes.
        /// </summary>
        Scope = 6,

        /// <summary>
        /// Used when generically accessing any type of command...
        /// </summary>
        Command = 7,

        /// <summary>
        /// Other resources not covered by the previous categories...
        /// </summary>
        Resource = 8,

        /// <summary>
        /// Used when an exception is thrown accessing a cmdlet.
        /// </summary>
        Cmdlet = 9,
    }
    [Serializable]
    public class SessionStateException : RuntimeException
    {
        internal SessionStateException(
                    string itemName,
                    SessionStateCategory sessionStateCategory,
                    string errorIdAndResourceId,
                    string resourceStr,
                    ErrorCategory errorCategory,
                    params object[] messageArgs)
        : base(f_1041_14827_14875_C(f_1041_14827_14875(itemName, resourceStr, messageArgs)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 14530, 15083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18142, 18154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18398, 18422);
                this._itemName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18722, 18775);
                this._sessionStateCategory = SessionStateCategory.Variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18859, 18893);
                this._errorId = "SessionStateException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18926, 18972);
                this._errorCategory = ErrorCategory.InvalidArgument;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 14901, 14922);

                _itemName = itemName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 14936, 14981);

                _sessionStateCategory = sessionStateCategory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 14995, 15027);

                _errorId = errorIdAndResourceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 15041, 15072);

                _errorCategory = errorCategory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 14530, 15083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 14530, 15083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 14530, 15083);
            }
        }

        public SessionStateException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 15191, 15265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18142, 18154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18398, 18422);
                this._itemName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18722, 18775);
                this._sessionStateCategory = SessionStateCategory.Variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18859, 18893);
                this._errorId = "SessionStateException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18926, 18972);
                this._errorCategory = ErrorCategory.InvalidArgument;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 15191, 15265);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 15191, 15265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 15191, 15265);
            }
        }

        public SessionStateException(string message)
        : base(f_1041_15544_15551_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 15479, 15574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18142, 18154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18398, 18422);
                this._itemName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18722, 18775);
                this._sessionStateCategory = SessionStateCategory.Variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18859, 18893);
                this._errorId = "SessionStateException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18926, 18972);
                this._errorCategory = ErrorCategory.InvalidArgument;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 15479, 15574);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 15479, 15574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 15479, 15574);
            }
        }

        public SessionStateException(string message,
                                             Exception innerException)
        : base(f_1041_16036_16043_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 15903, 16082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18142, 18154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18398, 18422);
                this._itemName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18722, 18775);
                this._sessionStateCategory = SessionStateCategory.Variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18859, 18893);
                this._errorId = "SessionStateException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18926, 18972);
                this._errorCategory = ErrorCategory.InvalidArgument;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 15903, 16082);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 15903, 16082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 15903, 16082);
            }
        }

        protected SessionStateException(SerializationInfo info,
                                                StreamingContext context)
        : base(f_1041_16540_16544_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 16397, 16696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18142, 18154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18398, 18422);
                this._itemName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18722, 18775);
                this._sessionStateCategory = SessionStateCategory.Variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18859, 18893);
                this._errorId = "SessionStateException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18926, 18972);
                this._errorCategory = ErrorCategory.InvalidArgument;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 16579, 16663);

                _sessionStateCategory = (SessionStateCategory)f_1041_16625_16662(info, "SessionStateCategory");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 16397, 16696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 16397, 16696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 16397, 16696);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 16928, 17456);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 17130, 17237) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 17130, 17237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 17180, 17222);

                    throw f_1041_17186_17221("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 17130, 17237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 17253, 17287);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1041, 17253, 17286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 17379, 17445);

                f_1041_17379_17444(            // If there are simple fields, serialize them with info.AddValue
                            info, "SessionStateCategory", _sessionStateCategory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 16928, 17456);

                System.Management.Automation.PSArgumentNullException
                f_1041_17186_17221(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 17186, 17221);
                    return return_v;
                }


                int
                f_1041_17379_17444(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Management.Automation.SessionStateCategory
                value)
                {
                    this_param.AddValue(name, (int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 17379, 17444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 16928, 17456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 16928, 17456);
            }
        }

        public override ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 17708, 18099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 17744, 18044) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 17744, 18044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 17810, 18025);

                        _errorRecord = f_1041_17825_18024(f_1041_17867_17911(this), _errorId, _errorCategory, _itemName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 17744, 18044);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18064, 18084);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 17708, 18099);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1041_17867_17911(System.Management.Automation.SessionStateException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 17867, 17911);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1041_17825_18024(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, string
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 17825, 18024);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 17644, 18110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 17644, 18110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        public string ItemName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 18335, 18360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18341, 18358);

                    return _itemName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 18335, 18360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 18288, 18371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 18288, 18371);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _itemName;

        public SessionStateCategory SessionStateCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 18633, 18670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 18639, 18668);

                    return _sessionStateCategory;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 18633, 18670);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 18560, 18681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 18560, 18681);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SessionStateCategory _sessionStateCategory;

        private string _errorId;

        private ErrorCategory _errorCategory;

        private static string BuildMessage(
                    string itemName,
                    string resourceStr,
                    params object[] messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1041, 18985, 19575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19150, 19161);

                object[]
                a
                = default(object[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19175, 19507) || true) && (messageArgs != null && (DynAbs.Tracing.TraceSender.Expression_True(1041, 19179, 19224) && 0 < f_1041_19206_19224(messageArgs)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 19175, 19507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19258, 19297);

                    a = new object[f_1041_19273_19291(messageArgs) + 1];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19315, 19331);

                    a[0] = itemName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19349, 19374);

                    f_1041_19349_19373(messageArgs, a, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 19175, 19507);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1041, 19175, 19507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19440, 19458);

                    a = new object[1];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19476, 19492);

                    a[0] = itemName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1041, 19175, 19507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 19523, 19564);

                return f_1041_19530_19563(resourceStr, a);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1041, 18985, 19575);

                int
                f_1041_19206_19224(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 19206, 19224);
                    return return_v;
                }


                int
                f_1041_19273_19291(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1041, 19273, 19291);
                    return return_v;
                }


                int
                f_1041_19349_19373(object[]
                this_param, object[]
                array, int
                index)
                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 19349, 19373);
                    return 0;
                }


                string
                f_1041_19530_19563(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 19530, 19563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 18985, 19575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 18985, 19575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SessionStateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1041, 13515, 19610);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1041, 13515, 19610);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 13515, 19610);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1041, 13515, 19610);

        static string
        f_1041_14827_14875(string
        itemName, string
        resourceStr, params object[]
        messageArgs)
        {
            var return_v = BuildMessage(itemName, resourceStr, messageArgs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 14827, 14875);
            return return_v;
        }


        static string
        f_1041_14827_14875_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 14530, 15083);
            return return_v;
        }


        static string
        f_1041_15544_15551_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 15479, 15574);
            return return_v;
        }


        static string
        f_1041_16036_16043_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 15903, 16082);
            return return_v;
        }


        int
        f_1041_16625_16662(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetInt32(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 16625, 16662);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1041_16540_16544_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 16397, 16696);
            return return_v;
        }

    }
    [Serializable]
    public class SessionStateUnauthorizedAccessException : SessionStateException
    {
        internal SessionStateUnauthorizedAccessException(
                    string itemName,
                    SessionStateCategory sessionStateCategory,
                    string errorIdAndResourceId,
                    string resourceStr
                    )
        : base(f_1041_21207_21215_C(itemName), sessionStateCategory, errorIdAndResourceId, resourceStr, ErrorCategory.WriteError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 20962, 21342);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 20962, 21342);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 20962, 21342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 20962, 21342);
            }
        }

        public SessionStateUnauthorizedAccessException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 21468, 21560);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 21468, 21560);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 21468, 21560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 21468, 21560);
            }
        }

        public SessionStateUnauthorizedAccessException(string message)
        : base(f_1041_21875_21882_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 21792, 21905);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 21792, 21905);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 21792, 21905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 21792, 21905);
            }
        }

        public SessionStateUnauthorizedAccessException(string message,
                                                     Exception innerException)
        : base(f_1041_22411_22418_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 22252, 22457);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 22252, 22457);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 22252, 22457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 22252, 22457);
            }
        }

        protected SessionStateUnauthorizedAccessException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1041_22937_22941_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 22790, 22973);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 22790, 22973);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 22790, 22973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 22790, 22973);
            }
        }

        static SessionStateUnauthorizedAccessException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1041, 19942, 23014);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1041, 19942, 23014);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 19942, 23014);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1041, 19942, 23014);

        static string
        f_1041_21207_21215_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 20962, 21342);
            return return_v;
        }


        static string
        f_1041_21875_21882_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 21792, 21905);
            return return_v;
        }


        static string
        f_1041_22411_22418_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 22252, 22457);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1041_22937_22941_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 22790, 22973);
            return return_v;
        }

    }
    [Serializable]
    public class ProviderNotFoundException : SessionStateException
    {
        internal ProviderNotFoundException(
                    string itemName,
                    SessionStateCategory sessionStateCategory,
                    string errorIdAndResourceId,
                    string resourceStr,
                    params object[] messageArgs)
        : base(
        f_1041_24408_24416_C(itemName), sessionStateCategory, errorIdAndResourceId, resourceStr, ErrorCategory.ObjectNotFound, messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 24131, 24624);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 24131, 24624);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 24131, 24624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 24131, 24624);
            }
        }

        public ProviderNotFoundException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 24736, 24814);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 24736, 24814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 24736, 24814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 24736, 24814);
            }
        }

        public ProviderNotFoundException(string message)
        : base(f_1041_25102_25109_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 25033, 25132);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 25033, 25132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 25033, 25132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 25033, 25132);
            }
        }

        public ProviderNotFoundException(string message,
                                                 Exception innerException)
        : base(f_1041_25606_25613_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 25465, 25652);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 25465, 25652);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 25465, 25652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 25465, 25652);
            }
        }

        protected ProviderNotFoundException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1041_26104_26108_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 25971, 26140);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 25971, 26140);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 25971, 26140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 25971, 26140);
            }
        }

        static ProviderNotFoundException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1041, 23167, 26181);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1041, 23167, 26181);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 23167, 26181);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1041, 23167, 26181);

        static string
        f_1041_24408_24416_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 24131, 24624);
            return return_v;
        }


        static string
        f_1041_25102_25109_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 25033, 25132);
            return return_v;
        }


        static string
        f_1041_25606_25613_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 25465, 25652);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1041_26104_26108_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 25971, 26140);
            return return_v;
        }

    }
    [Serializable]
    public class ProviderNameAmbiguousException : ProviderNotFoundException
    {
        internal ProviderNameAmbiguousException(
                    string providerName,
                    string errorIdAndResourceId,
                    string resourceStr,
                    Collection<ProviderInfo> possibleMatches,
                    params object[] messageArgs)
        : base(
        f_1041_27704_27716_C(providerName), SessionStateCategory.CmdletProvider, errorIdAndResourceId, resourceStr, messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 27419, 27979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 29991, 30007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 27895, 27968);

                _possibleMatches = f_1041_27914_27967(possibleMatches);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 27419, 27979);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 27419, 27979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 27419, 27979);
            }
        }

        public ProviderNameAmbiguousException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 28096, 28179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 29991, 30007);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 28096, 28179);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 28096, 28179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 28096, 28179);
            }
        }

        public ProviderNameAmbiguousException(string message)
        : base(f_1041_28477_28484_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 28403, 28507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 29991, 30007);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 28403, 28507);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 28403, 28507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 28403, 28507);
            }
        }

        public ProviderNameAmbiguousException(string message,
                                                 Exception innerException)
        : base(f_1041_28987_28994_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 28845, 29033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 29991, 30007);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 28845, 29033);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 28845, 29033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 28845, 29033);
            }
        }

        protected ProviderNameAmbiguousException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1041_29495_29499_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 29357, 29531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 29991, 30007);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 29357, 29531);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 29357, 29531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 29357, 29531);
            }
        }

        public ReadOnlyCollection<ProviderInfo> PossibleMatches
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1041, 29852, 29927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1041, 29888, 29912);

                    return _possibleMatches;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1041, 29852, 29927);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 29772, 29938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 29772, 29938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReadOnlyCollection<ProviderInfo> _possibleMatches;

        static ProviderNameAmbiguousException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1041, 26397, 30055);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1041, 26397, 30055);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 26397, 30055);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1041, 26397, 30055);

        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.ProviderInfo>
        f_1041_27914_27967(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.ProviderInfo>((System.Collections.Generic.IList<System.Management.Automation.ProviderInfo>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1041, 27914, 27967);
            return return_v;
        }


        static string
        f_1041_27704_27716_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 27419, 27979);
            return return_v;
        }


        static string
        f_1041_28477_28484_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 28403, 28507);
            return return_v;
        }


        static string
        f_1041_28987_28994_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 28845, 29033);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1041_29495_29499_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 29357, 29531);
            return return_v;
        }

    }
    [Serializable]
    public class DriveNotFoundException : SessionStateException
    {
        internal DriveNotFoundException(
                    string itemName,
                    string errorIdAndResourceId,
                    string resourceStr
                    )
        : base(f_1041_31089_31097_C(itemName), SessionStateCategory.Drive, errorIdAndResourceId, resourceStr, ErrorCategory.ObjectNotFound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 30917, 31234);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 30917, 31234);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 30917, 31234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 30917, 31234);
            }
        }

        public DriveNotFoundException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 31343, 31418);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 31343, 31418);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 31343, 31418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 31343, 31418);
            }
        }

        public DriveNotFoundException(string message)
        : base(f_1041_31712_31719_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 31646, 31742);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 31646, 31742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 31646, 31742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 31646, 31742);
            }
        }

        public DriveNotFoundException(string message,
                                              Exception innerException)
        : base(f_1041_32220_32227_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 32085, 32266);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 32085, 32266);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 32085, 32266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 32085, 32266);
            }
        }

        protected DriveNotFoundException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1041_32712_32716_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 32582, 32748);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 32582, 32748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 32582, 32748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 32582, 32748);
            }
        }

        static DriveNotFoundException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1041, 30202, 32789);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1041, 30202, 32789);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 30202, 32789);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1041, 30202, 32789);

        static string
        f_1041_31089_31097_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 30917, 31234);
            return return_v;
        }


        static string
        f_1041_31712_31719_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 31646, 31742);
            return return_v;
        }


        static string
        f_1041_32220_32227_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 32085, 32266);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1041_32712_32716_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 32582, 32748);
            return return_v;
        }

    }
    [Serializable]
    public class ItemNotFoundException : SessionStateException
    {
        internal ItemNotFoundException(
                    string path,
                    string errorIdAndResourceId,
                    string resourceStr
                    )
        : base(f_1041_33969_33973_C(path), SessionStateCategory.Drive, errorIdAndResourceId, resourceStr, ErrorCategory.ObjectNotFound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 33802, 34110);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 33802, 34110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 33802, 34110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 33802, 34110);
            }
        }

        public ItemNotFoundException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 34218, 34292);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 34218, 34292);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 34218, 34292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 34218, 34292);
            }
        }

        public ItemNotFoundException(string message)
        : base(f_1041_34571_34578_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 34506, 34601);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 34506, 34601);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 34506, 34601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 34506, 34601);
            }
        }

        public ItemNotFoundException(string message,
                                              Exception innerException)
        : base(f_1041_35064_35071_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 34930, 35110);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 34930, 35110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 34930, 35110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 34930, 35110);
            }
        }

        protected ItemNotFoundException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1041_35554_35558_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1041, 35425, 35590);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1041, 35425, 35590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1041, 35425, 35590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 35425, 35590);
            }
        }

        static ItemNotFoundException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1041, 32975, 35631);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1041, 32975, 35631);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1041, 32975, 35631);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1041, 32975, 35631);

        static string
        f_1041_33969_33973_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 33802, 34110);
            return return_v;
        }


        static string
        f_1041_34571_34578_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 34506, 34601);
            return return_v;
        }


        static string
        f_1041_35064_35071_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 34930, 35110);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1041_35554_35558_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1041, 35425, 35590);
            return return_v;
        }

    }
}

