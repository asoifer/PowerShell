// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56506

using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Resources;
using System.Runtime.Serialization;
using System.Reflection;
using System.Management.Automation.Language;
using System.Security.Permissions;

namespace System.Management.Automation
{
    /// <summary>
    /// Errors reported by Monad will be in one of these categories.
    /// </summary>
    /// <remarks>
    /// Do not specify ErrorCategory.NotSpecified when creating an
    /// <see cref="System.Management.Automation.ErrorRecord"/>.
    /// Choose the best match from among the other values.
    /// </remarks>
    public enum ErrorCategory
    {
        /// <summary>
        /// No error category is specified, or the error category is invalid.
        /// </summary>
        /// <remarks>
        /// Do not specify ErrorCategory.NotSpecified when creating an
        /// <see cref="System.Management.Automation.ErrorRecord"/>.
        /// Choose the best match from among the other values.
        /// </remarks>
        NotSpecified = 0,

        /// <summary>
        /// </summary>
        OpenError = 1,

        /// <summary>
        /// </summary>
        CloseError = 2,

        /// <summary>
        /// </summary>
        DeviceError = 3,

        /// <summary>
        /// </summary>
        DeadlockDetected = 4,

        /// <summary>
        /// </summary>
        InvalidArgument = 5,

        /// <summary>
        /// </summary>
        InvalidData = 6,

        /// <summary>
        /// </summary>
        InvalidOperation = 7,

        /// <summary>
        /// </summary>
        InvalidResult = 8,

        /// <summary>
        /// </summary>
        InvalidType = 9,

        /// <summary>
        /// </summary>
        MetadataError = 10,

        /// <summary>
        /// </summary>
        NotImplemented = 11,

        /// <summary>
        /// </summary>
        NotInstalled = 12,

        /// <summary>
        /// Object can not be found (file, directory, computer, system resource, etc.)
        /// </summary>
        ObjectNotFound = 13,

        /// <summary>
        /// </summary>
        OperationStopped = 14,

        /// <summary>
        /// </summary>
        OperationTimeout = 15,

        /// <summary>
        /// </summary>
        SyntaxError = 16,

        /// <summary>
        /// </summary>
        ParserError = 17,

        /// <summary>
        /// Operation not permitted.
        /// </summary>
        PermissionDenied = 18,

        /// <summary>
        /// </summary>
        ResourceBusy = 19,

        /// <summary>
        /// </summary>
        ResourceExists = 20,

        /// <summary>
        /// </summary>
        ResourceUnavailable = 21,

        /// <summary>
        /// </summary>
        ReadError = 22,

        /// <summary>
        /// </summary>
        WriteError = 23,

        /// <summary>
        /// A non-Monad command reported an error to its STDERR pipe.
        /// </summary>
        /// <remarks>
        /// The Engine uses this ErrorCategory when it executes a native
        /// console applications and captures the errors reported by the
        /// native application.  Avoid using ErrorCategory.FromStdErr
        /// in other circumstances.
        /// </remarks>
        FromStdErr = 24,

        /// <summary>
        /// Used for security exceptions.
        /// </summary>
        SecurityError = 25,

        /// <summary>
        /// The contract of a protocol is not being followed. Should not happen
        /// with well-behaved components.
        /// </summary>
        ProtocolError = 26,

        /// <summary>
        /// The operation depends on a network connection that cannot be
        /// established or maintained.
        /// </summary>
        ConnectionError = 27,

        /// <summary>
        /// Could not authenticate the user to the service. Could mean that the
        /// credentials are invalid or the authentication system is not
        /// functioning properly.
        /// </summary>
        AuthenticationError = 28,

        /// <summary>
        /// Internal limits prevent the operation from being executed.
        /// </summary>
        LimitsExceeded = 29,

        /// <summary>
        /// Controls on the use of traffic or resources prevent the operation
        /// from being executed.
        /// </summary>
        QuotaExceeded = 30,

