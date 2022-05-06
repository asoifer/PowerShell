// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Language;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class RuntimeException
                : SystemException, IContainsErrorRecord
    {
        public RuntimeException()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1040, 1094, 1163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6268, 6280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6306, 6335);
                this._errorId = "RuntimeException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6368, 6411);
                this._errorCategory = ErrorCategory.NotSpecified;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6437, 6457);
                this._targetObject = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10341, 10364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10377, 10416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11035, 11063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11121, 11132);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1040, 1094, 1163);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 1094, 1163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 1094, 1163);
            }
        }

        protected RuntimeException(SerializationInfo info,
                                   StreamingContext context)
        : base(f_1040_1713_1717_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1040, 1584, 1877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6268, 6280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6306, 6335);
                this._errorId = "RuntimeException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6368, 6411);
                this._errorCategory = ErrorCategory.NotSpecified;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6437, 6457);
                this._targetObject = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10341, 10364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10377, 10416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11035, 11063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11121, 11132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 1752, 1789);

                _errorId = f_1040_1763_1788(info, "ErrorId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 1803, 1866);

                _errorCategory = (ErrorCategory)f_1040_1835_1865(info, "ErrorCategory");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1040, 1584, 1877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 1584, 1877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 1584, 1877);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 2121, 2606);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 2323, 2430) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 2323, 2430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 2373, 2415);

                    throw f_1040_2379_2414("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 2323, 2430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 2446, 2480);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1040, 2446, 2479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 2494, 2529);

                f_1040_2494_2528(info, "ErrorId", _errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 2543, 2595);

                f_1040_2543_2594(info, "ErrorCategory", _errorCategory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 2121, 2606);

                System.Management.Automation.PSArgumentNullException
                f_1040_2379_2414(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 2379, 2414);
                    return return_v;
                }


                int
                f_1040_2494_2528(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 2494, 2528);
                    return 0;
                }


                int
                f_1040_2543_2594(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Management.Automation.ErrorCategory
                value)
                {
                    this_param.AddValue(name, (int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 2543, 2594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 2121, 2606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 2121, 2606);
            }
        }

        public RuntimeException(string message)
        : base(f_1040_2926_2933_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1040, 2866, 2956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6268, 6280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6306, 6335);
                this._errorId = "RuntimeException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6368, 6411);
                this._errorCategory = ErrorCategory.NotSpecified;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6437, 6457);
                this._targetObject = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10341, 10364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10377, 10416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11035, 11063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11121, 11132);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1040, 2866, 2956);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 2866, 2956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 2866, 2956);
            }
        }

        public RuntimeException(string message,
                                        Exception innerException)
        : base(f_1040_3356_3363_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1040, 3233, 3402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6268, 6280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6306, 6335);
                this._errorId = "RuntimeException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6368, 6411);
                this._errorCategory = ErrorCategory.NotSpecified;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6437, 6457);
                this._targetObject = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10341, 10364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10377, 10416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11035, 11063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11121, 11132);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1040, 3233, 3402);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 3233, 3402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 3233, 3402);
            }
        }

        public RuntimeException(string message,
                    Exception innerException,
                    ErrorRecord errorRecord)
        : base(f_1040_3929_3936_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1040, 3788, 4016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6268, 6280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6306, 6335);
                this._errorId = "RuntimeException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6368, 6411);
                this._errorCategory = ErrorCategory.NotSpecified;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6437, 6457);
                this._targetObject = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10341, 10364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10377, 10416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11035, 11063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11121, 11132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 3978, 4005);

                _errorRecord = errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1040, 3788, 4016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 3788, 4016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 3788, 4016);
            }
        }

        internal RuntimeException(ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string errorIdAndResourceId,
                    string message,
                    Exception innerException)
        : base(f_1040_4299_4306_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1040, 4028, 4960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6268, 6280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6306, 6335);
                this._errorId = "RuntimeException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6368, 6411);
                this._errorCategory = ErrorCategory.NotSpecified;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6437, 6457);
                this._targetObject = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10341, 10364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10377, 10416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11035, 11063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11121, 11132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4348, 4380);

                f_1040_4348_4379(this, errorCategory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4394, 4427);

                f_1040_4394_4426(this, errorIdAndResourceId);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4443, 4593) || true) && ((errorPosition == null) && (DynAbs.Tracing.TraceSender.Expression_True(1040, 4447, 4498) && (invocationInfo != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 4443, 4593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4532, 4578);

                    errorPosition = f_1040_4548_4577(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 4443, 4593);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4609, 4644) || true) && (invocationInfo == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 4609, 4644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4637, 4644);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 4609, 4644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4658, 4843);

                _errorRecord = f_1040_4673_4842(f_1040_4705_4749(this), _errorId, _errorCategory, _targetObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 4857, 4949);

                f_1040_4857_4948(_errorRecord, f_1040_4888_4947(f_1040_4907_4931(invocationInfo), errorPosition));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1040, 4028, 4960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 4028, 4960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 4028, 4960);
            }
        }

        public virtual ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 5830, 6225);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 5866, 6170) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 5866, 6170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 5932, 6151);

                        _errorRecord = f_1040_5947_6150(f_1040_5989_6033(this), _errorId, _errorCategory, _targetObject);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 5866, 6170);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6190, 6210);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 5830, 6225);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1040_5989_6033(System.Management.Automation.RuntimeException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 5989, 6033);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1040_5947_6150(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, object
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 5947, 6150);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 5767, 6236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 5767, 6236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        private string _errorId;

        private ErrorCategory _errorCategory;

        private object _targetObject;

        internal void SetErrorId(string errorId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 6825, 7030);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6890, 7019) || true) && (_errorId != errorId)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 6890, 7019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6947, 6966);

                    _errorId = errorId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 6984, 7004);

                    _errorRecord = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 6890, 7019);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 6825, 7030);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 6825, 7030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 6825, 7030);
            }
        }

        internal void SetErrorCategory(ErrorCategory errorCategory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 7445, 7693);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 7529, 7682) || true) && (_errorCategory != errorCategory)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 7529, 7682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 7598, 7629);

                    _errorCategory = errorCategory;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 7647, 7667);

                    _errorRecord = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 7529, 7682);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 7445, 7693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 7445, 7693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 7445, 7693);
            }
        }

        internal void SetTargetObject(object targetObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 8045, 8260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8120, 8149);

                _targetObject = targetObject;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8163, 8249) || true) && (_errorRecord != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 8163, 8249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8206, 8249);

                    f_1040_8206_8248(_errorRecord, targetObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 8163, 8249);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 8045, 8260);

                int
                f_1040_8206_8248(System.Management.Automation.ErrorRecord
                this_param, object
                target)
                {
                    this_param.SetTargetObject(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 8206, 8248);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 8045, 8260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 8045, 8260);
            }
        }

        internal static string RetrieveMessage(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1040, 8330, 8845);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8418, 8480) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 8418, 8480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8460, 8480);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 8418, 8480);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8494, 8695) || true) && (null != f_1040_8506_8530(errorRecord) && (DynAbs.Tracing.TraceSender.Expression_True(1040, 8498, 8606) && !f_1040_8552_8606(f_1040_8573_8605(f_1040_8573_8597(errorRecord)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 8494, 8695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8640, 8680);

                    return f_1040_8647_8679(f_1040_8647_8671(errorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 8494, 8695);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8711, 8783) || true) && (f_1040_8715_8736(errorRecord) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 8711, 8783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8763, 8783);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 8711, 8783);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8797, 8834);

                return f_1040_8804_8833(f_1040_8804_8825(errorRecord));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1040, 8330, 8845);

                System.Management.Automation.ErrorDetails
                f_1040_8506_8530(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8506, 8530);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1040_8573_8597(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8573, 8597);
                    return return_v;
                }


                string
                f_1040_8573_8605(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8573, 8605);
                    return return_v;
                }


                bool
                f_1040_8552_8606(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 8552, 8606);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1040_8647_8671(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8647, 8671);
                    return return_v;
                }


                string
                f_1040_8647_8679(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8647, 8679);
                    return return_v;
                }


                System.Exception
                f_1040_8715_8736(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8715, 8736);
                    return return_v;
                }


                System.Exception
                f_1040_8804_8825(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8804, 8825);
                    return return_v;
                }


                string
                f_1040_8804_8833(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 8804, 8833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 8330, 8845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 8330, 8845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string RetrieveMessage(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1040, 8857, 9494);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8933, 8985) || true) && (e == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 8933, 8985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 8965, 8985);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 8933, 8985);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9001, 9055);

                IContainsErrorRecord
                icer = e as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9069, 9121) || true) && (icer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 9069, 9121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9104, 9121);

                    return f_1040_9111_9120(e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 9069, 9121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9135, 9169);

                ErrorRecord
                er = f_1040_9152_9168(icer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9183, 9233) || true) && (er == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 9183, 9233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9216, 9233);

                    return f_1040_9223_9232(e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 9183, 9233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9247, 9281);

                ErrorDetails
                ed = f_1040_9265_9280(er)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9295, 9345) || true) && (ed == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 9295, 9345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9328, 9345);

                    return f_1040_9335_9344(e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 9295, 9345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9359, 9394);

                string
                detailsMessage = f_1040_9383_9393(ed)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9408, 9483);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1040, 9415, 9453) || (((f_1040_9416_9452(detailsMessage)) && DynAbs.Tracing.TraceSender.Conditional_F2(1040, 9456, 9465)) || DynAbs.Tracing.TraceSender.Conditional_F3(1040, 9468, 9482))) ? f_1040_9456_9465(e) : detailsMessage;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1040, 8857, 9494);

                string
                f_1040_9111_9120(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9111, 9120);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1040_9152_9168(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9152, 9168);
                    return return_v;
                }


                string
                f_1040_9223_9232(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9223, 9232);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1040_9265_9280(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9265, 9280);
                    return return_v;
                }


                string
                f_1040_9335_9344(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9335, 9344);
                    return return_v;
                }


                string
                f_1040_9383_9393(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9383, 9393);
                    return return_v;
                }


                bool
                f_1040_9416_9452(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 9416, 9452);
                    return return_v;
                }


                string
                f_1040_9456_9465(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9456, 9465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 8857, 9494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 8857, 9494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception RetrieveException(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1040, 9506, 9707);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9599, 9653) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 9599, 9653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9641, 9653);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 9599, 9653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9667, 9696);

                return f_1040_9674_9695(errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1040, 9506, 9707);

                System.Exception
                f_1040_9674_9695(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 9674, 9695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 9506, 9707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 9506, 9707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool WasThrownFromThrowStatement
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 9830, 9869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9836, 9867);

                    return _thrownByThrowStatement;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 9830, 9869);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 9766, 10316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 9766, 10316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 9885, 10305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9921, 9953);

                    _thrownByThrowStatement = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 9971, 10290) || true) && (_errorRecord != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 9971, 10290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10037, 10109);

                        RuntimeException
                        exception = f_1040_10066_10088(_errorRecord) as RuntimeException
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10131, 10271) || true) && (exception != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1040, 10131, 10271);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10202, 10248);

                            exception.WasThrownFromThrowStatement = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 10131, 10271);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1040, 9971, 10290);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 9885, 10305);

                    System.Exception
                    f_1040_10066_10088(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.Exception;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 10066, 10088);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 9766, 10316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 9766, 10316);
                }
            }
        }

        private bool _thrownByThrowStatement;

        internal bool WasRethrown { get; set; }

        internal bool SuppressPromptInInterpreter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 10894, 10938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10900, 10936);

                    return _suppressPromptInInterpreter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 10894, 10938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 10828, 11010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 10828, 11010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 10954, 10999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 10960, 10997);

                    _suppressPromptInInterpreter = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 10954, 10999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 10828, 11010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 10828, 11010);
                }
            }
        }

        private bool _suppressPromptInInterpreter;

        private Token _errorToken;

        internal Token ErrorToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 11193, 11263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11229, 11248);

                    return _errorToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 11193, 11263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 11143, 11361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 11143, 11361);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1040, 11279, 11350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1040, 11315, 11335);

                    _errorToken = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1040, 11279, 11350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1040, 11143, 11361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 11143, 11361);
                }
            }
        }

        static RuntimeException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1040, 783, 11368);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1040, 783, 11368);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1040, 783, 11368);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1040, 783, 11368);

        string?
        f_1040_1763_1788(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 1763, 1788);
            return return_v;
        }


        int
        f_1040_1835_1865(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetInt32(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 1835, 1865);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1040_1713_1717_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1040, 1584, 1877);
            return return_v;
        }


        static string
        f_1040_2926_2933_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1040, 2866, 2956);
            return return_v;
        }


        static string
        f_1040_3356_3363_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1040, 3233, 3402);
            return return_v;
        }


        static string
        f_1040_3929_3936_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1040, 3788, 4016);
            return return_v;
        }


        int
        f_1040_4348_4379(System.Management.Automation.RuntimeException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 4348, 4379);
            return 0;
        }


        int
        f_1040_4394_4426(System.Management.Automation.RuntimeException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 4394, 4426);
            return 0;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1040_4548_4577(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.ScriptPosition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 4548, 4577);
            return return_v;
        }


        System.Management.Automation.ParentContainsErrorRecordException
        f_1040_4705_4749(System.Management.Automation.RuntimeException
        wrapperException)
        {
            var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 4705, 4749);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1040_4673_4842(System.Management.Automation.ParentContainsErrorRecordException
        exception, string
        errorId, System.Management.Automation.ErrorCategory
        errorCategory, object
        targetObject)
        {
            var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 4673, 4842);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1040_4907_4931(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.MyCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1040, 4907, 4931);
            return return_v;
        }


        System.Management.Automation.InvocationInfo
        f_1040_4888_4947(System.Management.Automation.CommandInfo
        commandInfo, System.Management.Automation.Language.IScriptExtent
        scriptPosition)
        {
            var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 4888, 4947);
            return return_v;
        }


        int
        f_1040_4857_4948(System.Management.Automation.ErrorRecord
        this_param, System.Management.Automation.InvocationInfo
        invocationInfo)
        {
            this_param.SetInvocationInfo(invocationInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1040, 4857, 4948);
            return 0;
        }


        static string
        f_1040_4299_4306_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1040, 4028, 4960);
            return return_v;
        }

    }
}
