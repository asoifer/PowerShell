// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

/*
 * Common file that contains implementation for both server and client transport
 * managers based on WSMan protocol.
 *
 */

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Runspaces.Internal;
using System.Management.Automation.Tracing;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Xml;
using System.Threading;

using PSRemotingCryptoHelper = System.Management.Automation.Internal.PSRemotingCryptoHelper;
using WSManConnectionInfo = System.Management.Automation.Runspaces.WSManConnectionInfo;
using RunspaceConnectionInfo = System.Management.Automation.Runspaces.RunspaceConnectionInfo;
using AuthenticationMechanism = System.Management.Automation.Runspaces.AuthenticationMechanism;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting.Client
{
    internal static class WSManTransportManagerUtils
    {
        private static Dictionary<int, string> s_transportErrorCodeToFQEID;

        internal static TransportErrorOccuredEventArgs ConstructTransportErrorEventArgs(IntPtr wsmanAPIHandle,
                    WSManClientSessionTransportManager wsmanSessionTM,
                    WSManNativeApi.WSManError errorStruct,
                    TransportMethodEnum transportMethodReportingError,
                    string resourceString,
                    params object[] resourceArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 6000, 10058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 6386, 6417);

                PSRemotingTransportException
                e
                = default(PSRemotingTransportException);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 6931, 9821) || true) && ((errorStruct.errorCode == WSManNativeApi.ERROR_WSMAN_REDIRECT_REQUESTED) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 6935, 7035) && (wsmanSessionTM != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 6931, 9821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 7069, 7126);

                    IntPtr
                    wsmanSessionHandle = f_1644_7097_7125(wsmanSessionTM)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 7290, 7468);

                    string
                    redirectLocation = f_1644_7316_7467(wsmanSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_REDIRECT_LOCATION)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 7486, 7642);

                    string
                    winrmMessage = f_1644_7508_7641(f_1644_7508_7634(f_1644_7559_7633(wsmanAPIHandle, errorStruct.errorCode)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 7662, 7930);

                    e = f_1644_7666_7929(redirectLocation, PSRemotingErrorId.URIEndPointNotResolved, f_1644_7809_7854(), winrmMessage, redirectLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 6931, 9821);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 6931, 9821);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 7964, 9821) || true) && ((errorStruct.errorCode == WSManNativeApi.ERROR_WSMAN_INVALID_RESOURCE_URI) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 7968, 8070) && (wsmanSessionTM != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 7964, 9821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 8104, 8263);

                        string
                        configurationName =
                        f_1644_8152_8262(f_1644_8152_8190(f_1644_8152_8181(wsmanSessionTM)), Remoting.Client.WSManNativeApi.ResourceURIPrefix, string.Empty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 8281, 8566);

                        string
                        errorMessage = f_1644_8303_8565(f_1644_8350_8397(), configurationName, f_1644_8522_8564(f_1644_8522_8551(wsmanSessionTM)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 8586, 8824);

                        e = f_1644_8590_8823(PSRemotingErrorId.InvalidConfigurationName, f_1644_8719_8764(), f_1644_8766_8808(f_1644_8766_8795(wsmanSessionTM)), errorMessage);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 8844, 8991);

                        e.TransportMessage = f_1644_8865_8990(f_1644_8915_8989(wsmanAPIHandle, errorStruct.errorCode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 7964, 9821);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 7964, 9821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 9325, 9429);

                        string
                        wsManErrorMessage = f_1644_9352_9428(resourceString, resourceArgs)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 9447, 9638);

                        e = f_1644_9451_9637(PSRemotingErrorId.TroubleShootingHelpTopic, f_1644_9549_9596(), wsManErrorMessage);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 9658, 9806);

                        e.TransportMessage = f_1644_9679_9805(f_1644_9730_9804(wsmanAPIHandle, errorStruct.errorCode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 7964, 9821);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 6931, 9821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 9837, 9873);

                e.ErrorCode = errorStruct.errorCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 9887, 10016);

                TransportErrorOccuredEventArgs
                eventargs =
                f_1644_9947_10015(e, transportMethodReportingError)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 10030, 10047);

                return eventargs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 6000, 10058);

                System.IntPtr
                f_1644_7097_7125(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.SessionHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 7097, 7125);
                    return return_v;
                }


                string
                f_1644_7316_7467(System.IntPtr
                wsManAPIHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option)
                {
                    var return_v = WSManNativeApi.WSManGetSessionOptionAsString(wsManAPIHandle, option);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 7316, 7467);
                    return return_v;
                }


                string
                f_1644_7559_7633(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 7559, 7633);
                    return return_v;
                }


                string
                f_1644_7508_7634(string
                errorMessage)
                {
                    var return_v = ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 7508, 7634);
                    return return_v;
                }


                string
                f_1644_7508_7641(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 7508, 7641);
                    return return_v;
                }


                string
                f_1644_7809_7854()
                {
                    var return_v = RemotingErrorIdStrings.URIEndPointNotResolved;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 7809, 7854);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportRedirectException
                f_1644_7666_7929(string
                redirectLocation, System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportRedirectException(redirectLocation, errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 7666, 7929);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_8152_8181(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8152, 8181);
                    return return_v;
                }


                string
                f_1644_8152_8190(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ShellUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8152, 8190);
                    return return_v;
                }


                string
                f_1644_8152_8262(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 8152, 8262);
                    return return_v;
                }


                string
                f_1644_8350_8397()
                {
                    var return_v = RemotingErrorIdStrings.InvalidConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8350, 8397);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_8522_8551(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8522, 8551);
                    return return_v;
                }


                string
                f_1644_8522_8564(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8522, 8564);
                    return return_v;
                }


                string
                f_1644_8303_8565(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 8303, 8565);
                    return return_v;
                }


                string
                f_1644_8719_8764()
                {
                    var return_v = RemotingErrorIdStrings.ConnectExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8719, 8764);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_8766_8795(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8766, 8795);
                    return return_v;
                }


                string
                f_1644_8766_8808(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 8766, 8808);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_8590_8823(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 8590, 8823);
                    return return_v;
                }


                string
                f_1644_8915_8989(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 8915, 8989);
                    return return_v;
                }


                string
                f_1644_8865_8990(string
                errorMessage)
                {
                    var return_v = ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 8865, 8990);
                    return return_v;
                }


                string
                f_1644_9352_9428(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 9352, 9428);
                    return return_v;
                }


                string
                f_1644_9549_9596()
                {
                    var return_v = RemotingErrorIdStrings.TroubleShootingHelpTopic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 9549, 9596);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_9451_9637(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 9451, 9637);
                    return return_v;
                }


                string
                f_1644_9730_9804(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 9730, 9804);
                    return return_v;
                }


                string
                f_1644_9679_9805(string
                errorMessage)
                {
                    var return_v = ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 9679, 9805);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_9947_10015(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 9947, 10015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 6000, 10058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 6000, 10058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ParseEscapeWSManErrorMessage(string errorMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 10728, 13054);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 10901, 11042) || true) && (f_1644_10905_10939(errorMessage) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 10905, 10973) || (!f_1644_10945_10972(errorMessage, "@{"))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 10901, 11042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 11007, 11027);

                    return errorMessage;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 10901, 11042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 11058, 11127);

                string
                result = f_1644_11074_11126(f_1644_11074_11107(errorMessage, "@{", "'@{"), "}", "}'")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 11141, 11155);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 10728, 13054);

                bool
                f_1644_10905_10939(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 10905, 10939);
                    return return_v;
                }


                bool
                f_1644_10945_10972(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 10945, 10972);
                    return return_v;
                }


                string
                f_1644_11074_11107(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 11074, 11107);
                    return return_v;
                }


                string
                f_1644_11074_11126(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 11074, 11126);
                    return return_v;
                }


                /*
                 * Use this pattern if we need to escape other characters.
                 *
                try
                {
                    StringBuilder msgSB = new StringBuilder(errorMessage);

                    Collection<PSParseError> parserErrors = new Collection<PSParseError>();
                    Collection<PSToken> tokens = PSParser.Tokenize(errorMessage, out parserErrors);
                    if (parserErrors.Count > 0)
                    {
                        tracer.WriteLine(string.Format(CultureInfo.InvariantCulture,
                            "There were errors parsing string '{0}'", errorMessage);
                        return errorMessage;
                    }

                    for (int index = tokens.Count - 1; index > 0; index--)
                    {
                        PSToken currentToken = tokens[index];
                        switch(currentToken.Type)
                        {
                            case PSTokenType.GroupStart:
                                msgSB.Insert(currentToken.StartColumn - 1, "'", 1);
                                break;
                            case PSTokenType.GroupEnd:
                                if (msgSB.Length <= currentToken.EndColumn)
                                {
                                    msgSB.Append("'");
                                }
                                else
                                {
                                    msgSB.Insert(currentToken.EndColumn - 1, ",", 1);
                                }

                                break;
                        }
                    }

                    return msgSB.ToString();
                }
                // ignore possible exceptions manipulating the string.
                catch(ArgumentOutOfRangeException)
                {
                }
                catch(RuntimeException)
                {
                }

                return errorMessage;*/
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 10728, 13054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 10728, 13054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal enum tmStartModes
        {
            None = 1, Create = 2, Connect = 3
        }

        internal static string GetFQEIDFromTransportError(
                    int transportErrorCode,
                    string defaultFQEID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 13542, 14227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 13688, 13711);

                string
                specificErrorId
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 13725, 14180) || true) && (f_1644_13729_13809(s_transportErrorCodeToFQEID, transportErrorCode, out specificErrorId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 13725, 14180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 13843, 13887);

                    return specificErrorId + "," + defaultFQEID;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 13725, 14180);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 13725, 14180);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 13921, 14180) || true) && (transportErrorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 13921, 14180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 14056, 14165);

                        return f_1644_14063_14143(transportErrorCode, f_1644_14091_14142()) + "," + defaultFQEID;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 13921, 14180);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 13725, 14180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 14196, 14216);

                return defaultFQEID;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 13542, 14227);

                bool
                f_1644_13729_13809(System.Collections.Generic.Dictionary<int, string>
                this_param, int
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 13729, 13809);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1644_14091_14142()
                {
                    var return_v = System.Globalization.NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 14091, 14142);
                    return return_v;
                }


                string
                f_1644_14063_14143(int
                this_param, System.Globalization.NumberFormatInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 14063, 14143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 13542, 14227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 13542, 14227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WSManTransportManagerUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1644, 1276, 14256);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 1498, 4883);
            s_transportErrorCodeToFQEID = new Dictionary<int, string>()
        {
            {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => WSManNativeApi.ERROR_WSMAN_ACCESS_DENIED,1644,1528,4883),"AccessDenied"},            {WSManNativeApi.ERROR_WSMAN_OUTOF_MEMORY, "ServerOutOfMemory"},            {WSManNativeApi.ERROR_WSMAN_NETWORKPATH_NOTFOUND, "NetworkPathNotFound"},            {WSManNativeApi.ERROR_WSMAN_COMPUTER_NOTFOUND, "ComputerNotFound"},            {WSManNativeApi.ERROR_WSMAN_AUTHENTICATION_FAILED, "AuthenticationFailed"},            {WSManNativeApi.ERROR_WSMAN_LOGON_FAILURE, "LogonFailure"},            {WSManNativeApi.ERROR_WSMAN_IMPROPER_RESPONSE, "ImproperResponse"},            {WSManNativeApi.ERROR_WSMAN_INCORRECT_PROTOCOLVERSION, "IncorrectProtocolVersion"},            {WSManNativeApi.ERROR_WSMAN_SENDDATA_CANNOT_COMPLETE, "WinRMOperationTimeout"},            {WSManNativeApi.ERROR_WSMAN_URL_NOTAVAILABLE, "URLNotAvailable"},            {WSManNativeApi.ERROR_WSMAN_SENDDATA_CANNOT_CONNECT, "CannotConnect"},            {WSManNativeApi.ERROR_WSMAN_INVALID_RESOURCE_URI, "InvalidResourceUri"},            {WSManNativeApi.ERROR_WSMAN_INUSE_CANNOT_RECONNECT, "CannotConnectAlreadyConnected"},            {WSManNativeApi.ERROR_WSMAN_INVALID_AUTHENTICATION, "InvalidAuthentication"},            {WSManNativeApi.ERROR_WSMAN_SHUTDOWN_INPROGRESS, "ShutDownInProgress"},            {WSManNativeApi.ERROR_WSMAN_CANNOT_CONNECT_INVALID, "CannotConnectInvalidOperation"},            {WSManNativeApi.ERROR_WSMAN_CANNOT_CONNECT_MISMATCH, "CannotConnectMismatchSessions"},            {WSManNativeApi.ERROR_WSMAN_CANNOT_CONNECT_RUNASFAILED, "CannotConnectRunAsFailed"},            {WSManNativeApi.ERROR_WSMAN_CREATEFAILED_INVALIDNAME, "SessionCreateFailedInvalidName"},            {WSManNativeApi.ERROR_WSMAN_TARGETSESSION_DOESNOTEXIST, "CannotConnectTargetSessionDoesNotExist"},            {WSManNativeApi.ERROR_WSMAN_REMOTESESSION_DISALLOWED, "RemoteSessionDisallowed"},            {WSManNativeApi.ERROR_WSMAN_REMOTECONNECTION_DISALLOWED, "RemoteConnectionDisallowed"},            {WSManNativeApi.ERROR_WSMAN_INVALID_RESOURCE_URI2, "InvalidResourceUri"},            {WSManNativeApi.ERROR_WSMAN_CORRUPTED_CONFIG, "CorruptedWinRMConfig"},            {WSManNativeApi.ERROR_WSMAN_OPERATION_ABORTED, "WinRMOperationAborted"},            {WSManNativeApi.ERROR_WSMAN_URI_LIMIT, "URIExceedsMaxAllowedSize"},            {WSManNativeApi.ERROR_WSMAN_CLIENT_KERBEROS_DISABLED, "ClientKerberosDisabled"},            {WSManNativeApi.ERROR_WSMAN_SERVER_NOTTRUSTED, "ServerNotTrusted"},            {WSManNativeApi.ERROR_WSMAN_WORKGROUP_NO_KERBEROS, "WorkgroupCannotUseKerberos"},            {WSManNativeApi.ERROR_WSMAN_EXPLICIT_CREDENTIALS_REQUIRED, "ExplicitCredentialsRequired"},            {WSManNativeApi.ERROR_WSMAN_REDIRECT_LOCATION_INVALID, "RedirectLocationInvalid"},            {WSManNativeApi.ERROR_WSMAN_REDIRECT_REQUESTED, "RedirectInformationRequired"},            {WSManNativeApi.ERROR_WSMAN_BAD_METHOD, "WinRMOperationNotSupportedOnServer"},            {WSManNativeApi.ERROR_WSMAN_HTTP_SERVICE_UNAVAILABLE, "CannotConnectWinRMService"},            {WSManNativeApi.ERROR_WSMAN_HTTP_SERVICE_ERROR, "WinRMHttpError"},            {WSManNativeApi.ERROR_WSMAN_TARGET_UNKNOWN, "TargetUnknown"},            {WSManNativeApi.ERROR_WSMAN_CANNOTUSE_IP, "CannotUseIPAddress"}
        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1644, 1276, 14256);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 1276, 14256);
        }

    }
    internal sealed class WSManClientSessionTransportManager : BaseClientSessionTransportManager
    {
        internal const string
        MAX_URI_REDIRECTION_COUNT_VARIABLE = "WSManMaxRedirectionCount"
        ;

        internal const int
        MAX_URI_REDIRECTION_COUNT = 5
        ;



        private enum CompletionNotification
        {
            DisconnectCompleted
        }
        private class CompletionEventArgs : EventArgs
        {
            internal CompletionEventArgs(CompletionNotification notification)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1644, 15214, 15355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 15371, 15424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 15312, 15340);

                    Notification = notification;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1644, 15214, 15355);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 15214, 15355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 15214, 15355);
                }
            }

            internal CompletionNotification Notification { get; }

            static CompletionEventArgs()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1644, 15144, 15435);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1644, 15144, 15435);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 15144, 15435);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1644, 15144, 15435);
        }

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _wsManSessionHandle;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _wsManShellOperationHandle;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _wsManReceiveOperationHandle;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _wsManSendOperationHandle;

        private long _sessionContextID;

        private WSManTransportManagerUtils.tmStartModes _startMode;

        private string _sessionName;

        private PrioritySendDataCollection.OnDataAvailableCallback _onDataAvailableToSendCallback;

        private WSManNativeApi.WSManShellAsync _createSessionCallback;

        private WSManNativeApi.WSManShellAsync _receivedFromRemote;

        private WSManNativeApi.WSManShellAsync _sendToRemoteCompleted;

        private WSManNativeApi.WSManShellAsync _disconnectSessionCompleted;

        private WSManNativeApi.WSManShellAsync _reconnectSessionCompleted;

        private WSManNativeApi.WSManShellAsync _connectSessionCallback;

        private GCHandle _createSessionCallbackGCHandle;

        private WSManNativeApi.WSManShellAsync _closeSessionCompleted;

        private WSManNativeApi.WSManData_ManToUn _openContent;

        private bool _noCompression;

        private bool _noMachineProfile;

        private int _connectionRetryCount;

        private const string
        resBaseName = "remotingerroridstrings"
        ;

        private int _maxRetryTime;

        private void ProcessShellData(string data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 18021, 21863);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18124, 18223);

                    XmlReaderSettings
                    settings = f_1644_18153_18222(f_1644_18153_18214())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18241, 18283);

                    settings.MaxCharactersFromEntities = 1024;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18361, 18406);

                    settings.MaxCharactersInDocument = 1024 * 30;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18424, 18483);

                    settings.DtdProcessing = System.Xml.DtdProcessing.Prohibit;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18503, 21700);
                    using (XmlReader
                    reader = f_1644_18529_18579(f_1644_18546_18568(data), settings)
                    )
                    {
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18621, 21681) || true) && (f_1644_18628_18641(reader))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 18621, 21681);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18691, 21658) || true) && (f_1644_18695_18710(reader) == XmlNodeType.Element)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 18691, 21658);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 18791, 21631) || true) && (f_1644_18795_18869(f_1644_18795_18811(reader), "IdleTimeOut", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 18795, 18983) || f_1644_18906_18983(f_1644_18906_18922(reader), "MaxIdleTimeOut", StringComparison.OrdinalIgnoreCase)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 18791, 21631);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 19049, 19191);

                                        bool
                                        settingIdleTimeout =
                                                                            !f_1644_19113_19190(f_1644_19113_19129(reader), "MaxIdleTimeOut", StringComparison.OrdinalIgnoreCase)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 19227, 19286);

                                        string
                                        timeoutString = f_1644_19250_19285(reader)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 19320, 19489);

                                        f_1644_19320_19488(f_1644_19331_19409(f_1644_19331_19360(timeoutString, 0, 2), "PT", StringComparison.OrdinalIgnoreCase), "IdleTimeout is not in expected format");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 19525, 19571);

                                        int
                                        decimalIndex = f_1644_19544_19570(timeoutString, '.')
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 19681, 19892);

                                            int
                                            timeout = f_1644_19695_19788(f_1644_19711_19755(timeoutString, 2, decimalIndex - 2), f_1644_19757_19787()) * 1000 + f_1644_19798_19891(f_1644_19814_19858(timeoutString, decimalIndex + 1, 3), f_1644_19860_19890())
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 19930, 20312) || true) && (settingIdleTimeout)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 19930, 20312);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 20034, 20071);

                                                f_1644_20034_20048().IdleTimeout = timeout;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 19930, 20312);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 19930, 20312);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 20233, 20273);

                                                f_1644_20233_20247().MaxIdleTimeout = timeout;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 19930, 20312);
                                            }
                                        }
                                        catch (InvalidCastException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1644, 20381, 20576);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 20482, 20541);

                                            f_1644_20482_20540(false, "IdleTimeout is not in expected format");
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1644, 20381, 20576);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 18791, 21631);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 18791, 21631);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 20642, 21631) || true) && (f_1644_20646_20719(f_1644_20646_20662(reader), "BufferMode", StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 20642, 21631);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 20785, 20841);

                                            string
                                            bufferMode = f_1644_20805_20840(reader)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 20877, 21600) || true) && (f_1644_20881_20943(bufferMode, "Block", StringComparison.OrdinalIgnoreCase))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 20877, 21600);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 21017, 21090);

                                                f_1644_21017_21031().OutputBufferingMode = Runspaces.OutputBufferingMode.Block;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 20877, 21600);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 20877, 21600);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 21164, 21600) || true) && (f_1644_21168_21229(bufferMode, "Drop", StringComparison.OrdinalIgnoreCase))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 21164, 21600);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 21303, 21375);

                                                    f_1644_21303_21317().OutputBufferingMode = Runspaces.OutputBufferingMode.Drop;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 21164, 21600);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 21164, 21600);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 21521, 21565);

                                                    f_1644_21521_21564(false, "unexpected buffer mode");
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 21164, 21600);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 20877, 21600);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 20642, 21631);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 18791, 21631);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 18691, 21658);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 18621, 21681);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1644, 18621, 21681);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1644, 18621, 21681);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 18503, 21700);
                    }
                }
                catch (XmlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1644, 21729, 21852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 21782, 21837);

                    f_1644_21782_21836(false, "shell xml is in unexpected format");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1644, 21729, 21852);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 18021, 21863);

                System.Xml.XmlReaderSettings
                f_1644_18153_18214()
                {
                    var return_v = InternalDeserializer.XmlReaderSettingsForUntrustedXmlDocument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 18153, 18214);
                    return return_v;
                }


                System.Xml.XmlReaderSettings
                f_1644_18153_18222(System.Xml.XmlReaderSettings
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 18153, 18222);
                    return return_v;
                }


                System.IO.StringReader
                f_1644_18546_18568(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 18546, 18568);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1644_18529_18579(System.IO.StringReader
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.TextReader)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 18529, 18579);
                    return return_v;
                }


                bool
                f_1644_18628_18641(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 18628, 18641);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1644_18695_18710(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 18695, 18710);
                    return return_v;
                }


                string
                f_1644_18795_18811(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 18795, 18811);
                    return return_v;
                }


                bool
                f_1644_18795_18869(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 18795, 18869);
                    return return_v;
                }


                string
                f_1644_18906_18922(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 18906, 18922);
                    return return_v;
                }


                bool
                f_1644_18906_18983(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 18906, 18983);
                    return return_v;
                }


                string
                f_1644_19113_19129(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 19113, 19129);
                    return return_v;
                }


                bool
                f_1644_19113_19190(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19113, 19190);
                    return return_v;
                }


                string
                f_1644_19250_19285(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.ReadElementContentAsString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19250, 19285);
                    return return_v;
                }


                string
                f_1644_19331_19360(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19331, 19360);
                    return return_v;
                }


                bool
                f_1644_19331_19409(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19331, 19409);
                    return return_v;
                }


                int
                f_1644_19320_19488(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19320, 19488);
                    return 0;
                }


                int
                f_1644_19544_19570(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19544, 19570);
                    return return_v;
                }


                string
                f_1644_19711_19755(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19711, 19755);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1644_19757_19787()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 19757, 19787);
                    return return_v;
                }


                int
                f_1644_19695_19788(string
                value, System.Globalization.NumberFormatInfo
                provider)
                {
                    var return_v = Convert.ToInt32(value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19695, 19788);
                    return return_v;
                }


                string
                f_1644_19814_19858(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19814, 19858);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1644_19860_19890()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 19860, 19890);
                    return return_v;
                }


                int
                f_1644_19798_19891(string
                value, System.Globalization.NumberFormatInfo
                provider)
                {
                    var return_v = Convert.ToInt32(value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 19798, 19891);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_20034_20048()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 20034, 20048);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_20233_20247()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 20233, 20247);
                    return return_v;
                }


                int
                f_1644_20482_20540(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 20482, 20540);
                    return 0;
                }


                string
                f_1644_20646_20662(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 20646, 20662);
                    return return_v;
                }


                bool
                f_1644_20646_20719(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 20646, 20719);
                    return return_v;
                }


                string
                f_1644_20805_20840(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.ReadElementContentAsString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 20805, 20840);
                    return return_v;
                }


                bool
                f_1644_20881_20943(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 20881, 20943);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_21017_21031()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 21017, 21031);
                    return return_v;
                }


                bool
                f_1644_21168_21229(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 21168, 21229);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_21303_21317()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 21303, 21317);
                    return return_v;
                }


                int
                f_1644_21521_21564(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 21521, 21564);
                    return 0;
                }


                int
                f_1644_21782_21836(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 21782, 21836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 18021, 21863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 18021, 21863);
            }
        }

        private static WSManNativeApi.WSManShellAsyncCallback s_sessionCreateCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_sessionCloseCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_sessionReceiveCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_sessionSendCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_sessionDisconnectCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_sessionReconnectCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_sessionConnectCallback;

        private static Dictionary<long, WSManClientSessionTransportManager> s_sessionTMHandles;

        private static long s_sessionTMSeed;

        private static long GetNextSessionTMHandleId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 22964, 23113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 23035, 23102);

                return f_1644_23042_23101(ref s_sessionTMSeed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 22964, 23113);

                long
                f_1644_23042_23101(ref long
                location)
                {
                    var return_v = System.Threading.Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 23042, 23101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 22964, 23113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 22964, 23113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddSessionTransportManager(long sessnTMId,
                    WSManClientSessionTransportManager sessnTransportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 23247, 23546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 23411, 23429);
                lock (s_sessionTMHandles)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 23463, 23520);

                    f_1644_23463_23519(s_sessionTMHandles, sessnTMId, sessnTransportManager);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 23247, 23546);

                int
                f_1644_23463_23519(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager>
                this_param, long
                key, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 23463, 23519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 23247, 23546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 23247, 23546);
            }
        }

        private static void RemoveSessionTransportManager(long sessnTMId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 23558, 23769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 23654, 23672);
                lock (s_sessionTMHandles)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 23706, 23743);

                    f_1644_23706_23742(s_sessionTMHandles, sessnTMId);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 23558, 23769);

                bool
                f_1644_23706_23742(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager>
                this_param, long
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 23706, 23742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 23558, 23769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 23558, 23769);
            }
        }

        private static bool TryGetSessionTransportManager(IntPtr operationContext,
                    out WSManClientSessionTransportManager sessnTransportManager,
                    out long sessnTMId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 23903, 24366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 24110, 24149);

                sessnTMId = operationContext.ToInt64();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 24163, 24192);

                sessnTransportManager = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 24212, 24230);
                lock (s_sessionTMHandles)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 24264, 24340);

                    return f_1644_24271_24339(s_sessionTMHandles, sessnTMId, out sessnTransportManager);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 23903, 24366);

                bool
                f_1644_24271_24339(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager>
                this_param, long
                key, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 24271, 24339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 23903, 24366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 23903, 24366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Delegate s_sessionSendRedirect;

        private static Delegate s_protocolVersionRedirect;

        static WSManClientSessionTransportManager()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1644, 24764, 26790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 14696, 14759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 14892, 14921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17859, 17897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 22776, 22868);
                s_sessionTMHandles = f_1644_22810_22868();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 22899, 22914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 24489, 24517);
                s_sessionSendRedirect = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 24552, 24584);
                s_protocolVersionRedirect = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 24878, 25029);

                WSManNativeApi.WSManShellCompletionFunction
                createDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnCreateSessionCallback)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25043, 25128);

                s_sessionCreateCallback = f_1644_25069_25127(createDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25144, 25294);

                WSManNativeApi.WSManShellCompletionFunction
                closeDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnCloseSessionCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25308, 25391);

                s_sessionCloseCallback = f_1644_25333_25390(closeDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25407, 25563);

                WSManNativeApi.WSManShellCompletionFunction
                receiveDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteSessionDataReceived)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25577, 25664);

                s_sessionReceiveCallback = f_1644_25604_25663(receiveDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25680, 25834);

                WSManNativeApi.WSManShellCompletionFunction
                sendDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteSessionSendCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25848, 25929);

                s_sessionSendCallback = f_1644_25872_25928(sendDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 25945, 26111);

                WSManNativeApi.WSManShellCompletionFunction
                disconnectDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteSessionDisconnectCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 26125, 26218);

                s_sessionDisconnectCallback = f_1644_26155_26217(disconnectDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 26234, 26398);

                WSManNativeApi.WSManShellCompletionFunction
                reconnectDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteSessionReconnectCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 26412, 26503);

                s_sessionReconnectCallback = f_1644_26441_26502(reconnectDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 26519, 26678);

                WSManNativeApi.WSManShellCompletionFunction
                connectDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteSessionConnectCallback)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 26692, 26779);

                s_sessionConnectCallback = f_1644_26719_26778(connectDelegate);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1644, 24764, 26790);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 24764, 26790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 24764, 26790);
            }
        }

        internal WSManClientSessionTransportManager(Guid runspacePoolInstanceId,
                    WSManConnectionInfo connectionInfo,
                    PSRemotingCryptoHelper cryptoHelper, string sessionName) : base(f_1644_27866_27888_C(runspacePoolInstanceId), cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1644, 27667, 29442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16267, 16284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16345, 16402);
                this._startMode = WSManTransportManagerUtils.tmStartModes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16430, 16442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16536, 16566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16657, 16679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16729, 16748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16798, 16820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16870, 16897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 16947, 16973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17023, 17046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17329, 17351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17580, 17592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17724, 17738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17762, 17779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17804, 17825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 17995, 18008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39723, 39785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39797, 39851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 84102, 84167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 27970, 28010);

                WSManAPIData = f_1644_27985_28009();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 28024, 28263) || true) && (f_1644_28028_28055(f_1644_28028_28040()) == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 28024, 28263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 28104, 28248);

                    throw f_1644_28110_28247(f_1644_28165_28246(f_1644_28183_28221(), f_1644_28223_28245(f_1644_28223_28235())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 28024, 28263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 28279, 28347);

                f_1644_28279_28346(connectionInfo != null, "connectionInfo cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 28363, 28391);

                CryptoHelper = cryptoHelper;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 28405, 28447);

                dataToBeSent.Fragmentor = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Fragmentor, 1644, 28431, 28446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 28461, 28488);

                _sessionName = sessionName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 29052, 29106);

                f_1644_29052_29074().MaximumReceivedDataSize = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 29120, 29212);

                f_1644_29120_29142().MaximumReceivedObjectSize = f_1644_29171_29211(connectionInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 29228, 29358);

                _onDataAvailableToSendCallback =
                                new PrioritySendDataCollection.OnDataAvailableCallback(OnDataAvailableCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 29374, 29431);

                f_1644_29374_29430(this, f_1644_29385_29413(connectionInfo), connectionInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1644, 27667, 29442);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 27667, 29442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 27667, 29442);
            }
        }

        internal void SetDefaultTimeOut(int milliseconds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 29977, 30923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 30051, 30131);

                f_1644_30051_30130(_wsManSessionHandle != IntPtr.Zero, "Session handle cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 30145, 30912);
                using (f_1644_30152_30229(tracer, "Setting Default timeout: {0} milliseconds", milliseconds))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 30263, 30501);

                    int
                    result = f_1644_30276_30500(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_DEFAULT_OPERATION_TIMEOUTMS, f_1644_30452_30499(milliseconds))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 30521, 30897) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 30521, 30897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 30635, 30730);

                        string
                        errorMessage = f_1644_30657_30729(f_1644_30693_30720(f_1644_30693_30705()), result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 30754, 30840);

                        PSInvalidOperationException
                        exception = f_1644_30794_30839(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 30862, 30878);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 30521, 30897);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 30145, 30912);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 29977, 30923);

                int
                f_1644_30051_30130(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 30051, 30130);
                    return 0;
                }


                System.IDisposable
                f_1644_30152_30229(System.Management.Automation.PSTraceSource
                this_param, string
                format, params object[]
                args)
                {
                    var return_v = this_param.TraceMethod(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 30152, 30229);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_30452_30499(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 30452, 30499);
                    return return_v;
                }


                int
                f_1644_30276_30500(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 30276, 30500);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_30693_30705()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 30693, 30705);
                    return return_v;
                }


                System.IntPtr
                f_1644_30693_30720(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 30693, 30720);
                    return return_v;
                }


                string
                f_1644_30657_30729(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 30657, 30729);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_30794_30839(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 30794, 30839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 29977, 30923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 29977, 30923);
            }
        }

        internal void SetConnectTimeOut(int milliseconds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 31285, 32230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 31359, 31439);

                f_1644_31359_31438(_wsManSessionHandle != IntPtr.Zero, "Session handle cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 31453, 32219);
                using (f_1644_31460_31541(tracer, "Setting CreateShell timeout: {0} milliseconds", milliseconds))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 31575, 31808);

                    int
                    result = f_1644_31588_31807(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_TIMEOUTMS_CREATE_SHELL, f_1644_31759_31806(milliseconds))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 31828, 32204) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 31828, 32204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 31942, 32037);

                        string
                        errorMessage = f_1644_31964_32036(f_1644_32000_32027(f_1644_32000_32012()), result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 32061, 32147);

                        PSInvalidOperationException
                        exception = f_1644_32101_32146(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 32169, 32185);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 31828, 32204);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 31453, 32219);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 31285, 32230);

                int
                f_1644_31359_31438(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 31359, 31438);
                    return 0;
                }


                System.IDisposable
                f_1644_31460_31541(System.Management.Automation.PSTraceSource
                this_param, string
                format, params object[]
                args)
                {
                    var return_v = this_param.TraceMethod(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 31460, 31541);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_31759_31806(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 31759, 31806);
                    return return_v;
                }


                int
                f_1644_31588_31807(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 31588, 31807);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_32000_32012()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 32000, 32012);
                    return return_v;
                }


                System.IntPtr
                f_1644_32000_32027(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 32000, 32027);
                    return return_v;
                }


                string
                f_1644_31964_32036(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 31964, 32036);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_32101_32146(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 32101, 32146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 31285, 32230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 31285, 32230);
            }
        }

        internal void SetCloseTimeOut(int milliseconds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 32591, 33542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 32663, 32743);

                f_1644_32663_32742(_wsManSessionHandle != IntPtr.Zero, "Session handle cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 32757, 33531);
                using (f_1644_32764_32844(tracer, "Setting CloseShell timeout: {0} milliseconds", milliseconds))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 32878, 33120);

                    int
                    result = f_1644_32891_33119(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_TIMEOUTMS_CLOSE_SHELL_OPERATION, f_1644_33071_33118(milliseconds))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 33140, 33516) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 33140, 33516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 33254, 33349);

                        string
                        errorMessage = f_1644_33276_33348(f_1644_33312_33339(f_1644_33312_33324()), result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 33373, 33459);

                        PSInvalidOperationException
                        exception = f_1644_33413_33458(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 33481, 33497);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 33140, 33516);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 32757, 33531);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 32591, 33542);

                int
                f_1644_32663_32742(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 32663, 32742);
                    return 0;
                }


                System.IDisposable
                f_1644_32764_32844(System.Management.Automation.PSTraceSource
                this_param, string
                format, params object[]
                args)
                {
                    var return_v = this_param.TraceMethod(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 32764, 32844);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_33071_33118(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 33071, 33118);
                    return return_v;
                }


                int
                f_1644_32891_33119(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 32891, 33119);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_33312_33324()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 33312, 33324);
                    return return_v;
                }


                System.IntPtr
                f_1644_33312_33339(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 33312, 33339);
                    return return_v;
                }


                string
                f_1644_33276_33348(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 33276, 33348);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_33413_33458(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 33413, 33458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 32591, 33542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 32591, 33542);
            }
        }

        internal void SetSendTimeOut(int milliseconds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 33912, 34861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 33983, 34063);

                f_1644_33983_34062(_wsManSessionHandle != IntPtr.Zero, "Session handle cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 34077, 34850);
                using (f_1644_34084_34168(tracer, "Setting SendShellInput timeout: {0} milliseconds", milliseconds))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 34202, 34439);

                    int
                    result = f_1644_34215_34438(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_TIMEOUTMS_SEND_SHELL_INPUT, f_1644_34390_34437(milliseconds))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 34459, 34835) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 34459, 34835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 34573, 34668);

                        string
                        errorMessage = f_1644_34595_34667(f_1644_34631_34658(f_1644_34631_34643()), result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 34692, 34778);

                        PSInvalidOperationException
                        exception = f_1644_34732_34777(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 34800, 34816);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 34459, 34835);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 34077, 34850);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 33912, 34861);

                int
                f_1644_33983_34062(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 33983, 34062);
                    return 0;
                }


                System.IDisposable
                f_1644_34084_34168(System.Management.Automation.PSTraceSource
                this_param, string
                format, params object[]
                args)
                {
                    var return_v = this_param.TraceMethod(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 34084, 34168);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_34390_34437(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 34390, 34437);
                    return return_v;
                }


                int
                f_1644_34215_34438(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 34215, 34438);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_34631_34643()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 34631, 34643);
                    return return_v;
                }


                System.IntPtr
                f_1644_34631_34658(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 34631, 34658);
                    return return_v;
                }


                string
                f_1644_34595_34667(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 34595, 34667);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_34732_34777(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 34732, 34777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 33912, 34861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 33912, 34861);
            }
        }

        internal void SetReceiveTimeOut(int milliseconds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 35224, 36184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 35298, 35378);

                f_1644_35298_35377(_wsManSessionHandle != IntPtr.Zero, "Session handle cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 35392, 36173);
                using (f_1644_35399_35487(tracer, "Setting ReceiveShellOutput timeout: {0} milliseconds", milliseconds))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 35521, 35762);

                    int
                    result = f_1644_35534_35761(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_TIMEOUTMS_RECEIVE_SHELL_OUTPUT, f_1644_35713_35760(milliseconds))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 35782, 36158) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 35782, 36158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 35896, 35991);

                        string
                        errorMessage = f_1644_35918_35990(f_1644_35954_35981(f_1644_35954_35966()), result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 36015, 36101);

                        PSInvalidOperationException
                        exception = f_1644_36055_36100(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 36123, 36139);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 35782, 36158);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 35392, 36173);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 35224, 36184);

                int
                f_1644_35298_35377(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 35298, 35377);
                    return 0;
                }


                System.IDisposable
                f_1644_35399_35487(System.Management.Automation.PSTraceSource
                this_param, string
                format, params object[]
                args)
                {
                    var return_v = this_param.TraceMethod(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 35399, 35487);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_35713_35760(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 35713, 35760);
                    return return_v;
                }


                int
                f_1644_35534_35761(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 35534, 35761);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_35954_35966()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 35954, 35966);
                    return return_v;
                }


                System.IntPtr
                f_1644_35954_35981(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 35954, 35981);
                    return return_v;
                }


                string
                f_1644_35918_35990(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 35918, 35990);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_36055_36100(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 36055, 36100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 35224, 36184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 35224, 36184);
            }
        }

        internal void SetSignalTimeOut(int milliseconds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 36546, 37490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 36619, 36699);

                f_1644_36619_36698(_wsManSessionHandle != IntPtr.Zero, "Session handle cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 36713, 37479);
                using (f_1644_36720_36801(tracer, "Setting SignalShell timeout: {0} milliseconds", milliseconds))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 36835, 37068);

                    int
                    result = f_1644_36848_37067(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_TIMEOUTMS_SIGNAL_SHELL, f_1644_37019_37066(milliseconds))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 37088, 37464) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 37088, 37464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 37202, 37297);

                        string
                        errorMessage = f_1644_37224_37296(f_1644_37260_37287(f_1644_37260_37272()), result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 37321, 37407);

                        PSInvalidOperationException
                        exception = f_1644_37361_37406(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 37429, 37445);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 37088, 37464);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 36713, 37479);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 36546, 37490);

                int
                f_1644_36619_36698(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 36619, 36698);
                    return 0;
                }


                System.IDisposable
                f_1644_36720_36801(System.Management.Automation.PSTraceSource
                this_param, string
                format, params object[]
                args)
                {
                    var return_v = this_param.TraceMethod(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 36720, 36801);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_37019_37066(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 37019, 37066);
                    return return_v;
                }


                int
                f_1644_36848_37067(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 36848, 37067);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_37260_37272()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 37260, 37272);
                    return return_v;
                }


                System.IntPtr
                f_1644_37260_37287(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 37260, 37287);
                    return return_v;
                }


                string
                f_1644_37224_37296(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 37224, 37296);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_37361_37406(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 37361, 37406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 36546, 37490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 36546, 37490);
            }
        }

        internal void SetWSManSessionOption(WSManNativeApi.WSManSessionOption option, int dwordData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 37855, 38493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 37972, 38114);

                int
                result = f_1644_37985_38113(_wsManSessionHandle, option, f_1644_38068_38112(dwordData))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 38130, 38482) || true) && (result != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 38130, 38482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 38232, 38327);

                    string
                    errorMessage = f_1644_38254_38326(f_1644_38290_38317(f_1644_38290_38302()), result)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 38347, 38433);

                    PSInvalidOperationException
                    exception = f_1644_38387_38432(errorMessage)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 38451, 38467);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 38130, 38482);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 37855, 38493);

                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_38068_38112(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 38068, 38112);
                    return return_v;
                }


                int
                f_1644_37985_38113(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 37985, 38113);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_38290_38302()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 38290, 38302);
                    return return_v;
                }


                System.IntPtr
                f_1644_38290_38317(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 38290, 38317);
                    return return_v;
                }


                string
                f_1644_38254_38326(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 38254, 38326);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_38387_38432(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 38387, 38432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 37855, 38493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 37855, 38493);
            }
        }

        internal void SetWSManSessionOption(WSManNativeApi.WSManSessionOption option, string stringData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 38860, 39640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 38981, 39629);
                using (WSManNativeApi.WSManData_ManToUn
                data = f_1644_39028_39076(stringData)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39110, 39218);

                    int
                    result = f_1644_39123_39217(_wsManSessionHandle, option, data)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39238, 39614) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 39238, 39614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39352, 39447);

                        string
                        errorMessage = f_1644_39374_39446(f_1644_39410_39437(f_1644_39410_39422()), result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39471, 39557);

                        PSInvalidOperationException
                        exception = f_1644_39511_39556(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39579, 39595);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 39238, 39614);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 38981, 39629);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 38860, 39640);

                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                f_1644_39028_39076(string
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 39028, 39076);
                    return return_v;
                }


                int
                f_1644_39123_39217(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, (System.IntPtr)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 39123, 39217);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_39410_39422()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 39410, 39422);
                    return return_v;
                }


                System.IntPtr
                f_1644_39410_39437(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 39410, 39437);
                    return return_v;
                }


                string
                f_1644_39374_39446(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 39374, 39446);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_39511_39556(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 39511, 39556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 38860, 39640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 38860, 39640);
            }
        }

        internal WSManAPIDataCommon WSManAPIData { get; private set; }

        internal bool SupportsDisconnect { get; private set; }

        internal override void DisconnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 39863, 41867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 39928, 39977);

                f_1644_39928_39976(!isClosed, "object already disposed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 40209, 40348);

                uint
                uIdleTimeout = (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 40229, 40261) || (((f_1644_40230_40256(f_1644_40230_40244()) > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 40281, 40313)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 40316, 40347))) ? (uint)f_1644_40287_40313(f_1644_40287_40301()) : UseServerDefaultIdleTimeoutUInt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 40393, 40508);

                WSManNativeApi.WSManShellDisconnectInfo
                disconnectInfo = f_1644_40450_40507(uIdleTimeout)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 40593, 40718);

                _disconnectSessionCompleted = f_1644_40623_40717(f_1644_40658_40687(_sessionContextID), s_sessionDisconnectCallback);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 40774, 40784);
                    lock (syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 40826, 41015) || true) && (isClosed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 40826, 41015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 40985, 40992);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 40826, 41015);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 41039, 41053);

                        int
                        flags = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 41075, 41277);

                        flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 41084, 41159) || (((f_1644_41085_41119(f_1644_41085_41099()) == Runspaces.OutputBufferingMode.Block) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 41199, 41272)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 41275, 41276))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_BLOCK : 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 41299, 41499);

                        flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 41308, 41382) || (((f_1644_41309_41343(f_1644_41309_41323()) == Runspaces.OutputBufferingMode.Drop) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 41422, 41494)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 41497, 41498))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_DROP : 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 41523, 41728);

                        f_1644_41523_41727(_wsManShellOperationHandle, flags, disconnectInfo, _disconnectSessionCompleted);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1644, 41776, 41856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 41816, 41841);

                    disconnectInfo.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1644, 41776, 41856);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 39863, 41867);

                int
                f_1644_39928_39976(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 39928, 39976);
                    return 0;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_40230_40244()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 40230, 40244);
                    return return_v;
                }


                int
                f_1644_40230_40256(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IdleTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 40230, 40256);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_40287_40301()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 40287, 40301);
                    return return_v;
                }


                int
                f_1644_40287_40313(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IdleTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 40287, 40313);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellDisconnectInfo
                f_1644_40450_40507(uint
                serverIdleTimeOut)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellDisconnectInfo(serverIdleTimeOut);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 40450, 40507);
                    return return_v;
                }


                System.IntPtr
                f_1644_40658_40687(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 40658, 40687);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_40623_40717(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 40623, 40717);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_41085_41099()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 41085, 41099);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_41085_41119(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 41085, 41119);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_41309_41323()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 41309, 41323);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_41309_41343(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 41309, 41343);
                    return return_v;
                }


                int
                f_1644_41523_41727(System.IntPtr
                wsManSessionHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellDisconnectInfo
                disconnectInfo, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback)
                {
                    WSManNativeApi.WSManDisconnectShellEx(wsManSessionHandle, flags, (System.IntPtr)disconnectInfo, (System.IntPtr)asyncCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 41523, 41727);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 39863, 41867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 39863, 41867);
            }
        }

        internal override void ReconnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 41879, 43155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 41943, 41992);

                f_1644_41943_41991(!isClosed, "object already disposed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42006, 42055);

                f_1644_42006_42054(f_1644_42006_42028());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42139, 42262);

                _reconnectSessionCompleted = f_1644_42168_42261(f_1644_42203_42232(_sessionContextID), s_sessionReconnectCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42282, 42292);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42326, 42495) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 42326, 42495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42469, 42476);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 42326, 42495);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42515, 42529);

                    int
                    flags = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42547, 42745);

                    flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 42556, 42631) || (((f_1644_42557_42591(f_1644_42557_42571()) == Runspaces.OutputBufferingMode.Block) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 42667, 42740)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 42743, 42744))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_BLOCK : 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42763, 42959);

                    flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 42772, 42846) || (((f_1644_42773_42807(f_1644_42773_42787()) == Runspaces.OutputBufferingMode.Drop) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 42882, 42954)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 42957, 42958))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_DROP : 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 42979, 43129);

                    f_1644_42979_43128(_wsManShellOperationHandle, flags, _reconnectSessionCompleted);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 41879, 43155);

                int
                f_1644_41943_41991(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 41943, 41991);
                    return 0;
                }


                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1644_42006_42028()
                {
                    var return_v = ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 42006, 42028);
                    return return_v;
                }


                int
                f_1644_42006_42054(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param)
                {
                    this_param.PrepareForStreamConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 42006, 42054);
                    return 0;
                }


                System.IntPtr
                f_1644_42203_42232(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 42203, 42232);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_42168_42261(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 42168, 42261);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_42557_42571()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 42557, 42571);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_42557_42591(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 42557, 42591);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_42773_42787()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 42773, 42787);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_42773_42807(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 42773, 42807);
                    return return_v;
                }


                int
                f_1644_42979_43128(System.IntPtr
                wsManSessionHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback)
                {
                    WSManNativeApi.WSManReconnectShellEx(wsManSessionHandle, flags, (System.IntPtr)asyncCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 42979, 43128);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 41879, 43155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 41879, 43155);
            }
        }

        internal override void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 43636, 48204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 43698, 43747);

                f_1644_43698_43746(!isClosed, "object already disposed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 43761, 43858);

                f_1644_43761_43857(!f_1644_43773_43818(f_1644_43794_43817(f_1644_43794_43808())), "shell uri cannot be null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 43874, 43923);

                f_1644_43874_43922(f_1644_43874_43896());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 44084, 45711) || true) && (_openContent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 44084, 45711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 44142, 44178);

                    DataPriorityType
                    additionalDataType
                    = default(DataPriorityType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 44196, 44286);

                    byte[]
                    additionalData = f_1644_44220_44285(dataToBeSent, null, out additionalDataType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 44306, 44945) || true) && (additionalData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 44306, 44945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 44537, 44828);

                        string
                        base64EncodedDataInXml = f_1644_44569_44827(f_1644_44583_44611(), "<{0} xmlns=\"{1}\">{2}</{0}>", WSManNativeApi.PS_CONNECT_XML_TAG, WSManNativeApi.PS_XML_NAMESPACE, f_1644_44788_44826(additionalData))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 44850, 44926);

                        _openContent = f_1644_44865_44925(base64EncodedDataInXml);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 44306, 44945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 45213, 45296);

                    additionalData = f_1644_45230_45295(dataToBeSent, null, out additionalDataType);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 45314, 45696) || true) && (additionalData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 45314, 45696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 45578, 45648);

                        f_1644_45578_45647(false, "Negotiation payload does not fit in ConnectShell");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 45670, 45677);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 45314, 45696);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 44084, 45711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 45838, 45885);

                _sessionContextID = f_1644_45858_45884();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 45899, 45951);

                f_1644_45899_45950(_sessionContextID, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46035, 46061);

                SupportsDisconnect = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46109, 46227);

                _connectSessionCallback = f_1644_46135_46226(f_1644_46170_46199(_sessionContextID), s_sessionConnectCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46247, 46257);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46291, 46483) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 46291, 46483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46457, 46464);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 46291, 46483);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46503, 46612);

                    f_1644_46503_46611(_startMode == WSManTransportManagerUtils.tmStartModes.None, "startMode is not in expected state");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46630, 46691);

                    _startMode = WSManTransportManagerUtils.tmStartModes.Connect;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46711, 46725);

                    int
                    flags = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46743, 46941);

                    flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 46752, 46827) || (((f_1644_46753_46787(f_1644_46753_46767()) == Runspaces.OutputBufferingMode.Block) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 46863, 46936)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 46939, 46940))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_BLOCK : 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 46959, 47155);

                    flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 46968, 47042) || (((f_1644_46969_47003(f_1644_46969_46983()) == Runspaces.OutputBufferingMode.Drop) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 47078, 47150)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 47153, 47154))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_DROP : 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 47175, 47622);

                    f_1644_47175_47621(_wsManSessionHandle, flags, f_1644_47280_47303(f_1644_47280_47294()), f_1644_47326_47378(f_1644_47326_47348().ToString()), IntPtr.Zero, _openContent, _connectSessionCallback, ref _wsManShellOperationHandle);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 47653, 48193) || true) && (_wsManShellOperationHandle == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 47653, 48193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 47732, 48097);

                    TransportErrorOccuredEventArgs
                    eventargs = f_1644_47775_48096(f_1644_47835_47862(f_1644_47835_47847()), this, f_1644_47912_47943(), TransportMethodEnum.ConnectShellEx, f_1644_48023_48061(), f_1644_48063_48095(f_1644_48063_48082(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48115, 48153);

                    f_1644_48115_48152(this, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48171, 48178);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 47653, 48193);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 43636, 48204);

                int
                f_1644_43698_43746(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 43698, 43746);
                    return 0;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_43794_43808()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 43794, 43808);
                    return return_v;
                }


                string
                f_1644_43794_43817(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ShellUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 43794, 43817);
                    return return_v;
                }


                bool
                f_1644_43773_43818(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 43773, 43818);
                    return return_v;
                }


                int
                f_1644_43761_43857(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 43761, 43857);
                    return 0;
                }


                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1644_43874_43896()
                {
                    var return_v = ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 43874, 43896);
                    return return_v;
                }


                int
                f_1644_43874_43922(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param)
                {
                    this_param.PrepareForStreamConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 43874, 43922);
                    return 0;
                }


                byte[]
                f_1644_44220_44285(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 44220, 44285);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_44583_44611()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 44583, 44611);
                    return return_v;
                }


                string
                f_1644_44788_44826(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 44788, 44826);
                    return return_v;
                }


                string
                f_1644_44569_44827(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 44569, 44827);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                f_1644_44865_44925(string
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 44865, 44925);
                    return return_v;
                }


                byte[]
                f_1644_45230_45295(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 45230, 45295);
                    return return_v;
                }


                int
                f_1644_45578_45647(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 45578, 45647);
                    return 0;
                }


                long
                f_1644_45858_45884()
                {
                    var return_v = GetNextSessionTMHandleId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 45858, 45884);
                    return return_v;
                }


                int
                f_1644_45899_45950(long
                sessnTMId, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager)
                {
                    AddSessionTransportManager(sessnTMId, sessnTransportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 45899, 45950);
                    return 0;
                }


                System.IntPtr
                f_1644_46170_46199(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 46170, 46199);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_46135_46226(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 46135, 46226);
                    return return_v;
                }


                int
                f_1644_46503_46611(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 46503, 46611);
                    return 0;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_46753_46767()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 46753, 46767);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_46753_46787(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 46753, 46787);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_46969_46983()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 46969, 46983);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_46969_47003(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 46969, 47003);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_47280_47294()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 47280, 47294);
                    return return_v;
                }


                string
                f_1644_47280_47303(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ShellUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 47280, 47303);
                    return return_v;
                }


                System.Guid
                f_1644_47326_47348()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 47326, 47348);
                    return return_v;
                }


                string
                f_1644_47326_47378(string
                this_param)
                {
                    var return_v = this_param.ToUpperInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 47326, 47378);
                    return return_v;
                }


                int
                f_1644_47175_47621(System.IntPtr
                wsManSessionHandle, int
                flags, string
                resourceUri, string
                shellId, System.IntPtr
                optionSet, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                connectXml, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                shellOperationHandle)
                {
                    WSManNativeApi.WSManConnectShellEx(wsManSessionHandle, flags, resourceUri, shellId, optionSet, (System.IntPtr)connectXml, (System.IntPtr)asyncCallback, ref shellOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 47175, 47621);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_47835_47847()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 47835, 47847);
                    return return_v;
                }


                System.IntPtr
                f_1644_47835_47862(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 47835, 47862);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                f_1644_47912_47943()
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 47912, 47943);
                    return return_v;
                }


                string
                f_1644_48023_48061()
                {
                    var return_v = RemotingErrorIdStrings.ConnectExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 48023, 48061);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_48063_48082(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 48063, 48082);
                    return return_v;
                }


                string
                f_1644_48063_48095(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 48063, 48095);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_47775_48096(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 47775, 48096);
                    return return_v;
                }


                int
                f_1644_48115_48152(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 48115, 48152);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 43636, 48204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 43636, 48204);
            }
        }

        internal override void StartReceivingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 48216, 49608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48290, 48300);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48393, 48576) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 48393, 48576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48447, 48528);

                        f_1644_48447_48527(tracer, "Client Session TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48550, 48557);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 48393, 48576);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48596, 48786) || true) && (receiveDataInitiated)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 48596, 48786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48662, 48738);

                        f_1644_48662_48737(tracer, "Client Session TM: ReceiveData has already been called.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48760, 48767);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 48596, 48786);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48806, 48834);

                    receiveDataInitiated = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48852, 48947);

                    f_1644_48852_48946(tracer, "Client Session TM: Placing Receive request using WSManReceiveShellOutputEx");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 48965, 49218);

                    f_1644_48965_49217(PSEventId.WSManReceiveShellOutputEx, PSOpcode.Receive, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_49160_49182().ToString(), Guid.Empty.ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 49238, 49352);

                    _receivedFromRemote = f_1644_49260_49351(f_1644_49295_49324(_sessionContextID), s_sessionReceiveCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 49370, 49582);

                    f_1644_49370_49581(_wsManShellOperationHandle, IntPtr.Zero, 0, f_1644_49476_49504(f_1644_49476_49488()), _receivedFromRemote, ref _wsManReceiveOperationHandle);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 48216, 49608);

                int
                f_1644_48447_48527(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 48447, 48527);
                    return 0;
                }


                int
                f_1644_48662_48737(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 48662, 48737);
                    return 0;
                }


                int
                f_1644_48852_48946(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 48852, 48946);
                    return 0;
                }


                System.Guid
                f_1644_49160_49182()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 49160, 49182);
                    return return_v;
                }


                int
                f_1644_48965_49217(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 48965, 49217);
                    return 0;
                }


                System.IntPtr
                f_1644_49295_49324(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 49295, 49324);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_49260_49351(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 49260, 49351);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_49476_49488()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 49476, 49488);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                f_1644_49476_49504(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.OutputStreamSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 49476, 49504);
                    return return_v;
                }


                int
                f_1644_49370_49581(System.IntPtr
                shellOperationHandle, System.IntPtr
                commandOperationHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                desiredStreamSet, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                receiveOperationHandle)
                {
                    WSManNativeApi.WSManReceiveShellOutputEx(shellOperationHandle, commandOperationHandle, flags, (System.IntPtr)desiredStreamSet, (System.IntPtr)asyncCallback, ref receiveOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 49370, 49581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 48216, 49608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 48216, 49608);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 50153, 57466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50214, 50263);

                f_1644_50214_50262(!isClosed, "object already disposed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50277, 50374);

                f_1644_50277_50373(!f_1644_50289_50334(f_1644_50310_50333(f_1644_50310_50324())), "shell uri cannot be null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50388, 50487);

                f_1644_50388_50486(f_1644_50399_50411() != null, "WSManApiData should always be created before session creation.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50503, 50618);

                List<WSManNativeApi.WSManOption>
                shellOptions = f_1644_50551_50617(f_1644_50588_50616(f_1644_50588_50600()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50701, 51251) || true) && (s_protocolVersionRedirect != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 50701, 51251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50772, 50850);

                    string
                    newProtocolVersion = (string)f_1644_50808_50849(s_protocolVersionRedirect)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50868, 50889);

                    f_1644_50868_50888(shellOptions);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 50907, 50983);

                    WSManNativeApi.WSManOption
                    newPrtVOption = f_1644_50950_50982()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 51001, 51077);

                    newPrtVOption.name = RemoteDataNameStrings.PS_STARTUP_PROTOCOL_VERSION_NAME;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 51095, 51136);

                    newPrtVOption.value = newProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 51154, 51186);

                    newPrtVOption.mustComply = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 51204, 51236);

                    f_1644_51204_51235(shellOptions, newPrtVOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 50701, 51251);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 51509, 51648);

                uint
                uIdleTimeout = (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 51529, 51561) || (((f_1644_51530_51556(f_1644_51530_51544()) > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 51581, 51613)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 51616, 51647))) ? (uint)f_1644_51587_51613(f_1644_51587_51601()) : UseServerDefaultIdleTimeoutUInt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 51693, 51956);

                WSManNativeApi.WSManShellStartupInfo_ManToUn
                startupInfo =
                f_1644_51769_51955(f_1644_51818_51845(f_1644_51818_51830()), f_1644_51864_51892(f_1644_51864_51876()), uIdleTimeout, _sessionName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52103, 53519) || true) && (_openContent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 52103, 53519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52161, 52197);

                    DataPriorityType
                    additionalDataType
                    = default(DataPriorityType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52215, 52305);

                    byte[]
                    additionalData = f_1644_52239_52304(dataToBeSent, null, out additionalDataType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52398, 52423);

                    bool
                    sendContinue = true
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52443, 52747) || true) && (s_sessionSendRedirect != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 52443, 52747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52518, 52578);

                        object[]
                        arguments = new object[2] { null, additionalData }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52600, 52668);

                        sendContinue = (bool)f_1644_52621_52667(s_sessionSendRedirect, arguments);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52690, 52728);

                        additionalData = (byte[])arguments[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 52443, 52747);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52767, 52814) || true) && (!sendContinue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 52767, 52814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52807, 52814);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 52767, 52814);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 52864, 53504) || true) && (additionalData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 52864, 53504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 53095, 53387);

                        string
                        base64EncodedDataInXml = f_1644_53127_53386(f_1644_53141_53169(), "<{0} xmlns=\"{1}\">{2}</{0}>", WSManNativeApi.PS_CREATION_XML_TAG, WSManNativeApi.PS_XML_NAMESPACE, f_1644_53347_53385(additionalData))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 53409, 53485);

                        _openContent = f_1644_53424_53484(base64EncodedDataInXml);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 52864, 53504);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 52103, 53519);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 53705, 54274) || true) && (_sessionContextID == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 53705, 54274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 53880, 53927);

                    _sessionContextID = f_1644_53900_53926();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 53945, 53997);

                    f_1644_53945_53996(_sessionContextID, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 54053, 54169);

                    _createSessionCallback = f_1644_54078_54168(f_1644_54113_54142(_sessionContextID), s_sessionCreateCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 54187, 54259);

                    _createSessionCallbackGCHandle = GCHandle.Alloc(_createSessionCallback);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 53705, 54274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 54290, 54513);

                f_1644_54290_54512(PSEventId.WSManCreateShell, PSOpcode.Connect, PSTask.CreateRunspace, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_54478_54500().ToString());

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 54571, 54581);
                    lock (syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 54623, 54847) || true) && (isClosed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 54623, 54847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 54817, 54824);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 54623, 54847);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 54871, 54980);

                        f_1644_54871_54979(_startMode == WSManTransportManagerUtils.tmStartModes.None, "startMode is not in expected state");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55002, 55062);

                        _startMode = WSManTransportManagerUtils.tmStartModes.Create;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55086, 55476) || true) && (_noMachineProfile)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 55086, 55476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55157, 55229);

                            WSManNativeApi.WSManOption
                            noProfile = f_1644_55196_55228()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55255, 55297);

                            noProfile.name = WSManNativeApi.NoProfile;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55323, 55351);

                            noProfile.mustComply = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55377, 55399);

                            noProfile.value = "1";
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55425, 55453);

                            f_1644_55425_55452(shellOptions, noProfile);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 55086, 55476);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55500, 55594);

                        int
                        flags = (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 55512, 55526) || ((_noCompression && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 55529, 55589)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 55592, 55593))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_NO_COMPRESSION : 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55616, 55818);

                        flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 55625, 55700) || (((f_1644_55626_55660(f_1644_55626_55640()) == Runspaces.OutputBufferingMode.Block) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 55740, 55813)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 55816, 55817))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_BLOCK : 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 55840, 56040);

                        flags |= (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 55849, 55923) || (((f_1644_55850_55884(f_1644_55850_55864()) == Runspaces.OutputBufferingMode.Drop) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 55963, 56035)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 56038, 56039))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_SERVER_BUFFERING_MODE_DROP : 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 56064, 56710);
                        using (WSManNativeApi.WSManOptionSet
                        optionSet = f_1644_56113_56170(f_1644_56147_56169(shellOptions))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 56220, 56687);

                            f_1644_56220_56686(_wsManSessionHandle, flags, f_1644_56340_56363(f_1644_56340_56354()), f_1644_56394_56446(f_1644_56394_56416().ToString()), startupInfo, optionSet, _openContent, _createSessionCallback, ref _wsManShellOperationHandle);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 56064, 56710);
                        }
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 56749, 57349) || true) && (_wsManShellOperationHandle == IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 56749, 57349);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 56836, 57241);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_56879_57240(f_1644_56939_56966(f_1644_56939_56951()), this, f_1644_57024_57055(), TransportMethodEnum.CreateShellEx, f_1644_57142_57180(), f_1644_57207_57239(f_1644_57207_57226(this)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 57263, 57301);

                        f_1644_57263_57300(this, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 57323, 57330);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 56749, 57349);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1644, 57378, 57455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 57418, 57440);

                    startupInfo.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1644, 57378, 57455);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 50153, 57466);

                int
                f_1644_50214_50262(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50214, 50262);
                    return 0;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_50310_50324()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 50310, 50324);
                    return return_v;
                }


                string
                f_1644_50310_50333(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ShellUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 50310, 50333);
                    return return_v;
                }


                bool
                f_1644_50289_50334(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50289, 50334);
                    return return_v;
                }


                int
                f_1644_50277_50373(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50277, 50373);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_50399_50411()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 50399, 50411);
                    return return_v;
                }


                int
                f_1644_50388_50486(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50388, 50486);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_50588_50600()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 50588, 50600);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
                f_1644_50588_50616(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.CommonOptionSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 50588, 50616);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
                f_1644_50551_50617(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>((System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50551, 50617);
                    return return_v;
                }


                object?
                f_1644_50808_50849(System.Delegate
                this_param, params object?[]
                args)
                {
                    var return_v = this_param.DynamicInvoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50808, 50849);
                    return return_v;
                }


                int
                f_1644_50868_50888(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50868, 50888);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
                f_1644_50950_50982()
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 50950, 50982);
                    return return_v;
                }


                int
                f_1644_51204_51235(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 51204, 51235);
                    return 0;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_51530_51544()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51530, 51544);
                    return return_v;
                }


                int
                f_1644_51530_51556(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IdleTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51530, 51556);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_51587_51601()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51587, 51601);
                    return return_v;
                }


                int
                f_1644_51587_51613(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IdleTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51587, 51613);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_51818_51830()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51818, 51830);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                f_1644_51818_51845(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.InputStreamSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51818, 51845);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_51864_51876()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51864, 51876);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                f_1644_51864_51892(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.OutputStreamSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 51864, 51892);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_ManToUn
                f_1644_51769_51955(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                inputStreamSet, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                outputStreamSet, uint
                serverIdleTimeOut, string
                name)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_ManToUn(inputStreamSet, outputStreamSet, serverIdleTimeOut, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 51769, 51955);
                    return return_v;
                }


                byte[]
                f_1644_52239_52304(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 52239, 52304);
                    return return_v;
                }


                object?
                f_1644_52621_52667(System.Delegate
                this_param, params object[]
                args)
                {
                    var return_v = this_param.DynamicInvoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 52621, 52667);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_53141_53169()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 53141, 53169);
                    return return_v;
                }


                string
                f_1644_53347_53385(byte[]
                inArray)
                {
                    var return_v = Convert.ToBase64String(inArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 53347, 53385);
                    return return_v;
                }


                string
                f_1644_53127_53386(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 53127, 53386);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                f_1644_53424_53484(string
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 53424, 53484);
                    return return_v;
                }


                long
                f_1644_53900_53926()
                {
                    var return_v = GetNextSessionTMHandleId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 53900, 53926);
                    return return_v;
                }


                int
                f_1644_53945_53996(long
                sessnTMId, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager)
                {
                    AddSessionTransportManager(sessnTMId, sessnTransportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 53945, 53996);
                    return 0;
                }


                System.IntPtr
                f_1644_54113_54142(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 54113, 54142);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_54078_54168(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 54078, 54168);
                    return return_v;
                }


                System.Guid
                f_1644_54478_54500()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 54478, 54500);
                    return return_v;
                }


                int
                f_1644_54290_54512(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 54290, 54512);
                    return 0;
                }


                int
                f_1644_54871_54979(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 54871, 54979);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
                f_1644_55196_55228()
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 55196, 55228);
                    return return_v;
                }


                int
                f_1644_55425_55452(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 55425, 55452);
                    return 0;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_55626_55640()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 55626, 55640);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_55626_55660(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 55626, 55660);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_55850_55864()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 55850, 55864);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1644_55850_55884(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 55850, 55884);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption[]
                f_1644_56147_56169(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 56147, 56169);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet
                f_1644_56113_56170(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption[]
                options)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 56113, 56170);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_56340_56354()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 56340, 56354);
                    return return_v;
                }


                string
                f_1644_56340_56363(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ShellUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 56340, 56363);
                    return return_v;
                }


                System.Guid
                f_1644_56394_56416()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 56394, 56416);
                    return return_v;
                }


                string
                f_1644_56394_56446(string
                this_param)
                {
                    var return_v = this_param.ToUpperInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 56394, 56446);
                    return return_v;
                }


                int
                f_1644_56220_56686(System.IntPtr
                wsManSessionHandle, int
                flags, string
                resourceUri, string
                shellId, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_ManToUn
                startupInfo, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOptionSet
                optionSet, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                openContent, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                shellOperationHandle)
                {
                    WSManNativeApi.WSManCreateShellEx(wsManSessionHandle, flags, resourceUri, shellId, startupInfo, optionSet, openContent, (System.IntPtr)asyncCallback, ref shellOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 56220, 56686);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_56939_56951()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 56939, 56951);
                    return return_v;
                }


                System.IntPtr
                f_1644_56939_56966(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 56939, 56966);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                f_1644_57024_57055()
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 57024, 57055);
                    return return_v;
                }


                string
                f_1644_57142_57180()
                {
                    var return_v = RemotingErrorIdStrings.ConnectExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 57142, 57180);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_57207_57226(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 57207, 57226);
                    return return_v;
                }


                string
                f_1644_57207_57239(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 57207, 57239);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_56879_57240(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 56879, 57240);
                    return return_v;
                }


                int
                f_1644_57263_57300(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 57263, 57300);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 50153, 57466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 50153, 57466);
            }
        }

        internal override void CloseAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 57741, 59856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 57801, 57840);

                bool
                shouldRaiseCloseCompleted = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 57945, 57955);
                // let other threads release the lock before we clean up the resources.
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 57989, 58077) || true) && (isClosed == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 57989, 58077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58051, 58058);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 57989, 58077);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58097, 58774) || true) && (_startMode == WSManTransportManagerUtils.tmStartModes.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 58097, 58774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58201, 58234);

                        shouldRaiseCloseCompleted = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 58097, 58774);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 58097, 58774);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58276, 58774) || true) && (_startMode == WSManTransportManagerUtils.tmStartModes.Create || (DynAbs.Tracing.TraceSender.Expression_False(1644, 58280, 58426) || _startMode == WSManTransportManagerUtils.tmStartModes.Connect))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 58276, 58774);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58468, 58619) || true) && (IntPtr.Zero == _wsManShellOperationHandle)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 58468, 58619);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58563, 58596);

                                shouldRaiseCloseCompleted = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 58468, 58619);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 58276, 58774);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 58276, 58774);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58701, 58755);

                            f_1644_58701_58754(false, "startMode is in unexpected state");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 58276, 58774);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 58097, 58774);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58867, 58883);

                    isClosed = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58914, 58932);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAsync(), 1644, 58914, 58931);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 58948, 59272) || true) && (shouldRaiseCloseCompleted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 58948, 59272);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 59055, 59077);

                        f_1644_59055_59076(this);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1644, 59114, 59230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 59162, 59211);

                        f_1644_59162_59210(_sessionContextID);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1644, 59114, 59230);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 59250, 59257);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 58948, 59272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 59401, 59616);

                f_1644_59401_59615(PSEventId.WSManCloseShell, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_59581_59603().ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 59630, 59745);

                _closeSessionCompleted = f_1644_59655_59744(f_1644_59690_59719(_sessionContextID), s_sessionCloseCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 59759, 59845);

                f_1644_59759_59844(_wsManShellOperationHandle, 0, _closeSessionCompleted);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 57741, 59856);

                int
                f_1644_58701_58754(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 58701, 58754);
                    return 0;
                }


                int
                f_1644_59055_59076(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 59055, 59076);
                    return 0;
                }


                int
                f_1644_59162_59210(long
                sessnTMId)
                {
                    RemoveSessionTransportManager(sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 59162, 59210);
                    return 0;
                }


                System.Guid
                f_1644_59581_59603()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 59581, 59603);
                    return return_v;
                }


                int
                f_1644_59401_59615(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 59401, 59615);
                    return 0;
                }


                System.IntPtr
                f_1644_59690_59719(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 59690, 59719);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_59655_59744(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 59655, 59744);
                    return return_v;
                }


                int
                f_1644_59759_59844(System.IntPtr
                shellHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback)
                {
                    WSManNativeApi.WSManCloseShell(shellHandle, flags, (System.IntPtr)asyncCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 59759, 59844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 57741, 59856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 57741, 59856);
            }
        }

        internal void AdjustForProtocolVariations(Version serverProtocolVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 60514, 62285);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 60611, 62274) || true) && (serverProtocolVersion <= RemotingConstants.ProtocolVersionWin7RTM)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 60611, 62274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 60714, 60729);

                    int
                    maxEnvSize
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 60747, 60939);

                    f_1644_60747_60938(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_MAX_ENVELOPE_SIZE_KB, out maxEnvSize);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 60959, 62259) || true) && (maxEnvSize == WSManNativeApi.WSMAN_DEFAULT_MAX_ENVELOPE_SIZE_KB_V3)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 60959, 62259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 61071, 61342);

                        int
                        result = f_1644_61084_61341(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_MAX_ENVELOPE_SIZE_KB, f_1644_61253_61340(WSManNativeApi.WSMAN_DEFAULT_MAX_ENVELOPE_SIZE_KB_V2))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 61366, 61766) || true) && (result != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 61366, 61766);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 61492, 61587);

                            string
                            errorMessage = f_1644_61514_61586(f_1644_61550_61577(f_1644_61550_61562()), result)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 61615, 61701);

                            PSInvalidOperationException
                            exception = f_1644_61655_61700(errorMessage)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 61727, 61743);

                            throw exception;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 61366, 61766);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 61845, 61860);

                        int
                        packetSize
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 61882, 62096);

                        f_1644_61882_62095(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_SHELL_MAX_DATA_SIZE_PER_MESSAGE_KB, out packetSize);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 62197, 62240);

                        f_1644_62197_62207().FragmentSize = packetSize << 10;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 60959, 62259);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 60611, 62274);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 60514, 62285);

                int
                f_1644_60747_60938(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, out int
                value)
                {
                    WSManNativeApi.WSManGetSessionOptionAsDword(wsManSessionHandle, option, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 60747, 60938);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_61253_61340(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 61253, 61340);
                    return return_v;
                }


                int
                f_1644_61084_61341(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 61084, 61341);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_61550_61562()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 61550, 61562);
                    return return_v;
                }


                System.IntPtr
                f_1644_61550_61577(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 61550, 61577);
                    return return_v;
                }


                string
                f_1644_61514_61586(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 61514, 61586);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_61655_61700(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 61655, 61700);
                    return return_v;
                }


                int
                f_1644_61882_62095(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, out int
                value)
                {
                    WSManNativeApi.WSManGetSessionOptionAsDword(wsManSessionHandle, option, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 61882, 62095);
                    return 0;
                }


                System.Management.Automation.Remoting.Fragmentor
                f_1644_62197_62207()
                {
                    var return_v = Fragmentor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 62197, 62207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 60514, 62285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 60514, 62285);
            }
        }

        internal override void PrepareForRedirection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 62700, 63108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 62771, 62866);

                f_1644_62771_62865(!isClosed, "Transport manager must not be closed while preparing for redirection.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 62882, 62997);

                _closeSessionCompleted = f_1644_62907_62996(f_1644_62942_62971(_sessionContextID), s_sessionCloseCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 63011, 63097);

                f_1644_63011_63096(_wsManShellOperationHandle, 0, _closeSessionCompleted);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 62700, 63108);

                int
                f_1644_62771_62865(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 62771, 62865);
                    return 0;
                }


                System.IntPtr
                f_1644_62942_62971(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 62942, 62971);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_62907_62996(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 62907, 62996);
                    return return_v;
                }


                int
                f_1644_63011_63096(System.IntPtr
                shellHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback)
                {
                    WSManNativeApi.WSManCloseShell(shellHandle, flags, (System.IntPtr)asyncCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 63011, 63096);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 62700, 63108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 62700, 63108);
            }
        }

        internal override void Redirect(Uri newUri, RunspaceConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 63638, 64300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 63745, 63777);

                f_1644_63745_63776(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 63791, 63843);

                f_1644_63791_63842(tracer, "Redirecting to URI: {0}", newUri);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 63857, 64087);

                f_1644_63857_64086(PSEventId.URIRedirection, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_64033_64055().ToString(), f_1644_64068_64085(newUri));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 64101, 64157);

                f_1644_64101_64156(this, newUri, connectionInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 64203, 64261);

                _startMode = WSManTransportManagerUtils.tmStartModes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 64275, 64289);

                f_1644_64275_64288(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 63638, 64300);

                int
                f_1644_63745_63776(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.CloseSessionAndClearResources();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 63745, 63776);
                    return 0;
                }


                int
                f_1644_63791_63842(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Uri
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 63791, 63842);
                    return 0;
                }


                System.Guid
                f_1644_64033_64055()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 64033, 64055);
                    return return_v;
                }


                string
                f_1644_64068_64085(System.Uri
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 64068, 64085);
                    return return_v;
                }


                int
                f_1644_63857_64086(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 63857, 64086);
                    return 0;
                }


                int
                f_1644_64101_64156(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Uri
                connectionUri, System.Management.Automation.Runspaces.RunspaceConnectionInfo
                connectionInfo)
                {
                    this_param.Initialize(connectionUri, (System.Management.Automation.Runspaces.WSManConnectionInfo)connectionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 64101, 64156);
                    return 0;
                }


                int
                f_1644_64275_64288(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.CreateAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 64275, 64288);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 63638, 64300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 63638, 64300);
            }
        }

        internal override BaseClientCommandTransportManager CreateClientCommandTransportManager(RunspaceConnectionInfo connectionInfo,
                            ClientRemotePowerShell cmd, bool noInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 64902, 65582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 65116, 65162);

                f_1644_65116_65161(cmd != null, "Cmd cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 65178, 65258);

                WSManConnectionInfo
                wsmanConnectionInfo = connectionInfo as WSManConnectionInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 65272, 65358);

                f_1644_65272_65357(wsmanConnectionInfo != null, "ConnectionInfo must be WSManConnectionInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 65374, 65543);

                WSManClientCommandTransportManager
                result = f_1644_65418_65542(wsmanConnectionInfo, _wsManShellOperationHandle, cmd, noInput, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 65557, 65571);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 64902, 65582);

                int
                f_1644_65116_65161(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 65116, 65161);
                    return 0;
                }


                int
                f_1644_65272_65357(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 65272, 65357);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                f_1644_65418_65542(System.Management.Automation.Runspaces.WSManConnectionInfo
                connectionInfo, System.IntPtr
                wsManShellOperationHandle, System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                shell, bool
                noInput, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTM)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager(connectionInfo, wsManShellOperationHandle, shell, noInput, sessnTM);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 65418, 65542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 64902, 65582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 64902, 65582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Initialize(Uri connectionUri, WSManConnectionInfo connectionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 66081, 77880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 66184, 66253);

                f_1644_66184_66252(connectionInfo != null, "connectionInfo cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 66269, 66301);

                ConnectionInfo = connectionInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 66624, 66652);

                bool
                isSSLSpecified = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 66666, 66718);

                string
                connectionStr = f_1644_66689_66717(connectionUri)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 66732, 67016) || true) && ((connectionUri == f_1644_66754_66782(connectionInfo)) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 66736, 66840) && (f_1644_66805_66839(connectionInfo))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 66732, 67016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 66874, 67001);

                    connectionStr = f_1644_66890_67000(f_1644_66930_66958(connectionInfo), out isSSLSpecified);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 66732, 67016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 67092, 67140);

                string
                additionalUriSuffixString = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 67154, 67321) || true) && (PSSessionConfigurationData.IsServerManager)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 67154, 67321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 67234, 67306);

                    additionalUriSuffixString = ";MSP=7a83d074-bb86-4e52-aa3e-6cc73cc066c8";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 67154, 67321);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 67337, 68472) || true) && (f_1644_67341_67382(f_1644_67362_67381(connectionUri)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 67337, 68472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 67498, 68057);

                    connectionStr = f_1644_67514_68056(f_1644_67528_67556(), "{0}?PSVersion={1}{2}", f_1644_67935_67961(                    // Trimming the last '/' as this will allow WSMan to
                                                                                                                                            // properly apply URLPrefix.
                                                                                                                                            // Ex: http://localhost?PSVersion=2.0 will be converted
                                                                                                                                            // to http://localhost:<port>/<urlprefix>?PSVersion=2.0
                                                                                                                                            // by WSMan
                                        connectionStr, '/'), f_1644_67984_68007(), additionalUriSuffixString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 67337, 68472);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 67337, 68472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 68210, 68457);

                    connectionStr = f_1644_68226_68456(f_1644_68240_68268(), "{0};PSVersion={1}{2}", connectionStr, f_1644_68381_68404(), additionalUriSuffixString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 67337, 68472);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 68488, 68554);

                WSManNativeApi.BaseWSManAuthenticationCredentials
                authCredentials
                = default(WSManNativeApi.BaseWSManAuthenticationCredentials);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 68630, 69691) || true) && (f_1644_68634_68670(connectionInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 68630, 69691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 68712, 68825);

                    authCredentials = f_1644_68730_68824(f_1644_68787_68823(connectionInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 68630, 69691);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 68630, 69691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 68947, 68970);

                    string
                    userName = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 68988, 69033);

                    System.Security.SecureString
                    password = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69051, 69328) || true) && ((f_1644_69056_69081(connectionInfo) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 69055, 69153) && (!f_1644_69096_69152(f_1644_69117_69151(f_1644_69117_69142(connectionInfo))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 69051, 69328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69195, 69241);

                        userName = f_1644_69206_69240(f_1644_69206_69231(connectionInfo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69263, 69309);

                        password = f_1644_69274_69308(f_1644_69274_69299(connectionInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 69051, 69328);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69348, 69618);

                    WSManNativeApi.WSManUserNameAuthenticationCredentials
                    userNameCredentials =
                    f_1644_69445_69617(userName, password, f_1644_69573_69616(connectionInfo))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69638, 69676);

                    authCredentials = userNameCredentials;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 68630, 69691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69742, 69824);

                WSManNativeApi.WSManUserNameAuthenticationCredentials
                proxyAuthCredentials = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69838, 71328) || true) && (f_1644_69842_69872(connectionInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 69838, 71328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 69914, 70044);

                    WSManNativeApi.WSManAuthenticationMechanism
                    authMechanism = WSManNativeApi.WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_NEGOTIATE
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70062, 70085);

                    string
                    userName = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70103, 70148);

                    System.Security.SecureString
                    password = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70168, 70850);

                    switch (f_1644_70176_70210(connectionInfo))
                    {

                        case AuthenticationMechanism.Negotiate:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 70168, 70850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70317, 70403);

                            authMechanism = WSManNativeApi.WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_NEGOTIATE;
                            DynAbs.Tracing.TraceSender.TraceBreak(1644, 70429, 70435);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 70168, 70850);

                        case AuthenticationMechanism.Basic:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 70168, 70850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70518, 70600);

                            authMechanism = WSManNativeApi.WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_BASIC;
                            DynAbs.Tracing.TraceSender.TraceBreak(1644, 70626, 70632);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 70168, 70850);

                        case AuthenticationMechanism.Digest:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 70168, 70850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70716, 70799);

                            authMechanism = WSManNativeApi.WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_DIGEST;
                            DynAbs.Tracing.TraceSender.TraceBreak(1644, 70825, 70831);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 70168, 70850);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70870, 71121) || true) && (!f_1644_70875_70936(f_1644_70896_70935(f_1644_70896_70926(connectionInfo))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 70870, 71121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 70978, 71029);

                        userName = f_1644_70989_71028(f_1644_70989_71019(connectionInfo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 71051, 71102);

                        password = f_1644_71062_71101(f_1644_71062_71092(connectionInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 70870, 71121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 71197, 71313);

                    proxyAuthCredentials = f_1644_71220_71312(userName, password, authMechanism);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 69838, 71328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 71344, 71574);

                WSManNativeApi.WSManProxyInfo
                proxyInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 71386, 71442) || (((ProxyAccessType.None == f_1644_71411_71441(connectionInfo)) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 71462, 71466)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 71486, 71573))) ? null : f_1644_71486_71573(f_1644_71520_71550(connectionInfo), proxyAuthCredentials)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 71590, 71605);

                int
                result = 0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 71657, 71932);

                    result = f_1644_71666_71931(f_1644_71700_71727(f_1644_71700_71712()), connectionStr, 0, f_1644_71769_71806(authCredentials), (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 71830, 71849) || (((proxyInfo == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 71852, 71863)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 71866, 71883))) ? IntPtr.Zero : (IntPtr)proxyInfo, ref _wsManSessionHandle);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1644, 71961, 72434);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72039, 72163) || true) && (proxyAuthCredentials != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 72039, 72163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72113, 72144);

                        f_1644_72113_72143(proxyAuthCredentials);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 72039, 72163);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72183, 72285) || true) && (proxyInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 72183, 72285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72246, 72266);

                        f_1644_72246_72265(proxyInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 72183, 72285);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72305, 72419) || true) && (authCredentials != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 72305, 72419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72374, 72400);

                        f_1644_72374_72399(authCredentials);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 72305, 72419);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1644, 71961, 72434);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72450, 72802) || true) && (result != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 72450, 72802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72552, 72647);

                    string
                    errorMessage = f_1644_72574_72646(f_1644_72610_72637(f_1644_72610_72622()), result)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72667, 72753);

                    PSInvalidOperationException
                    exception = f_1644_72707_72752(errorMessage)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72771, 72787);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 72450, 72802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72871, 72886);

                int
                packetSize
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 72900, 73098);

                f_1644_72900_73097(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_SHELL_MAX_DATA_SIZE_PER_MESSAGE_KB, out packetSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 73185, 73228);

                f_1644_73185_73195().FragmentSize = packetSize << 10;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 73305, 73486);

                f_1644_73305_73485(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_MAX_RETRY_TIME, out _maxRetryTime);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 73502, 73549);

                this.dataToBeSent.Fragmentor = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Fragmentor, 1644, 73533, 73548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 73563, 73611);

                _noCompression = f_1644_73580_73610_M(!connectionInfo.UseCompression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 73625, 73677);

                _noMachineProfile = f_1644_73645_73676(connectionInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 73750, 74082) || true) && (isSSLSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 73750, 74082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 73986, 74067);

                    f_1644_73986_74066(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_USE_SSL, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 73750, 74082);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 74963, 75183) || true) && (f_1644_74967_74994(connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 74963, 75183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75074, 75168);

                    f_1644_75074_75167(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_UNENCRYPTED_MESSAGES, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 74963, 75183);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75269, 75604) || true) && (f_1644_75273_75323(connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 75269, 75604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75357, 75589);

                    result = f_1644_75366_75588(_wsManSessionHandle, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_ALLOW_NEGOTIATE_IMPLICIT_CREDENTIALS, f_1644_75551_75587(1));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 75269, 75604);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75620, 75775) || true) && (f_1644_75624_75647(connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 75620, 75775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75681, 75760);

                    f_1644_75681_75759(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_UTF16, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 75620, 75775);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75791, 75957) || true) && (f_1644_75795_75821(connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 75791, 75957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75855, 75942);

                    f_1644_75855_75941(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_SKIP_CA_CHECK, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 75791, 75957);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 75973, 76139) || true) && (f_1644_75977_76003(connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 75973, 76139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76037, 76124);

                    f_1644_76037_76123(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_SKIP_CN_CHECK, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 75973, 76139);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76155, 76337) || true) && (f_1644_76159_76193(connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 76155, 76337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76227, 76322);

                    f_1644_76227_76321(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_SKIP_REVOCATION_CHECK, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 76155, 76337);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76353, 76533) || true) && (f_1644_76357_76388(connectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 76353, 76533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76422, 76518);

                    f_1644_76422_76517(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_ENABLE_SPN_SERVER_PORT, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 76353, 76533);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76635, 76790);

                f_1644_76635_76789(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_USE_INTERACTIVE_TOKEN, (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 76744, 76780) || (((f_1644_76745_76779(connectionInfo)) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 76783, 76784)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 76787, 76788))) ? 1 : 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76887, 76943);

                string
                currentUICulture = f_1644_76913_76942(f_1644_76913_76937(connectionInfo))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 76957, 77213) || true) && (!f_1644_76962_77000(currentUICulture))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 76957, 77213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77098, 77198);

                    f_1644_77098_77197(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_UI_LANGUAGE, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 76957, 77213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77304, 77356);

                string
                currentCulture = f_1644_77328_77355(f_1644_77328_77350(connectionInfo))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77370, 77553) || true) && (!f_1644_77375_77411(currentCulture))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 77370, 77553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77445, 77538);

                    f_1644_77445_77537(this, WSManNativeApi.WSManSessionOption.WSMAN_OPTION_LOCALE, currentCulture);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 77370, 77553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77637, 77688);

                f_1644_77637_77687(this, f_1644_77655_77686(connectionInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77702, 77748);

                f_1644_77702_77747(this, f_1644_77720_77746(connectionInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77762, 77808);

                f_1644_77762_77807(this, f_1644_77778_77806(connectionInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 77822, 77869);

                f_1644_77822_77868(this, f_1644_77839_77867(connectionInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 66081, 77880);

                int
                f_1644_66184_66252(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 66184, 66252);
                    return 0;
                }


                string
                f_1644_66689_66717(System.Uri
                this_param)
                {
                    var return_v = this_param.OriginalString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 66689, 66717);
                    return return_v;
                }


                System.Uri
                f_1644_66754_66782(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ConnectionUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 66754, 66782);
                    return return_v;
                }


                bool
                f_1644_66805_66839(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.UseDefaultWSManPort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 66805, 66839);
                    return return_v;
                }


                System.Uri
                f_1644_66930_66958(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ConnectionUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 66930, 66958);
                    return return_v;
                }


                string
                f_1644_66890_67000(System.Uri
                connectionUri, out bool
                isSSLSpecified)
                {
                    var return_v = WSManConnectionInfo.GetConnectionString(connectionUri, out isSSLSpecified);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 66890, 67000);
                    return return_v;
                }


                string
                f_1644_67362_67381(System.Uri
                this_param)
                {
                    var return_v = this_param.Query;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 67362, 67381);
                    return return_v;
                }


                bool
                f_1644_67341_67382(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 67341, 67382);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_67528_67556()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 67528, 67556);
                    return return_v;
                }


                string
                f_1644_67935_67961(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 67935, 67961);
                    return return_v;
                }


                System.Version
                f_1644_67984_68007()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 67984, 68007);
                    return return_v;
                }


                string
                f_1644_67514_68056(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Version
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 67514, 68056);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_68240_68268()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 68240, 68268);
                    return return_v;
                }


                System.Version
                f_1644_68381_68404()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 68381, 68404);
                    return return_v;
                }


                string
                f_1644_68226_68456(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Version
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 68226, 68456);
                    return return_v;
                }


                string
                f_1644_68634_68670(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.CertificateThumbprint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 68634, 68670);
                    return return_v;
                }


                string
                f_1644_68787_68823(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.CertificateThumbprint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 68787, 68823);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateThumbprintCredentials
                f_1644_68730_68824(string
                thumbPrint)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCertificateThumbprintCredentials(thumbPrint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 68730, 68824);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_69056_69081(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Credential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69056, 69081);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_69117_69142(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Credential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69117, 69142);
                    return return_v;
                }


                string
                f_1644_69117_69151(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69117, 69151);
                    return return_v;
                }


                bool
                f_1644_69096_69152(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 69096, 69152);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_69206_69231(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Credential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69206, 69231);
                    return return_v;
                }


                string
                f_1644_69206_69240(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69206, 69240);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_69274_69299(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Credential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69274, 69299);
                    return return_v;
                }


                System.Security.SecureString
                f_1644_69274_69308(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.Password;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69274, 69308);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManAuthenticationMechanism
                f_1644_69573_69616(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.WSManAuthenticationMechanism;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69573, 69616);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials
                f_1644_69445_69617(string
                name, System.Security.SecureString
                pwd, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManAuthenticationMechanism
                authMechanism)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials(name, pwd, authMechanism);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 69445, 69617);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_69842_69872(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 69842, 69872);
                    return return_v;
                }


                System.Management.Automation.Runspaces.AuthenticationMechanism
                f_1644_70176_70210(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyAuthentication;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 70176, 70210);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_70896_70926(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 70896, 70926);
                    return return_v;
                }


                string
                f_1644_70896_70935(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 70896, 70935);
                    return return_v;
                }


                bool
                f_1644_70875_70936(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 70875, 70936);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_70989_71019(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 70989, 71019);
                    return return_v;
                }


                string
                f_1644_70989_71028(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 70989, 71028);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1644_71062_71092(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 71062, 71092);
                    return return_v;
                }


                System.Security.SecureString
                f_1644_71062_71101(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.Password;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 71062, 71101);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials
                f_1644_71220_71312(string
                name, System.Security.SecureString
                pwd, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManAuthenticationMechanism
                authMechanism)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials(name, pwd, authMechanism);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 71220, 71312);
                    return return_v;
                }


                System.Management.Automation.Remoting.ProxyAccessType
                f_1644_71411_71441(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyAccessType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 71411, 71441);
                    return return_v;
                }


                System.Management.Automation.Remoting.ProxyAccessType
                f_1644_71520_71550(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyAccessType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 71520, 71550);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManProxyInfo
                f_1644_71486_71573(System.Management.Automation.Remoting.ProxyAccessType
                proxyAccessType, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials
                authCredentials)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManProxyInfo(proxyAccessType, authCredentials);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 71486, 71573);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_71700_71712()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 71700, 71712);
                    return return_v;
                }


                System.IntPtr
                f_1644_71700_71727(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 71700, 71727);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.MarshalledObject
                f_1644_71769_71806(System.Management.Automation.Remoting.Client.WSManNativeApi.BaseWSManAuthenticationCredentials
                this_param)
                {
                    var return_v = this_param.GetMarshalledObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 71769, 71806);
                    return return_v;
                }


                int
                f_1644_71666_71931(System.IntPtr
                wsManAPIHandle, string
                connection, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.MarshalledObject
                authenticationCredentials, System.IntPtr
                proxyInfo, ref System.IntPtr
                wsManSessionHandle)
                {
                    var return_v = WSManNativeApi.WSManCreateSession(wsManAPIHandle, connection, flags, (System.IntPtr)authenticationCredentials, proxyInfo, ref wsManSessionHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 71666, 71931);
                    return return_v;
                }


                int
                f_1644_72113_72143(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManUserNameAuthenticationCredentials
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 72113, 72143);
                    return 0;
                }


                int
                f_1644_72246_72265(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManProxyInfo
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 72246, 72265);
                    return 0;
                }


                int
                f_1644_72374_72399(System.Management.Automation.Remoting.Client.WSManNativeApi.BaseWSManAuthenticationCredentials
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 72374, 72399);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_72610_72622()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 72610, 72622);
                    return return_v;
                }


                System.IntPtr
                f_1644_72610_72637(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 72610, 72637);
                    return return_v;
                }


                string
                f_1644_72574_72646(System.IntPtr
                wsManAPIHandle, int
                errorCode)
                {
                    var return_v = WSManNativeApi.WSManGetErrorMessage(wsManAPIHandle, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 72574, 72646);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1644_72707_72752(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 72707, 72752);
                    return return_v;
                }


                int
                f_1644_72900_73097(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, out int
                value)
                {
                    WSManNativeApi.WSManGetSessionOptionAsDword(wsManSessionHandle, option, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 72900, 73097);
                    return 0;
                }


                System.Management.Automation.Remoting.Fragmentor
                f_1644_73185_73195()
                {
                    var return_v = Fragmentor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 73185, 73195);
                    return return_v;
                }


                int
                f_1644_73305_73485(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, out int
                value)
                {
                    WSManNativeApi.WSManGetSessionOptionAsDword(wsManSessionHandle, option, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 73305, 73485);
                    return 0;
                }


                bool
                f_1644_73580_73610_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 73580, 73610);
                    return return_v;
                }


                bool
                f_1644_73645_73676(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.NoMachineProfile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 73645, 73676);
                    return return_v;
                }


                int
                f_1644_73986_74066(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 73986, 74066);
                    return 0;
                }


                bool
                f_1644_74967_74994(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.NoEncryption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 74967, 74994);
                    return return_v;
                }


                int
                f_1644_75074_75167(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 75074, 75167);
                    return 0;
                }


                bool
                f_1644_75273_75323(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.AllowImplicitCredentialForNegotiate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 75273, 75323);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                f_1644_75551_75587(int
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 75551, 75587);
                    return return_v;
                }


                int
                f_1644_75366_75588(System.IntPtr
                wsManSessionHandle, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataDWord
                data)
                {
                    var return_v = WSManNativeApi.WSManSetSessionOption(wsManSessionHandle, option, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 75366, 75588);
                    return return_v;
                }


                bool
                f_1644_75624_75647(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.UseUTF16;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 75624, 75647);
                    return return_v;
                }


                int
                f_1644_75681_75759(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 75681, 75759);
                    return 0;
                }


                bool
                f_1644_75795_75821(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.SkipCACheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 75795, 75821);
                    return return_v;
                }


                int
                f_1644_75855_75941(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 75855, 75941);
                    return 0;
                }


                bool
                f_1644_75977_76003(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.SkipCNCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 75977, 76003);
                    return return_v;
                }


                int
                f_1644_76037_76123(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 76037, 76123);
                    return 0;
                }


                bool
                f_1644_76159_76193(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.SkipRevocationCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 76159, 76193);
                    return return_v;
                }


                int
                f_1644_76227_76321(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 76227, 76321);
                    return 0;
                }


                bool
                f_1644_76357_76388(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IncludePortInSPN;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 76357, 76388);
                    return return_v;
                }


                int
                f_1644_76422_76517(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 76422, 76517);
                    return 0;
                }


                bool
                f_1644_76745_76779(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.EnableNetworkAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 76745, 76779);
                    return return_v;
                }


                int
                f_1644_76635_76789(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, int
                dwordData)
                {
                    this_param.SetWSManSessionOption(option, dwordData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 76635, 76789);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1644_76913_76937(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.UICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 76913, 76937);
                    return return_v;
                }


                string
                f_1644_76913_76942(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 76913, 76942);
                    return return_v;
                }


                bool
                f_1644_76962_77000(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 76962, 77000);
                    return return_v;
                }


                int
                f_1644_77098_77197(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, string
                stringData)
                {
                    this_param.SetWSManSessionOption(option, stringData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 77098, 77197);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1644_77328_77350(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 77328, 77350);
                    return return_v;
                }


                string
                f_1644_77328_77355(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 77328, 77355);
                    return return_v;
                }


                bool
                f_1644_77375_77411(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 77375, 77411);
                    return return_v;
                }


                int
                f_1644_77445_77537(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSessionOption
                option, string
                stringData)
                {
                    this_param.SetWSManSessionOption(option, stringData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 77445, 77537);
                    return 0;
                }


                int
                f_1644_77655_77686(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OperationTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 77655, 77686);
                    return return_v;
                }


                int
                f_1644_77637_77687(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                milliseconds)
                {
                    this_param.SetDefaultTimeOut(milliseconds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 77637, 77687);
                    return 0;
                }


                int
                f_1644_77720_77746(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OpenTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 77720, 77746);
                    return return_v;
                }


                int
                f_1644_77702_77747(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                milliseconds)
                {
                    this_param.SetConnectTimeOut(milliseconds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 77702, 77747);
                    return 0;
                }


                int
                f_1644_77778_77806(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.CancelTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 77778, 77806);
                    return return_v;
                }


                int
                f_1644_77762_77807(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                milliseconds)
                {
                    this_param.SetCloseTimeOut(milliseconds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 77762, 77807);
                    return 0;
                }


                int
                f_1644_77839_77867(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.CancelTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 77839, 77867);
                    return return_v;
                }


                int
                f_1644_77822_77868(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                milliseconds)
                {
                    this_param.SetSignalTimeOut(milliseconds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 77822, 77868);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 66081, 77880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 66081, 77880);
            }
        }

        internal void ProcessWSManTransportError(TransportErrorOccuredEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 78176, 78349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 78283, 78338);

                f_1644_78283_78337(this, null, eventArgs, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 78176, 78349);

                int
                f_1644_78283_78337(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, object
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 78283, 78337);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 78176, 78349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 78176, 78349);
            }
        }

        internal override void RaiseErrorHandler(TransportErrorOccuredEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 78536, 80195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 78689, 78707);

                string
                stackTrace
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 78721, 79230) || true) && (!f_1644_78726_78778(f_1644_78747_78777(f_1644_78747_78766(eventArgs))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 78721, 79230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 78812, 78856);

                    stackTrace = f_1644_78825_78855(f_1644_78825_78844(eventArgs));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 78721, 79230);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 78721, 79230);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 78890, 79230) || true) && (f_1644_78894_78928(f_1644_78894_78913(eventArgs)) != null && (DynAbs.Tracing.TraceSender.Expression_True(1644, 78894, 79030) && !f_1644_78963_79030(f_1644_78984_79029(f_1644_78984_79018(f_1644_78984_79003(eventArgs))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 78890, 79230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 79064, 79123);

                        stackTrace = f_1644_79077_79122(f_1644_79077_79111(f_1644_79077_79096(eventArgs)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 78890, 79230);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 78890, 79230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 79189, 79215);

                        stackTrace = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 78890, 79230);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 78721, 79230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 79321, 79690);

                f_1644_79321_79689(PSEventId.TransportError, PSOpcode.Open, PSTask.None, PSKeyword.UseAlwaysOperational, f_1644_79453_79475().ToString(), Guid.Empty.ToString(), f_1644_79545_79613(f_1644_79545_79574(f_1644_79545_79564(eventArgs)), f_1644_79584_79612()), f_1644_79632_79659(f_1644_79632_79651(eventArgs)), stackTrace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 79706, 80134);

                f_1644_79706_80133(PSEventId.TransportError_Analytic, PSOpcode.Open, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_79897_79919().ToString(), Guid.Empty.ToString(), f_1644_79989_80057(f_1644_79989_80018(f_1644_79989_80008(eventArgs)), f_1644_80028_80056()), f_1644_80076_80103(f_1644_80076_80095(eventArgs)), stackTrace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 80150, 80184);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RaiseErrorHandler(eventArgs), 1644, 80150, 80183);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 78536, 80195);

                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_78747_78766(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78747, 78766);
                    return return_v;
                }


                string
                f_1644_78747_78777(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78747, 78777);
                    return return_v;
                }


                bool
                f_1644_78726_78778(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 78726, 78778);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_78825_78844(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78825, 78844);
                    return return_v;
                }


                string
                f_1644_78825_78855(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78825, 78855);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_78894_78913(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78894, 78913);
                    return return_v;
                }


                System.Exception
                f_1644_78894_78928(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78894, 78928);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_78984_79003(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78984, 79003);
                    return return_v;
                }


                System.Exception
                f_1644_78984_79018(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78984, 79018);
                    return return_v;
                }


                string
                f_1644_78984_79029(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 78984, 79029);
                    return return_v;
                }


                bool
                f_1644_78963_79030(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 78963, 79030);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_79077_79096(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79077, 79096);
                    return return_v;
                }


                System.Exception
                f_1644_79077_79111(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79077, 79111);
                    return return_v;
                }


                string
                f_1644_79077_79122(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79077, 79122);
                    return return_v;
                }


                System.Guid
                f_1644_79453_79475()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79453, 79475);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_79545_79564(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79545, 79564);
                    return return_v;
                }


                int
                f_1644_79545_79574(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79545, 79574);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_79584_79612()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79584, 79612);
                    return return_v;
                }


                string
                f_1644_79545_79613(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 79545, 79613);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_79632_79651(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79632, 79651);
                    return return_v;
                }


                string
                f_1644_79632_79659(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79632, 79659);
                    return return_v;
                }


                int
                f_1644_79321_79689(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 79321, 79689);
                    return 0;
                }


                System.Guid
                f_1644_79897_79919()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79897, 79919);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_79989_80008(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79989, 80008);
                    return return_v;
                }


                int
                f_1644_79989_80018(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 79989, 80018);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_80028_80056()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 80028, 80056);
                    return return_v;
                }


                string
                f_1644_79989_80057(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 79989, 80057);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_80076_80095(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 80076, 80095);
                    return return_v;
                }


                string
                f_1644_80076_80103(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 80076, 80103);
                    return return_v;
                }


                int
                f_1644_79706_80133(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 79706, 80133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 78536, 80195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 78536, 80195);
            }
        }

        internal void ClearReceiveOrSendResources(int flags, bool shouldClearSend)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 80683, 82110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 80782, 82099) || true) && (shouldClearSend)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 80782, 82099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 80835, 81015) || true) && (_sendToRemoteCompleted != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 80835, 81015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 80911, 80944);

                        f_1644_80911_80943(_sendToRemoteCompleted);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 80966, 80996);

                        _sendToRemoteCompleted = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 80835, 81015);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81078, 81310) || true) && (IntPtr.Zero != _wsManSendOperationHandle)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 81078, 81310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81164, 81229);

                        f_1644_81164_81228(_wsManSendOperationHandle, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81251, 81291);

                        _wsManSendOperationHandle = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 81078, 81310);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 80782, 82099);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 80782, 82099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81467, 82084) || true) && (flags == (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_END_OF_OPERATION)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 81467, 82084);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81597, 81854) || true) && (IntPtr.Zero != _wsManReceiveOperationHandle)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 81597, 81854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81694, 81762);

                            f_1644_81694_81761(_wsManReceiveOperationHandle, 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81788, 81831);

                            _wsManReceiveOperationHandle = IntPtr.Zero;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 81597, 81854);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81878, 82065) || true) && (_receivedFromRemote != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 81878, 82065);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 81959, 81989);

                            f_1644_81959_81988(_receivedFromRemote);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82015, 82042);

                            _receivedFromRemote = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 81878, 82065);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 81467, 82084);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 80782, 82099);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 80683, 82110);

                int
                f_1644_80911_80943(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 80911, 80943);
                    return 0;
                }


                int
                f_1644_81164_81228(System.IntPtr
                operationHandle, int
                flags)
                {
                    WSManNativeApi.WSManCloseOperation(operationHandle, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 81164, 81228);
                    return 0;
                }


                int
                f_1644_81694_81761(System.IntPtr
                operationHandle, int
                flags)
                {
                    WSManNativeApi.WSManCloseOperation(operationHandle, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 81694, 81761);
                    return 0;
                }


                int
                f_1644_81959_81988(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 81959, 81988);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 80683, 82110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 80683, 82110);
            }
        }

        internal override void ProcessPrivateData(object privateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 82340, 83475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82459, 82535);

                ConnectionStatusEventArgs
                rcArgs = privateData as ConnectionStatusEventArgs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82549, 82683) || true) && (rcArgs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 82549, 82683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82601, 82643);

                    f_1644_82601_82642(this, rcArgs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82661, 82668);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 82549, 82683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82699, 82771);

                CompletionEventArgs
                completionArgs = privateData as CompletionEventArgs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82785, 83314) || true) && (completionArgs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 82785, 83314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82845, 83272);

                    switch (f_1644_82853_82880(completionArgs))
                    {

                        case CompletionNotification.DisconnectCompleted:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 82845, 83272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 82996, 83023);

                            f_1644_82996_83022(this);
                            DynAbs.Tracing.TraceSender.TraceBreak(1644, 83049, 83055);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 82845, 83272);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 82845, 83272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 83113, 83221);

                            f_1644_83113_83220(false, "Currently only DisconnectCompleted notification is handled on the worker thread queue.");
                            DynAbs.Tracing.TraceSender.TraceBreak(1644, 83247, 83253);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 82845, 83272);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 83292, 83299);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 82785, 83314);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 83330, 83464);

                f_1644_83330_83463(false, "Worker thread callback should always have ConnectionStatusEventArgs or CompletionEventArgs type for privateData.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 82340, 83475);

                int
                f_1644_82601_82642(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.ConnectionStatusEventArgs
                args)
                {
                    this_param.RaiseRobustConnectionNotification(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 82601, 82642);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.CompletionNotification
                f_1644_82853_82880(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.CompletionEventArgs
                this_param)
                {
                    var return_v = this_param.Notification;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 82853, 82880);
                    return return_v;
                }


                int
                f_1644_82996_83022(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.RaiseDisconnectCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 82996, 83022);
                    return 0;
                }


                int
                f_1644_83113_83220(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 83113, 83220);
                    return 0;
                }


                int
                f_1644_83330_83463(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 83330, 83463);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 82340, 83475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 82340, 83475);
            }
        }

        internal int MaxRetryConnectionTime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 83661, 83690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 83667, 83688);

                    return _maxRetryTime;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 83661, 83690);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 83601, 83701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 83601, 83701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IntPtr SessionHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 83923, 83958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 83929, 83956);

                    return _wsManSessionHandle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 83923, 83958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 83869, 83969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 83869, 83969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal WSManConnectionInfo ConnectionInfo { get; private set; }

        private bool RetrySessionCreation(int sessionCreateErrorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 84598, 86834);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 84684, 84770) || true) && (_connectionRetryCount >= f_1644_84713_84751(f_1644_84713_84727()))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 84684, 84770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 84755, 84768);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 84684, 84770);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 84786, 84804);

                bool
                retryConnect
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 84818, 85747);

                switch (sessionCreateErrorCode)
                {

                    case WSManNativeApi.ERROR_WSMAN_SENDDATA_CANNOT_CONNECT:
                    case WSManNativeApi.ERROR_WSMAN_OPERATION_ABORTED:
                    case WSManNativeApi.ERROR_WSMAN_IMPROPER_RESPONSE:
                    case WSManNativeApi.ERROR_WSMAN_URL_NOTAVAILABLE:
                    case WSManNativeApi.ERROR_WSMAN_CANNOT_CONNECT_INVALID:
                    case WSManNativeApi.ERROR_WSMAN_CANNOT_CONNECT_MISMATCH:
                    case WSManNativeApi.ERROR_WSMAN_HTTP_SERVICE_UNAVAILABLE:
                    case WSManNativeApi.ERROR_WSMAN_HTTP_SERVICE_ERROR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 84818, 85747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 85520, 85540);

                        retryConnect = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(1644, 85562, 85568);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 84818, 85747);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 84818, 85747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 85683, 85704);

                        retryConnect = false;
                        DynAbs.Tracing.TraceSender.TraceBreak(1644, 85726, 85732);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 84818, 85747);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 85763, 86787) || true) && (retryConnect)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 85763, 86787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 85813, 85837);

                    ++_connectionRetryCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 85896, 86083);

                    f_1644_85896_86082(
                                    // Write trace output
                                    tracer, "Attempting session creation retry {0} for error code {1} on session Id {2}", _connectionRetryCount, sessionCreateErrorCode, f_1644_86059_86081());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 86144, 86537);

                    f_1644_86144_86536(PSEventId.RetrySessionCreation, PSOpcode.Open, PSTask.None, PSKeyword.UseAlwaysOperational, f_1644_86335_86395(_connectionRetryCount, f_1644_86366_86394()), f_1644_86418_86479(sessionCreateErrorCode, f_1644_86450_86478()), f_1644_86502_86524().ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 86708, 86772);

                    f_1644_86708_86771(StartCreateRetry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 85763, 86787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 86803, 86823);

                return retryConnect;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 84598, 86834);

                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_84713_84727()
                {
                    var return_v = ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 84713, 84727);
                    return return_v;
                }


                int
                f_1644_84713_84751(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.MaxConnectionRetryCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 84713, 84751);
                    return return_v;
                }


                System.Guid
                f_1644_86059_86081()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 86059, 86081);
                    return return_v;
                }


                int
                f_1644_85896_86082(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1, int
                arg2, System.Guid
                arg3)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 85896, 86082);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1644_86366_86394()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 86366, 86394);
                    return return_v;
                }


                string
                f_1644_86335_86395(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 86335, 86395);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_86450_86478()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 86450, 86478);
                    return return_v;
                }


                string
                f_1644_86418_86479(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 86418, 86479);
                    return return_v;
                }


                System.Guid
                f_1644_86502_86524()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 86502, 86524);
                    return return_v;
                }


                int
                f_1644_86144_86536(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 86144, 86536);
                    return 0;
                }


                bool
                f_1644_86708_86771(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = System.Threading.ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 86708, 86771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 84598, 86834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 84598, 86834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void StartCreateRetry(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 86846, 87061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 86964, 87022);

                _startMode = WSManTransportManagerUtils.tmStartModes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 87036, 87050);

                f_1644_87036_87049(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 86846, 87061);

                int
                f_1644_87036_87049(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.CreateAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 87036, 87049);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 86846, 87061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 86846, 87061);
            }
        }

        private static void OnCreateSessionCallback(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 87208, 92630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 87501, 87570);

                f_1644_87501_87569(tracer, "Client Session TM: CreateShell callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 87586, 87611);

                long
                sessionTMHandle = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 87625, 87677);

                WSManClientSessionTransportManager
                sessionTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 87691, 88011) || true) && (!f_1644_87696_87779(operationContext, out sessionTM, out sessionTMHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 87691, 88011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 87882, 87971);

                    f_1644_87882_87970(                // We dont have the session TM handle..just return.
                                    tracer, "Unable to find a transport manager for context {0}.", sessionTMHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 87989, 87996);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 87691, 88011);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 88171, 88279) || true) && (f_1644_88175_88223(flags, sessionTM))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 88171, 88279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 88257, 88264);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 88171, 88279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 88295, 88534);

                f_1644_88295_88533(PSEventId.WSManCreateShellCallbackReceived, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, sessionTM.RunspacePoolInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 88991, 89051);

                sessionTM._wsManShellOperationHandle = shellOperationHandle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89073, 89093);

                lock (sessionTM.syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89188, 89278) || true) && (sessionTM.isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 89188, 89278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89252, 89259);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 89188, 89278);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89309, 90755) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 89309, 90755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89367, 89450);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89470, 90740) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 89470, 90740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89542, 89664);

                        f_1644_89542_89663(tracer, "Got error with error code {0}. Message {1}", f_1644_89605_89637(errorStruct.errorCode), errorStruct.errorDetail);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 89767, 90059) || true) && (f_1644_89771_89824(sessionTM, errorStruct.errorCode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 89767, 90059);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 90029, 90036);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 89767, 90059);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 90083, 90620);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_90126_90619(f_1644_90212_90249(f_1644_90212_90234(sessionTM)), sessionTM, errorStruct, TransportMethodEnum.CreateShellEx, f_1644_90410_90455(), new object[] { f_1644_90497_90534(f_1644_90497_90521(sessionTM)), f_1644_90536_90616(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 90642, 90690);

                        f_1644_90642_90689(sessionTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 90714, 90721);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 89470, 90740);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 89309, 90755);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 90828, 90976);

                sessionTM.SupportsDisconnect = (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 90859, 90960) || ((((flags & (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_SHELL_SUPPORTS_DISCONNECT) != 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 90963, 90967)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 90970, 90975))) ? true : false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91191, 91355) || true) && (sessionTM._openContent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 91191, 91355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91259, 91292);

                    f_1644_91259_91291(sessionTM._openContent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91310, 91340);

                    sessionTM._openContent = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 91191, 91355);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91371, 91756) || true) && (data != IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 91371, 91756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91428, 91540);

                    WSManNativeApi.WSManCreateShellDataResult
                    shellData = f_1644_91482_91539(data)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91558, 91741) || true) && (shellData.data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 91558, 91741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91626, 91660);

                        string
                        returnXml = shellData.data
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91684, 91722);

                        f_1644_91684_91721(
                                            sessionTM, returnXml);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 91558, 91741);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 91371, 91756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91778, 91798);

                lock (sessionTM.syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91895, 92088) || true) && (sessionTM.isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 91895, 92088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 91959, 92040);

                        f_1644_91959_92039(tracer, "Client Session TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 92062, 92069);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 91895, 92088);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 92280, 92395);

                    f_1644_92280_92394(
                                    // Successfully made a connection. Now report this by raising the CreateCompleted event.
                                    // Pass updated connection information to event.
                                    sessionTM, f_1644_92333_92393(f_1644_92361_92392(f_1644_92361_92385(sessionTM))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 92492, 92523);

                    f_1644_92492_92522(
                                    // Since create shell is successful, put a receive request.
                                    sessionTM);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 92595, 92619);

                f_1644_92595_92618(            // Start sending data if any.
                            sessionTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 87208, 92630);

                int
                f_1644_87501_87569(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 87501, 87569);
                    return 0;
                }


                bool
                f_1644_87696_87779(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager, out long
                sessnTMId)
                {
                    var return_v = TryGetSessionTransportManager(operationContext, out sessnTransportManager, out sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 87696, 87779);
                    return return_v;
                }


                int
                f_1644_87882_87970(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 87882, 87970);
                    return 0;
                }


                bool
                f_1644_88175_88223(int
                flags, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessionTM)
                {
                    var return_v = HandleRobustConnectionCallback(flags, sessionTM);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 88175, 88223);
                    return return_v;
                }


                int
                f_1644_88295_88533(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 88295, 88533);
                    return 0;
                }


                string
                f_1644_89605_89637(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 89605, 89637);
                    return return_v;
                }


                int
                f_1644_89542_89663(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 89542, 89663);
                    return 0;
                }


                bool
                f_1644_89771_89824(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                sessionCreateErrorCode)
                {
                    var return_v = this_param.RetrySessionCreation(sessionCreateErrorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 89771, 89824);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_90212_90234(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 90212, 90234);
                    return return_v;
                }


                System.IntPtr
                f_1644_90212_90249(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 90212, 90249);
                    return return_v;
                }


                string
                f_1644_90410_90455()
                {
                    var return_v = RemotingErrorIdStrings.ConnectExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 90410, 90455);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_90497_90521(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 90497, 90521);
                    return return_v;
                }


                string
                f_1644_90497_90534(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 90497, 90534);
                    return return_v;
                }


                string
                f_1644_90536_90616(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 90536, 90616);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_90126_90619(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 90126, 90619);
                    return return_v;
                }


                int
                f_1644_90642_90689(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 90642, 90689);
                    return 0;
                }


                int
                f_1644_91259_91291(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 91259, 91291);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCreateShellDataResult
                f_1644_91482_91539(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManCreateShellDataResult.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 91482, 91539);
                    return return_v;
                }


                int
                f_1644_91684_91721(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, string
                data)
                {
                    this_param.ProcessShellData(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 91684, 91721);
                    return 0;
                }


                int
                f_1644_91959_92039(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 91959, 92039);
                    return 0;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_92361_92385(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 92361, 92385);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_92361_92392(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 92361, 92392);
                    return return_v;
                }


                System.Management.Automation.Remoting.CreateCompleteEventArgs
                f_1644_92333_92393(System.Management.Automation.Runspaces.WSManConnectionInfo
                connectionInfo)
                {
                    var return_v = new System.Management.Automation.Remoting.CreateCompleteEventArgs((System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 92333, 92393);
                    return return_v;
                }


                int
                f_1644_92280_92394(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.CreateCompleteEventArgs
                eventArgs)
                {
                    this_param.RaiseCreateCompleted(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 92280, 92394);
                    return 0;
                }


                int
                f_1644_92492_92522(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.StartReceivingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 92492, 92522);
                    return 0;
                }


                int
                f_1644_92595_92618(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 92595, 92618);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 87208, 92630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 87208, 92630);
            }
        }

        private static void OnCloseSessionCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 92707, 94850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93000, 93068);

                f_1644_93000_93067(tracer, "Client Session TM: CloseShell callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93084, 93109);

                long
                sessionTMHandle = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93123, 93175);

                WSManClientSessionTransportManager
                sessionTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93189, 93509) || true) && (!f_1644_93194_93277(operationContext, out sessionTM, out sessionTMHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 93189, 93509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93380, 93469);

                    f_1644_93380_93468(                // We dont have the session TM handle..just return.
                                    tracer, "Unable to find a transport manager for context {0}.", sessionTMHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93487, 93494);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 93189, 93509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93525, 93766);

                f_1644_93525_93765(PSEventId.WSManCloseShellCallbackReceived, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, sessionTM.RunspacePoolInstanceId.ToString());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93782, 94791) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 93782, 94791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93840, 93923);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 93943, 94776) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 93943, 94776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 94015, 94137);

                        f_1644_94015_94136(tracer, "Got error with error code {0}. Message {1}", f_1644_94078_94110(errorStruct.errorCode), errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 94161, 94665);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_94204_94664(f_1644_94290_94327(f_1644_94290_94312(sessionTM)), sessionTM, errorStruct, TransportMethodEnum.CloseShellOperationEx, f_1644_94496_94539(), new object[] { f_1644_94581_94661(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 94687, 94726);

                        f_1644_94687_94725(sessionTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 94750, 94757);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 93943, 94776);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 93782, 94791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 94807, 94839);

                f_1644_94807_94838(
                            sessionTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 92707, 94850);

                int
                f_1644_93000_93067(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 93000, 93067);
                    return 0;
                }


                bool
                f_1644_93194_93277(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager, out long
                sessnTMId)
                {
                    var return_v = TryGetSessionTransportManager(operationContext, out sessnTransportManager, out sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 93194, 93277);
                    return return_v;
                }


                int
                f_1644_93380_93468(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 93380, 93468);
                    return 0;
                }


                int
                f_1644_93525_93765(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 93525, 93765);
                    return 0;
                }


                string
                f_1644_94078_94110(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 94078, 94110);
                    return return_v;
                }


                int
                f_1644_94015_94136(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 94015, 94136);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_94290_94312(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 94290, 94312);
                    return return_v;
                }


                System.IntPtr
                f_1644_94290_94327(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 94290, 94327);
                    return return_v;
                }


                string
                f_1644_94496_94539()
                {
                    var return_v = RemotingErrorIdStrings.CloseExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 94496, 94539);
                    return return_v;
                }


                string
                f_1644_94581_94661(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 94581, 94661);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_94204_94664(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 94204, 94664);
                    return return_v;
                }


                int
                f_1644_94687_94725(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.RaiseErrorHandler(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 94687, 94725);
                    return 0;
                }


                int
                f_1644_94807_94838(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 94807, 94838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 92707, 94850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 92707, 94850);
            }
        }

        private static void OnRemoteSessionDisconnectCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 94862, 97773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95166, 95235);

                f_1644_95166_95234(tracer, "Client Session TM: CreateShell callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95251, 95276);

                long
                sessionTMHandle = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95290, 95342);

                WSManClientSessionTransportManager
                sessionTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95356, 95676) || true) && (!f_1644_95361_95444(operationContext, out sessionTM, out sessionTMHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 95356, 95676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95547, 95636);

                    f_1644_95547_95635(                // We dont have the session TM handle..just return.
                                    tracer, "Unable to find a transport manager for context {0}.", sessionTMHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95654, 95661);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 95356, 95676);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95803, 96012) || true) && (sessionTM._disconnectSessionCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 95803, 96012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95886, 95934);

                    f_1644_95886_95933(sessionTM._disconnectSessionCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 95952, 95997);

                    sessionTM._disconnectSessionCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 95803, 96012);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 96028, 97084) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 96028, 97084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 96086, 96169);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 96189, 97069) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 96189, 97069);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 96261, 96383);

                        f_1644_96261_96382(tracer, "Got error with error code {0}. Message {1}", f_1644_96324_96356(errorStruct.errorCode), errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 96407, 96949);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_96450_96948(f_1644_96536_96573(f_1644_96536_96558(sessionTM)), sessionTM, errorStruct, TransportMethodEnum.DisconnectShellEx, f_1644_96738_96784(), new object[] { f_1644_96826_96863(f_1644_96826_96850(sessionTM)), f_1644_96865_96945(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 96971, 97019);

                        f_1644_96971_97018(sessionTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 97043, 97050);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 96189, 97069);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 96028, 97084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 97106, 97126);

                lock (sessionTM.syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 97223, 97416) || true) && (sessionTM.isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 97223, 97416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 97287, 97368);

                        f_1644_97287_97367(tracer, "Client Session TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 97390, 97397);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 97223, 97416);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 97543, 97687);

                    f_1644_97543_97686(
                                    // successfully made a connection. Now report this by raising the ConnectCompleted event.
                                    sessionTM, null, null, f_1644_97618_97685(CompletionNotification.DisconnectCompleted));

                    // Log ETW traces
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 97755, 97762);

                return;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 94862, 97773);

                int
                f_1644_95166_95234(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 95166, 95234);
                    return 0;
                }


                bool
                f_1644_95361_95444(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager, out long
                sessnTMId)
                {
                    var return_v = TryGetSessionTransportManager(operationContext, out sessnTransportManager, out sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 95361, 95444);
                    return return_v;
                }


                int
                f_1644_95547_95635(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 95547, 95635);
                    return 0;
                }


                int
                f_1644_95886_95933(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 95886, 95933);
                    return 0;
                }


                string
                f_1644_96324_96356(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 96324, 96356);
                    return return_v;
                }


                int
                f_1644_96261_96382(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 96261, 96382);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_96536_96558(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 96536, 96558);
                    return return_v;
                }


                System.IntPtr
                f_1644_96536_96573(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 96536, 96573);
                    return return_v;
                }


                string
                f_1644_96738_96784()
                {
                    var return_v = RemotingErrorIdStrings.DisconnectShellExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 96738, 96784);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_96826_96850(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 96826, 96850);
                    return return_v;
                }


                string
                f_1644_96826_96863(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 96826, 96863);
                    return return_v;
                }


                string
                f_1644_96865_96945(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 96865, 96945);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_96450_96948(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 96450, 96948);
                    return return_v;
                }


                int
                f_1644_96971_97018(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 96971, 97018);
                    return 0;
                }


                int
                f_1644_97287_97367(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 97287, 97367);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.CompletionEventArgs
                f_1644_97618_97685(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.CompletionNotification
                notification)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.CompletionEventArgs(notification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 97618, 97685);
                    return return_v;
                }


                int
                f_1644_97543_97686(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.CompletionEventArgs
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, (object)privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 97543, 97686);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 94862, 97773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 94862, 97773);
            }
        }

        private static void OnRemoteSessionReconnectCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 97785, 100524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98088, 98157);

                f_1644_98088_98156(tracer, "Client Session TM: CreateShell callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98173, 98198);

                long
                sessionTMHandle = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98212, 98264);

                WSManClientSessionTransportManager
                sessionTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98278, 98598) || true) && (!f_1644_98283_98366(operationContext, out sessionTM, out sessionTMHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 98278, 98598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98469, 98558);

                    f_1644_98469_98557(                // We dont have the session TM handle..just return.
                                    tracer, "Unable to find a transport manager for context {0}.", sessionTMHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98576, 98583);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 98278, 98598);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98721, 98927) || true) && (sessionTM._reconnectSessionCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 98721, 98927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98803, 98850);

                    f_1644_98803_98849(sessionTM._reconnectSessionCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98868, 98912);

                    sessionTM._reconnectSessionCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 98721, 98927);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 98943, 100003) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 98943, 100003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 99001, 99084);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 99104, 99988) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 99104, 99988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 99176, 99298);

                        f_1644_99176_99297(tracer, "Got error with error code {0}. Message {1}", f_1644_99239_99271(errorStruct.errorCode), errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 99322, 99868);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_99365_99867(f_1644_99451_99488(f_1644_99451_99473(sessionTM)), sessionTM, errorStruct, TransportMethodEnum.ReconnectShellEx, f_1644_99652_99703(), new object[] { f_1644_99745_99782(f_1644_99745_99769(sessionTM)), f_1644_99784_99864(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 99890, 99938);

                        f_1644_99890_99937(sessionTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 99962, 99969);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 99104, 99988);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 98943, 100003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 100025, 100045);

                lock (sessionTM.syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 100142, 100335) || true) && (sessionTM.isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 100142, 100335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 100206, 100287);

                        f_1644_100206_100286(tracer, "Client Session TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 100309, 100316);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 100142, 100335);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 100462, 100498);

                    f_1644_100462_100497(
                                    // successfully made a connection. Now report this by raising the ConnectCompleted event.
                                    sessionTM);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 97785, 100524);

                int
                f_1644_98088_98156(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 98088, 98156);
                    return 0;
                }


                bool
                f_1644_98283_98366(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager, out long
                sessnTMId)
                {
                    var return_v = TryGetSessionTransportManager(operationContext, out sessnTransportManager, out sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 98283, 98366);
                    return return_v;
                }


                int
                f_1644_98469_98557(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 98469, 98557);
                    return 0;
                }


                int
                f_1644_98803_98849(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 98803, 98849);
                    return 0;
                }


                string
                f_1644_99239_99271(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 99239, 99271);
                    return return_v;
                }


                int
                f_1644_99176_99297(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 99176, 99297);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_99451_99473(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 99451, 99473);
                    return return_v;
                }


                System.IntPtr
                f_1644_99451_99488(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 99451, 99488);
                    return return_v;
                }


                string
                f_1644_99652_99703()
                {
                    var return_v = RemotingErrorIdStrings.ReconnectShellExCallBackErrr;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 99652, 99703);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_99745_99769(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 99745, 99769);
                    return return_v;
                }


                string
                f_1644_99745_99782(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 99745, 99782);
                    return return_v;
                }


                string
                f_1644_99784_99864(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 99784, 99864);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_99365_99867(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 99365, 99867);
                    return return_v;
                }


                int
                f_1644_99890_99937(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 99890, 99937);
                    return 0;
                }


                int
                f_1644_100206_100286(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 100206, 100286);
                    return 0;
                }


                int
                f_1644_100462_100497(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.RaiseReconnectCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 100462, 100497);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 97785, 100524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 97785, 100524);
            }
        }

        private static bool HandleRobustConnectionCallback(int flags, WSManClientSessionTransportManager sessionTM)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 100536, 102715);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 100668, 101414) || true) && (flags != (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_SHELL_AUTODISCONNECTED && (DynAbs.Tracing.TraceSender.Expression_True(1644, 100672, 100875) && flags != (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_NETWORK_FAILURE_DETECTED) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 100672, 100994) && flags != (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RETRYING_AFTER_NETWORK_FAILURE) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 100672, 101116) && flags != (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RECONNECTED_AFTER_NETWORK_FAILURE) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 100672, 101228) && flags != (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_SHELL_AUTODISCONNECTING) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 100672, 101352) && flags != (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RETRY_ABORTED_DUE_TO_INTERNAL_ERROR))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 100668, 101414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 101386, 101399);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 100668, 101414);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 101507, 101861) || true) && (flags == (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_NETWORK_FAILURE_DETECTED)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 101507, 101861);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 101681, 101757);

                        f_1644_101681_101756(sessionTM.RobustConnectionsInitiated, sessionTM, EventArgs.Empty);
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1644, 101794, 101846);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1644, 101794, 101846);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 101507, 101861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 101929, 101980);

                f_1644_101929_101979(
                            // Send robust notification to client.
                            sessionTM, flags);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 102078, 102676) || true) && (flags == (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_SHELL_AUTODISCONNECTED || (DynAbs.Tracing.TraceSender.Expression_False(1644, 102082, 102294) || flags == (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RECONNECTED_AFTER_NETWORK_FAILURE) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 102082, 102418) || flags == (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_RETRY_ABORTED_DUE_TO_INTERNAL_ERROR))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 102078, 102676);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 102496, 102572);

                        f_1644_102496_102571(sessionTM.RobustConnectionsCompleted, sessionTM, EventArgs.Empty);
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1644, 102609, 102661);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1644, 102609, 102661);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 102078, 102676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 102692, 102704);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 100536, 102715);

                int
                f_1644_101681_101756(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 101681, 101756);
                    return 0;
                }


                int
                f_1644_101929_101979(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                flags)
                {
                    this_param.QueueRobustConnectionNotification(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 101929, 101979);
                    return 0;
                }


                int
                f_1644_102496_102571(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 102496, 102571);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 100536, 102715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 100536, 102715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void OnRemoteSessionConnectCallback(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 102727, 106532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103027, 103092);

                f_1644_103027_103091(tracer, "Client Session TM: Connect callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103108, 103133);

                long
                sessionTMHandle = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103147, 103199);

                WSManClientSessionTransportManager
                sessionTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103213, 103533) || true) && (!f_1644_103218_103301(operationContext, out sessionTM, out sessionTMHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 103213, 103533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103404, 103493);

                    f_1644_103404_103492(                // We dont have the session TM handle..just return.
                                    tracer, "Unable to find a transport manager for context {0}.", sessionTMHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103511, 103518);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 103213, 103533);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103693, 103801) || true) && (f_1644_103697_103745(flags, sessionTM))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 103693, 103801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103779, 103786);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 103693, 103801);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103817, 104869) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 103817, 104869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103875, 103958);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 103978, 104854) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 103978, 104854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 104050, 104172);

                        f_1644_104050_104171(tracer, "Got error with error code {0}. Message {1}", f_1644_104113_104145(errorStruct.errorCode), errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 104196, 104734);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_104239_104733(f_1644_104325_104362(f_1644_104325_104347(sessionTM)), sessionTM, errorStruct, TransportMethodEnum.ConnectShellEx, f_1644_104524_104569(), new object[] { f_1644_104611_104648(f_1644_104611_104635(sessionTM)), f_1644_104650_104730(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 104756, 104804);

                        f_1644_104756_104803(sessionTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 104828, 104835);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 103978, 104854);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 103817, 104869);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 104921, 105085) || true) && (sessionTM._openContent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 104921, 105085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 104989, 105022);

                    f_1644_104989_105021(sessionTM._openContent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105040, 105070);

                    sessionTM._openContent = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 104921, 105085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105107, 105127);

                lock (sessionTM.syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105224, 105417) || true) && (sessionTM.isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 105224, 105417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105288, 105369);

                        f_1644_105288_105368(tracer, "Client Session TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105391, 105398);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 105224, 105417);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105485, 105559);

                f_1644_105485_105558(data != null, "WSManConnectShell callback returned null data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105573, 105679);

                WSManNativeApi.WSManConnectDataResult
                connectData = f_1644_105625_105678(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105693, 106003) || true) && (connectData.data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 105693, 106003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105755, 105889);

                    byte[]
                    connectResponse = f_1644_105780_105888(connectData.data, WSManNativeApi.PS_CONNECTRESPONSE_XML_TAG)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 105907, 105988);

                    f_1644_105907_105987(sessionTM, connectResponse, WSManNativeApi.WSMAN_STREAM_ID_STDOUT);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 105693, 106003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 106069, 106093);

                f_1644_106069_106092(
                            // Set up the data-to-send callback.
                            sessionTM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 106487, 106521);

                f_1644_106487_106520(
                            // successfully made a connection. Now report this by raising the ConnectCompleted event.
                            // Microsoft's PS 3.0 Server will return all negotiation related data in one shot in connect Data
                            // Note that we are not starting to receive data yet. the DSHandlers above will do that when the session
                            // gets to an established state.
                            sessionTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 102727, 106532);

                int
                f_1644_103027_103091(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 103027, 103091);
                    return 0;
                }


                bool
                f_1644_103218_103301(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager, out long
                sessnTMId)
                {
                    var return_v = TryGetSessionTransportManager(operationContext, out sessnTransportManager, out sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 103218, 103301);
                    return return_v;
                }


                int
                f_1644_103404_103492(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 103404, 103492);
                    return 0;
                }


                bool
                f_1644_103697_103745(int
                flags, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessionTM)
                {
                    var return_v = HandleRobustConnectionCallback(flags, sessionTM);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 103697, 103745);
                    return return_v;
                }


                string
                f_1644_104113_104145(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 104113, 104145);
                    return return_v;
                }


                int
                f_1644_104050_104171(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 104050, 104171);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_104325_104347(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 104325, 104347);
                    return return_v;
                }


                System.IntPtr
                f_1644_104325_104362(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 104325, 104362);
                    return return_v;
                }


                string
                f_1644_104524_104569()
                {
                    var return_v = RemotingErrorIdStrings.ConnectExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 104524, 104569);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_104611_104635(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 104611, 104635);
                    return return_v;
                }


                string
                f_1644_104611_104648(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 104611, 104648);
                    return return_v;
                }


                string
                f_1644_104650_104730(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 104650, 104730);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_104239_104733(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 104239, 104733);
                    return return_v;
                }


                int
                f_1644_104756_104803(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 104756, 104803);
                    return 0;
                }


                int
                f_1644_104989_105021(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 104989, 105021);
                    return 0;
                }


                int
                f_1644_105288_105368(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 105288, 105368);
                    return 0;
                }


                int
                f_1644_105485_105558(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 105485, 105558);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManConnectDataResult
                f_1644_105625_105678(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManConnectDataResult.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 105625, 105678);
                    return return_v;
                }


                byte[]
                f_1644_105780_105888(string
                xmlBuffer, string
                xmlTag)
                {
                    var return_v = ServerOperationHelpers.ExtractEncodedXmlElement(xmlBuffer, xmlTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 105780, 105888);
                    return return_v;
                }


                int
                f_1644_105907_105987(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 105907, 105987);
                    return 0;
                }


                int
                f_1644_106069_106092(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 106069, 106092);
                    return 0;
                }


                int
                f_1644_106487_106520(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.RaiseConnectCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 106487, 106520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 102727, 106532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 102727, 106532);
            }
        }

        private static void OnRemoteSessionSendCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 106544, 110179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 106842, 106912);

                f_1644_106842_106911(tracer, "Client Session TM: SendComplete callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 106928, 106953);

                long
                sessionTMHandle = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 106967, 107019);

                WSManClientSessionTransportManager
                sessionTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 107033, 107353) || true) && (!f_1644_107038_107121(operationContext, out sessionTM, out sessionTMHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 107033, 107353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 107224, 107313);

                    f_1644_107224_107312(                // We dont have the session TM handle..just return.
                                    tracer, "Unable to find a transport manager for context {0}.", sessionTMHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 107331, 107338);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 107033, 107353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 107414, 107681);

                f_1644_107414_107680(PSEventId.WSManSendShellInputExCallbackReceived, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, sessionTM.RunspacePoolInstanceId.ToString(), Guid.Empty.ToString());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 107697, 108393) || true) && (!shellOperationHandle.Equals(sessionTM._wsManShellOperationHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 107697, 108393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 107915, 108127);

                    PSRemotingTransportException
                    e = f_1644_107948_108126(f_1644_108003_108125(f_1644_108050_108085(), f_1644_108087_108124(f_1644_108087_108111(sessionTM))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108145, 108285);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_108209_108284(e, TransportMethodEnum.SendShellInputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108303, 108351);

                    f_1644_108303_108350(sessionTM, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108371, 108378);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 107697, 108393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108409, 108460);

                f_1644_108409_108459(
                            sessionTM, flags, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108555, 108732) || true) && (sessionTM.isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 108555, 108732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108611, 108692);

                    f_1644_108611_108691(tracer, "Client Session TM: Transport manager is closed. So returning");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108710, 108717);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 108555, 108732);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108748, 110079) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 108748, 110079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 108806, 108889);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 109153, 110064) || true) && ((errorStruct.errorCode != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 109157, 109219) && (errorStruct.errorCode != 995)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 109153, 110064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 109261, 109383);

                        f_1644_109261_109382(tracer, "Got error with error code {0}. Message {1}", f_1644_109324_109356(errorStruct.errorCode), errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 109407, 109944);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_109450_109943(f_1644_109536_109573(f_1644_109536_109558(sessionTM)), sessionTM, errorStruct, TransportMethodEnum.SendShellInputEx, f_1644_109737_109779(), new object[] { f_1644_109821_109858(f_1644_109821_109845(sessionTM)), f_1644_109860_109940(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 109966, 110014);

                        f_1644_109966_110013(sessionTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 110038, 110045);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 109153, 110064);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 108748, 110079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 110144, 110168);

                f_1644_110144_110167(
                            // Send the next item, if available
                            sessionTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 106544, 110179);

                int
                f_1644_106842_106911(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 106842, 106911);
                    return 0;
                }


                bool
                f_1644_107038_107121(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager, out long
                sessnTMId)
                {
                    var return_v = TryGetSessionTransportManager(operationContext, out sessnTransportManager, out sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 107038, 107121);
                    return return_v;
                }


                int
                f_1644_107224_107312(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 107224, 107312);
                    return 0;
                }


                int
                f_1644_107414_107680(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 107414, 107680);
                    return 0;
                }


                string
                f_1644_108050_108085()
                {
                    var return_v = RemotingErrorIdStrings.SendExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 108050, 108085);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_108087_108111(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 108087, 108111);
                    return return_v;
                }


                string
                f_1644_108087_108124(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 108087, 108124);
                    return return_v;
                }


                string
                f_1644_108003_108125(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 108003, 108125);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_107948_108126(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 107948, 108126);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_108209_108284(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 108209, 108284);
                    return return_v;
                }


                int
                f_1644_108303_108350(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 108303, 108350);
                    return 0;
                }


                int
                f_1644_108409_108459(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                flags, bool
                shouldClearSend)
                {
                    this_param.ClearReceiveOrSendResources(flags, shouldClearSend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 108409, 108459);
                    return 0;
                }


                int
                f_1644_108611_108691(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 108611, 108691);
                    return 0;
                }


                string
                f_1644_109324_109356(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 109324, 109356);
                    return return_v;
                }


                int
                f_1644_109261_109382(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 109261, 109382);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_109536_109558(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 109536, 109558);
                    return return_v;
                }


                System.IntPtr
                f_1644_109536_109573(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 109536, 109573);
                    return return_v;
                }


                string
                f_1644_109737_109779()
                {
                    var return_v = RemotingErrorIdStrings.SendExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 109737, 109779);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_109821_109845(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 109821, 109845);
                    return return_v;
                }


                string
                f_1644_109821_109858(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 109821, 109858);
                    return return_v;
                }


                string
                f_1644_109860_109940(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 109860, 109940);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_109450_109943(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 109450, 109943);
                    return return_v;
                }


                int
                f_1644_109966_110013(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 109966, 110013);
                    return 0;
                }


                int
                f_1644_110144_110167(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 110144, 110167);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 106544, 110179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 106544, 110179);
            }
        }

        private static void OnRemoteSessionDataReceived(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 110361, 114032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 110658, 110728);

                f_1644_110658_110727(tracer, "Client Session TM: OnRemoteDataReceived callback.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 110744, 110769);

                long
                sessionTMHandle = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 110783, 110835);

                WSManClientSessionTransportManager
                sessionTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 110849, 111169) || true) && (!f_1644_110854_110937(operationContext, out sessionTM, out sessionTMHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 110849, 111169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111040, 111129);

                    f_1644_111040_111128(                // We dont have the session TM handle..just return.
                                    tracer, "Unable to find a transport manager for context {0}.", sessionTMHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111147, 111154);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 110849, 111169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111185, 111237);

                f_1644_111185_111236(
                            sessionTM, flags, false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111253, 111430) || true) && (sessionTM.isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 111253, 111430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111309, 111390);

                    f_1644_111309_111389(tracer, "Client Session TM: Transport manager is closed. So returning");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111408, 111415);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 111253, 111430);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111446, 112149) || true) && (!shellOperationHandle.Equals(sessionTM._wsManShellOperationHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 111446, 112149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111664, 111879);

                    PSRemotingTransportException
                    e = f_1644_111697_111878(f_1644_111752_111877(f_1644_111799_111837(), f_1644_111839_111876(f_1644_111839_111863(sessionTM))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 111897, 112041);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_111961_112040(e, TransportMethodEnum.ReceiveShellOutputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 112059, 112107);

                    f_1644_112059_112106(sessionTM, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 112127, 112134);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 111446, 112149);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 112165, 113223) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 112165, 113223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 112223, 112306);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 112326, 113208) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 112326, 113208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 112398, 112520);

                        f_1644_112398_112519(tracer, "Got error with error code {0}. Message {1}", f_1644_112461_112493(errorStruct.errorCode), errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 112544, 113088);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_112587_113087(f_1644_112673_112710(f_1644_112673_112695(sessionTM)), sessionTM, errorStruct, TransportMethodEnum.ReceiveShellOutputEx, f_1644_112878_112923(), new object[] { f_1644_112965_113002(f_1644_112965_112989(sessionTM)), f_1644_113004_113084(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 113110, 113158);

                        f_1644_113110_113157(sessionTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 113182, 113189);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 112326, 113208);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 112165, 113223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 113239, 113346);

                WSManNativeApi.WSManReceiveDataResult
                dataReceived = f_1644_113292_113345(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 113360, 114021) || true) && (dataReceived.data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 113360, 114021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 113423, 113497);

                    f_1644_113423_113496(tracer, "Session Received Data : {0}", f_1644_113471_113495(dataReceived.data));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 113515, 113923);

                    f_1644_113515_113922(PSEventId.WSManReceiveShellOutputExCallbackReceived, PSOpcode.Receive, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, sessionTM.RunspacePoolInstanceId.ToString(), Guid.Empty.ToString(), f_1644_113858_113921(f_1644_113858_113882(dataReceived.data), f_1644_113892_113920()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 113941, 114006);

                    f_1644_113941_114005(sessionTM, dataReceived.data, dataReceived.stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 113360, 114021);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 110361, 114032);

                int
                f_1644_110658_110727(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 110658, 110727);
                    return 0;
                }


                bool
                f_1644_110854_110937(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                sessnTransportManager, out long
                sessnTMId)
                {
                    var return_v = TryGetSessionTransportManager(operationContext, out sessnTransportManager, out sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 110854, 110937);
                    return return_v;
                }


                int
                f_1644_111040_111128(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 111040, 111128);
                    return 0;
                }


                int
                f_1644_111185_111236(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, int
                flags, bool
                shouldClearSend)
                {
                    this_param.ClearReceiveOrSendResources(flags, shouldClearSend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 111185, 111236);
                    return 0;
                }


                int
                f_1644_111309_111389(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 111309, 111389);
                    return 0;
                }


                string
                f_1644_111799_111837()
                {
                    var return_v = RemotingErrorIdStrings.ReceiveExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 111799, 111837);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_111839_111863(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 111839, 111863);
                    return return_v;
                }


                string
                f_1644_111839_111876(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 111839, 111876);
                    return return_v;
                }


                string
                f_1644_111752_111877(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 111752, 111877);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_111697_111878(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 111697, 111878);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_111961_112040(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 111961, 112040);
                    return return_v;
                }


                int
                f_1644_112059_112106(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 112059, 112106);
                    return 0;
                }


                string
                f_1644_112461_112493(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 112461, 112493);
                    return return_v;
                }


                int
                f_1644_112398_112519(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 112398, 112519);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_112673_112695(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 112673, 112695);
                    return return_v;
                }


                System.IntPtr
                f_1644_112673_112710(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 112673, 112710);
                    return return_v;
                }


                string
                f_1644_112878_112923()
                {
                    var return_v = RemotingErrorIdStrings.ReceiveExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 112878, 112923);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1644_112965_112989(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 112965, 112989);
                    return return_v;
                }


                string
                f_1644_112965_113002(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 112965, 113002);
                    return return_v;
                }


                string
                f_1644_113004_113084(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 113004, 113084);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_112587_113087(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 112587, 113087);
                    return return_v;
                }


                int
                f_1644_113110_113157(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 113110, 113157);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManReceiveDataResult
                f_1644_113292_113345(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManReceiveDataResult.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 113292, 113345);
                    return return_v;
                }


                int
                f_1644_113471_113495(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 113471, 113495);
                    return return_v;
                }


                int
                f_1644_113423_113496(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 113423, 113496);
                    return 0;
                }


                int
                f_1644_113858_113882(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 113858, 113882);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_113892_113920()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 113892, 113920);
                    return return_v;
                }


                string
                f_1644_113858_113921(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 113858, 113921);
                    return return_v;
                }


                int
                f_1644_113515_113922(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 113515, 113922);
                    return 0;
                }


                int
                f_1644_113941_114005(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 113941, 114005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 110361, 114032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 110361, 114032);
            }
        }

        private void SendOneItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 114104, 114522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114155, 114185);

                DataPriorityType
                priorityType
                = default(DataPriorityType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114286, 114403);

                byte[]
                data = f_1644_114300_114402(dataToBeSent, _onDataAvailableToSendCallback, out priorityType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114417, 114511) || true) && (data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 114417, 114511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114467, 114496);

                    f_1644_114467_114495(this, data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 114417, 114511);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 114104, 114522);

                byte[]
                f_1644_114300_114402(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 114300, 114402);
                    return return_v;
                }


                int
                f_1644_114467_114495(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.SendData(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 114467, 114495);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 114104, 114522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 114104, 114522);
            }
        }

        private void OnDataAvailableCallback(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 114534, 114852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114639, 114718);

                f_1644_114639_114717(data != null, "data cannot be null in the data available callback");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114734, 114798);

                f_1644_114734_114797(
                            tracer, "Received data to be sent from the callback.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114812, 114841);

                f_1644_114812_114840(this, data, priorityType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 114534, 114852);

                int
                f_1644_114639_114717(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 114639, 114717);
                    return 0;
                }


                int
                f_1644_114734_114797(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 114734, 114797);
                    return 0;
                }


                int
                f_1644_114812_114840(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.SendData(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 114812, 114840);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 114534, 114852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 114534, 114852);
            }
        }

        private void SendData(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 114864, 117097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 114954, 115022);

                f_1644_114954_115021(tracer, "Session sending data of size : {0}", f_1644_115009_115020(data));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115036, 115058);

                byte[]
                package = data
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115143, 115168);

                bool
                sendContinue = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115184, 115454) || true) && (s_sessionSendRedirect != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 115184, 115454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115251, 115304);

                    object[]
                    arguments = new object[2] { null, package }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115322, 115390);

                    sendContinue = (bool)f_1644_115343_115389(s_sessionSendRedirect, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115408, 115439);

                    package = (byte[])arguments[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 115184, 115454);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115470, 115513) || true) && (!sendContinue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 115470, 115513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115506, 115513);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 115470, 115513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115555, 117086);
                using (WSManNativeApi.WSManData_ManToUn
                serializedContent =
                f_1644_115641_115686(package)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 115720, 116101);

                    f_1644_115720_116100(PSEventId.WSManSendShellInputEx, PSOpcode.Send, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_115930_115952().ToString(), Guid.Empty.ToString(), f_1644_116030_116099(f_1644_116030_116060(serializedContent), f_1644_116070_116098()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 116127, 116137);

                    lock (syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 116242, 116441) || true) && (isClosed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 116242, 116441);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 116304, 116385);

                            f_1644_116304_116384(tracer, "Client Session TM: Transport manager is closed. So returning");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 116411, 116418);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 116242, 116441);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 116503, 116617);

                        _sendToRemoteCompleted = f_1644_116528_116616(f_1644_116563_116592(_sessionContextID), s_sessionSendCallback);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 116639, 117052);

                        f_1644_116639_117051(_wsManShellOperationHandle, IntPtr.Zero, 0, (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 116745, 116785) || ((priorityType == DataPriorityType.Default && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 116817, 116853)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 116856, 116901))) ? WSManNativeApi.WSMAN_STREAM_ID_STDIN : WSManNativeApi.WSMAN_STREAM_ID_PROMPTRESPONSE, serializedContent, _sendToRemoteCompleted, ref _wsManSendOperationHandle);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 115555, 117086);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 114864, 117097);

                int
                f_1644_115009_115020(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 115009, 115020);
                    return return_v;
                }


                int
                f_1644_114954_115021(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 114954, 115021);
                    return 0;
                }


                object?
                f_1644_115343_115389(System.Delegate
                this_param, params object[]
                args)
                {
                    var return_v = this_param.DynamicInvoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 115343, 115389);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                f_1644_115641_115686(byte[]
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 115641, 115686);
                    return return_v;
                }


                System.Guid
                f_1644_115930_115952()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 115930, 115952);
                    return return_v;
                }


                int
                f_1644_116030_116060(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                this_param)
                {
                    var return_v = this_param.BufferLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 116030, 116060);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_116070_116098()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 116070, 116098);
                    return return_v;
                }


                string
                f_1644_116030_116099(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 116030, 116099);
                    return return_v;
                }


                int
                f_1644_115720_116100(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 115720, 116100);
                    return 0;
                }


                int
                f_1644_116304_116384(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 116304, 116384);
                    return 0;
                }


                System.IntPtr
                f_1644_116563_116592(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 116563, 116592);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_116528_116616(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 116528, 116616);
                    return return_v;
                }


                int
                f_1644_116639_117051(System.IntPtr
                shellOperationHandle, System.IntPtr
                commandOperationHandle, int
                flags, string
                streamId, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                streamData, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                sendOperationHandle)
                {
                    WSManNativeApi.WSManSendShellInputEx(shellOperationHandle, commandOperationHandle, flags, streamId, streamData, (System.IntPtr)asyncCallback, ref sendOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 116639, 117051);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 114864, 117097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 114864, 117097);
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed")]
        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 117179, 117971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 117341, 117475);

                f_1644_117341_117474(tracer, "Disposing session with session context: {0} Operation Context: {1}", _sessionContextID, _wsManShellOperationHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 117491, 117523);

                f_1644_117491_117522(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 117539, 117566);

                f_1644_117539_117565(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 117767, 117918) || true) && (isDisposing && (DynAbs.Tracing.TraceSender.Expression_True(1644, 117771, 117808) && (_openContent != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 117767, 117918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 117842, 117865);

                    f_1644_117842_117864(_openContent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 117883, 117903);

                    _openContent = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 117767, 117918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 117934, 117960);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1644, 117934, 117959);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 117179, 117971);

                int
                f_1644_117341_117474(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, System.IntPtr
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 117341, 117474);
                    return 0;
                }


                int
                f_1644_117491_117522(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.CloseSessionAndClearResources();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 117491, 117522);
                    return 0;
                }


                int
                f_1644_117539_117565(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    this_param.DisposeWSManAPIDataAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 117539, 117565);
                    return 0;
                }


                int
                f_1644_117842_117864(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 117842, 117864);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 117179, 117971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 117179, 117971);
            }
        }

        private void CloseSessionAndClearResources()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 118153, 120620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 118222, 118355);

                f_1644_118222_118354(tracer, "Clearing session with session context: {0} Operation Context: {1}", _sessionContextID, _wsManShellOperationHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 118562, 118614);

                IntPtr
                tempWSManSessionHandle = _wsManSessionHandle
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 118628, 118662);

                _wsManSessionHandle = IntPtr.Zero;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 118877, 119420);

                f_1644_118877_119419(new WaitCallback(
                                // wsManSessionHandle is passed as parameter to allow the thread to be independent
                                // of the rest of the parent object.
                                delegate (object state)
                                {
                                    IntPtr sessionHandle = (IntPtr)state;
                                    if (sessionHandle != IntPtr.Zero)
                                    {
                                        WSManNativeApi.WSManCloseSession(sessionHandle, 0);
                                    }
                                }), tempWSManSessionHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 119507, 119556);

                f_1644_119507_119555(_sessionContextID);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 119572, 119736) || true) && (_closeSessionCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 119572, 119736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 119640, 119673);

                    f_1644_119640_119672(_closeSessionCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 119691, 119721);

                    _closeSessionCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 119572, 119736);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 119963, 120183) || true) && (_createSessionCallback != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 119963, 120183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120031, 120069);

                    _createSessionCallbackGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120087, 120120);

                    f_1644_120087_120119(_createSessionCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120138, 120168);

                    _createSessionCallback = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 119963, 120183);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120261, 120428) || true) && (_connectSessionCallback != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 120261, 120428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120330, 120364);

                    f_1644_120330_120363(_connectSessionCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120382, 120413);

                    _connectSessionCallback = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 120261, 120428);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120587, 120609);

                _sessionContextID = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 118153, 120620);

                int
                f_1644_118222_118354(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, System.IntPtr
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 118222, 118354);
                    return 0;
                }


                bool
                f_1644_118877_119419(System.Threading.WaitCallback
                callBack, System.IntPtr
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 118877, 119419);
                    return return_v;
                }


                int
                f_1644_119507_119555(long
                sessnTMId)
                {
                    RemoveSessionTransportManager(sessnTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 119507, 119555);
                    return 0;
                }


                int
                f_1644_119640_119672(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 119640, 119672);
                    return 0;
                }


                int
                f_1644_120087_120119(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 120087, 120119);
                    return 0;
                }


                int
                f_1644_120330_120363(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 120330, 120363);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 118153, 120620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 118153, 120620);
            }
        }

        private void DisposeWSManAPIDataAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 120632, 121278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120696, 120747);

                WSManAPIDataCommon
                tempWSManApiData = f_1644_120734_120746()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120761, 120802) || true) && (tempWSManApiData == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 120761, 120802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120793, 120800);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 120761, 120802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 120818, 120838);

                WSManAPIData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 121104, 121267);

                f_1644_121104_121266((state) =>
                                {
                                    tempWSManApiData.Dispose();
                                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 120632, 121278);

                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_120734_120746()
                {
                    var return_v = WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 120734, 120746);
                    return return_v;
                }


                bool
                f_1644_121104_121266(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = System.Threading.ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 121104, 121266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 120632, 121278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 120632, 121278);
            }
        }
        internal class WSManAPIDataCommon : IDisposable
        {
            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            private IntPtr _handle;

            private WSManNativeApi.WSManStreamIDSet_ManToUn _inputStreamSet;

            private WSManNativeApi.WSManStreamIDSet_ManToUn _outputStreamSet;

            private bool _isDisposed;

            private object _syncObject;

            private WindowsIdentity _identityToImpersonate;

            internal WSManAPIDataCommon()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1644, 122282, 124530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 121995, 122006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 122036, 122062);
                    this._syncObject = f_1644_122050_122062();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 122112, 122134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124546, 124577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124825, 124891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 122453, 122521);

                    f_1644_122453_122520(out _identityToImpersonate);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 122549, 122571);

                    _handle = IntPtr.Zero;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 122635, 122744);

                        ErrorCode = f_1644_122647_122743(WSManNativeApi.WSMAN_FLAG_REQUESTED_API_VERSION_1_1, ref _handle);
                    }
                    catch (DllNotFoundException ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1644, 122781, 123453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 122853, 123318);

                        f_1644_122853_123317(PSEventId.TransportError, PSOpcode.Open, PSTask.None, PSKeyword.UseAlwaysOperational, "WSManAPIDataCommon.ctor", "WSManInitialize", f_1644_123190_123239(f_1644_123190_123200(ex), f_1644_123210_123238()), f_1644_123266_123276(ex), f_1644_123303_123316(ex));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 123340, 123434);

                        throw f_1644_123346_123433(f_1644_123379_123428(), ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1644, 122781, 123453);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 123542, 123799);

                    _inputStreamSet = f_1644_123560_123798(new string[] {
                        WSManNativeApi.WSMAN_STREAM_ID_STDIN,
                        WSManNativeApi.WSMAN_STREAM_ID_PROMPTRESPONSE
                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 123817, 123958);

                    _outputStreamSet = f_1644_123836_123957(new string[] { WSManNativeApi.WSMAN_STREAM_ID_STDOUT });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124040, 124124);

                    WSManNativeApi.WSManOption
                    protocolStartupOption = f_1644_124091_124123()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124142, 124226);

                    protocolStartupOption.name = RemoteDataNameStrings.PS_STARTUP_PROTOCOL_VERSION_NAME;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124244, 124319);

                    protocolStartupOption.value = f_1644_124274_124318(RemotingConstants.ProtocolVersion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124337, 124377);

                    protocolStartupOption.mustComply = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124397, 124454);

                    CommonOptionSet = f_1644_124415_124453();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124472, 124515);

                    f_1644_124472_124514(f_1644_124472_124487(), protocolStartupOption);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1644, 122282, 124530);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 122282, 124530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 122282, 124530);
                }
            }

            internal int ErrorCode { get; }

            internal WSManNativeApi.WSManStreamIDSet_ManToUn InputStreamSet
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 124659, 124690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124665, 124688);

                        return _inputStreamSet;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 124659, 124690);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 124593, 124692);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 124593, 124692);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal WSManNativeApi.WSManStreamIDSet_ManToUn OutputStreamSet
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 124775, 124807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124781, 124805);

                        return _outputStreamSet;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 124775, 124807);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 124708, 124809);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 124708, 124809);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal List<WSManNativeApi.WSManOption> CommonOptionSet { get; }

            internal IntPtr WSManAPIHandle
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 124940, 124963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 124946, 124961);

                        return _handle;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 124940, 124963);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 124907, 124965);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 124907, 124965);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults",
                           MessageId = "System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDeinitialize(System.IntPtr,System.Int32)")]
            [SuppressMessage("Microsoft.Usage", "CA2216:Disposabletypesshoulddeclarefinalizer")]
            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 125161, 126673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125541, 125552);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125594, 125622) || true) && (_isDisposed)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 125594, 125622);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125613, 125620);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 125594, 125622);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125646, 125665);

                        _isDisposed = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125704, 125730);

                    _inputStreamSet.Dispose();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125748, 125775);

                    _outputStreamSet.Dispose();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125795, 126658) || true) && (IntPtr.Zero != _handle)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 125795, 126658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 125863, 125878);

                        int
                        result = 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 126028, 126494) || true) && (_identityToImpersonate != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 126028, 126494);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 126112, 126300);

                            result = f_1644_126121_126299(f_1644_126183_126217(_identityToImpersonate), () => WSManNativeApi.WSManDeinitialize(_handle, 0));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 126028, 126494);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 126028, 126494);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 126406, 126460);

                            result = f_1644_126415_126459(_handle, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 126028, 126494);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 126526, 126595);

                        f_1644_126526_126594(result == 0, "WSManDeinitialize returned non-zero value");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 126617, 126639);

                        _handle = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 125795, 126658);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 125161, 126673);

                    Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                    f_1644_126183_126217(System.Security.Principal.WindowsIdentity
                    this_param)
                    {
                        var return_v = this_param.AccessToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 126183, 126217);
                        return return_v;
                    }


                    int
                    f_1644_126121_126299(Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                    safeAccessTokenHandle, System.Func<int>
                    func)
                    {
                        var return_v = WindowsIdentity.RunImpersonated(safeAccessTokenHandle, func);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 126121, 126299);
                        return return_v;
                    }


                    int
                    f_1644_126415_126459(System.IntPtr
                    wsManAPIHandle, int
                    flags)
                    {
                        var return_v = WSManNativeApi.WSManDeinitialize(wsManAPIHandle, flags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 126415, 126459);
                        return return_v;
                    }


                    int
                    f_1644_126526_126594(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 126526, 126594);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 125161, 126673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 125161, 126673);
                }
            }

            static WSManAPIDataCommon()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1644, 121561, 126684);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1644, 121561, 126684);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 121561, 126684);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1644, 121561, 126684);

            object
            f_1644_122050_122062()
            {
                var return_v = new object();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 122050, 122062);
                return return_v;
            }


            static bool
            f_1644_122453_122520(out System.Security.Principal.WindowsIdentity
            impersonatedIdentity)
            {
                var return_v = Utils.TryGetWindowsImpersonatedIdentity(out impersonatedIdentity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 122453, 122520);
                return return_v;
            }


            static int
            f_1644_122647_122743(int
            flags, ref System.IntPtr
            wsManAPIHandle)
            {
                var return_v = WSManNativeApi.WSManInitialize(flags, ref wsManAPIHandle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 122647, 122743);
                return return_v;
            }


            static int
            f_1644_123190_123200(System.DllNotFoundException
            this_param)
            {
                var return_v = this_param.HResult;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 123190, 123200);
                return return_v;
            }


            static System.Globalization.CultureInfo
            f_1644_123210_123238()
            {
                var return_v = CultureInfo.InvariantCulture;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 123210, 123238);
                return return_v;
            }


            static string
            f_1644_123190_123239(int
            this_param, System.Globalization.CultureInfo
            provider)
            {
                var return_v = this_param.ToString((System.IFormatProvider)provider);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 123190, 123239);
                return return_v;
            }


            static string
            f_1644_123266_123276(System.DllNotFoundException
            this_param)
            {
                var return_v = this_param.Message;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 123266, 123276);
                return return_v;
            }


            static string
            f_1644_123303_123316(System.DllNotFoundException
            this_param)
            {
                var return_v = this_param.StackTrace;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 123303, 123316);
                return return_v;
            }


            static int
            f_1644_122853_123317(System.Management.Automation.Internal.PSEventId
            id, System.Management.Automation.Internal.PSOpcode
            opcode, System.Management.Automation.Internal.PSTask
            task, System.Management.Automation.Internal.PSKeyword
            keyword, params object[]
            args)
            {
                PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 122853, 123317);
                return 0;
            }


            static string
            f_1644_123379_123428()
            {
                var return_v = RemotingErrorIdStrings.WSManClientDllNotAvailable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 123379, 123428);
                return return_v;
            }


            static System.Management.Automation.Remoting.PSRemotingTransportException
            f_1644_123346_123433(string
            message, System.DllNotFoundException
            innerException)
            {
                var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message, (System.Exception)innerException);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 123346, 123433);
                return return_v;
            }


            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
            f_1644_123560_123798(string[]
            streamIds)
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn(streamIds);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 123560, 123798);
                return return_v;
            }


            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
            f_1644_123836_123957(string[]
            streamIds)
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn(streamIds);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 123836, 123957);
                return return_v;
            }


            static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
            f_1644_124091_124123()
            {
                var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 124091, 124123);
                return return_v;
            }


            static string
            f_1644_124274_124318(System.Version
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 124274, 124318);
                return return_v;
            }


            static System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
            f_1644_124415_124453()
            {
                var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 124415, 124453);
                return return_v;
            }


            System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
            f_1644_124472_124487()
            {
                var return_v = CommonOptionSet;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 124472, 124487);
                return return_v;
            }


            static int
            f_1644_124472_124514(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption>
            this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption
            item)
            {
                this_param.Add(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 124472, 124514);
                return 0;
            }

        }



        internal event EventHandler<EventArgs>
