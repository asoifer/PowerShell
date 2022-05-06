// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class PSInvalidOperationException
                : InvalidOperationException, IContainsErrorRecord
    {
        public PSInvalidOperationException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1021, 1061, 1141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4952, 4964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4990, 5019);
                this._errorId = "InvalidOperation";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5159, 5206);
                this._errorCategory = ErrorCategory.InvalidOperation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5232, 5246);
                this._target = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1021, 1061, 1141);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 1061, 1141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 1061, 1141);
            }
        }

        protected PSInvalidOperationException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1021_1742_1746_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1021, 1602, 1829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4952, 4964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4990, 5019);
                this._errorId = "InvalidOperation";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5159, 5206);
                this._errorCategory = ErrorCategory.InvalidOperation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5232, 5246);
                this._target = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 1781, 1818);

                _errorId = f_1021_1792_1817(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1021, 1602, 1829);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 1602, 1829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 1602, 1829);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1021, 2102, 2521);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 2304, 2411) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1021, 2304, 2411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 2354, 2396);

                    throw f_1021_2360_2395("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1021, 2304, 2411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 2427, 2461);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1021, 2427, 2460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 2475, 2510);

                f_1021_2475_2509(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1021, 2102, 2521);

                System.Management.Automation.PSArgumentNullException
                f_1021_2360_2395(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1021, 2360, 2395);
                    return return_v;
                }


                int
                f_1021_2475_2509(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1021, 2475, 2509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 2102, 2521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 2102, 2521);
            }
        }

        public PSInvalidOperationException(string message)
        : base(f_1021_2863_2870_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1021, 2792, 2893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4952, 4964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4990, 5019);
                this._errorId = "InvalidOperation";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5159, 5206);
                this._errorCategory = ErrorCategory.InvalidOperation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5232, 5246);
                this._target = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1021, 2792, 2893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 2792, 2893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 2792, 2893);
            }
        }

        public PSInvalidOperationException(string message,
                                                    Exception innerException)
        : base(f_1021_3327_3334_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1021, 3181, 3373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4952, 4964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4990, 5019);
                this._errorId = "InvalidOperation";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5159, 5206);
                this._errorCategory = ErrorCategory.InvalidOperation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5232, 5246);
                this._target = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1021, 3181, 3373);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 3181, 3373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 3181, 3373);
            }
        }

        internal PSInvalidOperationException(string message, Exception innerException, string errorId, ErrorCategory errorCategory, object target)
        : base(f_1021_3957_3964_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1021, 3798, 4112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4952, 4964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4990, 5019);
                this._errorId = "InvalidOperation";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5159, 5206);
                this._errorCategory = ErrorCategory.InvalidOperation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5232, 5246);
                this._target = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4006, 4025);

                _errorId = errorId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4039, 4070);

                _errorCategory = errorCategory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4084, 4101);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1021, 3798, 4112);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 3798, 4112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 3798, 4112);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1021, 4520, 4909);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4556, 4854) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1021, 4556, 4854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4622, 4835);

                        _errorRecord = f_1021_4637_4834(f_1021_4679_4723(this), _errorId, _errorCategory, _target);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1021, 4556, 4854);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 4874, 4894);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1021, 4520, 4909);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1021_4679_4723(System.Management.Automation.PSInvalidOperationException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1021, 4679, 4723);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1021_4637_4834(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1021, 4637, 4834);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 4465, 4920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 4465, 4920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        internal void SetErrorId(string errorId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1021, 5030, 5125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1021, 5095, 5114);

                _errorId = errorId;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1021, 5030, 5125);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1021, 5030, 5125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 5030, 5125);
            }
        }

        private ErrorCategory _errorCategory;

        private object _target;

        static PSInvalidOperationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1021, 718, 5254);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1021, 718, 5254);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1021, 718, 5254);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1021, 718, 5254);

        string?
        f_1021_1792_1817(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1021, 1792, 1817);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1021_1742_1746_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1021, 1602, 1829);
            return return_v;
        }


        static string
        f_1021_2863_2870_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1021, 2792, 2893);
            return return_v;
        }


        static string
        f_1021_3327_3334_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1021, 3181, 3373);
            return return_v;
        }


        static string
        f_1021_3957_3964_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1021, 3798, 4112);
            return return_v;
        }

    }
}

