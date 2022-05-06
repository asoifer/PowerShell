// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class PSArgumentNullException
                : ArgumentNullException, IContainsErrorRecord
    {
        public PSArgumentNullException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1019, 1045, 1121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5064, 5076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5102, 5127);
                this._errorId = "ArgumentNull";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5623, 5631);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1019, 1045, 1121);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 1045, 1121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 1045, 1121);
            }
        }

        public PSArgumentNullException(string paramName)
        : base(f_1019_1591_1600_C(paramName))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1019, 1522, 1623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5064, 5076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5102, 5127);
                this._errorId = "ArgumentNull";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5623, 5631);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1019, 1522, 1623);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 1522, 1623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 1522, 1623);
            }
        }

        public PSArgumentNullException(string message, Exception innerException)
        : base(f_1019_2000_2007_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1019, 1907, 2079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5064, 5076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5102, 5127);
                this._errorId = "ArgumentNull";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5623, 5631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 2049, 2068);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1019, 1907, 2079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 1907, 2079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 1907, 2079);
            }
        }

        public PSArgumentNullException(string paramName, string message)
        : base(f_1019_2568_2577_C(paramName), message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1019, 2483, 2642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5064, 5076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5102, 5127);
                this._errorId = "ArgumentNull";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5623, 5631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 2612, 2631);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1019, 2483, 2642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 2483, 2642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 2483, 2642);
            }
        }

        protected PSArgumentNullException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1019_3235_3239_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1019, 3099, 3405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5064, 5076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5102, 5127);
                this._errorId = "ArgumentNull";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5623, 5631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 3274, 3311);

                _errorId = f_1019_3285_3310(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 3325, 3394);

                _message = f_1019_3336_3393(info, "PSArgumentNullException_MessageOverride");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1019, 3099, 3405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 3099, 3405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 3099, 3405);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1019, 3678, 4178);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 3880, 3987) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1019, 3880, 3987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 3930, 3972);

                    throw f_1019_3936_3971("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1019, 3880, 3987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 4003, 4037);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1019, 4003, 4036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 4051, 4086);

                f_1019_4051_4085(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 4100, 4167);

                f_1019_4100_4166(info, "PSArgumentNullException_MessageOverride", _message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1019, 3678, 4178);

                System.Management.Automation.PSArgumentNullException
                f_1019_3936_3971(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 3936, 3971);
                    return return_v;
                }


                int
                f_1019_4051_4085(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 4051, 4085);
                    return 0;
                }


                int
                f_1019_4100_4166(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 4100, 4166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 3678, 4178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 3678, 4178);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1019, 4620, 5021);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 4656, 4966) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1019, 4656, 4966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 4722, 4947);

                        _errorRecord = f_1019_4737_4946(f_1019_4779_4823(this), _errorId, ErrorCategory.InvalidArgument, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1019, 4656, 4966);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 4986, 5006);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1019, 4620, 5021);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1019_4779_4823(System.Management.Automation.PSArgumentNullException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 4779, 4823);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1019_4737_4946(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 4737, 4946);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 4565, 5032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 4565, 5032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        public override string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1019, 5513, 5585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1019, 5519, 5583);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1019, 5526, 5556) || ((f_1019_5526_5556(_message) && DynAbs.Tracing.TraceSender.Conditional_F2(1019, 5559, 5571)) || DynAbs.Tracing.TraceSender.Conditional_F3(1019, 5574, 5582))) ? DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message, 1019, 5559, 5571) : _message;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1019, 5513, 5585);

                    bool
                    f_1019_5526_5556(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 5526, 5556);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1019, 5458, 5596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 5458, 5596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _message;

        static PSArgumentNullException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1019, 714, 5639);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1019, 714, 5639);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1019, 714, 5639);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1019, 714, 5639);

        static string
        f_1019_1591_1600_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1019, 1522, 1623);
            return return_v;
        }


        static string
        f_1019_2000_2007_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1019, 1907, 2079);
            return return_v;
        }


        static string
        f_1019_2568_2577_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1019, 2483, 2642);
            return return_v;
        }


        string?
        f_1019_3285_3310(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 3285, 3310);
            return return_v;
        }


        string?
        f_1019_3336_3393(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1019, 3336, 3393);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1019_3235_3239_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1019, 3099, 3405);
            return return_v;
        }

    }
}

