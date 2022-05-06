// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation.Remoting
{
    /// <summary>
    /// This enum defines the error message ids used by the resource manager to get
    /// localized messages.
    ///
    /// Related error ids are organized in a pre-defined range of values.
    /// </summary>
    internal enum PSRemotingErrorId : uint
    {
        // OS related 1-9
        DefaultRemotingExceptionMessage = 0,
        OutOfMemory = 1,

        // Pipeline related range: 10-99
        PipelineIdsDoNotMatch = 10,
        PipelineNotFoundOnServer = 11,
        PipelineStopped = 12,

        // Runspace, Host, UI and RawUI related range: 200-299
        RunspaceAlreadyExists = 200,
        RunspaceIdsDoNotMatch = 201,
        RemoteRunspaceOpenFailed = 202,
        RunspaceCannotBeFound = 203,
        ResponsePromptIdCannotBeFound = 204,
        RemoteHostCallFailed = 205,
        RemoteHostMethodNotImplemented = 206,
        RemoteHostDataEncodingNotSupported = 207,
        RemoteHostDataDecodingNotSupported = 208,
        NestedPipelineNotSupported = 209,
        RelativeUriForRunspacePathNotSupported = 210,
        RemoteHostDecodingFailed = 211,
        MustBeAdminToOverrideThreadOptions = 212,
        RemoteHostPromptForCredentialModifiedCaption = 213,
        RemoteHostPromptForCredentialModifiedMessage = 214,
        RemoteHostReadLineAsSecureStringPrompt = 215,
        RemoteHostGetBufferContents = 216,
        RemoteHostPromptSecureStringPrompt = 217,
        WinPERemotingNotSupported = 218,

        // reserved range: 300-399

        // Encoding/Decoding and fragmentation related range: 400-499
        ReceivedUnsupportedRemoteHostCall = 400,
        ReceivedUnsupportedAction = 401,
        ReceivedUnsupportedDataType = 402,
        MissingDestination = 403,
        MissingTarget = 404,
        MissingRunspaceId = 405,
        MissingDataType = 406,
        MissingCallId = 407,
        MissingMethodName = 408,
        MissingIsStartFragment = 409,
        MissingProperty = 410,
        ObjectIdsNotMatching = 411,
        FragmentIdsNotInSequence = 412,
        ObjectIsTooBig = 413,
        MissingIsEndFragment = 414,
        DeserializedObjectIsNull = 415,
        BlobLengthNotInRange = 416,
        DecodingErrorForErrorRecord = 417,
        DecodingErrorForPipelineStateInfo = 418,
        DecodingErrorForRunspaceStateInfo = 419,
        ReceivedUnsupportedRemotingTargetInterfaceType = 420,
        UnknownTargetClass = 421,
        MissingTargetClass = 422,
        DecodingErrorForRunspacePoolStateInfo = 423,
        DecodingErrorForMinRunspaces = 424,
        DecodingErrorForMaxRunspaces = 425,
        DecodingErrorForPowerShellStateInfo = 426,
        DecodingErrorForThreadOptions = 427,
        CantCastPropertyToExpectedType = 428,
        CantCastRemotingDataToPSObject = 429,
        CantCastCommandToPSObject = 430,
        CantCastParameterToPSObject = 431,
        ObjectIdCannotBeLessThanZero = 432,
        NotEnoughHeaderForRemoteDataObject = 433,

        // reserved range: 500-599

        // Remote Session related range: 600-699
        RemotingDestinationNotForMe = 600,
        ClientNegotiationTimeout = 601,
        ClientNegotiationFailed = 602,
        ServerRequestedToCloseSession = 603,
        ServerNegotiationFailed = 604,
        ServerNegotiationTimeout = 605,
        ClientRequestedToCloseSession = 606,
        FatalErrorCausingClose = 607,
        ClientKeyExchangeFailed = 608,
        ServerKeyExchangeFailed = 609,
        ClientNotFoundCapabilityProperties = 610,
        ServerNotFoundCapabilityProperties = 611,

        // reserved range: 700-799

        // Transport related range: 800-899

        ConnectFailed = 801,
        CloseIsCalled = 802,
        ForceClosed = 803,
        CloseFailed = 804,
        CloseCompleted = 805,
        UnsupportedWaitHandleType = 806,
        ReceivedDataStreamIsNotStdout = 807,
        StdInIsNotOpen = 808,
        NativeWriteFileFailed = 809,
        NativeReadFileFailed = 810,
        InvalidSchemeValue = 811,
        ClientReceiveFailed = 812,
        ClientSendFailed = 813,
        CommandHandleIsNull = 814,
        StdInCannotBeSetToNoWait = 815,
        PortIsOutOfRange = 816,
        ServerProcessExited = 817,
        CannotGetStdInHandle = 818,
        CannotGetStdOutHandle = 819,
        CannotGetStdErrHandle = 820,
        CannotSetStdInHandle = 821,
        CannotSetStdOutHandle = 822,
        CannotSetStdErrHandle = 823,
        InvalidConfigurationName = 824,
        ConnectSkipCheckFailed = 825,
        // Error codes added to support new WSMan Fan-In Model API
        CreateSessionFailed = 851,
        CreateExFailed = 853,
        ConnectExCallBackError = 854,
        SendExFailed = 855,
        SendExCallBackError = 856,
        ReceiveExFailed = 857,
        ReceiveExCallBackError = 858,
        RunShellCommandExFailed = 859,
        RunShellCommandExCallBackError = 860,
        CommandSendExFailed = 861,
        CommandSendExCallBackError = 862,
        CommandReceiveExFailed = 863,
        CommandReceiveExCallBackError = 864,
        CloseExCallBackError = 866,
        // END: Error codes added to support new WSMan Fan-In Model API
        // BEGIN: Error IDs introduced for URI redirection
        RedirectedURINotWellFormatted = 867,
        URIEndPointNotResolved = 868,
        // END: Error IDs introduced for URI redirection
        // BEGIN: Error IDs introduced for Quota Management
        ReceivedObjectSizeExceededMaximumClient = 869,
        ReceivedDataSizeExceededMaximumClient = 870,
        ReceivedObjectSizeExceededMaximumServer = 871,
        ReceivedDataSizeExceededMaximumServer = 872,
        // END: Error IDs introduced for Quota Management
        // BEGIN: Error IDs introduced for startup script
        StartupScriptThrewTerminatingError = 873,
        // END: Error IDs introduced for startup script
        TroubleShootingHelpTopic = 874,
        // BEGIN: Error IDs introduced for disconnect/reconnect
        DisconnectShellExFailed = 875,
        DisconnectShellExCallBackErrr = 876,
        ReconnectShellExFailed = 877,
        ReconnectShellExCallBackErrr = 878,
        // END: Error IDs introduced for disconnect/reconnect
        // Cmdlets related range: 900-999
        RemoteRunspaceInfoHasDuplicates = 900,
        RemoteRunspaceInfoLimitExceeded = 901,
        RemoteRunspaceOpenUnknownState = 902,
        UriSpecifiedNotValid = 903,
        RemoteRunspaceClosed = 904,
        RemoteRunspaceNotAvailableForSpecifiedComputer = 905,
        RemoteRunspaceNotAvailableForSpecifiedRunspaceId = 906,
        StopPSJobWhatIfTarget = 907,
        InvalidJobStateGeneral = 909,
        JobWithSpecifiedNameNotFound = 910,
        JobWithSpecifiedInstanceIdNotFound = 911,
        JobWithSpecifiedSessionIdNotFound = 912,
        JobWithSpecifiedNameNotCompleted = 913,
        JobWithSpecifiedSessionIdNotCompleted = 914,
        JobWithSpecifiedInstanceIdNotCompleted = 915,
        RemovePSJobWhatIfTarget = 916,
        ComputerNameParamNotSupported = 917,
        RunspaceParamNotSupported = 918,
        RemoteRunspaceNotAvailableForSpecifiedName = 919,
        RemoteRunspaceNotAvailableForSpecifiedSessionId = 920,
        ItemNotFoundInRepository = 921,
        CannotRemoveJob = 922,
        NewRunspaceAmbiguousAuthentication = 923,
        WildCardErrorFilePathParameter = 924,
        FilePathNotFromFileSystemProvider = 925,
        FilePathShouldPS1Extension = 926,
        PSSessionConfigurationName = 927,
        PSSessionAppName = 928,
        // Custom Shell commands
        CSCDoubleParameterOutOfRange = 929,
        URIRedirectionReported = 930,
        NoMoreInputWrites = 931,
        InvalidComputerName = 932,
        ProxyAmbiguousAuthentication = 933,
        ProxyCredentialWithoutAccess = 934,

        // Start-PSSession related error codes.
        PushedRunspaceMustBeOpen = 951,
        HostDoesNotSupportPushRunspace = 952,
        RemoteRunspaceHasMultipleMatchesForSpecifiedRunspaceId = 953,
        RemoteRunspaceHasMultipleMatchesForSpecifiedSessionId = 954,
        RemoteRunspaceHasMultipleMatchesForSpecifiedName = 955,
        RemoteRunspaceDoesNotSupportPushRunspace = 956,
        HostInNestedPrompt = 957,
        RemoteHostDoesNotSupportPushRunspace = 958,
        InvalidVMId = 959,
        InvalidVMNameNoVM = 960,
        InvalidVMNameMultipleVM = 961,
        HyperVModuleNotAvailable = 962,
        InvalidUsername = 963,
        InvalidCredential = 964,
        VMSessionConnectFailed = 965,
        InvalidContainerId = 966,
        CannotCreateProcessInContainer = 967,
        CannotTerminateProcessInContainer = 968,
        ContainersFeatureNotEnabled = 969,
        RemoteSessionHyperVSocketServerConstructorFailure = 970,
        ContainerSessionConnectFailed = 973,
        RemoteSessionHyperVSocketClientConstructorSetSocketOptionFailure = 974,
        InvalidVMState = 975,

        // Invoke-Command related error codes.
        InvalidVMIdNotSingle = 981,
        InvalidVMNameNotSingle = 982,

        // SessionState Description related messages
        WsmanMaxRedirectionCountVariableDescription = 1001,
        PSDefaultSessionOptionDescription = 1002,
        PSSenderInfoDescription = 1004,

        // IPC for Background jobs related errors: 2000
        IPCUnknownNodeType = 2001,
        IPCInsufficientDataforElement = 2002,
        IPCWrongAttributeCountForDataElement = 2003,
        IPCOnlyTextExpectedInDataElement = 2004,
        IPCWrongAttributeCountForElement = 2005,
        IPCUnknownElementReceived = 2006,
        IPCSupportsOnlyDefaultAuth = 2007,
        IPCWowComponentNotPresent = 2008,
        IPCServerProcessReportedError = 2100,
        IPCServerProcessExited = 2101,
        IPCErrorProcessingServerData = 2102,
        IPCUnknownCommandGuid = 2103,
        IPCNoSignalForSession = 2104,
        IPCSignalTimedOut = 2105,
        IPCCloseTimedOut = 2106,
        IPCExceptionLaunchingProcess = 2107,
    }
    internal static class PSRemotingErrorInvariants
    {
        internal static string FormatResourceString(string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1628, 11250, 11492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 11363, 11435);

                string
                resourceFormatedString = f_1628_11395_11434(resourceString, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 11451, 11481);

                return resourceFormatedString;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1628, 11250, 11492);

                string
                f_1628_11395_11434(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 11395, 11434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 11250, 11492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 11250, 11492);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSRemotingErrorInvariants()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1628, 10689, 11499);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1628, 10689, 11499);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 10689, 11499);
        }

    }
    [Serializable]
    public class PSRemotingDataStructureException : RuntimeException
    {
        public PSRemotingDataStructureException()
        : base(f_1628_11924_12077_C(f_1628_11924_12077(f_1628_11971_12025(), f_1628_12027_12076(typeof(PSRemotingDataStructureException)))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 11862, 12138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 12103, 12127);

                f_1628_12103_12126(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 11862, 12138);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 11862, 12138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 11862, 12138);
            }
        }

        public PSRemotingDataStructureException(string message)
        : base(f_1628_12460_12467_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 12384, 12528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 12493, 12517);

                f_1628_12493_12516(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 12384, 12528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 12384, 12528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 12384, 12528);
            }
        }

        public PSRemotingDataStructureException(string message, Exception innerException)
        : base(f_1628_12995_13002_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 12893, 13079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 13044, 13068);

                f_1628_13044_13067(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 12893, 13079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 12893, 13079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 12893, 13079);
            }
        }

        internal PSRemotingDataStructureException(string resourceString, params object[] args)
        : base(f_1628_13571_13639_C(f_1628_13571_13639(resourceString, args)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 13464, 13700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 13665, 13689);

                f_1628_13665_13688(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 13464, 13700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 13464, 13700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 13464, 13700);
            }
        }

        internal PSRemotingDataStructureException(Exception innerException, string resourceString, params object[] args)
        : base(f_1628_14311_14379_C(f_1628_14311_14379(resourceString, args)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 14178, 14456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 14421, 14445);

                f_1628_14421_14444(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 14178, 14456);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 14178, 14456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 14178, 14456);
            }
        }

        protected PSRemotingDataStructureException(SerializationInfo info, StreamingContext context)
        : base(f_1628_14773_14777_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 14660, 14809);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 14660, 14809);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 14660, 14809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 14660, 14809);
            }
        }

        private void SetDefaultErrorRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 14945, 15145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15006, 15058);

                f_1628_15006_15057(this, ErrorCategory.ResourceUnavailable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15072, 15134);

                f_1628_15072_15133(this, f_1628_15083_15132(typeof(PSRemotingDataStructureException)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 14945, 15145);

                int
                f_1628_15006_15057(System.Management.Automation.Remoting.PSRemotingDataStructureException
                this_param, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    this_param.SetErrorCategory(errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 15006, 15057);
                    return 0;
                }


                string
                f_1628_15083_15132(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 15083, 15132);
                    return return_v;
                }


                int
                f_1628_15072_15133(System.Management.Automation.Remoting.PSRemotingDataStructureException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 15072, 15133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 14945, 15145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 14945, 15145);
            }
        }

        static PSRemotingDataStructureException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1628, 11648, 15152);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1628, 11648, 15152);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 11648, 15152);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1628, 11648, 15152);

        static string
        f_1628_11971_12025()
        {
            var return_v = RemotingErrorIdStrings.DefaultRemotingExceptionMessage;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 11971, 12025);
            return return_v;
        }


        static string
        f_1628_12027_12076(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 12027, 12076);
            return return_v;
        }


        static string
        f_1628_11924_12077(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 11924, 12077);
            return return_v;
        }


        int
        f_1628_12103_12126(System.Management.Automation.Remoting.PSRemotingDataStructureException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 12103, 12126);
            return 0;
        }


        static string
        f_1628_11924_12077_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 11862, 12138);
            return return_v;
        }


        int
        f_1628_12493_12516(System.Management.Automation.Remoting.PSRemotingDataStructureException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 12493, 12516);
            return 0;
        }


        static string
        f_1628_12460_12467_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 12384, 12528);
            return return_v;
        }


        int
        f_1628_13044_13067(System.Management.Automation.Remoting.PSRemotingDataStructureException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 13044, 13067);
            return 0;
        }


        static string
        f_1628_12995_13002_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 12893, 13079);
            return return_v;
        }


        static string
        f_1628_13571_13639(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 13571, 13639);
            return return_v;
        }


        int
        f_1628_13665_13688(System.Management.Automation.Remoting.PSRemotingDataStructureException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 13665, 13688);
            return 0;
        }


        static string
        f_1628_13571_13639_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 13464, 13700);
            return return_v;
        }


        static string
        f_1628_14311_14379(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 14311, 14379);
            return return_v;
        }


        int
        f_1628_14421_14444(System.Management.Automation.Remoting.PSRemotingDataStructureException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 14421, 14444);
            return 0;
        }


        static string
        f_1628_14311_14379_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 14178, 14456);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1628_14773_14777_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 14660, 14809);
            return return_v;
        }

    }
    [Serializable]
    public class PSRemotingTransportException : RuntimeException
    {
        private int _errorCode;

        private string _transportMessage;

        public PSRemotingTransportException()
        : base(f_1628_15660_15809_C(f_1628_15660_15809(f_1628_15707_15761(), f_1628_15763_15808(typeof(PSRemotingTransportException)))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 15602, 15870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15411, 15421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15447, 15464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15835, 15859);

                f_1628_15835_15858(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 15602, 15870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 15602, 15870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 15602, 15870);
            }
        }

        public PSRemotingTransportException(string message)
        : base(f_1628_16162_16169_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 16090, 16230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15411, 15421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15447, 15464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 16195, 16219);

                f_1628_16195_16218(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 16090, 16230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 16090, 16230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 16090, 16230);
            }
        }

        public PSRemotingTransportException(string message, Exception innerException)
        : base(f_1628_16658_16665_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 16560, 16742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15411, 15421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15447, 15464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 16707, 16731);

                f_1628_16707_16730(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 16560, 16742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 16560, 16742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 16560, 16742);
            }
        }

        internal PSRemotingTransportException(PSRemotingErrorId errorId, string resourceString, params object[] args)
        : base(f_1628_17368_17436_C(f_1628_17368_17436(resourceString, args)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 17238, 17537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15411, 15421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15447, 15464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 17462, 17486);

                f_1628_17462_17485(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 17500, 17526);

                _errorCode = (int)errorId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 17238, 17537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 17238, 17537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 17238, 17537);
            }
        }

        internal PSRemotingTransportException(Exception innerException, string resourceString, params object[] args)
        : base(f_1628_18144_18212_C(f_1628_18144_18212(resourceString, args)), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 18015, 18289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15411, 15421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15447, 15464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 18254, 18278);

                f_1628_18254_18277(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 18015, 18289);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 18015, 18289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 18015, 18289);
            }
        }

        protected PSRemotingTransportException(SerializationInfo info, StreamingContext context)
        : base(f_1628_18712_18716_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 18603, 18994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15411, 15421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 15447, 15464);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 18751, 18858) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1628, 18751, 18858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 18801, 18843);

                    throw f_1628_18807_18842("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1628, 18751, 18858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 18874, 18914);

                _errorCode = f_1628_18887_18913(info, "ErrorCode");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 18928, 18983);

                _transportMessage = f_1628_18948_18982(info, "TransportMessage");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 18603, 18994);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 18603, 18994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 18603, 18994);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 19261, 19829);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 19463, 19570) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1628, 19463, 19570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 19513, 19555);

                    throw f_1628_19519_19554("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1628, 19463, 19570);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 19586, 19620);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1628, 19586, 19619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 19712, 19751);

                f_1628_19712_19750(            // If there are simple fields, serialize them with info.AddValue
                            info, "ErrorCode", _errorCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 19765, 19818);

                f_1628_19765_19817(info, "TransportMessage", _transportMessage);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 19261, 19829);

                System.Management.Automation.PSArgumentNullException
                f_1628_19519_19554(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 19519, 19554);
                    return return_v;
                }


                int
                f_1628_19712_19750(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, int
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 19712, 19750);
                    return 0;
                }


                int
                f_1628_19765_19817(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 19765, 19817);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 19261, 19829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 19261, 19829);
            }
        }

        protected void SetDefaultErrorRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 19930, 20132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 19993, 20045);

                f_1628_19993_20044(this, ErrorCategory.ResourceUnavailable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 20059, 20121);

                f_1628_20059_20120(this, f_1628_20070_20119(typeof(PSRemotingDataStructureException)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 19930, 20132);

                int
                f_1628_19993_20044(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    this_param.SetErrorCategory(errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 19993, 20044);
                    return 0;
                }


                string
                f_1628_20070_20119(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 20070, 20119);
                    return return_v;
                }


                int
                f_1628_20059_20120(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 20059, 20120);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 19930, 20132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 19930, 20132);
            }
        }

        public int ErrorCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 20294, 20363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 20330, 20348);

                    return _errorCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 20294, 20363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 20249, 20460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 20249, 20460);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 20379, 20449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 20415, 20434);

                    _errorCode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 20379, 20449);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 20249, 20460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 20249, 20460);
                }
            }
        }

        public string TransportMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 20637, 20713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 20673, 20698);

                    return _transportMessage;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 20637, 20713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 20582, 20817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 20582, 20817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 20729, 20806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 20765, 20791);

                    _transportMessage = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 20729, 20806);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 20582, 20817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 20582, 20817);
                }
            }
        }

        static PSRemotingTransportException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1628, 15302, 20824);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1628, 15302, 20824);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 15302, 20824);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1628, 15302, 20824);

        static string
        f_1628_15707_15761()
        {
            var return_v = RemotingErrorIdStrings.DefaultRemotingExceptionMessage;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 15707, 15761);
            return return_v;
        }


        static string
        f_1628_15763_15808(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 15763, 15808);
            return return_v;
        }


        static string
        f_1628_15660_15809(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 15660, 15809);
            return return_v;
        }


        int
        f_1628_15835_15858(System.Management.Automation.Remoting.PSRemotingTransportException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 15835, 15858);
            return 0;
        }


        static string
        f_1628_15660_15809_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 15602, 15870);
            return return_v;
        }


        int
        f_1628_16195_16218(System.Management.Automation.Remoting.PSRemotingTransportException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 16195, 16218);
            return 0;
        }


        static string
        f_1628_16162_16169_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 16090, 16230);
            return return_v;
        }


        int
        f_1628_16707_16730(System.Management.Automation.Remoting.PSRemotingTransportException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 16707, 16730);
            return 0;
        }


        static string
        f_1628_16658_16665_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 16560, 16742);
            return return_v;
        }


        static string
        f_1628_17368_17436(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 17368, 17436);
            return return_v;
        }


        int
        f_1628_17462_17485(System.Management.Automation.Remoting.PSRemotingTransportException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 17462, 17485);
            return 0;
        }


        static string
        f_1628_17368_17436_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 17238, 17537);
            return return_v;
        }


        static string
        f_1628_18144_18212(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 18144, 18212);
            return return_v;
        }


        int
        f_1628_18254_18277(System.Management.Automation.Remoting.PSRemotingTransportException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 18254, 18277);
            return 0;
        }


        static string
        f_1628_18144_18212_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 18015, 18289);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1628_18807_18842(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 18807, 18842);
            return return_v;
        }


        int
        f_1628_18887_18913(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetInt32(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 18887, 18913);
            return return_v;
        }


        string?
        f_1628_18948_18982(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 18948, 18982);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1628_18712_18716_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 18603, 18994);
            return return_v;
        }

    }
    [Serializable]
    public class PSRemotingTransportRedirectException : PSRemotingTransportException
    {
        public PSRemotingTransportRedirectException()
        : base(f_1628_21296_21467_C(f_1628_21296_21467(f_1628_21343_21397(), f_1628_21413_21466(typeof(PSRemotingTransportRedirectException)))))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 21230, 21528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25531, 25570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 21493, 21517);

                f_1628_21493_21516(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 21230, 21528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 21230, 21528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 21230, 21528);
            }
        }

        public PSRemotingTransportRedirectException(string message)
        : base(f_1628_21828_21835_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 21748, 21858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25531, 25570);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 21748, 21858);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 21748, 21858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 21748, 21858);
            }
        }

        public PSRemotingTransportRedirectException(string message, Exception innerException)
        : base(f_1628_22294_22301_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 22188, 22340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25531, 25570);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 22188, 22340);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 22188, 22340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 22188, 22340);
            }
        }

        internal PSRemotingTransportRedirectException(Exception innerException, string resourceString, params object[] args)
        : base(f_1628_22955_22969_C(innerException), resourceString, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 22818, 23014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25531, 25570);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 22818, 23014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 22818, 23014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 22818, 23014);
            }
        }

        protected PSRemotingTransportRedirectException(SerializationInfo info, StreamingContext context)
        : base(f_1628_23445_23449_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 23328, 23672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25531, 25570);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 23484, 23591) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1628, 23484, 23591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 23534, 23576);

                    throw f_1628_23540_23575("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1628, 23484, 23591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 23607, 23661);

                RedirectLocation = f_1628_23626_23660(info, "RedirectLocation");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 23328, 23672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 23328, 23672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 23328, 23672);
            }
        }

        internal PSRemotingTransportRedirectException(string redirectLocation, PSRemotingErrorId errorId, string resourceString, params object[] args)
        : base(f_1628_24464_24471_C(errorId), resourceString, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 24301, 24566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25531, 25570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 24519, 24555);

                RedirectLocation = redirectLocation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 24301, 24566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 24301, 24566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 24301, 24566);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1628, 24856, 25370);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25058, 25165) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1628, 25058, 25165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25108, 25150);

                    throw f_1628_25114_25149("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1628, 25058, 25165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25181, 25215);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1628, 25181, 25214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1628, 25307, 25359);

                f_1628_25307_25358(            // If there are simple fields, serialize them with info.AddValue
                            info, "RedirectLocation", f_1628_25341_25357());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1628, 24856, 25370);

                System.Management.Automation.PSArgumentNullException
                f_1628_25114_25149(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 25114, 25149);
                    return return_v;
                }


                string
                f_1628_25341_25357()
                {
                    var return_v = RedirectLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 25341, 25357);
                    return return_v;
                }


                int
                f_1628_25307_25358(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 25307, 25358);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 24856, 25370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 24856, 25370);
            }
        }

        public string RedirectLocation { get; }

        static PSRemotingTransportRedirectException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1628, 20991, 25599);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1628, 20991, 25599);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 20991, 25599);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1628, 20991, 25599);

        static string
        f_1628_21343_21397()
        {
            var return_v = RemotingErrorIdStrings.DefaultRemotingExceptionMessage;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 21343, 21397);
            return return_v;
        }


        static string
        f_1628_21413_21466(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1628, 21413, 21466);
            return return_v;
        }


        static string
        f_1628_21296_21467(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 21296, 21467);
            return return_v;
        }


        int
        f_1628_21493_21516(System.Management.Automation.Remoting.PSRemotingTransportRedirectException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 21493, 21516);
            return 0;
        }


        static string
        f_1628_21296_21467_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 21230, 21528);
            return return_v;
        }


        static string
        f_1628_21828_21835_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 21748, 21858);
            return return_v;
        }


        static string
        f_1628_22294_22301_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 22188, 22340);
            return return_v;
        }


        static System.Exception
        f_1628_22955_22969_C(System.Exception
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 22818, 23014);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1628_23540_23575(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 23540, 23575);
            return return_v;
        }


        string?
        f_1628_23626_23660(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1628, 23626, 23660);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1628_23445_23449_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 23328, 23672);
            return return_v;
        }


        static System.Management.Automation.Remoting.PSRemotingErrorId
        f_1628_24464_24471_C(System.Management.Automation.Remoting.PSRemotingErrorId
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 24301, 24566);
            return return_v;
        }

    }
    [Serializable]
    public class PSDirectException : RuntimeException
    {
        public PSDirectException(string message)
        : base(f_1628_26119_26126_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1628, 26058, 26149);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1628, 26058, 26149);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1628, 26058, 26149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 26058, 26149);
            }
        }

        static PSDirectException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1628, 25707, 26190);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1628, 25707, 26190);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1628, 25707, 26190);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1628, 25707, 26190);

        static string
        f_1628_26119_26126_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1628, 26058, 26149);
            return return_v;
        }

    }
}
