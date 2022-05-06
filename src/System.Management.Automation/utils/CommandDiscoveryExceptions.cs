// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace System.Management.Automation
{
    [Serializable]
    public class CommandNotFoundException : RuntimeException
    {
        internal CommandNotFoundException(
                    string commandName,
                    Exception innerException,
                    string errorIdAndResourceId,
                    string resourceStr,
                    params object[] messageArgs)
        : base(f_1004_1629_1680_C(f_1004_1629_1680(commandName, resourceStr, messageArgs)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 1385, 1806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4818, 4830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5118, 5145);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5231, 5268);
                this._errorId = "CommandNotFoundException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5301, 5346);
                this._errorCategory = ErrorCategory.ObjectNotFound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 1722, 1749);

                _commandName = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 1763, 1795);

                _errorId = errorIdAndResourceId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 1385, 1806);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 1385, 1806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 1385, 1806);
            }
        }

        public CommandNotFoundException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 1917, 1964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4818, 4830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5118, 5145);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5231, 5268);
                this._errorId = "CommandNotFoundException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5301, 5346);
                this._errorCategory = ErrorCategory.ObjectNotFound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 1961, 1962);
                ;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 1917, 1964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 1917, 1964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 1917, 1964);
            }
        }

        public CommandNotFoundException(string message) : base(f_1004_2236_2243_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 2181, 2249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4818, 4830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5118, 5145);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5231, 5268);
                this._errorId = "CommandNotFoundException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5301, 5346);
                this._errorCategory = ErrorCategory.ObjectNotFound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 2246, 2247);
                ;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 2181, 2249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 2181, 2249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 2181, 2249);
            }
        }

        public CommandNotFoundException(string message, Exception innerException) : base(f_1004_2666_2673_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 2585, 2695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4818, 4830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5118, 5145);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5231, 5268);
                this._errorId = "CommandNotFoundException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5301, 5346);
                this._errorCategory = ErrorCategory.ObjectNotFound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 2692, 2693);
                ;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 2585, 2695);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 2585, 2695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 2585, 2695);
            }
        }

        protected CommandNotFoundException(SerializationInfo info,
                                                StreamingContext context)
        : base(f_1004_3189_3193_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 3043, 3407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4818, 4830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5118, 5145);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5231, 5268);
                this._errorId = "CommandNotFoundException";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5301, 5346);
                this._errorCategory = ErrorCategory.ObjectNotFound;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 3228, 3335) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 3228, 3335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 3278, 3320);

                    throw f_1004_3284_3319("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 3228, 3335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 3351, 3396);

                _commandName = f_1004_3366_3395(info, "CommandName");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 3043, 3407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 3043, 3407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 3043, 3407);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 3703, 4130);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 3905, 4012) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 3905, 4012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 3955, 3997);

                    throw f_1004_3961_3996("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 3905, 4012);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4028, 4062);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1004, 4028, 4061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4076, 4119);

                f_1004_4076_4118(info, "CommandName", _commandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 3703, 4130);

                System.Management.Automation.PSArgumentNullException
                f_1004_3961_3996(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 3961, 3996);
                    return return_v;
                }


                int
                f_1004_4076_4118(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 4076, 4118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 3703, 4130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 3703, 4130);
            }
        }

        public override ErrorRecord ErrorRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 4381, 4775);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4417, 4720) || true) && (_errorRecord == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 4417, 4720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4483, 4701);

                        _errorRecord = f_1004_4498_4700(f_1004_4540_4584(this), _errorId, _errorCategory, _commandName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 4417, 4720);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 4740, 4760);

                    return _errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 4381, 4775);

                    System.Management.Automation.ParentContainsErrorRecordException
                    f_1004_4540_4584(System.Management.Automation.CommandNotFoundException
                    wrapperException)
                    {
                        var return_v = new System.Management.Automation.ParentContainsErrorRecordException((System.Exception)wrapperException);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 4540, 4584);
                        return return_v;
                    }


                    System.Management.Automation.ErrorRecord
                    f_1004_4498_4700(System.Management.Automation.ParentContainsErrorRecordException
                    exception, string
                    errorId, System.Management.Automation.ErrorCategory
                    errorCategory, string
                    targetObject)
                    {
                        var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 4498, 4700);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 4317, 4786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 4317, 4786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorRecord _errorRecord;

        public string CommandName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 5007, 5035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5013, 5033);

                    return _commandName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 5007, 5035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 4957, 5091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 4957, 5091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 5051, 5080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5057, 5078);

                    _commandName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 5051, 5080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 4957, 5091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 4957, 5091);
                }
            }
        }

        private string _commandName;

        private string _errorId;

        private ErrorCategory _errorCategory;

        private static string BuildMessage(
                    string commandName,
                    string resourceStr,
                    params object[] messageArgs
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1004, 5359, 5972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5541, 5552);

                object[]
                a
                = default(object[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5566, 5904) || true) && (messageArgs != null && (DynAbs.Tracing.TraceSender.Expression_True(1004, 5570, 5615) && 0 < f_1004_5597_5615(messageArgs)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 5566, 5904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5649, 5688);

                    a = new object[f_1004_5664_5682(messageArgs) + 1];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5706, 5725);

                    a[0] = commandName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5743, 5768);

                    f_1004_5743_5767(messageArgs, a, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 5566, 5904);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 5566, 5904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5834, 5852);

                    a = new object[1];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5870, 5889);

                    a[0] = commandName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 5566, 5904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 5920, 5961);

                return f_1004_5927_5960(resourceStr, a);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1004, 5359, 5972);

                int
                f_1004_5597_5615(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 5597, 5615);
                    return return_v;
                }


                int
                f_1004_5664_5682(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 5664, 5682);
                    return return_v;
                }


                int
                f_1004_5743_5767(object[]
                this_param, object[]
                array, int
                index)
                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 5743, 5767);
                    return 0;
                }


                string
                f_1004_5927_5960(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 5927, 5960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 5359, 5972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 5359, 5972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandNotFoundException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1004, 432, 6007);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1004, 432, 6007);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 432, 6007);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1004, 432, 6007);

        static string
        f_1004_1629_1680(string
        commandName, string
        resourceStr, params object[]
        messageArgs)
        {
            var return_v = BuildMessage(commandName, resourceStr, messageArgs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 1629, 1680);
            return return_v;
        }


        static string
        f_1004_1629_1680_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 1385, 1806);
            return return_v;
        }


        static string
        f_1004_2236_2243_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 2181, 2249);
            return return_v;
        }


        static string
        f_1004_2666_2673_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 2585, 2695);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1004_3284_3319(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 3284, 3319);
            return return_v;
        }


        string?
        f_1004_3366_3395(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 3366, 3395);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1004_3189_3193_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 3043, 3407);
            return return_v;
        }

    }
    [Serializable]
    public class ScriptRequiresException : RuntimeException
    {
        internal ScriptRequiresException(
                    string commandName,
                    string requiresShellId,
                    string requiresShellPath,
                    string errorId)
        : base(f_1004_7186_7253_C(f_1004_7186_7253(commandName, requiresShellId, requiresShellPath, true)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 6994, 7855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7279, 7408);

                f_1004_7279_7407(!f_1004_7299_7332(commandName), "commandName is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7422, 7543);

                f_1004_7422_7542(!f_1004_7442_7471(errorId), "errorId is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7557, 7584);

                _commandName = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7598, 7633);

                _requiresShellId = requiresShellId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7647, 7686);

                _requiresShellPath = requiresShellPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7700, 7725);

                f_1004_7700_7724(this, errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7739, 7773);

                f_1004_7739_7772(this, commandName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 7787, 7844);

                f_1004_7787_7843(this, ErrorCategory.ResourceUnavailable);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 6994, 7855);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 6994, 7855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 6994, 7855);
            }
        }

        internal ScriptRequiresException(
                    string commandName,
                    Version requiresPSVersion,
                    string currentPSVersion,
                    string errorId)
        : base(f_1004_8700_8780_C(f_1004_8700_8780(commandName, f_1004_8726_8754(requiresPSVersion), currentPSVersion, false)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 8506, 9473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 8806, 8935);

                f_1004_8806_8934(!f_1004_8826_8859(commandName), "commandName is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 8949, 9075);

                f_1004_8949_9074(requiresPSVersion != null, "requiresPSVersion is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 9089, 9210);

                f_1004_9089_9209(!f_1004_9109_9138(errorId), "errorId is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 9224, 9251);

                _commandName = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 9265, 9304);

                _requiresPSVersion = requiresPSVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 9318, 9343);

                f_1004_9318_9342(this, errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 9357, 9391);

                f_1004_9357_9390(this, commandName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 9405, 9462);

                f_1004_9405_9461(this, ErrorCategory.ResourceUnavailable);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 8506, 9473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 8506, 9473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 8506, 9473);
            }
        }

        internal ScriptRequiresException(
                    string commandName,
                    Collection<string> missingItems,
                    string errorId,
                    bool forSnapins)
        : this(f_1004_10423_10434_C(commandName), missingItems, errorId, forSnapins, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 10231, 10498);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 10231, 10498);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 10231, 10498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 10231, 10498);
            }
        }

        internal ScriptRequiresException(
                    string commandName,
                    Collection<string> missingItems,
                    string errorId,
                    bool forSnapins,
                    ErrorRecord errorRecord)
        : base(f_1004_11598_11649_C(f_1004_11598_11649(commandName, missingItems, forSnapins)), null, errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 11368, 12403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 11694, 11823);

                f_1004_11694_11822(!f_1004_11714_11747(commandName), "commandName is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 11837, 11979);

                f_1004_11837_11978(missingItems != null && (DynAbs.Tracing.TraceSender.Expression_True(1004, 11856, 11902) && f_1004_11880_11898(missingItems) > 0), "missingItems is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 11993, 12114);

                f_1004_11993_12113(!f_1004_12013_12042(errorId), "errorId is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 12128, 12155);

                _commandName = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 12169, 12234);

                _missingPSSnapIns = f_1004_12189_12233(missingItems);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 12248, 12273);

                f_1004_12248_12272(this, errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 12287, 12321);

                f_1004_12287_12320(this, commandName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 12335, 12392);

                f_1004_12335_12391(this, ErrorCategory.ResourceUnavailable);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 11368, 12403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 11368, 12403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 11368, 12403);
            }
        }

        internal ScriptRequiresException(
                    string commandName,
                    string errorId)
        : base(f_1004_12964_12989_C(f_1004_12964_12989(commandName)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 12848, 13486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13015, 13144);

                f_1004_13015_13143(!f_1004_13035_13068(commandName), "commandName is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13158, 13279);

                f_1004_13158_13278(!f_1004_13178_13207(errorId), "errorId is null or empty when constructing ScriptRequiresException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13293, 13320);

                _commandName = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13334, 13359);

                f_1004_13334_13358(this, errorId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13373, 13407);

                f_1004_13373_13406(this, commandName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13421, 13475);

                f_1004_13421_13474(this, ErrorCategory.PermissionDenied);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 12848, 13486);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 12848, 13486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 12848, 13486);
            }
        }

        public ScriptRequiresException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 13605, 13651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13648, 13649);
                ;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 13605, 13651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 13605, 13651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 13605, 13651);
            }
        }

        public ScriptRequiresException(string message) : base(f_1004_13930_13937_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 13876, 13943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 13940, 13941);
                ;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 13876, 13943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 13876, 13943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 13876, 13943);
            }
        }

        public ScriptRequiresException(string message, Exception innerException) : base(f_1004_14368_14375_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 14288, 14397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 14394, 14395);
                ;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 14288, 14397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 14288, 14397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 14288, 14397);
            }
        }

        protected ScriptRequiresException(SerializationInfo info,
                                                StreamingContext context)
        : base(f_1004_14897_14901_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1004, 14752, 15358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16725, 16752);
                this._commandName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17000, 17018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17309, 17382);
                this._missingPSSnapIns = f_1004_17329_17382(f_1004_17360_17381());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17613, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17879, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 14936, 14981);

                _commandName = f_1004_14951_14980(info, "CommandName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 14995, 15077);

                _requiresPSVersion = (Version)f_1004_15025_15076(info, "RequiresPSVersion", typeof(Version));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 15091, 15209);

                _missingPSSnapIns = (ReadOnlyCollection<string>)f_1004_15139_15208(info, "MissingPSSnapIns", typeof(ReadOnlyCollection<string>));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 15223, 15276);

                _requiresShellId = f_1004_15242_15275(info, "RequiresShellId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 15290, 15347);

                _requiresShellPath = f_1004_15311_15346(info, "RequiresShellPath");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1004, 14752, 15358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 14752, 15358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 14752, 15358);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 15655, 16405);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 15857, 15964) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 15857, 15964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 15907, 15949);

                    throw f_1004_15913_15948("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 15857, 15964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 15980, 16014);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1004, 15980, 16013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16028, 16071);

                f_1004_16028_16070(info, "CommandName", _commandName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16085, 16157);

                f_1004_16085_16156(info, "RequiresPSVersion", _requiresPSVersion, typeof(Version));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16171, 16260);

                f_1004_16171_16259(info, "MissingPSSnapIns", _missingPSSnapIns, typeof(ReadOnlyCollection<string>));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16274, 16325);

                f_1004_16274_16324(info, "RequiresShellId", _requiresShellId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16339, 16394);

                f_1004_16339_16393(info, "RequiresShellPath", _requiresShellPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 15655, 16405);

                System.Management.Automation.PSArgumentNullException
                f_1004_15913_15948(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 15913, 15948);
                    return return_v;
                }


                int
                f_1004_16028_16070(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 16028, 16070);
                    return 0;
                }


                int
                f_1004_16085_16156(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Version
                value, System.Type
                type)
                {
                    this_param.AddValue(name, (object)value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 16085, 16156);
                    return 0;
                }


                int
                f_1004_16171_16259(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Collections.ObjectModel.ReadOnlyCollection<string>
                value, System.Type
                type)
                {
                    this_param.AddValue(name, (object)value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 16171, 16259);
                    return 0;
                }


                int
                f_1004_16274_16324(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 16274, 16324);
                    return 0;
                }


                int
                f_1004_16339_16393(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 16339, 16393);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 15655, 16405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 15655, 16405);
            }
        }

        public string CommandName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 16659, 16687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16665, 16685);

                    return _commandName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 16659, 16687);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 16609, 16698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 16609, 16698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _commandName;

        public Version RequiresPSVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 16927, 16961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 16933, 16959);

                    return _requiresPSVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 16927, 16961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 16870, 16972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 16870, 16972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Version _requiresPSVersion;

        public ReadOnlyCollection<string> MissingPSSnapIns
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 17218, 17251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17224, 17249);

                    return _missingPSSnapIns;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 17218, 17251);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 17143, 17262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 17143, 17262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReadOnlyCollection<string> _missingPSSnapIns;

        public string RequiresShellId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 17543, 17575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17549, 17573);

                    return _requiresShellId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 17543, 17575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 17489, 17586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 17489, 17586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _requiresShellId;

        public string RequiresShellPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1004, 17807, 17841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 17813, 17839);

                    return _requiresShellPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1004, 17807, 17841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 17751, 17852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 17751, 17852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _requiresShellPath;

        private static string BuildMessage(
                    string commandName,
                    Collection<string> missingItems,
                    bool forSnapins)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1004, 17970, 19060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18139, 18178);

                StringBuilder
                sb = f_1004_18158_18177()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18192, 18326) || true) && (missingItems == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 18192, 18326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18250, 18311);

                    throw f_1004_18256_18310("missingItems");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 18192, 18326);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18342, 18470);
                    foreach (string missingItem in f_1004_18373_18385_I(missingItems))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 18342, 18470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18419, 18455);

                        f_1004_18419_18454(f_1004_18419_18441(sb, missingItem), ", ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 18342, 18470);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1004, 1, 129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1004, 1, 129);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18486, 18580) || true) && (f_1004_18490_18499(sb) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 18486, 18580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18537, 18565);

                    f_1004_18537_18564(sb, f_1004_18547_18556(sb) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 18486, 18580);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18596, 19049) || true) && (forSnapins)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 18596, 19049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18644, 18807);

                    return f_1004_18651_18806(f_1004_18691_18735(), commandName, f_1004_18792_18805(sb));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 18596, 19049);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 18596, 19049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 18873, 19034);

                    return f_1004_18880_19033(f_1004_18920_18962(), commandName, f_1004_19019_19032(sb));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 18596, 19049);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1004, 17970, 19060);

                System.Text.StringBuilder
                f_1004_18158_18177()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18158, 18177);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1004_18256_18310(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18256, 18310);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1004_18419_18441(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18419, 18441);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1004_18419_18454(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18419, 18454);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1004_18373_18385_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18373, 18385);
                    return return_v;
                }


                int
                f_1004_18490_18499(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 18490, 18499);
                    return return_v;
                }


                int
                f_1004_18547_18556(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 18547, 18556);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1004_18537_18564(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18537, 18564);
                    return return_v;
                }


                string
                f_1004_18691_18735()
                {
                    var return_v = DiscoveryExceptions.RequiresMissingPSSnapIns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 18691, 18735);
                    return return_v;
                }


                string
                f_1004_18792_18805(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18792, 18805);
                    return return_v;
                }


                string
                f_1004_18651_18806(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18651, 18806);
                    return return_v;
                }


                string
                f_1004_18920_18962()
                {
                    var return_v = DiscoveryExceptions.RequiresMissingModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 18920, 18962);
                    return return_v;
                }


                string
                f_1004_19019_19032(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 19019, 19032);
                    return return_v;
                }


                string
                f_1004_18880_19033(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 18880, 19033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 17970, 19060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 17970, 19060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string BuildMessage(
                    string commandName,
                    string first,
                    string second,
                    bool forShellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1004, 19072, 20041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 19250, 19276);

                string
                resourceStr = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 19292, 19948) || true) && (forShellId)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 19292, 19948);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 19340, 19802) || true) && (f_1004_19344_19371(first))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 19340, 19802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 19413, 19484);

                        resourceStr = f_1004_19427_19483();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 19340, 19802);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 19340, 19802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 19566, 19783);

                        resourceStr = (DynAbs.Tracing.TraceSender.Conditional_F1(1004, 19580, 19608) || ((f_1004_19580_19608(second) && DynAbs.Tracing.TraceSender.Conditional_F2(1004, 19640, 19698)) || DynAbs.Tracing.TraceSender.Conditional_F3(1004, 19730, 19782))) ? f_1004_19640_19698() : f_1004_19730_19782();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 19340, 19802);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 19292, 19948);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1004, 19292, 19948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 19868, 19933);

                    resourceStr = f_1004_19882_19932();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1004, 19292, 19948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 19964, 20030);

                return f_1004_19971_20029(resourceStr, commandName, first, second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1004, 19072, 20041);

                bool
                f_1004_19344_19371(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 19344, 19371);
                    return return_v;
                }


                string
                f_1004_19427_19483()
                {
                    var return_v = DiscoveryExceptions.RequiresShellIDInvalidForSingleShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 19427, 19483);
                    return return_v;
                }


                bool
                f_1004_19580_19608(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 19580, 19608);
                    return return_v;
                }


                string
                f_1004_19640_19698()
                {
                    var return_v = DiscoveryExceptions.RequiresInterpreterNotCompatibleNoPath
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 19640, 19698);
                    return return_v;
                }


                string
                f_1004_19730_19782()
                {
                    var return_v = DiscoveryExceptions.RequiresInterpreterNotCompatible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 19730, 19782);
                    return return_v;
                }


                string
                f_1004_19882_19932()
                {
                    var return_v = DiscoveryExceptions.RequiresPSVersionNotCompatible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 19882, 19932);
                    return return_v;
                }


                string
                f_1004_19971_20029(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 19971, 20029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 19072, 20041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 19072, 20041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string BuildMessage(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1004, 20053, 20220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1004, 20132, 20209);

                return f_1004_20139_20208(f_1004_20157_20194(), commandName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1004, 20053, 20220);

                string
                f_1004_20157_20194()
                {
                    var return_v = DiscoveryExceptions.RequiresElevation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 20157, 20194);
                    return return_v;
                }


                string
                f_1004_20139_20208(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 20139, 20208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1004, 20053, 20220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 20053, 20220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ScriptRequiresException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1004, 6186, 20257);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1004, 6186, 20257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1004, 6186, 20257);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1004, 6186, 20257);

        static string
        f_1004_7186_7253(string
        commandName, string
        first, string
        second, bool
        forShellId)
        {
            var return_v = BuildMessage(commandName, first, second, forShellId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7186, 7253);
            return return_v;
        }


        bool
        f_1004_7299_7332(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7299, 7332);
            return return_v;
        }


        int
        f_1004_7279_7407(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7279, 7407);
            return 0;
        }


        bool
        f_1004_7442_7471(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7442, 7471);
            return return_v;
        }


        int
        f_1004_7422_7542(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7422, 7542);
            return 0;
        }


        int
        f_1004_7700_7724(System.Management.Automation.ScriptRequiresException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7700, 7724);
            return 0;
        }


        int
        f_1004_7739_7772(System.Management.Automation.ScriptRequiresException
        this_param, string
        targetObject)
        {
            this_param.SetTargetObject((object)targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7739, 7772);
            return 0;
        }


        int
        f_1004_7787_7843(System.Management.Automation.ScriptRequiresException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 7787, 7843);
            return 0;
        }


        static string
        f_1004_7186_7253_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 6994, 7855);
            return return_v;
        }


        static string
        f_1004_8726_8754(System.Version
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 8726, 8754);
            return return_v;
        }


        static string
        f_1004_8700_8780(string
        commandName, string
        first, string
        second, bool
        forShellId)
        {
            var return_v = BuildMessage(commandName, first, second, forShellId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 8700, 8780);
            return return_v;
        }


        bool
        f_1004_8826_8859(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 8826, 8859);
            return return_v;
        }


        int
        f_1004_8806_8934(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 8806, 8934);
            return 0;
        }


        int
        f_1004_8949_9074(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 8949, 9074);
            return 0;
        }


        bool
        f_1004_9109_9138(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 9109, 9138);
            return return_v;
        }


        int
        f_1004_9089_9209(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 9089, 9209);
            return 0;
        }


        int
        f_1004_9318_9342(System.Management.Automation.ScriptRequiresException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 9318, 9342);
            return 0;
        }


        int
        f_1004_9357_9390(System.Management.Automation.ScriptRequiresException
        this_param, string
        targetObject)
        {
            this_param.SetTargetObject((object)targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 9357, 9390);
            return 0;
        }


        int
        f_1004_9405_9461(System.Management.Automation.ScriptRequiresException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 9405, 9461);
            return 0;
        }


        static string
        f_1004_8700_8780_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 8506, 9473);
            return return_v;
        }


        static string
        f_1004_10423_10434_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 10231, 10498);
            return return_v;
        }


        static string
        f_1004_11598_11649(string
        commandName, System.Collections.ObjectModel.Collection<string>
        missingItems, bool
        forSnapins)
        {
            var return_v = BuildMessage(commandName, missingItems, forSnapins);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 11598, 11649);
            return return_v;
        }


        bool
        f_1004_11714_11747(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 11714, 11747);
            return return_v;
        }


        int
        f_1004_11694_11822(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 11694, 11822);
            return 0;
        }


        int
        f_1004_11880_11898(System.Collections.ObjectModel.Collection<string>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1004, 11880, 11898);
            return return_v;
        }


        int
        f_1004_11837_11978(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 11837, 11978);
            return 0;
        }


        bool
        f_1004_12013_12042(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 12013, 12042);
            return return_v;
        }


        int
        f_1004_11993_12113(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 11993, 12113);
            return 0;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<string>
        f_1004_12189_12233(System.Collections.ObjectModel.Collection<string>
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 12189, 12233);
            return return_v;
        }


        int
        f_1004_12248_12272(System.Management.Automation.ScriptRequiresException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 12248, 12272);
            return 0;
        }


        int
        f_1004_12287_12320(System.Management.Automation.ScriptRequiresException
        this_param, string
        targetObject)
        {
            this_param.SetTargetObject((object)targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 12287, 12320);
            return 0;
        }


        int
        f_1004_12335_12391(System.Management.Automation.ScriptRequiresException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 12335, 12391);
            return 0;
        }


        static string
        f_1004_11598_11649_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 11368, 12403);
            return return_v;
        }


        static string
        f_1004_12964_12989(string
        commandName)
        {
            var return_v = BuildMessage(commandName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 12964, 12989);
            return return_v;
        }


        bool
        f_1004_13035_13068(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 13035, 13068);
            return return_v;
        }


        int
        f_1004_13015_13143(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 13015, 13143);
            return 0;
        }


        bool
        f_1004_13178_13207(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 13178, 13207);
            return return_v;
        }


        int
        f_1004_13158_13278(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 13158, 13278);
            return 0;
        }


        int
        f_1004_13334_13358(System.Management.Automation.ScriptRequiresException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 13334, 13358);
            return 0;
        }


        int
        f_1004_13373_13406(System.Management.Automation.ScriptRequiresException
        this_param, string
        targetObject)
        {
            this_param.SetTargetObject((object)targetObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 13373, 13406);
            return 0;
        }


        int
        f_1004_13421_13474(System.Management.Automation.ScriptRequiresException
        this_param, System.Management.Automation.ErrorCategory
        errorCategory)
        {
            this_param.SetErrorCategory(errorCategory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 13421, 13474);
            return 0;
        }


        static string
        f_1004_12964_12989_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 12848, 13486);
            return return_v;
        }


        static string
        f_1004_13930_13937_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 13876, 13943);
            return return_v;
        }


        static string
        f_1004_14368_14375_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 14288, 14397);
            return return_v;
        }


        string?
        f_1004_14951_14980(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 14951, 14980);
            return return_v;
        }


        object?
        f_1004_15025_15076(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 15025, 15076);
            return return_v;
        }


        object?
        f_1004_15139_15208(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 15139, 15208);
            return return_v;
        }


        string?
        f_1004_15242_15275(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 15242, 15275);
            return return_v;
        }


        string?
        f_1004_15311_15346(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 15311, 15346);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1004_14897_14901_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1004, 14752, 15358);
            return return_v;
        }


        string[]
        f_1004_17360_17381()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 17360, 17381);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<string>
        f_1004_17329_17382(string[]
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1004, 17329, 17382);
            return return_v;
        }

    }
}

