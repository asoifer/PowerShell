// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ----------------------------------------------------------------------
//  Contents:  Entry points for managed PowerShell plugin worker used to
//  host powershell in a WSMan service.
// ----------------------------------------------------------------------

using System.Threading;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Remoting.WSMan;
using System.Management.Automation.Tracing;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal static class WSManPluginConstants
    {
        internal const int
        ExitCodeSuccess = 0x00000000
        ;

        internal const int
        ExitCodeFailure = 0x00000001
        ;

        internal const string
        CtrlCSignal = "powershell/signal/crtl_c"
        ;

        internal const string
        SupportedInputStream = "stdin"
        ;

        internal const string
        SupportedOutputStream = "stdout"
        ;

        internal const string
        SupportedPromptResponseStream = "pr"
        ;

        internal const string
        PowerShellStartupProtocolVersionName = "protocolversion"
        ;

        internal const string
        PowerShellStartupProtocolVersionValue = "2.0"
        ;

        internal const string
        PowerShellOptionPrefix = "PS_"
        ;

        internal const int
        WSManPluginParamsGetRequestedLocale = 5
        ;

        internal const int
        WSManPluginParamsGetRequestedDataLocale = 6
        ;

        static WSManPluginConstants()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1640, 1018, 2021);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1096, 1124);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1154, 1182);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1217, 1257);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1475, 1505);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1538, 1570);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1603, 1639);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1672, 1728);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1761, 1806);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1839, 1869);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1901, 1940);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 1970, 2013);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1640, 1018, 2021);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 1018, 2021);
        }

    }

    /// <summary>
    /// Definitions of HRESULT error codes that are passed to the client.
    /// 0x8054.... means that it is a PowerShell HRESULT. The PowerShell facility
    /// is 84 (0x54).
    /// </summary>
    internal enum WSManPluginErrorCodes : int
    {
        NullPluginContext = -2141976624, // 0x805407D0
        PluginContextNotFound = -2141976623, // 0x805407D1

        NullInvalidInput = -2141975624, // 0x80540BB8
        NullInvalidStreamSets = -2141975623, // 0x80540BB9
        SessionCreationFailed = -2141975622, // 0x80540BBA
        NullShellContext = -2141975621, // 0x80540BBB
        InvalidShellContext = -2141975620, // 0x80540BBC
        InvalidCommandContext = -2141975619, // 0x80540BBD
        InvalidInputStream = -2141975618, // 0x80540BBE
        InvalidInputDatatype = -2141975617, // 0x80540BBF
        InvalidOutputStream = -2141975616, // 0x80540BC0
        InvalidSenderDetails = -2141975615, // 0x80540BC1
        ShutdownRegistrationFailed = -2141975614, // 0x80540BC2
        ReportContextFailed = -2141975613, // 0x80540BC3
        InvalidArgSet = -2141975612, // 0x80540BC4
        ProtocolVersionNotMatch = -2141975611, // 0x80540BC5
        OptionNotUnderstood = -2141975610, // 0x80540BC6
        ProtocolVersionNotFound = -2141975609, // 0x80540BC7

        ManagedException = -2141974624, // 0x80540FA0
        PluginOperationClose = -2141974623, // 0x80540FA1
        PluginConnectNoNegotiationData = -2141974622, // 0x80540FA2
        PluginConnectOperationFailed = -2141974621, // 0x80540FA3

        NoError = 0,
        OutOfMemory = -2147024882  // 0x8007000E
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal class WSManPluginOperationShutdownContext // TODO: Rename to OperationShutdownContext when removing the MC++ module.
    {
        internal IntPtr pluginContext;

        internal IntPtr shellContext;

        internal IntPtr commandContext;

        internal bool isReceiveOperation;

        internal bool isShuttingDown;

        internal WSManPluginOperationShutdownContext(
                    IntPtr plgContext,
                    IntPtr shContext,
                    IntPtr cmdContext,
                    bool isRcvOp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1640, 4483, 4874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 4359, 4377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 4402, 4416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 4675, 4702);

                pluginContext = plgContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 4716, 4741);

                shellContext = shContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 4755, 4783);

                commandContext = cmdContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 4797, 4826);

                isReceiveOperation = isRcvOp;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 4840, 4863);

                isShuttingDown = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1640, 4483, 4874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 4483, 4874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 4483, 4874);
            }
        }

        static WSManPluginOperationShutdownContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1640, 3977, 4903);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1640, 3977, 4903);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 3977, 4903);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1640, 3977, 4903);
    }
    internal class WSManPluginInstance
    {
        private Dictionary<IntPtr, WSManPluginShellSession> _activeShellSessions;

        private object _syncObject;

        private static Dictionary<IntPtr, WSManPluginInstance> s_activePlugins;

        internal static IWSManNativeApiFacade wsmanPinvokeStatic;

        internal WSManPluginInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1640, 5964, 6144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 5230, 5250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 5276, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 6019, 6092);

                _activeShellSessions = f_1640_6042_6091();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 6106, 6133);

                _syncObject = f_1640_6120_6132();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1640, 5964, 6144);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 5964, 6144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 5964, 6144);
            }
        }

        static WSManPluginInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1640, 6419, 6949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 5353, 5416);
                s_activePlugins = f_1640_5371_5416();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 5836, 5883);
                wsmanPinvokeStatic = f_1640_5857_5883();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 43607, 43665);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1640, 6419, 6949);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 6419, 6949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 6419, 6949);
            }
        }

        internal void CreateShell(
                    IntPtr pluginContext,
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    string extraInfo,
                    WSManNativeApi.WSManShellStartupInfo_UnToMan startupInfo,
                    WSManNativeApi.WSManData_UnToMan inboundShellInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 7382, 20508);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 7728, 8507) || true) && (requestDetails == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 7728, 8507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 7893, 8467);

                    f_1640_7893_8466(PSEventId.ReportOperationComplete, PSOpcode.Close, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, "null", f_1640_8138_8224(WSManPluginErrorCodes.NullInvalidInput, f_1640_8195_8223()), f_1640_8247_8430(f_1640_8291_8341(), "requestDetails", "WSManPluginShell"), string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 8485, 8492);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 7728, 8507);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 8523, 9027) || true) && ((requestDetails.senderDetails == null) || (DynAbs.Tracing.TraceSender.Expression_False(1640, 8527, 8624) || (requestDetails.operationInfo == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 8523, 9027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 8658, 8987);

                    f_1640_8658_8986(requestDetails, WSManPluginErrorCodes.NullInvalidInput, f_1640_8802_8985(f_1640_8846_8896(), "requestDetails", "WSManPluginShell"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 9005, 9012);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 8523, 9027);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 9043, 9466) || true) && (startupInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 9043, 9466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 9100, 9426);

                    f_1640_9100_9425(requestDetails, WSManPluginErrorCodes.NullInvalidInput, f_1640_9244_9424(f_1640_9288_9338(), "startupInfo", "WSManPluginShell"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 9444, 9451);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 9043, 9466);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 9482, 10048) || true) && ((0 == startupInfo.inputStreamSet.streamIDsCount) || (DynAbs.Tracing.TraceSender.Expression_False(1640, 9486, 9587) || (0 == startupInfo.outputStreamSet.streamIDsCount)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 9482, 10048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 9621, 10008);

                    f_1640_9621_10007(requestDetails, WSManPluginErrorCodes.NullInvalidStreamSets, f_1640_9770_10006(f_1640_9814_9868(), WSManPluginConstants.SupportedInputStream, WSManPluginConstants.SupportedOutputStream));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10026, 10033);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 9482, 10048);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10064, 10497) || true) && (f_1640_10068_10099(extraInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 10064, 10497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10133, 10457);

                    f_1640_10133_10456(requestDetails, WSManPluginErrorCodes.NullInvalidInput, f_1640_10277_10455(f_1640_10321_10371(), "extraInfo", "WSManPluginShell"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10475, 10482);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 10064, 10497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10513, 10569);

                f_1640_10513_10568(requestDetails);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10644, 10740) || true) && (!f_1640_10649_10684(this, requestDetails))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 10644, 10740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10718, 10725);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 10644, 10740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10756, 10806);

                int
                result = WSManPluginConstants.ExitCodeSuccess
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10820, 10860);

                WSManPluginShellSession
                mgdShellSession
                = default(WSManPluginShellSession);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10874, 10918);

                WSManPluginOperationShutdownContext
                context
                = default(WSManPluginOperationShutdownContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 10932, 10962);

                byte[]
                convertedBase64 = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 11014, 11086);

                    PSSenderInfo
                    senderInfo = f_1640_11040_11085(this, requestDetails.senderDetails)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 11240, 11293);

                    WSManPluginServerTransportManager
                    serverTransportMgr
                    = default(WSManPluginServerTransportManager);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 11313, 11722) || true) && (f_1640_11317_11335())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 11313, 11722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 11377, 11514);

                        serverTransportMgr = f_1640_11398_11513(BaseTransportManager.DefaultFragmentSize, f_1640_11478_11512());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 11313, 11722);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 11313, 11722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 11596, 11703);

                        serverTransportMgr = f_1640_11617_11702(BaseTransportManager.DefaultFragmentSize, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 11313, 11722);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 11742, 12052);

                    f_1640_11742_12051(PSEventId.ServerCreateRemoteSession, PSOpcode.Connect, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, f_1640_11962_11987(requestDetails), f_1640_11989_12022(f_1640_11989_12017(f_1640_11989_12008(senderInfo))), requestDetails.resourceUri);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12070, 12291);

                    ServerRemoteSession
                    remoteShellSession = f_1640_12111_12290(senderInfo, requestDetails.resourceUri, extraInfo, serverTransportMgr)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12311, 12592) || true) && (remoteShellSession == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 12311, 12592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12383, 12544);

                        f_1640_12383_12543(requestDetails, WSManPluginErrorCodes.SessionCreationFailed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12566, 12573);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 12311, 12592);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12612, 12729);

                    context = f_1640_12622_12728(pluginContext, requestDetails.unmanagedHandle, IntPtr.Zero, false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12747, 12931) || true) && (context == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 12747, 12931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12808, 12883);

                        f_1640_12808_12882(requestDetails, WSManPluginErrorCodes.OutOfMemory);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 12905, 12912);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 12747, 12931);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 13044, 13155);

                    mgdShellSession = f_1640_13062_13154(requestDetails, serverTransportMgr, remoteShellSession, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 13173, 13215);

                    f_1640_13173_13214(this, mgdShellSession);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 13233, 13320);

                    mgdShellSession.SessionClosed += new EventHandler<EventArgs>(HandleShellSessionClosed);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 13340, 14404) || true) && (inboundShellInformation != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 13340, 14404);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 13417, 14385) || true) && ((uint)WSManNativeApi.WSManDataType.WSMAN_DATA_TYPE_TEXT != f_1640_13480_13508(inboundShellInformation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 13417, 14385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 13614, 13952);

                            f_1640_13614_13951(requestDetails, WSManPluginErrorCodes.InvalidInputDatatype, f_1640_13786_13950(f_1640_13838_13892(), "WSMAN_DATA_TYPE_TEXT"));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 13978, 14040);

                            f_1640_13978_14039(this, requestDetails.unmanagedHandle);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 14066, 14073);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 13417, 14385);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 13417, 14385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 14171, 14362);

                            convertedBase64 = f_1640_14189_14361(f_1640_14267_14295(inboundShellInformation), WSManNativeApi.PS_CREATION_XML_TAG);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 13417, 14385);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 13340, 14404);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 14483, 14745);

                    f_1640_14483_14744(PSEventId.ReportContext, PSOpcode.Connect, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, f_1640_14691_14716(requestDetails), f_1640_14718_14743(requestDetails));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 14763, 14883);

                    result = f_1640_14772_14882(wsmanPinvokeStatic, requestDetails.unmanagedHandle, 0, requestDetails.unmanagedHandle);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 14903, 15394) || true) && (WSManPluginConstants.ExitCodeSuccess != result)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 14903, 15394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 14995, 15262);

                        f_1640_14995_15261(requestDetails, WSManPluginErrorCodes.ReportContextFailed, f_1640_15154_15260(f_1640_15206_15259()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 15284, 15346);

                        f_1640_15284_15345(this, requestDetails.unmanagedHandle);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 15368, 15375);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 14903, 15394);
                    }
                }
                catch (System.Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1640, 15423, 16252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 15482, 15835);

                    f_1640_15482_15834(PSEventId.TransportError, PSOpcode.Connect, PSTask.None, PSKeyword.UseAlwaysOperational, "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", f_1640_15722_15808(WSManPluginErrorCodes.ManagedException, f_1640_15779_15807()), f_1640_15810_15819(e), f_1640_15821_15833(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 15855, 15917);

                    f_1640_15855_15916(this, requestDetails.unmanagedHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 15935, 16212);

                    f_1640_15935_16211(requestDetails, WSManPluginErrorCodes.ManagedException, f_1640_16079_16210(f_1640_16123_16173(), f_1640_16200_16209(e)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 16230, 16237);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1640, 15423, 16252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 16268, 16319);

                bool
                isRegisterWaitForSingleObjectSucceeded = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 16503, 16534);

                // always synchronize calls to OperationComplete once notification handle is registered.. else duplicate OperationComplete calls are bound to happen
                lock (mgdShellSession.shellSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 16568, 16619);

                    mgdShellSession.registeredShutdownNotification = 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 16733, 16820);

                    EventWaitHandle
                    eventWaitHandle = f_1640_16767_16819(false, EventResetMode.AutoReset)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 16840, 18051) || true) && (f_1640_16844_16862())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 16840, 18051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 16904, 17005);

                        SafeWaitHandle
                        safeWaitHandle = f_1640_16936_17004(f_1640_16955_16996(requestDetails), false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 17045, 17093);

                        eventWaitHandle.SafeWaitHandle = safeWaitHandle;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 16840, 18051);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 16840, 18051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 17541, 17588);

                        GCHandle
                        gch = GCHandle.Alloc(eventWaitHandle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 17610, 17644);

                        IntPtr
                        p = GCHandle.ToIntPtr(gch)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 17668, 18032);

                        f_1640_17668_18031(
                                            wsmanPinvokeStatic, requestDetails.unmanagedHandle, f_1640_17876_17933(WSManPluginManagedEntryWrapper.workerPtrs).wsManPluginShutdownCallbackNative, p);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 16840, 18051);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 18071, 18467);

                    mgdShellSession.registeredShutDownWaitHandle = f_1640_18118_18466(eventWaitHandle, new WaitOrTimerCallback(WSManPluginManagedEntryWrapper.PSPluginOperationShutdownCallback), context, -1, true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 18570, 18734) || true) && (mgdShellSession.registeredShutDownWaitHandle == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 18570, 18734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 18668, 18715);

                        isRegisterWaitForSingleObjectSucceeded = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 18570, 18734);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 18765, 19189) || true) && (!isRegisterWaitForSingleObjectSucceeded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 18765, 19189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 18842, 18893);

                    mgdShellSession.registeredShutdownNotification = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 18911, 19069);

                    f_1640_18911_19068(requestDetails, WSManPluginErrorCodes.ShutdownRegistrationFailed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 19087, 19149);

                    f_1640_19087_19148(this, requestDetails.unmanagedHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 19167, 19174);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 18765, 19189);
                }

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 19241, 19432) || true) && (convertedBase64 != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 19241, 19432);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 19310, 19413);

                        f_1640_19310_19412(mgdShellSession, convertedBase64, WSManPluginConstants.SupportedInputStream);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 19241, 19432);
                    }
                }
                catch (System.Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1640, 19461, 20474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 19520, 19873);

                    f_1640_19520_19872(PSEventId.TransportError, PSOpcode.Connect, PSTask.None, PSKeyword.UseAlwaysOperational, "00000000-0000-0000-0000-000000000000", "00000000-0000-0000-0000-000000000000", f_1640_19760_19846(WSManPluginErrorCodes.ManagedException, f_1640_19817_19845()), f_1640_19848_19857(e), f_1640_19859_19871(e));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 19893, 20432) || true) && (f_1640_19897_19972(ref mgdShellSession.registeredShutdownNotification, 0) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 19893, 20432);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 20149, 20225);

                        bool
                        ignore = f_1640_20163_20224(mgdShellSession.registeredShutDownWaitHandle, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 20247, 20299);

                        mgdShellSession.registeredShutDownWaitHandle = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 20382, 20413);

                        f_1640_20382_20412(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 19893, 20432);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 20452, 20459);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1640, 19461, 20474);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 20490, 20497);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 7382, 20508);

                System.Globalization.CultureInfo
                f_1640_8195_8223()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 8195, 8223);
                    return return_v;
                }


                string?
                f_1640_8138_8224(System.Management.Automation.Remoting.WSManPluginErrorCodes
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 8138, 8224);
                    return return_v;
                }


                string
                f_1640_8291_8341()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 8291, 8341);
                    return return_v;
                }


                string
                f_1640_8247_8430(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 8247, 8430);
                    return return_v;
                }


                int
                f_1640_7893_8466(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 7893, 8466);
                    return 0;
                }


                string
                f_1640_8846_8896()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 8846, 8896);
                    return return_v;
                }


                string
                f_1640_8802_8985(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 8802, 8985);
                    return return_v;
                }


                int
                f_1640_8658_8986(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 8658, 8986);
                    return 0;
                }


                string
                f_1640_9288_9338()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 9288, 9338);
                    return return_v;
                }


                string
                f_1640_9244_9424(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 9244, 9424);
                    return return_v;
                }


                int
                f_1640_9100_9425(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 9100, 9425);
                    return 0;
                }


                string
                f_1640_9814_9868()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidStreamSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 9814, 9868);
                    return return_v;
                }


                string
                f_1640_9770_10006(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 9770, 10006);
                    return return_v;
                }


                int
                f_1640_9621_10007(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 9621, 10007);
                    return 0;
                }


                bool
                f_1640_10068_10099(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 10068, 10099);
                    return return_v;
                }


                string
                f_1640_10321_10371()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 10321, 10371);
                    return return_v;
                }


                string
                f_1640_10277_10455(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 10277, 10455);
                    return return_v;
                }


                int
                f_1640_10133_10456(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 10133, 10456);
                    return 0;
                }


                int
                f_1640_10513_10568(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    WSManPluginInstance.SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 10513, 10568);
                    return 0;
                }


                bool
                f_1640_10649_10684(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    var return_v = this_param.EnsureOptionsComply(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 10649, 10684);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSSenderInfo
                f_1640_11040_11085(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManSenderDetails
                senderDetails)
                {
                    var return_v = this_param.GetPSSenderInfo(senderDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 11040, 11085);
                    return return_v;
                }


                bool
                f_1640_11317_11335()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 11317, 11335);
                    return return_v;
                }


                System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                f_1640_11478_11512()
                {
                    var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperServer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 11478, 11512);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginServerTransportManager
                f_1640_11398_11513(int
                fragmentSize, System.Management.Automation.Internal.PSRemotingCryptoHelperServer
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginServerTransportManager(fragmentSize, (System.Management.Automation.Internal.PSRemotingCryptoHelper)cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 11398, 11513);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginServerTransportManager
                f_1640_11617_11702(int
                fragmentSize, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginServerTransportManager(fragmentSize, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 11617, 11702);
                    return return_v;
                }


                string?
                f_1640_11962_11987(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 11962, 11987);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1640_11989_12008(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.UserInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 11989, 12008);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSIdentity
                f_1640_11989_12017(System.Management.Automation.Remoting.PSPrincipal
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 11989, 12017);
                    return return_v;
                }


                string
                f_1640_11989_12022(System.Management.Automation.Remoting.PSIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 11989, 12022);
                    return return_v;
                }


                int
                f_1640_11742_12051(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 11742, 12051);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSession
                f_1640_12111_12290(System.Management.Automation.Remoting.PSSenderInfo
                senderInfo, string
                configurationProviderId, string
                initializationParameters, System.Management.Automation.Remoting.WSManPluginServerTransportManager
                transportManager)
                {
                    var return_v = ServerRemoteSession.CreateServerRemoteSession(senderInfo, configurationProviderId, initializationParameters, (System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager)transportManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 12111, 12290);
                    return return_v;
                }


                int
                f_1640_12383_12543(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 12383, 12543);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                f_1640_12622_12728(System.IntPtr
                plgContext, System.IntPtr
                shContext, System.IntPtr
                cmdContext, bool
                isRcvOp)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginOperationShutdownContext(plgContext, shContext, cmdContext, isRcvOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 12622, 12728);
                    return return_v;
                }


                int
                f_1640_12808_12882(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 12808, 12882);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_13062_13154(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                creationRequestDetails, System.Management.Automation.Remoting.WSManPluginServerTransportManager
                transportMgr, System.Management.Automation.Remoting.ServerRemoteSession
                remoteSession, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                shutDownContext)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginShellSession(creationRequestDetails, transportMgr, remoteSession, shutDownContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 13062, 13154);
                    return return_v;
                }


                int
                f_1640_13173_13214(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.WSManPluginShellSession
                newShellSession)
                {
                    this_param.AddToActiveShellSessions(newShellSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 13173, 13214);
                    return 0;
                }


                uint
                f_1640_13480_13508(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 13480, 13508);
                    return return_v;
                }


                string
                f_1640_13838_13892()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidInputDataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 13838, 13892);
                    return return_v;
                }


                string
                f_1640_13786_13950(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 13786, 13950);
                    return return_v;
                }


                int
                f_1640_13614_13951(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 13614, 13951);
                    return 0;
                }


                int
                f_1640_13978_14039(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                keyToDelete)
                {
                    this_param.DeleteFromActiveShellSessions(keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 13978, 14039);
                    return 0;
                }


                string
                f_1640_14267_14295(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 14267, 14295);
                    return return_v;
                }


                byte[]
                f_1640_14189_14361(string
                xmlBuffer, string
                xmlTag)
                {
                    var return_v = ServerOperationHelpers.ExtractEncodedXmlElement(xmlBuffer, xmlTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 14189, 14361);
                    return return_v;
                }


                string?
                f_1640_14691_14716(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 14691, 14716);
                    return return_v;
                }


                string?
                f_1640_14718_14743(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 14718, 14743);
                    return return_v;
                }


                int
                f_1640_14483_14744(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 14483, 14744);
                    return 0;
                }


                int
                f_1640_14772_14882(System.Management.Automation.Remoting.Client.IWSManNativeApiFacade
                this_param, System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                context)
                {
                    var return_v = this_param.WSManPluginReportContext(requestDetails, flags, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 14772, 14882);
                    return return_v;
                }


                string
                f_1640_15206_15259()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginReportContextFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 15206, 15259);
                    return return_v;
                }


                string
                f_1640_15154_15260(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 15154, 15260);
                    return return_v;
                }


                int
                f_1640_14995_15261(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 14995, 15261);
                    return 0;
                }


                int
                f_1640_15284_15345(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                keyToDelete)
                {
                    this_param.DeleteFromActiveShellSessions(keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 15284, 15345);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1640_15779_15807()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 15779, 15807);
                    return return_v;
                }


                string?
                f_1640_15722_15808(System.Management.Automation.Remoting.WSManPluginErrorCodes
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 15722, 15808);
                    return return_v;
                }


                string
                f_1640_15810_15819(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 15810, 15819);
                    return return_v;
                }


                string
                f_1640_15821_15833(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 15821, 15833);
                    return return_v;
                }


                int
                f_1640_15482_15834(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 15482, 15834);
                    return 0;
                }


                int
                f_1640_15855_15916(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                keyToDelete)
                {
                    this_param.DeleteFromActiveShellSessions(keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 15855, 15916);
                    return 0;
                }


                string
                f_1640_16123_16173()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginManagedException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 16123, 16173);
                    return return_v;
                }


                string
                f_1640_16200_16209(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 16200, 16209);
                    return return_v;
                }


                string
                f_1640_16079_16210(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 16079, 16210);
                    return return_v;
                }


                int
                f_1640_15935_16211(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 15935, 16211);
                    return 0;
                }


                System.Threading.EventWaitHandle
                f_1640_16767_16819(bool
                initialState, System.Threading.EventResetMode
                mode)
                {
                    var return_v = new System.Threading.EventWaitHandle(initialState, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 16767, 16819);
                    return return_v;
                }


                bool
                f_1640_16844_16862()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 16844, 16862);
                    return return_v;
                }


                System.IntPtr
                f_1640_16955_16996(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.shutdownNotificationHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 16955, 16996);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeWaitHandle
                f_1640_16936_17004(System.IntPtr
                existingHandle, bool
                ownsHandle)
                {
                    var return_v = new Microsoft.Win32.SafeHandles.SafeWaitHandle(existingHandle, ownsHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 16936, 17004);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginEntryDelegates.WSManPluginEntryDelegatesInternal
                f_1640_17876_17933(System.Management.Automation.Remoting.WSManPluginEntryDelegates
                this_param)
                {
                    var return_v = this_param.UnmanagedStruct;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 17876, 17933);
                    return return_v;
                }


                int
                f_1640_17668_18031(System.Management.Automation.Remoting.Client.IWSManNativeApiFacade
                this_param, System.IntPtr
                requestDetails, System.IntPtr
                shutdownCallback, System.IntPtr
                shutdownContext)
                {
                    this_param.WSManPluginRegisterShutdownCallback(requestDetails, shutdownCallback, shutdownContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 17668, 18031);
                    return 0;
                }


                System.Threading.RegisteredWaitHandle
                f_1640_18118_18466(System.Threading.EventWaitHandle
                waitObject, System.Threading.WaitOrTimerCallback
                callBack, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                state, int
                millisecondsTimeOutInterval, bool
                executeOnlyOnce)
                {
                    var return_v = ThreadPool.RegisterWaitForSingleObject((System.Threading.WaitHandle)waitObject, callBack, (object)state, millisecondsTimeOutInterval, executeOnlyOnce);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 18118, 18466);
                    return return_v;
                }


                int
                f_1640_18911_19068(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    WSManPluginInstance.ReportWSManOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 18911, 19068);
                    return 0;
                }


                int
                f_1640_19087_19148(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                keyToDelete)
                {
                    this_param.DeleteFromActiveShellSessions(keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 19087, 19148);
                    return 0;
                }


                int
                f_1640_19310_19412(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, byte[]
                data, string
                stream)
                {
                    this_param.SendOneItemToSessionHelper(data, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 19310, 19412);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1640_19817_19845()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 19817, 19845);
                    return return_v;
                }


                string?
                f_1640_19760_19846(System.Management.Automation.Remoting.WSManPluginErrorCodes
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 19760, 19846);
                    return return_v;
                }


                string
                f_1640_19848_19857(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 19848, 19857);
                    return return_v;
                }


                string
                f_1640_19859_19871(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 19859, 19871);
                    return return_v;
                }


                int
                f_1640_19520_19872(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 19520, 19872);
                    return 0;
                }


                int
                f_1640_19897_19972(ref int
                location1, int
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 19897, 19972);
                    return return_v;
                }


                bool
                f_1640_20163_20224(System.Threading.RegisteredWaitHandle
                this_param, System.Threading.WaitHandle?
                waitObject)
                {
                    var return_v = this_param.Unregister(waitObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 20163, 20224);
                    return return_v;
                }


                int
                f_1640_20382_20412(System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context)
                {
                    PerformCloseOperation(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 20382, 20412);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 7382, 20508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 7382, 20508);
            }
        }

        internal void CloseShellOperation(
                    WSManPluginOperationShutdownContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 20704, 21993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 20821, 21196);

                f_1640_20821_21195(PSEventId.ServerCloseOperation, PSOpcode.Disconnect, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, ((IntPtr)context.shellContext).ToString(), ((IntPtr)context.commandContext).ToString(), f_1640_21157_21194(context.isReceiveOperation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 21212, 21303);

                WSManPluginShellSession
                mgdShellSession = f_1640_21254_21302(this, context.shellContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 21317, 21557) || true) && (mgdShellSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 21317, 21557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 21535, 21542);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 21317, 21557);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 21659, 21791) || true) && (!context.isReceiveOperation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 21659, 21791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 21724, 21776);

                    f_1640_21724_21775(this, context.shellContext);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 21659, 21791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 21807, 21912);

                System.Exception
                reasonForClose = f_1640_21841_21911(f_1640_21862_21910())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 21926, 21982);

                f_1640_21926_21981(mgdShellSession, context, reasonForClose);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 20704, 21993);

                string
                f_1640_21157_21194(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 21157, 21194);
                    return return_v;
                }


                int
                f_1640_20821_21195(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 20821, 21195);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_21254_21302(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.GetFromActiveShellSessions(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 21254, 21302);
                    return return_v;
                }


                int
                f_1640_21724_21775(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                keyToDelete)
                {
                    this_param.DeleteFromActiveShellSessions(keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 21724, 21775);
                    return 0;
                }


                string
                f_1640_21862_21910()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginOperationClose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 21862, 21910);
                    return return_v;
                }


                System.Exception
                f_1640_21841_21911(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 21841, 21911);
                    return return_v;
                }


                int
                f_1640_21926_21981(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context, System.Exception
                reasonForClose)
                {
                    this_param.CloseOperation(context, reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 21926, 21981);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 20704, 21993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 20704, 21993);
            }
        }

        internal void CloseCommandOperation(
                    WSManPluginOperationShutdownContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 22005, 22906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 22124, 22471);

                f_1640_22124_22470(PSEventId.ServerCloseOperation, PSOpcode.Disconnect, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, context.shellContext.ToString(), context.commandContext.ToString(), f_1640_22432_22469(context.isReceiveOperation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 22487, 22578);

                WSManPluginShellSession
                mgdShellSession = f_1640_22529_22577(this, context.shellContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 22592, 22832) || true) && (mgdShellSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 22592, 22832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 22810, 22817);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 22592, 22832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 22848, 22895);

                f_1640_22848_22894(
                            mgdShellSession, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 22005, 22906);

                string
                f_1640_22432_22469(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 22432, 22469);
                    return return_v;
                }


                int
                f_1640_22124_22470(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 22124, 22470);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_22529_22577(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.GetFromActiveShellSessions(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 22529, 22577);
                    return return_v;
                }


                int
                f_1640_22848_22894(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context)
                {
                    this_param.CloseCommandOperation(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 22848, 22894);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 22005, 22906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 22005, 22906);
            }
        }

        private void AddToActiveShellSessions(
                    WSManPluginShellSession newShellSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 23141, 24041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23258, 23273);

                int
                count = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23293, 23304);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23338, 23406);

                    IntPtr
                    key = newShellSession.creationRequestDetails.unmanagedHandle
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23424, 23494);

                    f_1640_23424_23493(IntPtr.Zero != key, "NULL handles should not be provided");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23514, 23781) || true) && (!f_1640_23519_23556(_activeShellSessions, key))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 23514, 23781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23598, 23645);

                        f_1640_23598_23644(_activeShellSessions, key, newShellSession);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23727, 23762);

                        count = f_1640_23735_23761(_activeShellSessions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 23514, 23781);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23812, 24030) || true) && (-1 != count)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 23812, 24030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 23915, 24015);

                    f_1640_23915_24014(f_1640_23972_24013(count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 23812, 24030);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 23141, 24041);

                int
                f_1640_23424_23493(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 23424, 23493);
                    return 0;
                }


                bool
                f_1640_23519_23556(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 23519, 23556);
                    return return_v;
                }


                int
                f_1640_23598_23644(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
                this_param, System.IntPtr
                key, System.Management.Automation.Remoting.WSManPluginShellSession
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 23598, 23644);
                    return 0;
                }


                int
                f_1640_23735_23761(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 23735, 23761);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs
                f_1640_23972_24013(int
                activeSessionsCount)
                {
                    var return_v = new System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs(activeSessionsCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 23972, 24013);
                    return return_v;
                }


                int
                f_1640_23915_24014(System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs
                eventArgs)
                {
                    WSManServerChannelEvents.RaiseActiveSessionsChangedEvent(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 23915, 24014);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 23141, 24041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 23141, 24041);
            }
        }

        private WSManPluginShellSession GetFromActiveShellSessions(
                    IntPtr key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 24352, 24669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 24467, 24478);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 24512, 24543);

                    WSManPluginShellSession
                    result
                    = default(WSManPluginShellSession);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 24561, 24611);

                    f_1640_24561_24610(_activeShellSessions, key, out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 24629, 24643);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 24352, 24669);

                bool
                f_1640_24561_24610(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
                this_param, System.IntPtr
                key, out System.Management.Automation.Remoting.WSManPluginShellSession
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 24561, 24610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 24352, 24669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 24352, 24669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DeleteFromActiveShellSessions(
                    IntPtr keyToDelete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 24879, 25518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 24980, 24995);

                int
                count = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 25015, 25026);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 25060, 25258) || true) && (f_1640_25064_25104(_activeShellSessions, keyToDelete))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 25060, 25258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 25204, 25239);

                        count = f_1640_25212_25238(_activeShellSessions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 25060, 25258);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 25289, 25507) || true) && (-1 != count)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 25289, 25507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 25392, 25492);

                    f_1640_25392_25491(f_1640_25449_25490(count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 25289, 25507);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 24879, 25518);

                bool
                f_1640_25064_25104(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 25064, 25104);
                    return return_v;
                }


                int
                f_1640_25212_25238(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 25212, 25238);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs
                f_1640_25449_25490(int
                activeSessionsCount)
                {
                    var return_v = new System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs(activeSessionsCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 25449, 25490);
                    return return_v;
                }


                int
                f_1640_25392_25491(System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs
                eventArgs)
                {
                    WSManServerChannelEvents.RaiseActiveSessionsChangedEvent(eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 25392, 25491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 24879, 25518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 24879, 25518);
            }
        }

        private void HandleShellSessionClosed(
                    object source,
                    EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 25731, 25905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 25848, 25894);

                f_1640_25848_25893(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 25731, 25905);

                int
                f_1640_25848_25893(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, object
                keyToDelete)
                {
                    this_param.DeleteFromActiveShellSessions((System.IntPtr)keyToDelete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 25848, 25893);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 25731, 25905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 25731, 25905);
            }
        }

        private bool validateIncomingContexts(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    IntPtr shellContext,
                    string inputFunctionName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 26209, 27684);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 26408, 27192) || true) && (requestDetails == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 26408, 27192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 26573, 27146);

                    f_1640_26573_27145(PSEventId.ReportOperationComplete, PSOpcode.Close, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, "null", f_1640_26818_26904(WSManPluginErrorCodes.NullInvalidInput, f_1640_26875_26903()), f_1640_26927_27109(f_1640_26971_27021(), "requestDetails", inputFunctionName), string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 27164, 27177);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 26408, 27192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 27208, 27645) || true) && (IntPtr.Zero == shellContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 27208, 27645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 27273, 27599);

                    f_1640_27273_27598(requestDetails, WSManPluginErrorCodes.NullShellContext, f_1640_27417_27597(f_1640_27461_27511(), "ShellContext", inputFunctionName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 27617, 27630);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 27208, 27645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 27661, 27673);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 26209, 27684);

                System.Globalization.CultureInfo
                f_1640_26875_26903()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 26875, 26903);
                    return return_v;
                }


                string?
                f_1640_26818_26904(System.Management.Automation.Remoting.WSManPluginErrorCodes
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 26818, 26904);
                    return return_v;
                }


                string
                f_1640_26971_27021()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 26971, 27021);
                    return return_v;
                }


                string
                f_1640_26927_27109(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 26927, 27109);
                    return return_v;
                }


                int
                f_1640_26573_27145(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 26573, 27145);
                    return 0;
                }


                string
                f_1640_27461_27511()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullShellContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 27461, 27511);
                    return return_v;
                }


                string
                f_1640_27417_27597(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 27417, 27597);
                    return return_v;
                }


                int
                f_1640_27273_27598(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 27273, 27598);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 26209, 27684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 26209, 27684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CreateCommand(
                    IntPtr pluginContext,
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    IntPtr shellContext,
                    string commandLine,
                    WSManNativeApi.WSManCommandArgSet arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 28085, 29453);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 28385, 28526) || true) && (!f_1640_28390_28470(this, requestDetails, shellContext, "WSManRunShellCommandEx"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 28385, 28526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 28504, 28511);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 28385, 28526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 28542, 28578);

                f_1640_28542_28577(requestDetails);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 28594, 28873);

                f_1640_28594_28872(PSEventId.ServerCreateCommandSession, PSOpcode.Connect, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, ((IntPtr)shellContext).ToString(), f_1640_28846_28871(requestDetails));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 28889, 28972);

                WSManPluginShellSession
                mgdShellSession = f_1640_28931_28971(this, shellContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 28986, 29334) || true) && (mgdShellSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 28986, 29334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 29047, 29294);

                    f_1640_29047_29293(requestDetails, WSManPluginErrorCodes.InvalidShellContext, f_1640_29194_29292(f_1640_29238_29291()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 29312, 29319);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 28986, 29334);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 29350, 29442);

                f_1640_29350_29441(
                            mgdShellSession, pluginContext, requestDetails, flags, commandLine, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 28085, 29453);

                bool
                f_1640_28390_28470(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.IntPtr
                shellContext, string
                inputFunctionName)
                {
                    var return_v = this_param.validateIncomingContexts(requestDetails, shellContext, inputFunctionName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 28390, 28470);
                    return return_v;
                }


                int
                f_1640_28542_28577(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 28542, 28577);
                    return 0;
                }


                string?
                f_1640_28846_28871(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 28846, 28871);
                    return return_v;
                }


                int
                f_1640_28594_28872(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 28594, 28872);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_28931_28971(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.GetFromActiveShellSessions(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 28931, 28971);
                    return return_v;
                }


                string
                f_1640_29238_29291()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidShellContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 29238, 29291);
                    return return_v;
                }


                string
                f_1640_29194_29292(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 29194, 29292);
                    return return_v;
                }


                int
                f_1640_29047_29293(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 29047, 29293);
                    return 0;
                }


                int
                f_1640_29350_29441(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.IntPtr
                pluginContext, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, string
                commandLine, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet
                arguments)
                {
                    this_param.CreateCommand(pluginContext, requestDetails, flags, commandLine, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 29350, 29441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 28085, 29453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 28085, 29453);
            }
        }

        internal void StopCommand(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    IntPtr shellContext,
                    IntPtr commandContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 29465, 31854);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 29649, 30423) || true) && (requestDetails == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 29649, 30423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 29814, 30383);

                    f_1640_29814_30382(PSEventId.ReportOperationComplete, PSOpcode.Close, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, "null", f_1640_30059_30145(WSManPluginErrorCodes.NullInvalidInput, f_1640_30116_30144()), f_1640_30168_30346(f_1640_30212_30262(), "requestDetails", "StopCommand"), string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 30401, 30408);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 29649, 30423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 30439, 30475);

                f_1640_30439_30474(requestDetails);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 30491, 30847);

                f_1640_30491_30846(PSEventId.ServerStopCommand, PSOpcode.Disconnect, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, ((IntPtr)shellContext).ToString(), ((IntPtr)commandContext).ToString(), f_1640_30820_30845(requestDetails));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 30863, 30946);

                WSManPluginShellSession
                mgdShellSession = f_1640_30905_30945(this, shellContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 30960, 31308) || true) && (mgdShellSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 30960, 31308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31021, 31268);

                    f_1640_31021_31267(requestDetails, WSManPluginErrorCodes.InvalidShellContext, f_1640_31168_31266(f_1640_31212_31265()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31286, 31293);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 30960, 31308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31324, 31420);

                WSManPluginCommandSession
                mgdCommandSession = f_1640_31370_31419(mgdShellSession, commandContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31434, 31788) || true) && (mgdCommandSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 31434, 31788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31497, 31748);

                    f_1640_31497_31747(requestDetails, WSManPluginErrorCodes.InvalidCommandContext, f_1640_31646_31746(f_1640_31690_31745()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31766, 31773);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 31434, 31788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31804, 31843);

                f_1640_31804_31842(
                            mgdCommandSession, requestDetails);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 29465, 31854);

                System.Globalization.CultureInfo
                f_1640_30116_30144()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 30116, 30144);
                    return return_v;
                }


                string?
                f_1640_30059_30145(System.Management.Automation.Remoting.WSManPluginErrorCodes
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 30059, 30145);
                    return return_v;
                }


                string
                f_1640_30212_30262()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 30212, 30262);
                    return return_v;
                }


                string
                f_1640_30168_30346(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 30168, 30346);
                    return return_v;
                }


                int
                f_1640_29814_30382(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 29814, 30382);
                    return 0;
                }


                int
                f_1640_30439_30474(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 30439, 30474);
                    return 0;
                }


                string?
                f_1640_30820_30845(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 30820, 30845);
                    return return_v;
                }


                int
                f_1640_30491_30846(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 30491, 30846);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_30905_30945(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.GetFromActiveShellSessions(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 30905, 30945);
                    return return_v;
                }


                string
                f_1640_31212_31265()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidShellContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 31212, 31265);
                    return return_v;
                }


                string
                f_1640_31168_31266(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 31168, 31266);
                    return return_v;
                }


                int
                f_1640_31021_31267(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 31021, 31267);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginCommandSession
                f_1640_31370_31419(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.IntPtr
                cmdContext)
                {
                    var return_v = this_param.GetCommandSession(cmdContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 31370, 31419);
                    return return_v;
                }


                string
                f_1640_31690_31745()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidCommandContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 31690, 31745);
                    return return_v;
                }


                string
                f_1640_31646_31746(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 31646, 31746);
                    return return_v;
                }


                int
                f_1640_31497_31747(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 31497, 31747);
                    return 0;
                }


                int
                f_1640_31804_31842(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    this_param.Stop(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 31804, 31842);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 29465, 31854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 29465, 31854);
            }
        }

        internal void Shutdown()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 31866, 32402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 31915, 32113);

                f_1640_31915_32112(PSEventId.WSManPluginShutdown, PSOpcode.ShuttingDown, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 32194, 32276);

                f_1640_32194_32275(f_1640_32205_32231(_activeShellSessions) == 0, "All active shells should be closed");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 32341, 32391);

                f_1640_32341_32390();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 31866, 32402);

                int
                f_1640_31915_32112(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 31915, 32112);
                    return 0;
                }


                int
                f_1640_32205_32231(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 32205, 32231);
                    return return_v;
                }


                int
                f_1640_32194_32275(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 32194, 32275);
                    return 0;
                }


                int
                f_1640_32341_32390()
                {
                    WSManServerChannelEvents.RaiseShuttingDownEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 32341, 32390);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 31866, 32402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 31866, 32402);
            }
        }

        internal void ConnectShellOrCommand(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    WSManNativeApi.WSManData_UnToMan inboundConnectInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 32738, 34940);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 33029, 33169) || true) && (!f_1640_33034_33113(this, requestDetails, shellContext, "ConnectShellOrCommand"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 33029, 33169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 33147, 33154);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 33029, 33169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 33300, 33336);

                f_1640_33300_33335(requestDetails);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 33668, 33751);

                WSManPluginShellSession
                mgdShellSession = f_1640_33710_33750(this, shellContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 33765, 34113) || true) && (mgdShellSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 33765, 34113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 33826, 34073);

                    f_1640_33826_34072(requestDetails, WSManPluginErrorCodes.InvalidShellContext, f_1640_33973_34071(f_1640_34017_34070()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34091, 34098);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 33765, 34113);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34129, 34317) || true) && (IntPtr.Zero == commandContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 34129, 34317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34196, 34277);

                    f_1640_34196_34276(mgdShellSession, requestDetails, flags, inboundConnectInformation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34295, 34302);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 34129, 34317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34378, 34470);

                WSManPluginCommandSession
                mgdCmdSession = f_1640_34420_34469(mgdShellSession, commandContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34484, 34834) || true) && (mgdCmdSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 34484, 34834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34543, 34794);

                    f_1640_34543_34793(requestDetails, WSManPluginErrorCodes.InvalidCommandContext, f_1640_34692_34792(f_1640_34736_34791()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34812, 34819);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 34484, 34834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 34850, 34929);

                f_1640_34850_34928(
                            mgdCmdSession, requestDetails, flags, inboundConnectInformation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 32738, 34940);

                bool
                f_1640_33034_33113(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.IntPtr
                shellContext, string
                inputFunctionName)
                {
                    var return_v = this_param.validateIncomingContexts(requestDetails, shellContext, inputFunctionName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 33034, 33113);
                    return return_v;
                }


                int
                f_1640_33300_33335(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 33300, 33335);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_33710_33750(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.GetFromActiveShellSessions(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 33710, 33750);
                    return return_v;
                }


                string
                f_1640_34017_34070()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidShellContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 34017, 34070);
                    return return_v;
                }


                string
                f_1640_33973_34071(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 33973, 34071);
                    return return_v;
                }


                int
                f_1640_33826_34072(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 33826, 34072);
                    return 0;
                }


                int
                f_1640_34196_34276(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                inboundConnectInformation)
                {
                    this_param.ExecuteConnect(requestDetails, flags, inboundConnectInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 34196, 34276);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginCommandSession
                f_1640_34420_34469(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.IntPtr
                cmdContext)
                {
                    var return_v = this_param.GetCommandSession(cmdContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 34420, 34469);
                    return return_v;
                }


                string
                f_1640_34736_34791()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidCommandContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 34736, 34791);
                    return return_v;
                }


                string
                f_1640_34692_34792(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 34692, 34792);
                    return return_v;
                }


                int
                f_1640_34543_34793(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 34543, 34793);
                    return 0;
                }


                int
                f_1640_34850_34928(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                inboundConnectInformation)
                {
                    this_param.ExecuteConnect(requestDetails, flags, inboundConnectInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 34850, 34928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 32738, 34940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 32738, 34940);
            }
        }

        internal void SendOneItemToShellOrCommand(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    string stream,
                    WSManNativeApi.WSManData_UnToMan inboundData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 35340, 37579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 35651, 35797) || true) && (!f_1640_35656_35741(this, requestDetails, shellContext, "SendOneItemToShellOrCommand"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 35651, 35797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 35775, 35782);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 35651, 35797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 35813, 35849);

                f_1640_35813_35848(requestDetails);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 35865, 36170);

                f_1640_35865_36169(PSEventId.ServerReceivedData, PSOpcode.Open, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, ((IntPtr)shellContext).ToString(), ((IntPtr)commandContext).ToString(), f_1640_36143_36168(requestDetails));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 36186, 36269);

                WSManPluginShellSession
                mgdShellSession = f_1640_36228_36268(this, shellContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 36283, 36653) || true) && (mgdShellSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 36283, 36653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 36344, 36613);

                    f_1640_36344_36612(requestDetails, WSManPluginErrorCodes.InvalidShellContext, f_1640_36491_36589(f_1640_36535_36588()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 36631, 36638);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 36283, 36653);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 36669, 36951) || true) && (IntPtr.Zero == commandContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 36669, 36951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 36830, 36911);

                    f_1640_36830_36910(                // the data is destined for shell (runspace) session. so let shell handle it
                                    mgdShellSession, requestDetails, flags, stream, inboundData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 36929, 36936);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 36669, 36951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 37017, 37109);

                WSManPluginCommandSession
                mgdCmdSession = f_1640_37059_37108(mgdShellSession, commandContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 37123, 37473) || true) && (mgdCmdSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 37123, 37473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 37182, 37433);

                    f_1640_37182_37432(requestDetails, WSManPluginErrorCodes.InvalidCommandContext, f_1640_37331_37431(f_1640_37375_37430()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 37451, 37458);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 37123, 37473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 37489, 37568);

                f_1640_37489_37567(
                            mgdCmdSession, requestDetails, flags, stream, inboundData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 35340, 37579);

                bool
                f_1640_35656_35741(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.IntPtr
                shellContext, string
                inputFunctionName)
                {
                    var return_v = this_param.validateIncomingContexts(requestDetails, shellContext, inputFunctionName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 35656, 35741);
                    return return_v;
                }


                int
                f_1640_35813_35848(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 35813, 35848);
                    return 0;
                }


                string?
                f_1640_36143_36168(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 36143, 36168);
                    return return_v;
                }


                int
                f_1640_35865_36169(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 35865, 36169);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_36228_36268(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.GetFromActiveShellSessions(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 36228, 36268);
                    return return_v;
                }


                string
                f_1640_36535_36588()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidShellContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 36535, 36588);
                    return return_v;
                }


                string
                f_1640_36491_36589(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 36491, 36589);
                    return return_v;
                }


                int
                f_1640_36344_36612(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 36344, 36612);
                    return 0;
                }


                int
                f_1640_36830_36910(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, string
                stream, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                inboundData)
                {
                    this_param.SendOneItemToSession(requestDetails, flags, stream, inboundData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 36830, 36910);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginCommandSession
                f_1640_37059_37108(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.IntPtr
                cmdContext)
                {
                    var return_v = this_param.GetCommandSession(cmdContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 37059, 37108);
                    return return_v;
                }


                string
                f_1640_37375_37430()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidCommandContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 37375, 37430);
                    return return_v;
                }


                string
                f_1640_37331_37431(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 37331, 37431);
                    return return_v;
                }


                int
                f_1640_37182_37432(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 37182, 37432);
                    return 0;
                }


                int
                f_1640_37489_37567(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, string
                stream, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                inboundData)
                {
                    this_param.SendOneItemToSession(requestDetails, flags, stream, inboundData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 37489, 37567);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 35340, 37579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 35340, 37579);
            }
        }

        internal void EnableShellOrCommandToSendDataToClient(
                    IntPtr pluginContext,
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    WSManNativeApi.WSManStreamIDSet_UnToMan streamSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 38053, 41041);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 38387, 38544) || true) && (!f_1640_38392_38488(this, requestDetails, shellContext, "EnableShellOrCommandToSendDataToClient"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 38387, 38544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 38522, 38529);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 38387, 38544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 38560, 38596);

                f_1640_38560_38595(requestDetails);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 38612, 38971);

                f_1640_38612_38970(PSEventId.ServerClientReceiveRequest, PSOpcode.Open, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, ((IntPtr)shellContext).ToString(), ((IntPtr)commandContext).ToString(), f_1640_38944_38969(requestDetails));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 38987, 39070);

                WSManPluginShellSession
                mgdShellSession = f_1640_39029_39069(this, shellContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39084, 39454) || true) && (mgdShellSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 39084, 39454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39145, 39414);

                    f_1640_39145_39413(requestDetails, WSManPluginErrorCodes.InvalidShellContext, f_1640_39292_39390(f_1640_39336_39389()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39432, 39439);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 39084, 39454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39470, 39609);

                WSManPluginOperationShutdownContext
                ctxtToReport = f_1640_39521_39608(pluginContext, shellContext, IntPtr.Zero, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39623, 39796) || true) && (ctxtToReport == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 39623, 39796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39681, 39756);

                    f_1640_39681_39755(requestDetails, WSManPluginErrorCodes.OutOfMemory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39774, 39781);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 39623, 39796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39812, 41030) || true) && (IntPtr.Zero == commandContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 39812, 41030);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 39980, 40147) || true) && (f_1640_39984_40079(mgdShellSession, requestDetails, flags, streamSet, ctxtToReport))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 39980, 40147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40121, 40128);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 39980, 40147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 39812, 41030);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 39812, 41030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40273, 40318);

                    ctxtToReport.commandContext = commandContext;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40336, 40428);

                    WSManPluginCommandSession
                    mgdCmdSession = f_1640_40378_40427(mgdShellSession, commandContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40448, 40830) || true) && (mgdCmdSession == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 40448, 40830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40515, 40782);

                        f_1640_40515_40781(requestDetails, WSManPluginErrorCodes.InvalidCommandContext, f_1640_40676_40780(f_1640_40724_40779()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40804, 40811);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 40448, 40830);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40850, 41015) || true) && (f_1640_40854_40947(mgdCmdSession, requestDetails, flags, streamSet, ctxtToReport))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 40850, 41015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 40989, 40996);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 40850, 41015);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 39812, 41030);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 38053, 41041);

                bool
                f_1640_38392_38488(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.IntPtr
                shellContext, string
                inputFunctionName)
                {
                    var return_v = this_param.validateIncomingContexts(requestDetails, shellContext, inputFunctionName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 38392, 38488);
                    return return_v;
                }


                int
                f_1640_38560_38595(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails)
                {
                    SetThreadProperties(requestDetails);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 38560, 38595);
                    return 0;
                }


                string?
                f_1640_38944_38969(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 38944, 38969);
                    return return_v;
                }


                int
                f_1640_38612_38970(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 38612, 38970);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginShellSession
                f_1640_39029_39069(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.GetFromActiveShellSessions(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 39029, 39069);
                    return return_v;
                }


                string
                f_1640_39336_39389()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidShellContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 39336, 39389);
                    return return_v;
                }


                string
                f_1640_39292_39390(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 39292, 39390);
                    return return_v;
                }


                int
                f_1640_39145_39413(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 39145, 39413);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                f_1640_39521_39608(System.IntPtr
                plgContext, System.IntPtr
                shContext, System.IntPtr
                cmdContext, bool
                isRcvOp)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginOperationShutdownContext(plgContext, shContext, cmdContext, isRcvOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 39521, 39608);
                    return return_v;
                }


                int
                f_1640_39681_39755(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 39681, 39755);
                    return 0;
                }


                bool
                f_1640_39984_40079(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan
                streamSet, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                ctxtToReport)
                {
                    var return_v = this_param.EnableSessionToSendDataToClient(requestDetails, flags, streamSet, ctxtToReport);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 39984, 40079);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginCommandSession
                f_1640_40378_40427(System.Management.Automation.Remoting.WSManPluginShellSession
                this_param, System.IntPtr
                cmdContext)
                {
                    var return_v = this_param.GetCommandSession(cmdContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 40378, 40427);
                    return return_v;
                }


                string
                f_1640_40724_40779()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginInvalidCommandContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 40724, 40779);
                    return return_v;
                }


                string
                f_1640_40676_40780(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 40676, 40780);
                    return return_v;
                }


                int
                f_1640_40515_40781(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 40515, 40781);
                    return 0;
                }


                bool
                f_1640_40854_40947(System.Management.Automation.Remoting.WSManPluginCommandSession
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan
                streamSet, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                ctxtToReport)
                {
                    var return_v = this_param.EnableSessionToSendDataToClient(requestDetails, flags, streamSet, ctxtToReport);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 40854, 40947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 38053, 41041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 38053, 41041);
            }
        }

        private PSSenderInfo GetPSSenderInfo(
                    WSManNativeApi.WSManSenderDetails senderDetails)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 41257, 43574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 41429, 41495);

                f_1640_41429_41494(senderDetails != null, "senderDetails cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 41548, 41590);

                PSCertificateDetails
                psCertDetails = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 41650, 41986) || true) && (senderDetails.certificateDetails != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 41650, 41986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 41728, 41971);

                    psCertDetails = f_1640_41744_41970(senderDetails.certificateDetails.subject, senderDetails.certificateDetails.issuerName, senderDetails.certificateDetails.issuerThumbprint);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 41650, 41986);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 42040, 42165);

                PSIdentity
                psIdentity = f_1640_42064_42164(senderDetails.authenticationMechanism, true, senderDetails.senderName, psCertDetails)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 42355, 42398);

                IntPtr
                clientToken = f_1640_42376_42397(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 42412, 42497);

                clientToken = (DynAbs.Tracing.TraceSender.Conditional_F1(1640, 42426, 42454) || (((clientToken != IntPtr.Zero) && DynAbs.Tracing.TraceSender.Conditional_F2(1640, 42457, 42468)) || DynAbs.Tracing.TraceSender.Conditional_F3(1640, 42471, 42496))) ? clientToken : senderDetails.clientToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 42511, 42550);

                WindowsIdentity
                windowsIdentity = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 42564, 43355) || true) && (clientToken != IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 42564, 43355);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 42672, 42762);

                        windowsIdentity = f_1640_42690_42761(clientToken, senderDetails.authenticationMechanism);
                    }
                    // Suppress exceptions..So windowsIdentity = null in these cases
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1640, 42881, 43092);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1640, 42881, 43092);
                        // userToken is 0.
                        // -or-
                        // userToken is duplicated and invalid for impersonation.
                    }
                    catch (System.Security.SecurityException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1640, 43110, 43340);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1640, 43110, 43340);
                        // The caller does not have the correct permissions.
                        // -or-
                        // A Win32 error occurred.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 42564, 43355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 43371, 43444);

                PSPrincipal
                userPrincipal = f_1640_43399_43443(psIdentity, windowsIdentity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 43458, 43535);

                PSSenderInfo
                result = f_1640_43480_43534(userPrincipal, senderDetails.httpUrl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 43549, 43563);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 41257, 43574);

                int
                f_1640_41429_41494(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 41429, 41494);
                    return 0;
                }


                System.Management.Automation.Remoting.PSCertificateDetails
                f_1640_41744_41970(string
                subject, string
                issuerName, string
                issuerThumbprint)
                {
                    var return_v = new System.Management.Automation.Remoting.PSCertificateDetails(subject, issuerName, issuerThumbprint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 41744, 41970);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSIdentity
                f_1640_42064_42164(string
                authType, bool
                isAuthenticated, string
                userName, System.Management.Automation.Remoting.PSCertificateDetails
                cert)
                {
                    var return_v = new System.Management.Automation.Remoting.PSIdentity(authType, isAuthenticated, userName, cert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 42064, 42164);
                    return return_v;
                }


                System.IntPtr
                f_1640_42376_42397(System.Management.Automation.Remoting.WSManPluginInstance
                this_param)
                {
                    var return_v = this_param.GetRunAsClientToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 42376, 42397);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1640_42690_42761(System.IntPtr
                userToken, string
                type)
                {
                    var return_v = new System.Security.Principal.WindowsIdentity(userToken, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 42690, 42761);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1640_43399_43443(System.Management.Automation.Remoting.PSIdentity
                identity, System.Security.Principal.WindowsIdentity
                windowsIdentity)
                {
                    var return_v = new System.Management.Automation.Remoting.PSPrincipal(identity, windowsIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 43399, 43443);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSSenderInfo
                f_1640_43480_43534(System.Management.Automation.Remoting.PSPrincipal
                userPrincipal, string
                httpUrl)
                {
                    var return_v = new System.Management.Automation.Remoting.PSSenderInfo(userPrincipal, httpUrl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 43480, 43534);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 41257, 43574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 41257, 43574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        WSManRunAsClientTokenName = "__WINRM_RUNAS_CLIENT_TOKEN__"
        ;

        private IntPtr GetRunAsClientToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 43973, 44668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 44034, 44127);

                string
                clientTokenStr = f_1640_44058_44126(WSManRunAsClientTokenName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 44141, 44622) || true) && (clientTokenStr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 44141, 44622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 44274, 44349);

                    f_1640_44274_44348(WSManRunAsClientTokenName, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 44369, 44388);

                    int
                    clientTokenInt
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 44406, 44607) || true) && (f_1640_44410_44512(clientTokenStr, NumberStyles.HexNumber, f_1640_44463_44491(), out clientTokenInt))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 44406, 44607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 44554, 44588);

                        return f_1640_44561_44587(clientTokenInt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 44406, 44607);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 44141, 44622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 44638, 44657);

                return IntPtr.Zero;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 43973, 44668);

                string?
                f_1640_44058_44126(string
                variable)
                {
                    var return_v = System.Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 44058, 44126);
                    return return_v;
                }


                int
                f_1640_44274_44348(string
                variable, string?
                value)
                {
                    System.Environment.SetEnvironmentVariable(variable, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 44274, 44348);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1640_44463_44491()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 44463, 44491);
                    return return_v;
                }


                bool
                f_1640_44410_44512(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 44410, 44512);
                    return return_v;
                }


                System.IntPtr
                f_1640_44561_44587(int
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 44561, 44587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 43973, 44668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 43973, 44668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal bool EnsureOptionsComply(
                    WSManNativeApi.WSManPluginRequest requestDetails)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 44881, 47382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45013, 45099);

                WSManNativeApi.WSManOption[]
                options = requestDetails.operationInfo.optionSet.options
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45113, 45152);

                bool
                isProtocolVersionDeclared = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45177, 45182);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45168, 46712) || true) && (i < f_1640_45188_45202(options))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45204, 45207)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 45168, 46712)) // What about requestDetails.operationInfo.optionSet.optionsCount? It is a hold over from the C++ API. Safer is Length.

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 45168, 46712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45361, 45408);

                        WSManNativeApi.WSManOption
                        option = options[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45428, 45811) || true) && (f_1640_45432_45543(option.name, WSManPluginConstants.PowerShellStartupProtocolVersionName, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 45428, 45811);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45585, 45735) || true) && (!f_1640_45590_45649(this, requestDetails, option.value))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 45585, 45735);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45699, 45712);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 45585, 45735);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45759, 45792);

                            isProtocolVersionDeclared = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 45428, 45811);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 45831, 46697) || true) && (0 == f_1640_45840_45996(option.name, 0, WSManPluginConstants.PowerShellOptionPrefix, 0, f_1640_45919_45969(WSManPluginConstants.PowerShellOptionPrefix), StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 45831, 46697);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 46038, 46678) || true) && (option.mustComply)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 46038, 46678);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 46109, 46616);

                                f_1640_46109_46615(requestDetails, WSManPluginErrorCodes.OptionNotUnderstood, f_1640_46280_46614(f_1640_46332_46385(), option.name, f_1640_46466_46520(), WSManPluginConstants.PowerShellStartupProtocolVersionValue));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 46642, 46655);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 46038, 46678);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 45831, 46697);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1640, 1, 1545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1640, 1, 1545);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 46728, 47343) || true) && (!isProtocolVersionDeclared)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 46728, 47343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 46792, 47297);

                    f_1640_46792_47296(requestDetails, WSManPluginErrorCodes.ProtocolVersionNotFound, f_1640_46943_47295(f_1640_46987_47044(), WSManPluginConstants.PowerShellStartupProtocolVersionName, f_1640_47155_47209(), WSManPluginConstants.PowerShellStartupProtocolVersionValue));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 47315, 47328);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 46728, 47343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 47359, 47371);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 44881, 47382);

                int
                f_1640_45188_45202(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManOption[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 45188, 45202);
                    return return_v;
                }


                bool
                f_1640_45432_45543(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 45432, 45543);
                    return return_v;
                }


                bool
                f_1640_45590_45649(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, string
                clientVersionString)
                {
                    var return_v = this_param.EnsureProtocolVersionComplies(requestDetails, clientVersionString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 45590, 45649);
                    return return_v;
                }


                int
                f_1640_45919_45969(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 45919, 45969);
                    return return_v;
                }


                int
                f_1640_45840_45996(string
                strA, int
                indexA, string
                strB, int
                indexB, int
                length, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, indexA, strB, indexB, length, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 45840, 45996);
                    return return_v;
                }


                string
                f_1640_46332_46385()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginOptionNotUnderstood;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 46332, 46385);
                    return return_v;
                }


                string
                f_1640_46466_46520()
                {
                    var return_v = System.Management.Automation.PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 46466, 46520);
                    return return_v;
                }


                string
                f_1640_46280_46614(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 46280, 46614);
                    return return_v;
                }


                int
                f_1640_46109_46615(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 46109, 46615);
                    return 0;
                }


                string
                f_1640_46987_47044()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginProtocolVersionNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 46987, 47044);
                    return return_v;
                }


                string
                f_1640_47155_47209()
                {
                    var return_v = System.Management.Automation.PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 47155, 47209);
                    return return_v;
                }


                string
                f_1640_46943_47295(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 46943, 47295);
                    return return_v;
                }


                int
                f_1640_46792_47296(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 46792, 47296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 44881, 47382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 44881, 47382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal bool EnsureProtocolVersionComplies(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    string clientVersionString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1640, 47669, 49256);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 47852, 48037) || true) && (f_1640_47856_47976(clientVersionString, WSManPluginConstants.PowerShellStartupProtocolVersionValue, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 47852, 48037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 48010, 48022);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 47852, 48037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 48301, 48375);

                System.Version
                clientVersion = f_1640_48332_48374(clientVersionString)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 48389, 48502);

                System.Version
                serverVersion = f_1640_48420_48501(WSManPluginConstants.PowerShellStartupProtocolVersionValue)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 48518, 48763) || true) && ((clientVersion != null) && (DynAbs.Tracing.TraceSender.Expression_True(1640, 48522, 48572) && (serverVersion != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1640, 48522, 48637) && (f_1640_48594_48613(clientVersion) == f_1640_48617_48636(serverVersion))) && (DynAbs.Tracing.TraceSender.Expression_True(1640, 48522, 48702) && (f_1640_48659_48678(clientVersion) >= f_1640_48682_48701(serverVersion))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 48518, 48763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 48736, 48748);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 48518, 48763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 48779, 49218);

                f_1640_48779_49217(requestDetails, WSManPluginErrorCodes.ProtocolVersionNotMatch, f_1640_48918_49216(f_1640_48958_49015(), WSManPluginConstants.PowerShellStartupProtocolVersionValue, f_1640_49119_49173(), clientVersionString));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 49232, 49245);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1640, 47669, 49256);

                bool
                f_1640_47856_47976(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 47856, 47976);
                    return return_v;
                }


                System.Version
                f_1640_48332_48374(string
                versionString)
                {
                    var return_v = Utils.StringToVersion(versionString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 48332, 48374);
                    return return_v;
                }


                System.Version
                f_1640_48420_48501(string
                versionString)
                {
                    var return_v = Utils.StringToVersion(versionString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 48420, 48501);
                    return return_v;
                }


                int
                f_1640_48594_48613(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 48594, 48613);
                    return return_v;
                }


                int
                f_1640_48617_48636(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 48617, 48636);
                    return return_v;
                }


                int
                f_1640_48659_48678(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 48659, 48678);
                    return return_v;
                }


                int
                f_1640_48682_48701(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 48682, 48701);
                    return return_v;
                }


                string
                f_1640_48958_49015()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginProtocolVersionNotMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 48958, 49015);
                    return return_v;
                }


                string
                f_1640_49119_49173()
                {
                    var return_v = System.Management.Automation.PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 49119, 49173);
                    return return_v;
                }


                string
                f_1640_48918_49216(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 48918, 49216);
                    return return_v;
                }


                int
                f_1640_48779_49217(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 48779, 49217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 47669, 49256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 47669, 49256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void PerformWSManPluginShell(
                    IntPtr pluginContext, // PVOID
                    IntPtr requestDetails, // WSMAN_PLUGIN_REQUEST*
                    int flags,
                    string extraInfo,
                    IntPtr startupInfo, // WSMAN_SHELL_STARTUP_INFO*
                    IntPtr inboundShellInformation) // WSMAN_DATA*
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 49687, 51322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50039, 50109);

                WSManPluginInstance
                pluginToUse = f_1640_50073_50108(pluginContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50125, 50674) || true) && (pluginToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 50125, 50674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50188, 50203);
                    lock (s_activePlugins)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50245, 50295);

                        pluginToUse = f_1640_50259_50294(pluginContext);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50317, 50640) || true) && (pluginToUse == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 50317, 50640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50438, 50496);

                            WSManPluginInstance
                            mgdPlugin = f_1640_50470_50495()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50522, 50567);

                            f_1640_50522_50566(pluginContext, mgdPlugin);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50593, 50617);

                            pluginToUse = mgdPlugin;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 50317, 50640);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 50125, 50674);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50773, 50892);

                WSManNativeApi.WSManPluginRequest
                requestDetailsInstance = f_1640_50832_50891(requestDetails)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 50906, 51041);

                WSManNativeApi.WSManShellStartupInfo_UnToMan
                startupInfoInstance = f_1640_50973_51040(startupInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 51055, 51175);

                WSManNativeApi.WSManData_UnToMan
                inboundShellInfo = f_1640_51107_51174(inboundShellInformation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 51191, 51311);

                f_1640_51191_51310(
                            pluginToUse, pluginContext, requestDetailsInstance, flags, extraInfo, startupInfoInstance, inboundShellInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 49687, 51322);

                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_50073_50108(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 50073, 50108);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_50259_50294(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 50259, 50294);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_50470_50495()
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 50470, 50495);
                    return return_v;
                }


                int
                f_1640_50522_50566(System.IntPtr
                pluginContext, System.Management.Automation.Remoting.WSManPluginInstance
                plugin)
                {
                    AddToActivePlugins(pluginContext, plugin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 50522, 50566);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                f_1640_50832_50891(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManPluginRequest.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 50832, 50891);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_UnToMan
                f_1640_50973_51040(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManShellStartupInfo_UnToMan.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 50973, 51040);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                f_1640_51107_51174(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManData_UnToMan.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 51107, 51174);
                    return return_v;
                }


                int
                f_1640_51191_51310(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                pluginContext, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, string
                extraInfo, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManShellStartupInfo_UnToMan
                startupInfo, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                inboundShellInformation)
                {
                    this_param.CreateShell(pluginContext, requestDetails, flags, extraInfo, startupInfo, inboundShellInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 51191, 51310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 49687, 51322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 49687, 51322);
            }
        }

        internal static void PerformWSManPluginCommand(
                    IntPtr pluginContext,
                    IntPtr requestDetails, // WSMAN_PLUGIN_REQUEST*
                    int flags,
                    IntPtr shellContext, // PVOID
                    [MarshalAs(UnmanagedType.LPWStr)] string commandLine,
                    IntPtr arguments) // WSMAN_COMMAND_ARG_SET*
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 51334, 52555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 51693, 51763);

                WSManPluginInstance
                pluginToUse = f_1640_51727_51762(pluginContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 51779, 52121) || true) && (pluginToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 51779, 52121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 51836, 52081);

                    f_1640_51836_52080(requestDetails, WSManPluginErrorCodes.PluginContextNotFound, f_1640_51985_52079(f_1640_52029_52078()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 52099, 52106);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 51779, 52121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 52220, 52324);

                WSManNativeApi.WSManPluginRequest
                request = f_1640_52264_52323(requestDetails)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 52338, 52436);

                WSManNativeApi.WSManCommandArgSet
                argSet = WSManNativeApi.WSManCommandArgSet.UnMarshal(arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 52452, 52544);

                f_1640_52452_52543(
                            pluginToUse, pluginContext, request, flags, shellContext, commandLine, argSet);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 51334, 52555);

                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_51727_51762(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 51727, 51762);
                    return return_v;
                }


                string
                f_1640_52029_52078()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginContextNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 52029, 52078);
                    return return_v;
                }


                string
                f_1640_51985_52079(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 51985, 52079);
                    return return_v;
                }


                int
                f_1640_51836_52080(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 51836, 52080);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                f_1640_52264_52323(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManPluginRequest.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 52264, 52323);
                    return return_v;
                }


                int
                f_1640_52452_52543(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                pluginContext, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.IntPtr
                shellContext, string
                commandLine, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManCommandArgSet
                arguments)
                {
                    this_param.CreateCommand(pluginContext, requestDetails, flags, shellContext, commandLine, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 52452, 52543);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 51334, 52555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 51334, 52555);
            }
        }

        internal static void PerformWSManPluginConnect(
                    IntPtr pluginContext,
                    IntPtr requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    IntPtr inboundConnectInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 52567, 53747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 52851, 52921);

                WSManPluginInstance
                pluginToUse = f_1640_52885_52920(pluginContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 52937, 53279) || true) && (pluginToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 52937, 53279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 52994, 53239);

                    f_1640_52994_53238(requestDetails, WSManPluginErrorCodes.PluginContextNotFound, f_1640_53143_53237(f_1640_53187_53236()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 53257, 53264);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 52937, 53279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 53378, 53482);

                WSManNativeApi.WSManPluginRequest
                request = f_1640_53422_53481(requestDetails)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 53496, 53620);

                WSManNativeApi.WSManData_UnToMan
                connectInformation = f_1640_53550_53619(inboundConnectInformation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 53636, 53736);

                f_1640_53636_53735(
                            pluginToUse, request, flags, shellContext, commandContext, connectInformation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 52567, 53747);

                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_52885_52920(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 52885, 52920);
                    return return_v;
                }


                string
                f_1640_53187_53236()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginContextNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 53187, 53236);
                    return return_v;
                }


                string
                f_1640_53143_53237(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 53143, 53237);
                    return return_v;
                }


                int
                f_1640_52994_53238(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 52994, 53238);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                f_1640_53422_53481(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManPluginRequest.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 53422, 53481);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                f_1640_53550_53619(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManData_UnToMan.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 53550, 53619);
                    return return_v;
                }


                int
                f_1640_53636_53735(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.IntPtr
                shellContext, System.IntPtr
                commandContext, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                inboundConnectInformation)
                {
                    this_param.ConnectShellOrCommand(requestDetails, flags, shellContext, commandContext, inboundConnectInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 53636, 53735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 52567, 53747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 52567, 53747);
            }
        }

        internal static void PerformWSManPluginSend(
                    IntPtr pluginContext,
                    IntPtr requestDetails, // WSMAN_PLUGIN_REQUEST*
                    int flags,
                    IntPtr shellContext, // PVOID
                    IntPtr commandContext, // PVOID
                    string stream,
                    IntPtr inboundData) // WSMAN_DATA*
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 53759, 54980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 54112, 54182);

                WSManPluginInstance
                pluginToUse = f_1640_54146_54181(pluginContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 54198, 54540) || true) && (pluginToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 54198, 54540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 54255, 54500);

                    f_1640_54255_54499(requestDetails, WSManPluginErrorCodes.PluginContextNotFound, f_1640_54404_54498(f_1640_54448_54497()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 54518, 54525);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 54198, 54540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 54639, 54743);

                WSManNativeApi.WSManPluginRequest
                request = f_1640_54683_54742(requestDetails)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 54757, 54853);

                WSManNativeApi.WSManData_UnToMan
                data = f_1640_54797_54852(inboundData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 54869, 54969);

                f_1640_54869_54968(
                            pluginToUse, request, flags, shellContext, commandContext, stream, data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 53759, 54980);

                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_54146_54181(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 54146, 54181);
                    return return_v;
                }


                string
                f_1640_54448_54497()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginContextNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 54448, 54497);
                    return return_v;
                }


                string
                f_1640_54404_54498(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 54404, 54498);
                    return return_v;
                }


                int
                f_1640_54255_54499(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 54255, 54499);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                f_1640_54683_54742(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManPluginRequest.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 54683, 54742);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                f_1640_54797_54852(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManData_UnToMan.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 54797, 54852);
                    return return_v;
                }


                int
                f_1640_54869_54968(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.IntPtr
                shellContext, System.IntPtr
                commandContext, string
                stream, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                inboundData)
                {
                    this_param.SendOneItemToShellOrCommand(requestDetails, flags, shellContext, commandContext, stream, inboundData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 54869, 54968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 53759, 54980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 53759, 54980);
            }
        }

        internal static void PerformWSManPluginReceive(
                    IntPtr pluginContext, // PVOID
                    IntPtr requestDetails, // WSMAN_PLUGIN_REQUEST*
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    IntPtr streamSet) // WSMAN_STREAM_ID_SET*
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 54992, 56230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 55318, 55388);

                WSManPluginInstance
                pluginToUse = f_1640_55352_55387(pluginContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 55404, 55746) || true) && (pluginToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 55404, 55746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 55461, 55706);

                    f_1640_55461_55705(requestDetails, WSManPluginErrorCodes.PluginContextNotFound, f_1640_55610_55704(f_1640_55654_55703()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 55724, 55731);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 55404, 55746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 55845, 55949);

                WSManNativeApi.WSManPluginRequest
                request = f_1640_55889_55948(requestDetails)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 55963, 56078);

                WSManNativeApi.WSManStreamIDSet_UnToMan
                streamIdSet = f_1640_56017_56077(streamSet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 56094, 56219);

                f_1640_56094_56218(
                            pluginToUse, pluginContext, request, flags, shellContext, commandContext, streamIdSet);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 54992, 56230);

                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_55352_55387(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 55352, 55387);
                    return return_v;
                }


                string
                f_1640_55654_55703()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginContextNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 55654, 55703);
                    return return_v;
                }


                string
                f_1640_55610_55704(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 55610, 55704);
                    return return_v;
                }


                int
                f_1640_55461_55705(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 55461, 55705);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                f_1640_55889_55948(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManPluginRequest.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 55889, 55948);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan
                f_1640_56017_56077(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManStreamIDSet_UnToMan.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 56017, 56077);
                    return return_v;
                }


                int
                f_1640_56094_56218(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.IntPtr
                pluginContext, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, int
                flags, System.IntPtr
                shellContext, System.IntPtr
                commandContext, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManStreamIDSet_UnToMan
                streamSet)
                {
                    this_param.EnableShellOrCommandToSendDataToClient(pluginContext, requestDetails, flags, shellContext, commandContext, streamSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 56094, 56218);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 54992, 56230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 54992, 56230);
            }
        }

        internal static void PerformWSManPluginSignal(
                    IntPtr pluginContext, // PVOID
                    IntPtr requestDetails, // WSMAN_PLUGIN_REQUEST*
                    int flags,
                    IntPtr shellContext, // PVOID
                    IntPtr commandContext, // PVOID
                    string code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 56242, 58465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 56556, 56660);

                WSManNativeApi.WSManPluginRequest
                request = f_1640_56600_56659(requestDetails)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 56706, 58374) || true) && (IntPtr.Zero != commandContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 56706, 58374);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 56773, 58359) || true) && (!f_1640_56778_56857(code, WSManPluginConstants.CtrlCSignal, StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 56773, 58359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 56971, 57109);

                        WSManPluginOperationShutdownContext
                        cmdCtxt = f_1640_57017_57108(pluginContext, shellContext, commandContext, false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 57131, 57453) || true) && (cmdCtxt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 57131, 57453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 57200, 57231);

                            f_1640_57200_57230(cmdCtxt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 57131, 57453);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 57131, 57453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 57329, 57397);

                            f_1640_57329_57396(request, WSManPluginErrorCodes.OutOfMemory);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 57423, 57430);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 57131, 57453);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 56773, 58359);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 56773, 58359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 57620, 57690);

                        WSManPluginInstance
                        pluginToUse = f_1640_57654_57689(pluginContext)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 57714, 58113) || true) && (pluginToUse == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 57714, 58113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 57787, 58057);

                            f_1640_57787_58056(request, WSManPluginErrorCodes.PluginContextNotFound, f_1640_57953_58055(f_1640_58005_58054()));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58083, 58090);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 57714, 58113);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58248, 58311);

                        f_1640_58248_58310(
                                            // this will ReportOperationComplete by itself..
                                            // so we just here.
                                            pluginToUse, request, shellContext, commandContext);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58333, 58340);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 56773, 58359);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 56706, 58374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58390, 58454);

                f_1640_58390_58453(request, WSManPluginErrorCodes.NoError);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 56242, 58465);

                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                f_1640_56600_56659(System.IntPtr
                unmanagedData)
                {
                    var return_v = WSManNativeApi.WSManPluginRequest.UnMarshal(unmanagedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 56600, 56659);
                    return return_v;
                }


                bool
                f_1640_56778_56857(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 56778, 56857);
                    return return_v;
                }


                System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                f_1640_57017_57108(System.IntPtr
                plgContext, System.IntPtr
                shContext, System.IntPtr
                cmdContext, bool
                isRcvOp)
                {
                    var return_v = new System.Management.Automation.Remoting.WSManPluginOperationShutdownContext(plgContext, shContext, cmdContext, isRcvOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 57017, 57108);
                    return return_v;
                }


                int
                f_1640_57200_57230(System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context)
                {
                    PerformCloseOperation(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 57200, 57230);
                    return 0;
                }


                int
                f_1640_57329_57396(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 57329, 57396);
                    return 0;
                }


                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_57654_57689(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 57654, 57689);
                    return return_v;
                }


                string
                f_1640_58005_58054()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginContextNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 58005, 58054);
                    return return_v;
                }


                string
                f_1640_57953_58055(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 57953, 58055);
                    return return_v;
                }


                int
                f_1640_57787_58056(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 57787, 58056);
                    return 0;
                }


                int
                f_1640_58248_58310(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.IntPtr
                shellContext, System.IntPtr
                commandContext)
                {
                    this_param.StopCommand(requestDetails, shellContext, commandContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 58248, 58310);
                    return 0;
                }


                int
                f_1640_58390_58453(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 58390, 58453);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 56242, 58465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 56242, 58465);
            }
        }

        internal static void PerformCloseOperation(
                    WSManPluginOperationShutdownContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 58636, 59300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58762, 58840);

                WSManPluginInstance
                pluginToUse = f_1640_58796_58839(context.pluginContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58856, 58935) || true) && (pluginToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 58856, 58935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58913, 58920);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 58856, 58935);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 58951, 59289) || true) && (IntPtr.Zero == context.commandContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 58951, 59289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59072, 59113);

                    f_1640_59072_59112(                // this is targeted at shell
                                    pluginToUse, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 58951, 59289);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 58951, 59289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59231, 59274);

                    f_1640_59231_59273(                // shutdown is targeted at command
                                    pluginToUse, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 58951, 59289);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 58636, 59300);

                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_58796_58839(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 58796, 58839);
                    return return_v;
                }


                int
                f_1640_59072_59112(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context)
                {
                    this_param.CloseShellOperation(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 59072, 59112);
                    return 0;
                }


                int
                f_1640_59231_59273(System.Management.Automation.Remoting.WSManPluginInstance
                this_param, System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context)
                {
                    this_param.CloseCommandOperation(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 59231, 59273);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 58636, 59300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 58636, 59300);
            }
        }

        internal static void PerformShutdown(
                    IntPtr pluginContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 59465, 59777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59562, 59632);

                WSManPluginInstance
                pluginToUse = f_1640_59596_59631(pluginContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59648, 59727) || true) && (pluginToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 59648, 59727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59705, 59712);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 59648, 59727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59743, 59766);

                f_1640_59743_59765(
                            pluginToUse);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 59465, 59777);

                System.Management.Automation.Remoting.WSManPluginInstance
                f_1640_59596_59631(System.IntPtr
                pluginContext)
                {
                    var return_v = GetFromActivePlugins(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 59596, 59631);
                    return return_v;
                }


                int
                f_1640_59743_59765(System.Management.Automation.Remoting.WSManPluginInstance
                this_param)
                {
                    this_param.Shutdown();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 59743, 59765);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 59465, 59777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 59465, 59777);
            }
        }

        private static WSManPluginInstance GetFromActivePlugins(IntPtr pluginContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 59789, 60111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59897, 59912);
                lock (s_activePlugins)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59946, 59980);

                    WSManPluginInstance
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 59998, 60053);

                    f_1640_59998_60052(s_activePlugins, pluginContext, out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 60071, 60085);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 59789, 60111);

                bool
                f_1640_59998_60052(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginInstance>
                this_param, System.IntPtr
                key, out System.Management.Automation.Remoting.WSManPluginInstance
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 59998, 60052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 59789, 60111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 59789, 60111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddToActivePlugins(IntPtr pluginContext, WSManPluginInstance plugin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 60123, 60497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 60242, 60257);
                lock (s_activePlugins)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 60291, 60471) || true) && (!f_1640_60296_60338(s_activePlugins, pluginContext))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 60291, 60471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 60380, 60423);

                        f_1640_60380_60422(s_activePlugins, pluginContext, plugin);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 60445, 60452);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 60291, 60471);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 60123, 60497);

                bool
                f_1640_60296_60338(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginInstance>
                this_param, System.IntPtr
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 60296, 60338);
                    return return_v;
                }


                int
                f_1640_60380_60422(System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginInstance>
                this_param, System.IntPtr
                key, System.Management.Automation.Remoting.WSManPluginInstance
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 60380, 60422);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 60123, 60497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 60123, 60497);
            }
        }

        internal static void ReportWSManOperationComplete(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    WSManPluginErrorCodes errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 60759, 61531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 60943, 61034);

                f_1640_60943_61033(requestDetails != null, "requestDetails cannot be null in operation complete.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 61050, 61437);

                f_1640_61050_61436(PSEventId.ReportOperationComplete, PSOpcode.Close, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, (requestDetails.unmanagedHandle).ToString(), f_1640_61316_61373(errorCode, f_1640_61344_61372()), string.Empty, string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 61453, 61520);

                f_1640_61453_61519(requestDetails.unmanagedHandle, errorCode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 60759, 61531);

                int
                f_1640_60943_61033(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 60943, 61033);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1640_61344_61372()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 61344, 61372);
                    return return_v;
                }


                string?
                f_1640_61316_61373(System.Management.Automation.Remoting.WSManPluginErrorCodes
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 61316, 61373);
                    return return_v;
                }


                int
                f_1640_61050_61436(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 61050, 61436);
                    return 0;
                }


                int
                f_1640_61453_61519(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 61453, 61519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 60759, 61531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 60759, 61531);
            }
        }

        internal static void ReportWSManOperationComplete(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 61793, 63539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 61970, 62061);

                f_1640_61970_62060(requestDetails != null, "requestDetails cannot be null in operation complete.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62077, 62137);

                WSManPluginErrorCodes
                error = WSManPluginErrorCodes.NoError
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62151, 62186);

                string
                errorMessage = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62200, 62233);

                string
                stackTrace = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62249, 62484) || true) && (reasonForClose != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 62249, 62484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62309, 62356);

                    error = WSManPluginErrorCodes.ManagedException;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62374, 62412);

                    errorMessage = f_1640_62389_62411(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62430, 62469);

                    stackTrace = f_1640_62443_62468(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 62249, 62484);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62500, 62863);

                f_1640_62500_62862(PSEventId.ReportOperationComplete, PSOpcode.Close, PSTask.None, PSKeyword.ManagedPlugin | PSKeyword.UseAlwaysAnalytic, f_1640_62704_62729(requestDetails), f_1640_62748_62801(error, f_1640_62772_62800()), errorMessage, stackTrace);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 62879, 63528) || true) && (reasonForClose != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 62879, 63528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 63027, 63317);

                    f_1640_63027_63316(requestDetails, WSManPluginErrorCodes.ManagedException, f_1640_63171_63315(f_1640_63215_63265(), f_1640_63292_63314(reasonForClose)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 62879, 63528);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 62879, 63528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 63383, 63513);

                    f_1640_63383_63512(requestDetails.unmanagedHandle, WSManPluginErrorCodes.NoError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 62879, 63528);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 61793, 63539);

                int
                f_1640_61970_62060(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 61970, 62060);
                    return 0;
                }


                string
                f_1640_62389_62411(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 62389, 62411);
                    return return_v;
                }


                string
                f_1640_62443_62468(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 62443, 62468);
                    return return_v;
                }


                string?
                f_1640_62704_62729(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 62704, 62729);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1640_62772_62800()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 62772, 62800);
                    return return_v;
                }


                string?
                f_1640_62748_62801(System.Management.Automation.Remoting.WSManPluginErrorCodes
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 62748, 62801);
                    return return_v;
                }


                int
                f_1640_62500_62862(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticInformational(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 62500, 62862);
                    return 0;
                }


                string
                f_1640_63215_63265()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginManagedException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 63215, 63265);
                    return return_v;
                }


                string
                f_1640_63292_63314(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 63292, 63314);
                    return return_v;
                }


                string
                f_1640_63171_63315(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 63171, 63315);
                    return return_v;
                }


                int
                f_1640_63027_63316(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManPluginRequest
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 63027, 63316);
                    return 0;
                }


                int
                f_1640_63383_63512(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode)
                {
                    ReportOperationComplete(requestDetails, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 63383, 63512);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 61793, 63539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 61793, 63539);
            }
        }

        internal static void SetThreadProperties(
                    WSManNativeApi.WSManPluginRequest requestDetails)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 63991, 66579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 64171, 64239);

                f_1640_64171_64238(requestDetails != null, "requestDetails cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 64310, 64393);

                WSManNativeApi.WSManDataStruct
                outputStruct = f_1640_64356_64392()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 64407, 64630);

                int
                hResult = f_1640_64421_64629(wsmanPinvokeStatic, requestDetails.unmanagedHandle, WSManPluginConstants.WSManPluginParamsGetRequestedLocale, outputStruct)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 64683, 64731);

                bool
                retrievingLocaleSucceeded = (0 == hResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 64745, 64848);

                WSManNativeApi.WSManData_UnToMan
                localeData = f_1640_64791_64847(outputStruct)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 64943, 65166);

                hResult = f_1640_64953_65165(wsmanPinvokeStatic, requestDetails.unmanagedHandle, WSManPluginConstants.WSManPluginParamsGetRequestedDataLocale, outputStruct);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 65223, 65308);

                bool
                retrievingDataLocaleSucceeded = ((int)WSManPluginErrorCodes.NoError == hResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 65322, 65429);

                WSManNativeApi.WSManData_UnToMan
                dataLocaleData = f_1640_65372_65428(outputStruct)
                ;

                // Set the UI Culture
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 65540, 65849) || true) && (retrievingLocaleSucceeded && (DynAbs.Tracing.TraceSender.Expression_True(1640, 65544, 65649) && ((uint)WSManNativeApi.WSManDataType.WSMAN_DATA_TYPE_TEXT == f_1640_65633_65648(localeData))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 65540, 65849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 65691, 65753);

                        CultureInfo
                        uiCultureToUse = f_1640_65720_65752(f_1640_65736_65751(localeData))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 65775, 65830);

                        f_1640_65775_65795().CurrentUICulture = uiCultureToUse;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 65540, 65849);
                    }
                }
                // ignore if there is any exception constructing the culture..
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1640, 65954, 66009);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1640, 65954, 66009);
                }

                // Set the Culture
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 66093, 66408) || true) && (retrievingDataLocaleSucceeded && (DynAbs.Tracing.TraceSender.Expression_True(1640, 66097, 66210) && ((uint)WSManNativeApi.WSManDataType.WSMAN_DATA_TYPE_TEXT == f_1640_66190_66209(dataLocaleData))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 66093, 66408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 66252, 66316);

                        CultureInfo
                        cultureToUse = f_1640_66279_66315(f_1640_66295_66314(dataLocaleData))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 66338, 66389);

                        f_1640_66338_66358().CurrentCulture = cultureToUse;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 66093, 66408);
                    }
                }
                // ignore if there is any exception constructing the culture..
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1640, 66513, 66568);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1640, 66513, 66568);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 63991, 66579);

                int
                f_1640_64171_64238(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 64171, 64238);
                    return 0;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                f_1640_64356_64392()
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 64356, 64392);
                    return return_v;
                }


                int
                f_1640_64421_64629(System.Management.Automation.Remoting.Client.IWSManNativeApiFacade
                this_param, System.IntPtr
                requestDetails, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                data)
                {
                    var return_v = this_param.WSManPluginGetOperationParameters(requestDetails, flags, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 64421, 64629);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                f_1640_64791_64847(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                dataStruct)
                {
                    var return_v = WSManNativeApi.WSManData_UnToMan.UnMarshal(dataStruct);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 64791, 64847);
                    return return_v;
                }


                int
                f_1640_64953_65165(System.Management.Automation.Remoting.Client.IWSManNativeApiFacade
                this_param, System.IntPtr
                requestDetails, int
                flags, System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                data)
                {
                    var return_v = this_param.WSManPluginGetOperationParameters(requestDetails, flags, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 64953, 65165);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                f_1640_65372_65428(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManDataStruct
                dataStruct)
                {
                    var return_v = WSManNativeApi.WSManData_UnToMan.UnMarshal(dataStruct);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 65372, 65428);
                    return return_v;
                }


                uint
                f_1640_65633_65648(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 65633, 65648);
                    return return_v;
                }


                string
                f_1640_65736_65751(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 65736, 65751);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1640_65720_65752(string
                name)
                {
                    var return_v = new System.Globalization.CultureInfo(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 65720, 65752);
                    return return_v;
                }


                System.Threading.Thread
                f_1640_65775_65795()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 65775, 65795);
                    return return_v;
                }


                uint
                f_1640_66190_66209(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 66190, 66209);
                    return return_v;
                }


                string
                f_1640_66295_66314(System.Management.Automation.Remoting.Client.WSManNativeApi.WSManData_UnToMan
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 66295, 66314);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1640_66279_66315(string
                name)
                {
                    var return_v = new System.Globalization.CultureInfo(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 66279, 66315);
                    return return_v;
                }


                System.Threading.Thread
                f_1640_66338_66358()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1640, 66338, 66358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 63991, 66579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 63991, 66579);
            }
        }

        internal static void ReportOperationComplete(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    WSManPluginErrorCodes errorCode,
                    string errorMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 68211, 68653);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 68424, 68580) || true) && (requestDetails != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 68424, 68580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 68484, 68565);

                    f_1640_68484_68564(requestDetails.unmanagedHandle, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 68424, 68580);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 68211, 68653);

                int
                f_1640_68484_68564(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 68484, 68564);
                    return 0;
                }

                // else cannot report if requestDetails is null.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 68211, 68653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 68211, 68653);
            }
        }

        internal static void ReportOperationComplete(
                    WSManNativeApi.WSManPluginRequest requestDetails,
                    WSManPluginErrorCodes errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 68913, 69496);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 69092, 69423) || true) && (requestDetails != null && (DynAbs.Tracing.TraceSender.Expression_True(1640, 69096, 69184) && IntPtr.Zero != requestDetails.unmanagedHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 69092, 69423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 69218, 69408);

                    f_1640_69218_69407(wsmanPinvokeStatic, requestDetails.unmanagedHandle, 0, errorCode, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 69092, 69423);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 68913, 69496);

                int
                f_1640_69218_69407(System.Management.Automation.Remoting.Client.IWSManNativeApiFacade
                this_param, System.IntPtr
                requestDetails, int
                flags, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                extendedInformation)
                {
                    var return_v = this_param.WSManPluginOperationComplete(requestDetails, flags, (int)errorCode, extendedInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 69218, 69407);
                    return return_v;
                }

                // else cannot report if requestDetails is null.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 68913, 69496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 68913, 69496);
            }
        }

        internal static void ReportOperationComplete(
                    IntPtr requestDetails,
                    WSManPluginErrorCodes errorCode,
                    string errorMessage = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1640, 69838, 70395);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 70029, 70179) || true) && (IntPtr.Zero == requestDetails)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1640, 70029, 70179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 70157, 70164);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1640, 70029, 70179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 70195, 70361);

                f_1640_70195_70360(
                            wsmanPinvokeStatic, requestDetails, 0, errorCode, errorMessage);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1640, 70377, 70384);

                return;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1640, 69838, 70395);

                int
                f_1640_70195_70360(System.Management.Automation.Remoting.Client.IWSManNativeApiFacade
                this_param, System.IntPtr
                requestDetails, int
                flags, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                extendedInformation)
                {
                    var return_v = this_param.WSManPluginOperationComplete(requestDetails, flags, (int)errorCode, extendedInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 70195, 70360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1640, 69838, 70395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1640, 69838, 70395);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1640, 5092, 70424);

        static System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginInstance>
        f_1640_5371_5416()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginInstance>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 5371, 5416);
            return return_v;
        }


        static System.Management.Automation.Remoting.Client.WSManNativeApiFacade
        f_1640_5857_5883()
        {
            var return_v = new System.Management.Automation.Remoting.Client.WSManNativeApiFacade();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 5857, 5883);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>
        f_1640_6042_6091()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.IntPtr, System.Management.Automation.Remoting.WSManPluginShellSession>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 6042, 6091);
            return return_v;
        }


        object
        f_1640_6120_6132()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1640, 6120, 6132);
            return return_v;
        }

    }
}
