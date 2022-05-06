// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class PSNotImplementedException
                : NotImplementedException, IContainsErrorRecord
    {
        public PSNotImplementedException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1022, 1053, 1131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4201, 4213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4239, 4266);
                this._errorId = "NotImplemented";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1022, 1053, 1131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1022, 1053, 1131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1022, 1053, 1131);
            }
        }

        protected PSNotImplementedException(SerializationInfo info,
                                                      StreamingContext context)
        : base(f_1022_1747_1751_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1022, 1590, 1834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4201, 4213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4239, 4266);
                this._errorId = "NotImplemented";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 1786, 1823);

                _errorId = f_1022_1797_1822(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1022, 1590, 1834);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1022, 1590, 1834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1022, 1590, 1834);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1022, 2107, 2526);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 2309, 2416) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1022, 2309, 2416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 2359, 2401);

                    throw f_1022_2365_2400("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1022, 2309, 2416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 2432, 2466);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1022, 2432, 2465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 2480, 2515);

                f_1022_2480_2514(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1022, 2107, 2526);

                System.Management.Automation.PSArgumentNullException
                f_1022_2365_2400(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1022, 2365, 2400);
                    return return_v;
                }


                int
                f_1022_2480_2514(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1022, 2480, 2514);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1022, 2107, 2526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1022, 2107, 2526);
            }
        }

        public PSNotImplementedException(string message)
        : base(f_1022_2864_2871_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1022, 2795, 2894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4201, 4213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4239, 4266);
                this._errorId = "NotImplemented";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1022, 2795, 2894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1022, 2795, 2894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1022, 2795, 2894);
            }
        }

        public PSNotImplementedException(string message,
                                Exception innerException)
        : base(f_1022_3304_3311_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1022, 3180, 3350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4201, 4213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4239, 4266);
                this._errorId = "NotImplemented";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1022, 3180, 3350);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1022, 3180, 3350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1022, 3180, 3350);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1022, 3758, 4158);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 3794, 4103) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1022, 3794, 4103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 3860, 4084);

                        _errorRecord = f_1022_3875_4083(f_1022_3917_3961(this), _errorId, ErrorCategory.NotImplemented, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1022, 3794, 4103);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1022, 4123, 4143);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1022, 3758, 4158);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1022_3917_3961(System.Management.Automation.PSNotImplementedException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1022, 3917, 3961);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1022_3875_4083(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1022, 3875, 4083);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1022, 3703, 4169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1022, 3703, 4169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        static PSNotImplementedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1022, 716, 4274);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1022, 716, 4274);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1022, 716, 4274);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1022, 716, 4274);

        string?
        f_1022_1797_1822(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1022, 1797, 1822);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1022_1747_1751_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1022, 1590, 1834);
            return return_v;
        }


        static string
        f_1022_2864_2871_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1022, 2795, 2894);
            return return_v;
        }


        static string
        f_1022_3304_3311_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1022, 3180, 3350);
            return return_v;
        }

    }
}

