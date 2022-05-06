// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;
using System.Runtime.Serialization;

namespace System.Management.Automation.Host
{
    [Serializable]
    public
        class HostException : RuntimeException
    {
        public
                HostException() : base(
        f_1014_703_811_C(f_1014_703_811(f_1014_721_778(), f_1014_780_810(typeof(HostException)))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 650, 872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 837, 861);

                f_1014_837_860(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 650, 872);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 650, 872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 650, 872);
            }
        }

        public
                HostException(string message) : base(f_1014_1217_1224_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 1164, 1285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 1250, 1274);

                f_1014_1250_1273(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 1164, 1285);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 1164, 1285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 1164, 1285);
            }
        }

        public
                HostException(string message, Exception innerException)
        : base(f_1014_2023_2030_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 1931, 2107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 2072, 2096);

                f_1014_2072_2095(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 1931, 2107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 1931, 2107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 1931, 2107);
            }
        }

        public
                HostException(string message, Exception innerException, string errorId, ErrorCategory errorCategory) : base(f_1014_3391_3398_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 3254, 3517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 3440, 3460);

                f_1014_3440_3459(this, errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 3474, 3506);

                f_1014_3474_3505(this, errorCategory);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 3254, 3517);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 3254, 3517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 3254, 3517);
            }
        }

        protected
                HostException(SerializationInfo info, StreamingContext context)
        : base(f_1014_4070_4074_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 3967, 4106);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 3967, 4106);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 3967, 4106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 3967, 4106);
            }
        }

        private void SetDefaultErrorRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1014, 4161, 4342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 4222, 4274);

                f_1014_4222_4273(this, ErrorCategory.ResourceUnavailable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 4288, 4331);

                f_1014_4288_4330(this, f_1014_4299_4329(typeof(HostException)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1014, 4161, 4342);

                int
                f_1014_4222_4273(System.Management.Automation.Host.HostException
                this_param, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    this_param.SetErrorCategory(errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 4222, 4273);
                    return 0;
                }


                string
                f_1014_4299_4329(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1014, 4299, 4329);
                    return return_v;
                }


                int
                f_1014_4288_4330(System.Management.Automation.Host.HostException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 4288, 4330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 4161, 4342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 4161, 4342);
            }
        }

        static HostException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1014, 423, 4371);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1014, 423, 4371);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 423, 4371);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1014, 423, 4371);

        static string
        f_1014_721_778()
        {
            var return_v = HostInterfaceExceptionsStrings.DefaultCtorMessageTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1014, 721, 778);
            return return_v;
        }


        static string
        f_1014_780_810(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1014, 780, 810);
            return return_v;
        }


        static string
        f_1014_703_811(string
        formatSpec, string
        o)
        {
            var return_v = StringUtil.Format(formatSpec, (object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 703, 811);
            return return_v;
        }


        int
        f_1014_837_860(System.Management.Automation.Host.HostException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 837, 860);
            return 0;
        }


        static string
        f_1014_703_811_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 650, 872);
            return return_v;
        }


        int
        f_1014_1250_1273(System.Management.Automation.Host.HostException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 1250, 1273);
            return 0;
        }


        static string
        f_1014_1217_1224_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 1164, 1285);
            return return_v;
        }


        int
        f_1014_2072_2095(System.Management.Automation.Host.HostException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 2072, 2095);
            return 0;
        }


        static string
        f_1014_2023_2030_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 1931, 2107);
            return return_v;
        }


        int
        f_1014_3440_3459(System.Management.Automation.Host.HostException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 3440, 3459);
            return 0;
        }


        int
        f_1014_3474_3505(System.Management.Automation.Host.HostException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 3474, 3505);
            return 0;
        }


        static string
        f_1014_3391_3398_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 3254, 3517);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1014_4070_4074_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 3967, 4106);
            return return_v;
        }

    }
    [Serializable]
    public
        class PromptingException : HostException
    {
        public
                PromptingException() : base(f_1014_4797_4910_C(f_1014_4797_4910(f_1014_4815_4872(), f_1014_4874_4909(typeof(PromptingException)))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 4753, 4971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 4936, 4960);

                f_1014_4936_4959(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 4753, 4971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 4753, 4971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 4753, 4971);
            }
        }

        public
                PromptingException(string message) : base(f_1014_5326_5333_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 5268, 5394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 5359, 5383);

                f_1014_5359_5382(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 5268, 5394);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 5268, 5394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 5268, 5394);
            }
        }

        public
                PromptingException(string message, Exception innerException)
        : base(f_1014_6142_6149_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 6045, 6226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 6191, 6215);

                f_1014_6191_6214(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 6045, 6226);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 6045, 6226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 6045, 6226);
            }
        }

        public
                PromptingException(string message, Exception innerException, string errorId, ErrorCategory errorCategory) : base(f_1014_7520_7527_C(message), innerException, errorId, errorCategory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 7378, 7590);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 7378, 7590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 7378, 7590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 7378, 7590);
            }
        }

        protected
                PromptingException(SerializationInfo info, StreamingContext context)
        : base(f_1014_8148_8152_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1014, 8040, 8184);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1014, 8040, 8184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 8040, 8184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 8040, 8184);
            }
        }

        private void SetDefaultErrorRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1014, 8241, 8427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 8302, 8354);

                f_1014_8302_8353(this, ErrorCategory.ResourceUnavailable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1014, 8368, 8416);

                f_1014_8368_8415(this, f_1014_8379_8414(typeof(PromptingException)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1014, 8241, 8427);

                int
                f_1014_8302_8353(System.Management.Automation.Host.PromptingException
                this_param, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    this_param.SetErrorCategory(errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 8302, 8353);
                    return 0;
                }


                string
                f_1014_8379_8414(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1014, 8379, 8414);
                    return return_v;
                }


                int
                f_1014_8368_8415(System.Management.Automation.Host.PromptingException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 8368, 8415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1014, 8241, 8427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 8241, 8427);
            }
        }

        static PromptingException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1014, 4519, 8454);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1014, 4519, 8454);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1014, 4519, 8454);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1014, 4519, 8454);

        static string
        f_1014_4815_4872()
        {
            var return_v = HostInterfaceExceptionsStrings.DefaultCtorMessageTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1014, 4815, 4872);
            return return_v;
        }


        static string
        f_1014_4874_4909(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1014, 4874, 4909);
            return return_v;
        }


        static string
        f_1014_4797_4910(string
        formatSpec, string
        o)
        {
            var return_v = StringUtil.Format(formatSpec, (object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 4797, 4910);
            return return_v;
        }


        int
        f_1014_4936_4959(System.Management.Automation.Host.PromptingException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 4936, 4959);
            return 0;
        }


        static string
        f_1014_4797_4910_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 4753, 4971);
            return return_v;
        }


        int
        f_1014_5359_5382(System.Management.Automation.Host.PromptingException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 5359, 5382);
            return 0;
        }


        static string
        f_1014_5326_5333_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 5268, 5394);
            return return_v;
        }


        int
        f_1014_6191_6214(System.Management.Automation.Host.PromptingException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1014, 6191, 6214);
            return 0;
        }


        static string
        f_1014_6142_6149_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 6045, 6226);
            return return_v;
        }


        static string
        f_1014_7520_7527_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 7378, 7590);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1014_8148_8152_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1014, 8040, 8184);
            return return_v;
        }

    }
}
