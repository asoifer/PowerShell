// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class PSObjectDisposedException
                : ObjectDisposedException, IContainsErrorRecord
    {
        public PSObjectDisposedException(string objectName)
        : base(f_1024_1406_1416_C(objectName))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1024, 1334, 1439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4564, 4576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4602, 4629);
                this._errorId = "ObjectDisposed";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1024, 1334, 1439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1024, 1334, 1439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1024, 1334, 1439);
            }
        }

        public PSObjectDisposedException(string objectName, string message)
        : base(f_1024_1813_1823_C(objectName), message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1024, 1721, 1855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4564, 4576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4602, 4629);
                this._errorId = "ObjectDisposed";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1024, 1721, 1855);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1024, 1721, 1855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1024, 1721, 1855);
            }
        }

        public PSObjectDisposedException(string message, Exception innerException)
        : base(f_1024_2236_2243_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1024, 2141, 2282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4564, 4576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4602, 4629);
                this._errorId = "ObjectDisposed";
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1024, 2141, 2282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1024, 2141, 2282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1024, 2141, 2282);
            }
        }

        protected PSObjectDisposedException(SerializationInfo info,
                                                      StreamingContext context)
        : base(f_1024_2898_2902_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1024, 2741, 2985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4564, 4576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4602, 4629);
                this._errorId = "ObjectDisposed";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 2937, 2974);

                _errorId = f_1024_2948_2973(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1024, 2741, 2985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1024, 2741, 2985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1024, 2741, 2985);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1024, 3258, 3677);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 3460, 3567) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1024, 3460, 3567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 3510, 3552);

                    throw f_1024_3516_3551("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1024, 3460, 3567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 3583, 3617);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1024, 3583, 3616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 3631, 3666);

                f_1024_3631_3665(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1024, 3258, 3677);

                System.Management.Automation.PSArgumentNullException
                f_1024_3516_3551(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1024, 3516, 3551);
                    return return_v;
                }


                int
                f_1024_3631_3665(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1024, 3631, 3665);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1024, 3258, 3677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1024, 3258, 3677);
            }
        }

        public ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1024, 4119, 4521);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4155, 4466) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1024, 4155, 4466);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4221, 4447);

                        _errorRecord = f_1024_4236_4446(f_1024_4278_4322(this), _errorId, ErrorCategory.InvalidOperation, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1024, 4155, 4466);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1024, 4486, 4506);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1024, 4119, 4521);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1024_4278_4322(System.Management.Automation.PSObjectDisposedException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1024, 4278, 4322);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1024_4236_4446(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1024, 4236, 4446);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1024, 4064, 4532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1024, 4064, 4532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        static PSObjectDisposedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1024, 716, 4637);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1024, 716, 4637);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1024, 716, 4637);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1024, 716, 4637);

        static string
        f_1024_1406_1416_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1024, 1334, 1439);
            return return_v;
        }


        static string
        f_1024_1813_1823_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1024, 1721, 1855);
            return return_v;
        }


        static string
        f_1024_2236_2243_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1024, 2141, 2282);
            return return_v;
        }


        string?
        f_1024_2948_2973(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1024, 2948, 2973);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1024_2898_2902_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1024, 2741, 2985);
            return return_v;
        }

    }
}