RobustConnectionsInitiated
;

        internal event EventHandler<EventArgs>
RobustConnectionsCompleted
;
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1644, 14435, 126924);

        static System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager>
        f_1644_22810_22868()
        {
            var return_v = new System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 22810, 22868);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_25069_25127(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 25069, 25127);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_25333_25390(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 25333, 25390);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_25604_25663(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 25604, 25663);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_25872_25928(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 25872, 25928);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_26155_26217(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 26155, 26217);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_26441_26502(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 26441, 26502);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_26719_26778(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 26719, 26778);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
        f_1644_27985_28009()
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 27985, 28009);
            return return_v;
        }


        System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
        f_1644_28028_28040()
        {
            var return_v = WSManAPIData;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 28028, 28040);
            return return_v;
        }


        static System.IntPtr
        f_1644_28028_28055(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
        this_param)
        {
            var return_v = this_param.WSManAPIHandle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 28028, 28055);
            return return_v;
        }


        static string
        f_1644_28183_28221()
        {
            var return_v = RemotingErrorIdStrings.WSManInitFailed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 28183, 28221);
            return return_v;
        }


        System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
        f_1644_28223_28235()
        {
            var return_v = WSManAPIData;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 28223, 28235);
            return return_v;
        }


        static int
        f_1644_28223_28245(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
        this_param)
        {
            var return_v = this_param.ErrorCode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 28223, 28245);
            return return_v;
        }


        static string
        f_1644_28165_28246(string
        formatSpec, int
        o)
        {
            var return_v = StringUtil.Format(formatSpec, (object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 28165, 28246);
            return return_v;
        }


        static System.Management.Automation.Remoting.PSRemotingTransportException
        f_1644_28110_28247(string
        message)
        {
            var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 28110, 28247);
            return return_v;
        }


        static int
        f_1644_28279_28346(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 28279, 28346);
            return 0;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1644_29052_29074()
        {
            var return_v = ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 29052, 29074);
            return return_v;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1644_29120_29142()
        {
            var return_v = ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 29120, 29142);
            return return_v;
        }


        static int?
        f_1644_29171_29211(System.Management.Automation.Runspaces.WSManConnectionInfo
        this_param)
        {
            var return_v = this_param.MaximumReceivedObjectSize;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 29171, 29211);
            return return_v;
        }


        static System.Uri
        f_1644_29385_29413(System.Management.Automation.Runspaces.WSManConnectionInfo
        this_param)
        {
            var return_v = this_param.ConnectionUri;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 29385, 29413);
            return return_v;
        }


        static int
        f_1644_29374_29430(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
        this_param, System.Uri
        connectionUri, System.Management.Automation.Runspaces.WSManConnectionInfo
        connectionInfo)
        {
            this_param.Initialize(connectionUri, connectionInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 29374, 29430);
            return 0;
        }


        static System.Guid
        f_1644_27866_27888_C(System.Guid
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1644, 27667, 29442);
            return return_v;
        }

    }
    internal sealed class WSManClientCommandTransportManager : BaseClientCommandTransportManager
    {
        internal const string
        StopSignal = @"powershell/signal/crtl_c"
        ;

        private IntPtr _wsManShellOperationHandle;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _wsManCmdOperationHandle;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _cmdSignalOperationHandle;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _wsManReceiveOperationHandle;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private IntPtr _wsManSendOperationHandle;

        private long _cmdContextId;

        private PrioritySendDataCollection.OnDataAvailableCallback _onDataAvailableToSendCallback;

        private bool _shouldStartReceivingData;

        private bool _isCreateCallbackReceived;

        private bool _isStopSignalPending;

        private bool _isDisconnectPending;

        private bool _isSendingInput;

        private bool _isDisconnectedOnInvoke;

        private WSManNativeApi.WSManShellAsync _createCmdCompleted;

        private WSManNativeApi.WSManShellAsync _receivedFromRemote;

        private WSManNativeApi.WSManShellAsync _sendToRemoteCompleted;

        private WSManNativeApi.WSManShellAsync _reconnectCmdCompleted;

        private WSManNativeApi.WSManShellAsync _connectCmdCompleted;

        private GCHandle _createCmdCompletedGCHandle;

        private WSManNativeApi.WSManShellAsync _closeCmdCompleted;

        private WSManNativeApi.WSManShellAsync _signalCmdCompleted;

        private SendDataChunk _chunkToSend;

        private string _cmdLine;

        private readonly WSManClientSessionTransportManager _sessnTm;
        private class SendDataChunk
        {
            public SendDataChunk(byte[] data, DataPriorityType type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1644, 129924, 130070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 130086, 130113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 130129, 130166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 130013, 130025);

                    Data = data;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 130043, 130055);

                    Type = type;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1644, 129924, 130070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 129924, 130070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 129924, 130070);
                }
            }

            public byte[] Data { get; }

            public DataPriorityType Type { get; }

            static SendDataChunk()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1644, 129872, 130177);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1644, 129872, 130177);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 129872, 130177);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1644, 129872, 130177);
        }

        private static WSManNativeApi.WSManShellAsyncCallback s_cmdCreateCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_cmdCloseCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_cmdReceiveCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_cmdSendCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_cmdSignalCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_cmdReconnectCallback;

        private static WSManNativeApi.WSManShellAsyncCallback s_cmdConnectCallback;

        static WSManClientCommandTransportManager()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1644, 130871, 132815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 127378, 127418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 135380, 135412);
                s_commandCodeSendRedirect = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178575, 178603);
                s_commandSendRedirect = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183908, 183996);
                s_cmdTMHandles = f_1644_183938_183996();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 184027, 184038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 130985, 131133);

                WSManNativeApi.WSManShellCompletionFunction
                createDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnCreateCmdCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 131147, 131228);

                s_cmdCreateCallback = f_1644_131169_131227(createDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 131244, 131390);

                WSManNativeApi.WSManShellCompletionFunction
                closeDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnCloseCmdCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 131404, 131483);

                s_cmdCloseCallback = f_1644_131425_131482(closeDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 131499, 131651);

                WSManNativeApi.WSManShellCompletionFunction
                receiveDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteCmdDataReceived)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 131665, 131748);

                s_cmdReceiveCallback = f_1644_131688_131747(receiveDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 131764, 131914);

                WSManNativeApi.WSManShellCompletionFunction
                sendDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteCmdSendCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 131928, 132005);

                s_cmdSendCallback = f_1644_131948_132004(sendDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 132021, 132175);

                WSManNativeApi.WSManShellCompletionFunction
                signalDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnRemoteCmdSignalCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 132189, 132270);

                s_cmdSignalCallback = f_1644_132211_132269(signalDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 132286, 132440);

                WSManNativeApi.WSManShellCompletionFunction
                reconnectDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnReconnectCmdCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 132454, 132541);

                s_cmdReconnectCallback = f_1644_132479_132540(reconnectDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 132557, 132707);

                WSManNativeApi.WSManShellCompletionFunction
                connectDelegate =
                                new WSManNativeApi.WSManShellCompletionFunction(OnConnectCmdCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 132721, 132804);

                s_cmdConnectCallback = f_1644_132744_132803(connectDelegate);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1644, 130871, 132815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 130871, 132815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 130871, 132815);
            }
        }

        internal WSManClientCommandTransportManager(WSManConnectionInfo connectionInfo,
                    IntPtr wsManShellOperationHandle,
                    ClientRemotePowerShell shell,
                    bool noInput,
                    WSManClientSessionTransportManager sessnTM) : base(f_1644_134061_134066_C(shell), f_1644_134068_134088(sessnTM), sessnTM)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1644, 133787, 135253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128290, 128303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128375, 128405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128490, 128515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128626, 128651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128675, 128695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128719, 128739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128763, 128778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128802, 128825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128899, 128918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 128968, 128987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129037, 129059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129109, 129131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129181, 129201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129481, 129499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129549, 129568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129740, 129752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129780, 129788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 129851, 129859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134123, 134225);

                f_1644_134123_134224(IntPtr.Zero != wsManShellOperationHandle, "Shell operation handle cannot be IntPtr.Zero.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134239, 134307);

                f_1644_134239_134306(connectionInfo != null, "connectionInfo cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134323, 134378);

                _wsManShellOperationHandle = wsManShellOperationHandle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134464, 134562);

                f_1644_134464_134486().MaximumReceivedDataSize = f_1644_134513_134561(connectionInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134576, 134668);

                f_1644_134576_134598().MaximumReceivedObjectSize = f_1644_134627_134667(connectionInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134682, 134757);

                _cmdLine = f_1644_134693_134756(f_1644_134693_134727(f_1644_134693_134718(f_1644_134693_134709(shell))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134771, 134901);

                _onDataAvailableToSendCallback =
                                new PrioritySendDataCollection.OnDataAvailableCallback(OnDataAvailableCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 134915, 134934);

                _sessnTm = sessnTM;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 135017, 135088);

                sessnTM.RobustConnectionsInitiated += HandleRobustConnectionsInitiated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 135172, 135242);

                sessnTM.RobustConnectionsCompleted += HandleRobusConnectionsCompleted;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1644, 133787, 135253);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 133787, 135253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 133787, 135253);
            }
        }

        private static Delegate s_commandCodeSendRedirect;

        private void HandleRobustConnectionsInitiated(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 135496, 135620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 135594, 135609);

                f_1644_135594_135608(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 135496, 135620);

                int
                f_1644_135594_135608(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SuspendQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 135594, 135608);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 135496, 135620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 135496, 135620);
            }
        }

        private void HandleRobusConnectionsCompleted(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 135632, 135754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 135729, 135743);

                f_1644_135729_135742(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 135632, 135754);

                int
                f_1644_135729_135742(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.ResumeQueue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 135729, 135742);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 135632, 135754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 135632, 135754);
            }
        }

        internal override void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 135948, 137966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136010, 136059);

                f_1644_136010_136058(!isClosed, "object already disposed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136073, 136122);

                f_1644_136073_136121(f_1644_136073_136095());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136402, 136428);

                f_1644_136402_136427(
                            // Empty the serializedPipeline data that contains PowerShell command information created in the
                            // constructor.  We are connecting to an existing command on the server and don't want to send
                            // information on a new command.
                            serializedPipeline);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136480, 136519);

                _cmdContextId = f_1644_136496_136518();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136533, 136577);

                f_1644_136533_136576(_cmdContextId, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136625, 136732);

                _connectCmdCompleted = f_1644_136648_136731(f_1644_136683_136708(_cmdContextId), s_cmdConnectCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136746, 136857);

                _reconnectCmdCompleted = f_1644_136771_136856(f_1644_136806_136831(_cmdContextId), s_cmdReconnectCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136877, 136887);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 136921, 137125) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 136921, 137125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 137099, 137106);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 136921, 137125);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 137145, 137474);

                    f_1644_137145_137473(_wsManShellOperationHandle, 0, f_1644_137260_137310(f_1644_137260_137280().ToString()), IntPtr.Zero, IntPtr.Zero, _connectCmdCompleted, ref _wsManCmdOperationHandle);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 137505, 137955) || true) && (_wsManCmdOperationHandle == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 137505, 137955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 137582, 137696);

                    PSRemotingTransportException
                    e = f_1644_137615_137695(f_1644_137648_137694())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 137714, 137859);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_137778_137858(e, TransportMethodEnum.ConnectShellCommandEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 137877, 137915);

                    f_1644_137877_137914(this, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 137933, 137940);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 137505, 137955);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 135948, 137966);

                int
                f_1644_136010_136058(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136010, 136058);
                    return 0;
                }


                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1644_136073_136095()
                {
                    var return_v = ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 136073, 136095);
                    return return_v;
                }


                int
                f_1644_136073_136121(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param)
                {
                    this_param.PrepareForStreamConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136073, 136121);
                    return 0;
                }


                byte[]
                f_1644_136402_136427(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136402, 136427);
                    return return_v;
                }


                long
                f_1644_136496_136518()
                {
                    var return_v = GetNextCmdTMHandleId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136496, 136518);
                    return return_v;
                }


                int
                f_1644_136533_136576(long
                cmdTMId, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager)
                {
                    AddCmdTransportManager(cmdTMId, cmdTransportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136533, 136576);
                    return 0;
                }


                System.IntPtr
                f_1644_136683_136708(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136683, 136708);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_136648_136731(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136648, 136731);
                    return return_v;
                }


                System.IntPtr
                f_1644_136806_136831(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136806, 136831);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_136771_136856(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 136771, 136856);
                    return return_v;
                }


                System.Guid
                f_1644_137260_137280()
                {
                    var return_v = PowershellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 137260, 137280);
                    return return_v;
                }


                string
                f_1644_137260_137310(string
                this_param)
                {
                    var return_v = this_param.ToUpperInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 137260, 137310);
                    return return_v;
                }


                int
                f_1644_137145_137473(System.IntPtr
                shellOperationHandle, int
                flags, string
                commandID, System.IntPtr
                optionSet, System.IntPtr
                connectXml, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                commandOperationHandle)
                {
                    WSManNativeApi.WSManConnectShellCommandEx(shellOperationHandle, flags, commandID, optionSet, connectXml, (System.IntPtr)asyncCallback, ref commandOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 137145, 137473);
                    return 0;
                }


                string
                f_1644_137648_137694()
                {
                    var return_v = RemotingErrorIdStrings.RunShellCommandExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 137648, 137694);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_137615_137695(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 137615, 137695);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_137778_137858(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 137778, 137858);
                    return return_v;
                }


                int
                f_1644_137877_137914(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 137877, 137914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 135948, 137966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 135948, 137966);
            }
        }

        internal override void CreateAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 138156, 141341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138217, 138283);

                byte[]
                cmdPart1 = f_1644_138235_138282(serializedPipeline, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138297, 140868) || true) && (cmdPart1 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 138297, 140868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138424, 138449);

                    bool
                    sendContinue = true
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138469, 138769) || true) && (s_commandCodeSendRedirect != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 138469, 138769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138548, 138602);

                        object[]
                        arguments = new object[2] { null, cmdPart1 }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138624, 138696);

                        sendContinue = (bool)f_1644_138645_138695(s_commandCodeSendRedirect, arguments);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138718, 138750);

                        cmdPart1 = (byte[])arguments[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 138469, 138769);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138789, 138836) || true) && (!sendContinue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 138789, 138836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138829, 138836);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 138789, 138836);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 138886, 138977);

                    WSManNativeApi.WSManCommandArgSet
                    argSet = f_1644_138929_138976(cmdPart1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139037, 139076);

                    _cmdContextId = f_1644_139053_139075();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139094, 139138);

                    f_1644_139094_139137(_cmdContextId, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139158, 139448);

                    f_1644_139158_139447(PSEventId.WSManCreateCommand, PSOpcode.Connect, PSTask.CreateRunspace, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_139380_139402().ToString(), powershellInstanceId.ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139468, 139573);

                    _createCmdCompleted = f_1644_139490_139572(f_1644_139525_139550(_cmdContextId), s_cmdCreateCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139591, 139657);

                    _createCmdCompletedGCHandle = GCHandle.Alloc(_createCmdCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139675, 139786);

                    _reconnectCmdCompleted = f_1644_139700_139785(f_1644_139735_139760(_cmdContextId), s_cmdReconnectCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139806, 140853);
                    using (argSet)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139867, 139877);
                        lock (syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139927, 140811) || true) && (!isClosed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 139927, 140811);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 139998, 140629);

                                f_1644_139998_140628(_wsManShellOperationHandle, 0, f_1644_140133_140183(f_1644_140133_140153().ToString()), (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 140308, 140350) || ((                                // WSManRunsShellCommand doesn't accept empty string "".
                                                                (_cmdLine == null || (DynAbs.Tracing.TraceSender.Expression_False(1644, 140309, 140349) || f_1644_140329_140344(_cmdLine) == 0)) && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 140353, 140356)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 140359, 140423))) ? " " : ((DynAbs.Tracing.TraceSender.Conditional_F1(1644, 140360, 140382) || ((f_1644_140360_140375(_cmdLine) <= 256 && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 140385, 140393)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 140396, 140422))) ? _cmdLine : f_1644_140396_140422(_cmdLine, 0, 255)), argSet, IntPtr.Zero, _createCmdCompleted, ref _wsManCmdOperationHandle);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 140661, 140784);

                                f_1644_140661_140783(
                                                            tracer, "Started cmd with command context : {0} Operation context: {1}", _cmdContextId, _wsManCmdOperationHandle);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 139927, 140811);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 139806, 140853);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 138297, 140868);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 140884, 141330) || true) && (_wsManCmdOperationHandle == IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 140884, 141330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 140961, 141075);

                    PSRemotingTransportException
                    e = f_1644_140994_141074(f_1644_141027_141073())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141093, 141234);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_141157_141233(e, TransportMethodEnum.RunShellCommandEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141252, 141290);

                    f_1644_141252_141289(this, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141308, 141315);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 140884, 141330);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 138156, 141341);

                byte[]
                f_1644_138235_138282(System.Management.Automation.Remoting.SerializedDataStream
                this_param, System.Management.Automation.Remoting.SerializedDataStream.OnDataAvailableCallback
                callback)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 138235, 138282);
                    return return_v;
                }


                object?
                f_1644_138645_138695(System.Delegate
                this_param, params object[]
                args)
                {
                    var return_v = this_param.DynamicInvoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 138645, 138695);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet
                f_1644_138929_138976(byte[]
                firstArgument)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet(firstArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 138929, 138976);
                    return return_v;
                }


                long
                f_1644_139053_139075()
                {
                    var return_v = GetNextCmdTMHandleId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139053, 139075);
                    return return_v;
                }


                int
                f_1644_139094_139137(long
                cmdTMId, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager)
                {
                    AddCmdTransportManager(cmdTMId, cmdTransportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139094, 139137);
                    return 0;
                }


                System.Guid
                f_1644_139380_139402()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 139380, 139402);
                    return return_v;
                }


                int
                f_1644_139158_139447(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139158, 139447);
                    return 0;
                }


                System.IntPtr
                f_1644_139525_139550(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139525, 139550);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_139490_139572(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139490, 139572);
                    return return_v;
                }


                System.IntPtr
                f_1644_139735_139760(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139735, 139760);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_139700_139785(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139700, 139785);
                    return return_v;
                }


                System.Guid
                f_1644_140133_140153()
                {
                    var return_v = PowershellInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 140133, 140153);
                    return return_v;
                }


                string
                f_1644_140133_140183(string
                this_param)
                {
                    var return_v = this_param.ToUpperInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 140133, 140183);
                    return return_v;
                }


                int
                f_1644_140329_140344(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 140329, 140344);
                    return return_v;
                }


                int
                f_1644_140360_140375(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 140360, 140375);
                    return return_v;
                }


                string
                f_1644_140396_140422(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 140396, 140422);
                    return return_v;
                }


                int
                f_1644_139998_140628(System.IntPtr
                shellOperationHandle, int
                flags, string
                commandId, string
                commandLine, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet
                commandArgSet, System.IntPtr
                optionSet, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                commandOperationHandle)
                {
                    WSManNativeApi.WSManRunShellCommandEx(shellOperationHandle, flags, commandId, commandLine, (System.IntPtr)commandArgSet, optionSet, (System.IntPtr)asyncCallback, ref commandOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 139998, 140628);
                    return 0;
                }


                int
                f_1644_140661_140783(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, System.IntPtr
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 140661, 140783);
                    return 0;
                }


                string
                f_1644_141027_141073()
                {
                    var return_v = RemotingErrorIdStrings.RunShellCommandExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 141027, 141073);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_140994_141074(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 140994, 141074);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_141157_141233(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 141157, 141233);
                    return return_v;
                }


                int
                f_1644_141252_141289(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 141252, 141289);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 138156, 141341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 138156, 141341);
            }
        }

        internal override void ReconnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 141460, 141860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141524, 141573);

                f_1644_141524_141572(f_1644_141524_141546());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141593, 141603);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141637, 141717) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 141637, 141717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141691, 141698);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 141637, 141717);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 141737, 141834);

                    f_1644_141737_141833(_wsManCmdOperationHandle, 0, _reconnectCmdCompleted);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 141460, 141860);

                System.Management.Automation.Remoting.PriorityReceiveDataCollection
                f_1644_141524_141546()
                {
                    var return_v = ReceivedDataCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 141524, 141546);
                    return return_v;
                }


                int
                f_1644_141524_141572(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param)
                {
                    this_param.PrepareForStreamConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 141524, 141572);
                    return 0;
                }


                int
                f_1644_141737_141833(System.IntPtr
                wsManCommandHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback)
                {
                    WSManNativeApi.WSManReconnectShellCommandEx(wsManCommandHandle, flags, (System.IntPtr)asyncCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 141737, 141833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 141460, 141860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 141460, 141860);
            }
        }

        internal override void SendStopSignal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 142004, 143502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142074, 142084);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142118, 142206) || true) && (isClosed == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 142118, 142206);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142180, 142187);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 142118, 142206);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142458, 142606) || true) && (!_isCreateCallbackReceived)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 142458, 142606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142530, 142558);

                        _isStopSignalPending = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142580, 142587);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 142458, 142606);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142697, 142726);

                    _isStopSignalPending = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142746, 142875);

                    f_1644_142746_142874(
                                    tracer, "Sending stop signal with command context: {0} Operation Context {1}", _cmdContextId, _wsManCmdOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 142893, 143157);

                    f_1644_142893_143156(PSEventId.WSManSignal, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_143077_143099().ToString(), powershellInstanceId.ToString(), StopSignal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 143177, 143282);

                    _signalCmdCompleted = f_1644_143199_143281(f_1644_143234_143259(_cmdContextId), s_cmdSignalCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 143300, 143476);

                    f_1644_143300_143475(_wsManShellOperationHandle, _wsManCmdOperationHandle, 0, StopSignal, _signalCmdCompleted, ref _cmdSignalOperationHandle);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 142004, 143502);

                int
                f_1644_142746_142874(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, System.IntPtr
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 142746, 142874);
                    return 0;
                }


                System.Guid
                f_1644_143077_143099()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 143077, 143099);
                    return return_v;
                }


                int
                f_1644_142893_143156(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 142893, 143156);
                    return 0;
                }


                System.IntPtr
                f_1644_143234_143259(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 143234, 143259);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_143199_143281(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 143199, 143281);
                    return return_v;
                }


                int
                f_1644_143300_143475(System.IntPtr
                shellOperationHandle, System.IntPtr
                cmdOperationHandle, int
                flags, string
                code, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                signalOperationHandle)
                {
                    WSManNativeApi.WSManSignalShellEx(shellOperationHandle, cmdOperationHandle, flags, code, (System.IntPtr)asyncCallback, ref signalOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 143300, 143475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 142004, 143502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 142004, 143502);
            }
        }

        internal override void CloseAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 143681, 145581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 143741, 143866);

                f_1644_143741_143865(tracer, "Closing command with command context: {0} Operation Context {1}", _cmdContextId, _wsManCmdOperationHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 143882, 143921);

                bool
                shouldRaiseCloseCompleted = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144034, 144044);
                // then let other threads release the lock before we cleaning up the resources.
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144078, 144166) || true) && (isClosed == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 144078, 144166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144140, 144147);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 144078, 144166);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144298, 144314);

                    isClosed = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144445, 144582) || true) && (IntPtr.Zero == _wsManCmdOperationHandle)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 144445, 144582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144530, 144563);

                        shouldRaiseCloseCompleted = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 144445, 144582);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144613, 144631);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CloseAsync(), 1644, 144613, 144630);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144647, 144963) || true) && (shouldRaiseCloseCompleted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 144647, 144963);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144754, 144776);

                        f_1644_144754_144775(this);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1644, 144813, 144921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144861, 144902);

                        f_1644_144861_144901(_cmdContextId);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1644, 144813, 144921);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144941, 144948);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 144647, 144963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 144979, 145229);

                f_1644_144979_145228(PSEventId.WSManCloseCommand, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_145161_145183().ToString(), powershellInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 145243, 145346);

                _closeCmdCompleted = f_1644_145264_145345(f_1644_145299_145324(_cmdContextId), s_cmdCloseCallback);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 145360, 145474);

                f_1644_145360_145473((IntPtr)_closeCmdCompleted != IntPtr.Zero, "closeCmdCompleted callback is null in cmdTM.CloseAsync()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 145488, 145570);

                f_1644_145488_145569(_wsManCmdOperationHandle, 0, _closeCmdCompleted);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 143681, 145581);

                int
                f_1644_143741_143865(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, System.IntPtr
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 143741, 143865);
                    return 0;
                }


                int
                f_1644_144754_144775(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 144754, 144775);
                    return 0;
                }


                int
                f_1644_144861_144901(long
                cmdTMId)
                {
                    RemoveCmdTransportManager(cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 144861, 144901);
                    return 0;
                }


                System.Guid
                f_1644_145161_145183()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 145161, 145183);
                    return return_v;
                }


                int
                f_1644_144979_145228(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 144979, 145228);
                    return 0;
                }


                System.IntPtr
                f_1644_145299_145324(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 145299, 145324);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_145264_145345(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 145264, 145345);
                    return return_v;
                }


                int
                f_1644_145360_145473(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 145360, 145473);
                    return 0;
                }


                int
                f_1644_145488_145569(System.IntPtr
                cmdHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback)
                {
                    WSManNativeApi.WSManCloseCommand(cmdHandle, flags, (System.IntPtr)asyncCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 145488, 145569);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 143681, 145581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 143681, 145581);
            }
        }

        internal void ProcessWSManTransportError(TransportErrorOccuredEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 145877, 146050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 145984, 146039);

                f_1644_145984_146038(this, null, eventArgs, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 145877, 146050);

                int
                f_1644_145984_146038(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, object
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 145984, 146038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 145877, 146050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 145877, 146050);
            }
        }

        internal override void RaiseErrorHandler(TransportErrorOccuredEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 146237, 147877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 146390, 146408);

                string
                stackTrace
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 146422, 146931) || true) && (!f_1644_146427_146479(f_1644_146448_146478(f_1644_146448_146467(eventArgs))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 146422, 146931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 146513, 146557);

                    stackTrace = f_1644_146526_146556(f_1644_146526_146545(eventArgs));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 146422, 146931);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 146422, 146931);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 146591, 146931) || true) && (f_1644_146595_146629(f_1644_146595_146614(eventArgs)) != null && (DynAbs.Tracing.TraceSender.Expression_True(1644, 146595, 146731) && !f_1644_146664_146731(f_1644_146685_146730(f_1644_146685_146719(f_1644_146685_146704(eventArgs))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 146591, 146931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 146765, 146824);

                        stackTrace = f_1644_146778_146823(f_1644_146778_146812(f_1644_146778_146797(eventArgs)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 146591, 146931);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 146591, 146931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 146890, 146916);

                        stackTrace = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 146591, 146931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 146422, 146931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 146947, 147361);

                f_1644_146947_147360(PSEventId.TransportError, PSOpcode.Open, PSTask.None, PSKeyword.UseAlwaysOperational, f_1644_147114_147136().ToString(), powershellInstanceId.ToString(), f_1644_147216_147284(f_1644_147216_147245(f_1644_147216_147235(eventArgs)), f_1644_147255_147283()), f_1644_147303_147330(f_1644_147303_147322(eventArgs)), stackTrace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 147377, 147816);

                f_1644_147377_147815(PSEventId.TransportError_Analytic, PSOpcode.Open, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_147569_147591().ToString(), powershellInstanceId.ToString(), f_1644_147671_147739(f_1644_147671_147700(f_1644_147671_147690(eventArgs)), f_1644_147710_147738()), f_1644_147758_147785(f_1644_147758_147777(eventArgs)), stackTrace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 147832, 147866);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RaiseErrorHandler(eventArgs), 1644, 147832, 147865);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 146237, 147877);

                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_146448_146467(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146448, 146467);
                    return return_v;
                }


                string
                f_1644_146448_146478(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146448, 146478);
                    return return_v;
                }


                bool
                f_1644_146427_146479(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 146427, 146479);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_146526_146545(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146526, 146545);
                    return return_v;
                }


                string
                f_1644_146526_146556(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146526, 146556);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_146595_146614(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146595, 146614);
                    return return_v;
                }


                System.Exception
                f_1644_146595_146629(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146595, 146629);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_146685_146704(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146685, 146704);
                    return return_v;
                }


                System.Exception
                f_1644_146685_146719(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146685, 146719);
                    return return_v;
                }


                string
                f_1644_146685_146730(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146685, 146730);
                    return return_v;
                }


                bool
                f_1644_146664_146731(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 146664, 146731);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_146778_146797(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146778, 146797);
                    return return_v;
                }


                System.Exception
                f_1644_146778_146812(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146778, 146812);
                    return return_v;
                }


                string
                f_1644_146778_146823(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 146778, 146823);
                    return return_v;
                }


                System.Guid
                f_1644_147114_147136()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147114, 147136);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_147216_147235(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147216, 147235);
                    return return_v;
                }


                int
                f_1644_147216_147245(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147216, 147245);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_147255_147283()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147255, 147283);
                    return return_v;
                }


                string
                f_1644_147216_147284(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 147216, 147284);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_147303_147322(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147303, 147322);
                    return return_v;
                }


                string
                f_1644_147303_147330(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147303, 147330);
                    return return_v;
                }


                int
                f_1644_146947_147360(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 146947, 147360);
                    return 0;
                }


                System.Guid
                f_1644_147569_147591()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147569, 147591);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_147671_147690(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147671, 147690);
                    return return_v;
                }


                int
                f_1644_147671_147700(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147671, 147700);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_147710_147738()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147710, 147738);
                    return return_v;
                }


                string
                f_1644_147671_147739(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 147671, 147739);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_147758_147777(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147758, 147777);
                    return return_v;
                }


                string
                f_1644_147758_147785(System.Management.Automation.Remoting.PSRemotingTransportException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 147758, 147785);
                    return return_v;
                }


                int
                f_1644_147377_147815(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 147377, 147815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 146237, 147877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 146237, 147877);
            }
        }

        internal override void ProcessPrivateData(object privateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 148278, 148706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 148364, 148427);

                f_1644_148364_148426(privateData != null, "privateData cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 148522, 148574);

                bool
                shouldRaiseSignalCompleted = (bool)privateData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 148588, 148695) || true) && (shouldRaiseSignalCompleted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 148588, 148695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 148652, 148680);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RaiseSignalCompleted(), 1644, 148652, 148679);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 148588, 148695);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 148278, 148706);

                int
                f_1644_148364_148426(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 148364, 148426);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 148278, 148706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 148278, 148706);
            }
        }

        internal void ClearReceiveOrSendResources(int flags, bool shouldClearSend)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 149194, 150621);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149293, 150610) || true) && (shouldClearSend)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 149293, 150610);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149346, 149526) || true) && (_sendToRemoteCompleted != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 149346, 149526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149422, 149455);

                        f_1644_149422_149454(_sendToRemoteCompleted);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149477, 149507);

                        _sendToRemoteCompleted = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 149346, 149526);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149589, 149821) || true) && (IntPtr.Zero != _wsManSendOperationHandle)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 149589, 149821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149675, 149740);

                        f_1644_149675_149739(_wsManSendOperationHandle, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149762, 149802);

                        _wsManSendOperationHandle = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 149589, 149821);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 149293, 150610);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 149293, 150610);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 149978, 150595) || true) && (flags == (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_CALLBACK_END_OF_OPERATION)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 149978, 150595);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 150108, 150365) || true) && (IntPtr.Zero != _wsManReceiveOperationHandle)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 150108, 150365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 150205, 150273);

                            f_1644_150205_150272(_wsManReceiveOperationHandle, 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 150299, 150342);

                            _wsManReceiveOperationHandle = IntPtr.Zero;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 150108, 150365);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 150389, 150576) || true) && (_receivedFromRemote != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 150389, 150576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 150470, 150500);

                            f_1644_150470_150499(_receivedFromRemote);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 150526, 150553);

                            _receivedFromRemote = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 150389, 150576);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 149978, 150595);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 149293, 150610);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 149194, 150621);

                int
                f_1644_149422_149454(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 149422, 149454);
                    return 0;
                }


                int
                f_1644_149675_149739(System.IntPtr
                operationHandle, int
                flags)
                {
                    WSManNativeApi.WSManCloseOperation(operationHandle, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 149675, 149739);
                    return 0;
                }


                int
                f_1644_150205_150272(System.IntPtr
                operationHandle, int
                flags)
                {
                    WSManNativeApi.WSManCloseOperation(operationHandle, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 150205, 150272);
                    return 0;
                }


                int
                f_1644_150470_150499(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 150470, 150499);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 149194, 150621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 149194, 150621);
            }
        }

        internal override void PrepareForDisconnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 150754, 151381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 150824, 150852);

                _isDisconnectPending = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 151108, 151370) || true) && (this.isClosed || (DynAbs.Tracing.TraceSender.Expression_False(1644, 151112, 151152) || _isDisconnectedOnInvoke) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 151112, 151295) || (_isCreateCallbackReceived && (DynAbs.Tracing.TraceSender.Expression_True(1644, 151174, 151256) && f_1644_151221_151251(this.serializedPipeline) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 151174, 151294) && !_isSendingInput))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 151108, 151370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 151329, 151355);

                    f_1644_151329_151354(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 151108, 151370);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 150754, 151381);

                long
                f_1644_151221_151251(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 151221, 151251);
                    return return_v;
                }


                int
                f_1644_151329_151354(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 151329, 151354);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 150754, 151381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 150754, 151381);
            }
        }

        internal override void PrepareForConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 151498, 151605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 151565, 151594);

                _isDisconnectPending = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 151498, 151605);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 151498, 151605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 151498, 151605);
            }
        }

        private static void OnCreateCmdCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 151754, 156263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152044, 152103);

                f_1644_152044_152102(tracer, "OnCreateCmdCompleted callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152119, 152141);

                long
                cmdContextId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152155, 152203);

                WSManClientCommandTransportManager
                cmdTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152217, 152557) || true) && (!f_1644_152222_152294(operationContext, out cmdTM, out cmdContextId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 152217, 152557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152397, 152517);

                    f_1644_152397_152516(                // We dont have the command TM handle..just return.
                                    tracer, "OnCreateCmdCompleted: Unable to find a transport manager for the command context {0}.", cmdContextId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152535, 152542);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 152217, 152557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152573, 152849);

                f_1644_152573_152848(PSEventId.WSManCreateCommandCallbackReceived, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, cmdTM.RunspacePoolInstanceId.ToString(), cmdTM.powershellInstanceId.ToString());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 152944, 153176) || true) && (cmdTM._createCmdCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 152944, 153176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153015, 153056);

                    cmdTM._createCmdCompletedGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153074, 153110);

                    f_1644_153074_153109(cmdTM._createCmdCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153128, 153161);

                    cmdTM._createCmdCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 152944, 153176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153637, 153693);

                cmdTM._wsManCmdOperationHandle = commandOperationHandle;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153709, 154711) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 153709, 154711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153767, 153850);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153868, 154696) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 153868, 154696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 153940, 154045);

                        f_1644_153940_154044(tracer, "OnCreateCmdCompleted callback: WSMan reported an error: {0}", errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 154069, 154580);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_154112_154579(f_1644_154198_154240(f_1644_154198_154225(cmdTM._sessnTm)), null, errorStruct, TransportMethodEnum.RunShellCommandEx, f_1644_154400_154453(), new object[] { f_1644_154496_154576(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 154602, 154646);

                        f_1644_154602_154645(cmdTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 154670, 154677);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 153868, 154696);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 153709, 154711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 154791, 154807);

                // Send remaining cmd / parameter fragments.
                lock (cmdTM.syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 154841, 154880);

                    cmdTM._isCreateCallbackReceived = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 154963, 155313) || true) && (cmdTM.isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 154963, 155313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155023, 155104);

                        f_1644_155023_155103(tracer, "Client Session TM: Transport manager is closed. So returning");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155128, 155263) || true) && (cmdTM._isDisconnectPending)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 155128, 155263);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155208, 155240);

                            f_1644_155208_155239(cmdTM);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 155128, 155263);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155287, 155294);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 154963, 155313);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155506, 155658) || true) && (cmdTM._isDisconnectPending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 155506, 155658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155578, 155610);

                        f_1644_155578_155609(cmdTM);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155632, 155639);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 155506, 155658);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155678, 155818) || true) && (f_1644_155682_155713(cmdTM.serializedPipeline) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 155678, 155818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155760, 155799);

                        cmdTM._shouldStartReceivingData = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 155678, 155818);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 155923, 155943);

                    f_1644_155923_155942(
                                    // Start sending data if any..and see if we can initiate a receive.
                                    cmdTM);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 156123, 156237) || true) && (cmdTM._isStopSignalPending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 156123, 156237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 156195, 156218);

                        f_1644_156195_156217(cmdTM);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 156123, 156237);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 151754, 156263);

                int
                f_1644_152044_152102(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 152044, 152102);
                    return 0;
                }


                bool
                f_1644_152222_152294(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager, out long
                cmdTMId)
                {
                    var return_v = TryGetCmdTransportManager(operationContext, out cmdTransportManager, out cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 152222, 152294);
                    return return_v;
                }


                int
                f_1644_152397_152516(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 152397, 152516);
                    return 0;
                }


                int
                f_1644_152573_152848(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 152573, 152848);
                    return 0;
                }


                int
                f_1644_153074_153109(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 153074, 153109);
                    return 0;
                }


                int
                f_1644_153940_154044(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 153940, 154044);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_154198_154225(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 154198, 154225);
                    return return_v;
                }


                System.IntPtr
                f_1644_154198_154240(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 154198, 154240);
                    return return_v;
                }


                string
                f_1644_154400_154453()
                {
                    var return_v = RemotingErrorIdStrings.RunShellCommandExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 154400, 154453);
                    return return_v;
                }


                string
                f_1644_154496_154576(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 154496, 154576);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_154112_154579(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 154112, 154579);
                    return return_v;
                }


                int
                f_1644_154602_154645(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 154602, 154645);
                    return 0;
                }


                int
                f_1644_155023_155103(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 155023, 155103);
                    return 0;
                }


                int
                f_1644_155208_155239(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 155208, 155239);
                    return 0;
                }


                int
                f_1644_155578_155609(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 155578, 155609);
                    return 0;
                }


                long
                f_1644_155682_155713(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 155682, 155713);
                    return return_v;
                }


                int
                f_1644_155923_155942(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 155923, 155942);
                    return 0;
                }


                int
                f_1644_156195_156217(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SendStopSignal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 156195, 156217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 151754, 156263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 151754, 156263);
            }
        }

        private static void OnConnectCmdCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 156275, 159896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 156566, 156626);

                f_1644_156566_156625(tracer, "OnConnectCmdCompleted callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 156642, 156664);

                long
                cmdContextId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 156678, 156726);

                WSManClientCommandTransportManager
                cmdTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 156740, 157081) || true) && (!f_1644_156745_156817(operationContext, out cmdTM, out cmdContextId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 156740, 157081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 156920, 157041);

                    f_1644_156920_157040(                // We dont have the command TM handle..just return.
                                    tracer, "OnConnectCmdCompleted: Unable to find a transport manager for the command context {0}.", cmdContextId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157059, 157066);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 156740, 157081);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157176, 157352) || true) && (cmdTM._connectCmdCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 157176, 157352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157248, 157285);

                    f_1644_157248_157284(cmdTM._connectCmdCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157303, 157337);

                    cmdTM._connectCmdCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 157176, 157352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157368, 157424);

                cmdTM._wsManCmdOperationHandle = commandOperationHandle;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157440, 158455) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 157440, 158455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157498, 157581);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157599, 158440) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 157599, 158440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157671, 157777);

                        f_1644_157671_157776(tracer, "OnConnectCmdCompleted callback: WSMan reported an error: {0}", errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 157801, 158324);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_157844_158323(f_1644_157930_157972(f_1644_157930_157957(cmdTM._sessnTm)), null, errorStruct, TransportMethodEnum.ReconnectShellCommandEx, f_1644_158138_158197(), new object[] { f_1644_158240_158320(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158346, 158390);

                        f_1644_158346_158389(cmdTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158414, 158421);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 157599, 158440);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 157440, 158455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158477, 158493);

                lock (cmdTM.syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158600, 159010) || true) && (cmdTM.isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 158600, 159010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158660, 158741);

                        f_1644_158660_158740(tracer, "Client Session TM: Transport manager is closed. So returning");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158825, 158960) || true) && (cmdTM._isDisconnectPending)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 158825, 158960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158905, 158937);

                            f_1644_158905_158936(cmdTM);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 158825, 158960);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 158984, 158991);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 158600, 159010);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159203, 159355) || true) && (cmdTM._isDisconnectPending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 159203, 159355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159275, 159307);

                        f_1644_159275_159306(cmdTM);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159329, 159336);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 159203, 159355);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159417, 159456);

                    cmdTM._isCreateCallbackReceived = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159531, 159645) || true) && (cmdTM._isStopSignalPending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 159531, 159645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159603, 159626);

                        f_1644_159603_159625(cmdTM);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 159531, 159645);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159778, 159798);

                f_1644_159778_159797(
                            // Establish a client data to server callback so that the client can respond to prompts.
                            cmdTM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159814, 159844);

                f_1644_159814_159843(
                            cmdTM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 159858, 159885);

                f_1644_159858_159884(cmdTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 156275, 159896);

                int
                f_1644_156566_156625(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 156566, 156625);
                    return 0;
                }


                bool
                f_1644_156745_156817(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager, out long
                cmdTMId)
                {
                    var return_v = TryGetCmdTransportManager(operationContext, out cmdTransportManager, out cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 156745, 156817);
                    return return_v;
                }


                int
                f_1644_156920_157040(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 156920, 157040);
                    return 0;
                }


                int
                f_1644_157248_157284(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 157248, 157284);
                    return 0;
                }


                int
                f_1644_157671_157776(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 157671, 157776);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_157930_157957(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 157930, 157957);
                    return return_v;
                }


                System.IntPtr
                f_1644_157930_157972(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 157930, 157972);
                    return return_v;
                }


                string
                f_1644_158138_158197()
                {
                    var return_v = RemotingErrorIdStrings.ReconnectShellCommandExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 158138, 158197);
                    return return_v;
                }


                string
                f_1644_158240_158320(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 158240, 158320);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_157844_158323(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 157844, 158323);
                    return return_v;
                }


                int
                f_1644_158346_158389(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 158346, 158389);
                    return 0;
                }


                int
                f_1644_158660_158740(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 158660, 158740);
                    return 0;
                }


                int
                f_1644_158905_158936(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 158905, 158936);
                    return 0;
                }


                int
                f_1644_159275_159306(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 159275, 159306);
                    return 0;
                }


                int
                f_1644_159603_159625(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SendStopSignal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 159603, 159625);
                    return 0;
                }


                int
                f_1644_159778_159797(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 159778, 159797);
                    return 0;
                }


                int
                f_1644_159814_159843(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseConnectCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 159814, 159843);
                    return 0;
                }


                int
                f_1644_159858_159884(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.StartReceivingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 159858, 159884);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 156275, 159896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 156275, 159896);
            }
        }

        private static void OnCloseCmdCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 159908, 161340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160197, 160305);

                f_1644_160197_160304(tracer, "OnCloseCmdCompleted callback received for operation context {0}", commandOperationHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160321, 160343);

                long
                cmdContextId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160357, 160405);

                WSManClientCommandTransportManager
                cmdTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160419, 160758) || true) && (!f_1644_160424_160496(operationContext, out cmdTM, out cmdContextId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 160419, 160758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160599, 160718);

                    f_1644_160599_160717(                // We dont have the command TM handle..just return.
                                    tracer, "OnCloseCmdCompleted: Unable to find a transport manager for the command context {0}.", cmdContextId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160736, 160743);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 160419, 160758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160774, 160866);

                f_1644_160774_160865(
                            tracer, "Close completed callback received for command: {0}", cmdTM._cmdContextId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 160880, 161158);

                f_1644_160880_161157(PSEventId.WSManCloseCommandCallbackReceived, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, cmdTM.RunspacePoolInstanceId.ToString(), cmdTM.powershellInstanceId.ToString());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161174, 161285) || true) && (cmdTM._isDisconnectPending)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 161174, 161285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161238, 161270);

                    f_1644_161238_161269(cmdTM);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 161174, 161285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161301, 161329);

                f_1644_161301_161328(
                            cmdTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 159908, 161340);

                int
                f_1644_160197_160304(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.IntPtr
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 160197, 160304);
                    return 0;
                }


                bool
                f_1644_160424_160496(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager, out long
                cmdTMId)
                {
                    var return_v = TryGetCmdTransportManager(operationContext, out cmdTransportManager, out cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 160424, 160496);
                    return return_v;
                }


                int
                f_1644_160599_160717(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 160599, 160717);
                    return 0;
                }


                int
                f_1644_160774_160865(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 160774, 160865);
                    return 0;
                }


                int
                f_1644_160880_161157(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 160880, 161157);
                    return 0;
                }


                int
                f_1644_161238_161269(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 161238, 161269);
                    return 0;
                }


                int
                f_1644_161301_161328(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseCloseCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 161301, 161328);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 159908, 161340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 159908, 161340);
            }
        }

        private static void OnRemoteCmdSendCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 161352, 165253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161646, 161697);

                f_1644_161646_161696(tracer, "SendComplete callback received");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161713, 161735);

                long
                cmdContextId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161749, 161797);

                WSManClientCommandTransportManager
                cmdTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161811, 162129) || true) && (!f_1644_161816_161888(operationContext, out cmdTM, out cmdContextId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 161811, 162129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 161991, 162089);

                    f_1644_161991_162088(                // We dont have the command TM handle..just return.
                                    tracer, "Unable to find a transport manager for the command context {0}.", cmdContextId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 162107, 162114);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 161811, 162129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 162145, 162175);

                cmdTM._isSendingInput = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 162236, 162515);

                f_1644_162236_162514(PSEventId.WSManSendShellInputExCallbackReceived, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, cmdTM.RunspacePoolInstanceId.ToString(), cmdTM.powershellInstanceId.ToString());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 162531, 163336) || true) && ((!shellOperationHandle.Equals(cmdTM._wsManShellOperationHandle)) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 162535, 162684) || (!commandOperationHandle.Equals(cmdTM._wsManCmdOperationHandle))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 162531, 163336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 162718, 162834);

                    f_1644_162718_162833(tracer, "SendShellInputEx callback: ShellOperationHandles are not the same as the Send is initiated with");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 162966, 163076);

                    PSRemotingTransportException
                    e = f_1644_162999_163075(f_1644_163032_163074())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163094, 163232);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_163158_163231(e, TransportMethodEnum.CommandInputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163250, 163294);

                    f_1644_163250_163293(cmdTM, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163314, 163321);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 162531, 163336);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163406, 163453);

                f_1644_163406_163452(
                            // release the resources related to send
                            cmdTM, flags, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163558, 163876) || true) && (cmdTM.isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 163558, 163876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163610, 163691);

                    f_1644_163610_163690(tracer, "Client Command TM: Transport manager is closed. So returning");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163711, 163834) || true) && (cmdTM._isDisconnectPending)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 163711, 163834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163783, 163815);

                        f_1644_163783_163814(cmdTM);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 163711, 163834);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163854, 163861);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 163558, 163876);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163892, 165157) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 163892, 165157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 163950, 164033);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 164299, 165142) || true) && ((errorStruct.errorCode != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1644, 164303, 164365) && (errorStruct.errorCode != 995)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 164299, 165142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 164407, 164499);

                        f_1644_164407_164498(tracer, "CmdSend callback: WSMan reported an error: {0}", errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 164523, 165026);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_164566_165025(f_1644_164652_164694(f_1644_164652_164679(cmdTM._sessnTm)), null, errorStruct, TransportMethodEnum.CommandInputEx, f_1644_164851_164900(), new object[] { f_1644_164942_165022(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165048, 165092);

                        f_1644_165048_165091(cmdTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165116, 165123);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 164299, 165142);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 163892, 165157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165222, 165242);

                f_1644_165222_165241(
                            // Send the next item, if available
                            cmdTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 161352, 165253);

                int
                f_1644_161646_161696(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 161646, 161696);
                    return 0;
                }


                bool
                f_1644_161816_161888(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager, out long
                cmdTMId)
                {
                    var return_v = TryGetCmdTransportManager(operationContext, out cmdTransportManager, out cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 161816, 161888);
                    return return_v;
                }


                int
                f_1644_161991_162088(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 161991, 162088);
                    return 0;
                }


                int
                f_1644_162236_162514(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 162236, 162514);
                    return 0;
                }


                int
                f_1644_162718_162833(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 162718, 162833);
                    return 0;
                }


                string
                f_1644_163032_163074()
                {
                    var return_v = RemotingErrorIdStrings.CommandSendExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 163032, 163074);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_162999_163075(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 162999, 163075);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_163158_163231(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 163158, 163231);
                    return return_v;
                }


                int
                f_1644_163250_163293(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 163250, 163293);
                    return 0;
                }


                int
                f_1644_163406_163452(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, int
                flags, bool
                shouldClearSend)
                {
                    this_param.ClearReceiveOrSendResources(flags, shouldClearSend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 163406, 163452);
                    return 0;
                }


                int
                f_1644_163610_163690(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 163610, 163690);
                    return 0;
                }


                int
                f_1644_163783_163814(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 163783, 163814);
                    return 0;
                }


                int
                f_1644_164407_164498(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 164407, 164498);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_164652_164679(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 164652, 164679);
                    return return_v;
                }


                System.IntPtr
                f_1644_164652_164694(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 164652, 164694);
                    return return_v;
                }


                string
                f_1644_164851_164900()
                {
                    var return_v = RemotingErrorIdStrings.CommandSendExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 164851, 164900);
                    return return_v;
                }


                string
                f_1644_164942_165022(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 164942, 165022);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_164566_165025(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 164566, 165025);
                    return return_v;
                }


                int
                f_1644_165048_165091(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 165048, 165091);
                    return 0;
                }


                int
                f_1644_165222_165241(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 165222, 165241);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 161352, 165253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 161352, 165253);
            }
        }

        private static void OnRemoteCmdDataReceived(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 165265, 169334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165558, 165616);

                f_1644_165558_165615(tracer, "Remote Command DataReceived callback.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165632, 165654);

                long
                cmdContextId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165668, 165716);

                WSManClientCommandTransportManager
                cmdTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165730, 166054) || true) && (!f_1644_165735_165807(operationContext, out cmdTM, out cmdContextId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 165730, 166054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 165910, 166014);

                    f_1644_165910_166013(                // We dont have the command TM handle..just return.
                                    tracer, "Unable to find a transport manager for the given command context {0}.", cmdContextId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166032, 166039);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 165730, 166054);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166070, 166883) || true) && ((!shellOperationHandle.Equals(cmdTM._wsManShellOperationHandle)) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 166074, 166223) || (!commandOperationHandle.Equals(cmdTM._wsManCmdOperationHandle))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 166070, 166883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166371, 166484);

                    f_1644_166371_166483(                // WSMan returned data from a wrong shell..notify the caller
                                                         // about the same.
                                    tracer, "CmdReceive callback: ShellOperationHandles are not the same as the Receive is initiated with");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166502, 166615);

                    PSRemotingTransportException
                    e = f_1644_166535_166614(f_1644_166568_166613())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166633, 166779);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_166697_166778(e, TransportMethodEnum.ReceiveCommandOutputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166797, 166841);

                    f_1644_166797_166840(cmdTM, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166861, 166868);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 166070, 166883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 166956, 167004);

                f_1644_166956_167003(
                            // release the resources related to receive
                            cmdTM, flags, false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167109, 167282) || true) && (cmdTM.isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 167109, 167282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167161, 167242);

                    f_1644_167161_167241(tracer, "Client Command TM: Transport manager is closed. So returning");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167260, 167267);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 167109, 167282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167298, 168236) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 167298, 168236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167356, 167439);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167457, 168221) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 167457, 168221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167529, 167624);

                        f_1644_167529_167623(tracer, "CmdReceive callback: WSMan reported an error: {0}", errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 167648, 168105);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_167691_168104(f_1644_167777_167819(f_1644_167777_167804(cmdTM._sessnTm)), null, errorStruct, TransportMethodEnum.ReceiveCommandOutputEx, f_1644_167984_168036(), new object[] { errorStruct.errorDetail })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168127, 168171);

                        f_1644_168127_168170(cmdTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168195, 168202);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 167457, 168221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 167298, 168236);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168252, 168521) || true) && (flags == (int)WSManNativeApi.WSManCallbackFlags.WSMAN_FLAG_RECEIVE_DELAY_STREAM_REQUEST_PROCESSED)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 168252, 168521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168387, 168424);

                    cmdTM._isDisconnectedOnInvoke = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168442, 168481);

                    f_1644_168442_168480(cmdTM);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168499, 168506);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 168252, 168521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168537, 168644);

                WSManNativeApi.WSManReceiveDataResult
                dataReceived = f_1644_168590_168643(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168658, 169323) || true) && (dataReceived.data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 168658, 169323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168721, 168791);

                    f_1644_168721_168790(tracer, "Cmd Received Data : {0}", f_1644_168765_168789(dataReceived.data));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 168809, 169229);

                    f_1644_168809_169228(PSEventId.WSManReceiveShellOutputExCallbackReceived, PSOpcode.Receive, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, cmdTM.RunspacePoolInstanceId.ToString(), cmdTM.powershellInstanceId.ToString(), f_1644_169164_169227(f_1644_169164_169188(dataReceived.data), f_1644_169198_169226()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 169247, 169308);

                    f_1644_169247_169307(cmdTM, dataReceived.data, dataReceived.stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 168658, 169323);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 165265, 169334);

                int
                f_1644_165558_165615(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 165558, 165615);
                    return 0;
                }


                bool
                f_1644_165735_165807(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager, out long
                cmdTMId)
                {
                    var return_v = TryGetCmdTransportManager(operationContext, out cmdTransportManager, out cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 165735, 165807);
                    return return_v;
                }


                int
                f_1644_165910_166013(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 165910, 166013);
                    return 0;
                }


                int
                f_1644_166371_166483(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 166371, 166483);
                    return 0;
                }


                string
                f_1644_166568_166613()
                {
                    var return_v = RemotingErrorIdStrings.CommandReceiveExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 166568, 166613);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_166535_166614(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 166535, 166614);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_166697_166778(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 166697, 166778);
                    return return_v;
                }


                int
                f_1644_166797_166840(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 166797, 166840);
                    return 0;
                }


                int
                f_1644_166956_167003(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, int
                flags, bool
                shouldClearSend)
                {
                    this_param.ClearReceiveOrSendResources(flags, shouldClearSend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 166956, 167003);
                    return 0;
                }


                int
                f_1644_167161_167241(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 167161, 167241);
                    return 0;
                }


                int
                f_1644_167529_167623(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 167529, 167623);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_167777_167804(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 167777, 167804);
                    return return_v;
                }


                System.IntPtr
                f_1644_167777_167819(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 167777, 167819);
                    return return_v;
                }


                string
                f_1644_167984_168036()
                {
                    var return_v = RemotingErrorIdStrings.CommandReceiveExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 167984, 168036);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_167691_168104(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 167691, 168104);
                    return return_v;
                }


                int
                f_1644_168127_168170(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 168127, 168170);
                    return 0;
                }


                int
                f_1644_168442_168480(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseDelayStreamProcessedEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 168442, 168480);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManReceiveDataResult
                f_1644_168590_168643(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManReceiveDataResult.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 168590, 168643);
                    return return_v;
                }


                int
                f_1644_168765_168789(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 168765, 168789);
                    return return_v;
                }


                int
                f_1644_168721_168790(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 168721, 168790);
                    return 0;
                }


                int
                f_1644_169164_169188(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 169164, 169188);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_169198_169226()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 169198, 169226);
                    return return_v;
                }


                string
                f_1644_169164_169227(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 169164, 169227);
                    return return_v;
                }


                int
                f_1644_168809_169228(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 168809, 169228);
                    return 0;
                }


                int
                f_1644_169247_169307(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.ProcessRawData(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 169247, 169307);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 165265, 169334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 165265, 169334);
            }
        }

        private static void OnReconnectCmdCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 169346, 172234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 169639, 169661);

                long
                cmdContextId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 169675, 169723);

                WSManClientCommandTransportManager
                cmdTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 169737, 170061) || true) && (!f_1644_169742_169814(operationContext, out cmdTM, out cmdContextId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 169737, 170061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 169917, 170021);

                    f_1644_169917_170020(                // We dont have the command TM handle..just return.
                                    tracer, "Unable to find a transport manager for the given command context {0}.", cmdContextId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170039, 170046);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 169737, 170061);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170077, 170903) || true) && ((!shellOperationHandle.Equals(cmdTM._wsManShellOperationHandle)) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 170081, 170229) || (!commandOperationHandle.Equals(cmdTM._wsManCmdOperationHandle))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 170077, 170903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170377, 170489);

                    f_1644_170377_170488(                // WSMan returned data from a wrong shell..notify the caller
                                                         // about the same.
                                    tracer, "Cmd Signal callback: ShellOperationHandles are not the same as the signal is initiated with");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170507, 170634);

                    PSRemotingTransportException
                    e = f_1644_170540_170633(f_1644_170573_170632())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170652, 170799);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_170716_170798(e, TransportMethodEnum.ReconnectShellCommandEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170817, 170861);

                    f_1644_170817_170860(cmdTM, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170881, 170888);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 170077, 170903);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170919, 171936) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 170919, 171936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 170977, 171060);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 171078, 171921) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 171078, 171921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 171150, 171258);

                        f_1644_171150_171257(tracer, "OnReconnectCmdCompleted callback: WSMan reported an error: {0}", errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 171282, 171805);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_171325_171804(f_1644_171411_171453(f_1644_171411_171438(cmdTM._sessnTm)), null, errorStruct, TransportMethodEnum.ReconnectShellCommandEx, f_1644_171619_171678(), new object[] { f_1644_171721_171801(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 171827, 171871);

                        f_1644_171827_171870(cmdTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 171895, 171902);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 171078, 171921);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 170919, 171936);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172102, 172141);

                cmdTM._shouldStartReceivingData = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172155, 172175);

                f_1644_172155_172174(cmdTM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172191, 172223);

                f_1644_172191_172222(
                            cmdTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 169346, 172234);

                bool
                f_1644_169742_169814(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager, out long
                cmdTMId)
                {
                    var return_v = TryGetCmdTransportManager(operationContext, out cmdTransportManager, out cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 169742, 169814);
                    return return_v;
                }


                int
                f_1644_169917_170020(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 169917, 170020);
                    return 0;
                }


                int
                f_1644_170377_170488(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 170377, 170488);
                    return 0;
                }


                string
                f_1644_170573_170632()
                {
                    var return_v = RemotingErrorIdStrings.ReconnectShellCommandExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 170573, 170632);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_170540_170633(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 170540, 170633);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_170716_170798(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 170716, 170798);
                    return return_v;
                }


                int
                f_1644_170817_170860(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 170817, 170860);
                    return 0;
                }


                int
                f_1644_171150_171257(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 171150, 171257);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_171411_171438(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 171411, 171438);
                    return return_v;
                }


                System.IntPtr
                f_1644_171411_171453(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 171411, 171453);
                    return return_v;
                }


                string
                f_1644_171619_171678()
                {
                    var return_v = RemotingErrorIdStrings.ReconnectShellCommandExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 171619, 171678);
                    return return_v;
                }


                string
                f_1644_171721_171801(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 171721, 171801);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_171325_171804(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 171325, 171804);
                    return return_v;
                }


                int
                f_1644_171827_171870(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 171827, 171870);
                    return 0;
                }


                int
                f_1644_172155_172174(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 172155, 172174);
                    return 0;
                }


                int
                f_1644_172191_172222(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReconnectCompleted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 172191, 172222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 169346, 172234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 169346, 172234);
            }
        }

        private static void OnRemoteCmdSignalCompleted(IntPtr operationContext,
                    int flags,
                    IntPtr error,
                    IntPtr shellOperationHandle,
                    IntPtr commandOperationHandle,
                    IntPtr operationHandle,
                    IntPtr data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 172246, 176044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172542, 172598);

                f_1644_172542_172597(tracer, "Signal Completed callback received.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172614, 172636);

                long
                cmdContextId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172650, 172698);

                WSManClientCommandTransportManager
                cmdTM = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172712, 173036) || true) && (!f_1644_172717_172789(operationContext, out cmdTM, out cmdContextId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 172712, 173036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 172892, 172996);

                    f_1644_172892_172995(                // We dont have the command TM handle..just return.
                                    tracer, "Unable to find a transport manager for the given command context {0}.", cmdContextId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 173014, 173021);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 172712, 173036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 173101, 173373);

                f_1644_173101_173372(PSEventId.WSManSignalCallbackReceived, PSOpcode.Disconnect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, cmdTM.RunspacePoolInstanceId.ToString(), cmdTM.powershellInstanceId.ToString());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 173389, 174190) || true) && ((!shellOperationHandle.Equals(cmdTM._wsManShellOperationHandle)) || (DynAbs.Tracing.TraceSender.Expression_False(1644, 173393, 173542) || (!commandOperationHandle.Equals(cmdTM._wsManCmdOperationHandle))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 173389, 174190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 173690, 173802);

                    f_1644_173690_173801(                // WSMan returned data from a wrong shell..notify the caller
                                                         // about the same.
                                    tracer, "Cmd Signal callback: ShellOperationHandles are not the same as the signal is initiated with");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 173820, 173930);

                    PSRemotingTransportException
                    e = f_1644_173853_173929(f_1644_173886_173928())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 173948, 174086);

                    TransportErrorOccuredEventArgs
                    eventargs =
                    f_1644_174012_174085(e, TransportMethodEnum.CommandInputEx)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174104, 174148);

                    f_1644_174104_174147(cmdTM, eventargs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174168, 174175);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 173389, 174190);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174262, 174496) || true) && (IntPtr.Zero != cmdTM._cmdSignalOperationHandle)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 174262, 174496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174346, 174417);

                    f_1644_174346_174416(cmdTM._cmdSignalOperationHandle, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174435, 174481);

                    cmdTM._cmdSignalOperationHandle = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 174262, 174496);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174512, 174685) || true) && (cmdTM._signalCmdCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 174512, 174685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174583, 174619);

                    f_1644_174583_174618(cmdTM._signalCmdCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174637, 174670);

                    cmdTM._signalCmdCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 174512, 174685);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174790, 174963) || true) && (cmdTM.isClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 174790, 174963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174842, 174923);

                    f_1644_174842_174922(tracer, "Client Command TM: Transport manager is closed. So returning");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174941, 174948);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 174790, 174963);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 174979, 175961) || true) && (IntPtr.Zero != error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 174979, 175961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 175037, 175120);

                    WSManNativeApi.WSManError
                    errorStruct = WSManNativeApi.WSManError.UnMarshal(error)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 175138, 175946) || true) && (errorStruct.errorCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 175138, 175946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 175210, 175305);

                        f_1644_175210_175304(tracer, "Cmd Signal callback: WSMan reported an error: {0}", errorStruct.errorDetail);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 175329, 175832);

                        TransportErrorOccuredEventArgs
                        eventargs = f_1644_175372_175831(f_1644_175458_175500(f_1644_175458_175485(cmdTM._sessnTm)), null, errorStruct, TransportMethodEnum.CommandInputEx, f_1644_175657_175706(), new object[] { f_1644_175748_175828(errorStruct.errorDetail) })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 175854, 175898);

                        f_1644_175854_175897(cmdTM, eventargs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 175920, 175927);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 175138, 175946);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 174979, 175961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 175977, 176033);

                f_1644_175977_176032(
                            cmdTM, null, null, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 172246, 176044);

                int
                f_1644_172542_172597(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 172542, 172597);
                    return 0;
                }


                bool
                f_1644_172717_172789(System.IntPtr
                operationContext, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                cmdTransportManager, out long
                cmdTMId)
                {
                    var return_v = TryGetCmdTransportManager(operationContext, out cmdTransportManager, out cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 172717, 172789);
                    return return_v;
                }


                int
                f_1644_172892_172995(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 172892, 172995);
                    return 0;
                }


                int
                f_1644_173101_173372(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 173101, 173372);
                    return 0;
                }


                int
                f_1644_173690_173801(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 173690, 173801);
                    return 0;
                }


                string
                f_1644_173886_173928()
                {
                    var return_v = RemotingErrorIdStrings.CommandSendExFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 173886, 173928);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1644_173853_173929(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 173853, 173929);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_174012_174085(System.Management.Automation.Remoting.PSRemotingTransportException
                e, System.Management.Automation.Remoting.TransportMethodEnum
                m)
                {
                    var return_v = new System.Management.Automation.Remoting.TransportErrorOccuredEventArgs(e, m);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 174012, 174085);
                    return return_v;
                }


                int
                f_1644_174104_174147(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 174104, 174147);
                    return 0;
                }


                int
                f_1644_174346_174416(System.IntPtr
                operationHandle, int
                flags)
                {
                    WSManNativeApi.WSManCloseOperation(operationHandle, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 174346, 174416);
                    return 0;
                }


                int
                f_1644_174583_174618(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 174583, 174618);
                    return 0;
                }


                int
                f_1644_174842_174922(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 174842, 174922);
                    return 0;
                }


                int
                f_1644_175210_175304(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 175210, 175304);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_175458_175485(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 175458, 175485);
                    return return_v;
                }


                System.IntPtr
                f_1644_175458_175500(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.WSManAPIHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 175458, 175500);
                    return return_v;
                }


                string
                f_1644_175657_175706()
                {
                    var return_v = RemotingErrorIdStrings.CommandSendExCallBackError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 175657, 175706);
                    return return_v;
                }


                string
                f_1644_175748_175828(string
                errorMessage)
                {
                    var return_v = WSManTransportManagerUtils.ParseEscapeWSManErrorMessage(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 175748, 175828);
                    return return_v;
                }


                System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                f_1644_175372_175831(System.IntPtr
                wsmanAPIHandle, System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                wsmanSessionTM, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManError
                errorStruct, System.Management.Automation.Remoting.TransportMethodEnum
                transportMethodReportingError, string
                resourceString, params object[]
                resourceArgs)
                {
                    var return_v = WSManTransportManagerUtils.ConstructTransportErrorEventArgs(wsmanAPIHandle, wsmanSessionTM, errorStruct, transportMethodReportingError, resourceString, resourceArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 175372, 175831);
                    return return_v;
                }


                int
                f_1644_175854_175897(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                eventArgs)
                {
                    this_param.ProcessWSManTransportError(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 175854, 175897);
                    return 0;
                }


                int
                f_1644_175977_176032(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                remoteObject, System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
                transportErrorArgs, bool
                privateData)
                {
                    this_param.EnqueueAndStartProcessingThread(remoteObject, transportErrorArgs, (object)privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 175977, 176032);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 172246, 176044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 172246, 176044);
            }
        }

        private void SendOneItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 176056, 177984);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 176242, 176366) || true) && (_isDisconnectPending)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 176242, 176366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 176300, 176326);

                    f_1644_176300_176325(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 176344, 176351);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 176242, 176366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 176382, 176401);

                byte[]
                data = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 176415, 176472);

                DataPriorityType
                priorityType = DataPriorityType.Default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 176701, 177707) || true) && (f_1644_176705_176730(serializedPipeline) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 176701, 177707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 176768, 176823);

                    data = f_1644_176775_176822(serializedPipeline, null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177069, 177197) || true) && (f_1644_177073_177098(serializedPipeline) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 177069, 177197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177145, 177178);

                        _shouldStartReceivingData = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 177069, 177197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 176701, 177707);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 176701, 177707);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177231, 177707) || true) && (_chunkToSend != null)
                    ) // there is a pending chunk to be sent

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 177231, 177707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177328, 177353);

                        data = f_1644_177335_177352(_chunkToSend);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177371, 177404);

                        priorityType = f_1644_177386_177403(_chunkToSend);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177422, 177442);

                        _chunkToSend = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 177231, 177707);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 177231, 177707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177599, 177692);

                        data = f_1644_177606_177691(dataToBeSent, _onDataAvailableToSendCallback, out priorityType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 177231, 177707);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 176701, 177707);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177723, 177858) || true) && (data != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 177723, 177858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177773, 177796);

                    _isSendingInput = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177814, 177843);

                    f_1644_177814_177842(this, data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 177723, 177858);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177874, 177973) || true) && (_shouldStartReceivingData)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 177874, 177973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 177937, 177958);

                    f_1644_177937_177957(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 177874, 177973);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 176056, 177984);

                int
                f_1644_176300_176325(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.RaiseReadyForDisconnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 176300, 176325);
                    return 0;
                }


                long
                f_1644_176705_176730(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 176705, 176730);
                    return return_v;
                }


                byte[]
                f_1644_176775_176822(System.Management.Automation.Remoting.SerializedDataStream
                this_param, System.Management.Automation.Remoting.SerializedDataStream.OnDataAvailableCallback
                callback)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 176775, 176822);
                    return return_v;
                }


                long
                f_1644_177073_177098(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 177073, 177098);
                    return return_v;
                }


                byte[]
                f_1644_177335_177352(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager.SendDataChunk
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 177335, 177352);
                    return return_v;
                }


                System.Management.Automation.Remoting.DataPriorityType
                f_1644_177386_177403(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager.SendDataChunk
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 177386, 177403);
                    return return_v;
                }


                byte[]
                f_1644_177606_177691(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 177606, 177691);
                    return return_v;
                }


                int
                f_1644_177814_177842(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.SendData(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 177814, 177842);
                    return 0;
                }


                int
                f_1644_177937_177957(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.StartReceivingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 177937, 177957);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 176056, 177984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 176056, 177984);
            }
        }

        private void OnDataAvailableCallback(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 177996, 178470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178101, 178180);

                f_1644_178101_178179(data != null, "data cannot be null in the data available callback");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178196, 178255);

                f_1644_178196_178254(
                            tracer, "Received data from dataToBeSent store.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178269, 178364);

                f_1644_178269_178363(_chunkToSend == null, "data callback received while a chunk is pending to be sent");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178378, 178431);

                _chunkToSend = f_1644_178393_178430(data, priorityType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178445, 178459);

                f_1644_178445_178458(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 177996, 178470);

                int
                f_1644_178101_178179(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 178101, 178179);
                    return 0;
                }


                int
                f_1644_178196_178254(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 178196, 178254);
                    return 0;
                }


                int
                f_1644_178269_178363(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 178269, 178363);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager.SendDataChunk
                f_1644_178393_178430(byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                type)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager.SendDataChunk(data, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 178393, 178430);
                    return return_v;
                }


                int
                f_1644_178445_178458(System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                this_param)
                {
                    this_param.SendOneItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 178445, 178458);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 177996, 178470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 177996, 178470);
            }
        }

        private static Delegate s_commandSendRedirect;

        private void SendData(byte[] data, DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 178638, 180886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178728, 178796);

                f_1644_178728_178795(tracer, "Command sending data of size : {0}", f_1644_178783_178794(data));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178810, 178832);

                byte[]
                package = data
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178917, 178942);

                bool
                sendContinue = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 178958, 179228) || true) && (s_commandSendRedirect != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 178958, 179228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179025, 179078);

                    object[]
                    arguments = new object[2] { null, package }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179096, 179164);

                    sendContinue = (bool)f_1644_179117_179163(s_commandSendRedirect, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179182, 179213);

                    package = (byte[])arguments[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 178958, 179228);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179244, 179287) || true) && (!sendContinue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 179244, 179287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179280, 179287);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 179244, 179287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179329, 180875);
                using (WSManNativeApi.WSManData_ManToUn
                serializedContent =
                f_1644_179415_179460(package)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179494, 179885);

                    f_1644_179494_179884(PSEventId.WSManSendShellInputEx, PSOpcode.Send, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_179704_179726().ToString(), powershellInstanceId.ToString(), f_1644_179814_179883(f_1644_179814_179844(serializedContent), f_1644_179854_179882()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 179911, 179921);

                    lock (syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 180026, 180225) || true) && (isClosed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 180026, 180225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 180088, 180169);

                            f_1644_180088_180168(tracer, "Client Session TM: Transport manager is closed. So returning");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 180195, 180202);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 180026, 180225);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 180287, 180393);

                        _sendToRemoteCompleted = f_1644_180312_180392(f_1644_180347_180372(_cmdContextId), s_cmdSendCallback);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 180415, 180841);

                        f_1644_180415_180840(_wsManShellOperationHandle, _wsManCmdOperationHandle, 0, (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 180534, 180574) || ((priorityType == DataPriorityType.Default && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 180606, 180642)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 180645, 180690))) ? WSManNativeApi.WSMAN_STREAM_ID_STDIN : WSManNativeApi.WSMAN_STREAM_ID_PROMPTRESPONSE, serializedContent, _sendToRemoteCompleted, ref _wsManSendOperationHandle);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1644, 179329, 180875);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 178638, 180886);

                int
                f_1644_178783_178794(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 178783, 178794);
                    return return_v;
                }


                int
                f_1644_178728_178795(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 178728, 178795);
                    return 0;
                }


                object?
                f_1644_179117_179163(System.Delegate
                this_param, params object[]
                args)
                {
                    var return_v = this_param.DynamicInvoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 179117, 179163);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                f_1644_179415_179460(byte[]
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 179415, 179460);
                    return return_v;
                }


                System.Guid
                f_1644_179704_179726()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 179704, 179726);
                    return return_v;
                }


                int
                f_1644_179814_179844(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                this_param)
                {
                    var return_v = this_param.BufferLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 179814, 179844);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1644_179854_179882()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 179854, 179882);
                    return return_v;
                }


                string
                f_1644_179814_179883(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 179814, 179883);
                    return return_v;
                }


                int
                f_1644_179494_179884(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 179494, 179884);
                    return 0;
                }


                int
                f_1644_180088_180168(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 180088, 180168);
                    return 0;
                }


                System.IntPtr
                f_1644_180347_180372(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 180347, 180372);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_180312_180392(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 180312, 180392);
                    return return_v;
                }


                int
                f_1644_180415_180840(System.IntPtr
                shellOperationHandle, System.IntPtr
                commandOperationHandle, int
                flags, string
                streamId, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_ManToUn
                streamData, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                sendOperationHandle)
                {
                    WSManNativeApi.WSManSendShellInputEx(shellOperationHandle, commandOperationHandle, flags, streamId, streamData, (System.IntPtr)asyncCallback, ref sendOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 180415, 180840);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 178638, 180886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 178638, 180886);
            }
        }

        internal override void StartReceivingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 180898, 182497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 180966, 181229);

                f_1644_180966_181228(PSEventId.WSManReceiveShellOutputEx, PSOpcode.Receive, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, f_1644_181161_181183().ToString(), powershellInstanceId.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181339, 181373);

                _shouldStartReceivingData = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181393, 181403);
                lock (syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181496, 181679) || true) && (isClosed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 181496, 181679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181550, 181631);

                        f_1644_181550_181630(tracer, "Client Session TM: Transport manager is closed. So returning");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181653, 181660);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 181496, 181679);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181699, 181889) || true) && (receiveDataInitiated)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 181699, 181889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181765, 181841);

                        f_1644_181765_181840(tracer, "Client Session TM: ReceiveData has already been called.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181863, 181870);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 181699, 181889);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181909, 181937);

                    receiveDataInitiated = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 181992, 182098);

                    _receivedFromRemote = f_1644_182014_182097(f_1644_182049_182074(_cmdContextId), s_cmdReceiveCallback);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 182116, 182471);

                    f_1644_182116_182470(_wsManShellOperationHandle, _wsManCmdOperationHandle, (DynAbs.Tracing.TraceSender.Conditional_F1(1644, 182232, 182255) || ((startInDisconnectedMode && DynAbs.Tracing.TraceSender.Conditional_F2(1644, 182258, 182331)) || DynAbs.Tracing.TraceSender.Conditional_F3(1644, 182334, 182335))) ? (int)WSManNativeApi.WSManShellFlag.WSMAN_FLAG_RECEIVE_DELAY_OUTPUT_STREAM : 0, f_1644_182357_182394(f_1644_182357_182378(_sessnTm)), _receivedFromRemote, ref _wsManReceiveOperationHandle);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 180898, 182497);

                System.Guid
                f_1644_181161_181183()
                {
                    var return_v = RunspacePoolInstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 181161, 181183);
                    return return_v;
                }


                int
                f_1644_180966_181228(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 180966, 181228);
                    return 0;
                }


                int
                f_1644_181550_181630(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 181550, 181630);
                    return 0;
                }


                int
                f_1644_181765_181840(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 181765, 181840);
                    return 0;
                }


                System.IntPtr
                f_1644_182049_182074(long
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 182049, 182074);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                f_1644_182014_182097(System.IntPtr
                context, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
                callback)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync(context, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 182014, 182097);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                f_1644_182357_182378(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.WSManAPIData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 182357, 182378);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                f_1644_182357_182394(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager.WSManAPIDataCommon
                this_param)
                {
                    var return_v = this_param.OutputStreamSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 182357, 182394);
                    return return_v;
                }


                int
                f_1644_182116_182470(System.IntPtr
                shellOperationHandle, System.IntPtr
                commandOperationHandle, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_ManToUn
                desiredStreamSet, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                asyncCallback, ref System.IntPtr
                receiveOperationHandle)
                {
                    WSManNativeApi.WSManReceiveShellOutputEx(shellOperationHandle, commandOperationHandle, flags, (System.IntPtr)desiredStreamSet, (System.IntPtr)asyncCallback, ref receiveOperationHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 182116, 182470);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 180898, 182497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 180898, 182497);
            }
        }

        internal override void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1644, 182579, 183646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 182652, 182780);

                f_1644_182652_182779(tracer, "Disposing command with command context: {0} Operation Context: {1}", _cmdContextId, _wsManCmdOperationHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 182794, 182820);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(isDisposing), 1644, 182794, 182819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 182903, 182944);

                f_1644_182903_182943(_cmdContextId);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183002, 183232) || true) && (_sessnTm != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 183002, 183232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183056, 183128);

                    _sessnTm.RobustConnectionsInitiated -= HandleRobustConnectionsInitiated;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183146, 183217);

                    _sessnTm.RobustConnectionsCompleted -= HandleRobusConnectionsCompleted;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 183002, 183232);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183248, 183400) || true) && (_closeCmdCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 183248, 183400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183312, 183341);

                    f_1644_183312_183340(_closeCmdCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183359, 183385);

                    _closeCmdCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 183248, 183400);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183416, 183580) || true) && (_reconnectCmdCompleted != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1644, 183416, 183580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183484, 183517);

                    f_1644_183484_183516(_reconnectCmdCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183535, 183565);

                    _reconnectCmdCompleted = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1644, 183416, 183580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 183596, 183635);

                _wsManCmdOperationHandle = IntPtr.Zero;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1644, 182579, 183646);

                int
                f_1644_182652_182779(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, System.IntPtr
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 182652, 182779);
                    return 0;
                }


                int
                f_1644_182903_182943(long
                cmdTMId)
                {
                    RemoveCmdTransportManager(cmdTMId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 182903, 182943);
                    return 0;
                }


                int
                f_1644_183312_183340(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 183312, 183340);
                    return 0;
                }


                int
                f_1644_183484_183516(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsync
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 183484, 183516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 182579, 183646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 182579, 183646);
            }
        }

        private static Dictionary<long, WSManClientCommandTransportManager> s_cmdTMHandles;

        private static long s_cmdTMSeed;

        private static long GetNextCmdTMHandleId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 184108, 184249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 184175, 184238);

                return f_1644_184182_184237(ref s_cmdTMSeed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 184108, 184249);

                long
                f_1644_184182_184237(ref long
                location)
                {
                    var return_v = System.Threading.Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 184182, 184237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 184108, 184249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 184108, 184249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddCmdTransportManager(long cmdTMId,
                    WSManClientCommandTransportManager cmdTransportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 184383, 184662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 184539, 184553);
                lock (s_cmdTMHandles)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 184587, 184636);

                    f_1644_184587_184635(s_cmdTMHandles, cmdTMId, cmdTransportManager);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 184383, 184662);

                int
                f_1644_184587_184635(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager>
                this_param, long
                key, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 184587, 184635);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 184383, 184662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 184383, 184662);
            }
        }

        private static void RemoveCmdTransportManager(long cmdTMId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 184674, 184869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 184764, 184778);
                lock (s_cmdTMHandles)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 184812, 184843);

                    f_1644_184812_184842(s_cmdTMHandles, cmdTMId);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 184674, 184869);

                bool
                f_1644_184812_184842(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager>
                this_param, long
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 184812, 184842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 184674, 184869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 184674, 184869);
            }
        }

        private static bool TryGetCmdTransportManager(IntPtr operationContext,
                    out WSManClientCommandTransportManager cmdTransportManager,
                    out long cmdTMId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1644, 185003, 185442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 185202, 185239);

                cmdTMId = operationContext.ToInt64();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 185253, 185280);

                cmdTransportManager = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 185300, 185314);
                lock (s_cmdTMHandles)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1644, 185348, 185416);

                    return f_1644_185355_185415(s_cmdTMHandles, cmdTMId, out cmdTransportManager);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1644, 185003, 185442);

                bool
                f_1644_185355_185415(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager>
                this_param, long
                key, out System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 185355, 185415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1644, 185003, 185442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1644, 185003, 185442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1644, 127221, 185471);

        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_131169_131227(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 131169, 131227);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_131425_131482(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 131425, 131482);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_131688_131747(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 131688, 131747);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_131948_132004(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 131948, 132004);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_132211_132269(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 132211, 132269);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_132479_132540(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 132479, 132540);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback
        f_1644_132744_132803(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellCompletionFunction
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellAsyncCallback(callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 132744, 132803);
            return return_v;
        }


        static System.Management.Automation.Internal.PSRemotingCryptoHelper
        f_1644_134068_134088(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
        this_param)
        {
            var return_v = this_param.CryptoHelper;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134068, 134088);
            return return_v;
        }


        static int
        f_1644_134123_134224(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 134123, 134224);
            return 0;
        }


        static int
        f_1644_134239_134306(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 134239, 134306);
            return 0;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1644_134464_134486()
        {
            var return_v = ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134464, 134486);
            return return_v;
        }


        static int?
        f_1644_134513_134561(System.Management.Automation.Runspaces.WSManConnectionInfo
        this_param)
        {
            var return_v = this_param.MaximumReceivedDataSizePerCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134513, 134561);
            return return_v;
        }


        System.Management.Automation.Remoting.PriorityReceiveDataCollection
        f_1644_134576_134598()
        {
            var return_v = ReceivedDataCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134576, 134598);
            return return_v;
        }


        static int?
        f_1644_134627_134667(System.Management.Automation.Runspaces.WSManConnectionInfo
        this_param)
        {
            var return_v = this_param.MaximumReceivedObjectSize;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134627, 134667);
            return return_v;
        }


        static System.Management.Automation.PowerShell
        f_1644_134693_134709(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        this_param)
        {
            var return_v = this_param.PowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134693, 134709);
            return return_v;
        }


        static System.Management.Automation.PSCommand
        f_1644_134693_134718(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.Commands;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134693, 134718);
            return return_v;
        }


        static System.Management.Automation.Runspaces.CommandCollection
        f_1644_134693_134727(System.Management.Automation.PSCommand
        this_param)
        {
            var return_v = this_param.Commands;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1644, 134693, 134727);
            return return_v;
        }


        static string
        f_1644_134693_134756(System.Management.Automation.Runspaces.CommandCollection
        this_param)
        {
            var return_v = this_param.GetCommandStringForHistory();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 134693, 134756);
            return return_v;
        }


        static System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        f_1644_134061_134066_C(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1644, 133787, 135253);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager>
        f_1644_183938_183996()
        {
            var return_v = new System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.Client.WSManClientCommandTransportManager>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1644, 183938, 183996);
            return return_v;
        }

    }
}
