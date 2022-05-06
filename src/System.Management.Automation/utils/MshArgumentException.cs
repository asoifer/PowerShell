// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class PSArgumentException
                : ArgumentException, IContainsErrorRecord
    {
        public PSArgumentException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1018, 1029, 1101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5089, 5101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5127, 5148);
                this._errorId = "Argument";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5644, 5652);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1018, 1029, 1101);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 1029, 1101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 1029, 1101);
            }
        }

        public PSArgumentException(string message)
        : base(f_1018_1541_1548_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1018, 1478, 1571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5089, 5101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5127, 5148);
                this._errorId = "Argument";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5644, 5652);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1018, 1478, 1571);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 1478, 1571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 1478, 1571);
            }
        }

        public PSArgumentException(string message, string paramName)
        : base(f_1018_2120_2127_C(message), paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1018, 2035, 2194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5089, 5101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5127, 5148);
                this._errorId = "Argument";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5644, 5652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 2164, 2183);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1018, 2035, 2194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 2035, 2194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 2035, 2194);
            }
        }

        protected PSArgumentException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1018_2779_2783_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1018, 2647, 2945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5089, 5101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5127, 5148);
                this._errorId = "Argument";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5644, 5652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 2818, 2855);

                _errorId = f_1018_2829_2854(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 2869, 2934);

                _message = f_1018_2880_2933(info, "PSArgumentException_MessageOverride");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1018, 2647, 2945);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 2647, 2945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 2647, 2945);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1018, 3218, 3714);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 3420, 3527) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1018, 3420, 3527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 3470, 3512);

                    throw f_1018_3476_3511("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1018, 3420, 3527);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 3543, 3577);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1018, 3543, 3576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 3591, 3626);

                f_1018_3591_3625(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 3640, 3703);

                f_1018_3640_3702(info, "PSArgumentException_MessageOverride", _message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1018, 3218, 3714);

                System.Management.Automation.PSArgumentNullException
                f_1018_3476_3511(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 3476, 3511);
                    return return_v;
                }


                int
                f_1018_3591_3625(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 3591, 3625);
                    return 0;
                }


                int
                f_1018_3640_3702(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 3640, 3702);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 3218, 3714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 3218, 3714);
            }
        }

        public PSArgumentException(string message,
                                            Exception innerException)
        : base(f_1018_4158_4165_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1018, 4028, 4237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5089, 5101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5127, 5148);
                this._errorId = "Argument";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5644, 5652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 4207, 4226);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1018, 4028, 4237);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 4028, 4237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 4028, 4237);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1018, 4645, 5046);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 4681, 4991) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1018, 4681, 4991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 4747, 4972);

                        _errorRecord = f_1018_4762_4971(f_1018_4804_4848(this), _errorId, ErrorCategory.InvalidArgument, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1018, 4681, 4991);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5011, 5031);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1018, 4645, 5046);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1018_4804_4848(System.Management.Automation.PSArgumentException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 4804, 4848);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1018_4762_4971(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 4762, 4971);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 4590, 5057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 4590, 5057);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1018, 5534, 5606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1018, 5540, 5604);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1018, 5547, 5577) || ((f_1018_5547_5577(_message) && DynAbs.Tracing.TraceSender.Conditional_F2(1018, 5580, 5592)) || DynAbs.Tracing.TraceSender.Conditional_F3(1018, 5595, 5603))) ? DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Message, 1018, 5580, 5592) : _message;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1018, 5534, 5606);

                    bool
                    f_1018_5547_5577(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 5547, 5577);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1018, 5479, 5617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 5479, 5617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _message;

        static PSArgumentException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1018, 710, 5660);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1018, 710, 5660);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1018, 710, 5660);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1018, 710, 5660);

        static string
        f_1018_1541_1548_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1018, 1478, 1571);
            return return_v;
        }


        static string
        f_1018_2120_2127_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1018, 2035, 2194);
            return return_v;
        }


        string?
        f_1018_2829_2854(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 2829, 2854);
            return return_v;
        }


        string?
        f_1018_2880_2933(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1018, 2880, 2933);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1018_2779_2783_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1018, 2647, 2945);
            return return_v;
        }


        static string
        f_1018_4158_4165_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1018, 4028, 4237);
            return return_v;
        }

    }
}

