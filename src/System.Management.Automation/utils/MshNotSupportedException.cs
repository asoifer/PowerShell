// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class PSNotSupportedException
                : NotSupportedException, IContainsErrorRecord
    {
        public PSNotSupportedException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1023, 1045, 1121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4177, 4189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4215, 4240);
                this._errorId = "NotSupported";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1023, 1045, 1121);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1023, 1045, 1121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1023, 1045, 1121);
            }
        }

        protected PSNotSupportedException(SerializationInfo info,
                                                    StreamingContext context)
        : base(f_1023_1731_1735_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1023, 1578, 1818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4177, 4189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4215, 4240);
                this._errorId = "NotSupported";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 1770, 1807);

                _errorId = f_1023_1781_1806(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1023, 1578, 1818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1023, 1578, 1818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1023, 1578, 1818);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1023, 2091, 2510);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 2293, 2400) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1023, 2293, 2400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 2343, 2385);

                    throw f_1023_2349_2384("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1023, 2293, 2400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 2416, 2450);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1023, 2416, 2449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 2464, 2499);

                f_1023_2464_2498(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1023, 2091, 2510);

                System.Management.Automation.PSArgumentNullException
                f_1023_2349_2384(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1023, 2349, 2384);
                    return return_v;
                }


                int
                f_1023_2464_2498(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1023, 2464, 2498);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1023, 2091, 2510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1023, 2091, 2510);
            }
        }

        public PSNotSupportedException(string message)
        : base(f_1023_2844_2851_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1023, 2777, 2874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4177, 4189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4215, 4240);
                this._errorId = "NotSupported";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1023, 2777, 2874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1023, 2777, 2874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1023, 2777, 2874);
            }
        }

        public PSNotSupportedException(string message,
                                Exception innerException)
        : base(f_1023_3280_3287_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1023, 3158, 3326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4177, 4189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4215, 4240);
                this._errorId = "NotSupported";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1023, 3158, 3326);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1023, 3158, 3326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1023, 3158, 3326);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1023, 3734, 4134);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 3770, 4079) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1023, 3770, 4079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 3836, 4060);

                        _errorRecord = f_1023_3851_4059(f_1023_3893_3937(this), _errorId, ErrorCategory.NotImplemented, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1023, 3770, 4079);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1023, 4099, 4119);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1023, 3734, 4134);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1023_3893_3937(System.Management.Automation.PSNotSupportedException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1023, 3893, 3937);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1023_3851_4059(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1023, 3851, 4059);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1023, 3679, 4145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1023, 3679, 4145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        static PSNotSupportedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1023, 714, 4248);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1023, 714, 4248);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1023, 714, 4248);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1023, 714, 4248);

        string?
        f_1023_1781_1806(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1023, 1781, 1806);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1023_1731_1735_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1023, 1578, 1818);
            return return_v;
        }


        static string
        f_1023_2844_2851_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1023, 2777, 2874);
            return return_v;
        }


        static string
        f_1023_3280_3287_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1023, 3158, 3326);
            return return_v;
        }

    }
}