        /// <summary>
        /// The operation attempted to use functionality that is currently
        /// disabled.
        /// </summary>
        NotEnabled = 31,
    }
    public class ErrorCategoryInfo
    {
        internal ErrorCategoryInfo(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 5230, 5485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 8120, 8142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 15840, 15852);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 5306, 5431) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 5306, 5431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 5363, 5416);

                    throw f_1271_5369_5415(nameof(errorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 5306, 5431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 5447, 5474);

                _errorRecord = errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 5230, 5485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 5230, 5485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 5230, 5485);
            }
        }

        public ErrorCategory Category
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 5735, 5773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 5741, 5771);

                    return _errorRecord._category;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 5735, 5773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 5681, 5784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 5681, 5784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Activity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 6255, 6925);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 6291, 6447) || true) && (!f_1271_6296_6348(_errorRecord._activityOverride))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 6291, 6447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 6390, 6428);

                        return _errorRecord._activityOverride;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 6291, 6447);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 6467, 6870) || true) && (f_1271_6471_6498(_errorRecord) != null
                    && (DynAbs.Tracing.TraceSender.Expression_True(1271, 6471, 6647) && (f_1271_6532_6569(f_1271_6532_6559(_errorRecord)) is CmdletInfo || (DynAbs.Tracing.TraceSender.Expression_False(1271, 6532, 6646) || f_1271_6587_6624(f_1271_6587_6614(_errorRecord)) is IScriptCommandInfo))
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(1271, 6471, 6737) && !f_1271_6673_6737(f_1271_6694_6736(f_1271_6694_6731(f_1271_6694_6721(_errorRecord))))))
                                        )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 6467, 6870);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 6801, 6851);

                        return f_1271_6808_6850(f_1271_6808_6845(f_1271_6808_6835(_errorRecord)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 6467, 6870);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 6890, 6910);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 6255, 6925);

                    bool
                    f_1271_6296_6348(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 6296, 6348);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1271_6471_6498(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.InvocationInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6471, 6498);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1271_6532_6559(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.InvocationInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6532, 6559);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1271_6532_6569(System.Management.Automation.InvocationInfo
                    this_param)
                    {
                        var return_v = this_param.MyCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6532, 6569);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1271_6587_6614(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.InvocationInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6587, 6614);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1271_6587_6624(System.Management.Automation.InvocationInfo
                    this_param)
                    {
                        var return_v = this_param.MyCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6587, 6624);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1271_6694_6721(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.InvocationInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6694, 6721);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1271_6694_6731(System.Management.Automation.InvocationInfo
                    this_param)
                    {
                        var return_v = this_param.MyCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6694, 6731);
                        return return_v;
                    }


                    string
                    f_1271_6694_6736(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6694, 6736);
                        return return_v;
                    }


                    bool
                    f_1271_6673_6737(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 6673, 6737);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1271_6808_6835(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.InvocationInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6808, 6835);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1271_6808_6845(System.Management.Automation.InvocationInfo
                    this_param)
                    {
                        var return_v = this_param.MyCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6808, 6845);
                        return return_v;
                    }


                    string
                    f_1271_6808_6850(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 6808, 6850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 6208, 7042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 6208, 7042);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 6941, 7031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 6977, 7016);

                    _errorRecord._activityOverride = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 6941, 7031);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 6208, 7042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 6208, 7042);
                }
            }
        }

        public string Reason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 7476, 7980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 7512, 7543);

                    _reasonIsExceptionType = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 7561, 7713) || true) && (!f_1271_7566_7616(_errorRecord._reasonOverride))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 7561, 7713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 7658, 7694);

                        return _errorRecord._reasonOverride;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 7561, 7713);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 7733, 7925) || true) && (f_1271_7737_7759(_errorRecord) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 7733, 7925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 7809, 7839);

                        _reasonIsExceptionType = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 7861, 7906);

                        return f_1271_7868_7905(f_1271_7868_7900(f_1271_7868_7890(_errorRecord)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 7733, 7925);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 7945, 7965);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 7476, 7980);

                    bool
                    f_1271_7566_7616(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 7566, 7616);
                        return return_v;
                    }


                    System.Exception
                    f_1271_7737_7759(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.Exception;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 7737, 7759);
                        return return_v;
                    }


                    System.Exception
                    f_1271_7868_7890(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.Exception;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 7868, 7890);
                        return return_v;
                    }


                    System.Type
                    f_1271_7868_7900(System.Exception
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 7868, 7900);
                        return return_v;
                    }


                    string
                    f_1271_7868_7905(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 7868, 7905);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 7431, 8095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 7431, 8095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 7996, 8084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 8032, 8069);

                    _errorRecord._reasonOverride = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 7996, 8084);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 7431, 8095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 7431, 8095);
                }
            }
        }

        private bool _reasonIsExceptionType;

        public string TargetName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 8656, 9398);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 8692, 8852) || true) && (!f_1271_8697_8751(_errorRecord._targetNameOverride))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 8692, 8852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 8793, 8833);

                        return _errorRecord._targetNameOverride;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 8692, 8852);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 8872, 9343) || true) && (f_1271_8876_8901(_errorRecord) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 8872, 9343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 8951, 8973);

                        string
                        targetInString
                        = default(string);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 9047, 9101);

                            targetInString = f_1271_9064_9100(f_1271_9064_9089(_errorRecord));
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 9146, 9257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 9212, 9234);

                            targetInString = null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 9146, 9257);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 9281, 9324);

                        return f_1271_9288_9323(targetInString);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 8872, 9343);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 9363, 9383);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 8656, 9398);

                    bool
                    f_1271_8697_8751(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 8697, 8751);
                        return return_v;
                    }


                    object
                    f_1271_8876_8901(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.TargetObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 8876, 8901);
                        return return_v;
                    }


                    object
                    f_1271_9064_9089(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.TargetObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 9064, 9089);
                        return return_v;
                    }


                    string?
                    f_1271_9064_9100(object
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 9064, 9100);
                        return return_v;
                    }


                    string
                    f_1271_9288_9323(string
                    s)
                    {
                        var return_v = ErrorRecord.NotNull(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 9288, 9323);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 8607, 9517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 8607, 9517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 9414, 9506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 9450, 9491);

                    _errorRecord._targetNameOverride = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 9414, 9506);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 8607, 9517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 8607, 9517);
                }
            }
        }

        public string TargetType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 10077, 10494);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 10113, 10273) || true) && (!f_1271_10118_10172(_errorRecord._targetTypeOverride))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 10113, 10273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 10214, 10254);

                        return _errorRecord._targetTypeOverride;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 10113, 10273);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 10293, 10439) || true) && (f_1271_10297_10322(_errorRecord) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 10293, 10439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 10372, 10420);

                        return f_1271_10379_10419(f_1271_10379_10414(f_1271_10379_10404(_errorRecord)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 10293, 10439);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 10459, 10479);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 10077, 10494);

                    bool
                    f_1271_10118_10172(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 10118, 10172);
                        return return_v;
                    }


                    object
                    f_1271_10297_10322(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.TargetObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 10297, 10322);
                        return return_v;
                    }


                    object
                    f_1271_10379_10404(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.TargetObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 10379, 10404);
                        return return_v;
                    }


                    System.Type
                    f_1271_10379_10414(object
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 10379, 10414);
                        return return_v;
                    }


                    string
                    f_1271_10379_10419(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 10379, 10419);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 10028, 10613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 10028, 10613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 10510, 10602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 10546, 10587);

                    _errorRecord._targetTypeOverride = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 10510, 10602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 10028, 10613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 10028, 10613);
                }
            }
        }

        public string GetMessage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 11756, 12093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 12034, 12082);

                return f_1271_12041_12081(this, f_1271_12052_12080());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 11756, 12093);

                System.Globalization.CultureInfo
                f_1271_12052_12080()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 12052, 12080);
                    return return_v;
                }


                string
                f_1271_12041_12081(System.Management.Automation.ErrorCategoryInfo
                this_param, System.Globalization.CultureInfo
                uiCultureInfo)
                {
                    var return_v = this_param.GetMessage(uiCultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 12041, 12081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 11756, 12093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 11756, 12093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetMessage(CultureInfo uiCultureInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 13264, 15364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 13374, 13423);

                string
                errorCategoryString = f_1271_13403_13422(f_1271_13403_13411())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 13437, 13666) || true) && (f_1271_13441_13482(errorCategoryString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 13437, 13666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 13591, 13651);

                    errorCategoryString = f_1271_13613_13650(ErrorCategory.NotSpecified);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 13437, 13666);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 13682, 13787);

                string
                templateText = f_1271_13704_13786(f_1271_13704_13740(), errorCategoryString, uiCultureInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 13803, 14014) || true) && (f_1271_13807_13841(templateText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 13803, 14014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 13950, 13999);

                    templateText = f_1271_13965_13998();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 13803, 14014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 14030, 14149);

                f_1271_14030_14148(!f_1271_14050_14084(templateText), "ErrorCategoryStrings.resx resource failure");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 14165, 14223);

                string
                activityInUse = f_1271_14188_14222(uiCultureInfo, f_1271_14213_14221())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 14237, 14299);

                string
                targetNameInUse = f_1271_14262_14298(uiCultureInfo, f_1271_14287_14297())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 14313, 14375);

                string
                targetTypeInUse = f_1271_14338_14374(uiCultureInfo, f_1271_14363_14373())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 14477, 14505);

                string
                reasonInUse = f_1271_14498_14504()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 14519, 14610);

                reasonInUse = (DynAbs.Tracing.TraceSender.Conditional_F1(1271, 14533, 14555) || ((_reasonIsExceptionType && DynAbs.Tracing.TraceSender.Conditional_F2(1271, 14558, 14569)) || DynAbs.Tracing.TraceSender.Conditional_F3(1271, 14572, 14609))) ? reasonInUse : f_1271_14572_14609(uiCultureInfo, reasonInUse);

                // assemble final string
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 14700, 14938);

                    return f_1271_14707_14937(uiCultureInfo, templateText, activityInUse, targetNameInUse, targetTypeInUse, reasonInUse, errorCategoryString);
                }
                catch (FormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 14967, 15353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 15023, 15080);

                    templateText = f_1271_15038_15079();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 15100, 15338);

                    return f_1271_15107_15337(uiCultureInfo, templateText, activityInUse, targetNameInUse, targetTypeInUse, reasonInUse, errorCategoryString);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 14967, 15353);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 13264, 15364);

                System.Management.Automation.ErrorCategory
                f_1271_13403_13411()
                {
                    var return_v = Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 13403, 13411);
                    return return_v;
                }


                string
                f_1271_13403_13422(System.Management.Automation.ErrorCategory
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 13403, 13422);
                    return return_v;
                }


                bool
                f_1271_13441_13482(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 13441, 13482);
                    return return_v;
                }


                string
                f_1271_13613_13650(System.Management.Automation.ErrorCategory
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 13613, 13650);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_1271_13704_13740()
                {
                    var return_v = ErrorCategoryStrings.ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 13704, 13740);
                    return return_v;
                }


                string?
                f_1271_13704_13786(System.Resources.ResourceManager
                this_param, string
                name, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.GetString(name, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 13704, 13786);
                    return return_v;
                }


                bool
                f_1271_13807_13841(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 13807, 13841);
                    return return_v;
                }


                string
                f_1271_13965_13998()
                {
                    var return_v = ErrorCategoryStrings.NotSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 13965, 13998);
                    return return_v;
                }


                bool
                f_1271_14050_14084(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 14050, 14084);
                    return return_v;
                }


                int
                f_1271_14030_14148(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 14030, 14148);
                    return 0;
                }


                string
                f_1271_14213_14221()
                {
                    var return_v = Activity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 14213, 14221);
                    return return_v;
                }


                string
                f_1271_14188_14222(System.Globalization.CultureInfo
                uiCultureInfo, string
                original)
                {
                    var return_v = Ellipsize(uiCultureInfo, original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 14188, 14222);
                    return return_v;
                }


                string
                f_1271_14287_14297()
                {
                    var return_v = TargetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 14287, 14297);
                    return return_v;
                }


                string
                f_1271_14262_14298(System.Globalization.CultureInfo
                uiCultureInfo, string
                original)
                {
                    var return_v = Ellipsize(uiCultureInfo, original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 14262, 14298);
                    return return_v;
                }


                string
                f_1271_14363_14373()
                {
                    var return_v = TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 14363, 14373);
                    return return_v;
                }


                string
                f_1271_14338_14374(System.Globalization.CultureInfo
                uiCultureInfo, string
                original)
                {
                    var return_v = Ellipsize(uiCultureInfo, original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 14338, 14374);
                    return return_v;
                }


                string
                f_1271_14498_14504()
                {
                    var return_v = Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 14498, 14504);
                    return return_v;
                }


                string
                f_1271_14572_14609(System.Globalization.CultureInfo
                uiCultureInfo, string
                original)
                {
                    var return_v = Ellipsize(uiCultureInfo, original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 14572, 14609);
                    return return_v;
                }


                string
                f_1271_14707_14937(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 14707, 14937);
                    return return_v;
                }


                string
                f_1271_15038_15079()
                {
                    var return_v = ErrorCategoryStrings.InvalidErrorCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 15038, 15079);
                    return return_v;
                }


                string
                f_1271_15107_15337(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 15107, 15337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 13264, 15364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 13264, 15364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 15594, 15711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 15652, 15700);

                return f_1271_15659_15699(this, f_1271_15670_15698());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 15594, 15711);

                System.Globalization.CultureInfo
                f_1271_15670_15698()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 15670, 15698);
                    return return_v;
                }


                string
                f_1271_15659_15699(System.Management.Automation.ErrorCategoryInfo
                this_param, System.Globalization.CultureInfo
                uiCultureInfo)
                {
                    var return_v = this_param.GetMessage(uiCultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 15659, 15699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 15594, 15711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 15594, 15711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ErrorRecord _errorRecord;

        internal static string Ellipsize(CultureInfo uiCultureInfo, string original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1271, 16673, 17345);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 16774, 16864) || true) && (40 >= f_1271_16784_16799(original))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 16774, 16864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 16833, 16849);

                    return original;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 16774, 16864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 17044, 17072);

                const int
                MaxHalfWidth = 19
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 17086, 17137);

                string
                first = f_1271_17101_17136(original, 0, MaxHalfWidth)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 17151, 17230);

                string
                last = f_1271_17165_17229(original, f_1271_17184_17199(original) - MaxHalfWidth, MaxHalfWidth)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 17244, 17334);

                return
                f_1271_17268_17333(uiCultureInfo, f_1271_17297_17319(), first, last);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1271, 16673, 17345);

                int
                f_1271_16784_16799(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 16784, 16799);
                    return return_v;
                }


                string
                f_1271_17101_17136(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 17101, 17136);
                    return return_v;
                }


                int
                f_1271_17184_17199(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 17184, 17199);
                    return return_v;
                }


                string
                f_1271_17165_17229(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 17165, 17229);
                    return return_v;
                }


                string
                f_1271_17297_17319()
                {
                    var return_v = ErrorPackage.Ellipsize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 17297, 17319);
                    return return_v;
                }


                string
                f_1271_17268_17333(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 17268, 17333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 16673, 17345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 16673, 17345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ErrorCategoryInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1271, 5161, 17380);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1271, 5161, 17380);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 5161, 17380);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1271, 5161, 17380);

        System.ArgumentNullException
        f_1271_5369_5415(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 5369, 5415);
            return return_v;
        }

    }
    [Serializable]
    public class ErrorDetails : ISerializable
    {
        public ErrorDetails(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 18841, 18931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 28631, 28654);
                this._message = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29313, 29346);
                this._recommendedAction = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29615, 29631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 18901, 18920);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 18841, 18931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 18841, 18931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 18841, 18931);
            }
        }

        public ErrorDetails(
                    Cmdlet cmdlet,
                    string baseName,
                    string resourceId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 20929, 21170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 28631, 28654);
                this._message = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29313, 29346);
                this._recommendedAction = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29615, 29631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 21099, 21159);

                _message = f_1271_21110_21158(this, cmdlet, baseName, resourceId, args);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 20929, 21170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 20929, 21170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 20929, 21170);
            }
        }

        public ErrorDetails(
                    IResourceSupplier resourceSupplier,
                    string baseName,
                    string resourceId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 23543, 23815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 28631, 28654);
                this._message = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29313, 29346);
                this._recommendedAction = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29615, 29631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 23734, 23804);

                _message = f_1271_23745_23803(this, resourceSupplier, baseName, resourceId, args);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 23543, 23815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 23543, 23815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 23543, 23815);
            }
        }

        public ErrorDetails(
                    System.Reflection.Assembly assembly,
                    string baseName,
                    string resourceId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 25546, 25811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 28631, 28654);
                this._message = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29313, 29346);
                this._recommendedAction = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29615, 29631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 25738, 25800);

                _message = f_1271_25749_25799(this, assembly, baseName, resourceId, args);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 25546, 25811);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 25546, 25811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 25546, 25811);
            }
        }

        internal ErrorDetails(ErrorDetails errorDetails)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 25891, 26075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 28631, 28654);
                this._message = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29313, 29346);
                this._recommendedAction = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29615, 29631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 25964, 25997);

                _message = errorDetails._message;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 26011, 26064);

                _recommendedAction = errorDetails._recommendedAction;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 25891, 26075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 25891, 26075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 25891, 26075);
            }
        }

        protected ErrorDetails(SerializationInfo info,
                                       StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 26524, 26816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 28631, 28654);
                this._message = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29313, 29346);
                this._recommendedAction = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29615, 29631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 26653, 26703);

                _message = f_1271_26664_26702(info, "ErrorDetails_Message");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 26717, 26805);

                _recommendedAction = f_1271_26738_26804(info, "ErrorDetails_RecommendedAction");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 26524, 26816);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 26524, 26816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 26524, 26816);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 27060, 27492);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 27261, 27481) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 27261, 27481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 27311, 27359);

                    f_1271_27311_27358(info, "ErrorDetails_Message", _message);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 27377, 27466);

                    f_1271_27377_27465(info, "ErrorDetails_RecommendedAction", _recommendedAction);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 27261, 27481);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 27060, 27492);

                int
                f_1271_27311_27358(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 27311, 27358);
                    return 0;
                }


                int
                f_1271_27377_27465(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 27377, 27465);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 27060, 27492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 27060, 27492);
            }
        }

        public string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 28548, 28593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 28554, 28591);

                    return f_1271_28561_28590(_message);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 28548, 28593);

                    string
                    f_1271_28561_28590(string
                    s)
                    {
                        var return_v = ErrorRecord.NotNull(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 28561, 28590);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 28502, 28604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 28502, 28604);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _message;

        public string RecommendedAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 29126, 29181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29132, 29179);

                    return f_1271_29139_29178(_recommendedAction);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 29126, 29181);

                    string
                    f_1271_29139_29178(string
                    s)
                    {
                        var return_v = ErrorRecord.NotNull(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 29139, 29178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 29070, 29286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 29070, 29286);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 29197, 29275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29233, 29260);

                    _recommendedAction = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 29197, 29275);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 29070, 29286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 29070, 29286);
                }
            }
        }

        private string _recommendedAction;

        internal Exception TextLookupError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 29493, 29525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29499, 29523);

                    return _textLookupError;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 29493, 29525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 29434, 29585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 29434, 29585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 29541, 29574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29547, 29572);

                    _textLookupError = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 29541, 29574);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 29434, 29585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 29434, 29585);
                }
            }
        }

        private Exception _textLookupError /* = null */;

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 29888, 29972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 29946, 29961);

                return f_1271_29953_29960();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 29888, 29972);

                string
                f_1271_29953_29960()
                {
                    var return_v = Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 29953, 29960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 29888, 29972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 29888, 29972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string BuildMessage(
                    Cmdlet cmdlet,
                    string baseName,
                    string resourceId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 30038, 31306);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30216, 30344) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 30216, 30344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30268, 30329);

                    throw f_1271_30274_30328(nameof(cmdlet));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 30216, 30344);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30360, 30506) || true) && (f_1271_30364_30394(baseName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 30360, 30506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30428, 30491);

                    throw f_1271_30434_30490(nameof(baseName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 30360, 30506);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30522, 30672) || true) && (f_1271_30526_30558(resourceId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 30522, 30672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30592, 30657);

                    throw f_1271_30598_30656(nameof(resourceId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 30522, 30672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30688, 30719);

                string
                template = string.Empty
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30771, 30829);

                    template = f_1271_30782_30828(cmdlet, baseName, resourceId);
                }
                catch (MissingManifestResourceException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 30858, 31040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30933, 30954);

                    _textLookupError = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 30972, 30992);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 30858, 31040);
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 31054, 31221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31114, 31135);

                    _textLookupError = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31153, 31173);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 31054, 31221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31237, 31295);

                return f_1271_31244_31294(this, template, baseName, resourceId, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 30038, 31306);

                System.Management.Automation.PSArgumentNullException
                f_1271_30274_30328(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 30274, 30328);
                    return return_v;
                }


                bool
                f_1271_30364_30394(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 30364, 30394);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1271_30434_30490(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 30434, 30490);
                    return return_v;
                }


                bool
                f_1271_30526_30558(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 30526, 30558);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1271_30598_30656(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 30598, 30656);
                    return return_v;
                }


                string
                f_1271_30782_30828(System.Management.Automation.Cmdlet
                this_param, string
                baseName, string
                resourceId)
                {
                    var return_v = this_param.GetResourceString(baseName, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 30782, 30828);
                    return return_v;
                }


                string
                f_1271_31244_31294(System.Management.Automation.ErrorDetails
                this_param, string
                template, string
                baseName, string
                resourceId, params object[]
                args)
                {
                    var return_v = this_param.BuildMessage(template, baseName, resourceId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 31244, 31294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 30038, 31306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 30038, 31306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string BuildMessage(
                    IResourceSupplier resourceSupplier,
                    string baseName,
                    string resourceId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 31318, 32637);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31517, 31665) || true) && (resourceSupplier == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 31517, 31665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31579, 31650);

                    throw f_1271_31585_31649(nameof(resourceSupplier));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 31517, 31665);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31681, 31827) || true) && (f_1271_31685_31715(baseName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 31681, 31827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31749, 31812);

                    throw f_1271_31755_31811(nameof(baseName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 31681, 31827);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31843, 31993) || true) && (f_1271_31847_31879(resourceId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 31843, 31993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 31913, 31978);

                    throw f_1271_31919_31977(nameof(resourceId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 31843, 31993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32009, 32040);

                string
                template = string.Empty
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32092, 32160);

                    template = f_1271_32103_32159(resourceSupplier, baseName, resourceId);
                }
                catch (MissingManifestResourceException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 32189, 32371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32264, 32285);

                    _textLookupError = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32303, 32323);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 32189, 32371);
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 32385, 32552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32445, 32466);

                    _textLookupError = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32484, 32504);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 32385, 32552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32568, 32626);

                return f_1271_32575_32625(this, template, baseName, resourceId, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 31318, 32637);

                System.Management.Automation.PSArgumentNullException
                f_1271_31585_31649(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 31585, 31649);
                    return return_v;
                }


                bool
                f_1271_31685_31715(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 31685, 31715);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1271_31755_31811(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 31755, 31811);
                    return return_v;
                }


                bool
                f_1271_31847_31879(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 31847, 31879);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1271_31919_31977(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 31919, 31977);
                    return return_v;
                }


                string
                f_1271_32103_32159(System.Management.Automation.IResourceSupplier
                this_param, string
                baseName, string
                resourceId)
                {
                    var return_v = this_param.GetResourceString(baseName, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 32103, 32159);
                    return return_v;
                }


                string
                f_1271_32575_32625(System.Management.Automation.ErrorDetails
                this_param, string
                template, string
                baseName, string
                resourceId, params object[]
                args)
                {
                    var return_v = this_param.BuildMessage(template, baseName, resourceId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 32575, 32625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 31318, 32637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 31318, 32637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string BuildMessage(
                    System.Reflection.Assembly assembly,
                    string baseName,
                    string resourceId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 32649, 33961);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32849, 32981) || true) && (assembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 32849, 32981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32903, 32966);

                    throw f_1271_32909_32965(nameof(assembly));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 32849, 32981);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 32997, 33143) || true) && (f_1271_33001_33031(baseName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 32997, 33143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33065, 33128);

                    throw f_1271_33071_33127(nameof(baseName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 32997, 33143);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33159, 33309) || true) && (f_1271_33163_33195(resourceId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 33159, 33309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33229, 33294);

                    throw f_1271_33235_33293(nameof(resourceId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 33159, 33309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33325, 33356);

                string
                template = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33372, 33501);

                ResourceManager
                manager =
                f_1271_33415_33500(assembly, baseName)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33551, 33665);

                    template = f_1271_33562_33664(manager, resourceId, f_1271_33635_33663());
                }
                catch (MissingManifestResourceException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 33694, 33876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33769, 33790);

                    _textLookupError = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33808, 33828);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 33694, 33876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 33892, 33950);

                return f_1271_33899_33949(this, template, baseName, resourceId, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 32649, 33961);

                System.Management.Automation.PSArgumentNullException
                f_1271_32909_32965(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 32909, 32965);
                    return return_v;
                }


                bool
                f_1271_33001_33031(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 33001, 33031);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1271_33071_33127(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 33071, 33127);
                    return return_v;
                }


                bool
                f_1271_33163_33195(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 33163, 33195);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1271_33235_33293(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 33235, 33293);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_1271_33415_33500(System.Reflection.Assembly
                assembly, string
                baseName)
                {
                    var return_v = ResourceManagerCache.GetResourceManager(assembly, baseName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 33415, 33500);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1271_33635_33663()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 33635, 33663);
                    return return_v;
                }


                string?
                f_1271_33562_33664(System.Resources.ResourceManager
                this_param, string
                name, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.GetString(name, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 33562, 33664);
                    return return_v;
                }


                string
                f_1271_33899_33949(System.Management.Automation.ErrorDetails
                this_param, string
                template, string
                baseName, string
                resourceId, params object[]
                args)
                {
                    var return_v = this_param.BuildMessage(template, baseName, resourceId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 33899, 33949);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 32649, 33961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 32649, 33961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string BuildMessage(
                    string template,
                    string baseName,
                    string resourceId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 33973, 34886);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 34153, 34500) || true) && (f_1271_34157_34192(template))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 34153, 34500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 34226, 34414);

                    _textLookupError = f_1271_34245_34413(f_1271_34310_34348(), baseName, resourceId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 34432, 34452);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 34153, 34500);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 34552, 34681);

                    return f_1271_34559_34680(f_1271_34595_34621(), template, args);
                }
                catch (FormatException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1271, 34710, 34875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 34768, 34789);

                    _textLookupError = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 34807, 34827);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1271, 34710, 34875);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 33973, 34886);

                bool
                f_1271_34157_34192(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 34157, 34192);
                    return return_v;
                }


                string
                f_1271_34310_34348()
                {
                    var return_v = ErrorPackage.ErrorDetailsEmptyTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 34310, 34348);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1271_34245_34413(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 34245, 34413);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1271_34595_34621()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 34595, 34621);
                    return return_v;
                }


                string
                f_1271_34559_34680(System.Globalization.CultureInfo
                provider, string
                format, params object[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 34559, 34680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 33973, 34886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 33973, 34886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ErrorDetails()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1271, 18129, 34923);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1271, 18129, 34923);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 18129, 34923);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1271, 18129, 34923);

        string
        f_1271_21110_21158(System.Management.Automation.ErrorDetails
        this_param, System.Management.Automation.Cmdlet
        cmdlet, string
        baseName, string
        resourceId, params object[]
        args)
        {
            var return_v = this_param.BuildMessage(cmdlet, baseName, resourceId, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 21110, 21158);
            return return_v;
        }


        string
        f_1271_23745_23803(System.Management.Automation.ErrorDetails
        this_param, System.Management.Automation.IResourceSupplier
        resourceSupplier, string
        baseName, string
        resourceId, params object[]
        args)
        {
            var return_v = this_param.BuildMessage(resourceSupplier, baseName, resourceId, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 23745, 23803);
            return return_v;
        }


        string
        f_1271_25749_25799(System.Management.Automation.ErrorDetails
        this_param, System.Reflection.Assembly
        assembly, string
        baseName, string
        resourceId, params object[]
        args)
        {
            var return_v = this_param.BuildMessage(assembly, baseName, resourceId, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 25749, 25799);
            return return_v;
        }


        string?
        f_1271_26664_26702(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 26664, 26702);
            return return_v;
        }


        string?
        f_1271_26738_26804(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 26738, 26804);
            return return_v;
        }

    }
    [Serializable]
    public class ErrorRecord : ISerializable
    {
        private ErrorRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 36397, 36440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40703, 40724);
                this._isSerialized = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41033, 41072);
                this._serializedFullyQualifiedErrorId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41215, 41261);
                this._serializedErrorCategoryMessageOverride = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57146, 57152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57396, 57403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57942, 57955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59471, 59517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59813, 59828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61645, 61699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61896, 61913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63005, 63066);
                this._pipelineIterationInfo = f_1271_63030_63066();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63380, 63410);
                this._serializeExtendedInfo = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63503, 63511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63593, 63602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63629, 63646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63673, 63688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63715, 63734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63761, 63780);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 36397, 36440);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 36397, 36440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 36397, 36440);
            }
        }

        public ErrorRecord(
                    Exception exception,
                    string errorId,
                    ErrorCategory errorCategory,
                    object targetObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 37441, 38062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40703, 40724);
                this._isSerialized = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41033, 41072);
                this._serializedFullyQualifiedErrorId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41215, 41261);
                this._serializedErrorCategoryMessageOverride = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57146, 57152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57396, 57403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57942, 57955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59471, 59517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59813, 59828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61645, 61699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61896, 61913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63005, 63066);
                this._pipelineIterationInfo = f_1271_63030_63066();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63380, 63410);
                this._serializeExtendedInfo = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63503, 63511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63593, 63602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63629, 63646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63673, 63688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63715, 63734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63761, 63780);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 37624, 37758) || true) && (exception == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 37624, 37758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 37679, 37743);

                    throw f_1271_37685_37742(nameof(exception));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 37624, 37758);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 37774, 37865) || true) && (errorId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 37774, 37865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 37827, 37850);

                    errorId = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 37774, 37865);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 37922, 37941);

                _error = exception;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 37955, 37974);

                _errorId = errorId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 37988, 38014);

                _category = errorCategory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 38028, 38051);

                _target = targetObject;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 37441, 38062);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 37441, 38062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 37441, 38062);
            }
        }

        protected ErrorRecord(SerializationInfo info,
                                      StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 39437, 39715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40703, 40724);
                this._isSerialized = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41033, 41072);
                this._serializedFullyQualifiedErrorId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41215, 41261);
                this._serializedErrorCategoryMessageOverride = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57146, 57152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57396, 57403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57942, 57955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59471, 59517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59813, 59828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61645, 61699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61896, 61913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63005, 63066);
                this._pipelineIterationInfo = f_1271_63030_63066();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63380, 63410);
                this._serializeExtendedInfo = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63503, 63511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63593, 63602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63629, 63646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63673, 63688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63715, 63734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63761, 63780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 39564, 39647);

                PSObject
                psObject = f_1271_39584_39646(info, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 39661, 39704);

                f_1271_39661_39703(this, psObject);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 39437, 39715);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 39437, 39715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 39437, 39715);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 39961, 40492);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40162, 40481) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 40162, 40481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40212, 40270);

                    PSObject
                    psObject = f_1271_40232_40269()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40370, 40408);

                    f_1271_40370_40407(this, psObject, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40428, 40466);

                    f_1271_40428_40465(
                                    psObject, info, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 40162, 40481);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 39961, 40492);

                System.Management.Automation.PSObject
                f_1271_40232_40269()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 40232, 40269);
                    return return_v;
                }


                int
                f_1271_40370_40407(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.PSObject
                dest, bool
                serializeExtInfo)
                {
                    this_param.ToPSObjectForRemoting(dest, serializeExtInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 40370, 40407);
                    return 0;
                }


                int
                f_1271_40428_40465(System.Management.Automation.PSObject
                this_param, System.Runtime.Serialization.SerializationInfo
                info, System.Runtime.Serialization.StreamingContext
                context)
                {
                    this_param.GetObjectData(info, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 40428, 40465);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 39961, 40492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 39961, 40492);
            }
        }

        private bool _isSerialized;

        internal bool IsSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 40859, 40875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40862, 40875);
                    return _isSerialized;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 40859, 40875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 40826, 40878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 40826, 40878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _serializedFullyQualifiedErrorId;

        internal string _serializedErrorCategoryMessageOverride;

        internal ErrorRecord(
                    Exception exception,
                    object targetObject,
                    string fullyQualifiedErrorId,
                    ErrorCategory errorCategory,
                    string errorCategory_Activity,
                    string errorCategory_Reason,
                    string errorCategory_TargetName,
                    string errorCategory_TargetType,
                    string errorCategory_Message,
                    string errorDetails_Message,
                    string errorDetails_RecommendedAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 42096, 42936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40703, 40724);
                this._isSerialized = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41033, 41072);
                this._serializedFullyQualifiedErrorId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41215, 41261);
                this._serializedErrorCategoryMessageOverride = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57146, 57152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57396, 57403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57942, 57955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59471, 59517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59813, 59828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61645, 61699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61896, 61913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63005, 63066);
                this._pipelineIterationInfo = f_1271_63030_63066();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63380, 63410);
                this._serializeExtendedInfo = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63503, 63511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63593, 63602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63629, 63646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63673, 63688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63715, 63734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63761, 63780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 42610, 42925);

                f_1271_42610_42924(this, exception, targetObject, fullyQualifiedErrorId, errorCategory, errorCategory_Activity, errorCategory_Reason, errorCategory_TargetName, errorCategory_TargetType, errorCategory_Message, errorDetails_Message, errorDetails_RecommendedAction, null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 42096, 42936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 42096, 42936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 42096, 42936);
            }
        }

        private void PopulateProperties(
                    Exception exception,
                    object targetObject,
                    string fullyQualifiedErrorId,
                    ErrorCategory errorCategory,
                    string errorCategory_Activity,
                    string errorCategory_Reason,
                    string errorCategory_TargetName,
                    string errorCategory_TargetType,
                    string errorCategory_Message,
                    string errorDetails_Message,
                    string errorDetails_RecommendedAction,
                    string errorDetails_ScriptStackTrace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 42948, 44824);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 43524, 43658) || true) && (exception == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 43524, 43658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 43579, 43643);

                    throw f_1271_43585_43642(nameof(exception));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 43524, 43658);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 43674, 43832) || true) && (fullyQualifiedErrorId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 43674, 43832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 43741, 43817);

                    throw f_1271_43747_43816(nameof(fullyQualifiedErrorId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 43674, 43832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 43901, 43922);

                _isSerialized = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 43936, 43955);

                _error = exception;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 43969, 43992);

                _target = targetObject;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44006, 44063);

                _serializedFullyQualifiedErrorId = fullyQualifiedErrorId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44077, 44103);

                _category = errorCategory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44117, 44160);

                _activityOverride = errorCategory_Activity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44174, 44213);

                _reasonOverride = errorCategory_Reason;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44227, 44274);

                _targetNameOverride = errorCategory_TargetName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44288, 44335);

                _targetTypeOverride = errorCategory_TargetType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44349, 44413);

                _serializedErrorCategoryMessageOverride = errorCategory_Message;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44427, 44747) || true) && (errorDetails_Message != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 44427, 44747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44493, 44547);

                    ErrorDetails = f_1271_44508_44546(errorDetails_Message);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44565, 44732) || true) && (errorDetails_RecommendedAction != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 44565, 44732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44649, 44713);

                        f_1271_44649_44661().RecommendedAction = errorDetails_RecommendedAction;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 44565, 44732);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 44427, 44747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 44763, 44813);

                _scriptStackTrace = errorDetails_ScriptStackTrace;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 42948, 44824);

                System.Management.Automation.PSArgumentNullException
                f_1271_43585_43642(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 43585, 43642);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1271_43747_43816(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 43747, 43816);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1271_44508_44546(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 44508, 44546);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1271_44649_44661()
                {
                    var return_v = ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 44649, 44661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 42948, 44824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 42948, 44824);
            }
        }

        internal void ToPSObjectForRemoting(PSObject dest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 44996, 45133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45071, 45122);

                f_1271_45071_45121(this, dest, f_1271_45099_45120());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 44996, 45133);

                bool
                f_1271_45099_45120()
                {
                    var return_v = SerializeExtendedInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 45099, 45120);
                    return return_v;
                }


                int
                f_1271_45071_45121(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.PSObject
                dest, bool
                serializeExtInfo)
                {
                    this_param.ToPSObjectForRemoting(dest, serializeExtInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45071, 45121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 44996, 45133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 44996, 45133);
            }
        }

        private void ToPSObjectForRemoting(PSObject dest, bool serializeExtInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 45145, 47681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45242, 45339);

                f_1271_45242_45338(dest, "Exception", delegate ()
                { return Exception; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45353, 45453);

                f_1271_45353_45452(dest, "TargetObject", delegate ()
                { return TargetObject; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45467, 45585);

                f_1271_45467_45584(dest, "FullyQualifiedErrorId", delegate ()
                { return FullyQualifiedErrorId; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45599, 45711);

                f_1271_45599_45710(dest, "InvocationInfo", delegate ()
                { return InvocationInfo; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45725, 45846);

                f_1271_45725_45845(dest, "ErrorCategory_Category", delegate ()
                { return (int)CategoryInfo.Category; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45860, 45979);

                f_1271_45860_45978(dest, "ErrorCategory_Activity", delegate ()
                { return CategoryInfo.Activity; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 45993, 46108);

                f_1271_45993_46107(dest, "ErrorCategory_Reason", delegate ()
                { return CategoryInfo.Reason; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 46122, 46245);

                f_1271_46122_46244(dest, "ErrorCategory_TargetName", delegate ()
                { return CategoryInfo.TargetName; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 46259, 46382);

                f_1271_46259_46381(dest, "ErrorCategory_TargetType", delegate ()
                { return CategoryInfo.TargetType; });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 46396, 46544);

                f_1271_46396_46543(dest, "ErrorCategory_Message", delegate ()
                { return CategoryInfo.GetMessage(CultureInfo.CurrentCulture); });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 46560, 46903) || true) && (f_1271_46564_46576() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 46560, 46903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 46618, 46734);

                    f_1271_46618_46733(dest, "ErrorDetails_Message", delegate ()
                    { return ErrorDetails.Message; });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 46752, 46888);

                    f_1271_46752_46887(dest, "ErrorDetails_RecommendedAction", delegate ()
                    { return ErrorDetails.RecommendedAction; });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 46560, 46903);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 46919, 47439) || true) && (!serializeExtInfo || (DynAbs.Tracing.TraceSender.Expression_False(1271, 46923, 46971) || f_1271_46944_46963(this) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 46919, 47439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 47005, 47081);

                    f_1271_47005_47080(dest, "SerializeExtendedInfo", () => false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 46919, 47439);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 46919, 47439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 47147, 47222);

                    f_1271_47147_47221(dest, "SerializeExtendedInfo", () => true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 47240, 47288);

                    f_1271_47240_47287(f_1271_47240_47259(this), dest);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 47306, 47424);

                    f_1271_47306_47423(dest, "PipelineIterationInfo", delegate ()
                    { return PipelineIterationInfo; });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 46919, 47439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 47455, 47670) || true) && (!f_1271_47460_47503(f_1271_47481_47502(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 47455, 47670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 47537, 47655);

                    f_1271_47537_47654(dest, "ErrorDetails_ScriptStackTrace", delegate ()
                    { return this.ScriptStackTrace; });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 47455, 47670);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 45145, 47681);

                int
                f_1271_45242_45338(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<System.Exception>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<Exception>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45242, 45338);
                    return 0;
                }


                int
                f_1271_45353_45452(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<object>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<object>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45353, 45452);
                    return 0;
                }


                int
                f_1271_45467_45584(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45467, 45584);
                    return 0;
                }


                int
                f_1271_45599_45710(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<System.Management.Automation.InvocationInfo>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<InvocationInfo>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45599, 45710);
                    return 0;
                }


                int
                f_1271_45725_45845(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<int>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45725, 45845);
                    return 0;
                }


                int
                f_1271_45860_45978(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45860, 45978);
                    return 0;
                }


                int
                f_1271_45993_46107(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 45993, 46107);
                    return 0;
                }


                int
                f_1271_46122_46244(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 46122, 46244);
                    return 0;
                }


                int
                f_1271_46259_46381(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 46259, 46381);
                    return 0;
                }


                int
                f_1271_46396_46543(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 46396, 46543);
                    return 0;
                }


                System.Management.Automation.ErrorDetails
                f_1271_46564_46576()
                {
                    var return_v = ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 46564, 46576);
                    return return_v;
                }


                int
                f_1271_46618_46733(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 46618, 46733);
                    return 0;
                }


                int
                f_1271_46752_46887(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 46752, 46887);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1271_46944_46963(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 46944, 46963);
                    return return_v;
                }


                int
                f_1271_47005_47080(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<bool>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 47005, 47080);
                    return 0;
                }


                int
                f_1271_47147_47221(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<bool>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 47147, 47221);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1271_47240_47259(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 47240, 47259);
                    return return_v;
                }


                int
                f_1271_47240_47287(System.Management.Automation.InvocationInfo
                this_param, System.Management.Automation.PSObject
                psObject)
                {
                    this_param.ToPSObjectForRemoting(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 47240, 47287);
                    return 0;
                }


                int
                f_1271_47306_47423(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<object>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<object>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 47306, 47423);
                    return 0;
                }


                string
                f_1271_47481_47502(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ScriptStackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 47481, 47502);
                    return return_v;
                }


                bool
                f_1271_47460_47503(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 47460, 47503);
                    return return_v;
                }


                int
                f_1271_47537_47654(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 47537, 47654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 45145, 47681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 45145, 47681);
            }
        }

        private static object GetNoteValue(PSObject mshObject, string note)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1271, 48082, 48377);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 48174, 48366) || true) && (f_1271_48178_48204(f_1271_48178_48198(mshObject), note) is PSNoteProperty p)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 48174, 48366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 48258, 48273);

                    return f_1271_48265_48272(p);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 48174, 48366);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 48174, 48366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 48339, 48351);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 48174, 48366);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1271, 48082, 48377);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1271_48178_48198(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 48178, 48198);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1271_48178_48204(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 48178, 48204);
                    return return_v;
                }


                object
                f_1271_48265_48272(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 48265, 48272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 48082, 48377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 48082, 48377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorRecord FromPSObjectForRemoting(PSObject serializedErrorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1271, 48971, 49222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49079, 49114);

                ErrorRecord
                er = f_1271_49096_49113()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49128, 49187);

                f_1271_49128_49186(er, serializedErrorRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49201, 49211);

                return er;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1271, 48971, 49222);

                System.Management.Automation.ErrorRecord
                f_1271_49096_49113()
                {
                    var return_v = new System.Management.Automation.ErrorRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 49096, 49113);
                    return return_v;
                }


                int
                f_1271_49128_49186(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.PSObject
                serializedErrorRecord)
                {
                    this_param.ConstructFromPSObjectForRemoting(serializedErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 49128, 49186);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 48971, 49222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 48971, 49222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ConstructFromPSObjectForRemoting(PSObject serializedErrorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 49234, 53838);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49336, 49494) || true) && (serializedErrorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 49336, 49494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49403, 49479);

                    throw f_1271_49409_49478(nameof(serializedErrorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 49336, 49494);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49540, 49650);

                PSObject
                serializedException = f_1271_49571_49649(serializedErrorRecord, "Exception")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49700, 49802);

                object
                targetObject = f_1271_49722_49801(serializedErrorRecord, "TargetObject")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49818, 49849);

                string
                exceptionMessage = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49863, 50193) || true) && (serializedException != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 49863, 50193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 49928, 50021);

                    PSPropertyInfo
                    messageProperty = f_1271_49961_50002(f_1271_49961_49991(serializedException), "Message") as PSPropertyInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 50039, 50178) || true) && (messageProperty != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 50039, 50178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 50108, 50159);

                        exceptionMessage = f_1271_50127_50148(messageProperty) as string;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 50039, 50178);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 49863, 50193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 50251, 50442);

                string
                fullyQualifiedErrorId = f_1271_50282_50370(serializedErrorRecord, "FullyQualifiedErrorId") ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1271, 50282, 50441) ?? "fullyQualifiedErrorId")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 50495, 50622);

                ErrorCategory
                errorCategory = f_1271_50525_50621(serializedErrorRecord, "errorCategory_Category")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 50687, 50809);

                string
                errorCategory_Activity = f_1271_50719_50808(serializedErrorRecord, "ErrorCategory_Activity")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 50823, 50941);

                string
                errorCategory_Reason = f_1271_50853_50940(serializedErrorRecord, "ErrorCategory_Reason")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 50955, 51081);

                string
                errorCategory_TargetName = f_1271_50989_51080(serializedErrorRecord, "ErrorCategory_TargetName")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 51095, 51221);

                string
                errorCategory_TargetType = f_1271_51129_51220(serializedErrorRecord, "ErrorCategory_TargetType")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 51235, 51355);

                string
                errorCategory_Message = f_1271_51266_51354(serializedErrorRecord, "ErrorCategory_Message")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 51426, 51704);

                PSObject
                invocationInfo = f_1271_51452_51703(serializedErrorRecord, "InvocationInfo", Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags.MissingPropertyOk)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 51833, 51950);

                string
                errorDetails_Message =
                f_1271_51880_51939(serializedErrorRecord, "ErrorDetails_Message") as string
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 51966, 52103);

                string
                errorDetails_RecommendedAction =
                f_1271_52023_52092(serializedErrorRecord, "ErrorDetails_RecommendedAction") as string
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 52119, 52254);

                string
                errorDetails_ScriptStackTrace =
                f_1271_52175_52243(serializedErrorRecord, "ErrorDetails_ScriptStackTrace") as string
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 52270, 52447);

                RemoteException
                re = f_1271_52291_52446((DynAbs.Tracing.TraceSender.Conditional_F1(1271, 52311, 52365) || (((f_1271_52312_52355(exceptionMessage) == false) && DynAbs.Tracing.TraceSender.Conditional_F2(1271, 52368, 52384)) || DynAbs.Tracing.TraceSender.Conditional_F3(1271, 52387, 52408))) ? exceptionMessage : errorCategory_Message, serializedException, invocationInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 52498, 53002);

                f_1271_52498_53001(this, re, targetObject, fullyQualifiedErrorId, errorCategory, errorCategory_Activity, errorCategory_Reason, errorCategory_TargetName, errorCategory_TargetType, errorCategory_Message, errorDetails_Message, errorDetails_RecommendedAction, errorDetails_ScriptStackTrace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53018, 53048);

                f_1271_53018_53047(
                            re, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53135, 53247);

                _serializeExtendedInfo = f_1271_53160_53246(serializedErrorRecord, "SerializeExtendedInfo");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53263, 53827) || true) && (_serializeExtendedInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 53263, 53827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53323, 53383);

                    _invocationInfo = f_1271_53341_53382(serializedErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53403, 53521);

                    ArrayList
                    iterationInfo = f_1271_53429_53520(serializedErrorRecord, "PipelineIterationInfo")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53539, 53723) || true) && (iterationInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 53539, 53723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53606, 53704);

                        _pipelineIterationInfo = f_1271_53631_53703((int[])f_1271_53666_53702(iterationInfo, typeof(Int32)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 53539, 53723);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 53263, 53827);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 53263, 53827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 53789, 53812);

                    _invocationInfo = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 53263, 53827);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 49234, 53838);

                System.Management.Automation.PSArgumentNullException
                f_1271_49409_49478(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 49409, 49478);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1271_49571_49649(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 49571, 49649);
                    return return_v;
                }


                object
                f_1271_49722_49801(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<object>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 49722, 49801);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1271_49961_49991(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 49961, 49991);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1271_49961_50002(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 49961, 50002);
                    return return_v;
                }


                object
                f_1271_50127_50148(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 50127, 50148);
                    return return_v;
                }


                string
                f_1271_50282_50370(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 50282, 50370);
                    return return_v;
                }


                System.Management.Automation.ErrorCategory
                f_1271_50525_50621(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<ErrorCategory>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 50525, 50621);
                    return return_v;
                }


                string
                f_1271_50719_50808(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 50719, 50808);
                    return return_v;
                }


                string
                f_1271_50853_50940(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 50853, 50940);
                    return return_v;
                }


                string
                f_1271_50989_51080(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 50989, 51080);
                    return return_v;
                }


                string
                f_1271_51129_51220(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 51129, 51220);
                    return return_v;
                }


                string
                f_1271_51266_51354(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 51266, 51354);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1271_51452_51703(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = Microsoft.PowerShell.DeserializingTypeConverter.GetPropertyValue<PSObject>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 51452, 51703);
                    return return_v;
                }


                object
                f_1271_51880_51939(System.Management.Automation.PSObject
                mshObject, string
                note)
                {
                    var return_v = GetNoteValue(mshObject, note);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 51880, 51939);
                    return return_v;
                }


                object
                f_1271_52023_52092(System.Management.Automation.PSObject
                mshObject, string
                note)
                {
                    var return_v = GetNoteValue(mshObject, note);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 52023, 52092);
                    return return_v;
                }


                object
                f_1271_52175_52243(System.Management.Automation.PSObject
                mshObject, string
                note)
                {
                    var return_v = GetNoteValue(mshObject, note);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 52175, 52243);
                    return return_v;
                }


                bool
                f_1271_52312_52355(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 52312, 52355);
                    return return_v;
                }


                System.Management.Automation.RemoteException
                f_1271_52291_52446(string
                message, System.Management.Automation.PSObject
                serializedRemoteException, System.Management.Automation.PSObject
                serializedRemoteInvocationInfo)
                {
                    var return_v = new System.Management.Automation.RemoteException(message, serializedRemoteException, serializedRemoteInvocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 52291, 52446);
                    return return_v;
                }


                int
                f_1271_52498_53001(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.RemoteException
                exception, object
                targetObject, string
                fullyQualifiedErrorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                errorCategory_Activity, string
                errorCategory_Reason, string
                errorCategory_TargetName, string
                errorCategory_TargetType, string
                errorCategory_Message, string
                errorDetails_Message, string
                errorDetails_RecommendedAction, string
                errorDetails_ScriptStackTrace)
                {
                    this_param.PopulateProperties((System.Exception)exception, targetObject, fullyQualifiedErrorId, errorCategory, errorCategory_Activity, errorCategory_Reason, errorCategory_TargetName, errorCategory_TargetType, errorCategory_Message, errorDetails_Message, errorDetails_RecommendedAction, errorDetails_ScriptStackTrace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 52498, 53001);
                    return 0;
                }


                int
                f_1271_53018_53047(System.Management.Automation.RemoteException
                this_param, System.Management.Automation.ErrorRecord
                remoteError)
                {
                    this_param.SetRemoteErrorRecord(remoteError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 53018, 53047);
                    return 0;
                }


                bool
                f_1271_53160_53246(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<bool>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 53160, 53246);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1271_53341_53382(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 53341, 53382);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1271_53429_53520(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<ArrayList>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 53429, 53520);
                    return return_v;
                }


                System.Array
                f_1271_53666_53702(System.Collections.ArrayList
                this_param, System.Type
                type)
                {
                    var return_v = this_param.ToArray(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 53666, 53702);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<int>
                f_1271_53631_53703(int[]
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<int>((System.Collections.Generic.IList<int>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 53631, 53703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 49234, 53838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 49234, 53838);
            }
        }

        public ErrorRecord(ErrorRecord errorRecord,
                                     Exception replaceParentContainsErrorRecordException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 54479, 55899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 40703, 40724);
                this._isSerialized = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41033, 41072);
                this._serializedFullyQualifiedErrorId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 41215, 41261);
                this._serializedErrorCategoryMessageOverride = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57146, 57152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57396, 57403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57942, 57955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59471, 59517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59813, 59828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61645, 61699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61896, 61913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63005, 63066);
                this._pipelineIterationInfo = f_1271_63030_63066();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63380, 63410);
                this._serializeExtendedInfo = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63503, 63511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63593, 63602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63629, 63646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63673, 63688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63715, 63734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63761, 63780);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 54630, 54757) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 54630, 54757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 54687, 54742);

                    throw f_1271_54693_54741(nameof(errorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 54630, 54757);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 54773, 55105) || true) && (replaceParentContainsErrorRecordException != null
                && (DynAbs.Tracing.TraceSender.Expression_True(1271, 54777, 54908) && (f_1271_54848_54869(errorRecord) is ParentContainsErrorRecordException)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 54773, 55105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 54942, 54993);

                    _error = replaceParentContainsErrorRecordException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 54773, 55105);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 54773, 55105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55059, 55090);

                    _error = f_1271_55068_55089(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 54773, 55105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55121, 55156);

                _target = f_1271_55131_55155(errorRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55170, 55202);

                _errorId = errorRecord._errorId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55216, 55250);

                _category = errorRecord._category;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55264, 55314);

                _activityOverride = errorRecord._activityOverride;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55328, 55374);

                _reasonOverride = errorRecord._reasonOverride;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55388, 55442);

                _targetNameOverride = errorRecord._targetNameOverride;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55456, 55510);

                _targetTypeOverride = errorRecord._targetTypeOverride;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55524, 55667) || true) && (f_1271_55528_55552(errorRecord) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 55524, 55667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55594, 55652);

                    ErrorDetails = f_1271_55609_55651(f_1271_55626_55650(errorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 55524, 55667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55683, 55730);

                f_1271_55683_55729(this, errorRecord._invocationInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55744, 55794);

                _scriptStackTrace = errorRecord._scriptStackTrace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 55808, 55888);

                _serializedFullyQualifiedErrorId = errorRecord._serializedFullyQualifiedErrorId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 54479, 55899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 54479, 55899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 54479, 55899);
            }
        }

        internal virtual ErrorRecord WrapException(Exception replaceParentContainsErrorRecordException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 56501, 56704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 56621, 56693);

                return f_1271_56628_56692(this, replaceParentContainsErrorRecordException);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 56501, 56704);

                System.Management.Automation.ErrorRecord
                f_1271_56628_56692(System.Management.Automation.ErrorRecord
                errorRecord, System.Exception
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 56628, 56692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 56501, 56704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 56501, 56704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Exception Exception
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 56969, 57105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57005, 57058);

                    f_1271_57005_57057(_error != null, "_error is null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57076, 57090);

                    return _error;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 56969, 57105);

                    int
                    f_1271_57005_57057(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 57005, 57057);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 56918, 57116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 56918, 57116);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Exception _error /* = null */;

        public object TargetObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 57356, 57366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57359, 57366);
                    return _target;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 57356, 57366);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 57323, 57369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 57323, 57369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private object _target /* = null */;

        internal void SetTargetObject(object target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 57427, 57524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57496, 57513);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 57427, 57524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 57427, 57524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 57427, 57524);
            }
        }

        public ErrorCategoryInfo CategoryInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 57836, 57901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 57839, 57901);
                    return _categoryInfo ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ErrorCategoryInfo>(1271, 57839, 57901) ?? (_categoryInfo = f_1271_57873_57900(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 57836, 57901);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 57792, 57904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 57792, 57904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ErrorCategoryInfo _categoryInfo;

        public string FullyQualifiedErrorId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 58543, 59072);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 58579, 58724) || true) && (_serializedFullyQualifiedErrorId != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 58579, 58724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 58665, 58705);

                        return _serializedFullyQualifiedErrorId;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 58579, 58724);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 58744, 58786);

                    string
                    typeName = f_1271_58762_58785(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 58804, 58982);

                    string
                    delimiter =
                    (DynAbs.Tracing.TraceSender.Conditional_F1(1271, 58844, 58910) || (((f_1271_58845_58875(typeName) || (DynAbs.Tracing.TraceSender.Expression_False(1271, 58845, 58909) || f_1271_58879_58909(_errorId)))
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1271, 58938, 58950)) || DynAbs.Tracing.TraceSender.Conditional_F3(1271, 58978, 58981))) ? string.Empty
                    : ","
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59000, 59057);

                    return f_1271_59007_59024(_errorId) + delimiter + f_1271_59039_59056(typeName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 58543, 59072);

                    string
                    f_1271_58762_58785(System.Management.Automation.ErrorRecord
                    this_param)
                    {
                        var return_v = this_param.GetInvocationTypeName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 58762, 58785);
                        return return_v;
                    }


                    bool
                    f_1271_58845_58875(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 58845, 58875);
                        return return_v;
                    }


                    bool
                    f_1271_58879_58909(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 58879, 58909);
                        return return_v;
                    }


                    string
                    f_1271_59007_59024(string
                    s)
                    {
                        var return_v = NotNull(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 59007, 59024);
                        return return_v;
                    }


                    string
                    f_1271_59039_59056(string
                    s)
                    {
                        var return_v = NotNull(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 59039, 59056);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 58483, 59083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 58483, 59083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ErrorDetails ErrorDetails { get; set; }

        public InvocationInfo InvocationInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 59757, 59775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59760, 59775);
                    return _invocationInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 59757, 59775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 59714, 59778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 59714, 59778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private InvocationInfo _invocationInfo /* = null */;

        internal void SetInvocationInfo(InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 59854, 61554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 59996, 60044);

                IScriptExtent
                savedDisplayScriptPosition = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60058, 60201) || true) && (_invocationInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 60058, 60201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60119, 60186);

                    savedDisplayScriptPosition = f_1271_60148_60185(_invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 60058, 60201);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60259, 60857) || true) && (invocationInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 60259, 60857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60319, 60413);

                    _invocationInfo = f_1271_60337_60412(f_1271_60356_60380(invocationInfo), f_1271_60382_60411(invocationInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60431, 60494);

                    _invocationInfo.InvocationName = f_1271_60464_60493(invocationInfo);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60512, 60842) || true) && (f_1271_60516_60540(invocationInfo) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 60512, 60842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60770, 60823);

                        _invocationInfo.HistoryId = f_1271_60798_60822(invocationInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 60512, 60842);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 60259, 60857);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60923, 61077) || true) && (savedDisplayScriptPosition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 60923, 61077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 60995, 61062);

                    _invocationInfo.DisplayScriptPosition = savedDisplayScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 60923, 61077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61093, 61116);

                f_1271_61093_61115(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61268, 61543) || true) && (invocationInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1271, 61272, 61342) && f_1271_61298_61334(invocationInfo) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 61268, 61543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61376, 61445);

                    int[]
                    snapshot = (int[])f_1271_61400_61444(f_1271_61400_61436(invocationInfo))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61465, 61528);

                    _pipelineIterationInfo = f_1271_61490_61527(snapshot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 61268, 61543);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 59854, 61554);

                System.Management.Automation.Language.IScriptExtent
                f_1271_60148_60185(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.DisplayScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 60148, 60185);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1271_60356_60380(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 60356, 60380);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1271_60382_60411(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 60382, 60411);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1271_60337_60412(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 60337, 60412);
                    return return_v;
                }


                string
                f_1271_60464_60493(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 60464, 60493);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1271_60516_60540(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 60516, 60540);
                    return return_v;
                }


                long
                f_1271_60798_60822(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.HistoryId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 60798, 60822);
                    return return_v;
                }


                int
                f_1271_61093_61115(System.Management.Automation.ErrorRecord
                this_param)
                {
                    this_param.LockScriptStackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 61093, 61115);
                    return 0;
                }


                int[]
                f_1271_61298_61334(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 61298, 61334);
                    return return_v;
                }


                int[]
                f_1271_61400_61436(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 61400, 61436);
                    return return_v;
                }


                object
                f_1271_61400_61444(int[]
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 61400, 61444);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<int>
                f_1271_61490_61527(int[]
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<int>((System.Collections.Generic.IList<int>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 61490, 61527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 59854, 61554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 59854, 61554);
            }
        }

        internal bool PreserveInvocationInfoOnce { get; set; }

        public string ScriptStackTrace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 61846, 61866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61849, 61866);
                    return _scriptStackTrace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 61846, 61866);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 61809, 61869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 61809, 61869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _scriptStackTrace;

        internal void LockScriptStackTrace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 61926, 62745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 61987, 62072) || true) && (_scriptStackTrace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 61987, 62072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62050, 62057);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 61987, 62072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62088, 62145);

                var
                context = f_1271_62102_62144()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62159, 62734) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 62159, 62734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62212, 62251);

                    StringBuilder
                    sb = f_1271_62231_62250()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62269, 62317);

                    var
                    callstack = f_1271_62285_62316(f_1271_62285_62301(context))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62335, 62353);

                    bool
                    first = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62371, 62665);
                        foreach (var frame in f_1271_62393_62402_I(callstack))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 62371, 62665);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62444, 62558) || true) && (!first)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 62444, 62558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62504, 62535);

                                f_1271_62504_62534(sb, f_1271_62514_62533());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 62444, 62558);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62582, 62596);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62618, 62646);

                            f_1271_62618_62645(sb, f_1271_62628_62644(frame));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 62371, 62665);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1271, 1, 295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1271, 1, 295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62685, 62719);

                    _scriptStackTrace = f_1271_62705_62718(sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 62159, 62734);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 61926, 62745);

                System.Management.Automation.ExecutionContext
                f_1271_62102_62144()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62102, 62144);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1271_62231_62250()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62231, 62250);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1271_62285_62301(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 62285, 62301);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1271_62285_62316(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    var return_v = this_param.GetCallStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62285, 62316);
                    return return_v;
                }


                string
                f_1271_62514_62533()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 62514, 62533);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1271_62504_62534(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62504, 62534);
                    return return_v;
                }


                string
                f_1271_62628_62644(System.Management.Automation.CallStackFrame
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62628, 62644);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1271_62618_62645(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62618, 62645);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1271_62393_62402_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62393, 62402);
                    return return_v;
                }


                string
                f_1271_62705_62718(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 62705, 62718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 61926, 62745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 61926, 62745);
            }
        }

        public ReadOnlyCollection<int> PipelineIterationInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 62933, 62958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 62936, 62958);
                    return _pipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 62933, 62958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 62874, 62961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 62874, 62961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReadOnlyCollection<int> _pipelineIterationInfo;

        internal bool SerializeExtendedInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 63264, 63289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63267, 63289);
                    return _serializeExtendedInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 63264, 63289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 63200, 63355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 63200, 63355);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 63310, 63343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63313, 63343);
                    _serializeExtendedInfo = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 63310, 63343);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 63200, 63355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 63200, 63355);
                }
            }
        }

        private bool _serializeExtendedInfo;

        private string _errorId;

        internal ErrorCategory _category;

        internal string _activityOverride;

        internal string _reasonOverride;

        internal string _targetNameOverride;

        internal string _targetTypeOverride;

        internal static string NotNull(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 63883, 63903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63886, 63903);
                return s ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1271, 63886, 63903) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 63883, 63903);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 63883, 63903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 63883, 63903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetInvocationTypeName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 63916, 64746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 63979, 64031);

                InvocationInfo
                invocationInfo = f_1271_64011_64030(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64045, 64140) || true) && (invocationInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 64045, 64140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64105, 64125);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 64045, 64140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64156, 64207);

                CommandInfo
                commandInfo = f_1271_64182_64206(invocationInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64221, 64313) || true) && (commandInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 64221, 64313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64278, 64298);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 64221, 64313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64329, 64395);

                IScriptCommandInfo
                scriptInfo = commandInfo as IScriptCommandInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64409, 64504) || true) && (scriptInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 64409, 64504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64465, 64489);

                    return f_1271_64472_64488(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 64409, 64504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64520, 64570);

                CmdletInfo
                cmdletInfo = commandInfo as CmdletInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64584, 64675) || true) && (cmdletInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 64584, 64675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64640, 64660);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 64584, 64675);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 64691, 64735);

                return f_1271_64698_64734(f_1271_64698_64725(cmdletInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 63916, 64746);

                System.Management.Automation.InvocationInfo
                f_1271_64011_64030(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 64011, 64030);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1271_64182_64206(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 64182, 64206);
                    return return_v;
                }


                string
                f_1271_64472_64488(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 64472, 64488);
                    return return_v;
                }


                System.Type
                f_1271_64698_64725(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 64698, 64725);
                    return return_v;
                }


                string
                f_1271_64698_64734(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 64698, 64734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 63916, 64746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 63916, 64746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1271, 64979, 65499);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65037, 65185) || true) && (f_1271_65041_65053() != null && (DynAbs.Tracing.TraceSender.Expression_True(1271, 65041, 65108) && !f_1271_65066_65108(f_1271_65087_65107(f_1271_65087_65099()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 65037, 65185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65142, 65170);

                    return f_1271_65149_65169(f_1271_65149_65161());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 65037, 65185);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65201, 65449) || true) && (f_1271_65205_65214() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 65201, 65449);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65256, 65386) || true) && (!f_1271_65261_65300(f_1271_65282_65299(f_1271_65282_65291())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1271, 65256, 65386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65342, 65367);

                        return f_1271_65349_65366(f_1271_65349_65358());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 65256, 65386);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65406, 65434);

                    return f_1271_65413_65433(f_1271_65413_65422());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1271, 65201, 65449);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65465, 65488);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ToString(), 1271, 65472, 65487);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1271, 64979, 65499);

                System.Management.Automation.ErrorDetails
                f_1271_65041_65053()
                {
                    var return_v = ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65041, 65053);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1271_65087_65099()
                {
                    var return_v = ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65087, 65099);
                    return return_v;
                }


                string
                f_1271_65087_65107(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65087, 65107);
                    return return_v;
                }


                bool
                f_1271_65066_65108(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 65066, 65108);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1271_65149_65161()
                {
                    var return_v = ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65149, 65161);
                    return return_v;
                }


                string
                f_1271_65149_65169(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65149, 65169);
                    return return_v;
                }


                System.Exception
                f_1271_65205_65214()
                {
                    var return_v = Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65205, 65214);
                    return return_v;
                }


                System.Exception
                f_1271_65282_65291()
                {
                    var return_v = Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65282, 65291);
                    return return_v;
                }


                string
                f_1271_65282_65299(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65282, 65299);
                    return return_v;
                }


                bool
                f_1271_65261_65300(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 65261, 65300);
                    return return_v;
                }


                System.Exception
                f_1271_65349_65358()
                {
                    var return_v = Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65349, 65358);
                    return return_v;
                }


                string
                f_1271_65349_65366(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65349, 65366);
                    return return_v;
                }


                System.Exception
                f_1271_65413_65422()
                {
                    var return_v = Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 65413, 65422);
                    return return_v;
                }


                string
                f_1271_65413_65433(System.Exception
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 65413, 65433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 64979, 65499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 64979, 65499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ErrorRecord()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1271, 36289, 65537);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1271, 36289, 65537);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 36289, 65537);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1271, 36289, 65537);

        System.Management.Automation.PSArgumentNullException
        f_1271_37685_37742(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 37685, 37742);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1271_39584_39646(System.Runtime.Serialization.SerializationInfo
        info, System.Runtime.Serialization.StreamingContext
        context)
        {
            var return_v = PSObject.ConstructPSObjectFromSerializationInfo(info, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 39584, 39646);
            return return_v;
        }


        int
        f_1271_39661_39703(System.Management.Automation.ErrorRecord
        this_param, System.Management.Automation.PSObject
        serializedErrorRecord)
        {
            this_param.ConstructFromPSObjectForRemoting(serializedErrorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 39661, 39703);
            return 0;
        }


        int
        f_1271_42610_42924(System.Management.Automation.ErrorRecord
        this_param, System.Exception
        exception, object
        targetObject, string
        fullyQualifiedErrorId, System.Management.Automation.ErrorCategory
        errorCategory, string
        errorCategory_Activity, string
        errorCategory_Reason, string
        errorCategory_TargetName, string
        errorCategory_TargetType, string
        errorCategory_Message, string
        errorDetails_Message, string
        errorDetails_RecommendedAction, string
        errorDetails_ScriptStackTrace)
        {
            this_param.PopulateProperties(exception, targetObject, fullyQualifiedErrorId, errorCategory, errorCategory_Activity, errorCategory_Reason, errorCategory_TargetName, errorCategory_TargetType, errorCategory_Message, errorDetails_Message, errorDetails_RecommendedAction, errorDetails_ScriptStackTrace);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 42610, 42924);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1271_54693_54741(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 54693, 54741);
            return return_v;
        }


        System.Exception
        f_1271_54848_54869(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.Exception;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 54848, 54869);
            return return_v;
        }


        System.Exception
        f_1271_55068_55089(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.Exception;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 55068, 55089);
            return return_v;
        }


        object
        f_1271_55131_55155(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.TargetObject;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 55131, 55155);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1271_55528_55552(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorDetails;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 55528, 55552);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1271_55626_55650(System.Management.Automation.ErrorRecord
        this_param)
        {
            var return_v = this_param.ErrorDetails;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1271, 55626, 55650);
            return return_v;
        }


        System.Management.Automation.ErrorDetails
        f_1271_55609_55651(System.Management.Automation.ErrorDetails
        errorDetails)
        {
            var return_v = new System.Management.Automation.ErrorDetails(errorDetails);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 55609, 55651);
            return return_v;
        }


        int
        f_1271_55683_55729(System.Management.Automation.ErrorRecord
        this_param, System.Management.Automation.InvocationInfo
        invocationInfo)
        {
            this_param.SetInvocationInfo(invocationInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 55683, 55729);
            return 0;
        }


        System.Management.Automation.ErrorCategoryInfo
        f_1271_57873_57900(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = new System.Management.Automation.ErrorCategoryInfo(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 57873, 57900);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<int>
        f_1271_63030_63066()
        {
            var return_v = Utils.EmptyReadOnlyCollection<int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1271, 63030, 63066);
            return return_v;
        }

    }
    internal class ErrorRecord<TException> : ErrorRecord where TException : Exception
    {
        public new TException Exception { get; }

        public ErrorRecord(Exception exception, string errorId, ErrorCategory errorCategory, object targetObject) : base(f_1271_66011_66020_C(exception), errorId, errorCategory, targetObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1271, 65898, 66081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1271, 65846, 65886);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1271, 65898, 66081);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1271, 65898, 66081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1271, 65898, 66081);
            }
        }

        static System.Exception
        f_1271_66011_66020_C(System.Exception
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1271, 65898, 66081);
            return return_v;
        }

    }

    /// <summary>
    /// Implemented by exception classes which contain additional
    /// <see cref="System.Management.Automation.ErrorRecord"/>
    /// information.
    /// </summary>
    /// <remarks>
    /// MSH defines certain exception classes which implement this interface.
    /// This includes wrapper exceptions such as
    /// <see cref="System.Management.Automation.CmdletInvocationException"/>,
    /// and also MSH engine errors such as
    /// <see cref="System.Management.Automation.GetValueException"/>.
    /// Cmdlets and providers should not define this interface;
    /// instead, they should use the
    /// WriteError(ErrorRecord) or
    /// ThrowTerminatingError(ErrorRecord) methods.
    /// The ErrorRecord property will contain an ErrorRecord
    /// which contains an instance of
    /// <see cref="System.Management.Automation.ParentContainsErrorRecordException"/>
    /// rather than the actual exception.
    ///
    /// Do not call WriteError(e.ErrorRecord).
    /// The ErrorRecord contained in the ErrorRecord property of
    /// an exception which implements IContainsErrorRecord
    /// should not be passed directly to WriteError, since it contains
    /// a ParentContainsErrorRecordException rather than the real exception.
    ///
    /// It is permitted for PSSnapins to implement custom Exception classes which implement
    /// <see cref="IContainsErrorRecord"/>,
    /// but it is generally preferable for Cmdlets and CmdletProviders to communicate
    /// <see cref="ErrorRecord"/>
    /// information using
    /// <see cref="Cmdlet.ThrowTerminatingError"/>
    /// or
    /// <see cref="Provider.CmdletProvider.ThrowTerminatingError"/>
    /// rather than by throwing an exception which implements
    /// <see cref="IContainsErrorRecord"/>.
    /// Consider implementing
    /// <seealso cref="IContainsErrorRecord"/>
    /// in your custom exception only if you throw it from a context
    /// where a reference to the active
    /// <seealso cref="Cmdlet"/> or
    /// <seealso cref="Provider.CmdletProvider"/>
    /// is no longer available.
    /// </remarks>
    public interface IContainsErrorRecord
    {

        ErrorRecord ErrorRecord { get; }
    }

    /// <summary>
    /// Objects implementing this interface can be used by
    /// <see cref="System.Management.Automation.ErrorDetails(IResourceSupplier,string,string,object[])"/>
    /// </summary>
    /// <remarks>
    /// <see cref="Provider.CmdletProvider"/>
    /// implements this interface.  PSSnapins can implement
    /// <see cref="IResourceSupplier"/>
    /// on their custom classes, but the only purpose would be to permit
    /// the custom class to be used in the
    /// <see cref="ErrorDetails(IResourceSupplier,string,string,object[])"/>.
    /// constructor.
    /// <see cref="ErrorDetails"/> contains special constructor
    /// <see cref="ErrorDetails(IResourceSupplier,string,string,object[])"/>
    /// reducing the steps which localizable code generally has to duplicate when it
    /// generates a localizable string.  This variant is preferred over
    /// <see cref="ErrorDetails(string)"/>,
    /// since the improved
    /// information about the error may help enable future scenarios.
    /// </remarks>
    public interface IResourceSupplier
    {

        string GetResourceString(string baseName, string resourceId);
    }
}

#pragma warning restore 56506
