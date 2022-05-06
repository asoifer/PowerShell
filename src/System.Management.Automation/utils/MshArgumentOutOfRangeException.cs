// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class PSArgumentOutOfRangeException
                : ArgumentOutOfRangeException, IContainsErrorRecord
    {
        public PSArgumentOutOfRangeException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1020, 1051, 1133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5040, 5052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5078, 5109);
                this._errorId = "ArgumentOutOfRange";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1020, 1051, 1133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1020, 1051, 1133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 1051, 1133);
            }
        }

        public PSArgumentOutOfRangeException(string paramName)
        : base(f_1020_1619_1628_C(paramName))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1020, 1540, 1651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5040, 5052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5078, 5109);
                this._errorId = "ArgumentOutOfRange";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1020, 1540, 1651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1020, 1540, 1651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 1540, 1651);
            }
        }

        public PSArgumentOutOfRangeException(string paramName, object actualValue, string message)
        : base(f_1020_2230_2239_C(paramName), actualValue, message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1020, 2115, 2284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5040, 5052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5078, 5109);
                this._errorId = "ArgumentOutOfRange";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1020, 2115, 2284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1020, 2115, 2284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 2115, 2284);
            }
        }

        protected PSArgumentOutOfRangeException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1020_2889_2893_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1020, 2747, 2976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5040, 5052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5078, 5109);
                this._errorId = "ArgumentOutOfRange";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 2928, 2965);

                _errorId = f_1020_2939_2964(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1020, 2747, 2976);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1020, 2747, 2976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 2747, 2976);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1020, 3249, 3668);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 3451, 3558) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1020, 3451, 3558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 3501, 3543);

                    throw f_1020_3507_3542("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1020, 3451, 3558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 3574, 3608);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1020, 3574, 3607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 3622, 3657);

                f_1020_3622_3656(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1020, 3249, 3668);

                System.Management.Automation.PSArgumentNullException
                f_1020_3507_3542(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1020, 3507, 3542);
                    return return_v;
                }


                int
                f_1020_3622_3656(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1020, 3622, 3656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1020, 3249, 3668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 3249, 3668);
            }
        }

        public PSArgumentOutOfRangeException(string message,
                                                      Exception innerException)
        : base(f_1020_4142_4149_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1020, 3992, 4188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5040, 5052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 5078, 5109);
                this._errorId = "ArgumentOutOfRange";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1020, 3992, 4188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1020, 3992, 4188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 3992, 4188);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1020, 4596, 4997);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 4632, 4942) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1020, 4632, 4942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 4698, 4923);

                        _errorRecord = f_1020_4713_4922(f_1020_4755_4799(this), _errorId, ErrorCategory.InvalidArgument, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1020, 4632, 4942);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1020, 4962, 4982);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1020, 4596, 4997);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1020_4755_4799(System.Management.Automation.PSArgumentOutOfRangeException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1020, 4755, 4799);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1020_4713_4922(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1020, 4713, 4922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1020, 4541, 5008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 4541, 5008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        static PSArgumentOutOfRangeException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1020, 720, 5117);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1020, 720, 5117);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1020, 720, 5117);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1020, 720, 5117);

        static string
        f_1020_1619_1628_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1020, 1540, 1651);
            return return_v;
        }


        static string
        f_1020_2230_2239_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1020, 2115, 2284);
            return return_v;
        }


        string?
        f_1020_2939_2964(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1020, 2939, 2964);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1020_2889_2893_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1020, 2747, 2976);
            return return_v;
        }


        static string
        f_1020_4142_4149_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1020, 3992, 4188);
            return return_v;
        }

    }
}

