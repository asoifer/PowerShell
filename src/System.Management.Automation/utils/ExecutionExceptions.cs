// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56506

using System.Runtime.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Internal;
using System.Security.Permissions;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation
{
    [Serializable]
    public class CmdletInvocationException : RuntimeException
    {
        internal CmdletInvocationException(ErrorRecord errorRecord)
        : base(f_1009_1075_1103_C(f_1009_1075_1103(errorRecord)), f_1009_1105_1135(errorRecord))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 995, 1639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6723, 6742);
                this._errorRecord = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 1161, 1280) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 1161, 1280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 1218, 1265);

                    throw f_1009_1224_1264("errorRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 1161, 1280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 1296, 1323);

                _errorRecord = errorRecord;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 1337, 1628) || true) && (f_1009_1341_1362(errorRecord) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 1337, 1628);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 1337, 1628);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 995, 1639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 995, 1639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 995, 1639);
            }
        }

        internal CmdletInvocationException(Exception innerException,
                                                   InvocationInfo invocationInfo)
        : base(f_1009_2118_2149_C(f_1009_2118_2149(innerException)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 1962, 3291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6723, 6742);
                this._errorRecord = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 2191, 2316) || true) && (innerException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 2191, 2316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 2251, 2301);

                    throw f_1009_2257_2300("innerException");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 2191, 2316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 2375, 2442);

                IContainsErrorRecord
                icer = innerException as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 2456, 3016) || true) && (icer != null && (DynAbs.Tracing.TraceSender.Expression_True(1009, 2460, 2500) && f_1009_2476_2492(icer) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 2456, 3016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 2534, 2599);

                    _errorRecord = f_1009_2549_2598(f_1009_2565_2581(icer), innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 2456, 3016);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 2456, 3016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 2800, 3001);

                    _errorRecord = f_1009_2815_3000(innerException, f_1009_2890_2923(f_1009_2890_2914(innerException)), ErrorCategory.NotSpecified, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 2456, 3016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 3032, 3079);

                f_1009_3032_3078(
                            _errorRecord, invocationInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 1962, 3291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 1962, 3291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 1962, 3291);
            }
        }

        public CmdletInvocationException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 3431, 3509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6723, 6742);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 3431, 3509);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 3431, 3509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 3431, 3509);
            }
        }

        public CmdletInvocationException(string message)
        : base(f_1009_3814_3821_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 3745, 3844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6723, 6742);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 3745, 3844);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 3745, 3844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 3745, 3844);
            }
        }

        public CmdletInvocationException(string message,
                                                 Exception innerException)
        : base(f_1009_4268_4275_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 4131, 4314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6723, 6742);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 4131, 4314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 4131, 4314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 4131, 4314);
            }
        }

        protected CmdletInvocationException(SerializationInfo info,
                                                    StreamingContext context)
        : base(f_1009_4903_4907_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 4744, 5138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6723, 6742);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 4942, 4998);

                bool
                hasErrorRecord = f_1009_4964_4997(info, "HasErrorRecord")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5012, 5127) || true) && (hasErrorRecord)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 5012, 5127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5049, 5127);

                    _errorRecord = (ErrorRecord)f_1009_5077_5126(info, "ErrorRecord", typeof(ErrorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 5012, 5127);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 4744, 5138);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 4744, 5138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 4744, 5138);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 5382, 5967);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5584, 5691) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 5584, 5691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5634, 5676);

                    throw f_1009_5640_5675("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 5584, 5691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5707, 5741);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1009, 5707, 5740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5755, 5800);

                bool
                hasErrorRecord = (_errorRecord != null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5814, 5862);

                f_1009_5814_5861(info, "HasErrorRecord", hasErrorRecord);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5876, 5956) || true) && (hasErrorRecord)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 5876, 5956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 5913, 5956);

                    f_1009_5913_5955(info, "ErrorRecord", _errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 5876, 5956);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 5382, 5967);

                System.Management.Automation.PSArgumentNullException
                f_1009_5640_5675(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 5640, 5675);
                    return return_v;
                }


                int
                f_1009_5814_5861(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, bool
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 5814, 5861);
                    return 0;
                }


                int
                f_1009_5913_5955(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Management.Automation.ErrorRecord
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 5913, 5955);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 5382, 5967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 5382, 5967);
            }
        }

        public override ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 6263, 6680);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6299, 6625) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 6299, 6625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6365, 6606);

                        _errorRecord = f_1009_6380_6605(f_1009_6422_6466(this), "CmdletInvocationException", ErrorCategory.NotSpecified, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 6299, 6625);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 6645, 6665);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 6263, 6680);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1009_6422_6466(System.Management.Automation.CmdletInvocationException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 6422, 6466);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1009_6380_6605(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 6380, 6605);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 6199, 6691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 6199, 6691);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        static CmdletInvocationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 703, 6783);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 703, 6783);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 703, 6783);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 703, 6783);

        static string
        f_1009_1075_1103(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = RetrieveMessage(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 1075, 1103);
            return return_v;
        }


        static System.Exception
        f_1009_1105_1135(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = RetrieveException(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 1105, 1135);
            return return_v;
        }


        System.ArgumentNullException
        f_1009_1224_1264(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 1224, 1264);
            return return_v;
        }


        System.Exception
        f_1009_1341_1362(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.Exception;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 1341, 1362);
            return return_v;
        }


        static string
        f_1009_1075_1103_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 995, 1639);
            return return_v;
        }


        static string
        f_1009_2118_2149(System.Exception
        e)
        {
            var return_v = RetrieveMessage(e);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 2118, 2149);
            return return_v;
        }


        System.ArgumentNullException
        f_1009_2257_2300(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 2257, 2300);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1009_2476_2492(System.Management.Automation.IContainsErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 2476, 2492);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1009_2565_2581(System.Management.Automation.IContainsErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 2565, 2581);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1009_2549_2598(System.Management.Automation.ErrorRecord
        errorRecord, System.Exception
        replaceParentContainsErrorRecordException)
        {
            var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 2549, 2598);
            return return_v;
        }


        System.Type
        f_1009_2890_2914(System.Exception
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 2890, 2914);
            return return_v;
        }


        string
        f_1009_2890_2923(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 2890, 2923);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1009_2815_3000(System.Exception
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 2815, 3000);
            return return_v;
        }


        int
        f_1009_3032_3078(System.Management.Automation.ErrorRecord
        this_param, System.Management.Automation.InvocationInfo
        invocationInfo)
        {
            this_param.SetInvocationInfo(invocationInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 3032, 3078);
            return 0;
        }


        static string
        f_1009_2118_2149_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 1962, 3291);
            return return_v;
        }


        static string
        f_1009_3814_3821_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 3745, 3844);
            return return_v;
        }


        static string
        f_1009_4268_4275_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 4131, 4314);
            return return_v;
        }


        bool
        f_1009_4964_4997(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetBoolean(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 4964, 4997);
            return return_v;
        }


        object?
        f_1009_5077_5126(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 5077, 5126);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_4903_4907_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 4744, 5138);
            return return_v;
        }

    }
    [Serializable]
    public class CmdletProviderInvocationException : CmdletInvocationException
    {
        internal CmdletProviderInvocationException(
                            ProviderInvocationException innerException,
                            InvocationInfo myInvocation)
        : base(f_1009_7860_7893_C(f_1009_7860_7893(innerException)), myInvocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 7681, 8131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 10540, 10568);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 7933, 8058) || true) && (innerException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 7933, 8058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 7993, 8043);

                    throw f_1009_7999_8042("innerException");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 7933, 8058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 8074, 8120);

                _providerInvocationException = innerException;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 7681, 8131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 7681, 8131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 7681, 8131);
            }
        }

        public CmdletProviderInvocationException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 8331, 8417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 10540, 10568);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 8331, 8417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 8331, 8417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 8331, 8417);
            }
        }

        protected CmdletProviderInvocationException(SerializationInfo info,
                                                            StreamingContext context)
        : base(f_1009_8991_8995_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 8824, 9118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 10540, 10568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 9030, 9107);

                _providerInvocationException = f_1009_9061_9075() as ProviderInvocationException;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 8824, 9118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 8824, 9118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 8824, 9118);
            }
        }

        public CmdletProviderInvocationException(string message)
        : base(f_1009_9439_9446_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 9362, 9469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 10540, 10568);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 9362, 9469);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 9362, 9469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 9362, 9469);
            }
        }

        public CmdletProviderInvocationException(string message,
                                                         Exception innerException)
        : base(f_1009_9917_9924_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 9764, 10054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 10540, 10568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 9966, 10043);

                _providerInvocationException = innerException as ProviderInvocationException;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 9764, 10054);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 9764, 10054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 9764, 10054);
            }
        }

        public ProviderInvocationException ProviderInvocationException
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 10369, 10456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 10405, 10441);

                    return _providerInvocationException;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 10369, 10456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 10282, 10467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 10282, 10467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [NonSerialized]
        private ProviderInvocationException _providerInvocationException;

        public ProviderInfo ProviderInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 10832, 11022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 10868, 11007);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1009, 10875, 10913) || (((_providerInvocationException == null)
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1009, 10937, 10941)) || DynAbs.Tracing.TraceSender.Conditional_F3(1009, 10965, 11006))) ? null
                    : f_1009_10965_11006(_providerInvocationException);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 10832, 11022);

                    System.Management.Automation.ProviderInfo
                    f_1009_10965_11006(System.Management.Automation.ProviderInvocationException
                    this_param)
                    {
                        var return_v = this_param.ProviderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 10965, 11006);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 10775, 11033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 10775, 11033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static Exception GetInnerException(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1009, 11104, 11240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 11184, 11229);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1009, 11191, 11202) || (((e == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1009, 11205, 11209)) || DynAbs.Tracing.TraceSender.Conditional_F3(1009, 11212, 11228))) ? null : f_1009_11212_11228(e);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1009, 11104, 11240);

                System.Exception
                f_1009_11212_11228(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 11212, 11228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 11104, 11240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 11104, 11240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CmdletProviderInvocationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 7179, 11276);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 7179, 11276);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 7179, 11276);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 7179, 11276);

        static System.Exception
        f_1009_7860_7893(System.Management.Automation.ProviderInvocationException
        e)
        {
            var return_v = GetInnerException((System.Exception)e);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 7860, 7893);
            return return_v;
        }


        System.ArgumentNullException
        f_1009_7999_8042(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 7999, 8042);
            return return_v;
        }


        static System.Exception
        f_1009_7860_7893_C(System.Exception
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 7681, 8131);
            return return_v;
        }


        System.Exception
        f_1009_9061_9075()
        {
            var return_v = InnerException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 9061, 9075);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_8991_8995_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 8824, 9118);
            return return_v;
        }


        static string
        f_1009_9439_9446_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 9362, 9469);
            return return_v;
        }


        static string
        f_1009_9917_9924_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 9764, 10054);
            return return_v;
        }

    }
    [Serializable]
    public class PipelineStoppedException : RuntimeException
    {
        public PipelineStoppedException()
        : base(f_1009_12645_12682_C(f_1009_12645_12682()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 12591, 12812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 12708, 12738);

                f_1009_12708_12737(this, "PipelineStopped");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 12752, 12801);

                f_1009_12752_12800(this, ErrorCategory.OperationStopped);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 12591, 12812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 12591, 12812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 12591, 12812);
            }
        }

        protected PipelineStoppedException(SerializationInfo info,
                                                   StreamingContext context)
        : base(f_1009_13367_13371_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 13210, 13519);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 13210, 13519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 13210, 13519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 13210, 13519);
            }
        }

        public PipelineStoppedException(string message)
        : base(f_1009_13822_13829_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 13754, 13852);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 13754, 13852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 13754, 13852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 13754, 13852);
            }
        }

        public PipelineStoppedException(string message,
                                                Exception innerException)
        : base(f_1009_14273_14280_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 14138, 14319);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 14138, 14319);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 14138, 14319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 14138, 14319);
            }
        }

        static PipelineStoppedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 12297, 14351);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 12297, 14351);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 12297, 14351);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 12297, 14351);

        static string
        f_1009_12645_12682()
        {
            var return_v = GetErrorText.PipelineStoppedException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 12645, 12682);
            return return_v;
        }


        int
        f_1009_12708_12737(System.Management.Automation.PipelineStoppedException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 12708, 12737);
            return 0;
        }


        int
        f_1009_12752_12800(System.Management.Automation.PipelineStoppedException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 12752, 12800);
            return 0;
        }


        static string
        f_1009_12645_12682_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 12591, 12812);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_13367_13371_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 13210, 13519);
            return return_v;
        }


        static string
        f_1009_13822_13829_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 13754, 13852);
            return return_v;
        }


        static string
        f_1009_14273_14280_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 14138, 14319);
            return return_v;
        }

    }
    [Serializable]
    public class PipelineClosedException : RuntimeException
    {
        public PipelineClosedException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 15013, 15089);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 15013, 15089);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 15013, 15089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 15013, 15089);
            }
        }

        public PipelineClosedException(string message)
        : base(f_1009_15390_15397_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 15323, 15420);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 15323, 15420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 15323, 15420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 15323, 15420);
            }
        }

        public PipelineClosedException(string message,
                                               Exception innerException)
        : base(f_1009_15838_15845_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 15705, 15884);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 15705, 15884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 15705, 15884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 15705, 15884);
            }
        }

        protected PipelineClosedException(SerializationInfo info,
                                                  StreamingContext context)
        : base(f_1009_16484_16488_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 16337, 16520);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 16337, 16520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 16337, 16520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 16337, 16520);
            }
        }

        static PipelineClosedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 14721, 16561);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 14721, 16561);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 14721, 16561);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 14721, 16561);

        static string
        f_1009_15390_15397_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 15323, 15420);
            return return_v;
        }


        static string
        f_1009_15838_15845_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 15705, 15884);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_16484_16488_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 16337, 16520);
            return return_v;
        }

    }
    [Serializable]
    public class ActionPreferenceStopException : RuntimeException
    {
        public ActionPreferenceStopException()
        : this(f_1009_17362_17395_C(f_1009_17362_17395()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 17303, 17418);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 17303, 17418);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 17303, 17418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 17303, 17418);
            }
        }

        internal ActionPreferenceStopException(ErrorRecord error)
        : this(f_1009_17808_17830_C(f_1009_17808_17830(error)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 17730, 18011);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 17856, 17963) || true) && (error == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 17856, 17963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 17907, 17948);

                    throw f_1009_17913_17947("error");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 17856, 17963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 17979, 18000);

                _errorRecord = error;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 17730, 18011);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 17730, 18011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 17730, 18011);
            }
        }

        internal ActionPreferenceStopException(InvocationInfo invocationInfo, string message)
        : this(f_1009_18408_18415_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 18302, 18503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 18441, 18492);

                f_1009_18441_18491(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ErrorRecord, 1009, 18441, 18457), invocationInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 18302, 18503);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 18302, 18503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 18302, 18503);
            }
        }

        internal ActionPreferenceStopException(InvocationInfo invocationInfo,
                                                       ErrorRecord errorRecord,
                                                       string message)
        : this(f_1009_18874_18888_C(invocationInfo), message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 18647, 19096);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 18923, 19042) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 18923, 19042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 18980, 19027);

                    throw f_1009_18986_19026("errorRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 18923, 19042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 19058, 19085);

                _errorRecord = errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 18647, 19096);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 18647, 19096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 18647, 19096);
            }
        }

        protected ActionPreferenceStopException(SerializationInfo info,
                                                        StreamingContext context)
        : base(f_1009_19697_19701_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 19530, 20356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 24178, 24197);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 19736, 19792);

                bool
                hasErrorRecord = f_1009_19758_19791(info, "HasErrorRecord")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 19806, 19921) || true) && (hasErrorRecord)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 19806, 19921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 19843, 19921);

                    _errorRecord = (ErrorRecord)f_1009_19871_19920(info, "ErrorRecord", typeof(ErrorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 19806, 19921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 20305, 20345);

                this.SuppressPromptInInterpreter = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 19530, 20356);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 19530, 20356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 19530, 20356);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 20600, 21601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 20802, 20836);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1009, 20802, 20835);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 20850, 21166) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 20850, 21166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 20900, 20945);

                    bool
                    hasErrorRecord = (_errorRecord != null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 20963, 21011);

                    f_1009_20963_21010(info, "HasErrorRecord", hasErrorRecord);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 21029, 21151) || true) && (hasErrorRecord)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 21029, 21151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 21089, 21132);

                        f_1009_21089_21131(info, "ErrorRecord", _errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 21029, 21151);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 20850, 21166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 21550, 21590);

                this.SuppressPromptInInterpreter = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 20600, 21601);

                int
                f_1009_20963_21010(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, bool
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 20963, 21010);
                    return 0;
                }


                int
                f_1009_21089_21131(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Management.Automation.ErrorRecord
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 21089, 21131);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 20600, 21601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 20600, 21601);
            }
        }

        public ActionPreferenceStopException(string message)
        : base(f_1009_21948_21955_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 21875, 22514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 24178, 24197);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 21981, 22030);

                f_1009_21981_22029(this, ErrorCategory.OperationStopped);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 22044, 22079);

                f_1009_22044_22078(this, "ActionPreferenceStop");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 22463, 22503);

                this.SuppressPromptInInterpreter = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 21875, 22514);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 21875, 22514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 21875, 22514);
            }
        }

        public ActionPreferenceStopException(string message,
                                                     Exception innerException)
        : base(f_1009_22950_22957_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 22805, 23532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 24178, 24197);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 22999, 23048);

                f_1009_22999_23047(this, ErrorCategory.OperationStopped);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 23062, 23097);

                f_1009_23062_23096(this, "ActionPreferenceStop");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 23481, 23521);

                this.SuppressPromptInInterpreter = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 22805, 23532);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 22805, 23532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 22805, 23532);
            }
        }

        public override ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 24078, 24126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 24084, 24124);

                    return _errorRecord ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ErrorRecord>(1009, 24091, 24123) ?? DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ErrorRecord, 1009, 24107, 24123));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 24078, 24126);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 24014, 24137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 24014, 24137);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly ErrorRecord _errorRecord;

        static ActionPreferenceStopException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 16999, 24236);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 16999, 24236);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 16999, 24236);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 16999, 24236);

        static string
        f_1009_17362_17395()
        {
            var return_v = GetErrorText.ActionPreferenceStop;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 17362, 17395);
            return return_v;
        }


        static string
        f_1009_17362_17395_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 17303, 17418);
            return return_v;
        }


        static string
        f_1009_17808_17830(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = RetrieveMessage(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 17808, 17830);
            return return_v;
        }


        System.ArgumentNullException
        f_1009_17913_17947(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 17913, 17947);
            return return_v;
        }


        static string
        f_1009_17808_17830_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 17730, 18011);
            return return_v;
        }


        int
        f_1009_18441_18491(System.Management.Automation.ErrorRecord
        this_param, System.Management.Automation.InvocationInfo
        invocationInfo)
        {
            this_param.SetInvocationInfo(invocationInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 18441, 18491);
            return 0;
        }


        static string
        f_1009_18408_18415_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 18302, 18503);
            return return_v;
        }


        System.ArgumentNullException
        f_1009_18986_19026(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 18986, 19026);
            return return_v;
        }


        static System.Management.Automation.InvocationInfo
        f_1009_18874_18888_C(System.Management.Automation.InvocationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 18647, 19096);
            return return_v;
        }


        bool
        f_1009_19758_19791(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetBoolean(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 19758, 19791);
            return return_v;
        }


        object?
        f_1009_19871_19920(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 19871, 19920);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_19697_19701_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 19530, 20356);
            return return_v;
        }


        int
        f_1009_21981_22029(System.Management.Automation.ActionPreferenceStopException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 21981, 22029);
            return 0;
        }


        int
        f_1009_22044_22078(System.Management.Automation.ActionPreferenceStopException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 22044, 22078);
            return 0;
        }


        static string
        f_1009_21948_21955_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 21875, 22514);
            return return_v;
        }


        int
        f_1009_22999_23047(System.Management.Automation.ActionPreferenceStopException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 22999, 23047);
            return 0;
        }


        int
        f_1009_23062_23096(System.Management.Automation.ActionPreferenceStopException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 23062, 23096);
            return 0;
        }


        static string
        f_1009_22950_22957_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 22805, 23532);
            return return_v;
        }

    }
    [Serializable]
    public class ParentContainsErrorRecordException : SystemException
    {
        public ParentContainsErrorRecordException(Exception wrapperException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 25475, 25617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28657, 28674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28700, 28708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 25569, 25606);

                _wrapperException = wrapperException;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 25475, 25617);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 25475, 25617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 25475, 25617);
            }
        }

        public ParentContainsErrorRecordException(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 25895, 26007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28657, 28674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28700, 28708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 25977, 25996);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 25895, 26007);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 25895, 26007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 25895, 26007);
            }
        }

        public ParentContainsErrorRecordException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 26208, 26295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28657, 28674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28700, 28708);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 26208, 26295);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 26208, 26295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 26208, 26295);
            }
        }

        public ParentContainsErrorRecordException(string message,
                                                          Exception innerException)
        : base(f_1009_26746_26753_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 26591, 26825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28657, 28674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28700, 28708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 26795, 26814);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 26591, 26825);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 26591, 26825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 26591, 26825);
            }
        }

        protected ParentContainsErrorRecordException(
                    SerializationInfo info, StreamingContext context)
        : base(f_1009_27505_27509_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 27368, 27627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28657, 28674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28700, 28708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 27544, 27616);

                _message = f_1009_27555_27615(info, "ParentContainsErrorRecordException_Message");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 27368, 27627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 27368, 27627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 27368, 27627);
            }
        }

        public override string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 27822, 27976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 27858, 27961);

                    return _message ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1009, 27865, 27960) ?? (_message = (DynAbs.Tracing.TraceSender.Conditional_F1(1009, 27889, 27916) || (((_wrapperException != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1009, 27919, 27944)) || DynAbs.Tracing.TraceSender.Conditional_F3(1009, 27947, 27959))) ? f_1009_27919_27944(_wrapperException) : string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 27822, 27976);

                    string
                    f_1009_27919_27944(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 27919, 27944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 27767, 27987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 27767, 27987);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 28221, 28586);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28330, 28437) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 28330, 28437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28380, 28422);

                    throw f_1009_28386_28421("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 28330, 28437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28453, 28487);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1009, 28453, 28486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 28501, 28575);

                f_1009_28501_28574(info, "ParentContainsErrorRecordException_Message", f_1009_28561_28573(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 28221, 28586);

                System.Management.Automation.PSArgumentNullException
                f_1009_28386_28421(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 28386, 28421);
                    return return_v;
                }


                string
                f_1009_28561_28573(System.Management.Automation.ParentContainsErrorRecordException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 28561, 28573);
                    return return_v;
                }


                int
                f_1009_28501_28574(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 28501, 28574);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 28221, 28586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 28221, 28586);
            }
        }

        private readonly Exception _wrapperException;

        private string _message;

        static ParentContainsErrorRecordException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 24796, 28738);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 24796, 28738);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 24796, 28738);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 24796, 28738);

        static string
        f_1009_26746_26753_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 26591, 26825);
            return return_v;
        }


        string?
        f_1009_27555_27615(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 27555, 27615);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_27505_27509_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 27368, 27627);
            return return_v;
        }

    }
    [Serializable]
    public class RedirectedException : RuntimeException
    {
        public RedirectedException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 29499, 29678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 29574, 29608);

                f_1009_29574_29607(this, "RedirectedException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 29622, 29667);

                f_1009_29622_29666(this, ErrorCategory.NotSpecified);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 29499, 29678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 29499, 29678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 29499, 29678);
            }
        }

        public RedirectedException(string message)
        : base(f_1009_29971_29978_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 29908, 30108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 30004, 30038);

                f_1009_30004_30037(this, "RedirectedException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 30052, 30097);

                f_1009_30052_30096(this, ErrorCategory.NotSpecified);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 29908, 30108);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 29908, 30108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 29908, 30108);
            }
        }

        public RedirectedException(string message,
                                           Exception innerException)
        : base(f_1009_30514_30521_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 30389, 30667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 30563, 30597);

                f_1009_30563_30596(this, "RedirectedException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 30611, 30656);

                f_1009_30611_30655(this, ErrorCategory.NotSpecified);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 30389, 30667);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 30389, 30667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 30389, 30667);
            }
        }

        protected RedirectedException(SerializationInfo info,
                                              StreamingContext context)
        : base(f_1009_31207_31211_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 31060, 31243);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 31060, 31243);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 31060, 31243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 31060, 31243);
            }
        }

        static RedirectedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 29207, 31283);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 29207, 31283);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 29207, 31283);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 29207, 31283);

        int
        f_1009_29574_29607(System.Management.Automation.RedirectedException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 29574, 29607);
            return 0;
        }


        int
        f_1009_29622_29666(System.Management.Automation.RedirectedException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 29622, 29666);
            return 0;
        }


        int
        f_1009_30004_30037(System.Management.Automation.RedirectedException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 30004, 30037);
            return 0;
        }


        int
        f_1009_30052_30096(System.Management.Automation.RedirectedException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 30052, 30096);
            return 0;
        }


        static string
        f_1009_29971_29978_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 29908, 30108);
            return return_v;
        }


        int
        f_1009_30563_30596(System.Management.Automation.RedirectedException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 30563, 30596);
            return 0;
        }


        int
        f_1009_30611_30655(System.Management.Automation.RedirectedException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 30611, 30655);
            return 0;
        }


        static string
        f_1009_30514_30521_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 30389, 30667);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_31207_31211_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 31060, 31243);
            return return_v;
        }

    }
    [Serializable]
    public class ScriptCallDepthException : SystemException, IContainsErrorRecord
    {
        public ScriptCallDepthException()
        : base(f_1009_32347_32384_C(f_1009_32347_32384()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 32293, 32407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 35177, 35196);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 32293, 32407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 32293, 32407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 32293, 32407);
            }
        }

        public ScriptCallDepthException(string message)
        : base(f_1009_32710_32717_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 32642, 32740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 35177, 35196);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 32642, 32740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 32642, 32740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 32642, 32740);
            }
        }

        public ScriptCallDepthException(string message,
                                                Exception innerException)
        : base(f_1009_33165_33172_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 33026, 33211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 35177, 35196);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 33026, 33211);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 33026, 33211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 33026, 33211);
            }
        }

        protected ScriptCallDepthException(SerializationInfo info,
                                                   StreamingContext context)
        : base(f_1009_33814_33818_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 33665, 33850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 35177, 35196);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 33665, 33850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 33665, 33850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 33665, 33850);
            }
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override
                void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 34082, 34329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 34284, 34318);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1009, 34284, 34317);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 34082, 34329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 34082, 34329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 34082, 34329);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 34716, 35134);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 34752, 35079) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 34752, 35079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 34818, 35060);

                        _errorRecord = f_1009_34833_35059(f_1009_34875_34919(this), "CallDepthOverflow", ErrorCategory.InvalidOperation, f_1009_35049_35058());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 34752, 35079);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 35099, 35119);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 34716, 35134);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1009_34875_34919(System.Management.Automation.ScriptCallDepthException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 34875, 34919);
                        return return_v;
                    }


                    int
                    f_1009_35049_35058()
                    {
                        var return_v = CallDepth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 35049, 35058);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1009_34833_35059(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, int
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 34833, 35059);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 34661, 35145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 34661, 35145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        public int CallDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 35381, 35398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 35387, 35396);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 35381, 35398);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 35336, 35409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 35336, 35409);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ScriptCallDepthException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 31976, 35447);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 31976, 35447);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 31976, 35447);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 31976, 35447);

        static string
        f_1009_32347_32384()
        {
            var return_v = GetErrorText.ScriptCallDepthException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 32347, 32384);
            return return_v;
        }


        static string
        f_1009_32347_32384_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 32293, 32407);
            return return_v;
        }


        static string
        f_1009_32710_32717_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 32642, 32740);
            return return_v;
        }


        static string
        f_1009_33165_33172_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 33026, 33211);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_33814_33818_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 33665, 33850);
            return return_v;
        }

    }
    [Serializable]
    public class PipelineDepthException : SystemException, IContainsErrorRecord
    {
        public PipelineDepthException()
        : base(f_1009_36137_36172_C(f_1009_36137_36172()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 36085, 36195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 39048, 39067);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 36085, 36195);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 36085, 36195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 36085, 36195);
            }
        }

        public PipelineDepthException(string message)
        : base(f_1009_36494_36501_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 36428, 36524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 39048, 39067);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 36428, 36524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 36428, 36524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 36428, 36524);
            }
        }

        public PipelineDepthException(string message,
                                                Exception innerException)
        : base(f_1009_36941_36948_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 36808, 36987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 39048, 39067);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 36808, 36987);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 36808, 36987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 36808, 36987);
            }
        }

        protected PipelineDepthException(SerializationInfo info,
                                                   StreamingContext context)
        : base(f_1009_37586_37590_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 37439, 37622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 39048, 39067);
                this._errorRecord = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 37439, 37622);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 37439, 37622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 37439, 37622);
            }
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override
                void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 37854, 38101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 38056, 38090);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1009, 38056, 38089);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 37854, 38101);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 37854, 38101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 37854, 38101);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 38587, 39005);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 38623, 38950) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1009, 38623, 38950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 38689, 38931);

                        _errorRecord = f_1009_38704_38930(f_1009_38746_38790(this), "CallDepthOverflow", ErrorCategory.InvalidOperation, f_1009_38920_38929());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1009, 38623, 38950);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 38970, 38990);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 38587, 39005);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1009_38746_38790(System.Management.Automation.PipelineDepthException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 38746, 38790);
                        return return_v;
                    }


                    int
                    f_1009_38920_38929()
                    {
                        var return_v = CallDepth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 38920, 38929);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1009_38704_38930(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, int
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 38704, 38930);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 38433, 39016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 38433, 39016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        public int CallDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1009, 39281, 39298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1009, 39287, 39296);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1009, 39281, 39298);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 39236, 39309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 39236, 39309);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PipelineDepthException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 35774, 39347);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 35774, 39347);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 35774, 39347);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 35774, 39347);

        static string
        f_1009_36137_36172()
        {
            var return_v = GetErrorText.PipelineDepthException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 36137, 36172);
            return return_v;
        }


        static string
        f_1009_36137_36172_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 36085, 36195);
            return return_v;
        }


        static string
        f_1009_36494_36501_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 36428, 36524);
            return return_v;
        }


        static string
        f_1009_36941_36948_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 36808, 36987);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_37586_37590_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 37439, 37622);
            return return_v;
        }

    }
    [Serializable]
    public class HaltCommandException : SystemException
    {
        public HaltCommandException()
        : base(f_1009_40308_40368_C(f_1009_40308_40368(f_1009_40326_40367())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 40258, 40391);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 40258, 40391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 40258, 40391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 40258, 40391);
            }
        }

        public HaltCommandException(string message)
        : base(f_1009_40686_40693_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 40622, 40716);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 40622, 40716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 40622, 40716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 40622, 40716);
            }
        }

        public HaltCommandException(string message,
                                            Exception innerException)
        : base(f_1009_41125_41132_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 40998, 41171);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 40998, 41171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 40998, 41171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 40998, 41171);
            }
        }

        protected HaltCommandException(SerializationInfo info,
                                               StreamingContext context)
        : base(f_1009_41762_41766_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1009, 41621, 41798);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1009, 41621, 41798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1009, 41621, 41798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 41621, 41798);
            }
        }

        static HaltCommandException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1009, 39973, 41839);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1009, 39973, 41839);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1009, 39973, 41839);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1009, 39973, 41839);

        static string
        f_1009_40326_40367()
        {
            var return_v = AutomationExceptions.HaltCommandException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1009, 40326, 40367);
            return return_v;
        }


        static string
        f_1009_40308_40368(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1009, 40308, 40368);
            return return_v;
        }


        static string
        f_1009_40308_40368_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 40258, 40391);
            return return_v;
        }


        static string
        f_1009_40686_40693_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 40622, 40716);
            return return_v;
        }


        static string
        f_1009_41125_41132_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 40998, 41171);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1009_41762_41766_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1009, 41621, 41798);
            return return_v;
        }

    }
}

#pragma warning restore 56506
